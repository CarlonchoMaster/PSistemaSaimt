Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Public Class frmPivotearCajaChica
    Dim dtReporte As DataTable = New DataTable
    Dim listaReporte As List(Of EEReportesGeneral)
    Dim contprogreso As Integer = 0
    Private Sub ContruirTabla()
        dtReporte.Columns.Add("NroCaja", GetType(String))
        dtReporte.Columns.Add("CajaDep", GetType(String))
        dtReporte.Columns.Add("cajDetFechaMov", GetType(Date))
        dtReporte.Columns.Add("TipoDoc", GetType(String))
        dtReporte.Columns.Add("cajDetDocSerie", GetType(String))
        dtReporte.Columns.Add("cajDetDocNro", GetType(String))
        dtReporte.Columns.Add("NombresCompletos", GetType(String))
        dtReporte.Columns.Add("perNDoc", GetType(String))
        dtReporte.Columns.Add("cajDetDescripcion", GetType(String))
        dtReporte.Columns.Add("Grupo", GetType(String))
        dtReporte.Columns.Add("AreaSol", GetType(String))
        dtReporte.Columns.Add("partId", GetType(String))
        dtReporte.Columns.Add("cajDetImporte", GetType(Decimal))
    End Sub

    Private Sub btnexportar_Click(sender As System.Object, e As System.EventArgs) Handles btnexportar.Click
        sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            gcCajas.ExportToXls(sfdexportar.FileName)
        End If
    End Sub

    Private Sub frmPivotearCajaChica_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboCriterioAño.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCriterioAño.Properties.DisplayMember = "TgNombre"
        cboCriterioAño.Properties.ValueMember = "TgCodigo"
        cboCriterioAño.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)
        cboCriterioAño.ItemIndex = 0
        ContruirTabla()
    End Sub

    Private Sub btnMostrarDatos_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrarDatos.Click
        Try
            beiProgreso.Caption = "Cargando Datos..."
            contprogreso = 0
            Me.beiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            btnMostrarDatos.Enabled = False
            Me.riprogreso.Minimum = 0
            listaReporte = MantenimientosBL.Instancia.PivotearCajaChica(cboCriterioAño.EditValue)
            Me.riprogreso.Maximum = listaReporte.Count
            For Each fReporte As EEReportesGeneral In listaReporte
                dtReporte.LoadDataRow(New Object() {fReporte.NroCaja, _
                fReporte.CajaDependencia, _
                fReporte.FechaPago, _
                fReporte.TipoDoc, _
                fReporte.Serie, _
                fReporte.NroComprobante, _
                fReporte.Persona, _
                fReporte.NroDoc, _
                fReporte.Descripcion, _
                fReporte.Grupo, _
                fReporte.AreaSolicitante, _
                fReporte.PartId, _
                fReporte.Monto
                   }, True)
                Application.DoEvents()
                contprogreso = contprogreso + 1
                beiProgreso.EditValue = contprogreso
                beiProgreso.Caption = "Cargando Datos...(" & Format(contprogreso / Me.riprogreso.Maximum, "0%") & ")"
            Next
            gcCajas.DataSource = dtReporte
            gcCajas.RefreshData()
            gcCajas.BestFit()
            Me.beiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnMostrarDatos.Enabled = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
End Class