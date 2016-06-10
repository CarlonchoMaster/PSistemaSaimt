Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls

Public Class frmPersona
    Dim dtTablaContacto As DataTable = New DataTable()
    Dim dtListadoPersona As DataTable = New DataTable()
    Dim RefPersona As String = 108
    Dim VPerRef As String = "00"
    Dim VperId As String = Nothing
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Sub New(ByVal PerRef As String, Optional ByVal perId As String = Nothing)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        VPerRef = PerRef
        VperId = perId
    End Sub

#Region "Construir Table Persona Listado"
    Private Sub ConstruirTablePersonaListado()
        dtListadoPersona.Columns.Add("PerId", GetType(String))
        dtListadoPersona.Columns.Add("Persona", GetType(String))
        dtListadoPersona.Columns.Add("TipoDocumento", GetType(String))
        dtListadoPersona.Columns.Add("TipoPersona", GetType(String))
        dtListadoPersona.Columns.Add("Referencia", GetType(String))
    End Sub
#End Region

#Region "Construir Table Contacto"
    Private Sub ConstruirTableContacto()
        dtTablaContacto.Columns.Add("Descripcion", GetType(String))
        dtTablaContacto.Columns.Add("Contacto", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvResultados.DataRowCount <> 0 Then

                Dim loPersona As EEPersona = MantenimientosBL.Instancia.personaListarXPerId(gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "PerId").ToString())
                If loPersona IsNot Nothing Then
                    cboTipoPersona.EditValue = loPersona.TgTipoPersId
                    cboTipoDocumento.EditValue = loPersona.TgTipoDoc
                    txtNroDocumento.Text = loPersona.PerNDoc

                    If loPersona.TgTipoPersId = "J" Then
                        txtNombreRazon.Text = loPersona.PerRazonSocial
                        txtApMaterno.Text = String.Empty
                        txtApPaterno.Text = String.Empty
                    Else
                        txtNombreRazon.Text = loPersona.PerNombres
                        txtApMaterno.Text = loPersona.PerApeMaterno
                        txtApPaterno.Text = loPersona.PerApePaterno
                    End If
                    dtpFechaNac.EditValue = loPersona.PerFechaNac
                    cboGenero.EditValue = loPersona.TgGeneroId
                    txtDireccion.Text = loPersona.PerDireccion
                    cboDepartamento.EditValue = loPersona.OUbigeo.UbgDep
                    cboProvincia.EditValue = loPersona.OUbigeo.UbgProv
                    cboDistrito.EditValue = loPersona.OUbigeo.UbgDist
                    chkActivo.Checked = loPersona.PerActivo
                    txtObservacion.Text = loPersona.PerObservacion
                    cboRefPersona.EditValue = IIf(loPersona.PerRef = Nothing, VPerRef, loPersona.PerRef)
                    dtTablaContacto.Rows.Clear()

                    For Each fContacto As EEPersona.EEContacto In loPersona.ListaContacto
                        dtTablaContacto.LoadDataRow(New Object() {fContacto.ContDescripcion, _
                             fContacto.OTablaGeneral.TgCodigo
                           }, True)

                    Next
                    gvDatosAdicionales.BestFitColumns()
                    If loPersona.OPerConyuge IsNot Nothing Then
                        txtConyugue.Text = String.Format("{0} {1} {2}", loPersona.OPerConyuge.PerApePaterno, loPersona.OPerConyuge.PerApeMaterno, loPersona.OPerConyuge.PerNombres)
                        txtConyugue.Tag = loPersona.PerIdConyuge
                    Else
                        With txtConyugue
                            .Text = String.Empty
                            .Tag = String.Empty
                        End With
                    End If

                    txtCodigoPersona.Text = loPersona.PerId
                    GIdRegistroActual = loPersona.PerId
                    MyBase.seleccionarListado()
                End If
                
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        'VALIDACIONES
        If String.IsNullOrEmpty(cboTipoPersona.EditValue) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Tipo de Persona")
            cboTipoPersona.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(cboTipoDocumento.EditValue) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Tipo de Documento")
            cboTipoDocumento.Focus()
            Exit Sub
        End If

        'If cboTipoDocumento.EditValue.Equals("0") Then
        '    SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Tipo Documento Valido" & Environment.NewLine & "Diferente a " & cboTipoDocumento.Text)
        '    cboTipoDocumento.Focus()
        '    Exit Sub
        'End If

        'If String.IsNullOrEmpty(txtNroDocumento.Text) Then
        '    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Número de Documento")
        '    txtNroDocumento.Focus()
        '    Exit Sub
        'End If

        If cboTipoPersona.EditValue.Equals("N") Then
            If String.IsNullOrEmpty(txtNombreRazon.Text) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Nombre es Obligatorio")
                txtNombreRazon.Focus()
                Exit Sub
            End If
            If String.IsNullOrEmpty(txtApPaterno.Text) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Apellido Paterno es Obligatorio")
                txtApPaterno.Focus()
                Exit Sub
            End If
            If String.IsNullOrEmpty(txtApMaterno.Text) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Apellido Materno es Obligatorio")
                txtApMaterno.Focus()
                Exit Sub
            End If
        ElseIf cboTipoPersona.EditValue.Equals("J") Then
            If String.IsNullOrEmpty(txtNombreRazon.Text) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("La Razon Social es Obligatorio")
                txtNombreRazon.Focus()
                Exit Sub
            End If
        End If
        'FIN VALIDACIONES

        Try
            Dim loPersona As EEPersona = New EEPersona()
            Dim loUbigeo As EEUbigeo = New EEUbigeo()
            loUbigeo.UbgDep = cboDepartamento.EditValue
            loUbigeo.UbgDist = cboDistrito.EditValue
            loUbigeo.UbgProv = cboProvincia.EditValue

            loPersona.PerId = GIdRegistroActual
            loPersona.PerActivo = chkActivo.Checked
            loPersona.PerDireccion = txtDireccion.Text
            loPersona.PerObservacion = txtObservacion.Text
            loPersona.OUbigeo = loUbigeo
            loPersona.TgTipoPersId = cboTipoPersona.EditValue
            loPersona.TgTipoDoc = cboTipoDocumento.EditValue
            loPersona.PerNDoc = txtNroDocumento.Text
            loPersona.PerRef = cboRefPersona.EditValue
            loPersona.PerFechaNac = dtpFechaNac.EditValue
            loPersona.TgGeneroId = cboGenero.EditValue

            If cboTipoPersona.EditValue = "J" Then
                loPersona.PerRazonSocial = txtNombreRazon.Text
            Else
                loPersona.PerApeMaterno = txtApMaterno.Text
                loPersona.PerApePaterno = txtApPaterno.Text
                loPersona.PerIdConyuge = IIf(txtConyugue.Tag = "", Nothing, txtConyugue.Tag)
                loPersona.PerNombres = txtNombreRazon.Text
            End If

            For Each fTablaContacto As DataRow In dtTablaContacto.Rows
                Dim loContacto As EEPersona.EEContacto = New EEPersona.EEContacto()
                Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = fTablaContacto("Contacto")
                loContacto.ContDescripcion = fTablaContacto("Descripcion")
                loContacto.OTablaGeneral = loTablaGeneral

                loPersona.ListaContacto.Add(loContacto)
            Next

            If GEstadoNuevo Then
                If MantenimientosBL.Instancia.personaValidarHomonimia(loPersona) Then
                    If SaimtMessageBox.mostrarAlertaPregunta("El Nombre de la Persona ya Existe. Desea Guardar de Todos Modos") Then
                        MantenimientosBL.Instancia.personaGuardar(loPersona)
                    End If
                Else
                    MantenimientosBL.Instancia.personaGuardar(loPersona)
                End If
            Else
                MantenimientosBL.Instancia.personaActualizar(loPersona)
            End If
            Me.enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            dtListadoPersona.Rows.Clear()
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterios.SelectedIndex

            If lbMarcaDatosAdicionales = True Then
                GValorTextoBuscado = cboBuscarPor.EditValue & txtBuscarPor.Text
            End If

            Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaListarCriterio(cboCriterios.SelectedIndex, GValorTextoBuscado)
            If ListaPersona IsNot Nothing Then
                For Each fPersona As EEPersona In ListaPersona
                    dtListadoPersona.LoadDataRow(New Object() {fPersona.PerId, _
                         fPersona.Persona, _
                         fPersona.TgTipoDoc, _
                         fPersona.TgTipoPersona, _
                         fPersona.PerRef
                       }, True)
                Next
                gvResultados.BestFitColumns()
                gvResultados.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub listar()
        Try
            dtListadoPersona.Rows.Clear()
            Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            If ListaPersona IsNot Nothing Then
                For Each fPersona As EEPersona In ListaPersona
                    dtListadoPersona.LoadDataRow(New Object() {fPersona.PerId, _
                         fPersona.Persona, _
                         fPersona.TgTipoDoc, _
                         fPersona.TgTipoPersona, _
                         fPersona.PerRef
                       }, True)
                Next
                gvResultados.BestFitColumns()
                gvResultados.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.listar()
            Me.gvResultados.FocusedRowHandle = GIndiceSeleccionado
            dgvListado_Click(Nothing, Nothing)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub eliminar()
        Try
            MantenimientosBL.Instancia.personaEliminar(GIdRegistroActual)
            MyBase.eliminar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        dtTablaContacto.Rows.Clear()
        MyBase.nuevo()
        'cboTipoPersona.ItemIndex = 0
        cboTipoDocumento.ItemIndex = 0
        cboDepartamento.ItemIndex = 0
        txtConyugue.Properties.ReadOnly = True
        txtNroDocumento.Properties.ReadOnly = True
        txtCodigoPersona.Properties.ReadOnly = True
        'txtRuc.Enabled = False
        btnLimpiarConyuge.Enabled = False
        btnConsultarConyuge.Enabled = False
        cboTipoPersona.Properties.ReadOnly = False
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        'cboTipoPersona.Properties.ReadOnly = True
        txtConyugue.Properties.ReadOnly = True
        txtNroDocumento.Properties.ReadOnly = False
        txtCodigoPersona.Properties.ReadOnly = True
        If cboTipoPersona.EditValue = "N" Then
            'txtRuc.Enabled = False
        ElseIf cboTipoPersona.EditValue = "J" Then
            btnLimpiarConyuge.Enabled = False
            btnConsultarConyuge.Enabled = False
        End If
    End Sub
