﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInmueblesConsultorActualizaciones
    Inherits Presentacion.frmConsultas

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInmueblesConsultorActualizaciones))
        Me.dgvResultado = New SaimtControles.SaimtDataGrid()
        Me.gvResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcNro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInmUbicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSupuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCampo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcfechaReg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcValorOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcValorNew = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMotivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcObs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcfechaUpd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFechaDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcinmUpdId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.btnSeleccionar = New SaimtControles.SaimtButton()
        Me.lblResultados = New SaimtControles.SaimtLabel()
        Me.SaimtLabel67 = New SaimtControles.SaimtLabel()
        Me.gbOtras = New SaimtControles.SaimtGroupBox()
        Me.cboAnio = New SaimtControles.SaimtComboBoxLookUp()
        Me.chkFechas2 = New SaimtControles.SaimtCheckBox()
        Me.cboCriterioFechaSub = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCriterioFecha = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtButton3 = New SaimtControles.SaimtButton()
        Me.SaimtButton2 = New SaimtControles.SaimtButton()
        Me.SaimtButton1 = New SaimtControles.SaimtButton()
        Me.chkFile = New SaimtControles.SaimtCheckBox()
        Me.cboCriterioFile = New System.Windows.Forms.ComboBox()
        Me.txtFile = New SaimtControles.SaimtTextBox()
        Me.chkRubros = New SaimtControles.SaimtCheckBox()
        Me.cboRubro = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboRubroGrupos = New SaimtControles.SaimtComboBoxLookUp()
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        Me.beprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.fbdExportar = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.gbOtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOtras.SuspendLayout()
        CType(Me.cboAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFechas2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterioFechaSub.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterioFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRubros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRubro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRubroGrupos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.beprogreso)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 511)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1036, 27)
        '
        'dgvResultado
        '
        Me.dgvResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultado.Location = New System.Drawing.Point(5, 51)
        Me.dgvResultado.MainView = Me.gvResultado
        Me.dgvResultado.MenuManager = Me.RibbonControl
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.Size = New System.Drawing.Size(1026, 266)
        Me.dgvResultado.TabIndex = 3
        Me.dgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResultado})
        '
        'gvResultado
        '
        Me.gvResultado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcNro, Me.gcCodigo, Me.gcInmUbicacion, Me.gcTipo, Me.gcSupuesto, Me.gcCampo, Me.gcfechaReg, Me.gcValorOld, Me.gcValorNew, Me.gcDoc, Me.gcMotivo, Me.gcObs, Me.gcfechaUpd, Me.gcFechaDoc, Me.gcinmUpdId})
        Me.gvResultado.GridControl = Me.dgvResultado
        Me.gvResultado.Name = "gvResultado"
        Me.gvResultado.OptionsBehavior.Editable = False
        Me.gvResultado.OptionsView.ColumnAutoWidth = False
        Me.gvResultado.OptionsView.ShowGroupPanel = False
        '
        'gcNro
        '
        Me.gcNro.Caption = "N°"
        Me.gcNro.FieldName = "nro"
        Me.gcNro.Name = "gcNro"
        Me.gcNro.Visible = True
        Me.gcNro.VisibleIndex = 0
        Me.gcNro.Width = 29
        '
        'gcCodigo
        '
        Me.gcCodigo.Caption = "Código Margesí MPT"
        Me.gcCodigo.FieldName = "codigo"
        Me.gcCodigo.Name = "gcCodigo"
        Me.gcCodigo.Visible = True
        Me.gcCodigo.VisibleIndex = 1
        '
        'gcInmUbicacion
        '
        Me.gcInmUbicacion.Caption = "Inmueble"
        Me.gcInmUbicacion.FieldName = "ubicacion"
        Me.gcInmUbicacion.Name = "gcInmUbicacion"
        Me.gcInmUbicacion.Visible = True
        Me.gcInmUbicacion.VisibleIndex = 2
        '
        'gcTipo
        '
        Me.gcTipo.Caption = "Tipo Actualización"
        Me.gcTipo.FieldName = "tipo"
        Me.gcTipo.Name = "gcTipo"
        Me.gcTipo.Visible = True
        Me.gcTipo.VisibleIndex = 3
        '
        'gcSupuesto
        '
        Me.gcSupuesto.Caption = "Supuesto de Actualización"
        Me.gcSupuesto.FieldName = "supuesto"
        Me.gcSupuesto.Name = "gcSupuesto"
        Me.gcSupuesto.Visible = True
        Me.gcSupuesto.VisibleIndex = 4
        '
        'gcCampo
        '
        Me.gcCampo.Caption = "Campo de Actualización"
        Me.gcCampo.FieldName = "campo"
        Me.gcCampo.Name = "gcCampo"
        Me.gcCampo.Visible = True
        Me.gcCampo.VisibleIndex = 5
        Me.gcCampo.Width = 70
        '
        'gcfechaReg
        '
        Me.gcfechaReg.Caption = "Fecha de registro de actualización"
        Me.gcfechaReg.FieldName = "fechaReg"
        Me.gcfechaReg.Name = "gcfechaReg"
        Me.gcfechaReg.Visible = True
        Me.gcfechaReg.VisibleIndex = 6
        '
        'gcValorOld
        '
        Me.gcValorOld.Caption = "Información Antigua"
        Me.gcValorOld.FieldName = "valorOld"
        Me.gcValorOld.Name = "gcValorOld"
        Me.gcValorOld.Visible = True
        Me.gcValorOld.VisibleIndex = 7
        '
        'gcValorNew
        '
        Me.gcValorNew.Caption = "Información actual"
        Me.gcValorNew.FieldName = "valorNew"
        Me.gcValorNew.Name = "gcValorNew"
        Me.gcValorNew.Visible = True
        Me.gcValorNew.VisibleIndex = 8
        '
        'gcDoc
        '
        Me.gcDoc.Caption = "Documento que aprueba la actualización"
        Me.gcDoc.FieldName = "doc"
        Me.gcDoc.Name = "gcDoc"
        Me.gcDoc.Visible = True
        Me.gcDoc.VisibleIndex = 9
        '
        'gcMotivo
        '
        Me.gcMotivo.Caption = "Motivo de Actualización"
        Me.gcMotivo.FieldName = "motivo"
        Me.gcMotivo.Name = "gcMotivo"
        Me.gcMotivo.Visible = True
        Me.gcMotivo.VisibleIndex = 10
        '
        'gcObs
        '
        Me.gcObs.Caption = "Observación"
        Me.gcObs.FieldName = "obs"
        Me.gcObs.Name = "gcObs"
        Me.gcObs.Visible = True
        Me.gcObs.VisibleIndex = 11
        '
        'gcfechaUpd
        '
        Me.gcfechaUpd.Caption = "FechaUpd"
        Me.gcfechaUpd.FieldName = "fechaUpd"
        Me.gcfechaUpd.Name = "gcfechaUpd"
        '
        'gcFechaDoc
        '
        Me.gcFechaDoc.Caption = "FechaDoc"
        Me.gcFechaDoc.FieldName = "fechaDoc"
        Me.gcFechaDoc.Name = "gcFechaDoc"
        '
        'gcinmUpdId
        '
        Me.gcinmUpdId.Caption = "inmUpdId"
        Me.gcinmUpdId.FieldName = "inmUpdId"
        Me.gcinmUpdId.Name = "gcinmUpdId"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.btnexportar)
        Me.SaimtGroupBox2.Controls.Add(Me.btnSeleccionar)
        Me.SaimtGroupBox2.Controls.Add(Me.lblResultados)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel67)
        Me.SaimtGroupBox2.Controls.Add(Me.dgvResultado)
        Me.SaimtGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(0, 151)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.ShowCaption = False
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(1036, 360)
        Me.SaimtGroupBox2.TabIndex = 17
        '
        'btnexportar
        '
        Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.Location = New System.Drawing.Point(894, 323)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(120, 31)
        Me.btnexportar.TabIndex = 18
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.Location = New System.Drawing.Point(492, 331)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 17
        Me.btnSeleccionar.Text = "Seleccionar"
        '
        'lblResultados
        '
        Me.lblResultados.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultados.Location = New System.Drawing.Point(682, 14)
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Size = New System.Drawing.Size(144, 13)
        Me.lblResultados.TabIndex = 4
        Me.lblResultados.Text = "Resultados de Busquedas"
        '
        'SaimtLabel67
        '
        Me.SaimtLabel67.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SaimtLabel67.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.SaimtLabel67.Location = New System.Drawing.Point(2, 2)
        Me.SaimtLabel67.Name = "SaimtLabel67"
        Me.SaimtLabel67.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.SaimtLabel67.Size = New System.Drawing.Size(1032, 18)
        Me.SaimtLabel67.TabIndex = 2
        Me.SaimtLabel67.Text = "De la lista ya buscada, en la caja de texto abajo; podras realizar cualquier sub " & _
            "consulta de cualquiera de los campos mostrados en la tabla."
        '
        'gbOtras
        '
        Me.gbOtras.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.gbOtras.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.gbOtras.Appearance.Options.UseBackColor = True
        Me.gbOtras.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.gbOtras.AppearanceCaption.Options.UseForeColor = True
        Me.gbOtras.Controls.Add(Me.cboAnio)
        Me.gbOtras.Controls.Add(Me.chkFechas2)
        Me.gbOtras.Controls.Add(Me.cboCriterioFechaSub)
        Me.gbOtras.Controls.Add(Me.cboCriterioFecha)
        Me.gbOtras.Controls.Add(Me.SaimtButton3)
        Me.gbOtras.Controls.Add(Me.SaimtButton2)
        Me.gbOtras.Controls.Add(Me.SaimtButton1)
        Me.gbOtras.Controls.Add(Me.chkFile)
        Me.gbOtras.Controls.Add(Me.cboCriterioFile)
        Me.gbOtras.Controls.Add(Me.txtFile)
        Me.gbOtras.Controls.Add(Me.chkRubros)
        Me.gbOtras.Controls.Add(Me.cboRubro)
        Me.gbOtras.Controls.Add(Me.cboRubroGrupos)
        Me.gbOtras.Location = New System.Drawing.Point(2, 5)
        Me.gbOtras.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gbOtras.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gbOtras.Name = "gbOtras"
        Me.gbOtras.Size = New System.Drawing.Size(1034, 140)
        Me.gbOtras.TabIndex = 18
        Me.gbOtras.Text = "Buscar por año y rubro seleccionado"
        '
        'cboAnio
        '
        Me.cboAnio.Location = New System.Drawing.Point(79, 30)
        Me.cboAnio.MenuManager = Me.RibbonControl
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAnio.Properties.NullText = ""
        Me.cboAnio.Size = New System.Drawing.Size(173, 20)
        Me.cboAnio.TabIndex = 115
        '
        'chkFechas2
        '
        Me.chkFechas2.EditValue = True
        Me.chkFechas2.Location = New System.Drawing.Point(9, 56)
        Me.chkFechas2.MenuManager = Me.RibbonControl
        Me.chkFechas2.Name = "chkFechas2"
        Me.chkFechas2.Properties.AutoWidth = True
        Me.chkFechas2.Properties.Caption = "Fechas :"
        Me.chkFechas2.Size = New System.Drawing.Size(63, 19)
        Me.chkFechas2.TabIndex = 114
        Me.chkFechas2.Tag = "NotClear"
        '
        'cboCriterioFechaSub
        '
        Me.cboCriterioFechaSub.Location = New System.Drawing.Point(258, 56)
        Me.cboCriterioFechaSub.MenuManager = Me.RibbonControl
        Me.cboCriterioFechaSub.Name = "cboCriterioFechaSub"
        Me.cboCriterioFechaSub.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioFechaSub.Properties.NullText = ""
        Me.cboCriterioFechaSub.Size = New System.Drawing.Size(163, 20)
        Me.cboCriterioFechaSub.TabIndex = 113
        '
        'cboCriterioFecha
        '
        Me.cboCriterioFecha.Location = New System.Drawing.Point(80, 56)
        Me.cboCriterioFecha.MenuManager = Me.RibbonControl
        Me.cboCriterioFecha.Name = "cboCriterioFecha"
        Me.cboCriterioFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioFecha.Properties.NullText = ""
        Me.cboCriterioFecha.Size = New System.Drawing.Size(172, 20)
        Me.cboCriterioFecha.TabIndex = 112
        '
        'SaimtButton3
        '
        Me.SaimtButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SaimtButton3.Appearance.Options.UseFont = True
        Me.SaimtButton3.Image = Global.Presentacion.My.Resources.Resources.buscar32
        Me.SaimtButton3.Location = New System.Drawing.Point(845, 33)
        Me.SaimtButton3.LookAndFeel.SkinName = "Seven"
        Me.SaimtButton3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SaimtButton3.Name = "SaimtButton3"
        Me.SaimtButton3.Size = New System.Drawing.Size(167, 59)
        Me.SaimtButton3.TabIndex = 110
        Me.SaimtButton3.Text = "Cancelados"
        '
        'SaimtButton2
        '
        Me.SaimtButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SaimtButton2.Appearance.Options.UseFont = True
        Me.SaimtButton2.Image = Global.Presentacion.My.Resources.Resources.buscar32
        Me.SaimtButton2.Location = New System.Drawing.Point(672, 32)
        Me.SaimtButton2.LookAndFeel.SkinName = "Seven"
        Me.SaimtButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SaimtButton2.Name = "SaimtButton2"
        Me.SaimtButton2.Size = New System.Drawing.Size(167, 59)
        Me.SaimtButton2.TabIndex = 1
        Me.SaimtButton2.Text = "Saneados"
        '
        'SaimtButton1
        '
        Me.SaimtButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SaimtButton1.Appearance.Options.UseFont = True
        Me.SaimtButton1.Image = Global.Presentacion.My.Resources.Resources.buscar32
        Me.SaimtButton1.Location = New System.Drawing.Point(499, 32)
        Me.SaimtButton1.LookAndFeel.SkinName = "Seven"
        Me.SaimtButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SaimtButton1.Name = "SaimtButton1"
        Me.SaimtButton1.Size = New System.Drawing.Size(167, 59)
        Me.SaimtButton1.TabIndex = 101
        Me.SaimtButton1.Text = "Buscar todas las " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "actualizaciones"
        '
        'chkFile
        '
        Me.chkFile.EditValue = True
        Me.chkFile.Location = New System.Drawing.Point(9, 116)
        Me.chkFile.MenuManager = Me.RibbonControl
        Me.chkFile.Name = "chkFile"
        Me.chkFile.Properties.AutoWidth = True
        Me.chkFile.Properties.Caption = "File :"
        Me.chkFile.Size = New System.Drawing.Size(45, 19)
        Me.chkFile.TabIndex = 97
        Me.chkFile.Tag = "NotClear"
        '
        'cboCriterioFile
        '
        Me.cboCriterioFile.FormattingEnabled = True
        Me.cboCriterioFile.Items.AddRange(New Object() {"File", "File Ant."})
        Me.cboCriterioFile.Location = New System.Drawing.Point(79, 114)
        Me.cboCriterioFile.Name = "cboCriterioFile"
        Me.cboCriterioFile.Size = New System.Drawing.Size(173, 21)
        Me.cboCriterioFile.TabIndex = 96
        '
        'txtFile
        '
        Me.txtFile.EditValue = ""
        Me.txtFile.Location = New System.Drawing.Point(258, 114)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(163, 20)
        Me.txtFile.TabIndex = 95
        '
        'chkRubros
        '
        Me.chkRubros.EditValue = True
        Me.chkRubros.Location = New System.Drawing.Point(9, 86)
        Me.chkRubros.MenuManager = Me.RibbonControl
        Me.chkRubros.Name = "chkRubros"
        Me.chkRubros.Properties.AutoWidth = True
        Me.chkRubros.Properties.Caption = "Rubros :"
        Me.chkRubros.Size = New System.Drawing.Size(63, 19)
        Me.chkRubros.TabIndex = 94
        Me.chkRubros.Tag = "NotClear"
        '
        'cboRubro
        '
        Me.cboRubro.Location = New System.Drawing.Point(258, 85)
        Me.cboRubro.MenuManager = Me.RibbonControl
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRubro.Properties.LookAndFeel.SkinName = "Seven"
        Me.cboRubro.Properties.NullText = ""
        Me.cboRubro.Size = New System.Drawing.Size(163, 20)
        Me.cboRubro.TabIndex = 93
        '
        'cboRubroGrupos
        '
        Me.cboRubroGrupos.Location = New System.Drawing.Point(79, 85)
        Me.cboRubroGrupos.MenuManager = Me.RibbonControl
        Me.cboRubroGrupos.Name = "cboRubroGrupos"
        Me.cboRubroGrupos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRubroGrupos.Properties.LookAndFeel.SkinName = "Seven"
        Me.cboRubroGrupos.Properties.NullText = ""
        Me.cboRubroGrupos.Size = New System.Drawing.Size(173, 20)
        Me.cboRubroGrupos.TabIndex = 92
        '
        'beprogreso
        '
        Me.beprogreso.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.beprogreso.Edit = Me.RepositoryItemProgressBar1
        Me.beprogreso.Id = 4
        Me.beprogreso.Name = "beprogreso"
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'frmInmueblesConsultorActualizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonBuscar = Me.SaimtButton1
        Me.ButtonSeleccionar = Me.btnSeleccionar
        Me.ClientSize = New System.Drawing.Size(1036, 538)
        Me.Controls.Add(Me.gbOtras)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmInmueblesConsultorActualizaciones"
        Me.SaimtGrid = Me.dgvResultado
        Me.Text = "Consultor de Actualizaciones"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.gbOtras, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.gbOtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOtras.ResumeLayout(False)
        Me.gbOtras.PerformLayout()
        CType(Me.cboAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFechas2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterioFechaSub.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterioFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRubros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRubro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRubroGrupos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvResultado As SaimtControles.SaimtDataGrid
    Friend WithEvents gvResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcValorNew As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCampo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcfechaReg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcValorOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel67 As SaimtControles.SaimtLabel
    Friend WithEvents lblResultados As SaimtControles.SaimtLabel
    Friend WithEvents gbOtras As SaimtControles.SaimtGroupBox
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents btnSeleccionar As SaimtControles.SaimtButton
    Friend WithEvents sfdexportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gcInmUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkFile As SaimtControles.SaimtCheckBox
    Friend WithEvents cboCriterioFile As System.Windows.Forms.ComboBox
    Friend WithEvents txtFile As SaimtControles.SaimtTextBox
    Friend WithEvents chkRubros As SaimtControles.SaimtCheckBox
    Friend WithEvents cboRubro As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboRubroGrupos As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtButton1 As SaimtControles.SaimtButton
    Friend WithEvents gcNro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSupuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtButton3 As SaimtControles.SaimtButton
    Friend WithEvents SaimtButton2 As SaimtControles.SaimtButton
    Friend WithEvents chkFechas2 As SaimtControles.SaimtCheckBox
    Friend WithEvents cboCriterioFechaSub As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboCriterioFecha As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents beprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents fbdExportar As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents gcfechaUpd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcFechaDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboAnio As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents gcinmUpdId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMotivo As DevExpress.XtraGrid.Columns.GridColumn
End Class