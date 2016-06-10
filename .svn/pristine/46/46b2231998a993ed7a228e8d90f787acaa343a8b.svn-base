Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Public Class frmSimulador
    ReadOnly oTProgramacion As New DataTable
    ReadOnly oTProgramacionDet As New DataTable
    Dim listTabla As List(Of EETablaGeneral)
    Dim xl As Excel.Application

    Sub TCreate()
        oTProgramacion.Columns.Add("cuota", GetType(String))
        oTProgramacion.Columns.Add("Anio", GetType(String))
        oTProgramacion.Columns.Add("mes", GetType(String))
        oTProgramacion.Columns.Add("fechaven", GetType(Date))
        oTProgramacion.Columns.Add("diasven", GetType(Integer))
        oTProgramacion.Columns.Add("cuotatotal", GetType(Decimal))
        oTProgramacion.Columns.Add("pmora", GetType(Decimal))
        oTProgramacion.Columns.Add("totalmora", GetType(Decimal))

        oTProgramacionDet.Columns.Add("conId", GetType(String))
        oTProgramacionDet.Columns.Add("conNombre", GetType(String))
        oTProgramacionDet.Columns.Add("proPaDetMonto", GetType(Decimal))
        oTProgramacionDet.Columns.Add("proPaDetMontoA", GetType(Decimal))
    End Sub
    Private Sub btnGenerarCuotas_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarCuotas.Click
        Dim NroCuotas = DateDiff(DateInterval.Month, dtFechaInicio.EditValue, dtfechaFin.EditValue)
        oTProgramacion.Clear()

        If dtpFechaPago.Text = "" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese la Fecha de Pago para el Calculo")
            dtpFechaPago.Focus()
            Return
        End If
        If TxtDiaVen.EditValue <= 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese los dias de vencimiento para el calculo")
            TxtDiaVen.Focus()
            Return
        End If
        If txtMerced.EditValue <= 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese la merced conductiva para el calculo")
            txtMerced.Focus()
            Return
        End If
  

        If NroCuotas > 0 Then
            Dim fechaVen As Date
            Dim diasVen, cuota, mes, anio As Integer
            Dim totalCuota, totalCuotas, totalmora As Decimal
            Dim aplicaDet As Boolean
            Dim merced, Garantia, derllaves As Decimal
            If IIf(cboTipoMoneda.EditValue = "S", txtMerced.Text, Val(txtMerced.Text * txtTipoCambio.Text)) >= 700 And cboTipoComprobante.EditValue = "F" And cboUso.EditValue = 2 Then
                aplicaDet = True
            Else
                aplicaDet = False
            End If

            If cboTipoMoneda.EditValue = "D" And rbMoneda.EditValue = "S" Then
                merced = txtMerced.Text * txtTipoCambio.Text
                Garantia = txtGarantia.Text * txtTipoCambio.Text
                derllaves = txtderllaves.Text * txtTipoCambio.Text
            Else
                merced = txtMerced.Text
                Garantia = txtGarantia.Text
                derllaves = txtderllaves.Text
            End If

            For i = 0 To NroCuotas
                fechaVen = String.Format("{0}/{1}/{2}", TxtDiaVen.Text, DatePart(DateInterval.Month, DateAdd(DateInterval.Month, i, dtFechaInicio.EditValue)), DatePart(DateInterval.Year, DateAdd(DateInterval.Month, i, dtFechaInicio.EditValue)))
                diasVen = IIf(DateDiff(DateInterval.Day, fechaVen, dtpFechaPago.EditValue) < 0, 0, DateDiff(DateInterval.Day, fechaVen, dtpFechaPago.EditValue))
                cuota = i + 1
                mes = DatePart(DateInterval.Month, DateAdd(DateInterval.Month, i, dtFechaInicio.EditValue))
                anio = DatePart(DateInterval.Year, DateAdd(DateInterval.Month, i, dtFechaInicio.EditValue))
                '--->DETALLES
                totalCuota = 0
                'Merced'Garantia
                totalCuota = totalCuota + merced + IIf(i = 0, Val(Garantia), 0) + Val(derllaves)
                Dim igv As Decimal



                igv = Val(merced) * Val(txtigv.Text)
                'Detracion
                Dim igvSinDet As Decimal = 0
                Dim igvdet As Decimal = 0
                If aplicaDet = True Then
                    igvdet = CDec(merced) * (1 + CDec(txtigv.Text)) * 0.1
                    totalCuota = totalCuota + igvdet

                    igvSinDet = (CDec(merced) * (1 + CDec(txtigv.Text)) - CDec(merced)) - igvdet
                    totalCuota = totalCuota + igvSinDet
                Else
                    igvSinDet = CDec(merced) * (1 + CDec(txtigv.Text)) - CDec(merced)
                End If
                totalCuota = totalCuota + igvSinDet
                'Derecho Mora
                Dim mora As Decimal = 0
                Dim pmora As Decimal
                If chkMora.Checked = True Then
                    pmora = MantenimientosBL.Instancia.parametroMostrarXClsId_ParAnio(72, fechaVen.Year)
                Else
                    pmora = 0
                End If

                If diasVen > 0 Then
                    If chkMora.Checked = True Then
                        mora = diasVen * (CDec(merced) + CDec(igvSinDet)) * MantenimientosBL.Instancia.parametroMostrarXClsId_ParAnio(72, fechaVen.Year)
                    Else
                        mora = 0
                    End If

                    totalCuota = totalCuota + mora
                End If
                '--------------------------------------------------
                If chkMora.Checked = True Then
                    totalmora = totalmora + mora
                Else
                    totalmora = 0
                End If

                oTProgramacion.LoadDataRow(New Object() {cuota, _
                                                         anio, _
                  LetraMes(mes), _
                   fechaVen, _
                   diasVen, _
                    totalCuota, _
                                 pmora, _
                     totalmora}, True)
                totalCuotas = totalCuotas + totalCuota

            Next

            SaimtLabel6.Text = IIf(rbMoneda.EditValue = "S", "Total Pagar en Soles :", "Total Pagar en Dolares :")
            SaimtLabel11.Text = IIf(rbMoneda.EditValue = "S", "Total Mora en Soles :", "Total Mora en Dolares :")
            txttotalpagar.Text = CDec(totalCuotas)
            txtTotalMora.Text = CDec(totalmora)
            txttotalarrendamiento.Text = CDec(totalCuotas) - CDec(totalmora)
            dgvProgramacionPagos.DataSource = oTProgramacion
            gvProgramacionPagos.BestFitColumns()
            btnexportar.Enabled = True
        End If
    End Sub
    Shared Function LetraMes(x As Integer) As String
        Dim mes As String = ""
        Select Case x
            Case 1
                mes = "Enero"
            Case 2
                mes = "Febrero"
            Case 3
                mes = "Marzo"
            Case 4
                mes = "Abril"
            Case 5
                mes = "Mayo"
            Case 6
                mes = "Junio"
            Case 7
                mes = "Julio"
            Case 8
                mes = "Agosto"
            Case 9
                mes = "Setiembre"
            Case 10
                mes = "Octubre"
            Case 11
                mes = "Noviembre"
            Case 12
                mes = "Diciembre"
        End Select

        Return mes
    End Function

    Private Sub frmSimulador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TCreate()
        txtigv.Text = String.Format("{0:0.00}", MantenimientosBL.Instancia.parametroMostrarXClsId(42))
        cboTipoComprobante.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoComprobante.Properties.DisplayMember = "TgNombre"
        cboTipoComprobante.Properties.ValueMember = "TgCodigo"
        cboTipoComprobante.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(36)
        cboTipoComprobante.ItemIndex = 0

        cboTipoGarantia.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoGarantia.Properties.DisplayMember = "TgNombre"
        cboTipoGarantia.Properties.ValueMember = "TgCodigo"
        cboTipoGarantia.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(77)

        cboTipoDocumento.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoDocumento.Properties.DisplayMember = "TgNombre"
        cboTipoDocumento.Properties.ValueMember = "TgCodigo"
        listTabla = MantenimientosBL.Instancia.tablageneralListarXClsId(4)
        cboTipoDocumento.Properties.DataSource = listTabla
        cboTipoDocumento.ItemIndex = 0
        cboUso.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboUso.Properties.DisplayMember = "TgNombre"
        cboUso.Properties.ValueMember = "TgCodigo"
        cboUso.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(16)
        cboUso.ItemIndex = 0

        cboTipoMoneda.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoMoneda.Properties.DisplayMember = "TgNombre"
        cboTipoMoneda.Properties.ValueMember = "TgCodigo"
        cboTipoMoneda.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(5)
        cboTipoMoneda.ItemIndex = 0

    End Sub

    Private Sub cboTipoGarantia_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoGarantia.EditValueChanged
        If cboTipoGarantia.EditValue = 0 Then
            txtGarantia.Text = 0
            txtGarantia.Enabled = False
        Else
            txtGarantia.Enabled = True
        End If
    End Sub


    Sub generaDetalle(ByVal diasVencimiento As Integer, ByVal fechavenc As Date, ByVal cuota As Integer)
        If gvProgramacionPagos.DataRowCount <> 0 Then
            '--->DETALLES
            oTProgramacionDet.Clear()
            Dim aplicaDet As Boolean
            Dim diasVen As Integer = diasVencimiento
            Dim merced, Garantia, derllaves, totalA As Decimal
            If IIf(cboTipoMoneda.EditValue = "S", txtMerced.Text, Val(txtMerced.Text * txtTipoCambio.Text)) >= 700 And cboTipoComprobante.EditValue = "F" And cboUso.EditValue = 2 Then
                aplicaDet = True
            Else
                aplicaDet = False
            End If
            If cboTipoMoneda.EditValue = "D" And rbMoneda.EditValue = "S" Then
                merced = txtMerced.Text * txtTipoCambio.Text
                Garantia = txtGarantia.Text * txtTipoCambio.Text
                derllaves = txtderllaves.Text * txtTipoCambio.Text
            Else
                merced = txtMerced.Text
                Garantia = txtGarantia.Text
                derllaves = txtderllaves.Text
            End If
            'Merced
            Dim fechaVen As Date = fechavenc
            totalA = totalA + merced
            oTProgramacionDet.LoadDataRow(New Object() {"S0001" & DatePart(DateInterval.Year, fechaVen), "MERCED CONDUCTIVA", merced, totalA}, True)
            If CInt(cuota) = 1 Then
                'Garantia
                If Val(Garantia) > 0 And cboTipoGarantia.EditValue = 2 Then
                    totalA = totalA + Garantia
                    oTProgramacionDet.LoadDataRow(New Object() {"S0893" & DatePart(DateInterval.Year, fechaVen), "GARANTIA", Garantia, totalA}, True)
                ElseIf cboTipoGarantia.EditValue = 1 Then
                    totalA = totalA + Garantia
                    oTProgramacionDet.LoadDataRow(New Object() {"S0998" & DatePart(DateInterval.Year, fechaVen), "GARANTIA REINTEGRO", Garantia, totalA}, True)
                End If
                'Derecho de Llaves
                If Val(derllaves) > 0 Then
                    totalA = totalA + derllaves
                    oTProgramacionDet.LoadDataRow(New Object() {"S0885" & DatePart(DateInterval.Year, fechaVen), "DERECHO LLAVES", derllaves, totalA}, True)
                End If
            End If
            Dim igv As Decimal
            igv = Val(merced) * Val(txtigv.Text)
            'Detracion
            Dim igvSinDet As Decimal = 0
            Dim igvdet As Decimal = 0
            If aplicaDet = True Then
                igvdet = Val(merced) * (1 + Val(txtigv.Text)) * 0.12
                totalA = totalA + igvdet
                oTProgramacionDet.LoadDataRow(New Object() {"S6177" & DatePart(DateInterval.Year, fechaVen), "IGV DETRACION", igvdet, totalA}, True)
                igvSinDet = (Val(merced) * (1 + Val(txtigv.Text)) - Val(merced)) - igvdet
                totalA = totalA + igvSinDet
                oTProgramacionDet.LoadDataRow(New Object() {"S4516" & DatePart(DateInterval.Year, fechaVen), "IGV MERCED", igvSinDet, totalA}, True)
            Else
                igvSinDet = Val(merced) * (1 + Val(txtigv.Text)) - Val(merced)
                totalA = totalA + igvSinDet
                oTProgramacionDet.LoadDataRow(New Object() {"S4516" & DatePart(DateInterval.Year, fechaVen), "IGV MERCED", igvSinDet, totalA}, True)
            End If
            'Derecho Mora
            Dim mora, pmora As Decimal
            pmora = MantenimientosBL.Instancia.parametroMostrarXClsId_ParAnio(72, fechaVen.Year)
            If diasVen > 0 Then
                mora = diasVen * (CDec(merced) + CDec(igvSinDet)) * pmora
                totalA = totalA + mora
                If chkMora.Checked = True Then
                    oTProgramacionDet.LoadDataRow(New Object() {"S0835" & DatePart(DateInterval.Year, fechaVen), "MORA", mora, totalA}, True)
                End If
            End If
            dgvProgramacionPagosDetalle.DataSource = oTProgramacionDet
            gvProgramacionPagosDetalle.BestFitColumns()
            colProPaDetMonto.Width = 60
        End If
    End Sub

    Private Sub gvProgramacionPagos_Click(sender As System.Object, e As System.EventArgs) Handles gvProgramacionPagos.Click
        If gvProgramacionPagos.SelectedRowsCount <> 0 Then
            generaDetalle(gvProgramacionPagos.GetRowCellValue(gvProgramacionPagos.GetSelectedRows(0), "diasven"), gvProgramacionPagos.GetRowCellValue(gvProgramacionPagos.GetSelectedRows(0), "fechaven"), gvProgramacionPagos.GetRowCellValue(gvProgramacionPagos.GetSelectedRows(0), "cuota"))
        End If

    End Sub

    Private Sub btnConsultarInmueble_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultarInmueble.Click
        Using fmConsultainmueble As frmConsultaInmuebleSimulador = New frmConsultaInmuebleSimulador
            If fmConsultainmueble.ShowDialog() = DialogResult.OK Then
                txtCodInm.Text = fmConsultainmueble.InmId
                txtDirInmueble.Text = fmConsultainmueble.InmDir
            End If
        End Using
    End Sub

    Private Sub SaimtLabel1_Click(sender As System.Object, e As System.EventArgs) Handles SaimtLabel1.Click

    End Sub

    Private Sub cboTipoMoneda_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoMoneda.EditValueChanged
        If cboTipoMoneda.EditValue = "D" Then
            txtTipoCambio.Text = ""
            txtTipoCambio.Enabled = True
        Else
            txtTipoCambio.Focus()
            txtTipoCambio.Enabled = False
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Me.btnImprimir.Enabled = False
        EEComun.ExportarPrintForm(Me, Me.Text)
        Me.btnImprimir.Enabled = True
    End Sub

    Private Sub btnexportar_Click(sender As System.Object, e As System.EventArgs) Handles btnexportar.Click
        Try
            btnexportar.Enabled = False
            If Len(txtPersona.Text) = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Debe ingresar el nombre de la persona a simular en la programación")
                Exit Sub
            End If
            If Me.cboTipoDocumento.Text.Length = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Debe ingresar el tipo documento de para la simulación")
                Exit Sub
            End If
            If Len(txtNroDocumento.Text) = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Debe ingresar Nro. Documento de la persona")
                Exit Sub
            End If
            If Len(txtCodInm.Text) = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Debe buscar el inmueble el cual se va a seleccionar para la simulación")
                Exit Sub
            End If
            If oTProgramacion.Rows.Count = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Si ya ingreso los parametros para la simulación, debe hacer click en el boton Calcular Pagos")
                Exit Sub
            End If
            ReporteSimulacion()
            btnexportar.Enabled = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError("btnExportarReporte => " & ex.Message)
        End Try
    End Sub
    Public Sub ReporteSimulacion()
        Dim fila As Integer = 0
        Dim contMaestro As Integer = 0
        Dim contDetalle As Integer = 0
        Dim sumMaestro, sumDet As Decimal
        xl = EEExcel.Instancia
        xl.Workbooks.Open(EEComun.RutaReportes & "\RptSimulacion.xls", 1, True, 4)
        Me.beiprogreso.Caption = "Procesando Reporte de Simulación..."
        Me.ripprogreso.Minimum = 0
        Me.beiprogreso.EditValue = 0
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        fila = 5
        sumMaestro = 0
        sumDet = 0
        xl.Cells(fila, 2) = txtPersona.Text.Trim
        fila = fila + 1
        xl.Cells(fila, 2) = cboTipoDocumento.Text.Trim
        fila = fila + 1
        xl.Cells(fila, 2) = txtNroDocumento.Text.Trim
        fila = fila + 3
        xl.Cells(fila, 2) = txtCodInm.Text.Trim
        fila = fila + 1
        xl.Cells(fila, 2) = txtDirInmueble.Text.Trim
        fila = fila + 3
        xl.Cells(fila, 2) = dtFechaInicio.DateTime.Date
        xl.Cells(fila, 4) = dtfechaFin.DateTime.Date
        xl.Cells(fila, 6) = cboTipoMoneda.Text.Trim
        xl.Cells(fila, 8) = txtTipoCambio.Text.Trim
        fila = fila + 1
        xl.Cells(fila, 2) = txtigv.Text.Trim
        xl.Cells(fila, 4) = TxtDiaVen.Text.Trim
        xl.Cells(fila, 6) = txtderllaves.Text.Trim
        xl.Cells(fila, 8) = cboTipoComprobante.Text.Trim
        fila = fila + 1
        xl.Cells(fila, 2) = cboTipoGarantia.Text.Trim
        xl.Cells(fila, 4) = txtGarantia.Text.Trim
        xl.Cells(fila, 6) = cboUso.Text.Trim
        fila = fila + 1
        xl.Cells(fila, 2) = dtpFechaPago.DateTime.Date
        If Me.rbMoneda.EditValue = "S" Then
            xl.Cells(fila, 8) = "Calculo en Soles"
        Else
            xl.Cells(fila, 8) = "Calculo en Dólares"
        End If
        fila = fila + 4
        xl.Cells(fila, 1) = "N° Cuota"
        xl.Cells(fila, 1).Font.Bold = True
        xl.Cells(fila, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(fila, 1).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xl.Cells(fila, 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 1).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 1).Interior.Color = RGB(184, 204, 228)
        xl.Cells(fila, 2) = "Año"
        xl.Cells(fila, 2).Font.Bold = True
        xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(fila, 2).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xl.Cells(fila, 2).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 2).Interior.Color = RGB(184, 204, 228)
        xl.Cells(fila, 3) = "Mes"
        xl.Cells(fila, 3).Font.Bold = True
        xl.Cells(fila, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(fila, 3).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xl.Cells(fila, 3).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 3).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 3).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 3).Interior.Color = RGB(184, 204, 228)
        xl.Cells(fila, 4) = "Fech. Venc."
        xl.Cells(fila, 4).Font.Bold = True
        xl.Cells(fila, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(fila, 4).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xl.Cells(fila, 4).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 4).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 4).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 4).Interior.Color = RGB(184, 204, 228)
        xl.Cells(fila, 5) = "Dias Venc."
        xl.Cells(fila, 5).Font.Bold = True
        xl.Cells(fila, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(fila, 5).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 5).Interior.Color = RGB(184, 204, 228)
        xl.Cells(fila, 6) = "Total X Cuota"
        xl.Cells(fila, 6).Font.Bold = True
        xl.Cells(fila, 6).WrapText = True
        xl.Cells(fila, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(fila, 6).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 6).Interior.Color = RGB(184, 204, 228)
        xl.Cells(fila, 7) = "Mora Acumulada"
        xl.Cells(fila, 7).Font.Bold = True
        xl.Cells(fila, 7).WrapText = True
        xl.Cells(fila, 7).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(fila, 7).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xl.Cells(fila, 7).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 7).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 7).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 7).Interior.Color = RGB(184, 204, 228)
        xl.Cells(fila, 8) = "% Mora"
        xl.Cells(fila, 8).Font.Bold = True
        xl.Cells(fila, 8).WrapText = True
        xl.Cells(fila, 8).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(fila, 8).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xl.Cells(fila, 8).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 8).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 8).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 8).Interior.Color = RGB(184, 204, 228)
        fila = fila + 1
        Me.ripprogreso.Minimum = 0
        Me.ripprogreso.Maximum = oTProgramacion.Rows.Count
        For contMaestro = 0 To oTProgramacion.Rows.Count - 1
            Application.DoEvents()
            Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
            Me.beiprogreso.Caption = "Procesando Reporte de Simulación... (" & Format(Me.beiprogreso.EditValue / Me.ripprogreso.Maximum, "0%") & ") "
            xl.Cells(fila, 1) = oTProgramacion.Rows(contMaestro).Item("cuota").ToString()
            xl.Cells(fila, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells(fila, 1).Resize(1, 7).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 1).Resize(1, 7).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 2) = oTProgramacion.Rows(contMaestro).Item("Anio").ToString()
            xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells(fila, 3) = oTProgramacion.Rows(contMaestro).Item("mes").ToString()
            xl.Cells(fila, 4) = DateValue(oTProgramacion.Rows(contMaestro).Item("fechaven"))
            xl.Cells(fila, 5) = oTProgramacion.Rows(contMaestro).Item("diasven").ToString()
            xl.Cells(fila, 6) = oTProgramacion.Rows(contMaestro).Item("cuotatotal").ToString()
            sumMaestro = sumMaestro + CDec(xl.Cells(fila, 6).Value)
            xl.Cells(fila, 6).NumberFormat = "###,##0.00"
            'xl.Cells(fila, 6).Interior.Color = RGB(196, 189, 151)
            xl.Cells(fila, 7) = oTProgramacion.Rows(contMaestro).Item("totalmora").ToString()
            xl.Cells(fila, 7).NumberFormat = "###,##0.00"
            xl.Cells(fila, 8) = CDec(oTProgramacion.Rows(contMaestro).Item("pmora"))
            xl.Cells(fila, 8).NumberFormat = "0.0%"

            fila = fila + 1
            xl.Cells(fila, 2) = "Cod. Concepto"
            xl.Cells(fila, 2).Font.Bold = True
            xl.Cells(fila, 2).WrapText = True
            xl.Cells(fila, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells(fila, 2).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xl.Cells(fila, 2).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 2).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 2).Interior.Color = RGB(216, 228, 188)
            xl.Cells(fila, 3) = "Concepto"
            xl.Cells(fila, 3).Font.Bold = True
            xl.Cells(fila, 3).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells(fila, 3).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xl.Cells(fila, 3).Resize(1, 2).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 3).Resize(1, 2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 3).Resize(1, 2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 3).Resize(1, 2).Interior.Color = RGB(216, 228, 188)
            xl.Cells(fila, 3).Resize(1, 2).MergeCells = True
            xl.Cells(fila, 5) = "Monto"
            xl.Cells(fila, 5).Font.Bold = True
            xl.Cells(fila, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells(fila, 5).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 5).Interior.Color = RGB(216, 228, 188)
            xl.Cells(fila, 6) = "Monto Acumulado"
            xl.Cells(fila, 6).Font.Bold = True
            xl.Cells(fila, 6).WrapText = True
            xl.Cells(fila, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells(fila, 6).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 6).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 6).Interior.Color = RGB(216, 228, 188)
            fila = fila + 1
            sumDet = 0
            generaDetalle(oTProgramacion.Rows(contMaestro).Item("diasven"), oTProgramacion.Rows(contMaestro).Item("fechaven"), oTProgramacion.Rows(contMaestro).Item("cuota"))
            For contDetalle = 0 To oTProgramacionDet.Rows.Count - 1
                xl.Cells(fila, 2) = oTProgramacionDet.Rows(contDetalle).Item("conId").ToString
                xl.Cells(fila, 2).Resize(1, 5).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot
                xl.Cells(fila, 3) = oTProgramacionDet.Rows(contDetalle).Item("conNombre").ToString
                xl.Cells(fila, 5) = oTProgramacionDet.Rows(contDetalle).Item("proPaDetMonto").ToString
                xl.Cells(fila, 5).NumberFormat = "###,##0.00"
                sumDet = sumDet + CDec(xl.Cells(fila, 5).Value)
                xl.Cells(fila, 6) = oTProgramacionDet.Rows(contDetalle).Item("proPaDetMontoA").ToString
                xl.Cells(fila, 6).NumberFormat = "###,##0.00"
                fila = fila + 1
            Next
            xl.Cells(fila, 4) = "Total N° Cuota " & Format(CInt(oTProgramacion.Rows(contMaestro).Item("cuota")), "00")
            xl.Cells(fila, 4).Font.Bold = True
            xl.Cells(fila, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xl.Cells(fila, 4).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 3).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 5) = sumDet
            xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(fila, 5).Font.Bold = True
            xl.Cells(fila, 5).NumberFormat = "###,##0.00"
            xl.Cells(fila, 5).Interior.Color = RGB(196, 189, 151)
            fila = fila + 1
        Next
        xl.Cells(fila, 4) = "Total a Pagar"
        xl.Cells(fila, 4).Font.Bold = True
        xl.Cells(fila, 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        xl.Cells(fila, 5) = sumMaestro
        xl.Cells(fila, 5).NumberFormat = "###,##0.00"
        xl.Cells(fila, 5).Font.Bold = True
        xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells(fila, 5).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        fila = fila + 2
        xl.Cells(fila, 1) = "RESUMEN"
        xl.Cells(fila, 1).Resize(1, 8).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        fila = fila + 1
        xl.Cells(fila, 1) = "Total a pagar solo en arrendamiento (Códigos S0001 y S4516)……………………………………"
        xl.Cells(fila, 7) = CDec(txttotalarrendamiento.Text.Trim)
        xl.Cells(fila, 7).NumberFormat = "###,##0.00"
        fila = fila + 1
        xl.Cells(fila, 1) = "Total a pagar solo en Mora (Código S0835)…………………………………………………………………"
        xl.Cells(fila, 7) = CDec(txtTotalMora.Text.Trim)
        xl.Cells(fila, 7).NumberFormat = "###,##0.00"
        xl.Cells(fila, 7).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        fila = fila + 1
        xl.Cells(fila, 1) = "Total a Pagar Final……………………………………………………………………………………………………."
        xl.Cells(fila, 1).Font.Bold = True
        xl.Cells(fila, 7) = CDec(txttotalpagar.Text.Trim)
        xl.Cells(fila, 7).NumberFormat = "###,##0.00"
        xl.Cells(fila, 7).Font.Bold = True
        sfdExportar.Filter = "Archivo de Excel|*.xls"
        If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            xl.ActiveWorkbook.SaveAs(fbdExportar.SelectedPath & "\Simulacion_Fincas" & Format(Now, "dd-MM-yyyy"))
            xl.ActiveWorkbook.Close()
            Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada"
        End If

        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
End Class