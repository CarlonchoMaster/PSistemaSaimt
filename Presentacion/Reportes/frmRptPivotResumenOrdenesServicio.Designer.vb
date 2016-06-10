<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptPivotResumenOrdenesServicio

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptPivotResumenOrdenesServicio))
        Me.beiprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
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
        Me.pgfordFechaDoc = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordNro = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordNroCompPago = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfperProv = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordDetDescripcion = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfpartId = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordImporte = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordDetImporteIGV = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfordDetTotal = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
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
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1178, 27)
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
        Me.DockPanel1.ID = New System.Guid("c623e882-07df-4146-a3cd-1acdad63aeb5")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 586)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 88)
        Me.DockPanel1.Size = New System.Drawing.Size(1178, 88)
        Me.DockPanel1.Text = "Datos para el Reporte"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel2)
        Me.DockPanel1_Container.Controls.Add(Me.btnexportar)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel1)
        Me.DockPanel1_Container.Controls.Add(Me.dtpFechaFin)
        Me.DockPanel1_Container.Controls.Add(Me.btnmostrarxfecha)
        Me.DockPanel1_Container.Controls.Add(Me.dtpFechaInicio)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(1170, 61)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(21, 36)
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
        Me.btnexportar.Location = New System.Drawing.Point(1079, 17)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(83, 36)
        Me.btnexportar.TabIndex = 32
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(10, 10)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(57, 13)
        Me.SaimtLabel1.TabIndex = 29
        Me.SaimtLabel1.Text = "Fecha Inicio"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.EditValue = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(82, 33)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaFin.TabIndex = 30
        '
        'btnmostrarxfecha
        '
        Me.btnmostrarxfecha.Location = New System.Drawing.Point(197, 6)
        Me.btnmostrarxfecha.Name = "btnmostrarxfecha"
        Me.btnmostrarxfecha.Size = New System.Drawing.Size(91, 21)
        Me.btnmostrarxfecha.TabIndex = 31
        Me.btnmostrarxfecha.Text = "Mostrar X Fecha"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.EditValue = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(82, 7)
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
        Me.pgcordenesdetalle.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pgfordId, Me.pgfordFechaDoc, Me.pgfordNro, Me.PivotGridField2, Me.pgfordNroCompPago, Me.pgfperProv, Me.pgfordDetDescripcion, Me.pgfpartId, Me.pgfordImporte, Me.pgfordDetImporteIGV, Me.PivotGridField3, Me.pgfordDetTotal, Me.PivotGridField1})
        Me.pgcordenesdetalle.Location = New System.Drawing.Point(0, 0)
        Me.pgcordenesdetalle.Name = "pgcordenesdetalle"
        Me.pgcordenesdetalle.Size = New System.Drawing.Size(1178, 586)
        Me.pgcordenesdetalle.TabIndex = 33
        '
        'pgfordId
        '
        Me.pgfordId.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordId.AreaIndex = 0
        Me.pgfordId.Caption = "N°"
        Me.pgfordId.FieldName = "Item"
        Me.pgfordId.Name = "pgfordId"
        '
        'pgfordFechaDoc
        '
        Me.pgfordFechaDoc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordFechaDoc.AreaIndex = 1
        Me.pgfordFechaDoc.Caption = "DÍA"
        Me.pgfordFechaDoc.FieldName = "OrdDia"
        Me.pgfordFechaDoc.Name = "pgfordFechaDoc"
        Me.pgfordFechaDoc.ValueFormat.FormatString = "d"
        Me.pgfordFechaDoc.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'pgfordNro
        '
        Me.pgfordNro.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordNro.AreaIndex = 2
        Me.pgfordNro.Caption = "N° O/S"
        Me.pgfordNro.FieldName = "OrdNro"
        Me.pgfordNro.Name = "pgfordNro"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField2.AreaIndex = 3
        Me.PivotGridField2.Caption = "RUC"
        Me.PivotGridField2.FieldName = "PerProvNDoc"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'pgfordNroCompPago
        '
        Me.pgfordNroCompPago.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordNroCompPago.AreaIndex = 4
        Me.pgfordNroCompPago.Caption = "N° DE DOCUMENTO"
        Me.pgfordNroCompPago.FieldName = "OrdNroCompPago"
        Me.pgfordNroCompPago.Name = "pgfordNroCompPago"
        '
        'pgfperProv
        '
        Me.pgfperProv.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfperProv.AreaIndex = 5
        Me.pgfperProv.Caption = "NOMBRE DEL PROVEEDOR"
        Me.pgfperProv.FieldName = "PerProv"
        Me.pgfperProv.Name = "pgfperProv"
        '
        'pgfordDetDescripcion
        '
        Me.pgfordDetDescripcion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfordDetDescripcion.AreaIndex = 6
        Me.pgfordDetDescripcion.Caption = "DESCRIPCIÓN DEL SERVICIO"
        Me.pgfordDetDescripcion.FieldName = "OrdenServicioDet.OrdDetDescripcion"
        Me.pgfordDetDescripcion.Name = "pgfordDetDescripcion"
        '
        'pgfpartId
        '
        Me.pgfpartId.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfpartId.AreaIndex = 7
        Me.pgfpartId.Caption = "PARTIDA PRESUPUESTAL"
        Me.pgfpartId.FieldName = "PartId"
        Me.pgfpartId.Name = "pgfpartId"
        '
        'pgfordImporte
        '
        Me.pgfordImporte.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfordImporte.AreaIndex = 0
        Me.pgfordImporte.Caption = "IMPORTE"
        Me.pgfordImporte.FieldName = "OrdImporte"
        Me.pgfordImporte.Name = "pgfordImporte"
        '
        'pgfordDetImporteIGV
        '
        Me.pgfordDetImporteIGV.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfordDetImporteIGV.AreaIndex = 1
        Me.pgfordDetImporteIGV.Caption = "IGV"
        Me.pgfordDetImporteIGV.FieldName = "OrdImporteIGV"
        Me.pgfordDetImporteIGV.Name = "pgfordDetImporteIGV"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField3.AreaIndex = 2
        Me.PivotGridField3.Caption = "DETRACCIÓN"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'pgfordDetTotal
        '
        Me.pgfordDetTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfordDetTotal.AreaIndex = 3
        Me.pgfordDetTotal.Caption = "TOTAL"
        Me.pgfordDetTotal.FieldName = "OrdTotal"
        Me.pgfordDetTotal.Name = "pgfordDetTotal"
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField1.AreaIndex = 4
        Me.PivotGridField1.Caption = "NETO PAGADO"
        Me.PivotGridField1.FieldName = "OrdNetoPagado"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'frmRptPivotResumenOrdenesServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 701)
        Me.Controls.Add(Me.pgcordenesdetalle)
        Me.Controls.Add(Me.DockPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmRptPivotResumenOrdenesServicio"
        Me.Text = "Pivot Ordenes de Servicio"
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
    Friend WithEvents pgfordNroCompPago As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfpartId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordImporte As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordDetImporteIGV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordDetTotal As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfperProv As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfordDetDescripcion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
End Class
