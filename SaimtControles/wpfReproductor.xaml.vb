Imports System.Windows.Media
Public Class wpfReproductor
    Private urlrep As String
    Dim tg As New TransformGroup
    Dim rt As New RotateTransform(0)
    Public Sub New(ByVal url As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        urlrep = url
    End Sub
    Private Sub btnplay_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnplay.Click
        Try
            tg.Children.Add(rt)
            Me.Reproductor.RenderTransform = tg
            Me.Reproductor.Source = New Uri(urlrep)
            Me.Reproductor.Play()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnparar_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnparar.Click
        Me.Reproductor.Stop()
    End Sub

   
    Private Sub btnpausa_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnpausa.Click
        Me.Reproductor.Pause()
    End Sub

    
    Private Sub tbevolumen_EditValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs) Handles tbevolumen.EditValueChanged
        Me.Reproductor.Volume = (CDbl(Me.tbevolumen.EditValue) / 100)
    End Sub

    Private Sub UserControl_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

    End Sub

    Private Sub fullscreen_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles fullscreen.Click

    End Sub
End Class
