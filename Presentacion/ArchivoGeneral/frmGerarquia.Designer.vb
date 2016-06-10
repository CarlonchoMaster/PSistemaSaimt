<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerarquia
    Inherits Presentacion.frmMantenimientos

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerarquia))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarLargeButtonItem1 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.btnNuevo = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarLargeButtonItem3 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarLargeButtonItem4 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarLargeButtonItem5 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.BarLargeButtonItem6 = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.tlJerarquia = New System.Windows.Forms.TreeView()
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mbtiNuevoExpediente = New System.Windows.Forms.ToolStripMenuItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem3 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem2 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.IconosArchivo = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconosArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 719)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1080, 27)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarEditItem1, Me.BarLargeButtonItem1, Me.btnNuevo, Me.BarLargeButtonItem3, Me.BarLargeButtonItem4, Me.BarLargeButtonItem5, Me.BarLargeButtonItem6, Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 21
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNuevo, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarLargeButtonItem6)})
        Me.Bar1.Text = "Herramientas"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem1.Id = 1
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 300
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarLargeButtonItem1
        '
        Me.BarLargeButtonItem1.Caption = "Buscar"
        Me.BarLargeButtonItem1.Glyph = CType(resources.GetObject("BarLargeButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarLargeButtonItem1.Id = 2
        Me.BarLargeButtonItem1.LargeGlyph = CType(resources.GetObject("BarLargeButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarLargeButtonItem1.Name = "BarLargeButtonItem1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Caption = "Nueva"
        Me.btnNuevo.DropDownControl = Me.PopupMenu1
        Me.btnNuevo.Glyph = CType(resources.GetObject("btnNuevo.Glyph"), System.Drawing.Image)
        Me.btnNuevo.Id = 14
        Me.btnNuevo.LargeGlyph = CType(resources.GetObject("btnNuevo.LargeGlyph"), System.Drawing.Image)
        Me.btnNuevo.Name = "btnNuevo"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Nueva Carpeta"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 19
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Nuevo Expediente"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 20
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarLargeButtonItem3
        '
        Me.BarLargeButtonItem3.Caption = "Modificar"
        Me.BarLargeButtonItem3.Glyph = CType(resources.GetObject("BarLargeButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarLargeButtonItem3.Id = 15
        Me.BarLargeButtonItem3.LargeGlyph = CType(resources.GetObject("BarLargeButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarLargeButtonItem3.Name = "BarLargeButtonItem3"
        '
        'BarLargeButtonItem4
        '
        Me.BarLargeButtonItem4.Caption = "Eliminar"
        Me.BarLargeButtonItem4.Glyph = CType(resources.GetObject("BarLargeButtonItem4.Glyph"), System.Drawing.Image)
        Me.BarLargeButtonItem4.Id = 16
        Me.BarLargeButtonItem4.LargeGlyph = CType(resources.GetObject("BarLargeButtonItem4.LargeGlyph"), System.Drawing.Image)
        Me.BarLargeButtonItem4.Name = "BarLargeButtonItem4"
        '
        'BarLargeButtonItem5
        '
        Me.BarLargeButtonItem5.Caption = "Refrescar"
        Me.BarLargeButtonItem5.Glyph = CType(resources.GetObject("BarLargeButtonItem5.Glyph"), System.Drawing.Image)
        Me.BarLargeButtonItem5.Id = 17
        Me.BarLargeButtonItem5.LargeGlyph = CType(resources.GetObject("BarLargeButtonItem5.LargeGlyph"), System.Drawing.Image)
        Me.BarLargeButtonItem5.Name = "BarLargeButtonItem5"
        '
        'BarLargeButtonItem6
        '
        Me.BarLargeButtonItem6.Caption = "Visualizar"
        Me.BarLargeButtonItem6.Glyph = CType(resources.GetObject("BarLargeButtonItem6.Glyph"), System.Drawing.Image)
        Me.BarLargeButtonItem6.Id = 18
        Me.BarLargeButtonItem6.LargeGlyph = CType(resources.GetObject("BarLargeButtonItem6.LargeGlyph"), System.Drawing.Image)
        Me.BarLargeButtonItem6.Name = "BarLargeButtonItem6"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1080, 65)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 746)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1080, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 65)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 681)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1080, 65)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 681)
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.tlJerarquia)
        Me.LayoutControl1.Controls.Add(Me.MemoEdit2)
        Me.LayoutControl1.Controls.Add(Me.MemoEdit1)
        Me.LayoutControl1.Controls.Add(Me.GroupControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 65)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(540, 380, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1080, 681)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'tlJerarquia
        '
        Me.tlJerarquia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlJerarquia.Location = New System.Drawing.Point(7, 7)
        Me.tlJerarquia.Name = "tlJerarquia"
        Me.tlJerarquia.ShowLines = False
        Me.tlJerarquia.Size = New System.Drawing.Size(563, 544)
        Me.tlJerarquia.TabIndex = 64
        '
        'MemoEdit2
        '
        Me.MemoEdit2.Location = New System.Drawing.Point(505, 576)
        Me.MemoEdit2.MenuManager = Me.BarManager1
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Size = New System.Drawing.Size(568, 98)
        Me.MemoEdit2.StyleController = Me.LayoutControl1
        Me.MemoEdit2.TabIndex = 7
        Me.MemoEdit2.UseOptimizedRendering = True
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(7, 576)
        Me.MemoEdit1.MenuManager = Me.BarManager1
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(489, 98)
        Me.MemoEdit1.StyleController = Me.LayoutControl1
        Me.MemoEdit1.TabIndex = 6
        Me.MemoEdit1.UseOptimizedRendering = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.TreeList1)
        Me.GroupControl1.Location = New System.Drawing.Point(579, 7)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(494, 544)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Expedientes"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(445, 534)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(117, 25)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "LabelControl1"
        Me.LabelControl1.Visible = False
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn2})
        Me.TreeList1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeList1.Location = New System.Drawing.Point(2, 21)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsView.ShowColumns = False
        Me.TreeList1.Size = New System.Drawing.Size(490, 521)
        Me.TreeList1.TabIndex = 0
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "TreeListColumn2"
        Me.TreeListColumn2.FieldName = "TreeListColumn2"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.Visible = True
        Me.TreeListColumn2.VisibleIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mbtiNuevoExpediente})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'mbtiNuevoExpediente
        '
        Me.mbtiNuevoExpediente.Name = "mbtiNuevoExpediente"
        Me.mbtiNuevoExpediente.Size = New System.Drawing.Size(152, 22)
        Me.mbtiNuevoExpediente.Text = "&Nuevo"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.SplitterItem1, Me.LayoutControlItem3, Me.SplitterItem3, Me.LayoutControlItem4, Me.SplitterItem2, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1080, 681)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GroupControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(572, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(498, 548)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(567, 0)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(5, 548)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.MemoEdit1
        Me.LayoutControlItem3.CustomizationFormText = "Descripción"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 553)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(493, 118)
        Me.LayoutControlItem3.Text = "Descripción"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(54, 13)
        '
        'SplitterItem3
        '
        Me.SplitterItem3.AllowHotTrack = True
        Me.SplitterItem3.CustomizationFormText = "SplitterItem3"
        Me.SplitterItem3.Location = New System.Drawing.Point(493, 553)
        Me.SplitterItem3.Name = "SplitterItem3"
        Me.SplitterItem3.Size = New System.Drawing.Size(5, 118)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.MemoEdit2
        Me.LayoutControlItem4.CustomizationFormText = "Resumen"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(498, 553)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(572, 118)
        Me.LayoutControlItem4.Text = "Resumen"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(54, 13)
        '
        'SplitterItem2
        '
        Me.SplitterItem2.AllowHotTrack = True
        Me.SplitterItem2.CustomizationFormText = "SplitterItem2"
        Me.SplitterItem2.Location = New System.Drawing.Point(0, 548)
        Me.SplitterItem2.Name = "SplitterItem2"
        Me.SplitterItem2.Size = New System.Drawing.Size(1070, 5)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.tlJerarquia
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(567, 548)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'IconosArchivo
        '
        Me.IconosArchivo.ImageStream = CType(resources.GetObject("IconosArchivo.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.IconosArchivo.Images.SetKeyName(0, "10.ico")
        Me.IconosArchivo.Images.SetKeyName(1, "11.ico")
        Me.IconosArchivo.Images.SetKeyName(2, "12.ico")
        Me.IconosArchivo.Images.SetKeyName(3, "13.ico")
        Me.IconosArchivo.Images.SetKeyName(4, "20.ico")
        Me.IconosArchivo.Images.SetKeyName(5, "21.ico")
        Me.IconosArchivo.Images.SetKeyName(6, "22.ico")
        Me.IconosArchivo.Images.SetKeyName(7, "30.ico")
        Me.IconosArchivo.Images.SetKeyName(8, "31.ico")
        Me.IconosArchivo.Images.SetKeyName(9, "32.ico")
        Me.IconosArchivo.Images.SetKeyName(10, "40.ico")
        Me.IconosArchivo.Images.SetKeyName(11, "41.ico")
        Me.IconosArchivo.Images.SetKeyName(12, "42.ico")
        Me.IconosArchivo.Images.SetKeyName(13, "50.ico")
        Me.IconosArchivo.Images.SetKeyName(14, "51.ico")
        Me.IconosArchivo.Images.SetKeyName(15, "52.ico")
        Me.IconosArchivo.Images.SetKeyName(16, "53.ico")
        Me.IconosArchivo.Images.SetKeyName(17, "60.ico")
        Me.IconosArchivo.Images.SetKeyName(18, "61.ico")
        Me.IconosArchivo.Images.SetKeyName(19, "62.ico")
        Me.IconosArchivo.Images.SetKeyName(20, "70.ico")
        Me.IconosArchivo.Images.SetKeyName(21, "71.ico")
        Me.IconosArchivo.Images.SetKeyName(22, "72.ico")
        Me.IconosArchivo.Images.SetKeyName(23, "73.ico")
        Me.IconosArchivo.Images.SetKeyName(24, "80.ico")
        Me.IconosArchivo.Images.SetKeyName(25, "81.ico")
        Me.IconosArchivo.Images.SetKeyName(26, "82.ico")
        Me.IconosArchivo.Images.SetKeyName(27, "90.ico")
        Me.IconosArchivo.Images.SetKeyName(28, "91.ico")
        Me.IconosArchivo.Images.SetKeyName(29, "92.ico")
        Me.IconosArchivo.Images.SetKeyName(30, "93.ico")
        Me.IconosArchivo.Images.SetKeyName(31, "100.ico")
        Me.IconosArchivo.Images.SetKeyName(32, "101.ico")
        Me.IconosArchivo.Images.SetKeyName(33, "102.ico")
        Me.IconosArchivo.Images.SetKeyName(34, "110.ico")
        Me.IconosArchivo.Images.SetKeyName(35, "111.ico")
        Me.IconosArchivo.Images.SetKeyName(36, "112.ico")
        Me.IconosArchivo.Images.SetKeyName(37, "113.ico")
        Me.IconosArchivo.Images.SetKeyName(38, "120.ico")
        Me.IconosArchivo.Images.SetKeyName(39, "121.ico")
        Me.IconosArchivo.Images.SetKeyName(40, "122.ico")
        Me.IconosArchivo.Images.SetKeyName(41, "130.png")
        Me.IconosArchivo.Images.SetKeyName(42, "140.png")
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmGerarquia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 746)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmGerarquia"
        Me.Text = "frmGerarquia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconosArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarLargeButtonItem1 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnNuevo As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarLargeButtonItem3 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarLargeButtonItem4 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarLargeButtonItem5 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarLargeButtonItem6 As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem3 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem2 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IconosArchivo As DevExpress.Utils.ImageCollection
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tlJerarquia As System.Windows.Forms.TreeView
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mbtiNuevoExpediente As System.Windows.Forms.ToolStripMenuItem
End Class
