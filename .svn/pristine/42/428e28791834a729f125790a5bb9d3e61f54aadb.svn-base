Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Public Class frmCargos
    Inherits frmGeneral
    Dim claseSeleccionada As Integer
    Dim iClaseArea As Integer = 83
    Dim iClaseCargo As Integer = 84
    Dim iClaseInstitucion As Integer = 82
    Dim dtTablaGeneral As DataTable = New DataTable()
    Dim dtListado As DataTable = New DataTable()
    Dim vstgCodigoIns, vstgCodigoArea As String
    Dim ListaTemporalTablaGeneralEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalTablaGeneralNuevos As List(Of EETablaGeneral) = Nothing

    Dim codigoCargo As Integer

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtTablaGeneral.Columns.Add("tgId", GetType(Integer))
        dtTablaGeneral.Columns.Add("clsId", GetType(Integer))
        dtTablaGeneral.Columns.Add("tgNombre", GetType(String))
        dtTablaGeneral.Columns.Add("tgCodigo", GetType(String))
        dtTablaGeneral.Columns.Add("tgExtra", GetType(String))
        dtTablaGeneral.Columns.Add("tgActivo", GetType(Boolean))
    End Sub


    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("tgArea", GetType(String))
        dtListado.Columns.Add("tgAreaId", GetType(String))
        dtListado.Columns.Add("tgAbrev", GetType(String))
        dtListado.Columns.Add("tgInstitucion", GetType(String))
        dtListado.Columns.Add("tgInstitucionId", GetType(String))
    End Sub
