<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaTablaGeneral
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
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.txtBuscar = New SaimtControles.SaimtTextBox()
        Me.btnBuscar = New SaimtControles.SaimtButton()
        Me.dgvResultado = New SaimtControles.SaimtDataGrid()
        Me.gvResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTgCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgAbrev = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSeleccionar = New SaimtControles.SaimtButton()
        Me.cboBuscarPor = New SaimtControles.SaimtComboBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscarPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 330)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(706, 27)
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(5, 9)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(39, 13)
        Me.SaimtLabel1.TabIndex = 0
        Me.SaimtLabel1.Text = "Buscar :"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(49, 6)
        Me.txtBuscar.MenuManager = Me.RibbonControl
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(295, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(350, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscar.TabIndex = 3
        '
        'dgvResultado
        '
        Me.dgvResultado.Location = New System.Drawing.Point(5, 34)
        Me.dgvResultado.MainView = Me.gvResultado
        Me.dgvResultado.MenuManager = Me.RibbonControl
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.Size = New System.Drawing.Size(690, 259)
        Me.dgvResultado.TabIndex = 2
        Me.dgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResultado})
        '
        'gvResultado
        '
        Me.gvResultado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTgCodigo, Me.colTgNombre, Me.colTgAbrev, Me.colTgDescripcion})
        Me.gvResultado.GridControl = Me.dgvResultado
        Me.gvResultado.Name = "gvResultado"
        Me.gvResultado.OptionsBehavior.Editable = False
        Me.gvResultado.OptionsView.ColumnAutoWidth = False
        Me.gvResultado.OptionsView.ShowGroupPanel = False
        '
        'colTgCodigo
        '
        Me.colTgCodigo.Caption = "Codigo"
        Me.colTgCodigo.FieldName = "tgCodigo"
        Me.colTgCodigo.Name = "colTgCodigo"
        Me.colTgCodigo.Visible = True
        Me.colTgCodigo.VisibleIndex = 0
        '
        'colTgNombre
        '
        Me.colTgNombre.Caption = "Nombre"
        Me.colTgNombre.FieldName = "tgNombre"
        Me.colTgNombre.Name = "colTgNombre"
        Me.colTgNombre.Visible = True
        Me.colTgNombre.VisibleIndex = 1
        '
        'colTgAbrev
        '
        Me.colTgAbrev.Caption = "Siglas"
        Me.colTgAbrev.FieldName = "tgAbrev"
        Me.colTgAbrev.Name = "colTgAbrev"
        Me.colTgAbrev.Visible = True
        Me.colTgAbrev.VisibleIndex = 3
        '
        'colTgDescripcion
        '
        Me.colTgDescripcion.Caption = "Descripcion"
        Me.colTgDescripcion.FieldName = "tgDescripcion"
        Me.colTgDescripcion.Name = "colTgDescripcion"
        Me.colTgDescripcion.Visible = True
        Me.colTgDescripcion.VisibleIndex = 2
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(303, 299)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 28)
        Me.btnSeleccionar.TabIndex = 4
        Me.btnSeleccionar.Text = "Seleccionar"
        '
        'cboBuscarPor
        '
        Me.cboBuscarPor.EditValue = "Busqueda por Nombre"
        Me.cboBuscarPor.Location = New System.Drawing.Point(440, 6)
        Me.cboBuscarPor.MenuManager = Me.RibbonControl
        Me.cboBuscarPor.Name = "cboBuscarPor"
        Me.cboBuscarPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarPor.Properties.Items.AddRange(New Object() {"Busqueda por Nombre", "Busqueda por Descripción "})
        Me.cboBuscarPor.Size = New System.Drawing.Size(254, 20)
        Me.cboBuscarPor.TabIndex = 5
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(383, 9)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel2.TabIndex = 6
        Me.SaimtLabel2.Text = "Buscar por"
        '
        'frmConsultaTablaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonBuscar = Me.btnBuscar
        Me.ButtonSeleccionar = Me.btnSeleccionar
        Me.ClientSize = New System.Drawing.Size(706, 357)
        Me.Controls.Add(Me.SaimtLabel2)
        Me.Controls.Add(Me.cboBuscarPor)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.SaimtLabel1)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.dgvResultado)
        Me.Controls.Add(Me.btnBuscar)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmConsultaTablaGeneral"
        Me.SaimtGrid = Me.dgvResultado
        Me.Text = "CONSULTA TABLA GENERAL"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.dgvResultado, 0)
        Me.Controls.SetChildIndex(Me.btnSeleccionar, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.cboBuscarPor, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel2, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscarPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents txtBuscar As SaimtControles.SaimtTextBox
    Friend WithEvents btnBuscar As SaimtControles.SaimtButton
    Friend WithEvents dgvResultado As SaimtControles.SaimtDataGrid
    Friend WithEvents gvResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSeleccionar As SaimtControles.SaimtButton
    Friend WithEvents colTgCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgAbrev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboBuscarPor As SaimtControles.SaimtComboBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
End Class
