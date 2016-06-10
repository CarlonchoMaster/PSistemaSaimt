Imports Entidades
Imports System.IO
Imports ReglasNegocio
Imports SaimtControles

Public Class frmTransferirAnexos

    Private Sub btnEjecutarTarea_Click(sender As System.Object, e As System.EventArgs) Handles btnEjecutarTarea.Click
        Try
            Dim ListaAnexoSTD As List(Of EEAnexoSTD) = MantenimientosBL.Instancia.anexostdListarXFechaServidor(EEComun.FechaServidor)
            If ListaAnexoSTD IsNot Nothing Then
                Dim rutaDestino As String = "\\server01\d$\BaseDatos\AnexosTramiteSTD\"
                For Each fAnexoSTD As EEAnexoSTD In ListaAnexoSTD
                    Dim archPartes As String() = fAnexoSTD.AneArch.Split("\"c)

                    If Not Directory.Exists(rutaDestino & archPartes(archPartes.Length - 2)) Then
                        Directory.CreateDirectory(rutaDestino & archPartes(archPartes.Length - 2))
                    End If

                    File.Copy(fAnexoSTD.AneArch & fAnexoSTD.AneArchExt, rutaDestino & archPartes(archPartes.Length - 2) & "\" & archPartes(archPartes.Length - 1) & fAnexoSTD.AneArchExt, True)
                Next
                MantenimientosBL.Instancia.anexostdActualizarTransferencia(ListaAnexoSTD)
                SaimtMessageBox.mostrarAlertaInformativa("La Transferencia Se Realizo Correctamente")
            Else
                SaimtMessageBox.mostrarAlertaInformativa("No Se Realizo Ninguna Transferencia")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
End Class