﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBandejaEntrada
    Inherits Presentacion.frmGeneral

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBandejaEntrada))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.gcMovRead = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riicmbleido = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.ImageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.gcmovgaf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctgEstadoTramite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtXtraTabControl1 = New SaimtControles.SaimtXtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.SaimtLabel57 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel56 = New SaimtControles.SaimtLabel()
        Me.cboCriterioMes = New System.Windows.Forms.ComboBox()
        Me.CboCriterioAnio = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.SaimtLabel71 = New SaimtControles.SaimtLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaimtLabel52 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel53 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel50 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel51 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel48 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel49 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel46 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel47 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel44 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel45 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel39 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel43 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.TxtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.sTLBandeja = New SaimtControles.SaimtTreeList()
        Me.tlCarPerId = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlCargo = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.sRbtipoCriterio = New SaimtControles.SaimtRadioGroup()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.CheckButton1 = New DevExpress.XtraEditors.CheckButton()
        Me.btnAnularEnvio = New SaimtControles.SaimtButton()
        Me.btnExportargrilla = New SaimtControles.SaimtButton()
        Me.cbagrupar = New DevExpress.XtraEditors.CheckButton()
        Me.dgvRemitente = New SaimtControles.SaimtDataGrid()
        Me.gvRemitente = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcMovID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDocId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riicmborigen = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.gcRecepcionado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gcOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcOrigenCargo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ripcdestino = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.gcDestinoCargo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMovComentario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ritxtcomentario = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.gcDocNReg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTipoDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMovFechaEnvio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTipoDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc_MovPara = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAsunto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ritxtAsunto = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.gcAdjunto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riicmbadjunto = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.gcGrupoMovFechaEnv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gctgEstadoTramiteId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMovEnviado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riicmbenviado = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.gcVinculado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riicmbprioridad = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.SaimtLabel55 = New SaimtControles.SaimtLabel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SaimtLabel70 = New SaimtControles.SaimtLabel()
        Me.btnPagUltimo = New SaimtControles.SaimtButton()
        Me.btnPagAdelante = New SaimtControles.SaimtButton()
        Me.btnPagAtras = New SaimtControles.SaimtButton()
        Me.btnPagInicio = New SaimtControles.SaimtButton()
        Me.SaimtLabel69 = New SaimtControles.SaimtLabel()
        Me.txtNActual = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel58 = New SaimtControles.SaimtLabel()
        Me.chkMostrarNrow = New SaimtControles.SaimtCheckBox()
        Me.txtNRegistros = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel42 = New SaimtControles.SaimtLabel()
        Me.ssNrow = New SaimtControles.SaimtSpinner()
        Me.dtpfechaIngDoc = New SaimtControles.SaimtDateTimePicker()
        Me.chkMovFechaEnv = New SaimtControles.SaimtCheckBox()
        Me.SaimtLabel54 = New SaimtControles.SaimtLabel()
        Me.cboAccion = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnrefrescar = New SaimtControles.SaimtButton()
        Me.btnTerminar = New SaimtControles.SaimtButton()
        Me.btnAbrirDoc = New SaimtControles.SaimtButton()
        Me.btnImprimirFlujo = New SaimtControles.SaimtButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GBoxDatosDocumento = New SaimtControles.SaimtGroupBox()
        Me.btnVisorDoc = New SaimtControles.SaimtButton()
        Me.txtDocumentoAux = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel35 = New SaimtControles.SaimtLabel()
        Me.txtMovDoc = New SaimtControles.SaimtTextBox()
        Me.TxtTipoDoc = New SaimtControles.SaimtTextBox()
        Me.TxtPrioridad = New SaimtControles.SaimtTextBox()
        Me.txtDocFecha = New SaimtControles.SaimtTextBox()
        Me.txtDocFechaIng = New SaimtControles.SaimtTextBox()
        Me.btnSiguiente = New SaimtControles.SaimtButton()
        Me.btnAtras = New SaimtControles.SaimtButton()
        Me.btnReenviar = New SaimtControles.SaimtButton()
        Me.btnVolver = New SaimtControles.SaimtButton()
        Me.SaimtButton4 = New SaimtControles.SaimtButton()
        Me.TxtProcedimiento = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel33 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel32 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel31 = New SaimtControles.SaimtLabel()
        Me.txtdocid = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtvinId = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel27 = New SaimtControles.SaimtLabel()
        Me.btnAnexos = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox6 = New SaimtControles.SaimtGroupBox()
        Me.txtArea = New SaimtControles.SaimtTextBox()
        Me.txtIntitucion = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel19 = New SaimtControles.SaimtLabel()
        Me.TxtNdocReg = New SaimtControles.SaimtTextBox()
        Me.txtAño = New SaimtControles.SaimtTextBox()
        Me.sTxtSiglas = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel22 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel21 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel20 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel26 = New SaimtControles.SaimtLabel()
        Me.ssDocParte = New SaimtControles.SaimtSpinner()
        Me.txtasunto = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.sRdbOrigen = New SaimtControles.SaimtRadioGroup()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.chkReqActivos = New SaimtControles.SaimtCheckBox()
        Me.sRbTupac = New SaimtControles.SaimtRadioGroup()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.ssFolios = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel34 = New SaimtControles.SaimtLabel()
        Me.GBoxDatosAdicionales = New SaimtControles.SaimtGroupBox()
        Me.BackstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        Me.BackstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.SaimtTabs1 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.TxtCargoInt = New SaimtControles.SaimtTextBox()
        Me.TxtAreaInt = New SaimtControles.SaimtTextBox()
        Me.TxtInstitucionInt = New SaimtControles.SaimtTextBox()
        Me.TxtDireccionPerInt = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel23 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel24 = New SaimtControles.SaimtLabel()
        Me.TxtInteresado = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel25 = New SaimtControles.SaimtLabel()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgvDatosAdicionales = New SaimtControles.SaimtDataGrid()
        Me.gvDatosAdicionales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BackstageViewClientControl2 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.SaimtTabs2 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgvReqvsProc = New SaimtControles.SaimtDataGrid()
        Me.gvReqvsProc = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcTgId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtProcedimientoVer = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel28 = New SaimtControles.SaimtLabel()
        Me.BackstageViewClientControl3 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.dgvMovimientos = New SaimtControles.SaimtDataGrid()
        Me.gvMovimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcPerNombreOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPerCargoOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPerNombreDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPerCargoDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMovDiasTenencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMovFechaRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTgEstadoMov = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMovFechaEnv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMovTieneArch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.gvMovimientosDet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gccarPerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcperId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcpersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcperDni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gccarPerFechaIni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcperDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BackstageViewClientControl5 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.TxtDocRef = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel30 = New SaimtControles.SaimtLabel()
        Me.txtcomentario = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel29 = New SaimtControles.SaimtLabel()
        Me.BackstageViewClientControl6 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.dgvDocumentosVinculados = New SaimtControles.SaimtDataGrid()
        Me.lvDocumentosVinculados = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.LayoutViewColumn12 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn12 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn10 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.layoutViewField_LayoutViewColumn10 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn11 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn11 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn4 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn4 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn5 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn5 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn6 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn6 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.RepositoryItemMemoExEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemMemoExEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.BackstageViewTabItem2 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem3 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator2 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem5 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator3 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem7 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator5 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BackstageViewTabItem8 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator6 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.SaimtLabel18 = New SaimtControles.SaimtLabel()
        Me.btnInstitucionEnviar = New SaimtControles.SaimtButton()
        Me.sTxtInstitucion = New SaimtControles.SaimtTextBox()
        Me.SaimtButton6 = New SaimtControles.SaimtButton()
        Me.sBtnAgregar = New SaimtControles.SaimtButton()
        Me.sCboEstado = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.sTxtComentario = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel16 = New SaimtControles.SaimtLabel()
        Me.gvDestinos = New SaimtControles.SaimtDataGrid()
        Me.dgvTrabajadores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTgTDestinoId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTgTipoDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.sCboCargoDest = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel17 = New SaimtControles.SaimtLabel()
        Me.sCboArea = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel37 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel38 = New SaimtControles.SaimtLabel()
        Me.BackstageViewTabItem4 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.sfdExportar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicmbleido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtXtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtXtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.CboCriterioAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.TxtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.sTLBandeja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sRbtipoCriterio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.dgvRemitente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRemitente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicmborigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ripcdestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ritxtcomentario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ritxtAsunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicmbadjunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicmbenviado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicmbprioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtNActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMostrarNrow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNRegistros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssNrow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpfechaIngDoc.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpfechaIngDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMovFechaEnv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GBoxDatosDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxDatosDocumento.SuspendLayout()
        CType(Me.txtDocumentoAux.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMovDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTipoDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrioridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocFechaIng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdocid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvinId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox6.SuspendLayout()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNdocReg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sTxtSiglas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssDocParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtasunto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sRdbOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReqActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sRbTupac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssFolios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GBoxDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxDatosAdicionales.SuspendLayout()
        Me.BackstageViewControl1.SuspendLayout()
        Me.BackstageViewClientControl1.SuspendLayout()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.TxtCargoInt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAreaInt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInstitucionInt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDireccionPerInt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInteresado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.dgvDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewClientControl2.SuspendLayout()
        CType(Me.SaimtTabs2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs2.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.dgvReqvsProc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReqvsProc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtProcedimientoVer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewClientControl3.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMovimientosDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewClientControl5.SuspendLayout()
        CType(Me.TxtDocRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcomentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewClientControl6.SuspendLayout()
        CType(Me.dgvDocumentosVinculados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvDocumentosVinculados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sTxtInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sCboEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sTxtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDestinos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sCboCargoDest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sCboArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 721)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1028, 27)
        '
        'gcMovRead
        '
        Me.gcMovRead.Caption = " "
        Me.gcMovRead.ColumnEdit = Me.riicmbleido
        Me.gcMovRead.FieldName = "movRead"
        Me.gcMovRead.Image = CType(resources.GetObject("gcMovRead.Image"), System.Drawing.Image)
        Me.gcMovRead.ImageIndex = 5
        Me.gcMovRead.Name = "gcMovRead"
        Me.gcMovRead.OptionsColumn.AllowEdit = False
        Me.gcMovRead.OptionsColumn.ReadOnly = True
        Me.gcMovRead.ToolTip = "Lectura de Documento ?"
        '
        'riicmbleido
        '
        Me.riicmbleido.AutoHeight = False
        Me.riicmbleido.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riicmbleido.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.riicmbleido.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "1", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "0", 0)})
        Me.riicmbleido.Name = "riicmbleido"
        Me.riicmbleido.SmallImages = Me.ImageCollection2
        '
        'ImageCollection2
        '
        Me.ImageCollection2.ImageStream = CType(resources.GetObject("ImageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection2.Images.SetKeyName(0, "email.png")
        Me.ImageCollection2.Images.SetKeyName(1, "email_open.png")
        Me.ImageCollection2.Images.SetKeyName(2, "attach.png")
        Me.ImageCollection2.Images.SetKeyName(3, "arrow_down.png")
        Me.ImageCollection2.Images.SetKeyName(4, "arrow_up.png")
        Me.ImageCollection2.Images.SetKeyName(5, "page_white.png")
        Me.ImageCollection2.Images.SetKeyName(6, "newspaper_go.png")
        Me.ImageCollection2.Images.SetKeyName(7, "page_white_put.png")
        Me.ImageCollection2.Images.SetKeyName(8, "basket_put.png")
        Me.ImageCollection2.Images.SetKeyName(9, "arrow_down.png")
        Me.ImageCollection2.Images.SetKeyName(10, "arrow_up1.png")
        Me.ImageCollection2.Images.SetKeyName(11, "carouselnavigator.png")
        Me.ImageCollection2.Images.SetKeyName(12, "arrow_turn_000_left.png")
        Me.ImageCollection2.Images.SetKeyName(13, "page_white_word.png")
        '
        'gcmovgaf
        '
        Me.gcmovgaf.Caption = "VistaGaf"
        Me.gcmovgaf.FieldName = "movgaf"
        Me.gcmovgaf.Name = "gcmovgaf"
        '
        'gctgEstadoTramite
        '
        Me.gctgEstadoTramite.Caption = "Estado Tramite"
        Me.gctgEstadoTramite.FieldName = "tgEstadoTramite"
        Me.gctgEstadoTramite.Name = "gctgEstadoTramite"
        Me.gctgEstadoTramite.OptionsColumn.AllowEdit = False
        Me.gctgEstadoTramite.OptionsColumn.ReadOnly = True
        Me.gctgEstadoTramite.Visible = True
        Me.gctgEstadoTramite.VisibleIndex = 13
        Me.gctgEstadoTramite.Width = 101
        '
        'SaimtXtraTabControl1
        '
        Me.SaimtXtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtXtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtXtraTabControl1.Name = "SaimtXtraTabControl1"
        Me.SaimtXtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.SaimtXtraTabControl1.Size = New System.Drawing.Size(1028, 721)
        Me.SaimtXtraTabControl1.TabIndex = 0
        Me.SaimtXtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1022, 693)
        Me.XtraTabPage1.Tag = ""
        Me.XtraTabPage1.Text = "Recepción Documentos"
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel57)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel56)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cboCriterioMes)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.CboCriterioAnio)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtGroupBox3)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.TxtBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.sRbtipoCriterio)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.SaimtGroupBox2)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.PanelControl1)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(1022, 693)
        Me.SaimtSplitContainerControl1.SplitterPosition = 269
        Me.SaimtSplitContainerControl1.TabIndex = 0
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'SaimtLabel57
        '
        Me.SaimtLabel57.Location = New System.Drawing.Point(147, 23)
        Me.SaimtLabel57.Name = "SaimtLabel57"
        Me.SaimtLabel57.Size = New System.Drawing.Size(30, 13)
        Me.SaimtLabel57.TabIndex = 8
        Me.SaimtLabel57.Text = "Meses"
        '
        'SaimtLabel56
        '
        Me.SaimtLabel56.Location = New System.Drawing.Point(9, 24)
        Me.SaimtLabel56.Name = "SaimtLabel56"
        Me.SaimtLabel56.Size = New System.Drawing.Size(19, 13)
        Me.SaimtLabel56.TabIndex = 7
        Me.SaimtLabel56.Text = "Año"
        '
        'cboCriterioMes
        '
        Me.cboCriterioMes.FormattingEnabled = True
        Me.cboCriterioMes.Items.AddRange(New Object() {"Todos", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Noviembre", "Diciembre"})
        Me.cboCriterioMes.Location = New System.Drawing.Point(145, 36)
        Me.cboCriterioMes.Name = "cboCriterioMes"
        Me.cboCriterioMes.Size = New System.Drawing.Size(121, 21)
        Me.cboCriterioMes.TabIndex = 6
        '
        'CboCriterioAnio
        '
        Me.CboCriterioAnio.Location = New System.Drawing.Point(5, 37)
        Me.CboCriterioAnio.MenuManager = Me.RibbonControl
        Me.CboCriterioAnio.Name = "CboCriterioAnio"
        Me.CboCriterioAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CboCriterioAnio.Properties.NullText = ""
        Me.CboCriterioAnio.Size = New System.Drawing.Size(126, 20)
        Me.CboCriterioAnio.TabIndex = 5
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel71)
        Me.SaimtGroupBox3.Controls.Add(Me.Label1)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel52)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel53)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel50)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel51)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel48)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel49)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel46)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel47)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel44)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel45)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel39)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel43)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel11)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel9)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(0, 469)
        Me.SaimtGroupBox3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(268, 221)
        Me.SaimtGroupBox3.TabIndex = 4
        Me.SaimtGroupBox3.Text = "Leyenda"
        '
        'SaimtLabel71
        '
        Me.SaimtLabel71.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SaimtLabel71.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel71.Location = New System.Drawing.Point(35, 28)
        Me.SaimtLabel71.Name = "SaimtLabel71"
        Me.SaimtLabel71.Size = New System.Drawing.Size(228, 26)
        Me.SaimtLabel71.TabIndex = 15
        Me.SaimtLabel71.Text = "Fila color naranja, son expedientes que ya ha sido archivados."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(5, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 19)
        Me.Label1.TabIndex = 14
        '
        'SaimtLabel52
        '
        Me.SaimtLabel52.Location = New System.Drawing.Point(34, 156)
        Me.SaimtLabel52.Name = "SaimtLabel52"
        Me.SaimtLabel52.Size = New System.Drawing.Size(95, 13)
        Me.SaimtLabel52.TabIndex = 9
        Me.SaimtLabel52.Text = "Documento Enviado"
        '
        'SaimtLabel53
        '
        Me.SaimtLabel53.Appearance.ImageIndex = 6
        Me.SaimtLabel53.Appearance.ImageList = Me.ImageCollection2
        Me.SaimtLabel53.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel53.Location = New System.Drawing.Point(6, 151)
        Me.SaimtLabel53.Name = "SaimtLabel53"
        Me.SaimtLabel53.Size = New System.Drawing.Size(21, 22)
        Me.SaimtLabel53.TabIndex = 8
        Me.SaimtLabel53.Text = "       "
        '
        'SaimtLabel50
        '
        Me.SaimtLabel50.Location = New System.Drawing.Point(34, 200)
        Me.SaimtLabel50.Name = "SaimtLabel50"
        Me.SaimtLabel50.Size = New System.Drawing.Size(66, 13)
        Me.SaimtLabel50.TabIndex = 13
        Me.SaimtLabel50.Text = "Prioridad Baja"
        '
        'SaimtLabel51
        '
        Me.SaimtLabel51.Appearance.ImageIndex = 9
        Me.SaimtLabel51.Appearance.ImageList = Me.ImageCollection2
        Me.SaimtLabel51.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel51.Location = New System.Drawing.Point(6, 196)
        Me.SaimtLabel51.Name = "SaimtLabel51"
        Me.SaimtLabel51.Size = New System.Drawing.Size(21, 21)
        Me.SaimtLabel51.TabIndex = 12
        Me.SaimtLabel51.Text = "       "
        '
        'SaimtLabel48
        '
        Me.SaimtLabel48.Location = New System.Drawing.Point(34, 178)
        Me.SaimtLabel48.Name = "SaimtLabel48"
        Me.SaimtLabel48.Size = New System.Drawing.Size(64, 13)
        Me.SaimtLabel48.TabIndex = 11
        Me.SaimtLabel48.Text = "Prioridad Alta"
        '
        'SaimtLabel49
        '
        Me.SaimtLabel49.Appearance.ImageIndex = 10
        Me.SaimtLabel49.Appearance.ImageList = Me.ImageCollection2
        Me.SaimtLabel49.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel49.Location = New System.Drawing.Point(6, 171)
        Me.SaimtLabel49.Name = "SaimtLabel49"
        Me.SaimtLabel49.Size = New System.Drawing.Size(21, 24)
        Me.SaimtLabel49.TabIndex = 10
        Me.SaimtLabel49.Text = "       "
        '
        'SaimtLabel46
        '
        Me.SaimtLabel46.Location = New System.Drawing.Point(34, 133)
        Me.SaimtLabel46.Name = "SaimtLabel46"
        Me.SaimtLabel46.Size = New System.Drawing.Size(97, 13)
        Me.SaimtLabel46.TabIndex = 7
        Me.SaimtLabel46.Text = "Documento Recibido"
        '
        'SaimtLabel47
        '
        Me.SaimtLabel47.Appearance.ImageIndex = 7
        Me.SaimtLabel47.Appearance.ImageList = Me.ImageCollection2
        Me.SaimtLabel47.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel47.Location = New System.Drawing.Point(6, 128)
        Me.SaimtLabel47.Name = "SaimtLabel47"
        Me.SaimtLabel47.Size = New System.Drawing.Size(21, 22)
        Me.SaimtLabel47.TabIndex = 6
        Me.SaimtLabel47.Text = "       "
        '
        'SaimtLabel44
        '
        Me.SaimtLabel44.Location = New System.Drawing.Point(34, 111)
        Me.SaimtLabel44.Name = "SaimtLabel44"
        Me.SaimtLabel44.Size = New System.Drawing.Size(113, 13)
        Me.SaimtLabel44.TabIndex = 5
        Me.SaimtLabel44.Text = "Documento con Anexos"
        '
        'SaimtLabel45
        '
        Me.SaimtLabel45.Appearance.ImageIndex = 2
        Me.SaimtLabel45.Appearance.ImageList = Me.ImageCollection2
        Me.SaimtLabel45.Location = New System.Drawing.Point(6, 111)
        Me.SaimtLabel45.Name = "SaimtLabel45"
        Me.SaimtLabel45.Size = New System.Drawing.Size(21, 13)
        Me.SaimtLabel45.TabIndex = 4
        Me.SaimtLabel45.Text = "       "
        '
        'SaimtLabel39
        '
        Me.SaimtLabel39.Location = New System.Drawing.Point(34, 89)
        Me.SaimtLabel39.Name = "SaimtLabel39"
        Me.SaimtLabel39.Size = New System.Drawing.Size(82, 13)
        Me.SaimtLabel39.TabIndex = 3
        Me.SaimtLabel39.Text = "Documento Leído"
        '
        'SaimtLabel43
        '
        Me.SaimtLabel43.Appearance.ImageIndex = 1
        Me.SaimtLabel43.Appearance.ImageList = Me.ImageCollection2
        Me.SaimtLabel43.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel43.Location = New System.Drawing.Point(6, 84)
        Me.SaimtLabel43.Name = "SaimtLabel43"
        Me.SaimtLabel43.Size = New System.Drawing.Size(21, 23)
        Me.SaimtLabel43.TabIndex = 2
        Me.SaimtLabel43.Text = "       "
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(34, 66)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(95, 13)
        Me.SaimtLabel11.TabIndex = 1
        Me.SaimtLabel11.Text = "Documento No leído"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Appearance.ImageIndex = 0
        Me.SaimtLabel9.Appearance.ImageList = Me.ImageCollection2
        Me.SaimtLabel9.Location = New System.Drawing.Point(6, 66)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(21, 13)
        Me.SaimtLabel9.TabIndex = 0
        Me.SaimtLabel9.Text = "       "
        '
        'TxtBuscarPor
        '
        Me.TxtBuscarPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarPor.Location = New System.Drawing.Point(5, 127)
        Me.TxtBuscarPor.Name = "TxtBuscarPor"
        Me.TxtBuscarPor.Size = New System.Drawing.Size(263, 20)
        Me.TxtBuscarPor.TabIndex = 2
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox1.Controls.Add(Me.sTLBandeja)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(0, 155)
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(268, 308)
        Me.SaimtGroupBox1.TabIndex = 3
        Me.SaimtGroupBox1.Text = "Categoria Documentos"
        '
        'sTLBandeja
        '
        Me.sTLBandeja.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.tlCarPerId, Me.tlCargo})
        Me.sTLBandeja.ColumnsImageList = Me.ImageCollection1
        Me.sTLBandeja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sTLBandeja.Location = New System.Drawing.Point(2, 21)
        Me.sTLBandeja.LookAndFeel.SkinName = "Blue"
        Me.sTLBandeja.LookAndFeel.UseDefaultLookAndFeel = False
        Me.sTLBandeja.Name = "sTLBandeja"
        Me.sTLBandeja.OptionsBehavior.Editable = False
        Me.sTLBandeja.OptionsBehavior.ExpandNodesOnIncrementalSearch = True
        Me.sTLBandeja.OptionsSelection.InvertSelection = True
        Me.sTLBandeja.OptionsView.ShowHorzLines = False
        Me.sTLBandeja.OptionsView.ShowIndicator = False
        Me.sTLBandeja.OptionsView.ShowVertLines = False
        Me.sTLBandeja.SelectImageList = Me.ImageCollection1
        Me.sTLBandeja.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow
        Me.sTLBandeja.Size = New System.Drawing.Size(264, 285)
        Me.sTLBandeja.StateImageList = Me.ImageCollection1
        Me.sTLBandeja.TabIndex = 0
        '
        'tlCarPerId
        '
        Me.tlCarPerId.Caption = "CarPerId"
        Me.tlCarPerId.FieldName = "carPerId"
        Me.tlCarPerId.Name = "tlCarPerId"
        '
        'tlCargo
        '
        Me.tlCargo.MinWidth = 85
        Me.tlCargo.Name = "tlCargo"
        Me.tlCargo.Visible = True
        Me.tlCargo.VisibleIndex = 0
        Me.tlCargo.Width = 85
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "newspaper_go.png")
        Me.ImageCollection1.Images.SetKeyName(1, "basket_put.png")
        Me.ImageCollection1.Images.SetKeyName(2, "basket_remove.png")
        Me.ImageCollection1.Images.SetKeyName(3, "application_get.png")
        Me.ImageCollection1.Images.SetKeyName(4, "application_go.png")
        Me.ImageCollection1.Images.SetKeyName(5, "vcard.png")
        Me.ImageCollection1.Images.SetKeyName(6, "user_gray.png")
        Me.ImageCollection1.Images.SetKeyName(7, "email_go.png")
        Me.ImageCollection1.Images.SetKeyName(8, "email_open.png")
        Me.ImageCollection1.Images.SetKeyName(9, "script_go.png")
        Me.ImageCollection1.Images.SetKeyName(10, "group_go.png")
        Me.ImageCollection1.Images.SetKeyName(11, "Email-Attachment-icon.png")
        Me.ImageCollection1.Images.SetKeyName(12, "Email-icon.png")
        Me.ImageCollection1.Images.SetKeyName(13, "down-alt-icon.png")
        Me.ImageCollection1.Images.SetKeyName(14, "forward-alt-icon.png")
        Me.ImageCollection1.Images.SetKeyName(15, "page_white_put.png")
        Me.ImageCollection1.Images.SetKeyName(16, "user_trash_full.png")
        Me.ImageCollection1.Images.SetKeyName(17, "link.png")
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(8, 5)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(55, 13)
        Me.SaimtLabel4.TabIndex = 0
        Me.SaimtLabel4.Text = "Buscar por:"
        '
        'sRbtipoCriterio
        '
        Me.sRbtipoCriterio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sRbtipoCriterio.EditValue = "0"
        Me.sRbtipoCriterio.Location = New System.Drawing.Point(5, 59)
        Me.sRbtipoCriterio.Name = "sRbtipoCriterio"
        Me.sRbtipoCriterio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sRbtipoCriterio.Properties.Appearance.Options.UseBackColor = True
        Me.sRbtipoCriterio.Properties.Columns = 3
        Me.sRbtipoCriterio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("0", "N° Registro"), New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Asunto"), New DevExpress.XtraEditors.Controls.RadioGroupItem("3", "Remitente"), New DevExpress.XtraEditors.Controls.RadioGroupItem("4", "Cargo Remitente"), New DevExpress.XtraEditors.Controls.RadioGroupItem("5", "Destinatario"), New DevExpress.XtraEditors.Controls.RadioGroupItem("6", "Cargo Destinatario")})
        Me.sRbtipoCriterio.Size = New System.Drawing.Size(263, 62)
        Me.sRbtipoCriterio.TabIndex = 1
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.CheckButton1)
        Me.SaimtGroupBox2.Controls.Add(Me.btnAnularEnvio)
        Me.SaimtGroupBox2.Controls.Add(Me.btnExportargrilla)
        Me.SaimtGroupBox2.Controls.Add(Me.cbagrupar)
        Me.SaimtGroupBox2.Controls.Add(Me.dgvRemitente)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel55)
        Me.SaimtGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(748, 617)
        Me.SaimtGroupBox2.TabIndex = 0
        Me.SaimtGroupBox2.Text = "Visor de Documentos"
        '
        'CheckButton1
        '
        Me.CheckButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckButton1.Image = CType(resources.GetObject("CheckButton1.Image"), System.Drawing.Image)
        Me.CheckButton1.Location = New System.Drawing.Point(578, 92)
        Me.CheckButton1.LookAndFeel.SkinName = "Office 2007 Blue"
        Me.CheckButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CheckButton1.Name = "CheckButton1"
        Me.CheckButton1.Size = New System.Drawing.Size(78, 23)
        Me.CheckButton1.TabIndex = 6
        Me.CheckButton1.Text = "Vista GAF"
        Me.CheckButton1.Visible = False
        '
        'btnAnularEnvio
        '
        Me.btnAnularEnvio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnularEnvio.Image = CType(resources.GetObject("btnAnularEnvio.Image"), System.Drawing.Image)
        Me.btnAnularEnvio.Location = New System.Drawing.Point(662, 92)
        Me.btnAnularEnvio.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btnAnularEnvio.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAnularEnvio.Name = "btnAnularEnvio"
        Me.btnAnularEnvio.Size = New System.Drawing.Size(89, 23)
        Me.btnAnularEnvio.TabIndex = 5
        Me.btnAnularEnvio.Text = "Anular Envio"
        '
        'btnExportargrilla
        '
        Me.btnExportargrilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportargrilla.Image = CType(resources.GetObject("btnExportargrilla.Image"), System.Drawing.Image)
        Me.btnExportargrilla.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnExportargrilla.Location = New System.Drawing.Point(513, 42)
        Me.btnExportargrilla.LookAndFeel.SkinName = "Blue"
        Me.btnExportargrilla.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnExportargrilla.Name = "btnExportargrilla"
        Me.btnExportargrilla.Size = New System.Drawing.Size(87, 36)
        Me.btnExportargrilla.TabIndex = 4
        Me.btnExportargrilla.Text = "Exportar"
        Me.btnExportargrilla.ToolTip = "Exportar a Excel"
        '
        'cbagrupar
        '
        Me.cbagrupar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbagrupar.Location = New System.Drawing.Point(606, 51)
        Me.cbagrupar.LookAndFeel.SkinName = "Blue"
        Me.cbagrupar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cbagrupar.Name = "cbagrupar"
        Me.cbagrupar.Size = New System.Drawing.Size(147, 23)
        Me.cbagrupar.TabIndex = 1
        Me.cbagrupar.Text = "Mostrar agrupado por fecha"
        '
        'dgvRemitente
        '
        Me.dgvRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRemitente.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dgvRemitente.Location = New System.Drawing.Point(2, 34)
        Me.dgvRemitente.LookAndFeel.SkinName = "Blue"
        Me.dgvRemitente.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgvRemitente.MainView = Me.gvRemitente
        Me.dgvRemitente.MenuManager = Me.RibbonControl
        Me.dgvRemitente.Name = "dgvRemitente"
        Me.dgvRemitente.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ripcdestino, Me.riicmbadjunto, Me.riicmbprioridad, Me.riicmbleido, Me.riicmborigen, Me.ritxtcomentario, Me.ritxtAsunto, Me.riicmbenviado, Me.RepositoryItemCheckEdit3})
        Me.dgvRemitente.Size = New System.Drawing.Size(744, 581)
        Me.dgvRemitente.TabIndex = 0
        Me.dgvRemitente.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRemitente})
        '
        'gvRemitente
        '
        Me.gvRemitente.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcMovID, Me.gcDocId, Me.gctOrigen, Me.gcRecepcionado, Me.gcMovRead, Me.gcOrigen, Me.gcOrigenCargo, Me.cDestino, Me.gcDestinoCargo, Me.gcMovComentario, Me.gcDocNReg, Me.gcTipoDoc, Me.gcDocumento, Me.gcMovFechaEnvio, Me.gctgEstadoTramite, Me.gcTipoDestino, Me.gc_MovPara, Me.gcAsunto, Me.gcAdjunto, Me.gcGrupoMovFechaEnv, Me.gctgEstadoTramiteId, Me.gcmovgaf, Me.gcMovEnviado, Me.gcVinculado})
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.gcMovRead
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(148, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.gcmovgaf
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[movgaf]>=5"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(143, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Column = Me.gcmovgaf
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "4"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Column = Me.gcmovgaf
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = "3"
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(153, Byte), Integer))
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.gctgEstadoTramite
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Value1 = "Archivado"
        Me.gvRemitente.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5})
        Me.gvRemitente.GridControl = Me.dgvRemitente
        Me.gvRemitente.GroupCount = 1
        Me.gvRemitente.Images = Me.ImageCollection2
        Me.gvRemitente.Name = "gvRemitente"
        Me.gvRemitente.OptionsFind.AlwaysVisible = True
        Me.gvRemitente.OptionsFind.FindFilterColumns = "origen;cargoOrigen;destino;cargoDestino;movComentario;docNReg;movFechaEnvio;docAs" & _
    "unto"
        Me.gvRemitente.OptionsPrint.AutoWidth = False
        Me.gvRemitente.OptionsView.ColumnAutoWidth = False
        Me.gvRemitente.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvRemitente.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcTipoDestino, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcGrupoMovFechaEnv, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'gcMovID
        '
        Me.gcMovID.Caption = " "
        Me.gcMovID.FieldName = "movId"
        Me.gcMovID.Name = "gcMovID"
        Me.gcMovID.OptionsColumn.ReadOnly = True
        '
        'gcDocId
        '
        Me.gcDocId.Caption = "DocId "
        Me.gcDocId.FieldName = "docId"
        Me.gcDocId.Name = "gcDocId"
        Me.gcDocId.OptionsColumn.ReadOnly = True
        '
        'gctOrigen
        '
        Me.gctOrigen.Caption = " "
        Me.gctOrigen.ColumnEdit = Me.riicmborigen
        Me.gctOrigen.FieldName = "tOrigen"
        Me.gctOrigen.ImageIndex = 11
        Me.gctOrigen.Name = "gctOrigen"
        Me.gctOrigen.OptionsColumn.AllowEdit = False
        Me.gctOrigen.OptionsColumn.ReadOnly = True
        '
        'riicmborigen
        '
        Me.riicmborigen.AutoHeight = False
        Me.riicmborigen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riicmborigen.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.riicmborigen.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "1", 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "2", 6)})
        Me.riicmborigen.Name = "riicmborigen"
        Me.riicmborigen.SmallImages = Me.ImageCollection2
        '
        'gcRecepcionado
        '
        Me.gcRecepcionado.Caption = " "
        Me.gcRecepcionado.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.gcRecepcionado.FieldName = "movRecepcionado"
        Me.gcRecepcionado.Image = CType(resources.GetObject("gcRecepcionado.Image"), System.Drawing.Image)
        Me.gcRecepcionado.Name = "gcRecepcionado"
        Me.gcRecepcionado.Visible = True
        Me.gcRecepcionado.VisibleIndex = 0
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'gcOrigen
        '
        Me.gcOrigen.Caption = "Remitente"
        Me.gcOrigen.FieldName = "origen"
        Me.gcOrigen.Name = "gcOrigen"
        Me.gcOrigen.OptionsColumn.AllowEdit = False
        Me.gcOrigen.OptionsColumn.ReadOnly = True
        Me.gcOrigen.Visible = True
        Me.gcOrigen.VisibleIndex = 4
        '
        'gcOrigenCargo
        '
        Me.gcOrigenCargo.Caption = "Cargo Remitente"
        Me.gcOrigenCargo.FieldName = "cargoOrigen"
        Me.gcOrigenCargo.Name = "gcOrigenCargo"
        Me.gcOrigenCargo.OptionsColumn.AllowEdit = False
        Me.gcOrigenCargo.OptionsColumn.ReadOnly = True
        Me.gcOrigenCargo.Visible = True
        Me.gcOrigenCargo.VisibleIndex = 5
        Me.gcOrigenCargo.Width = 195
        '
        'cDestino
        '
        Me.cDestino.Caption = "Destinatario"
        Me.cDestino.ColumnEdit = Me.ripcdestino
        Me.cDestino.FieldName = "destino"
        Me.cDestino.Name = "cDestino"
        Me.cDestino.OptionsColumn.ReadOnly = True
        Me.cDestino.Visible = True
        Me.cDestino.VisibleIndex = 6
        '
        'ripcdestino
        '
        Me.ripcdestino.AutoHeight = False
        Me.ripcdestino.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ripcdestino.Name = "ripcdestino"
        '
        'gcDestinoCargo
        '
        Me.gcDestinoCargo.Caption = "Cargo Destinatario"
        Me.gcDestinoCargo.FieldName = "cargoDestino"
        Me.gcDestinoCargo.Name = "gcDestinoCargo"
        Me.gcDestinoCargo.OptionsColumn.AllowEdit = False
        Me.gcDestinoCargo.OptionsColumn.ReadOnly = True
        Me.gcDestinoCargo.Visible = True
        Me.gcDestinoCargo.VisibleIndex = 7
        '
        'gcMovComentario
        '
        Me.gcMovComentario.Caption = "Comentario de Envio"
        Me.gcMovComentario.ColumnEdit = Me.ritxtcomentario
        Me.gcMovComentario.FieldName = "movComentario"
        Me.gcMovComentario.Name = "gcMovComentario"
        Me.gcMovComentario.OptionsColumn.ReadOnly = True
        Me.gcMovComentario.Visible = True
        Me.gcMovComentario.VisibleIndex = 9
        '
        'ritxtcomentario
        '
        Me.ritxtcomentario.AutoHeight = False
        Me.ritxtcomentario.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ritxtcomentario.Name = "ritxtcomentario"
        Me.ritxtcomentario.ShowIcon = False
        '
        'gcDocNReg
        '
        Me.gcDocNReg.Caption = "Reg. Documento"
        Me.gcDocNReg.FieldName = "docNReg"
        Me.gcDocNReg.Name = "gcDocNReg"
        Me.gcDocNReg.OptionsColumn.AllowEdit = False
        Me.gcDocNReg.OptionsColumn.ReadOnly = True
        Me.gcDocNReg.Visible = True
        Me.gcDocNReg.VisibleIndex = 10
        '
        'gcTipoDoc
        '
        Me.gcTipoDoc.Caption = "Tipo Doc."
        Me.gcTipoDoc.FieldName = "tgTipoDoc"
        Me.gcTipoDoc.Name = "gcTipoDoc"
        Me.gcTipoDoc.OptionsColumn.AllowEdit = False
        Me.gcTipoDoc.OptionsColumn.ReadOnly = True
        Me.gcTipoDoc.Visible = True
        Me.gcTipoDoc.VisibleIndex = 11
        '
        'gcDocumento
        '
        Me.gcDocumento.Caption = "Cod Documento "
        Me.gcDocumento.FieldName = "docAux"
        Me.gcDocumento.Name = "gcDocumento"
        Me.gcDocumento.Visible = True
        Me.gcDocumento.VisibleIndex = 12
        '
        'gcMovFechaEnvio
        '
        Me.gcMovFechaEnvio.Caption = "Fecha Envio"
        Me.gcMovFechaEnvio.FieldName = "movFechaEnvio"
        Me.gcMovFechaEnvio.Name = "gcMovFechaEnvio"
        Me.gcMovFechaEnvio.OptionsColumn.AllowEdit = False
        Me.gcMovFechaEnvio.OptionsColumn.ReadOnly = True
        Me.gcMovFechaEnvio.Visible = True
        Me.gcMovFechaEnvio.VisibleIndex = 8
        '
        'gcTipoDestino
        '
        Me.gcTipoDestino.Caption = "Acción a adoptar"
        Me.gcTipoDestino.FieldName = "tgTipoDestino"
        Me.gcTipoDestino.Name = "gcTipoDestino"
        Me.gcTipoDestino.OptionsColumn.AllowEdit = False
        Me.gcTipoDestino.OptionsColumn.ReadOnly = True
        Me.gcTipoDestino.Visible = True
        Me.gcTipoDestino.VisibleIndex = 9
        '
        'gc_MovPara
        '
        Me.gc_MovPara.Caption = "MovPara"
        Me.gc_MovPara.FieldName = "movPara"
        Me.gc_MovPara.Name = "gc_MovPara"
        Me.gc_MovPara.OptionsColumn.ReadOnly = True
        '
        'gcAsunto
        '
        Me.gcAsunto.Caption = "Asunto"
        Me.gcAsunto.ColumnEdit = Me.ritxtAsunto
        Me.gcAsunto.FieldName = "docAsunto"
        Me.gcAsunto.Name = "gcAsunto"
        Me.gcAsunto.OptionsColumn.ReadOnly = True
        Me.gcAsunto.Visible = True
        Me.gcAsunto.VisibleIndex = 3
        '
        'ritxtAsunto
        '
        Me.ritxtAsunto.AutoHeight = False
        Me.ritxtAsunto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ritxtAsunto.Name = "ritxtAsunto"
        Me.ritxtAsunto.ShowIcon = False
        '
        'gcAdjunto
        '
        Me.gcAdjunto.Caption = " "
        Me.gcAdjunto.ColumnEdit = Me.riicmbadjunto
        Me.gcAdjunto.FieldName = "conAnexo"
        Me.gcAdjunto.ImageIndex = 2
        Me.gcAdjunto.Name = "gcAdjunto"
        Me.gcAdjunto.OptionsColumn.AllowEdit = False
        Me.gcAdjunto.OptionsColumn.ReadOnly = True
        Me.gcAdjunto.ToolTip = "Contiene Anexos ?"
        '
        'riicmbadjunto
        '
        Me.riicmbadjunto.AutoHeight = False
        Me.riicmbadjunto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riicmbadjunto.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.riicmbadjunto.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", True, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", False, -1)})
        Me.riicmbadjunto.Name = "riicmbadjunto"
        Me.riicmbadjunto.SmallImages = Me.ImageCollection2
        '
        'gcGrupoMovFechaEnv
        '
        Me.gcGrupoMovFechaEnv.Caption = "Fecha Envio"
        Me.gcGrupoMovFechaEnv.FieldName = "grupomovFechaEnvio"
        Me.gcGrupoMovFechaEnv.Name = "gcGrupoMovFechaEnv"
        Me.gcGrupoMovFechaEnv.OptionsColumn.AllowEdit = False
        Me.gcGrupoMovFechaEnv.OptionsColumn.ReadOnly = True
        '
        'gctgEstadoTramiteId
        '
        Me.gctgEstadoTramiteId.Caption = "GridColumn8"
        Me.gctgEstadoTramiteId.Name = "gctgEstadoTramiteId"
        Me.gctgEstadoTramiteId.OptionsColumn.ReadOnly = True
        '
        'gcMovEnviado
        '
        Me.gcMovEnviado.Caption = " "
        Me.gcMovEnviado.ColumnEdit = Me.riicmbenviado
        Me.gcMovEnviado.FieldName = "movEnviado"
        Me.gcMovEnviado.ImageIndex = 12
        Me.gcMovEnviado.Name = "gcMovEnviado"
        Me.gcMovEnviado.Visible = True
        Me.gcMovEnviado.VisibleIndex = 2
        '
        'riicmbenviado
        '
        Me.riicmbenviado.AutoHeight = False
        Me.riicmbenviado.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riicmbenviado.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", True, 12), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", False, -1)})
        Me.riicmbenviado.Name = "riicmbenviado"
        Me.riicmbenviado.SmallImages = Me.ImageCollection2
        '
        'gcVinculado
        '
        Me.gcVinculado.Caption = " "
        Me.gcVinculado.FieldName = "movVinculado"
        Me.gcVinculado.ImageIndex = 2
        Me.gcVinculado.Name = "gcVinculado"
        Me.gcVinculado.Visible = True
        Me.gcVinculado.VisibleIndex = 1
        '
        'riicmbprioridad
        '
        Me.riicmbprioridad.AutoHeight = False
        Me.riicmbprioridad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riicmbprioridad.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.riicmbprioridad.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "1", 10), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "2", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "3", 9)})
        Me.riicmbprioridad.Name = "riicmbprioridad"
        Me.riicmbprioridad.SmallImages = Me.ImageCollection2
        '
        'SaimtLabel55
        '
        Me.SaimtLabel55.Dock = System.Windows.Forms.DockStyle.Top
        Me.SaimtLabel55.Location = New System.Drawing.Point(2, 21)
        Me.SaimtLabel55.Name = "SaimtLabel55"
        Me.SaimtLabel55.Size = New System.Drawing.Size(174, 13)
        Me.SaimtLabel55.TabIndex = 3
        Me.SaimtLabel55.Text = "Sub Busqueda para la lista mostrada"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SaimtLabel70)
        Me.PanelControl1.Controls.Add(Me.btnPagUltimo)
        Me.PanelControl1.Controls.Add(Me.btnPagAdelante)
        Me.PanelControl1.Controls.Add(Me.btnPagAtras)
        Me.PanelControl1.Controls.Add(Me.btnPagInicio)
        Me.PanelControl1.Controls.Add(Me.SaimtLabel69)
        Me.PanelControl1.Controls.Add(Me.txtNActual)
        Me.PanelControl1.Controls.Add(Me.SaimtLabel58)
        Me.PanelControl1.Controls.Add(Me.chkMostrarNrow)
        Me.PanelControl1.Controls.Add(Me.txtNRegistros)
        Me.PanelControl1.Controls.Add(Me.SaimtLabel42)
        Me.PanelControl1.Controls.Add(Me.ssNrow)
        Me.PanelControl1.Controls.Add(Me.dtpfechaIngDoc)
        Me.PanelControl1.Controls.Add(Me.chkMovFechaEnv)
        Me.PanelControl1.Controls.Add(Me.SaimtLabel54)
        Me.PanelControl1.Controls.Add(Me.cboAccion)
        Me.PanelControl1.Controls.Add(Me.btnrefrescar)
        Me.PanelControl1.Controls.Add(Me.btnTerminar)
        Me.PanelControl1.Controls.Add(Me.btnAbrirDoc)
        Me.PanelControl1.Controls.Add(Me.btnImprimirFlujo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 617)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(748, 76)
        Me.PanelControl1.TabIndex = 1
        '
        'SaimtLabel70
        '
        Me.SaimtLabel70.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel70.Location = New System.Drawing.Point(159, 7)
        Me.SaimtLabel70.Name = "SaimtLabel70"
        Me.SaimtLabel70.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel70.TabIndex = 19
        Me.SaimtLabel70.Text = "registros"
        '
        'btnPagUltimo
        '
        Me.btnPagUltimo.Location = New System.Drawing.Point(234, 44)
        Me.btnPagUltimo.Name = "btnPagUltimo"
        Me.btnPagUltimo.Size = New System.Drawing.Size(27, 23)
        Me.btnPagUltimo.TabIndex = 18
        Me.btnPagUltimo.Text = ">>"
        '
        'btnPagAdelante
        '
        Me.btnPagAdelante.Location = New System.Drawing.Point(201, 44)
        Me.btnPagAdelante.Name = "btnPagAdelante"
        Me.btnPagAdelante.Size = New System.Drawing.Size(27, 23)
        Me.btnPagAdelante.TabIndex = 17
        Me.btnPagAdelante.Text = ">"
        '
        'btnPagAtras
        '
        Me.btnPagAtras.Location = New System.Drawing.Point(40, 43)
        Me.btnPagAtras.Name = "btnPagAtras"
        Me.btnPagAtras.Size = New System.Drawing.Size(27, 23)
        Me.btnPagAtras.TabIndex = 16
        Me.btnPagAtras.Text = "<"
        '
        'btnPagInicio
        '
        Me.btnPagInicio.Location = New System.Drawing.Point(7, 43)
        Me.btnPagInicio.Name = "btnPagInicio"
        Me.btnPagInicio.Size = New System.Drawing.Size(27, 23)
        Me.btnPagInicio.TabIndex = 15
        Me.btnPagInicio.Text = "<<"
        '
        'SaimtLabel69
        '
        Me.SaimtLabel69.Location = New System.Drawing.Point(146, 50)
        Me.SaimtLabel69.Name = "SaimtLabel69"
        Me.SaimtLabel69.Size = New System.Drawing.Size(12, 13)
        Me.SaimtLabel69.TabIndex = 14
        Me.SaimtLabel69.Text = "de"
        '
        'txtNActual
        '
        Me.txtNActual.Enabled = False
        Me.txtNActual.Location = New System.Drawing.Point(108, 46)
        Me.txtNActual.MenuManager = Me.RibbonControl
        Me.txtNActual.Name = "txtNActual"
        Me.txtNActual.Size = New System.Drawing.Size(34, 20)
        Me.txtNActual.TabIndex = 13
        '
        'SaimtLabel58
        '
        Me.SaimtLabel58.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel58.Location = New System.Drawing.Point(340, 6)
        Me.SaimtLabel58.Name = "SaimtLabel58"
        Me.SaimtLabel58.Size = New System.Drawing.Size(353, 13)
        Me.SaimtLabel58.TabIndex = 12
        Me.SaimtLabel58.Text = "Muestra los documentos que seran enviados segun la acción seleccionada"
        Me.SaimtLabel58.Visible = False
        '
        'chkMostrarNrow
        '
        Me.chkMostrarNrow.Location = New System.Drawing.Point(9, 4)
        Me.chkMostrarNrow.MenuManager = Me.RibbonControl
        Me.chkMostrarNrow.Name = "chkMostrarNrow"
        Me.chkMostrarNrow.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarNrow.Properties.Appearance.Options.UseFont = True
        Me.chkMostrarNrow.Properties.AutoWidth = True
        Me.chkMostrarNrow.Properties.Caption = "Mostrando :"
        Me.chkMostrarNrow.Size = New System.Drawing.Size(89, 19)
        Me.chkMostrarNrow.TabIndex = 11
        '
        'txtNRegistros
        '
        Me.txtNRegistros.Enabled = False
        Me.txtNRegistros.Location = New System.Drawing.Point(161, 46)
        Me.txtNRegistros.MenuManager = Me.RibbonControl
        Me.txtNRegistros.Name = "txtNRegistros"
        Me.txtNRegistros.Size = New System.Drawing.Size(34, 20)
        Me.txtNRegistros.TabIndex = 10
        '
        'SaimtLabel42
        '
        Me.SaimtLabel42.Location = New System.Drawing.Point(73, 50)
        Me.SaimtLabel42.Name = "SaimtLabel42"
        Me.SaimtLabel42.Size = New System.Drawing.Size(32, 13)
        Me.SaimtLabel42.TabIndex = 9
        Me.SaimtLabel42.Text = "Pagina"
        '
        'ssNrow
        '
        Me.ssNrow.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ssNrow.Location = New System.Drawing.Point(101, 4)
        Me.ssNrow.MenuManager = Me.RibbonControl
        Me.ssNrow.Name = "ssNrow"
        Me.ssNrow.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssNrow.Properties.Appearance.Options.UseFont = True
        Me.ssNrow.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ssNrow.Properties.Mask.EditMask = "n0"
        Me.ssNrow.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.ssNrow.Size = New System.Drawing.Size(52, 20)
        Me.ssNrow.TabIndex = 3
        '
        'dtpfechaIngDoc
        '
        Me.dtpfechaIngDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpfechaIngDoc.EditValue = Nothing
        Me.dtpfechaIngDoc.Location = New System.Drawing.Point(593, 48)
        Me.dtpfechaIngDoc.MenuManager = Me.RibbonControl
        Me.dtpfechaIngDoc.Name = "dtpfechaIngDoc"
        Me.dtpfechaIngDoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpfechaIngDoc.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpfechaIngDoc.Size = New System.Drawing.Size(100, 20)
        Me.dtpfechaIngDoc.TabIndex = 2
        Me.dtpfechaIngDoc.Visible = False
        '
        'chkMovFechaEnv
        '
        Me.chkMovFechaEnv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMovFechaEnv.Location = New System.Drawing.Point(564, 48)
        Me.chkMovFechaEnv.MenuManager = Me.RibbonControl
        Me.chkMovFechaEnv.Name = "chkMovFechaEnv"
        Me.chkMovFechaEnv.Properties.AutoWidth = True
        Me.chkMovFechaEnv.Properties.Caption = ""
        Me.chkMovFechaEnv.Size = New System.Drawing.Size(19, 19)
        Me.chkMovFechaEnv.TabIndex = 8
        Me.chkMovFechaEnv.Visible = False
        '
        'SaimtLabel54
        '
        Me.SaimtLabel54.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtLabel54.Location = New System.Drawing.Point(549, 28)
        Me.SaimtLabel54.Name = "SaimtLabel54"
        Me.SaimtLabel54.Size = New System.Drawing.Size(38, 13)
        Me.SaimtLabel54.TabIndex = 7
        Me.SaimtLabel54.Text = "Accion :"
        Me.SaimtLabel54.Visible = False
        '
        'cboAccion
        '
        Me.cboAccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAccion.Location = New System.Drawing.Point(593, 25)
        Me.cboAccion.MenuManager = Me.RibbonControl
        Me.cboAccion.Name = "cboAccion"
        Me.cboAccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAccion.Properties.NullText = ""
        Me.cboAccion.Size = New System.Drawing.Size(100, 20)
        Me.cboAccion.TabIndex = 5
        Me.cboAccion.Visible = False
        '
        'btnrefrescar
        '
        Me.btnrefrescar.Image = CType(resources.GetObject("btnrefrescar.Image"), System.Drawing.Image)
        Me.btnrefrescar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnrefrescar.Location = New System.Drawing.Point(420, 7)
        Me.btnrefrescar.LookAndFeel.SkinName = "Seven"
        Me.btnrefrescar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnrefrescar.Name = "btnrefrescar"
        Me.btnrefrescar.Size = New System.Drawing.Size(64, 64)
        Me.btnrefrescar.TabIndex = 3
        Me.btnrefrescar.Text = "Refrescar"
        Me.btnrefrescar.ToolTip = "Refrescar"
        '
        'btnTerminar
        '
        Me.btnTerminar.Image = CType(resources.GetObject("btnTerminar.Image"), System.Drawing.Image)
        Me.btnTerminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnTerminar.Location = New System.Drawing.Point(350, 7)
        Me.btnTerminar.LookAndFeel.SkinName = "Seven"
        Me.btnTerminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(64, 64)
        Me.btnTerminar.TabIndex = 2
        Me.btnTerminar.Text = "Cambiar Estado Tramite"
        Me.btnTerminar.ToolTip = "Cambiar Estado Tramite"
        '
        'btnAbrirDoc
        '
        Me.btnAbrirDoc.Image = CType(resources.GetObject("btnAbrirDoc.Image"), System.Drawing.Image)
        Me.btnAbrirDoc.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAbrirDoc.Location = New System.Drawing.Point(280, 7)
        Me.btnAbrirDoc.LookAndFeel.SkinName = "Seven"
        Me.btnAbrirDoc.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnAbrirDoc.Name = "btnAbrirDoc"
        Me.btnAbrirDoc.Size = New System.Drawing.Size(64, 64)
        Me.btnAbrirDoc.TabIndex = 0
        Me.btnAbrirDoc.Text = "Ver Documento"
        Me.btnAbrirDoc.ToolTip = "Ver Documento"
        '
        'btnImprimirFlujo
        '
        Me.btnImprimirFlujo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirFlujo.Image = CType(resources.GetObject("btnImprimirFlujo.Image"), System.Drawing.Image)
        Me.btnImprimirFlujo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImprimirFlujo.Location = New System.Drawing.Point(700, 4)
        Me.btnImprimirFlujo.LookAndFeel.SkinName = "Seven"
        Me.btnImprimirFlujo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnImprimirFlujo.Name = "btnImprimirFlujo"
        Me.btnImprimirFlujo.Size = New System.Drawing.Size(64, 64)
        Me.btnImprimirFlujo.TabIndex = 1
        Me.btnImprimirFlujo.Text = "Imprimir Flujo"
        Me.btnImprimirFlujo.ToolTip = "Imprimir Flujo"
        Me.btnImprimirFlujo.Visible = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GBoxDatosDocumento)
        Me.XtraTabPage2.Controls.Add(Me.GBoxDatosAdicionales)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1022, 693)
        Me.XtraTabPage2.Text = "Envio Documentos"
        '
        'GBoxDatosDocumento
        '
        Me.GBoxDatosDocumento.Controls.Add(Me.btnVisorDoc)
        Me.GBoxDatosDocumento.Controls.Add(Me.txtDocumentoAux)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel35)
        Me.GBoxDatosDocumento.Controls.Add(Me.txtMovDoc)
        Me.GBoxDatosDocumento.Controls.Add(Me.TxtTipoDoc)
        Me.GBoxDatosDocumento.Controls.Add(Me.TxtPrioridad)
        Me.GBoxDatosDocumento.Controls.Add(Me.txtDocFecha)
        Me.GBoxDatosDocumento.Controls.Add(Me.txtDocFechaIng)
        Me.GBoxDatosDocumento.Controls.Add(Me.btnSiguiente)
        Me.GBoxDatosDocumento.Controls.Add(Me.btnAtras)
        Me.GBoxDatosDocumento.Controls.Add(Me.btnReenviar)
        Me.GBoxDatosDocumento.Controls.Add(Me.btnVolver)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtButton4)
        Me.GBoxDatosDocumento.Controls.Add(Me.TxtProcedimiento)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel33)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel32)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel31)
        Me.GBoxDatosDocumento.Controls.Add(Me.txtdocid)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel1)
        Me.GBoxDatosDocumento.Controls.Add(Me.txtvinId)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel27)
        Me.GBoxDatosDocumento.Controls.Add(Me.btnAnexos)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtGroupBox6)
        Me.GBoxDatosDocumento.Controls.Add(Me.txtasunto)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel10)
        Me.GBoxDatosDocumento.Controls.Add(Me.sRdbOrigen)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel3)
        Me.GBoxDatosDocumento.Controls.Add(Me.chkReqActivos)
        Me.GBoxDatosDocumento.Controls.Add(Me.sRbTupac)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel5)
        Me.GBoxDatosDocumento.Controls.Add(Me.ssFolios)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel6)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel13)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel8)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel7)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel34)
        Me.GBoxDatosDocumento.Location = New System.Drawing.Point(10, 2)
        Me.GBoxDatosDocumento.Name = "GBoxDatosDocumento"
        Me.GBoxDatosDocumento.Size = New System.Drawing.Size(1035, 350)
        Me.GBoxDatosDocumento.TabIndex = 0
        Me.GBoxDatosDocumento.Text = "Datos del Documento"
        '
        'btnVisorDoc
        '
        Me.btnVisorDoc.Image = CType(resources.GetObject("btnVisorDoc.Image"), System.Drawing.Image)
        Me.btnVisorDoc.Location = New System.Drawing.Point(632, 327)
        Me.btnVisorDoc.Name = "btnVisorDoc"
        Me.btnVisorDoc.Size = New System.Drawing.Size(25, 21)
        Me.btnVisorDoc.TabIndex = 36
        '
        'txtDocumentoAux
        '
        Me.txtDocumentoAux.Location = New System.Drawing.Point(190, 92)
        Me.txtDocumentoAux.MenuManager = Me.RibbonControl
        Me.txtDocumentoAux.Name = "txtDocumentoAux"
        Me.txtDocumentoAux.Size = New System.Drawing.Size(509, 20)
        Me.txtDocumentoAux.TabIndex = 41
        '
        'SaimtLabel35
        '
        Me.SaimtLabel35.Location = New System.Drawing.Point(193, 77)
        Me.SaimtLabel35.Name = "SaimtLabel35"
        Me.SaimtLabel35.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel35.TabIndex = 40
        Me.SaimtLabel35.Text = "N° Documento"
        '
        'txtMovDoc
        '
        Me.txtMovDoc.Location = New System.Drawing.Point(12, 92)
        Me.txtMovDoc.Name = "txtMovDoc"
        Me.txtMovDoc.Size = New System.Drawing.Size(172, 20)
        Me.txtMovDoc.TabIndex = 39
        '
        'TxtTipoDoc
        '
        Me.TxtTipoDoc.Location = New System.Drawing.Point(317, 51)
        Me.TxtTipoDoc.Name = "TxtTipoDoc"
        Me.TxtTipoDoc.Size = New System.Drawing.Size(356, 20)
        Me.TxtTipoDoc.TabIndex = 38
        '
        'TxtPrioridad
        '
        Me.TxtPrioridad.Location = New System.Drawing.Point(101, 326)
        Me.TxtPrioridad.Name = "TxtPrioridad"
        Me.TxtPrioridad.Size = New System.Drawing.Size(143, 20)
        Me.TxtPrioridad.TabIndex = 37
        '
        'txtDocFecha
        '
        Me.txtDocFecha.Location = New System.Drawing.Point(744, 191)
        Me.txtDocFecha.Name = "txtDocFecha"
        Me.txtDocFecha.Size = New System.Drawing.Size(212, 20)
        Me.txtDocFecha.TabIndex = 36
        '
        'txtDocFechaIng
        '
        Me.txtDocFechaIng.Location = New System.Drawing.Point(494, 191)
        Me.txtDocFechaIng.Name = "txtDocFechaIng"
        Me.txtDocFechaIng.Size = New System.Drawing.Size(172, 20)
        Me.txtDocFechaIng.TabIndex = 35
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSiguiente.Location = New System.Drawing.Point(761, 35)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(45, 39)
        Me.btnSiguiente.TabIndex = 10
        '
        'btnAtras
        '
        Me.btnAtras.Image = CType(resources.GetObject("btnAtras.Image"), System.Drawing.Image)
        Me.btnAtras.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAtras.Location = New System.Drawing.Point(712, 35)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(45, 39)
        Me.btnAtras.TabIndex = 9
        '
        'btnReenviar
        '
        Me.btnReenviar.Image = CType(resources.GetObject("btnReenviar.Image"), System.Drawing.Image)
        Me.btnReenviar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnReenviar.Location = New System.Drawing.Point(912, 35)
        Me.btnReenviar.LookAndFeel.SkinName = "Seven"
        Me.btnReenviar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnReenviar.Name = "btnReenviar"
        Me.btnReenviar.Size = New System.Drawing.Size(44, 39)
        Me.btnReenviar.TabIndex = 13
        Me.btnReenviar.Text = "Reenviar"
        '
        'btnVolver
        '
        Me.btnVolver.Image = CType(resources.GetObject("btnVolver.Image"), System.Drawing.Image)
        Me.btnVolver.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnVolver.Location = New System.Drawing.Point(812, 35)
        Me.btnVolver.LookAndFeel.SkinName = "Seven"
        Me.btnVolver.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(45, 39)
        Me.btnVolver.TabIndex = 11
        Me.btnVolver.Text = "Reenviar"
        '
        'SaimtButton4
        '
        Me.SaimtButton4.Image = CType(resources.GetObject("SaimtButton4.Image"), System.Drawing.Image)
        Me.SaimtButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SaimtButton4.Location = New System.Drawing.Point(863, 37)
        Me.SaimtButton4.LookAndFeel.SkinName = "Seven"
        Me.SaimtButton4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SaimtButton4.Name = "SaimtButton4"
        Me.SaimtButton4.Size = New System.Drawing.Size(43, 37)
        Me.SaimtButton4.TabIndex = 12
        Me.SaimtButton4.Text = "Imprimir Flujo"
        '
        'TxtProcedimiento
        '
        Me.TxtProcedimiento.Location = New System.Drawing.Point(101, 221)
        Me.TxtProcedimiento.MenuManager = Me.RibbonControl
        Me.TxtProcedimiento.Name = "TxtProcedimiento"
        Me.TxtProcedimiento.Size = New System.Drawing.Size(855, 20)
        Me.TxtProcedimiento.TabIndex = 24
        '
        'SaimtLabel33
        '
        Me.SaimtLabel33.Location = New System.Drawing.Point(12, 77)
        Me.SaimtLabel33.Name = "SaimtLabel33"
        Me.SaimtLabel33.Size = New System.Drawing.Size(128, 13)
        Me.SaimtLabel33.TabIndex = 3
        Me.SaimtLabel33.Text = "Movimiento del Documento"
        '
        'SaimtLabel32
        '
        Me.SaimtLabel32.Location = New System.Drawing.Point(145, 40)
        Me.SaimtLabel32.Name = "SaimtLabel32"
        Me.SaimtLabel32.Size = New System.Drawing.Size(0, 13)
        Me.SaimtLabel32.TabIndex = 4
        '
        'SaimtLabel31
        '
        Me.SaimtLabel31.Location = New System.Drawing.Point(684, 194)
        Me.SaimtLabel31.Name = "SaimtLabel31"
        Me.SaimtLabel31.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel31.TabIndex = 21
        Me.SaimtLabel31.Text = "Fecha Doc."
        '
        'txtdocid
        '
        Me.txtdocid.Location = New System.Drawing.Point(101, 191)
        Me.txtdocid.MenuManager = Me.RibbonControl
        Me.txtdocid.Name = "txtdocid"
        Me.txtdocid.Size = New System.Drawing.Size(143, 20)
        Me.txtdocid.TabIndex = 16
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(46, 194)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(48, 13)
        Me.SaimtLabel1.TabIndex = 15
        Me.SaimtLabel1.Text = "Cod. Doc."
        '
        'txtvinId
        '
        Me.txtvinId.Location = New System.Drawing.Point(337, 327)
        Me.txtvinId.MenuManager = Me.RibbonControl
        Me.txtvinId.Name = "txtvinId"
        Me.txtvinId.Size = New System.Drawing.Size(290, 20)
        Me.txtvinId.TabIndex = 31
        '
        'SaimtLabel27
        '
        Me.SaimtLabel27.Location = New System.Drawing.Point(252, 330)
        Me.SaimtLabel27.Name = "SaimtLabel27"
        Me.SaimtLabel27.Size = New System.Drawing.Size(79, 13)
        Me.SaimtLabel27.TabIndex = 32
        Me.SaimtLabel27.Text = "Doc. Vinculado a"
        '
        'btnAnexos
        '
        Me.btnAnexos.Image = CType(resources.GetObject("btnAnexos.Image"), System.Drawing.Image)
        Me.btnAnexos.Location = New System.Drawing.Point(816, 6)
        Me.btnAnexos.Name = "btnAnexos"
        Me.btnAnexos.Size = New System.Drawing.Size(143, 23)
        Me.btnAnexos.TabIndex = 34
        Me.btnAnexos.Text = "Ver Documentos Anexos"
        '
        'SaimtGroupBox6
        '
        Me.SaimtGroupBox6.Controls.Add(Me.txtArea)
        Me.SaimtGroupBox6.Controls.Add(Me.txtIntitucion)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel19)
        Me.SaimtGroupBox6.Controls.Add(Me.TxtNdocReg)
        Me.SaimtGroupBox6.Controls.Add(Me.txtAño)
        Me.SaimtGroupBox6.Controls.Add(Me.sTxtSiglas)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel22)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel21)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel20)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel26)
        Me.SaimtGroupBox6.Controls.Add(Me.ssDocParte)
        Me.SaimtGroupBox6.Location = New System.Drawing.Point(6, 117)
        Me.SaimtGroupBox6.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox6.Name = "SaimtGroupBox6"
        Me.SaimtGroupBox6.Size = New System.Drawing.Size(998, 52)
        Me.SaimtGroupBox6.TabIndex = 14
        Me.SaimtGroupBox6.Text = "N° de Registro del Documento"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(756, 26)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(234, 20)
        Me.txtArea.TabIndex = 11
        '
        'txtIntitucion
        '
        Me.txtIntitucion.Location = New System.Drawing.Point(440, 25)
        Me.txtIntitucion.Name = "txtIntitucion"
        Me.txtIntitucion.Size = New System.Drawing.Size(282, 20)
        Me.txtIntitucion.TabIndex = 10
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(727, 28)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(23, 13)
        Me.SaimtLabel2.TabIndex = 8
        Me.SaimtLabel2.Text = "Área"
        '
        'SaimtLabel19
        '
        Me.SaimtLabel19.Location = New System.Drawing.Point(10, 28)
        Me.SaimtLabel19.Name = "SaimtLabel19"
        Me.SaimtLabel19.Size = New System.Drawing.Size(37, 13)
        Me.SaimtLabel19.TabIndex = 0
        Me.SaimtLabel19.Text = "Nº Doc."
        '
        'TxtNdocReg
        '
        Me.TxtNdocReg.Location = New System.Drawing.Point(53, 25)
        Me.TxtNdocReg.Name = "TxtNdocReg"
        Me.TxtNdocReg.Size = New System.Drawing.Size(55, 20)
        Me.TxtNdocReg.TabIndex = 1
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(233, 25)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(55, 20)
        Me.txtAño.TabIndex = 3
        '
        'sTxtSiglas
        '
        Me.sTxtSiglas.Location = New System.Drawing.Point(323, 25)
        Me.sTxtSiglas.Name = "sTxtSiglas"
        Me.sTxtSiglas.Size = New System.Drawing.Size(55, 20)
        Me.sTxtSiglas.TabIndex = 5
        '
        'SaimtLabel22
        '
        Me.SaimtLabel22.Location = New System.Drawing.Point(384, 28)
        Me.SaimtLabel22.Name = "SaimtLabel22"
        Me.SaimtLabel22.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel22.TabIndex = 6
        Me.SaimtLabel22.Text = "Institución"
        '
        'SaimtLabel21
        '
        Me.SaimtLabel21.Location = New System.Drawing.Point(295, 28)
        Me.SaimtLabel21.Name = "SaimtLabel21"
        Me.SaimtLabel21.Size = New System.Drawing.Size(27, 13)
        Me.SaimtLabel21.TabIndex = 4
        Me.SaimtLabel21.Text = "Siglas"
        '
        'SaimtLabel20
        '
        Me.SaimtLabel20.Location = New System.Drawing.Point(211, 28)
        Me.SaimtLabel20.Name = "SaimtLabel20"
        Me.SaimtLabel20.Size = New System.Drawing.Size(19, 13)
        Me.SaimtLabel20.TabIndex = 2
        Me.SaimtLabel20.Text = "Año"
        '
        'SaimtLabel26
        '
        Me.SaimtLabel26.Location = New System.Drawing.Point(114, 28)
        Me.SaimtLabel26.Name = "SaimtLabel26"
        Me.SaimtLabel26.Size = New System.Drawing.Size(26, 13)
        Me.SaimtLabel26.TabIndex = 29
        Me.SaimtLabel26.Text = "Parte"
        '
        'ssDocParte
        '
        Me.ssDocParte.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ssDocParte.Location = New System.Drawing.Point(141, 25)
        Me.ssDocParte.MenuManager = Me.RibbonControl
        Me.ssDocParte.Name = "ssDocParte"
        Me.ssDocParte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ssDocParte.Properties.Mask.EditMask = "n0"
        Me.ssDocParte.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.ssDocParte.Size = New System.Drawing.Size(64, 20)
        Me.ssDocParte.TabIndex = 30
        '
        'txtasunto
        '
        Me.txtasunto.Location = New System.Drawing.Point(101, 251)
        Me.txtasunto.MenuManager = Me.RibbonControl
        Me.txtasunto.Name = "txtasunto"
        Me.txtasunto.Size = New System.Drawing.Size(855, 67)
        Me.txtasunto.TabIndex = 26
        Me.txtasunto.UseOptimizedRendering = True
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(61, 253)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(34, 13)
        Me.SaimtLabel10.TabIndex = 25
        Me.SaimtLabel10.Text = "Asunto"
        '
        'sRdbOrigen
        '
        Me.sRdbOrigen.Location = New System.Drawing.Point(12, 49)
        Me.sRdbOrigen.Name = "sRdbOrigen"
        Me.sRdbOrigen.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Doc. Interno"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Doc. Externo")})
        Me.sRdbOrigen.Size = New System.Drawing.Size(201, 22)
        Me.sRdbOrigen.TabIndex = 5
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(14, 30)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(89, 13)
        Me.SaimtLabel3.TabIndex = 0
        Me.SaimtLabel3.Text = "Origen Documento"
        '
        'chkReqActivos
        '
        Me.chkReqActivos.Location = New System.Drawing.Point(675, 327)
        Me.chkReqActivos.MenuManager = Me.RibbonControl
        Me.chkReqActivos.Name = "chkReqActivos"
        Me.chkReqActivos.Properties.AutoWidth = True
        Me.chkReqActivos.Properties.Caption = "Active el check si todos los Requisitos estan completos."
        Me.chkReqActivos.Size = New System.Drawing.Size(286, 19)
        Me.chkReqActivos.TabIndex = 33
        '
        'sRbTupac
        '
        Me.sRbTupac.Location = New System.Drawing.Point(219, 51)
        Me.sRbTupac.Name = "sRbTupac"
        Me.sRbTupac.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Si"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "No")})
        Me.sRbTupac.Size = New System.Drawing.Size(91, 20)
        Me.sRbTupac.TabIndex = 6
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(222, 30)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(26, 13)
        Me.SaimtLabel5.TabIndex = 1
        Me.SaimtLabel5.Text = "TUPA"
        '
        'ssFolios
        '
        Me.ssFolios.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ssFolios.Location = New System.Drawing.Point(330, 191)
        Me.ssFolios.Name = "ssFolios"
        Me.ssFolios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ssFolios.Properties.Mask.EditMask = "n0"
        Me.ssFolios.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.ssFolios.Size = New System.Drawing.Size(63, 20)
        Me.ssFolios.TabIndex = 18
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(52, 328)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(42, 13)
        Me.SaimtLabel6.TabIndex = 27
        Me.SaimtLabel6.Text = "Prioridad"
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(18, 224)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(79, 13)
        Me.SaimtLabel13.TabIndex = 23
        Me.SaimtLabel13.Text = "Procedimientos :"
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(284, 194)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(42, 13)
        Me.SaimtLabel8.TabIndex = 17
        Me.SaimtLabel8.Text = "Nº Folios"
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(415, 194)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel7.TabIndex = 19
        Me.SaimtLabel7.Text = "Fecha Ingreso"
        '
        'SaimtLabel34
        '
        Me.SaimtLabel34.Location = New System.Drawing.Point(316, 35)
        Me.SaimtLabel34.Name = "SaimtLabel34"
        Me.SaimtLabel34.Size = New System.Drawing.Size(77, 13)
        Me.SaimtLabel34.TabIndex = 2
        Me.SaimtLabel34.Text = "Tipo Documento"
        '
        'GBoxDatosAdicionales
        '
        Me.GBoxDatosAdicionales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBoxDatosAdicionales.Controls.Add(Me.BackstageViewControl1)
        Me.GBoxDatosAdicionales.Location = New System.Drawing.Point(11, 355)
        Me.GBoxDatosAdicionales.Name = "GBoxDatosAdicionales"
        Me.GBoxDatosAdicionales.Size = New System.Drawing.Size(1008, 337)
        Me.GBoxDatosAdicionales.TabIndex = 1
        Me.GBoxDatosAdicionales.Text = "Datos Adicionales"
        '
        'BackstageViewControl1
        '
        Me.BackstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl1)
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl2)
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl3)
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl5)
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl6)
        Me.BackstageViewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem2)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator1)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem3)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator2)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem5)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator3)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem7)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator5)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem8)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator6)
        Me.BackstageViewControl1.Location = New System.Drawing.Point(2, 21)
        Me.BackstageViewControl1.Name = "BackstageViewControl1"
        Me.BackstageViewControl1.SelectedTab = Me.BackstageViewTabItem5
        Me.BackstageViewControl1.SelectedTabIndex = 4
        Me.BackstageViewControl1.Size = New System.Drawing.Size(1004, 314)
        Me.BackstageViewControl1.TabIndex = 0
        Me.BackstageViewControl1.Text = "BackstageViewControl1"
        '
        'BackstageViewClientControl1
        '
        Me.BackstageViewClientControl1.Controls.Add(Me.SaimtTabs1)
        Me.BackstageViewClientControl1.Location = New System.Drawing.Point(158, 0)
        Me.BackstageViewClientControl1.Name = "BackstageViewClientControl1"
        Me.BackstageViewClientControl1.Size = New System.Drawing.Size(846, 314)
        Me.BackstageViewClientControl1.TabIndex = 0
        '
        'SaimtTabs1
        '
        Me.SaimtTabs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtTabs1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtTabs1.Name = "SaimtTabs1"
        Me.SaimtTabs1.SelectedTabPage = Me.XtraTabPage3
        Me.SaimtTabs1.Size = New System.Drawing.Size(830, 315)
        Me.SaimtTabs1.TabIndex = 0
        Me.SaimtTabs1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.TxtCargoInt)
        Me.XtraTabPage3.Controls.Add(Me.TxtAreaInt)
        Me.XtraTabPage3.Controls.Add(Me.TxtInstitucionInt)
        Me.XtraTabPage3.Controls.Add(Me.TxtDireccionPerInt)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel23)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel14)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel12)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel24)
        Me.XtraTabPage3.Controls.Add(Me.TxtInteresado)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel25)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(824, 287)
        Me.XtraTabPage3.Text = "Datos del Interesado"
        '
        'TxtCargoInt
        '
        Me.TxtCargoInt.Location = New System.Drawing.Point(88, 188)
        Me.TxtCargoInt.MenuManager = Me.RibbonControl
        Me.TxtCargoInt.Name = "TxtCargoInt"
        Me.TxtCargoInt.Size = New System.Drawing.Size(357, 20)
        Me.TxtCargoInt.TabIndex = 12
        '
        'TxtAreaInt
        '
        Me.TxtAreaInt.Location = New System.Drawing.Point(88, 158)
        Me.TxtAreaInt.MenuManager = Me.RibbonControl
        Me.TxtAreaInt.Name = "TxtAreaInt"
        Me.TxtAreaInt.Size = New System.Drawing.Size(357, 20)
        Me.TxtAreaInt.TabIndex = 11
        '
        'TxtInstitucionInt
        '
        Me.TxtInstitucionInt.Location = New System.Drawing.Point(88, 132)
        Me.TxtInstitucionInt.MenuManager = Me.RibbonControl
        Me.TxtInstitucionInt.Name = "TxtInstitucionInt"
        Me.TxtInstitucionInt.Size = New System.Drawing.Size(357, 20)
        Me.TxtInstitucionInt.TabIndex = 10
        '
        'TxtDireccionPerInt
        '
        Me.TxtDireccionPerInt.Location = New System.Drawing.Point(88, 53)
        Me.TxtDireccionPerInt.MenuManager = Me.RibbonControl
        Me.TxtDireccionPerInt.Name = "TxtDireccionPerInt"
        Me.TxtDireccionPerInt.Size = New System.Drawing.Size(607, 61)
        Me.TxtDireccionPerInt.TabIndex = 3
        Me.TxtDireccionPerInt.UseOptimizedRendering = True
        '
        'SaimtLabel23
        '
        Me.SaimtLabel23.Location = New System.Drawing.Point(39, 56)
        Me.SaimtLabel23.Name = "SaimtLabel23"
        Me.SaimtLabel23.Size = New System.Drawing.Size(43, 13)
        Me.SaimtLabel23.TabIndex = 2
        Me.SaimtLabel23.Text = "Dirección"
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(53, 195)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(29, 13)
        Me.SaimtLabel14.TabIndex = 8
        Me.SaimtLabel14.Text = "Cargo"
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(56, 161)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(26, 13)
        Me.SaimtLabel12.TabIndex = 6
        Me.SaimtLabel12.Text = "Área "
        '
        'SaimtLabel24
        '
        Me.SaimtLabel24.Location = New System.Drawing.Point(32, 130)
        Me.SaimtLabel24.Name = "SaimtLabel24"
        Me.SaimtLabel24.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel24.TabIndex = 4
        Me.SaimtLabel24.Text = "Institución"
        '
        'TxtInteresado
        '
        Me.TxtInteresado.Location = New System.Drawing.Point(88, 22)
        Me.TxtInteresado.MenuManager = Me.RibbonControl
        Me.TxtInteresado.Name = "TxtInteresado"
        Me.TxtInteresado.Size = New System.Drawing.Size(607, 20)
        Me.TxtInteresado.TabIndex = 1
        '
        'SaimtLabel25
        '
        Me.SaimtLabel25.Location = New System.Drawing.Point(29, 25)
        Me.SaimtLabel25.Name = "SaimtLabel25"
        Me.SaimtLabel25.Size = New System.Drawing.Size(53, 13)
        Me.SaimtLabel25.TabIndex = 0
        Me.SaimtLabel25.Text = "Interesado"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.dgvDatosAdicionales)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(824, 287)
        Me.XtraTabPage4.Text = "Datos Adicionales del Interesado"
        '
        'dgvDatosAdicionales
        '
        Me.dgvDatosAdicionales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDatosAdicionales.Location = New System.Drawing.Point(0, 0)
        Me.dgvDatosAdicionales.MainView = Me.gvDatosAdicionales
        Me.dgvDatosAdicionales.MenuManager = Me.RibbonControl
        Me.dgvDatosAdicionales.Name = "dgvDatosAdicionales"
        Me.dgvDatosAdicionales.Size = New System.Drawing.Size(824, 287)
        Me.dgvDatosAdicionales.TabIndex = 1
        Me.dgvDatosAdicionales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDatosAdicionales, Me.GridView4, Me.GridView5})
        '
        'gvDatosAdicionales
        '
        Me.gvDatosAdicionales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colContacto, Me.colDescripcion})
        Me.gvDatosAdicionales.GridControl = Me.dgvDatosAdicionales
        Me.gvDatosAdicionales.Name = "gvDatosAdicionales"
        Me.gvDatosAdicionales.OptionsView.ShowGroupPanel = False
        '
        'colContacto
        '
        Me.colContacto.Caption = "Contacto"
        Me.colContacto.FieldName = "Contacto"
        Me.colContacto.Name = "colContacto"
        Me.colContacto.Visible = True
        Me.colContacto.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.dgvDatosAdicionales
        Me.GridView4.Name = "GridView4"
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.dgvDatosAdicionales
        Me.GridView5.Name = "GridView5"
        '
        'BackstageViewClientControl2
        '
        Me.BackstageViewClientControl2.Controls.Add(Me.SaimtTabs2)
        Me.BackstageViewClientControl2.Location = New System.Drawing.Point(158, 0)
        Me.BackstageViewClientControl2.Name = "BackstageViewClientControl2"
        Me.BackstageViewClientControl2.Size = New System.Drawing.Size(846, 314)
        Me.BackstageViewClientControl2.TabIndex = 1
        '
        'SaimtTabs2
        '
        Me.SaimtTabs2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtTabs2.Location = New System.Drawing.Point(0, 0)
        Me.SaimtTabs2.Name = "SaimtTabs2"
        Me.SaimtTabs2.SelectedTabPage = Me.XtraTabPage5
        Me.SaimtTabs2.Size = New System.Drawing.Size(830, 315)
        Me.SaimtTabs2.TabIndex = 0
        Me.SaimtTabs2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage5})
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.dgvReqvsProc)
        Me.XtraTabPage5.Controls.Add(Me.TxtProcedimientoVer)
        Me.XtraTabPage5.Controls.Add(Me.SaimtLabel28)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(824, 287)
        Me.XtraTabPage5.Text = "Agregar Requisitos"
        '
        'dgvReqvsProc
        '
        Me.dgvReqvsProc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReqvsProc.Location = New System.Drawing.Point(3, 39)
        Me.dgvReqvsProc.MainView = Me.gvReqvsProc
        Me.dgvReqvsProc.MenuManager = Me.RibbonControl
        Me.dgvReqvsProc.Name = "dgvReqvsProc"
        Me.dgvReqvsProc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCheckEdit5, Me.RepositoryItemCheckEdit6, Me.RepositoryItemCheckEdit4, Me.RepositoryItemMemoExEdit3})
        Me.dgvReqvsProc.Size = New System.Drawing.Size(816, 232)
        Me.dgvReqvsProc.TabIndex = 2
        Me.dgvReqvsProc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvReqvsProc, Me.GridView3})
        '
        'gvReqvsProc
        '
        Me.gvReqvsProc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcTgId, Me.GridColumn1, Me.GridColumn3, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.gvReqvsProc.GridControl = Me.dgvReqvsProc
        Me.gvReqvsProc.Name = "gvReqvsProc"
        Me.gvReqvsProc.OptionsView.ColumnAutoWidth = False
        Me.gvReqvsProc.OptionsView.ShowGroupPanel = False
        '
        'gcTgId
        '
        Me.gcTgId.Caption = "tgId"
        Me.gcTgId.FieldName = "tgId"
        Me.gcTgId.Name = "gcTgId"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Proc."
        Me.GridColumn1.FieldName = "procId"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cod. Req."
        Me.GridColumn3.FieldName = "reqId"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Requisito"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemMemoExEdit3
        Me.GridColumn2.FieldName = "requisito"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nro. Orden"
        Me.GridColumn4.FieldName = "nOrden"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Es Obligatorio"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn5.FieldName = "tgActivo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Observación"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn6.FieldName = "tgDescripcion"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Presento"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemCheckEdit4
        Me.GridColumn7.FieldName = "reqPresento"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Caption = "Check"
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'RepositoryItemCheckEdit5
        '
        Me.RepositoryItemCheckEdit5.AutoHeight = False
        Me.RepositoryItemCheckEdit5.Caption = "Check"
        Me.RepositoryItemCheckEdit5.Name = "RepositoryItemCheckEdit5"
        '
        'RepositoryItemCheckEdit6
        '
        Me.RepositoryItemCheckEdit6.AutoHeight = False
        Me.RepositoryItemCheckEdit6.Caption = "Check"
        Me.RepositoryItemCheckEdit6.Name = "RepositoryItemCheckEdit6"
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.dgvReqvsProc
        Me.GridView3.Name = "GridView3"
        '
        'TxtProcedimientoVer
        '
        Me.TxtProcedimientoVer.Location = New System.Drawing.Point(97, 10)
        Me.TxtProcedimientoVer.MenuManager = Me.RibbonControl
        Me.TxtProcedimientoVer.Name = "TxtProcedimientoVer"
        Me.TxtProcedimientoVer.Size = New System.Drawing.Size(587, 20)
        Me.TxtProcedimientoVer.TabIndex = 1
        '
        'SaimtLabel28
        '
        Me.SaimtLabel28.Location = New System.Drawing.Point(10, 13)
        Me.SaimtLabel28.Name = "SaimtLabel28"
        Me.SaimtLabel28.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel28.TabIndex = 0
        Me.SaimtLabel28.Text = "Procedimiento"
        '
        'BackstageViewClientControl3
        '
        Me.BackstageViewClientControl3.Controls.Add(Me.dgvMovimientos)
        Me.BackstageViewClientControl3.Location = New System.Drawing.Point(158, 0)
        Me.BackstageViewClientControl3.Name = "BackstageViewClientControl3"
        Me.BackstageViewClientControl3.Size = New System.Drawing.Size(846, 314)
        Me.BackstageViewClientControl3.TabIndex = 2
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.dgvMovimientos.MainView = Me.gvMovimientos
        Me.dgvMovimientos.MenuManager = Me.RibbonControl
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageComboBox1})
        Me.dgvMovimientos.Size = New System.Drawing.Size(846, 314)
        Me.dgvMovimientos.TabIndex = 1
        Me.dgvMovimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMovimientos, Me.gvMovimientosDet})
        '
        'gvMovimientos
        '
        Me.gvMovimientos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcPerNombreOrigen, Me.gcPerCargoOrigen, Me.gcPerNombreDestino, Me.gcPerCargoDestino, Me.gcMovDiasTenencia, Me.gcMovFechaRec, Me.gcTgEstadoMov, Me.gcMovFechaEnv, Me.gcMovTieneArch})
        Me.gvMovimientos.GridControl = Me.dgvMovimientos
        Me.gvMovimientos.Name = "gvMovimientos"
        Me.gvMovimientos.OptionsBehavior.Editable = False
        Me.gvMovimientos.OptionsBehavior.ReadOnly = True
        Me.gvMovimientos.OptionsDetail.ShowDetailTabs = False
        Me.gvMovimientos.OptionsView.ColumnAutoWidth = False
        Me.gvMovimientos.OptionsView.RowAutoHeight = True
        Me.gvMovimientos.OptionsView.ShowGroupPanel = False
        '
        'gcPerNombreOrigen
        '
        Me.gcPerNombreOrigen.Caption = "Envia"
        Me.gcPerNombreOrigen.FieldName = "perNombreOrigen"
        Me.gcPerNombreOrigen.Name = "gcPerNombreOrigen"
        Me.gcPerNombreOrigen.Visible = True
        Me.gcPerNombreOrigen.VisibleIndex = 1
        '
        'gcPerCargoOrigen
        '
        Me.gcPerCargoOrigen.Caption = "Cargo Envia"
        Me.gcPerCargoOrigen.FieldName = "perCargoOrigen"
        Me.gcPerCargoOrigen.Name = "gcPerCargoOrigen"
        Me.gcPerCargoOrigen.Visible = True
        Me.gcPerCargoOrigen.VisibleIndex = 2
        '
        'gcPerNombreDestino
        '
        Me.gcPerNombreDestino.Caption = "Recibe"
        Me.gcPerNombreDestino.FieldName = "perNombreDestino"
        Me.gcPerNombreDestino.Name = "gcPerNombreDestino"
        Me.gcPerNombreDestino.Visible = True
        Me.gcPerNombreDestino.VisibleIndex = 3
        '
        'gcPerCargoDestino
        '
        Me.gcPerCargoDestino.Caption = "Cargo Destino"
        Me.gcPerCargoDestino.FieldName = "perCargoDestino"
        Me.gcPerCargoDestino.Name = "gcPerCargoDestino"
        Me.gcPerCargoDestino.Visible = True
        Me.gcPerCargoDestino.VisibleIndex = 4
        '
        'gcMovDiasTenencia
        '
        Me.gcMovDiasTenencia.Caption = "Dias en Tenencias"
        Me.gcMovDiasTenencia.FieldName = "diasTenencia"
        Me.gcMovDiasTenencia.Name = "gcMovDiasTenencia"
        Me.gcMovDiasTenencia.Visible = True
        Me.gcMovDiasTenencia.VisibleIndex = 7
        Me.gcMovDiasTenencia.Width = 93
        '
        'gcMovFechaRec
        '
        Me.gcMovFechaRec.Caption = "Fecha Recepción"
        Me.gcMovFechaRec.FieldName = "movFechaRec"
        Me.gcMovFechaRec.Name = "gcMovFechaRec"
        Me.gcMovFechaRec.Visible = True
        Me.gcMovFechaRec.VisibleIndex = 6
        Me.gcMovFechaRec.Width = 108
        '
        'gcTgEstadoMov
        '
        Me.gcTgEstadoMov.Caption = "Estado del Tramite"
        Me.gcTgEstadoMov.FieldName = "tgEstadoMov"
        Me.gcTgEstadoMov.Name = "gcTgEstadoMov"
        Me.gcTgEstadoMov.Visible = True
        Me.gcTgEstadoMov.VisibleIndex = 8
        Me.gcTgEstadoMov.Width = 118
        '
        'gcMovFechaEnv
        '
        Me.gcMovFechaEnv.Caption = "Fecha de Envio"
        Me.gcMovFechaEnv.FieldName = "movFechaEnv"
        Me.gcMovFechaEnv.Name = "gcMovFechaEnv"
        Me.gcMovFechaEnv.Visible = True
        Me.gcMovFechaEnv.VisibleIndex = 5
        Me.gcMovFechaEnv.Width = 91
        '
        'gcMovTieneArch
        '
        Me.gcMovTieneArch.Caption = " "
        Me.gcMovTieneArch.ColumnEdit = Me.RepositoryItemImageComboBox1
        Me.gcMovTieneArch.FieldName = "movTieneArch"
        Me.gcMovTieneArch.Image = CType(resources.GetObject("gcMovTieneArch.Image"), System.Drawing.Image)
        Me.gcMovTieneArch.Name = "gcMovTieneArch"
        Me.gcMovTieneArch.Visible = True
        Me.gcMovTieneArch.VisibleIndex = 0
        Me.gcMovTieneArch.Width = 20
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", True, 13)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        Me.RepositoryItemImageComboBox1.SmallImages = Me.ImageCollection2
        '
        'gvMovimientosDet
        '
        Me.gvMovimientosDet.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvMovimientosDet.Appearance.FooterPanel.Options.UseFont = True
        Me.gvMovimientosDet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gccarPerId, Me.gcperId, Me.gcpersona, Me.gcperDni, Me.gccarPerFechaIni, Me.gcperDireccion})
        Me.gvMovimientosDet.GridControl = Me.dgvMovimientos
        Me.gvMovimientosDet.Name = "gvMovimientosDet"
        Me.gvMovimientosDet.OptionsDetail.ShowDetailTabs = False
        Me.gvMovimientosDet.OptionsView.ColumnAutoWidth = False
        Me.gvMovimientosDet.OptionsView.ShowFooter = True
        Me.gvMovimientosDet.OptionsView.ShowGroupPanel = False
        '
        'gccarPerId
        '
        Me.gccarPerId.Caption = "GridColumn5"
        Me.gccarPerId.FieldName = "carPerId"
        Me.gccarPerId.Name = "gccarPerId"
        '
        'gcperId
        '
        Me.gcperId.Caption = "perId"
        Me.gcperId.FieldName = "perId"
        Me.gcperId.Name = "gcperId"
        '
        'gcpersona
        '
        Me.gcpersona.Caption = "Nombre "
        Me.gcpersona.FieldName = "persona"
        Me.gcpersona.Name = "gcpersona"
        Me.gcpersona.Visible = True
        Me.gcpersona.VisibleIndex = 0
        '
        'gcperDni
        '
        Me.gcperDni.Caption = "DNI"
        Me.gcperDni.FieldName = "perDni"
        Me.gcperDni.Name = "gcperDni"
        Me.gcperDni.Visible = True
        Me.gcperDni.VisibleIndex = 1
        '
        'gccarPerFechaIni
        '
        Me.gccarPerFechaIni.Caption = "Fecha Inicio Cargo"
        Me.gccarPerFechaIni.FieldName = "carPerFechaIni"
        Me.gccarPerFechaIni.Name = "gccarPerFechaIni"
        Me.gccarPerFechaIni.Visible = True
        Me.gccarPerFechaIni.VisibleIndex = 2
        '
        'gcperDireccion
        '
        Me.gcperDireccion.Caption = "Direccion"
        Me.gcperDireccion.FieldName = "perDireccion"
        Me.gcperDireccion.Name = "gcperDireccion"
        Me.gcperDireccion.Visible = True
        Me.gcperDireccion.VisibleIndex = 3
        '
        'BackstageViewClientControl5
        '
        Me.BackstageViewClientControl5.Controls.Add(Me.TxtDocRef)
        Me.BackstageViewClientControl5.Controls.Add(Me.SaimtLabel30)
        Me.BackstageViewClientControl5.Controls.Add(Me.txtcomentario)
        Me.BackstageViewClientControl5.Controls.Add(Me.SaimtLabel29)
        Me.BackstageViewClientControl5.Location = New System.Drawing.Point(158, 0)
        Me.BackstageViewClientControl5.Name = "BackstageViewClientControl5"
        Me.BackstageViewClientControl5.Size = New System.Drawing.Size(846, 314)
        Me.BackstageViewClientControl5.TabIndex = 4
        '
        'TxtDocRef
        '
        Me.TxtDocRef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDocRef.Location = New System.Drawing.Point(103, 12)
        Me.TxtDocRef.MenuManager = Me.RibbonControl
        Me.TxtDocRef.Name = "TxtDocRef"
        Me.TxtDocRef.Size = New System.Drawing.Size(678, 20)
        Me.TxtDocRef.TabIndex = 9
        '
        'SaimtLabel30
        '
        Me.SaimtLabel30.Location = New System.Drawing.Point(20, 15)
        Me.SaimtLabel30.Name = "SaimtLabel30"
        Me.SaimtLabel30.Size = New System.Drawing.Size(77, 13)
        Me.SaimtLabel30.TabIndex = 8
        Me.SaimtLabel30.Text = "Doc. Referencia"
        '
        'txtcomentario
        '
        Me.txtcomentario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcomentario.Location = New System.Drawing.Point(15, 71)
        Me.txtcomentario.MenuManager = Me.RibbonControl
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(820, 241)
        Me.txtcomentario.TabIndex = 7
        Me.txtcomentario.UseOptimizedRendering = True
        '
        'SaimtLabel29
        '
        Me.SaimtLabel29.Location = New System.Drawing.Point(18, 52)
        Me.SaimtLabel29.Name = "SaimtLabel29"
        Me.SaimtLabel29.Size = New System.Drawing.Size(112, 13)
        Me.SaimtLabel29.TabIndex = 6
        Me.SaimtLabel29.Text = "Comentario Documento"
        '
        'BackstageViewClientControl6
        '
        Me.BackstageViewClientControl6.Controls.Add(Me.dgvDocumentosVinculados)
        Me.BackstageViewClientControl6.Location = New System.Drawing.Point(158, 0)
        Me.BackstageViewClientControl6.Name = "BackstageViewClientControl6"
        Me.BackstageViewClientControl6.Size = New System.Drawing.Size(846, 314)
        Me.BackstageViewClientControl6.TabIndex = 5
        '
        'dgvDocumentosVinculados
        '
        Me.dgvDocumentosVinculados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDocumentosVinculados.Location = New System.Drawing.Point(0, 0)
        Me.dgvDocumentosVinculados.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.dgvDocumentosVinculados.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgvDocumentosVinculados.MainView = Me.lvDocumentosVinculados
        Me.dgvDocumentosVinculados.MenuManager = Me.RibbonControl
        Me.dgvDocumentosVinculados.Name = "dgvDocumentosVinculados"
        Me.dgvDocumentosVinculados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit5, Me.RepositoryItemMemoExEdit6, Me.RepositoryItemMemoExEdit2})
        Me.dgvDocumentosVinculados.Size = New System.Drawing.Size(846, 314)
        Me.dgvDocumentosVinculados.TabIndex = 2
        Me.dgvDocumentosVinculados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvDocumentosVinculados})
        '
        'lvDocumentosVinculados
        '
        Me.lvDocumentosVinculados.CardMinSize = New System.Drawing.Size(322, 182)
        Me.lvDocumentosVinculados.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.LayoutViewColumn12, Me.LayoutViewColumn1, Me.LayoutViewColumn10, Me.LayoutViewColumn11, Me.LayoutViewColumn4, Me.LayoutViewColumn5, Me.LayoutViewColumn6, Me.LayoutViewColumn2})
        Me.lvDocumentosVinculados.GridControl = Me.dgvDocumentosVinculados
        Me.lvDocumentosVinculados.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1})
        Me.lvDocumentosVinculados.Name = "lvDocumentosVinculados"
        Me.lvDocumentosVinculados.OptionsBehavior.ReadOnly = True
        Me.lvDocumentosVinculados.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn
        Me.lvDocumentosVinculados.TemplateCard = Me.LayoutViewCard1
        '
        'LayoutViewColumn12
        '
        Me.LayoutViewColumn12.Caption = "Cod. Interno"
        Me.LayoutViewColumn12.FieldName = "docId"
        Me.LayoutViewColumn12.LayoutViewField = Me.layoutViewField_LayoutViewColumn12
        Me.LayoutViewColumn12.Name = "LayoutViewColumn12"
        '
        'layoutViewField_LayoutViewColumn12
        '
        Me.layoutViewField_LayoutViewColumn12.EditorPreferredWidth = 217
        Me.layoutViewField_LayoutViewColumn12.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn12.Name = "layoutViewField_LayoutViewColumn12"
        Me.layoutViewField_LayoutViewColumn12.Size = New System.Drawing.Size(302, 24)
        Me.layoutViewField_LayoutViewColumn12.TextSize = New System.Drawing.Size(76, 13)
        Me.layoutViewField_LayoutViewColumn12.TextToControlDistance = 5
        '
        'LayoutViewColumn1
        '
        Me.LayoutViewColumn1.Caption = "Nro Parte"
        Me.LayoutViewColumn1.FieldName = "docParte"
        Me.LayoutViewColumn1.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.LayoutViewColumn1.Name = "LayoutViewColumn1"
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 217
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(0, 20)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(326, 20)
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(76, 13)
        Me.layoutViewField_LayoutViewColumn1.TextToControlDistance = 5
        '
        'LayoutViewColumn10
        '
        Me.LayoutViewColumn10.Caption = "Asunto"
        Me.LayoutViewColumn10.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.LayoutViewColumn10.FieldName = "docAsunto"
        Me.LayoutViewColumn10.LayoutViewField = Me.layoutViewField_LayoutViewColumn10
        Me.LayoutViewColumn10.Name = "LayoutViewColumn10"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'layoutViewField_LayoutViewColumn10
        '
        Me.layoutViewField_LayoutViewColumn10.EditorPreferredWidth = 217
        Me.layoutViewField_LayoutViewColumn10.Location = New System.Drawing.Point(0, 24)
        Me.layoutViewField_LayoutViewColumn10.Name = "layoutViewField_LayoutViewColumn10"
        Me.layoutViewField_LayoutViewColumn10.Size = New System.Drawing.Size(302, 24)
        Me.layoutViewField_LayoutViewColumn10.TextSize = New System.Drawing.Size(76, 13)
        Me.layoutViewField_LayoutViewColumn10.TextToControlDistance = 5
        '
        'LayoutViewColumn11
        '
        Me.LayoutViewColumn11.Caption = "Fecha Registro"
        Me.LayoutViewColumn11.FieldName = "docFechaReg"
        Me.LayoutViewColumn11.LayoutViewField = Me.layoutViewField_LayoutViewColumn11
        Me.LayoutViewColumn11.Name = "LayoutViewColumn11"
        '
        'layoutViewField_LayoutViewColumn11
        '
        Me.layoutViewField_LayoutViewColumn11.EditorPreferredWidth = 217
        Me.layoutViewField_LayoutViewColumn11.Location = New System.Drawing.Point(0, 48)
        Me.layoutViewField_LayoutViewColumn11.Name = "layoutViewField_LayoutViewColumn11"
        Me.layoutViewField_LayoutViewColumn11.Size = New System.Drawing.Size(302, 24)
        Me.layoutViewField_LayoutViewColumn11.TextSize = New System.Drawing.Size(76, 13)
        Me.layoutViewField_LayoutViewColumn11.TextToControlDistance = 5
        '
        'LayoutViewColumn4
        '
        Me.LayoutViewColumn4.Caption = "N° Registro"
        Me.LayoutViewColumn4.FieldName = "docNroReg"
        Me.LayoutViewColumn4.LayoutViewField = Me.layoutViewField_LayoutViewColumn4
        Me.LayoutViewColumn4.Name = "LayoutViewColumn4"
        '
        'layoutViewField_LayoutViewColumn4
        '
        Me.layoutViewField_LayoutViewColumn4.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn4.Location = New System.Drawing.Point(0, 72)
        Me.layoutViewField_LayoutViewColumn4.Name = "layoutViewField_LayoutViewColumn4"
        Me.layoutViewField_LayoutViewColumn4.Size = New System.Drawing.Size(302, 24)
        Me.layoutViewField_LayoutViewColumn4.TextSize = New System.Drawing.Size(76, 13)
        Me.layoutViewField_LayoutViewColumn4.TextToControlDistance = 5
        '
        'LayoutViewColumn5
        '
        Me.LayoutViewColumn5.Caption = "Institución"
        Me.LayoutViewColumn5.FieldName = "tgInstPerInt"
        Me.LayoutViewColumn5.LayoutViewField = Me.layoutViewField_LayoutViewColumn5
        Me.LayoutViewColumn5.Name = "LayoutViewColumn5"
        '
        'layoutViewField_LayoutViewColumn5
        '
        Me.layoutViewField_LayoutViewColumn5.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn5.Location = New System.Drawing.Point(0, 96)
        Me.layoutViewField_LayoutViewColumn5.Name = "layoutViewField_LayoutViewColumn5"
        Me.layoutViewField_LayoutViewColumn5.Size = New System.Drawing.Size(302, 24)
        Me.layoutViewField_LayoutViewColumn5.TextSize = New System.Drawing.Size(76, 13)
        Me.layoutViewField_LayoutViewColumn5.TextToControlDistance = 5
        '
        'LayoutViewColumn6
        '
        Me.LayoutViewColumn6.Caption = "Área"
        Me.LayoutViewColumn6.FieldName = "tgAreaPerInt"
        Me.LayoutViewColumn6.LayoutViewField = Me.layoutViewField_LayoutViewColumn6
        Me.LayoutViewColumn6.Name = "LayoutViewColumn6"
        '
        'layoutViewField_LayoutViewColumn6
        '
        Me.layoutViewField_LayoutViewColumn6.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn6.Location = New System.Drawing.Point(0, 120)
        Me.layoutViewField_LayoutViewColumn6.Name = "layoutViewField_LayoutViewColumn6"
        Me.layoutViewField_LayoutViewColumn6.Size = New System.Drawing.Size(302, 24)
        Me.layoutViewField_LayoutViewColumn6.TextSize = New System.Drawing.Size(76, 13)
        Me.layoutViewField_LayoutViewColumn6.TextToControlDistance = 5
        '
        'LayoutViewColumn2
        '
        Me.LayoutViewColumn2.Caption = "Interesado"
        Me.LayoutViewColumn2.FieldName = "perInteresado"
        Me.LayoutViewColumn2.LayoutViewField = Me.layoutViewField_LayoutViewColumn2
        Me.LayoutViewColumn2.Name = "LayoutViewColumn2"
        '
        'layoutViewField_LayoutViewColumn2
        '
        Me.layoutViewField_LayoutViewColumn2.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn2.Location = New System.Drawing.Point(0, 144)
        Me.layoutViewField_LayoutViewColumn2.Name = "layoutViewField_LayoutViewColumn2"
        Me.layoutViewField_LayoutViewColumn2.Size = New System.Drawing.Size(302, 24)
        Me.layoutViewField_LayoutViewColumn2.TextSize = New System.Drawing.Size(76, 13)
        Me.layoutViewField_LayoutViewColumn2.TextToControlDistance = 5
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn10, Me.layoutViewField_LayoutViewColumn11, Me.layoutViewField_LayoutViewColumn12, Me.layoutViewField_LayoutViewColumn4, Me.layoutViewField_LayoutViewColumn5, Me.layoutViewField_LayoutViewColumn6, Me.layoutViewField_LayoutViewColumn2})
        Me.LayoutViewCard1.Name = "layoutViewTemplateCard"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'RepositoryItemMemoExEdit5
        '
        Me.RepositoryItemMemoExEdit5.AutoHeight = False
        Me.RepositoryItemMemoExEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit5.Name = "RepositoryItemMemoExEdit5"
        Me.RepositoryItemMemoExEdit5.ShowIcon = False
        '
        'RepositoryItemMemoExEdit6
        '
        Me.RepositoryItemMemoExEdit6.AutoHeight = False
        Me.RepositoryItemMemoExEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit6.Name = "RepositoryItemMemoExEdit6"
        Me.RepositoryItemMemoExEdit6.ShowIcon = False
        '
        'BackstageViewTabItem2
        '
        Me.BackstageViewTabItem2.Caption = "Interesado"
        Me.BackstageViewTabItem2.ContentControl = Me.BackstageViewClientControl1
        Me.BackstageViewTabItem2.Glyph = CType(resources.GetObject("BackstageViewTabItem2.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem2.Name = "BackstageViewTabItem2"
        Me.BackstageViewTabItem2.Selected = False
        '
        'BackstageViewItemSeparator1
        '
        Me.BackstageViewItemSeparator1.Name = "BackstageViewItemSeparator1"
        '
        'BackstageViewTabItem3
        '
        Me.BackstageViewTabItem3.Caption = "Requisitos"
        Me.BackstageViewTabItem3.ContentControl = Me.BackstageViewClientControl2
        Me.BackstageViewTabItem3.Glyph = CType(resources.GetObject("BackstageViewTabItem3.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem3.Name = "BackstageViewTabItem3"
        Me.BackstageViewTabItem3.Selected = False
        '
        'BackstageViewItemSeparator2
        '
        Me.BackstageViewItemSeparator2.Name = "BackstageViewItemSeparator2"
        '
        'BackstageViewTabItem5
        '
        Me.BackstageViewTabItem5.Caption = "Movimientos"
        Me.BackstageViewTabItem5.ContentControl = Me.BackstageViewClientControl3
        Me.BackstageViewTabItem5.Glyph = CType(resources.GetObject("BackstageViewTabItem5.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem5.Name = "BackstageViewTabItem5"
        Me.BackstageViewTabItem5.Selected = True
        '
        'BackstageViewItemSeparator3
        '
        Me.BackstageViewItemSeparator3.Name = "BackstageViewItemSeparator3"
        '
        'BackstageViewTabItem7
        '
        Me.BackstageViewTabItem7.Caption = "Observaciones"
        Me.BackstageViewTabItem7.ContentControl = Me.BackstageViewClientControl5
        Me.BackstageViewTabItem7.Glyph = CType(resources.GetObject("BackstageViewTabItem7.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem7.Name = "BackstageViewTabItem7"
        Me.BackstageViewTabItem7.Selected = False
        '
        'BackstageViewItemSeparator5
        '
        Me.BackstageViewItemSeparator5.Name = "BackstageViewItemSeparator5"
        '
        'BackstageViewTabItem8
        '
        Me.BackstageViewTabItem8.Caption = "Doc. Vinculados"
        Me.BackstageViewTabItem8.ContentControl = Me.BackstageViewClientControl6
        Me.BackstageViewTabItem8.Glyph = CType(resources.GetObject("BackstageViewTabItem8.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem8.Name = "BackstageViewTabItem8"
        Me.BackstageViewTabItem8.Selected = False
        '
        'BackstageViewItemSeparator6
        '
        Me.BackstageViewItemSeparator6.Name = "BackstageViewItemSeparator6"
        '
        'SaimtLabel18
        '
        Me.SaimtLabel18.Location = New System.Drawing.Point(21, 142)
        Me.SaimtLabel18.Name = "SaimtLabel18"
        Me.SaimtLabel18.Size = New System.Drawing.Size(53, 13)
        Me.SaimtLabel18.TabIndex = 62
        '
        'btnInstitucionEnviar
        '
        Me.btnInstitucionEnviar.Image = CType(resources.GetObject("btnInstitucionEnviar.Image"), System.Drawing.Image)
        Me.btnInstitucionEnviar.Location = New System.Drawing.Point(446, 49)
        Me.btnInstitucionEnviar.Name = "btnInstitucionEnviar"
        Me.btnInstitucionEnviar.Size = New System.Drawing.Size(22, 23)
        Me.btnInstitucionEnviar.TabIndex = 61
        '
        'sTxtInstitucion
        '
        Me.sTxtInstitucion.Location = New System.Drawing.Point(80, 52)
        Me.sTxtInstitucion.MenuManager = Me.RibbonControl
        Me.sTxtInstitucion.Name = "sTxtInstitucion"
        Me.sTxtInstitucion.Size = New System.Drawing.Size(360, 20)
        Me.sTxtInstitucion.TabIndex = 60
        '
        'SaimtButton6
        '
        Me.SaimtButton6.Image = CType(resources.GetObject("SaimtButton6.Image"), System.Drawing.Image)
        Me.SaimtButton6.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SaimtButton6.Location = New System.Drawing.Point(443, 300)
        Me.SaimtButton6.LookAndFeel.SkinName = "Seven"
        Me.SaimtButton6.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SaimtButton6.Name = "SaimtButton6"
        Me.SaimtButton6.Size = New System.Drawing.Size(25, 23)
        Me.SaimtButton6.TabIndex = 59
        '
        'sBtnAgregar
        '
        Me.sBtnAgregar.Image = CType(resources.GetObject("sBtnAgregar.Image"), System.Drawing.Image)
        Me.sBtnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.sBtnAgregar.Location = New System.Drawing.Point(416, 300)
        Me.sBtnAgregar.LookAndFeel.SkinName = "Seven"
        Me.sBtnAgregar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.sBtnAgregar.Name = "sBtnAgregar"
        Me.sBtnAgregar.Size = New System.Drawing.Size(25, 23)
        Me.sBtnAgregar.TabIndex = 58
        '
        'sCboEstado
        '
        Me.sCboEstado.Location = New System.Drawing.Point(319, 25)
        Me.sCboEstado.MenuManager = Me.RibbonControl
        Me.sCboEstado.Name = "sCboEstado"
        Me.sCboEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sCboEstado.Properties.NullText = ""
        Me.sCboEstado.Size = New System.Drawing.Size(146, 20)
        Me.sCboEstado.TabIndex = 57
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(241, 28)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(72, 13)
        Me.SaimtLabel15.TabIndex = 56
        '
        'sTxtComentario
        '
        Me.sTxtComentario.Location = New System.Drawing.Point(9, 225)
        Me.sTxtComentario.MenuManager = Me.RibbonControl
        Me.sTxtComentario.Name = "sTxtComentario"
        Me.sTxtComentario.Size = New System.Drawing.Size(459, 68)
        Me.sTxtComentario.TabIndex = 55
        Me.sTxtComentario.UseOptimizedRendering = True
        '
        'SaimtLabel16
        '
        Me.SaimtLabel16.Location = New System.Drawing.Point(11, 210)
        Me.SaimtLabel16.Name = "SaimtLabel16"
        Me.SaimtLabel16.Size = New System.Drawing.Size(55, 13)
        Me.SaimtLabel16.TabIndex = 54
        '
        'gvDestinos
        '
        Me.gvDestinos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvDestinos.Location = New System.Drawing.Point(2, 430)
        Me.gvDestinos.MainView = Me.dgvTrabajadores
        Me.gvDestinos.MenuManager = Me.RibbonControl
        Me.gvDestinos.Name = "gvDestinos"
        Me.gvDestinos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2, Me.RepositoryItemMemoExEdit4})
        Me.gvDestinos.Size = New System.Drawing.Size(479, 171)
        Me.gvDestinos.TabIndex = 6
        Me.gvDestinos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvTrabajadores})
        '
        'dgvTrabajadores
        '
        Me.dgvTrabajadores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcDestino, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.gcTgTDestinoId, Me.gcTgTipoDestino, Me.GridColumn15})
        Me.dgvTrabajadores.GridControl = Me.gvDestinos
        Me.dgvTrabajadores.Name = "dgvTrabajadores"
        Me.dgvTrabajadores.OptionsView.ColumnAutoWidth = False
        Me.dgvTrabajadores.OptionsView.ShowGroupPanel = False
        '
        'gcDestino
        '
        Me.gcDestino.Caption = "DestinoID"
        Me.gcDestino.FieldName = "DestinoId"
        Me.gcDestino.Name = "gcDestino"
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Institución"
        Me.GridColumn22.FieldName = "tgInstitucion"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 2
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Área"
        Me.GridColumn23.FieldName = "tgArea"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 1
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Cargo Destino"
        Me.GridColumn24.FieldName = "tgCargo"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 0
        '
        'gcTgTDestinoId
        '
        Me.gcTgTDestinoId.Caption = "tgTipoDestinoId"
        Me.gcTgTDestinoId.FieldName = "tgTipoDestinoId"
        Me.gcTgTDestinoId.Name = "gcTgTDestinoId"
        '
        'gcTgTipoDestino
        '
        Me.gcTgTipoDestino.Caption = "Tipo Destino"
        Me.gcTgTipoDestino.FieldName = "tgTipoDestino"
        Me.gcTgTipoDestino.Name = "gcTgTipoDestino"
        Me.gcTgTipoDestino.Visible = True
        Me.gcTgTipoDestino.VisibleIndex = 4
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Comentario"
        Me.GridColumn15.ColumnEdit = Me.RepositoryItemMemoExEdit4
        Me.GridColumn15.FieldName = "Comentario"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 3
        '
        'RepositoryItemMemoExEdit4
        '
        Me.RepositoryItemMemoExEdit4.AutoHeight = False
        Me.RepositoryItemMemoExEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit4.Name = "RepositoryItemMemoExEdit4"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'sCboCargoDest
        '
        Me.sCboCargoDest.Location = New System.Drawing.Point(80, 110)
        Me.sCboCargoDest.MenuManager = Me.RibbonControl
        Me.sCboCargoDest.Name = "sCboCargoDest"
        Me.sCboCargoDest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sCboCargoDest.Properties.NullText = ""
        Me.sCboCargoDest.Size = New System.Drawing.Size(388, 20)
        Me.sCboCargoDest.TabIndex = 5
        '
        'SaimtLabel17
        '
        Me.SaimtLabel17.Location = New System.Drawing.Point(6, 115)
        Me.SaimtLabel17.Name = "SaimtLabel17"
        Me.SaimtLabel17.Size = New System.Drawing.Size(68, 13)
        Me.SaimtLabel17.TabIndex = 4
        '
        'sCboArea
        '
        Me.sCboArea.Location = New System.Drawing.Point(80, 81)
        Me.sCboArea.MenuManager = Me.RibbonControl
        Me.sCboArea.Name = "sCboArea"
        Me.sCboArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sCboArea.Properties.NullText = ""
        Me.sCboArea.Size = New System.Drawing.Size(388, 20)
        Me.sCboArea.TabIndex = 3
        '
        'SaimtLabel37
        '
        Me.SaimtLabel37.Location = New System.Drawing.Point(51, 84)
        Me.SaimtLabel37.Name = "SaimtLabel37"
        Me.SaimtLabel37.Size = New System.Drawing.Size(23, 13)
        Me.SaimtLabel37.TabIndex = 2
        '
        'SaimtLabel38
        '
        Me.SaimtLabel38.Location = New System.Drawing.Point(24, 55)
        Me.SaimtLabel38.Name = "SaimtLabel38"
        Me.SaimtLabel38.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel38.TabIndex = 0
        '
        'BackstageViewTabItem4
        '
        Me.BackstageViewTabItem4.Caption = "Interesado"
        Me.BackstageViewTabItem4.Glyph = CType(resources.GetObject("BackstageViewTabItem4.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem4.Name = "BackstageViewTabItem4"
        Me.BackstageViewTabItem4.Selected = False
        '
        'BackstageViewTabItem1
        '
        Me.BackstageViewTabItem1.Caption = "BackstageViewTabItem1"
        Me.BackstageViewTabItem1.Name = "BackstageViewTabItem1"
        Me.BackstageViewTabItem1.Selected = False
        '
        'frmBandejaEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 748)
        Me.Controls.Add(Me.SaimtXtraTabControl1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmBandejaEntrada"
        Me.Text = "Bandeja de Entrada - Proveidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtXtraTabControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicmbleido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtXtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtXtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.CboCriterioAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        Me.SaimtGroupBox3.PerformLayout()
        CType(Me.TxtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.sTLBandeja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sRbtipoCriterio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.dgvRemitente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRemitente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicmborigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ripcdestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ritxtcomentario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ritxtAsunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicmbadjunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicmbenviado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicmbprioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtNActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMostrarNrow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNRegistros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssNrow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpfechaIngDoc.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpfechaIngDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMovFechaEnv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GBoxDatosDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxDatosDocumento.ResumeLayout(False)
        Me.GBoxDatosDocumento.PerformLayout()
        CType(Me.txtDocumentoAux.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMovDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTipoDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrioridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocFechaIng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdocid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvinId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox6.ResumeLayout(False)
        Me.SaimtGroupBox6.PerformLayout()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNdocReg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sTxtSiglas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssDocParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtasunto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sRdbOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReqActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sRbTupac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssFolios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GBoxDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxDatosAdicionales.ResumeLayout(False)
        Me.BackstageViewControl1.ResumeLayout(False)
        Me.BackstageViewClientControl1.ResumeLayout(False)
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.TxtCargoInt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAreaInt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInstitucionInt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDireccionPerInt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInteresado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.dgvDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewClientControl2.ResumeLayout(False)
        CType(Me.SaimtTabs2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs2.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage5.PerformLayout()
        CType(Me.dgvReqvsProc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReqvsProc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtProcedimientoVer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewClientControl3.ResumeLayout(False)
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMovimientosDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewClientControl5.ResumeLayout(False)
        Me.BackstageViewClientControl5.PerformLayout()
        CType(Me.TxtDocRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcomentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewClientControl6.ResumeLayout(False)
        CType(Me.dgvDocumentosVinculados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvDocumentosVinculados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sTxtInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sCboEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sTxtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDestinos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sCboCargoDest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sCboArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtXtraTabControl1 As SaimtControles.SaimtXtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents TxtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents sRbtipoCriterio As SaimtControles.SaimtRadioGroup
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents dgvRemitente As SaimtControles.SaimtDataGrid
    Friend WithEvents gvRemitente As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnImprimirFlujo As SaimtControles.SaimtButton
    Friend WithEvents GBoxDatosAdicionales As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtButton4 As SaimtControles.SaimtButton
    Friend WithEvents gcMovID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovComentario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDocNReg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovFechaEnvio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctgEstadoTramite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovRead As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BackstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Friend WithEvents BackstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewClientControl2 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewClientControl3 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewTabItem2 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem3 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator2 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem5 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator3 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem4 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewTabItem1 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewClientControl5 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewClientControl6 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewTabItem7 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator5 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewTabItem8 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator6 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents SaimtTabs1 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxtDireccionPerInt As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel23 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel24 As SaimtControles.SaimtLabel
    Friend WithEvents TxtInteresado As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel25 As SaimtControles.SaimtLabel
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SaimtTabs2 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxtProcedimientoVer As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel28 As SaimtControles.SaimtLabel
    Friend WithEvents btnAbrirDoc As SaimtControles.SaimtButton
    Friend WithEvents btnVolver As SaimtControles.SaimtButton
    Friend WithEvents gcTipoDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDocId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTipoDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sTLBandeja As SaimtControles.SaimtTreeList
    Friend WithEvents tlCarPerId As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlCargo As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents GBoxDatosDocumento As SaimtControles.SaimtGroupBox
    Friend WithEvents TxtProcedimiento As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel33 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel32 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel31 As SaimtControles.SaimtLabel
    Friend WithEvents txtdocid As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtvinId As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel27 As SaimtControles.SaimtLabel
    Friend WithEvents ssDocParte As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel26 As SaimtControles.SaimtLabel
    Friend WithEvents btnAnexos As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox6 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel19 As SaimtControles.SaimtLabel
    Friend WithEvents TxtNdocReg As SaimtControles.SaimtTextBox
    Friend WithEvents txtAño As SaimtControles.SaimtTextBox
    Friend WithEvents sTxtSiglas As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel22 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel21 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel20 As SaimtControles.SaimtLabel
    Friend WithEvents txtasunto As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents sRdbOrigen As SaimtControles.SaimtRadioGroup
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents chkReqActivos As SaimtControles.SaimtCheckBox
    Friend WithEvents sRbTupac As SaimtControles.SaimtRadioGroup
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents ssFolios As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel34 As SaimtControles.SaimtLabel
    Friend WithEvents dgvReqvsProc As SaimtControles.SaimtDataGrid
    Friend WithEvents gvReqvsProc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcTgId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LstTrabajador As SaimtControles.SaimtListBox
    Friend WithEvents SaimtLabel18 As SaimtControles.SaimtLabel
    Friend WithEvents btnInstitucionEnviar As SaimtControles.SaimtButton
    Friend WithEvents sTxtInstitucion As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtButton6 As SaimtControles.SaimtButton
    Friend WithEvents sBtnAgregar As SaimtControles.SaimtButton
    Friend WithEvents sCboEstado As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents sTxtComentario As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel16 As SaimtControles.SaimtLabel
    Friend WithEvents gvDestinos As SaimtControles.SaimtDataGrid
    Friend WithEvents dgvTrabajadores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTgTDestinoId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTgTipoDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents sCboCargoDest As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel17 As SaimtControles.SaimtLabel
    Friend WithEvents sCboArea As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel37 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel38 As SaimtControles.SaimtLabel
    Friend WithEvents btnReenviar As SaimtControles.SaimtButton
    Friend WithEvents btnSiguiente As SaimtControles.SaimtButton
    Friend WithEvents btnAtras As SaimtControles.SaimtButton
    Friend WithEvents gcOrigenCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDestinoCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ripcdestino As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents gc_MovPara As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gctOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAsunto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageCollection2 As DevExpress.Utils.ImageCollection
    Friend WithEvents gcAdjunto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcGrupoMovFechaEnv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbagrupar As DevExpress.XtraEditors.CheckButton
    Friend WithEvents riicmborigen As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents riicmbleido As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents riicmbprioridad As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents riicmbadjunto As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents ritxtcomentario As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents gctgEstadoTramiteId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnTerminar As SaimtControles.SaimtButton
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel48 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel49 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel46 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel47 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel44 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel45 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel39 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel43 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel52 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel53 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel50 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel51 As SaimtControles.SaimtLabel
    Friend WithEvents btnrefrescar As SaimtControles.SaimtButton
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents TxtInstitucionInt As SaimtControles.SaimtTextBox
    Friend WithEvents TxtCargoInt As SaimtControles.SaimtTextBox
    Friend WithEvents TxtAreaInt As SaimtControles.SaimtTextBox
    Friend WithEvents dgvDatosAdicionales As SaimtControles.SaimtDataGrid
    Friend WithEvents gvDatosAdicionales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtIntitucion As SaimtControles.SaimtTextBox
    Friend WithEvents txtArea As SaimtControles.SaimtTextBox
    Friend WithEvents TxtPrioridad As SaimtControles.SaimtTextBox
    Friend WithEvents txtDocFecha As SaimtControles.SaimtTextBox
    Friend WithEvents txtDocFechaIng As SaimtControles.SaimtTextBox
    Friend WithEvents txtMovDoc As SaimtControles.SaimtTextBox
    Friend WithEvents TxtTipoDoc As SaimtControles.SaimtTextBox
    Friend WithEvents txtDocumentoAux As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel35 As SaimtControles.SaimtLabel
    Friend WithEvents gcDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnVisorDoc As SaimtControles.SaimtButton
    Friend WithEvents ritxtAsunto As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents SaimtLabel54 As SaimtControles.SaimtLabel
    Friend WithEvents cboAccion As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents dtpfechaIngDoc As SaimtControles.SaimtDateTimePicker
    Friend WithEvents chkMovFechaEnv As SaimtControles.SaimtCheckBox
    Friend WithEvents txtNRegistros As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel42 As SaimtControles.SaimtLabel
    Friend WithEvents ssNrow As SaimtControles.SaimtSpinner
    Friend WithEvents chkMostrarNrow As SaimtControles.SaimtCheckBox
    Friend WithEvents cboCriterioMes As System.Windows.Forms.ComboBox
    Friend WithEvents CboCriterioAnio As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel55 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel57 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel56 As SaimtControles.SaimtLabel
    Friend WithEvents btnExportargrilla As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel58 As SaimtControles.SaimtLabel
    Friend WithEvents sfdExportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnAnularEnvio As SaimtControles.SaimtButton
    Friend WithEvents CheckButton1 As DevExpress.XtraEditors.CheckButton
    Friend WithEvents gcmovgaf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovEnviado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riicmbenviado As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents SaimtLabel69 As SaimtControles.SaimtLabel
    Friend WithEvents txtNActual As SaimtControles.SaimtTextBox
    Friend WithEvents btnPagUltimo As SaimtControles.SaimtButton
    Friend WithEvents btnPagAdelante As SaimtControles.SaimtButton
    Friend WithEvents btnPagAtras As SaimtControles.SaimtButton
    Friend WithEvents btnPagInicio As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel70 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel71 As SaimtControles.SaimtLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gcRecepcionado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents dgvMovimientos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvMovimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcPerNombreOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPerCargoOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPerNombreDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPerCargoDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovDiasTenencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovFechaRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTgEstadoMov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovFechaEnv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovTieneArch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvMovimientosDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gccarPerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcperId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcpersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcperDni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gccarPerFechaIni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcperDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtDocRef As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel30 As SaimtControles.SaimtLabel
    Friend WithEvents txtcomentario As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel29 As SaimtControles.SaimtLabel
    Friend WithEvents dgvDocumentosVinculados As SaimtControles.SaimtDataGrid
    Friend WithEvents lvDocumentosVinculados As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewColumn12 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn12 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn10 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents layoutViewField_LayoutViewColumn10 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn11 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn11 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn4 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn4 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn5 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn5 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn6 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn6 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents RepositoryItemMemoExEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoExEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents gcVinculado As DevExpress.XtraGrid.Columns.GridColumn

End Class