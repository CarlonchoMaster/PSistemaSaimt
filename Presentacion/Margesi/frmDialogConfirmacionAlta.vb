Imports System.Windows.Forms

Public Class frmDialogConfirmacionAlta
    Public Property result() As Boolean

    Public Sub New(ByVal lsubicacion As String, ByVal lsFile As String, ByVal lsRubro As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtDireccion.Text = lsubicacion
        txtFile.Text = lsFile
        txtRubro.Text = lsRubro
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        result = True
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        result = False
        Me.Close()
    End Sub

    Private Sub btnConsultaInmueblePadre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaInmueblePadre.Click
        frmInmueblesAlta.btnImprimir.PerformClick()
    End Sub



End Class
