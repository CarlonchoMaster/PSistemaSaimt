<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarRecDet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarRecDet))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.txtconcepto = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.dtpfechaliq = New SaimtControles.SaimtDateTimePicker()
        Me.TxtNroDoc = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.cboTipoDoc = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.txtDepositante = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.TxtMontoTotal = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.cboRecaudador = New SaimtControles.SaimtComboBoxLookUp()
        Me.dtpRecfecPago = New SaimtControles.SaimtDateTimePicker()
        Me.TxtRecId = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.btnimprimir = New SaimtControles.SaimtButton()
        Me.btnexportar = New SaimtControles.SaimtButton()
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
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.txtconcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpfechaliq.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpfechaliq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNroDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepositante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMontoTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRecaudador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRecfecPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRecfecPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRecId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.dgvRecaudacionDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRecaudacionDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 626)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(836, 25)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.txtconcepto)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel12)
        Me.SaimtGroupBox1.Controls.Add(Me.dtpfechaliq)
        Me.SaimtGroupBox1.Controls.Add(Me.TxtNroDoc)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel13)
        Me.SaimtGroupBox1.Controls.Add(Me.cboTipoDoc)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel11)
        Me.SaimtGroupBox1.Controls.Add(Me.txtDepositante)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel9)
        Me.SaimtGroupBox1.Controls.Add(Me.TxtMontoTotal)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox1.Controls.Add(Me.cboRecaudador)
        Me.SaimtGroupBox1.Controls.Add(Me.dtpRecfecPago)
        Me.SaimtGroupBox1.Controls.Add(Me.TxtRecId)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(815, 146)
        Me.SaimtGroupBox1.TabIndex = 3
        Me.SaimtGroupBox1.Text = "Datos de Recaudación"
        '
        'txtconcepto
        '
        Me.txtconcepto.Location = New System.Drawing.Point(385, 89)
        Me.txtconcepto.MenuManager = Me.RibbonControl
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Size = New System.Drawing.Size(425, 20)
        Me.txtconcepto.TabIndex = 24
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(295, 92)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(89, 13)
        Me.SaimtLabel12.TabIndex = 23
        Me.SaimtLabel12.Text = "Deposito al Código"
        '
        'dtpfechaliq
        '
        Me.dtpfechaliq.EditValue = Nothing
        Me.dtpfechaliq.Location = New System.Drawing.Point(112, 118)
        Me.dtpfechaliq.MenuManager = Me.RibbonControl
        Me.dtpfechaliq.Name = "dtpfechaliq"
        Me.dtpfechaliq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpfechaliq.Properties.NullText = "No hay Fecha de Liquidación"
        Me.dtpfechaliq.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpfechaliq.Size = New System.Drawing.Size(176, 20)
        Me.dtpfechaliq.TabIndex = 27
        '
        'TxtNroDoc
        '
        Me.TxtNroDoc.Location = New System.Drawing.Point(654, 58)
        Me.TxtNroDoc.MenuManager = Me.RibbonControl
        Me.TxtNroDoc.Name = "TxtNroDoc"
        Me.TxtNroDoc.Size = New System.Drawing.Size(156, 20)
        Me.TxtNroDoc.TabIndex = 22
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(9, 121)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(99, 13)
        Me.SaimtLabel13.TabIndex = 28
        Me.SaimtLabel13.Text = "Fecha de Liquidación"
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.Location = New System.Drawing.Point(385, 58)
        Me.cboTipoDoc.MenuManager = Me.RibbonControl
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoDoc.Properties.NullText = ""
        Me.cboTipoDoc.Size = New System.Drawing.Size(175, 20)
        Me.cboTipoDoc.TabIndex = 21
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(594, 61)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel11.TabIndex = 20
        Me.SaimtLabel11.Text = "Documento"
        '
        'txtDepositante
        '
        Me.txtDepositante.Location = New System.Drawing.Point(552, 30)
        Me.txtDepositante.MenuManager = Me.RibbonControl
        Me.txtDepositante.Name = "txtDepositante"
        Me.txtDepositante.Size = New System.Drawing.Size(258, 20)
        Me.txtDepositante.TabIndex = 19
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(303, 61)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(77, 13)
        Me.SaimtLabel10.TabIndex = 18
        Me.SaimtLabel10.Text = "Tipo Documento"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(488, 33)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel9.TabIndex = 17
        Me.SaimtLabel9.Text = "Depositante"
        '
        'TxtMontoTotal
        '
        Me.TxtMontoTotal.Location = New System.Drawing.Point(386, 30)
        Me.TxtMontoTotal.MenuManager = Me.RibbonControl
        Me.TxtMontoTotal.Name = "TxtMontoTotal"
        Me.TxtMontoTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtMontoTotal.Properties.Appearance.Options.UseFont = True
        Me.TxtMontoTotal.Properties.Mask.EditMask = "n2"
        Me.TxtMontoTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtMontoTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtMontoTotal.Size = New System.Drawing.Size(96, 20)
        Me.TxtMontoTotal.TabIndex = 16
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(323, 33)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel8.TabIndex = 15
        Me.SaimtLabel8.Text = "Depositado"
        '
        'cboRecaudador
        '
        Me.cboRecaudador.Location = New System.Drawing.Point(112, 89)
        Me.cboRecaudador.Name = "cboRecaudador"
        Me.cboRecaudador.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRecaudador.Properties.NullText = ""
        Me.cboRecaudador.Size = New System.Drawing.Size(176, 20)
        Me.cboRecaudador.TabIndex = 14
        '
        'dtpRecfecPago
        '
        Me.dtpRecfecPago.EditValue = Nothing
        Me.dtpRecfecPago.Location = New System.Drawing.Point(112, 58)
        Me.dtpRecfecPago.MenuManager = Me.RibbonControl
        Me.dtpRecfecPago.Name = "dtpRecfecPago"
        Me.dtpRecfecPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpRecfecPago.Properties.ReadOnly = True
        Me.dtpRecfecPago.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpRecfecPago.Size = New System.Drawing.Size(176, 20)
        Me.dtpRecfecPago.TabIndex = 4
        '
        'TxtRecId
        '
        Me.TxtRecId.Location = New System.Drawing.Point(112, 30)
        Me.TxtRecId.MenuManager = Me.RibbonControl
        Me.TxtRecId.Name = "TxtRecId"
        Me.TxtRecId.Properties.ReadOnly = True
        Me.TxtRecId.Size = New System.Drawing.Size(100, 20)
        Me.TxtRecId.TabIndex = 3
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(16, 92)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(90, 13)
        Me.SaimtLabel3.TabIndex = 2
        Me.SaimtLabel3.Text = "Inst. Recaudadora"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(50, 61)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(56, 13)
        Me.SaimtLabel2.TabIndex = 1
        Me.SaimtLabel2.Text = "Fecha Pago"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(19, 33)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(87, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Cod. Recaudación"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.btnimprimir)
        Me.SaimtGroupBox2.Controls.Add(Me.btnexportar)
        Me.SaimtGroupBox2.Controls.Add(Me.dgvRecaudacionDet)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(9, 164)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(815, 443)
        Me.SaimtGroupBox2.TabIndex = 4
        Me.SaimtGroupBox2.Text = "Detalle Recaudación"
        '
        'btnimprimir
        '
        Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
        Me.btnimprimir.Location = New System.Drawing.Point(740, 1)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(71, 23)
        Me.btnimprimir.TabIndex = 12
        Me.btnimprimir.Text = "Imprimir"
        '
        'btnexportar
        '
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.Location = New System.Drawing.Point(624, 1)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(112, 23)
        Me.btnexportar.TabIndex = 11
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'dgvRecaudacionDet
        '
        Me.dgvRecaudacionDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecaudacionDet.Location = New System.Drawing.Point(2, 28)
        Me.dgvRecaudacionDet.MainView = Me.gvRecaudacionDet
        Me.dgvRecaudacionDet.MenuManager = Me.RibbonControl
        Me.dgvRecaudacionDet.Name = "dgvRecaudacionDet"
        Me.dgvRecaudacionDet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.dgvRecaudacionDet.Size = New System.Drawing.Size(811, 413)
        Me.dgvRecaudacionDet.TabIndex = 10
        Me.dgvRecaudacionDet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRecaudacionDet})
        '
        'gvRecaudacionDet
        '
        Me.gvRecaudacionDet.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvRecaudacionDet.Appearance.FooterPanel.Options.UseFont = True
        Me.gvRecaudacionDet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.gvRecaudacionDet.GridControl = Me.dgvRecaudacionDet
        Me.gvRecaudacionDet.Name = "gvRecaudacionDet"
        Me.gvRecaudacionDet.OptionsBehavior.ReadOnly = True
        Me.gvRecaudacionDet.OptionsView.ColumnAutoWidth = False
        Me.gvRecaudacionDet.OptionsView.ShowFooter = True
        Me.gvRecaudacionDet.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Concepto"
        Me.GridColumn1.FieldName = "conid"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Concepto"
        Me.GridColumn2.FieldName = "concepto"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
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
        Me.GridColumn3.VisibleIndex = 5
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "% SAIMT"
        Me.GridColumn4.FieldName = "porsaimt"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Ing. SAIMT"
        Me.GridColumn5.FieldName = "ingsaimt"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha Liquidación X Concepto"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn6.FieldName = "fechaLiq"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 8
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Cod. Recaudación"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Fecha Deposito"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Recaudador"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'frmConsultarRecDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 651)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmConsultarRecDet"
        Me.Text = "frmConsultarRecDet"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.txtconcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpfechaliq.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpfechaliq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNroDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepositante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMontoTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRecaudador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRecfecPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRecfecPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRecId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        CType(Me.dgvRecaudacionDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRecaudacionDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtconcepto As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents dtpfechaliq As SaimtControles.SaimtDateTimePicker
    Friend WithEvents TxtNroDoc As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoDoc As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents txtDepositante As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents TxtMontoTotal As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents cboRecaudador As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents dtpRecfecPago As SaimtControles.SaimtDateTimePicker
    Friend WithEvents TxtRecId As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvRecaudacionDet As SaimtControles.SaimtDataGrid
    Friend WithEvents gvRecaudacionDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnimprimir As SaimtControles.SaimtButton
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
End Class
