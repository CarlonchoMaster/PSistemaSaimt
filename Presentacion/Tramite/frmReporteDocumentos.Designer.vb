<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteDocumentos
    Inherits frmGeneral

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteDocumentos))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.sCboArea = New SaimtControles.SaimtComboBoxLookUp()
        Me.VerFormulario = New SaimtControles.SaimtButton()
        Me.btnbuscar = New SaimtControles.SaimtButton()
        Me.cbopciones = New SaimtControles.SaimtComboBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.txtregistro = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.cmbaños = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.btnExportarExcel = New SaimtControles.SaimtButton()
        Me.btnMostrarDatos = New SaimtControles.SaimtButton()
        Me.sfdExportar = New System.Windows.Forms.SaveFileDialog()
        Me.pgprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.riprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.gcresultado = New DevExpress.XtraGrid.GridControl()
        Me.gvresultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.mpbprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.rimpgprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.sCboArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbopciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtregistro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbaños.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riprogreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcresultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvresultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimpgprogreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.mpbprogreso)
        Me.rsbMensajeBarra.ItemLinks.Add(Me.pgprogreso)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 709)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1060, 27)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel1.ID = New System.Guid("65c29ccd-5965-4b03-8b5e-a5c4e2a37d8d")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 589)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 120)
        Me.DockPanel1.Size = New System.Drawing.Size(1060, 120)
        Me.DockPanel1.Text = "Opciones de Busqueda"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel3)
        Me.DockPanel1_Container.Controls.Add(Me.sCboArea)
        Me.DockPanel1_Container.Controls.Add(Me.VerFormulario)
        Me.DockPanel1_Container.Controls.Add(Me.btnbuscar)
        Me.DockPanel1_Container.Controls.Add(Me.cbopciones)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel4)
        Me.DockPanel1_Container.Controls.Add(Me.txtregistro)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel2)
        Me.DockPanel1_Container.Controls.Add(Me.cmbaños)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel1)
        Me.DockPanel1_Container.Controls.Add(Me.btnExportarExcel)
        Me.DockPanel1_Container.Controls.Add(Me.btnMostrarDatos)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(1052, 93)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(276, 74)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(30, 13)
        Me.SaimtLabel3.TabIndex = 10
        Me.SaimtLabel3.Text = "Area :"
        '
        'sCboArea
        '
        Me.sCboArea.Location = New System.Drawing.Point(333, 71)
        Me.sCboArea.MenuManager = Me.RibbonControl
        Me.sCboArea.Name = "sCboArea"
        Me.sCboArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sCboArea.Properties.NullText = ""
        Me.sCboArea.Size = New System.Drawing.Size(397, 20)
        Me.sCboArea.TabIndex = 17
        '
        'VerFormulario
        '
        Me.VerFormulario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerFormulario.Appearance.Options.UseTextOptions = True
        Me.VerFormulario.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VerFormulario.Image = CType(resources.GetObject("VerFormulario.Image"), System.Drawing.Image)
        Me.VerFormulario.Location = New System.Drawing.Point(970, 11)
        Me.VerFormulario.Name = "VerFormulario"
        Me.VerFormulario.Size = New System.Drawing.Size(77, 32)
        Me.VerFormulario.TabIndex = 16
        Me.VerFormulario.Text = "Ver en formulario"
        '
        'btnbuscar
        '
        Me.btnbuscar.Enabled = False
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnbuscar.Location = New System.Drawing.Point(701, 24)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(29, 23)
        Me.btnbuscar.TabIndex = 15
        '
        'cbopciones
        '
        Me.cbopciones.EditValue = "Todos los documentos del año seleccionado"
        Me.cbopciones.Location = New System.Drawing.Point(6, 49)
        Me.cbopciones.MenuManager = Me.RibbonControl
        Me.cbopciones.Name = "cbopciones"
        Me.cbopciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbopciones.Properties.Items.AddRange(New Object() {"Todos los documentos del año seleccionado", "Buscar por N° Reg. Documento", "Buscar por Nro. Expediente MPT", "Buscar por los Apellidos y Nombres del interesado", "Buscar por Nombre de Institución", "Lista de todos los documentos Atendidos", "Listado de todos los documentos por atender.", "Buscar por Nombre de Institución y Area"})
        Me.cbopciones.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbopciones.Size = New System.Drawing.Size(251, 20)
        Me.cbopciones.TabIndex = 14
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(7, 34)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(85, 13)
        Me.SaimtLabel4.TabIndex = 13
        Me.SaimtLabel4.Text = "Tipo de Busqueda"
        '
        'txtregistro
        '
        Me.txtregistro.Location = New System.Drawing.Point(333, 49)
        Me.txtregistro.MenuManager = Me.RibbonControl
        Me.txtregistro.Name = "txtregistro"
        Me.txtregistro.Size = New System.Drawing.Size(397, 20)
        Me.txtregistro.TabIndex = 11
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(276, 52)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel2.TabIndex = 9
        Me.SaimtLabel2.Text = "Buscar Por"
        '
        'cmbaños
        '
        Me.cmbaños.Location = New System.Drawing.Point(33, 8)
        Me.cmbaños.MenuManager = Me.RibbonControl
        Me.cmbaños.Name = "cmbaños"
        Me.cmbaños.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbaños.Properties.NullText = ""
        Me.cmbaños.Size = New System.Drawing.Size(179, 20)
        Me.cmbaños.TabIndex = 7
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(8, 11)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(19, 13)
        Me.SaimtLabel1.TabIndex = 6
        Me.SaimtLabel1.Text = "Año"
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarExcel.Appearance.Options.UseTextOptions = True
        Me.btnExportarExcel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.Location = New System.Drawing.Point(947, 46)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(100, 44)
        Me.btnExportarExcel.TabIndex = 5
        Me.btnExportarExcel.Text = "Exportar a Excel"
        '
        'btnMostrarDatos
        '
        Me.btnMostrarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMostrarDatos.Appearance.Options.UseTextOptions = True
        Me.btnMostrarDatos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnMostrarDatos.Image = CType(resources.GetObject("btnMostrarDatos.Image"), System.Drawing.Image)
        Me.btnMostrarDatos.Location = New System.Drawing.Point(841, 46)
        Me.btnMostrarDatos.Name = "btnMostrarDatos"
        Me.btnMostrarDatos.Size = New System.Drawing.Size(100, 44)
        Me.btnMostrarDatos.TabIndex = 4
        Me.btnMostrarDatos.Text = "Mostrar Datos"
        '
        'pgprogreso
        '
        Me.pgprogreso.Edit = Me.riprogreso
        Me.pgprogreso.Id = 4
        Me.pgprogreso.Name = "pgprogreso"
        Me.pgprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.pgprogreso.Width = 110
        '
        'riprogreso
        '
        Me.riprogreso.Name = "riprogreso"
        '
        'gcresultado
        '
        Me.gcresultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcresultado.Location = New System.Drawing.Point(0, 0)
        Me.gcresultado.LookAndFeel.SkinName = "Blue"
        Me.gcresultado.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcresultado.MainView = Me.gvresultado
        Me.gcresultado.MenuManager = Me.RibbonControl
        Me.gcresultado.Name = "gcresultado"
        Me.gcresultado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit2})
        Me.gcresultado.Size = New System.Drawing.Size(1060, 589)
        Me.gcresultado.TabIndex = 4
        Me.gcresultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvresultado})
        '
        'gvresultado
        '
        Me.gvresultado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14})
        Me.gvresultado.GridControl = Me.gcresultado
        Me.gvresultado.GroupCount = 2
        Me.gvresultado.Name = "gvresultado"
        Me.gvresultado.OptionsBehavior.ReadOnly = True
        Me.gvresultado.OptionsPrint.AutoWidth = False
        Me.gvresultado.OptionsView.ColumnAutoWidth = False
        Me.gvresultado.OptionsView.ShowAutoFilterRow = True
        Me.gvresultado.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn13, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn12, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Envia"
        Me.GridColumn1.FieldName = "origen"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Cargo Envia"
        Me.GridColumn2.FieldName = "cargoOrigen"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Recibe"
        Me.GridColumn3.FieldName = "destino"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cargo Recibe"
        Me.GridColumn4.FieldName = "cargoDestino"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha Envio"
        Me.GridColumn5.FieldName = "fechaEnvio"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha Recepción"
        Me.GridColumn6.FieldName = "fechaRecepcion"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Dias Tenencia"
        Me.GridColumn7.FieldName = "diasTenencia"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Estado de Tramite"
        Me.GridColumn8.FieldName = "estadoTramite"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Dias Procedimiento"
        Me.GridColumn9.FieldName = "diasProcedimiento"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Comentario de Envio"
        Me.GridColumn10.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.GridColumn10.FieldName = "comentarioenvio"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Doc. Id"
        Me.GridColumn11.FieldName = "docid"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "N° Reg. Doc."
        Me.GridColumn12.FieldName = "docnreg"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Mes"
        Me.GridColumn13.FieldName = "mes"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Acción"
        Me.GridColumn14.FieldName = "accion"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 6
        '
        'mpbprogreso
        '
        Me.mpbprogreso.Edit = Me.rimpgprogreso
        Me.mpbprogreso.Id = 4
        Me.mpbprogreso.Name = "mpbprogreso"
        Me.mpbprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.mpbprogreso.Width = 110
        '
        'rimpgprogreso
        '
        Me.rimpgprogreso.Name = "rimpgprogreso"
        '
        'frmReporteDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 736)
        Me.Controls.Add(Me.gcresultado)
        Me.Controls.Add(Me.DockPanel1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmReporteDocumentos"
        Me.Tag = "btiPivotDocumentosExternos"
        Me.Text = "frmReporteDocumentos"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.DockPanel1, 0)
        Me.Controls.SetChildIndex(Me.gcresultado, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.sCboArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbopciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtregistro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbaños.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riprogreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcresultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvresultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimpgprogreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents btnExportarExcel As SaimtControles.SaimtButton
    Friend WithEvents btnMostrarDatos As SaimtControles.SaimtButton
    Friend WithEvents cmbaños As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents sfdExportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtregistro As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents pgprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents riprogreso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents gcresultado As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvresultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents btnbuscar As SaimtControles.SaimtButton
    Friend WithEvents cbopciones As SaimtControles.SaimtComboBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents mpbprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents rimpgprogreso As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents VerFormulario As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents sCboArea As SaimtControles.SaimtComboBoxLookUp
End Class
