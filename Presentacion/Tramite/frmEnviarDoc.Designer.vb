﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnviarDoc
    Inherits Presentacion.frmGeneral

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnviarDoc))
        Me.SaimtGroupBox5 = New SaimtControles.SaimtGroupBox()
        Me.btnBuscarTrabajadorCC = New SaimtControles.SaimtButton()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.txtTrabajadorCC = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscarTrabajador = New SaimtControles.SaimtButton()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtTrabajador = New DevExpress.XtraEditors.TextEdit()
        Me.chkEnviarCC = New DevExpress.XtraEditors.CheckEdit()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cboTipoAccion = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.xtabAcciones = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtNroDocProv = New DevExpress.XtraEditors.TextEdit()
        Me.lblPersonaDeProv = New DevExpress.XtraEditors.LabelControl()
        Me.chkGenerarNroProv = New DevExpress.XtraEditors.CheckEdit()
        Me.txtAnioProv = New DevExpress.XtraEditors.SpinEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsuntoProv = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSiglasProv = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTipoDocPro = New SaimtControles.SaimtComboBoxLookUp()
        Me.chlbasuntos = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.XtraTabPage0 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtNroDocResp = New DevExpress.XtraEditors.TextEdit()
        Me.lblPersonaDeResp = New DevExpress.XtraEditors.LabelControl()
        Me.chkGenerarNroResp = New DevExpress.XtraEditors.CheckEdit()
        Me.txtAnioResp = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSiglasResp = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbotipoDocResp = New SaimtControles.SaimtComboBoxLookUp()
        Me.txtAsuntoRes = New DevExpress.XtraEditors.MemoEdit()
        Me.txtdocID = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel35 = New SaimtControles.SaimtLabel()
        Me.btnExaminarArchivo = New SaimtControles.SaimtButton()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscarArchivo = New SaimtControles.SaimtTextBox()
        Me.cboEstadoMovimiento = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.BtnEnviar = New SaimtControles.SaimtButton()
        Me.SaimtButton4 = New SaimtControles.SaimtButton()
        Me.ofdExaminarArchivos = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox5.SuspendLayout()
        CType(Me.txtTrabajadorCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrabajador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEnviarCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtabAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtabAcciones.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtNroDocProv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGenerarNroProv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnioProv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsuntoProv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSiglasProv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chlbasuntos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage0.SuspendLayout()
        CType(Me.txtNroDocResp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGenerarNroResp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnioResp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSiglasResp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbotipoDocResp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsuntoRes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdocID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 508)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(570, 27)
        '
        'SaimtGroupBox5
        '
        Me.SaimtGroupBox5.Controls.Add(Me.btnBuscarTrabajadorCC)
        Me.SaimtGroupBox5.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox5.Controls.Add(Me.txtTrabajadorCC)
        Me.SaimtGroupBox5.Controls.Add(Me.btnBuscarTrabajador)
        Me.SaimtGroupBox5.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox5.Controls.Add(Me.txtTrabajador)
        Me.SaimtGroupBox5.Controls.Add(Me.chkEnviarCC)
        Me.SaimtGroupBox5.Controls.Add(Me.LinkLabel1)
        Me.SaimtGroupBox5.Controls.Add(Me.cboTipoAccion)
        Me.SaimtGroupBox5.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox5.Controls.Add(Me.xtabAcciones)
        Me.SaimtGroupBox5.Controls.Add(Me.txtdocID)
        Me.SaimtGroupBox5.Controls.Add(Me.SaimtLabel35)
        Me.SaimtGroupBox5.Controls.Add(Me.btnExaminarArchivo)
        Me.SaimtGroupBox5.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox5.Controls.Add(Me.txtBuscarArchivo)
        Me.SaimtGroupBox5.Controls.Add(Me.cboEstadoMovimiento)
        Me.SaimtGroupBox5.Controls.Add(Me.SaimtLabel11)
        Me.SaimtGroupBox5.Location = New System.Drawing.Point(4, 5)
        Me.SaimtGroupBox5.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox5.Name = "SaimtGroupBox5"
        Me.SaimtGroupBox5.Size = New System.Drawing.Size(558, 432)
        Me.SaimtGroupBox5.TabIndex = 34
        Me.SaimtGroupBox5.Text = "Datos para el Envio"
        '
        'btnBuscarTrabajadorCC
        '
        Me.btnBuscarTrabajadorCC.Image = Global.Presentacion.My.Resources.Resources.examinar
        Me.btnBuscarTrabajadorCC.Location = New System.Drawing.Point(514, 114)
        Me.btnBuscarTrabajadorCC.Name = "btnBuscarTrabajadorCC"
        Me.btnBuscarTrabajadorCC.Size = New System.Drawing.Size(23, 22)
        Me.btnBuscarTrabajadorCC.TabIndex = 94
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(53, 119)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(21, 13)
        Me.SaimtLabel4.TabIndex = 93
        Me.SaimtLabel4.Text = "CC :"
        '
        'txtTrabajadorCC
        '
        Me.txtTrabajadorCC.Location = New System.Drawing.Point(80, 116)
        Me.txtTrabajadorCC.MenuManager = Me.RibbonControl
        Me.txtTrabajadorCC.Name = "txtTrabajadorCC"
        Me.txtTrabajadorCC.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTrabajadorCC.Properties.Appearance.Options.UseBackColor = True
        Me.txtTrabajadorCC.Size = New System.Drawing.Size(428, 20)
        Me.txtTrabajadorCC.TabIndex = 92
        '
        'btnBuscarTrabajador
        '
        Me.btnBuscarTrabajador.Image = Global.Presentacion.My.Resources.Resources.examinar
        Me.btnBuscarTrabajador.Location = New System.Drawing.Point(514, 51)
        Me.btnBuscarTrabajador.Name = "btnBuscarTrabajador"
        Me.btnBuscarTrabajador.Size = New System.Drawing.Size(23, 22)
        Me.btnBuscarTrabajador.TabIndex = 91
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(45, 56)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(29, 13)
        Me.SaimtLabel3.TabIndex = 90
        Me.SaimtLabel3.Text = "Para :"
        '
        'txtTrabajador
        '
        Me.txtTrabajador.Location = New System.Drawing.Point(80, 53)
        Me.txtTrabajador.MenuManager = Me.RibbonControl
        Me.txtTrabajador.Name = "txtTrabajador"
        Me.txtTrabajador.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTrabajador.Properties.Appearance.Options.UseBackColor = True
        Me.txtTrabajador.Size = New System.Drawing.Size(428, 20)
        Me.txtTrabajador.TabIndex = 89
        '
        'chkEnviarCC
        '
        Me.chkEnviarCC.Location = New System.Drawing.Point(19, 86)
        Me.chkEnviarCC.MenuManager = Me.RibbonControl
        Me.chkEnviarCC.Name = "chkEnviarCC"
        Me.chkEnviarCC.Properties.Caption = "Enviar con Copia a"
        Me.chkEnviarCC.Size = New System.Drawing.Size(124, 19)
        Me.chkEnviarCC.TabIndex = 71
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(414, 412)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(90, 13)
        Me.LinkLabel1.TabIndex = 70
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Visualizar Archivo"
        '
        'cboTipoAccion
        '
        Me.cboTipoAccion.Location = New System.Drawing.Point(320, 23)
        Me.cboTipoAccion.MenuManager = Me.RibbonControl
        Me.cboTipoAccion.Name = "cboTipoAccion"
        Me.cboTipoAccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboTipoAccion.Properties.Appearance.Options.UseBackColor = True
        Me.cboTipoAccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoAccion.Properties.NullText = ""
        Me.cboTipoAccion.Size = New System.Drawing.Size(188, 20)
        Me.cboTipoAccion.TabIndex = 67
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(280, 26)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(31, 13)
        Me.SaimtLabel2.TabIndex = 66
        Me.SaimtLabel2.Text = "Acción"
        '
        'xtabAcciones
        '
        Me.xtabAcciones.Location = New System.Drawing.Point(6, 149)
        Me.xtabAcciones.Name = "xtabAcciones"
        Me.xtabAcciones.SelectedTabPage = Me.XtraTabPage1
        Me.xtabAcciones.Size = New System.Drawing.Size(541, 220)
        Me.xtabAcciones.TabIndex = 69
        Me.xtabAcciones.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage0, Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txtNroDocProv)
        Me.XtraTabPage1.Controls.Add(Me.lblPersonaDeProv)
        Me.XtraTabPage1.Controls.Add(Me.chkGenerarNroProv)
        Me.XtraTabPage1.Controls.Add(Me.txtAnioProv)
        Me.XtraTabPage1.Controls.Add(Me.Label3)
        Me.XtraTabPage1.Controls.Add(Me.txtAsuntoProv)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.txtSiglasProv)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.Label4)
        Me.XtraTabPage1.Controls.Add(Me.cboTipoDocPro)
        Me.XtraTabPage1.Controls.Add(Me.chlbasuntos)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.PageVisible = False
        Me.XtraTabPage1.Size = New System.Drawing.Size(535, 192)
        Me.XtraTabPage1.Text = "Proveer"
        '
        'txtNroDocProv
        '
        Me.txtNroDocProv.Location = New System.Drawing.Point(280, 36)
        Me.txtNroDocProv.MenuManager = Me.RibbonControl
        Me.txtNroDocProv.Name = "txtNroDocProv"
        Me.txtNroDocProv.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNroDocProv.Properties.Appearance.Options.UseBackColor = True
        Me.txtNroDocProv.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocProv.Size = New System.Drawing.Size(48, 20)
        Me.txtNroDocProv.TabIndex = 96
        '
        'lblPersonaDeProv
        '
        Me.lblPersonaDeProv.Location = New System.Drawing.Point(168, 12)
        Me.lblPersonaDeProv.Name = "lblPersonaDeProv"
        Me.lblPersonaDeProv.Size = New System.Drawing.Size(66, 13)
        Me.lblPersonaDeProv.TabIndex = 93
        Me.lblPersonaDeProv.Text = "LabelControl5"
        '
        'chkGenerarNroProv
        '
        Me.chkGenerarNroProv.EditValue = True
        Me.chkGenerarNroProv.Location = New System.Drawing.Point(9, 9)
        Me.chkGenerarNroProv.MenuManager = Me.RibbonControl
        Me.chkGenerarNroProv.Name = "chkGenerarNroProv"
        Me.chkGenerarNroProv.Properties.Caption = "AutoGenerar Numeración"
        Me.chkGenerarNroProv.Size = New System.Drawing.Size(150, 19)
        Me.chkGenerarNroProv.TabIndex = 92
        '
        'txtAnioProv
        '
        Me.txtAnioProv.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAnioProv.Location = New System.Drawing.Point(334, 36)
        Me.txtAnioProv.MenuManager = Me.RibbonControl
        Me.txtAnioProv.Name = "txtAnioProv"
        Me.txtAnioProv.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtAnioProv.Properties.Appearance.Options.UseBackColor = True
        Me.txtAnioProv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAnioProv.Properties.Mask.EditMask = "n0"
        Me.txtAnioProv.Size = New System.Drawing.Size(62, 20)
        Me.txtAnioProv.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "N°"
        '
        'txtAsuntoProv
        '
        Me.txtAsuntoProv.Location = New System.Drawing.Point(67, 62)
        Me.txtAsuntoProv.MenuManager = Me.RibbonControl
        Me.txtAsuntoProv.Name = "txtAsuntoProv"
        Me.txtAsuntoProv.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtAsuntoProv.Properties.Appearance.Options.UseBackColor = True
        Me.txtAsuntoProv.Size = New System.Drawing.Size(459, 20)
        Me.txtAsuntoProv.TabIndex = 88
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 65)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl3.TabIndex = 87
        Me.LabelControl3.Text = "Asunto"
        '
        'txtSiglasProv
        '
        Me.txtSiglasProv.Location = New System.Drawing.Point(447, 36)
        Me.txtSiglasProv.MenuManager = Me.RibbonControl
        Me.txtSiglasProv.Name = "txtSiglasProv"
        Me.txtSiglasProv.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSiglasProv.Properties.Appearance.Options.UseBackColor = True
        Me.txtSiglasProv.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSiglasProv.Size = New System.Drawing.Size(79, 20)
        Me.txtSiglasProv.TabIndex = 86
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(409, 39)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl4.TabIndex = 85
        Me.LabelControl4.Text = "SAIMT/"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Tipo Doc"
        '
        'cboTipoDocPro
        '
        Me.cboTipoDocPro.Location = New System.Drawing.Point(68, 36)
        Me.cboTipoDocPro.MenuManager = Me.RibbonControl
        Me.cboTipoDocPro.Name = "cboTipoDocPro"
        Me.cboTipoDocPro.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboTipoDocPro.Properties.Appearance.Options.UseBackColor = True
        Me.cboTipoDocPro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoDocPro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocPro.Properties.NullText = ""
        Me.cboTipoDocPro.Size = New System.Drawing.Size(174, 20)
        Me.cboTipoDocPro.TabIndex = 81
        '
        'chlbasuntos
        '
        Me.chlbasuntos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chlbasuntos.Location = New System.Drawing.Point(0, 88)
        Me.chlbasuntos.MultiColumn = True
        Me.chlbasuntos.Name = "chlbasuntos"
        Me.chlbasuntos.Size = New System.Drawing.Size(535, 104)
        Me.chlbasuntos.TabIndex = 0
        '
        'XtraTabPage0
        '
        Me.XtraTabPage0.Controls.Add(Me.txtNroDocResp)
        Me.XtraTabPage0.Controls.Add(Me.lblPersonaDeResp)
        Me.XtraTabPage0.Controls.Add(Me.chkGenerarNroResp)
        Me.XtraTabPage0.Controls.Add(Me.txtAnioResp)
        Me.XtraTabPage0.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage0.Controls.Add(Me.txtSiglasResp)
        Me.XtraTabPage0.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage0.Controls.Add(Me.Label2)
        Me.XtraTabPage0.Controls.Add(Me.Label1)
        Me.XtraTabPage0.Controls.Add(Me.cbotipoDocResp)
        Me.XtraTabPage0.Controls.Add(Me.txtAsuntoRes)
        Me.XtraTabPage0.Name = "XtraTabPage0"
        Me.XtraTabPage0.PageVisible = False
        Me.XtraTabPage0.Size = New System.Drawing.Size(535, 192)
        Me.XtraTabPage0.Text = "Responder"
        '
        'txtNroDocResp
        '
        Me.txtNroDocResp.Location = New System.Drawing.Point(262, 45)
        Me.txtNroDocResp.MenuManager = Me.RibbonControl
        Me.txtNroDocResp.Name = "txtNroDocResp"
        Me.txtNroDocResp.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNroDocResp.Properties.Appearance.Options.UseBackColor = True
        Me.txtNroDocResp.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocResp.Size = New System.Drawing.Size(48, 20)
        Me.txtNroDocResp.TabIndex = 95
        '
        'lblPersonaDeResp
        '
        Me.lblPersonaDeResp.Location = New System.Drawing.Point(174, 16)
        Me.lblPersonaDeResp.Name = "lblPersonaDeResp"
        Me.lblPersonaDeResp.Size = New System.Drawing.Size(66, 13)
        Me.lblPersonaDeResp.TabIndex = 94
        Me.lblPersonaDeResp.Text = "LabelControl6"
        '
        'chkGenerarNroResp
        '
        Me.chkGenerarNroResp.EditValue = True
        Me.chkGenerarNroResp.Location = New System.Drawing.Point(12, 13)
        Me.chkGenerarNroResp.MenuManager = Me.RibbonControl
        Me.chkGenerarNroResp.Name = "chkGenerarNroResp"
        Me.chkGenerarNroResp.Properties.Caption = "AutoGenerar Numeración"
        Me.chkGenerarNroResp.Size = New System.Drawing.Size(150, 19)
        Me.chkGenerarNroResp.TabIndex = 93
        '
        'txtAnioResp
        '
        Me.txtAnioResp.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAnioResp.Location = New System.Drawing.Point(316, 45)
        Me.txtAnioResp.MenuManager = Me.RibbonControl
        Me.txtAnioResp.Name = "txtAnioResp"
        Me.txtAnioResp.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtAnioResp.Properties.Appearance.Options.UseBackColor = True
        Me.txtAnioResp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAnioResp.Properties.Mask.EditMask = "n0"
        Me.txtAnioResp.Size = New System.Drawing.Size(62, 20)
        Me.txtAnioResp.TabIndex = 81
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl2.TabIndex = 79
        Me.LabelControl2.Text = "Asunto"
        '
        'txtSiglasResp
        '
        Me.txtSiglasResp.Location = New System.Drawing.Point(422, 45)
        Me.txtSiglasResp.MenuManager = Me.RibbonControl
        Me.txtSiglasResp.Name = "txtSiglasResp"
        Me.txtSiglasResp.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSiglasResp.Properties.Appearance.Options.UseBackColor = True
        Me.txtSiglasResp.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSiglasResp.Size = New System.Drawing.Size(100, 20)
        Me.txtSiglasResp.TabIndex = 75
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(384, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 74
        Me.LabelControl1.Text = "SAIMT/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "N°"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Tipo Doc."
        '
        'cbotipoDocResp
        '
        Me.cbotipoDocResp.Location = New System.Drawing.Point(65, 45)
        Me.cbotipoDocResp.MenuManager = Me.RibbonControl
        Me.cbotipoDocResp.Name = "cbotipoDocResp"
        Me.cbotipoDocResp.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbotipoDocResp.Properties.Appearance.Options.UseBackColor = True
        Me.cbotipoDocResp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbotipoDocResp.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbotipoDocResp.Properties.NullText = ""
        Me.cbotipoDocResp.Size = New System.Drawing.Size(166, 20)
        Me.cbotipoDocResp.TabIndex = 70
        '
        'txtAsuntoRes
        '
        Me.txtAsuntoRes.Location = New System.Drawing.Point(65, 78)
        Me.txtAsuntoRes.MenuManager = Me.RibbonControl
        Me.txtAsuntoRes.Name = "txtAsuntoRes"
        Me.txtAsuntoRes.Size = New System.Drawing.Size(457, 92)
        Me.txtAsuntoRes.TabIndex = 80
        Me.txtAsuntoRes.UseOptimizedRendering = True
        '
        'txtdocID
        '
        Me.txtdocID.Location = New System.Drawing.Point(80, 27)
        Me.txtdocID.MenuManager = Me.RibbonControl
        Me.txtdocID.Name = "txtdocID"
        Me.txtdocID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtdocID.Properties.Appearance.Options.UseBackColor = True
        Me.txtdocID.Size = New System.Drawing.Size(142, 20)
        Me.txtdocID.TabIndex = 65
        '
        'SaimtLabel35
        '
        Me.SaimtLabel35.Location = New System.Drawing.Point(9, 370)
        Me.SaimtLabel35.Name = "SaimtLabel35"
        Me.SaimtLabel35.Size = New System.Drawing.Size(209, 13)
        Me.SaimtLabel35.TabIndex = 12
        Me.SaimtLabel35.Text = "Puede agregar archivos de Microsoft Word."
        '
        'btnExaminarArchivo
        '
        Me.btnExaminarArchivo.Image = Global.Presentacion.My.Resources.Resources.examinar
        Me.btnExaminarArchivo.Location = New System.Drawing.Point(510, 386)
        Me.btnExaminarArchivo.Name = "btnExaminarArchivo"
        Me.btnExaminarArchivo.Size = New System.Drawing.Size(23, 22)
        Me.btnExaminarArchivo.TabIndex = 15
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(27, 30)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(44, 13)
        Me.SaimtLabel1.TabIndex = 64
        Me.SaimtLabel1.Text = "Cod. Doc"
        '
        'txtBuscarArchivo
        '
        Me.txtBuscarArchivo.Location = New System.Drawing.Point(8, 388)
        Me.txtBuscarArchivo.MenuManager = Me.RibbonControl
        Me.txtBuscarArchivo.Name = "txtBuscarArchivo"
        Me.txtBuscarArchivo.Properties.LookAndFeel.SkinName = "Seven"
        Me.txtBuscarArchivo.Properties.ReadOnly = True
        Me.txtBuscarArchivo.Size = New System.Drawing.Size(496, 20)
        Me.txtBuscarArchivo.TabIndex = 14
        '
        'cboEstadoMovimiento
        '
        Me.cboEstadoMovimiento.Location = New System.Drawing.Point(349, 85)
        Me.cboEstadoMovimiento.MenuManager = Me.RibbonControl
        Me.cboEstadoMovimiento.Name = "cboEstadoMovimiento"
        Me.cboEstadoMovimiento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboEstadoMovimiento.Properties.Appearance.Options.UseBackColor = True
        Me.cboEstadoMovimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstadoMovimiento.Properties.NullText = ""
        Me.cboEstadoMovimiento.Size = New System.Drawing.Size(159, 20)
        Me.cboEstadoMovimiento.TabIndex = 57
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(271, 88)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(72, 13)
        Me.SaimtLabel11.TabIndex = 56
        Me.SaimtLabel11.Text = "Estado Tramite"
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Image = CType(resources.GetObject("BtnEnviar.Image"), System.Drawing.Image)
        Me.BtnEnviar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnEnviar.Location = New System.Drawing.Point(214, 441)
        Me.BtnEnviar.LookAndFeel.SkinName = "Seven"
        Me.BtnEnviar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(64, 64)
        Me.BtnEnviar.TabIndex = 61
        Me.BtnEnviar.Text = "Reenviar"
        '
        'SaimtButton4
        '
        Me.SaimtButton4.Image = CType(resources.GetObject("SaimtButton4.Image"), System.Drawing.Image)
        Me.SaimtButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SaimtButton4.Location = New System.Drawing.Point(284, 441)
        Me.SaimtButton4.LookAndFeel.SkinName = "Seven"
        Me.SaimtButton4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SaimtButton4.Name = "SaimtButton4"
        Me.SaimtButton4.Size = New System.Drawing.Size(64, 64)
        Me.SaimtButton4.TabIndex = 62
        Me.SaimtButton4.Text = "Imprimir Flujo"
        '
        'ofdExaminarArchivos
        '
        Me.ofdExaminarArchivos.FileName = "OpenFileDialog1"
        '
        'frmEnviarDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 535)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.SaimtButton4)
        Me.Controls.Add(Me.SaimtGroupBox5)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmEnviarDoc"
        Me.Text = "Enviar Documento"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox5, 0)
        Me.Controls.SetChildIndex(Me.SaimtButton4, 0)
        Me.Controls.SetChildIndex(Me.BtnEnviar, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox5.ResumeLayout(False)
        Me.SaimtGroupBox5.PerformLayout()
        CType(Me.txtTrabajadorCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrabajador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEnviarCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtabAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtabAcciones.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtNroDocProv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGenerarNroProv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnioProv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsuntoProv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSiglasProv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chlbasuntos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage0.ResumeLayout(False)
        Me.XtraTabPage0.PerformLayout()
        CType(Me.txtNroDocResp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGenerarNroResp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnioResp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSiglasResp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbotipoDocResp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsuntoRes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdocID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox5 As SaimtControles.SaimtGroupBox
    Friend WithEvents cboEstadoMovimiento As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents txtdocID As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents BtnEnviar As SaimtControles.SaimtButton
    Friend WithEvents SaimtButton4 As SaimtControles.SaimtButton
    Friend WithEvents cboTipoAccion As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents xtabAcciones As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chlbasuntos As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents XtraTabPage0 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cbotipoDocResp As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtSiglasResp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExaminarArchivo As SaimtControles.SaimtButton
    Friend WithEvents txtBuscarArchivo As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel35 As SaimtControles.SaimtLabel
    Friend WithEvents txtAsuntoProv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSiglasProv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocPro As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtAnioProv As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAnioResp As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtAsuntoRes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ofdExaminarArchivos As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents chkGenerarNroProv As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGenerarNroResp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEnviarCC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblPersonaDeProv As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPersonaDeResp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTrabajador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuscarTrabajador As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents btnBuscarTrabajadorCC As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents txtTrabajadorCC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNroDocResp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNroDocProv As DevExpress.XtraEditors.TextEdit
End Class
