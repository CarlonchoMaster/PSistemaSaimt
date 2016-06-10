Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class ReportesGeneralDAS

#Region "Reporte Decoin Proyeccion"
    Public Shared Function RptDecoin_proyeccion(ByVal asAnio As String, ByVal asConId As [String]) As List(Of EEReportesGeneral)
        Dim ListaReporteGeneral As List(Of EEReportesGeneral) = Nothing
        Dim loReporteGeneral As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_RptDecoin_Proyeccion_by_Xanio_conId")
            db.AddInParameter(cmd, "Anio", DbType.String, asAnio)
            db.AddInParameter(cmd, "conId", DbType.String, asConId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReporteGeneral Is Nothing Then
                    ListaReporteGeneral = New List(Of EEReportesGeneral)()
                End If

                loReporteGeneral = New EEReportesGeneral()
                loReporteGeneral.RgMesVen = Convert.ToInt32(dr("RgMesVen"))
                loReporteGeneral.RgProyeccion = IIf(IsDBNull(dr("RgProyeccion")), 0, Convert.ToDecimal(dr("RgProyeccion")))
                loReporteGeneral.RgPproyeccion = IIf(IsDBNull(dr("RgPproyeccion")), 0, Convert.ToDecimal(dr("RgPproyeccion")))
                loReporteGeneral.RgIngreso = IIf(IsDBNull(dr("RgIngreso")), 0, Convert.ToDecimal(dr("RgIngreso")))
                loReporteGeneral.RgPIngreso = IIf(IsDBNull(dr("RgPIngreso")), 0, Convert.ToDecimal(dr("RgPIngreso")))
                loReporteGeneral.RgMorosidad = IIf(IsDBNull(dr("RgMorosidad")), 0, Convert.ToDecimal(dr("RgMorosidad")))
                loReporteGeneral.RgPmorosidad = IIf(IsDBNull(dr("RgPmorosidad")), 0, Convert.ToDecimal(dr("RgPmorosidad")))
                loReporteGeneral.RgMontobyFP = IIf(IsDBNull(dr("RgMontobyFP")), 0, Convert.ToDecimal(dr("RgMontobyFP")))
                ListaReporteGeneral.Add(loReporteGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar proyeccion by Anio y conid => " + ex.Message, ex)
        End Try
        Return ListaReporteGeneral
    End Function

    Public Shared Function RptDecoin_ControlIngresos(ByVal asAnio As String, ByVal asMes As [String], asPa As Int16, Optional asFecha As Date = Nothing, Optional asConId As String = Nothing) As List(Of EEReportesGeneral)
        Dim ListaReporteGeneral As List(Of EEReportesGeneral) = Nothing
        Dim loReporteGeneral As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Reporte_ControlIngresos_by_año_mes_pa")
            db.AddInParameter(cmd, "año", DbType.String, asAnio)
            db.AddInParameter(cmd, "mes", DbType.String, asMes)
            db.AddInParameter(cmd, "pa", DbType.Int16, asPa)
            If asConId IsNot Nothing Then
                db.AddInParameter(cmd, "conid", DbType.String, asConId)
            End If
            If asFecha <> "#12:00:00 AM#" Then
                db.AddInParameter(cmd, "dia", DbType.Date, asFecha)
            End If

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReporteGeneral Is Nothing Then
                    ListaReporteGeneral = New List(Of EEReportesGeneral)()
                End If

                loReporteGeneral = New EEReportesGeneral()
                If asPa = 1 Then
                    loReporteGeneral.ConId = IIf(IsDBNull(dr("conid")), 0, dr("conid"))
                End If
                If asPa = 2 Then
                    loReporteGeneral.ProPaFechaPag = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
                End If
                If asPa = 3 Then

                    loReporteGeneral.MontoSAIMT = IIf(IsDBNull(dr("SAIMT")), 0, Convert.ToDecimal(dr("SAIMT")))
                    loReporteGeneral.MontoMPT = IIf(IsDBNull(dr("MPT")), 0, Convert.ToDecimal(dr("MPT")))
                    loReporteGeneral.MontoRecaudador = IIf(IsDBNull(dr("Recaudador")), 0, Convert.ToDecimal(dr("Recaudador")))
                    loReporteGeneral.Monto = IIf(IsDBNull(dr("Monto")), 0, Convert.ToDecimal(dr("Monto")))
                    loReporteGeneral.NetoSaimt = IIf(IsDBNull(dr("Neto")), 0, Convert.ToDecimal(dr("Neto")))
                End If
                ListaReporteGeneral.Add(loReporteGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Reporte Decoin Control de Ingresos  => " + ex.Message, ex)
        End Try
        Return ListaReporteGeneral
    End Function

    Public Shared Function RptDecoin_ControlIngresosConceptos(ByVal asAnio As String, ByVal asMes As [String], asPa As String) As List(Of EEReportesGeneral)
        Dim ListaReporteGeneral As List(Of EEReportesGeneral) = Nothing
        Dim loReporteGeneral As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Reporte_ControlIngresos_by_año_mes_pa")
            db.AddInParameter(cmd, "año", DbType.String, asAnio)
            db.AddInParameter(cmd, "mes", DbType.String, asMes)
            db.AddInParameter(cmd, "pa", DbType.String, asPa)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReporteGeneral Is Nothing Then
                    ListaReporteGeneral = New List(Of EEReportesGeneral)()
                End If

                loReporteGeneral = New EEReportesGeneral()
                loReporteGeneral.ConId = IIf(IsDBNull(dr("conid")), 0, dr("conid"))
                ListaReporteGeneral.Add(loReporteGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Reporte Decoin Control de Ingresos  => " + ex.Message, ex)
        End Try
        Return ListaReporteGeneral
    End Function
#End Region

#Region "Reporte PivotearProPagos"
    ''' <summary>
    ''' Reporte PivotearProPagos
    ''' </summary>
    ''' <param name="asTipoCriterio"></param>
    ''' 
    ''' 
    ''' 
    ''' <param name="asCriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function reportePivotearProPagosCriterio(ByVal asTipoCriterio As String, ByVal asCriterio As String) As List(Of EEReportesGeneral)
        Dim ListaReporte As List(Of EEReportesGeneral) = Nothing
        Dim loReporte As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Pivoter_ProgramacionesPagos")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipocriterio", DbType.String, asTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReporte Is Nothing Then
                    ListaReporte = New List(Of EEReportesGeneral)()
                End If
                loReporte = New EEReportesGeneral()
                loReporte.ProPaId = dr("ProPaId").ToString()
                loReporte.Año = dr("Año").ToString()
                loReporte.PerId = dr("PerId").ToString()
                loReporte.Persona = dr("Personas").ToString()
                loReporte.Contacto = dr("Contacto").ToString()
                loReporte.Direccion = dr("Direccion").ToString()
                loReporte.ConId = dr("ConId").ToString()
                loReporte.ConNombre = dr("ConNombre").ToString()
                loReporte.ProPaDetMonto = Convert.ToDecimal(dr("ProPaDetMonto").ToString())
                loReporte.ProPaNroCuota = Convert.ToInt16(dr("ProPaNroCuota").ToString())
                If Not IsDBNull(dr("ProPaFechaPag")) Then
                    loReporte.ProPaFechaPag = Convert.ToDateTime(dr("ProPaFechaPag").ToString())
                End If
                loReporte.ProPaFechaVen = Convert.ToDateTime(dr("ProPaFechaVen").ToString())
                If Not IsDBNull(dr("proPaDetComision")) Then
                    loReporte.ProPaComision = Convert.ToDecimal(dr("proPaDetComision"))
                End If
                If Not IsDBNull(dr("neto_Saimt")) Then
                    loReporte.NetoSaimt = Convert.ToDecimal(dr("neto_Saimt"))
                End If
                loReporte.MesC_Orden = Convert.ToInt16(dr("MesC_Orden").ToString())
                loReporte.Mes_Cuotas = dr("Mes_Cuotas").ToString()
                If Not IsDBNull(dr("MesP_Orden")) Then
                    loReporte.MesP_Orden = Convert.ToInt16(dr("MesP_Orden").ToString())
                End If
                loReporte.Mes_Pagado = dr("Mes_Pagado").ToString()
                loReporte.Estado = dr("Estado").ToString()
                loReporte.InmId = dr("InmId").ToString()
                loReporte.tgInmCondReg = dr("tgInmCondReg").ToString()
                loReporte.TgInmCondLegal = dr("TgInmCondLegal").ToString()
                loReporte.DiferenciaDias = CInt(dr("DiferenciaDias"))
                If dr("ComprobantePago") Is DBNull.Value Then
                    loReporte.CompPago = "No Registra"
                Else
                    loReporte.CompPago = dr("ComprobantePago").ToString
                End If
                If dr("tgTipoDoc") Is DBNull.Value Then
                    loReporte.TipoDoc = "No Registra"
                Else
                    loReporte.TipoDoc = dr("tgTipoDoc").ToString
                End If
                If dr("perNDoc") Is DBNull.Value Then
                    loReporte.NroDoc = "No Registra"
                Else
                    loReporte.NroDoc = dr("perNDoc").ToString
                End If
                If dr("tgUsoNombre") Is DBNull.Value Then
                    loReporte.ProPaTipoUso = String.Empty
                Else
                    loReporte.ProPaTipoUso = dr("tgUsoNombre")
                End If
                loReporte.InmPredArea = dr("InmPredArea").ToString()
                loReporte.MontoSAIMT = CDec(dr("IngSAIMT"))
                loReporte.MontoMPT = CDec(dr("IngMPT"))
                ListaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Reporte Pivotear ProPagos Criterio => " + ex.Message, ex)
        End Try
        Return ListaReporte
    End Function
#End Region

#Region "Reporte De Deudores en DECOIN"
    Public Shared Function reporteDeudoresDECOIN() As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loProPagosDetalle As EEProPagos.EEProPagosDet = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim dr As IDataReader = Nothing
        Dim drProPag As IDataReader = Nothing
        Dim drProPagDetalle As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Reporte_Deudores_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("ConInmId").ToString()
                loContratoInm.InmId = dr("InmId").ToString()

                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()
                loPersona.PerContacto = dr("PerContacto").ToString()

                loContratoInm.OPersona = loPersona

                If Not IsDBNull(dr("ConInmMerced")) Then
                    loContratoInm.ConInmMerced = Convert.ToDecimal(dr("ConInmMerced").ToString())
                End If
                If Not IsDBNull(dr("conInmFecIni")) Then
                    loContratoInm.ConInmFecIni = Convert.ToDateTime(dr("conInmFecIni").ToString())
                End If
                If Not IsDBNull(dr("conInmFecFin")) Then
                    loContratoInm.ConInmFecFin = Convert.ToDateTime(dr("conInmFecFin").ToString())
                End If
                If Not IsDBNull(dr("conInmFecReg")) Then
                    loContratoInm.ConInmFecReg = Convert.ToDateTime(dr("conInmFecReg").ToString())
                End If

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgMonId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreMoneda").ToString()

                loContratoInm.OTgMoneda = loTablaGeneral

                loContratoInm.ConInmObs = dr("conInmObs").ToString()
                loContratoInm.InmDir = dr("inmDirCon").ToString()

                cmd = db.GetStoredProcCommand("Mostrar_ProPagos_XConInmId_EnReporteDeudores_pa")
                db.AddInParameter(cmd, "coninmid", DbType.String, loContratoInm.ConInmId)

                drProPag = db.ExecuteReader(cmd)
                While drProPag.Read()
                    loProPagos = New EEProPagos()
                    loProPagos.ProPaId = drProPag("ProPaId").ToString()

                    cmd = db.GetStoredProcCommand("Mostrar_ProPagosDet_XProPaId_EnReporteDeudores_pa")
                    db.AddInParameter(cmd, "proPaId", DbType.String, loProPagos.ProPaId)
                    drProPagDetalle = db.ExecuteReader(cmd)
                    While drProPagDetalle.Read()
                        If loProPagos.ListaProgramacionPagosDetalle Is Nothing Then
                            loProPagos.ListaProgramacionPagosDetalle = New List(Of EEProPagos.EEProPagosDet)
                        End If
                        loProPagosDetalle = New EEProPagos.EEProPagosDet()
                        loProPagosDetalle.ProPaDetMonto = Convert.ToDecimal(drProPagDetalle("ProPaDetMonto").ToString())
                        loProPagosDetalle.ProPaDetPConcepto = Convert.ToDecimal(drProPagDetalle("ProPaDetPConcepto").ToString())
                        loConceptos = New EEConceptos()
                        loConceptos.ConId = drProPagDetalle("ConId").ToString()
                        loConceptos.ConNombre = drProPagDetalle("ConNombre").ToString()
                        loProPagosDetalle.OConcepto = loConceptos
                        loProPagos.ListaProgramacionPagosDetalle.Add(loProPagosDetalle)
                    End While
                    drProPagDetalle.Close()
                    loContratoInm.ListaProgramacionPagos.Add(loProPagos)
                End While
                drProPag.Close()

                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Reporte De Deudores en DECOIN => " & ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#End Region

#Region "Reporte de Notificaciones de Deudores"
    Public Shared Function NotificacionesDeudores(ByVal asTipoCriterio As Short, ByVal asCriterio As Short) As List(Of EENotificaciones)
        Dim listaReporte As List(Of EENotificaciones) = Nothing
        Dim loNotificacion As EENotificaciones = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("ListarNotificacionesDecoin")
            db.AddInParameter(cmd, "tipocriterio", DbType.Int16, asTipoCriterio)
            db.AddInParameter(cmd, "param", DbType.Int16, asCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If listaReporte Is Nothing Then
                    listaReporte = New List(Of EENotificaciones)()
                End If
                loNotificacion = New EENotificaciones
                If asTipoCriterio = 1 Then
                    loNotificacion.ProPaId = dr("proPaId").ToString
                    loNotificacion.ProPaNroCuota = CShort(dr("proPaNroCuota"))
                    loNotificacion.MesId = CShort(dr("Mes"))
                    loNotificacion.perId = dr("perId").ToString
                    loNotificacion.PerNombres = dr("NomPersona").ToString
                    loNotificacion.PerContacto = dr("ContactoPer").ToString
                    loNotificacion.InmId = dr("inmId").ToString
                    loNotificacion.InmDirCon = dr("inmDirCon").ToString
                    loNotificacion.ConInmId = dr("conInmId").ToString()
                Else
                    loNotificacion.ConInmId = dr("conInmId").ToString()
                    loNotificacion.perId = dr("perId").ToString
                    loNotificacion.PerNombres = dr("NomPersona")
                    loNotificacion.PerContacto = dr("ContactoPer")
                    loNotificacion.InmId = dr("inmId")
                    loNotificacion.InmDirCon = dr("inmDirCon")
                    loNotificacion.conInmFecIni = dr("conInmFecIni")
                    loNotificacion.conInmFecFin = dr("conInmFecFin")
                    loNotificacion.TgNombreUso = dr("tgNombreUso")
                    loNotificacion.conInmMerced = dr("conInmMerced")
                    loNotificacion.tgNombreGar = dr("tgNombreGar")
                    loNotificacion.conInmGarantia = dr("conInmGarantia")
                    If dr("conInmFecSus") Is DBNull.Value Then
                        loNotificacion.conInmFecSus = CDate("01/01/0001")
                    Else
                        loNotificacion.conInmFecSus = dr("conInmFecSus")
                    End If
                    loNotificacion.tgEstId = dr("tgEstId")
                    End If
                    listaReporte.Add(loNotificacion)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Reporte Pivotear ProPagos Criterio => " + ex.Message, ex)
        End Try
        Return listaReporte
    End Function
#End Region

#Region "Reporte De Deudores en Infocorp"
    Public Shared Function reporteDeudoresInfocorp() As List(Of EEReportesGeneral)
        Dim ListaDeudoresInfocorp As List(Of EEReportesGeneral) = Nothing
        Dim loReportesGeneral As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Reporte_Deudores_Inforcorp_pa")
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDeudoresInfocorp Is Nothing Then
                    ListaDeudoresInfocorp = New List(Of EEReportesGeneral)()
                End If

                loReportesGeneral = New EEReportesGeneral()
                loReportesGeneral.InfFechaReporte = Convert.ToDateTime(dr("FechaReporte").ToString())
                loReportesGeneral.InfCodEntidad = dr("CodEntidad").ToString()
                loReportesGeneral.InfCodMorosidad = dr("CodMorosidad").ToString()
                loReportesGeneral.InfTipoDocIdentidad = dr("TipoDocIdentidad").ToString()
                loReportesGeneral.InfNroDocIdentidad = dr("NroDocIdentidad").ToString()
                loReportesGeneral.InfTipoPersona = dr("TipoPersona").ToString()
                loReportesGeneral.InfTipoDeudor = dr("TipoDeudor").ToString()
                loReportesGeneral.InfNombre = dr("Nombre").ToString()
                loReportesGeneral.InfDireccion = dr("Direccion").ToString()
                loReportesGeneral.InfDistrito = dr("Distrito").ToString()
                loReportesGeneral.InfDepartamento = dr("Departamento").ToString()
                loReportesGeneral.InfFechaVencimiento = Convert.ToDateTime(dr("FechaVencimiento").ToString())
                loReportesGeneral.InfTipoDocumento = Convert.ToDateTime(dr("TipoDocumento").ToString())
                loReportesGeneral.InfTipoMoneda = dr("TipoMoneda").ToString()
                loReportesGeneral.InfMontoImpago = Convert.ToDecimal(dr("TipoMoneda").ToString())
                loReportesGeneral.InfCondicionDeuda = dr("TipoMoneda").ToString()
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Reporte De Deudores Inforcorp => " & ex.Message, ex)
        End Try
        Return ListaDeudoresInfocorp
    End Function
#End Region

#Region "Listar Recaudacion Detalle X Año y FechaDeposito"
    Public Shared Function ListarRecaudacionDetalleXAñoXFechaDeposito(ByVal asAño As Short, ByVal adFechaDeposito As Date?, ByVal aiOpcion As Int16) As List(Of EEReportesGeneral)
        Dim loReporte As EEReportesGeneral = Nothing
        Dim listaReporte As List(Of EEReportesGeneral) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Pivotear_RecaudacionDetalle_pa")
            db.AddInParameter(cmd, "opcion", DbType.Int16, aiOpcion)
            db.AddInParameter(cmd, "año", DbType.Int16, asAño)
            db.AddInParameter(cmd, "fechadeposito", DbType.Date, adFechaDeposito)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If listaReporte Is Nothing Then
                    listaReporte = New List(Of EEReportesGeneral)
                End If
                loReporte = New EEReportesGeneral()
                loReporte.PartId = dr("PartId").ToString()
                loReporte.CentroProduccion = dr("CentroProduccion").ToString()
                loReporte.CuentaCargo = dr("CuentaCargo").ToString()
                loReporte.CuentaAbono = dr("CuentaAbono").ToString()
                loReporte.ConCodConMPT = dr("ConCodConMPT").ToString()
                loReporte.ConCodPresMPT = dr("ConCodPresMPT").ToString()
                loReporte.IngresoMuni = dr("IngresoMuni").ToString()
                loReporte.RecDFechaLiquidacion = dr("RecDFechaLiquidacion").ToString()
                loReporte.RecDMonto = dr("RecDMonto").ToString()
                loReporte.ConPorcentaje = dr("ConPorcentaje").ToString()
                loReporte.IngresoSAIMT = dr("IngresoSAIMT").ToString()
                loReporte.Grupo = dr("Grupo").ToString()
                loReporte.Año = dr("Año").ToString()
                loReporte.IdMes = dr("IdMes").ToString()
                loReporte.Mes = dr("Mes").ToString()
                loReporte.RecFecPago = dr("RecFecPago").ToString()
                loReporte.ConId = dr("ConId").ToString()
                loReporte.ConNombre = dr("ConNombre").ToString()

                listaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Recaudacion Detalle XAño XFechaDeposito => " + ex.Message, ex)
        End Try
        Return listaReporte
    End Function
#End Region

#Region "Listar Ordenes de Servicio entre fechas"
    Public Shared Function PivotOrdenServicioXFecha(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEOrdenServicio)
        Dim loReporte As EEOrdenServicio = Nothing
        Dim listaReporte As List(Of EEOrdenServicio) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Pivotear_OrdenServicioDetalle_pa")
            db.AddInParameter(cmd, "FechaInicio", DbType.Date, adFechaInicio)
            db.AddInParameter(cmd, "FechaFin", DbType.Date, adFechaFin)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If listaReporte Is Nothing Then
                    listaReporte = New List(Of EEOrdenServicio)()
                End If
                loReporte = New EEOrdenServicio()
                loReporte.OrdId = dr("ordId").ToString()
                loReporte.OrdNro = dr("ordNro").ToString()
                loReporte.OrdFechaDoc = IIf(IsDBNull(dr("ordFechaDoc")), Nothing, dr("ordFechaDoc"))
                loReporte.TgEstado = dr("tgEstado").ToString()
                loReporte.TgCompPago = dr("tgCompPago").ToString()
                loReporte.OrdNroCompPago = dr("ordNroCompPago").ToString()
                loReporte.PerProv = dr("perProv").ToString()
                loReporte.PerProvNDoc = dr("perNDoc").ToString()
                loReporte.OrdRefDoc = dr("ordRefDoc").ToString()
                loReporte.TgCuentaDebeId = dr("tgCuentaDebeId").ToString()
                loReporte.TgCuentaDebe = dr("tgCuentaDebe").ToString()
                loReporte.TgCuentaHaberId = dr("tgCuentaHaberId").ToString()
                loReporte.TgCuentaHaber = dr("tgCuentaHaber").ToString()
                loReporte.PartId = dr("partId").ToString()
                loReporte.PartNombre = dr("partNombre").ToString()
                loReporte.CerId = dr("cerId").ToString()
                loReporte.CerNro = dr("cerNro").ToString()
                loReporte.TgFFinancieraId = dr("tgFFinancieraId").ToString()
                loReporte.TgMetaId = dr("tgMetaId").ToString()
                loReporte.TgActProyId = dr("tgActProyId").ToString()
                loReporte.OrdImporte = dr("ordImporte").ToString()
                ' Cambiar nombre  ordDetImporteIGV
                loReporte.OrdImporteIGV = dr("ordImporteIGV").ToString()
                'Cambiar nombre ordDetTotal
                loReporte.OrdTotal = dr("ordTotal").ToString()
                'Detalle de Ordenes de Servicio
                loReporte.OrdenServicioDet = New EEOrdenServicio.EEOrdenServicioDet
                loReporte.OrdenServicioDet.OrdDetId = dr("ordDetId").ToString()
                loReporte.OrdenServicioDet.OrdDetDescripcion = dr("ordDetDescripcion").ToString()
                loReporte.OrdenServicioDet.TgCatServ = dr("tgCatServ").ToString()
                loReporte.OrdenServicioDet.OrdDetPrecio = dr("ordDetPrecio").ToString()
                loReporte.OrdenServicioDet.OrdDetRta4ta = dr("ordDetRta4ta").ToString()
                loReporte.OrdenServicioDet.OrdDetAjuste = dr("ordDetAjuste").ToString()
                listaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Ordenes de Servicio Detalle X Fecha => " + ex.Message, ex)
        End Try
        Return listaReporte
    End Function
#End Region

#Region "Listar Resumen Ordenes de Servicio entre fechas"
    Public Shared Function PivotResumenOrdenServicioXFecha(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEOrdenServicio)
        Dim loReporte As EEOrdenServicio = Nothing
        Dim listaReporte As List(Of EEOrdenServicio) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Pivotear_ResumenOrdenServicio_pa")
            db.AddInParameter(cmd, "FechaInicio", DbType.Date, adFechaInicio)
            db.AddInParameter(cmd, "FechaFin", DbType.Date, adFechaFin)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If listaReporte Is Nothing Then
                    listaReporte = New List(Of EEOrdenServicio)()
                End If
                loReporte = New EEOrdenServicio()
                loReporte.Item = dr("item")
                loReporte.OrdDia = dr("ordDia").ToString()
                loReporte.OrdNro = dr("ordNro").ToString()
                loReporte.PerProvNDoc = dr("perNDoc").ToString()
                loReporte.OrdNroCompPago = dr("ordNroCompPago").ToString()
                loReporte.PerProv = dr("perProv").ToString()
                loReporte.OrdenServicioDet = New EEOrdenServicio.EEOrdenServicioDet
                loReporte.OrdenServicioDet.OrdDetDescripcion = dr("ordDetDescripcion").ToString()
                loReporte.PartId = dr("partId").ToString()
                loReporte.OrdImporte = dr("ordImporte").ToString()
                loReporte.OrdImporteIGV = dr("ordImporteIGV").ToString()
                loReporte.OrdTotal = dr("ordTotal").ToString()
                loReporte.OrdNetoPagado = dr("ordNetoPagado").ToString()

                listaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Resumen Ordenes de Servicio X Fecha => " + ex.Message, ex)
        End Try
        Return listaReporte
    End Function
#End Region

#Region "Listar Ordenes de COmpra y Servicio OSCE"

    Public Shared Function ReporteOSCEOrdenCompraServicioXFechas(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEOrdenCompra)
        Dim loReporte As EEOrdenCompra = Nothing
        Dim listaReporte As List(Of EEOrdenCompra) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Pivotear_ReporteOSCE_pa")
            db.AddInParameter(cmd, "FechaInicio", DbType.Date, adFechaInicio)
            db.AddInParameter(cmd, "FechaFin", DbType.Date, adFechaFin)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If listaReporte Is Nothing Then
                    listaReporte = New List(Of EEOrdenCompra)()
                End If
                loReporte = New EEOrdenCompra()
                loReporte.Idgeneral = dr("O/C U O/S").ToString()
                loReporte.OrdNro = dr("N°").ToString()
                loReporte.OrdFechaDoc = IIf(IsDBNull(dr("ordFechaDoc")), Nothing, dr("ordFechaDoc"))
                loReporte.TgEstado = dr("Estado").ToString()
                loReporte.PerProvNDoc = dr("perNDoc").ToString()
                loReporte.informacionComplementaria = dr("Informacion Complementaria").ToString()
                loReporte.tipoContratacion = dr("Tipo Contratacion").ToString()
                loReporte.ObjectoContratacion = dr("Objecto Contratacion").ToString()
                loReporte.OrdTotal = dr("ordTotal").ToString()
                loReporte.Descripcion = dr("Descripcion").ToString()
                loReporte.tipoMoneda = dr("Tipo Moneda").ToString()
                loReporte.tipocambio = dr("Tipo de Cambio").ToString()
                listaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Ordenes de Servicio Detalle X Fecha => " + ex.Message, ex)
        End Try
        Return listaReporte
    End Function
#End Region
#Region "Listar Ordenes de Compra entre fechas"
    Public Shared Function PivotOrdenCompraXFecha(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEOrdenCompra)
        Dim loReporte As EEOrdenCompra = Nothing
        Dim listaReporte As List(Of EEOrdenCompra) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Pivotear_OrdenCompraDetalle_pa")
            db.AddInParameter(cmd, "FechaInicio", DbType.Date, adFechaInicio)
            db.AddInParameter(cmd, "FechaFin", DbType.Date, adFechaFin)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If listaReporte Is Nothing Then
                    listaReporte = New List(Of EEOrdenCompra)()
                End If
                loReporte = New EEOrdenCompra()
                loReporte.OrdId = dr("ordId").ToString()
                loReporte.OrdNro = dr("ordNro").ToString()
                loReporte.OrdFechaDoc = IIf(IsDBNull(dr("ordFechaDoc")), Nothing, dr("ordFechaDoc"))
                loReporte.TgEstado = dr("tgEstado").ToString()
                loReporte.OrdNroCompPago = dr("ordNroCompPago").ToString()
                loReporte.PerProv = dr("perProv").ToString()
                loReporte.PerProvNDoc = dr("perNDoc").ToString()
                loReporte.OrdRefDoc = dr("ordRefDoc").ToString()
                loReporte.tgCuentaDebeId = dr("tgCuentaDebeId").ToString()
                loReporte.tgCuentaDebe = dr("tgCuentaDebe").ToString()
                loReporte.tgCuentaHaberId = dr("tgCuentaHaberId").ToString()
                loReporte.tgCuentaHaber = dr("tgCuentaHaber").ToString()
                loReporte.PartId = dr("partId").ToString()
                loReporte.PartNombre = dr("partNombre").ToString()
                loReporte.CerId = dr("cerId").ToString()
                loReporte.CerNro = dr("cerNro").ToString()
                loReporte.tgFFinancieraId = dr("tgFFinancieraId").ToString()
                loReporte.tgMetaId = dr("tgMetaId").ToString()
                loReporte.tgActProyId = dr("tgActProyId").ToString()
                loReporte.ordImporte = dr("ordImporte").ToString()
                loReporte.OrdImporteIGV = dr("ordImporteIGV").ToString()
                loReporte.OrdTotal = dr("ordTotal").ToString()
                'Detalle de Ordenes de Servicio
                loReporte.OrdenCompraDet = New EEOrdenCompra.EEOrdenCompraDet
                loReporte.OrdenCompraDet.OrdDetId = dr("ordDetId").ToString()
                loReporte.OrdenCompraDet.OArticulo = New EEArticulo
                loReporte.OrdenCompraDet.OArticulo.ArtDescripcion = dr("artDescripcion").ToString()
                loReporte.OrdenCompraDet.TgUm = dr("tgUM").ToString()
                loReporte.OrdenCompraDet.OrdDetCantidad = dr("ordDetCantidad").ToString()
                loReporte.OrdenCompraDet.OrdDetPrecio = dr("ordDetPrecio").ToString()
                listaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Ordenes de Servicio Detalle X Fecha => " + ex.Message, ex)
        End Try
        Return listaReporte
    End Function
    'Public Shared Function PivotOrdenCompraXFecha(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEReportesGeneral)
    '    Dim loReporte As EEReportesGeneral = Nothing
    '    Dim listaReporte As List(Of EEReportesGeneral) = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Pivotear_OrdenCompraDetalle_pa")
    '        db.AddInParameter(cmd, "FechaInicio", DbType.Date, adFechaInicio)
    '        db.AddInParameter(cmd, "FechaFin", DbType.Date, adFechaFin)
    '        dr = db.ExecuteReader(cmd)
    '        While dr.Read()
    '            If listaReporte Is Nothing Then
    '                listaReporte = New List(Of EEReportesGeneral)()
    '            End If
    '            loReporte = New EEReportesGeneral()
    '            loReporte.ordId = dr("ordId").ToString()
    '            loReporte.ordNro = dr("ordNro").ToString()
    '            loReporte.ordFechaDoc = IIf(IsDBNull(dr("ordFechaDoc")), Nothing, dr("ordFechaDoc"))
    '            loReporte.tgEstado = dr("tgEstado").ToString()
    '            loReporte.ordNroCompPago = dr("ordNroCompPago").ToString()
    '            loReporte.perProv = dr("perProv").ToString()
    '            loReporte.perNDoc = dr("perNDoc").ToString()
    '            loReporte.ordRefCert = dr("ordRefCert").ToString()
    '            loReporte.ordRefDoc = dr("ordRefDoc").ToString()
    '            loReporte.tgCuentaDebeId = dr("tgCuentaDebeId").ToString()
    '            loReporte.tgCuentaDebe = dr("tgCuentaDebe").ToString()
    '            loReporte.tgCuentaHaberId = dr("tgCuentaHaberId").ToString()
    '            loReporte.tgCuentaHaber = dr("tgCuentaHaber").ToString()
    '            loReporte.partOSId = dr("partId").ToString()
    '            loReporte.tgFFinancieraId = dr("tgFFinancieraId").ToString()
    '            loReporte.tgMetaId = dr("tgMetaId").ToString()
    '            loReporte.tgActProyId = dr("tgActProyId").ToString()
    '            loReporte.ordImporte = dr("ordImporte").ToString()
    '            loReporte.ordDetImporteIGV = dr("ordDetImporteIGV").ToString()
    '            loReporte.ordTotal = dr("ordDetTotal").ToString()
    '            'Detalle de Ordenes de Servicio
    '            loReporte.ordDetId = dr("ordDetId").ToString()
    '            loReporte.artDescripcion = dr("artDescripcion").ToString()
    '            loReporte.tgUM = dr("tgUM").ToString()
    '            loReporte.ordDetCantidad = dr("ordDetCantidad").ToString()
    '            loReporte.ordDetPrecio = dr("ordDetPrecio").ToString()
    '            listaReporte.Add(loReporte)
    '        End While
    '        dr.Close()
    '    Catch ex As Exception
    '        Throw New Exception("Listar Ordenes de Servicio Detalle X Fecha => " + ex.Message, ex)
    '    End Try
    '    Return listaReporte
    'End Function
#End Region

#Region "Listar Salida Articulo Almacen entre fechas"
    Public Shared Function PivotPecosaXFecha(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEPecosa)
        Dim loReporte As EEPecosa = Nothing
        Dim listaReporte As List(Of EEPecosa) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Pivotear_PecosaDetalle_pa")
            db.AddInParameter(cmd, "FechaInicio", DbType.Date, adFechaInicio)
            db.AddInParameter(cmd, "FechaFin", DbType.Date, adFechaFin)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If listaReporte Is Nothing Then
                    listaReporte = New List(Of EEPecosa)()
                End If
                loReporte = New EEPecosa()
                loReporte.PecId = dr("pecId").ToString()
                loReporte.PecNro = dr("pecNro").ToString()
                loReporte.OrdNro = dr("ordNro").ToString()
                loReporte.PerSolicita = dr("perSolicita").ToString()
                loReporte.TgAreaDes = dr("tgAreaDes").ToString()
                loReporte.PecFecha = dr("pecFecha").ToString()
                loReporte.TgCuentaDebeId = dr("tgCuentaDebeId").ToString()
                loReporte.TgCuentaHaberId = dr("tgCuentaHaberId").ToString()
                loReporte.PecosaOCDet = New EEPecosa.EEPecosaOCDet
                loReporte.PecosaOCDet.CanOrdComDet = dr("pecDetCanTotal").ToString()
                loReporte.PecosaOCDet.PrecOrdComDet = dr("pecDetPrecioUnit").ToString()
                loReporte.PecosaOCDet.PecSubTotal = dr("pecSubTotal").ToString()
                loReporte.PecosaDet = New EEPecosa.EEPecosaDet
                loReporte.PecosaDet.TgUm = dr("tgUM").ToString()
                loReporte.PecosaDet.OArticulo = New EEArticulo
                loReporte.PecosaDet.OArticulo.ArtNombre = dr("artDescripcion").ToString()
                loReporte.PecosaDet.OArticulo.ArtDescripcion = dr("pecDescripcion").ToString()
                loReporte.pecAnulado = dr("pecAnulado").ToString
                loReporte.cerNro = dr("cerNro").ToString
                listaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar  Salida Articulo Almacen Detalle X Fecha => " + ex.Message, ex)
        End Try
        Return listaReporte
    End Function
#End Region

#Region "Reporte la Programacion Pagos Detalle X RangoFecha"
    ''' <summary>
    ''' Reporte la Programacion Pagos Detalle X RangoFecha
    ''' </summary>
    ''' <param name="adtFecha1"></param>
    ''' <param name="adtFecha2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function reporteProPagosDetalleXRangoFecha(adtFecha1 As Date, adtFecha2 As Date) As List(Of EEReportesGeneral)
        Dim ListaReporte As List(Of EEReportesGeneral) = Nothing
        Dim loReporte As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("RListar_ProPagosDet_XRangoFecha_pa")
            db.AddInParameter(cmd, "fecha1", DbType.Date, adtFecha1)
            db.AddInParameter(cmd, "fecha2", DbType.Date, adtFecha2)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReporte Is Nothing Then
                    ListaReporte = New List(Of EEReportesGeneral)()
                End If
                loReporte = New EEReportesGeneral()
                loReporte.ProPaId = dr("ProPaId").ToString()
                loReporte.ProPaFechaPag = Convert.ToDateTime(dr("proPaFechaPag").ToString())
                loReporte.NroComprobante = dr("NroComprobante").ToString()
                loReporte.ConId = dr("ConId").ToString()
                loReporte.CtaContable = dr("CtaContable").ToString()
                loReporte.CtaPresupuestal = dr("CtaPresupuestal").ToString()
                loReporte.Persona = dr("Persona").ToString()
                loReporte.ProPaDetMonto = Convert.ToDecimal(dr("ProPaDetMonto").ToString())
                loReporte.ProPaDetPConcepto = Convert.ToDecimal(dr("ProPaDetPConcepto").ToString())
                ListaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("RListar ProPagos Detalle X RangoFecha => " + ex.Message, ex)
        End Try
        Return ListaReporte
    End Function
#End Region

#Region "Reporte la Programacion Pagos Detalle Conceptos X RangoFecha"
    ''' <summary>
    ''' Reporte la Programacion Pagos Detalle X RangoFecha
    ''' </summary>
    ''' <param name="adtFecha1"></param>
    ''' <param name="adtFecha2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function reporteProPagosDetalleConceptosXRangoFecha(adtFecha1 As Date, adtFecha2 As Date) As List(Of EEReportesGeneral)
        Dim ListaReporte As List(Of EEReportesGeneral) = Nothing
        Dim loReporte As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("RListar_ProPagosDetConceptos_XRangoFecha_pa")
            db.AddInParameter(cmd, "fecha1", DbType.Date, adtFecha1)
            db.AddInParameter(cmd, "fecha2", DbType.Date, adtFecha2)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReporte Is Nothing Then
                    ListaReporte = New List(Of EEReportesGeneral)()
                End If
                loReporte = New EEReportesGeneral()
                loReporte.ProPaFechaPag = Convert.ToDateTime(dr("proPaFechaPag").ToString())
                loReporte.ConId = dr("ConId").ToString()
                loReporte.ConNombre = dr("ConNombre").ToString()
                loReporte.CtaContable = dr("CtaContable").ToString()
                loReporte.CtaPresupuestal = dr("CtaPresupuestal").ToString()
                loReporte.ProPaDetMonto = Convert.ToDecimal(dr("ProPaDetMonto").ToString())
                loReporte.ProPaDetPConcepto = Convert.ToDecimal(dr("ProPaDetPConcepto").ToString())
                ListaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("RListar ProPagos Detalle Conceptos X RangoFecha => " + ex.Message, ex)
        End Try
        Return ListaReporte
    End Function
#End Region

#Region "Reporte Recaudacion Detalle XRangoFecha y XTgGrupoConId"
    ''' <summary>
    ''' Reporte Recaudacion Detalle XRangoFecha y XTgGrupoConId
    ''' </summary>
    ''' <param name="adtFecha1"></param>
    ''' <param name="adtFecha2"></param>
    ''' <param name="asTgGrupoConId">06=PEM,07=TTSC</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function reporteRecaudacionDetXRangoFechaXTgGrupoConId(adtFecha1 As Date, adtFecha2 As Date, asTgGrupoConId As String) As List(Of EEReportesGeneral)
        Dim ListaReporte As List(Of EEReportesGeneral) = Nothing
        Dim loReporte As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("RListar_RecaudacionDet_Total_XRangoFecha_XTgGrupoConId_pa")
            db.AddInParameter(cmd, "fecha1", DbType.Date, adtFecha1)
            db.AddInParameter(cmd, "fecha2", DbType.Date, adtFecha2)
            db.AddInParameter(cmd, "tggrupoconid", DbType.String, asTgGrupoConId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReporte Is Nothing Then
                    ListaReporte = New List(Of EEReportesGeneral)()
                End If
                loReporte = New EEReportesGeneral()
                loReporte.RecFecPago = Convert.ToDateTime(dr("RecFecPago").ToString())
                loReporte.ConNombre = dr("ConNombre").ToString()
                loReporte.RecDMonto = dr("RecDMonto").ToString()
                loReporte.ConPorcentaje = dr("ConPorcentaje").ToString()
                If dr("ConPorcentaje") Is DBNull.Value Then
                    loReporte.ConId = String.Empty
                Else
                    loReporte.ConId = dr("conId").ToString
                End If
                ListaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("RListar Recaudacion Detalle Total XRangoFecha y XTgGrupoConId => " + ex.Message, ex)
        End Try
        Return ListaReporte
    End Function
#End Region

#Region "Reporte Recaudacion XRecFecPago y XTgGrupoConId"
    ''' <summary>
    ''' Reporte Recaudacion XRecFecPago y XTgGrupoConId
    ''' </summary>
    ''' <param name="adtRecFecPago"></param>
    ''' <param name="asTgGrupoConId">06=PEM,07=TTSC</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function reporteRecaudacionXRecFecPagoXTgGrupoConId(adtRecFecPago As Date, asTgGrupoConId As String) As EEReportesGeneral
        Dim loReporte As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("RListar_Recaudacion_Total_XRecFecPago_XTgGrupoConId_pa")
            db.AddInParameter(cmd, "recfecpago", DbType.Date, adtRecFecPago)
            db.AddInParameter(cmd, "tggrupoconid", DbType.String, asTgGrupoConId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loReporte = New EEReportesGeneral()
                loReporte.RecFecPago = Convert.ToDateTime(dr("RecFecPago").ToString())
                loReporte.RecDMonto = dr("RecDMonto").ToString()
                loReporte.ConPorcentaje = dr("ConPorcentaje").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("RListar Recaudacion XRecFecPago y XTgGrupoConId => " + ex.Message, ex)
        End Try
        Return loReporte
    End Function
#End Region

#Region "Pivotear Caja Chica"
    Public Shared Function Pivotear_CajaChica(ByVal anio As String) As List(Of EEReportesGeneral)
        Dim loReporte As EEReportesGeneral = Nothing
        Dim listaReporte As List(Of EEReportesGeneral) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("PivotearCajaChica")
            db.AddInParameter(cmd, "anio", DbType.String, anio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If listaReporte Is Nothing Then
                    listaReporte = New List(Of EEReportesGeneral)()
                End If
                loReporte = New EEReportesGeneral()
                loReporte.NroCaja = dr("NroCaja").ToString
                loReporte.CajaDependencia = dr("CajaDep").ToString
                loReporte.FechaPago = dr("cajDetFechaMov")
                loReporte.TipoDoc = dr("TipoDoc").ToString
                loReporte.Serie = dr("cajDetDocSerie").ToString
                loReporte.NroComprobante = dr("cajDetDocNro").ToString
                loReporte.Persona = dr("NombresCompletos").ToString
                loReporte.NroDoc = dr("perNDoc").ToString
                loReporte.Descripcion = dr("cajDetDescripcion").ToString
                loReporte.Grupo = dr("Grupo").ToString
                loReporte.AreaSolicitante = dr("AreaSol").ToString
                loReporte.PartId = dr("partId").ToString
                loReporte.Monto = CDec(dr("cajDetImporte"))
                listaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Pivotear Caja Chica => " + ex.Message, ex)
        End Try
        Return listaReporte
    End Function
#End Region

#Region "Reporte Programacion Pagos Total XProPaFechaPag"
    ''' <summary>
    ''' Reporte Programacion Pagos Total XProPaFechaPag
    ''' </summary>
    ''' <param name="adtProPaFechaPag"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function reporteProgramacionPagosTotalXProPaFechaPag(adtProPaFechaPag As Date) As EEReportesGeneral
        Dim loReporte As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("RListar_ProPagos_Total_XProPaFechaPag_pa")
            db.AddInParameter(cmd, "proPaFechaPag", DbType.Date, adtProPaFechaPag)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loReporte = New EEReportesGeneral()
                loReporte.ProPaFechaPag = Convert.ToDateTime(dr("ProPaFechaPag").ToString())
                loReporte.ProPaDetMonto = dr("ProPaDetMonto").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("RListar Programacion Pagos Total XProPaFechaPag => " + ex.Message, ex)
        End Try
        Return loReporte
    End Function
#End Region


#Region "Reporte Detalle de Contratos"
    Public Shared Function reporteProgramacionPagosDetXconInmId(conInmId As String) As List(Of EEReportesGeneral)
        Dim loReporte As EEReportesGeneral = Nothing
        Dim listaReporte As List(Of EEReportesGeneral) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_ProPagosDet_XconInmId_pa")
            db.AddInParameter(cmd, "conInmId", DbType.String, conInmId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If listaReporte Is Nothing Then
                    listaReporte = New List(Of EEReportesGeneral)()
                End If
                loReporte = New EEReportesGeneral()
                loReporte.ProPaNroCuota = CShort(dr("proPaNroCuota"))
                loReporte.ProPaFechaVen = dr("proPaFechaVen")
                loReporte.ConId = dr("conId")
                loReporte.ConNombre = dr("conNombre")
                loReporte.Monto = dr("monto")
                loReporte.IngresoSAIMT = dr("ingsaimt")
                loReporte.IngresoMuni = dr("ingmpt")
                loReporte.ProPaComision = dr("proPaDetComision")
                loReporte.NetoSaimt = dr("netosaimt")
                loReporte.Estado = dr("tgEstadoId")
                loReporte.conInmId = dr("conInmId")
                listaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar_ProPagosDet_XconInmId_pa => " + ex.Message, ex)
        End Try
        Return listaReporte
    End Function
#End Region

#Region "Reporte PivotearPEM X Conceptos"
    Public Shared Function reportePivotearPEM(ByVal asTipoCriterio As String, ByVal asCriterio As String) As List(Of EEReportesGeneral)
        Dim ListaReporte As List(Of EEReportesGeneral) = Nothing
        Dim loReporte As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("PivotearPEM_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipocriterio", DbType.String, asTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReporte Is Nothing Then
                    ListaReporte = New List(Of EEReportesGeneral)()
                End If
                loReporte = New EEReportesGeneral()
                loReporte.NroTicket = dr("NroTicket").ToString()
                loReporte.Placa = dr("Placa").ToString()
                loReporte.FechaInicio = dr("FechaInicio").ToString()
                loReporte.FechaTermino = dr("FechaTermino").ToString()
                loReporte.Importe = Convert.ToDecimal(dr("Importe").ToString())
                loReporte.EstadoDiario = dr("EstadoDiario").ToString()
                If Not IsDBNull(dr("HoraIngreso")) Then
                    loReporte.HoraIngreso = dr("HoraIngreso")
                End If
                If Not IsDBNull(dr("HoraSalida")) Then
                    loReporte.HoraSalida = dr("HoraSalida")
                End If
                loReporte.TipoAbonado = dr("TipoAbonado").ToString()
                loReporte.Concepto = dr("Concepto").ToString()
                If Not IsDBNull(dr("FechaPago")) Then
                    loReporte.FechaPago = Convert.ToDateTime(dr("FechaPago").ToString())
                End If
                If Not IsDBNull(dr("HoraPago")) Then
                    loReporte.HoraPago = dr("HoraPago")
                End If
                loReporte.Año = dr("Año").ToString()
                loReporte.Mes = dr("Mes").ToString()
                loReporte.TipoUsuario = dr("Login").ToString()
                loReporte.NroPlaca = CInt(dr("NroPlaca"))
                ListaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Reporte Pivotear PEM X Conceptos => " + ex.Message, ex)
        End Try
        Return ListaReporte
    End Function


    Public Shared Function reportePivotearRinconada(ByVal asTipoCriterio As String, ByVal asCriterio As String) As List(Of EEReportesGeneral)
        Dim ListaReporte As List(Of EEReportesGeneral) = Nothing
        Dim loReporte As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("PivotearRinconada_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipocriterio", DbType.String, asTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReporte Is Nothing Then
                    ListaReporte = New List(Of EEReportesGeneral)()
                End If
                loReporte = New EEReportesGeneral()
                loReporte.NroTicket = dr("NroTicket").ToString()
                loReporte.Placa = dr("Placa").ToString()
                loReporte.FechaInicio = dr("FechaIngreso").ToString()
                loReporte.FechaTermino = dr("FechaTermino").ToString()
                loReporte.Importe = Convert.ToDecimal(dr("Importe").ToString())
                loReporte.EstadoDiario = dr("EstadoDiario").ToString()
                If Not IsDBNull(dr("HoraIngreso")) Then
                    loReporte.HoraIngreso = dr("HoraIngreso")
                End If
                If Not IsDBNull(dr("HoraSalida")) Then
                    loReporte.HoraSalida = dr("HoraSalida")
                End If
                loReporte.TipoAbonado = dr("TipoAbonado").ToString()
                loReporte.Concepto = dr("Concepto").ToString()
                If Not IsDBNull(dr("FechaPago")) Then
                    loReporte.FechaPago = Convert.ToDateTime(dr("FechaPago").ToString())
                End If
                If Not IsDBNull(dr("HoraPago")) Then
                    loReporte.HoraPago = dr("HoraPago")
                End If
                loReporte.Año = dr("Año").ToString()
                loReporte.Mes = dr("Mes").ToString()
                loReporte.TipoUsuario = dr("Login").ToString()
                loReporte.NroPlaca = CInt(dr("NroPlaca"))
                loReporte.CantPersonas = CInt(dr("CantPers"))
                ListaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Reporte Pivotear Rinconada X Conceptos => " + ex.Message, ex)
        End Try
        Return ListaReporte
    End Function
#End Region

#Region "Reporte Pivotear Asistencias X Fecha"
    Public Shared Function reportePivotearAsistencias_XFecha(ByVal adFechaInicio As DateTime, adFechaTermino As DateTime) As List(Of EEReportesGeneral)
        Dim ListaReporte As List(Of EEReportesGeneral) = Nothing
        Dim loReporte As EEReportesGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDAsistencia)
            Dim cmd As DbCommand = db.GetStoredProcCommand("PivotearAsistenciaXFecha")
            db.AddInParameter(cmd, "Fech1", DbType.DateTime, adFechaInicio)
            db.AddInParameter(cmd, "Fech2", DbType.DateTime, adFechaTermino)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReporte Is Nothing Then
                    ListaReporte = New List(Of EEReportesGeneral)()
                End If
                loReporte = New EEReportesGeneral()
                loReporte.Num_Marca = dr("Num_Marca").ToString()
                loReporte.CodTarjeta = dr("CodTarjeta").ToString()
                loReporte.Trabajador = dr("Trabajador").ToString()
                loReporte.TipoTrabajador = dr("TipoTrabajador").ToString()
                loReporte.UnidadOrg = dr("UnidadOrg").ToString()
                loReporte.Documento = dr("Documento").ToString()
                loReporte.FechaMar = Convert.ToDateTime(dr("FechaMar").ToString())
                loReporte.Hora = dr("Hora").ToString()
                loReporte.CodTrabajador = dr("CodTrabajador").ToString()
                loReporte.Incidencia = dr("Incidencia").ToString()
                loReporte.Estado = dr("Estado").ToString()
                loReporte.Temprano = dr("Temprano").ToString()
                loReporte.Tardanza = dr("Tardanza").ToString()
                loReporte.Tipo = dr("Tipo").ToString()
                loReporte.Obs = dr("Obs").ToString()
                loReporte.NroFaltas = dr("NroFaltas")
                ListaReporte.Add(loReporte)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Reporte Pivotear Asistencias X Fecha => " + ex.Message, ex)
        End Try
        Return ListaReporte
    End Function
#End Region

#Region "Reporte Pivotear Ordenes de Compra X fechas"
    Public Shared Function reportePivotearOrdenCompras(Optional ByVal fechaInicio As Date = Nothing, Optional ByVal fechaFin As Date = Nothing, Optional ByVal mes As Integer = Nothing) As List(Of EEDocumentoLOG)
        Dim ListaOrdenCompra As List(Of EEDocumentoLOG) = Nothing
        Dim loOrdenCompra As EEDocumentoLOG = Nothing
        Dim loPerProveedor As EEDocPersonaLOG = Nothing
        Dim loOrdenCompraDet As EEDocumentoLOG.EEPedArtDetLOG = Nothing
        Dim ListaOrdenCompraDet As List(Of EEDocumentoLOG.EEPedArtDetLOG) = Nothing
        Dim loArticulo As EEArticulo = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Pivotear_OrdenesCompras_by_criterios_pa")
            If fechaInicio <> "# 12:00:00 #" Then
                db.AddInParameter(cmd, "fechaInicio", DbType.String, fechaInicio)
                db.AddInParameter(cmd, "fechaFin", DbType.String, fechaFin)
            Else
                If mes > 0 Then
                    db.AddInParameter(cmd, "mes", DbType.Int16, mes)
                End If
            End If

        

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenCompra Is Nothing Then
                    ListaOrdenCompra = New List(Of EEDocumentoLOG)()
                End If
                loOrdenCompraDet = New EEDocumentoLOG.EEPedArtDetLOG
                loOrdenCompra = New EEDocumentoLOG()
                loPerProveedor = New EEDocPersonaLOG

                loOrdenCompra.DocCodigo = dr("docCodigo").ToString()

                loPerProveedor.Persona = dr("perProveedor").ToString()
                loPerProveedor.NroDoc = dr("ruc").ToString()
                loPerProveedor.PerOrigen = dr("Area").ToString()
                loOrdenCompra.loDocPersona = loPerProveedor
                loArticulo = New EEArticulo()

                loOrdenCompraDet.PedArtDetCantidad = dr("pedArtDetCantidad").ToString()
                loOrdenCompraDet.PedArtDetPrecio = dr("pedArtDetPrecio").ToString()
                loOrdenCompraDet.PedArtDetPartId = dr("pedArtDetPartId").ToString()
                loOrdenCompraDet.OArticulo = loArticulo
                loOrdenCompra.loPedArtDetLOG = loOrdenCompraDet

                ListaOrdenCompra.Add(loOrdenCompra)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Reporte Pivotear Ordenes Compras X Filtros => " + ex.Message, ex)
        End Try
        Return ListaOrdenCompra
    End Function
#End Region
End Class