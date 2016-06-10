Imports Entidades
Imports ReglasNegocio

Public Class frmExtorno
    Inherits System.Web.UI.Page
    Dim funciones As New MantenimientoWeb
    Private Shared dtTablaTicket As DataTable = New DataTable

#Region "Construir Table Contacto"
    Private Sub ConstruirTable()
        dtTablaTicket.Columns.Add("diarioId", GetType(String))
        dtTablaTicket.Columns.Add("diaFIngreso", GetType(String))
    End Sub
#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then

                dtTablaTicket.Columns.Clear()
                ConstruirTable()
                dgvDatosTicket.DataSource = dtTablaTicket
                dgvDatosTicket.DataBind()

                rblBuscar.SelectedIndex = 2
                funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Load)
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
        'If txtBuscarSaimt.Text <> "" Then
        '    LstListado.Items.Clear()
        '    Dim ListaPersonas As List(Of EEDiarioPEM) = ReglasWebBL.Instancia.diariopemConsultarX_Estacionamiento(rblBuscar.Value, txtBuscarSaimt.Text)
        '    If ListaPersonas IsNot Nothing Then
        '        LstListado.ValueField = "DiarioId"
        '        LstListado.TextField = "DiaNPlaca"
        '        LstListado.DataSource = ListaPersonas
        '        LstListado.DataBind()
        '    End If
        'End If
    End Sub

    Protected Sub LstListado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstListado.SelectedIndexChanged
        'If LstListado.SelectedItem IsNot Nothing Then
        '    funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.ListBoxListado)
        '    Dim loDiario As List(Of EEDiarioPEM) = ReglasWebBL.Instancia.diariopemConsultarX_Estacionamiento(3, LstListado.Value)
        '    'MantenimientosBL.Instancia.listarPersona_PerId(LstListado.Value)
        '    txtDiarioId.Text = LstListado.Value
        '    dtTablaTicket.Rows.Clear()
        '    If loDiario IsNot Nothing Then
        '        For Each frow As EEDiarioPEM In loDiario
        '            dtTablaTicket.LoadDataRow(New Object() {frow.DiarioId, frow.DiaFIngreso}, True)
        '        Next
        '    End If
        '    dgvDatosTicket.DataSource = dtTablaTicket
        '    dgvDatosTicket.DataBind()
        'End If
    End Sub

    Protected Sub btnExtornar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExtornar.Click
        'If ReglasWebBL.Instancia.diariopemExtornar(txtDiarioId.Text) Then
        '    MensajeScript("El Extorno se hizo correctamente")
        'End If
    End Sub
End Class