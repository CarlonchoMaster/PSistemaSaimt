﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProPagMant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProPagMant))
        Me.ofdimportar = New System.Windows.Forms.OpenFileDialog()
        Me.bteruta = New SaimtControles.SaimtButtonEdit()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.btnImportar = New SaimtControles.SaimtButton()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar3 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.BarEditItem4 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar4 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.beiprogress = New DevExpress.XtraBars.BarEditItem()
        Me.riprogress = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemProgressBar5 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.tlImportar = New SaimtControles.SaimtTreeList()
        Me.tlcProPaId = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcanio = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcContrato = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcPerId = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcPersona = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcContacto = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcNroCuota = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcConceptoId = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcConcepto = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcp_saimt = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcp_mpt = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcFechaVenc = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcMonto = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlctgEstadoId = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcFechaPago = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcCta_SAIMT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcCta_MPT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcMora_Cta_SAIMT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcMora_Cta_MPT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcCom_Cta_SAIMT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcCom_Cta_MPT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcTotalPagar = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.fbdexportar = New System.Windows.Forms.FolderBrowserDialog()
        Me.RepositoryItemProgressBar6 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.SaimtTabs1 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.btnExportarGrilla = New SaimtControles.SaimtButton()
        Me.sdnFechas = New SaimtControles.SaimtDateNavigator()
        Me.dgvTempProPagos = New SaimtControles.SaimtDataGrid()
        Me.gvTempProPagos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProPaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAño = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNroCuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConceptoId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colP_SAIMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colP_MPT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaVencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCTASaimt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCTAMpt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoraSaimt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoraMpt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComCtaSaimt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComCtaMpt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPagar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bteruta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riprogress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.tlImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.sdnFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTempProPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTempProPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.beiprogress)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 723)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1019, 27)
        '
        'bteruta
        '
        Me.bteruta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bteruta.Location = New System.Drawing.Point(97, 31)
        Me.bteruta.MenuManager = Me.RibbonControl
        Me.bteruta.Name = "bteruta"
        Me.bteruta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bteruta.Properties.ReadOnly = True
        Me.bteruta.Size = New System.Drawing.Size(651, 20)
        Me.bteruta.TabIndex = 1
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(9, 34)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(84, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Ruta de Archivo :"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemProgressBar1
        Me.BarEditItem1.Id = 2
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 110
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Controls.Add(Me.bteruta)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(11, 13)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(993, 60)
        Me.SaimtGroupBox1.TabIndex = 0
        Me.SaimtGroupBox1.Text = "Datos para Importación y Exportación de Pagos"
        '
        'btnexportar
        '
        Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnexportar.Location = New System.Drawing.Point(530, 626)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(75, 58)
        Me.btnexportar.TabIndex = 3
        Me.btnexportar.Text = "Exportar"
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Image = CType(resources.GetObject("btnImportar.Image"), System.Drawing.Image)
        Me.btnImportar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnImportar.Location = New System.Drawing.Point(438, 626)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 58)
        Me.btnImportar.TabIndex = 2
        Me.btnImportar.Text = "Importar"
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Caption = "BarEditItem2"
        Me.BarEditItem2.Edit = Me.RepositoryItemProgressBar2
        Me.BarEditItem2.Id = 2
        Me.BarEditItem2.Name = "BarEditItem2"
        Me.BarEditItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.BarEditItem2.Width = 110
        '
        'RepositoryItemProgressBar2
        '
        Me.RepositoryItemProgressBar2.Name = "RepositoryItemProgressBar2"
        '
        'BarEditItem3
        '
        Me.BarEditItem3.Caption = "BarEditItem3"
        Me.BarEditItem3.Edit = Me.RepositoryItemProgressBar3
        Me.BarEditItem3.Id = 2
        Me.BarEditItem3.Name = "BarEditItem3"
        '
        'RepositoryItemProgressBar3
        '
        Me.RepositoryItemProgressBar3.Name = "RepositoryItemProgressBar3"
        '
        'BarEditItem4
        '
        Me.BarEditItem4.Caption = "BarEditItem4"
        Me.BarEditItem4.Edit = Me.RepositoryItemProgressBar4
        Me.BarEditItem4.Id = 2
        Me.BarEditItem4.Name = "BarEditItem4"
        '
        'RepositoryItemProgressBar4
        '
        Me.RepositoryItemProgressBar4.Name = "RepositoryItemProgressBar4"
        '
        'beiprogress
        '
        Me.beiprogress.Caption = "BarEditItem5"
        Me.beiprogress.Edit = Me.riprogress
        Me.beiprogress.Id = 2
        Me.beiprogress.Name = "beiprogress"
        Me.beiprogress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.beiprogress.Width = 110
        '
        'riprogress
        '
        Me.riprogress.Name = "riprogress"
        Me.riprogress.PercentView = False
        Me.riprogress.Step = 1
        '
        'RepositoryItemProgressBar5
        '
        Me.RepositoryItemProgressBar5.Name = "RepositoryItemProgressBar5"
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox2.Controls.Add(Me.tlImportar)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(11, 79)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(995, 541)
        Me.SaimtGroupBox2.TabIndex = 1
        Me.SaimtGroupBox2.Text = "Visor de Datos a Importar"
        '
        'tlImportar
        '
        Me.tlImportar.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.tlcProPaId, Me.tlcanio, Me.tlcContrato, Me.tlcPerId, Me.tlcPersona, Me.tlcContacto, Me.tlcNroCuota, Me.tlcConceptoId, Me.tlcConcepto, Me.tlcp_saimt, Me.tlcp_mpt, Me.tlcFechaVenc, Me.tlcMonto, Me.tlctgEstadoId, Me.tlcFechaPago, Me.tlcCta_SAIMT, Me.tlcCta_MPT, Me.tlcMora_Cta_SAIMT, Me.tlcMora_Cta_MPT, Me.tlcCom_Cta_SAIMT, Me.tlcCom_Cta_MPT, Me.tlcTotalPagar})
        Me.tlImportar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlImportar.Location = New System.Drawing.Point(2, 21)
        Me.tlImportar.Name = "tlImportar"
        Me.tlImportar.OptionsBehavior.PopulateServiceColumns = True
        Me.tlImportar.OptionsView.AutoWidth = False
        Me.tlImportar.OptionsView.ShowRoot = False
        Me.tlImportar.Size = New System.Drawing.Size(991, 518)
        Me.tlImportar.TabIndex = 0
        '
        'tlcProPaId
        '
        Me.tlcProPaId.Caption = "ProPaId"
        Me.tlcProPaId.FieldName = "TreeListColumn1"
        Me.tlcProPaId.Name = "tlcProPaId"
        Me.tlcProPaId.OptionsColumn.ReadOnly = True
        Me.tlcProPaId.Visible = True
        Me.tlcProPaId.VisibleIndex = 0
        Me.tlcProPaId.Width = 90
        '
        'tlcanio
        '
        Me.tlcanio.Caption = "Año"
        Me.tlcanio.FieldName = "TreeListColumn2"
        Me.tlcanio.Name = "tlcanio"
        Me.tlcanio.OptionsColumn.ReadOnly = True
        Me.tlcanio.Visible = True
        Me.tlcanio.VisibleIndex = 1
        '
        'tlcContrato
        '
        Me.tlcContrato.Caption = "Contrato"
        Me.tlcContrato.FieldName = "TreeListColumn3"
        Me.tlcContrato.Name = "tlcContrato"
        Me.tlcContrato.OptionsColumn.ReadOnly = True
        Me.tlcContrato.Visible = True
        Me.tlcContrato.VisibleIndex = 2
        Me.tlcContrato.Width = 90
        '
        'tlcPerId
        '
        Me.tlcPerId.Caption = "PerId"
        Me.tlcPerId.FieldName = "TreeListColumn4"
        Me.tlcPerId.Name = "tlcPerId"
        Me.tlcPerId.OptionsColumn.ReadOnly = True
        Me.tlcPerId.Visible = True
        Me.tlcPerId.VisibleIndex = 3
        Me.tlcPerId.Width = 90
        '
        'tlcPersona
        '
        Me.tlcPersona.Caption = "Persona"
        Me.tlcPersona.FieldName = "Persona"
        Me.tlcPersona.Name = "tlcPersona"
        Me.tlcPersona.OptionsColumn.ReadOnly = True
        Me.tlcPersona.Visible = True
        Me.tlcPersona.VisibleIndex = 4
        Me.tlcPersona.Width = 90
        '
        'tlcContacto
        '
        Me.tlcContacto.Caption = "Contacto"
        Me.tlcContacto.FieldName = "Contacto"
        Me.tlcContacto.Name = "tlcContacto"
        Me.tlcContacto.OptionsColumn.ReadOnly = True
        Me.tlcContacto.Visible = True
        Me.tlcContacto.VisibleIndex = 5
        Me.tlcContacto.Width = 90
        '
        'tlcNroCuota
        '
        Me.tlcNroCuota.Caption = "NroCuota"
        Me.tlcNroCuota.FieldName = "NroCuota"
        Me.tlcNroCuota.Name = "tlcNroCuota"
        Me.tlcNroCuota.OptionsColumn.ReadOnly = True
        Me.tlcNroCuota.Visible = True
        Me.tlcNroCuota.VisibleIndex = 6
        Me.tlcNroCuota.Width = 90
        '
        'tlcConceptoId
        '
        Me.tlcConceptoId.Caption = "ConceptoId"
        Me.tlcConceptoId.FieldName = "ConceptoId"
        Me.tlcConceptoId.Name = "tlcConceptoId"
        Me.tlcConceptoId.OptionsColumn.ReadOnly = True
        Me.tlcConceptoId.Visible = True
        Me.tlcConceptoId.VisibleIndex = 7
        Me.tlcConceptoId.Width = 90
        '
        'tlcConcepto
        '
        Me.tlcConcepto.Caption = "Concepto"
        Me.tlcConcepto.FieldName = "Concepto"
        Me.tlcConcepto.Name = "tlcConcepto"
        Me.tlcConcepto.OptionsColumn.ReadOnly = True
        Me.tlcConcepto.Visible = True
        Me.tlcConcepto.VisibleIndex = 8
        Me.tlcConcepto.Width = 90
        '
        'tlcp_saimt
        '
        Me.tlcp_saimt.Caption = "P_SAIMT"
        Me.tlcp_saimt.FieldName = "P_SAIMT"
        Me.tlcp_saimt.Name = "tlcp_saimt"
        Me.tlcp_saimt.OptionsColumn.ReadOnly = True
        Me.tlcp_saimt.Visible = True
        Me.tlcp_saimt.VisibleIndex = 9
        Me.tlcp_saimt.Width = 90
        '
        'tlcp_mpt
        '
        Me.tlcp_mpt.Caption = "P_MPT"
        Me.tlcp_mpt.FieldName = "P_MPT"
        Me.tlcp_mpt.Name = "tlcp_mpt"
        Me.tlcp_mpt.OptionsColumn.ReadOnly = True
        Me.tlcp_mpt.Visible = True
        Me.tlcp_mpt.VisibleIndex = 10
        Me.tlcp_mpt.Width = 90
        '
        'tlcFechaVenc
        '
        Me.tlcFechaVenc.Caption = "FechaVenc"
        Me.tlcFechaVenc.FieldName = "FechaVenc"
        Me.tlcFechaVenc.Name = "tlcFechaVenc"
        Me.tlcFechaVenc.OptionsColumn.ReadOnly = True
        Me.tlcFechaVenc.Visible = True
        Me.tlcFechaVenc.VisibleIndex = 11
        Me.tlcFechaVenc.Width = 90
        '
        'tlcMonto
        '
        Me.tlcMonto.Caption = "Monto"
        Me.tlcMonto.FieldName = "Monto"
        Me.tlcMonto.Name = "tlcMonto"
        Me.tlcMonto.OptionsColumn.ReadOnly = True
        Me.tlcMonto.Visible = True
        Me.tlcMonto.VisibleIndex = 12
        Me.tlcMonto.Width = 90
        '
        'tlctgEstadoId
        '
        Me.tlctgEstadoId.Caption = "tgEstadoId"
        Me.tlctgEstadoId.FieldName = "tgEstadoId"
        Me.tlctgEstadoId.Name = "tlctgEstadoId"
        Me.tlctgEstadoId.OptionsColumn.ReadOnly = True
        Me.tlctgEstadoId.Visible = True
        Me.tlctgEstadoId.VisibleIndex = 13
        '
        'tlcFechaPago
        '
        Me.tlcFechaPago.Caption = "FechaPago"
        Me.tlcFechaPago.FieldName = "FechaPago"
        Me.tlcFechaPago.Name = "tlcFechaPago"
        Me.tlcFechaPago.OptionsColumn.ReadOnly = True
        Me.tlcFechaPago.Visible = True
        Me.tlcFechaPago.VisibleIndex = 14
        Me.tlcFechaPago.Width = 90
        '
        'tlcCta_SAIMT
        '
        Me.tlcCta_SAIMT.Caption = "Cta_SAIMT"
        Me.tlcCta_SAIMT.FieldName = "Cta_SAIMT"
        Me.tlcCta_SAIMT.Name = "tlcCta_SAIMT"
        Me.tlcCta_SAIMT.OptionsColumn.ReadOnly = True
        Me.tlcCta_SAIMT.Visible = True
        Me.tlcCta_SAIMT.VisibleIndex = 15
        Me.tlcCta_SAIMT.Width = 90
        '
        'tlcCta_MPT
        '
        Me.tlcCta_MPT.Caption = "Cta_MPT"
        Me.tlcCta_MPT.FieldName = "Cta_MPT"
        Me.tlcCta_MPT.Name = "tlcCta_MPT"
        Me.tlcCta_MPT.OptionsColumn.ReadOnly = True
        Me.tlcCta_MPT.Visible = True
        Me.tlcCta_MPT.VisibleIndex = 16
        Me.tlcCta_MPT.Width = 90
        '
        'tlcMora_Cta_SAIMT
        '
        Me.tlcMora_Cta_SAIMT.Caption = "Mora_Cta_SAIMT"
        Me.tlcMora_Cta_SAIMT.FieldName = "Mora_Cta_SAIMT"
        Me.tlcMora_Cta_SAIMT.Name = "tlcMora_Cta_SAIMT"
        Me.tlcMora_Cta_SAIMT.OptionsColumn.ReadOnly = True
        Me.tlcMora_Cta_SAIMT.Visible = True
        Me.tlcMora_Cta_SAIMT.VisibleIndex = 17
        '
        'tlcMora_Cta_MPT
        '
        Me.tlcMora_Cta_MPT.Caption = "Mora_Cta_MPT"
        Me.tlcMora_Cta_MPT.FieldName = "Mora_Cta_MPT"
        Me.tlcMora_Cta_MPT.Name = "tlcMora_Cta_MPT"
        Me.tlcMora_Cta_MPT.OptionsColumn.ReadOnly = True
        Me.tlcMora_Cta_MPT.Visible = True
        Me.tlcMora_Cta_MPT.VisibleIndex = 18
        '
        'tlcCom_Cta_SAIMT
        '
        Me.tlcCom_Cta_SAIMT.Caption = "Com_Cta_SAIMT"
        Me.tlcCom_Cta_SAIMT.FieldName = "Com_Cta_SAIMT"
        Me.tlcCom_Cta_SAIMT.Name = "tlcCom_Cta_SAIMT"
        Me.tlcCom_Cta_SAIMT.OptionsColumn.ReadOnly = True
        Me.tlcCom_Cta_SAIMT.Visible = True
        Me.tlcCom_Cta_SAIMT.VisibleIndex = 19
        '
        'tlcCom_Cta_MPT
        '
        Me.tlcCom_Cta_MPT.Caption = "Com_Cta_MPT"
        Me.tlcCom_Cta_MPT.FieldName = "Com_Cta_MPT"
        Me.tlcCom_Cta_MPT.Name = "tlcCom_Cta_MPT"
        Me.tlcCom_Cta_MPT.OptionsColumn.ReadOnly = True
        Me.tlcCom_Cta_MPT.Visible = True
        Me.tlcCom_Cta_MPT.VisibleIndex = 20
        '
        'tlcTotalPagar
        '
        Me.tlcTotalPagar.Caption = "TotalPagar"
        Me.tlcTotalPagar.FieldName = "TotalPagar"
        Me.tlcTotalPagar.Name = "tlcTotalPagar"
        Me.tlcTotalPagar.OptionsColumn.ReadOnly = True
        Me.tlcTotalPagar.Visible = True
        Me.tlcTotalPagar.VisibleIndex = 21
        '
        'RepositoryItemProgressBar6
        '
        Me.RepositoryItemProgressBar6.Name = "RepositoryItemProgressBar6"
        '
        'SaimtTabs1
        '
        Me.SaimtTabs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtTabs1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtTabs1.Name = "SaimtTabs1"
        Me.SaimtTabs1.SelectedTabPage = Me.XtraTabPage1
        Me.SaimtTabs1.Size = New System.Drawing.Size(1019, 723)
        Me.SaimtTabs1.TabIndex = 0
        Me.SaimtTabs1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnexportar)
        Me.XtraTabPage1.Controls.Add(Me.SaimtGroupBox1)
        Me.XtraTabPage1.Controls.Add(Me.btnImportar)
        Me.XtraTabPage1.Controls.Add(Me.SaimtGroupBox2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1013, 695)
        Me.XtraTabPage1.Text = "Importación de Datos"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LayoutControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1013, 695)
        Me.XtraTabPage2.Text = "Mostrar Datos Importados"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SaimtGroupBox3)
        Me.LayoutControl1.Controls.Add(Me.sdnFechas)
        Me.LayoutControl1.Controls.Add(Me.dgvTempProPagos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(811, 496, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1013, 699)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Controls.Add(Me.btnExportarGrilla)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(768, 533)
        Me.SaimtGroupBox3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(233, 154)
        Me.SaimtGroupBox3.TabIndex = 0
        Me.SaimtGroupBox3.Text = "Opciones"
        '
        'btnExportarGrilla
        '
        Me.btnExportarGrilla.Appearance.Options.UseTextOptions = True
        Me.btnExportarGrilla.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportarGrilla.Image = CType(resources.GetObject("btnExportarGrilla.Image"), System.Drawing.Image)
        Me.btnExportarGrilla.Location = New System.Drawing.Point(67, 60)
        Me.btnExportarGrilla.Name = "btnExportarGrilla"
        Me.btnExportarGrilla.Size = New System.Drawing.Size(108, 40)
        Me.btnExportarGrilla.TabIndex = 0
        Me.btnExportarGrilla.Text = "Exportar Grilla"
        '
        'sdnFechas
        '
        Me.sdnFechas.DateTime = New Date(2012, 1, 10, 0, 0, 0, 0)
        Me.sdnFechas.HotDate = Nothing
        Me.sdnFechas.Location = New System.Drawing.Point(12, 533)
        Me.sdnFechas.Multiselect = False
        Me.sdnFechas.Name = "sdnFechas"
        Me.sdnFechas.Size = New System.Drawing.Size(752, 154)
        Me.sdnFechas.TabIndex = 0
        '
        'dgvTempProPagos
        '
        Me.dgvTempProPagos.Location = New System.Drawing.Point(12, 12)
        Me.dgvTempProPagos.MainView = Me.gvTempProPagos
        Me.dgvTempProPagos.MenuManager = Me.RibbonControl
        Me.dgvTempProPagos.Name = "dgvTempProPagos"
        Me.dgvTempProPagos.Size = New System.Drawing.Size(989, 512)
        Me.dgvTempProPagos.TabIndex = 0
        Me.dgvTempProPagos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTempProPagos})
        '
        'gvTempProPagos
        '
        Me.gvTempProPagos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProPaId, Me.colAño, Me.colContrato, Me.colPerId, Me.colPersona, Me.colContacto, Me.colNroCuota, Me.colConceptoId, Me.colConcepto, Me.colP_SAIMT, Me.colP_MPT, Me.colFechaVencimiento, Me.colMonto, Me.colEstado, Me.colFechaPago, Me.colCTASaimt, Me.colCTAMpt, Me.colMoraSaimt, Me.colMoraMpt, Me.colComCtaSaimt, Me.colComCtaMpt, Me.colTotalPagar})
        Me.gvTempProPagos.GridControl = Me.dgvTempProPagos
        Me.gvTempProPagos.Name = "gvTempProPagos"
        Me.gvTempProPagos.OptionsBehavior.ReadOnly = True
        Me.gvTempProPagos.OptionsView.ColumnAutoWidth = False
        Me.gvTempProPagos.OptionsView.ShowGroupPanel = False
        '
        'colProPaId
        '
        Me.colProPaId.Caption = "ProPaId"
        Me.colProPaId.FieldName = "proPaId"
        Me.colProPaId.Name = "colProPaId"
        Me.colProPaId.Visible = True
        Me.colProPaId.VisibleIndex = 0
        '
        'colAño
        '
        Me.colAño.Caption = "Año"
        Me.colAño.FieldName = "año"
        Me.colAño.Name = "colAño"
        Me.colAño.Visible = True
        Me.colAño.VisibleIndex = 1
        '
        'colContrato
        '
        Me.colContrato.Caption = "Cod. Contrato"
        Me.colContrato.FieldName = "codContrato"
        Me.colContrato.Name = "colContrato"
        Me.colContrato.Visible = True
        Me.colContrato.VisibleIndex = 2
        '
        'colPerId
        '
        Me.colPerId.Caption = "Cod. Persona"
        Me.colPerId.FieldName = "codPersona"
        Me.colPerId.Name = "colPerId"
        Me.colPerId.Visible = True
        Me.colPerId.VisibleIndex = 3
        '
        'colPersona
        '
        Me.colPersona.Caption = "Persona"
        Me.colPersona.FieldName = "persona"
        Me.colPersona.Name = "colPersona"
        Me.colPersona.Visible = True
        Me.colPersona.VisibleIndex = 4
        '
        'colContacto
        '
        Me.colContacto.Caption = "Contacto"
        Me.colContacto.FieldName = "contacto"
        Me.colContacto.Name = "colContacto"
        Me.colContacto.Visible = True
        Me.colContacto.VisibleIndex = 5
        '
        'colNroCuota
        '
        Me.colNroCuota.Caption = "Nro. Cuota"
        Me.colNroCuota.FieldName = "nroCuota"
        Me.colNroCuota.Name = "colNroCuota"
        Me.colNroCuota.Visible = True
        Me.colNroCuota.VisibleIndex = 6
        '
        'colConceptoId
        '
        Me.colConceptoId.Caption = "Cod. Concepto"
        Me.colConceptoId.FieldName = "codConcepto"
        Me.colConceptoId.Name = "colConceptoId"
        Me.colConceptoId.Visible = True
        Me.colConceptoId.VisibleIndex = 7
        '
        'colConcepto
        '
        Me.colConcepto.Caption = "Concepto"
        Me.colConcepto.FieldName = "concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 8
        '
        'colP_SAIMT
        '
        Me.colP_SAIMT.Caption = "P_SAIMT"
        Me.colP_SAIMT.FieldName = "p_saimt"
        Me.colP_SAIMT.Name = "colP_SAIMT"
        Me.colP_SAIMT.Visible = True
        Me.colP_SAIMT.VisibleIndex = 9
        '
        'colP_MPT
        '
        Me.colP_MPT.Caption = "P_MPT"
        Me.colP_MPT.FieldName = "p_mpt"
        Me.colP_MPT.Name = "colP_MPT"
        Me.colP_MPT.Visible = True
        Me.colP_MPT.VisibleIndex = 10
        '
        'colFechaVencimiento
        '
        Me.colFechaVencimiento.Caption = "F. Vencimiento"
        Me.colFechaVencimiento.FieldName = "fechaVencimiento"
        Me.colFechaVencimiento.Name = "colFechaVencimiento"
        Me.colFechaVencimiento.Visible = True
        Me.colFechaVencimiento.VisibleIndex = 11
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto"
        Me.colMonto.FieldName = "monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Visible = True
        Me.colMonto.VisibleIndex = 12
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 13
        '
        'colFechaPago
        '
        Me.colFechaPago.Caption = "F. Pago"
        Me.colFechaPago.FieldName = "fechaPago"
        Me.colFechaPago.Name = "colFechaPago"
        Me.colFechaPago.Visible = True
        Me.colFechaPago.VisibleIndex = 14
        '
        'colCTASaimt
        '
        Me.colCTASaimt.Caption = "CTA Saimt"
        Me.colCTASaimt.FieldName = "cta_saimt"
        Me.colCTASaimt.Name = "colCTASaimt"
        Me.colCTASaimt.Visible = True
        Me.colCTASaimt.VisibleIndex = 15
        '
        'colCTAMpt
        '
        Me.colCTAMpt.Caption = "CTA MPT"
        Me.colCTAMpt.FieldName = "cta_mpt"
        Me.colCTAMpt.Name = "colCTAMpt"
        Me.colCTAMpt.Visible = True
        Me.colCTAMpt.VisibleIndex = 16
        '
        'colMoraSaimt
        '
        Me.colMoraSaimt.Caption = "Mora Saimt"
        Me.colMoraSaimt.FieldName = "moraSaimt"
        Me.colMoraSaimt.Name = "colMoraSaimt"
        Me.colMoraSaimt.Visible = True
        Me.colMoraSaimt.VisibleIndex = 17
        '
        'colMoraMpt
        '
        Me.colMoraMpt.Caption = "Mora MPT"
        Me.colMoraMpt.FieldName = "moraMpt"
        Me.colMoraMpt.Name = "colMoraMpt"
        Me.colMoraMpt.Visible = True
        Me.colMoraMpt.VisibleIndex = 18
        '
        'colComCtaSaimt
        '
        Me.colComCtaSaimt.Caption = "Com_Cta_Saimt"
        Me.colComCtaSaimt.FieldName = "com_cta_saimt"
        Me.colComCtaSaimt.Name = "colComCtaSaimt"
        Me.colComCtaSaimt.Visible = True
        Me.colComCtaSaimt.VisibleIndex = 19
        '
        'colComCtaMpt
        '
        Me.colComCtaMpt.Caption = "Com_Cta_Mpt"
        Me.colComCtaMpt.FieldName = "com_cta_mpt"
        Me.colComCtaMpt.Name = "colComCtaMpt"
        Me.colComCtaMpt.Visible = True
        Me.colComCtaMpt.VisibleIndex = 20
        '
        'colTotalPagar
        '
        Me.colTotalPagar.Caption = "Total Pagar"
        Me.colTotalPagar.FieldName = "totalPagar"
        Me.colTotalPagar.Name = "colTotalPagar"
        Me.colTotalPagar.Visible = True
        Me.colTotalPagar.VisibleIndex = 21
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.SplitterItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1013, 699)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgvTempProPagos
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(993, 516)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(0, 516)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(993, 5)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.sdnFechas
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 521)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(756, 158)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SaimtGroupBox3
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(756, 521)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(237, 158)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'frmProPagMant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 750)
        Me.Controls.Add(Me.SaimtTabs1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmProPagMant"
        Me.Tag = "btiProgPagIE"
        Me.Text = "Importación y Exportación de Programación de Pagos Fincas"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtTabs1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bteruta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riprogress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        CType(Me.tlImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        CType(Me.sdnFechas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTempProPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTempProPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdimportar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bteruta As SaimtControles.SaimtButtonEdit
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents btnImportar As SaimtControles.SaimtButton
    Friend WithEvents sfdexportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar3 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents BarEditItem4 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar4 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents beiprogress As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar5 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents tlImportar As SaimtControles.SaimtTreeList
    Friend WithEvents tlcProPaId As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcanio As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcContrato As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcPerId As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcPersona As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcContacto As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcNroCuota As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcConceptoId As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcConcepto As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcp_saimt As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcp_mpt As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcFechaVenc As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcMonto As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlctgEstadoId As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcFechaPago As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcCta_SAIMT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcCta_MPT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcMora_Cta_SAIMT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcMora_Cta_MPT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcCom_Cta_SAIMT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcCom_Cta_MPT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcTotalPagar As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents riprogress As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents fbdexportar As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents RepositoryItemProgressBar6 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents SaimtTabs1 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dgvTempProPagos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvTempProPagos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents btnExportarGrilla As SaimtControles.SaimtButton
    Friend WithEvents sdnFechas As SaimtControles.SaimtDateNavigator
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colProPaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAño As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNroCuota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConceptoId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colP_SAIMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colP_MPT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCTASaimt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCTAMpt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoraSaimt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoraMpt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComCtaSaimt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComCtaMpt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPagar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContacto As DevExpress.XtraGrid.Columns.GridColumn
End Class
