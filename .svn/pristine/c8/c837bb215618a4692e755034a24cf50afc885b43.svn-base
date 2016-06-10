Imports Entidades
Imports ReglasNegocio

Public Class Vehiculo
    Inherits System.Web.UI.Page
    Dim funciones As New MantenimientoWeb
    Private Shared dtTablaVehiculo As DataTable = New DataTable
    Private Shared dtTablaDetVehiculo As DataTable = New DataTable
    Private Shared idVehiculo As String


#Region "Construir Table Persona"
    Private Sub ConstruirTablaVehiculo()
        dtTablaVehiculo.Columns.Add("tgTipoVeh", GetType(String))
        dtTablaVehiculo.Columns.Add("AcuNPlaca", GetType(String))
    End Sub

    Private Sub ConstruirTablaDetVehiculo()
        dtTablaDetVehiculo.Columns.Add("tgCaracVehId", GetType(String))
        dtTablaDetVehiculo.Columns.Add("tgCaracVeh", GetType(String))
        dtTablaDetVehiculo.Columns.Add("VehDetCarac", GetType(String))
    End Sub
#End Region
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then

                dtTablaVehiculo.Columns.Clear()
                ConstruirTablaVehiculo()
                dgvDatosPersona.DataSource = dtTablaVehiculo
                dgvDatosPersona.DataBind()
                dtTablaDetVehiculo.Columns.Clear()
                ConstruirTablaDetVehiculo()
                cboCaracteristica.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(104)
                cboCaracteristica.TextField = "TgNombre"
                cboCaracteristica.ValueField = "TgCodigo"
                cboCaracteristica.SelectedIndex = -1
                cboCaracteristica.DataBind()
                rblBuscar.SelectedIndex = 0
                funciones.ActivarBoton(rpDatosVehiculo.Controls, MantenimientoWeb.Botones.Load)
            End If


        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub

    Public Sub MensajeScript(ByVal asMensaje)
        Dim sbMensaje As StringBuilder = New StringBuilder()
        sbMensaje.Append("<script type='text/javascript'>")
        sbMensaje.AppendFormat("alert('{0}');", asMensaje)
        sbMensaje.Append("</script>")
        ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensaje.ToString())
    End Sub
  
    Protected Sub btnSaimtBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaimtBuscar.Click
        Dim ListaAcuerdo As List(Of EEPersona) = MantenimientosBL.Instancia.ConsultarPerVehiculoPEMCriterio(rblBuscar.Value, txtBuscarSaimt.Text)
        LstListado.Items.Clear()
        If ListaAcuerdo IsNot Nothing Then
            LstListado.DataSource = ListaAcuerdo
            LstListado.ValueField = "PerId"
            LstListado.TextField = "Persona"
            LstListado.DataBind()
            LstListado.SelectedIndex = -1
        End If
    End Sub

    Protected Sub LstListado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstListado.SelectedIndexChanged
        If LstListado.SelectedItem IsNot Nothing Then
            funciones.ActivarBoton(rpDatosVehiculo.Controls, MantenimientoWeb.Botones.ListBoxListado)
            Dim loAcuerdoPEM As List(Of EEAcuerdoPEM) = ReglasWebBL.Instancia.listarAcuerdoPEMCriterio(4, LstListado.Value)
            txtCliente.Text = LstListado.SelectedItem.Text
            dtTablaVehiculo.Rows.Clear()
            For Each fAcuerdo As EEAcuerdoPEM In loAcuerdoPEM
                'dtTablaVehiculo.LoadDataRow(New Object() {fAcuerdo.tgTipoVeh, fAcuerdo.AcuNPlaca}, True)
            Next
            dgvDatosPersona.DataSource = dtTablaVehiculo
            dgvDatosPersona.DataBind()
        End If
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs)
        'If idVehiculo Is Nothing Then
        '    idVehiculo = DirectCast(sender, System.Web.UI.WebControls.LinkButton).Text
        '    Dim loDetVehiculo As List(Of EEVehiculoDetPEM) = ReglasWebBL.Instancia.vehiculodetpemListarCriterio(1, idVehiculo)
        '    dtTablaDetVehiculo.Rows.Clear()
        '    If loDetVehiculo IsNot Nothing Then
        '        For Each fdetVehiculo As EEVehiculoDetPEM In loDetVehiculo
        '            dtTablaDetVehiculo.LoadDataRow(New Object() {fdetVehiculo.TgCaracVehId, fdetVehiculo.TgCaracVeh, fdetVehiculo.VehDetCarac}, True)
        '        Next
        '        dgvDatosDetvehiculo.DataSource = dtTablaDetVehiculo
        '    End If
        '    dgvDatosDetvehiculo.DataBind()
        'End If

        'If idVehiculo <> DirectCast(sender, System.Web.UI.WebControls.LinkButton).Text Then
        '    idVehiculo = DirectCast(sender, System.Web.UI.WebControls.LinkButton).Text
        '    Dim loDetVehiculo As List(Of EEVehiculoDetPEM) = ReglasWebBL.Instancia.vehiculodetpemListarCriterio(1, idVehiculo)
        '    dtTablaDetVehiculo.Rows.Clear()
        '    If loDetVehiculo IsNot Nothing Then
        '        For Each fdetVehiculo As EEVehiculoDetPEM In loDetVehiculo
        '            dtTablaDetVehiculo.LoadDataRow(New Object() {fdetVehiculo.TgCaracVehId, fdetVehiculo.TgCaracVeh, fdetVehiculo.VehDetCarac}, True)
        '        Next
        '        dgvDatosDetvehiculo.DataSource = dtTablaDetVehiculo
        '    End If
        '    dgvDatosDetvehiculo.DataBind()
        'End If

        'txtNPlaca.Text = idVehiculo
    End Sub

    Protected Sub btnAddCaracterisca_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddCaracterisca.Click
        Try
            For Each fTablaGeneral As DataRow In dtTablaDetVehiculo.Rows
                If (fTablaGeneral("tgCaracVehId") = cboCaracteristica.Value) Then
                    MensajeScript("Ya se encuentra Agregado " & txtDescripcion.Text)
                    Return

                End If
            Next
            dtTablaDetVehiculo.LoadDataRow(New Object() {cboCaracteristica.Value, cboCaracteristica.Text, txtDescripcion.Text}, True)
            dgvDatosDetvehiculo.DataSource = dtTablaDetVehiculo
            dgvDatosDetvehiculo.DataBind()
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub

    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
        'Try
        '    Dim loDetVehiculo As EEVehiculoDetPEM = New EEVehiculoDetPEM
        '    ReglasWebBL.Instancia.vehiculodetpemEliminar(idVehiculo)
        '    For Each fTablaDetVehiculo As DataRow In dtTablaDetVehiculo.Rows
        '        loDetVehiculo.VehNPlaca = txtNPlaca.Text
        '        loDetVehiculo.TgCaracVehId = fTablaDetVehiculo("tgCaracVehId")
        '        loDetVehiculo.VehDetCarac = fTablaDetVehiculo("VehDetCarac")
        '        loDetVehiculo.VehDetActivo = True
        '        ReglasWebBL.Instancia.vehiculodetpemGuardar(loDetVehiculo)
        '    Next
        '    funciones.ActivarBoton(rpDatosVehiculo.Controls, MantenimientoWeb.Botones.Guardar)
        'Catch ex As Exception
        '    MensajeScript(ex.Message)
        'End Try
    End Sub

    Protected Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        funciones.ActivarBoton(rpDatosVehiculo.Controls, MantenimientoWeb.Botones.Editar)
        txtDescripcion.Text = ""
        cboCaracteristica.SelectedIndex = 0
    End Sub

    Protected Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            If Me.dgvDatosDetvehiculo.VisibleRowCount <> 0 Then
                dtTablaDetVehiculo.Rows.RemoveAt(Me.dgvDatosDetvehiculo.FocusedRowIndex)
            Else
                MensajeScript("No Hay Ninguna Fila Seleccionada")
            End If

            dgvDatosDetvehiculo.DataSource = dtTablaDetVehiculo
            dgvDatosDetvehiculo.DataBind()
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub


    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        funciones.ActivarBoton(rpDatosVehiculo.Controls, MantenimientoWeb.Botones.CancelarEditar)
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        funciones.ActivarBoton(rpDatosVehiculo.Controls, MantenimientoWeb.Botones.Eliminar)
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        funciones.ActivarBoton(rpDatosVehiculo.Controls, MantenimientoWeb.Botones.Limpiar)
    End Sub
End Class