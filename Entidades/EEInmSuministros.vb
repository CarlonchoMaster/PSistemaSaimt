
Public Class EEInmSuministros
    Inherits EEComun

    Public Property InmSumId() As String
    Public Property InmId() As String
    Public Property OPersona() As EEPersona
    Public Property TgTipoServicio() As EETablaGeneral
    Public Property InmSumFechaVen() As DateTime?
    Public Property TgTipoMes() As EETablaGeneral
    Public Property InmSumAño() As Int32?
    Public Property InmSumMonto() As Decimal?
    Public Property InmSumMedidor() As String
       
End Class
