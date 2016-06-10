<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecaudacionDiaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecaudacionDiaria))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.cboConceptos = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnConsultarConyuge = New SaimtControles.SaimtButton()
        Me.btnfechaliqui = New SaimtControles.SaimtButton()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.dtpfechaliq = New SaimtControles.SaimtDateTimePicker()
        Me.TxtNroDoc = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.cboTipoDoc = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.txtDepositante = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.TxtMontoTotal = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.cboRecaudador = New SaimtControles.SaimtComboBoxLookUp()
        Me.dtpRecfecPago = New SaimtControles.SaimtDateTimePicker()
        Me.TxtRecId = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.cboConceptos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpfechaliq.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpfechaliq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNroDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepositante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMontoTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRecaudador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRecfecPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRecfecPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRecId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 237)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(839, 27)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.cboConceptos)
        Me.SaimtGroupBox1.Controls.Add(Me.btnConsultarConyuge)
        Me.SaimtGroupBox1.Controls.Add(Me.btnfechaliqui)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel12)
        Me.SaimtGroupBox1.Controls.Add(Me.dtpfechaliq)
        Me.SaimtGroupBox1.Controls.Add(Me.TxtNroDoc)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel13)
        Me.SaimtGroupBox1.Controls.Add(Me.cboTipoDoc)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel11)
        Me.SaimtGroupBox1.Controls.Add(Me.txtDepositante)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel9)
        Me.SaimtGroupBox1.Controls.Add(Me.TxtMontoTotal)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox1.Controls.Add(Me.cboRecaudador)
        Me.SaimtGroupBox1.Controls.Add(Me.dtpRecfecPago)
        Me.SaimtGroupBox1.Controls.Add(Me.TxtRecId)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(815, 146)
        Me.SaimtGroupBox1.TabIndex = 2
        Me.SaimtGroupBox1.Text = "Datos de Recaudación"
        '
        'cboConceptos
        '
        Me.cboConceptos.Location = New System.Drawing.Point(385, 92)
        Me.cboConceptos.Name = "cboConceptos"
        Me.cboConceptos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConceptos.Properties.NullText = ""
        Me.cboConceptos.Size = New System.Drawing.Size(425, 20)
        Me.cboConceptos.TabIndex = 31
        '
        'btnConsultarConyuge
        '
        Me.btnConsultarConyuge.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnConsultarConyuge.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConsultarConyuge.Location = New System.Drawing.Point(786, 33)
        Me.btnConsultarConyuge.Name = "btnConsultarConyuge"
        Me.btnConsultarConyuge.Size = New System.Drawing.Size(21, 21)
        Me.btnConsultarConyuge.TabIndex = 30
        '
        'btnfechaliqui
        '
        Me.btnfechaliqui.Image = CType(resources.GetObject("btnfechaliqui.Image"), System.Drawing.Image)
        Me.btnfechaliqui.Location = New System.Drawing.Point(294, 119)
        Me.btnfechaliqui.Name = "btnfechaliqui"
        Me.btnfechaliqui.Size = New System.Drawing.Size(26, 23)
        Me.btnfechaliqui.TabIndex = 29
        Me.btnfechaliqui.ToolTip = "Actualizar Fecha de Liquidación"
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(295, 96)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(89, 13)
        Me.SaimtLabel12.TabIndex = 23
        Me.SaimtLabel12.Text = "Deposito al Código"
        '
        'dtpfechaliq
        '
        Me.dtpfechaliq.EditValue = Nothing
        Me.dtpfechaliq.Location = New System.Drawing.Point(112, 122)
        Me.dtpfechaliq.MenuManager = Me.RibbonControl
        Me.dtpfechaliq.Name = "dtpfechaliq"
        Me.dtpfechaliq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpfechaliq.Properties.NullText = "No hay Fecha de Liquidación"
        Me.dtpfechaliq.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpfechaliq.Size = New System.Drawing.Size(176, 20)
        Me.dtpfechaliq.TabIndex = 27
        '
        'TxtNroDoc
        '
        Me.TxtNroDoc.Location = New System.Drawing.Point(654, 62)
        Me.TxtNroDoc.MenuManager = Me.RibbonControl
        Me.TxtNroDoc.Name = "TxtNroDoc"
        Me.TxtNroDoc.Size = New System.Drawing.Size(156, 20)
        Me.TxtNroDoc.TabIndex = 22
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(9, 125)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(99, 13)
        Me.SaimtLabel13.TabIndex = 28
        Me.SaimtLabel13.Text = "Fecha de Liquidación"
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.Location = New System.Drawing.Point(385, 62)
        Me.cboTipoDoc.MenuManager = Me.RibbonControl
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoDoc.Properties.NullText = ""
        Me.cboTipoDoc.Size = New System.Drawing.Size(190, 20)
        Me.cboTipoDoc.TabIndex = 21
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(594, 65)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel11.TabIndex = 20
        Me.SaimtLabel11.Text = "Documento"
        '
        'txtDepositante
        '
        Me.txtDepositante.Location = New System.Drawing.Point(552, 34)
        Me.txtDepositante.MenuManager = Me.RibbonControl
        Me.txtDepositante.Name = "txtDepositante"
        Me.txtDepositante.Size = New System.Drawing.Size(228, 20)
        Me.txtDepositante.TabIndex = 19
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(303, 65)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(77, 13)
        Me.SaimtLabel10.TabIndex = 18
        Me.SaimtLabel10.Text = "Tipo Documento"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(488, 37)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel9.TabIndex = 17
        Me.SaimtLabel9.Text = "Depositante"
        '
        'TxtMontoTotal
        '
        Me.TxtMontoTotal.Location = New System.Drawing.Point(386, 34)
        Me.TxtMontoTotal.MenuManager = Me.RibbonControl
        Me.TxtMontoTotal.Name = "TxtMontoTotal"
        Me.TxtMontoTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtMontoTotal.Properties.Appearance.Options.UseFont = True
        Me.TxtMontoTotal.Properties.Mask.EditMask = "n2"
        Me.TxtMontoTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtMontoTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtMontoTotal.Size = New System.Drawing.Size(96, 20)
        Me.TxtMontoTotal.TabIndex = 16
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(323, 37)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(57, 13)
        Me.SaimtLabel8.TabIndex = 15
        Me.SaimtLabel8.Text = "Monto Total"
        '
        'cboRecaudador
        '
        Me.cboRecaudador.Location = New System.Drawing.Point(112, 93)
        Me.cboRecaudador.Name = "cboRecaudador"
        Me.cboRecaudador.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRecaudador.Properties.NullText = ""
        Me.cboRecaudador.Size = New System.Drawing.Size(176, 20)
        Me.cboRecaudador.TabIndex = 14
        '
        'dtpRecfecPago
        '
        Me.dtpRecfecPago.EditValue = Nothing
        Me.dtpRecfecPago.Location = New System.Drawing.Point(112, 62)
        Me.dtpRecfecPago.MenuManager = Me.RibbonControl
        Me.dtpRecfecPago.Name = "dtpRecfecPago"
        Me.dtpRecfecPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpRecfecPago.Properties.ReadOnly = True
        Me.dtpRecfecPago.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpRecfecPago.Size = New System.Drawing.Size(176, 20)
        Me.dtpRecfecPago.TabIndex = 4
        '
        'TxtRecId
        '
        Me.TxtRecId.Location = New System.Drawing.Point(112, 34)
        Me.TxtRecId.MenuManager = Me.RibbonControl
        Me.TxtRecId.Name = "TxtRecId"
        Me.TxtRecId.Properties.ReadOnly = True
        Me.TxtRecId.Size = New System.Drawing.Size(100, 20)
        Me.TxtRecId.TabIndex = 3
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(16, 96)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(90, 13)
        Me.SaimtLabel3.TabIndex = 2
        Me.SaimtLabel3.Text = "Inst. Recaudadora"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(50, 65)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(56, 13)
        Me.SaimtLabel2.TabIndex = 1
        Me.SaimtLabel2.Text = "Fecha Pago"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(19, 37)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(87, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Cod. Recaudación"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(762, 162)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        '
        'frmRecaudacionDiaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonGuardar = Me.btnGuardar
        Me.ClientSize = New System.Drawing.Size(839, 264)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmRecaudacionDiaria"
        Me.Text = "Recaudación"
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.cboConceptos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpfechaliq.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpfechaliq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNroDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepositante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMontoTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRecaudador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRecfecPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRecfecPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRecId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents dtpRecfecPago As SaimtControles.SaimtDateTimePicker
    Friend WithEvents TxtRecId As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents cboRecaudador As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents TxtMontoTotal As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents txtDepositante As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents TxtNroDoc As SaimtControles.SaimtTextBox
    Friend WithEvents cboTipoDoc As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents btnfechaliqui As SaimtControles.SaimtButton
    Friend WithEvents dtpfechaliq As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnConsultarConyuge As SaimtControles.SaimtButton
    Friend WithEvents cboConceptos As SaimtControles.SaimtComboBoxLookUp
End Class
