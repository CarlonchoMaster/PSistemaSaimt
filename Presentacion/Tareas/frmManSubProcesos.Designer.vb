<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManSubProcesos
    Inherits Presentacion.frmMantenimientos

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManSubProcesos))
        Me.tabDetContrato = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnElimEditor = New SaimtControles.SaimtButton()
        Me.dgvSubProcesos = New SaimtControles.SaimtDataGrid()
        Me.gvSubProcesos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.procId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.subProcId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.subProcNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.subProcDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.subProcActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.linkEditar = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtSubProcNombre = New SaimtControles.SaimtTextBox()
        Me.chkSubProcActivo = New SaimtControles.SaimtCheckBox()
        Me.txtProcNombre = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtSubProcDescripcion = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cbBuscarPor = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New SaimtControles.SaimtTextBox()
        Me.grbLista = New SaimtControles.SaimtGroupBox()
        Me.dgvListadosubProc = New SaimtControles.SaimtDataGrid()
        Me.gvListado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.btnCancelarContrato = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabDetContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetContrato.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dgvSubProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSubProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubProcNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSubProcActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubProcDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLista.SuspendLayout()
        CType(Me.dgvListadosubProc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 406)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(816, 27)
        '
        'tabDetContrato
        '
        Me.tabDetContrato.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabDetContrato.Location = New System.Drawing.Point(0, 0)
        Me.tabDetContrato.Name = "tabDetContrato"
        Me.tabDetContrato.SelectedTabPage = Me.XtraTabPage1
        Me.tabDetContrato.Size = New System.Drawing.Size(541, 330)
        Me.tabDetContrato.TabIndex = 4
        Me.tabDetContrato.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnElimEditor)
        Me.XtraTabPage1.Controls.Add(Me.dgvSubProcesos)
        Me.XtraTabPage1.Controls.Add(Me.btnAgregar)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel2)
        Me.XtraTabPage1.Controls.Add(Me.txtSubProcNombre)
        Me.XtraTabPage1.Controls.Add(Me.chkSubProcActivo)
        Me.XtraTabPage1.Controls.Add(Me.txtProcNombre)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel1)
        Me.XtraTabPage1.Controls.Add(Me.txtSubProcDescripcion)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel10)
        Me.XtraTabPage1.Image = CType(resources.GetObject("XtraTabPage1.Image"), System.Drawing.Image)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(535, 299)
        Me.XtraTabPage1.Text = "Datos del Proceso"
        '
        'btnElimEditor
        '
        Me.btnElimEditor.Image = Global.Presentacion.My.Resources.Resources.contrato1
        Me.btnElimEditor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnElimEditor.Location = New System.Drawing.Point(482, 108)
        Me.btnElimEditor.LookAndFeel.SkinName = "Seven"
        Me.btnElimEditor.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnElimEditor.Name = "btnElimEditor"
        Me.btnElimEditor.Size = New System.Drawing.Size(25, 23)
        Me.btnElimEditor.TabIndex = 56
        '
        'dgvSubProcesos
        '
        Me.dgvSubProcesos.Location = New System.Drawing.Point(77, 137)
        Me.dgvSubProcesos.MainView = Me.gvSubProcesos
        Me.dgvSubProcesos.MenuManager = Me.RibbonControl
        Me.dgvSubProcesos.Name = "dgvSubProcesos"
        Me.dgvSubProcesos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.linkEditar})
        Me.dgvSubProcesos.Size = New System.Drawing.Size(430, 147)
        Me.dgvSubProcesos.TabIndex = 49
        Me.dgvSubProcesos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSubProcesos})
        '
        'gvSubProcesos
        '
        Me.gvSubProcesos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.procId, Me.subProcId, Me.subProcNombre, Me.subProcDescripcion, Me.subProcActivo})
        Me.gvSubProcesos.GridControl = Me.dgvSubProcesos
        Me.gvSubProcesos.Name = "gvSubProcesos"
        Me.gvSubProcesos.OptionsBehavior.ReadOnly = True
        Me.gvSubProcesos.OptionsView.ColumnAutoWidth = False
        Me.gvSubProcesos.OptionsView.ShowGroupPanel = False
        '
        'procId
        '
        Me.procId.Caption = "procId"
        Me.procId.FieldName = "procId"
        Me.procId.Name = "procId"
        '
        'subProcId
        '
        Me.subProcId.Caption = "subProcId"
        Me.subProcId.FieldName = "subProcId"
        Me.subProcId.Name = "subProcId"
        '
        'subProcNombre
        '
        Me.subProcNombre.Caption = "Nombre"
        Me.subProcNombre.FieldName = "subProcNombre"
        Me.subProcNombre.Name = "subProcNombre"
        Me.subProcNombre.Visible = True
        Me.subProcNombre.VisibleIndex = 0
        Me.subProcNombre.Width = 106
        '
        'subProcDescripcion
        '
        Me.subProcDescripcion.Caption = "Descripción"
        Me.subProcDescripcion.FieldName = "subProcDescripcion"
        Me.subProcDescripcion.Name = "subProcDescripcion"
        Me.subProcDescripcion.Visible = True
        Me.subProcDescripcion.VisibleIndex = 1
        Me.subProcDescripcion.Width = 150
        '
        'subProcActivo
        '
        Me.subProcActivo.Caption = "Activo"
        Me.subProcActivo.FieldName = "subProcActivo"
        Me.subProcActivo.Name = "subProcActivo"
        Me.subProcActivo.Visible = True
        Me.subProcActivo.VisibleIndex = 2
        '
        'linkEditar
        '
        Me.linkEditar.AutoHeight = False
        Me.linkEditar.Name = "linkEditar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(451, 108)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 23)
        Me.btnAgregar.TabIndex = 47
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(253, 21)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(49, 13)
        Me.SaimtLabel2.TabIndex = 46
        Me.SaimtLabel2.Text = "Sub Proc :"
        '
        'txtSubProcNombre
        '
        Me.txtSubProcNombre.Location = New System.Drawing.Point(308, 18)
        Me.txtSubProcNombre.Name = "txtSubProcNombre"
        Me.txtSubProcNombre.Size = New System.Drawing.Size(199, 20)
        Me.txtSubProcNombre.TabIndex = 45
        '
        'chkSubProcActivo
        '
        Me.chkSubProcActivo.Location = New System.Drawing.Point(75, 110)
        Me.chkSubProcActivo.MenuManager = Me.RibbonControl
        Me.chkSubProcActivo.Name = "chkSubProcActivo"
        Me.chkSubProcActivo.Properties.AutoWidth = True
        Me.chkSubProcActivo.Properties.Caption = "Activo"
        Me.chkSubProcActivo.Size = New System.Drawing.Size(52, 19)
        Me.chkSubProcActivo.TabIndex = 44
        '
        'txtProcNombre
        '
        Me.txtProcNombre.Location = New System.Drawing.Point(77, 18)
        Me.txtProcNombre.Name = "txtProcNombre"
        Me.txtProcNombre.Size = New System.Drawing.Size(157, 20)
        Me.txtProcNombre.TabIndex = 43
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(21, 21)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(45, 13)
        Me.SaimtLabel1.TabIndex = 42
        Me.SaimtLabel1.Text = "Proceso :"
        '
        'txtSubProcDescripcion
        '
        Me.txtSubProcDescripcion.Location = New System.Drawing.Point(77, 54)
        Me.txtSubProcDescripcion.Name = "txtSubProcDescripcion"
        Me.txtSubProcDescripcion.Size = New System.Drawing.Size(430, 50)
        Me.txtSubProcDescripcion.TabIndex = 39
        Me.txtSubProcDescripcion.UseOptimizedRendering = True
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(5, 56)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(61, 13)
        Me.SaimtLabel10.TabIndex = 38
        Me.SaimtLabel10.Text = "Descripción :"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbBuscarPor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBuscar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grbLista)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnImprimir)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tabDetContrato)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancelarContrato)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancelar)
        Me.SplitContainer1.Size = New System.Drawing.Size(816, 433)
        Me.SplitContainer1.SplitterDistance = 271
        Me.SplitContainer1.TabIndex = 5
        '
        'cbBuscarPor
        '
        Me.cbBuscarPor.FormattingEnabled = True
        Me.cbBuscarPor.Items.AddRange(New Object() {"Buscar por Nombre", "Buscar por Codigo"})
        Me.cbBuscarPor.Location = New System.Drawing.Point(9, 9)
        Me.cbBuscarPor.Name = "cbBuscarPor"
        Me.cbBuscarPor.Size = New System.Drawing.Size(253, 21)
        Me.cbBuscarPor.TabIndex = 7
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(7, 35)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(255, 20)
        Me.txtBuscar.TabIndex = 5
        Me.txtBuscar.Tag = "0"
        '
        'grbLista
        '
        Me.grbLista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbLista.Controls.Add(Me.dgvListadosubProc)
        Me.grbLista.Location = New System.Drawing.Point(7, 61)
        Me.grbLista.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grbLista.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grbLista.Name = "grbLista"
        Me.grbLista.Size = New System.Drawing.Size(255, 339)
        Me.grbLista.TabIndex = 6
        Me.grbLista.Text = "Listado de Procesos"
        '
        'dgvListadosubProc
        '
        Me.dgvListadosubProc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadosubProc.Location = New System.Drawing.Point(2, 21)
        Me.dgvListadosubProc.MainView = Me.gvListado
        Me.dgvListadosubProc.Name = "dgvListadosubProc"
        Me.dgvListadosubProc.Size = New System.Drawing.Size(251, 316)
        Me.dgvListadosubProc.TabIndex = 0
        Me.dgvListadosubProc.Tag = "0"
        Me.dgvListadosubProc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListado, Me.GridView2})
        '
        'gvListado
        '
        Me.gvListado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn1, Me.GridColumn4})
        Me.gvListado.GridControl = Me.dgvListadosubProc
        Me.gvListado.Name = "gvListado"
        Me.gvListado.OptionsBehavior.ReadOnly = True
        Me.gvListado.OptionsView.ColumnAutoWidth = False
        Me.gvListado.OptionsView.ShowGroupPanel = False
        Me.gvListado.Tag = ""
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Proceso"
        Me.GridColumn2.FieldName = "procNombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Codigo"
        Me.GridColumn3.FieldName = "procId"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ProcDescripcion"
        Me.GridColumn1.FieldName = "procDescripcion"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "procActivo"
        Me.GridColumn4.FieldName = "procActivo"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.dgvListadosubProc
        Me.GridView2.Name = "GridView2"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImprimir.Location = New System.Drawing.Point(220, 334)
        Me.btnImprimir.LookAndFeel.SkinName = "Seven"
        Me.btnImprimir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 64)
        Me.btnImprimir.TabIndex = 35
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCancelarContrato
        '
        Me.btnCancelarContrato.Image = CType(resources.GetObject("btnCancelarContrato.Image"), System.Drawing.Image)
        Me.btnCancelarContrato.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelarContrato.Location = New System.Drawing.Point(290, 334)
        Me.btnCancelarContrato.LookAndFeel.SkinName = "Seven"
        Me.btnCancelarContrato.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelarContrato.Name = "btnCancelarContrato"
        Me.btnCancelarContrato.Size = New System.Drawing.Size(68, 64)
        Me.btnCancelarContrato.TabIndex = 36
        Me.btnCancelarContrato.Text = "Cancelar Contrato"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(150, 334)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 34
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(79, 334)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Text = "Cancelar Edición"
        '
        'frmManSubProcesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonImprimir = Me.btnImprimir
        Me.ClientSize = New System.Drawing.Size(816, 433)
        Me.Controls.Add(Me.SplitContainer1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmManSubProcesos"
        Me.Text = "Mantenedor de Procesos"
        Me.txtBuscarSaimt = Me.txtBuscar
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabDetContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetContrato.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.dgvSubProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSubProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubProcNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSubProcActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubProcDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLista.ResumeLayout(False)
        CType(Me.dgvListadosubProc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabDetContrato As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents btnCancelarContrato As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents txtBuscar As SaimtControles.SaimtTextBox
    Friend WithEvents grbLista As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvListadosubProc As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtProcNombre As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtSubProcDescripcion As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents cbBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkSubProcActivo As SaimtControles.SaimtCheckBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtSubProcNombre As SaimtControles.SaimtTextBox
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
    Friend WithEvents dgvSubProcesos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvSubProcesos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents subProcId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents subProcNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents subProcDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents linkEditar As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents procId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents subProcActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnElimEditor As SaimtControles.SaimtButton
End Class
