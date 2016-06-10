﻿Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports Microsoft.Office.Interop

Public Class frmInmueblesRptFinal
    Dim oTable As DataTable = New DataTable()
    Dim oTableGRubros As DataTable = New DataTable()
    Public Property InmId() As String
    Public Property SQlString() As String
    Dim xl As Excel.Application

    Private Sub ConstruirTableGRubros()
        oTableGRubros.Columns.Add("TgCodigo", GetType(String))
        oTableGRubros.Columns.Add("TgNombre", GetType(String))
    End Sub

    Private Sub ConstruirTable()
        oTable.Columns.Add("inmFile", GetType(String))
        oTable.Columns.Add("inmFileAnt", GetType(String))
        oTable.Columns.Add("inmUbicacion", GetType(String))
        oTable.Columns.Add("inmInscrito", GetType(String))
        oTable.Columns.Add("inmDenominacion", GetType(String))
        oTable.Columns.Add("tgInmCondReg", GetType(String))
        oTable.Columns.Add("inmPartidaElec", GetType(String))
        oTable.Columns.Add("tgInmCondLegal", GetType(String))
        oTable.Columns.Add("tgEstSan", GetType(String))
        oTable.Columns.Add("InmPredArea", GetType(String))
        oTable.Columns.Add("tgInmSitFisica", GetType(String))
        oTable.Columns.Add("tgInmSFUso", GetType(String))
        oTable.Columns.Add("tgEstInmConsv", GetType(String))
        oTable.Columns.Add("inmDisponibilidad", GetType(String))
        oTable.Columns.Add("inmValComAreaTechada", GetType(Decimal))
        oTable.Columns.Add("inmValComArea", GetType(Decimal))
        oTable.Columns.Add("InmValComValxMetro", GetType(String))
        oTable.Columns.Add("InmValComValTerreno", GetType(String))
        oTable.Columns.Add("InmValComValConst", GetType(String))
        oTable.Columns.Add("InmValComValTotal", GetType(String))

        oTable.Columns.Add("InmId", GetType(String))
        oTable.Columns.Add("TgRubroId", GetType(String))

        oTable.Columns.Add("TotalBienesPropios", GetType(Integer))
        oTable.Columns.Add("TotalSerpar", GetType(Integer))
        oTable.Columns.Add("TotalAreasVerdes", GetType(Integer))
        oTable.Columns.Add("TotalOtrosFines", GetType(Integer))

        oTable.Columns.Add("TotalAreaBienesPropios", GetType(Decimal))
        oTable.Columns.Add("TotalAreaSerpar", GetType(Decimal))
        oTable.Columns.Add("TotalAreaAreasVerdes", GetType(Decimal))
        oTable.Columns.Add("TotalAreaOtrosFines", GetType(Decimal))

        oTable.Columns.Add("TotalAreaTechadaBienesPropios", GetType(Decimal))
        oTable.Columns.Add("TotalAreaTechadaSerpar", GetType(Decimal))
        oTable.Columns.Add("TotalAreaTechadaAreasVerdes", GetType(Decimal))
        oTable.Columns.Add("TotalAreaTechadaOtrosFines", GetType(Decimal))

        oTable.Columns.Add("TotalValorBienesPropios", GetType(Decimal))
        oTable.Columns.Add("TotalValorAreaSerpar", GetType(Decimal))
        oTable.Columns.Add("TotalValorAreaAreasVerdes", GetType(Decimal))
        oTable.Columns.Add("TotalValorAreaOtrosFines", GetType(Decimal))

        oTable.Columns.Add("CountBP_BienesPropios", GetType(Integer))
        oTable.Columns.Add("CountBP_Vias", GetType(Integer))


    End Sub

    Private Sub ExportarGeneral(Optional ByVal ruta As String = Nothing)
        Try
            xl = EEExcel.Instancia
            Me.beprogreso.Caption = "Abriendo Exel Temporal... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            xl.Workbooks.Open(EEComun.RutaReportes & "\RptFinalMargesi.xlsx", 1, True, 4)

            'consulta General
            Me.beprogreso.Caption = "Cargando Consulta General de Totales... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim loVariableRpt As EEInmueble.EEVariablesRpt = MantenimientosBL.Instancia.inmuebleMostrarTotalesByAnio(Nothing)
            If loVariableRpt IsNot Nothing Then
        

                xl.Range("E7").Value = loVariableRpt.TotalBienesPropios
                xl.Range("E8").Value = loVariableRpt.TotalOtrosFines
                xl.Range("E9").Value = loVariableRpt.TotalSerpar
                xl.Range("E10").Value = loVariableRpt.TotalAreasVerdes
                Dim suma1 As Decimal = loVariableRpt.TotalBienesPropios + loVariableRpt.TotalOtrosFines + loVariableRpt.TotalSerpar + loVariableRpt.TotalAreasVerdes
                xl.Range("I24").Value = suma1

                xl.Range("E12").Value = loVariableRpt.TotalAreaBienesPropios
                xl.Range("E13").Value = loVariableRpt.TotalAreaOtrosFines
                xl.Range("E14").Value = loVariableRpt.TotalAreaSerpar
                xl.Range("E15").Value = loVariableRpt.TotalAreaAreasVerdes

                Dim suma2 As Decimal = loVariableRpt.TotalAreaBienesPropios + loVariableRpt.TotalAreaOtrosFines + loVariableRpt.TotalAreaSerpar + loVariableRpt.TotalAreaAreasVerdes
                xl.Range("F45").Value = suma2

                xl.Range("E18").Value = loVariableRpt.TotalValorBienesPropios
                xl.Range("E19").Value = loVariableRpt.TotalValorOtrosFines
                xl.Range("E20").Value = loVariableRpt.TotalValorSerpar
                xl.Range("E21").Value = loVariableRpt.TotalValorAreasVerdes
                Dim suma3 As Decimal = loVariableRpt.TotalValorBienesPropios + loVariableRpt.TotalValorOtrosFines + loVariableRpt.TotalValorSerpar + loVariableRpt.TotalValorAreasVerdes
                xl.Range("L45").Value = suma3
            End If

            Application.DoEvents()
            If ruta Is Nothing Then
                If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(String.Format("{0}\Margesí Municipal - Resumen (dato general)", fbdExportar.SelectedPath))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Bienes Propios"
                    'Me.BarEditItem3.EditValue = Me.BarEditItem3.EditValue + 1
                    Application.DoEvents()
                End If
            Else
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\Margesí Municipal - Resumen (dato general)", ruta))
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Bienes Propios"
                ' Me.BarEditItem3.EditValue = Me.BarEditItem3.EditValue + 1
                Application.DoEvents()
            End If

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub ExportarReporteBienesPropios(Optional ByVal ruta As String = Nothing)
        Try
            xl = EEExcel.Instancia
            Me.beprogreso.Caption = "Abriendo Exel Temporal... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO BIENES PROPIOS.xls", 1, True, 4)

            'consulta General
            Me.beprogreso.Caption = "Cargando Consulta General de Totales... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim loVariableRpt As EEInmueble.EEVariablesRpt = MantenimientosBL.Instancia.inmuebleMostrarTotalesByAnio(cboAnio.EditValue)
            If loVariableRpt IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Bienes Propios Total").Index).Select()
                xl.Range("D3").Value = "RUBRO BIENES PROPIOS DEL MARGESÍ MUNICIPAL " & cboAnio.Text
                xl.Range("F28").Value = "RESUMEN RUBRO BIENES PROPIOS " & cboAnio.Text
                xl.Range("F35").Value = "RUBRO BIENES PROPIOS " & cboAnio.Text
                xl.Range("G29").Value = loVariableRpt.TotalBienesPropios
                xl.Range("G30").Value = String.Format("{0} m2", Format(loVariableRpt.TotalAreaBienesPropios, "##,##0.00"))
                xl.Range("G31").Value = String.Format("{0} m2", Format(loVariableRpt.TotalAreaTechadaBienesPropios, "##,##0.00"))
                xl.Range("G32").Value = loVariableRpt.TotalValorBienesPropios
                xl.Range("G36").Value = loVariableRpt.CountBP_BienesPropios
                xl.Range("G37").Value = loVariableRpt.CountBP_Vias
            End If

            'Consulta  01
            Me.beprogreso.Caption = "Cargando Consulta Bienes Propios... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim ListaInmuebles As List(Of EEInmueble) = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarXAnio_tgRubroId(cboAnio.EditValue, "01")
            Dim fila As String = 7
            Dim cant As Integer = 1
            If ListaInmuebles IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Bienes Propios").Index).Select()
                xl.Range("B2").Value = "RUBRO BIENES PROPIOS DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                ' Dim loImageConver As ImageConver
                Dim i As Int16 = 0
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble en reporte del Rubro Bienes Propios... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    ' Aliniar(fila)
                    xl.Range("C" & fila).Value = String.Format("File {0} - Bienes Propios", loinmueble.InmFile) 'CÓDIGO MARGESÍ MPT(N° de file actual y rubro)

                    If loinmueble.InmArchDivision IsNot Nothing Then
                        'loImageConver = New ImageConver
                        'xl.Range("D" & fila).Value = loImageConver.Bytes2Image(loinmueble.InmArchDivision)
                        Dim cj = loinmueble.InmArchDivision
                        If (cj.GetType = GetType(System.Byte())) Then
                            Dim data As Byte() = DirectCast(cj, Byte())
                            Dim ms As New System.IO.MemoryStream(data)
                            Dim im As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                            Dim h As String = Application.StartupPath + loinmueble.InmId + ".jpg"
                            im.Save(h, Imaging.ImageFormat.Jpeg)
                            System.Windows.Forms.Clipboard.SetDataObject(im, True)

                            '// paste bmp to xlsRange
                            ' xl = xl.get_Range(xl.Range("D" & fila))
                            xl.Paste(xl.Range("D" & fila), im)

                            'xl.Range("D" & fila).Value = im ' AddPicture(h, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoTrue, i + 2, i + 1, 100, 100)
                            '    count += 1
                            'Else
                            '    xl.Cells("D" & fila) = DataGridView1(j, i).Value.ToString()
                        End If
                    End If
                    '"Registro antiguo" (N° de file antiguo)
                    xl.Range("E" & fila).Value = loinmueble.InmUbicacion ' Ubicación
                    xl.Range("F" & fila).Value = loinmueble.InmInscrito ' Finca Inscrita
                    xl.Range(String.Format("C{0}:D{0}", fila)).Interior.Color = RGB(242, 242, 242)
                    xl.Range("G" & fila).Value = loinmueble.InmDenominacion ' Finca Inscrita
                    xl.Range("H" & fila).Value = loinmueble.tgInmCondReg ' Estado
                    xl.Range("I" & fila).Value = loinmueble.InmPartidaElec ' Estado
                    xl.Range("J" & fila).Value = loinmueble.TgInmCondLegal ' Condicion Legal
                    xl.Range("K" & fila).Value = loinmueble.tgEstSan ' Proceso o Estado de Saneamiento
                    xl.Range("L" & fila).Value = CDbl(loinmueble.OInmPredio.InmPredArea) ' area m2 -- Predio
                    xl.Range("M" & fila).Value = loinmueble.tgInmSitFisica ' Uso actual
                    xl.Range("N" & fila).Value = loinmueble.tgInmSFUso ' Zonificacion
                    xl.Range("O" & fila).Value = loinmueble.tgEstInmConsv ' Estado de Conservacion
                    xl.Range("P" & fila).Value = IIf(loinmueble.InmDisponibilidad = 0, "NO", "SI") ' Disponibilidad
                    ' Valor Comercial
                    xl.Range("Q" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComAreaTechada) ' area Techada
                    xl.Range("R" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValxMetro) ' Valor por Metro 2
                    xl.Range("S" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTerreno) ' Valor del Terreno
                    xl.Range("T" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValConst) ' Valor de Edificacion o Construcion
                    xl.Range("U" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTotal) ' Valor comercial
                    xl.Range("V" & fila).Value = loinmueble.InmId ' Codigo Informatico
                    xl.Range("W" & fila).Value = loinmueble.inmSaneadoObsMostrable ' "..." ' Observacion
                    NewBorde(fila)
                    fila = fila + 1
                    cant = cant + 1
                Next
                Me.beprogreso.Caption = "Escribiendo totales del Rubro Bienes Propios..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:F{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN RUBRO BIENES PROPIOS"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 1).Value = "TOTAL DE INMUEBLES"
                xl.Range("E" & fila + 1).Font.Bold = True
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
                xl.Range("E" & fila + 2).Font.Bold = True
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 3).Value = "ÁREA CONSTRUIDA TOTAL"
                xl.Range("E" & fila + 3).Font.Bold = True
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 4).Value = "VALOR COMERCIAL TOTAL"
                xl.Range("E" & fila + 4).Font.Bold = True
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 1).Value = loVariableRpt.CountBP_BienesPropios
                xl.Range("F" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 2).Value = Format(loVariableRpt.itemAreaBP_BienesPropio, "##,##0.00") & " m2"
                xl.Range("F" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 3).Value = Format(loVariableRpt.itemAreaTechadaBP_BienesPropio, "##,##0.00") & " m2"
                xl.Range("F" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 4).Value = "S/." & Format(loVariableRpt.itemValorBP_BienesPropios, "##,##0.00")
                xl.Range("F" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Me.beprogreso.Caption = "Finalizando Rubro Bienes Propios..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

            End If

            'Consulta  02
            Me.beprogreso.Caption = "Cargando Consulta BP - Vias... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarXAnio_tgRubroId(cboAnio.EditValue, "02")
            fila = 7
            cant = 1

            If ListaInmuebles IsNot Nothing Then
                xl.Sheets(xl.Worksheets("BP - Vías").Index).Select()
                xl.Range("B2").Value = "RUBRO BIENES PROPIOS - VÍAS DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} inmueble en reporte del Rubro BP Vías... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    ' Aliniar(fila)
                    xl.Range("C" & fila).Value = String.Format("File {0} - Bienes Propios " & Chr(34) & "Vías" & Chr(34), loinmueble.InmFile) 'CÓDIGO MARGESÍ MPT(N° de file actual y rubro)
                    xl.Range("D" & fila).Value = "File " & loinmueble.InmFileAnt '"Registro antiguo" (N° de file antiguo)
                    xl.Range("E" & fila).Value = loinmueble.InmUbicacion ' Ubicación
                    xl.Range("F" & fila).Value = loinmueble.InmInscrito ' Finca Inscrita
                    xl.Range(String.Format("C{0}:D{0}", fila)).Interior.Color = RGB(242, 242, 242)
                    xl.Range("G" & fila).Value = loinmueble.InmDenominacion ' Finca Inscrita
                    xl.Range("H" & fila).Value = loinmueble.tgInmCondReg ' Estado
                    xl.Range("I" & fila).Value = loinmueble.InmPartidaElec ' Estado
                    xl.Range("J" & fila).Value = loinmueble.TgInmCondLegal ' Condicion Legal
                    xl.Range("K" & fila).Value = loinmueble.tgEstSan ' Proceso o Estado de Saneamiento
                    xl.Range("L" & fila).Value = CDbl(loinmueble.OInmPredio.InmPredArea) ' area m2 -- Predio
                    xl.Range("M" & fila).Value = loinmueble.tgInmSitFisica ' Uso actual
                    xl.Range("N" & fila).Value = loinmueble.tgInmSFUso ' Zonificacion
                    xl.Range("O" & fila).Value = loinmueble.tgEstInmConsv ' Estado de Conservacion
                    xl.Range("P" & fila).Value = IIf(loinmueble.InmDisponibilidad = 0, "NO", "SI") ' Disponibilidad
                    ' Valor Comercial
                    xl.Range("Q" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComAreaTechada) ' area Techada
                    xl.Range("R" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValxMetro) ' Valor por Metro 2
                    xl.Range("S" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTerreno) ' Valor del Terreno
                    xl.Range("T" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValConst) ' Valor de Edificacion o Construcion
                    xl.Range("U" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTotal) ' Valor comercial
                    xl.Range("V" & fila).Value = loinmueble.InmId ' Codigo Informatico
                    xl.Range("W" & fila).Value = loinmueble.inmSaneadoObsMostrable ' "..." ' Observacion
                    NewBorde(fila)
                    fila = fila + 1
                    cant = cant + 1
                Next
                Me.beprogreso.Caption = "Escribiendo totales del Rubro BP - Vías..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:F{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN RUBRO BIENES PROPIOS - VÍAS"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 1).Value = "TOTAL DE INMUEBLES"
                xl.Range("E" & fila + 1).Font.Bold = True
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
                xl.Range("E" & fila + 2).Font.Bold = True
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 3).Value = "ÁREA CONSTRUIDA TOTAL"
                xl.Range("E" & fila + 3).Font.Bold = True
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 4).Value = "VALOR COMERCIAL TOTAL"
                xl.Range("E" & fila + 4).Font.Bold = True
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 1).Value = loVariableRpt.CountBP_Vias
                xl.Range("F" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 2).Value = Format(loVariableRpt.itemAreaBP_Vias, "##,##0.00") & " m2"
                xl.Range("F" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 3).Value = Format(loVariableRpt.itemAreaTechadaBP_Vias, "##,##0.00") & " m2"
                xl.Range("F" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 4).Value = "S/." & Format(loVariableRpt.itemValorBP_Vias, "##,##0.00")
                xl.Range("F" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Me.beprogreso.Caption = "Finalizando Rubro Bp - Vías..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
            End If
            '
            '                                                   ALTAS
            '
            Me.beprogreso.Caption = "Cargando Data de Altas Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarAltasXAnio_tgGRubroId(cboAnio.EditValue, "01")
            xl.Sheets(xl.Worksheets("Altas").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "ALTAS " & cboAnio.Text & " DEL RUBRO BIENES PROPIOS DEL MARGESÍ MUNICIPAL MPT"

            Dim NroAltasxAnio As Int16 = 0
            If ListaInmuebles IsNot Nothing Then
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} inmueble Altas en reporte Bienes Propios Altas... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmFile
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = Format(CDbl(loinmueble.OInmPredio.InmPredArea), "##,##0.00")
                    xl.Range("F" & fila).Value = "Alta"
                    xl.Range("G" & fila).Value = loinmueble.inmCausalAlta
                    xl.Range("H" & fila).Value = loinmueble.InmFecReg
                    xl.Range("I" & fila).Value = loinmueble.OInmValorComercial.InmValComValTotal
                    xl.Range("J" & fila).Value = loinmueble.inmDocAlta
                    xl.Range("k" & fila).Value = loinmueble.inmAltaObservacion
                    NewBordeK(fila)
                    fila = fila + 1
                    cant = cant + 1
                    NroAltasxAnio = NroAltasxAnio + 1
                Next
            Else
                fila = fila + 2
            End If
            Me.beprogreso.Caption = "Escribiendo totales de Altas Bienes Propios"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("D{0}:E{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("D" & fila).Value = "RESUMEN DE ALTAS  - RUBRO BIENES PROPIOS"
            xl.Range("D" & fila).Font.Bold = True
            xl.Range("D" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 1).Value = "TOTAL DE INMUEBLES"
            xl.Range("D" & fila + 1).Font.Bold = True
            xl.Range("D" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
            xl.Range("D" & fila + 2).Font.Bold = True
            xl.Range("D" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 3).Value = "VALOR COMERCIAL TOTAL"
            xl.Range("D" & fila + 3).Font.Bold = True
            xl.Range("D" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = NroAltasxAnio ' loVariableRpt.TotalAltasBienesPropios
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 2).Value = Format(loVariableRpt.TotalAreaAltasBienesPropios, "##,##0.00") & " m2"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 3).Value = "S/." & Format(loVariableRpt.TotalValorAltasBienesPropios, "##,##0.00")
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Me.beprogreso.Caption = "Finalizando Altas Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   BAJAS
            '
            Me.beprogreso.Caption = "Cargando Data de Bajas Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarBajasXAnio_tgGRubroId(cboAnio.EditValue, "01")
            xl.Sheets(xl.Worksheets("Bajas").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "BAJAS " & cboAnio.Text & " DEL RUBRO BIENES PROPIOS DEL MARGESÍ MUNICIPAL MPT"
            Dim NrobajasxAnio As Int16 = 0
            If ListaInmuebles IsNot Nothing Then
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble Bajas en reporte Bienes Propios Bajas 2013... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmFile
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = Format(CDbl(loinmueble.OInmPredio.InmPredArea), "##,##0.00")
                    xl.Range("F" & fila).Value = "Baja"
                    xl.Range("G" & fila).Value = loinmueble.OInmBajas.InmBajaCausa
                    xl.Range("H" & fila).Value = loinmueble.OInmBajas.InmBajaFecha
                    xl.Range("I" & fila).Value = loinmueble.OInmValorComercial.InmValComValTotal
                    xl.Range("J" & fila).Value = loinmueble.OInmBajas.InmBajaNroDoc
                    xl.Range("K" & fila).Value = loinmueble.OInmBajas.InmBajaDatoAdicional
                    xl.Range("L" & fila).Value = loinmueble.OInmBajas.InmBajaObservacion
                    NewBordeL(fila)

                    fila = fila + 1
                    cant = cant + 1
                    NrobajasxAnio = NrobajasxAnio + 1
                Next
            Else
                fila = fila + 2
            End If
            Me.beprogreso.Caption = "Escribiendo totales de Bajas Bienes Propios"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("D{0}:E{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("D" & fila).Value = "RESUMEN DE BAJAS  - RUBRO BIENES PROPIOS"
            xl.Range("D" & fila).Font.Bold = True
            xl.Range("D" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 1).Value = "TOTAL DE INMUEBLES"
            xl.Range("D" & fila + 1).Font.Bold = True
            xl.Range("D" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
            xl.Range("D" & fila + 2).Font.Bold = True
            xl.Range("D" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 3).Value = "VALOR COMERCIAL TOTAL"
            xl.Range("D" & fila + 3).Font.Bold = True
            xl.Range("D" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = NrobajasxAnio ' loVariableRpt.TotalBajasBienesPropios
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 2).Value = Format(loVariableRpt.TotalAreaBajasBienesPropios, "##,##0.00") & " m2"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 3).Value = "S/." & Format(loVariableRpt.TotalValorBajasBienesPropios, "##,##0.00")
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Me.beprogreso.Caption = "Finalizando Bajas Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()




            '
            '                                                   ACTUALIZACIONES
            '
            Me.beprogreso.Caption = "Cargando Data de Actualizaciones Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            Dim ListaInmueblesLogs As List(Of EEInmueble.EEInmLogs) = Nothing
            Dim loCriteriosConsultas As New EECriterios() With {.tgGRubroId = "01", .FechaInicio = DateSerial(cboAnio.EditValue, 1, 1), .FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)}
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Actualizaciones").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "ACTUALIZACIONES DEL RUBRO BIENES PROPIOS " & cboAnio.Text & " DEL MARGESÍ MUNICIPAL MPT"
     
            If ListaInmueblesLogs IsNot Nothing Then
       
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} inmueble Actualizaciones en reporte Bienes Propios ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1
                
                Next
            Else
                fila = fila + 2
            End If
  

            Me.beprogreso.Caption = "Escribiendo totales en Actualizaciones Bienes Propios"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("E{0}:F{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium

            xl.Range("E" & fila).Value = "Total de inmuebles"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'xl.Range(String.Format("E{0}:F{0}", fila)).Select()
            'xl.Selection.MergeCells = True
            xl.Range("G" & fila).Value = cant - 1
            xl.Range("G" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            Me.beprogreso.Caption = "Finalizando Actualizaciones Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   INMUEBLES SANEADOS
            '
            Me.beprogreso.Caption = "Cargando Data de Inmuebles Saneados Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            ListaInmueblesLogs = Nothing
            loCriteriosConsultas.tgGRubroId = "01"
            loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
            loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
            loCriteriosConsultas.inmUpdDetCampo = "TgEstSanId"
            loCriteriosConsultas.inmUpdDetValorNew = "01"
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Inmuebles Saneados").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "INMUEBLES SANEADOS " & cboAnio.Text & " DEL RUBRO BIENES PROPIOS DEL MARGESÍ MUNICIPAL MPT"
            Dim act_san_count_bpropios, act_san_count_vias As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                act_san_count_bpropios = 0
                act_san_count_vias = 0
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} Inmuebles Saneados en reporte Bienes Propios ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1
                    If loinmueble.InmCodigo.Contains("Bienes Propios") = True Then
                        act_san_count_bpropios = act_san_count_bpropios + 1
                    ElseIf loinmueble.InmCodigo.Contains("Vías") = True Then
                        act_san_count_vias = act_san_count_vias + 1
                    End If
                Next
            Else
                fila = fila + 2
            End If


            Me.beprogreso.Caption = "Escribiendo totales de Saneados Bienes Propios"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("E{0}:G{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS SANEADOS BIENES PROPIOS"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = "Bienes Propios"
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
            xl.Selection.MergeCells = True

            xl.Range("E" & fila + 2).Value = "Vías"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
            xl.Selection.MergeCells = True

            xl.Range("E" & fila + 3).Value = "Total de Inmuebles"
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 3).Font.Bold = True
            xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
            xl.Selection.MergeCells = True

            xl.Range("G" & fila + 1).Value = act_san_count_bpropios
            xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 2).Value = act_san_count_vias
            xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 3).Value = act_san_count_bpropios + act_san_count_vias
            xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            Me.beprogreso.Caption = "Finalizando Inmuebles Saneados Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   INMUEBLES CANCELADOS
            '
            Me.beprogreso.Caption = "Cargando Data de Inmuebles Cancelados Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            ListaInmueblesLogs = Nothing
            loCriteriosConsultas.tgGRubroId = "01"
            loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
            loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
            loCriteriosConsultas.inmUpdDetCampo = "TgInmEstado"
            loCriteriosConsultas.inmUpdDetValorNew = "03"
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Inmuebles Cancelados").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "INMUEBLES CANCELADOS " & cboAnio.Text & " DEL RUBRO BIENES PROPIOS DEL MARGESÍ MUNICIPAL MPT"
            Dim count_can_bajas, count_can_duplicados, count_can_cambiouso As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                count_can_bajas = 0
                count_can_duplicados = 0
                count_can_cambiouso = 0
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} Inmuebles Cancelados en reporte Bienes Propios ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1


                    If loinmueble.inmUpdSup.ToLower.Contains("duplicidad") Then
                        count_can_duplicados = count_can_duplicados + 1
                    ElseIf loinmueble.inmUpdSup.ToLower.Contains("baja") Then
                        count_can_bajas = count_can_bajas + 1
                    ElseIf loinmueble.inmUpdSup.ToLower.Contains("cambio") Then
                        count_can_cambiouso = count_can_cambiouso + 1
                    End If

                    'If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("03") = True Or loinmueble._InmUpdDetValorNew2.Contains("06") = True) Then
                    '    count_can_bajas = count_can_bajas + 1
                    'ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                    '    count_can_duplicados = count_can_duplicados + 1
                    'ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
                    '    count_can_cambiouso = count_can_cambiouso + 1
                    'End If
                Next
            Else
                fila = fila + 2
            End If


            Me.beprogreso.Caption = "Escribiendo totales cancelados Bienes Propios"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("E{0}:G{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("E" & fila).Value = "RESUMEN DE REGISTROS CANCELADOS BIENES PROPIOS"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = "Duplicidad"
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 2).Value = "Baja"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 3).Value = "Cambio de Uso"
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 4).Value = "Total de Inmuebles"
            xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 4).Font.Bold = True
            xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
            xl.Selection.MergeCells = True
            xl.Range("G" & fila + 1).Value = count_can_duplicados
            xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 2).Value = count_can_bajas
            xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 3).Value = count_can_cambiouso
            xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 4).Value = count_can_bajas + count_can_cambiouso + count_can_duplicados
            xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            Me.beprogreso.Caption = "Finalizando Inmuebles Cancelados Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            If ruta Is Nothing Then
                If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO BIENES PROPIOS {1}", fbdExportar.SelectedPath, cboAnio.EditValue))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Bienes Propios"
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Me.beprogreso.EditValue = 0
                    Application.DoEvents()
                End If
            Else
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO BIENES PROPIOS {1}", ruta, cboAnio.Text))
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Bienes Propios"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Me.beprogreso.EditValue = 0
                Application.DoEvents()
            End If

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub ExportarReporteOtrosFines(Optional ByVal ruta As String = Nothing)
        Try
            xl = EEExcel.Instancia
            Me.beprogreso.Caption = "Abriendo Exel Temporal... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO OTROS FINES.xls", 1, True, 4)

            'consulta General
            Me.beprogreso.Caption = "Cargando Consulta General de Totales... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim loVariableRpt As EEInmueble.EEVariablesRpt = MantenimientosBL.Instancia.inmuebleMostrarTotalesByAnio(cboAnio.EditValue)
            If loVariableRpt IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Otros Fines total").Index).Select()
                xl.Range("D3").Value = "RUBRO OTROS FINES DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                xl.Range("F33").Value = "RESUMEN RUBRO OTROS FINES " & cboAnio.Text
                xl.Range("F40").Value = "RUBRO OTROS FINES " & cboAnio.Text
                xl.Range("G34").Value = loVariableRpt.TotalOtrosFines
                xl.Range("G35").Value = String.Format("{0} m2", Format(loVariableRpt.TotalAreaOtrosFines, "##,##0.00"))
                xl.Range("G36").Value = String.Format("{0} m2", Format(loVariableRpt.TotalAreaTechadaOtrosFines, "##,##0.00"))
                xl.Range("G37").Value = loVariableRpt.TotalValorOtrosFines
                xl.Range("G41").Value = loVariableRpt.CountOF_OtrosFines
            End If

            'Consulta  01
            Me.beprogreso.Caption = "Cargando Consulta Otros Fines... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim ListaInmuebles As List(Of EEInmueble) = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarXAnio_tgRubroId(cboAnio.EditValue, "08")
            Dim fila As String = 7
            Dim cant As Integer = 1
            If ListaInmuebles IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Otros Fines").Index).Select()
                xl.Range("B2").Value = "RUBRO OTROS FINES DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble en reporte del Rubro Otros Fines... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    ' Aliniar(fila)
                    xl.Range("C" & fila).Value = String.Format("File {0} - Otros Fines", loinmueble.InmFile) 'CÓDIGO MARGESÍ MPT(N° de file actual y rubro)
                    xl.Range("D" & fila).Value = "File " & loinmueble.InmFileAnt '"Registro antiguo" (N° de file antiguo)
                    xl.Range("E" & fila).Value = loinmueble.InmUbicacion ' Ubicación
                    xl.Range("F" & fila).Value = loinmueble.InmInscrito ' Finca Inscrita
                    xl.Range(String.Format("C{0}:D{0}", fila)).Interior.Color = RGB(242, 242, 242)
                    xl.Range("G" & fila).Value = loinmueble.InmDenominacion ' Finca Inscrita
                    xl.Range("H" & fila).Value = loinmueble.tgInmCondReg ' Estado
                    xl.Range("I" & fila).Value = loinmueble.InmPartidaElec ' Estado
                    xl.Range("J" & fila).Value = loinmueble.TgInmCondLegal ' Condicion Legal
                    xl.Range("K" & fila).Value = loinmueble.tgEstSan ' Proceso o Estado de Saneamiento
                    xl.Range("L" & fila).Value = CDbl(loinmueble.OInmPredio.InmPredArea) ' area m2 -- Predio
                    xl.Range("M" & fila).Value = loinmueble.tgInmSitFisica ' Uso actual
                    xl.Range("N" & fila).Value = loinmueble.tgInmSFUso ' Zonificacion
                    xl.Range("O" & fila).Value = loinmueble.tgEstInmConsv ' Estado de Conservacion
                    xl.Range("P" & fila).Value = IIf(loinmueble.InmDisponibilidad = 0, "NO", "SI") ' Disponibilidad
                    ' Valor Comercial
                    xl.Range("Q" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComAreaTechada) ' area Techada
                    xl.Range("R" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValxMetro) ' Valor por Metro 2
                    xl.Range("S" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTerreno) ' Valor del Terreno
                    xl.Range("T" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValConst) ' Valor de Edificacion o Construcion
                    xl.Range("U" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTotal) ' Valor comercial
                    xl.Range("V" & fila).Value = loinmueble.InmId ' Codigo Informatico
                    xl.Range("W" & fila).Value = loinmueble.inmSaneadoObsMostrable ' "..." ' Observacion
                    NewBorde(fila)
                    fila = fila + 1
                    cant = cant + 1
                Next
                Me.beprogreso.Caption = "Escribiendo totales del Rubro Otros Fines..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:F{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN RUBRO OTROS FINES"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 1).Value = "TOTAL DE INMUEBLES"
                xl.Range("E" & fila + 1).Font.Bold = True
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
                xl.Range("E" & fila + 2).Font.Bold = True
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 3).Value = "ÁREA CONSTRUIDA TOTAL"
                xl.Range("E" & fila + 3).Font.Bold = True
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 4).Value = "VALOR COMERCIAL TOTAL"
                xl.Range("E" & fila + 4).Font.Bold = True
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 1).Value = loVariableRpt.CountOF_OtrosFines
                xl.Range("F" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 2).Value = Format(loVariableRpt.itemAreaOF_OtrosFines, "##,##0.00") & " m2"
                xl.Range("F" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 3).Value = Format(loVariableRpt.itemAreaTechadaOF_OtrosFines, "##,##0.00") & " m2"
                xl.Range("F" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 4).Value = "S/." & Format(loVariableRpt.itemValorOF_OtrosFines, "##,##0.00")
                xl.Range("F" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Me.beprogreso.Caption = "Finalizando Rubro Otros Fines..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

            End If

            '
            '                                                   ALTAS
            '
            Me.beprogreso.Caption = "Cargando Data de Altas Otros Fines..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarAltasXAnio_tgGRubroId(cboAnio.EditValue, "02")
            xl.Sheets(xl.Worksheets("Altas").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "ALTAS " & cboAnio.Text & " DEL RUBRO OTROS FINES DEL MARGESÍ MUNICIPAL MPT"
            Dim TotalAltasXAnio As Int16 = 0
            If ListaInmuebles IsNot Nothing Then
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble Altas en reporte Otros Fines Altas... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmFile
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = Format(CDbl(loinmueble.OInmPredio.InmPredArea), "##,##0.00")
                    xl.Range("F" & fila).Value = "Alta"
                    xl.Range("G" & fila).Value = loinmueble.inmCausalAlta
                    xl.Range("H" & fila).Value = loinmueble.InmFecReg
                    xl.Range("I" & fila).Value = loinmueble.OInmValorComercial.InmValComValTotal
                    xl.Range("J" & fila).Value = loinmueble.inmDocAlta
                    xl.Range("K" & fila).Value = loinmueble.inmAltaObservacion
                    NewBordeK(fila)
                    fila = fila + 1
                    cant = cant + 1
                    TotalAltasXAnio = TotalAltasXAnio + 1
                Next
            Else
                fila = fila + 2
            End If
            Me.beprogreso.Caption = "Escribiendo totales de Altas Otros Fines"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("D{0}:E{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("D" & fila).Value = "RESUMEN DE ALTAS  - RUBRO OTROS FINES"
            xl.Range("D" & fila).Font.Bold = True
            xl.Range("D" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 1).Value = "TOTAL DE INMUEBLES"
            xl.Range("D" & fila + 1).Font.Bold = True
            xl.Range("D" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
            xl.Range("D" & fila + 2).Font.Bold = True
            xl.Range("D" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 3).Value = "VALOR COMERCIAL TOTAL"
            xl.Range("D" & fila + 3).Font.Bold = True
            xl.Range("D" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = TotalAltasXAnio 'Format(loVariableRpt.TotalAltasOtrosFines, "##,##0.00")
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 2).Value = Format(loVariableRpt.TotalAreaAltasOtrosFines, "##,##0.00") & " m2"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 3).Value = "S/." & Format(loVariableRpt.TotalValorAltasOtrosFines, "##,##0.00")
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Me.beprogreso.Caption = "Finalizando Altas Otros Fines..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   BAJAS
            '
            Me.beprogreso.Caption = "Cargando Data de Otros Fines..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarBajasXAnio_tgGRubroId(cboAnio.EditValue, "02")
            xl.Sheets(xl.Worksheets("Bajas").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "BAJAS " & cboAnio.Text & " DEL RUBRO OTROS FINES DEL MARGESÍ MUNICIPAL MPT"
            Dim NroBajasXAnio As Int16 = 0
            If ListaInmuebles IsNot Nothing Then
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble Altas en reporte Otros Fines Bajas... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmFile
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = Format(CDbl(loinmueble.OInmPredio.InmPredArea), "##,##0.00")
                    xl.Range("F" & fila).Value = "Baja"
                    xl.Range("G" & fila).Value = loinmueble.OInmBajas.InmBajaCausa
                    xl.Range("H" & fila).Value = loinmueble.OInmBajas.InmBajaFecha
                    xl.Range("I" & fila).Value = loinmueble.OInmValorComercial.InmValComValTotal
                    xl.Range("J" & fila).Value = loinmueble.OInmBajas.InmBajaNroDoc
                    xl.Range("K" & fila).Value = loinmueble.OInmBajas.InmBajaDatoAdicional
                    xl.Range("L" & fila).Value = loinmueble.OInmBajas.InmBajaObservacion
                    NewBordeL(fila)
                    fila = fila + 1
                    cant = cant + 1
                    NroBajasXAnio = NroBajasXAnio + 1
                Next
            Else
                fila = fila + 2
            End If


            Me.beprogreso.Caption = "Escribiendo totales de Bajas Otros Fines"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("D{0}:E{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("D" & fila).Value = "RESUMEN DE BAJAS  - RUBRO OTROS FINES"
            xl.Range("D" & fila).Font.Bold = True
            xl.Range("D" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 1).Value = "TOTAL DE INMUEBLES"
            xl.Range("D" & fila + 1).Font.Bold = True
            xl.Range("D" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
            xl.Range("D" & fila + 2).Font.Bold = True
            xl.Range("D" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 3).Value = "VALOR COMERCIAL TOTAL"
            xl.Range("D" & fila + 3).Font.Bold = True
            xl.Range("D" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = NroBajasXAnio 'loVariableRpt.TotalBajasOtrosFines
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 2).Value = Format(loVariableRpt.TotalAreaBajasOtrosFines, "##,##0.00") & " m2"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 3).Value = "S/." & Format(loVariableRpt.TotalValorBajasOtrosFines, "##,##0.00")
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Me.beprogreso.Caption = "Finalizando Bajas Otros Fines..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   ACTUALIZACIONES
            '
            Me.beprogreso.Caption = "Cargando Data de Actualizaciones Otros Fines..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            Dim ListaInmueblesLogs As List(Of EEInmueble.EEInmLogs) = Nothing
            Dim loCriteriosConsultas As New EECriterios() With {.tgGRubroId = "02", .FechaInicio = DateSerial(cboAnio.EditValue, 1, 1), .FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)}
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Actualizaciones").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "ACTUALIZACIONES DEL RUBRO OTROS FINES " & cboAnio.Text & " DEL MARGESÍ MUNICIPAL MPT"
            'Dim act_san_count As Integer
            'Dim act_vc_count As Integer
            'Dim act_rc_count As Integer
            'Dim act_dir_count As Integer
            'Dim act_dirf_count As Integer
            'Dim act_area_count As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                'act_san_count = 0
                'act_vc_count = 0
                'act_rc_count = 0
                'act_dir_count = 0
                'act_dirf_count = 0
                'act_area_count = 0
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} inmueble Actualizaciones en reporte Otros Fines ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1
                    'If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                    '    act_san_count = act_san_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                    '    act_vc_count = act_vc_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And loinmueble._InmUpdDetValorNew2 = "06" Then
                    '    act_rc_count = act_rc_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                    '    act_dir_count = act_dir_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                    '    act_dirf_count = act_dirf_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                    '    act_area_count = act_area_count + 1
                    'End If
                Next
            Else
                fila = fila + 2
            End If

            Me.beprogreso.Caption = "Escribiendo totales en Actualizaciones Otros Fines"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("E{0}:F{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium

            xl.Range("E" & fila).Value = "Total de inmuebles"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'xl.Range(String.Format("E{0}:F{0}", fila)).Select()
            'xl.Selection.MergeCells = True
            xl.Range("G" & fila).Value = cant - 1
            xl.Range("G" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            Me.beprogreso.Caption = "Finalizando Actualizaciones Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   INMUEBLES SANEADOS
            '
            Me.beprogreso.Caption = "Cargando Data de Inmuebles Saneados Otros Fines..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            ListaInmueblesLogs = Nothing
            loCriteriosConsultas.tgGRubroId = "02"
            loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
            loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
            loCriteriosConsultas.inmUpdDetCampo = "TgEstSanId"
            loCriteriosConsultas.inmUpdDetValorNew = "01"
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Inmuebles Saneados").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "INMUEBLES SANEADOS " & cboAnio.Text & " DEL RUBRO OTROS FINES DEL MARGESÍ MUNICIPAL MPT"
            Dim act_san_count_otrosFines As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                act_san_count_otrosFines = 0
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} Inmuebles Saneados en reporte Otros Fines ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1
                    act_san_count_otrosFines = act_san_count_otrosFines + 1
                Next
            Else
                fila = fila + 2
            End If


            Me.beprogreso.Caption = "Escribiendo totales de Saneados Otros Fines"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("E{0}:G{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS SANEADOS OTROS FINES"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = "Otros Fines"
            xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 2).Value = "Total de Inmuebles"
            xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 2).Font.Bold = True
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            xl.Range("G" & fila + 1).Value = act_san_count_otrosFines
            xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 2).Value = act_san_count_otrosFines
            xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
           

            Me.beprogreso.Caption = "Finalizando Inmuebles Saneados Otros Fines..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   INMUEBLES CANCELADOS
            '
            Me.beprogreso.Caption = "Cargando Data de Inmuebles Cancelados Otros Fines..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            ListaInmueblesLogs = Nothing
            loCriteriosConsultas.tgGRubroId = "02"
            loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
            loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
            loCriteriosConsultas.inmUpdDetCampo = "TgInmEstado"
            loCriteriosConsultas.inmUpdDetValorNew = "03"
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Inmuebles Cancelados").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "INMUEBLES CANCELADOS " & cboAnio.Text & " DEL RUBRO OTROS FINES DEL MARGESÍ MUNICIPAL MPT"
            Dim count_can_bajas, count_can_duplicados, count_can_cambiouso As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} Inmuebles Cancelados en reporte Otros Fines ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1
                    'If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("03") = True Or loinmueble._InmUpdDetValorNew2.Contains("06") = True) Then
                    '    count_can_bajas = count_can_bajas + 1
                    'ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                    '    count_can_duplicados = count_can_duplicados + 1
                    'ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
                    '    count_can_cambiouso = count_can_cambiouso + 1
                    'End If
                    If loinmueble.inmUpdSup.ToLower.Contains("duplicidad") Then
                        count_can_duplicados = count_can_duplicados + 1
                    ElseIf loinmueble.inmUpdSup.ToLower.Contains("baja") Then
                        count_can_bajas = count_can_bajas + 1
                    ElseIf loinmueble.inmUpdSup.ToLower.Contains("cambio") Then
                        count_can_cambiouso = count_can_cambiouso + 1
                    End If
                Next
            Else
                fila = fila + 2
            End If


            Me.beprogreso.Caption = "Escribiendo totales cancelados Otros Fines"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("E{0}:G{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("E" & fila).Value = "RESUMEN DE REGISTROS CANCELADOS OTROS FINES"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = "Duplicidad"
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 2).Value = "Baja"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 3).Value = "Cambio de Uso"
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 4).Value = "Total de Inmuebles"
            xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 4).Font.Bold = True
            xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
            xl.Selection.MergeCells = True
            xl.Range("G" & fila + 1).Value = count_can_duplicados
            xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 2).Value = count_can_bajas
            xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 3).Value = count_can_cambiouso
            xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 4).Value = count_can_bajas + count_can_cambiouso + count_can_duplicados
            xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


          
            'xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            Me.beprogreso.Caption = "Finalizando Inmuebles Cancelados Otros Fines..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            If ruta Is Nothing Then
                If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO OTROS FINES {1}", fbdExportar.SelectedPath, cboAnio.Text))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Otros Fines"
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                End If
            Else
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO OTROS FINES {1}", ruta, cboAnio.Text))
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Otros Fines"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            End If

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub ExportarReporteSerpar(Optional ByVal ruta As String = Nothing)
        Try
            xl = EEExcel.Instancia
            Me.beprogreso.Caption = "Abriendo Exel Temporal... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO SERPAR.xls", 1, True, 4)

            'consulta General
            Me.beprogreso.Caption = "Cargando Consulta General de Totales... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim loVariableRpt As EEInmueble.EEVariablesRpt = MantenimientosBL.Instancia.inmuebleMostrarTotalesByAnio(cboAnio.EditValue)
            If loVariableRpt IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Serpar total").Index).Select()
                xl.Range("D3").Value = "RUBRO SERPAR DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                xl.Range("F31").Value = "RESUMEN RUBRO SERPAR " & cboAnio.Text
                xl.Range("F38").Value = "RUBRO SERPAR " & cboAnio.Text
                xl.Range("G32").Value = loVariableRpt.TotalSerpar
                xl.Range("G32").Value = loVariableRpt.TotalSerpar
                xl.Range("G33").Value = String.Format("{0} m2", Format(loVariableRpt.TotalAreaSerpar, "##,##0.00"))
                xl.Range("G34").Value = String.Format("{0} m2", Format(loVariableRpt.TotalAreaTechadaSerpar, "##,##0.00"))
                xl.Range("G35").Value = loVariableRpt.TotalValorSerpar
                xl.Range("G39").Value = loVariableRpt.CountS_Serpar
            End If

            'Consulta  01
            Me.beprogreso.Caption = "Cargando Consulta Serpar... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim ListaInmuebles As List(Of EEInmueble) = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarXAnio_tgRubroId(cboAnio.EditValue, "07")
            Dim fila As String = 7
            Dim cant As Integer = 1
            If ListaInmuebles IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Serpar").Index).Select()
                xl.Range("B2").Value = "RUBRO SERPAR DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble en reporte del Rubro Serpar... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    ' Aliniar(fila)
                    xl.Range("C" & fila).Value = String.Format("File {0} - Serpar", loinmueble.InmFile) 'CÓDIGO MARGESÍ MPT(N° de file actual y rubro)
                    xl.Range("D" & fila).Value = "File " & loinmueble.InmFileAnt '"Registro antiguo" (N° de file antiguo)
                    xl.Range("E" & fila).Value = loinmueble.InmUbicacion ' Ubicación
                    xl.Range("F" & fila).Value = loinmueble.InmInscrito ' Finca Inscrita
                    xl.Range(String.Format("C{0}:D{0}", fila)).Interior.Color = RGB(242, 242, 242)
                    xl.Range("G" & fila).Value = loinmueble.InmDenominacion ' Finca Inscrita
                    xl.Range("H" & fila).Value = loinmueble.tgInmCondReg ' Estado
                    xl.Range("I" & fila).Value = loinmueble.InmPartidaElec ' Estado
                    xl.Range("J" & fila).Value = loinmueble.TgInmCondLegal ' Condicion Legal
                    xl.Range("K" & fila).Value = loinmueble.tgEstSan ' Proceso o Estado de Saneamiento
                    xl.Range("L" & fila).Value = CDbl(loinmueble.OInmPredio.InmPredArea) ' area m2 -- Predio
                    xl.Range("M" & fila).Value = loinmueble.tgInmSitFisica ' Uso actual
                    xl.Range("N" & fila).Value = loinmueble.tgInmSFUso ' Zonificacion
                    xl.Range("O" & fila).Value = loinmueble.tgEstInmConsv ' Estado de Conservacion
                    xl.Range("P" & fila).Value = IIf(loinmueble.InmDisponibilidad = 0, "NO", "SI") ' Disponibilidad
                    ' Valor Comercial
                    xl.Range("Q" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComAreaTechada) ' area Techada
                    xl.Range("R" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValxMetro) ' Valor por Metro 2
                    xl.Range("S" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTerreno) ' Valor del Terreno
                    xl.Range("T" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValConst) ' Valor de Edificacion o Construcion
                    xl.Range("U" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTotal) ' Valor comercial
                    xl.Range("V" & fila).Value = loinmueble.InmId ' Codigo Informatico
                    xl.Range("W" & fila).Value = loinmueble.inmSaneadoObsMostrable '"..." ' Observacion
                    NewBorde(fila)
                    fila = fila + 1
                    cant = cant + 1
                Next
                Me.beprogreso.Caption = "Escribiendo totales del Rubro Serpar..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:F{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN RUBRO SERPAR"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 1).Value = "TOTAL DE INMUEBLES"
                xl.Range("E" & fila + 1).Font.Bold = True
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
                xl.Range("E" & fila + 2).Font.Bold = True
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 3).Value = "ÁREA CONSTRUIDA TOTAL"
                xl.Range("E" & fila + 3).Font.Bold = True
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 4).Value = "VALOR COMERCIAL TOTAL"
                xl.Range("E" & fila + 4).Font.Bold = True
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 1).Value = loVariableRpt.CountS_Serpar
                xl.Range("F" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 2).Value = Format(loVariableRpt.itemAreaS_Serpar, "##,##0.00") & " m2"
                xl.Range("F" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 3).Value = Format(loVariableRpt.itemAreaTechadaS_Serpar, "##,##0.00") & " m2"
                xl.Range("F" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 4).Value = "S/." & Format(loVariableRpt.itemValorS_Serpar, "##,##0.00")
                xl.Range("F" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Me.beprogreso.Caption = "Finalizando Rubro Serpar..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

            End If

            '
            '                                                   ALTAS
            '
            Me.beprogreso.Caption = "Cargando Data de Altas Serpar..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarAltasXAnio_tgGRubroId(cboAnio.EditValue, "04")
            xl.Sheets(xl.Worksheets("Altas").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "ALTAS " & cboAnio.Text & " DEL RUBRO SERPAR DEL MARGESÍ MUNICIPAL MPT"

            Dim NroAltasXAnio As Int16 = 0
            If ListaInmuebles IsNot Nothing Then
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble Altas en reporte Serpar Altas... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmFile
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = Format(CDbl(loinmueble.OInmPredio.InmPredArea), "##,##0.00")
                    xl.Range("F" & fila).Value = "Alta"
                    xl.Range("G" & fila).Value = loinmueble.inmCausalAlta
                    xl.Range("H" & fila).Value = loinmueble.InmFecReg
                    xl.Range("I" & fila).Value = loinmueble.OInmValorComercial.InmValComValTotal
                    xl.Range("J" & fila).Value = loinmueble.inmDocAlta
                    xl.Range("k" & fila).Value = loinmueble.inmAltaObservacion
                    NewBordeK(fila)
                    fila = fila + 1
                    cant = cant + 1
                    NroAltasXAnio = NroAltasXAnio + 1
                Next
            Else
                fila = fila + 2
            End If
            Me.beprogreso.Caption = "Escribiendo totales de Altas Serpar"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("D{0}:E{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("D" & fila).Value = "RESUMEN DE ALTAS  - RUBRO SERPAR"
            xl.Range("D" & fila).Font.Bold = True
            xl.Range("D" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 1).Value = "TOTAL DE INMUEBLES"
            xl.Range("D" & fila + 1).Font.Bold = True
            xl.Range("D" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
            xl.Range("D" & fila + 2).Font.Bold = True
            xl.Range("D" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 3).Value = "VALOR COMERCIAL TOTAL"
            xl.Range("D" & fila + 3).Font.Bold = True
            xl.Range("D" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = NroAltasXAnio 'loVariableRpt.TotalAltasSerpar
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 2).Value = Format(loVariableRpt.TotalAreaAltasSerpar, "##,##0.00") & " m2"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 3).Value = "S/." & Format(loVariableRpt.TotalValorAltasSerpar, "##,##0.00")
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Me.beprogreso.Caption = "Finalizando Altas Serpar..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   BAJAS
            '
            Me.beprogreso.Caption = "Cargando Data de Serpar..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarBajasXAnio_tgGRubroId(cboAnio.EditValue, "04")
            xl.Sheets(xl.Worksheets("Bajas").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "BAJAS " & cboAnio.Text & " DEL RUBRO SERPAR DEL MARGESÍ MUNICIPAL MPT"
            Dim NroBajasXAnio As Int16 = 0
            If ListaInmuebles IsNot Nothing Then
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble Altas en reporte Serpar Bajas... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmFile
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = Format(CDbl(loinmueble.OInmPredio.InmPredArea), "##,##0.00")
                    xl.Range("F" & fila).Value = "Baja"
                    xl.Range("G" & fila).Value = loinmueble.OInmBajas.InmBajaCausa
                    xl.Range("H" & fila).Value = loinmueble.OInmBajas.InmBajaFecha
                    xl.Range("I" & fila).Value = loinmueble.OInmValorComercial.InmValComValTotal
                    xl.Range("J" & fila).Value = loinmueble.OInmBajas.InmBajaNroDoc
                    xl.Range("K" & fila).Value = loinmueble.OInmBajas.InmBajaDatoAdicional
                    xl.Range("L" & fila).Value = loinmueble.OInmBajas.InmBajaObservacion
                    NewBordeL(fila)
                    fila = fila + 1
                    cant = cant + 1
                    NroBajasXAnio = NroBajasXAnio + 1
                Next
            Else
                fila = fila + 2
            End If
            Me.beprogreso.Caption = "Escribiendo totales de Bajas Serpar"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("D{0}:E{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("D" & fila).Value = "RESUMEN DE BAJAS  - RUBRO SERPAR"
            xl.Range("D" & fila).Font.Bold = True
            xl.Range("D" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 1).Value = "TOTAL DE INMUEBLES"
            xl.Range("D" & fila + 1).Font.Bold = True
            xl.Range("D" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
            xl.Range("D" & fila + 2).Font.Bold = True
            xl.Range("D" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 3).Value = "VALOR COMERCIAL TOTAL"
            xl.Range("D" & fila + 3).Font.Bold = True
            xl.Range("D" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = NroBajasXAnio ' loVariableRpt.TotalBajasSerpar
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 2).Value = Format(loVariableRpt.TotalAreaBajasSerpar, "##,##0.00") & " m2"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 3).Value = "S/." & Format(loVariableRpt.TotalValorBajasSerpar, "##,##0.00")
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Me.beprogreso.Caption = "Finalizando Bajas Serpar..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   ACTUALIZACIONES
            '
            Me.beprogreso.Caption = "Cargando Data de Actualizaciones Serpar..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            Dim ListaInmueblesLogs As List(Of EEInmueble.EEInmLogs) = Nothing
            Dim loCriteriosConsultas As New EECriterios() With {.tgGRubroId = "04", .FechaInicio = DateSerial(cboAnio.EditValue, 1, 1), .FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)}
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Actualizaciones").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "ACTUALIZACIONES DEL RUBRO SERPAR " & cboAnio.Text & " DEL MARGESÍ MUNICIPAL MPT"
            'Dim act_san_count As Integer
            'Dim act_vc_count As Integer
            'Dim act_rc_count As Integer
            'Dim act_dir_count As Integer
            'Dim act_dirf_count As Integer
            'Dim act_area_count As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                'act_san_count = 0
                'act_vc_count = 0
                'act_rc_count = 0
                'act_dir_count = 0
                'act_dirf_count = 0
                'act_area_count = 0
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} inmueble Actualizaciones en reporte Serpar ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1
                    'If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                    '    act_san_count = act_san_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                    '    act_vc_count = act_vc_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And loinmueble._InmUpdDetValorNew2 = "06" Then
                    '    act_rc_count = act_rc_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                    '    act_dir_count = act_dir_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                    '    act_dirf_count = act_dirf_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                    '    act_area_count = act_area_count + 1
                    'End If
                Next
            Else
                fila = fila + 2
            End If

            Me.beprogreso.Caption = "Escribiendo totales en Actualizaciones Serpar"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
              fila = fila + 1
            xl.Range(String.Format("E{0}:F{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium

            xl.Range("E" & fila).Value = "Total de inmuebles"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'xl.Range(String.Format("E{0}:F{0}", fila)).Select()
            'xl.Selection.MergeCells = True
            xl.Range("G" & fila).Value = cant - 1
            xl.Range("G" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            Me.beprogreso.Caption = "Finalizando Actualizaciones Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()


            '
            '                                                   INMUEBLES SANEADOS
            '
            Me.beprogreso.Caption = "Cargando Data de Inmuebles Saneados Serpar..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            ListaInmueblesLogs = Nothing
            loCriteriosConsultas.tgGRubroId = "04"
            loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
            loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
            loCriteriosConsultas.inmUpdDetCampo = "TgEstSanId"
            loCriteriosConsultas.inmUpdDetValorNew = "01"
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Inmuebles Saneados").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "INMUEBLES SANEADOS " & cboAnio.Text & " DEL RUBRO SERPAR DEL MARGESÍ MUNICIPAL MPT"

            Dim act_san_count_Serpar As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                act_san_count_Serpar = 0
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} Inmuebles Saneados en reporte Serpar ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1
                    act_san_count_Serpar = act_san_count_Serpar + 1
                Next
            Else
                fila = fila + 2
            End If


            Me.beprogreso.Caption = "Escribiendo totales de Saneados Serpar"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("E{0}:G{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS SANEADOS SERPAR"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            xl.Range("E" & fila + 1).Value = "Serpar"
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
            xl.Selection.MergeCells = True

            xl.Range("E" & fila + 2).Value = "Total de Inmuebles"
            xl.Range("E" & fila + 2).Font.Bold = True
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
            xl.Selection.MergeCells = True

            xl.Range("G" & fila + 1).Value = act_san_count_Serpar
            xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            xl.Range("G" & fila + 2).Value = act_san_count_Serpar
            xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


            Me.beprogreso.Caption = "Finalizando Inmuebles Saneados Serpar..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   INMUEBLES CANCELADOS
            '
            Me.beprogreso.Caption = "Cargando Data de Inmuebles Cancelados Serpar..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            ListaInmueblesLogs = Nothing
            loCriteriosConsultas.tgGRubroId = "04"
            loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
            loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
            loCriteriosConsultas.inmUpdDetCampo = "TgInmEstado"
            loCriteriosConsultas.inmUpdDetValorNew = "03"
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Inmuebles Cancelados").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "INMUEBLES CANCELADOS " & cboAnio.Text & " DEL RUBRO SERPAR DEL MARGESÍ MUNICIPAL MPT"
            Dim count_can_bajas, count_can_duplicados, count_can_cambiouso As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} Inmuebles Cancelados en reporte Serpar ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1

                    'If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("03") = True Or loinmueble._InmUpdDetValorNew2.Contains("06") = True) Then
                    '    count_can_bajas = count_can_bajas + 1
                    'ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                    '    count_can_duplicados = count_can_duplicados + 1
                    'ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
                    '    count_can_cambiouso = count_can_cambiouso + 1
                    'End If
                    If loinmueble.inmUpdSup.ToLower.Contains("duplicidad") Then
                        count_can_duplicados = count_can_duplicados + 1
                    ElseIf loinmueble.inmUpdSup.ToLower.Contains("baja") Then
                        count_can_bajas = count_can_bajas + 1
                    ElseIf loinmueble.inmUpdSup.ToLower.Contains("cambio") Then
                        count_can_cambiouso = count_can_cambiouso + 1
                    End If
                Next
            Else
                fila = fila + 2
            End If

            Me.beprogreso.Caption = "Escribiendo totales cancelados Serpar"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("E{0}:G{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("E" & fila).Value = "RESUMEN DE REGISTROS CANCELADOS SERPAR"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = "Duplicidad"
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 2).Value = "Baja"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 3).Value = "Cambio de Uso"
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 4).Value = "Total de Inmuebles"
            xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 4).Font.Bold = True
            xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
            xl.Selection.MergeCells = True
            xl.Range("G" & fila + 1).Value = count_can_duplicados
            xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 2).Value = count_can_bajas
            xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 3).Value = count_can_cambiouso
            xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 4).Value = count_can_bajas + count_can_cambiouso + count_can_duplicados
            xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


            Me.beprogreso.Caption = "Finalizando Inmuebles Cancelados Serpar..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()


            If ruta Is Nothing Then
                If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO SERPAR_{1}", fbdExportar.SelectedPath, cboAnio.EditValue))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Serpar"
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                End If
            Else
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO SERPAR_{1}", ruta, cboAnio.EditValue))
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Serpar"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            End If

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub ExportarReporteAreasVerdes(Optional ByVal ruta As String = Nothing)
        Try
            xl = EEExcel.Instancia
            Me.beprogreso.Caption = "Abriendo Exel Temporal... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO ÁREAS VERDES.xls", 1, True, 4)

            'consulta General
            Me.beprogreso.Caption = "Cargando Consulta General de Totales... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim loVariableRpt As EEInmueble.EEVariablesRpt = MantenimientosBL.Instancia.inmuebleMostrarTotalesByAnio(cboAnio.EditValue)
            If loVariableRpt IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Áreas Verdes Total").Index).Select()
                xl.Range("E3").Value = "RUBRO ÁREAS VERDES DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                xl.Range("G27").Value = "RESUMEN RUBRO ÁREAS VERDES " & cboAnio.Text
                xl.Range("G34").Value = "RUBRO ÁREAS VERDES " & cboAnio.Text
                xl.Range("H28").Value = loVariableRpt.TotalAreasVerdes
                xl.Range("H29").Value = String.Format("{0} m2", Format(loVariableRpt.TotalAreaAreasVerdes, "##,##0.00"))
                xl.Range("H30").Value = String.Format("{0} m2", Format(loVariableRpt.TotalAreaTechadaAreasVerdes, "##,##0.00"))
                xl.Range("H31").Value = loVariableRpt.TotalValorAreasVerdes

                xl.Range("H35").Value = loVariableRpt.CountAV_Parques
                xl.Range("H36").Value = loVariableRpt.CountAV_Plazuelas
                xl.Range("H37").Value = loVariableRpt.CountAV_Bermas
                xl.Range("H38").Value = loVariableRpt.CountAV_Viveros
                xl.Range("H39").Value = loVariableRpt.TotalAreasVerdes
            End If

            'Consulta  Parques
            Me.beprogreso.Caption = "Cargando Consulta Areas Verdes Parques... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim ListaInmuebles As List(Of EEInmueble) = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarXAnio_tgRubroId(cboAnio.EditValue, "03")
            Dim fila As String = 7
            Dim cant As Integer = 1
            If ListaInmuebles IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Parques").Index).Select()
                xl.Range("B2").Value = "RUBRO ÁREAS VERDES - PARQUES DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble en reporte del Rubro Áreas Verdes Plazuelas... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    ' Aliniar(fila)
                    xl.Range("C" & fila).Value = String.Format("File {0} - Áreas Verdes " & Chr(34) & "Parques" & Chr(34), loinmueble.InmFile) 'CÓDIGO MARGESÍ MPT(N° de file actual y rubro)
                    xl.Range("D" & fila).Value = "File " & loinmueble.InmFileAnt '"Registro antiguo" (N° de file antiguo)
                    xl.Range("E" & fila).Value = loinmueble.InmUbicacion ' Ubicación
                    xl.Range("F" & fila).Value = loinmueble.InmInscrito ' Finca Inscrita
                    xl.Range(String.Format("C{0}:D{0}", fila)).Interior.Color = RGB(242, 242, 242)
                    xl.Range("G" & fila).Value = loinmueble.InmDenominacion ' Finca Inscrita
                    xl.Range("H" & fila).Value = loinmueble.tgInmCondReg ' Estado
                    xl.Range("I" & fila).Value = loinmueble.InmPartidaElec ' Estado
                    xl.Range("J" & fila).Value = loinmueble.TgInmCondLegal ' Condicion Legal
                    xl.Range("K" & fila).Value = loinmueble.tgEstSan ' Proceso o Estado de Saneamiento
                    xl.Range("L" & fila).Value = CDbl(loinmueble.OInmPredio.InmPredArea) ' area m2 -- Predio
                    xl.Range("M" & fila).Value = loinmueble.tgInmSitFisica ' Uso actual
                    xl.Range("N" & fila).Value = loinmueble.tgInmSFUso ' Zonificacion
                    xl.Range("O" & fila).Value = loinmueble.tgEstInmConsv ' Estado de Conservacion
                    xl.Range("P" & fila).Value = IIf(loinmueble.InmDisponibilidad = 0, "NO", "SI") ' Disponibilidad
                    ' Valor Comercial
                    xl.Range("Q" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComAreaTechada) ' area Techada
                    xl.Range("R" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValxMetro) ' Valor por Metro 2
                    xl.Range("S" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTerreno) ' Valor del Terreno
                    xl.Range("T" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValConst) ' Valor de Edificacion o Construcion
                    xl.Range("U" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTotal) ' Valor comercial
                    xl.Range("V" & fila).Value = loinmueble.InmId ' Codigo Informatico
                    xl.Range("W" & fila).Value = loinmueble.inmSaneadoObsMostrable '"..." ' Observacion
                    NewBorde(fila)
                    fila = fila + 1
                    cant = cant + 1
                Next
                Me.beprogreso.Caption = "Escribiendo totales del Rubro Áreas Verdes Parques..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:F{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN RUBRO ÁREAS VERDES - PARQUES"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 1).Value = "TOTAL DE INMUEBLES"
                xl.Range("E" & fila + 1).Font.Bold = True
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
                xl.Range("E" & fila + 2).Font.Bold = True
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 3).Value = "ÁREA CONSTRUIDA TOTAL"
                xl.Range("E" & fila + 3).Font.Bold = True
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 4).Value = "VALOR COMERCIAL TOTAL"
                xl.Range("E" & fila + 4).Font.Bold = True
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 1).Value = loVariableRpt.CountAV_Parques
                xl.Range("F" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 2).Value = Format(loVariableRpt.itemAreaAV_Parques, "##,##0.00") & " m2"
                xl.Range("F" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 3).Value = Format(loVariableRpt.itemAreaTechadaAV_Parques, "##,##0.00") & " m2"
                xl.Range("F" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 4).Value = "S/." & Format(loVariableRpt.itemValorAV_Parques, "##,##0.00")
                xl.Range("F" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Me.beprogreso.Caption = "Finalizando Rubro Áreas Verdes Parques..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

            End If

            'Consulta  Plazuelas
            Me.beprogreso.Caption = "Cargando Consulta Areas Verdes Plazuelas... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarXAnio_tgRubroId(cboAnio.EditValue, "04")
            fila = 7
            cant = 1
            If ListaInmuebles IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Plazuelas").Index).Select()
                xl.Range("B2").Value = "RUBRO ÁREAS VERDES - PLAZUELAS DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble en reporte del Rubro Áreas Verdes Plazuelas... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    ' Aliniar(fila)
                    xl.Range("C" & fila).Value = String.Format("File {0} - Áreas Verdes " & Chr(34) & "Plazuelas" & Chr(34), loinmueble.InmFile) 'CÓDIGO MARGESÍ MPT(N° de file actual y rubro)
                    xl.Range("D" & fila).Value = "File " & loinmueble.InmFileAnt '"Registro antiguo" (N° de file antiguo)
                    xl.Range("E" & fila).Value = loinmueble.InmUbicacion ' Ubicación
                    xl.Range("F" & fila).Value = loinmueble.InmInscrito ' Finca Inscrita
                    xl.Range(String.Format("C{0}:D{0}", fila)).Interior.Color = RGB(242, 242, 242)
                    xl.Range("G" & fila).Value = loinmueble.InmDenominacion ' Finca Inscrita
                    xl.Range("H" & fila).Value = loinmueble.tgInmCondReg ' Estado
                    xl.Range("I" & fila).Value = loinmueble.InmPartidaElec ' Estado
                    xl.Range("J" & fila).Value = loinmueble.TgInmCondLegal ' Condicion Legal
                    xl.Range("K" & fila).Value = loinmueble.tgEstSan ' Proceso o Estado de Saneamiento
                    xl.Range("L" & fila).Value = CDbl(loinmueble.OInmPredio.InmPredArea) ' area m2 -- Predio
                    xl.Range("M" & fila).Value = loinmueble.tgInmSitFisica ' Uso actual
                    xl.Range("N" & fila).Value = loinmueble.tgInmSFUso ' Zonificacion
                    xl.Range("O" & fila).Value = loinmueble.tgEstInmConsv ' Estado de Conservacion
                    xl.Range("P" & fila).Value = IIf(loinmueble.InmDisponibilidad = 0, "NO", "SI") ' Disponibilidad
                    ' Valor Comercial
                    xl.Range("Q" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComAreaTechada) ' area Techada
                    xl.Range("R" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValxMetro) ' Valor por Metro 2
                    xl.Range("S" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTerreno) ' Valor del Terreno
                    xl.Range("T" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValConst) ' Valor de Edificacion o Construcion
                    xl.Range("U" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTotal) ' Valor comercial
                    xl.Range("V" & fila).Value = loinmueble.InmId ' Codigo Informatico
                    xl.Range("W" & fila).Value = loinmueble.inmSaneadoObsMostrable ' "..." ' Observacion
                    NewBorde(fila)
                    fila = fila + 1
                    cant = cant + 1
                Next
                Me.beprogreso.Caption = "Escribiendo totales del Rubro Áreas Verdes Plazuelas..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:F{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN RUBRO ÁREAS VERDES - PLAZUELAS"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 1).Value = "TOTAL DE INMUEBLES"
                xl.Range("E" & fila + 1).Font.Bold = True
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
                xl.Range("E" & fila + 2).Font.Bold = True
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 3).Value = "ÁREA CONSTRUIDA TOTAL"
                xl.Range("E" & fila + 3).Font.Bold = True
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 4).Value = "VALOR COMERCIAL TOTAL"
                xl.Range("E" & fila + 4).Font.Bold = True
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 1).Value = loVariableRpt.CountAV_Plazuelas
                xl.Range("F" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 2).Value = Format(loVariableRpt.itemAreaAV_Plazuelas, "##,##0.00") & " m2"
                xl.Range("F" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 3).Value = Format(loVariableRpt.itemAreaTechadaAV_Plazuelas, "##,##0.00") & " m2"
                xl.Range("F" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 4).Value = "S/." & Format(loVariableRpt.itemValorAV_Plazuelas, "##,##0.00")
                xl.Range("F" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Me.beprogreso.Caption = "Finalizando Rubro Áreas Verdes Plazuelas..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

            End If

            'Consulta  Bermas
            Me.beprogreso.Caption = "Cargando Consulta Areas Verdes Bermas... "
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarXAnio_tgRubroId(cboAnio.EditValue, "05")
            fila = 7
            cant = 1
            If ListaInmuebles IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Bermas").Index).Select()
                xl.Range("B2").Value = "RUBRO ÁREAS VERDES - BERMAS DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble en reporte del Rubro Áreas Verdes Bermas... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    ' Aliniar(fila)
                    xl.Range("C" & fila).Value = String.Format("File {0} - Áreas Verdes " & Chr(34) & "Bermas" & Chr(34), loinmueble.InmFile) 'CÓDIGO MARGESÍ MPT(N° de file actual y rubro)
                    xl.Range("D" & fila).Value = "File " & loinmueble.InmFileAnt '"Registro antiguo" (N° de file antiguo)
                    xl.Range("E" & fila).Value = loinmueble.InmUbicacion ' Ubicación
                    xl.Range("F" & fila).Value = loinmueble.InmInscrito ' Finca Inscrita
                    xl.Range(String.Format("C{0}:D{0}", fila)).Interior.Color = RGB(242, 242, 242)
                    xl.Range("G" & fila).Value = loinmueble.InmDenominacion ' Finca Inscrita
                    xl.Range("H" & fila).Value = loinmueble.tgInmCondReg ' Estado
                    xl.Range("I" & fila).Value = loinmueble.InmPartidaElec ' Estado
                    xl.Range("J" & fila).Value = loinmueble.TgInmCondLegal ' Condicion Legal
                    xl.Range("K" & fila).Value = loinmueble.tgEstSan ' Proceso o Estado de Saneamiento
                    xl.Range("L" & fila).Value = CDbl(loinmueble.OInmPredio.InmPredArea) ' area m2 -- Predio
                    xl.Range("M" & fila).Value = loinmueble.tgInmSitFisica ' Uso actual
                    xl.Range("N" & fila).Value = loinmueble.tgInmSFUso ' Zonificacion
                    xl.Range("O" & fila).Value = loinmueble.tgEstInmConsv ' Estado de Conservacion
                    xl.Range("P" & fila).Value = IIf(loinmueble.InmDisponibilidad = 0, "NO", "SI") ' Disponibilidad
                    ' Valor Comercial
                    xl.Range("Q" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComAreaTechada) ' area Techada
                    xl.Range("R" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValxMetro) ' Valor por Metro 2
                    xl.Range("S" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTerreno) ' Valor del Terreno
                    xl.Range("T" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValConst) ' Valor de Edificacion o Construcion
                    xl.Range("U" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTotal) ' Valor comercial
                    xl.Range("V" & fila).Value = loinmueble.InmId ' Codigo Informatico
                    xl.Range("W" & fila).Value = loinmueble.inmSaneadoObsMostrable '"..." ' Observacion
                    NewBorde(fila)
                    fila = fila + 1
                    cant = cant + 1
                Next
                Me.beprogreso.Caption = "Escribiendo totales del Rubro Áreas Verdes Bermas..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:F{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN RUBRO ÁREAS VERDES - BERMAS"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 1).Value = "TOTAL DE INMUEBLES"
                xl.Range("E" & fila + 1).Font.Bold = True
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
                xl.Range("E" & fila + 2).Font.Bold = True
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 3).Value = "ÁREA CONSTRUIDA TOTAL"
                xl.Range("E" & fila + 3).Font.Bold = True
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 4).Value = "VALOR COMERCIAL TOTAL"
                xl.Range("E" & fila + 4).Font.Bold = True
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 1).Value = loVariableRpt.CountAV_Bermas
                xl.Range("F" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 2).Value = Format(loVariableRpt.itemAreaAV_Bermas, "##,##0.00") & " m2"
                xl.Range("F" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 3).Value = Format(loVariableRpt.itemAreaTechadaAV_Bermas, "##,##0.00") & " m2"
                xl.Range("F" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 4).Value = "S/." & Format(loVariableRpt.itemValorAV_Bermas, "##,##0.00")
                xl.Range("F" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Me.beprogreso.Caption = "Finalizando Rubro Áreas Verdes Bermas..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
            End If

            'Consulta  Viveros
            Me.beprogreso.Caption = "Cargando Consulta Areas Verdes Viveros... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarXAnio_tgRubroId(cboAnio.EditValue, "06")
            fila = 7
            cant = 1
            If ListaInmuebles IsNot Nothing Then
                xl.Sheets(xl.Worksheets("Viveros").Index).Select()
                xl.Range("B2").Value = "RUBRO ÁREAS VERDES - VIVEROS DEL MARGESÍ MUNICIPAL MPT " & cboAnio.Text
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble en reporte del Rubro Áreas Verdes Viveros... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    ' Aliniar(fila)
                    xl.Range("C" & fila).Value = String.Format("File {0} -  Áreas  Verdes " & Chr(34) & "Viveros" & Chr(34), loinmueble.InmFile) 'CÓDIGO MARGESÍ MPT(N° de file actual y rubro)
                    xl.Range("D" & fila).Value = "File " & loinmueble.InmFileAnt '"Registro antiguo" (N° de file antiguo)
                    xl.Range("E" & fila).Value = loinmueble.InmUbicacion ' Ubicación
                    xl.Range("F" & fila).Value = loinmueble.InmInscrito ' Finca Inscrita
                    xl.Range(String.Format("C{0}:D{0}", fila)).Interior.Color = RGB(242, 242, 242)
                    xl.Range("G" & fila).Value = loinmueble.InmDenominacion ' Finca Inscrita
                    xl.Range("H" & fila).Value = loinmueble.tgInmCondReg ' Estado
                    xl.Range("I" & fila).Value = loinmueble.InmPartidaElec ' Estado
                    xl.Range("J" & fila).Value = loinmueble.TgInmCondLegal ' Condicion Legal
                    xl.Range("K" & fila).Value = loinmueble.tgEstSan ' Proceso o Estado de Saneamiento
                    xl.Range("L" & fila).Value = CDbl(loinmueble.OInmPredio.InmPredArea) ' area m2 -- Predio
                    xl.Range("M" & fila).Value = loinmueble.tgInmSitFisica ' Uso actual
                    xl.Range("N" & fila).Value = loinmueble.tgInmSFUso ' Zonificacion
                    xl.Range("O" & fila).Value = loinmueble.tgEstInmConsv ' Estado de Conservacion
                    xl.Range("P" & fila).Value = IIf(loinmueble.InmDisponibilidad = 0, "NO", "SI") ' Disponibilidad
                    ' Valor Comercial
                    xl.Range("Q" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComAreaTechada) ' area Techada
                    xl.Range("R" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValxMetro) ' Valor por Metro 2
                    xl.Range("S" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTerreno) ' Valor del Terreno
                    xl.Range("T" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValConst) ' Valor de Edificacion o Construcion
                    xl.Range("U" & fila).Value = CDbl(loinmueble.OInmValorComercial.InmValComValTotal) ' Valor comercial
                    xl.Range("V" & fila).Value = loinmueble.InmId ' Codigo Informatico
                    xl.Range("W" & fila).Value = loinmueble.inmSaneadoObsMostrable '"..." ' Observacion
                    NewBorde(fila)
                    fila = fila + 1
                    cant = cant + 1
                Next
                Me.beprogreso.Caption = "Escribiendo totales del Rubro Áreas Verdes Viveros..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:F{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:F{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN RUBRO ÁREAS VERDES - VIVEROS"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 1).Value = "TOTAL DE INMUEBLES"
                xl.Range("E" & fila + 1).Font.Bold = True
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
                xl.Range("E" & fila + 2).Font.Bold = True
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 3).Value = "ÁREA CONSTRUIDA TOTAL"
                xl.Range("E" & fila + 3).Font.Bold = True
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 4).Value = "VALOR COMERCIAL TOTAL"
                xl.Range("E" & fila + 4).Font.Bold = True
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 1).Value = loVariableRpt.CountAV_Viveros
                xl.Range("F" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 2).Value = Format(loVariableRpt.itemAreaAV_Viveros, "##,##0.00") & " m2"
                xl.Range("F" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 3).Value = Format(loVariableRpt.itemAreaTechadaAV_Viveros, "##,##0.00") & " m2"
                xl.Range("F" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("F" & fila + 4).Value = "S/." & Format(loVariableRpt.itemValorAV_Viveros, "##,##0.00")
                xl.Range("F" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Me.beprogreso.Caption = "Finalizando Rubro Áreas Verdes Viveros..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

            End If

            '
            '                                                   ALTAS
            '
            Me.beprogreso.Caption = "Cargando Data de Altas área Verdes..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarAltasXAnio_tgGRubroId(cboAnio.EditValue, "03")
            xl.Sheets(xl.Worksheets("Altas").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "ALTAS " & cboAnio.Text & " DEL RUBRO ÁREAS VERDES DEL MARGESÍ MUNICIPAL MPT"
            Dim NroAltasXAnio As Int16 = 0
            If ListaInmuebles IsNot Nothing Then
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble Altas en reporte  Áreas  Verdes Altas ... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmFile
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = Format(CDbl(loinmueble.OInmPredio.InmPredArea), "##,##0.00")
                    xl.Range("F" & fila).Value = "Alta"
                    xl.Range("G" & fila).Value = loinmueble.inmCausalAlta
                    xl.Range("H" & fila).Value = loinmueble.InmFecReg
                    xl.Range("I" & fila).Value = loinmueble.OInmValorComercial.InmValComValTotal
                    xl.Range("J" & fila).Value = loinmueble.inmDocAlta
                    xl.Range("k" & fila).Value = loinmueble.inmAltaObservacion
                    NewBordeK(fila)
                    fila = fila + 1
                    cant = cant + 1
                    NroAltasXAnio = NroAltasXAnio + 1
                Next
            Else
                fila = fila + 2
            End If
            Me.beprogreso.Caption = "Escribiendo totales de Altas  Áreas  Verdes"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("D{0}:E{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("D" & fila).Value = "RESUMEN DE ALTAS  - RUBRO ÁREAS VERDES"
            xl.Range("D" & fila).Font.Bold = True
            xl.Range("D" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 1).Value = "TOTAL DE INMUEBLES"
            xl.Range("D" & fila + 1).Font.Bold = True
            xl.Range("D" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
            xl.Range("D" & fila + 2).Font.Bold = True
            xl.Range("D" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 3).Value = "VALOR COMERCIAL TOTAL"
            xl.Range("D" & fila + 3).Font.Bold = True
            xl.Range("D" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = NroAltasXAnio ' loVariableRpt.TotalAltasAreasVerdes
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 2).Value = Format(loVariableRpt.TotalAreaAltasAreasVerdes, "##,##0.00") & " m2"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 3).Value = "S/." & Format(loVariableRpt.TotalValorAltasAreasVerdes, "##,##0.00")
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Me.beprogreso.Caption = "Finalizando Altas Áreas Verdes..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   BAJAS
            '
            Me.beprogreso.Caption = "Cargando Data de  Áreas  Verdes..."
            Application.DoEvents()
            ListaInmuebles = Nothing
            ListaInmuebles = MantenimientosBL.Instancia.inmuebleListarBajasXAnio_tgGRubroId(cboAnio.EditValue, "03")
            xl.Sheets(xl.Worksheets("Bajas").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "BAJAS " & cboAnio.Text & " DEL RUBRO ÁREAS VERDES DEL MARGESÍ MUNICIPAL MPT"
            Dim NroBajasXAnio As Int16 = 0
            If ListaInmuebles IsNot Nothing Then
                For Each loinmueble In ListaInmuebles
                    Me.beprogreso.Caption = "Escribiendo " & cant & " inmueble Altas en reporte Areas Verdes Bajas 2013... "
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmFile
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = CDbl(loinmueble.OInmPredio.InmPredArea)
                    xl.Range("F" & fila).Value = "Baja"
                    xl.Range("G" & fila).Value = loinmueble.OInmBajas.InmBajaCausa
                    xl.Range("H" & fila).Value = loinmueble.OInmBajas.InmBajaFecha
                    xl.Range("I" & fila).Value = loinmueble.OInmValorComercial.InmValComValTotal
                    xl.Range("J" & fila).Value = loinmueble.OInmBajas.InmBajaNroDoc
                    xl.Range("K" & fila).Value = loinmueble.OInmBajas.InmBajaDatoAdicional
                    xl.Range("L" & fila).Value = loinmueble.OInmBajas.InmBajaObservacion
                    NewBordeL(fila)
                    fila = fila + 1
                    cant = cant + 1
                    NroBajasXAnio = NroBajasXAnio + 1
                Next
            Else
                fila = fila + 2
            End If
            Me.beprogreso.Caption = "Escribiendo totales de Bajas Areas Verdes"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("D{0}:E{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("D{0}:E{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("D" & fila).Value = "RESUMEN DE BAJAS  - RUBRO ÁREAS VERDES"
            xl.Range("D" & fila).Font.Bold = True
            xl.Range("D" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 1).Value = "TOTAL DE INMUEBLES"
            xl.Range("D" & fila + 1).Font.Bold = True
            xl.Range("D" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 2).Value = "ÁREA DE TERRENO TOTAL"
            xl.Range("D" & fila + 2).Font.Bold = True
            xl.Range("D" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("D" & fila + 3).Value = "VALOR COMERCIAL TOTAL"
            xl.Range("D" & fila + 3).Font.Bold = True
            xl.Range("D" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = NroBajasXAnio 'loVariableRpt.TotalBajasAreasVerdes
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 2).Value = Format(loVariableRpt.TotalAreaBajasAreasVerdes, "##,##0.00") & " m2"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 3).Value = "S/." & Format(loVariableRpt.TotalValorBajasAreasVerdes, "##,##0.00")
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Me.beprogreso.Caption = "Finalizando Bajas Areas Verdes..."
            Application.DoEvents()

            '
            '                                                   ACTUALIZACIONES
            '
            Me.beprogreso.Caption = "Cargando Data de Actualizaciones Areas Verdes..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            Dim ListaInmueblesLogs As List(Of EEInmueble.EEInmLogs) = Nothing
            Dim loCriteriosConsultas As New EECriterios() With {.tgGRubroId = "03", .FechaInicio = DateSerial(cboAnio.EditValue, 1, 1), .FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)}
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Actualizaciones").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "ACTUALIZACIONES DEL RUBRO ÁREAS VERDES " & cboAnio.Text & " DEL MARGESÍ MUNICIPAL MPT"
            'Dim act_san_count As Integer
            'Dim act_vc_count As Integer
            'Dim act_rc_count As Integer
            'Dim act_dir_count As Integer
            'Dim act_dirf_count As Integer
            'Dim act_area_count As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                'act_san_count = 0
                'act_vc_count = 0
                'act_rc_count = 0
                'act_dir_count = 0
                'act_dirf_count = 0
                'act_area_count = 0
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} inmueble Actualizaciones en reporte Areas Verdes ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1
                    'If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                    '    act_san_count = act_san_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                    '    act_vc_count = act_vc_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And loinmueble._InmUpdDetValorNew2 = "06" Then
                    '    act_rc_count = act_rc_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                    '    act_dir_count = act_dir_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                    '    act_dirf_count = act_dirf_count + 1
                    'ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                    '    act_area_count = act_area_count + 1
                    'End If
                Next
            Else
                fila = fila + 2
            End If

            Me.beprogreso.Caption = "Escribiendo totales en Actualizaciones Áreas Verdes"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
              fila = fila + 1
            xl.Range(String.Format("E{0}:F{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium

            xl.Range("E" & fila).Value = "Total de inmuebles"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'xl.Range(String.Format("E{0}:F{0}", fila)).Select()
            'xl.Selection.MergeCells = True
            xl.Range("G" & fila).Value = cant - 1
            xl.Range("G" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            Me.beprogreso.Caption = "Finalizando Actualizaciones Bienes Propios..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            '
            '                                                   INMUEBLES SANEADOS
            '
            Me.beprogreso.Caption = "Cargando Data de Inmuebles Saneados Areas Verdes..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            ListaInmueblesLogs = Nothing
            loCriteriosConsultas.tgGRubroId = "03"
            loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
            loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
            loCriteriosConsultas.inmUpdDetCampo = "TgEstSanId"
            loCriteriosConsultas.inmUpdDetValorNew = "01"
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Inmuebles Saneados").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "INMUEBLES SANEADOS " & cboAnio.Text & " DEL RUBRO ÁREAS VERDES DEL MARGESÍ MUNICIPAL MPT"
            Dim act_san_count_parques, act_san_count_plazuelas, act_san_count_vermas, act_san_count_viveros As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                act_san_count_parques = 0
                act_san_count_plazuelas = 0
                act_san_count_vermas = 0
                act_san_count_viveros = 0
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} Inmuebles Saneados en reporte Areas Verdes ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1
                    If loinmueble.InmCodigo.Contains("Parques") = True Then
                        act_san_count_parques = act_san_count_parques + 1
                    ElseIf loinmueble.InmCodigo.Contains("Plazuelas") = True Then
                        act_san_count_plazuelas = act_san_count_plazuelas + 1
                    ElseIf loinmueble.InmCodigo.Contains("Bermas") = True Then
                        act_san_count_vermas = act_san_count_vermas + 1
                    ElseIf loinmueble.InmCodigo.Contains("Viveros") = True Then
                        act_san_count_viveros = act_san_count_viveros + 1
                    End If

                Next
            Else
                fila = fila + 2
            End If


            Me.beprogreso.Caption = "Escribiendo totales de Áreas Verdes"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("E{0}:G{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 5)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS SANEADOS  - ÁREAS VERDES"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = "Parques"
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
            xl.Selection.MergeCells = True

            xl.Range("E" & fila + 2).Value = "Plazuelas"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
            xl.Selection.MergeCells = True

            xl.Range("E" & fila + 3).Value = "Bermas"
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
            xl.Selection.MergeCells = True

            xl.Range("E" & fila + 4).Value = "Viveros"
            xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
            xl.Selection.MergeCells = True

            xl.Range("E" & fila + 5).Value = "Total de Inmuebles"
            xl.Range("E" & fila + 5).Font.Bold = True
            xl.Range("E" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 5)).Select()
            xl.Selection.MergeCells = True

            xl.Range("G" & fila + 1).Value = act_san_count_parques
            xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 2).Value = act_san_count_plazuelas
            xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 3).Value = act_san_count_vermas
            xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 4).Value = act_san_count_viveros
            xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 5).Value = act_san_count_parques + act_san_count_viveros + act_san_count_plazuelas + act_san_count_vermas
            xl.Range("G" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Me.beprogreso.Caption = "Finalizando Inmuebles Saneados Areas Verdes..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            '
            '                                                   INMUEBLES CANCELADOS
            '
            Me.beprogreso.Caption = "Cargando Data de Inmuebles Cancelados Areas Verdes..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            ListaInmueblesLogs = Nothing
            loCriteriosConsultas.tgGRubroId = "03"
            loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
            loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
            loCriteriosConsultas.inmUpdDetCampo = "TgInmEstado"
            loCriteriosConsultas.inmUpdDetValorNew = "03"
            ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            xl.Sheets(xl.Worksheets("Inmuebles Cancelados").Index).Select()
            fila = 7
            cant = 1
            xl.Range("C3").Value = "INMUEBLES CANCELADOS " & cboAnio.Text & " DEL RUBRO ÁREAS VERDES DEL MARGESÍ MUNICIPAL MPT"
            Dim count_can_bajas, count_can_duplicados, count_can_cambiouso As Integer
            If ListaInmueblesLogs IsNot Nothing Then
                count_can_bajas = 0
                count_can_duplicados = 0
                count_can_cambiouso = 0
                For Each loinmueble In ListaInmueblesLogs
                    Me.beprogreso.Caption = String.Format("Escribiendo {0} Inmuebles Cancelados en reporte Areas Verdes ... ", cant)
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                    Application.DoEvents()
                    xl.Range("B" & fila).Value = cant 'CANT. 
                    xl.Range("C" & fila).Value = loinmueble.InmCodigo
                    xl.Range("D" & fila).Value = loinmueble.InmUbicacion
                    xl.Range("E" & fila).Value = loinmueble.tgTipoUpd
                    xl.Range("F" & fila).Value = loinmueble.inmUpdSup
                    xl.Range("G" & fila).Value = loinmueble._InmUpdDetCampoText
                    xl.Range("H" & fila).Value = loinmueble.InmUpdFecRegUpd
                    xl.Range("I" & fila).Value = loinmueble._InmUpdDetValorOld
                    xl.Range("J" & fila).Value = loinmueble._InmUpdDetValorNew
                    xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                    xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                    xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                    NewBordeM(fila)
                    fila = fila + 1
                    cant = cant + 1

                    'If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("03") = True Or loinmueble._InmUpdDetValorNew2.Contains("06") = True) Then
                    '    count_can_bajas = count_can_bajas + 1
                    'ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                    '    count_can_duplicados = count_can_duplicados + 1
                    'ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
                    '    count_can_cambiouso = count_can_cambiouso + 1
                    'End If
                    If loinmueble.inmUpdSup.ToLower.Contains("duplicidad") Then
                        count_can_duplicados = count_can_duplicados + 1
                    ElseIf loinmueble.inmUpdSup.ToLower.Contains("baja") Then
                        count_can_bajas = count_can_bajas + 1
                    ElseIf loinmueble.inmUpdSup.ToLower.Contains("cambio") Then
                        count_can_cambiouso = count_can_cambiouso + 1
                    End If
                Next
            Else
                fila = fila + 2
            End If

            Me.beprogreso.Caption = "Escribiendo totales cancelados Áreas Verdes"
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            fila = fila + 1
            xl.Range(String.Format("E{0}:G{0}", fila)).Select()
            xl.Selection.MergeCells = True
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
            xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
            xl.Range("E" & fila).Value = "RESUMEN DE REGISTROS CANCELADOS ÁREAS VERDES"
            xl.Range("E" & fila).Font.Bold = True
            xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 1).Value = "Duplicidad"
            xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 2).Value = "Baja"
            xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 3).Value = "Cambio de Uso"
            xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
            xl.Selection.MergeCells = True
            xl.Range("E" & fila + 4).Value = "Total de Inmuebles"
            xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("E" & fila + 4).Font.Bold = True
            xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
            xl.Selection.MergeCells = True
            xl.Range("G" & fila + 1).Value = count_can_duplicados
            xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 2).Value = count_can_bajas
            xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 3).Value = count_can_cambiouso
            xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range("G" & fila + 4).Value = count_can_bajas + count_can_cambiouso + count_can_duplicados
            xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


            Me.beprogreso.Caption = "Finalizando Inmuebles Cancelados Áreas Verdes..."
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            If ruta Is Nothing Then
                If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO ÁREAS VERDES {1}", fbdExportar.SelectedPath, cboAnio.Text))
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Areas Verdes"
                    Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                End If
            Else
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO ÁREAS VERDES {1}", ruta, cboAnio.Text))
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Areas Verdes"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            End If

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub Aliniar(ByVal fila As Integer)
        xl.Range("B" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Range("B" & fila).VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub

    Private Sub NewBorde(ByVal fila As Integer)
        xl.Cells.Range(String.Format("B{0}:W{0}", fila)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(String.Format("B{0}:W{0}", fila)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
        xl.Cells.Range(String.Format("B{0}:W{0}", fila)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
        xl.Cells.Range(String.Format("B{0}:D{0}", fila)).Borders.Weight = Excel.XlBorderWeight.xlMedium
        xl.Cells.Range(String.Format("H{0}", fila)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlMedium
        xl.Cells.Range(String.Format("L{0}", fila)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlMedium
        xl.Cells.Range(String.Format("P{0}", fila)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlMedium
        xl.Cells.Range(String.Format("U{0}:W{0}", fila)).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlMedium
    End Sub

    Private Sub NewBordeL(ByVal fila As Integer)
        xl.Cells.Range(String.Format("B{0}:L{0}", fila)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

    Private Sub NewBordeM(ByVal fila As Integer)
        xl.Cells.Range(String.Format("B{0}:M{0}", fila)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub
    Private Sub NewBordeK(ByVal fila As Integer)
        xl.Cells.Range(String.Format("B{0}:K{0}", fila)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub


    Private Sub frmRptFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableGRubros()
        Dim loTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(32)
        If loTablaGeneral IsNot Nothing Then
            oTableGRubros.LoadDataRow(New Object() {0, "Todos los Rubros"}, True)
            For Each frow In loTablaGeneral
                oTableGRubros.LoadDataRow(New Object() {frow.TgCodigo, frow.TgNombre}, True)
            Next
            cboRubroGrupos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboRubroGrupos.Properties.DisplayMember = "TgNombre"
            cboRubroGrupos.Properties.ValueMember = "TgCodigo"
            cboRubroGrupos.Properties.DataSource = oTableGRubros
        End If

        cboAnio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAnio.Properties.DisplayMember = "TgNombre"
        cboAnio.Properties.ValueMember = "TgCodigo"
        cboAnio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)
        cboAnio.ItemIndex = 0
        ConstruirTable()
    End Sub

    Sub Consultar()
        Dim TgRubroId As String = Nothing
        Dim TgGRubroId As String = Nothing
        If chkRubros.Checked = True Then
            If cboRubroGrupos.EditValue IsNot Nothing Then
                TgGRubroId = cboRubroGrupos.EditValue
                If cboRubroGrupos.EditValue <> 0 Then
                    TgGRubroId = cboRubroGrupos.EditValue
                Else
                    TgGRubroId = Nothing
                End If
            End If
        Else
            TgRubroId = Nothing
            TgGRubroId = Nothing
        End If

        Me.beprogreso.Caption = "Cargando Reporte de Inmuebles... "
        Me.riprogreso.Minimum = 0
        Me.beprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Application.DoEvents()
        Select Case TgGRubroId
            Case Nothing
                If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ExportarGeneral(fbdExportar.SelectedPath)
                    beprogreso.Reset()
                    ExportarReporteBienesPropios(fbdExportar.SelectedPath)
                    beprogreso.Reset()
                    ExportarReporteOtrosFines(fbdExportar.SelectedPath)
                    beprogreso.Reset()
                    ExportarReporteAreasVerdes(fbdExportar.SelectedPath)
                    beprogreso.Reset()
                    ExportarReporteSerpar(fbdExportar.SelectedPath)
                    beprogreso.Reset()
                End If
            Case "01"
                ExportarReporteBienesPropios()
            Case "02"
                ExportarReporteOtrosFines()
            Case "03"
                ExportarReporteAreasVerdes()
            Case "04"
                ExportarReporteSerpar()
        End Select
    End Sub

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton1.Click
        Consultar()
    End Sub

    Private Sub SaimtButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton2.Click
        If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ExportarGeneral(fbdExportar.SelectedPath)
            beprogreso.Reset()
        End If
    End Sub
End Class


