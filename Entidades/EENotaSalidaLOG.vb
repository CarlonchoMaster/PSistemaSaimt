Public Class EENotaSalidaLOG

    Public Property NSalDestinoId() As String
    Public Property NSalId() As String
    Public Property NSalFechaReg() As DateTime?
    Public Property NSalFecSal() As DateTime?
    Public Property NSalObservacion() As String
    Public Property tgInstitucion() As String
    Public Property tgArea() As String
    Public Property NSalActivo() As Boolean
    Public Property NSalCodigo As String
    Public Property LoNotaSalidaDet As New List(Of EENotaSalidaDetLOG)
    Public Class EENotaSalidaDetLOG

        Public Property NSalDetId() As Int32
        Public Property ArtId() As String
        Public Property NSalDetSalCantidad() As Decimal
        Public Property TgUMSalId() As String
        Public Property TgUMSal() As String
        Public Property NSalDetCCtaDebeId() As String
        Public Property NSalDetCCtaDebe() As String
        Public Property NSalDetCCtaDebeMonto() As Decimal
        Public Property NSalDetCCtaHaberId() As String
        Public Property NSalDetCCtaHaber() As String
        Public Property NSalDetCCtaHaberMonto() As Decimal
        Public Property NSalId() As String
        Public Property NSalDetPrecio() As Decimal
        Public Property nSalDetPrecioTotal() As Decimal
        Public Property ReqId() As String
        Public Property ReqNroGenera() As String
        Public Property TgUMReqId() As String
        Public Property TgUMReq() As String
        Public Property NSalDetReqCantidad() As Decimal
        Public Property tgMetaId() As String
        Public Property tgActProyId() As String
        Public Property OArticulo As EEArticulo

    End Class

End Class