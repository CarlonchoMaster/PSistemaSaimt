Public Class EEDiarioPEM

    Public Property DiarioId() As Int32
    Public Property DiaNPlaca() As String
    Public Property DiaFechaIng() As DateTime?
    Public Property DiaFechaSal() As DateTime?
    Public Property DiaPrecio() As Decimal
    Public Property TgEstadoId() As String
    Public Property OTgEstado() As EETablaGeneral
    Public Property DiaHoraIng() As DateTime?
    Public Property DiaHoraSal() As DateTime?
    Public Property TgTipoAbonoId() As String
    Public Property TgTipoAbono() As String
    Public Property ConId() As String
    Public Property PerRegId() As String
    Public Property PerRegEntId() As String
    Public Property PerRegSalId() As String
    Public Property AbonDetId() As String
    Public Property DiarioCod() As String
    Public Property loConcepto() As EEConceptos
    ''' <summary>
    ''' Solo Hora Ingreso
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DiaHoraIngreso() As TimeSpan?

    ''' <summary>
    ''' Solo Hora Salida
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DiaHoraSalida() As TimeSpan?
End Class





