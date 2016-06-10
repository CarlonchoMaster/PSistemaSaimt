Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmEtapas

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If lstEtapas.SelectedItem IsNot Nothing Then

                Dim loEtapaSTD As EEEtapaSTD = DirectCast(lstEtapas.SelectedItem, EEEtapaSTD)

                txtCodigoEtapa.Text = loEtapaSTD.EtaCod
                txtInstitucion.Text = loEtapaSTD.Institucion
                txtInstitucion.Tag = loEtapaSTD.CodInstitucion

                cboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                cboArea.Properties.DisplayMember = "TgNombre"
                cboArea.Properties.ValueMember = "TgCodigo"
                cboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucion.Tag)


                cboArea.EditValue = loEtapaSTD.CodArea
                txtProcedimiento.Text = loEtapaSTD.OProcedimientoSTD.ProcNombre
                txtProcedimiento.Tag = loEtapaSTD.OProcedimientoSTD.ProcId
                spnNumero.EditValue = loEtapaSTD.EtaNro
                txtNombre.Text = loEtapaSTD.EtaNombre
                spnDuracion.EditValue = loEtapaSTD.EtaMaxDia
                spnHoras.EditValue = loEtapaSTD.EtaMaxHoras
                chkFinProcedimiento.Checked = loEtapaSTD.EtaFinaliza
                txtObservaciones.Text = loEtapaSTD.EtaObservacion

                GIdRegistroActual = loEtapaSTD.EtaCod
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            lstEtapas.DisplayMember = "DatoListadoEtapaSTD"
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = rdbCriterios.EditValue
            lstEtapas.DataSource = MantenimientosBL.Instancia.etapastdListarCriterio(rdbCriterios.EditValue, txtBuscarPor.Text)
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            If String.IsNullOrEmpty(txtInstitucion.Tag) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Institución")
                btnConsultarInstitucion.Focus()
                Exit Sub
            End If
            If String.IsNullOrEmpty(cboArea.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Área")
                cboArea.Focus()
                Exit Sub
            End If
            If String.IsNullOrEmpty(txtProcedimiento.Tag) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Procedimiento")
                btnConsultarProcedimiento.Focus()
                Exit Sub
            End If
            If Convert.ToInt16(spnNumero.EditValue) <= 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Nro. de Etapa No Puede Ser Menor Igual que Cero")
                spnNumero.Focus()
                Exit Sub
            End If
            If Convert.ToInt16(spnDuracion.EditValue) <= 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("La Duración No Puede Ser Menor Igual que Cero")
                spnDuracion.Focus()
                Exit Sub
            End If

            Dim loEtapaSTD As EEEtapaSTD = New EEEtapaSTD()
            loEtapaSTD.EtaCod = GIdRegistroActual
            loEtapaSTD.EtaInstArea = txtInstitucion.Tag & cboArea.EditValue
            loEtapaSTD.EtaNro = Convert.ToInt16(spnNumero.EditValue)
            loEtapaSTD.EtaNombre = txtNombre.Text
            loEtapaSTD.EtaMaxDia = Convert.ToInt16(spnDuracion.EditValue)
            loEtapaSTD.EtaMaxHoras = Convert.ToDecimal(spnHoras.EditValue)
            loEtapaSTD.EtaFinaliza = chkFinProcedimiento.Checked
            loEtapaSTD.EtaObservacion = txtObservaciones.Text

            Dim loProcedimientoSTD As EEProcedimientoSTD = New EEProcedimientoSTD()
            loProcedimientoSTD.ProcId = txtProcedimiento.Tag

            loEtapaSTD.OProcedimientoSTD = loProcedimientoSTD
            If GEstadoNuevo Then
                MantenimientosBL.Instancia.etapastdGuardar(loEtapaSTD)
            Else
                MantenimientosBL.Instancia.etapastdActualizar(loEtapaSTD)
            End If
            Me.enabledGA = False
            MyBase.guardar()
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub listar()
        Try
            lstEtapas.DisplayMember = "DatoListadoEtapaSTD"
            lstEtapas.DataSource = MantenimientosBL.Instancia.etapastdListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            MyBase.listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub eliminar()
        Try
            MyBase.eliminar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtInstitucion.Properties.ReadOnly = True
        txtProcedimiento.Properties.ReadOnly = True
        txtCodigoEtapa.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        txtInstitucion.Properties.ReadOnly = True
        txtProcedimiento.Properties.ReadOnly = True
        txtCodigoEtapa.Properties.ReadOnly = True
    End Sub

#End Region

    Private Sub frmEtapas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
    End Sub

    Private Sub btnConsultarInstitucion_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultarInstitucion.Click
        Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(82)
            If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                txtInstitucion.Text = fmConsultaTablaGeneral.TgNombre
                txtInstitucion.Tag = fmConsultaTablaGeneral.TgCodigo

                cboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                cboArea.Properties.DisplayMember = "TgNombre"
                cboArea.Properties.ValueMember = "TgCodigo"
                cboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucion.Tag)
            End If
        End Using
    End Sub

    Private Sub btnConsultarProcedimiento_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultarProcedimiento.Click
        Using fmConsultaProcedimiento As frmConsultaProcedimiento = New frmConsultaProcedimiento()
            If fmConsultaProcedimiento.ShowDialog() = DialogResult.OK Then
                txtProcedimiento.Text = fmConsultaProcedimiento.ProcNombre
                txtProcedimiento.Tag = fmConsultaProcedimiento.ProcId
            End If
        End Using
    End Sub
End Class