﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPecosa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPecosa))
        Me.gvDetalleOrdenCompra = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgvDetalleArticulos = New SaimtControles.SaimtDataGrid()
        Me.gvDetalleArticulos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pecDetId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.artId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pcDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.ordId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ordDetId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riProducto = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.riLlevar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtPecosaId = New SaimtControles.SaimtTextBox()
        Me.btnConsultarOC = New SaimtControles.SaimtButton()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.txtNroOrd = New SaimtControles.SaimtTextBox()
        Me.cboAreaDestino = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboMeta = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel28 = New SaimtControles.SaimtLabel()
        Me.cboActProy = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.grbListaClase = New SaimtControles.SaimtGroupBox()
        Me.dgvResultados = New SaimtControles.SaimtDataGrid()
        Me.gvResultados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.BackstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewButtonItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
        Me.BackstageViewItemSeparator2 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewItemSeparator3 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.SaimtTabs1 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnElimEditor = New SaimtControles.SaimtButton()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoExEdit()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.lblmensaje = New SaimtControles.SaimtLabel()
        Me.txtaño = New SaimtControles.SaimtTextBox()
        Me.cmbArticulos = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnRemover = New SaimtControles.SaimtButton()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.txtimporte = New SaimtControles.SaimtTextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtpreciounit = New SaimtControles.SaimtTextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcantidad = New SaimtControles.SaimtSpinner()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboUnidadMed = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.txtMontoTotal = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnConsultarCuentaHaber = New SaimtControles.SaimtButton()
        Me.txtMontoHaber = New SaimtControles.SaimtTextBox()
        Me.btnConsultarCuentaDebe = New SaimtControles.SaimtButton()
        Me.SaimtLabel18 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel16 = New SaimtControles.SaimtLabel()
        Me.txtCuentaHaber = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.txtMontoDebe = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.txtCuentaDebe = New SaimtControles.SaimtTextBox()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.BackstageViewItemSeparator4 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewItemSeparator5 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewItemSeparator6 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem4 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.cboCriterio = New SaimtControles.SaimtComboBox()
        Me.ofdExaminarArchivos = New System.Windows.Forms.OpenFileDialog()
        Me.cboBuscarArea = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.cboAnioCriterio = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.chbAnulado = New SaimtControles.SaimtCheckBox()
        Me.SaimtButton1 = New SaimtControles.SaimtButton()
        Me.txtpersona = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtPecNro = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel19 = New SaimtControles.SaimtLabel()
        Me.meeObservacion = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.dtpFechaPec = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.BackstageViewTabItem5 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewClientControl4 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.fbdExportar = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riLlevar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPecosaId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroOrd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAreaDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMeta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboActProy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbListaClase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbListaClase.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtaño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbArticulos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtimporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpreciounit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnidadMed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtMontoHaber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaHaber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoDebe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaDebe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.cboCriterio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.cboAnioCriterio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.chbAnulado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPecNro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meeObservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPec.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 721)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1068, 27)
        '
        'gvDetalleOrdenCompra
        '
        Me.gvDetalleOrdenCompra.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15})
        Me.gvDetalleOrdenCompra.GridControl = Me.dgvDetalleArticulos
        Me.gvDetalleOrdenCompra.Name = "gvDetalleOrdenCompra"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "pecOrdComDetId"
        Me.GridColumn10.FieldName = "pecOrdComDetId"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "pecDetId"
        Me.GridColumn11.FieldName = "pecDetId"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "artId"
        Me.GridColumn12.FieldName = "artId"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Det. Cantidad"
        Me.GridColumn13.FieldName = "canOrdComDet"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "ordId"
        Me.GridColumn14.FieldName = "ordId"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Det. Precio "
        Me.GridColumn15.FieldName = "precOrdComDet"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 2
        '
        'dgvDetalleArticulos
        '
        Me.dgvDetalleArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleArticulos.Location = New System.Drawing.Point(3, 91)
        Me.dgvDetalleArticulos.MainView = Me.gvDetalleArticulos
        Me.dgvDetalleArticulos.MenuManager = Me.RibbonControl
        Me.dgvDetalleArticulos.Name = "dgvDetalleArticulos"
        Me.dgvDetalleArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1})
        Me.dgvDetalleArticulos.Size = New System.Drawing.Size(677, 305)
        Me.dgvDetalleArticulos.TabIndex = 55
        Me.dgvDetalleArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalleArticulos, Me.gvDetalleOrdenCompra})
        '
        'gvDetalleArticulos
        '
        Me.gvDetalleArticulos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.pecDetId, Me.artId, Me.GridColumn19, Me.GridColumn18, Me.GridColumn20, Me.GridColumn23, Me.GridColumn25, Me.pcDescripcion, Me.ordId, Me.ordDetId, Me.GridColumn5, Me.GridColumn6})
        Me.gvDetalleArticulos.CustomizationFormBounds = New System.Drawing.Rectangle(808, 416, 216, 171)
        Me.gvDetalleArticulos.GridControl = Me.dgvDetalleArticulos
        Me.gvDetalleArticulos.Name = "gvDetalleArticulos"
        Me.gvDetalleArticulos.OptionsView.ColumnAutoWidth = False
        Me.gvDetalleArticulos.OptionsView.ShowGroupPanel = False
        '
        'pecDetId
        '
        Me.pecDetId.Caption = "pecDetId"
        Me.pecDetId.FieldName = "pecDetId"
        Me.pecDetId.Name = "pecDetId"
        '
        'artId
        '
        Me.artId.Caption = "artId"
        Me.artId.FieldName = "artId"
        Me.artId.Name = "artId"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Articulo"
        Me.GridColumn19.FieldName = "artNombre"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 2
        Me.GridColumn19.Width = 272
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "tgUMId"
        Me.GridColumn18.FieldName = "tgUMId"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Unidad Med."
        Me.GridColumn20.FieldName = "tgUM"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 1
        Me.GridColumn20.Width = 88
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Importe (S/.)"
        Me.GridColumn23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn23.FieldName = "pecDetImpTotal"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 5
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Cantidad"
        Me.GridColumn25.FieldName = "pecDetCanTotal"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 0
        Me.GridColumn25.Width = 95
        '
        'pcDescripcion
        '
        Me.pcDescripcion.Caption = "Descripcion"
        Me.pcDescripcion.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.pcDescripcion.FieldName = "artDescripcion"
        Me.pcDescripcion.Name = "pcDescripcion"
        Me.pcDescripcion.Visible = True
        Me.pcDescripcion.VisibleIndex = 3
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'ordId
        '
        Me.ordId.Caption = "ordId"
        Me.ordId.FieldName = "ordId"
        Me.ordId.Name = "ordId"
        '
        'ordDetId
        '
        Me.ordDetId.Caption = "ordDetId"
        Me.ordDetId.FieldName = "ordDetId"
        Me.ordDetId.Name = "ordDetId"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Precio Unitario"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "pecDetPrecio"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nro. O/C"
        Me.GridColumn6.FieldName = "NroOC"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        '
        'riProducto
        '
        Me.riProducto.AutoHeight = False
        Me.riProducto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riProducto.LookAndFeel.SkinName = "Seven"
        Me.riProducto.Name = "riProducto"
        Me.riProducto.ShowIcon = False
        '
        'riLlevar
        '
        Me.riLlevar.AutoHeight = False
        Me.riLlevar.Caption = "Check"
        Me.riLlevar.Name = "riLlevar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(374, 650)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(304, 650)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(164, 650)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(444, 650)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(16, 29)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(62, 13)
        Me.SaimtLabel3.TabIndex = 16
        Me.SaimtLabel3.Text = "Num. Pecosa"
        '
        'txtPecosaId
        '
        Me.txtPecosaId.EditValue = ""
        Me.txtPecosaId.Location = New System.Drawing.Point(291, 26)
        Me.txtPecosaId.Name = "txtPecosaId"
        Me.txtPecosaId.Size = New System.Drawing.Size(89, 20)
        Me.txtPecosaId.TabIndex = 17
        '
        'btnConsultarOC
        '
        Me.btnConsultarOC.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnConsultarOC.Location = New System.Drawing.Point(138, 11)
        Me.btnConsultarOC.Name = "btnConsultarOC"
        Me.btnConsultarOC.Size = New System.Drawing.Size(24, 22)
        Me.btnConsultarOC.TabIndex = 24
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(7, 15)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(34, 13)
        Me.SaimtLabel14.TabIndex = 16
        Me.SaimtLabel14.Text = "N° O/C"
        '
        'txtNroOrd
        '
        Me.txtNroOrd.EditValue = ""
        Me.txtNroOrd.Location = New System.Drawing.Point(45, 12)
        Me.txtNroOrd.Name = "txtNroOrd"
        Me.txtNroOrd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOrd.Properties.MaxLength = 6
        Me.txtNroOrd.Size = New System.Drawing.Size(50, 20)
        Me.txtNroOrd.TabIndex = 17
        '
        'cboAreaDestino
        '
        Me.cboAreaDestino.Location = New System.Drawing.Point(84, 52)
        Me.cboAreaDestino.MenuManager = Me.RibbonControl
        Me.cboAreaDestino.Name = "cboAreaDestino"
        Me.cboAreaDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAreaDestino.Properties.NullText = ""
        Me.cboAreaDestino.Size = New System.Drawing.Size(539, 20)
        Me.cboAreaDestino.TabIndex = 21
        '
        'cboMeta
        '
        Me.cboMeta.Location = New System.Drawing.Point(81, 70)
        Me.cboMeta.MenuManager = Me.RibbonControl
        Me.cboMeta.Name = "cboMeta"
        Me.cboMeta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMeta.Properties.NullText = ""
        Me.cboMeta.Size = New System.Drawing.Size(513, 20)
        Me.cboMeta.TabIndex = 44
        '
        'SaimtLabel28
        '
        Me.SaimtLabel28.Location = New System.Drawing.Point(48, 73)
        Me.SaimtLabel28.Name = "SaimtLabel28"
        Me.SaimtLabel28.Size = New System.Drawing.Size(24, 13)
        Me.SaimtLabel28.TabIndex = 43
        Me.SaimtLabel28.Text = "Meta"
        '
        'cboActProy
        '
        Me.cboActProy.Location = New System.Drawing.Point(81, 34)
        Me.cboActProy.MenuManager = Me.RibbonControl
        Me.cboActProy.Name = "cboActProy"
        Me.cboActProy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboActProy.Properties.NullText = ""
        Me.cboActProy.Size = New System.Drawing.Size(513, 20)
        Me.cboActProy.TabIndex = 42
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(14, 37)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel5.TabIndex = 41
        Me.SaimtLabel5.Text = "ACT/PROY"
        '
        'grbListaClase
        '
        Me.grbListaClase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbListaClase.Controls.Add(Me.dgvResultados)
        Me.grbListaClase.Location = New System.Drawing.Point(1, 107)
        Me.grbListaClase.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbListaClase.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbListaClase.Name = "grbListaClase"
        Me.grbListaClase.Size = New System.Drawing.Size(355, 609)
        Me.grbListaClase.TabIndex = 3
        Me.grbListaClase.Text = "Resultado de Busqueda"
        '
        'dgvResultados
        '
        Me.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResultados.Location = New System.Drawing.Point(2, 21)
        Me.dgvResultados.MainView = Me.gvResultados
        Me.dgvResultados.MenuManager = Me.RibbonControl
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.Size = New System.Drawing.Size(351, 586)
        Me.dgvResultados.TabIndex = 14
        Me.dgvResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResultados})
        '
        'gvResultados
        '
        Me.gvResultados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn4, Me.GridColumn2, Me.GridColumn8})
        Me.gvResultados.GridControl = Me.dgvResultados
        Me.gvResultados.Name = "gvResultados"
        Me.gvResultados.OptionsView.ColumnAutoWidth = False
        Me.gvResultados.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "pecId"
        Me.GridColumn1.FieldName = "pecId"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "N° Pecosa"
        Me.GridColumn4.FieldName = "pecNro"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha Pecosa"
        Me.GridColumn2.FieldName = "pecFecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Area Pecosa"
        Me.GridColumn8.FieldName = "tgAreaDes"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'txtBuscarPor
        '
        Me.txtBuscarPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPor.Location = New System.Drawing.Point(3, 81)
        Me.txtBuscarPor.MenuManager = Me.RibbonControl
        Me.txtBuscarPor.Name = "txtBuscarPor"
        Me.txtBuscarPor.Size = New System.Drawing.Size(353, 20)
        Me.txtBuscarPor.TabIndex = 1
        Me.txtBuscarPor.Tag = "NotClear"
        '
        'BackstageViewTabItem1
        '
        Me.BackstageViewTabItem1.Caption = "BackstageViewTabItem1"
        Me.BackstageViewTabItem1.Name = "BackstageViewTabItem1"
        Me.BackstageViewTabItem1.Selected = False
        '
        'BackstageViewItemSeparator1
        '
        Me.BackstageViewItemSeparator1.Name = "BackstageViewItemSeparator1"
        '
        'BackstageViewButtonItem1
        '
        Me.BackstageViewButtonItem1.Caption = "BackstageViewButtonItem1"
        Me.BackstageViewButtonItem1.Name = "BackstageViewButtonItem1"
        '
        'BackstageViewItemSeparator2
        '
        Me.BackstageViewItemSeparator2.Name = "BackstageViewItemSeparator2"
        '
        'BackstageViewItemSeparator3
        '
        Me.BackstageViewItemSeparator3.Name = "BackstageViewItemSeparator3"
        '
        'SaimtTabs1
        '
        Me.SaimtTabs1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtTabs1.Location = New System.Drawing.Point(8, 192)
        Me.SaimtTabs1.Name = "SaimtTabs1"
        Me.SaimtTabs1.SelectedTabPage = Me.XtraTabPage1
        Me.SaimtTabs1.Size = New System.Drawing.Size(691, 452)
        Me.SaimtTabs1.TabIndex = 15
        Me.SaimtTabs1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnElimEditor)
        Me.XtraTabPage1.Controls.Add(Me.txtDescripcion)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel13)
        Me.XtraTabPage1.Controls.Add(Me.lblmensaje)
        Me.XtraTabPage1.Controls.Add(Me.txtaño)
        Me.XtraTabPage1.Controls.Add(Me.cmbArticulos)
        Me.XtraTabPage1.Controls.Add(Me.btnRemover)
        Me.XtraTabPage1.Controls.Add(Me.btnAgregar)
        Me.XtraTabPage1.Controls.Add(Me.txtimporte)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.txtpreciounit)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.txtcantidad)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.cboUnidadMed)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel12)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel11)
        Me.XtraTabPage1.Controls.Add(Me.btnConsultarOC)
        Me.XtraTabPage1.Controls.Add(Me.dgvDetalleArticulos)
        Me.XtraTabPage1.Controls.Add(Me.txtNroOrd)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel14)
        Me.XtraTabPage1.Controls.Add(Me.txtMontoTotal)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel8)
        Me.XtraTabPage1.Controls.Add(Me.CheckEdit1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(685, 423)
        Me.XtraTabPage1.Text = "Productos Stock"
        '
        'btnElimEditor
        '
        Me.btnElimEditor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnElimEditor.Image = Global.Presentacion.My.Resources.Resources.contrato1
        Me.btnElimEditor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnElimEditor.Location = New System.Drawing.Point(625, 62)
        Me.btnElimEditor.LookAndFeel.SkinName = "Seven"
        Me.btnElimEditor.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnElimEditor.Name = "btnElimEditor"
        Me.btnElimEditor.Size = New System.Drawing.Size(25, 23)
        Me.btnElimEditor.TabIndex = 75
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(255, 39)
        Me.txtDescripcion.MenuManager = Me.RibbonControl
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDescripcion.Properties.ShowIcon = False
        Me.txtDescripcion.Size = New System.Drawing.Size(425, 20)
        Me.txtDescripcion.TabIndex = 74
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(198, 42)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel13.TabIndex = 73
        Me.SaimtLabel13.Text = "Descripción"
        '
        'lblmensaje
        '
        Me.lblmensaje.Location = New System.Drawing.Point(559, 42)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(0, 13)
        Me.lblmensaje.TabIndex = 72
        '
        'txtaño
        '
        Me.txtaño.EditValue = ""
        Me.txtaño.Location = New System.Drawing.Point(97, 12)
        Me.txtaño.MenuManager = Me.RibbonControl
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Properties.Mask.EditMask = "n0"
        Me.txtaño.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtaño.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtaño.Properties.MaxLength = 4
        Me.txtaño.Properties.NullValuePrompt = "Año"
        Me.txtaño.Size = New System.Drawing.Size(39, 20)
        Me.txtaño.TabIndex = 71
        '
        'cmbArticulos
        '
        Me.cmbArticulos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbArticulos.Location = New System.Drawing.Point(214, 12)
        Me.cmbArticulos.MenuManager = Me.RibbonControl
        Me.cmbArticulos.Name = "cmbArticulos"
        Me.cmbArticulos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbArticulos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("artId", "ArtId", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("artDescripcion", "Articulo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ordDetDescripcion", "Descripción"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ordId", "OrdId", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ordDetId", "OrdDetId", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ordDetCantidad", "Cantidad", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("umId", "UmId", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tgUm", "UM", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cmbArticulos.Properties.NullText = ""
        Me.cmbArticulos.Size = New System.Drawing.Size(466, 20)
        Me.cmbArticulos.TabIndex = 70
        '
        'btnRemover
        '
        Me.btnRemover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemover.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnRemover.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRemover.Location = New System.Drawing.Point(655, 62)
        Me.btnRemover.LookAndFeel.SkinName = "Seven"
        Me.btnRemover.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(25, 23)
        Me.btnRemover.TabIndex = 68
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(595, 62)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 23)
        Me.btnAgregar.TabIndex = 67
        '
        'txtimporte
        '
        Me.txtimporte.EditValue = "0"
        Me.txtimporte.Location = New System.Drawing.Point(459, 65)
        Me.txtimporte.MenuManager = Me.RibbonControl
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Properties.Mask.EditMask = "n2"
        Me.txtimporte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtimporte.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtimporte.Size = New System.Drawing.Size(100, 20)
        Me.txtimporte.TabIndex = 66
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(392, 68)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 65
        Me.LabelControl3.Text = "Importe (S/.)"
        '
        'txtpreciounit
        '
        Me.txtpreciounit.EditValue = "0"
        Me.txtpreciounit.Location = New System.Drawing.Point(286, 65)
        Me.txtpreciounit.MenuManager = Me.RibbonControl
        Me.txtpreciounit.Name = "txtpreciounit"
        Me.txtpreciounit.Properties.Mask.EditMask = "n2"
        Me.txtpreciounit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtpreciounit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtpreciounit.Size = New System.Drawing.Size(100, 20)
        Me.txtpreciounit.TabIndex = 64
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(214, 68)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl2.TabIndex = 63
        Me.LabelControl2.Text = "Precio Unitario"
        '
        'txtcantidad
        '
        Me.txtcantidad.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcantidad.Location = New System.Drawing.Point(79, 65)
        Me.txtcantidad.MenuManager = Me.RibbonControl
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 62
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(32, 68)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl1.TabIndex = 61
        Me.LabelControl1.Text = "Cantidad"
        '
        'cboUnidadMed
        '
        Me.cboUnidadMed.Location = New System.Drawing.Point(73, 39)
        Me.cboUnidadMed.MenuManager = Me.RibbonControl
        Me.cboUnidadMed.Name = "cboUnidadMed"
        Me.cboUnidadMed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUnidadMed.Properties.NullText = ""
        Me.cboUnidadMed.Size = New System.Drawing.Size(116, 20)
        Me.cboUnidadMed.TabIndex = 59
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(7, 42)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(62, 13)
        Me.SaimtLabel12.TabIndex = 58
        Me.SaimtLabel12.Text = "Unid. Medida"
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(171, 15)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(41, 13)
        Me.SaimtLabel11.TabIndex = 56
        Me.SaimtLabel11.Text = "Articulos"
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoTotal.EditValue = "0"
        Me.txtMontoTotal.Location = New System.Drawing.Point(580, 400)
        Me.txtMontoTotal.MenuManager = Me.RibbonControl
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoTotal.Properties.Appearance.Options.UseFont = True
        Me.txtMontoTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMontoTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMontoTotal.Properties.Mask.EditMask = "n2"
        Me.txtMontoTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoTotal.TabIndex = 54
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel8.Location = New System.Drawing.Point(506, 403)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(68, 13)
        Me.SaimtLabel8.TabIndex = 53
        Me.SaimtLabel8.Text = "Monto Total"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(566, 66)
        Me.CheckEdit1.MenuManager = Me.RibbonControl
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Trabajar a 4 digitos"
        Me.CheckEdit1.Size = New System.Drawing.Size(114, 19)
        Me.CheckEdit1.TabIndex = 76
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.btnConsultarCuentaHaber)
        Me.XtraTabPage2.Controls.Add(Me.txtMontoHaber)
        Me.XtraTabPage2.Controls.Add(Me.btnConsultarCuentaDebe)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel18)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel16)
        Me.XtraTabPage2.Controls.Add(Me.txtCuentaHaber)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel7)
        Me.XtraTabPage2.Controls.Add(Me.txtMontoDebe)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel6)
        Me.XtraTabPage2.Controls.Add(Me.txtCuentaDebe)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(685, 423)
        Me.XtraTabPage2.Text = "Proceso Patrimonial"
        '
        'btnConsultarCuentaHaber
        '
        Me.btnConsultarCuentaHaber.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnConsultarCuentaHaber.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConsultarCuentaHaber.Location = New System.Drawing.Point(596, 118)
        Me.btnConsultarCuentaHaber.Name = "btnConsultarCuentaHaber"
        Me.btnConsultarCuentaHaber.Size = New System.Drawing.Size(21, 21)
        Me.btnConsultarCuentaHaber.TabIndex = 27
        '
        'txtMontoHaber
        '
        Me.txtMontoHaber.EditValue = "0"
        Me.txtMontoHaber.Location = New System.Drawing.Point(53, 154)
        Me.txtMontoHaber.MenuManager = Me.RibbonControl
        Me.txtMontoHaber.Name = "txtMontoHaber"
        Me.txtMontoHaber.Properties.Mask.EditMask = "n2"
        Me.txtMontoHaber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoHaber.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoHaber.Size = New System.Drawing.Size(169, 20)
        Me.txtMontoHaber.TabIndex = 29
        '
        'btnConsultarCuentaDebe
        '
        Me.btnConsultarCuentaDebe.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnConsultarCuentaDebe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConsultarCuentaDebe.Location = New System.Drawing.Point(596, 32)
        Me.btnConsultarCuentaDebe.Name = "btnConsultarCuentaDebe"
        Me.btnConsultarCuentaDebe.Size = New System.Drawing.Size(21, 21)
        Me.btnConsultarCuentaDebe.TabIndex = 22
        '
        'SaimtLabel18
        '
        Me.SaimtLabel18.Location = New System.Drawing.Point(23, 18)
        Me.SaimtLabel18.Name = "SaimtLabel18"
        Me.SaimtLabel18.Size = New System.Drawing.Size(63, 13)
        Me.SaimtLabel18.TabIndex = 20
        Me.SaimtLabel18.Text = "Cuenta Debe"
        '
        'SaimtLabel16
        '
        Me.SaimtLabel16.Location = New System.Drawing.Point(22, 70)
        Me.SaimtLabel16.Name = "SaimtLabel16"
        Me.SaimtLabel16.Size = New System.Drawing.Size(25, 13)
        Me.SaimtLabel16.TabIndex = 23
        Me.SaimtLabel16.Text = "Debe"
        '
        'txtCuentaHaber
        '
        Me.txtCuentaHaber.Location = New System.Drawing.Point(20, 119)
        Me.txtCuentaHaber.MenuManager = Me.RibbonControl
        Me.txtCuentaHaber.Name = "txtCuentaHaber"
        Me.txtCuentaHaber.Size = New System.Drawing.Size(575, 20)
        Me.txtCuentaHaber.TabIndex = 26
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(23, 104)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel7.TabIndex = 25
        Me.SaimtLabel7.Text = "Cuenta Haber"
        '
        'txtMontoDebe
        '
        Me.txtMontoDebe.EditValue = "0"
        Me.txtMontoDebe.Location = New System.Drawing.Point(53, 67)
        Me.txtMontoDebe.MenuManager = Me.RibbonControl
        Me.txtMontoDebe.Name = "txtMontoDebe"
        Me.txtMontoDebe.Properties.Mask.EditMask = "n2"
        Me.txtMontoDebe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoDebe.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoDebe.Size = New System.Drawing.Size(169, 20)
        Me.txtMontoDebe.TabIndex = 24
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(23, 157)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(29, 13)
        Me.SaimtLabel6.TabIndex = 28
        Me.SaimtLabel6.Text = "Haber"
        '
        'txtCuentaDebe
        '
        Me.txtCuentaDebe.Location = New System.Drawing.Point(20, 33)
        Me.txtCuentaDebe.MenuManager = Me.RibbonControl
        Me.txtCuentaDebe.Name = "txtCuentaDebe"
        Me.txtCuentaDebe.Size = New System.Drawing.Size(575, 20)
        Me.txtCuentaDebe.TabIndex = 21
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.cboMeta)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel5)
        Me.XtraTabPage3.Controls.Add(Me.cboActProy)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel28)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(685, 423)
        Me.XtraTabPage3.Text = "Proceso Presupuesto"
        '
        'BackstageViewItemSeparator4
        '
        Me.BackstageViewItemSeparator4.Name = "BackstageViewItemSeparator4"
        '
        'BackstageViewItemSeparator5
        '
        Me.BackstageViewItemSeparator5.Name = "BackstageViewItemSeparator5"
        '
        'BackstageViewItemSeparator6
        '
        Me.BackstageViewItemSeparator6.Name = "BackstageViewItemSeparator6"
        '
        'BackstageViewTabItem4
        '
        Me.BackstageViewTabItem4.Caption = "Datos Adicionales"
        Me.BackstageViewTabItem4.Glyph = CType(resources.GetObject("BackstageViewTabItem4.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem4.Name = "BackstageViewTabItem4"
        Me.BackstageViewTabItem4.Selected = False
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(6, 3)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel2.TabIndex = 10
        Me.SaimtLabel2.Text = "Buscar por"
        '
        'cboCriterio
        '
        Me.cboCriterio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCriterio.EditValue = "Nro Pecosa"
        Me.cboCriterio.Location = New System.Drawing.Point(103, 19)
        Me.cboCriterio.MenuManager = Me.RibbonControl
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterio.Properties.Items.AddRange(New Object() {"Nro Pecosa", "Fecha Pecosa", "Area Pecosa"})
        Me.cboCriterio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCriterio.Size = New System.Drawing.Size(253, 20)
        Me.cboCriterio.TabIndex = 12
        Me.cboCriterio.Tag = "NotClear"
        '
        'ofdExaminarArchivos
        '
        Me.ofdExaminarArchivos.FileName = "OpenFileDialog1"
        '
        'cboBuscarArea
        '
        Me.cboBuscarArea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBuscarArea.Location = New System.Drawing.Point(3, 56)
        Me.cboBuscarArea.MenuManager = Me.RibbonControl
        Me.cboBuscarArea.Name = "cboBuscarArea"
        Me.cboBuscarArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarArea.Properties.NullText = ""
        Me.cboBuscarArea.Size = New System.Drawing.Size(353, 20)
        Me.cboBuscarArea.TabIndex = 13
        Me.cboBuscarArea.Tag = "NotClear"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(6, 41)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(55, 13)
        Me.SaimtLabel9.TabIndex = 41
        Me.SaimtLabel9.Text = "Grupo Area"
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboAnioCriterio)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel9)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboBuscarArea)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.grbListaClase)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboCriterio)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEditar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtTabs1)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnImprimir)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox3)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnNuevo)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnCancelar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnLimpiar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(1068, 721)
        Me.SaimtSplitContainerControl1.SplitterPosition = 362
        Me.SaimtSplitContainerControl1.TabIndex = 42
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'cboAnioCriterio
        '
        Me.cboAnioCriterio.Location = New System.Drawing.Point(3, 19)
        Me.cboAnioCriterio.MenuManager = Me.RibbonControl
        Me.cboAnioCriterio.Name = "cboAnioCriterio"
        Me.cboAnioCriterio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAnioCriterio.Properties.NullText = ""
        Me.cboAnioCriterio.Size = New System.Drawing.Size(94, 20)
        Me.cboAnioCriterio.TabIndex = 43
        Me.cboAnioCriterio.Tag = "NotClear"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(234, 650)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 43
        Me.btnEditar.Text = "Editar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImprimir.Location = New System.Drawing.Point(514, 650)
        Me.btnImprimir.LookAndFeel.SkinName = "Seven"
        Me.btnImprimir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 64)
        Me.btnImprimir.TabIndex = 46
        Me.btnImprimir.Text = "Guardar"
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Controls.Add(Me.chbAnulado)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtButton1)
        Me.SaimtGroupBox3.Controls.Add(Me.txtpersona)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox3.Controls.Add(Me.txtPecNro)
        Me.SaimtGroupBox3.Controls.Add(Me.txtPecosaId)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel19)
        Me.SaimtGroupBox3.Controls.Add(Me.meeObservacion)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox3.Controls.Add(Me.cboAreaDestino)
        Me.SaimtGroupBox3.Controls.Add(Me.dtpFechaPec)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel15)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(4, 12)
        Me.SaimtGroupBox3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(637, 174)
        Me.SaimtGroupBox3.TabIndex = 45
        Me.SaimtGroupBox3.Text = "Datos Pecosa"
        '
        'chbAnulado
        '
        Me.chbAnulado.Location = New System.Drawing.Point(529, 147)
        Me.chbAnulado.MenuManager = Me.RibbonControl
        Me.chbAnulado.Name = "chbAnulado"
        Me.chbAnulado.Properties.AutoWidth = True
        Me.chbAnulado.Properties.Caption = "Esta Anulado?"
        Me.chbAnulado.Size = New System.Drawing.Size(90, 19)
        Me.chbAnulado.TabIndex = 70
        '
        'SaimtButton1
        '
        Me.SaimtButton1.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.SaimtButton1.Location = New System.Drawing.Point(602, 78)
        Me.SaimtButton1.Name = "SaimtButton1"
        Me.SaimtButton1.Size = New System.Drawing.Size(24, 22)
        Me.SaimtButton1.TabIndex = 69
        '
        'txtpersona
        '
        Me.txtpersona.Location = New System.Drawing.Point(85, 79)
        Me.txtpersona.MenuManager = Me.RibbonControl
        Me.txtpersona.Name = "txtpersona"
        Me.txtpersona.Size = New System.Drawing.Size(516, 20)
        Me.txtpersona.TabIndex = 50
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(29, 82)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(49, 13)
        Me.SaimtLabel4.TabIndex = 49
        Me.SaimtLabel4.Text = "Solicitante"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(205, 29)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(81, 13)
        Me.SaimtLabel1.TabIndex = 48
        Me.SaimtLabel1.Text = "Cód. Informatico"
        '
        'txtPecNro
        '
        Me.txtPecNro.EditValue = ""
        Me.txtPecNro.Location = New System.Drawing.Point(85, 26)
        Me.txtPecNro.Name = "txtPecNro"
        Me.txtPecNro.Size = New System.Drawing.Size(89, 20)
        Me.txtPecNro.TabIndex = 17
        '
        'SaimtLabel19
        '
        Me.SaimtLabel19.Location = New System.Drawing.Point(18, 108)
        Me.SaimtLabel19.Name = "SaimtLabel19"
        Me.SaimtLabel19.Size = New System.Drawing.Size(60, 13)
        Me.SaimtLabel19.TabIndex = 47
        Me.SaimtLabel19.Text = "Observación"
        '
        'meeObservacion
        '
        Me.meeObservacion.Location = New System.Drawing.Point(84, 105)
        Me.meeObservacion.MenuManager = Me.RibbonControl
        Me.meeObservacion.Name = "meeObservacion"
        Me.meeObservacion.Size = New System.Drawing.Size(539, 36)
        Me.meeObservacion.TabIndex = 46
        Me.meeObservacion.UseOptimizedRendering = True
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(16, 55)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(62, 13)
        Me.SaimtLabel10.TabIndex = 20
        Me.SaimtLabel10.Text = "Área Destino"
        '
        'dtpFechaPec
        '
        Me.dtpFechaPec.EditValue = Nothing
        Me.dtpFechaPec.Location = New System.Drawing.Point(478, 26)
        Me.dtpFechaPec.Name = "dtpFechaPec"
        Me.dtpFechaPec.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaPec.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaPec.Size = New System.Drawing.Size(145, 20)
        Me.dtpFechaPec.TabIndex = 26
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(412, 29)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(60, 13)
        Me.SaimtLabel15.TabIndex = 25
        Me.SaimtLabel15.Text = "Fecha Salida"
        '
        'BackstageViewTabItem5
        '
        Me.BackstageViewTabItem5.Caption = "Archivos"
        Me.BackstageViewTabItem5.ContentControl = Me.BackstageViewClientControl4
        Me.BackstageViewTabItem5.Glyph = CType(resources.GetObject("BackstageViewTabItem5.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem5.Name = "BackstageViewTabItem5"
        Me.BackstageViewTabItem5.Selected = False
        '
        'BackstageViewClientControl4
        '
        Me.BackstageViewClientControl4.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl4.Name = "BackstageViewClientControl4"
        Me.BackstageViewClientControl4.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl4.TabIndex = 3
        '
        'frmPecosa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonImprimir = Me.btnImprimir
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(1068, 748)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.dgvListado = Me.dgvResultados
        Me.LookAndFeel.SkinName = "Seven"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmPecosa"
        Me.Tag = "btiClase"
        Me.Text = "Pecosa"
        Me.txtBuscarSaimt = Me.txtBuscarPor
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riLlevar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPecosaId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroOrd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAreaDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMeta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboActProy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbListaClase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbListaClase.ResumeLayout(False)
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtaño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbArticulos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtimporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpreciounit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnidadMed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtMontoHaber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaHaber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoDebe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaDebe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.cboCriterio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.cboAnioCriterio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        Me.SaimtGroupBox3.PerformLayout()
        CType(Me.chbAnulado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPecNro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meeObservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPec.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents grbListaClase As SaimtControles.SaimtGroupBox
    Friend WithEvents txtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents BackstageViewTabItem1 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewButtonItem1 As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
    Friend WithEvents BackstageViewItemSeparator2 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewItemSeparator3 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewItemSeparator4 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewItemSeparator5 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents txtPecosaId As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents cboCriterio As SaimtControles.SaimtComboBox
    Friend WithEvents ofdExaminarArchivos As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BackstageViewItemSeparator6 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem4 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents cboBuscarArea As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents BackstageViewTabItem5 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewClientControl4 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents dgvResultados As SaimtControles.SaimtDataGrid
    Friend WithEvents gvResultados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboAreaDestino As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents btnConsultarOC As SaimtControles.SaimtButton
    Friend WithEvents cboActProy As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents cboMeta As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel28 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtTabs1 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtMontoTotal As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroOrd As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaPec As SaimtControles.SaimtDateTimePicker
    Friend WithEvents btnConsultarCuentaHaber As SaimtControles.SaimtButton
    Friend WithEvents btnConsultarCuentaDebe As SaimtControles.SaimtButton
    Friend WithEvents txtMontoHaber As SaimtControles.SaimtTextBox
    Friend WithEvents txtCuentaHaber As SaimtControles.SaimtTextBox
    Friend WithEvents txtMontoDebe As SaimtControles.SaimtTextBox
    Friend WithEvents txtCuentaDebe As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel16 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel18 As SaimtControles.SaimtLabel
    Friend WithEvents dgvDetalleArticulos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvDetalleArticulos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pecDetId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents artId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel19 As SaimtControles.SaimtLabel
    Friend WithEvents meeObservacion As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents riProducto As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents riLlevar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gvDetalleOrdenCompra As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPecNro As SaimtControles.SaimtTextBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents cboUnidadMed As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents txtimporte As SaimtControles.SaimtTextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtpreciounit As SaimtControles.SaimtTextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcantidad As SaimtControles.SaimtSpinner
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRemover As SaimtControles.SaimtButton
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
    Friend WithEvents SaimtButton1 As SaimtControles.SaimtButton
    Friend WithEvents txtpersona As SaimtControles.SaimtTextBox
    Friend WithEvents cmbArticulos As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtaño As SaimtControles.SaimtTextBox
    Friend WithEvents pcDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents ordId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ordDetId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblmensaje As SaimtControles.SaimtLabel
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fbdExportar As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents chbAnulado As SaimtControles.SaimtCheckBox
    Friend WithEvents btnElimEditor As SaimtControles.SaimtButton
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboAnioCriterio As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit

End Class
