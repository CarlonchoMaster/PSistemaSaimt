Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmUnidadMedida
    Inherits frmMantenimientos
    Dim ClaseActual As Integer = 105
    Protected Overrides Sub guardar()
        Try
            Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral
            Dim loClase As EEClase = New EEClase

            If TxtNombre.Text.Length = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nombre de la Unidad de Medida")
                Return
            End If

            If TxtCodigo.Text.Length = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Codigo de la Unidad de Medida")
                Return
            End If

            loTablaGeneral.TgId = GIdRegistroActual
            loTablaGeneral.TgNombre = TxtNombre.Text
            loTablaGeneral.TgCodigo = TxtCodigo.Text
            loTablaGeneral.TgAbrev = txtSiglas.Text
            loTablaGeneral.TgActivo = chkActivo.Checked
            loClase.ClsId = ClaseActual
            loTablaGeneral.OClase = loClase
            Dim Graba As Boolean = False
            If GEstadoNuevo Then
                If MantenimientosBL.Instancia.tablageneralValidaItgCodigo(ClaseActual, loTablaGeneral.TgCodigo) = False Then
                    MantenimientosBL.Instancia.tablageneralinsertar(loTablaGeneral)
                    Graba = True
                End If
            Else
                If MantenimientosBL.Instancia.tablageneralValidaUtgCodigo(ClaseActual, loTablaGeneral.TgId, loTablaGeneral.TgCodigo) = False Then
                    MantenimientosBL.Instancia.tablageneralUpdate(loTablaGeneral)
                    Graba = True
                End If
            End If
            If Graba = False Then
                SaimtMessageBox.mostrarAlertaInformativa("El codigo Ingresado ya se encuentra registrado, Intente Otro")
                Return
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
            lstUM.DisplayMember = "TgNombre"
            lstUM.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(ClaseActual, sRbBuscarPor.EditValue, GValorTextoBuscado)
            MyBase.listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            lstUM.DisplayMember = "TgNombre"
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = 1
            lstUM.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(ClaseActual, sRbBuscarPor.EditValue, txtBuscarPor.Text)
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub seleccionarListado()
        Try
            If lstUM.SelectedItem IsNot Nothing Then

                Dim loTableGeneral As EETablaGeneral = DirectCast(lstUM.SelectedValue, EETablaGeneral)

                TxtNombre.Text = loTableGeneral.TgNombre
                GIdRegistroActual = loTableGeneral.TgId
                txtSiglas.Text = loTableGeneral.TgAbrev
                TxtCodigo.Text = loTableGeneral.TgCodigo
                chkActivo.Checked = loTableGeneral.TgActivo
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        TxtCodigo.Text = MantenimientosBL.Instancia.TablaGeneralNewCodigo(3, ClaseActual)
        TxtCodigo.Properties.ReadOnly = False
        TxtCodigo.Enabled = False
        TxtNombre.Focus()
    End Sub

    Private Sub frmInstitucion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        sRbBuscarPor.SelectedIndex = 0
    End Sub
End Class