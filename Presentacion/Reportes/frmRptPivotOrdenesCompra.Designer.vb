<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptPivotOrdenesCompra

    Inherits frmGeneral

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptPivotOrdenesCompra))
        Me.beiprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.btnExportarOsce = New SaimtControles.SaimtButton()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.dtpFechaFin = New SaimtControles.SaimtDateTimePicker()
        Me.btnmostrarxfecha = New SaimtControles.SaimtButton()
        Me.dtpFechaInicio = New SaimtControles.SaimtDateTimePicker()
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.beiprogresoO = New DevExpress.XtraBars.BarEditItem()
        Me.riprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.pgcordenesdetalle = New SaimtControles.SaimtPivotGridControl()
        Me.pgfordId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordNro = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordFechaDoc = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgEstadoId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordNroCompPago = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfperProv = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfperNDoc = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordRefDoc = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgCuentaDebeId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgCuentaDebe = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgCuentaHaberId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgCuentaHaber = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfpartId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordRefCert = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgFFinancieraId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgMetaId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgActProyId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordImporte = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordImporteIGV = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordTotal = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordDetId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfartDescripcion = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgUMId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordDetCantidad = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordDetPrecio = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.dtpFechaFin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riprogreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcordenesdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.beiprogresoO)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 674)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1094, 27)
        '
        'beiprogreso
        '
        Me.beiprogreso.Caption = "BarEditItem1"
        Me.beiprogreso.Edit = Nothing
        Me.beiprogreso.Id = 4
        Me.beiprogreso.Name = "beiprogreso"
        Me.beiprogreso.Width = 110
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Nothing
        Me.BarEditItem1.Id = 4
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 110
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel1.ID = New System.Guid("fc2c24e8-56eb-4032-814a-c602adc53d8a")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 587)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 87)
        Me.DockPanel1.Size = New System.Drawing.Size(1094, 87)
        Me.DockPanel1.Text = "Datos para el Reporte"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.btnExportarOsce)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel2)
        Me.DockPanel1_Container.Controls.Add(Me.btnexportar)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel1)
        Me.DockPanel1_Container.Controls.Add(Me.dtpFechaFin)
        Me.DockPanel1_Container.Controls.Add(Me.btnmostrarxfecha)
        Me.DockPanel1_Container.Controls.Add(Me.dtpFechaInicio)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(1086, 60)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'btnExportarOsce
        '
        Me.btnExportarOsce.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarOsce.Appearance.Options.UseTextOptions = True
        Me.btnExportarOsce.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportarOsce.Image = CType(resources.GetObject("btnExportarOsce.Image"), System.Drawing.Image)
        Me.btnExportarOsce.Location = New System.Drawing.Point(906, 12)
        Me.btnExportarOsce.Name = "btnExportarOsce"
        Me.btnExportarOsce.Size = New System.Drawing.Size(83, 36)
        Me.btnExportarOsce.TabIndex = 35
        Me.btnExportarOsce.Text = "Exportar a OSCE"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(19, 32)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(46, 13)
        Me.SaimtLabel2.TabIndex = 29
        Me.SaimtLabel2.Text = "Fecha Fin"
        '
        'btnexportar
        '
        Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportar.Appearance.Options.UseTextOptions = True
        Me.btnexportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.Location = New System.Drawing.Point(995, 12)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(83, 36)
        Me.btnexportar.TabIndex = 32
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(8, 6)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(57, 13)
        Me.SaimtLabel1.TabIndex = 29
        Me.SaimtLabel1.Text = "Fecha Inicio"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.EditValue = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(80, 29)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaFin.TabIndex = 30
        '
        'btnmostrarxfecha
        '
        Me.btnmostrarxfecha.Location = New System.Drawing.Point(209, 8)
        Me.btnmostrarxfecha.Name = "btnmostrarxfecha"
        Me.btnmostrarxfecha.Size = New System.Drawing.Size(87, 21)
        Me.btnmostrarxfecha.TabIndex = 31
        Me.btnmostrarxfecha.Text = "Mostrar X Fecha"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.EditValue = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(80, 3)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaInicio.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaInicio.TabIndex = 30
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Caption = "BarEditItem1"
        Me.BarEditItem2.Edit = Nothing
        Me.BarEditItem2.Id = 4
        Me.BarEditItem2.Name = "BarEditItem2"
        Me.BarEditItem2.Width = 110
        '
        'BarEditItem3
        '
        Me.BarEditItem3.Caption = "BarEditItem1"
        Me.BarEditItem3.Edit = Nothing
        Me.BarEditItem3.Id = 4
        Me.BarEditItem3.Name = "BarEditItem3"
        Me.BarEditItem3.Width = 110
        '
        'beiprogresoO
        '
        Me.beiprogresoO.Caption = "BarEditItem4"
        Me.beiprogresoO.Edit = Me.riprogreso
        Me.beiprogresoO.Id = 4
        Me.beiprogresoO.Name = "beiprogresoO"
        '
        'riprogreso
        '
        Me.riprogreso.Name = "riprogreso"
        '
        'pgcordenesdetalle
        '
        Me.pgcordenesdetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcordenesdetalle.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pgfordId, Me.pgfordNro, Me.pgfordFechaDoc, Me.pgftgEstadoId, Me.pgfordNroCompPago, Me.pgfperProv, Me.pgfperNDoc, Me.pgfordRefDoc, Me.pgftgCuentaDebeId, Me.pgftgCuentaDebe, Me.pgftgCuentaHaberId, Me.pgftgCuentaHaber, Me.pgfpartId, Me.PivotGridField2, Me.pgfordRefCert, Me.PivotGridField1, Me.pgftgFFinancieraId, Me.pgftgMetaId, Me.pgftgActProyId, Me.pgfordImporte, Me.pgfordImporteIGV, Me.pgfordTotal, Me.pgfordDetId, Me.pgfartDescripcion, Me.pgftgUMId, Me.pgfordDetCantidad, Me.pgfordDetPrecio})
        Me.pgcordenesdetalle.Location = New System.Drawing.Point(0, 0)
        Me.pgcordenesdetalle.Name = "pgcordenesdetalle"
        Me.pgcordenesdetalle.Size = New System.Drawing.Size(1094, 587)
        Me.pgcordenesdetalle.TabIndex = 33
        '
        'pgfordId
        '
        Me.pgfordId.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordId.AreaIndex = 0
        Me.pgfordId.Caption = "COD. INF."
        Me.pgfordId.FieldName = "OrdId"
        Me.pgfordId.Name = "pgfordId"
        '
        'pgfordNro
        '
        Me.pgfordNro.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordNro.AreaIndex = 2
        Me.pgfordNro.Caption = "N° O/C"
        Me.pgfordNro.FieldName = "OrdNro"
        Me.pgfordNro.Name = "pgfordNro"
        Me.pgfordNro.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'pgfordFechaDoc
        '
        Me.pgfordFechaDoc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordFechaDoc.AreaIndex = 1
        Me.pgfordFechaDoc.Caption = "FECHA"
        Me.pgfordFechaDoc.FieldName = "OrdFechaDoc"
        Me.pgfordFechaDoc.Name = "pgfordFechaDoc"
        Me.pgfordFechaDoc.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.pgfordFechaDoc.ValueFormat.FormatString = "d"
        Me.pgfordFechaDoc.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'pgftgEstadoId
        '
        Me.pgftgEstadoId.AreaIndex = 8
        Me.pgftgEstadoId.Caption = "ESTADO"
        Me.pgftgEstadoId.FieldName = "TgEstado"
        Me.pgftgEstadoId.Name = "pgftgEstadoId"
        '
        'pgfordNroCompPago
        '
        Me.pgfordNroCompPago.AreaIndex = 11
        Me.pgfordNroCompPago.Caption = "N° COMP. PAGO"
        Me.pgfordNroCompPago.FieldName = "OrdNroCompPago"
        Me.pgfordNroCompPago.Name = "pgfordNroCompPago"
        Me.pgfordNroCompPago.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'pgfperProv
        '
        Me.pgfperProv.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfperProv.AreaIndex = 4
        Me.pgfperProv.Caption = "PROVEDOR"
        Me.pgfperProv.FieldName = "PerProv"
        Me.pgfperProv.Name = "pgfperProv"
        '
        'pgfperNDoc
        '
        Me.pgfperNDoc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfperNDoc.AreaIndex = 3
        Me.pgfperNDoc.Caption = "N° DNI/RUC"
        Me.pgfperNDoc.FieldName = "PerProvNDoc"
        Me.pgfperNDoc.Name = "pgfperNDoc"
        '
        'pgfordRefDoc
        '
        Me.pgfordRefDoc.AreaIndex = 0
        Me.pgfordRefDoc.Caption = "DOC. REF."
        Me.pgfordRefDoc.FieldName = "OrdRefDoc"
        Me.pgfordRefDoc.Name = "pgfordRefDoc"
        '
        'pgftgCuentaDebeId
        '
        Me.pgftgCuentaDebeId.AreaIndex = 1
        Me.pgftgCuentaDebeId.Caption = "CUENTA DEBE"
        Me.pgftgCuentaDebeId.FieldName = "TgCuentaDebeId"
        Me.pgftgCuentaDebeId.Name = "pgftgCuentaDebeId"
        '
        'pgftgCuentaDebe
        '
        Me.pgftgCuentaDebe.AreaIndex = 2
        Me.pgftgCuentaDebe.Caption = "MONTO C. DEBE"
        Me.pgftgCuentaDebe.FieldName = "TgCuentaDebe"
        Me.pgftgCuentaDebe.Name = "pgftgCuentaDebe"
        '
        'pgftgCuentaHaberId
        '
        Me.pgftgCuentaHaberId.AreaIndex = 3
        Me.pgftgCuentaHaberId.Caption = "CUENTA HABER"
        Me.pgftgCuentaHaberId.FieldName = "TgCuentaHaberId"
        Me.pgftgCuentaHaberId.Name = "pgftgCuentaHaberId"
        '
        'pgftgCuentaHaber
        '
        Me.pgftgCuentaHaber.AreaIndex = 9
        Me.pgftgCuentaHaber.Caption = "MONTO C. HABER"
        Me.pgftgCuentaHaber.FieldName = "TgCuentaHaber"
        Me.pgftgCuentaHaber.Name = "pgftgCuentaHaber"
        '
        'pgfpartId
        '
        Me.pgfpartId.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfpartId.AreaIndex = 6
        Me.pgfpartId.Caption = "NRO. PARTIDA"
        Me.pgfpartId.FieldName = "PartId"
        Me.pgfpartId.Name = "pgfpartId"
        Me.pgfpartId.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'PivotGridField2
        '
        Me.PivotGridField2.AreaIndex = 14
        Me.PivotGridField2.Caption = "PARTIDA"
        Me.PivotGridField2.FieldName = "PartNombre"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'pgfordRefCert
        '
        Me.pgfordRefCert.AreaIndex = 0
        Me.pgfordRefCert.Caption = "CER. ID"
        Me.pgfordRefCert.FieldName = "CerId"
        Me.pgfordRefCert.Name = "pgfordRefCert"
        Me.pgfordRefCert.Visible = False
        '
        'PivotGridField1
        '
        Me.PivotGridField1.AreaIndex = 13
        Me.PivotGridField1.Caption = "NRO. CERTIFICACIÓN"
        Me.PivotGridField1.FieldName = "CerNro"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'pgftgFFinancieraId
        '
        Me.pgftgFFinancieraId.AreaIndex = 4
        Me.pgftgFFinancieraId.Caption = "F. FINANCIERA"
        Me.pgftgFFinancieraId.FieldName = "TgFFinancieraId"
        Me.pgftgFFinancieraId.Name = "pgftgFFinancieraId"
        '
        'pgftgMetaId
        '
        Me.pgftgMetaId.AreaIndex = 5
        Me.pgftgMetaId.Caption = "META"
        Me.pgftgMetaId.FieldName = "TgMetaId"
        Me.pgftgMetaId.Name = "pgftgMetaId"
        '
        'pgftgActProyId
        '
        Me.pgftgActProyId.AreaIndex = 6
        Me.pgftgActProyId.Caption = "ACT / PROY"
        Me.pgftgActProyId.FieldName = "TgActProyId"
        Me.pgftgActProyId.Name = "pgftgActProyId"
        '
        'pgfordImporte
        '
        Me.pgfordImporte.AreaIndex = 12
        Me.pgfordImporte.Caption = "IMPORTE"
        Me.pgfordImporte.FieldName = "OrdImporte"
        Me.pgfordImporte.Name = "pgfordImporte"
        Me.pgfordImporte.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'pgfordImporteIGV
        '
        Me.pgfordImporteIGV.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordImporteIGV.AreaIndex = 9
        Me.pgfordImporteIGV.Caption = "IGV"
        Me.pgfordImporteIGV.FieldName = "OrdImporteIGV"
        Me.pgfordImporteIGV.Name = "pgfordImporteIGV"
        '
        'pgfordTotal
        '
        Me.pgfordTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfordTotal.AreaIndex = 0
        Me.pgfordTotal.Caption = "MONTO TOTAL"
        Me.pgfordTotal.FieldName = "OrdTotal"
        Me.pgfordTotal.Name = "pgfordTotal"
        '
        'pgfordDetId
        '
        Me.pgfordDetId.AreaIndex = 7
        Me.pgfordDetId.Caption = "DET. ID."
        Me.pgfordDetId.FieldName = "OrdenCompraDet.OrdDetId"
        Me.pgfordDetId.Name = "pgfordDetId"
        '
        'pgfartDescripcion
        '
        Me.pgfartDescripcion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfartDescripcion.AreaIndex = 5
        Me.pgfartDescripcion.Caption = "ARTICULO"
        Me.pgfartDescripcion.FieldName = "OrdenCompraDet.OArticulo.ArtDescripcion"
        Me.pgfartDescripcion.Name = "pgfartDescripcion"
        '
        'pgftgUMId
        '
        Me.pgftgUMId.AreaIndex = 10
        Me.pgftgUMId.Caption = "U. MEDIDA"
        Me.pgftgUMId.FieldName = "OrdenCompraDet.TgUm"
        Me.pgftgUMId.Name = "pgftgUMId"
        '
        'pgfordDetCantidad
        '
        Me.pgfordDetCantidad.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordDetCantidad.AreaIndex = 7
        Me.pgfordDetCantidad.Caption = "CANTIDAD"
        Me.pgfordDetCantidad.FieldName = "OrdenCompraDet.OrdDetCantidad"
        Me.pgfordDetCantidad.Name = "pgfordDetCantidad"
        '
        'pgfordDetPrecio
        '
        Me.pgfordDetPrecio.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordDetPrecio.AreaIndex = 8
        Me.pgfordDetPrecio.Caption = "PRECIO U."
        Me.pgfordDetPrecio.FieldName = "OrdenCompraDet.OrdDetPrecio"
        Me.pgfordDetPrecio.Name = "pgfordDetPrecio"
        Me.pgfordDetPrecio.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'frmRptPivotOrdenesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 701)
        Me.Controls.Add(Me.pgcordenesdetalle)
        Me.Controls.Add(Me.DockPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmRptPivotOrdenesCompra"
        Me.Text = "Pivot Ordenes de Compra"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.DockPanel1, 0)
        Me.Controls.SetChildIndex(Me.pgcordenesdetalle, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.dtpFechaFin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riprogreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcordenesdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents beiprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents sfdexportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents btnmostrarxfecha As SaimtControles.SaimtButton
    Friend WithEvents dtpFechaInicio As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents beiprogresoO As DevExpress.XtraBars.BarEditItem
    Friend WithEvents riprogreso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents dtpFechaFin As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents pgcordenesdetalle As SaimtControles.SaimtPivotGridControl
    Friend WithEvents pgfordId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordNro As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordFechaDoc As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgEstadoId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordNroCompPago As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordRefCert As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordRefDoc As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgCuentaDebeId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgCuentaDebe As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgCuentaHaberId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgCuentaHaber As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfpartId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgFFinancieraId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgMetaId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgActProyId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordImporte As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordImporteIGV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordTotal As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordDetId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordDetPrecio As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfartDescripcion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgUMId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordDetCantidad As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfperNDoc As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfperProv As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents btnExportarOsce As SaimtControles.SaimtButton
End Class
