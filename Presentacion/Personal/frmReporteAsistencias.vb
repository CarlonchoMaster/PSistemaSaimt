Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports System.IO
Imports DevExpress.XtraEditors.Controls

Public Class frmReporteAsistencias
#Region "Propiedades"
    Public Property Trabajador() As String
    Public Property InicioContrato() As String
    Public Property FinContrato() As String
    Public Property Modalidad() As String
#End Region

    Dim oData(7) As String
    Public Property Encontrado() As Boolean
    Dim contResultados As Integer = 0
    Dim xl As Excel.Application

    Private Sub frmReporteAsistencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Try
            Dim ListaPersona As List(Of EEContratoPersonal) = MantenimientosBL.Instancia.TrabajadorListarCriterio(1, 1)
            If ListaPersona IsNot Nothing Then
                For Each fPersona As EEContratoPersonal In ListaPersona
                    If fPersona.OPersona.PerNombreCompleto Is Nothing Then
                        oData(0) = String.Empty
                    Else
                        oData(0) = fPersona.OPersona.PerNombreCompleto
                    End If
                    If fPersona.ConTrabFecInicio Is Nothing Then
                        oData(1) = String.Empty
                    Else
                        oData(1) = fPersona.ConTrabFecInicio
                    End If
                    If fPersona.ConTrabFecFin Is Nothing Then
                        oData(2) = String.Empty
                    Else
                        oData(2) = fPersona.ConTrabFecFin
                    End If
                    If fPersona.OTgTipoContrato.TgNombre Is Nothing Then
                        oData(3) = String.Empty
                    Else
                        oData(3) = fPersona.OTgTipoContrato.TgNombre
                    End If
                    If fPersona.Sucursal Is Nothing Then
                        oData(4) = String.Empty
                    Else
                        oData(4) = fPersona.Sucursal
                    End If
                    If fPersona.OPersona.PerId Is Nothing Then
                        oData(5) = String.Empty
                    Else
                        oData(5) = fPersona.OPersona.PerId
                    End If
                    If fPersona.OPersona.PerCodTarjeta Is Nothing Then
                        oData(6) = String.Empty
                    Else
                        oData(6) = fPersona.OPersona.PerCodTarjeta
                    End If
                    If fPersona.CodAsistencia Is Nothing Then
                        oData(7) = String.Empty
                    Else
                        oData(7) = fPersona.CodAsistencia
                    End If
                    tlResultados.AppendNode(oData, -1)
                Next

                Me.Encontrado = True
            Else
                Me.Encontrado = False
            End If
            Me.dtpFechaFin.DateTime = EEComun.FechaServidor
            Me.dtpFechaInicio.DateTime = DateAdd(DateInterval.Day, -30, Me.dtpFechaFin.DateTime)
            tlResultados.BestFitColumns()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Private Sub chbSelectAll_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbSelectAll.CheckedChanged
        contResultados = 0
        If chbSelectAll.Checked Then
            For Me.contResultados = 0 To tlResultados.Nodes.Count - 1
                tlResultados.Nodes(contResultados).CheckState = CheckState.Checked
            Next
        Else
            For Me.contResultados = 0 To tlResultados.Nodes.Count - 1
                tlResultados.Nodes(contResultados).CheckState = CheckState.Unchecked
            Next
        End If
    End Sub

    Private Sub btnExportarReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarReporte.Click
        Try
            If dtpFechaInicio.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una Fecha de Inicio")
                dtpFechaInicio.Focus()
                Exit Sub
            End If
            If dtpFechaFin.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una Fecha de Fin")
                dtpFechaFin.Focus()
                Exit Sub
            End If
            Dim lbMarcaSeleccion As Boolean = False
            For fFilaTrabajador As Int32 = 0 To tlResultados.Nodes.Count - 1
                If tlResultados.Nodes(fFilaTrabajador).CheckState = CheckState.Checked Then
                    lbMarcaSeleccion = True
                    Exit For
                End If
            Next
            If lbMarcaSeleccion = False Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione al menos a un Trabajador")
                Exit Sub
            End If
            Dim lbMarcaReporte As Boolean = False
            For Each fItem As CheckedListBoxItem In clbreportes.Items
                If fItem.CheckState = CheckState.Checked Then
                    lbMarcaReporte = True
                    Exit For
                End If
            Next
            If lbMarcaReporte = False Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione al menos un Reporte")
                clbreportes.Focus()
                Exit Sub
            End If
            btnExportarReporte.Enabled = False
            xl = EEExcel.Instancia
            xl.Workbooks.Open(EEComun.RutaReportes + "\RptReporteAsistencias.xls", 1, True, 4)
            If clbreportes.Items(0).CheckState = CheckState.Checked Then
                ExportarMarcaciones()
            ElseIf clbreportes.Items(1).CheckState = CheckState.Checked Then
                ExportarMarcacionesXEstado("S")
            End If
            btnExportarReporte.Enabled = True
            sfdExportar.FileName = "Reporte_Asistencias_" & DateTime.Now.ToString("dd-MM-yyyy")
            sfdExportar.DefaultExt = "xls"
            sfdExportar.Filter = "Excel (*.xls)|*.xls"
            If sfdExportar.ShowDialog() = DialogResult.OK Then
                Dim wbk As Microsoft.Office.Interop.Excel.Workbook = xl.Workbooks(1)
                wbk.SaveAs(sfdExportar.FileName, Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing)
                xl.Workbooks(1).Close()
            End If
            xl.Quit()
            SaimtMessageBox.mostrarAlertaInformativa("Se Exporto Correctamente.")
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

