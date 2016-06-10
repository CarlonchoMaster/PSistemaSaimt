Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports System.IO

Public Class frmCambiarEstadoSTD
    Inherits frmMantenimientos
    Dim vMovId As String
    Dim loPersona As EEPersona
    Dim loInstitucion As EETablaGeneral
    Dim loArea As EETablaGeneral
    Dim loCargo As EETablaGeneral
    Dim dtTablaContacto As DataTable = New DataTable()

    Public Sub New(ByVal v_MovId As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vMovId = v_MovId
    End Sub
    Private Sub ConstruirTableContacto()
        dtTablaContacto.Columns.Add("Descripcion", GetType(String))
        dtTablaContacto.Columns.Add("Contacto", GetType(String))
    End Sub

    Sub CargarMovDocumento(ByVal movId As String)
        Dim fmovimiento As EEMovimientoSTD
        Try
            fmovimiento = MantenimientosBL.Instancia.movimientoSTDxMovId(movId)
            If Not fmovimiento Is Nothing Then
                txtcodint.EditValue = fmovimiento.DocId
                txtnroreg.EditValue = fmovimiento.ODocumento.DocNReg
                txtTipoDoc.EditValue = fmovimiento.ODocumento.TgTDoc
                txtasunto.EditValue = fmovimiento.ODocumento.DocAsunto
                txtremitente.EditValue = fmovimiento.OPersonaOrigen.PerNombreCompleto
                txtcargorem.EditValue = fmovimiento.OPersonaOrigen.OPerCargoPersonal.Cargo
                dtpfechaenvio.EditValue = fmovimiento.MovFechaEnv
                txtaccionadoptar.EditValue = fmovimiento.TgTDestino
                txtaccionadoptar.Tag = fmovimiento.TgTDestinoId
                txtcomentario.EditValue = fmovimiento.MovComentario
                'sCboEstadoSTD.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                'sCboEstadoSTD.Properties.DisplayMember = "TgNombre"
                'sCboEstadoSTD.Properties.ValueMember = "TgCodigo"
                'sCboEstadoSTD.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(99, fmovimiento.TgEstadoMovId)

                sCboEstadoSTD.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                sCboEstadoSTD.Properties.DisplayMember = "TgNombre"
                sCboEstadoSTD.Properties.ValueMember = "TgCodigo"
                sCboEstadoSTD.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(100, fmovimiento.TgTDestinoId)
                sCboEstadoSTD.ItemIndex = 0

                Me.Tag = fmovimiento.OPersonaDestino.OPerCargoPersonal.Cargo
                rgtupa.EditValue = fmovimiento.ODocumento.DocTupac
                spfolios.Value = fmovimiento.ODocumento.DocNFolio
                dtpfecharecep.DateTime = fmovimiento.MovFechaRec
                dtpfechaing.DateTime = fmovimiento.ODocumento.DocFechaIng
                txtcomentariodoc.Text = fmovimiento.ODocumento.DocComentario
                txtdocreferencia.Text = fmovimiento.ODocumento.DocNRef
                txtdocaux.Text = fmovimiento.ODocumento.DocAux
                txtinteresado.Tag = fmovimiento.ODocumento.OPersonaInteresada.PerId
                txtinteresado.Text = fmovimiento.ODocumento.OPersonaInteresada.PerNombreCompleto ' loPersona.perNombresoRazon
                txtdireccion.Text = fmovimiento.ODocumento.OPersonaInteresada.PerDireccion
                loPersona = MantenimientosBL.Instancia.PersonaContactoXPerId(fmovimiento.ODocumento.OPersonaInteresada.PerId)
                If loPersona IsNot Nothing Then
                    For Each fContacto As EEPersona.EEContacto In loPersona.ListaContacto
                        dtTablaContacto.LoadDataRow(New Object() {fContacto.ContDescripcion, _
                             fContacto.OTablaGeneral.TgCodigo
                           }, True)
                    Next
                End If
                gvDatosAdicionales.BestFitColumns()
                txtinstitucion.Text = fmovimiento.ODocumento.OPersonaInteresada.OPerCargoPersonal.Institucion
                txtinstitucion.Tag = fmovimiento.ODocumento.OPersonaInteresada.OPerCargoPersonal.CodInstitucion
                txtarea.Text = fmovimiento.ODocumento.OPersonaInteresada.OPerCargoPersonal.Area
                txtarea.Tag = fmovimiento.ODocumento.OPersonaInteresada.OPerCargoPersonal.CodArea
                txtcargo.Text = fmovimiento.ODocumento.OPersonaInteresada.OPerCargoPersonal.Cargo
                txtcargo.Tag = fmovimiento.ODocumento.OPersonaInteresada.OPerCargoPersonal.CodCargo
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub guardar()
        Try

            If sCboEstadoSTD.EditValue IsNot Nothing And vMovId IsNot Nothing Then
                MantenimientosBL.Instancia.movimientostdActualizarEstadoMov(vMovId, sCboEstadoSTD.EditValue, Trim(txtComentarioFinal.EditValue), Me.Tag, txtcodint.Text.Trim, chkautoproveido.Checked)
                Dim loMovimiento As EEMovimientoSTD = Nothing
                loMovimiento = New EEMovimientoSTD()
                loMovimiento.MovId = vMovId
                loMovimiento.DocId = txtcodint.EditValue
                loMovimiento.MovDe = EEComun.PerCargoID
                If txtinteresado.Tag IsNot Nothing Then
                    loMovimiento.MovPara = txtinstitucion.Tag & txtarea.Tag & txtcargo.Tag
                    loMovimiento.MovPerIdPara = txtinteresado.Tag.ToString.Substring(0, 8)
                Else
                    SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Interesado")
                    Return
                End If

                loMovimiento.MovComentario = Trim(txtComentarioFinal.EditValue)
                loMovimiento.TgEstadoMovId = sCboEstadoSTD.EditValue
                loMovimiento.TgTDestinoId = txtaccionadoptar.Tag
                loMovimiento.MovPerIdDe = EEComun._PerId
                'loMovimiento.MovNroDocInt = MovNroDocInt
                'loMovimiento.MovTgTDocId = MovTgTDocId
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


                Me.enabledGA = False
                MyBase.guardar()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub frmCambiarEstadoSTD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sCboEstadoSTD.Enabled = True
        sCboEstadoSTD.Properties.ReadOnly = False
        txtComentarioFinal.Enabled = True
        txtComentarioFinal.Properties.ReadOnly = False
        btnGuardar.Enabled = True
        btnExaminarArchivo.Enabled = True
        ConstruirTableContacto()
        CargarMovDocumento(vMovId)
        If EEUsuarios.UsuIdOnline = 41 Then
            chkautoproveido.Enabled = True
            chkautoproveido.Properties.ReadOnly = False
            chkautoproveido.Visible = True
        Else
            chkautoproveido.Visible = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If txtBuscarArchivo.Text <> "" Then
            Process.Start(txtBuscarArchivo.Text)
        End If
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


End Class