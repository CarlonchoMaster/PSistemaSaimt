﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptReSatt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptReSatt))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.cmbgrupoingreso = New SaimtControles.SaimtComboBoxLookUp()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnmostrarxfecha = New SaimtControles.SaimtButton()
        Me.dtpFechaRecaudacion = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.btnmostrardet = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbaños = New SaimtControles.SaimtComboBox()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.btnverreporte = New SaimtControles.SaimtButton()
        Me.cmbreportes = New SaimtControles.SaimtComboBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnmostrarxaño = New SaimtControles.SaimtButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.pgcrecaudacion = New SaimtControles.SaimtPivotGridControl()
        Me.pgffechapago = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfnroorden = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcodconcepto = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfpartida = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcentroprod = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfconcepto = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcuentabanco = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcuentacargo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcuentaabono = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfgrupo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcuentacont = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfcuentapres = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfnro = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfnrodoc = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfpersona = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfmontopagado = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfporcentajeSAIMT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfingresoSAIMT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfingresorec = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfporcrecaudacion = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfneto = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfrecaudadora = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfaño = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfidmes = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgfmes = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgIngMuni = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        Me.beiprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.ripprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.cmbgrupoingreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecaudacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecaudacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbaños.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbreportes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcrecaudacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ripprogreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.beiprogreso)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 726)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1006, 27)
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
        Me.DockPanel1.FloatVertical = True
        Me.DockPanel1.ID = New System.Guid("c23c4f91-23ae-4b7a-bea0-29549ae11360")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 636)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 90)
        Me.DockPanel1.Size = New System.Drawing.Size(1006, 90)
        Me.DockPanel1.Text = "Datos para Reporte"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.cmbgrupoingreso)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel1_Container.Controls.Add(Me.btnmostrarxfecha)
        Me.DockPanel1_Container.Controls.Add(Me.dtpFechaRecaudacion)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel1)
        Me.DockPanel1_Container.Controls.Add(Me.btnmostrardet)
        Me.DockPanel1_Container.Controls.Add(Me.cmbaños)
        Me.DockPanel1_Container.Controls.Add(Me.btnexportar)
        Me.DockPanel1_Container.Controls.Add(Me.btnverreporte)
        Me.DockPanel1_Container.Controls.Add(Me.cmbreportes)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.btnmostrarxaño)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(998, 63)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'cmbgrupoingreso
        '
        Me.cmbgrupoingreso.Location = New System.Drawing.Point(390, 30)
        Me.cmbgrupoingreso.MenuManager = Me.RibbonControl
        Me.cmbgrupoingreso.Name = "cmbgrupoingreso"
        Me.cmbgrupoingreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbgrupoingreso.Properties.NullText = ""
        Me.cmbgrupoingreso.Size = New System.Drawing.Size(312, 20)
        Me.cmbgrupoingreso.TabIndex = 21
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(300, 33)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Grupo de Ingreso"
        '
        'btnmostrarxfecha
        '
        Me.btnmostrarxfecha.Location = New System.Drawing.Point(193, 29)
        Me.btnmostrarxfecha.Name = "btnmostrarxfecha"
        Me.btnmostrarxfecha.Size = New System.Drawing.Size(87, 23)
        Me.btnmostrarxfecha.TabIndex = 19
        Me.btnmostrarxfecha.Text = "Mostrar X Fecha"
        '
        'dtpFechaRecaudacion
        '
        Me.dtpFechaRecaudacion.EditValue = Nothing
        Me.dtpFechaRecaudacion.Location = New System.Drawing.Point(83, 30)
        Me.dtpFechaRecaudacion.MenuManager = Me.RibbonControl
        Me.dtpFechaRecaudacion.Name = "dtpFechaRecaudacion"
        Me.dtpFechaRecaudacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaRecaudacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaRecaudacion.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaRecaudacion.TabIndex = 18
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(3, 33)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(74, 13)
        Me.SaimtLabel1.TabIndex = 17
        Me.SaimtLabel1.Text = "Fecha Deposito"
        '
        'btnmostrardet
        '
        Me.btnmostrardet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmostrardet.Appearance.Options.UseTextOptions = True
        Me.btnmostrardet.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnmostrardet.Image = CType(resources.GetObject("btnmostrardet.Image"), System.Drawing.Image)
        Me.btnmostrardet.Location = New System.Drawing.Point(826, 24)
        Me.btnmostrardet.Name = "btnmostrardet"
        Me.btnmostrardet.Size = New System.Drawing.Size(78, 36)
        Me.btnmostrardet.TabIndex = 16
        Me.btnmostrardet.Text = "Mostrar Detalle"
        '
        'cmbaños
        '
        Me.cmbaños.Location = New System.Drawing.Point(35, 3)
        Me.cmbaños.MenuManager = Me.RibbonControl
        Me.cmbaños.Name = "cmbaños"
        Me.cmbaños.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbaños.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbaños.Size = New System.Drawing.Size(148, 20)
        Me.cmbaños.TabIndex = 7
        '
        'btnexportar
        '
        Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportar.Appearance.Options.UseTextOptions = True
        Me.btnexportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.Location = New System.Drawing.Point(910, 24)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(83, 36)
        Me.btnexportar.TabIndex = 6
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'btnverreporte
        '
        Me.btnverreporte.Location = New System.Drawing.Point(713, 2)
        Me.btnverreporte.Name = "btnverreporte"
        Me.btnverreporte.Size = New System.Drawing.Size(75, 23)
        Me.btnverreporte.TabIndex = 5
        Me.btnverreporte.Text = "Ver Reporte"
        '
        'cmbreportes
        '
        Me.cmbreportes.EditValue = "Reporte Contable Formato Nº 1"
        Me.cmbreportes.Location = New System.Drawing.Point(350, 3)
        Me.cmbreportes.MenuManager = Me.RibbonControl
        Me.cmbreportes.Name = "cmbreportes"
        Me.cmbreportes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbreportes.Properties.Items.AddRange(New Object() {"Reporte Contable Formato Nº 1", "Reporte Contable Formato Nº 2"})
        Me.cmbreportes.Size = New System.Drawing.Size(352, 20)
        Me.cmbreportes.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(300, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Reportes"
        '
        'btnmostrarxaño
        '
        Me.btnmostrarxaño.Location = New System.Drawing.Point(193, 2)
        Me.btnmostrarxaño.Name = "btnmostrarxaño"
        Me.btnmostrarxaño.Size = New System.Drawing.Size(87, 23)
        Me.btnmostrarxaño.TabIndex = 2
        Me.btnmostrarxaño.Text = "Mostrar X Año"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Año"
        '
        'pgcrecaudacion
        '
        Me.pgcrecaudacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcrecaudacion.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pgffechapago, Me.pgfnroorden, Me.pgfcodconcepto, Me.pgfpartida, Me.pgfcentroprod, Me.pgfconcepto, Me.pgfcuentabanco, Me.pgfcuentacargo, Me.pgfcuentaabono, Me.pgfgrupo, Me.pgfcuentacont, Me.pgfcuentapres, Me.pgfnro, Me.pgfnrodoc, Me.pgfpersona, Me.pgfmontopagado, Me.pgfporcentajeSAIMT, Me.pgfingresoSAIMT, Me.pgfingresorec, Me.pgfporcrecaudacion, Me.pgfneto, Me.pgfrecaudadora, Me.pgfaño, Me.pgfidmes, Me.pgfmes, Me.pgIngMuni})
        Me.pgcrecaudacion.Location = New System.Drawing.Point(0, 0)
        Me.pgcrecaudacion.Name = "pgcrecaudacion"
        Me.pgcrecaudacion.Size = New System.Drawing.Size(1006, 636)
        Me.pgcrecaudacion.TabIndex = 3
        '
        'pgffechapago
        '
        Me.pgffechapago.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgffechapago.AreaIndex = 4
        Me.pgffechapago.Caption = "Fecha Deposito"
        Me.pgffechapago.FieldName = "recFecPago"
        Me.pgffechapago.Name = "pgffechapago"
        '
        'pgfnroorden
        '
        Me.pgfnroorden.AreaIndex = 0
        Me.pgfnroorden.Caption = "Nro. Orden"
        Me.pgfnroorden.FieldName = "recNroOrden"
        Me.pgfnroorden.Name = "pgfnroorden"
        '
        'pgfcodconcepto
        '
        Me.pgfcodconcepto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfcodconcepto.AreaIndex = 5
        Me.pgfcodconcepto.Caption = "Cod. Concepto"
        Me.pgfcodconcepto.FieldName = "conId"
        Me.pgfcodconcepto.Name = "pgfcodconcepto"
        '
        'pgfpartida
        '
        Me.pgfpartida.AreaIndex = 1
        Me.pgfpartida.Caption = "Cod. Partida"
        Me.pgfpartida.FieldName = "partId"
        Me.pgfpartida.Name = "pgfpartida"
        '
        'pgfcentroprod
        '
        Me.pgfcentroprod.AreaIndex = 2
        Me.pgfcentroprod.Caption = "Centro Producción"
        Me.pgfcentroprod.FieldName = "CentroProd"
        Me.pgfcentroprod.Name = "pgfcentroprod"
        '
        'pgfconcepto
        '
        Me.pgfconcepto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfconcepto.AreaIndex = 6
        Me.pgfconcepto.Caption = "Concepto"
        Me.pgfconcepto.FieldName = "conNombre"
        Me.pgfconcepto.Name = "pgfconcepto"
        '
        'pgfcuentabanco
        '
        Me.pgfcuentabanco.AreaIndex = 3
        Me.pgfcuentabanco.Caption = "Cuenta Banco"
        Me.pgfcuentabanco.FieldName = "tgCueBanId"
        Me.pgfcuentabanco.Name = "pgfcuentabanco"
        '
        'pgfcuentacargo
        '
        Me.pgfcuentacargo.AreaIndex = 4
        Me.pgfcuentacargo.Caption = "Cuenta Cargo"
        Me.pgfcuentacargo.FieldName = "pcontCuenC"
        Me.pgfcuentacargo.Name = "pgfcuentacargo"
        '
        'pgfcuentaabono
        '
        Me.pgfcuentaabono.AreaIndex = 5
        Me.pgfcuentaabono.Caption = "Cuenta Abono"
        Me.pgfcuentaabono.FieldName = "pcontCuenA"
        Me.pgfcuentaabono.Name = "pgfcuentaabono"
        '
        'pgfgrupo
        '
        Me.pgfgrupo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfgrupo.AreaIndex = 0
        Me.pgfgrupo.Caption = "Grupo Ingresos"
        Me.pgfgrupo.FieldName = "Grupo"
        Me.pgfgrupo.Name = "pgfgrupo"
        '
        'pgfcuentacont
        '
        Me.pgfcuentacont.AreaIndex = 6
        Me.pgfcuentacont.Caption = "Cuenta Cont. MPT"
        Me.pgfcuentacont.FieldName = "conCodConMPT"
        Me.pgfcuentacont.Name = "pgfcuentacont"
        '
        'pgfcuentapres
        '
        Me.pgfcuentapres.AreaIndex = 7
        Me.pgfcuentapres.Caption = "Cuenta Pres. MPT"
        Me.pgfcuentapres.FieldName = "conCodPresMPT"
        Me.pgfcuentapres.Name = "pgfcuentapres"
        '
        'pgfnro
        '
        Me.pgfnro.AreaIndex = 8
        Me.pgfnro.Caption = "Nro."
        Me.pgfnro.FieldName = "recNro"
        Me.pgfnro.Name = "pgfnro"
        '
        'pgfnrodoc
        '
        Me.pgfnrodoc.AreaIndex = 9
        Me.pgfnrodoc.Caption = "Nro. Doc"
        Me.pgfnrodoc.FieldName = "perNroDoc"
        Me.pgfnrodoc.Name = "pgfnrodoc"
        '
        'pgfpersona
        '
        Me.pgfpersona.AreaIndex = 11
        Me.pgfpersona.Caption = "Persona"
        Me.pgfpersona.FieldName = "perNombre"
        Me.pgfpersona.Name = "pgfpersona"
        '
        'pgfmontopagado
        '
        Me.pgfmontopagado.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfmontopagado.AreaIndex = 0
        Me.pgfmontopagado.Caption = "Monto Pagado"
        Me.pgfmontopagado.FieldName = "recMonto"
        Me.pgfmontopagado.Name = "pgfmontopagado"
        Me.pgfmontopagado.TotalCellFormat.FormatString = "n2"
        Me.pgfmontopagado.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'pgfporcentajeSAIMT
        '
        Me.pgfporcentajeSAIMT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfporcentajeSAIMT.AreaIndex = 1
        Me.pgfporcentajeSAIMT.Caption = "Porcentaje SAIMT"
        Me.pgfporcentajeSAIMT.FieldName = "conPorcentaje"
        Me.pgfporcentajeSAIMT.Name = "pgfporcentajeSAIMT"
        Me.pgfporcentajeSAIMT.TotalCellFormat.FormatString = "p"
        Me.pgfporcentajeSAIMT.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'pgfingresoSAIMT
        '
        Me.pgfingresoSAIMT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfingresoSAIMT.AreaIndex = 2
        Me.pgfingresoSAIMT.Caption = "Ingreso SAIMT"
        Me.pgfingresoSAIMT.FieldName = "recTotalIng"
        Me.pgfingresoSAIMT.Name = "pgfingresoSAIMT"
        Me.pgfingresoSAIMT.TotalCellFormat.FormatString = "n2"
        Me.pgfingresoSAIMT.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'pgfingresorec
        '
        Me.pgfingresorec.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfingresorec.AreaIndex = 4
        Me.pgfingresorec.Caption = "Ingreso Recaudadora"
        Me.pgfingresorec.FieldName = "recVComision"
        Me.pgfingresorec.Name = "pgfingresorec"
        Me.pgfingresorec.TotalCellFormat.FormatString = "n2"
        Me.pgfingresorec.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'pgfporcrecaudacion
        '
        Me.pgfporcrecaudacion.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfporcrecaudacion.AreaIndex = 3
        Me.pgfporcrecaudacion.Caption = "Porcentaje Recaudadora"
        Me.pgfporcrecaudacion.FieldName = "recComision"
        Me.pgfporcrecaudacion.Name = "pgfporcrecaudacion"
        Me.pgfporcrecaudacion.TotalCellFormat.FormatString = "p"
        Me.pgfporcrecaudacion.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'pgfneto
        '
        Me.pgfneto.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pgfneto.AreaIndex = 5
        Me.pgfneto.Caption = "Neto SAIMT"
        Me.pgfneto.FieldName = "recNeto"
        Me.pgfneto.Name = "pgfneto"
        Me.pgfneto.TotalCellFormat.FormatString = "n2"
        Me.pgfneto.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'pgfrecaudadora
        '
        Me.pgfrecaudadora.AreaIndex = 12
        Me.pgfrecaudadora.Caption = "Recaudadora"
        Me.pgfrecaudadora.FieldName = "Recaudadora"
        Me.pgfrecaudadora.Name = "pgfrecaudadora"
        '
        'pgfaño
        '
        Me.pgfaño.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfaño.AreaIndex = 1
        Me.pgfaño.Caption = "Año"
        Me.pgfaño.FieldName = "Año"
        Me.pgfaño.Name = "pgfaño"
        '
        'pgfidmes
        '
        Me.pgfidmes.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfidmes.AreaIndex = 2
        Me.pgfidmes.Caption = "ID Mes"
        Me.pgfidmes.FieldName = "Mes_Id"
        Me.pgfidmes.Name = "pgfidmes"
        '
        'pgfmes
        '
        Me.pgfmes.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pgfmes.AreaIndex = 3
        Me.pgfmes.Caption = "Mes"
        Me.pgfmes.FieldName = "Mes"
        Me.pgfmes.Name = "pgfmes"
        '
        'pgIngMuni
        '
        Me.pgIngMuni.AreaIndex = 10
        Me.pgIngMuni.Caption = "Ingreso Muni"
        Me.pgIngMuni.FieldName = "recIngMuni"
        Me.pgIngMuni.Name = "pgIngMuni"
        '
        'beiprogreso
        '
        Me.beiprogreso.Caption = "BarEditItem1"
        Me.beiprogreso.Edit = Me.ripprogreso
        Me.beiprogreso.Id = 3
        Me.beiprogreso.Name = "beiprogreso"
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.beiprogreso.Width = 110
        '
        'ripprogreso
        '
        Me.ripprogreso.Name = "ripprogreso"
        '
        'frmRptReSatt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 753)
        Me.Controls.Add(Me.pgcrecaudacion)
        Me.Controls.Add(Me.DockPanel1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmRptReSatt"
        Me.Tag = "frmRptReSatt"
        Me.Text = "Recaudación Satt y Caja Trujillo (Playa y Terminal) "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.DockPanel1, 0)
        Me.Controls.SetChildIndex(Me.pgcrecaudacion, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.cmbgrupoingreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecaudacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecaudacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbaños.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbreportes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcrecaudacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ripprogreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents pgcrecaudacion As SaimtControles.SaimtPivotGridControl
    Friend WithEvents cmbreportes As SaimtControles.SaimtComboBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnmostrarxaño As SaimtControles.SaimtButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents btnverreporte As SaimtControles.SaimtButton
    Friend WithEvents pgffechapago As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfnroorden As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcodconcepto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfpartida As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcentroprod As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfconcepto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcuentabanco As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcuentacargo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcuentaabono As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfgrupo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcuentacont As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfcuentapres As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfnro As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfnrodoc As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfpersona As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfmontopagado As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfporcentajeSAIMT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfingresoSAIMT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfingresorec As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfporcrecaudacion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfneto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfrecaudadora As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents cmbaños As SaimtControles.SaimtComboBox
    Friend WithEvents pgfaño As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfidmes As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgfmes As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents sfdexportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents beiprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ripprogreso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents btnmostrardet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents btnmostrarxfecha As SaimtControles.SaimtButton
    Friend WithEvents dtpFechaRecaudacion As SaimtControles.SaimtDateTimePicker
    Friend WithEvents cmbgrupoingreso As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pgIngMuni As DevExpress.XtraPivotGrid.PivotGridField
End Class