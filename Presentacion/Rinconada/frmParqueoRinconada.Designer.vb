﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParqueoRinconada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParqueoRinconada))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.chkSinPlaca = New SaimtControles.SaimtCheckBox()
        Me.txtHora = New SaimtControles.SaimtTextBox()
        Me.txtfecha = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.cboConcepto = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.btnOK = New SaimtControles.SaimtButton()
        Me.txtplaca = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.txtCapacidadDisponible = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.txtcapacidadIN = New SaimtControles.SaimtTextBox()
        Me.cboTipoVehiculo = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.txtCapacidad = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.cboEstados = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboConceptosBusquedas = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnBuscar = New SaimtControles.SaimtButton()
        Me.dgvDiarioPEM = New SaimtControles.SaimtDataGrid()
        Me.gvDiarioPEM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnExportar = New SaimtControles.SaimtButton()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.tmhora = New System.Windows.Forms.Timer(Me.components)
        Me.sfdExportar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.chkSinPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtplaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.txtCapacidadDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcapacidadIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoVehiculo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCapacidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.cboEstados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConceptosBusquedas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDiarioPEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDiarioPEM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 708)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1020, 27)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtGroupBox1.Appearance.Options.UseFont = True
        Me.SaimtGroupBox1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtGroupBox1.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseFont = True
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseForeColor = True
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseTextOptions = True
        Me.SaimtGroupBox1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SaimtGroupBox1.Controls.Add(Me.chkSinPlaca)
        Me.SaimtGroupBox1.Controls.Add(Me.txtHora)
        Me.SaimtGroupBox1.Controls.Add(Me.txtfecha)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Controls.Add(Me.cboConcepto)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox1.Controls.Add(Me.btnOK)
        Me.SaimtGroupBox1.Controls.Add(Me.txtplaca)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(1002, 203)
        Me.SaimtGroupBox1.TabIndex = 2
        Me.SaimtGroupBox1.Text = "Ingreso de Vehiculos"
        '
        'chkSinPlaca
        '
        Me.chkSinPlaca.Location = New System.Drawing.Point(769, 31)
        Me.chkSinPlaca.MenuManager = Me.RibbonControl
        Me.chkSinPlaca.Name = "chkSinPlaca"
        Me.chkSinPlaca.Properties.AutoWidth = True
        Me.chkSinPlaca.Properties.Caption = "Placa en Tramite"
        Me.chkSinPlaca.Size = New System.Drawing.Size(102, 19)
        Me.chkSinPlaca.TabIndex = 9
        Me.chkSinPlaca.Visible = False
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(591, 30)
        Me.txtHora.MenuManager = Me.RibbonControl
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtHora.Properties.Appearance.Options.UseFont = True
        Me.txtHora.Properties.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(139, 26)
        Me.txtHora.TabIndex = 8
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(301, 29)
        Me.txtfecha.MenuManager = Me.RibbonControl
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtfecha.Properties.Appearance.Options.UseFont = True
        Me.txtfecha.Properties.ReadOnly = True
        Me.txtfecha.Size = New System.Drawing.Size(182, 26)
        Me.txtfecha.TabIndex = 7
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel10.Location = New System.Drawing.Point(551, 32)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(34, 19)
        Me.SaimtLabel10.TabIndex = 6
        Me.SaimtLabel10.Text = "Hora"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel2.Location = New System.Drawing.Point(255, 32)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(40, 19)
        Me.SaimtLabel2.TabIndex = 5
        Me.SaimtLabel2.Text = "Fecha"
        '
        'cboConcepto
        '
        Me.cboConcepto.Location = New System.Drawing.Point(199, 168)
        Me.cboConcepto.MenuManager = Me.RibbonControl
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConcepto.Properties.Appearance.Options.UseFont = True
        Me.cboConcepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConcepto.Properties.NullText = ""
        Me.cboConcepto.Size = New System.Drawing.Size(797, 29)
        Me.cboConcepto.TabIndex = 4
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel5.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtLabel5.Location = New System.Drawing.Point(118, 168)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(72, 25)
        Me.SaimtLabel5.TabIndex = 3
        Me.SaimtLabel5.Text = "Servicio"
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Location = New System.Drawing.Point(886, 63)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(110, 98)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'txtplaca
        '
        Me.txtplaca.EditValue = ""
        Me.txtplaca.Location = New System.Drawing.Point(199, 60)
        Me.txtplaca.MenuManager = Me.RibbonControl
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplaca.Properties.Appearance.Options.UseFont = True
        Me.txtplaca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtplaca.Properties.MaxLength = 8
        Me.txtplaca.Size = New System.Drawing.Size(681, 103)
        Me.txtplaca.TabIndex = 1
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel1.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtLabel1.Location = New System.Drawing.Point(7, 65)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(183, 97)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Placa"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.txtCapacidadDisponible)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox2.Controls.Add(Me.txtcapacidadIN)
        Me.SaimtGroupBox2.Controls.Add(Me.cboTipoVehiculo)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox2.Controls.Add(Me.txtCapacidad)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(12, 214)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(1002, 68)
        Me.SaimtGroupBox2.TabIndex = 4
        Me.SaimtGroupBox2.Text = "Cobertura de PEM"
        '
        'txtCapacidadDisponible
        '
        Me.txtCapacidadDisponible.Location = New System.Drawing.Point(463, 40)
        Me.txtCapacidadDisponible.MenuManager = Me.RibbonControl
        Me.txtCapacidadDisponible.Name = "txtCapacidadDisponible"
        Me.txtCapacidadDisponible.Size = New System.Drawing.Size(100, 20)
        Me.txtCapacidadDisponible.TabIndex = 7
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(465, 25)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(94, 13)
        Me.SaimtLabel7.TabIndex = 6
        Me.SaimtLabel7.Text = "Lugares Disponibles"
        '
        'txtcapacidadIN
        '
        Me.txtcapacidadIN.Location = New System.Drawing.Point(321, 40)
        Me.txtcapacidadIN.MenuManager = Me.RibbonControl
        Me.txtcapacidadIN.Name = "txtcapacidadIN"
        Me.txtcapacidadIN.Size = New System.Drawing.Size(125, 20)
        Me.txtcapacidadIN.TabIndex = 5
        '
        'cboTipoVehiculo
        '
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(8, 40)
        Me.cboTipoVehiculo.MenuManager = Me.RibbonControl
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoVehiculo.Properties.NullText = ""
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(195, 20)
        Me.cboTipoVehiculo.TabIndex = 4
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(10, 25)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(77, 13)
        Me.SaimtLabel6.TabIndex = 3
        Me.SaimtLabel6.Text = "Tipo de Vehiculo"
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(323, 25)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(123, 13)
        Me.SaimtLabel4.TabIndex = 2
        Me.SaimtLabel4.Text = "Vehiculos dentro de Playa"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(212, 40)
        Me.txtCapacidad.MenuManager = Me.RibbonControl
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCapacidad.TabIndex = 1
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(214, 25)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(77, 13)
        Me.SaimtLabel3.TabIndex = 0
        Me.SaimtLabel3.Text = "Capacidad Total"
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(10, 29)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(88, 13)
        Me.SaimtLabel8.TabIndex = 6
        Me.SaimtLabel8.Text = "Concepto Vehiculo"
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Controls.Add(Me.btnImprimir)
        Me.SaimtGroupBox3.Controls.Add(Me.cboEstados)
        Me.SaimtGroupBox3.Controls.Add(Me.cboConceptosBusquedas)
        Me.SaimtGroupBox3.Controls.Add(Me.btnBuscar)
        Me.SaimtGroupBox3.Controls.Add(Me.dgvDiarioPEM)
        Me.SaimtGroupBox3.Controls.Add(Me.btnExportar)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel9)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(12, 288)
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(1002, 416)
        Me.SaimtGroupBox3.TabIndex = 7
        Me.SaimtGroupBox3.Text = "Consulta de Datos"
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(910, 13)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(86, 36)
        Me.btnImprimir.TabIndex = 14
        Me.btnImprimir.Text = "Imprimir Duplicado"
        '
        'cboEstados
        '
        Me.cboEstados.Location = New System.Drawing.Point(607, 26)
        Me.cboEstados.MenuManager = Me.RibbonControl
        Me.cboEstados.Name = "cboEstados"
        Me.cboEstados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstados.Properties.NullText = ""
        Me.cboEstados.Size = New System.Drawing.Size(156, 20)
        Me.cboEstados.TabIndex = 13
        '
        'cboConceptosBusquedas
        '
        Me.cboConceptosBusquedas.Location = New System.Drawing.Point(118, 26)
        Me.cboConceptosBusquedas.MenuManager = Me.RibbonControl
        Me.cboConceptosBusquedas.Name = "cboConceptosBusquedas"
        Me.cboConceptosBusquedas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConceptosBusquedas.Properties.NullText = ""
        Me.cboConceptosBusquedas.Size = New System.Drawing.Size(405, 20)
        Me.cboConceptosBusquedas.TabIndex = 12
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(769, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscar.TabIndex = 11
        '
        'dgvDiarioPEM
        '
        Me.dgvDiarioPEM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDiarioPEM.Location = New System.Drawing.Point(2, 52)
        Me.dgvDiarioPEM.MainView = Me.gvDiarioPEM
        Me.dgvDiarioPEM.MenuManager = Me.RibbonControl
        Me.dgvDiarioPEM.Name = "dgvDiarioPEM"
        Me.dgvDiarioPEM.Size = New System.Drawing.Size(998, 362)
        Me.dgvDiarioPEM.TabIndex = 10
        Me.dgvDiarioPEM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDiarioPEM})
        '
        'gvDiarioPEM
        '
        Me.gvDiarioPEM.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvDiarioPEM.Appearance.FooterPanel.Options.UseFont = True
        Me.gvDiarioPEM.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.gvDiarioPEM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.gvDiarioPEM.GridControl = Me.dgvDiarioPEM
        Me.gvDiarioPEM.Name = "gvDiarioPEM"
        Me.gvDiarioPEM.OptionsBehavior.ReadOnly = True
        Me.gvDiarioPEM.OptionsFind.AlwaysVisible = True
        Me.gvDiarioPEM.OptionsPrint.AutoWidth = False
        Me.gvDiarioPEM.OptionsView.ColumnAutoWidth = False
        Me.gvDiarioPEM.OptionsView.ShowFooter = True
        Me.gvDiarioPEM.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "diarioId"
        Me.GridColumn7.FieldName = "diarioId"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "N° Ticket"
        Me.GridColumn1.FieldName = "diarioCod"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Placa"
        Me.GridColumn2.FieldName = "diaNPlaca"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha Ing."
        Me.GridColumn3.FieldName = "diaFechaIng"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Hora Entrada"
        Me.GridColumn4.FieldName = "diaHoraIng"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Hora Salida"
        Me.GridColumn5.FieldName = "diaHoraSal"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseFont = True
        Me.GridColumn6.Caption = "Monto (S/.)"
        Me.GridColumn6.FieldName = "diaPrecio"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "diaPrecio", "Total : {0:###,##0.00}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "tgTipoAbonoId"
        Me.GridColumn8.FieldName = "tgTipoAbonoId"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tipo"
        Me.GridColumn9.FieldName = "tgTipoAbono"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Usuario ID"
        Me.GridColumn10.FieldName = "usuario"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "perId"
        Me.GridColumn11.FieldName = "perId"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Usuario"
        Me.GridColumn12.FieldName = "persona"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Fecha Sal."
        Me.GridColumn13.FieldName = "diaFechaSal"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(829, 13)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(79, 36)
        Me.btnExportar.TabIndex = 9
        Me.btnExportar.Text = "Exportar"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(550, 29)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel9.TabIndex = 7
        Me.SaimtLabel9.Text = "Buscar por"
        '
        'tmhora
        '
        Me.tmhora.Interval = 60000
        '
        'frmParqueoRinconada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 735)
        Me.Controls.Add(Me.SaimtGroupBox3)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmParqueoRinconada"
        Me.Tag = "btiIngresoVehiculo"
        Me.Text = "frmIngresoVehiculos"
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox3, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.chkSinPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtplaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.txtCapacidadDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcapacidadIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoVehiculo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCapacidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        Me.SaimtGroupBox3.PerformLayout()
        CType(Me.cboEstados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConceptosBusquedas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDiarioPEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDiarioPEM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents cboConcepto As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents btnOK As SaimtControles.SaimtButton
    Friend WithEvents txtplaca As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtCapacidadDisponible As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents txtcapacidadIN As SaimtControles.SaimtTextBox
    Friend WithEvents cboTipoVehiculo As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents txtCapacidad As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvDiarioPEM As SaimtControles.SaimtDataGrid
    Friend WithEvents gvDiarioPEM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExportar As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtHora As SaimtControles.SaimtTextBox
    Friend WithEvents txtfecha As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents btnBuscar As SaimtControles.SaimtButton
    Friend WithEvents cboConceptosBusquedas As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboEstados As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tmhora As System.Windows.Forms.Timer
    Friend WithEvents sfdExportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkSinPlaca As SaimtControles.SaimtCheckBox
End Class
