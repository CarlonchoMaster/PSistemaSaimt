Imports ReglasNegocio
Imports Entidades

Public Class frmRegistroDiario
    Inherits System.Web.UI.Page

    Private Shared DiarioId As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        upPanelAsignarEspacio.Visible = False
        btnGuardar.Visible = False
        hlRealizarNuevoAcuerdo.Visible = False

        If Not Page.IsPostBack Then
            Dim ListaTipoVehiculos As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId(103)

            rblTipoVehiculos.TextField = "TgNombre"
            rblTipoVehiculos.ValueField = "TgCodigo"
            rblTipoVehiculos.DataSource = ListaTipoVehiculos
            rblTipoVehiculos.DataBind()

            cboNivel.DataSource = ReglasWebBL.Instancia.nivelespemListarCriterio(0, cboNivel.Value)
            cboNivel.TextField = "NivNombre"
            cboNivel.ValueField = "NivId"
            cboNivel.DataBind()

            cboNivel.SelectedIndex = 0
            rblTipoVehiculos.SelectedIndex = 0
        End If
    End Sub

    Protected Sub btnConfirmar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirmar.Click
        'Try
        '    Dim lbMarcaAbonado As Boolean = False
        '    Dim acuEstado As String
        '    Dim loAcuerdoPEM As EEAcuerdoPEM = ReglasWebBL.Instancia.acuerdopemConsultarAcuerdoXNPlaca_Estacionamiento(txtPlacaVehiculo.Text)
        '    If loAcuerdoPEM IsNot Nothing Then
        '        rblTipoVehiculos.Value = loAcuerdoPEM.TgTipoVehId
        '        acuEstado = loAcuerdoPEM.AcuEstado
        '        rblTipoVehiculos.ReadOnly = True
        '        lbMarcaAbonado = True
        '    End If

        '    Dim loDiarioPEM As EEDiarioPEM = ReglasWebBL.Instancia.diariopemConsultarXNPlaca_Estacionamiento(txtPlacaVehiculo.Text)
        '    If loDiarioPEM Is Nothing Then
        '        lblIngresoSalida.Text = "Entrada"

        '        If lbMarcaAbonado Then
        '            Dim loDiarioPEM2 As EEDiarioPEM = New EEDiarioPEM()

        '            loDiarioPEM2.DiaNPlaca = txtPlacaVehiculo.Text
        '            loDiarioPEM2.TgTipoVehId = rblTipoVehiculos.Value
        '            loDiarioPEM2.NivId = cboNivel.Value
        '            loDiarioPEM2.DiaEspacio = loAcuerdoPEM.AcuNEspacio
        '            loDiarioPEM2.TgTipoAbonoId = 1
        '            If loAcuerdoPEM.MensajeAcuerdo <> "" Then
        '                lblMensajeExito.Text = loAcuerdoPEM.MensajeAcuerdo
        '                hlRealizarNuevoAcuerdo.Visible = True
        '                hlRealizarRegistroDiario.Visible = True
        '            Else
        '                ReglasWebBL.Instancia.diariopemGuardar(loDiarioPEM2)

        '                lblAbonadoCliente.Text = "Bienvenido Abonado : " & loAcuerdoPEM.Persona
        '                lblMensajeExito.Text = "La Entrada Se Realizo Corectamente"
        '                lblMensajeUbicacion.Text = "Ubicarse en el espacio : " & loAcuerdoPEM.AcuNEspacio
        '            End If
        '        Else
        '            upPanelAsignarEspacio.Visible = True
        '            btnGuardar.Visible = True
        '            rblTipoVehiculos.ReadOnly = False
        '            lblAbonadoCliente.Text = String.Empty
        '            lblMensajeUbicacion.Text = String.Empty
        '            lblMensajeExito.Text = String.Empty
        '        End If
        '    Else
        '        upPanelAsignarEspacio.Visible = False
        '        btnGuardar.Visible = False
        '        rblTipoVehiculos.ReadOnly = True
        '        lblAbonadoCliente.Text = String.Empty
        '        lblIngresoSalida.Text = String.Empty
        '        lblMensajeUbicacion.Text = String.Empty
        '        lblMensajeExito.Text = "El Vehículo Ya Fué Registrado"
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
        'Try
        '    Dim loDiarioPEM As EEDiarioPEM = New EEDiarioPEM()

        '    loDiarioPEM.DiaNPlaca = txtPlacaVehiculo.Text
        '    loDiarioPEM.TgTipoVehId = rblTipoVehiculos.Value
        '    loDiarioPEM.NivId = cboNivel.Value
        '    loDiarioPEM.DiaEspacio = txtEspacioSelec.Text
        '    loDiarioPEM.TgTipoAbonoId = 0
        '    ReglasWebBL.Instancia.diariopemGuardar(loDiarioPEM)

        '    lblAbonadoCliente.Text = "---"
        '    lblIngresoSalida.Text = "---"
        '    lblMensajeUbicacion.Text = String.Empty
        '    lblMensajeExito.Text = "La Entrada Se Realizo Corectamente"


        '    'Create an instance of PrintDocument
        '    Dim printdoc As New System.Drawing.Printing.PrintDocument()
        '    ' Set the printer name

        '    printdoc.PrinterSettings.PrinterName = "EPSON TM-T88IV Receipt"
        '    ' Handle printing
        '    AddHandler printdoc.PrintPage, AddressOf Me.printdoc_PrintPage

        '    ' Print!
        '    printdoc.Print()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub printdoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Definición de la fte a utilizar.
        Dim printFont1 As System.Drawing.Font = New System.Drawing.Font("Times New Roman", 11, Drawing.FontStyle.Bold)

        ' Dibujar el nombre escrito y que se desea imprimir directamente.
        e.Graphics.DrawString("Servicio de Administracion de Inmuebles", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(5.0F, -5.0F))
        e.Graphics.DrawString("Municipales de Trujillo", printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(59.0F, 11.0F))
        e.Graphics.DrawString("Cliente - Hora Ingreso : " & DateTime.Now.ToString("hh:mm:ss tt"), printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(30.0F, 30.0F))

        'Definición de la fte a utilizar.
        Dim printFont As System.Drawing.Font = New System.Drawing.Font("Free 3 of 9 Extended", 25)

        ' Dibujar el nombre escrito y que se desea imprimir directamente.
        e.Graphics.DrawString("*" & txtPlacaVehiculo.Text.ToUpper() & "*", printFont, System.Drawing.Brushes.Black, New System.Drawing.PointF(70.0F, 50.0F))

        e.Graphics.DrawString("Ubicación : Nivel " & cboNivel.Text & " - Esp. " & txtEspacioSelec.Text, printFont1, System.Drawing.Brushes.Black, New System.Drawing.PointF(5.0F, 82.0F))
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles hlRealizarRegistroDiario.Click
        upPanelAsignarEspacio.Visible = True
        btnGuardar.Visible = True
        rblTipoVehiculos.ReadOnly = False
        lblAbonadoCliente.Text = String.Empty
        lblMensajeUbicacion.Text = String.Empty
        lblMensajeExito.Text = String.Empty
        hlRealizarNuevoAcuerdo.Visible = False
        hlRealizarRegistroDiario.Visible = False
    End Sub
End Class