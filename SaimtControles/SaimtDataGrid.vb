Imports DevExpress.XtraGrid

Public Class SaimtDataGrid
    Inherits GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView

    Private Sub InitializeComponent()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me
        Me.GridView1.Name = "GridView1"
        '
        'SaimtDataGrid
        '
        Me.MainView = Me.GridView1
        Me.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
