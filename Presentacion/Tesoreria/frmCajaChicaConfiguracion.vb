Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports DevExpress.XtraEditors.Repository

Public Class frmCajaChicaConfiguracion
    Inherits frmMantenimientos
    Dim xl As Excel.Application
    Dim dtListado As DataTable = New DataTable()
    Dim TgAñoId As String

#Region "Construir Table"
    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("CcConfId", GetType(String))
        dtListado.Columns.Add("ccConfAnio", GetType(String))
        dtListado.Columns.Add("TgAreaId", GetType(String))
        dtListado.Columns.Add("CcConfMinPorCierre", GetType(String))
        dtListado.Columns.Add("CcConfMaxCajasxAnio", GetType(String))
        dtListado.Columns.Add("CcConfMaxFondoTotal", GetType(String))
        dtListado.Columns.Add("CcConfActivo", GetType(String))
        dtListado.Columns.Add("CcConfInicioNroDoc", GetType(String))
        dtListado.Columns.Add("CcConfInicioSerieDoc", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvListado.DataRowCount <> 0 Then

                GIndiceSeleccionado = Me.gvListado.GetSelectedRows(0)
                txtccConfId.Text = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "CcConfId").ToString()
                cboTgAñoId.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "ccConfAnio").ToString()
                cboTgAreaId.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "TgAreaId").ToString()
                'txtccConfNCajasInTime.Text = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "CcConfNCajasInTime").ToString()
                txtccConfMaxCajasxAnio.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "CcConfMaxCajasxAnio").ToString()
                txtccConfMaxFondoTotal.Text = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "CcConfMaxFondoTotal").ToString()
                chkActivar.Checked = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "CcConfActivo").ToString()
                '  TxtccConfInicioNro.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "CcConfInicioNroDoc").ToString()
                '   TxtccConfInicioSerieDoc.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "CcConfInicioSerieDoc").ToString()
                TgAñoId = cboTgAñoId.EditValue
            End If
            MyBase.seleccionarListado()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            If String.IsNullOrEmpty(txtccConfId.EditValue) Then
                txtccConfId.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro codigo de configuración")
                Return
            End If
            If String.IsNullOrEmpty(cboTgAreaId.EditValue) Then
                cboTgAreaId.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el area")
                Return
            End If
            'If String.IsNullOrEmpty(txtccConfNCajasInTime.Text) > 0 Then
            '    txtccConfNCajasInTime.Focus()
            '    SaimtMessageBox.mostrarAlertaAdvertencia("El número de cajas al mismo tiempo debe ser mayor a cero")
            '    Return
            'End If
            If String.IsNullOrEmpty(txtccConfMaxCajasxAnio.Text) > 0 Then
                txtccConfMaxCajasxAnio.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("El número de cajas por año debe ser mayor a cero")
                Return
            End If
            If String.IsNullOrEmpty(txtccConfMaxFondoTotal.Text) > "0.00" Then
                txtccConfMaxFondoTotal.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("El monto total por caja debe ser mayor a cero")
                Return
            End If

            Dim loCajaChicaConfig As EECajaChica.EECajaChicaConfiguracion = New EECajaChica.EECajaChicaConfiguracion()
            loCajaChicaConfig.CcConfId = txtccConfId.Text + cboTgAñoId.Text
            loCajaChicaConfig.TgAreaId = cboTgAreaId.EditValue
            'loCajaChicaConfig.CcConfNCajasInTime = txtccConfNCajasInTime.EditValue
            loCajaChicaConfig.CcConfMaxCajasxAnio = txtccConfMaxCajasxAnio.Text
            loCajaChicaConfig.CcConfMaxFondoTotal = txtccConfMaxFondoTotal.Text
            loCajaChicaConfig.CcConfActivo = chkActivar.Checked
            loCajaChicaConfig.ccConfMinPorCierre = txtccConfMinPorCierre.Value
            ' loCajaChicaConfig.ccConfInicioNroDoc = TxtccConfInicioNro.EditValue
            ' loCajaChicaConfig.ccConfInicioSerieDoc = TxtccConfInicioSerieDoc.EditValue

            If GEstadoNuevo Then
                Dim loCajaConf As EECajaChica.EECajaChicaConfiguracion = MantenimientosBL.Instancia.cajaChicaConfigListarxTgAreaId_TgAnioId(cboTgAreaId.EditValue, cboTgAñoId.EditValue)
                If loCajaConf Is Nothing Then
                    MantenimientosBL.Instancia.cajaChicaConfigGuardar(loCajaChicaConfig)
                Else
                    SaimtMessageBox.mostrarAlertaInformativa(String.Format("Ya se cuenta con una configuración para el area de {0} para el año {1}", cboTgAreaId.Text, cboTgAñoId.EditValue))
                    Return
                End If
            Else
                MantenimientosBL.Instancia.cajaChicaConfigActualizar(loCajaChicaConfig)
            End If
            enabledGA = False
            MyBase.guardar()
            cboCriterioAño.Properties.ReadOnly = False
            cboCriterioArea.Properties.ReadOnly = False
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtccConfId.EditValue = MantenimientosBL.Instancia.cajaChicaConfigGenerarCodigoxtgAnioId(cboTgAñoId.EditValue)
        txtccConfId.Properties.ReadOnly = True
        txtccConfMinPorCierre.Text = "80"
        txtccConfMaxCajasxAnio.Text = "0"
        txtccConfMaxFondoTotal.Text = "0.00"
        cboTgAreaId.EditValue = Nothing
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        txtccConfId.Properties.ReadOnly = True
        cboTgAñoId.Properties.ReadOnly = True
        cboTgAreaId.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub Buscar()
        Try

            Dim loCajaChicaConfig As EECajaChica.EECajaChicaConfiguracion = MantenimientosBL.Instancia.cajaChicaConfigListarxTgAreaId_TgAnioId(cboCriterioArea.EditValue, cboCriterioAño.EditValue)
            dtListado.Clear()
            If loCajaChicaConfig IsNot Nothing Then
                dtListado.LoadDataRow(New Object() {loCajaChicaConfig.CcConfId, _
                                                        loCajaChicaConfig.CcConfAnio, _
                                                        loCajaChicaConfig.TgAreaId, _
                                                        loCajaChicaConfig.ccConfMinPorCierre, _
                                                        loCajaChicaConfig.CcConfMaxCajasxAnio, _
                                                        loCajaChicaConfig.CcConfMaxFondoTotal, _
                                                        loCajaChicaConfig.CcConfActivo, _
                                                        loCajaChicaConfig.ccConfInicioNroDoc, _
                                                        loCajaChicaConfig.ccConfInicioSerieDoc}, True)

                gvListado.BestFitColumns()
                gvListado.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
            cboCriterioAño.Properties.ReadOnly = False
            cboCriterioArea.Properties.ReadOnly = False
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub frmCajaChicaConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PuedeBuscar = True
        PuedeCrear = True
        PuedeEditar = True
        PuedeEliminar = True
        PuedeImprimir = True
        cboCriterioAño.Properties.ReadOnly = False
        cboCriterioArea.Properties.ReadOnly = False
        ConstruirTableListado()
        dgvCajaChicaConfiguracion.DataSource = dtListado
        cboTgAñoId.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTgAñoId.Properties.DisplayMember = "TgNombre"
        cboTgAñoId.Properties.ValueMember = "TgCodigo"
        cboTgAñoId.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)
        cboTgAreaId.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTgAreaId.Properties.DisplayMember = "TgNombre"
        cboTgAreaId.Properties.ValueMember = "TgCodigo"
        cboTgAreaId.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, "0001")
        cboCriterioAño.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCriterioAño.Properties.DisplayMember = "TgNombre"
        cboCriterioAño.Properties.ValueMember = "TgCodigo"
        cboCriterioAño.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)
        cboCriterioAño.ItemIndex = 0
        cboCriterioArea.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgArea", "Area")})
    End Sub

    Private Sub cboTgAñoId_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTgAñoId.EditValueChanged
        If GEstadoNuevo Then
            txtccConfId.EditValue = MantenimientosBL.Instancia.cajaChicaConfigGenerarCodigoxtgAnioId(cboTgAñoId.EditValue)
            'ElseIf GEstadoNuevo Then
            '    If TgAñoId <> cboTgAñoId.EditValue Then
            '        txtccConfId.EditValue = MantenimientosBL.Instancia.cajaChicaConfigGenerarCodigoxtgAnioId(cboTgAñoId.EditValue)
            '    End If
        End If
    End Sub
    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton1.Click
        Buscar()
    End Sub
    Private Sub cboCriterioAño_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriterioAño.EditValueChanged
        If cboCriterioAño.EditValue IsNot Nothing Then
            cboCriterioArea.Properties.DisplayMember = "TgArea"
            cboCriterioArea.Properties.ValueMember = "TgAreaId"
            cboCriterioArea.Properties.DataSource = MantenimientosBL.Instancia.cajaChicaConfigListarAreasxTgAnioId(cboCriterioAño.EditValue)
        End If
    End Sub
End Class