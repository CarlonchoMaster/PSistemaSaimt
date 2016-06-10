<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanCuentas
    Inherits frmMantenimientos

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanCuentas))
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.cboTipoCuentaCriterio = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboAñoPor = New SaimtControles.SaimtComboBox()
        Me.cboCriterioPor = New SaimtControles.SaimtComboBox()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoPlanCuentas = New SaimtControles.SaimtDataGrid()
        Me.gvListadoPlanCuentas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtTabs1 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.txtDescripcion = New SaimtControles.SaimtTextBoxMultiline()
        Me.btnConsultarCuentaAbona = New SaimtControles.SaimtButton()
        Me.btnConsultarCuentaCarga = New SaimtControles.SaimtButton()
        Me.txtCuentaAbono = New SaimtControles.SaimtTextBox()
        Me.txtCuentaCargo = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.cboTipoAuxiliar = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboTipoCuenta = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtAño = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtCuenta = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnExportarExcelPlanCuentas = New SaimtControles.SaimtButton()
        Me.btnMostrarPlanCuentas = New SaimtControles.SaimtButton()
        Me.dgvVisorPlanCuenta = New SaimtControles.SaimtDataGrid()
        Me.gvVisorPlanCuenta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sfdRutaExcelPlanCuenta = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.cboTipoCuentaCriterio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAñoPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterioPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.dgvListadoPlanCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoPlanCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaAbono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAuxiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.dgvVisorPlanCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVisorPlanCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 434)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(968, 27)
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboTipoCuentaCriterio)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboAñoPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboCriterioPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtTabs1)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(968, 434)
        Me.SaimtSplitContainerControl1.SplitterPosition = 264
        Me.SaimtSplitContainerControl1.TabIndex = 0
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'cboTipoCuentaCriterio
        '
        Me.cboTipoCuentaCriterio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoCuentaCriterio.Location = New System.Drawing.Point(6, 47)
        Me.cboTipoCuentaCriterio.MenuManager = Me.RibbonControl
        Me.cboTipoCuentaCriterio.Name = "cboTipoCuentaCriterio"
        Me.cboTipoCuentaCriterio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoCuentaCriterio.Properties.NullText = ""
        Me.cboTipoCuentaCriterio.Size = New System.Drawing.Size(253, 20)
        Me.cboTipoCuentaCriterio.TabIndex = 5
        Me.cboTipoCuentaCriterio.Tag = "0"
        '
        'cboAñoPor
        '
        Me.cboAñoPor.Location = New System.Drawing.Point(199, 21)
        Me.cboAñoPor.MenuManager = Me.RibbonControl
        Me.cboAñoPor.Name = "cboAñoPor"
        Me.cboAñoPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAñoPor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboAñoPor.Size = New System.Drawing.Size(60, 20)
        Me.cboAñoPor.TabIndex = 2
        Me.cboAñoPor.Tag = "0"
        '
        'cboCriterioPor
        '
        Me.cboCriterioPor.EditValue = "Busqueda por Cuenta"
        Me.cboCriterioPor.Location = New System.Drawing.Point(6, 21)
        Me.cboCriterioPor.MenuManager = Me.RibbonControl
        Me.cboCriterioPor.Name = "cboCriterioPor"
        Me.cboCriterioPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioPor.Properties.Items.AddRange(New Object() {"Busqueda por Cuenta", "Busqueda por Descripción Cuenta", "Busqueda por Año", "Busqueda por Tipo Cuenta", "Busqueda por Tipo Cuenta Auxiliar"})
        Me.cboCriterioPor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCriterioPor.Size = New System.Drawing.Size(187, 20)
        Me.cboCriterioPor.TabIndex = 1
        Me.cboCriterioPor.Tag = "0"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox1.Controls.Add(Me.dgvListadoPlanCuentas)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(6, 99)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(253, 328)
        Me.SaimtGroupBox1.TabIndex = 4
        Me.SaimtGroupBox1.Text = "Resultados de Busqueda"
        '
        'dgvListadoPlanCuentas
        '
        Me.dgvListadoPlanCuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoPlanCuentas.Location = New System.Drawing.Point(2, 22)
        Me.dgvListadoPlanCuentas.MainView = Me.gvListadoPlanCuentas
        Me.dgvListadoPlanCuentas.MenuManager = Me.RibbonControl
        Me.dgvListadoPlanCuentas.Name = "dgvListadoPlanCuentas"
        Me.dgvListadoPlanCuentas.Size = New System.Drawing.Size(249, 304)
        Me.dgvListadoPlanCuentas.TabIndex = 0
        Me.dgvListadoPlanCuentas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoPlanCuentas})
        '
        'gvListadoPlanCuentas
        '
        Me.gvListadoPlanCuentas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.gvListadoPlanCuentas.GridControl = Me.dgvListadoPlanCuentas
        Me.gvListadoPlanCuentas.Name = "gvListadoPlanCuentas"
        Me.gvListadoPlanCuentas.OptionsBehavior.ReadOnly = True
        Me.gvListadoPlanCuentas.OptionsCustomization.AllowSort = False
        Me.gvListadoPlanCuentas.OptionsView.ColumnAutoWidth = False
        Me.gvListadoPlanCuentas.OptionsView.ShowGroupPanel = False
        Me.gvListadoPlanCuentas.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cuenta"
        Me.GridColumn1.FieldName = "planCId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción Cuenta"
        Me.GridColumn2.FieldName = "planCDescripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Año"
        Me.GridColumn3.FieldName = "planCAño"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'txtBuscarPor
        '
        Me.txtBuscarPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPor.Location = New System.Drawing.Point(6, 73)
        Me.txtBuscarPor.MenuManager = Me.RibbonControl
        Me.txtBuscarPor.Name = "txtBuscarPor"
        Me.txtBuscarPor.Size = New System.Drawing.Size(253, 20)
        Me.txtBuscarPor.TabIndex = 3
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(10, 6)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Buscar por"
        '
        'SaimtTabs1
        '
        Me.SaimtTabs1.Location = New System.Drawing.Point(2, 6)
        Me.SaimtTabs1.Name = "SaimtTabs1"
        Me.SaimtTabs1.SelectedTabPage = Me.XtraTabPage1
        Me.SaimtTabs1.Size = New System.Drawing.Size(697, 457)
        Me.SaimtTabs1.TabIndex = 0
        Me.SaimtTabs1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SaimtGroupBox2)
        Me.XtraTabPage1.Controls.Add(Me.btnCancelar)
        Me.XtraTabPage1.Controls.Add(Me.btnNuevo)
        Me.XtraTabPage1.Controls.Add(Me.btnEliminar)
        Me.XtraTabPage1.Controls.Add(Me.btnEditar)
        Me.XtraTabPage1.Controls.Add(Me.btnLimpiar)
        Me.XtraTabPage1.Controls.Add(Me.btnGuardar)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(691, 431)
        Me.XtraTabPage1.Text = "Plan de Cuentas"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.txtDescripcion)
        Me.SaimtGroupBox2.Controls.Add(Me.btnConsultarCuentaAbona)
        Me.SaimtGroupBox2.Controls.Add(Me.btnConsultarCuentaCarga)
        Me.SaimtGroupBox2.Controls.Add(Me.txtCuentaAbono)
        Me.SaimtGroupBox2.Controls.Add(Me.txtCuentaCargo)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox2.Controls.Add(Me.cboTipoAuxiliar)
        Me.SaimtGroupBox2.Controls.Add(Me.cboTipoCuenta)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox2.Controls.Add(Me.txtAño)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox2.Controls.Add(Me.txtCuenta)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(691, 331)
        Me.SaimtGroupBox2.TabIndex = 0
        Me.SaimtGroupBox2.Text = "Datos del Plan de Cuentas"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(72, 65)
        Me.txtDescripcion.MenuManager = Me.RibbonControl
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(599, 96)
        Me.txtDescripcion.TabIndex = 5
        '
        'btnConsultarCuentaAbona
        '
        Me.btnConsultarCuentaAbona.Image = CType(resources.GetObject("btnConsultarCuentaAbona.Image"), System.Drawing.Image)
        Me.btnConsultarCuentaAbona.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConsultarCuentaAbona.Location = New System.Drawing.Point(661, 255)
        Me.btnConsultarCuentaAbona.Name = "btnConsultarCuentaAbona"
        Me.btnConsultarCuentaAbona.Size = New System.Drawing.Size(21, 21)
        Me.btnConsultarCuentaAbona.TabIndex = 15
        '
        'btnConsultarCuentaCarga
        '
        Me.btnConsultarCuentaCarga.Image = CType(resources.GetObject("btnConsultarCuentaCarga.Image"), System.Drawing.Image)
        Me.btnConsultarCuentaCarga.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConsultarCuentaCarga.Location = New System.Drawing.Point(661, 212)
        Me.btnConsultarCuentaCarga.Name = "btnConsultarCuentaCarga"
        Me.btnConsultarCuentaCarga.Size = New System.Drawing.Size(21, 21)
        Me.btnConsultarCuentaCarga.TabIndex = 12
        '
        'txtCuentaAbono
        '
        Me.txtCuentaAbono.Location = New System.Drawing.Point(72, 256)
        Me.txtCuentaAbono.MenuManager = Me.RibbonControl
        Me.txtCuentaAbono.Name = "txtCuentaAbono"
        Me.txtCuentaAbono.Size = New System.Drawing.Size(587, 20)
        Me.txtCuentaAbono.TabIndex = 14
        '
        'txtCuentaCargo
        '
        Me.txtCuentaCargo.Location = New System.Drawing.Point(72, 213)
        Me.txtCuentaCargo.MenuManager = Me.RibbonControl
        Me.txtCuentaCargo.Name = "txtCuentaCargo"
        Me.txtCuentaCargo.Size = New System.Drawing.Size(587, 20)
        Me.txtCuentaCargo.TabIndex = 11
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(72, 239)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(116, 13)
        Me.SaimtLabel8.TabIndex = 13
        Me.SaimtLabel8.Text = "Cuenta donde se Abona"
        '
        'cboTipoAuxiliar
        '
        Me.cboTipoAuxiliar.Location = New System.Drawing.Point(434, 170)
        Me.cboTipoAuxiliar.MenuManager = Me.RibbonControl
        Me.cboTipoAuxiliar.Name = "cboTipoAuxiliar"
        Me.cboTipoAuxiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoAuxiliar.Properties.NullText = ""
        Me.cboTipoAuxiliar.Size = New System.Drawing.Size(237, 20)
        Me.cboTipoAuxiliar.TabIndex = 9
        '
        'cboTipoCuenta
        '
        Me.cboTipoCuenta.Location = New System.Drawing.Point(72, 170)
        Me.cboTipoCuenta.MenuManager = Me.RibbonControl
        Me.cboTipoCuenta.Name = "cboTipoCuenta"
        Me.cboTipoCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoCuenta.Properties.NullText = ""
        Me.cboTipoCuenta.Size = New System.Drawing.Size(228, 20)
        Me.cboTipoCuenta.TabIndex = 7
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(332, 173)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(96, 13)
        Me.SaimtLabel7.TabIndex = 8
        Me.SaimtLabel7.Text = "Tipo Cuenta Auxiliar"
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(8, 173)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel6.TabIndex = 6
        Me.SaimtLabel6.Text = "Tipo Cuenta"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(75, 196)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(114, 13)
        Me.SaimtLabel5.TabIndex = 10
        Me.SaimtLabel5.Text = "Cuenta donde se Carga"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(276, 39)
        Me.txtAño.MenuManager = Me.RibbonControl
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 3
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(251, 42)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(19, 13)
        Me.SaimtLabel4.TabIndex = 2
        Me.SaimtLabel4.Text = "Año"
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(12, 68)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel3.TabIndex = 4
        Me.SaimtLabel3.Text = "Descripción"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(72, 39)
        Me.txtCuenta.MenuManager = Me.RibbonControl
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(123, 20)
        Me.txtCuenta.TabIndex = 1
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(31, 42)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(35, 13)
        Me.SaimtLabel2.TabIndex = 0
        Me.SaimtLabel2.Text = "Cuenta"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(346, 338)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(136, 338)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(486, 338)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(206, 338)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "Editar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(276, 338)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(416, 338)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.btnExportarExcelPlanCuentas)
        Me.XtraTabPage2.Controls.Add(Me.btnMostrarPlanCuentas)
        Me.XtraTabPage2.Controls.Add(Me.dgvVisorPlanCuenta)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(691, 431)
        Me.XtraTabPage2.Text = "Visor del Plan de Cuentas"
        '
        'btnExportarExcelPlanCuentas
        '
        Me.btnExportarExcelPlanCuentas.Image = CType(resources.GetObject("btnExportarExcelPlanCuentas.Image"), System.Drawing.Image)
        Me.btnExportarExcelPlanCuentas.Location = New System.Drawing.Point(421, 9)
        Me.btnExportarExcelPlanCuentas.Name = "btnExportarExcelPlanCuentas"
        Me.btnExportarExcelPlanCuentas.Size = New System.Drawing.Size(111, 23)
        Me.btnExportarExcelPlanCuentas.TabIndex = 0
        Me.btnExportarExcelPlanCuentas.Text = "Exportar a Excel"
        '
        'btnMostrarPlanCuentas
        '
        Me.btnMostrarPlanCuentas.Image = CType(resources.GetObject("btnMostrarPlanCuentas.Image"), System.Drawing.Image)
        Me.btnMostrarPlanCuentas.Location = New System.Drawing.Point(538, 9)
        Me.btnMostrarPlanCuentas.Name = "btnMostrarPlanCuentas"
        Me.btnMostrarPlanCuentas.Size = New System.Drawing.Size(147, 23)
        Me.btnMostrarPlanCuentas.TabIndex = 1
        Me.btnMostrarPlanCuentas.Text = "Mostrar Plan de Cuentas"
        '
        'dgvVisorPlanCuenta
        '
        Me.dgvVisorPlanCuenta.Location = New System.Drawing.Point(0, 38)
        Me.dgvVisorPlanCuenta.MainView = Me.gvVisorPlanCuenta
        Me.dgvVisorPlanCuenta.MenuManager = Me.RibbonControl
        Me.dgvVisorPlanCuenta.Name = "dgvVisorPlanCuenta"
        Me.dgvVisorPlanCuenta.Size = New System.Drawing.Size(691, 371)
        Me.dgvVisorPlanCuenta.TabIndex = 2
        Me.dgvVisorPlanCuenta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVisorPlanCuenta})
        '
        'gvVisorPlanCuenta
        '
        Me.gvVisorPlanCuenta.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.gvVisorPlanCuenta.GridControl = Me.dgvVisorPlanCuenta
        Me.gvVisorPlanCuenta.Name = "gvVisorPlanCuenta"
        Me.gvVisorPlanCuenta.OptionsBehavior.ReadOnly = True
        Me.gvVisorPlanCuenta.OptionsCustomization.AllowSort = False
        Me.gvVisorPlanCuenta.OptionsPrint.AutoWidth = False
        Me.gvVisorPlanCuenta.OptionsView.ColumnAutoWidth = False
        Me.gvVisorPlanCuenta.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cuenta"
        Me.GridColumn4.FieldName = "planCId"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Año"
        Me.GridColumn5.FieldName = "planCAño"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Descripción"
        Me.GridColumn6.FieldName = "planCDescripcion"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Cuenta Cargo"
        Me.GridColumn7.FieldName = "cargo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Cuenta Abono"
        Me.GridColumn8.FieldName = "abono"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tipo Cuenta"
        Me.GridColumn9.FieldName = "cuenta"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Tipo Cuenta Auxiliar"
        Me.GridColumn10.FieldName = "cuentaAuxiliar"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        '
        'frmPlanCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(968, 461)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.dgvListado = Me.dgvListadoPlanCuentas
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmPlanCuentas"
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeImprimir = True
        Me.Tag = "btiPlanCuentas"
        Me.Text = "PLAN DE CUENTAS"
        Me.txtBuscarSaimt = Me.txtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.cboTipoCuentaCriterio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAñoPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterioPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.dgvListadoPlanCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoPlanCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaAbono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAuxiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.dgvVisorPlanCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVisorPlanCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents txtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvListadoPlanCuentas As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoPlanCuentas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboAñoPor As SaimtControles.SaimtComboBox
    Friend WithEvents cboCriterioPor As SaimtControles.SaimtComboBox
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtCuentaAbono As SaimtControles.SaimtTextBox
    Friend WithEvents txtCuentaCargo As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoAuxiliar As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboTipoCuenta As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtAño As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents txtCuenta As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtDescripcion As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents btnConsultarCuentaAbona As SaimtControles.SaimtButton
    Friend WithEvents btnConsultarCuentaCarga As SaimtControles.SaimtButton
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents SaimtTabs1 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnExportarExcelPlanCuentas As SaimtControles.SaimtButton
    Friend WithEvents btnMostrarPlanCuentas As SaimtControles.SaimtButton
    Friend WithEvents dgvVisorPlanCuenta As SaimtControles.SaimtDataGrid
    Friend WithEvents gvVisorPlanCuenta As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sfdRutaExcelPlanCuenta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cboTipoCuentaCriterio As SaimtControles.SaimtComboBoxLookUp
End Class
