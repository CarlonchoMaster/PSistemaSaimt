Public Class EEDocumentoLOG
    'Documento Interno
    Public Property DocId() As String
    Public Property TgTipoDocId() As String
    ' Documento y serie Externos como factura o boleta o otros
    Public Property DocNroTDoc() As String
    Public Property DocSerieTDoc() As String
    Public Property DocNroProv() As String
    ' Nro de Requerimiento o NroCdroNecesidad o NroOrdendeCredito
    Public Property DocNroGenera() As String
    'Public Property DocNroCdroNec() As String
    Public Property DocAsunto() As String
    Public Property DocObservacion() As String
    Public Property DocFechaDoc() As DateTime?
    Public Property DocFechaReg() As DateTime?
    Public Property DocFechaRec() As DateTime?
    Public Property DocAño As String
    Public Property TgMovId() As String
    Public Property TgMovDescripcion() As String
    Public Property TgSubEstadoId() As String
    Public Property TgEstadoId() As String ' Depende del Mov
    ' Documento propio de la empresa 
    Public Property DocCodigo As String
    Public Property DocNroCertificacion As String
    Public Property ListaDocTextLog() As List(Of EEDocTextLOG)
    Public Property docReferencia() As String

#Region "Requerimientos Articulo LOG"
    Public Property loReqArtDet() As List(Of EEReqArtDetLOG)
    Public Property loReqArtDetEliminados As List(Of String) = New List(Of String)
#End Region

#Region "Requerimiento Servicio LOG"
    Public Property loReqServDetEliminados As List(Of String) = New List(Of String)
    Public Property ListaReqServDet() As List(Of EEReqServDetLOG) = New List(Of EEReqServDetLOG)
#End Region

#Region "Cuadro de Necesidad Servicio LOG"
    Public Property loCdroNecServDetEliminados As List(Of String) = New List(Of String)
    Public Property loCdroNecServDet() As List(Of EECdroNecesidadServDetLOG)
#End Region

#Region "Cuadro de Necesidad Articulo LOG"
    Public Property loCdroNecArtDetEliminados As List(Of String) = New List(Of String)
    Public Property loCdroNecArtDet() As List(Of EECdroNecesidadArtDetLOG)
#End Region

#Region "Pedidos Detalles Servicios"
    Public Property loPedServDetLOG() As List(Of EEPedServDetLOG)
    Public Property loPedServDetEliminados As List(Of String) = New List(Of String)
#End Region

    '#Region "Pedido Detalle Articulo"

    '    Public Property loPedArtDetLOG() As List(Of EEPedArtDetLOG)
    '    Public Property loPedArtDetEliminados As List(Of String) = New List(Of String)
    '#End Region

#Region "Clase PedArtDetLOG"
    Public Property ListaPedArtDetLOG() As List(Of EEPedArtDetLOG) = New List(Of EEPedArtDetLOG)
    Public Property ListaPedArtDetLOGNuevos() As List(Of EEPedArtDetLOG) = New List(Of EEPedArtDetLOG)
    Public Property loPedArtDetEliminados As List(Of String) = New List(Of String)
    Public Property loPedArtDetLOG As EEDocumentoLOG.EEPedArtDetLOG
    Public Class EEPedArtDetLOG
        Public Property PedCantidad() As Int32?
        Public Property PedArtDetId() As Int32
        Public Property ArtId() As String
        Public Property TgUMIdOrigen() As String
        Public Property TgUMId() As String
        Public Property TgUM() As String
        Public Property PedId() As String
        Public Property DocId() As String
        Public Property DocNro() As String
        Public Property TgTipoReqId() As String
        Public Property TgTipoReq() As String
        Public Property TgMesId() As String
        Public Property PedArtDetCantidad() As Int32
        Public Property PedArtDetPrecio() As Decimal
        Public Property PedArtDetConforme() As Boolean
        Public Property PedArtDetCCtaDebeId() As String
        Public Property PedArtDetCCtaDebe() As Decimal
        Public Property PedArtDetCCtaDebeNombre() As String
        Public Property PedArtDetCCtaHaberId() As String
        Public Property PedArtDetCCtaHaber() As Decimal
        Public Property PedArtDetCCtaHaberNombre() As String
        Public Property PedArtDetPartId() As String
        Public Property PedArtDetPart() As String
        Public Property TgFuenteFId() As String
        Public Property TgFuenteF() As String
        Public Property TgMetaId() As String
        Public Property TgMeta() As String
        Public Property TgActProyId() As String
        Public Property TgActProy() As String
        Public Property TgEstadoId() As String
        Public Property TgEstado() As String
        Public Property PedArtDetCImporte() As Decimal

        Public Property ODocRequerimiento() As EEDocumentoLOG
        Public Property ODocCdroNecesidad() As EEDocumentoLOG

        Public Property ODocumentoGeneral() As EEDocumentoLOG
        Public Property OArticulo() As EEArticulo
        'Public Property loPedArtDetLOG() As List(Of EEPedArtDetLOG)      

    End Class
