Public Class EEContratoPersonal
    Public Property OPersona() As EEPersona
    Public Property PerNombreCompleto() As EEPersona
    Public Property ConTrabId() As String
    Public Property ConTrabFecInicio() As DateTime?
    Public Property ConTrabFecFin() As DateTime?
    Public Property OTgEstadoContrato() As EETablaGeneral
    Public Property OHorarioPer() As EEHorarioPer
    Public Property OTgTipoContrato() As EETablaGeneral
    Public Property ConTrabNroSueldos() As Int32?
    Public Property ConTrabMonto() As Decimal?
    Public Property ConTrabResolucion() As String
    Public Property ConTrabFecRes() As DateTime?
    Public Property ConTrabOficio() As String
    Public Property ConTrabFecOficio() As DateTime?
    Public Property ConTrabFecReq() As DateTime?
    Public Property ConTrabRequeriemiento() As String
    Public Property ConTrabProveido() As String
    Public Property ConTrabFecProv() As DateTime?
    Public Property ConTrabInforme() As String
    Public Property CodAsistencia() As String
    Public Property ConTrabFecInf() As DateTime?

    Public Property tgNivEduId() As String
    Public Property tgNivRemnId() As String
    Public Property tgGradoOcuId() As String
    Public Property tgForProfId() As String
    Public Property tgTipoConId() As String
    Public Property tgBancoId() As String
    Public Property tgAFPId() As String

    Public Property tgBanco() As String
    Public Property tgTipoCon() As String
    Public Property tgNivEdu() As String
    Public Property tgNivRemn() As String
    Public Property tgGradoOcu() As String
    Public Property tgForProf() As String
    Public Property tgAFP() As String


    Public Property ListaTemporalEliminados() As List(Of String)
    Public Property ListaTemporalNuevos() As List(Of EECargoPersonal)
    Public Property ListaTemporalEditados() As List(Of String)



    Public Property ConTrabRuc() As String
    Public Property ConTrabNroCuenta() As String
    Public Property TgEstadoCivilId() As Int32?
    Public Property ConTrabNroHijos() As Int32?
    Public Property CodSucursal() As Int32?
    Public Property Sucursal() As String
    Public Property HorarioNombre() As String
    Public Property TgSeguroSocId As String
    Public Property NroSeguroSoc As String


    Public ReadOnly Property Trabajador
        Get
            Return OPersona.perNombresoRazon
        End Get
    End Property

#Region "Relaciones"
    Public Property ListaCargoPersonal() As List(Of EECargoPersonal) = New List(Of EECargoPersonal)
#End Region
End Class
