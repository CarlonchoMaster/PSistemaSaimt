Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Public Class frmAreas
    Inherits frmGeneral
    Dim iClaseArea As Integer = 83
    Dim iClaseInstitucion As Integer = 82
    Dim dtTablaGeneral As DataTable = New DataTable()
    Dim itgCodigoIns As String
    Dim ListaTemporalTablaGeneralEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalTablaGeneralNuevos As List(Of EETablaGeneral) = Nothing
    Dim codigoArea As Integer
    Dim Editar As Boolean = False
    Dim dt_Listado As DataTable = New DataTable
    Private Sub ConstruirTableListado()
        dt_Listado.Columns.Add("tgSiglas", GetType(String))
        dt_Listado.Columns.Add("tgId", GetType(String))
        dt_Listado.Columns.Add("tgActivo", GetType(Boolean))
        dt_Listado.Columns.Add("tgInstitucionId", GetType(String))
        dt_Listado.Columns.Add("tgInstitucion", GetType(String))
    End Sub
#Region "Construir Table"
    Private Sub ConstruirTable()
        dtTablaGeneral.Columns.Add("tgId", GetType(Integer))
        dtTablaGeneral.Columns.Add("clsId", GetType(Integer))
        dtTablaGeneral.Columns.Add("tgNombre", GetType(String))
        dtTablaGeneral.Columns.Add("tgCodigo", GetType(String))
        dtTablaGeneral.Columns.Add("tgExtra", GetType(String))
        dtTablaGeneral.Columns.Add("tgAbrev", GetType(String))
        dtTablaGeneral.Columns.Add("tgActivo", GetType(Boolean))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Sub MostrarAreas(ByVal InstitucionId As String)
        dtTablaGeneral.Clear()
        Dim lstAreas As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(iClaseArea, InstitucionId)
        If lstAreas IsNot Nothing Then
            For Each frow As EETablaGeneral In lstAreas
                dtTablaGeneral.LoadDataRow(New Object() {frow.TgId, iClaseArea, frow.TgNombre, frow.TgCodigo, InstitucionId, frow.TgAbrev, frow.TgActivo}, True)
            Next
            gvTablaGeneral.BestFitColumns()
            gvTablaGeneral.SelectRow(0)
            dgvTablaGeneral_Click()
        End If

    End Sub
    Sub SeleccionarAreas()
        Try
            If Me.gvTablaGeneral.DataRowCount <> 0 Then
                txtNombre.Text = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgNombre").ToString()
                GIdRegistroActual = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgId").ToString()
                txtCodigo.Tag = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgId").ToString()
                txtSiglas.Text = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgAbrev").ToString()
                txtCodigo.Text = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgCodigo").ToString()
                chkEstado.Checked = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgActivo")
                sCboInstitucion.EditValue = gvTablaGeneral.GetRowCellValue(gvTablaGeneral.GetSelectedRows(0), "tgExtra").ToString
                btnEditar.Enabled = True
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    'Protected Overrides Sub listar()
    '    Try
    '        ' lstTablaGeneral.DisplayMember = "TgNombre"
    '        'lstTablaGeneral.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(iClaseInstitucion, GCriterioBuscado, GValorTextoBuscado)
    '        '  MyBase.listar()
    '    Catch ex As Exception
    '        SaimtMessageBox.mostrarAlertaError(ex.Message)
    '    End Try
    'End Sub

    Sub Buscar()
        Try
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = 1
            dt_Listado.Clear()
            dtTablaGeneral.Clear()
            Dim ListaInstituciones As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(iClaseInstitucion, 1, txtBuscarPor.Text)
            If ListaInstituciones IsNot Nothing Then

                For Each frow As EETablaGeneral In ListaInstituciones
                    dt_Listado.LoadDataRow(New Object() {frow.TgAbrev,
                                                         frow.TgId,
                                                         frow.TgActivo,
                                                        frow.TgCodigo,
                                                         frow.TgNombre
                                   }, True)
                Next
                gvResultadoBusqueda.BestFitColumns()
                gvResultadoBusqueda.SelectRow(0)
                dgvgvResultadoBusqueda_Click()

            End If
            '  MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

