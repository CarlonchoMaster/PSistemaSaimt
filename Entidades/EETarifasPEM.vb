
Public Class EETarifasPEM

    Public Property TarfId() As String
    Public Property ConNombre() As String
    Public Property ConId() As String
    Public Property tarfIni() As Date
    Public Property tarfFin() As Date
    Public Property tgTipoVehId() As String
    Public Property tgInstitucionId() As String
    Public Property tgSedeId() As String
    Public Property AcuPrecio() As Decimal
    Public Property TarfNroDias() As Int16?
    Public Property TarfNroHoras() As Int16?
    Public Property TarfActivo() As Boolean?

    Public Property tgTipoVeh() As EETablaGeneral
    Public Property tgInstitucion() As EETablaGeneral
    Public Property tgSede() As EETablaGeneral
    Public Property Concepto() As EEConceptos

    Public Property TgTipoClienteId() As String
End Class
