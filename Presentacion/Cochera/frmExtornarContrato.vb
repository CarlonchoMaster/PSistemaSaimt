Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Public Class frmExtornarContrato

    Private Sub frmExtornarContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cboMotivoExtorno.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboMotivoExtorno.Properties.DisplayMember = "TgNombre"
            cboMotivoExtorno.Properties.ValueMember = "TgCodigo"
            cboMotivoExtorno.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(159)
            cboMotivoExtorno.ItemIndex = -1

            txtNroContrato.Properties.ReadOnly = True
            dtpFechaCancelacion.EditValue = DateTime.Now
            Dim ListaProPagos As List(Of EEAbonoPEM.EEAbonoDetPEM) = MantenimientosBL.Instancia.abonoDetpemListarNroCuotasNoPagadasXAbonId(txtNroContrato.Text)

            If ListaProPagos IsNot Nothing Then
                cboCanDesde.mColumnas(SaimtComboBoxLookUp.Entidades.abonDetNroCuota)
                cboCanDesde.Properties.DisplayMember = "AbonDetNroCuota"
                cboCanDesde.Properties.ValueMember = "AbonDetNroCuota"
                cboCanDesde.Properties.DataSource = ListaProPagos
                txtNroCuotasPendientes.Text = ListaProPagos.Count
            End If

            txtNroTotalCuotas.Text = MantenimientosBL.Instancia.abonoDetpemMostrarNroCuotasALLXAbonId(txtNroContrato.Text)
            txtNroCuotasPagadas.Text = Convert.ToInt32(txtNroTotalCuotas.Text) - Convert.ToInt32(txtNroCuotasPendientes.Text)
            txtNroTotalCuotas.Properties.ReadOnly = True
            txtNroCuotasPendientes.Properties.ReadOnly = True
            txtNroCuotasPagadas.Properties.ReadOnly = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub guardar()
        Try
            If cboMotivoExtorno.EditValue Is Nothing Then

                SaimtMessageBox.mostrarAlertaInformativa("Seleccione Motivo de Extorno")
                Return
            End If

            If cboCanDesde.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione Cuota a cancelar")
                Return
            End If

            Dim aoAbonExtorno As EEAbonExtorno = New EEAbonExtorno()
            aoAbonExtorno.OAbonoPEM = New EEAbonoPEM
            aoAbonExtorno.OAbonoPEM.AbonId = txtNroContrato.Text
            aoAbonExtorno.OTgTipoExt = New EETablaGeneral
            aoAbonExtorno.OTgTipoExt.TgCodigo = cboMotivoExtorno.EditValue
            aoAbonExtorno.ExtObservacion = txtObsContrato.Text
            aoAbonExtorno.ExtDesdeCuota = cboCanDesde.Text
            aoAbonExtorno.ExtPerId = EEComun._PerId
            MantenimientosBL.Instancia.abonextornoGuardarExtonoAbono(aoAbonExtorno)
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaInformativa(ex.Message)
        End Try
    End Sub


    Private Sub btnGuardarCancelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCancelacion.Click
        guardar()
    End Sub
End Class