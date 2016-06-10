<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtapas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtapas))
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.cboArea = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.txtCodigoEtapa = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.btnConsultarInstitucion = New SaimtControles.SaimtButton()
        Me.chkFinProcedimiento = New SaimtControles.SaimtCheckBox()
        Me.txtObservaciones = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtNombre = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.spnNumero = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.spnHoras = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.btnConsultarProcedimiento = New SaimtControles.SaimtButton()
        Me.txtProcedimiento = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.spnDuracion = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtInstitucion = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.lstEtapas = New SaimtControles.SaimtListBox()
        Me.txtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.rdbCriterios = New SaimtControles.SaimtRadioGroup()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.cboArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoEtapa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFinProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHoras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnDuracion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.lstEtapas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbCriterios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 551)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(824, 27)
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(406, 472)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(616, 472)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(336, 472)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(476, 472)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(686, 472)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(546, 472)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.cboArea)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox2.Controls.Add(Me.txtCodigoEtapa)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel9)
        Me.SaimtGroupBox2.Controls.Add(Me.btnConsultarInstitucion)
        Me.SaimtGroupBox2.Controls.Add(Me.chkFinProcedimiento)
        Me.SaimtGroupBox2.Controls.Add(Me.txtObservaciones)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox2.Controls.Add(Me.txtNombre)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox2.Controls.Add(Me.spnNumero)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox2.Controls.Add(Me.spnHoras)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox2.Controls.Add(Me.btnConsultarProcedimiento)
        Me.SaimtGroupBox2.Controls.Add(Me.txtProcedimiento)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox2.Controls.Add(Me.spnDuracion)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox2.Controls.Add(Me.txtInstitucion)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(281, 6)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(531, 460)
        Me.SaimtGroupBox2.TabIndex = 3
        Me.SaimtGroupBox2.Text = "Datos de la Etapa"
        '
        'cboArea
        '
        Me.cboArea.Location = New System.Drawing.Point(37, 97)
        Me.cboArea.MenuManager = Me.RibbonControl
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboArea.Properties.NullText = ""
        Me.cboArea.Size = New System.Drawing.Size(488, 20)
        Me.cboArea.TabIndex = 6
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(8, 100)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(23, 13)
        Me.SaimtLabel10.TabIndex = 5
        Me.SaimtLabel10.Text = "Área"
        '
        'txtCodigoEtapa
        '
        Me.txtCodigoEtapa.Location = New System.Drawing.Point(68, 28)
        Me.txtCodigoEtapa.MenuManager = Me.RibbonControl
        Me.txtCodigoEtapa.Name = "txtCodigoEtapa"
        Me.txtCodigoEtapa.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoEtapa.TabIndex = 1
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(8, 31)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel9.TabIndex = 0
        Me.SaimtLabel9.Text = "Cod. Etapa"
        '
        'btnConsultarInstitucion
        '
        Me.btnConsultarInstitucion.Image = CType(resources.GetObject("btnConsultarInstitucion.Image"), System.Drawing.Image)
        Me.btnConsultarInstitucion.Location = New System.Drawing.Point(494, 67)
        Me.btnConsultarInstitucion.Name = "btnConsultarInstitucion"
        Me.btnConsultarInstitucion.Size = New System.Drawing.Size(28, 23)
        Me.btnConsultarInstitucion.TabIndex = 4
        '
        'chkFinProcedimiento
        '
        Me.chkFinProcedimiento.Location = New System.Drawing.Point(9, 436)
        Me.chkFinProcedimiento.MenuManager = Me.RibbonControl
        Me.chkFinProcedimiento.Name = "chkFinProcedimiento"
        Me.chkFinProcedimiento.Properties.AutoWidth = True
        Me.chkFinProcedimiento.Properties.Caption = "Etapa fin del procedimiento"
        Me.chkFinProcedimiento.Size = New System.Drawing.Size(153, 19)
        Me.chkFinProcedimiento.TabIndex = 20
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(11, 334)
        Me.txtObservaciones.MenuManager = Me.RibbonControl
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(511, 96)
        Me.txtObservaciones.TabIndex = 19
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(13, 318)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(71, 13)
        Me.SaimtLabel5.TabIndex = 18
        Me.SaimtLabel5.Text = "Observaciones"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(94, 180)
        Me.txtNombre.MenuManager = Me.RibbonControl
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(428, 96)
        Me.txtNombre.TabIndex = 13
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(94, 164)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(83, 13)
        Me.SaimtLabel8.TabIndex = 11
        Me.SaimtLabel8.Text = "Nombre de Etapa"
        '
        'spnNumero
        '
        Me.spnNumero.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnNumero.Location = New System.Drawing.Point(8, 180)
        Me.spnNumero.MenuManager = Me.RibbonControl
        Me.spnNumero.Name = "spnNumero"
        Me.spnNumero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spnNumero.Properties.Mask.EditMask = "f0"
        Me.spnNumero.Size = New System.Drawing.Size(69, 20)
        Me.spnNumero.TabIndex = 12
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(11, 164)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(52, 13)
        Me.SaimtLabel7.TabIndex = 10
        Me.SaimtLabel7.Text = "Nro. Etapa"
        '
        'spnHoras
        '
        Me.spnHoras.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnHoras.Location = New System.Drawing.Point(229, 287)
        Me.spnHoras.MenuManager = Me.RibbonControl
        Me.spnHoras.Name = "spnHoras"
        Me.spnHoras.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spnHoras.Properties.Mask.EditMask = "f1"
        Me.spnHoras.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spnHoras.Size = New System.Drawing.Size(69, 20)
        Me.spnHoras.TabIndex = 17
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(195, 290)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(28, 13)
        Me.SaimtLabel6.TabIndex = 16
        Me.SaimtLabel6.Text = "Horas"
        '
        'btnConsultarProcedimiento
        '
        Me.btnConsultarProcedimiento.Image = CType(resources.GetObject("btnConsultarProcedimiento.Image"), System.Drawing.Image)
        Me.btnConsultarProcedimiento.Location = New System.Drawing.Point(494, 134)
        Me.btnConsultarProcedimiento.Name = "btnConsultarProcedimiento"
        Me.btnConsultarProcedimiento.Size = New System.Drawing.Size(28, 23)
        Me.btnConsultarProcedimiento.TabIndex = 9
        '
        'txtProcedimiento
        '
        Me.txtProcedimiento.Location = New System.Drawing.Point(8, 137)
        Me.txtProcedimiento.MenuManager = Me.RibbonControl
        Me.txtProcedimiento.Name = "txtProcedimiento"
        Me.txtProcedimiento.Size = New System.Drawing.Size(480, 20)
        Me.txtProcedimiento.TabIndex = 8
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(11, 121)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel2.TabIndex = 7
        Me.SaimtLabel2.Text = "Procedimiento"
        '
        'spnDuracion
        '
        Me.spnDuracion.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnDuracion.Location = New System.Drawing.Point(105, 287)
        Me.spnDuracion.MenuManager = Me.RibbonControl
        Me.spnDuracion.Name = "spnDuracion"
        Me.spnDuracion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spnDuracion.Properties.Mask.EditMask = "f0"
        Me.spnDuracion.Size = New System.Drawing.Size(69, 20)
        Me.spnDuracion.TabIndex = 15
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(11, 290)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(88, 13)
        Me.SaimtLabel3.TabIndex = 14
        Me.SaimtLabel3.Text = "Duración (En Días)"
        '
        'txtInstitucion
        '
        Me.txtInstitucion.Location = New System.Drawing.Point(8, 70)
        Me.txtInstitucion.MenuManager = Me.RibbonControl
        Me.txtInstitucion.Name = "txtInstitucion"
        Me.txtInstitucion.Size = New System.Drawing.Size(480, 20)
        Me.txtInstitucion.TabIndex = 3
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(11, 54)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(53, 13)
        Me.SaimtLabel1.TabIndex = 2
        Me.SaimtLabel1.Text = "Institución "
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.lstEtapas)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(7, 81)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(264, 466)
        Me.SaimtGroupBox1.TabIndex = 4
        Me.SaimtGroupBox1.Text = "Resultados de Busqueda"
        '
        'lstEtapas
        '
        Me.lstEtapas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstEtapas.HorizontalScrollbar = True
        Me.lstEtapas.Location = New System.Drawing.Point(2, 22)
        Me.lstEtapas.Name = "lstEtapas"
        Me.lstEtapas.Size = New System.Drawing.Size(260, 442)
        Me.lstEtapas.TabIndex = 0
        '
        'txtBuscarPor
        '
        Me.txtBuscarPor.Location = New System.Drawing.Point(7, 55)
        Me.txtBuscarPor.Name = "txtBuscarPor"
        Me.txtBuscarPor.Size = New System.Drawing.Size(264, 20)
        Me.txtBuscarPor.TabIndex = 2
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(12, 5)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel4.TabIndex = 0
        Me.SaimtLabel4.Text = "Buscar por :"
        '
        'rdbCriterios
        '
        Me.rdbCriterios.EditValue = CType(1, Short)
        Me.rdbCriterios.Location = New System.Drawing.Point(7, 21)
        Me.rdbCriterios.Name = "rdbCriterios"
        Me.rdbCriterios.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rdbCriterios.Properties.Appearance.Options.UseBackColor = True
        Me.rdbCriterios.Properties.Columns = 3
        Me.rdbCriterios.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Nom. Proc."), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Área"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "Duración")})
        Me.rdbCriterios.Size = New System.Drawing.Size(264, 29)
        Me.rdbCriterios.TabIndex = 1
        '
        'frmEtapas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(824, 578)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.txtBuscarPor)
        Me.Controls.Add(Me.SaimtLabel4)
        Me.Controls.Add(Me.rdbCriterios)
        Me.LookAndFeel.SkinName = "Seven"
        Me.lstListado = Me.lstEtapas
        Me.Name = "frmEtapas"
        Me.Tag = "btiEtapas"
        Me.Text = "ETAPAS"
        Me.txtBuscarSaimt = Me.txtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.rdbCriterios, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel4, 0)
        Me.Controls.SetChildIndex(Me.txtBuscarPor, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.cboArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoEtapa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFinProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHoras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnDuracion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.lstEtapas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbCriterios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents btnConsultarProcedimiento As SaimtControles.SaimtButton
    Friend WithEvents txtProcedimiento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents spnDuracion As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents txtInstitucion As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents lstEtapas As SaimtControles.SaimtListBox
    Friend WithEvents txtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents rdbCriterios As SaimtControles.SaimtRadioGroup
    Friend WithEvents spnHoras As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents txtNombre As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents spnNumero As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents chkFinProcedimiento As SaimtControles.SaimtCheckBox
    Friend WithEvents txtObservaciones As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents btnConsultarInstitucion As SaimtControles.SaimtButton
    Friend WithEvents cboArea As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents txtCodigoEtapa As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
End Class
