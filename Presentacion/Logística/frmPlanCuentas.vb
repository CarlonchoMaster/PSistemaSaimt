Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmPlanCuentas
    Dim dtListado As DataTable = New DataTable()
    Dim dtPlanCuentas As DataTable = New DataTable()

    'Cargo = Debe
    'Abono = Haber
#Region "Construir Table"
    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("planCId", GetType(String))
        dtListado.Columns.Add("planCDescripcion", GetType(String))
        dtListado.Columns.Add("planCAño", GetType(String))
    End Sub

    Private Sub ConstruirTablePlanCuenta()
        dtPlanCuentas.Columns.Add("planCId", GetType(String))
        dtPlanCuentas.Columns.Add("planCAño", GetType(String))
        dtPlanCuentas.Columns.Add("planCDescripcion", GetType(String))
        dtPlanCuentas.Columns.Add("cargo", GetType(String))
        dtPlanCuentas.Columns.Add("abono", GetType(String))
        dtPlanCuentas.Columns.Add("cuenta", GetType(String))
        dtPlanCuentas.Columns.Add("cuentaAuxiliar", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvListadoPlanCuentas.DataRowCount <> 0 Then
                Dim loPlanCuenta As EEPlanCuenta = MantenimientosBL.Instancia.plancuentaListarXPlanCId_XPlanCAño(gvListadoPlanCuentas.GetRowCellValue(Me.gvListadoPlanCuentas.GetSelectedRows(0), "planCId").ToString(), gvListadoPlanCuentas.GetRowCellValue(Me.gvListadoPlanCuentas.GetSelectedRows(0), "planCAño").ToString())
                GIndiceSeleccionado = Me.gvListadoPlanCuentas.GetSelectedRows(0)
                txtAño.Text = loPlanCuenta.PlanCAño
                txtCuenta.Text = loPlanCuenta.PlanCId
                txtDescripcion.Text = loPlanCuenta.PlanCDescripcion
                cboTipoCuenta.EditValue = loPlanCuenta.TgPlanCTipoCuenta.TgCodigo
                cboTipoAuxiliar.EditValue = loPlanCuenta.TgPlanCTipoAuxiliar.TgCodigo
                txtCuentaAbono.Text = loPlanCuenta.PlanCCtaNombreHaber
                txtCuentaAbono.Tag = loPlanCuenta.PlanCCtaHaber
                txtCuentaCargo.Text = loPlanCuenta.PlanCCtaNombreDebe
                txtCuentaCargo.Tag = loPlanCuenta.PlanCCtaDebe
                GIdRegistroActual = loPlanCuenta.PlanCId & "-" & loPlanCuenta.PlanCAño
            End If
            MyBase.seleccionarListado()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            GValorTextoBuscado = cboAñoPor.Text & txtBuscarPor.Text
            GCriterioBuscado = cboCriterioPor.SelectedIndex
            Dim loPlanCuenta As List(Of EEPlanCuenta) = MantenimientosBL.Instancia.plancuentaListarCriterio(cboCriterioPor.SelectedIndex, GValorTextoBuscado)

            dtListado.Clear()
            If loPlanCuenta IsNot Nothing Then
                For Each frow As EEPlanCuenta In loPlanCuenta
                    dtListado.LoadDataRow(New Object() {frow.PlanCId, _
                        frow.PlanCDescripcion, _
                        frow.PlanCAño
                    }, True)
                Next
                gvListadoPlanCuentas.BestFitColumns()
                gvListadoPlanCuentas.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub


    Protected Overrides Sub listar()
        Try
            Dim loPlanCuenta As List(Of EEPlanCuenta) = MantenimientosBL.Instancia.plancuentaListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            dtListado.Clear()
            If loPlanCuenta IsNot Nothing Then
                For Each frow As EEPlanCuenta In loPlanCuenta
                    dtListado.LoadDataRow(New Object() {frow.PlanCId, _
                        frow.PlanCDescripcion, _
                        frow.PlanCAño
                    }, True)
                Next
                gvListadoPlanCuentas.BestFitColumns()
                gvListadoPlanCuentas.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.listar()
            Me.gvListadoPlanCuentas.FocusedRowHandle = GIndiceSeleccionado
            dgvListado_Click(Nothing, Nothing)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            Dim loPlanCuenta As EEPlanCuenta = New EEPlanCuenta()
            Dim loTablaGeneral As EETablaGeneral = Nothing

            loTablaGeneral = New EETablaGeneral()
            loTablaGeneral.TgCodigo = cboTipoCuenta.EditValue
            loPlanCuenta.TgPlanCTipoCuenta = loTablaGeneral

            loTablaGeneral = New EETablaGeneral()
            loTablaGeneral.TgCodigo = cboTipoAuxiliar.EditValue
            loPlanCuenta.TgPlanCTipoAuxiliar = loTablaGeneral
            loPlanCuenta.PlanCId = txtCuenta.Text
            loPlanCuenta.PlanCAño = txtAño.Text
            loPlanCuenta.PlanCDescripcion = txtDescripcion.Text
            loPlanCuenta.PlanCCtaDebe = txtCuentaCargo.Tag
            loPlanCuenta.PlanCCtaHaber = txtCuentaAbono.Tag

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.plancuentaGuardar(loPlanCuenta)
            Else
                MantenimientosBL.Instancia.plancuentaActualizar(loPlanCuenta)
            End If
            enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtCuentaAbono.Properties.ReadOnly = True
        txtCuentaCargo.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        txtCuentaAbono.Properties.ReadOnly = True
        txtCuentaCargo.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub eliminar()
        Try
            MyBase.eliminar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub frmPlanCuentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        cboTipoCuenta.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoCuenta.Properties.DisplayMember = "TgNombre"
        cboTipoCuenta.Properties.ValueMember = "TgCodigo"
        cboTipoCuenta.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(131)
        cboTipoCuenta.ItemIndex = -1

        cboTipoAuxiliar.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoAuxiliar.Properties.DisplayMember = "TgNombre"
        cboTipoAuxiliar.Properties.ValueMember = "TgCodigo"
        cboTipoAuxiliar.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(132)
        cboTipoAuxiliar.ItemIndex = -1

        ConstruirTableListado()
        ConstruirTablePlanCuenta()
        dgvListadoPlanCuentas.DataSource = dtListado
        dgvVisorPlanCuenta.DataSource = dtPlanCuentas

        Dim ListaAños As List(Of String) = MantenimientosBL.Instancia.plancuentaListarAños()
        For Each fAños As String In ListaAños
            cboAñoPor.Properties.Items.Add(fAños)
        Next
        cboAñoPor.SelectedIndex = 0

        dgvVisorPlanCuenta.Enabled = True
        btnExportarExcelPlanCuentas.Enabled = True
        btnMostrarPlanCuentas.Enabled = True
        cboTipoCuentaCriterio.Properties.ReadOnly = True
    End Sub

    Private Sub gvListadoPlanCuentas_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvListadoPlanCuentas.CustomRowCellEditForEditing
        seleccionarListado()
    End Sub

    Private Sub btnConsultarCuentaCarga_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultarCuentaCarga.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta()
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaCargo.Tag = fmConsulta.PlanCId
                txtCuentaCargo.Text = fmConsulta.PlanCId & " - " & fmConsulta.PlanCDescripcion
            End If
        End Using
    End Sub

    Private Sub btnConsultarCuentaAbona_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultarCuentaAbona.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta()
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaAbono.Tag = fmConsulta.PlanCId
                txtCuentaAbono.Text = fmConsulta.PlanCId & " - " & fmConsulta.PlanCDescripcion
            End If
        End Using
    End Sub

    Private Sub btnMostrarPlanCuentas_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrarPlanCuentas.Click
        Try
            Dim ListaPlanCuenta As List(Of EEPlanCuenta) = MantenimientosBL.Instancia.plancuentaListarXPlanCAño(Convert.ToInt16(cboAñoPor.Text))
            dtPlanCuentas.Clear()
            If ListaPlanCuenta IsNot Nothing Then
                For Each frow As EEPlanCuenta In ListaPlanCuenta
                    dtPlanCuentas.LoadDataRow(New Object() {frow.PlanCId, _
                        frow.PlanCAño, _
                        frow.PlanCDescripcion, _
                        frow.PlanCCtaNombreDebe, _
                        frow.PlanCCtaNombreHaber, _
                        frow.TgPlanCTipoCuenta.TgNombre, _
                        frow.TgPlanCTipoAuxiliar.TgNombre
                    }, True)
                Next
                gvVisorPlanCuenta.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnExportarExcelPlanCuentas_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarExcelPlanCuentas.Click
        sfdRutaExcelPlanCuenta.Filter = "Excel (*.xls)|*.xls"
        If sfdRutaExcelPlanCuenta.ShowDialog() = DialogResult.OK Then
            gvVisorPlanCuenta.ExportToXls(sfdRutaExcelPlanCuenta.FileName)
        End If
    End Sub

    Private Sub cboCriterioPor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCriterioPor.SelectedIndexChanged
        txtBuscarPor.Properties.ReadOnly = True
        GValorTextoBuscado = Nothing

        If cboCriterioPor.SelectedIndex = 2 Then
            cboAñoPor.SelectedIndex = 0
        ElseIf cboCriterioPor.SelectedIndex = 3 Then
            cboTipoCuentaCriterio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoCuentaCriterio.Properties.DisplayMember = "TgNombre"
            cboTipoCuentaCriterio.Properties.ValueMember = "TgCodigo"
            cboTipoCuentaCriterio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(131)
            cboTipoCuentaCriterio.ItemIndex = -1
        ElseIf cboCriterioPor.SelectedIndex = 4 Then
            cboTipoCuentaCriterio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoCuentaCriterio.Properties.DisplayMember = "TgNombre"
            cboTipoCuentaCriterio.Properties.ValueMember = "TgCodigo"
            cboTipoCuentaCriterio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(132)
            cboTipoCuentaCriterio.ItemIndex = -1
        End If

        If cboCriterioPor.SelectedIndex < 2 Then
            txtBuscarPor.Properties.ReadOnly = False
            cboTipoCuentaCriterio.Properties.ReadOnly = True
            cboTipoCuentaCriterio.Properties.DataSource = Nothing
            cboTipoCuentaCriterio.ItemIndex = -1
            GCriterioBuscado = cboCriterioPor.SelectedIndex
            GValorTextoBuscado = cboAñoPor.Text
        ElseIf cboCriterioPor.SelectedIndex > 2 Then
            cboTipoCuentaCriterio.Properties.ReadOnly = False
            GCriterioBuscado = cboCriterioPor.SelectedIndex
            GValorTextoBuscado = cboAñoPor.Text & cboTipoCuentaCriterio.Text
            'listar()
        End If
    End Sub

    Private Sub cboAñoPor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAñoPor.SelectedIndexChanged
        If cboCriterioPor.SelectedIndex = 2 Then
            If cboAñoPor.Text <> "" Then
                GCriterioBuscado = cboCriterioPor.SelectedIndex
                GValorTextoBuscado = cboAñoPor.Text
                listar()
            End If
        End If
    End Sub

    Private Sub cboTipoCuentaCriterio_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoCuentaCriterio.EditValueChanged
        If GValorTextoBuscado IsNot Nothing Then
            GCriterioBuscado = cboCriterioPor.SelectedIndex
            GValorTextoBuscado = cboAñoPor.Text & cboTipoCuentaCriterio.EditValue
            listar()
        End If
    End Sub
End Class