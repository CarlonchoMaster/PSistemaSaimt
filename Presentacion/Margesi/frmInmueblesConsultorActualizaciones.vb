Imports SaimtControles
Imports Entidades
Imports ReglasNegocio
Imports Microsoft.Office.Interop

Public Class frmInmueblesConsultorActualizaciones
    Inherits frmConsultas
    Dim loCriteriosConsultas As EECriterios = Nothing

#Region "Propiedades"
    Public Property InmId() As String
    Public Property InmDir() As String
#End Region

    Dim oTable As DataTable
    Dim btnActivo As Int16 = 0
    Dim xl As Excel.Application
    Private Sub ConstruirTable()
        oTable = New DataTable
        oTable.Columns.Add("nro", GetType(String))
        oTable.Columns.Add("codigo", GetType(String))
        oTable.Columns.Add("ubicacion", GetType(String))
        oTable.Columns.Add("tipo", GetType(String))
        oTable.Columns.Add("supuesto", GetType(String))
        oTable.Columns.Add("campo", GetType(String))
        oTable.Columns.Add("fechaReg", GetType(Date))
        oTable.Columns.Add("valorOld", GetType(String))
        oTable.Columns.Add("valorNew", GetType(String))
        oTable.Columns.Add("doc", GetType(String))
        oTable.Columns.Add("motivo", GetType(String))
        oTable.Columns.Add("obs", GetType(String))
        oTable.Columns.Add("fechaUpd", GetType(String))
        oTable.Columns.Add("fechaDoc", GetType(String))
        oTable.Columns.Add("inmUpdId", GetType(String))
    
    End Sub

    Private Sub frmConsultaInmueble_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EEComun.CargarTablasGenerales(MantenimientosBL.Instancia.tablageneralListarXClasesId("32,33,76,192"))
        cboRubroGrupos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRubroGrupos.Properties.DisplayMember = "TgNombre"
        cboRubroGrupos.Properties.ValueMember = "TgCodigo"
        cboRubroGrupos.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgRubrosGrupos, True)

        cboCriterioFecha.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCriterioFecha.Properties.DisplayMember = "TgNombre"
        cboCriterioFecha.Properties.ValueMember = "TgCodigo"
        cboCriterioFecha.Properties.DataSource = EEComun.DtByClsId(192, True) 'MantenimientosBL.Instancia.tablageneralListarXClsId2(192)
        cboCriterioFecha.ItemIndex = 0

        cboAnio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAnio.Properties.DisplayMember = "TgNombre"
        cboAnio.Properties.ValueMember = "TgCodigo"
        cboAnio.Properties.DataSource = EEComun.DtByClsId(76, True)
        cboAnio.EditValue = Year(Date.Now).ToString
        ConstruirTable()
        ' chkfecha.Checked = False
        chkRubros.Checked = False
        chkFile.Checked = False
        ' chkCriterios.Checked = False
        chkFechas2.Checked = False
        dgvResultado.DataSource = oTable
     
    End Sub

    Protected Overrides Sub buscar()
        Dim fInmueble As EEInmueble.EEInmLogs
        Dim ListaInmueble As List(Of EEInmueble.EEInmLogs)

        Try
            loCriteriosConsultas = New EECriterios
            'If chkfecha.Checked = True Then

            '    If dpTiempoInicio.EditValue Is Nothing Or dpTiempoFin.EditValue Is Nothing Then
            '        dpTiempoInicio.Focus()
            '        SaimtMessageBox.mostrarAlertaInformativa("Seleccione Fecha Correcta")
            '        Return
            '    End If
            '    loCriteriosConsultas.FechaInicio = dpTiempoInicio.EditValue
            '    loCriteriosConsultas.FechaFin = dpTiempoFin.EditValue
            'End If
            loCriteriosConsultas.anio = cboAnio.EditValue

            If chkFechas2.Checked = True Then
                If cboCriterioFecha.EditValue Is Nothing Or cboCriterioFechaSub.EditValue Is Nothing Then
                    SaimtMessageBox.mostrarAlertaInformativa("Seleccione Fecha Correcta")
                    Return
                End If
                loCriteriosConsultas.tpCriterio = cboCriterioFecha.EditValue
                loCriteriosConsultas.Criterio = cboCriterioFechaSub.EditValue
            End If


            If chkRubros.Checked = True Then
                loCriteriosConsultas.tgRubroId = Nothing
                loCriteriosConsultas.tgGRubroId = Nothing

                If cboRubroGrupos.EditValue = "0" Then
                    loCriteriosConsultas.tgRubroId = Nothing
                    loCriteriosConsultas.tgGRubroId = Nothing
                Else
                    If cboRubro.EditValue IsNot Nothing And cboRubro.EditValue <> "0" Then
                        loCriteriosConsultas.tgRubroId = cboRubro.EditValue
                    Else
                        loCriteriosConsultas.tgGRubroId = cboRubroGrupos.EditValue
                    End If
                End If
            End If
          
            If chkFile.Checked = True Then
                If cboCriterioFile.SelectedIndex <> -1 Then
                    If cboCriterioFile.SelectedIndex = 0 Then
                        loCriteriosConsultas.inmFile = txtFile.Text
                    Else
                        loCriteriosConsultas.inmFileAnt = txtFile.Text
                    End If
                    If Len(txtFile.Text) = 0 Then
                        SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor correctamente en el File")
                        txtFile.Focus()
                        Return
                    End If
                Else
                    SaimtMessageBox.mostrarAlertaInformativa("Seleccione un valor File o FileAnt")
                    cboCriterioFile.Focus()
                    Return
                End If
            End If
            If GValorCriterioBuscado <> String.Empty Then
                loCriteriosConsultas.inmUpdDetCampo = GValorCriterioBuscado
                loCriteriosConsultas.inmUpdDetValorNew = GValorTextoBuscado
            End If

            ListaInmueble = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
            oTable.Clear()
            If ListaInmueble IsNot Nothing Then
                For Each fInmueble In ListaInmueble


                    oTable.LoadDataRow(New Object() {fInmueble.Nro, _
                                                     fInmueble.InmCodigo, _
                                                     fInmueble.InmUbicacion, _
                                                     fInmueble.tgTipoUpd, _
                                                     fInmueble.inmUpdSup, _
                                                     fInmueble._InmUpdDetCampoText, _
                                                     fInmueble.InmUpdFechaReg, _
                                                     fInmueble._InmUpdDetValorOld, _
                                                     fInmueble._InmUpdDetValorNew, _
                                                     fInmueble.inmUpdDoc, _
                                                     fInmueble.inmUpdMotivo, _
                                                     fInmueble.inmUpdObservacion, _
                                                     fInmueble.InmUpdFecRegUpd, _
                                                     fInmueble.InmUpdFecDoc, fInmueble.InmUpdId}, True)

                Next
                Me.Encontrado = True
            Else
                Me.Encontrado = False
                SaimtMessageBox.mostrarAlertaInformativa("No se encontraron Resultados")
            End If

            MyBase.buscar()
            Me.gvResultado.BestFitColumns()
            lblResultados.Text = "Resultados de Búsqueda: " & Me.gvResultado.RowCount
            GValorCriterioBuscado = String.Empty
            GValorTextoBuscado = String.Empty
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
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
        ' Me.riprogreso.Minimum = 0
        Me.beprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Application.DoEvents()
        Select Case TgGRubroId
            Case Nothing
                ExportarReporteAll(btnActivo)
            Case "01"
                ExportarReporteBienesPropios(btnActivo)
            Case "02"
                ExportarReporteOtrosFines(btnActivo)
            Case "03"
                ExportarReporteAreasVerdes(btnActivo)
            Case "04"
                ExportarReporteSerpar(btnActivo)
        End Select
    End Sub

    Private Sub NewBorde3(ByVal fila As Integer)
        xl.Cells.Range(String.Format("B{0}:L{0}", fila)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub
    Private Sub ExportarReporteAll(ByVal btnActivo As Integer)
        Try
            xl = EEExcel.Instancia
            Me.beprogreso.Caption = "Abriendo Exel Temporal... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim fila As String = String.Empty
            Dim cant As Integer = 0
            Dim ListaInmueblesLogs As List(Of EEInmueble.EEInmLogs) = Nothing
            Dim completa As String = String.Empty
            xl.Workbooks.Open(EEComun.RutaReportes & "\Rpt_Margesi_actualizaciones.xlsx", 1, True, 4)
            If btnActivo = 1 Then
                completa = "Actualizaciones"


                '
                '                                                   ACTUALIZACIONES
                '
                Me.beprogreso.Caption = "Cargando Data de Actualizaciones..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()


                ' Dim loCriteriosConsultas As New EECriterios() With {.tgGRubroId = "01", .FechaInicio = DateSerial(cboAnio.EditValue, 1, 1), .FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)}
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Actualizaciones").Index).Select()
                fila = 5
                cant = 1
                Dim bp_act_san_count As Integer
                Dim bp_act_vc_count As Integer
                Dim bp_act_rc_count As Integer
                Dim bp_act_dir_count As Integer
                Dim bp_act_dirf_count As Integer
                Dim bp_act_area_count As Integer

                Dim of_act_san_count As Integer
                Dim of_act_vc_count As Integer
                Dim of_act_rc_count As Integer
                Dim of_act_dir_count As Integer
                Dim of_act_dirf_count As Integer
                Dim of_act_area_count As Integer


                Dim sp_act_san_count As Integer
                Dim sp_act_vc_count As Integer
                Dim sp_act_rc_count As Integer
                Dim sp_act_dir_count As Integer
                Dim sp_act_dirf_count As Integer
                Dim sp_act_area_count As Integer

                Dim pq_act_san_count As Integer
                Dim pq_act_vc_count As Integer
                Dim pq_act_rc_count As Integer
                Dim pq_act_dir_count As Integer
                Dim pq_act_dirf_count As Integer
                Dim pq_act_area_count As Integer



                If ListaInmueblesLogs IsNot Nothing Then
                    bp_act_san_count = 0
                    bp_act_vc_count = 0
                    bp_act_rc_count = 0
                    bp_act_dir_count = 0
                    bp_act_dirf_count = 0
                    bp_act_area_count = 0

                    of_act_san_count = 0
                    of_act_vc_count = 0
                    of_act_rc_count = 0
                    of_act_dir_count = 0
                    of_act_dirf_count = 0
                    of_act_area_count = 0

                    sp_act_san_count = 0
                    sp_act_vc_count = 0
                    sp_act_rc_count = 0
                    sp_act_dir_count = 0
                    sp_act_dirf_count = 0
                    sp_act_area_count = 0

                    pq_act_san_count = 0
                    pq_act_vc_count = 0
                    pq_act_rc_count = 0
                    pq_act_dir_count = 0
                    pq_act_dirf_count = 0
                    pq_act_area_count = 0

                    For Each loinmueble In ListaInmueblesLogs
                        Me.beprogreso.Caption = String.Format("Escribiendo {0} inmueble Actualizaciones en reporte... ", cant)
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
                        xl.Range(String.Format("I{0}:J{0}", fila)).Interior.Color = RGB(242, 242, 242)
                        xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                        xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                        xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1
                        If loinmueble.InmCodigo.Contains("Bienes Propios") = True Then
                            If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                                bp_act_san_count = bp_act_san_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                                bp_act_vc_count = bp_act_vc_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And (loinmueble._InmUpdDetValorNew2 = "06" Or loinmueble._InmUpdDetValorNew2 = "03") Then
                                bp_act_rc_count = bp_act_rc_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                                bp_act_dir_count = bp_act_dir_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                                bp_act_dirf_count = bp_act_dirf_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                                bp_act_area_count = bp_act_area_count + 1
                            End If
                        End If

                        If loinmueble.InmCodigo.Contains("Otros Fines") = True Then
                            If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                                of_act_san_count = of_act_san_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                                of_act_vc_count = of_act_vc_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And (loinmueble._InmUpdDetValorNew2 = "06" Or loinmueble._InmUpdDetValorNew2 = "03") Then
                                of_act_rc_count = of_act_rc_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                                of_act_dir_count = of_act_dir_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                                of_act_dirf_count = of_act_dirf_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                                of_act_area_count = of_act_area_count + 1
                            End If
                        End If


                        If loinmueble.InmCodigo.Contains("Serpar") = True Then
                            If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                                sp_act_san_count = sp_act_san_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                                sp_act_vc_count = sp_act_vc_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And (loinmueble._InmUpdDetValorNew2 = "06" Or loinmueble._InmUpdDetValorNew2 = "03") Then
                                sp_act_rc_count = sp_act_rc_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                                sp_act_dir_count = sp_act_dir_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                                sp_act_dirf_count = sp_act_dirf_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                                sp_act_area_count = sp_act_area_count + 1
                            End If
                        End If


                        If loinmueble.InmCodigo.Contains("Areas Verdes") = True Then
                            If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                                pq_act_san_count = pq_act_san_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                                pq_act_vc_count = pq_act_vc_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And (loinmueble._InmUpdDetValorNew2 = "06" Or loinmueble._InmUpdDetValorNew2 = "03") Then
                                pq_act_rc_count = pq_act_rc_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                                pq_act_dir_count = pq_act_dir_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                                pq_act_dirf_count = pq_act_dirf_count + 1
                            ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                                pq_act_area_count = pq_act_area_count + 1
                            End If
                        End If
                    
                    Next
                Else
                    fila = fila + 2
                End If


                Me.beprogreso.Caption = "Escribiendo totales en Actualizaciones"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                'Serpar

                fila = fila + 1
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS ACTUALIZADOS   RUBRO SERPAR"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila).RowHeight = "30"

                xl.Range("E" & fila + 1).Value = "Saneados"
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 2).Value = "Valor comercial actualizados"
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 3).Value = "Registros cancelados"
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 4).Value = "Dirección actualizada"
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 5).Value = "Finca inscrita actualizada"
                xl.Range("E" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 5)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 6).Value = "Área actualizada"
                xl.Range("E" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 6)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 7).Value = "Total de inmuebles"
                xl.Range("E" & fila + 7).Font.Bold = True
                xl.Range("E" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 7)).Select()
                xl.Selection.MergeCells = True


                xl.Range("G" & fila + 1).Value = sp_act_san_count
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = sp_act_vc_count
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = sp_act_rc_count
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = sp_act_dir_count
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 5).Value = sp_act_dirf_count
                xl.Range("G" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 6).Value = sp_act_area_count
                xl.Range("G" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Value = sp_act_san_count + sp_act_vc_count + sp_act_rc_count + sp_act_dir_count + sp_act_dirf_count + sp_act_area_count
                xl.Range("G" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Font.Bold = True

                'Otros Fines

                fila = fila + 9
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS ACTUALIZADOS   RUBRO OTROS FINES"
                xl.Range("E" & fila).RowHeight = "30"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                xl.Range("E" & fila + 1).Value = "Saneados"
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 2).Value = "Valor comercial actualizados"
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 3).Value = "Registros cancelados"
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 4).Value = "Dirección actualizada"
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 5).Value = "Finca inscrita actualizada"
                xl.Range("E" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 5)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 6).Value = "Área actualizada"
                xl.Range("E" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 6)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 7).Value = "Total de inmuebles"
                xl.Range("E" & fila + 7).Font.Bold = True
                xl.Range("E" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 7)).Select()
                xl.Selection.MergeCells = True


                xl.Range("G" & fila + 1).Value = of_act_san_count
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = of_act_vc_count
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = of_act_rc_count
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = of_act_dir_count
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 5).Value = of_act_dirf_count
                xl.Range("G" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 6).Value = of_act_area_count
                xl.Range("G" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Value = of_act_san_count + of_act_vc_count + of_act_rc_count + of_act_dir_count + of_act_dirf_count + of_act_area_count
                xl.Range("G" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Font.Bold = True

                'Areas Verdes

                fila = fila + 9
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS ACTUALIZADOS   RUBRO ÁREAS VERDES"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila).RowHeight = "30"

                xl.Range("E" & fila + 1).Value = "Saneados"
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 2).Value = "Valor comercial actualizados"
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 3).Value = "Registros cancelados"
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 4).Value = "Dirección actualizada"
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 5).Value = "Finca inscrita actualizada"
                xl.Range("E" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 5)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 6).Value = "Área actualizada"
                xl.Range("E" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 6)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 7).Value = "Total de inmuebles"
                xl.Range("E" & fila + 7).Font.Bold = True
                xl.Range("E" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 7)).Select()
                xl.Selection.MergeCells = True


                xl.Range("G" & fila + 1).Value = pq_act_san_count
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = pq_act_vc_count
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = pq_act_rc_count
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = pq_act_dir_count
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 5).Value = pq_act_dirf_count
                xl.Range("G" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 6).Value = pq_act_area_count
                xl.Range("G" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Value = pq_act_san_count + pq_act_vc_count + pq_act_rc_count + pq_act_dir_count + pq_act_dirf_count + pq_act_area_count
                xl.Range("G" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Font.Bold = True

                'Bienes Propios

                fila = fila + 9
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS ACTUALIZADOS   RUBRO BIENES PROPIOS"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila).RowHeight = "30"

                xl.Range("E" & fila + 1).Value = "Saneados"
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 2).Value = "Valor comercial actualizados"
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 3).Value = "Registros cancelados"
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 4).Value = "Dirección actualizada"
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 5).Value = "Finca inscrita actualizada"
                xl.Range("E" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 5)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 6).Value = "Área actualizada"
                xl.Range("E" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 6)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 7).Value = "Total de inmuebles"
                xl.Range("E" & fila + 7).Font.Bold = True
                xl.Range("E" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 7)).Select()
                xl.Selection.MergeCells = True


                xl.Range("G" & fila + 1).Value = bp_act_san_count
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = bp_act_vc_count
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = bp_act_rc_count
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = bp_act_dir_count
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 5).Value = bp_act_dirf_count
                xl.Range("G" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 6).Value = bp_act_area_count
                xl.Range("G" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Value = bp_act_san_count + bp_act_vc_count + bp_act_rc_count + bp_act_dir_count + bp_act_dirf_count + bp_act_area_count
                xl.Range("G" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Font.Bold = True


                Me.beprogreso.Caption = "Finalizando Actualizaciones..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()


            End If
            If btnActivo = 2 Then
                completa = "Saneados"

                '
                '                                                   INMUEBLES SANEADOS
                '
                Me.beprogreso.Caption = "Cargando Data de Inmuebles Saneados..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing

                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Saneados").Index).Select()
                fila = 5
                cant = 1
                Dim act_san_count_bpropios, act_san_count_vias As Integer
                Dim act_san_count_otrosFines As Integer
                Dim act_san_count_Serpar As Integer
                Dim act_san_count_parques, act_san_count_plazuelas, act_san_count_vermas, act_san_count_viveros As Integer
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
                        xl.Range(String.Format("I{0}:J{0}", fila)).Interior.Color = RGB(242, 242, 242)
                        xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                        xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                        xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1
                        If loinmueble.InmCodigo.Contains("Bienes Propios") = True Then
                            act_san_count_bpropios = act_san_count_bpropios + 1
                        ElseIf loinmueble.InmCodigo.Contains("Vías") = True Then
                            act_san_count_vias = act_san_count_vias + 1
                        ElseIf loinmueble.InmCodigo.Contains("Otros Fines") = True Then
                            act_san_count_otrosFines = act_san_count_otrosFines + 1
                        ElseIf loinmueble.InmCodigo.Contains("Serpar") = True Then
                            act_san_count_Serpar = act_san_count_Serpar + 1
                        ElseIf loinmueble.InmCodigo.Contains("Parques") = True Then
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


                Me.beprogreso.Caption = "Escribiendo totales de Saneados"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 3)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS SANEADOS"
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 3).Font.Bold = True

                fila = fila + 5
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS SANEADOS OTROS FINES"
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 2).Font.Bold = True

                fila = fila + 4
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 2)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS SANEADOS SERPAR"
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 2).Font.Bold = True

                fila = fila + 4
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 5)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 5)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS SANEADOS  - ÁREAS VERDES"
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 5).Font.Bold = True

                Me.beprogreso.Caption = "Finalizando Inmuebles Saneados..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()


            End If
            If btnActivo = 3 Then
                completa = "Cancelados"
                '
                '                                                   INMUEBLES CANCELADOS
                '
                Me.beprogreso.Caption = "Cargando Data de Inmuebles Cancelados..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Cancelados").Index).Select()
                fila = 5
                cant = 1
                Dim bp_count_can_bajas, bp_count_can_duplicados, bp_count_can_cambiouso As Integer
                Dim of_count_can_bajas, of_count_can_duplicados, of_count_can_cambiouso As Integer
                Dim sp_count_can_bajas, sp_count_can_duplicados, sp_count_can_cambiouso As Integer
                Dim pq_count_can_bajas, pq_count_can_duplicados, pq_count_can_cambiouso As Integer
                If ListaInmueblesLogs IsNot Nothing Then
                    bp_count_can_bajas = 0
                    bp_count_can_duplicados = 0
                    bp_count_can_cambiouso = 0

                    of_count_can_bajas = 0
                    of_count_can_duplicados = 0
                    of_count_can_cambiouso = 0

                    sp_count_can_bajas = 0
                    sp_count_can_duplicados = 0
                    sp_count_can_cambiouso = 0

                    pq_count_can_bajas = 0
                    pq_count_can_duplicados = 0
                    pq_count_can_cambiouso = 0

                    For Each loinmueble In ListaInmueblesLogs
                        Me.beprogreso.Caption = String.Format("Escribiendo {0} Inmuebles Cancelados en reporte ... ", cant)
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
                        xl.Range(String.Format("I{0}:J{0}", fila)).Interior.Color = RGB(242, 242, 242)
                        xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                        xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                        xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1

                     
                        If loinmueble.InmCodigo.Contains("Bienes Propios") = True Then
                            If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("03") = True Then
                                bp_count_can_bajas = bp_count_can_bajas + 1
                            ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                                bp_count_can_duplicados = bp_count_can_duplicados + 1
                            ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
                                bp_count_can_cambiouso = bp_count_can_cambiouso + 1
                            End If

                        ElseIf loinmueble.InmCodigo.Contains("Otros Fines") = True Then

                            If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("03") = True Then
                                of_count_can_bajas = of_count_can_bajas + 1
                            ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                                of_count_can_duplicados = of_count_can_duplicados + 1
                            ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
                                of_count_can_cambiouso = of_count_can_cambiouso + 1
                            End If

                        ElseIf loinmueble.InmCodigo.Contains("Serpar") = True Then

                            If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("03") = True Then
                                sp_count_can_bajas = sp_count_can_bajas + 1
                            ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                                sp_count_can_duplicados = sp_count_can_duplicados + 1
                            ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
                                sp_count_can_cambiouso = sp_count_can_cambiouso + 1
                            End If

                        ElseIf loinmueble.InmCodigo.Contains("Parques") = True Then

                            If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("03") = True Then
                                pq_count_can_bajas = pq_count_can_bajas + 1
                            ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                                pq_count_can_duplicados = pq_count_can_duplicados + 1
                            ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
                                pq_count_can_cambiouso = pq_count_can_cambiouso + 1
                            End If

                        End If
                    Next
                Else
                    fila = fila + 2
                End If


                Me.beprogreso.Caption = "Escribiendo totales cancelados"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE REGISTROS CANCELADOS BIENES PROPIOS"
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 1).Value = bp_count_can_duplicados
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = bp_count_can_bajas
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = bp_count_can_cambiouso
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = bp_count_can_bajas + bp_count_can_cambiouso + bp_count_can_duplicados
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Font.Bold = True


                fila = fila + 6
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE REGISTROS CANCELADOS OTROS FINES"
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 1).Value = of_count_can_duplicados
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = of_count_can_bajas
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = of_count_can_cambiouso
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = of_count_can_bajas + of_count_can_cambiouso + of_count_can_duplicados
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Font.Bold = True


                fila = fila + 6
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE REGISTROS CANCELADOS SERPAR"
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 1).Value = sp_count_can_duplicados
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = sp_count_can_bajas
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = sp_count_can_cambiouso
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = sp_count_can_bajas + sp_count_can_cambiouso + sp_count_can_duplicados
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Font.Bold = True

                fila = fila + 6
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 4)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE REGISTROS CANCELADOS ÁREAS VERDES"
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 1).Value = pq_count_can_duplicados
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = pq_count_can_bajas
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = pq_count_can_cambiouso
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = pq_count_can_bajas + pq_count_can_cambiouso + pq_count_can_duplicados
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Font.Bold = True

                Me.beprogreso.Caption = "Finalizando Inmuebles Cancelados..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

            End If
            If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\Margesi_{1}", fbdExportar.SelectedPath, completa))
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Me.beprogreso.EditValue = 0
                Application.DoEvents()
            End If


        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub ExportarReporteBienesPropios(Optional ByVal item As Int16 = Nothing)
        Try
            xl = EEExcel.Instancia
            Me.beprogreso.Caption = "Abriendo Exel Temporal... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim fila As String = String.Empty
            Dim cant As Integer = 0
            Dim ListaInmueblesLogs As List(Of EEInmueble.EEInmLogs) = Nothing
            Dim completa As String = String.Empty
            If item = 1 Then

                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO BIENES PROPIOS_Actualizaciones.xls", 1, True, 4)
                completa = "ACTUALIZACIONES"

                '
                '                                                   ACTUALIZACIONES
                '
                Me.beprogreso.Caption = "Cargando Data de Actualizaciones Bienes Propios..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()


                ' Dim loCriteriosConsultas As New EECriterios() With {.tgGRubroId = "01", .FechaInicio = DateSerial(cboAnio.EditValue, 1, 1), .FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)}
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Actualizaciones").Index).Select()
                fila = 7
                cant = 1
                Dim act_san_count As Integer
                Dim act_vc_count As Integer
                Dim act_rc_count As Integer
                Dim act_dir_count As Integer
                Dim act_dirf_count As Integer
                Dim act_area_count As Integer
                If ListaInmueblesLogs IsNot Nothing Then
                    act_san_count = 0
                    act_vc_count = 0
                    act_rc_count = 0
                    act_dir_count = 0
                    act_dirf_count = 0
                    act_area_count = 0
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
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1
                        If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                            act_san_count = act_san_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                            act_vc_count = act_vc_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And loinmueble._InmUpdDetValorNew2 = "06" Then
                            act_rc_count = act_rc_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                            act_dir_count = act_dir_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                            act_dirf_count = act_dirf_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                            act_area_count = act_area_count + 1
                        End If
                    Next
                Else
                    fila = fila + 2
                End If


                Me.beprogreso.Caption = "Escribiendo totales en Actualizaciones Bienes Propios"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS ACTUALIZADOS BIENES PROPIOS"
                xl.Range("E" & fila).RowHeight = "30"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                xl.Range("E" & fila + 1).Value = "Saneados"
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 2).Value = "Valor comercial actualizados"
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 3).Value = "Registros cancelados"
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 4).Value = "Dirección actualizada"
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 5).Value = "Finca inscrita actualizada"
                xl.Range("E" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 5)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 6).Value = "Área actualizada"
                xl.Range("E" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 6)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 7).Value = "Total de inmuebles"
                xl.Range("E" & fila + 7).Font.Bold = True
                xl.Range("E" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 7)).Select()
                xl.Selection.MergeCells = True


                xl.Range("G" & fila + 1).Value = act_san_count
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = act_vc_count
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = act_rc_count
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = act_dir_count
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 5).Value = act_dirf_count
                xl.Range("G" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 6).Value = act_area_count
                xl.Range("G" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Value = act_san_count + act_vc_count + act_rc_count + act_dir_count + act_dirf_count + act_area_count
                xl.Range("G" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Font.Bold = True

                Me.beprogreso.Caption = "Finalizando Actualizaciones Bienes Propios..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
            End If

            If item = 2 Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO BIENES PROPIOS_Saneados.xls", 1, True, 4)
                completa = "SANEADOS"

                '
                '                                                   INMUEBLES SANEADOS
                '
                Me.beprogreso.Caption = "Cargando Data de Inmuebles Saneados Bienes Propios..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing

                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Inmuebles Saneados").Index).Select()
                fila = 7
                cant = 1
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
                        NewBorde3(fila)
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
                xl.Range("E" & fila).RowHeight = "30"
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

            End If
            If item = 3 Then

                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO BIENES PROPIOS_Cancelados.xls", 1, True, 4)
                completa = "CANCELADOS"

                '
                '                                                   INMUEBLES CANCELADOS
                '
                Me.beprogreso.Caption = "Cargando Data de Inmuebles Cancelados Bienes Propios..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Inmuebles Cancelados").Index).Select()
                fila = 7
                cant = 1
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
                        xl.Range("K" & fila).Value = loinmueble.inmUpdDoc
                        xl.Range("L" & fila).Value = loinmueble.inmUpdMotivo
                        xl.Range("M" & fila).Value = loinmueble.inmUpdObservacion
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1

                        If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("03") = True Or loinmueble._InmUpdDetValorNew2.Contains("06") = True) Then
                            count_can_bajas = count_can_bajas + 1
                        ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                            count_can_duplicados = count_can_duplicados + 1
                        ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
                            count_can_cambiouso = count_can_cambiouso + 1
                        End If
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
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 1).Value = count_can_bajas
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = count_can_duplicados
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = count_can_cambiouso
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = count_can_bajas + count_can_cambiouso + count_can_duplicados
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Font.Bold = True

                Me.beprogreso.Caption = "Finalizando Inmuebles Cancelados Bienes Propios..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
            End If

            If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO BIENES PROPIOS - {1}", fbdExportar.SelectedPath, completa))
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

    Private Sub ExportarReporteOtrosFines(Optional ByVal item As Integer = Nothing)
        Try
            xl = EEExcel.Instancia
            Me.beprogreso.Caption = "Abriendo Exel Temporal... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim fila As String = String.Empty
            Dim cant As Integer = 0
            Dim ListaInmueblesLogs As List(Of EEInmueble.EEInmLogs) = Nothing
            Dim completa As String = String.Empty
            If item = 1 Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO OTROS FINES_Actualizaciones.xls", 1, True, 4)
                completa = "ACTUALIZACIONES"
                '
                '                                                   ACTUALIZACIONES
                '
                Me.beprogreso.Caption = "Cargando Data de Actualizaciones Otros Fines..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Actualizaciones").Index).Select()
                fila = 7
                cant = 1
                Dim act_san_count As Integer
                Dim act_vc_count As Integer
                Dim act_rc_count As Integer
                Dim act_dir_count As Integer
                Dim act_dirf_count As Integer
                Dim act_area_count As Integer
                If ListaInmueblesLogs IsNot Nothing Then
                    act_san_count = 0
                    act_vc_count = 0
                    act_rc_count = 0
                    act_dir_count = 0
                    act_dirf_count = 0
                    act_area_count = 0
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
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1
                        If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                            act_san_count = act_san_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                            act_vc_count = act_vc_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And loinmueble._InmUpdDetValorNew2 = "06" Then
                            act_rc_count = act_rc_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                            act_dir_count = act_dir_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                            act_dirf_count = act_dirf_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                            act_area_count = act_area_count + 1
                        End If
                    Next
                Else
                    fila = fila + 2
                End If



                Me.beprogreso.Caption = "Escribiendo totales en Actualizaciones Otros Fines"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS ACTUALIZADOS OTROS FINES"
                xl.Range("E" & fila).RowHeight = "30"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 1).Value = "Saneados"
                xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
                xl.Selection.MergeCells = True
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                xl.Range("E" & fila + 2).Value = "Valor comercial actualizados"
                xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
                xl.Selection.MergeCells = True
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                xl.Range("E" & fila + 3).Value = "Registros cancelados"
                xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
                xl.Selection.MergeCells = True
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                xl.Range("E" & fila + 4).Value = "Dirección actualizada"
                xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
                xl.Selection.MergeCells = True
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                xl.Range("E" & fila + 5).Value = "Finca inscrita actualizada"
                xl.Range(String.Format("E{0}:F{0}", fila + 5)).Select()
                xl.Selection.MergeCells = True
                xl.Range("E" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                xl.Range("E" & fila + 6).Value = "Área actualizada"
                xl.Range(String.Format("E{0}:F{0}", fila + 6)).Select()
                xl.Selection.MergeCells = True
                xl.Range("E" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                xl.Range("E" & fila + 7).Value = "Total de inmuebles"
                xl.Range("E" & fila + 7).Font.Bold = True
                xl.Range("E" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 7)).Select()
                xl.Selection.MergeCells = True

                xl.Range("G" & fila + 1).Value = act_san_count
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = act_vc_count
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = act_rc_count
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = act_dir_count
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 5).Value = act_dirf_count
                xl.Range("G" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 6).Value = act_area_count
                xl.Range("G" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Value = act_san_count + act_vc_count + act_rc_count + act_dir_count + act_dirf_count + act_area_count
                xl.Range("G" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                Me.beprogreso.Caption = "Finalizando Actualizaciones Otros Fines..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
            End If

            If item = 2 Then


                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO OTROS FINES_Saneados.xls", 1, True, 4)
                completa = "SANEADOS"
                '
                '                                                   INMUEBLES SANEADOS
                '
                Me.beprogreso.Caption = "Cargando Data de Inmuebles Saneados Otros Fines..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing
                 
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Inmuebles Saneados").Index).Select()
                fila = 7
                cant = 1
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
                        NewBorde3(fila)
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
                xl.Range("E" & fila).RowHeight = "30"
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
            End If
            If item = 3 Then

                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO OTROS FINES_Cancelados.xls", 1, True, 4)
                completa = "CANCELADOS"
                '
                '                                                   INMUEBLES CANCELADOS
                '
                Me.beprogreso.Caption = "Cargando Data de Inmuebles Cancelados Otros Fines..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing
                ' loCriteriosConsultas.inmUpdDetValorNew = "'03','04','05','06'"
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Inmuebles Cancelados").Index).Select()
                fila = 7
                cant = 1
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
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1
                        If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("03") = True Or loinmueble._InmUpdDetValorNew2.Contains("06") = True) Then
                            count_can_bajas = count_can_bajas + 1
                        ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                            count_can_duplicados = count_can_duplicados + 1
                        ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
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
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 1).Value = count_can_bajas
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = count_can_duplicados
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = count_can_cambiouso
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = count_can_bajas + count_can_cambiouso + count_can_duplicados
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter



                'xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                Me.beprogreso.Caption = "Finalizando Inmuebles Cancelados Otros Fines..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
            End If


            If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO OTROS FINES {1}", fbdExportar.SelectedPath, completa))
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Otros Fines"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            End If


        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub ExportarReporteSerpar(Optional ByVal item As Integer = Nothing)
        Try
            xl = EEExcel.Instancia
            Me.beprogreso.Caption = "Abriendo Exel Temporal... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()
            Dim fila As String = String.Empty
            Dim cant As Integer = 0
            Dim ListaInmueblesLogs As List(Of EEInmueble.EEInmLogs) = Nothing
            Dim completa As String = String.Empty
            If item = 1 Then
                completa = "ACTUALIZACIONES"

                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO SERPAR_Actualizaciones.xls", 1, True, 4)


                '
                '                                                   ACTUALIZACIONES
                '
                Me.beprogreso.Caption = "Cargando Data de Actualizaciones Serpar..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing
                ' Dim loCriteriosConsultas As New EECriterios() With {.tgGRubroId = "04", .FechaInicio = DateSerial(cboAnio.EditValue, 1, 1), .FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)}
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Actualizaciones").Index).Select()
                fila = 7
                cant = 1
                Dim act_san_count As Integer
                Dim act_vc_count As Integer
                Dim act_rc_count As Integer
                Dim act_dir_count As Integer
                Dim act_dirf_count As Integer
                Dim act_area_count As Integer
                If ListaInmueblesLogs IsNot Nothing Then
                    act_san_count = 0
                    act_vc_count = 0
                    act_rc_count = 0
                    act_dir_count = 0
                    act_dirf_count = 0
                    act_area_count = 0
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
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1
                        If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                            act_san_count = act_san_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                            act_vc_count = act_vc_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And loinmueble._InmUpdDetValorNew2 = "06" Then
                            act_rc_count = act_rc_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                            act_dir_count = act_dir_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                            act_dirf_count = act_dirf_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                            act_area_count = act_area_count + 1
                        End If
                    Next
                Else
                    fila = fila + 2
                End If

                Me.beprogreso.Caption = "Escribiendo totales en Actualizaciones Serpar"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS ACTUALIZADOS SERPAR"
                xl.Range("E" & fila).RowHeight = "30"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("E" & fila + 1).Value = "Saneados"
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 2).Value = "Valor comercial actualizados"
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 3).Value = "Registros cancelados"
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 4).Value = "Dirección actualizada"
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 5).Value = "Finca inscrita actualizada"
                xl.Range("E" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 5)).Select()
                xl.Selection.MergeCells = True


                xl.Range("E" & fila + 6).Value = "Área actualizada"
                xl.Range("E" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 6)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 7).Value = "Total de inmuebles"
                xl.Range("E" & fila + 7).Font.Bold = True
                xl.Range("E" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 7)).Select()
                xl.Selection.MergeCells = True

                xl.Range("G" & fila + 1).Value = act_san_count
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = act_vc_count
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = act_rc_count
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = act_dir_count
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 5).Value = act_dirf_count
                xl.Range("G" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 6).Value = act_area_count
                xl.Range("G" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Value = act_san_count + act_vc_count + act_rc_count + act_dir_count + act_dirf_count + act_area_count
                xl.Range("G" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                Me.beprogreso.Caption = "Finalizando Actualizaciones Serpar..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
            End If
            If item = "2 Then" Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO SERPAR_Saneados.xls", 1, True, 4)
                completa = "SANEADOS"

                '
                '                                                   INMUEBLES SANEADOS
                '
                Me.beprogreso.Caption = "Cargando Data de Inmuebles Saneados Serpar..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing
                'loCriteriosConsultas.tgGRubroId = "04"
                'loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
                'loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
                'loCriteriosConsultas.inmUpdDetCampo = "TgEstSanId"
                'loCriteriosConsultas.inmUpdDetValorNew = "01"
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Inmuebles Saneados").Index).Select()
                fila = 7
                cant = 1
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
                        NewBorde3(fila)
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
                xl.Range("E" & fila).RowHeight = "30"
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
            End If
            If item = 3 Then
                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO SERPAR_Cancelados.xls", 1, True, 4)
                completa = "CANCELADOS"
                '
                '                                                   INMUEBLES CANCELADOS
                '
                Me.beprogreso.Caption = "Cargando Data de Inmuebles Cancelados Serpar..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing
                'loCriteriosConsultas.tgGRubroId = "04"
                'loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
                'loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
                'loCriteriosConsultas.inmUpdDetCampo = "TgInmEstado"
                'loCriteriosConsultas.inmUpdDetValorNew = "'03','04','05','06'"
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Inmuebles Cancelados").Index).Select()
                fila = 7
                cant = 1
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
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1

                        If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("03") = True Or loinmueble._InmUpdDetValorNew2.Contains("06") = True) Then
                            count_can_bajas = count_can_bajas + 1
                        ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                            count_can_duplicados = count_can_duplicados + 1
                        ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
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
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 1).Value = count_can_bajas
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = count_can_duplicados
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = count_can_cambiouso
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = count_can_bajas + count_can_cambiouso + count_can_duplicados
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


                Me.beprogreso.Caption = "Finalizando Inmuebles Cancelados Serpar..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
            End If

            If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO SERPAR {1}", fbdExportar.SelectedPath, completa))
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Serpar"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            End If
             

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub ExportarReporteAreasVerdes(Optional ByVal item As Int16 = Nothing)
        Try
            xl = EEExcel.Instancia
            Me.beprogreso.Caption = "Abriendo Exel Temporal... "
            Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            Application.DoEvents()

            ' xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO ÁREAS VERDES.xls", 1, True, 4)

            Dim fila As String = String.Empty
            Dim cant As Integer = 0
            Dim ListaInmueblesLogs As List(Of EEInmueble.EEInmLogs) = Nothing
            Dim completa As String = String.Empty
            If item = 1 Then
                completa = "ACTUALIZACIONES"

                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO ÁREAS VERDES_Actualizaciones.xls", 1, True, 4)


                '
                '                                                   ACTUALIZACIONES
                '
                Me.beprogreso.Caption = "Cargando Data de Actualizaciones Areas Verdes..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing
                ' Dim loCriteriosConsultas As New EECriterios() With {.tgGRubroId = "03", .FechaInicio = DateSerial(cboAnio.EditValue, 1, 1), .FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)}
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Actualizaciones").Index).Select()
                fila = 7
                cant = 1
                Dim act_san_count As Integer
                Dim act_vc_count As Integer
                Dim act_rc_count As Integer
                Dim act_dir_count As Integer
                Dim act_dirf_count As Integer
                Dim act_area_count As Integer
                If ListaInmueblesLogs IsNot Nothing Then
                    act_san_count = 0
                    act_vc_count = 0
                    act_rc_count = 0
                    act_dir_count = 0
                    act_dirf_count = 0
                    act_area_count = 0
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
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1
                        If loinmueble._InmUpdDetCampo = "TgEstSanId" And loinmueble._InmUpdDetValorNew2 = "01" Then
                            act_san_count = act_san_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmValComValTotal" Then
                            act_vc_count = act_vc_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "TgInmEstado" And loinmueble._InmUpdDetValorNew2 = "06" Then
                            act_rc_count = act_rc_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta" Then
                            act_dir_count = act_dir_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmDireccionCompleta Inscrita" Then
                            act_dirf_count = act_dirf_count + 1
                        ElseIf loinmueble._InmUpdDetCampo = "InmPredArea" Then
                            act_area_count = act_area_count + 1
                        End If
                    Next
                Else
                    fila = fila + 2
                End If

                Me.beprogreso.Caption = "Escribiendo totales en Actualizaciones Áreas Verdes"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
                fila = fila + 1
                xl.Range(String.Format("E{0}:G{0}", fila)).Select()
                xl.Selection.MergeCells = True
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlMedium
                xl.Cells.Range(String.Format("E{0}:G{1}", fila, fila + 7)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlMedium
                xl.Range("E" & fila).Value = "RESUMEN DE PREDIOS ACTUALIZADOS ÁREAS VERDES"
                xl.Range("E" & fila).RowHeight = "30"
                xl.Range("E" & fila).Font.Bold = True
                xl.Range("E" & fila).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                xl.Range("E" & fila + 1).Value = "Saneados"
                xl.Range("E" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 1)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 2).Value = "Valor comercial actualizados"
                xl.Range("E" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 2)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 3).Value = "Registros cancelados"
                xl.Range("E" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 3)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 4).Value = "Dirección actualizada"
                xl.Range("E" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 4)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 5).Value = "Finca inscrita actualizada"
                xl.Range("E" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 5)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 6).Value = "Área actualizada"
                xl.Range("E" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 6)).Select()
                xl.Selection.MergeCells = True

                xl.Range("E" & fila + 7).Value = "Total de inmuebles"
                xl.Range("E" & fila + 7).Font.Bold = True
                xl.Range("E" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range(String.Format("E{0}:F{0}", fila + 7)).Select()
                xl.Selection.MergeCells = True

                xl.Range("G" & fila + 1).Value = act_san_count
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = act_vc_count
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = act_rc_count
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = act_dir_count
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 5).Value = act_dirf_count
                xl.Range("G" & fila + 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 6).Value = act_area_count
                xl.Range("G" & fila + 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 7).Value = act_san_count + act_vc_count + act_dir_count + act_dirf_count + act_area_count
                xl.Range("G" & fila + 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


                Me.beprogreso.Caption = "Finalizando Actualizaciones Areas Verdes..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()
            End If
            If item = 2 Then

                completa = "SANEADOS"

                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO ÁREAS VERDES_Saneados.xls", 1, True, 4)

                '
                '                                                   INMUEBLES SANEADOS
                '
                Me.beprogreso.Caption = "Cargando Data de Inmuebles Saneados Areas Verdes..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing
                'loCriteriosConsultas.tgGRubroId = "03"
                'loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
                'loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
                'loCriteriosConsultas.inmUpdDetCampo = "TgEstSanId"
                'loCriteriosConsultas.inmUpdDetValorNew = "01"
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Inmuebles Saneados").Index).Select()
                fila = 7
                cant = 1
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
                        NewBorde3(fila)
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
                xl.Range("E" & fila).RowHeight = "30"
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
            End If
            If item = 3 Then

                completa = "CANCELADOS"

                xl.Workbooks.Open(EEComun.RutaReportes & "\RUBRO ÁREAS VERDES_Cancelados.xls", 1, True, 4)
                '
                '                                                   INMUEBLES CANCELADOS
                '
                Me.beprogreso.Caption = "Cargando Data de Inmuebles Cancelados Areas Verdes..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

                ListaInmueblesLogs = Nothing
                'loCriteriosConsultas.tgGRubroId = "03"
                'loCriteriosConsultas.FechaInicio = DateSerial(cboAnio.EditValue, 1, 1)
                'loCriteriosConsultas.FechaFin = DateSerial(cboAnio.EditValue, 12 + 1, 0)
                'loCriteriosConsultas.inmUpdDetCampo = "TgInmEstado"
                'loCriteriosConsultas.inmUpdDetValorNew = "'03','04','05','06'"
                ListaInmueblesLogs = MantenimientosBL.Instancia.inmuebleUpdateProcesadosListarxCriterios(loCriteriosConsultas)
                xl.Sheets(xl.Worksheets("Inmuebles Cancelados").Index).Select()
                fila = 7
                cant = 1
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
                        NewBorde3(fila)
                        fila = fila + 1
                        cant = cant + 1

                        If loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("03") = True Or loinmueble._InmUpdDetValorNew2.Contains("06") = True) Then
                            count_can_bajas = count_can_bajas + 1
                        ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And (loinmueble._InmUpdDetValorNew2.Contains("04") = True Or loinmueble._InmUpdDetValorNew2.Contains("05") = True) Then
                            count_can_duplicados = count_can_duplicados + 1
                        ElseIf loinmueble._InmUpdDetCampo.Contains("TgInmEstado") = True And loinmueble._InmUpdDetValorNew2.Contains("07") = True Then
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
                xl.Range("E" & fila).RowHeight = "30"
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
                xl.Range("G" & fila + 1).Value = count_can_bajas
                xl.Range("G" & fila + 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 2).Value = count_can_duplicados
                xl.Range("G" & fila + 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 3).Value = count_can_cambiouso
                xl.Range("G" & fila + 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Range("G" & fila + 4).Value = count_can_bajas + count_can_cambiouso + count_can_duplicados
                xl.Range("G" & fila + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


                Me.beprogreso.Caption = "Finalizando Inmuebles Cancelados Áreas Verdes..."
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
                Application.DoEvents()

            End If
            If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\RUBRO ÁREAS VERDES {1}", fbdExportar.SelectedPath, completa))
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Rubro Areas Verdes"
                Me.beprogreso.EditValue = Me.beprogreso.EditValue + 1
            End If


        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        Consultar()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If Me.gvResultado.DataRowCount <> 0 Then
            Dim fmFichaAct As frmInmueblesFichaActualizacionPrint = New frmInmueblesFichaActualizacionPrint(gvResultado.GetFocusedRowCellValue("inmUpdId").ToString())
            fmFichaAct.txtInmCodigo.Text = gvResultado.GetFocusedRowCellValue("codigo").ToString()
            fmFichaAct.txtInmUbicacion.Text = gvResultado.GetFocusedRowCellValue("ubicacion").ToString()
            fmFichaAct.txtFechaModificación.Text = gvResultado.GetFocusedRowCellValue("fechaReg").ToString()
            fmFichaAct.dtFechaDocUpd.Text = gvResultado.GetFocusedRowCellValue("fechaDoc").ToString()
            fmFichaAct.dtFechaRegUpd.Text = gvResultado.GetFocusedRowCellValue("fechaUpd").ToString()
            fmFichaAct.cboTipoUpd.Text = gvResultado.GetFocusedRowCellValue("tipo").ToString()
            fmFichaAct.cboSupuestoUpd.Text = gvResultado.GetFocusedRowCellValue("supuesto").ToString()
            fmFichaAct.cboCampoUpd.Text = gvResultado.GetFocusedRowCellValue("campo").ToString()
            fmFichaAct.txtCampoOld.Text = gvResultado.GetFocusedRowCellValue("valorOld").ToString()
            fmFichaAct.txtCampoNew.Text = gvResultado.GetFocusedRowCellValue("valorNew").ToString()
            fmFichaAct.txtDocUpd.Text = gvResultado.GetFocusedRowCellValue("doc").ToString()
            fmFichaAct.txtObservacion.Text = gvResultado.GetFocusedRowCellValue("obs").ToString()
            fmFichaAct.txtMotivo.Text = gvResultado.GetFocusedRowCellValue("motivo").ToString()
            fmFichaAct.Show()
        End If
    End Sub

 

    Private Sub cboRubroGrupos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRubroGrupos.EditValueChanged

        Dim TgExtra As String = cboRubroGrupos.EditValue
        cboRubro.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRubro.Properties.DisplayMember = "TgNombre"
        cboRubro.Properties.ValueMember = "TgCodigo"
        cboRubro.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgRubros, True, TgExtra)
        cboRubro.ItemIndex = 0
    End Sub
 

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton1.Click
        GValorCriterioBuscado = String.Empty
        GValorTextoBuscado = String.Empty
        btnActivo = 1
    End Sub

    Private Sub SaimtButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton2.Click
        GValorCriterioBuscado = "TgEstSanId"
        GValorTextoBuscado = "01"
        btnActivo = 2
        buscar()
    End Sub

    Private Sub SaimtButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton3.Click
        GValorCriterioBuscado = "TgInmEstado"
        GValorTextoBuscado = "03"
        btnActivo = 3
        buscar()
    End Sub

    Private Sub cboCriterioFecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriterioFecha.EditValueChanged
        If cboCriterioFecha.EditValue IsNot Nothing Then
            Dim tipo As Integer = cboCriterioFecha.EditValue
            Dim clsCriterio As Int32 = 0
            If tipo = 1 Then
                clsCriterio = 40
            ElseIf tipo = 2 Then
                clsCriterio = 190
            Else
                clsCriterio = 191
            End If
            cboCriterioFechaSub.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboCriterioFechaSub.Properties.DisplayMember = "TgNombre"
            cboCriterioFechaSub.Properties.ValueMember = "TgCodigo"
            cboCriterioFechaSub.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(clsCriterio)
            cboCriterioFechaSub.ItemIndex = 0
        End If
    End Sub

    Private Sub gvResultado_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvResultado.DoubleClick
        btnSeleccionar.PerformClick()
    End Sub
End Class