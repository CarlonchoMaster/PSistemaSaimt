﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargoTipoDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargoTipoDoc))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.txtCargo = New SaimtControles.SaimtTextBox()
        Me.txtArea = New SaimtControles.SaimtTextBox()
        Me.spnAño = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.spnNroDocGenerados = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.cboTipoDocumento = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.dgvTipoDocumentosCargos = New SaimtControles.SaimtDataGrid()
        Me.gvTipoDocumentosCargos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnQuitar = New SaimtControles.SaimtButton()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.lstTipoDocumentoCargos = New SaimtControles.SaimtListBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.cboAreaCriterio = New SaimtControles.SaimtComboBoxLookUp()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnNroDocGenerados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTipoDocumentosCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTipoDocumentosCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.lstTipoDocumentoCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAreaCriterio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 604)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(895, 27)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.txtCargo)
        Me.SaimtGroupBox1.Controls.Add(Me.txtArea)
        Me.SaimtGroupBox1.Controls.Add(Me.spnAño)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox1.Controls.Add(Me.spnNroDocGenerados)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox1.Controls.Add(Me.cboTipoDocumento)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(280, 9)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(604, 121)
        Me.SaimtGroupBox1.TabIndex = 5
        Me.SaimtGroupBox1.Text = "Asignacion de Tipo Documentos por Cargos"
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(66, 60)
        Me.txtCargo.MenuManager = Me.RibbonControl
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(533, 20)
        Me.txtCargo.TabIndex = 5
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(66, 34)
        Me.txtArea.MenuManager = Me.RibbonControl
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(533, 20)
        Me.txtArea.TabIndex = 3
        '
        'spnAño
        '
        Me.spnAño.EditValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.spnAño.Location = New System.Drawing.Point(445, 90)
        Me.spnAño.MenuManager = Me.RibbonControl
        Me.spnAño.Name = "spnAño"
        Me.spnAño.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spnAño.Properties.Mask.EditMask = "f0"
        Me.spnAño.Properties.MaxValue = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.spnAño.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.spnAño.Size = New System.Drawing.Size(70, 20)
        Me.spnAño.TabIndex = 11
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(422, 93)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(19, 13)
        Me.SaimtLabel10.TabIndex = 10
        Me.SaimtLabel10.Text = "Año"
        '
        'spnNroDocGenerados
        '
        Me.spnNroDocGenerados.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnNroDocGenerados.Location = New System.Drawing.Point(316, 90)
        Me.spnNroDocGenerados.MenuManager = Me.RibbonControl
        Me.spnNroDocGenerados.Name = "spnNroDocGenerados"
        Me.spnNroDocGenerados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spnNroDocGenerados.Properties.Mask.EditMask = "f0"
        Me.spnNroDocGenerados.Size = New System.Drawing.Size(100, 20)
        Me.spnNroDocGenerados.TabIndex = 9
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(209, 93)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(101, 13)
        Me.SaimtLabel5.TabIndex = 8
        Me.SaimtLabel5.Text = "Nro. Doc. Generados"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.Location = New System.Drawing.Point(66, 90)
        Me.cboTipoDocumento.MenuManager = Me.RibbonControl
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoDocumento.Properties.NullText = ""
        Me.cboTipoDocumento.Size = New System.Drawing.Size(131, 20)
        Me.cboTipoDocumento.TabIndex = 7
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(15, 93)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(45, 13)
        Me.SaimtLabel4.TabIndex = 6
        Me.SaimtLabel4.Text = "Tipo Doc."
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(31, 65)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(29, 13)
        Me.SaimtLabel3.TabIndex = 4
        Me.SaimtLabel3.Text = "Cargo"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(37, 37)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(23, 13)
        Me.SaimtLabel2.TabIndex = 2
        Me.SaimtLabel2.Text = "Área"
        '
        'dgvTipoDocumentosCargos
        '
        Me.dgvTipoDocumentosCargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTipoDocumentosCargos.Location = New System.Drawing.Point(280, 160)
        Me.dgvTipoDocumentosCargos.MainView = Me.gvTipoDocumentosCargos
        Me.dgvTipoDocumentosCargos.MenuManager = Me.RibbonControl
        Me.dgvTipoDocumentosCargos.Name = "dgvTipoDocumentosCargos"
        Me.dgvTipoDocumentosCargos.Size = New System.Drawing.Size(604, 366)
        Me.dgvTipoDocumentosCargos.TabIndex = 9
        Me.dgvTipoDocumentosCargos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTipoDocumentosCargos})
        '
        'gvTipoDocumentosCargos
        '
        Me.gvTipoDocumentosCargos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.gvTipoDocumentosCargos.GridControl = Me.dgvTipoDocumentosCargos
        Me.gvTipoDocumentosCargos.Name = "gvTipoDocumentosCargos"
        Me.gvTipoDocumentosCargos.OptionsView.ColumnAutoWidth = False
        Me.gvTipoDocumentosCargos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Id"
        Me.GridColumn11.FieldName = "id"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cod. Área"
        Me.GridColumn3.FieldName = "codArea"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Área"
        Me.GridColumn4.FieldName = "area"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Cod. Cargo"
        Me.GridColumn5.FieldName = "codCargo"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Cargo"
        Me.GridColumn6.FieldName = "cargo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Cod. Tipo Documento"
        Me.GridColumn7.FieldName = "codTipoDocumento"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tipo Documento"
        Me.GridColumn8.FieldName = "tipoDocumento"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Nro. Doc. Generados"
        Me.GridColumn9.FieldName = "nroDocGenerados"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Año"
        Me.GridColumn10.FieldName = "año"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        '
        'btnQuitar
        '
        Me.btnQuitar.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnQuitar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuitar.Location = New System.Drawing.Point(858, 136)
        Me.btnQuitar.LookAndFeel.SkinName = "Seven"
        Me.btnQuitar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(25, 18)
        Me.btnQuitar.TabIndex = 8
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(829, 136)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 18)
        Me.btnAgregar.TabIndex = 7
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox2.Controls.Add(Me.lstTipoDocumentoCargos)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(7, 69)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(264, 529)
        Me.SaimtGroupBox2.TabIndex = 6
        Me.SaimtGroupBox2.Text = "Resultados de Busqueda"
        '
        'lstTipoDocumentoCargos
        '
        Me.lstTipoDocumentoCargos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstTipoDocumentoCargos.HorizontalScrollbar = True
        Me.lstTipoDocumentoCargos.Location = New System.Drawing.Point(2, 21)
        Me.lstTipoDocumentoCargos.Name = "lstTipoDocumentoCargos"
        Me.lstTipoDocumentoCargos.Size = New System.Drawing.Size(260, 506)
        Me.lstTipoDocumentoCargos.TabIndex = 0
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(9, 5)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel6.TabIndex = 0
        Me.SaimtLabel6.Text = "Buscar por :"
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(7, 24)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(23, 13)
        Me.SaimtLabel8.TabIndex = 3
        Me.SaimtLabel8.Text = "Área"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(562, 532)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(702, 532)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(492, 532)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(632, 532)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(422, 532)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "Editar"
        '
        'cboAreaCriterio
        '
        Me.cboAreaCriterio.Location = New System.Drawing.Point(7, 43)
        Me.cboAreaCriterio.MenuManager = Me.RibbonControl
        Me.cboAreaCriterio.Name = "cboAreaCriterio"
        Me.cboAreaCriterio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAreaCriterio.Properties.NullText = ""
        Me.cboAreaCriterio.Size = New System.Drawing.Size(262, 20)
        Me.cboAreaCriterio.TabIndex = 4
        '
        'frmCargoTipoDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ClientSize = New System.Drawing.Size(895, 631)
        Me.Controls.Add(Me.cboAreaCriterio)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.SaimtLabel8)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.Controls.Add(Me.SaimtLabel6)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.dgvTipoDocumentosCargos)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.LookAndFeel.SkinName = "Seven"
        Me.lstListado = Me.lstTipoDocumentoCargos
        Me.Name = "frmCargoTipoDoc"
        Me.Tag = "btiTipoDocumentoCargos"
        Me.Text = "TIPO DOCUMENTOS POR CARGOS"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnQuitar, 0)
        Me.Controls.SetChildIndex(Me.dgvTipoDocumentosCargos, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel6, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel8, 0)
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.cboAreaCriterio, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnNroDocGenerados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTipoDocumentosCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTipoDocumentosCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        CType(Me.lstTipoDocumentoCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAreaCriterio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents spnNroDocGenerados As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoDocumento As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents dgvTipoDocumentosCargos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvTipoDocumentosCargos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnQuitar As SaimtControles.SaimtButton
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents lstTipoDocumentoCargos As SaimtControles.SaimtListBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents spnAño As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents cboAreaCriterio As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCargo As SaimtControles.SaimtTextBox
    Friend WithEvents txtArea As SaimtControles.SaimtTextBox
End Class