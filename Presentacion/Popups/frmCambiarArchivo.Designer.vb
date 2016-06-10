<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarArchivo
    Inherits Presentacion.frmGeneral

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
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtNombreArchivo = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.txtDescripcionArchivo = New SaimtControles.SaimtTextBoxMultiline()
        Me.chkArchPrincipal = New SaimtControles.SaimtCheckBox()
        Me.chkActivo = New SaimtControles.SaimtCheckBox()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkArchPrincipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 255)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(380, 27)
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(25, 9)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(44, 13)
        Me.SaimtLabel1.TabIndex = 7
        Me.SaimtLabel1.Text = "Nombre :"
        '
        'txtNombreArchivo
        '
        Me.txtNombreArchivo.Location = New System.Drawing.Point(75, 7)
        Me.txtNombreArchivo.Name = "txtNombreArchivo"
        Me.txtNombreArchivo.Size = New System.Drawing.Size(293, 20)
        Me.txtNombreArchivo.TabIndex = 8
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(8, 35)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(61, 13)
        Me.SaimtLabel2.TabIndex = 9
        Me.SaimtLabel2.Text = "Descripción :"
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.Presentacion.My.Resources.Resources.editar
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(177, 185)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(72, 64)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.Text = "Editar"
        '
        'txtDescripcionArchivo
        '
        Me.txtDescripcionArchivo.Location = New System.Drawing.Point(75, 33)
        Me.txtDescripcionArchivo.MenuManager = Me.RibbonControl
        Me.txtDescripcionArchivo.Name = "txtDescripcionArchivo"
        Me.txtDescripcionArchivo.Properties.LookAndFeel.SkinName = "Seven"
        Me.txtDescripcionArchivo.Size = New System.Drawing.Size(293, 113)
        Me.txtDescripcionArchivo.TabIndex = 14
        '
        'chkArchPrincipal
        '
        Me.chkArchPrincipal.Location = New System.Drawing.Point(73, 154)
        Me.chkArchPrincipal.MenuManager = Me.RibbonControl
        Me.chkArchPrincipal.Name = "chkArchPrincipal"
        Me.chkArchPrincipal.Properties.AutoWidth = True
        Me.chkArchPrincipal.Properties.Caption = "Imagen Principal"
        Me.chkArchPrincipal.Properties.LookAndFeel.SkinName = "Seven"
        Me.chkArchPrincipal.Size = New System.Drawing.Size(101, 19)
        Me.chkArchPrincipal.TabIndex = 15
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(221, 154)
        Me.chkActivo.MenuManager = Me.RibbonControl
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.AutoWidth = True
        Me.chkActivo.Properties.Caption = "Activo"
        Me.chkActivo.Properties.LookAndFeel.SkinName = "Seven"
        Me.chkActivo.Size = New System.Drawing.Size(53, 19)
        Me.chkActivo.TabIndex = 16
        '
        'frmCambiarArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 282)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.chkArchPrincipal)
        Me.Controls.Add(Me.txtDescripcionArchivo)
        Me.Controls.Add(Me.SaimtLabel2)
        Me.Controls.Add(Me.txtNombreArchivo)
        Me.Controls.Add(Me.SaimtLabel1)
        Me.Controls.Add(Me.btnEditar)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmCambiarArchivo"
        Me.Text = "EDICION ARCHIVO"
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtNombreArchivo, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel2, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionArchivo, 0)
        Me.Controls.SetChildIndex(Me.chkArchPrincipal, 0)
        Me.Controls.SetChildIndex(Me.chkActivo, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkArchPrincipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtNombreArchivo As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents txtDescripcionArchivo As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents chkArchPrincipal As SaimtControles.SaimtCheckBox
    Friend WithEvents chkActivo As SaimtControles.SaimtCheckBox
End Class