#End Region

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
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

        If String.IsNullOrEmpty(txtSiglas.Text) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Siglas")
            txtSiglas.Focus()
            Exit Sub
        End If
        Dim repite As Boolean = False
        For Each fTablaGeneral As DataRow In dtTablaGeneral.Rows
            If (fTablaGeneral("tgCodigo") = txtCodigo.EditValue) Or (fTablaGeneral("tgNombre") = txtNombre.EditValue) Then
                repite = True
            End If
        Next

        If repite = True Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Exite un elemento duplicado, verifique que le nombre, siglas o codigo del area no se repita")
            Return
        End If
        itgCodigoIns = sCboInstitucion.EditValue

        dtTablaGeneral.LoadDataRow(New Object() { _
            0, _
            iClaseArea, _
            txtNombre.Text, _
            txtCodigo.Text, _
            itgCodigoIns, _
            txtSiglas.Text, _
            chkEstado.Checked
        }, True)

        If ListaTemporalTablaGeneralNuevos Is Nothing Then
            ListaTemporalTablaGeneralNuevos = New List(Of EETablaGeneral)
        End If

        Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
        Dim loClase As EEClase = New EEClase()
        loClase.ClsId = iClaseArea

        loTablaGeneral.TgNombre = txtNombre.Text
        loTablaGeneral.TgExtra = sCboInstitucion.EditValue
        loTablaGeneral.TgCodigo = txtCodigo.Text
        loTablaGeneral.TgActivo = chkEstado.Checked
        loTablaGeneral.TgAbrev = txtSiglas.Text
        loTablaGeneral.OClase = loClase
        ListaTemporalTablaGeneralNuevos.Add(loTablaGeneral)
        codigoArea = CInt(txtCodigo.Text)
        txtNombre.EditValue = Nothing
        txtSiglas.EditValue = Nothing
        txtCodigo.EditValue = Nothing
        txtNombre.Focus()
    End Sub

    Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click
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


    Private Sub frmAreas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        ConstruirTableListado()
        dgvTablaGeneral.DataSource = dtTablaGeneral
        dgvResultadoBusqueda.DataSource = dt_Listado
        sCboInstitucion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        sCboInstitucion.Properties.DisplayMember = "TgNombre"
        sCboInstitucion.Properties.ValueMember = "TgCodigo"
        sCboInstitucion.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(iClaseInstitucion)
        sCboInstitucion.ItemIndex = 0
        Me.PuedeBuscar = True
        Me.PuedeEditar = True
        Me.PuedeCrear = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True

        hodControlesTotal(SaimtGroupBox3.Controls, False)
        btnEditar.Enabled = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub dgvgvResultadoBusqueda_Click()
        If gvResultadoBusqueda.DataRowCount > 0 Then
            MostrarAreas(gvResultadoBusqueda.GetRowCellValue(gvResultadoBusqueda.GetSelectedRows(0), "tgInstitucionId").ToString)
            sCboInstitucion.EditValue = gvResultadoBusqueda.GetRowCellValue(gvResultadoBusqueda.GetSelectedRows(0), "tgInstitucionId").ToString
            btnNuevo.Enabled = True
            btnEditar.Enabled = True
            btnGuardar.Enabled = False
            hodControlesTotal(SaimtGroupBox3.Controls, False)
        End If
    End Sub
    Private Sub dgvTablaGeneral_Click()
        If gvTablaGeneral.DataRowCount > 0 Then
            SeleccionarAreas()
            hodControlesTotal(SaimtGroupBox3.Controls, False)
        End If
    End Sub

    'Private Sub gvResultadoBusqueda_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvResultadoBusqueda.RowClick
    '    dgvgvResultadoBusqueda_Click()
    'End Sub

    'Private Sub gvResultadoBusqueda_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gvResultadoBusqueda.RowCellClick
    '    dgvgvResultadoBusqueda_Click()
    'End Sub

    'Private Sub gvTablaGeneral_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvTablaGeneral.RowClick
    '    dgvTablaGeneral_Click()
    'End Sub

    'Private Sub gvTablaGeneral_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gvTablaGeneral.RowCellClick
    '    dgvTablaGeneral_Click()
    'End Sub


    Private Sub txtBuscarPor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarPor.KeyPress
        If e.KeyChar = ChrW(13) Then
            Buscar()
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        If gvResultadoBusqueda.DataRowCount > 0 Then
            GLimpiarControlesTotal(SaimtGroupBox3.Controls)
            btnEditar.Enabled = False
            btnGuardar.Enabled = True
            btnAgregar.Enabled = True
            codigoArea = MantenimientosBL.Instancia.AreaNewCodigo(sCboInstitucion.EditValue)
            Dim codigo As String = "000" & CInt(codigoArea)
            txtCodigo.EditValue = codigo.Substring(Len(codigo) - 3, 3)
            sCboInstitucion.Properties.ReadOnly = True
            txtNombre.Properties.ReadOnly = False
            txtSiglas.Properties.ReadOnly = False
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Ha seleccionado la Institucion")
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim loTablaGeneral As EETablaGeneral = Nothing
            Dim loTablaGeneralSA As EETablaGeneral = New EETablaGeneral()
            Dim loClase As EEClase = Nothing
            Dim loClaseExtra As EEClase = Nothing
            If Editar = True Then
                loTablaGeneral = New EETablaGeneral()
                loClase = New EEClase()
                loClaseExtra = New EEClase()
                loClase.ClsId = iClaseArea
                loClaseExtra.ClsId = iClaseInstitucion
                loTablaGeneral.TgId = txtCodigo.Tag
                loTablaGeneral.TgNombre = txtNombre.Text
                loTablaGeneral.TgExtra = sCboInstitucion.EditValue
                loTablaGeneral.TgCodigo = txtCodigo.Text
                loTablaGeneral.TgActivo = chkEstado.Checked
                loTablaGeneral.TgAbrev = txtSiglas.Text
                loTablaGeneral.OClase = loClase
                loTablaGeneral.OClaseExtra = loClaseExtra
                MantenimientosBL.Instancia.tablageneralUpdate(loTablaGeneral)
            Else
                For Each fTablaGeneral As DataRow In dtTablaGeneral.Rows
                    loTablaGeneral = New EETablaGeneral()
                    loClase = New EEClase()
                    loClaseExtra = New EEClase()

                    If loTablaGeneralSA.ListaTablaGeneral Is Nothing Then
                        loTablaGeneralSA.ListaTablaGeneral = New List(Of EETablaGeneral)
                    End If
                    loClase.ClsId = iClaseArea
                    loClaseExtra.ClsId = iClaseInstitucion
                    loTablaGeneral.TgId = fTablaGeneral("tgId")
                    loTablaGeneral.TgNombre = fTablaGeneral("tgNombre")
                    loTablaGeneral.TgExtra = IIf(IsDBNull(fTablaGeneral("tgExtra")), Nothing, fTablaGeneral("tgExtra"))
                    loTablaGeneral.TgCodigo = fTablaGeneral("tgCodigo")
                    loTablaGeneral.TgActivo = fTablaGeneral("tgActivo")
                    loTablaGeneral.TgAbrev = IIf(IsDBNull(fTablaGeneral("tgAbrev")), Nothing, fTablaGeneral("tgAbrev"))
                    loTablaGeneral.OClase = loClase
                    loTablaGeneral.OClaseExtra = loClaseExtra

                    loTablaGeneralSA.ListaTablaGeneral.Add(loTablaGeneral)
                Next
                loTablaGeneralSA.ListaTablaGeneralTemporalNuevos = ListaTemporalTablaGeneralNuevos
                loTablaGeneralSA.ListaTablaGeneralTemporalEliminados = ListaTemporalTablaGeneralEliminados
                If MantenimientosBL.Instancia.tablageneralActualizar(loTablaGeneralSA) = True Then
                    SaimtMessageBox.mostrarAlertaInformativa("Se registro correctamente el área ingresada")
                Else
                    SaimtMessageBox.mostrarAlertaAdvertencia("No se pudo registrar correctamente los datos, favor de revisarlos")
                End If
                ListaTemporalTablaGeneralNuevos = Nothing
                ListaTemporalTablaGeneralEliminados = Nothing
                codigoArea = Nothing
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        Editar = True
        txtNombre.Properties.ReadOnly = False
        txtSiglas.Properties.ReadOnly = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        btnEditar.Enabled = True
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
    End Sub

    Private Sub gvResultadoBusqueda_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvResultadoBusqueda.FocusedRowChanged
        dgvgvResultadoBusqueda_Click()
    End Sub

    Private Sub gvTablaGeneral_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTablaGeneral.FocusedRowChanged
        dgvTablaGeneral_Click()
    End Sub
End Class
