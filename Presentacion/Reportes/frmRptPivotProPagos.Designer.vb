﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptPivotProPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptPivotProPagos))
        Me.pgcRecaudacion = New SaimtControles.SaimtPivotGridControl()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pgffechapago = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField18 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField19 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField20 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField21 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField22 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField23 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField24 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField25 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField26 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField27 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField28 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField29 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.cboAños = New SaimtControles.SaimtComboBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnExportarExcel = New SaimtControles.SaimtButton()
        Me.btnVerReporte = New SaimtControles.SaimtButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cboReportes = New SaimtControles.SaimtComboBox()
        Me.sfdDescargar = New System.Windows.Forms.SaveFileDialog()
        Me.beiprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.riprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcRecaudacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.cboAños.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboReportes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riprogreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.beiprogreso)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 715)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1020, 27)
        '
        'pgcRecaudacion
        '
        Me.pgcRecaudacion.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.pgffechapago, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16, Me.PivotGridField17, Me.PivotGridField18, Me.PivotGridField19, Me.PivotGridField20, Me.PivotGridField21, Me.PivotGridField22, Me.PivotGridField23, Me.PivotGridField24, Me.PivotGridField25, Me.PivotGridField12, Me.PivotGridField26, Me.PivotGridField27, Me.PivotGridField28, Me.PivotGridField29})
        Me.pgcRecaudacion.Location = New System.Drawing.Point(0, 0)
        Me.pgcRecaudacion.Name = "pgcRecaudacion"
        Me.pgcRecaudacion.Size = New System.Drawing.Size(1020, 634)
        Me.pgcRecaudacion.TabIndex = 0
        '
        'PivotGridField1
        '
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Cod. Programación"
        Me.PivotGridField1.FieldName = "proPaId"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.Caption = "Año"
        Me.PivotGridField2.FieldName = "año"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.AreaIndex = 12
        Me.PivotGridField3.Caption = "Cod. Persona"
        Me.PivotGridField3.FieldName = "perId"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField4.AreaIndex = 3
        Me.PivotGridField4.Caption = "Persona"
        Me.PivotGridField4.FieldName = "persona"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField5.AreaIndex = 4
        Me.PivotGridField5.Caption = "Contacto"
        Me.PivotGridField5.FieldName = "contacto"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField6.AreaIndex = 6
        Me.PivotGridField6.Caption = "Dirección"
        Me.PivotGridField6.FieldName = "direccion"
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField7.AreaIndex = 8
        Me.PivotGridField7.Caption = "Cod. Concepto"
        Me.PivotGridField7.FieldName = "conId"
        Me.PivotGridField7.Name = "PivotGridField7"
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField8.AreaIndex = 9
        Me.PivotGridField8.Caption = "Concepto"
        Me.PivotGridField8.FieldName = "conNombre"
        Me.PivotGridField8.Name = "PivotGridField8"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField9.AreaIndex = 0
        Me.PivotGridField9.Caption = "Monto"
        Me.PivotGridField9.CellFormat.FormatString = "#,##0.00"
        Me.PivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField9.FieldName = "monto"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField10.AreaIndex = 7
        Me.PivotGridField10.Caption = "N° Cuota"
        Me.PivotGridField10.FieldName = "proPaNroCuota"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.AreaIndex = 1
        Me.PivotGridField11.Caption = "Fecha Vencimiento"
        Me.PivotGridField11.FieldName = "proPaFechaVen"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'pgffechapago
        '
        Me.pgffechapago.AreaIndex = 2
        Me.pgffechapago.Caption = "Fecha Pago"
        Me.pgffechapago.FieldName = "proPaFechaPag"
        Me.pgffechapago.Name = "pgffechapago"
        '
        'PivotGridField13
        '
        Me.PivotGridField13.AreaIndex = 3
        Me.PivotGridField13.Caption = "MesC_Orden"
        Me.PivotGridField13.FieldName = "mesc_orden"
        Me.PivotGridField13.Name = "PivotGridField13"
        '
        'PivotGridField14
        '
        Me.PivotGridField14.AreaIndex = 4
        Me.PivotGridField14.Caption = "Mes_Cuotas"
        Me.PivotGridField14.FieldName = "mes_cuotas"
        Me.PivotGridField14.Name = "PivotGridField14"
        '
        'PivotGridField15
        '
        Me.PivotGridField15.AreaIndex = 5
        Me.PivotGridField15.Caption = "Estado"
        Me.PivotGridField15.FieldName = "tgEstado"
        Me.PivotGridField15.Name = "PivotGridField15"
        '
        'PivotGridField16
        '
        Me.PivotGridField16.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField16.AreaIndex = 5
        Me.PivotGridField16.Caption = "Cod. Inmueble"
        Me.PivotGridField16.FieldName = "inmId"
        Me.PivotGridField16.Name = "PivotGridField16"
        '
        'PivotGridField17
        '
        Me.PivotGridField17.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField17.AreaIndex = 3
        Me.PivotGridField17.Caption = "Comisión"
        Me.PivotGridField17.CellFormat.FormatString = "#,##0.00"
        Me.PivotGridField17.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField17.FieldName = "proPaComision"
        Me.PivotGridField17.Name = "PivotGridField17"
        '
        'PivotGridField18
        '
        Me.PivotGridField18.AreaIndex = 6
        Me.PivotGridField18.Caption = "MesP_Orden"
        Me.PivotGridField18.FieldName = "mesp_orden"
        Me.PivotGridField18.Name = "PivotGridField18"
        '
        'PivotGridField19
        '
        Me.PivotGridField19.AreaIndex = 7
        Me.PivotGridField19.Caption = "Mes_Pagado"
        Me.PivotGridField19.FieldName = "mes_pagado"
        Me.PivotGridField19.Name = "PivotGridField19"
        '
        'PivotGridField20
        '
        Me.PivotGridField20.AreaIndex = 8
        Me.PivotGridField20.Caption = "Condicion Legal"
        Me.PivotGridField20.FieldName = "TgInmCondLegalId"
        Me.PivotGridField20.Name = "PivotGridField20"
        '
        'PivotGridField21
        '
        Me.PivotGridField21.AreaIndex = 9
        Me.PivotGridField21.Caption = "Condicion Registral"
        Me.PivotGridField21.FieldName = "tgInmCondRegId"
        Me.PivotGridField21.Name = "PivotGridField21"
        '
        'PivotGridField22
        '
        Me.PivotGridField22.AreaIndex = 10
        Me.PivotGridField22.Caption = "Antiguedad Deuda"
        Me.PivotGridField22.FieldName = "DiferenciaDias"
        Me.PivotGridField22.Name = "PivotGridField22"
        '
        'PivotGridField23
        '
        Me.PivotGridField23.AreaIndex = 11
        Me.PivotGridField23.Caption = "Comp. Pago"
        Me.PivotGridField23.FieldName = "CompPago"
        Me.PivotGridField23.Name = "PivotGridField23"
        '
        'PivotGridField24
        '
        Me.PivotGridField24.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField24.AreaIndex = 1
        Me.PivotGridField24.Caption = "Tipo Doc."
        Me.PivotGridField24.FieldName = "TipoDoc"
        Me.PivotGridField24.Name = "PivotGridField24"
        '
        'PivotGridField25
        '
        Me.PivotGridField25.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField25.AreaIndex = 2
        Me.PivotGridField25.Caption = "Nro. Doc"
        Me.PivotGridField25.FieldName = "NroDoc"
        Me.PivotGridField25.Name = "PivotGridField25"
        '
        'PivotGridField12
        '
        Me.PivotGridField12.AreaIndex = 13
        Me.PivotGridField12.Caption = "Clasificación Uso"
        Me.PivotGridField12.FieldName = "TipoUso"
        Me.PivotGridField12.Name = "PivotGridField12"
        '
        'PivotGridField26
        '
        Me.PivotGridField26.AreaIndex = 14
        Me.PivotGridField26.Caption = "Área(M2)"
        Me.PivotGridField26.FieldName = "aream2"
        Me.PivotGridField26.Name = "PivotGridField26"
        '
        'PivotGridField27
        '
        Me.PivotGridField27.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField27.AreaIndex = 1
        Me.PivotGridField27.Caption = "Ingreso SAIMT"
        Me.PivotGridField27.CellFormat.FormatString = "#,##0.00"
        Me.PivotGridField27.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField27.FieldName = "ingsaimt"
        Me.PivotGridField27.Name = "PivotGridField27"
        '
        'PivotGridField28
        '
        Me.PivotGridField28.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField28.AreaIndex = 2
        Me.PivotGridField28.Caption = "Ingreso MPT"
        Me.PivotGridField28.CellFormat.FormatString = "#,##0.00"
        Me.PivotGridField28.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField28.FieldName = "ingmpt"
        Me.PivotGridField28.Name = "PivotGridField28"
        '
        'PivotGridField29
        '
        Me.PivotGridField29.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField29.AreaIndex = 4
        Me.PivotGridField29.Caption = "Neto SAIMT"
        Me.PivotGridField29.CellFormat.FormatString = "#,##0.00"
        Me.PivotGridField29.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField29.FieldName = "netosaimt"
        Me.PivotGridField29.Name = "PivotGridField29"
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
        Me.DockPanel1.ID = New System.Guid("169e78ee-e836-4a79-acbd-9eb64db13632")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 634)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 81)
        Me.DockPanel1.Size = New System.Drawing.Size(1020, 81)
        Me.DockPanel1.Text = "Datos para Reporte"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.cboAños)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.btnExportarExcel)
        Me.DockPanel1_Container.Controls.Add(Me.btnVerReporte)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.cboReportes)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(1012, 54)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'cboAños
        '
        Me.cboAños.Location = New System.Drawing.Point(36, 11)
        Me.cboAños.MenuManager = Me.RibbonControl
        Me.cboAños.Name = "cboAños"
        Me.cboAños.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAños.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboAños.Size = New System.Drawing.Size(152, 20)
        Me.cboAños.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Año"
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarExcel.Appearance.Options.UseTextOptions = True
        Me.btnExportarExcel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.Location = New System.Drawing.Point(925, 14)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(83, 36)
        Me.btnExportarExcel.TabIndex = 5
        Me.btnExportarExcel.Text = "Exportar a Excel"
        '
        'btnVerReporte
        '
        Me.btnVerReporte.Location = New System.Drawing.Point(694, 8)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnVerReporte.TabIndex = 4
        Me.btnVerReporte.Text = "Ver Reporte"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(223, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Reportes"
        '
        'cboReportes
        '
        Me.cboReportes.EditValue = "Reporte Programaciones Anuales "
        Me.cboReportes.Location = New System.Drawing.Point(273, 11)
        Me.cboReportes.MenuManager = Me.RibbonControl
        Me.cboReportes.Name = "cboReportes"
        Me.cboReportes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboReportes.Properties.Items.AddRange(New Object() {"Reporte Programaciones Anuales ", "Reporte de Programaciones Cobradas por Fecha de Pago", "Reporte de Programaciones Cobradas por Fecha de Vencimiento", "Reporte de Programaciones Adeudadas por Fecha de Vencimiento", "Reporte de Saldo de Deudas por año ", "Reporte Programaciones Anuales (Todos los Años)", "Reporte de Programaciones Cobradas por Fecha de Pago (Todos los Años)"})
        Me.cboReportes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboReportes.Size = New System.Drawing.Size(407, 20)
        Me.cboReportes.TabIndex = 3
        '
        'beiprogreso
        '
        Me.beiprogreso.Caption = "BarEditItem1"
        Me.beiprogreso.Edit = Me.riprogreso
        Me.beiprogreso.Id = 4
        Me.beiprogreso.Name = "beiprogreso"
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.beiprogreso.Width = 110
        '
        'riprogreso
        '
        Me.riprogreso.Name = "riprogreso"
        '
        'frmRptPivotProPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 742)
        Me.Controls.Add(Me.pgcRecaudacion)
        Me.Controls.Add(Me.DockPanel1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmRptPivotProPagos"
        Me.Text = "PIVOTEAR PROGRAMACIÓN PAGOS"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.DockPanel1, 0)
        Me.Controls.SetChildIndex(Me.pgcRecaudacion, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcRecaudacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.cboAños.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboReportes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riprogreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pgcRecaudacion As SaimtControles.SaimtPivotGridControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents cboAños As SaimtControles.SaimtComboBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExportarExcel As SaimtControles.SaimtButton
    Friend WithEvents btnVerReporte As SaimtControles.SaimtButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboReportes As SaimtControles.SaimtComboBox
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgffechapago As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents sfdDescargar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PivotGridField17 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField18 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField19 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents beiprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents riprogreso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents PivotGridField20 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField21 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField22 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField23 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField24 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField25 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField26 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField27 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField28 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField29 As DevExpress.XtraPivotGrid.PivotGridField
End Class
