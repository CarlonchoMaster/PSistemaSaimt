﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptAsistencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptAsistencias))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.btnBuscar = New SaimtControles.SaimtButton()
        Me.btnExportar = New SaimtControles.SaimtButton()
        Me.dtpTermino = New SaimtControles.SaimtDateTimePicker()
        Me.dtpInicio = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.pgcPivotearAsistencias = New DevExpress.XtraPivotGrid.PivotGridControl()
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
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.dtpTermino.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTermino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcPivotearAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 707)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1041, 27)
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
        Me.DockPanel1.ID = New System.Guid("05e2a2f3-94cc-4401-8cf2-73eeeae051e1")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 631)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 76)
        Me.DockPanel1.Size = New System.Drawing.Size(1041, 76)
        Me.DockPanel1.Text = "Datos para el Reporte"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.btnBuscar)
        Me.DockPanel1_Container.Controls.Add(Me.btnExportar)
        Me.DockPanel1_Container.Controls.Add(Me.dtpTermino)
        Me.DockPanel1_Container.Controls.Add(Me.dtpInicio)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel2)
        Me.DockPanel1_Container.Controls.Add(Me.SaimtLabel1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(1033, 49)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(385, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(87, 30)
        Me.btnBuscar.TabIndex = 22
        Me.btnBuscar.Text = "Buscar"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Appearance.Options.UseTextOptions = True
        Me.btnExportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(950, 13)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(83, 36)
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = "Exportar a Excel"
        '
        'dtpTermino
        '
        Me.dtpTermino.EditValue = Nothing
        Me.dtpTermino.Location = New System.Drawing.Point(266, 7)
        Me.dtpTermino.MenuManager = Me.RibbonControl
        Me.dtpTermino.Name = "dtpTermino"
        Me.dtpTermino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTermino.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpTermino.Size = New System.Drawing.Size(100, 20)
        Me.dtpTermino.TabIndex = 3
        '
        'dtpInicio
        '
        Me.dtpInicio.EditValue = Nothing
        Me.dtpInicio.Location = New System.Drawing.Point(71, 7)
        Me.dtpInicio.MenuManager = Me.RibbonControl
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpInicio.Size = New System.Drawing.Size(100, 20)
        Me.dtpInicio.TabIndex = 2
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(190, 10)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(70, 13)
        Me.SaimtLabel2.TabIndex = 1
        Me.SaimtLabel2.Text = "Fecha Termino"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(6, 10)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(59, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Fecha Inicial"
        '
        'pgcPivotearAsistencias
        '
        Me.pgcPivotearAsistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcPivotearAsistencias.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField12, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15})
        Me.pgcPivotearAsistencias.Location = New System.Drawing.Point(0, 0)
        Me.pgcPivotearAsistencias.Name = "pgcPivotearAsistencias"
        Me.pgcPivotearAsistencias.Size = New System.Drawing.Size(1041, 631)
        Me.pgcPivotearAsistencias.TabIndex = 2
        '
        'PivotGridField1
        '
        Me.PivotGridField1.AreaIndex = 5
        Me.PivotGridField1.Caption = "Nro. Marcación"
        Me.PivotGridField1.FieldName = "Num_Marca"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.Caption = "Cod. Tarjeta"
        Me.PivotGridField2.FieldName = "CodTarjeta"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField3.AreaIndex = 1
        Me.PivotGridField3.Caption = "Trabajador"
        Me.PivotGridField3.FieldName = "Trabajador"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.AreaIndex = 1
        Me.PivotGridField4.Caption = "Modalidad Contrato"
        Me.PivotGridField4.FieldName = "TipoTrabajador"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.AreaIndex = 2
        Me.PivotGridField5.Caption = "Unidad Organica"
        Me.PivotGridField5.FieldName = "UnidadOrg"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField6.AreaIndex = 0
        Me.PivotGridField6.Caption = "Doc. Identidad"
        Me.PivotGridField6.FieldName = "Documento"
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField7.AreaIndex = 2
        Me.PivotGridField7.Caption = "Fecha Marcación"
        Me.PivotGridField7.CellFormat.FormatString = "d"
        Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField7.FieldName = "FechaMar"
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.ValueFormat.FormatString = "d"
        Me.PivotGridField7.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField8.AreaIndex = 3
        Me.PivotGridField8.Caption = "Hora"
        Me.PivotGridField8.FieldName = "Hora"
        Me.PivotGridField8.Name = "PivotGridField8"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.AreaIndex = 4
        Me.PivotGridField9.Caption = "Cod. Trabajador"
        Me.PivotGridField9.FieldName = "CodTrabajador"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField10.AreaIndex = 4
        Me.PivotGridField10.Caption = "Incidencia"
        Me.PivotGridField10.FieldName = "Incidencia"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField11.AreaIndex = 5
        Me.PivotGridField11.Caption = "Estado"
        Me.PivotGridField11.FieldName = "Estado"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField12.AreaIndex = 7
        Me.PivotGridField12.Caption = "Tiempo Temprano"
        Me.PivotGridField12.FieldName = "Temprano"
        Me.PivotGridField12.Name = "PivotGridField12"
        '
        'PivotGridField13
        '
        Me.PivotGridField13.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField13.AreaIndex = 6
        Me.PivotGridField13.Caption = "Tiempo Tardanza"
        Me.PivotGridField13.FieldName = "Tardanza"
        Me.PivotGridField13.Name = "PivotGridField13"
        '
        'PivotGridField14
        '
        Me.PivotGridField14.AreaIndex = 3
        Me.PivotGridField14.Caption = "Observación"
        Me.PivotGridField14.FieldName = "Obs"
        Me.PivotGridField14.Name = "PivotGridField14"
        '
        'PivotGridField15
        '
        Me.PivotGridField15.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField15.AreaIndex = 0
        Me.PivotGridField15.Caption = "Nro. Faltas"
        Me.PivotGridField15.FieldName = "NroFaltas"
        Me.PivotGridField15.Name = "PivotGridField15"
        '
        'frmRptAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 734)
        Me.Controls.Add(Me.pgcPivotearAsistencias)
        Me.Controls.Add(Me.DockPanel1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmRptAsistencias"
        Me.Text = "PIVOTEAR ASISTENCIAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.DockPanel1, 0)
        Me.Controls.SetChildIndex(Me.pgcPivotearAsistencias, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.dtpTermino.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTermino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcPivotearAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents pgcPivotearAsistencias As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents dtpTermino As SaimtControles.SaimtDateTimePicker
    Friend WithEvents dtpInicio As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents btnExportar As SaimtControles.SaimtButton
    Friend WithEvents sfdexportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnBuscar As SaimtControles.SaimtButton
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
End Class
