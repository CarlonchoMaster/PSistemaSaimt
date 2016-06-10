Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmRptDecoin
    Dim años As List(Of EEProPagos) = Nothing
    Dim año As EEProPagos = Nothing
    Dim ListaProyeccion As List(Of EEReportesGeneral) = Nothing
    Dim ListaContratos As List(Of EEContratoInm) = Nothing
    Dim loContratos As EEContratoInm = Nothing
    Dim loProyeccion As EEReportesGeneral = Nothing
    Dim xl As Excel.Application
    Dim vañoAnt As String
    Dim vaño As String
    Private Sub frmRptDecoin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        años = MantenimientosBL.Instancia.AñosProgPagos()
        For Each Me.año In años
            chlbaños.Items.Add(año.Año)
        Next
        Me.dtpfechaInicio.DateTime = EEComun.FechaServidor
        Me.dtpfechaFin.DateTime = Me.dtpfechaInicio.DateTime
    End Sub

    Private Sub btnexportarrep_Click(sender As System.Object, e As System.EventArgs) Handles btnexportarrep.Click
        Try
            xl = EEExcel.Instancia
            
            Me.btnexportarrep.Enabled = False
            If chlbreportes.Items(0).CheckState = CheckState.Checked Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptDecoin.xls", 1, True, 4)
                ExportarDeudores()
                If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(Me.fbdExportar.SelectedPath & "\ReporteDeudores_" & Format(Now, "dd-MM-yyyy"))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre ReporteDeudores_" & Format(Now, "dd-MM-yyyy")
                End If
            End If
            If chlbreportes.Items(1).CheckState = CheckState.Checked Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptDecoin.xls", 1, True, 4)
                ExportarProyecciónIngresosFVP(xl)
                If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(Me.fbdExportar.SelectedPath & "\ReporteProyeccion_" & Format(Now, "dd-MM-yyyy"))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre ReporteProyeccion_" & Format(Now, "dd-MM-yyyy")
                End If
            End If
            If chlbreportes.Items(2).CheckState = CheckState.Checked Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptDecoin.xls", 1, True, 4)
                ExportarContratos(xl)
                If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(Me.fbdExportar.SelectedPath & "\ReporteContratos_" & Format(Now, "dd-MM-yyyy"))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre ReporteContratos_" & Format(Now, "dd-MM-yyyy")
                End If
            End If
            If chlbreportes.Items(3).CheckState = CheckState.Checked Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptDecoin.xls", 1, True, 4)
                ExportarIngresosDiarios()
                If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(Me.fbdExportar.SelectedPath & "\ReporteIngresos_" & Format(Now, "dd-MM-yyyy"))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre ReporteIngresos_" & Format(Now, "dd-MM-yyyy")
                End If
            End If
            If chlbreportes.Items(4).CheckState = CheckState.Checked Then
                NotificacionesDeudores()
            End If
            If chlbreportes.Items(5).CheckState = CheckState.Checked Then
                NotificacionesDeudoresRenovacion()
            End If
            If chlbreportes.Items(6).CheckState = CheckState.Checked Then
                NotificacionesRenovacion()
            End If
            If chlbreportes.Items(7).CheckState = CheckState.Checked Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptIngresos.xls", 1, True, 4)
                ReporteControlIngresosDiarios(xl)
                If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(Me.fbdExportar.SelectedPath & "\IngresosDiarios_" & Format(Now, "dd-MM-yyyy"))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre IngresosDiarios_" & Format(Now, "dd-MM-yyyy")
                End If
            End If
            If chlbreportes.Items(8).CheckState = CheckState.Checked Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptMacroInfocorp.xls", 1, True, 4)
                ReporteDeudoresInfocorp()
                If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(Me.fbdExportar.SelectedPath & "\ReporteInfocorp_" & Format(Now, "dd-MM-yyyy"))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre ReporteInfocorp_" & Format(Now, "dd-MM-yyyy")
                End If
            End If
            If chlbreportes.Items(9).CheckState = CheckState.Checked Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptDecoin.xls", 1, True, 4)
                ExportarContratosDiferenciaAnterior(xl)
                If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(Me.fbdExportar.SelectedPath & "\ReporteContratos" & vaño & "Difal_" & vañoAnt)
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre ReporteContratos" & vaño & "Difal_" & vañoAnt
                End If
            End If
            Me.btnexportarrep.Enabled = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#Region "Notificaciones para Renovacion de Contrato"
    Private Sub NotificacionesRenovacion()
        Dim docExcel As Excel.Application = EEExcel.Instancia
        Dim listaReporte As List(Of EENotificaciones) = Nothing
        Dim loNotificacion As EENotificaciones = Nothing
        Dim fechNoti As Date = Nothing
        Dim contaños As Integer = 0
        Dim contNot As Integer = 0
        Dim CodInm As String = String.Empty
        beiprogreso.Caption = "Cargando Notificaciones..."
        beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        docExcel.Workbooks.Open(EEComun.RutaReportes & "\RptNotReqContrato.xls", 1, True, 4)
        For contaños = 0 To Me.chlbaños.ItemCount - 1
            If Me.chlbaños.Items(contaños).CheckState = CheckState.Checked Then
                listaReporte = ReportesBL.Instancia.ReporteNotificaciones(2, Me.chlbaños.Items(contaños).Value)
                If Not listaReporte Is Nothing Then
                    riprogreso.Minimum = 0
                    riprogreso.Maximum = listaReporte.Count - 1
                    Application.DoEvents()
                    beiprogreso.Caption = "Cargando Notificaciones " & Me.chlbaños.Items(contaños).Value & "..."
                    contNot = 0
                    For Each loNotificacion In listaReporte
                        Application.DoEvents()
                        contNot = contNot + 1
                        beiprogreso.EditValue = contNot
                        beiprogreso.Caption = "Cargando Notificaciones " & Me.chlbaños.Items(contaños).Value & "...(" & Format(beiprogreso.EditValue / riprogreso.Maximum, "0%") & ")"
                        docExcel.Sheets(docExcel.Sheets.Count).Copy(Before:=docExcel.Sheets(docExcel.Sheets.Count))
                        docExcel.Sheets(docExcel.Sheets.Count - 1).Name = "ContratoNro_" & loNotificacion.ConInmId
                        docExcel.Sheets(docExcel.Sheets.Count - 1).Select()
                        docExcel.Cells(5, 3) = loNotificacion.PerNombres & IIf(loNotificacion.PerContacto = String.Empty, String.Empty, " - " & loNotificacion.PerContacto)
                        docExcel.Cells(6, 3) = loNotificacion.InmDirCon
                        fechNoti = EEComun.FechaServidor
                        docExcel.Cells(11, 8) = "Trujillo, " & Format(fechNoti, "dd") & " de " & StrConv(Format(fechNoti, "MMMM"), VbStrConv.ProperCase) & " del " & Format(fechNoti, "yyyy")
                        docExcel.Cells(13, 1) = "Me dirijo a Usted para saludarle cordialmente y a la vez, informarle por medio del presente que a efectos de la renovación de contrato de arrendamiento para el año " & (Me.chlbaños.Items(contaños).Value + 1) & " con nuestra representada, deberá presentar a esta Jefatura la siguiente documentación:"
                    Next
                End If
            End If
        Next
        If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            docExcel.ActiveWorkbook.SaveAs(Me.fbdExportar.SelectedPath & "\NotificacionesRenovacionForm2_" & Format(Now, "dd-MM-yyyy"))
            docExcel.ActiveWorkbook.Close()
            Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada"
        End If
        beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        beiprogreso.EditValue = 0
    End Sub

#End Region

