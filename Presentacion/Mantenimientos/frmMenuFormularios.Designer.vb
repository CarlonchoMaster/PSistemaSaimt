﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuFormularios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuFormularios))
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.grbDatos = New SaimtControles.SaimtGroupBox()
        Me.btnGuardarEdicion = New SaimtControles.SaimtButton()
        Me.pbxInfoTag = New SaimtControles.SaimtPictureBox()
        Me.txtTag = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.pbxInfoName = New SaimtControles.SaimtPictureBox()
        Me.txtGrupo = New SaimtControles.SaimtTextBox()
        Me.dgvMenuFormularios = New SaimtControles.SaimtDataGrid()
        Me.gvMenuFormularios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMfrId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMfrNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMfrTitulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMfrDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMfrTag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEditar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.linkEditar = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.btnQuitar = New SaimtControles.SaimtButton()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.txtDescripcion = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.txtNombre = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtTitulo = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.grbLista = New SaimtControles.SaimtGroupBox()
        Me.lstGrupoFormularios = New SaimtControles.SaimtListBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscarPor = New SaimtControles.SaimtTextBox()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatos.SuspendLayout()
        CType(Me.pbxInfoTag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxInfoName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMenuFormularios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMenuFormularios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLista.SuspendLayout()
        CType(Me.lstGrupoFormularios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 406)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(860, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(549, 337)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(479, 337)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(619, 337)
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
        Me.btnEditar.Location = New System.Drawing.Point(409, 337)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.btnGuardarEdicion)
        Me.grbDatos.Controls.Add(Me.pbxInfoTag)
        Me.grbDatos.Controls.Add(Me.txtTag)
        Me.grbDatos.Controls.Add(Me.SaimtLabel4)
        Me.grbDatos.Controls.Add(Me.pbxInfoName)
        Me.grbDatos.Controls.Add(Me.txtGrupo)
        Me.grbDatos.Controls.Add(Me.dgvMenuFormularios)
        Me.grbDatos.Controls.Add(Me.btnQuitar)
        Me.grbDatos.Controls.Add(Me.btnAgregar)
        Me.grbDatos.Controls.Add(Me.txtDescripcion)
        Me.grbDatos.Controls.Add(Me.SaimtLabel6)
        Me.grbDatos.Controls.Add(Me.txtNombre)
        Me.grbDatos.Controls.Add(Me.SaimtLabel3)
        Me.grbDatos.Controls.Add(Me.SaimtLabel2)
        Me.grbDatos.Controls.Add(Me.txtTitulo)
        Me.grbDatos.Controls.Add(Me.SaimtLabel5)
        Me.grbDatos.Location = New System.Drawing.Point(244, 5)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(618, 330)
        Me.grbDatos.TabIndex = 2
        Me.grbDatos.Text = "Datos "
        '
        'btnGuardarEdicion
        '
        Me.btnGuardarEdicion.Image = Global.Presentacion.My.Resources.Resources.guardar16
        Me.btnGuardarEdicion.Location = New System.Drawing.Point(584, 42)
        Me.btnGuardarEdicion.Name = "btnGuardarEdicion"
        Me.btnGuardarEdicion.Size = New System.Drawing.Size(25, 23)
        Me.btnGuardarEdicion.TabIndex = 5
        '
        'pbxInfoTag
        '
        Me.pbxInfoTag.EditValue = Global.Presentacion.My.Resources.Resources.information16
        Me.pbxInfoTag.Location = New System.Drawing.Point(550, 56)
        Me.pbxInfoTag.MenuManager = Me.RibbonControl
        Me.pbxInfoTag.Name = "pbxInfoTag"
        Me.pbxInfoTag.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pbxInfoTag.Properties.Appearance.Options.UseBackColor = True
        Me.pbxInfoTag.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pbxInfoTag.Properties.NullText = "Sin Imagen"
        Me.pbxInfoTag.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pbxInfoTag.Size = New System.Drawing.Size(20, 19)
        Me.pbxInfoTag.TabIndex = 8
        '
        'txtTag
        '
        Me.txtTag.EditValue = ""
        Me.txtTag.Location = New System.Drawing.Point(344, 56)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(204, 20)
        Me.txtTag.TabIndex = 7
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(313, 59)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(25, 13)
        Me.SaimtLabel4.TabIndex = 10
        Me.SaimtLabel4.Text = "Tag :"
        '
        'pbxInfoName
        '
        Me.pbxInfoName.EditValue = Global.Presentacion.My.Resources.Resources.information16
        Me.pbxInfoName.Location = New System.Drawing.Point(550, 31)
        Me.pbxInfoName.MenuManager = Me.RibbonControl
        Me.pbxInfoName.Name = "pbxInfoName"
        Me.pbxInfoName.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pbxInfoName.Properties.Appearance.Options.UseBackColor = True
        Me.pbxInfoName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pbxInfoName.Properties.NullText = "Sin Imagen"
        Me.pbxInfoName.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pbxInfoName.Size = New System.Drawing.Size(20, 19)
        Me.pbxInfoName.TabIndex = 4
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(78, 31)
        Me.txtGrupo.MenuManager = Me.RibbonControl
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(179, 20)
        Me.txtGrupo.TabIndex = 1
        '
        'dgvMenuFormularios
        '
        Me.dgvMenuFormularios.Location = New System.Drawing.Point(9, 127)
        Me.dgvMenuFormularios.MainView = Me.gvMenuFormularios
        Me.dgvMenuFormularios.MenuManager = Me.RibbonControl
        Me.dgvMenuFormularios.Name = "dgvMenuFormularios"
        Me.dgvMenuFormularios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.linkEditar})
        Me.dgvMenuFormularios.Size = New System.Drawing.Size(601, 200)
        Me.dgvMenuFormularios.TabIndex = 15
        Me.dgvMenuFormularios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMenuFormularios})
        '
        'gvMenuFormularios
        '
        Me.gvMenuFormularios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMfrId, Me.colMfrNombre, Me.colMfrTitulo, Me.colMfrDescripcion, Me.colMfrTag, Me.colEditar})
        Me.gvMenuFormularios.GridControl = Me.dgvMenuFormularios
        Me.gvMenuFormularios.Name = "gvMenuFormularios"
        Me.gvMenuFormularios.OptionsBehavior.ReadOnly = True
        Me.gvMenuFormularios.OptionsView.ColumnAutoWidth = False
        Me.gvMenuFormularios.OptionsView.ShowGroupPanel = False
        '
        'colMfrId
        '
        Me.colMfrId.Caption = "mfrId"
        Me.colMfrId.FieldName = "mfrId"
        Me.colMfrId.Name = "colMfrId"
        '
        'colMfrNombre
        '
        Me.colMfrNombre.Caption = "Name"
        Me.colMfrNombre.FieldName = "mfrNombre"
        Me.colMfrNombre.Name = "colMfrNombre"
        Me.colMfrNombre.Visible = True
        Me.colMfrNombre.VisibleIndex = 0
        '
        'colMfrTitulo
        '
        Me.colMfrTitulo.Caption = "Título"
        Me.colMfrTitulo.FieldName = "mfrTitulo"
        Me.colMfrTitulo.Name = "colMfrTitulo"
        Me.colMfrTitulo.Visible = True
        Me.colMfrTitulo.VisibleIndex = 1
        '
        'colMfrDescripcion
        '
        Me.colMfrDescripcion.Caption = "Descripción"
        Me.colMfrDescripcion.FieldName = "mfrDescripcion"
        Me.colMfrDescripcion.Name = "colMfrDescripcion"
        Me.colMfrDescripcion.Visible = True
        Me.colMfrDescripcion.VisibleIndex = 2
        '
        'colMfrTag
        '
        Me.colMfrTag.Caption = "Tag"
        Me.colMfrTag.FieldName = "mfrTag"
        Me.colMfrTag.Name = "colMfrTag"
        Me.colMfrTag.Visible = True
        Me.colMfrTag.VisibleIndex = 3
        '
        'colEditar
        '
        Me.colEditar.Caption = "Editar"
        Me.colEditar.ColumnEdit = Me.linkEditar
        Me.colEditar.FieldName = "editar"
        Me.colEditar.Name = "colEditar"
        Me.colEditar.Visible = True
        Me.colEditar.VisibleIndex = 4
        '
        'linkEditar
        '
        Me.linkEditar.AutoHeight = False
        Me.linkEditar.Name = "linkEditar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnQuitar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuitar.Location = New System.Drawing.Point(585, 101)
        Me.btnQuitar.LookAndFeel.SkinName = "Seven"
        Me.btnQuitar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(25, 18)
        Me.btnQuitar.TabIndex = 14
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(554, 101)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 18)
        Me.btnAgregar.TabIndex = 13
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(78, 83)
        Me.txtDescripcion.MenuManager = Me.RibbonControl
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(470, 36)
        Me.txtDescripcion.TabIndex = 12
        Me.txtDescripcion.UseOptimizedRendering = True
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(274, 34)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(34, 13)
        Me.SaimtLabel6.TabIndex = 2
        Me.SaimtLabel6.Text = "Name :"
        '
        'txtNombre
        '
        Me.txtNombre.EditValue = ""
        Me.txtNombre.Location = New System.Drawing.Point(313, 31)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 20)
        Me.txtNombre.TabIndex = 3
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(38, 34)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(36, 13)
        Me.SaimtLabel3.TabIndex = 0
        Me.SaimtLabel3.Text = "Grupo :"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(41, 59)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(33, 13)
        Me.SaimtLabel2.TabIndex = 6
        Me.SaimtLabel2.Text = "Título :"
        '
        'txtTitulo
        '
        Me.txtTitulo.EditValue = ""
        Me.txtTitulo.Location = New System.Drawing.Point(78, 57)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(221, 20)
        Me.txtTitulo.TabIndex = 9
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(13, 84)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(61, 13)
        Me.SaimtLabel5.TabIndex = 11
        Me.SaimtLabel5.Text = "Descripción :"
        '
        'grbLista
        '
        Me.grbLista.Controls.Add(Me.lstGrupoFormularios)
        Me.grbLista.Location = New System.Drawing.Point(4, 54)
        Me.grbLista.Name = "grbLista"
        Me.grbLista.Size = New System.Drawing.Size(238, 349)
        Me.grbLista.TabIndex = 3
        Me.grbLista.Text = "Listado"
        '
        'lstGrupoFormularios
        '
        Me.lstGrupoFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstGrupoFormularios.HorizontalScrollbar = True
        Me.lstGrupoFormularios.Location = New System.Drawing.Point(2, 21)
        Me.lstGrupoFormularios.Name = "lstGrupoFormularios"
        Me.lstGrupoFormularios.Size = New System.Drawing.Size(234, 326)
        Me.lstGrupoFormularios.TabIndex = 0
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(5, 6)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(124, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Buscar Grupo Formulario :"
        '
        'txtBuscarPor
        '
        Me.txtBuscarPor.Location = New System.Drawing.Point(3, 28)
        Me.txtBuscarPor.MenuManager = Me.RibbonControl
        Me.txtBuscarPor.Name = "txtBuscarPor"
        Me.txtBuscarPor.Size = New System.Drawing.Size(239, 20)
        Me.txtBuscarPor.TabIndex = 1
        '
        'frmMenuFormularios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ClientSize = New System.Drawing.Size(860, 433)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.grbDatos)
        Me.Controls.Add(Me.grbLista)
        Me.Controls.Add(Me.SaimtLabel1)
        Me.Controls.Add(Me.txtBuscarPor)
        Me.LookAndFeel.SkinName = "Seven"
        Me.lstListado = Me.lstGrupoFormularios
        Me.Name = "frmMenuFormularios"
        Me.Tag = "btiMenuFormularios"
        Me.Text = "MENU FORMULARIOS"
        Me.txtBuscarSaimt = Me.txtBuscarPor
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.txtBuscarPor, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel1, 0)
        Me.Controls.SetChildIndex(Me.grbLista, 0)
        Me.Controls.SetChildIndex(Me.grbDatos, 0)
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        CType(Me.pbxInfoTag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxInfoName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrupo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMenuFormularios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMenuFormularios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLista.ResumeLayout(False)
        CType(Me.lstGrupoFormularios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents grbDatos As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvMenuFormularios As SaimtControles.SaimtDataGrid
    Friend WithEvents gvMenuFormularios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnQuitar As SaimtControles.SaimtButton
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
    Friend WithEvents txtDescripcion As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents txtNombre As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtTitulo As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents grbLista As SaimtControles.SaimtGroupBox
    Friend WithEvents lstGrupoFormularios As SaimtControles.SaimtListBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents txtGrupo As SaimtControles.SaimtTextBox
    Friend WithEvents colMfrId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMfrNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMfrTitulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMfrDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pbxInfoName As SaimtControles.SaimtPictureBox
    Friend WithEvents pbxInfoTag As SaimtControles.SaimtPictureBox
    Friend WithEvents txtTag As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents colMfrTag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEditar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents linkEditar As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents btnGuardarEdicion As SaimtControles.SaimtButton

End Class
