﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersona
    Inherits Presentacion.frmMantenimientos

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersona))
        Me.grbLista = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoPersona = New SaimtControles.SaimtDataGrid()
        Me.gvResultados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.grbDatosPersonales = New SaimtControles.SaimtGroupBox()
        Me.dtpFechaNac = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel17 = New SaimtControles.SaimtLabel()
        Me.cboGenero = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel16 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.txtCodigoPersona = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.cboRefPersona = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboTipoDocumento = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnLimpiarConyuge = New SaimtControles.SaimtButton()
        Me.btnConsultarConyuge = New SaimtControles.SaimtButton()
        Me.cboTipoPersona = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtNroDocumento = New SaimtControles.SaimtTextBox()
        Me.txtConyugue = New SaimtControles.SaimtTextBox()
        Me.txtApMaterno = New SaimtControles.SaimtTextBox()
        Me.txtApPaterno = New SaimtControles.SaimtTextBox()
        Me.txtNombreRazon = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.txtDireccion = New SaimtControles.SaimtTextBox()
        Me.grbDomicilioFiscal = New SaimtControles.SaimtGroupBox()
        Me.cboDistrito = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboProvincia = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboDepartamento = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel18 = New SaimtControles.SaimtLabel()
        Me.grbDatosAdicionales = New SaimtControles.SaimtGroupBox()
        Me.btnRemover = New SaimtControles.SaimtButton()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.dgvDatosAdicionales = New SaimtControles.SaimtDataGrid()
        Me.gvDatosAdicionales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkActivo = New SaimtControles.SaimtCheckBox()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.txtObservacion = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.cboBuscarPor = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCriterios = New SaimtControles.SaimtComboBox()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLista.SuspendLayout()
        CType(Me.dgvListadoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosPersonales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosPersonales.SuspendLayout()
        CType(Me.dtpFechaNac.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaNac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGenero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConyugue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApMaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApPaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreRazon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDomicilioFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDomicilioFiscal.SuspendLayout()
        CType(Me.cboDistrito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProvincia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosAdicionales.SuspendLayout()
        CType(Me.dgvDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.cboBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 712)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(946, 27)
        '
        'grbLista
        '
        Me.grbLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbLista.Controls.Add(Me.dgvListadoPersona)
        Me.grbLista.Location = New System.Drawing.Point(7, 95)
        Me.grbLista.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbLista.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbLista.Name = "grbLista"
        Me.grbLista.Size = New System.Drawing.Size(366, 611)
        Me.grbLista.TabIndex = 4
        Me.grbLista.Text = "Resultado de Busquedas"
        '
        'dgvListadoPersona
        '
        Me.dgvListadoPersona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoPersona.Location = New System.Drawing.Point(2, 21)
        Me.dgvListadoPersona.MainView = Me.gvResultados
        Me.dgvListadoPersona.MenuManager = Me.RibbonControl
        Me.dgvListadoPersona.Name = "dgvListadoPersona"
        Me.dgvListadoPersona.Size = New System.Drawing.Size(362, 588)
        Me.dgvListadoPersona.TabIndex = 0
        Me.dgvListadoPersona.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResultados})
        '
        'gvResultados
        '
        Me.gvResultados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.gvResultados.GridControl = Me.dgvListadoPersona
        Me.gvResultados.Name = "gvResultados"
        Me.gvResultados.OptionsView.ColumnAutoWidth = False
        Me.gvResultados.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Persona"
        Me.GridColumn1.FieldName = "PerId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Persona"
        Me.GridColumn2.FieldName = "Persona"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tipo de Documento"
        Me.GridColumn4.FieldName = "TipoDocumento"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tipo de Persona"
        Me.GridColumn5.FieldName = "TipoPersona"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Referencia"
        Me.GridColumn6.FieldName = "Referencia"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(6, 6)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(55, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Buscar por:"
        '
        'txtBuscarPor
        '
        Me.txtBuscarPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPor.Location = New System.Drawing.Point(6, 69)
        Me.txtBuscarPor.MenuManager = Me.RibbonControl
        Me.txtBuscarPor.Name = "txtBuscarPor"
        Me.txtBuscarPor.Size = New System.Drawing.Size(367, 20)
        Me.txtBuscarPor.TabIndex = 3
        '
        'grbDatosPersonales
        '
        Me.grbDatosPersonales.Controls.Add(Me.dtpFechaNac)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel17)
        Me.grbDatosPersonales.Controls.Add(Me.cboGenero)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel16)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel15)
        Me.grbDatosPersonales.Controls.Add(Me.txtCodigoPersona)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel14)
        Me.grbDatosPersonales.Controls.Add(Me.cboRefPersona)
        Me.grbDatosPersonales.Controls.Add(Me.cboTipoDocumento)
        Me.grbDatosPersonales.Controls.Add(Me.btnLimpiarConyuge)
        Me.grbDatosPersonales.Controls.Add(Me.btnConsultarConyuge)
        Me.grbDatosPersonales.Controls.Add(Me.cboTipoPersona)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel4)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel13)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel7)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel6)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel5)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel3)
        Me.grbDatosPersonales.Controls.Add(Me.SaimtLabel2)
        Me.grbDatosPersonales.Controls.Add(Me.txtNroDocumento)
        Me.grbDatosPersonales.Controls.Add(Me.txtConyugue)
        Me.grbDatosPersonales.Controls.Add(Me.txtApMaterno)
        Me.grbDatosPersonales.Controls.Add(Me.txtApPaterno)
        Me.grbDatosPersonales.Controls.Add(Me.txtNombreRazon)
        Me.grbDatosPersonales.Location = New System.Drawing.Point(5, 8)
        Me.grbDatosPersonales.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbDatosPersonales.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbDatosPersonales.Name = "grbDatosPersonales"
        Me.grbDatosPersonales.Size = New System.Drawing.Size(546, 230)
        Me.grbDatosPersonales.TabIndex = 0
        Me.grbDatosPersonales.Text = "Datos Personales"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.EditValue = Nothing
        Me.dtpFechaNac.Location = New System.Drawing.Point(104, 102)
        Me.dtpFechaNac.MenuManager = Me.RibbonControl
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaNac.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaNac.Size = New System.Drawing.Size(130, 20)
        Me.dtpFechaNac.TabIndex = 12
        '
        'SaimtLabel17
        '
        Me.SaimtLabel17.Location = New System.Drawing.Point(7, 105)
        Me.SaimtLabel17.Name = "SaimtLabel17"
        Me.SaimtLabel17.Size = New System.Drawing.Size(91, 13)
        Me.SaimtLabel17.TabIndex = 10
        Me.SaimtLabel17.Text = "Fecha Nacimiento :"
        '
        'cboGenero
        '
        Me.cboGenero.Location = New System.Drawing.Point(104, 51)
        Me.cboGenero.MenuManager = Me.RibbonControl
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGenero.Properties.NullText = ""
        Me.cboGenero.Size = New System.Drawing.Size(130, 20)
        Me.cboGenero.TabIndex = 5
        '
        'SaimtLabel16
        '
        Me.SaimtLabel16.Location = New System.Drawing.Point(56, 54)
        Me.SaimtLabel16.Name = "SaimtLabel16"
        Me.SaimtLabel16.Size = New System.Drawing.Size(42, 13)
        Me.SaimtLabel16.TabIndex = 3
        Me.SaimtLabel16.Text = "Género :"
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(26, 28)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(72, 13)
        Me.SaimtLabel15.TabIndex = 0
        Me.SaimtLabel15.Text = "Cod. Persona :"
        '
        'txtCodigoPersona
        '
        Me.txtCodigoPersona.Location = New System.Drawing.Point(104, 25)
        Me.txtCodigoPersona.MenuManager = Me.RibbonControl
        Me.txtCodigoPersona.Name = "txtCodigoPersona"
        Me.txtCodigoPersona.Size = New System.Drawing.Size(130, 20)
        Me.txtCodigoPersona.TabIndex = 1
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(265, 77)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(24, 13)
        Me.SaimtLabel14.TabIndex = 6
        Me.SaimtLabel14.Text = "Ref :"
        '
        'cboRefPersona
        '
        Me.cboRefPersona.Location = New System.Drawing.Point(293, 74)
        Me.cboRefPersona.MenuManager = Me.RibbonControl
        Me.cboRefPersona.Name = "cboRefPersona"
        Me.cboRefPersona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefPersona.Properties.NullText = ""
        Me.cboRefPersona.Size = New System.Drawing.Size(235, 20)
        Me.cboRefPersona.TabIndex = 8
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.Location = New System.Drawing.Point(104, 77)
        Me.cboTipoDocumento.MenuManager = Me.RibbonControl
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoDocumento.Properties.NullText = ""
        Me.cboTipoDocumento.Size = New System.Drawing.Size(130, 20)
        Me.cboTipoDocumento.TabIndex = 9
        '
        'btnLimpiarConyuge
        '
        Me.btnLimpiarConyuge.Image = Global.Presentacion.My.Resources.Resources.limpiar16
        Me.btnLimpiarConyuge.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiarConyuge.Location = New System.Drawing.Point(512, 203)
        Me.btnLimpiarConyuge.Name = "btnLimpiarConyuge"
        Me.btnLimpiarConyuge.Size = New System.Drawing.Size(21, 21)
        Me.btnLimpiarConyuge.TabIndex = 23
        '
        'btnConsultarConyuge
        '
        Me.btnConsultarConyuge.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnConsultarConyuge.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConsultarConyuge.Location = New System.Drawing.Point(489, 203)
        Me.btnConsultarConyuge.Name = "btnConsultarConyuge"
        Me.btnConsultarConyuge.Size = New System.Drawing.Size(21, 21)
        Me.btnConsultarConyuge.TabIndex = 22
        '
        'cboTipoPersona
        '
        Me.cboTipoPersona.Location = New System.Drawing.Point(315, 48)
        Me.cboTipoPersona.MenuManager = Me.RibbonControl
        Me.cboTipoPersona.Name = "cboTipoPersona"
        Me.cboTipoPersona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoPersona.Properties.NullText = ""
        Me.cboTipoPersona.Size = New System.Drawing.Size(213, 20)
        Me.cboTipoPersona.TabIndex = 4
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(240, 103)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(49, 13)
        Me.SaimtLabel4.TabIndex = 13
        Me.SaimtLabel4.Text = "Nro Doc. :"
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(2, 207)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(96, 13)
        Me.SaimtLabel13.TabIndex = 20
        Me.SaimtLabel13.Text = "Nombre Conyugue :"
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(31, 180)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel7.TabIndex = 18
        Me.SaimtLabel7.Text = "Ap. Materno :"
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(33, 154)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(65, 13)
        Me.SaimtLabel6.TabIndex = 16
        Me.SaimtLabel6.Text = "Ap. Paterno :"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(7, 128)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(91, 13)
        Me.SaimtLabel5.TabIndex = 14
        Me.SaimtLabel5.Text = "Nombres o Razon :"
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(14, 80)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(84, 13)
        Me.SaimtLabel3.TabIndex = 7
        Me.SaimtLabel3.Text = "Tipo Documento :"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(240, 51)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel2.TabIndex = 2
        Me.SaimtLabel2.Text = "Tipo Persona :"
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.EditValue = ""
        Me.txtNroDocumento.Location = New System.Drawing.Point(293, 100)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(235, 20)
        Me.txtNroDocumento.TabIndex = 11
        '
        'txtConyugue
        '
        Me.txtConyugue.EditValue = ""
        Me.txtConyugue.Location = New System.Drawing.Point(104, 204)
        Me.txtConyugue.Name = "txtConyugue"
        Me.txtConyugue.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConyugue.Size = New System.Drawing.Size(379, 20)
        Me.txtConyugue.TabIndex = 21
        Me.txtConyugue.Tag = ""
        '
        'txtApMaterno
        '
        Me.txtApMaterno.EditValue = ""
        Me.txtApMaterno.Location = New System.Drawing.Point(104, 178)
        Me.txtApMaterno.Name = "txtApMaterno"
        Me.txtApMaterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApMaterno.Size = New System.Drawing.Size(424, 20)
        Me.txtApMaterno.TabIndex = 19
        '
        'txtApPaterno
        '
        Me.txtApPaterno.EditValue = ""
        Me.txtApPaterno.Location = New System.Drawing.Point(104, 152)
        Me.txtApPaterno.Name = "txtApPaterno"
        Me.txtApPaterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApPaterno.Size = New System.Drawing.Size(424, 20)
        Me.txtApPaterno.TabIndex = 17
        '
        'txtNombreRazon
        '
        Me.txtNombreRazon.EditValue = ""
        Me.txtNombreRazon.Location = New System.Drawing.Point(104, 126)
        Me.txtNombreRazon.Name = "txtNombreRazon"
        Me.txtNombreRazon.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreRazon.Size = New System.Drawing.Size(424, 20)
        Me.txtNombreRazon.TabIndex = 15
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(34, 109)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel8.TabIndex = 6
        Me.SaimtLabel8.Text = "Dirección :"
        '
        'txtDireccion
        '
        Me.txtDireccion.EditValue = ""
        Me.txtDireccion.Location = New System.Drawing.Point(90, 106)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Size = New System.Drawing.Size(438, 20)
        Me.txtDireccion.TabIndex = 7
        '
        'grbDomicilioFiscal
        '
        Me.grbDomicilioFiscal.Controls.Add(Me.cboDistrito)
        Me.grbDomicilioFiscal.Controls.Add(Me.cboProvincia)
        Me.grbDomicilioFiscal.Controls.Add(Me.cboDepartamento)
        Me.grbDomicilioFiscal.Controls.Add(Me.SaimtLabel8)
        Me.grbDomicilioFiscal.Controls.Add(Me.SaimtLabel12)
        Me.grbDomicilioFiscal.Controls.Add(Me.SaimtLabel11)
        Me.grbDomicilioFiscal.Controls.Add(Me.SaimtLabel18)
        Me.grbDomicilioFiscal.Controls.Add(Me.txtDireccion)
        Me.grbDomicilioFiscal.Location = New System.Drawing.Point(5, 244)
        Me.grbDomicilioFiscal.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbDomicilioFiscal.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbDomicilioFiscal.Name = "grbDomicilioFiscal"
        Me.grbDomicilioFiscal.Size = New System.Drawing.Size(546, 135)
        Me.grbDomicilioFiscal.TabIndex = 1
        Me.grbDomicilioFiscal.Text = "Domicilio Fiscal"
        '
        'cboDistrito
        '
        Me.cboDistrito.Location = New System.Drawing.Point(90, 80)
        Me.cboDistrito.MenuManager = Me.RibbonControl
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDistrito.Properties.NullText = ""
        Me.cboDistrito.Size = New System.Drawing.Size(438, 20)
        Me.cboDistrito.TabIndex = 5
        '
        'cboProvincia
        '
        Me.cboProvincia.Location = New System.Drawing.Point(90, 54)
        Me.cboProvincia.MenuManager = Me.RibbonControl
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProvincia.Properties.NullText = ""
        Me.cboProvincia.Size = New System.Drawing.Size(438, 20)
        Me.cboProvincia.TabIndex = 3
        '
        'cboDepartamento
        '
        Me.cboDepartamento.Location = New System.Drawing.Point(90, 28)
        Me.cboDepartamento.MenuManager = Me.RibbonControl
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDepartamento.Properties.NullText = ""
        Me.cboDepartamento.Size = New System.Drawing.Size(438, 20)
        Me.cboDepartamento.TabIndex = 1
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(8, 31)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(76, 13)
        Me.SaimtLabel12.TabIndex = 0
        Me.SaimtLabel12.Text = "Departamento :"
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(43, 83)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(41, 13)
        Me.SaimtLabel11.TabIndex = 4
        Me.SaimtLabel11.Text = "Distrito :"
        '
        'SaimtLabel18
        '
        Me.SaimtLabel18.Location = New System.Drawing.Point(34, 57)
        Me.SaimtLabel18.Name = "SaimtLabel18"
        Me.SaimtLabel18.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel18.TabIndex = 2
        Me.SaimtLabel18.Text = "Provincia :"
        '
        'grbDatosAdicionales
        '
        Me.grbDatosAdicionales.Controls.Add(Me.btnRemover)
        Me.grbDatosAdicionales.Controls.Add(Me.btnAgregar)
        Me.grbDatosAdicionales.Controls.Add(Me.dgvDatosAdicionales)
        Me.grbDatosAdicionales.Location = New System.Drawing.Point(5, 385)
        Me.grbDatosAdicionales.Name = "grbDatosAdicionales"
        Me.grbDatosAdicionales.Size = New System.Drawing.Size(546, 186)
        Me.grbDatosAdicionales.TabIndex = 2
        Me.grbDatosAdicionales.Text = "Datos Adicionales"
        '
        'btnRemover
        '
        Me.btnRemover.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnRemover.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRemover.Location = New System.Drawing.Point(516, 23)
        Me.btnRemover.LookAndFeel.SkinName = "Seven"
        Me.btnRemover.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(25, 18)
        Me.btnRemover.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(489, 23)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 18)
        Me.btnAgregar.TabIndex = 0
        '
        'dgvDatosAdicionales
        '
        Me.dgvDatosAdicionales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDatosAdicionales.Location = New System.Drawing.Point(2, 44)
        Me.dgvDatosAdicionales.MainView = Me.gvDatosAdicionales
        Me.dgvDatosAdicionales.MenuManager = Me.RibbonControl
        Me.dgvDatosAdicionales.Name = "dgvDatosAdicionales"
        Me.dgvDatosAdicionales.Size = New System.Drawing.Size(542, 140)
        Me.dgvDatosAdicionales.TabIndex = 2
        Me.dgvDatosAdicionales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDatosAdicionales})
        '
        'gvDatosAdicionales
        '
        Me.gvDatosAdicionales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colContacto, Me.colDescripcion})
        Me.gvDatosAdicionales.GridControl = Me.dgvDatosAdicionales
        Me.gvDatosAdicionales.Name = "gvDatosAdicionales"
        Me.gvDatosAdicionales.OptionsView.ColumnAutoWidth = False
        Me.gvDatosAdicionales.OptionsView.ShowGroupPanel = False
        '
        'colContacto
        '
        Me.colContacto.Caption = "Contacto"
        Me.colContacto.FieldName = "Contacto"
        Me.colContacto.Name = "colContacto"
        Me.colContacto.Visible = True
        Me.colContacto.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(377, 574)
        Me.chkActivo.MenuManager = Me.RibbonControl
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.AutoWidth = True
        Me.chkActivo.Properties.Caption = "Check si la persona esta activa"
        Me.chkActivo.Size = New System.Drawing.Size(170, 19)
        Me.chkActivo.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(284, 645)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(424, 645)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(214, 645)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(74, 645)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(354, 645)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(144, 645)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(335, 577)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(40, 13)
        Me.SaimtLabel10.TabIndex = 3
        Me.SaimtLabel10.Text = "Estado :"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(9, 579)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel9.TabIndex = 4
        Me.SaimtLabel9.Text = "Observacion :"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(5, 594)
        Me.txtObservacion.MenuManager = Me.RibbonControl
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(546, 46)
        Me.txtObservacion.TabIndex = 6
        Me.txtObservacion.UseOptimizedRendering = True
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboCriterios)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.grbLista)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.grbDatosPersonales)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.txtObservacion)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtLabel9)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.chkActivo)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.grbDatosAdicionales)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtLabel10)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.grbDomicilioFiscal)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnCancelar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEditar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEliminar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnLimpiar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnNuevo)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(946, 712)
        Me.SaimtSplitContainerControl1.SplitterPosition = 378
        Me.SaimtSplitContainerControl1.TabIndex = 0
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'cboBuscarPor
        '
        Me.cboBuscarPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBuscarPor.Location = New System.Drawing.Point(6, 45)
        Me.cboBuscarPor.MenuManager = Me.RibbonControl
        Me.cboBuscarPor.Name = "cboBuscarPor"
        Me.cboBuscarPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarPor.Properties.NullText = ""
        Me.cboBuscarPor.Size = New System.Drawing.Size(367, 20)
        Me.cboBuscarPor.TabIndex = 2
        Me.cboBuscarPor.Tag = "0"
        '
        'cboCriterios
        '
        Me.cboCriterios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCriterios.EditValue = "Busqueda por Apellidos y Nombres"
        Me.cboCriterios.Location = New System.Drawing.Point(6, 21)
        Me.cboCriterios.MenuManager = Me.RibbonControl
        Me.cboCriterios.Name = "cboCriterios"
        Me.cboCriterios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterios.Properties.Items.AddRange(New Object() {"Busqueda por Apellidos y Nombres", "Busqueda por Tipo de Documento", "Busqueda por Razón Social", "Busqueda por Tipo de Persona", "Busqueda por Datos Adicionales", "Busqueda por Codigo Persona"})
        Me.cboCriterios.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCriterios.Size = New System.Drawing.Size(367, 20)
        Me.cboCriterios.TabIndex = 1
        Me.cboCriterios.Tag = "0"
        '
        'frmPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(946, 739)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.dgvListado = Me.dgvListadoPersona
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmPersona"
        Me.Tag = "btiPersona"
        Me.Text = "PERSONA"
        Me.txtBuscarSaimt = Me.txtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLista.ResumeLayout(False)
        CType(Me.dgvListadoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosPersonales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosPersonales.ResumeLayout(False)
        Me.grbDatosPersonales.PerformLayout()
        CType(Me.dtpFechaNac.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaNac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGenero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConyugue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApMaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApPaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreRazon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDomicilioFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDomicilioFiscal.ResumeLayout(False)
        Me.grbDomicilioFiscal.PerformLayout()
        CType(Me.cboDistrito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProvincia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosAdicionales.ResumeLayout(False)
        CType(Me.dgvDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.cboBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbLista As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents grbDatosPersonales As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroDocumento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtDireccion As SaimtControles.SaimtTextBox
    Friend WithEvents txtApMaterno As SaimtControles.SaimtTextBox
    Friend WithEvents txtApPaterno As SaimtControles.SaimtTextBox
    Friend WithEvents txtNombreRazon As SaimtControles.SaimtTextBox
    Friend WithEvents grbDomicilioFiscal As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel18 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents txtConyugue As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents grbDatosAdicionales As SaimtControles.SaimtGroupBox
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents cboTipoPersona As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents dgvDatosAdicionales As SaimtControles.SaimtDataGrid
    Friend WithEvents gvDatosAdicionales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkActivo As SaimtControles.SaimtCheckBox
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents cboDistrito As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboProvincia As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboDepartamento As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents txtObservacion As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents colContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRemover As SaimtControles.SaimtButton
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
    Friend WithEvents btnConsultarConyuge As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiarConyuge As SaimtControles.SaimtButton
    Friend WithEvents cboTipoDocumento As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents cboRefPersona As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents txtCodigoPersona As SaimtControles.SaimtTextBox
    Friend WithEvents dgvListadoPersona As SaimtControles.SaimtDataGrid
    Friend WithEvents gvResultados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents cboBuscarPor As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboCriterios As SaimtControles.SaimtComboBox
    Friend WithEvents cboGenero As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel16 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaNac As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel17 As SaimtControles.SaimtLabel

End Class
