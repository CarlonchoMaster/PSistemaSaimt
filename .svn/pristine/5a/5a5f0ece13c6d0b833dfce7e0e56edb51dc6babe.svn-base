Imports Entidades
Imports ReglasNegocio
Imports System.Drawing
Imports SaimtControlesWeb

Public Class frmConsultarXCriterio
    Inherits System.Web.UI.Page
    Dim oTable As DataTable = New DataTable()
    Dim encontrado As Boolean

    Private Sub ConstruirTable()
        oTable.Columns.Add("inmFile", GetType(String))
        oTable.Columns.Add("inmFileAnt", GetType(String))
        oTable.Columns.Add("inmUbicacion", GetType(String))
        oTable.Columns.Add("inmInscrito", GetType(String))
        oTable.Columns.Add("inmDenominacion", GetType(String))
        oTable.Columns.Add("tgInmCondReg", GetType(String))
        oTable.Columns.Add("inmPartidaElec", GetType(String))
        oTable.Columns.Add("tgInmCondLegal", GetType(String))
        oTable.Columns.Add("tgEstSan", GetType(String))
        oTable.Columns.Add("tgInmSitFisica", GetType(String))
        oTable.Columns.Add("tgInmSFUso", GetType(String))
        oTable.Columns.Add("tgEstInmConsv", GetType(String))
        oTable.Columns.Add("inmDisponibilidad", GetType(String))
        oTable.Columns.Add("inmId", GetType(String))
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            cboRubroGrupos.TextField = "TgNombre"
            cboRubroGrupos.ValueField = "TgCodigo"
            cboRubroGrupos.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(32)
            cboRubroGrupos.DataBind()
            cboRubroGrupos.SelectedIndex = 0
            cboRubro.TextField = "TgNombre"
            cboRubro.ValueField = "TgCodigo"
            cboRubro.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(32)
            cboRubro.SelectedIndex = 0
            txtDepartamento.Text = "La Libertad"
            txtDepartamento.ReadOnly = True
            txtProvincia.Text = "Trujillo"
            txtProvincia.ReadOnly = True
            txtDistrito.Text = "Trujillo"
            txtDistrito.ReadOnly = True

            cboSubDistritos.TextField = "TgNombre"
            cboSubDistritos.ValueField = "TgCodigo"
            cboSubDistritos.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(172)
            cboSubDistritos.DataBind()
            cboSubDistritos.SelectedIndex = 0

            If cboSubDistritos.Value IsNot Nothing Then
                txtsubdistritoscbo.TextField = "TgNombre"
                txtsubdistritoscbo.ValueField = "TgCodigo"
                txtsubdistritoscbo.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(171, "01", "01", cboSubDistritos.Value)
                If txtsubdistritoscbo.DataSource IsNot Nothing Then
                    txtsubdistritoscbo.Visible = True
                    txtsubdistritoText.Visible = False
                Else
                    txtsubdistritoscbo.Visible = False
                    txtsubdistritoText.Visible = True
                End If
                txtsubdistritoscbo.DataBind()
            End If

            cboLocalizacion.TextField = "TgNombre"
            cboLocalizacion.ValueField = "TgCodigo"
            cboLocalizacion.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(1)
            cboLocalizacion.DataBind()
            cboLocalizacion.SelectedIndex = 0

            cboTipoNro.TextField = "TgNombre"
            cboTipoNro.ValueField = "TgCodigo"
            cboTipoNro.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(169)
            cboTipoNro.DataBind()
            cboTipoNro.SelectedIndex = 0

            cboTipoSubNro.TextField = "TgNombre"
            cboTipoSubNro.ValueField = "TgCodigo"
            cboTipoSubNro.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(170)
            cboTipoSubNro.DataBind()
            cboTipoSubNro.SelectedIndex = 0

            txtDepartamento.ReadOnly = True
            cboLocalizacion.Value = "00"
            cboTipoNro.Value = "00"
            cboTipoSubNro.Value = "00"
            cboSubDistritos.Value = "00"
        End If
    End Sub

    Protected Sub btnBuscarInmuebles_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscarInmuebles.Click
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As New EEInmueble
        Dim criterio As String = Nothing
        criterio = "01"
        If cboLocalizacion.Value <> "00" And txtLocalizacion.Value = "" Then
            ' SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor para " & cboLocalizacion.Text)
            txtLocalizacion.Focus()
            Return
        End If

        If cboTipoNro.Value <> "00" And txtNroUbicacion.Value = "" Then
            ' SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor en el para " & cboTipoNro.Text)
            txtNroUbicacion.Focus()
            Return
        End If

        If cboTipoSubNro.Value <> "00" And txtSubNro.Value = "" Then
            ' SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor en el para " & cboTipoSubNro.Text)
            txtSubNro.Focus()
            Return
        End If
        loInmueble.TgRubroId = cboRubro.Value
        loInmueble.TgRubroGrupoId = cboRubroGrupos.Value
        loInmueble.TgInmEstado = "01"
        loInmueble.OInmDireccion = New EEInmDireccion
        loInmueble.OInmDireccion.TgLocalizacionId = IIf(cboLocalizacion.Value = "00", Nothing, cboLocalizacion.Value)
        loInmueble.OInmDireccion.InmDirLocalizacion = IIf(txtLocalizacion.Value = "", Nothing, txtLocalizacion.Value)
        loInmueble.OInmDireccion.InmDirAdicional = IIf(txtdireccionAdicional.Text = "", Nothing, txtdireccionAdicional.Text)
        loInmueble.OInmDireccion.TgNroId = IIf(cboTipoNro.Value = "00", Nothing, cboTipoNro.Value)
        loInmueble.OInmDireccion.InmDirNro = IIf(txtNroUbicacion.Value = "", Nothing, txtNroUbicacion.Value)
        loInmueble.OInmDireccion.TgSubNroId = IIf(cboTipoSubNro.Value = "00", Nothing, cboTipoSubNro.Value)
        loInmueble.OInmDireccion.InmDirSubNro = IIf(txtSubNro.Value = "", Nothing, txtSubNro.Value)
        loInmueble.OInmDireccion.InmDirSubDistritos = IIf(IIf(txtsubdistritoscbo.Visible = True, txtsubdistritoscbo.Value, txtsubdistritoText.Value) = "", Nothing, IIf(txtsubdistritoscbo.Visible = True, txtsubdistritoscbo.Value, txtsubdistritoText.Value))
        loInmueble.OInmDireccion.TgSubDistritosId = IIf(cboSubDistritos.Value = "00", Nothing, cboSubDistritos.Value)
        loInmueble.OInmDireccion.InmDirEtapa = IIf(txtEtapa.Value = "", Nothing, txtEtapa.Value)
        loInmueble.OInmDireccion.InmDirFase = IIf(txtFase.Value = "", Nothing, txtFase.Value)
        loInmueble.OInmDireccion.InmDirBarrio = IIf(txtBarrio.Value = "", Nothing, txtBarrio.Value)
        loInmueble.OInmDireccion.InmDirSector = IIf(txtSector.Value = "", Nothing, txtSector.Value)
        loInmueble.OInmDireccion.UbgId = "130101"
        'chekar mañana
        ListaInmueble = MantenimientosBL.Instancia.inmuebleListarConsultaCriteriosWebDireccion(loInmueble)
        Try
            ConstruirTable()
            dvInmuebles.DataSource = oTable
            If ListaInmueble IsNot Nothing Then
                For Each fInmueble As EEInmueble In ListaInmueble
                    'Const lsUbicacion As String = ""
                    oTable.LoadDataRow(New Object() {
                    fInmueble.InmFile, _
                    fInmueble.InmUbicacion, _
                    fInmueble.InmInscrito, _
                    fInmueble.InmDenominacion, _
                    fInmueble.tgInmCondReg, _
                    fInmueble.InmPartidaElec, _
                    fInmueble.TgInmCondLegal, _
                    fInmueble.tgEstSan, _
                    fInmueble.tgInmSitFisica, _
                    fInmueble.tgInmSFUso, _
                    fInmueble.tgEstInmConsv, _
                   IIf(fInmueble.InmDisponibilidad = False, "NO", "SI"), _
                     fInmueble.InmId
                    }, True)
                Next
                ' gvResultado.BestFitColumns()
                encontrado = True
            Else
                encontrado = False
            End If

            If encontrado = False Then
                Dim sbMensaje As StringBuilder = New StringBuilder()
                sbMensaje.Append("<script type='text/javascript'>")
                sbMensaje.AppendFormat("alert('{0}');", "No se encontro resultados")
                sbMensaje.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensaje.ToString())
            End If

            '  Session.Add("SqlWhere", SQlString)
            dvInmuebles.Visible = True
            dvInmuebles.DataBind()
        Catch ex As Exception
            Dim sbMensaje As StringBuilder = New StringBuilder()
            sbMensaje.Append("<script type='text/javascript'>")
            sbMensaje.AppendFormat("alert('{0}');", ex.Message)
            sbMensaje.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensaje.ToString())
        End Try
    End Sub

    Public Sub MensajeBox(ByVal ex As String)
        Dim sbMensaje As StringBuilder = New StringBuilder()
        sbMensaje.Append("<script type='text/javascript'>")
        sbMensaje.AppendFormat("alert('{0}');", ex)
        sbMensaje.Append("</script>")
        ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensaje.ToString())
    End Sub

    Protected Sub cboRubroGrupos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboRubroGrupos.SelectedIndexChanged
        Dim lsTgcodigo As String = cboRubroGrupos.Value
        cboRubro.TextField = "TgNombre"
        cboRubro.ValueField = "TgCodigo"
        cboRubro.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(33, lsTgcodigo)
        cboRubro.DataBind()
    End Sub

    Protected Sub cboSubDistritos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboSubDistritos.SelectedIndexChanged
        If cboSubDistritos.Value IsNot Nothing Then
            ' txtsubdistritoscbo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            txtsubdistritoscbo.TextField = "TgNombre"
            txtsubdistritoscbo.ValueField = "TgCodigo"
            txtsubdistritoscbo.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(171, Nothing, "01", cboSubDistritos.Value)
            If txtsubdistritoscbo.DataSource IsNot Nothing Then
                txtsubdistritoscbo.Visible = True
                txtsubdistritoText.Visible = False
            Else
                txtsubdistritoscbo.Visible = False
                txtsubdistritoText.Visible = True
            End If

        End If
    End Sub
End Class