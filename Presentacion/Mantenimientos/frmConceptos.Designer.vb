<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConceptos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConceptos))
        Me.grbLista = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoConcepto = New SaimtControles.SaimtDataGrid()
        Me.gvResultados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.txtBaseLegal = New SaimtControles.SaimtTextBoxMultiline()
        Me.btnAgregarCuentaHaber = New SaimtControles.SaimtButton()
        Me.btnAgregarCuentaDebe = New SaimtControles.SaimtButton()
        Me.txtCuentaBancaria = New SaimtControles.SaimtTextBox()
        Me.btnAgregarPartida = New SaimtControles.SaimtButton()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.txtImporte = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.txtCodPresupuestarioMPT = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.txtCodContableMPT = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.chkMora = New SaimtControles.SaimtCheckBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.chkActivo = New SaimtControles.SaimtCheckBox()
        Me.cboSubGrupoConcepto = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.cboGrupoConcepto = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.txtCuentaHaber = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.txtCuentaDebe = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtPorcSAIMT = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.txtPartida = New SaimtControles.SaimtTextBox()
        Me.cboFuenteFinanciera = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel16 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.txtConId = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtConcepto = New SaimtControles.SaimtTextBox()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.cboFiltroAño = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboBuscarPor = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCriterios = New SaimtControles.SaimtComboBox()
        Me.SaimtTabs1 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.cboAño = New SaimtControles.SaimtComboBoxLookUp()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcPartidas = New SaimtControles.SaimtDataGrid()
        Me.gvPartidas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SaimtButton1 = New SaimtControles.SaimtButton()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLista.SuspendLayout()
        CType(Me.dgvListadoConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBaseLegal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaBancaria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPresupuestarioMPT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodContableMPT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSubGrupoConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupoConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaHaber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaDebe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcSAIMT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFuenteFinanciera.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.cboFiltroAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.cboAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 705)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1097, 27)
        '
        'grbLista
        '
        Me.grbLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbLista.Controls.Add(Me.dgvListadoConcepto)
        Me.grbLista.Location = New System.Drawing.Point(7, 95)
        Me.grbLista.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbLista.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbLista.Name = "grbLista"
        Me.grbLista.Size = New System.Drawing.Size(391, 604)
        Me.grbLista.TabIndex = 6
        Me.grbLista.Text = "Resultado de Busquedas"
        '
        'dgvListadoConcepto
        '
        Me.dgvListadoConcepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoConcepto.Location = New System.Drawing.Point(2, 22)
        Me.dgvListadoConcepto.MainView = Me.gvResultados
        Me.dgvListadoConcepto.MenuManager = Me.RibbonControl
        Me.dgvListadoConcepto.Name = "dgvListadoConcepto"
        Me.dgvListadoConcepto.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.dgvListadoConcepto.Size = New System.Drawing.Size(387, 580)
        Me.dgvListadoConcepto.TabIndex = 0
        Me.dgvListadoConcepto.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResultados})
        '
        'gvResultados
        '
        Me.gvResultados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn8, Me.GridColumn9, Me.GridColumn3})
        Me.gvResultados.GridControl = Me.dgvListadoConcepto
        Me.gvResultados.Name = "gvResultados"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Concepto"
        Me.GridColumn1.FieldName = "ConId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Concepto"
        Me.GridColumn2.FieldName = "ConNombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Grupo Concepto"
        Me.GridColumn8.FieldName = "TgGrupoCon"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Esta Activo?"
        Me.GridColumn9.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn9.FieldName = "ConActivo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "conAnio"
        Me.GridColumn3.FieldName = "conAnio"
        Me.GridColumn3.Name = "GridColumn3"
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
        Me.txtBuscarPor.Size = New System.Drawing.Size(392, 20)
        Me.txtBuscarPor.TabIndex = 5
        Me.txtBuscarPor.Tag = "NotClear"
        '
        'txtBaseLegal
        '
        Me.txtBaseLegal.Location = New System.Drawing.Point(105, 209)
        Me.txtBaseLegal.MenuManager = Me.RibbonControl
        Me.txtBaseLegal.Name = "txtBaseLegal"
        Me.txtBaseLegal.Size = New System.Drawing.Size(536, 78)
        Me.txtBaseLegal.TabIndex = 26
        '
        'btnAgregarCuentaHaber
        '
        Me.btnAgregarCuentaHaber.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnAgregarCuentaHaber.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregarCuentaHaber.Location = New System.Drawing.Point(620, 147)
        Me.btnAgregarCuentaHaber.Name = "btnAgregarCuentaHaber"
        Me.btnAgregarCuentaHaber.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarCuentaHaber.TabIndex = 19
        '
        'btnAgregarCuentaDebe
        '
        Me.btnAgregarCuentaDebe.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnAgregarCuentaDebe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregarCuentaDebe.Location = New System.Drawing.Point(620, 120)
        Me.btnAgregarCuentaDebe.Name = "btnAgregarCuentaDebe"
        Me.btnAgregarCuentaDebe.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarCuentaDebe.TabIndex = 17
        '
        'txtCuentaBancaria
        '
        Me.txtCuentaBancaria.Location = New System.Drawing.Point(105, 95)
        Me.txtCuentaBancaria.MenuManager = Me.RibbonControl
        Me.txtCuentaBancaria.Name = "txtCuentaBancaria"
        Me.txtCuentaBancaria.Size = New System.Drawing.Size(130, 20)
        Me.txtCuentaBancaria.TabIndex = 12
        '
        'btnAgregarPartida
        '
        Me.btnAgregarPartida.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnAgregarPartida.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregarPartida.Location = New System.Drawing.Point(620, 16)
        Me.btnAgregarPartida.Name = "btnAgregarPartida"
        Me.btnAgregarPartida.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarPartida.TabIndex = 4
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(473, 46)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(19, 13)
        Me.SaimtLabel14.TabIndex = 6
        Me.SaimtLabel14.Text = "Año"
        '
        'txtImporte
        '
        Me.txtImporte.EditValue = ""
        Me.txtImporte.Location = New System.Drawing.Point(105, 319)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporte.Size = New System.Drawing.Size(104, 20)
        Me.txtImporte.TabIndex = 32
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(61, 322)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(38, 13)
        Me.SaimtLabel13.TabIndex = 31
        Me.SaimtLabel13.Text = "Importe"
        '
        'txtCodPresupuestarioMPT
        '
        Me.txtCodPresupuestarioMPT.EditValue = ""
        Me.txtCodPresupuestarioMPT.Location = New System.Drawing.Point(440, 293)
        Me.txtCodPresupuestarioMPT.Name = "txtCodPresupuestarioMPT"
        Me.txtCodPresupuestarioMPT.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPresupuestarioMPT.Size = New System.Drawing.Size(165, 20)
        Me.txtCodPresupuestarioMPT.TabIndex = 30
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(313, 296)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(121, 13)
        Me.SaimtLabel12.TabIndex = 29
        Me.SaimtLabel12.Text = "Cod. Presupuestario MPT"
        '
        'txtCodContableMPT
        '
        Me.txtCodContableMPT.EditValue = ""
        Me.txtCodContableMPT.Location = New System.Drawing.Point(105, 293)
        Me.txtCodContableMPT.Name = "txtCodContableMPT"
        Me.txtCodContableMPT.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodContableMPT.Size = New System.Drawing.Size(183, 20)
        Me.txtCodContableMPT.TabIndex = 28
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(12, 296)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(92, 13)
        Me.SaimtLabel11.TabIndex = 27
        Me.SaimtLabel11.Text = "Cod. Contable MPT"
        '
        'chkMora
        '
        Me.chkMora.Location = New System.Drawing.Point(240, 345)
        Me.chkMora.MenuManager = Me.RibbonControl
        Me.chkMora.Name = "chkMora"
        Me.chkMora.Properties.AutoWidth = True
        Me.chkMora.Properties.Caption = "Aplicar Mora"
        Me.chkMora.Size = New System.Drawing.Size(82, 19)
        Me.chkMora.TabIndex = 34
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(50, 212)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel7.TabIndex = 25
        Me.SaimtLabel7.Text = "Base Legal"
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(103, 345)
        Me.chkActivo.MenuManager = Me.RibbonControl
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.AutoWidth = True
        Me.chkActivo.Properties.Caption = "Activar Concepto"
        Me.chkActivo.Size = New System.Drawing.Size(106, 19)
        Me.chkActivo.TabIndex = 33
        '
        'cboSubGrupoConcepto
        '
        Me.cboSubGrupoConcepto.Location = New System.Drawing.Point(509, 178)
        Me.cboSubGrupoConcepto.MenuManager = Me.RibbonControl
        Me.cboSubGrupoConcepto.Name = "cboSubGrupoConcepto"
        Me.cboSubGrupoConcepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSubGrupoConcepto.Properties.NullText = ""
        Me.cboSubGrupoConcepto.Size = New System.Drawing.Size(132, 20)
        Me.cboSubGrupoConcepto.TabIndex = 24
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(403, 181)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(99, 13)
        Me.SaimtLabel6.TabIndex = 23
        Me.SaimtLabel6.Text = "Sub Grupo Concepto"
        '
        'cboGrupoConcepto
        '
        Me.cboGrupoConcepto.Location = New System.Drawing.Point(105, 178)
        Me.cboGrupoConcepto.MenuManager = Me.RibbonControl
        Me.cboGrupoConcepto.Name = "cboGrupoConcepto"
        Me.cboGrupoConcepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrupoConcepto.Properties.NullText = ""
        Me.cboGrupoConcepto.Size = New System.Drawing.Size(260, 20)
        Me.cboGrupoConcepto.TabIndex = 22
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(23, 181)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(78, 13)
        Me.SaimtLabel10.TabIndex = 21
        Me.SaimtLabel10.Text = "Grupo Concepto"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(32, 152)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel9.TabIndex = 18
        Me.SaimtLabel9.Text = "Cuenta Haber"
        '
        'txtCuentaHaber
        '
        Me.txtCuentaHaber.EditValue = ""
        Me.txtCuentaHaber.Location = New System.Drawing.Point(105, 149)
        Me.txtCuentaHaber.Name = "txtCuentaHaber"
        Me.txtCuentaHaber.Size = New System.Drawing.Size(511, 20)
        Me.txtCuentaHaber.TabIndex = 20
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(36, 124)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(63, 13)
        Me.SaimtLabel4.TabIndex = 15
        Me.SaimtLabel4.Text = "Cuenta Debe"
        '
        'txtCuentaDebe
        '
        Me.txtCuentaDebe.EditValue = ""
        Me.txtCuentaDebe.Location = New System.Drawing.Point(105, 121)
        Me.txtCuentaDebe.Name = "txtCuentaDebe"
        Me.txtCuentaDebe.Size = New System.Drawing.Size(511, 20)
        Me.txtCuentaDebe.TabIndex = 16
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(20, 98)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(79, 13)
        Me.SaimtLabel3.TabIndex = 11
        Me.SaimtLabel3.Text = "Cuenta Bancaria"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(295, 98)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(49, 13)
        Me.SaimtLabel2.TabIndex = 13
        Me.SaimtLabel2.Text = "% SAIMT:"
        '
        'txtPorcSAIMT
        '
        Me.txtPorcSAIMT.EditValue = ""
        Me.txtPorcSAIMT.Location = New System.Drawing.Point(356, 95)
        Me.txtPorcSAIMT.Name = "txtPorcSAIMT"
        Me.txtPorcSAIMT.Size = New System.Drawing.Size(91, 20)
        Me.txtPorcSAIMT.TabIndex = 14
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(254, 20)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(34, 13)
        Me.SaimtLabel8.TabIndex = 2
        Me.SaimtLabel8.Text = "Partida"
        '
        'txtPartida
        '
        Me.txtPartida.EditValue = ""
        Me.txtPartida.Location = New System.Drawing.Point(294, 17)
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.Size = New System.Drawing.Size(322, 20)
        Me.txtPartida.TabIndex = 3
        '
        'cboFuenteFinanciera
        '
        Me.cboFuenteFinanciera.Location = New System.Drawing.Point(105, 43)
        Me.cboFuenteFinanciera.MenuManager = Me.RibbonControl
        Me.cboFuenteFinanciera.Name = "cboFuenteFinanciera"
        Me.cboFuenteFinanciera.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFuenteFinanciera.Properties.NullText = ""
        Me.cboFuenteFinanciera.Size = New System.Drawing.Size(342, 20)
        Me.cboFuenteFinanciera.TabIndex = 5
        '
        'SaimtLabel16
        '
        Me.SaimtLabel16.Location = New System.Drawing.Point(13, 47)
        Me.SaimtLabel16.Name = "SaimtLabel16"
        Me.SaimtLabel16.Size = New System.Drawing.Size(86, 13)
        Me.SaimtLabel16.TabIndex = 7
        Me.SaimtLabel16.Text = "Fuente Financiera"
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(27, 20)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(72, 13)
        Me.SaimtLabel15.TabIndex = 0
        Me.SaimtLabel15.Text = "Cod. Concepto"
        '
        'txtConId
        '
        Me.txtConId.Location = New System.Drawing.Point(105, 17)
        Me.txtConId.MenuManager = Me.RibbonControl
        Me.txtConId.Name = "txtConId"
        Me.txtConId.Size = New System.Drawing.Size(130, 20)
        Me.txtConId.TabIndex = 1
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(50, 72)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(49, 13)
        Me.SaimtLabel5.TabIndex = 9
        Me.SaimtLabel5.Text = "Concepto "
        '
        'txtConcepto
        '
        Me.txtConcepto.EditValue = ""
        Me.txtConcepto.Location = New System.Drawing.Point(105, 69)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Size = New System.Drawing.Size(536, 20)
        Me.txtConcepto.TabIndex = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(347, 558)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(487, 558)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(277, 558)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(137, 558)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(417, 558)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(207, 558)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "Editar"
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboFiltroAño)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboCriterios)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.txtBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.grbLista)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtTabs1)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(1097, 705)
        Me.SaimtSplitContainerControl1.SplitterPosition = 403
        Me.SaimtSplitContainerControl1.TabIndex = 0
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'cboFiltroAño
        '
        Me.cboFiltroAño.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFiltroAño.Location = New System.Drawing.Point(324, 21)
        Me.cboFiltroAño.MenuManager = Me.RibbonControl
        Me.cboFiltroAño.Name = "cboFiltroAño"
        Me.cboFiltroAño.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFiltroAño.Properties.NullText = ""
        Me.cboFiltroAño.Size = New System.Drawing.Size(73, 20)
        Me.cboFiltroAño.TabIndex = 2
        Me.cboFiltroAño.Tag = "NotClear"
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
        Me.cboBuscarPor.Size = New System.Drawing.Size(390, 20)
        Me.cboBuscarPor.TabIndex = 3
        Me.cboBuscarPor.Tag = "0"
        '
        'cboCriterios
        '
        Me.cboCriterios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCriterios.EditValue = "Busqueda por Codigo Concepto"
        Me.cboCriterios.Location = New System.Drawing.Point(6, 21)
        Me.cboCriterios.MenuManager = Me.RibbonControl
        Me.cboCriterios.Name = "cboCriterios"
        Me.cboCriterios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterios.Properties.Items.AddRange(New Object() {"Cod. Concepto", "Concepto", "Partida", "Grupo Conceptos"})
        Me.cboCriterios.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCriterios.Size = New System.Drawing.Size(313, 20)
        Me.cboCriterios.TabIndex = 1
        Me.cboCriterios.Tag = "NotClear"
        '
        'SaimtTabs1
        '
        Me.SaimtTabs1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtTabs1.Location = New System.Drawing.Point(9, 6)
        Me.SaimtTabs1.Name = "SaimtTabs1"
        Me.SaimtTabs1.SelectedTabPage = Me.XtraTabPage1
        Me.SaimtTabs1.Size = New System.Drawing.Size(677, 693)
        Me.SaimtTabs1.TabIndex = 7
        Me.SaimtTabs1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.cboAño)
        Me.XtraTabPage1.Controls.Add(Me.txtBaseLegal)
        Me.XtraTabPage1.Controls.Add(Me.btnCancelar)
        Me.XtraTabPage1.Controls.Add(Me.btnAgregarCuentaHaber)
        Me.XtraTabPage1.Controls.Add(Me.btnEditar)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel15)
        Me.XtraTabPage1.Controls.Add(Me.btnEliminar)
        Me.XtraTabPage1.Controls.Add(Me.btnAgregarCuentaDebe)
        Me.XtraTabPage1.Controls.Add(Me.btnGuardar)
        Me.XtraTabPage1.Controls.Add(Me.txtConcepto)
        Me.XtraTabPage1.Controls.Add(Me.btnLimpiar)
        Me.XtraTabPage1.Controls.Add(Me.txtCuentaBancaria)
        Me.XtraTabPage1.Controls.Add(Me.btnNuevo)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel5)
        Me.XtraTabPage1.Controls.Add(Me.txtConId)
        Me.XtraTabPage1.Controls.Add(Me.btnAgregarPartida)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel16)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel14)
        Me.XtraTabPage1.Controls.Add(Me.cboFuenteFinanciera)
        Me.XtraTabPage1.Controls.Add(Me.txtImporte)
        Me.XtraTabPage1.Controls.Add(Me.txtPartida)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel13)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel8)
        Me.XtraTabPage1.Controls.Add(Me.txtCodPresupuestarioMPT)
        Me.XtraTabPage1.Controls.Add(Me.txtPorcSAIMT)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel12)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel2)
        Me.XtraTabPage1.Controls.Add(Me.txtCodContableMPT)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel3)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel11)
        Me.XtraTabPage1.Controls.Add(Me.txtCuentaDebe)
        Me.XtraTabPage1.Controls.Add(Me.chkMora)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel4)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel7)
        Me.XtraTabPage1.Controls.Add(Me.txtCuentaHaber)
        Me.XtraTabPage1.Controls.Add(Me.chkActivo)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel9)
        Me.XtraTabPage1.Controls.Add(Me.cboSubGrupoConcepto)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel10)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel6)
        Me.XtraTabPage1.Controls.Add(Me.cboGrupoConcepto)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(671, 667)
        Me.XtraTabPage1.Text = "Datos de Conceptos"
        '
        'cboAño
        '
        Me.cboAño.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAño.Location = New System.Drawing.Point(509, 43)
        Me.cboAño.MenuManager = Me.RibbonControl
        Me.cboAño.Name = "cboAño"
        Me.cboAño.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAño.Properties.NullText = ""
        Me.cboAño.Size = New System.Drawing.Size(132, 20)
        Me.cboAño.TabIndex = 35
        Me.cboAño.Tag = ""
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gcPartidas)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(671, 667)
        Me.XtraTabPage2.Text = "Conceptos X Año"
        '
        'gcPartidas
        '
        Me.gcPartidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPartidas.Location = New System.Drawing.Point(0, 0)
        Me.gcPartidas.MainView = Me.gvPartidas
        Me.gcPartidas.MenuManager = Me.RibbonControl
        Me.gcPartidas.Name = "gcPartidas"
        Me.gcPartidas.Size = New System.Drawing.Size(671, 605)
        Me.gcPartidas.TabIndex = 0
        Me.gcPartidas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPartidas})
        '
        'gvPartidas
        '
        Me.gvPartidas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26})
        Me.gvPartidas.GridControl = Me.gcPartidas
        Me.gvPartidas.Name = "gvPartidas"
        Me.gvPartidas.OptionsView.ColumnAutoWidth = False
        Me.gvPartidas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Código"
        Me.GridColumn18.FieldName = "ConId"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 0
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Concepto"
        Me.GridColumn19.FieldName = "ConNombre"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 1
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Porcentaje SAIMT"
        Me.GridColumn20.FieldName = "ConPorcentajeSAIMT"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 2
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Porcentaje MPT"
        Me.GridColumn21.FieldName = "ConPorcentajeMPT"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 3
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Cargo"
        Me.GridColumn22.FieldName = "PcontCuenC"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 4
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Abono"
        Me.GridColumn23.FieldName = "PcontCuenA"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 5
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Partida"
        Me.GridColumn24.FieldName = "Partida"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 6
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Estado"
        Me.GridColumn25.FieldName = "ConActivo"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 7
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Grupo"
        Me.GridColumn26.FieldName = "TgGrupoCon"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 8
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SaimtButton1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 605)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(671, 62)
        Me.PanelControl1.TabIndex = 1
        '
        'SaimtButton1
        '
        Me.SaimtButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtButton1.Location = New System.Drawing.Point(542, 11)
        Me.SaimtButton1.Name = "SaimtButton1"
        Me.SaimtButton1.Size = New System.Drawing.Size(119, 39)
        Me.SaimtButton1.TabIndex = 0
        Me.SaimtButton1.Tag = "NotClear"
        Me.SaimtButton1.Text = "Mostrar Conceptos"
        '
        'frmConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(1097, 732)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.dgvListado = Me.dgvListadoConcepto
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmConceptos"
        Me.Tag = "btiPersona"
        Me.Text = "CONCEPTOS"
        Me.txtBuscarSaimt = Me.txtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLista.ResumeLayout(False)
        CType(Me.dgvListadoConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBaseLegal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaBancaria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPresupuestarioMPT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodContableMPT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSubGrupoConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupoConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaHaber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaDebe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcSAIMT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFuenteFinanciera.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.cboFiltroAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.cboAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.gcPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbLista As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtConcepto As SaimtControles.SaimtTextBox
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents txtConId As SaimtControles.SaimtTextBox
    Friend WithEvents dgvListadoConcepto As SaimtControles.SaimtDataGrid
    Friend WithEvents gvResultados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents cboBuscarPor As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboCriterios As SaimtControles.SaimtComboBox
    Friend WithEvents cboFuenteFinanciera As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel16 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents txtPartida As SaimtControles.SaimtTextBox
    Friend WithEvents cboSubGrupoConcepto As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents cboGrupoConcepto As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents txtCuentaHaber As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents txtCuentaDebe As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtPorcSAIMT As SaimtControles.SaimtTextBox
    Friend WithEvents txtCodPresupuestarioMPT As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents txtCodContableMPT As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents chkMora As SaimtControles.SaimtCheckBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents chkActivo As SaimtControles.SaimtCheckBox
    Friend WithEvents txtImporte As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents btnAgregarCuentaHaber As SaimtControles.SaimtButton
    Friend WithEvents btnAgregarCuentaDebe As SaimtControles.SaimtButton
    Friend WithEvents txtCuentaBancaria As SaimtControles.SaimtTextBox
    Friend WithEvents btnAgregarPartida As SaimtControles.SaimtButton
    Friend WithEvents txtBaseLegal As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents cboFiltroAño As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SaimtTabs1 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcPartidas As SaimtControles.SaimtDataGrid
    Friend WithEvents gvPartidas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SaimtButton1 As SaimtControles.SaimtButton
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboAño As SaimtControles.SaimtComboBoxLookUp

End Class
