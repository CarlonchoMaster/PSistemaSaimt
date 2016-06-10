Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Public Class frmRecaudacionDiaria
    Inherits frmMantenimientos
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private lsRecId As String
    Private lsRecfecPag As Date


    Public Sub New(ByVal RecfecPag As Date, Optional ByVal recId As Int16 = 0)
        InitializeComponent()
        If recId = 0 Then
            recId = MantenimientosBL.Instancia.GeneraCodigo_RecIdxFechaPago(RecfecPag)
        End If
        lsRecId = recId
        lsRecfecPag = RecfecPag
    End Sub
    Private Sub frmRecaudacionDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nuevo()
        cboConceptos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboConceptos.Properties.DisplayMember = "TgNombre"
        cboConceptos.Properties.ValueMember = "TgCodigo"
        cboConceptos.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(193)
        cboConceptos.ItemIndex = 0

    End Sub


    Protected Overrides Sub nuevo()
        MyBase.nuevo()

        cboRecaudador.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRecaudador.Properties.DisplayMember = "TgNombre"
        cboRecaudador.Properties.ValueMember = "TgCodigo"
        cboRecaudador.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(34)
        cboRecaudador.EditValue = "02"

        cboTipoDoc.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoDoc.Properties.DisplayMember = "TgNombre"
        cboTipoDoc.Properties.ValueMember = "TgCodigo"
        cboTipoDoc.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(4)

        TxtRecId.Text = lsRecId
        dtpRecfecPago.Text = lsRecfecPag

        GEstadoNuevo = True
        Dim ListaRecaudacion As EERecaudacion = MantenimientosBL.Instancia.RecaudacionXrecFechaPago_recId(dtpRecfecPago.EditValue, TxtRecId.Text)

        If ListaRecaudacion IsNot Nothing Then
            cboRecaudador.EditValue = ListaRecaudacion.TgRecaudadorId
            TxtMontoTotal.Text = ListaRecaudacion.RecMonto
            txtDepositante.Text = ListaRecaudacion.PerNombre
            cboTipoDoc.EditValue = ListaRecaudacion.TgTipoDoc
            TxtNroDoc.Text = ListaRecaudacion.PerNroDoc
            cboConceptos.EditValue = ListaRecaudacion.ConId.Substring(0, 4)
            dtpfechaliq.DateTime = ListaRecaudacion.RecFechaLiquidacion
            GEstadoNuevo = False
            cboConceptos.Properties.ReadOnly = True
        Else
            TxtMontoTotal.Text = 0
            txtDepositante.Text = Nothing
            txtDepositante.Tag = Nothing
            cboTipoDoc.EditValue = Nothing
            TxtNroDoc.Text = Nothing
            dtpfechaliq.DateTime = Nothing
            cboConceptos.ItemIndex = 0
        End If

        TxtRecId.Properties.ReadOnly = True
        dtpRecfecPago.Properties.ReadOnly = True
        cboRecaudador.Properties.ReadOnly = True

    End Sub


    Protected Overrides Sub guardar()
        Try

      
        If Me.TxtRecId.Text Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("La recaudacion debe tener un valor")
            Exit Sub
        End If
        If Me.dtpRecfecPago.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("Fecha de pago debe tener un valor")
            Exit Sub
        End If
        If Me.cboRecaudador.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("Recaudador debe tener un valor")
            Exit Sub
            End If

        If Me.txtDepositante.Tag Is Nothing Then
                SaimtMessageBox.mostrarAlertaInformativa("seleccione el Depositante")
                Exit Sub
            End If

            If Me.TxtMontoTotal.Text <= 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un Monto Correcto")
                Exit Sub
            End If
        Dim concepto As EEConceptos = MantenimientosBL.Instancia.conceptosMostrarXConId(cboConceptos.EditValue & Year(dtpRecfecPago.EditValue))
        If concepto IsNot Nothing Then
            Dim loRecaudacion As New EERecaudacion
            loRecaudacion.RecId = TxtRecId.Text
            loRecaudacion.RecFecPago = dtpRecfecPago.EditValue
            loRecaudacion.ConId = cboConceptos.EditValue & Year(dtpRecfecPago.EditValue)
            loRecaudacion.TgTipoDoc = cboTipoDoc.EditValue
            loRecaudacion.PerNroDoc = TxtNroDoc.Text
            loRecaudacion.PerNombre = txtDepositante.Text
            loRecaudacion.RecMonto = TxtMontoTotal.Text
                loRecaudacion.ConPorcentaje = concepto.ConPorcentaje / 100
                loRecaudacion.RecTotalIng = (TxtMontoTotal.Text * loRecaudacion.ConPorcentaje)
                loRecaudacion.RecVComision = 0.25
                loRecaudacion.RecNeto = loRecaudacion.RecTotalIng - 0.25
                loRecaudacion.RecComision = loRecaudacion.RecVComision / loRecaudacion.RecNeto

                loRecaudacion.TgRecaudadorId = cboRecaudador.EditValue
            loRecaudacion.UsuId = EEComun.UsuIdOnline
                loRecaudacion.RecFechaLiquidacion = dtpfechaliq.EditValue
                If GEstadoNuevo = True Then
                    If MantenimientosBL.Instancia.RecaudacionGuardar(loRecaudacion) = True Then
                        SaimtMessageBox.mostrarAlertaInformativa("Se Guardo Correctamente la Recaudación")
                    End If
                Else
                    If MantenimientosBL.Instancia.RecaudacionActualizar(loRecaudacion, "02") = True Then
                        SaimtMessageBox.mostrarAlertaInformativa("Se Actualizo Correctamente la Recaudación")
                    End If
                End If
              

        End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaInformativa("Error al Guardar")
        End Try
    End Sub

 
    Private Sub btnConsultarConyuge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarConyuge.Click
        Dim fmConsultaPersona As frmConsultaPersonaGeneral = New frmConsultaPersonaGeneral(1)
        If fmConsultaPersona.ShowDialog() = DialogResult.OK Then
            txtDepositante.Text = fmConsultaPersona.PerNombre
            txtDepositante.Tag = fmConsultaPersona.PerId
            TxtNroDoc.Text = fmConsultaPersona.perNdoc
            cboTipoDoc.EditValue = fmConsultaPersona.PerTipoDoc
        End If
    End Sub
End Class