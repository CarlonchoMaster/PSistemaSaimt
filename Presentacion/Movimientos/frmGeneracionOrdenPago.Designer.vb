﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneracionOrdenPago
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
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.chkMarcarTodo = New SaimtControles.SaimtCheckBox()
        Me.dgvProgramacionPagos = New SaimtControles.SaimtDataGrid()
        Me.gvProgramacionPagos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gctgtipoCompId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcconInmId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcinmId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Año = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcproPaNroCuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcproPaFechaPag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Monto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDetracion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProPaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcmarcado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.dgvProgramacionPagosDet = New SaimtControles.SaimtDataGrid()
        Me.gvProgramacionPagosDet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcdSerieComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdNroComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdtgtipoCompId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdconInmId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdinmId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdAño = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdproPaNroCuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdproPaFechaPag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdDetracion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdPropaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.rdbOpciones = New SaimtControles.SaimtRadioGroup()
        Me.chkaplicaaniomes = New SaimtControles.SaimtCheckBox()
        Me.SaimtLabel16 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel17 = New SaimtControles.SaimtLabel()
        Me.cboAnioGenerar = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnBuscarXClienteGenerar = New SaimtControles.SaimtButton()
        Me.txtNroFinBoleta = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtSerieFactura = New SaimtControles.SaimtTextBox()
        Me.txtNroInicioFactura = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtSerieBoleta = New SaimtControles.SaimtTextBox()
        Me.TxtNroInicioBoleta = New SaimtControles.SaimtTextBox()
        Me.txtNroFinFactura = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.btnBuscarXMesGenerar = New SaimtControles.SaimtButton()
        Me.cboMesGenerar = New SaimtControles.SaimtComboBoxLookUp()
        Me.txtClienteGenerar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.btnAsignar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.SaimtTabs1 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SaimtButton1 = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox4 = New SaimtControles.SaimtGroupBox()
        Me.chkAnioMesAnular = New SaimtControles.SaimtCheckBox()
        Me.SaimtLabel18 = New SaimtControles.SaimtLabel()
        Me.cbAnioAnular = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnMostrarAnioMesAnular = New SaimtControles.SaimtButton()
        Me.cbMesAnular = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel19 = New SaimtControles.SaimtLabel()
        Me.rbNroCompCliente = New SaimtControles.SaimtRadioGroup()
        Me.btnNroCompCliente = New SaimtControles.SaimtButton()
        Me.txtBuscarNroCompCliente = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.btnAnular = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox5 = New SaimtControles.SaimtGroupBox()
        Me.SaimtCheckBox2 = New SaimtControles.SaimtCheckBox()
        Me.dgvProgramacionAnular = New SaimtControles.SaimtDataGrid()
        Me.gvProgramacionPagosAnular = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcaSerieComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcaNroComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcatgtipoCompId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcaconInmId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcainmId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcaPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcaAño = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcaproPaNroCuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcaproPaFechaPag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcaMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcaDetracion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcaPropaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcamarcado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.chkMarcarTodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.dgvProgramacionPagosDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionPagosDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.rdbOpciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkaplicaaniomes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAnioGenerar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroFinBoleta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroInicioFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieBoleta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNroInicioBoleta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroFinFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMesGenerar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClienteGenerar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox4.SuspendLayout()
        CType(Me.chkAnioMesAnular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAnioAnular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMesAnular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbNroCompCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarNroCompCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox5.SuspendLayout()
        CType(Me.SaimtCheckBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProgramacionAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionPagosAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 613)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1034, 27)
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.chkMarcarTodo)
        Me.SaimtGroupBox2.Controls.Add(Me.dgvProgramacionPagos)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(11, 75)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(942, 219)
        Me.SaimtGroupBox2.TabIndex = 1
        Me.SaimtGroupBox2.Text = "Programación de Pagos"
        '
        'chkMarcarTodo
        '
        Me.chkMarcarTodo.Location = New System.Drawing.Point(189, 1)
        Me.chkMarcarTodo.MenuManager = Me.RibbonControl
        Me.chkMarcarTodo.Name = "chkMarcarTodo"
        Me.chkMarcarTodo.Properties.AutoWidth = True
        Me.chkMarcarTodo.Properties.Caption = "Marcar todo"
        Me.chkMarcarTodo.Size = New System.Drawing.Size(80, 19)
        Me.chkMarcarTodo.TabIndex = 0
        '
        'dgvProgramacionPagos
        '
        Me.dgvProgramacionPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProgramacionPagos.Location = New System.Drawing.Point(2, 22)
        Me.dgvProgramacionPagos.MainView = Me.gvProgramacionPagos
        Me.dgvProgramacionPagos.MenuManager = Me.RibbonControl
        Me.dgvProgramacionPagos.Name = "dgvProgramacionPagos"
        Me.dgvProgramacionPagos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemComboBox1})
        Me.dgvProgramacionPagos.Size = New System.Drawing.Size(938, 195)
        Me.dgvProgramacionPagos.TabIndex = 1
        Me.dgvProgramacionPagos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionPagos})
        '
        'gvProgramacionPagos
        '
        Me.gvProgramacionPagos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gctgtipoCompId, Me.gcconInmId, Me.gcinmId, Me.gcPersona, Me.Año, Me.gcproPaNroCuota, Me.gcproPaFechaPag, Me.Monto, Me.gcDetracion, Me.ProPaId, Me.gcmarcado})
        Me.gvProgramacionPagos.GridControl = Me.dgvProgramacionPagos
        Me.gvProgramacionPagos.Name = "gvProgramacionPagos"
        Me.gvProgramacionPagos.OptionsView.ColumnAutoWidth = False
        Me.gvProgramacionPagos.OptionsView.ShowGroupPanel = False
        '
        'gctgtipoCompId
        '
        Me.gctgtipoCompId.Caption = "Comprobante"
        Me.gctgtipoCompId.FieldName = "tgtipoCompId"
        Me.gctgtipoCompId.Name = "gctgtipoCompId"
        Me.gctgtipoCompId.Visible = True
        Me.gctgtipoCompId.VisibleIndex = 0
        '
        'gcconInmId
        '
        Me.gcconInmId.Caption = "Cod. Contrato"
        Me.gcconInmId.FieldName = "conInmId"
        Me.gcconInmId.Name = "gcconInmId"
        Me.gcconInmId.Visible = True
        Me.gcconInmId.VisibleIndex = 1
        '
        'gcinmId
        '
        Me.gcinmId.Caption = "Cod. Inmueble"
        Me.gcinmId.FieldName = "inmId"
        Me.gcinmId.Name = "gcinmId"
        Me.gcinmId.Visible = True
        Me.gcinmId.VisibleIndex = 2
        '
        'gcPersona
        '
        Me.gcPersona.Caption = "Persona"
        Me.gcPersona.FieldName = "Persona"
        Me.gcPersona.Name = "gcPersona"
        Me.gcPersona.Visible = True
        Me.gcPersona.VisibleIndex = 3
        '
        'Año
        '
        Me.Año.Caption = "Año"
        Me.Año.FieldName = "Año"
        Me.Año.Name = "Año"
        Me.Año.Visible = True
        Me.Año.VisibleIndex = 4
        '
        'gcproPaNroCuota
        '
        Me.gcproPaNroCuota.Caption = "Nro. Cuota"
        Me.gcproPaNroCuota.FieldName = "proPaNroCuota"
        Me.gcproPaNroCuota.Name = "gcproPaNroCuota"
        Me.gcproPaNroCuota.Visible = True
        Me.gcproPaNroCuota.VisibleIndex = 5
        '
        'gcproPaFechaPag
        '
        Me.gcproPaFechaPag.Caption = "Fecha Pago"
        Me.gcproPaFechaPag.FieldName = "proPaFechaPag"
        Me.gcproPaFechaPag.Name = "gcproPaFechaPag"
        Me.gcproPaFechaPag.Visible = True
        Me.gcproPaFechaPag.VisibleIndex = 6
        '
        'Monto
        '
        Me.Monto.Caption = "Monto"
        Me.Monto.FieldName = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Visible = True
        Me.Monto.VisibleIndex = 7
        '
        'gcDetracion
        '
        Me.gcDetracion.Caption = "Detracion"
        Me.gcDetracion.FieldName = "Detracion"
        Me.gcDetracion.Name = "gcDetracion"
        Me.gcDetracion.Visible = True
        Me.gcDetracion.VisibleIndex = 8
        '
        'ProPaId
        '
        Me.ProPaId.Caption = "ProPaId"
        Me.ProPaId.FieldName = "ProPaId"
        Me.ProPaId.Name = "ProPaId"
        '
        'gcmarcado
        '
        Me.gcmarcado.FieldName = "marcado"
        Me.gcmarcado.Name = "gcmarcado"
        Me.gcmarcado.Visible = True
        Me.gcmarcado.VisibleIndex = 9
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.btnLimpiar)
        Me.SaimtGroupBox1.Controls.Add(Me.dgvProgramacionPagosDet)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(13, 293)
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(940, 245)
        Me.SaimtGroupBox1.TabIndex = 3
        Me.SaimtGroupBox1.Text = "Detalle de Comprobante de Pago"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.Presentacion.My.Resources.Resources.limpiar16
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(906, 2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(31, 23)
        Me.btnLimpiar.TabIndex = 0
        '
        'dgvProgramacionPagosDet
        '
        Me.dgvProgramacionPagosDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProgramacionPagosDet.Location = New System.Drawing.Point(2, 22)
        Me.dgvProgramacionPagosDet.MainView = Me.gvProgramacionPagosDet
        Me.dgvProgramacionPagosDet.MenuManager = Me.RibbonControl
        Me.dgvProgramacionPagosDet.Name = "dgvProgramacionPagosDet"
        Me.dgvProgramacionPagosDet.Size = New System.Drawing.Size(936, 221)
        Me.dgvProgramacionPagosDet.TabIndex = 1
        Me.dgvProgramacionPagosDet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionPagosDet})
        '
        'gvProgramacionPagosDet
        '
        Me.gvProgramacionPagosDet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcdSerieComp, Me.gcdNroComp, Me.gcdtgtipoCompId, Me.gcdconInmId, Me.gcdinmId, Me.gcdPersona, Me.gcdAño, Me.gcdproPaNroCuota, Me.gcdproPaFechaPag, Me.gcdMonto, Me.gcdDetracion, Me.gcdPropaId})
        Me.gvProgramacionPagosDet.GridControl = Me.dgvProgramacionPagosDet
        Me.gvProgramacionPagosDet.Name = "gvProgramacionPagosDet"
        Me.gvProgramacionPagosDet.OptionsView.ShowGroupPanel = False
        '
        'gcdSerieComp
        '
        Me.gcdSerieComp.Caption = "Serie"
        Me.gcdSerieComp.FieldName = "SerieComp"
        Me.gcdSerieComp.Name = "gcdSerieComp"
        Me.gcdSerieComp.Visible = True
        Me.gcdSerieComp.VisibleIndex = 0
        '
        'gcdNroComp
        '
        Me.gcdNroComp.Caption = "Nro Comp."
        Me.gcdNroComp.FieldName = "NroComp"
        Me.gcdNroComp.Name = "gcdNroComp"
        Me.gcdNroComp.Visible = True
        Me.gcdNroComp.VisibleIndex = 1
        '
        'gcdtgtipoCompId
        '
        Me.gcdtgtipoCompId.Caption = "Comprobante"
        Me.gcdtgtipoCompId.FieldName = "tgtipoCompId"
        Me.gcdtgtipoCompId.Name = "gcdtgtipoCompId"
        Me.gcdtgtipoCompId.Visible = True
        Me.gcdtgtipoCompId.VisibleIndex = 2
        '
        'gcdconInmId
        '
        Me.gcdconInmId.Caption = "Cod. Contrato"
        Me.gcdconInmId.FieldName = "conInmId"
        Me.gcdconInmId.Name = "gcdconInmId"
        Me.gcdconInmId.Visible = True
        Me.gcdconInmId.VisibleIndex = 3
        '
        'gcdinmId
        '
        Me.gcdinmId.Caption = "Cod. Inmueble"
        Me.gcdinmId.FieldName = "inmId"
        Me.gcdinmId.Name = "gcdinmId"
        Me.gcdinmId.Visible = True
        Me.gcdinmId.VisibleIndex = 4
        '
        'gcdPersona
        '
        Me.gcdPersona.Caption = "Persona"
        Me.gcdPersona.FieldName = "Persona"
        Me.gcdPersona.Name = "gcdPersona"
        Me.gcdPersona.Visible = True
        Me.gcdPersona.VisibleIndex = 5
        '
        'gcdAño
        '
        Me.gcdAño.Caption = "Año"
        Me.gcdAño.FieldName = "Año"
        Me.gcdAño.Name = "gcdAño"
        Me.gcdAño.Visible = True
        Me.gcdAño.VisibleIndex = 6
        '
        'gcdproPaNroCuota
        '
        Me.gcdproPaNroCuota.Caption = "Nro. Cuota"
        Me.gcdproPaNroCuota.FieldName = "proPaNroCuota"
        Me.gcdproPaNroCuota.Name = "gcdproPaNroCuota"
        Me.gcdproPaNroCuota.Visible = True
        Me.gcdproPaNroCuota.VisibleIndex = 7
        '
        'gcdproPaFechaPag
        '
        Me.gcdproPaFechaPag.Caption = "Fecha Pago"
        Me.gcdproPaFechaPag.FieldName = "proPaFechaPag"
        Me.gcdproPaFechaPag.Name = "gcdproPaFechaPag"
        Me.gcdproPaFechaPag.Visible = True
        Me.gcdproPaFechaPag.VisibleIndex = 8
        '
        'gcdMonto
        '
        Me.gcdMonto.Caption = "Monto"
        Me.gcdMonto.FieldName = "Monto"
        Me.gcdMonto.Name = "gcdMonto"
        Me.gcdMonto.Visible = True
        Me.gcdMonto.VisibleIndex = 9
        '
        'gcdDetracion
        '
        Me.gcdDetracion.Caption = "Detracion"
        Me.gcdDetracion.FieldName = "Detracion"
        Me.gcdDetracion.Name = "gcdDetracion"
        Me.gcdDetracion.Visible = True
        Me.gcdDetracion.VisibleIndex = 10
        '
        'gcdPropaId
        '
        Me.gcdPropaId.Caption = "PropaId"
        Me.gcdPropaId.FieldName = "PropaId"
        Me.gcdPropaId.Name = "gcdPropaId"
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Controls.Add(Me.rdbOpciones)
        Me.SaimtGroupBox3.Controls.Add(Me.chkaplicaaniomes)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel16)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel17)
        Me.SaimtGroupBox3.Controls.Add(Me.cboAnioGenerar)
        Me.SaimtGroupBox3.Controls.Add(Me.btnBuscarXClienteGenerar)
        Me.SaimtGroupBox3.Controls.Add(Me.txtNroFinBoleta)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox3.Controls.Add(Me.txtSerieFactura)
        Me.SaimtGroupBox3.Controls.Add(Me.txtNroInicioFactura)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox3.Controls.Add(Me.txtSerieBoleta)
        Me.SaimtGroupBox3.Controls.Add(Me.TxtNroInicioBoleta)
        Me.SaimtGroupBox3.Controls.Add(Me.txtNroFinFactura)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel15)
        Me.SaimtGroupBox3.Controls.Add(Me.btnBuscarXMesGenerar)
        Me.SaimtGroupBox3.Controls.Add(Me.cboMesGenerar)
        Me.SaimtGroupBox3.Controls.Add(Me.txtClienteGenerar)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(11, 3)
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(855, 70)
        Me.SaimtGroupBox3.TabIndex = 0
        Me.SaimtGroupBox3.Text = "Busqueda de cuotas :"
        '
        'rdbOpciones
        '
        Me.rdbOpciones.Location = New System.Drawing.Point(221, -1)
        Me.rdbOpciones.MenuManager = Me.RibbonControl
        Me.rdbOpciones.Name = "rdbOpciones"
        Me.rdbOpciones.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rdbOpciones.Properties.Appearance.Options.UseBackColor = True
        Me.rdbOpciones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdbOpciones.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Todas"), New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Anuladas"), New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Canceladas")})
        Me.rdbOpciones.Size = New System.Drawing.Size(352, 20)
        Me.rdbOpciones.TabIndex = 0
        '
        'chkaplicaaniomes
        '
        Me.chkaplicaaniomes.Location = New System.Drawing.Point(320, 26)
        Me.chkaplicaaniomes.MenuManager = Me.RibbonControl
        Me.chkaplicaaniomes.Name = "chkaplicaaniomes"
        Me.chkaplicaaniomes.Properties.AutoWidth = True
        Me.chkaplicaaniomes.Properties.Caption = "Aplica Anio Mes"
        Me.chkaplicaaniomes.Size = New System.Drawing.Size(96, 19)
        Me.chkaplicaaniomes.TabIndex = 6
        '
        'SaimtLabel16
        '
        Me.SaimtLabel16.Location = New System.Drawing.Point(626, 29)
        Me.SaimtLabel16.Name = "SaimtLabel16"
        Me.SaimtLabel16.Size = New System.Drawing.Size(4, 13)
        Me.SaimtLabel16.TabIndex = 10
        Me.SaimtLabel16.Text = "-"
        '
        'SaimtLabel17
        '
        Me.SaimtLabel17.Location = New System.Drawing.Point(163, 28)
        Me.SaimtLabel17.Name = "SaimtLabel17"
        Me.SaimtLabel17.Size = New System.Drawing.Size(26, 13)
        Me.SaimtLabel17.TabIndex = 3
        Me.SaimtLabel17.Text = "Mes :"
        '
        'cboAnioGenerar
        '
        Me.cboAnioGenerar.Location = New System.Drawing.Point(68, 25)
        Me.cboAnioGenerar.MenuManager = Me.RibbonControl
        Me.cboAnioGenerar.Name = "cboAnioGenerar"
        Me.cboAnioGenerar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAnioGenerar.Properties.NullText = ""
        Me.cboAnioGenerar.Size = New System.Drawing.Size(89, 20)
        Me.cboAnioGenerar.TabIndex = 2
        '
        'btnBuscarXClienteGenerar
        '
        Me.btnBuscarXClienteGenerar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscarXClienteGenerar.Location = New System.Drawing.Point(371, 47)
        Me.btnBuscarXClienteGenerar.Name = "btnBuscarXClienteGenerar"
        Me.btnBuscarXClienteGenerar.Size = New System.Drawing.Size(25, 21)
        Me.btnBuscarXClienteGenerar.TabIndex = 14
        '
        'txtNroFinBoleta
        '
        Me.txtNroFinBoleta.Location = New System.Drawing.Point(636, 48)
        Me.txtNroFinBoleta.Name = "txtNroFinBoleta"
        Me.txtNroFinBoleta.Size = New System.Drawing.Size(77, 20)
        Me.txtNroFinBoleta.TabIndex = 19
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(626, 51)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(4, 13)
        Me.SaimtLabel1.TabIndex = 18
        Me.SaimtLabel1.Text = "-"
        '
        'txtSerieFactura
        '
        Me.txtSerieFactura.Location = New System.Drawing.Point(525, 25)
        Me.txtSerieFactura.Name = "txtSerieFactura"
        Me.txtSerieFactura.Size = New System.Drawing.Size(39, 20)
        Me.txtSerieFactura.TabIndex = 8
        '
        'txtNroInicioFactura
        '
        Me.txtNroInicioFactura.Location = New System.Drawing.Point(570, 25)
        Me.txtNroInicioFactura.MenuManager = Me.RibbonControl
        Me.txtNroInicioFactura.Name = "txtNroInicioFactura"
        Me.txtNroInicioFactura.Size = New System.Drawing.Size(50, 20)
        Me.txtNroInicioFactura.TabIndex = 9
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(449, 26)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(73, 13)
        Me.SaimtLabel3.TabIndex = 7
        Me.SaimtLabel3.Text = "N° Inicial de F :"
        '
        'txtSerieBoleta
        '
        Me.txtSerieBoleta.Location = New System.Drawing.Point(525, 48)
        Me.txtSerieBoleta.Name = "txtSerieBoleta"
        Me.txtSerieBoleta.Size = New System.Drawing.Size(39, 20)
        Me.txtSerieBoleta.TabIndex = 16
        '
        'TxtNroInicioBoleta
        '
        Me.TxtNroInicioBoleta.Location = New System.Drawing.Point(570, 48)
        Me.TxtNroInicioBoleta.Name = "TxtNroInicioBoleta"
        Me.TxtNroInicioBoleta.Size = New System.Drawing.Size(50, 20)
        Me.TxtNroInicioBoleta.TabIndex = 17
        '
        'txtNroFinFactura
        '
        Me.txtNroFinFactura.Location = New System.Drawing.Point(636, 25)
        Me.txtNroFinFactura.MenuManager = Me.RibbonControl
        Me.txtNroFinFactura.Name = "txtNroFinFactura"
        Me.txtNroFinFactura.Size = New System.Drawing.Size(77, 20)
        Me.txtNroFinFactura.TabIndex = 11
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(449, 51)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(73, 13)
        Me.SaimtLabel15.TabIndex = 15
        Me.SaimtLabel15.Text = "N° Inicial de B :"
        '
        'btnBuscarXMesGenerar
        '
        Me.btnBuscarXMesGenerar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscarXMesGenerar.Location = New System.Drawing.Point(289, 24)
        Me.btnBuscarXMesGenerar.Name = "btnBuscarXMesGenerar"
        Me.btnBuscarXMesGenerar.Size = New System.Drawing.Size(25, 21)
        Me.btnBuscarXMesGenerar.TabIndex = 5
        '
        'cboMesGenerar
        '
        Me.cboMesGenerar.Location = New System.Drawing.Point(194, 25)
        Me.cboMesGenerar.MenuManager = Me.RibbonControl
        Me.cboMesGenerar.Name = "cboMesGenerar"
        Me.cboMesGenerar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMesGenerar.Properties.NullText = ""
        Me.cboMesGenerar.Size = New System.Drawing.Size(89, 20)
        Me.cboMesGenerar.TabIndex = 4
        '
        'txtClienteGenerar
        '
        Me.txtClienteGenerar.Location = New System.Drawing.Point(68, 48)
        Me.txtClienteGenerar.Name = "txtClienteGenerar"
        Me.txtClienteGenerar.Size = New System.Drawing.Size(295, 20)
        Me.txtClienteGenerar.TabIndex = 13
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(1, 28)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(61, 13)
        Me.SaimtLabel2.TabIndex = 1
        Me.SaimtLabel2.Text = "Fecha  Año :"
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(21, 51)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(40, 13)
        Me.SaimtLabel4.TabIndex = 12
        Me.SaimtLabel4.Text = "Cliente :"
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = Global.Presentacion.My.Resources.Resources.cancelardata48
        Me.btnAsignar.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter
        Me.btnAsignar.Location = New System.Drawing.Point(959, 103)
        Me.btnAsignar.LookAndFeel.SkinName = "Seven"
        Me.btnAsignar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(59, 71)
        Me.btnAsignar.TabIndex = 2
        Me.btnAsignar.Text = "Asignar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.generar32
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(363, 544)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(194, 34)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Generar Comprobante de Pago"
        '
        'SaimtTabs1
        '
        Me.SaimtTabs1.Location = New System.Drawing.Point(4, 3)
        Me.SaimtTabs1.Name = "SaimtTabs1"
        Me.SaimtTabs1.SelectedTabPage = Me.XtraTabPage1
        Me.SaimtTabs1.Size = New System.Drawing.Size(1030, 609)
        Me.SaimtTabs1.TabIndex = 0
        Me.SaimtTabs1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SaimtGroupBox3)
        Me.XtraTabPage1.Controls.Add(Me.btnGuardar)
        Me.XtraTabPage1.Controls.Add(Me.SaimtGroupBox2)
        Me.XtraTabPage1.Controls.Add(Me.btnAsignar)
        Me.XtraTabPage1.Controls.Add(Me.SaimtGroupBox1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1024, 580)
        Me.XtraTabPage1.Text = "Generar"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.SaimtButton1)
        Me.XtraTabPage2.Controls.Add(Me.SaimtGroupBox4)
        Me.XtraTabPage2.Controls.Add(Me.btnAnular)
        Me.XtraTabPage2.Controls.Add(Me.SaimtGroupBox5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1024, 580)
        Me.XtraTabPage2.Text = "Anular"
        '
        'SaimtButton1
        '
        Me.SaimtButton1.Image = Global.Presentacion.My.Resources.Resources.generar32
        Me.SaimtButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SaimtButton1.Location = New System.Drawing.Point(506, 546)
        Me.SaimtButton1.LookAndFeel.SkinName = "Seven"
        Me.SaimtButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SaimtButton1.Name = "SaimtButton1"
        Me.SaimtButton1.Size = New System.Drawing.Size(143, 34)
        Me.SaimtButton1.TabIndex = 3
        Me.SaimtButton1.Text = "Guardar Cancelados"
        '
        'SaimtGroupBox4
        '
        Me.SaimtGroupBox4.Controls.Add(Me.chkAnioMesAnular)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel18)
        Me.SaimtGroupBox4.Controls.Add(Me.cbAnioAnular)
        Me.SaimtGroupBox4.Controls.Add(Me.btnMostrarAnioMesAnular)
        Me.SaimtGroupBox4.Controls.Add(Me.cbMesAnular)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel19)
        Me.SaimtGroupBox4.Controls.Add(Me.rbNroCompCliente)
        Me.SaimtGroupBox4.Controls.Add(Me.btnNroCompCliente)
        Me.SaimtGroupBox4.Controls.Add(Me.txtBuscarNroCompCliente)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox4.Location = New System.Drawing.Point(11, 6)
        Me.SaimtGroupBox4.Name = "SaimtGroupBox4"
        Me.SaimtGroupBox4.Size = New System.Drawing.Size(918, 55)
        Me.SaimtGroupBox4.TabIndex = 0
        Me.SaimtGroupBox4.Text = "Busqueda de comprobantes por :"
        '
        'chkAnioMesAnular
        '
        Me.chkAnioMesAnular.Location = New System.Drawing.Point(585, 1)
        Me.chkAnioMesAnular.MenuManager = Me.RibbonControl
        Me.chkAnioMesAnular.Name = "chkAnioMesAnular"
        Me.chkAnioMesAnular.Properties.AutoWidth = True
        Me.chkAnioMesAnular.Properties.Caption = "Aplica Anio Mes"
        Me.chkAnioMesAnular.Size = New System.Drawing.Size(96, 19)
        Me.chkAnioMesAnular.TabIndex = 1
        '
        'SaimtLabel18
        '
        Me.SaimtLabel18.Location = New System.Drawing.Point(179, 29)
        Me.SaimtLabel18.Name = "SaimtLabel18"
        Me.SaimtLabel18.Size = New System.Drawing.Size(26, 13)
        Me.SaimtLabel18.TabIndex = 4
        Me.SaimtLabel18.Text = "Mes :"
        '
        'cbAnioAnular
        '
        Me.cbAnioAnular.Location = New System.Drawing.Point(76, 26)
        Me.cbAnioAnular.MenuManager = Me.RibbonControl
        Me.cbAnioAnular.Name = "cbAnioAnular"
        Me.cbAnioAnular.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAnioAnular.Properties.NullText = ""
        Me.cbAnioAnular.Size = New System.Drawing.Size(89, 20)
        Me.cbAnioAnular.TabIndex = 3
        '
        'btnMostrarAnioMesAnular
        '
        Me.btnMostrarAnioMesAnular.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnMostrarAnioMesAnular.Location = New System.Drawing.Point(305, 25)
        Me.btnMostrarAnioMesAnular.Name = "btnMostrarAnioMesAnular"
        Me.btnMostrarAnioMesAnular.Size = New System.Drawing.Size(25, 21)
        Me.btnMostrarAnioMesAnular.TabIndex = 7
        '
        'cbMesAnular
        '
        Me.cbMesAnular.Location = New System.Drawing.Point(210, 26)
        Me.cbMesAnular.MenuManager = Me.RibbonControl
        Me.cbMesAnular.Name = "cbMesAnular"
        Me.cbMesAnular.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMesAnular.Properties.NullText = ""
        Me.cbMesAnular.Size = New System.Drawing.Size(89, 20)
        Me.cbMesAnular.TabIndex = 5
        '
        'SaimtLabel19
        '
        Me.SaimtLabel19.Location = New System.Drawing.Point(9, 29)
        Me.SaimtLabel19.Name = "SaimtLabel19"
        Me.SaimtLabel19.Size = New System.Drawing.Size(61, 13)
        Me.SaimtLabel19.TabIndex = 2
        Me.SaimtLabel19.Text = "Fecha  Año :"
        '
        'rbNroCompCliente
        '
        Me.rbNroCompCliente.Location = New System.Drawing.Point(339, 0)
        Me.rbNroCompCliente.MenuManager = Me.RibbonControl
        Me.rbNroCompCliente.Name = "rbNroCompCliente"
        Me.rbNroCompCliente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rbNroCompCliente.Properties.Appearance.Options.UseBackColor = True
        Me.rbNroCompCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rbNroCompCliente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "N° Comprobante"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Cliente")})
        Me.rbNroCompCliente.Size = New System.Drawing.Size(352, 20)
        Me.rbNroCompCliente.TabIndex = 0
        '
        'btnNroCompCliente
        '
        Me.btnNroCompCliente.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnNroCompCliente.Location = New System.Drawing.Point(824, 25)
        Me.btnNroCompCliente.Name = "btnNroCompCliente"
        Me.btnNroCompCliente.Size = New System.Drawing.Size(25, 21)
        Me.btnNroCompCliente.TabIndex = 9
        '
        'txtBuscarNroCompCliente
        '
        Me.txtBuscarNroCompCliente.Location = New System.Drawing.Point(339, 26)
        Me.txtBuscarNroCompCliente.Name = "txtBuscarNroCompCliente"
        Me.txtBuscarNroCompCliente.Size = New System.Drawing.Size(479, 20)
        Me.txtBuscarNroCompCliente.TabIndex = 8
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(210, 33)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(44, 13)
        Me.SaimtLabel6.TabIndex = 6
        Me.SaimtLabel6.Text = "Nombre :"
        '
        'btnAnular
        '
        Me.btnAnular.Image = Global.Presentacion.My.Resources.Resources.generar32
        Me.btnAnular.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnAnular.Location = New System.Drawing.Point(350, 546)
        Me.btnAnular.LookAndFeel.SkinName = "Seven"
        Me.btnAnular.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(133, 34)
        Me.btnAnular.TabIndex = 2
        Me.btnAnular.Text = "Guardar Anulados"
        '
        'SaimtGroupBox5
        '
        Me.SaimtGroupBox5.Controls.Add(Me.SaimtCheckBox2)
        Me.SaimtGroupBox5.Controls.Add(Me.dgvProgramacionAnular)
        Me.SaimtGroupBox5.Location = New System.Drawing.Point(11, 67)
        Me.SaimtGroupBox5.Name = "SaimtGroupBox5"
        Me.SaimtGroupBox5.Size = New System.Drawing.Size(920, 475)
        Me.SaimtGroupBox5.TabIndex = 1
        Me.SaimtGroupBox5.Text = "Comprobantes de Pago"
        '
        'SaimtCheckBox2
        '
        Me.SaimtCheckBox2.Location = New System.Drawing.Point(172, 0)
        Me.SaimtCheckBox2.MenuManager = Me.RibbonControl
        Me.SaimtCheckBox2.Name = "SaimtCheckBox2"
        Me.SaimtCheckBox2.Properties.AutoWidth = True
        Me.SaimtCheckBox2.Properties.Caption = "Marcar todo"
        Me.SaimtCheckBox2.Size = New System.Drawing.Size(80, 19)
        Me.SaimtCheckBox2.TabIndex = 0
        '
        'dgvProgramacionAnular
        '
        Me.dgvProgramacionAnular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProgramacionAnular.Location = New System.Drawing.Point(2, 21)
        Me.dgvProgramacionAnular.MainView = Me.gvProgramacionPagosAnular
        Me.dgvProgramacionAnular.MenuManager = Me.RibbonControl
        Me.dgvProgramacionAnular.Name = "dgvProgramacionAnular"
        Me.dgvProgramacionAnular.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2, Me.RepositoryItemComboBox2})
        Me.dgvProgramacionAnular.Size = New System.Drawing.Size(916, 452)
        Me.dgvProgramacionAnular.TabIndex = 1
        Me.dgvProgramacionAnular.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionPagosAnular})
        '
        'gvProgramacionPagosAnular
        '
        Me.gvProgramacionPagosAnular.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcaSerieComp, Me.gcaNroComp, Me.gcatgtipoCompId, Me.gcaconInmId, Me.gcainmId, Me.gcaPersona, Me.gcaAño, Me.gcaproPaNroCuota, Me.gcaproPaFechaPag, Me.gcaMonto, Me.gcaDetracion, Me.gcaPropaId, Me.gcamarcado})
        Me.gvProgramacionPagosAnular.GridControl = Me.dgvProgramacionAnular
        Me.gvProgramacionPagosAnular.Name = "gvProgramacionPagosAnular"
        Me.gvProgramacionPagosAnular.OptionsView.ColumnAutoWidth = False
        Me.gvProgramacionPagosAnular.OptionsView.ShowGroupPanel = False
        '
        'gcaSerieComp
        '
        Me.gcaSerieComp.Caption = "Serie"
        Me.gcaSerieComp.FieldName = "SerieComp"
        Me.gcaSerieComp.Name = "gcaSerieComp"
        Me.gcaSerieComp.Visible = True
        Me.gcaSerieComp.VisibleIndex = 0
        '
        'gcaNroComp
        '
        Me.gcaNroComp.Caption = "Nro Comp."
        Me.gcaNroComp.FieldName = "NroComp"
        Me.gcaNroComp.Name = "gcaNroComp"
        Me.gcaNroComp.Visible = True
        Me.gcaNroComp.VisibleIndex = 1
        '
        'gcatgtipoCompId
        '
        Me.gcatgtipoCompId.Caption = "Comprobante"
        Me.gcatgtipoCompId.FieldName = "tgtipoCompId"
        Me.gcatgtipoCompId.Name = "gcatgtipoCompId"
        Me.gcatgtipoCompId.Visible = True
        Me.gcatgtipoCompId.VisibleIndex = 2
        '
        'gcaconInmId
        '
        Me.gcaconInmId.Caption = "Cod. Contrato"
        Me.gcaconInmId.FieldName = "conInmId"
        Me.gcaconInmId.Name = "gcaconInmId"
        Me.gcaconInmId.Visible = True
        Me.gcaconInmId.VisibleIndex = 3
        '
        'gcainmId
        '
        Me.gcainmId.Caption = "Cod. Inmueble"
        Me.gcainmId.FieldName = "inmId"
        Me.gcainmId.Name = "gcainmId"
        Me.gcainmId.Visible = True
        Me.gcainmId.VisibleIndex = 4
        '
        'gcaPersona
        '
        Me.gcaPersona.Caption = "Persona"
        Me.gcaPersona.FieldName = "Persona"
        Me.gcaPersona.Name = "gcaPersona"
        Me.gcaPersona.Visible = True
        Me.gcaPersona.VisibleIndex = 5
        '
        'gcaAño
        '
        Me.gcaAño.Caption = "Año"
        Me.gcaAño.FieldName = "Año"
        Me.gcaAño.Name = "gcaAño"
        Me.gcaAño.Visible = True
        Me.gcaAño.VisibleIndex = 6
        '
        'gcaproPaNroCuota
        '
        Me.gcaproPaNroCuota.Caption = "Nro. Cuota"
        Me.gcaproPaNroCuota.FieldName = "proPaNroCuota"
        Me.gcaproPaNroCuota.Name = "gcaproPaNroCuota"
        Me.gcaproPaNroCuota.Visible = True
        Me.gcaproPaNroCuota.VisibleIndex = 7
        '
        'gcaproPaFechaPag
        '
        Me.gcaproPaFechaPag.Caption = "Fecha Pago"
        Me.gcaproPaFechaPag.FieldName = "proPaFechaPag"
        Me.gcaproPaFechaPag.Name = "gcaproPaFechaPag"
        Me.gcaproPaFechaPag.Visible = True
        Me.gcaproPaFechaPag.VisibleIndex = 8
        '
        'gcaMonto
        '
        Me.gcaMonto.Caption = "Monto"
        Me.gcaMonto.FieldName = "Monto"
        Me.gcaMonto.Name = "gcaMonto"
        Me.gcaMonto.Visible = True
        Me.gcaMonto.VisibleIndex = 9
        '
        'gcaDetracion
        '
        Me.gcaDetracion.Caption = "Detracion"
        Me.gcaDetracion.FieldName = "Detracion"
        Me.gcaDetracion.Name = "gcaDetracion"
        Me.gcaDetracion.Visible = True
        Me.gcaDetracion.VisibleIndex = 10
        '
        'gcaPropaId
        '
        Me.gcaPropaId.Caption = "PropaId"
        Me.gcaPropaId.FieldName = "PropaId"
        Me.gcaPropaId.Name = "gcaPropaId"
        '
        'gcamarcado
        '
        Me.gcamarcado.FieldName = "marcado"
        Me.gcamarcado.Name = "gcamarcado"
        Me.gcamarcado.Visible = True
        Me.gcamarcado.VisibleIndex = 11
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'frmGeneracionOrdenPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 640)
        Me.Controls.Add(Me.SaimtTabs1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmGeneracionOrdenPago"
        Me.Tag = "btiOrdenPago"
        Me.Text = "GENERACION DE COMPROBANTES DE PAGO"
        Me.Controls.SetChildIndex(Me.SaimtTabs1, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.chkMarcarTodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.dgvProgramacionPagosDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionPagosDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        Me.SaimtGroupBox3.PerformLayout()
        CType(Me.rdbOpciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkaplicaaniomes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAnioGenerar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroFinBoleta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroInicioFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieBoleta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNroInicioBoleta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroFinFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMesGenerar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClienteGenerar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox4.ResumeLayout(False)
        Me.SaimtGroupBox4.PerformLayout()
        CType(Me.chkAnioMesAnular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAnioAnular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMesAnular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbNroCompCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarNroCompCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox5.ResumeLayout(False)
        Me.SaimtGroupBox5.PerformLayout()
        CType(Me.SaimtCheckBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProgramacionAnular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionPagosAnular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvProgramacionPagos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionPagos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvProgramacionPagosDet As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionPagosDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkMarcarTodo As SaimtControles.SaimtCheckBox
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents btnAsignar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnBuscarXMesGenerar As SaimtControles.SaimtButton
    Friend WithEvents cboMesGenerar As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtTabs1 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtClienteGenerar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox4 As SaimtControles.SaimtGroupBox
    Friend WithEvents btnNroCompCliente As SaimtControles.SaimtButton
    Friend WithEvents txtBuscarNroCompCliente As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents btnAnular As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox5 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtCheckBox2 As SaimtControles.SaimtCheckBox
    Friend WithEvents dgvProgramacionAnular As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionPagosAnular As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents rbNroCompCliente As SaimtControles.SaimtRadioGroup
    Friend WithEvents btnBuscarXClienteGenerar As SaimtControles.SaimtButton
    Friend WithEvents txtNroFinBoleta As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtSerieFactura As SaimtControles.SaimtTextBox
    Friend WithEvents txtNroInicioFactura As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents txtSerieBoleta As SaimtControles.SaimtTextBox
    Friend WithEvents TxtNroInicioBoleta As SaimtControles.SaimtTextBox
    Friend WithEvents txtNroFinFactura As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel17 As SaimtControles.SaimtLabel
    Friend WithEvents cboAnioGenerar As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel16 As SaimtControles.SaimtLabel
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel18 As SaimtControles.SaimtLabel
    Friend WithEvents cbAnioAnular As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents btnMostrarAnioMesAnular As SaimtControles.SaimtButton
    Friend WithEvents cbMesAnular As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel19 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtButton1 As SaimtControles.SaimtButton
    Friend WithEvents chkaplicaaniomes As SaimtControles.SaimtCheckBox
    Friend WithEvents chkAnioMesAnular As SaimtControles.SaimtCheckBox
    Friend WithEvents rdbOpciones As SaimtControles.SaimtRadioGroup
    Friend WithEvents gctgtipoCompId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcconInmId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcinmId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Año As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcproPaNroCuota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcproPaFechaPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Monto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDetracion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProPaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcmarcado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdSerieComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdNroComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdtgtipoCompId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdconInmId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdinmId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdAño As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdproPaNroCuota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdproPaFechaPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdDetracion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdPropaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcaSerieComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcaNroComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcatgtipoCompId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcaconInmId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcainmId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcaPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcaAño As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcaproPaNroCuota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcaproPaFechaPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcaMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcaDetracion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcaPropaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcamarcado As DevExpress.XtraGrid.Columns.GridColumn
End Class
