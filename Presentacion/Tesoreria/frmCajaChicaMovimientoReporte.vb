Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Public Class frmCajaChicaMovimientoReporte

    Inherits frmGeneral
    Dim dtDetalleMovimiento As DataTable = New DataTable()
    Dim CajId As String = String.Empty
    Dim CajFondoTotal As Decimal
    Dim xl As Excel.Application
    Dim fechaInicio As Date
    Dim fechafin As Date
    Dim ejecutado As Boolean = False


#Region "Construir Table"
    Private Sub ConstruirTableDetalle()
        dtDetalleMovimiento.Columns.Add("CajDetId", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetNro", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajId", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetFechaMov", GetType(Date))
        dtDetalleMovimiento.Columns.Add("Persona", GetType(String))
        dtDetalleMovimiento.Columns.Add("Area", GetType(String))
        dtDetalleMovimiento.Columns.Add("TgGrupo", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetDescripcion", GetType(String))
        dtDetalleMovimiento.Columns.Add("TgTipoDoc", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetDocSerie", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetDocNro", GetType(String))
        dtDetalleMovimiento.Columns.Add("CajDetImporte", GetType(Decimal))
        dtDetalleMovimiento.Columns.Add("CajDetSaldo", GetType(Decimal))
        dtDetalleMovimiento.Columns.Add("CajDetAnulada", GetType(Boolean))
        dtDetalleMovimiento.Columns.Add("Usuario", GetType(String))
        dtDetalleMovimiento.Columns.Add("PartId", GetType(String))
        dtDetalleMovimiento.Columns.Add("PerNDoc", GetType(String))
        dtDetalleMovimiento.Columns.Add("AreaS", GetType(String))
    End Sub
#End Region

    Private Sub frmCajaChicaMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PuedeBuscar = True
        PuedeCrear = True
        PuedeEditar = True
        cboCriterioAño.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCriterioAño.Properties.DisplayMember = "TgNombre"
        cboCriterioAño.Properties.ValueMember = "TgCodigo"
        cboCriterioAño.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)
        cboCriterioAño.ItemIndex = 0
        ConstruirTableDetalle()
        dgvDetalle.DataSource = dtDetalleMovimiento
        cboCriterioArea.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgArea", "Area")})
        cboCajaChica.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CajNro", "Caja Nro")})
    End Sub

    Private Sub btnMostrarMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarMovimientos.Click
        Try
            If cboCajaChica.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione una Caja a mostrar")
                Return
            End If

            Dim loCajaChica As EECajaChica = MantenimientosBL.Instancia.cajaChicaMostrarxCajId(cboCajaChica.EditValue)
            If loCajaChica IsNot Nothing Then
                CajId = loCajaChica.CajId
                CajFondoTotal = loCajaChica.CajFondoTotal
                txtSaldoFinal.Text = loCajaChica.CajFondoTotal
                txtSaldoInicial.Text = loCajaChica.CajFondoAnterior
                txtChequeGirado.Text = loCajaChica.CajFondoRetiro
                If loCajaChica.CajFechaFin Is Nothing Then
                    fechafin = Nothing
                Else
                    fechafin = loCajaChica.CajFechaFin
                End If
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("No Existen Caja Actualmente Aperturada o usted no tiene permiso")
                Return
            End If

            Dim loCajaChicaDet As List(Of EECajaChica.EECajaChicaDet) = MantenimientosBL.Instancia.cajachicadetListarXCajId(cboCajaChica.EditValue)
            Dim ImporteAcomulado As Decimal
            dtDetalleMovimiento.Clear()
            If loCajaChicaDet IsNot Nothing Then
                For Each frow As EECajaChica.EECajaChicaDet In loCajaChicaDet
                    If frow.CajDetAnulada = False Then
                        ImporteAcomulado = ImporteAcomulado + frow.CajDetImporte
                    End If
                    dtDetalleMovimiento.LoadDataRow(New Object() {frow.CajDetId, frow.CajNro, _
                    frow.CajId, _
                    frow.CajDetFechaMov, _
                    frow.Persona, _
                    frow.Area, _
                    frow.TgGrupo, _
                    frow.CajDetDescripcion, _
                    frow.tgTipoDoc, _
                    frow.CajDetDocSerie, _
                    frow.CajDetDocNro, _
                    frow.CajDetImporte, _
                    CajFondoTotal - ImporteAcomulado, _
                    frow.CajDetAnulada, _
                    frow.usuario, _
                    frow.PartId, frow.PerNDoc, frow.AreaS
                     }, True)
                Next
                gvDetalle.BestFitColumns()
                gvDetalle.SelectRow(0)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            gvDetalle.ExportToXls(sfdexportar.SelectedPath & "\CajaChicaF_Simple" & Format(Now, "dd-MM-yyyy") & ".xls")
            bsiMensaje.Caption = "Se guardo correctamente en la ruta seleccionada con el nombre de CajaChicaF_Simple" & Format(Now, "dd-MM-yyyy") & ".xls"
        End If
    End Sub

    Private Sub cboCriterioAño_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriterioAño.EditValueChanged
        If cboCriterioAño.EditValue IsNot Nothing Then
            cboCriterioArea.Properties.DisplayMember = "TgArea"
            cboCriterioArea.Properties.ValueMember = "TgAreaId"
            cboCriterioArea.Properties.DataSource = MantenimientosBL.Instancia.cajaChicaConfigListarAreasxTgAnioId(cboCriterioAño.EditValue)
            cboCriterioArea.ItemIndex = 0
        End If
    End Sub

  

    Private Sub cboCriterioArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriterioArea.EditValueChanged
        If Not ejecutado Then
            If cboCriterioArea.EditValue IsNot Nothing And cboCriterioAño.EditValue IsNot Nothing Then
                cboCajaChica.Properties.DisplayMember = "CajNro"
                cboCajaChica.Properties.ValueMember = "CajId"
                cboCajaChica.Properties.DataSource = MantenimientosBL.Instancia.cajaChicaListarCajNroxTgAreaId_TgAnioId(cboCriterioArea.EditValue, cboCriterioAño.EditValue)
                cboCajaChica.ItemIndex = 0
            End If
        End If
        ejecutado = Not ejecutado
    End Sub

#Region "Imprimir"

    Private Sub NewBorde(ByVal fila As Integer)
        xl.Cells.Range("A" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("A" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("A" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("A" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("B" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("B" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("B" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("B" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("C" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("C" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("C" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("C" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("D" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("D" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("D" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("D" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("E" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("E" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("E" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("E" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("F" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("F" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("F" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("F" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("G" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("G" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("G" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("G" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("H" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("H" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("H" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("H" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("I" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("I" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("I" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("I" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("J" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("J" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("J" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("J" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("K" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("K" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("K" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("K" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("L" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("L" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("L" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("L" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("M" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("M" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("M" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("M" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("N" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("N" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("N" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("N" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("O" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("O" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("O" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("O" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        xl.Cells.Range("P" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("P" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("P" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("P" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

    End Sub

    Private Sub BackgroundColor(ByVal fila As Integer, ByVal todas As Boolean, Optional ByVal row As Integer = -1)
        If todas = True Then
            xl.Cells(fila, 1).Interior.Color = RGB(217, 217, 217)
            xl.Cells(fila, 2).Interior.Color = RGB(217, 217, 217)
            xl.Cells(fila, 3).Interior.Color = RGB(217, 217, 217)
            xl.Cells(fila, 4).Interior.Color = RGB(217, 217, 217)
            xl.Cells(fila, 5).Interior.Color = RGB(217, 217, 217)
            xl.Cells(fila, 6).Interior.Color = RGB(217, 217, 217)
            xl.Cells(fila, 7).Interior.Color = RGB(217, 217, 217)
            xl.Cells(fila, 8).Interior.Color = RGB(217, 217, 217)
            xl.Cells(fila, 9).Interior.Color = RGB(217, 217, 217)
        Else
            xl.Cells(fila, row).Interior.Color = RGB(217, 217, 217)
        End If
    End Sub
    Sub SetContorno(ByVal celda As String)
        xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub
    Sub SetCelda(ByVal celda As String, ByVal valor As String, Optional ByVal contorno As Boolean = False, Optional ByVal aliniar As Int16 = 0, Optional ByVal negrita As Boolean = False, Optional ByVal subrayado As Boolean = False, Optional ByVal formato As String = "", Optional ByVal AjustarTexto As Boolean = False)
        If formato <> "" Then
            If IsNumeric(valor) Then
                xl.Range(celda).Value = Format(CDbl(valor), formato)
            Else
                xl.Range(celda).Value = Format(valor, formato)
            End If
        Else
            xl.Range(celda).Value = valor
        End If
        If contorno = True Then
            xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        End If
        Select Case aliniar
            Case 1
                xl.Range(celda).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Case 2
                xl.Range(celda).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            Case 3
                xl.Range(celda).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            Case 4
                xl.Range(celda).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        End Select
        If negrita = True Then
            xl.Cells.Range(celda).Font.Bold = True
        End If
        If subrayado = True Then
            xl.Cells.Range(celda).Font.Underline = True
        End If
        If AjustarTexto = True Then
            xl.Cells.Range(celda).WrapText = True
        End If
    End Sub
    Private Sub ExportarExFor()
        Application.DoEvents()
        Dim contProg As Integer = 0
        xl.Sheets(xl.Worksheets("Hoja1").Index).Select()
        SetCelda("C2", "RENDICION DE GASTO CAJA CHICA N° " & CajId.Substring(0, 2))
        SetCelda("A6", String.Format("Fondo otorgado S/. {0} ({1})", txtSaldoFinal.Text, EEComun.NumerosLetras(txtSaldoFinal.Text)))
        SetCelda("I6", fechafin.Date.ToLongDateString)
        Dim i As Integer = 9

        SetCelda("A" & i, "", True)
        SetCelda("B" & i, "", True)
        SetCelda("C" & i, "", True)
        SetCelda("D" & i, "", True)
        SetCelda("E" & i, "", True)
        SetCelda("F" & i, "", True)
        SetCelda("G" & i, "", True)
        SetCelda("H" & i, "SALDO INCIAL", True, 1, True)
        SetCelda("I" & i, "", True)
        SetCelda("J" & i, "", True)
        SetCelda("K" & i, "", True)
        SetCelda("L" & i, txtSaldoFinal.Text, True, 1, , , "##,##00.00")
        i = i + 1
        SetCelda("A" & i, "", True)
        SetCelda("B" & i, "", True)
        SetCelda("C" & i, "", True)
        SetCelda("D" & i, "", True)
        SetCelda("E" & i, "", True)
        SetCelda("F" & i, "", True)
        SetCelda("G" & i, "", True)
        SetCelda("H" & i, "", True)
        SetCelda("I" & i, "", True)
        SetCelda("J" & i, "", True)
        SetCelda("K" & i, txtSaldoFinal.Text, True, 1, True, , "##,##00.00")
        SetCelda("L" & i, txtSaldoFinal.Text, True, 1, True, , "##,##00.00")
        i = i + 1
        beiProgreso.Caption = "Empezando a procesar reporte..."
        riProgreso.Maximum = dtDetalleMovimiento.Rows.Count
        riProgreso.Minimum = 0
        Dim TotalGastado As Decimal
        For Each frow As DataRow In dtDetalleMovimiento.Rows
            SetCelda("A" & i, frow("CajDetNro"), True, 1)
            SetCelda("B" & i, frow("CajDetFechaMov"), True, 1)
            SetCelda("C" & i, frow("TgTipoDoc"), True, 1)
            SetCelda("D" & i, frow("CajDetDocSerie"), True, 1)
            SetCelda("E" & i, frow("CajDetDocNro"), True, 1)
            SetCelda("F" & i, frow("PerNDoc"), True, 1) ' DNI
            SetCelda("G" & i, frow("Persona"), True, 3)
            SetCelda("H" & i, frow("CajDetDescripcion"), True, 3)
            SetCelda("I" & i, frow("AreaS"), True, 1)
            SetCelda("J" & i, frow("CajDetImporte"), True, 1)
            TotalGastado = TotalGastado + frow("CajDetImporte")
            SetCelda("K" & i, frow("CajDetSaldo"), True, 1)
            SetCelda("L" & i, frow("PartId"), True, 1)
            contProg = contProg + 1
            Application.DoEvents()
            beiProgreso.EditValue = contProg
            i = i + 1
        Next
        SetCelda("K" & i, TotalGastado, True, 1, , , "##,##0.00")
        i = i + 1
        SetCelda("B" & i, "Partida Presupuestal", True, 1, True, False, "", True)
        SetCelda("C" & i, "Importe", True, 1, True)
        i = i + 1
        SetContorno(String.Format("H{0}:I{1}", i, (i + 6)))
        SetCelda("H" & i, "MOVIMIENTOS DEL FONDO", False, 0, True, True)
        SetCelda("H" & i + 2, "SALDO INICIAL", False, 0)
        SetCelda("I" & i + 2, txtSaldoInicial.Text, False, 0, , , "##,##0.00")
        SetCelda("H" & i + 3, "(+) INCREMENTO DEL FONDO", False, 0, True)
        SetCelda("I" & i + 3, txtChequeGirado.Text, False, 0, True, True, "##,##0.00")
        SetCelda("H" & i + 4, "TOTAL DEL FONDO", False, 0)
        SetCelda("I" & i + 4, txtSaldoFinal.Text, False, 0, , , "##,##0.00")
        SetCelda("H" & i + 5, "(-) IMPORTE PRESENTE RENDICIÓN", False, 0)
        SetCelda("I" & i + 5, TotalGastado, False, 0, , True, "##,##0.00")
        SetCelda("H" & i + 6, "SALDO ACTUAL", False, 0, True)
        SetCelda("I" & i + 6, CDbl(txtSaldoFinal.Text) - CDbl(TotalGastado), False, 0, True, , "##,##0.00")
        Dim TOTAL As Decimal
        beiProgreso.Caption = "Calculando Totales..."
        Dim CajaChicaDet As List(Of EECajaChica.EECajaChicaDet) = MantenimientosBL.Instancia.cajachicadetListarResumenPartidasXCajId(CajId)
        If CajaChicaDet IsNot Nothing Then
            riProgreso.Maximum = CajaChicaDet.Count
            riProgreso.Minimum = 0
            contProg = 0
            For Each row As EECajaChica.EECajaChicaDet In CajaChicaDet
                SetCelda("B" & i, row.PartId, True, 1)
                TOTAL = TOTAL + row.CajDetImporte
                SetCelda("C" & i, row.CajDetImporte, True, 1, , , "##,##0.00")
                Application.DoEvents()
                beiProgreso.EditValue = contProg
                i = i + 1
            Next
        End If
        SetCelda("B" & i, "TOTAL", True, 1, True)
        SetCelda("C" & i, TOTAL, True, 1, True, , "##,##0.00")

    End Sub
#End Region

    Private Sub btnExportarExFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExFor.Click
        Dim ruta As String = String.Empty
        Try
            If gvDetalle.RowCount > 0 Then

                xl = EEExcel.Instancia

                btnExportarExFor.Enabled = False
                Application.DoEvents()
                beiProgreso.Caption = "Cargando Reporte..."
                beiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptCajaChica.xls", 1, True, 4)
                ExportarExFor()
                If sfdexportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ruta = String.Format("{0}\Caja-ChicaNro_{1}", sfdexportar.SelectedPath, cboCajaChica.EditValue.ToString.Substring(0, 2) & "-" & cboCajaChica.EditValue.ToString.Substring(2, 4))
                    xl.ActiveWorkbook.SaveAs(ruta)
                    xl.ActiveWorkbook.Close()
                    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre Caja-ChicaNro_" & cboCajaChica.EditValue.ToString.Substring(0, 2) & "-" & cboCajaChica.EditValue.ToString.Substring(2, 4)
                End If
                beiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                btnExportarExFor.Enabled = True
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("No hay datos que exportar al reporte, asegurese de dar click al boton Mostrar Movimientos")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub


    'Private Sub cboCriterioArea_ListChanged(sender As System.Object, e As System.ComponentModel.ListChangedEventArgs) Handles cboCriterioArea.ListChanged
    '    If Not ejecutado Then
    '        If cboCriterioArea.EditValue IsNot Nothing And cboCriterioAño.EditValue IsNot Nothing Then
    '            cboCajaChica.Properties.DisplayMember = "CajNro"
    '            cboCajaChica.Properties.ValueMember = "CajId"
    '            cboCajaChica.Properties.DataSource = MantenimientosBL.Instancia.cajaChicaListarCajNroxTgAreaId_TgAnioId(cboCriterioArea.EditValue, cboCriterioAño.EditValue)
    '            cboCajaChica.ItemIndex = 0
    '        End If
    '    End If
    '    ejecutado = Not ejecutado
    'End Sub
End Class