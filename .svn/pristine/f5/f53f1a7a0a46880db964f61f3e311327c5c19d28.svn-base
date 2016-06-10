Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmRptPivotProPagos

    Dim dtPivoteoProPagos As DataTable = New DataTable()

#Region "Construir Table Programacion Pagos"
    Private Sub ConstruirTablePivotProPagos()
        dtPivoteoProPagos.Columns.Add("proPaId", GetType(String))
        dtPivoteoProPagos.Columns.Add("año", GetType(String))
        dtPivoteoProPagos.Columns.Add("perId", GetType(String))
        dtPivoteoProPagos.Columns.Add("persona", GetType(String))
        dtPivoteoProPagos.Columns.Add("contacto", GetType(String))
        dtPivoteoProPagos.Columns.Add("direccion", GetType(String))
        dtPivoteoProPagos.Columns.Add("conId", GetType(String))
        dtPivoteoProPagos.Columns.Add("conNombre", GetType(String))
        dtPivoteoProPagos.Columns.Add("monto", GetType(Decimal))
        dtPivoteoProPagos.Columns.Add("proPaNroCuota", GetType(Int16))
        dtPivoteoProPagos.Columns.Add("proPaFechaVen", GetType(DateTime))
        dtPivoteoProPagos.Columns.Add("proPaFechaPag", GetType(DateTime))
        dtPivoteoProPagos.Columns.Add("mesc_orden", GetType(Int16))
        dtPivoteoProPagos.Columns.Add("mes_cuotas", GetType(String))
        dtPivoteoProPagos.Columns.Add("mesp_orden", GetType(Int16))
        dtPivoteoProPagos.Columns.Add("mes_pagado", GetType(String))
        dtPivoteoProPagos.Columns.Add("tgEstado", GetType(String))
        dtPivoteoProPagos.Columns.Add("inmId", GetType(String))
        dtPivoteoProPagos.Columns.Add("proPaComision", GetType(Decimal))
        dtPivoteoProPagos.Columns.Add("tgInmCondRegId", GetType(String))
        dtPivoteoProPagos.Columns.Add("TgInmCondLegalId", GetType(String))
        dtPivoteoProPagos.Columns.Add("DiferenciaDias", GetType(String))
        dtPivoteoProPagos.Columns.Add("CompPago", GetType(String))
        dtPivoteoProPagos.Columns.Add("TipoDoc", GetType(String))
        dtPivoteoProPagos.Columns.Add("NroDoc", GetType(String))
        dtPivoteoProPagos.Columns.Add("TipoUso", GetType(String))
        dtPivoteoProPagos.Columns.Add("aream2", GetType(Decimal))
        dtPivoteoProPagos.Columns.Add("ingsaimt", GetType(Decimal))
        dtPivoteoProPagos.Columns.Add("ingmpt", GetType(Decimal))
        dtPivoteoProPagos.Columns.Add("netosaimt", GetType(Decimal))
    End Sub
#End Region

    Private Sub frmRptPivotProPagos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ConstruirTablePivotProPagos()
            Dim ListaAños As List(Of String) = MantenimientosBL.Instancia.proPagosListarAñosProPagos_EnPivotProPagos()
            For Each fAños As String In ListaAños
                cboAños.Properties.Items.Add(fAños)
            Next
            cboAños.SelectedIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnVerReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnVerReporte.Click
        Try
            Me.btnVerReporte.Enabled = False
            Dim ListaReporte As List(Of EEReportesGeneral) = ReportesBL.Instancia.ReportePivotearProPagosCriterio(cboReportes.SelectedIndex, cboAños.Text)
            pgcRecaudacion.DataSource = Nothing
            Me.riprogreso.Maximum = ListaReporte.Count
            Me.riprogreso.Minimum = 0
            Me.beiprogreso.EditValue = 0
            Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.beiprogreso.Caption = "Cargando datos para Reporte..."
            dtPivoteoProPagos.Rows.Clear()
            For Each fReporte As EEReportesGeneral In ListaReporte
                dtPivoteoProPagos.LoadDataRow(New Object() {fReporte.ProPaId, _
                        fReporte.Año, _
                        fReporte.PerId, _
                        fReporte.Persona, _
                        fReporte.Contacto, _
                        fReporte.Direccion, _
                        fReporte.ConId, _
                        fReporte.ConNombre, _
                        fReporte.ProPaDetMonto, _
                        fReporte.ProPaNroCuota, _
                        fReporte.ProPaFechaVen, _
                        fReporte.ProPaFechaPag, _
                        fReporte.MesC_Orden, _
                        fReporte.Mes_Cuotas, _
                        fReporte.MesP_Orden, _
                        fReporte.Mes_Pagado, _
                        fReporte.Estado, _
                        fReporte.InmId, _
                        fReporte.ProPaComision, _
                        fReporte.tgInmCondReg, _
                        fReporte.TgInmCondLegal, _
                        fReporte.DiferenciaDias & " Días", _
                        fReporte.CompPago, _
                        fReporte.TipoDoc, _
                        fReporte.NroDoc, _
                        fReporte.ProPaTipoUso,
                        fReporte.InmPredArea,
                        fReporte.MontoSAIMT,
                        fReporte.MontoMPT,
                        fReporte.NetoSaimt
                   }, True)
                Application.DoEvents()
                Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                Me.beiprogreso.Caption = "Cargando reporte...(" & Format(Me.beiprogreso.EditValue / Me.riprogreso.Maximum, "0%") & ") "
            Next
            Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            pgcRecaudacion.DataSource = dtPivoteoProPagos
            pgcRecaudacion.BestFit()
            Me.btnVerReporte.Enabled = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarExcel.Click
        Try
            sfdDescargar.Filter = "Archivos de Excel|.xls"
            If sfdDescargar.ShowDialog = Windows.Forms.DialogResult.OK Then
                pgcRecaudacion.ExportToXls(sfdDescargar.FileName)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnmostrardet_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class