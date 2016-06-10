﻿Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports System.IO
Public Class frmEnviarDoc
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private ReadOnly vDocId As String = Nothing
    Private ReadOnly vMovActId As String = Nothing
    '  Private ReadOnly vTTramiteId As String = Nothing
    Private ReadOnly tgOrigenId As String = Nothing
    ' Private ReadOnly tgTipoDocId As String = Nothing
    ' Private ReadOnly vOrigenId As String = Nothing
    ' Private ReadOnly tgCargoDeId As String = Nothing
    'Lista Manejo Archivos
    Dim ListaTemporalArchivosEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalArchivosNuevos As List(Of EEInmArchivos) = New List(Of EEInmArchivos)
    Dim ListaTemporalArchivosEditados As List(Of EEInmArchivos) = New List(Of EEInmArchivos)
    Dim dtArchivos As DataTable = New DataTable()

    Public Sub New(ByVal _docId As String, Optional ByVal _tgOrigenId As String = Nothing, Optional ByVal _MovActId As String = Nothing)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vDocId = _docId
        vMovActId = _MovActId
        tgOrigenId = _tgOrigenId
    End Sub
 
    Dim InstitucionId As String
    Dim Mensaje As String
    Enum Cls_TramiteDoc
        tgInstitucion = 82
        tgArea = 83
        tgCargo = 84
        'tgEstadoTramite = 89
        accionVsOrigen = 101
        estadoVsAccion = 100
        ' tgTipoDestino = 96
    End Enum
    Dim dtTablaGeneral As DataTable = New DataTable()

#Region "Construir Table"

    Private Sub ConstruirTableArchivos()
        dtArchivos.Columns.Add("inmArchId", GetType(String))
        dtArchivos.Columns.Add("inmArchNombre", GetType(String))
        dtArchivos.Columns.Add("inmArchDescripcion", GetType(String))
        dtArchivos.Columns.Add("tgTipoArchId", GetType(String))
        dtArchivos.Columns.Add("inmArch", GetType(Byte()))
        dtArchivos.Columns.Add("inmArchExt", GetType(String))
        dtArchivos.Columns.Add("inmArchPrincipal", GetType(Boolean))
        dtArchivos.Columns.Add("inmArchActivo", GetType(Boolean))

        dtArchivos.Columns("inmArchId").ColumnMapping = MappingType.Hidden
        dtArchivos.Columns("tgTipoArchId").ColumnMapping = MappingType.Hidden
        dtArchivos.Columns("inmArch").ColumnMapping = MappingType.Hidden

        dtArchivos.Columns("inmArchNombre").Caption = "Nombre"
        dtArchivos.Columns("inmArchDescripcion").Caption = "Descripcion"
        dtArchivos.Columns("inmArchExt").Caption = "Extension"
        dtArchivos.Columns("inmArchPrincipal").Caption = "Principal"
        dtArchivos.Columns("inmArchActivo").Caption = "Activo"
    End Sub

    Private Sub ConstruirTable()
        dtTablaGeneral.Columns.Add("DestinoId", GetType(String))
        dtTablaGeneral.Columns.Add("MovPerPara", GetType(String))
        dtTablaGeneral.Columns.Add("tgInstitucion", GetType(String))
        dtTablaGeneral.Columns.Add("tgArea", GetType(String))
        dtTablaGeneral.Columns.Add("tgCargo", GetType(String))
        dtTablaGeneral.Columns.Add("tgTipoDestinoId", GetType(String))
        dtTablaGeneral.Columns.Add("tgTipoDestino", GetType(String))
        dtTablaGeneral.Columns.Add("Comentario", GetType(String))

    End Sub


