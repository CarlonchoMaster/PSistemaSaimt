Public Class EEComprobantePago
    Public Property ComPagId() As String
    Public Property ComPagNro() As String
    Public Property ComPagFecha() As Date?
    Public Property ComPagNroOrden() As String
    Public Property ComPagConcepto() As String
    Public Property ComPagCtaCorriente() As String
    Public Property ComPagImpTotal() As Decimal?
    Public Property ComPagImpDeduccion() As Decimal?
    Public Property ComPagImpPagar() As Decimal?
    Public Property PerProvId() As String
    Public Property PerProv() As String
    Public Property PerRespId() As String
    Public Property TgEstadoId() As String
    Public Property TgBancoId() As String
    Public Property TgTipoComId() As String
    Public Property TgTipoOdenId() As String
    'Codificacion Programatica
    Public Property ComPagSector() As String
    Public Property ComPagPliego() As String
    Public Property ComPagFuncion() As String
    Public Property ComPagPrograma() As String
    Public Property ComPagSubPrograma() As String
    Public Property TgActProyId() As String
    Public Property TgMetaId() As String
    Public Property TgFFinancieraId() As String
    'Contabilidad Presupuestal
    Public Property TgCuentaDebeId() As String
    Public Property TgCuentaDebe() As Decimal?
    Public Property TgCuentaHaberId() As String
    Public Property TgCuentaHaber() As Decimal?
    'Contabilidad
    Public Property TgCuentaDebe2Id() As String
    Public Property TgCuentaDebe2() As Decimal?
    Public Property TgCuentaHaber2Id() As String
    Public Property TgCuentaHaber2() As Decimal?

    Public Property ComprobantePagoDet() As EEComprobantePago.EEComprobantePagoDet
    Public Property ListaComprobantePagoDet() As List(Of EEComprobantePago.EEComprobantePagoDet)
    Public Property Lista_ComprobantePagoDetElimnados As List(Of String)

    Public Class EEComprobantePagoDet
        'Estadisticas Objeto del Gasto
        Public Property ComDetId() As String
        Public Property PartId() As String
        'Public Property PartNombre() As String
        'Public Property PartAnio() As String
        Public Property ComDetImpParcial() As Decimal
        Public Property ComDetImpTotal() As Decimal
        Public Property ComDetImpDeduccion() As Decimal
    End Class
End Class

