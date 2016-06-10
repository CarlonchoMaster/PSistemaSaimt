<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalidaCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalidaCaja))
        Me.SaimtGroupBox1 = New SaimtControles.SaimtGroupBox()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.btnOKTiket = New SaimtControles.SaimtButton()
        Me.SaimtLabel3 = New SaimtControles.SaimtLabel()
        Me.txtHora = New SaimtControles.SaimtTextBox()
        Me.txtfecha = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel10 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        Me.btnOKPlaca = New SaimtControles.SaimtButton()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox3 = New SaimtControles.SaimtGroupBox()
        Me.btnImprimir = New SaimtControles.SaimtButton()
        Me.cboEstados = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboConceptosBusquedas = New SaimtControles.SaimtComboBoxLookUp()
        Me.dgvDiarioPEM = New SaimtControles.SaimtDataGrid()
        Me.gvDiarioPEM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnBuscar = New SaimtControles.SaimtButton()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.SaimtLabel9 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel8 = New SaimtControles.SaimtLabel()
        Me.SaimtGroupBox4 = New SaimtControles.SaimtGroupBox()
        Me.SaimtLabel6 = New SaimtControles.SaimtLabel()
        Me.SaimtLabel5 = New SaimtControles.SaimtLabel()
        Me.txtmonto = New SaimtControles.SaimtTextBox()
        Me.txtTiempo = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel4 = New SaimtControles.SaimtLabel()
        Me.txtconcepto = New SaimtControles.SaimtTextBox()
        Me.SaimtTextBox5 = New SaimtControles.SaimtTextBox()
        Me.SaimtTextBox1 = New SaimtControles.SaimtTextBox()
        Me.SaimtTextBox3 = New SaimtControles.SaimtTextBox()
        Me.tmhora = New System.Windows.Forms.Timer(Me.components)
        Me.sfdExportar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox1.SuspendLayout()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox3.SuspendLayout()
        CType(Me.cboEstados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConceptosBusquedas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDiarioPEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDiarioPEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox4.SuspendLayout()
        CType(Me.txtmonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTiempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtconcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTextBox5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTextBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtTextBox3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 708)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(1026, 27)
        '
        'SaimtGroupBox1
        '
        Me.SaimtGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtGroupBox1.Appearance.Options.UseFont = True
        Me.SaimtGroupBox1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtGroupBox1.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseFont = True
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseForeColor = True
        Me.SaimtGroupBox1.AppearanceCaption.Options.UseTextOptions = True
        Me.SaimtGroupBox1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SaimtGroupBox1.Controls.Add(Me.txtplaca)
        Me.SaimtGroupBox1.Controls.Add(Me.txtTicket)
        Me.SaimtGroupBox1.Controls.Add(Me.btnOKTiket)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel3)
        Me.SaimtGroupBox1.Controls.Add(Me.txtHora)
        Me.SaimtGroupBox1.Controls.Add(Me.txtfecha)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel10)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel2)
        Me.SaimtGroupBox1.Controls.Add(Me.btnOKPlaca)
        Me.SaimtGroupBox1.Controls.Add(Me.SaimtLabel1)
        Me.SaimtGroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.SaimtGroupBox1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox1.Name = "SaimtGroupBox1"
        Me.SaimtGroupBox1.Size = New System.Drawing.Size(1013, 287)
        Me.SaimtGroupBox1.TabIndex = 3
        Me.SaimtGroupBox1.Text = "Salida de Vehiculos"
        '
        'txtplaca
        '
        Me.txtplaca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtplaca.Font = New System.Drawing.Font("Tahoma", 60.0!)
        Me.txtplaca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtplaca.Location = New System.Drawing.Point(310, 173)
        Me.txtplaca.MaxLength = 8
        Me.txtplaca.Multiline = True
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(574, 101)
        Me.txtplaca.TabIndex = 14
        '
        'txtTicket
        '
        Me.txtTicket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTicket.Font = New System.Drawing.Font("Tahoma", 60.0!)
        Me.txtTicket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtTicket.Location = New System.Drawing.Point(310, 66)
        Me.txtTicket.MaxLength = 9
        Me.txtTicket.Multiline = True
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(574, 101)
        Me.txtTicket.TabIndex = 13
        '
        'btnOKTiket
        '
        Me.btnOKTiket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOKTiket.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOKTiket.Appearance.Options.UseFont = True
        Me.btnOKTiket.Location = New System.Drawing.Point(890, 66)
        Me.btnOKTiket.Name = "btnOKTiket"
        Me.btnOKTiket.Size = New System.Drawing.Size(110, 98)
        Me.btnOKTiket.TabIndex = 11
        Me.btnOKTiket.Text = "OK"
        '
        'SaimtLabel3
        '
        Me.SaimtLabel3.Appearance.Font = New System.Drawing.Font("Tahoma", 54.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel3.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtLabel3.Location = New System.Drawing.Point(8, 72)
        Me.SaimtLabel3.Name = "SaimtLabel3"
        Me.SaimtLabel3.Size = New System.Drawing.Size(294, 87)
        Me.SaimtLabel3.TabIndex = 9
        Me.SaimtLabel3.Text = "N° Ticket"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(639, 28)
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
        Me.txtfecha.Location = New System.Drawing.Point(349, 27)
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
        Me.SaimtLabel10.Location = New System.Drawing.Point(599, 30)
        Me.SaimtLabel10.Name = "SaimtLabel10"
        Me.SaimtLabel10.Size = New System.Drawing.Size(34, 19)
        Me.SaimtLabel10.TabIndex = 6
        Me.SaimtLabel10.Text = "Hora"
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel2.Location = New System.Drawing.Point(303, 30)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(40, 19)
        Me.SaimtLabel2.TabIndex = 5
        Me.SaimtLabel2.Text = "Fecha"
        '
        'btnOKPlaca
        '
        Me.btnOKPlaca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOKPlaca.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOKPlaca.Appearance.Options.UseFont = True
        Me.btnOKPlaca.Location = New System.Drawing.Point(890, 176)
        Me.btnOKPlaca.Name = "btnOKPlaca"
        Me.btnOKPlaca.Size = New System.Drawing.Size(110, 98)
        Me.btnOKPlaca.TabIndex = 2
        Me.btnOKPlaca.Text = "OK"
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtLabel1.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.SaimtLabel1.Location = New System.Drawing.Point(10, 177)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(299, 97)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "N° Placa"
        '
        'SaimtGroupBox3
        '
        Me.SaimtGroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox3.Controls.Add(Me.btnImprimir)
        Me.SaimtGroupBox3.Controls.Add(Me.cboEstados)
        Me.SaimtGroupBox3.Controls.Add(Me.cboConceptosBusquedas)
        Me.SaimtGroupBox3.Controls.Add(Me.dgvDiarioPEM)
        Me.SaimtGroupBox3.Controls.Add(Me.btnBuscar)
        Me.SaimtGroupBox3.Controls.Add(Me.btnexportar)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel9)
        Me.SaimtGroupBox3.Controls.Add(Me.SaimtLabel8)
        Me.SaimtGroupBox3.Location = New System.Drawing.Point(7, 373)
        Me.SaimtGroupBox3.Name = "SaimtGroupBox3"
        Me.SaimtGroupBox3.Size = New System.Drawing.Size(1013, 331)
        Me.SaimtGroupBox3.TabIndex = 9
        Me.SaimtGroupBox3.Text = "Consulta de Datos"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(921, 13)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(86, 35)
        Me.btnImprimir.TabIndex = 16
        Me.btnImprimir.Text = "Imprimir Duplicado"
        '
        'cboEstados
        '
        Me.cboEstados.Location = New System.Drawing.Point(616, 25)
        Me.cboEstados.MenuManager = Me.RibbonControl
        Me.cboEstados.Name = "cboEstados"
        Me.cboEstados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstados.Properties.NullText = ""
        Me.cboEstados.Size = New System.Drawing.Size(156, 20)
        Me.cboEstados.TabIndex = 15
        '
        'cboConceptosBusquedas
        '
        Me.cboConceptosBusquedas.Location = New System.Drawing.Point(116, 25)
        Me.cboConceptosBusquedas.MenuManager = Me.RibbonControl
        Me.cboConceptosBusquedas.Name = "cboConceptosBusquedas"
        Me.cboConceptosBusquedas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConceptosBusquedas.Properties.NullText = ""
        Me.cboConceptosBusquedas.Size = New System.Drawing.Size(405, 20)
        Me.cboConceptosBusquedas.TabIndex = 14
        '
        'dgvDiarioPEM
        '
        Me.dgvDiarioPEM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDiarioPEM.Location = New System.Drawing.Point(2, 52)
        Me.dgvDiarioPEM.MainView = Me.gvDiarioPEM
        Me.dgvDiarioPEM.MenuManager = Me.RibbonControl
        Me.dgvDiarioPEM.Name = "dgvDiarioPEM"
        Me.dgvDiarioPEM.Size = New System.Drawing.Size(1009, 277)
        Me.dgvDiarioPEM.TabIndex = 12
        Me.dgvDiarioPEM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDiarioPEM})
        '
        'gvDiarioPEM
        '
        Me.gvDiarioPEM.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvDiarioPEM.Appearance.FooterPanel.Options.UseFont = True
        Me.gvDiarioPEM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn13, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn14, Me.GridColumn15})
        Me.gvDiarioPEM.GridControl = Me.dgvDiarioPEM
        Me.gvDiarioPEM.Name = "gvDiarioPEM"
        Me.gvDiarioPEM.OptionsFind.AlwaysVisible = True
        Me.gvDiarioPEM.OptionsPrint.AutoWidth = False
        Me.gvDiarioPEM.OptionsView.ColumnAutoWidth = False
        Me.gvDiarioPEM.OptionsView.ShowFooter = True
        Me.gvDiarioPEM.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "diarioId"
        Me.GridColumn7.FieldName = "diarioId"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "N° Ticket"
        Me.GridColumn1.FieldName = "diarioCod"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Placa"
        Me.GridColumn2.FieldName = "diaNPlaca"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha Ing."
        Me.GridColumn3.DisplayFormat.FormatString = "d"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "diaFechaIng"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Fecha Sal."
        Me.GridColumn13.FieldName = "diaFechaSal"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Hora Entrada"
        Me.GridColumn4.FieldName = "diaHoraIng"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Hora Salida"
        Me.GridColumn5.FieldName = "diaHoraSal"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Monto (S/.)"
        Me.GridColumn6.FieldName = "diaPrecio"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "diaPrecio", "Total : {0:###,##0.00}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "tgTipoAbonoId"
        Me.GridColumn8.FieldName = "tgTipoAbonoId"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tipo"
        Me.GridColumn9.FieldName = "tgTipoAbono"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Usuario ID"
        Me.GridColumn10.FieldName = "usuario"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "perId"
        Me.GridColumn11.FieldName = "perId"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Usuario"
        Me.GridColumn12.FieldName = "persona"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Cod. Concepto"
        Me.GridColumn14.FieldName = "conId"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Concepto"
        Me.GridColumn15.FieldName = "concepto"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(778, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscar.TabIndex = 11
        '
        'btnexportar
        '
        Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.Location = New System.Drawing.Point(842, 13)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(77, 35)
        Me.btnexportar.TabIndex = 9
        Me.btnexportar.Text = "Exportar"
        '
        'SaimtLabel9
        '
        Me.SaimtLabel9.Location = New System.Drawing.Point(551, 29)
        Me.SaimtLabel9.Name = "SaimtLabel9"
        Me.SaimtLabel9.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel9.TabIndex = 7
        Me.SaimtLabel9.Text = "Buscar por"
        '
        'SaimtLabel8
        '
        Me.SaimtLabel8.Location = New System.Drawing.Point(10, 29)
        Me.SaimtLabel8.Name = "SaimtLabel8"
        Me.SaimtLabel8.Size = New System.Drawing.Size(88, 13)
        Me.SaimtLabel8.TabIndex = 6
        Me.SaimtLabel8.Text = "Concepto Vehiculo"
        '
        'SaimtGroupBox4
        '
        Me.SaimtGroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel6)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel5)
        Me.SaimtGroupBox4.Controls.Add(Me.txtmonto)
        Me.SaimtGroupBox4.Controls.Add(Me.txtTiempo)
        Me.SaimtGroupBox4.Controls.Add(Me.SaimtLabel4)
        Me.SaimtGroupBox4.Controls.Add(Me.txtconcepto)
        Me.SaimtGroupBox4.Location = New System.Drawing.Point(7, 299)
        Me.SaimtGroupBox4.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SaimtGroupBox4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaimtGroupBox4.Name = "SaimtGroupBox4"
        Me.SaimtGroupBox4.Size = New System.Drawing.Size(1013, 68)
        Me.SaimtGroupBox4.TabIndex = 10
        Me.SaimtGroupBox4.Text = "Datos a Cobrar"
        '
        'SaimtLabel6
        '
        Me.SaimtLabel6.Location = New System.Drawing.Point(810, 37)
        Me.SaimtLabel6.Name = "SaimtLabel6"
        Me.SaimtLabel6.Size = New System.Drawing.Size(30, 13)
        Me.SaimtLabel6.TabIndex = 5
        Me.SaimtLabel6.Text = "Monto"
        '
        'SaimtLabel5
        '
        Me.SaimtLabel5.Location = New System.Drawing.Point(581, 37)
        Me.SaimtLabel5.Name = "SaimtLabel5"
        Me.SaimtLabel5.Size = New System.Drawing.Size(37, 13)
        Me.SaimtLabel5.TabIndex = 4
        Me.SaimtLabel5.Text = "Tiempo "
        '
        'txtmonto
        '
        Me.txtmonto.EditValue = "0"
        Me.txtmonto.Location = New System.Drawing.Point(843, 34)
        Me.txtmonto.MenuManager = Me.RibbonControl
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Properties.Mask.EditMask = "n2"
        Me.txtmonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtmonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtmonto.Properties.ReadOnly = True
        Me.txtmonto.Size = New System.Drawing.Size(152, 20)
        Me.txtmonto.TabIndex = 3
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(622, 34)
        Me.txtTiempo.MenuManager = Me.RibbonControl
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Properties.ReadOnly = True
        Me.txtTiempo.Size = New System.Drawing.Size(152, 20)
        Me.txtTiempo.TabIndex = 2
        '
        'SaimtLabel4
        '
        Me.SaimtLabel4.Location = New System.Drawing.Point(20, 37)
        Me.SaimtLabel4.Name = "SaimtLabel4"
        Me.SaimtLabel4.Size = New System.Drawing.Size(46, 13)
        Me.SaimtLabel4.TabIndex = 1
        Me.SaimtLabel4.Text = "Concepto"
        '
        'txtconcepto
        '
        Me.txtconcepto.Location = New System.Drawing.Point(73, 34)
        Me.txtconcepto.MenuManager = Me.RibbonControl
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Properties.ReadOnly = True
        Me.txtconcepto.Size = New System.Drawing.Size(448, 20)
        Me.txtconcepto.TabIndex = 0
        '
        'SaimtTextBox5
        '
        Me.SaimtTextBox5.Location = New System.Drawing.Point(349, 27)
        Me.SaimtTextBox5.MenuManager = Me.RibbonControl
        Me.SaimtTextBox5.Name = "SaimtTextBox5"
        Me.SaimtTextBox5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SaimtTextBox5.Properties.Appearance.Options.UseFont = True
        Me.SaimtTextBox5.Properties.ReadOnly = True
        Me.SaimtTextBox5.Size = New System.Drawing.Size(182, 26)
        Me.SaimtTextBox5.TabIndex = 7
        '
        'SaimtTextBox1
        '
        Me.SaimtTextBox1.EditValue = ""
        Me.SaimtTextBox1.Location = New System.Drawing.Point(310, 173)
        Me.SaimtTextBox1.MenuManager = Me.RibbonControl
        Me.SaimtTextBox1.Name = "SaimtTextBox1"
        Me.SaimtTextBox1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaimtTextBox1.Properties.Appearance.Options.UseFont = True
        Me.SaimtTextBox1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SaimtTextBox1.Size = New System.Drawing.Size(574, 103)
        Me.SaimtTextBox1.TabIndex = 1
        '
        'SaimtTextBox3
        '
        Me.SaimtTextBox3.Location = New System.Drawing.Point(73, 34)
        Me.SaimtTextBox3.MenuManager = Me.RibbonControl
        Me.SaimtTextBox3.Name = "SaimtTextBox3"
        Me.SaimtTextBox3.Size = New System.Drawing.Size(448, 20)
        Me.SaimtTextBox3.TabIndex = 0
        '
        'tmhora
        '
        Me.tmhora.Interval = 60000
        '
        'frmSalidaCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 735)
        Me.Controls.Add(Me.SaimtGroupBox4)
        Me.Controls.Add(Me.SaimtGroupBox3)
        Me.Controls.Add(Me.SaimtGroupBox1)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmSalidaCaja"
        Me.Text = "frmSalidaCaja"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox3, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox4, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox1.ResumeLayout(False)
        Me.SaimtGroupBox1.PerformLayout()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox3.ResumeLayout(False)
        Me.SaimtGroupBox3.PerformLayout()
        CType(Me.cboEstados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConceptosBusquedas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDiarioPEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDiarioPEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox4.ResumeLayout(False)
        Me.SaimtGroupBox4.PerformLayout()
        CType(Me.txtmonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTiempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtconcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTextBox5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTextBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtTextBox3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaimtGroupBox1 As SaimtControles.SaimtGroupBox
    Friend WithEvents txtHora As SaimtControles.SaimtTextBox
    Friend WithEvents txtfecha As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel10 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
    Friend WithEvents btnOKPlaca As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents btnOKTiket As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel3 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtGroupBox3 As SaimtControles.SaimtGroupBox
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents SaimtLabel9 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel8 As SaimtControles.SaimtLabel
    Friend WithEvents btnBuscar As SaimtControles.SaimtButton
    Friend WithEvents dgvDiarioPEM As SaimtControles.SaimtDataGrid
    Friend WithEvents gvDiarioPEM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtGroupBox4 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel6 As SaimtControles.SaimtLabel
    Friend WithEvents SaimtLabel5 As SaimtControles.SaimtLabel
    Friend WithEvents txtmonto As SaimtControles.SaimtTextBox
    Friend WithEvents txtTiempo As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel4 As SaimtControles.SaimtLabel
    Friend WithEvents txtconcepto As SaimtControles.SaimtTextBox
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtTextBox5 As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtTextBox1 As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtTextBox3 As SaimtControles.SaimtTextBox
    Friend WithEvents cboEstados As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboConceptosBusquedas As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents tmhora As System.Windows.Forms.Timer
    Friend WithEvents btnImprimir As SaimtControles.SaimtButton
    Friend WithEvents sfdExportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtTicket As System.Windows.Forms.TextBox
    Friend WithEvents txtplaca As System.Windows.Forms.TextBox
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
End Class
