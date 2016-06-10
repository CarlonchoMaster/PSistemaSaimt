Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmPermisosSTD

    Dim ListaTemporalNuevos As List(Of EEJerarquiaSTD)
    Dim ListaTemporalEliminados As List(Of String)
    Dim dtPermisosSTD As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtPermisosSTD.Columns.Add("codInstitucionOrigen", GetType(String))
        dtPermisosSTD.Columns.Add("institucionOrigen", GetType(String))
        dtPermisosSTD.Columns.Add("codAreaOrigen", GetType(String))
        dtPermisosSTD.Columns.Add("areaOrigen", GetType(String))
        dtPermisosSTD.Columns.Add("codCargoOrigen", GetType(String))
        dtPermisosSTD.Columns.Add("cargoOrigen", GetType(String))

        dtPermisosSTD.Columns.Add("codInstitucionDestino", GetType(String))
        dtPermisosSTD.Columns.Add("institucionDestino", GetType(String))
        dtPermisosSTD.Columns.Add("codAreaDestino", GetType(String))
        dtPermisosSTD.Columns.Add("areaDestino", GetType(String))
        dtPermisosSTD.Columns.Add("codCargoDestino", GetType(String))
        dtPermisosSTD.Columns.Add("cargoDestino", GetType(String))

        dtPermisosSTD.Columns.Add("codTipoDocumento", GetType(String))
        dtPermisosSTD.Columns.Add("tipoDocumento", GetType(String))
        dtPermisosSTD.Columns.Add("jerActivo", GetType(Boolean))
        dtPermisosSTD.Columns.Add("nuevo", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If lstPermisosSTD.SelectedItem IsNot Nothing Then
                Dim loJerarquiaSTD As EEJerarquiaSTD = DirectCast(lstPermisosSTD.SelectedItem, EEJerarquiaSTD)

                GIndiceSeleccionado = lstPermisosSTD.SelectedIndex

                Dim ListaJerarquiaSTD As List(Of EEJerarquiaSTD) = MantenimientosBL.Instancia.jerarquiastdListarCriterioXTipoCriterio_XId(rdbCriterios.EditValue, loJerarquiaSTD.Id)

                dtPermisosSTD.Clear()
                For Each fJerarquiaSTD As EEJerarquiaSTD In ListaJerarquiaSTD
                    dtPermisosSTD.LoadDataRow(New Object() { _
                            fJerarquiaSTD.CodInstitucionOrigen, _
                            fJerarquiaSTD.InstitucionOrigen, _
                            fJerarquiaSTD.CodAreaOrigen, _
                            fJerarquiaSTD.AreaOrigen, _
                            fJerarquiaSTD.CodCargoOrigen, _
                            fJerarquiaSTD.CargoOrigen, _
                            fJerarquiaSTD.CodInstitucionDestino, _
                            fJerarquiaSTD.InstitucionDestino, _
                            fJerarquiaSTD.CodAreaDestino, _
                            fJerarquiaSTD.AreaDestino, _
                            fJerarquiaSTD.CodCargoDestino, _
                            fJerarquiaSTD.CargoDestino, _
                            fJerarquiaSTD.OTgTipoDocumento.TgCodigo, _
                            fJerarquiaSTD.OTgTipoDocumento.TgNombre, _
                            fJerarquiaSTD.JerActivo, _
                            fJerarquiaSTD.CodInstitucionOrigen & fJerarquiaSTD.CodAreaOrigen & fJerarquiaSTD.CodCargoOrigen & fJerarquiaSTD.CodInstitucionDestino & fJerarquiaSTD.CodAreaDestino & fJerarquiaSTD.CodCargoDestino & fJerarquiaSTD.OTgTipoDocumento.TgCodigo
                    }, True)
                Next
                gvPermisosSTD.BestFitColumns()
            End If
            MyBase.seleccionarListado()
            txtInstitucionOrigen.Text = "SERVICIO DE ADMINISTRACIÓN DE INMUEBLES MUNICIPALES DE TRUJILLO"
            txtInstitucionOrigen.Tag = "0001"
            cboAreaOrigen.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboAreaOrigen.Properties.DisplayMember = "TgNombre"
            cboAreaOrigen.Properties.ValueMember = "TgCodigo"
            cboAreaOrigen.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucionOrigen.Tag)
            txtInstitucionDestino.Text = "SERVICIO DE ADMINISTRACIÓN DE INMUEBLES MUNICIPALES DE TRUJILLO"
            txtInstitucionDestino.Tag = "0001"
            cboAreaDestino.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboAreaDestino.Properties.DisplayMember = "TgNombre"
            cboAreaDestino.Properties.ValueMember = "TgCodigo"
            cboAreaDestino.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucionOrigen.Tag)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            lstPermisosSTD.DisplayMember = "PermisosSTD"
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = rdbCriterios.EditValue
            lstPermisosSTD.DataSource = MantenimientosBL.Instancia.jerarquiastdListarCriterio(rdbCriterios.EditValue, txtBuscarPor.Text)
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub listar()
        Try
            lstPermisosSTD.DisplayMember = "PermisosSTD"
            lstPermisosSTD.DataSource = MantenimientosBL.Instancia.jerarquiastdListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            MyBase.listar()
            lstPermisosSTD.SelectedIndex = GIndiceSeleccionado
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            Dim loJerarquiaSTDPrincipal As EEJerarquiaSTD = New EEJerarquiaSTD()
            For Each fJerarquiaSTD As DataRow In dtPermisosSTD.Rows
                Dim loJerarquiaSTD As EEJerarquiaSTD = New EEJerarquiaSTD()
                Dim loTipoDocumento As EETablaGeneral = New EETablaGeneral()
                loTipoDocumento.TgCodigo = fJerarquiaSTD("codTipoDocumento")

                loJerarquiaSTD.JerDeId = fJerarquiaSTD("codInstitucionOrigen") & fJerarquiaSTD("codAreaOrigen") & fJerarquiaSTD("codCargoOrigen")
                loJerarquiaSTD.JerParaId = fJerarquiaSTD("codInstitucionDestino") & fJerarquiaSTD("codAreaDestino") & fJerarquiaSTD("codCargoDestino")
                loJerarquiaSTD.OTgTipoDocumento = loTipoDocumento
                loJerarquiaSTD.JerActivo = fJerarquiaSTD("jerActivo")

                loJerarquiaSTDPrincipal.ListaJerarquiaSTD.Add(loJerarquiaSTD)
            Next

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.jerarquiastdGuardar(loJerarquiaSTDPrincipal)
            Else
                loJerarquiaSTDPrincipal.ListaTemporalNuevos = ListaTemporalNuevos
                loJerarquiaSTDPrincipal.ListaTemporalEliminados = ListaTemporalEliminados
                MantenimientosBL.Instancia.jerarquiastdActualizar(loJerarquiaSTDPrincipal)

                ListaTemporalEliminados.Clear()
                ListaTemporalNuevos.Clear()
            End If
            Me.enabledGA = False
            MyBase.guardar()
            listar()
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
        txtInstitucionOrigen.Properties.ReadOnly = True
        txtInstitucionDestino.Properties.ReadOnly = True
        btnConsultarInstitucionOrigen.Enabled = True
        btnConsultarInstitucionDestino.Enabled = True
        dtPermisosSTD.Clear()

        txtInstitucionOrigen.Text = "SERVICIO DE ADMINISTRACION DE INMUEBLES MUNICIPALES"
        txtInstitucionDestino.Text = "SERVICIO DE ADMINISTRACION DE INMUEBLES MUNICIPALES"
        txtInstitucionOrigen.Tag = "0001"
        txtInstitucionDestino.Tag = "0001"
        cboAreaOrigen.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAreaOrigen.Properties.DisplayMember = "TgNombre"
        cboAreaOrigen.Properties.ValueMember = "TgCodigo"
        cboAreaOrigen.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucionOrigen.Tag)

        cboAreaDestino.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAreaDestino.Properties.DisplayMember = "TgNombre"
        cboAreaDestino.Properties.ValueMember = "TgCodigo"
        cboAreaDestino.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucionOrigen.Tag)
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        txtInstitucionOrigen.Properties.ReadOnly = True
        txtInstitucionDestino.Properties.ReadOnly = True
        btnConsultarInstitucionOrigen.Enabled = True
        btnConsultarInstitucionDestino.Enabled = True
    End Sub
