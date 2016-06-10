<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInmueblesActualizaciones
    Inherits Presentacion.frmConsultas

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInmueblesActualizaciones))
        Me.dgvResultado = New SaimtControles.SaimtDataGrid()
        Me.gvResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcInmCod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInmUpdFechaReg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUsuLogin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcinmUpdId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInmUpdDetCampoText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInmUpdDetValorOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInmUpdDetValorNew = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInmId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInmUbicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInmUpdDetId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnBuscar = New SaimtControles.SaimtButton()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.cboCriterioFecha = New SaimtControles.SaimtComboBoxLookUp()
        Me.cboCriterioFechaSub = New SaimtControles.SaimtComboBoxLookUp()
        Me.SaimtGroupBox2 = New SaimtControles.SaimtGroupBox()
        Me.btnexportar = New SaimtControles.SaimtButton()
        Me.btnSeleccionar = New SaimtControles.SaimtButton()
        Me.btnQuitar = New SaimtControles.SaimtButton()
        Me.lblResultados = New SaimtControles.SaimtLabel()
        Me.SaimtLabel67 = New SaimtControles.SaimtLabel()
        Me.gbOtras = New SaimtControles.SaimtGroupBox()
        Me.chkCriteriosInmEstado3 = New SaimtControles.SaimtCheckBox()
        Me.sfdexportar = New System.Windows.Forms.SaveFileDialog()
        Me.cboAnio = New SaimtControles.SaimtComboBoxLookUp()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterioFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterioFechaSub.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaimtGroupBox2.SuspendLayout()
        CType(Me.gbOtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOtras.SuspendLayout()
        CType(Me.chkCriteriosInmEstado3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 454)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(951, 27)
        '
        'dgvResultado
        '
        Me.dgvResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultado.Location = New System.Drawing.Point(5, 51)
        Me.dgvResultado.MainView = Me.gvResultado
        Me.dgvResultado.MenuManager = Me.RibbonControl
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.Size = New System.Drawing.Size(941, 266)
        Me.dgvResultado.TabIndex = 3
        Me.dgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResultado})
        '
        'gvResultado
        '
        Me.gvResultado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcInmCod, Me.gcInmUpdFechaReg, Me.gcUsuLogin, Me.gcinmUpdId, Me.gcInmUpdDetCampoText, Me.gcInmUpdDetValorOld, Me.gcInmUpdDetValorNew, Me.gcInmId, Me.gcInmUbicacion, Me.gcInmUpdDetId})
        Me.gvResultado.GridControl = Me.dgvResultado
        Me.gvResultado.Name = "gvResultado"
        Me.gvResultado.OptionsBehavior.Editable = False
        Me.gvResultado.OptionsView.ColumnAutoWidth = False
        Me.gvResultado.OptionsView.ShowGroupPanel = False
        '
        'gcInmCod
        '
        Me.gcInmCod.Caption = "Código Margesí MPT"
        Me.gcInmCod.FieldName = "InmCodigo"
        Me.gcInmCod.Name = "gcInmCod"
        Me.gcInmCod.Visible = True
        Me.gcInmCod.VisibleIndex = 0
        '
        'gcInmUpdFechaReg
        '
        Me.gcInmUpdFechaReg.Caption = "Fecha Modificación"
        Me.gcInmUpdFechaReg.FieldName = "InmUpdFechaReg"
        Me.gcInmUpdFechaReg.Name = "gcInmUpdFechaReg"
        Me.gcInmUpdFechaReg.Visible = True
        Me.gcInmUpdFechaReg.VisibleIndex = 1
        '
        'gcUsuLogin
        '
        Me.gcUsuLogin.Caption = "Usuario"
        Me.gcUsuLogin.FieldName = "UsuLogin"
        Me.gcUsuLogin.Name = "gcUsuLogin"
        Me.gcUsuLogin.Visible = True
        Me.gcUsuLogin.VisibleIndex = 2
        '
        'gcinmUpdId
        '
        Me.gcinmUpdId.Caption = "Código de Actualización"
        Me.gcinmUpdId.FieldName = "InmUpdId"
        Me.gcinmUpdId.Name = "gcinmUpdId"
        Me.gcinmUpdId.Visible = True
        Me.gcinmUpdId.VisibleIndex = 3
        '
        'gcInmUpdDetCampoText
        '
        Me.gcInmUpdDetCampoText.Caption = "Campo"
        Me.gcInmUpdDetCampoText.FieldName = "InmUpdDetCampoText"
        Me.gcInmUpdDetCampoText.Name = "gcInmUpdDetCampoText"
        Me.gcInmUpdDetCampoText.Visible = True
        Me.gcInmUpdDetCampoText.VisibleIndex = 4
        '
        'gcInmUpdDetValorOld
        '
        Me.gcInmUpdDetValorOld.Caption = "Información Antigua"
        Me.gcInmUpdDetValorOld.FieldName = "InmUpdDetValorOld"
        Me.gcInmUpdDetValorOld.Name = "gcInmUpdDetValorOld"
        Me.gcInmUpdDetValorOld.Visible = True
        Me.gcInmUpdDetValorOld.VisibleIndex = 5
        '
        'gcInmUpdDetValorNew
        '
        Me.gcInmUpdDetValorNew.Caption = "Información Actual"
        Me.gcInmUpdDetValorNew.FieldName = "InmUpdDetValorNew"
        Me.gcInmUpdDetValorNew.Name = "gcInmUpdDetValorNew"
        Me.gcInmUpdDetValorNew.Visible = True
        Me.gcInmUpdDetValorNew.VisibleIndex = 6
        '
        'gcInmId
        '
        Me.gcInmId.Caption = "Código Informático"
        Me.gcInmId.FieldName = "InmId"
        Me.gcInmId.Name = "gcInmId"
        Me.gcInmId.Visible = True
        Me.gcInmId.VisibleIndex = 7
        '
        'gcInmUbicacion
        '
        Me.gcInmUbicacion.Caption = "InmUbicacion"
        Me.gcInmUbicacion.FieldName = "InmUbicacion"
        Me.gcInmUbicacion.Name = "gcInmUbicacion"
        '
        'gcInmUpdDetId
        '
        Me.gcInmUpdDetId.Caption = "GridColumn1"
        Me.gcInmUpdDetId.FieldName = "InmUpdDetId"
        Me.gcInmUpdDetId.Name = "gcInmUpdDetId"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(549, 32)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscar.TabIndex = 5
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(128, 36)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(41, 13)
        Me.SaimtLabel1.TabIndex = 6
        Me.SaimtLabel1.Text = "Fechas :"
        '
        'cboCriterioFecha
        '
        Me.cboCriterioFecha.Location = New System.Drawing.Point(262, 33)
        Me.cboCriterioFecha.MenuManager = Me.RibbonControl
        Me.cboCriterioFecha.Name = "cboCriterioFecha"
        Me.cboCriterioFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioFecha.Properties.NullText = ""
        Me.cboCriterioFecha.Size = New System.Drawing.Size(145, 20)
        Me.cboCriterioFecha.TabIndex = 7
        '
        'cboCriterioFechaSub
        '
        Me.cboCriterioFechaSub.Location = New System.Drawing.Point(413, 33)
        Me.cboCriterioFechaSub.MenuManager = Me.RibbonControl
        Me.cboCriterioFechaSub.Name = "cboCriterioFechaSub"
        Me.cboCriterioFechaSub.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioFechaSub.Properties.NullText = ""
        Me.cboCriterioFechaSub.Size = New System.Drawing.Size(130, 20)
        Me.cboCriterioFechaSub.TabIndex = 8
        '
        'SaimtGroupBox2
        '
        Me.SaimtGroupBox2.Controls.Add(Me.btnexportar)
        Me.SaimtGroupBox2.Controls.Add(Me.btnSeleccionar)
        Me.SaimtGroupBox2.Controls.Add(Me.btnQuitar)
        Me.SaimtGroupBox2.Controls.Add(Me.lblResultados)
        Me.SaimtGroupBox2.Controls.Add(Me.SaimtLabel67)
        Me.SaimtGroupBox2.Controls.Add(Me.dgvResultado)
        Me.SaimtGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SaimtGroupBox2.Location = New System.Drawing.Point(0, 94)
        Me.SaimtGroupBox2.Name = "SaimtGroupBox2"
        Me.SaimtGroupBox2.ShowCaption = False
        Me.SaimtGroupBox2.Size = New System.Drawing.Size(951, 360)
        Me.SaimtGroupBox2.TabIndex = 17
        '
        'btnexportar
        '
        Me.btnexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.Location = New System.Drawing.Point(809, 323)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(120, 31)
        Me.btnexportar.TabIndex = 18
        Me.btnexportar.Text = "Exportar a Excel"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.Location = New System.Drawing.Point(407, 331)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 17
        Me.btnSeleccionar.Text = "Seleccionar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Image = Global.Presentacion.My.Resources.Resources.remover
        Me.btnQuitar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuitar.Location = New System.Drawing.Point(904, 14)
        Me.btnQuitar.LookAndFeel.SkinName = "Seven"
        Me.btnQuitar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(25, 18)
        Me.btnQuitar.TabIndex = 16
        '
        'lblResultados
        '
        Me.lblResultados.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultados.Location = New System.Drawing.Point(682, 14)
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Size = New System.Drawing.Size(144, 13)
        Me.lblResultados.TabIndex = 4
        Me.lblResultados.Text = "Resultados de Busquedas"
        '
        'SaimtLabel67
        '
        Me.SaimtLabel67.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SaimtLabel67.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.SaimtLabel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.SaimtLabel67.Location = New System.Drawing.Point(2, 2)
        Me.SaimtLabel67.Name = "SaimtLabel67"
        Me.SaimtLabel67.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.SaimtLabel67.Size = New System.Drawing.Size(947, 18)
        Me.SaimtLabel67.TabIndex = 2
        Me.SaimtLabel67.Text = "De la lista ya buscada, en la caja de texto abajo; podras realizar cualquier sub " & _
            "consulta de cualquiera de los campos mostrados en la tabla."
        '
        'gbOtras
        '
        Me.gbOtras.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.gbOtras.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.gbOtras.Appearance.Options.UseBackColor = True
        Me.gbOtras.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.gbOtras.AppearanceCaption.Options.UseForeColor = True
        Me.gbOtras.Controls.Add(Me.cboAnio)
        Me.gbOtras.Controls.Add(Me.chkCriteriosInmEstado3)
        Me.gbOtras.Controls.Add(Me.cboCriterioFechaSub)
        Me.gbOtras.Controls.Add(Me.btnBuscar)
        Me.gbOtras.Controls.Add(Me.cboCriterioFecha)
        Me.gbOtras.Controls.Add(Me.SaimtLabel1)
        Me.gbOtras.Location = New System.Drawing.Point(2, 5)
        Me.gbOtras.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gbOtras.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gbOtras.Name = "gbOtras"
        Me.gbOtras.Size = New System.Drawing.Size(944, 83)
        Me.gbOtras.TabIndex = 18
        Me.gbOtras.Text = "    Buscar por Denominación y Referencia"
        '
        'chkCriteriosInmEstado3
        '
        Me.chkCriteriosInmEstado3.EditValue = True
        Me.chkCriteriosInmEstado3.Location = New System.Drawing.Point(952, 0)
        Me.chkCriteriosInmEstado3.MenuManager = Me.RibbonControl
        Me.chkCriteriosInmEstado3.Name = "chkCriteriosInmEstado3"
        Me.chkCriteriosInmEstado3.Properties.AutoWidth = True
        Me.chkCriteriosInmEstado3.Properties.Caption = "Registrados"
        Me.chkCriteriosInmEstado3.Size = New System.Drawing.Size(79, 19)
        Me.chkCriteriosInmEstado3.TabIndex = 56
        Me.chkCriteriosInmEstado3.Tag = "NotClear"
        Me.chkCriteriosInmEstado3.Visible = False
        '
        'cboAnio
        '
        Me.cboAnio.Location = New System.Drawing.Point(184, 33)
        Me.cboAnio.MenuManager = Me.RibbonControl
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAnio.Properties.NullText = ""
        Me.cboAnio.Size = New System.Drawing.Size(72, 20)
        Me.cboAnio.TabIndex = 57
        '
        'frmInmueblesActualizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonBuscar = Me.btnBuscar
        Me.ButtonSeleccionar = Me.btnSeleccionar
        Me.ClientSize = New System.Drawing.Size(951, 481)
        Me.Controls.Add(Me.gbOtras)
        Me.Controls.Add(Me.SaimtGroupBox2)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmInmueblesActualizaciones"
        Me.SaimtGrid = Me.dgvResultado
        Me.Text = "Inmuebles para Actualización "
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.SaimtGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.gbOtras, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterioFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterioFechaSub.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaimtGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaimtGroupBox2.ResumeLayout(False)
        Me.SaimtGroupBox2.PerformLayout()
        CType(Me.gbOtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOtras.ResumeLayout(False)
        Me.gbOtras.PerformLayout()
        CType(Me.chkCriteriosInmEstado3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvResultado As SaimtControles.SaimtDataGrid
    Friend WithEvents gvResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcInmId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBuscar As SaimtControles.SaimtButton
    Friend WithEvents gcInmUpdFechaReg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcUsuLogin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcinmUpdId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcInmUpdDetCampoText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcInmUpdDetValorOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcInmUpdDetValorNew As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents cboCriterioFecha As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents cboCriterioFechaSub As SaimtControles.SaimtComboBoxLookUp
    Friend WithEvents gcInmCod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaimtGroupBox2 As SaimtControles.SaimtGroupBox
    Friend WithEvents SaimtLabel67 As SaimtControles.SaimtLabel
    Friend WithEvents lblResultados As SaimtControles.SaimtLabel
    Friend WithEvents btnQuitar As SaimtControles.SaimtButton
    Friend WithEvents gbOtras As SaimtControles.SaimtGroupBox
    Friend WithEvents chkCriteriosInmEstado3 As SaimtControles.SaimtCheckBox
    Friend WithEvents btnexportar As SaimtControles.SaimtButton
    Friend WithEvents btnSeleccionar As SaimtControles.SaimtButton
    Friend WithEvents sfdexportar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gcInmUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcInmUpdDetId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboAnio As SaimtControles.SaimtComboBoxLookUp
End Class
