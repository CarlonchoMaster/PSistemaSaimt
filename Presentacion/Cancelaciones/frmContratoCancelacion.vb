Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmContratoCancelacion
    Inherits frmCancelacion

    Private Sub frmContratoCancelacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PuedeBuscar = True
            Me.PuedeCrear = True
            Me.PuedeEditar = True
            Me.PuedeExportar = True
            Me.PuedeImprimir = True
            txtNroContrato.Properties.ReadOnly = True
            dtpFechaCancelacion.EditValue = DateTime.Now
            Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarNroCuotasNoPagadasXConInmId(txtNroContrato.Text)

            If ListaProPagos IsNot Nothing Then
                cboCanDesde.mColumnas(SaimtComboBoxLookUp.Entidades.proPaNroCuota)
                cboCanDesde.Properties.DisplayMember = "ProPaNroCuota"
                cboCanDesde.Properties.ValueMember = "ProPaNroCuota"
                cboCanDesde.Properties.DataSource = ListaProPagos
                txtNroCuotasPendientes.Text = ListaProPagos.Count
            End If

            txtNroTotalCuotas.Text = MantenimientosBL.Instancia.proPagosMostrarNroCuotasALLXConInmId(txtNroContrato.Text)
            txtNroCuotasPagadas.Text = Convert.ToInt32(txtNroTotalCuotas.Text) - Convert.ToInt32(txtNroCuotasPendientes.Text)
            cboEstadoContrato.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboEstadoContrato.Properties.DisplayMember = "TgNombre"
            cboEstadoContrato.Properties.ValueMember = "TgCodigo"
            cboEstadoContrato.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(17, "2','3")
            cboEstadoContrato.ItemIndex = 0

            txtNroTotalCuotas.Properties.ReadOnly = True
            txtNroCuotasPendientes.Properties.ReadOnly = True
            txtNroCuotasPagadas.Properties.ReadOnly = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            Dim loContratoInm As EEContratoInm = New EEContratoInm()
            loContratoInm.ConInmId = txtNroContrato.Text
            loContratoInm.ConInmFecCan = dtpFechaCancelacion.EditValue
            loContratoInm.ConInmObs = txtObsContrato.Text
            loContratoInm.ConInmICuotaCan = cboCanDesde.Text
            loContratoInm.TgEstId = cboEstadoContrato.EditValue

            MantenimientosBL.Instancia.contratoInmCancelarContrato(loContratoInm)
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaInformativa(ex.Message)
        End Try
    End Sub
End Class