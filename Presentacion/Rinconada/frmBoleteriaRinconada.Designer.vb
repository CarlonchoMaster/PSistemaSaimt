﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoleteriaRinconada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoleteriaRinconada))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.SaimtSpinner1 = New SaimtControles.SaimtSpinner()
        Me.txtimporte = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtHora = New SaimtControles.SaimtTextBox()
        Me.txtfecha = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.cboConcepto = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.btnOK = New SaimtControles.SaimtButton()
        Me.txtNticket = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.btnExtornar = New SaimtControles.SaimtButton()
        Me.btnBuscar = New SaimtControles.SaimtButton()
        Me.SaimtDateTimePicker1 = New SaimtControles.SaimtDateTimePicker()
        Me.btnExportar = New SaimtControles.SaimtButton()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.dgvBoleteria = New SaimtControles.SaimtDataGrid()
        Me.gvBoleteria = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tmhora = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.SaimtSpinner1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtimporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNticket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.SaimtDateTimePicker1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtDateTimePicker1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBoleteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBoleteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 688)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1016, 27)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtGroupBox1.Appearance.Options.UseFont = True
        Me.SaimtGroupBox1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtGroupBox1.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseFont = True
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseForeColor = True
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseTextOptions = True
        Me.SaimtGroupBox1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtSpinner1)
        Me.SaimtGroupBox1.Controls.Add(Me.txtimporte)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.txtHora)
        Me.SaimtGroupBox1.Controls.Add(Me.txtfecha)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Controls.Add(Me.cboConcepto)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox1.Controls.Add(Me.btnOK)
        Me.SaimtGroupBox1.Controls.Add(Me.txtNticket)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(1002, 231)
        Me.SaimtGroupBox1.TabIndex = 3
        Me.SaimtGroupBox1.Text = "Boleteria Centro Recreacional"
        '
        'SaimtSpinner1
        '
        Me.SaimtSpinner1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SaimtSpinner1.Location = New System.Drawing.Point(765, 60)
        Me.SaimtSpinner1.MenuManager = Me.RibbonControl
        Me.SaimtSpinner1.Name = "SaimtSpinner1"
        Me.SaimtSpinner1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 60.25!)
        Me.SaimtSpinner1.Properties.Appearance.Options.UseFont = True
        Me.SaimtSpinner1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SaimtSpinner1.Properties.IsFloatValue = False
        Me.SaimtSpinner1.Properties.Mask.EditMask = "N00"
        Me.SaimtSpinner1.Size = New System.Drawing.Size(115, 104)
        Me.SaimtSpinner1.TabIndex = 11
        '
        'txtimporte
        '
        Me.txtimporte.EditValue = "0"
        Me.txtimporte.Location = New System.Drawing.Point(886, 203)
        Me.txtimporte.MenuManager = Me.RibbonControl
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtimporte.Properties.Appearance.Options.UseFont = True
        Me.txtimporte.Properties.Appearance.Options.UseTextOptions = True
        Me.txtimporte.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtimporte.Properties.Mask.EditMask = "n2"
        Me.txtimporte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtimporte.Properties.ReadOnly = True
        Me.txtimporte.Size = New System.Drawing.Size(106, 26)
        Me.txtimporte.TabIndex = 10
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel3.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtLabel3.Location = New System.Drawing.Point(805, 201)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(75, 25)
        Me.SaimtLabel3.TabIndex = 9
        Me.SaimtLabel3.Text = "Importe"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(591, 30)
        Me.txtHora.MenuManager = Me.RibbonControl
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtHora.Properties.Appearance.Options.UseFont = True
        Me.txtHora.Properties.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(139, 26)
        Me.txtHora.TabIndex = 8
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(301, 29)
        Me.txtfecha.MenuManager = Me.RibbonControl
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtfecha.Properties.Appearance.Options.UseFont = True
        Me.txtfecha.Properties.ReadOnly = True
        Me.txtfecha.Size = New System.Drawing.Size(182, 26)
        Me.txtfecha.TabIndex = 7
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel10.Location = New System.Drawing.Point(551, 32)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(34, 19)
        Me.SaimtLabel10.TabIndex = 6
        Me.SaimtLabel10.Text = "Hora"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel2.Location = New System.Drawing.Point(255, 32)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(40, 19)
        Me.SaimtLabel2.TabIndex = 5
        Me.SaimtLabel2.Text = "Fecha"
        '
        'cboConcepto
        '
        Me.cboConcepto.Location = New System.Drawing.Point(203, 167)
        Me.cboConcepto.MenuManager = Me.RibbonControl
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConcepto.Properties.Appearance.Options.UseFont = True
        Me.cboConcepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConcepto.Properties.NullText = ""
        Me.cboConcepto.Size = New System.Drawing.Size(797, 30)
        Me.cboConcepto.TabIndex = 4
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel5.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtLabel5.Location = New System.Drawing.Point(118, 168)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(72, 25)
        Me.SaimtLabel5.TabIndex = 3
        Me.SaimtLabel5.Text = "Servicio"
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnOK.Location = New System.Drawing.Point(886, 63)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(110, 98)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "Ticket Nuevo"
        '
        'txtNticket
        '
        Me.txtNticket.EditValue = ""
        Me.txtNticket.Location = New System.Drawing.Point(199, 60)
        Me.txtNticket.MenuManager = Me.RibbonControl
        Me.txtNticket.Name = "txtNticket"
        Me.txtNticket.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNticket.Properties.Appearance.Options.UseFont = True
        Me.txtNticket.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNticket.Properties.MaxLength = 8
        Me.txtNticket.Properties.ReadOnly = True
        Me.txtNticket.Size = New System.Drawing.Size(560, 104)
        Me.txtNticket.TabIndex = 1
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel1.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtLabel1.Location = New System.Drawing.Point(9, 84)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(183, 54)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "N° Ticket"
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Controls.Add(Me.btnExtornar)
        Me.SaimtGroupBox3.Controls.Add(Me.btnBuscar)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtDateTimePicker1)
        Me.SaimtGroupBox3.Controls.Add(Me.btnExportar)
        Me.SaimtGroupBox3.Controls.Add(Me.btnImprimir)
        Me.SaimtGroupBox3.Controls.Add(Me.dgvBoleteria)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(8, 241)
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(1002, 441)
        Me.SaimtGroupBox3.TabIndex = 8
        Me.SaimtGroupBox3.Text = "Consulta de Datos"
        '
        'btnExtornar
        '
        Me.btnExtornar.Image = CType(resources.GetObject("btnExtornar.Image"), System.Drawing.Image)
        Me.btnExtornar.Location = New System.Drawing.Point(734, 29)
        Me.btnExtornar.Name = "btnExtornar"
        Me.btnExtornar.Size = New System.Drawing.Size(89, 35)
        Me.btnExtornar.TabIndex = 17
        Me.btnExtornar.Text = "Extornar"
        Me.btnExtornar.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(703, 33)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscar.TabIndex = 16
        '
        'SaimtDateTimePicker1
        '
        Me.SaimtDateTimePicker1.EditValue = Nothing
        Me.SaimtDateTimePicker1.Location = New System.Drawing.Point(560, 35)
        Me.SaimtDateTimePicker1.MenuManager = Me.RibbonControl
        Me.SaimtDateTimePicker1.Name = "SaimtDateTimePicker1"
        Me.SaimtDateTimePicker1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SaimtDateTimePicker1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SaimtDateTimePicker1.Size = New System.Drawing.Size(137, 20)
        Me.SaimtDateTimePicker1.TabIndex = 15
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(829, 28)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(79, 36)
        Me.btnExportar.TabIndex = 9
        Me.btnExportar.Text = "Exportar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(910, 28)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(86, 36)
        Me.btnImprimir.TabIndex = 14
        Me.btnImprimir.Text = "Imprimir Duplicado"
        '
        'dgvBoleteria
        '
        Me.dgvBoleteria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBoleteria.Location = New System.Drawing.Point(2, 21)
        Me.dgvBoleteria.MainView = Me.gvBoleteria
        Me.dgvBoleteria.MenuManager = Me.RibbonControl
        Me.dgvBoleteria.Name = "dgvBoleteria"
        Me.dgvBoleteria.Size = New System.Drawing.Size(998, 418)
        Me.dgvBoleteria.TabIndex = 10
        Me.dgvBoleteria.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBoleteria})
        '
        'gvBoleteria
        '
        Me.gvBoleteria.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvBoleteria.Appearance.FooterPanel.Options.UseFont = True
        Me.gvBoleteria.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.gvBoleteria.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn2, Me.GridColumn5, Me.GridColumn7})
        Me.gvBoleteria.GridControl = Me.dgvBoleteria
        Me.gvBoleteria.Name = "gvBoleteria"
        Me.gvBoleteria.OptionsBehavior.ReadOnly = True
        Me.gvBoleteria.OptionsFind.AlwaysVisible = True
        Me.gvBoleteria.OptionsPrint.AutoWidth = False
        Me.gvBoleteria.OptionsView.ColumnAutoWidth = False
        Me.gvBoleteria.OptionsView.ShowFooter = True
        Me.gvBoleteria.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "N° Ticket"
        Me.GridColumn1.FieldName = "bolCod"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha Ing."
        Me.GridColumn3.FieldName = "bolFechaIng"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Hora Entrada"
        Me.GridColumn4.FieldName = "bolHoraIng"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseFont = True
        Me.GridColumn6.Caption = "Precio (S/.)"
        Me.GridColumn6.FieldName = "bolPrecio"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Cantidad"
        Me.GridColumn2.FieldName = "bolCantidad"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Importe (S/.)"
        Me.GridColumn5.DisplayFormat.FormatString = "n2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "bolTotal"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "bolTotal", "Total : {0:###,##0.00}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Estado"
        Me.GridColumn7.FieldName = "tgEstado"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'tmhora
        '
        Me.tmhora.Interval = 60000
        '
        'frmBoleteriaRinconada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 715)
        Me.Controls.Add(Me.SaimtGroupBox3)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmBoleteriaRinconada"
        Me.Text = "Boletería Parque Recreacional la Rinconada"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox3, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.SaimtSpinner1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtimporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNticket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        CType(Me.SaimtDateTimePicker1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtDateTimePicker1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBoleteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBoleteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtimporte As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents txtHora As SaimtControles.SaimtTextBox
    Friend WithEvents txtfecha As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents cboConcepto As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents btnOK As SaimtControles.SaimtButton
    Friend WithEvents txtNticket As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents btnExportar As SaimtControles.SaimtButton
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents dgvBoleteria As SaimtControles.SaimtDataGrid
    Friend WithEvents gvBoleteria As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tmhora As System.Windows.Forms.Timer
    Friend WithEvents SaimtSpinner1 As SaimtControles.SaimtSpinner
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtDateTimePicker1 As SaimtControles.SaimtDateTimePicker
    Friend WithEvents btnBuscar As SaimtControles.SaimtButton
    Friend WithEvents btnExtornar As SaimtControles.SaimtButton
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class