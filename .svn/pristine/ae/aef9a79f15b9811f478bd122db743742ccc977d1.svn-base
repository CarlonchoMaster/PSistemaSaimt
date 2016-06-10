Public Class EECargoTipoDocSTD
    Public Property CarTipoDocId() As String
    Public Property CarTipoDocNroIni() As Int32?
    Public Property OTgTipoDocumento() As EETablaGeneral
    Public Property CarTipoAño() As String
    Public Property ListaTemporalEliminados() As List(Of String)
    Public Property ListaTemporalNuevos() As List(Of EECargoTipoDocSTD)
    Public ReadOnly Property TgNombre() As String
        Get
            Return OTgTipoDocumento.TgNombre
        End Get
    End Property
    Public ReadOnly Property TgCodigo() As String
        Get
            Return OTgTipoDocumento.TgCodigo
        End Get
    End Property
    Public Property Institucion() As String
    Public Property CodInstitucion() As String
    Public Property Area() As String
    Public Property CodArea() As String
    Public Property Cargo() As String
    Public Property CodCargo() As String

#Region "Relaciones"
    Public Property ListaCargoTipoDocSTD() As List(Of EECargoTipoDocSTD) = New List(Of EECargoTipoDocSTD)
#End Region
End Class
