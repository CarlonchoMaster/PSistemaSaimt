Imports LibReniec
Public Class frmReniec
    Inherits frmGeneral

    Dim myInfo As Info_Reniec
    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If Me.txtNumDni.Text.Length <> 8 Then
        '        Me.LblResul.Text = "Ingrese Dni Valido"
        '        Me.txtNumDni.SelectAll()
        '        Me.txtNumDni.Focus()
        '        Return
        '    End If

        '    myInfo.GetInfo(Me.txtNumDni.Text, Me.txtCapcha.Text)
        '    CaptionResul()
        '    ' CargarImagen()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub cmdReloadCapcha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    'CargarImagen()
        '    Me.txtCapcha.SelectAll()
        '    Me.txtCapcha.Focus()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub txtNumDni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   LblResul.Text = ""
    End Sub
    Private Sub CaptionResul()
        'Try
        '    Select Case myInfo.GetResul
        '        Case LibReniec.Info.Resul.Ok
        '            Me.LblResul.Text = [String].Format(("Nombre(s): {0}" + Environment.NewLine & "Apellidos Paterno: {1}") + Environment.NewLine & "Apellidos Paterno: {2}", myInfo.Nombres, myInfo.ApePaterno, myInfo.ApeMaterno)
        '            Exit Select
        '        Case LibReniec.Info.Resul.NoResul
        '            Me.LblResul.Text = "No existe DNI"
        '            Exit Select
        '        Case LibReniec.Info.Resul.ErrorCapcha
        '            CargarImagen()
        '            Me.LblResul.Text = "Ingrese imagen correctamente"
        '            Exit Select
        '        Case LibReniec.Info.Resul.[Error]
        '            Me.LblResul.Text = "Error Desconocido"
        '            Exit Select
        '    End Select
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub CargarImagen()
        'Try
        '    If myInfo Is Nothing Then
        '        myInfo = New Info_Reniec
        '    End If
        '    Me.pictureCapcha.Image = myInfo.GetCapcha
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub LibReniec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            WebBrowser1.Navigate("https://cel.reniec.gob.pe/valreg/valreg.do?accion=ini")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class