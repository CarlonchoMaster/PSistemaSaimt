Imports SaimtControles
Imports ReglasNegocio

Public Class frmCambiarPassword
    Inherits frmGeneral


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If txtNuevoPassword.Text IsNot Nothing Then
                If txtRepitaPassword.Text Is Nothing Then
                    Throw New Exception("Repita el Password como Ingreso en el Nuevo Pasword")
                End If
                If txtRepitaPassword.Text IsNot Nothing Then
                    If txtRepitaPassword.Text <> txtNuevoPassword.Text Then
                        Throw New Exception("Repita el Password como Ingreso en el Nuevo Pasword")
                    End If
                End If
            End If
            MantenimientosBL.Instancia.usuariosCambiarPassword(IdUsuarioOnline, txtAntiguoPassword.Text, txtNuevoPassword.Text)
            Me.mostrarMensajeBarra("El Password Se Actualizo Correctamente")
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub frmCambiarPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mGSetearTool(btnGuardar, "Guardar", "Guardar cambios efectuados")
    End Sub
End Class