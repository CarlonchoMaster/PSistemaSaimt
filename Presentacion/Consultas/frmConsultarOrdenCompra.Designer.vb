<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarOrdenCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarOrdenCompra))
        Me.grbDatosClase = New SaimtControles.SaimtGroupBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.Codigo = New SaimtControles.SaimtLabel()
        Me.txtNumOrd = New SaimtControles.SaimtTextBox()
        Me.txtCodId = New SaimtControles.SaimtTextBox()
        Me.grbListaClase = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoOrdenCompra = New SaimtControles.SaimtDataGrid()
        Me.gvListadoOrdenCompra = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BackstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewButtonItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
        Me.BackstageViewItemSeparator2 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewItemSeparator3 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.SaimtTabs1 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgvDetalleArticulos = New SaimtControles.SaimtDataGrid()
        Me.gvDetalleArticulos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ordDetId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riProducto = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.tgUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ordDetCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ordDetCQuedan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ordDetPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ordDetImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ordLlevar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riLlevar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ordCanLlevar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BackstageViewItemSeparator4 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewItemSeparator5 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewItemSeparator6 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem4 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.ofdExaminarArchivos = New System.Windows.Forms.OpenFileDialog()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.cboCriterio = New SaimtControles.SaimtComboBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.btnSeleccionar = New SaimtControles.SaimtButton()
        Me.BackstageViewTabItem5 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewClientControl4 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosClase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosClase.SuspendLayout()
        CType(Me.txtNumOrd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbListaClase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbListaClase.SuspendLayout()
        CType(Me.dgvListadoOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dgvDetalleArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riLlevar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.cboCriterio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 523)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1007, 27)
        '
        'grbDatosClase
        '
        Me.grbDatosClase.Controls.Add(Me.SaimtLabel2)
        Me.grbDatosClase.Controls.Add(Me.Codigo)
        Me.grbDatosClase.Controls.Add(Me.txtNumOrd)
        Me.grbDatosClase.Controls.Add(Me.txtCodId)
        Me.grbDatosClase.Location = New System.Drawing.Point(4, 3)
        Me.grbDatosClase.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbDatosClase.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbDatosClase.Name = "grbDatosClase"
        Me.grbDatosClase.Size = New System.Drawing.Size(636, 58)
        Me.grbDatosClase.TabIndex = 2
        Me.grbDatosClase.Text = "Datos Orden de Compra"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(19, 34)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(100, 13)
        Me.SaimtLabel2.TabIndex = 16
        Me.SaimtLabel2.Text = "N° Orden de Compra"
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(342, 34)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(33, 13)
        Me.Codigo.TabIndex = 16
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Visible = False
        '
        'txtNumOrd
        '
        Me.txtNumOrd.EditValue = ""
        Me.txtNumOrd.Location = New System.Drawing.Point(125, 32)
        Me.txtNumOrd.Name = "txtNumOrd"
        Me.txtNumOrd.Size = New System.Drawing.Size(146, 20)
        Me.txtNumOrd.TabIndex = 17
        '
        'txtCodId
        '
        Me.txtCodId.EditValue = ""
        Me.txtCodId.Location = New System.Drawing.Point(381, 31)
        Me.txtCodId.Name = "txtCodId"
        Me.txtCodId.Size = New System.Drawing.Size(72, 20)
        Me.txtCodId.TabIndex = 17
        Me.txtCodId.Visible = False
        '
        'grbListaClase
        '
        Me.grbListaClase.Controls.Add(Me.dgvListadoOrdenCompra)
        Me.grbListaClase.Location = New System.Drawing.Point(1, 80)
        Me.grbListaClase.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbListaClase.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbListaClase.Name = "grbListaClase"
        Me.grbListaClase.Size = New System.Drawing.Size(351, 435)
        Me.grbListaClase.TabIndex = 3
        Me.grbListaClase.Text = "Resultado de Busqueda"
        '
        'dgvListadoOrdenCompra
        '
        Me.dgvListadoOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoOrdenCompra.Location = New System.Drawing.Point(2, 22)
        Me.dgvListadoOrdenCompra.MainView = Me.gvListadoOrdenCompra
        Me.dgvListadoOrdenCompra.MenuManager = Me.RibbonControl
        Me.dgvListadoOrdenCompra.Name = "dgvListadoOrdenCompra"
        Me.dgvListadoOrdenCompra.Size = New System.Drawing.Size(347, 411)
        Me.dgvListadoOrdenCompra.TabIndex = 1
        Me.dgvListadoOrdenCompra.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoOrdenCompra})
        '
        'gvListadoOrdenCompra
        '
        Me.gvListadoOrdenCompra.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn2, Me.GridColumn10, Me.GridColumn11, Me.GridColumn1})
        Me.gvListadoOrdenCompra.GridControl = Me.dgvListadoOrdenCompra
        Me.gvListadoOrdenCompra.Name = "gvListadoOrdenCompra"
        Me.gvListadoOrdenCompra.OptionsBehavior.Editable = False
        Me.gvListadoOrdenCompra.OptionsBehavior.ReadOnly = True
        Me.gvListadoOrdenCompra.OptionsCustomization.AllowSort = False
        Me.gvListadoOrdenCompra.OptionsView.ColumnAutoWidth = False
        Me.gvListadoOrdenCompra.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Cod. Interior"
        Me.GridColumn9.FieldName = "OrdId"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Producto"
        Me.GridColumn2.FieldName = "artDescripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nro. O/C."
        Me.GridColumn10.FieldName = "OrdNro"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Fecha O/C."
        Me.GridColumn11.FieldName = "OrdFechaDoc"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Stock"
        Me.GridColumn1.FieldName = "ordDetCQuedan"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
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
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtTabs1)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(4, 67)
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(636, 402)
        Me.SaimtGroupBox1.TabIndex = 9
        Me.SaimtGroupBox1.Text = "Datos Adicionales"
        '
        'SaimtTabs1
        '
        Me.SaimtTabs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtTabs1.Location = New System.Drawing.Point(2, 28)
        Me.SaimtTabs1.Name = "SaimtTabs1"
        Me.SaimtTabs1.SelectedTabPage = Me.XtraTabPage1
        Me.SaimtTabs1.Size = New System.Drawing.Size(632, 372)
        Me.SaimtTabs1.TabIndex = 15
        Me.SaimtTabs1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.dgvDetalleArticulos)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(626, 346)
        Me.XtraTabPage1.Text = "Productos"
        '
        'dgvDetalleArticulos
        '
        Me.dgvDetalleArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalleArticulos.Location = New System.Drawing.Point(0, 0)
        Me.dgvDetalleArticulos.MainView = Me.gvDetalleArticulos
        Me.dgvDetalleArticulos.MenuManager = Me.RibbonControl
        Me.dgvDetalleArticulos.Name = "dgvDetalleArticulos"
        Me.dgvDetalleArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riProducto, Me.riLlevar})
        Me.dgvDetalleArticulos.Size = New System.Drawing.Size(626, 346)
        Me.dgvDetalleArticulos.TabIndex = 56
        Me.dgvDetalleArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalleArticulos})
        '
        'gvDetalleArticulos
        '
        Me.gvDetalleArticulos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ordDetId, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.tgUM, Me.ordDetCantidad, Me.ordDetCQuedan, Me.ordDetPrecio, Me.ordDetImporte, Me.ordLlevar, Me.ordCanLlevar})
        Me.gvDetalleArticulos.GridControl = Me.dgvDetalleArticulos
        Me.gvDetalleArticulos.Name = "gvDetalleArticulos"
        Me.gvDetalleArticulos.OptionsView.ColumnAutoWidth = False
        Me.gvDetalleArticulos.OptionsView.ShowGroupPanel = False
        '
        'ordDetId
        '
        Me.ordDetId.Caption = "ordDetId"
        Me.ordDetId.FieldName = "ordDetId"
        Me.ordDetId.Name = "ordDetId"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "artId"
        Me.GridColumn17.FieldName = "artId"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "tgUMId"
        Me.GridColumn18.FieldName = "tgUMId"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Producto"
        Me.GridColumn19.ColumnEdit = Me.riProducto
        Me.GridColumn19.FieldName = "artDescripcion"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 0
        '
        'riProducto
        '
        Me.riProducto.AutoHeight = False
        Me.riProducto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riProducto.Name = "riProducto"
        Me.riProducto.ShowIcon = False
        '
        'tgUM
        '
        Me.tgUM.Caption = "Unidad Medida"
        Me.tgUM.FieldName = "tgUM"
        Me.tgUM.Name = "tgUM"
        Me.tgUM.Visible = True
        Me.tgUM.VisibleIndex = 1
        '
        'ordDetCantidad
        '
        Me.ordDetCantidad.Caption = "Cantidad"
        Me.ordDetCantidad.FieldName = "ordDetCantidad"
        Me.ordDetCantidad.Name = "ordDetCantidad"
        Me.ordDetCantidad.Visible = True
        Me.ordDetCantidad.VisibleIndex = 2
        '
        'ordDetCQuedan
        '
        Me.ordDetCQuedan.Caption = "Stock"
        Me.ordDetCQuedan.FieldName = "ordDetCQuedan"
        Me.ordDetCQuedan.Name = "ordDetCQuedan"
        Me.ordDetCQuedan.Visible = True
        Me.ordDetCQuedan.VisibleIndex = 3
        '
        'ordDetPrecio
        '
        Me.ordDetPrecio.Caption = "Precio Unitario"
        Me.ordDetPrecio.FieldName = "ordDetPrecio"
        Me.ordDetPrecio.Name = "ordDetPrecio"
        Me.ordDetPrecio.Visible = True
        Me.ordDetPrecio.VisibleIndex = 4
        '
        'ordDetImporte
        '
        Me.ordDetImporte.Caption = "Importe (S/.)"
        Me.ordDetImporte.FieldName = "ordDetImporte"
        Me.ordDetImporte.Name = "ordDetImporte"
        Me.ordDetImporte.Visible = True
        Me.ordDetImporte.VisibleIndex = 5
        '
        'ordLlevar
        '
        Me.ordLlevar.Caption = "Llevar"
        Me.ordLlevar.ColumnEdit = Me.riLlevar
        Me.ordLlevar.FieldName = "ordLleva"
        Me.ordLlevar.Name = "ordLlevar"
        Me.ordLlevar.Visible = True
        Me.ordLlevar.VisibleIndex = 6
        '
        'riLlevar
        '
        Me.riLlevar.AutoHeight = False
        Me.riLlevar.Name = "riLlevar"
        '
        'ordCanLlevar
        '
        Me.ordCanLlevar.Caption = "Cantidad Llevar"
        Me.ordCanLlevar.FieldName = "ordCanLleva"
        Me.ordCanLlevar.Name = "ordCanLlevar"
        Me.ordCanLlevar.Visible = True
        Me.ordCanLlevar.VisibleIndex = 7
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
        'ofdExaminarArchivos
        '
        Me.ofdExaminarArchivos.FileName = "OpenFileDialog1"
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboCriterio)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.grbListaClase)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnSeleccionar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.grbDatosClase)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(1007, 523)
        Me.SaimtSplitContainerControl1.SplitterPosition = 358
        Me.SaimtSplitContainerControl1.TabIndex = 42
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'cboCriterio
        '
        Me.cboCriterio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCriterio.EditValue = "Articulo"
        Me.cboCriterio.Location = New System.Drawing.Point(3, 28)
        Me.cboCriterio.MenuManager = Me.RibbonControl
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterio.Properties.Items.AddRange(New Object() {"Articulo", "Nro. O/C", "Proveedor", "Fecha Documento"})
        Me.cboCriterio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCriterio.Size = New System.Drawing.Size(349, 20)
        Me.cboCriterio.TabIndex = 12
        Me.cboCriterio.Tag = "0"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(3, 9)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel1.TabIndex = 11
        Me.SaimtLabel1.Text = "Buscar por"
        '
        'txtBuscarPor
        '
        Me.txtBuscarPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPor.Location = New System.Drawing.Point(3, 54)
        Me.txtBuscarPor.MenuManager = Me.RibbonControl
        Me.txtBuscarPor.Name = "txtBuscarPor"
        Me.txtBuscarPor.Size = New System.Drawing.Size(349, 20)
        Me.txtBuscarPor.TabIndex = 14
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(285, 487)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 28)
        Me.btnSeleccionar.TabIndex = 10
        Me.btnSeleccionar.Text = "Seleccionar"
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
        Me.BackstageViewClientControl4.Name = "BackstageViewClientControl4"
        Me.BackstageViewClientControl4.TabIndex = 3
        '
        'frmConsultarOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1007, 550)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmConsultarOrdenCompra"
        Me.PuedeBuscar = True
        Me.PuedeConfirmar = True
        Me.PuedeCrear = True
        Me.PuedeDesvincular = True
        Me.PuedeEditar = True
        Me.PuedeEliminar = True
        Me.PuedeEnviar = True
        Me.PuedeExportar = True
        Me.PuedeImportar = True
        Me.PuedeImprimir = True
        Me.PuedeVerDetalle = True
        Me.PuedeVincular = True
        Me.PuedeVisualizar = True
        Me.Tag = "btiStockAlmacen"
        Me.Text = "Consultar Orden Compra"
        Me.txtBuscarSaimt = Me.txtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosClase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosClase.ResumeLayout(False)
        Me.grbDatosClase.PerformLayout()
        CType(Me.txtNumOrd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbListaClase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbListaClase.ResumeLayout(False)
        CType(Me.dgvListadoOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.dgvDetalleArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riLlevar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.cboCriterio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDatosClase As SaimtControles.SaimtGroupBox
    Friend WithEvents grbListaClase As SaimtControles.SaimtGroupBox
    Friend WithEvents BackstageViewTabItem1 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewButtonItem1 As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
    Friend WithEvents BackstageViewItemSeparator2 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewItemSeparator3 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents BackstageViewItemSeparator4 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewItemSeparator5 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents ofdExaminarArchivos As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BackstageViewItemSeparator6 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem4 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents BackstageViewTabItem5 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewClientControl4 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents SaimtTabs1 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Codigo As SaimtControles.SaimtLabel
    Friend WithEvents txtCodId As SaimtControles.SaimtTextBox
    Friend WithEvents dgvDetalleArticulos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvDetalleArticulos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ordDetId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riProducto As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents tgUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ordDetCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ordDetPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ordDetImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ordLlevar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riLlevar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ordCanLlevar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboCriterio As SaimtControles.SaimtComboBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents dgvListadoOrdenCompra As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoOrdenCompra As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtNumOrd As SaimtControles.SaimtTextBox
    Friend WithEvents btnSeleccionar As SaimtControles.SaimtButton
    Friend WithEvents ordDetCQuedan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
