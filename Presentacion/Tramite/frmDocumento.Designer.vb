﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumento
    Inherits Presentacion.frmMantenimientos

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumento))
        Me.gvMovimientosDet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gccarPerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcperId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcpersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcperDni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gccarPerFechaIni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcperDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GBoxDatosDocumento = New SaimtControles.SaimtGroupBox()
        Me.btnVisorDoc = New SaimtControles.SaimtButton()
        Me.lblNroDoc = New SaimtControles.SaimtLabel()
        Me.SaimtLabel34 = New SaimtControles.SaimtLabel()
        Me.txtDocAux = New SaimtControles.SaimtTextBox()
        Me.cbTipoDocAux = New SaimtControles.SaimtComboBoxLookUp()
        Me.TxtProcedimiento = New SaimtControles.SaimtTextBox()
        Me.sCboTipoAccion = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel33 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel32 = New SaimtControles.SaimtLabel()
        Me.dtpFechaDoc = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel31 = New SaimtControles.SaimtLabel()
        Me.btnProcedimiento = New SaimtControles.SaimtButton()
        Me.txtdocid = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel29 = New SaimtControles.SaimtLabel()
        Me.btnAnexos = New SaimtControles.SaimtButton()
        Me.SaimtGroupBox6 = New SaimtControles.SaimtGroupBox()
        Me.spañoReg = New SaimtControles.SaimtSpinner()
        Me.btnInstitucion = New SaimtControles.SaimtButtonEdit()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.sCboAreas = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel19 = New SaimtControles.SaimtLabel()
        Me.TxtNdocReg = New SaimtControles.SaimtTextBox()
        Me.sTxtSiglas = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel22 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel21 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel20 = New SaimtControles.SaimtLabel()
        Me.txtasunto = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.sRdbOrigen = New SaimtControles.SaimtRadioGroup()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.chkReqActivos = New SaimtControles.SaimtCheckBox()
        Me.sRbTupac = New SaimtControles.SaimtRadioGroup()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.ssFolios = New SaimtControles.SaimtSpinner()
        Me.dtpDocFechaIng = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel13 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.lblTipoDoc = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.dgvListadoDocumento = New SaimtControles.SaimtDataGrid()
        Me.gvListadoDocumento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtBuscarPor = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox4 = New SaimtControles.SaimtGroupBox()
        Me.SaimtTextBox3 = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel17 = New SaimtControles.SaimtLabel()
        Me.SaimtTextBoxMultiline2 = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtComboBoxLookUpUpdate7 = New SaimtControles.SaimtComboBoxLookUpUpdate()
        Me.SaimtLabel18 = New SaimtControles.SaimtLabel()
        Me.SaimtComboBoxLookUpUpdate8 = New SaimtControles.SaimtComboBoxLookUpUpdate()
        Me.SaimtLabel16 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel15 = New SaimtControles.SaimtLabel()
        Me.SaimtButton2 = New SaimtControles.SaimtButton()
        Me.btnCancelar = New SaimtControles.SaimtButton()
        Me.btnEliminar = New SaimtControles.SaimtButton()
        Me.btnLimpiar = New SaimtControles.SaimtButton()
        Me.btnNuevo = New SaimtControles.SaimtButton()
        Me.btnGuardar = New SaimtControles.SaimtButton()
        Me.btnEditar = New SaimtControles.SaimtButton()
        Me.BackstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BVTabInteresado = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BVCCInteresado = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.SaimtTabs1 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnInstitucionInt = New SaimtControles.SaimtButtonEdit()
        Me.TxtDireccionPerInt = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel23 = New SaimtControles.SaimtLabel()
        Me.SCboCargoInt = New SaimtControles.SaimtComboBoxLookUp()
        Me.sCboAreaInt = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtLabel14 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel12 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel11 = New SaimtControles.SaimtLabel()
        Me.btnInteresado = New SaimtControles.SaimtButton()
        Me.TxtInteresado = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgvDatosAdicionales = New SaimtControles.SaimtDataGrid()
        Me.gvDatosAdicionales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colContacto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BackstageViewItemSeparator2 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BVTabRequisitos = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BVCCRequisitos = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.SaimtTabs2 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.TxtProcedimientoVer = New SaimtControles.SaimtTextBox()
        Me.dgvReqvsProc = New SaimtControles.SaimtDataGrid()
        Me.gvReqvsProc = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcTgId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SaimtLabel24 = New SaimtControles.SaimtLabel()
        Me.BackstageViewItemSeparator3 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BVTabMovimientos = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BVCCMovimientos = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewItemSeparator4 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.SaimtTabs3 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.BVTabObservaciones = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BVCCObservacion = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.TxtDocRef = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel30 = New SaimtControles.SaimtLabel()
        Me.txtcomentario = New SaimtControles.SaimtTextBoxMultiline()
        Me.SaimtLabel25 = New SaimtControles.SaimtLabel()
        Me.BackstageViewItemSeparator6 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.BVTabDocVinculados = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BVCCDocVinculados = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.dgvDocumentosVinculados = New SaimtControles.SaimtDataGrid()
        Me.lvDocumentosVinculados = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.LayoutViewColumn12 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn12 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn10 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
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
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemMemoExEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GBoxDatosAdicionales = New SaimtControles.SaimtGroupBox()
        Me.BackstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        Me.BackstageViewClientControl9 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewClientControl10 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewClientControl11 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewClientControl12 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewClientControl13 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewClientControl14 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewClientControl15 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewTabItem9 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewTabItem10 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewTabItem11 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewTabItem12 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewTabItem13 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewTabItem14 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewTabItem15 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewTabItem16 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewClientControl3 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewTabItem3 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewClientControl2 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewTabItem2 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.ofdExaminarArchivos = New System.Windows.Forms.OpenFileDialog()
        Me.btnEnviar = New SaimtControles.SaimtButton()
        Me.SaimtSplitContainerControl1 = New SaimtControles.SaimtSplitContainerControl()
        Me.btnBuscar = New SaimtControles.SaimtButton()
        Me.spaño = New SaimtControles.SaimtSpinner()
        Me.SaimtLabel49 = New SaimtControles.SaimtLabel()
        Me.cmbopciones = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.fbdExportar = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMovimientosDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GBoxDatosDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxDatosDocumento.SuspendLayout()
        CType(Me.txtDocAux.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoDocAux.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtProcedimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sCboTipoAccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDoc.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdocid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox6.SuspendLayout()
        CType(Me.spañoReg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sCboAreas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNdocReg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sTxtSiglas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtasunto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sRdbOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReqActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sRbTupac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssFolios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDocFechaIng.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDocFechaIng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.dgvListadoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListadoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox4.SuspendLayout()
        CType(Me.SaimtTextBox3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTextBoxMultiline2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BVCCInteresado.SuspendLayout()
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.btnInstitucionInt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDireccionPerInt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCboCargoInt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sCboAreaInt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInteresado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.dgvDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BVCCRequisitos.SuspendLayout()
        CType(Me.SaimtTabs2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.TxtProcedimientoVer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReqvsProc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReqvsProc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BVCCMovimientos.SuspendLayout()
        CType(Me.SaimtTabs3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs3.SuspendLayout()
        Me.BVCCObservacion.SuspendLayout()
        CType(Me.TxtDocRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcomentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BVCCDocVinculados.SuspendLayout()
        CType(Me.dgvDocumentosVinculados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvDocumentosVinculados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GBoxDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxDatosAdicionales.SuspendLayout()
        Me.BackstageViewControl1.SuspendLayout()
        Me.BackstageViewClientControl2.SuspendLayout()
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtSplitContainerControl1.SuspendLayout()
        CType(Me.spaño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbopciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 767)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1139, 27)
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
        'dgvMovimientos
        '
        Me.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.dgvMovimientos.MainView = Me.gvMovimientos
        Me.dgvMovimientos.MenuManager = Me.RibbonControl
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageComboBox1})
        Me.dgvMovimientos.Size = New System.Drawing.Size(588, 334)
        Me.dgvMovimientos.TabIndex = 0
        Me.dgvMovimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMovimientos, Me.gvMovimientosDet})
        '
        'gvMovimientos
        '
        Me.gvMovimientos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcPerNombreOrigen, Me.gcPerCargoOrigen, Me.gcPerNombreDestino, Me.gcPerCargoDestino, Me.gcMovDiasTenencia, Me.gcMovFechaRec, Me.gcTgEstadoMov, Me.gcMovFechaEnv, Me.gcMovTieneArch, Me.GridColumn10})
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
        Me.gcMovTieneArch.AppearanceCell.Options.UseTextOptions = True
        Me.gcMovTieneArch.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcMovTieneArch.AppearanceHeader.Image = CType(resources.GetObject("gcMovTieneArch.AppearanceHeader.Image"), System.Drawing.Image)
        Me.gcMovTieneArch.AppearanceHeader.Options.UseImage = True
        Me.gcMovTieneArch.Caption = " "
        Me.gcMovTieneArch.ColumnEdit = Me.RepositoryItemImageComboBox1
        Me.gcMovTieneArch.FieldName = "movTieneArch"
        Me.gcMovTieneArch.Image = Global.Presentacion.My.Resources.Resources.imag_visor16
        Me.gcMovTieneArch.Name = "gcMovTieneArch"
        Me.gcMovTieneArch.OptionsColumn.ReadOnly = True
        Me.gcMovTieneArch.Visible = True
        Me.gcMovTieneArch.VisibleIndex = 0
        Me.gcMovTieneArch.Width = 20
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemImageComboBox1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", True, 0)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        Me.RepositoryItemImageComboBox1.SmallImages = Me.ImageCollection1
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "page_white_word.png")
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "MovId"
        Me.GridColumn10.FieldName = "movId"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'GBoxDatosDocumento
        '
        Me.GBoxDatosDocumento.Controls.Add(Me.btnVisorDoc)
        Me.GBoxDatosDocumento.Controls.Add(Me.lblNroDoc)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel34)
        Me.GBoxDatosDocumento.Controls.Add(Me.txtDocAux)
        Me.GBoxDatosDocumento.Controls.Add(Me.cbTipoDocAux)
        Me.GBoxDatosDocumento.Controls.Add(Me.TxtProcedimiento)
        Me.GBoxDatosDocumento.Controls.Add(Me.sCboTipoAccion)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel33)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel32)
        Me.GBoxDatosDocumento.Controls.Add(Me.dtpFechaDoc)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel31)
        Me.GBoxDatosDocumento.Controls.Add(Me.btnProcedimiento)
        Me.GBoxDatosDocumento.Controls.Add(Me.txtdocid)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel29)
        Me.GBoxDatosDocumento.Controls.Add(Me.btnAnexos)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtGroupBox6)
        Me.GBoxDatosDocumento.Controls.Add(Me.txtasunto)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel10)
        Me.GBoxDatosDocumento.Controls.Add(Me.sRdbOrigen)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel2)
        Me.GBoxDatosDocumento.Controls.Add(Me.chkReqActivos)
        Me.GBoxDatosDocumento.Controls.Add(Me.sRbTupac)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel5)
        Me.GBoxDatosDocumento.Controls.Add(Me.ssFolios)
        Me.GBoxDatosDocumento.Controls.Add(Me.dtpDocFechaIng)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel13)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel8)
        Me.GBoxDatosDocumento.Controls.Add(Me.SaimtLabel7)
        Me.GBoxDatosDocumento.Controls.Add(Me.lblTipoDoc)
        Me.GBoxDatosDocumento.Location = New System.Drawing.Point(3, 6)
        Me.GBoxDatosDocumento.Name = "GBoxDatosDocumento"
        Me.GBoxDatosDocumento.Size = New System.Drawing.Size(750, 289)
        Me.GBoxDatosDocumento.TabIndex = 3
        Me.GBoxDatosDocumento.Text = "Datos del Documento"
        '
        'btnVisorDoc
        '
        Me.btnVisorDoc.Image = CType(resources.GetObject("btnVisorDoc.Image"), System.Drawing.Image)
        Me.btnVisorDoc.Location = New System.Drawing.Point(689, 147)
        Me.btnVisorDoc.Name = "btnVisorDoc"
        Me.btnVisorDoc.Size = New System.Drawing.Size(25, 21)
        Me.btnVisorDoc.TabIndex = 35
        Me.btnVisorDoc.Visible = False
        '
        'lblNroDoc
        '
        Me.lblNroDoc.Location = New System.Drawing.Point(404, 56)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(22, 13)
        Me.lblNroDoc.TabIndex = 34
        Me.lblNroDoc.Text = "Doc."
        '
        'SaimtLabel34
        '
        Me.SaimtLabel34.Location = New System.Drawing.Point(404, 56)
        Me.SaimtLabel34.Name = "SaimtLabel34"
        Me.SaimtLabel34.Size = New System.Drawing.Size(0, 13)
        Me.SaimtLabel34.TabIndex = 33
        '
        'txtDocAux
        '
        Me.txtDocAux.Location = New System.Drawing.Point(432, 53)
        Me.txtDocAux.MenuManager = Me.RibbonControl
        Me.txtDocAux.Name = "txtDocAux"
        Me.txtDocAux.Size = New System.Drawing.Size(285, 20)
        Me.txtDocAux.TabIndex = 32
        '
        'cbTipoDocAux
        '
        Me.cbTipoDocAux.Location = New System.Drawing.Point(279, 53)
        Me.cbTipoDocAux.MenuManager = Me.RibbonControl
        Me.cbTipoDocAux.Name = "cbTipoDocAux"
        Me.cbTipoDocAux.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoDocAux.Properties.NullText = ""
        Me.cbTipoDocAux.Size = New System.Drawing.Size(118, 20)
        Me.cbTipoDocAux.TabIndex = 8
        '
        'TxtProcedimiento
        '
        Me.TxtProcedimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtProcedimiento.Location = New System.Drawing.Point(99, 176)
        Me.TxtProcedimiento.MenuManager = Me.RibbonControl
        Me.TxtProcedimiento.Name = "TxtProcedimiento"
        Me.TxtProcedimiento.Size = New System.Drawing.Size(553, 20)
        Me.TxtProcedimiento.TabIndex = 19
        '
        'sCboTipoAccion
        '
        Me.sCboTipoAccion.Location = New System.Drawing.Point(432, 28)
        Me.sCboTipoAccion.MenuManager = Me.RibbonControl
        Me.sCboTipoAccion.Name = "sCboTipoAccion"
        Me.sCboTipoAccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sCboTipoAccion.Properties.NullText = ""
        Me.sCboTipoAccion.Size = New System.Drawing.Size(172, 20)
        Me.sCboTipoAccion.TabIndex = 4
        '
        'SaimtLabel33
        '
        Me.SaimtLabel33.Location = New System.Drawing.Point(329, 31)
        Me.SaimtLabel33.Name = "SaimtLabel33"
        Me.SaimtLabel33.Size = New System.Drawing.Size(88, 13)
        Me.SaimtLabel33.TabIndex = 2
        Me.SaimtLabel33.Text = "Accion Documento"
        '
        'SaimtLabel32
        '
        Me.SaimtLabel32.Location = New System.Drawing.Point(323, 31)
        Me.SaimtLabel32.Name = "SaimtLabel32"
        Me.SaimtLabel32.Size = New System.Drawing.Size(0, 13)
        Me.SaimtLabel32.TabIndex = 3
        '
        'dtpFechaDoc
        '
        Me.dtpFechaDoc.EditValue = Nothing
        Me.dtpFechaDoc.Location = New System.Drawing.Point(576, 150)
        Me.dtpFechaDoc.Name = "dtpFechaDoc"
        Me.dtpFechaDoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaDoc.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaDoc.Size = New System.Drawing.Size(107, 20)
        Me.dtpFechaDoc.TabIndex = 17
        '
        'SaimtLabel31
        '
        Me.SaimtLabel31.Location = New System.Drawing.Point(518, 153)
        Me.SaimtLabel31.Name = "SaimtLabel31"
        Me.SaimtLabel31.Size = New System.Drawing.Size(54, 13)
        Me.SaimtLabel31.TabIndex = 16
        Me.SaimtLabel31.Text = "Fecha Doc."
        '
        'btnProcedimiento
        '
        Me.btnProcedimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcedimiento.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnProcedimiento.Location = New System.Drawing.Point(658, 174)
        Me.btnProcedimiento.Name = "btnProcedimiento"
        Me.btnProcedimiento.Size = New System.Drawing.Size(24, 22)
        Me.btnProcedimiento.TabIndex = 20
        '
        'txtdocid
        '
        Me.txtdocid.Location = New System.Drawing.Point(99, 150)
        Me.txtdocid.MenuManager = Me.RibbonControl
        Me.txtdocid.Name = "txtdocid"
        Me.txtdocid.Size = New System.Drawing.Size(117, 20)
        Me.txtdocid.TabIndex = 11
        '
        'SaimtLabel29
        '
        Me.SaimtLabel29.Location = New System.Drawing.Point(44, 153)
        Me.SaimtLabel29.Name = "SaimtLabel29"
        Me.SaimtLabel29.Size = New System.Drawing.Size(48, 13)
        Me.SaimtLabel29.TabIndex = 10
        Me.SaimtLabel29.Text = "Cod. Doc."
        '
        'btnAnexos
        '
        Me.btnAnexos.Appearance.Options.UseTextOptions = True
        Me.btnAnexos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAnexos.Image = CType(resources.GetObject("btnAnexos.Image"), System.Drawing.Image)
        Me.btnAnexos.Location = New System.Drawing.Point(636, 17)
        Me.btnAnexos.Name = "btnAnexos"
        Me.btnAnexos.Size = New System.Drawing.Size(106, 34)
        Me.btnAnexos.TabIndex = 31
        Me.btnAnexos.Text = "Ver Documentos Anexos"
        '
        'SaimtGroupBox6
        '
        Me.SaimtGroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox6.Controls.Add(Me.spañoReg)
        Me.SaimtGroupBox6.Controls.Add(Me.btnInstitucion)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox6.Controls.Add(Me.sCboAreas)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel19)
        Me.SaimtGroupBox6.Controls.Add(Me.TxtNdocReg)
        Me.SaimtGroupBox6.Controls.Add(Me.sTxtSiglas)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel22)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel21)
        Me.SaimtGroupBox6.Controls.Add(Me.SaimtLabel20)
        Me.SaimtGroupBox6.Location = New System.Drawing.Point(6, 77)
        Me.SaimtGroupBox6.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox6.Name = "SaimtGroupBox6"
        Me.SaimtGroupBox6.Size = New System.Drawing.Size(731, 67)
        Me.SaimtGroupBox6.TabIndex = 9
        Me.SaimtGroupBox6.Text = "N° de Registro del Documento"
        '
        'spañoReg
        '
        Me.spañoReg.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spañoReg.Location = New System.Drawing.Point(66, 39)
        Me.spañoReg.MenuManager = Me.RibbonControl
        Me.spañoReg.Name = "spañoReg"
        Me.spañoReg.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spañoReg.Properties.Mask.EditMask = "n0"
        Me.spañoReg.Size = New System.Drawing.Size(64, 20)
        Me.spañoReg.TabIndex = 37
        '
        'btnInstitucion
        '
        Me.btnInstitucion.Location = New System.Drawing.Point(190, 39)
        Me.btnInstitucion.MenuManager = Me.RibbonControl
        Me.btnInstitucion.Name = "btnInstitucion"
        Me.btnInstitucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnInstitucion.Size = New System.Drawing.Size(281, 20)
        Me.btnInstitucion.TabIndex = 8
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(477, 24)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(23, 13)
        Me.SaimtLabel1.TabIndex = 4
        Me.SaimtLabel1.Text = "Área"
        '
        'sCboAreas
        '
        Me.sCboAreas.Location = New System.Drawing.Point(474, 39)
        Me.sCboAreas.MenuManager = Me.RibbonControl
        Me.sCboAreas.Name = "sCboAreas"
        Me.sCboAreas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sCboAreas.Properties.NullText = ""
        Me.sCboAreas.Size = New System.Drawing.Size(204, 20)
        Me.sCboAreas.TabIndex = 9
        '
        'SaimtLabel19
        '
        Me.SaimtLabel19.Location = New System.Drawing.Point(10, 24)
        Me.SaimtLabel19.Name = "SaimtLabel19"
        Me.SaimtLabel19.Size = New System.Drawing.Size(38, 13)
        Me.SaimtLabel19.TabIndex = 0
        Me.SaimtLabel19.Text = "Nº Reg."
        '
        'TxtNdocReg
        '
        Me.TxtNdocReg.Location = New System.Drawing.Point(7, 39)
        Me.TxtNdocReg.Name = "TxtNdocReg"
        Me.TxtNdocReg.Size = New System.Drawing.Size(55, 20)
        Me.TxtNdocReg.TabIndex = 5
        '
        'sTxtSiglas
        '
        Me.sTxtSiglas.Location = New System.Drawing.Point(133, 39)
        Me.sTxtSiglas.Name = "sTxtSiglas"
        Me.sTxtSiglas.Size = New System.Drawing.Size(55, 20)
        Me.sTxtSiglas.TabIndex = 7
        '
        'SaimtLabel22
        '
        Me.SaimtLabel22.Location = New System.Drawing.Point(193, 24)
        Me.SaimtLabel22.Name = "SaimtLabel22"
        Me.SaimtLabel22.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel22.TabIndex = 3
        Me.SaimtLabel22.Text = "Institución"
        '
        'SaimtLabel21
        '
        Me.SaimtLabel21.Location = New System.Drawing.Point(136, 24)
        Me.SaimtLabel21.Name = "SaimtLabel21"
        Me.SaimtLabel21.Size = New System.Drawing.Size(27, 13)
        Me.SaimtLabel21.TabIndex = 2
        Me.SaimtLabel21.Text = "Siglas"
        '
        'SaimtLabel20
        '
        Me.SaimtLabel20.Location = New System.Drawing.Point(70, 24)
        Me.SaimtLabel20.Name = "SaimtLabel20"
        Me.SaimtLabel20.Size = New System.Drawing.Size(19, 13)
        Me.SaimtLabel20.TabIndex = 1
        Me.SaimtLabel20.Text = "Año"
        '
        'txtasunto
        '
        Me.txtasunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtasunto.Location = New System.Drawing.Point(99, 202)
        Me.txtasunto.MenuManager = Me.RibbonControl
        Me.txtasunto.Name = "txtasunto"
        Me.txtasunto.Size = New System.Drawing.Size(580, 53)
        Me.txtasunto.TabIndex = 22
        Me.txtasunto.UseOptimizedRendering = True
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(59, 204)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(34, 13)
        Me.SaimtLabel10.TabIndex = 21
        Me.SaimtLabel10.Text = "Asunto"
        '
        'sRdbOrigen
        '
        Me.sRdbOrigen.EditValue = "1"
        Me.sRdbOrigen.Location = New System.Drawing.Point(103, 27)
        Me.sRdbOrigen.Name = "sRdbOrigen"
        Me.sRdbOrigen.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Doc. Interno"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Doc. Externo")})
        Me.sRdbOrigen.Size = New System.Drawing.Size(201, 22)
        Me.sRdbOrigen.TabIndex = 1
        Me.sRdbOrigen.Tag = "0"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(7, 31)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(89, 13)
        Me.SaimtLabel2.TabIndex = 0
        Me.SaimtLabel2.Text = "Origen Documento"
        '
        'chkReqActivos
        '
        Me.chkReqActivos.Location = New System.Drawing.Point(11, 258)
        Me.chkReqActivos.MenuManager = Me.RibbonControl
        Me.chkReqActivos.Name = "chkReqActivos"
        Me.chkReqActivos.Properties.AutoWidth = True
        Me.chkReqActivos.Properties.Caption = "Active el check si todos los Requisitos estan completos."
        Me.chkReqActivos.Size = New System.Drawing.Size(286, 19)
        Me.chkReqActivos.TabIndex = 30
        '
        'sRbTupac
        '
        Me.sRbTupac.Location = New System.Drawing.Point(103, 53)
        Me.sRbTupac.Name = "sRbTupac"
        Me.sRbTupac.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Si"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "No")})
        Me.sRbTupac.Size = New System.Drawing.Size(91, 20)
        Me.sRbTupac.TabIndex = 6
        Me.sRbTupac.Tag = "0"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(70, 56)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(26, 13)
        Me.SaimtLabel5.TabIndex = 5
        Me.SaimtLabel5.Text = "TUPA"
        '
        'ssFolios
        '
        Me.ssFolios.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ssFolios.Location = New System.Drawing.Point(268, 150)
        Me.ssFolios.Name = "ssFolios"
        Me.ssFolios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ssFolios.Properties.Mask.EditMask = "n0"
        Me.ssFolios.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.ssFolios.Size = New System.Drawing.Size(63, 20)
        Me.ssFolios.TabIndex = 13
        '
        'dtpDocFechaIng
        '
        Me.dtpDocFechaIng.EditValue = Nothing
        Me.dtpDocFechaIng.Location = New System.Drawing.Point(412, 150)
        Me.dtpDocFechaIng.Name = "dtpDocFechaIng"
        Me.dtpDocFechaIng.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDocFechaIng.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDocFechaIng.Size = New System.Drawing.Size(95, 20)
        Me.dtpDocFechaIng.TabIndex = 15
        '
        'SaimtLabel13
        '
        Me.SaimtLabel13.Location = New System.Drawing.Point(16, 179)
        Me.SaimtLabel13.Name = "SaimtLabel13"
        Me.SaimtLabel13.Size = New System.Drawing.Size(79, 13)
        Me.SaimtLabel13.TabIndex = 18
        Me.SaimtLabel13.Text = "Procedimientos :"
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(222, 153)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(42, 13)
        Me.SaimtLabel8.TabIndex = 12
        Me.SaimtLabel8.Text = "Nº Folios"
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(339, 153)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(69, 13)
        Me.SaimtLabel7.TabIndex = 14
        Me.SaimtLabel7.Text = "Fecha Ingreso"
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.Location = New System.Drawing.Point(199, 56)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(77, 13)
        Me.lblTipoDoc.TabIndex = 7
        Me.lblTipoDoc.Text = "Tipo Documento"
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox1.Controls.Add(Me.dgvListadoDocumento)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(6, 88)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(352, 645)
        Me.SaimtGroupBox1.TabIndex = 4
        Me.SaimtGroupBox1.Text = "Resultados de Busqueda"
        '
        'dgvListadoDocumento
        '
        Me.dgvListadoDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoDocumento.Location = New System.Drawing.Point(2, 21)
        Me.dgvListadoDocumento.MainView = Me.gvListadoDocumento
        Me.dgvListadoDocumento.MenuManager = Me.RibbonControl
        Me.dgvListadoDocumento.Name = "dgvListadoDocumento"
        Me.dgvListadoDocumento.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit6})
        Me.dgvListadoDocumento.Size = New System.Drawing.Size(348, 622)
        Me.dgvListadoDocumento.TabIndex = 1
        Me.dgvListadoDocumento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListadoDocumento})
        '
        'gvListadoDocumento
        '
        Me.gvListadoDocumento.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.gvListadoDocumento.GridControl = Me.dgvListadoDocumento
        Me.gvListadoDocumento.Name = "gvListadoDocumento"
        Me.gvListadoDocumento.OptionsBehavior.ReadOnly = True
        Me.gvListadoDocumento.OptionsView.ColumnAutoWidth = False
        Me.gvListadoDocumento.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "N° Registro"
        Me.GridColumn5.FieldName = "docNRegT"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha Registro"
        Me.GridColumn6.FieldName = "docFechaReg"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha Ingreso"
        Me.GridColumn7.FieldName = "docFechaIng"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Asunto"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemMemoExEdit6
        Me.GridColumn8.FieldName = "docAsunto"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'RepositoryItemMemoExEdit6
        '
        Me.RepositoryItemMemoExEdit6.AutoHeight = False
        Me.RepositoryItemMemoExEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit6.Name = "RepositoryItemMemoExEdit6"
        Me.RepositoryItemMemoExEdit6.ShowIcon = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Cod. Doc."
        Me.GridColumn9.FieldName = "docId"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'TxtBuscarPor
        '
        Me.TxtBuscarPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarPor.Location = New System.Drawing.Point(8, 63)
        Me.TxtBuscarPor.Name = "TxtBuscarPor"
        Me.TxtBuscarPor.Size = New System.Drawing.Size(348, 20)
        Me.TxtBuscarPor.TabIndex = 2
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(9, 22)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(58, 13)
        Me.SaimtLabel4.TabIndex = 0
        Me.SaimtLabel4.Text = "Buscar por :"
        '
        'SaimtGroupBox4
        '
        Me.SaimtGroupBox4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SaimtGroupBox4.Appearance.Options.UseBackColor = True
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtTextBox3)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel17)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtTextBoxMultiline2)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtComboBoxLookUpUpdate7)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel18)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtComboBoxLookUpUpdate8)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel16)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel15)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtButton2)
        Me.SaimtGroupBox4.Location = New System.Drawing.Point(6, 7)
        Me.SaimtGroupBox4.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox4.Name = "SaimtGroupBox4"
        Me.SaimtGroupBox4.Size = New System.Drawing.Size(467, 221)
        Me.SaimtGroupBox4.TabIndex = 13
        Me.SaimtGroupBox4.Text = "Datos del Interesado"
        '
        'SaimtTextBox3
        '
        Me.SaimtTextBox3.Location = New System.Drawing.Point(10, 42)
        Me.SaimtTextBox3.MenuManager = Me.RibbonControl
        Me.SaimtTextBox3.Name = "SaimtTextBox3"
        Me.SaimtTextBox3.Size = New System.Drawing.Size(391, 20)
        Me.SaimtTextBox3.TabIndex = 20
        '
        'SaimtLabel17
        '
        Me.SaimtLabel17.Location = New System.Drawing.Point(228, 74)
        Me.SaimtLabel17.Name = "SaimtLabel17"
        Me.SaimtLabel17.Size = New System.Drawing.Size(124, 13)
        Me.SaimtLabel17.TabIndex = 16
        Me.SaimtLabel17.Text = "Encargado o Responsable"
        '
        'SaimtTextBoxMultiline2
        '
        Me.SaimtTextBoxMultiline2.Location = New System.Drawing.Point(113, 114)
        Me.SaimtTextBoxMultiline2.Name = "SaimtTextBoxMultiline2"
        Me.SaimtTextBoxMultiline2.Size = New System.Drawing.Size(347, 34)
        Me.SaimtTextBoxMultiline2.TabIndex = 19
        Me.SaimtTextBoxMultiline2.UseOptimizedRendering = True
        '
        'SaimtComboBoxLookUpUpdate7
        '
        Me.SaimtComboBoxLookUpUpdate7.Entidad = SaimtControles.SaimtComboBoxLookUpUpdate.Entidades.Ninguno
        Me.SaimtComboBoxLookUpUpdate7.Location = New System.Drawing.Point(19, 90)
        Me.SaimtComboBoxLookUpUpdate7.MinimumSize = New System.Drawing.Size(100, 20)
        Me.SaimtComboBoxLookUpUpdate7.Name = "SaimtComboBoxLookUpUpdate7"
        Me.SaimtComboBoxLookUpUpdate7.Size = New System.Drawing.Size(195, 21)
        Me.SaimtComboBoxLookUpUpdate7.TabIndex = 18
        '
        'SaimtLabel18
        '
        Me.SaimtLabel18.Location = New System.Drawing.Point(34, 117)
        Me.SaimtLabel18.Name = "SaimtLabel18"
        Me.SaimtLabel18.Size = New System.Drawing.Size(71, 13)
        Me.SaimtLabel18.TabIndex = 15
        Me.SaimtLabel18.Text = "Observaciones"
        '
        'SaimtComboBoxLookUpUpdate8
        '
        Me.SaimtComboBoxLookUpUpdate8.Entidad = SaimtControles.SaimtComboBoxLookUpUpdate.Entidades.Ninguno
        Me.SaimtComboBoxLookUpUpdate8.Location = New System.Drawing.Point(224, 90)
        Me.SaimtComboBoxLookUpUpdate8.MinimumSize = New System.Drawing.Size(100, 20)
        Me.SaimtComboBoxLookUpUpdate8.Name = "SaimtComboBoxLookUpUpdate8"
        Me.SaimtComboBoxLookUpUpdate8.Size = New System.Drawing.Size(236, 21)
        Me.SaimtComboBoxLookUpUpdate8.TabIndex = 17
        '
        'SaimtLabel16
        '
        Me.SaimtLabel16.Location = New System.Drawing.Point(23, 74)
        Me.SaimtLabel16.Name = "SaimtLabel16"
        Me.SaimtLabel16.Size = New System.Drawing.Size(104, 13)
        Me.SaimtLabel16.TabIndex = 14
        Me.SaimtLabel16.Text = "Area o Departamente"
        '
        'SaimtLabel15
        '
        Me.SaimtLabel15.Location = New System.Drawing.Point(12, 27)
        Me.SaimtLabel15.Name = "SaimtLabel15"
        Me.SaimtLabel15.Size = New System.Drawing.Size(53, 13)
        Me.SaimtLabel15.TabIndex = 3
        Me.SaimtLabel15.Text = "Interesado"
        '
        'SaimtButton2
        '
        Me.SaimtButton2.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.SaimtButton2.Location = New System.Drawing.Point(407, 40)
        Me.SaimtButton2.Name = "SaimtButton2"
        Me.SaimtButton2.Size = New System.Drawing.Size(24, 22)
        Me.SaimtButton2.TabIndex = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancelar.Location = New System.Drawing.Point(238, 672)
        Me.btnCancelar.LookAndFeel.SkinName = "Seven"
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(378, 672)
        Me.btnEliminar.LookAndFeel.SkinName = "Seven"
        Me.btnEliminar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 64)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(168, 672)
        Me.btnLimpiar.LookAndFeel.SkinName = "Seven"
        Me.btnLimpiar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 64)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(28, 672)
        Me.btnNuevo.LookAndFeel.SkinName = "Seven"
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(308, 672)
        Me.btnGuardar.LookAndFeel.SkinName = "Seven"
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(98, 672)
        Me.btnEditar.LookAndFeel.SkinName = "Seven"
        Me.btnEditar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 64)
        Me.btnEditar.TabIndex = 7
        Me.btnEditar.Text = "Editar"
        '
        'BackstageViewItemSeparator1
        '
        Me.BackstageViewItemSeparator1.Name = "BackstageViewItemSeparator1"
        '
        'BVTabInteresado
        '
        Me.BVTabInteresado.Caption = "Interesado"
        Me.BVTabInteresado.ContentControl = Me.BVCCInteresado
        Me.BVTabInteresado.Glyph = CType(resources.GetObject("BVTabInteresado.Glyph"), System.Drawing.Image)
        Me.BVTabInteresado.Name = "BVTabInteresado"
        Me.BVTabInteresado.Selected = False
        '
        'BVCCInteresado
        '
        Me.BVCCInteresado.Controls.Add(Me.SaimtTabs1)
        Me.BVCCInteresado.Location = New System.Drawing.Point(158, 0)
        Me.BVCCInteresado.Name = "BVCCInteresado"
        Me.BVCCInteresado.Size = New System.Drawing.Size(588, 334)
        Me.BVCCInteresado.TabIndex = 0
        '
        'SaimtTabs1
        '
        Me.SaimtTabs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtTabs1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtTabs1.Name = "SaimtTabs1"
        Me.SaimtTabs1.SelectedTabPage = Me.XtraTabPage1
        Me.SaimtTabs1.Size = New System.Drawing.Size(567, 334)
        Me.SaimtTabs1.TabIndex = 0
        Me.SaimtTabs1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnInstitucionInt)
        Me.XtraTabPage1.Controls.Add(Me.TxtDireccionPerInt)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel23)
        Me.XtraTabPage1.Controls.Add(Me.SCboCargoInt)
        Me.XtraTabPage1.Controls.Add(Me.sCboAreaInt)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel14)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel12)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel11)
        Me.XtraTabPage1.Controls.Add(Me.btnInteresado)
        Me.XtraTabPage1.Controls.Add(Me.TxtInteresado)
        Me.XtraTabPage1.Controls.Add(Me.SaimtLabel9)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(561, 306)
        Me.XtraTabPage1.Text = "Datos del Interesado"
        '
        'btnInstitucionInt
        '
        Me.btnInstitucionInt.Location = New System.Drawing.Point(71, 117)
        Me.btnInstitucionInt.MenuManager = Me.RibbonControl
        Me.btnInstitucionInt.Name = "btnInstitucionInt"
        Me.btnInstitucionInt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnInstitucionInt.Size = New System.Drawing.Size(472, 20)
        Me.btnInstitucionInt.TabIndex = 11
        '
        'TxtDireccionPerInt
        '
        Me.TxtDireccionPerInt.Location = New System.Drawing.Point(71, 48)
        Me.TxtDireccionPerInt.MenuManager = Me.RibbonControl
        Me.TxtDireccionPerInt.Name = "TxtDireccionPerInt"
        Me.TxtDireccionPerInt.Properties.ReadOnly = True
        Me.TxtDireccionPerInt.Size = New System.Drawing.Size(472, 61)
        Me.TxtDireccionPerInt.TabIndex = 4
        Me.TxtDireccionPerInt.UseOptimizedRendering = True
        '
        'SaimtLabel23
        '
        Me.SaimtLabel23.Location = New System.Drawing.Point(22, 51)
        Me.SaimtLabel23.Name = "SaimtLabel23"
        Me.SaimtLabel23.Size = New System.Drawing.Size(43, 13)
        Me.SaimtLabel23.TabIndex = 3
        Me.SaimtLabel23.Text = "Dirección"
        '
        'SCboCargoInt
        '
        Me.SCboCargoInt.Location = New System.Drawing.Point(71, 169)
        Me.SCboCargoInt.MenuManager = Me.RibbonControl
        Me.SCboCargoInt.Name = "SCboCargoInt"
        Me.SCboCargoInt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SCboCargoInt.Properties.NullText = ""
        Me.SCboCargoInt.Size = New System.Drawing.Size(472, 20)
        Me.SCboCargoInt.TabIndex = 10
        '
        'sCboAreaInt
        '
        Me.sCboAreaInt.Location = New System.Drawing.Point(71, 143)
        Me.sCboAreaInt.MenuManager = Me.RibbonControl
        Me.sCboAreaInt.Name = "sCboAreaInt"
        Me.sCboAreaInt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sCboAreaInt.Properties.NullText = ""
        Me.sCboAreaInt.Size = New System.Drawing.Size(472, 20)
        Me.sCboAreaInt.TabIndex = 8
        '
        'SaimtLabel14
        '
        Me.SaimtLabel14.Location = New System.Drawing.Point(36, 172)
        Me.SaimtLabel14.Name = "SaimtLabel14"
        Me.SaimtLabel14.Size = New System.Drawing.Size(29, 13)
        Me.SaimtLabel14.TabIndex = 9
        Me.SaimtLabel14.Text = "Cargo"
        '
        'SaimtLabel12
        '
        Me.SaimtLabel12.Location = New System.Drawing.Point(39, 146)
        Me.SaimtLabel12.Name = "SaimtLabel12"
        Me.SaimtLabel12.Size = New System.Drawing.Size(26, 13)
        Me.SaimtLabel12.TabIndex = 7
        Me.SaimtLabel12.Text = "Área "
        '
        'SaimtLabel11
        '
        Me.SaimtLabel11.Location = New System.Drawing.Point(15, 121)
        Me.SaimtLabel11.Name = "SaimtLabel11"
        Me.SaimtLabel11.Size = New System.Drawing.Size(50, 13)
        Me.SaimtLabel11.TabIndex = 5
        Me.SaimtLabel11.Text = "Institución"
        '
        'btnInteresado
        '
        Me.btnInteresado.Image = CType(resources.GetObject("btnInteresado.Image"), System.Drawing.Image)
        Me.btnInteresado.Location = New System.Drawing.Point(544, 20)
        Me.btnInteresado.Name = "btnInteresado"
        Me.btnInteresado.Size = New System.Drawing.Size(23, 23)
        Me.btnInteresado.TabIndex = 2
        '
        'TxtInteresado
        '
        Me.TxtInteresado.Location = New System.Drawing.Point(71, 22)
        Me.TxtInteresado.MenuManager = Me.RibbonControl
        Me.TxtInteresado.Name = "TxtInteresado"
        Me.TxtInteresado.Properties.ReadOnly = True
        Me.TxtInteresado.Size = New System.Drawing.Size(472, 20)
        Me.TxtInteresado.TabIndex = 1
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(12, 25)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(53, 13)
        Me.SaimtLabel9.TabIndex = 0
        Me.SaimtLabel9.Text = "Interesado"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.dgvDatosAdicionales)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(561, 306)
        Me.XtraTabPage2.Text = "Datos Adicionales del Interesado"
        '
        'dgvDatosAdicionales
        '
        Me.dgvDatosAdicionales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDatosAdicionales.Location = New System.Drawing.Point(0, 0)
        Me.dgvDatosAdicionales.MainView = Me.gvDatosAdicionales
        Me.dgvDatosAdicionales.MenuManager = Me.RibbonControl
        Me.dgvDatosAdicionales.Name = "dgvDatosAdicionales"
        Me.dgvDatosAdicionales.Size = New System.Drawing.Size(561, 306)
        Me.dgvDatosAdicionales.TabIndex = 0
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
        'BackstageViewItemSeparator2
        '
        Me.BackstageViewItemSeparator2.Name = "BackstageViewItemSeparator2"
        '
        'BVTabRequisitos
        '
        Me.BVTabRequisitos.Caption = "Requisitos"
        Me.BVTabRequisitos.ContentControl = Me.BVCCRequisitos
        Me.BVTabRequisitos.Glyph = CType(resources.GetObject("BVTabRequisitos.Glyph"), System.Drawing.Image)
        Me.BVTabRequisitos.Name = "BVTabRequisitos"
        Me.BVTabRequisitos.Selected = False
        '
        'BVCCRequisitos
        '
        Me.BVCCRequisitos.Controls.Add(Me.SaimtTabs2)
        Me.BVCCRequisitos.Location = New System.Drawing.Point(158, 0)
        Me.BVCCRequisitos.Name = "BVCCRequisitos"
        Me.BVCCRequisitos.Size = New System.Drawing.Size(588, 334)
        Me.BVCCRequisitos.TabIndex = 1
        '
        'SaimtTabs2
        '
        Me.SaimtTabs2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtTabs2.Location = New System.Drawing.Point(0, 0)
        Me.SaimtTabs2.Name = "SaimtTabs2"
        Me.SaimtTabs2.SelectedTabPage = Me.XtraTabPage3
        Me.SaimtTabs2.Size = New System.Drawing.Size(567, 334)
        Me.SaimtTabs2.TabIndex = 0
        Me.SaimtTabs2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.TxtProcedimientoVer)
        Me.XtraTabPage3.Controls.Add(Me.dgvReqvsProc)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel24)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(561, 306)
        Me.XtraTabPage3.Text = "Agregar Requisitos"
        '
        'TxtProcedimientoVer
        '
        Me.TxtProcedimientoVer.Location = New System.Drawing.Point(83, 10)
        Me.TxtProcedimientoVer.MenuManager = Me.RibbonControl
        Me.TxtProcedimientoVer.Name = "TxtProcedimientoVer"
        Me.TxtProcedimientoVer.Size = New System.Drawing.Size(442, 20)
        Me.TxtProcedimientoVer.TabIndex = 1
        '
        'dgvReqvsProc
        '
        Me.dgvReqvsProc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReqvsProc.Location = New System.Drawing.Point(4, 36)
        Me.dgvReqvsProc.MainView = Me.gvReqvsProc
        Me.dgvReqvsProc.MenuManager = Me.RibbonControl
        Me.dgvReqvsProc.Name = "dgvReqvsProc"
        Me.dgvReqvsProc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4, Me.RepositoryItemMemoExEdit2})
        Me.dgvReqvsProc.Size = New System.Drawing.Size(554, 268)
        Me.dgvReqvsProc.TabIndex = 2
        Me.dgvReqvsProc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvReqvsProc, Me.GridView3})
        '
        'gvReqvsProc
        '
        Me.gvReqvsProc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcTgId, Me.GridColumn1, Me.GridColumn3, Me.GridColumn2, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn4})
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
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.GridColumn2.FieldName = "requisito"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Nro. Orden"
        Me.GridColumn16.FieldName = "nOrden"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 2
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Es Obligatorio"
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn17.FieldName = "tgActivo"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 3
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Observación"
        Me.GridColumn18.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn18.FieldName = "tgDescripcion"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 4
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Presento"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemCheckEdit4
        Me.GridColumn4.FieldName = "reqPresento"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Caption = "Check"
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.dgvReqvsProc
        Me.GridView3.Name = "GridView3"
        '
        'SaimtLabel24
        '
        Me.SaimtLabel24.Location = New System.Drawing.Point(10, 13)
        Me.SaimtLabel24.Name = "SaimtLabel24"
        Me.SaimtLabel24.Size = New System.Drawing.Size(67, 13)
        Me.SaimtLabel24.TabIndex = 0
        Me.SaimtLabel24.Text = "Procedimiento"
        '
        'BackstageViewItemSeparator3
        '
        Me.BackstageViewItemSeparator3.Name = "BackstageViewItemSeparator3"
        '
        'BVTabMovimientos
        '
        Me.BVTabMovimientos.Caption = "Movimientos"
        Me.BVTabMovimientos.ContentControl = Me.BVCCMovimientos
        Me.BVTabMovimientos.Glyph = CType(resources.GetObject("BVTabMovimientos.Glyph"), System.Drawing.Image)
        Me.BVTabMovimientos.Name = "BVTabMovimientos"
        Me.BVTabMovimientos.Selected = True
        '
        'BVCCMovimientos
        '
        Me.BVCCMovimientos.Controls.Add(Me.dgvMovimientos)
        Me.BVCCMovimientos.Location = New System.Drawing.Point(158, 0)
        Me.BVCCMovimientos.Name = "BVCCMovimientos"
        Me.BVCCMovimientos.Size = New System.Drawing.Size(588, 334)
        Me.BVCCMovimientos.TabIndex = 2
        '
        'BackstageViewItemSeparator4
        '
        Me.BackstageViewItemSeparator4.Name = "BackstageViewItemSeparator4"
        '
        'SaimtTabs3
        '
        Me.SaimtTabs3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtTabs3.Location = New System.Drawing.Point(0, 0)
        Me.SaimtTabs3.Name = "SaimtTabs3"
        Me.SaimtTabs3.SelectedTabPage = Me.XtraTabPage4
        Me.SaimtTabs3.Size = New System.Drawing.Size(565, 351)
        Me.SaimtTabs3.TabIndex = 0
        Me.SaimtTabs3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage4})
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(557, 323)
        Me.XtraTabPage4.Text = "Lista de Archivos"
        '
        'BVTabObservaciones
        '
        Me.BVTabObservaciones.Caption = "Observaciones"
        Me.BVTabObservaciones.ContentControl = Me.BVCCObservacion
        Me.BVTabObservaciones.Glyph = CType(resources.GetObject("BVTabObservaciones.Glyph"), System.Drawing.Image)
        Me.BVTabObservaciones.Name = "BVTabObservaciones"
        Me.BVTabObservaciones.Selected = False
        '
        'BVCCObservacion
        '
        Me.BVCCObservacion.Controls.Add(Me.TxtDocRef)
        Me.BVCCObservacion.Controls.Add(Me.SaimtLabel30)
        Me.BVCCObservacion.Controls.Add(Me.txtcomentario)
        Me.BVCCObservacion.Controls.Add(Me.SaimtLabel25)
        Me.BVCCObservacion.Location = New System.Drawing.Point(158, 0)
        Me.BVCCObservacion.Name = "BVCCObservacion"
        Me.BVCCObservacion.Size = New System.Drawing.Size(588, 334)
        Me.BVCCObservacion.TabIndex = 4
        '
        'TxtDocRef
        '
        Me.TxtDocRef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDocRef.Location = New System.Drawing.Point(94, 14)
        Me.TxtDocRef.MenuManager = Me.RibbonControl
        Me.TxtDocRef.Name = "TxtDocRef"
        Me.TxtDocRef.Size = New System.Drawing.Size(457, 20)
        Me.TxtDocRef.TabIndex = 5
        '
        'SaimtLabel30
        '
        Me.SaimtLabel30.Location = New System.Drawing.Point(11, 17)
        Me.SaimtLabel30.Name = "SaimtLabel30"
        Me.SaimtLabel30.Size = New System.Drawing.Size(77, 13)
        Me.SaimtLabel30.TabIndex = 4
        Me.SaimtLabel30.Text = "Doc. Referencia"
        '
        'txtcomentario
        '
        Me.txtcomentario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcomentario.Location = New System.Drawing.Point(6, 73)
        Me.txtcomentario.MenuManager = Me.RibbonControl
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(545, 265)
        Me.txtcomentario.TabIndex = 3
        Me.txtcomentario.UseOptimizedRendering = True
        '
        'SaimtLabel25
        '
        Me.SaimtLabel25.Location = New System.Drawing.Point(9, 54)
        Me.SaimtLabel25.Name = "SaimtLabel25"
        Me.SaimtLabel25.Size = New System.Drawing.Size(112, 13)
        Me.SaimtLabel25.TabIndex = 2
        Me.SaimtLabel25.Text = "Comentario Documento"
        '
        'BackstageViewItemSeparator6
        '
        Me.BackstageViewItemSeparator6.Name = "BackstageViewItemSeparator6"
        '
        'BVTabDocVinculados
        '
        Me.BVTabDocVinculados.Caption = "Doc. Vinculados"
        Me.BVTabDocVinculados.ContentControl = Me.BVCCDocVinculados
        Me.BVTabDocVinculados.Glyph = CType(resources.GetObject("BVTabDocVinculados.Glyph"), System.Drawing.Image)
        Me.BVTabDocVinculados.Name = "BVTabDocVinculados"
        Me.BVTabDocVinculados.Selected = False
        '
        'BVCCDocVinculados
        '
        Me.BVCCDocVinculados.Controls.Add(Me.dgvDocumentosVinculados)
        Me.BVCCDocVinculados.Location = New System.Drawing.Point(158, 0)
        Me.BVCCDocVinculados.Name = "BVCCDocVinculados"
        Me.BVCCDocVinculados.Size = New System.Drawing.Size(588, 334)
        Me.BVCCDocVinculados.TabIndex = 5
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
        Me.dgvDocumentosVinculados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit4, Me.RepositoryItemMemoExEdit5, Me.RepositoryItemMemoExEdit3})
        Me.dgvDocumentosVinculados.Size = New System.Drawing.Size(551, 335)
        Me.dgvDocumentosVinculados.TabIndex = 1
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
        Me.LayoutViewColumn10.ColumnEdit = Me.RepositoryItemMemoExEdit3
        Me.LayoutViewColumn10.FieldName = "docAsunto"
        Me.LayoutViewColumn10.LayoutViewField = Me.layoutViewField_LayoutViewColumn10
        Me.LayoutViewColumn10.Name = "LayoutViewColumn10"
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
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
        'RepositoryItemMemoExEdit4
        '
        Me.RepositoryItemMemoExEdit4.AutoHeight = False
        Me.RepositoryItemMemoExEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit4.Name = "RepositoryItemMemoExEdit4"
        Me.RepositoryItemMemoExEdit4.ShowIcon = False
        '
        'RepositoryItemMemoExEdit5
        '
        Me.RepositoryItemMemoExEdit5.AutoHeight = False
        Me.RepositoryItemMemoExEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit5.Name = "RepositoryItemMemoExEdit5"
        Me.RepositoryItemMemoExEdit5.ShowIcon = False
        '
        'GBoxDatosAdicionales
        '
        Me.GBoxDatosAdicionales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBoxDatosAdicionales.Controls.Add(Me.BackstageViewControl1)
        Me.GBoxDatosAdicionales.Location = New System.Drawing.Point(3, 309)
        Me.GBoxDatosAdicionales.Name = "GBoxDatosAdicionales"
        Me.GBoxDatosAdicionales.Size = New System.Drawing.Size(750, 357)
        Me.GBoxDatosAdicionales.TabIndex = 5
        Me.GBoxDatosAdicionales.Text = "Datos Adicionales"
        '
        'BackstageViewControl1
        '
        Me.BackstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow
        Me.BackstageViewControl1.Controls.Add(Me.BVCCInteresado)
        Me.BackstageViewControl1.Controls.Add(Me.BVCCRequisitos)
        Me.BackstageViewControl1.Controls.Add(Me.BVCCMovimientos)
        Me.BackstageViewControl1.Controls.Add(Me.BVCCObservacion)
        Me.BackstageViewControl1.Controls.Add(Me.BVCCDocVinculados)
        Me.BackstageViewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator1)
        Me.BackstageViewControl1.Items.Add(Me.BVTabInteresado)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator2)
        Me.BackstageViewControl1.Items.Add(Me.BVTabRequisitos)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator3)
        Me.BackstageViewControl1.Items.Add(Me.BVTabMovimientos)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator4)
        Me.BackstageViewControl1.Items.Add(Me.BVTabObservaciones)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewItemSeparator6)
        Me.BackstageViewControl1.Items.Add(Me.BVTabDocVinculados)
        Me.BackstageViewControl1.Location = New System.Drawing.Point(2, 21)
        Me.BackstageViewControl1.Name = "BackstageViewControl1"
        Me.BackstageViewControl1.SelectedTab = Me.BVTabMovimientos
        Me.BackstageViewControl1.SelectedTabIndex = 5
        Me.BackstageViewControl1.Size = New System.Drawing.Size(746, 334)
        Me.BackstageViewControl1.TabIndex = 0
        Me.BackstageViewControl1.Text = "BackstageViewControl1"
        '
        'BackstageViewClientControl9
        '
        Me.BackstageViewClientControl9.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl9.Name = "BackstageViewClientControl9"
        Me.BackstageViewClientControl9.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl9.TabIndex = 0
        '
        'BackstageViewClientControl10
        '
        Me.BackstageViewClientControl10.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl10.Name = "BackstageViewClientControl10"
        Me.BackstageViewClientControl10.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl10.TabIndex = 0
        '
        'BackstageViewClientControl11
        '
        Me.BackstageViewClientControl11.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl11.Name = "BackstageViewClientControl11"
        Me.BackstageViewClientControl11.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl11.TabIndex = 0
        '
        'BackstageViewClientControl12
        '
        Me.BackstageViewClientControl12.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl12.Name = "BackstageViewClientControl12"
        Me.BackstageViewClientControl12.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl12.TabIndex = 0
        '
        'BackstageViewClientControl13
        '
        Me.BackstageViewClientControl13.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl13.Name = "BackstageViewClientControl13"
        Me.BackstageViewClientControl13.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl13.TabIndex = 0
        '
        'BackstageViewClientControl14
        '
        Me.BackstageViewClientControl14.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl14.Name = "BackstageViewClientControl14"
        Me.BackstageViewClientControl14.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl14.TabIndex = 0
        '
        'BackstageViewClientControl15
        '
        Me.BackstageViewClientControl15.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl15.Name = "BackstageViewClientControl15"
        Me.BackstageViewClientControl15.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl15.TabIndex = 0
        '
        'BackstageViewTabItem9
        '
        Me.BackstageViewTabItem9.Name = "BackstageViewTabItem9"
        Me.BackstageViewTabItem9.Selected = False
        '
        'BackstageViewTabItem10
        '
        Me.BackstageViewTabItem10.Name = "BackstageViewTabItem10"
        Me.BackstageViewTabItem10.Selected = False
        '
        'BackstageViewTabItem11
        '
        Me.BackstageViewTabItem11.Name = "BackstageViewTabItem11"
        Me.BackstageViewTabItem11.Selected = False
        '
        'BackstageViewTabItem12
        '
        Me.BackstageViewTabItem12.Name = "BackstageViewTabItem12"
        Me.BackstageViewTabItem12.Selected = False
        '
        'BackstageViewTabItem13
        '
        Me.BackstageViewTabItem13.Name = "BackstageViewTabItem13"
        Me.BackstageViewTabItem13.Selected = False
        '
        'BackstageViewTabItem14
        '
        Me.BackstageViewTabItem14.Name = "BackstageViewTabItem14"
        Me.BackstageViewTabItem14.Selected = False
        '
        'BackstageViewTabItem15
        '
        Me.BackstageViewTabItem15.Name = "BackstageViewTabItem15"
        Me.BackstageViewTabItem15.Selected = False
        '
        'BackstageViewTabItem16
        '
        Me.BackstageViewTabItem16.Name = "BackstageViewTabItem16"
        Me.BackstageViewTabItem16.Selected = False
        '
        'BackstageViewClientControl3
        '
        Me.BackstageViewClientControl3.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl3.Name = "BackstageViewClientControl3"
        Me.BackstageViewClientControl3.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl3.TabIndex = 0
        '
        'BackstageViewTabItem3
        '
        Me.BackstageViewTabItem3.Caption = "Anexos"
        Me.BackstageViewTabItem3.ContentControl = Me.BackstageViewClientControl3
        Me.BackstageViewTabItem3.Name = "BackstageViewTabItem3"
        Me.BackstageViewTabItem3.Selected = False
        '
        'BackstageViewClientControl2
        '
        Me.BackstageViewClientControl2.Controls.Add(Me.SaimtGroupBox4)
        Me.BackstageViewClientControl2.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl2.Name = "BackstageViewClientControl2"
        Me.BackstageViewClientControl2.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl2.TabIndex = 1
        '
        'BackstageViewTabItem2
        '
        Me.BackstageViewTabItem2.Caption = "Interesado"
        Me.BackstageViewTabItem2.ContentControl = Me.BackstageViewClientControl2
        Me.BackstageViewTabItem2.Glyph = CType(resources.GetObject("BackstageViewTabItem2.Glyph"), System.Drawing.Image)
        Me.BackstageViewTabItem2.Name = "BackstageViewTabItem2"
        Me.BackstageViewTabItem2.Selected = False
        '
        'ofdExaminarArchivos
        '
        Me.ofdExaminarArchivos.FileName = "OpenFileDialog1"
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.Image = CType(resources.GetObject("btnEnviar.Image"), System.Drawing.Image)
        Me.btnEnviar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEnviar.Location = New System.Drawing.Point(448, 672)
        Me.btnEnviar.LookAndFeel.SkinName = "Seven"
        Me.btnEnviar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(64, 64)
        Me.btnEnviar.TabIndex = 12
        Me.btnEnviar.Text = "Reenviar"
        '
        'SaimtSplitContainerControl1
        '
        Me.SaimtSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaimtSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SaimtSplitContainerControl1.Name = "SaimtSplitContainerControl1"
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.btnBuscar)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.spaño)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel49)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.cmbopciones)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtLabel4)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.TxtBuscarPor)
        Me.SaimtSplitContainerControl1.Panel1.Controls.Add(Me.SaimtGroupBox1)
        Me.SaimtSplitContainerControl1.Panel1.Text = "Panel1"
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnImprimir)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.GBoxDatosDocumento)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEnviar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.GBoxDatosAdicionales)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnNuevo)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEditar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnCancelar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnEliminar)
        Me.SaimtSplitContainerControl1.Panel2.Controls.Add(Me.btnLimpiar)
        Me.SaimtSplitContainerControl1.Panel2.Text = "Panel2"
        Me.SaimtSplitContainerControl1.Size = New System.Drawing.Size(1139, 767)
        Me.SaimtSplitContainerControl1.SplitterPosition = 373
        Me.SaimtSplitContainerControl1.TabIndex = 13
        Me.SaimtSplitContainerControl1.Text = "SaimtSplitContainerControl1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(341, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(25, 21)
        Me.btnBuscar.TabIndex = 38
        '
        'spaño
        '
        Me.spaño.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spaño.Location = New System.Drawing.Point(92, 3)
        Me.spaño.MenuManager = Me.RibbonControl
        Me.spaño.Name = "spaño"
        Me.spaño.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spaño.Size = New System.Drawing.Size(77, 20)
        Me.spaño.TabIndex = 7
        '
        'SaimtLabel49
        '
        Me.SaimtLabel49.Location = New System.Drawing.Point(10, 6)
        Me.SaimtLabel49.Name = "SaimtLabel49"
        Me.SaimtLabel49.Size = New System.Drawing.Size(76, 13)
        Me.SaimtLabel49.TabIndex = 6
        Me.SaimtLabel49.Text = "Seleccionar Año"
        '
        'cmbopciones
        '
        Me.cmbopciones.Location = New System.Drawing.Point(8, 39)
        Me.cmbopciones.MenuManager = Me.RibbonControl
        Me.cmbopciones.Name = "cmbopciones"
        Me.cmbopciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbopciones.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Nombre")})
        Me.cmbopciones.Properties.NullText = ""
        Me.cmbopciones.Size = New System.Drawing.Size(360, 20)
        Me.cmbopciones.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnImprimir.Location = New System.Drawing.Point(518, 672)
        Me.btnImprimir.LookAndFeel.SkinName = "Seven"
        Me.btnImprimir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 64)
        Me.btnImprimir.TabIndex = 13
        '
        'frmDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonCancelar = Me.btnCancelar
        Me.ButtonEditar = Me.btnEditar
        Me.ButtonEliminar = Me.btnEliminar
        Me.ButtonGuardar = Me.btnGuardar
        Me.ButtonImprimir = Me.btnImprimir
        Me.ButtonLimpiar = Me.btnLimpiar
        Me.ButtonNuevo = Me.btnNuevo
        Me.ClientSize = New System.Drawing.Size(1139, 794)
        Me.Controls.Add(Me.SaimtSplitContainerControl1)
        Me.dgvListado = Me.dgvListadoDocumento
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmDocumento"
        Me.Text = "Registrar Documento"
        Me.txtBuscarSaimt = Me.TxtBuscarPor
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtSplitContainerControl1, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMovimientosDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GBoxDatosDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxDatosDocumento.ResumeLayout(False)
        Me.GBoxDatosDocumento.PerformLayout()
        CType(Me.txtDocAux.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoDocAux.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtProcedimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sCboTipoAccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDoc.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdocid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox6.ResumeLayout(False)
        Me.SaimtGroupBox6.PerformLayout()
        CType(Me.spañoReg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sCboAreas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNdocReg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sTxtSiglas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtasunto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sRdbOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReqActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sRbTupac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssFolios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDocFechaIng.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDocFechaIng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        CType(Me.dgvListadoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListadoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox4.ResumeLayout(False)
        Me.SaimtGroupBox4.PerformLayout()
        CType(Me.SaimtTextBox3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTextBoxMultiline2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BVCCInteresado.ResumeLayout(False)
        CType(Me.SaimtTabs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.btnInstitucionInt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDireccionPerInt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCboCargoInt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sCboAreaInt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInteresado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.dgvDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BVCCRequisitos.ResumeLayout(False)
        CType(Me.SaimtTabs2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.TxtProcedimientoVer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReqvsProc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReqvsProc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BVCCMovimientos.ResumeLayout(False)
        CType(Me.SaimtTabs3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs3.ResumeLayout(False)
        Me.BVCCObservacion.ResumeLayout(False)
        Me.BVCCObservacion.PerformLayout()
        CType(Me.TxtDocRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcomentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BVCCDocVinculados.ResumeLayout(False)
        CType(Me.dgvDocumentosVinculados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvDocumentosVinculados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GBoxDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxDatosAdicionales.ResumeLayout(False)
        Me.BackstageViewControl1.ResumeLayout(False)
        Me.BackstageViewClientControl2.ResumeLayout(False)
        CType(Me.SaimtSplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtSplitContainerControl1.ResumeLayout(False)
        CType(Me.spaño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbopciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents TxtBuscarPor As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents GBoxDatosDocumento As SaimtControles.SaimtGroupBox
    Friend WithEvents dtpDocFechaIng As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents lblTipoDoc As SaimtControles.SaimtLabel
    Friend WithEvents ssFolios As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel13 As SaimtControles.SaimtLabel
    Friend WithEvents TxtNdocReg As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtGroupBox4 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel15 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtButton2 As SaimtControles.SaimtButton
    Friend WithEvents btnCancelar As SaimtControles.SaimtButton
    Friend WithEvents btnEliminar As SaimtControles.SaimtButton
    Friend WithEvents btnLimpiar As SaimtControles.SaimtButton
    Friend WithEvents btnNuevo As SaimtControles.SaimtButton
    Friend WithEvents btnGuardar As SaimtControles.SaimtButton
    Friend WithEvents btnEditar As SaimtControles.SaimtButton
    Friend WithEvents chkReqActivos As SaimtControles.SaimtCheckBox
    Friend WithEvents sRdbOrigen As SaimtControles.SaimtRadioGroup
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents sRbTupac As SaimtControles.SaimtRadioGroup
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel17 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtTextBoxMultiline2 As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtComboBoxLookUpUpdate7 As SaimtControles.SaimtComboBoxLookUpUpdate
    Friend WithEvents SaimtLabel18 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtComboBoxLookUpUpdate8 As SaimtControles.SaimtComboBoxLookUpUpdate
    Friend WithEvents SaimtLabel16 As SaimtControles.SaimtLabel
    Friend WithEvents sTxtSiglas As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel22 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel21 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel20 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel19 As SaimtControles.SaimtLabel
    Friend WithEvents txtasunto As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents BVTabRequisitos As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents SaimtTextBox3 As SaimtControles.SaimtTextBox
    Friend WithEvents GBoxDatosAdicionales As SaimtControles.SaimtGroupBox
    Friend WithEvents BackstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BVTabInteresado As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator2 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BVTabMovimientos As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewClientControl3 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewTabItem3 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewClientControl2 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewTabItem2 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents SaimtGroupBox6 As SaimtControles.SaimtGroupBox
    Friend WithEvents sCboAreas As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents BackstageViewItemSeparator3 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BackstageViewItemSeparator4 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents btnAnexos As SaimtControles.SaimtButton
    Friend WithEvents BVTabObservaciones As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator6 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents BVTabDocVinculados As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents txtdocid As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel29 As SaimtControles.SaimtLabel
    Friend WithEvents btnProcedimiento As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel32 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaDoc As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel31 As SaimtControles.SaimtLabel
    Friend WithEvents sCboTipoAccion As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel33 As SaimtControles.SaimtLabel
    Friend WithEvents btnInstitucion As SaimtControles.SaimtButtonEdit
    Friend WithEvents TxtProcedimiento As SaimtControles.SaimtTextBox
    Friend WithEvents ofdExaminarArchivos As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BackstageViewTabItem9 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewTabItem10 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewTabItem11 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewTabItem12 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewTabItem13 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewTabItem14 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BVCCInteresado As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents SaimtTabs1 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxtDireccionPerInt As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel23 As SaimtControles.SaimtLabel
    Friend WithEvents SCboCargoInt As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents sCboAreaInt As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents SaimtLabel14 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel12 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel11 As SaimtControles.SaimtLabel
    Friend WithEvents btnInteresado As SaimtControles.SaimtButton
    Friend WithEvents TxtInteresado As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgvDatosAdicionales As SaimtControles.SaimtDataGrid
    Friend WithEvents gvDatosAdicionales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BVCCRequisitos As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents SaimtTabs2 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgvReqvsProc As SaimtControles.SaimtDataGrid
    Friend WithEvents gvReqvsProc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcTgId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SaimtLabel24 As SaimtControles.SaimtLabel
    Friend WithEvents BVCCMovimientos As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BVCCObservacion As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents TxtDocRef As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel30 As SaimtControles.SaimtLabel
    Friend WithEvents txtcomentario As SaimtControles.SaimtTextBoxMultiline
    Friend WithEvents SaimtLabel25 As SaimtControles.SaimtLabel
    Friend WithEvents BVCCDocVinculados As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Friend WithEvents BackstageViewClientControl9 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewClientControl10 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewClientControl11 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewClientControl12 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewClientControl13 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewClientControl14 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewClientControl15 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewTabItem15 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewTabItem16 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents SaimtTabs3 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cbTipoDocAux As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnEnviar As SaimtControles.SaimtButton
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dgvMovimientos As SaimtControles.SaimtDataGrid
    Friend WithEvents gvMovimientosDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gvMovimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcMovDiasTenencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovFechaRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTgEstadoMov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovFechaEnv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMovTieneArch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gccarPerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcperId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcpersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcperDni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gccarPerFechaIni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcperDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtProcedimientoVer As SaimtControles.SaimtTextBox
    Friend WithEvents gcPerNombreOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPerCargoOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPerNombreDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPerCargoDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents lblNroDoc As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel34 As SaimtControles.SaimtLabel
    Friend WithEvents txtDocAux As SaimtControles.SaimtTextBox
    Friend WithEvents btnInstitucionInt As SaimtControles.SaimtButtonEdit
    Friend WithEvents dgvDocumentosVinculados As SaimtControles.SaimtDataGrid
    Friend WithEvents lvDocumentosVinculados As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewColumn12 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn12 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn10 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents layoutViewField_LayoutViewColumn10 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn11 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn11 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn4 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn4 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn5 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn5 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn6 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn6 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoExEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents btnVisorDoc As SaimtControles.SaimtButton
    Friend WithEvents SaimtSplitContainerControl1 As SaimtControles.SaimtSplitContainerControl
    Friend WithEvents dgvListadoDocumento As SaimtControles.SaimtDataGrid
    Friend WithEvents gvListadoDocumento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spaño As SaimtControles.SaimtSpinner
    Friend WithEvents SaimtLabel49 As SaimtControles.SaimtLabel
    Friend WithEvents cmbopciones As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents spañoReg As SaimtControles.SaimtSpinner
    Friend WithEvents btnBuscar As SaimtControles.SaimtButton
    Friend WithEvents RepositoryItemMemoExEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents fbdExportar As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents LayoutViewColumn2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
End Class