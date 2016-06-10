Imports DevExpress.XtraEditors

Public Class SaimtMessageBox
    Public Shared Sub mostrarAlertaAdvertencia(ByVal asMensaje As [String])
        XtraMessageBox.Show(asMensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Shared Sub mostrarAlertaError(ByVal asMensaje As [String])
        XtraMessageBox.Show(asMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
    End Sub

    Public Shared Sub mostrarAlertaInformativa(ByVal asMensaje As [String])
        XtraMessageBox.Show(asMensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Shared Function mostrarAlertaPreguntaYESNO(ByVal asMensaje As [String]) As [Boolean]
        Select Case XtraMessageBox.Show(asMensaje, "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case System.Windows.Forms.DialogResult.Yes
                Return True
            Case System.Windows.Forms.DialogResult.No
                Return False
        End Select
        Return False
    End Function

    Public Shared Function mostrarAlertaPregunta(ByVal asMensaje As [String]) As [Boolean]
        Select Case XtraMessageBox.Show(asMensaje, "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            Case System.Windows.Forms.DialogResult.OK
                Return True
            Case System.Windows.Forms.DialogResult.Cancel
                Return False
        End Select
        Return False
    End Function

    ''' <summary>
    ''' Mostrar Alerta con Mensaje y Cabezera Personalizado
    ''' </summary>
    ''' <param name="asMensaje">Mensaje que se va Mostrar</param>
    ''' <param name="asMensajeCabezera">Mensaje que se mostrara en la parte Superior</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function mostrarAlertaPregunta(ByVal asMensaje As [String], ByVal asMensajeCabezera As String) As [Boolean]
        Select Case XtraMessageBox.Show(asMensaje, asMensajeCabezera, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            Case System.Windows.Forms.DialogResult.OK
                Return True
            Case System.Windows.Forms.DialogResult.Cancel
                Return False
        End Select
        Return False
    End Function
End Class
