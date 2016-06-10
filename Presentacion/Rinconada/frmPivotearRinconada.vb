Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmPivotearRinconada

    Dim dtPivot As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtPivot.Columns.Add("NroTicket", GetType(String))
        dtPivot.Columns.Add("Placa", GetType(String))
        dtPivot.Columns.Add("FechaInicio", GetType(Date))
        dtPivot.Columns.Add("FechaTermino", GetType(Date))
        dtPivot.Columns.Add("Importe", GetType(Decimal))
        dtPivot.Columns.Add("EstadoDiario", GetType(String))
        dtPivot.Columns.Add("HoraIngreso", GetType(TimeSpan))
        dtPivot.Columns.Add("HoraSalida", GetType(TimeSpan))
        dtPivot.Columns.Add("TipoAbonado", GetType(String))
        dtPivot.Columns.Add("Concepto", GetType(String))
        dtPivot.Columns.Add("FechaPago", GetType(Date))
        dtPivot.Columns.Add("HoraPago", GetType(TimeSpan))
        dtPivot.Columns.Add("Año", GetType(String))
        dtPivot.Columns.Add("Mes", GetType(String))
        dtPivot.Columns.Add("TipoUsuario", GetType(String))
        dtPivot.Columns.Add("NroPlaca", GetType(Integer))
        dtPivot.Columns.Add("CantPers", GetType(Integer))
    End Sub
#End Region

    Private Sub frmPivotearPEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()

        cboMensual.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboMensual.Properties.DisplayMember = "TgNombre"
        cboMensual.Properties.ValueMember = "TgCodigo"
        Dim ListaMeses As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId(40)
        Dim liFila As Int16 = 0
        For Each fTablaGeneral As EETablaGeneral In ListaMeses
            ListaMeses(liFila).TgNombre = ListaMeses(liFila).TgNombre & " - " & DateTime.Now.Year
            liFila = liFila + 1
        Next
        cboMensual.Properties.DataSource = ListaMeses
        cboMensual.ItemIndex = 0
    End Sub

    Private Sub btnMostrarXFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarXFecha.Click
        Try
            Dim ListaReporte As List(Of EEReportesGeneral) = Nothing
            If rdgFechas.SelectedIndex = 0 Then
                ListaReporte = ReportesBL.Instancia.reportePivotearRinconada(0, dtpDiario.EditValue.ToString())
            ElseIf rdgFechas.SelectedIndex = 1 Then
                ListaReporte = ReportesBL.Instancia.reportePivotearRinconada(1, dtpInicioIntervalo.EditValue.ToString() & "-" & dtpFinIntervalo.EditValue.ToString())
            ElseIf rdgFechas.SelectedIndex = 2 Then
                ListaReporte = ReportesBL.Instancia.reportePivotearRinconada(2, cboMensual.EditValue.ToString())
            End If
            dtPivot.Rows.Clear()
            If ListaReporte IsNot Nothing Then
                For Each fReporte As EEReportesGeneral In ListaReporte
                    dtPivot.LoadDataRow(New Object() {fReporte.NroTicket,
                            fReporte.Placa,
                            fReporte.FechaInicio,
                            fReporte.FechaTermino,
                            fReporte.Importe,
                            fReporte.EstadoDiario,
                            fReporte.HoraIngreso,
                            fReporte.HoraSalida,
                            fReporte.TipoAbonado,
                            fReporte.Concepto,
                            fReporte.FechaPago,
                            fReporte.HoraPago,
                            fReporte.Año,
                            fReporte.Mes,
                            fReporte.TipoUsuario,
                            fReporte.NroPlaca,
                            fReporte.CantPersonas
                       }, True)
                Next
                pgcPivotearPEM.DataSource = dtPivot
                pgcPivotearPEM.RefreshData()
                pgcPivotearPEM.BestFit()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        Try
            sfdDescargar.Filter = "Archivos de Excel|.xls"
            If sfdDescargar.ShowDialog = Windows.Forms.DialogResult.OK Then
                pgcPivotearPEM.ExportToXls(sfdDescargar.FileName)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
End Class