<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaChicaConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajaChicaConfiguracion))
        Me.grbListaClase = New SaimtControles.SaimtGroupBox()
        Me.dgvCajaChicaConfiguracion = New SaimtControles.SaimtDataGrid()
        Me.gvListado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BackstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewTabItem2 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.txtccConfMinPorCierre = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtccConfMaxFondoTotal = New SaimtControles.SaimtTextBox()
        Me.txtccConfMaxCajasxAnio = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.cboTgAñoId = New SaimtControles.SaimtComboBoxLookUp()
        Me.chkActivar = New SaimtControles.SaimtCheckBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.cboTgAreaId = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtccConfId = New SaimtControles.SaimtTextBox()
        Me.BackstageViewItemSeparator2 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem4 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator3 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem3 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator4 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.BackstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.SaimtButton1 = New SaimtControles.SaimtButton()
        Me.cboCriterioArea = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCriterioAño = New SaimtControles.SaimtComboBoxLookUp()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbListaClase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbListaClase.SuspendLayout()
        CType(Me.dgvCajaChicaConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.txtccConfMinPorCierre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtccConfMaxFondoTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtccConfMaxCajasxAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTgAñoId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTgAreaId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtccConfId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.cboCriterioArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterioAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 300)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(927, 27)
        '
        'grbListaClase
        '
        Me.grbListaClase.Controls.Add(Me.dgvCajaChicaConfiguracion)
        Me.grbListaClase.Location = New System.Drawing.Point(5, 55)
        Me.grbListaClase.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbListaClase.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbListaClase.Name = "grbListaClase"
        Me.grbListaClase.Size = New System.Drawing.Size(316, 239)
        Me.grbListaClase.TabIndex = 4
        Me.grbListaClase.Text = "Resultados de Busqueda"
        '
        'dgvCajaChicaConfiguracion
        '
        Me.dgvCajaChicaConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCajaChicaConfiguracion.Location = New System.Drawing.Point(2, 22)
        Me.dgvCajaChicaConfiguracion.MainView = Me.gvListado
        Me.dgvCajaChicaConfiguracion.MenuManager = Me.RibbonControl
        Me.dgvCajaChicaConfiguracion.Name = "dgvCajaChicaConfiguracion"
        Me.dgvCajaChicaConfiguracion.Size = New System.Drawing.Size(312, 215)
        Me.dgvCajaChicaConfiguracion.TabIndex = 0
        Me.dgvCajaChicaConfiguracion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListado})
        '
        'gvListado
        '
        Me.gvListado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn3, Me.GridColumn8, Me.GridColumn9})
        Me.gvListado.GridControl = Me.dgvCajaChicaConfiguracion
        Me.gvListado.Name = "gvListado"
        Me.gvListado.OptionsBehavior.Editable = False
        Me.gvListado.OptionsBehavior.ReadOnly = True
        Me.gvListado.OptionsCustomization.AllowSort = False
        Me.gvListado.OptionsView.ColumnAutoWidth = False
        Me.gvListado.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Codigo Conf."
        Me.GridColumn1.FieldName = "CcConfId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Area"
        Me.GridColumn2.FieldName = "TgAreaId"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Max. de Cajas x Año"
        Me.GridColumn4.FieldName = "CcConfMaxCajasxAnio"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 132
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Max. Fondo Total"
        Me.GridColumn5.FieldName = "CcConfMaxFondoTotal"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Conf. Activo"
        Me.GridColumn6.FieldName = "CcConfActivo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Conf. Año"
        Me.GridColumn7.FieldName = "ccConfAnio"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Porcentaje de Cierre"
        Me.GridColumn3.FieldName = "ccConfMinPorCierre"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "CcConfInicioNroDoc"
        Me.GridColumn8.FieldName = "CcConfInicioNroDoc"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 153
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "CcConfInicioNroDoc"
        Me.GridColumn9.FieldName = "CcConfInicioSerieDoc"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 188
        '
        'BackstageViewTabItem1
        '
        Me.BackstageViewTabItem1.Caption = "BackstageViewTabItem1"
        Me.BackstageViewTabItem1.Name = "BackstageViewTabItem1"
        Me.BackstageViewTabItem1.Selected = False
        '
        'BackstageViewTabItem2
        '
        Me.BackstageViewTabItem2.Caption = "BackstageViewTabItem2"
        Me.BackstageViewTabItem2.Name = "BackstageViewTabItem2"
        Me.BackstageViewTabItem2.Selected = False
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox1.Controls.Add(Me.txtccConfMinPorCierre)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Controls.Add(Me.txtccConfMaxFondoTotal)
        Me.SaimtGroupBox1.Controls.Add(Me.txtccConfMaxCajasxAnio)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox1.Controls.Add(Me.cboTgAñoId)
        Me.SaimtGroupBox1.Controls.Add(Me.chkActivar)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox1.Controls.Add(Me.cboTgAreaId)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Controls.Add(Me.txtccConfId)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(2, 4)
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(588, 208)
        Me.SaimtGroupBox1.TabIndex = 1
        Me.SaimtGroupBox1.Text = "Datos de Configuración Caja Chica"
        '
        'txtccConfMinPorCierre
        '
        Me.txtccConfMinPorCierre.EditValue = New Decimal(New Integer() {80, 0, 0, 0})
        Me.txtccConfMinPorCierre.Location = New System.Drawing.Point(136, 81)
        Me.txtccConfMinPorCierre.MenuManager = Me.RibbonControl
        Me.txtccConfMinPorCierre.Name = "txtccConfMinPorCierre"
        Me.txtccConfMinPorCierre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtccConfMinPorCierre.Properties.Mask.EditMask = "n0"
        Me.txtccConfMinPorCierre.Size = New System.Drawing.Size(124, 20)
        Me.txtccConfMinPorCierre.TabIndex = 41
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(5, 84)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(125, 13)
        Me.SaimtLabel1.TabIndex = 40
        Me.SaimtLabel1.Text = "Porcentaje Min de Cierre :"
        '
        'txtccConfMaxFondoTotal
        '
        Me.txtccConfMaxFondoTotal.EditValue = "0"
        Me.txtccConfMaxFondoTotal.Location = New System.Drawing.Point(136, 107)
        Me.txtccConfMaxFondoTotal.MenuManager = Me.RibbonControl
        Me.txtccConfMaxFondoTotal.Name = "txtccConfMaxFondoTotal"
        Me.txtccConfMaxFondoTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtccConfMaxFondoTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtccConfMaxFondoTotal.Properties.Mask.EditMask = "n2"
        Me.txtccConfMaxFondoTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtccConfMaxFondoTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtccConfMaxFondoTotal.Size = New System.Drawing.Size(103, 20)
        Me.txtccConfMaxFondoTotal.TabIndex = 39
        '
        'txtccConfMaxCajasxAnio
        '
        Me.txtccConfMaxCajasxAnio.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtccConfMaxCajasxAnio.Location = New System.Drawing.Point(136, 55)
        Me.txtccConfMaxCajasxAnio.MenuManager = Me.RibbonControl
        Me.txtccConfMaxCajasxAnio.Name = "txtccConfMaxCajasxAnio"
        Me.txtccConfMaxCajasxAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtccConfMaxCajasxAnio.Properties.Mask.EditMask = "n0"
        Me.txtccConfMaxCajasxAnio.Size = New System.Drawing.Size(124, 20)
        Me.txtccConfMaxCajasxAnio.TabIndex = 38
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(322, 31)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(26, 13)
        Me.SaimtLabel5.TabIndex = 23
        Me.SaimtLabel5.Text = "Año :"
        '
        'cboTgAñoId
        '
        Me.cboTgAñoId.Location = New System.Drawing.Point(354, 28)
        Me.cboTgAñoId.MenuManager = Me.RibbonControl
        Me.cboTgAñoId.Name = "cboTgAñoId"
        Me.cboTgAñoId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTgAñoId.Properties.NullText = ""
        Me.cboTgAñoId.Size = New System.Drawing.Size(124, 20)
        Me.cboTgAñoId.TabIndex = 22
        '
        'chkActivar
        '
        Me.chkActivar.Location = New System.Drawing.Point(351, 107)
        Me.chkActivar.MenuManager = Me.RibbonControl
        Me.chkActivar.Name = "chkActivar"
        Me.chkActivar.Properties.AutoWidth = True
        Me.chkActivar.Properties.Caption = "Activar"
        Me.chkActivar.Size = New System.Drawing.Size(57, 19)
        Me.chkActivar.TabIndex = 21
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(42, 58)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(88, 13)
        Me.SaimtLabel7.TabIndex = 11
        Me.SaimtLabel7.Text = "Max Cajas x Año :"
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(9, 110)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(121, 13)
        Me.SaimtLabel6.TabIndex = 9
        Me.SaimtLabel6.Text = "Max Fondo Total x Caja :"
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(279, 58)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel4.TabIndex = 5
        Me.SaimtLabel4.Text = "Dependencia :"
        '
        'cboTgAreaId
        '
        Me.cboTgAreaId.Location = New System.Drawing.Point(354, 55)
        Me.cboTgAreaId.MenuManager = Me.RibbonControl
        Me.cboTgAreaId.Name = "cboTgAreaId"
        Me.cboTgAreaId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTgAreaId.Properties.NullText = ""
        Me.cboTgAreaId.Size = New System.Drawing.Size(225, 20)
        Me.cboTgAreaId.TabIndex = 4
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(56, 31)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(74, 13)
        Me.SaimtLabel2.TabIndex = 1
        Me.SaimtLabel2.Text = "Codigo Config :"
        '
        'txtccConfId
        '
        Me.txtccConfId.Location = New System.Drawing.Point(136, 28)
        Me.txtccConfId.MenuManager = Me.RibbonControl
        Me.txtccConfId.Name = "txtccConfId"
        Me.txtccConfId.Size = New System.Drawing.Size(124, 20)
        Me.txtccConfId.TabIndex = 0
        '
        'BackstageViewItemSeparator2
        '
        Me.BackstageViewItemSeparator2.Name = "BackstageViewItemSeparator2"
        '
        'BackstageViewTabItem4
        '
        Me.BackstageViewTabItem4.Caption = "Productos"
        Me.BackstageViewTabItem4.Glyph = CType(resources.GetObject("BackstageViewTabItem4.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem4.Name = "BackstageViewTabItem4"
        Me.BackstageViewTabItem4.Selected = False
        '
        'BackstageViewItemSeparator3
        '
        Me.BackstageViewItemSeparator3.Name = "BackstageViewItemSeparator3"
        '
        'BackstageViewTabItem3
        '
        Me.BackstageViewTabItem3.Caption = "Procesos"
        Me.BackstageViewTabItem3.Glyph = CType(resources.GetObject("BackstageViewTabItem3.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem3.Name = "BackstageViewTabItem3"
        Me.BackstageViewTabItem3.Selected = False
        '
        'BackstageViewItemSeparator4
        '
        Me.BackstageViewItemSeparator4.Name = "BackstageViewItemSeparator4"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(105, 218)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(315, 218)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(245, 218)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(385, 218)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(175, 218)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Editar"
        '
        'BackstageViewItemSeparator1
        '
        Me.BackstageViewItemSeparator1.Name = "BackstageViewItemSeparator1"
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtGroupBox2)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnNuevo)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnCancelar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnLimpiar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEditar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(927, 300)
        Me.SaimtSplitContainerControl1.SplitterPosition = 329
        Me.SaimtSplitContainerControl1.TabIndex = 0
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtButton1)
        Me.SaimtGroupBox2.Controls.Add(Me.cboCriterioArea)
        Me.SaimtGroupBox2.Controls.Add(Me.grbListaClase)
        Me.SaimtGroupBox2.Controls.Add(Me.cboCriterioAño)
        Me.SaimtGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(329, 300)
        Me.SaimtGroupBox2.TabIndex = 7
        Me.SaimtGroupBox2.Text = "Buscar Por Area y Año"
        '
        'SaimtButton1
        '
        Me.SaimtButton1.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.SaimtButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SaimtButton1.Location = New System.Drawing.Point(253, 28)
        Me.SaimtButton1.Name = "SaimtButton1"
        Me.SaimtButton1.Size = New System.Drawing.Size(21, 21)
        Me.SaimtButton1.TabIndex = 33
        Me.SaimtButton1.Tag = "NotClear"
        '
        'cboCriterioArea
        '
        Me.cboCriterioArea.Location = New System.Drawing.Point(5, 29)
        Me.cboCriterioArea.MenuManager = Me.RibbonControl
        Me.cboCriterioArea.Name = "cboCriterioArea"
        Me.cboCriterioArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioArea.Properties.NullText = ""
        Me.cboCriterioArea.Size = New System.Drawing.Size(162, 20)
        Me.cboCriterioArea.TabIndex = 5
        Me.cboCriterioArea.Tag = "NotClear"
        '
        'cboCriterioAño
        '
        Me.cboCriterioAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCriterioAño.Location = New System.Drawing.Point(171, 29)
        Me.cboCriterioAño.MenuManager = Me.RibbonControl
        Me.cboCriterioAño.Name = "cboCriterioAño"
        Me.cboCriterioAño.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioAño.Properties.NullText = ""
        Me.cboCriterioAño.Size = New System.Drawing.Size(76, 20)
        Me.cboCriterioAño.TabIndex = 6
        Me.cboCriterioAño.Tag = "NotClear"
        '
        'frmCajaChicaConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(927, 327)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmCajaChicaConfiguracion"
        Me.Tag = "btiOrdenCompra"
        Me.Text = "Configuración de Caja Chica"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbListaClase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbListaClase.ResumeLayout(False)
        CType(Me.dgvCajaChicaConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.txtccConfMinPorCierre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtccConfMaxFondoTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtccConfMaxCajasxAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTgAñoId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTgAreaId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtccConfId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        CType(Me.cboCriterioArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterioAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbListaClase As SaimtControles.SaimtGroupBox
    Friend WithEvents BackstageViewTabItem1 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewTabItem2 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents BackstageViewItemSeparator2 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem4 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator3 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents BackstageViewTabItem3 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator4 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents dgvCajaChicaConfiguracion As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents cboTgAreaId As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtccConfId As SaimtControles.SaimtTextBox
    Friend WithEvents chkActivar As SaimtControles.SaimtCheckBox
    Friend WithEvents cboCriterioArea As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboCriterioAño As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents cboTgAñoId As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtccConfMaxCajasxAnio As SaimtControles.SaimtSpinner
    Friend WithEvents txtccConfMaxFondoTotal As SaimtControles.SaimtTextBox
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtccConfMinPorCierre As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtButton1 As SaimtControles.SaimtButton
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
End Class
