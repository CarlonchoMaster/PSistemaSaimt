﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarDetalleAbono
    Inherits frmGeneral

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarDetalleAbono))
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.dgvContratos = New SaimtControles.SaimtDataGrid()
        Me.gvContratos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtFiltroContrato = New SaimtControles.SaimtTextBox()
        Me.cboCriterioContrato = New SaimtControles.SaimtComboBox()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.dgvPersona = New SaimtControles.SaimtDataGrid()
        Me.gvPersona = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtFiltroPersona = New SaimtControles.SaimtTextBox()
        Me.cboCriterio2Persona = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCriterioPersona = New SaimtControles.SaimtComboBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtButton1 = New SaimtControles.SaimtButton()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.spnNroCuotas = New SaimtControles.SaimtSpinner()
        Me.btnQuitarCuota = New SaimtControles.SaimtButton()
        Me.btnAgregarCuota = New SaimtControles.SaimtButton()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.txtMontoXPagar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtMontoPagado = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.txtMontoAPagar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.dgvProgramacionAbonos = New SaimtControles.SaimtDataGrid()
        Me.gvProgramacionAbonos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.dgvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltroContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterioContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltroPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterio2Persona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterioPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnNroCuotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoXPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPagado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoAPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.dgvProgramacionAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 703)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1285, 27)
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtGroupBox2)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtFiltroContrato)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboCriterioContrato)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtFiltroPersona)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboCriterio2Persona)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboCriterioPersona)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtButton1)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnImprimir)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.spnNroCuotas)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnQuitarCuota)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnAgregarCuota)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtLabel14)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.txtMontoXPagar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtLabel5)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.txtMontoPagado)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtLabel4)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.txtMontoAPagar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtLabel3)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtLabel2)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox3)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(1285, 703)
        Me.SaimtSplitContainerControl1.SplitterPosition = 564
        Me.SaimtSplitContainerControl1.TabIndex = 0
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox2.Controls.Add(Me.dgvContratos)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(8, 421)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(553, 278)
        Me.SaimtGroupBox2.TabIndex = 7
        Me.SaimtGroupBox2.Text = "Contratos"
        '
        'dgvContratos
        '
        Me.dgvContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvContratos.Location = New System.Drawing.Point(2, 21)
        Me.dgvContratos.MainView = Me.gvContratos
        Me.dgvContratos.MenuManager = Me.RibbonControl
        Me.dgvContratos.Name = "dgvContratos"
        Me.dgvContratos.Size = New System.Drawing.Size(549, 255)
        Me.dgvContratos.TabIndex = 0
        Me.dgvContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvContratos})
        '
        'gvContratos
        '
        Me.gvContratos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20})
        Me.gvContratos.GridControl = Me.dgvContratos
        Me.gvContratos.Name = "gvContratos"
        Me.gvContratos.OptionsBehavior.ReadOnly = True
        Me.gvContratos.OptionsView.ColumnAutoWidth = False
        Me.gvContratos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Cod. Contrato"
        Me.GridColumn8.FieldName = "AbonId"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Fecha Inicio"
        Me.GridColumn9.FieldName = "AbonFechaIni"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Fecha Término"
        Me.GridColumn10.FieldName = "AbonFechaFin"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Tipo Vehiculo"
        Me.GridColumn11.FieldName = "TipoVehiculo"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 6
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Estado Contrato"
        Me.GridColumn12.FieldName = "Estado"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 7
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Concepto de Servicio"
        Me.GridColumn13.FieldName = "Concepto"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 8
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Placa 1"
        Me.GridColumn14.FieldName = "AbonNPlaca1"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 3
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Placa 2"
        Me.GridColumn15.FieldName = "AbonNPlaca2"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 4
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Placa 3"
        Me.GridColumn16.FieldName = "AbonNPlaca3"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 5
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Nivel"
        Me.GridColumn17.FieldName = "Nivel"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 9
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "N° Espacio"
        Me.GridColumn18.FieldName = "AbonNroEspacio"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 10
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "N° Meses"
        Me.GridColumn19.FieldName = "AbonNroMeses"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 11
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Monto a Pagar (S/.)"
        Me.GridColumn20.DisplayFormat.FormatString = "n2"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "AbonImporte"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 12
        '
        'txtFiltroContrato
        '
        Me.txtFiltroContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltroContrato.Location = New System.Drawing.Point(191, 396)
        Me.txtFiltroContrato.MenuManager = Me.RibbonControl
        Me.txtFiltroContrato.Name = "txtFiltroContrato"
        Me.txtFiltroContrato.Size = New System.Drawing.Size(370, 20)
        Me.txtFiltroContrato.TabIndex = 6
        '
        'cboCriterioContrato
        '
        Me.cboCriterioContrato.EditValue = "Cod. Persona"
        Me.cboCriterioContrato.Location = New System.Drawing.Point(8, 396)
        Me.cboCriterioContrato.MenuManager = Me.RibbonControl
        Me.cboCriterioContrato.Name = "cboCriterioContrato"
        Me.cboCriterioContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioContrato.Properties.Items.AddRange(New Object() {"Cod. Persona", "N° Contrato", "Placa 1", "Placa 2", "Placa 3"})
        Me.cboCriterioContrato.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCriterioContrato.Size = New System.Drawing.Size(177, 20)
        Me.cboCriterioContrato.TabIndex = 5
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox1.Controls.Add(Me.dgvPersona)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(8, 70)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(553, 320)
        Me.SaimtGroupBox1.TabIndex = 4
        Me.SaimtGroupBox1.Text = "Resultado de Busqueda de Abonados"
        '
        'dgvPersona
        '
        Me.dgvPersona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPersona.Location = New System.Drawing.Point(2, 21)
        Me.dgvPersona.MainView = Me.gvPersona
        Me.dgvPersona.MenuManager = Me.RibbonControl
        Me.dgvPersona.Name = "dgvPersona"
        Me.dgvPersona.Size = New System.Drawing.Size(549, 297)
        Me.dgvPersona.TabIndex = 0
        Me.dgvPersona.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPersona})
        '
        'gvPersona
        '
        Me.gvPersona.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.gvPersona.GridControl = Me.dgvPersona
        Me.gvPersona.Name = "gvPersona"
        Me.gvPersona.OptionsBehavior.ReadOnly = True
        Me.gvPersona.OptionsFind.AlwaysVisible = True
        Me.gvPersona.OptionsView.ColumnAutoWidth = False
        Me.gvPersona.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Persona"
        Me.GridColumn1.FieldName = "Persona"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tipo Doc."
        Me.GridColumn2.FieldName = "TgTipoDocumento"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "N° Doc"
        Me.GridColumn3.FieldName = "PerNdoc"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cod. Persona"
        Me.GridColumn4.FieldName = "PerId"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Contacto"
        Me.GridColumn5.FieldName = "Contacto"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tipo Persona"
        Me.GridColumn6.FieldName = "TgTipoPersona"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Dirección"
        Me.GridColumn7.FieldName = "PerDireccion"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'txtFiltroPersona
        '
        Me.txtFiltroPersona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltroPersona.Location = New System.Drawing.Point(9, 44)
        Me.txtFiltroPersona.MenuManager = Me.RibbonControl
        Me.txtFiltroPersona.Name = "txtFiltroPersona"
        Me.txtFiltroPersona.Size = New System.Drawing.Size(552, 20)
        Me.txtFiltroPersona.TabIndex = 3
        '
        'cboCriterio2Persona
        '
        Me.cboCriterio2Persona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCriterio2Persona.Location = New System.Drawing.Point(300, 19)
        Me.cboCriterio2Persona.MenuManager = Me.RibbonControl
        Me.cboCriterio2Persona.Name = "cboCriterio2Persona"
        Me.cboCriterio2Persona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterio2Persona.Properties.NullText = ""
        Me.cboCriterio2Persona.Size = New System.Drawing.Size(261, 20)
        Me.cboCriterio2Persona.TabIndex = 2
        '
        'cboCriterioPersona
        '
        Me.cboCriterioPersona.EditValue = "Apellidos y Nombres"
        Me.cboCriterioPersona.Location = New System.Drawing.Point(8, 19)
        Me.cboCriterioPersona.MenuManager = Me.RibbonControl
        Me.cboCriterioPersona.Name = "cboCriterioPersona"
        Me.cboCriterioPersona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioPersona.Properties.Items.AddRange(New Object() {"Apellidos y Nombres", "Tipo de Documento", "N° Documento", "Placa 1", "Placa 2", "Placa 3"})
        Me.cboCriterioPersona.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCriterioPersona.Size = New System.Drawing.Size(286, 20)
        Me.cboCriterioPersona.TabIndex = 1
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(9, 4)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(55, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Buscar por:"
        '
        'SaimtButton1
        '
        Me.SaimtButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtButton1.Appearance.Options.UseTextOptions = True
        Me.SaimtButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SaimtButton1.Image = CType(resources.GetObject("SaimtButton1.Image"), System.Drawing.Image)
        Me.SaimtButton1.Location = New System.Drawing.Point(586, 513)
        Me.SaimtButton1.Name = "SaimtButton1"
        Me.SaimtButton1.Size = New System.Drawing.Size(124, 44)
        Me.SaimtButton1.TabIndex = 14
        Me.SaimtButton1.Text = "Activar Programaciones"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(485, 513)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(95, 44)
        Me.btnImprimir.TabIndex = 13
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(380, 513)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(99, 44)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        '
        'spnNroCuotas
        '
        Me.spnNroCuotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spnNroCuotas.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnNroCuotas.Location = New System.Drawing.Point(622, 8)
        Me.spnNroCuotas.MenuManager = Me.RibbonControl
        Me.spnNroCuotas.Name = "spnNroCuotas"
        Me.spnNroCuotas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spnNroCuotas.Properties.MaxValue = New Decimal(New Integer() {12, 0, 0, 0})
        Me.spnNroCuotas.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnNroCuotas.Size = New System.Drawing.Size(42, 20)
        Me.spnNroCuotas.TabIndex = 1
        '
        'btnQuitarCuota
        '
        Me.btnQuitarCuota.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarCuota.Image = CType(resources.GetObject("btnQuitarCuota.Image"), System.Drawing.Image)
        Me.btnQuitarCuota.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuitarCuota.Location = New System.Drawing.Point(691, 8)
        Me.btnQuitarCuota.Name = "btnQuitarCuota"
        Me.btnQuitarCuota.Size = New System.Drawing.Size(21, 21)
        Me.btnQuitarCuota.TabIndex = 3
        '
        'btnAgregarCuota
        '
        Me.btnAgregarCuota.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCuota.Image = CType(resources.GetObject("btnAgregarCuota.Image"), System.Drawing.Image)
        Me.btnAgregarCuota.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregarCuota.Location = New System.Drawing.Point(668, 8)
        Me.btnAgregarCuota.Name = "btnAgregarCuota"
        Me.btnAgregarCuota.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarCuota.TabIndex = 2
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel14.Location = New System.Drawing.Point(502, 11)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(116, 13)
        Me.SaimtLabel14.TabIndex = 0
        Me.SaimtLabel14.Text = "N° de Abonos a agregar"
        '
        'txtMontoXPagar
        '
        Me.txtMontoXPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoXPagar.EditValue = "0"
        Me.txtMontoXPagar.Location = New System.Drawing.Point(609, 482)
        Me.txtMontoXPagar.MenuManager = Me.RibbonControl
        Me.txtMontoXPagar.Name = "txtMontoXPagar"
        Me.txtMontoXPagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoXPagar.Properties.Appearance.Options.UseFont = True
        Me.txtMontoXPagar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMontoXPagar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMontoXPagar.Properties.Mask.EditMask = "n2"
        Me.txtMontoXPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoXPagar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoXPagar.Properties.ReadOnly = True
        Me.txtMontoXPagar.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoXPagar.TabIndex = 11
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel5.Location = New System.Drawing.Point(522, 485)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(82, 13)
        Me.SaimtLabel5.TabIndex = 10
        Me.SaimtLabel5.Text = "Monto X Pagar"
        '
        'txtMontoPagado
        '
        Me.txtMontoPagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoPagado.EditValue = "0"
        Me.txtMontoPagado.Location = New System.Drawing.Point(356, 482)
        Me.txtMontoPagado.MenuManager = Me.RibbonControl
        Me.txtMontoPagado.Name = "txtMontoPagado"
        Me.txtMontoPagado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPagado.Properties.Appearance.Options.UseFont = True
        Me.txtMontoPagado.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMontoPagado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMontoPagado.Properties.Mask.EditMask = "n2"
        Me.txtMontoPagado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoPagado.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoPagado.Properties.ReadOnly = True
        Me.txtMontoPagado.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoPagado.TabIndex = 9
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel4.Location = New System.Drawing.Point(270, 485)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(81, 13)
        Me.SaimtLabel4.TabIndex = 8
        Me.SaimtLabel4.Text = "Monto Pagado"
        '
        'txtMontoAPagar
        '
        Me.txtMontoAPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoAPagar.EditValue = "0"
        Me.txtMontoAPagar.Location = New System.Drawing.Point(94, 482)
        Me.txtMontoAPagar.MenuManager = Me.RibbonControl
        Me.txtMontoAPagar.Name = "txtMontoAPagar"
        Me.txtMontoAPagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoAPagar.Properties.Appearance.Options.UseFont = True
        Me.txtMontoAPagar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMontoAPagar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMontoAPagar.Properties.Mask.EditMask = "n2"
        Me.txtMontoAPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoAPagar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoAPagar.Properties.ReadOnly = True
        Me.txtMontoAPagar.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoAPagar.TabIndex = 7
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel3.Location = New System.Drawing.Point(8, 485)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(82, 13)
        Me.SaimtLabel3.TabIndex = 6
        Me.SaimtLabel3.Text = "Monto a Pagar"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(8, 424)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(0, 13)
        Me.SaimtLabel2.TabIndex = 5
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox3.Controls.Add(Me.dgvProgramacionAbonos)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(2, 33)
        Me.SaimtGroupBox3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(711, 443)
        Me.SaimtGroupBox3.TabIndex = 4
        Me.SaimtGroupBox3.Text = "Programación de Abonos"
        '
        'dgvProgramacionAbonos
        '
        Me.dgvProgramacionAbonos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProgramacionAbonos.Location = New System.Drawing.Point(2, 21)
        Me.dgvProgramacionAbonos.MainView = Me.gvProgramacionAbonos
        Me.dgvProgramacionAbonos.MenuManager = Me.RibbonControl
        Me.dgvProgramacionAbonos.Name = "dgvProgramacionAbonos"
        Me.dgvProgramacionAbonos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.dgvProgramacionAbonos.Size = New System.Drawing.Size(707, 420)
        Me.dgvProgramacionAbonos.TabIndex = 0
        Me.dgvProgramacionAbonos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionAbonos})
        '
        'gvProgramacionAbonos
        '
        Me.gvProgramacionAbonos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn32, Me.GridColumn31})
        Me.gvProgramacionAbonos.GridControl = Me.dgvProgramacionAbonos
        Me.gvProgramacionAbonos.Name = "gvProgramacionAbonos"
        Me.gvProgramacionAbonos.OptionsPrint.AutoWidth = False
        Me.gvProgramacionAbonos.OptionsView.ColumnAutoWidth = False
        Me.gvProgramacionAbonos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "N° Contrato"
        Me.GridColumn21.FieldName = "AbonId"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "N° Abono"
        Me.GridColumn22.FieldName = "AbonDetNroCuota"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.ReadOnly = True
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 1
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Fecha Inicio"
        Me.GridColumn23.FieldName = "AbonDetFechaIni"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 2
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Fecha Término"
        Me.GridColumn24.FieldName = "AbonDetFechaFin"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 3
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Fecha Pago"
        Me.GridColumn25.FieldName = "AbonDetFecPago"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.ReadOnly = True
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 4
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Importe (S/.)"
        Me.GridColumn26.DisplayFormat.FormatString = "n2"
        Me.GridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn26.FieldName = "AbonDetImporte"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.ReadOnly = True
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 6
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Estado Abono"
        Me.GridColumn27.FieldName = "Estado"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.ReadOnly = True
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 7
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "Fue Pagada?"
        Me.GridColumn28.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn28.FieldName = "AbonDetPagado"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 5
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "Cod. Abono"
        Me.GridColumn29.FieldName = "AbonDetId"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.OptionsColumn.AllowEdit = False
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 0
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "tgEstadoId"
        Me.GridColumn30.FieldName = "TgEstadoId"
        Me.GridColumn30.Name = "GridColumn30"
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Fecha Generó"
        Me.GridColumn32.FieldName = "AbonDetFechaGenera"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 8
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Temporal"
        Me.GridColumn31.FieldName = "Temporal"
        Me.GridColumn31.Name = "GridColumn31"
        '
        'frmConsultarDetalleAbono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 730)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmConsultarDetalleAbono"
        Me.Tag = "btiConsultaDetalleAbono"
        Me.Text = "CONSULTAR ABONADO"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        CType(Me.dgvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltroContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterioContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltroPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterio2Persona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterioPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnNroCuotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoXPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPagado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoAPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        CType(Me.dgvProgramacionAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents cboCriterioPersona As SaimtControles.SaimtComboBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtFiltroPersona As SaimtControles.SaimtTextBox
    Friend WithEvents cboCriterio2Persona As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvContratos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvContratos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtFiltroContrato As SaimtControles.SaimtTextBox
    Friend WithEvents cboCriterioContrato As SaimtControles.SaimtComboBox
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvPersona As SaimtControles.SaimtDataGrid
    Friend WithEvents gvPersona As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvProgramacionAbonos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionAbonos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMontoXPagar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtMontoPagado As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents txtMontoAPagar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents spnNroCuotas As SaimtControles.SaimtSpinner
    Friend WithEvents btnQuitarCuota As SaimtControles.SaimtButton
    Friend WithEvents btnAgregarCuota As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents SaimtButton1 As SaimtControles.SaimtButton
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
End Class