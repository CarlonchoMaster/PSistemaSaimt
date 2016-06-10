Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmGruposArt
    Inherits frmMantenimientos
    Dim ClsIdGrupo As Integer = 106
    Dim ClsIdTipoGrupo As Integer = 113
    Protected Overrides Sub guardar()
        Try
            Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral
            Dim loClase As EEClase = New EEClase

            If TxtNombre.EditValue = Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nombre de la Grupo de Articulos")
                Return
            End If

            If TxtCodigo.EditValue = Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Codigo de la Grupo de Articulos")
                Return
            End If


            loTablaGeneral.TgId = GIdRegistroActual
            loTablaGeneral.TgNombre = TxtNombre.Text
            loTablaGeneral.TgCodigo = TxtCodigo.Text
            loTablaGeneral.TgAbrev = txtSiglas.Text
            loTablaGeneral.TgActivo = chkActivo.Checked
            loTablaGeneral.TgExtra = cboTipoGrupo.EditValue
            loClase.ClsId = ClsIdGrupo
            loTablaGeneral.OClase = loClase
            Dim Graba As Boolean = False
            If GEstadoNuevo Then
                If MantenimientosBL.Instancia.tablageneralValidaItgCodigo(ClsIdGrupo, loTablaGeneral.TgCodigo) = False Then
                    MantenimientosBL.Instancia.tablageneralinsertar(loTablaGeneral)
                    Graba = True
                End If
            Else
                If MantenimientosBL.Instancia.tablageneralValidaUtgCodigo(ClsIdGrupo, loTablaGeneral.TgId, loTablaGeneral.TgCodigo) = False Then
                    MantenimientosBL.Instancia.tablageneralUpdate(loTablaGeneral)
                    Graba = True
                End If
            End If
            If Graba = False Then
                SaimtMessageBox.mostrarAlertaInformativa("El codigo Ingresado ya se encuentra registrado, Intente Otro")
                Return
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
            lstGrupo.DisplayMember = "TgNombre"
            lstGrupo.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(ClsIdGrupo, sRbBuscarPor.EditValue, GValorTextoBuscado)
            MyBase.listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            lstGrupo.DisplayMember = "TgNombre"
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = sRbBuscarPor.EditValue
            Select Case sRbBuscarPor.EditValue
                Case 1, 2
                    lstGrupo.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(ClsIdGrupo, sRbBuscarPor.EditValue, GValorTextoBuscado)
                Case 3
                    GValorTextoBuscado = cboBuscarPorGrupo.Text
                    lstGrupo.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId1_IN_ClsId2_ListarCriterio(ClsIdGrupo, ClsIdTipoGrupo, 1, GValorTextoBuscado)
            End Select

            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub seleccionarListado()
        Try
            If lstGrupo.SelectedItem IsNot Nothing Then

                Dim loTableGeneral As EETablaGeneral = DirectCast(lstGrupo.SelectedValue, EETablaGeneral)

                TxtNombre.Text = loTableGeneral.TgNombre
                GIdRegistroActual = loTableGeneral.TgId
                txtSiglas.Text = loTableGeneral.TgAbrev
                TxtCodigo.Text = loTableGeneral.TgCodigo
                chkActivo.Checked = loTableGeneral.TgActivo
                cboTipoGrupo.EditValue = loTableGeneral.TgExtra
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        TxtCodigo.Text = MantenimientosBL.Instancia.TablaGeneralNewCodigo(3, ClsIdGrupo)
        TxtCodigo.Properties.ReadOnly = False
        TxtCodigo.Enabled = False
        TxtNombre.Focus()
    End Sub

    Private Sub frmInstitucion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        Me.PuedeEliminar = True
        cboTipoGrupo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoGrupo.Properties.DisplayMember = "TgNombre"
        cboTipoGrupo.Properties.ValueMember = "TgCodigo"
        cboTipoGrupo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(ClsIdTipoGrupo)
        cboTipoGrupo.ItemIndex = 0
        sRbBuscarPor.SelectedIndex = 0

        cboBuscarPorGrupo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboBuscarPorGrupo.Properties.DisplayMember = "TgNombre"
        cboBuscarPorGrupo.Properties.ValueMember = "TgCodigo"
        cboBuscarPorGrupo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(113)
        cboBuscarPorGrupo.ItemIndex = 0

        cboBuscarPorGrupo.Properties.ReadOnly = IIf(sRbBuscarPor.SelectedIndex = 3, False, True)
        txtBuscarPor.Properties.ReadOnly = IIf(sRbBuscarPor.SelectedIndex = 3, True, False)
    End Sub

    Private Sub sRbBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sRbBuscarPor.SelectedIndexChanged
        cboBuscarPorGrupo.Properties.ReadOnly = IIf(sRbBuscarPor.SelectedIndex = 2, False, True)
        txtBuscarPor.Properties.ReadOnly = IIf(sRbBuscarPor.SelectedIndex = 2, True, False)
    End Sub

    Private Sub cboBuscarPorGrupo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuscarPorGrupo.EditValueChanged
        Buscar()
    End Sub
End Class