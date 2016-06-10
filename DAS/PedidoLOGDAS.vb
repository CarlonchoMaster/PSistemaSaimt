Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class PedidoLOGDAS
    Public Shared Function listarPedidoArtCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocumentoLOG)
        Dim ListaRequerimientoLog As List(Of EEDocumentoLOG) = Nothing
        Dim loPedidoLog As EEDocumentoLOG = Nothing
        Dim loPerProveedor As EEDocPersonaLOG = Nothing
        Dim loPerGirarA As EEDocPersonaLOG = Nothing
        Dim ListaPersona As List(Of EEDocPersonaLOG) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_PedidoArtLOG_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaRequerimientoLog Is Nothing Then
                    ListaRequerimientoLog = New List(Of EEDocumentoLOG)()
                End If
                ListaPersona = New List(Of EEDocPersonaLOG)()
                loPedidoLog = New EEDocumentoLOG()
                loPerProveedor = New EEDocPersonaLOG()
                loPerGirarA = New EEDocPersonaLOG()
                loPedidoLog.DocId = dr("DocId").ToString()
                loPedidoLog.DocCodigo = dr("docCodigo").ToString()
                loPerProveedor.Persona = dr("perProveedor").ToString()
                ListaPersona.Add(loPerProveedor)
                loPerGirarA.Persona = dr("perGirarA").ToString()
                ListaPersona.Add(loPerGirarA)
                loPedidoLog.ListaDocPersonaLOG = ListaPersona
                loPedidoLog.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))

                ListaRequerimientoLog.Add(loPedidoLog)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Pedido Articulo Criterio => " + ex.Message, ex)
        End Try
        Return ListaRequerimientoLog
    End Function

    Public Shared Function listarPedidoArtXDocId(ByVal asDocId As String) As EEDocumentoLOG
        Dim loPedidoLog As EEDocumentoLOG = Nothing
        Dim loDocGeneral As EEDocumentoLOG = Nothing
        Dim loPedidoDetalleLog As EEDocumentoLOG.EEPedArtDetLOG = Nothing
        Dim loArticulo As EEArticulo = Nothing
        Dim loPerProveedor As EEDocPersonaLOG = Nothing
        Dim loPerGirarA As EEDocPersonaLOG = Nothing
        Dim ListaPersona As List(Of EEDocPersonaLOG) = Nothing
        Dim dr As IDataReader = Nothing
        Dim drPedidoDetalle As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_PedidoArtLOG_XDocId_pa")
            db.AddInParameter(cmd, "docid", DbType.String, asDocId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                ListaPersona = New List(Of EEDocPersonaLOG)()
                loPedidoLog = New EEDocumentoLOG()
                loPerProveedor = New EEDocPersonaLOG
                loPerGirarA = New EEDocPersonaLOG
                loPedidoLog.DocId = dr("DocId").ToString()
                loPedidoLog.DocCodigo = dr("docCodigo").ToString()
                loPerProveedor.PerId = dr("provId").ToString()
                loPerProveedor.Persona = dr("provProveedor").ToString()
                loPerProveedor.TipoDocumento = dr("provTipoDoc").ToString()
                loPerProveedor.NroDoc = dr("provNroDoc").ToString()
                loPerProveedor.Direccion = dr("provDireccion").ToString()
                ListaPersona.Add(loPerProveedor)
                loPerGirarA.PerId = dr("perGirarAId").ToString()
                loPerGirarA.Persona = dr("perGirarA").ToString()
                ListaPersona.Add(loPerGirarA)
                loPedidoLog.ListaDocPersonaLOG = ListaPersona
                loPedidoLog.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loPedidoLog.TgMovId = dr("TgMovId").ToString()
                loPedidoLog.TgTipoDocId = dr("tgTipoDocId").ToString()
                loPedidoLog.DocNroTDoc = dr("docNroTDoc").ToString()
                loPedidoLog.DocSerieTDoc = dr("docSerieTDoc").ToString()
                loPedidoLog.TgEstadoId = dr("tgEstadoId").ToString()
                loPedidoLog.TgSubEstadoId = dr("tgSubEstadoId").ToString()
                loPedidoLog.docReferencia = dr("docReferencia").ToString()
                loPedidoLog.DocNroCertificacion = dr("docNroCertificacion").ToString()
                cmd = db.GetStoredProcCommand("Listar_PedidoArtDetLOG_XPedId_pa")
                db.AddInParameter(cmd, "pedid", DbType.String, loPedidoLog.DocId)
                drPedidoDetalle = db.ExecuteReader(cmd)
                While drPedidoDetalle.Read()
                    loPedidoDetalleLog = New EEDocumentoLOG.EEPedArtDetLOG()
                    loDocGeneral = New EEDocumentoLOG
                    loArticulo = New EEArticulo()
                    loArticulo.ArtId = drPedidoDetalle("artId").ToString()
                    loArticulo.ArtDescripcion = drPedidoDetalle("artDescripcion").ToString()
                    loPedidoDetalleLog.OArticulo = loArticulo
                    loPedidoDetalleLog.ArtId = drPedidoDetalle("artId").ToString()
                    loPedidoDetalleLog.TgUMIdOrigen = drPedidoDetalle("tgUMOrigenId").ToString()
                    loPedidoDetalleLog.TgUMId = drPedidoDetalle("tgUMId").ToString()
                    loPedidoDetalleLog.TgUM = drPedidoDetalle("tgUM").ToString()
                    loPedidoDetalleLog.PedArtDetCantidad = drPedidoDetalle("pedArtDetCantidad").ToString()
                    loPedidoDetalleLog.PedArtDetPrecio = drPedidoDetalle("pedArtDetPrecio").ToString()
                    loPedidoDetalleLog.DocId = drPedidoDetalle("docId").ToString()
                    loPedidoDetalleLog.TgTipoReqId = drPedidoDetalle("tgTipoReqId").ToString()
                    loPedidoDetalleLog.PedArtDetId = drPedidoDetalle("PedArtDetId").ToString()
                    loPedidoDetalleLog.PedArtDetCCtaDebeId = drPedidoDetalle("PedArtDetCCtaDebeId").ToString()
                    loPedidoDetalleLog.PedArtDetCCtaDebeNombre = drPedidoDetalle("PedArtDetCCtaDebeNombre").ToString()
                    loPedidoDetalleLog.PedArtDetCCtaDebe = Convert.ToDecimal(drPedidoDetalle("PedArtDetCCtaDebe").ToString)
                    loPedidoDetalleLog.PedArtDetCCtaHaberNombre = drPedidoDetalle("pedArtDetCCtaHaberNombre").ToString()
                    loPedidoDetalleLog.PedArtDetCCtaHaber = Convert.ToDecimal(drPedidoDetalle("PedArtDetCCtaHaber").ToString())
                    loPedidoDetalleLog.PedArtDetPartId = drPedidoDetalle("PedArtDetPartId").ToString()
                    loPedidoDetalleLog.PedArtDetPart = drPedidoDetalle("PedArtDetPart").ToString()
                    loPedidoDetalleLog.TgFuenteFId = drPedidoDetalle("TgFuenteFId").ToString()
                    loPedidoDetalleLog.TgFuenteF = drPedidoDetalle("TgFuenteF").ToString()
                    loPedidoDetalleLog.TgMetaId = drPedidoDetalle("TgMetaId").ToString()
                    loPedidoDetalleLog.TgMeta = drPedidoDetalle("TgMeta").ToString()
                    loPedidoDetalleLog.TgActProyId = drPedidoDetalle("TgActProyId").ToString()
                    loPedidoDetalleLog.TgActProy = drPedidoDetalle("TgActProy").ToString()
                    loPedidoDetalleLog.PedArtDetCImporte = Convert.ToDecimal(drPedidoDetalle("PedArtDetCImporte").ToString())
                    loPedidoDetalleLog.TgMesId = drPedidoDetalle("TgMesId").ToString()
                    loDocGeneral.DocId = drPedidoDetalle("DocId").ToString()
                    loDocGeneral.DocNroGenera = drPedidoDetalle("DocNroGenera").ToString()
                    loDocGeneral.DocAño = drPedidoDetalle("docAño").ToString()
                    loDocGeneral.TgArea = drPedidoDetalle("Area").ToString()
                    Select Case drPedidoDetalle("tgTipoReqId").ToString()
                        Case "00"
                            loPedidoDetalleLog.TgTipoReq = "Cdro Necesidad"
                        Case "01"
                            loPedidoDetalleLog.TgTipoReq = "Requerimiento"
                        Case "06"
                            loPedidoDetalleLog.TgTipoReq = "Nota de Credito"
                    End Select
                    loPedidoDetalleLog.ODocumentoGeneral = loDocGeneral
                    loPedidoLog.ListaPedArtDetLOG.Add(loPedidoDetalleLog)
                End While
                drPedidoDetalle.Close()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Pedido Articulo XDocId => " + ex.Message, ex)
        End Try
        Return loPedidoLog
    End Function

    Public Shared Function listarServCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocumentoLOG)
        Dim ListaRequerimientoLog As List(Of EEDocumentoLOG) = Nothing
        Dim loPedidoLog As EEDocumentoLOG = Nothing
        Dim loPerProveedor As EEDocPersonaLOG = Nothing
        Dim loPerGirarA As EEDocPersonaLOG = Nothing
        Dim ListaPersona As List(Of EEDocPersonaLOG) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_PedidoServLOG_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaRequerimientoLog Is Nothing Then
                    ListaRequerimientoLog = New List(Of EEDocumentoLOG)()
                End If
                ListaPersona = New List(Of EEDocPersonaLOG)()
                loPedidoLog = New EEDocumentoLOG()
                loPerProveedor = New EEDocPersonaLOG
                loPerGirarA = New EEDocPersonaLOG
                loPedidoLog.DocId = dr("DocId").ToString()
                loPedidoLog.DocCodigo = dr("docCodigo").ToString()
                loPerProveedor.PerId = dr("perProveedorId").ToString()
                loPerProveedor.Persona = dr("perProveedor").ToString()
                ListaPersona.Add(loPerProveedor)
                loPerGirarA.PerId = dr("perGirarAId").ToString()
                loPerGirarA.Persona = dr("perGirarA").ToString()
                ListaPersona.Add(loPerGirarA)
                loPedidoLog.ListaDocPersonaLOG = ListaPersona
                loPedidoLog.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loPedidoLog.TgMovId = dr("TgMovId").ToString()
                ' loPedidoLog.TgMovId = dr("TgMovId").ToString()
                loPedidoLog.TgTipoDocId = dr("tgTipoDocId").ToString()
                loPedidoLog.DocNroTDoc = dr("docNroTDoc").ToString()
                loPedidoLog.DocSerieTDoc = dr("docSerieTDoc").ToString()
                loPedidoLog.TgEstadoId = dr("tgEstadoId").ToString()
                loPedidoLog.docReferencia = dr("docReferencia").ToString()
                loPedidoLog.DocNroCertificacion = dr("DocNroCertificacion").ToString()
                ListaRequerimientoLog.Add(loPedidoLog)
            End While
        Catch ex As Exception
            Throw New Exception("Listar PedidoServLOG Criterio => " + ex.Message, ex)
        End Try
        Return ListaRequerimientoLog
    End Function

    Public Shared Function listarDetallePedServXPedId(ByVal PedId As [String]) As List(Of EEDocumentoLOG.EEPedServDetLOG)
        Dim ListaPedidoDet As List(Of EEDocumentoLOG.EEPedServDetLOG) = Nothing
        Dim loPedidoDet As EEDocumentoLOG.EEPedServDetLOG = Nothing
        Dim loDocGeneral As EEDocumentoLOG = Nothing
        Dim loServicio As EEServicio = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_PedidoServDetLOG_XPedId_pa")
            db.AddInParameter(cmd, "PedId ", DbType.String, PedId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPedidoDet Is Nothing Then
                    ListaPedidoDet = New List(Of EEDocumentoLOG.EEPedServDetLOG)
                End If
                loPedidoDet = New EEDocumentoLOG.EEPedServDetLOG()
                loServicio = New EEServicio
                loDocGeneral = New EEDocumentoLOG
                loPedidoDet.PedServDetId = CInt(dr("PedServDetId"))
                loPedidoDet.PedId = dr("pedId").ToString()
                loPedidoDet.PedServDetConforme = CBool(dr("PedServDetConforme"))
                loPedidoDet.PedServDetCantidad = dr("PedServDetCantidad").ToString()
                loPedidoDet.PedServDetPrecio = dr("PedServDetPrecio").ToString()
                loPedidoDet.PedServDetDescripcion = dr("PedServDetDescripcion").ToString()
                loPedidoDet.DocId = dr("DocId").ToString()
                loServicio.ServId = dr("servId").ToString()
                loServicio.ServNombre = dr("servNombre").ToString()
                loServicio.ServCodigo = dr("servCodigo").ToString()

                loPedidoDet.PedServDetCCtaDebeId = dr("PedServDetCCtaDebeId").ToString()
                loPedidoDet.PedServDetCCtaDebeNombre = dr("PedServDetCCtaDebeNombre").ToString()

                If Not IsDBNull(dr("PedServDetCCtaDebe")) Then
                    loPedidoDet.PedServDetCCtaDebe = Convert.ToDecimal(dr("PedServDetCCtaDebe").ToString())
                End If

                loPedidoDet.PedServDetCCtaHaberId = dr("PedServDetCCtaHaberId").ToString()
                loPedidoDet.PedServDetCCtaHaberNombre = dr("PedServDetCCtaHaberNombre").ToString()

                If Not IsDBNull(dr("PedServDetCCtaHaber")) Then
                    loPedidoDet.PedServDetCCtaHaber = Convert.ToDecimal(dr("PedServDetCCtaHaber").ToString())
                End If

                loPedidoDet.PedServDetPartId = dr("PedServDetPartId").ToString()
                loPedidoDet.PedServDetPart = dr("PedServDetPart").ToString()
                loPedidoDet.TgFuenteFId = dr("TgFuenteFId").ToString()
                loPedidoDet.TgFuenteF = dr("TgFuenteF").ToString()
                loPedidoDet.TgMetaId = dr("TgMetaId").ToString()
                loPedidoDet.TgMeta = dr("TgMeta").ToString()
                loPedidoDet.TgActProyId = dr("TgActProyId").ToString()
                loPedidoDet.TgActProy = dr("TgActProy").ToString()
                loPedidoDet.TgMesId = dr("tgMesId").ToString()
                If Not IsDBNull(dr("PedServDetCImporte")) Then
                    loPedidoDet.PedServDetCImporte = Convert.ToDecimal(dr("PedServDetCImporte").ToString())
                End If
                loDocGeneral.DocId = dr("DocId").ToString()
                loDocGeneral.DocNroGenera = dr("DocNroGenera").ToString()
                ' loDocGeneral.DocAño = dr("docAño").ToString()
                ' loDocGeneral.TgArea = dr("Area").ToString()
                loPedidoDet.TgTipoReqId = dr("tgTipoReqId").ToString()
                Select Case dr("tgTipoReqId").ToString()
                    Case "00"
                        loPedidoDet.TgTipoReq = "Cdro Necesidad"
                    Case "01"
                        loPedidoDet.TgTipoReq = "Requerimiento"
                End Select
                loPedidoDet.ODocumentoGeneral = loDocGeneral
                loPedidoDet.LoServicio = loServicio
                ListaPedidoDet.Add(loPedidoDet)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Detalle Pedido Servicio x PedID => " + ex.Message, ex)
        End Try
        Return ListaPedidoDet
    End Function


    Public Shared Function NewDocCodigo(ByVal tipo As [String]) As String
        Dim docCodigo As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Orden_Pedido_by_tipo")
            db.AddInParameter(cmd, "tipo ", DbType.String, tipo)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                docCodigo = dr("docCodigo").ToString()
            End If
        Catch ex As Exception
            Throw New Exception("Genera DocCodigo Orden de Pedido => " + ex.Message, ex)
        End Try
        Return docCodigo
    End Function

    Public Shared Function listarPedidoArtActivos_Criterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocumentoLOG)
        Dim ListaPedidosLog As List(Of EEDocumentoLOG) = Nothing
        Dim loPedidoLog As EEDocumentoLOG = Nothing
        Dim loPerProveedor As EEDocPersonaLOG = Nothing
        Dim ListaPersona As List(Of EEDocPersonaLOG) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_PedidoArtLOG_Activos_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPedidosLog Is Nothing Then
                    ListaPedidosLog = New List(Of EEDocumentoLOG)()
                End If
                ListaPersona = New List(Of EEDocPersonaLOG)()
                loPedidoLog = New EEDocumentoLOG()
                loPerProveedor = New EEDocPersonaLOG()
                loPedidoLog.DocId = dr("docId").ToString()
                loPedidoLog.DocCodigo = dr("docCodigo").ToString()
                loPerProveedor.Persona = dr("perProveedor").ToString()
                loPerProveedor.PerId = dr("perProvId").ToString()
                ListaPersona.Add(loPerProveedor)
                loPedidoLog.ListaDocPersonaLOG = ListaPersona
                loPedidoLog.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loPedidoLog.TgMovId = dr("tgMovId").ToString()
                loPedidoLog.TgTipoDocId = dr("tgTipoDocId").ToString()
                loPedidoLog.DocNroTDoc = dr("DocNroTDoc").ToString()
                loPedidoLog.DocSerieTDoc = dr("docSerieTDoc").ToString()
              
                ListaPedidosLog.Add(loPedidoLog)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Pedido Articulo Activos (Pendiente de Pagos o Pagados) Criterio => " + ex.Message, ex)
        End Try
        Return ListaPedidosLog
    End Function
End Class