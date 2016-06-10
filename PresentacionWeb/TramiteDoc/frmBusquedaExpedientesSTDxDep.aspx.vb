﻿Imports ReglasNegocio
Imports Entidades
Imports SaimtControlesWeb
Imports DevExpress.Web

Public Class frmBusquedaExpedientesSTDxDep
    Inherits System.Web.UI.Page
    Dim CExpDep_oTable As DataTable = New DataTable()
    Dim encontrado As Boolean
    Public Property InmId() As String
    Public Property SQlString() As String
    Private Sub CExpDep_ConstruirTable()
        CExpDep_oTable.Columns.Add("docId", GetType(String))
        CExpDep_oTable.Columns.Add("expediente", GetType(String))
        '  CExpDep_oTable.Columns.Add("expedienteMpt", GetType(String))
        CExpDep_oTable.Columns.Add("fechaExp", GetType(String))
        CExpDep_oTable.Columns.Add("procedimiento", GetType(String))
        CExpDep_oTable.Columns.Add("tipodoc", GetType(String))
        CExpDep_oTable.Columns.Add("estado", GetType(String))
        CExpDep_oTable.Columns.Add("dias", GetType(String))
        CExpDep_oTable.Columns.Add("interesado", GetType(String))
        CExpDep_oTable.Columns.Add("dependencia", GetType(String))
        CExpDep_oTable.Columns.Add("area", GetType(String))
        CExpDep_oTable.Columns.Add("observacion", GetType(String))
        CExpDep_oTable.Columns.Add("indicador", GetType(String))
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            CExpDep_ConstruirTable()
            CExpDep_cboDependencia.TextField = "TgNombre"
            CExpDep_cboDependencia.ValueField = "TgCodigo"
            CExpDep_cboDependencia.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(82)
            CExpDep_cboDependencia.DataBind()
            'Else
            '    If Session("index") IsNot Nothing Then
            '        CExpDep_cboResultado.SelectedIndex = Session("index")
            '    End If
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

        If CExpDep_cboDependencia.Value Is Nothing Then

            CExpDep_lblDependencia.ForeColor = Drawing.Color.Red
            paso = False
        Else
            CExpDep_lblDependencia.ForeColor = Drawing.Color.Black
        End If

        If CExpDep_FechaInicio.Value Is Nothing Then

            CExpDep_lblFechaInicio.ForeColor = Drawing.Color.Red
            paso = False
        Else
            CExpDep_lblFechaInicio.ForeColor = Drawing.Color.Black
        End If

        If CExpDep_FechaFin.Value Is Nothing Then

            CExpDep_lblFechaFinal.ForeColor = Drawing.Color.Red
            paso = False
        Else
            CExpDep_lblFechaFinal.ForeColor = Drawing.Color.Black
        End If

        Dim resultado As String = String.Empty
        If CExpDep_cboResultado.Value Is Nothing Then
            CExpDep_lblResultados.ForeColor = Drawing.Color.Red
            paso = False
        Else
            CExpDep_lblResultados.ForeColor = Drawing.Color.Black
            If CExpDep_cboResultado.SelectedIndex = 1 Then
                resultado = 1
            End If
        End If
        Dim area As String = String.Empty

        If CExpDep_Eleccion.SelectedIndex <> 0 Then
            If CExpDep_cboArea.Value Is Nothing Then
                CExpDep_lblCboArea.ForeColor = Drawing.Color.Red
                paso = False
            Else
                CExpDep_lblCboArea.ForeColor = Drawing.Color.Black
                area = CExpDep_cboArea.Value
            End If
        End If



        If paso = True Then

            Try
                Dim ListaDocumentos As List(Of EEDocumentoSTD) = Nothing
                ListaDocumentos = MantenimientosBL.Instancia.documentosSTD_ListarConsultaxDependencia(CExpDep_FechaInicio.Value, CExpDep_FechaFin.Value, CExpDep_cboDependencia.Value, area, resultado)

                CExpDep_ConstruirTable()
                CExpDep_oTable.Clear()
                If ListaDocumentos IsNot Nothing Then

                    For Each frow As EEDocumentoSTD In ListaDocumentos
                        CExpDep_oTable.LoadDataRow(New Object() {frow.DocId, frow.DocNRegT, frow.DocFechaDoc.ToString.Substring(0, 10),
                        frow.DocAsunto, frow.TgTDoc, frow.DocEstado, frow.DocDias, frow.perNombreOrigen, CExpDep_cboDependencia.Text, frow.TgArea, frow.DocComentario, frow.indicador}, True)
                    Next
                    Me.encontrado = True
                Else
                    Me.encontrado = False
                End If

                If encontrado = False Then
                    CExpDep_lblResultado.Text = "No se encontraron resultados de Búsqueda"
                Else
                    CExpDep_lblResultado.Text = CExpDep_oTable.Rows.Count & " Resultados de Busquedas"
                End If
                Session("dtmytable") = CExpDep_oTable
                CExpDep_dgvResultado.DataSource = CExpDep_oTable
                CExpDep_dgvResultado.Visible = True
                CExpDep_dgvResultado.DataBind()

            Catch ex As Exception
                MensajeBox(ex.Message)
            End Try

        End If


    End Sub

    Protected Sub gvResultado_PageIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CExpDep_dgvResultado.PageIndexChanged
        Try
            CExpDep_dgvResultado.DataSource = DirectCast(Session("dtmytable"), DataTable)
            CExpDep_dgvResultado.Visible = True
            CExpDep_dgvResultado.DataBind()
        Catch ex As Exception
            MensajeBox(ex.Message)
        End Try
    End Sub

    Protected Sub linkSeleccion_Click(ByVal sender As Object, ByVal e As EventArgs)
        CExpDep_observacion.Text = DirectCast(sender, System.Web.UI.WebControls.LinkButton).CommandArgument
    End Sub


    Public Sub CargarCExpDep_Eleccion(ByVal eleccion As String)
        If eleccion = 0 Then
            CExpDep_cboArea.Enabled = False
        Else
            CExpDep_cboArea.Enabled = True
        End If
    End Sub

    'Private Sub CExpDep_cboDependencia_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase) Handles CExpDep_cboDependencia.Callback
    '    CargarCExpDep_cboArea(e.Parameter)
    'End Sub



    'Protected Sub CExpDep_Eleccion_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CExpDep_Eleccion.SelectedIndexChanged

    'End Sub

    Protected Sub CExpDep_cboDependencia_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CExpDep_cboDependencia.SelectedIndexChanged
        If CExpDep_cboDependencia.Value IsNot Nothing Then
            CExpDep_cboArea.TextField = "TgNombre"
            CExpDep_cboArea.ValueField = "TgCodigo"
            CExpDep_cboArea.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(83, CExpDep_cboDependencia.Value)
            CExpDep_cboArea.DataBind()
            ' CExpDep_Eleccion_SelectedIndexChanged(Nothing, Nothing)
        End If

    End Sub



    Protected Sub CExpDep_Eleccion_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CExpDep_Eleccion.ValueChanged
        If CExpDep_Eleccion.SelectedItem.Value = 0 Then
            CExpDep_cboArea.Enabled = False
        Else
            CExpDep_cboArea.Enabled = True
        End If
    End Sub

    'Protected Sub CExpDep_dgvResultado_RowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)


    'End Sub

    Protected Sub CExpDep_dgvResultado_HtmlRowPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles CExpDep_dgvResultado.HtmlRowPrepared

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