#Region "Notificaciones para Deudores"
    Private Sub NotificacionesDeudores()
        Dim docExcel As Excel.Application = EEExcel.Instancia
        Dim listaReporte As List(Of EENotificaciones) = Nothing
        Dim loNotificacion As EENotificaciones = Nothing
        Dim fechNoti As Date = Nothing
        Dim contNot As Integer = 0
        Dim contaños As Integer = 0
        Dim CodInm As String = String.Empty
        beiprogreso.Caption = "Cargando Notificaciones..."
        beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        docExcel.Workbooks.Open(EEComun.RutaReportes & "\RptNotificacionDeudores.xls", 1, True, 4)
        For contaños = 0 To Me.chlbaños.ItemCount - 1
            If Me.chlbaños.Items(contaños).CheckState = CheckState.Checked Then
                listaReporte = ReportesBL.Instancia.ReporteNotificaciones(1, Me.chlbaños.Items(contaños).Value)
                If Not listaReporte Is Nothing Then
                    riprogreso.Minimum = 0
                    riprogreso.Maximum = listaReporte.Count - 1
                    Application.DoEvents()
                    beiprogreso.Caption = "Cargando Notificaciones " & Me.chlbaños.Items(contaños).Value & "..."
                    contNot = 0
                    For Each loNotificacion In listaReporte
                        If loNotificacion.InmId <> CodInm Then
                            docExcel.Sheets(docExcel.Sheets.Count).Copy(Before:=docExcel.Sheets(docExcel.Sheets.Count))
                            docExcel.Sheets(docExcel.Sheets.Count - 1).Name = "ContratoNro_" & loNotificacion.ConInmId
                            docExcel.Sheets(docExcel.Sheets.Count - 1).Select()
                            CodInm = loNotificacion.InmId
                            docExcel.Cells(5, 3) = loNotificacion.PerNombres & IIf(loNotificacion.PerContacto = String.Empty, String.Empty, " - " & loNotificacion.PerContacto)
                            docExcel.Cells(6, 3) = loNotificacion.InmDirCon
                            fechNoti = EEComun.FechaServidor
                            docExcel.Cells(11, 8) = "Trujillo, " & Format(fechNoti, "dd") & " de " & StrConv(Format(fechNoti, "MMMM"), VbStrConv.ProperCase) & " del " & Format(fechNoti, "yyyy")
                        End If
                        Application.DoEvents()
                        contNot = contNot + 1
                        beiprogreso.EditValue = contNot
                        beiprogreso.Caption = "Cargando Notificaciones " & Me.chlbaños.Items(contaños).Value & "...(" & Format(beiprogreso.EditValue / riprogreso.Maximum, "0%") & ")"
                        docExcel.Cells(16, 1).EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown)
                        docExcel.Cells(16, 3) = "■ " & Format(loNotificacion.ProPaNroCuota, "00")
                        docExcel.Cells(16, 3).Font.Bold = False
                        docExcel.Cells(16, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        docExcel.Cells(16, 4) = EEComun.NumMeses(loNotificacion.MesId)
                        docExcel.Cells(16, 4).Font.Bold = False
                        docExcel.Cells(13, 1) = String.Format("Me dirijo a Usted para saludarle cordialmente y a la vez, informarle que a la fecha adeuda la merced conductiva correspondiente al periodo {0} de los meses:", Me.chlbaños.Items(contaños).Value)
                    Next

                End If
            End If
        Next
        If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            docExcel.ActiveWorkbook.SaveAs(Me.fbdExportar.SelectedPath & "\ReporteNotificaciones_" & Format(Now, "dd-MM-yyyy"))
            docExcel.ActiveWorkbook.Close()
            Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre ReporteNotificaciones_" & Format(Now, "dd-MM-yyyy")
        End If
        beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        beiprogreso.EditValue = 0
    End Sub

#End Region

#Region "Notificaciones para Deudores con formato de renovacion"
    Private Sub NotificacionesDeudoresRenovacion()
        Dim docExcel As Excel.Application = EEExcel.Instancia
        Dim listaReporte As List(Of EENotificaciones) = Nothing
        Dim loNotificacion As EENotificaciones = Nothing
        Dim fechNoti As Date = Nothing
        Dim contaños As Integer = 0
        Dim contNot As Integer = 0
        Dim CodInm As String = String.Empty
        beiprogreso.Caption = "Cargando Notificaciones..."
        beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        docExcel.Workbooks.Open(EEComun.RutaReportes & "\RptNotificacionDeuXRen.xls", 1, True, 4)
        For contaños = 0 To Me.chlbaños.ItemCount - 1
            If Me.chlbaños.Items(contaños).CheckState = CheckState.Checked Then
                listaReporte = ReportesBL.Instancia.ReporteNotificaciones(1, Me.chlbaños.Items(contaños).Value)
                If Not listaReporte Is Nothing Then
                    riprogreso.Minimum = 0
                    riprogreso.Maximum = listaReporte.Count - 1
                    Application.DoEvents()
                    beiprogreso.Caption = "Cargando Notificaciones " & Me.chlbaños.Items(contaños).Value & "..."
                    contNot = 0
                    For Each loNotificacion In listaReporte
                        If loNotificacion.InmId <> CodInm Then
                            docExcel.Sheets(docExcel.Sheets.Count).Copy(Before:=docExcel.Sheets(docExcel.Sheets.Count))
                            docExcel.Sheets(docExcel.Sheets.Count - 1).Name = "ContratoNro_" & loNotificacion.ConInmId
                            docExcel.Sheets(docExcel.Sheets.Count - 1).Select()
                            CodInm = loNotificacion.InmId
                            docExcel.Cells(5, 3) = loNotificacion.PerNombres & IIf(loNotificacion.PerContacto = String.Empty, String.Empty, " - " & loNotificacion.PerContacto)
                            docExcel.Cells(6, 3) = loNotificacion.InmDirCon
                            fechNoti = EEComun.FechaServidor
                            docExcel.Cells(11, 8) = "Trujillo, " & Format(fechNoti, "dd") & " de " & StrConv(Format(fechNoti, "MMMM"), VbStrConv.ProperCase) & " del " & Format(fechNoti, "yyyy")
                            docExcel.Cells(17, 1) = "En ese sentido, se le otorga el plazo de 5 días hábiles para el cumplimiento de pago de dicha deuda, bajo apercibimiento de no renovársele contrato de arrendamiento para el año " & (Me.chlbaños.Items(contaños).Value + 1) & ". En caso de cumplimiento dentro del plazo anteriormente señalado, se procederá automáticamente a renovársele contrato de arrendamiento, adjuntando los siguientes requisitos:"
                        End If
                        Application.DoEvents()
                        contNot = contNot + 1
                        beiprogreso.EditValue = contNot
                        beiprogreso.Caption = "Cargando Notificaciones " & Me.chlbaños.Items(contaños).Value & "...(" & Format(beiprogreso.EditValue / riprogreso.Maximum, "0%") & ")"
                        docExcel.Cells(16, 1).EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown)
                        docExcel.Cells(16, 3) = "■ " & Format(loNotificacion.ProPaNroCuota, "00")
                        docExcel.Cells(16, 3).Font.Bold = False
                        docExcel.Cells(16, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        docExcel.Cells(16, 4) = EEComun.NumMeses(loNotificacion.MesId)
                        docExcel.Cells(16, 4).Font.Bold = False
                    Next
                End If
            End If
        Next

        If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            docExcel.ActiveWorkbook.SaveAs(Me.fbdExportar.SelectedPath & "\NotificacionesRenovacion_" & Format(Now, "dd-MM-yyyy"))
            docExcel.ActiveWorkbook.Close()
            Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre NotificacionesRenovacion_" & Format(Now, "dd-MM-yyyy")
        End If
        beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        beiprogreso.EditValue = 0
    End Sub
#End Region

#Region "Exportar Contratos"
    Private Sub ExportarContratos(xl As Excel.Application)
        Dim HojaPlantilla As String = "Contratos-"
        Me.beiprogreso.Caption = "Cargando Reporte... "
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        For contanios = 0 To Me.chlbaños.Items.Count - 1
            If Me.chlbaños.Items(contanios).CheckState = CheckState.Checked Then
                ListaContratos = MantenimientosBL.Instancia.contratoInmListarXanio(Me.chlbaños.Items(contanios).Value)
                If ListaContratos IsNot Nothing Then
                    Dim fila As Integer = 5
                    xl.Sheets(xl.Worksheets(HojaPlantilla).Index).Copy(Before:=xl.Sheets(xl.Worksheets(HojaPlantilla).Index))
                    xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Name = "Contratos -" & Me.chlbaños.Items(contanios).Value
                    xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Select()
                    If Not ListaContratos Is Nothing Then
                        Me.riprogreso.Minimum = 0
                        Me.riprogreso.Maximum = ListaContratos.Count
                        Me.beiprogreso.EditValue = 0
                    End If
                    For Each Me.loContratos In ListaContratos
                        Application.DoEvents()
                        Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                        xl.Cells(fila, 1) = fila + 1 - 5
                        xl.Cells(fila, 2) = loContratos.ConInmId
                        xl.Cells(fila, 3) = loContratos.PerId
                        xl.Cells(fila, 4) = loContratos.OPersona.PerNombres
                        xl.Cells(fila, 5) = loContratos.OPersona.PerContacto
                        xl.Cells(fila, 6) = loContratos.InmId
                        xl.Cells(fila, 7) = loContratos.InmDir
                        xl.Cells(fila, 8) = loContratos.ConInmFecIni
                        xl.Cells(fila, 9) = loContratos.ConInmFecFin
                        xl.Cells(fila, 10) = loContratos.OTgUso.TgNombre
                        xl.Cells(fila, 11) = loContratos.ConInmMerced
                        xl.Cells(fila, 12) = loContratos.OTgGarantia.TgNombre
                        xl.Cells(fila, 13) = loContratos.ConInmGarantia
                        xl.Cells(fila, 14) = loContratos.ConInmFecSus
                        xl.Cells(fila, 15) = loContratos.OTgEstado.TgNombre
                        xl.Cells(fila, 16) = loContratos.ConInmObs
                        fila = fila + 1
                    Next
                End If
            End If
        Next
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub ExportarContratosDiferenciaAnterior(ByVal xl As Excel.Application)
        Dim HojaPlantilla As String = "Contratos-"
        Me.beiprogreso.Caption = "Cargando Reporte... "
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        For contanios = 0 To Me.chlbaños.Items.Count - 1
            If Me.chlbaños.Items(contanios).CheckState = CheckState.Checked Then
                vaño = Me.chlbaños.Items(contanios).Value
                vañoAnt = CInt(Me.chlbaños.Items(contanios).Value) - 1
                ListaContratos = MantenimientosBL.Instancia.contratoInmListarDifAnteriorXanio(vaño)
                If ListaContratos IsNot Nothing Then
                    Dim fila As Integer = 5
                    xl.Sheets(xl.Worksheets(HojaPlantilla).Index).Copy(Before:=xl.Sheets(xl.Worksheets(HojaPlantilla).Index))
                    xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Name = "Contratos -" & Me.chlbaños.Items(contanios).Value
                    xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Select()
                    If Not ListaContratos Is Nothing Then
                        Me.riprogreso.Minimum = 0
                        Me.riprogreso.Maximum = ListaContratos.Count
                        Me.beiprogreso.EditValue = 0
                    End If
                    For Each Me.loContratos In ListaContratos
                        Application.DoEvents()
                        Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                        xl.Cells(fila, 1) = fila + 1 - 5
                        xl.Cells(fila, 2) = loContratos.ConInmId
                        xl.Cells(fila, 3) = loContratos.PerId
                        xl.Cells(fila, 4) = loContratos.OPersona.PerNombres
                        xl.Cells(fila, 5) = loContratos.OPersona.PerContacto
                        xl.Cells(fila, 6) = loContratos.InmId
                        xl.Cells(fila, 7) = loContratos.InmDir
                        xl.Cells(fila, 8) = loContratos.ConInmFecIni
                        xl.Cells(fila, 9) = loContratos.ConInmFecFin
                        xl.Cells(fila, 10) = loContratos.OTgUso.TgNombre
                        xl.Cells(fila, 11) = loContratos.ConInmMerced
                        xl.Cells(fila, 12) = loContratos.OTgGarantia.TgNombre
                        xl.Cells(fila, 13) = loContratos.ConInmGarantia
                        xl.Cells(fila, 14) = loContratos.ConInmFecSus
                        xl.Cells(fila, 15) = loContratos.OTgEstado.TgNombre
                        xl.Cells(fila, 16) = loContratos.ConInmObs
                        fila = fila + 1
                    Next
                End If
            End If
        Next
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
#End Region

#Region "Reporte Control Ingresos Diarios"
    Private Sub ReporteControlIngresosDiarios(xl As Excel.Application)
        Dim HojaPlantilla As String = "RptIngresos"
        Me.beiprogreso.Caption = "Cargando Reporte... "
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Dim ListaConceptos As List(Of EEReportesGeneral) = Nothing
        Dim loConceptos As EEReportesGeneral = Nothing
        Dim ListaMontos As List(Of EEReportesGeneral) = Nothing
        Dim loMontos As EEReportesGeneral = Nothing
        Dim ListaMontosDia As List(Of EEReportesGeneral) = Nothing
        Dim loMontosDia As EEReportesGeneral = Nothing
        Dim fila As Integer
        For contanios = 0 To Me.chlbaños.Items.Count - 1
            If Me.chlbaños.Items(contanios).CheckState = CheckState.Checked Then
                For contmes = 0 To Me.chlbmes.Items.Count - 1
                    If Me.chlbmes.Items(contmes).CheckState = CheckState.Checked Then
                        fila = 1
                        xl.Sheets(xl.Worksheets(HojaPlantilla).Index).Copy(Before:=xl.Sheets(xl.Worksheets(HojaPlantilla).Index))
                        xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Name = String.Format("Rpt{0}-{1}", Me.chlbmes.Items(contmes).Value, Me.chlbaños.Items(contanios).Value)
                        xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Select()
                        xl.Cells(fila, 2) = String.Format("Reporte de Control de Ingresos {0}-{1}", Me.chlbmes.Items(contmes).Value, Me.chlbaños.Items(contanios).Value)

                        ListaConceptos = ReportesBL.Instancia.ReportesDecoin_Ingresos_by_anio_mes_pa(Me.chlbaños.Items(contanios).Value, Me.chlbmes.Items(contmes).Value, 1)
                        fila = 5
                        'Listamos los conceptos horizontalmente 
                        If ListaConceptos IsNot Nothing Then
                            Dim col As Int16 = 3
                            ListaMontos = ReportesBL.Instancia.ReportesDecoin_Ingresos_by_anio_mes_fecha_conid_pa(Me.chlbaños.Items(contanios).Value, Me.chlbmes.Items(contmes).Value, 2)
                            For Each loConceptos In ListaConceptos
                                xl.Cells(5, col) = loConceptos.ConId
                                col = col + 1
                            Next
                            'Formato de los conceptos
                            xl.Cells(4, col - 1) = "Conceptos"
                            xl.Cells(4, col - 1).Font.Bold = True
                            xl.Cells(4, 3).Resize(1, col - 3).MergeCells = True
                            xl.Cells(4, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            xl.Cells(4, 3).Resize(1, col - 3).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(4, 3).Resize(1, col - 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(4, 3).Resize(1, col - 3).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous

                            Dim RIdConp As String = "C5:" & CChar(Microsoft.VisualBasic.ChrW(65 + col - 2)) & 5
                            xl.Cells.Range(RIdConp).Font.Bold = True
                            xl.Cells.Range(RIdConp).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            xl.Cells.Range(RIdConp).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells.Range(RIdConp).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells.Range(RIdConp).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells.Range(RIdConp).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

                            xl.Cells(5, col) = "TOTAL"
                            xl.Cells(5, col).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(5, col).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            xl.Cells(5, col).Font.Bold = True

                            Dim i As Integer
                            Dim merger As String
                            Dim acol As Integer = 3
                            For Each loMontos In ListaMontos

                                xl.Cells(fila + 1, 2) = "MONTO"
                                xl.Cells(fila + 1, 2).Font.Bold = True
                                xl.Cells(fila + 1, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                                xl.Cells(fila + 2, 2) = "ING_SAIMT"
                                xl.Cells(fila + 2, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                                xl.Cells(fila + 2, 2).Font.Bold = True
                                xl.Cells(fila + 3, 2) = "ING_MPT"
                                xl.Cells(fila + 3, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                                xl.Cells(fila + 3, 2).Font.Bold = True
                                xl.Cells(fila + 4, 2) = "ING_RECAUDADOR"
                                xl.Cells(fila + 4, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                                xl.Cells(fila + 4, 2).Font.Bold = True
                                xl.Cells(fila + 5, 2) = "ING_NETO"
                                xl.Cells(fila + 5, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                                xl.Cells(fila + 5, 2).Font.Bold = True
                                xl.Cells(fila + 5, 1) = loMontos.ProPaFechaPag
                                xl.Cells(fila + 5, 1).Font.Bold = True
                                xl.Cells(fila + 5, 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                                merger = "A" & fila + 1 & ":A" & fila + 5
                                xl.Cells.Range(merger).MergeCells = True
                                xl.Cells.Range(merger).VerticalAlignment = 2

                                Dim saimt, mpt, recaudador, monto, neto As Decimal
                                For i = 3 To col
                                    ListaMontosDia = ReportesBL.Instancia.ReportesDecoin_Ingresos_by_anio_mes_fecha_conid_pa(Me.chlbaños.Items(contanios).Value, Me.chlbmes.Items(contmes).Value, 3, loMontos.ProPaFechaPag, xl.Cells(5, i).value)
                                    If ListaMontosDia IsNot Nothing Then
                                        For Each loMontosDia In ListaMontosDia
                                            monto = monto + loMontosDia.Monto
                                            xl.Cells(fila + 1, i) = loMontosDia.Monto
                                            xl.Cells(fila + 1, i).NumberFormat = "###,##0.00"
                                            xl.Cells(fila + 1, i).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDot
                                            xl.Cells(fila + 1, i).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot

                                            saimt = saimt + loMontosDia.MontoSAIMT
                                            xl.Cells(fila + 2, i) = loMontosDia.MontoSAIMT
                                            xl.Cells(fila + 2, i).NumberFormat = "###,##0.00"
                                            xl.Cells(fila + 2, i).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDot
                                            xl.Cells(fila + 2, i).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot

                                            mpt = mpt + loMontosDia.MontoMPT
                                            xl.Cells(fila + 3, i) = loMontosDia.MontoMPT
                                            xl.Cells(fila + 3, i).NumberFormat = "###,##0.00"
                                            xl.Cells(fila + 3, i).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDot
                                            xl.Cells(fila + 3, i).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot

                                            recaudador = recaudador + loMontosDia.MontoRecaudador
                                            xl.Cells(fila + 4, i) = loMontosDia.MontoRecaudador
                                            xl.Cells(fila + 4, i).NumberFormat = "###,##0.00"
                                            xl.Cells(fila + 4, i).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDot
                                            xl.Cells(fila + 4, i).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                                            neto = neto + loMontosDia.NetoSaimt
                                            xl.Cells(fila + 5, i) = loMontosDia.NetoSaimt
                                            xl.Cells(fila + 5, i).NumberFormat = "###,##0.00"
                                            xl.Cells(fila + 5, i).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDot
                                            xl.Cells(fila + 5, i).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

                                            If i = col Then
                                                xl.Cells(fila + 1, i).Interior.Color = RGB(215, 228, 188)
                                                xl.Cells(fila + 2, i).Interior.Color = RGB(215, 228, 188)
                                                xl.Cells(fila + 3, i).Interior.Color = RGB(215, 228, 188)
                                                xl.Cells(fila + 4, i).Interior.Color = RGB(215, 228, 188)
                                                xl.Cells(fila + 5, i).Interior.Color = RGB(215, 228, 188)
                                                xl.Cells(fila + 1, i) = monto
                                                xl.Cells(fila + 2, i) = saimt
                                                xl.Cells(fila + 3, i) = mpt
                                                xl.Cells(fila + 4, i) = recaudador
                                                xl.Cells(fila + 5, i) = neto
                                            End If

                                        Next

                                    End If
                                Next
                                fila = fila + 5
                            Next
                            xl.Cells(fila + 1, 3).Resize(1, i - 3).Interior.Color = RGB(184, 204, 228)
                            xl.Cells(fila + 1, 2) = "TOTALES"
                            xl.Cells(fila + 1, 2).Font.Bold = True
                            Dim code As Integer = 65
                            Dim RSaimt, RMpt, RRec, Rmonto, RNeto As Decimal
                            Dim subtotalConId As Decimal
                            For i = 3 To col
                                RSaimt = RMpt = RRec = Rmonto = RNeto = subtotalConId = 0
                                For f = 5 To fila
                                    subtotalConId = subtotalConId + Val(xl.Cells(f, i).value)
                                    If f >= 6 And (f Mod 5) = 1 Then
                                        Rmonto = Rmonto + Val(xl.Cells(f, i).value)
                                    End If
                                    If f >= 7 And (f Mod 5) = 2 Then
                                        RSaimt = RSaimt + Val(xl.Cells(f, i).value)
                                    End If
                                    If f >= 8 And (f Mod 5) = 3 Then
                                        RMpt = RMpt + Val(xl.Cells(f, i).value)
                                    End If

                                    If f >= 9 And (f Mod 5) = 4 Then
                                        RRec = RRec + Val(xl.Cells(f, i).value)
                                    End If
                                    If f >= 10 And (f Mod 5) = 0 Then
                                        RNeto = RNeto + Val(xl.Cells(f, i).value)
                                    End If
                                Next
                                xl.Cells(fila + 1, i) = subtotalConId
                                xl.Cells(fila + 5, i) = Rmonto
                                xl.Cells(fila + 5, i).NumberFormat = "###,##0.00"
                                xl.Cells(fila + 5, i).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDot
                                xl.Cells(fila + 5, i).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot

                                xl.Cells(fila + 6, i) = RSaimt
                                xl.Cells(fila + 6, i).NumberFormat = "###,##0.00"
                                xl.Cells(fila + 6, i).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDot
                                xl.Cells(fila + 6, i).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot

                                xl.Cells(fila + 7, i) = RMpt
                                xl.Cells(fila + 7, i).NumberFormat = "###,##0.00"
                                xl.Cells(fila + 7, i).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDot
                                xl.Cells(fila + 7, i).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot

                                xl.Cells(fila + 8, i) = RRec
                                xl.Cells(fila + 8, i).NumberFormat = "###,##0.00"
                                xl.Cells(fila + 8, i).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDot
                                xl.Cells(fila + 8, i).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot

                                xl.Cells(fila + 9, i) = RNeto
                                xl.Cells(fila + 9, i).NumberFormat = "###,##0.00"
                                xl.Cells(fila + 9, i).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlDot
                                xl.Cells(fila + 9, i).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            Next
                            fila = fila + 4
                            xl.Cells(fila, 1) = "RESUMEN"
                            xl.Cells(fila, 1).Font.Bold = True
                            xl.Cells(fila, 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(fila, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            Dim range1, range2 As String
                            range1 = "C5:" & CChar(Microsoft.VisualBasic.ChrW(65 + col - 1).ToString) & "5"
                            range2 = "C" & fila & ":" & CChar(Microsoft.VisualBasic.ChrW(65 + col - 1).ToString) & fila
                            xl.Cells.Range(range2).Value = xl.Cells.Range(range1).Value
                            xl.Cells.Range(range2).Font.Bold = True
                            xl.Cells.Range(range2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells.Range(range2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            range2 = "C" & fila & ":" & CChar(Microsoft.VisualBasic.ChrW(65 + col - 2).ToString) & fila
                            xl.Cells.Range(range2).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells.Range(range2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells.Range(range2).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous


                            xl.Cells(fila + 1, 1) = "MONTO"
                            xl.Cells(fila + 1, 1).Font.Bold = True
                            xl.Cells(fila + 1, 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot

                            xl.Cells(fila + 2, 1) = "ING_SAIMT"
                            xl.Cells(fila + 2, 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                            xl.Cells(fila + 2, 1).Font.Bold = True

                            xl.Cells(fila + 3, 1) = "ING_MPT"
                            xl.Cells(fila + 3, 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                            xl.Cells(fila + 3, 1).Font.Bold = True

                            xl.Cells(fila + 4, 1) = "ING_RECAUDADOR"
                            xl.Cells(fila + 4, 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                            xl.Cells(fila + 4, 1).Font.Bold = True

                            xl.Cells(fila + 5, 1) = "ING_NETO"
                            xl.Cells(fila + 5, 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(fila + 5, 1).Font.Bold = True


                            xl.Cells(fila + 1, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                            xl.Cells(fila + 2, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                            xl.Cells(fila + 3, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                            xl.Cells(fila + 4, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                            xl.Cells(fila + 5, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous


                        End If
                    End If
                Next

            End If
        Next

        '            xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Name = "I" & countconp & "-" & Me.chlbaños.Items(contanios).Value
        '            xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Select()



        'Dim HojaPlantilla As String = "Hoja3"
        'Dim conceptos(4) As String
        'conceptos = {"S0001", "S6177", "S4516", "S0835"}

        'Dim fila As Integer
        'Me.beiprogreso.Caption = "Cargando Reporte... "
        'Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'For contanios = 0 To Me.chlbaños.Items.Count - 1
        '    If Me.chlbaños.Items(contanios).CheckState = CheckState.Checked Then
        '        If Not conceptos Is Nothing Then
        '            Me.riprogreso.Minimum = 0
        '            Me.riprogreso.Maximum = conceptos.Length
        '            Me.beiprogreso.EditValue = 0
        '        End If
        '        For Each countconp In conceptos
        '            fila = 1
        '            Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
        '            xl.Sheets(xl.Worksheets(HojaPlantilla).Index).Copy(Before:=xl.Sheets(xl.Worksheets(HojaPlantilla).Index))
        '            xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Name = "I" & countconp & "-" & Me.chlbaños.Items(contanios).Value
        '            xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Select()
        '            xl.Cells(fila, 2) = "REPORTE PARA EL CONCEPTO (" & countconp & " - PAGO DE ALQUILER FINCAS AÑO " & Me.chlbaños.Items(contanios).Value & ")"
        '            xl.Cells(fila, 2).Font.Bold = True
        '            fila = fila + 2
        '            xl.Cells(fila, 2) = "INGRESOS " & Me.chlbaños.Items(contanios).Value & " POR FECHA DE VENCIMIENTO"
        '            xl.Cells(fila, 2).Font.Bold = True
        '            fila = fila + 2
        '            xl.Cells(fila, 2) = "Mes Venc."
        '            xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '            xl.Cells(fila, 3) = "Proyección	"
        '            xl.Cells(fila, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '            xl.Cells(fila, 4) = "% Proyección"
        '            xl.Cells(fila, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '            xl.Cells(fila, 5) = "Ingresos "
        '            xl.Cells(fila, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '            xl.Cells(fila, 6) = "% Ingreso"
        '            xl.Cells(fila, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '            xl.Cells(fila, 7) = "Morosidad "
        '            xl.Cells(fila, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '            xl.Cells(fila, 8) = "% Morosidad"
        '            xl.Cells(fila, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '            xl.Cells.Range("B5:H5").Font.Bold = True
        '            ListaProyeccion = ReportesBL.Instancia.ReportesDecoin_proyeccion_by_anio_conid(Me.chlbaños.Items(contanios).Value, countconp)
        '            If ListaProyeccion IsNot Nothing Then
        '                Dim vRgProyeccion, VRgIngreso, VRgMorosidad As Decimal
        '                For Each Me.loProyeccion In ListaProyeccion
        '                    fila = fila + 1
        '                    xl.Cells(fila, 2) = loProyeccion.RgMesVen
        '                    xl.Cells(fila, 3) = loProyeccion.RgProyeccion
        '                    vRgProyeccion = vRgProyeccion + loProyeccion.RgProyeccion
        '                    xl.Cells(fila, 4) = loProyeccion.RgPproyeccion
        '                    xl.Cells(fila, 5) = loProyeccion.RgIngreso
        '                    VRgIngreso = VRgIngreso + loProyeccion.RgPIngreso
        '                    xl.Cells(fila, 6) = loProyeccion.RgPIngreso
        '                    xl.Cells(fila, 7) = loProyeccion.RgMorosidad
        '                    VRgMorosidad = VRgMorosidad + loProyeccion.RgMorosidad
        '                    xl.Cells(fila, 8) = loProyeccion.RgPmorosidad
        '                Next

        '                xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous

        '                fila = fila + 1
        '                xl.Cells(fila, 2) = "TOTAL"
        '                xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        '                xl.Cells.Range("B" & fila & ":H" & fila).Font.Bold = True
        '                xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells(fila, 3) = vRgProyeccion
        '                xl.Cells(fila, 4) = "100%"
        '                xl.Cells(fila, 5) = VRgIngreso
        '                xl.Cells(fila, 6) = vRgProyeccion / VRgIngreso
        '                xl.Cells(fila, 7) = VRgMorosidad
        '                xl.Cells(fila, 8) = vRgProyeccion / VRgMorosidad * 100
        '                fila = fila + 2
        '                xl.Cells(fila, 2) = "INGRESOS " & Me.chlbaños.Items(contanios).Value & " POR FECHA DE PAGO"
        '                xl.Cells(fila, 2).Font.Bold = True
        '                fila = fila + 2
        '                xl.Cells(fila, 2) = "Mes Pago"
        '                xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '                xl.Cells(fila, 3) = "Ingresos "
        '                xl.Cells(fila, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '                xl.Cells(fila, 2).Font.Bold = True
        '                xl.Cells(fila, 3).Font.Bold = True
        '                Dim vrange As Integer = fila
        '                Dim totalfp As Double
        '                For Each Me.loProyeccion In ListaProyeccion
        '                    fila = fila + 1
        '                    xl.Cells(fila, 2) = loProyeccion.RgMesVen
        '                    xl.Cells(fila, 3) = loProyeccion.RgMontobyFP
        '                    totalfp = totalfp + loProyeccion.RgMontobyFP
        '                Next

        '                xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous

        '                fila = fila + 1
        '                xl.Cells(fila, 2) = "TOTAL"
        '                xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        '                xl.Cells(fila, 3) = totalfp
        '                xl.Cells(fila, 2).Font.Bold = True
        '                xl.Cells(fila, 3).Font.Bold = True
        '                fila = fila + 2
        '                xl.Cells(fila, 2) = "RESUMEN"
        '                xl.Cells(fila, 2).Font.Bold = True
        '                fila = fila + 1
        '                xl.Cells.Range("B" & fila & ":F" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        '                xl.Cells(fila, 2) = "Total de Proyección 2011"
        '                xl.Cells(fila, 6) = vRgProyeccion
        '                xl.Cells(fila, 6).font.bold = True

        '                xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous

        '                fila = fila + 1
        '                xl.Cells(fila, 2) = "Total de Ingresos 2011"
        '                xl.Cells(fila, 6) = VRgIngreso
        '                xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous

        '                fila = fila + 1
        '                xl.Cells(fila, 2) = "Total de Morosidad 2011"
        '                xl.Cells(fila, 6) = VRgMorosidad
        '                xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous


        '            End If
        '        Next
        '    End If
        'Next
        'Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
#End Region

#Region "Exportar Deudores"
    Private Sub ExportarDeudores()
        'SE OBTIENE EL IGV DE LA TABLA PARAMETRO
        Dim IGV As Decimal = String.Format("{0:0.00}", MantenimientosBL.Instancia.parametroMostrarXClsId(42))
        Dim ListaContratoDeudores As List(Of EEContratoInm) = ReportesBL.Instancia.reporteDeudoresDECOIN()
        xl.Sheets(xl.Worksheets("Lista_Deudores").Index).Select()
        Dim liFila As Integer = 5
        Dim liNroReg As Integer = 1
        Dim ldMontoTotalDetalle As Decimal = 0
        Dim ldMontoTotalPersona As Decimal = 0
        Dim ldMontoTotalAño As Decimal = 0
        Dim liAño As Integer = 0
        Dim lbTempAño As Boolean = False
        'PARA ALMACENAR LOS AÑOS
        Dim htAños As Hashtable = New Hashtable
        Me.beiprogreso.Caption = "Cargando Reporte... "
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If Not ListaContratoDeudores Is Nothing Then
            Me.riprogreso.Minimum = 0
            Me.riprogreso.Maximum = ListaContratoDeudores.Count
            Me.beiprogreso.EditValue = 0
        End If
        For Each fContratoInm As EEContratoInm In ListaContratoDeudores
            Application.DoEvents()
            Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
            If lbTempAño = False Then
                liAño = Year(fContratoInm.ConInmFecIni)
                lbTempAño = True
            End If
            'VERIFICAMOS SI EL AÑO YA SE ENCUENTRA MOSTRADO PARA NO REPETIRLO VARIAS VECES
            If htAños(Year(fContratoInm.ConInmFecIni)) Is Nothing Then
                If htAños.Count > 1 Then
                    liFila = liFila + 1
                    With xl.Range("D" & liFila)
                        .Value = "TOTAL AÑO " & liAño
                        .Font.Bold = True
                    End With
                    With xl.Range("E" & liFila)
                        .Value = ldMontoTotalAño
                        .NumberFormat = "###,##0.00"
                        .Value = "S/." & ldMontoTotalAño
                        .HorizontalAlignment = .XlHAlign.xlHAlignRight
                        .Font.Bold = True
                    End With
                    xl.Range("B" & liFila & ":D" & liFila).MergeCells = True
                    xl.Range("B" & liFila & ":D" & liFila).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    ldMontoTotalAño = 0
                    lbTempAño = False
                    liFila = liFila + 2
                    liNroReg = 1
                End If
                htAños.Add(Year(fContratoInm.ConInmFecIni), Year(fContratoInm.ConInmFecIni))
                With xl.Range("A" & liFila)
                    .Value = Year(fContratoInm.ConInmFecIni)
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    .Font.Bold = True
                End With
            End If
            liFila = liFila + 1
            With xl.Range("A" & liFila)
                .Value = fContratoInm.OPersona.perNombresoRazon.ToUpper()
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                .Font.Bold = True
                .InsertIndent(1)
            End With
            liFila = liFila + 1
            xl.Range("A" & liFila).Value = liNroReg
            With xl.Range("B" & liFila)
                .Value = "'" & fContratoInm.OPersona.PerId
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End With
            With xl.Range("C" & liFila)
                .Value = fContratoInm.OPersona.PerContacto
                .WrapText = True
            End With
            With xl.Range("D" & liFila)
                .Value = "'" & fContratoInm.InmId
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End With
            With xl.Range("E" & liFila)
                .Value = fContratoInm.InmDir
                .WrapText = True
            End With
            With xl.Range("F" & liFila)
                .Value = fContratoInm.ConInmMerced - (fContratoInm.ConInmMerced * IGV)
                .NumberFormat = "###,##0.00"
            End With
            xl.Range("G" & liFila).Value = fContratoInm.ConInmMerced
            xl.Range("H" & liFila).Value = IGV
            xl.Range("I" & liFila).Value = fContratoInm.OTgMoneda.TgNombre
            With xl.Range("J" & liFila)
                .Value = fContratoInm.ConInmObs
                .WrapText = True
            End With
            liFila = liFila + 1

            For Each fProPagos As EEProPagos In fContratoInm.ListaProgramacionPagos
                xl.Range("B" & liFila).Value = "Cod. Prog."
                xl.Range("C" & liFila).Value = "Concepto"
                xl.Range("D" & liFila).Value = "Cod. Concepto"
                xl.Range("E" & liFila).Value = "P. Concepto"
                xl.Range("F" & liFila).Value = "Monto"
                With xl.Range("B" & liFila & ":F" & liFila)
                    .Interior.Color = RGB(141, 180, 226)
                    .Font.Bold = True
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .WrapText = True
                    .Borders().LineStyle = Excel.XlLineStyle.xlContinuous
                End With
                liFila = liFila + 1
                For Each fProPagosDet As EEProPagos.EEProPagosDet In fProPagos.ListaProgramacionPagosDetalle
                    xl.Range("B" & liFila).Value = "'" & fProPagos.ProPaId
                    xl.Range("C" & liFila).Value = fProPagosDet.OConcepto.ConNombre
                    xl.Range("D" & liFila).Value = "'" & fProPagosDet.OConcepto.ConId
                    xl.Range("E" & liFila).Value = (fProPagosDet.ProPaDetPConcepto / 100)
                    xl.Range("E" & liFila).NumberFormat = "0.00%"
                    With xl.Range("F" & liFila)
                        .Value = "S/." & fProPagosDet.ProPaDetMonto
                        .HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    End With

                    ldMontoTotalDetalle = ldMontoTotalDetalle + fProPagosDet.ProPaDetMonto

                    With xl.Range("B" & liFila & ":F" & liFila)
                        .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    End With

                    liFila = liFila + 1
                Next


                xl.Range("E" & liFila).Value = "Total N° Cuota " & fProPagos.ProPaId.Substring(0, 2)
                With xl.Range("F" & liFila)
                    .Value = ldMontoTotalDetalle
                    .NumberFormat = "###,##0.00"
                    .Value = "S/." & ldMontoTotalDetalle
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                End With

                With xl.Range("E" & liFila & ":F" & liFila)
                    .Interior.Color = RGB(220, 230, 241)
                    .Font.Bold = True
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                End With

                ldMontoTotalPersona = ldMontoTotalPersona + ldMontoTotalDetalle

                ldMontoTotalDetalle = 0
                liFila = liFila + 1
            Next

            liFila = liFila + 1

            With xl.Range("E" & liFila)
                .Value = "TOTAL : " & fContratoInm.OPersona.perNombresoRazon.ToUpper
                .Font.Bold = True
            End With

            With xl.Range("F" & liFila)
                .Value = ldMontoTotalPersona
                .NumberFormat = "###,##0.00"
                .Value = "S/." & ldMontoTotalPersona
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                .Font.Bold = True
            End With
            xl.Range("B" & liFila & ":E" & liFila).MergeCells = True
            xl.Range("B" & liFila & ":E" & liFila).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

            ldMontoTotalAño = ldMontoTotalAño + ldMontoTotalPersona

            ldMontoTotalPersona = 0
            liFila = liFila + 1
            liNroReg = liNroReg + 1
        Next

        liFila = liFila + 1

        With xl.Range("D" & liFila)
            .Value = "TOTAL AÑO " & liAño
            .Font.Bold = True
        End With

        With xl.Range("E" & liFila)
            .Value = ldMontoTotalAño
            .NumberFormat = "###,##0.00"
            .Value = "S/." & ldMontoTotalAño
            .HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            .Font.Bold = True
        End With

        xl.Range("B" & liFila & ":D" & liFila).MergeCells = True
        xl.Range("B" & liFila & ":D" & liFila).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
#End Region

#Region "Exportar Proyeccioón de Ingresos"
    Private Sub ExportarProyecciónIngresosFVP(xl As Excel.Application)
        Dim HojaPlantilla As String = "Hoja3"
        Dim conceptos(4) As String
        conceptos = {"S0001", "S6177", "S4516", "S0835"}

        Dim fila As Integer
        Me.beiprogreso.Caption = "Cargando Reporte... "
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        For contanios = 0 To Me.chlbaños.Items.Count - 1
            If Me.chlbaños.Items(contanios).CheckState = CheckState.Checked Then
                If Not conceptos Is Nothing Then
                    Me.riprogreso.Minimum = 0
                    Me.riprogreso.Maximum = conceptos.Length
                    Me.beiprogreso.EditValue = 0
                End If
                For Each countconp In conceptos
                    fila = 1
                    Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                    xl.Sheets(xl.Worksheets(HojaPlantilla).Index).Copy(Before:=xl.Sheets(xl.Worksheets(HojaPlantilla).Index))
                    xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Name = "I" & countconp & "-" & Me.chlbaños.Items(contanios).Value
                    xl.Sheets(xl.Worksheets(HojaPlantilla).Index - 1).Select()
                    xl.Cells(fila, 2) = "REPORTE PARA EL CONCEPTO (" & countconp & " - PAGO DE ALQUILER FINCAS AÑO " & Me.chlbaños.Items(contanios).Value & ")"
                    xl.Cells(fila, 2).Font.Bold = True
                    fila = fila + 2
                    xl.Cells(fila, 2) = "INGRESOS " & Me.chlbaños.Items(contanios).Value & " POR FECHA DE VENCIMIENTO"
                    xl.Cells(fila, 2).Font.Bold = True
                    fila = fila + 2
                    xl.Cells(fila, 2) = "Mes Venc."
                    xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xl.Cells(fila, 3) = "Proyección	"
                    xl.Cells(fila, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xl.Cells(fila, 4) = "% Proyección"
                    xl.Cells(fila, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xl.Cells(fila, 5) = "Ingresos "
                    xl.Cells(fila, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xl.Cells(fila, 6) = "% Ingreso"
                    xl.Cells(fila, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xl.Cells(fila, 7) = "Morosidad "
                    xl.Cells(fila, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xl.Cells(fila, 8) = "% Morosidad"
                    xl.Cells(fila, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xl.Cells.Range("B5:H5").Font.Bold = True
                    ListaProyeccion = ReportesBL.Instancia.ReportesDecoin_proyeccion_by_anio_conid(Me.chlbaños.Items(contanios).Value, countconp)
                    If ListaProyeccion IsNot Nothing Then
                        Dim vRgProyeccion, VRgIngreso, VRgMorosidad As Decimal
                        For Each Me.loProyeccion In ListaProyeccion
                            fila = fila + 1
                            xl.Cells(fila, 2) = loProyeccion.RgMesVen
                            xl.Cells(fila, 3) = loProyeccion.RgProyeccion
                            vRgProyeccion = vRgProyeccion + loProyeccion.RgProyeccion
                            xl.Cells(fila, 4) = loProyeccion.RgPproyeccion
                            xl.Cells(fila, 5) = loProyeccion.RgIngreso
                            VRgIngreso = VRgIngreso + loProyeccion.RgPIngreso
                            xl.Cells(fila, 6) = loProyeccion.RgPIngreso
                            xl.Cells(fila, 7) = loProyeccion.RgMorosidad
                            VRgMorosidad = VRgMorosidad + loProyeccion.RgMorosidad
                            xl.Cells(fila, 8) = loProyeccion.RgPmorosidad
                        Next

                        xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B5:H" & fila).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous

                        fila = fila + 1
                        xl.Cells(fila, 2) = "TOTAL"
                        xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        xl.Cells.Range("B" & fila & ":H" & fila).Font.Bold = True
                        xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B" & fila & ":H" & fila).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(fila, 3) = vRgProyeccion
                        xl.Cells(fila, 4) = "100%"
                        xl.Cells(fila, 5) = VRgIngreso
                        xl.Cells(fila, 6) = vRgProyeccion / VRgIngreso
                        xl.Cells(fila, 7) = VRgMorosidad
                        xl.Cells(fila, 8) = vRgProyeccion / VRgMorosidad * 100
                        fila = fila + 2
                        xl.Cells(fila, 2) = "INGRESOS " & Me.chlbaños.Items(contanios).Value & " POR FECHA DE PAGO"
                        xl.Cells(fila, 2).Font.Bold = True
                        fila = fila + 2
                        xl.Cells(fila, 2) = "Mes Pago"
                        xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xl.Cells(fila, 3) = "Ingresos "
                        xl.Cells(fila, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xl.Cells(fila, 2).Font.Bold = True
                        xl.Cells(fila, 3).Font.Bold = True
                        Dim vrange As Integer = fila
                        Dim totalfp As Double
                        For Each Me.loProyeccion In ListaProyeccion
                            fila = fila + 1
                            xl.Cells(fila, 2) = loProyeccion.RgMesVen
                            xl.Cells(fila, 3) = loProyeccion.RgMontobyFP
                            totalfp = totalfp + loProyeccion.RgMontobyFP
                        Next

                        xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells.Range("B" & vrange & ":C" & fila + 1).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous

                        fila = fila + 1
                        xl.Cells(fila, 2) = "TOTAL"
                        xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        xl.Cells(fila, 3) = totalfp
                        xl.Cells(fila, 2).Font.Bold = True
                        xl.Cells(fila, 3).Font.Bold = True
                        fila = fila + 2
                        xl.Cells(fila, 2) = "RESUMEN"
                        xl.Cells(fila, 2).Font.Bold = True
                        fila = fila + 1
                        xl.Cells.Range("B" & fila & ":F" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(fila, 2) = "Total de Proyección 2011"
                        xl.Cells(fila, 6) = vRgProyeccion
                        xl.Cells(fila, 6).font.bold = True

                        xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous

                        fila = fila + 1
                        xl.Cells(fila, 2) = "Total de Ingresos 2011"
                        xl.Cells(fila, 6) = VRgIngreso
                        xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous

                        fila = fila + 1
                        xl.Cells(fila, 2) = "Total de Morosidad 2011"
                        xl.Cells(fila, 6) = VRgMorosidad
                        xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous


                    End If
                Next
            End If
        Next
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
#End Region

#Region "Reporte Deudores Infocorp"
    Private Sub ReporteDeudoresInfocorp()
        xl.Sheets(0).Select()
        Me.beiprogreso.Caption = "Cargando Reporte... "
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Application.DoEvents()
        Dim liFila As Integer = 10
        Dim ListaDeudoresInfocorp As List(Of EEReportesGeneral) = ReportesBL.Instancia.reporteDeudoresInfocorp()
        For Each fDeudoresInfocorp As EEReportesGeneral In ListaDeudoresInfocorp
            xl.Range("C" & liFila).Value = fDeudoresInfocorp.InfFechaReporte
            xl.Range("D" & liFila).Value = fDeudoresInfocorp.InfCodEntidad
            xl.Range("E" & liFila).Value = fDeudoresInfocorp.InfCodMorosidad
            xl.Range("F" & liFila).Value = fDeudoresInfocorp.InfTipoDocIdentidad
            xl.Range("G" & liFila).Value = fDeudoresInfocorp.InfNroDocIdentidad
            xl.Range("H" & liFila).Value = fDeudoresInfocorp.InfTipoPersona
            xl.Range("I" & liFila).Value = fDeudoresInfocorp.InfTipoDeudor
            xl.Range("J" & liFila).Value = fDeudoresInfocorp.InfNombre
            xl.Range("K" & liFila).Value = fDeudoresInfocorp.InfDireccion
            'xl.Range("L" & liFila).Value = ""
            xl.Range("M" & liFila).Value = fDeudoresInfocorp.InfDistrito
            'xl.Range("N" & liFila).Value = ""
            xl.Range("O" & liFila).Value = fDeudoresInfocorp.InfDepartamento
            xl.Range("P" & liFila).Value = fDeudoresInfocorp.InfFechaVencimiento
            xl.Range("Q" & liFila).Value = fDeudoresInfocorp.InfTipoDocumento
            xl.Range("R" & liFila).Value = fDeudoresInfocorp.InfTipoMoneda
            xl.Range("S" & liFila).Value = fDeudoresInfocorp.InfMontoImpago
            xl.Range("T" & liFila).Value = fDeudoresInfocorp.InfCondicionDeuda
            liFila = liFila + 1
        Next

        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
#End Region

#Region "Reporte Ingresos Diarios TTSC PEM FINCAS"
    Private Sub ExportarIngresosDiarios()
        xl.Sheets(xl.Worksheets("Diario_Decoin").Index).Select()
        Me.beiprogreso.Caption = "Cargando Reporte... "
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Application.DoEvents()
        Dim liFila As Integer = 7
        Dim liFilaRegistroPPD As Integer = 1
        Dim filaResAux As Integer = 0
        Dim ldMontoTotal As Decimal = 0
        Dim ldMPTTotal As Decimal = 0
        Dim ldSAIMTTotal As Decimal = 0
        Dim ldDetraccionTotal As Decimal = 0
        Dim loResumenRep As EEReportesGeneral = Nothing
        xl.Range("G4").Value = "PAGOS EFECTUADOS DEL " & dtpfechaInicio.DateTime.ToString("dd/MM/yyyy") & " AL " & dtpfechaFin.DateTime.ToString("dd/MM/yyyy")
        'ALMACENAR EL RANGO DE FECHAS
        Dim ListaRangoFechas As List(Of Date) = New List(Of Date)
        Dim ldtFechaInicio As Date = dtpfechaFin.DateTime.Date
        While ldtFechaInicio >= dtpfechaInicio.DateTime.Date
            ListaRangoFechas.Add(ldtFechaInicio)
            ldtFechaInicio = DateAdd(DateInterval.Day, -1, ldtFechaInicio)
        End While
        'FIN
        Dim htTotalFincasMPT As Hashtable = New Hashtable()
        Dim htTotalFincasSAIMT As Hashtable = New Hashtable()
        'PARA ALMACENAR LAS FECHAS
        Dim htFechaPago As Hashtable = New Hashtable()
        Dim ListaProPagosDetalle As List(Of EEReportesGeneral) = ReportesBL.Instancia.reporteProPagosDetalleXRangoFecha(dtpfechaInicio.EditValue, dtpfechaFin.EditValue)
        If ListaProPagosDetalle IsNot Nothing Then
            For Each fReporte As EEReportesGeneral In ListaProPagosDetalle
                If htFechaPago(fReporte.ProPaFechaPag) Is Nothing Then
                    If htFechaPago.Count > 0 Then
                        xl.Range("H" & liFila).Value = "TOTAL FINCAS"
                        xl.Range("H" & liFila).Interior.Color = RGB(217, 217, 217)
                        xl.Range("H" & liFila).Font.Bold = True
                        xl.Range("I" & liFila).Value = ldDetraccionTotal
                        xl.Range("I" & liFila).Interior.Color = RGB(217, 217, 217)
                        xl.Range("J" & liFila).Value = ldMontoTotal
                        xl.Range("J" & liFila).Interior.Color = RGB(217, 217, 217)
                        xl.Range("J" & liFila).Font.Bold = True
                        xl.Range("K" & liFila).Value = Math.Round(ldMPTTotal, 2)
                        xl.Range("K" & liFila).Interior.Color = RGB(217, 217, 217)
                        xl.Range("K" & liFila).Font.Bold = True
                        xl.Range("M" & liFila).Value = Math.Round(ldSAIMTTotal, 2)
                        xl.Range("M" & liFila).Interior.Color = RGB(217, 217, 217)
                        xl.Range("M" & liFila).Font.Bold = True
                        filaResAux = liFila
                        xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        liFila = liFila + 1
                        liFilaRegistroPPD = 1
                        ldMontoTotal = 0
                        ldMPTTotal = 0
                        ldSAIMTTotal = 0
                        ldDetraccionTotal = 0
                    End If
                    htFechaPago.Add(fReporte.ProPaFechaPag, fReporte.ProPaFechaPag)
                End If

                xl.Range("A" & liFila).Value = liFilaRegistroPPD
                xl.Range("B" & liFila).Value = fReporte.ProPaFechaPag
                xl.Range("C" & liFila).Value = Trim(fReporte.NroComprobante)
                xl.Range("E" & liFila).Value = fReporte.ConId.Substring(0, 5)
                xl.Range("F" & liFila).Value = fReporte.CtaContable
                xl.Range("G" & liFila).Value = fReporte.CtaPresupuestal
                xl.Range("H" & liFila).Value = fReporte.Persona
                xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 4).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 7).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 8).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 9).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 12).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 13).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 14).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                If fReporte.ConId.Substring(0, 5).Equals("S6177") Then
                    xl.Range("I" & liFila).Value = fReporte.ProPaDetMonto
                    ldDetraccionTotal = ldDetraccionTotal + fReporte.ProPaDetMonto
                    xl.Range("J" & liFila).Value = 0
                Else
                    xl.Range("J" & liFila).Value = fReporte.ProPaDetMonto

                    'MPT
                    xl.Range("K" & liFila).Value = Math.Round(CDec(fReporte.ProPaDetMonto) * CDec(1 - fReporte.ProPaDetPConcepto), 2)
                    xl.Range("L" & liFila).Value = 1 - fReporte.ProPaDetPConcepto
                    xl.Range("L" & liFila).Style = "Percent"

                    'SAIMT
                    xl.Range("M" & liFila).Value = Math.Round(CDec(fReporte.ProPaDetMonto) * CDec(fReporte.ProPaDetPConcepto), 2)
                    xl.Range("N" & liFila).Value = fReporte.ProPaDetPConcepto
                    xl.Range("N" & liFila).Style = "Percent"

                    ldMPTTotal = ldMPTTotal + Math.Round(CDec(fReporte.ProPaDetMonto) * CDec(1 - fReporte.ProPaDetPConcepto), 2)

                    ldSAIMTTotal = ldSAIMTTotal + Math.Round(CDec(fReporte.ProPaDetMonto) * CDec(fReporte.ProPaDetPConcepto), 2)
                    ldMontoTotal = ldMontoTotal + fReporte.ProPaDetMonto
                End If
                xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                liFila = liFila + 1
                liFilaRegistroPPD = liFilaRegistroPPD + 1
            Next

            xl.Range("H" & liFila).Value = "TOTAL FINCAS"
            xl.Range("H" & liFila).Interior.Color = RGB(217, 217, 217)
            xl.Range("H" & liFila).Font.Bold = True
            xl.Range("I" & liFila).Value = ldDetraccionTotal
            xl.Range("I" & liFila).Interior.Color = RGB(217, 217, 217)
            xl.Range("I" & liFila).Font.Bold = True
            xl.Range("J" & liFila).Value = ldMontoTotal
            xl.Range("J" & liFila).Interior.Color = RGB(217, 217, 217)
            xl.Range("J" & liFila).Font.Bold = True
            xl.Range("K" & liFila).Value = Math.Round(ldMPTTotal, 2)
            xl.Range("K" & liFila).Interior.Color = RGB(217, 217, 217)
            xl.Range("K" & liFila).Font.Bold = True
            xl.Range("M" & liFila).Value = Math.Round(ldSAIMTTotal, 2)
            xl.Range("M" & liFila).Interior.Color = RGB(217, 217, 217)
            xl.Range("M" & liFila).Font.Bold = True
            filaResAux = liFila
            liFila = liFila + 1

            'DETALLE CONCEPTOS PROGRAMACION PAGOS

            xl.Range("A5:N6").Select()
            xl.Selection.Copy()
            xl.Range("A" & liFila).Select()
            xl.ActiveSheet.Paste()
            xl.Application.CutCopyMode = False
            xl.Range("H" & liFila).Value = "DESCRIPCION"
            liFila = liFila + 2
            htFechaPago.Clear()
            liFilaRegistroPPD = 1
            ldMontoTotal = 0
            ldMPTTotal = 0
            ldSAIMTTotal = 0
            Dim ListaProPagosDetalleConceptos As List(Of EEReportesGeneral) = ReportesBL.Instancia.reporteProPagosDetalleConceptosXRangoFecha(dtpfechaInicio.EditValue, dtpfechaFin.EditValue)
            For Each fReporte As EEReportesGeneral In ListaProPagosDetalleConceptos
                If htFechaPago(fReporte.ProPaFechaPag) Is Nothing Then
                    If htFechaPago.Count > 0 Then
                        xl.Range("H" & liFila).Value = "TOTAL FINCAS"
                        xl.Range("H" & liFila).Interior.Color = RGB(217, 217, 217)
                        xl.Range("H" & liFila).Font.Bold = True
                        xl.Range("J" & liFila).Value = ldMontoTotal
                        xl.Range("J" & liFila).Interior.Color = RGB(217, 217, 217)
                        xl.Range("J" & liFila).Font.Bold = True
                        xl.Range("K" & liFila).Value = Math.Round(ldMPTTotal, 2)
                        xl.Range("K" & liFila).Interior.Color = RGB(217, 217, 217)
                        xl.Range("K" & liFila).Font.Bold = True
                        xl.Range("M" & liFila).Value = Math.Round(ldSAIMTTotal, 2)
                        xl.Range("M" & liFila).Interior.Color = RGB(217, 217, 217)
                        xl.Range("M" & liFila).Font.Bold = True
                        xl.Cells(filaResAux, 8).Resize(1, 6).Copy(Destination:=xl.Cells(liFila, 8))
                        xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

                        liFila = liFila + 1
                        liFilaRegistroPPD = 1
                        htTotalFincasSAIMT.Add(fReporte.ProPaFechaPag, CDec(ldSAIMTTotal))
                        htTotalFincasMPT.Add(fReporte.ProPaFechaPag, CDec(ldMPTTotal))
                        ldMontoTotal = 0
                        ldMPTTotal = 0
                        ldSAIMTTotal = 0
                    End If
                    htFechaPago.Add(fReporte.ProPaFechaPag, fReporte.ProPaFechaPag)
                End If
                xl.Range("A" & liFila).Value = liFilaRegistroPPD
                xl.Range("B" & liFila).Value = fReporte.ProPaFechaPag
                xl.Range("E" & liFila).Value = fReporte.ConId.Substring(0, 5)
                xl.Range("F" & liFila).Value = fReporte.CtaContable
                xl.Range("G" & liFila).Value = fReporte.CtaPresupuestal
                xl.Range("H" & liFila).Value = fReporte.ConNombre
                xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 4).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 7).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 8).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 9).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 12).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 13).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells(liFila, 14).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                If fReporte.ConId.Substring(0, 5).Equals("S6177") Then
                    xl.Range("I" & liFila).Value = fReporte.ProPaDetMonto
                    xl.Range("J" & liFila).Value = 0
                Else
                    xl.Range("J" & liFila).Value = fReporte.ProPaDetMonto

                    'MPT
                    xl.Range("K" & liFila).Value = Math.Round(CDec(fReporte.ProPaDetMonto) * CDec(1 - fReporte.ProPaDetPConcepto), 2)
                    xl.Range("L" & liFila).Value = 1 - fReporte.ProPaDetPConcepto
                    xl.Range("L" & liFila).Style = "Percent"

                    'SAIMT
                    xl.Range("M" & liFila).Value = Math.Round(CDec(fReporte.ProPaDetMonto) * CDec(fReporte.ProPaDetPConcepto), 2)
                    xl.Range("N" & liFila).Value = fReporte.ProPaDetPConcepto
                    xl.Range("N" & liFila).Style = "Percent"

                    ldMPTTotal = ldMPTTotal + Math.Round(CDec(fReporte.ProPaDetMonto) * CDec(1 - fReporte.ProPaDetPConcepto), 2)
                    ldSAIMTTotal = ldSAIMTTotal + Math.Round(CDec(fReporte.ProPaDetMonto) * CDec(fReporte.ProPaDetPConcepto), 2)

                    ldMontoTotal = ldMontoTotal + fReporte.ProPaDetMonto
                End If
                xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                liFila = liFila + 1
                liFilaRegistroPPD = liFilaRegistroPPD + 1
            Next

            xl.Range("H" & liFila).Value = "TOTAL FINCAS"
            xl.Range("H" & liFila).Interior.Color = RGB(217, 217, 217)
            xl.Range("H" & liFila).Font.Bold = True
            xl.Range("I" & liFila).Value = ldDetraccionTotal
            xl.Range("I" & liFila).Interior.Color = RGB(217, 217, 217)
            xl.Range("I" & liFila).Font.Bold = True
            xl.Range("J" & liFila).Value = ldMontoTotal
            xl.Range("J" & liFila).Interior.Color = RGB(217, 217, 217)
            xl.Range("J" & liFila).Font.Bold = True
            xl.Range("K" & liFila).Value = Math.Round(ldMPTTotal, 2)
            xl.Range("K" & liFila).Interior.Color = RGB(217, 217, 217)
            xl.Range("K" & liFila).Font.Bold = True
            xl.Range("M" & liFila).Value = Math.Round(ldSAIMTTotal, 2)
            xl.Range("M" & liFila).Interior.Color = RGB(217, 217, 217)
            xl.Range("M" & liFila).Font.Bold = True
            xl.Cells(filaResAux, 8).Resize(1, 6).Copy(Destination:=xl.Cells(liFila, 8))

            If htTotalFincasSAIMT(xl.Range("B" & liFila - 1).Value) Is Nothing Then
                htTotalFincasSAIMT.Add(xl.Range("B" & liFila - 1).Value, CDec(ldSAIMTTotal))
            End If

            If htTotalFincasMPT(xl.Range("B" & liFila - 1).Value) Is Nothing Then
                htTotalFincasMPT.Add(xl.Range("B" & liFila - 1).Value, CDec(ldMPTTotal))
            End If

            liFila = liFila + 1
        Else
            With xl.Range("A" & liFila & ":N" & liFila)
                .Merge()
                .Value = "No Existe Registros de Detalle al " & dtpfechaFin.EditValue
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Interior.Color = RGB(255, 0, 0)
                .Font.Italic = True
            End With
            liFila = liFila + 2
        End If
        'PLAYA DE ESTACIONAMIENTO

        With xl.Range("A" & liFila & ":N" & liFila)
            .Merge()
            .Interior.Color = RGB(0, 0, 0)
            .Font.Bold = True
            .Font.ColorIndex = 2
            .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With
        xl.Range("A" & liFila).Value = "RESUMEN PLAYA DE ESTACIONAMIENTO"
        liFila = liFila + 1
        For Each fFechaReporte As Date In ListaRangoFechas
            htFechaPago.Clear()
            liFilaRegistroPPD = 1
            ldMontoTotal = 0
            ldMPTTotal = 0
            ldSAIMTTotal = 0
            Dim ListaRecaudacionDetallePEM As List(Of EEReportesGeneral) = ReportesBL.Instancia.reporteRecaudacionDetXRangoFechaXTgGrupoConId(fFechaReporte, fFechaReporte, "06")
            If ListaRecaudacionDetallePEM IsNot Nothing Then
                For Each fReporte As EEReportesGeneral In ListaRecaudacionDetallePEM
                    If htFechaPago(fReporte.RecFecPago) Is Nothing Then
                        If htFechaPago.Count > 0 Then
                            xl.Range("E" & liFila).Value = "S0490"
                            xl.Range("F" & liFila).Value = "120.10.302"
                            xl.Range("G" & liFila).Value = "1302080105"
                            xl.Range("H" & liFila).Value = "TOTAL PLAYA DE ESTACIONAMIENTO"
                            xl.Range("H" & liFila).Interior.Color = RGB(217, 217, 217)
                            xl.Range("H" & liFila).Font.Bold = True
                            xl.Range("J" & liFila).Value = ldMontoTotal
                            xl.Range("J" & liFila).Interior.Color = RGB(217, 217, 217)
                            xl.Range("I" & liFila).Interior.Color = RGB(217, 217, 217)
                            xl.Range("J" & liFila).Font.Bold = True
                            xl.Range("K" & liFila).Value = Math.Round(ldMPTTotal, 2)
                            xl.Range("K" & liFila).Interior.Color = RGB(217, 217, 217)
                            xl.Range("K" & liFila).Font.Bold = True
                            xl.Range("M" & liFila).Value = Math.Round(ldSAIMTTotal, 2)
                            xl.Range("M" & liFila).Interior.Color = RGB(217, 217, 217)
                            xl.Range("M" & liFila).Font.Bold = True
                            xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            liFila = liFila + 1
                            liFilaRegistroPPD = 1
                            ldMontoTotal = 0
                            ldMPTTotal = 0
                            ldSAIMTTotal = 0
                        End If
                        htFechaPago.Add(fReporte.RecFecPago, fReporte.RecFecPago)
                    End If

                    xl.Range("A" & liFila).Value = liFilaRegistroPPD
                    xl.Range("B" & liFila).Value = fReporte.RecFecPago
                    xl.Range("E" & liFila).Value = fReporte.ConId.Substring(0, 5)
                    xl.Range("F" & liFila).Value = "120.10.302"
                    xl.Range("G" & liFila).Value = "1302080105"

                    xl.Range("H" & liFila).Font.Size = 8
                    xl.Range("H" & liFila).Value = fReporte.ConNombre
                    xl.Range("H" & liFila).WrapText = True
                    xl.Range("J" & liFila).Value = fReporte.RecDMonto

                    'MPT
                    xl.Range("K" & liFila).Value = Math.Round(CDec(fReporte.RecDMonto) * CDec(1 - fReporte.ConPorcentaje), 2)
                    xl.Range("L" & liFila).Value = 1 - fReporte.ConPorcentaje
                    xl.Range("L" & liFila).Style = "Percent"

                    'SAIMT
                    xl.Range("M" & liFila).Value = Math.Round(CDec(fReporte.RecDMonto) * CDec(fReporte.ConPorcentaje), 2)
                    xl.Range("N" & liFila).Value = fReporte.ConPorcentaje
                    xl.Range("N" & liFila).Style = "Percent"

                    xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 4).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 7).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 8).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 9).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 12).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 13).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 14).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                    ldMPTTotal = ldMPTTotal + Math.Round(CDec(fReporte.RecDMonto) * CDec(1 - fReporte.ConPorcentaje), 2)
                    ldSAIMTTotal = ldSAIMTTotal + Math.Round(CDec(fReporte.RecDMonto) * CDec(fReporte.ConPorcentaje), 2)
                    xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    liFila = liFila + 1
                    liFilaRegistroPPD = liFilaRegistroPPD + 1
                    ldMontoTotal = ldMontoTotal + fReporte.RecDMonto
                Next

                xl.Range("B" & liFila).Value = xl.Range("B" & liFila - 1).Value
                xl.Range("E" & liFila).Value = "S0490"
                xl.Range("F" & liFila).Value = "120.10.302"
                xl.Range("G" & liFila).Value = "1302080105"
                xl.Range("H" & liFila).Value = "TOTAL PLAYA DE ESTACIONAMIENTO"
                xl.Range("H" & liFila).Interior.Color = RGB(217, 217, 217)
                xl.Range("H" & liFila).Font.Bold = True
                xl.Range("J" & liFila).Value = ldMontoTotal
                xl.Range("J" & liFila).Interior.Color = RGB(217, 217, 217)
                xl.Range("J" & liFila).Font.Bold = True
                xl.Range("K" & liFila).Value = Math.Round(ldMPTTotal, 2)
                xl.Range("k" & liFila).Interior.Color = RGB(217, 217, 217)
                xl.Range("K" & liFila).Font.Bold = True
                xl.Range("M" & liFila).Value = Math.Round(ldSAIMTTotal, 2)
                xl.Range("M" & liFila).Interior.Color = RGB(217, 217, 217)
                xl.Range("I" & liFila).Interior.Color = RGB(217, 217, 217)
                xl.Range("M" & liFila).Font.Bold = True

            Else
                loResumenRep = ReportesBL.Instancia.reporteRecaudacionXRecFecPagoXTgGrupoConId(fFechaReporte, "06")

                If loResumenRep IsNot Nothing Then
                    xl.Range("B" & liFila).Value = loResumenRep.RecFecPago
                    xl.Range("E" & liFila).Value = "S0490"
                    xl.Range("F" & liFila).Value = "120.10.302"
                    xl.Range("G" & liFila).Value = "1302080105"
                    xl.Range("H" & liFila).Value = "TOTAL PLAYA DE ESTACIONAMIENTO"
                    xl.Range("H" & liFila).Interior.Color = RGB(217, 217, 217)
                    xl.Range("H" & liFila).Font.Bold = True
                    xl.Range("J" & liFila).Value = loResumenRep.RecDMonto
                    xl.Range("J" & liFila).Interior.Color = RGB(217, 217, 217)
                    xl.Range("J" & liFila).Font.Bold = True
                    xl.Range("K" & liFila).Value = Math.Round(CDec(1 - loResumenRep.ConPorcentaje) * CDec(loResumenRep.RecDMonto), 2)
                    xl.Range("k" & liFila).Interior.Color = RGB(217, 217, 217)
                    xl.Range("K" & liFila).Font.Bold = True
                    xl.Range("M" & liFila).Value = Math.Round(CDec(loResumenRep.ConPorcentaje) * CDec(loResumenRep.RecDMonto), 2)
                    xl.Range("M" & liFila).Interior.Color = RGB(217, 217, 217)
                    xl.Range("I" & liFila).Interior.Color = RGB(217, 217, 217)
                    xl.Range("M" & liFila).Font.Bold = True
                Else
                    With xl.Range("A" & liFila & ":N" & liFila)
                        .Merge()
                        .Value = "No Existe Registros de Detalle al " & fFechaReporte
                        .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        .Interior.Color = RGB(255, 0, 0)
                        .Font.Italic = True
                    End With

                End If
            End If
            xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            liFila = liFila + 1
        Next
        liFila = liFila + 1
        loResumenRep = Nothing
        'TERMINAL TERRESTRE
        With xl.Range("A" & liFila & ":N" & liFila)
            .Merge()
            .Interior.Color = RGB(0, 0, 0)
            .Font.Bold = True
            .Font.ColorIndex = 2
            .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With
        xl.Range("A" & liFila).Value = "RESUMEN TERMINAL TERRESTRE"
        liFila = liFila + 1
        For Each fFechaReporte As Date In ListaRangoFechas
            htFechaPago.Clear()
            liFilaRegistroPPD = 1
            ldMontoTotal = 0
            ldMPTTotal = 0
            ldSAIMTTotal = 0
            Dim ListaRecaudacionDetalleTTSC As List(Of EEReportesGeneral) = ReportesBL.Instancia.reporteRecaudacionDetXRangoFechaXTgGrupoConId(fFechaReporte, fFechaReporte, "07")
            If ListaRecaudacionDetalleTTSC IsNot Nothing Then
                For Each fReporte As EEReportesGeneral In ListaRecaudacionDetalleTTSC
                    If htFechaPago(fReporte.RecFecPago) Is Nothing Then
                        If htFechaPago.Count > 0 Then
                            xl.Range("E" & liFila).Value = "S0669"
                            xl.Range("F" & liFila).Value = "120.10.302"
                            xl.Range("G" & liFila).Value = "1302080106"
                            xl.Range("H" & liFila).Value = "TOTAL TERMINAL TERRESTRE"
                            xl.Range("H" & liFila).Interior.Color = RGB(217, 217, 217)
                            xl.Range("H" & liFila).Font.Bold = True
                            xl.Range("J" & liFila).Value = ldMontoTotal
                            xl.Range("J" & liFila).Interior.Color = RGB(217, 217, 217)
                            xl.Range("J" & liFila).Font.Bold = True
                            xl.Range("K" & liFila).Value = Math.Round(ldMPTTotal, 2)
                            xl.Range("K" & liFila).Interior.Color = RGB(217, 217, 217)
                            xl.Range("K" & liFila).Font.Bold = True
                            xl.Range("M" & liFila).Value = Math.Round(ldSAIMTTotal, 2)
                            xl.Range("M" & liFila).Interior.Color = RGB(217, 217, 217)
                            xl.Range("I" & liFila).Interior.Color = RGB(217, 217, 217)
                            xl.Range("M" & liFila).Font.Bold = True
                            xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            liFila = liFila + 1
                            liFilaRegistroPPD = 1
                            ldMontoTotal = 0
                            ldMPTTotal = 0
                            ldSAIMTTotal = 0
                        End If
                        htFechaPago.Add(fReporte.RecFecPago, fReporte.RecFecPago)
                    End If
                    xl.Range("A" & liFila).Value = liFilaRegistroPPD
                    xl.Range("B" & liFila).Value = fReporte.RecFecPago
                    xl.Range("E" & liFila).Value = fReporte.ConId.Substring(0, 5)
                    xl.Range("F" & liFila).Value = "120.10.302"
                    xl.Range("G" & liFila).Value = "1302080106"
                    xl.Range("H" & liFila).Value = fReporte.ConNombre
                    xl.Range("H" & liFila).WrapText = True
                    xl.Range("J" & liFila).Value = fReporte.RecDMonto
                    'MPT
                    xl.Range("K" & liFila).Value = Math.Round(CDec(fReporte.RecDMonto) * CDec(1 - fReporte.ConPorcentaje), 2)
                    xl.Range("L" & liFila).Value = 1 - fReporte.ConPorcentaje
                    xl.Range("L" & liFila).Style = "Percent"
                    'SAIMT
                    xl.Range("M" & liFila).Value = Math.Round(CDec(fReporte.RecDMonto) * CDec(fReporte.ConPorcentaje), 2)
                    xl.Range("N" & liFila).Value = fReporte.ConPorcentaje
                    xl.Range("N" & liFila).Style = "Percent"
                    ldMPTTotal = ldMPTTotal + Math.Round(CDec(fReporte.RecDMonto) * CDec(1 - fReporte.ConPorcentaje), 2)
                    ldSAIMTTotal = ldSAIMTTotal + Math.Round(CDec(fReporte.RecDMonto) * CDec(fReporte.ConPorcentaje), 2)
                    xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 4).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 7).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 8).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 9).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 12).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 13).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 14).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    liFila = liFila + 1
                    liFilaRegistroPPD = liFilaRegistroPPD + 1
                    ldMontoTotal = ldMontoTotal + fReporte.RecDMonto
                Next
                xl.Range("B" & liFila).Value = xl.Range("B" & liFila - 1).Value
                xl.Range("E" & liFila).Value = "S0669"
                xl.Range("F" & liFila).Value = "120.10.302"
                xl.Range("G" & liFila).Value = "1302080106"
                xl.Range("H" & liFila).Value = "TOTAL TERMINAL TERRESTRE"
                xl.Range("H" & liFila).Interior.Color = RGB(217, 217, 217)
                xl.Range("H" & liFila).Font.Bold = True
                xl.Range("J" & liFila).Value = ldMontoTotal
                xl.Range("J" & liFila).Interior.Color = RGB(217, 217, 217)
                xl.Range("J" & liFila).Font.Bold = True
                xl.Range("K" & liFila).Value = Math.Round(ldMPTTotal, 2)
                xl.Range("K" & liFila).Interior.Color = RGB(217, 217, 217)
                xl.Range("K" & liFila).Font.Bold = True
                xl.Range("M" & liFila).Value = Math.Round(ldSAIMTTotal, 2)
                xl.Range("M" & liFila).Interior.Color = RGB(217, 217, 217)
                xl.Range("I" & liFila).Interior.Color = RGB(217, 217, 217)
                xl.Range("M" & liFila).Font.Bold = True
            Else
                loResumenRep = ReportesBL.Instancia.reporteRecaudacionXRecFecPagoXTgGrupoConId(fFechaReporte, "07")
                If loResumenRep IsNot Nothing Then
                    xl.Range("B" & liFila).Value = loResumenRep.RecFecPago
                    xl.Range("E" & liFila).Value = "S0669"
                    xl.Range("F" & liFila).Value = "120.10.302"
                    xl.Range("G" & liFila).Value = "1302080106"
                    xl.Range("H" & liFila).Value = "TOTAL TERMINAL TERRESTRE"
                    xl.Range("H" & liFila).Interior.Color = RGB(217, 217, 217)
                    xl.Range("H" & liFila).Font.Bold = True
                    xl.Range("J" & liFila).Value = loResumenRep.RecDMonto
                    xl.Range("J" & liFila).Interior.Color = RGB(217, 217, 217)
                    xl.Range("J" & liFila).Font.Bold = True
                    xl.Range("K" & liFila).Value = Math.Round(CDec(1 - loResumenRep.ConPorcentaje) * CDec(loResumenRep.RecDMonto), 2)
                    xl.Range("K" & liFila).Interior.Color = RGB(217, 217, 217)
                    xl.Range("K" & liFila).Font.Bold = True
                    xl.Range("M" & liFila).Value = Math.Round(CDec(loResumenRep.ConPorcentaje) * CDec(loResumenRep.RecDMonto), 2)
                    xl.Range("M" & liFila).Interior.Color = RGB(217, 217, 217)
                    xl.Range("I" & liFila).Interior.Color = RGB(217, 217, 217)
                    xl.Range("M" & liFila).Font.Bold = True
                Else
                    With xl.Range("A" & liFila & ":N" & liFila)
                        .Merge()
                        .Value = "No Existe Registros de Detalle al " & fFechaReporte
                        .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        .Interior.Color = RGB(255, 0, 0)
                        .Font.Italic = True
                    End With
                End If
            End If
            xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            liFila = liFila + 1
        Next
        liFila = liFila + 1
        xl.Cells(liFila, 1) = "RESUMEN TOTAL GENERAL"
        xl.Cells(liFila, 1).Font.Color = RGB(255, 255, 255)
        xl.Cells(liFila, 1).Font.Bold = True
        xl.Cells(liFila, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(liFila, 1).Resize(1, 14).Interior.Color = RGB(0, 0, 0)
        xl.Cells(liFila, 1).Resize(1, 14).MergeCells = True
        liFila = liFila + 1
        'TOTALES
        For Each fFechaReporte As Date In ListaRangoFechas
            ldMontoTotal = 0
            ldMPTTotal = 0
            ldSAIMTTotal = 0
            xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 4).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 7).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 8).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 9).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 12).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 13).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 14).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            Dim loTotalPP As EEReportesGeneral = ReportesBL.Instancia.reporteProgramacionPagosTotalXProPaFechaPag(fFechaReporte)
            If loTotalPP IsNot Nothing Then
                xl.Range("B" & liFila).Value = loTotalPP.ProPaFechaPag
                xl.Range("H" & liFila).Value = "TOTAL FINCAS"
                xl.Range("H" & liFila).Font.Bold = True
                xl.Range("J" & liFila).Value = loTotalPP.ProPaDetMonto
                'MPT
                'xl.Range("K" & liFila).Value = loTotalPP.ProPaDetMonto * (1 - 0.5)
                'xl.Range("L" & liFila).Value = 1 - 0.5
                'xl.Range("L" & liFila).Style = "Percent"
                xl.Range("K" & liFila).Value = Math.Round(htTotalFincasMPT(loTotalPP.ProPaFechaPag), 2)
                xl.Range("L" & liFila).Value = 1 - 0.5
                xl.Range("L" & liFila).Style = "Percent"
                'SAIMT
                'xl.Range("M" & liFila).Value = loTotalPP.ProPaDetMonto * 0.5
                'xl.Range("N" & liFila).Value = 0.5
                'xl.Range("N" & liFila).Style = "Percent"
                xl.Range("M" & liFila).Value = Math.Round(CDec(htTotalFincasSAIMT(loTotalPP.ProPaFechaPag)), 2)
                xl.Range("N" & liFila).Value = 0.5
                xl.Range("N" & liFila).Style = "Percent"
                ldMPTTotal = ldMPTTotal + Math.Round(CDec(htTotalFincasMPT(loTotalPP.ProPaFechaPag)), 2)
                ldSAIMTTotal = ldSAIMTTotal + Math.Round(CDec(htTotalFincasSAIMT(loTotalPP.ProPaFechaPag)), 2)
                ldMontoTotal = ldMontoTotal + loTotalPP.ProPaDetMonto
                xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                liFila = liFila + 1
            End If
            xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 4).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 7).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 8).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 9).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 12).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 13).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 14).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            Dim loReporteRecaudacionPEM As EEReportesGeneral = ReportesBL.Instancia.reporteRecaudacionXRecFecPagoXTgGrupoConId(fFechaReporte, "06")
            If loReporteRecaudacionPEM IsNot Nothing Then
                xl.Range("B" & liFila).Value = loReporteRecaudacionPEM.RecFecPago
                xl.Range("E" & liFila).Value = "S0490"
                xl.Range("F" & liFila).Value = "120.10.302"
                xl.Range("G" & liFila).Value = "1302080105"
                xl.Range("H" & liFila).Value = "TOTAL PLAYA DE ESTACIONAMIENTO"
                xl.Range("H" & liFila).Font.Bold = True
                xl.Range("J" & liFila).Value = loReporteRecaudacionPEM.RecDMonto
                'MPT
                xl.Range("K" & liFila).Value = Math.Round(CDec(loReporteRecaudacionPEM.RecDMonto) * CDec(1 - loReporteRecaudacionPEM.ConPorcentaje), 2)
                xl.Range("L" & liFila).Value = 1 - loReporteRecaudacionPEM.ConPorcentaje
                xl.Range("L" & liFila).Style = "Percent"

                'SAIMT
                xl.Range("M" & liFila).Value = Math.Round(CDec(loReporteRecaudacionPEM.RecDMonto) * CDec(loReporteRecaudacionPEM.ConPorcentaje), 2)
                xl.Range("N" & liFila).Value = loReporteRecaudacionPEM.ConPorcentaje
                xl.Range("N" & liFila).Style = "Percent"

                ldMPTTotal = ldMPTTotal + Math.Round(CDec(loReporteRecaudacionPEM.RecDMonto) * CDec(1 - loReporteRecaudacionPEM.ConPorcentaje), 2)
                ldSAIMTTotal = ldSAIMTTotal + Math.Round(CDec(loReporteRecaudacionPEM.RecDMonto) * CDec(loReporteRecaudacionPEM.ConPorcentaje), 2)
                ldMontoTotal = ldMontoTotal + loReporteRecaudacionPEM.RecDMonto
                xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                liFila = liFila + 1
            End If
            xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 4).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 7).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 8).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 9).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 12).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 13).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(liFila, 14).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            Dim loReporteRecaudacionTTSC As EEReportesGeneral = ReportesBL.Instancia.reporteRecaudacionXRecFecPagoXTgGrupoConId(fFechaReporte, "07")
            If loReporteRecaudacionTTSC IsNot Nothing Then
                xl.Range("B" & liFila).Value = loReporteRecaudacionTTSC.RecFecPago
                xl.Range("E" & liFila).Value = "S0669"
                xl.Range("F" & liFila).Value = "120.10.302"
                xl.Range("G" & liFila).Value = "1302080106"
                xl.Range("H" & liFila).Value = "TOTAL TERMINAL TERRESTRE"
                xl.Range("H" & liFila).Font.Bold = True
                xl.Range("J" & liFila).Value = loReporteRecaudacionTTSC.RecDMonto
                'MPT
                xl.Range("K" & liFila).Value = Math.Round(CDec(loReporteRecaudacionTTSC.RecDMonto) * CDec(1 - loReporteRecaudacionTTSC.ConPorcentaje), 2)
                xl.Range("L" & liFila).Value = 1 - loReporteRecaudacionTTSC.ConPorcentaje
                xl.Range("L" & liFila).Style = "Percent"
                'SAIMT
                xl.Range("M" & liFila).Value = Math.Round(CDec(loReporteRecaudacionTTSC.RecDMonto) * CDec(loReporteRecaudacionTTSC.ConPorcentaje), 2)
                xl.Range("N" & liFila).Value = loReporteRecaudacionTTSC.ConPorcentaje
                xl.Range("N" & liFila).Style = "Percent"
                ldMPTTotal = ldMPTTotal + Math.Round(CDec(loReporteRecaudacionTTSC.RecDMonto) * CDec(1 - loReporteRecaudacionTTSC.ConPorcentaje), 2)
                ldSAIMTTotal = ldSAIMTTotal + Math.Round(CDec(loReporteRecaudacionTTSC.RecDMonto) * CDec(loReporteRecaudacionTTSC.ConPorcentaje), 2)
                ldMontoTotal = ldMontoTotal + loReporteRecaudacionTTSC.RecDMonto
                xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                liFila = liFila + 1
            End If

            If loTotalPP IsNot Nothing Then
                xl.Range("B" & liFila).Value = loTotalPP.ProPaFechaPag
                xl.Range("H" & liFila).Value = "TOTAL GENERAL"
                xl.Range("H" & liFila).Font.Bold = True
                xl.Range("J" & liFila).Value = ldMontoTotal
                'MPT
                xl.Range("K" & liFila).Value = Math.Round(ldMPTTotal, 2)
                'SAIMT
                xl.Range("M" & liFila).Value = Math.Round(ldSAIMTTotal, 2)
                With xl.Range("A" & liFila & ":N" & liFila)
                    .Interior.Color = RGB(217, 217, 217)
                    .Font.Bold = True
                End With
                xl.Cells(liFila, 1).Resize(1, 14).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                liFila = liFila + 2
            End If
        Next
        xl.Range("A4").Select()
        htTotalFincasMPT.Clear()
        htTotalFincasSAIMT.Clear()
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
#End Region


End Class
