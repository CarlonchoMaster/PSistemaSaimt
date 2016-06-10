Imports Entidades
Imports ReglasNegocio

Public Class frmRptPivotResumenOrdenesServicio
    Dim dtpivot As DataTable = New DataTable()
    Dim Registro(12) As Object

#Region "Construir Table"
    Private Sub ConstruirTableOrdenServicioDetalle()
        'Ordenes de Servicio
        dtpivot.Columns.Add("Item", GetType(Integer))
        dtpivot.Columns.Add("OrdDia", GetType(Date))
        dtpivot.Columns.Add("OrdNro", GetType(String))
        dtpivot.Columns.Add("PerProvNDoc", GetType(String))
        dtpivot.Columns.Add("OrdNroCompPago", GetType(String))
        dtpivot.Columns.Add("PerProv", GetType(String))
        dtpivot.Columns.Add("OrdenServicioDet.OrdDetDescripcion", GetType(String))
        dtpivot.Columns.Add("PartId", GetType(String))
        dtpivot.Columns.Add("OrdImporte", GetType(Decimal))
        dtpivot.Columns.Add("OrdImporteIGV", GetType(Decimal))
        dtpivot.Columns.Add("OrdTotal", GetType(Decimal))
        dtpivot.Columns.Add("OrdNetoPagado", GetType(Decimal))
    End Sub
#End Region

    Private Sub frmRptPivotOrdenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableOrdenServicioDetalle()
        dtpFechaInicio.EditValue = DateTime.Now
        dtpFechaFin.EditValue = DateTime.Now
    End Sub

    Private Sub btnmostrarxfecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrarxfecha.Click
        dtpivot.Rows.Clear()
        pgcordenesdetalle.DataSource = Nothing
        Dim ListaOrdenServicioDetalle As List(Of EEOrdenServicio) = ReportesBL.Instancia.ReportePivotearResumenOrdenServicioXFecha(dtpFechaInicio.EditValue, dtpFechaFin.EditValue)

        If ListaOrdenServicioDetalle IsNot Nothing Then
            riprogreso.Minimum = 0
            riprogreso.Maximum = ListaOrdenServicioDetalle.Count
            beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            beiprogreso.EditValue = 0
            pgcordenesdetalle.DataSource = ListaOrdenServicioDetalle 'dtpivot
            pgcordenesdetalle.BestFit()
        End If
    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            pgcordenesdetalle.ExportToXls(sfdexportar.FileName)
        End If
    End Sub
End Class