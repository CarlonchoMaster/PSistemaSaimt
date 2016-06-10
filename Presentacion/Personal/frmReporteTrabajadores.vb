Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Public Class frmReporteTrabajadores

    Dim dT_Trabajador As DataTable = New DataTable()
#Region "Construir Table Trabajador"
    Private Sub NewTable_Trabajador()
        dT_Trabajador.Columns.Add("tgTipoDoc", GetType(String))
        dT_Trabajador.Columns.Add("perNDoc", GetType(String))
        dT_Trabajador.Columns.Add("Persona", GetType(String))
        dT_Trabajador.Columns.Add("tgGenero", GetType(String))
        dT_Trabajador.Columns.Add("perFechaNac", GetType(DateTime))
        dT_Trabajador.Columns.Add("conTrabFecFin", GetType(DateTime))
        dT_Trabajador.Columns.Add("conTrabFecInicio", GetType(DateTime))
        dT_Trabajador.Columns.Add("Sucursal", GetType(String))
        dT_Trabajador.Columns.Add("PerDistrito", GetType(String))
        dT_Trabajador.Columns.Add("PerProvincia", GetType(String))
        dT_Trabajador.Columns.Add("PerDepartamento", GetType(String))
        dT_Trabajador.Columns.Add("tgNivEdu", GetType(String))
        dT_Trabajador.Columns.Add("tgForProf", GetType(String))
        dT_Trabajador.Columns.Add("tgGradoOcu", GetType(String))
        dT_Trabajador.Columns.Add("tgNivRemn", GetType(String))
        dT_Trabajador.Columns.Add("tgTipoCon", GetType(String))
        dT_Trabajador.Columns.Add("conTrabMonto", GetType(String))
        dT_Trabajador.Columns.Add("perDireccion", GetType(String))
        dT_Trabajador.Columns.Add("perRuc", GetType(String))
        dT_Trabajador.Columns.Add("tgBanco", GetType(String))
        dT_Trabajador.Columns.Add("tgAFP", GetType(String))
        dT_Trabajador.Columns.Add("ConTrabNroCuenta", GetType(String))

    End Sub
#End Region
    Private Sub frmReporteTrabajadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NewTable_Trabajador()

    End Sub

    Private Sub btnMostrarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarDatos.Click
        Try
            Me.btnMostrarDatos.Enabled = False
            Dim ListaReporte As List(Of EEContratoPersonal) = ReportesBL.Instancia.ReportePivotearTrabajador()
            pgcTrabajador.DataSource = Nothing
            'Me.riprogreso.Maximum = ListaReporte.Count
            'Me.riprogreso.Minimum = 0
            Me.beiprogreso.EditValue = 0
            Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.beiprogreso.Caption = "Cargando datos para Reporte..."
            dT_Trabajador.Rows.Clear()
            For Each fReporte As EEContratoPersonal In ListaReporte
                dT_Trabajador.LoadDataRow(New Object() {fReporte.OPersona.TgTipoDoc, _
                        fReporte.OPersona.PerNDoc, _
                        fReporte.OPersona.PerNombreCompleto, _
                        fReporte.OPersona.TgGenero, _
                        fReporte.OPersona.PerFechaNac, _
                        fReporte.ConTrabFecFin, _
                        fReporte.ConTrabFecInicio, _
                        fReporte.Sucursal, _
                        fReporte.OPersona.PerDistrito, _
                        fReporte.OPersona.PerProvincia, _
                        fReporte.OPersona.PerDepartamento, _
                        fReporte.tgNivEdu, _
                        fReporte.tgForProf, _
                        fReporte.tgGradoOcu, _
                        fReporte.tgNivRemn, _
                        fReporte.tgTipoCon, _
                        fReporte.ConTrabMonto, _
                        fReporte.OPersona.PerDireccion, _
                        fReporte.OPersona.PerRuc, _
                        fReporte.tgBanco, _
                        fReporte.tgAFP, _
                        fReporte.ConTrabNroCuenta}, True)
                Application.DoEvents()
                Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                '    Me.beiprogreso.Caption = String.Format("Cargando reporte...({0}) ", Format(Me.beiprogreso.EditValue / Me.riprogreso.Maximum, "0%"))
            Next
            Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            pgcTrabajador.DataSource = dT_Trabajador
            pgcTrabajador.BestFit()
            Me.btnMostrarDatos.Enabled = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarExcel.Click

    End Sub
End Class