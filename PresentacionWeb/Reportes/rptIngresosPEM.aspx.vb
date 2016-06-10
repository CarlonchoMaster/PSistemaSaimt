Imports ReglasNegocio
Imports Entidades
Imports System.Drawing

Public Class rptIngresosPEM
    Inherits System.Web.UI.Page
    Dim funciones As New MantenimientoWeb
    Dim dtPersona As DataTable = New DataTable()

#Region "Construir Table Persona"
    Private Sub ConstruirTable()
        dtPersona.Columns.Add("perId", GetType(String))
        dtPersona.Columns.Add("persona", GetType(String))
        dtPersona.Columns.Add("tipoPersona", GetType(String))
        dtPersona.Columns.Add("tipoDocumento", GetType(String))
        dtPersona.Columns.Add("numeroDocumento", GetType(String))
        dtPersona.Columns.Add("tgInstitucionId", GetType(String))
        dtPersona.Columns.Add("tgSedeId", GetType(String))
    End Sub
#End Region


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                cboInstitucion.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(82)
                cboInstitucion.TextField = "TgNombre"
                cboInstitucion.ValueField = "TgCodigo"
                cboInstitucion.SelectedIndex = -1
                cboInstitucion.DataBind()

                cboTipoVehiculo.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(103)
                cboTipoVehiculo.TextField = "TgNombre"
                cboTipoVehiculo.ValueField = "TgCodigo"
                cboTipoVehiculo.SelectedIndex = -1
                cboTipoVehiculo.DataBind()

                cboTipoCliente.TextField = "TgNombre"
                cboTipoCliente.ValueField = "TgCodigo"
                cboTipoCliente.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(126)
                cboTipoCliente.DataBind()
                cboTipoCliente.SelectedIndex = -1

                cboTarifa.DataSource = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupo(Date.Now.Year, "06")
                cboTarifa.TextField = "ConNombre"
                cboTarifa.ValueField = "ConId"
                cboTarifa.SelectedIndex = -1
                cboTarifa.DataBind()
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

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        Try
            Dim SQlString As String = String.Empty

            If chkCriterioFechaInicio.Checked Then
                If dtpFechaInicio.Value Is Nothing Then
                    chkCriterioFechaInicio.ForeColor = Color.Red
                Else
                    If dtpFechaInicio.Value.ToString().Length > 0 Then
                        SQlString = String.Format("CONVERT(VARCHAR, diaFIngreso, 103)=SUBSTRING('{0}',1,10) {1} ", dtpFechaInicio.Value, mOrAnd(cboCriterioFechaInicio.Text))
                    End If
                    chkCriterioFechaInicio.ForeColor = Color.Black
                End If
            End If

            If chkCriterioFechaFin.Checked Then
                If dtpFechaFin.Value Is Nothing Then
                    chkCriterioFechaFin.ForeColor = Color.Red
                Else
                    If dtpFechaFin.Value.ToString().Length > 0 Then
                        SQlString = String.Format("CONVERT(VARCHAR, diaFSalida, 103)=SUBSTRING('{0}',1,10) {1} ", dtpFechaFin.Value, mOrAnd(cboCriterioFechaFin.Text))
                    End If
                    chkCriterioFechaFin.ForeColor = Color.Black
                End If
            End If

            If chkCriterioPlacaVehiculo.Checked Then
                If txtPlacaVehiculo.Text Is Nothing Then
                    chkCriterioPlacaVehiculo.ForeColor = Color.Red
                Else
                    If txtPlacaVehiculo.Text.Length > 0 Then
                        SQlString = SQlString & String.Format(" diaNPlaca like '%{0}%' {1} ", txtPlacaVehiculo.Text, mOrAnd(cboCriterioPlacaVehiculo.Text))
                    End If
                    chkCriterioPlacaVehiculo.ForeColor = Color.Black
                End If
            End If

            If chkCriterioTipoVehiculo.Checked Then
                If cboTipoVehiculo.Value Is Nothing Then
                    chkCriterioTipoVehiculo.ForeColor = Color.Red
                Else
                    If cboTipoVehiculo.Value.ToString().Length > 0 Then
                        SQlString = SQlString & String.Format(" tgTipoVehId='{0}' {1} ", cboTipoVehiculo.Value, mOrAnd(cboCriterioTipoVehiculo.Text))
                    End If
                    chkCriterioTipoVehiculo.ForeColor = Color.Black
                End If
            End If

            'If chkEstadoSaneamiento.Checked Then
            '    If cboOYEstadoSaneamiento.SelectedIndex = -1 Then
            '        chkEstadoSaneamiento.ForeColor = Color.Red
            '    Else
            '        If cboOYEstadoSaneamiento.SelectedItem.ToString().Length > 0 Then
            '            SQlString = String.Format(" {0} tgEstSanId='{1}' {2} ", SQlString, cboEstadoSaneamiento.Value, mOrAnd(cboOYEstadoSaneamiento.Text))
            '        End If
            '        chkEstadoSaneamiento.ForeColor = Color.Black
            '    End If
            'End If

            'If chkSituacionLegal.Checked Then
            '    If cboOYSituacionLegal.SelectedIndex = -1 Then
            '        chkSituacionLegal.ForeColor = Color.Red
            '    Else
            '        If cboOYSituacionLegal.SelectedItem.ToString().Length > 0 Then
            '            SQlString = String.Format(" {0} tgInmCondRegId='{1}' {2} ", SQlString, cboSituacionLegal.Value, mOrAnd(cboOYSituacionLegal.Text))
            '        End If
            '        chkSituacionLegal.ForeColor = Color.Black
            '    End If
            'End If

            'If chkNroFile.Checked Then
            '    If txtNroFile.Text Is Nothing Then
            '        chkNroFile.ForeColor = Color.Red
            '    Else
            '        If txtNroFile.Text.Length > 0 Then
            '            SQlString = String.Format(" {0} inmFile like '%{1}%' {2} ", SQlString, txtNroFile.Text, mOrAnd(cboNroFile.Text))
            '        End If
            '        chkNroFile.ForeColor = Color.Black
            '    End If
            'End If


            'If chkNroFileAntiguo.Checked Then
            '    If txtNroFileAntiguo.Text Is Nothing Then
            '        chkNroFileAntiguo.ForeColor = Color.Red
            '    Else
            '        If txtNroFileAntiguo.Text.Length > 0 Then
            '            SQlString = String.Format(" {0} inmFileAnt like '%{1}%' {2} ", SQlString, txtNroFileAntiguo.Text, mOrAnd(cboNroFileAntiguo.Text))
            '        End If
            '        chkNroFileAntiguo.ForeColor = Color.Black
            '    End If
            'End If

            'If chkPartidaElectronica.Checked Then
            '    If txtPartidaElectronica.Text Is Nothing Then
            '        chkPartidaElectronica.ForeColor = Color.Red
            '    Else
            '        If txtPartidaElectronica.Text.Length > 0 Then
            '            SQlString = String.Format(" {0} inmPartidaElec like '%{1}%' ", SQlString, txtPartidaElectronica.Text, mOrAnd(cboPartidaElectronica.Text))
            '        End If
            '        chkPartidaElectronica.ForeColor = Color.Black
            '    End If
            'End If

            'If chkDisponiblidad.Checked Then
            '    SQlString = String.Format(" {0} ISNULL(inmDisponibilidad,0)=1  {1} ", SQlString, mOrAnd(cboDisponiblidad.Text))
            'End If
            Session.Add("sqlIngresosPEM", SQlString)
            dgvIngresosPEM.DataBind()
        Catch ex As Exception
            Dim sbMensaje As StringBuilder = New StringBuilder()
            sbMensaje.Append("<script type='text/javascript'>")
            sbMensaje.AppendFormat("alert('{0}');", ex.Message)
            sbMensaje.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensaje.ToString())
        End Try
    End Sub

    Private Function mOrAnd(ByVal asParametro) As String
        If asParametro.Equals("O") Then
            Return "OR"
        Else
            Return "AND"
        End If
    End Function

    Protected Sub cboInstitucion_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboInstitucion.ValueChanged
        cboSede.TextField = "TgNombre"
        cboSede.ValueField = "TgCodigo"
        cboSede.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, cboInstitucion.Value)
        cboSede.SelectedIndex = -1
        cboSede.DataBind()
    End Sub

    Protected Sub cboTipoVehiculo_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTipoVehiculo.ValueChanged
        cboTarifa.TextField = "ConNombre"
        cboTarifa.ValueField = "TarfId"
        cboTarifa.DataSource = ReglasWebBL.Instancia.listarTarifasPEMCriterio(0, cboTipoVehiculo.Value)
        cboTarifa.SelectedIndex = -1
        cboTarifa.DataBind()
    End Sub

    Public Shared TarfNroDias = 0
    Protected Sub cboTarifa_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTarifa.ValueChanged

        Dim loTarifasPEM As EETarifasPEM = ReglasWebBL.Instancia.listarTarifasPEM_TarfId(cboTarifa.Value)
        If loTarifasPEM IsNot Nothing Then
            'txtPrecio.Text = loTarifasPEM.AcuPrecio
            'dtHInicio.Value = loTarifasPEM.tarfIni
            'dtHFin.Value = loTarifasPEM.tarfFin
            'TarfNroDias = loTarifasPEM.TarfNroDias
        Else

        End If


        'cboTarifa.TextField = "ConNombre"
        ''cboTarifa.ValueField = "TarfId"
        'cboTarifa.DataSource = ReglasWebBL.Instancia.listarTarifasPEMCriterio(0, cboTipoVehiculo.Value)
        'cboTarifa.SelectedIndex = -1
        'cboTarifa.DataBind()
    End Sub
End Class