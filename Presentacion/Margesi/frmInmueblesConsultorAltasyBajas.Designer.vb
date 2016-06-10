<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInmueblesConsultorAltasyBajas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInmueblesConsultorAltasyBajas))
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        Me.gbFile = New SaimtControles.SaimtGroupBox()
        Me.chkfecha = New SaimtControles.SaimtCheckBox()
        Me.dpTiempoFin = New SaimtControles.SaimtDateTimePicker()
        Me.dpTiempoInicio = New SaimtControles.SaimtDateTimePicker()
        Me.chkFile = New SaimtControles.SaimtCheckBox()
        Me.cboCriterioFile = New System.Windows.Forms.ComboBox()
        Me.txtFile = New SaimtControles.SaimtTextBox()
        Me.cboDetalleTiempo = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCriterioTiempo = New SaimtControles.SaimtComboBox()
        Me.SaimtButton2 = New SaimtControles.SaimtButton()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.chkRubros = New SaimtControles.SaimtCheckBox()
        Me.cboAnio = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboRubro = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboRubroGrupos = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtButton1 = New SaimtControles.SaimtButton()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.btnSeleccionar = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.SaimtLabel67 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.dgvResultado = New SaimtControles.SaimtDataGrid()
        Me.gvResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFile.SuspendLayout()
        CType(Me.chkfecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpTiempoFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpTiempoFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpTiempoInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpTiempoInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDetalleTiempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterioTiempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRubros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRubro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRubroGrupos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 713)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1090, 27)
        '
        'gbFile
        '
        Me.gbFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFile.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.gbFile.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.gbFile.Appearance.Options.UseBackColor = True
        Me.gbFile.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.gbFile.AppearanceCaption.Options.UseForeColor = True
        Me.gbFile.Controls.Add(Me.chkfecha)
        Me.gbFile.Controls.Add(Me.dpTiempoFin)
        Me.gbFile.Controls.Add(Me.dpTiempoInicio)
        Me.gbFile.Controls.Add(Me.chkFile)
        Me.gbFile.Controls.Add(Me.cboCriterioFile)
        Me.gbFile.Controls.Add(Me.txtFile)
        Me.gbFile.Controls.Add(Me.cboDetalleTiempo)
        Me.gbFile.Controls.Add(Me.cboCriterioTiempo)
        Me.gbFile.Controls.Add(Me.SaimtButton2)
        Me.gbFile.Controls.Add(Me.SaimtLabel3)
        Me.gbFile.Controls.Add(Me.chkRubros)
        Me.gbFile.Controls.Add(Me.cboAnio)
        Me.gbFile.Controls.Add(Me.cboRubro)
        Me.gbFile.Controls.Add(Me.cboRubroGrupos)
        Me.gbFile.Controls.Add(Me.SaimtLabel1)
        Me.gbFile.Controls.Add(Me.SaimtButton1)
        Me.gbFile.Location = New System.Drawing.Point(12, 8)
        Me.gbFile.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gbFile.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gbFile.Name = "gbFile"
        Me.gbFile.Size = New System.Drawing.Size(1055, 135)
        Me.gbFile.TabIndex = 14
        Me.gbFile.Text = "Busca por año y rubro seleccionado"
        '
        'chkfecha
        '
        Me.chkfecha.EditValue = True
        Me.chkfecha.Location = New System.Drawing.Point(12, 29)
        Me.chkfecha.MenuManager = Me.RibbonControl
        Me.chkfecha.Name = "chkfecha"
        Me.chkfecha.Properties.AutoWidth = True
        Me.chkfecha.Properties.Caption = "Fechas :"
        Me.chkfecha.Size = New System.Drawing.Size(63, 19)
        Me.chkfecha.TabIndex = 91
        Me.chkfecha.Tag = "NotClear"
        '
        'dpTiempoFin
        '
        Me.dpTiempoFin.EditValue = Nothing
        Me.dpTiempoFin.Location = New System.Drawing.Point(261, 31)
        Me.dpTiempoFin.MenuManager = Me.RibbonControl
        Me.dpTiempoFin.Name = "dpTiempoFin"
        Me.dpTiempoFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpTiempoFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dpTiempoFin.Size = New System.Drawing.Size(163, 20)
        Me.dpTiempoFin.TabIndex = 90
        '
        'dpTiempoInicio
        '
        Me.dpTiempoInicio.EditValue = Nothing
        Me.dpTiempoInicio.Location = New System.Drawing.Point(83, 29)
        Me.dpTiempoInicio.MenuManager = Me.RibbonControl
        Me.dpTiempoInicio.Name = "dpTiempoInicio"
        Me.dpTiempoInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpTiempoInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dpTiempoInicio.Size = New System.Drawing.Size(172, 20)
        Me.dpTiempoInicio.TabIndex = 89
        '
        'chkFile
        '
        Me.chkFile.EditValue = True
        Me.chkFile.Location = New System.Drawing.Point(12, 89)
        Me.chkFile.MenuManager = Me.RibbonControl
        Me.chkFile.Name = "chkFile"
        Me.chkFile.Properties.AutoWidth = True
        Me.chkFile.Properties.Caption = "File :"
        Me.chkFile.Size = New System.Drawing.Size(45, 19)
        Me.chkFile.TabIndex = 88
        Me.chkFile.Tag = "NotClear"
        '
        'cboCriterioFile
        '
        Me.cboCriterioFile.FormattingEnabled = True
        Me.cboCriterioFile.Items.AddRange(New Object() {"File", "File Ant."})
        Me.cboCriterioFile.Location = New System.Drawing.Point(82, 87)
        Me.cboCriterioFile.Name = "cboCriterioFile"
        Me.cboCriterioFile.Size = New System.Drawing.Size(173, 21)
        Me.cboCriterioFile.TabIndex = 87
        '
        'txtFile
        '
        Me.txtFile.EditValue = ""
        Me.txtFile.Location = New System.Drawing.Point(261, 87)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(163, 20)
        Me.txtFile.TabIndex = 86
        '
        'cboDetalleTiempo
        '
        Me.cboDetalleTiempo.Location = New System.Drawing.Point(588, 98)
        Me.cboDetalleTiempo.MenuManager = Me.RibbonControl
        Me.cboDetalleTiempo.Name = "cboDetalleTiempo"
        Me.cboDetalleTiempo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDetalleTiempo.Properties.NullText = ""
        Me.cboDetalleTiempo.Size = New System.Drawing.Size(157, 20)
        Me.cboDetalleTiempo.TabIndex = 85
        Me.cboDetalleTiempo.Visible = False
        '
        'cboCriterioTiempo
        '
        Me.cboCriterioTiempo.Location = New System.Drawing.Point(588, 72)
        Me.cboCriterioTiempo.MenuManager = Me.RibbonControl
        Me.cboCriterioTiempo.Name = "cboCriterioTiempo"
        Me.cboCriterioTiempo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioTiempo.Properties.Items.AddRange(New Object() {"Mes", "Trimestres", "Semestres"})
        Me.cboCriterioTiempo.Size = New System.Drawing.Size(163, 20)
        Me.cboCriterioTiempo.TabIndex = 84
        Me.cboCriterioTiempo.Visible = False
        '
        'SaimtButton2
        '
        Me.SaimtButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SaimtButton2.Appearance.Options.UseFont = True
        Me.SaimtButton2.Image = Global.Presentacion.My.Resources.Resources.buscar32
        Me.SaimtButton2.Location = New System.Drawing.Point(911, 25)
        Me.SaimtButton2.LookAndFeel.SkinName = "Seven"
        Me.SaimtButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SaimtButton2.Name = "SaimtButton2"
        Me.SaimtButton2.Size = New System.Drawing.Size(120, 59)
        Me.SaimtButton2.TabIndex = 83
        Me.SaimtButton2.Text = "Buscar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Altas"
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(556, 50)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(26, 13)
        Me.SaimtLabel3.TabIndex = 82
        Me.SaimtLabel3.Text = "Año :"
        Me.SaimtLabel3.Visible = False
        '
        'chkRubros
        '
        Me.chkRubros.EditValue = True
        Me.chkRubros.Location = New System.Drawing.Point(12, 59)
        Me.chkRubros.MenuManager = Me.RibbonControl
        Me.chkRubros.Name = "chkRubros"
        Me.chkRubros.Properties.AutoWidth = True
        Me.chkRubros.Properties.Caption = "Rubros :"
        Me.chkRubros.Size = New System.Drawing.Size(63, 19)
        Me.chkRubros.TabIndex = 79
        Me.chkRubros.Tag = "NotClear"
        '
        'cboAnio
        '
        Me.cboAnio.Location = New System.Drawing.Point(588, 46)
        Me.cboAnio.MenuManager = Me.RibbonControl
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAnio.Properties.NullText = ""
        Me.cboAnio.Size = New System.Drawing.Size(172, 20)
        Me.cboAnio.TabIndex = 74
        Me.cboAnio.Visible = False
        '
        'cboRubro
        '
        Me.cboRubro.Location = New System.Drawing.Point(261, 58)
        Me.cboRubro.MenuManager = Me.RibbonControl
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRubro.Properties.LookAndFeel.SkinName = "Seven"
        Me.cboRubro.Properties.NullText = ""
        Me.cboRubro.Size = New System.Drawing.Size(163, 20)
        Me.cboRubro.TabIndex = 39
        '
        'cboRubroGrupos
        '
        Me.cboRubroGrupos.Location = New System.Drawing.Point(82, 58)
        Me.cboRubroGrupos.MenuManager = Me.RibbonControl
        Me.cboRubroGrupos.Name = "cboRubroGrupos"
        Me.cboRubroGrupos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRubroGrupos.Properties.LookAndFeel.SkinName = "Seven"
        Me.cboRubroGrupos.Properties.NullText = ""
        Me.cboRubroGrupos.Size = New System.Drawing.Size(173, 20)
        Me.cboRubroGrupos.TabIndex = 38
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(766, 61)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(0, 13)
        Me.SaimtLabel1.TabIndex = 37
        Me.SaimtLabel1.Visible = False
        '
        'SaimtButton1
        '
        Me.SaimtButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SaimtButton1.Appearance.Options.UseFont = True
        Me.SaimtButton1.Image = Global.Presentacion.My.Resources.Resources.buscar32
        Me.SaimtButton1.Location = New System.Drawing.Point(782, 25)
        Me.SaimtButton1.LookAndFeel.SkinName = "Seven"
        Me.SaimtButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SaimtButton1.Name = "SaimtButton1"
        Me.SaimtButton1.Size = New System.Drawing.Size(120, 59)
        Me.SaimtButton1.TabIndex = 36
        Me.SaimtButton1.Text = "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Bajas"
        '
        'btnexportar
        '
        Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.Location = New System.Drawing.Point(947, 669)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(120, 31)
        Me.btnexportar.TabIndex = 17
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.Location = New System.Drawing.Point(459, 669)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 16
        Me.btnSeleccionar.Text = "Seleccionar"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel67)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox2.Controls.Add(Me.dgvResultado)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(18, 149)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.ShowCaption = False
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(1055, 514)
        Me.SaimtGroupBox2.TabIndex = 18
        '
        'SaimtLabel67
        '
        Me.SaimtLabel67.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SaimtLabel67.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.SaimtLabel67.Location = New System.Drawing.Point(2, 2)
        Me.SaimtLabel67.Name = "SaimtLabel67"
        Me.SaimtLabel67.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.SaimtLabel67.Size = New System.Drawing.Size(1051, 18)
        Me.SaimtLabel67.TabIndex = 2
        Me.SaimtLabel67.Text = "De la lista ya buscada, en la caja de texto abajo; podras realizar cualquier sub " & _
            "consulta de cualquiera de los campos mostrados en la tabla."
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
        Me.dgvResultado.Location = New System.Drawing.Point(2, 2)
        Me.dgvResultado.MainView = Me.gvResultado
        Me.dgvResultado.MenuManager = Me.RibbonControl
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.Size = New System.Drawing.Size(1051, 510)
        Me.dgvResultado.TabIndex = 4
        Me.dgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResultado})
        '
        'gvResultado
        '
        Me.gvResultado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn11, Me.GridColumn10, Me.GridColumn12})
        Me.gvResultado.GridControl = Me.dgvResultado
        Me.gvResultado.Name = "gvResultado"
        Me.gvResultado.OptionsBehavior.ReadOnly = True
        Me.gvResultado.OptionsFind.AlwaysVisible = True
        Me.gvResultado.OptionsView.ColumnAutoWidth = False
        Me.gvResultado.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cantidad"
        Me.GridColumn1.FieldName = "InmCant"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Código Margesí MPT"
        Me.GridColumn2.FieldName = "inmFileRubro"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Inmueble"
        Me.GridColumn3.FieldName = "inmUbicacion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Área"
        Me.GridColumn4.FieldName = "inmArea"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tipo de Actualización"
        Me.GridColumn5.FieldName = "InmTipoActualizacion"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Causal"
        Me.GridColumn6.FieldName = "InmCausal"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha"
        Me.GridColumn7.FieldName = "inmFecha"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Valor del Inmueble"
        Me.GridColumn8.FieldName = "InmValComValTotal"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Documento"
        Me.GridColumn9.FieldName = "InmDocumento"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Dato Adicional"
        Me.GridColumn11.FieldName = "InmDatoAdicional"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Observación"
        Me.GridColumn10.FieldName = "InmObservacion"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "InmId"
        Me.GridColumn12.FieldName = "InmId"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'frmInmueblesConsultorAltasyBajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonBuscar = Me.SaimtButton1
        Me.ButtonSeleccionar = Me.btnSeleccionar
        Me.ClientSize = New System.Drawing.Size(1090, 740)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.Controls.Add(Me.btnexportar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.gbFile)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmInmueblesConsultorAltasyBajas"
        Me.Tag = "btiConsultordeAltasyBajas"
        Me.Text = "CONSULTOR DE ALTAS Y BAJAS"
        Me.Controls.SetChildIndex(Me.gbFile, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.btnSeleccionar, 0)
        Me.Controls.SetChildIndex(Me.btnexportar, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFile.ResumeLayout(False)
        Me.gbFile.PerformLayout()
        CType(Me.chkfecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpTiempoFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpTiempoFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpTiempoInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpTiempoInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDetalleTiempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterioTiempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRubros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRubro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRubroGrupos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sfdexportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gbFile As SaimtControles.SaimtGroupBox
    Friend WithEvents cboRubro As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboRubroGrupos As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtButton1 As SaimtControles.SaimtButton
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents btnSeleccionar As SaimtControles.SaimtButton
    Friend WithEvents cboAnio As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents chkRubros As SaimtControles.SaimtCheckBox
    Friend WithEvents SaimtButton2 As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel67 As SaimtControles.SaimtLabel
    Friend WithEvents cboCriterioTiempo As SaimtControles.SaimtComboBox
    Friend WithEvents cboDetalleTiempo As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboCriterioFile As System.Windows.Forms.ComboBox
    Friend WithEvents txtFile As SaimtControles.SaimtTextBox
    Friend WithEvents chkFile As SaimtControles.SaimtCheckBox
    Friend WithEvents chkfecha As SaimtControles.SaimtCheckBox
    Friend WithEvents dpTiempoFin As SaimtControles.SaimtDateTimePicker
    Friend WithEvents dpTiempoInicio As SaimtControles.SaimtDateTimePicker
    Friend WithEvents dgvResultado As SaimtControles.SaimtDataGrid
    Friend WithEvents gvResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
End Class
