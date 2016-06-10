Imports ReglasNegocio
Imports Entidades

Public Class frmPisos
    Inherits System.Web.UI.Page

    Dim funciones As New MantenimientoWeb
    Private Shared vNuevoEditar As Boolean
    Dim tgId As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                txtCodigo.Enabled = False
                cboInstitucion.TextField = "TgNombre"
                cboInstitucion.ValueField = "TgCodigo"
                cboInstitucion.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(82)
                cboInstitucion.DataBind()
                cboInstitucion.SelectedIndex = -1
                funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Load)
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

    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
        LstListado.SelectedIndex = -1

        Try
            If cboInstitucion.Value = "" Then
                MensajeScript("Seleccione Institucion")
                Return
            End If
            If cboSede.Value = "" Then
                MensajeScript("Seleccione Sede")
                Return
            End If

            If spnPisos.Value < 0 Then
                MensajeScript("Ingrese Numero Enteros Positivos")
                Return
            End If
            Dim loPisosPEM As EETablaGeneral = New EETablaGeneral()
            Dim loClase As EEClase = New EEClase
            loPisosPEM.TgExtra = cboInstitucion.Value & cboSede.Value
            loPisosPEM.TgAbrev = spnPisos.Text
            loPisosPEM.TgCodigo = txtCodigo.Text
            loPisosPEM.TgActivo = True
            loPisosPEM.TgId = txttid.Text
            loClase.ClsId = 117
            loPisosPEM.OClase = loClase
            If vNuevoEditar = True Then
                Dim loPisos As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(117, loPisosPEM.TgExtra)
                If loPisos IsNot Nothing Then
                    MensajeScript("Ya se encuentra con pisos la sede seleccionada")
                    Return
                End If
                MantenimientosBL.Instancia.tablageneralinsertar(loPisosPEM)
            Else
                MantenimientosBL.Instancia.tablageneralUpdate(loPisosPEM)
            End If
            funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Guardar)
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub

    Protected Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        Try
            funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Nuevo)
            txtCodigo.Text = MantenimientosBL.Instancia.TablaGeneralNewCodigo(3, 117)
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
        cboSede.SelectedIndex = -1
        cboSede.DataBind()
    End Sub
    Protected Sub cboInstitucion_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboInstitucion.ValueChanged
        cboSede.Items.Clear()
        cboSede.TextField = "TgNombre"
        cboSede.ValueField = "TgCodigo"
        cboSede.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, cboInstitucion.Value)
        cboSede.DataBind()
        cboSede.SelectedIndex = -1
    End Sub

    Protected Sub btnSaimtBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaimtBuscar.Click
        LstListado.Items.Clear()
        LstListado.ValueField = "TgCodigo"
        LstListado.TextField = "TgNombre"
        LstListado.DataSource = MantenimientosBL.Instancia.ListarPisosXInstitucion(txtBuscarSaimt.Text)
        LstListado.DataBind()

    End Sub

    Protected Sub LstListado_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstListado.SelectedIndexChanged
        If LstListado.SelectedItem IsNot Nothing Then
            funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.ListBoxListado)
            Dim loPisosPEM As EETablaGeneral = MantenimientosBL.Instancia.ListarPisosXPisoId(LstListado.Value)
            txttid.Text = loPisosPEM.TgId
            txtCodigo.Text = loPisosPEM.TgCodigo
            cboInstitucion.Value = loPisosPEM.TgExtra.Substring(0, 4)
            cboSede.TextField = "TgNombre"
            cboSede.ValueField = "TgCodigo"
            cboSede.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, cboInstitucion.Value)
            cboSede.DataBind()
            cboSede.SelectedIndex = -1
            cboSede.Value = loPisosPEM.TgExtra.Substring(4, 3)
            spnPisos.Text = loPisosPEM.TgAbrev
        End If
    End Sub

    Protected Sub btnEditar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditar.Click
        funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Editar)
        vNuevoEditar = False
    End Sub

    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        If MantenimientosBL.Instancia.tablageneralEliminar(txttid.Text) Then
            MensajeScript("El Dato se a eliminado correctamente")
            funciones.ActivarBoton(rpDatos.Controls, MantenimientoWeb.Botones.Eliminar)
            btnSaimtBuscar_Click(Nothing, Nothing)
        End If
    End Sub
End Class