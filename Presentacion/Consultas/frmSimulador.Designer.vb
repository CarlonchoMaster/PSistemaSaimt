﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimulador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSimulador))
        Me.grbDatosPersona = New SaimtControles.SaimtGroupBox()
        Me.cboTipoDocumento = New SaimtControles.SaimtComboBoxLookUp()
        Me.txtNroDocumento = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtPersona = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.chkMora = New SaimtControles.SaimtCheckBox()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.cboUso = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.rbMoneda = New SaimtControles.SaimtRadioGroup()
        Me.txtTipoCambio = New SaimtControles.SaimtTextBox()
        Me.cboTipoMoneda = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.cboTipoGarantia = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboTipoComprobante = New SaimtControles.SaimtComboBoxLookUp()
        Me.TxtDiaVen = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel19 = New SaimtControles.SaimtLabel()
        Me.lblTipoComprobante = New SaimtControles.SaimtLabel()
        Me.lblIgv = New SaimtControles.SaimtLabel()
        Me.txtigv = New SaimtControles.SaimtTextBox()
        Me.txtderllaves = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel17 = New SaimtControles.SaimtLabel()
        Me.txtGarantia = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel16 = New SaimtControles.SaimtLabel()
        Me.txtMerced = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.dtfechaFin = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.dtFechaInicio = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.dtpFechaPago = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.btnGenerarCuotas = New SaimtControles.SaimtButton()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox4 = New SaimtControles.SaimtGroupBox()
        Me.dgvProgramacionPagos = New SaimtControles.SaimtDataGrid()
        Me.gvProgramacionPagos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProPaNroCuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAnio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaFechaVen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaDiasVen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcuotatotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPMora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtGroupBox5 = New SaimtControles.SaimtGroupBox()
        Me.dgvProgramacionPagosDetalle = New SaimtControles.SaimtDataGrid()
        Me.gvProgramacionPagosDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colConId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaDetMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPorPagar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.txtTotalMora = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.txttotalpagar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.txtDirInmueble = New SaimtControles.SaimtTextBox()
        Me.btnConsultarInmueble = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.txtCodInm = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel18 = New SaimtControles.SaimtLabel()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.CalcEdit1 = New DevExpress.XtraEditors.CalcEdit()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.txttotalarrendamiento = New SaimtControles.SaimtTextBox()
        Me.beiprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.ripprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.sfdExportar = New System.Windows.Forms.SaveFileDialog()
        Me.fbdExportar = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosPersona.SuspendLayout()
        CType(Me.cboTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.chkMora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoGarantia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDiaVen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtigv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtderllaves.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGarantia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMerced.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtfechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtfechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox4.SuspendLayout()
        CType(Me.dgvProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox5.SuspendLayout()
        CType(Me.dgvProgramacionPagosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionPagosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalMora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotalpagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDirInmueble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.txtCodInm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotalarrendamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ripprogreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.beiprogreso)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 687)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(866, 27)
        '
        'grbDatosPersona
        '
        Me.grbDatosPersona.Controls.Add(Me.cboTipoDocumento)
        Me.grbDatosPersona.Controls.Add(Me.txtNroDocumento)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel4)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel3)
        Me.grbDatosPersona.Controls.Add(Me.txtPersona)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel2)
        Me.grbDatosPersona.Location = New System.Drawing.Point(6, 5)
        Me.grbDatosPersona.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbDatosPersona.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbDatosPersona.Name = "grbDatosPersona"
        Me.grbDatosPersona.Size = New System.Drawing.Size(856, 64)
        Me.grbDatosPersona.TabIndex = 3
        Me.grbDatosPersona.Text = "Datos de la Persona"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.Location = New System.Drawing.Point(480, 28)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoDocumento.Properties.NullText = ""
        Me.cboTipoDocumento.Size = New System.Drawing.Size(178, 20)
        Me.cboTipoDocumento.TabIndex = 92
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(757, 28)
        Me.txtNroDocumento.MenuManager = Me.RibbonControl
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(82, 20)
        Me.txtNroDocumento.TabIndex = 7
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(675, 31)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(85, 13)
        Me.SaimtLabel4.TabIndex = 5
        Me.SaimtLabel4.Text = "Nro. Documento :"
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(390, 31)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(84, 13)
        Me.SaimtLabel3.TabIndex = 4
        Me.SaimtLabel3.Text = "Tipo Documento :"
        '
        'txtPersona
        '
        Me.txtPersona.Location = New System.Drawing.Point(62, 28)
        Me.txtPersona.MenuManager = Me.RibbonControl
        Me.txtPersona.Name = "txtPersona"
        Me.txtPersona.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPersona.Size = New System.Drawing.Size(321, 20)
        Me.txtPersona.TabIndex = 3
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(12, 31)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(46, 13)
        Me.SaimtLabel2.TabIndex = 2
        Me.SaimtLabel2.Text = "Persona :"
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Controls.Add(Me.chkMora)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox3.Controls.Add(Me.cboUso)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox3.Controls.Add(Me.rbMoneda)
        Me.SaimtGroupBox3.Controls.Add(Me.txtTipoCambio)
        Me.SaimtGroupBox3.Controls.Add(Me.cboTipoMoneda)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox3.Controls.Add(Me.cboTipoGarantia)
        Me.SaimtGroupBox3.Controls.Add(Me.cboTipoComprobante)
        Me.SaimtGroupBox3.Controls.Add(Me.TxtDiaVen)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel19)
        Me.SaimtGroupBox3.Controls.Add(Me.lblTipoComprobante)
        Me.SaimtGroupBox3.Controls.Add(Me.lblIgv)
        Me.SaimtGroupBox3.Controls.Add(Me.txtigv)
        Me.SaimtGroupBox3.Controls.Add(Me.txtderllaves)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel17)
        Me.SaimtGroupBox3.Controls.Add(Me.txtGarantia)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel16)
        Me.SaimtGroupBox3.Controls.Add(Me.txtMerced)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel13)
        Me.SaimtGroupBox3.Controls.Add(Me.dtfechaFin)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel15)
        Me.SaimtGroupBox3.Controls.Add(Me.dtFechaInicio)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel14)
        Me.SaimtGroupBox3.Controls.Add(Me.dtpFechaPago)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(6, 142)
        Me.SaimtGroupBox3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(856, 103)
        Me.SaimtGroupBox3.TabIndex = 5
        Me.SaimtGroupBox3.Text = "Datos para simulacion"
        '
        'chkMora
        '
        Me.chkMora.EditValue = True
        Me.chkMora.Location = New System.Drawing.Point(590, 79)
        Me.chkMora.MenuManager = Me.RibbonControl
        Me.chkMora.Name = "chkMora"
        Me.chkMora.Properties.AutoWidth = True
        Me.chkMora.Properties.Caption = "Tomar en cuenta la Mora"
        Me.chkMora.Size = New System.Drawing.Size(141, 19)
        Me.chkMora.TabIndex = 102
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(699, 56)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(22, 13)
        Me.SaimtLabel10.TabIndex = 101
        Me.SaimtLabel10.Text = "Uso:"
        '
        'cboUso
        '
        Me.cboUso.Location = New System.Drawing.Point(731, 51)
        Me.cboUso.Name = "cboUso"
        Me.cboUso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUso.Properties.NullText = ""
        Me.cboUso.Size = New System.Drawing.Size(108, 20)
        Me.cboUso.TabIndex = 100
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(8, 79)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(56, 13)
        Me.SaimtLabel7.TabIndex = 99
        Me.SaimtLabel7.Text = "Calculo en :"
        '
        'rbMoneda
        '
        Me.rbMoneda.EditValue = "S"
        Me.rbMoneda.Location = New System.Drawing.Point(70, 72)
        Me.rbMoneda.MenuManager = Me.RibbonControl
        Me.rbMoneda.Name = "rbMoneda"
        Me.rbMoneda.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rbMoneda.Properties.Appearance.Options.UseBackColor = True
        Me.rbMoneda.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Soles"), New DevExpress.XtraEditors.Controls.RadioGroupItem("D", "Dolares")})
        Me.rbMoneda.Size = New System.Drawing.Size(236, 25)
        Me.rbMoneda.TabIndex = 0
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.EditValue = "0"
        Me.txtTipoCambio.Location = New System.Drawing.Point(439, 27)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Properties.Mask.EditMask = "n2"
        Me.txtTipoCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTipoCambio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(80, 20)
        Me.txtTipoCambio.TabIndex = 97
        '
        'cboTipoMoneda
        '
        Me.cboTipoMoneda.Location = New System.Drawing.Point(353, 27)
        Me.cboTipoMoneda.Name = "cboTipoMoneda"
        Me.cboTipoMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoMoneda.Properties.NullText = ""
        Me.cboTipoMoneda.Size = New System.Drawing.Size(80, 20)
        Me.cboTipoMoneda.TabIndex = 96
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(302, 28)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(45, 13)
        Me.SaimtLabel1.TabIndex = 95
        Me.SaimtLabel1.Text = "Moneda :"
        '
        'cboTipoGarantia
        '
        Me.cboTipoGarantia.Location = New System.Drawing.Point(354, 50)
        Me.cboTipoGarantia.Name = "cboTipoGarantia"
        Me.cboTipoGarantia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoGarantia.Properties.NullText = ""
        Me.cboTipoGarantia.Size = New System.Drawing.Size(79, 20)
        Me.cboTipoGarantia.TabIndex = 93
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.Location = New System.Drawing.Point(590, 52)
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoComprobante.Properties.NullText = ""
        Me.cboTipoComprobante.Size = New System.Drawing.Size(80, 20)
        Me.cboTipoComprobante.TabIndex = 91
        '
        'TxtDiaVen
        '
        Me.TxtDiaVen.Location = New System.Drawing.Point(62, 50)
        Me.TxtDiaVen.Name = "TxtDiaVen"
        Me.TxtDiaVen.Size = New System.Drawing.Size(80, 20)
        Me.TxtDiaVen.TabIndex = 17
        '
        'SaimtLabel19
        '
        Me.SaimtLabel19.Location = New System.Drawing.Point(8, 54)
        Me.SaimtLabel19.Name = "SaimtLabel19"
        Me.SaimtLabel19.Size = New System.Drawing.Size(40, 13)
        Me.SaimtLabel19.TabIndex = 16
        Me.SaimtLabel19.Text = "Dia Ven:"
        '
        'lblTipoComprobante
        '
        Me.lblTipoComprobante.Location = New System.Drawing.Point(530, 57)
        Me.lblTipoComprobante.Name = "lblTipoComprobante"
        Me.lblTipoComprobante.Size = New System.Drawing.Size(57, 13)
        Me.lblTipoComprobante.TabIndex = 14
        Me.lblTipoComprobante.Text = "Tipo Comp :"
        '
        'lblIgv
        '
        Me.lblIgv.Location = New System.Drawing.Point(699, 29)
        Me.lblIgv.Name = "lblIgv"
        Me.lblIgv.Size = New System.Drawing.Size(24, 13)
        Me.lblIgv.TabIndex = 11
        Me.lblIgv.Text = "IGV :"
        '
        'txtigv
        '
        Me.txtigv.EditValue = "0.19"
        Me.txtigv.Location = New System.Drawing.Point(731, 26)
        Me.txtigv.MenuManager = Me.RibbonControl
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Properties.Mask.EditMask = "n2"
        Me.txtigv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtigv.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtigv.Size = New System.Drawing.Size(108, 20)
        Me.txtigv.TabIndex = 9
        '
        'txtderllaves
        '
        Me.txtderllaves.EditValue = "0"
        Me.txtderllaves.Location = New System.Drawing.Point(216, 49)
        Me.txtderllaves.Name = "txtderllaves"
        Me.txtderllaves.Properties.Mask.EditMask = "n2"
        Me.txtderllaves.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtderllaves.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtderllaves.Size = New System.Drawing.Size(80, 20)
        Me.txtderllaves.TabIndex = 8
        '
        'SaimtLabel17
        '
        Me.SaimtLabel17.Location = New System.Drawing.Point(154, 52)
        Me.SaimtLabel17.Name = "SaimtLabel17"
        Me.SaimtLabel17.Size = New System.Drawing.Size(56, 13)
        Me.SaimtLabel17.TabIndex = 7
        Me.SaimtLabel17.Text = "Der. Llave :"
        '
        'txtGarantia
        '
        Me.txtGarantia.EditValue = "0"
        Me.txtGarantia.Location = New System.Drawing.Point(439, 50)
        Me.txtGarantia.Name = "txtGarantia"
        Me.txtGarantia.Properties.Mask.EditMask = "n2"
        Me.txtGarantia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtGarantia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtGarantia.Size = New System.Drawing.Size(80, 20)
        Me.txtGarantia.TabIndex = 8
        '
        'SaimtLabel16
        '
        Me.SaimtLabel16.Location = New System.Drawing.Point(300, 55)
        Me.SaimtLabel16.Name = "SaimtLabel16"
        Me.SaimtLabel16.Size = New System.Drawing.Size(48, 13)
        Me.SaimtLabel16.TabIndex = 7
        Me.SaimtLabel16.Text = "Garantía :"
        '
        'txtMerced
        '
        Me.txtMerced.Location = New System.Drawing.Point(590, 27)
        Me.txtMerced.MenuManager = Me.RibbonControl
        Me.txtMerced.Name = "txtMerced"
        Me.txtMerced.Properties.Mask.EditMask = "n2"
        Me.txtMerced.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMerced.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMerced.Size = New System.Drawing.Size(80, 20)
        Me.txtMerced.TabIndex = 8
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(528, 32)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(42, 13)
        Me.SaimtLabel13.TabIndex = 7
        Me.SaimtLabel13.Text = "Merced :"
        '
        'dtfechaFin
        '
        Me.dtfechaFin.EditValue = Nothing
        Me.dtfechaFin.Location = New System.Drawing.Point(216, 25)
        Me.dtfechaFin.Name = "dtfechaFin"
        Me.dtfechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtfechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtfechaFin.Size = New System.Drawing.Size(80, 20)
        Me.dtfechaFin.TabIndex = 1
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(152, 28)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel15.TabIndex = 0
        Me.SaimtLabel15.Text = "F. Termino :"
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.EditValue = Nothing
        Me.dtFechaInicio.Location = New System.Drawing.Point(62, 25)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFechaInicio.Size = New System.Drawing.Size(80, 20)
        Me.dtFechaInicio.TabIndex = 1
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(9, 28)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(45, 13)
        Me.SaimtLabel14.TabIndex = 0
        Me.SaimtLabel14.Text = "F. Inicio :"
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.EditValue = Nothing
        Me.dtpFechaPago.Location = New System.Drawing.Point(402, 76)
        Me.dtpFechaPago.MenuManager = Me.RibbonControl
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaPago.Size = New System.Drawing.Size(117, 20)
        Me.dtpFechaPago.TabIndex = 1
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(318, 79)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(81, 13)
        Me.SaimtLabel5.TabIndex = 0
        Me.SaimtLabel5.Text = "Fecha Deposito :"
        '
        'btnGenerarCuotas
        '
        Me.btnGenerarCuotas.Image = CType(resources.GetObject("btnGenerarCuotas.Image"), System.Drawing.Image)
        Me.btnGenerarCuotas.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnGenerarCuotas.Location = New System.Drawing.Point(593, 26)
        Me.btnGenerarCuotas.Name = "btnGenerarCuotas"
        Me.btnGenerarCuotas.Size = New System.Drawing.Size(84, 36)
        Me.btnGenerarCuotas.TabIndex = 2
        Me.btnGenerarCuotas.Text = "Calcular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pagos"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(682, 26)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(84, 36)
        Me.btnImprimir.TabIndex = 94
        Me.btnImprimir.Text = "Imprimir"
        '
        'SaimtGroupBox4
        '
        Me.SaimtGroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox4.Controls.Add(Me.dgvProgramacionPagos)
        Me.SaimtGroupBox4.Location = New System.Drawing.Point(6, 245)
        Me.SaimtGroupBox4.Name = "SaimtGroupBox4"
        Me.SaimtGroupBox4.Size = New System.Drawing.Size(856, 256)
        Me.SaimtGroupBox4.TabIndex = 7
        Me.SaimtGroupBox4.Text = "Programaciones de Pago"
        '
        'dgvProgramacionPagos
        '
        Me.dgvProgramacionPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProgramacionPagos.Location = New System.Drawing.Point(2, 21)
        Me.dgvProgramacionPagos.MainView = Me.gvProgramacionPagos
        Me.dgvProgramacionPagos.MenuManager = Me.RibbonControl
        Me.dgvProgramacionPagos.Name = "dgvProgramacionPagos"
        Me.dgvProgramacionPagos.Size = New System.Drawing.Size(852, 233)
        Me.dgvProgramacionPagos.TabIndex = 5
        Me.dgvProgramacionPagos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionPagos})
        '
        'gvProgramacionPagos
        '
        Me.gvProgramacionPagos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvProgramacionPagos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvProgramacionPagos.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvProgramacionPagos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProPaNroCuota, Me.colAnio, Me.colMes, Me.colProPaFechaVen, Me.colProPaDiasVen, Me.colcuotatotal, Me.colPMora, Me.colMora})
        Me.gvProgramacionPagos.GridControl = Me.dgvProgramacionPagos
        Me.gvProgramacionPagos.Name = "gvProgramacionPagos"
        Me.gvProgramacionPagos.OptionsBehavior.ReadOnly = True
        Me.gvProgramacionPagos.OptionsView.ColumnAutoWidth = False
        Me.gvProgramacionPagos.OptionsView.ShowFooter = True
        Me.gvProgramacionPagos.OptionsView.ShowGroupPanel = False
        '
        'colProPaNroCuota
        '
        Me.colProPaNroCuota.Caption = "Nro Cuota"
        Me.colProPaNroCuota.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProPaNroCuota.FieldName = "cuota"
        Me.colProPaNroCuota.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.colProPaNroCuota.Name = "colProPaNroCuota"
        Me.colProPaNroCuota.Visible = True
        Me.colProPaNroCuota.VisibleIndex = 0
        '
        'colAnio
        '
        Me.colAnio.Caption = "Año"
        Me.colAnio.FieldName = "Anio"
        Me.colAnio.Name = "colAnio"
        Me.colAnio.Visible = True
        Me.colAnio.VisibleIndex = 1
        '
        'colMes
        '
        Me.colMes.Caption = "Mes"
        Me.colMes.FieldName = "mes"
        Me.colMes.Name = "colMes"
        Me.colMes.Visible = True
        Me.colMes.VisibleIndex = 2
        '
        'colProPaFechaVen
        '
        Me.colProPaFechaVen.Caption = "Fecha Vencimiento"
        Me.colProPaFechaVen.DisplayFormat.FormatString = "d"
        Me.colProPaFechaVen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colProPaFechaVen.FieldName = "fechaven"
        Me.colProPaFechaVen.Name = "colProPaFechaVen"
        Me.colProPaFechaVen.Visible = True
        Me.colProPaFechaVen.VisibleIndex = 3
        '
        'colProPaDiasVen
        '
        Me.colProPaDiasVen.Caption = "Dias Vencimiento"
        Me.colProPaDiasVen.FieldName = "diasven"
        Me.colProPaDiasVen.Name = "colProPaDiasVen"
        Me.colProPaDiasVen.Visible = True
        Me.colProPaDiasVen.VisibleIndex = 4
        '
        'colcuotatotal
        '
        Me.colcuotatotal.Caption = "Total X Cuota"
        Me.colcuotatotal.DisplayFormat.FormatString = "n2"
        Me.colcuotatotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcuotatotal.FieldName = "cuotatotal"
        Me.colcuotatotal.Name = "colcuotatotal"
        Me.colcuotatotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cuotatotal", "{0:###,##0.00}")})
        Me.colcuotatotal.Visible = True
        Me.colcuotatotal.VisibleIndex = 5
        '
        'colPMora
        '
        Me.colPMora.Caption = "% Mora"
        Me.colPMora.DisplayFormat.FormatString = "P"
        Me.colPMora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPMora.FieldName = "pmora"
        Me.colPMora.Name = "colPMora"
        Me.colPMora.Visible = True
        Me.colPMora.VisibleIndex = 6
        '
        'colMora
        '
        Me.colMora.Caption = "Mora Acumulada"
        Me.colMora.DisplayFormat.FormatString = "n2"
        Me.colMora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMora.FieldName = "totalmora"
        Me.colMora.Name = "colMora"
        Me.colMora.Visible = True
        Me.colMora.VisibleIndex = 7
        '
        'SaimtGroupBox5
        '
        Me.SaimtGroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox5.Controls.Add(Me.dgvProgramacionPagosDetalle)
        Me.SaimtGroupBox5.Controls.Add(Me.txtPorPagar)
        Me.SaimtGroupBox5.Controls.Add(Me.SaimtLabel9)
        Me.SaimtGroupBox5.Location = New System.Drawing.Point(8, 527)
        Me.SaimtGroupBox5.Name = "SaimtGroupBox5"
        Me.SaimtGroupBox5.Size = New System.Drawing.Size(852, 157)
        Me.SaimtGroupBox5.TabIndex = 8
        Me.SaimtGroupBox5.Text = "Detalle de Programaciones de Pago"
        '
        'dgvProgramacionPagosDetalle
        '
        Me.dgvProgramacionPagosDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProgramacionPagosDetalle.Location = New System.Drawing.Point(2, 21)
        Me.dgvProgramacionPagosDetalle.MainView = Me.gvProgramacionPagosDetalle
        Me.dgvProgramacionPagosDetalle.MenuManager = Me.RibbonControl
        Me.dgvProgramacionPagosDetalle.Name = "dgvProgramacionPagosDetalle"
        Me.dgvProgramacionPagosDetalle.Size = New System.Drawing.Size(848, 134)
        Me.dgvProgramacionPagosDetalle.TabIndex = 9
        Me.dgvProgramacionPagosDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionPagosDetalle})
        '
        'gvProgramacionPagosDetalle
        '
        Me.gvProgramacionPagosDetalle.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvProgramacionPagosDetalle.Appearance.FooterPanel.Options.UseFont = True
        Me.gvProgramacionPagosDetalle.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvProgramacionPagosDetalle.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvProgramacionPagosDetalle.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvProgramacionPagosDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colConId, Me.colConNombre, Me.colProPaDetMonto, Me.colMontoA})
        Me.gvProgramacionPagosDetalle.GridControl = Me.dgvProgramacionPagosDetalle
        Me.gvProgramacionPagosDetalle.Name = "gvProgramacionPagosDetalle"
        Me.gvProgramacionPagosDetalle.OptionsBehavior.ReadOnly = True
        Me.gvProgramacionPagosDetalle.OptionsCustomization.AllowFilter = False
        Me.gvProgramacionPagosDetalle.OptionsCustomization.AllowSort = False
        Me.gvProgramacionPagosDetalle.OptionsView.ColumnAutoWidth = False
        Me.gvProgramacionPagosDetalle.OptionsView.ShowFooter = True
        Me.gvProgramacionPagosDetalle.OptionsView.ShowGroupPanel = False
        '
        'colConId
        '
        Me.colConId.Caption = "Cod. Concepto"
        Me.colConId.FieldName = "conId"
        Me.colConId.Name = "colConId"
        Me.colConId.Visible = True
        Me.colConId.VisibleIndex = 0
        '
        'colConNombre
        '
        Me.colConNombre.Caption = "Concepto"
        Me.colConNombre.FieldName = "conNombre"
        Me.colConNombre.Name = "colConNombre"
        Me.colConNombre.Visible = True
        Me.colConNombre.VisibleIndex = 1
        '
        'colProPaDetMonto
        '
        Me.colProPaDetMonto.Caption = "Monto"
        Me.colProPaDetMonto.DisplayFormat.FormatString = "n2"
        Me.colProPaDetMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProPaDetMonto.FieldName = "proPaDetMonto"
        Me.colProPaDetMonto.Name = "colProPaDetMonto"
        Me.colProPaDetMonto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "proPaDetMonto", "{0:###,##0.00}")})
        Me.colProPaDetMonto.Visible = True
        Me.colProPaDetMonto.VisibleIndex = 2
        '
        'colMontoA
        '
        Me.colMontoA.Caption = "Monto Acumulado"
        Me.colMontoA.DisplayFormat.FormatString = "n2"
        Me.colMontoA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMontoA.FieldName = "proPaDetMontoA"
        Me.colMontoA.Name = "colMontoA"
        Me.colMontoA.Visible = True
        Me.colMontoA.VisibleIndex = 3
        '
        'txtPorPagar
        '
        Me.txtPorPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorPagar.Location = New System.Drawing.Point(368, -29)
        Me.txtPorPagar.MenuManager = Me.RibbonControl
        Me.txtPorPagar.Name = "txtPorPagar"
        Me.txtPorPagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPorPagar.Properties.Appearance.Options.UseFont = True
        Me.txtPorPagar.Properties.DisplayFormat.FormatString = "n2"
        Me.txtPorPagar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorPagar.Properties.Mask.EditMask = "n2"
        Me.txtPorPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorPagar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorPagar.Properties.ReadOnly = True
        Me.txtPorPagar.Size = New System.Drawing.Size(100, 20)
        Me.txtPorPagar.TabIndex = 27
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel9.Location = New System.Drawing.Point(310, -26)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel9.TabIndex = 25
        Me.SaimtLabel9.Text = "Por Pagar :"
        '
        'txtTotalMora
        '
        Me.txtTotalMora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMora.Location = New System.Drawing.Point(457, 506)
        Me.txtTotalMora.MenuManager = Me.RibbonControl
        Me.txtTotalMora.Name = "txtTotalMora"
        Me.txtTotalMora.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalMora.Properties.Appearance.Options.UseFont = True
        Me.txtTotalMora.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalMora.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalMora.Properties.Mask.EditMask = "n2"
        Me.txtTotalMora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalMora.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalMora.Properties.ReadOnly = True
        Me.txtTotalMora.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMora.TabIndex = 32
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SaimtLabel11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel11.Location = New System.Drawing.Point(284, 508)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(166, 19)
        Me.SaimtLabel11.TabIndex = 31
        Me.SaimtLabel11.Text = "Total Mora :"
        '
        'txttotalpagar
        '
        Me.txttotalpagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttotalpagar.Location = New System.Drawing.Point(175, 505)
        Me.txttotalpagar.MenuManager = Me.RibbonControl
        Me.txttotalpagar.Name = "txttotalpagar"
        Me.txttotalpagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txttotalpagar.Properties.Appearance.Options.UseFont = True
        Me.txttotalpagar.Properties.DisplayFormat.FormatString = "n2"
        Me.txttotalpagar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txttotalpagar.Properties.Mask.EditMask = "n2"
        Me.txttotalpagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttotalpagar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttotalpagar.Properties.ReadOnly = True
        Me.txttotalpagar.Size = New System.Drawing.Size(100, 20)
        Me.txttotalpagar.TabIndex = 34
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SaimtLabel6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel6.Location = New System.Drawing.Point(11, 505)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(158, 21)
        Me.SaimtLabel6.TabIndex = 33
        Me.SaimtLabel6.Text = "Total Pagar :"
        '
        'txtDirInmueble
        '
        Me.txtDirInmueble.EditValue = ""
        Me.txtDirInmueble.Location = New System.Drawing.Point(209, 28)
        Me.txtDirInmueble.Name = "txtDirInmueble"
        Me.txtDirInmueble.Properties.ReadOnly = True
        Me.txtDirInmueble.Size = New System.Drawing.Size(349, 20)
        Me.txtDirInmueble.TabIndex = 73
        '
        'btnConsultarInmueble
        '
        Me.btnConsultarInmueble.Image = CType(resources.GetObject("btnConsultarInmueble.Image"), System.Drawing.Image)
        Me.btnConsultarInmueble.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConsultarInmueble.Location = New System.Drawing.Point(564, 26)
        Me.btnConsultarInmueble.Name = "btnConsultarInmueble"
        Me.btnConsultarInmueble.Size = New System.Drawing.Size(21, 21)
        Me.btnConsultarInmueble.TabIndex = 74
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.txtCodInm)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel18)
        Me.SaimtGroupBox1.Controls.Add(Me.btnexportar)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox1.Controls.Add(Me.btnGenerarCuotas)
        Me.SaimtGroupBox1.Controls.Add(Me.txtDirInmueble)
        Me.SaimtGroupBox1.Controls.Add(Me.btnConsultarInmueble)
        Me.SaimtGroupBox1.Controls.Add(Me.btnImprimir)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(4, 75)
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(856, 64)
        Me.SaimtGroupBox1.TabIndex = 75
        Me.SaimtGroupBox1.Text = "Datos del Inmueble"
        '
        'txtCodInm
        '
        Me.txtCodInm.Location = New System.Drawing.Point(64, 27)
        Me.txtCodInm.MenuManager = Me.RibbonControl
        Me.txtCodInm.Name = "txtCodInm"
        Me.txtCodInm.Properties.ReadOnly = True
        Me.txtCodInm.Size = New System.Drawing.Size(82, 20)
        Me.txtCodInm.TabIndex = 93
        '
        'SaimtLabel18
        '
        Me.SaimtLabel18.Location = New System.Drawing.Point(14, 30)
        Me.SaimtLabel18.Name = "SaimtLabel18"
        Me.SaimtLabel18.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel18.TabIndex = 96
        Me.SaimtLabel18.Text = "Cod. Inm. "
        '
        'btnexportar
        '
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnexportar.Location = New System.Drawing.Point(770, 26)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(84, 36)
        Me.btnexportar.TabIndex = 95
        Me.btnexportar.Text = "Exportar"
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(152, 30)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel8.TabIndex = 2
        Me.SaimtLabel8.Text = "Inmueble :"
        '
        'CalcEdit1
        '
        Me.CalcEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalcEdit1.Location = New System.Drawing.Point(773, 504)
        Me.CalcEdit1.MenuManager = Me.RibbonControl
        Me.CalcEdit1.Name = "CalcEdit1"
        Me.CalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit1.Properties.NullText = "Calculadora"
        Me.CalcEdit1.Size = New System.Drawing.Size(87, 20)
        Me.CalcEdit1.TabIndex = 76
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel12.Location = New System.Drawing.Point(563, 509)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(105, 13)
        Me.SaimtLabel12.TabIndex = 102
        Me.SaimtLabel12.Text = "Total Arrendamiento :"
        '
        'txttotalarrendamiento
        '
        Me.txttotalarrendamiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttotalarrendamiento.Location = New System.Drawing.Point(674, 505)
        Me.txttotalarrendamiento.MenuManager = Me.RibbonControl
        Me.txttotalarrendamiento.Name = "txttotalarrendamiento"
        Me.txttotalarrendamiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txttotalarrendamiento.Properties.Appearance.Options.UseFont = True
        Me.txttotalarrendamiento.Properties.DisplayFormat.FormatString = "n2"
        Me.txttotalarrendamiento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txttotalarrendamiento.Properties.Mask.EditMask = "n2"
        Me.txttotalarrendamiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttotalarrendamiento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttotalarrendamiento.Properties.ReadOnly = True
        Me.txttotalarrendamiento.Size = New System.Drawing.Size(92, 20)
        Me.txttotalarrendamiento.TabIndex = 103
        '
        'beiprogreso
        '
        Me.beiprogreso.Caption = "BarEditItem1"
        Me.beiprogreso.Edit = Me.ripprogreso
        Me.beiprogreso.Id = 4
        Me.beiprogreso.Name = "beiprogreso"
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.beiprogreso.Width = 110
        '
        'ripprogreso
        '
        Me.ripprogreso.Name = "ripprogreso"
        '
        'frmSimulador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 714)
        Me.Controls.Add(Me.txttotalarrendamiento)
        Me.Controls.Add(Me.SaimtLabel12)
        Me.Controls.Add(Me.CalcEdit1)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.txttotalpagar)
        Me.Controls.Add(Me.SaimtLabel6)
        Me.Controls.Add(Me.txtTotalMora)
        Me.Controls.Add(Me.SaimtGroupBox5)
        Me.Controls.Add(Me.SaimtLabel11)
        Me.Controls.Add(Me.SaimtGroupBox4)
        Me.Controls.Add(Me.SaimtGroupBox3)
        Me.Controls.Add(Me.grbDatosPersona)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmSimulador"
        Me.Text = "Simulador Programación de Pagos"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.grbDatosPersona, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox3, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox4, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel11, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox5, 0)
        Me.Controls.SetChildIndex(Me.txtTotalMora, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel6, 0)
        Me.Controls.SetChildIndex(Me.txttotalpagar, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.CalcEdit1, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel12, 0)
        Me.Controls.SetChildIndex(Me.txttotalarrendamiento, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosPersona.ResumeLayout(False)
        Me.grbDatosPersona.PerformLayout()
        CType(Me.cboTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        Me.SaimtGroupBox3.PerformLayout()
        CType(Me.chkMora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoGarantia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDiaVen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtigv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtderllaves.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGarantia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMerced.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtfechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtfechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox4.ResumeLayout(False)
        CType(Me.dgvProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox5.ResumeLayout(False)
        Me.SaimtGroupBox5.PerformLayout()
        CType(Me.dgvProgramacionPagosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionPagosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalMora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotalpagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDirInmueble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.txtCodInm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotalarrendamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ripprogreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbDatosPersona As SaimtControles.SaimtGroupBox
    Friend WithEvents txtNroDocumento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents txtPersona As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents dtpFechaPago As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox4 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtGroupBox5 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvProgramacionPagosDetalle As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionPagosDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colConId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaDetMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalMora As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents txtPorPagar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents txtderllaves As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel17 As SaimtControles.SaimtLabel
    Friend WithEvents txtGarantia As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel16 As SaimtControles.SaimtLabel
    Friend WithEvents txtMerced As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents btnGenerarCuotas As SaimtControles.SaimtButton
    Friend WithEvents dtfechaFin As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents dtFechaInicio As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents lblIgv As SaimtControles.SaimtLabel
    Friend WithEvents txtigv As SaimtControles.SaimtTextBox
    Friend WithEvents lblTipoComprobante As SaimtControles.SaimtLabel
    Friend WithEvents TxtDiaVen As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel19 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoComprobante As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboTipoGarantia As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents dgvProgramacionPagos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionPagos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProPaNroCuota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaFechaVen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaDiasVen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcuotatotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txttotalpagar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents colMora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTipoDocumento As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents txtDirInmueble As SaimtControles.SaimtTextBox
    Friend WithEvents btnConsultarInmueble As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoMoneda As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtTipoCambio As SaimtControles.SaimtTextBox
    Friend WithEvents colMontoA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents rbMoneda As SaimtControles.SaimtRadioGroup
    Friend WithEvents colAnio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CalcEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents cboUso As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents txttotalarrendamiento As SaimtControles.SaimtTextBox
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents beiprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ripprogreso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents txtCodInm As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel18 As SaimtControles.SaimtLabel
    Friend WithEvents chkMora As SaimtControles.SaimtCheckBox
    Friend WithEvents colPMora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sfdExportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents fbdExportar As System.Windows.Forms.FolderBrowserDialog
End Class
