Imports ReglasNegocio
Imports Entidades
Imports SaimtControlesWeb
Imports DevExpress.Web

Public Class frmBusquedaExpedientesSTDxIntAsu
    Inherits System.Web.UI.Page
    Dim CExpInt_oTable As DataTable = New DataTable()
    Dim encontrado As Boolean
    Public Property InmId() As String
    Public Property SQlString() As String
    Private Sub CExpInt_ConstruirTable()
        CExpInt_oTable.Columns.Add("docId", GetType(String))
        CExpInt_oTable.Columns.Add("expediente", GetType(String))
        ' CExpInt_oTable.Columns.Add("expedienteMpt", GetType(String))
        CExpInt_oTable.Columns.Add("fechaExp", GetType(String))
        CExpInt_oTable.Columns.Add("procedimiento", GetType(String))
        CExpInt_oTable.Columns.Add("tipodoc", GetType(String))
        CExpInt_oTable.Columns.Add("estado", GetType(String))
        CExpInt_oTable.Columns.Add("dias", GetType(String))
        CExpInt_oTable.Columns.Add("interesado", GetType(String))
        CExpInt_oTable.Columns.Add("dependencia", GetType(String))
        CExpInt_oTable.Columns.Add("area", GetType(String))
        CExpInt_oTable.Columns.Add("observacion", GetType(String))
        CExpInt_oTable.Columns.Add("indicador", GetType(String))
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            CExpInt_ConstruirTable()
            CExpInt_Procedimiento.TextField = "ProcNombre"
            CExpInt_Procedimiento.ValueField = "ProcId"
            CExpInt_Procedimiento.DataSource = MantenimientosBL.Instancia.procedimientostdListarALL()
            CExpInt_Procedimiento.DataBind()
            CExpInt_Procedimiento.Visible = False
            CExpInt_lblEleccion.Text = "Asunto"
        End If
    End Sub



    Public Sub MensajeBox(ByVal ex As String)
        Dim sbMensaje As StringBuilder = New StringBuilder()
        sbMensaje.Append("<script type='text/javascript'>")
        sbMensaje.AppendFormat("alert('{0}');", ex)
        sbMensaje.Append("</script>")
        ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensaje.ToString())
    End Sub

    Public Sub MensajeBoxAjax(ByVal ex As String, ByVal elementId As String)
        Dim sbMensaje As StringBuilder = New StringBuilder()
        sbMensaje.Append("<script type='text/javascript'>")
        sbMensaje.AppendFormat("document.getElementById('{0}').innerHTML='{1}'", elementId, ex)
        sbMensaje.Append("</script>")
        ClientScript.RegisterClientScriptBlock(Me.GetType(), elementId, sbMensaje.ToString())
    End Sub



    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        Dim paso As Boolean = True

        If CExpInt_FechaInicio.Value Is Nothing Then

            CExpInt_lblFechaInicio.ForeColor = Drawing.Color.Red
            paso = False
        Else
            CExpInt_lblFechaInicio.ForeColor = Drawing.Color.Black
        End If

        If CExpInt_FechaFin.Value Is Nothing Then

            CExpInt_lblFechaFin.ForeColor = Drawing.Color.Red
            paso = False
        Else
            CExpInt_lblFechaFin.ForeColor = Drawing.Color.Black
        End If
        Dim interesado, asunto, procediento As String

        interesado = String.Empty
        asunto = String.Empty
        procediento = String.Empty
        If CExpInt_Eleccion.SelectedItem.Value = 1 Then
            If CExpInt_Procedimiento.Value Is Nothing Then
                procediento = String.Empty
                CExpInt_lblEleccion.ForeColor = Drawing.Color.Red
                paso = False
            Else
                CExpInt_lblEleccion.ForeColor = Drawing.Color.Black
                procediento = CExpInt_Procedimiento.Value
            End If
        Else
            If CExpInt_AsuOrInt.Value Is Nothing Then
                CExpInt_lblEleccion.ForeColor = Drawing.Color.Red
                paso = False
            Else
                CExpInt_lblEleccion.ForeColor = Drawing.Color.Black
            End If
            interesado = String.Empty
            asunto = String.Empty
            If CExpInt_Eleccion.SelectedItem.Value = 0 Then
                asunto = CExpInt_AsuOrInt.Value

            Else
                interesado = CExpInt_AsuOrInt.Value
            End If
        End If

        If paso = True Then

            Try
                Dim ListaDocumentos As List(Of EEDocumentoSTD) = Nothing
                ListaDocumentos = MantenimientosBL.Instancia.documentosSTD_ListarConsultaxInteresadoProcedimientoAsunto(CExpInt_FechaInicio.Value, CExpInt_FechaFin.Value, interesado, procediento, asunto)

                CExpInt_ConstruirTable()
                CExpint_oTable.Clear()
                If ListaDocumentos IsNot Nothing Then

                    For Each frow As EEDocumentoSTD In ListaDocumentos
                        CExpInt_oTable.LoadDataRow(New Object() {frow.DocId, frow.DocNRegT, frow.DocFechaDoc.ToString.Substring(0, 10),
                        frow.DocAsunto, frow.TgTDoc, frow.DocEstado, frow.DocDias, frow.perNombreOrigen, frow.dependencia, frow.TgArea, frow.DocComentario, frow.indicador}, True)
                    Next
                    Me.encontrado = True
                Else
                    Me.encontrado = False
                End If

                If encontrado = False Then
                    CExpInt_lblResultado.Text = "No se encontraron resultados de Búsqueda"
                Else
                    CExpInt_lblResultado.Text = CExpInt_oTable.Rows.Count & " Resultados de Busquedas"
                End If
                Session("dtmytable") = CExpInt_oTable
                CExpInt_dgvResultado.DataSource = CExpInt_oTable
                CExpInt_dgvResultado.Visible = True
                CExpInt_dgvResultado.DataBind()

            Catch ex As Exception
                MensajeBox(ex.Message)
            End Try


        End If

        'Session("dtmytable") = CExpDep_oTable
        'CExpDep_dgvResultado.DataSource = CExpDep_oTable
        'CExpDep_dgvResultado.Visible = True
        'CExpDep_dgvResultado.DataBind()
    End Sub

    Protected Sub gvResultado_PageIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CExpInt_dgvResultado.PageIndexChanged
        Try
            CExpInt_dgvResultado.DataSource = DirectCast(Session("dtmytable"), DataTable)
            CExpInt_dgvResultado.Visible = True
            CExpInt_dgvResultado.DataBind()
        Catch ex As Exception
            MensajeBox(ex.Message)
        End Try
    End Sub

    Protected Sub linkSeleccion_Click(ByVal sender As Object, ByVal e As EventArgs)
        CExpDep_observacion.Text = DirectCast(sender, System.Web.UI.WebControls.LinkButton).CommandArgument
    End Sub

 



    Protected Sub CExpDep_Eleccion_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CExpInt_Eleccion.ValueChanged
        CExpInt_AsuOrInt.Visible = False
        CExpInt_Procedimiento.Visible = False
        If CExpInt_Eleccion.SelectedItem.Value = 1 Then
            CExpInt_Procedimiento.Visible = True

            CExpInt_lblEleccion.Text = "Procedimiento"
        Else
            CExpInt_AsuOrInt.Visible = True
            ' CExpInt_Procedimiento.Properties.DataSource = Nothing
            If CExpInt_Eleccion.SelectedItem.Value = 0 Then
                CExpInt_lblEleccion.Text = "Asunto"
            ElseIf CExpInt_Eleccion.SelectedItem.Value = 2 Then
                CExpInt_lblEleccion.Text = "Interesado"
            Else
                CExpInt_lblEleccion.Text = "Asunto"
            End If

        End If


    End Sub

    'Protected Sub CExpDep_dgvResultado_RowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)


    'End Sub

    Protected Sub CExpDep_dgvResultado_HtmlRowPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles CExpInt_dgvResultado.HtmlRowPrepared

        If e.RowType <> GridViewRowType.Data Then
            Return
        End If

        Dim CellValue As Integer = Convert.ToInt32(e.GetValue("indicador"))
        If CellValue = 1 Then
            e.Row.BackColor = Drawing.Color.FromArgb(196, 189, 151)
        ElseIf CellValue = 2 Then
            e.Row.BackColor = Drawing.Color.FromArgb(255, 255, 153)
        Else
            e.Row.BackColor = Drawing.Color.FromArgb(196, 215, 155)
        End If

    End Sub

 
End Class