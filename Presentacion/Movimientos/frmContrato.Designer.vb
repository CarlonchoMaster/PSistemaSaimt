﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContrato
    Inherits Presentacion.frmMantenimientos

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContrato))
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscarPersonaPor = New SaimtControles.SaimtTextBox()
        Me.grbContratos = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoContratos = New SaimtControles.SaimtDataGrid()
        Me.gvListadoContratos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BackstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator2 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem2 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator3 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem3 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator4 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.cboTipoGarantia = New SaimtControles.SaimtComboBoxLookUp()
        Me.txtRegMesPart = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.dtFechaSol = New SaimtControles.SaimtDateTimePicker()
        Me.dtFechaSus = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.cboTipoComprobante = New SaimtControles.SaimtComboBoxLookUp()
        Me.txtNroContrato = New SaimtControles.SaimtTextBox()
        Me.txtDocRef = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.txtDiaMaxVen = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.cbModalidad = New SaimtControles.SaimtComboBoxLookUp()
        Me.txtObsCon = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.dtFechaFin = New SaimtControles.SaimtDateTimePicker()
        Me.dtFechaInicio = New SaimtControles.SaimtDateTimePicker()
        Me.cboUso = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboTipoMoneda = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboEstadoContrato = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnConsultarConyuge = New SaimtControles.SaimtButton()
        Me.txtGarantia = New SaimtControles.SaimtTextBox()
        Me.txtDerLlave = New SaimtControles.SaimtTextBox()
        Me.txtMerced = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel28 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel27 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel26 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel25 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel24 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel23 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel21 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel20 = New SaimtControles.SaimtLabel()
        Me.txtDirInmueble = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.txtCodInmueble = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.grbLista = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoPersona = New SaimtControles.SaimtDataGrid()
        Me.gvListadoPersona = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.txtTipoDocumento = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel30 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.txtPerId = New SaimtControles.SaimtTextBox()
        Me.txtObsPer = New SaimtControles.SaimtTextBoxMultiline()
        Me.cboTipoPersona = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtDireccion = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel17 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel19 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel22 = New SaimtControles.SaimtLabel()
        Me.btnBuscarPersona = New SaimtControles.SaimtButton()
        Me.SaimtLabel29 = New SaimtControles.SaimtLabel()
        Me.txtNombreRazon = New SaimtControles.SaimtTextBox()
        Me.txtNroDocumento = New SaimtControles.SaimtTextBox()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnCancelarContrato = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.fbdcontrato = New System.Windows.Forms.FolderBrowserDialog()
        Me.bieprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.ripprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.bieprogresomarque = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        Me.tabDetContrato = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnincrementar = New SaimtControles.SaimtButton()
        Me.SaimtLabel18 = New SaimtControles.SaimtLabel()
        Me.txtPorcentajeInc = New SaimtControles.SaimtSpinner()
        Me.btnObtenerMCAnt = New SaimtControles.SaimtButton()
        Me.btnArchivosAnexados = New SaimtControles.SaimtButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.cboTipoArchivos = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel42 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel16 = New SaimtControles.SaimtLabel()
        Me.txtNroContrato1 = New SaimtControles.SaimtTextBox()
        Me.btnVerArchivos = New SaimtControles.SaimtButton()
        Me.dgvArchivos = New SaimtControles.SaimtDataGrid()
        Me.gvArchivos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnRemover = New SaimtControles.SaimtButton()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.SaimtLabel40 = New SaimtControles.SaimtLabel()
        Me.txtDescripcionArchivo = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel41 = New SaimtControles.SaimtLabel()
        Me.txtNombreArchivo = New SaimtControles.SaimtTextBox()
        Me.btnExaminarArchivo = New SaimtControles.SaimtButton()
        Me.txtBuscarArchivo = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel35 = New SaimtControles.SaimtLabel()
        Me.ofdExaminarArchivos = New System.Windows.Forms.OpenFileDialog()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.cboTipoUso = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboBuscarContratoPor = New SaimtControles.SaimtComboBox()
        Me.txtBuscarContratoPor = New SaimtControles.SaimtTextBox()
        Me.cboBuscarPersonaPor = New SaimtControles.SaimtComboBox()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContratos.SuspendLayout()
        CType(Me.dgvListadoContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoGarantia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegMesPart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaSol.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaSol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaSus.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaSus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaMaxVen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbModalidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObsCon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGarantia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDerLlave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMerced.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDirInmueble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodInmueble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLista.SuspendLayout()
        CType(Me.dgvListadoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObsPer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreRazon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ripprogreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabDetContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetContrato.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtPorcentajeInc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cboTipoArchivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroContrato1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.cboTipoUso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.bieprogreso)
        Me.rsbMensajeBarra.ItemLinks.Add(Me.bieprogresomarque)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 681)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(906, 27)
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(8, 2)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(55, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Buscar por:"
        '
        'txtBuscarPersonaPor
        '
        Me.txtBuscarPersonaPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPersonaPor.Location = New System.Drawing.Point(8, 40)
        Me.txtBuscarPersonaPor.MenuManager = Me.RibbonControl
        Me.txtBuscarPersonaPor.Name = "txtBuscarPersonaPor"
        Me.txtBuscarPersonaPor.Size = New System.Drawing.Size(352, 20)
        Me.txtBuscarPersonaPor.TabIndex = 2
        Me.txtBuscarPersonaPor.Tag = "0"
        '
        'grbContratos
        '
        Me.grbContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbContratos.Controls.Add(Me.dgvListadoContratos)
        Me.grbContratos.Location = New System.Drawing.Point(8, 396)
        Me.grbContratos.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbContratos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbContratos.Name = "grbContratos"
        Me.grbContratos.Size = New System.Drawing.Size(352, 282)
        Me.grbContratos.TabIndex = 7
        Me.grbContratos.Text = "Contratos"
        '
        'dgvListadoContratos
        '
        Me.dgvListadoContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoContratos.Location = New System.Drawing.Point(2, 21)
        Me.dgvListadoContratos.MainView = Me.gvListadoContratos
        Me.dgvListadoContratos.MenuManager = Me.RibbonControl
        Me.dgvListadoContratos.Name = "dgvListadoContratos"
        Me.dgvListadoContratos.Size = New System.Drawing.Size(348, 259)
        Me.dgvListadoContratos.TabIndex = 0
        Me.dgvListadoContratos.Tag = ""
        Me.dgvListadoContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoContratos})
        '
        'gvListadoContratos
        '
        Me.gvListadoContratos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.gvListadoContratos.GridControl = Me.dgvListadoContratos
        Me.gvListadoContratos.Name = "gvListadoContratos"
        Me.gvListadoContratos.OptionsBehavior.Editable = False
        Me.gvListadoContratos.OptionsView.ColumnAutoWidth = False
        Me.gvListadoContratos.OptionsView.ShowGroupPanel = False
        Me.gvListadoContratos.Tag = ""
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cod. Contrato"
        Me.GridColumn4.FieldName = "CodContrato"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha Inicio"
        Me.GridColumn5.FieldName = "FechaIni"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha Fin"
        Me.GridColumn6.FieldName = "FechaFin"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'BackstageViewItemSeparator1
        '
        Me.BackstageViewItemSeparator1.Name = "BackstageViewItemSeparator1"
        '
        'BackstageViewTabItem1
        '
        Me.BackstageViewTabItem1.Caption = "Datos de Cliente"
        Me.BackstageViewTabItem1.Glyph = CType(resources.GetObject("BackstageViewTabItem1.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem1.Name = "BackstageViewTabItem1"
        Me.BackstageViewTabItem1.Selected = False
        '
        'BackstageViewItemSeparator2
        '
        Me.BackstageViewItemSeparator2.Name = "BackstageViewItemSeparator2"
        '
        'BackstageViewTabItem2
        '
        Me.BackstageViewTabItem2.Caption = "Datos de Inmueble"
        Me.BackstageViewTabItem2.Glyph = CType(resources.GetObject("BackstageViewTabItem2.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem2.Name = "BackstageViewTabItem2"
        Me.BackstageViewTabItem2.Selected = False
        '
        'BackstageViewItemSeparator3
        '
        Me.BackstageViewItemSeparator3.Name = "BackstageViewItemSeparator3"
        '
        'BackstageViewTabItem3
        '
        Me.BackstageViewTabItem3.Caption = "Datos de Contrato"
        Me.BackstageViewTabItem3.Glyph = CType(resources.GetObject("BackstageViewTabItem3.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem3.Name = "BackstageViewTabItem3"
        Me.BackstageViewTabItem3.Selected = False
        '
        'BackstageViewItemSeparator4
        '
        Me.BackstageViewItemSeparator4.Name = "BackstageViewItemSeparator4"
        '
        'cboTipoGarantia
        '
        Me.cboTipoGarantia.Location = New System.Drawing.Point(359, 122)
        Me.cboTipoGarantia.MenuManager = Me.RibbonControl
        Me.cboTipoGarantia.Name = "cboTipoGarantia"
        Me.cboTipoGarantia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoGarantia.Properties.NullText = ""
        Me.cboTipoGarantia.Size = New System.Drawing.Size(88, 20)
        Me.cboTipoGarantia.TabIndex = 19
        '
        'txtRegMesPart
        '
        Me.txtRegMesPart.Location = New System.Drawing.Point(114, 218)
        Me.txtRegMesPart.Name = "txtRegMesPart"
        Me.txtRegMesPart.Size = New System.Drawing.Size(139, 20)
        Me.txtRegMesPart.TabIndex = 38
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(21, 221)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(87, 13)
        Me.SaimtLabel15.TabIndex = 37
        Me.SaimtLabel15.Text = "Reg. Mesa Parte :"
        '
        'dtFechaSol
        '
        Me.dtFechaSol.EditValue = Nothing
        Me.dtFechaSol.Location = New System.Drawing.Point(360, 194)
        Me.dtFechaSol.MenuManager = Me.RibbonControl
        Me.dtFechaSol.Name = "dtFechaSol"
        Me.dtFechaSol.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaSol.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFechaSol.Size = New System.Drawing.Size(144, 20)
        Me.dtFechaSol.TabIndex = 36
        '
        'dtFechaSus
        '
        Me.dtFechaSus.EditValue = Nothing
        Me.dtFechaSus.Location = New System.Drawing.Point(114, 194)
        Me.dtFechaSus.MenuManager = Me.RibbonControl
        Me.dtFechaSus.Name = "dtFechaSus"
        Me.dtFechaSus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaSus.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFechaSus.Size = New System.Drawing.Size(139, 20)
        Me.dtFechaSus.TabIndex = 34
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(271, 197)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(85, 13)
        Me.SaimtLabel12.TabIndex = 35
        Me.SaimtLabel12.Text = "Fecha - Solicitud :"
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(9, 197)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(99, 13)
        Me.SaimtLabel14.TabIndex = 33
        Me.SaimtLabel14.Text = "Fecha - Suscripción :"
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(260, 173)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(95, 13)
        Me.SaimtLabel11.TabIndex = 31
        Me.SaimtLabel11.Text = "Tipo Comprobante :"
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.Location = New System.Drawing.Point(359, 170)
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoComprobante.Properties.NullText = ""
        Me.cboTipoComprobante.Size = New System.Drawing.Size(145, 20)
        Me.cboTipoComprobante.TabIndex = 32
        '
        'txtNroContrato
        '
        Me.txtNroContrato.Location = New System.Drawing.Point(114, 9)
        Me.txtNroContrato.MenuManager = Me.RibbonControl
        Me.txtNroContrato.Name = "txtNroContrato"
        Me.txtNroContrato.Properties.ReadOnly = True
        Me.txtNroContrato.Size = New System.Drawing.Size(100, 20)
        Me.txtNroContrato.TabIndex = 1
        '
        'txtDocRef
        '
        Me.txtDocRef.Location = New System.Drawing.Point(114, 170)
        Me.txtDocRef.Name = "txtDocRef"
        Me.txtDocRef.Size = New System.Drawing.Size(139, 20)
        Me.txtDocRef.TabIndex = 30
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(28, 173)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(80, 13)
        Me.SaimtLabel8.TabIndex = 29
        Me.SaimtLabel8.Text = "Doc Referencia :"
        '
        'txtDiaMaxVen
        '
        Me.txtDiaMaxVen.Location = New System.Drawing.Point(359, 146)
        Me.txtDiaMaxVen.Name = "txtDiaMaxVen"
        Me.txtDiaMaxVen.Properties.Mask.EditMask = "n0"
        Me.txtDiaMaxVen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDiaMaxVen.Size = New System.Drawing.Size(146, 20)
        Me.txtDiaMaxVen.TabIndex = 28
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(288, 149)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel7.TabIndex = 27
        Me.SaimtLabel7.Text = "Dia de Venc. :"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(53, 149)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(55, 13)
        Me.SaimtLabel5.TabIndex = 25
        Me.SaimtLabel5.Text = "Modalidad :"
        '
        'cbModalidad
        '
        Me.cbModalidad.Location = New System.Drawing.Point(114, 146)
        Me.cbModalidad.MenuManager = Me.RibbonControl
        Me.cbModalidad.Name = "cbModalidad"
        Me.cbModalidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbModalidad.Properties.NullText = ""
        Me.cbModalidad.Size = New System.Drawing.Size(139, 20)
        Me.cbModalidad.TabIndex = 26
        '
        'txtObsCon
        '
        Me.txtObsCon.Location = New System.Drawing.Point(114, 242)
        Me.txtObsCon.MenuManager = Me.RibbonControl
        Me.txtObsCon.Name = "txtObsCon"
        Me.txtObsCon.Size = New System.Drawing.Size(390, 65)
        Me.txtObsCon.TabIndex = 40
        Me.txtObsCon.UseOptimizedRendering = True
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(41, 251)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel4.TabIndex = 39
        Me.SaimtLabel4.Text = "Observación :"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.EditValue = Nothing
        Me.dtFechaFin.Location = New System.Drawing.Point(360, 76)
        Me.dtFechaFin.MenuManager = Me.RibbonControl
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFechaFin.Size = New System.Drawing.Size(144, 20)
        Me.dtFechaFin.TabIndex = 14
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.EditValue = Nothing
        Me.dtFechaInicio.Location = New System.Drawing.Point(114, 76)
        Me.dtFechaInicio.MenuManager = Me.RibbonControl
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFechaInicio.Size = New System.Drawing.Size(139, 20)
        Me.dtFechaInicio.TabIndex = 11
        '
        'cboUso
        '
        Me.cboUso.Location = New System.Drawing.Point(359, 99)
        Me.cboUso.MenuManager = Me.RibbonControl
        Me.cboUso.Name = "cboUso"
        Me.cboUso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUso.Properties.NullText = ""
        Me.cboUso.Size = New System.Drawing.Size(146, 20)
        Me.cboUso.TabIndex = 24
        '
        'cboTipoMoneda
        '
        Me.cboTipoMoneda.Location = New System.Drawing.Point(360, 54)
        Me.cboTipoMoneda.MenuManager = Me.RibbonControl
        Me.cboTipoMoneda.Name = "cboTipoMoneda"
        Me.cboTipoMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoMoneda.Properties.NullText = ""
        Me.cboTipoMoneda.Size = New System.Drawing.Size(144, 20)
        Me.cboTipoMoneda.TabIndex = 10
        '
        'cboEstadoContrato
        '
        Me.cboEstadoContrato.Location = New System.Drawing.Point(114, 54)
        Me.cboEstadoContrato.MenuManager = Me.RibbonControl
        Me.cboEstadoContrato.Name = "cboEstadoContrato"
        Me.cboEstadoContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstadoContrato.Properties.NullText = ""
        Me.cboEstadoContrato.Size = New System.Drawing.Size(139, 20)
        Me.cboEstadoContrato.TabIndex = 8
        '
        'btnConsultarConyuge
        '
        Me.btnConsultarConyuge.Image = CType(resources.GetObject("btnConsultarConyuge.Image"), System.Drawing.Image)
        Me.btnConsultarConyuge.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConsultarConyuge.Location = New System.Drawing.Point(482, 8)
        Me.btnConsultarConyuge.Name = "btnConsultarConyuge"
        Me.btnConsultarConyuge.Size = New System.Drawing.Size(21, 21)
        Me.btnConsultarConyuge.TabIndex = 4
        '
        'txtGarantia
        '
        Me.txtGarantia.Location = New System.Drawing.Point(453, 122)
        Me.txtGarantia.Name = "txtGarantia"
        Me.txtGarantia.Properties.Mask.EditMask = "n2"
        Me.txtGarantia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtGarantia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtGarantia.Size = New System.Drawing.Size(51, 20)
        Me.txtGarantia.TabIndex = 20
        '
        'txtDerLlave
        '
        Me.txtDerLlave.Location = New System.Drawing.Point(114, 123)
        Me.txtDerLlave.Name = "txtDerLlave"
        Me.txtDerLlave.Properties.Mask.EditMask = "n2"
        Me.txtDerLlave.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDerLlave.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDerLlave.Size = New System.Drawing.Size(139, 20)
        Me.txtDerLlave.TabIndex = 23
        '
        'txtMerced
        '
        Me.txtMerced.Location = New System.Drawing.Point(114, 100)
        Me.txtMerced.MenuManager = Me.RibbonControl
        Me.txtMerced.Name = "txtMerced"
        Me.txtMerced.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMerced.Properties.Appearance.Options.UseBackColor = True
        Me.txtMerced.Properties.Mask.EditMask = "n2"
        Me.txtMerced.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMerced.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMerced.Size = New System.Drawing.Size(139, 20)
        Me.txtMerced.TabIndex = 16
        '
        'SaimtLabel28
        '
        Me.SaimtLabel28.Location = New System.Drawing.Point(305, 123)
        Me.SaimtLabel28.Name = "SaimtLabel28"
        Me.SaimtLabel28.Size = New System.Drawing.Size(48, 13)
        Me.SaimtLabel28.TabIndex = 18
        Me.SaimtLabel28.Text = "Garantia :"
        '
        'SaimtLabel27
        '
        Me.SaimtLabel27.Location = New System.Drawing.Point(9, 101)
        Me.SaimtLabel27.Name = "SaimtLabel27"
        Me.SaimtLabel27.Size = New System.Drawing.Size(99, 13)
        Me.SaimtLabel27.TabIndex = 15
        Me.SaimtLabel27.Text = "Merced Conductiva :"
        '
        'SaimtLabel26
        '
        Me.SaimtLabel26.Location = New System.Drawing.Point(27, 126)
        Me.SaimtLabel26.Name = "SaimtLabel26"
        Me.SaimtLabel26.Size = New System.Drawing.Size(81, 13)
        Me.SaimtLabel26.TabIndex = 22
        Me.SaimtLabel26.Text = "Derecho a llave :"
        '
        'SaimtLabel25
        '
        Me.SaimtLabel25.Location = New System.Drawing.Point(328, 101)
        Me.SaimtLabel25.Name = "SaimtLabel25"
        Me.SaimtLabel25.Size = New System.Drawing.Size(25, 13)
        Me.SaimtLabel25.TabIndex = 21
        Me.SaimtLabel25.Text = "Uso :"
        '
        'SaimtLabel24
        '
        Me.SaimtLabel24.Location = New System.Drawing.Point(278, 79)
        Me.SaimtLabel24.Name = "SaimtLabel24"
        Me.SaimtLabel24.Size = New System.Drawing.Size(77, 13)
        Me.SaimtLabel24.TabIndex = 12
        Me.SaimtLabel24.Text = "Fecha Término :"
        '
        'SaimtLabel23
        '
        Me.SaimtLabel23.Location = New System.Drawing.Point(41, 82)
        Me.SaimtLabel23.Name = "SaimtLabel23"
        Me.SaimtLabel23.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel23.TabIndex = 13
        Me.SaimtLabel23.Text = "Fecha  Inicio :"
        '
        'SaimtLabel21
        '
        Me.SaimtLabel21.Location = New System.Drawing.Point(288, 57)
        Me.SaimtLabel21.Name = "SaimtLabel21"
        Me.SaimtLabel21.Size = New System.Drawing.Size(68, 13)
        Me.SaimtLabel21.TabIndex = 9
        Me.SaimtLabel21.Text = "Tipo Moneda :"
        '
        'SaimtLabel20
        '
        Me.SaimtLabel20.Location = New System.Drawing.Point(68, 57)
        Me.SaimtLabel20.Name = "SaimtLabel20"
        Me.SaimtLabel20.Size = New System.Drawing.Size(40, 13)
        Me.SaimtLabel20.TabIndex = 7
        Me.SaimtLabel20.Text = "Estado :"
        '
        'txtDirInmueble
        '
        Me.txtDirInmueble.EditValue = ""
        Me.txtDirInmueble.Location = New System.Drawing.Point(114, 31)
        Me.txtDirInmueble.Name = "txtDirInmueble"
        Me.txtDirInmueble.Size = New System.Drawing.Size(390, 20)
        Me.txtDirInmueble.TabIndex = 6
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(215, 12)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(97, 13)
        Me.SaimtLabel6.TabIndex = 2
        Me.SaimtLabel6.Text = " Cod Inm - Nombre :"
        '
        'txtCodInmueble
        '
        Me.txtCodInmueble.EditValue = ""
        Me.txtCodInmueble.Location = New System.Drawing.Point(318, 9)
        Me.txtCodInmueble.Name = "txtCodInmueble"
        Me.txtCodInmueble.Size = New System.Drawing.Size(158, 20)
        Me.txtCodInmueble.TabIndex = 3
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(58, 35)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel2.TabIndex = 5
        Me.SaimtLabel2.Text = "Dirección :"
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel13.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.SaimtLabel13.Location = New System.Drawing.Point(17, 10)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(91, 16)
        Me.SaimtLabel13.TabIndex = 0
        Me.SaimtLabel13.Text = "N° CONTRATO:"
        '
        'grbLista
        '
        Me.grbLista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbLista.Controls.Add(Me.dgvListadoPersona)
        Me.grbLista.Location = New System.Drawing.Point(8, 64)
        Me.grbLista.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbLista.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbLista.Name = "grbLista"
        Me.grbLista.Size = New System.Drawing.Size(352, 260)
        Me.grbLista.TabIndex = 3
        Me.grbLista.Text = "Listado de Arrendatarios"
        '
        'dgvListadoPersona
        '
        Me.dgvListadoPersona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoPersona.Location = New System.Drawing.Point(2, 21)
        Me.dgvListadoPersona.MainView = Me.gvListadoPersona
        Me.dgvListadoPersona.MenuManager = Me.RibbonControl
        Me.dgvListadoPersona.Name = "dgvListadoPersona"
        Me.dgvListadoPersona.Size = New System.Drawing.Size(348, 237)
        Me.dgvListadoPersona.TabIndex = 0
        Me.dgvListadoPersona.Tag = "0"
        Me.dgvListadoPersona.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoPersona})
        '
        'gvListadoPersona
        '
        Me.gvListadoPersona.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3})
        Me.gvListadoPersona.GridControl = Me.dgvListadoPersona
        Me.gvListadoPersona.Name = "gvListadoPersona"
        Me.gvListadoPersona.OptionsBehavior.ReadOnly = True
        Me.gvListadoPersona.OptionsView.ColumnAutoWidth = False
        Me.gvListadoPersona.OptionsView.ShowGroupPanel = False
        Me.gvListadoPersona.Tag = ""
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Cod. Persona"
        Me.GridColumn2.FieldName = "CodPersona"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Persona"
        Me.GridColumn3.FieldName = "Persona"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.txtTipoDocumento)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel30)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel9)
        Me.SaimtGroupBox1.Controls.Add(Me.txtPerId)
        Me.SaimtGroupBox1.Controls.Add(Me.txtObsPer)
        Me.SaimtGroupBox1.Controls.Add(Me.cboTipoPersona)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.txtDireccion)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel17)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel19)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel22)
        Me.SaimtGroupBox1.Controls.Add(Me.btnBuscarPersona)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel29)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNombreRazon)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroDocumento)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(3, 13)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(545, 170)
        Me.SaimtGroupBox1.TabIndex = 0
        Me.SaimtGroupBox1.Text = "Datos de Persona"
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.Location = New System.Drawing.Point(321, 30)
        Me.txtTipoDocumento.MenuManager = Me.RibbonControl
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.Size = New System.Drawing.Size(179, 20)
        Me.txtTipoDocumento.TabIndex = 3
        '
        'SaimtLabel30
        '
        Me.SaimtLabel30.Location = New System.Drawing.Point(271, 34)
        Me.SaimtLabel30.Name = "SaimtLabel30"
        Me.SaimtLabel30.Size = New System.Drawing.Size(45, 13)
        Me.SaimtLabel30.TabIndex = 2
        Me.SaimtLabel30.Text = "Tipo Doc."
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(35, 61)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel10.TabIndex = 5
        Me.SaimtLabel10.Text = "Tipo Persona :"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(36, 34)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(68, 13)
        Me.SaimtLabel9.TabIndex = 1
        Me.SaimtLabel9.Text = "Cod Persona :"
        '
        'txtPerId
        '
        Me.txtPerId.EditValue = ""
        Me.txtPerId.Location = New System.Drawing.Point(110, 31)
        Me.txtPerId.Name = "txtPerId"
        Me.txtPerId.Size = New System.Drawing.Size(139, 20)
        Me.txtPerId.TabIndex = 4
        '
        'txtObsPer
        '
        Me.txtObsPer.Location = New System.Drawing.Point(110, 124)
        Me.txtObsPer.MenuManager = Me.RibbonControl
        Me.txtObsPer.Name = "txtObsPer"
        Me.txtObsPer.Size = New System.Drawing.Size(390, 35)
        Me.txtObsPer.TabIndex = 15
        Me.txtObsPer.UseOptimizedRendering = True
        '
        'cboTipoPersona
        '
        Me.cboTipoPersona.Location = New System.Drawing.Point(110, 57)
        Me.cboTipoPersona.Name = "cboTipoPersona"
        Me.cboTipoPersona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoPersona.Properties.NullText = ""
        Me.cboTipoPersona.Size = New System.Drawing.Size(139, 20)
        Me.cboTipoPersona.TabIndex = 6
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(37, 127)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel3.TabIndex = 14
        Me.SaimtLabel3.Text = "Observación :"
        '
        'txtDireccion
        '
        Me.txtDireccion.EditValue = ""
        Me.txtDireccion.Location = New System.Drawing.Point(110, 101)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(390, 20)
        Me.txtDireccion.TabIndex = 13
        '
        'SaimtLabel17
        '
        Me.SaimtLabel17.Location = New System.Drawing.Point(54, 104)
        Me.SaimtLabel17.Name = "SaimtLabel17"
        Me.SaimtLabel17.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel17.TabIndex = 12
        Me.SaimtLabel17.Text = "Dirección :"
        '
        'SaimtLabel19
        '
        Me.SaimtLabel19.Location = New System.Drawing.Point(13, 80)
        Me.SaimtLabel19.Name = "SaimtLabel19"
        Me.SaimtLabel19.Size = New System.Drawing.Size(91, 13)
        Me.SaimtLabel19.TabIndex = 9
        Me.SaimtLabel19.Text = "Nombres o Razon :"
        '
        'SaimtLabel22
        '
        Me.SaimtLabel22.Location = New System.Drawing.Point(266, 57)
        Me.SaimtLabel22.Name = "SaimtLabel22"
        Me.SaimtLabel22.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel22.TabIndex = 7
        Me.SaimtLabel22.Text = "Nro. Doc.:"
        '
        'btnBuscarPersona
        '
        Me.btnBuscarPersona.Image = CType(resources.GetObject("btnBuscarPersona.Image"), System.Drawing.Image)
        Me.btnBuscarPersona.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBuscarPersona.Location = New System.Drawing.Point(476, 78)
        Me.btnBuscarPersona.Name = "btnBuscarPersona"
        Me.btnBuscarPersona.Size = New System.Drawing.Size(21, 21)
        Me.btnBuscarPersona.TabIndex = 11
        '
        'SaimtLabel29
        '
        Me.SaimtLabel29.Location = New System.Drawing.Point(-289, -171)
        Me.SaimtLabel29.Name = "SaimtLabel29"
        Me.SaimtLabel29.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel29.TabIndex = 0
        Me.SaimtLabel29.Text = "Tipo Persona :"
        '
        'txtNombreRazon
        '
        Me.txtNombreRazon.EditValue = ""
        Me.txtNombreRazon.Location = New System.Drawing.Point(110, 79)
        Me.txtNombreRazon.Name = "txtNombreRazon"
        Me.txtNombreRazon.Size = New System.Drawing.Size(360, 20)
        Me.txtNombreRazon.TabIndex = 10
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.EditValue = ""
        Me.txtNroDocumento.Location = New System.Drawing.Point(322, 54)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(144, 20)
        Me.txtNroDocumento.TabIndex = 8
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(200, 585)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar Edición"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImprimir.Location = New System.Drawing.Point(341, 585)
        Me.btnImprimir.LookAndFeel.SkinName = "Seven"
        Me.btnImprimir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 64)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(271, 585)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(60, 585)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnCancelarContrato
        '
        Me.btnCancelarContrato.Image = CType(resources.GetObject("btnCancelarContrato.Image"), System.Drawing.Image)
        Me.btnCancelarContrato.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelarContrato.Location = New System.Drawing.Point(411, 585)
        Me.btnCancelarContrato.LookAndFeel.SkinName = "Seven"
        Me.btnCancelarContrato.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelarContrato.Name = "btnCancelarContrato"
        Me.btnCancelarContrato.Size = New System.Drawing.Size(68, 64)
        Me.btnCancelarContrato.TabIndex = 7
        Me.btnCancelarContrato.Text = "Cancelar Contrato"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(130, 585)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Editar"
        '
        'bieprogreso
        '
        Me.bieprogreso.Caption = "BarEditItem1"
        Me.bieprogreso.Edit = Me.ripprogreso
        Me.bieprogreso.Id = 2
        Me.bieprogreso.Name = "bieprogreso"
        Me.bieprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bieprogreso.Width = 110
        '
        'ripprogreso
        '
        Me.ripprogreso.Name = "ripprogreso"
        '
        'bieprogresomarque
        '
        Me.bieprogresomarque.Caption = "BarEditItem1"
        Me.bieprogresomarque.Edit = Me.RepositoryItemMarqueeProgressBar1
        Me.bieprogresomarque.Id = 2
        Me.bieprogresomarque.Name = "bieprogresomarque"
        Me.bieprogresomarque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bieprogresomarque.Width = 110
        '
        'RepositoryItemMarqueeProgressBar1
        '
        Me.RepositoryItemMarqueeProgressBar1.MarqueeAnimationSpeed = 50
        Me.RepositoryItemMarqueeProgressBar1.Name = "RepositoryItemMarqueeProgressBar1"
        Me.RepositoryItemMarqueeProgressBar1.Stopped = True
        '
        'tabDetContrato
        '
        Me.tabDetContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDetContrato.Location = New System.Drawing.Point(5, 186)
        Me.tabDetContrato.Name = "tabDetContrato"
        Me.tabDetContrato.SelectedTabPage = Me.XtraTabPage1
        Me.tabDetContrato.Size = New System.Drawing.Size(528, 393)
        Me.tabDetContrato.TabIndex = 1
        Me.tabDetContrato.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnincrementar)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel18)
        Me.XtraTabPage1.Controls.Add(Me.txtPorcentajeInc)
        Me.XtraTabPage1.Controls.Add(Me.btnObtenerMCAnt)
        Me.XtraTabPage1.Controls.Add(Me.btnArchivosAnexados)
        Me.XtraTabPage1.Controls.Add(Me.cboTipoGarantia)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel13)
        Me.XtraTabPage1.Controls.Add(Me.txtRegMesPart)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel2)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel15)
        Me.XtraTabPage1.Controls.Add(Me.txtCodInmueble)
        Me.XtraTabPage1.Controls.Add(Me.dtFechaSol)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel6)
        Me.XtraTabPage1.Controls.Add(Me.dtFechaSus)
        Me.XtraTabPage1.Controls.Add(Me.txtDirInmueble)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel12)
        Me.XtraTabPage1.Controls.Add(Me.cboUso)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel25)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel20)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel14)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel21)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel11)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel23)
        Me.XtraTabPage1.Controls.Add(Me.cboTipoComprobante)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel24)
        Me.XtraTabPage1.Controls.Add(Me.txtNroContrato)
        Me.XtraTabPage1.Controls.Add(Me.txtDocRef)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel26)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel8)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel27)
        Me.XtraTabPage1.Controls.Add(Me.txtDiaMaxVen)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel28)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel7)
        Me.XtraTabPage1.Controls.Add(Me.txtMerced)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel5)
        Me.XtraTabPage1.Controls.Add(Me.txtDerLlave)
        Me.XtraTabPage1.Controls.Add(Me.cbModalidad)
        Me.XtraTabPage1.Controls.Add(Me.txtGarantia)
        Me.XtraTabPage1.Controls.Add(Me.txtObsCon)
        Me.XtraTabPage1.Controls.Add(Me.btnConsultarConyuge)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel4)
        Me.XtraTabPage1.Controls.Add(Me.cboEstadoContrato)
        Me.XtraTabPage1.Controls.Add(Me.dtFechaFin)
        Me.XtraTabPage1.Controls.Add(Me.cboTipoMoneda)
        Me.XtraTabPage1.Controls.Add(Me.dtFechaInicio)
        Me.XtraTabPage1.Image = CType(resources.GetObject("XtraTabPage1.Image"), System.Drawing.Image)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(522, 361)
        Me.XtraTabPage1.Text = "Datos Contrato"
        '
        'btnincrementar
        '
        Me.btnincrementar.Image = CType(resources.GetObject("btnincrementar.Image"), System.Drawing.Image)
        Me.btnincrementar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnincrementar.Location = New System.Drawing.Point(315, 313)
        Me.btnincrementar.Name = "btnincrementar"
        Me.btnincrementar.Size = New System.Drawing.Size(93, 45)
        Me.btnincrementar.TabIndex = 43
        Me.btnincrementar.Text = "Incrementar"
        Me.btnincrementar.ToolTip = "Incrementa la Merced Conductiva al porcentaje establecido"
        '
        'SaimtLabel18
        '
        Me.SaimtLabel18.Location = New System.Drawing.Point(32, 329)
        Me.SaimtLabel18.Name = "SaimtLabel18"
        Me.SaimtLabel18.Size = New System.Drawing.Size(202, 13)
        Me.SaimtLabel18.TabIndex = 41
        Me.SaimtLabel18.Text = "Se incrementara la Merced Conductiva en "
        '
        'txtPorcentajeInc
        '
        Me.txtPorcentajeInc.EditValue = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.txtPorcentajeInc.Location = New System.Drawing.Point(237, 326)
        Me.txtPorcentajeInc.MenuManager = Me.RibbonControl
        Me.txtPorcentajeInc.Name = "txtPorcentajeInc"
        Me.txtPorcentajeInc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPorcentajeInc.Properties.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtPorcentajeInc.Properties.Mask.EditMask = "p"
        Me.txtPorcentajeInc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentajeInc.Size = New System.Drawing.Size(72, 20)
        Me.txtPorcentajeInc.TabIndex = 42
        '
        'btnObtenerMCAnt
        '
        Me.btnObtenerMCAnt.Image = CType(resources.GetObject("btnObtenerMCAnt.Image"), System.Drawing.Image)
        Me.btnObtenerMCAnt.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnObtenerMCAnt.Location = New System.Drawing.Point(255, 99)
        Me.btnObtenerMCAnt.Name = "btnObtenerMCAnt"
        Me.btnObtenerMCAnt.Size = New System.Drawing.Size(30, 23)
        Me.btnObtenerMCAnt.TabIndex = 17
        Me.btnObtenerMCAnt.ToolTip = "Obtener Merced Conductiva del ultimo contrato"
        '
        'btnArchivosAnexados
        '
        Me.btnArchivosAnexados.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnArchivosAnexados.Appearance.Options.UseFont = True
        Me.btnArchivosAnexados.Appearance.Options.UseTextOptions = True
        Me.btnArchivosAnexados.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnArchivosAnexados.Image = CType(resources.GetObject("btnArchivosAnexados.Image"), System.Drawing.Image)
        Me.btnArchivosAnexados.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnArchivosAnexados.Location = New System.Drawing.Point(412, 313)
        Me.btnArchivosAnexados.LookAndFeel.SkinName = "Seven"
        Me.btnArchivosAnexados.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnArchivosAnexados.Name = "btnArchivosAnexados"
        Me.btnArchivosAnexados.Size = New System.Drawing.Size(102, 45)
        Me.btnArchivosAnexados.TabIndex = 44
        Me.btnArchivosAnexados.Text = "Archivos Anexados"
        Me.btnArchivosAnexados.Visible = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.cboTipoArchivos)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel42)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel16)
        Me.XtraTabPage2.Controls.Add(Me.txtNroContrato1)
        Me.XtraTabPage2.Controls.Add(Me.btnVerArchivos)
        Me.XtraTabPage2.Controls.Add(Me.dgvArchivos)
        Me.XtraTabPage2.Controls.Add(Me.btnRemover)
        Me.XtraTabPage2.Controls.Add(Me.btnAgregar)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel40)
        Me.XtraTabPage2.Controls.Add(Me.txtDescripcionArchivo)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel41)
        Me.XtraTabPage2.Controls.Add(Me.txtNombreArchivo)
        Me.XtraTabPage2.Controls.Add(Me.btnExaminarArchivo)
        Me.XtraTabPage2.Controls.Add(Me.txtBuscarArchivo)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel35)
        Me.XtraTabPage2.Image = CType(resources.GetObject("XtraTabPage2.Image"), System.Drawing.Image)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(522, 361)
        Me.XtraTabPage2.Text = "Anexar Archivos"
        '
        'cboTipoArchivos
        '
        Me.cboTipoArchivos.Location = New System.Drawing.Point(91, 83)
        Me.cboTipoArchivos.MenuManager = Me.RibbonControl
        Me.cboTipoArchivos.Name = "cboTipoArchivos"
        Me.cboTipoArchivos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoArchivos.Properties.LookAndFeel.SkinName = "Seven"
        Me.cboTipoArchivos.Properties.NullText = ""
        Me.cboTipoArchivos.Size = New System.Drawing.Size(156, 20)
        Me.cboTipoArchivos.TabIndex = 10
        '
        'SaimtLabel42
        '
        Me.SaimtLabel42.Location = New System.Drawing.Point(20, 82)
        Me.SaimtLabel42.Name = "SaimtLabel42"
        Me.SaimtLabel42.Size = New System.Drawing.Size(66, 13)
        Me.SaimtLabel42.TabIndex = 9
        Me.SaimtLabel42.Text = "Tipo Archivo :"
        '
        'SaimtLabel16
        '
        Me.SaimtLabel16.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel16.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.SaimtLabel16.Location = New System.Drawing.Point(4, 5)
        Me.SaimtLabel16.Name = "SaimtLabel16"
        Me.SaimtLabel16.Size = New System.Drawing.Size(82, 16)
        Me.SaimtLabel16.TabIndex = 0
        Me.SaimtLabel16.Text = "N° Contrato:"
        '
        'txtNroContrato1
        '
        Me.txtNroContrato1.Location = New System.Drawing.Point(91, 4)
        Me.txtNroContrato1.MenuManager = Me.RibbonControl
        Me.txtNroContrato1.Name = "txtNroContrato1"
        Me.txtNroContrato1.Properties.ReadOnly = True
        Me.txtNroContrato1.Size = New System.Drawing.Size(93, 20)
        Me.txtNroContrato1.TabIndex = 1
        '
        'btnVerArchivos
        '
        Me.btnVerArchivos.Image = Global.Presentacion.My.Resources.Resources.observacion
        Me.btnVerArchivos.Location = New System.Drawing.Point(360, 83)
        Me.btnVerArchivos.Name = "btnVerArchivos"
        Me.btnVerArchivos.Size = New System.Drawing.Size(95, 23)
        Me.btnVerArchivos.TabIndex = 11
        Me.btnVerArchivos.Text = "Ver archivos"
        '
        'dgvArchivos
        '
        Me.dgvArchivos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvArchivos.Location = New System.Drawing.Point(0, 109)
        Me.dgvArchivos.MainView = Me.gvArchivos
        Me.dgvArchivos.MenuManager = Me.RibbonControl
        Me.dgvArchivos.Name = "dgvArchivos"
        Me.dgvArchivos.Size = New System.Drawing.Size(522, 252)
        Me.dgvArchivos.TabIndex = 14
        Me.dgvArchivos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArchivos, Me.GridView1})
        '
        'gvArchivos
        '
        Me.gvArchivos.GridControl = Me.dgvArchivos
        Me.gvArchivos.Name = "gvArchivos"
        Me.gvArchivos.OptionsBehavior.ReadOnly = True
        Me.gvArchivos.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgvArchivos
        Me.GridView1.Name = "GridView1"
        '
        'btnRemover
        '
        Me.btnRemover.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnRemover.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRemover.Location = New System.Drawing.Point(489, 87)
        Me.btnRemover.LookAndFeel.SkinName = "Seven"
        Me.btnRemover.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(25, 18)
        Me.btnRemover.TabIndex = 13
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(461, 87)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 18)
        Me.btnAgregar.TabIndex = 12
        '
        'SaimtLabel40
        '
        Me.SaimtLabel40.Location = New System.Drawing.Point(5, 49)
        Me.SaimtLabel40.Name = "SaimtLabel40"
        Me.SaimtLabel40.Size = New System.Drawing.Size(81, 13)
        Me.SaimtLabel40.TabIndex = 7
        Me.SaimtLabel40.Text = "Descrip Archivo :"
        '
        'txtDescripcionArchivo
        '
        Me.txtDescripcionArchivo.Location = New System.Drawing.Point(91, 50)
        Me.txtDescripcionArchivo.MenuManager = Me.RibbonControl
        Me.txtDescripcionArchivo.Name = "txtDescripcionArchivo"
        Me.txtDescripcionArchivo.Properties.LookAndFeel.SkinName = "Seven"
        Me.txtDescripcionArchivo.Size = New System.Drawing.Size(426, 29)
        Me.txtDescripcionArchivo.TabIndex = 8
        Me.txtDescripcionArchivo.UseOptimizedRendering = True
        '
        'SaimtLabel41
        '
        Me.SaimtLabel41.Location = New System.Drawing.Point(190, 8)
        Me.SaimtLabel41.Name = "SaimtLabel41"
        Me.SaimtLabel41.Size = New System.Drawing.Size(44, 13)
        Me.SaimtLabel41.TabIndex = 2
        Me.SaimtLabel41.Text = "Nombre :"
        '
        'txtNombreArchivo
        '
        Me.txtNombreArchivo.Location = New System.Drawing.Point(240, 4)
        Me.txtNombreArchivo.MenuManager = Me.RibbonControl
        Me.txtNombreArchivo.Name = "txtNombreArchivo"
        Me.txtNombreArchivo.Properties.LookAndFeel.SkinName = "Seven"
        Me.txtNombreArchivo.Size = New System.Drawing.Size(277, 20)
        Me.txtNombreArchivo.TabIndex = 3
        '
        'btnExaminarArchivo
        '
        Me.btnExaminarArchivo.Image = Global.Presentacion.My.Resources.Resources.examinar
        Me.btnExaminarArchivo.Location = New System.Drawing.Point(496, 26)
        Me.btnExaminarArchivo.Name = "btnExaminarArchivo"
        Me.btnExaminarArchivo.Size = New System.Drawing.Size(23, 22)
        Me.btnExaminarArchivo.TabIndex = 6
        '
        'txtBuscarArchivo
        '
        Me.txtBuscarArchivo.Location = New System.Drawing.Point(91, 27)
        Me.txtBuscarArchivo.MenuManager = Me.RibbonControl
        Me.txtBuscarArchivo.Name = "txtBuscarArchivo"
        Me.txtBuscarArchivo.Properties.LookAndFeel.SkinName = "Seven"
        Me.txtBuscarArchivo.Size = New System.Drawing.Size(403, 20)
        Me.txtBuscarArchivo.TabIndex = 5
        '
        'SaimtLabel35
        '
        Me.SaimtLabel35.Location = New System.Drawing.Point(7, 30)
        Me.SaimtLabel35.Name = "SaimtLabel35"
        Me.SaimtLabel35.Size = New System.Drawing.Size(79, 13)
        Me.SaimtLabel35.TabIndex = 4
        Me.SaimtLabel35.Text = "Buscar archivos:"
        '
        'ofdExaminarArchivos
        '
        Me.ofdExaminarArchivos.FileName = "OpenFileDialog1"
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboTipoUso)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboBuscarContratoPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarContratoPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboBuscarPersonaPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarPersonaPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.grbContratos)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.grbLista)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnImprimir)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.tabDetContrato)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnCancelarContrato)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEditar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnNuevo)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnCancelar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(906, 681)
        Me.SaimtSplitContainerControl1.SplitterPosition = 365
        Me.SaimtSplitContainerControl1.TabIndex = 0
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'cboTipoUso
        '
        Me.cboTipoUso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoUso.Location = New System.Drawing.Point(8, 350)
        Me.cboTipoUso.MenuManager = Me.RibbonControl
        Me.cboTipoUso.Name = "cboTipoUso"
        Me.cboTipoUso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoUso.Properties.NullText = ""
        Me.cboTipoUso.Size = New System.Drawing.Size(352, 20)
        Me.cboTipoUso.TabIndex = 5
        Me.cboTipoUso.Tag = "0"
        '
        'cboBuscarContratoPor
        '
        Me.cboBuscarContratoPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBuscarContratoPor.EditValue = "Busqueda por Cod. Persona"
        Me.cboBuscarContratoPor.Location = New System.Drawing.Point(8, 329)
        Me.cboBuscarContratoPor.MenuManager = Me.RibbonControl
        Me.cboBuscarContratoPor.Name = "cboBuscarContratoPor"
        Me.cboBuscarContratoPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarContratoPor.Properties.Items.AddRange(New Object() {"Busqueda por Cod. Persona", "Busqueda por N° Contrato", "Busqueda por Dirección Inmueble", "Busqueda por Tipo de Uso", "Busqueda por Registro Mesa Partes", "Busqueda por Doc. Referencia"})
        Me.cboBuscarContratoPor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBuscarContratoPor.Size = New System.Drawing.Size(352, 20)
        Me.cboBuscarContratoPor.TabIndex = 4
        Me.cboBuscarContratoPor.Tag = "0"
        '
        'txtBuscarContratoPor
        '
        Me.txtBuscarContratoPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarContratoPor.Location = New System.Drawing.Point(8, 372)
        Me.txtBuscarContratoPor.MenuManager = Me.RibbonControl
        Me.txtBuscarContratoPor.Name = "txtBuscarContratoPor"
        Me.txtBuscarContratoPor.Size = New System.Drawing.Size(352, 20)
        Me.txtBuscarContratoPor.TabIndex = 6
        Me.txtBuscarContratoPor.Tag = "0"
        '
        'cboBuscarPersonaPor
        '
        Me.cboBuscarPersonaPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBuscarPersonaPor.EditValue = "Busqueda por Apellidos y Nombres"
        Me.cboBuscarPersonaPor.Location = New System.Drawing.Point(8, 17)
        Me.cboBuscarPersonaPor.MenuManager = Me.RibbonControl
        Me.cboBuscarPersonaPor.Name = "cboBuscarPersonaPor"
        Me.cboBuscarPersonaPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarPersonaPor.Properties.Items.AddRange(New Object() {"Busqueda por Apellidos y Nombres", "Busqueda por RUC", "Busqueda por DNI"})
        Me.cboBuscarPersonaPor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBuscarPersonaPor.Size = New System.Drawing.Size(352, 20)
        Me.cboBuscarPersonaPor.TabIndex = 1
        Me.cboBuscarPersonaPor.Tag = "0"
        '
        'frmContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonCancelarData = Me.btnCancelarContrato
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonImprimir = Me.btnImprimir
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(906, 708)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.dgvListado = Me.dgvListadoContratos
        Me.LookAndFeel.SkinName = "Seven"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmContrato"
        Me.Text = " Contratos de Arrendamiento"
        Me.txtBuscarSaimt = Me.txtBuscarContratoPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContratos.ResumeLayout(False)
        CType(Me.dgvListadoContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoGarantia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegMesPart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaSol.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaSol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaSus.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaSus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaMaxVen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbModalidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObsCon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGarantia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDerLlave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMerced.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDirInmueble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodInmueble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLista.ResumeLayout(False)
        CType(Me.dgvListadoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObsPer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreRazon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ripprogreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabDetContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetContrato.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtPorcentajeInc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cboTipoArchivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroContrato1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.cboTipoUso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtBuscarPersonaPor As SaimtControles.SaimtTextBox
    Friend WithEvents grbContratos As SaimtControles.SaimtGroupBox
    Friend WithEvents BackstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem1 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator2 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem2 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator3 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem3 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator4 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents txtGarantia As SaimtControles.SaimtTextBox
    Friend WithEvents txtDerLlave As SaimtControles.SaimtTextBox
    Friend WithEvents txtMerced As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel28 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel27 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel26 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel25 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel24 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel23 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel21 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel20 As SaimtControles.SaimtLabel
    Friend WithEvents txtDirInmueble As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents txtCodInmueble As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents btnConsultarConyuge As SaimtControles.SaimtButton
    Friend WithEvents cboEstadoContrato As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboUso As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboTipoMoneda As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents dtFechaFin As SaimtControles.SaimtDateTimePicker
    Friend WithEvents dtFechaInicio As SaimtControles.SaimtDateTimePicker
    Friend WithEvents grbLista As SaimtControles.SaimtGroupBox
    Friend WithEvents txtObsCon As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtObsPer As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents cboTipoPersona As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents txtDireccion As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel17 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel19 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel22 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel29 As SaimtControles.SaimtLabel
    Friend WithEvents txtNombreRazon As SaimtControles.SaimtTextBox
    Friend WithEvents txtNroDocumento As SaimtControles.SaimtTextBox
    Friend WithEvents btnBuscarPersona As SaimtControles.SaimtButton
    Friend WithEvents cbModalidad As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtDiaMaxVen As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtDocRef As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents txtPerId As SaimtControles.SaimtTextBox
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnCancelarContrato As SaimtControles.SaimtButton
    Friend WithEvents txtNroContrato As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoComprobante As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtRegMesPart As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents dtFechaSol As SaimtControles.SaimtDateTimePicker
    Friend WithEvents dtFechaSus As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents fbdcontrato As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents bieprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ripprogreso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents bieprogresomarque As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents cboTipoGarantia As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents tabDetContrato As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnExaminarArchivo As SaimtControles.SaimtButton
    Friend WithEvents txtBuscarArchivo As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel35 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel41 As SaimtControles.SaimtLabel
    Friend WithEvents txtNombreArchivo As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel40 As SaimtControles.SaimtLabel
    Friend WithEvents txtDescripcionArchivo As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents btnRemover As SaimtControles.SaimtButton
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
    Friend WithEvents btnVerArchivos As SaimtControles.SaimtButton
    Friend WithEvents dgvArchivos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvArchivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SaimtLabel16 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroContrato1 As SaimtControles.SaimtTextBox
    Friend WithEvents ofdExaminarArchivos As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cboTipoArchivos As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel42 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents btnArchivosAnexados As SaimtControles.SaimtButton
    Friend WithEvents txtBuscarContratoPor As SaimtControles.SaimtTextBox
    Friend WithEvents cboBuscarPersonaPor As SaimtControles.SaimtComboBox
    Friend WithEvents SaimtLabel30 As SaimtControles.SaimtLabel
    Friend WithEvents dgvListadoPersona As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoPersona As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvListadoContratos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoContratos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboBuscarContratoPor As SaimtControles.SaimtComboBox
    Friend WithEvents cboTipoUso As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtTipoDocumento As SaimtControles.SaimtTextBox
    Friend WithEvents btnincrementar As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel18 As SaimtControles.SaimtLabel
    Friend WithEvents txtPorcentajeInc As SaimtControles.SaimtSpinner
    Friend WithEvents btnObtenerMCAnt As SaimtControles.SaimtButton



End Class



