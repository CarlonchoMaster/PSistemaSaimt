Public Class EEJerarquiaSTD
    Public Property JerDeId() As String
    Public Property JerParaId() As String
    Public Property OTgTipoDocumento() As EETablaGeneral
    Public Property JerActivo() As Boolean?
    Public Property ListaTemporalEliminados() As List(Of String)
    Public Property ListaTemporalNuevos() As List(Of EEJerarquiaSTD)

    Public Property InstitucionOrigen() As String
    Public Property CodInstitucionOrigen() As String
    Public Property AreaOrigen() As String
    Public Property CodAreaOrigen() As String
    Public Property CargoOrigen() As String
    Public Property CodCargoOrigen() As String

    Public Property InstitucionDestino() As String
    Public Property CodInstitucionDestino() As String
    Public Property AreaDestino() As String
    Public Property CodAreaDestino() As String
    Public Property CargoDestino() As String
    Public Property CodCargoDestino() As String

    ''' <summary>
    ''' Para el Listar Criterio PermisosSTD
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Cargo As String

    ''' <summary>
    ''' Para el Listar Criterio PermisosSTD
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Id As String


    Public ReadOnly Property PermisosSTD
        Get
            Return Cargo
        End Get
    End Property


#Region "Relaciones"
    Public Property ListaJerarquiaSTD() As List(Of EEJerarquiaSTD) = New List(Of EEJerarquiaSTD)
#End Region
End Class
