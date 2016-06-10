Imports ReglasNegocio
Imports Entidades

Public Class frmLoginTra
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Try
            Dim loUsuario As EEUsuarios = MantenimientosBL.Instancia.usuariosLogin(txtUsuario.Text, txtPassword.Text)
            If loUsuario IsNot Nothing Then
                Session("usuario") = loUsuario

                If chkRecordarContraseña.Checked Then
                    FormsAuthentication.RedirectFromLoginPage(txtUsuario.Text, True)
                Else
                    FormsAuthentication.RedirectFromLoginPage(txtUsuario.Text, False)
                End If
            Else
                Dim sbMensaje As StringBuilder = New StringBuilder()
                sbMensaje.Append("<script type='text/javascript'>")
                sbMensaje.AppendFormat("alert('{0}');", "Usuario o Password Incorrectos")
                sbMensaje.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensaje.ToString())
            End If
        Catch ex As Exception
            Dim sbMensaje As StringBuilder = New StringBuilder()
            sbMensaje.Append("<script type='text/javascript'>")
            sbMensaje.AppendFormat("alert('{0}');", ex.Message)
            sbMensaje.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensaje.ToString())
        End Try
    End Sub
End Class