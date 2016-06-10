
Public Class EEEtapaSTD
    Public Property EtaCod() As String
    Public Property EtaInstArea() As String
    Public Property EtaNro() As Int16?
    Public Property EtaNombre() As String
    Public Property EtaMaxDia() As Int16?
    Public Property EtaMaxHoras() As Decimal?
    Public Property EtaFinaliza() As Boolean?
    Public Property EtaObservacion() As String
    Public Property OProcedimientoSTD() As EEProcedimientoSTD

    Public Property Institucion() As String
    Public Property CodInstitucion() As String
    Public Property Area() As String
    Public Property CodArea() As String


    Public ReadOnly Property DatoListadoEtapaSTD
        Get
            Return EtaNombre & " - " & OProcedimientoSTD.ProcNombre & " - " & Area
        End Get
    End Property
End Class