#End Region

    Private Sub frmPermisosSTD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        ConstruirTable()
        dgvPermisosSTD.DataSource = dtPermisosSTD

        If ListaTemporalNuevos Is Nothing Then
            ListaTemporalNuevos = New List(Of EEJerarquiaSTD)
        End If

        If ListaTemporalEliminados Is Nothing Then
            ListaTemporalEliminados = New List(Of String)
        End If

        cboTipoDocumento.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoDocumento.Properties.DisplayMember = "TgNombre"
        cboTipoDocumento.Properties.ValueMember = "TgCodigo"
        cboTipoDocumento.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(86)
    End Sub

    Private Sub btnConsultarInstitucionOrigen_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultarInstitucionOrigen.Click
        Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(82)
            If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                txtInstitucionOrigen.Text = fmConsultaTablaGeneral.TgNombre
                txtInstitucionOrigen.Tag = fmConsultaTablaGeneral.TgCodigo
                cboAreaOrigen.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                cboAreaOrigen.Properties.DisplayMember = "TgNombre"
                cboAreaOrigen.Properties.ValueMember = "TgCodigo"
                cboAreaOrigen.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucionOrigen.Tag)
            End If
        End Using
    End Sub

    Private Sub btnConsultarInstitucionDestino_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultarInstitucionDestino.Click
        Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(82)
            If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                txtInstitucionDestino.Text = fmConsultaTablaGeneral.TgNombre
                txtInstitucionDestino.Tag = fmConsultaTablaGeneral.TgCodigo
                cboAreaDestino.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                cboAreaDestino.Properties.DisplayMember = "TgNombre"
                cboAreaDestino.Properties.ValueMember = "TgCodigo"
                cboAreaDestino.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucionOrigen.Tag)
            End If
        End Using
    End Sub

    Private Sub cboAreaOrigen_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboAreaOrigen.EditValueChanged
        cboCargoOrigen.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCargoOrigen.Properties.DisplayMember = "TgNombre"
        cboCargoOrigen.Properties.ValueMember = "TgCodigo"
        cboCargoOrigen.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(84, cboAreaOrigen.EditValue & txtInstitucionOrigen.Tag)
    End Sub

    Private Sub cboAreaDestino_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboAreaDestino.EditValueChanged
        cboCargoDestino.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCargoDestino.Properties.DisplayMember = "TgNombre"
        cboCargoDestino.Properties.ValueMember = "TgCodigo"
        cboCargoDestino.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(84, cboAreaDestino.EditValue & txtInstitucionDestino.Tag)
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Try
            If txtInstitucionOrigen.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una Institución Origen")
                Exit Sub
            End If

            If cboAreaOrigen.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Area de Origen")
                Exit Sub
            End If

            If cboCargoOrigen.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Cargo de Origen")
                Exit Sub
            End If

            If txtInstitucionDestino.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una Institución Destino")
                Exit Sub
            End If

            If cboAreaDestino.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Area de Destino")
                Exit Sub
            End If

            If cboCargoDestino.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Cargo de Destino")
                Exit Sub
            End If

            dtPermisosSTD.LoadDataRow(New Object() { _
                txtInstitucionOrigen.Tag, _
                txtInstitucionOrigen.Text, _
                cboAreaOrigen.EditValue, _
                cboAreaOrigen.Text, _
                cboCargoOrigen.EditValue, _
                cboCargoOrigen.Text, _
                txtInstitucionDestino.Tag, _
                txtInstitucionDestino.Text, _
                cboAreaDestino.EditValue, _
                cboAreaDestino.Text, _
                cboCargoDestino.EditValue, _
                cboCargoDestino.Text, _
                cboTipoDocumento.EditValue, _
                cboTipoDocumento.Text, _
                chkPermisoActivo.Checked, _
                String.Empty
            }, True)

            gvPermisosSTD.BestFitColumns()

            If GEstadoNuevo = False Then
                Dim loJerarquiaSTD As EEJerarquiaSTD = New EEJerarquiaSTD()
                Dim loTipoDocumento As EETablaGeneral = New EETablaGeneral()

                loTipoDocumento.TgCodigo = cboTipoDocumento.EditValue

                loJerarquiaSTD.JerDeId = txtInstitucionOrigen.Tag & cboAreaOrigen.EditValue & cboCargoOrigen.EditValue
                loJerarquiaSTD.JerParaId = txtInstitucionDestino.Tag & cboAreaDestino.EditValue & cboCargoDestino.EditValue
                loJerarquiaSTD.OTgTipoDocumento = loTipoDocumento
                loJerarquiaSTD.JerActivo = chkPermisoActivo.Checked
                ListaTemporalNuevos.Add(loJerarquiaSTD)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnRemover_Click(sender As System.Object, e As System.EventArgs) Handles btnRemover.Click
        If Me.gvPermisosSTD.DataRowCount <> 0 Then
            If GEstadoNuevo = False Then
                If Not String.IsNullOrEmpty(dtPermisosSTD.Rows(Me.gvPermisosSTD.GetSelectedRows(0))("nuevo").ToString()) Then
                    ListaTemporalEliminados.Add(dtPermisosSTD.Rows(Me.gvPermisosSTD.GetSelectedRows(0))("nuevo").ToString())
                End If
            End If

            If ListaTemporalNuevos.Count > 0 Then
                Dim liIndiceNuevoModificar As Int16 = 0
                Dim liFila As Int16 = -1

                For Each fTablaCargoPersonal As DataRow In dtPermisosSTD.Rows
                    Dim lsString As String = fTablaCargoPersonal("nuevo").ToString()
                    If String.IsNullOrEmpty(fTablaCargoPersonal("nuevo")) And Me.gvPermisosSTD.FocusedRowHandle = liFila Then
                        liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                    End If

                    liFila = liFila + 1
                Next
                ListaTemporalNuevos.RemoveAt(liIndiceNuevoModificar)
            End If
            dtPermisosSTD.Rows.RemoveAt(Me.gvPermisosSTD.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

    End Sub
End Class