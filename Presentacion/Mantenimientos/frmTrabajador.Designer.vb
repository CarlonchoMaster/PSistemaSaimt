﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrabajador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrabajador))
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.cboBuscarPor = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCriterios = New SaimtControles.SaimtComboBox()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoTrabajador = New SaimtControles.SaimtDataGrid()
        Me.gvListadoTrabajador = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtTabs3 = New SaimtControles.SaimtTabs()
        Me.xtpDatosTrabajador = New DevExpress.XtraTab.XtraTabPage()
        Me.txtDistrito = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel40 = New SaimtControles.SaimtLabel()
        Me.txtProvincia = New SaimtControles.SaimtTextBox()
        Me.txtDepartamento = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel39 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel38 = New SaimtControles.SaimtLabel()
        Me.txtCodigoPersona = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtCodigoContrato = New SaimtControles.SaimtTextBox()
        Me.txtDomicilio = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtPersona = New SaimtControles.SaimtTextBox()
        Me.btnConsultarPersona = New SaimtControles.SaimtButton()
        Me.xtpDatosContacto = New DevExpress.XtraTab.XtraTabPage()
        Me.dgvDatosAdicionales = New SaimtControles.SaimtDataGrid()
        Me.gvDatosAdicionales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox4 = New SaimtControles.SaimtGroupBox()
        Me.BackstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        Me.BackstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.SaimtTabs1 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtNroSeguroSocial = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel37 = New SaimtControles.SaimtLabel()
        Me.cboSeguroSocial = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel36 = New SaimtControles.SaimtLabel()
        Me.txtRUC = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel35 = New SaimtControles.SaimtLabel()
        Me.cboSucursal = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel28 = New SaimtControles.SaimtLabel()
        Me.txtCantidadHijos = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.cboEstadoCivil = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.cboBanco = New SaimtControles.SaimtComboBoxLookUp()
        Me.txtNroCuenta = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.cbHorario = New SaimtControles.SaimtComboBoxLookUp()
        Me.dtpFechaInforme = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel27 = New SaimtControles.SaimtLabel()
        Me.txtRefInforme = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel26 = New SaimtControles.SaimtLabel()
        Me.dtpFechaProveido = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel25 = New SaimtControles.SaimtLabel()
        Me.txtRefProveido = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel24 = New SaimtControles.SaimtLabel()
        Me.dtpFechaRequerimiento = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel23 = New SaimtControles.SaimtLabel()
        Me.txtRefRequerimiento = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel22 = New SaimtControles.SaimtLabel()
        Me.dtpFechaOficio = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel21 = New SaimtControles.SaimtLabel()
        Me.txtRefOficio = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel20 = New SaimtControles.SaimtLabel()
        Me.dtpFechaResolucion = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel19 = New SaimtControles.SaimtLabel()
        Me.txtRefResolucion = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel18 = New SaimtControles.SaimtLabel()
        Me.txtRemuneracion = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel17 = New SaimtControles.SaimtLabel()
        Me.spnNroSueldos = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel16 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.cboTipoContrato = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.cboEstadoContrato = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.dtpFechaFinDC = New SaimtControles.SaimtDateTimePicker()
        Me.dtpFechaInicioDC = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.BackstageViewClientControl2 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.SaimtTabs2 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnDesactivarCargo = New SaimtControles.SaimtButton()
        Me.cboCargo = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboArea = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnQuitarCargo = New SaimtControles.SaimtButton()
        Me.btnAgregarCargo = New SaimtControles.SaimtButton()
        Me.dgvCargos = New SaimtControles.SaimtDataGrid()
        Me.gvCargos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.dtpFechaFinCargos = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel34 = New SaimtControles.SaimtLabel()
        Me.dtpFechaInicioCargos = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel33 = New SaimtControles.SaimtLabel()
        Me.cboTipoCargo = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel32 = New SaimtControles.SaimtLabel()
        Me.chkCargoActivo = New SaimtControles.SaimtCheckBox()
        Me.SaimtLabel31 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel30 = New SaimtControles.SaimtLabel()
        Me.txtInstitucion = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel29 = New SaimtControles.SaimtLabel()
        Me.BackstageViewClientControl3 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.cboNivelRemunerativo = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboGradoOcupacional = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboFormacionProfecional = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboNivelEstudio = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel44 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel43 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel42 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel41 = New SaimtControles.SaimtLabel()
        Me.BackstageViewClientControl4 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.txtPrimaSegAFP = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel48 = New SaimtControles.SaimtLabel()
        Me.txtComisionAFP = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel47 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel46 = New SaimtControles.SaimtLabel()
        Me.txtAporteObligatorioAFP = New SaimtControles.SaimtTextBox()
        Me.cboAFP = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel45 = New SaimtControles.SaimtLabel()
        Me.BackstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem2 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator2 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem3 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator3 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem4 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.cboBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.dgvListadoTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTabs3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs3.SuspendLayout()
        Me.xtpDatosTrabajador.SuspendLayout()
        CType(Me.txtDistrito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProvincia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDomicilio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDatosContacto.SuspendLayout()
        CType(Me.dgvDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox4.SuspendLayout()
        Me.BackstageViewControl1.SuspendLayout()
        Me.BackstageViewClientControl1.SuspendLayout()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtNroSeguroSocial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSeguroSocial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRUC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadHijos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoCivil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbHorario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInforme.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInforme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefInforme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaProveido.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaProveido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefProveido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRequerimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRequerimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefRequerimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaOficio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaOficio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefOficio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaResolucion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemuneracion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnNroSueldos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFinDC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFinDC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioDC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioDC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewClientControl2.SuspendLayout()
        CType(Me.SaimtTabs2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cboCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFinCargos.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFinCargos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioCargos.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioCargos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCargoActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewClientControl3.SuspendLayout()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.cboNivelRemunerativo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGradoOcupacional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormacionProfecional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNivelEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewClientControl4.SuspendLayout()
        CType(Me.txtPrimaSegAFP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComisionAFP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAporteObligatorioAFP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAFP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 726)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1126, 27)
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboCriterios)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtTabs3)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.PictureEdit1)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnCancelar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEliminar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnLimpiar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnNuevo)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEditar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox4)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(1126, 726)
        Me.SaimtSplitContainerControl1.SplitterPosition = 348
        Me.SaimtSplitContainerControl1.TabIndex = 0
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'cboBuscarPor
        '
        Me.cboBuscarPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBuscarPor.Location = New System.Drawing.Point(8, 46)
        Me.cboBuscarPor.MenuManager = Me.RibbonControl
        Me.cboBuscarPor.Name = "cboBuscarPor"
        Me.cboBuscarPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarPor.Properties.NullText = ""
        Me.cboBuscarPor.Size = New System.Drawing.Size(335, 20)
        Me.cboBuscarPor.TabIndex = 5
        Me.cboBuscarPor.Tag = "0"
        '
        'cboCriterios
        '
        Me.cboCriterios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCriterios.EditValue = "Busqueda por Cod. Contrato"
        Me.cboCriterios.Location = New System.Drawing.Point(8, 21)
        Me.cboCriterios.MenuManager = Me.RibbonControl
        Me.cboCriterios.Name = "cboCriterios"
        Me.cboCriterios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterios.Properties.Items.AddRange(New Object() {"Busqueda por Cod. Contrato", "Busqueda por Apellidos y Nombres", "Busqueda por DNI", "Busqueda por Sucursal", "Busqueda por Modalidad de Contrato", "Busqueda por Horario"})
        Me.cboCriterios.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCriterios.Size = New System.Drawing.Size(335, 20)
        Me.cboCriterios.TabIndex = 4
        Me.cboCriterios.Tag = "0"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox1.Controls.Add(Me.dgvListadoTrabajador)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(8, 97)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(335, 623)
        Me.SaimtGroupBox1.TabIndex = 3
        Me.SaimtGroupBox1.Text = "Resultados de Busqueda"
        '
        'dgvListadoTrabajador
        '
        Me.dgvListadoTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoTrabajador.Location = New System.Drawing.Point(2, 21)
        Me.dgvListadoTrabajador.MainView = Me.gvListadoTrabajador
        Me.dgvListadoTrabajador.MenuManager = Me.RibbonControl
        Me.dgvListadoTrabajador.Name = "dgvListadoTrabajador"
        Me.dgvListadoTrabajador.Size = New System.Drawing.Size(331, 600)
        Me.dgvListadoTrabajador.TabIndex = 0
        Me.dgvListadoTrabajador.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoTrabajador})
        '
        'gvListadoTrabajador
        '
        Me.gvListadoTrabajador.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        Me.gvListadoTrabajador.GridControl = Me.dgvListadoTrabajador
        Me.gvListadoTrabajador.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvListadoTrabajador.Name = "gvListadoTrabajador"
        Me.gvListadoTrabajador.OptionsBehavior.ReadOnly = True
        Me.gvListadoTrabajador.OptionsCustomization.AllowSort = False
        Me.gvListadoTrabajador.OptionsView.ColumnAutoWidth = False
        Me.gvListadoTrabajador.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "ConTrabId"
        Me.GridColumn13.FieldName = "ConTrabId"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Persona"
        Me.GridColumn14.FieldName = "Persona"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Fecha Inicio"
        Me.GridColumn15.FieldName = "ConTrabFecInicio"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 1
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Fecha Fin"
        Me.GridColumn16.FieldName = "ConTrabFecFin"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 2
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Modalidad"
        Me.GridColumn17.FieldName = "Modalidad"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 3
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Sucursal"
        Me.GridColumn18.FieldName = "Sucursal"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 4
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Horario"
        Me.GridColumn19.FieldName = "Horario"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 5
        '
        'txtBuscarPor
        '
        Me.txtBuscarPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPor.Location = New System.Drawing.Point(8, 71)
        Me.txtBuscarPor.Name = "txtBuscarPor"
        Me.txtBuscarPor.Size = New System.Drawing.Size(335, 20)
        Me.txtBuscarPor.TabIndex = 2
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(10, 6)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel4.TabIndex = 0
        Me.SaimtLabel4.Text = "Buscar por :"
        '
        'SaimtTabs3
        '
        Me.SaimtTabs3.Location = New System.Drawing.Point(3, 6)
        Me.SaimtTabs3.Name = "SaimtTabs3"
        Me.SaimtTabs3.SelectedTabPage = Me.xtpDatosTrabajador
        Me.SaimtTabs3.Size = New System.Drawing.Size(612, 197)
        Me.SaimtTabs3.TabIndex = 1
        Me.SaimtTabs3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpDatosTrabajador, Me.xtpDatosContacto})
        '
        'xtpDatosTrabajador
        '
        Me.xtpDatosTrabajador.Controls.Add(Me.txtDistrito)
        Me.xtpDatosTrabajador.Controls.Add(Me.SaimtLabel40)
        Me.xtpDatosTrabajador.Controls.Add(Me.txtProvincia)
        Me.xtpDatosTrabajador.Controls.Add(Me.txtDepartamento)
        Me.xtpDatosTrabajador.Controls.Add(Me.SaimtLabel39)
        Me.xtpDatosTrabajador.Controls.Add(Me.SaimtLabel38)
        Me.xtpDatosTrabajador.Controls.Add(Me.txtCodigoPersona)
        Me.xtpDatosTrabajador.Controls.Add(Me.SaimtLabel1)
        Me.xtpDatosTrabajador.Controls.Add(Me.SaimtLabel5)
        Me.xtpDatosTrabajador.Controls.Add(Me.txtCodigoContrato)
        Me.xtpDatosTrabajador.Controls.Add(Me.txtDomicilio)
        Me.xtpDatosTrabajador.Controls.Add(Me.SaimtLabel2)
        Me.xtpDatosTrabajador.Controls.Add(Me.SaimtLabel3)
        Me.xtpDatosTrabajador.Controls.Add(Me.txtPersona)
        Me.xtpDatosTrabajador.Controls.Add(Me.btnConsultarPersona)
        Me.xtpDatosTrabajador.Name = "xtpDatosTrabajador"
        Me.xtpDatosTrabajador.Size = New System.Drawing.Size(606, 169)
        Me.xtpDatosTrabajador.Text = "Datos del Trabajador"
        '
        'txtDistrito
        '
        Me.txtDistrito.Location = New System.Drawing.Point(90, 145)
        Me.txtDistrito.MenuManager = Me.RibbonControl
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(191, 20)
        Me.txtDistrito.TabIndex = 14
        '
        'SaimtLabel40
        '
        Me.SaimtLabel40.Location = New System.Drawing.Point(50, 148)
        Me.SaimtLabel40.Name = "SaimtLabel40"
        Me.SaimtLabel40.Size = New System.Drawing.Size(34, 13)
        Me.SaimtLabel40.TabIndex = 13
        Me.SaimtLabel40.Text = "Distrito"
        '
        'txtProvincia
        '
        Me.txtProvincia.Location = New System.Drawing.Point(352, 120)
        Me.txtProvincia.MenuManager = Me.RibbonControl
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(198, 20)
        Me.txtProvincia.TabIndex = 12
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(90, 120)
        Me.txtDepartamento.MenuManager = Me.RibbonControl
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(191, 20)
        Me.txtDepartamento.TabIndex = 11
        '
        'SaimtLabel39
        '
        Me.SaimtLabel39.Location = New System.Drawing.Point(303, 123)
        Me.SaimtLabel39.Name = "SaimtLabel39"
        Me.SaimtLabel39.Size = New System.Drawing.Size(43, 13)
        Me.SaimtLabel39.TabIndex = 10
        Me.SaimtLabel39.Text = "Provincia"
        '
        'SaimtLabel38
        '
        Me.SaimtLabel38.Location = New System.Drawing.Point(16, 123)
        Me.SaimtLabel38.Name = "SaimtLabel38"
        Me.SaimtLabel38.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel38.TabIndex = 9
        Me.SaimtLabel38.Text = "Departamento"
        '
        'txtCodigoPersona
        '
        Me.txtCodigoPersona.Location = New System.Drawing.Point(90, 67)
        Me.txtCodigoPersona.MenuManager = Me.RibbonControl
        Me.txtCodigoPersona.Name = "txtCodigoPersona"
        Me.txtCodigoPersona.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoPersona.TabIndex = 6
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(15, 15)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Cod. Contrato"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(19, 70)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(65, 13)
        Me.SaimtLabel5.TabIndex = 5
        Me.SaimtLabel5.Text = "Cod. Persona"
        '
        'txtCodigoContrato
        '
        Me.txtCodigoContrato.Location = New System.Drawing.Point(90, 12)
        Me.txtCodigoContrato.MenuManager = Me.RibbonControl
        Me.txtCodigoContrato.Name = "txtCodigoContrato"
        Me.txtCodigoContrato.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoContrato.TabIndex = 1
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(90, 93)
        Me.txtDomicilio.MenuManager = Me.RibbonControl
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(511, 20)
        Me.txtDomicilio.TabIndex = 8
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(45, 44)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(39, 13)
        Me.SaimtLabel2.TabIndex = 2
        Me.SaimtLabel2.Text = "Persona"
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(45, 96)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(40, 13)
        Me.SaimtLabel3.TabIndex = 7
        Me.SaimtLabel3.Text = "Domicilio"
        '
        'txtPersona
        '
        Me.txtPersona.Location = New System.Drawing.Point(90, 41)
        Me.txtPersona.MenuManager = Me.RibbonControl
        Me.txtPersona.Name = "txtPersona"
        Me.txtPersona.Size = New System.Drawing.Size(479, 20)
        Me.txtPersona.TabIndex = 4
        '
        'btnConsultarPersona
        '
        Me.btnConsultarPersona.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnConsultarPersona.Location = New System.Drawing.Point(568, 39)
        Me.btnConsultarPersona.Name = "btnConsultarPersona"
        Me.btnConsultarPersona.Size = New System.Drawing.Size(24, 22)
        Me.btnConsultarPersona.TabIndex = 3
        '
        'xtpDatosContacto
        '
        Me.xtpDatosContacto.Controls.Add(Me.dgvDatosAdicionales)
        Me.xtpDatosContacto.Name = "xtpDatosContacto"
        Me.xtpDatosContacto.Size = New System.Drawing.Size(606, 169)
        Me.xtpDatosContacto.Text = "Datos Adicionales"
        '
        'dgvDatosAdicionales
        '
        Me.dgvDatosAdicionales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDatosAdicionales.Location = New System.Drawing.Point(0, 0)
        Me.dgvDatosAdicionales.MainView = Me.gvDatosAdicionales
        Me.dgvDatosAdicionales.MenuManager = Me.RibbonControl
        Me.dgvDatosAdicionales.Name = "dgvDatosAdicionales"
        Me.dgvDatosAdicionales.Size = New System.Drawing.Size(606, 169)
        Me.dgvDatosAdicionales.TabIndex = 0
        Me.dgvDatosAdicionales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDatosAdicionales})
        '
        'gvDatosAdicionales
        '
        Me.gvDatosAdicionales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colContacto, Me.colDescripcion})
        Me.gvDatosAdicionales.GridControl = Me.dgvDatosAdicionales
        Me.gvDatosAdicionales.Name = "gvDatosAdicionales"
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
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(619, 6)
        Me.PictureEdit1.MenuManager = Me.RibbonControl
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(144, 160)
        Me.PictureEdit1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(390, 661)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(530, 661)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(320, 661)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(180, 661)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(460, 661)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(250, 661)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        '
        'SaimtGroupBox4
        '
        Me.SaimtGroupBox4.Controls.Add(Me.BackstageViewControl1)
        Me.SaimtGroupBox4.Location = New System.Drawing.Point(1, 207)
        Me.SaimtGroupBox4.Name = "SaimtGroupBox4"
        Me.SaimtGroupBox4.Size = New System.Drawing.Size(766, 449)
        Me.SaimtGroupBox4.TabIndex = 2
        Me.SaimtGroupBox4.Text = "Datos Adicionales para el Trabajador"
        '
        'BackstageViewControl1
        '
        Me.BackstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl1)
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl2)
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl3)
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl4)
        Me.BackstageViewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem1)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator1)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem2)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator2)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem3)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator3)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem4)
        Me.BackstageViewControl1.Location = New System.Drawing.Point(2, 21)
        Me.BackstageViewControl1.Name = "BackstageViewControl1"
        Me.BackstageViewControl1.SelectedTab = Me.BackstageViewTabItem4
        Me.BackstageViewControl1.SelectedTabIndex = 6
        Me.BackstageViewControl1.Size = New System.Drawing.Size(762, 426)
        Me.BackstageViewControl1.TabIndex = 0
        '
        'BackstageViewClientControl1
        '
        Me.BackstageViewClientControl1.Controls.Add(Me.SaimtTabs1)
        Me.BackstageViewClientControl1.Location = New System.Drawing.Point(133, 0)
        Me.BackstageViewClientControl1.Name = "BackstageViewClientControl1"
        Me.BackstageViewClientControl1.Size = New System.Drawing.Size(629, 426)
        Me.BackstageViewClientControl1.TabIndex = 0
        '
        'SaimtTabs1
        '
        Me.SaimtTabs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtTabs1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtTabs1.Name = "SaimtTabs1"
        Me.SaimtTabs1.SelectedTabPage = Me.XtraTabPage1
        Me.SaimtTabs1.Size = New System.Drawing.Size(629, 425)
        Me.SaimtTabs1.TabIndex = 0
        Me.SaimtTabs1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txtNroSeguroSocial)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel37)
        Me.XtraTabPage1.Controls.Add(Me.cboSeguroSocial)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel36)
        Me.XtraTabPage1.Controls.Add(Me.txtRUC)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel35)
        Me.XtraTabPage1.Controls.Add(Me.cboSucursal)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel28)
        Me.XtraTabPage1.Controls.Add(Me.txtCantidadHijos)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel13)
        Me.XtraTabPage1.Controls.Add(Me.cboEstadoCivil)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel12)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel11)
        Me.XtraTabPage1.Controls.Add(Me.cboBanco)
        Me.XtraTabPage1.Controls.Add(Me.txtNroCuenta)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel10)
        Me.XtraTabPage1.Controls.Add(Me.cbHorario)
        Me.XtraTabPage1.Controls.Add(Me.dtpFechaInforme)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel27)
        Me.XtraTabPage1.Controls.Add(Me.txtRefInforme)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel26)
        Me.XtraTabPage1.Controls.Add(Me.dtpFechaProveido)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel25)
        Me.XtraTabPage1.Controls.Add(Me.txtRefProveido)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel24)
        Me.XtraTabPage1.Controls.Add(Me.dtpFechaRequerimiento)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel23)
        Me.XtraTabPage1.Controls.Add(Me.txtRefRequerimiento)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel22)
        Me.XtraTabPage1.Controls.Add(Me.dtpFechaOficio)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel21)
        Me.XtraTabPage1.Controls.Add(Me.txtRefOficio)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel20)
        Me.XtraTabPage1.Controls.Add(Me.dtpFechaResolucion)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel19)
        Me.XtraTabPage1.Controls.Add(Me.txtRefResolucion)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel18)
        Me.XtraTabPage1.Controls.Add(Me.txtRemuneracion)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel17)
        Me.XtraTabPage1.Controls.Add(Me.spnNroSueldos)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel16)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel15)
        Me.XtraTabPage1.Controls.Add(Me.cboTipoContrato)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel14)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel9)
        Me.XtraTabPage1.Controls.Add(Me.cboEstadoContrato)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel8)
        Me.XtraTabPage1.Controls.Add(Me.dtpFechaFinDC)
        Me.XtraTabPage1.Controls.Add(Me.dtpFechaInicioDC)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel7)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel6)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(623, 397)
        Me.XtraTabPage1.Text = "Datos para el Contrato"
        '
        'txtNroSeguroSocial
        '
        Me.txtNroSeguroSocial.Location = New System.Drawing.Point(98, 366)
        Me.txtNroSeguroSocial.MenuManager = Me.RibbonControl
        Me.txtNroSeguroSocial.Name = "txtNroSeguroSocial"
        Me.txtNroSeguroSocial.Size = New System.Drawing.Size(128, 20)
        Me.txtNroSeguroSocial.TabIndex = 50
        '
        'SaimtLabel37
        '
        Me.SaimtLabel37.Location = New System.Drawing.Point(6, 369)
        Me.SaimtLabel37.Name = "SaimtLabel37"
        Me.SaimtLabel37.Size = New System.Drawing.Size(88, 13)
        Me.SaimtLabel37.TabIndex = 49
        Me.SaimtLabel37.Text = "Nro. Seguro Social"
        '
        'cboSeguroSocial
        '
        Me.cboSeguroSocial.Location = New System.Drawing.Point(96, 340)
        Me.cboSeguroSocial.MenuManager = Me.RibbonControl
        Me.cboSeguroSocial.Name = "cboSeguroSocial"
        Me.cboSeguroSocial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSeguroSocial.Properties.NullText = ""
        Me.cboSeguroSocial.Size = New System.Drawing.Size(128, 20)
        Me.cboSeguroSocial.TabIndex = 45
        '
        'SaimtLabel36
        '
        Me.SaimtLabel36.Location = New System.Drawing.Point(30, 347)
        Me.SaimtLabel36.Name = "SaimtLabel36"
        Me.SaimtLabel36.Size = New System.Drawing.Size(64, 13)
        Me.SaimtLabel36.TabIndex = 47
        Me.SaimtLabel36.Text = "Seguro Social"
        '
        'txtRUC
        '
        Me.txtRUC.Location = New System.Drawing.Point(290, 340)
        Me.txtRUC.MenuManager = Me.RibbonControl
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(128, 20)
        Me.txtRUC.TabIndex = 48
        '
        'SaimtLabel35
        '
        Me.SaimtLabel35.Location = New System.Drawing.Point(262, 343)
        Me.SaimtLabel35.Name = "SaimtLabel35"
        Me.SaimtLabel35.Size = New System.Drawing.Size(21, 13)
        Me.SaimtLabel35.TabIndex = 46
        Me.SaimtLabel35.Text = "RUC"
        '
        'cboSucursal
        '
        Me.cboSucursal.Location = New System.Drawing.Point(96, 314)
        Me.cboSucursal.MenuManager = Me.RibbonControl
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSucursal.Properties.NullText = ""
        Me.cboSucursal.Size = New System.Drawing.Size(128, 20)
        Me.cboSucursal.TabIndex = 43
        '
        'SaimtLabel28
        '
        Me.SaimtLabel28.Location = New System.Drawing.Point(54, 321)
        Me.SaimtLabel28.Name = "SaimtLabel28"
        Me.SaimtLabel28.Size = New System.Drawing.Size(40, 13)
        Me.SaimtLabel28.TabIndex = 42
        Me.SaimtLabel28.Text = "Sucursal"
        '
        'txtCantidadHijos
        '
        Me.txtCantidadHijos.Location = New System.Drawing.Point(290, 314)
        Me.txtCantidadHijos.MenuManager = Me.RibbonControl
        Me.txtCantidadHijos.Name = "txtCantidadHijos"
        Me.txtCantidadHijos.Size = New System.Drawing.Size(128, 20)
        Me.txtCantidadHijos.TabIndex = 44
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(230, 317)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(53, 13)
        Me.SaimtLabel13.TabIndex = 41
        Me.SaimtLabel13.Text = "Cant. Hijos"
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.Location = New System.Drawing.Point(290, 287)
        Me.cboEstadoCivil.MenuManager = Me.RibbonControl
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstadoCivil.Properties.NullText = ""
        Me.cboEstadoCivil.Size = New System.Drawing.Size(128, 20)
        Me.cboEstadoCivil.TabIndex = 40
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(228, 290)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(55, 13)
        Me.SaimtLabel12.TabIndex = 39
        Me.SaimtLabel12.Text = "Estado Civil"
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(246, 101)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(59, 13)
        Me.SaimtLabel11.TabIndex = 12
        Me.SaimtLabel11.Text = "Nro. Cuenta"
        '
        'cboBanco
        '
        Me.cboBanco.Location = New System.Drawing.Point(96, 99)
        Me.cboBanco.MenuManager = Me.RibbonControl
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBanco.Properties.NullText = ""
        Me.cboBanco.Size = New System.Drawing.Size(128, 20)
        Me.cboBanco.TabIndex = 15
        '
        'txtNroCuenta
        '
        Me.txtNroCuenta.Location = New System.Drawing.Point(313, 97)
        Me.txtNroCuenta.MenuManager = Me.RibbonControl
        Me.txtNroCuenta.Name = "txtNroCuenta"
        Me.txtNroCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtNroCuenta.TabIndex = 14
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(65, 102)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(29, 13)
        Me.SaimtLabel10.TabIndex = 13
        Me.SaimtLabel10.Text = "Banco"
        '
        'cbHorario
        '
        Me.cbHorario.Location = New System.Drawing.Point(311, 37)
        Me.cbHorario.MenuManager = Me.RibbonControl
        Me.cbHorario.Name = "cbHorario"
        Me.cbHorario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbHorario.Properties.NullText = ""
        Me.cbHorario.Size = New System.Drawing.Size(140, 20)
        Me.cbHorario.TabIndex = 7
        '
        'dtpFechaInforme
        '
        Me.dtpFechaInforme.EditValue = Nothing
        Me.dtpFechaInforme.Location = New System.Drawing.Point(96, 287)
        Me.dtpFechaInforme.MenuManager = Me.RibbonControl
        Me.dtpFechaInforme.Name = "dtpFechaInforme"
        Me.dtpFechaInforme.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInforme.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaInforme.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaInforme.TabIndex = 38
        '
        'SaimtLabel27
        '
        Me.SaimtLabel27.Location = New System.Drawing.Point(24, 290)
        Me.SaimtLabel27.Name = "SaimtLabel27"
        Me.SaimtLabel27.Size = New System.Drawing.Size(70, 13)
        Me.SaimtLabel27.TabIndex = 37
        Me.SaimtLabel27.Text = "Fecha Informe"
        '
        'txtRefInforme
        '
        Me.txtRefInforme.Location = New System.Drawing.Point(290, 258)
        Me.txtRefInforme.MenuManager = Me.RibbonControl
        Me.txtRefInforme.Name = "txtRefInforme"
        Me.txtRefInforme.Size = New System.Drawing.Size(320, 20)
        Me.txtRefInforme.TabIndex = 36
        '
        'SaimtLabel26
        '
        Me.SaimtLabel26.Location = New System.Drawing.Point(220, 261)
        Me.SaimtLabel26.Name = "SaimtLabel26"
        Me.SaimtLabel26.Size = New System.Drawing.Size(62, 13)
        Me.SaimtLabel26.TabIndex = 35
        Me.SaimtLabel26.Text = "Ref. Informe"
        '
        'dtpFechaProveido
        '
        Me.dtpFechaProveido.EditValue = Nothing
        Me.dtpFechaProveido.Location = New System.Drawing.Point(96, 258)
        Me.dtpFechaProveido.MenuManager = Me.RibbonControl
        Me.dtpFechaProveido.Name = "dtpFechaProveido"
        Me.dtpFechaProveido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaProveido.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaProveido.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaProveido.TabIndex = 34
        '
        'SaimtLabel25
        '
        Me.SaimtLabel25.Location = New System.Drawing.Point(20, 261)
        Me.SaimtLabel25.Name = "SaimtLabel25"
        Me.SaimtLabel25.Size = New System.Drawing.Size(74, 13)
        Me.SaimtLabel25.TabIndex = 33
        Me.SaimtLabel25.Text = "Fecha Proveido"
        '
        'txtRefProveido
        '
        Me.txtRefProveido.Location = New System.Drawing.Point(290, 227)
        Me.txtRefProveido.MenuManager = Me.RibbonControl
        Me.txtRefProveido.Name = "txtRefProveido"
        Me.txtRefProveido.Size = New System.Drawing.Size(320, 20)
        Me.txtRefProveido.TabIndex = 32
        '
        'SaimtLabel24
        '
        Me.SaimtLabel24.Location = New System.Drawing.Point(216, 230)
        Me.SaimtLabel24.Name = "SaimtLabel24"
        Me.SaimtLabel24.Size = New System.Drawing.Size(66, 13)
        Me.SaimtLabel24.TabIndex = 31
        Me.SaimtLabel24.Text = "Ref. Proveido"
        '
        'dtpFechaRequerimiento
        '
        Me.dtpFechaRequerimiento.EditValue = Nothing
        Me.dtpFechaRequerimiento.Location = New System.Drawing.Point(96, 227)
        Me.dtpFechaRequerimiento.MenuManager = Me.RibbonControl
        Me.dtpFechaRequerimiento.Name = "dtpFechaRequerimiento"
        Me.dtpFechaRequerimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaRequerimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaRequerimiento.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaRequerimiento.TabIndex = 30
        '
        'SaimtLabel23
        '
        Me.SaimtLabel23.Location = New System.Drawing.Point(1, 230)
        Me.SaimtLabel23.Name = "SaimtLabel23"
        Me.SaimtLabel23.Size = New System.Drawing.Size(93, 13)
        Me.SaimtLabel23.TabIndex = 29
        Me.SaimtLabel23.Text = "Fec. Requerimiento"
        '
        'txtRefRequerimiento
        '
        Me.txtRefRequerimiento.Location = New System.Drawing.Point(290, 196)
        Me.txtRefRequerimiento.MenuManager = Me.RibbonControl
        Me.txtRefRequerimiento.Name = "txtRefRequerimiento"
        Me.txtRefRequerimiento.Size = New System.Drawing.Size(320, 20)
        Me.txtRefRequerimiento.TabIndex = 28
        '
        'SaimtLabel22
        '
        Me.SaimtLabel22.Location = New System.Drawing.Point(189, 199)
        Me.SaimtLabel22.Name = "SaimtLabel22"
        Me.SaimtLabel22.Size = New System.Drawing.Size(93, 13)
        Me.SaimtLabel22.TabIndex = 27
        Me.SaimtLabel22.Text = "Ref. Requerimiento"
        '
        'dtpFechaOficio
        '
        Me.dtpFechaOficio.EditValue = Nothing
        Me.dtpFechaOficio.Location = New System.Drawing.Point(96, 196)
        Me.dtpFechaOficio.MenuManager = Me.RibbonControl
        Me.dtpFechaOficio.Name = "dtpFechaOficio"
        Me.dtpFechaOficio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaOficio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaOficio.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaOficio.TabIndex = 26
        '
        'SaimtLabel21
        '
        Me.SaimtLabel21.Location = New System.Drawing.Point(35, 199)
        Me.SaimtLabel21.Name = "SaimtLabel21"
        Me.SaimtLabel21.Size = New System.Drawing.Size(59, 13)
        Me.SaimtLabel21.TabIndex = 25
        Me.SaimtLabel21.Text = "Fecha Oficio"
        '
        'txtRefOficio
        '
        Me.txtRefOficio.Location = New System.Drawing.Point(290, 164)
        Me.txtRefOficio.MenuManager = Me.RibbonControl
        Me.txtRefOficio.Name = "txtRefOficio"
        Me.txtRefOficio.Size = New System.Drawing.Size(320, 20)
        Me.txtRefOficio.TabIndex = 24
        '
        'SaimtLabel20
        '
        Me.SaimtLabel20.Location = New System.Drawing.Point(231, 167)
        Me.SaimtLabel20.Name = "SaimtLabel20"
        Me.SaimtLabel20.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel20.TabIndex = 23
        Me.SaimtLabel20.Text = "Ref. Oficio"
        '
        'dtpFechaResolucion
        '
        Me.dtpFechaResolucion.EditValue = Nothing
        Me.dtpFechaResolucion.Location = New System.Drawing.Point(96, 164)
        Me.dtpFechaResolucion.MenuManager = Me.RibbonControl
        Me.dtpFechaResolucion.Name = "dtpFechaResolucion"
        Me.dtpFechaResolucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaResolucion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaResolucion.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaResolucion.TabIndex = 22
        '
        'SaimtLabel19
        '
        Me.SaimtLabel19.Location = New System.Drawing.Point(11, 167)
        Me.SaimtLabel19.Name = "SaimtLabel19"
        Me.SaimtLabel19.Size = New System.Drawing.Size(83, 13)
        Me.SaimtLabel19.TabIndex = 21
        Me.SaimtLabel19.Text = "Fecha Resolución"
        '
        'txtRefResolucion
        '
        Me.txtRefResolucion.Location = New System.Drawing.Point(290, 132)
        Me.txtRefResolucion.MenuManager = Me.RibbonControl
        Me.txtRefResolucion.Name = "txtRefResolucion"
        Me.txtRefResolucion.Size = New System.Drawing.Size(320, 20)
        Me.txtRefResolucion.TabIndex = 20
        '
        'SaimtLabel18
        '
        Me.SaimtLabel18.Location = New System.Drawing.Point(207, 135)
        Me.SaimtLabel18.Name = "SaimtLabel18"
        Me.SaimtLabel18.Size = New System.Drawing.Size(75, 13)
        Me.SaimtLabel18.TabIndex = 19
        Me.SaimtLabel18.Text = "Ref. Resolución"
        '
        'txtRemuneracion
        '
        Me.txtRemuneracion.Location = New System.Drawing.Point(96, 132)
        Me.txtRemuneracion.MenuManager = Me.RibbonControl
        Me.txtRemuneracion.Name = "txtRemuneracion"
        Me.txtRemuneracion.Properties.Mask.EditMask = "n2"
        Me.txtRemuneracion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRemuneracion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRemuneracion.Size = New System.Drawing.Size(88, 20)
        Me.txtRemuneracion.TabIndex = 18
        '
        'SaimtLabel17
        '
        Me.SaimtLabel17.Location = New System.Drawing.Point(26, 135)
        Me.SaimtLabel17.Name = "SaimtLabel17"
        Me.SaimtLabel17.Size = New System.Drawing.Size(68, 13)
        Me.SaimtLabel17.TabIndex = 17
        Me.SaimtLabel17.Text = "Remuneración"
        '
        'spnNroSueldos
        '
        Me.spnNroSueldos.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnNroSueldos.Location = New System.Drawing.Point(313, 65)
        Me.spnNroSueldos.MenuManager = Me.RibbonControl
        Me.spnNroSueldos.Name = "spnNroSueldos"
        Me.spnNroSueldos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spnNroSueldos.Properties.Mask.EditMask = "f0"
        Me.spnNroSueldos.Size = New System.Drawing.Size(138, 20)
        Me.spnNroSueldos.TabIndex = 11
        '
        'SaimtLabel16
        '
        Me.SaimtLabel16.Location = New System.Drawing.Point(247, 68)
        Me.SaimtLabel16.Name = "SaimtLabel16"
        Me.SaimtLabel16.Size = New System.Drawing.Size(57, 13)
        Me.SaimtLabel16.TabIndex = 10
        Me.SaimtLabel16.Text = "Nro Sueldos"
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(426, 104)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(0, 13)
        Me.SaimtLabel15.TabIndex = 16
        '
        'cboTipoContrato
        '
        Me.cboTipoContrato.Location = New System.Drawing.Point(96, 65)
        Me.cboTipoContrato.MenuManager = Me.RibbonControl
        Me.cboTipoContrato.Name = "cboTipoContrato"
        Me.cboTipoContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoContrato.Properties.NullText = ""
        Me.cboTipoContrato.Size = New System.Drawing.Size(128, 20)
        Me.cboTipoContrato.TabIndex = 9
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(2, 68)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(94, 13)
        Me.SaimtLabel14.TabIndex = 8
        Me.SaimtLabel14.Text = "Modalidad Contrato"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(269, 41)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(35, 13)
        Me.SaimtLabel9.TabIndex = 5
        Me.SaimtLabel9.Text = "Horario"
        '
        'cboEstadoContrato
        '
        Me.cboEstadoContrato.Location = New System.Drawing.Point(96, 39)
        Me.cboEstadoContrato.MenuManager = Me.RibbonControl
        Me.cboEstadoContrato.Name = "cboEstadoContrato"
        Me.cboEstadoContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstadoContrato.Properties.NullText = ""
        Me.cboEstadoContrato.Size = New System.Drawing.Size(128, 20)
        Me.cboEstadoContrato.TabIndex = 4
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(15, 42)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(79, 13)
        Me.SaimtLabel8.TabIndex = 6
        Me.SaimtLabel8.Text = "Estado Contrato"
        '
        'dtpFechaFinDC
        '
        Me.dtpFechaFinDC.EditValue = Nothing
        Me.dtpFechaFinDC.Location = New System.Drawing.Point(311, 11)
        Me.dtpFechaFinDC.MenuManager = Me.RibbonControl
        Me.dtpFechaFinDC.Name = "dtpFechaFinDC"
        Me.dtpFechaFinDC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFinDC.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaFinDC.Size = New System.Drawing.Size(140, 20)
        Me.dtpFechaFinDC.TabIndex = 3
        '
        'dtpFechaInicioDC
        '
        Me.dtpFechaInicioDC.EditValue = Nothing
        Me.dtpFechaInicioDC.Location = New System.Drawing.Point(96, 11)
        Me.dtpFechaInicioDC.MenuManager = Me.RibbonControl
        Me.dtpFechaInicioDC.Name = "dtpFechaInicioDC"
        Me.dtpFechaInicioDC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicioDC.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaInicioDC.Size = New System.Drawing.Size(128, 20)
        Me.dtpFechaInicioDC.TabIndex = 1
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(258, 14)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(46, 13)
        Me.SaimtLabel7.TabIndex = 2
        Me.SaimtLabel7.Text = "Fecha Fin"
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(37, 14)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(57, 13)
        Me.SaimtLabel6.TabIndex = 0
        Me.SaimtLabel6.Text = "Fecha Inicio"
        '
        'BackstageViewClientControl2
        '
        Me.BackstageViewClientControl2.Controls.Add(Me.SaimtTabs2)
        Me.BackstageViewClientControl2.Location = New System.Drawing.Point(133, 0)
        Me.BackstageViewClientControl2.Name = "BackstageViewClientControl2"
        Me.BackstageViewClientControl2.Size = New System.Drawing.Size(629, 426)
        Me.BackstageViewClientControl2.TabIndex = 1
        '
        'SaimtTabs2
        '
        Me.SaimtTabs2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtTabs2.Location = New System.Drawing.Point(0, 0)
        Me.SaimtTabs2.Name = "SaimtTabs2"
        Me.SaimtTabs2.SelectedTabPage = Me.XtraTabPage2
        Me.SaimtTabs2.Size = New System.Drawing.Size(629, 425)
        Me.SaimtTabs2.TabIndex = 0
        Me.SaimtTabs2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.btnDesactivarCargo)
        Me.XtraTabPage2.Controls.Add(Me.cboCargo)
        Me.XtraTabPage2.Controls.Add(Me.cboArea)
        Me.XtraTabPage2.Controls.Add(Me.btnQuitarCargo)
        Me.XtraTabPage2.Controls.Add(Me.btnAgregarCargo)
        Me.XtraTabPage2.Controls.Add(Me.dgvCargos)
        Me.XtraTabPage2.Controls.Add(Me.dtpFechaFinCargos)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel34)
        Me.XtraTabPage2.Controls.Add(Me.dtpFechaInicioCargos)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel33)
        Me.XtraTabPage2.Controls.Add(Me.cboTipoCargo)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel32)
        Me.XtraTabPage2.Controls.Add(Me.chkCargoActivo)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel31)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel30)
        Me.XtraTabPage2.Controls.Add(Me.txtInstitucion)
        Me.XtraTabPage2.Controls.Add(Me.SaimtLabel29)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(623, 397)
        Me.XtraTabPage2.Text = "Asignación de Cargos al Trabajador"
        '
        'btnDesactivarCargo
        '
        Me.btnDesactivarCargo.Location = New System.Drawing.Point(472, 117)
        Me.btnDesactivarCargo.Name = "btnDesactivarCargo"
        Me.btnDesactivarCargo.Size = New System.Drawing.Size(75, 23)
        Me.btnDesactivarCargo.TabIndex = 13
        Me.btnDesactivarCargo.Text = "Desactivar"
        '
        'cboCargo
        '
        Me.cboCargo.Location = New System.Drawing.Point(69, 72)
        Me.cboCargo.MenuManager = Me.RibbonControl
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCargo.Properties.NullText = ""
        Me.cboCargo.Size = New System.Drawing.Size(325, 20)
        Me.cboCargo.TabIndex = 7
        '
        'cboArea
        '
        Me.cboArea.Location = New System.Drawing.Point(69, 45)
        Me.cboArea.MenuManager = Me.RibbonControl
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboArea.Properties.NullText = ""
        Me.cboArea.Size = New System.Drawing.Size(325, 20)
        Me.cboArea.TabIndex = 3
        '
        'btnQuitarCargo
        '
        Me.btnQuitarCargo.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnQuitarCargo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuitarCargo.Location = New System.Drawing.Point(593, 117)
        Me.btnQuitarCargo.LookAndFeel.SkinName = "Seven"
        Me.btnQuitarCargo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnQuitarCargo.Name = "btnQuitarCargo"
        Me.btnQuitarCargo.Size = New System.Drawing.Size(25, 21)
        Me.btnQuitarCargo.TabIndex = 15
        '
        'btnAgregarCargo
        '
        Me.btnAgregarCargo.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregarCargo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregarCargo.Location = New System.Drawing.Point(566, 117)
        Me.btnAgregarCargo.LookAndFeel.SkinName = "Seven"
        Me.btnAgregarCargo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregarCargo.Name = "btnAgregarCargo"
        Me.btnAgregarCargo.Size = New System.Drawing.Size(25, 21)
        Me.btnAgregarCargo.TabIndex = 14
        '
        'dgvCargos
        '
        Me.dgvCargos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCargos.Location = New System.Drawing.Point(0, 150)
        Me.dgvCargos.MainView = Me.gvCargos
        Me.dgvCargos.MenuManager = Me.RibbonControl
        Me.dgvCargos.Name = "dgvCargos"
        Me.dgvCargos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.dgvCargos.Size = New System.Drawing.Size(623, 247)
        Me.dgvCargos.TabIndex = 16
        Me.dgvCargos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCargos})
        '
        'gvCargos
        '
        Me.gvCargos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn10, Me.GridColumn2, Me.GridColumn11, Me.GridColumn3, Me.GridColumn12, Me.GridColumn4, Me.GridColumn9, Me.GridColumn7, Me.GridColumn5, Me.GridColumn6, Me.GridColumn8})
        Me.gvCargos.GridControl = Me.dgvCargos
        Me.gvCargos.Name = "gvCargos"
        Me.gvCargos.OptionsView.ColumnAutoWidth = False
        Me.gvCargos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Cargo Personal"
        Me.GridColumn1.FieldName = "carPerId"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Cod. Institución"
        Me.GridColumn10.FieldName = "codInstitucion"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Institución"
        Me.GridColumn2.FieldName = "institucion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Cod. Area"
        Me.GridColumn11.FieldName = "codArea"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Área "
        Me.GridColumn3.FieldName = "area"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Cod. Cargo"
        Me.GridColumn12.FieldName = "codCargo"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cargo"
        Me.GridColumn4.FieldName = "cargo"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Cod. Tipo Cargo"
        Me.GridColumn9.FieldName = "tgTipoCargoId"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tipo Cargo"
        Me.GridColumn7.FieldName = "tipocargo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha Inicio"
        Me.GridColumn5.FieldName = "carPerFechaIni"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha Fin"
        Me.GridColumn6.FieldName = "carPerFechaFin"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Activo?"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn8.FieldName = "tgEstadoId"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'dtpFechaFinCargos
        '
        Me.dtpFechaFinCargos.EditValue = Nothing
        Me.dtpFechaFinCargos.Location = New System.Drawing.Point(269, 101)
        Me.dtpFechaFinCargos.MenuManager = Me.RibbonControl
        Me.dtpFechaFinCargos.Name = "dtpFechaFinCargos"
        Me.dtpFechaFinCargos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFinCargos.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaFinCargos.Size = New System.Drawing.Size(125, 20)
        Me.dtpFechaFinCargos.TabIndex = 12
        '
        'SaimtLabel34
        '
        Me.SaimtLabel34.Location = New System.Drawing.Point(215, 104)
        Me.SaimtLabel34.Name = "SaimtLabel34"
        Me.SaimtLabel34.Size = New System.Drawing.Size(46, 13)
        Me.SaimtLabel34.TabIndex = 11
        Me.SaimtLabel34.Text = "Fecha Fin"
        '
        'dtpFechaInicioCargos
        '
        Me.dtpFechaInicioCargos.EditValue = Nothing
        Me.dtpFechaInicioCargos.Location = New System.Drawing.Point(69, 101)
        Me.dtpFechaInicioCargos.MenuManager = Me.RibbonControl
        Me.dtpFechaInicioCargos.Name = "dtpFechaInicioCargos"
        Me.dtpFechaInicioCargos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicioCargos.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaInicioCargos.Size = New System.Drawing.Size(125, 20)
        Me.dtpFechaInicioCargos.TabIndex = 10
        '
        'SaimtLabel33
        '
        Me.SaimtLabel33.Location = New System.Drawing.Point(9, 104)
        Me.SaimtLabel33.Name = "SaimtLabel33"
        Me.SaimtLabel33.Size = New System.Drawing.Size(57, 13)
        Me.SaimtLabel33.TabIndex = 9
        Me.SaimtLabel33.Text = "Fecha Inicio"
        '
        'cboTipoCargo
        '
        Me.cboTipoCargo.Location = New System.Drawing.Point(472, 45)
        Me.cboTipoCargo.MenuManager = Me.RibbonControl
        Me.cboTipoCargo.Name = "cboTipoCargo"
        Me.cboTipoCargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoCargo.Properties.NullText = ""
        Me.cboTipoCargo.Size = New System.Drawing.Size(137, 20)
        Me.cboTipoCargo.TabIndex = 5
        '
        'SaimtLabel32
        '
        Me.SaimtLabel32.Location = New System.Drawing.Point(399, 48)
        Me.SaimtLabel32.Name = "SaimtLabel32"
        Me.SaimtLabel32.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel32.TabIndex = 4
        Me.SaimtLabel32.Text = "Tipo de Cargo"
        '
        'chkCargoActivo
        '
        Me.chkCargoActivo.Location = New System.Drawing.Point(426, 73)
        Me.chkCargoActivo.MenuManager = Me.RibbonControl
        Me.chkCargoActivo.Name = "chkCargoActivo"
        Me.chkCargoActivo.Properties.AutoWidth = True
        Me.chkCargoActivo.Properties.Caption = "Check si es el cargo esta activo"
        Me.chkCargoActivo.Size = New System.Drawing.Size(172, 19)
        Me.chkCargoActivo.TabIndex = 8
        '
        'SaimtLabel31
        '
        Me.SaimtLabel31.Location = New System.Drawing.Point(34, 76)
        Me.SaimtLabel31.Name = "SaimtLabel31"
        Me.SaimtLabel31.Size = New System.Drawing.Size(29, 13)
        Me.SaimtLabel31.TabIndex = 6
        Me.SaimtLabel31.Text = "Cargo"
        '
        'SaimtLabel30
        '
        Me.SaimtLabel30.Location = New System.Drawing.Point(40, 48)
        Me.SaimtLabel30.Name = "SaimtLabel30"
        Me.SaimtLabel30.Size = New System.Drawing.Size(23, 13)
        Me.SaimtLabel30.TabIndex = 2
        Me.SaimtLabel30.Text = "Área"
        '
        'txtInstitucion
        '
        Me.txtInstitucion.Location = New System.Drawing.Point(69, 16)
        Me.txtInstitucion.MenuManager = Me.RibbonControl
        Me.txtInstitucion.Name = "txtInstitucion"
        Me.txtInstitucion.Size = New System.Drawing.Size(521, 20)
        Me.txtInstitucion.TabIndex = 1
        '
        'SaimtLabel29
        '
        Me.SaimtLabel29.Location = New System.Drawing.Point(13, 19)
        Me.SaimtLabel29.Name = "SaimtLabel29"
        Me.SaimtLabel29.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel29.TabIndex = 0
        Me.SaimtLabel29.Text = "Institución"
        '
        'BackstageViewClientControl3
        '
        Me.BackstageViewClientControl3.Controls.Add(Me.SaimtGroupBox2)
        Me.BackstageViewClientControl3.Location = New System.Drawing.Point(133, 0)
        Me.BackstageViewClientControl3.Name = "BackstageViewClientControl3"
        Me.BackstageViewClientControl3.Size = New System.Drawing.Size(629, 426)
        Me.BackstageViewClientControl3.TabIndex = 2
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.cboNivelRemunerativo)
        Me.SaimtGroupBox2.Controls.Add(Me.cboGradoOcupacional)
        Me.SaimtGroupBox2.Controls.Add(Me.cboFormacionProfecional)
        Me.SaimtGroupBox2.Controls.Add(Me.cboNivelEstudio)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel44)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel43)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel42)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel41)
        Me.SaimtGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(629, 425)
        Me.SaimtGroupBox2.TabIndex = 0
        Me.SaimtGroupBox2.Text = "Datos para Perfil Académico"
        '
        'cboNivelRemunerativo
        '
        Me.cboNivelRemunerativo.Location = New System.Drawing.Point(122, 129)
        Me.cboNivelRemunerativo.MenuManager = Me.RibbonControl
        Me.cboNivelRemunerativo.Name = "cboNivelRemunerativo"
        Me.cboNivelRemunerativo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNivelRemunerativo.Properties.NullText = ""
        Me.cboNivelRemunerativo.Size = New System.Drawing.Size(484, 20)
        Me.cboNivelRemunerativo.TabIndex = 7
        '
        'cboGradoOcupacional
        '
        Me.cboGradoOcupacional.Location = New System.Drawing.Point(122, 97)
        Me.cboGradoOcupacional.MenuManager = Me.RibbonControl
        Me.cboGradoOcupacional.Name = "cboGradoOcupacional"
        Me.cboGradoOcupacional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGradoOcupacional.Properties.NullText = ""
        Me.cboGradoOcupacional.Size = New System.Drawing.Size(484, 20)
        Me.cboGradoOcupacional.TabIndex = 6
        '
        'cboFormacionProfecional
        '
        Me.cboFormacionProfecional.Location = New System.Drawing.Point(122, 65)
        Me.cboFormacionProfecional.MenuManager = Me.RibbonControl
        Me.cboFormacionProfecional.Name = "cboFormacionProfecional"
        Me.cboFormacionProfecional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFormacionProfecional.Properties.NullText = ""
        Me.cboFormacionProfecional.Size = New System.Drawing.Size(484, 20)
        Me.cboFormacionProfecional.TabIndex = 5
        '
        'cboNivelEstudio
        '
        Me.cboNivelEstudio.Location = New System.Drawing.Point(122, 33)
        Me.cboNivelEstudio.MenuManager = Me.RibbonControl
        Me.cboNivelEstudio.Name = "cboNivelEstudio"
        Me.cboNivelEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNivelEstudio.Properties.NullText = ""
        Me.cboNivelEstudio.Size = New System.Drawing.Size(484, 20)
        Me.cboNivelEstudio.TabIndex = 4
        '
        'SaimtLabel44
        '
        Me.SaimtLabel44.Location = New System.Drawing.Point(23, 132)
        Me.SaimtLabel44.Name = "SaimtLabel44"
        Me.SaimtLabel44.Size = New System.Drawing.Size(93, 13)
        Me.SaimtLabel44.TabIndex = 3
        Me.SaimtLabel44.Text = "Nivel Remunerativo"
        '
        'SaimtLabel43
        '
        Me.SaimtLabel43.Location = New System.Drawing.Point(26, 100)
        Me.SaimtLabel43.Name = "SaimtLabel43"
        Me.SaimtLabel43.Size = New System.Drawing.Size(90, 13)
        Me.SaimtLabel43.TabIndex = 2
        Me.SaimtLabel43.Text = "Grupo Ocupacional"
        '
        'SaimtLabel42
        '
        Me.SaimtLabel42.Location = New System.Drawing.Point(11, 68)
        Me.SaimtLabel42.Name = "SaimtLabel42"
        Me.SaimtLabel42.Size = New System.Drawing.Size(105, 13)
        Me.SaimtLabel42.TabIndex = 1
        Me.SaimtLabel42.Text = "Formación Profesional"
        '
        'SaimtLabel41
        '
        Me.SaimtLabel41.Location = New System.Drawing.Point(40, 36)
        Me.SaimtLabel41.Name = "SaimtLabel41"
        Me.SaimtLabel41.Size = New System.Drawing.Size(76, 13)
        Me.SaimtLabel41.TabIndex = 0
        Me.SaimtLabel41.Text = "Nivel de Estudio"
        '
        'BackstageViewClientControl4
        '
        Me.BackstageViewClientControl4.Controls.Add(Me.txtPrimaSegAFP)
        Me.BackstageViewClientControl4.Controls.Add(Me.SaimtLabel48)
        Me.BackstageViewClientControl4.Controls.Add(Me.txtComisionAFP)
        Me.BackstageViewClientControl4.Controls.Add(Me.SaimtLabel47)
        Me.BackstageViewClientControl4.Controls.Add(Me.SaimtLabel46)
        Me.BackstageViewClientControl4.Controls.Add(Me.txtAporteObligatorioAFP)
        Me.BackstageViewClientControl4.Controls.Add(Me.cboAFP)
        Me.BackstageViewClientControl4.Controls.Add(Me.SaimtLabel45)
        Me.BackstageViewClientControl4.Location = New System.Drawing.Point(133, 0)
        Me.BackstageViewClientControl4.Name = "BackstageViewClientControl4"
        Me.BackstageViewClientControl4.Size = New System.Drawing.Size(629, 426)
        Me.BackstageViewClientControl4.TabIndex = 3
        '
        'txtPrimaSegAFP
        '
        Me.txtPrimaSegAFP.Location = New System.Drawing.Point(516, 14)
        Me.txtPrimaSegAFP.MenuManager = Me.RibbonControl
        Me.txtPrimaSegAFP.Name = "txtPrimaSegAFP"
        Me.txtPrimaSegAFP.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimaSegAFP.TabIndex = 60
        '
        'SaimtLabel48
        '
        Me.SaimtLabel48.Location = New System.Drawing.Point(518, 1)
        Me.SaimtLabel48.Name = "SaimtLabel48"
        Me.SaimtLabel48.Size = New System.Drawing.Size(66, 13)
        Me.SaimtLabel48.TabIndex = 59
        Me.SaimtLabel48.Text = "Prima de Seg."
        '
        'txtComisionAFP
        '
        Me.txtComisionAFP.Location = New System.Drawing.Point(411, 14)
        Me.txtComisionAFP.MenuManager = Me.RibbonControl
        Me.txtComisionAFP.Name = "txtComisionAFP"
        Me.txtComisionAFP.Size = New System.Drawing.Size(100, 20)
        Me.txtComisionAFP.TabIndex = 58
        '
        'SaimtLabel47
        '
        Me.SaimtLabel47.Location = New System.Drawing.Point(412, 1)
        Me.SaimtLabel47.Name = "SaimtLabel47"
        Me.SaimtLabel47.Size = New System.Drawing.Size(42, 13)
        Me.SaimtLabel47.TabIndex = 57
        Me.SaimtLabel47.Text = "Comisión"
        '
        'SaimtLabel46
        '
        Me.SaimtLabel46.Location = New System.Drawing.Point(307, 1)
        Me.SaimtLabel46.Name = "SaimtLabel46"
        Me.SaimtLabel46.Size = New System.Drawing.Size(88, 13)
        Me.SaimtLabel46.TabIndex = 56
        Me.SaimtLabel46.Text = "Aporte Obligatorio"
        '
        'txtAporteObligatorioAFP
        '
        Me.txtAporteObligatorioAFP.Location = New System.Drawing.Point(306, 14)
        Me.txtAporteObligatorioAFP.MenuManager = Me.RibbonControl
        Me.txtAporteObligatorioAFP.Name = "txtAporteObligatorioAFP"
        Me.txtAporteObligatorioAFP.Size = New System.Drawing.Size(100, 20)
        Me.txtAporteObligatorioAFP.TabIndex = 55
        '
        'cboAFP
        '
        Me.cboAFP.Location = New System.Drawing.Point(9, 14)
        Me.cboAFP.MenuManager = Me.RibbonControl
        Me.cboAFP.Name = "cboAFP"
        Me.cboAFP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAFP.Properties.NullText = ""
        Me.cboAFP.Size = New System.Drawing.Size(291, 20)
        Me.cboAFP.TabIndex = 54
        '
        'SaimtLabel45
        '
        Me.SaimtLabel45.Location = New System.Drawing.Point(12, 1)
        Me.SaimtLabel45.Name = "SaimtLabel45"
        Me.SaimtLabel45.Size = New System.Drawing.Size(103, 13)
        Me.SaimtLabel45.TabIndex = 53
        Me.SaimtLabel45.Text = "Sistema de Pensiones"
        '
        'BackstageViewTabItem1
        '
        Me.BackstageViewTabItem1.Caption = "Contrato"
        Me.BackstageViewTabItem1.ContentControl = Me.BackstageViewClientControl1
        Me.BackstageViewTabItem1.Glyph = CType(resources.GetObject("BackstageViewTabItem1.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem1.Name = "BackstageViewTabItem1"
        Me.BackstageViewTabItem1.Selected = False
        '
        'BackstageViewItemSeparator1
        '
        Me.BackstageViewItemSeparator1.Name = "BackstageViewItemSeparator1"
        '
        'BackstageViewTabItem2
        '
        Me.BackstageViewTabItem2.Caption = "Cargos"
        Me.BackstageViewTabItem2.ContentControl = Me.BackstageViewClientControl2
        Me.BackstageViewTabItem2.Glyph = CType(resources.GetObject("BackstageViewTabItem2.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem2.Name = "BackstageViewTabItem2"
        Me.BackstageViewTabItem2.Selected = False
        '
        'BackstageViewItemSeparator2
        '
        Me.BackstageViewItemSeparator2.Name = "BackstageViewItemSeparator2"
        '
        'BackstageViewTabItem3
        '
        Me.BackstageViewTabItem3.Caption = "Perfil Acad."
        Me.BackstageViewTabItem3.ContentControl = Me.BackstageViewClientControl3
        Me.BackstageViewTabItem3.Glyph = CType(resources.GetObject("BackstageViewTabItem3.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem3.Name = "BackstageViewTabItem3"
        Me.BackstageViewTabItem3.Selected = False
        '
        'BackstageViewItemSeparator3
        '
        Me.BackstageViewItemSeparator3.Name = "BackstageViewItemSeparator3"
        '
        'BackstageViewTabItem4
        '
        Me.BackstageViewTabItem4.Caption = "Planilla"
        Me.BackstageViewTabItem4.ContentControl = Me.BackstageViewClientControl4
        Me.BackstageViewTabItem4.Glyph = CType(resources.GetObject("BackstageViewTabItem4.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem4.Name = "BackstageViewTabItem4"
        Me.BackstageViewTabItem4.Selected = True
        '
        'frmTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(1126, 753)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.dgvListado = Me.dgvListadoTrabajador
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmTrabajador"
        Me.Tag = "btiTrabajador"
        Me.Text = "TRABAJADOR"
        Me.txtBuscarSaimt = Me.txtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.cboBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.dgvListadoTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTabs3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs3.ResumeLayout(False)
        Me.xtpDatosTrabajador.ResumeLayout(False)
        Me.xtpDatosTrabajador.PerformLayout()
        CType(Me.txtDistrito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProvincia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDomicilio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDatosContacto.ResumeLayout(False)
        CType(Me.dgvDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox4.ResumeLayout(False)
        Me.BackstageViewControl1.ResumeLayout(False)
        Me.BackstageViewClientControl1.ResumeLayout(False)
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtNroSeguroSocial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSeguroSocial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRUC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadHijos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoCivil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbHorario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInforme.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInforme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefInforme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaProveido.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaProveido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefProveido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRequerimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRequerimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefRequerimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaOficio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaOficio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefOficio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaResolucion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemuneracion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnNroSueldos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFinDC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFinDC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioDC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioDC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewClientControl2.ResumeLayout(False)
        CType(Me.SaimtTabs2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cboCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFinCargos.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFinCargos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioCargos.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioCargos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCargoActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewClientControl3.ResumeLayout(False)
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.cboNivelRemunerativo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGradoOcupacional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormacionProfecional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNivelEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewClientControl4.ResumeLayout(False)
        Me.BackstageViewClientControl4.PerformLayout()
        CType(Me.txtPrimaSegAFP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComisionAFP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAporteObligatorioAFP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAFP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents txtPersona As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtCodigoContrato As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtCodigoPersona As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtDomicilio As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents btnConsultarPersona As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox4 As SaimtControles.SaimtGroupBox
    Friend WithEvents BackstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Friend WithEvents BackstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents SaimtTabs1 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dtpFechaInforme As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel27 As SaimtControles.SaimtLabel
    Friend WithEvents txtRefInforme As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel26 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaProveido As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel25 As SaimtControles.SaimtLabel
    Friend WithEvents txtRefProveido As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel24 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaRequerimiento As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel23 As SaimtControles.SaimtLabel
    Friend WithEvents txtRefRequerimiento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel22 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaOficio As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel21 As SaimtControles.SaimtLabel
    Friend WithEvents txtRefOficio As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel20 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaResolucion As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel19 As SaimtControles.SaimtLabel
    Friend WithEvents txtRefResolucion As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel18 As SaimtControles.SaimtLabel
    Friend WithEvents txtRemuneracion As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel17 As SaimtControles.SaimtLabel
    Friend WithEvents spnNroSueldos As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel16 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoContrato As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents cboEstadoContrato As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaFinDC As SaimtControles.SaimtDateTimePicker
    Friend WithEvents dtpFechaInicioDC As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents BackstageViewClientControl2 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewTabItem1 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem2 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator2 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents SaimtTabs2 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtInstitucion As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel29 As SaimtControles.SaimtLabel
    Friend WithEvents dgvCargos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvCargos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtpFechaFinCargos As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel34 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaInicioCargos As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel33 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoCargo As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel32 As SaimtControles.SaimtLabel
    Friend WithEvents chkCargoActivo As SaimtControles.SaimtCheckBox
    Friend WithEvents SaimtLabel31 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel30 As SaimtControles.SaimtLabel
    Friend WithEvents btnQuitarCargo As SaimtControles.SaimtButton
    Friend WithEvents btnAgregarCargo As SaimtControles.SaimtButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cboCargo As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboArea As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDesactivarCargo As SaimtControles.SaimtButton
    Friend WithEvents cbHorario As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtCantidadHijos As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents cboEstadoCivil As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents cboBanco As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents txtNroCuenta As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents cboSucursal As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel28 As SaimtControles.SaimtLabel
    Friend WithEvents txtRUC As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel35 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroSeguroSocial As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel37 As SaimtControles.SaimtLabel
    Friend WithEvents cboSeguroSocial As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel36 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtTabs3 As SaimtControles.SaimtTabs
    Friend WithEvents xtpDatosTrabajador As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpDatosContacto As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgvDatosAdicionales As SaimtControles.SaimtDataGrid
    Friend WithEvents gvDatosAdicionales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvListadoTrabajador As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoTrabajador As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboBuscarPor As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboCriterios As SaimtControles.SaimtComboBox
    Friend WithEvents txtDistrito As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel40 As SaimtControles.SaimtLabel
    Friend WithEvents txtProvincia As SaimtControles.SaimtTextBox
    Friend WithEvents txtDepartamento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel39 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel38 As SaimtControles.SaimtLabel
    Friend WithEvents BackstageViewClientControl3 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewTabItem3 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents cboNivelRemunerativo As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboGradoOcupacional As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboFormacionProfecional As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboNivelEstudio As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel44 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel43 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel42 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel41 As SaimtControles.SaimtLabel
    Friend WithEvents BackstageViewClientControl4 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents txtPrimaSegAFP As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel48 As SaimtControles.SaimtLabel
    Friend WithEvents txtComisionAFP As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel47 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel46 As SaimtControles.SaimtLabel
    Friend WithEvents txtAporteObligatorioAFP As SaimtControles.SaimtTextBox
    Friend WithEvents cboAFP As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel45 As SaimtControles.SaimtLabel
    Friend WithEvents BackstageViewItemSeparator3 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem4 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
End Class