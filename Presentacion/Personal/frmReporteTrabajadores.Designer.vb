<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteTrabajadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteTrabajadores))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.btnExportarExcel = New SaimtControles.SaimtButton()
        Me.btnMostrarDatos = New SaimtControles.SaimtButton()
        Me.pgcTrabajador = New DevExpress.XtraPivotGrid.PivotGridControl()
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
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField18 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField19 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField20 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField21 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField22 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField23 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.beiprogreso = New DevExpress.XtraBars.BarEditItem()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.pgcTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 707)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(887, 27)
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
        Me.DockPanel1.ID = New System.Guid("973f24ed-c54c-417b-a286-815fc75151a4")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 613)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 94)
        Me.DockPanel1.Size = New System.Drawing.Size(887, 94)
        Me.DockPanel1.Text = "Parametros para el Reporte"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.btnExportarExcel)
        Me.DockPanel1_Container.Controls.Add(Me.btnMostrarDatos)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(879, 67)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarExcel.Appearance.Options.UseTextOptions = True
        Me.btnExportarExcel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.Location = New System.Drawing.Point(772, 17)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(100, 44)
        Me.btnExportarExcel.TabIndex = 1
        Me.btnExportarExcel.Text = "Exportar a Excel"
        '
        'btnMostrarDatos
        '
        Me.btnMostrarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMostrarDatos.Appearance.Options.UseTextOptions = True
        Me.btnMostrarDatos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnMostrarDatos.Image = CType(resources.GetObject("btnMostrarDatos.Image"), System.Drawing.Image)
        Me.btnMostrarDatos.Location = New System.Drawing.Point(666, 17)
        Me.btnMostrarDatos.Name = "btnMostrarDatos"
        Me.btnMostrarDatos.Size = New System.Drawing.Size(100, 44)
        Me.btnMostrarDatos.TabIndex = 0
        Me.btnMostrarDatos.Text = "Mostras Datos"
        '
        'pgcTrabajador
        '
        Me.pgcTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcTrabajador.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField12, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16, Me.PivotGridField17, Me.PivotGridField18, Me.PivotGridField19, Me.PivotGridField20, Me.PivotGridField21, Me.PivotGridField22, Me.PivotGridField23})
        Me.pgcTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.pgcTrabajador.Name = "pgcTrabajador"
        Me.pgcTrabajador.Size = New System.Drawing.Size(887, 613)
        Me.pgcTrabajador.TabIndex = 2
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Tipo Doc."
        Me.PivotGridField1.FieldName = "tgTipoDoc"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.Caption = "Nro. Doc."
        Me.PivotGridField2.FieldName = "perNDoc"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField3.AreaIndex = 2
        Me.PivotGridField3.Caption = "Trabajador"
        Me.PivotGridField3.FieldName = "Persona"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.AreaIndex = 0
        Me.PivotGridField4.Caption = "Sexo"
        Me.PivotGridField4.FieldName = "tgGenero"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.AreaIndex = 2
        Me.PivotGridField5.Caption = "Fecha de Nacimiento"
        Me.PivotGridField5.FieldName = "perFechaNac"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField6.AreaIndex = 3
        Me.PivotGridField6.Caption = "Sucursal"
        Me.PivotGridField6.FieldName = "Sucursal"
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.AreaIndex = 3
        Me.PivotGridField7.Caption = "Departamento"
        Me.PivotGridField7.FieldName = "PerDepartamento"
        Me.PivotGridField7.Name = "PivotGridField7"
        '
        'PivotGridField8
        '
        Me.PivotGridField8.AreaIndex = 4
        Me.PivotGridField8.Caption = "Provincia"
        Me.PivotGridField8.FieldName = "PerProvincia"
        Me.PivotGridField8.Name = "PivotGridField8"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.AreaIndex = 5
        Me.PivotGridField9.Caption = "Distrito"
        Me.PivotGridField9.FieldName = "PerDistrito"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.AreaIndex = 6
        Me.PivotGridField10.Caption = "Fecha Inicio Contrato"
        Me.PivotGridField10.FieldName = "conTrabFecInicio"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.AreaIndex = 7
        Me.PivotGridField11.Caption = "Nivel de Estudio"
        Me.PivotGridField11.FieldName = "tgNivEdu"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField12.AreaIndex = 4
        Me.PivotGridField12.Caption = "Formación/Profesión "
        Me.PivotGridField12.FieldName = "tgForProf"
        Me.PivotGridField12.Name = "PivotGridField12"
        '
        'PivotGridField13
        '
        Me.PivotGridField13.AreaIndex = 8
        Me.PivotGridField13.Caption = "Régimen Laboral/Contractual"
        Me.PivotGridField13.FieldName = "tgTipoCon"
        Me.PivotGridField13.Name = "PivotGridField13"
        '
        'PivotGridField14
        '
        Me.PivotGridField14.AreaIndex = 9
        Me.PivotGridField14.Caption = "Grupo Ocupacional"
        Me.PivotGridField14.FieldName = "tgGradoOcu"
        Me.PivotGridField14.Name = "PivotGridField14"
        '
        'PivotGridField15
        '
        Me.PivotGridField15.AreaIndex = 10
        Me.PivotGridField15.Caption = " Nivel  Remunerativo"
        Me.PivotGridField15.FieldName = "tgNivRemn"
        Me.PivotGridField15.Name = "PivotGridField15"
        '
        'PivotGridField16
        '
        Me.PivotGridField16.AreaIndex = 11
        Me.PivotGridField16.Caption = "Remuneración"
        Me.PivotGridField16.FieldName = "conTrabMonto"
        Me.PivotGridField16.Name = "PivotGridField16"
        '
        'PivotGridField17
        '
        Me.PivotGridField17.AreaIndex = 12
        Me.PivotGridField17.Caption = "Domicilio"
        Me.PivotGridField17.FieldName = "perDireccion"
        Me.PivotGridField17.Name = "PivotGridField17"
        '
        'PivotGridField18
        '
        Me.PivotGridField18.AreaIndex = 1
        Me.PivotGridField18.Caption = "Fecha Fin Contrato"
        Me.PivotGridField18.FieldName = "conTrabFecFin"
        Me.PivotGridField18.Name = "PivotGridField18"
        '
        'PivotGridField19
        '
        Me.PivotGridField19.AreaIndex = 13
        Me.PivotGridField19.Caption = "RUC"
        Me.PivotGridField19.FieldName = "perRuc"
        Me.PivotGridField19.Name = "PivotGridField19"
        '
        'PivotGridField20
        '
        Me.PivotGridField20.AreaIndex = 14
        Me.PivotGridField20.Caption = "Sistema de Pensiones"
        Me.PivotGridField20.FieldName = "tgAFP"
        Me.PivotGridField20.Name = "PivotGridField20"
        '
        'PivotGridField21
        '
        Me.PivotGridField21.AreaIndex = 15
        Me.PivotGridField21.Caption = "Cuenta Bancaria"
        Me.PivotGridField21.FieldName = "ConTrabNroCuenta"
        Me.PivotGridField21.Name = "PivotGridField21"
        '
        'PivotGridField22
        '
        Me.PivotGridField22.AreaIndex = 16
        Me.PivotGridField22.Caption = "Banco"
        Me.PivotGridField22.FieldName = "tgBanco"
        Me.PivotGridField22.Name = "PivotGridField22"
        '
        'PivotGridField23
        '
        Me.PivotGridField23.AreaIndex = 17
        Me.PivotGridField23.Caption = "Modalidad"
        Me.PivotGridField23.FieldName = "tgTipoCon"
        Me.PivotGridField23.Name = "PivotGridField23"
        '
        'beiprogreso
        '
        Me.beiprogreso.Caption = "BarEditItem1"
        Me.beiprogreso.Edit = Nothing
        Me.beiprogreso.Id = 4
        Me.beiprogreso.Name = "beiprogreso"
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.beiprogreso.Width = 110
        '
        'frmReporteTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 734)
        Me.Controls.Add(Me.pgcTrabajador)
        Me.Controls.Add(Me.DockPanel1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmReporteTrabajadores"
        Me.Text = "frmReporteTrabajadores"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.DockPanel1, 0)
        Me.Controls.SetChildIndex(Me.pgcTrabajador, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.pgcTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents pgcTrabajador As DevExpress.XtraPivotGrid.PivotGridControl
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
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField17 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField18 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField19 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField20 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField21 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField22 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportarExcel As SaimtControles.SaimtButton
    Friend WithEvents btnMostrarDatos As SaimtControles.SaimtButton
    Friend WithEvents beiprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents PivotGridField23 As DevExpress.XtraPivotGrid.PivotGridField
End Class
