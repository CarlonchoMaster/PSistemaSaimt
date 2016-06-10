Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class OrdenServicioDAS
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal asAnio As Int16) As List(Of EEOrdenServicio)
        Dim ListaOrdenServicio As List(Of EEOrdenServicio) = Nothing
        Dim loOrdenServicio As EEOrdenServicio = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenServicio_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            db.AddInParameter(cmd, "anio", DbType.Int32, asAnio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenServicio Is Nothing Then
                    ListaOrdenServicio = New List(Of EEOrdenServicio)()
                End If

                loOrdenServicio = New EEOrdenServicio()

                loOrdenServicio.OrdId = dr("OrdId").ToString()
                loOrdenServicio.OrdNro = dr("OrdNro").ToString()
                loOrdenServicio.OrdFechaDoc = IIf(IsDBNull(dr("OrdFechaDoc")), Nothing, dr("OrdFechaDoc"))
                loOrdenServicio.TgEstado = dr("tgEstado").ToString()
                ListaOrdenServicio.Add(loOrdenServicio)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenServicio Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenServicio
    End Function

    Public Shared Function ListarxOrdId(ByVal ordId As [String]) As EEOrdenServicio
        Dim loOrdenServicio As EEOrdenServicio = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenServicio_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, ordId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loOrdenServicio = New EEOrdenServicio()
                loOrdenServicio.OrdId = dr("OrdId").ToString()
                loOrdenServicio.OrdNro = dr("OrdNro").ToString()
                loOrdenServicio.OrdFechaDoc = IIf(IsDBNull(dr("OrdFechaDoc")), Nothing, dr("OrdFechaDoc"))
                loOrdenServicio.TgEstadoId = dr("TgEstadoId").ToString()
                loOrdenServicio.TgCompPagoId = dr("TgCompPagoId").ToString()
                loOrdenServicio.OrdNroCompPago = dr("OrdNroCompPago").ToString()
                loOrdenServicio.PerProvId = dr("PerProvId").ToString()
                loOrdenServicio.PerProv = dr("PerProv").ToString()
                loOrdenServicio.OrdRefDoc = dr("OrdRefDoc").ToString()
                loOrdenServicio.PlanCDDescripcion = dr("planCDDescripcion").ToString()
                loOrdenServicio.TgCuentaDebeId = dr("TgCuentaDebeId").ToString()
                loOrdenServicio.TgCuentaDebe = Convert.ToDecimal(dr("TgCuentaDebe").ToString())
                loOrdenServicio.PlanCHDescripcion = dr("planCHDescripcion").ToString()
                loOrdenServicio.TgCuentaHaberId = dr("TgCuentaHaberId").ToString()
                loOrdenServicio.TgCuentaHaber = Convert.ToDecimal(dr("TgCuentaHaber").ToString())
                loOrdenServicio.OrdParIGV = Convert.ToDecimal(dr("OrdParIGV").ToString())
                loOrdenServicio.CerId = dr("cerId").ToString()
                loOrdenServicio.CerNro = dr("cerNro").ToString()
                loOrdenServicio.CerValTotal = dr("cerValTotal").ToString()
                If IsDBNull(dr("cerValQuedan")) = False Then
                    loOrdenServicio.CerValQuedan = Convert.ToDecimal(dr("cerValQuedan").ToString)
                End If
                loOrdenServicio.CerCompId = dr("CerCompId").ToString()
                loOrdenServicio.CerCompNro = dr("cerCompNro").ToString()

                If IsDBNull(dr("cerCompValTotal")) = False Then
                    loOrdenServicio.CerCompValTotal = Convert.ToDecimal(dr("cerCompValTotal").ToString)
                End If
                If IsDBNull(dr("cerCompValQuedan")) = False Then
                    loOrdenServicio.CerCompValQuedan = Convert.ToDecimal(dr("cerCompValQuedan").ToString)
                End If
                If IsDBNull(dr("CerValUtilizado")) = False Then
                    loOrdenServicio.CerValUtilizado = Convert.ToDecimal(dr("CerValUtilizado").ToString)
                End If
                If IsDBNull(dr("CerCompValUtilizado")) = False Then
                    loOrdenServicio.CerCompValUtilizado = Convert.ToDecimal(dr("CerCompValUtilizado").ToString)
                End If
                If IsDBNull(dr("OrdSaldoI")) = False Then
                    loOrdenServicio.OrdSaldoI = Convert.ToDecimal(dr("OrdSaldoI").ToString())
                End If
                If IsDBNull(dr("OrdSaldoF")) = False Then
                    loOrdenServicio.OrdSaldoF = Convert.ToDecimal(dr("OrdSaldoF").ToString())
                End If
                loOrdenServicio.PartId = dr("PartId").ToString()
                loOrdenServicio.PartNombre = dr("PartNombre").ToString()
                loOrdenServicio.TgFFinancieraId = dr("TgFFinancieraId").ToString()
                loOrdenServicio.TgMetaId = dr("TgMetaId").ToString()
                loOrdenServicio.TgActProyId = dr("TgActProyId").ToString()
                loOrdenServicio.OrdImporte = Convert.ToDecimal(dr("OrdImporte").ToString())
                loOrdenServicio.OrdSubTotal = Convert.ToDecimal(dr("OrdSubTotal").ToString())
                loOrdenServicio.OrdImporteIGV = Convert.ToDecimal(dr("OrdImporteIGV").ToString())
                loOrdenServicio.ordRta4taTotal = Convert.ToDecimal(dr("ordRta4taTotal").ToString())
                loOrdenServicio.OrdAjusteTotal = Convert.ToDecimal(dr("OrdAjusteTotal").ToString())
                loOrdenServicio.OrdTotal = Convert.ToDecimal(dr("OrdTotal").ToString())
            End If
        Catch ex As Exception
            Throw New Exception("Listar OrdenServicio x ordId => " & ex.Message, ex)
        End Try
        Return loOrdenServicio
    End Function
    Public Shared Function listarAreaRefXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenServicio.EEOrdenServicioAreaRef)
        Dim ListaOrdenServicioAreaRef As List(Of EEOrdenServicio.EEOrdenServicioAreaRef) = Nothing
        Dim loOrdenServicioAreaRef As EEOrdenServicio.EEOrdenServicioAreaRef = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenServicioAreasRef_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenServicioAreaRef Is Nothing Then
                    ListaOrdenServicioAreaRef = New List(Of EEOrdenServicio.EEOrdenServicioAreaRef)()
                End If
                loOrdenServicioAreaRef = New EEOrdenServicio.EEOrdenServicioAreaRef()
                loOrdenServicioAreaRef.tgAreaId = dr("tgAreaId").ToString()
                ListaOrdenServicioAreaRef.Add(loOrdenServicioAreaRef)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenServicioAreaRef XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenServicioAreaRef
    End Function


    Public Shared Function listarDocRefXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenServicio.EEOrdenServicioDocRef)
        Dim ListaOrdenServicioDocRef As List(Of EEOrdenServicio.EEOrdenServicioDocRef) = Nothing
        Dim loOrdenServicioDocRef As EEOrdenServicio.EEOrdenServicioDocRef = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenServicioDocRef_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenServicioDocRef Is Nothing Then
                    ListaOrdenServicioDocRef = New List(Of EEOrdenServicio.EEOrdenServicioDocRef)()
                End If
                loOrdenServicioDocRef = New EEOrdenServicio.EEOrdenServicioDocRef()
                loOrdenServicioDocRef.documento = dr("documento").ToString()
                loOrdenServicioDocRef.año = dr("año").ToString()
                loOrdenServicioDocRef.area = dr("area").ToString()
                ListaOrdenServicioDocRef.Add(loOrdenServicioDocRef)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenServicioDocRef XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenServicioDocRef
    End Function

    Public Shared Function listarDetalleXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenServicio.EEOrdenServicioDet)
        Dim ListaOrdenServicioDet As List(Of EEOrdenServicio.EEOrdenServicioDet) = Nothing
        Dim loOrdenServicioDet As EEOrdenServicio.EEOrdenServicioDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenServicioDet_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenServicioDet Is Nothing Then
                    ListaOrdenServicioDet = New List(Of EEOrdenServicio.EEOrdenServicioDet)()
                End If

                loOrdenServicioDet = New EEOrdenServicio.EEOrdenServicioDet()

                loOrdenServicioDet.OrdDetId = dr("ordDetId").ToString()
                loOrdenServicioDet.OrdId = dr("ordId").ToString()
                loOrdenServicioDet.TgCatServId = dr("tgCatServId").ToString()
                loOrdenServicioDet.TgCatServ = dr("tgCatServ").ToString()
                loOrdenServicioDet.OrdDetDescripcion = dr("ordDetDescripcion").ToString()
                loOrdenServicioDet.ordDetObservacion = dr("ordDetObservacion").ToString()
                loOrdenServicioDet.OrdDetPrecio = CDbl(dr("ordDetPrecio"))
                loOrdenServicioDet.ordDetIgv = CDbl(dr("ordDetIgv"))
                loOrdenServicioDet.ordDetRta4ta = CDbl(dr("ordDetRta4ta"))
                loOrdenServicioDet.tgTipoAjusteId = dr("tgTipoAjusteId").ToString()
                loOrdenServicioDet.tgTipoAjuste = dr("tgTipoAjuste").ToString()
                loOrdenServicioDet.OrdDetAjuste = CDbl(dr("ordDetAjuste"))
                loOrdenServicioDet.OrdDetMontoCertUtl1 = CDbl(dr("OrdDetMontoCertUtl1"))
                loOrdenServicioDet.OrdDetMontoCertUtl2 = CDbl(dr("OrdDetMontoCertUtl2"))
                ListaOrdenServicioDet.Add(loOrdenServicioDet)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenServicioDet XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenServicioDet
    End Function

    Public Shared Function generaCodigo() As String
        Dim artId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_OrdenServicio_OrdId")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                artId = dr("ordId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Id Orden Servicio => " + ex.Message, ex)
        End Try
        Return artId
    End Function

    Public Shared Function generaCodigoSAIMT() As String
        Dim servCodigo As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_OrdenServicio_OrdNro")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                servCodigo = dr("ordNro").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Codigo Orden Servicio => " + ex.Message, ex)
        End Try
        Return servCodigo
    End Function

    Public Shared Function listarGrupoPartidaXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenServicio.EEOrdenServicioGrupoPartidas)
        Dim ListaOrdenServicioGrupoPartida As List(Of EEOrdenServicio.EEOrdenServicioGrupoPartidas) = Nothing
        Dim loOrdenServicioGrupoPartida As EEOrdenServicio.EEOrdenServicioGrupoPartidas = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenServicioGrupoPartida_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenServicioGrupoPartida Is Nothing Then
                    ListaOrdenServicioGrupoPartida = New List(Of EEOrdenServicio.EEOrdenServicioGrupoPartidas)()
                End If

                loOrdenServicioGrupoPartida = New EEOrdenServicio.EEOrdenServicioGrupoPartidas()

                loOrdenServicioGrupoPartida.cerGrupoParId = dr("cerGrupoParId").ToString()
                loOrdenServicioGrupoPartida.cerGrupoParValImporte = dr("cerGrupoParValImporte").ToString()
                loOrdenServicioGrupoPartida.Partida = dr("partNombre").ToString()
                loOrdenServicioGrupoPartida.Certificacion = dr("certificacion").ToString()
                loOrdenServicioGrupoPartida.CerId = dr("cerId").ToString()
                ListaOrdenServicioGrupoPartida.Add(loOrdenServicioGrupoPartida)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenServicioGrupoPartida XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenServicioGrupoPartida
    End Function
End Class
