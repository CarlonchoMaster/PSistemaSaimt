<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisito
    Inherits Presentacion.frmMantenimientos

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequisito))
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.txtcodigoReq = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.chkActivo = New SaimtControles.SaimtCheckBox()
        Me.TxtDescripcionReq = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.TxtNombreReq = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.lstRequisitos = New SaimtControles.SaimtListBox()
        Me.TxtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.txtcodigoReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescripcionReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNombreReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.lstRequisitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 422)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(838, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(557, 352)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 37
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(697, 352)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(487, 352)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 36
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(347, 352)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 34
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(627, 352)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 38
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(417, 352)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 35
        Me.btnEditar.Text = "Editar"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.txtcodigoReq)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox2.Controls.Add(Me.chkActivo)
        Me.SaimtGroupBox2.Controls.Add(Me.TxtDescripcionReq)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox2.Controls.Add(Me.TxtNombreReq)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(277, 12)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(549, 334)
        Me.SaimtGroupBox2.TabIndex = 33
        Me.SaimtGroupBox2.Text = "Datos del Requisito"
        '
        'txtcodigoReq
        '
        Me.txtcodigoReq.Location = New System.Drawing.Point(73, 29)
        Me.txtcodigoReq.MenuManager = Me.RibbonControl
        Me.txtcodigoReq.Name = "txtcodigoReq"
        Me.txtcodigoReq.Size = New System.Drawing.Size(131, 20)
        Me.txtcodigoReq.TabIndex = 9
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(14, 32)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(45, 13)
        Me.SaimtLabel3.TabIndex = 8
        Me.SaimtLabel3.Text = "Cod. Req"
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(12, 310)
        Me.chkActivo.MenuManager = Me.RibbonControl
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.AutoWidth = True
        Me.chkActivo.Properties.Caption = "Check si el requisito esta Activo"
        Me.chkActivo.Size = New System.Drawing.Size(174, 19)
        Me.chkActivo.TabIndex = 4
        '
        'TxtDescripcionReq
        '
        Me.TxtDescripcionReq.Location = New System.Drawing.Point(13, 128)
        Me.TxtDescripcionReq.MenuManager = Me.RibbonControl
        Me.TxtDescripcionReq.Name = "TxtDescripcionReq"
        Me.TxtDescripcionReq.Size = New System.Drawing.Size(526, 176)
        Me.TxtDescripcionReq.TabIndex = 3
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(13, 109)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(107, 13)
        Me.SaimtLabel2.TabIndex = 2
        Me.SaimtLabel2.Text = "Observación Requisito"
        '
        'TxtNombreReq
        '
        Me.TxtNombreReq.Location = New System.Drawing.Point(12, 83)
        Me.TxtNombreReq.MenuManager = Me.RibbonControl
        Me.TxtNombreReq.Name = "TxtNombreReq"
        Me.TxtNombreReq.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreReq.Size = New System.Drawing.Size(527, 20)
        Me.TxtNombreReq.TabIndex = 1
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(12, 64)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(84, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Nombre Requisito"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.lstRequisitos)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(7, 45)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(264, 371)
        Me.SaimtGroupBox1.TabIndex = 43
        Me.SaimtGroupBox1.Text = "Resultados de Busqueda"
        '
        'lstRequisitos
        '
        Me.lstRequisitos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstRequisitos.HorizontalScrollbar = True
        Me.lstRequisitos.Location = New System.Drawing.Point(2, 22)
        Me.lstRequisitos.Name = "lstRequisitos"
        Me.lstRequisitos.Size = New System.Drawing.Size(260, 347)
        Me.lstRequisitos.TabIndex = 6
        '
        'TxtBuscarPor
        '
        Me.TxtBuscarPor.Location = New System.Drawing.Point(7, 19)
        Me.TxtBuscarPor.Name = "TxtBuscarPor"
        Me.TxtBuscarPor.Size = New System.Drawing.Size(264, 20)
        Me.TxtBuscarPor.TabIndex = 42
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(12, 4)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel4.TabIndex = 41
        Me.SaimtLabel4.Text = "Buscar por :"
        '
        'frmRequisito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(838, 449)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.TxtBuscarPor)
        Me.Controls.Add(Me.SaimtLabel4)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.LookAndFeel.SkinName = "Seven"
        Me.lstListado = Me.lstRequisitos
        Me.Name = "frmRequisito"
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeEliminar = True
        Me.Text = "Registrar Requisito"
        Me.txtBuscarSaimt = Me.TxtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel4, 0)
        Me.Controls.SetChildIndex(Me.TxtBuscarPor, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.txtcodigoReq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescripcionReq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNombreReq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.lstRequisitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents TxtNombreReq As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents lstRequisitos As SaimtControles.SaimtListBox
    Friend WithEvents TxtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents TxtDescripcionReq As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents chkActivo As SaimtControles.SaimtCheckBox
    Friend WithEvents txtcodigoReq As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
End Class
