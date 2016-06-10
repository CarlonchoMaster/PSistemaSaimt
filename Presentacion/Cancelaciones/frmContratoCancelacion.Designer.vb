<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratoCancelacion
    Inherits Presentacion.frmCancelacion

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContratoCancelacion))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.cboEstadoContrato = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCanDesde = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtNroCuotasPagadas = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtNroCuotasPendientes = New SaimtControles.SaimtTextBox()
        Me.txtNroTotalCuotas = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.dtpFechaCancelacion = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel24 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.txtNroContrato = New SaimtControles.SaimtTextBox()
        Me.txtObsContrato = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel29 = New SaimtControles.SaimtLabel()
        Me.btnGuardarCancelacion = New SaimtControles.SaimtButton()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.cboEstadoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCanDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroCuotasPagadas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroCuotasPendientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroTotalCuotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaCancelacion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaCancelacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObsContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 216)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(526, 27)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.cboEstadoContrato)
        Me.SaimtGroupBox1.Controls.Add(Me.cboCanDesde)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroCuotasPagadas)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroCuotasPendientes)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroTotalCuotas)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Controls.Add(Me.dtpFechaCancelacion)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel24)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel9)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroContrato)
        Me.SaimtGroupBox1.Controls.Add(Me.txtObsContrato)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel29)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(3, 5)
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(518, 147)
        Me.SaimtGroupBox1.TabIndex = 46
        Me.SaimtGroupBox1.Text = "Datos de la Cancelación"
        '
        'cboEstadoContrato
        '
        Me.cboEstadoContrato.Location = New System.Drawing.Point(110, 58)
        Me.cboEstadoContrato.Name = "cboEstadoContrato"
        Me.cboEstadoContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstadoContrato.Properties.NullText = ""
        Me.cboEstadoContrato.Size = New System.Drawing.Size(139, 20)
        Me.cboEstadoContrato.TabIndex = 93
        '
        'cboCanDesde
        '
        Me.cboCanDesde.Location = New System.Drawing.Point(368, 57)
        Me.cboCanDesde.Name = "cboCanDesde"
        Me.cboCanDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCanDesde.Properties.NullText = ""
        Me.cboCanDesde.Size = New System.Drawing.Size(144, 20)
        Me.cboCanDesde.TabIndex = 92
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(381, 85)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(85, 13)
        Me.SaimtLabel5.TabIndex = 91
        Me.SaimtLabel5.Text = "Cuotas Pagadas :"
        '
        'txtNroCuotasPagadas
        '
        Me.txtNroCuotasPagadas.EditValue = ""
        Me.txtNroCuotasPagadas.Location = New System.Drawing.Point(472, 82)
        Me.txtNroCuotasPagadas.Name = "txtNroCuotasPagadas"
        Me.txtNroCuotasPagadas.Size = New System.Drawing.Size(40, 20)
        Me.txtNroCuotasPagadas.TabIndex = 90
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(201, 84)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(97, 13)
        Me.SaimtLabel4.TabIndex = 89
        Me.SaimtLabel4.Text = "Cuotas Pendientes :"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(45, 82)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(61, 13)
        Me.SaimtLabel2.TabIndex = 88
        Me.SaimtLabel2.Text = "Nro Cuotas :"
        '
        'txtNroCuotasPendientes
        '
        Me.txtNroCuotasPendientes.EditValue = ""
        Me.txtNroCuotasPendientes.Location = New System.Drawing.Point(304, 81)
        Me.txtNroCuotasPendientes.Name = "txtNroCuotasPendientes"
        Me.txtNroCuotasPendientes.Size = New System.Drawing.Size(39, 20)
        Me.txtNroCuotasPendientes.TabIndex = 86
        '
        'txtNroTotalCuotas
        '
        Me.txtNroTotalCuotas.EditValue = ""
        Me.txtNroTotalCuotas.Location = New System.Drawing.Point(110, 81)
        Me.txtNroTotalCuotas.Name = "txtNroTotalCuotas"
        Me.txtNroTotalCuotas.Size = New System.Drawing.Size(39, 20)
        Me.txtNroTotalCuotas.TabIndex = 85
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(278, 60)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(82, 13)
        Me.SaimtLabel1.TabIndex = 84
        Me.SaimtLabel1.Text = "Cancelar Desde :"
        '
        'dtpFechaCancelacion
        '
        Me.dtpFechaCancelacion.EditValue = Nothing
        Me.dtpFechaCancelacion.Location = New System.Drawing.Point(368, 31)
        Me.dtpFechaCancelacion.Name = "dtpFechaCancelacion"
        Me.dtpFechaCancelacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaCancelacion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaCancelacion.Size = New System.Drawing.Size(144, 20)
        Me.dtpFechaCancelacion.TabIndex = 82
        '
        'SaimtLabel24
        '
        Me.SaimtLabel24.Location = New System.Drawing.Point(267, 34)
        Me.SaimtLabel24.Name = "SaimtLabel24"
        Me.SaimtLabel24.Size = New System.Drawing.Size(96, 13)
        Me.SaimtLabel24.TabIndex = 81
        Me.SaimtLabel24.Text = "Fecha Cancelacion :"
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(20, 60)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(86, 13)
        Me.SaimtLabel10.TabIndex = 78
        Me.SaimtLabel10.Text = "Estado Contrato :"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(36, 34)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(70, 13)
        Me.SaimtLabel9.TabIndex = 76
        Me.SaimtLabel9.Text = "Nro Contrato :"
        '
        'txtNroContrato
        '
        Me.txtNroContrato.EditValue = ""
        Me.txtNroContrato.Location = New System.Drawing.Point(110, 31)
        Me.txtNroContrato.Name = "txtNroContrato"
        Me.txtNroContrato.Size = New System.Drawing.Size(139, 20)
        Me.txtNroContrato.TabIndex = 77
        '
        'txtObsContrato
        '
        Me.txtObsContrato.Location = New System.Drawing.Point(110, 108)
        Me.txtObsContrato.Name = "txtObsContrato"
        Me.txtObsContrato.Size = New System.Drawing.Size(402, 35)
        Me.txtObsContrato.TabIndex = 75
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(38, 110)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel3.TabIndex = 48
        Me.SaimtLabel3.Text = "Observación :"
        '
        'SaimtLabel29
        '
        Me.SaimtLabel29.Location = New System.Drawing.Point(-289, -171)
        Me.SaimtLabel29.Name = "SaimtLabel29"
        Me.SaimtLabel29.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel29.TabIndex = 0
        Me.SaimtLabel29.Text = "Tipo Persona :"
        '
        'btnGuardarCancelacion
        '
        Me.btnGuardarCancelacion.Image = CType(resources.GetObject("btnGuardarCancelacion.Image"), System.Drawing.Image)
        Me.btnGuardarCancelacion.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnGuardarCancelacion.Location = New System.Drawing.Point(252, 154)
        Me.btnGuardarCancelacion.Name = "btnGuardarCancelacion"
        Me.btnGuardarCancelacion.Size = New System.Drawing.Size(75, 58)
        Me.btnGuardarCancelacion.TabIndex = 47
        Me.btnGuardarCancelacion.Text = "Guardar"
        '
        'frmContratoCancelacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonGuardar = Me.btnGuardarCancelacion
        Me.ClientSize = New System.Drawing.Size(526, 243)
        Me.Controls.Add(Me.btnGuardarCancelacion)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmContratoCancelacion"
        Me.Text = "CANCELACION CONTRATO"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarCancelacion, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.cboEstadoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCanDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroCuotasPagadas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroCuotasPendientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroTotalCuotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaCancelacion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaCancelacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObsContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaCancelacion As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel24 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroContrato As SaimtControles.SaimtTextBox
    Friend WithEvents txtObsContrato As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel29 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroCuotasPagadas As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroCuotasPendientes As SaimtControles.SaimtTextBox
    Friend WithEvents txtNroTotalCuotas As SaimtControles.SaimtTextBox
    Friend WithEvents cboCanDesde As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents btnGuardarCancelacion As SaimtControles.SaimtButton
    Friend WithEvents cboEstadoContrato As SaimtControles.SaimtComboBoxLookUp
End Class
