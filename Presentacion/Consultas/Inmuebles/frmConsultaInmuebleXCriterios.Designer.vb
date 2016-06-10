<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaInmuebleXCriterios
    Inherits frmConsultas

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaInmuebleXCriterios))
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        Me.gbFile = New SaimtControles.SaimtGroupBox()
        Me.cboDisponibilidad = New SaimtControles.SaimtComboBox()
        Me.chkDisponibilidad = New SaimtControles.SaimtCheckBox()
        Me.chkCondicionRegistral = New SaimtControles.SaimtCheckBox()
        Me.chkPartidaElectronica = New SaimtControles.SaimtCheckBox()
        Me.chkCondicionLegal = New SaimtControles.SaimtCheckBox()
        Me.chkEstadoSanemiento = New SaimtControles.SaimtCheckBox()
        Me.chkRubros = New SaimtControles.SaimtCheckBox()
        Me.chkZonificacionUso = New SaimtControles.SaimtCheckBox()
        Me.chkEstadoConservacion = New SaimtControles.SaimtCheckBox()
        Me.chkSituacionFisica = New SaimtControles.SaimtCheckBox()
        Me.cboEstadoConservacion = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboSFinformacion = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.cboSituacionFisica = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboEstadoSaneamiento = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCondicionLegal = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCondicionRegistral = New SaimtControles.SaimtComboBoxLookUp()
        Me.txtPartElectronica = New SaimtControles.SaimtTextBox()
        Me.chkCriteriosInmEstado1 = New SaimtControles.SaimtCheckBox()
        Me.btnLimpiarFile = New SaimtControles.SaimtButton()
        Me.cboRubro = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboRubroGrupos = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtButton1 = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.dgvResultado = New SaimtControles.SaimtDataGrid()
        Me.gvResultado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gband1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcRubro = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.inmDenominacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcAream2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcValorxm2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcValorTerreno = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcValorEdificacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcValorTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridColumn12 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcInmSaneadoObsMostrable = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.SaimtLabel67 = New SaimtControles.SaimtLabel()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.btnSeleccionar = New SaimtControles.SaimtButton()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFile.SuspendLayout()
        CType(Me.cboDisponibilidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDisponibilidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCondicionRegistral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPartidaElectronica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCondicionLegal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstadoSanemiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRubros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkZonificacionUso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstadoConservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSituacionFisica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoConservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSFinformacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSituacionFisica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoSaneamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCondicionLegal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCondicionRegistral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartElectronica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCriteriosInmEstado1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRubro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRubroGrupos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 623)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1116, 27)
        '
        'gbFile
        '
        Me.gbFile.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.gbFile.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.gbFile.Appearance.Options.UseBackColor = True
        Me.gbFile.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.gbFile.AppearanceCaption.Options.UseForeColor = True
        Me.gbFile.Controls.Add(Me.cboDisponibilidad)
        Me.gbFile.Controls.Add(Me.chkDisponibilidad)
        Me.gbFile.Controls.Add(Me.chkCondicionRegistral)
        Me.gbFile.Controls.Add(Me.chkPartidaElectronica)
        Me.gbFile.Controls.Add(Me.chkCondicionLegal)
        Me.gbFile.Controls.Add(Me.chkEstadoSanemiento)
        Me.gbFile.Controls.Add(Me.chkRubros)
        Me.gbFile.Controls.Add(Me.chkZonificacionUso)
        Me.gbFile.Controls.Add(Me.chkEstadoConservacion)
        Me.gbFile.Controls.Add(Me.chkSituacionFisica)
        Me.gbFile.Controls.Add(Me.cboEstadoConservacion)
        Me.gbFile.Controls.Add(Me.cboSFinformacion)
        Me.gbFile.Controls.Add(Me.SaimtLabel2)
        Me.gbFile.Controls.Add(Me.cboSituacionFisica)
        Me.gbFile.Controls.Add(Me.cboEstadoSaneamiento)
        Me.gbFile.Controls.Add(Me.cboCondicionLegal)
        Me.gbFile.Controls.Add(Me.cboCondicionRegistral)
        Me.gbFile.Controls.Add(Me.txtPartElectronica)
        Me.gbFile.Controls.Add(Me.chkCriteriosInmEstado1)
        Me.gbFile.Controls.Add(Me.btnLimpiarFile)
        Me.gbFile.Controls.Add(Me.cboRubro)
        Me.gbFile.Controls.Add(Me.cboRubroGrupos)
        Me.gbFile.Controls.Add(Me.SaimtLabel1)
        Me.gbFile.Controls.Add(Me.SaimtButton1)
        Me.gbFile.Location = New System.Drawing.Point(12, 8)
        Me.gbFile.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gbFile.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gbFile.Name = "gbFile"
        Me.gbFile.Size = New System.Drawing.Size(1081, 192)
        Me.gbFile.TabIndex = 14
        Me.gbFile.Text = "Buscar x Criterios"
        '
        'cboDisponibilidad
        '
        Me.cboDisponibilidad.Location = New System.Drawing.Point(562, 112)
        Me.cboDisponibilidad.MenuManager = Me.RibbonControl
        Me.cboDisponibilidad.Name = "cboDisponibilidad"
        Me.cboDisponibilidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDisponibilidad.Properties.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboDisponibilidad.Size = New System.Drawing.Size(187, 20)
        Me.cboDisponibilidad.TabIndex = 86
        '
        'chkDisponibilidad
        '
        Me.chkDisponibilidad.Location = New System.Drawing.Point(442, 112)
        Me.chkDisponibilidad.MenuManager = Me.RibbonControl
        Me.chkDisponibilidad.Name = "chkDisponibilidad"
        Me.chkDisponibilidad.Properties.AutoWidth = True
        Me.chkDisponibilidad.Properties.Caption = "Disponibilidad :"
        Me.chkDisponibilidad.Size = New System.Drawing.Size(94, 19)
        Me.chkDisponibilidad.TabIndex = 85
        Me.chkDisponibilidad.Tag = "NotClear"
        '
        'chkCondicionRegistral
        '
        Me.chkCondicionRegistral.Location = New System.Drawing.Point(37, 33)
        Me.chkCondicionRegistral.MenuManager = Me.RibbonControl
        Me.chkCondicionRegistral.Name = "chkCondicionRegistral"
        Me.chkCondicionRegistral.Properties.AutoWidth = True
        Me.chkCondicionRegistral.Properties.Caption = "Condición Registral :"
        Me.chkCondicionRegistral.Size = New System.Drawing.Size(121, 19)
        Me.chkCondicionRegistral.TabIndex = 83
        Me.chkCondicionRegistral.Tag = "NotClear"
        '
        'chkPartidaElectronica
        '
        Me.chkPartidaElectronica.Location = New System.Drawing.Point(37, 59)
        Me.chkPartidaElectronica.MenuManager = Me.RibbonControl
        Me.chkPartidaElectronica.Name = "chkPartidaElectronica"
        Me.chkPartidaElectronica.Properties.AutoWidth = True
        Me.chkPartidaElectronica.Properties.Caption = "Partida Electrónica :"
        Me.chkPartidaElectronica.Size = New System.Drawing.Size(119, 19)
        Me.chkPartidaElectronica.TabIndex = 82
        Me.chkPartidaElectronica.Tag = "NotClear"
        '
        'chkCondicionLegal
        '
        Me.chkCondicionLegal.Location = New System.Drawing.Point(50, 87)
        Me.chkCondicionLegal.MenuManager = Me.RibbonControl
        Me.chkCondicionLegal.Name = "chkCondicionLegal"
        Me.chkCondicionLegal.Properties.AutoWidth = True
        Me.chkCondicionLegal.Properties.Caption = "Condición Legal :"
        Me.chkCondicionLegal.Size = New System.Drawing.Size(104, 19)
        Me.chkCondicionLegal.TabIndex = 81
        Me.chkCondicionLegal.Tag = "NotClear"
        '
        'chkEstadoSanemiento
        '
        Me.chkEstadoSanemiento.Location = New System.Drawing.Point(11, 112)
        Me.chkEstadoSanemiento.MenuManager = Me.RibbonControl
        Me.chkEstadoSanemiento.Name = "chkEstadoSanemiento"
        Me.chkEstadoSanemiento.Properties.AutoWidth = True
        Me.chkEstadoSanemiento.Properties.Caption = "Estado del Saneamiento :"
        Me.chkEstadoSanemiento.Size = New System.Drawing.Size(145, 19)
        Me.chkEstadoSanemiento.TabIndex = 80
        Me.chkEstadoSanemiento.Tag = "NotClear"
        '
        'chkRubros
        '
        Me.chkRubros.Location = New System.Drawing.Point(92, 138)
        Me.chkRubros.MenuManager = Me.RibbonControl
        Me.chkRubros.Name = "chkRubros"
        Me.chkRubros.Properties.AutoWidth = True
        Me.chkRubros.Properties.Caption = "Rubros :"
        Me.chkRubros.Size = New System.Drawing.Size(64, 19)
        Me.chkRubros.TabIndex = 79
        Me.chkRubros.Tag = "NotClear"
        '
        'chkZonificacionUso
        '
        Me.chkZonificacionUso.Location = New System.Drawing.Point(442, 86)
        Me.chkZonificacionUso.MenuManager = Me.RibbonControl
        Me.chkZonificacionUso.Name = "chkZonificacionUso"
        Me.chkZonificacionUso.Properties.AutoWidth = True
        Me.chkZonificacionUso.Properties.Caption = "Zonificación / Uso :"
        Me.chkZonificacionUso.Size = New System.Drawing.Size(114, 19)
        Me.chkZonificacionUso.TabIndex = 78
        Me.chkZonificacionUso.Tag = "NotClear"
        '
        'chkEstadoConservacion
        '
        Me.chkEstadoConservacion.Location = New System.Drawing.Point(424, 59)
        Me.chkEstadoConservacion.MenuManager = Me.RibbonControl
        Me.chkEstadoConservacion.Name = "chkEstadoConservacion"
        Me.chkEstadoConservacion.Properties.AutoWidth = True
        Me.chkEstadoConservacion.Properties.Caption = "Est. de Conservación :"
        Me.chkEstadoConservacion.Size = New System.Drawing.Size(132, 19)
        Me.chkEstadoConservacion.TabIndex = 77
        Me.chkEstadoConservacion.Tag = "NotClear"
        '
        'chkSituacionFisica
        '
        Me.chkSituacionFisica.Location = New System.Drawing.Point(475, 33)
        Me.chkSituacionFisica.MenuManager = Me.RibbonControl
        Me.chkSituacionFisica.Name = "chkSituacionFisica"
        Me.chkSituacionFisica.Properties.AutoWidth = True
        Me.chkSituacionFisica.Properties.Caption = "Uso Actual :"
        Me.chkSituacionFisica.Size = New System.Drawing.Size(81, 19)
        Me.chkSituacionFisica.TabIndex = 76
        Me.chkSituacionFisica.Tag = "NotClear"
        '
        'cboEstadoConservacion
        '
        Me.cboEstadoConservacion.Location = New System.Drawing.Point(562, 59)
        Me.cboEstadoConservacion.MenuManager = Me.RibbonControl
        Me.cboEstadoConservacion.Name = "cboEstadoConservacion"
        Me.cboEstadoConservacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstadoConservacion.Properties.NullText = ""
        Me.cboEstadoConservacion.Size = New System.Drawing.Size(187, 20)
        Me.cboEstadoConservacion.TabIndex = 75
        '
        'cboSFinformacion
        '
        Me.cboSFinformacion.Location = New System.Drawing.Point(562, 85)
        Me.cboSFinformacion.MenuManager = Me.RibbonControl
        Me.cboSFinformacion.Name = "cboSFinformacion"
        Me.cboSFinformacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSFinformacion.Properties.NullText = ""
        Me.cboSFinformacion.Size = New System.Drawing.Size(187, 20)
        Me.cboSFinformacion.TabIndex = 74
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(460, 87)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(0, 13)
        Me.SaimtLabel2.TabIndex = 73
        '
        'cboSituacionFisica
        '
        Me.cboSituacionFisica.Location = New System.Drawing.Point(562, 35)
        Me.cboSituacionFisica.MenuManager = Me.RibbonControl
        Me.cboSituacionFisica.Name = "cboSituacionFisica"
        Me.cboSituacionFisica.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSituacionFisica.Properties.NullText = ""
        Me.cboSituacionFisica.Size = New System.Drawing.Size(187, 20)
        Me.cboSituacionFisica.TabIndex = 71
        '
        'cboEstadoSaneamiento
        '
        Me.cboEstadoSaneamiento.Location = New System.Drawing.Point(161, 112)
        Me.cboEstadoSaneamiento.MenuManager = Me.RibbonControl
        Me.cboEstadoSaneamiento.Name = "cboEstadoSaneamiento"
        Me.cboEstadoSaneamiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstadoSaneamiento.Properties.NullText = ""
        Me.cboEstadoSaneamiento.Size = New System.Drawing.Size(220, 20)
        Me.cboEstadoSaneamiento.TabIndex = 67
        '
        'cboCondicionLegal
        '
        Me.cboCondicionLegal.Location = New System.Drawing.Point(161, 85)
        Me.cboCondicionLegal.MenuManager = Me.RibbonControl
        Me.cboCondicionLegal.Name = "cboCondicionLegal"
        Me.cboCondicionLegal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCondicionLegal.Properties.NullText = ""
        Me.cboCondicionLegal.Size = New System.Drawing.Size(220, 20)
        Me.cboCondicionLegal.TabIndex = 65
        '
        'cboCondicionRegistral
        '
        Me.cboCondicionRegistral.Location = New System.Drawing.Point(161, 34)
        Me.cboCondicionRegistral.MenuManager = Me.RibbonControl
        Me.cboCondicionRegistral.Name = "cboCondicionRegistral"
        Me.cboCondicionRegistral.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCondicionRegistral.Properties.NullText = ""
        Me.cboCondicionRegistral.Size = New System.Drawing.Size(220, 20)
        Me.cboCondicionRegistral.TabIndex = 63
        '
        'txtPartElectronica
        '
        Me.txtPartElectronica.EditValue = ""
        Me.txtPartElectronica.Location = New System.Drawing.Point(161, 59)
        Me.txtPartElectronica.Name = "txtPartElectronica"
        Me.txtPartElectronica.Properties.LookAndFeel.SkinName = "Seven"
        Me.txtPartElectronica.Size = New System.Drawing.Size(220, 20)
        Me.txtPartElectronica.TabIndex = 58
        '
        'chkCriteriosInmEstado1
        '
        Me.chkCriteriosInmEstado1.EditValue = True
        Me.chkCriteriosInmEstado1.Location = New System.Drawing.Point(560, 139)
        Me.chkCriteriosInmEstado1.MenuManager = Me.RibbonControl
        Me.chkCriteriosInmEstado1.Name = "chkCriteriosInmEstado1"
        Me.chkCriteriosInmEstado1.Properties.AutoWidth = True
        Me.chkCriteriosInmEstado1.Properties.Caption = "Registrados"
        Me.chkCriteriosInmEstado1.Size = New System.Drawing.Size(80, 19)
        Me.chkCriteriosInmEstado1.TabIndex = 56
        Me.chkCriteriosInmEstado1.Tag = "NotClear"
        '
        'btnLimpiarFile
        '
        Me.btnLimpiarFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiarFile.Image = CType(resources.GetObject("btnLimpiarFile.Image"), System.Drawing.Image)
        Me.btnLimpiarFile.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiarFile.Location = New System.Drawing.Point(879, 24)
        Me.btnLimpiarFile.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiarFile.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiarFile.Name = "btnLimpiarFile"
        Me.btnLimpiarFile.Size = New System.Drawing.Size(64, 53)
        Me.btnLimpiarFile.TabIndex = 40
        '
        'cboRubro
        '
        Me.cboRubro.Location = New System.Drawing.Point(324, 138)
        Me.cboRubro.MenuManager = Me.RibbonControl
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRubro.Properties.LookAndFeel.SkinName = "Seven"
        Me.cboRubro.Properties.NullText = ""
        Me.cboRubro.Size = New System.Drawing.Size(140, 20)
        Me.cboRubro.TabIndex = 39
        '
        'cboRubroGrupos
        '
        Me.cboRubroGrupos.Location = New System.Drawing.Point(161, 138)
        Me.cboRubroGrupos.MenuManager = Me.RibbonControl
        Me.cboRubroGrupos.Name = "cboRubroGrupos"
        Me.cboRubroGrupos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRubroGrupos.Properties.LookAndFeel.SkinName = "Seven"
        Me.cboRubroGrupos.Properties.NullText = ""
        Me.cboRubroGrupos.Size = New System.Drawing.Size(157, 20)
        Me.cboRubroGrupos.TabIndex = 38
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(89, 141)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(0, 13)
        Me.SaimtLabel1.TabIndex = 37
        '
        'SaimtButton1
        '
        Me.SaimtButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SaimtButton1.Appearance.Options.UseFont = True
        Me.SaimtButton1.Image = Global.Presentacion.My.Resources.Resources.buscar32
        Me.SaimtButton1.Location = New System.Drawing.Point(954, 21)
        Me.SaimtButton1.LookAndFeel.SkinName = "Seven"
        Me.SaimtButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SaimtButton1.Name = "SaimtButton1"
        Me.SaimtButton1.Size = New System.Drawing.Size(120, 59)
        Me.SaimtButton1.TabIndex = 36
        Me.SaimtButton1.Text = "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inmueble"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox2.Controls.Add(Me.dgvResultado)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel67)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(12, 206)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.ShowCaption = False
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(1081, 367)
        Me.SaimtGroupBox2.TabIndex = 15
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel7.Location = New System.Drawing.Point(778, 36)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(144, 13)
        Me.SaimtLabel7.TabIndex = 3
        Me.SaimtLabel7.Text = "Resultados de Busquedas"
        '
        'dgvResultado
        '
        Me.dgvResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResultado.Location = New System.Drawing.Point(2, 20)
        Me.dgvResultado.MainView = Me.gvResultado
        Me.dgvResultado.MenuManager = Me.RibbonControl
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.dgvResultado.Size = New System.Drawing.Size(1077, 345)
        Me.dgvResultado.TabIndex = 0
        Me.dgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResultado})
        '
        'gvResultado
        '
        Me.gvResultado.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gband1, Me.gridBand2, Me.GridBand1, Me.GridBand3, Me.GridBand4, Me.GridBand5, Me.GridBand6})
        Me.gvResultado.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.inmDenominacion, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.gcRubro, Me.gcAream2, Me.gcValorxm2, Me.gcValorTerreno, Me.gcValorEdificacion, Me.gcValorTotal, Me.gcInmSaneadoObsMostrable})
        Me.gvResultado.GridControl = Me.dgvResultado
        Me.gvResultado.Name = "gvResultado"
        Me.gvResultado.OptionsBehavior.Editable = False
        Me.gvResultado.OptionsFind.AlwaysVisible = True
        Me.gvResultado.OptionsPrint.AutoWidth = False
        Me.gvResultado.OptionsView.ColumnAutoWidth = False
        Me.gvResultado.OptionsView.ShowGroupPanel = False
        '
        'gband1
        '
        Me.gband1.Caption = "Codigo Margesí"
        Me.gband1.Columns.Add(Me.GridColumn1)
        Me.gband1.Columns.Add(Me.gcRubro)
        Me.gband1.MinWidth = 20
        Me.gband1.Name = "gband1"
        Me.gband1.Width = 117
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "File y Rubro"
        Me.GridColumn1.FieldName = "inmFile"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.Width = 117
        '
        'gcRubro
        '
        Me.gcRubro.Caption = "Rubro "
        Me.gcRubro.FieldName = "TgRubro"
        Me.gcRubro.Name = "gcRubro"
        '
        'gridBand2
        '
        Me.gridBand2.Columns.Add(Me.GridColumn2)
        Me.gridBand2.MinWidth = 20
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.Width = 118
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "N° Antiguo File"
        Me.GridColumn2.FieldName = "inmFileAnt"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.Width = 118
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "Datos Basicos"
        Me.GridBand1.Columns.Add(Me.GridColumn3)
        Me.GridBand1.Columns.Add(Me.GridColumn4)
        Me.GridBand1.Columns.Add(Me.inmDenominacion)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 222
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Ubicación"
        Me.GridColumn3.FieldName = "inmUbicacion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.Width = 74
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Finca Inscrita"
        Me.GridColumn4.FieldName = "inmInscrito"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.Width = 74
        '
        'inmDenominacion
        '
        Me.inmDenominacion.Caption = "Denominación"
        Me.inmDenominacion.FieldName = "inmDenominacion"
        Me.inmDenominacion.Name = "inmDenominacion"
        Me.inmDenominacion.Visible = True
        Me.inmDenominacion.Width = 74
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.Caption = "Situación Legal"
        Me.GridBand3.Columns.Add(Me.GridColumn5)
        Me.GridBand3.Columns.Add(Me.GridColumn6)
        Me.GridBand3.Columns.Add(Me.GridColumn7)
        Me.GridBand3.Columns.Add(Me.GridColumn8)
        Me.GridBand3.MinWidth = 20
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 378
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Condición Registral"
        Me.GridColumn5.FieldName = "tgInmCondReg"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.Width = 121
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Partida Electronica"
        Me.GridColumn6.FieldName = "inmPartidaElec"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.Width = 74
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Condición Legal"
        Me.GridColumn7.FieldName = "tgInmCondLegal"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.Width = 109
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Proceso de Saneamiento"
        Me.GridColumn8.FieldName = "tgEstSan"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.Width = 74
        '
        'GridBand4
        '
        Me.GridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand4.Caption = "Situación Fisica"
        Me.GridBand4.Columns.Add(Me.gcAream2)
        Me.GridBand4.Columns.Add(Me.GridColumn9)
        Me.GridBand4.Columns.Add(Me.GridColumn10)
        Me.GridBand4.Columns.Add(Me.GridColumn11)
        Me.GridBand4.MinWidth = 20
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 297
        '
        'gcAream2
        '
        Me.gcAream2.Caption = "Area m2"
        Me.gcAream2.FieldName = "InmPredArea"
        Me.gcAream2.Name = "gcAream2"
        Me.gcAream2.Visible = True
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Uso Actual"
        Me.GridColumn9.FieldName = "tgInmSitFisica"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.Width = 74
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Zonificación/Uso"
        Me.GridColumn10.FieldName = "tgInmSFUso"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.Width = 74
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Estado de Conservación"
        Me.GridColumn11.FieldName = "tgEstInmConsv"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.Width = 74
        '
        'GridBand5
        '
        Me.GridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand5.Caption = "Valor Comercial"
        Me.GridBand5.Columns.Add(Me.gcValorxm2)
        Me.GridBand5.Columns.Add(Me.gcValorTerreno)
        Me.GridBand5.Columns.Add(Me.gcValorEdificacion)
        Me.GridBand5.Columns.Add(Me.gcValorTotal)
        Me.GridBand5.MinWidth = 20
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 300
        '
        'gcValorxm2
        '
        Me.gcValorxm2.Caption = "Valor x m2"
        Me.gcValorxm2.FieldName = "InmValComValxMetro"
        Me.gcValorxm2.Name = "gcValorxm2"
        Me.gcValorxm2.Visible = True
        '
        'gcValorTerreno
        '
        Me.gcValorTerreno.Caption = "Valor del Terreno"
        Me.gcValorTerreno.FieldName = "InmValComValTerreno"
        Me.gcValorTerreno.Name = "gcValorTerreno"
        Me.gcValorTerreno.Visible = True
        '
        'gcValorEdificacion
        '
        Me.gcValorEdificacion.Caption = "Valor de Edificación"
        Me.gcValorEdificacion.FieldName = "InmValComValConst"
        Me.gcValorEdificacion.Name = "gcValorEdificacion"
        Me.gcValorEdificacion.Visible = True
        '
        'gcValorTotal
        '
        Me.gcValorTotal.Caption = "Valor Total"
        Me.gcValorTotal.FieldName = "InmValComValTotal"
        Me.gcValorTotal.Name = "gcValorTotal"
        Me.gcValorTotal.Visible = True
        '
        'GridBand6
        '
        Me.GridBand6.Columns.Add(Me.GridColumn12)
        Me.GridBand6.Columns.Add(Me.GridColumn13)
        Me.GridBand6.Columns.Add(Me.gcInmSaneadoObsMostrable)
        Me.GridBand6.MinWidth = 20
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.Width = 244
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Disponibilidad"
        Me.GridColumn12.FieldName = "inmDisponibilidad"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.Width = 74
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Código Informático"
        Me.GridColumn13.FieldName = "inmId"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.Width = 95
        '
        'gcInmSaneadoObsMostrable
        '
        Me.gcInmSaneadoObsMostrable.Caption = "Observación"
        Me.gcInmSaneadoObsMostrable.FieldName = "InmSaneadoObsMostrable"
        Me.gcInmSaneadoObsMostrable.Name = "gcInmSaneadoObsMostrable"
        Me.gcInmSaneadoObsMostrable.Visible = True
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'SaimtLabel67
        '
        Me.SaimtLabel67.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SaimtLabel67.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.SaimtLabel67.Location = New System.Drawing.Point(2, 2)
        Me.SaimtLabel67.Name = "SaimtLabel67"
        Me.SaimtLabel67.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.SaimtLabel67.Size = New System.Drawing.Size(1077, 18)
        Me.SaimtLabel67.TabIndex = 2
        Me.SaimtLabel67.Text = "De la lista ya buscada, en la caja de texto abajo; podras realizar cualquier sub " & _
            "consulta de cualquiera de los campos mostrados en la tabla."
        '
        'btnexportar
        '
        Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.Location = New System.Drawing.Point(973, 579)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(120, 31)
        Me.btnexportar.TabIndex = 17
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.Location = New System.Drawing.Point(485, 579)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 16
        Me.btnSeleccionar.Text = "Seleccionar"
        '
        'frmConsultaInmuebleXCriterios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonBuscar = Me.SaimtButton1
        Me.ButtonSeleccionar = Me.btnSeleccionar
        Me.ClientSize = New System.Drawing.Size(1116, 650)
        Me.Controls.Add(Me.btnexportar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.Controls.Add(Me.gbFile)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmConsultaInmuebleXCriterios"
        Me.Text = "CONSULTOR POR CRITERIOS"
        Me.Controls.SetChildIndex(Me.gbFile, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.btnSeleccionar, 0)
        Me.Controls.SetChildIndex(Me.btnexportar, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFile.ResumeLayout(False)
        Me.gbFile.PerformLayout()
        CType(Me.cboDisponibilidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDisponibilidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCondicionRegistral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPartidaElectronica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCondicionLegal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstadoSanemiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRubros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkZonificacionUso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstadoConservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSituacionFisica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoConservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSFinformacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSituacionFisica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoSaneamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCondicionLegal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCondicionRegistral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartElectronica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCriteriosInmEstado1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRubro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRubroGrupos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sfdexportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gbFile As SaimtControles.SaimtGroupBox
    Friend WithEvents chkCriteriosInmEstado1 As SaimtControles.SaimtCheckBox
    Friend WithEvents btnLimpiarFile As SaimtControles.SaimtButton
    Friend WithEvents cboRubro As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboRubroGrupos As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtButton1 As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents dgvResultado As SaimtControles.SaimtDataGrid
    Friend WithEvents gvResultado As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents inmDenominacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SaimtLabel67 As SaimtControles.SaimtLabel
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents btnSeleccionar As SaimtControles.SaimtButton
    Friend WithEvents cboEstadoSaneamiento As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboCondicionLegal As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboCondicionRegistral As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtPartElectronica As SaimtControles.SaimtTextBox
    Friend WithEvents cboEstadoConservacion As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboSFinformacion As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents cboSituacionFisica As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents gcRubro As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcValorxm2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcValorTerreno As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcValorEdificacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcValorTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcAream2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents chkCondicionRegistral As SaimtControles.SaimtCheckBox
    Friend WithEvents chkPartidaElectronica As SaimtControles.SaimtCheckBox
    Friend WithEvents chkCondicionLegal As SaimtControles.SaimtCheckBox
    Friend WithEvents chkEstadoSanemiento As SaimtControles.SaimtCheckBox
    Friend WithEvents chkRubros As SaimtControles.SaimtCheckBox
    Friend WithEvents chkZonificacionUso As SaimtControles.SaimtCheckBox
    Friend WithEvents chkEstadoConservacion As SaimtControles.SaimtCheckBox
    Friend WithEvents chkSituacionFisica As SaimtControles.SaimtCheckBox
    Friend WithEvents chkDisponibilidad As SaimtControles.SaimtCheckBox
    Friend WithEvents cboDisponibilidad As SaimtControles.SaimtComboBox
    Friend WithEvents gcInmSaneadoObsMostrable As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gband1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
