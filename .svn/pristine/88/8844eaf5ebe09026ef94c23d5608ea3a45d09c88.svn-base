Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop

Public Class frmParqueoRinconada
    Inherits frmGeneral
    Dim dt_conceptos As DataTable = New DataTable
    Dim dt_diarioPEM As DataTable = New DataTable
    Dim loconcepto As List(Of EEConceptos) = Nothing

    Private Property tgTipoAbonId As String = String.Empty
    Private Property AbonadoDetID As String = String.Empty
    Private Property AbonadoFechaVen As Date
    Dim DescripcionTickec As String = String.Empty
    Dim IsAdministrador As Boolean = False
    Dim xl As Excel.Application

    Private Sub ConstruirTableConceptos()
        dt_conceptos.Columns.Add("conId", GetType(String))
        dt_conceptos.Columns.Add("conNombre", GetType(String))
        dt_conceptos.Columns.Add("conGrupo", GetType(String))
        dt_conceptos.Columns.Add("conImporte", GetType(Decimal))
        dt_conceptos.Columns.Add("tgSubGrupoId", GetType(String))
        dt_conceptos.Columns.Add("ConIdConNombre", GetType(String))

    End Sub

    Private Sub ConstruirTableDiarioPEM()
        dt_diarioPEM.Columns.Add("diarioId", GetType(String))
        dt_diarioPEM.Columns.Add("diarioCod", GetType(String))
        dt_diarioPEM.Columns.Add("diaNPlaca", GetType(String))
        dt_diarioPEM.Columns.Add("diaFechaIng", GetType(Date))
        dt_diarioPEM.Columns.Add("diaFechaSal", GetType(Date))
        dt_diarioPEM.Columns.Add("diaHoraIng", GetType(String))
        dt_diarioPEM.Columns.Add("diaHoraSal", GetType(String))
        dt_diarioPEM.Columns.Add("diaPrecio", GetType(String))
        dt_diarioPEM.Columns.Add("tgTipoAbonoId", GetType(String))
        dt_diarioPEM.Columns.Add("tgTipoAbono", GetType(String))
        dt_diarioPEM.Columns.Add("usuario", GetType(String))
        dt_diarioPEM.Columns.Add("perId", GetType(String))
        dt_diarioPEM.Columns.Add("persona", GetType(String))
    End Sub

    Private Sub frmIngresoVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableConceptos()
        ConstruirTableDiarioPEM()
        dgvDiarioPEM.DataSource = dt_diarioPEM
        txtfecha.Text = Date.Now.ToShortDateString
        txtHora.Text = Date.Now.ToString("HH:mm")

        loconcepto = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupo(Date.Now.Year, "08")
        dt_conceptos.Clear()
        For Each fConcepto As EEConceptos In loconcepto
            '    ' If tgTipoAbonId = "02" Then
            If fConcepto.TgSubGrupoId = "02" Then
                dt_conceptos.LoadDataRow(New Object() {fConcepto.ConId, _
                            fConcepto.ConNombre, _
                            fConcepto.ConGrupo, _
                            fConcepto.ConImporte, _
                            fConcepto.TgSubGrupoId, _
                             fConcepto.ConIdConNombre
                          }, True)
            End If
        Next

        cboConcepto.mColumnas(SaimtComboBoxLookUp.Entidades.Concepto)
        cboConcepto.Properties.DisplayMember = "ConIdConNombre"
        cboConcepto.Properties.ValueMember = "conId"
        cboConcepto.Properties.DataSource = dt_conceptos
        cboConcepto.ItemIndex = 0

        cboConceptosBusquedas.mColumnas(SaimtComboBoxLookUp.Entidades.Concepto)
        cboConceptosBusquedas.Properties.DisplayMember = "ConIdConNombre"
        cboConceptosBusquedas.Properties.ValueMember = "conId"
        cboConceptosBusquedas.Properties.DataSource = dt_conceptos
        cboConceptosBusquedas.ItemIndex = 0

        cboEstados.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstados.Properties.DisplayMember = "TgNombre"
        cboEstados.Properties.ValueMember = "TgCodigo"
        cboEstados.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(157)
        cboEstados.ItemIndex = 0


        cboTipoVehiculo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoVehiculo.Properties.DisplayMember = "TgNombre"
        cboTipoVehiculo.Properties.ValueMember = "TgCodigo"
        cboTipoVehiculo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(103)
        cboTipoVehiculo.ItemIndex = 0
        txtcapacidadIN.Text = MantenimientosBL.Instancia.diarioRinconadaMostrarCapacidadXtgTipoVehiculoId(cboTipoVehiculo.EditValue)

        Dim lotablageneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId(158)
        If lotablageneral IsNot Nothing Then
            DescripcionTickec = lotablageneral.Item(0).TgDescripcion.ToUpper
        End If
        Dim loAdministrado As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(200, EEComun._PerId)
        If loAdministrado IsNot Nothing Then
            IsAdministrador = True
            btnImprimir.Visible = True
        Else
            IsAdministrador = True
            btnImprimir.Visible = False
        End If
        tmhora.Enabled = True

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtplaca.Text IsNot Nothing Or txtplaca.Text <> "" Then
            If txtplaca.Text.Length < 6 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("La Placa debe tener de 6 a 8 caracteres")
                txtplaca.Focus()
                Return
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese la Placa del Vehiculo")
            txtplaca.Focus()
            Return
        End If

        'Importe 
        Dim selectConc As Boolean = False
        Dim conImporte As Decimal = 0
        Dim tgSubGrupoId As String = String.Empty
        For Each fConcepto As DataRow In dt_conceptos.Rows
            If fConcepto("conId") = cboConcepto.EditValue Then
                conImporte = 0 'Val(fConcepto("conImporte"))
                tgSubGrupoId = fConcepto("tgSubGrupoId")
                selectConc = True
            End If
        Next
        If selectConc = False Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Concepto")
            cboConcepto.Focus()
            Return
        End If
        Dim ExisteloDiarioPEM As EEDiarioPEM = MantenimientosBL.Instancia.diarioRinconadaMostrarXtgEstadoIdXdiaNPlaca("01", txtplaca.Text)
        'validar que el carro este adentro
        If ExisteloDiarioPEM IsNot Nothing Then
            ' If String.Compare(ExisteloDiarioPEM.DiaNPlaca, txtplaca.Text, True) = 0 Then
            If ExisteloDiarioPEM.AbonDetId = Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia(String.Format("El Vehiculo aun se encuentra adentro, ingreso el día {0} {1}", Format(ExisteloDiarioPEM.DiaFechaIng, "dd/MM/yyyy"), ExisteloDiarioPEM.DiaHoraIng.ToString.Substring(10)))
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia(String.Format("El Vehiculo " & ExisteloDiarioPEM.DiaNPlaca & " aun se encuentra adentro, ingreso el día {0} {1} y pertenece al mismo abonado con Placa " & txtplaca.Text & " ", Format(ExisteloDiarioPEM.DiaFechaIng, "dd/MM/yyyy"), ExisteloDiarioPEM.DiaHoraIng.ToString.Substring(10)))
            End If

            Return
        End If

        'Verificar si es abonado
        Dim DiaCodigo As String = MantenimientosBL.Instancia.diarioRinconadaGenerarDiaCodigo
        Dim loDiarioPEM As New EEDiarioPEM() With {.TgEstadoId = "01", .TgTipoAbonoId = tgTipoAbonId, .ConId = cboConcepto.EditValue, .DiaFechaIng = Date.Now, .DiaHoraIng = Date.Now, .DiaNPlaca = txtplaca.Text, .DiaPrecio = conImporte, .DiarioId = 0, .DiarioCod = DiaCodigo, .PerRegId = EEComun._PerId}
        Dim NroTicket As String = DiaCodigo
        If String.Compare(NroTicket, "", True) <> 0 And MantenimientosBL.Instancia.diarioRinconadaGuardar(loDiarioPEM) = True Then
            'If tgTipoAbonId = "02" Then
            SaimtMessageBox.mostrarAlertaInformativa("Se registro correctamente el Ingreso del vehículo")
            Try
                xl = EEExcel.Instancia
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptTicketIngreso.xls", 1, True, 4)
                ImprimirTikect(NroTicket)
                cboTipoVehiculo_EditValueChanged(Nothing, Nothing)
                chkSinPlaca.Checked = False
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaError(ex.Message)
            End Try
            'Else ' eS ABONADO
            '  SaimtMessageBox.mostrarAlertaInformativa(String.Format("Se registro correctamente el Ingreso del vehículo, La fecha de vencimiento es {0} le quedan:{1}", AbonadoFechaVen, DateDiff(DateInterval.Day, Date.Now, AbonadoFechaVen)))
            'End If
            txtplaca.Text = ""
            txtplaca.Focus()
        End If
        ' EEComun.CloseAllExcel(xl)
    End Sub
    Sub ImprimirTikect(ByVal NroTicket As String)
        xl.Sheets(xl.Worksheets("TicketIngreso").Index).Select()
        xl.Range("B4").Value = "'" & NroTicket
        xl.Range("A5").Value = cboConcepto.Text
        xl.Range("B6").Value = txtplaca.Text.ToUpper
        xl.Range("B7").Value = Date.Now.ToShortDateString
        xl.Range("B7").NumberFormat = "dd/mm/yyyy"
        xl.Range("B8").Value = Date.Now.ToString("HH:mm:ss")
        xl.Range("A9").Value = DescripcionTickec.ToUpper
        xl.ActiveSheet.Protect("GeneralX2011", True, True)
        xl.ActiveWindow.Zoom = 130
        xl.Application.Visible = False
        xl.Application.WindowState = Excel.XlWindowState.xlMaximized
        xl.ActiveWorkbook.PrintOutEx(1, 1, 1, False, xl.ActivePrinter, False, False, "", False)
        EEComun.CloseAllExcel(xl)
    End Sub
    Private Sub txtplaca_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtplaca.EditValueChanged
        If txtplaca.Text IsNot Nothing Then
            If txtplaca.Text.Length >= 6 Then
                'Dim loVehiculo As EEVehiculoPEM = MantenimientosBL.Instancia.vehiculopemMostrarTgTipoVehIdXVehNPlaca(txtplaca.Text)
                '  If loVehiculo IsNot Nothing Then
                'loconcepto = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupoXTgSubGrupo(Date.Now.Year, "06", loVehiculo.TgTipoVehId)
                'Else

                '  End If

                'Dim loAbonoPEM As EEAbonoPEM = MantenimientosBL.Instancia.abonopemMostrarAbonadoActivoXabonNPlaca(txtplaca.Text)
                'If loAbonoPEM IsNot Nothing Then
                '    tgTipoAbonId = "01"
                'Else
                tgTipoAbonId = "02"
                'End If

                'dt_conceptos.Clear()
                'For Each fConcepto As EEConceptos In loconcepto
                '    ' If tgTipoAbonId = "02" Then
                '    ' If fConcepto.ConId.IndexOf("0007") > 0 Or fConcepto.ConId.IndexOf("0006") > 0 Then
                '    dt_conceptos.LoadDataRow(New Object() {fConcepto.ConId, _
                '                fConcepto.ConNombre, _
                '                fConcepto.ConGrupo, _
                '                fConcepto.ConImporte, _
                '                fConcepto.TgSubGrupoId, _
                '                 fConcepto.ConIdConNombre
                '              }, True)
                '    '  End If
                '    '       Else
                '    '       dt_conceptos.LoadDataRow(New Object() {fConcepto.ConId, _
                '    '  fConcepto.ConNombre, _
                '    '  fConcepto.ConGrupo, _
                '    '  fConcepto.ConImporte, _
                '    '  fConcepto.TgSubGrupoId, _
                '    '   fConcepto.ConIdConNombre
                '    '}, True)
                '    '       End If

                'Next
           

                'If loAbonoPEM IsNot Nothing Then
                '    AbonadoDetID = loAbonoPEM.LoAbonadoDetalle.AbonDetId
                '    AbonadoFechaVen = loAbonoPEM.AbonFechaFin
                '    cboConcepto.EditValue = loAbonoPEM.OConcepto.ConId
                '    cboConcepto.Properties.ReadOnly = True
                'Else
                'AbonadoDetID = Nothing
                cboConcepto.Properties.ReadOnly = False
                'End If

                For Each fConcepto As DataRow In dt_conceptos.Rows
                    If fConcepto("conId") = cboConcepto.EditValue Then
                        cboTipoVehiculo.EditValue = fConcepto("tgSubGrupoId")
                        Exit For
                    End If
                Next
                'ElseIf txtplaca.Text.Length = 8 Then

                '    Dim loconcepto As List(Of EEConceptos)
                '    loconcepto = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupo(Date.Now.Year, "06")
                '    tgTipoAbonId = "02"
                '    dt_conceptos.Clear()
                '    For Each fConcepto As EEConceptos In loconcepto
                '        If tgTipoAbonId = "02" Then
                '            If fConcepto.ConId.IndexOf("0007") > 0 Or fConcepto.ConId.IndexOf("0006") > 0 Then
                '                dt_conceptos.LoadDataRow(New Object() {fConcepto.ConId, _
                '                            fConcepto.ConNombre, _
                '                            fConcepto.ConGrupo, _
                '                            fConcepto.ConImporte, _
                '                            fConcepto.TgSubGrupoId, _
                '                             fConcepto.ConIdConNombre
                '                          }, True)
                '            End If
                '        Else
                '            dt_conceptos.LoadDataRow(New Object() {fConcepto.ConId, _
                '       fConcepto.ConNombre, _
                '       fConcepto.ConGrupo, _
                '       fConcepto.ConImporte, _
                '       fConcepto.TgSubGrupoId, _
                '        fConcepto.ConIdConNombre
                '     }, True)
                '        End If

                '    Next
                '    cboConcepto.mColumnas(SaimtComboBoxLookUp.Entidades.Concepto)
                '    cboConcepto.Properties.DisplayMember = "ConIdConNombre"
                '    cboConcepto.Properties.ValueMember = "conId"
                '    cboConcepto.Properties.DataSource = dt_conceptos
                '    cboConcepto.ItemIndex = 0

                '    AbonadoDetID = Nothing
                '    cboConcepto.Properties.ReadOnly = False

                '    For Each fConcepto As DataRow In dt_conceptos.Rows
                '        If fConcepto("conId") = cboConcepto.EditValue Then
                '            cboTipoVehiculo.EditValue = fConcepto("tgSubGrupoId")
                '            Exit For
                '        End If
                '    Next

            End If
        End If

    End Sub

    Private Sub cboTipoVehiculo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVehiculo.EditValueChanged
        If cboTipoVehiculo.EditValue IsNot Nothing Then
            Dim loTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(103, cboTipoVehiculo.EditValue)
            If loTablaGeneral IsNot Nothing Then
                txtCapacidad.Text = loTablaGeneral.Item(0).TgExtra
                txtcapacidadIN.Text = MantenimientosBL.Instancia.diarioRinconadaMostrarCapacidadXtgTipoVehiculoId(cboTipoVehiculo.EditValue)
                txtCapacidadDisponible.Text = Val(txtCapacidad.Text) - Val(txtcapacidadIN.Text)
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            dt_diarioPEM.Rows.Clear()
            Dim PerId As String = String.Empty
            Dim Persona As String = String.Empty
            Dim Usuario As String = String.Empty
            Dim ListaDiarioPEM As List(Of EEDiarioPEM) = MantenimientosBL.Instancia.diarioRinconadaListarXtgEstadoIdXconId(cboEstados.EditValue, cboConceptosBusquedas.EditValue)
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
                                                         frow.DiaFechaSal, _
                                                         Format(horaEntrada, "HH:mm:ss"), _
                                                         IIf(horaSalida2 Is Nothing, "", Format(horaSalida2, "HH:mm:ss")), _
                                                         frow.DiaPrecio, _
                                                         frow.TgTipoAbonoId, _
                                                         frow.TgTipoAbono, _
                                                         Usuario, _
                                                         PerId, _
                                                         Persona
                                                         }, True)

                Next
            End If
            Me.GridColumn6.Width = 110
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub tmhora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmhora.Tick
        txtfecha.Text = Date.Now.ToShortDateString
        txtHora.Text = Date.Now.ToString("HH:mm")
    End Sub

    Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click
        sfdExportar.Filter = "Archivo de Excel|*.xls"
        If sfdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            gvDiarioPEM.ExportToXls(sfdExportar.FileName)
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If gvDiarioPEM.SelectedRowsCount > 0 Then
            Me.btnImprimir.Enabled = False
            Try
                xl = EEExcel.Instancia
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptTicketIngreso.xls", 1, True, 4)
                xl.Sheets(xl.Worksheets("TicketIngreso").Index).Select()
                xl.Range("B4").Value = "'" & gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diarioCod")
                xl.Range("A5").Value = cboConceptosBusquedas.Text
                xl.Range("B6").Value = gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaNPlaca")
                xl.Range("B7").Value = gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaFechaIng")
                xl.Range("B7").NumberFormat = "dd/mm/yyyy"
                xl.Range("B8").Value = gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaHoraIng")
                Dim lotablageneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId(158)
                If lotablageneral IsNot Nothing Then
                    xl.Range("A10").Value = lotablageneral.Item(0).TgDescripcion.ToUpper
                End If
                xl.ActiveSheet.Protect("GeneralX2011", True, True)
                xl.ActiveWindow.Zoom = 130
                xl.Application.Visible = True
                xl.Application.WindowState = Excel.XlWindowState.xlMaximized
                xl.ActiveWorkbook.PrintOutEx(1, 1, 1, False, xl.ActivePrinter, False, False, "", False)
                EEComun.CloseAllExcel(xl)
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaError(ex.Message)
            End Try
            Me.btnImprimir.Enabled = True
        End If

    End Sub

    Private Sub txtplaca_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtplaca.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnOK.PerformClick()
        End If
    End Sub

    'Private Sub chkSinPlaca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSinPlaca.CheckedChanged

    '    'If chkSinPlaca.Checked = True Then
    '    '    txtplaca.Properties.MaxLength = 8
    '    'Else
    '    '    txtplaca.Properties.MaxLength = 6
    '    'End If
    'End Sub

    Private Sub cboConcepto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.EditValueChanged
        Try
            cboTipoVehiculo.EditValue = IIf(cboConcepto.Text.IndexOf("MOTO") > 0, "01", "02")
        Catch ex As Exception

        End Try
    End Sub
 
End Class