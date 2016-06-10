<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPivotRecaudacionDet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPivotRecaudacionDet))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.btnrefrescar = New SaimtControles.SaimtButton()
        Me.cmbGrupoIngresos = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.dtpRecfecPago = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.dgvRecaudacionDet = New SaimtControles.SaimtDataGrid()
        Me.gvRecaudacionDet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ricmbgrupoingreso = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.cmbGrupoIngresos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRecfecPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRecfecPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.dgvRecaudacionDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRecaudacionDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ricmbgrupoingreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 739)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(985, 27)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.btnrefrescar)
        Me.SaimtGroupBox1.Controls.Add(Me.cmbGrupoIngresos)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Controls.Add(Me.dtpRecfecPago)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel13)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(961, 65)
        Me.SaimtGroupBox1.TabIndex = 2
        Me.SaimtGroupBox1.Text = "Datos de Recaudación"
        '
        'btnrefrescar
        '
        Me.btnrefrescar.Image = CType(resources.GetObject("btnrefrescar.Image"), System.Drawing.Image)
        Me.btnrefrescar.Location = New System.Drawing.Point(790, 29)
        Me.btnrefrescar.Name = "btnrefrescar"
        Me.btnrefrescar.Size = New System.Drawing.Size(31, 23)
        Me.btnrefrescar.TabIndex = 30
        '
        'cmbGrupoIngresos
        '
        Me.cmbGrupoIngresos.Location = New System.Drawing.Point(329, 32)
        Me.cmbGrupoIngresos.MenuManager = Me.RibbonControl
        Me.cmbGrupoIngresos.Name = "cmbGrupoIngresos"
        Me.cmbGrupoIngresos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGrupoIngresos.Properties.NullText = ""
        Me.cmbGrupoIngresos.Size = New System.Drawing.Size(455, 20)
        Me.cmbGrupoIngresos.TabIndex = 11
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(254, 34)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel1.TabIndex = 30
        Me.SaimtLabel1.Text = "Grupo Ingreso"
        '
        'dtpRecfecPago
        '
        Me.dtpRecfecPago.EditValue = Nothing
        Me.dtpRecfecPago.Location = New System.Drawing.Point(128, 32)
        Me.dtpRecfecPago.MenuManager = Me.RibbonControl
        Me.dtpRecfecPago.Name = "dtpRecfecPago"
        Me.dtpRecfecPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpRecfecPago.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpRecfecPago.Size = New System.Drawing.Size(100, 20)
        Me.dtpRecfecPago.TabIndex = 29
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(12, 34)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(91, 13)
        Me.SaimtLabel13.TabIndex = 28
        Me.SaimtLabel13.Text = "Fecha de deposito "
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox2.Controls.Add(Me.dgvRecaudacionDet)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(12, 79)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(964, 654)
        Me.SaimtGroupBox2.TabIndex = 3
        Me.SaimtGroupBox2.Text = "Detalle Recaudación"
        '
        'dgvRecaudacionDet
        '
        Me.dgvRecaudacionDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecaudacionDet.Location = New System.Drawing.Point(2, 22)
        Me.dgvRecaudacionDet.MainView = Me.gvRecaudacionDet
        Me.dgvRecaudacionDet.MenuManager = Me.RibbonControl
        Me.dgvRecaudacionDet.Name = "dgvRecaudacionDet"
        Me.dgvRecaudacionDet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.ricmbgrupoingreso})
        Me.dgvRecaudacionDet.Size = New System.Drawing.Size(960, 630)
        Me.dgvRecaudacionDet.TabIndex = 10
        Me.dgvRecaudacionDet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRecaudacionDet})
        '
        'gvRecaudacionDet
        '
        Me.gvRecaudacionDet.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvRecaudacionDet.Appearance.FooterPanel.Options.UseFont = True
        Me.gvRecaudacionDet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.gvRecaudacionDet.GridControl = Me.dgvRecaudacionDet
        Me.gvRecaudacionDet.GroupCount = 1
        Me.gvRecaudacionDet.Name = "gvRecaudacionDet"
        Me.gvRecaudacionDet.OptionsBehavior.ReadOnly = True
        Me.gvRecaudacionDet.OptionsView.ColumnAutoWidth = False
        Me.gvRecaudacionDet.OptionsView.ShowFooter = True
        Me.gvRecaudacionDet.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Concepto"
        Me.GridColumn1.FieldName = "conid"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Concepto"
        Me.GridColumn2.FieldName = "concepto"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Monto Depositado"
        Me.GridColumn3.DisplayFormat.FormatString = "n2"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "montodep"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "montodep", "Total : {0:###,##0.00}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "% SAIMT"
        Me.GridColumn4.FieldName = "porsaimt"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Ing. SAIMT"
        Me.GridColumn5.FieldName = "ingsaimt"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha Liquidación X Concepto"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn6.FieldName = "fechaLiq"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Cuenta Cargo"
        Me.GridColumn7.FieldName = "CuentaCargo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Cuenta Abono"
        Me.GridColumn8.FieldName = "CuentaAbono"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Grupo Ingreso"
        Me.GridColumn9.ColumnEdit = Me.ricmbgrupoingreso
        Me.GridColumn9.FieldName = "tgGrupoConId"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        '
        'ricmbgrupoingreso
        '
        Me.ricmbgrupoingreso.AutoHeight = False
        Me.ricmbgrupoingreso.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ricmbgrupoingreso.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgNombre", "Nombre")})
        Me.ricmbgrupoingreso.Name = "ricmbgrupoingreso"
        '
        'frmPivotRecaudacionDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 766)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.LookAndFeel.SkinName = "Seven"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmPivotRecaudacionDet"
        Me.Text = "frmRecaudacionDet"
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.cmbGrupoIngresos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRecfecPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRecfecPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        CType(Me.dgvRecaudacionDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRecaudacionDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ricmbgrupoingreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents dgvRecaudacionDet As SaimtControles.SaimtDataGrid
    Friend WithEvents gvRecaudacionDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtpRecfecPago As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbGrupoIngresos As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents btnrefrescar As SaimtControles.SaimtButton
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ricmbgrupoingreso As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
