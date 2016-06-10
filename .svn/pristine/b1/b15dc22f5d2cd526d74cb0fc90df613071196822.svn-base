Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports DevExpress.XtraEditors.Repository

Public Class frmComprobantePago
    Inherits frmMantenimientos

    Dim dtDetalleCompPago As DataTable = New DataTable()
    Dim dtListado As DataTable = New DataTable()
    Public Property CBANCO() As String

    Private ListaTemporal_ComprobantePagoDetNuevo As List(Of EEComprobantePago.EEComprobantePagoDet) = New List(Of EEComprobantePago.EEComprobantePagoDet)
    Private ListaTemporal_ComprobantePagoDetElimandos As List(Of String) = New List(Of String)

#Region "Funciones Sobrescritas"

    Protected Overrides Sub Buscar()
        Try
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterio.SelectedIndex
            If GCriterioBuscado = 5 Then
                GValorTextoBuscado = cboBuscarPorEstado.EditValue
            End If
            Dim loOrdenCompra As List(Of EEComprobantePago) = MantenimientosBL.Instancia.ComprobantePagoListarCriterio(GCriterioBuscado, GValorTextoBuscado)

            dtListado.Clear()
            dtDetalleCompPago.Clear()
            If loOrdenCompra IsNot Nothing Then
                For Each frow As EEComprobantePago In loOrdenCompra
                    'dtListado.LoadDataRow(New Object() {frow.OrdId, _
                    'frow.OrdNro, _
                    'frow.OrdFechaDoc, _
                    'frow.TgEstadoId, _
                    'frow.TgCompPagoId, _
                    'frow.OrdNroCompPago, _
                    'frow.PerProvId, _
                    'frow.PerProv, _
                    'frow.OrdRefCert, _
                    'frow.OrdRefDoc, _
                    'frow.TgCuentaDebeId, _
                    'frow.planCDDescripcion, _
                    'frow.TgCuentaDebe, _
                    'frow.TgCuentaHaberId, _
                    'frow.planCHDescripcion, _
                    'frow.TgCuentaHaber, _
                    'frow.PartId, _
                    'frow.PartNombre, _
                    'frow.PartAnio, _
                    'frow.TgFFinancieraId, _
                    'frow.TgMetaId, _
                    'frow.TgActProyId, _
                    'frow.OrdImporte
                    '}, True)
                Next
                gvListadoOrdenCompra.BestFitColumns()
                gvListadoOrdenCompra.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
            cboBuscarPorEstado.Properties.ReadOnly = IIf(cboCriterio.SelectedIndex = 5, False, True)
            'txtCantidad.Properties.ReadOnly = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        dtDetalleCompPago.Clear()
        txtComPagId.EditValue = MantenimientosBL.Instancia.comprobantePagoGeneraCodigo
        txtComPagId.Properties.ReadOnly = True
        txtComPagNro.Properties.ReadOnly = True
        txtProveedor.Properties.ReadOnly = True
        txtResponsable.Properties.ReadOnly = True
        txtResponsable.EditValue = "ANGULO ALCALDE PATRICIA GIANNELLA"
        txtResponsable.Tag = "0000000015"
        txtPartida.Properties.ReadOnly = True
        txtCuentaDebe.Properties.ReadOnly = True
        txtCuentaHaber.Properties.ReadOnly = True
        txtCuentaDebe2.Properties.ReadOnly = True
        txtCuentaHaber2.Properties.ReadOnly = True
        cboEstado.EditValue = "4"
        cboEstado.Properties.ReadOnly = True
        txtTotal.Properties.ReadOnly = True
        txtDeduccion.Properties.ReadOnly = True
        txtLiquidoPagar.Properties.ReadOnly = True

        txtTotal.Text = 0
        txtDeduccion.Text = 0
        txtLiquidoPagar.Text = 0
    End Sub

    Protected Overrides Sub guardar()
        Try
            If String.IsNullOrEmpty(txtComPagNro.EditValue) Then
                txtComPagNro.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro del Comprobante de Pago")
                Return
            End If
            If String.IsNullOrEmpty(txtProveedor.Tag) Then
                txtProveedor.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado al proveedor")
                Return
            End If
            If String.IsNullOrEmpty(txtResponsable.Tag) Then
                txtResponsable.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado el Encargado")
                Return
            End If
            If String.IsNullOrEmpty(cboBanco.EditValue) Then
                cboBanco.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el tipo de Banco")
                Return
            End If

            Dim loComprobantePago As EEComprobantePago = New EEComprobantePago()
            loComprobantePago.ComPagId = txtComPagId.Text
            loComprobantePago.ComPagNro = txtComPagNro.Text
            ''loComprobantePago.ComPagNroOrden = txtNroOrden.Text
            ''loComprobantePago.ComPagFecha = dtpFecha.EditValue
            ''loComprobantePago.TgEstadoId = cboEstado.EditValue
            ''loComprobantePago.PerProvId = txtProveedor.Tag
            ''loComprobantePago.PerRespId = txtResponsable.Tag
            loComprobantePago.TgBancoId = cboBanco.EditValue
            ''loComprobantePago.TgTipoComId = cboTipoComPag.EditValue
            ''loComprobantePago.ComPagCtaCorriente = txtCtaCorriente.Text
            ''loComprobantePago.ComPagConcepto = txtConceptoPago.Text
            ''loComprobantePago.ComPagImpTotal = txtTotal.Text
            ''loComprobantePago.ComPagImpDeduccion = txtDeduccion.Text
            ''loComprobantePago.ComPagImpPagar = txtLiquidoPagar.Text
            'Codificacion Programatica
            ''loComprobantePago.ComPagSector = txtSector.Text
            ''loComprobantePago.ComPagPliego = txtPliego.Text
            ''loComprobantePago.ComPagFuncion = txtFuncion.Text
            ''loComprobantePago.ComPagPrograma = txtPrograma.Text
            ''loComprobantePago.ComPagSubPrograma = txtSubPrograma.Text
            ''loComprobantePago.TgActProyId = cboActProy.EditValue
            ''loComprobantePago.TgMetaId = cboMeta.EditValue
            ''loComprobantePago.TgFFinancieraId = cboFuenteFinanciera.EditValue
            'Contabilidad Presupuestal
            ''loComprobantePago.TgCuentaDebeId = txtCuentaDebe.Tag
            ''loComprobantePago.TgCuentaDebe = Val(txtMontoDebe.EditValue)
            ''loComprobantePago.TgCuentaHaberId = txtCuentaHaber.Tag
            ''loComprobantePago.TgCuentaHaber = Val(txtMontoHaber.EditValue)
            'Contabilidad
            ''loComprobantePago.TgCuentaDebeId = txtCuentaDebe.Tag
            ''loComprobantePago.TgCuentaDebe = Val(txtMontoDebe.EditValue)
            ''loComprobantePago.TgCuentaHaberId = txtCuentaHaber.Tag
            ''loComprobantePago.TgCuentaHaber = Val(txtMontoHaber.EditValue)
            'Estadisticas Objeto del Gasto

            'ListaTemporal_OrdenCompraDetNuevo.Clear()
            'Dim loComprobantePagoDet As EEComprobantePago.EEComprobantePagoDet
            'loComprobantePago.ListaComprobantePagoDet = New List(Of EEComprobantePago.EEComprobantePagoDet)

            'For Each frowDet As DataRow In dtDetalleCompPago.Rows
            '    loComprobantePagoDet = New EEComprobantePago.EEComprobantePagoDet
            '    loComprobantePagoDet.ComDetId = frowDet("comDetId")
            '    loComprobantePagoDet.PartId = frowDet("partId")
            '    loComprobantePagoDet.ComDetImpParcial = frowDet("comDetImpParcial")
            '    loComprobantePagoDet.ComDetImpTotal = frowDet("comDetImpTotal")
            '    loComprobantePagoDet.ComDetImpDeduccion = frowDet("comDetImpDeduccion")
            '    ListaTemporal_ComprobantePagoDetNuevo.Add(loComprobantePagoDet)
            'Next
            'loComprobantePago.ListaComprobantePagoDet = ListaTemporal_ComprobantePagoDetNuevo

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.comprobantePagoGuardar(loComprobantePago)
            Else
                loComprobantePago.Lista_ComprobantePagoDetElimnados = ListaTemporal_ComprobantePagoDetElimandos
                MantenimientosBL.Instancia.comprobantePagoActualizar(loComprobantePago)
            End If
            ListaTemporal_ComprobantePagoDetNuevo.Clear()
            ListaTemporal_ComprobantePagoDetElimandos.Clear()
            dtDetalleCompPago.Clear()
            enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub frmComprobantePago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        cboTipoDoc.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoDoc.Properties.DisplayMember = "TgNombre"
        cboTipoDoc.Properties.ValueMember = "TgCodigo"
        cboTipoDoc.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(181)
        cboTipoDoc.ItemIndex = -1

        cboEstado.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstado.Properties.DisplayMember = "TgNombre"
        cboEstado.Properties.ValueMember = "TgCodigo"
        cboEstado.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(128)
        cboEstado.ItemIndex = -1

        cboBanco.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboBanco.Properties.DisplayMember = "TgNombre"
        cboBanco.Properties.ValueMember = "TgCodigo"
        cboBanco.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(121)
        cboBanco.ItemIndex = -1

        cboTipoComPag.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoComPag.Properties.DisplayMember = "TgNombre"
        cboTipoComPag.Properties.ValueMember = "TgCodigo"
        cboTipoComPag.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(182)
        cboTipoComPag.ItemIndex = -1

        cboFuenteFinanciera.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboFuenteFinanciera.Properties.DisplayMember = "TgNombre"
        cboFuenteFinanciera.Properties.ValueMember = "TgCodigo"
        cboFuenteFinanciera.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(23)
        cboFuenteFinanciera.ItemIndex = -1

        cboMeta.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboMeta.Properties.DisplayMember = "TgNombre"
        cboMeta.Properties.ValueMember = "TgCodigo"
        cboMeta.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(136)
        cboMeta.ItemIndex = -1

        cboActProy.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboActProy.Properties.DisplayMember = "TgNombre"
        cboActProy.Properties.ValueMember = "TgCodigo"
        cboActProy.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(135)
        cboActProy.ItemIndex = -1
    End Sub

    Private Sub btnBuscarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProveedor.Click
        Using fmConsultaProveedor As frmConsultaProveedor = New frmConsultaProveedor()
            If fmConsultaProveedor.ShowDialog() = DialogResult.OK Then
                txtProveedor.Text = fmConsultaProveedor.PerProveedor
                txtProveedor.Tag = fmConsultaProveedor.PerId
            End If
        End Using
    End Sub

    Private Sub btnBuscarTrabajador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarTrabajador.Click
        Using fmConsultaTrabajador As frmConsultaTrabajador = New frmConsultaTrabajador()
            If fmConsultaTrabajador.ShowDialog() = DialogResult.OK Then
                txtResponsable.Text = fmConsultaTrabajador.PerTrabajador
                txtResponsable.Tag = fmConsultaTrabajador.PerId
            End If
        End Using
    End Sub

    Private Sub btnConsultarCuentaDebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCuentaDebe.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta()
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaDebe.Tag = fmConsulta.PlanCIdCompuesto
                txtCuentaDebe.Text = String.Format("{0} - {1}", txtCuentaDebe.Tag.ToString.Substring(4), fmConsulta.PlanCDescripcion)
            End If
        End Using
    End Sub

    Private Sub btnConsultarCuentaHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCuentaHaber.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta()
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaHaber.Tag = fmConsulta.PlanCIdCompuesto
                txtCuentaHaber.Text = String.Format("{0} - {1}", txtCuentaHaber.Tag.ToString.Substring(4), fmConsulta.PlanCDescripcion)
            End If
        End Using
    End Sub

    Private Sub btnConsultarCuentaDebe2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCuentaDebe2.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta()
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaDebe2.Tag = fmConsulta.PlanCIdCompuesto
                txtCuentaDebe2.Text = String.Format("{0} - {1}", txtCuentaDebe2.Tag.ToString.Substring(4), fmConsulta.PlanCDescripcion)
            End If
        End Using
    End Sub

    Private Sub btnConsultarCuentaHaber2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCuentaHaber2.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta()
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaHaber2.Tag = fmConsulta.PlanCIdCompuesto
                txtCuentaHaber2.Text = String.Format("{0} - {1}", txtCuentaHaber2.Tag.ToString.Substring(4), fmConsulta.PlanCDescripcion)
            End If
        End Using
    End Sub

    Private Sub btnConsultarPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarPartida.Click
        Dim frm As frmConsultarPartida = New frmConsultarPartida()
        If frm.ShowDialog Then
            If frm.PartPIM <> 0 Then
                txtPartida.Tag = frm.PartIdCompuesta
                txtPartida.Text = String.Format("{0} - {1}", frm.PartId, frm.PartNombre)
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("La Partida Seleccionada no Tiene Monto PIM Asignado")
            End If
        End If
    End Sub

    Private Sub cboBanco_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBanco.EditValueChanged
        If cboBanco.EditValue IsNot Nothing Then
            txtComPagNro.EditValue = MantenimientosBL.Instancia.comprobantePagoGeneraCodigoSAIMT(cboBanco.EditValue)
        End If
    End Sub
End Class