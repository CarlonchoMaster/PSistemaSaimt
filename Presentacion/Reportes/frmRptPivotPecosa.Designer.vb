<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptPivotPecosa

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptPivotPecosa))
        Me.beiprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.btnmostrarxfecha = New SaimtControles.SaimtButton()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.dtpFechaFin = New SaimtControles.SaimtDateTimePicker()
        Me.dtpFechaInicio = New SaimtControles.SaimtDateTimePicker()
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.beiprogresoO = New DevExpress.XtraBars.BarEditItem()
        Me.riprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.pgcSalidaProductodetalle = New SaimtControles.SaimtPivotGridControl()
        Me.pgfpecId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordNro = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfperSolicita = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgArea = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfpecFecha = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcanOrdComDet = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgUm = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfartDescripcion = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfprecOrdComDet = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfpecSubTotal = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgCuentaDebeId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgftgCuentaHaberId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
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
        CType(Me.pgcSalidaProductodetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.beiprogresoO)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 674)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1134, 27)
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
        Me.DockPanel1.ID = New System.Guid("1b5cdf38-2d74-4037-a07d-3162aacd7964")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 584)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 90)
        Me.DockPanel1.Size = New System.Drawing.Size(1134, 90)
        Me.DockPanel1.Text = "Datos para el Reporte"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel2)
        Me.DockPanel1_Container.Controls.Add(Me.btnexportar)
        Me.DockPanel1_Container.Controls.Add(Me.btnmostrarxfecha)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel1)
        Me.DockPanel1_Container.Controls.Add(Me.dtpFechaFin)
        Me.DockPanel1_Container.Controls.Add(Me.dtpFechaInicio)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(1126, 63)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(19, 34)
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
        Me.btnexportar.Location = New System.Drawing.Point(1035, 18)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(83, 36)
        Me.btnexportar.TabIndex = 32
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'btnmostrarxfecha
        '
        Me.btnmostrarxfecha.Location = New System.Drawing.Point(197, 4)
        Me.btnmostrarxfecha.Name = "btnmostrarxfecha"
        Me.btnmostrarxfecha.Size = New System.Drawing.Size(87, 21)
        Me.btnmostrarxfecha.TabIndex = 31
        Me.btnmostrarxfecha.Text = "Mostrar X Fecha"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(8, 8)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(57, 13)
        Me.SaimtLabel1.TabIndex = 29
        Me.SaimtLabel1.Text = "Fecha Inicio"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.EditValue = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(80, 31)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaFin.TabIndex = 30
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.EditValue = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(80, 5)
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
        'pgcSalidaProductodetalle
        '
        Me.pgcSalidaProductodetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcSalidaProductodetalle.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pgfpecId, Me.PivotGridField1, Me.pgfordNro, Me.pgfperSolicita, Me.pgftgArea, Me.pgfpecFecha, Me.pgfcanOrdComDet, Me.pgftgUm, Me.pgfartDescripcion, Me.pgfprecOrdComDet, Me.pgfpecSubTotal, Me.pgftgCuentaDebeId, Me.pgftgCuentaHaberId, Me.PivotGridField2, Me.PivotGridField3})
        Me.pgcSalidaProductodetalle.Location = New System.Drawing.Point(0, 0)
        Me.pgcSalidaProductodetalle.Name = "pgcSalidaProductodetalle"
        Me.pgcSalidaProductodetalle.Size = New System.Drawing.Size(1134, 584)
        Me.pgcSalidaProductodetalle.TabIndex = 33
        '
        'pgfpecId
        '
        Me.pgfpecId.AreaIndex = 9
        Me.pgfpecId.Caption = "Pecosa Id"
        Me.pgfpecId.FieldName = "PecId"
        Me.pgfpecId.Name = "pgfpecId"
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "N° Pecosa"
        Me.PivotGridField1.FieldName = "PecNro"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'pgfordNro
        '
        Me.pgfordNro.AreaIndex = 6
        Me.pgfordNro.Caption = "N° O/C"
        Me.pgfordNro.FieldName = "OrdNro"
        Me.pgfordNro.Name = "pgfordNro"
        Me.pgfordNro.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'pgfperSolicita
        '
        Me.pgfperSolicita.AreaIndex = 8
        Me.pgfperSolicita.Caption = "Persona Solicita"
        Me.pgfperSolicita.FieldName = "PerSolicita"
        Me.pgfperSolicita.Name = "pgfperSolicita"
        '
        'pgftgArea
        '
        Me.pgftgArea.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgftgArea.AreaIndex = 1
        Me.pgftgArea.Caption = "Area Solicita"
        Me.pgftgArea.FieldName = "TgAreaDes"
        Me.pgftgArea.Name = "pgftgArea"
        '
        'pgfpecFecha
        '
        Me.pgfpecFecha.AreaIndex = 7
        Me.pgfpecFecha.Caption = "Fecha Pecosa"
        Me.pgfpecFecha.FieldName = "PecFecha"
        Me.pgfpecFecha.Name = "pgfpecFecha"
        '
        'pgfcanOrdComDet
        '
        Me.pgfcanOrdComDet.AreaIndex = 0
        Me.pgfcanOrdComDet.Caption = "Cantidad"
        Me.pgfcanOrdComDet.FieldName = "pecDetCanTotal"
        Me.pgfcanOrdComDet.Name = "pgfcanOrdComDet"
        '
        'pgftgUm
        '
        Me.pgftgUm.AreaIndex = 1
        Me.pgftgUm.Caption = "U. Medida"
        Me.pgftgUm.FieldName = "TgUm"
        Me.pgftgUm.Name = "pgftgUm"
        '
        'pgfartDescripcion
        '
        Me.pgfartDescripcion.AreaIndex = 2
        Me.pgfartDescripcion.Caption = "Articulo"
        Me.pgfartDescripcion.FieldName = "ArtDescripcion"
        Me.pgfartDescripcion.Name = "pgfartDescripcion"
        '
        'pgfprecOrdComDet
        '
        Me.pgfprecOrdComDet.AreaIndex = 3
        Me.pgfprecOrdComDet.Caption = "Precio"
        Me.pgfprecOrdComDet.FieldName = "pecDetPrecioUnit"
        Me.pgfprecOrdComDet.Name = "pgfprecOrdComDet"
        '
        'pgfpecSubTotal
        '
        Me.pgfpecSubTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfpecSubTotal.AreaIndex = 0
        Me.pgfpecSubTotal.Caption = "Sub Total"
        Me.pgfpecSubTotal.FieldName = "PecSubTotal"
        Me.pgfpecSubTotal.Name = "pgfpecSubTotal"
        '
        'pgftgCuentaDebeId
        '
        Me.pgftgCuentaDebeId.AreaIndex = 4
        Me.pgftgCuentaDebeId.Caption = "Cuenta Debe"
        Me.pgftgCuentaDebeId.FieldName = "TgCuentaDebeId"
        Me.pgftgCuentaDebeId.Name = "pgftgCuentaDebeId"
        '
        'pgftgCuentaHaberId
        '
        Me.pgftgCuentaHaberId.AreaIndex = 5
        Me.pgftgCuentaHaberId.Caption = "Cuenta Haber"
        Me.pgftgCuentaHaberId.FieldName = "TgCuentaHaberId"
        Me.pgftgCuentaHaberId.Name = "pgftgCuentaHaberId"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.AreaIndex = 10
        Me.PivotGridField2.Caption = "Descripción"
        Me.PivotGridField2.FieldName = "pecDescripcion"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.AreaIndex = 11
        Me.PivotGridField3.Caption = "Nro de Certificación"
        Me.PivotGridField3.FieldName = "cerNro"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'frmRptPivotPecosa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 701)
        Me.Controls.Add(Me.pgcSalidaProductodetalle)
        Me.Controls.Add(Me.DockPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmRptPivotPecosa"
        Me.Text = "Pivot Salida Articulos Almacen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.DockPanel1, 0)
        Me.Controls.SetChildIndex(Me.pgcSalidaProductodetalle, 0)
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
        CType(Me.pgcSalidaProductodetalle, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pgcSalidaProductodetalle As SaimtControles.SaimtPivotGridControl
    Friend WithEvents pgfpecId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordNro As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgArea As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfperSolicita As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfpecFecha As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcanOrdComDet As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgUm As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfartDescripcion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfprecOrdComDet As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfpecSubTotal As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgCuentaDebeId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgftgCuentaHaberId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
End Class