#Region "Exportar Marcaciones"
    Private Sub ExportarMarcaciones()
        xl.Sheets(xl.Worksheets("Marcaciones").Index).Select()
        xl.Range("A1").Value = "Del " & dtpFechaInicio.Text & " al " & dtpFechaFin.Text
        xl.Range("J1").Value = "AÑO " & EEComun.FechaServidor.Value.Year
        Dim liFila As Integer = 8
        Dim filaIni As Integer = 0
        Dim liNroDias As Integer = 0
        Dim liMinutosTarde As Integer = 0
        Dim liMinutosTemprano As Integer = 0
        Dim CodigoTrabajador As Int32 = 0
        Dim liNroTrabajadoresSeleccionados As Int32 = 0
        For fFilaTrabajador As Int32 = 0 To tlResultados.Nodes.Count - 1
            If tlResultados.Nodes(fFilaTrabajador).CheckState = CheckState.Checked Then
                liNroTrabajadoresSeleccionados = liNroTrabajadoresSeleccionados + 1
            End If
        Next
        Dim liNroFilaSeleccionada As Int32 = 0
        Me.beiprogreso.Caption = "Cargando Reporte"
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.riprogreso.Minimum = 0
        Me.riprogreso.Maximum = liNroTrabajadoresSeleccionados
        Me.beiprogreso.EditValue = 0
        For fFilaTrabajador As Int32 = 0 To tlResultados.Nodes.Count - 1
            If tlResultados.Nodes(fFilaTrabajador).CheckState = CheckState.Checked Then
                Application.DoEvents()
                Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                liNroFilaSeleccionada = liNroFilaSeleccionada + 1
                CodigoTrabajador = Convert.ToInt32(tlResultados.Nodes(fFilaTrabajador).Item("CodAsistencia").ToString())
                'PARA ALMACENAR LAS FECHAS
                Dim htFechas As Hashtable = New Hashtable()
                Dim ListaMarcaciones As List(Of EEMarcaciones) = ReportesBL.Instancia.marcacionesListarXTrab(dtpFechaInicio.Text, dtpFechaFin.Text, CodigoTrabajador)
                If ListaMarcaciones IsNot Nothing Then
                    Me.beiprogreso.Caption = "Cargando Reporte - " & ListaMarcaciones(0).Trabajador
                    xl.Range("A" & liFila - 2).Value = "Personal: " & ListaMarcaciones(0).Trabajador
                    xl.Range("A" & liFila - 2).Font.Bold = True
                    xl.Cells(liFila - 2, 10) = ListaMarcaciones(0).Documento
                    xl.Cells(liFila - 2, 10).Font.Bold = True
                    xl.Cells(liFila - 2, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    filaIni = liFila
                    For Each fMarcaciones As EEMarcaciones In ListaMarcaciones
                        If htFechas(fMarcaciones.FechaMar) Is Nothing Then
                            liNroDias = liNroDias + 1
                            xl.Range("A" & liFila).Value = liNroDias
                            xl.Cells(liFila, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            xl.Cells(liFila, 1).Resize(1, 11).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 1).Resize(1, 11).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 4).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 7).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 8).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 9).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            xl.Range("B" & liFila).Value = fMarcaciones.FechaMar
                            xl.Range("A" & liFila & ":K" & liFila).Interior.Color = RGB(197, 217, 241)
                            Dim ldFechaMarcacion As Date = fMarcaciones.FechaMar
                            Dim ListaHorasTrabajadas As List(Of EEMarcaciones) = ListaMarcaciones.FindAll(Function(ac) ac.FechaMar = ldFechaMarcacion AndAlso (ac.Estado = "E" OrElse ac.Estado = "S"))
                            If ListaHorasTrabajadas.Count = 2 Then
                                Dim liTotalHorasTrabajadas As Int16 = DateDiff(DateInterval.Hour, ListaHorasTrabajadas(0).Hora, ListaHorasTrabajadas(1).Hora) - 1
                                If liTotalHorasTrabajadas > 8 Then
                                    xl.Range("K" & liFila).Value = 8
                                Else
                                    xl.Range("K" & liFila).Value = liTotalHorasTrabajadas
                                End If
                            Else
                                xl.Range("K" & liFila).Value = "Indeterminado Calcular"
                            End If

                            liFila = liFila + 1
                            htFechas.Add(fMarcaciones.FechaMar, fMarcaciones.FechaMar)
                        End If
                        xl.Range("C" & liFila).Value = fMarcaciones.Hora
                        'xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 3).NumberFormat = "hh:mm:ss"
                        xl.Cells(liFila, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xl.Range("D" & liFila).Value = fMarcaciones.Estado
                        xl.Cells(liFila, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xl.Range("E" & liFila).Value = fMarcaciones.Tardanza
                        xl.Range("F" & liFila).Value = fMarcaciones.Temprano
                        If Not fMarcaciones.Tardanza = String.Empty Then
                            xl.Range("G" & liFila).Value = ConvertirTiempo(Hour(fMarcaciones.Tardanza), Minute(fMarcaciones.Tardanza))
                            liMinutosTarde = Convert.ToInt32(xl.Range("G" & liFila).Value)
                        Else
                            liMinutosTarde = 0
                        End If
                        If Not fMarcaciones.Temprano = String.Empty Then
                            xl.Range("H" & liFila).Value = ConvertirTiempo(Hour(fMarcaciones.Temprano), Minute(fMarcaciones.Temprano))
                            liMinutosTemprano = Convert.ToInt32(xl.Range("H" & liFila).Value)
                        Else
                            liMinutosTemprano = 0
                        End If
                        If Trim(fMarcaciones.Estado) = "FT" Or Trim(fMarcaciones.Estado) = "F" Then
                            xl.Range("I" & liFila).Value = 0
                            xl.Cells(liFila, 10) = 1
                        Else
                            If liMinutosTarde + liMinutosTemprano <> 0 Then
                                xl.Range("I" & liFila).Value = liMinutosTarde + liMinutosTemprano
                            End If
                        End If
                        liFila = liFila + 1
                    Next
                    xl.Cells(liFila, 1).Resize(1, 9).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 9) = "Minutos"
                    xl.Cells(liFila, 9).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 9).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 9).Font.Bold = True
                    xl.Cells(liFila, 10) = "Dias"
                    xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 10).Font.Bold = True
                    xl.Cells(liFila, 10).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    xl.Cells(liFila, 11).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    liFila = liFila + 1
                    xl.Cells(liFila, 9).Formula = "=Sum(I" & filaIni & ":I" & (liFila - 2) & ")"
                    xl.Cells(liFila, 10).Formula = "=Sum(J" & filaIni & ":J" & (liFila - 2) & ")"
                    xl.Cells(liFila, 8) = "Total a Descontar"
                    xl.Cells(liFila, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    xl.Cells(liFila, 8).Font.Bold = True
                    xl.Cells(liFila, 1).Resize(1, 9).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    liFila = liFila + 1
                    If liNroFilaSeleccionada < liNroTrabajadoresSeleccionados Then
                        xl.Range("A" & 7 & ":K" & 7).Select()
                        xl.Selection.Copy()
                        xl.Range("A" & liFila + 2).Select()
                        xl.ActiveSheet.Paste()
                        xl.Cells(xl.Selection.Row, 1).EntireRow.RowHeight = 30
                        xl.Application.CutCopyMode = False
                        liFila = liFila + 3
                    End If
                    liNroDias = 0
                End If
            End If
        Next
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub ExportarMarcacionesXEstado(ByVal asEstado As String)
        xl.Sheets(xl.Worksheets("MarcacionesEstado").Index).Select()
        xl.Range("A1").Value = "Del " & dtpFechaInicio.Text & " al " & dtpFechaFin.Text
        'xl.Range("J1").Value = "AÑO " & EEComun.FechaServidor.Value.Year
        Dim liFila As Integer = 8
        Dim filaIni As Integer = 0
        Dim liNroDias As Integer = 0
        Dim liMinutosTarde As Integer = 0
        Dim liMinutosTemprano As Integer = 0
        Dim CodigoTrabajador As Int32 = 0
        Dim liNroTrabajadoresSeleccionados = 0
        For fFilaTrabajador As Int32 = 0 To tlResultados.Nodes.Count - 1
            If tlResultados.Nodes(fFilaTrabajador).CheckState = CheckState.Checked Then
                liNroTrabajadoresSeleccionados = liNroTrabajadoresSeleccionados + 1
            End If
        Next
        Dim liNroFilaSeleccionada As Int32 = 0
        Me.beiprogreso.Caption = "Cargando Reporte... "
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.riprogreso.Minimum = 0
        Me.riprogreso.Maximum = liNroTrabajadoresSeleccionados
        Me.beiprogreso.EditValue = 0
        filaIni = liFila
        For fFilaTrabajador As Int32 = 0 To tlResultados.Nodes.Count - 1
            If tlResultados.Nodes(fFilaTrabajador).CheckState = CheckState.Checked Then
                Application.DoEvents()
                Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                liNroFilaSeleccionada = liNroFilaSeleccionada + 1
                CodigoTrabajador = Convert.ToInt32(tlResultados.Nodes(fFilaTrabajador).Item("CodAsistencia").ToString())
                'PARA ALMACENAR LAS FECHAS
                Dim htFechas As Hashtable = New Hashtable()
                Dim ListaMarcaciones As List(Of EEMarcaciones) = ReportesBL.Instancia.marcacionesListarXTrabEstado(dtpFechaInicio.Text, dtpFechaFin.Text, CodigoTrabajador, asEstado)
                Me.beiprogreso.Caption = "Cargando Reporte - " & ListaMarcaciones(0).Trabajador
                xl.Range("A" & liFila - 2).Value = "Personal: " & ListaMarcaciones(0).Trabajador
                xl.Range("A" & liFila - 2).Font.Bold = True
                'xl.Cells(liFila - 2, 10) = ListaMarcaciones(0).Documento
                'xl.Cells(liFila - 2, 10).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                For Each fMarcaciones As EEMarcaciones In ListaMarcaciones
                    If htFechas(fMarcaciones.FechaMar) Is Nothing Then
                        liNroDias = liNroDias + 1
                        xl.Range("A" & liFila).Value = liNroDias
                        xl.Cells(liFila, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xl.Cells(liFila, 1).Resize(1, 6).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 1).Resize(1, 6).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 4).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Cells(liFila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        xl.Range("B" & liFila).Value = fMarcaciones.FechaMar
                        xl.Range("A" & liFila & ":F" & liFila).Interior.Color = RGB(197, 217, 241)
                        liFila = liFila + 1
                        htFechas.Add(fMarcaciones.FechaMar, fMarcaciones.FechaMar)
                    End If
                    xl.Range("C" & liFila).Value = fMarcaciones.Hora
                    xl.Cells(liFila, 3).NumberFormat = "hh:mm:ss"
                    xl.Cells(liFila, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xl.Range("D" & liFila).Value = fMarcaciones.Estado
                    xl.Cells(liFila, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    xl.Range("E" & liFila).Value = fMarcaciones.SalidaOficial
                    xl.Cells(liFila, 5).NumberFormat = "hh:mm:ss"
                    xl.Range("F" & liFila).Value = fMarcaciones.DiferenciaMinutos
                    liFila = liFila + 1
                Next
                xl.Cells(liFila, 5) = "Total"
                xl.Cells(liFila, 5).Font.Bold = True
                xl.Cells(liFila, 6).Formula = "=Sum(F" & filaIni & ":F" & (liFila - 2) & ")"
                liFila = liFila + 1
                If liNroFilaSeleccionada < liNroTrabajadoresSeleccionados Then
                    xl.Range("A" & 7 & ":F" & 7).Select()
                    xl.Selection.Copy()
                    xl.Range("A" & liFila + 2).Select()
                    xl.ActiveSheet.Paste()
                    xl.Application.CutCopyMode = False
                    liFila = liFila + 3
                End If
                liNroDias = 0
            End If
        Next
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Function ConvertirTiempo(horas As Short, minutos As Short) As Integer
        Dim ResultadosMin As Integer = 0
        ResultadosMin = horas * 60
        ResultadosMin = ResultadosMin + minutos
        Return ResultadosMin
    End Function
#End Region

    Private Sub btnPivotearMarcaciones_Click(sender As System.Object, e As System.EventArgs) Handles btnPivotearMarcaciones.Click
        Dim fRptAsistencias As frmRptAsistencias = New frmRptAsistencias()
        fRptAsistencias.Show()
    End Sub
End Class