#End Region
    Sub seleccionarListado()
        Try
            If Me.gvResultBusq.DataRowCount <> 0 Then
                Dim extra As String = gvResultBusq.GetRowCellValue(gvResultBusq.GetSelectedRows(0), "tgAreaId") & gvResultBusq.GetRowCellValue(gvResultBusq.GetSelectedRows(0), "tgInstitucionId")
                Dim lTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(iClaseCargo, extra)
                dtTablaGeneral.Clear()
                If lTablaGeneral IsNot Nothing Then
                    For Each fTablaGeneral As EETablaGeneral In lTablaGeneral
                        dtTablaGeneral.LoadDataRow(New Object() {fTablaGeneral.TgId, _
                              iClaseArea, _
                               fTablaGeneral.TgNombre, _
                               fTablaGeneral.TgCodigo, _
                               fTablaGeneral.TgExtra, _
                               fTablaGeneral.TgActivo
                       }, True)
                    Next
                End If
                Me.gvTablaGeneral.BestFitColumns()
                sCboInstitucion.EditValue = gvResultBusq.GetRowCellValue(gvResultBusq.GetSelectedRows(0), "tgInstitucionId")
                sCboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                sCboArea.Properties.DisplayMember = "TgNombre"
                sCboArea.Properties.ValueMember = "TgCodigo"
                sCboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(iClaseArea, sCboInstitucion.EditValue)
                sCboArea.ItemIndex = 0
                sCboArea.EditValue = gvResultBusq.GetRowCellValue(gvResultBusq.GetSelectedRows(0), "tgAreaId")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Sub seleccionarCargo()
        Try
            If Me.gvTablaGeneral.DataRowCount <> 0 Then
       
                txtNombre.Text = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgNombre")
                txtCodigo.Text = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgCodigo")
                txtCodigo.Tag = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgId")
                chkEstado.Checked = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgActivo")
                btnEditar.Enabled = True
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    'Private Sub gvResultBusq_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvResultBusq.RowClick
    '    gvResultBusq_Click()
    'End Sub
    'Private Sub gvTablaGeneral_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvTablaGeneral.RowClick
    '    gvTablaGeneral_Click()
    'End Sub

    Private Sub gvResultBusq_Click()
        If gvResultBusq.DataRowCount > 0 Then
            seleccionarListado()
            hodControlesTotal(SaimtGroupBox2.Controls, False)
        End If
    End Sub

    Private Sub gvTablaGeneral_Click()
        If gvTablaGeneral.DataRowCount > 0 Then
            seleccionarCargo()
            'hodControlesTotal(SaimtGroupBox2.Controls, False)
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If String.IsNullOrEmpty(txtNombre.Text) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Nombre")
            txtNombre.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtCodigo.Text) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Codigo")
            txtCodigo.Focus()
            Exit Sub
        End If
        If sCboInstitucion.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Debe de desplegar las areas de las instituciones y seleccionar una")
            Exit Sub
        End If
        If sCboArea.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Debe de desplegar las areas de las instituciones y seleccionar una")
            Exit Sub
        End If
        Dim repite As Boolean = False
        For Each fTablaGeneral As DataRow In dtTablaGeneral.Rows
            If (fTablaGeneral("tgCodigo") = txtCodigo.EditValue) Or (fTablaGeneral("tgNombre") = txtNombre.EditValue) Then
                repite = True
            End If
        Next

        If repite = True Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Exite un elemento duplicado, verifique que le nombre o codigo del cargo no se repita")
            Return
        End If

        dtTablaGeneral.LoadDataRow(New Object() { _
            0, _
            iClaseCargo, _
            txtNombre.Text, _
            txtCodigo.Text, _
            iClaseArea & iClaseInstitucion, _
            chkEstado.EditValue
        }, True)

        If ListaTemporalTablaGeneralNuevos Is Nothing Then
            ListaTemporalTablaGeneralNuevos = New List(Of EETablaGeneral)
        End If

        Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
        Dim loClase As EEClase = New EEClase()
        loClase.ClsId = iClaseCargo
        loTablaGeneral.TgNombre = txtNombre.Text
        loTablaGeneral.TgCodigo = txtCodigo.Text
        loTablaGeneral.TgActivo = chkEstado.Checked
        loTablaGeneral.TgExtra = sCboArea.EditValue & sCboInstitucion.EditValue
        loTablaGeneral.OClase = loClase
        ListaTemporalTablaGeneralNuevos.Add(loTablaGeneral)
        codigoCargo = CInt(txtCodigo.Text)
        txtNombre.EditValue = Nothing
        txtCodigo.EditValue = Nothing
        txtNombre.Focus()
    End Sub
    'Private Sub gvResultados_CustomRowCellEditForEditing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvResultBusq.CustomRowCellEditForEditing
    '    seleccionarListado()
    'End Sub
    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If Me.gvTablaGeneral.DataRowCount <> 0 Then

            If dtTablaGeneral.Rows(Me.gvTablaGeneral.GetSelectedRows(0))("tgId").ToString() > 0 Then
                If ListaTemporalTablaGeneralEliminados Is Nothing Then
                    ListaTemporalTablaGeneralEliminados = New List(Of String)
                End If
                ListaTemporalTablaGeneralEliminados.Add(dtTablaGeneral.Rows(Me.gvTablaGeneral.GetSelectedRows(0))("tgId").ToString())

            End If

            If ListaTemporalTablaGeneralNuevos IsNot Nothing Then

                If ListaTemporalTablaGeneralNuevos.Count > 0 Then
                    Dim liIndiceNuevoModificar As Int16 = 0
                    Dim liFila As Int16 = -1

                    For Each fTablaGeneral As DataRow In dtTablaGeneral.Rows
                        If String.IsNullOrEmpty(fTablaGeneral("tgId")) And Me.gvTablaGeneral.FocusedRowHandle = liFila Then
                            liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                        End If
                        liFila = liFila + 1
                    Next
                    ListaTemporalTablaGeneralNuevos.RemoveAt(liIndiceNuevoModificar)
                End If
            End If
            dtTablaGeneral.Rows.RemoveAt(Me.gvTablaGeneral.GetSelectedRows(0))

        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub


    Private Sub frmCargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        ConstruirTableListado()
        dgvTablaGeneral.DataSource = dtTablaGeneral
        gcResultBusq.DataSource = dtListado
        sCboInstitucion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        sCboInstitucion.Properties.DisplayMember = "TgNombre"
        sCboInstitucion.Properties.ValueMember = "TgCodigo"
        sCboInstitucion.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(iClaseInstitucion)
        sCboInstitucion.ItemIndex = 0
        hodControlesTotal(SaimtGroupBox2.Controls, False)
        txtBuscarPor.Focus()
        Me.PuedeBuscar = True
        Me.PuedeEditar = True
        Me.PuedeCrear = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        btnEditar.Enabled = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        If gvResultBusq.DataRowCount > 0 Then
            GLimpiarControlesTotal(SaimtGroupBox2.Controls)
            btnEditar.Enabled = False
            btnGuardar.Enabled = True
            btnAgregar.Enabled = True
            codigoCargo = MantenimientosBL.Instancia.CargosNewCodigo(sCboInstitucion.EditValue, sCboArea.EditValue)
            Dim codigo As String = "000" & CInt(codigoCargo)
            txtCodigo.EditValue = codigo.Substring(Len(codigo) - 2, 2)
            sCboInstitucion.Properties.ReadOnly = True
            sCboArea.Properties.ReadOnly = True
            txtNombre.Properties.ReadOnly = False
            GEstadoNuevo = False
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Ha seleccionado la Institucion e Area")
        End If
    End Sub
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        GEstadoNuevo = True
        txtNombre.Properties.ReadOnly = False
        sCboArea.Properties.ReadOnly = True
        sCboInstitucion.Properties.ReadOnly = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim loTablaGeneral As EETablaGeneral = Nothing
            Dim loTablaGeneralSA As EETablaGeneral = New EETablaGeneral()
            Dim loClase As EEClase = Nothing
            Dim loClaseExtra As EEClase = Nothing
           
            If SaimtMessageBox.mostrarAlertaPregunta("¿Estas seguro que deseas guardar los nuevos cargos?") Then
                If GEstadoNuevo = True Then
                    loTablaGeneral = New EETablaGeneral()
                    loClase = New EEClase()
                    loClaseExtra = New EEClase()
                    loClase.ClsId = iClaseCargo
                    'loClaseExtra.ClsId = iClaseInstitucion
                    loTablaGeneral.TgId = txtCodigo.Tag
                    loTablaGeneral.TgNombre = txtNombre.Text
                    loTablaGeneral.TgExtra = sCboArea.Text & sCboInstitucion.EditValue
                    loTablaGeneral.TgCodigo = txtCodigo.Text
                    loTablaGeneral.TgActivo = chkEstado.Checked
                    loTablaGeneral.OClase = loClase
                    'loTablaGeneral.OClaseExtra = loClaseExtra
                    MantenimientosBL.Instancia.tablageneralUpdate(loTablaGeneral)
                Else
                    For Each fTablaGeneral As DataRow In dtTablaGeneral.Rows
                        loTablaGeneral = New EETablaGeneral()
                        loClase = New EEClase()
                        loClaseExtra = New EEClase()
                        If loTablaGeneralSA.ListaTablaGeneral Is Nothing Then
                            loTablaGeneralSA.ListaTablaGeneral = New List(Of EETablaGeneral)
                        End If
                        loClase.ClsId = iClaseCargo
                        loTablaGeneral.TgId = fTablaGeneral("tgId")
                        loTablaGeneral.TgNombre = fTablaGeneral("tgNombre")
                        loTablaGeneral.TgExtra = sCboArea.EditValue & sCboInstitucion.EditValue
                        loTablaGeneral.TgCodigo = fTablaGeneral("tgCodigo")
                        loTablaGeneral.TgActivo = fTablaGeneral("tgActivo")
                        loTablaGeneral.OClase = loClase
                        loTablaGeneral.OClaseExtra = loClaseExtra

                        loTablaGeneralSA.ListaTablaGeneral.Add(loTablaGeneral)
                    Next
                    loTablaGeneralSA.ListaTablaGeneralTemporalNuevos = ListaTemporalTablaGeneralNuevos
                    loTablaGeneralSA.ListaTablaGeneralTemporalEliminados = ListaTemporalTablaGeneralEliminados
                    MantenimientosBL.Instancia.tablageneralActualizar(loTablaGeneralSA)
                    ' Me.enabledGA = False
                    ListaTemporalTablaGeneralNuevos = Nothing
                    ListaTemporalTablaGeneralEliminados = Nothing
                    codigoCargo = Nothing
                    'listar()
                End If

                If Me.GEstadoNuevo Then
                    'mostrarAlertaInformativa("Se Guardo Correctamente");
                    mostrarMensajeBarra("Se Guardo Correctamente")
                Else
                    'mostrarAlertaInformativa("Se Actualizo Correctamente");
                    mostrarMensajeBarra("Se Actualizo Correctamente")
                End If
                Me.GEstadoNuevo = False
                btnEditar.Enabled = False
                btnGuardar.Enabled = False
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub txtBuscarPor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarPor.KeyPress
        If e.KeyChar = ChrW(13) Then
            Try
                GValorTextoBuscado = txtBuscarPor.EditValue
                Dim Lista As List(Of EETablaGeneral)
                Lista = MantenimientosBL.Instancia.tablageneralListarXClsId1_IN_ClsId2_ListarCriterio(iClaseArea, iClaseInstitucion, 1, txtBuscarPor.EditValue)
                dtListado.Clear()
                If Lista IsNot Nothing Then
                    For Each frow As EETablaGeneral In Lista
                        Dim lst As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(iClaseInstitucion, frow.TgExtra)
                        Dim a, b, c As String
                        a = String.Empty
                        b = String.Empty
                        c = String.Empty
                        If lst IsNot Nothing Then
                            b = lst.Item(0).TgNombre
                            a = lst.Item(0).TgAbrev
                            c = lst.Item(0).TgCodigo
                        End If
                        dtListado.LoadDataRow(New Object() {frow.TgNombre, frow.TgCodigo, a, b, c}, True)
                    Next
                Else
                    SaimtMessageBox.mostrarAlertaAdvertencia("No se encontratos áreas asignada a la institución que intenta buscar")
                End If
                gvResultBusq.BestFitColumns()
                gvResultBusq.CollapseAllGroups()
                ' dgvListado_Click(Nothing, Nothing)
                ' MyBase.Buscar()
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub gvResultBusq_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvResultBusq.FocusedRowChanged
        gvResultBusq_Click()
    End Sub

    Private Sub gvTablaGeneral_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTablaGeneral.FocusedRowChanged
        gvTablaGeneral_Click()
    End Sub
End Class