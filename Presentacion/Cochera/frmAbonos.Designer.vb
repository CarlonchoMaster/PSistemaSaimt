<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbonos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbonos))
        Me.grbDatosPersona = New SaimtControles.SaimtGroupBox()
        Me.txtTipoDocumento = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel30 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.txtPerId = New SaimtControles.SaimtTextBox()
        Me.txtObsPer = New SaimtControles.SaimtTextBoxMultiline()
        Me.cboTipoPersona = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtDireccion = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel17 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel19 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel22 = New SaimtControles.SaimtLabel()
        Me.btnBuscarPersona = New SaimtControles.SaimtButton()
        Me.SaimtLabel29 = New SaimtControles.SaimtLabel()
        Me.txtNombreRazon = New SaimtControles.SaimtTextBox()
        Me.txtNroDocumento = New SaimtControles.SaimtTextBox()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.btnCancelarContrato = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.SaimtLabel21 = New SaimtControles.SaimtLabel()
        Me.dtpHoraIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.chkAplicaHora = New SaimtControles.SaimtCheckBox()
        Me.cboEstado = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel20 = New SaimtControles.SaimtLabel()
        Me.chkConsiderarEspacio = New SaimtControles.SaimtCheckBox()
        Me.cboTipoVehiculo = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel16 = New SaimtControles.SaimtLabel()
        Me.txtNroMeses = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.txtPlaca3 = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.spnNroEspacio = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.cboNivel = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.txtPlaca2 = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.txtNroContratoAbono = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.txtMontoPagar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.txtPlaca1 = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.dtpFechaFin = New SaimtControles.SaimtDateTimePicker()
        Me.dtpFechaInicio = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.cboConceptoAbono = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscarContratoPor = New SaimtControles.SaimtTextBox()
        Me.cboBuscarContratoPor = New SaimtControles.SaimtComboBox()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoContratos = New SaimtControles.SaimtDataGrid()
        Me.gvListadoContratos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgvListadoPersona = New SaimtControles.SaimtDataGrid()
        Me.gvListadoPersona = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboBuscarPersonaPor1 = New SaimtControles.SaimtComboBoxLookUp()
        Me.txtBuscarPersonaPor = New SaimtControles.SaimtTextBox()
        Me.cboBuscarPersonaPor = New SaimtControles.SaimtComboBox()
        Me.SaimtLabel18 = New SaimtControles.SaimtLabel()
        Me.SaimtTextBox2 = New SaimtControles.SaimtTextBox()
        Me.fbdExportar = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosPersona.SuspendLayout()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObsPer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreRazon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.chkAplicaHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkConsiderarEspacio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoVehiculo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroMeses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnNroEspacio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroContratoAbono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConceptoAbono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.dgvListadoContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarPersonaPor1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTextBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 691)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(963, 27)
        '
        'grbDatosPersona
        '
        Me.grbDatosPersona.Controls.Add(Me.txtTipoDocumento)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel30)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel10)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel9)
        Me.grbDatosPersona.Controls.Add(Me.txtPerId)
        Me.grbDatosPersona.Controls.Add(Me.txtObsPer)
        Me.grbDatosPersona.Controls.Add(Me.cboTipoPersona)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel3)
        Me.grbDatosPersona.Controls.Add(Me.txtDireccion)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel17)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel19)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel22)
        Me.grbDatosPersona.Controls.Add(Me.btnBuscarPersona)
        Me.grbDatosPersona.Controls.Add(Me.SaimtLabel29)
        Me.grbDatosPersona.Controls.Add(Me.txtNombreRazon)
        Me.grbDatosPersona.Controls.Add(Me.txtNroDocumento)
        Me.grbDatosPersona.Location = New System.Drawing.Point(4, 10)
        Me.grbDatosPersona.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbDatosPersona.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbDatosPersona.Name = "grbDatosPersona"
        Me.grbDatosPersona.Size = New System.Drawing.Size(537, 191)
        Me.grbDatosPersona.TabIndex = 0
        Me.grbDatosPersona.Text = "Datos de Persona"
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.Location = New System.Drawing.Point(321, 30)
        Me.txtTipoDocumento.MenuManager = Me.RibbonControl
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.Size = New System.Drawing.Size(179, 20)
        Me.txtTipoDocumento.TabIndex = 3
        '
        'SaimtLabel30
        '
        Me.SaimtLabel30.Location = New System.Drawing.Point(271, 34)
        Me.SaimtLabel30.Name = "SaimtLabel30"
        Me.SaimtLabel30.Size = New System.Drawing.Size(45, 13)
        Me.SaimtLabel30.TabIndex = 2
        Me.SaimtLabel30.Text = "Tipo Doc."
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(35, 61)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel10.TabIndex = 6
        Me.SaimtLabel10.Text = "Tipo Persona :"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(36, 34)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(68, 13)
        Me.SaimtLabel9.TabIndex = 1
        Me.SaimtLabel9.Text = "Cod Persona :"
        '
        'txtPerId
        '
        Me.txtPerId.EditValue = ""
        Me.txtPerId.Location = New System.Drawing.Point(110, 31)
        Me.txtPerId.Name = "txtPerId"
        Me.txtPerId.Size = New System.Drawing.Size(139, 20)
        Me.txtPerId.TabIndex = 4
        '
        'txtObsPer
        '
        Me.txtObsPer.Location = New System.Drawing.Point(110, 124)
        Me.txtObsPer.MenuManager = Me.RibbonControl
        Me.txtObsPer.Name = "txtObsPer"
        Me.txtObsPer.Size = New System.Drawing.Size(390, 35)
        Me.txtObsPer.TabIndex = 15
        Me.txtObsPer.UseOptimizedRendering = True
        '
        'cboTipoPersona
        '
        Me.cboTipoPersona.Location = New System.Drawing.Point(110, 57)
        Me.cboTipoPersona.Name = "cboTipoPersona"
        Me.cboTipoPersona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoPersona.Properties.NullText = ""
        Me.cboTipoPersona.Size = New System.Drawing.Size(139, 20)
        Me.cboTipoPersona.TabIndex = 8
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(37, 127)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel3.TabIndex = 14
        Me.SaimtLabel3.Text = "Observación :"
        '
        'txtDireccion
        '
        Me.txtDireccion.EditValue = ""
        Me.txtDireccion.Location = New System.Drawing.Point(110, 101)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(390, 20)
        Me.txtDireccion.TabIndex = 13
        '
        'SaimtLabel17
        '
        Me.SaimtLabel17.Location = New System.Drawing.Point(54, 104)
        Me.SaimtLabel17.Name = "SaimtLabel17"
        Me.SaimtLabel17.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel17.TabIndex = 12
        Me.SaimtLabel17.Text = "Dirección :"
        '
        'SaimtLabel19
        '
        Me.SaimtLabel19.Location = New System.Drawing.Point(13, 80)
        Me.SaimtLabel19.Name = "SaimtLabel19"
        Me.SaimtLabel19.Size = New System.Drawing.Size(91, 13)
        Me.SaimtLabel19.TabIndex = 9
        Me.SaimtLabel19.Text = "Nombres o Razon :"
        '
        'SaimtLabel22
        '
        Me.SaimtLabel22.Location = New System.Drawing.Point(266, 57)
        Me.SaimtLabel22.Name = "SaimtLabel22"
        Me.SaimtLabel22.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel22.TabIndex = 5
        Me.SaimtLabel22.Text = "Nro. Doc.:"
        '
        'btnBuscarPersona
        '
        Me.btnBuscarPersona.Image = CType(resources.GetObject("btnBuscarPersona.Image"), System.Drawing.Image)
        Me.btnBuscarPersona.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBuscarPersona.Location = New System.Drawing.Point(476, 78)
        Me.btnBuscarPersona.Name = "btnBuscarPersona"
        Me.btnBuscarPersona.Size = New System.Drawing.Size(21, 21)
        Me.btnBuscarPersona.TabIndex = 11
        '
        'SaimtLabel29
        '
        Me.SaimtLabel29.Location = New System.Drawing.Point(-289, -171)
        Me.SaimtLabel29.Name = "SaimtLabel29"
        Me.SaimtLabel29.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel29.TabIndex = 0
        Me.SaimtLabel29.Text = "Tipo Persona :"
        '
        'txtNombreRazon
        '
        Me.txtNombreRazon.EditValue = ""
        Me.txtNombreRazon.Location = New System.Drawing.Point(110, 79)
        Me.txtNombreRazon.Name = "txtNombreRazon"
        Me.txtNombreRazon.Size = New System.Drawing.Size(360, 20)
        Me.txtNombreRazon.TabIndex = 10
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.EditValue = ""
        Me.txtNroDocumento.Location = New System.Drawing.Point(322, 54)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(144, 20)
        Me.txtNroDocumento.TabIndex = 7
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(39, 598)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(239, 598)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(169, 598)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(309, 598)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.btnEditar)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.btnImprimir)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.btnCancelarContrato)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.grbDatosPersona)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.btnNuevo)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.btnCancelar)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtGroupBox2)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.btnLimpiar)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.btnGuardar)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.txtBuscarContratoPor)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.cboBuscarContratoPor)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.dgvListadoPersona)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.cboBuscarPersonaPor1)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.txtBuscarPersonaPor)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.cboBuscarPersonaPor)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtLabel18)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(963, 691)
        Me.SaimtSplitContainerControl1.SplitterPosition = 547
        Me.SaimtSplitContainerControl1.TabIndex = 0
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(104, 598)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 17
        Me.btnEditar.Text = "Editar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImprimir.Location = New System.Drawing.Point(379, 598)
        Me.btnImprimir.LookAndFeel.SkinName = "Seven"
        Me.btnImprimir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 64)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCancelarContrato
        '
        Me.btnCancelarContrato.Image = CType(resources.GetObject("btnCancelarContrato.Image"), System.Drawing.Image)
        Me.btnCancelarContrato.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelarContrato.Location = New System.Drawing.Point(448, 598)
        Me.btnCancelarContrato.LookAndFeel.SkinName = "Seven"
        Me.btnCancelarContrato.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelarContrato.Name = "btnCancelarContrato"
        Me.btnCancelarContrato.Size = New System.Drawing.Size(68, 64)
        Me.btnCancelarContrato.TabIndex = 8
        Me.btnCancelarContrato.Text = "Resindir Contrato"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel21)
        Me.SaimtGroupBox2.Controls.Add(Me.dtpHoraIngreso)
        Me.SaimtGroupBox2.Controls.Add(Me.dtpHoraFin)
        Me.SaimtGroupBox2.Controls.Add(Me.chkAplicaHora)
        Me.SaimtGroupBox2.Controls.Add(Me.cboEstado)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel20)
        Me.SaimtGroupBox2.Controls.Add(Me.chkConsiderarEspacio)
        Me.SaimtGroupBox2.Controls.Add(Me.cboTipoVehiculo)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel16)
        Me.SaimtGroupBox2.Controls.Add(Me.txtNroMeses)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel15)
        Me.SaimtGroupBox2.Controls.Add(Me.txtPlaca3)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel14)
        Me.SaimtGroupBox2.Controls.Add(Me.spnNroEspacio)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel13)
        Me.SaimtGroupBox2.Controls.Add(Me.cboNivel)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel12)
        Me.SaimtGroupBox2.Controls.Add(Me.txtPlaca2)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel11)
        Me.SaimtGroupBox2.Controls.Add(Me.txtNroContratoAbono)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox2.Controls.Add(Me.txtMontoPagar)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox2.Controls.Add(Me.txtPlaca1)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox2.Controls.Add(Me.dtpFechaFin)
        Me.SaimtGroupBox2.Controls.Add(Me.dtpFechaInicio)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox2.Controls.Add(Me.cboConceptoAbono)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(6, 209)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(535, 356)
        Me.SaimtGroupBox2.TabIndex = 1
        Me.SaimtGroupBox2.Text = "Datos para el Abono"
        '
        'SaimtLabel21
        '
        Me.SaimtLabel21.Location = New System.Drawing.Point(277, 178)
        Me.SaimtLabel21.Name = "SaimtLabel21"
        Me.SaimtLabel21.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel21.TabIndex = 32
        Me.SaimtLabel21.Text = "Hora Salida"
        '
        'dtpHoraIngreso
        '
        Me.dtpHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraIngreso.Location = New System.Drawing.Point(85, 172)
        Me.dtpHoraIngreso.Name = "dtpHoraIngreso"
        Me.dtpHoraIngreso.Size = New System.Drawing.Size(127, 21)
        Me.dtpHoraIngreso.TabIndex = 31
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFin.Location = New System.Drawing.Point(335, 172)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.Size = New System.Drawing.Size(118, 21)
        Me.dtpHoraFin.TabIndex = 30
        '
        'chkAplicaHora
        '
        Me.chkAplicaHora.Location = New System.Drawing.Point(8, 172)
        Me.chkAplicaHora.MenuManager = Me.RibbonControl
        Me.chkAplicaHora.Name = "chkAplicaHora"
        Me.chkAplicaHora.Properties.AutoWidth = True
        Me.chkAplicaHora.Properties.Caption = "Hora Inicio"
        Me.chkAplicaHora.Size = New System.Drawing.Size(73, 19)
        Me.chkAplicaHora.TabIndex = 29
        '
        'cboEstado
        '
        Me.cboEstado.Location = New System.Drawing.Point(85, 111)
        Me.cboEstado.MenuManager = Me.RibbonControl
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstado.Properties.NullText = ""
        Me.cboEstado.Size = New System.Drawing.Size(127, 20)
        Me.cboEstado.TabIndex = 28
        '
        'SaimtLabel20
        '
        Me.SaimtLabel20.Location = New System.Drawing.Point(3, 114)
        Me.SaimtLabel20.Name = "SaimtLabel20"
        Me.SaimtLabel20.Size = New System.Drawing.Size(79, 13)
        Me.SaimtLabel20.TabIndex = 27
        Me.SaimtLabel20.Text = "Estado Contrato"
        '
        'chkConsiderarEspacio
        '
        Me.chkConsiderarEspacio.Location = New System.Drawing.Point(333, 307)
        Me.chkConsiderarEspacio.MenuManager = Me.RibbonControl
        Me.chkConsiderarEspacio.Name = "chkConsiderarEspacio"
        Me.chkConsiderarEspacio.Properties.AutoWidth = True
        Me.chkConsiderarEspacio.Properties.Caption = "Considerar N° de espacio"
        Me.chkConsiderarEspacio.Size = New System.Drawing.Size(143, 19)
        Me.chkConsiderarEspacio.TabIndex = 26
        '
        'cboTipoVehiculo
        '
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(271, 31)
        Me.cboTipoVehiculo.MenuManager = Me.RibbonControl
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoVehiculo.Properties.NullText = ""
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(167, 20)
        Me.cboTipoVehiculo.TabIndex = 3
        '
        'SaimtLabel16
        '
        Me.SaimtLabel16.Location = New System.Drawing.Point(201, 34)
        Me.SaimtLabel16.Name = "SaimtLabel16"
        Me.SaimtLabel16.Size = New System.Drawing.Size(62, 13)
        Me.SaimtLabel16.TabIndex = 2
        Me.SaimtLabel16.Text = "Tipo Vehiculo"
        '
        'txtNroMeses
        '
        Me.txtNroMeses.Location = New System.Drawing.Point(335, 281)
        Me.txtNroMeses.MenuManager = Me.RibbonControl
        Me.txtNroMeses.Name = "txtNroMeses"
        Me.txtNroMeses.Size = New System.Drawing.Size(118, 20)
        Me.txtNroMeses.TabIndex = 23
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(286, 284)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(45, 13)
        Me.SaimtLabel15.TabIndex = 22
        Me.SaimtLabel15.Text = "N° Meses"
        '
        'txtPlaca3
        '
        Me.txtPlaca3.Location = New System.Drawing.Point(335, 255)
        Me.txtPlaca3.MenuManager = Me.RibbonControl
        Me.txtPlaca3.Name = "txtPlaca3"
        Me.txtPlaca3.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca3.Properties.MaxLength = 8
        Me.txtPlaca3.Size = New System.Drawing.Size(118, 20)
        Me.txtPlaca3.TabIndex = 19
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(297, 258)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(34, 13)
        Me.SaimtLabel14.TabIndex = 18
        Me.SaimtLabel14.Text = "Placa 3"
        '
        'spnNroEspacio
        '
        Me.spnNroEspacio.EditValue = New Decimal(New Integer() {101, 0, 0, 0})
        Me.spnNroEspacio.Location = New System.Drawing.Point(85, 227)
        Me.spnNroEspacio.MenuManager = Me.RibbonControl
        Me.spnNroEspacio.Name = "spnNroEspacio"
        Me.spnNroEspacio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spnNroEspacio.Properties.Mask.EditMask = "n0"
        Me.spnNroEspacio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.spnNroEspacio.Properties.MaxValue = New Decimal(New Integer() {334, 0, 0, 0})
        Me.spnNroEspacio.Size = New System.Drawing.Size(127, 20)
        Me.spnNroEspacio.TabIndex = 21
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(22, 230)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(60, 13)
        Me.SaimtLabel13.TabIndex = 20
        Me.SaimtLabel13.Text = "Nro. Espacio"
        '
        'cboNivel
        '
        Me.cboNivel.Location = New System.Drawing.Point(85, 199)
        Me.cboNivel.MenuManager = Me.RibbonControl
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNivel.Properties.NullText = ""
        Me.cboNivel.Size = New System.Drawing.Size(127, 20)
        Me.cboNivel.TabIndex = 17
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(58, 202)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(23, 13)
        Me.SaimtLabel12.TabIndex = 15
        Me.SaimtLabel12.Text = "Nivel"
        '
        'txtPlaca2
        '
        Me.txtPlaca2.Location = New System.Drawing.Point(335, 229)
        Me.txtPlaca2.MenuManager = Me.RibbonControl
        Me.txtPlaca2.Name = "txtPlaca2"
        Me.txtPlaca2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca2.Properties.MaxLength = 8
        Me.txtPlaca2.Size = New System.Drawing.Size(118, 20)
        Me.txtPlaca2.TabIndex = 16
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(297, 232)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(34, 13)
        Me.SaimtLabel11.TabIndex = 14
        Me.SaimtLabel11.Text = "Placa 2"
        '
        'txtNroContratoAbono
        '
        Me.txtNroContratoAbono.Location = New System.Drawing.Point(80, 31)
        Me.txtNroContratoAbono.MenuManager = Me.RibbonControl
        Me.txtNroContratoAbono.Name = "txtNroContratoAbono"
        Me.txtNroContratoAbono.Properties.ReadOnly = True
        Me.txtNroContratoAbono.Size = New System.Drawing.Size(100, 20)
        Me.txtNroContratoAbono.TabIndex = 1
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(16, 34)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel8.TabIndex = 0
        Me.SaimtLabel8.Text = "N° Contrato"
        '
        'txtMontoPagar
        '
        Me.txtMontoPagar.EditValue = "0"
        Me.txtMontoPagar.Location = New System.Drawing.Point(85, 257)
        Me.txtMontoPagar.MenuManager = Me.RibbonControl
        Me.txtMontoPagar.Name = "txtMontoPagar"
        Me.txtMontoPagar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMontoPagar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMontoPagar.Properties.Mask.EditMask = "n2"
        Me.txtMontoPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoPagar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoPagar.Size = New System.Drawing.Size(127, 20)
        Me.txtMontoPagar.TabIndex = 25
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(12, 260)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(70, 13)
        Me.SaimtLabel7.TabIndex = 24
        Me.SaimtLabel7.Text = "Monto a Pagar"
        '
        'txtPlaca1
        '
        Me.txtPlaca1.Location = New System.Drawing.Point(335, 202)
        Me.txtPlaca1.MenuManager = Me.RibbonControl
        Me.txtPlaca1.Name = "txtPlaca1"
        Me.txtPlaca1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca1.Properties.MaxLength = 8
        Me.txtPlaca1.Size = New System.Drawing.Size(118, 20)
        Me.txtPlaca1.TabIndex = 13
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(297, 205)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(34, 13)
        Me.SaimtLabel6.TabIndex = 11
        Me.SaimtLabel6.Text = "Placa 1"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.EditValue = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(335, 141)
        Me.dtpFechaFin.MenuManager = Me.RibbonControl
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaFin.Size = New System.Drawing.Size(118, 20)
        Me.dtpFechaFin.TabIndex = 9
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.EditValue = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(85, 141)
        Me.dtpFechaInicio.MenuManager = Me.RibbonControl
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaInicio.Size = New System.Drawing.Size(127, 20)
        Me.dtpFechaInicio.TabIndex = 7
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(260, 144)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(70, 13)
        Me.SaimtLabel4.TabIndex = 8
        Me.SaimtLabel4.Text = "Fecha Término"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(25, 144)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(57, 13)
        Me.SaimtLabel2.TabIndex = 6
        Me.SaimtLabel2.Text = "Fecha Inicio"
        '
        'cboConceptoAbono
        '
        Me.cboConceptoAbono.Location = New System.Drawing.Point(9, 79)
        Me.cboConceptoAbono.MenuManager = Me.RibbonControl
        Me.cboConceptoAbono.Name = "cboConceptoAbono"
        Me.cboConceptoAbono.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConceptoAbono.Properties.NullText = ""
        Me.cboConceptoAbono.Size = New System.Drawing.Size(519, 20)
        Me.cboConceptoAbono.TabIndex = 5
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(11, 63)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(156, 13)
        Me.SaimtLabel1.TabIndex = 4
        Me.SaimtLabel1.Text = "Seleccione Concepto del Servicio"
        '
        'txtBuscarContratoPor
        '
        Me.txtBuscarContratoPor.Location = New System.Drawing.Point(7, 399)
        Me.txtBuscarContratoPor.MenuManager = Me.RibbonControl
        Me.txtBuscarContratoPor.Name = "txtBuscarContratoPor"
        Me.txtBuscarContratoPor.Size = New System.Drawing.Size(392, 20)
        Me.txtBuscarContratoPor.TabIndex = 7
        Me.txtBuscarContratoPor.Tag = "0"
        '
        'cboBuscarContratoPor
        '
        Me.cboBuscarContratoPor.EditValue = "Busqueda por Cod. Persona"
        Me.cboBuscarContratoPor.Location = New System.Drawing.Point(7, 376)
        Me.cboBuscarContratoPor.MenuManager = Me.RibbonControl
        Me.cboBuscarContratoPor.Name = "cboBuscarContratoPor"
        Me.cboBuscarContratoPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarContratoPor.Properties.Items.AddRange(New Object() {"Busqueda por Cod. Persona", "Busqueda por N° Contrato", "Busqueda por Placa"})
        Me.cboBuscarContratoPor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBuscarContratoPor.Size = New System.Drawing.Size(392, 20)
        Me.cboBuscarContratoPor.TabIndex = 6
        Me.cboBuscarContratoPor.Tag = "0"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.dgvListadoContratos)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(2, 425)
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(397, 265)
        Me.SaimtGroupBox1.TabIndex = 5
        Me.SaimtGroupBox1.Text = "Contratos"
        '
        'dgvListadoContratos
        '
        Me.dgvListadoContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoContratos.Location = New System.Drawing.Point(2, 21)
        Me.dgvListadoContratos.MainView = Me.gvListadoContratos
        Me.dgvListadoContratos.MenuManager = Me.RibbonControl
        Me.dgvListadoContratos.Name = "dgvListadoContratos"
        Me.dgvListadoContratos.Size = New System.Drawing.Size(393, 242)
        Me.dgvListadoContratos.TabIndex = 0
        Me.dgvListadoContratos.Tag = "0"
        Me.dgvListadoContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoContratos})
        '
        'gvListadoContratos
        '
        Me.gvListadoContratos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.gvListadoContratos.GridControl = Me.dgvListadoContratos
        Me.gvListadoContratos.Name = "gvListadoContratos"
        Me.gvListadoContratos.OptionsBehavior.ReadOnly = True
        Me.gvListadoContratos.OptionsView.ColumnAutoWidth = False
        Me.gvListadoContratos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "N° Contrato"
        Me.GridColumn5.FieldName = "AbonId"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha Inicio"
        Me.GridColumn6.FieldName = "AbonFechaIni"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha Fin"
        Me.GridColumn7.FieldName = "AbonFechaFin"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Monto a Pagar"
        Me.GridColumn8.FieldName = "AbonImporte"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        '
        'dgvListadoPersona
        '
        Me.dgvListadoPersona.Location = New System.Drawing.Point(2, 90)
        Me.dgvListadoPersona.MainView = Me.gvListadoPersona
        Me.dgvListadoPersona.MenuManager = Me.RibbonControl
        Me.dgvListadoPersona.Name = "dgvListadoPersona"
        Me.dgvListadoPersona.Size = New System.Drawing.Size(397, 280)
        Me.dgvListadoPersona.TabIndex = 4
        Me.dgvListadoPersona.Tag = "0"
        Me.dgvListadoPersona.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoPersona})
        '
        'gvListadoPersona
        '
        Me.gvListadoPersona.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.gvListadoPersona.GridControl = Me.dgvListadoPersona
        Me.gvListadoPersona.Name = "gvListadoPersona"
        Me.gvListadoPersona.OptionsBehavior.ReadOnly = True
        Me.gvListadoPersona.OptionsFind.AlwaysVisible = True
        Me.gvListadoPersona.OptionsView.ColumnAutoWidth = False
        Me.gvListadoPersona.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Persona"
        Me.GridColumn1.FieldName = "Persona"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tipo Doc."
        Me.GridColumn2.FieldName = "TgTipoDoc"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "N° Documento"
        Me.GridColumn3.FieldName = "PerNdoc"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cod. Persona"
        Me.GridColumn4.FieldName = "PerId"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'cboBuscarPersonaPor1
        '
        Me.cboBuscarPersonaPor1.Location = New System.Drawing.Point(7, 42)
        Me.cboBuscarPersonaPor1.MenuManager = Me.RibbonControl
        Me.cboBuscarPersonaPor1.Name = "cboBuscarPersonaPor1"
        Me.cboBuscarPersonaPor1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarPersonaPor1.Properties.NullText = ""
        Me.cboBuscarPersonaPor1.Size = New System.Drawing.Size(390, 20)
        Me.cboBuscarPersonaPor1.TabIndex = 3
        Me.cboBuscarPersonaPor1.Tag = "0"
        '
        'txtBuscarPersonaPor
        '
        Me.txtBuscarPersonaPor.Location = New System.Drawing.Point(7, 66)
        Me.txtBuscarPersonaPor.MenuManager = Me.RibbonControl
        Me.txtBuscarPersonaPor.Name = "txtBuscarPersonaPor"
        Me.txtBuscarPersonaPor.Size = New System.Drawing.Size(390, 20)
        Me.txtBuscarPersonaPor.TabIndex = 2
        '
        'cboBuscarPersonaPor
        '
        Me.cboBuscarPersonaPor.EditValue = "Busqueda por Apellidos y Nombres"
        Me.cboBuscarPersonaPor.Location = New System.Drawing.Point(7, 18)
        Me.cboBuscarPersonaPor.MenuManager = Me.RibbonControl
        Me.cboBuscarPersonaPor.Name = "cboBuscarPersonaPor"
        Me.cboBuscarPersonaPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarPersonaPor.Properties.Items.AddRange(New Object() {"Busqueda por Apellidos y Nombres", "Busqueda por Tipo y  N° Documento", "Busqueda por Placa 1", "Busqueda por Placa 2", "Busqueda por Placa 3"})
        Me.cboBuscarPersonaPor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBuscarPersonaPor.Size = New System.Drawing.Size(390, 20)
        Me.cboBuscarPersonaPor.TabIndex = 1
        Me.cboBuscarPersonaPor.Tag = "0"
        '
        'SaimtLabel18
        '
        Me.SaimtLabel18.Location = New System.Drawing.Point(8, 3)
        Me.SaimtLabel18.Name = "SaimtLabel18"
        Me.SaimtLabel18.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel18.TabIndex = 0
        Me.SaimtLabel18.Text = "Buscar por"
        '
        'SaimtTextBox2
        '
        Me.SaimtTextBox2.Location = New System.Drawing.Point(7, 399)
        Me.SaimtTextBox2.MenuManager = Me.RibbonControl
        Me.SaimtTextBox2.Name = "SaimtTextBox2"
        Me.SaimtTextBox2.Size = New System.Drawing.Size(366, 20)
        Me.SaimtTextBox2.TabIndex = 7
        '
        'frmAbonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(963, 718)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmAbonos"
        Me.ShowIcon = False
        Me.Tag = "btiRegistroAbonados"
        Me.Text = "REGISTRO DE CONTRATO O ABONO"
        Me.txtBuscarSaimt = Me.txtBuscarPersonaPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosPersona.ResumeLayout(False)
        Me.grbDatosPersona.PerformLayout()
        CType(Me.txtTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObsPer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreRazon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.chkAplicaHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkConsiderarEspacio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoVehiculo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroMeses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnNroEspacio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroContratoAbono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConceptoAbono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarContratoPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.dgvListadoContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarPersonaPor1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarPersonaPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTextBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDatosPersona As SaimtControles.SaimtGroupBox
    Friend WithEvents txtTipoDocumento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel30 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents txtPerId As SaimtControles.SaimtTextBox
    Friend WithEvents txtObsPer As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents cboTipoPersona As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents txtDireccion As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel17 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel19 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel22 As SaimtControles.SaimtLabel
    Friend WithEvents btnBuscarPersona As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel29 As SaimtControles.SaimtLabel
    Friend WithEvents txtNombreRazon As SaimtControles.SaimtTextBox
    Friend WithEvents txtNroDocumento As SaimtControles.SaimtTextBox
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents btnCancelarContrato As SaimtControles.SaimtButton
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvListadoContratos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoContratos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvListadoPersona As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoPersona As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboBuscarPersonaPor1 As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtBuscarPersonaPor As SaimtControles.SaimtTextBox
    Friend WithEvents cboBuscarPersonaPor As SaimtControles.SaimtComboBox
    Friend WithEvents SaimtLabel18 As SaimtControles.SaimtLabel
    Friend WithEvents txtBuscarContratoPor As SaimtControles.SaimtTextBox
    Friend WithEvents cboBuscarContratoPor As SaimtControles.SaimtComboBox
    Friend WithEvents SaimtTextBox2 As SaimtControles.SaimtTextBox
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel21 As SaimtControles.SaimtLabel
    Friend WithEvents dtpHoraIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkAplicaHora As SaimtControles.SaimtCheckBox
    Friend WithEvents cboEstado As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel20 As SaimtControles.SaimtLabel
    Friend WithEvents chkConsiderarEspacio As SaimtControles.SaimtCheckBox
    Friend WithEvents cboTipoVehiculo As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel16 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroMeses As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents txtPlaca3 As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents spnNroEspacio As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents cboNivel As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents txtPlaca2 As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroContratoAbono As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents txtMontoPagar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents txtPlaca1 As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaFin As SaimtControles.SaimtDateTimePicker
    Friend WithEvents dtpFechaInicio As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents cboConceptoAbono As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents fbdExportar As System.Windows.Forms.FolderBrowserDialog
End Class
