<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPivotearRinconada
    Inherits frmGeneral

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPivotearRinconada))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.btnMostrarXFecha = New SaimtControles.SaimtButton()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.cboMensual = New SaimtControles.SaimtComboBoxLookUp()
        Me.dtpFinIntervalo = New SaimtControles.SaimtDateTimePicker()
        Me.dtpInicioIntervalo = New SaimtControles.SaimtDateTimePicker()
        Me.dtpDiario = New SaimtControles.SaimtDateTimePicker()
        Me.rdgFechas = New SaimtControles.SaimtRadioGroup()
        Me.pgcPivotearPEM = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.sfdDescargar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.cboMensual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFinIntervalo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFinIntervalo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpInicioIntervalo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpInicioIntervalo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDiario.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcPivotearPEM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 708)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1013, 27)
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
        Me.DockPanel1.ID = New System.Guid("0e7205f9-26e1-4e8f-94a6-0da403fe6f4b")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 558)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 150)
        Me.DockPanel1.Size = New System.Drawing.Size(1013, 150)
        Me.DockPanel1.Text = "Opciones de Reporte"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.btnMostrarXFecha)
        Me.DockPanel1_Container.Controls.Add(Me.btnexportar)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtGroupBox1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(1005, 123)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'btnMostrarXFecha
        '
        Me.btnMostrarXFecha.Location = New System.Drawing.Point(287, 32)
        Me.btnMostrarXFecha.Name = "btnMostrarXFecha"
        Me.btnMostrarXFecha.Size = New System.Drawing.Size(93, 32)
        Me.btnMostrarXFecha.TabIndex = 1
        Me.btnMostrarXFecha.Text = "Mostrar x Fecha"
        '
        'btnexportar
        '
        Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportar.Appearance.Options.UseTextOptions = True
        Me.btnexportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.Location = New System.Drawing.Point(920, 85)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(83, 36)
        Me.btnexportar.TabIndex = 2
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.cboMensual)
        Me.SaimtGroupBox1.Controls.Add(Me.dtpFinIntervalo)
        Me.SaimtGroupBox1.Controls.Add(Me.dtpInicioIntervalo)
        Me.SaimtGroupBox1.Controls.Add(Me.dtpDiario)
        Me.SaimtGroupBox1.Controls.Add(Me.rdgFechas)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(5, 0)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(276, 109)
        Me.SaimtGroupBox1.TabIndex = 0
        Me.SaimtGroupBox1.Text = "Selección de Fechas"
        '
        'cboMensual
        '
        Me.cboMensual.Location = New System.Drawing.Point(82, 81)
        Me.cboMensual.MenuManager = Me.RibbonControl
        Me.cboMensual.Name = "cboMensual"
        Me.cboMensual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMensual.Properties.NullText = ""
        Me.cboMensual.Size = New System.Drawing.Size(136, 20)
        Me.cboMensual.TabIndex = 4
        '
        'dtpFinIntervalo
        '
        Me.dtpFinIntervalo.EditValue = Nothing
        Me.dtpFinIntervalo.Location = New System.Drawing.Point(179, 55)
        Me.dtpFinIntervalo.MenuManager = Me.RibbonControl
        Me.dtpFinIntervalo.Name = "dtpFinIntervalo"
        Me.dtpFinIntervalo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFinIntervalo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFinIntervalo.Size = New System.Drawing.Size(84, 20)
        Me.dtpFinIntervalo.TabIndex = 3
        '
        'dtpInicioIntervalo
        '
        Me.dtpInicioIntervalo.EditValue = Nothing
        Me.dtpInicioIntervalo.Location = New System.Drawing.Point(82, 55)
        Me.dtpInicioIntervalo.MenuManager = Me.RibbonControl
        Me.dtpInicioIntervalo.Name = "dtpInicioIntervalo"
        Me.dtpInicioIntervalo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpInicioIntervalo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpInicioIntervalo.Size = New System.Drawing.Size(84, 20)
        Me.dtpInicioIntervalo.TabIndex = 2
        '
        'dtpDiario
        '
        Me.dtpDiario.EditValue = Nothing
        Me.dtpDiario.Location = New System.Drawing.Point(82, 29)
        Me.dtpDiario.MenuManager = Me.RibbonControl
        Me.dtpDiario.Name = "dtpDiario"
        Me.dtpDiario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDiario.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDiario.Size = New System.Drawing.Size(111, 20)
        Me.dtpDiario.TabIndex = 1
        '
        'rdgFechas
        '
        Me.rdgFechas.Dock = System.Windows.Forms.DockStyle.Left
        Me.rdgFechas.EditValue = CType(0, Short)
        Me.rdgFechas.Location = New System.Drawing.Point(2, 21)
        Me.rdgFechas.MenuManager = Me.RibbonControl
        Me.rdgFechas.Name = "rdgFechas"
        Me.rdgFechas.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rdgFechas.Properties.Appearance.Options.UseBackColor = True
        Me.rdgFechas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdgFechas.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Diario"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Intervalo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Mensual")})
        Me.rdgFechas.Size = New System.Drawing.Size(76, 86)
        Me.rdgFechas.TabIndex = 0
        '
        'pgcPivotearPEM
        '
        Me.pgcPivotearPEM.AppearancePrint.Cell.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.Cell.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.Cell.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.Cell.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.Cell.Options.UseBorderColor = True
        Me.pgcPivotearPEM.AppearancePrint.CustomTotalCell.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.CustomTotalCell.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.CustomTotalCell.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.CustomTotalCell.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.CustomTotalCell.Options.UseBorderColor = True
        Me.pgcPivotearPEM.AppearancePrint.FieldHeader.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.FieldHeader.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.FieldHeader.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.FieldHeader.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.FieldHeader.Options.UseBorderColor = True
        Me.pgcPivotearPEM.AppearancePrint.FieldValue.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.FieldValue.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.FieldValue.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.FieldValue.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.FieldValue.Options.UseBorderColor = True
        Me.pgcPivotearPEM.AppearancePrint.FieldValueGrandTotal.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.FieldValueGrandTotal.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.FieldValueGrandTotal.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.FieldValueGrandTotal.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.FieldValueGrandTotal.Options.UseBorderColor = True
        Me.pgcPivotearPEM.AppearancePrint.FieldValueTotal.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.FieldValueTotal.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.FieldValueTotal.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.FieldValueTotal.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.FieldValueTotal.Options.UseBorderColor = True
        Me.pgcPivotearPEM.AppearancePrint.FilterSeparator.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.FilterSeparator.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.FilterSeparator.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.FilterSeparator.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.FilterSeparator.Options.UseBorderColor = True
        Me.pgcPivotearPEM.AppearancePrint.GrandTotalCell.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.GrandTotalCell.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.GrandTotalCell.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.GrandTotalCell.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.GrandTotalCell.Options.UseBorderColor = True
        Me.pgcPivotearPEM.AppearancePrint.HeaderGroupLine.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.HeaderGroupLine.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.HeaderGroupLine.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.HeaderGroupLine.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.HeaderGroupLine.Options.UseBorderColor = True
        Me.pgcPivotearPEM.AppearancePrint.Lines.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.Lines.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.Lines.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.Lines.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.Lines.Options.UseBorderColor = True
        Me.pgcPivotearPEM.AppearancePrint.TotalCell.BackColor = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.TotalCell.BackColor2 = System.Drawing.Color.White
        Me.pgcPivotearPEM.AppearancePrint.TotalCell.BorderColor = System.Drawing.Color.Black
        Me.pgcPivotearPEM.AppearancePrint.TotalCell.Options.UseBackColor = True
        Me.pgcPivotearPEM.AppearancePrint.TotalCell.Options.UseBorderColor = True
        Me.pgcPivotearPEM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcPivotearPEM.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField12, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16})
        Me.pgcPivotearPEM.Location = New System.Drawing.Point(0, 0)
        Me.pgcPivotearPEM.Name = "pgcPivotearPEM"
        Me.pgcPivotearPEM.OptionsPrint.PageSettings.Margins = New System.Drawing.Printing.Margins(20, 20, 20, 20)
        Me.pgcPivotearPEM.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.pgcPivotearPEM.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.pgcPivotearPEM.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.pgcPivotearPEM.OptionsPrint.UsePrintAppearance = True
        Me.pgcPivotearPEM.Size = New System.Drawing.Size(1013, 558)
        Me.pgcPivotearPEM.TabIndex = 0
        '
        'PivotGridField1
        '
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "N° Ticket"
        Me.PivotGridField1.FieldName = "NroTicket"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.Caption = "Placa"
        Me.PivotGridField2.FieldName = "Placa"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.AreaIndex = 2
        Me.PivotGridField3.Caption = "Fecha Ingreso"
        Me.PivotGridField3.FieldName = "FechaInicio"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.AreaIndex = 3
        Me.PivotGridField4.Caption = "Fecha Término"
        Me.PivotGridField4.FieldName = "FechaTermino"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField5.AreaIndex = 0
        Me.PivotGridField5.Caption = "Importe"
        Me.PivotGridField5.FieldName = "Importe"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.AreaIndex = 4
        Me.PivotGridField6.Caption = "Estado Diario"
        Me.PivotGridField6.FieldName = "EstadoDiario"
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.AreaIndex = 5
        Me.PivotGridField7.Caption = "Hora Entrada"
        Me.PivotGridField7.FieldName = "HoraIngreso"
        Me.PivotGridField7.Name = "PivotGridField7"
        '
        'PivotGridField8
        '
        Me.PivotGridField8.AreaIndex = 6
        Me.PivotGridField8.Caption = "Hora Salida"
        Me.PivotGridField8.FieldName = "HoraSalida"
        Me.PivotGridField8.Name = "PivotGridField8"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField9.AreaIndex = 2
        Me.PivotGridField9.Caption = "Usuario ID"
        Me.PivotGridField9.FieldName = "TipoUsuario"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField10.AreaIndex = 4
        Me.PivotGridField10.Caption = "Concepto"
        Me.PivotGridField10.FieldName = "Concepto"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField11.AreaIndex = 3
        Me.PivotGridField11.Caption = "Fecha Pago"
        Me.PivotGridField11.FieldName = "FechaPago"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'PivotGridField12
        '
        Me.PivotGridField12.AreaIndex = 7
        Me.PivotGridField12.Caption = "Hora Pago"
        Me.PivotGridField12.FieldName = "HoraPago"
        Me.PivotGridField12.Name = "PivotGridField12"
        '
        'PivotGridField13
        '
        Me.PivotGridField13.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField13.AreaIndex = 0
        Me.PivotGridField13.Caption = "Año"
        Me.PivotGridField13.FieldName = "Año"
        Me.PivotGridField13.Name = "PivotGridField13"
        '
        'PivotGridField14
        '
        Me.PivotGridField14.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField14.AreaIndex = 1
        Me.PivotGridField14.Caption = "Mes"
        Me.PivotGridField14.FieldName = "Mes"
        Me.PivotGridField14.Name = "PivotGridField14"
        '
        'PivotGridField15
        '
        Me.PivotGridField15.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField15.AreaIndex = 1
        Me.PivotGridField15.Caption = "Nro. Tickets"
        Me.PivotGridField15.FieldName = "NroPlaca"
        Me.PivotGridField15.Name = "PivotGridField15"
        '
        'PivotGridField16
        '
        Me.PivotGridField16.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField16.AreaIndex = 2
        Me.PivotGridField16.Caption = "Nro. Personas"
        Me.PivotGridField16.FieldName = "CantPers"
        Me.PivotGridField16.Name = "PivotGridField16"
        '
        'frmPivotearRinconada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 735)
        Me.Controls.Add(Me.pgcPivotearPEM)
        Me.Controls.Add(Me.DockPanel1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmPivotearRinconada"
        Me.Tag = "btiPivotearPorConceptos"
        Me.Text = "PIVOTEAR POR CONCEPTOS"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.DockPanel1, 0)
        Me.Controls.SetChildIndex(Me.pgcPivotearPEM, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.cboMensual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFinIntervalo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFinIntervalo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpInicioIntervalo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpInicioIntervalo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDiario.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcPivotearPEM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents pgcPivotearPEM As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents cboMensual As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents dtpFinIntervalo As SaimtControles.SaimtDateTimePicker
    Friend WithEvents dtpInicioIntervalo As SaimtControles.SaimtDateTimePicker
    Friend WithEvents dtpDiario As SaimtControles.SaimtDateTimePicker
    Friend WithEvents rdgFechas As SaimtControles.SaimtRadioGroup
    Friend WithEvents btnMostrarXFecha As SaimtControles.SaimtButton
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents sfdDescargar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
End Class
