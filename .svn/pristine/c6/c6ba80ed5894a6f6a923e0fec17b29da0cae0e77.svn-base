Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmConsultorMargesiXItem
    Inherits frmConsultas
    Dim oTable As DataTable = New DataTable()
    Dim oTableGRubros As DataTable = New DataTable()
    Dim oTableRubros As DataTable = New DataTable()
    Public Property InmId() As String
    Public Property SQlString() As String

#Region "Construir Table"
    Private Sub ConstruirTable()
        oTable.Columns.Add("inmFile", GetType(String))
        oTable.Columns.Add("inmFileAnt", GetType(String))
        oTable.Columns.Add("inmUbicacion", GetType(String))
        oTable.Columns.Add("inmInscrito", GetType(String))
        oTable.Columns.Add("inmDenominacion", GetType(String))
        oTable.Columns.Add("tgInmCondReg", GetType(String))
        oTable.Columns.Add("inmPartidaElec", GetType(String))
        oTable.Columns.Add("tgInmCondLegal", GetType(String))
        oTable.Columns.Add("tgEstSan", GetType(String))
        oTable.Columns.Add("tgInmSitFisica", GetType(String))
        oTable.Columns.Add("tgInmSFUso", GetType(String))
        oTable.Columns.Add("tgEstInmConsv", GetType(String))
        oTable.Columns.Add("inmDisponibilidad", GetType(String))
        oTable.Columns.Add("inmId", GetType(String))
        oTable.Columns.Add("TgRubro", GetType(String))
        oTable.Columns.Add("InmPredArea", GetType(Decimal))
        oTable.Columns.Add("InmValComValxMetro", GetType(String))
        oTable.Columns.Add("InmValComValTerreno", GetType(String))
        oTable.Columns.Add("InmValComValConst", GetType(String))
        oTable.Columns.Add("InmValComValTotal", GetType(String))
        oTable.Columns.Add("InmSaneadoObsMostrable", GetType(String))
        oTable.Columns.Add("tgInmEstado", GetType(String))
    End Sub

    Private Sub ConstruirTableRubros()
        oTableRubros.Columns.Add("TgCodigo", GetType(String))
        oTableRubros.Columns.Add("TgNombre", GetType(String))
    End Sub
    Private Sub ConstruirTableGRubros()
        oTableGRubros.Columns.Add("TgCodigo", GetType(String))
        oTableGRubros.Columns.Add("TgNombre", GetType(String))
    End Sub
