<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInmueblesFichaActualizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInmueblesFichaActualizacion))
        Me.grbDatosPersona = New SaimtControles.SaimtGroupBox()
        Me.txtInmUbicacion = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel30 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.txtInmCodigo = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel29 = New SaimtControles.SaimtLabel()
        Me.SaimtTextBox2 = New SaimtControles.SaimtTextBox()
        Me.fbdExportar = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.cboSupuestoUpd = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.txtCampoOld = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.txtCampoNew = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.cboCampoUpd = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.cboTipoUpd = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtFechaModificación = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.dtFechaDocUpd = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.txtDocUpd = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.dtFechaRegUpd = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtButton1 = New SaimtControles.SaimtButton()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.txtObservacion = New DevExpress.XtraEditors.MemoEdit()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.SaimtTabs1 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtMotivo = New DevExpress.XtraEditors.MemoEdit()
        Me.ofdExaminarArchivos = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosPersona.SuspendLayout()
        CType(Me.txtInmUbicacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInmCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTextBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.cboSupuestoUpd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCampoOld.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCampoNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCampoUpd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoUpd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaModificación.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.dtFechaDocUpd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaDocUpd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocUpd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.dtFechaRegUpd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaRegUpd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 658)
        '
        'grbDatosPersona
        '
        Me.grbDatosPersona.Controls.Add(Me.txtInmUbicacion)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel30)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel9)
        Me.grbDatosPersona.Controls.Add(Me.txtInmCodigo)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel29)
        Me.grbDatosPersona.Location = New System.Drawing.Point(9, 7)
        Me.grbDatosPersona.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbDatosPersona.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbDatosPersona.Name = "grbDatosPersona"
        Me.grbDatosPersona.Size = New System.Drawing.Size(564, 87)
        Me.grbDatosPersona.TabIndex = 0
        Me.grbDatosPersona.Text = "Datos del Ejido Municipal"
        '
        'txtInmUbicacion
        '
        Me.txtInmUbicacion.Location = New System.Drawing.Point(146, 55)
        Me.txtInmUbicacion.MenuManager = Me.RibbonControl
        Me.txtInmUbicacion.Name = "txtInmUbicacion"
        Me.txtInmUbicacion.Size = New System.Drawing.Size(382, 20)
        Me.txtInmUbicacion.TabIndex = 3
        '
        'SaimtLabel30
        '
        Me.SaimtLabel30.Location = New System.Drawing.Point(89, 58)
        Me.SaimtLabel30.Name = "SaimtLabel30"
        Me.SaimtLabel30.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel30.TabIndex = 2
        Me.SaimtLabel30.Text = "Inmueble :"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(39, 32)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(103, 13)
        Me.SaimtLabel9.TabIndex = 1
        Me.SaimtLabel9.Text = "Código Margesí MPT :"
        '
        'txtInmCodigo
        '
        Me.txtInmCodigo.EditValue = ""
        Me.txtInmCodigo.Location = New System.Drawing.Point(146, 29)
        Me.txtInmCodigo.Name = "txtInmCodigo"
        Me.txtInmCodigo.Size = New System.Drawing.Size(118, 20)
        Me.txtInmCodigo.TabIndex = 4
        '
        'SaimtLabel29
        '
        Me.SaimtLabel29.Location = New System.Drawing.Point(-289, -171)
        Me.SaimtLabel29.Name = "SaimtLabel29"
        Me.SaimtLabel29.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel29.TabIndex = 0
        Me.SaimtLabel29.Text = "Tipo Persona :"
        '
        'SaimtTextBox2
        '
        Me.SaimtTextBox2.Location = New System.Drawing.Point(7, 399)
        Me.SaimtTextBox2.MenuManager = Me.RibbonControl
        Me.SaimtTextBox2.Name = "SaimtTextBox2"
        Me.SaimtTextBox2.Size = New System.Drawing.Size(366, 20)
        Me.SaimtTextBox2.TabIndex = 7
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.cboSupuestoUpd)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox1.Controls.Add(Me.txtCampoOld)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox1.Controls.Add(Me.txtCampoNew)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox1.Controls.Add(Me.cboCampoUpd)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox1.Controls.Add(Me.cboTipoUpd)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Controls.Add(Me.txtFechaModificación)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(9, 97)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(564, 216)
        Me.SaimtGroupBox1.TabIndex = 2
        Me.SaimtGroupBox1.Text = "Datos de Actualización"
        '
        'cboSupuestoUpd
        '
        Me.cboSupuestoUpd.Location = New System.Drawing.Point(146, 77)
        Me.cboSupuestoUpd.MenuManager = Me.RibbonControl
        Me.cboSupuestoUpd.Name = "cboSupuestoUpd"
        Me.cboSupuestoUpd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSupuestoUpd.Properties.NullText = ""
        Me.cboSupuestoUpd.Size = New System.Drawing.Size(136, 20)
        Me.cboSupuestoUpd.TabIndex = 15
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(10, 129)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(140, 13)
        Me.SaimtLabel8.TabIndex = 14
        Me.SaimtLabel8.Text = "Información que se actualiza "
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(35, 158)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(104, 13)
        Me.SaimtLabel7.TabIndex = 12
        Me.SaimtLabel7.Text = "Información Antigua :"
        '
        'txtCampoOld
        '
        Me.txtCampoOld.EditValue = ""
        Me.txtCampoOld.Location = New System.Drawing.Point(146, 155)
        Me.txtCampoOld.Name = "txtCampoOld"
        Me.txtCampoOld.Size = New System.Drawing.Size(369, 20)
        Me.txtCampoOld.TabIndex = 13
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(42, 184)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(97, 13)
        Me.SaimtLabel6.TabIndex = 10
        Me.SaimtLabel6.Text = "Información Actual :"
        '
        'txtCampoNew
        '
        Me.txtCampoNew.EditValue = ""
        Me.txtCampoNew.Location = New System.Drawing.Point(146, 181)
        Me.txtCampoNew.Name = "txtCampoNew"
        Me.txtCampoNew.Size = New System.Drawing.Size(369, 20)
        Me.txtCampoNew.TabIndex = 11
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(8, 80)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(132, 13)
        Me.SaimtLabel5.TabIndex = 8
        Me.SaimtLabel5.Text = "Supuesto de Actualización :"
        '
        'cboCampoUpd
        '
        Me.cboCampoUpd.Location = New System.Drawing.Point(146, 103)
        Me.cboCampoUpd.MenuManager = Me.RibbonControl
        Me.cboCampoUpd.Name = "cboCampoUpd"
        Me.cboCampoUpd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCampoUpd.Properties.NullText = ""
        Me.cboCampoUpd.Size = New System.Drawing.Size(136, 20)
        Me.cboCampoUpd.TabIndex = 7
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(19, 106)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(120, 13)
        Me.SaimtLabel4.TabIndex = 6
        Me.SaimtLabel4.Text = "Campo de Actualización :"
        '
        'cboTipoUpd
        '
        Me.cboTipoUpd.Location = New System.Drawing.Point(146, 51)
        Me.cboTipoUpd.MenuManager = Me.RibbonControl
        Me.cboTipoUpd.Name = "cboTipoUpd"
        Me.cboTipoUpd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoUpd.Properties.NullText = ""
        Me.cboTipoUpd.Size = New System.Drawing.Size(136, 20)
        Me.cboTipoUpd.TabIndex = 5
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(36, 54)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(103, 13)
        Me.SaimtLabel1.TabIndex = 2
        Me.SaimtLabel1.Text = "Tipo de Modificación :"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(28, 28)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(112, 13)
        Me.SaimtLabel2.TabIndex = 1
        Me.SaimtLabel2.Text = "Fecha de Modificación :"
        '
        'txtFechaModificación
        '
        Me.txtFechaModificación.EditValue = ""
        Me.txtFechaModificación.Location = New System.Drawing.Point(146, 25)
        Me.txtFechaModificación.Name = "txtFechaModificación"
        Me.txtFechaModificación.Size = New System.Drawing.Size(136, 20)
        Me.txtFechaModificación.TabIndex = 4
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(-289, -171)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel3.TabIndex = 0
        Me.SaimtLabel3.Text = "Tipo Persona :"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.dtFechaDocUpd)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel11)
        Me.SaimtGroupBox2.Controls.Add(Me.txtDocUpd)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel12)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(9, 319)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(564, 52)
        Me.SaimtGroupBox2.TabIndex = 3
        Me.SaimtGroupBox2.Text = "Autorizacón"
        '
        'dtFechaDocUpd
        '
        Me.dtFechaDocUpd.EditValue = Nothing
        Me.dtFechaDocUpd.Location = New System.Drawing.Point(422, 25)
        Me.dtFechaDocUpd.MenuManager = Me.RibbonControl
        Me.dtFechaDocUpd.Name = "dtFechaDocUpd"
        Me.dtFechaDocUpd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaDocUpd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFechaDocUpd.Size = New System.Drawing.Size(93, 20)
        Me.dtFechaDocUpd.TabIndex = 5
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(306, 28)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(110, 13)
        Me.SaimtLabel10.TabIndex = 2
        Me.SaimtLabel10.Text = "Fecha del Documento :"
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(22, 28)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(61, 13)
        Me.SaimtLabel11.TabIndex = 1
        Me.SaimtLabel11.Text = "Documento :"
        '
        'txtDocUpd
        '
        Me.txtDocUpd.EditValue = ""
        Me.txtDocUpd.Location = New System.Drawing.Point(89, 25)
        Me.txtDocUpd.Name = "txtDocUpd"
        Me.txtDocUpd.Size = New System.Drawing.Size(211, 20)
        Me.txtDocUpd.TabIndex = 4
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(-289, -171)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel12.TabIndex = 0
        Me.SaimtLabel12.Text = "Tipo Persona :"
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Controls.Add(Me.dtFechaRegUpd)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtButton1)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel14)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel15)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(9, 376)
        Me.SaimtGroupBox3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.ShowCaption = False
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(564, 32)
        Me.SaimtGroupBox3.TabIndex = 4
        '
        'dtFechaRegUpd
        '
        Me.dtFechaRegUpd.EditValue = Nothing
        Me.dtFechaRegUpd.Location = New System.Drawing.Point(218, 6)
        Me.dtFechaRegUpd.MenuManager = Me.RibbonControl
        Me.dtFechaRegUpd.Name = "dtFechaRegUpd"
        Me.dtFechaRegUpd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaRegUpd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFechaRegUpd.Size = New System.Drawing.Size(136, 20)
        Me.dtFechaRegUpd.TabIndex = 6
        '
        'SaimtButton1
        '
        Me.SaimtButton1.Location = New System.Drawing.Point(458, 4)
        Me.SaimtButton1.Name = "SaimtButton1"
        Me.SaimtButton1.Size = New System.Drawing.Size(101, 23)
        Me.SaimtButton1.TabIndex = 1
        Me.SaimtButton1.Text = "Editar Inmueble"
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(8, 9)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(204, 13)
        Me.SaimtLabel14.TabIndex = 1
        Me.SaimtLabel14.Text = "FECHA DE REGISTRO DE ACTUALIZACIÓN"
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(-289, -191)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel15.TabIndex = 0
        Me.SaimtLabel15.Text = "Tipo Persona :"
        '
        'txtObservacion
        '
        Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservacion.EditValue = ""
        Me.txtObservacion.Location = New System.Drawing.Point(0, 0)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(488, 213)
        Me.txtObservacion.TabIndex = 5
        Me.txtObservacion.UseOptimizedRendering = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImprimir.Location = New System.Drawing.Point(509, 567)
        Me.btnImprimir.LookAndFeel.SkinName = "Seven"
        Me.btnImprimir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 64)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(509, 427)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(509, 497)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        '
        'SaimtTabs1
        '
        Me.SaimtTabs1.Location = New System.Drawing.Point(9, 411)
        Me.SaimtTabs1.Name = "SaimtTabs1"
        Me.SaimtTabs1.SelectedTabPage = Me.XtraTabPage1
        Me.SaimtTabs1.Size = New System.Drawing.Size(494, 241)
        Me.SaimtTabs1.TabIndex = 12
        Me.SaimtTabs1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txtObservacion)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(488, 213)
        Me.XtraTabPage1.Text = "Observación"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtMotivo)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(488, 213)
        Me.XtraTabPage2.Text = "Motivo de Actualización"
        '
        'txtMotivo
        '
        Me.txtMotivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMotivo.EditValue = ""
        Me.txtMotivo.Location = New System.Drawing.Point(0, 0)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(488, 215)
        Me.txtMotivo.TabIndex = 6
        Me.txtMotivo.UseOptimizedRendering = True
        '
        'ofdExaminarArchivos
        '
        Me.ofdExaminarArchivos.FileName = "OpenFileDialog1"
        '
        'frmInmueblesFichaActualizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonImprimir = Me.btnImprimir
        Me.ClientSize = New System.Drawing.Size(585, 685)
        Me.Controls.Add(Me.SaimtTabs1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.SaimtGroupBox3)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.grbDatosPersona)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmInmueblesFichaActualizacion"
        Me.ShowIcon = False
        Me.Tag = ""
        Me.Text = "FICHA DE ACTUALIZACIÓN DE INFORMACIÓN DE EJIDO MUNICIPAL"
        Me.Controls.SetChildIndex(Me.grbDatosPersona, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox3, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.SaimtTabs1, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosPersona.ResumeLayout(False)
        Me.grbDatosPersona.PerformLayout()
        CType(Me.txtInmUbicacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInmCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTextBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.cboSupuestoUpd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCampoOld.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCampoNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCampoUpd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoUpd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaModificación.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.dtFechaDocUpd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaDocUpd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocUpd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        Me.SaimtGroupBox3.PerformLayout()
        CType(Me.dtFechaRegUpd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaRegUpd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDatosPersona As SaimtControles.SaimtGroupBox
    Friend WithEvents txtInmUbicacion As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel30 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents txtInmCodigo As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel29 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtTextBox2 As SaimtControles.SaimtTextBox
    Friend WithEvents fbdExportar As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents txtCampoOld As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents txtCampoNew As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents cboCampoUpd As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoUpd As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtFechaModificación As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents dtFechaDocUpd As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents txtDocUpd As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents dtFechaRegUpd As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents txtObservacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents SaimtTabs1 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ofdExaminarArchivos As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cboSupuestoUpd As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtButton1 As SaimtControles.SaimtButton
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtMotivo As DevExpress.XtraEditors.MemoEdit
End Class
