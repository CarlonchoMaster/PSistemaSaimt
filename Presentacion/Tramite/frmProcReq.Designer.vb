<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcReq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcReq))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.lstResultados = New SaimtControles.SaimtListBox()
        Me.TxtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.sRdbBuscarPor = New SaimtControles.SaimtRadioGroup()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.TxtCodReq = New SaimtControles.SaimtTextBox()
        Me.txtCodProc = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.btnRemover = New SaimtControles.SaimtButton()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.dgvReqvsProc = New SaimtControles.SaimtDataGrid()
        Me.gvReqvsProc = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcTgId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.TxtObservacion = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.chkActivo = New SaimtControles.SaimtCheckBox()
        Me.ssNroOrden = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.sbtnRequisito = New SaimtControles.SaimtButton()
        Me.TxtRequisito = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.btnProcedimiento = New SaimtControles.SaimtButton()
        Me.TxtProcedimiento = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.lstResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sRdbBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.TxtCodReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodProc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReqvsProc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReqvsProc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtObservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssNroOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRequisito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 575)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(838, 25)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.lstResultados)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(8, 78)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(264, 491)
        Me.SaimtGroupBox1.TabIndex = 13
        Me.SaimtGroupBox1.Text = "Resultados de Busqueda"
        '
        'lstResultados
        '
        Me.lstResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstResultados.HorizontalScrollbar = True
        Me.lstResultados.Location = New System.Drawing.Point(2, 22)
        Me.lstResultados.Name = "lstResultados"
        Me.lstResultados.Size = New System.Drawing.Size(260, 467)
        Me.lstResultados.TabIndex = 6
        '
        'TxtBuscarPor
        '
        Me.TxtBuscarPor.Location = New System.Drawing.Point(8, 52)
        Me.TxtBuscarPor.Name = "TxtBuscarPor"
        Me.TxtBuscarPor.Size = New System.Drawing.Size(264, 20)
        Me.TxtBuscarPor.TabIndex = 12
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(13, 2)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel4.TabIndex = 11
        Me.SaimtLabel4.Text = "Buscar por :"
        '
        'sRdbBuscarPor
        '
        Me.sRdbBuscarPor.EditValue = CType(1, Short)
        Me.sRdbBuscarPor.Location = New System.Drawing.Point(8, 18)
        Me.sRdbBuscarPor.Name = "sRdbBuscarPor"
        Me.sRdbBuscarPor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sRdbBuscarPor.Properties.Appearance.Options.UseBackColor = True
        Me.sRdbBuscarPor.Properties.Columns = 3
        Me.sRdbBuscarPor.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Nom. Proc."), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Area. Res."), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "Duración")})
        Me.sRdbBuscarPor.Size = New System.Drawing.Size(264, 29)
        Me.sRdbBuscarPor.TabIndex = 10
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox2.Controls.Add(Me.TxtCodReq)
        Me.SaimtGroupBox2.Controls.Add(Me.txtCodProc)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox2.Controls.Add(Me.btnRemover)
        Me.SaimtGroupBox2.Controls.Add(Me.btnAgregar)
        Me.SaimtGroupBox2.Controls.Add(Me.dgvReqvsProc)
        Me.SaimtGroupBox2.Controls.Add(Me.TxtObservacion)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox2.Controls.Add(Me.chkActivo)
        Me.SaimtGroupBox2.Controls.Add(Me.ssNroOrden)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox2.Controls.Add(Me.sbtnRequisito)
        Me.SaimtGroupBox2.Controls.Add(Me.TxtRequisito)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox2.Controls.Add(Me.btnProcedimiento)
        Me.SaimtGroupBox2.Controls.Add(Me.TxtProcedimiento)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(278, 5)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(560, 490)
        Me.SaimtGroupBox2.TabIndex = 14
        Me.SaimtGroupBox2.Text = "Asignación de Requisitos a Procedimientos"
        '
        'TxtCodReq
        '
        Me.TxtCodReq.Location = New System.Drawing.Point(345, 86)
        Me.TxtCodReq.MenuManager = Me.RibbonControl
        Me.TxtCodReq.Name = "TxtCodReq"
        Me.TxtCodReq.Size = New System.Drawing.Size(143, 20)
        Me.TxtCodReq.TabIndex = 48
        '
        'txtCodProc
        '
        Me.txtCodProc.Location = New System.Drawing.Point(106, 86)
        Me.txtCodProc.MenuManager = Me.RibbonControl
        Me.txtCodProc.Name = "txtCodProc"
        Me.txtCodProc.Size = New System.Drawing.Size(143, 20)
        Me.txtCodProc.TabIndex = 47
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(269, 89)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(70, 13)
        Me.SaimtLabel7.TabIndex = 46
        Me.SaimtLabel7.Text = "Cod. Requisito"
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(7, 89)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(93, 13)
        Me.SaimtLabel6.TabIndex = 45
        Me.SaimtLabel6.Text = "Cod. Procedimiento"
        '
        'btnRemover
        '
        Me.btnRemover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemover.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnRemover.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRemover.Location = New System.Drawing.Point(532, 210)
        Me.btnRemover.LookAndFeel.SkinName = "Seven"
        Me.btnRemover.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(25, 23)
        Me.btnRemover.TabIndex = 44
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(501, 211)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 22)
        Me.btnAgregar.TabIndex = 43
        '
        'dgvReqvsProc
        '
        Me.dgvReqvsProc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvReqvsProc.Location = New System.Drawing.Point(2, 237)
        Me.dgvReqvsProc.MainView = Me.gvReqvsProc
        Me.dgvReqvsProc.MenuManager = Me.RibbonControl
        Me.dgvReqvsProc.Name = "dgvReqvsProc"
        Me.dgvReqvsProc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemMemoExEdit1})
        Me.dgvReqvsProc.Size = New System.Drawing.Size(556, 251)
        Me.dgvReqvsProc.TabIndex = 42
        Me.dgvReqvsProc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvReqvsProc})
        '
        'gvReqvsProc
        '
        Me.gvReqvsProc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcTgId, Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.gvReqvsProc.GridControl = Me.dgvReqvsProc
        Me.gvReqvsProc.Name = "gvReqvsProc"
        Me.gvReqvsProc.OptionsView.ColumnAutoWidth = False
        Me.gvReqvsProc.OptionsView.ShowGroupPanel = False
        '
        'gcTgId
        '
        Me.gcTgId.Caption = "tgId"
        Me.gcTgId.FieldName = "tgId"
        Me.gcTgId.Name = "gcTgId"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Proc."
        Me.GridColumn1.FieldName = "procId"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cod. Req."
        Me.GridColumn3.FieldName = "reqId"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Requisito"
        Me.GridColumn4.FieldName = "requisito"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Nro. Orden"
        Me.GridColumn5.FieldName = "nOrden"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Es Obligatorio"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn6.FieldName = "tgActivo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Observación"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn7.FieldName = "tgDescripcion"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Location = New System.Drawing.Point(80, 145)
        Me.TxtObservacion.MenuManager = Me.RibbonControl
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(452, 59)
        Me.TxtObservacion.TabIndex = 41
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(14, 147)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(60, 13)
        Me.SaimtLabel5.TabIndex = 40
        Me.SaimtLabel5.Text = "Observación"
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(197, 115)
        Me.chkActivo.MenuManager = Me.RibbonControl
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.AutoWidth = True
        Me.chkActivo.Properties.Caption = "Check si el requisito es obligatorio para el procedimiento."
        Me.chkActivo.Size = New System.Drawing.Size(294, 19)
        Me.chkActivo.TabIndex = 39
        '
        'ssNroOrden
        '
        Me.ssNroOrden.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ssNroOrden.Location = New System.Drawing.Point(80, 115)
        Me.ssNroOrden.MenuManager = Me.RibbonControl
        Me.ssNroOrden.Name = "ssNroOrden"
        Me.ssNroOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ssNroOrden.Properties.Mask.EditMask = "n0"
        Me.ssNroOrden.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.ssNroOrden.Size = New System.Drawing.Size(82, 20)
        Me.ssNroOrden.TabIndex = 38
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(20, 118)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel3.TabIndex = 37
        Me.SaimtLabel3.Text = "Nro. Orden"
        '
        'sbtnRequisito
        '
        Me.sbtnRequisito.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.sbtnRequisito.Location = New System.Drawing.Point(505, 56)
        Me.sbtnRequisito.Name = "sbtnRequisito"
        Me.sbtnRequisito.Size = New System.Drawing.Size(24, 22)
        Me.sbtnRequisito.TabIndex = 36
        '
        'TxtRequisito
        '
        Me.TxtRequisito.Location = New System.Drawing.Point(80, 58)
        Me.TxtRequisito.MenuManager = Me.RibbonControl
        Me.TxtRequisito.Name = "TxtRequisito"
        Me.TxtRequisito.Size = New System.Drawing.Size(420, 20)
        Me.TxtRequisito.TabIndex = 35
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(30, 61)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(44, 13)
        Me.SaimtLabel2.TabIndex = 34
        Me.SaimtLabel2.Text = "Requisito"
        '
        'btnProcedimiento
        '
        Me.btnProcedimiento.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnProcedimiento.Location = New System.Drawing.Point(505, 27)
        Me.btnProcedimiento.Name = "btnProcedimiento"
        Me.btnProcedimiento.Size = New System.Drawing.Size(24, 22)
        Me.btnProcedimiento.TabIndex = 33
        '
        'TxtProcedimiento
        '
        Me.TxtProcedimiento.Location = New System.Drawing.Point(80, 29)
        Me.TxtProcedimiento.MenuManager = Me.RibbonControl
        Me.TxtProcedimiento.Name = "TxtProcedimiento"
        Me.TxtProcedimiento.Size = New System.Drawing.Size(420, 20)
        Me.TxtProcedimiento.TabIndex = 1
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(7, 32)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Procedimiento"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(420, 501)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 43
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(560, 501)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 45
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(350, 501)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 42
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(490, 501)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 44
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(280, 501)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 41
        Me.btnEditar.Text = "Editar"
        '
        'frmProcReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ClientSize = New System.Drawing.Size(838, 600)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.TxtBuscarPor)
        Me.Controls.Add(Me.SaimtLabel4)
        Me.Controls.Add(Me.sRdbBuscarPor)
        Me.LookAndFeel.SkinName = "Seven"
        Me.lstListado = Me.lstResultados
        Me.Name = "frmProcReq"
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeEliminar = True
        Me.Text = "Vinculación Procedimiento con Requerimiento"
        Me.txtBuscarSaimt = Me.TxtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.sRdbBuscarPor, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel4, 0)
        Me.Controls.SetChildIndex(Me.TxtBuscarPor, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.lstResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sRdbBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.TxtCodReq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodProc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReqvsProc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReqvsProc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtObservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssNroOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRequisito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents lstResultados As SaimtControles.SaimtListBox
    Friend WithEvents TxtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents sRdbBuscarPor As SaimtControles.SaimtRadioGroup
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents TxtProcedimiento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents dgvReqvsProc As SaimtControles.SaimtDataGrid
    Friend WithEvents gvReqvsProc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtObservacion As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents chkActivo As SaimtControles.SaimtCheckBox
    Friend WithEvents ssNroOrden As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents sbtnRequisito As SaimtControles.SaimtButton
    Friend WithEvents TxtRequisito As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents btnProcedimiento As SaimtControles.SaimtButton
    Friend WithEvents btnRemover As SaimtControles.SaimtButton
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents TxtCodReq As SaimtControles.SaimtTextBox
    Friend WithEvents txtCodProc As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents gcTgId As DevExpress.XtraGrid.Columns.GridColumn
End Class
