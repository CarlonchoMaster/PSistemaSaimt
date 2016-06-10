<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaProgramacionPagos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaProgramacionPagos))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.txtBuscarPersona = New SaimtControles.SaimtTextBox()
        Me.rdbCriteriosPersona = New SaimtControles.SaimtRadioGroup()
        Me.grbLista = New SaimtControles.SaimtGroupBox()
        Me.dgvInmueble = New SaimtControles.SaimtDataGrid()
        Me.gvInmueble = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgvPersona = New SaimtControles.SaimtDataGrid()
        Me.gvPersona = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.SaimtGroupBox6 = New SaimtControles.SaimtGroupBox()
        Me.dgvContratos = New SaimtControles.SaimtDataGrid()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerGaleriaDeArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gvContrato = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riObservacion = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riiAnexos = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.txtBuscarInmueble = New SaimtControles.SaimtTextBox()
        Me.rdbCriteriosInmueble = New SaimtControles.SaimtRadioGroup()
        Me.SaimtGroupBox4 = New SaimtControles.SaimtGroupBox()
        Me.btnCalcularM = New DevExpress.XtraEditors.DropDownButton()
        Me.btnimprimirf = New SaimtControles.SaimtButton()
        Me.btnimprimir = New SaimtControles.SaimtButton()
        Me.lblNroCuota = New SaimtControles.SaimtLabel()
        Me.txtTotalConcepto = New SaimtControles.SaimtTextBox()
        Me.lblTotalCuota = New SaimtControles.SaimtLabel()
        Me.txtTotalPagar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtPorPagar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.txtTotalPagado = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtCuotasNoPagadas = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtCuotasPagadas = New SaimtControles.SaimtTextBox()
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
        Me.colTgEstadoId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgvDetalleProgramacionPagos = New SaimtControles.SaimtDataGrid()
        Me.gvDetalleProgramacionPagos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProPaIdDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaDetPConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProPaDetMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtGroupBox5 = New SaimtControles.SaimtGroupBox()
        Me.btnComprobantePago = New SaimtControles.SaimtButton()
        Me.chkFiltroBusqueda = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.SplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.bieprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.pgbprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.txtBuscarPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbCriteriosPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLista.SuspendLayout()
        CType(Me.dgvInmueble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvInmueble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.SaimtGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox6.SuspendLayout()
        CType(Me.dgvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gvContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riiAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.txtBuscarInmueble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbCriteriosInmueble.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox4.SuspendLayout()
        CType(Me.txtTotalConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPagado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuotasNoPagadas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuotasPagadas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox5.SuspendLayout()
        CType(Me.chkFiltroBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.pgbprogreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.bieprogreso)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 658)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1276, 27)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SaimtGroupBox1.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SaimtGroupBox1.Appearance.Options.UseBackColor = True
        Me.SaimtGroupBox1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SaimtGroupBox1.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseFont = True
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseForeColor = True
        Me.SaimtGroupBox1.Controls.Add(Me.txtBuscarPersona)
        Me.SaimtGroupBox1.Controls.Add(Me.rdbCriteriosPersona)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(5, 7)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(249, 75)
        Me.SaimtGroupBox1.TabIndex = 0
        Me.SaimtGroupBox1.Text = "Búsqueda x Persona"
        '
        'txtBuscarPersona
        '
        Me.txtBuscarPersona.EditValue = ""
        Me.txtBuscarPersona.Location = New System.Drawing.Point(7, 44)
        Me.txtBuscarPersona.Name = "txtBuscarPersona"
        Me.txtBuscarPersona.Size = New System.Drawing.Size(232, 20)
        Me.txtBuscarPersona.TabIndex = 1
        '
        'rdbCriteriosPersona
        '
        Me.rdbCriteriosPersona.AutoSizeInLayoutControl = True
        Me.rdbCriteriosPersona.EditValue = CType(3, Short)
        Me.rdbCriteriosPersona.Location = New System.Drawing.Point(7, 23)
        Me.rdbCriteriosPersona.MenuManager = Me.RibbonControl
        Me.rdbCriteriosPersona.Name = "rdbCriteriosPersona"
        Me.rdbCriteriosPersona.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rdbCriteriosPersona.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCriteriosPersona.Properties.Appearance.Options.UseBackColor = True
        Me.rdbCriteriosPersona.Properties.Appearance.Options.UseFont = True
        Me.rdbCriteriosPersona.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdbCriteriosPersona.Properties.Columns = 3
        Me.rdbCriteriosPersona.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "Nombre"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "RUC"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "DNI")})
        Me.rdbCriteriosPersona.Size = New System.Drawing.Size(232, 23)
        Me.rdbCriteriosPersona.TabIndex = 0
        '
        'grbLista
        '
        Me.grbLista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbLista.Controls.Add(Me.dgvInmueble)
        Me.grbLista.Controls.Add(Me.dgvPersona)
        Me.grbLista.Location = New System.Drawing.Point(3, 88)
        Me.grbLista.Name = "grbLista"
        Me.grbLista.Size = New System.Drawing.Size(563, 280)
        Me.grbLista.TabIndex = 2
        Me.grbLista.Text = "Resultado de Busqueda"
        '
        'dgvInmueble
        '
        Me.dgvInmueble.Location = New System.Drawing.Point(295, 28)
        Me.dgvInmueble.MainView = Me.gvInmueble
        Me.dgvInmueble.MenuManager = Me.RibbonControl
        Me.dgvInmueble.Name = "dgvInmueble"
        Me.dgvInmueble.Size = New System.Drawing.Size(246, 247)
        Me.dgvInmueble.TabIndex = 1
        Me.dgvInmueble.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInmueble})
        '
        'gvInmueble
        '
        Me.gvInmueble.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvInmueble.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvInmueble.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvInmueble.GridControl = Me.dgvInmueble
        Me.gvInmueble.Name = "gvInmueble"
        Me.gvInmueble.OptionsBehavior.ReadOnly = True
        Me.gvInmueble.OptionsView.ColumnAutoWidth = False
        Me.gvInmueble.OptionsView.ShowGroupPanel = False
        '
        'dgvPersona
        '
        Me.dgvPersona.Location = New System.Drawing.Point(24, 28)
        Me.dgvPersona.MainView = Me.gvPersona
        Me.dgvPersona.MenuManager = Me.RibbonControl
        Me.dgvPersona.Name = "dgvPersona"
        Me.dgvPersona.Size = New System.Drawing.Size(265, 247)
        Me.dgvPersona.TabIndex = 0
        Me.dgvPersona.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPersona})
        '
        'gvPersona
        '
        Me.gvPersona.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvPersona.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvPersona.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvPersona.GridControl = Me.dgvPersona
        Me.gvPersona.Name = "gvPersona"
        Me.gvPersona.OptionsBehavior.ReadOnly = True
        Me.gvPersona.OptionsView.ColumnAutoWidth = False
        Me.gvPersona.OptionsView.ShowGroupPanel = False
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.SaimtGroupBox2.AppearanceCaption.Options.UseForeColor = True
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtGroupBox6)
        Me.SaimtGroupBox2.Controls.Add(Me.grbLista)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtGroupBox3)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.ShowCaption = False
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(572, 658)
        Me.SaimtGroupBox2.TabIndex = 0
        '
        'SaimtGroupBox6
        '
        Me.SaimtGroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox6.Controls.Add(Me.dgvContratos)
        Me.SaimtGroupBox6.Location = New System.Drawing.Point(4, 374)
        Me.SaimtGroupBox6.Name = "SaimtGroupBox6"
        Me.SaimtGroupBox6.Size = New System.Drawing.Size(563, 279)
        Me.SaimtGroupBox6.TabIndex = 3
        Me.SaimtGroupBox6.Text = "Contratos"
        '
        'dgvContratos
        '
        Me.dgvContratos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvContratos.Location = New System.Drawing.Point(2, 21)
        Me.dgvContratos.MainView = Me.gvContrato
        Me.dgvContratos.MenuManager = Me.RibbonControl
        Me.dgvContratos.Name = "dgvContratos"
        Me.dgvContratos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riObservacion, Me.riiAnexos})
        Me.dgvContratos.Size = New System.Drawing.Size(559, 256)
        Me.dgvContratos.TabIndex = 0
        Me.dgvContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvContrato})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerGaleriaDeArchivosToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(196, 26)
        '
        'VerGaleriaDeArchivosToolStripMenuItem
        '
        Me.VerGaleriaDeArchivosToolStripMenuItem.Image = CType(resources.GetObject("VerGaleriaDeArchivosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerGaleriaDeArchivosToolStripMenuItem.Name = "VerGaleriaDeArchivosToolStripMenuItem"
        Me.VerGaleriaDeArchivosToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.VerGaleriaDeArchivosToolStripMenuItem.Text = "Ver Galeria de Archivos"
        '
        'gvContrato
        '
        Me.gvContrato.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvContrato.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvContrato.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvContrato.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.gvContrato.GridControl = Me.dgvContratos
        Me.gvContrato.Images = Me.ImageCollection1
        Me.gvContrato.Name = "gvContrato"
        Me.gvContrato.OptionsBehavior.ReadOnly = True
        Me.gvContrato.OptionsView.ColumnAutoWidth = False
        Me.gvContrato.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Contrato"
        Me.GridColumn1.FieldName = "conInmId"
        Me.GridColumn1.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Cod. Inmueble"
        Me.GridColumn2.FieldName = "inmId"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha Inicio"
        Me.GridColumn3.FieldName = "conInmFecIni"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha Fin"
        Me.GridColumn4.FieldName = "conInmFecFin"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Dia Venc."
        Me.GridColumn5.FieldName = "conInmDiaMaxVen"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Ubicación Inmueble"
        Me.GridColumn6.FieldName = "inmDirLocalizacion"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Uso"
        Me.GridColumn7.FieldName = "tgUso"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Estado"
        Me.GridColumn8.FieldName = "tgEstado"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Moneda"
        Me.GridColumn9.FieldName = "tgMoneda"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 10
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Modalidad"
        Me.GridColumn10.FieldName = "tgModalidad"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 11
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Observación"
        Me.GridColumn11.ColumnEdit = Me.riObservacion
        Me.GridColumn11.FieldName = "conInmObs"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        '
        'riObservacion
        '
        Me.riObservacion.AutoHeight = False
        Me.riObservacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riObservacion.Name = "riObservacion"
        Me.riObservacion.ShowIcon = False
        '
        'GridColumn12
        '
        Me.GridColumn12.ColumnEdit = Me.riiAnexos
        Me.GridColumn12.FieldName = "Anexos"
        Me.GridColumn12.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.GridColumn12.ImageIndex = 1
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ShowCaption = False
        Me.GridColumn12.ToolTip = "Tiene Anexos?"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        Me.GridColumn12.Width = 35
        '
        'riiAnexos
        '
        Me.riiAnexos.AutoHeight = False
        Me.riiAnexos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riiAnexos.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.riiAnexos.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", CType(1, Short), 0)})
        Me.riiAnexos.Name = "riiAnexos"
        Me.riiAnexos.SmallImages = Me.ImageCollection1
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "attach.png")
        Me.ImageCollection1.Images.SetKeyName(1, "page_attach.png")
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SaimtGroupBox3.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SaimtGroupBox3.Appearance.Options.UseBackColor = True
        Me.SaimtGroupBox3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SaimtGroupBox3.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtGroupBox3.AppearanceCaption.Options.UseFont = True
        Me.SaimtGroupBox3.AppearanceCaption.Options.UseForeColor = True
        Me.SaimtGroupBox3.Controls.Add(Me.txtBuscarInmueble)
        Me.SaimtGroupBox3.Controls.Add(Me.rdbCriteriosInmueble)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(260, 7)
        Me.SaimtGroupBox3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(303, 75)
        Me.SaimtGroupBox3.TabIndex = 1
        Me.SaimtGroupBox3.Text = "Búsqueda x Inmueble"
        '
        'txtBuscarInmueble
        '
        Me.txtBuscarInmueble.EditValue = ""
        Me.txtBuscarInmueble.Location = New System.Drawing.Point(7, 44)
        Me.txtBuscarInmueble.Name = "txtBuscarInmueble"
        Me.txtBuscarInmueble.Size = New System.Drawing.Size(289, 20)
        Me.txtBuscarInmueble.TabIndex = 1
        '
        'rdbCriteriosInmueble
        '
        Me.rdbCriteriosInmueble.AutoSizeInLayoutControl = True
        Me.rdbCriteriosInmueble.EditValue = CType(1, Short)
        Me.rdbCriteriosInmueble.Location = New System.Drawing.Point(7, 23)
        Me.rdbCriteriosInmueble.Name = "rdbCriteriosInmueble"
        Me.rdbCriteriosInmueble.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rdbCriteriosInmueble.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCriteriosInmueble.Properties.Appearance.Options.UseBackColor = True
        Me.rdbCriteriosInmueble.Properties.Appearance.Options.UseFont = True
        Me.rdbCriteriosInmueble.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdbCriteriosInmueble.Properties.Columns = 4
        Me.rdbCriteriosInmueble.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Denominación"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "Codigo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(4, Short), "Nro. File"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Dirección")})
        Me.rdbCriteriosInmueble.Size = New System.Drawing.Size(289, 23)
        Me.rdbCriteriosInmueble.TabIndex = 0
        '
        'SaimtGroupBox4
        '
        Me.SaimtGroupBox4.Controls.Add(Me.btnCalcularM)
        Me.SaimtGroupBox4.Controls.Add(Me.btnimprimirf)
        Me.SaimtGroupBox4.Controls.Add(Me.btnimprimir)
        Me.SaimtGroupBox4.Controls.Add(Me.lblNroCuota)
        Me.SaimtGroupBox4.Controls.Add(Me.txtTotalConcepto)
        Me.SaimtGroupBox4.Controls.Add(Me.lblTotalCuota)
        Me.SaimtGroupBox4.Controls.Add(Me.txtTotalPagar)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox4.Controls.Add(Me.txtPorPagar)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox4.Controls.Add(Me.txtTotalPagado)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox4.Controls.Add(Me.txtCuotasNoPagadas)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox4.Controls.Add(Me.txtCuotasPagadas)
        Me.SaimtGroupBox4.Controls.Add(Me.dgvProgramacionPagos)
        Me.SaimtGroupBox4.Controls.Add(Me.dgvDetalleProgramacionPagos)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtGroupBox5)
        Me.SaimtGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.SaimtGroupBox4.Name = "SaimtGroupBox4"
        Me.SaimtGroupBox4.Size = New System.Drawing.Size(699, 658)
        Me.SaimtGroupBox4.TabIndex = 0
        Me.SaimtGroupBox4.Text = "Programacion de Pagos"
        '
        'btnCalcularM
        '
        Me.btnCalcularM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCalcularM.Appearance.Options.UseTextOptions = True
        Me.btnCalcularM.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCalcularM.DropDownControl = Me.pmconsultorpropagos
        Me.btnCalcularM.Image = CType(resources.GetObject("btnCalcularM.Image"), System.Drawing.Image)
        Me.btnCalcularM.Location = New System.Drawing.Point(398, 607)
        Me.btnCalcularM.Name = "btnCalcularM"
        Me.btnCalcularM.Size = New System.Drawing.Size(101, 42)
        Me.btnCalcularM.TabIndex = 19
        Me.btnCalcularM.Text = "Simular Mora"
        '
        'btnimprimirf
        '
        Me.btnimprimirf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnimprimirf.Appearance.Options.UseTextOptions = True
        Me.btnimprimirf.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnimprimirf.Image = CType(resources.GetObject("btnimprimirf.Image"), System.Drawing.Image)
        Me.btnimprimirf.Location = New System.Drawing.Point(280, 607)
        Me.btnimprimirf.Name = "btnimprimirf"
        Me.btnimprimirf.Size = New System.Drawing.Size(112, 42)
        Me.btnimprimirf.TabIndex = 17
        Me.btnimprimirf.Text = "Imprimir Ficha Programación"
        '
        'btnimprimir
        '
        Me.btnimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnimprimir.Appearance.Options.UseTextOptions = True
        Me.btnimprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
        Me.btnimprimir.Location = New System.Drawing.Point(165, 607)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(109, 42)
        Me.btnimprimir.TabIndex = 16
        Me.btnimprimir.Text = "Imprimir Orden Pago"
        '
        'lblNroCuota
        '
        Me.lblNroCuota.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNroCuota.Location = New System.Drawing.Point(590, 606)
        Me.lblNroCuota.Name = "lblNroCuota"
        Me.lblNroCuota.Size = New System.Drawing.Size(19, 13)
        Me.lblNroCuota.TabIndex = 15
        Me.lblNroCuota.Text = "00 :"
        '
        'txtTotalConcepto
        '
        Me.txtTotalConcepto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalConcepto.Location = New System.Drawing.Point(613, 603)
        Me.txtTotalConcepto.MenuManager = Me.RibbonControl
        Me.txtTotalConcepto.Name = "txtTotalConcepto"
        Me.txtTotalConcepto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalConcepto.Properties.Appearance.Options.UseFont = True
        Me.txtTotalConcepto.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalConcepto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalConcepto.Properties.Mask.EditMask = "n2"
        Me.txtTotalConcepto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalConcepto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalConcepto.Properties.ReadOnly = True
        Me.txtTotalConcepto.Size = New System.Drawing.Size(82, 20)
        Me.txtTotalConcepto.TabIndex = 14
        '
        'lblTotalCuota
        '
        Me.lblTotalCuota.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalCuota.Location = New System.Drawing.Point(511, 606)
        Me.lblTotalCuota.Name = "lblTotalCuota"
        Me.lblTotalCuota.Size = New System.Drawing.Size(71, 13)
        Me.lblTotalCuota.TabIndex = 13
        Me.lblTotalCuota.Text = "Total Cuota N°"
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPagar.Location = New System.Drawing.Point(79, 434)
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
        Me.txtTotalPagar.TabIndex = 3
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel5.Location = New System.Drawing.Point(2, 437)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(71, 13)
        Me.SaimtLabel5.TabIndex = 2
        Me.SaimtLabel5.Text = "Total a Pagar :"
        '
        'txtPorPagar
        '
        Me.txtPorPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPorPagar.Location = New System.Drawing.Point(594, 434)
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
        Me.txtPorPagar.TabIndex = 7
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel4.Location = New System.Drawing.Point(534, 437)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel4.TabIndex = 6
        Me.SaimtLabel4.Text = "Por Pagar :"
        '
        'txtTotalPagado
        '
        Me.txtTotalPagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPagado.Location = New System.Drawing.Point(417, 434)
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
        Me.txtTotalPagado.TabIndex = 5
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel3.Location = New System.Drawing.Point(340, 437)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(70, 13)
        Me.SaimtLabel3.TabIndex = 4
        Me.SaimtLabel3.Text = "Total Pagado :"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel2.Location = New System.Drawing.Point(5, 632)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(101, 13)
        Me.SaimtLabel2.TabIndex = 11
        Me.SaimtLabel2.Text = "Cuotas No Pagadas :"
        '
        'txtCuotasNoPagadas
        '
        Me.txtCuotasNoPagadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCuotasNoPagadas.Location = New System.Drawing.Point(112, 629)
        Me.txtCuotasNoPagadas.MenuManager = Me.RibbonControl
        Me.txtCuotasNoPagadas.Name = "txtCuotasNoPagadas"
        Me.txtCuotasNoPagadas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCuotasNoPagadas.Properties.Appearance.Options.UseFont = True
        Me.txtCuotasNoPagadas.Properties.ReadOnly = True
        Me.txtCuotasNoPagadas.Size = New System.Drawing.Size(40, 20)
        Me.txtCuotasNoPagadas.TabIndex = 12
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel1.Location = New System.Drawing.Point(21, 606)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(85, 13)
        Me.SaimtLabel1.TabIndex = 9
        Me.SaimtLabel1.Text = "Cuotas Pagadas :"
        '
        'txtCuotasPagadas
        '
        Me.txtCuotasPagadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCuotasPagadas.Location = New System.Drawing.Point(112, 603)
        Me.txtCuotasPagadas.MenuManager = Me.RibbonControl
        Me.txtCuotasPagadas.Name = "txtCuotasPagadas"
        Me.txtCuotasPagadas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCuotasPagadas.Properties.Appearance.Options.UseFont = True
        Me.txtCuotasPagadas.Properties.ReadOnly = True
        Me.txtCuotasPagadas.Size = New System.Drawing.Size(40, 20)
        Me.txtCuotasPagadas.TabIndex = 10
        '
        'dgvProgramacionPagos
        '
        Me.dgvProgramacionPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProgramacionPagos.Location = New System.Drawing.Point(5, 89)
        Me.dgvProgramacionPagos.MainView = Me.gvProgramacionPagos
        Me.dgvProgramacionPagos.MenuManager = Me.RibbonControl
        Me.dgvProgramacionPagos.Name = "dgvProgramacionPagos"
        Me.dgvProgramacionPagos.Size = New System.Drawing.Size(692, 340)
        Me.dgvProgramacionPagos.TabIndex = 1
        Me.dgvProgramacionPagos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionPagos})
        '
        'gvProgramacionPagos
        '
        Me.gvProgramacionPagos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvProgramacionPagos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvProgramacionPagos.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvProgramacionPagos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProPaNroCuota, Me.colProPaId, Me.colTgTipoComprobante, Me.colProPaFechaPag, Me.colMes, Me.colProPaFechaVen, Me.colTgEstado, Me.colProPaDetIgv, Me.colProPaPMora, Me.colProPaAplicaD, Me.colTgRecaudadora, Me.colTgMoneda, Me.colProPaComision, Me.colTgEstadoId, Me.GridColumn13})
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
        Me.colProPaFechaPag.VisibleIndex = 4
        '
        'colMes
        '
        Me.colMes.Caption = "Mes"
        Me.colMes.FieldName = "Mes"
        Me.colMes.Name = "colMes"
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
        'colTgEstado
        '
        Me.colTgEstado.Caption = "Estado"
        Me.colTgEstado.FieldName = "tgEstado"
        Me.colTgEstado.Name = "colTgEstado"
        Me.colTgEstado.Visible = True
        Me.colTgEstado.VisibleIndex = 7
        '
        'colProPaDetIgv
        '
        Me.colProPaDetIgv.Caption = "IGV"
        Me.colProPaDetIgv.FieldName = "proPaDetIgv"
        Me.colProPaDetIgv.Name = "colProPaDetIgv"
        Me.colProPaDetIgv.Visible = True
        Me.colProPaDetIgv.VisibleIndex = 8
        '
        'colProPaPMora
        '
        Me.colProPaPMora.Caption = "Mora"
        Me.colProPaPMora.FieldName = "proPaPMora"
        Me.colProPaPMora.Name = "colProPaPMora"
        Me.colProPaPMora.Visible = True
        Me.colProPaPMora.VisibleIndex = 9
        '
        'colProPaAplicaD
        '
        Me.colProPaAplicaD.Caption = "Aplica Det."
        Me.colProPaAplicaD.FieldName = "proPaAplicaD"
        Me.colProPaAplicaD.Name = "colProPaAplicaD"
        Me.colProPaAplicaD.Visible = True
        Me.colProPaAplicaD.VisibleIndex = 10
        '
        'colTgRecaudadora
        '
        Me.colTgRecaudadora.Caption = "Recaudadora"
        Me.colTgRecaudadora.FieldName = "tgRecaudadora"
        Me.colTgRecaudadora.Name = "colTgRecaudadora"
        Me.colTgRecaudadora.Visible = True
        Me.colTgRecaudadora.VisibleIndex = 11
        '
        'colTgMoneda
        '
        Me.colTgMoneda.Caption = "Moneda"
        Me.colTgMoneda.FieldName = "tgMoneda"
        Me.colTgMoneda.Name = "colTgMoneda"
        Me.colTgMoneda.Visible = True
        Me.colTgMoneda.VisibleIndex = 12
        '
        'colProPaComision
        '
        Me.colProPaComision.Caption = "Comisión"
        Me.colProPaComision.FieldName = "proPaComision"
        Me.colProPaComision.Name = "colProPaComision"
        Me.colProPaComision.Visible = True
        Me.colProPaComision.VisibleIndex = 13
        '
        'colTgEstadoId
        '
        Me.colTgEstadoId.Caption = "GridColumn1"
        Me.colTgEstadoId.FieldName = "tgEstadoId"
        Me.colTgEstadoId.Name = "colTgEstadoId"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "N° Comp."
        Me.GridColumn13.FieldName = "nroComprobante"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        '
        'dgvDetalleProgramacionPagos
        '
        Me.dgvDetalleProgramacionPagos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleProgramacionPagos.Location = New System.Drawing.Point(5, 460)
        Me.dgvDetalleProgramacionPagos.MainView = Me.gvDetalleProgramacionPagos
        Me.dgvDetalleProgramacionPagos.MenuManager = Me.RibbonControl
        Me.dgvDetalleProgramacionPagos.Name = "dgvDetalleProgramacionPagos"
        Me.dgvDetalleProgramacionPagos.Size = New System.Drawing.Size(692, 132)
        Me.dgvDetalleProgramacionPagos.TabIndex = 8
        Me.dgvDetalleProgramacionPagos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalleProgramacionPagos})
        '
        'gvDetalleProgramacionPagos
        '
        Me.gvDetalleProgramacionPagos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvDetalleProgramacionPagos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvDetalleProgramacionPagos.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvDetalleProgramacionPagos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProPaIdDetalle, Me.colConId, Me.colConNombre, Me.colProPaDetPConcepto, Me.colProPaDetMonto})
        Me.gvDetalleProgramacionPagos.GridControl = Me.dgvDetalleProgramacionPagos
        Me.gvDetalleProgramacionPagos.Name = "gvDetalleProgramacionPagos"
        Me.gvDetalleProgramacionPagos.OptionsBehavior.ReadOnly = True
        Me.gvDetalleProgramacionPagos.OptionsCustomization.AllowFilter = False
        Me.gvDetalleProgramacionPagos.OptionsCustomization.AllowSort = False
        Me.gvDetalleProgramacionPagos.OptionsView.ColumnAutoWidth = False
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
        Me.colProPaDetPConcepto.DisplayFormat.FormatString = "p"
        Me.colProPaDetPConcepto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProPaDetPConcepto.FieldName = "proPaDetPConcepto"
        Me.colProPaDetPConcepto.Name = "colProPaDetPConcepto"
        Me.colProPaDetPConcepto.Visible = True
        Me.colProPaDetPConcepto.VisibleIndex = 3
        '
        'colProPaDetMonto
        '
        Me.colProPaDetMonto.Caption = "Monto"
        Me.colProPaDetMonto.FieldName = "proPaDetMonto"
        Me.colProPaDetMonto.Name = "colProPaDetMonto"
        Me.colProPaDetMonto.Visible = True
        Me.colProPaDetMonto.VisibleIndex = 4
        '
        'SaimtGroupBox5
        '
        Me.SaimtGroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox5.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SaimtGroupBox5.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SaimtGroupBox5.Appearance.Options.UseBackColor = True
        Me.SaimtGroupBox5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SaimtGroupBox5.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtGroupBox5.AppearanceCaption.Options.UseFont = True
        Me.SaimtGroupBox5.AppearanceCaption.Options.UseForeColor = True
        Me.SaimtGroupBox5.Controls.Add(Me.btnComprobantePago)
        Me.SaimtGroupBox5.Controls.Add(Me.chkFiltroBusqueda)
        Me.SaimtGroupBox5.Location = New System.Drawing.Point(2, 30)
        Me.SaimtGroupBox5.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox5.Name = "SaimtGroupBox5"
        Me.SaimtGroupBox5.Size = New System.Drawing.Size(692, 52)
        Me.SaimtGroupBox5.TabIndex = 0
        Me.SaimtGroupBox5.Text = "Filtro"
        '
        'btnComprobantePago
        '
        Me.btnComprobantePago.Image = CType(resources.GetObject("btnComprobantePago.Image"), System.Drawing.Image)
        Me.btnComprobantePago.Location = New System.Drawing.Point(588, 24)
        Me.btnComprobantePago.Name = "btnComprobantePago"
        Me.btnComprobantePago.Size = New System.Drawing.Size(90, 23)
        Me.btnComprobantePago.TabIndex = 7
        Me.btnComprobantePago.Text = "Comp. Pago"
        '
        'chkFiltroBusqueda
        '
        Me.chkFiltroBusqueda.EditValue = ""
        Me.chkFiltroBusqueda.Location = New System.Drawing.Point(7, 26)
        Me.chkFiltroBusqueda.MenuManager = Me.RibbonControl
        Me.chkFiltroBusqueda.Name = "chkFiltroBusqueda"
        Me.chkFiltroBusqueda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.chkFiltroBusqueda.Size = New System.Drawing.Size(464, 20)
        Me.chkFiltroBusqueda.TabIndex = 0
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "BarButtonItem7"
        Me.BarButtonItem7.Id = 2
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "BarButtonItem8"
        Me.BarButtonItem8.Id = 3
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "BarButtonItem9"
        Me.BarButtonItem9.Id = 2
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "BarButtonItem10"
        Me.BarButtonItem10.Id = 3
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Calcular Mora"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Calcular Mora Sin Contrato"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BarButtonItem4"
        Me.BarButtonItem4.Glyph = CType(resources.GetObject("BarButtonItem4.Glyph"), System.Drawing.Image)
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SaimtGroupBox2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox4)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1276, 658)
        Me.SplitContainerControl1.SplitterPosition = 572
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'bieprogreso
        '
        Me.bieprogreso.Caption = "BarEditItem1"
        Me.bieprogreso.Edit = Me.pgbprogreso
        Me.bieprogreso.Id = 3
        Me.bieprogreso.Name = "bieprogreso"
        Me.bieprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bieprogreso.Width = 110
        '
        'pgbprogreso
        '
        Me.pgbprogreso.Name = "pgbprogreso"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem5"
        Me.BarButtonItem5.Glyph = CType(resources.GetObject("BarButtonItem5.Glyph"), System.Drawing.Image)
        Me.BarButtonItem5.Id = 2
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "BarButtonItem6"
        Me.BarButtonItem6.Glyph = CType(resources.GetObject("BarButtonItem6.Glyph"), System.Drawing.Image)
        Me.BarButtonItem6.Id = 3
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Ver Galeria de Archivos"
        Me.BarButtonItem11.Glyph = CType(resources.GetObject("BarButtonItem11.Glyph"), System.Drawing.Image)
        Me.BarButtonItem11.Id = 4
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "BarButtonItem12"
        Me.BarButtonItem12.Id = 4
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'frmConsultaProgramacionPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 685)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.MaximizeBox = True
        Me.Name = "frmConsultaProgramacionPagos"
        Me.Tag = "btiConsultorProgramacionPagos"
        Me.Text = "CONSULTOR PROGRAMACIÓN PAGOS"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.txtBuscarPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbCriteriosPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLista.ResumeLayout(False)
        CType(Me.dgvInmueble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvInmueble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        CType(Me.SaimtGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox6.ResumeLayout(False)
        CType(Me.dgvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gvContrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riiAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        CType(Me.txtBuscarInmueble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbCriteriosInmueble.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox4.ResumeLayout(False)
        Me.SaimtGroupBox4.PerformLayout()
        CType(Me.txtTotalConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPagado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuotasNoPagadas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuotasPagadas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox5.ResumeLayout(False)
        CType(Me.chkFiltroBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.pgbprogreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents grbLista As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtBuscarPersona As SaimtControles.SaimtTextBox
    Friend WithEvents rdbCriteriosPersona As SaimtControles.SaimtRadioGroup
    Friend WithEvents SaimtGroupBox6 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtBuscarInmueble As SaimtControles.SaimtTextBox
    Friend WithEvents rdbCriteriosInmueble As SaimtControles.SaimtRadioGroup
    Friend WithEvents dgvPersona As SaimtControles.SaimtDataGrid
    Friend WithEvents gvPersona As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvContratos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvContrato As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SaimtGroupBox4 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvProgramacionPagos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionPagos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SaimtGroupBox5 As SaimtControles.SaimtGroupBox
    Friend WithEvents chkFiltroBusqueda As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents SplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents dgvInmueble As SaimtControles.SaimtDataGrid
    Friend WithEvents gvInmueble As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvDetalleProgramacionPagos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvDetalleProgramacionPagos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCuotasPagadas As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtCuotasNoPagadas As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtTotalPagado As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents txtPorPagar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents txtTotalPagar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtTotalConcepto As SaimtControles.SaimtTextBox
    Friend WithEvents lblTotalCuota As SaimtControles.SaimtLabel
    Friend WithEvents lblNroCuota As SaimtControles.SaimtLabel
    Friend WithEvents btnimprimir As SaimtControles.SaimtButton
    Friend WithEvents btnimprimirf As SaimtControles.SaimtButton
    Friend WithEvents bieprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents pgbprogreso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
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
    Friend WithEvents colProPaIdDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaDetPConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProPaDetMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCalcularM As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Protected WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Protected WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colTgEstadoId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riObservacion As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riiAnexos As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerGaleriaDeArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnComprobantePago As SaimtControles.SaimtButton
End Class
