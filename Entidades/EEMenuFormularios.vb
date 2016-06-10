
Public Class EEMenuFormularios

    Public Property MfrId() As Int16?
    ''' <summary>
    ''' ES EL NAME DEL FORMULARIO
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MfrNombre() As String
    Public Property MfrTitulo() As String
    Public Property MfrAplicacion() As String
    Public Property MfrDescripcion() As String
    Public Property MfrTag() As String
    Public Property MfrEliminado() As Boolean?
    Public Property OGrupoFormularios() As EEGrupoFormularios
    Public Property ListaMenuFormularios() As List(Of EEMenuFormularios)

#Region "Lista Temporal"
    Public Property ListaTemporalEliminados() As List(Of String)
    Public Property ListaTemporalNuevos() As List(Of EEMenuFormularios)
#End Region
End Class
