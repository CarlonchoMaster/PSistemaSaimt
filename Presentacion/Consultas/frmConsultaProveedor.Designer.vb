﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaProveedor
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
        Me.btnAgregarConyuge = New SaimtControles.SaimtButton()
        Me.txtBuscar = New SaimtControles.SaimtTextBox()
        Me.SaimtLabel1 = New SaimtControles.SaimtLabel()
        Me.btnSeleccionar = New SaimtControles.SaimtButton()
        Me.dgvResultado = New SaimtControles.SaimtDataGrid()
        Me.gvResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnBuscar = New SaimtControles.SaimtButton()
        Me.cboCriterioConsulta = New SaimtControles.SaimtComboBox()
        Me.SaimtLabel2 = New SaimtControles.SaimtLabel()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCriterioConsulta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 254)
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(598, 25)
        '
        'btnAgregarConyuge
        '
        Me.btnAgregarConyuge.Image = Global.Presentacion.My.Resources.Resources.addc
        Me.btnAgregarConyuge.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregarConyuge.Location = New System.Drawing.Point(569, 2)
        Me.btnAgregarConyuge.Name = "btnAgregarConyuge"
        Me.btnAgregarConyuge.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarConyuge.TabIndex = 9
        Me.btnAgregarConyuge.ToolTip = "Agregar Conyuge"
        Me.btnAgregarConyuge.ToolTipTitle = "Nuevo"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(52, 3)
        Me.txtBuscar.MenuManager = Me.RibbonControl
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(212, 20)
        Me.txtBuscar.TabIndex = 7
        '
        'SaimtLabel1
        '
        Me.SaimtLabel1.Location = New System.Drawing.Point(7, 6)
        Me.SaimtLabel1.Name = "SaimtLabel1"
        Me.SaimtLabel1.Size = New System.Drawing.Size(39, 13)
        Me.SaimtLabel1.TabIndex = 6
        Me.SaimtLabel1.Text = "Buscar :"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(201, 221)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 28)
        Me.btnSeleccionar.TabIndex = 11
        Me.btnSeleccionar.Text = "Seleccionar"
        '
        'dgvResultado
        '
        Me.dgvResultado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultado.Location = New System.Drawing.Point(7, 30)
        Me.dgvResultado.MainView = Me.gvResultado
        Me.dgvResultado.MenuManager = Me.RibbonControl
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.Size = New System.Drawing.Size(584, 187)
        Me.dgvResultado.TabIndex = 10
        Me.dgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResultado})
        '
        'gvResultado
        '
        Me.gvResultado.GridControl = Me.dgvResultado
        Me.gvResultado.Name = "gvResultado"
        Me.gvResultado.OptionsBehavior.Editable = False
        Me.gvResultado.OptionsView.ColumnAutoWidth = False
        Me.gvResultado.OptionsView.ShowGroupPanel = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(264, 1)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscar.TabIndex = 8
        '
        'cboCriterioConsulta
        '
        Me.cboCriterioConsulta.EditValue = ""
        Me.cboCriterioConsulta.Location = New System.Drawing.Point(354, 3)
        Me.cboCriterioConsulta.MenuManager = Me.RibbonControl
        Me.cboCriterioConsulta.Name = "cboCriterioConsulta"
        Me.cboCriterioConsulta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCriterioConsulta.Size = New System.Drawing.Size(209, 20)
        Me.cboCriterioConsulta.TabIndex = 12
        '
        'SaimtLabel2
        '
        Me.SaimtLabel2.Location = New System.Drawing.Point(297, 6)
        Me.SaimtLabel2.Name = "SaimtLabel2"
        Me.SaimtLabel2.Size = New System.Drawing.Size(51, 13)
        Me.SaimtLabel2.TabIndex = 13
        Me.SaimtLabel2.Text = "Buscar por"
        '
        'frmConsultaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonBuscar = Me.btnBuscar
        Me.ButtonSeleccionar = Me.btnSeleccionar
        Me.ClientSize = New System.Drawing.Size(598, 279)
        Me.Controls.Add(Me.SaimtLabel2)
        Me.Controls.Add(Me.cboCriterioConsulta)
        Me.Controls.Add(Me.btnAgregarConyuge)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.SaimtLabel1)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.dgvResultado)
        Me.Controls.Add(Me.btnBuscar)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmConsultaProveedor"
        Me.SaimtGrid = Me.dgvResultado
        Me.Text = "CONSULTA PROVEEDOR"
        Me.Controls.SetChildIndex(Me.rsbMensajeBarra, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.dgvResultado, 0)
        Me.Controls.SetChildIndex(Me.btnSeleccionar, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAgregarConyuge, 0)
        Me.Controls.SetChildIndex(Me.cboCriterioConsulta, 0)
        Me.Controls.SetChildIndex(Me.SaimtLabel2, 0)
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCriterioConsulta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarConyuge As SaimtControles.SaimtButton
    Friend WithEvents txtBuscar As SaimtControles.SaimtTextBox
    Friend WithEvents SaimtLabel1 As SaimtControles.SaimtLabel
    Friend WithEvents btnSeleccionar As SaimtControles.SaimtButton
    Friend WithEvents dgvResultado As SaimtControles.SaimtDataGrid
    Friend WithEvents gvResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnBuscar As SaimtControles.SaimtButton
    Friend WithEvents cboCriterioConsulta As SaimtControles.SaimtComboBox
    Friend WithEvents SaimtLabel2 As SaimtControles.SaimtLabel
End Class