#End Region

#Region "Load"
    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PuedeBuscar = True
            Me.PuedeCrear = True
            Me.PuedeEditar = True
            Me.PuedeExportar = True
            Me.PuedeImprimir = True
            cboTipoPersona.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoPersona.Properties.DisplayMember = "TgNombre"
            cboTipoPersona.Properties.ValueMember = "TgCodigo"
            cboTipoPersona.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(6)
            cboTipoPersona.ItemIndex = 0

            cboDepartamento.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
            cboDepartamento.Properties.DisplayMember = "UbgNombre"
            cboDepartamento.Properties.ValueMember = "UbgDep"
            cboDepartamento.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarDepartamentoALL()
            cboDepartamento.ItemIndex = 0

            cboTipoDocumento.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoDocumento.Properties.DisplayMember = "TgNombre"
            cboTipoDocumento.Properties.ValueMember = "TgCodigo"
            cboTipoDocumento.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(4)
            cboTipoDocumento.ItemIndex = 0

            cboRefPersona.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboRefPersona.Properties.DisplayMember = "TgNombre"
            cboRefPersona.Properties.ValueMember = "TgCodigo"
            cboRefPersona.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(RefPersona)
            cboRefPersona.EditValue = VPerRef
            cboRefPersona.Enabled = False

            cboGenero.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboGenero.Properties.DisplayMember = "TgNombre"
            cboGenero.Properties.ValueMember = "TgCodigo"
            cboGenero.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(142)

            ConstruirTableContacto()
            ConstruirTablePersonaListado()
            dgvDatosAdicionales.DataSource = dtTablaContacto
            dgvListadoPersona.DataSource = dtListadoPersona
            'mGSetearTool(rdbCriterios, "Criterios", "- Apellidos y Nombres o Razón Social." & Environment.NewLine & "- RUC." & Environment.NewLine & "- DNI.")

            mAgregarComboContacto()
            cboBuscarPor.Properties.ReadOnly = True

            If VperId IsNot Nothing Then
                cboCriterios.SelectedIndex = 5
                txtBuscarPor.Text = VperId
                Buscar()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub cboDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.EditValueChanged
        Dim lsUbgDep As String = cboDepartamento.EditValue
        cboProvincia.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboProvincia.Properties.DisplayMember = "UbgNombre"
        cboProvincia.Properties.ValueMember = "UbgProv"
        cboProvincia.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarProvinciaXUbgDep(lsUbgDep)
        cboProvincia.ItemIndex = 0
    End Sub

    Private Sub cboProvincia_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.EditValueChanged
        Dim lsUbgDep As String = cboDepartamento.EditValue
        Dim lsUbgProv As String = cboProvincia.EditValue
        cboDistrito.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboDistrito.Properties.DisplayMember = "UbgNombre"
        cboDistrito.Properties.ValueMember = "UbgDist"
        cboDistrito.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarDistritoXUbgDepXUbgProv(lsUbgDep, lsUbgProv)
        cboDistrito.ItemIndex = 0
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        dtTablaContacto.Rows.Add()
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        If Me.gvDatosAdicionales.DataRowCount <> 0 Then
            dtTablaContacto.Rows.RemoveAt(Me.gvDatosAdicionales.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaError("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub cboTipoPersona_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoPersona.EditValueChanged
        If cboTipoPersona.EditValue = "N" Then
            btnLimpiarConyuge.Enabled = True
            btnConsultarConyuge.Enabled = True
        ElseIf cboTipoPersona.EditValue = "J" OrElse cboTipoPersona.EditValue = "0" Then
            btnLimpiarConyuge.Enabled = False
            btnConsultarConyuge.Enabled = False
        End If
    End Sub

    Private Sub btnConsultarConyuge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarConyuge.Click
        Dim fmConsultaConyuge As frmConsultaConyuge = New frmConsultaConyuge()

        If fmConsultaConyuge.ShowDialog() = DialogResult.OK Then
            txtConyugue.Text = fmConsultaConyuge.PerConyuge
            txtConyugue.Tag = fmConsultaConyuge.PerId
        End If
    End Sub

    Private Sub btnLimpiarConyuge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarConyuge.Click
        With txtConyugue
            .Text = String.Empty
            .Tag = String.Empty
        End With
    End Sub

#Region "Agregar Combo A Grilla"
    Private Sub mAgregarComboContacto()
        Dim RepositorioItemsContacto As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim dtComboContacto As DataTable = New DataTable
        dtComboContacto.Columns.Add("TgNombre", GetType(String))
        dtComboContacto.Columns.Add("TgCodigo", GetType(String))

        dtComboContacto.Columns("TgNombre").Caption = "Nombre"
        dtComboContacto.Columns("TgCodigo").Caption = "Codigo"
        dtComboContacto.Columns("TgCodigo").ColumnMapping = MappingType.Hidden

        For Each fTg As EETablaGeneral In MantenimientosBL.Instancia.tablageneralListarXClsId(15)
            dtComboContacto.Rows.Add(fTg.TgNombre, fTg.TgCodigo)
        Next

        With RepositorioItemsContacto
            .DisplayMember = "TgNombre"
            .ValueMember = "TgCodigo"
            .DataSource = dtComboContacto
            .NullText = "<<Seleccione>>"
        End With

        colContacto.ColumnEdit = RepositorioItemsContacto
        RepositorioItemsContacto.BestFit()
    End Sub
#End Region

    Private Sub cboTipoDocumento_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoDocumento.EditValueChanged
        If cboTipoDocumento.EditValue.Equals("0") Then
            txtNroDocumento.Properties.ReadOnly = True
            txtNroDocumento.Text = String.Empty
        Else
            txtNroDocumento.Properties.ReadOnly = False
        End If
    End Sub

    ''' <summary>
    ''' False = No Busca Datos Adicionales , True = Si
    ''' </summary>
    ''' <remarks></remarks>
    Dim lbMarcaDatosAdicionales As Boolean = False
    Private Sub cboCriterios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCriterios.SelectedIndexChanged
        cboBuscarPor.Properties.ReadOnly = False
        GValorTextoBuscado = Nothing
        txtBuscarPor.Text = String.Empty

        If cboCriterios.SelectedIndex = 1 Then
            cboBuscarPor.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboBuscarPor.Properties.DisplayMember = "TgNombre"
            cboBuscarPor.Properties.ValueMember = "TgCodigo"
            cboBuscarPor.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(4)
            cboBuscarPor.ItemIndex = 0
        ElseIf cboCriterios.SelectedIndex = 3 Then
            cboBuscarPor.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboBuscarPor.Properties.DisplayMember = "TgNombre"
            cboBuscarPor.Properties.ValueMember = "TgCodigo"
            cboBuscarPor.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(6)
            cboBuscarPor.ItemIndex = 0
        ElseIf cboCriterios.SelectedIndex = 4 Then
            cboBuscarPor.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboBuscarPor.Properties.DisplayMember = "TgNombre"
            cboBuscarPor.Properties.ValueMember = "TgCodigo"
            cboBuscarPor.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(15)
            cboBuscarPor.ItemIndex = 0
        End If

        If cboCriterios.SelectedIndex = 3 Then
            txtBuscarPor.Properties.ReadOnly = True
            GCriterioBuscado = cboCriterios.SelectedIndex
            GValorTextoBuscado = cboBuscarPor.EditValue
            listar()
            lbMarcaDatosAdicionales = False
        ElseIf cboCriterios.SelectedIndex = 1 OrElse cboCriterios.SelectedIndex = 4 Then
            txtBuscarPor.Properties.ReadOnly = False
            lbMarcaDatosAdicionales = True
        Else
            cboBuscarPor.Properties.ReadOnly = True
            cboBuscarPor.Properties.DataSource = Nothing
            cboBuscarPor.ItemIndex = -1
            txtBuscarPor.Properties.ReadOnly = False
            GCriterioBuscado = cboCriterios.SelectedIndex
            GValorTextoBuscado = cboBuscarPor.EditValue
            listar()
        End If
    End Sub

    Private Sub cboBuscarPor_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboBuscarPor.EditValueChanged
        If GValorTextoBuscado IsNot Nothing Then
            GCriterioBuscado = cboCriterios.SelectedIndex
            GValorTextoBuscado = cboBuscarPor.EditValue
            listar()
        End If
    End Sub

    Private Sub gvResultados_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvResultados.CustomRowCellEditForEditing
        seleccionarListado()
    End Sub

    Private Sub gvDatosAdicionales_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDatosAdicionales.CellValueChanged
        gvDatosAdicionales.BestFitColumns()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

    End Sub
End Class
