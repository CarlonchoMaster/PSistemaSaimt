Public Class EEAbonoPEM
    Public Property OPersona() As EEPersona
    Public Property AbonId() As String
    Public Property OConcepto() As EEConceptos
    Public Property AbonFechaIni() As DateTime?
    Public Property AbonFechaFin() As DateTime?
    Public Property AbonHoraReg() As DateTime?
    Public Property AbonFechaReg() As DateTime?
    Public Property OTgEstado() As EETablaGeneral
    Public Property PerRegistra() As String
    Public Property AbonNPlaca1() As String
    Public Property AbonImporte() As Decimal?
    Public Property AbonNPlaca2() As String
    Public Property OTgNivel() As EETablaGeneral
    Public Property AbonNroEspacio() As Int16?
    Public Property AbonNroMeses() As Int16?
    Public Property AbonNPlaca3() As String
    Public Property OTgTipoVehiculo() As EETablaGeneral
    Public Property LoAbonadoDetalle As EEAbonoDetPEM
    Public Property AbonHoraIni() As Date?
    Public Property AbonHoraFin() As Date?
    Public Property abonAplicaHora() As Boolean
    Public Property abonReprogramar() As Boolean
    Public Property ListaAbonoDetPEM As List(Of EEAbonoDetPEM) = New List(Of EEAbonoDetPEM)

    Public Class EEAbonoDetPEM
        Public Property OAbonoPEM As EEAbonoPEM
        Public Property AbonDetId() As String
        Public Property AbonDetNroCuota() As Int32?
        Public Property AbonDetFechaIni() As DateTime?
        Public Property AbonDetFechaFin() As DateTime?
        Public Property AbonDetFecPago() As DateTime?
        Public Property AbonDetFechaGenera() As DateTime?
        Public Property OTgEstado() As EETablaGeneral
        Public Property AbonDetPagado() As Boolean?
        Public Property AbonDetImporte() As Decimal?
        Public Property AbonDetPerReg As String
        ''' <summary>
        ''' True = Actualizar, False = Insertar
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GuardarOrUpdate() As Boolean
    End Class
End Class
