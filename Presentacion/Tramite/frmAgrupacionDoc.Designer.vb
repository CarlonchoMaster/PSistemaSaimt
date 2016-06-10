<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrupacionDoc
    Inherits Presentacion.frmMantenimientos

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrupacionDoc))
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.lblDocSecIdFecha = New SaimtControles.SaimtLabel()
        Me.lblDocIdFecha = New SaimtControles.SaimtLabel()
        Me.lnkDocSecId = New System.Windows.Forms.LinkLabel()
        Me.lnkDocId = New System.Windows.Forms.LinkLabel()
        Me.btnBuscarDocSecId = New SaimtControles.SaimtButton()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnQuitar = New SaimtControles.SaimtButton()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.dgvDocumentosSecundarios = New DevExpress.XtraGrid.GridControl()
        Me.gvDocumentosSecundarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNroRegistro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gclinkDetalleDocSec = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.txtDocSecId = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.btnBuscarDocId = New SaimtControles.SaimtButton()
        Me.txtDocId = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel27 = New SaimtControles.SaimtLabel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDocumentosSecundarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDocumentosSecundarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gclinkDetalleDocSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocSecId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 475)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(602, 27)
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(23, 122)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(72, 13)
        Me.SaimtLabel6.TabIndex = 62
        Me.SaimtLabel6.Text = "Ingreso el día :"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(23, 28)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(72, 13)
        Me.SaimtLabel5.TabIndex = 61
        Me.SaimtLabel5.Text = "Ingreso el día :"
        '
        'lblDocSecIdFecha
        '
        Me.lblDocSecIdFecha.Location = New System.Drawing.Point(109, 122)
        Me.lblDocSecIdFecha.Name = "lblDocSecIdFecha"
        Me.lblDocSecIdFecha.Size = New System.Drawing.Size(67, 13)
        Me.lblDocSecIdFecha.TabIndex = 60
        Me.lblDocSecIdFecha.Text = "lblDocIdFecha"
        '
        'lblDocIdFecha
        '
        Me.lblDocIdFecha.Location = New System.Drawing.Point(109, 28)
        Me.lblDocIdFecha.Name = "lblDocIdFecha"
        Me.lblDocIdFecha.Size = New System.Drawing.Size(67, 13)
        Me.lblDocIdFecha.TabIndex = 59
        Me.lblDocIdFecha.Text = "lblDocIdFecha"
        '
        'lnkDocSecId
        '
        Me.lnkDocSecId.AutoSize = True
        Me.lnkDocSecId.Location = New System.Drawing.Point(120, 101)
        Me.lnkDocSecId.Name = "lnkDocSecId"
        Me.lnkDocSecId.Size = New System.Drawing.Size(0, 13)
        Me.lnkDocSecId.TabIndex = 58
        '
        'lnkDocId
        '
        Me.lnkDocId.AutoSize = True
        Me.lnkDocId.Location = New System.Drawing.Point(106, 12)
        Me.lnkDocId.Name = "lnkDocId"
        Me.lnkDocId.Size = New System.Drawing.Size(0, 13)
        Me.lnkDocId.TabIndex = 57
        '
        'btnBuscarDocSecId
        '
        Me.btnBuscarDocSecId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarDocSecId.Image = CType(resources.GetObject("btnBuscarDocSecId.Image"), System.Drawing.Image)
        Me.btnBuscarDocSecId.Location = New System.Drawing.Point(529, 139)
        Me.btnBuscarDocSecId.Name = "btnBuscarDocSecId"
        Me.btnBuscarDocSecId.Size = New System.Drawing.Size(25, 21)
        Me.btnBuscarDocSecId.TabIndex = 56
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImprimir.Location = New System.Drawing.Point(459, 397)
        Me.btnImprimir.LookAndFeel.SkinName = "Seven"
        Me.btnImprimir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 64)
        Me.btnImprimir.TabIndex = 55
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(109, 397)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 49
        Me.btnEditar.Text = "Editar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(249, 397)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 51
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(319, 397)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 52
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(389, 397)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 53
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(179, 397)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 50
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnQuitar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuitar.Location = New System.Drawing.Point(560, 172)
        Me.btnQuitar.LookAndFeel.SkinName = "Seven"
        Me.btnQuitar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(30, 24)
        Me.btnQuitar.TabIndex = 47
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(529, 172)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(28, 24)
        Me.btnAgregar.TabIndex = 46
        '
        'dgvDocumentosSecundarios
        '
        Me.dgvDocumentosSecundarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentosSecundarios.Location = New System.Drawing.Point(24, 215)
        Me.dgvDocumentosSecundarios.MainView = Me.gvDocumentosSecundarios
        Me.dgvDocumentosSecundarios.Name = "dgvDocumentosSecundarios"
        Me.dgvDocumentosSecundarios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gclinkDetalleDocSec})
        Me.dgvDocumentosSecundarios.Size = New System.Drawing.Size(569, 176)
        Me.dgvDocumentosSecundarios.TabIndex = 45
        Me.dgvDocumentosSecundarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDocumentosSecundarios})
        '
        'gvDocumentosSecundarios
        '
        Me.gvDocumentosSecundarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.gcNroRegistro})
        Me.gvDocumentosSecundarios.GridControl = Me.dgvDocumentosSecundarios
        Me.gvDocumentosSecundarios.Name = "gvDocumentosSecundarios"
        Me.gvDocumentosSecundarios.OptionsView.ColumnAutoWidth = False
        Me.gvDocumentosSecundarios.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nro Documento"
        Me.GridColumn1.FieldName = "docSecId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 115
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha Ingreso"
        Me.GridColumn2.FieldName = "docSecfechaIng"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Asunto"
        Me.GridColumn3.FieldName = "docSecAsunto"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'gcNroRegistro
        '
        Me.gcNroRegistro.Caption = "Nro Registro"
        Me.gcNroRegistro.ColumnEdit = Me.gclinkDetalleDocSec
        Me.gcNroRegistro.FieldName = "docSecNroReg"
        Me.gcNroRegistro.Name = "gcNroRegistro"
        Me.gcNroRegistro.Visible = True
        Me.gcNroRegistro.VisibleIndex = 0
        '
        'gclinkDetalleDocSec
        '
        Me.gclinkDetalleDocSec.AutoHeight = False
        Me.gclinkDetalleDocSec.Name = "gclinkDetalleDocSec"
        '
        'txtDocSecId
        '
        Me.txtDocSecId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocSecId.Location = New System.Drawing.Point(22, 137)
        Me.txtDocSecId.Name = "txtDocSecId"
        Me.txtDocSecId.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtDocSecId.Properties.Appearance.Options.UseBackColor = True
        Me.txtDocSecId.Size = New System.Drawing.Size(501, 50)
        Me.txtDocSecId.TabIndex = 42
        Me.txtDocSecId.UseOptimizedRendering = True
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(24, 103)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(90, 13)
        Me.SaimtLabel1.TabIndex = 41
        Me.SaimtLabel1.Text = "Doc. Complemento"
        '
        'btnBuscarDocId
        '
        Me.btnBuscarDocId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarDocId.Image = CType(resources.GetObject("btnBuscarDocId.Image"), System.Drawing.Image)
        Me.btnBuscarDocId.Location = New System.Drawing.Point(529, 48)
        Me.btnBuscarDocId.Name = "btnBuscarDocId"
        Me.btnBuscarDocId.Size = New System.Drawing.Size(25, 21)
        Me.btnBuscarDocId.TabIndex = 40
        '
        'txtDocId
        '
        Me.txtDocId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocId.Location = New System.Drawing.Point(20, 46)
        Me.txtDocId.Name = "txtDocId"
        Me.txtDocId.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtDocId.Properties.Appearance.Options.UseBackColor = True
        Me.txtDocId.Size = New System.Drawing.Size(503, 50)
        Me.txtDocId.TabIndex = 39
        Me.txtDocId.UseOptimizedRendering = True
        '
        'SaimtLabel27
        '
        Me.SaimtLabel27.Location = New System.Drawing.Point(24, 12)
        Me.SaimtLabel27.Name = "SaimtLabel27"
        Me.SaimtLabel27.Size = New System.Drawing.Size(64, 13)
        Me.SaimtLabel27.TabIndex = 38
        Me.SaimtLabel27.Text = "Doc. Principal"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(26, 194)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(326, 19)
        Me.LabelControl1.TabIndex = 63
        Me.LabelControl1.Text = "Documentos vinculados al Doc. Principal"
        '
        'frmAgrupacionDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonImprimir = Me.btnImprimir
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ClientSize = New System.Drawing.Size(602, 502)
        Me.Controls.Add(Me.SaimtLabel27)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SaimtLabel6)
        Me.Controls.Add(Me.SaimtLabel5)
        Me.Controls.Add(Me.lblDocSecIdFecha)
        Me.Controls.Add(Me.txtDocId)
        Me.Controls.Add(Me.lblDocIdFecha)
        Me.Controls.Add(Me.lnkDocSecId)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.SaimtLabel1)
        Me.Controls.Add(Me.lnkDocId)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtDocSecId)
        Me.Controls.Add(Me.btnBuscarDocId)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvDocumentosSecundarios)
        Me.Controls.Add(Me.btnBuscarDocSecId)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmAgrupacionDoc"
        Me.Text = "Vincular Expedientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiar, 0)
        Me.Controls.SetChildIndex(Me.btnQuitar, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarDocSecId, 0)
        Me.Controls.SetChildIndex(Me.dgvDocumentosSecundarios, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarDocId, 0)
        Me.Controls.SetChildIndex(Me.txtDocSecId, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lnkDocId, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.lnkDocSecId, 0)
        Me.Controls.SetChildIndex(Me.lblDocIdFecha, 0)
        Me.Controls.SetChildIndex(Me.txtDocId, 0)
        Me.Controls.SetChildIndex(Me.lblDocSecIdFecha, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel5, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel6, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel27, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDocumentosSecundarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDocumentosSecundarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gclinkDetalleDocSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocSecId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDocId As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel27 As SaimtControles.SaimtLabel
    Friend WithEvents txtDocSecId As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents btnBuscarDocId As SaimtControles.SaimtButton
    Friend WithEvents dgvDocumentosSecundarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDocumentosSecundarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitar As SaimtControles.SaimtButton
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents lnkDocSecId As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkDocId As System.Windows.Forms.LinkLabel
    Friend WithEvents btnBuscarDocSecId As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents lblDocSecIdFecha As SaimtControles.SaimtLabel
    Friend WithEvents lblDocIdFecha As SaimtControles.SaimtLabel
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNroRegistro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gclinkDetalleDocSec As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
