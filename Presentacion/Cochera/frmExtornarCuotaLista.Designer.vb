<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtornarCuotaLista
    Inherits frmCancelacion

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExtornarCuotaLista))
        Me.btnGuardarCancelacion = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.dgvProgramacionAbonos = New SaimtControles.SaimtDataGrid()
        Me.gvProgramacionAbonos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.btnRemover = New SaimtControles.SaimtButton()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.txtNroCuotasPagadas = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.txtNroCuotasPendientes = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.txtNroTotalCuotas = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.cboCanDesde = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.dtpFechaCancelacion = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.txtObsContrato = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.cboMotivoExtorno = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.txtNroContrato = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.dgvProgramacionAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProgramacionAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroCuotasPagadas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroCuotasPendientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroTotalCuotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCanDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaCancelacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObsContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMotivoExtorno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 443)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(545, 27)
        '
        'btnGuardarCancelacion
        '
        Me.btnGuardarCancelacion.Image = CType(resources.GetObject("btnGuardarCancelacion.Image"), System.Drawing.Image)
        Me.btnGuardarCancelacion.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnGuardarCancelacion.Location = New System.Drawing.Point(230, 381)
        Me.btnGuardarCancelacion.Name = "btnGuardarCancelacion"
        Me.btnGuardarCancelacion.Size = New System.Drawing.Size(75, 58)
        Me.btnGuardarCancelacion.TabIndex = 50
        Me.btnGuardarCancelacion.Text = "Guardar"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.dgvProgramacionAbonos)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel9)
        Me.SaimtGroupBox1.Controls.Add(Me.btnRemover)
        Me.SaimtGroupBox1.Controls.Add(Me.btnAgregar)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroCuotasPagadas)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroCuotasPendientes)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel7)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroTotalCuotas)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox1.Controls.Add(Me.cboCanDesde)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox1.Controls.Add(Me.dtpFechaCancelacion)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox1.Controls.Add(Me.txtObsContrato)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.cboMotivoExtorno)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNroContrato)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(532, 369)
        Me.SaimtGroupBox1.TabIndex = 49
        Me.SaimtGroupBox1.Text = "Datos para la Cancelación"
        '
        'dgvProgramacionAbonos
        '
        Me.dgvProgramacionAbonos.Location = New System.Drawing.Point(9, 120)
        Me.dgvProgramacionAbonos.MainView = Me.gvProgramacionAbonos
        Me.dgvProgramacionAbonos.MenuManager = Me.RibbonControl
        Me.dgvProgramacionAbonos.Name = "dgvProgramacionAbonos"
        Me.dgvProgramacionAbonos.Size = New System.Drawing.Size(510, 155)
        Me.dgvProgramacionAbonos.TabIndex = 19
        Me.dgvProgramacionAbonos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProgramacionAbonos})
        '
        'gvProgramacionAbonos
        '
        Me.gvProgramacionAbonos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.gvProgramacionAbonos.GridControl = Me.dgvProgramacionAbonos
        Me.gvProgramacionAbonos.Name = "gvProgramacionAbonos"
        Me.gvProgramacionAbonos.OptionsView.ColumnAutoWidth = False
        Me.gvProgramacionAbonos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Abono"
        Me.GridColumn1.FieldName = "AbonDetId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nro. Abono"
        Me.GridColumn2.FieldName = "AbonDetNroCuota"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha Inicio"
        Me.GridColumn3.FieldName = "AbonDetFechaIni"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha Termino"
        Me.GridColumn4.FieldName = "AbonDetFechaFin"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Importe (S/.)"
        Me.GridColumn5.FieldName = "AbonDetImporte"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(11, 106)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(164, 13)
        Me.SaimtLabel9.TabIndex = 18
        Me.SaimtLabel9.Text = "Lista de Cuotas para ser Anuladas"
        '
        'btnRemover
        '
        Me.btnRemover.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnRemover.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRemover.Location = New System.Drawing.Point(492, 100)
        Me.btnRemover.LookAndFeel.SkinName = "Seven"
        Me.btnRemover.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(25, 18)
        Me.btnRemover.TabIndex = 17
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(464, 100)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 18)
        Me.btnAgregar.TabIndex = 16
        '
        'txtNroCuotasPagadas
        '
        Me.txtNroCuotasPagadas.Location = New System.Drawing.Point(441, 281)
        Me.txtNroCuotasPagadas.MenuManager = Me.RibbonControl
        Me.txtNroCuotasPagadas.Name = "txtNroCuotasPagadas"
        Me.txtNroCuotasPagadas.Size = New System.Drawing.Size(78, 20)
        Me.txtNroCuotasPagadas.TabIndex = 15
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(361, 284)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(78, 13)
        Me.SaimtLabel8.TabIndex = 14
        Me.SaimtLabel8.Text = "Cuotas pagadas"
        '
        'txtNroCuotasPendientes
        '
        Me.txtNroCuotasPendientes.Location = New System.Drawing.Point(265, 281)
        Me.txtNroCuotasPendientes.MenuManager = Me.RibbonControl
        Me.txtNroCuotasPendientes.Name = "txtNroCuotasPendientes"
        Me.txtNroCuotasPendientes.Size = New System.Drawing.Size(78, 20)
        Me.txtNroCuotasPendientes.TabIndex = 13
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(169, 284)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(90, 13)
        Me.SaimtLabel7.TabIndex = 12
        Me.SaimtLabel7.Text = "Cuotas pendientes"
        '
        'txtNroTotalCuotas
        '
        Me.txtNroTotalCuotas.Location = New System.Drawing.Point(65, 281)
        Me.txtNroTotalCuotas.MenuManager = Me.RibbonControl
        Me.txtNroTotalCuotas.Name = "txtNroTotalCuotas"
        Me.txtNroTotalCuotas.Size = New System.Drawing.Size(77, 20)
        Me.txtNroTotalCuotas.TabIndex = 11
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(10, 284)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(49, 13)
        Me.SaimtLabel6.TabIndex = 10
        Me.SaimtLabel6.Text = "N° Cuotas"
        '
        'cboCanDesde
        '
        Me.cboCanDesde.Location = New System.Drawing.Point(105, 75)
        Me.cboCanDesde.MenuManager = Me.RibbonControl
        Me.cboCanDesde.Name = "cboCanDesde"
        Me.cboCanDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCanDesde.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name1", "Cod. Abono"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name2", "Nro. Abono"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Fecha Inicio"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name4", "Fecha Termino"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name5", "Importe (S/.)")})
        Me.cboCanDesde.Properties.NullText = ""
        Me.cboCanDesde.Size = New System.Drawing.Size(411, 20)
        Me.cboCanDesde.TabIndex = 9
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(9, 78)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(90, 13)
        Me.SaimtLabel5.TabIndex = 8
        Me.SaimtLabel5.Text = "Cuotas Disponibles"
        '
        'dtpFechaCancelacion
        '
        Me.dtpFechaCancelacion.Location = New System.Drawing.Point(303, 25)
        Me.dtpFechaCancelacion.MenuManager = Me.RibbonControl
        Me.dtpFechaCancelacion.Name = "dtpFechaCancelacion"
        Me.dtpFechaCancelacion.Properties.ReadOnly = True
        Me.dtpFechaCancelacion.Size = New System.Drawing.Size(149, 20)
        Me.dtpFechaCancelacion.TabIndex = 7
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(210, 28)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(89, 13)
        Me.SaimtLabel4.TabIndex = 6
        Me.SaimtLabel4.Text = "Fecha Cancelación"
        '
        'txtObsContrato
        '
        Me.txtObsContrato.Location = New System.Drawing.Point(8, 318)
        Me.txtObsContrato.MenuManager = Me.RibbonControl
        Me.txtObsContrato.Name = "txtObsContrato"
        Me.txtObsContrato.Size = New System.Drawing.Size(510, 45)
        Me.txtObsContrato.TabIndex = 5
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(11, 303)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(60, 13)
        Me.SaimtLabel3.TabIndex = 4
        Me.SaimtLabel3.Text = "Observación"
        '
        'cboMotivoExtorno
        '
        Me.cboMotivoExtorno.Location = New System.Drawing.Point(83, 49)
        Me.cboMotivoExtorno.MenuManager = Me.RibbonControl
        Me.cboMotivoExtorno.Name = "cboMotivoExtorno"
        Me.cboMotivoExtorno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMotivoExtorno.Properties.NullText = ""
        Me.cboMotivoExtorno.Size = New System.Drawing.Size(434, 20)
        Me.cboMotivoExtorno.TabIndex = 3
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(7, 52)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(73, 13)
        Me.SaimtLabel2.TabIndex = 2
        Me.SaimtLabel2.Text = "Motivo Extorno"
        '
        'txtNroContrato
        '
        Me.txtNroContrato.Location = New System.Drawing.Point(83, 25)
        Me.txtNroContrato.MenuManager = Me.RibbonControl
        Me.txtNroContrato.Name = "txtNroContrato"
        Me.txtNroContrato.Size = New System.Drawing.Size(100, 20)
        Me.txtNroContrato.TabIndex = 1
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(22, 28)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "N° Contrato"
        '
        'frmExtornarCuotaLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 470)
        Me.Controls.Add(Me.btnGuardarCancelacion)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmExtornarCuotaLista"
        Me.Text = "frmExtornarCuotaLista"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarCancelacion, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.dgvProgramacionAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProgramacionAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroCuotasPagadas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroCuotasPendientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroTotalCuotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCanDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaCancelacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObsContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMotivoExtorno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardarCancelacion As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtNroCuotasPagadas As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroCuotasPendientes As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroTotalCuotas As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents cboCanDesde As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaCancelacion As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents txtObsContrato As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents cboMotivoExtorno As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents txtNroContrato As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents dgvProgramacionAbonos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvProgramacionAbonos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents btnRemover As SaimtControles.SaimtButton
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
End Class
