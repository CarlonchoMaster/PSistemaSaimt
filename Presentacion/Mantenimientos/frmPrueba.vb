Imports Entidades
Imports ReglasNegocio

Public Class frmPrueba
    Inherits frmMantenimientos

    Protected Overrides Sub guardar()
        Dim loPrueba As EEPrueba = New EEPrueba
        loPrueba.PruNombre = txtNombre.Text
        loPrueba.PruDescripcion = txtDescripcion.Text

        If GEstadoNuevo Then
            MantenimientosBL.Instancia.pruebaGuardar(loPrueba)
        Else

        End If

        MyBase.guardar()
    End Sub


    Private Sub frmPrueba_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class