Imports ReglasNegocio
Imports Entidades
Imports SaimtControlesWeb
Public Class frmBusquedaExpedientesSTD
    Inherits System.Web.UI.Page
    Dim oTable As DataTable = New DataTable()
    Dim ListaDocumentos As List(Of EEDocumentoSTD)
    Dim encontrado As Boolean
    Public Property InmId() As String
    Public Property SQlString() As String
    Private Sub ConstruirTable()
        oTable.Columns.Add("docId", GetType(String))
        oTable.Columns.Add("expediente", GetType(String))
        'oTable.Columns.Add("expedienteMpt", GetType(String))
        oTable.Columns.Add("fechaExp", GetType(String))
        oTable.Columns.Add("procedimiento", GetType(String))
        oTable.Columns.Add("interesado", GetType(String))
        oTable.Columns.Add("dependencia", GetType(String))
        oTable.Columns.Add("area", GetType(String))
        oTable.Columns.Add("observacion", GetType(String))
    End Sub
 

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ConstruirTable()
            cboCampo.TextField = "TgNombre"
            cboCampo.ValueField = "TgCodigo"
            cboCampo.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(196)
            cboCampo.DataBind()
            ' cargarDistrito("13", "01")
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
        If dtFechaInicio.Value Is Nothing Then

            lbldtFechaInicio.ForeColor = Drawing.Color.Red
            paso = False
        Else
            lbldtFechaInicio.ForeColor = Drawing.Color.Black
        End If
        If dtFechaFin.Value Is Nothing Then
            lbldtFechaFin.ForeColor = Drawing.Color.Red
            paso = False
        Else
            lbldtFechaFin.ForeColor = Drawing.Color.Black
        End If
        If cboCampo.Value = "" Then
            lblcboCampo.ForeColor = Drawing.Color.Red
            paso = False
        Else
            lblcboCampo.ForeColor = Drawing.Color.Black
        End If
        If cboCriterio.Value = "" Then
            lblcboCriterio.ForeColor = Drawing.Color.Red
            paso = False
        Else
            lblcboCriterio.ForeColor = Drawing.Color.Black
        End If

        If paso = True Then

 
                Try
                ListaDocumentos = MantenimientosBL.Instancia.documentosSTD_ListarConsultaCriterios(dtFechaInicio.Value, dtFechaFin.Value, cboCampo.Value, cboCriterio.Value)

                    ConstruirTable()
                    oTable.Clear()
                    If ListaDocumentos IsNot Nothing Then

                    For Each frow As EEDocumentoSTD In ListaDocumentos
                        oTable.LoadDataRow(New Object() {frow.DocId, frow.DocNRegT, frow.DocFechaDoc.ToString.Substring(0, 10),
                        frow.DocAsunto, frow.perNombreOrigen, frow.dependencia, frow.TgArea, frow.DocComentario}, True)
                    Next
                        Session("dtmytable") = oTable
                        Me.encontrado = True
                    Else
                        Me.encontrado = False
                    End If

                    If encontrado = False Then
                        lblResultados.Text = "No se encontraron resultados de Búsqueda"
                    Else
                        lblResultados.Text = oTable.Rows.Count & " Resultados de Busquedas"
                    End If
                    gvResultado.DataSource = oTable
                    gvResultado.Visible = True
                    gvResultado.DataBind()

                Catch ex As Exception
                    MensajeBox(ex.Message)
                End Try

    
        End If
    End Sub

    Protected Sub gvResultado_PageIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gvResultado.PageIndexChanged
        Try
            gvResultado.DataSource = DirectCast(Session("dtmytable"), DataTable)
            gvResultado.Visible = True
            gvResultado.DataBind()
        Catch ex As Exception
            MensajeBox(ex.Message)
        End Try
    End Sub
End Class