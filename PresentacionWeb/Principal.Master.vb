Imports Entidades

Public Class Principal
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not Page.IsPostBack Then
        If Session("usuario") IsNot Nothing Then
            Dim loUsuario As EEUsuarios = DirectCast(Session("usuario"), EEUsuarios)
            lblUsuarioOnline.Text = loUsuario.OPersona.PerApePaterno & " " & loUsuario.OPersona.PerApeMaterno & " " & loUsuario.OPersona.PerNombres
        Else
            FormsAuthentication.RedirectToLoginPage()
        End If
        'End If
    End Sub

    Protected Sub linkCerrarSesion_Click(sender As Object, e As EventArgs) Handles linkCerrarSesion.Click
        FormsAuthentication.SignOut()
        Session.Remove("usuario")
        FormsAuthentication.RedirectToLoginPage()
    End Sub
End Class