#End Region

    Private Sub frmEnviarDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()

        cboTipoAccion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoAccion.Properties.DisplayMember = "TgNombre"
        cboTipoAccion.Properties.ValueMember = "TgCodigo"
        cboTipoAccion.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(Cls_TramiteDoc.accionVsOrigen, tgOrigenId)
        cboTipoAccion.ItemIndex = 0

        txtdocID.EditValue = vDocId
        txtAnioProv.Text = Year(EEComun.FechaServidor)
        txtAnioResp.Text = Year(EEComun.FechaServidor)

        txtdocID.Properties.ReadOnly = True
        txtTrabajador.Properties.ReadOnly = True
        txtTrabajadorCC.Properties.ReadOnly = True
        txtAnioResp.Properties.ReadOnly = True
        txtAnioProv.Properties.ReadOnly = True
        btnBuscarTrabajadorCC.Enabled = False
        txtAsuntoProv.Properties.ReadOnly = True
        lblPersonaDeProv.Text = EEComun.PerNombreCompleto & " (" & EEComun.PerCargo & ")"
        lblPersonaDeResp.Text = lblPersonaDeProv.Text
        chlbasuntos.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(209)
        chlbasuntos.DisplayMember = "TgNombre"
        chlbasuntos.ValueMember = "TgCodigo"

        'cbotipoDocResp.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        'cbotipoDocResp.Properties.DisplayMember = "TgNombre"
        'cbotipoDocResp.Properties.ValueMember = "TgCodigo"
        'cbotipoDocResp.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(86)
        'cbotipoDocResp.ItemIndex = 1

    End Sub


    Private Sub BtnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnviar.Click
        Try

            If String.IsNullOrEmpty(txtTrabajador.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado Destinatario")
                btnBuscarTrabajador.Focus()
                Exit Sub
            End If

            If chkEnviarCC.Checked = True Then
                If String.IsNullOrEmpty(txtTrabajadorCC.EditValue) Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado Destinatario")
                    btnBuscarTrabajadorCC.Focus()
                    Exit Sub
                End If
            End If


            Dim MovNroDocInt As String = String.Empty
            Dim MovTgTDocId As String = String.Empty
            Mensaje = String.Empty
            Select Case cboTipoAccion.EditValue.ToString
                Case "01"
                    chlbasuntos.GetItemText(0)
                    For i As Integer = 0 To chlbasuntos.ItemCount - 1
                        If chlbasuntos.GetItemCheckState(i) = CheckState.Checked Then
                            If i = chlbasuntos.ItemCount - 1 Then
                                Mensaje = Mensaje & chlbasuntos.GetItemText(i)
                            Else
                                Mensaje = Mensaje & chlbasuntos.GetItemText(i) & ", "
                            End If
                        End If
                    Next

                    If chkGenerarNroProv.Checked = True Then
                        If String.IsNullOrEmpty(cboTipoDocPro.EditValue) Then
                            SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado el Tipo Documento")
                            cboTipoDocPro.Focus()
                            Exit Sub
                        End If
                        If String.IsNullOrEmpty(txtNroDocProv.EditValue) = True Or txtNroDocProv.EditValue = 0 Then
                            SaimtMessageBox.mostrarAlertaAdvertencia("No ha ingresado el Nro de Documento")
                            txtNroDocProv.Focus()
                            Exit Sub
                        End If

                        If String.IsNullOrEmpty(txtAnioProv.EditValue) = True Or txtAnioProv.EditValue = 0 Then
                            SaimtMessageBox.mostrarAlertaAdvertencia("No ha Ingresado el anio")
                            txtAnioProv.Focus()
                            Exit Sub
                        End If
                        If String.IsNullOrEmpty(txtSiglasProv.EditValue) = True Then
                            SaimtMessageBox.mostrarAlertaAdvertencia("No ha Ingresado la siglas del documento")
                            txtSiglasProv.Focus()
                            Exit Sub
                        End If

                        MovNroDocInt = txtNroDocProv.Text & "-" & txtAnioProv.Text & " SAIMT/" & txtSiglasProv.Text
                        MovTgTDocId = cboTipoDocPro.EditValue
                    End If

                    If String.IsNullOrEmpty(Mensaje) Then
                        SaimtMessageBox.mostrarAlertaAdvertencia("No ha ingresado el Asunto o Comentario")
                        chlbasuntos.Focus()
                        Exit Sub
                    End If

                Case "03", "04"

                    If chkGenerarNroResp.Checked = True Then
                        If String.IsNullOrEmpty(cbotipoDocResp.EditValue) Then
                            SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado el Tipo Documento")
                            cboTipoDocPro.Focus()
                            Exit Sub
                        End If
                        If String.IsNullOrEmpty(txtNroDocResp.EditValue) = True Or txtNroDocResp.EditValue = 0 Then
                            SaimtMessageBox.mostrarAlertaAdvertencia("No ha ingresado el Nro de Documento")
                            txtNroDocProv.Focus()
                            Exit Sub
                        End If

                        If String.IsNullOrEmpty(txtAnioResp.EditValue) = True Or txtAnioResp.EditValue = 0 Then
                            SaimtMessageBox.mostrarAlertaAdvertencia("No ha Ingresado el anio")
                            txtAnioResp.Focus()
                            Exit Sub
                        End If
                        If String.IsNullOrEmpty(txtSiglasResp.EditValue) = True Then
                            SaimtMessageBox.mostrarAlertaAdvertencia("No ha Ingresado la siglas del documento")
                            txtSiglasResp.Focus()
                            Exit Sub
                        End If
                        MovNroDocInt = txtNroDocResp.Text & "-" & txtAnioResp.Text & " SAIMT/" & txtSiglasResp.Text
                        MovTgTDocId = cbotipoDocResp.EditValue
                    End If

                    Mensaje = txtAsuntoRes.Text.Trim

                    If String.IsNullOrEmpty(Mensaje) Then
                        SaimtMessageBox.mostrarAlertaAdvertencia("No ha ingresado el Asunto o Comentario")
                        txtAsuntoRes.Focus()
                        Exit Sub
                    End If

            End Select


            Dim loMovimiento As EEMovimientoSTD = Nothing

            loMovimiento = New EEMovimientoSTD()
            loMovimiento.MovId = vMovActId
            loMovimiento.DocId = txtdocID.EditValue
            loMovimiento.MovDe = EEComun.PerCargoID
            If txtTrabajador.Tag IsNot Nothing Then
                loMovimiento.MovPara = txtTrabajador.Tag.ToString.Substring(8, 9)
                loMovimiento.MovPerIdPara = txtTrabajador.Tag.ToString.Substring(0, 8)
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione al Destinatario")
                Return
            End If
            If txtTrabajadorCC.Tag IsNot Nothing Then
                loMovimiento.MovParaCC = txtTrabajadorCC.Tag.ToString.Substring(8, 9)
                loMovimiento.MovPerIdParaCC = txtTrabajadorCC.Tag.ToString.Substring(0, 8)
            End If

            loMovimiento.MovComentario = Mensaje
            loMovimiento.TgEstadoMovId = cboEstadoMovimiento.EditValue
            loMovimiento.tgTDestinoId = cboTipoAccion.EditValue
            loMovimiento.MovPerIdDe = EEComun._PerId
            loMovimiento.MovNroDocInt = MovNroDocInt
            loMovimiento.movTgTDocId = MovTgTDocId
            If txtBuscarArchivo.Text <> String.Empty Then
                Dim loImageConver As ImageConver = New ImageConver
                loMovimiento.MovArch = loImageConver.FileToByteArray(txtBuscarArchivo.Text)
            End If

            If MantenimientosBL.Instancia.movimientoSTDGuardar(loMovimiento) = True Then
                SaimtMessageBox.mostrarAlertaInformativa("Se envio Correctamente el documento")
                Me.Close()
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("Error al Intentar Enviar")
            End If

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub sCboTipoDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoAccion.Click
        If cboTipoAccion.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("Usted a seleccionado el de estado de tramite : " & cboEstadoMovimiento.Text)
        End If
    End Sub


    Private Sub cboTipoAccion_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoAccion.EditValueChanged
        cboEstadoMovimiento.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoMovimiento.Properties.DisplayMember = "TgNombre"
        cboEstadoMovimiento.Properties.ValueMember = "TgCodigo"
        cboEstadoMovimiento.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(Cls_TramiteDoc.estadoVsAccion, cboTipoAccion.EditValue)
        cboEstadoMovimiento.ItemIndex = 0
        XtraTabPage1.Text = cboTipoAccion.Text
        XtraTabPage0.Text = cboTipoAccion.Text
        XtraTabPage1.PageVisible = False
        XtraTabPage0.PageVisible = False
        Select Case cboTipoAccion.EditValue.ToString
            Case "03", "04"
                xtabAcciones.SelectedTabPageIndex = 0
                XtraTabPage0.PageVisible = True
            Case "01"
                xtabAcciones.SelectedTabPageIndex = 1
                XtraTabPage1.PageVisible = True
        End Select
    End Sub
    Dim ListaExtenciones As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralMostrarXClsId(30)

    Private Sub btnExaminarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminarArchivo.Click
        ofdExaminarArchivos.Filter = "Archivos de Word | *.doc; *.docx"
        If ofdExaminarArchivos.ShowDialog() = DialogResult.OK Then
            Dim lsArchSplit As String() = ofdExaminarArchivos.FileName.Split(".")
            Dim Ext, Peso, CodigoExt As String
            For Each loExt As EETablaGeneral In ListaExtenciones
                If loExt.TgAbrev.Contains(lsArchSplit(lsArchSplit.Length - 1)) Then
                    Ext = lsArchSplit(lsArchSplit.Length - 1)
                    Peso = loExt.TgExtra
                    CodigoExt = loExt.TgCodigo
                End If
            Next
            Dim f2 As FileInfo = New FileInfo(ofdExaminarArchivos.FileName)
            If (f2.Length / 1024) > Peso Then
                SaimtMessageBox.mostrarAlertaError(String.Format("El Archivo Seleccionado Tiene {0} KB.{1}El Peso Requerido Para los Archivos Word es de {2} KB.", (f2.Length / 1024), Environment.NewLine, Peso))
            Else
                txtBuscarArchivo.Text = ofdExaminarArchivos.FileName
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If txtBuscarArchivo.Text <> "" Then
            'Dim frm As New frmVisorDocWord()
            'frm.Show()
            'Dim byA As Byte() = loMovimientoSTD.MovArch
            'loImagenConver.ByteArrayToFile(String.Format("{0}SaimtTemporal{1}", System.IO.Path.GetTempPath(), ".doc"), byA)
            'rutaFile = String.Format("{0}SaimtTemporal{1}", System.IO.Path.GetTempPath(), ".doc")
            Process.Start(txtBuscarArchivo.Text)
        End If

    End Sub

    Private Sub btnBuscarTrabajador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarTrabajador.Click
        Try
            ' Si es Karla prederminamos a Secretaria general
            Dim frm As frmSeleccionarTrabajador
            If EEComun.PerCargoID = "000101801" Then
                If cboTipoAccion.EditValue = "05" Then
                    frm = New frmSeleccionarTrabajador(True, EEComun.PerCargoID, "017", "01")
                End If
            Else
                frm = New frmSeleccionarTrabajador(True, EEComun.PerCargoID)
            End If

            If frm.ShowDialog() Then
                Dim JerParaId As String = "0001" & frm.cboArea.EditValue & frm.cboCargo.EditValue
                txtTrabajador.Tag = frm.lstTrabajador.SelectedValue & JerParaId
                txtTrabajador.Text = frm.lstTrabajador.Text

                Dim ListaTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.jerarquiaSTDListarTipoDocumentosXJerDeId_JerParaId(EEComun.PerCargoID, JerParaId)

                cboTipoDocPro.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                cboTipoDocPro.Properties.DisplayMember = "TgNombre"
                cboTipoDocPro.Properties.ValueMember = "TgCodigo"
                cboTipoDocPro.Properties.DataSource = ListaTablaGeneral
                cboTipoDocPro.ItemIndex = -1

                cbotipoDocResp.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                cbotipoDocResp.Properties.DisplayMember = "TgNombre"
                cbotipoDocResp.Properties.ValueMember = "TgCodigo"
                cbotipoDocResp.Properties.DataSource = ListaTablaGeneral
                cbotipoDocResp.ItemIndex = -1
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub chkEnviarCC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnviarCC.CheckedChanged
        btnBuscarTrabajadorCC.Enabled = chkEnviarCC.Checked
        If chkEnviarCC.Checked = False Then
            txtTrabajadorCC.Text = Nothing
            txtTrabajadorCC.Tag = Nothing
        End If
    End Sub

    Private Sub btnBuscarTrabajadorCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarTrabajadorCC.Click
        Try
            Dim frm As New frmSeleccionarTrabajador(False)
            If frm.ShowDialog() Then
                txtTrabajadorCC.Tag = frm.lstTrabajador.SelectedValue & "0001" & frm.cboArea.EditValue & frm.cboCargo.EditValue
                txtTrabajadorCC.Text = frm.lstTrabajador.Text
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub cbotipoDocResp_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipoDocResp.EditValueChanged
        If Not String.IsNullOrEmpty(cbotipoDocResp.EditValue) And Not String.IsNullOrEmpty(txtAnioResp.Text) Then
            txtNroDocResp.Text = MantenimientosBL.Instancia.documentosGenerarCodigoInterno(EEComun.PerCargoID.Substring(4, 5), cbotipoDocResp.EditValue)
            txtSiglasResp.Text = EEComun.PerCargoSigla
        End If
    End Sub

    Private Sub chkGenerarNroResp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenerarNroResp.CheckedChanged
        If chkGenerarNroResp.Checked = True Then
            txtNroDocResp.BackColor = System.Drawing.SystemColors.Info
            txtAnioResp.Properties.ReadOnly = True
        Else
            txtNroDocResp.BackColor = Color.White
            txtAnioResp.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub chkGenerarNroProv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenerarNroProv.CheckedChanged
        If chkGenerarNroProv.Checked = True Then
            txtNroDocProv.BackColor = System.Drawing.SystemColors.Info
            txtAnioProv.Properties.ReadOnly = True

        Else
            txtNroDocProv.BackColor = Color.White
            txtAnioProv.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub cboTipoDocPro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocPro.EditValueChanged
        If Not String.IsNullOrEmpty(cboTipoDocPro.EditValue) And Not String.IsNullOrEmpty(txtAnioProv.Text) Then
            txtNroDocProv.Text = MantenimientosBL.Instancia.documentosGenerarCodigoInterno(EEComun.PerCargoID.Substring(4, 5), cboTipoDocPro.EditValue)
            txtSiglasProv.Text = EEComun.PerCargoSigla
        End If
    End Sub

 

    Private Sub chlbasuntos_ItemCheck(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles chlbasuntos.ItemCheck
        txtAsuntoProv.Text = String.Empty
        chlbasuntos.GetItemText(0)
        For i As Integer = 0 To chlbasuntos.ItemCount - 1
            If chlbasuntos.GetItemCheckState(i) = CheckState.Checked Then
                If i = chlbasuntos.ItemCount - 1 Then
                    txtAsuntoProv.Text = txtAsuntoProv.Text & chlbasuntos.GetItemText(i)
                Else
                    txtAsuntoProv.Text = txtAsuntoProv.Text & chlbasuntos.GetItemText(i) & ", "
                End If
            End If
        Next
    End Sub
End Class