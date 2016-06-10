Imports ReglasNegocio
Imports Entidades


Public Class frmTarifa
    Inherits System.Web.UI.Page
    Dim dtTarifasPEM As DataTable = New DataTable()
    Dim funciones As New MantenimientoWeb
    Private Shared vNuevoEditar As Boolean


#Region "Construir Table Tarifas PEM"
    Private Sub ConstruirTableTarifasPEM()
        dtTarifasPEM.Columns.Add("tarfId", GetType(String))
        dtTarifasPEM.Columns.Add("tarfNombre", GetType(String))
        dtTarifasPEM.Columns.Add("conId", GetType(String))
        dtTarifasPEM.Columns.Add("tarfIni", GetType(Date))
        dtTarifasPEM.Columns.Add("tarfFin", GetType(Date))
        dtTarifasPEM.Columns.Add("tgTipoVehId", GetType(String))
        dtTarifasPEM.Columns.Add("tgInstitucionId", GetType(String))
        dtTarifasPEM.Columns.Add("tgSedeId", GetType(String))
    End Sub
#End Region
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then

                funciones.ActivarBoton(rpDatosTarifa.Controls, MantenimientoWeb.Botones.CancelarNuevo)

                txtCodigo.Enabled = False
                cboTVehiculo.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(103)
                cboTVehiculo.TextField = "TgNombre"
                cboTVehiculo.ValueField = "TgCodigo"
                cboTVehiculo.DataBind()
                cboTVehiculo.SelectedIndex = -1

                cboConcepto.DataSource = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupo(Date.Now.Year, "06")
                cboConcepto.TextField = "ConNombre"
                cboConcepto.ValueField = "ConId"
                cboConcepto.DataBind()
                cboConcepto.SelectedIndex = -1

                ConstruirTableTarifasPEM()

                cboInstitucion.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(82)
                cboInstitucion.TextField = "TgNombre"
                cboInstitucion.ValueField = "TgCodigo"
                cboInstitucion.DataBind()
                cboInstitucion.SelectedIndex = -1

                cboTipoCliente.TextField = "TgNombre"
                cboTipoCliente.ValueField = "TgCodigo"
                cboTipoCliente.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(126)
                cboTipoCliente.DataBind()
                cboTipoCliente.SelectedIndex = -1
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

    Protected Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        Try
            funciones.ActivarBoton(rpDatosTarifa.Controls, MantenimientoWeb.Botones.Nuevo)
            txtCodigo.Text = ReglasWebBL.Instancia.generaCodigoTarifaPEM
            txtCodigo.ReadOnly = True
            dtHFin.ReadOnly = True
            vNuevoEditar = True
            cboInstitucion.Value = "0001"
            cargarSede()
            cboSede.Value = "001"
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub
    Sub cargarSede()
        cboSede.TextField = "TgNombre"
        cboSede.ValueField = "TgCodigo"
        cboSede.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, cboInstitucion.Value)
        cboSede.DataBind()
        cboSede.SelectedIndex = -1
    End Sub
    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
        'VALIDACIONES
        If String.IsNullOrEmpty(cboConcepto.Value) Then
            MensajeScript("Seleccione un Tipo de Concepto")
            cboConcepto.Focus()
            Return
        End If

        If String.IsNullOrEmpty(cboTVehiculo.Value) Then
            MensajeScript("Seleccione un Tipo de Vehiculo")
            cboTVehiculo.Focus()
            Return
        End If

        If String.IsNullOrEmpty(cboInstitucion.Value) Then
            MensajeScript("Seleccione un Instituto")
            cboInstitucion.Focus()
            Return
        End If

        If String.IsNullOrEmpty(cboSede.Value) Then
            MensajeScript("Seleccione una Sede")
            cboSede.Focus()
            Return
        End If


        ' Fin Validacion

        Try
            Dim loTarifasPEM As EETarifasPEM = New EETarifasPEM()


            loTarifasPEM.ConId = cboConcepto.Value
            loTarifasPEM.tgTipoVehId = cboTVehiculo.Value
            loTarifasPEM.tgInstitucionId = cboInstitucion.Value
            loTarifasPEM.tgSedeId = cboSede.Value

            loTarifasPEM.tarfIni = String.Format("{0} {1}", Date.Now.Date.ToShortDateString, dtHInicio.Text)
            loTarifasPEM.tarfFin = String.Format("{0} {1}", Date.Now.Date.ToShortDateString, dtHFin.Text)
            loTarifasPEM.TarfActivo = chbEstadoTarifa.Checked
            loTarifasPEM.AcuPrecio = txtPrecioTarifa.Text
            loTarifasPEM.TarfId = txtCodigo.Text
            loTarifasPEM.TarfNroDias = Convert.ToInt16(spnNroDias.Value)
            loTarifasPEM.TarfNroHoras = Convert.ToInt16(spnNroHoras.Value)
            loTarifasPEM.TgTipoClienteId = cboTipoCliente.Value

            If vNuevoEditar = True Then
                ReglasWebBL.Instancia.guardarTarifasPEM(loTarifasPEM)
            Else
                ReglasWebBL.Instancia.actualizarTarifasPEM(loTarifasPEM)
            End If
            funciones.ActivarBoton(rpDatosTarifa.Controls, MantenimientoWeb.Botones.Guardar)
            btnSaimtBuscar_Click(Nothing, Nothing)
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try

    End Sub

    Protected Sub btnEditar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditar.Click
        LstListado.SelectedIndex = -1
        vNuevoEditar = False
        txtCodigo.ReadOnly = True
        funciones.ActivarBoton(rpDatosTarifa.Controls, MantenimientoWeb.Botones.Editar)

    End Sub

    Protected Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLimpiar.Click
        LstListado.SelectedIndex = -1
        funciones.ActivarBoton(rpDatosTarifa.Controls, MantenimientoWeb.Botones.Nuevo)
    End Sub

    Protected Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        LstListado.SelectedIndex = -1
        funciones.ActivarBoton(rpDatosTarifa.Controls, MantenimientoWeb.Botones.CancelarNuevo)
    End Sub

    Protected Sub btnSaimtBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaimtBuscar.Click

        Dim ListaTarifas As List(Of EETarifasPEM) = ReglasWebBL.Instancia.listarTarifasPEMCriterio(1, txtBuscarSaimt.Text)
        If ListaTarifas IsNot Nothing Then
            LstListado.DataSource = ListaTarifas
            LstListado.ValueField = "TarfId"
            LstListado.TextField = "ConNombre"
            LstListado.DataBind()
        End If
    End Sub

    Protected Sub LstListado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstListado.SelectedIndexChanged
        If LstListado.SelectedItem IsNot Nothing Then
            funciones.ActivarBoton(rpDatosTarifa.Controls, MantenimientoWeb.Botones.ListBoxListado)
            Dim loTarifas As EETarifasPEM = ReglasWebBL.Instancia.listarTarifasPEM_TarfId(LstListado.Value)
            txtCodigo.Text = loTarifas.TarfId
            cboConcepto.Value = loTarifas.ConId
            cboTVehiculo.Value = loTarifas.tgTipoVehId
            cboInstitucion.Value = loTarifas.tgInstitucionId
            cboTipoCliente.Value = loTarifas.TgTipoClienteId
            cargarSede()
            cboSede.Value = loTarifas.tgSedeId
            dtHInicio.Value = loTarifas.tarfIni
            dtHFin.Value = loTarifas.tarfFin
            txtPrecioTarifa.Text = loTarifas.AcuPrecio
            spnNroDias.Value = loTarifas.TarfNroDias
            spnNroHoras.Value = loTarifas.TarfNroHoras
            chbEstadoTarifa.Checked = IIf(loTarifas.TarfActivo Is Nothing, False, loTarifas.TarfActivo)

        End If
    End Sub


    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        LstListado.SelectedIndex = -1
        Try
            ReglasWebBL.Instancia.eliminarTarifasPEM(txtCodigo.Text)
            btnSaimtBuscar_Click(sender, e) 'para realizar la busqueda nuevamente
            funciones.ActivarBoton(rpDatosTarifa.Controls, MantenimientoWeb.Botones.Eliminar)
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub


    Protected Sub cboInstitucion_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboInstitucion.ValueChanged
        cargarSede()
    End Sub

    Protected Sub dtHInicio_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtHInicio.ValueChanged
        dtHFin.Value = DateAdd(DateInterval.Hour, spnNroHoras.Value, dtHInicio.Value)
    End Sub

    Protected Sub spnNroHoras_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spnNroHoras.ValueChanged
        dtHFin.Value = DateAdd(DateInterval.Hour, spnNroHoras.Value, dtHInicio.Value)
    End Sub
End Class