Imports Entidades
Imports ReglasNegocio
Imports System.Drawing.Printing

Public Class frmContrato
    Inherits System.Web.UI.Page
    Dim funciones As New MantenimientoWeb
    Private Shared vNuevoEditar As Boolean

    Private lsPerId As String = String.Empty
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
                Me.ddlImpresoras.DataSource = PrinterSettings.InstalledPrinters()
                Me.ddlImpresoras.DataBind()
                Me.ddlImpresoras.SelectedIndex = 0

                btnImprimir.Enabled = False
                btnImprimir2.Enabled = False
                btnImprimir3.Enabled = False


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

                cboNivel.DataSource = ReglasWebBL.Instancia.nivelespemListarCriterio(0, cboNivel.Value)
                cboNivel.TextField = "NivNombre"
                cboNivel.ValueField = "NivId"
                cboNivel.SelectedIndex = -1
                cboNivel.DataBind()
                rblBuscar.SelectedIndex = 0


                cboAcuerdoEstado.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(129)
                cboAcuerdoEstado.TextField = "TgNombre"
                cboAcuerdoEstado.ValueField = "TgCodigo"
                cboAcuerdoEstado.SelectedIndex = -1
                cboAcuerdoEstado.DataBind()
                funciones.ActivarBoton(rpDatosAcuerdo.Controls, MantenimientoWeb.Botones.Load)
            End If

            'If Request.QueryString("idper") IsNot Nothing Then
            '    Session("perid") = Request.QueryString("idper").ToString()
            '    Response.Redirect("frmAcuerdo.aspx")
            'End If

            'If Session("perid") IsNot Nothing Then
            '    Dim loPersona As Entidades.EEPersona = ReglasNegocio.MantenimientosBL.Instancia.listarPersona_PerId(Session("perid").ToString())
            '    txtCliente.Text = loPersona.PerNombres & " " & loPersona.PerApePaterno & " " & loPersona.PerApeMaterno
            '    lsPerId = loPersona.PerId
            '    Session("perid") = Nothing
            'End If
            'dgvResultado.Visible = False
            'ConstruirTable()
            'dgvResultado.DataSource = dtPersona

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
            funciones.ActivarBoton(rpDatosAcuerdo.Controls, MantenimientoWeb.Botones.Nuevo)
            txtCodigo.Text = ReglasWebBL.Instancia.generaCodigoAcuerdoPEM
            txtCodigo.ReadOnly = True
            '
            dtHInicio.ReadOnly = True
            dtHFin.ReadOnly = True
            txtPrecio.ReadOnly = True
            dedFechaFin.ReadOnly = True
            txtEspacioSelec.ReadOnly = True

            vNuevoEditar = True
            txtFechaRegistro.Text = Date.Now
            imgCodBarras1.Visible = False
            imgCodBarras2.Visible = False
            imgCodBarras3.Visible = False
            cboInstitucion.Value = "0001"
            cargarSede()
            cboSede.Value = "001"
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub

    'Protected Sub BuscarPersona_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
    '    Try
    '        dgvResultado.Visible = True
    '        Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaConsultarGeneral(3, txtCliente.Text)
    '        dtPersona.Clear()
    '        If ListaPersona IsNot Nothing Then
    '            For Each fPersona As EEPersona In ListaPersona
    '                dtPersona.LoadDataRow(New Object() {
    '                    fPersona.PerId, _
    '                    fPersona.Persona, _
    '                    fPersona.perTipoPersona, _
    '                    fPersona.TgDocumento, _
    '                    fPersona.PerNDoc
    '                }, True)
    '            Next
    '        End If
    '        dgvResultado.DataSource = dtPersona
    '        dgvResultado.DataBind()
    '    Catch ex As Exception
    '        MensajeScript(ex.Message)
    '    End Try
    'End Sub

    'Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    txtCliente.Text = DirectCast(sender, System.Web.UI.WebControls.LinkButton).Text
    ''    Session("lsPerId") = DirectCast(sender, System.Web.UI.WebControls.LinkButton).CommandArgument
    ''    dgvResultado.Visible = False
    'End Sub

    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
        'VALIDACIONES
        If String.IsNullOrEmpty(txtCliente.Text) Then
            MensajeScript("La Denominacion de Cliente es Obligatorio")
            txtCliente.Focus()
            Return
        End If

        If String.IsNullOrEmpty(txtNumPlaca1.Text) Then
            MensajeScript("Numero de Placa es Obligatorio")
            txtNumPlaca1.Focus()
            Return
        End If

        If String.IsNullOrEmpty(cboTarifa.Value) Then
            MensajeScript("Seleccione una Tarifa")
            cboTarifa.Focus()
            Return
        End If

        If String.IsNullOrEmpty(dedFechaInicio.Text) Then
            MensajeScript("La fecha Inicio es Obligatorio")
            dedFechaInicio.Focus()
            Return
        End If

        If String.IsNullOrEmpty(dedFechaFin.Text) Then
            MensajeScript("La Fecha Fin es Obligatorio")
            dedFechaFin.Focus()
            Return
        End If

        If String.IsNullOrEmpty(dtHInicio.Text) Then
            MensajeScript("La hora de Inicio Obligatorio")
            dtHInicio.Focus()
            Return
        End If

        If String.IsNullOrEmpty(dtHFin.Text) Then
            MensajeScript("La Hora de Fin es Obligatorio")
            dtHFin.Focus()
            Return
        End If

        If String.IsNullOrEmpty(cboTipoVehiculo.Value) Then
            MensajeScript("Seleccione un Tipo de Vehiculo")
            cboTipoVehiculo.Focus()
            Return
        End If

        If String.IsNullOrEmpty(txtPrecio.Text) Then
            MensajeScript("El Precio es Obligatorio")
            txtPrecio.Focus()
            Return
        End If

        If String.IsNullOrEmpty(cboNivel.Value) Then
            MensajeScript("Seleccione una Tarifa")
            cboNivel.Focus()
            Return
        End If

        If String.IsNullOrEmpty(txtEspacioSelec.Text) Then
            MensajeScript("La Hora de Fin es Obligatorio")
            txtEspacioSelec.Focus()
            Return
        End If

        If String.IsNullOrEmpty(txtCodigo.Text) Then
            MensajeScript("El codigo es Obligatorio")
            txtCodigo.Focus()
            Return
        End If

        ' Fin Validacion

        Try
            Dim loAcuerdoPEM As EEAcuerdoPEM = New EEAcuerdoPEM()

            loAcuerdoPEM.tgInstitucionId = cboInstitucion.Value
            loAcuerdoPEM.tgSedeId = cboSede.Value
            loAcuerdoPEM.AcuId = txtCodigo.Text
            loAcuerdoPEM.PerId = txtPerId.Text
            loAcuerdoPEM.TgTipoVehId = cboTipoVehiculo.Value
            loAcuerdoPEM.AcuNPlaca1 = txtNumPlaca1.Text
            loAcuerdoPEM.AcuNPlaca2 = txtNumPlaca2.Text
            loAcuerdoPEM.AcuNPlaca3 = txtNumPlaca3.Text
            loAcuerdoPEM.TarfId = cboTarifa.Value
            loAcuerdoPEM.AcuFechaIni = dedFechaInicio.Date
            loAcuerdoPEM.AcuFechaFin = dedFechaFin.Date
            loAcuerdoPEM.AcuHoIni = Date.Now.Date & " " & dtHInicio.Text
            loAcuerdoPEM.AcuHoFin = Date.Now.Date & " " & dtHFin.Text
            loAcuerdoPEM.AcuPrecio = txtPrecio.Text
            loAcuerdoPEM.NivId = cboNivel.Value
            loAcuerdoPEM.AcuNEspacio = txtEspacioSelec.Text
            loAcuerdoPEM.AcuEstado = cboAcuerdoEstado.SelectedIndex
            If vNuevoEditar = True Then
              
                If CInt(ReglasWebBL.Instancia.AcuerdoPEM_Mostrar_acuEstado_XacuNPlaca_perId_pa(txtNumPlaca1.Text, txtNumPlaca2.Text, txtNumPlaca3.Text, txtPerId.Text)) > 1 And cboAcuerdoEstado.Value = 1 Then
                    MensajeScript("La Placa de Vehiculo ya tienen un Acuerdo activo")
                    Return
                Else
                    ReglasWebBL.Instancia.acuerdopemGuardar(loAcuerdoPEM)
                    'Else
                End If
            Else
                ReglasWebBL.Instancia.acuerdopemActualizar(loAcuerdoPEM)
            End If
            funciones.ActivarBoton(rpDatosAcuerdo.Controls, MantenimientoWeb.Botones.Guardar)
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub

    Protected Sub btnSaimtBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaimtBuscar.Click
        Dim ListaAcuerdo As List(Of EEPersona) = MantenimientosBL.Instancia.ConsultarPerVehiculoPEMCriterio(rblBuscar.Value, txtBuscarSaimt.Text)
        If ListaAcuerdo IsNot Nothing Then
            LstListado.DataSource = ListaAcuerdo
            LstListado.ValueField = "PerId"
            LstListado.TextField = "Persona"
            LstListado.DataBind()
        End If
    End Sub

    Protected Sub LstListado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstListado.SelectedIndexChanged
        If LstListado.SelectedItem IsNot Nothing Then
            'funciones.ActivarBoton(rpDatosAcuerdo.Controls, MantenimientoWeb.Botones.ListBoxListado)
            Dim loAcuerdoPEM As List(Of EEAcuerdoPEM) = ReglasWebBL.Instancia.listarAcuerdoPEMCriterio(4, LstListado.Value)
            If loAcuerdoPEM IsNot Nothing Then
                LstAcuerdos.DataSource = loAcuerdoPEM
                LstAcuerdos.ValueField = "AcuId"
                LstAcuerdos.TextField = "AcuDatos"
                LstAcuerdos.DataBind()
            End If
        End If
    End Sub

    Protected Sub btnEditar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditar.Click
        LstListado.SelectedIndex = -1
        vNuevoEditar = False
        txtCodigo.ReadOnly = True
        funciones.ActivarBoton(rpDatosAcuerdo.Controls, MantenimientoWeb.Botones.Editar)
    End Sub

    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        LstListado.SelectedIndex = -1
        Try

            ReglasWebBL.Instancia.acuerdopemEliminar(txtCodigo.Text)

            'Dim sbMensajeExito As StringBuilder = New StringBuilder()
            'sbMensajeExito.Append("<script type='text/javascript'>")
            'sbMensajeExito.AppendFormat("alert('{0}');", "Las Recaudaciones Se Eliminaron con Exito")
            'sbMensajeExito.Append("</script>")
            'ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensajeExito.ToString())

            funciones.ActivarBoton(rpDatosAcuerdo.Controls, MantenimientoWeb.Botones.Eliminar)
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub


    Protected Sub btnSelecEspacio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelecEspacio.Click
        If cboNivel.Value IsNot Nothing Then
            Dim script As StringBuilder = New StringBuilder()
            script.Append("<script type='text/javascript'>")
            script.AppendFormat(" Abrir_ventana('{0}');", "../Consultas/ConsultarEspaciosXNivel.aspx?NivelId=" + cboNivel.Value + "")
            script.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "PEspacio", script.ToString())
        Else
            MensajeScript("Seleccione el Nivel")
        End If

    End Sub

    Protected Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        LstListado.SelectedIndex = -1
        funciones.ActivarBoton(rpDatosAcuerdo.Controls, MantenimientoWeb.Botones.CancelarNuevo)
    End Sub

    Protected Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLimpiar.Click
        LstListado.SelectedIndex = -1
        funciones.ActivarBoton(rpDatosAcuerdo.Controls, MantenimientoWeb.Botones.Nuevo)
    End Sub

    Protected Sub LstAcuerdos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstAcuerdos.SelectedIndexChanged
        imgCodBarras1.Visible = False
        imgCodBarras2.Visible = False
        imgCodBarras3.Visible = False
        btnImprimir.Enabled = False
        btnImprimir2.Enabled = False
        btnImprimir3.Enabled = False
        txtCodBarras1.Text = String.Empty
        txtCodBarras2.Text = String.Empty
        txtCodBarras3.Text = String.Empty

        If LstAcuerdos.SelectedItem IsNot Nothing Then
            funciones.ActivarBoton(rpDatosAcuerdo.Controls, MantenimientoWeb.Botones.ListBoxListado)
            Dim loAcuerdoPEM As EEAcuerdoPEM = ReglasWebBL.Instancia.listarAcuerdoPEM_AcuId(LstAcuerdos.Value)

            txtCodigo.Text = loAcuerdoPEM.AcuId

            cboInstitucion.Value = loAcuerdoPEM.tgInstitucionId
            cboSede.TextField = "TgNombre"
            cboSede.ValueField = "TgCodigo"
            cboSede.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, cboInstitucion.Value)
            cboSede.SelectedIndex = -1
            cboSede.DataBind()
            cboSede.Value = loAcuerdoPEM.tgSedeId

            txtPerId.Text = loAcuerdoPEM.PerId
            txtCliente.Text = loAcuerdoPEM.Persona
            cboTipoVehiculo.Value = loAcuerdoPEM.TgTipoVehId
            txtNumPlaca1.Text = loAcuerdoPEM.AcuNPlaca1
            txtNumPlaca2.Text = loAcuerdoPEM.AcuNPlaca2
            txtNumPlaca3.Text = loAcuerdoPEM.AcuNPlaca3

            If loAcuerdoPEM.AcuNPlaca1 <> "" Then
                txtCodBarras1.Text = loAcuerdoPEM.AcuNPlaca1 & loAcuerdoPEM.PerId
                imgCodBarras1.ImageUrl = String.Format("http:\\" & Request.Url.Authority & "\" & "MarckysCodeBar.ashx?code={0}&format={1}&width=400&height=60&size=50", "*" & txtCodBarras1.Text & "*", "E9")
                imgCodBarras1.Visible = True
                btnImprimir.Enabled = True
            End If

            If loAcuerdoPEM.AcuNPlaca2 <> "" Then
                txtCodBarras2.Text = loAcuerdoPEM.AcuNPlaca2 & loAcuerdoPEM.PerId
                imgCodBarras2.ImageUrl = String.Format("http:\\" & Request.Url.Authority & "\" & "MarckysCodeBar.ashx?code={0}&format={1}&width=400&height=60&size=50", "*" & txtCodBarras2.Text & "*", "E9")
                imgCodBarras2.Visible = True
                btnImprimir2.Enabled = True
            End If

            If loAcuerdoPEM.AcuNPlaca3 <> "" Then
                txtCodBarras3.Text = loAcuerdoPEM.AcuNPlaca3 & loAcuerdoPEM.PerId
                imgCodBarras3.ImageUrl = String.Format("http:\\" & Request.Url.Authority & "\" & "MarckysCodeBar.ashx?code={0}&format={1}&width=400&height=60&size=50", "*" & txtCodBarras3.Text & "*", "E9")
                imgCodBarras3.Visible = True
                btnImprimir3.Enabled = True
            End If

            cboTarifa.TextField = "ConNombre"
            cboTarifa.ValueField = "TarfId"
            cboTarifa.DataSource = ReglasWebBL.Instancia.listarTarifasPEMCriterio(0, cboTipoVehiculo.Value)
            cboTarifa.SelectedIndex = -1
            cboTarifa.DataBind()
            cboTarifa.Value = loAcuerdoPEM.TarfId


            txtFechaRegistro.Text = loAcuerdoPEM.AcuFechaReg
            dedFechaInicio.Date = loAcuerdoPEM.AcuFechaIni
            dedFechaFin.Date = loAcuerdoPEM.AcuFechaFin
            dtHInicio.Value = loAcuerdoPEM.AcuHoIni
            dtHFin.Value = loAcuerdoPEM.AcuHoFin
            txtPrecio.Text = loAcuerdoPEM.AcuPrecio
            cboNivel.Value = loAcuerdoPEM.NivId
            txtEspacioSelec.Text = loAcuerdoPEM.AcuNEspacio
            cboAcuerdoEstado.SelectedIndex = IIf(loAcuerdoPEM.AcuEstado Is Nothing, 1, loAcuerdoPEM.AcuEstado)
        End If
    End Sub

    Sub cargarSede()
        cboSede.TextField = "TgNombre"
        cboSede.ValueField = "TgCodigo"
        cboSede.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, cboInstitucion.Value)
        cboSede.SelectedIndex = -1
        cboSede.DataBind()
    End Sub
    Protected Sub cboInstitucion_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboInstitucion.ValueChanged
        cargarSede()
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
            txtPrecio.Text = loTarifasPEM.AcuPrecio
            dtHInicio.Value = loTarifasPEM.tarfIni
            dtHFin.Value = loTarifasPEM.tarfFin
            TarfNroDias = loTarifasPEM.TarfNroDias
        Else

        End If


        'cboTarifa.TextField = "ConNombre"
        ''cboTarifa.ValueField = "TarfId"
        'cboTarifa.DataSource = ReglasWebBL.Instancia.listarTarifasPEMCriterio(0, cboTipoVehiculo.Value)
        'cboTarifa.SelectedIndex = -1
        'cboTarifa.DataBind()
    End Sub

    Protected Sub dedFechaInicio_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dedFechaInicio.ValueChanged
        dedFechaFin.Value = DateAdd(DateInterval.Day, TarfNroDias, dedFechaInicio.Value)

        If DateDiff(DateInterval.Day, dedFechaInicio.Value, Date.Now) > 7 Then
            dedFechaInicio.Value = Date.Now
            MensajeScript("Los dias anteriores Maximos son de 7 Dias")
            Return
        End If
    End Sub

    Protected Sub btnImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click
        'Create an instance of PrintDocument
        Dim printdoc As New System.Drawing.Printing.PrintDocument()
        ' Set the printer name

        printdoc.PrinterSettings.PrinterName = Me.ddlImpresoras.Text
        ' Handle printing
        AddHandler printdoc.PrintPage, AddressOf Me.printdoc_PrintPage

        ' Print!
        printdoc.Print()
    End Sub

    Private Sub printdoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Definición de la fte a utilizar.
        Dim printFont1 As System.Drawing.Font = New System.Drawing.Font("Times New Roman", 11, Drawing.FontStyle.Bold)

        ' Dibujar el nombre escrito y que se desea imprimir directamente.
        e.Graphics.DrawString("Servicio de Administracion de Inmuebles", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(5.0F, -5.0F))
        e.Graphics.DrawString("Municipales de Trujillo", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(59.0F, 11.0F))
        e.Graphics.DrawString("Abonado", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(100.0F, 30.0F))

        'Definición de la fte a utilizar.
        Dim printFont As System.Drawing.Font = New System.Drawing.Font("Free 3 of 9 Extended", 25)

        ' Dibujar el nombre escrito y que se desea imprimir directamente.
        e.Graphics.DrawString("*" & txtCodBarras1.Text & "*", printFont, System.Drawing.Brushes.Black, New System.Drawing.PointF(24.0F, 50.0F))
    End Sub

    Protected Sub btnImprimir2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir2.Click
        'Create an instance of PrintDocument
        Dim printdoc As New System.Drawing.Printing.PrintDocument()
        ' Set the printer name
        printdoc.PrinterSettings.PrinterName = Me.ddlImpresoras.Text
        ' Handle printing
        AddHandler printdoc.PrintPage, AddressOf Me.printdoc_PrintPage2
        ' Print!
        printdoc.Print()
    End Sub

    Private Sub printdoc_PrintPage2(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Definición de la fte a utilizar.
        Dim printFont1 As System.Drawing.Font = New System.Drawing.Font("Times New Roman", 11, Drawing.FontStyle.Bold)

        ' Dibujar el nombre escrito y que se desea imprimir directamente.
        e.Graphics.DrawString("Servicio de Administracion de Inmuebles", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(5.0F, -5.0F))
        e.Graphics.DrawString("Municipales de Trujillo", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(59.0F, 11.0F))
        e.Graphics.DrawString("Abonado", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(100.0F, 30.0F))

        'Definición de la fte a utilizar.
        Dim printFont As System.Drawing.Font = New System.Drawing.Font("Free 3 of 9 Extended", 25)

        ' Dibujar el nombre escrito y que se desea imprimir directamente.
        e.Graphics.DrawString("*" & txtCodBarras2.Text & "*", printFont, System.Drawing.Brushes.Black, New System.Drawing.PointF(10.0F, 50.0F))
    End Sub

    Protected Sub btnImprimir3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir3.Click
        'Create an instance of PrintDocument
        Dim printdoc As New System.Drawing.Printing.PrintDocument()
        ' Set the printer name
        printdoc.PrinterSettings.PrinterName = Me.ddlImpresoras.Text
        ' Handle printing
        AddHandler printdoc.PrintPage, AddressOf Me.printdoc_PrintPage3
        ' Print!
        printdoc.Print()
    End Sub

    Private Sub printdoc_PrintPage3(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Definición de la fte a utilizar.
        Dim printFont1 As System.Drawing.Font = New System.Drawing.Font("Times New Roman", 11, Drawing.FontStyle.Bold)

        ' Dibujar el nombre escrito y que se desea imprimir directamente.
        e.Graphics.DrawString("Servicio de Administracion de Inmuebles", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(5.0F, -5.0F))
        e.Graphics.DrawString("Municipales de Trujillo", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(59.0F, 11.0F))
        e.Graphics.DrawString("Abonado", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(100.0F, 30.0F))

        'Definición de la fte a utilizar.
        Dim printFont As System.Drawing.Font = New System.Drawing.Font("Free 3 of 9 Extended", 25)

        ' Dibujar el nombre escrito y que se desea imprimir directamente.
        e.Graphics.DrawString("*" & txtCodBarras3.Text & "*", printFont, System.Drawing.Brushes.Black, New System.Drawing.PointF(10.0F, 50.0F))
    End Sub
End Class