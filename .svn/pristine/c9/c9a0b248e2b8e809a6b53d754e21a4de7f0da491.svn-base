Imports ReglasNegocio
Imports SaimtControles
Imports Entidades

Public Class frmCajaChica
    Inherits frmMantenimientos
    Dim dtListado As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("CajId", GetType(String))
        dtListado.Columns.Add("CajFondoRetiro", GetType(Decimal))
        dtListado.Columns.Add("CajFondoAnterior", GetType(Decimal))
        dtListado.Columns.Add("CajFondoTotal", GetType(Decimal))
        dtListado.Columns.Add("TgEstadoId", GetType(String))
        dtListado.Columns.Add("TgEstado", GetType(String))
        dtListado.Columns.Add("CajFechaInicio", GetType(Date))
        dtListado.Columns.Add("CajFechaFin", GetType(Date))
        dtListado.Columns.Add("CajNro", GetType(String))
        dtListado.Columns.Add("CajAnio", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvListadoCajaChica.DataRowCount <> 0 Then
                GIndiceSeleccionado = gvListadoCajaChica.GetSelectedRows(0)
                txtCajaChicaId.Text = gvListadoCajaChica.GetRowCellValue(GIndiceSeleccionado, "CajId").ToString
                txtNroCaja.Text = gvListadoCajaChica.GetRowCellValue(GIndiceSeleccionado, "CajNro").ToString
                cboAnio.EditValue = gvListadoCajaChica.GetRowCellValue(GIndiceSeleccionado, "CajAnio").ToString
                cboArea.EditValue = gvListadoCajaChica.GetRowCellValue(GIndiceSeleccionado, "CajId").ToString.Substring(6, 3)
                cboEstado.EditValue = gvListadoCajaChica.GetRowCellValue(GIndiceSeleccionado, "TgEstadoId").ToString
                txtFondoRetiro.Text = gvListadoCajaChica.GetRowCellValue(GIndiceSeleccionado, "CajFondoRetiro").ToString
                txtSaldoAnterior.Text = gvListadoCajaChica.GetRowCellValue(GIndiceSeleccionado, "CajFondoAnterior").ToString
                txtFondoTotal.Text = gvListadoCajaChica.GetRowCellValue(GIndiceSeleccionado, "CajFondoTotal").ToString
                dpFechaInicio.EditValue = gvListadoCajaChica.GetRowCellValue(GIndiceSeleccionado, "CajFechaInicio").ToString
                dpFechaFin.EditValue = gvListadoCajaChica.GetRowCellValue(GIndiceSeleccionado, "CajFechaFin").ToString
                Dim CajMontoUtilizado As Decimal = MantenimientosBL.Instancia.cajaChicaMostrarMontoUtilizadoxCajId(txtCajaChicaId.Text)
                txtSaldoActual.Text = txtFondoTotal.Text - CajMontoUtilizado
            End If
            MyBase.seleccionarListado()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            btncalcular.PerformClick()
            If GEstadoNuevo = False Then
                If String.IsNullOrEmpty(txtCajaChicaId.EditValue) Then
                    txtCajaChicaId.Focus()
                    SaimtMessageBox.mostrarAlertaAdvertencia("Error No Existe el Codigo de Caja Para Actualizar")
                    Return
                End If
            End If
            Dim loCajaConf As EECajaChica.EECajaChicaConfiguracion = MantenimientosBL.Instancia.cajaChicaConfigListarxTgAreaId_TgAnioId(cboArea.EditValue, cboAnio.EditValue)

            If String.IsNullOrEmpty(txtFondoTotal.Text) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No se asigno correctamente el monto total")
                Return
            Else
                If IsNumeric(txtFondoTotal.Text) Then
                    If txtFondoTotal.Text <= 0 Then
                        SaimtMessageBox.mostrarAlertaAdvertencia("No se asigno correctamente el monto total")
                        Return
                    Else

                        If loCajaConf IsNot Nothing Then
                            If txtFondoTotal.Text > loCajaConf.CcConfMaxFondoTotal Then
                                SaimtMessageBox.mostrarAlertaAdvertencia("El Monto Supera lo programado: S/." & loCajaConf.CcConfMaxFondoTotal)
                                Return
                            End If
                        End If
                    End If
                End If
            End If

            Dim loCajaChica As EECajaChica = New EECajaChica
            loCajaChica.CajId = txtCajaChicaId.Text
            loCajaChica.TgEstadoId = cboEstado.EditValue
            loCajaChica.CajFondoTotal = txtFondoTotal.Text
            loCajaChica.CajFondoRetiro = txtFondoRetiro.Text
            loCajaChica.CajFondoAnterior = txtSaldoAnterior.Text
            loCajaChica.CajFondoCierre = txtSaldoActual.Text
            loCajaChica.CajFechaInicio = dpFechaInicio.EditValue
            loCajaChica.CajFechaFin = dpFechaFin.EditValue
            loCajaChica.loCajaChicaConfiguracion = New EECajaChica.EECajaChicaConfiguracion
            loCajaChica.loCajaChicaConfiguracion.CcConfAnio = cboAnio.EditValue
            loCajaChica.loCajaChicaConfiguracion.TgAreaId = cboArea.EditValue
            If GEstadoNuevo Then
                Dim ncajas As Int16 = MantenimientosBL.Instancia.cajaChicaContarCajasXTgAreaId_tgEstadoId(loCajaChica.loCajaChicaConfiguracion.TgAreaId, loCajaChica.TgEstadoId)
                If ncajas >= 1 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia(String.Format("Actualmente se tiene {0} abiertas, Maximo se puede tener {1} ", ncajas, 1))
                    Return
                End If
                MantenimientosBL.Instancia.cajaChicaGuardar(loCajaChica)
            Else
                If cboEstado.EditValue = "02" Then
                    If dpFechaFin.EditValue Is Nothing Then
                        SaimtMessageBox.mostrarAlertaInformativa("Seleccione la fecha de cierre de caja")
                        Return
                    Else
                        If DateDiff(DateInterval.Day, EEComun.FechaServidor.Value.Date, dpFechaFin.EditValue) > 4 Or DateDiff(DateInterval.Day, dpFechaFin.EditValue, EEComun.FechaServidor.Value.Date) < -4 Then
                            SaimtMessageBox.mostrarAlertaInformativa("Seleccione una fecha correcta al cierre")
                            Return
                        End If
                    End If
                Else
                    If dpFechaFin.EditValue IsNot Nothing Then
                        SaimtMessageBox.mostrarAlertaInformativa("La Caja tiene esta Abierta y ha seleccionado fecha de fin")
                        dpFechaFin.EditValue = Nothing
                        Return
                    End If
                End If
                MantenimientosBL.Instancia.cajaChicaActualizar(loCajaChica)
            End If
            enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        cboEstado.EditValue = "01"
        cboEstado.Properties.ReadOnly = True
        txtCajaChicaId.Properties.ReadOnly = True
        txtNroCaja.Properties.ReadOnly = True
        txtSaldoActual.Properties.ReadOnly = True
        txtSaldoAnterior.Properties.ReadOnly = True
        txtFondoTotal.Properties.ReadOnly = True
        dpFechaFin.Properties.ReadOnly = True
        dpFechaFin.EditValue = Nothing
        cboAnio.ItemIndex = -1
        cboAnio.EditValue = Nothing
        cboArea.ItemIndex = -1
        cboArea.EditValue = Nothing
    End Sub

    Protected Overrides Sub editar()
        If cboEstado.EditValue = "02" Then
            SaimtMessageBox.mostrarAlertaInformativa("No se puede Editar, La caja ya se encuentra Cerrada")
        Else
            MyBase.editar()
            cboEstado.EditValue = "01"
            txtCajaChicaId.Properties.ReadOnly = True
            txtNroCaja.Properties.ReadOnly = True
            txtSaldoActual.Properties.ReadOnly = True
            txtSaldoAnterior.Properties.ReadOnly = True
            txtFondoTotal.Properties.ReadOnly = True
            dpFechaInicio.Properties.ReadOnly = True
            txtFondoRetiro.Properties.ReadOnly = True
            cboArea.Properties.ReadOnly = True
            cboAnio.Properties.ReadOnly = True
        End If
    End Sub

    Protected Overrides Sub Buscar()
        Try
            Dim loCajaChica As List(Of EECajaChica) = MantenimientosBL.Instancia.cajaChicaListarxTgAreaId_TgAnioId(cboCriterioArea.EditValue, cboCriterioAño.EditValue)
            dtListado.Clear()
            If loCajaChica IsNot Nothing Then
                For Each frow As EECajaChica In loCajaChica
                    dtListado.LoadDataRow(New Object() {
                                            frow.CajId,
                                            frow.CajFondoRetiro,
                                            frow.CajFondoAnterior,
                                            frow.CajFondoTotal,
                                            frow.TgEstadoId,
                                            frow.TgEstado,
                                            frow.CajFechaInicio,
                                            frow.CajFechaFin,
                                            frow.CajId.Substring(0, 2),
                                            frow.CajId.Substring(2, 4)}, True)
                Next
                gvListadoCajaChica.BestFitColumns()
                gvListadoCajaChica.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub frmCajaChica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboAnio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAnio.Properties.DisplayMember = "TgNombre"
        cboAnio.Properties.ValueMember = "TgCodigo"
        cboAnio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)
        cboAnio.ItemIndex = -1

        cboEstado.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstado.Properties.DisplayMember = "TgNombre"
        cboEstado.Properties.ValueMember = "TgCodigo"
        cboEstado.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(185)
        cboEstado.ItemIndex = -1

        cboCriterioAño.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCriterioAño.Properties.DisplayMember = "TgNombre"
        cboCriterioAño.Properties.ValueMember = "TgCodigo"
        cboCriterioAño.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)
        cboCriterioAño.ItemIndex = 0

        cboArea.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgArea", "Area")})
        cboCriterioArea.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgArea", "Area")})
        PuedeBuscar = True
        PuedeCrear = True
        PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        ConstruirTableListado()
        dgvListadoCajaChica.DataSource = dtListado
        'dpFechaFin.Properties.MinValue = DateAdd(DateInterval.Day, -4, EEComun.FechaServidor.Value)
        'dpFechaFin.Properties.MaxValue = DateAdd(DateInterval.Day, 4, EEComun.FechaServidor.Value)
    End Sub

    Private Sub txtFondoRetiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFondoRetiro.EditValueChanged
        If GEstadoNuevo = True Then
            txtFondoTotal.Text = CDbl(txtFondoRetiro.Text) + CDbl(txtSaldoAnterior.Text)
        End If
    End Sub

    Private Sub cboAnio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.EditValueChanged
        If cboArea.Properties.DataSource Is Nothing Then
            cboArea.Properties.DisplayMember = "TgArea"
            cboArea.Properties.ValueMember = "TgAreaId"
            cboArea.Properties.DataSource = MantenimientosBL.Instancia.cajaChicaConfigListarAreasxTgAnioId(cboAnio.EditValue)
            cboArea.ItemIndex = -1
        End If
        If GEstadoNuevo = True Then
            If cboArea.EditValue IsNot Nothing And cboAnio.EditValue IsNot Nothing Then
                txtSaldoAnterior.Text = MantenimientosBL.Instancia.cajaChicaMostrarAnteriorFondoCierrexTgAreaId_TgAnioId(cboArea.EditValue, cboAnio.EditValue)
            End If
        End If

    End Sub

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub cboArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.EditValueChanged
        If GEstadoNuevo = True Then
            If cboArea.EditValue IsNot Nothing And cboAnio.EditValue IsNot Nothing Then
                txtSaldoAnterior.Text = MantenimientosBL.Instancia.cajaChicaMostrarAnteriorFondoCierrexTgAreaId_TgAnioId(cboArea.EditValue, cboAnio.EditValue)
            End If
        End If
    End Sub

    Private Sub cboCriterioAño_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriterioAño.EditValueChanged
        If cboCriterioAño.EditValue IsNot Nothing Then
            cboCriterioArea.Properties.DisplayMember = "TgArea"
            cboCriterioArea.Properties.ValueMember = "TgAreaId"
            cboCriterioArea.Properties.DataSource = MantenimientosBL.Instancia.cajaChicaConfigListarAreasxTgAnioId(cboCriterioAño.EditValue)
            cboCriterioArea.ItemIndex = 0
        End If
    End Sub

    Private Sub cboEstado_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstado.EditValueChanged
        If cboEstado.EditValue = "02" Then
            dpFechaFin.Properties.ReadOnly = False
        Else
            dpFechaFin.EditValue = Nothing
            dpFechaFin.Text = Nothing
            dpFechaFin.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub btncalcular_Click(sender As System.Object, e As System.EventArgs) Handles btncalcular.Click
        txtFondoTotal.Text = CDec(txtFondoRetiro.Text.Trim) + CDec(txtSaldoAnterior.Text.Trim)
    End Sub
End Class