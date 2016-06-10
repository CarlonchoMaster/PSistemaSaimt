Imports SaimtControles
Imports Entidades
Imports ReglasNegocio

Public Class frmGrupoFormulario

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If lstGrupoFormulario.SelectedItem IsNot Nothing Then
                Dim loGrupoFormularios As EEGrupoFormularios = DirectCast(lstGrupoFormulario.SelectedValue, EEGrupoFormularios)

                txtNombre.Text = loGrupoFormularios.GrfNombre
                txtDescripcion.Text = loGrupoFormularios.GrfDescripcion

                GIdRegistroActual = loGrupoFormularios.GrfId

                MyBase.seleccionarListado()
            End If
            MyBase.seleccionarListado()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            lstGrupoFormulario.DisplayMember = "GrfNombre"
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = 1
            lstGrupoFormulario.DataSource = MantenimientosBL.Instancia.grupoformulariosListarCriterio(1, txtBuscarPor.Text)
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub listar()
        Try
            lstGrupoFormulario.DisplayMember = "GrfNombre"
            lstGrupoFormulario.DataSource = MantenimientosBL.Instancia.grupoformulariosListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            MyBase.listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            Dim loGrupoFormulario As EEGrupoFormularios = New EEGrupoFormularios()
            loGrupoFormulario.GrfId = Convert.ToInt16(GIdRegistroActual)
            loGrupoFormulario.GrfNombre = txtNombre.Text
            loGrupoFormulario.GrfDescripcion = txtDescripcion.Text

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.grupoformulariosGuardar(loGrupoFormulario)
            Else
                MantenimientosBL.Instancia.grupoformulariosGuardar(loGrupoFormulario)
            End If
            Me.enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub eliminar()
        Try
            MyBase.eliminar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub frmGrupoFormulario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
