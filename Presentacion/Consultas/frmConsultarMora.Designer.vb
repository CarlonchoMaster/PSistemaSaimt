<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarMora
    Inherits Presentacion.frmConsultas

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarMora))
        Me.grbDatosPersona = New SaimtControles.SaimtGroupBox()
        Me.txtNroDocumento = New SaimtControles.SaimtTextBox()
        Me.txtTipoDocumento = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtPersona = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtCodigoPersona = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.dgvContratos = New SaimtControles.SaimtDataGrid()
        Me.gvContrato = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colConInmId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInmId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConInmFecIni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConInmFecFin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConInmDiaMaxVen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInmDireccionCompleta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgUsoContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgEstadoContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgMonedaContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgModalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitterItem5 = New DevExpress.XtraLayout.SplitterItem()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.btnCalcularMora = New SaimtControles.SaimtButton()
        Me.dtpFechaPago = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.dgvProgramacionPagos = New SaimtControles.SaimtDataGrid()
        Me.gvProgramacionPagos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProPaNroCuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgTipoComprobante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaFechaPag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaFechaVen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaDetIgv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaPMora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaAplicaD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgRecaudadora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaComision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtGroupBox4 = New SaimtControles.SaimtGroupBox()
        Me.SaimtGroupBox5 = New SaimtControles.SaimtGroupBox()
        Me.dgvProgramacionPagosDetalle = New SaimtControles.SaimtDataGrid()
        Me.gvProgramacionPagosDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProPaIdDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaDetPConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaDetMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.txtCuotasNoPagadas = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.txtCuotasPagadas = New SaimtControles.SaimtTextBox()
        Me.txtTotalPagar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.txtPorPagar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.txtTotalPagado = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.txtTotalMora = New SaimtControles.SaimtTextBox()
        Me.txtTotalMoraRecalculo = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.txtCuotasParciales = New SaimtControles.SaimtTextBox()
        Me.colTgEstadoId = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosPersona.SuspendLayout()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.dgvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.dtpFechaPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox4.SuspendLayout()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox5.SuspendLayout()
        CType(Me.dgvProgramacionPagosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionPagosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuotasNoPagadas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuotasPagadas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPagado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalMora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalMoraRecalculo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuotasParciales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 695)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(868, 27)
        '
        'grbDatosPersona
        '
        Me.grbDatosPersona.Controls.Add(Me.txtNroDocumento)
        Me.grbDatosPersona.Controls.Add(Me.txtTipoDocumento)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel4)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel3)
        Me.grbDatosPersona.Controls.Add(Me.txtPersona)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel2)
        Me.grbDatosPersona.Controls.Add(Me.txtCodigoPersona)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel1)
        Me.grbDatosPersona.Location = New System.Drawing.Point(6, 2)
        Me.grbDatosPersona.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbDatosPersona.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbDatosPersona.Name = "grbDatosPersona"
        Me.grbDatosPersona.Size = New System.Drawing.Size(856, 82)
        Me.grbDatosPersona.TabIndex = 2
        Me.grbDatosPersona.Text = "Datos de la Persona"
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(520, 54)
        Me.txtNroDocumento.MenuManager = Me.RibbonControl
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(174, 20)
        Me.txtNroDocumento.TabIndex = 7
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.Location = New System.Drawing.Point(520, 28)
        Me.txtTipoDocumento.MenuManager = Me.RibbonControl
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.Size = New System.Drawing.Size(174, 20)
        Me.txtTipoDocumento.TabIndex = 6
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(431, 57)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(85, 13)
        Me.SaimtLabel4.TabIndex = 5
        Me.SaimtLabel4.Text = "Nro. Documento :"
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(432, 31)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(84, 13)
        Me.SaimtLabel3.TabIndex = 4
        Me.SaimtLabel3.Text = "Tipo Documento :"
        '
        'txtPersona
        '
        Me.txtPersona.Location = New System.Drawing.Point(84, 54)
        Me.txtPersona.MenuManager = Me.RibbonControl
        Me.txtPersona.Name = "txtPersona"
        Me.txtPersona.Size = New System.Drawing.Size(339, 20)
        Me.txtPersona.TabIndex = 3
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(34, 57)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(46, 13)
        Me.SaimtLabel2.TabIndex = 2
        Me.SaimtLabel2.Text = "Persona :"
        '
        'txtCodigoPersona
        '
        Me.txtCodigoPersona.Location = New System.Drawing.Point(84, 28)
        Me.txtCodigoPersona.MenuManager = Me.RibbonControl
        Me.txtCodigoPersona.Name = "txtCodigoPersona"
        Me.txtCodigoPersona.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoPersona.TabIndex = 1
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(8, 31)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(72, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Cod. Persona :"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.dgvContratos)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(6, 89)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(856, 91)
        Me.SaimtGroupBox2.TabIndex = 3
        Me.SaimtGroupBox2.Text = "Datos del Contrato"
        '
        'dgvContratos
        '
        Me.dgvContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvContratos.Location = New System.Drawing.Point(2, 22)
        Me.dgvContratos.MainView = Me.gvContrato
        Me.dgvContratos.MenuManager = Me.RibbonControl
        Me.dgvContratos.Name = "dgvContratos"
        Me.dgvContratos.Size = New System.Drawing.Size(852, 67)
        Me.dgvContratos.TabIndex = 1
        Me.dgvContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvContrato})
        '
        'gvContrato
        '
        Me.gvContrato.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvContrato.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvContrato.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvContrato.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colConInmId, Me.colInmId, Me.colConInmFecIni, Me.colConInmFecFin, Me.colConInmDiaMaxVen, Me.colInmDireccionCompleta, Me.colTgUsoContrato, Me.colTgEstadoContrato, Me.colTgMonedaContrato, Me.colTgModalidad})
        Me.gvContrato.GridControl = Me.dgvContratos
        Me.gvContrato.Name = "gvContrato"
        Me.gvContrato.OptionsBehavior.ReadOnly = True
        Me.gvContrato.OptionsView.ColumnAutoWidth = False
        Me.gvContrato.OptionsView.ShowGroupPanel = False
        '
        'colConInmId
        '
        Me.colConInmId.Caption = "Cod. Contrato"
        Me.colConInmId.FieldName = "conInmId"
        Me.colConInmId.Name = "colConInmId"
        Me.colConInmId.Visible = True
        Me.colConInmId.VisibleIndex = 0
        '
        'colInmId
        '
        Me.colInmId.Caption = "Cod. Inmueble"
        Me.colInmId.FieldName = "inmId"
        Me.colInmId.Name = "colInmId"
        Me.colInmId.Visible = True
        Me.colInmId.VisibleIndex = 1
        '
        'colConInmFecIni
        '
        Me.colConInmFecIni.Caption = "Fec. Inicio"
        Me.colConInmFecIni.FieldName = "conInmFecIni"
        Me.colConInmFecIni.Name = "colConInmFecIni"
        Me.colConInmFecIni.Visible = True
        Me.colConInmFecIni.VisibleIndex = 2
        '
        'colConInmFecFin
        '
        Me.colConInmFecFin.Caption = "Fec. Fin"
        Me.colConInmFecFin.FieldName = "conInmFecFin"
        Me.colConInmFecFin.Name = "colConInmFecFin"
        Me.colConInmFecFin.Visible = True
        Me.colConInmFecFin.VisibleIndex = 4
        '
        'colConInmDiaMaxVen
        '
        Me.colConInmDiaMaxVen.Caption = "Día Venc."
        Me.colConInmDiaMaxVen.FieldName = "conInmDiaMaxVen"
        Me.colConInmDiaMaxVen.Name = "colConInmDiaMaxVen"
        Me.colConInmDiaMaxVen.Visible = True
        Me.colConInmDiaMaxVen.VisibleIndex = 6
        '
        'colInmDireccionCompleta
        '
        Me.colInmDireccionCompleta.Caption = "Dirección"
        Me.colInmDireccionCompleta.FieldName = "inmDireccionCompleta"
        Me.colInmDireccionCompleta.Name = "colInmDireccionCompleta"
        Me.colInmDireccionCompleta.Visible = True
        Me.colInmDireccionCompleta.VisibleIndex = 3
        '
        'colTgUsoContrato
        '
        Me.colTgUsoContrato.Caption = "Uso"
        Me.colTgUsoContrato.FieldName = "tgUso"
        Me.colTgUsoContrato.Name = "colTgUsoContrato"
        Me.colTgUsoContrato.Visible = True
        Me.colTgUsoContrato.VisibleIndex = 7
        '
        'colTgEstadoContrato
        '
        Me.colTgEstadoContrato.Caption = "Estado"
        Me.colTgEstadoContrato.FieldName = "tgEstado"
        Me.colTgEstadoContrato.Name = "colTgEstadoContrato"
        Me.colTgEstadoContrato.Visible = True
        Me.colTgEstadoContrato.VisibleIndex = 5
        '
        'colTgMonedaContrato
        '
        Me.colTgMonedaContrato.Caption = "Moneda"
        Me.colTgMonedaContrato.FieldName = "tgMoneda"
        Me.colTgMonedaContrato.Name = "colTgMonedaContrato"
        Me.colTgMonedaContrato.Visible = True
        Me.colTgMonedaContrato.VisibleIndex = 8
        '
        'colTgModalidad
        '
        Me.colTgModalidad.Caption = "Modalidad"
        Me.colTgModalidad.FieldName = "tgModalidad"
        Me.colTgModalidad.Name = "colTgModalidad"
        Me.colTgModalidad.Visible = True
        Me.colTgModalidad.VisibleIndex = 9
        '
        'SplitterItem5
        '
        Me.SplitterItem5.AllowHotTrack = True
        Me.SplitterItem5.CustomizationFormText = "SplitterItem5"
        Me.SplitterItem5.Location = New System.Drawing.Point(355, 46)
        Me.SplitterItem5.Name = "SplitterItem5"
        Me.SplitterItem5.Size = New System.Drawing.Size(477, 110)
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Controls.Add(Me.btnImprimir)
        Me.SaimtGroupBox3.Controls.Add(Me.btnCalcularMora)
        Me.SaimtGroupBox3.Controls.Add(Me.dtpFechaPago)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(6, 184)
        Me.SaimtGroupBox3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(856, 68)
        Me.SaimtGroupBox3.TabIndex = 4
        Me.SaimtGroupBox3.Text = "Fecha para Recalculo"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(421, 27)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(84, 36)
        Me.btnImprimir.TabIndex = 95
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCalcularMora
        '
        Me.btnCalcularMora.Image = CType(resources.GetObject("btnCalcularMora.Image"), System.Drawing.Image)
        Me.btnCalcularMora.Location = New System.Drawing.Point(305, 27)
        Me.btnCalcularMora.Name = "btnCalcularMora"
        Me.btnCalcularMora.Size = New System.Drawing.Size(110, 36)
        Me.btnCalcularMora.TabIndex = 2
        Me.btnCalcularMora.Text = "Cacular Mora"
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.EditValue = Nothing
        Me.dtpFechaPago.Location = New System.Drawing.Point(98, 34)
        Me.dtpFechaPago.MenuManager = Me.RibbonControl
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaPago.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaPago.Size = New System.Drawing.Size(191, 20)
        Me.dtpFechaPago.TabIndex = 1
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(12, 37)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(81, 13)
        Me.SaimtLabel5.TabIndex = 0
        Me.SaimtLabel5.Text = "Fecha Deposito :"
        '
        'dgvProgramacionPagos
        '
        Me.dgvProgramacionPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProgramacionPagos.Location = New System.Drawing.Point(2, 22)
        Me.dgvProgramacionPagos.MainView = Me.gvProgramacionPagos
        Me.dgvProgramacionPagos.MenuManager = Me.RibbonControl
        Me.dgvProgramacionPagos.Name = "dgvProgramacionPagos"
        Me.dgvProgramacionPagos.Size = New System.Drawing.Size(852, 187)
        Me.dgvProgramacionPagos.TabIndex = 5
        Me.dgvProgramacionPagos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionPagos})
        '
        'gvProgramacionPagos
        '
        Me.gvProgramacionPagos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvProgramacionPagos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvProgramacionPagos.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvProgramacionPagos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProPaNroCuota, Me.colProPaId, Me.colTgTipoComprobante, Me.colProPaFechaPag, Me.colMes, Me.colProPaFechaVen, Me.colTgEstado, Me.colProPaDetIgv, Me.colProPaPMora, Me.colProPaAplicaD, Me.colTgRecaudadora, Me.colTgMoneda, Me.colProPaComision, Me.colTgEstadoId})
        Me.gvProgramacionPagos.GridControl = Me.dgvProgramacionPagos
        Me.gvProgramacionPagos.Name = "gvProgramacionPagos"
        Me.gvProgramacionPagos.OptionsBehavior.ReadOnly = True
        Me.gvProgramacionPagos.OptionsView.ColumnAutoWidth = False
        Me.gvProgramacionPagos.OptionsView.ShowGroupPanel = False
        '
        'colProPaNroCuota
        '
        Me.colProPaNroCuota.Caption = "Nro Cuota"
        Me.colProPaNroCuota.FieldName = "proPaNroCuota"
        Me.colProPaNroCuota.Name = "colProPaNroCuota"
        Me.colProPaNroCuota.Visible = True
        Me.colProPaNroCuota.VisibleIndex = 0
        '
        'colProPaId
        '
        Me.colProPaId.Caption = "Cod. Prog."
        Me.colProPaId.FieldName = "proPaId"
        Me.colProPaId.Name = "colProPaId"
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
        Me.colProPaFechaPag.Visible = True
        Me.colProPaFechaPag.VisibleIndex = 3
        '
        'colMes
        '
        Me.colMes.Caption = "Mes"
        Me.colMes.FieldName = "Mes"
        Me.colMes.Name = "colMes"
        Me.colMes.Visible = True
        Me.colMes.VisibleIndex = 4
        '
        'colProPaFechaVen
        '
        Me.colProPaFechaVen.Caption = "Fecha Vencimiento"
        Me.colProPaFechaVen.FieldName = "proPaFechaVen"
        Me.colProPaFechaVen.Name = "colProPaFechaVen"
        Me.colProPaFechaVen.Visible = True
        Me.colProPaFechaVen.VisibleIndex = 5
        '
        'colTgEstado
        '
        Me.colTgEstado.Caption = "Estado"
        Me.colTgEstado.FieldName = "tgEstado"
        Me.colTgEstado.Name = "colTgEstado"
        Me.colTgEstado.Visible = True
        Me.colTgEstado.VisibleIndex = 6
        '
        'colProPaDetIgv
        '
        Me.colProPaDetIgv.Caption = "IGV"
        Me.colProPaDetIgv.FieldName = "proPaDetIgv"
        Me.colProPaDetIgv.Name = "colProPaDetIgv"
        Me.colProPaDetIgv.Visible = True
        Me.colProPaDetIgv.VisibleIndex = 7
        '
        'colProPaPMora
        '
        Me.colProPaPMora.Caption = "Mora"
        Me.colProPaPMora.FieldName = "proPaPMora"
        Me.colProPaPMora.Name = "colProPaPMora"
        Me.colProPaPMora.Visible = True
        Me.colProPaPMora.VisibleIndex = 8
        '
        'colProPaAplicaD
        '
        Me.colProPaAplicaD.Caption = "Aplica Det."
        Me.colProPaAplicaD.FieldName = "proPaAplicaD"
        Me.colProPaAplicaD.Name = "colProPaAplicaD"
        Me.colProPaAplicaD.Visible = True
        Me.colProPaAplicaD.VisibleIndex = 9
        '
        'colTgRecaudadora
        '
        Me.colTgRecaudadora.Caption = "Recaudadora"
        Me.colTgRecaudadora.FieldName = "tgRecaudadora"
        Me.colTgRecaudadora.Name = "colTgRecaudadora"
        Me.colTgRecaudadora.Visible = True
        Me.colTgRecaudadora.VisibleIndex = 10
        '
        'colTgMoneda
        '
        Me.colTgMoneda.Caption = "Moneda"
        Me.colTgMoneda.FieldName = "tgMoneda"
        Me.colTgMoneda.Name = "colTgMoneda"
        Me.colTgMoneda.Visible = True
        Me.colTgMoneda.VisibleIndex = 11
        '
        'colProPaComision
        '
        Me.colProPaComision.Caption = "Comisión"
        Me.colProPaComision.FieldName = "proPaComision"
        Me.colProPaComision.Name = "colProPaComision"
        Me.colProPaComision.Visible = True
        Me.colProPaComision.VisibleIndex = 12
        '
        'SaimtGroupBox4
        '
        Me.SaimtGroupBox4.Controls.Add(Me.dgvProgramacionPagos)
        Me.SaimtGroupBox4.Location = New System.Drawing.Point(6, 257)
        Me.SaimtGroupBox4.Name = "SaimtGroupBox4"
        Me.SaimtGroupBox4.Size = New System.Drawing.Size(856, 211)
        Me.SaimtGroupBox4.TabIndex = 6
        Me.SaimtGroupBox4.Text = "Programaciones de Pago"
        '
        'SaimtGroupBox5
        '
        Me.SaimtGroupBox5.Controls.Add(Me.dgvProgramacionPagosDetalle)
        Me.SaimtGroupBox5.Location = New System.Drawing.Point(8, 474)
        Me.SaimtGroupBox5.Name = "SaimtGroupBox5"
        Me.SaimtGroupBox5.Size = New System.Drawing.Size(852, 137)
        Me.SaimtGroupBox5.TabIndex = 7
        Me.SaimtGroupBox5.Text = "Detalle de Programaciones de Pago"
        '
        'dgvProgramacionPagosDetalle
        '
        Me.dgvProgramacionPagosDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProgramacionPagosDetalle.Location = New System.Drawing.Point(2, 22)
        Me.dgvProgramacionPagosDetalle.MainView = Me.gvProgramacionPagosDetalle
        Me.dgvProgramacionPagosDetalle.MenuManager = Me.RibbonControl
        Me.dgvProgramacionPagosDetalle.Name = "dgvProgramacionPagosDetalle"
        Me.dgvProgramacionPagosDetalle.Size = New System.Drawing.Size(848, 113)
        Me.dgvProgramacionPagosDetalle.TabIndex = 9
        Me.dgvProgramacionPagosDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionPagosDetalle})
        '
        'gvProgramacionPagosDetalle
        '
        Me.gvProgramacionPagosDetalle.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvProgramacionPagosDetalle.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvProgramacionPagosDetalle.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvProgramacionPagosDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProPaIdDetalle, Me.colConId, Me.colConNombre, Me.colProPaDetPConcepto, Me.colProPaDetMonto})
        Me.gvProgramacionPagosDetalle.GridControl = Me.dgvProgramacionPagosDetalle
        Me.gvProgramacionPagosDetalle.Name = "gvProgramacionPagosDetalle"
        Me.gvProgramacionPagosDetalle.OptionsBehavior.ReadOnly = True
        Me.gvProgramacionPagosDetalle.OptionsCustomization.AllowFilter = False
        Me.gvProgramacionPagosDetalle.OptionsCustomization.AllowSort = False
        Me.gvProgramacionPagosDetalle.OptionsView.ColumnAutoWidth = False
        Me.gvProgramacionPagosDetalle.OptionsView.ShowGroupPanel = False
        '
        'colProPaIdDetalle
        '
        Me.colProPaIdDetalle.Caption = "Cod. Prog."
        Me.colProPaIdDetalle.FieldName = "proPaId"
        Me.colProPaIdDetalle.Name = "colProPaIdDetalle"
        Me.colProPaIdDetalle.Visible = True
        Me.colProPaIdDetalle.VisibleIndex = 0
        '
        'colConId
        '
        Me.colConId.Caption = "Cod. Concepto"
        Me.colConId.FieldName = "conId"
        Me.colConId.Name = "colConId"
        Me.colConId.Visible = True
        Me.colConId.VisibleIndex = 1
        '
        'colConNombre
        '
        Me.colConNombre.Caption = "Concepto"
        Me.colConNombre.FieldName = "conNombre"
        Me.colConNombre.Name = "colConNombre"
        Me.colConNombre.Visible = True
        Me.colConNombre.VisibleIndex = 2
        '
        'colProPaDetPConcepto
        '
        Me.colProPaDetPConcepto.Caption = "P. Concepto"
        Me.colProPaDetPConcepto.FieldName = "proPaDetPConcepto"
        Me.colProPaDetPConcepto.Name = "colProPaDetPConcepto"
        Me.colProPaDetPConcepto.Visible = True
        Me.colProPaDetPConcepto.VisibleIndex = 3
        '
        'colProPaDetMonto
        '
        Me.colProPaDetMonto.Caption = "Monto"
        Me.colProPaDetMonto.DisplayFormat.FormatString = "{0:0.00}"
        Me.colProPaDetMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colProPaDetMonto.FieldName = "proPaDetMonto"
        Me.colProPaDetMonto.Name = "colProPaDetMonto"
        Me.colProPaDetMonto.Visible = True
        Me.colProPaDetMonto.VisibleIndex = 4
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(5, 647)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(101, 13)
        Me.SaimtLabel6.TabIndex = 15
        Me.SaimtLabel6.Text = "Cuotas No Pagadas :"
        '
        'txtCuotasNoPagadas
        '
        Me.txtCuotasNoPagadas.Location = New System.Drawing.Point(134, 644)
        Me.txtCuotasNoPagadas.MenuManager = Me.RibbonControl
        Me.txtCuotasNoPagadas.Name = "txtCuotasNoPagadas"
        Me.txtCuotasNoPagadas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCuotasNoPagadas.Properties.Appearance.Options.UseFont = True
        Me.txtCuotasNoPagadas.Properties.ReadOnly = True
        Me.txtCuotasNoPagadas.Size = New System.Drawing.Size(40, 20)
        Me.txtCuotasNoPagadas.TabIndex = 16
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(21, 621)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(85, 13)
        Me.SaimtLabel7.TabIndex = 13
        Me.SaimtLabel7.Text = "Cuotas Pagadas :"
        '
        'txtCuotasPagadas
        '
        Me.txtCuotasPagadas.Location = New System.Drawing.Point(134, 618)
        Me.txtCuotasPagadas.MenuManager = Me.RibbonControl
        Me.txtCuotasPagadas.Name = "txtCuotasPagadas"
        Me.txtCuotasPagadas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCuotasPagadas.Properties.Appearance.Options.UseFont = True
        Me.txtCuotasPagadas.Properties.ReadOnly = True
        Me.txtCuotasPagadas.Size = New System.Drawing.Size(40, 20)
        Me.txtCuotasPagadas.TabIndex = 14
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.Location = New System.Drawing.Point(260, 617)
        Me.txtTotalPagar.MenuManager = Me.RibbonControl
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalPagar.Properties.Appearance.Options.UseFont = True
        Me.txtTotalPagar.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalPagar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalPagar.Properties.Mask.EditMask = "n2"
        Me.txtTotalPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalPagar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalPagar.Properties.ReadOnly = True
        Me.txtTotalPagar.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPagar.TabIndex = 9
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(185, 620)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(71, 13)
        Me.SaimtLabel8.TabIndex = 8
        Me.SaimtLabel8.Text = "Total a Pagar :"
        '
        'txtPorPagar
        '
        Me.txtPorPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorPagar.Location = New System.Drawing.Point(450, 618)
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
        Me.txtPorPagar.TabIndex = 13
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel9.Location = New System.Drawing.Point(392, 621)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel9.TabIndex = 12
        Me.SaimtLabel9.Text = "Por Pagar :"
        '
        'txtTotalPagado
        '
        Me.txtTotalPagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPagado.Location = New System.Drawing.Point(260, 643)
        Me.txtTotalPagado.MenuManager = Me.RibbonControl
        Me.txtTotalPagado.Name = "txtTotalPagado"
        Me.txtTotalPagado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalPagado.Properties.Appearance.Options.UseFont = True
        Me.txtTotalPagado.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalPagado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalPagado.Properties.Mask.EditMask = "n2"
        Me.txtTotalPagado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalPagado.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalPagado.Properties.ReadOnly = True
        Me.txtTotalPagado.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPagado.TabIndex = 11
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel10.Location = New System.Drawing.Point(186, 646)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(70, 13)
        Me.SaimtLabel10.TabIndex = 10
        Me.SaimtLabel10.Text = "Total Pagado :"
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(388, 647)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel11.TabIndex = 17
        Me.SaimtLabel11.Text = "Total Mora :"
        '
        'txtTotalMora
        '
        Me.txtTotalMora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMora.Location = New System.Drawing.Point(450, 644)
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
        Me.txtTotalMora.TabIndex = 18
        '
        'txtTotalMoraRecalculo
        '
        Me.txtTotalMoraRecalculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMoraRecalculo.Location = New System.Drawing.Point(693, 618)
        Me.txtTotalMoraRecalculo.MenuManager = Me.RibbonControl
        Me.txtTotalMoraRecalculo.Name = "txtTotalMoraRecalculo"
        Me.txtTotalMoraRecalculo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalMoraRecalculo.Properties.Appearance.Options.UseFont = True
        Me.txtTotalMoraRecalculo.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalMoraRecalculo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalMoraRecalculo.Properties.Mask.EditMask = "n2"
        Me.txtTotalMoraRecalculo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalMoraRecalculo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalMoraRecalculo.Properties.ReadOnly = True
        Me.txtTotalMoraRecalculo.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMoraRecalculo.TabIndex = 20
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(578, 621)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(111, 13)
        Me.SaimtLabel12.TabIndex = 19
        Me.SaimtLabel12.Text = "Total Moras Recalculo :"
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(5, 670)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(118, 13)
        Me.SaimtLabel13.TabIndex = 21
        Me.SaimtLabel13.Text = "Cuotas Pagos Parciales :"
        '
        'txtCuotasParciales
        '
        Me.txtCuotasParciales.Location = New System.Drawing.Point(134, 667)
        Me.txtCuotasParciales.MenuManager = Me.RibbonControl
        Me.txtCuotasParciales.Name = "txtCuotasParciales"
        Me.txtCuotasParciales.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCuotasParciales.Properties.Appearance.Options.UseFont = True
        Me.txtCuotasParciales.Properties.ReadOnly = True
        Me.txtCuotasParciales.Size = New System.Drawing.Size(40, 20)
        Me.txtCuotasParciales.TabIndex = 22
        '
        'colTgEstadoId
        '
        Me.colTgEstadoId.Caption = "colTgEstadoId"
        Me.colTgEstadoId.FieldName = "tgEstadoId"
        Me.colTgEstadoId.Name = "colTgEstadoId"
        '
        'frmConsultarMora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 722)
        Me.Controls.Add(Me.SaimtLabel13)
        Me.Controls.Add(Me.txtCuotasParciales)
        Me.Controls.Add(Me.txtTotalMoraRecalculo)
        Me.Controls.Add(Me.SaimtLabel12)
        Me.Controls.Add(Me.txtTotalMora)
        Me.Controls.Add(Me.SaimtLabel11)
        Me.Controls.Add(Me.SaimtLabel6)
        Me.Controls.Add(Me.txtTotalPagar)
        Me.Controls.Add(Me.SaimtLabel8)
        Me.Controls.Add(Me.txtCuotasNoPagadas)
        Me.Controls.Add(Me.txtPorPagar)
        Me.Controls.Add(Me.SaimtLabel9)
        Me.Controls.Add(Me.SaimtLabel7)
        Me.Controls.Add(Me.txtCuotasPagadas)
        Me.Controls.Add(Me.txtTotalPagado)
        Me.Controls.Add(Me.SaimtLabel10)
        Me.Controls.Add(Me.SaimtGroupBox5)
        Me.Controls.Add(Me.SaimtGroupBox4)
        Me.Controls.Add(Me.grbDatosPersona)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.Controls.Add(Me.SaimtGroupBox3)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmConsultarMora"
        Me.Text = "CONSULTAR MORA"
        Me.Controls.SetChildIndex(Me.SaimtGroupBox3, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.grbDatosPersona, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox4, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox5, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel10, 0)
        Me.Controls.SetChildIndex(Me.txtTotalPagado, 0)
        Me.Controls.SetChildIndex(Me.txtCuotasPagadas, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel7, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel9, 0)
        Me.Controls.SetChildIndex(Me.txtPorPagar, 0)
        Me.Controls.SetChildIndex(Me.txtCuotasNoPagadas, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel8, 0)
        Me.Controls.SetChildIndex(Me.txtTotalPagar, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel6, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel11, 0)
        Me.Controls.SetChildIndex(Me.txtTotalMora, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel12, 0)
        Me.Controls.SetChildIndex(Me.txtTotalMoraRecalculo, 0)
        Me.Controls.SetChildIndex(Me.txtCuotasParciales, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel13, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosPersona.ResumeLayout(False)
        Me.grbDatosPersona.PerformLayout()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        CType(Me.dgvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvContrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        Me.SaimtGroupBox3.PerformLayout()
        CType(Me.dtpFechaPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox4.ResumeLayout(False)
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox5.ResumeLayout(False)
        CType(Me.dgvProgramacionPagosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionPagosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuotasNoPagadas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuotasPagadas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPagado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalMora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalMoraRecalculo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuotasParciales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbDatosPersona As SaimtControles.SaimtGroupBox
    Friend WithEvents txtCodigoPersona As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtPersona As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroDocumento As SaimtControles.SaimtTextBox
    Friend WithEvents txtTipoDocumento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents SplitterItem5 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents dgvContratos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvContrato As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents btnCalcularMora As SaimtControles.SaimtButton
    Friend WithEvents dtpFechaPago As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents dgvProgramacionPagos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionPagos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProPaNroCuota As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colProPaComision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtGroupBox4 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtGroupBox5 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents txtCuotasNoPagadas As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents txtCuotasPagadas As SaimtControles.SaimtTextBox
    Friend WithEvents txtTotalPagar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents txtPorPagar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents txtTotalPagado As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents txtTotalMora As SaimtControles.SaimtTextBox
    Friend WithEvents colConInmId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInmId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInmDireccionCompleta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgEstadoContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConInmFecIni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConInmFecFin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgUsoContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgMonedaContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgModalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConInmDiaMaxVen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvProgramacionPagosDetalle As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionPagosDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProPaIdDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaDetPConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaDetMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalMoraRecalculo As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents txtCuotasParciales As SaimtControles.SaimtTextBox
    Friend WithEvents colTgEstadoId As DevExpress.XtraGrid.Columns.GridColumn
End Class
