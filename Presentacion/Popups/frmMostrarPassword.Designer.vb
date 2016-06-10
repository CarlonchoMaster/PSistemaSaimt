<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarPassword
    Inherits frmPopup

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
        Me.txtPasswordDecodificado = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPasswordDecodificado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 139)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(292, 27)
        '
        'txtPasswordDecodificado
        '
        Me.txtPasswordDecodificado.EditValue = ""
        Me.txtPasswordDecodificado.Location = New System.Drawing.Point(25, 57)
        Me.txtPasswordDecodificado.MenuManager = Me.RibbonControl
        Me.txtPasswordDecodificado.Name = "txtPasswordDecodificado"
        Me.txtPasswordDecodificado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtPasswordDecodificado.Properties.Appearance.Options.UseFont = True
        Me.txtPasswordDecodificado.Properties.ReadOnly = True
        Me.txtPasswordDecodificado.Size = New System.Drawing.Size(244, 29)
        Me.txtPasswordDecodificado.TabIndex = 2
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(27, 42)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(110, 13)
        Me.SaimtLabel1.TabIndex = 3
        Me.SaimtLabel1.Text = "Password Decodificado"
        '
        'frmMostrarPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 166)
        Me.Controls.Add(Me.txtPasswordDecodificado)
        Me.Controls.Add(Me.SaimtLabel1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmMostrarPassword"
        Me.Text = "PASSWORD"
        Me.Controls.SetChildIndex(Me.SaimtLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtPasswordDecodificado, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPasswordDecodificado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPasswordDecodificado As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
End Class
