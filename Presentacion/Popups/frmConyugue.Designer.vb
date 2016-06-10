<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConyugue
    Inherits Presentacion.frmPopup

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
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtDni = New SaimtControles.SaimtTextBox()
        Me.txtApMaterno = New SaimtControles.SaimtTextBox()
        Me.txtApPaterno = New SaimtControles.SaimtTextBox()
        Me.txtNombres = New SaimtControles.SaimtTextBox()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        CType(Me.txtDni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApMaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApPaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 180)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(319, 25)
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(51, 8)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(25, 13)
        Me.SaimtLabel4.TabIndex = 0
        Me.SaimtLabel4.Text = "DNI :"
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(9, 85)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel7.TabIndex = 6
        Me.SaimtLabel7.Text = "Ap. Materno :"
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(11, 59)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(65, 13)
        Me.SaimtLabel6.TabIndex = 4
        Me.SaimtLabel6.Text = "Ap. Paterno :"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(27, 34)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(49, 13)
        Me.SaimtLabel5.TabIndex = 2
        Me.SaimtLabel5.Text = "Nombres :"
        '
        'txtDni
        '
        Me.txtDni.EditValue = ""
        Me.txtDni.Location = New System.Drawing.Point(82, 5)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(230, 20)
        Me.txtDni.TabIndex = 1
        '
        'txtApMaterno
        '
        Me.txtApMaterno.EditValue = ""
        Me.txtApMaterno.Location = New System.Drawing.Point(82, 83)
        Me.txtApMaterno.Name = "txtApMaterno"
        Me.txtApMaterno.Size = New System.Drawing.Size(230, 20)
        Me.txtApMaterno.TabIndex = 7
        '
        'txtApPaterno
        '
        Me.txtApPaterno.EditValue = ""
        Me.txtApPaterno.Location = New System.Drawing.Point(82, 57)
        Me.txtApPaterno.Name = "txtApPaterno"
        Me.txtApPaterno.Size = New System.Drawing.Size(230, 20)
        Me.txtApPaterno.TabIndex = 5
        '
        'txtNombres
        '
        Me.txtNombres.EditValue = ""
        Me.txtNombres.Location = New System.Drawing.Point(82, 31)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(230, 20)
        Me.txtNombres.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.Presentacion.My.Resources.Resources.guardar
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(186, 109)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 10
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Presentacion.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(116, 109)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 8
        '
        'frmConyugue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(319, 205)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.SaimtLabel4)
        Me.Controls.Add(Me.SaimtLabel7)
        Me.Controls.Add(Me.SaimtLabel6)
        Me.Controls.Add(Me.SaimtLabel5)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.txtApMaterno)
        Me.Controls.Add(Me.txtApPaterno)
        Me.Controls.Add(Me.txtNombres)
        Me.Name = "frmConyugue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CONYUGUE"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.txtNombres, 0)
        Me.Controls.SetChildIndex(Me.txtApPaterno, 0)
        Me.Controls.SetChildIndex(Me.txtApMaterno, 0)
        Me.Controls.SetChildIndex(Me.txtDni, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel5, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel6, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel7, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel4, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        CType(Me.txtDni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApMaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApPaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtDni As SaimtControles.SaimtTextBox
    Friend WithEvents txtApMaterno As SaimtControles.SaimtTextBox
    Friend WithEvents txtApPaterno As SaimtControles.SaimtTextBox
    Friend WithEvents txtNombres As SaimtControles.SaimtTextBox
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton

End Class
