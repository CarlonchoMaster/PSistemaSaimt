<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.rdbCriterios = New SaimtControles.SaimtRadioGroup()
        Me.gbxLista = New SaimtControles.SaimtGroupBox()
        Me.lstUsuarios = New SaimtControles.SaimtListBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtDatosUsuarios = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.btnRevelarPassword = New SaimtControles.SaimtButton()
        Me.btnConsultarUsuario = New SaimtControles.SaimtButton()
        Me.txtPassword = New SaimtControles.SaimtTextBox()
        Me.txtUsuario = New SaimtControles.SaimtTextBox()
        Me.btnDesmarcarVistas = New SaimtControles.SaimtButton()
        Me.btnMarcarVistas = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.tabsModulos = New SaimtControles.SaimtTabs()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbCriterios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxLista.SuspendLayout()
        CType(Me.lstUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatosUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.tabsModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 408)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(858, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(518, 342)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 9
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(658, 342)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 11
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(448, 342)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 8
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(308, 342)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 6
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(588, 342)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 10
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(378, 342)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 7
        '
        'rdbCriterios
        '
        Me.rdbCriterios.EditValue = CType(1, Short)
        Me.rdbCriterios.Location = New System.Drawing.Point(65, 3)
        Me.rdbCriterios.MenuManager = Me.RibbonControl
        Me.rdbCriterios.Name = "rdbCriterios"
        Me.rdbCriterios.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rdbCriterios.Properties.Appearance.Options.UseBackColor = True
        Me.rdbCriterios.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdbCriterios.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Usuario"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Datos")})
        Me.rdbCriterios.Size = New System.Drawing.Size(121, 21)
        Me.rdbCriterios.TabIndex = 1
        '
        'gbxLista
        '
        Me.gbxLista.Controls.Add(Me.lstUsuarios)
        Me.gbxLista.Location = New System.Drawing.Point(5, 56)
        Me.gbxLista.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gbxLista.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gbxLista.Name = "gbxLista"
        Me.gbxLista.Size = New System.Drawing.Size(181, 351)
        Me.gbxLista.TabIndex = 4
        Me.gbxLista.Text = "Lista de Usuarios"
        '
        'lstUsuarios
        '
        Me.lstUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstUsuarios.HorizontalScrollbar = True
        Me.lstUsuarios.Location = New System.Drawing.Point(2, 22)
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.Size = New System.Drawing.Size(177, 327)
        Me.lstUsuarios.TabIndex = 0
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(4, 6)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(55, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Buscar por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(4, 30)
        Me.txtBuscar.MenuManager = Me.RibbonControl
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(182, 20)
        Me.txtBuscar.TabIndex = 2
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(36, 34)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(74, 13)
        Me.SaimtLabel5.TabIndex = 0
        Me.SaimtLabel5.Text = "Datos Usuario :"
        '
        'txtDatosUsuarios
        '
        Me.txtDatosUsuarios.EditValue = ""
        Me.txtDatosUsuarios.Location = New System.Drawing.Point(116, 31)
        Me.txtDatosUsuarios.Name = "txtDatosUsuarios"
        Me.txtDatosUsuarios.Size = New System.Drawing.Size(464, 20)
        Me.txtDatosUsuarios.TabIndex = 1
        Me.txtDatosUsuarios.Tag = "0"
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(67, 60)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(43, 13)
        Me.SaimtLabel3.TabIndex = 4
        Me.SaimtLabel3.Text = "Usuario :"
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(329, 59)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(53, 13)
        Me.SaimtLabel4.TabIndex = 3
        Me.SaimtLabel4.Text = "Password :"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.btnRevelarPassword)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox1.Controls.Add(Me.btnConsultarUsuario)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.txtPassword)
        Me.SaimtGroupBox1.Controls.Add(Me.txtUsuario)
        Me.SaimtGroupBox1.Controls.Add(Me.txtDatosUsuarios)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(192, 3)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(659, 90)
        Me.SaimtGroupBox1.TabIndex = 3
        Me.SaimtGroupBox1.Text = "Datos de Usuario"
        '
        'btnRevelarPassword
        '
        Me.btnRevelarPassword.Image = CType(resources.GetObject("btnRevelarPassword.Image"), System.Drawing.Image)
        Me.btnRevelarPassword.Location = New System.Drawing.Point(581, 56)
        Me.btnRevelarPassword.Name = "btnRevelarPassword"
        Me.btnRevelarPassword.Size = New System.Drawing.Size(25, 21)
        Me.btnRevelarPassword.TabIndex = 7
        '
        'btnConsultarUsuario
        '
        Me.btnConsultarUsuario.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnConsultarUsuario.Location = New System.Drawing.Point(581, 30)
        Me.btnConsultarUsuario.Name = "btnConsultarUsuario"
        Me.btnConsultarUsuario.Size = New System.Drawing.Size(25, 21)
        Me.btnConsultarUsuario.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.EditValue = ""
        Me.txtPassword.Location = New System.Drawing.Point(388, 57)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.UseSystemPasswordChar = True
        Me.txtPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtPassword.TabIndex = 6
        '
        'txtUsuario
        '
        Me.txtUsuario.EditValue = ""
        Me.txtUsuario.Location = New System.Drawing.Point(116, 57)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(192, 20)
        Me.txtUsuario.TabIndex = 5
        '
        'btnDesmarcarVistas
        '
        Me.btnDesmarcarVistas.Image = Global.Presentacion.My.Resources.Resources.uncheck
        Me.btnDesmarcarVistas.Location = New System.Drawing.Point(533, 0)
        Me.btnDesmarcarVistas.Name = "btnDesmarcarVistas"
        Me.btnDesmarcarVistas.Size = New System.Drawing.Size(126, 23)
        Me.btnDesmarcarVistas.TabIndex = 1
        Me.btnDesmarcarVistas.Text = "Descamarcar Vistas"
        '
        'btnMarcarVistas
        '
        Me.btnMarcarVistas.Image = Global.Presentacion.My.Resources.Resources.check
        Me.btnMarcarVistas.Location = New System.Drawing.Point(426, 0)
        Me.btnMarcarVistas.Name = "btnMarcarVistas"
        Me.btnMarcarVistas.Size = New System.Drawing.Size(100, 23)
        Me.btnMarcarVistas.TabIndex = 0
        Me.btnMarcarVistas.Text = "Marcar Vistas"
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Controls.Add(Me.btnDesmarcarVistas)
        Me.SaimtGroupBox3.Controls.Add(Me.btnMarcarVistas)
        Me.SaimtGroupBox3.Controls.Add(Me.tabsModulos)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(192, 99)
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(665, 240)
        Me.SaimtGroupBox3.TabIndex = 5
        Me.SaimtGroupBox3.Text = "Privilegios de Vistas"
        '
        'tabsModulos
        '
        Me.tabsModulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabsModulos.Location = New System.Drawing.Point(2, 22)
        Me.tabsModulos.Name = "tabsModulos"
        Me.tabsModulos.Size = New System.Drawing.Size(661, 216)
        Me.tabsModulos.TabIndex = 2
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(858, 435)
        Me.Controls.Add(Me.SaimtGroupBox3)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.rdbCriterios)
        Me.Controls.Add(Me.gbxLista)
        Me.Controls.Add(Me.SaimtLabel1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.LookAndFeel.SkinName = "Seven"
        Me.lstListado = Me.lstUsuarios
        Me.Name = "frmUsuarios"
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeImprimir = True
        Me.Tag = "btiUsuarios"
        Me.Text = "USUARIOS"
        Me.txtBuscarSaimt = Me.txtBuscar
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel1, 0)
        Me.Controls.SetChildIndex(Me.gbxLista, 0)
        Me.Controls.SetChildIndex(Me.rdbCriterios, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox3, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbCriterios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxLista.ResumeLayout(False)
        CType(Me.lstUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatosUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        CType(Me.tabsModulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents rdbCriterios As SaimtControles.SaimtRadioGroup
    Friend WithEvents gbxLista As SaimtControles.SaimtGroupBox
    Friend WithEvents lstUsuarios As SaimtControles.SaimtListBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtBuscar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtDatosUsuarios As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtPassword As SaimtControles.SaimtTextBox
    Friend WithEvents txtUsuario As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents btnConsultarUsuario As SaimtControles.SaimtButton
    Friend WithEvents tabsModulos As SaimtControles.SaimtTabs
    Friend WithEvents btnDesmarcarVistas As SaimtControles.SaimtButton
    Friend WithEvents btnMarcarVistas As SaimtControles.SaimtButton
    Friend WithEvents btnRevelarPassword As SaimtControles.SaimtButton

End Class
