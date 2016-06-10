Imports Entidades
Imports SaimtControles
Imports ReglasNegocio

Public Class frmCargoTipoAccionSTD

    Dim ListaTemporalNuevos As List(Of EECargoTipoAccionSTD)
    Dim ListaTemporalEliminados As List(Of String)
    Dim dtCargoTipoAccionSTD As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtCargoTipoAccionSTD.Columns.Add("id", GetType(String))
        dtCargoTipoAccionSTD.Columns.Add("codInstitucion", GetType(String))
        dtCargoTipoAccionSTD.Columns.Add("institucion", GetType(String))
        dtCargoTipoAccionSTD.Columns.Add("codArea", GetType(String))
        dtCargoTipoAccionSTD.Columns.Add("area", GetType(String))
        dtCargoTipoAccionSTD.Columns.Add("codCargo", GetType(String))
        dtCargoTipoAccionSTD.Columns.Add("cargo", GetType(String))
        dtCargoTipoAccionSTD.Columns.Add("codTipoAccion", GetType(String))
        dtCargoTipoAccionSTD.Columns.Add("tipoAccion", GetType(String))
        dtCargoTipoAccionSTD.Columns.Add("nroAccionesGenerados", GetType(String))
        dtCargoTipoAccionSTD.Columns.Add("año", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try

            If lstCargoTipoAccion.SelectedItem IsNot Nothing Then
                GIndiceSeleccionado = lstCargoTipoAccion.SelectedIndex

                Dim lsCarTipoAccionId As String = txtInstitucionCriterio.Tag & cboAreaCriterio.EditValue & lstCargoTipoAccion.SelectedValue

                txtInstitucion.Text = txtInstitucionCriterio.Text
                txtInstitucion.Tag = txtInstitucionCriterio.Tag
                txtArea.Text = cboAreaCriterio.Text
                txtArea.Tag = cboAreaCriterio.EditValue
                txtCargo.Text = lstCargoTipoAccion.Text
                txtCargo.Tag = lstCargoTipoAccion.SelectedValue

                Dim ListaCargoTipoAccionSTD As List(Of EECargoTipoAccionSTD) = MantenimientosBL.Instancia.cargotipoaccionstdListarCriterio(1, lsCarTipoAccionId)

                dtCargoTipoAccionSTD.Clear()
                If ListaCargoTipoAccionSTD IsNot Nothing Then
                    For Each fCargoTipoAccionSTD As EECargoTipoAccionSTD In ListaCargoTipoAccionSTD
                        dtCargoTipoAccionSTD.LoadDataRow(New Object() { _
                               fCargoTipoAccionSTD.CarTipoAccId & fCargoTipoAccionSTD.OTgAccion.TgCodigo & fCargoTipoAccionSTD.CarTipoAccAño, _
                               fCargoTipoAccionSTD.CodInstitucion, _
                               fCargoTipoAccionSTD.Institucion, _
                               fCargoTipoAccionSTD.CodArea, _
                               fCargoTipoAccionSTD.Area, _
                               fCargoTipoAccionSTD.CodCargo, _
                               fCargoTipoAccionSTD.Cargo, _
                               fCargoTipoAccionSTD.OTgAccion.TgCodigo, _
                               fCargoTipoAccionSTD.OTgAccion.TgNombre, _
                               fCargoTipoAccionSTD.CarTipoAccNroIni, _
                               fCargoTipoAccionSTD.CarTipoAccAño
                        }, True)
                    Next
                    gvCargoTipoAccion.BestFitColumns()
                End If
                MyBase.seleccionarListado()
                txtInstitucionCriterio.Properties.ReadOnly = False
                cboAreaCriterio.Properties.ReadOnly = False
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        MyBase.Buscar()
    End Sub

    Protected Overrides Sub listar()
        MyBase.listar()
    End Sub

    Protected Overrides Sub guardar()
        Try
            Dim loCargoTipoAccionSTDPrincipal As EECargoTipoAccionSTD = New EECargoTipoAccionSTD()
            For Each fCargoTipoAccionSTD As DataRow In dtCargoTipoAccionSTD.Rows
                Dim loCargoTípoAccionSTD As EECargoTipoAccionSTD = New EECargoTipoAccionSTD()
                Dim loTipoAccion As EETablaGeneral = New EETablaGeneral()
                loTipoAccion.TgCodigo = fCargoTipoAccionSTD("codTipoAccion")

                loCargoTípoAccionSTD.CarTipoAccId = fCargoTipoAccionSTD("codInstitucion") & fCargoTipoAccionSTD("codArea") & fCargoTipoAccionSTD("codCargo")
                loCargoTípoAccionSTD.CarTipoAccNroIni = Convert.ToInt32(fCargoTipoAccionSTD("nroAccionesGenerados"))
                loCargoTípoAccionSTD.CarTipoAccAño = fCargoTipoAccionSTD("año")
                loCargoTípoAccionSTD.OTgAccion = loTipoAccion

                loCargoTipoAccionSTDPrincipal.ListaCargoTipoAccionSTD.Add(loCargoTípoAccionSTD)
            Next

            If GEstadoNuevo = False Then
                loCargoTipoAccionSTDPrincipal.ListaTemporalNuevos = ListaTemporalNuevos
                loCargoTipoAccionSTDPrincipal.ListaTemporalEliminados = ListaTemporalEliminados
                MantenimientosBL.Instancia.cargotipoaccionstdActualizar(loCargoTipoAccionSTDPrincipal)

                ListaTemporalEliminados.Clear()
                ListaTemporalNuevos.Clear()
            End If
            Me.enabledGA = False
            MyBase.guardar()
            Me.lstListado.SelectionMode = SelectionMode.One
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

    Protected Overrides Sub editar()
        MyBase.editar()
        txtInstitucion.Properties.ReadOnly = True
        txtInstitucionCriterio.Properties.ReadOnly = False
        cboAreaCriterio.Properties.ReadOnly = False
        txtArea.Properties.ReadOnly = True
        txtCargo.Properties.ReadOnly = True
    End Sub
#End Region

    Private Sub frmCargoTipoAccionSTD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        txtInstitucionCriterio.Properties.ReadOnly = False
        cboAreaCriterio.Properties.ReadOnly = False

        ConstruirTable()
        dgvCargoTipoAccion.DataSource = dtCargoTipoAccionSTD

        If ListaTemporalNuevos Is Nothing Then
            ListaTemporalNuevos = New List(Of EECargoTipoAccionSTD)
        End If
        If ListaTemporalEliminados Is Nothing Then
            ListaTemporalEliminados = New List(Of String)
        End If
        cboTipoAccion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoAccion.Properties.DisplayMember = "TgNombre"
        cboTipoAccion.Properties.ValueMember = "TgCodigo"
        cboTipoAccion.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(96)
        spnAño.Value = Year(EEComun.FechaServidor)
    End Sub

    Private Sub txtInstitucionCriterio_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtInstitucionCriterio.ButtonClick
        Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(82)
            If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                txtInstitucionCriterio.Text = fmConsultaTablaGeneral.TgNombre
                txtInstitucionCriterio.Tag = fmConsultaTablaGeneral.TgCodigo
                cboAreaCriterio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                cboAreaCriterio.Properties.DisplayMember = "TgNombre"
                cboAreaCriterio.Properties.ValueMember = "TgCodigo"
                cboAreaCriterio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucionCriterio.Tag)
            End If
        End Using
    End Sub

    Private Sub cboAreaCriterio_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboAreaCriterio.EditValueChanged
        lstCargoTipoAccion.DisplayMember = "TgNombre"
        lstCargoTipoAccion.ValueMember = "TgCodigo"
        lstCargoTipoAccion.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(84, cboAreaCriterio.EditValue & txtInstitucionCriterio.Tag)
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Try
            If txtInstitucion.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una Institución")
                Exit Sub
            End If
            If txtArea.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Area")
                Exit Sub
            End If
            If txtCargo.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Cargo")
                Exit Sub
            End If

            Dim repite As Boolean = False
            For Each fTablaGeneral As DataRow In dtCargoTipoAccionSTD.Rows
                If (fTablaGeneral("codTipoAccion") = cboTipoAccion.EditValue) Then
                    repite = True
                End If
            Next

            If repite = True Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Existe un elemento duplicado, verifique el tipo Accion")
                Return
            End If

            dtCargoTipoAccionSTD.LoadDataRow(New Object() { _
                String.Empty, _
                txtInstitucion.Tag, _
                txtInstitucion.Text, _
                txtArea.Tag, _
                txtArea.Text, _
                txtCargo.Tag, _
                txtCargo.Text, _
                cboTipoAccion.EditValue, _
                cboTipoAccion.Text, _
                spnNroAccionGenerados.EditValue, _
                spnAño.EditValue
            }, True)
            gvCargoTipoAccion.BestFitColumns()
            If GEstadoNuevo = False Then
                Dim loCargoTipoAccionSTD As EECargoTipoAccionSTD = New EECargoTipoAccionSTD()
                Dim loTipoAccion As EETablaGeneral = New EETablaGeneral()
                loTipoAccion.TgCodigo = cboTipoAccion.EditValue

                loCargoTipoAccionSTD.CarTipoAccId = txtInstitucion.Tag & txtArea.Tag & txtCargo.Tag
                loCargoTipoAccionSTD.CarTipoAccNroIni = Convert.ToInt32(spnNroAccionGenerados.EditValue)
                loCargoTipoAccionSTD.OTgAccion = loTipoAccion
                loCargoTipoAccionSTD.CarTipoAccAño = spnAño.EditValue
                ListaTemporalNuevos.Add(loCargoTipoAccionSTD)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click
        If Me.gvCargoTipoAccion.DataRowCount <> 0 Then
            If GEstadoNuevo = False Then
                If Not String.IsNullOrEmpty(dtCargoTipoAccionSTD.Rows(Me.gvCargoTipoAccion.GetSelectedRows(0))("id").ToString()) Then
                    ListaTemporalEliminados.Add(dtCargoTipoAccionSTD.Rows(Me.gvCargoTipoAccion.GetSelectedRows(0))("id").ToString())
                End If
            End If
            If ListaTemporalNuevos.Count > 0 Then
                Dim liIndiceNuevoModificar As Int16 = 0
                Dim liFila As Int16 = -1
                For Each fCargoTipoAccion As DataRow In dtCargoTipoAccionSTD.Rows
                    If String.IsNullOrEmpty(fCargoTipoAccion("id")) And Me.gvCargoTipoAccion.FocusedRowHandle = liFila Then
                        liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                    End If
                    liFila = liFila + 1
                Next
                ListaTemporalNuevos.RemoveAt(liIndiceNuevoModificar)
            End If
            dtCargoTipoAccionSTD.Rows.RemoveAt(Me.gvCargoTipoAccion.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub
End Class