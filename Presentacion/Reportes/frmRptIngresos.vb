Imports Entidades
Imports ReglasNegocio

Public Class frmRptIngresos

    Dim dtpivot As DataTable = New DataTable()
    Dim Registro(17) As Object

#Region "Construir Table"
    Private Sub ConstruirTableRecaudacionDetalle()
        dtpivot.Columns.Add("codPartida", GetType(String))
        dtpivot.Columns.Add("centroProduccion", GetType(String))
        dtpivot.Columns.Add("cuentaCargo", GetType(String))
        dtpivot.Columns.Add("cuentaAbono", GetType(String))
        dtpivot.Columns.Add("cuentaContMPT", GetType(String))
        dtpivot.Columns.Add("cuentaPresMPT", GetType(String))
        dtpivot.Columns.Add("ingresoMuni", GetType(Decimal))
        dtpivot.Columns.Add("fechaLiquidacion", GetType(String))
        dtpivot.Columns.Add("montoPagado", GetType(Decimal))
        dtpivot.Columns.Add("porcentajeSAIMT", GetType(Decimal))
        dtpivot.Columns.Add("ingresoSAIMT", GetType(Decimal))
        dtpivot.Columns.Add("grupoIngresos", GetType(String))
        dtpivot.Columns.Add("año", GetType(String))
        dtpivot.Columns.Add("idMes", GetType(String))
        dtpivot.Columns.Add("mes", GetType(String))
        dtpivot.Columns.Add("fechaDeposito", GetType(String))
        dtpivot.Columns.Add("codConcepto", GetType(String))
        dtpivot.Columns.Add("concepto", GetType(String))
    End Sub
#End Region

    Private Sub frmRptIngresos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.cmbaños.Properties.Items.Add("Todos los Años")
        For Each loRecaudacionAños As EERecaudacion In MantenimientosBL.Instancia.ListarAñosRec()
            Me.cmbaños.Properties.Items.Add(loRecaudacionAños.RecAño)
        Next
        Me.cmbaños.SelectedItem = Me.cmbaños.Properties.Items(1)
        ConstruirTableRecaudacionDetalle()
        dtpFechaRecaudacion.EditValue = DateTime.Now
    End Sub

    Private Sub btnmostrarxaño_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrarxaño.Click
        Dim ListaRecaudacionDetalle As List(Of EEReportesGeneral) = Nothing
        dtpivot.Rows.Clear()
        pgcrecaudaciondetalle.DataSource = Nothing
        If cmbaños.SelectedIndex = 0 Then
            ListaRecaudacionDetalle = ReportesBL.Instancia.ListarRecaudacionDetalleXAñoXFechaDeposito(0, dtpFechaRecaudacion.EditValue, 0)
        Else
            ListaRecaudacionDetalle = ReportesBL.Instancia.ListarRecaudacionDetalleXAñoXFechaDeposito(cmbaños.EditValue, dtpFechaRecaudacion.EditValue, 0)
        End If
        If ListaRecaudacionDetalle IsNot Nothing Then
            riprogreso.Minimum = 0
            riprogreso.Maximum = ListaRecaudacionDetalle.Count
            beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            For Each fRecaudacionDetalle As EEReportesGeneral In ListaRecaudacionDetalle
                Registro(0) = fRecaudacionDetalle.PartId
                Registro(1) = fRecaudacionDetalle.CentroProduccion
                Registro(2) = fRecaudacionDetalle.CuentaCargo
                Registro(3) = fRecaudacionDetalle.CuentaAbono
                Registro(4) = fRecaudacionDetalle.ConCodConMPT
                Registro(5) = fRecaudacionDetalle.ConCodPresMPT
                Registro(6) = fRecaudacionDetalle.IngresoMuni
                Registro(7) = fRecaudacionDetalle.RecDFechaLiquidacion
                Registro(8) = fRecaudacionDetalle.RecDMonto
                Registro(9) = fRecaudacionDetalle.ConPorcentaje
                Registro(10) = fRecaudacionDetalle.IngresoSAIMT
                Registro(11) = fRecaudacionDetalle.Grupo
                Registro(12) = fRecaudacionDetalle.Año
                Registro(13) = fRecaudacionDetalle.IdMes
                Registro(14) = fRecaudacionDetalle.Mes
                Registro(15) = fRecaudacionDetalle.RecFecPago
                Registro(16) = fRecaudacionDetalle.ConId
                Registro(17) = fRecaudacionDetalle.ConNombre
                dtpivot.Rows.Add(Registro)
            Next
            beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            beiprogreso.EditValue = 0
            pgcrecaudaciondetalle.DataSource = dtpivot
            pgcrecaudaciondetalle.BestFit()
        End If
    End Sub

    Private Sub btnmostrarxfecha_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrarxfecha.Click
        dtpivot.Rows.Clear()
        pgcrecaudaciondetalle.DataSource = Nothing
        Dim ListaRecaudacionDetalle As List(Of EEReportesGeneral) = Nothing
        If cmbaños.SelectedIndex = 0 Then
            ListaRecaudacionDetalle = ReportesBL.Instancia.ListarRecaudacionDetalleXAñoXFechaDeposito(0, dtpFechaRecaudacion.EditValue, 1)
        Else
            ListaRecaudacionDetalle = ReportesBL.Instancia.ListarRecaudacionDetalleXAñoXFechaDeposito(cmbaños.EditValue, dtpFechaRecaudacion.EditValue, 1)
        End If
        If ListaRecaudacionDetalle IsNot Nothing Then
            riprogreso.Minimum = 0
            riprogreso.Maximum = ListaRecaudacionDetalle.Count
            beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            For Each fRecaudacionDetalle As EEReportesGeneral In ListaRecaudacionDetalle
                Registro(0) = fRecaudacionDetalle.PartId
                Registro(1) = fRecaudacionDetalle.CentroProduccion
                Registro(2) = fRecaudacionDetalle.CuentaCargo
                Registro(3) = fRecaudacionDetalle.CuentaAbono
                Registro(4) = fRecaudacionDetalle.ConCodConMPT
                Registro(5) = fRecaudacionDetalle.ConCodPresMPT
                Registro(6) = fRecaudacionDetalle.IngresoMuni
                Registro(7) = fRecaudacionDetalle.RecDFechaLiquidacion
                Registro(8) = fRecaudacionDetalle.RecDMonto
                Registro(9) = fRecaudacionDetalle.ConPorcentaje
                Registro(10) = fRecaudacionDetalle.IngresoSAIMT
                Registro(11) = fRecaudacionDetalle.Grupo
                Registro(12) = fRecaudacionDetalle.Año
                Registro(13) = fRecaudacionDetalle.IdMes
                Registro(14) = fRecaudacionDetalle.Mes
                Registro(15) = fRecaudacionDetalle.RecFecPago
                Registro(16) = fRecaudacionDetalle.ConId
                Registro(17) = fRecaudacionDetalle.ConNombre
                dtpivot.Rows.Add(Registro)
            Next
            beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            beiprogreso.EditValue = 0
            pgcrecaudaciondetalle.DataSource = dtpivot
            pgcrecaudaciondetalle.BestFit()
        End If
    End Sub

    Private Sub btnexportar_Click(sender As System.Object, e As System.EventArgs) Handles btnexportar.Click
        sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            pgcrecaudaciondetalle.ExportToXls(sfdexportar.FileName)
        End If
    End Sub
End Class