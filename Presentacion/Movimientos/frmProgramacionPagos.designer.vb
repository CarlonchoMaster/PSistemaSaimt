﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramacionPagos
    Inherits Presentacion.frmMantenimientos

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramacionPagos))
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.grbContratos = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoContratos = New SaimtControles.SaimtDataGrid()
        Me.gvListadoContratos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grbPersona = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoPersona = New SaimtControles.SaimtDataGrid()
        Me.gvListadoPersona = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscarPersonaPor = New SaimtControles.SaimtTextBox()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.grbDatosContrato = New SaimtControles.SaimtGroupBox()
        Me.txtTipoDocumento = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.btnBuscarContrato = New SaimtControles.SaimtButton()
        Me.txtNroContrato = New SaimtControles.SaimtTextBox()
        Me.txtUso = New SaimtControles.SaimtTextBox()
        Me.txtTipoCambio = New SaimtControles.SaimtTextBox()
        Me.txtGarantia = New SaimtControles.SaimtTextBox()
        Me.txtDerLlave = New SaimtControles.SaimtTextBox()
        Me.txtMerConductiva = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel28 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel27 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel26 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel25 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel24 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel23 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel22 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel21 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel20 = New SaimtControles.SaimtLabel()
        Me.txtDirInmueble = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.txtFecTermino = New SaimtControles.SaimtTextBox()
        Me.txtFecInicio = New SaimtControles.SaimtTextBox()
        Me.txtTipoMoneda = New SaimtControles.SaimtTextBox()
        Me.txtEstado = New SaimtControles.SaimtTextBox()
        Me.txtCodInmueble = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.txtNombreRazon = New SaimtControles.SaimtTextBox()
        Me.txtTipoPersona = New SaimtControles.SaimtTextBox()
        Me.txtNroDocumento = New SaimtControles.SaimtTextBox()
        Me.SaimtGroupBox5 = New SaimtControles.SaimtGroupBox()
        Me.dgvDetalleProgramacionPagos = New SaimtControles.SaimtDataGrid()
        Me.gvDetalleProgramacionPagos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProPaIdDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConIdDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConNombreDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaDetPConceptoDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaDetMontoDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTemporalDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnQuitarDetalle = New SaimtControles.SaimtButton()
        Me.cboConcepto = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnAgregarDetallle = New SaimtControles.SaimtButton()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.txtMonto = New SaimtControles.SaimtTextBox()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.dgvProgramacionPagos = New SaimtControles.SaimtDataGrid()
        Me.gvProgramacionPagos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPropaNroCuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgTipoComprobante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaFechaPag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaFechaVen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgEstadoId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaDetIgv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaPMora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaComision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaAplicaD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgRecaudadoraId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgRecaudadora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTemporal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnComprobantePago = New SaimtControles.SaimtButton()
        Me.btnAplicaDetraccion = New SaimtControles.SaimtButton()
        Me.btnComprobante = New SaimtControles.SaimtButton()
        Me.spnNroCuotas = New SaimtControles.SaimtSpinner()
        Me.btnQuitarCuota = New SaimtControles.SaimtButton()
        Me.btnAgregarCuota = New SaimtControles.SaimtButton()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.cboTipoUso = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboBuscarContratoPor = New SaimtControles.SaimtComboBox()
        Me.txtBuscarContratoPor = New SaimtControles.SaimtTextBox()
        Me.cboBuscarPersonaPor = New SaimtControles.SaimtComboBox()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContratos.SuspendLayout()
        CType(Me.dgvListadoContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbPersona.SuspendLayout()
        CType(Me.dgvListadoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosContrato.SuspendLayout()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGarantia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDerLlave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMerConductiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDirInmueble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecTermino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodInmueble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreRazon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox5.SuspendLayout()
        CType(Me.dgvDetalleProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.dgvProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnNroCuotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.cboTipoUso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 692)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1306, 27)
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel13.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SaimtLabel13.Location = New System.Drawing.Point(10, 29)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(95, 16)
        Me.SaimtLabel13.TabIndex = 0
        Me.SaimtLabel13.Text = "N° CONTRATO :"
        '
        'grbContratos
        '
        Me.grbContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbContratos.Controls.Add(Me.dgvListadoContratos)
        Me.grbContratos.Location = New System.Drawing.Point(4, 451)
        Me.grbContratos.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbContratos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbContratos.Name = "grbContratos"
        Me.grbContratos.Size = New System.Drawing.Size(374, 235)
        Me.grbContratos.TabIndex = 7
        Me.grbContratos.Text = "Contratos"
        '
        'dgvListadoContratos
        '
        Me.dgvListadoContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoContratos.Location = New System.Drawing.Point(2, 21)
        Me.dgvListadoContratos.MainView = Me.gvListadoContratos
        Me.dgvListadoContratos.MenuManager = Me.RibbonControl
        Me.dgvListadoContratos.Name = "dgvListadoContratos"
        Me.dgvListadoContratos.Size = New System.Drawing.Size(370, 212)
        Me.dgvListadoContratos.TabIndex = 0
        Me.dgvListadoContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoContratos})
        '
        'gvListadoContratos
        '
        Me.gvListadoContratos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.gvListadoContratos.GridControl = Me.dgvListadoContratos
        Me.gvListadoContratos.Name = "gvListadoContratos"
        Me.gvListadoContratos.OptionsBehavior.ReadOnly = True
        Me.gvListadoContratos.OptionsView.ColumnAutoWidth = False
        Me.gvListadoContratos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cod. Contrato"
        Me.GridColumn4.FieldName = "conInmId"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha Inicio"
        Me.GridColumn5.FieldName = "conInmFecIni"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha Fin"
        Me.GridColumn6.FieldName = "conInmFecFin"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Dirección"
        Me.GridColumn7.FieldName = "inmUbicacion"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        '
        'grbPersona
        '
        Me.grbPersona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbPersona.Controls.Add(Me.dgvListadoPersona)
        Me.grbPersona.Location = New System.Drawing.Point(4, 66)
        Me.grbPersona.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbPersona.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbPersona.Name = "grbPersona"
        Me.grbPersona.Size = New System.Drawing.Size(374, 311)
        Me.grbPersona.TabIndex = 3
        Me.grbPersona.Text = "Lista de Arrendatarios"
        '
        'dgvListadoPersona
        '
        Me.dgvListadoPersona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoPersona.Location = New System.Drawing.Point(2, 21)
        Me.dgvListadoPersona.MainView = Me.gvListadoPersona
        Me.dgvListadoPersona.MenuManager = Me.RibbonControl
        Me.dgvListadoPersona.Name = "dgvListadoPersona"
        Me.dgvListadoPersona.Size = New System.Drawing.Size(370, 288)
        Me.dgvListadoPersona.TabIndex = 0
        Me.dgvListadoPersona.Tag = "0"
        Me.dgvListadoPersona.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoPersona})
        '
        'gvListadoPersona
        '
        Me.gvListadoPersona.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3})
        Me.gvListadoPersona.GridControl = Me.dgvListadoPersona
        Me.gvListadoPersona.Name = "gvListadoPersona"
        Me.gvListadoPersona.OptionsBehavior.ReadOnly = True
        Me.gvListadoPersona.OptionsView.ColumnAutoWidth = False
        Me.gvListadoPersona.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Cod. Persona"
        Me.GridColumn2.FieldName = "perId"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Persona"
        Me.GridColumn3.FieldName = "persona"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(8, 3)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(55, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Buscar por:"
        '
        'txtBuscarPersonaPor
        '
        Me.txtBuscarPersonaPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPersonaPor.Location = New System.Drawing.Point(4, 43)
        Me.txtBuscarPersonaPor.MenuManager = Me.RibbonControl
        Me.txtBuscarPersonaPor.Name = "txtBuscarPersonaPor"
        Me.txtBuscarPersonaPor.Size = New System.Drawing.Size(374, 20)
        Me.txtBuscarPersonaPor.TabIndex = 2
        Me.txtBuscarPersonaPor.Tag = "0"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(411, 624)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImprimir.Location = New System.Drawing.Point(551, 624)
        Me.btnImprimir.LookAndFeel.SkinName = "Seven"
        Me.btnImprimir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 64)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(341, 624)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(201, 624)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(481, 624)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(271, 624)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        '
        'grbDatosContrato
        '
        Me.grbDatosContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbDatosContrato.Controls.Add(Me.txtTipoDocumento)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel9)
        Me.grbDatosContrato.Controls.Add(Me.btnBuscarContrato)
        Me.grbDatosContrato.Controls.Add(Me.txtNroContrato)
        Me.grbDatosContrato.Controls.Add(Me.txtUso)
        Me.grbDatosContrato.Controls.Add(Me.txtTipoCambio)
        Me.grbDatosContrato.Controls.Add(Me.txtGarantia)
        Me.grbDatosContrato.Controls.Add(Me.txtDerLlave)
        Me.grbDatosContrato.Controls.Add(Me.txtMerConductiva)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel28)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel27)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel26)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel25)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel24)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel23)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel22)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel21)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel20)
        Me.grbDatosContrato.Controls.Add(Me.txtDirInmueble)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel6)
        Me.grbDatosContrato.Controls.Add(Me.txtFecTermino)
        Me.grbDatosContrato.Controls.Add(Me.txtFecInicio)
        Me.grbDatosContrato.Controls.Add(Me.txtTipoMoneda)
        Me.grbDatosContrato.Controls.Add(Me.txtEstado)
        Me.grbDatosContrato.Controls.Add(Me.txtCodInmueble)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel2)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel13)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel5)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel3)
        Me.grbDatosContrato.Controls.Add(Me.SaimtLabel8)
        Me.grbDatosContrato.Controls.Add(Me.txtNombreRazon)
        Me.grbDatosContrato.Controls.Add(Me.txtTipoPersona)
        Me.grbDatosContrato.Controls.Add(Me.txtNroDocumento)
        Me.grbDatosContrato.Location = New System.Drawing.Point(3, 7)
        Me.grbDatosContrato.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbDatosContrato.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbDatosContrato.Name = "grbDatosContrato"
        Me.grbDatosContrato.Size = New System.Drawing.Size(911, 122)
        Me.grbDatosContrato.TabIndex = 0
        Me.grbDatosContrato.Text = "Datos Contrato"
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.Location = New System.Drawing.Point(656, 50)
        Me.txtTipoDocumento.MenuManager = Me.RibbonControl
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.Size = New System.Drawing.Size(238, 20)
        Me.txtTipoDocumento.TabIndex = 14
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(609, 54)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(45, 13)
        Me.SaimtLabel9.TabIndex = 13
        Me.SaimtLabel9.Text = "Tipo Doc."
        '
        'btnBuscarContrato
        '
        Me.btnBuscarContrato.Image = CType(resources.GetObject("btnBuscarContrato.Image"), System.Drawing.Image)
        Me.btnBuscarContrato.Location = New System.Drawing.Point(199, 26)
        Me.btnBuscarContrato.Name = "btnBuscarContrato"
        Me.btnBuscarContrato.Size = New System.Drawing.Size(26, 23)
        Me.btnBuscarContrato.TabIndex = 1
        '
        'txtNroContrato
        '
        Me.txtNroContrato.EditValue = ""
        Me.txtNroContrato.Location = New System.Drawing.Point(110, 28)
        Me.txtNroContrato.MenuManager = Me.RibbonControl
        Me.txtNroContrato.Name = "txtNroContrato"
        Me.txtNroContrato.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNroContrato.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNroContrato.Properties.Appearance.Options.UseFont = True
        Me.txtNroContrato.Properties.Appearance.Options.UseForeColor = True
        Me.txtNroContrato.Size = New System.Drawing.Size(90, 20)
        Me.txtNroContrato.TabIndex = 2
        '
        'txtUso
        '
        Me.txtUso.Location = New System.Drawing.Point(656, 96)
        Me.txtUso.Name = "txtUso"
        Me.txtUso.Size = New System.Drawing.Size(238, 20)
        Me.txtUso.TabIndex = 32
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(299, 73)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(94, 20)
        Me.txtTipoCambio.TabIndex = 18
        '
        'txtGarantia
        '
        Me.txtGarantia.Location = New System.Drawing.Point(299, 96)
        Me.txtGarantia.Name = "txtGarantia"
        Me.txtGarantia.Size = New System.Drawing.Size(94, 20)
        Me.txtGarantia.TabIndex = 28
        '
        'txtDerLlave
        '
        Me.txtDerLlave.Location = New System.Drawing.Point(463, 96)
        Me.txtDerLlave.Name = "txtDerLlave"
        Me.txtDerLlave.Size = New System.Drawing.Size(97, 20)
        Me.txtDerLlave.TabIndex = 30
        '
        'txtMerConductiva
        '
        Me.txtMerConductiva.Location = New System.Drawing.Point(110, 96)
        Me.txtMerConductiva.MenuManager = Me.RibbonControl
        Me.txtMerConductiva.Name = "txtMerConductiva"
        Me.txtMerConductiva.Size = New System.Drawing.Size(100, 20)
        Me.txtMerConductiva.TabIndex = 26
        '
        'SaimtLabel28
        '
        Me.SaimtLabel28.Location = New System.Drawing.Point(248, 100)
        Me.SaimtLabel28.Name = "SaimtLabel28"
        Me.SaimtLabel28.Size = New System.Drawing.Size(48, 13)
        Me.SaimtLabel28.TabIndex = 27
        Me.SaimtLabel28.Text = "Garantia :"
        '
        'SaimtLabel27
        '
        Me.SaimtLabel27.Location = New System.Drawing.Point(5, 100)
        Me.SaimtLabel27.Name = "SaimtLabel27"
        Me.SaimtLabel27.Size = New System.Drawing.Size(99, 13)
        Me.SaimtLabel27.TabIndex = 25
        Me.SaimtLabel27.Text = "Merced Conductiva :"
        '
        'SaimtLabel26
        '
        Me.SaimtLabel26.Location = New System.Drawing.Point(404, 100)
        Me.SaimtLabel26.Name = "SaimtLabel26"
        Me.SaimtLabel26.Size = New System.Drawing.Size(53, 13)
        Me.SaimtLabel26.TabIndex = 29
        Me.SaimtLabel26.Text = "Der. llave :"
        '
        'SaimtLabel25
        '
        Me.SaimtLabel25.Location = New System.Drawing.Point(629, 100)
        Me.SaimtLabel25.Name = "SaimtLabel25"
        Me.SaimtLabel25.Size = New System.Drawing.Size(25, 13)
        Me.SaimtLabel25.TabIndex = 31
        Me.SaimtLabel25.Text = "Uso :"
        '
        'SaimtLabel24
        '
        Me.SaimtLabel24.Location = New System.Drawing.Point(585, 77)
        Me.SaimtLabel24.Name = "SaimtLabel24"
        Me.SaimtLabel24.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel24.TabIndex = 21
        Me.SaimtLabel24.Text = "Fec. Termino :"
        '
        'SaimtLabel23
        '
        Me.SaimtLabel23.Location = New System.Drawing.Point(401, 77)
        Me.SaimtLabel23.Name = "SaimtLabel23"
        Me.SaimtLabel23.Size = New System.Drawing.Size(56, 13)
        Me.SaimtLabel23.TabIndex = 19
        Me.SaimtLabel23.Text = "Fec. Inicio :"
        '
        'SaimtLabel22
        '
        Me.SaimtLabel22.Location = New System.Drawing.Point(231, 77)
        Me.SaimtLabel22.Name = "SaimtLabel22"
        Me.SaimtLabel22.Size = New System.Drawing.Size(65, 13)
        Me.SaimtLabel22.TabIndex = 17
        Me.SaimtLabel22.Text = "Tipo Cambio :"
        '
        'SaimtLabel21
        '
        Me.SaimtLabel21.Location = New System.Drawing.Point(21, 77)
        Me.SaimtLabel21.Name = "SaimtLabel21"
        Me.SaimtLabel21.Size = New System.Drawing.Size(83, 13)
        Me.SaimtLabel21.TabIndex = 15
        Me.SaimtLabel21.Text = "Tipo de Moneda :"
        '
        'SaimtLabel20
        '
        Me.SaimtLabel20.Location = New System.Drawing.Point(424, 32)
        Me.SaimtLabel20.Name = "SaimtLabel20"
        Me.SaimtLabel20.Size = New System.Drawing.Size(40, 13)
        Me.SaimtLabel20.TabIndex = 5
        Me.SaimtLabel20.Text = "Estado :"
        '
        'txtDirInmueble
        '
        Me.txtDirInmueble.EditValue = ""
        Me.txtDirInmueble.Location = New System.Drawing.Point(299, 50)
        Me.txtDirInmueble.Name = "txtDirInmueble"
        Me.txtDirInmueble.Size = New System.Drawing.Size(261, 20)
        Me.txtDirInmueble.TabIndex = 12
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(8, 54)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(97, 13)
        Me.SaimtLabel6.TabIndex = 9
        Me.SaimtLabel6.Text = " Cod Inm - Nombre :"
        '
        'txtFecTermino
        '
        Me.txtFecTermino.EditValue = ""
        Me.txtFecTermino.Location = New System.Drawing.Point(656, 73)
        Me.txtFecTermino.Name = "txtFecTermino"
        Me.txtFecTermino.Size = New System.Drawing.Size(94, 20)
        Me.txtFecTermino.TabIndex = 22
        '
        'txtFecInicio
        '
        Me.txtFecInicio.EditValue = ""
        Me.txtFecInicio.Location = New System.Drawing.Point(463, 73)
        Me.txtFecInicio.Name = "txtFecInicio"
        Me.txtFecInicio.Size = New System.Drawing.Size(97, 20)
        Me.txtFecInicio.TabIndex = 20
        '
        'txtTipoMoneda
        '
        Me.txtTipoMoneda.EditValue = ""
        Me.txtTipoMoneda.Location = New System.Drawing.Point(110, 73)
        Me.txtTipoMoneda.Name = "txtTipoMoneda"
        Me.txtTipoMoneda.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoMoneda.TabIndex = 16
        '
        'txtEstado
        '
        Me.txtEstado.EditValue = ""
        Me.txtEstado.Location = New System.Drawing.Point(466, 28)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(94, 20)
        Me.txtEstado.TabIndex = 6
        '
        'txtCodInmueble
        '
        Me.txtCodInmueble.EditValue = ""
        Me.txtCodInmueble.Location = New System.Drawing.Point(110, 50)
        Me.txtCodInmueble.Name = "txtCodInmueble"
        Me.txtCodInmueble.Size = New System.Drawing.Size(100, 20)
        Me.txtCodInmueble.TabIndex = 10
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(246, 54)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel2.TabIndex = 11
        Me.SaimtLabel2.Text = "Dirección :"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(563, 32)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(91, 13)
        Me.SaimtLabel5.TabIndex = 7
        Me.SaimtLabel5.Text = "Nombres o Razon :"
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(755, 77)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(46, 13)
        Me.SaimtLabel3.TabIndex = 23
        Me.SaimtLabel3.Text = "Nro. Doc."
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(227, 32)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel8.TabIndex = 3
        Me.SaimtLabel8.Text = "Tipo Persona :"
        '
        'txtNombreRazon
        '
        Me.txtNombreRazon.EditValue = ""
        Me.txtNombreRazon.Location = New System.Drawing.Point(656, 28)
        Me.txtNombreRazon.Name = "txtNombreRazon"
        Me.txtNombreRazon.Size = New System.Drawing.Size(238, 20)
        Me.txtNombreRazon.TabIndex = 8
        '
        'txtTipoPersona
        '
        Me.txtTipoPersona.EditValue = ""
        Me.txtTipoPersona.Location = New System.Drawing.Point(299, 28)
        Me.txtTipoPersona.Name = "txtTipoPersona"
        Me.txtTipoPersona.Size = New System.Drawing.Size(94, 20)
        Me.txtTipoPersona.TabIndex = 4
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.EditValue = ""
        Me.txtNroDocumento.Location = New System.Drawing.Point(802, 73)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(92, 20)
        Me.txtNroDocumento.TabIndex = 24
        '
        'SaimtGroupBox5
        '
        Me.SaimtGroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox5.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SaimtGroupBox5.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SaimtGroupBox5.Appearance.Options.UseBackColor = True
        Me.SaimtGroupBox5.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.SaimtGroupBox5.AppearanceCaption.Options.UseForeColor = True
        Me.SaimtGroupBox5.Controls.Add(Me.dgvDetalleProgramacionPagos)
        Me.SaimtGroupBox5.Controls.Add(Me.btnQuitarDetalle)
        Me.SaimtGroupBox5.Controls.Add(Me.cboConcepto)
        Me.SaimtGroupBox5.Controls.Add(Me.btnAgregarDetallle)
        Me.SaimtGroupBox5.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox5.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox5.Controls.Add(Me.txtMonto)
        Me.SaimtGroupBox5.Location = New System.Drawing.Point(3, 411)
        Me.SaimtGroupBox5.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox5.Name = "SaimtGroupBox5"
        Me.SaimtGroupBox5.Size = New System.Drawing.Size(911, 209)
        Me.SaimtGroupBox5.TabIndex = 2
        Me.SaimtGroupBox5.Text = "Detalle de Cuotas"
        '
        'dgvDetalleProgramacionPagos
        '
        Me.dgvDetalleProgramacionPagos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDetalleProgramacionPagos.Location = New System.Drawing.Point(2, 50)
        Me.dgvDetalleProgramacionPagos.MainView = Me.gvDetalleProgramacionPagos
        Me.dgvDetalleProgramacionPagos.MenuManager = Me.RibbonControl
        Me.dgvDetalleProgramacionPagos.Name = "dgvDetalleProgramacionPagos"
        Me.dgvDetalleProgramacionPagos.Size = New System.Drawing.Size(907, 157)
        Me.dgvDetalleProgramacionPagos.TabIndex = 6
        Me.dgvDetalleProgramacionPagos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalleProgramacionPagos})
        '
        'gvDetalleProgramacionPagos
        '
        Me.gvDetalleProgramacionPagos.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvDetalleProgramacionPagos.Appearance.FooterPanel.Options.UseFont = True
        Me.gvDetalleProgramacionPagos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProPaIdDetalle, Me.colConIdDetalle, Me.colConNombreDetalle, Me.colProPaDetPConceptoDetalle, Me.colProPaDetMontoDetalle, Me.colTemporalDetalle})
        Me.gvDetalleProgramacionPagos.GridControl = Me.dgvDetalleProgramacionPagos
        Me.gvDetalleProgramacionPagos.Name = "gvDetalleProgramacionPagos"
        Me.gvDetalleProgramacionPagos.OptionsBehavior.ReadOnly = True
        Me.gvDetalleProgramacionPagos.OptionsView.ColumnAutoWidth = False
        Me.gvDetalleProgramacionPagos.OptionsView.ShowFooter = True
        Me.gvDetalleProgramacionPagos.OptionsView.ShowGroupPanel = False
        '
        'colProPaIdDetalle
        '
        Me.colProPaIdDetalle.Caption = "Cod. Prog."
        Me.colProPaIdDetalle.FieldName = "proPaId"
        Me.colProPaIdDetalle.Name = "colProPaIdDetalle"
        Me.colProPaIdDetalle.Visible = True
        Me.colProPaIdDetalle.VisibleIndex = 0
        '
        'colConIdDetalle
        '
        Me.colConIdDetalle.Caption = "Cod. Concepto"
        Me.colConIdDetalle.FieldName = "conId"
        Me.colConIdDetalle.Name = "colConIdDetalle"
        Me.colConIdDetalle.Visible = True
        Me.colConIdDetalle.VisibleIndex = 1
        '
        'colConNombreDetalle
        '
        Me.colConNombreDetalle.Caption = "Concepto"
        Me.colConNombreDetalle.FieldName = "conNombre"
        Me.colConNombreDetalle.Name = "colConNombreDetalle"
        Me.colConNombreDetalle.Visible = True
        Me.colConNombreDetalle.VisibleIndex = 2
        '
        'colProPaDetPConceptoDetalle
        '
        Me.colProPaDetPConceptoDetalle.Caption = "P. Concepto"
        Me.colProPaDetPConceptoDetalle.DisplayFormat.FormatString = "n2"
        Me.colProPaDetPConceptoDetalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProPaDetPConceptoDetalle.FieldName = "proPaDetPConcepto"
        Me.colProPaDetPConceptoDetalle.Name = "colProPaDetPConceptoDetalle"
        Me.colProPaDetPConceptoDetalle.Visible = True
        Me.colProPaDetPConceptoDetalle.VisibleIndex = 3
        '
        'colProPaDetMontoDetalle
        '
        Me.colProPaDetMontoDetalle.Caption = "Monto"
        Me.colProPaDetMontoDetalle.DisplayFormat.FormatString = "n2"
        Me.colProPaDetMontoDetalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProPaDetMontoDetalle.FieldName = "proPaDetMonto"
        Me.colProPaDetMontoDetalle.Name = "colProPaDetMontoDetalle"
        Me.colProPaDetMontoDetalle.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "proPaDetMonto", "Total : {0:###,##0.00}")})
        Me.colProPaDetMontoDetalle.Visible = True
        Me.colProPaDetMontoDetalle.VisibleIndex = 4
        Me.colProPaDetMontoDetalle.Width = 93
        '
        'colTemporalDetalle
        '
        Me.colTemporalDetalle.Caption = "Temporal"
        Me.colTemporalDetalle.FieldName = "temporal"
        Me.colTemporalDetalle.Name = "colTemporalDetalle"
        '
        'btnQuitarDetalle
        '
        Me.btnQuitarDetalle.Image = CType(resources.GetObject("btnQuitarDetalle.Image"), System.Drawing.Image)
        Me.btnQuitarDetalle.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuitarDetalle.Location = New System.Drawing.Point(580, 23)
        Me.btnQuitarDetalle.Name = "btnQuitarDetalle"
        Me.btnQuitarDetalle.Size = New System.Drawing.Size(21, 21)
        Me.btnQuitarDetalle.TabIndex = 5
        '
        'cboConcepto
        '
        Me.cboConcepto.Location = New System.Drawing.Point(67, 23)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConcepto.Properties.NullText = ""
        Me.cboConcepto.Size = New System.Drawing.Size(377, 20)
        Me.cboConcepto.TabIndex = 1
        '
        'btnAgregarDetallle
        '
        Me.btnAgregarDetallle.Image = CType(resources.GetObject("btnAgregarDetallle.Image"), System.Drawing.Image)
        Me.btnAgregarDetallle.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregarDetallle.Location = New System.Drawing.Point(558, 23)
        Me.btnAgregarDetallle.Name = "btnAgregarDetallle"
        Me.btnAgregarDetallle.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarDetallle.TabIndex = 4
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(8, 27)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(53, 13)
        Me.SaimtLabel4.TabIndex = 0
        Me.SaimtLabel4.Text = "Concepto :"
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(451, 28)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(37, 13)
        Me.SaimtLabel7.TabIndex = 2
        Me.SaimtLabel7.Text = "Monto :"
        '
        'txtMonto
        '
        Me.txtMonto.EditValue = "0.00"
        Me.txtMonto.Location = New System.Drawing.Point(490, 24)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.Mask.EditMask = "n2"
        Me.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Size = New System.Drawing.Size(61, 20)
        Me.txtMonto.TabIndex = 3
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SaimtGroupBox1.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SaimtGroupBox1.Appearance.Options.UseBackColor = True
        Me.SaimtGroupBox1.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseForeColor = True
        Me.SaimtGroupBox1.Controls.Add(Me.dgvProgramacionPagos)
        Me.SaimtGroupBox1.Controls.Add(Me.btnComprobantePago)
        Me.SaimtGroupBox1.Controls.Add(Me.btnAplicaDetraccion)
        Me.SaimtGroupBox1.Controls.Add(Me.btnComprobante)
        Me.SaimtGroupBox1.Controls.Add(Me.spnNroCuotas)
        Me.SaimtGroupBox1.Controls.Add(Me.btnQuitarCuota)
        Me.SaimtGroupBox1.Controls.Add(Me.btnAgregarCuota)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel14)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(3, 135)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(911, 271)
        Me.SaimtGroupBox1.TabIndex = 1
        Me.SaimtGroupBox1.Text = "Cuotas"
        '
        'dgvProgramacionPagos
        '
        Me.dgvProgramacionPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProgramacionPagos.Location = New System.Drawing.Point(3, 49)
        Me.dgvProgramacionPagos.MainView = Me.gvProgramacionPagos
        Me.dgvProgramacionPagos.MenuManager = Me.RibbonControl
        Me.dgvProgramacionPagos.Name = "dgvProgramacionPagos"
        Me.dgvProgramacionPagos.Size = New System.Drawing.Size(904, 219)
        Me.dgvProgramacionPagos.TabIndex = 7
        Me.dgvProgramacionPagos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionPagos})
        '
        'gvProgramacionPagos
        '
        Me.gvProgramacionPagos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPropaNroCuota, Me.colProPaId, Me.colTgTipoComprobante, Me.colProPaFechaPag, Me.colMes, Me.colProPaFechaVen, Me.colTgEstadoId, Me.colTgEstado, Me.colProPaDetIgv, Me.colProPaPMora, Me.colProPaComision, Me.colProPaAplicaD, Me.colTgRecaudadoraId, Me.colTgRecaudadora, Me.colTgMoneda, Me.colTemporal, Me.GridColumn1})
        Me.gvProgramacionPagos.GridControl = Me.dgvProgramacionPagos
        Me.gvProgramacionPagos.Name = "gvProgramacionPagos"
        Me.gvProgramacionPagos.OptionsView.ColumnAutoWidth = False
        Me.gvProgramacionPagos.OptionsView.ShowGroupPanel = False
        '
        'colPropaNroCuota
        '
        Me.colPropaNroCuota.Caption = "Nro Cuota"
        Me.colPropaNroCuota.FieldName = "propaNroCuota"
        Me.colPropaNroCuota.Name = "colPropaNroCuota"
        Me.colPropaNroCuota.OptionsColumn.ReadOnly = True
        Me.colPropaNroCuota.Visible = True
        Me.colPropaNroCuota.VisibleIndex = 0
        '
        'colProPaId
        '
        Me.colProPaId.Caption = "Cod. Prog"
        Me.colProPaId.FieldName = "proPaId"
        Me.colProPaId.Name = "colProPaId"
        Me.colProPaId.OptionsColumn.ReadOnly = True
        Me.colProPaId.Visible = True
        Me.colProPaId.VisibleIndex = 1
        '
        'colTgTipoComprobante
        '
        Me.colTgTipoComprobante.Caption = "Comprobante"
        Me.colTgTipoComprobante.FieldName = "tgTipoComprobante"
        Me.colTgTipoComprobante.Name = "colTgTipoComprobante"
        Me.colTgTipoComprobante.Visible = True
        Me.colTgTipoComprobante.VisibleIndex = 2
        '
        'colProPaFechaPag
        '
        Me.colProPaFechaPag.Caption = "Fecha Pago"
        Me.colProPaFechaPag.FieldName = "proPaFechaPag"
        Me.colProPaFechaPag.Name = "colProPaFechaPag"
        Me.colProPaFechaPag.OptionsColumn.ReadOnly = True
        Me.colProPaFechaPag.Visible = True
        Me.colProPaFechaPag.VisibleIndex = 4
        '
        'colMes
        '
        Me.colMes.Caption = "Mes"
        Me.colMes.FieldName = "Mes"
        Me.colMes.Name = "colMes"
        Me.colMes.OptionsColumn.ReadOnly = True
        Me.colMes.Visible = True
        Me.colMes.VisibleIndex = 5
        '
        'colProPaFechaVen
        '
        Me.colProPaFechaVen.Caption = "Fecha Vencimiento"
        Me.colProPaFechaVen.FieldName = "proPaFechaVen"
        Me.colProPaFechaVen.Name = "colProPaFechaVen"
        Me.colProPaFechaVen.Visible = True
        Me.colProPaFechaVen.VisibleIndex = 6
        '
        'colTgEstadoId
        '
        Me.colTgEstadoId.Caption = "EstadoId"
        Me.colTgEstadoId.FieldName = "tgEstadoId"
        Me.colTgEstadoId.Name = "colTgEstadoId"
        '
        'colTgEstado
        '
        Me.colTgEstado.Caption = "Estado"
        Me.colTgEstado.FieldName = "tgEstado"
        Me.colTgEstado.Name = "colTgEstado"
        Me.colTgEstado.OptionsColumn.ReadOnly = True
        Me.colTgEstado.Visible = True
        Me.colTgEstado.VisibleIndex = 7
        '
        'colProPaDetIgv
        '
        Me.colProPaDetIgv.Caption = "IGV"
        Me.colProPaDetIgv.FieldName = "proPaDetIgv"
        Me.colProPaDetIgv.Name = "colProPaDetIgv"
        Me.colProPaDetIgv.OptionsColumn.ReadOnly = True
        Me.colProPaDetIgv.Visible = True
        Me.colProPaDetIgv.VisibleIndex = 8
        '
        'colProPaPMora
        '
        Me.colProPaPMora.Caption = "Mora"
        Me.colProPaPMora.FieldName = "proPaPMora"
        Me.colProPaPMora.Name = "colProPaPMora"
        Me.colProPaPMora.OptionsColumn.ReadOnly = True
        Me.colProPaPMora.Visible = True
        Me.colProPaPMora.VisibleIndex = 9
        '
        'colProPaComision
        '
        Me.colProPaComision.Caption = "Comisión"
        Me.colProPaComision.FieldName = "proPaComision"
        Me.colProPaComision.Name = "colProPaComision"
        Me.colProPaComision.OptionsColumn.ReadOnly = True
        Me.colProPaComision.Visible = True
        Me.colProPaComision.VisibleIndex = 10
        '
        'colProPaAplicaD
        '
        Me.colProPaAplicaD.Caption = "Aplica Det."
        Me.colProPaAplicaD.FieldName = "ProPaAplicaD"
        Me.colProPaAplicaD.Name = "colProPaAplicaD"
        Me.colProPaAplicaD.Visible = True
        Me.colProPaAplicaD.VisibleIndex = 11
        '
        'colTgRecaudadoraId
        '
        Me.colTgRecaudadoraId.Caption = "RecaudadoraId"
        Me.colTgRecaudadoraId.FieldName = "tgRecaudadoraId"
        Me.colTgRecaudadoraId.Name = "colTgRecaudadoraId"
        '
        'colTgRecaudadora
        '
        Me.colTgRecaudadora.Caption = "Recaudadora"
        Me.colTgRecaudadora.FieldName = "tgRecaudadora"
        Me.colTgRecaudadora.Name = "colTgRecaudadora"
        Me.colTgRecaudadora.OptionsColumn.ReadOnly = True
        Me.colTgRecaudadora.Visible = True
        Me.colTgRecaudadora.VisibleIndex = 12
        '
        'colTgMoneda
        '
        Me.colTgMoneda.Caption = "Moneda"
        Me.colTgMoneda.FieldName = "tgMoneda"
        Me.colTgMoneda.Name = "colTgMoneda"
        Me.colTgMoneda.Visible = True
        Me.colTgMoneda.VisibleIndex = 13
        '
        'colTemporal
        '
        Me.colTemporal.Caption = "Temporal"
        Me.colTemporal.FieldName = "temporal"
        Me.colTemporal.Name = "colTemporal"
        Me.colTemporal.OptionsColumn.ReadOnly = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "N° Comp."
        Me.GridColumn1.FieldName = "nroComprobante"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        '
        'btnComprobantePago
        '
        Me.btnComprobantePago.Image = CType(resources.GetObject("btnComprobantePago.Image"), System.Drawing.Image)
        Me.btnComprobantePago.Location = New System.Drawing.Point(813, 23)
        Me.btnComprobantePago.Name = "btnComprobantePago"
        Me.btnComprobantePago.Size = New System.Drawing.Size(90, 23)
        Me.btnComprobantePago.TabIndex = 6
        Me.btnComprobantePago.Text = "Comp. Pago"
        '
        'btnAplicaDetraccion
        '
        Me.btnAplicaDetraccion.Location = New System.Drawing.Point(739, 23)
        Me.btnAplicaDetraccion.Name = "btnAplicaDetraccion"
        Me.btnAplicaDetraccion.Size = New System.Drawing.Size(68, 23)
        Me.btnAplicaDetraccion.TabIndex = 5
        Me.btnAplicaDetraccion.Text = "Aplica Det."
        '
        'btnComprobante
        '
        Me.btnComprobante.Location = New System.Drawing.Point(658, 23)
        Me.btnComprobante.Name = "btnComprobante"
        Me.btnComprobante.Size = New System.Drawing.Size(75, 23)
        Me.btnComprobante.TabIndex = 4
        Me.btnComprobante.Text = "Comprobante"
        '
        'spnNroCuotas
        '
        Me.spnNroCuotas.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnNroCuotas.Location = New System.Drawing.Point(96, 24)
        Me.spnNroCuotas.MenuManager = Me.RibbonControl
        Me.spnNroCuotas.Name = "spnNroCuotas"
        Me.spnNroCuotas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spnNroCuotas.Properties.MaxValue = New Decimal(New Integer() {12, 0, 0, 0})
        Me.spnNroCuotas.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnNroCuotas.Size = New System.Drawing.Size(42, 20)
        Me.spnNroCuotas.TabIndex = 1
        '
        'btnQuitarCuota
        '
        Me.btnQuitarCuota.Image = CType(resources.GetObject("btnQuitarCuota.Image"), System.Drawing.Image)
        Me.btnQuitarCuota.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuitarCuota.Location = New System.Drawing.Point(165, 24)
        Me.btnQuitarCuota.Name = "btnQuitarCuota"
        Me.btnQuitarCuota.Size = New System.Drawing.Size(21, 21)
        Me.btnQuitarCuota.TabIndex = 3
        '
        'btnAgregarCuota
        '
        Me.btnAgregarCuota.Image = CType(resources.GetObject("btnAgregarCuota.Image"), System.Drawing.Image)
        Me.btnAgregarCuota.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregarCuota.Location = New System.Drawing.Point(142, 24)
        Me.btnAgregarCuota.Name = "btnAgregarCuota"
        Me.btnAgregarCuota.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarCuota.TabIndex = 2
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(8, 28)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(83, 13)
        Me.SaimtLabel14.TabIndex = 0
        Me.SaimtLabel14.Text = "Agregar Cuotas :"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.LookAndFeel.SkinName = "Seven"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboTipoUso)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboBuscarContratoPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarContratoPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboBuscarPersonaPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarPersonaPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.grbPersona)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.grbContratos)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.grbDatosContrato)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEditar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox5)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnLimpiar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnCancelar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnImprimir)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnNuevo)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(1306, 692)
        Me.SaimtSplitContainerControl1.SplitterPosition = 380
        Me.SaimtSplitContainerControl1.TabIndex = 0
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'cboTipoUso
        '
        Me.cboTipoUso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoUso.Location = New System.Drawing.Point(6, 403)
        Me.cboTipoUso.MenuManager = Me.RibbonControl
        Me.cboTipoUso.Name = "cboTipoUso"
        Me.cboTipoUso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoUso.Properties.NullText = ""
        Me.cboTipoUso.Size = New System.Drawing.Size(372, 20)
        Me.cboTipoUso.TabIndex = 5
        Me.cboTipoUso.Tag = "0"
        '
        'cboBuscarContratoPor
        '
        Me.cboBuscarContratoPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBuscarContratoPor.EditValue = "Busqueda por Cod. Persona"
        Me.cboBuscarContratoPor.Location = New System.Drawing.Point(6, 382)
        Me.cboBuscarContratoPor.MenuManager = Me.RibbonControl
        Me.cboBuscarContratoPor.Name = "cboBuscarContratoPor"
        Me.cboBuscarContratoPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarContratoPor.Properties.Items.AddRange(New Object() {"Busqueda por Cod. Persona", "Busqueda por N° Contrato", "Busqueda por Dirección Inmueble", "Busqueda por Tipo de Uso", "Busqueda por Registro Mesa Partes", "Busqueda por Doc. Referencia"})
        Me.cboBuscarContratoPor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBuscarContratoPor.Size = New System.Drawing.Size(372, 20)
        Me.cboBuscarContratoPor.TabIndex = 4
        Me.cboBuscarContratoPor.Tag = ""
        '
        'txtBuscarContratoPor
        '
        Me.txtBuscarContratoPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarContratoPor.Location = New System.Drawing.Point(6, 425)
        Me.txtBuscarContratoPor.MenuManager = Me.RibbonControl
        Me.txtBuscarContratoPor.Name = "txtBuscarContratoPor"
        Me.txtBuscarContratoPor.Size = New System.Drawing.Size(372, 20)
        Me.txtBuscarContratoPor.TabIndex = 6
        '
        'cboBuscarPersonaPor
        '
        Me.cboBuscarPersonaPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBuscarPersonaPor.EditValue = "Busqueda por Apellidos y Nombres"
        Me.cboBuscarPersonaPor.Location = New System.Drawing.Point(4, 19)
        Me.cboBuscarPersonaPor.MenuManager = Me.RibbonControl
        Me.cboBuscarPersonaPor.Name = "cboBuscarPersonaPor"
        Me.cboBuscarPersonaPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarPersonaPor.Properties.Items.AddRange(New Object() {"Busqueda por Apellidos y Nombres", "Busqueda por RUC", "Busqueda por DNI"})
        Me.cboBuscarPersonaPor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBuscarPersonaPor.Size = New System.Drawing.Size(374, 20)
        Me.cboBuscarPersonaPor.TabIndex = 1
        Me.cboBuscarPersonaPor.Tag = "0"
        '
        'frmProgramacionPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonImprimir = Me.btnImprimir
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(1306, 719)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.dgvListado = Me.dgvListadoContratos
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmProgramacionPagos"
        Me.Tag = "btiProgPag"
        Me.Text = "PROGRAMACION DE PAGOS"
        Me.txtBuscarSaimt = Me.txtBuscarContratoPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContratos.ResumeLayout(False)
        CType(Me.dgvListadoContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbPersona.ResumeLayout(False)
        CType(Me.dgvListadoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosContrato.ResumeLayout(False)
        Me.grbDatosContrato.PerformLayout()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGarantia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDerLlave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMerConductiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDirInmueble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecTermino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodInmueble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreRazon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox5.ResumeLayout(False)
        Me.SaimtGroupBox5.PerformLayout()
        CType(Me.dgvDetalleProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.dgvProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnNroCuotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.cboTipoUso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents grbContratos As SaimtControles.SaimtGroupBox
    Friend WithEvents grbPersona As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtBuscarPersonaPor As SaimtControles.SaimtTextBox
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents grbDatosContrato As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents txtNombreRazon As SaimtControles.SaimtTextBox
    Friend WithEvents txtTipoPersona As SaimtControles.SaimtTextBox
    Friend WithEvents txtNroDocumento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents txtCodInmueble As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtTipoCambio As SaimtControles.SaimtTextBox
    Friend WithEvents txtGarantia As SaimtControles.SaimtTextBox
    Friend WithEvents txtDerLlave As SaimtControles.SaimtTextBox
    Friend WithEvents txtMerConductiva As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel28 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel27 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel26 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel25 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel24 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel23 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel22 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel21 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel20 As SaimtControles.SaimtLabel
    Friend WithEvents txtMonto As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents dgvDetalleProgramacionPagos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvDetalleProgramacionPagos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAgregarDetallle As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox5 As SaimtControles.SaimtGroupBox
    Friend WithEvents cboConcepto As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtNroContrato As SaimtControles.SaimtTextBox
    Friend WithEvents btnQuitarDetalle As SaimtControles.SaimtButton
    Friend WithEvents txtUso As SaimtControles.SaimtTextBox
    Friend WithEvents txtFecTermino As SaimtControles.SaimtTextBox
    Friend WithEvents txtFecInicio As SaimtControles.SaimtTextBox
    Friend WithEvents txtTipoMoneda As SaimtControles.SaimtTextBox
    Friend WithEvents txtEstado As SaimtControles.SaimtTextBox
    Friend WithEvents txtDirInmueble As SaimtControles.SaimtTextBox
    Friend WithEvents dgvProgramacionPagos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionPagos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents spnNroCuotas As SaimtControles.SaimtSpinner
    Friend WithEvents btnQuitarCuota As SaimtControles.SaimtButton
    Friend WithEvents btnAgregarCuota As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents colPropaNroCuota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgTipoComprobante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaFechaPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaFechaVen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaDetIgv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaPMora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaAplicaD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgRecaudadora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTemporal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBuscarContrato As SaimtControles.SaimtButton
    Friend WithEvents colTgEstadoId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgRecaudadoraId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaIdDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaDetMontoDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaDetPConceptoDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConIdDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConNombreDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTemporalDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnComprobante As SaimtControles.SaimtButton
    Friend WithEvents btnAplicaDetraccion As SaimtControles.SaimtButton
    Friend WithEvents colProPaComision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnComprobantePago As SaimtControles.SaimtButton
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTipoDocumento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents cboBuscarPersonaPor As SaimtControles.SaimtComboBox
    Friend WithEvents dgvListadoContratos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoContratos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvListadoPersona As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoPersona As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTipoUso As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboBuscarContratoPor As SaimtControles.SaimtComboBox
    Friend WithEvents txtBuscarContratoPor As SaimtControles.SaimtTextBox
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class