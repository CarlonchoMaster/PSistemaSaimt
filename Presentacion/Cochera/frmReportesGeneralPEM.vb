Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmReportesGeneralPEM
    Inherits frmGeneral
    Dim dtAbonoPEM As DataTable = New DataTable
    Dim dt_diarioPEM As DataTable = New DataTable
    Dim dt_AbonadoDetPEM As DataTable = New DataTable
    Private Property tgTipoAbonId As String = String.Empty
    Private Property AbonadoID As String = String.Empty

    Private Sub ConstruirTableAbonadosPEM()
        dtAbonoPEM.Columns.Add("AbonId", GetType(String))
        dtAbonoPEM.Columns.Add("AbonNPlaca1", GetType(String))
        dtAbonoPEM.Columns.Add("AbonNPlaca2", GetType(String))
        dtAbonoPEM.Columns.Add("AbonNPlaca3", GetType(String))
        dtAbonoPEM.Columns.Add("AbonFechaIni", GetType(DateTime))
        dtAbonoPEM.Columns.Add("AbonFechaFin", GetType(DateTime))
        dtAbonoPEM.Columns.Add("AbonImporte", GetType(Decimal))
        dtAbonoPEM.Columns.Add("Concepto", GetType(String))
        dtAbonoPEM.Columns.Add("Persona", GetType(String))
        dtAbonoPEM.Columns.Add("TipoDocumento", GetType(String))
        dtAbonoPEM.Columns.Add("NroDocumento", GetType(String))
    End Sub

    Private Sub ConstruirTableDiarioPEM()
        dt_diarioPEM.Columns.Add("diarioId", GetType(String))
        dt_diarioPEM.Columns.Add("diarioCod", GetType(String))
        dt_diarioPEM.Columns.Add("diaNPlaca", GetType(String))
        dt_diarioPEM.Columns.Add("diaFechaIng", GetType(Date))
        dt_diarioPEM.Columns.Add("diaHoraIng", GetType(String))
        dt_diarioPEM.Columns.Add("diaHoraSal", GetType(String))
        dt_diarioPEM.Columns.Add("diaPrecio", GetType(Decimal))
        dt_diarioPEM.Columns.Add("usuario", GetType(String))
        dt_diarioPEM.Columns.Add("perId", GetType(String))
        dt_diarioPEM.Columns.Add("persona", GetType(String))
        dt_diarioPEM.Columns.Add("conId", GetType(String))
        dt_diarioPEM.Columns.Add("conNombre", GetType(String))
        dt_diarioPEM.Columns.Add("diaFechaSal", GetType(Date))
    End Sub

    Private Sub ConstruirTableDiarioDetPEM()
        dt_AbonadoDetPEM.Columns.Add("AbonDetId", GetType(String))
        dt_AbonadoDetPEM.Columns.Add("AbonId", GetType(String))
        dt_AbonadoDetPEM.Columns.Add("AbonDetNroCuota", GetType(Int16))
        dt_AbonadoDetPEM.Columns.Add("AbonDetFechaIni", GetType(DateTime))
        dt_AbonadoDetPEM.Columns.Add("AbonDetFechaFin", GetType(DateTime))
        dt_AbonadoDetPEM.Columns.Add("AbonDetFecPago", GetType(DateTime))
        dt_AbonadoDetPEM.Columns.Add("AbonDetPagado", GetType(Boolean))
        dt_AbonadoDetPEM.Columns.Add("AbonDetImporte", GetType(Decimal))
        dt_AbonadoDetPEM.Columns.Add("TgEstadoId", GetType(String))
        dt_AbonadoDetPEM.Columns.Add("Estado", GetType(String))
        dt_AbonadoDetPEM.Columns.Add("Persona", GetType(String))
        dt_AbonadoDetPEM.Columns.Add("perNDoc", GetType(String))
        dt_AbonadoDetPEM.Columns.Add("tgDocumento", GetType(String))
    End Sub

    Private Sub frmIngresoVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableAbonadosPEM()
        ConstruirTableDiarioPEM()
        ConstruirTableDiarioDetPEM()
        'txtfecha.Text = Date.Now.ToShortDateString
        'txtHora.Text = Date.Now.ToShortTimeString

        cboTipoVehiculo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoVehiculo.Properties.DisplayMember = "TgNombre"
        cboTipoVehiculo.Properties.ValueMember = "TgCodigo"
        cboTipoVehiculo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(103)
        cboTipoVehiculo.ItemIndex = -1
        cboTipoVehiculo.EditValue = Nothing
        cboTipoVehiculo.Properties.ReadOnly = True


        cboConceptos.mColumnas(SaimtComboBoxLookUp.Entidades.Concepto)
        cboConceptos.Properties.DisplayMember = "ConIdConNombre"
        cboConceptos.Properties.ValueMember = "ConId"
        cboConceptos.Properties.DataSource = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupo(EEComun.FechaServidor.Value.Year, "06")
        cboConceptos.ItemIndex = -1
        cboConceptos.EditValue = Nothing
        cboConceptos.Properties.ReadOnly = True

        dtpFechaInicio.EditValue = Date.Now.Date
        dtpFechaFin.EditValue = Date.Now.Date
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        gcdiarioId.Visible = False
        gcdiarionroticket.Visible = False
        gcdiarioplaca.Visible = False
        gcdiariofecha.Visible = False
        gcdiariohoraE.Visible = False
        gcdiariohoras.Visible = False
        gcdiariomonto.Visible = False
        gcdiarioUsuarioId.Visible = False
        gcdiarioPerId.Visible = False
        gcDiarioUsuario.Visible = False
        gcdiarioConId.Visible = False
        gcdiarioConcepto.Visible = False
        gcdiariofechaSal.Visible = False

        gcAbonId.Visible = False
        gcAbonPlaca1.Visible = False
        gcAbonPlaca2.Visible = False
        gcAbonPlaca3.Visible = False
        gcAbonFechaIni.Visible = False
        gcAbonFechaFin.Visible = False
        gcAbonImporte.Visible = False
        gcAbonConcepto.Visible = False
        gcAbonPersona.Visible = False
        gcAbonTipoDoc.Visible = False
        gcAbonNroDoc.Visible = False

        If cboTipoAbonado.SelectedIndex = 0 Then
            gcAbonId.Visible = True
            gcAbonPlaca1.Visible = True
            gcAbonPlaca2.Visible = True
            gcAbonPlaca3.Visible = True
            gcAbonFechaIni.Visible = True
            gcAbonFechaFin.Visible = True
            gcAbonImporte.Visible = True
            gcAbonConcepto.Visible = True
            gcAbonPersona.Visible = True
            gcAbonTipoDoc.Visible = True
            gcAbonNroDoc.Visible = True

            gcAbonId.VisibleIndex = 0
            gcAbonPlaca1.VisibleIndex = 1
            gcAbonPlaca2.VisibleIndex = 2
            gcAbonPlaca3.VisibleIndex = 3
            gcAbonFechaIni.VisibleIndex = 4
            gcAbonFechaFin.VisibleIndex = 5
            gcAbonImporte.VisibleIndex = 6
            gcAbonConcepto.VisibleIndex = 7
            gcAbonPersona.VisibleIndex = 8
            gcAbonTipoDoc.VisibleIndex = 9
            gcAbonNroDoc.VisibleIndex = 10

            Try
                dgvReportePEM.DataSource = dtAbonoPEM
                dgvAbonadoDetPEM.DataSource = Nothing
                dtAbonoPEM.Rows.Clear()
                Dim ListaAbonoPEM As List(Of EEAbonoPEM) = MantenimientosBL.Instancia.abonopemReporteXFechasXtgEstadoIdXOPtgTipoVehiculoIdXOPConId(dtpFechaInicio.EditValue, dtpFechaFin.EditValue, cboEstados.EditValue, cboTipoVehiculo.EditValue, cboConceptos.EditValue)
                If ListaAbonoPEM IsNot Nothing Then
                    For Each fAbonoPEM As EEAbonoPEM In ListaAbonoPEM
                        dtAbonoPEM.LoadDataRow(New Object() {fAbonoPEM.AbonId,
                                                             fAbonoPEM.AbonNPlaca1,
                                                             fAbonoPEM.AbonNPlaca2,
                                                             fAbonoPEM.AbonNPlaca3,
                                                             fAbonoPEM.AbonFechaIni,
                                                             fAbonoPEM.AbonFechaFin,
                                                             fAbonoPEM.AbonImporte,
                                                             fAbonoPEM.OConcepto.ConNombre,
                                                             fAbonoPEM.OPersona.Persona,
                                                             fAbonoPEM.OPersona.TgDocumento,
                                                             fAbonoPEM.OPersona.PerNDoc
                                        }, True)
                    Next
                End If
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaError(ex.Message)
            End Try
        Else
            dgvReportePEM.DataSource = dt_diarioPEM
            gcdiarionroticket.Visible = True
            gcdiarioplaca.Visible = True
            gcdiariofecha.Visible = True
            gcdiariohoraE.Visible = True
            gcdiariohoras.Visible = True
            gcdiariomonto.Visible = True
            gcdiarioUsuarioId.Visible = True
            gcDiarioUsuario.Visible = True
            gcdiarioConId.Visible = True
            gcdiarioConcepto.Visible = True
            gcdiariofechaSal.Visible = True

            gcdiarionroticket.VisibleIndex = 0
            gcdiarioplaca.VisibleIndex = 1
            gcdiariofecha.VisibleIndex = 2
            gcdiariohoraE.VisibleIndex = 3
            gcdiariofechaSal.VisibleIndex = 4
            gcdiariohoras.VisibleIndex = 5
            gcdiariomonto.VisibleIndex = 6
            gcdiarioConcepto.VisibleIndex = 7
            gcdiarioConId.VisibleIndex = 8
            gcdiarioUsuarioId.VisibleIndex = 9
            gcDiarioUsuario.VisibleIndex = 10


            Try
                dt_diarioPEM.Rows.Clear()
                Dim PerId As String = String.Empty
                Dim Persona As String = String.Empty
                Dim Usuario As String = String.Empty

                Dim tipoAbonado As String = Nothing
                If cboTipoAbonado.SelectedIndex = 1 Then
                    tipoAbonado = "02"
                Else
                    tipoAbonado = "01"
                End If

                Dim ListaDiarioPEM As List(Of EEDiarioPEM) = MantenimientosBL.Instancia.diariopemReporteXFechasXtgEstadoIdXOPtgTipoVehiculoIdXOPConId(dtpFechaInicio.EditValue, dtpFechaFin.EditValue, cboEstados.EditValue, cboTipoVehiculo.EditValue, cboConceptos.EditValue, tipoAbonado)
                If ListaDiarioPEM IsNot Nothing Then
                    For Each frow As EEDiarioPEM In ListaDiarioPEM
                        If String.Compare(PerId, frow.PerRegId) <> 0 Then
                            Dim loPersona As EEPersona = MantenimientosBL.Instancia.MostrarPersonaUsuarioxPerId(frow.PerRegId)
                            If loPersona IsNot Nothing Then
                                PerId = frow.PerRegId
                                Persona = loPersona.Persona
                                Usuario = loPersona.Usuario
                            End If
                        End If
                        Dim horaEntrada As Date = frow.DiaHoraIng
                        Dim horaSalida As String = frow.DiaHoraSal
                        Dim horaSalida2 As Date? = frow.DiaHoraSal
                        horaSalida = IIf(Len(horaSalida.ToString) > 10, horaSalida.ToString.Substring(10), "")
                        If Len(horaSalida) > 0 Then
                            horaSalida2 = CDate(horaSalida)
                        Else
                            horaSalida2 = Nothing
                        End If
                        dt_diarioPEM.LoadDataRow(New Object() {frow.DiarioId, _
                                                             frow.DiarioCod, _
                                                             frow.DiaNPlaca, _
                                                             frow.DiaFechaIng, _
                                                             Format(horaEntrada, "HH:mm:ss"), _
                                                               IIf(horaSalida2 Is Nothing, "", Format(horaSalida2, "HH:mm:ss")), _
                                                             frow.DiaPrecio, _
                                                             Usuario, _
                                                             PerId, _
                                                             Persona, _
                                                             frow.loConcepto.ConId, _
                                                             frow.loConcepto.ConNombre, _
                                                             frow.DiaFechaSal
                                                             }, True)

                    Next
                End If
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaError(ex.Message)
            End Try
        End If
        Me.gvReportePEM.BestFitColumns()
        gcdiariomonto.Width = 110
        gcAbonImporte.Width = 110
        Me.tabReportes.SelectedTabPageIndex = 0
    End Sub

    Private Sub chkTipoVehiculo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTipoVehiculo.CheckedChanged
        cboTipoVehiculo.Properties.ReadOnly = Not chkTipoVehiculo.Checked
        If chkTipoVehiculo.Checked = False Then
            cboTipoVehiculo.ItemIndex = -1
            cboTipoVehiculo.EditValue = Nothing
        End If
    End Sub

    Private Sub chkConceptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConceptos.CheckedChanged
        cboConceptos.Properties.ReadOnly = Not chkConceptos.Checked
        If chkConceptos.Checked = False Then
            cboConceptos.ItemIndex = -1
            cboConceptos.EditValue = Nothing
        End If
    End Sub

    Private Sub cboTipoAbonado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoAbonado.SelectedIndexChanged
        cboEstados.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstados.Properties.DisplayMember = "TgNombre"
        cboEstados.Properties.ValueMember = "TgCodigo"


        If cboTipoAbonado.SelectedIndex = 0 Then
            cboEstados.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(118)
        ElseIf cboTipoAbonado.SelectedIndex = 1 Then
            cboEstados.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(157)
        End If
        cboEstados.ItemIndex = 0
    End Sub

    Private Sub btnBuscarAbonoFechaV_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarAbonoFechaV.Click
        Try
            If dtpAbonFechaFin.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Fecha Abonado Vencimiento")
                dtpAbonFechaFin.Focus()
                Exit Sub
            End If

            dgvAbonadoDetPEM.DataSource = dt_AbonadoDetPEM
            dgvReportePEM.DataSource = Nothing
            dt_AbonadoDetPEM.Rows.Clear()
            Dim ListaAbonoPEM As List(Of EEAbonoPEM) = MantenimientosBL.Instancia.abonodetpemListarDetalleEnReportePEMXAbonDetFecha(1, dtpAbonFechaFin.EditValue)
            If ListaAbonoPEM IsNot Nothing Then
                For Each fAbonoPEM As EEAbonoPEM In ListaAbonoPEM
                    dt_AbonadoDetPEM.LoadDataRow(New Object() {fAbonoPEM.LoAbonadoDetalle.AbonDetId,
                                                         fAbonoPEM.AbonId,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetNroCuota,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetFechaIni,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetFechaFin,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetFecPago,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetPagado,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetImporte,
                                                         fAbonoPEM.LoAbonadoDetalle.OTgEstado.TgCodigo,
                                                         fAbonoPEM.LoAbonadoDetalle.OTgEstado.TgNombre,
                                                         fAbonoPEM.OPersona.Persona,
                                                         fAbonoPEM.OPersona.PerNDoc,
                                                         fAbonoPEM.OPersona.TgDocumento
                                    }, True)
                Next
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
        Me.gvAbonadoDetPEM.BestFitColumns()
        GridColumn6.Width = 110
        Me.tabReportes.SelectedTabPageIndex = 1
    End Sub

    Private Sub btnBuscarAbonoFechaI_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarAbonoFechaI.Click
        Try
            If dtpAbonFechaFin.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Fecha Abonado Inicio")
                dtpAbonFechaInicio.Focus()
                Exit Sub
            End If

            dgvAbonadoDetPEM.DataSource = dt_AbonadoDetPEM
            dgvReportePEM.DataSource = Nothing
            dt_AbonadoDetPEM.Rows.Clear()
            Dim ListaAbonoPEM As List(Of EEAbonoPEM) = MantenimientosBL.Instancia.abonodetpemListarDetalleEnReportePEMXAbonDetFecha(0, dtpAbonFechaInicio.EditValue)
            If ListaAbonoPEM IsNot Nothing Then
                For Each fAbonoPEM As EEAbonoPEM In ListaAbonoPEM
                    dt_AbonadoDetPEM.LoadDataRow(New Object() {fAbonoPEM.LoAbonadoDetalle.AbonDetId,
                                                         fAbonoPEM.AbonId,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetNroCuota,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetFechaIni,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetFechaFin,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetFecPago,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetPagado,
                                                         fAbonoPEM.LoAbonadoDetalle.AbonDetImporte,
                                                         fAbonoPEM.LoAbonadoDetalle.OTgEstado.TgCodigo,
                                                         fAbonoPEM.LoAbonadoDetalle.OTgEstado.TgNombre,
                                                         fAbonoPEM.OPersona.Persona,
                                                         fAbonoPEM.OPersona.PerNDoc,
                                                         fAbonoPEM.OPersona.TgDocumento
                                    }, True)
                Next
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
        Me.gvAbonadoDetPEM.BestFitColumns()
        GridColumn6.Width = 110
        Me.tabReportes.SelectedTabPageIndex = 1
    End Sub

    Private Sub btnFechaIngreso_Click(sender As System.Object, e As System.EventArgs) Handles btnFechaIngreso.Click
        If dtpFechaIngreso.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Fecha Ingreso")
            dtpFechaIngreso.Focus()
            Exit Sub
        End If

        gcdiarioId.Visible = False

        gcAbonId.Visible = False
        gcAbonPlaca1.Visible = False
        gcAbonPlaca2.Visible = False
        gcAbonPlaca3.Visible = False
        gcAbonFechaIni.Visible = False
        gcAbonFechaFin.Visible = False
        gcAbonImporte.Visible = False
        gcAbonConcepto.Visible = False
        gcAbonPersona.Visible = False
        gcAbonTipoDoc.Visible = False
        gcAbonNroDoc.Visible = False


        gcdiarionroticket.Visible = True
        gcdiarioplaca.Visible = True
        gcdiariofecha.Visible = True
        gcdiariohoraE.Visible = True
        gcdiariohoras.Visible = True
        gcdiariomonto.Visible = True
        gcdiarioUsuarioId.Visible = True
        gcDiarioUsuario.Visible = True
        gcdiarioConId.Visible = True
        gcdiarioConcepto.Visible = True
        gcdiariofechaSal.Visible = True

        gcdiarionroticket.VisibleIndex = 0
        gcdiarioplaca.VisibleIndex = 1
        gcdiariofecha.VisibleIndex = 2
        gcdiariohoraE.VisibleIndex = 3
        gcdiariofechaSal.VisibleIndex = 4
        gcdiariohoras.VisibleIndex = 5
        gcdiariomonto.VisibleIndex = 6
        gcdiarioConcepto.VisibleIndex = 7
        gcdiarioConId.VisibleIndex = 8
        gcdiarioUsuarioId.VisibleIndex = 9
        gcDiarioUsuario.VisibleIndex = 10



        dt_diarioPEM.Rows.Clear()
        Dim PerId As String = String.Empty
        Dim Persona As String = String.Empty
        Dim Usuario As String = String.Empty

        Try
            dgvReportePEM.DataSource = dt_diarioPEM
            Dim ListaDiarioPEM As List(Of EEDiarioPEM) = MantenimientosBL.Instancia.diariopemReporteXFecha(0, dtpFechaIngreso.EditValue)
            If ListaDiarioPEM IsNot Nothing Then
                For Each frow As EEDiarioPEM In ListaDiarioPEM
                    If String.Compare(PerId, frow.PerRegId) <> 0 Then
                        Dim loPersona As EEPersona = MantenimientosBL.Instancia.MostrarPersonaUsuarioxPerId(frow.PerRegId)
                        If loPersona IsNot Nothing Then
                            PerId = frow.PerRegId
                            Persona = loPersona.Persona
                            Usuario = loPersona.Usuario
                        End If
                    End If
                    Dim horaEntrada As Date = frow.DiaHoraIng
                    Dim horaSalida As String = frow.DiaHoraSal
                    Dim horaSalida2 As Date? = frow.DiaHoraSal
                    horaSalida = IIf(Len(horaSalida.ToString) > 10, horaSalida.ToString.Substring(10), "")
                    If Len(horaSalida) > 0 Then
                        horaSalida2 = CDate(horaSalida)
                    Else
                        horaSalida2 = Nothing
                    End If
                    dt_diarioPEM.LoadDataRow(New Object() {frow.DiarioId, _
                                                         frow.DiarioCod, _
                                                         frow.DiaNPlaca, _
                                                         frow.DiaFechaIng, _
                                                         Format(horaEntrada, "HH:mm:ss"), _
                                                           IIf(horaSalida2 Is Nothing, "", Format(horaSalida2, "HH:mm:ss")), _
                                                         frow.DiaPrecio, _
                                                         Usuario, _
                                                         PerId, _
                                                         Persona, _
                                                         frow.loConcepto.ConId, _
                                                         frow.loConcepto.ConNombre, _
                                                         frow.DiaFechaSal
                                                         }, True)

                Next
            End If
            Me.gvReportePEM.BestFitColumns()
            gcdiariomonto.Width = 110
            gcAbonImporte.Width = 110
            Me.tabReportes.SelectedTabPageIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnFechaSalida_Click(sender As System.Object, e As System.EventArgs) Handles btnFechaSalida.Click
        If dtpFechaIngreso.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Fecha Salida")
            dtpFechaSalida.Focus()
            Exit Sub
        End If

        gcdiarioId.Visible = False

        gcAbonId.Visible = False
        gcAbonPlaca1.Visible = False
        gcAbonPlaca2.Visible = False
        gcAbonPlaca3.Visible = False
        gcAbonFechaIni.Visible = False
        gcAbonFechaFin.Visible = False
        gcAbonImporte.Visible = False
        gcAbonConcepto.Visible = False
        gcAbonPersona.Visible = False
        gcAbonTipoDoc.Visible = False
        gcAbonNroDoc.Visible = False


        gcdiarionroticket.Visible = True
        gcdiarioplaca.Visible = True
        gcdiariofecha.Visible = True
        gcdiariohoraE.Visible = True
        gcdiariohoras.Visible = True
        gcdiariomonto.Visible = True
        gcdiarioUsuarioId.Visible = True
        gcDiarioUsuario.Visible = True
        gcdiarioConId.Visible = True
        gcdiarioConcepto.Visible = True
        gcdiariofechaSal.Visible = True

        gcdiarionroticket.VisibleIndex = 0
        gcdiarioplaca.VisibleIndex = 1
        gcdiariofecha.VisibleIndex = 2
        gcdiariohoraE.VisibleIndex = 3
        gcdiariofechaSal.VisibleIndex = 4
        gcdiariohoras.VisibleIndex = 5
        gcdiariomonto.VisibleIndex = 6
        gcdiarioConcepto.VisibleIndex = 7
        gcdiarioConId.VisibleIndex = 8
        gcdiarioUsuarioId.VisibleIndex = 9
        gcDiarioUsuario.VisibleIndex = 10

        dt_diarioPEM.Rows.Clear()
        Dim PerId As String = String.Empty
        Dim Persona As String = String.Empty
        Dim Usuario As String = String.Empty

        Try
            dgvReportePEM.DataSource = dt_diarioPEM
            Dim ListaDiarioPEM As List(Of EEDiarioPEM) = MantenimientosBL.Instancia.diariopemReporteXFecha(1, dtpFechaIngreso.EditValue)
            If ListaDiarioPEM IsNot Nothing Then
                For Each frow As EEDiarioPEM In ListaDiarioPEM
                    If String.Compare(PerId, frow.PerRegId) <> 0 Then
                        Dim loPersona As EEPersona = MantenimientosBL.Instancia.MostrarPersonaUsuarioxPerId(frow.PerRegId)
                        If loPersona IsNot Nothing Then
                            PerId = frow.PerRegId
                            Persona = loPersona.Persona
                            Usuario = loPersona.Usuario
                        End If
                    End If
                    Dim horaEntrada As Date = frow.DiaHoraIng
                    Dim horaSalida As String = frow.DiaHoraSal
                    Dim horaSalida2 As Date? = frow.DiaHoraSal
                    horaSalida = IIf(Len(horaSalida.ToString) > 10, horaSalida.ToString.Substring(10), "")
                    If Len(horaSalida) > 0 Then
                        horaSalida2 = CDate(horaSalida)
                    Else
                        horaSalida2 = Nothing
                    End If
                    dt_diarioPEM.LoadDataRow(New Object() {frow.DiarioId, _
                                                         frow.DiarioCod, _
                                                         frow.DiaNPlaca, _
                                                         frow.DiaFechaIng, _
                                                         Format(horaEntrada, "HH:mm:ss"), _
                                                           IIf(horaSalida2 Is Nothing, "", Format(horaSalida2, "HH:mm:ss")), _
                                                         frow.DiaPrecio, _
                                                         Usuario, _
                                                         PerId, _
                                                         Persona, _
                                                         frow.loConcepto.ConId, _
                                                         frow.loConcepto.ConNombre, _
                                                         frow.DiaFechaSal
                                                         }, True)

                Next
            End If
            Me.gvReportePEM.BestFitColumns()
            gcdiariomonto.Width = 110
            gcAbonImporte.Width = 110
            Me.tabReportes.SelectedTabPageIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

   
    Private Sub btnExportarHoraFraccion_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarHoraFraccion.Click
        sfdExportar.Filter = "Archivo de Excel|*.xls"
        If sfdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            gvReportePEM.ExportToXlsx(sfdExportar.FileName)
        End If
    End Sub

    Private Sub btnExportarAbonos_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarAbonos.Click
        sfdExportar.Filter = "Archivo de Excel|*.xls"
        If sfdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            gvAbonadoDetPEM.ExportToXlsx(sfdExportar.FileName)

        End If
    End Sub
End Class