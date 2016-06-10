Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Public Class frmCajaChicaMovimiento
    Inherits frmMantenimientos
    Dim perId As String
    Dim dtListado As DataTable = New DataTable()
    Dim dtDetalleMovimiento As DataTable = New DataTable()
    Dim CajId As String = String.Empty
    Dim AreaId, ccConfId As String
    Dim CajFondoTotal, CajMontoUtilizado As Decimal


#Region "Construir Table"
    Private Sub ConstruirTableDetalle()
        dtDetalleMovimiento.Columns.Add("CajDetId", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajNro", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajId", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetFechaMov", GetType(Date))
        dtDetalleMovimiento.Columns.Add("Persona", GetType(String))
        dtDetalleMovimiento.Columns.Add("Area", GetType(String))
        dtDetalleMovimiento.Columns.Add("Cargo", GetType(String))
        dtDetalleMovimiento.Columns.Add("TgGrupo", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetDescripcion", GetType(String))
        dtDetalleMovimiento.Columns.Add("TgTipoDoc", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetDocSerie", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetDocNro", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetImporte", GetType(Decimal))
        dtDetalleMovimiento.Columns.Add("CajDetSaldo", GetType(Decimal))
        dtDetalleMovimiento.Columns.Add("CajDetAnulada", GetType(Boolean))
        dtDetalleMovimiento.Columns.Add("Usuario", GetType(String))
        dtDetalleMovimiento.Columns.Add("PartId", GetType(String))
    End Sub

    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("CajDetId", GetType(String))
        dtListado.Columns.Add("CajNro", GetType(String))
        dtListado.Columns.Add("CajId", GetType(String))
        dtListado.Columns.Add("CajDetFechaMov", GetType(Date))
        dtListado.Columns.Add("Persona", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvListadoMov.DataRowCount <> 0 Then
                Dim loCajaChicaDet As EECajaChica.EECajaChicaDet = MantenimientosBL.Instancia.cajachicadetListarXCajDetId(gvListadoMov.GetRowCellValue(Me.gvListadoMov.GetSelectedRows(0), "CajDetId").ToString())
                If loCajaChicaDet IsNot Nothing Then
                    GIndiceSeleccionado = Me.gvListadoMov.GetSelectedRows(0)
                    txtCajDetId.Text = loCajaChicaDet.CajDetId
                    txtCajId.Text = loCajaChicaDet.CajId
                    txtNroCaja.Text = loCajaChicaDet.CajId.Substring(0, 2)
                    txtAnio.Text = loCajaChicaDet.CajId.Substring(2, 4)
                    dtpFechaMov.EditValue = loCajaChicaDet.CajDetFechaMov
                    txtPersona.Tag = loCajaChicaDet.PerId
                    txtPersona.Text = IIf(loCajaChicaDet.CajDetAnulada = True, "ANULADO", loCajaChicaDet.Persona)
                    cboArea.EditValue = loCajaChicaDet.PerAreaId
                    cboGrupo.EditValue = loCajaChicaDet.TgGrupoId
                    txtPartida.Text = loCajaChicaDet.PartId
                    txtObservacion.Text = IIf(loCajaChicaDet.CajDetAnulada = True, "ANULADO", loCajaChicaDet.CajDetDescripcion)
                    cboTipoDocumento.EditValue = loCajaChicaDet.TgTipoDocId.TrimEnd
                    txtNroMov.Text = loCajaChicaDet.CajDetDocNro
                    TxtSerieDocMov.Text = loCajaChicaDet.CajDetDocSerie
                    txtImporte.Text = loCajaChicaDet.CajDetImporte
                    chkAnulado.Checked = loCajaChicaDet.CajDetAnulada
                End If
                Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaConsultarGeneral(3, 0, txtPersona.Tag)
                If ListaPersona IsNot Nothing Then
                    txtNroDocPersona.EditValue = ListaPersona.Item(0).PerNDoc
                End If
                gvDetalle.BestFitColumns()
            End If
            MyBase.seleccionarListado()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try

            If chkAnulado.Checked = False Then
                If String.IsNullOrEmpty(txtCajId.EditValue) Then
                    txtCajId.Focus()
                    SaimtMessageBox.mostrarAlertaAdvertencia("No se ha podido indentificar la caja actual")
                    Return
                End If
                Dim MontoUtilizado As Decimal = MantenimientosBL.Instancia.cajaChicaMostrarMontoUtilizadoxCajId(CajId)

                If IsNumeric(txtImporte.Text) Then
                    If txtImporte.Text > 0 Then
                        If MontoUtilizado + CDbl(txtImporte.Text) > CajFondoTotal Then
                            SaimtMessageBox.mostrarAlertaAdvertencia("El Importe Sobrepasa el Saldo Actual")
                            txtImporte.Focus()
                            Return
                        End If
                    Else
                        SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese un Valor positivo, como importe")
                        txtImporte.Focus()
                        Return
                    End If
                Else
                    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese un Valor Numerico, como importe")
                    txtImporte.Focus()
                    Return
                End If

                If IsDBNull(txtPersona.Tag) = True Or txtPersona.Text = "" Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Debe seleccionar un proveedor")
                    txtPersona.Focus()
                    Return
                End If

                If IsDBNull(cboGrupo.EditValue) = True Or cboGrupo.EditValue = "" Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Debe seleccionar el Grupo")
                    cboGrupo.Focus()
                    Return
                End If

                If IsDBNull(txtPartida.Text) = True Or txtPartida.Text = "" Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Debe seleccionar la Partida")
                    txtPartida.Focus()
                    Return
                End If
            End If

            Dim loCajaChicaDet As EECajaChica.EECajaChicaDet = New EECajaChica.EECajaChicaDet
            loCajaChicaDet.CajDetId = txtCajDetId.Text
            loCajaChicaDet.CajId = txtCajId.Text
            loCajaChicaDet.CajDetFechaMov = dtpFechaMov.EditValue
            loCajaChicaDet.PerId = txtPersona.Tag
            loCajaChicaDet.PerAreaId = cboArea.EditValue
            loCajaChicaDet.TgGrupoId = cboGrupo.EditValue
            loCajaChicaDet.PartId = txtPartida.Text
            loCajaChicaDet.CajDetDescripcion = txtObservacion.Text
            loCajaChicaDet.TgTipoDocId = cboTipoDocumento.EditValue
            loCajaChicaDet.CajDetDocNro = txtNroMov.Text
            loCajaChicaDet.CajDetDocSerie = TxtSerieDocMov.Text
            loCajaChicaDet.CajDetImporte = CDbl(txtImporte.Text)
            loCajaChicaDet.CajDetAnulada = chkAnulado.Checked
            loCajaChicaDet.ccConfId = ccConfId
            loCajaChicaDet.CajDetAnulada = chkAnulado.Checked
            If loCajaChicaDet.CajDetAnulada = True Then
                If SaimtMessageBox.mostrarAlertaPregunta("Se esta Anulando este movimiento, Desea Continuar") = False Then
                    Return
                End If
            End If
            loCajaChicaDet.UsuId = EEComun.UsuIdOnline
            If GEstadoNuevo Then
                MantenimientosBL.Instancia.cajachicadetGuardar(loCajaChicaDet)
            Else
                MantenimientosBL.Instancia.cajachicadetActualizar(loCajaChicaDet)
            End If
            enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtCajId.Text = CajId
        txtNroCaja.Text = txtCajId.Text.Substring(0, 2)
        txtAnio.Text = txtCajId.Text.Substring(2, 4)
        CajMontoUtilizado = MantenimientosBL.Instancia.cajaChicaMostrarMontoUtilizadoxCajId(CajId)
        txtSaldoActual.Text = CajFondoTotal - CajMontoUtilizado
        dtpFechaMov.EditValue = Date.Now
        txtPersona.Properties.ReadOnly = True
        ' cboInstitucion.Properties.ReadOnly = True
        ' cboArea.Properties.ReadOnly = True
        txtNroDocPersona.Properties.ReadOnly = True
        ' cboGrupo.Properties.ReadOnly = True
        txtPartida.Properties.ReadOnly = True
        txtCajDetId.Properties.ReadOnly = True
        txtCajId.Properties.ReadOnly = True
        ' txtNroMov.Properties.ReadOnly = True
        '  TxtSerieDocMov.Properties.ReadOnly = True
        txtSaldoActual.Properties.ReadOnly = True
        chkAnulado.Checked = False
        Dim loCajaConf As EECajaChica.EECajaChicaConfiguracion = MantenimientosBL.Instancia.cajaChicaConfigActivaxTgAreaId(AreaId)
        ccConfId = String.Empty
        If loCajaConf IsNot Nothing Then
            ccConfId = loCajaConf.CcConfId & loCajaConf.CcConfAnio
            'TxtSerieDocMov.Text = Strings.Right("000" & (loCajaConf.ccConfInicioSerieDoc), 3)
            ' txtNroMov.Text = Strings.Right("0000" & (loCajaConf.ccConfInicioNroDoc + 1), 4)
        End If
    End Sub

    Protected Overrides Sub editar()

        MyBase.editar()
        txtCajId.Properties.ReadOnly = True
        txtNroDocPersona.Properties.ReadOnly = True
        txtPartida.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub Buscar()
        Try

            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterio.SelectedIndex
            Dim loCajaChicaDet As List(Of EECajaChica.EECajaChicaDet) = MantenimientosBL.Instancia.cajachicadetBListarXcriterios(GCriterioBuscado, GValorTextoBuscado)
            dtListado.Clear()
            If loCajaChicaDet IsNot Nothing Then
                For Each frow As EECajaChica.EECajaChicaDet In loCajaChicaDet
                    dtListado.LoadDataRow(New Object() {frow.CajDetId, frow.CajNro, _
                    frow.CajId, _
                    frow.CajDetFechaMov, _
                    frow.Persona}, True)
                Next
                gvListadoMov.BestFitColumns()
                gvListadoMov.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub frmCajaChicaMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PuedeBuscar = True
        PuedeCrear = True
        PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        cboTipoDocumento.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoDocumento.Properties.DisplayMember = "TgNombre"
        cboTipoDocumento.Properties.ValueMember = "TgCodigo"
        cboTipoDocumento.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(187)
        cboTipoDocumento.ItemIndex = -1
        cboGrupo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboGrupo.Properties.DisplayMember = "TgNombre"
        cboGrupo.Properties.ValueMember = "TgCodigo"
        cboGrupo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(186)
        cboGrupo.ItemIndex = -1
        cboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboArea.Properties.DisplayMember = "TgNombre"
        cboArea.Properties.ValueMember = "TgCodigo"
        cboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(83, "0001")
        cboArea.ItemIndex = -1

        ConstruirTableDetalle()
        dgvDetalle.DataSource = dtDetalleMovimiento
        ConstruirTableListado()
        dgvListadoMov.DataSource = dtListado
        perId = EEComun._PerId
        '"00000330"
        Dim locargoPersonal As List(Of EECargoPersonal) = MantenimientosBL.Instancia.CargoListarXPerId_pa(perId)
        If locargoPersonal IsNot Nothing Then
            AreaId = locargoPersonal(0).CodArea
            Dim loCajaChica As EECajaChica = MantenimientosBL.Instancia.cajaChicaMostrarAbiertaxTgAreaId(AreaId)
            If loCajaChica IsNot Nothing Then
                CajId = loCajaChica.CajId
                CajFondoTotal = loCajaChica.CajFondoTotal
                txtSaldoFinal.Text = loCajaChica.CajFondoTotal
                txtSaldoInicial.Text = loCajaChica.CajFondoAnterior
                txtChequeGirado.Text = loCajaChica.CajFondoRetiro
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("No Existen Caja Actualmente Aperturada o usted no tiene permiso")
                Me.Close()
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Existen Caja Actualmente Aperturada o usted no tiene permiso")
            Me.Close()
        End If
    End Sub

    Private Sub btnConsultarPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarPartida.Click
        Dim frm As frmConsultarPartida = New frmConsultarPartida()
        If frm.ShowDialog Then
            txtPartida.Text = frm.PartId
        End If
    End Sub

    Private Sub SaimtButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarPersona.Click
        Using fmConsultaPersona As frmConsultaPersonaGeneral = New frmConsultaPersonaGeneral(3)
            If fmConsultaPersona.ShowDialog() = DialogResult.OK Then
                txtPersona.Text = fmConsultaPersona.PerNombre
                txtPersona.Tag = fmConsultaPersona.PerId
                txtNroDocPersona.Text = fmConsultaPersona.perNdoc
                Dim locargoPersonal As List(Of EECargoPersonal) = MantenimientosBL.Instancia.CargoListarXPerId_pa(fmConsultaPersona.PerId)
                If locargoPersonal IsNot Nothing Then
                    cboArea.EditValue = locargoPersonal(0).CodArea
                End If
            End If
        End Using
    End Sub

    Private Sub btnMostrarMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarMovimientos.Click
        Try
            Dim loCajaChicaDet As List(Of EECajaChica.EECajaChicaDet) = MantenimientosBL.Instancia.cajachicadetListarXCajId(CajId)
            Dim ImporteAcomulado As Decimal
            dtDetalleMovimiento.Clear()
            If loCajaChicaDet IsNot Nothing Then
                For Each frow As EECajaChica.EECajaChicaDet In loCajaChicaDet
                    If frow.CajDetAnulada = False Then
                        ImporteAcomulado = ImporteAcomulado + frow.CajDetImporte
                    End If
                    dtDetalleMovimiento.LoadDataRow(New Object() {frow.CajDetId, frow.CajNro, _
                    frow.CajId, _
                    frow.CajDetFechaMov, _
                    IIf(frow.CajDetAnulada = True, "ANULADO", frow.Persona), _
                    frow.Area, _
                    frow.Cargo, _
                    frow.TgGrupo, _
                    IIf(frow.CajDetAnulada = True, "ANULADO", frow.CajDetDescripcion), _
                    frow.tgTipoDoc, _
                    frow.CajDetDocSerie, _
                    frow.CajDetDocNro, _
                    frow.CajDetImporte, _
                    CajFondoTotal - ImporteAcomulado, _
                    frow.CajDetAnulada, _
                    frow.usuario, _
                    frow.PartId
                     }, True)
                Next
                'txtImporte.Text = ImporteAcomulado
                gvDetalle.BestFitColumns()
                gvDetalle.SelectRow(0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            gvDetalle.ExportToXls(sfdexportar.FileName)
        End If
    End Sub

End Class