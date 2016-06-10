Imports ReglasNegocio
Imports Entidades

Public Class frmNiveles
    Inherits System.Web.UI.Page

    Dim dtNivelesPEM As DataTable = New DataTable()
    Dim funciones As New MantenimientoWeb
    Private Shared vNuevoEditar As Boolean
    Dim NPrimerNivel As String = String.Empty

    Private Sub ConstruirTableNivelesPEM()
        dtNivelesPEM.Columns.Add("nivId", GetType(String))
        dtNivelesPEM.Columns.Add("nivNombre", GetType(String))
        dtNivelesPEM.Columns.Add("nivEspInicio", GetType(Int16))
        dtNivelesPEM.Columns.Add("nivEspFin", GetType(Int16))
        dtNivelesPEM.Columns.Add("nroPiso", GetType(String))
        dtNivelesPEM.Columns.Add("tgInstitucionId", GetType(String))
        dtNivelesPEM.Columns.Add("tgSedeId", GetType(String))
        dtNivelesPEM.Columns.Add("nivActivo", GetType(Boolean))
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                txtCodigo.Enabled = False

                cboInstitucion.TextField = "TgNombre"
                cboInstitucion.ValueField = "TgCodigo"
                cboInstitucion.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(82)
                cboInstitucion.DataBind()
                cboInstitucion.SelectedIndex = -1

                ConstruirTableNivelesPEM()
                funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Load)
            End If

        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        LstListado.SelectedIndex = -1
        'VALIDACIONES

        If String.IsNullOrEmpty(cboNroPiso.Value) Then
            MensajeScript("Seleccione un Número de Piso")
            cboNroPiso.Focus()
            Return
        End If

        If String.IsNullOrEmpty(txtCodigo.Text) Then
            MensajeScript("Ingrese Codigo")
            txtCodigo.Focus()
            Return
        End If

        If String.IsNullOrEmpty(txtNombre.Text) Then
            MensajeScript("El Nombre de Nivel es Obligatorio")
            txtNombre.Focus()
            Return
        End If

        If String.IsNullOrEmpty(spnDesde.Text) Then
            MensajeScript("Ingrese numero de espacio Inicio")
            spnDesde.Focus()
            Return
        End If

        If String.IsNullOrEmpty(spnHasta.Text) Then
            MensajeScript("Ingrese numero de espacio Hasta")
            spnHasta.Focus()
            Return
        Else
            If spnDesde.Text >= spnHasta.Text Then
                MensajeScript("El Numero de Espacio DESDE debe ser menor que HASTA")
                spnHasta.Focus()
                Return
            End If
        End If
        Dim loniveles As List(Of EENivelesPEM) = ReglasWebBL.Instancia.nivelespemListarCriterio(0, txtNombre.Text)
        If vNuevoEditar = True Then
            If loniveles IsNot Nothing Then
                MensajeScript(String.Format("El Nombre {0} Ya existe", txtNombre.Text))
                Return
            End If
        Else
            If txtCodigo0.Text <> txtNombre.Text Then
                If loniveles IsNot Nothing Then
                    MensajeScript(String.Format("El Nombre {0} Ya existe", txtNombre.Text))
                    Return
                End If
            End If
        End If



        ' Fin Validacion

        Try
            Dim loNivelPEM As EENivelesPEM = New EENivelesPEM()
            Dim loNroPiso As EETablaGeneral = New EETablaGeneral()
            loNroPiso.TgCodigo = cboNroPiso.Value

            loNivelPEM.tgInstitucionId = cboInstitucion.Value
            loNivelPEM.tgSedeId = cboSede.Value
            loNivelPEM.NivNombre = txtNombre.Text
            loNivelPEM.ONroPiso = loNroPiso
            loNivelPEM.NivEspInicio = Convert.ToInt16(spnDesde.Value)
            loNivelPEM.NivEspFin = Convert.ToInt16(spnHasta.Value)
            loNivelPEM.NivActivo = chbEstadoNivel.Checked
            loNivelPEM.NivId = txtCodigo.Text

            If vNuevoEditar = True Then
                ReglasWebBL.Instancia.nivelespemGuardar(loNivelPEM)
                txtNombre.Text = ""
            Else
                ReglasWebBL.Instancia.nivelespemActualizar(loNivelPEM)
            End If

            funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Guardar)
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
        LstListado.SelectedIndex = -1
        Try
            funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Nuevo)
            txtCodigo.Text = ReglasWebBL.Instancia.generaCodigoNivelesPEM
            txtCodigo.ReadOnly = True
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
    Protected Sub btnEditar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditar.Click
        LstListado.SelectedIndex = -1
        vNuevoEditar = False

        funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Editar)
    End Sub

    Protected Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        LstListado.SelectedIndex = -1
        funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.CancelarNuevo)
    End Sub

    Protected Sub btnSaimtBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaimtBuscar.Click
        LstListado.ValueField = "NivId"
        LstListado.TextField = "DatoListadoNivles"
        LstListado.DataSource = ReglasWebBL.Instancia.nivelespemListarCriterio(0, txtBuscarSaimt.Text)
        LstListado.DataBind()
    End Sub

    Protected Sub LstListado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstListado.SelectedIndexChanged
        If LstListado.SelectedItem IsNot Nothing Then
            funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.ListBoxListado)
            Dim loNiveles As EENivelesPEM = ReglasWebBL.Instancia.listarNivelesPEM_NivId(LstListado.Value)
            txtCodigo.Text = loNiveles.NivId
            cboInstitucion.Value = loNiveles.tgInstitucionId
            cboSede.TextField = "TgNombre"
            cboSede.ValueField = "TgCodigo"
            cboSede.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, cboInstitucion.Value)
            cboSede.SelectedIndex = -1
            cboSede.DataBind()
            cboSede.Value = loNiveles.tgSedeId
            cboNroPiso.Value = loNiveles.tgNPisoId
            txtNombre.Text = loNiveles.NivNombre
            spnDesde.Text = loNiveles.NivEspInicio
            spnHasta.Text = loNiveles.NivEspFin
            txtCodigo0.Text = txtNombre.Text
            chbEstadoNivel.Checked = IIf(loNiveles.NivActivo Is Nothing, False, loNiveles.NivActivo)
        End If
    End Sub

    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        LstListado.SelectedIndex = -1
        Try

            ReglasWebBL.Instancia.nivelespemEliminar(txtCodigo.Text)
            funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Eliminar)
            btnSaimtBuscar_Click(Nothing, Nothing)
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub

    Protected Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLimpiar.Click
        LstListado.SelectedIndex = -1
        funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Nuevo)
    End Sub

    Protected Sub cboInstitucion_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboInstitucion.ValueChanged
        cboSede.TextField = "TgNombre"
        cboSede.ValueField = "TgCodigo"
        cboSede.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, cboInstitucion.Value)
        cboSede.DataBind()
        cboSede.SelectedIndex = -1
    End Sub

    Protected Sub cboSede_ValueChanged(sender As Object, e As EventArgs) Handles cboSede.ValueChanged
        Dim ListaPisos As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(117, cboInstitucion.Value & cboSede.Value)
        Dim ListaPisosMostrar As List(Of EETablaGeneral) = Nothing
        If ListaPisos IsNot Nothing Then

            Dim liNroPisos As Int16 = Convert.ToInt16(ListaPisos(0).TgAbrev)
            Dim liFila = 1

            While liNroPisos > 0
                If ListaPisosMostrar Is Nothing Then
                    ListaPisosMostrar = New List(Of EETablaGeneral)
                End If
                Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = liFila.ToString()
                loTablaGeneral.TgCodigo = ListaPisos(0).TgCodigo & liFila.ToString()

                ListaPisosMostrar.Add(loTablaGeneral)
                liNroPisos = liNroPisos - 1
                liFila = liFila + 1
            End While
        End If

        cboNroPiso.Items.Clear()
        cboNroPiso.TextField = "TgNombre"
        cboNroPiso.ValueField = "TgCodigo"
        cboNroPiso.DataSource = ListaPisosMostrar
        cboNroPiso.DataBind()
        cboNroPiso.SelectedIndex = -1
    End Sub
End Class