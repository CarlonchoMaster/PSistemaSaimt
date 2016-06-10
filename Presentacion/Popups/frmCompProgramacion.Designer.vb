<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompProgramacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompProgramacion))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.cboTipoComprobante = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.txtNroComp = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtSerie = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtProPaId = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.btnguardar = New SaimtControles.SaimtButton()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.cboTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProPaId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 171)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(353, 27)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.cboTipoComprobante)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroComp)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.txtSerie)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Controls.Add(Me.txtProPaId)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(258, 160)
        Me.SaimtGroupBox1.TabIndex = 0
        Me.SaimtGroupBox1.Text = "Comprobante de Pago"
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.Location = New System.Drawing.Point(65, 123)
        Me.cboTipoComprobante.MenuManager = Me.RibbonControl
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoComprobante.Properties.NullText = ""
        Me.cboTipoComprobante.Size = New System.Drawing.Size(126, 20)
        Me.cboTipoComprobante.TabIndex = 7
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(5, 126)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel4.TabIndex = 6
        Me.SaimtLabel4.Text = "Tipo Comp."
        '
        'txtNroComp
        '
        Me.txtNroComp.Location = New System.Drawing.Point(63, 93)
        Me.txtNroComp.MenuManager = Me.RibbonControl
        Me.txtNroComp.Name = "txtNroComp"
        Me.txtNroComp.Size = New System.Drawing.Size(128, 20)
        Me.txtNroComp.TabIndex = 5
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(20, 96)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(37, 13)
        Me.SaimtLabel3.TabIndex = 4
        Me.SaimtLabel3.Text = "Número"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(63, 63)
        Me.txtSerie.MenuManager = Me.RibbonControl
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(128, 20)
        Me.txtSerie.TabIndex = 3
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(33, 66)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(24, 13)
        Me.SaimtLabel2.TabIndex = 2
        Me.SaimtLabel2.Text = "Serie"
        '
        'txtProPaId
        '
        Me.txtProPaId.Location = New System.Drawing.Point(63, 33)
        Me.txtProPaId.MenuManager = Me.RibbonControl
        Me.txtProPaId.Name = "txtProPaId"
        Me.txtProPaId.Properties.ReadOnly = True
        Me.txtProPaId.Size = New System.Drawing.Size(128, 20)
        Me.txtProPaId.TabIndex = 1
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(5, 36)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(52, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Cod. Prog."
        '
        'btnguardar
        '
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnguardar.Location = New System.Drawing.Point(273, 54)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 62)
        Me.btnguardar.TabIndex = 1
        Me.btnguardar.Text = "SaimtButton1"
        '
        'frmCompProgramacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonGuardar = Me.btnguardar
        Me.ClientSize = New System.Drawing.Size(353, 198)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.btnguardar)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmCompProgramacion"
        Me.Text = "SERIE - NÚMERO COMPROBANTE"
        Me.Controls.SetChildIndex(Me.btnguardar, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.cboTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProPaId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents cboTipoComprobante As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroComp As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents txtSerie As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtProPaId As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents btnguardar As SaimtControles.SaimtButton
End Class
