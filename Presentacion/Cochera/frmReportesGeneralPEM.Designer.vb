﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesGeneralPEM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesGeneralPEM))
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.cboTipoAbonado = New SaimtControles.SaimtComboBox()
        Me.chkTipoVehiculo = New SaimtControles.SaimtCheckBox()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.cboTipoVehiculo = New SaimtControles.SaimtComboBoxLookUp()
        Me.chkConceptos = New SaimtControles.SaimtCheckBox()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.dtpFechaFin = New SaimtControles.SaimtDateTimePicker()
        Me.dtpFechaInicio = New SaimtControles.SaimtDateTimePicker()
        Me.cboEstados = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboConceptos = New SaimtControles.SaimtComboBoxLookUp()
        Me.btnBuscar = New SaimtControles.SaimtButton()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.dgvReportePEM = New SaimtControles.SaimtDataGrid()
        Me.gvReportePEM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcdiarioId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiarionroticket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiarioplaca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiariofecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiariohoraE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiariohoras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiariomonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiarioUsuarioId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiarioPerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDiarioUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiarioConId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiarioConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonPlaca1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonPlaca2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonPlaca3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonFechaIni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonFechaFin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonTipoDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAbonNroDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiariofechaSal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnExportarHoraFraccion = New SaimtControles.SaimtButton()
        Me.btnBuscarAbonoFechaV = New SaimtControles.SaimtButton()
        Me.dtpAbonFechaFin = New SaimtControles.SaimtDateTimePicker()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.tabReportes = New SaimtControles.SaimtTabs()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnExportarAbonos = New SaimtControles.SaimtButton()
        Me.dgvAbonadoDetPEM = New SaimtControles.SaimtDataGrid()
        Me.gvAbonadoDetPEM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaimtTabs2 = New SaimtControles.SaimtTabs()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnBuscarAbonoFechaI = New SaimtControles.SaimtButton()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.dtpAbonFechaInicio = New SaimtControles.SaimtDateTimePicker()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnFechaSalida = New SaimtControles.SaimtButton()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.dtpFechaSalida = New SaimtControles.SaimtDateTimePicker()
        Me.btnFechaIngreso = New SaimtControles.SaimtButton()
        Me.SaimtLabel7 = New SaimtControles.SaimtLabel()
        Me.dtpFechaIngreso = New SaimtControles.SaimtDateTimePicker()
        Me.sfdExportar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAbonado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTipoVehiculo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoVehiculo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkConceptos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConceptos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReportePEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReportePEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAbonFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAbonFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReportes.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.dgvAbonadoDetPEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAbonadoDetPEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTabs2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtTabs2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.dtpAbonFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAbonFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.dtpFechaSalida.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 708)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1020, 27)
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(263, 44)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(88, 13)
        Me.SaimtLabel8.TabIndex = 12
        Me.SaimtLabel8.Text = "Concepto Vehiculo"
        '
        'cboTipoAbonado
        '
        Me.cboTipoAbonado.Location = New System.Drawing.Point(100, 16)
        Me.cboTipoAbonado.MenuManager = Me.RibbonControl
        Me.cboTipoAbonado.Name = "cboTipoAbonado"
        Me.cboTipoAbonado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoAbonado.Properties.Items.AddRange(New Object() {"Abonados", "Hora Fracción", "Abonados (Control)"})
        Me.cboTipoAbonado.Size = New System.Drawing.Size(154, 20)
        Me.cboTipoAbonado.TabIndex = 1
        '
        'chkTipoVehiculo
        '
        Me.chkTipoVehiculo.Location = New System.Drawing.Point(96, 42)
        Me.chkTipoVehiculo.MenuManager = Me.RibbonControl
        Me.chkTipoVehiculo.Name = "chkTipoVehiculo"
        Me.chkTipoVehiculo.Properties.AutoWidth = True
        Me.chkTipoVehiculo.Properties.Caption = ""
        Me.chkTipoVehiculo.Size = New System.Drawing.Size(19, 19)
        Me.chkTipoVehiculo.TabIndex = 9
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(18, 45)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(62, 13)
        Me.SaimtLabel5.TabIndex = 7
        Me.SaimtLabel5.Text = "Tipo Vehiculo"
        '
        'cboTipoVehiculo
        '
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(122, 42)
        Me.cboTipoVehiculo.MenuManager = Me.RibbonControl
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoVehiculo.Properties.NullText = ""
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(132, 20)
        Me.cboTipoVehiculo.TabIndex = 11
        '
        'chkConceptos
        '
        Me.chkConceptos.Location = New System.Drawing.Point(370, 41)
        Me.chkConceptos.MenuManager = Me.RibbonControl
        Me.chkConceptos.Name = "chkConceptos"
        Me.chkConceptos.Properties.AutoWidth = True
        Me.chkConceptos.Properties.Caption = ""
        Me.chkConceptos.Size = New System.Drawing.Size(19, 19)
        Me.chkConceptos.TabIndex = 8
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Location = New System.Drawing.Point(14, 16)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(66, 13)
        Me.SaimtLabel3.TabIndex = 0
        Me.SaimtLabel3.Text = "Tipo Abonado"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(523, 19)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(46, 13)
        Me.SaimtLabel2.TabIndex = 4
        Me.SaimtLabel2.Text = "Fecha Fin"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(294, 19)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(57, 13)
        Me.SaimtLabel1.TabIndex = 2
        Me.SaimtLabel1.Text = "Fecha Inicio"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.EditValue = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(588, 16)
        Me.dtpFechaFin.MenuManager = Me.RibbonControl
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaFin.Size = New System.Drawing.Size(128, 20)
        Me.dtpFechaFin.TabIndex = 5
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.EditValue = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(370, 16)
        Me.dtpFechaInicio.MenuManager = Me.RibbonControl
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaInicio.Size = New System.Drawing.Size(129, 20)
        Me.dtpFechaInicio.TabIndex = 3
        '
        'cboEstados
        '
        Me.cboEstados.Location = New System.Drawing.Point(100, 67)
        Me.cboEstados.MenuManager = Me.RibbonControl
        Me.cboEstados.Name = "cboEstados"
        Me.cboEstados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstados.Properties.NullText = ""
        Me.cboEstados.Size = New System.Drawing.Size(156, 20)
        Me.cboEstados.TabIndex = 14
        '
        'cboConceptos
        '
        Me.cboConceptos.Location = New System.Drawing.Point(394, 41)
        Me.cboConceptos.MenuManager = Me.RibbonControl
        Me.cboConceptos.Name = "cboConceptos"
        Me.cboConceptos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConceptos.Properties.NullText = ""
        Me.cboConceptos.Size = New System.Drawing.Size(322, 20)
        Me.cboConceptos.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(720, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscar.TabIndex = 6
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(47, 70)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(33, 13)
        Me.SaimtLabel9.TabIndex = 13
        Me.SaimtLabel9.Text = "Estado"
        '
        'dgvReportePEM
        '
        Me.dgvReportePEM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReportePEM.Location = New System.Drawing.Point(0, 0)
        Me.dgvReportePEM.MainView = Me.gvReportePEM
        Me.dgvReportePEM.MenuManager = Me.RibbonControl
        Me.dgvReportePEM.Name = "dgvReportePEM"
        Me.dgvReportePEM.Size = New System.Drawing.Size(1014, 550)
        Me.dgvReportePEM.TabIndex = 0
        Me.dgvReportePEM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvReportePEM})
        '
        'gvReportePEM
        '
        Me.gvReportePEM.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvReportePEM.Appearance.FooterPanel.Options.UseFont = True
        Me.gvReportePEM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcdiarioId, Me.gcdiarionroticket, Me.gcdiarioplaca, Me.gcdiariofecha, Me.gcdiariohoraE, Me.gcdiariohoras, Me.gcdiariomonto, Me.gcdiarioUsuarioId, Me.gcdiarioPerId, Me.gcDiarioUsuario, Me.gcdiarioConId, Me.gcdiarioConcepto, Me.gcAbonId, Me.gcAbonPlaca1, Me.gcAbonPlaca2, Me.gcAbonPlaca3, Me.gcAbonFechaIni, Me.gcAbonFechaFin, Me.gcAbonImporte, Me.gcAbonConcepto, Me.gcAbonPersona, Me.gcAbonTipoDoc, Me.gcAbonNroDoc, Me.gcdiariofechaSal})
        Me.gvReportePEM.GridControl = Me.dgvReportePEM
        Me.gvReportePEM.Name = "gvReportePEM"
        Me.gvReportePEM.OptionsBehavior.ReadOnly = True
        Me.gvReportePEM.OptionsFind.AlwaysVisible = True
        Me.gvReportePEM.OptionsPrint.AutoWidth = False
        Me.gvReportePEM.OptionsView.ColumnAutoWidth = False
        Me.gvReportePEM.OptionsView.ShowFooter = True
        Me.gvReportePEM.OptionsView.ShowGroupPanel = False
        '
        'gcdiarioId
        '
        Me.gcdiarioId.Caption = "diarioId"
        Me.gcdiarioId.FieldName = "diarioId"
        Me.gcdiarioId.Name = "gcdiarioId"
        '
        'gcdiarionroticket
        '
        Me.gcdiarionroticket.Caption = "N° Ticket"
        Me.gcdiarionroticket.FieldName = "diarioCod"
        Me.gcdiarionroticket.Name = "gcdiarionroticket"
        Me.gcdiarionroticket.Visible = True
        Me.gcdiarionroticket.VisibleIndex = 0
        '
        'gcdiarioplaca
        '
        Me.gcdiarioplaca.Caption = "Placa"
        Me.gcdiarioplaca.FieldName = "diaNPlaca"
        Me.gcdiarioplaca.Name = "gcdiarioplaca"
        Me.gcdiarioplaca.Visible = True
        Me.gcdiarioplaca.VisibleIndex = 1
        '
        'gcdiariofecha
        '
        Me.gcdiariofecha.Caption = "Fecha Entrada"
        Me.gcdiariofecha.FieldName = "diaFechaIng"
        Me.gcdiariofecha.Name = "gcdiariofecha"
        Me.gcdiariofecha.Visible = True
        Me.gcdiariofecha.VisibleIndex = 2
        '
        'gcdiariohoraE
        '
        Me.gcdiariohoraE.Caption = "Hora Entrada"
        Me.gcdiariohoraE.FieldName = "diaHoraIng"
        Me.gcdiariohoraE.Name = "gcdiariohoraE"
        Me.gcdiariohoraE.Visible = True
        Me.gcdiariohoraE.VisibleIndex = 3
        '
        'gcdiariohoras
        '
        Me.gcdiariohoras.Caption = "Hora Salida"
        Me.gcdiariohoras.FieldName = "diaHoraSal"
        Me.gcdiariohoras.Name = "gcdiariohoras"
        Me.gcdiariohoras.Visible = True
        Me.gcdiariohoras.VisibleIndex = 5
        '
        'gcdiariomonto
        '
        Me.gcdiariomonto.Caption = "Monto (S/.)"
        Me.gcdiariomonto.DisplayFormat.FormatString = "n2"
        Me.gcdiariomonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcdiariomonto.FieldName = "diaPrecio"
        Me.gcdiariomonto.Name = "gcdiariomonto"
        Me.gcdiariomonto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "diaPrecio", "Total : {0:###,##0.00}")})
        Me.gcdiariomonto.Visible = True
        Me.gcdiariomonto.VisibleIndex = 7
        '
        'gcdiarioUsuarioId
        '
        Me.gcdiarioUsuarioId.Caption = "Usuario ID"
        Me.gcdiarioUsuarioId.FieldName = "usuario"
        Me.gcdiarioUsuarioId.Name = "gcdiarioUsuarioId"
        Me.gcdiarioUsuarioId.Visible = True
        Me.gcdiarioUsuarioId.VisibleIndex = 8
        '
        'gcdiarioPerId
        '
        Me.gcdiarioPerId.Caption = "perId"
        Me.gcdiarioPerId.FieldName = "perId"
        Me.gcdiarioPerId.Name = "gcdiarioPerId"
        '
        'gcDiarioUsuario
        '
        Me.gcDiarioUsuario.Caption = "Usuario"
        Me.gcDiarioUsuario.FieldName = "persona"
        Me.gcDiarioUsuario.Name = "gcDiarioUsuario"
        '
        'gcdiarioConId
        '
        Me.gcdiarioConId.Caption = "conId"
        Me.gcdiarioConId.FieldName = "conId"
        Me.gcdiarioConId.Name = "gcdiarioConId"
        '
        'gcdiarioConcepto
        '
        Me.gcdiarioConcepto.Caption = "Servicio"
        Me.gcdiarioConcepto.FieldName = "conNombre"
        Me.gcdiarioConcepto.Name = "gcdiarioConcepto"
        Me.gcdiarioConcepto.Visible = True
        Me.gcdiarioConcepto.VisibleIndex = 6
        '
        'gcAbonId
        '
        Me.gcAbonId.Caption = "AbonId"
        Me.gcAbonId.FieldName = "AbonId"
        Me.gcAbonId.Name = "gcAbonId"
        Me.gcAbonId.Visible = True
        Me.gcAbonId.VisibleIndex = 9
        '
        'gcAbonPlaca1
        '
        Me.gcAbonPlaca1.Caption = "Placa 1"
        Me.gcAbonPlaca1.FieldName = "AbonNPlaca1"
        Me.gcAbonPlaca1.Name = "gcAbonPlaca1"
        Me.gcAbonPlaca1.Visible = True
        Me.gcAbonPlaca1.VisibleIndex = 10
        '
        'gcAbonPlaca2
        '
        Me.gcAbonPlaca2.Caption = "Placa 2"
        Me.gcAbonPlaca2.FieldName = "AbonNPlaca2"
        Me.gcAbonPlaca2.Name = "gcAbonPlaca2"
        Me.gcAbonPlaca2.Visible = True
        Me.gcAbonPlaca2.VisibleIndex = 11
        '
        'gcAbonPlaca3
        '
        Me.gcAbonPlaca3.Caption = "Placa 3"
        Me.gcAbonPlaca3.FieldName = "AbonNPlaca3"
        Me.gcAbonPlaca3.Name = "gcAbonPlaca3"
        Me.gcAbonPlaca3.Visible = True
        Me.gcAbonPlaca3.VisibleIndex = 12
        '
        'gcAbonFechaIni
        '
        Me.gcAbonFechaIni.Caption = "Fecha Inicio"
        Me.gcAbonFechaIni.FieldName = "AbonFechaIni"
        Me.gcAbonFechaIni.Name = "gcAbonFechaIni"
        Me.gcAbonFechaIni.Visible = True
        Me.gcAbonFechaIni.VisibleIndex = 14
        '
        'gcAbonFechaFin
        '
        Me.gcAbonFechaFin.Caption = "Fecha Fin"
        Me.gcAbonFechaFin.FieldName = "AbonFechaFin"
        Me.gcAbonFechaFin.Name = "gcAbonFechaFin"
        Me.gcAbonFechaFin.Visible = True
        Me.gcAbonFechaFin.VisibleIndex = 15
        '
        'gcAbonImporte
        '
        Me.gcAbonImporte.Caption = "Importe"
        Me.gcAbonImporte.DisplayFormat.FormatString = "n2"
        Me.gcAbonImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcAbonImporte.FieldName = "AbonImporte"
        Me.gcAbonImporte.Name = "gcAbonImporte"
        Me.gcAbonImporte.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AbonImporte", "Total : {0:###,##0.00}")})
        Me.gcAbonImporte.Visible = True
        Me.gcAbonImporte.VisibleIndex = 16
        '
        'gcAbonConcepto
        '
        Me.gcAbonConcepto.Caption = "Servicio"
        Me.gcAbonConcepto.FieldName = "Concepto"
        Me.gcAbonConcepto.Name = "gcAbonConcepto"
        Me.gcAbonConcepto.Visible = True
        Me.gcAbonConcepto.VisibleIndex = 13
        '
        'gcAbonPersona
        '
        Me.gcAbonPersona.Caption = "Persona"
        Me.gcAbonPersona.FieldName = "Persona"
        Me.gcAbonPersona.Name = "gcAbonPersona"
        Me.gcAbonPersona.Visible = True
        Me.gcAbonPersona.VisibleIndex = 17
        '
        'gcAbonTipoDoc
        '
        Me.gcAbonTipoDoc.Caption = "TipoDocumento"
        Me.gcAbonTipoDoc.FieldName = "TipoDocumento"
        Me.gcAbonTipoDoc.Name = "gcAbonTipoDoc"
        Me.gcAbonTipoDoc.Visible = True
        Me.gcAbonTipoDoc.VisibleIndex = 18
        '
        'gcAbonNroDoc
        '
        Me.gcAbonNroDoc.Caption = "Nro Documento"
        Me.gcAbonNroDoc.FieldName = "NroDocumento"
        Me.gcAbonNroDoc.Name = "gcAbonNroDoc"
        Me.gcAbonNroDoc.Visible = True
        Me.gcAbonNroDoc.VisibleIndex = 19
        '
        'gcdiariofechaSal
        '
        Me.gcdiariofechaSal.Caption = "Fecha Salida"
        Me.gcdiariofechaSal.FieldName = "diaFechaSal"
        Me.gcdiariofechaSal.Name = "gcdiariofechaSal"
        Me.gcdiariofechaSal.Visible = True
        Me.gcdiariofechaSal.VisibleIndex = 4
        '
        'btnExportarHoraFraccion
        '
        Me.btnExportarHoraFraccion.Image = CType(resources.GetObject("btnExportarHoraFraccion.Image"), System.Drawing.Image)
        Me.btnExportarHoraFraccion.Location = New System.Drawing.Point(904, 12)
        Me.btnExportarHoraFraccion.Name = "btnExportarHoraFraccion"
        Me.btnExportarHoraFraccion.Size = New System.Drawing.Size(109, 23)
        Me.btnExportarHoraFraccion.TabIndex = 1
        Me.btnExportarHoraFraccion.Text = "Exportar Grilla"
        '
        'btnBuscarAbonoFechaV
        '
        Me.btnBuscarAbonoFechaV.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscarAbonoFechaV.Location = New System.Drawing.Point(162, 41)
        Me.btnBuscarAbonoFechaV.Name = "btnBuscarAbonoFechaV"
        Me.btnBuscarAbonoFechaV.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscarAbonoFechaV.TabIndex = 3
        '
        'dtpAbonFechaFin
        '
        Me.dtpAbonFechaFin.EditValue = Nothing
        Me.dtpAbonFechaFin.Location = New System.Drawing.Point(16, 42)
        Me.dtpAbonFechaFin.MenuManager = Me.RibbonControl
        Me.dtpAbonFechaFin.Name = "dtpAbonFechaFin"
        Me.dtpAbonFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpAbonFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpAbonFechaFin.Size = New System.Drawing.Size(140, 20)
        Me.dtpAbonFechaFin.TabIndex = 2
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(16, 25)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(173, 13)
        Me.SaimtLabel4.TabIndex = 0
        Me.SaimtLabel4.Text = "Abonados que venceran en la fecha"
        '
        'tabReportes
        '
        Me.tabReportes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabReportes.Location = New System.Drawing.Point(0, 130)
        Me.tabReportes.Name = "tabReportes"
        Me.tabReportes.SelectedTabPage = Me.XtraTabPage1
        Me.tabReportes.Size = New System.Drawing.Size(1020, 578)
        Me.tabReportes.TabIndex = 1
        Me.tabReportes.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnExportarHoraFraccion)
        Me.XtraTabPage1.Controls.Add(Me.dgvReportePEM)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1014, 550)
        Me.XtraTabPage1.Text = "Lista de movimientos de Hora Fracción"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.btnExportarAbonos)
        Me.XtraTabPage2.Controls.Add(Me.dgvAbonadoDetPEM)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1014, 550)
        Me.XtraTabPage2.Text = "Lista de abonados"
        '
        'btnExportarAbonos
        '
        Me.btnExportarAbonos.Image = CType(resources.GetObject("btnExportarAbonos.Image"), System.Drawing.Image)
        Me.btnExportarAbonos.Location = New System.Drawing.Point(902, 12)
        Me.btnExportarAbonos.Name = "btnExportarAbonos"
        Me.btnExportarAbonos.Size = New System.Drawing.Size(109, 23)
        Me.btnExportarAbonos.TabIndex = 1
        Me.btnExportarAbonos.Text = "Exportar Grilla"
        '
        'dgvAbonadoDetPEM
        '
        Me.dgvAbonadoDetPEM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAbonadoDetPEM.Location = New System.Drawing.Point(0, 0)
        Me.dgvAbonadoDetPEM.MainView = Me.gvAbonadoDetPEM
        Me.dgvAbonadoDetPEM.MenuManager = Me.RibbonControl
        Me.dgvAbonadoDetPEM.Name = "dgvAbonadoDetPEM"
        Me.dgvAbonadoDetPEM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.dgvAbonadoDetPEM.Size = New System.Drawing.Size(1014, 552)
        Me.dgvAbonadoDetPEM.TabIndex = 0
        Me.dgvAbonadoDetPEM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAbonadoDetPEM})
        '
        'gvAbonadoDetPEM
        '
        Me.gvAbonadoDetPEM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.gvAbonadoDetPEM.GridControl = Me.dgvAbonadoDetPEM
        Me.gvAbonadoDetPEM.Name = "gvAbonadoDetPEM"
        Me.gvAbonadoDetPEM.OptionsFind.AlwaysVisible = True
        Me.gvAbonadoDetPEM.OptionsPrint.AutoWidth = False
        Me.gvAbonadoDetPEM.OptionsView.ColumnAutoWidth = False
        Me.gvAbonadoDetPEM.OptionsView.ShowFooter = True
        Me.gvAbonadoDetPEM.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Abono"
        Me.GridColumn1.FieldName = "AbonId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nro. Cuota"
        Me.GridColumn2.FieldName = "AbonDetNroCuota"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha Inicio"
        Me.GridColumn3.FieldName = "AbonDetFechaIni"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha Termino"
        Me.GridColumn4.FieldName = "AbonDetFechaFin"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha Pago"
        Me.GridColumn5.FieldName = "AbonDetFecPago"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Monto a Pagar (S/.)"
        Me.GridColumn6.DisplayFormat.FormatString = "n2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "AbonDetImporte"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Estado"
        Me.GridColumn7.FieldName = "Estado"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Esta Pagado?"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn8.FieldName = "AbonDetPagado"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Persona"
        Me.GridColumn9.FieldName = "Persona"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Tipo Doc."
        Me.GridColumn10.FieldName = "tgDocumento"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Nro. Doc"
        Me.GridColumn11.FieldName = "perNDoc"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Cod. Estado"
        Me.GridColumn12.FieldName = "TgEstadoId"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        '
        'SaimtTabs2
        '
        Me.SaimtTabs2.Location = New System.Drawing.Point(8, 1)
        Me.SaimtTabs2.LookAndFeel.SkinName = "Blue"
        Me.SaimtTabs2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtTabs2.Name = "SaimtTabs2"
        Me.SaimtTabs2.SelectedTabPage = Me.XtraTabPage3
        Me.SaimtTabs2.Size = New System.Drawing.Size(1013, 129)
        Me.SaimtTabs2.TabIndex = 0
        Me.SaimtTabs2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.cboTipoAbonado)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel3)
        Me.XtraTabPage3.Controls.Add(Me.chkTipoVehiculo)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel8)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel5)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel9)
        Me.XtraTabPage3.Controls.Add(Me.cboTipoVehiculo)
        Me.XtraTabPage3.Controls.Add(Me.btnBuscar)
        Me.XtraTabPage3.Controls.Add(Me.chkConceptos)
        Me.XtraTabPage3.Controls.Add(Me.cboConceptos)
        Me.XtraTabPage3.Controls.Add(Me.cboEstados)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel2)
        Me.XtraTabPage3.Controls.Add(Me.dtpFechaInicio)
        Me.XtraTabPage3.Controls.Add(Me.SaimtLabel1)
        Me.XtraTabPage3.Controls.Add(Me.dtpFechaFin)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1008, 103)
        Me.XtraTabPage3.Text = "Datos para diversas consultas"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.btnBuscarAbonoFechaI)
        Me.XtraTabPage4.Controls.Add(Me.SaimtLabel6)
        Me.XtraTabPage4.Controls.Add(Me.dtpAbonFechaInicio)
        Me.XtraTabPage4.Controls.Add(Me.btnBuscarAbonoFechaV)
        Me.XtraTabPage4.Controls.Add(Me.SaimtLabel4)
        Me.XtraTabPage4.Controls.Add(Me.dtpAbonFechaFin)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1008, 103)
        Me.XtraTabPage4.Text = "Reportes para Abonados"
        '
        'btnBuscarAbonoFechaI
        '
        Me.btnBuscarAbonoFechaI.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscarAbonoFechaI.Location = New System.Drawing.Point(439, 41)
        Me.btnBuscarAbonoFechaI.Name = "btnBuscarAbonoFechaI"
        Me.btnBuscarAbonoFechaI.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscarAbonoFechaI.TabIndex = 5
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(252, 25)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(214, 13)
        Me.SaimtLabel6.TabIndex = 1
        Me.SaimtLabel6.Text = "Abonados que iniciaron su abono en la fecha"
        '
        'dtpAbonFechaInicio
        '
        Me.dtpAbonFechaInicio.EditValue = Nothing
        Me.dtpAbonFechaInicio.Location = New System.Drawing.Point(252, 42)
        Me.dtpAbonFechaInicio.MenuManager = Me.RibbonControl
        Me.dtpAbonFechaInicio.Name = "dtpAbonFechaInicio"
        Me.dtpAbonFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpAbonFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpAbonFechaInicio.Size = New System.Drawing.Size(181, 20)
        Me.dtpAbonFechaInicio.TabIndex = 4
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.btnFechaSalida)
        Me.XtraTabPage5.Controls.Add(Me.SaimtLabel10)
        Me.XtraTabPage5.Controls.Add(Me.dtpFechaSalida)
        Me.XtraTabPage5.Controls.Add(Me.btnFechaIngreso)
        Me.XtraTabPage5.Controls.Add(Me.SaimtLabel7)
        Me.XtraTabPage5.Controls.Add(Me.dtpFechaIngreso)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1008, 103)
        Me.XtraTabPage5.Text = "Reportes para Hora Fracción"
        '
        'btnFechaSalida
        '
        Me.btnFechaSalida.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnFechaSalida.Location = New System.Drawing.Point(390, 46)
        Me.btnFechaSalida.Name = "btnFechaSalida"
        Me.btnFechaSalida.Size = New System.Drawing.Size(27, 23)
        Me.btnFechaSalida.TabIndex = 5
        '
        'SaimtLabel10
        '
        Me.SaimtLabel10.Location = New System.Drawing.Point(244, 30)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(161, 13)
        Me.SaimtLabel10.TabIndex = 1
        Me.SaimtLabel10.Text = "Vehiculos que salieron en la fecha"
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.EditValue = Nothing
        Me.dtpFechaSalida.Location = New System.Drawing.Point(244, 47)
        Me.dtpFechaSalida.MenuManager = Me.RibbonControl
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaSalida.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaSalida.Size = New System.Drawing.Size(140, 20)
        Me.dtpFechaSalida.TabIndex = 4
        '
        'btnFechaIngreso
        '
        Me.btnFechaIngreso.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnFechaIngreso.Location = New System.Drawing.Point(168, 46)
        Me.btnFechaIngreso.Name = "btnFechaIngreso"
        Me.btnFechaIngreso.Size = New System.Drawing.Size(27, 23)
        Me.btnFechaIngreso.TabIndex = 3
        '
        'SaimtLabel7
        '
        Me.SaimtLabel7.Location = New System.Drawing.Point(22, 30)
        Me.SaimtLabel7.Name = "SaimtLabel7"
        Me.SaimtLabel7.Size = New System.Drawing.Size(175, 13)
        Me.SaimtLabel7.TabIndex = 0
        Me.SaimtLabel7.Text = "Vehiculos que ingresaron en la fecha"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.EditValue = Nothing
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(22, 47)
        Me.dtpFechaIngreso.MenuManager = Me.RibbonControl
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(140, 20)
        Me.dtpFechaIngreso.TabIndex = 2
        '
        'frmReportesGeneralPEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 735)
        Me.Controls.Add(Me.SaimtTabs2)
        Me.Controls.Add(Me.tabReportes)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmReportesGeneralPEM"
        Me.Tag = "btiReporteGeneralPEM"
        Me.Text = "Reporte para gestión de PEM"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.tabReportes, 0)
        Me.Controls.SetChildIndex(Me.SaimtTabs2, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAbonado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTipoVehiculo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoVehiculo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkConceptos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConceptos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReportePEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReportePEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAbonFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAbonFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReportes.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.dgvAbonadoDetPEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAbonadoDetPEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTabs2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtTabs2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.dtpAbonFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAbonFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage5.PerformLayout()
        CType(Me.dtpFechaSalida.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaIngreso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents dgvReportePEM As SaimtControles.SaimtDataGrid
    Friend WithEvents gvReportePEM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExportarHoraFraccion As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents gcdiarionroticket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdiarioplaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdiariofecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdiariohoraE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdiariohoras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdiariomonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBuscar As SaimtControles.SaimtButton
    Friend WithEvents cboConceptos As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboEstados As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents gcdiarioId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdiarioUsuarioId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdiarioPerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDiarioUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaFin As SaimtControles.SaimtDateTimePicker
    Friend WithEvents dtpFechaInicio As SaimtControles.SaimtDateTimePicker
    Friend WithEvents chkConceptos As SaimtControles.SaimtCheckBox
    Friend WithEvents chkTipoVehiculo As SaimtControles.SaimtCheckBox
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents cboTipoVehiculo As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents gcdiarioConId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdiarioConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTipoAbonado As SaimtControles.SaimtComboBox
    Friend WithEvents gcAbonId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbonPlaca1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbonPlaca2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbonPlaca3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbonFechaIni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbonFechaFin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbonImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbonPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbonTipoDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbonNroDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbonConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBuscarAbonoFechaV As SaimtControles.SaimtButton
    Friend WithEvents dtpAbonFechaFin As SaimtControles.SaimtDateTimePicker
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents tabReportes As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgvAbonadoDetPEM As SaimtControles.SaimtDataGrid
    Friend WithEvents gvAbonadoDetPEM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExportarAbonos As SaimtControles.SaimtButton
    Friend WithEvents SaimtTabs2 As SaimtControles.SaimtTabs
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnBuscarAbonoFechaI As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents dtpAbonFechaInicio As SaimtControles.SaimtDateTimePicker
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcdiariofechaSal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnFechaSalida As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaSalida As SaimtControles.SaimtDateTimePicker
    Friend WithEvents btnFechaIngreso As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel7 As SaimtControles.SaimtLabel
    Friend WithEvents dtpFechaIngreso As SaimtControles.SaimtDateTimePicker
    Friend WithEvents sfdExportar As System.Windows.Forms.SaveFileDialog
End Class