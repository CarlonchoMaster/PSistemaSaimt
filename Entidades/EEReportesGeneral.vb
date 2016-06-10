Public Class EEReportesGeneral

    Public Property RgMesVen() As Int32
    Public Property RgProyeccion() As Decimal?
    Public Property RgPproyeccion() As Decimal?
    Public Property RgIngreso() As Decimal?
    Public Property RgPIngreso() As Decimal?
    Public Property RgMorosidad() As Decimal?
    Public Property RgPmorosidad() As Decimal?
    Public Property RgMontobyFP() As Decimal?

    'PIVOTEAR PROPAGOS
    Public Property ProPaId As String
    Public Property A�o As String
    Public Property PerId As String
    Public Property Persona As String
    Public Property Contacto As String
    Public Property Direccion As String
    Public Property ConId As String
    Public Property ConNombre As String
    Public Property ProPaNroCuota As Int16?
    Public Property ProPaFechaVen As DateTime?
    Public Property ProPaFechaPag As DateTime?
    Public Property ProPaTipoUso As String
    Public Property InmPredArea As Decimal?
    ''' <summary>
    ''' MES CUOTA EN NUMERO
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MesC_Orden As Int16
    ''' <summary>
    ''' MES PAGO EN NUMERO
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MesP_Orden As Int16?
    ''' <summary>
    ''' MES CUOTAS EN LETRAS
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Mes_Cuotas As String
    ''' <summary>
    ''' MES PAGOS EN LETRAS
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Mes_Pagado As String
    Public Property Mes As String
    Public Property Estado As String
    Public Property InmId As String
    Public Property conInmId As String
    Public Property ProPaDetMonto As Decimal?
    Public Property ProPaComision As Decimal?
    'Public Property SitLegalInmueble As String
    'Public Property SitInmueble As String
    Public Property tgInmCondReg As String
    Public Property TgInmCondLegal As String
    Public Property DiferenciaDias As Integer
    Public Property CompPago As String
    Public Property TipoDoc As String
    Public Property NroDoc As String

    ' Control de Ingresos
    Public Property MontoSAIMT As Decimal
    Public Property MontoMPT As Decimal
    Public Property MontoRecaudador As Decimal
    Public Property Monto As Decimal
    Public Property NetoSaimt As Decimal

    'INFOCORP
    Public Property InfFechaReporte As Date?
    Public Property InfCodEntidad As String
    ''' <summary>
    ''' Codigo del Contrato
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property InfCodMorosidad As String
    Public Property InfTipoDocIdentidad As String
    Public Property InfNroDocIdentidad As String
    Public Property InfTipoPersona As String
    Public Property InfTipoDeudor As String
    Public Property InfNombre As String
    Public Property InfDireccion As String
    Public Property InfDepartamento As String
    Public Property InfDistrito As String
    Public Property InfFechaVencimiento As Date?
    Public Property InfTipoDocumento As String
    Public Property InfTipoMoneda As String
    Public Property InfMontoImpago As Decimal
    Public Property InfCondicionDeuda As String


    'RECAUDACION DETALLE
    Public Property PartId As String
    Public Property CentroProduccion As String
    Public Property CuentaCargo As String
    Public Property CuentaAbono As String
    Public Property ConCodConMPT As String
    Public Property ConCodPresMPT As String
    Public Property IngresoMuni As Decimal?
    Public Property RecDFechaLiquidacion As String
    Public Property RecDMonto As Decimal?
    Public Property ConPorcentaje As Decimal?
    Public Property IngresoSAIMT As Decimal?
    Public Property Grupo As String
    Public Property IdMes As String
    Public Property RecFecPago As DateTime?

    'REPORTE TRABAJADORES
    Public Property Trabajador As String
    Public Property InicioContrato As String
    Public Property FinContrato As String
    Public Property Modalidad As String

    'REPORTE INGRESOS PEM
    Public Property Institucion As String
    Public Property Sede As String
    Public Property TipoCliente As String
    Public Property TipoVehiculo As String
    Public Property Placa As String
    Public Property Tarifa As String
    Public Property FechaIngreso As String
    Public Property FechaSalida As String
    Public Property DiarioId As String

    'REPORTE INGRESOS DIARIOS TTSC PEM FINCAS    
    Public Property NroComprobante As String
    Public Property CtaContable As String
    Public Property CtaPresupuestal As String
    Public Property ProPaDetPConcepto As Decimal?

    'PIVOTEAR PEM
    Public Property NroTicket As String
    Public Property FechaInicio As DateTime?
    Public Property FechaTermino As DateTime?
    Public Property Importe As Decimal?
    Public Property EstadoDiario As String
    Public Property HoraIngreso As TimeSpan?
    Public Property HoraSalida As TimeSpan?
    Public Property TipoAbonado As String
    Public Property Concepto As String
    Public Property FechaPago As DateTime
    Public Property HoraPago As TimeSpan
    Public Property TipoUsuario As String
    Public Property NroPlaca As Integer
    'PIVOTEAR ASISTENCIAS
    Public Property Num_Marca As String
    Public Property CodTarjeta As String
    'Public Property Trabajador As String
    Public Property TipoTrabajador As String
    Public Property UnidadOrg As String
    Public Property Documento As String
    Public Property FechaMar As DateTime?
    Public Property Hora As String
    Public Property CodTrabajador As String
    Public Property Incidencia As String
    'Public Property Estado As String
    Public Property Temprano As String
    Public Property Tardanza As String
    Public Property Tipo As String
    Public Property Obs As String
    Public Property NroFaltas As Integer
    'Pivotear Caja Chica
    Public Property NroCaja As String
    Public Property CajaDependencia As String
    Public Property Serie As String
    Public Property Descripcion As String
    Public Property AreaSolicitante As String

    'PIVOTEAR RINCONADA

    Public Property CantPersonas As Integer
End Class