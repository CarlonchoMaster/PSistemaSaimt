<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGaleriaInmueble
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGaleriaInmueble))
        Me.BackstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.SplitContainerControl4 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.dgvArchivos = New SaimtControles.SaimtDataGrid()
        Me.gvArchivos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rihNombreVistaPreview = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rihdescargar2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rihTipoArchivoDescargar = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEditVistaPrevia = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEditImprimir = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.visorPDF = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.PdfCommandBar1 = New DevExpress.XtraPdfViewer.Bars.PdfCommandBar()
        Me.PdfFileOpenBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
        Me.PdfFilePrintBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem()
        Me.PdfPreviousPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
        Me.PdfNextPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
        Me.PdfFindTextBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem()
        Me.PdfZoomOutBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
        Me.PdfZoomInBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
        Me.PdfExactZoomListBarSubItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
        Me.PdfZoom10CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
        Me.PdfZoom25CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
        Me.PdfZoom50CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
        Me.PdfZoom75CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
        Me.PdfZoom100CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
        Me.PdfZoom125CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
        Me.PdfZoom150CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
        Me.PdfZoom200CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
        Me.PdfZoom400CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
        Me.PdfZoom500CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
        Me.PdfSetActualSizeZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem()
        Me.PdfSetPageLevelZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem()
        Me.PdfSetFitWidthZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem()
        Me.PdfSetFitVisibleZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem()
        Me.fgvExcel = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.recWord = New DevExpress.XtraRichEdit.RichEditControl()
        Me.BackstageViewItemSeparator2 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem2 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewClientControl2 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.dgvGaleriaImagenes = New SaimtControles.SaimtDataGrid()
        Me.lvGaleriaImagenes = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colFoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemPictureEditFoto = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colNombre = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1_5 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pbFotoInmueble = New SaimtControles.SaimtPictureBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblzoom = New SaimtControles.SaimtLabel()
        Me.ZoomTrackBarControl1 = New DevExpress.XtraEditors.ZoomTrackBarControl()
        Me.BackstageViewItemSeparator3 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem3 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewClientControl3 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.dgvMultimedia = New SaimtControles.SaimtDataGrid()
        Me.lvmultimedia = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.lvcfoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_LayoutViewColumn1_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvcnombre = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn2_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvcdescripcion = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn3_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvcopcion1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.rihdescargarvid = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.layoutViewField_LayoutViewColumn1_2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvcopcion2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.rihvistaprevia = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.layoutViewField_LayoutViewColumn2_2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvcextension = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1_3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvcarchivo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn2_3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvctipovid = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1_4 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn2_4 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BackstageViewItemSeparator4 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.sfddescargar = New System.Windows.Forms.SaveFileDialog()
        Me.imagenes128 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RepositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
        Me.RepositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
        Me.RepositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
        Me.RepositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
        Me.RepositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
        Me.CommonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
        Me.FileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
        Me.ClipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
        Me.HomeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
        Me.FontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
        Me.ParagraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
        Me.StylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
        Me.EditingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
        Me.PagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
        Me.InsertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
        Me.TablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
        Me.IllustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
        Me.LinksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
        Me.HeaderFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
        Me.SymbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
        Me.PageSetupRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup()
        Me.PageLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage()
        Me.DocumentViewsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup()
        Me.ViewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ViewRibbonPage()
        Me.ShowRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup()
        Me.ZoomRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup()
        Me.TableStylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup()
        Me.TableDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableDesignRibbonPage()
        Me.TableDrawBordersRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup()
        Me.TableToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory()
        Me.TableLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage()
        Me.TableTableRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup()
        Me.TableRowsAndColumnsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup()
        Me.TableMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup()
        Me.TableCellSizeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup()
        Me.TableAlignmentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup()
        Me.BackstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        Me.PdfBarController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarController()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewClientControl1.SuspendLayout()
        CType(Me.SplitContainerControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl4.SuspendLayout()
        CType(Me.dgvArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rihNombreVistaPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rihdescargar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rihTipoArchivoDescargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEditVistaPrevia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEditImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.visorPDF.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewClientControl2.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.dgvGaleriaImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvGaleriaImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEditFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFotoInmueble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ZoomTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewClientControl3.SuspendLayout()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.dgvMultimedia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvmultimedia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn3_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rihdescargarvid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rihvistaprevia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenes128, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewControl1.SuspendLayout()
        CType(Me.PdfBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 584)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1156, 27)
        '
        'BackstageViewItemSeparator1
        '
        Me.BackstageViewItemSeparator1.Name = "BackstageViewItemSeparator1"
        '
        'BackstageViewTabItem1
        '
        Me.BackstageViewTabItem1.Caption = "Archivos"
        Me.BackstageViewTabItem1.ContentControl = Me.BackstageViewClientControl1
        Me.BackstageViewTabItem1.Glyph = Global.Presentacion.My.Resources.Resources.arch_contrato16
        Me.BackstageViewTabItem1.Name = "BackstageViewTabItem1"
        Me.BackstageViewTabItem1.Selected = True
        '
        'BackstageViewClientControl1
        '
        Me.BackstageViewClientControl1.Controls.Add(Me.SplitContainerControl4)
        Me.BackstageViewClientControl1.Location = New System.Drawing.Point(132, 0)
        Me.BackstageViewClientControl1.Name = "BackstageViewClientControl1"
        Me.BackstageViewClientControl1.Size = New System.Drawing.Size(1024, 584)
        Me.BackstageViewClientControl1.TabIndex = 0
        '
        'SplitContainerControl4
        '
        Me.SplitContainerControl4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainerControl4.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl4.Name = "SplitContainerControl4"
        Me.SplitContainerControl4.Panel1.Controls.Add(Me.dgvArchivos)
        Me.SplitContainerControl4.Panel1.Text = "Panel1"
        Me.SplitContainerControl4.Panel2.Controls.Add(Me.visorPDF)
        Me.SplitContainerControl4.Panel2.Controls.Add(Me.fgvExcel)
        Me.SplitContainerControl4.Panel2.Controls.Add(Me.recWord)
        Me.SplitContainerControl4.Panel2.Text = "Panel2"
        Me.SplitContainerControl4.Size = New System.Drawing.Size(1024, 584)
        Me.SplitContainerControl4.SplitterPosition = 402
        Me.SplitContainerControl4.TabIndex = 0
        Me.SplitContainerControl4.Text = "SplitContainerControl4"
        '
        'dgvArchivos
        '
        Me.dgvArchivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvArchivos.Location = New System.Drawing.Point(0, 0)
        Me.dgvArchivos.MainView = Me.gvArchivos
        Me.dgvArchivos.MenuManager = Me.RibbonControl
        Me.dgvArchivos.Name = "dgvArchivos"
        Me.dgvArchivos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rihdescargar2, Me.RepositoryItemHyperLinkEditVistaPrevia, Me.RepositoryItemHyperLinkEditImprimir, Me.RepositoryItemMemoExEdit1, Me.rihNombreVistaPreview, Me.rihTipoArchivoDescargar, Me.RepositoryItemCheckEdit1})
        Me.dgvArchivos.Size = New System.Drawing.Size(402, 584)
        Me.dgvArchivos.TabIndex = 0
        Me.dgvArchivos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArchivos, Me.GridView3})
        '
        'gvArchivos
        '
        Me.gvArchivos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn1, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.gvArchivos.GridControl = Me.dgvArchivos
        Me.gvArchivos.Name = "gvArchivos"
        Me.gvArchivos.OptionsView.ColumnAutoWidth = False
        Me.gvArchivos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Archivo"
        Me.GridColumn2.FieldName = "Archivo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Nombre"
        Me.GridColumn3.ColumnEdit = Me.rihNombreVistaPreview
        Me.GridColumn3.FieldName = "Nombre"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 101
        '
        'rihNombreVistaPreview
        '
        Me.rihNombreVistaPreview.AutoHeight = False
        Me.rihNombreVistaPreview.Name = "rihNombreVistaPreview"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Descripcion"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn4.FieldName = "Descripcion"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Width = 152
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Acción"
        Me.GridColumn1.ColumnEdit = Me.rihdescargar2
        Me.GridColumn1.FieldName = "Tipo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 94
        '
        'rihdescargar2
        '
        Me.rihdescargar2.AutoHeight = False
        Me.rihdescargar2.Caption = "Descargar"
        Me.rihdescargar2.Name = "rihdescargar2"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Extensión"
        Me.GridColumn5.FieldName = "Extension"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Width = 55
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tipo Archivo"
        Me.GridColumn6.ColumnEdit = Me.rihTipoArchivoDescargar
        Me.GridColumn6.FieldName = "Tipo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 66
        '
        'rihTipoArchivoDescargar
        '
        Me.rihTipoArchivoDescargar.AutoHeight = False
        Me.rihTipoArchivoDescargar.Name = "rihTipoArchivoDescargar"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Vista Previa"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemHyperLinkEditVistaPrevia
        Me.GridColumn7.FieldName = "VistaPrevia"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'RepositoryItemHyperLinkEditVistaPrevia
        '
        Me.RepositoryItemHyperLinkEditVistaPrevia.AutoHeight = False
        Me.RepositoryItemHyperLinkEditVistaPrevia.Caption = "Vista Previa"
        Me.RepositoryItemHyperLinkEditVistaPrevia.Name = "RepositoryItemHyperLinkEditVistaPrevia"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Imprimir"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemHyperLinkEditImprimir
        Me.GridColumn8.FieldName = "Imprirmir"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'RepositoryItemHyperLinkEditImprimir
        '
        Me.RepositoryItemHyperLinkEditImprimir.AutoHeight = False
        Me.RepositoryItemHyperLinkEditImprimir.Name = "RepositoryItemHyperLinkEditImprimir"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "GridColumn9"
        Me.GridColumn9.FieldName = "Id"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn10.FieldName = "Activo"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        Me.GridColumn10.Width = 44
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.dgvArchivos
        Me.GridView3.Name = "GridView3"
        '
        'visorPDF
        '
        Me.visorPDF.Controls.Add(Me.barDockControlLeft)
        Me.visorPDF.Controls.Add(Me.barDockControlRight)
        Me.visorPDF.Controls.Add(Me.barDockControlBottom)
        Me.visorPDF.Controls.Add(Me.barDockControlTop)
        Me.visorPDF.Location = New System.Drawing.Point(410, 121)
        Me.visorPDF.MenuManager = Me.BarManager1
        Me.visorPDF.Name = "visorPDF"
        Me.visorPDF.Size = New System.Drawing.Size(178, 393)
        Me.visorPDF.TabIndex = 3
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 362)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(178, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 362)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 362)
        Me.barDockControlBottom.Size = New System.Drawing.Size(178, 31)
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(178, 0)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.PdfCommandBar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me.visorPDF
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.PdfFileOpenBarItem1, Me.PdfFilePrintBarItem1, Me.PdfPreviousPageBarItem1, Me.PdfNextPageBarItem1, Me.PdfFindTextBarItem1, Me.PdfZoomOutBarItem1, Me.PdfZoomInBarItem1, Me.PdfExactZoomListBarSubItem1, Me.PdfZoom10CheckItem1, Me.PdfZoom25CheckItem1, Me.PdfZoom50CheckItem1, Me.PdfZoom75CheckItem1, Me.PdfZoom100CheckItem1, Me.PdfZoom125CheckItem1, Me.PdfZoom150CheckItem1, Me.PdfZoom200CheckItem1, Me.PdfZoom400CheckItem1, Me.PdfZoom500CheckItem1, Me.PdfSetActualSizeZoomModeCheckItem1, Me.PdfSetPageLevelZoomModeCheckItem1, Me.PdfSetFitWidthZoomModeCheckItem1, Me.PdfSetFitVisibleZoomModeCheckItem1})
        Me.BarManager1.MaxItemId = 22
        '
        'PdfCommandBar1
        '
        Me.PdfCommandBar1.Control = Me.visorPDF
        Me.PdfCommandBar1.DockCol = 0
        Me.PdfCommandBar1.DockRow = 0
        Me.PdfCommandBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.PdfCommandBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PdfFileOpenBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfFilePrintBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfPreviousPageBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfNextPageBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfFindTextBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoomOutBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoomInBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfExactZoomListBarSubItem1)})
        '
        'PdfFileOpenBarItem1
        '
        Me.PdfFileOpenBarItem1.Id = 0
        Me.PdfFileOpenBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
        Me.PdfFileOpenBarItem1.Name = "PdfFileOpenBarItem1"
        Me.PdfFileOpenBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'PdfFilePrintBarItem1
        '
        Me.PdfFilePrintBarItem1.Id = 1
        Me.PdfFilePrintBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.PdfFilePrintBarItem1.Name = "PdfFilePrintBarItem1"
        '
        'PdfPreviousPageBarItem1
        '
        Me.PdfPreviousPageBarItem1.Id = 2
        Me.PdfPreviousPageBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.PageUp)
        Me.PdfPreviousPageBarItem1.Name = "PdfPreviousPageBarItem1"
        '
        'PdfNextPageBarItem1
        '
        Me.PdfNextPageBarItem1.Id = 3
        Me.PdfNextPageBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.PageDown)
        Me.PdfNextPageBarItem1.Name = "PdfNextPageBarItem1"
        '
        'PdfFindTextBarItem1
        '
        Me.PdfFindTextBarItem1.Id = 4
        Me.PdfFindTextBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.PdfFindTextBarItem1.Name = "PdfFindTextBarItem1"
        '
        'PdfZoomOutBarItem1
        '
        Me.PdfZoomOutBarItem1.Id = 5
        Me.PdfZoomOutBarItem1.Name = "PdfZoomOutBarItem1"
        '
        'PdfZoomInBarItem1
        '
        Me.PdfZoomInBarItem1.Id = 6
        Me.PdfZoomInBarItem1.Name = "PdfZoomInBarItem1"
        '
        'PdfExactZoomListBarSubItem1
        '
        Me.PdfExactZoomListBarSubItem1.Id = 7
        Me.PdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom10CheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom25CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom50CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom75CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom100CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom125CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom150CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom200CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom400CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom500CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetActualSizeZoomModeCheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetPageLevelZoomModeCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetFitWidthZoomModeCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetFitVisibleZoomModeCheckItem1)})
        Me.PdfExactZoomListBarSubItem1.Name = "PdfExactZoomListBarSubItem1"
        Me.PdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'PdfZoom10CheckItem1
        '
        Me.PdfZoom10CheckItem1.Id = 8
        Me.PdfZoom10CheckItem1.Name = "PdfZoom10CheckItem1"
        '
        'PdfZoom25CheckItem1
        '
        Me.PdfZoom25CheckItem1.Id = 9
        Me.PdfZoom25CheckItem1.Name = "PdfZoom25CheckItem1"
        '
        'PdfZoom50CheckItem1
        '
        Me.PdfZoom50CheckItem1.Id = 10
        Me.PdfZoom50CheckItem1.Name = "PdfZoom50CheckItem1"
        '
        'PdfZoom75CheckItem1
        '
        Me.PdfZoom75CheckItem1.Id = 11
        Me.PdfZoom75CheckItem1.Name = "PdfZoom75CheckItem1"
        '
        'PdfZoom100CheckItem1
        '
        Me.PdfZoom100CheckItem1.Id = 12
        Me.PdfZoom100CheckItem1.Name = "PdfZoom100CheckItem1"
        '
        'PdfZoom125CheckItem1
        '
        Me.PdfZoom125CheckItem1.Id = 13
        Me.PdfZoom125CheckItem1.Name = "PdfZoom125CheckItem1"
        '
        'PdfZoom150CheckItem1
        '
        Me.PdfZoom150CheckItem1.Id = 14
        Me.PdfZoom150CheckItem1.Name = "PdfZoom150CheckItem1"
        '
        'PdfZoom200CheckItem1
        '
        Me.PdfZoom200CheckItem1.Id = 15
        Me.PdfZoom200CheckItem1.Name = "PdfZoom200CheckItem1"
        '
        'PdfZoom400CheckItem1
        '
        Me.PdfZoom400CheckItem1.Id = 16
        Me.PdfZoom400CheckItem1.Name = "PdfZoom400CheckItem1"
        '
        'PdfZoom500CheckItem1
        '
        Me.PdfZoom500CheckItem1.Id = 17
        Me.PdfZoom500CheckItem1.Name = "PdfZoom500CheckItem1"
        '
        'PdfSetActualSizeZoomModeCheckItem1
        '
        Me.PdfSetActualSizeZoomModeCheckItem1.Id = 18
        Me.PdfSetActualSizeZoomModeCheckItem1.Name = "PdfSetActualSizeZoomModeCheckItem1"
        '
        'PdfSetPageLevelZoomModeCheckItem1
        '
        Me.PdfSetPageLevelZoomModeCheckItem1.Id = 19
        Me.PdfSetPageLevelZoomModeCheckItem1.Name = "PdfSetPageLevelZoomModeCheckItem1"
        '
        'PdfSetFitWidthZoomModeCheckItem1
        '
        Me.PdfSetFitWidthZoomModeCheckItem1.Id = 20
        Me.PdfSetFitWidthZoomModeCheckItem1.Name = "PdfSetFitWidthZoomModeCheckItem1"
        '
        'PdfSetFitVisibleZoomModeCheckItem1
        '
        Me.PdfSetFitVisibleZoomModeCheckItem1.Id = 21
        Me.PdfSetFitVisibleZoomModeCheckItem1.Name = "PdfSetFitVisibleZoomModeCheckItem1"
        '
        'fgvExcel
        '
        Me.fgvExcel.Location = New System.Drawing.Point(14, 30)
        Me.fgvExcel.MenuManager = Me.RibbonControl
        Me.fgvExcel.Name = "fgvExcel"
        Me.fgvExcel.Size = New System.Drawing.Size(187, 513)
        Me.fgvExcel.TabIndex = 2
        Me.fgvExcel.Text = "SpreadsheetControl1"
        '
        'recWord
        '
        Me.recWord.Location = New System.Drawing.Point(207, 76)
        Me.recWord.MenuManager = Me.RibbonControl
        Me.recWord.Name = "recWord"
        Me.recWord.Options.Fields.UseCurrentCultureDateTimeFormat = False
        Me.recWord.Options.MailMerge.KeepLastParagraph = False
        Me.recWord.Size = New System.Drawing.Size(182, 510)
        Me.recWord.TabIndex = 1
        '
        'BackstageViewItemSeparator2
        '
        Me.BackstageViewItemSeparator2.Name = "BackstageViewItemSeparator2"
        '
        'BackstageViewTabItem2
        '
        Me.BackstageViewTabItem2.Caption = "Imagenes"
        Me.BackstageViewTabItem2.ContentControl = Me.BackstageViewClientControl2
        Me.BackstageViewTabItem2.Glyph = Global.Presentacion.My.Resources.Resources.imag_visor16
        Me.BackstageViewTabItem2.Name = "BackstageViewTabItem2"
        Me.BackstageViewTabItem2.Selected = False
        '
        'BackstageViewClientControl2
        '
        Me.BackstageViewClientControl2.Controls.Add(Me.SplitContainerControl2)
        Me.BackstageViewClientControl2.Location = New System.Drawing.Point(132, 0)
        Me.BackstageViewClientControl2.Name = "BackstageViewClientControl2"
        Me.BackstageViewClientControl2.Size = New System.Drawing.Size(1024, 584)
        Me.BackstageViewClientControl2.TabIndex = 1
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainerControl2.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.dgvGaleriaImagenes)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.pbFotoInmueble)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1024, 584)
        Me.SplitContainerControl2.SplitterPosition = 488
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'dgvGaleriaImagenes
        '
        Me.dgvGaleriaImagenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGaleriaImagenes.Location = New System.Drawing.Point(0, 0)
        Me.dgvGaleriaImagenes.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.dgvGaleriaImagenes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgvGaleriaImagenes.MainView = Me.lvGaleriaImagenes
        Me.dgvGaleriaImagenes.MenuManager = Me.RibbonControl
        Me.dgvGaleriaImagenes.Name = "dgvGaleriaImagenes"
        Me.dgvGaleriaImagenes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEditFoto})
        Me.dgvGaleriaImagenes.Size = New System.Drawing.Size(488, 584)
        Me.dgvGaleriaImagenes.TabIndex = 0
        Me.dgvGaleriaImagenes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvGaleriaImagenes, Me.GridView2})
        '
        'lvGaleriaImagenes
        '
        Me.lvGaleriaImagenes.CardCaptionFormat = "Imagen {0} de {1}"
        Me.lvGaleriaImagenes.CardMinSize = New System.Drawing.Size(214, 269)
        Me.lvGaleriaImagenes.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colFoto, Me.colNombre, Me.colDescripcion, Me.LayoutViewColumn1})
        Me.lvGaleriaImagenes.GridControl = Me.dgvGaleriaImagenes
        Me.lvGaleriaImagenes.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1_5})
        Me.lvGaleriaImagenes.Name = "lvGaleriaImagenes"
        Me.lvGaleriaImagenes.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn
        Me.lvGaleriaImagenes.TemplateCard = Me.LayoutViewCard1
        '
        'colFoto
        '
        Me.colFoto.Caption = "Foto"
        Me.colFoto.ColumnEdit = Me.RepositoryItemPictureEditFoto
        Me.colFoto.FieldName = "Foto"
        Me.colFoto.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.colFoto.Name = "colFoto"
        Me.colFoto.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemPictureEditFoto
        '
        Me.RepositoryItemPictureEditFoto.Appearance.BorderColor = System.Drawing.Color.DarkGray
        Me.RepositoryItemPictureEditFoto.Appearance.Options.UseBorderColor = True
        Me.RepositoryItemPictureEditFoto.CustomHeight = 125
        Me.RepositoryItemPictureEditFoto.Name = "RepositoryItemPictureEditFoto"
        Me.RepositoryItemPictureEditFoto.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 190
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(194, 153)
        Me.layoutViewField_LayoutViewColumn1.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(58, 13)
        Me.layoutViewField_LayoutViewColumn1.TextToControlDistance = 5
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.LayoutViewField = Me.layoutViewField_LayoutViewColumn2
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn2
        '
        Me.layoutViewField_LayoutViewColumn2.EditorPreferredWidth = 190
        Me.layoutViewField_LayoutViewColumn2.Location = New System.Drawing.Point(0, 153)
        Me.layoutViewField_LayoutViewColumn2.Name = "layoutViewField_LayoutViewColumn2"
        Me.layoutViewField_LayoutViewColumn2.Size = New System.Drawing.Size(194, 38)
        Me.layoutViewField_LayoutViewColumn2.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_LayoutViewColumn2.TextSize = New System.Drawing.Size(58, 13)
        Me.layoutViewField_LayoutViewColumn2.TextToControlDistance = 5
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.LayoutViewField = Me.layoutViewField_LayoutViewColumn3
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn3
        '
        Me.layoutViewField_LayoutViewColumn3.EditorPreferredWidth = 190
        Me.layoutViewField_LayoutViewColumn3.Location = New System.Drawing.Point(0, 191)
        Me.layoutViewField_LayoutViewColumn3.Name = "layoutViewField_LayoutViewColumn3"
        Me.layoutViewField_LayoutViewColumn3.Size = New System.Drawing.Size(194, 58)
        Me.layoutViewField_LayoutViewColumn3.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_LayoutViewColumn3.TextSize = New System.Drawing.Size(58, 13)
        Me.layoutViewField_LayoutViewColumn3.TextToControlDistance = 5
        '
        'LayoutViewColumn1
        '
        Me.LayoutViewColumn1.FieldName = "Id"
        Me.LayoutViewColumn1.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_5
        Me.LayoutViewColumn1.Name = "LayoutViewColumn1"
        '
        'layoutViewField_LayoutViewColumn1_5
        '
        Me.layoutViewField_LayoutViewColumn1_5.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1_5.Location = New System.Drawing.Point(0, 229)
        Me.layoutViewField_LayoutViewColumn1_5.Name = "layoutViewField_LayoutViewColumn1_5"
        Me.layoutViewField_LayoutViewColumn1_5.Size = New System.Drawing.Size(194, 20)
        Me.layoutViewField_LayoutViewColumn1_5.TextSize = New System.Drawing.Size(58, 20)
        Me.layoutViewField_LayoutViewColumn1_5.TextToControlDistance = 5
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1, Me.layoutViewField_LayoutViewColumn2, Me.layoutViewField_LayoutViewColumn3})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.dgvGaleriaImagenes
        Me.GridView2.Name = "GridView2"
        '
        'pbFotoInmueble
        '
        Me.pbFotoInmueble.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbFotoInmueble.Location = New System.Drawing.Point(0, 0)
        Me.pbFotoInmueble.MenuManager = Me.RibbonControl
        Me.pbFotoInmueble.Name = "pbFotoInmueble"
        Me.pbFotoInmueble.Properties.LookAndFeel.SkinName = "Seven"
        Me.pbFotoInmueble.Properties.NullText = "Sin Imagen"
        Me.pbFotoInmueble.Size = New System.Drawing.Size(531, 552)
        Me.pbFotoInmueble.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblzoom)
        Me.PanelControl1.Controls.Add(Me.ZoomTrackBarControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 552)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(531, 32)
        Me.PanelControl1.TabIndex = 1
        '
        'lblzoom
        '
        Me.lblzoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblzoom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblzoom.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblzoom.Location = New System.Drawing.Point(295, 6)
        Me.lblzoom.Name = "lblzoom"
        Me.lblzoom.Size = New System.Drawing.Size(49, 18)
        Me.lblzoom.TabIndex = 0
        Me.lblzoom.Text = "0"
        '
        'ZoomTrackBarControl1
        '
        Me.ZoomTrackBarControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoomTrackBarControl1.EditValue = 100
        Me.ZoomTrackBarControl1.Location = New System.Drawing.Point(351, 4)
        Me.ZoomTrackBarControl1.MenuManager = Me.RibbonControl
        Me.ZoomTrackBarControl1.Name = "ZoomTrackBarControl1"
        Me.ZoomTrackBarControl1.Properties.LargeChange = 10
        Me.ZoomTrackBarControl1.Properties.LookAndFeel.SkinName = "Seven"
        Me.ZoomTrackBarControl1.Properties.Maximum = 300
        Me.ZoomTrackBarControl1.Properties.Middle = 5
        Me.ZoomTrackBarControl1.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
        Me.ZoomTrackBarControl1.Properties.SmallChange = 10
        Me.ZoomTrackBarControl1.Size = New System.Drawing.Size(175, 23)
        Me.ZoomTrackBarControl1.TabIndex = 1
        Me.ZoomTrackBarControl1.Value = 100
        '
        'BackstageViewItemSeparator3
        '
        Me.BackstageViewItemSeparator3.Name = "BackstageViewItemSeparator3"
        '
        'BackstageViewTabItem3
        '
        Me.BackstageViewTabItem3.Caption = "Multimedia"
        Me.BackstageViewTabItem3.ContentControl = Me.BackstageViewClientControl3
        Me.BackstageViewTabItem3.Glyph = Global.Presentacion.My.Resources.Resources.mult_visor16
        Me.BackstageViewTabItem3.Name = "BackstageViewTabItem3"
        Me.BackstageViewTabItem3.Selected = False
        '
        'BackstageViewClientControl3
        '
        Me.BackstageViewClientControl3.Controls.Add(Me.SplitContainerControl3)
        Me.BackstageViewClientControl3.Location = New System.Drawing.Point(132, 0)
        Me.BackstageViewClientControl3.Name = "BackstageViewClientControl3"
        Me.BackstageViewClientControl3.Size = New System.Drawing.Size(1024, 584)
        Me.BackstageViewClientControl3.TabIndex = 2
        '
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainerControl3.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.dgvMultimedia)
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.Size = New System.Drawing.Size(1024, 584)
        Me.SplitContainerControl3.SplitterPosition = 460
        Me.SplitContainerControl3.TabIndex = 0
        Me.SplitContainerControl3.Text = "SplitContainerControl3"
        '
        'dgvMultimedia
        '
        Me.dgvMultimedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMultimedia.Location = New System.Drawing.Point(0, 0)
        Me.dgvMultimedia.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.dgvMultimedia.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgvMultimedia.MainView = Me.lvmultimedia
        Me.dgvMultimedia.MenuManager = Me.RibbonControl
        Me.dgvMultimedia.Name = "dgvMultimedia"
        Me.dgvMultimedia.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1, Me.rihdescargarvid, Me.rihvistaprevia})
        Me.dgvMultimedia.Size = New System.Drawing.Size(460, 584)
        Me.dgvMultimedia.TabIndex = 0
        Me.dgvMultimedia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvmultimedia, Me.GridView1})
        '
        'lvmultimedia
        '
        Me.lvmultimedia.CardCaptionFormat = "Video {0} de {1}"
        Me.lvmultimedia.CardMinSize = New System.Drawing.Size(214, 269)
        Me.lvmultimedia.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.lvcfoto, Me.lvcnombre, Me.lvcdescripcion, Me.lvcopcion1, Me.lvcopcion2, Me.lvcextension, Me.lvcarchivo, Me.lvctipovid, Me.LayoutViewColumn2})
        Me.lvmultimedia.GridControl = Me.dgvMultimedia
        Me.lvmultimedia.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1_3, Me.layoutViewField_LayoutViewColumn2_3, Me.layoutViewField_LayoutViewColumn1_4, Me.layoutViewField_LayoutViewColumn2_4})
        Me.lvmultimedia.Name = "lvmultimedia"
        Me.lvmultimedia.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn
        Me.lvmultimedia.TemplateCard = Me.LayoutViewCard2
        '
        'lvcfoto
        '
        Me.lvcfoto.AppearanceCell.BackColor = System.Drawing.Color.Black
        Me.lvcfoto.AppearanceCell.Options.UseBackColor = True
        Me.lvcfoto.Caption = "Foto"
        Me.lvcfoto.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.lvcfoto.FieldName = "Foto"
        Me.lvcfoto.ImageIndex = 0
        Me.lvcfoto.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_1
        Me.lvcfoto.Name = "lvcfoto"
        Me.lvcfoto.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Appearance.BackColor = System.Drawing.Color.Black
        Me.RepositoryItemPictureEdit1.Appearance.Options.UseBackColor = True
        Me.RepositoryItemPictureEdit1.AppearanceDisabled.BackColor = System.Drawing.Color.Black
        Me.RepositoryItemPictureEdit1.AppearanceDisabled.Options.UseBackColor = True
        Me.RepositoryItemPictureEdit1.AppearanceFocused.BackColor = System.Drawing.Color.Black
        Me.RepositoryItemPictureEdit1.AppearanceFocused.Options.UseBackColor = True
        Me.RepositoryItemPictureEdit1.AppearanceReadOnly.BackColor = System.Drawing.Color.Black
        Me.RepositoryItemPictureEdit1.AppearanceReadOnly.Options.UseBackColor = True
        Me.RepositoryItemPictureEdit1.CustomHeight = 125
        Me.RepositoryItemPictureEdit1.InitialImage = CType(resources.GetObject("RepositoryItemPictureEdit1.InitialImage"), System.Drawing.Image)
        Me.RepositoryItemPictureEdit1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.RepositoryItemPictureEdit1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'layoutViewField_LayoutViewColumn1_1
        '
        Me.layoutViewField_LayoutViewColumn1_1.EditorPreferredWidth = 190
        Me.layoutViewField_LayoutViewColumn1_1.ImageIndex = 0
        Me.layoutViewField_LayoutViewColumn1_1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1_1.Name = "layoutViewField_LayoutViewColumn1_1"
        Me.layoutViewField_LayoutViewColumn1_1.Size = New System.Drawing.Size(194, 153)
        Me.layoutViewField_LayoutViewColumn1_1.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_LayoutViewColumn1_1.TextSize = New System.Drawing.Size(58, 13)
        Me.layoutViewField_LayoutViewColumn1_1.TextToControlDistance = 5
        '
        'lvcnombre
        '
        Me.lvcnombre.Caption = "Nombre"
        Me.lvcnombre.FieldName = "Nombre"
        Me.lvcnombre.LayoutViewField = Me.layoutViewField_LayoutViewColumn2_1
        Me.lvcnombre.Name = "lvcnombre"
        Me.lvcnombre.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn2_1
        '
        Me.layoutViewField_LayoutViewColumn2_1.EditorPreferredWidth = 190
        Me.layoutViewField_LayoutViewColumn2_1.Location = New System.Drawing.Point(0, 153)
        Me.layoutViewField_LayoutViewColumn2_1.Name = "layoutViewField_LayoutViewColumn2_1"
        Me.layoutViewField_LayoutViewColumn2_1.Size = New System.Drawing.Size(194, 38)
        Me.layoutViewField_LayoutViewColumn2_1.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_LayoutViewColumn2_1.TextSize = New System.Drawing.Size(58, 13)
        Me.layoutViewField_LayoutViewColumn2_1.TextToControlDistance = 5
        '
        'lvcdescripcion
        '
        Me.lvcdescripcion.Caption = "Descripcion"
        Me.lvcdescripcion.FieldName = "Descripcion"
        Me.lvcdescripcion.LayoutViewField = Me.layoutViewField_LayoutViewColumn3_1
        Me.lvcdescripcion.Name = "lvcdescripcion"
        Me.lvcdescripcion.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn3_1
        '
        Me.layoutViewField_LayoutViewColumn3_1.EditorPreferredWidth = 190
        Me.layoutViewField_LayoutViewColumn3_1.Location = New System.Drawing.Point(0, 191)
        Me.layoutViewField_LayoutViewColumn3_1.Name = "layoutViewField_LayoutViewColumn3_1"
        Me.layoutViewField_LayoutViewColumn3_1.Size = New System.Drawing.Size(194, 38)
        Me.layoutViewField_LayoutViewColumn3_1.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_LayoutViewColumn3_1.TextSize = New System.Drawing.Size(58, 13)
        Me.layoutViewField_LayoutViewColumn3_1.TextToControlDistance = 5
        '
        'lvcopcion1
        '
        Me.lvcopcion1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.lvcopcion1.AppearanceCell.BorderColor = System.Drawing.Color.Gray
        Me.lvcopcion1.AppearanceCell.Options.UseBackColor = True
        Me.lvcopcion1.AppearanceCell.Options.UseBorderColor = True
        Me.lvcopcion1.Caption = "Opción 1"
        Me.lvcopcion1.ColumnEdit = Me.rihdescargarvid
        Me.lvcopcion1.FieldName = "Accion1"
        Me.lvcopcion1.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_2
        Me.lvcopcion1.Name = "lvcopcion1"
        Me.lvcopcion1.OptionsColumn.ReadOnly = True
        '
        'rihdescargarvid
        '
        Me.rihdescargarvid.AutoHeight = False
        Me.rihdescargarvid.Name = "rihdescargarvid"
        '
        'layoutViewField_LayoutViewColumn1_2
        '
        Me.layoutViewField_LayoutViewColumn1_2.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1_2.Location = New System.Drawing.Point(0, 229)
        Me.layoutViewField_LayoutViewColumn1_2.Name = "layoutViewField_LayoutViewColumn1_2"
        Me.layoutViewField_LayoutViewColumn1_2.Size = New System.Drawing.Size(194, 20)
        Me.layoutViewField_LayoutViewColumn1_2.TextSize = New System.Drawing.Size(58, 13)
        Me.layoutViewField_LayoutViewColumn1_2.TextToControlDistance = 5
        '
        'lvcopcion2
        '
        Me.lvcopcion2.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.lvcopcion2.AppearanceCell.BorderColor = System.Drawing.Color.Gray
        Me.lvcopcion2.AppearanceCell.Options.UseBackColor = True
        Me.lvcopcion2.AppearanceCell.Options.UseBorderColor = True
        Me.lvcopcion2.Caption = "Opción 2"
        Me.lvcopcion2.ColumnEdit = Me.rihvistaprevia
        Me.lvcopcion2.FieldName = "Accion2"
        Me.lvcopcion2.LayoutViewField = Me.layoutViewField_LayoutViewColumn2_2
        Me.lvcopcion2.Name = "lvcopcion2"
        Me.lvcopcion2.OptionsColumn.ReadOnly = True
        '
        'rihvistaprevia
        '
        Me.rihvistaprevia.AutoHeight = False
        Me.rihvistaprevia.Name = "rihvistaprevia"
        '
        'layoutViewField_LayoutViewColumn2_2
        '
        Me.layoutViewField_LayoutViewColumn2_2.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn2_2.Location = New System.Drawing.Point(0, 249)
        Me.layoutViewField_LayoutViewColumn2_2.Name = "layoutViewField_LayoutViewColumn2_2"
        Me.layoutViewField_LayoutViewColumn2_2.Size = New System.Drawing.Size(194, 40)
        Me.layoutViewField_LayoutViewColumn2_2.TextSize = New System.Drawing.Size(58, 13)
        Me.layoutViewField_LayoutViewColumn2_2.TextToControlDistance = 5
        '
        'lvcextension
        '
        Me.lvcextension.Caption = "LayoutViewColumn1"
        Me.lvcextension.FieldName = "Extension"
        Me.lvcextension.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_3
        Me.lvcextension.Name = "lvcextension"
        Me.lvcextension.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn1_3
        '
        Me.layoutViewField_LayoutViewColumn1_3.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1_3.Location = New System.Drawing.Point(0, 269)
        Me.layoutViewField_LayoutViewColumn1_3.Name = "layoutViewField_LayoutViewColumn1_3"
        Me.layoutViewField_LayoutViewColumn1_3.Size = New System.Drawing.Size(194, 20)
        Me.layoutViewField_LayoutViewColumn1_3.TextSize = New System.Drawing.Size(58, 20)
        Me.layoutViewField_LayoutViewColumn1_3.TextToControlDistance = 5
        '
        'lvcarchivo
        '
        Me.lvcarchivo.Caption = "LayoutViewColumn2"
        Me.lvcarchivo.FieldName = "Archivo"
        Me.lvcarchivo.LayoutViewField = Me.layoutViewField_LayoutViewColumn2_3
        Me.lvcarchivo.Name = "lvcarchivo"
        Me.lvcarchivo.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn2_3
        '
        Me.layoutViewField_LayoutViewColumn2_3.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn2_3.Location = New System.Drawing.Point(0, 269)
        Me.layoutViewField_LayoutViewColumn2_3.Name = "layoutViewField_LayoutViewColumn2_3"
        Me.layoutViewField_LayoutViewColumn2_3.Size = New System.Drawing.Size(194, 40)
        Me.layoutViewField_LayoutViewColumn2_3.TextSize = New System.Drawing.Size(100, 20)
        Me.layoutViewField_LayoutViewColumn2_3.TextToControlDistance = 5
        '
        'lvctipovid
        '
        Me.lvctipovid.Caption = "LayoutViewColumn1"
        Me.lvctipovid.FieldName = "Tipo"
        Me.lvctipovid.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_4
        Me.lvctipovid.Name = "lvctipovid"
        Me.lvctipovid.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn1_4
        '
        Me.layoutViewField_LayoutViewColumn1_4.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1_4.Location = New System.Drawing.Point(0, 269)
        Me.layoutViewField_LayoutViewColumn1_4.Name = "layoutViewField_LayoutViewColumn1_4"
        Me.layoutViewField_LayoutViewColumn1_4.Size = New System.Drawing.Size(194, 20)
        Me.layoutViewField_LayoutViewColumn1_4.TextSize = New System.Drawing.Size(100, 13)
        Me.layoutViewField_LayoutViewColumn1_4.TextToControlDistance = 5
        '
        'LayoutViewColumn2
        '
        Me.LayoutViewColumn2.Caption = "LayoutViewColumn2"
        Me.LayoutViewColumn2.FieldName = "Id"
        Me.LayoutViewColumn2.LayoutViewField = Me.layoutViewField_LayoutViewColumn2_4
        Me.LayoutViewColumn2.Name = "LayoutViewColumn2"
        '
        'layoutViewField_LayoutViewColumn2_4
        '
        Me.layoutViewField_LayoutViewColumn2_4.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn2_4.Location = New System.Drawing.Point(0, 269)
        Me.layoutViewField_LayoutViewColumn2_4.Name = "layoutViewField_LayoutViewColumn2_4"
        Me.layoutViewField_LayoutViewColumn2_4.Size = New System.Drawing.Size(194, 20)
        Me.layoutViewField_LayoutViewColumn2_4.TextSize = New System.Drawing.Size(100, 20)
        Me.layoutViewField_LayoutViewColumn2_4.TextToControlDistance = 5
        '
        'LayoutViewCard2
        '
        Me.LayoutViewCard2.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard2.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1_1, Me.layoutViewField_LayoutViewColumn2_1, Me.layoutViewField_LayoutViewColumn3_1, Me.layoutViewField_LayoutViewColumn1_2, Me.layoutViewField_LayoutViewColumn2_2})
        Me.LayoutViewCard2.Name = "layoutViewTemplateCard"
        Me.LayoutViewCard2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard2.Text = "TemplateCard"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgvMultimedia
        Me.GridView1.Name = "GridView1"
        '
        'BackstageViewItemSeparator4
        '
        Me.BackstageViewItemSeparator4.Name = "BackstageViewItemSeparator4"
        '
        'imagenes128
        '
        Me.imagenes128.ImageSize = New System.Drawing.Size(128, 128)
        Me.imagenes128.ImageStream = CType(resources.GetObject("imagenes128.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imagenes128.Images.SetKeyName(0, "app_icon_128.png")
        Me.imagenes128.Images.SetKeyName(1, "flv_icon_128.png")
        '
        'RepositoryItemFontEdit1
        '
        Me.RepositoryItemFontEdit1.AutoHeight = False
        Me.RepositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemFontEdit1.Name = "RepositoryItemFontEdit1"
        '
        'RepositoryItemRichEditFontSizeEdit1
        '
        Me.RepositoryItemRichEditFontSizeEdit1.AutoHeight = False
        Me.RepositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemRichEditFontSizeEdit1.Control = Nothing
        Me.RepositoryItemRichEditFontSizeEdit1.Name = "RepositoryItemRichEditFontSizeEdit1"
        '
        'RepositoryItemRichEditStyleEdit1
        '
        Me.RepositoryItemRichEditStyleEdit1.AutoHeight = False
        Me.RepositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemRichEditStyleEdit1.Control = Nothing
        Me.RepositoryItemRichEditStyleEdit1.Name = "RepositoryItemRichEditStyleEdit1"
        '
        'RepositoryItemBorderLineStyle1
        '
        Me.RepositoryItemBorderLineStyle1.AutoHeight = False
        Me.RepositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemBorderLineStyle1.Control = Nothing
        Me.RepositoryItemBorderLineStyle1.Name = "RepositoryItemBorderLineStyle1"
        '
        'RepositoryItemBorderLineWeight1
        '
        Me.RepositoryItemBorderLineWeight1.AutoHeight = False
        Me.RepositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemBorderLineWeight1.Control = Nothing
        Me.RepositoryItemBorderLineWeight1.Name = "RepositoryItemBorderLineWeight1"
        '
        'CommonRibbonPageGroup1
        '
        Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
        Me.CommonRibbonPageGroup1.Text = ""
        '
        'FileRibbonPage1
        '
        Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1})
        Me.FileRibbonPage1.Name = "FileRibbonPage1"
        '
        'ClipboardRibbonPageGroup1
        '
        Me.ClipboardRibbonPageGroup1.Name = "ClipboardRibbonPageGroup1"
        Me.ClipboardRibbonPageGroup1.Text = ""
        '
        'HomeRibbonPage1
        '
        Me.HomeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ClipboardRibbonPageGroup1, Me.FontRibbonPageGroup1, Me.ParagraphRibbonPageGroup1, Me.StylesRibbonPageGroup1, Me.EditingRibbonPageGroup1})
        Me.HomeRibbonPage1.Name = "HomeRibbonPage1"
        '
        'FontRibbonPageGroup1
        '
        Me.FontRibbonPageGroup1.Name = "FontRibbonPageGroup1"
        Me.FontRibbonPageGroup1.Text = ""
        '
        'ParagraphRibbonPageGroup1
        '
        Me.ParagraphRibbonPageGroup1.Name = "ParagraphRibbonPageGroup1"
        Me.ParagraphRibbonPageGroup1.Text = ""
        '
        'StylesRibbonPageGroup1
        '
        Me.StylesRibbonPageGroup1.Name = "StylesRibbonPageGroup1"
        Me.StylesRibbonPageGroup1.Text = ""
        '
        'EditingRibbonPageGroup1
        '
        Me.EditingRibbonPageGroup1.Name = "EditingRibbonPageGroup1"
        Me.EditingRibbonPageGroup1.Text = ""
        '
        'PagesRibbonPageGroup1
        '
        Me.PagesRibbonPageGroup1.Name = "PagesRibbonPageGroup1"
        Me.PagesRibbonPageGroup1.Text = ""
        '
        'InsertRibbonPage1
        '
        Me.InsertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PagesRibbonPageGroup1, Me.TablesRibbonPageGroup1, Me.IllustrationsRibbonPageGroup1, Me.LinksRibbonPageGroup1, Me.HeaderFooterRibbonPageGroup1, Me.SymbolsRibbonPageGroup1})
        Me.InsertRibbonPage1.Name = "InsertRibbonPage1"
        '
        'TablesRibbonPageGroup1
        '
        Me.TablesRibbonPageGroup1.Name = "TablesRibbonPageGroup1"
        Me.TablesRibbonPageGroup1.Text = ""
        '
        'IllustrationsRibbonPageGroup1
        '
        Me.IllustrationsRibbonPageGroup1.Name = "IllustrationsRibbonPageGroup1"
        Me.IllustrationsRibbonPageGroup1.Text = ""
        '
        'LinksRibbonPageGroup1
        '
        Me.LinksRibbonPageGroup1.Name = "LinksRibbonPageGroup1"
        Me.LinksRibbonPageGroup1.Text = ""
        '
        'HeaderFooterRibbonPageGroup1
        '
        Me.HeaderFooterRibbonPageGroup1.Name = "HeaderFooterRibbonPageGroup1"
        Me.HeaderFooterRibbonPageGroup1.Text = ""
        '
        'SymbolsRibbonPageGroup1
        '
        Me.SymbolsRibbonPageGroup1.Name = "SymbolsRibbonPageGroup1"
        Me.SymbolsRibbonPageGroup1.Text = ""
        '
        'PageSetupRibbonPageGroup1
        '
        Me.PageSetupRibbonPageGroup1.Name = "PageSetupRibbonPageGroup1"
        Me.PageSetupRibbonPageGroup1.Text = ""
        '
        'PageLayoutRibbonPage1
        '
        Me.PageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PageSetupRibbonPageGroup1})
        Me.PageLayoutRibbonPage1.Name = "PageLayoutRibbonPage1"
        '
        'DocumentViewsRibbonPageGroup1
        '
        Me.DocumentViewsRibbonPageGroup1.Name = "DocumentViewsRibbonPageGroup1"
        Me.DocumentViewsRibbonPageGroup1.Text = ""
        '
        'ViewRibbonPage1
        '
        Me.ViewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.DocumentViewsRibbonPageGroup1, Me.ShowRibbonPageGroup1, Me.ZoomRibbonPageGroup1})
        Me.ViewRibbonPage1.Name = "ViewRibbonPage1"
        '
        'ShowRibbonPageGroup1
        '
        Me.ShowRibbonPageGroup1.Name = "ShowRibbonPageGroup1"
        Me.ShowRibbonPageGroup1.Text = ""
        '
        'ZoomRibbonPageGroup1
        '
        Me.ZoomRibbonPageGroup1.Name = "ZoomRibbonPageGroup1"
        Me.ZoomRibbonPageGroup1.Text = ""
        '
        'TableStylesRibbonPageGroup1
        '
        Me.TableStylesRibbonPageGroup1.Name = "TableStylesRibbonPageGroup1"
        Me.TableStylesRibbonPageGroup1.Text = ""
        '
        'TableDesignRibbonPage1
        '
        Me.TableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.TableStylesRibbonPageGroup1, Me.TableDrawBordersRibbonPageGroup1})
        Me.TableDesignRibbonPage1.Name = "TableDesignRibbonPage1"
        '
        'TableDrawBordersRibbonPageGroup1
        '
        Me.TableDrawBordersRibbonPageGroup1.Name = "TableDrawBordersRibbonPageGroup1"
        Me.TableDrawBordersRibbonPageGroup1.Text = ""
        '
        'TableToolsRibbonPageCategory1
        '
        Me.TableToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TableToolsRibbonPageCategory1.Control = Nothing
        Me.TableToolsRibbonPageCategory1.Name = "TableToolsRibbonPageCategory1"
        Me.TableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.TableDesignRibbonPage1, Me.TableLayoutRibbonPage1})
        '
        'TableLayoutRibbonPage1
        '
        Me.TableLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.TableTableRibbonPageGroup1, Me.TableRowsAndColumnsRibbonPageGroup1, Me.TableMergeRibbonPageGroup1, Me.TableCellSizeRibbonPageGroup1, Me.TableAlignmentRibbonPageGroup1})
        Me.TableLayoutRibbonPage1.Name = "TableLayoutRibbonPage1"
        '
        'TableTableRibbonPageGroup1
        '
        Me.TableTableRibbonPageGroup1.Name = "TableTableRibbonPageGroup1"
        Me.TableTableRibbonPageGroup1.Text = ""
        '
        'TableRowsAndColumnsRibbonPageGroup1
        '
        Me.TableRowsAndColumnsRibbonPageGroup1.Name = "TableRowsAndColumnsRibbonPageGroup1"
        Me.TableRowsAndColumnsRibbonPageGroup1.Text = ""
        '
        'TableMergeRibbonPageGroup1
        '
        Me.TableMergeRibbonPageGroup1.Name = "TableMergeRibbonPageGroup1"
        Me.TableMergeRibbonPageGroup1.Text = ""
        '
        'TableCellSizeRibbonPageGroup1
        '
        Me.TableCellSizeRibbonPageGroup1.Name = "TableCellSizeRibbonPageGroup1"
        Me.TableCellSizeRibbonPageGroup1.Text = ""
        '
        'TableAlignmentRibbonPageGroup1
        '
        Me.TableAlignmentRibbonPageGroup1.Name = "TableAlignmentRibbonPageGroup1"
        Me.TableAlignmentRibbonPageGroup1.Text = ""
        '
        'BackstageViewControl1
        '
        Me.BackstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl1)
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl2)
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl3)
        Me.BackstageViewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator1)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem1)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator2)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem2)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator3)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem3)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator4)
        Me.BackstageViewControl1.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewControl1.Name = "BackstageViewControl1"
        Me.BackstageViewControl1.SelectedTab = Me.BackstageViewTabItem1
        Me.BackstageViewControl1.SelectedTabIndex = 1
        Me.BackstageViewControl1.Size = New System.Drawing.Size(1156, 584)
        Me.BackstageViewControl1.TabIndex = 0
        Me.BackstageViewControl1.Text = "BackstageViewControl1"
        '
        'PdfBarController1
        '
        Me.PdfBarController1.BarItems.Add(Me.PdfFileOpenBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfFilePrintBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfPreviousPageBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfNextPageBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfFindTextBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoomOutBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoomInBarItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfExactZoomListBarSubItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom10CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom25CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom50CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom75CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom100CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom125CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom150CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom200CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom400CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom500CheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetActualSizeZoomModeCheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetPageLevelZoomModeCheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetFitWidthZoomModeCheckItem1)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetFitVisibleZoomModeCheckItem1)
        Me.PdfBarController1.Control = Me.visorPDF
        '
        'frmGaleriaInmueble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 611)
        Me.Controls.Add(Me.BackstageViewControl1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmGaleriaInmueble"
        Me.ShowInTaskbar = False
        Me.Text = "GALERIA DE INMUEBLES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.BackstageViewControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewClientControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl4.ResumeLayout(False)
        CType(Me.dgvArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rihNombreVistaPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rihdescargar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rihTipoArchivoDescargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEditVistaPrevia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEditImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.visorPDF.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewClientControl2.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.dgvGaleriaImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvGaleriaImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEditFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFotoInmueble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.ZoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZoomTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewClientControl3.ResumeLayout(False)
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.dgvMultimedia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvmultimedia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn3_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rihdescargarvid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rihvistaprevia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenes128, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewControl1.ResumeLayout(False)
        CType(Me.PdfBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem1 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator2 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem2 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator3 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem3 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator4 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents sfddescargar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents imagenes128 As DevExpress.Utils.ImageCollection
    Friend WithEvents RepositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
    Friend WithEvents RepositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
    Friend WithEvents RepositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
    Friend WithEvents RepositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
    Friend WithEvents RepositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
    Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
    Friend WithEvents FileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
    Friend WithEvents ClipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
    Friend WithEvents HomeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
    Friend WithEvents FontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
    Friend WithEvents ParagraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
    Friend WithEvents StylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
    Friend WithEvents EditingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
    Friend WithEvents PagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
    Friend WithEvents InsertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
    Friend WithEvents TablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
    Friend WithEvents IllustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
    Friend WithEvents LinksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
    Friend WithEvents HeaderFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
    Friend WithEvents SymbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
    Friend WithEvents PageSetupRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup
    Friend WithEvents PageLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage
    Friend WithEvents DocumentViewsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup
    Friend WithEvents ViewRibbonPage1 As DevExpress.XtraRichEdit.UI.ViewRibbonPage
    Friend WithEvents ShowRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup
    Friend WithEvents ZoomRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup
    Friend WithEvents TableStylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup
    Friend WithEvents TableDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.TableDesignRibbonPage
    Friend WithEvents TableDrawBordersRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup
    Friend WithEvents TableToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory
    Friend WithEvents TableLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage
    Friend WithEvents TableTableRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup
    Friend WithEvents TableRowsAndColumnsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup
    Friend WithEvents TableMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup
    Friend WithEvents TableCellSizeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup
    Friend WithEvents TableAlignmentRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup
    Friend WithEvents BackstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents SplitContainerControl4 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents dgvArchivos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvArchivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rihdescargar2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEditVistaPrevia As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEditImprimir As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents recWord As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents BackstageViewClientControl2 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents dgvGaleriaImagenes As SaimtControles.SaimtDataGrid
    Friend WithEvents lvGaleriaImagenes As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colFoto As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents RepositoryItemPictureEditFoto As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents pbFotoInmueble As SaimtControles.SaimtPictureBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblzoom As SaimtControles.SaimtLabel
    Friend WithEvents ZoomTrackBarControl1 As DevExpress.XtraEditors.ZoomTrackBarControl
    Friend WithEvents BackstageViewClientControl3 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents dgvMultimedia As SaimtControles.SaimtDataGrid
    Friend WithEvents lvmultimedia As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents lvcfoto As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents layoutViewField_LayoutViewColumn1_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents lvcnombre As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn2_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents lvcdescripcion As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn3_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents lvcopcion1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents rihdescargarvid As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents layoutViewField_LayoutViewColumn1_2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents lvcopcion2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents rihvistaprevia As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents layoutViewField_LayoutViewColumn2_2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents lvcextension As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1_3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents lvcarchivo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn2_3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents lvctipovid As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1_4 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard2 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BackstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1_5 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn2_4 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents rihNombreVistaPreview As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents rihTipoArchivoDescargar As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents fgvExcel As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents visorPDF As DevExpress.XtraPdfViewer.PdfViewer
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents PdfCommandBar1 As DevExpress.XtraPdfViewer.Bars.PdfCommandBar
    Friend WithEvents PdfFileOpenBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem
    Friend WithEvents PdfFilePrintBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem
    Friend WithEvents PdfPreviousPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem
    Friend WithEvents PdfNextPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem
    Friend WithEvents PdfFindTextBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem
    Friend WithEvents PdfZoomOutBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem
    Friend WithEvents PdfZoomInBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem
    Friend WithEvents PdfExactZoomListBarSubItem1 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem
    Friend WithEvents PdfZoom10CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem
    Friend WithEvents PdfZoom25CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem
    Friend WithEvents PdfZoom50CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem
    Friend WithEvents PdfZoom75CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem
    Friend WithEvents PdfZoom100CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem
    Friend WithEvents PdfZoom125CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem
    Friend WithEvents PdfZoom150CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem
    Friend WithEvents PdfZoom200CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem
    Friend WithEvents PdfZoom400CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem
    Friend WithEvents PdfZoom500CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem
    Friend WithEvents PdfSetActualSizeZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem
    Friend WithEvents PdfSetPageLevelZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem
    Friend WithEvents PdfSetFitWidthZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem
    Friend WithEvents PdfSetFitVisibleZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem
    Friend WithEvents PdfBarController1 As DevExpress.XtraPdfViewer.Bars.PdfBarController

End Class