#End Region

    Private Sub frmConsultaInmuebleXCriterio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  
        EEComun.CargarTablasGenerales(MantenimientosBL.Instancia.tablageneralListarXClasesId("1,32,33,169,170,172"))

        cboRubroGrupos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRubroGrupos.Properties.DisplayMember = "TgNombre"
        cboRubroGrupos.Properties.ValueMember = "TgCodigo"
        cboRubroGrupos.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgRubrosGrupos, True)

        cboGRubroFile.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboGRubroFile.Properties.DisplayMember = "TgNombre"
        cboGRubroFile.Properties.ValueMember = "TgCodigo"
        cboGRubroFile.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgRubrosGrupos, True)
        cboGRubroFile.ItemIndex = 0

        cboGRubroDenominacionReferencia.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboGRubroDenominacionReferencia.Properties.DisplayMember = "TgNombre"
        cboGRubroDenominacionReferencia.Properties.ValueMember = "TgCodigo"
        cboGRubroDenominacionReferencia.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgRubrosGrupos, True)
        cboGRubroDenominacionReferencia.ItemIndex = 0

        cboDepartamento.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboDepartamento.Properties.DisplayMember = "UbgNombre"
        cboDepartamento.Properties.ValueMember = "UbgDep"
        cboDepartamento.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarDepartamentoALL()
        cboDepartamento.EditValue = "13"
        cboDepartamento.Properties.ReadOnly = True
        '

        cboSubDistritos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSubDistritos.Properties.DisplayMember = "TgNombre"
        cboSubDistritos.Properties.ValueMember = "TgCodigo"
        cboSubDistritos.Properties.DataSource = EEComun.DtByClsId(172) ' Tipo Urbanizaciones
        cboSubDistritos.ItemIndex = 0


        cboLocalizacion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboLocalizacion.Properties.DisplayMember = "TgNombre"
        cboLocalizacion.Properties.ValueMember = "TgCodigo"
        cboLocalizacion.Properties.DataSource = EEComun.DtByClsId(1) ' Localizacion
        cboLocalizacion.ItemIndex = 0

        cboTipoNro.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoNro.Properties.DisplayMember = "TgNombre"
        cboTipoNro.Properties.ValueMember = "TgCodigo"
        cboTipoNro.Properties.DataSource = EEComun.DtByClsId(169) ' Tipo Nro
        cboTipoNro.ItemIndex = 0

        cboTipoSubNro.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoSubNro.Properties.DisplayMember = "TgNombre"
        cboTipoSubNro.Properties.ValueMember = "TgCodigo"
        cboTipoSubNro.Properties.DataSource = EEComun.DtByClsId(170) ' Tipo Sub Nro
        cboTipoSubNro.ItemIndex = 0

        rbopcion1.Checked = True
        rbtipodireccion.SelectedIndex = 0

        ConstruirTable()
        dgvResultado.DataSource = oTable

        cboLocalizacion.EditValue = "00"
        cboTipoNro.EditValue = "00"
        cboTipoSubNro.EditValue = "00"
        cboSubDistritos.EditValue = "00"
    End Sub

    Protected Overrides Sub buscar()
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As New EEInmueble
        Dim criterio As String = Nothing
        If rbopcion1.Checked = True Then
            criterio = 0 & rbtipodireccion.EditValue
            If cboLocalizacion.EditValue <> "00" And txtLocalizacion.EditValue = "" Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor para " & cboLocalizacion.Text)
                txtLocalizacion.Focus()
                Return
            End If
            If cboTipoNro.EditValue <> "00" And txtNroUbicacion.EditValue = "" Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor en el para " & cboTipoNro.Text)
                txtNroUbicacion.Focus()
                Return
            End If
            If cboTipoSubNro.EditValue <> "00" And txtSubNro.EditValue = "" Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor en el para " & cboTipoSubNro.Text)
                txtSubNro.Focus()
                Return
            End If
            loInmueble.TgRubroId = IIf(cboRubro.EditValue = 0, Nothing, cboRubro.EditValue)
            loInmueble.TgRubroGrupoId = IIf(cboRubroGrupos.EditValue = 0, Nothing, cboRubroGrupos.EditValue)

            If chkCriteriosInmEstado1.Checked = True And chkBajas1.Checked = True Then
                loInmueble.TgInmEstado = "01"
                loInmueble.TgInmEstado2 = "03"
            Else
                If chkCriteriosInmEstado1.Checked = True Then
                    loInmueble.TgInmEstado = "01"
                Else
                    loInmueble.TgInmEstado = Nothing
                End If
            End If

            loInmueble.OInmDireccion = New EEInmDireccion
            loInmueble.OInmDireccion.TgLocalizacionId = IIf(cboLocalizacion.EditValue = "00", Nothing, cboLocalizacion.EditValue)
            loInmueble.OInmDireccion.InmDirLocalizacion = IIf(txtLocalizacion.Text = "", Nothing, txtLocalizacion.Text)
            loInmueble.OInmDireccion.InmDirAdicional = IIf(txtdireccionAdicional.Text = "", Nothing, txtdireccionAdicional.Text)
            loInmueble.OInmDireccion.TgNroId = IIf(cboTipoNro.EditValue = "00", Nothing, cboTipoNro.EditValue)
            loInmueble.OInmDireccion.InmDirNro = IIf(txtNroUbicacion.EditValue = "", Nothing, txtNroUbicacion.EditValue)
            loInmueble.OInmDireccion.TgSubNroId = IIf(cboTipoSubNro.EditValue = "00", Nothing, cboTipoSubNro.EditValue)
            loInmueble.OInmDireccion.InmDirSubNro = IIf(txtSubNro.EditValue = "", Nothing, txtSubNro.EditValue)
            loInmueble.OInmDireccion.InmDirSubDistritos = IIf(IIf(txtsubdistritoscbo.Visible = True, txtsubdistritoscbo.EditValue, txtsubdistritoText.EditValue) = "", Nothing, IIf(txtsubdistritoscbo.Visible = True, txtsubdistritoscbo.EditValue, txtsubdistritoText.EditValue))
            loInmueble.OInmDireccion.TgSubDistritosId = IIf(cboSubDistritos.EditValue = "00", Nothing, cboSubDistritos.EditValue)
            loInmueble.OInmDireccion.InmDirEtapa = IIf(txtEtapa.EditValue = "", Nothing, txtEtapa.EditValue)
            loInmueble.OInmDireccion.InmDirFase = IIf(txtFase.EditValue = "", Nothing, txtFase.EditValue)
            loInmueble.OInmDireccion.InmDirBarrio = IIf(txtBarrio.EditValue = "", Nothing, txtBarrio.EditValue)
            loInmueble.OInmDireccion.InmDirSector = IIf(txtSector.EditValue = "", Nothing, txtSector.EditValue)
            loInmueble.OInmDireccion.UbgId = cboDepartamento.EditValue & cboProvincia.EditValue & cboDistrito.EditValue
        ElseIf rbopcion2.Checked = True Then
            criterio = 2
            If cboCriterioFile.SelectedIndex >= 2 And txtFile.EditValue = "" Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor en el para " & cboCriterioFile.Text)
                txtFile.Focus()
                Return
            End If
            loInmueble.TgRubroId = IIf(cboRubroFile.EditValue = 0, Nothing, cboRubroFile.EditValue)
            loInmueble.TgRubroGrupoId = IIf(cboGRubroFile.EditValue = 0, Nothing, cboGRubroFile.EditValue)

            If chkCriteriosInmEstado2.Checked = True And chkBajas2.Checked = True Then
                loInmueble.TgInmEstado = "01"
                loInmueble.TgInmEstado2 = "03"
            Else
                If chkCriteriosInmEstado2.Checked = True Then
                    loInmueble.TgInmEstado = "01"
                Else
                    loInmueble.TgInmEstado = Nothing
                End If
            End If

            loInmueble.InmFile = IIf(cboCriterioFile.SelectedIndex = 2, txtFile.Text, Nothing)
            loInmueble.InmFileAnt = IIf(cboCriterioFile.SelectedIndex = 3, txtFile.Text, Nothing)
        ElseIf rbopcion3.Checked = True Then
            criterio = "02"
            If cboCriterioDenominacionReferencia.SelectedIndex = 0 And txtCriterioDenominacionReferencia.EditValue = "" Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor en el para " & txtCriterioDenominacionReferencia.Text)
                txtFile.Focus()
                Return
            End If
            loInmueble.InmDenominacion = IIf(cboCriterioDenominacionReferencia.SelectedIndex = 1, txtCriterioDenominacionReferencia.Text, Nothing)
            loInmueble.OInmDireccion = New EEInmDireccion
            loInmueble.OInmDireccion.InmDirReferencia = IIf(cboCriterioDenominacionReferencia.SelectedIndex = 2, txtCriterioDenominacionReferencia.Text, Nothing)
            loInmueble.TgRubroId = IIf(cboRubroDenominacionReferencia.EditValue = 0, Nothing, cboRubroDenominacionReferencia.EditValue)
            loInmueble.TgRubroGrupoId = IIf(cboGRubroDenominacionReferencia.EditValue = 0, Nothing, cboGRubroDenominacionReferencia.EditValue)

            If chkCriteriosInmEstado3.Checked = True And chkBajas3.Checked = True Then
                loInmueble.TgInmEstado = "01"
                loInmueble.TgInmEstado2 = "03"
            Else
                If chkCriteriosInmEstado3.Checked = True Then
                    loInmueble.TgInmEstado = "01"
                Else
                    loInmueble.TgInmEstado = Nothing
                End If
            End If
        End If
        ListaInmueble = MantenimientosBL.Instancia.inmuebleListarConsultaCriteriosxItem(criterio, loInmueble)
        Try
            oTable.Clear()
            If ListaInmueble IsNot Nothing Then
                For Each fInmueble As EEInmueble In ListaInmueble
                    oTable.LoadDataRow(New Object() {
                    String.Format("File {0} - {1}", fInmueble.InmFile, fInmueble.TgRubro), _
                    fInmueble.InmFileAnt, _
                    fInmueble.InmUbicacion, _
                    fInmueble.InmInscrito, _
                    fInmueble.InmDenominacion, _
                    fInmueble.tgInmCondReg, _
                    fInmueble.InmPartidaElec, _
                    fInmueble.TgInmCondLegal, _
                    fInmueble.tgEstSan, _
                    fInmueble.tgInmSitFisica, _
                    fInmueble.tgInmSFUso, _
                    fInmueble.tgEstInmConsv, _
                    IIf(fInmueble.InmDisponibilidad = False, "NO", "SI"), _
                    fInmueble.InmId, _
                    fInmueble.TgRubro, _
                    fInmueble.OInmPredio.InmPredArea, _
                    fInmueble.OInmValorComercial.InmValComValxMetro, _
                    fInmueble.OInmValorComercial.InmValComValTerreno, _
                    fInmueble.OInmValorComercial.InmValComValConst, _
                    fInmueble.OInmValorComercial.InmValComValTotal, _
                    fInmueble.inmSaneadoObsMostrable, _
                    fInmueble.TgInmEstado}, True)
                Next
                gvResultado.BestFitColumns()
                Me.Encontrado = True
            Else
                Me.Encontrado = False
            End If
            If Encontrado = False Then
                SaimtMessageBox.mostrarAlertaInformativa("No se encontro resultados")
            End If
            lblResultados.Text = oTable.Rows.Count & " Resultados de Busquedas"
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub seleccionar()
        If Me.gvResultado.DataRowCount <> 0 Then
            InmId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "inmId").ToString()
            Seleccionado = True
            Dim fmVisorInmuebles As frmVisorInmuebles = New frmVisorInmuebles(InmId)
            fmVisorInmuebles.MdiParent = Me.MdiParent
            fmVisorInmuebles.BringToFront()
            fmVisorInmuebles.Show()
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        Me.sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.gvResultado.ExportToXls(Me.sfdexportar.FileName)
        End If
    End Sub
    Private Sub cboDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.EditValueChanged
        Dim lsUbgDep As String = cboDepartamento.EditValue
        cboProvincia.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboProvincia.Properties.DisplayMember = "UbgNombre"
        cboProvincia.Properties.ValueMember = "UbgProv"
        cboProvincia.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarProvinciaXUbgDep(lsUbgDep)
        cboProvincia.EditValue = "01"
        cboProvincia.Properties.ReadOnly = True
    End Sub

    Private Sub cboProvincia_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.EditValueChanged
        Dim lsUbgDep As String = cboDepartamento.EditValue
        Dim lsUbgProv As String = cboProvincia.EditValue
        cboDistrito.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboDistrito.Properties.DisplayMember = "UbgNombre"
        cboDistrito.Properties.ValueMember = "UbgDist"
        cboDistrito.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarDistritoXUbgDepXUbgProv(lsUbgDep, lsUbgProv)
        cboDistrito.EditValue = "01"
    End Sub

    Private Sub cboRubroGrupos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRubroGrupos.EditValueChanged
        Dim lsTgExtra As String = cboRubroGrupos.EditValue
        cboRubro.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRubro.Properties.DisplayMember = "TgNombre"
        cboRubro.Properties.ValueMember = "TgCodigo"
        cboRubro.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgRubros, True, lsTgExtra)
        cboRubro.ItemIndex = 0
    End Sub

    Private Sub rbopcion1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbopcion1.CheckedChanged
        gbFile.Enabled = Not rbopcion1.Checked
        gbOtras.Enabled = Not rbopcion1.Checked
        btnLimpiar_Click(Nothing, Nothing)
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtLocalizacion.EditValue = Nothing
        txtNroUbicacion.EditValue = Nothing
        txtSubNro.EditValue = Nothing
        txtsubdistritoText.Text = Nothing
        cboLocalizacion.EditValue = "00"
        cboTipoNro.EditValue = "00"
        cboTipoSubNro.EditValue = "00"
        cboSubDistritos.EditValue = "00"
    End Sub

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton1.Click
        buscar()
    End Sub

    Private Sub rbopcion2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbopcion2.CheckedChanged
        gbdireccion.Enabled = Not rbopcion2.Checked
        gbOtras.Enabled = Not rbopcion2.Checked
        btnLimpiarFile_Click(Nothing, Nothing)
    End Sub

    Private Sub rbopcion3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbopcion3.CheckedChanged
        gbdireccion.Enabled = Not rbopcion3.Checked
        gbFile.Enabled = Not rbopcion3.Checked
        LimpiarOtras_Click(Nothing, Nothing)
    End Sub

    Private Sub cboSubDistritos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubDistritos.EditValueChanged
        If cboSubDistritos.EditValue IsNot Nothing Then
            txtsubdistritoscbo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            txtsubdistritoscbo.Properties.DisplayMember = "TgNombre"
            txtsubdistritoscbo.Properties.ValueMember = "TgCodigo"
            txtsubdistritoscbo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(171, Nothing, cboDistrito.EditValue, cboSubDistritos.EditValue)
            If txtsubdistritoscbo.Properties.DataSource IsNot Nothing Then

                txtsubdistritoscbo.Visible = True
                txtsubdistritoText.Visible = False
            Else
                txtsubdistritoscbo.Visible = False
                txtsubdistritoText.Visible = True
            End If
        End If
    End Sub

    Private Sub cboGRubroFile_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGRubroFile.EditValueChanged
        Dim lsTgExtra As String = cboGRubroFile.EditValue
        cboRubroFile.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRubroFile.Properties.DisplayMember = "TgNombre"
        cboRubroFile.Properties.ValueMember = "TgCodigo"
        cboRubroFile.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgRubros, True, lsTgExtra)
        cboRubroFile.ItemIndex = 0
    End Sub

    Private Sub btnLimpiarFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarFile.Click
        cboCriterioFile.SelectedIndex = 0
        txtFile.Text = Nothing
    End Sub

    Private Sub cboCriterioFile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriterioFile.SelectedIndexChanged
        If cboCriterioFile.SelectedIndex = 0 Or cboCriterioFile.SelectedIndex = 1 Then
            txtFile.Properties.ReadOnly = True
            txtFile.Text = Nothing
        Else
            txtFile.Properties.ReadOnly = False
        End If
    End Sub


    Private Sub SaimtButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton3.Click
        buscar()
    End Sub

    Private Sub cboGRubroDenominacionReferencia_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGRubroDenominacionReferencia.EditValueChanged

        Dim lsTgExtra As String = cboGRubroDenominacionReferencia.EditValue
        cboRubroDenominacionReferencia.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRubroDenominacionReferencia.Properties.DisplayMember = "TgNombre"
        cboRubroDenominacionReferencia.Properties.ValueMember = "TgCodigo"
        cboRubroDenominacionReferencia.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgRubros, True, lsTgExtra)
        cboRubroDenominacionReferencia.ItemIndex = 0
    End Sub

    Private Sub LimpiarOtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton2.Click
        cboCriterioDenominacionReferencia.SelectedIndex = 0
        txtCriterioDenominacionReferencia.Text = Nothing
    End Sub

End Class