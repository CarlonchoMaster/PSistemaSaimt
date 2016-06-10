Public Class EEProcedimientoSTD
    Private _ProcId As String
    Public Property ProcId() As String
        Get
            Return _ProcId
        End Get
        Set(value As String)
            _ProcId = value
        End Set
    End Property
    Private _ProcNombre As String
    Public Property ProcNombre() As String
        Get
            Return _ProcNombre
        End Get
        Set(value As String)
            _ProcNombre = value
        End Set
    End Property
    Private _ProcDescripcion As String
    Public Property ProcDescripcion() As String
        Get
            Return _ProcDescripcion
        End Get
        Set(value As String)
            _ProcDescripcion = value
        End Set
    End Property
    Private _ProcMaxDia As Int32
    Public Property ProcMaxDia() As Int32
        Get
            Return _ProcMaxDia
        End Get
        Set(value As Int32)
            _ProcMaxDia = value
        End Set
    End Property
    Private _TgCalificacionId As String
    Public Property TgCalificacionId() As String
        Get
            Return _TgCalificacionId
        End Get
        Set(value As String)
            _TgCalificacionId = value
        End Set
    End Property
    Private _TgAreaInicio As String
    Public Property TgAreaInicio() As String
        Get
            Return _TgAreaInicio
        End Get
        Set(value As String)
            _TgAreaInicio = value
        End Set
    End Property
    Private _TgAreaFin As String
    Public Property TgAreaFin() As String
        Get
            Return _TgAreaFin
        End Get
        Set(value As String)
            _TgAreaFin = value
        End Set
    End Property
    Private _ProcFinalidad As String
    Public Property ProcFinalidad() As String
        Get
            Return _ProcFinalidad
        End Get
        Set(value As String)
            _ProcFinalidad = value
        End Set
    End Property
    Private _ProcBaseLegal As String
    Public Property ProcBaseLegal() As String
        Get
            Return _ProcBaseLegal
        End Get
        Set(value As String)
            _ProcBaseLegal = value
        End Set
    End Property
    Private _ProcDerTramite As String
    Public Property ProcDerTramite() As String
        Get
            Return _ProcDerTramite
        End Get
        Set(value As String)
            _ProcDerTramite = value
        End Set
    End Property
    Private _ProcActivo As Boolean
    Public Property ProcActivo() As Boolean
        Get
            Return _ProcActivo
        End Get
        Set(value As Boolean)
            _ProcActivo = value
        End Set
    End Property
    Private _ProcPUIT As Decimal
    Public Property ProcPUIT() As Decimal
        Get
            Return _ProcPUIT
        End Get
        Set(value As Decimal)
            _ProcPUIT = value
        End Set
    End Property

    Public Property OUTablaGeneralAreaInicio() As EETablaGeneral
    Public Property OUTablaGeneralAreaFin() As EETablaGeneral
    Public Property OUTablaGeneralInstitucion() As EETablaGeneral
    Public Property OUTablaGeneralInstitucionR() As EETablaGeneral
    Public Property OUTablaGeneralCalificacion() As EETablaGeneral
End Class
