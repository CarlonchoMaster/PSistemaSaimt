<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptIngresos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptIngresos))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.btnmostrarxfecha = New SaimtControles.SaimtButton()
        Me.cmbaños = New SaimtControles.SaimtComboBox()
        Me.dtpFechaRecaudacion = New SaimtControles.SaimtDateTimePicker()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.btnmostrarxaño = New SaimtControles.SaimtButton()
        Me.pgcrecaudaciondetalle = New SaimtControles.SaimtPivotGridControl()
        Me.pgffechapago = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcodconcepto = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfpartida = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcentroprod = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfconcepto = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcuentacargo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcuentaabono = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfgrupo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcuentacont = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcuentapres = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfmontopagado = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfporcentajeSAIMT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgIngresoSAIMT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfaño = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfidmes = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfmes = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgIngMuni = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfFechaLiq = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.beiprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.riprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.cmbaños.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecaudacion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecaudacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcrecaudaciondetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riprogreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.beiprogreso)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 726)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(921, 27)
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
        Me.DockPanel1.ID = New System.Guid("d225f211-f126-49f8-990e-a9e3030b23bc")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 639)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 87)
        Me.DockPanel1.Size = New System.Drawing.Size(921, 87)
        Me.DockPanel1.Text = "Datos para Reporte"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.btnexportar)
        Me.DockPanel1_Container.Controls.Add(Me.btnmostrarxfecha)
        Me.DockPanel1_Container.Controls.Add(Me.cmbaños)
        Me.DockPanel1_Container.Controls.Add(Me.dtpFechaRecaudacion)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel1)
        Me.DockPanel1_Container.Controls.Add(Me.btnmostrarxaño)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(913, 60)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'btnexportar
        '
        Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportar.Appearance.Options.UseTextOptions = True
        Me.btnexportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.Location = New System.Drawing.Point(827, 13)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(83, 36)
        Me.btnexportar.TabIndex = 7
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'btnmostrarxfecha
        '
        Me.btnmostrarxfecha.Location = New System.Drawing.Point(198, 28)
        Me.btnmostrarxfecha.Name = "btnmostrarxfecha"
        Me.btnmostrarxfecha.Size = New System.Drawing.Size(87, 21)
        Me.btnmostrarxfecha.TabIndex = 25
        Me.btnmostrarxfecha.Text = "Mostrar X Fecha"
        '
        'cmbaños
        '
        Me.cmbaños.Location = New System.Drawing.Point(40, 2)
        Me.cmbaños.MenuManager = Me.RibbonControl
        Me.cmbaños.Name = "cmbaños"
        Me.cmbaños.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbaños.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbaños.Size = New System.Drawing.Size(148, 20)
        Me.cmbaños.TabIndex = 22
        '
        'dtpFechaRecaudacion
        '
        Me.dtpFechaRecaudacion.EditValue = Nothing
        Me.dtpFechaRecaudacion.Location = New System.Drawing.Point(88, 29)
        Me.dtpFechaRecaudacion.MenuManager = Me.RibbonControl
        Me.dtpFechaRecaudacion.Name = "dtpFechaRecaudacion"
        Me.dtpFechaRecaudacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaRecaudacion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaRecaudacion.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaRecaudacion.TabIndex = 24
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Año"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(8, 32)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(74, 13)
        Me.SaimtLabel1.TabIndex = 23
        Me.SaimtLabel1.Text = "Fecha Deposito"
        '
        'btnmostrarxaño
        '
        Me.btnmostrarxaño.Location = New System.Drawing.Point(198, 1)
        Me.btnmostrarxaño.Name = "btnmostrarxaño"
        Me.btnmostrarxaño.Size = New System.Drawing.Size(87, 23)
        Me.btnmostrarxaño.TabIndex = 21
        Me.btnmostrarxaño.Text = "Mostrar X Año"
        '
        'pgcrecaudaciondetalle
        '
        Me.pgcrecaudaciondetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcrecaudaciondetalle.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pgffechapago, Me.pgfcodconcepto, Me.pgfpartida, Me.pgfcentroprod, Me.pgfconcepto, Me.pgfcuentacargo, Me.pgfcuentaabono, Me.pgfgrupo, Me.pgfcuentacont, Me.pgfcuentapres, Me.pgfmontopagado, Me.pgfporcentajeSAIMT, Me.pgIngresoSAIMT, Me.pgfaño, Me.pgfidmes, Me.pgfmes, Me.pgIngMuni, Me.pgfFechaLiq})
        Me.pgcrecaudaciondetalle.Location = New System.Drawing.Point(0, 0)
        Me.pgcrecaudaciondetalle.Name = "pgcrecaudaciondetalle"
        Me.pgcrecaudaciondetalle.Size = New System.Drawing.Size(921, 639)
        Me.pgcrecaudaciondetalle.TabIndex = 4
        '
        'pgffechapago
        '
        Me.pgffechapago.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgffechapago.AreaIndex = 4
        Me.pgffechapago.Caption = "Fecha Deposito"
        Me.pgffechapago.FieldName = "fechaDeposito"
        Me.pgffechapago.Name = "pgffechapago"
        '
        'pgfcodconcepto
        '
        Me.pgfcodconcepto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfcodconcepto.AreaIndex = 6
        Me.pgfcodconcepto.Caption = "Cod. Concepto"
        Me.pgfcodconcepto.FieldName = "codConcepto"
        Me.pgfcodconcepto.Name = "pgfcodconcepto"
        '
        'pgfpartida
        '
        Me.pgfpartida.AreaIndex = 0
        Me.pgfpartida.Caption = "Cod. Partida"
        Me.pgfpartida.FieldName = "codPartida"
        Me.pgfpartida.Name = "pgfpartida"
        '
        'pgfcentroprod
        '
        Me.pgfcentroprod.AreaIndex = 1
        Me.pgfcentroprod.Caption = "Centro Producción"
        Me.pgfcentroprod.FieldName = "centroProduccion"
        Me.pgfcentroprod.Name = "pgfcentroprod"
        '
        'pgfconcepto
        '
        Me.pgfconcepto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfconcepto.AreaIndex = 7
        Me.pgfconcepto.Caption = "Concepto"
        Me.pgfconcepto.FieldName = "concepto"
        Me.pgfconcepto.Name = "pgfconcepto"
        '
        'pgfcuentacargo
        '
        Me.pgfcuentacargo.AreaIndex = 2
        Me.pgfcuentacargo.Caption = "Cuenta Cargo"
        Me.pgfcuentacargo.FieldName = "cuentaCargo"
        Me.pgfcuentacargo.Name = "pgfcuentacargo"
        '
        'pgfcuentaabono
        '
        Me.pgfcuentaabono.AreaIndex = 3
        Me.pgfcuentaabono.Caption = "Cuenta Abono"
        Me.pgfcuentaabono.FieldName = "cuentaAbono"
        Me.pgfcuentaabono.Name = "pgfcuentaabono"
        '
        'pgfgrupo
        '
        Me.pgfgrupo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfgrupo.AreaIndex = 0
        Me.pgfgrupo.Caption = "Grupo Ingresos"
        Me.pgfgrupo.FieldName = "grupoIngresos"
        Me.pgfgrupo.Name = "pgfgrupo"
        '
        'pgfcuentacont
        '
        Me.pgfcuentacont.AreaIndex = 4
        Me.pgfcuentacont.Caption = "Cuenta Cont. MPT"
        Me.pgfcuentacont.FieldName = "cuentaContMPT"
        Me.pgfcuentacont.Name = "pgfcuentacont"
        '
        'pgfcuentapres
        '
        Me.pgfcuentapres.AreaIndex = 5
        Me.pgfcuentapres.Caption = "Cuenta Pres. MPT"
        Me.pgfcuentapres.FieldName = "cuentaPresMPT"
        Me.pgfcuentapres.Name = "pgfcuentapres"
        '
        'pgfmontopagado
        '
        Me.pgfmontopagado.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfmontopagado.AreaIndex = 0
        Me.pgfmontopagado.Caption = "Monto Pagado"
        Me.pgfmontopagado.FieldName = "montoPagado"
        Me.pgfmontopagado.Name = "pgfmontopagado"
        Me.pgfmontopagado.TotalCellFormat.FormatString = "n2"
        Me.pgfmontopagado.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'pgfporcentajeSAIMT
        '
        Me.pgfporcentajeSAIMT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfporcentajeSAIMT.AreaIndex = 1
        Me.pgfporcentajeSAIMT.Caption = "Porcentaje SAIMT"
        Me.pgfporcentajeSAIMT.FieldName = "porcentajeSAIMT"
        Me.pgfporcentajeSAIMT.Name = "pgfporcentajeSAIMT"
        Me.pgfporcentajeSAIMT.TotalCellFormat.FormatString = "p"
        Me.pgfporcentajeSAIMT.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'pgIngresoSAIMT
        '
        Me.pgIngresoSAIMT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgIngresoSAIMT.AreaIndex = 2
        Me.pgIngresoSAIMT.Caption = "Ingreso SAIMT"
        Me.pgIngresoSAIMT.FieldName = "ingresoSAIMT"
        Me.pgIngresoSAIMT.Name = "pgIngresoSAIMT"
        '
        'pgfaño
        '
        Me.pgfaño.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfaño.AreaIndex = 1
        Me.pgfaño.Caption = "Año"
        Me.pgfaño.FieldName = "año"
        Me.pgfaño.Name = "pgfaño"
        '
        'pgfidmes
        '
        Me.pgfidmes.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfidmes.AreaIndex = 2
        Me.pgfidmes.Caption = "ID Mes"
        Me.pgfidmes.FieldName = "idMes"
        Me.pgfidmes.Name = "pgfidmes"
        '
        'pgfmes
        '
        Me.pgfmes.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfmes.AreaIndex = 3
        Me.pgfmes.Caption = "Mes"
        Me.pgfmes.FieldName = "mes"
        Me.pgfmes.Name = "pgfmes"
        '
        'pgIngMuni
        '
        Me.pgIngMuni.AreaIndex = 6
        Me.pgIngMuni.Caption = "Ingreso Muni"
        Me.pgIngMuni.FieldName = "ingresoMuni"
        Me.pgIngMuni.Name = "pgIngMuni"
        '
        'pgfFechaLiq
        '
        Me.pgfFechaLiq.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfFechaLiq.AreaIndex = 5
        Me.pgfFechaLiq.Caption = "Fecha Liquidación"
        Me.pgfFechaLiq.FieldName = "fechaLiquidacion"
        Me.pgfFechaLiq.Name = "pgfFechaLiq"
        '
        'beiprogreso
        '
        Me.beiprogreso.Caption = "BarEditItem1"
        Me.beiprogreso.Edit = Me.riprogreso
        Me.beiprogreso.Id = 4
        Me.beiprogreso.Name = "beiprogreso"
        Me.beiprogreso.Width = 110
        '
        'riprogreso
        '
        Me.riprogreso.Name = "riprogreso"
        '
        'frmRptIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 753)
        Me.Controls.Add(Me.pgcrecaudaciondetalle)
        Me.Controls.Add(Me.DockPanel1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmRptIngresos"
        Me.Text = "Detalle de los Ingresos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.DockPanel1, 0)
        Me.Controls.SetChildIndex(Me.pgcrecaudaciondetalle, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.cmbaños.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecaudacion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecaudacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcrecaudaciondetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riprogreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents pgcrecaudaciondetalle As SaimtControles.SaimtPivotGridControl
    Friend WithEvents pgffechapago As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcodconcepto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfpartida As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcentroprod As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfconcepto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcuentacargo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcuentaabono As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfgrupo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcuentacont As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcuentapres As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfmontopagado As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfporcentajeSAIMT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgIngresoSAIMT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfaño As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfidmes As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfmes As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgIngMuni As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfFechaLiq As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnmostrarxfecha As SaimtControles.SaimtButton
    Friend WithEvents cmbaños As SaimtControles.SaimtComboBox
    Friend WithEvents dtpFechaRecaudacion As SaimtControles.SaimtDateTimePicker
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents btnmostrarxaño As SaimtControles.SaimtButton
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents beiprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents riprogreso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents sfdexportar As System.Windows.Forms.SaveFileDialog
End Class
