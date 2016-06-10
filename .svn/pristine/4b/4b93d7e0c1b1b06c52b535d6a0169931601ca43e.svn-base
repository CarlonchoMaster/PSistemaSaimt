Public Class EENotaIngresoLOG

    Public Property AlmId() As String
    Public Property Almacen() As String
    Public Property NIngId() As String
    Public Property NIngFechaReg() As DateTime?
    Public Property NIngFecIng() As DateTime?
    Public Property NIngObservacion() As String
    Public Property PedId() As String
    Public Property NIngActivo() As Boolean
    Public Property loNotaDetIngreso As New List(Of EENotaIngresoLOG.EENotaIngresoDetLOG)


    Public Class EENotaIngresoDetLOG

        Public Property NIngDetId() As Int32
        Public Property ArtId() As String
        Public Property NIngCantidad() As Decimal
        Public Property TgUMId() As String
        Public Property NIngCantidadDesc() As Decimal
        Public Property TgUMDescId() As String
        Public Property PedArtDetId() As Int32
        Public Property NIngId() As String
        Public Property NIngDetCCtaDebeId() As String
        Public Property NIngDetCCtaDebe() As String
        Public Property NIngDetCCtaDebeMonto() As Decimal
        Public Property NIngDetCCtaHaberId() As String
        Public Property NIngDetCCtaHaber() As String
        Public Property NIngDetCCtaHaberMonto() As Decimal
        Public Property TgMesId() As String
        Public Property loArticulo() As New EEArticulo
        Public Property loDetOrdenCompra() As New EEDocumentoLOG.EEPedArtDetLOG
        Public Property loOrdenCompra() As New EEDocumentoLOG
    End Class

End Class

