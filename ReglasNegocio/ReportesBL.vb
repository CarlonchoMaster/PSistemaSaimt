Imports System.Threading
Imports Entidades
Imports DAS

Public Class ReportesBL
#Region "Instancia"
    Private Shared oInstance As ReportesBL
    Private Shared oMutex As New Mutex()
    Public Shared ReadOnly Property Instancia() As ReportesBL
        Get
            oMutex.WaitOne()
            If oInstance Is Nothing Then
                oInstance = New ReportesBL()
            End If
            oMutex.ReleaseMutex()
            Return oInstance
        End Get
    End Property
#End Region

    Public Function reporteDeudoresDECOIN() As List(Of EEContratoInm)
        Return ReportesGeneralDAS.reporteDeudoresDECOIN()
    End Function

    Public Function reporteDeudoresInfocorp() As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.reporteDeudoresInfocorp()
    End Function

    Public Function ReportesDecoin_proyeccion_by_anio_conid(ByVal asAnio As String, ByVal asConId As String) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.RptDecoin_proyeccion(asAnio, asConId)
    End Function

    Public Function ReportesDecoin_Ingresos_by_anio_mes_pa(ByVal asAnio As String, ByVal asMes As String, asPa As String) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.RptDecoin_ControlIngresosConceptos(asAnio, asMes, asPa)
    End Function

    Public Function ReportesDecoin_Ingresos_by_anio_mes_fecha_conid_pa(ByVal asAnio As String, ByVal asMes As String, asPa As Int16, Optional asFecha As Date = Nothing, Optional asConId As String = Nothing) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.RptDecoin_ControlIngresos(asAnio, asMes, asPa, asFecha, asConId)
    End Function

    ''' <summary>
    ''' Reporte PivotearProPagos
    ''' </summary>
    ''' <param name="asTipoCriterio"></param>
    ''' <param name="asCriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReportePivotearProPagosCriterio(ByVal asTipoCriterio As String, ByVal asCriterio As String) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.reportePivotearProPagosCriterio(asTipoCriterio, asCriterio)
    End Function

    Public Function ReporteNotificaciones(ByVal asTipoCriterio As Short, ByVal asCriterio As Short) As List(Of EENotificaciones)
        Return ReportesGeneralDAS.NotificacionesDeudores(asTipoCriterio, asCriterio)
    End Function

    Public Function ListarRecaudacionDetalleXAñoXFechaDeposito(año As Short, adFechaDeposito As Date?, aiOpcion As Int16) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.ListarRecaudacionDetalleXAñoXFechaDeposito(año, adFechaDeposito, aiOpcion)
    End Function

    Public Function ReportePivotearOrdenServicioXFecha(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEOrdenServicio)
        Return ReportesGeneralDAS.PivotOrdenServicioXFecha(adFechaInicio, adFechaFin)
    End Function

    Public Function ReportePivotearResumenOrdenServicioXFecha(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEOrdenServicio)
        Return ReportesGeneralDAS.PivotResumenOrdenServicioXFecha(adFechaInicio, adFechaFin)
    End Function

    Public Function ReportePivotearOrdenCompraXFecha(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEOrdenCompra)
        Return ReportesGeneralDAS.PivotOrdenCompraXFecha(adFechaInicio, adFechaFin)
    End Function

    Public Function ReportePivotearPecosaXFecha(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEPecosa)
        Return ReportesGeneralDAS.PivotPecosaXFecha(adFechaInicio, adFechaFin)
    End Function

    Public Function ReporteOsceOrdenCompraServicioXFecha(ByVal adFechaInicio As Date?, ByVal adFechaFin As Date?) As List(Of EEOrdenCompra)
        Return ReportesGeneralDAS.ReporteOSCEOrdenCompraServicioXFechas(adFechaInicio, adFechaFin)
    End Function


#Region "Marcaciones"
    Public Function marcacionesListarXTrab(ByVal asFecha1 As String, ByVal asFecha2 As String, ByVal aiCodTrabajador As Int32) As List(Of EEMarcaciones)
        Return MarcacionesDAS.listarXTrab(asFecha1, asFecha2, aiCodTrabajador)
    End Function

    Public Function marcacionesListarXTrabEstado(ByVal asFecha1 As String, ByVal asFecha2 As String, ByVal aiCodTrabajador As Int32, ByVal asEstado As String) As List(Of EEMarcaciones)
        Return MarcacionesDAS.listarXTrabEstado(asFecha1, asFecha2, aiCodTrabajador, asEstado)
    End Function
#End Region

    Public Function ReportePivotearTrabajador() As List(Of EEContratoPersonal)
        Return ContratoPersonalDAS.PivotTrabajador
    End Function

    Public Function reporteProPagosDetalleXRangoFecha(ByVal adtFecha1 As Date, ByVal adtFecha2 As Date) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.reporteProPagosDetalleXRangoFecha(adtFecha1, adtFecha2)
    End Function

    Public Function reporteProPagosDetalleConceptosXRangoFecha(adtFecha1 As Date, adtFecha2 As Date) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.reporteProPagosDetalleConceptosXRangoFecha(adtFecha1, adtFecha2)
    End Function

    ''' <summary>
    ''' Reporte Recaudacion Detalle XRangoFecha y XTgGrupoConId
    ''' </summary>
    ''' <param name="adtFecha1"></param>
    ''' <param name="adtFecha2"></param>
    ''' <param name="asTgGrupoConId">06=PEM,07=TTSC</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function reporteRecaudacionDetXRangoFechaXTgGrupoConId(adtFecha1 As Date, adtFecha2 As Date, asTgGrupoConId As String) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.reporteRecaudacionDetXRangoFechaXTgGrupoConId(adtFecha1, adtFecha2, asTgGrupoConId)
    End Function

    ''' <summary>
    ''' Reporte Recaudacion XRecFecPago y XTgGrupoConId
    ''' </summary>
    ''' <param name="adtRecFecPago"></param>
    ''' <param name="asTgGrupoConId">06=PEM,07=TTSC</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function reporteRecaudacionXRecFecPagoXTgGrupoConId(adtRecFecPago As Date, asTgGrupoConId As String) As EEReportesGeneral
        Return ReportesGeneralDAS.reporteRecaudacionXRecFecPagoXTgGrupoConId(adtRecFecPago, asTgGrupoConId)
    End Function

    Public Function reporteProgramacionPagosTotalXProPaFechaPag(adtProPaFechaPag As Date) As EEReportesGeneral
        Return ReportesGeneralDAS.reporteProgramacionPagosTotalXProPaFechaPag(adtProPaFechaPag)
    End Function

    Public Function reportePivotearPEM(ByVal asTipoCriterio As String, ByVal asCriterio As String) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.reportePivotearPEM(asTipoCriterio, asCriterio)
    End Function

    Public Function reportePivotearRinconada(ByVal asTipoCriterio As String, ByVal asCriterio As String) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.reportePivotearRinconada(asTipoCriterio, asCriterio)
    End Function

    Public Function reportePivotearOrdenCompras(Optional ByVal fechaInicio As Date = Nothing, Optional ByVal fechaFin As Date = Nothing, Optional ByVal mes As Integer = Nothing) As List(Of EEDocumentoLOG)
        Return ReportesGeneralDAS.reportePivotearOrdenCompras(fechaInicio, fechaFin, mes)
    End Function

    Public Function reportePivotearAsistencias_XFecha(ByVal adFechaInicio As DateTime, adFechaTermino As DateTime) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.reportePivotearAsistencias_XFecha(adFechaInicio, adFechaTermino)
    End Function
End Class
