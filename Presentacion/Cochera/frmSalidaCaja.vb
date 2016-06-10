﻿Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmSalidaCaja
    Inherits frmGeneral
    Dim dt_conceptos As DataTable = New DataTable
    Dim loconcepto As List(Of EEConceptos) = Nothing
    Dim dt_diarioPEM As DataTable = New DataTable
    Private tolerancia As Integer = 8
    Private Property tgTipoAbonId As String = String.Empty
    Private Property AbonadoID As String = String.Empty
    Dim xl As Excel.Application
    Dim HoraIng As String = String.Empty
    Dim DiaIng As Date = Nothing
    Dim placa As String = String.Empty
    Dim placaTemp As String = String.Empty
    Dim mensajePrint As String = String.Empty
    Dim loPersona As List(Of EEPersona) = Nothing

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
        dt_diarioPEM.Columns.Add("concepto", GetType(String))
        dt_diarioPEM.Columns.Add("conId", GetType(String))

    End Sub

    Sub guardar()
        Dim loDiarioPEM As New EEDiarioPEM() With {.TgEstadoId = "02", .DiaFechaSal = Date.Now, .DiaHoraSal = Date.Now, .DiaPrecio = txtmonto.Text, .DiarioId = txtplaca.Tag, .PerRegId = EEComun._PerId}
        Dim NroTicket As String = MantenimientosBL.Instancia.diariopemGuardar(loDiarioPEM)
        If String.Compare(NroTicket, "", True) <> 0 Then
            SaimtMessageBox.mostrarAlertaInformativa("El Vehiculo puede salir de la cochera")
            If tgTipoAbonId <> "01" Then
                Try
                    xl = EEExcel.Instancia
                    If File.Exists(My.Application.Info.DirectoryPath & "\RepositorioReportes\RptTicketSalida2.xls") = True Then
                        xl.Workbooks.Open(My.Application.Info.DirectoryPath & "\RepositorioReportes\RptTicketSalida2.xls", 1, True, 4)
                    Else
                        xl.Workbooks.Open(EEComun.RutaReportes & "\RptTicketSalida2.xls", 1, True, 4)
                    End If
                    If SaimtMessageBox.mostrarAlertaPregunta(String.Format("¿Deseas mandar a imprimir el ticket {0} ?", NroTicket)) Then
                        ImprimirTikect(NroTicket)
                    End If
                Catch ex As Exception
                    SaimtMessageBox.mostrarAlertaError(ex.Message)
                End Try
            End If
            txtconcepto.EditValue = Nothing
            txtconcepto.Tag = Nothing
            txtmonto.Text = Nothing

        End If
    End Sub

    Private Sub btnOKPlaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKPlaca.Click

        If txtplaca.Text IsNot Nothing Or txtplaca.Text <> "" Then
            If txtplaca.Text.Length < 6 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("La Placa debe tener 6 a 8 caracteres")
                txtplaca.Focus()
                Return
            Else
                If txtplaca.Tag Is Nothing Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("El Vehiculo no ha ingresado aun")
                    SaimtLabel1.ForeColor = Color.Red
                    txtplaca.Focus()
                    txtconcepto.Text = Nothing
                    txtconcepto.Tag = Nothing
                    txtmonto.Text = Nothing
                    Return
                End If
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese la Placa del Vehiculo")
            txtplaca.Focus()
            Return
        End If

        guardar()
        txtplaca.Text = Nothing

    End Sub



    Private Sub txtplaca_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtplaca.TextChanged
        If txtplaca.Text IsNot Nothing Then
            SaimtLabel1.ForeColor = Color.SteelBlue
            If txtplaca.Text.Length >= 6 Then
                Dim loDiario As EEDiarioPEM = MantenimientosBL.Instancia.diariopemMostrarDatosIngresoXdiaNPlaca(txtplaca.Text)
                Dim diaInicio As Date
                If loDiario IsNot Nothing Then
                    diaInicio = loDiario.DiaFechaIng
                    txtconcepto.Text = loDiario.loConcepto.ConNombre
                    txtconcepto.Tag = loDiario.loConcepto.ConId
                    Dim mn As Integer = 0
                    Dim rs As Integer = 0
                    Dim horas As Integer = 0
                    'Dim dia As Integer = 0
                    HoraIng = diaInicio.ToString("HH:mm:ss")
                    DiaIng = diaInicio.ToShortDateString
                    placa = txtplaca.Text
                    mn = DateDiff(DateInterval.Minute, diaInicio, Date.Now)
                    rs = mn Mod 60
                    If rs = mn Then
                        horas = 0
                    Else
                        horas = Int(mn / 60)
                    End If
                    txtTiempo.Text = String.Format("Horas:{0} Mn:{1}", horas, rs)
                    Select Case txtconcepto.Tag.ToString.Substring(0, 5)
                        Case "S0055", "S0059"
                            If horas = 0 Then
                                horas = horas + 1
                            ElseIf horas > 0 Then
                                horas = horas + IIf(rs > tolerancia, 1, 0)
                            End If
                            txtmonto.Text = horas * Val(loDiario.loConcepto.ConImporte)
                        Case Else
                            txtmonto.Text = 0
                    End Select
                    txtplaca.Tag = loDiario.DiarioId
                    btnOKTiket.Enabled = True
                    btnOKPlaca.Enabled = True
                    ' placaTemp = txtplaca.Text
                    btnOKPlaca_Click(Nothing, Nothing)
                    'txtplaca.Text = String.Empty
                Else
                    SaimtLabel1.ForeColor = Color.Red
                    ' SaimtMessageBox.mostrarAlertaAdvertencia("El Vehiculo no ha ingresado aun")
                    txtplaca.Focus()
                    diaInicio = Nothing
                    txtconcepto.Text = Nothing
                    txtconcepto.Tag = Nothing
                    txtmonto.Text = Nothing
                    btnOKTiket.Enabled = False
                    btnOKPlaca.Enabled = False
                    Return
                End If
            End If
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
                                                        Persona, _
                                                         frow.loConcepto.ConNombre, _
                                                           frow.loConcepto.ConId}, True)
         

                Next
            End If
            GridColumn6.Width = 110
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub frmSalidaCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableConceptos()
        ConstruirTableDiarioPEM()
        dgvDiarioPEM.DataSource = dt_diarioPEM
        txtfecha.Text = Date.Now.ToShortDateString
        txtHora.Text = Date.Now.ToString("HH:mm")

        cboEstados.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstados.Properties.DisplayMember = "TgNombre"
        cboEstados.Properties.ValueMember = "TgCodigo"
        cboEstados.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(157)
        cboEstados.ItemIndex = 0

        loconcepto = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupo(Date.Now.Year, "06")

        dt_conceptos.Clear()
        Dim i As Int16 = 0
        For Each fConcepto As EEConceptos In loconcepto
            If i = 0 Then
                dt_conceptos.LoadDataRow(New Object() {"S00002015", _
                  "LISTAR TODOS LOS CONCEPTOS", _
                  fConcepto.ConGrupo, _
                  fConcepto.ConImporte, _
                  fConcepto.TgSubGrupoId, _
                   "S0000 - LISTAR TODOS LOS CONCEPTOS"
                }, True)
                dt_conceptos.LoadDataRow(New Object() {fConcepto.ConId, _
                  fConcepto.ConNombre, _
                  fConcepto.ConGrupo, _
                  fConcepto.ConImporte, _
                  fConcepto.TgSubGrupoId, _
                   fConcepto.ConIdConNombre
                }, True)
            Else
                dt_conceptos.LoadDataRow(New Object() {fConcepto.ConId, _
                  fConcepto.ConNombre, _
                  fConcepto.ConGrupo, _
                  fConcepto.ConImporte, _
                  fConcepto.TgSubGrupoId, _
                   fConcepto.ConIdConNombre
                }, True)
            End If
            i = i + 1
        Next

        cboConceptosBusquedas.mColumnas(SaimtComboBoxLookUp.Entidades.Concepto)
        cboConceptosBusquedas.Properties.DisplayMember = "ConIdConNombre"
        cboConceptosBusquedas.Properties.ValueMember = "conId"
        cboConceptosBusquedas.Properties.DataSource = dt_conceptos
        cboConceptosBusquedas.ItemIndex = 0


        loPersona = MantenimientosBL.Instancia.MostrarPersonaUsuario()
        Dim lotablageneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId(160)
        If lotablageneral IsNot Nothing Then
            mensajePrint = lotablageneral.Item(0).TgDescripcion.ToUpper
        End If
        Me.tmhora.Enabled = True
    End Sub

    Private Sub btnOKTiket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKTiket.Click
        If txtTicket.Text IsNot Nothing Or txtTicket.Text <> "" Then
            If txtTicket.Text.Length <> 9 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Tikect debe tener 9 caracteres")
                txtTicket.Focus()
                Return
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el ticket Vehiculo")
            txtTicket.Focus()
            Return
        End If
        guardar()
        txtTicket.Text = Nothing
        '  txtTicket.Text = Nothing
    End Sub


    Private Sub txtTicket_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTicket.TextChanged
        If txtTicket.Text IsNot Nothing Then
            If txtTicket.Text.Length = 9 Then
                Dim loDiario As EEDiarioPEM = MantenimientosBL.Instancia.diariopemMostrarDatosIngresoXdiaNroTicket(txtTicket.Text)
                Dim diaInicio As Date
                If loDiario IsNot Nothing Then
                    diaInicio = loDiario.DiaFechaIng
                    txtconcepto.Text = loDiario.loConcepto.ConNombre
                    txtconcepto.Tag = loDiario.loConcepto.ConId
                    HoraIng = diaInicio.ToString("HH:mm:ss")
                    placa = loDiario.DiaNPlaca
                    Dim mn As Integer = 0
                    Dim rs As Integer = 0
                    Dim horas As Integer = 0
                    HoraIng = diaInicio.ToString("HH:mm:ss")
                    DiaIng = diaInicio.ToShortDateString
                    placa = loDiario.DiaNPlaca
                    mn = DateDiff(DateInterval.Minute, diaInicio, Date.Now)
                    rs = mn Mod 60
                    If rs = mn Then
                        horas = 0
                    Else
                        horas = Int(mn / 60)
                    End If
                    txtTiempo.Text = String.Format("Horas:{0} Mn:{1}", horas, rs)
                    Select Case txtconcepto.Tag.ToString.Substring(0, 5)
                        Case "S0055", "S0059"
                            If horas = 0 Then
                                horas = horas + 1
                            ElseIf horas > 0 Then
                                horas = horas + IIf(rs > tolerancia, 1, 0)
                            End If
                            txtmonto.Text = horas * Val(loDiario.loConcepto.ConImporte)
                        Case Else
                            txtmonto.Text = 0
                    End Select
                    txtplaca.Tag = loDiario.DiarioId
                    btnOKTiket.Enabled = True
                    btnOKPlaca.Enabled = True
                    btnOKTiket_Click(Nothing, Nothing)

                Else
                    SaimtMessageBox.mostrarAlertaAdvertencia("El Vehiculo no ha ingresado aun")
                    txtTicket.Focus()
                    diaInicio = Nothing
                    txtconcepto.Text = Nothing
                    txtconcepto.Tag = Nothing
                    txtmonto.Text = Nothing
                    btnOKTiket.Enabled = False
                    btnOKPlaca.Enabled = False
                    Return
                End If

            End If
        End If
    End Sub

    Private Sub tmhora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmhora.Tick
        txtfecha.Text = Date.Now.ToShortDateString
        txtHora.Text = Date.Now.ToString("HH:mm")
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If gvDiarioPEM.SelectedRowsCount > 0 Then
            Me.btnImprimir.Enabled = False
            Try
                xl = EEExcel.Instancia
                If File.Exists(My.Application.Info.DirectoryPath & "\RepositorioReportes\RptTicketSalida2.xls") = True Then
                    xl.Workbooks.Open(My.Application.Info.DirectoryPath & "\RepositorioReportes\RptTicketSalida2.xls", 1, True, 4)
                Else
                    xl.Workbooks.Open(EEComun.RutaReportes & "\RptTicketSalida2.xls", 1, True, 4)
                End If
                xl.Sheets(xl.Worksheets("TicketSalida").Index).Select()
                xl.Cells(6, 1).Value = "RUC. 20481297223 - " & EEComun.Usuario
                xl.Cells(6, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Cells(6, 1).Resize(1, 4).MergeCells = True
                xl.Range("C8").Value = "'" & gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diarioCod")
                xl.Range("A9").Value = cboConceptosBusquedas.Text.Trim
                xl.Range("B10").Value = gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaFechaIng")
                xl.Range("B10").NumberFormat = "dd/mm/yyyy"
                xl.Range("D10").Value = gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaFechaSal")
                xl.Range("D10").NumberFormat = "dd/mm/yyyy"
                xl.Range("B11").Value = gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaHoraIng")
                xl.Range("D11").Value = gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaHoraSal")
                xl.Range("B12").Value = gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaNPlaca").ToString()
                xl.Range("D12").Value = CDec(gvDiarioPEM.GetRowCellValue(Me.gvDiarioPEM.GetSelectedRows(0), "diaPrecio").ToString())
                xl.Range("A13").Value = mensajePrint
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
    Private Sub ImprimirTikectAntiguo(ByVal NroTicket As String)
        xl.Sheets(xl.Worksheets("TicketSalida").Index).Select()
        xl.Range("B3").Value = "SALIDA - " & Date.Now.ToShortDateString
        xl.Cells(5, 1).Value = "RUC. 20481297223 - " & EEComun.Usuario
        xl.Cells(5, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(5, 1).Resize(1, 4).MergeCells = True
        xl.Range("C6").Value = "'" & NroTicket
        xl.Range("A7").Value = String.Format("{0} - {1}", txtconcepto.Tag.ToString.Substring(0, 5), txtconcepto.Text)
        xl.Range("B8").Value = DiaIng.ToShortDateString
        xl.Range("D8").Value = Date.Now.ToShortDateString
        xl.Range("B9").Value = HoraIng
        xl.Range("D9").Value = Date.Now.ToString("HH:mm:ss")
        xl.Range("B10").Value = placa
        xl.Range("D10").Value = CDec(txtmonto.Text.Trim)
        xl.Range("A12").Value = mensajePrint
        xl.ActiveSheet.Protect("GeneralX2011", True, True)
        xl.ActiveWindow.Zoom = 130
        xl.Application.Visible = True
        xl.Application.WindowState = Excel.XlWindowState.xlMaximized
        xl.ActiveWorkbook.PrintOutEx(1, 1, 1, False, xl.ActivePrinter, False, False, "", False)
        EEComun.CloseAllExcel(xl)
    End Sub

    Private Sub ImprimirTikect(ByVal NroTicket As String)
        xl.Sheets(xl.Worksheets("TicketSalida").Index).Select()
        xl.Cells(6, 1).Value = "RUC. 20481297223 - " & EEComun.Usuario
        xl.Cells(6, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(6, 1).Resize(1, 4).MergeCells = True
        xl.Range("C8").Value = "'" & NroTicket
        xl.Range("A9").Value = String.Format("{0} - {1}", txtconcepto.Tag.ToString.Substring(0, 5), txtconcepto.Text)
        xl.Range("B10").Value = DiaIng.ToShortDateString
        xl.Range("D10").Value = Date.Now.ToShortDateString
        xl.Range("B11").Value = HoraIng
        xl.Range("D11").Value = Date.Now.ToString("HH:mm:ss")
        xl.Range("B12").Value = placa
        xl.Range("D12").Value = CDec(txtmonto.Text.Trim)
        xl.Range("A13").Value = mensajePrint
        xl.ActiveSheet.Protect("GeneralX2011", True, True)
        xl.ActiveWindow.Zoom = 130
        xl.Application.Visible = True
        xl.Application.WindowState = Excel.XlWindowState.xlMaximized
        xl.ActiveWorkbook.PrintOutEx(1, 1, 1, False, xl.ActivePrinter, False, False, "", False)
        EEComun.CloseAllExcel(xl)
    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        sfdExportar.Filter = "Archivo de Excel|*.xls"
        If sfdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            gvDiarioPEM.ExportToXls(sfdExportar.FileName)
        End If
    End Sub

End Class