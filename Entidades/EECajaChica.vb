Public Class EECajaChica

    Public Property CajId() As String
    Public Property CajNro() As String
    Public Property TgBancoId() As String
    Public Property CajFondoRetiro() As Decimal?
    Public Property CajFondoAnterior() As Decimal?
    Public Property CajFondoTotal() As Decimal?
    Public Property CajFondoCierre() As Decimal?
    Public Property CajSaldoActual() As Decimal?
    Public Property CajActivo() As Boolean?
    Public Property CajFechaInicio() As DateTime?
    Public Property CajFechaFin() As DateTime?
    Public Property TgEstadoId() As String
    Public Property TgEstado() As String
    Public Property TgAnioId() As String
    Public Property loCajaChicaConfiguracion As EECajaChicaConfiguracion

    Public Class EECajaChicaConfiguracion

        Public Property CcConfId() As String
        Public Property CcConfAnio() As String
        Public Property TgAreaId() As String
        Public Property TgArea() As String
        Public Property CcConfMaxCajasxAnio() As Integer
        Public Property CcConfMaxFondoTotal() As Decimal?
        Public Property CcConfActivo() As Boolean?
        Public Property ccConfMinPorCierre() As Integer
        Public Property ccConfInicioNroDoc() As String
        Public Property ccConfInicioSerieDoc() As String


    End Class

    Public Class EECajaChicaDet

        Public Property CajDetId() As Int32?
        Public Property CajNro() As Int32?
        Public Property CajId() As String
        Public Property CajDetFechaReg() As DateTime?
        Public Property CajDetFechaMov() As DateTime?
        Public Property PerId() As String
        Public Property PerNDoc() As String
        Public Property PerAreaId() As String
        Public Property ConId() As String
        Public Property PartId() As String
        Public Property CajDetDescripcion() As String
        Public Property TgGrupoId() As String
        Public Property TgTipoDocId() As String
        Public Property CajDetDocNro() As String
        Public Property CajDetDocSerie() As String
        Public Property CajDetImporte() As Decimal?
        Public Property UsuId() As Int32?
        Public Property CajDetAnulada() As Boolean?
        Public Property Persona() As String
        Public Property Area() As String
        Public Property AreaS() As String
        Public Property Cargo() As String
        Public Property TgGrupo() As String
        Public Property tgTipoDoc() As String
        Public Property usuario() As String
        Public Property ccConfId() As String



    End Class

End Class
