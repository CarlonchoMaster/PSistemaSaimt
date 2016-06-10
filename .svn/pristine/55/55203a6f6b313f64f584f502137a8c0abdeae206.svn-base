
Public Class EEPersona

    Public Property PerId() As String
    Public Property PerCodTarjeta() As String
    Public Property PerNombres() As String
    Public Property PerNombreCompleto() As String
    Public Property PerApeMaterno() As String
    Public Property PerApePaterno() As String
    Public Property TgTipoPersId() As String
    Public Property PerRazonSocial() As String
    Public Property PerRuc() As String
    Public Property PerDni() As String
    Public Property TgTipoDocId() As String
    Public Property TgTipoDoc() As String
    Public Property TgTipoPersona() As String
    Public Property TgEstConId() As String
    Public Property TgDocumento() As String
    Public Property TgGeneroId() As String
    Public Property TgGenero() As String
    Public Property PerNDoc() As String
    Public Property PerDireccion() As String
    Public Property OUbigeo() As EEUbigeo
    Public Property PerObservacion() As String
    Public Property PerDepartamento() As String
    Public Property PerProvincia() As String
    Public Property PerDistrito() As String
    Public Property PerActivo() As Boolean
    Public Property PerFechaReg() As DateTime?
    Public Property PerFechaAct() As DateTime?
    Public Property PerFechaNac() As DateTime?
    Public Property PerIdConyuge() As String
    Public Property PerRef() As String
    Public Property PerEliminado() As Boolean
    Public Property OPerConyuge() As EEPersona
    Public Property OPerCargoPersonal() As EECargoPersonal
    ''' <summary>
    ''' MUESTRA NOMBRES O RAZON SOCIAL ASIGNADO
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Persona As String
    Public Property Usuario As String

    ''' <summary>
    ''' Para Consulta Programacion Pagos
    ''' </summary>
    ''' <remarks></remarks>
    Public Property PerContacto() As String

#Region "Propiedades ReadOnly"
    Public ReadOnly Property perRucoDni() As String
        Get
            If String.IsNullOrEmpty(PerRuc) Then
                Return PerDni
            Else
                Return PerRuc
            End If
        End Get
    End Property

    ''' <summary>
    ''' Devuelve Nombres y Apellidos o Razon Social
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property perNombresoRazon() As String
        Get
            If String.IsNullOrEmpty(PerRazonSocial) Then
                Return PerApePaterno & " " & PerApeMaterno & " " & PerNombres
            Else
                Return PerRazonSocial
            End If
        End Get
    End Property

    Public ReadOnly Property perTipoPersona() As String
        Get
            If TgTipoPersId = "J" Then
                Return "Persona Juridica"
            Else
                Return "Persona Natural"
            End If
        End Get
    End Property
#End Region

#Region "EEContacto"
    Public Property ListaContacto() As List(Of EEContacto) = New List(Of EEContacto)

    Public Class EEContacto
        Public Property OTablaGeneral() As EETablaGeneral
        Public Property ContDescripcion() As String
    End Class
#End Region

#Region "Mostrar ListBox Persona"
    Public ReadOnly Property DatosPersona() As String
        Get
            If Not String.IsNullOrEmpty(PerRazonSocial) Then
                Return PerRazonSocial
            Else
                Return PerApePaterno & " " & PerApeMaterno & ", " & PerNombres
            End If
        End Get
    End Property
#End Region

End Class