#End Region
#Region "Clase PedServDetLOG"
    Public Property ListaPedServDetLOG() As List(Of EEPedServDetLOG) = New List(Of EEPedServDetLOG)
    Public Class EEPedServDetLOG
        Public Property PedServDetId() As Int32
        Public Property ServId() As String
        Public Property PedId() As String
        Public Property DocId() As String
        Public Property DocNro() As String
        Public Property TgTipoReqId() As String
        Public Property TgTipoReq() As String
        Public Property TgMesId() As String
        Public Property TgMes() As String
        Public Property PedServDetPrecio() As Decimal?
        Public Property PedServDetConforme() As Boolean
        Public Property PedServDetCantidad() As Int32
        Public Property PedServDetDescripcion() As String
        Public Property PedServDetCCtaDebeId() As String
        Public Property PedServDetCCtaDebe() As Decimal?
        Public Property PedServDetCCtaDebeNombre() As String
        Public Property PedServDetCCtaHaberId() As String
        Public Property PedServDetCCtaHaber() As Decimal?
        Public Property PedServDetCCtaHaberNombre() As String
        Public Property PedServDetPartId() As String
        Public Property PedServDetPart() As String
        Public Property TgFuenteFId() As String
        Public Property TgFuenteF() As String
        Public Property TgMetaId() As String
        Public Property TgMeta() As String
        Public Property TgActProyId() As String
        Public Property TgActProy() As String
        Public Property PedServDetCImporte() As Decimal?
        Public Property LoDocRequerimiento() As EEDocumentoLOG
        Public Property LoDocCdroNecesidad() As EEDocumentoLOG
        Public Property ODocumentoGeneral() As EEDocumentoLOG
        Public Property LoServicio() As EEServicio
    End Class
#End Region

    Public Property ListaDocPersonaLOG() As List(Of EEDocPersonaLOG)
    Public Property loDocPersona() As EEDocPersonaLOG


    Public Property TgArea() As String
    Public Property TgAreaId() As String
    Public Property TgInstitucion() As String


    Public Class EECdroNecesidadServDetLOG
        Public Property ServId() As String
        Public Property CdroNecServDetDescripcion() As String
        Public Property TgMesId() As String
        Public Property TgMes() As String
        Public Property CdroNecServDetGastoEst() As Decimal
        Public Property CdroNecServDetCantidad() As Int32
        Public Property CdroNecServDetActivo() As Boolean
        Public Property CdroNecServId() As String
        Public Property CdroNecServCantidad() As Int32
        Public Property CdroNecServCantDesc() As Int32
        Public Property CdroNecServActivo() As Boolean
        Public Property TgEstadoId() As String
        Public Property TgEstado() As String
        Public Property loServicios As EEServicio
        Public Property OTgEstado() As EETablaGeneral
    End Class

    Public Class EECdroNecesidadArtDetLOG
        Public Property ArtId() As String
        Public Property TgUMId() As String
        Public Property TgUM() As String
        Public Property TgMesId() As String
        Public Property TgMes() As String
        Public Property CdroNecArtDetCantidad() As Int32
        Public Property CdroNecArtCantidad() As Int32
        Public Property CdroNecArtDetActivo() As Boolean
        Public Property CdroNecArtId() As String
        Public Property CdroNecArtDetGastoEst() As Decimal
        Public Property CdroNecArtCantDesc() As Int32
        Public Property CdroNecArtActivo() As Boolean
        Public Property TgEstadoId() As String
        Public Property TgEstado() As String
        Public Property loArticulos As EEArticulo
        Public Property OTgEstado() As EETablaGeneral
    End Class

    Public Class EEReqServDetLOG
        Public Property ReqId() As String
        Public Property ServId() As String
        Public Property TgEstadoId() As String
        Public Property TgEstado() As String
        Public Property ReqObservacion() As String
        Public Property loServicios As EEServicio
    End Class

    Public Class EEReqArtDetLOG
        Public Property ReqId() As String
        Public Property ArtId() As String
        Public Property ReqCantidad() As Int32
        Public Property TgUMId() As String
        Public Property TgEstadoId() As String
        Public Property TgEstado() As String
        Public Property loArticulos As EEArticulo
        Public Property loPedidoDet As EEDocumentoLOG.EEPedArtDetLOG
    End Class

    Public Property ListaNotaCredArtDetLOG As List(Of EENotaCredArtDetLOG)
    Public Property ListaNotaCredArtDetEliminadosLOG As List(Of String)
    Public Class EENotaCredArtDetLOG
        Public Property NotCredDetId() As String
        Public Property NotCredId() As String
        Public Property NotCredNro() As String
        Public Property ArtId() As String
        Public Property TgUMId() As String
        Public Property TgUM() As String
        Public Property NotCredCantidad() As Int32
        Public Property NotCredPrecioUnitario() As Decimal
        Public Property NotCredPrecioTotal() As Decimal
        Public Property NotCredRegularizado() As Boolean
        Public Property TgTipoReqId() As String
        Public Property TgTipoReq() As String
        Public Property TgMesId() As String
        Public Property OTgEstado() As EETablaGeneral
        Public Property TgMes() As String
        Public Property TgEstadoId() As String
        Public Property TgEstado() As String
        Public Property DocId() As String
        Public Property lo_DocReq_Cdro() As EEDocumentoLOG
        'Public Property ODocCdroNecesidad() As EEDocumentoLOG
        Public Property loArticulos As EEArticulo
    End Class
End Class
