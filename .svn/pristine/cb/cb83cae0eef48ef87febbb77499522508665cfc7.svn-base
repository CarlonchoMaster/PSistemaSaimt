Public Class frmCambiarArchivo
    Inherits frmGeneral

    Private _TipoArchivo As String
    Public Property TipoArchivo() As String
        Get
            Return _TipoArchivo
        End Get
        Set(ByVal value As String)
            _TipoArchivo = value
        End Set
    End Property

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmCambiarArchivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If TipoArchivo.ToLower().Contains(".jpg") Or TipoArchivo.ToLower().Contains(".gif") Then
            chkArchPrincipal.Properties.ReadOnly = False
        Else
            chkArchPrincipal.Properties.ReadOnly = True
        End If
    End Sub
End Class