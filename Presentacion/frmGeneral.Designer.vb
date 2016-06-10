<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneral
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneral))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bsiMensaje = New DevExpress.XtraBars.BarStaticItem()
        Me.bbicalcmora = New DevExpress.XtraBars.BarButtonItem()
        Me.bbicalcmorasc = New DevExpress.XtraBars.BarButtonItem()
        Me.rsbMensajeBarra = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.pmconsultorpropagos = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonText = Nothing
        Me.RibbonControl.Dock = System.Windows.Forms.DockStyle.None
        '
        '
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.ExpandCollapseItem.Name = ""
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.bsiMensaje, Me.bbicalcmora, Me.bbicalcmorasc})
        Me.RibbonControl.Location = New System.Drawing.Point(677, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowCategoryInCaption = False
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(0, 0)
        Me.RibbonControl.StatusBar = Me.rsbMensajeBarra
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        Me.RibbonControl.Visible = False
        '
        'bsiMensaje
        '
        Me.bsiMensaje.Id = 1
        Me.bsiMensaje.Name = "bsiMensaje"
        Me.bsiMensaje.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bbicalcmora
        '
        Me.bbicalcmora.Caption = "Calcular Mora"
        Me.bbicalcmora.Glyph = CType(resources.GetObject("bbicalcmora.Glyph"), System.Drawing.Image)
        Me.bbicalcmora.Id = 2
        Me.bbicalcmora.Name = "bbicalcmora"
        '
        'bbicalcmorasc
        '
        Me.bbicalcmorasc.Caption = "Calcular Mora sin Contrato"
        Me.bbicalcmorasc.Glyph = CType(resources.GetObject("bbicalcmorasc.Glyph"), System.Drawing.Image)
        Me.bbicalcmorasc.Id = 3
        Me.bbicalcmorasc.Name = "bbicalcmorasc"
        '
        'rsbMensajeBarra
        '
        Me.rsbMensajeBarra.ItemLinks.Add(Me.bsiMensaje)
        Me.rsbMensajeBarra.Location = New System.Drawing.Point(0, 415)
        Me.rsbMensajeBarra.Name = "rsbMensajeBarra"
        Me.rsbMensajeBarra.Ribbon = Me.RibbonControl
        Me.rsbMensajeBarra.Size = New System.Drawing.Size(679, 27)
        '
        'pmconsultorpropagos
        '
        Me.pmconsultorpropagos.ItemLinks.Add(Me.bbicalcmora)
        Me.pmconsultorpropagos.ItemLinks.Add(Me.bbicalcmorasc)
        Me.pmconsultorpropagos.Name = "pmconsultorpropagos"
        Me.pmconsultorpropagos.Ribbon = Me.RibbonControl
        '
        'frmGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 442)
        Me.Controls.Add(Me.rsbMensajeBarra)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven"
        Me.Name = "frmGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pmconsultorpropagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbicalcmora As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbicalcmorasc As DevExpress.XtraBars.BarButtonItem
    Protected Friend WithEvents pmconsultorpropagos As DevExpress.XtraBars.PopupMenu
    Friend WithEvents bsiMensaje As DevExpress.XtraBars.BarStaticItem
    Protected Friend WithEvents rsbMensajeBarra As DevExpress.XtraBars.Ribbon.RibbonStatusBar


End Class
