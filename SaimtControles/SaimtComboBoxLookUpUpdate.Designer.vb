<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaimtComboBoxLookUpUpdate
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.cboUpdate = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnUpdateCbo = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.cboUpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboUpdate
        '
        Me.cboUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboUpdate.Location = New System.Drawing.Point(0, 0)
        Me.cboUpdate.Name = "cboUpdate"
        Me.cboUpdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUpdate.Properties.NullText = ""
        Me.cboUpdate.Size = New System.Drawing.Size(100, 20)
        Me.cboUpdate.TabIndex = 0
        '
        'btnUpdateCbo
        '
        Me.btnUpdateCbo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUpdateCbo.Image = Global.SaimtControles.My.Resources.Resources.updatecbosaimt
        Me.btnUpdateCbo.Location = New System.Drawing.Point(0, 0)
        Me.btnUpdateCbo.MaximumSize = New System.Drawing.Size(23, 20)
        Me.btnUpdateCbo.MinimumSize = New System.Drawing.Size(23, 20)
        Me.btnUpdateCbo.Name = "btnUpdateCbo"
        Me.btnUpdateCbo.Size = New System.Drawing.Size(23, 20)
        Me.btnUpdateCbo.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboUpdate)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnUpdateCbo)
        Me.SplitContainer1.Panel2MinSize = 23
        Me.SplitContainer1.Size = New System.Drawing.Size(126, 21)
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'SaimtComboBoxLookUpUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Name = "SaimtComboBoxLookUpUpdate"
        Me.Size = New System.Drawing.Size(126, 21)
        CType(Me.cboUpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cboUpdate As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Public WithEvents btnUpdateCbo As DevExpress.XtraEditors.SimpleButton

End Class
