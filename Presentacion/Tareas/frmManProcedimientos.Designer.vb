<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManProcedimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManProcedimientos))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grbLista = New SaimtControles.SaimtGroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.chkProcdActivo = New SaimtControles.SaimtCheckBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.cboSubProceso = New SaimtControles.SaimtComboBoxLookUp()
        Me.txtProcdDescripcion = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtProcdId = New SaimtControles.SaimtTextBox()
        Me.cboProceso = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.TxtProcdNombre = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.txtNroDias = New SaimtControles.SaimtTextBox()
        Me.cboCargo = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.cboArea = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.btnCancelarContrato = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLista.SuspendLayout()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.chkProcdActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSubProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcdDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcdId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtProcdNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.txtNroDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 416)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(807, 27)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grbLista)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SaimtGroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SaimtGroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnImprimir)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancelarContrato)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnEditar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnNuevo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancelar)
        Me.SplitContainer1.Size = New System.Drawing.Size(807, 443)
        Me.SplitContainer1.SplitterDistance = 268
        Me.SplitContainer1.TabIndex = 5
        '
        'grbLista
        '
        Me.grbLista.AutoSize = True
        Me.grbLista.Controls.Add(Me.TreeView1)
        Me.grbLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbLista.Location = New System.Drawing.Point(0, 0)
        Me.grbLista.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbLista.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbLista.Name = "grbLista"
        Me.grbLista.Size = New System.Drawing.Size(268, 443)
        Me.grbLista.TabIndex = 6
        Me.grbLista.Text = "Listado de Procesos"
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(2, 21)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(264, 420)
        Me.TreeView1.TabIndex = 0
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox2.Controls.Add(Me.chkProcdActivo)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox2.Controls.Add(Me.cboSubProceso)
        Me.SaimtGroupBox2.Controls.Add(Me.txtProcdDescripcion)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox2.Controls.Add(Me.txtProcdId)
        Me.SaimtGroupBox2.Controls.Add(Me.cboProceso)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox2.Controls.Add(Me.TxtProcdNombre)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(523, 197)
        Me.SaimtGroupBox2.TabIndex = 54
        Me.SaimtGroupBox2.Text = "Datos del Procedimiento"
        '
        'chkProcdActivo
        '
        Me.chkProcdActivo.Location = New System.Drawing.Point(420, 24)
        Me.chkProcdActivo.MenuManager = Me.RibbonControl
        Me.chkProcdActivo.Name = "chkProcdActivo"
        Me.chkProcdActivo.Properties.AutoWidth = True
        Me.chkProcdActivo.Properties.Caption = "Activo"
        Me.chkProcdActivo.Size = New System.Drawing.Size(52, 19)
        Me.chkProcdActivo.TabIndex = 52
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(277, 61)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(62, 13)
        Me.SaimtLabel6.TabIndex = 46
        Me.SaimtLabel6.Text = "Sub Proceso "
        '
        'cboSubProceso
        '
        Me.cboSubProceso.Location = New System.Drawing.Point(345, 58)
        Me.cboSubProceso.Name = "cboSubProceso"
        Me.cboSubProceso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSubProceso.Properties.NullText = ""
        Me.cboSubProceso.Size = New System.Drawing.Size(127, 20)
        Me.cboSubProceso.TabIndex = 45
        '
        'txtProcdDescripcion
        '
        Me.txtProcdDescripcion.Location = New System.Drawing.Point(114, 114)
        Me.txtProcdDescripcion.Name = "txtProcdDescripcion"
        Me.txtProcdDescripcion.Size = New System.Drawing.Size(358, 69)
        Me.txtProcdDescripcion.TabIndex = 39
        Me.txtProcdDescripcion.UseOptimizedRendering = True
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(10, 36)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(89, 13)
        Me.SaimtLabel8.TabIndex = 31
        Me.SaimtLabel8.Text = "Cod Procedimiento"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(58, 61)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(41, 13)
        Me.SaimtLabel2.TabIndex = 44
        Me.SaimtLabel2.Text = "Proceso "
        '
        'txtProcdId
        '
        Me.txtProcdId.Location = New System.Drawing.Point(114, 32)
        Me.txtProcdId.Name = "txtProcdId"
        Me.txtProcdId.Properties.ReadOnly = True
        Me.txtProcdId.Size = New System.Drawing.Size(127, 20)
        Me.txtProcdId.TabIndex = 32
        '
        'cboProceso
        '
        Me.cboProceso.Location = New System.Drawing.Point(114, 58)
        Me.cboProceso.Name = "cboProceso"
        Me.cboProceso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProceso.Properties.NullText = ""
        Me.cboProceso.Size = New System.Drawing.Size(127, 20)
        Me.cboProceso.TabIndex = 16
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(38, 116)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel10.TabIndex = 38
        Me.SaimtLabel10.Text = "Descripción"
        '
        'TxtProcdNombre
        '
        Me.TxtProcdNombre.Location = New System.Drawing.Point(114, 83)
        Me.TxtProcdNombre.Name = "TxtProcdNombre"
        Me.TxtProcdNombre.Size = New System.Drawing.Size(358, 20)
        Me.TxtProcdNombre.TabIndex = 43
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(32, 86)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel1.TabIndex = 42
        Me.SaimtLabel1.Text = "Procedimiento"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroDias)
        Me.SaimtGroupBox1.Controls.Add(Me.cboCargo)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox1.Controls.Add(Me.cboArea)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(3, 206)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(523, 132)
        Me.SaimtGroupBox1.TabIndex = 53
        Me.SaimtGroupBox1.Text = "Encargados del Procedimiento"
        '
        'txtNroDias
        '
        Me.txtNroDias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNroDias.Location = New System.Drawing.Point(71, 84)
        Me.txtNroDias.Name = "txtNroDias"
        Me.txtNroDias.Size = New System.Drawing.Size(97, 20)
        Me.txtNroDias.TabIndex = 51
        Me.txtNroDias.Tag = "0"
        '
        'cboCargo
        '
        Me.cboCargo.Location = New System.Drawing.Point(71, 57)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCargo.Properties.NullText = ""
        Me.cboCargo.Size = New System.Drawing.Size(358, 20)
        Me.cboCargo.TabIndex = 47
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(20, 87)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(40, 13)
        Me.SaimtLabel5.TabIndex = 50
        Me.SaimtLabel5.Text = "Nro Días"
        '
        'cboArea
        '
        Me.cboArea.Location = New System.Drawing.Point(71, 31)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboArea.Properties.NullText = ""
        Me.cboArea.Size = New System.Drawing.Size(358, 20)
        Me.cboArea.TabIndex = 45
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(34, 34)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(26, 13)
        Me.SaimtLabel3.TabIndex = 46
        Me.SaimtLabel3.Text = "Area "
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(31, 60)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(29, 13)
        Me.SaimtLabel4.TabIndex = 48
        Me.SaimtLabel4.Text = "Cargo"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImprimir.Location = New System.Drawing.Point(337, 344)
        Me.btnImprimir.LookAndFeel.SkinName = "Seven"
        Me.btnImprimir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 64)
        Me.btnImprimir.TabIndex = 35
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCancelarContrato
        '
        Me.btnCancelarContrato.Image = CType(resources.GetObject("btnCancelarContrato.Image"), System.Drawing.Image)
        Me.btnCancelarContrato.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelarContrato.Location = New System.Drawing.Point(407, 344)
        Me.btnCancelarContrato.LookAndFeel.SkinName = "Seven"
        Me.btnCancelarContrato.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelarContrato.Name = "btnCancelarContrato"
        Me.btnCancelarContrato.Size = New System.Drawing.Size(68, 64)
        Me.btnCancelarContrato.TabIndex = 36
        Me.btnCancelarContrato.Text = "Cancelar Contrato"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(126, 344)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 32
        Me.btnEditar.Text = "Editar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(267, 344)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 34
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(56, 344)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 31
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(196, 344)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Text = "Cancelar Edición"
        '
        'frmManProcedimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(807, 443)
        Me.Controls.Add(Me.SplitContainer1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmManProcedimientos"
        Me.Text = "Mantenedor de Procedimientos"
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLista.ResumeLayout(False)
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.chkProcdActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSubProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcdDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcdId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtProcdNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.txtNroDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents btnCancelarContrato As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents grbLista As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtProcdDescripcion As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtProcdId As SaimtControles.SaimtTextBox
    Friend WithEvents cboProceso As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents TxtProcdNombre As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtNroDias As SaimtControles.SaimtTextBox
    Friend WithEvents cboCargo As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents cboArea As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents cboSubProceso As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents chkProcdActivo As SaimtControles.SaimtCheckBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class
