Imports SaimtControles

Public Class frmCancelacion
    Inherits frmGeneral

    Private _ButtonGuardar As SaimtButton
    Public Property ButtonGuardar() As SaimtButton
        Get
            If _ButtonGuardar IsNot Nothing Then
                _ButtonGuardar.Text = "Guardar"
                _ButtonGuardar.Image = Presentacion.My.Resources.guardar
                mAsignarPosicionImagenBoton(_ButtonGuardar)
            End If
            Return _ButtonGuardar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonGuardar = value
        End Set
    End Property

    Private Sub mAsignarPosicionImagenBoton(ByVal abuButton As SaimtButton)
        abuButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        'abuButton.Width = 64
        'abuButton.Height = 64
    End Sub

    Private Sub frmCancelacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.ButtonGuardar IsNot Nothing Then
            AddHandler Me.ButtonGuardar.Click, AddressOf ButtonGuardar_Click
            ButtonGuardar.Text = "Guardar"
            mGSetearTool(ButtonGuardar, "Guardar", "Guardar nuevo registro y/o cambios efectuados")
        End If
    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Select Case SaimtMessageBox.mostrarAlertaPregunta("Esta Seguro de Realizar la Cancelacion")
            Case System.Windows.Forms.DialogResult.OK
                Me.guardar()
            Case System.Windows.Forms.DialogResult.Cancel
                Exit Select
        End Select
    End Sub

    Protected Overridable Sub guardar()
        SaimtMessageBox.mostrarAlertaInformativa("La Cancelacion Se Ralizo Con Exito")
        Me.Close()
    End Sub
End Class