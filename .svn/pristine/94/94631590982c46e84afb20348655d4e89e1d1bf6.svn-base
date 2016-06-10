Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmRptPivotPecosa
    Dim dtpivot As DataTable = New DataTable()
    Dim Registro(13) As Object

#Region "Construir Table"
    Private Sub ConstruirTableSalidaArticuloAlmacenDetalle()
        'Salida Productos Almacen
        dtpivot.Columns.Add("PecId", GetType(String))
        dtpivot.Columns.Add("PecNro", GetType(String))
        dtpivot.Columns.Add("OrdNro", GetType(String))
        dtpivot.Columns.Add("PerSolicita", GetType(String))
        dtpivot.Columns.Add("TgAreaDes", GetType(String))
        dtpivot.Columns.Add("PecFecha", GetType(Date))
        dtpivot.Columns.Add("pecDetCanTotal", GetType(Decimal))
        dtpivot.Columns.Add("TgUm", GetType(String))
        dtpivot.Columns.Add("ArtDescripcion", GetType(String))
        dtpivot.Columns.Add("pecDescripcion", GetType(String))
        dtpivot.Columns.Add("pecDetPrecioUnit", GetType(Decimal))
        dtpivot.Columns.Add("TgCuentaDebeId", GetType(String))
        dtpivot.Columns.Add("TgCuentaHaberId", GetType(String))
        dtpivot.Columns.Add("PecSubTotal", GetType(Decimal))
        dtpivot.Columns.Add("cerNro", GetType(String))
    End Sub
#End Region

    Private Sub frmRptPivotSalidaArticuloAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableSalidaArticuloAlmacenDetalle()
        dtpFechaInicio.EditValue = DateTime.Now
        dtpFechaFin.EditValue = DateTime.Now
    End Sub

    Private Sub btnmostrarxfecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrarxfecha.Click
        dtpivot.Rows.Clear()
        pgcSalidaProductodetalle.DataSource = Nothing
        Dim ListaSalidaArticuloAlmacenDetalle As List(Of EEPecosa) = ReportesBL.Instancia.ReportePivotearPecosaXFecha(dtpFechaInicio.EditValue, dtpFechaFin.EditValue)
        If ListaSalidaArticuloAlmacenDetalle IsNot Nothing Then
            For Each loreporte As EEPecosa In ListaSalidaArticuloAlmacenDetalle
                If loreporte.pecAnulado Then
                    dtpivot.LoadDataRow(New Object() {loreporte.PecId, _
                                                      loreporte.PecNro, _
                                                      loreporte.OrdNro, _
                                                      "ANULADO", _
                                                      "ANULADO", _
                                                      loreporte.PecFecha, _
                                                      loreporte.PecosaOCDet.CanOrdComDet, _
                                                      loreporte.PecosaDet.TgUm, _
                                                      loreporte.PecosaDet.OArticulo.ArtNombre, _
                                                      loreporte.PecosaDet.OArticulo.ArtDescripcion, _
                                                      loreporte.PecosaOCDet.PrecOrdComDet, _
                                                      loreporte.TgCuentaDebeId, _
                                                      loreporte.TgCuentaHaberId, _
                                                      0, _
                                                      loreporte.cerNro}, True)
                Else
                    dtpivot.LoadDataRow(New Object() {loreporte.PecId, _
                                                      loreporte.PecNro, _
                                                      loreporte.OrdNro, _
                                                      loreporte.PerSolicita, _
                                                      loreporte.TgAreaDes, _
                                                      loreporte.PecFecha, _
                                                      loreporte.PecosaOCDet.CanOrdComDet, _
                                                      loreporte.PecosaDet.TgUm, _
                                                      loreporte.PecosaDet.OArticulo.ArtNombre, _
                                                      loreporte.PecosaDet.OArticulo.ArtDescripcion, _
                                                      loreporte.PecosaOCDet.PrecOrdComDet, _
                                                      loreporte.TgCuentaDebeId, _
                                                      loreporte.TgCuentaHaberId, _
                                                      loreporte.PecosaOCDet.PecSubTotal, _
                                                      loreporte.cerNro}, True)
                End If
            Next
            If dtpivot.Rows.Count > 0 Then
                riprogreso.Minimum = 0
                riprogreso.Maximum = dtpivot.Rows.Count
                beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                beiprogreso.EditValue = 0
                pgcSalidaProductodetalle.DataSource = dtpivot ' dtpivot
                pgcSalidaProductodetalle.BestFit()
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No existen pecosas que consultar entre las fechas seleccionadas")
        End If
    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            pgcSalidaProductodetalle.ExportToXls(sfdexportar.FileName)
        End If
    End Sub

    Private Sub pgcSalidaProductodetalle_Click(sender As System.Object, e As System.EventArgs) Handles pgcSalidaProductodetalle.Click

    End Sub
End Class