Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmRequisito
    Inherits frmMantenimientos
    Dim claseRequisitos As Integer = 92

    Protected Overrides Sub guardar()
        Try
            Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral
            Dim loClase As EEClase = New EEClase

            If TxtNombreReq.EditValue.Length = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nombre del Requisito")
                Return
            End If

            loTablaGeneral.TgId = GIdRegistroActual
            loTablaGeneral.TgCodigo = txtcodigoReq.EditValue
            loTablaGeneral.TgNombre = TxtNombreReq.EditValue
            loTablaGeneral.TgDescripcion = TxtDescripcionReq.EditValue
            loTablaGeneral.TgActivo = chkActivo.Checked
            loClase.ClsId = claseRequisitos
            loTablaGeneral.OClase = loClase
            Dim Graba As Boolean = False
            If GEstadoNuevo Then
                If MantenimientosBL.Instancia.tablageneralValidaItgCodigo(claseRequisitos, loTablaGeneral.TgCodigo) = False Then
                    MantenimientosBL.Instancia.tablageneralinsertar(loTablaGeneral)
                    Graba = True
                End If
            Else
                If MantenimientosBL.Instancia.tablageneralValidaUtgCodigo(claseRequisitos, loTablaGeneral.TgId, loTablaGeneral.TgCodigo) = False Then
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
            lstRequisitos.DisplayMember = "TgNombre"
            lstRequisitos.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(claseRequisitos, GCriterioBuscado, GValorTextoBuscado)
            MyBase.listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            lstRequisitos.DisplayMember = "TgNombre"
            GValorTextoBuscado = TxtBuscarPor.Text
            GCriterioBuscado = 1
            lstRequisitos.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(claseRequisitos, 1, TxtBuscarPor.Text)
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub seleccionarListado()
        Try
            If lstRequisitos.SelectedItem IsNot Nothing Then

                Dim loTableGeneral As EETablaGeneral = DirectCast(lstRequisitos.SelectedValue, EETablaGeneral)

                TxtNombreReq.Text = loTableGeneral.TgNombre
                GIdRegistroActual = loTableGeneral.TgId
                TxtDescripcionReq.Text = loTableGeneral.TgDescripcion
                txtcodigoReq.Text = loTableGeneral.TgCodigo
                chkActivo.Checked = loTableGeneral.TgActivo
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtcodigoReq.Text = MantenimientosBL.Instancia.RequisitosNewCodigo()
        txtcodigoReq.Properties.ReadOnly = False
        txtcodigoReq.Enabled = False
    End Sub

    Private Sub frmRequisito_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
    End Sub
End Class