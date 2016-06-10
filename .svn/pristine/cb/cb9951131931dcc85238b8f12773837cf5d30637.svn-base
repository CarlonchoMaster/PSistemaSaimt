
Public Class EENivelesPEM
	
	Public Property NivId() As String
	Public Property NivNombre() As String
	Public Property NivEspInicio() As Int32?
	Public Property NivEspFin() As Int32?
	Public Property NivActivo() As Boolean?
    Public Property tgNPisoId() As String
    Public Property tgInstitucionId() As String
    Public Property tgSedeId() As String

    Public Property ONroPiso() As EETablaGeneral
    Public Property tgInstitucion() As EETablaGeneral
    Public Property tgSede() As EETablaGeneral
    Public Property AbreviaturaIntitucionSede As String

    Public ReadOnly Property DatoListadoNivles() As String
        Get
            Return AbreviaturaIntitucionSede & " | " & NivNombre
        End Get
    End Property


End Class
