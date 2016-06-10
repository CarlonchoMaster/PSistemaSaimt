Public Class EEPecosa

    Public Property PecId() As String
    Public Property PecNro() As String
    Public Property PecFecha() As Date?
    Public Property PecFechaReg() As Date?
    Public Property PecCarPerId() As String
    Public Property PecObservacion() As String
    Public Property PerSolicitaId() As String
    Public Property PerSolicita() As String
    Public Property PlanCDDescripcion() As String
    Public Property PlanCHDescripcion() As String
    Public Property OrdId() As String
    Public Property OrdNro() As String
    Public Property OrdFechaOC() As Date?
    Public Property TgAreaOCId() As String
    Public Property TgAreaOC() As String
    Public Property TgAreaDesId() As String
    Public Property TgAreaDes() As String
    Public Property TgCarDesId() As String
    Public Property TgCarDes() As String
    Public Property TgMetaId() As String
    Public Property TgActProyId() As String
    Public Property TgCuentaDebeId() As String
    Public Property TgCuentaDebe() As Decimal?
    Public Property TgCuentaHaberId() As String
    Public Property TgCuentaHaber() As Decimal?
    Public Property TgEstadoId() As String
    Public Property TgEstado() As String
    Public Property cerNro() As String

    Public Property pecAnulado As Boolean



    Public Property PecosaDet() As EEPecosa.EEPecosaDet
    Public Property ListaPecosaDet() As List(Of EEPecosa.EEPecosaDet)

    Public Property Lista_PecosaDetElimnados As List(Of String)
    Public Class EEPecosaDet
        Public Property OArticulo() As EEArticulo
        Public Property ArtId() As String
        Public Property TgUmId() As String
        Public Property TgUm() As String
        Public Property OrdDetId() As String
        Public Property PecDetId() As String
        Public Property PecDetCantidad() As Decimal
        Public Property PecDetCQuedan() As Decimal
        Public Property PecDetPrecio() As Decimal
        Public Property PecDetImpTotal() As Decimal
        Public Property PecDetDescripcion As String
        Public Property PecLlevar() As Boolean
        Public Property PecId() As String
        Public Property PecDetCanTotal() As Decimal
        Public Property PecCanLleva() As Decimal
        Public Property OrdId() As String
        Public Property OCNro As String
        Public Property ListaPecosaOCDet() As List(Of EEPecosa.EEPecosaOCDet)
    End Class

    Public Property PecosaOCDet() As EEPecosa.EEPecosaOCDet
    Public Property ListaPecosaOCDet() As List(Of EEPecosa.EEPecosaOCDet)

    Public Property Lista_PecosaOCDetElimnados As List(Of String)

    Public Class EEPecosaOCDet
        Public Property OArticulo() As EEArticulo
        Public Property ArtId() As String
        Public Property PecOrdComDetId() As String
        Public Property PecDetId() As String
        Public Property CanOrdComDet() As Decimal
        Public Property OrdId() As String
        Public Property PrecOrdComDet() As Decimal
        Public Property PecSubTotal() As Decimal

    End Class
End Class

