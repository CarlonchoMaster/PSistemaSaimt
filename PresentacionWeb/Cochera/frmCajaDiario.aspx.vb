Imports Entidades
Imports ReglasNegocio

Public Class frmCajaDiario
    Inherits System.Web.UI.Page

    Private Shared DiarioId As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnConfirmarSalida.Enabled = False
        lblMensajeAcuerdo.Visible = False
        rpnInfEntradaSalida.Visible = False
    End Sub

    'Protected Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
    '    Try
    '        Dim loDiarioPEM As EEDiarioPEM = ReglasWebBL.Instancia.diariopemConsultarXNPlaca_Estacionamiento(txtPlacaVehiculo.Text)
    '        If loDiarioPEM IsNot Nothing Then
    '            If loDiarioPEM.PersonaNombres <> "" Then
    '                lblMensajeAcuerdo.Text = loDiarioPEM.PersonaNombres & " le quedan " & loDiarioPEM.DiasFaltaAcuerdo & " Dias y " & loDiarioPEM.HorasFaltaAcuerdo & " Horas para cumplir el Acuerdo"
    '                lblMensajeAcuerdo.Visible = True
    '            Else
    '                lblMensajeAcuerdo.Visible = False
    '            End If

    '            DiarioId = loDiarioPEM.DiarioId
    '            txtHoraIngreso.Text = loDiarioPEM.DiaHIngreso.Value.ToString("hh:mm:ss tt")
    '            txtHoraSalida.Text = DateTime.Now.ToString("hh:mm:ss tt")
    '            btnConfirmarSalida.Enabled = True

    '            Dim liMinutos As Decimal = DateDiff(DateInterval.Minute, Convert.ToDateTime(txtHoraIngreso.Text), Convert.ToDateTime(txtHoraSalida.Text)).ToString()
    '            Dim liHoras As Decimal = DateDiff(DateInterval.Hour, Convert.ToDateTime(txtHoraIngreso.Text), Convert.ToDateTime(txtHoraSalida.Text)).ToString()

    '            txtTiempoTranscurrido.Text = liMinutos & " minutos"
    '            txtHorasContabilizadas.Text = liHoras & " horas"

    '            If liHoras < 0 Then
    '                If liMinutos > 5 Then
    '                    txtMontoPagar.Text = "1.50"
    '                Else
    '                    txtMontoPagar.Text = "0.00"
    '                End If
    '            Else
    '                If liMinutos Mod 60 > 0 Then
    '                    liHoras = liHoras + 1
    '                End If

    '                txtMontoPagar.Text = 1.5 * liHoras
    '            End If
    '            rpnInfEntradaSalida.Visible = True
    '        Else
    '            rpnInfEntradaSalida.Visible = False
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Protected Sub btnConfirmarSalida_Click(sender As Object, e As EventArgs) Handles btnConfirmarSalida.Click
        Try
            Dim loDiarioPEM As EEDiarioPEM = New EEDiarioPEM()

            loDiarioPEM.DiarioId = DiarioId
            loDiarioPEM.DiaPrecio = Convert.ToDecimal(txtMontoPagar.Text)

            '   ReglasWebBL.Instancia.diariopemActualizar(loDiarioPEM)

            lblMensajeExito.Text = "La Salida Se Realizo Corectamente"
            'Create an instance of PrintDocument
            Dim printdoc As New System.Drawing.Printing.PrintDocument()
            ' Set the printer name

            printdoc.PrinterSettings.PrinterName = "EPSON TM-T88IV Receipt"
            ' Handle printing
            AddHandler printdoc.PrintPage, AddressOf Me.printdoc_PrintPage

            ' Print!
            printdoc.Print()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub printdoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Definición de la fte a utilizar.
        Dim printFont1 As System.Drawing.Font = New System.Drawing.Font("Times New Roman", 11, Drawing.FontStyle.Bold)

        ' Dibujar el nombre escrito y que se desea imprimir directamente.
        e.Graphics.DrawString("Servicio de Administracion de Inmuebles", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(5.0F, -5.0F))
        e.Graphics.DrawString("Municipales de Trujillo", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(59.0F, 11.0F))
        e.Graphics.DrawString("Cliente - Hora Salida : " & DateTime.Now.ToString("hh:mm:ss tt"), printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(30.0F, 30.0F))

        'Definición de la fte a utilizar.
        Dim printFont As System.Drawing.Font = New System.Drawing.Font("Free 3 of 9 Extended", 25)

        ' Dibujar el nombre escrito y que se desea imprimir directamente.
        e.Graphics.DrawString("*" & txtPlacaVehiculo.Text.ToUpper() & "*", printFont, System.Drawing.Brushes.Black, New System.Drawing.PointF(70.0F, 50.0F))

        e.Graphics.DrawString("Monto : S/. " & txtMontoPagar.Text, printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(25.0F, 82.0F))
    End Sub
End Class