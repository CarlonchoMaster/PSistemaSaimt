<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarRecSatt
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportarRecSatt))
        Me.dgvRecaudacionDet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcdconId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdconcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdmontodep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdporsaimt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdingsaimt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdrecid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdRecFecPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdTgRecaudadorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgvResultado = New SaimtControles.SaimtDataGrid()
        Me.dgvMostrarRecaudacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcRecId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRecFecPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRecNroOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcConId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRecNro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTgNombreTipoDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPerNroDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPerNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRecMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcConPorcentaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRecTotalIng = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRecVComision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRecComision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRecNeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRecFechaReg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUsuId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTgNombreRecaudador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTgRecaudadorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcconcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTgTipoDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.rblrecaudador = New SaimtControles.SaimtRadioGroup()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.btnAgregar = New SaimtControles.SaimtButton()
        Me.btndetalle = New SaimtControles.SaimtButton()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.lblmRecaudador = New SaimtControles.SaimtLabel()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.lblMFecha = New SaimtControles.SaimtLabel()
        Me.lblFecha = New SaimtControles.SaimtLabel()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.DateNImp = New SaimtControles.SaimtDateNavigator()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.TxtTotalIngreso = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem3 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem4 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem5 = New DevExpress.XtraLayout.SplitterItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.rbRecaudador = New SaimtControles.SaimtRadioGroup()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.btnimportar = New SaimtControles.SaimtButton()
        Me.btnImpArchivo = New SaimtControles.SaimtButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.tlImportar = New SaimtControles.SaimtTreeList()
        Me.tlc1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc7 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc8 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc9 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc10 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc11 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlc12 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem2 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.ofdimportar = New System.Windows.Forms.OpenFileDialog()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.beiprogreso = New DevExpress.XtraBars.BarEditItem()
        Me.ripprogreso = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecaudacionDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMostrarRecaudacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.rblrecaudador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.DateNImp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotalIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.rbRecaudador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.btnImpArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tlImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ripprogreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.beiprogreso)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 728)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1004, 27)
        '
        'dgvRecaudacionDet
        '
        Me.dgvRecaudacionDet.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dgvRecaudacionDet.Appearance.FooterPanel.Options.UseFont = True
        Me.dgvRecaudacionDet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcdconId, Me.gcdconcepto, Me.gcdmontodep, Me.gcdporsaimt, Me.gcdingsaimt, Me.gcdrecid, Me.gcdRecFecPago, Me.gcdTgRecaudadorId, Me.GridColumn7})
        Me.dgvRecaudacionDet.GridControl = Me.dgvResultado
        Me.dgvRecaudacionDet.Name = "dgvRecaudacionDet"
        Me.dgvRecaudacionDet.OptionsDetail.ShowDetailTabs = False
        Me.dgvRecaudacionDet.OptionsPrint.AutoWidth = False
        Me.dgvRecaudacionDet.OptionsView.ColumnAutoWidth = False
        Me.dgvRecaudacionDet.OptionsView.ShowFooter = True
        Me.dgvRecaudacionDet.OptionsView.ShowGroupPanel = False
        '
        'gcdconId
        '
        Me.gcdconId.Caption = "ID Concepto"
        Me.gcdconId.FieldName = "conid"
        Me.gcdconId.Name = "gcdconId"
        Me.gcdconId.Visible = True
        Me.gcdconId.VisibleIndex = 0
        '
        'gcdconcepto
        '
        Me.gcdconcepto.Caption = "Concepto"
        Me.gcdconcepto.FieldName = "concepto"
        Me.gcdconcepto.Name = "gcdconcepto"
        Me.gcdconcepto.Visible = True
        Me.gcdconcepto.VisibleIndex = 1
        '
        'gcdmontodep
        '
        Me.gcdmontodep.Caption = "Monto Depositado"
        Me.gcdmontodep.DisplayFormat.FormatString = "#,##0.00"
        Me.gcdmontodep.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcdmontodep.FieldName = "montodep"
        Me.gcdmontodep.Name = "gcdmontodep"
        Me.gcdmontodep.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "montodep", "Total : {0:###,##0.00}")})
        Me.gcdmontodep.Visible = True
        Me.gcdmontodep.VisibleIndex = 2
        '
        'gcdporsaimt
        '
        Me.gcdporsaimt.Caption = "% Saimt"
        Me.gcdporsaimt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcdporsaimt.FieldName = "porsaimt"
        Me.gcdporsaimt.Name = "gcdporsaimt"
        Me.gcdporsaimt.Visible = True
        Me.gcdporsaimt.VisibleIndex = 3
        '
        'gcdingsaimt
        '
        Me.gcdingsaimt.Caption = "Ing. Saimt"
        Me.gcdingsaimt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcdingsaimt.FieldName = "ingsaimt"
        Me.gcdingsaimt.Name = "gcdingsaimt"
        Me.gcdingsaimt.Visible = True
        Me.gcdingsaimt.VisibleIndex = 4
        '
        'gcdrecid
        '
        Me.gcdrecid.Caption = "Rec Id"
        Me.gcdrecid.FieldName = "RecId"
        Me.gcdrecid.Name = "gcdrecid"
        Me.gcdrecid.Visible = True
        Me.gcdrecid.VisibleIndex = 5
        '
        'gcdRecFecPago
        '
        Me.gcdRecFecPago.Caption = "Fecha Pago"
        Me.gcdRecFecPago.FieldName = "RecFecPago"
        Me.gcdRecFecPago.Name = "gcdRecFecPago"
        Me.gcdRecFecPago.Visible = True
        Me.gcdRecFecPago.VisibleIndex = 6
        '
        'gcdTgRecaudadorId
        '
        Me.gcdTgRecaudadorId.Caption = "RecaudadorId"
        Me.gcdTgRecaudadorId.FieldName = "TgRecaudadorId"
        Me.gcdTgRecaudadorId.Name = "gcdTgRecaudadorId"
        Me.gcdTgRecaudadorId.Visible = True
        Me.gcdTgRecaudadorId.VisibleIndex = 7
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha Liquidación X Concepto"
        Me.GridColumn7.FieldName = "FechaLiq"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        '
        'dgvResultado
        '
        GridLevelNode1.LevelTemplate = Me.dgvRecaudacionDet
        GridLevelNode1.RelationName = "RecaudacionDet"
        Me.dgvResultado.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgvResultado.Location = New System.Drawing.Point(12, 62)
        Me.dgvResultado.MainView = Me.dgvMostrarRecaudacion
        Me.dgvResultado.MenuManager = Me.RibbonControl
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.Size = New System.Drawing.Size(974, 445)
        Me.dgvResultado.TabIndex = 0
        Me.dgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvMostrarRecaudacion, Me.dgvRecaudacionDet})
        '
        'dgvMostrarRecaudacion
        '
        Me.dgvMostrarRecaudacion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcRecId, Me.gcRecFecPago, Me.gcRecNroOrden, Me.gcConId, Me.gcRecNro, Me.gcTgNombreTipoDoc, Me.gcPerNroDoc, Me.gcPerNombre, Me.gcRecMonto, Me.gcConPorcentaje, Me.gcRecTotalIng, Me.gcRecVComision, Me.gcRecComision, Me.gcRecNeto, Me.gcRecFechaReg, Me.gcUsuId, Me.gcTgNombreRecaudador, Me.gcTgRecaudadorId, Me.gcconcepto, Me.gcTgTipoDoc, Me.GridColumn6})
        Me.dgvMostrarRecaudacion.GridControl = Me.dgvResultado
        Me.dgvMostrarRecaudacion.Name = "dgvMostrarRecaudacion"
        Me.dgvMostrarRecaudacion.OptionsBehavior.ReadOnly = True
        Me.dgvMostrarRecaudacion.OptionsDetail.ShowDetailTabs = False
        Me.dgvMostrarRecaudacion.OptionsPrint.AutoWidth = False
        Me.dgvMostrarRecaudacion.OptionsPrint.PrintDetails = True
        Me.dgvMostrarRecaudacion.OptionsView.ColumnAutoWidth = False
        Me.dgvMostrarRecaudacion.OptionsView.RowAutoHeight = True
        Me.dgvMostrarRecaudacion.OptionsView.ShowGroupPanel = False
        '
        'gcRecId
        '
        Me.gcRecId.Caption = "Rec Id"
        Me.gcRecId.FieldName = "RecId"
        Me.gcRecId.Name = "gcRecId"
        Me.gcRecId.Visible = True
        Me.gcRecId.VisibleIndex = 0
        '
        'gcRecFecPago
        '
        Me.gcRecFecPago.Caption = "Fecha Pago"
        Me.gcRecFecPago.FieldName = "RecFecPago"
        Me.gcRecFecPago.Name = "gcRecFecPago"
        Me.gcRecFecPago.Visible = True
        Me.gcRecFecPago.VisibleIndex = 1
        '
        'gcRecNroOrden
        '
        Me.gcRecNroOrden.Caption = "Nro Orden"
        Me.gcRecNroOrden.FieldName = "RecNroOrden"
        Me.gcRecNroOrden.Name = "gcRecNroOrden"
        Me.gcRecNroOrden.Visible = True
        Me.gcRecNroOrden.VisibleIndex = 2
        '
        'gcConId
        '
        Me.gcConId.Caption = "Concepto ID"
        Me.gcConId.FieldName = "ConId"
        Me.gcConId.Name = "gcConId"
        Me.gcConId.Visible = True
        Me.gcConId.VisibleIndex = 3
        '
        'gcRecNro
        '
        Me.gcRecNro.Caption = "Recibo"
        Me.gcRecNro.FieldName = "RecNro"
        Me.gcRecNro.Name = "gcRecNro"
        Me.gcRecNro.Visible = True
        Me.gcRecNro.VisibleIndex = 5
        '
        'gcTgNombreTipoDoc
        '
        Me.gcTgNombreTipoDoc.Caption = "Tipo Doc"
        Me.gcTgNombreTipoDoc.FieldName = "TgNombreTipoDoc"
        Me.gcTgNombreTipoDoc.Name = "gcTgNombreTipoDoc"
        Me.gcTgNombreTipoDoc.Visible = True
        Me.gcTgNombreTipoDoc.VisibleIndex = 6
        '
        'gcPerNroDoc
        '
        Me.gcPerNroDoc.Caption = "Nro Doc"
        Me.gcPerNroDoc.FieldName = "PerNroDoc"
        Me.gcPerNroDoc.Name = "gcPerNroDoc"
        Me.gcPerNroDoc.Visible = True
        Me.gcPerNroDoc.VisibleIndex = 7
        '
        'gcPerNombre
        '
        Me.gcPerNombre.Caption = "Persona"
        Me.gcPerNombre.FieldName = "PerNombre"
        Me.gcPerNombre.Name = "gcPerNombre"
        Me.gcPerNombre.Visible = True
        Me.gcPerNombre.VisibleIndex = 8
        '
        'gcRecMonto
        '
        Me.gcRecMonto.Caption = "Monto "
        Me.gcRecMonto.DisplayFormat.FormatString = "#,##0.00"
        Me.gcRecMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcRecMonto.FieldName = "RecMonto"
        Me.gcRecMonto.Name = "gcRecMonto"
        Me.gcRecMonto.Visible = True
        Me.gcRecMonto.VisibleIndex = 9
        '
        'gcConPorcentaje
        '
        Me.gcConPorcentaje.Caption = "% Concepto"
        Me.gcConPorcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcConPorcentaje.FieldName = "ConPorcentaje"
        Me.gcConPorcentaje.Name = "gcConPorcentaje"
        Me.gcConPorcentaje.Visible = True
        Me.gcConPorcentaje.VisibleIndex = 10
        '
        'gcRecTotalIng
        '
        Me.gcRecTotalIng.Caption = "Rec Total Ing"
        Me.gcRecTotalIng.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcRecTotalIng.FieldName = "RecTotalIng"
        Me.gcRecTotalIng.Name = "gcRecTotalIng"
        Me.gcRecTotalIng.Visible = True
        Me.gcRecTotalIng.VisibleIndex = 11
        '
        'gcRecVComision
        '
        Me.gcRecVComision.Caption = "Comision "
        Me.gcRecVComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcRecVComision.FieldName = "RecVComision"
        Me.gcRecVComision.Name = "gcRecVComision"
        Me.gcRecVComision.Visible = True
        Me.gcRecVComision.VisibleIndex = 12
        '
        'gcRecComision
        '
        Me.gcRecComision.Caption = "Comision %"
        Me.gcRecComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcRecComision.FieldName = "RecComision"
        Me.gcRecComision.Name = "gcRecComision"
        Me.gcRecComision.Visible = True
        Me.gcRecComision.VisibleIndex = 13
        '
        'gcRecNeto
        '
        Me.gcRecNeto.Caption = "Neto "
        Me.gcRecNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcRecNeto.FieldName = "RecNeto"
        Me.gcRecNeto.Name = "gcRecNeto"
        Me.gcRecNeto.Visible = True
        Me.gcRecNeto.VisibleIndex = 14
        '
        'gcRecFechaReg
        '
        Me.gcRecFechaReg.Caption = "Fecha Reg"
        Me.gcRecFechaReg.DisplayFormat.FormatString = "d"
        Me.gcRecFechaReg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcRecFechaReg.FieldName = "RecFechaReg"
        Me.gcRecFechaReg.Name = "gcRecFechaReg"
        Me.gcRecFechaReg.Visible = True
        Me.gcRecFechaReg.VisibleIndex = 15
        '
        'gcUsuId
        '
        Me.gcUsuId.Caption = "Usuario"
        Me.gcUsuId.FieldName = "UsuId"
        Me.gcUsuId.Name = "gcUsuId"
        Me.gcUsuId.Visible = True
        Me.gcUsuId.VisibleIndex = 16
        '
        'gcTgNombreRecaudador
        '
        Me.gcTgNombreRecaudador.Caption = "Recaudador"
        Me.gcTgNombreRecaudador.FieldName = "TgNombreRecaudador"
        Me.gcTgNombreRecaudador.Name = "gcTgNombreRecaudador"
        Me.gcTgNombreRecaudador.Visible = True
        Me.gcTgNombreRecaudador.VisibleIndex = 17
        '
        'gcTgRecaudadorId
        '
        Me.gcTgRecaudadorId.Caption = "Recaudador Id"
        Me.gcTgRecaudadorId.FieldName = "TgRecaudadorId"
        Me.gcTgRecaudadorId.Name = "gcTgRecaudadorId"
        '
        'gcconcepto
        '
        Me.gcconcepto.Caption = "Concepto"
        Me.gcconcepto.FieldName = "Concepto"
        Me.gcconcepto.Name = "gcconcepto"
        Me.gcconcepto.Visible = True
        Me.gcconcepto.VisibleIndex = 4
        '
        'gcTgTipoDoc
        '
        Me.gcTgTipoDoc.Caption = "GridColumn6"
        Me.gcTgTipoDoc.FieldName = "TgTipoDoc"
        Me.gcTgTipoDoc.Name = "gcTgTipoDoc"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha Liquidación"
        Me.GridColumn6.FieldName = "RecFechaLiquidacion"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 18
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1004, 728)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(998, 699)
        Me.XtraTabPage1.Text = "Mostrar Recaudación "
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.rblrecaudador)
        Me.LayoutControl1.Controls.Add(Me.SaimtGroupBox2)
        Me.LayoutControl1.Controls.Add(Me.DateNImp)
        Me.LayoutControl1.Controls.Add(Me.SplitterControl1)
        Me.LayoutControl1.Controls.Add(Me.TxtTotalIngreso)
        Me.LayoutControl1.Controls.Add(Me.dgvResultado)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(600, 210, 250, 385)
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(998, 699)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'rblrecaudador
        '
        Me.rblrecaudador.EditValue = "ALL"
        Me.rblrecaudador.Location = New System.Drawing.Point(12, 28)
        Me.rblrecaudador.MenuManager = Me.RibbonControl
        Me.rblrecaudador.Name = "rblrecaudador"
        Me.rblrecaudador.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rblrecaudador.Properties.Appearance.Options.UseBackColor = True
        Me.rblrecaudador.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("02", "Caja Trujillo"), New DevExpress.XtraEditors.Controls.RadioGroupItem("01", "SATT"), New DevExpress.XtraEditors.Controls.RadioGroupItem("ALL", "Todos")})
        Me.rblrecaudador.Size = New System.Drawing.Size(485, 25)
        Me.rblrecaudador.StyleController = Me.LayoutControl1
        Me.rblrecaudador.TabIndex = 0
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.btnEditar)
        Me.SaimtGroupBox2.Controls.Add(Me.btnAgregar)
        Me.SaimtGroupBox2.Controls.Add(Me.btndetalle)
        Me.SaimtGroupBox2.Controls.Add(Me.btnexportar)
        Me.SaimtGroupBox2.Controls.Add(Me.lblmRecaudador)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox2.Controls.Add(Me.lblMFecha)
        Me.SaimtGroupBox2.Controls.Add(Me.lblFecha)
        Me.SaimtGroupBox2.Controls.Add(Me.btnEliminar)
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(759, 545)
        Me.SaimtGroupBox2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(227, 142)
        Me.SaimtGroupBox2.TabIndex = 0
        Me.SaimtGroupBox2.Text = "Opcion Eliminar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.Presentacion.My.Resources.Resources.contrato1
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(179, 92)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(29, 23)
        Me.btnEditar.TabIndex = 59
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(179, 65)
        Me.btnAgregar.LookAndFeel.SkinName = "Seven"
        Me.btnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(29, 22)
        Me.btnAgregar.TabIndex = 58
        Me.btnAgregar.Visible = False
        '
        'btndetalle
        '
        Me.btndetalle.Image = CType(resources.GetObject("btndetalle.Image"), System.Drawing.Image)
        Me.btndetalle.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btndetalle.Location = New System.Drawing.Point(67, 65)
        Me.btndetalle.Name = "btndetalle"
        Me.btndetalle.Size = New System.Drawing.Size(52, 50)
        Me.btndetalle.TabIndex = 5
        Me.btndetalle.Text = "Detalle"
        Me.btndetalle.ToolTip = "Ver Detalle"
        '
        'btnexportar
        '
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnexportar.Location = New System.Drawing.Point(121, 65)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(52, 50)
        Me.btnexportar.TabIndex = 6
        Me.btnexportar.Text = "Exportar"
        '
        'lblmRecaudador
        '
        Me.lblmRecaudador.Location = New System.Drawing.Point(87, 45)
        Me.lblmRecaudador.Name = "lblmRecaudador"
        Me.lblmRecaudador.Size = New System.Drawing.Size(0, 13)
        Me.lblmRecaudador.TabIndex = 3
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(15, 45)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(65, 13)
        Me.SaimtLabel1.TabIndex = 2
        Me.SaimtLabel1.Text = "Recaudador :"
        '
        'lblMFecha
        '
        Me.lblMFecha.Location = New System.Drawing.Point(15, 29)
        Me.lblMFecha.Name = "lblMFecha"
        Me.lblMFecha.Size = New System.Drawing.Size(36, 13)
        Me.lblMFecha.TabIndex = 0
        Me.lblMFecha.Text = "Fecha :"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(67, 29)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 13)
        Me.lblFecha.TabIndex = 1
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.Presentacion.My.Resources.Resources.cancelar
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.cancelar
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(14, 65)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(52, 50)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        '
        'DateNImp
        '
        Me.DateNImp.DateTime = New Date(CType(0, Long))
        Me.DateNImp.HotDate = Nothing
        Me.DateNImp.Location = New System.Drawing.Point(12, 545)
        Me.DateNImp.Multiselect = False
        Me.DateNImp.Name = "DateNImp"
        Me.DateNImp.ShowTodayButton = False
        Me.DateNImp.Size = New System.Drawing.Size(738, 142)
        Me.DateNImp.TabIndex = 0
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(976, 400)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(5, 3)
        Me.SplitterControl1.TabIndex = 5
        Me.SplitterControl1.TabStop = False
        '
        'TxtTotalIngreso
        '
        Me.TxtTotalIngreso.Location = New System.Drawing.Point(856, 516)
        Me.TxtTotalIngreso.MenuManager = Me.RibbonControl
        Me.TxtTotalIngreso.Name = "TxtTotalIngreso"
        Me.TxtTotalIngreso.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalIngreso.Properties.Appearance.Options.UseFont = True
        Me.TxtTotalIngreso.Properties.Mask.EditMask = "n2"
        Me.TxtTotalIngreso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtTotalIngreso.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtTotalIngreso.Properties.ReadOnly = True
        Me.TxtTotalIngreso.Size = New System.Drawing.Size(130, 20)
        Me.TxtTotalIngreso.StyleController = Me.LayoutControl1
        Me.TxtTotalIngreso.TabIndex = 0
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.SplitterItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.SplitterItem3, Me.LayoutControlItem5, Me.SplitterItem4, Me.LayoutControlItem15, Me.SplitterItem5, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(998, 699)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgvResultado
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(978, 449)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(0, 528)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(978, 5)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DateNImp
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 533)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(742, 146)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 504)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(719, 24)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtTotalIngreso
        Me.LayoutControlItem3.CustomizationFormText = "Total Ingreso"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(719, 504)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(259, 24)
        Me.LayoutControlItem3.Text = "Total Ingreso"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(120, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'SplitterItem3
        '
        Me.SplitterItem3.AllowHotTrack = True
        Me.SplitterItem3.CustomizationFormText = "SplitterItem3"
        Me.SplitterItem3.Location = New System.Drawing.Point(0, 499)
        Me.SplitterItem3.Name = "SplitterItem3"
        Me.SplitterItem3.Size = New System.Drawing.Size(978, 5)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SaimtGroupBox2
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(747, 533)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(231, 146)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'SplitterItem4
        '
        Me.SplitterItem4.AllowHotTrack = True
        Me.SplitterItem4.CustomizationFormText = "SplitterItem4"
        Me.SplitterItem4.Location = New System.Drawing.Point(742, 533)
        Me.SplitterItem4.Name = "SplitterItem4"
        Me.SplitterItem4.Size = New System.Drawing.Size(5, 146)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.rblrecaudador
        Me.LayoutControlItem15.CustomizationFormText = "Seleccione Agente Recaudador"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(489, 45)
        Me.LayoutControlItem15.Text = "Seleccione Agente Recaudador"
        Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(149, 13)
        '
        'SplitterItem5
        '
        Me.SplitterItem5.AllowHotTrack = True
        Me.SplitterItem5.CustomizationFormText = "SplitterItem5"
        Me.SplitterItem5.Location = New System.Drawing.Point(0, 45)
        Me.SplitterItem5.Name = "SplitterItem5"
        Me.SplitterItem5.Size = New System.Drawing.Size(978, 5)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(489, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(489, 45)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LayoutControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(998, 699)
        Me.XtraTabPage2.Text = "Importar Recaudación"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.rbRecaudador)
        Me.LayoutControl2.Controls.Add(Me.SaimtGroupBox1)
        Me.LayoutControl2.Controls.Add(Me.tlImportar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(602, 274, 250, 350)
        Me.LayoutControl2.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(998, 699)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'rbRecaudador
        '
        Me.rbRecaudador.Location = New System.Drawing.Point(12, 28)
        Me.rbRecaudador.MenuManager = Me.RibbonControl
        Me.rbRecaudador.Name = "rbRecaudador"
        Me.rbRecaudador.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rbRecaudador.Properties.Appearance.Options.UseBackColor = True
        Me.rbRecaudador.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Caja Trujillo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "SATT")})
        Me.rbRecaudador.Size = New System.Drawing.Size(278, 25)
        Me.rbRecaudador.StyleController = Me.LayoutControl2
        Me.rbRecaudador.TabIndex = 0
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Controls.Add(Me.btnimportar)
        Me.SaimtGroupBox1.Controls.Add(Me.btnImpArchivo)
        Me.SaimtGroupBox1.Controls.Add(Me.LabelControl1)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(12, 535)
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(974, 152)
        Me.SaimtGroupBox1.TabIndex = 0
        Me.SaimtGroupBox1.Text = "Datos para la Importación"
        '
        'btnimportar
        '
        Me.btnimportar.Image = CType(resources.GetObject("btnimportar.Image"), System.Drawing.Image)
        Me.btnimportar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnimportar.Location = New System.Drawing.Point(74, 54)
        Me.btnimportar.Name = "btnimportar"
        Me.btnimportar.Size = New System.Drawing.Size(75, 66)
        Me.btnimportar.TabIndex = 2
        Me.btnimportar.Text = "Importar"
        '
        'btnImpArchivo
        '
        Me.btnImpArchivo.Location = New System.Drawing.Point(74, 28)
        Me.btnImpArchivo.MenuManager = Me.RibbonControl
        Me.btnImpArchivo.Name = "btnImpArchivo"
        Me.btnImpArchivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnImpArchivo.Properties.ReadOnly = True
        Me.btnImpArchivo.Size = New System.Drawing.Size(457, 20)
        Me.btnImpArchivo.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Ruta Archivo"
        '
        'tlImportar
        '
        Me.tlImportar.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.tlc1, Me.tlc2, Me.tlc3, Me.tlc4, Me.tlc5, Me.tlc6, Me.tlc7, Me.tlc8, Me.tlc9, Me.tlc10, Me.tlc11, Me.tlc12})
        Me.tlImportar.Location = New System.Drawing.Point(12, 57)
        Me.tlImportar.Name = "tlImportar"
        Me.tlImportar.OptionsView.AutoWidth = False
        Me.tlImportar.Size = New System.Drawing.Size(974, 469)
        Me.tlImportar.TabIndex = 0
        '
        'tlc1
        '
        Me.tlc1.Caption = "tlc1"
        Me.tlc1.FieldName = "tlc1"
        Me.tlc1.Name = "tlc1"
        Me.tlc1.Visible = True
        Me.tlc1.VisibleIndex = 0
        '
        'tlc2
        '
        Me.tlc2.Caption = "tlc2"
        Me.tlc2.FieldName = "tlc2"
        Me.tlc2.Name = "tlc2"
        Me.tlc2.Visible = True
        Me.tlc2.VisibleIndex = 1
        '
        'tlc3
        '
        Me.tlc3.Caption = "tlc3"
        Me.tlc3.FieldName = "tlc3"
        Me.tlc3.Name = "tlc3"
        Me.tlc3.Visible = True
        Me.tlc3.VisibleIndex = 2
        '
        'tlc4
        '
        Me.tlc4.Caption = "tlc4"
        Me.tlc4.FieldName = "tlc4"
        Me.tlc4.Name = "tlc4"
        Me.tlc4.Visible = True
        Me.tlc4.VisibleIndex = 3
        '
        'tlc5
        '
        Me.tlc5.Caption = "tlc5"
        Me.tlc5.FieldName = "tlc5"
        Me.tlc5.Name = "tlc5"
        Me.tlc5.Visible = True
        Me.tlc5.VisibleIndex = 4
        '
        'tlc6
        '
        Me.tlc6.Caption = "tlc6"
        Me.tlc6.FieldName = "tlc6"
        Me.tlc6.Name = "tlc6"
        Me.tlc6.Visible = True
        Me.tlc6.VisibleIndex = 5
        '
        'tlc7
        '
        Me.tlc7.Caption = "tlc7"
        Me.tlc7.FieldName = "tlc7"
        Me.tlc7.Name = "tlc7"
        Me.tlc7.Visible = True
        Me.tlc7.VisibleIndex = 6
        '
        'tlc8
        '
        Me.tlc8.Caption = "tlc8"
        Me.tlc8.FieldName = "tlc8"
        Me.tlc8.Name = "tlc8"
        Me.tlc8.Visible = True
        Me.tlc8.VisibleIndex = 7
        '
        'tlc9
        '
        Me.tlc9.Caption = "tlc9"
        Me.tlc9.FieldName = "tlc9"
        Me.tlc9.Name = "tlc9"
        Me.tlc9.Visible = True
        Me.tlc9.VisibleIndex = 8
        '
        'tlc10
        '
        Me.tlc10.Caption = "tlc10"
        Me.tlc10.FieldName = "tlc10"
        Me.tlc10.Name = "tlc10"
        Me.tlc10.Visible = True
        Me.tlc10.VisibleIndex = 9
        '
        'tlc11
        '
        Me.tlc11.Caption = "tlc11"
        Me.tlc11.FieldName = "tlc11"
        Me.tlc11.Name = "tlc11"
        Me.tlc11.Visible = True
        Me.tlc11.VisibleIndex = 10
        '
        'tlc12
        '
        Me.tlc12.Caption = "tlc12"
        Me.tlc12.FieldName = "tlc12"
        Me.tlc12.Name = "tlc12"
        Me.tlc12.Visible = True
        Me.tlc12.VisibleIndex = 11
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem6, Me.SplitterItem2, Me.LayoutControlItem7, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(998, 699)
        Me.LayoutControlGroup2.Text = "Root"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.tlImportar
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 45)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(978, 473)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SaimtGroupBox1
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 523)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(978, 156)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'SplitterItem2
        '
        Me.SplitterItem2.AllowHotTrack = True
        Me.SplitterItem2.CustomizationFormText = "SplitterItem2"
        Me.SplitterItem2.Location = New System.Drawing.Point(0, 518)
        Me.SplitterItem2.Name = "SplitterItem2"
        Me.SplitterItem2.Size = New System.Drawing.Size(978, 5)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.rbRecaudador
        Me.LayoutControlItem7.CustomizationFormText = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(171, 45)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(282, 45)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(167, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(282, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(696, 45)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "GridColumn4"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "GridColumn5"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.rbRecaudador
        Me.LayoutControlItem9.CustomizationFormText = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(171, 45)
        Me.LayoutControlItem9.Name = "LayoutControlItem7"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(284, 48)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(167, 13)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.rbRecaudador
        Me.LayoutControlItem10.CustomizationFormText = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(171, 45)
        Me.LayoutControlItem10.Name = "LayoutControlItem7"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(284, 48)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(167, 13)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.rbRecaudador
        Me.LayoutControlItem11.CustomizationFormText = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(171, 45)
        Me.LayoutControlItem11.Name = "LayoutControlItem7"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(284, 48)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(167, 13)
        Me.LayoutControlItem11.TextToControlDistance = 5
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.rbRecaudador
        Me.LayoutControlItem12.CustomizationFormText = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(171, 45)
        Me.LayoutControlItem12.Name = "LayoutControlItem7"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(284, 48)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(167, 13)
        Me.LayoutControlItem12.TextToControlDistance = 5
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.rbRecaudador
        Me.LayoutControlItem13.CustomizationFormText = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(171, 45)
        Me.LayoutControlItem13.Name = "LayoutControlItem7"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(284, 48)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(167, 13)
        Me.LayoutControlItem13.TextToControlDistance = 5
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.rbRecaudador
        Me.LayoutControlItem14.CustomizationFormText = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(171, 45)
        Me.LayoutControlItem14.Name = "LayoutControlItem7"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(284, 48)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "Selecciona la Entidad Recaudadora"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(167, 13)
        Me.LayoutControlItem14.TextToControlDistance = 5
        '
        'beiprogreso
        '
        Me.beiprogreso.Caption = "BarEditItem1"
        Me.beiprogreso.Edit = Me.ripprogreso
        Me.beiprogreso.Id = 2
        Me.beiprogreso.Name = "beiprogreso"
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.beiprogreso.Width = 110
        '
        'ripprogreso
        '
        Me.ripprogreso.Name = "ripprogreso"
        Me.ripprogreso.Stopped = True
        '
        'frmImportarRecSatt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 755)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmImportarRecSatt"
        Me.Tag = "frmImportarRecSatt"
        Me.Text = "Importar Datos de Satt y Terminal Terrestre "
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecaudacionDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMostrarRecaudacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.rblrecaudador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.DateNImp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotalIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.rbRecaudador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.btnImpArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tlImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ripprogreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ofdimportar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents btnimportar As SaimtControles.SaimtButton
    Friend WithEvents btnImpArchivo As SaimtControles.SaimtButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents tlImportar As SaimtControles.SaimtTreeList
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem2 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TxtTotalIngreso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateNImp As SaimtControles.SaimtDateNavigator
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rbRecaudador As SaimtControles.SaimtRadioGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SplitterItem3 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents tlc1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc3 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc4 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc5 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc6 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc7 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc8 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc9 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc10 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc11 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlc12 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents dgvResultado As SaimtControles.SaimtDataGrid
    Friend WithEvents dgvMostrarRecaudacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem4 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents lblMFecha As SaimtControles.SaimtLabel
    Friend WithEvents lblFecha As SaimtControles.SaimtLabel
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents rblrecaudador As SaimtControles.SaimtRadioGroup
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem5 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblmRecaudador As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents beiprogreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ripprogreso As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents btndetalle As SaimtControles.SaimtButton
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents sfdexportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dgvRecaudacionDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcRecId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRecFecPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRecNroOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcConId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRecNro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTgNombreTipoDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPerNroDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPerNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRecMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcConPorcentaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRecTotalIng As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRecVComision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRecComision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRecNeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRecFechaReg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcUsuId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTgNombreRecaudador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTgRecaudadorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdconId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdconcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdmontodep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdporsaimt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdingsaimt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdrecid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdRecFecPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdTgRecaudadorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcconcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTgTipoDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents btnAgregar As SaimtControles.SaimtButton
End Class
