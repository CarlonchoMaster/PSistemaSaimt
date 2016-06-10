Imports ReglasNegocio
Imports Entidades
Imports SaimtControlesWeb
Public Class frmConsultarExpedientesSTD
    Inherits System.Web.UI.Page
    Dim oTable As DataTable = New DataTable()
    Dim oTableDet As DataTable = New DataTable()
    Dim encontrado As Boolean
    Public Property InmId() As String
    Public Property SQlString() As String

    Private Sub ConstruirTable_Detalle()
        oTableDet.Columns.Add("item", GetType(String))
        oTableDet.Columns.Add("movId", GetType(String))
        oTableDet.Columns.Add("movFechaRec", GetType(String))
        oTableDet.Columns.Add("dependencia", GetType(String))
        oTableDet.Columns.Add("persona", GetType(String))
        oTableDet.Columns.Add("personaPara", GetType(String))
        oTableDet.Columns.Add("resultado", GetType(String))
        oTableDet.Columns.Add("movFechaEnv", GetType(String))
        oTableDet.Columns.Add("dependenciaPara", GetType(String))
    End Sub

    Private Sub ConstruirTable()
        oTable.Columns.Add("docId", GetType(String))
        oTable.Columns.Add("nroReg", GetType(String))
        oTable.Columns.Add("parte", GetType(String))
        oTable.Columns.Add("procedimiento", GetType(String))
        oTable.Columns.Add("usuario", GetType(String))
        oTable.Columns.Add("dependencia", GetType(String))
        oTable.Columns.Add("folio", GetType(String))
        oTable.Columns.Add("fecha", GetType(String))
        oTable.Columns.Add("interesado", GetType(String))
        oTable.Columns.Add("derivado", GetType(String))
        oTable.Columns.Add("fechaderivado", GetType(String))
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ConstruirTable()
            ConstruirTable_Detalle()
            cboAño.TextField = "TgNombre"
            cboAño.ValueField = "TgCodigo"
            cboAño.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)
            cboAño.DataBind()
            SaimtASPxRoundPanel2.Visible = False
        End If
    End Sub

    'Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
    '    Dim ListaInmueble As List(Of EEInmueble) = Nothing
    '    Dim loInmueble As New EEInmueble
    '    Dim criterio As String = Nothing
    '    '  criterio = 0 & rbtipodireccion.Value
    '    '  If txtUbicacion.Value = "" Then
    '    ' MensajeBox("Ingrese parte o la dirección del inmueble")
    '    '  txtUbicacion.Focus()
    '    ' Return
    '    'End If
    '    'loInmueble.TgRubroGrupoId = IIf(cboRubroGrupos.Value = 0, Nothing, cboRubroGrupos.Value)
    '    'loInmueble.TgInmEstado = "01"
    '    'loInmueble.OInmDireccion = New EEInmDireccion
    '    'loInmueble.InmUbicacion = IIf(txtUbicacion.Text.Trim = "", Nothing, txtUbicacion.Text.Trim)
    '    'loInmueble.OInmDireccion.UbgId = "13" & "01" & cboDistrito.Value
    '    
    'End Sub


    Public Sub cargarDistrito(ByVal lsUbgDep As String, ByVal lsUbgPro As String)
        'cboDistrito.TextField = "UbgNombre"
        'cboDistrito.ValueField = "UbgDist"
        'cboDistrito.DataSource = MantenimientosBL.Instancia.ubigeoListarDistritoXUbgDepXUbgProv(lsUbgDep, lsUbgPro)
        'cboDistrito.Value = "01"
        'cboDistrito.DataBind()
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



    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        Dim paso As Boolean = True
    
        If txtNroExpediente.Value = "" Then
            lblNroExpediente.ForeColor = Drawing.Color.Red
            paso = False
        Else
            lblNroExpediente.ForeColor = Drawing.Color.Black
        End If
        If cboAño.Value = "" Then
            lblcboAño.ForeColor = Drawing.Color.Red
            paso = False
        Else
            lblcboAño.ForeColor = Drawing.Color.Black
        End If

        If cboDependencia.Value = "" Then
            lblDependencia.ForeColor = Drawing.Color.Red
            paso = False
        Else
            lblDependencia.ForeColor = Drawing.Color.Black
        End If

        If paso = True Then
            Try
                Dim NDocReg As String = String.Empty
                Dim loDatosGenerales As EEDocumentoSTD
                loDatosGenerales = MantenimientosBL.Instancia.documentosSTD_MostrarDatosExpedientexNroExpediente_Anio_Dependencia(txtNroExpediente.Value, cboAño.Value, cboDependencia.Value)

                If loDatosGenerales IsNot Nothing Then
                    lblFechaIngreso.Text = loDatosGenerales.DocFechaIng.ToString.Substring(0, 10)
                    lblInteresado.Text = loDatosGenerales.perNombreOrigen
                    lblDocumento.Text = loDatosGenerales.perDoc
                    lblDireccion.Text = loDatosGenerales.perDireccion
                    lblObservacion.Text = loDatosGenerales.DocComentario
                    NDocReg = loDatosGenerales.DocNReg
                End If


                Dim ListaExpedientes As List(Of EEDocumentoSTD) = Nothing
                If NDocReg <> String.Empty Then
                    ListaExpedientes = MantenimientosBL.Instancia.documentosSTD_MostrarDetalleExpedientexNroReg(NDocReg)
                End If
                ConstruirTable()
                oTable.Clear()
                If ListaExpedientes IsNot Nothing Then
                    For Each frow As EEDocumentoSTD In ListaExpedientes
                        oTable.LoadDataRow(New Object() {frow.DocId, frow.DocNReg, frow.procedimiento, frow.usuario, frow.dependencia, frow.DocNFolio, frow.DocFechaIng.ToString.Substring(0, 10), frow.interesado, frow.derivado, frow.fechaDerivado}, True)
                    Next
                    Session("dtmytable") = oTable
                    Me.encontrado = True
                Else
                    Me.encontrado = False
                End If

                If encontrado = False Then
                    lblResultados.Text = "No se encontraron resultados de Búsqueda"
                    SaimtASPxRoundPanel2.Visible = False
                Else
                    lblResultados.Text = oTable.Rows.Count & " Resultados de Busquedas"
                    SaimtASPxRoundPanel2.Visible = True
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
            SaimtASPxRoundPanel2.Visible = True
        Catch ex As Exception
            MensajeBox(ex.Message)
        End Try
    End Sub

    Protected Sub linkSeleccionMov_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim DocId As String = DirectCast(sender, System.Web.UI.WebControls.LinkButton).CommandArgument
        Dim parte As String = String.Empty
        If Len(DocId) > 6 Then
            parte = DocId.Substring(6)
        End If
        lblResultadoDet.Text = "Resultado de la Parte " & parte

        If DocId <> "" Then
            Dim ListaMovimientos As List(Of EEMovimientoSTD) = Nothing
            If DocId <> String.Empty Then
                ListaMovimientos = MantenimientosBL.Instancia.movimientosSTD_ListarMovimientosxDocId(DocId)
            End If
            ConstruirTable_Detalle()
            oTableDet.Clear()
            Dim encontradoDet As Boolean = False
            If ListaMovimientos IsNot Nothing Then
                Dim c As Integer = ListaMovimientos.Count
                For Each frow As EEMovimientoSTD In ListaMovimientos
                    oTableDet.LoadDataRow(New Object() {c, frow.MovId, frow.MovFechaRec, frow.MovDe, frow.MovPerDe, frow.MovPerPara, frow.TgEstadoMov, frow.MovFechaEnv, frow.MovPara}, True)
                    c = c - 1
                Next
                Session("dtmytableDet") = oTableDet
                encontradoDet = True
            Else
                encontradoDet = False
            End If

            gvResultadoDet.DataSource = oTableDet
            gvResultadoDet.Visible = True
            gvResultadoDet.DataBind()
        End If

    End Sub
End Class