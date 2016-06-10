Imports Entidades
Imports ReglasNegocio
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Public Class frmRptPivotOrdenesCompra
    Dim dtpivot As DataTable = New DataTable()
    Dim Registro(27) As Object
    Dim xl As Excel.Application

#Region "Construir Table"
    Private Sub ConstruirTableOrdenServicioDetalle()
        'Ordenes de Servicio
        dtpivot.Columns.Add("OrdId", GetType(String))
        dtpivot.Columns.Add("OrdNro", GetType(String))
        dtpivot.Columns.Add("OrdFechaDoc", GetType(Date))
        dtpivot.Columns.Add("TgEstado", GetType(String))
        dtpivot.Columns.Add("OrdNroCompPago", GetType(String))
        dtpivot.Columns.Add("PerProv", GetType(String))
        dtpivot.Columns.Add("PerProvNDoc", GetType(String))
        dtpivot.Columns.Add("OrdRefCert", GetType(String))
        dtpivot.Columns.Add("OrdRefDoc", GetType(String))
        dtpivot.Columns.Add("TgCuentaDebeId", GetType(String))
        dtpivot.Columns.Add("TgCuentaDebe", GetType(String))
        dtpivot.Columns.Add("TgCuentaHaberId", GetType(String))
        dtpivot.Columns.Add("TgCuentaHaber", GetType(String))
        dtpivot.Columns.Add("PartId", GetType(String))
        dtpivot.Columns.Add("PartNombre", GetType(String))
        dtpivot.Columns.Add("CerId", GetType(String))
        dtpivot.Columns.Add("CerNro", GetType(String))
        dtpivot.Columns.Add("TgFFinancieraId", GetType(String))
        dtpivot.Columns.Add("TgMetaId", GetType(String))
        dtpivot.Columns.Add("TgActProyId", GetType(String))
        dtpivot.Columns.Add("OrdImporte", GetType(Decimal))
        dtpivot.Columns.Add("OrdImporteIGV", GetType(Decimal))
        dtpivot.Columns.Add("OrdTotal", GetType(Decimal))
        'Detalle de Ordenes de Servicio
        dtpivot.Columns.Add("OrdenCompraDet.OrdDetId", GetType(String))
        dtpivot.Columns.Add("OrdenCompraDet.OArticulo.ArtDescripcion", GetType(String))
        dtpivot.Columns.Add("OrdenCompraDet.TgUm", GetType(String))
        dtpivot.Columns.Add("OrdenCompraDet.OrdDetCantidad", GetType(String))
        dtpivot.Columns.Add("OrdenCompraDet.OrdDetPrecio", GetType(Decimal))
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
        Dim ListaOrdenServicioDetalle As List(Of EEOrdenCompra) = ReportesBL.Instancia.ReportePivotearOrdenCompraXFecha(dtpFechaInicio.EditValue, dtpFechaFin.EditValue)


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

    Private Sub btnExportarOsce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarOsce.Click

        Try
            xl = EEExcel.Instancia
            xl.Workbooks.Open(EEComun.RutaReportes & "\Registro_OC-OS.xls", 1, True, 4)
            ExportarReporteOsce()
            xl.Application.Visible = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ExportarReporteOsce()
        xl.Sheets(xl.Worksheets("formulario").Index).Select()
        Dim ListaOrdenes As List(Of EEOrdenCompra) = ReportesBL.Instancia.ReporteOsceOrdenCompraServicioXFecha(dtpFechaInicio.EditValue, dtpFechaFin.EditValue)
        Dim Index As String = String.Empty
        Dim fila As Integer = 11
        If ListaOrdenes IsNot Nothing Then
            For Each frow In ListaOrdenes
                Index = "B" & fila
                xl.Range(Index).Value = frow.Idgeneral

                Index = "C" & fila
                xl.Range(Index).Value = frow.OrdNro

                Index = "D" & fila
                xl.Range(Index).Value = frow.TgEstado

                Index = "E" & fila
                xl.Range(Index).Value = frow.PerProvNDoc

                Index = "F" & fila
                xl.Range(Index).Value = frow.OrdFechaDoc

                Index = "G" & fila
                xl.Range(Index).Value = frow.OrdFechaDoc

                Index = "H" & fila
                xl.Range(Index).Value = frow.OrdFechaDoc

                Index = "I" & fila
                xl.Range(Index).Value = String.Empty

                Index = "J" & fila
                xl.Range(Index).Value = frow.tipoContratacion

                Index = "K" & fila
                xl.Range(Index).Value = frow.informacionComplementaria

                Index = "L" & fila
                xl.Range(Index).Value = frow.ObjectoContratacion

                Index = "M" & fila
                xl.Range(Index).Value = frow.Descripcion.Replace("&#x0D;", "")

                Index = "N" & fila
                xl.Range(Index).Value = String.Empty

                Index = "O" & fila
                xl.Range(Index).Value = frow.OrdTotal

                Index = "P" & fila
                xl.Range(Index).Value = frow.tipoMoneda

                Index = "Q" & fila
                xl.Range(Index).Value = frow.tipocambio

                fila = fila + 1
            Next
        End If


    End Sub
End Class