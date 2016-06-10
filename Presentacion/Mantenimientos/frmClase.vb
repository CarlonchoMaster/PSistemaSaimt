Imports Entidades
Imports ReglasNegocio
Imports SaimtControles

Public Class frmClase
    Inherits frmMantenimientos

#Region "Funciones Sobrescritas"
    Protected Overrides Sub guardar()
        Try
            Dim loClase As EEClase = New EEClase
            loClase.ClsId = GIdRegistroActual
            loClase.ClsNombre = txtNombre.Text
            loClase.ClsDescripcion = txtDescripcion.Text

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.claseGuardar(loClase)
            Else
                MantenimientosBL.Instancia.claseActualizar(loClase)
            End If
            Me.enabledGA = False
            MyBase.guardar()
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub listar()
        Try
            lstClase.DisplayMember = "ClsNombre"
            lstClase.DataSource = MantenimientosBL.Instancia.claseListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            MyBase.listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            lstClase.DisplayMember = "ClsNombre"
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = 1
            lstClase.DataSource = MantenimientosBL.Instancia.claseListarCriterio(1, txtBuscarPor.Text)
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub seleccionarListado()
        Try
            If lstClase.SelectedItem IsNot Nothing Then

                Dim loClase As EEClase = DirectCast(lstClase.SelectedValue, EEClase)

                txtNombre.Text = loClase.ClsNombre
                txtDescripcion.Text = loClase.ClsDescripcion

                GIdRegistroActual = loClase.ClsId

                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
    End Sub
#End Region

    Private Sub frmClase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
