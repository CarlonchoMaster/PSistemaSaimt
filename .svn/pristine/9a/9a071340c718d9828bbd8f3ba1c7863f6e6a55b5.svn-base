Imports Entidades
Imports ReglasNegocio
Imports SaimtControles

Public Class frmRptAsistencias

    Dim dtPivot As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtPivot.Columns.Add("Num_Marca", GetType(Integer))
        dtPivot.Columns.Add("CodTarjeta", GetType(String))
        dtPivot.Columns.Add("Trabajador", GetType(String))
        dtPivot.Columns.Add("TipoTrabajador", GetType(String))
        dtPivot.Columns.Add("UnidadOrg", GetType(String))
        dtPivot.Columns.Add("Documento", GetType(String))
        dtPivot.Columns.Add("FechaMar", GetType(Date))
        dtPivot.Columns.Add("Hora", GetType(String))
        dtPivot.Columns.Add("CodTrabajador", GetType(Integer))
        dtPivot.Columns.Add("Incidencia", GetType(String))
        dtPivot.Columns.Add("Estado", GetType(String))
        dtPivot.Columns.Add("Temprano", GetType(String))
        dtPivot.Columns.Add("Tardanza", GetType(String))
        dtPivot.Columns.Add("Obs", GetType(String))
        dtPivot.Columns.Add("NroFaltas", GetType(Integer))
    End Sub
#End Region

    Private Sub frmRptAsistencias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dtpInicio.EditValue = DateTime.Now
        dtpTermino.EditValue = DateTime.Now
    End Sub

    Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click
        sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            pgcPivotearAsistencias.ExportToXls(sfdexportar.FileName)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim ListaReporte As List(Of EEReportesGeneral) = ReportesBL.Instancia.reportePivotearAsistencias_XFecha(dtpInicio.EditValue, dtpTermino.EditValue)
            If ListaReporte IsNot Nothing Then
                dtPivot.Rows.Clear()
                For Each fReporte As EEReportesGeneral In ListaReporte
                    dtPivot.LoadDataRow(New Object() {fReporte.Num_Marca,
                            fReporte.CodTarjeta,
                            fReporte.Trabajador,
                            fReporte.TipoTrabajador,
                            fReporte.UnidadOrg,
                            fReporte.Documento,
                            fReporte.FechaMar,
                            fReporte.Hora,
                            fReporte.CodTrabajador,
                            fReporte.Incidencia,
                            fReporte.Estado,
                            fReporte.Temprano,
                            fReporte.Tardanza,
                            fReporte.Obs,
                            fReporte.NroFaltas
                       }, True)
                Next
                pgcPivotearAsistencias.DataSource = dtPivot
                pgcPivotearAsistencias.RefreshData()
                pgcPivotearAsistencias.BestFit()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
End Class