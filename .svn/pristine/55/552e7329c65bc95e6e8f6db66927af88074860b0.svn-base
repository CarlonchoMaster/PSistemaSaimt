Imports ReglasNegocio
Imports Entidades
Imports SaimtControlesWeb
Public Class frmBusquedaXUbicacion
    Inherits System.Web.UI.Page
    Dim oTable As DataTable = New DataTable()
    Dim oTableGRubros As DataTable = New DataTable()
    Dim oTableRubros As DataTable = New DataTable()
    Dim encontrado As Boolean
    Public Property InmId() As String
    Public Property SQlString() As String
    Private Sub ConstruirTable()
        oTable.Columns.Add("inmId", GetType(String))
        oTable.Columns.Add("inmFile", GetType(String))
        oTable.Columns.Add("inmUbicacion", GetType(String))
        oTable.Columns.Add("Detalle", GetType(String))
    End Sub

    Private Sub ConstruirTableGRubros()
        oTableGRubros.Columns.Add("TgCodigo", GetType(String))
        oTableGRubros.Columns.Add("TgNombre", GetType(String))
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ConstruirTableGRubros()
            ConstruirTable()
            Dim loTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(32)
            If loTablaGeneral IsNot Nothing Then
                oTableGRubros.LoadDataRow(New Object() {0, "Todos los Rubros"}, True)
                For Each frow In loTablaGeneral
                    oTableGRubros.LoadDataRow(New Object() {frow.TgCodigo, frow.TgNombre}, True)
                Next
                cboRubroGrupos.TextField = "TgNombre"
                cboRubroGrupos.ValueField = "TgCodigo"
                cboRubroGrupos.DataSource = oTableGRubros
                cboRubroGrupos.DataBind()
                If Request.QueryString("grubro") IsNot Nothing Then
                    cboRubroGrupos.Value = Request.QueryString("grubro")
                End If
            End If

            txtDepartamento.ReadOnly = True
            txtProvincia.ReadOnly = True
            cargarDistrito("13", "01")
        End If
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As New EEInmueble
        Dim criterio As String = Nothing
        '  criterio = 0 & rbtipodireccion.Value
        If txtUbicacion.Value = "" Then
            MensajeBox("Ingrese parte o la dirección del inmueble")
            txtUbicacion.Focus()
            Return
        End If
        loInmueble.TgRubroGrupoId = IIf(cboRubroGrupos.Value = 0, Nothing, cboRubroGrupos.Value)
        loInmueble.TgInmEstado = "01"
        loInmueble.OInmDireccion = New EEInmDireccion
        loInmueble.InmUbicacion = IIf(txtUbicacion.Text.Trim = "", Nothing, txtUbicacion.Text.Trim)
        loInmueble.OInmDireccion.UbgId = "13" & "01" & cboDistrito.Value
        ListaInmueble = MantenimientosBL.Instancia.inmuebleListarConsultaWebCriterios(loInmueble)
        Try
            ConstruirTable()
            oTable.Clear()
            If ListaInmueble IsNot Nothing Then
                For Each fInmueble As EEInmueble In ListaInmueble
                    oTable.LoadDataRow(New Object() {fInmueble.InmId, fInmueble.InmFile,
                    fInmueble.InmUbicacion, _
                    ""}, True)
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
    End Sub


    Public Sub cargarDistrito(ByVal lsUbgDep As String, ByVal lsUbgPro As String)
        cboDistrito.TextField = "UbgNombre"
        cboDistrito.ValueField = "UbgDist"
        cboDistrito.DataSource = MantenimientosBL.Instancia.ubigeoListarDistritoXUbgDepXUbgProv(lsUbgDep, lsUbgPro)
        cboDistrito.Value = "01"
        cboDistrito.DataBind()
    End Sub

    Public Sub MensajeBox(ByVal ex As String)
        Dim sbMensaje As StringBuilder = New StringBuilder()
        sbMensaje.Append("<script type='text/javascript'>")
        sbMensaje.AppendFormat("alert('{0}');", ex)
        sbMensaje.Append("</script>")
        ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensaje.ToString())
    End Sub

    'Protected Sub cboRubroGrupos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboRubroGrupos.SelectedIndexChanged
    '    Dim lsTgcodigo As String = cboRubroGrupos.Value
    '    Dim loTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(33, lsTgcodigo)
    '    oTableRubros.Clear()
    '    If loTablaGeneral IsNot Nothing Then
    '        oTableRubros.LoadDataRow(New Object() {0, "Todos los Rubros " & cboRubroGrupos.Text}, True)
    '        For Each frow In loTablaGeneral
    '            oTableRubros.LoadDataRow(New Object() {frow.TgCodigo, frow.TgNombre}, True)
    '        Next
    '    End If
    'End Sub

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