<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTablaGeneral
    Inherits Presentacion.frmMantenimientos

    'Form invalida a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTablaGeneral))
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.grbDatosPersonales = New SaimtControles.SaimtGroupBox()
        Me.chkActivarClaseExtra = New SaimtControles.SaimtCheckBox()
        Me.cboUClaseExtra = New SaimtControles.SaimtComboBoxLookUpUpdate()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.dgvTablaGeneral = New SaimtControles.SaimtDataGrid()
        Me.gvTablaGeneral = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTgId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgExtra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgAbrev = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtraId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnQuitar = New SaimtControles.SaimtButton()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.cboUClase = New SaimtControles.SaimtComboBoxLookUpUpdate()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.chkEstado = New SaimtControles.SaimtCheckBox()
        Me.txtDescripcion = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.txtNombre = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.txtExtra = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtCodigo = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtAbreviatura = New SaimtControles.SaimtTextBox()
        Me.grbLista = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoTablaGeneral = New SaimtControles.SaimtDataGrid()
        Me.gvListadoTablaGeneral = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosPersonales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosPersonales.SuspendLayout()
        CType(Me.chkActivarClaseExtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTablaGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTablaGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLista.SuspendLayout()
        CType(Me.dgvListadoTablaGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoTablaGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 429)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1107, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(334, 353)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(474, 353)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(264, 353)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(404, 353)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(194, 353)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        '
        'grbDatosPersonales
        '
        Me.grbDatosPersonales.Controls.Add(Me.chkActivarClaseExtra)
        Me.grbDatosPersonales.Controls.Add(Me.cboUClaseExtra)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel9)
        Me.grbDatosPersonales.Controls.Add(Me.dgvTablaGeneral)
        Me.grbDatosPersonales.Controls.Add(Me.btnQuitar)
        Me.grbDatosPersonales.Controls.Add(Me.btnAgregar)
        Me.grbDatosPersonales.Controls.Add(Me.cboUClase)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel8)
        Me.grbDatosPersonales.Controls.Add(Me.chkEstado)
        Me.grbDatosPersonales.Controls.Add(Me.txtDescripcion)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel6)
        Me.grbDatosPersonales.Controls.Add(Me.txtNombre)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel7)
        Me.grbDatosPersonales.Controls.Add(Me.txtExtra)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel3)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel2)
        Me.grbDatosPersonales.Controls.Add(Me.txtCodigo)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel4)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel5)
        Me.grbDatosPersonales.Controls.Add(Me.txtAbreviatura)
        Me.grbDatosPersonales.Location = New System.Drawing.Point(6, 6)
        Me.grbDatosPersonales.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbDatosPersonales.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbDatosPersonales.Name = "grbDatosPersonales"
        Me.grbDatosPersonales.Size = New System.Drawing.Size(776, 335)
        Me.grbDatosPersonales.TabIndex = 2
        Me.grbDatosPersonales.Text = "Datos "
        '
        'chkActivarClaseExtra
        '
        Me.chkActivarClaseExtra.Location = New System.Drawing.Point(755, 30)
        Me.chkActivarClaseExtra.MenuManager = Me.RibbonControl
        Me.chkActivarClaseExtra.Name = "chkActivarClaseExtra"
        Me.chkActivarClaseExtra.Properties.AutoWidth = True
        Me.chkActivarClaseExtra.Properties.Caption = ""
        Me.chkActivarClaseExtra.Size = New System.Drawing.Size(23, 19)
        Me.chkActivarClaseExtra.TabIndex = 19
        '
        'cboUClaseExtra
        '
        Me.cboUClaseExtra.Entidad = SaimtControles.SaimtComboBoxLookUpUpdate.Entidades.Clase
        Me.cboUClaseExtra.Location = New System.Drawing.Point(574, 30)
        Me.cboUClaseExtra.MinimumSize = New System.Drawing.Size(100, 20)
        Me.cboUClaseExtra.Name = "cboUClaseExtra"
        Me.cboUClaseExtra.Size = New System.Drawing.Size(179, 21)
        Me.cboUClaseExtra.TabIndex = 18
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(506, 34)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(62, 13)
        Me.SaimtLabel9.TabIndex = 17
        Me.SaimtLabel9.Text = "Clase Extra :"
        '
        'dgvTablaGeneral
        '
        Me.dgvTablaGeneral.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvTablaGeneral.Location = New System.Drawing.Point(2, 133)
        Me.dgvTablaGeneral.MainView = Me.gvTablaGeneral
        Me.dgvTablaGeneral.MenuManager = Me.RibbonControl
        Me.dgvTablaGeneral.Name = "dgvTablaGeneral"
        Me.dgvTablaGeneral.Size = New System.Drawing.Size(772, 200)
        Me.dgvTablaGeneral.TabIndex = 16
        Me.dgvTablaGeneral.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTablaGeneral})
        '
        'gvTablaGeneral
        '
        Me.gvTablaGeneral.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTgId, Me.colClsId, Me.colTgNombre, Me.colTgCodigo, Me.colTgExtra, Me.colTgAbrev, Me.colTgDescripcion, Me.colTgActivo, Me.colExtraId})
        Me.gvTablaGeneral.GridControl = Me.dgvTablaGeneral
        Me.gvTablaGeneral.Name = "gvTablaGeneral"
        Me.gvTablaGeneral.OptionsBehavior.ReadOnly = True
        Me.gvTablaGeneral.OptionsView.ColumnAutoWidth = False
        Me.gvTablaGeneral.OptionsView.ShowGroupPanel = False
        '
        'colTgId
        '
        Me.colTgId.Caption = "tgId"
        Me.colTgId.FieldName = "tgId"
        Me.colTgId.Name = "colTgId"
        '
        'colClsId
        '
        Me.colClsId.Caption = "clsId"
        Me.colClsId.FieldName = "clsId"
        Me.colClsId.Name = "colClsId"
        '
        'colTgNombre
        '
        Me.colTgNombre.Caption = "Nombre"
        Me.colTgNombre.FieldName = "tgNombre"
        Me.colTgNombre.Name = "colTgNombre"
        Me.colTgNombre.Visible = True
        Me.colTgNombre.VisibleIndex = 0
        '
        'colTgCodigo
        '
        Me.colTgCodigo.Caption = "Codigo"
        Me.colTgCodigo.FieldName = "tgCodigo"
        Me.colTgCodigo.Name = "colTgCodigo"
        Me.colTgCodigo.Visible = True
        Me.colTgCodigo.VisibleIndex = 1
        '
        'colTgExtra
        '
        Me.colTgExtra.Caption = "Extra"
        Me.colTgExtra.FieldName = "tgExtra"
        Me.colTgExtra.Name = "colTgExtra"
        Me.colTgExtra.Visible = True
        Me.colTgExtra.VisibleIndex = 2
        '
        'colTgAbrev
        '
        Me.colTgAbrev.Caption = "Abreviatura"
        Me.colTgAbrev.FieldName = "tgAbrev"
        Me.colTgAbrev.Name = "colTgAbrev"
        Me.colTgAbrev.Visible = True
        Me.colTgAbrev.VisibleIndex = 3
        '
        'colTgDescripcion
        '
        Me.colTgDescripcion.Caption = "Descripción"
        Me.colTgDescripcion.FieldName = "tgDescripcion"
        Me.colTgDescripcion.Name = "colTgDescripcion"
        Me.colTgDescripcion.Visible = True
        Me.colTgDescripcion.VisibleIndex = 4
        '
        'colTgActivo
        '
        Me.colTgActivo.Caption = "Activo"
        Me.colTgActivo.FieldName = "tgActivo"
        Me.colTgActivo.Name = "colTgActivo"
        Me.colTgActivo.Visible = True
        Me.colTgActivo.VisibleIndex = 5
        '
        'colExtraId
        '
        Me.colExtraId.Caption = "clsExtraId"
        Me.colExtraId.FieldName = "clsExtraId"
        Me.colExtraId.Name = "colExtraId"
        Me.colExtraId.Visible = True
        Me.colExtraId.VisibleIndex = 6
        '
        'btnQuitar
        '
        Me.btnQuitar.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnQuitar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuitar.Location = New System.Drawing.Point(612, 103)
        Me.btnQuitar.LookAndFeel.SkinName = "Seven"
        Me.btnQuitar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(25, 18)
        Me.btnQuitar.TabIndex = 15
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(581, 103)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 18)
        Me.btnAgregar.TabIndex = 14
        '
        'cboUClase
        '
        Me.cboUClase.Entidad = SaimtControles.SaimtComboBoxLookUpUpdate.Entidades.Clase
        Me.cboUClase.Location = New System.Drawing.Point(79, 30)
        Me.cboUClase.MinimumSize = New System.Drawing.Size(100, 20)
        Me.cboUClase.Name = "cboUClase"
        Me.cboUClase.Size = New System.Drawing.Size(179, 21)
        Me.cboUClase.TabIndex = 1
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(450, 60)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(40, 13)
        Me.SaimtLabel8.TabIndex = 10
        Me.SaimtLabel8.Text = "Estado :"
        '
        'chkEstado
        '
        Me.chkEstado.EditValue = True
        Me.chkEstado.Location = New System.Drawing.Point(496, 58)
        Me.chkEstado.MenuManager = Me.RibbonControl
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.AutoWidth = True
        Me.chkEstado.Properties.Caption = "Activo"
        Me.chkEstado.Size = New System.Drawing.Size(53, 19)
        Me.chkEstado.TabIndex = 11
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(79, 83)
        Me.txtDescripcion.MenuManager = Me.RibbonControl
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(489, 36)
        Me.txtDescripcion.TabIndex = 13
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(264, 34)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(44, 13)
        Me.SaimtLabel6.TabIndex = 2
        Me.SaimtLabel6.Text = "Nombre :"
        '
        'txtNombre
        '
        Me.txtNombre.EditValue = ""
        Me.txtNombre.Location = New System.Drawing.Point(314, 31)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(186, 20)
        Me.txtNombre.TabIndex = 3
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(332, 60)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(33, 13)
        Me.SaimtLabel7.TabIndex = 8
        Me.SaimtLabel7.Text = "Extra :"
        '
        'txtExtra
        '
        Me.txtExtra.EditValue = ""
        Me.txtExtra.Location = New System.Drawing.Point(371, 57)
        Me.txtExtra.Name = "txtExtra"
        Me.txtExtra.Size = New System.Drawing.Size(73, 20)
        Me.txtExtra.TabIndex = 9
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(40, 34)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(33, 13)
        Me.SaimtLabel3.TabIndex = 0
        Me.SaimtLabel3.Text = "Clase :"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(33, 60)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(40, 13)
        Me.SaimtLabel2.TabIndex = 4
        Me.SaimtLabel2.Text = "Codigo :"
        '
        'txtCodigo
        '
        Me.txtCodigo.EditValue = ""
        Me.txtCodigo.Location = New System.Drawing.Point(79, 57)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(68, 20)
        Me.txtCodigo.TabIndex = 5
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(156, 60)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(64, 13)
        Me.SaimtLabel4.TabIndex = 6
        Me.SaimtLabel4.Text = "Abreviatura :"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(12, 84)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(61, 13)
        Me.SaimtLabel5.TabIndex = 12
        Me.SaimtLabel5.Text = "Descripcion :"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.EditValue = ""
        Me.txtAbreviatura.Location = New System.Drawing.Point(226, 57)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(100, 20)
        Me.txtAbreviatura.TabIndex = 7
        '
        'grbLista
        '
        Me.grbLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbLista.Controls.Add(Me.dgvListadoTablaGeneral)
        Me.grbLista.Location = New System.Drawing.Point(7, 47)
        Me.grbLista.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbLista.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbLista.Name = "grbLista"
        Me.grbLista.Size = New System.Drawing.Size(303, 376)
        Me.grbLista.TabIndex = 3
        Me.grbLista.Text = "Resultado de Busqueda"
        '
        'dgvListadoTablaGeneral
        '
        Me.dgvListadoTablaGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoTablaGeneral.Location = New System.Drawing.Point(2, 22)
        Me.dgvListadoTablaGeneral.MainView = Me.gvListadoTablaGeneral
        Me.dgvListadoTablaGeneral.MenuManager = Me.RibbonControl
        Me.dgvListadoTablaGeneral.Name = "dgvListadoTablaGeneral"
        Me.dgvListadoTablaGeneral.Size = New System.Drawing.Size(299, 352)
        Me.dgvListadoTablaGeneral.TabIndex = 0
        Me.dgvListadoTablaGeneral.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoTablaGeneral})
        '
        'gvListadoTablaGeneral
        '
        Me.gvListadoTablaGeneral.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn2, Me.GridColumn6})
        Me.gvListadoTablaGeneral.GridControl = Me.dgvListadoTablaGeneral
        Me.gvListadoTablaGeneral.Name = "gvListadoTablaGeneral"
        Me.gvListadoTablaGeneral.OptionsBehavior.ReadOnly = True
        Me.gvListadoTablaGeneral.OptionsFind.AlwaysVisible = True
        Me.gvListadoTablaGeneral.OptionsView.ColumnAutoWidth = False
        Me.gvListadoTablaGeneral.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cód. Clase"
        Me.GridColumn3.FieldName = "clsId"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre"
        Me.GridColumn2.FieldName = "clsNombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Descripción"
        Me.GridColumn6.FieldName = "clsDescripcion"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(6, 4)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(65, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Buscar Clase:"
        '
        'txtBuscarPor
        '
        Me.txtBuscarPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPor.Location = New System.Drawing.Point(6, 21)
        Me.txtBuscarPor.MenuManager = Me.RibbonControl
        Me.txtBuscarPor.Name = "txtBuscarPor"
        Me.txtBuscarPor.Size = New System.Drawing.Size(304, 20)
        Me.txtBuscarPor.TabIndex = 1
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.grbLista)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.grbDatosPersonales)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnCancelar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEditar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEliminar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnLimpiar)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(1107, 429)
        Me.SaimtSplitContainerControl1.SplitterPosition = 314
        Me.SaimtSplitContainerControl1.TabIndex = 9
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'frmTablaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ClientSize = New System.Drawing.Size(1107, 456)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.dgvListado = Me.dgvListadoTablaGeneral
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmTablaGeneral"
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeImprimir = True
        Me.Tag = "btiTablaGeneral"
        Me.Text = "TABLA GENERAL"
        Me.txtBuscarSaimt = Me.txtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosPersonales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosPersonales.ResumeLayout(False)
        Me.grbDatosPersonales.PerformLayout()
        CType(Me.chkActivarClaseExtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTablaGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTablaGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLista.ResumeLayout(False)
        CType(Me.dgvListadoTablaGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoTablaGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents grbDatosPersonales As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtAbreviatura As SaimtControles.SaimtTextBox
    Friend WithEvents grbLista As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents txtNombre As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents txtExtra As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtCodigo As SaimtControles.SaimtTextBox
    Friend WithEvents txtDescripcion As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents chkEstado As SaimtControles.SaimtCheckBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents cboUClase As SaimtControles.SaimtComboBoxLookUpUpdate
    Friend WithEvents dgvTablaGeneral As SaimtControles.SaimtDataGrid
    Friend WithEvents gvTablaGeneral As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnQuitar As SaimtControles.SaimtButton
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
    Friend WithEvents colTgId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgExtra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgAbrev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtraId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboUClaseExtra As SaimtControles.SaimtComboBoxLookUpUpdate
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents chkActivarClaseExtra As SaimtControles.SaimtCheckBox
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents dgvListadoTablaGeneral As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoTablaGeneral As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
