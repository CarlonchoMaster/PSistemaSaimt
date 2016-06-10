Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class DocumentoLogDAO

#Region "Guardar"
    Public Shared Function guardar(ByVal aoDocumentoLog As EEDocumentoLOG) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_DocumentoLog_pa")

                db.AddInParameter(cmd, "docid", DbType.String, aoDocumentoLog.DocId)
                db.AddInParameter(cmd, "docCodigo", DbType.String, aoDocumentoLog.DocCodigo)
                db.AddInParameter(cmd, "docNroProv", DbType.String, aoDocumentoLog.DocNroProv)
                db.AddInParameter(cmd, "docNroGenera", DbType.String, aoDocumentoLog.DocNroGenera)
                db.AddInParameter(cmd, "docfechadoc", DbType.DateTime, aoDocumentoLog.DocFechaDoc)
                db.AddInParameter(cmd, "docfecharec", DbType.DateTime, aoDocumentoLog.DocFechaRec)
                db.AddInParameter(cmd, "tgmovid", DbType.String, aoDocumentoLog.TgMovId)
                db.AddInParameter(cmd, "tgestadoid", DbType.String, aoDocumentoLog.TgEstadoId)
                db.AddInParameter(cmd, "tgsubestadoid", DbType.String, aoDocumentoLog.TgSubEstadoId)
                db.AddInParameter(cmd, "tgtipodocid", DbType.String, aoDocumentoLog.TgTipoDocId)
                db.AddInParameter(cmd, "docNroTDoc", DbType.String, aoDocumentoLog.DocNroTDoc)
                db.AddInParameter(cmd, "docSerieTDoc", DbType.String, aoDocumentoLog.DocSerieTDoc)
                db.AddInParameter(cmd, "docAño", DbType.String, aoDocumentoLog.DocAño)
                'db.AddInParameter(cmd, "tgReferenciaId", DbType.String, aoDocumentoLog.TgReferenciaId)
                db.AddInParameter(cmd, "docNroCertificacion", DbType.String, aoDocumentoLog.DocNroCertificacion)
                db.ExecuteNonQuery(cmd, transaccion)

                If aoDocumentoLog.ListaDocPersonaLOG IsNot Nothing Then
                    For Each frow As EEDocPersonaLOG In aoDocumentoLog.ListaDocPersonaLOG
                        cmd = db.GetStoredProcCommand("Insertar_DocPersonaLOG_pa")
                        db.AddInParameter(cmd, "docId", DbType.String, frow.DocId)
                        db.AddInParameter(cmd, "perId", DbType.String, frow.PerId)
                        db.AddInParameter(cmd, "perOrigen", DbType.String, frow.PerOrigen)
                        db.AddInParameter(cmd, "tgTipoPerId", DbType.String, frow.TgTipoPerId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoDocumentoLog.ListaDocTextLog IsNot Nothing Then
                    For Each frow As EEDocTextLOG In aoDocumentoLog.ListaDocTextLog
                        cmd = db.GetStoredProcCommand("Insertar_DocTextLOG_pa")
                        db.AddInParameter(cmd, "docText", DbType.String, frow.DocText)
                        db.AddInParameter(cmd, "docId", DbType.String, frow.DocId)
                        db.AddInParameter(cmd, "tgTipoTextId", DbType.String, frow.TgTipoTextId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If
                ' Requerimiento Articulo
                If aoDocumentoLog.loReqArtDet IsNot Nothing Then
                    For Each frow As EEDocumentoLOG.EEReqArtDetLOG In aoDocumentoLog.loReqArtDet
                        cmd = db.GetStoredProcCommand("InsertarU_ReqArtDetLOG_pa")
                        db.AddInParameter(cmd, "reqId", DbType.String, frow.ReqId)
                        db.AddInParameter(cmd, "artId", DbType.String, frow.ArtId)
                        db.AddInParameter(cmd, "reqCantidad", DbType.Int16, frow.ReqCantidad)
                        db.AddInParameter(cmd, "tgUMId", DbType.String, frow.TgUMId)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, frow.TgEstadoId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                'Requerimiento Servicio
                If aoDocumentoLog.ListaReqServDet IsNot Nothing Then
                    For Each frow As EEDocumentoLOG.EEReqServDetLOG In aoDocumentoLog.ListaReqServDet
                        cmd = db.GetStoredProcCommand("InsertarU_ReqServDetLOG_pa")
                        db.AddInParameter(cmd, "reqId", DbType.String, frow.ReqId)
                        db.AddInParameter(cmd, "servId", DbType.String, frow.ServId)
                        db.AddInParameter(cmd, "reqObservacion", DbType.String, frow.ReqObservacion)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, frow.TgEstadoId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                'ACTUALIZAR PARTIDA MONTO ACTUAL SERVICIOS
                If aoDocumentoLog.ListaPedServDetLOG IsNot Nothing Then
                    Dim liFila As Integer = 1
                    For Each aoPedServDetLOG As EEDocumentoLOG.EEPedServDetLOG In aoDocumentoLog.ListaPedServDetLOG
                        cmd = db.GetStoredProcCommand("Actualizar_Partida_MontoActual_pa")
                        db.AddOutParameter(cmd, "marca", DbType.String, 1)
                        db.AddInParameter(cmd, "partid", DbType.String, aoPedServDetLOG.PedServDetPartId)
                        db.AddInParameter(cmd, "monto", DbType.Decimal, aoPedServDetLOG.PedServDetCantidad * aoPedServDetLOG.PedServDetPrecio)
                        db.ExecuteNonQuery(cmd, transaccion)

                        Dim lbMarca As String = db.GetParameterValue(cmd, "marca").ToString()
                        If lbMarca = 0 Then
                            Throw New Exception("No Hay Dinero Suficiente Para la Partida Asignada " & aoPedServDetLOG.PedServDetPartId.Substring(4, aoPedServDetLOG.PedServDetPartId.Length - 4) & " - Fila : " & liFila)
                        End If
                        liFila = liFila + 1
                    Next
                End If

                'Pedido Servicios
                If aoDocumentoLog.ListaPedServDetLOG IsNot Nothing Then
                    For Each aoPedServDetLOG As EEDocumentoLOG.EEPedServDetLOG In aoDocumentoLog.ListaPedServDetLOG
                        cmd = db.GetStoredProcCommand("InsertarU_PedServDetLOG_pa")
                        db.AddInParameter(cmd, "pedservdetid", DbType.Int32, aoPedServDetLOG.PedServDetId)
                        db.AddInParameter(cmd, "servid", DbType.String, aoPedServDetLOG.ServId)
                        db.AddInParameter(cmd, "pedid", DbType.String, aoPedServDetLOG.PedId)
                        db.AddInParameter(cmd, "docid", DbType.String, aoPedServDetLOG.DocId)
                        db.AddInParameter(cmd, "tgtiporeqid", DbType.String, aoPedServDetLOG.TgTipoReqId)
                        db.AddInParameter(cmd, "tgmesid", DbType.String, IIf(aoPedServDetLOG.TgMesId = "", Nothing, aoPedServDetLOG.TgMesId))
                        db.AddInParameter(cmd, "pedservdetprecio", DbType.Decimal, aoPedServDetLOG.PedServDetPrecio)
                        db.AddInParameter(cmd, "pedservdetconforme", DbType.Boolean, aoPedServDetLOG.PedServDetConforme)
                        db.AddInParameter(cmd, "pedservdetcantidad", DbType.Int32, aoPedServDetLOG.PedServDetCantidad)
                        db.AddInParameter(cmd, "pedservdetdescripcion", DbType.String, aoPedServDetLOG.PedServDetDescripcion)
                        db.AddInParameter(cmd, "pedservdetcctadebeid", DbType.String, aoPedServDetLOG.PedServDetCCtaDebeId)
                        db.AddInParameter(cmd, "pedservdetcctadebe", DbType.Decimal, aoPedServDetLOG.PedServDetCCtaDebe)
                        db.AddInParameter(cmd, "pedservdetcctahaberid", DbType.String, aoPedServDetLOG.PedServDetCCtaHaberId)
                        db.AddInParameter(cmd, "pedservdetcctahaber", DbType.Decimal, aoPedServDetLOG.PedServDetCCtaHaber)
                        db.AddInParameter(cmd, "pedservdetpartid", DbType.String, aoPedServDetLOG.PedServDetPartId)
                        db.AddInParameter(cmd, "tgfuentefid", DbType.String, aoPedServDetLOG.TgFuenteFId)
                        db.AddInParameter(cmd, "tgmetaid", DbType.String, aoPedServDetLOG.TgMetaId)
                        db.AddInParameter(cmd, "tgactproyid", DbType.String, aoPedServDetLOG.TgActProyId)
                        db.AddInParameter(cmd, "pedservdetcimporte", DbType.Decimal, aoPedServDetLOG.PedServDetCImporte)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                'ACTUALIZAR PARTIDA MONTO ACTUAL ARTICULO
                If aoDocumentoLog.ListaPedArtDetLOG IsNot Nothing Then
                    Dim liFila As Integer = 1
                    For Each aoPedArtDetLOG As EEDocumentoLOG.EEPedArtDetLOG In aoDocumentoLog.ListaPedArtDetLOG
                        cmd = db.GetStoredProcCommand("Actualizar_Partida_MontoActual_pa")
                        db.AddOutParameter(cmd, "marca", DbType.String, 1)
                        db.AddInParameter(cmd, "partid", DbType.String, aoPedArtDetLOG.PedArtDetPartId)
                        db.AddInParameter(cmd, "monto", DbType.Decimal, aoPedArtDetLOG.PedArtDetCantidad * aoPedArtDetLOG.PedArtDetPrecio)
                        db.ExecuteNonQuery(cmd, transaccion)

                        Dim lbMarca As String = db.GetParameterValue(cmd, "marca").ToString()
                        If lbMarca = 0 Then
                            Throw New Exception("No Hay Dinero Suficiente Para la Partida Asignada " & aoPedArtDetLOG.PedArtDetPartId.Substring(4, aoPedArtDetLOG.PedArtDetPartId.Length - 4) & " - Fila : " & liFila)
                        End If
                        liFila = liFila + 1
                    Next
                End If

                'Pedido Articulo
                If aoDocumentoLog.ListaPedArtDetLOG IsNot Nothing Then
                    For Each aoPedArtDetLOG As EEDocumentoLOG.EEPedArtDetLOG In aoDocumentoLog.ListaPedArtDetLOG
                        cmd = db.GetStoredProcCommand("InsertarU_PedArtDetLOG_pa")
                        db.AddInParameter(cmd, "pedartdetid", DbType.Int32, aoPedArtDetLOG.PedArtDetId)
                        db.AddInParameter(cmd, "artid", DbType.String, aoPedArtDetLOG.ArtId)
                        db.AddInParameter(cmd, "tgumorigenid", DbType.String, aoPedArtDetLOG.TgUMIdOrigen)
                        db.AddInParameter(cmd, "tgumid", DbType.String, aoPedArtDetLOG.TgUMId)
                        db.AddInParameter(cmd, "docid", DbType.String, aoPedArtDetLOG.DocId)
                        db.AddInParameter(cmd, "pedid", DbType.String, aoPedArtDetLOG.PedId)
                        db.AddInParameter(cmd, "tgtiporeqid", DbType.String, aoPedArtDetLOG.TgTipoReqId)
                        db.AddInParameter(cmd, "tgmesid", DbType.String, IIf(aoPedArtDetLOG.TgMesId = "", Nothing, RTrim(aoPedArtDetLOG.TgMesId)))
                        db.AddInParameter(cmd, "pedartdetcantidad", DbType.Int32, aoPedArtDetLOG.PedArtDetCantidad)
                        db.AddInParameter(cmd, "pedartdetprecio", DbType.Decimal, aoPedArtDetLOG.PedArtDetPrecio)
                        db.AddInParameter(cmd, "pedartdetconforme", DbType.Boolean, aoPedArtDetLOG.PedArtDetConforme)
                        db.AddInParameter(cmd, "pedartdetcctadebeid", DbType.String, aoPedArtDetLOG.PedArtDetCCtaDebeId)
                        db.AddInParameter(cmd, "pedartdetcctadebe", DbType.Decimal, aoPedArtDetLOG.PedArtDetCCtaDebe)
                        db.AddInParameter(cmd, "pedartdetcctahaberid", DbType.String, aoPedArtDetLOG.PedArtDetCCtaHaberId)
                        db.AddInParameter(cmd, "pedartdetcctahaber", DbType.Decimal, aoPedArtDetLOG.PedArtDetCCtaHaber)
                        db.AddInParameter(cmd, "pedartdetpartid", DbType.String, aoPedArtDetLOG.PedArtDetPartId)
                        db.AddInParameter(cmd, "tgfuentefid", DbType.String, aoPedArtDetLOG.TgFuenteFId)
                        db.AddInParameter(cmd, "tgmetaid", DbType.String, aoPedArtDetLOG.TgMetaId)
                        db.AddInParameter(cmd, "tgactproyid", DbType.String, aoPedArtDetLOG.TgActProyId)
                        db.AddInParameter(cmd, "pedartdetcimporte", DbType.Decimal, aoPedArtDetLOG.PedArtDetCImporte)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, aoPedArtDetLOG.TgEstadoId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                'Cdro Necesidad Servicio
                If aoDocumentoLog.loCdroNecServDet IsNot Nothing Then
                    For Each frow As EEDocumentoLOG.EECdroNecesidadServDetLOG In aoDocumentoLog.loCdroNecServDet
                        cmd = db.GetStoredProcCommand("Insertar_CdroNecesidadServDetLOG_pa")
                        db.AddInParameter(cmd, "servid", DbType.String, frow.ServId)
                        db.AddInParameter(cmd, "cdroNecServDetDescripcion", DbType.String, frow.CdroNecServDetDescripcion)
                        db.AddInParameter(cmd, "tgmesid", DbType.String, frow.TgMesId)
                        db.AddInParameter(cmd, "cdroNecServDetGastoEst", DbType.Decimal, frow.CdroNecServDetGastoEst)
                        db.AddInParameter(cmd, "cdroNecServDetCantidad", DbType.Int32, frow.CdroNecServDetCantidad)
                        db.AddInParameter(cmd, "cdroNecServDetActivo", DbType.String, frow.CdroNecServDetActivo)
                        db.AddInParameter(cmd, "cdroNecServId", DbType.String, frow.CdroNecServId)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, frow.OTgEstado.TgCodigo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If
                'Cdro Necesidad Articulo
                If aoDocumentoLog.loCdroNecArtDet IsNot Nothing Then
                    For Each frow As EEDocumentoLOG.EECdroNecesidadArtDetLOG In aoDocumentoLog.loCdroNecArtDet
                        cmd = db.GetStoredProcCommand("Insertar_CdroNecesidadArtDetLOG_pa")
                        db.AddInParameter(cmd, "artid", DbType.String, frow.ArtId)
                        db.AddInParameter(cmd, "tgumid", DbType.String, frow.TgUMId)
                        db.AddInParameter(cmd, "tgmesid", DbType.String, frow.TgMesId)
                        db.AddInParameter(cmd, "cdroNecArtDetGastoEst", DbType.Decimal, frow.CdroNecArtDetGastoEst)
                        db.AddInParameter(cmd, "cdroNecArtDetCantidad", DbType.Int32, frow.CdroNecArtDetCantidad)
                        db.AddInParameter(cmd, "cdroNecArtDetActivo", DbType.String, frow.CdroNecArtDetActivo)
                        db.AddInParameter(cmd, "cdroNecArtId", DbType.String, frow.CdroNecArtId)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, frow.OTgEstado.TgCodigo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If
                ' Nota de Credito Detalle
                If aoDocumentoLog.ListaNotaCredArtDetLOG IsNot Nothing Then
                    For Each aoNotaCredArtDetLOG As EEDocumentoLOG.EENotaCredArtDetLOG In aoDocumentoLog.ListaNotaCredArtDetLOG
                        cmd = db.GetStoredProcCommand("InsertarU_NotaCredArtDetLOG_pa")
                        db.AddInParameter(cmd, "notcredid", DbType.String, aoNotaCredArtDetLOG.NotCredId)
                        db.AddInParameter(cmd, "artid", DbType.String, aoNotaCredArtDetLOG.ArtId)
                        db.AddInParameter(cmd, "tgumid", DbType.String, aoNotaCredArtDetLOG.TgUMId)
                        db.AddInParameter(cmd, "notcredcantidad", DbType.Int32, aoNotaCredArtDetLOG.NotCredCantidad)
                        db.AddInParameter(cmd, "notcredpreciounitario", DbType.Decimal, aoNotaCredArtDetLOG.NotCredPrecioUnitario)
                        db.AddInParameter(cmd, "notcredpreciototal", DbType.Decimal, aoNotaCredArtDetLOG.NotCredPrecioTotal)
                        db.AddInParameter(cmd, "notcredregularizado", DbType.Boolean, aoNotaCredArtDetLOG.NotCredRegularizado)
                        db.AddInParameter(cmd, "tgtiporeqid", DbType.String, aoNotaCredArtDetLOG.TgTipoReqId)
                        db.AddInParameter(cmd, "docid", DbType.String, aoNotaCredArtDetLOG.DocId)
                        db.AddInParameter(cmd, "tgmesid", DbType.String, RTrim(aoNotaCredArtDetLOG.TgMesId))
                        db.AddInParameter(cmd, "notcreddetid", DbType.Int32, aoNotaCredArtDetLOG.NotCredDetId)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, aoNotaCredArtDetLOG.OTgEstado.TgCodigo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If
                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Guardar Articulo => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function
#End Region

#Region "Actualizar"
    Public Shared Function actualizar(aoDocumentoLog As EEDocumentoLOG) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_DocumentoLOG_pa")
                db.AddInParameter(cmd, "docid", DbType.String, aoDocumentoLog.DocId)
                db.AddInParameter(cmd, "docCodigo", DbType.String, aoDocumentoLog.DocCodigo)
                db.AddInParameter(cmd, "docNroProv", DbType.String, aoDocumentoLog.DocNroProv)
                db.AddInParameter(cmd, "docNroGenera", DbType.String, aoDocumentoLog.DocNroGenera)
                db.AddInParameter(cmd, "docfechadoc", DbType.DateTime, aoDocumentoLog.DocFechaDoc)
                db.AddInParameter(cmd, "tgmovid", DbType.String, aoDocumentoLog.TgMovId)
                db.AddInParameter(cmd, "tgestadoid", DbType.String, aoDocumentoLog.TgEstadoId)
                db.AddInParameter(cmd, "tgsubestadoid", DbType.String, aoDocumentoLog.TgSubEstadoId)
                db.AddInParameter(cmd, "tgtipodocid", DbType.String, aoDocumentoLog.TgTipoDocId)
                db.AddInParameter(cmd, "docNroTDoc", DbType.String, aoDocumentoLog.DocNroTDoc)
                db.AddInParameter(cmd, "docSerieTDoc", DbType.String, aoDocumentoLog.DocSerieTDoc)
                db.AddInParameter(cmd, "docAño", DbType.String, aoDocumentoLog.DocAño)
                ' db.AddInParameter(cmd, "tgReferenciaId", DbType.String, aoDocumentoLog.TgReferenciaId)
                db.AddInParameter(cmd, "docNroCertificacion", DbType.String, aoDocumentoLog.DocNroCertificacion)
                db.ExecuteNonQuery(cmd, transaccion)

                If aoDocumentoLog.ListaDocTextLog IsNot Nothing Then
                    For Each frow As EEDocTextLOG In aoDocumentoLog.ListaDocTextLog
                        cmd = db.GetStoredProcCommand("Actualizar_DocTextLOG_pa")
                        db.AddInParameter(cmd, "docText", DbType.String, frow.DocText)
                        db.AddInParameter(cmd, "docId", DbType.String, frow.DocId)
                        db.AddInParameter(cmd, "tgTipoTextId", DbType.String, frow.TgTipoTextId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoDocumentoLog.ListaDocPersonaLOG IsNot Nothing Then
                    For Each frow As EEDocPersonaLOG In aoDocumentoLog.ListaDocPersonaLOG
                        cmd = db.GetStoredProcCommand("Actualizar_DocPersonaLOG_pa")
                        db.AddInParameter(cmd, "docId", DbType.String, frow.DocId)
                        db.AddInParameter(cmd, "perId", DbType.String, frow.PerId)
                        db.AddInParameter(cmd, "perOrigen", DbType.String, frow.PerOrigen)
                        db.AddInParameter(cmd, "tgTipoPerId", DbType.String, frow.TgTipoPerId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                ' Eliminar Requerimiento Servicio
                If aoDocumentoLog.loReqServDetEliminados IsNot Nothing Then
                    For Each frow As String In aoDocumentoLog.loReqServDetEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_ReqServDetLOG_pa")
                        db.AddInParameter(cmd, "reqId", DbType.String, frow.Substring(1, 7))
                        db.AddInParameter(cmd, "servId", DbType.String, frow.Substring(7, 4))
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                ' Actualizar Requerimiento Servicio
                If aoDocumentoLog.ListaReqServDet IsNot Nothing Then
                    For Each frow As EEDocumentoLOG.EEReqServDetLOG In aoDocumentoLog.ListaReqServDet
                        cmd = db.GetStoredProcCommand("InsertarU_ReqServDetLOG_pa")
                        db.AddInParameter(cmd, "reqId", DbType.String, frow.ReqId)
                        db.AddInParameter(cmd, "servId", DbType.String, frow.ServId)
                        db.AddInParameter(cmd, "reqObservacion", DbType.String, frow.ReqObservacion)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, frow.TgEstadoId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                ' Eliminar Requerimiento Articulo
                If aoDocumentoLog.loReqArtDetEliminados IsNot Nothing Then
                    For Each frow As String In aoDocumentoLog.loReqArtDetEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_ReqArtDetLOG_pa")
                        db.AddInParameter(cmd, "reqId", DbType.String, frow.Substring(0, 8))
                        db.AddInParameter(cmd, "artId", DbType.String, frow.Substring(8, 6))
                        db.AddInParameter(cmd, "tgUMId", DbType.String, frow.Substring(14, 3))
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                ' Actualizar Requerimiento Articulo
                If aoDocumentoLog.loReqArtDet IsNot Nothing Then
                    For Each frow As EEDocumentoLOG.EEReqArtDetLOG In aoDocumentoLog.loReqArtDet
                        cmd = db.GetStoredProcCommand("InsertarU_ReqArtDetLOG_pa")
                        db.AddInParameter(cmd, "reqId", DbType.String, frow.ReqId)
                        db.AddInParameter(cmd, "artId", DbType.String, frow.ArtId)
                        db.AddInParameter(cmd, "reqCantidad", DbType.Int16, frow.ReqCantidad)
                        db.AddInParameter(cmd, "tgUMId", DbType.String, frow.TgUMId)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, frow.TgEstadoId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                ' Eliminar CdroNecesidad Servicio
                If aoDocumentoLog.loCdroNecServDetEliminados IsNot Nothing Then
                    For Each frow As String In aoDocumentoLog.loCdroNecServDetEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_CdroNecesidadServDetLOG_pa")
                        db.AddInParameter(cmd, "servId", DbType.String, frow.Substring(0, 4))
                        db.AddInParameter(cmd, "tgMesId", DbType.String, RTrim(frow.Substring(4, 2)))
                        db.AddInParameter(cmd, "cdroNecServId", DbType.String, frow.Substring(6, 8))
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                ' Actualizar CdroNecesidad Servicio
                If aoDocumentoLog.loCdroNecServDet IsNot Nothing Then
                    For Each aoCdroNecesidadServDetLOG As EEDocumentoLOG.EECdroNecesidadServDetLOG In aoDocumentoLog.loCdroNecServDet
                        cmd = db.GetStoredProcCommand("Insertar_CdroNecesidadServDetLOG_pa")
                        db.AddInParameter(cmd, "servid", DbType.String, aoCdroNecesidadServDetLOG.ServId)
                        db.AddInParameter(cmd, "cdroNecServDetDescripcion", DbType.String, aoCdroNecesidadServDetLOG.CdroNecServDetDescripcion)
                        db.AddInParameter(cmd, "tgmesid", DbType.String, RTrim(aoCdroNecesidadServDetLOG.TgMesId))
                        db.AddInParameter(cmd, "cdroNecServDetGastoEst", DbType.Decimal, aoCdroNecesidadServDetLOG.CdroNecServDetGastoEst)
                        db.AddInParameter(cmd, "cdroNecServDetCantidad", DbType.Int32, aoCdroNecesidadServDetLOG.CdroNecServDetCantidad)
                        db.AddInParameter(cmd, "cdroNecServDetActivo", DbType.String, aoCdroNecesidadServDetLOG.CdroNecServDetActivo)
                        db.AddInParameter(cmd, "cdroNecServId", DbType.String, aoCdroNecesidadServDetLOG.CdroNecServId)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, aoCdroNecesidadServDetLOG.OTgEstado.TgCodigo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                ' Eliminar CdroNecesidad Articulo
                If aoDocumentoLog.loCdroNecArtDetEliminados IsNot Nothing Then
                    For Each frow As String In aoDocumentoLog.loCdroNecArtDetEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_CdroNecesidadArtDetLOG_pa")
                        db.AddInParameter(cmd, "artId", DbType.String, frow.Substring(0, 6))
                        db.AddInParameter(cmd, "tgUMId", DbType.String, frow.Substring(6, 3))
                        db.AddInParameter(cmd, "tgMesId", DbType.String, RTrim(frow.Substring(9, 2)))
                        db.AddInParameter(cmd, "cdroNecArtId", DbType.String, frow.Substring(11, 8))
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                ' Actualizar CdroNecesidad Articulo
                If aoDocumentoLog.loCdroNecArtDet IsNot Nothing Then
                    For Each frow As EEDocumentoLOG.EECdroNecesidadArtDetLOG In aoDocumentoLog.loCdroNecArtDet
                        cmd = db.GetStoredProcCommand("Insertar_CdroNecesidadArtDetLOG_pa")
                        db.AddInParameter(cmd, "artid", DbType.String, frow.ArtId)
                        db.AddInParameter(cmd, "tgumid", DbType.String, frow.TgUMId)
                        db.AddInParameter(cmd, "tgmesid", DbType.String, RTrim(frow.TgMesId))
                        db.AddInParameter(cmd, "cdroNecArtDetGastoEst", DbType.Decimal, frow.CdroNecArtDetGastoEst)
                        db.AddInParameter(cmd, "cdroNecArtDetCantidad", DbType.Int32, frow.CdroNecArtDetCantidad)
                        db.AddInParameter(cmd, "cdroNecArtDetActivo", DbType.String, frow.CdroNecArtDetActivo)
                        db.AddInParameter(cmd, "cdroNecArtId", DbType.String, frow.CdroNecArtId)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, frow.OTgEstado.TgCodigo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                'Pedido Servicios
                If aoDocumentoLog.loPedServDetEliminados IsNot Nothing Then
                    For Each frow As String In aoDocumentoLog.loPedServDetEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_PedServDetLOG_pa")
                        db.AddInParameter(cmd, "pedServDetId", DbType.String, frow.ToString)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoDocumentoLog.ListaPedServDetLOG IsNot Nothing Then
                    For Each aoPedServDetLOG As EEDocumentoLOG.EEPedServDetLOG In aoDocumentoLog.ListaPedServDetLOG
                        cmd = db.GetStoredProcCommand("InsertarU_PedServDetLOG_pa")
                        db.AddInParameter(cmd, "pedservdetid", DbType.Int32, aoPedServDetLOG.PedServDetId)
                        db.AddInParameter(cmd, "servid", DbType.String, aoPedServDetLOG.ServId)
                        db.AddInParameter(cmd, "pedid", DbType.String, aoPedServDetLOG.PedId)
                        db.AddInParameter(cmd, "docid", DbType.String, aoPedServDetLOG.DocId)
                        db.AddInParameter(cmd, "tgtiporeqid", DbType.String, aoPedServDetLOG.TgTipoReqId)
                        db.AddInParameter(cmd, "tgmesid", DbType.String, IIf(aoPedServDetLOG.TgMesId = "", Nothing, RTrim(aoPedServDetLOG.TgMesId)))
                        db.AddInParameter(cmd, "pedservdetprecio", DbType.Decimal, aoPedServDetLOG.PedServDetPrecio)
                        db.AddInParameter(cmd, "pedservdetconforme", DbType.Boolean, aoPedServDetLOG.PedServDetConforme)
                        db.AddInParameter(cmd, "pedservdetcantidad", DbType.Int32, aoPedServDetLOG.PedServDetCantidad)
                        db.AddInParameter(cmd, "pedservdetdescripcion", DbType.String, aoPedServDetLOG.PedServDetDescripcion)
                        db.AddInParameter(cmd, "pedservdetcctadebeid", DbType.String, aoPedServDetLOG.PedServDetCCtaDebeId)
                        db.AddInParameter(cmd, "pedservdetcctadebe", DbType.Decimal, aoPedServDetLOG.PedServDetCCtaDebe)
                        db.AddInParameter(cmd, "pedservdetcctahaberid", DbType.String, aoPedServDetLOG.PedServDetCCtaHaberId)
                        db.AddInParameter(cmd, "pedservdetcctahaber", DbType.Decimal, aoPedServDetLOG.PedServDetCCtaHaber)
                        db.AddInParameter(cmd, "pedservdetpartid", DbType.String, aoPedServDetLOG.PedServDetPartId)
                        db.AddInParameter(cmd, "tgfuentefid", DbType.String, aoPedServDetLOG.TgFuenteFId)
                        db.AddInParameter(cmd, "tgmetaid", DbType.String, aoPedServDetLOG.TgMetaId)
                        db.AddInParameter(cmd, "tgactproyid", DbType.String, aoPedServDetLOG.TgActProyId)
                        db.AddInParameter(cmd, "pedservdetcimporte", DbType.Decimal, aoPedServDetLOG.PedServDetCImporte)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoDocumentoLog.loPedArtDetEliminados IsNot Nothing Then
                    For Each frow As String In aoDocumentoLog.loPedArtDetEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_PedArtDetLOG_pa")
                        db.AddInParameter(cmd, "PedArtDetId", DbType.String, frow.ToString)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoDocumentoLog.ListaPedArtDetLOG IsNot Nothing Then
                    For Each aoPedArtDetLOG As EEDocumentoLOG.EEPedArtDetLOG In aoDocumentoLog.ListaPedArtDetLOG
                        cmd = db.GetStoredProcCommand("InsertarU_PedArtDetLOG_pa")
                        db.AddInParameter(cmd, "pedartdetid", DbType.Int32, aoPedArtDetLOG.PedArtDetId)
                        db.AddInParameter(cmd, "artid", DbType.String, aoPedArtDetLOG.ArtId)
                        db.AddInParameter(cmd, "tgumorigenid", DbType.String, aoPedArtDetLOG.TgUMIdOrigen)
                        db.AddInParameter(cmd, "tgumid", DbType.String, aoPedArtDetLOG.TgUMId)
                        db.AddInParameter(cmd, "docid", DbType.String, aoPedArtDetLOG.DocId)
                        db.AddInParameter(cmd, "pedid", DbType.String, aoPedArtDetLOG.PedId)
                        db.AddInParameter(cmd, "tgtiporeqid", DbType.String, aoPedArtDetLOG.TgTipoReqId)
                        db.AddInParameter(cmd, "tgmesid", DbType.String, IIf(aoPedArtDetLOG.TgMesId = "", Nothing, RTrim(aoPedArtDetLOG.TgMesId)))
                        db.AddInParameter(cmd, "pedartdetcantidad", DbType.Int32, aoPedArtDetLOG.PedArtDetCantidad)
                        db.AddInParameter(cmd, "pedartdetprecio", DbType.Decimal, aoPedArtDetLOG.PedArtDetPrecio)
                        db.AddInParameter(cmd, "pedartdetconforme", DbType.Boolean, aoPedArtDetLOG.PedArtDetConforme)
                        db.AddInParameter(cmd, "pedartdetcctadebeid", DbType.String, aoPedArtDetLOG.PedArtDetCCtaDebeId)
                        db.AddInParameter(cmd, "pedartdetcctadebe", DbType.Decimal, aoPedArtDetLOG.PedArtDetCCtaDebe)
                        db.AddInParameter(cmd, "pedartdetcctahaberid", DbType.String, aoPedArtDetLOG.PedArtDetCCtaHaberId)
                        db.AddInParameter(cmd, "pedartdetcctahaber", DbType.Decimal, aoPedArtDetLOG.PedArtDetCCtaHaber)
                        db.AddInParameter(cmd, "pedartdetpartid", DbType.String, aoPedArtDetLOG.PedArtDetPartId)
                        db.AddInParameter(cmd, "tgfuentefid", DbType.String, aoPedArtDetLOG.TgFuenteFId)
                        db.AddInParameter(cmd, "tgmetaid", DbType.String, aoPedArtDetLOG.TgMetaId)
                        db.AddInParameter(cmd, "tgactproyid", DbType.String, aoPedArtDetLOG.TgActProyId)
                        db.AddInParameter(cmd, "pedartdetcimporte", DbType.Decimal, aoPedArtDetLOG.PedArtDetCImporte)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, aoPedArtDetLOG.TgEstadoId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoDocumentoLog.ListaNotaCredArtDetEliminadosLOG IsNot Nothing Then
                    For Each frow As String In aoDocumentoLog.ListaNotaCredArtDetEliminadosLOG
                        cmd = db.GetStoredProcCommand("Eliminar_NotaCredArtDetLOG_pa")
                        db.AddInParameter(cmd, "NotCredDetId", DbType.String, frow)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If
                ' Actualiza Nota de Credito Detalle
                If aoDocumentoLog.ListaNotaCredArtDetLOG IsNot Nothing Then
                    For Each aoNotaCredArtDetLOG As EEDocumentoLOG.EENotaCredArtDetLOG In aoDocumentoLog.ListaNotaCredArtDetLOG
                        cmd = db.GetStoredProcCommand("InsertarU_NotaCredArtDetLOG_pa")
                        db.AddInParameter(cmd, "notcredid", DbType.String, aoNotaCredArtDetLOG.NotCredId)
                        db.AddInParameter(cmd, "artid", DbType.String, aoNotaCredArtDetLOG.ArtId)
                        db.AddInParameter(cmd, "tgumid", DbType.String, aoNotaCredArtDetLOG.TgUMId)
                        db.AddInParameter(cmd, "notcredcantidad", DbType.Int32, aoNotaCredArtDetLOG.NotCredCantidad)
                        db.AddInParameter(cmd, "notcredpreciounitario", DbType.Decimal, aoNotaCredArtDetLOG.NotCredPrecioUnitario)
                        db.AddInParameter(cmd, "notcredpreciototal", DbType.Decimal, aoNotaCredArtDetLOG.NotCredPrecioTotal)
                        db.AddInParameter(cmd, "notcredregularizado", DbType.Boolean, aoNotaCredArtDetLOG.NotCredRegularizado)
                        db.AddInParameter(cmd, "tgtiporeqid", DbType.String, aoNotaCredArtDetLOG.TgTipoReqId)
                        db.AddInParameter(cmd, "docid", DbType.String, aoNotaCredArtDetLOG.DocId)
                        db.AddInParameter(cmd, "tgmesid", DbType.String, RTrim(aoNotaCredArtDetLOG.TgMesId))
                        db.AddInParameter(cmd, "notcreddetid", DbType.Int32, aoNotaCredArtDetLOG.NotCredDetId)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.String, aoNotaCredArtDetLOG.OTgEstado.TgCodigo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If
                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Actualizar Documento Logistica => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function
#End Region

End Class
