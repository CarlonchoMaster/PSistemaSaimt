Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls

Public Class frmConceptos
    Dim dt_Conceptos As DataTable = New DataTable()
    Dim dt_ListaConceptos As DataTable = New DataTable()

#Region "Construir Table Persona Listado"
    Private Sub ConstruirTableConceptos()
        dt_ListaConceptos.Columns.Add("ConId", GetType(String))
        dt_ListaConceptos.Columns.Add("ConNombre", GetType(String))
        dt_ListaConceptos.Columns.Add("ConPorcentajeSAIMT", GetType(String))
        dt_ListaConceptos.Columns.Add("ConPorcentajeMPT", GetType(String))
        dt_ListaConceptos.Columns.Add("PcontCuenC", GetType(String))
        dt_ListaConceptos.Columns.Add("PcontCuenA", GetType(String))
        dt_ListaConceptos.Columns.Add("Partida", GetType(String))
        dt_ListaConceptos.Columns.Add("ConActivo", GetType(String))
        dt_ListaConceptos.Columns.Add("TgGrupoCon", GetType(String))
    End Sub

    Private Sub ConstruirTableBConceptos()
        dt_Conceptos.Columns.Add("ConId", GetType(String))
        dt_Conceptos.Columns.Add("ConNombre", GetType(String))
        dt_Conceptos.Columns.Add("TgGrupoCon", GetType(String))
        dt_Conceptos.Columns.Add("ConActivo", GetType(Boolean))
        dt_Conceptos.Columns.Add("ConAño", GetType(String))
       
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvResultados.DataRowCount <> 0 Then
                Dim loConcepto As EEConceptos = MantenimientosBL.Instancia.conceptosMostrarXConId(gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "ConId").ToString() & gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "ConAño").ToString())

                If loConcepto IsNot Nothing Then
                    txtConId.EditValue = loConcepto.ConId
                    txtPartida.EditValue = loConcepto.Partida
                    txtPartida.Tag = loConcepto.PartId
                    cboFuenteFinanciera.EditValue = loConcepto.TgCenProId
                    txtConcepto.EditValue = loConcepto.ConNombre
                    txtCuentaBancaria.EditValue = loConcepto.TgCueBanId
                    txtCuentaHaber.Tag = loConcepto.PcontCuenA
                    txtCuentaDebe.Tag = loConcepto.PcontCuenC
                    txtPorcSAIMT.Text = loConcepto.ConPorcentaje
                    txtCodContableMPT.Text = loConcepto.ConCodConMPT
                    txtCodPresupuestarioMPT.Text = loConcepto.ConCodPresMPT
                    txtCuentaHaber.Text = loConcepto.PcontCuenANombre
                    txtCuentaDebe.Text = loConcepto.PcontCuenCNombre

                    cboGrupoConcepto.EditValue = loConcepto.TgGrupoConId
                    chkActivo.Checked = loConcepto.ConActivo
                    txtBaseLegal.EditValue = loConcepto.ConBaseLegal
                    chkMora.EditValue = loConcepto.ConApliMora
                    cboAño.EditValue = loConcepto.ConAño
                    cboSubGrupoConcepto.EditValue = loConcepto.TgSubGrupoId
                    txtImporte.EditValue = loConcepto.ConImporte
                    GIdRegistroActual = loConcepto.ConId
                    MyBase.seleccionarListado()
                    txtPartida.Properties.ReadOnly = True
                    txtCuentaDebe.Properties.ReadOnly = True
                    txtCuentaHaber.Properties.ReadOnly = True
                End If

            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        ''VALIDACIONES
        'If String.IsNullOrEmpty(cboTipoPersona.EditValue) Then
        '    SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Tipo de Persona")
        '    cboTipoPersona.Focus()
        '    Exit Sub
        'End If

        'If String.IsNullOrEmpty(cboTipoDocumento.EditValue) Then
        '    SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Tipo de Documento")
        '    cboTipoDocumento.Focus()
        '    Exit Sub
        'End If

        ''If cboTipoDocumento.EditValue.Equals("0") Then
        ''    SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Tipo Documento Valido" & Environment.NewLine & "Diferente a " & cboTipoDocumento.Text)
        ''    cboTipoDocumento.Focus()
        ''    Exit Sub
        ''End If

        ''If String.IsNullOrEmpty(txtNroDocumento.Text) Then
        ''    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Número de Documento")
        ''    txtNroDocumento.Focus()
        ''    Exit Sub
        ''End If

        'If cboTipoPersona.EditValue.Equals("N") Then
        '    If String.IsNullOrEmpty(txtNombreRazon.Text) Then
        '        SaimtMessageBox.mostrarAlertaAdvertencia("El Nombre es Obligatorio")
        '        txtNombreRazon.Focus()
        '        Exit Sub
        '    End If
        '    If String.IsNullOrEmpty(txtApPaterno.Text) Then
        '        SaimtMessageBox.mostrarAlertaAdvertencia("El Apellido Paterno es Obligatorio")
        '        txtApPaterno.Focus()
        '        Exit Sub
        '    End If
        '    If String.IsNullOrEmpty(txtApMaterno.Text) Then
        '        SaimtMessageBox.mostrarAlertaAdvertencia("El Apellido Materno es Obligatorio")
        '        txtApMaterno.Focus()
        '        Exit Sub
        '    End If
        'ElseIf cboTipoPersona.EditValue.Equals("J") Then
        '    If String.IsNullOrEmpty(txtNombreRazon.Text) Then
        '        SaimtMessageBox.mostrarAlertaAdvertencia("La Razon Social es Obligatorio")
        '        txtNombreRazon.Focus()
        '        Exit Sub
        '    End If
        'End If
        ''FIN VALIDACIONES

        Try
            Dim loConcepto As EEConceptos = New EEConceptos()
            loConcepto.ConId = txtConId.Text

            loConcepto.PartId = txtPartida.Tag
            loConcepto.TgCenProId = cboFuenteFinanciera.EditValue
            loConcepto.ConNombre = txtConcepto.EditValue
            loConcepto.TgCueBanId = txtCuentaBancaria.EditValue

            loConcepto.PcontCuenA = txtCuentaHaber.Tag
            loConcepto.PcontCuenC = txtCuentaDebe.Tag

            loConcepto.TgGrupoConId = cboGrupoConcepto.EditValue
            loConcepto.ConActivo = chkActivo.Checked
            loConcepto.ConBaseLegal = txtBaseLegal.EditValue
            loConcepto.ConApliMora = chkMora.EditValue
            loConcepto.ConAño = cboAño.EditValue
            loConcepto.TgSubGrupoId = cboSubGrupoConcepto.EditValue
            loConcepto.ConImporte = CDbl(txtImporte.EditValue)


            loConcepto.ConPorcentaje = txtPorcSAIMT.Text
            loConcepto.ConCodConMPT = txtCodContableMPT.Text
            loConcepto.ConCodPresMPT = txtCodPresupuestarioMPT.Text

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.conceptosGuardar(loConcepto)
            Else
                loConcepto.ConId = GIdRegistroActual
                MantenimientosBL.Instancia.conceptosActualizar(loConcepto)
            End If
            Me.enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtPartida.Properties.ReadOnly = True
        txtCuentaDebe.Properties.ReadOnly = True
        txtCuentaHaber.Properties.ReadOnly = True

    End Sub
    Protected Overrides Sub Buscar()
        Try
            dt_Conceptos.Rows.Clear()
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterios.SelectedIndex
            If cboCriterios.SelectedIndex = 3 Then
                GValorTextoBuscado = cboBuscarPor.EditValue
            End If
            Dim ListaConceptos As List(Of EEConceptos) = MantenimientosBL.Instancia.conceptosListarBCriterio(cboCriterios.SelectedIndex, GValorTextoBuscado, cboFiltroAño.EditValue)
            If ListaConceptos IsNot Nothing Then
                For Each fconcepto As EEConceptos In ListaConceptos
                    dt_Conceptos.LoadDataRow(New Object() {fconcepto.ConId.Substring(0, 5), _
                    fconcepto.ConNombre, _
                    fconcepto.TgGrupoCon, _
                    fconcepto.ConActivo,
                    fconcepto.ConAño}, True)
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
        'Try
        '    dtListadoPersona.Rows.Clear()
        '    Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaListarCriterio(GCriterioBuscado, GValorTextoBuscado)
        '    If ListaPersona IsNot Nothing Then
        '        For Each fPersona As EEPersona In ListaPersona
        '            dtListadoPersona.LoadDataRow(New Object() {fPersona.PerId, _
        '                 fPersona.Persona, _
        '                 fPersona.TgTipoDoc, _
        '                 fPersona.TgTipoPersona, _
        '                 fPersona.PerRef
        '               }, True)
        '        Next
        '        gvResultados.BestFitColumns()
        '        gvResultados.SelectRow(0)
        '        dgvListado_Click(Nothing, Nothing)
        '    End If
        '    MyBase.listar()
        '    Me.gvResultados.FocusedRowHandle = GIndiceSeleccionado
        '    dgvListado_Click(Nothing, Nothing)
        'Catch ex As Exception
        '    SaimtMessageBox.mostrarAlertaError(ex.Message)
        'End Try
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
            cboFuenteFinanciera.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboFuenteFinanciera.Properties.DisplayMember = "TgNombre"
            cboFuenteFinanciera.Properties.ValueMember = "TgCodigo"
            cboFuenteFinanciera.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(23)
            cboFuenteFinanciera.ItemIndex = 0

            cboGrupoConcepto.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboGrupoConcepto.Properties.DisplayMember = "TgNombre"
            cboGrupoConcepto.Properties.ValueMember = "TgCodigo"
            cboGrupoConcepto.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(25)
            cboGrupoConcepto.ItemIndex = 0

            cboSubGrupoConcepto.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboSubGrupoConcepto.Properties.DisplayMember = "TgNombre"
            cboSubGrupoConcepto.Properties.ValueMember = "TgCodigo"
            cboSubGrupoConcepto.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(103)

            cboFiltroAño.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboFiltroAño.Properties.DisplayMember = "TgNombre"
            cboFiltroAño.Properties.ValueMember = "TgCodigo"
            cboFiltroAño.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)
            cboFiltroAño.EditValue = CStr(Year(Now))

            cboAño.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboAño.Properties.DisplayMember = "TgNombre"
            cboAño.Properties.ValueMember = "TgCodigo"
            cboAño.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)
            cboAño.EditValue = CStr(Year(Now))

            ConstruirTableBConceptos()
            ConstruirTableConceptos()
            dgvListadoConcepto.DataSource = dt_Conceptos
            gcPartidas.DataSource = dt_ListaConceptos

            cboBuscarPor.Properties.ReadOnly = True

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub btnAgregarCuentaDebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCuentaDebe.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta(cboAño.EditValue)
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaDebe.Tag = fmConsulta.PlanCId
                txtCuentaDebe.Text = String.Format("{0} - {1}", txtCuentaDebe.Tag.ToString.Substring(4), fmConsulta.PlanCDescripcion)
            End If
        End Using
    End Sub

    Private Sub btnAgregarCuentaHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCuentaHaber.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta(cboAño.EditValue)
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaHaber.Tag = fmConsulta.PlanCId
                txtCuentaHaber.Text = String.Format("{0} - {1}", txtCuentaHaber.Tag.ToString.Substring(4), fmConsulta.PlanCDescripcion)
            End If
        End Using
    End Sub

    Private Sub btnAgregarPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPartida.Click
        Dim frm As frmConsultarPartida = New frmConsultarPartida(cboAño.EditValue)
        If frm.ShowDialog Then
            If frm.PartId <> Nothing Then
                txtPartida.Tag = frm.PartId
                txtPartida.Text = String.Format("{0} - {1}", frm.PartId, frm.PartNombre)
                If frm.PartPIM = 0 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("La Partida Seleccionada no Tiene Monto PIM Asignado")
                End If
            End If
        End If
    End Sub

    Private Sub cboCriterios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriterios.SelectedIndexChanged
        If cboCriterios.SelectedIndex = 3 Then
            cboBuscarPor.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboBuscarPor.Properties.DisplayMember = "TgNombre"
            cboBuscarPor.Properties.ValueMember = "TgCodigo"
            cboBuscarPor.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(25)
            cboBuscarPor.ItemIndex = 0
            cboBuscarPor.Tag = "NotClear"
            cboBuscarPor.Properties.ReadOnly = False
        Else
            cboBuscarPor.Tag = Nothing
        End If
    End Sub

    Private Sub cboBuscarPor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuscarPor.EditValueChanged
        Buscar()
    End Sub

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton1.Click
        Try
            dt_Conceptos.Rows.Clear()
            Dim ListaConceptos As List(Of EEConceptos) = MantenimientosBL.Instancia.conceptosListarCriterio(5, Nothing, cboFiltroAño.EditValue)
            If ListaConceptos IsNot Nothing Then
                For Each fconcepto As EEConceptos In ListaConceptos
                    dt_ListaConceptos.LoadDataRow(New Object() {fconcepto.ConId, _
                    fconcepto.ConNombre, _
                    fconcepto.ConPorcentaje, _
                    IIf(IsDBNull(fconcepto.ConPorcentaje) = True, 0, (100 - fconcepto.ConPorcentaje)), _
                    fconcepto.PcontCuenC, _
                    fconcepto.PcontCuenA, _
                    fconcepto.Partida, _
                    IIf(fconcepto.ConActivo = True, "Activo", "Inactivo"), _
                    fconcepto.TgGrupoCon}, True)
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
End Class
