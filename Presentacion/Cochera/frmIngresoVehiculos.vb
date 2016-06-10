﻿Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmIngresoVehiculos
    Inherits frmGeneral
    Dim dt_conceptos As DataTable = New DataTable
    Dim dt_conceptos2 As DataTable = New DataTable
    Dim dt_diarioPEM As DataTable = New DataTable
    Private Property tgTipoAbonId As String = String.Empty
    Private Property AbonadoDetID As String = String.Empty
    Private Property AbonadoFechaVen As Date
    Dim xl As Excel.Application
    Dim loconcepto As List(Of EEConceptos) = Nothing
    Dim capacidadAutos As Integer
    Dim capacidadMotos As Integer
    Dim importLavado As Decimal = 0
    Dim MensajePrint As String = String.Empty
    Dim loPersona As List(Of EEPersona) = Nothing

    Private Sub ConstruirTableConceptos()
        dt_conceptos.Columns.Add("conId", GetType(String))
        dt_conceptos.Columns.Add("conNombre", GetType(String))
        dt_conceptos.Columns.Add("conGrupo", GetType(String))
        dt_conceptos.Columns.Add("conImporte", GetType(Decimal))
        dt_conceptos.Columns.Add("tgSubGrupoId", GetType(String))
        dt_conceptos.Columns.Add("ConIdConNombre", GetType(String))
    End Sub

    Private Sub ConstruirTableConceptos2()
        dt_conceptos2.Columns.Add("conId", GetType(String))
        dt_conceptos2.Columns.Add("conNombre", GetType(String))
        dt_conceptos2.Columns.Add("conGrupo", GetType(String))
        dt_conceptos2.Columns.Add("conImporte", GetType(Decimal))
        dt_conceptos2.Columns.Add("tgSubGrupoId", GetType(String))
        dt_conceptos2.Columns.Add("ConIdConNombre", GetType(String))

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
        dt_diarioPEM.Columns.Add("ConNombre", GetType(String))
    End Sub

    Private Sub frmIngresoVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableConceptos()
        ConstruirTableConceptos2()
        ConstruirTableDiarioPEM()
        dgvDiarioPEM.DataSource = dt_diarioPEM
        txtfecha.Text = Date.Now.ToShortDateString
        txtHora.Text = Date.Now.ToString("HH:mm")

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

        loconcepto = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupo(Date.Now.Year, "06")

        dt_conceptos2.Clear()
        Dim i As Int16 = 0
        For Each fConcepto As EEConceptos In loconcepto
            If i = 0 Then
                dt_conceptos2.LoadDataRow(New Object() {"S00002015", _
                  "LISTAR TODOS LOS CONCEPTOS", _
                  fConcepto.ConGrupo, _
                  fConcepto.ConImporte, _
                  fConcepto.TgSubGrupoId, _
                   "S0000 - LISTAR TODOS LOS CONCEPTOS"
                }, True)
                dt_conceptos2.LoadDataRow(New Object() {fConcepto.ConId, _
                  fConcepto.ConNombre, _
                  fConcepto.ConGrupo, _
                  fConcepto.ConImporte, _
                  fConcepto.TgSubGrupoId, _
                   fConcepto.ConIdConNombre
                }, True)
            Else
                dt_conceptos2.LoadDataRow(New Object() {fConcepto.ConId, _
                  fConcepto.ConNombre, _
                  fConcepto.ConGrupo, _
                  fConcepto.ConImporte, _
                  fConcepto.TgSubGrupoId, _
                   fConcepto.ConIdConNombre
                }, True)
            End If
            i = i + 1
        Next
        cboConcepto.mColumnas(SaimtComboBoxLookUp.Entidades.Concepto)
        cboConcepto.Properties.DisplayMember = "ConIdConNombre"
        cboConcepto.Properties.ValueMember = "conId"
        cboConcepto.Properties.DataSource = dt_conceptos
        cboConcepto.ItemIndex = 0

        cboConceptosBusquedas.mColumnas(SaimtComboBoxLookUp.Entidades.Concepto)
        cboConceptosBusquedas.Properties.DisplayMember = "ConIdConNombre"
        cboConceptosBusquedas.Properties.ValueMember = "conId"
        cboConceptosBusquedas.Properties.DataSource = dt_conceptos2
        cboConceptosBusquedas.ItemIndex = 0

        Dim loTablaGeneralAutos As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(103, "01")
        If loTablaGeneralAutos IsNot Nothing Then
            capacidadAutos = loTablaGeneralAutos.Item(0).TgExtra
        End If
        Dim loTablaGeneralMotos As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(103, "02")
        If loTablaGeneralMotos IsNot Nothing Then
            capacidadMotos = loTablaGeneralMotos.Item(0).TgExtra
        End If

        Dim lotablageneralMensaje As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId(158)
        If lotablageneralMensaje IsNot Nothing Then
            MensajePrint = lotablageneralMensaje.Item(0).TgDescripcion.ToUpper
        End If
        loPersona = MantenimientosBL.Instancia.MostrarPersonaUsuario()
        txtcapacidadIN.Text = MantenimientosBL.Instancia.diariopemMostrarCapacidadXtgTipoVehiculoId(cboTipoVehiculo.EditValue)
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
                If fConcepto("conId").ToString.Contains("S049") = True Then
                    conImporte = fConcepto("conImporte")
                Else
                    conImporte = 0
                End If
                importLavado = conImporte
                tgSubGrupoId = fConcepto("tgSubGrupoId")
                selectConc = True
            End If
        Next
        If selectConc = False Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Concepto")
            cboConcepto.Focus()
            Return
        End If

        ' Si es lavado de auto
        If cboConcepto.EditValue.Contains("S049") = True Then

            Dim loDiarioPEM As New EEDiarioPEM() With {.TgEstadoId = "02", .TgTipoAbonoId = tgTipoAbonId, .AbonDetId = AbonadoDetID, .ConId = cboConcepto.EditValue, .DiaFechaIng = Date.Now, .DiaFechaSal = Date.Now, .DiaHoraIng = Date.Now, .DiaHoraSal = Date.Now, .DiaNPlaca = txtplaca.Text, .DiaPrecio = conImporte, .DiarioId = 0, .DiarioCod = "", .PerRegId = EEComun._PerId, .PerRegSalId = EEComun._PerId}
            Dim NroTicket As String = MantenimientosBL.Instancia.diariopemGuardar(loDiarioPEM)
            If String.Compare(NroTicket, "", True) <> 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("El servicio adicional al vehículo se registro correctamente")
                Try
                    xl = EEExcel.Instancia
                    If File.Exists(My.Application.Info.DirectoryPath & "\RepositorioReportes\RptTicketLavado.xls") Then
                        xl.Workbooks.Open(My.Application.Info.DirectoryPath & "\RepositorioReportes\RptTicketLavado.xls", 1, True, 4)
                    Else
                        xl.Workbooks.Open(EEComun.RutaReportes & "\RptTicketLavado.xls", 1, True, 4)
                    End If

                    ImprimirTikectLavado(NroTicket)

                    chkSinPlaca.Checked = False
                Catch ex As Exception
                    SaimtMessageBox.mostrarAlertaError(ex.Message)
                End Try
             
                txtplaca.Text = ""
                txtplaca.Focus()
            End If

        Else

            Dim ExisteloDiarioPEM As EEDiarioPEM = MantenimientosBL.Instancia.diariopemMostrarXtgEstadoIdXdiaNPlaca("01", txtplaca.Text)
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
            Dim loDiarioPEM As New EEDiarioPEM() With {.TgEstadoId = "01", .TgTipoAbonoId = tgTipoAbonId, .AbonDetId = AbonadoDetID, .ConId = cboConcepto.EditValue, .DiaFechaIng = Date.Now, .DiaHoraIng = Date.Now, .DiaNPlaca = txtplaca.Text, .DiaPrecio = conImporte, .DiarioId = 0, .DiarioCod = "", .PerRegId = EEComun._PerId}
            Dim NroTicket As String = MantenimientosBL.Instancia.diariopemGuardar(loDiarioPEM)
            If String.Compare(NroTicket, "", True) <> 0 Then
                If tgTipoAbonId <> "01" Then
                    SaimtMessageBox.mostrarAlertaInformativa("Se registro correctamente el Ingreso del vehículo")
                    Try
                        xl = EEExcel.Instancia

                        If File.Exists(My.Application.Info.DirectoryPath & "\RepositorioReportes\RptTicketIngreso.xls") Then
                            xl.Workbooks.Open(My.Application.Info.DirectoryPath & "\RepositorioReportes\RptTicketIngreso.xls", 1, True, 4)
                        Else
                            xl.Workbooks.Open(EEComun.RutaReportes & "\RptTicketIngreso.xls", 1, True, 4)
                        End If

                        ImprimirTikect(NroTicket)

                        chkSinPlaca.Checked = False
                    Catch ex As Exception
                        SaimtMessageBox.mostrarAlertaError(ex.Message)
                    End Try
                Else ' eS ABONADO
                    SaimtMessageBox.mostrarAlertaInformativa(String.Format("Se registro correctamente el Ingreso del vehículo, La fecha de vencimiento es {0} le quedan:{1}", AbonadoFechaVen, DateDiff(DateInterval.Day, Date.Now, AbonadoFechaVen)))
                End If
                txtplaca.Text = ""
                txtplaca.Focus()
            End If
        End If
        ' EEComun.CloseAllExcel(xl)
    End Sub
    Sub ImprimirTikectLavado(ByVal NroTicket As String)
        xl.Sheets(xl.Worksheets("TicketLavado").Index).Select()
        xl.Range("B3").Value = "OTROS SERVICIOS - " & Date.Now.ToShortDateString
        xl.Range("A5").Value = "RUC. 20481297223 - " & EEComun.Usuario
        '  xl.Cells(5, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        ' xl.Cells(5, 1).Resize(1, 4).MergeCells = True
        xl.Range("C6").Value = "'" & NroTicket
        '  xl.Range("B10").Value = "'" & NroTicket
        xl.Range("A7").Value = cboConcepto.Text
        xl.Range("B8").Value = txtplaca.Text.ToUpper
        xl.Range("B9").Value = Date.Now.ToString("HH:mm:ss")
        xl.Range("D8").Value = "'" & Date.Now.ToShortDateString
        xl.Range("D9").Value = CDec(importLavado)
        ' Dim lotablageneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId(158)
        ' If lotablageneral IsNot Nothing Then
        xl.Range("A11").Value = MensajePrint
        'End If
        xl.ActiveSheet.Protect("GeneralX2011", True, True)

        xl.ActiveWindow.Zoom = 130
        xl.Application.Visible = True
        xl.Application.WindowState = Excel.XlWindowState.xlMaximized
        xl.ActiveWorkbook.PrintOutEx(1, 1, 1, False, xl.ActivePrinter, False, False, "", False)
        EEComun.CloseAllExcel(xl)
    End Sub

    Sub ImprimirTikect(ByVal NroTicket As String)
        xl.Sheets(xl.Worksheets("TicketIngreso").Index).Select()
        xl.Range("B3").Value = "INGRESO - " & Date.Now.ToShortDateString
        xl.Cells(5, 1).Value = "RUC. 20481297223 - " & EEComun.Usuario
        xl.Cells(5, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(5, 1).Resize(1, 4).MergeCells = True
        xl.Range("C6").Value = "'" & NroTicket
        xl.Range("A7").Value = cboConcepto.Text
        xl.Range("B8").Value = txtplaca.Text.ToUpper
        xl.Range("D8").Value = Date.Now.ToString("HH:mm:ss")
        xl.Range("A9").Value = String.Format("*{0}*", NroTicket)
        xl.Range("A10").Value = MensajePrint
        xl.ActiveSheet.Protect("GeneralX2011", True, True)

        xl.ActiveWindow.Zoom = 130
        xl.Application.Visible = True
        xl.Application.WindowState = Excel.XlWindowState.xlMaximized
        xl.ActiveWorkbook.PrintOutEx(1, 1, 1, False, xl.ActivePrinter, False, False, "", False)
        EEComun.CloseAllExcel(xl)
    End Sub
    Private Sub txtplaca_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtplaca.EditValueChanged
        If txtplaca.Text IsNot Nothing Then
            If txtplaca.Text.Length >= 6 Then
                Dim loAbonoPEM As EEAbonoPEM = MantenimientosBL.Instancia.abonopemMostrarAbonadoActivoXabonNPlaca(txtplaca.Text)
                lblMensajeAbonado.Text = String.Empty
                If loAbonoPEM IsNot Nothing Then
                    If loAbonoPEM.OTgEstado.TgCodigo = "02" Then
                        tgTipoAbonId = "01"
                    Else
                        tgTipoAbonId = "02"
                        lblMensajeAbonado.Text = "Abonado : Pendiente de Activación :" & loAbonoPEM.AbonFechaIni & "-" & loAbonoPEM.AbonFechaFin
                        txtplaca.Text = String.Empty
                        txtplaca.Focus()
                        SaimtMessageBox.mostrarAlertaAdvertencia(lblMensajeAbonado.Text)
                    End If

                Else
                    tgTipoAbonId = "02"
                End If

                dt_conceptos.Clear()
                For Each fConcepto As EEConceptos In loconcepto
                    If tgTipoAbonId = "02" Then
                        If fConcepto.ConId.IndexOf("0059") > 0 Or fConcepto.ConId.IndexOf("0055") > 0 Or fConcepto.ConId.IndexOf("049") > 0 Then
                            dt_conceptos.LoadDataRow(New Object() {fConcepto.ConId, _
                                        fConcepto.ConNombre, _
                                        fConcepto.ConGrupo, _
                                        fConcepto.ConImporte, _
                                        fConcepto.TgSubGrupoId, _
                                         fConcepto.ConIdConNombre
                                      }, True)
                        End If
                    Else
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

                If loAbonoPEM IsNot Nothing Then
                    AbonadoDetID = loAbonoPEM.LoAbonadoDetalle.AbonDetId
                    AbonadoFechaVen = loAbonoPEM.AbonFechaFin
                    cboConcepto.EditValue = loAbonoPEM.OConcepto.ConId
                    cboConcepto.Properties.ReadOnly = True
                Else
                    AbonadoDetID = Nothing
                    cboConcepto.Properties.ReadOnly = False
                    cboConcepto.ItemIndex = 0
                End If

                For Each fConcepto As DataRow In dt_conceptos.Rows
                    If fConcepto("conId") = cboConcepto.EditValue Then
                        cboTipoVehiculo.EditValue = fConcepto("tgSubGrupoId")
                        Exit For
                    End If
                Next

            End If
        End If

    End Sub

    Private Sub cboTipoVehiculo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVehiculo.EditValueChanged
        If cboTipoVehiculo.EditValue IsNot Nothing Then
            If cboTipoVehiculo.EditValue = "01" Then
                txtCapacidad.Text = capacidadAutos
            ElseIf cboTipoVehiculo.EditValue = "02" Then
                txtCapacidad.Text = capacidadMotos
            Else
                txtCapacidad.Text = 0
            End If
            txtcapacidadIN.Text = MantenimientosBL.Instancia.diariopemMostrarCapacidadXtgTipoVehiculoId(cboTipoVehiculo.EditValue)
            txtCapacidadDisponible.Text = Val(txtCapacidad.Text) - Val(txtcapacidadIN.Text)
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            dt_diarioPEM.Rows.Clear()
            Dim PerId As String = String.Empty
            Dim Persona As String = String.Empty
            Dim Usuario As String = String.Empty
            Dim ListaDiarioPEM As List(Of EEDiarioPEM) = MantenimientosBL.Instancia.diariopemListarXtgEstadoIdXconId(cboEstados.EditValue, cboConceptosBusquedas.EditValue)
            If ListaDiarioPEM IsNot Nothing Then
                For Each frow As EEDiarioPEM In ListaDiarioPEM
                    If loPersona IsNot Nothing Then
                        For Each rowp As EEPersona In loPersona
                            If frow.PerRegId = rowp.PerId Then
                                PerId = rowp.PerId
                                Persona = rowp.Persona
                                Usuario = rowp.Usuario
                            End If
                        Next
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
                                                         Persona, frow.loConcepto.ConNombre
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

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        sfdExportar.Filter = "Archivo de Excel (*.xls)|*.xls"
        If sfdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            gvDiarioPEM.ExportToXls(sfdExportar.FileName)
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If gvDiarioPEM.SelectedRowsCount > 0 Then
            Me.btnImprimir.Enabled = False
            Try
                xl = EEExcel.Instancia

                If File.Exists(My.Application.Info.DirectoryPath & "\RepositorioReportes\RptTicketIngreso.xls") Then
                    xl.Workbooks.Open(My.Application.Info.DirectoryPath & "\RepositorioReportes\RptTicketIngreso.xls", 1, True, 4)
                Else
                    xl.Workbooks.Open(EEComun.RutaReportes & "\RptTicketIngreso.xls", 1, True, 4)
                End If

                xl.Sheets(xl.Worksheets("TicketIngreso").Index).Select()
                xl.Range("B3").Value = "INGRESO - " & gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaFechaIng")
                xl.Cells(5, 1).Value = "RUC. 20481297223 - " & EEComun.Usuario
                xl.Cells(5, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Cells(5, 1).Resize(1, 4).MergeCells = True
                xl.Range("C6").Value = "'" & gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diarioCod")
                xl.Range("A7").Value = cboConceptosBusquedas.Text
                xl.Range("B8").Value = gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaNPlaca")
                xl.Range("D8").Value = gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaHoraIng")
                xl.Range("A9").Value = String.Format("*{0}*", gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diarioCod"))
     
                    xl.Range("A10").Value = MensajePrint

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

    Private Sub txtplaca_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtplaca.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnOK.PerformClick()
        End If
    End Sub

    Private Sub cboConcepto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.EditValueChanged
        Try
            cboTipoVehiculo.EditValue = IIf(cboConcepto.Text.IndexOf("MOTO") > 0, "01", "02")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDiarioPEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDiarioPEM.Click

    End Sub
End Class