<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGruposArt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGruposArt))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.lstGrupo = New SaimtControles.SaimtListBox()
        Me.txtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.sRbBuscarPor = New SaimtControles.SaimtRadioGroup()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.cboTipoGrupo = New SaimtControles.SaimtComboBoxLookUp()
        Me.TxtCodigo = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.chkActivo = New SaimtControles.SaimtCheckBox()
        Me.txtSiglas = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.TxtNombre = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.cboBuscarPorGrupo = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.lstGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sRbBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.cboTipoGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSiglas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarPorGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 364)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(699, 25)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.lstGrupo)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(6, 115)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(264, 243)
        Me.SaimtGroupBox1.TabIndex = 65
        Me.SaimtGroupBox1.Text = "Resultados de Busqueda"
        '
        'lstGrupo
        '
        Me.lstGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstGrupo.HorizontalScrollbar = True
        Me.lstGrupo.Location = New System.Drawing.Point(2, 22)
        Me.lstGrupo.Name = "lstGrupo"
        Me.lstGrupo.Size = New System.Drawing.Size(260, 219)
        Me.lstGrupo.TabIndex = 6
        '
        'txtBuscarPor
        '
        Me.txtBuscarPor.Location = New System.Drawing.Point(6, 89)
        Me.txtBuscarPor.Name = "txtBuscarPor"
        Me.txtBuscarPor.Size = New System.Drawing.Size(264, 20)
        Me.txtBuscarPor.TabIndex = 64
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(11, 3)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel4.TabIndex = 63
        Me.SaimtLabel4.Text = "Buscar por :"
        '
        'sRbBuscarPor
        '
        Me.sRbBuscarPor.EditValue = "1"
        Me.sRbBuscarPor.Location = New System.Drawing.Point(6, 19)
        Me.sRbBuscarPor.Name = "sRbBuscarPor"
        Me.sRbBuscarPor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sRbBuscarPor.Properties.Appearance.Options.UseBackColor = True
        Me.sRbBuscarPor.Properties.Columns = 3
        Me.sRbBuscarPor.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Nombre Grupo"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Siglas"), New DevExpress.XtraEditors.Controls.RadioGroupItem("3", "Tipo")})
        Me.sRbBuscarPor.Size = New System.Drawing.Size(264, 29)
        Me.sRbBuscarPor.TabIndex = 62
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(489, 224)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 59
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(629, 224)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 61
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(419, 224)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 58
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(279, 224)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 56
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(559, 224)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 60
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(349, 224)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 57
        Me.btnEditar.Text = "Editar"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox2.Controls.Add(Me.cboTipoGrupo)
        Me.SaimtGroupBox2.Controls.Add(Me.TxtCodigo)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox2.Controls.Add(Me.chkActivo)
        Me.SaimtGroupBox2.Controls.Add(Me.txtSiglas)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox2.Controls.Add(Me.TxtNombre)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(276, 7)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(417, 187)
        Me.SaimtGroupBox2.TabIndex = 55
        Me.SaimtGroupBox2.Text = "Datos de Grupo de Articulos"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(180, 71)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(52, 13)
        Me.SaimtLabel5.TabIndex = 9
        Me.SaimtLabel5.Text = "Tipo Grupo"
        '
        'cboTipoGrupo
        '
        Me.cboTipoGrupo.Location = New System.Drawing.Point(178, 86)
        Me.cboTipoGrupo.MenuManager = Me.RibbonControl
        Me.cboTipoGrupo.Name = "cboTipoGrupo"
        Me.cboTipoGrupo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoGrupo.Properties.NullText = ""
        Me.cboTipoGrupo.Size = New System.Drawing.Size(226, 20)
        Me.cboTipoGrupo.TabIndex = 8
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(11, 86)
        Me.TxtCodigo.MenuManager = Me.RibbonControl
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(131, 20)
        Me.TxtCodigo.TabIndex = 7
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(13, 71)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel3.TabIndex = 6
        Me.SaimtLabel3.Text = "Cod Grupo"
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(176, 125)
        Me.chkActivo.MenuManager = Me.RibbonControl
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.AutoWidth = True
        Me.chkActivo.Properties.Caption = "Check si el Grupo esta Activo"
        Me.chkActivo.Size = New System.Drawing.Size(162, 19)
        Me.chkActivo.TabIndex = 4
        '
        'txtSiglas
        '
        Me.txtSiglas.Location = New System.Drawing.Point(11, 125)
        Me.txtSiglas.MenuManager = Me.RibbonControl
        Me.txtSiglas.Name = "txtSiglas"
        Me.txtSiglas.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSiglas.Size = New System.Drawing.Size(131, 20)
        Me.txtSiglas.TabIndex = 3
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(13, 110)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(74, 13)
        Me.SaimtLabel2.TabIndex = 2
        Me.SaimtLabel2.Text = "Siglas de Grupo"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(11, 42)
        Me.TxtNombre.MenuManager = Me.RibbonControl
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Size = New System.Drawing.Size(393, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(14, 27)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(85, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Nombre del grupo"
        '
        'cboBuscarPorGrupo
        '
        Me.cboBuscarPorGrupo.Location = New System.Drawing.Point(6, 65)
        Me.cboBuscarPorGrupo.MenuManager = Me.RibbonControl
        Me.cboBuscarPorGrupo.Name = "cboBuscarPorGrupo"
        Me.cboBuscarPorGrupo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarPorGrupo.Properties.NullText = ""
        Me.cboBuscarPorGrupo.Size = New System.Drawing.Size(264, 20)
        Me.cboBuscarPorGrupo.TabIndex = 66
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(6, 50)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(52, 13)
        Me.SaimtLabel6.TabIndex = 67
        Me.SaimtLabel6.Text = "Tipo Grupo"
        '
        'frmGruposArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(699, 389)
        Me.Controls.Add(Me.SaimtLabel6)
        Me.Controls.Add(Me.cboBuscarPorGrupo)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.txtBuscarPor)
        Me.Controls.Add(Me.SaimtLabel4)
        Me.Controls.Add(Me.sRbBuscarPor)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.LookAndFeel.SkinName = "Seven"
        Me.lstListado = Me.lstGrupo
        Me.Name = "frmGruposArt"
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeImprimir = True
        Me.Text = "Registro de Grupos de Articulos y Servicios"
        Me.txtBuscarSaimt = Me.txtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.sRbBuscarPor, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel4, 0)
        Me.Controls.SetChildIndex(Me.txtBuscarPor, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.cboBuscarPorGrupo, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel6, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.lstGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sRbBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.cboTipoGrupo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSiglas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarPorGrupo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents lstGrupo As SaimtControles.SaimtListBox
    Friend WithEvents txtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents sRbBuscarPor As SaimtControles.SaimtRadioGroup
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents TxtCodigo As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents chkActivo As SaimtControles.SaimtCheckBox
    Friend WithEvents txtSiglas As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents TxtNombre As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoGrupo As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboBuscarPorGrupo As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
End Class
