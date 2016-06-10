Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.Office.Interop

Public Class frmConsultarDetalleAbono

    Dim dtPersona As DataTable = New DataTable()
    Dim dtContrato As DataTable = New DataTable()
    Dim dtProgramacionAbono As DataTable = New DataTable()
    Dim xl As Excel.Application
    Dim MensajePrint As String = String.Empty

#Region "Construir Table Persona"
    Private Sub ConstruirTablePersona()
        dtPersona.Columns.Add("PerId", GetType(String))
        dtPersona.Columns.Add("Persona", GetType(String))
        dtPersona.Columns.Add("Contacto", GetType(String))
        dtPersona.Columns.Add("TgTipoDocumento", GetType(String))
        dtPersona.Columns.Add("PerNdoc", GetType(String))
        dtPersona.Columns.Add("TgTipoPersona", GetType(String))
        dtPersona.Columns.Add("PerDireccion", GetType(String))
    End Sub
#End Region

#Region "Construir Table Contrato"
    Private Sub ConstruirTableContrato()
        dtContrato.Columns.Add("AbonId", GetType(String))
        dtContrato.Columns.Add("AbonFechaIni", GetType(DateTime))
        dtContrato.Columns.Add("AbonFechaFin", GetType(DateTime))
        dtContrato.Columns.Add("TipoVehiculo", GetType(String))
        dtContrato.Columns.Add("Estado", GetType(String))
        dtContrato.Columns.Add("Concepto", GetType(String))
        dtContrato.Columns.Add("AbonNPlaca1", GetType(String))
        dtContrato.Columns.Add("AbonNPlaca2", GetType(String))
        dtContrato.Columns.Add("AbonNPlaca3", GetType(String))
        dtContrato.Columns.Add("Nivel", GetType(String))
        dtContrato.Columns.Add("AbonNroEspacio", GetType(Int16))
        dtContrato.Columns.Add("AbonNroMeses", GetType(Int16))
        dtContrato.Columns.Add("AbonImporte", GetType(Decimal))
    End Sub
#End Region

#Region "Construir Table Programacion Abono"
    Private Sub ConstruirTableProgramacionAbono()
        dtProgramacionAbono.Columns.Add("AbonDetId", GetType(String))
        dtProgramacionAbono.Columns.Add("AbonId", GetType(String))
        dtProgramacionAbono.Columns.Add("AbonDetNroCuota", GetType(Int16))
        dtProgramacionAbono.Columns.Add("AbonDetFechaIni", GetType(DateTime))
        dtProgramacionAbono.Columns.Add("AbonDetFechaFin", GetType(DateTime))
        dtProgramacionAbono.Columns.Add("AbonDetFecPago", GetType(String))
        dtProgramacionAbono.Columns.Add("AbonDetPagado", GetType(Boolean))
        dtProgramacionAbono.Columns.Add("AbonDetImporte", GetType(Decimal))
        dtProgramacionAbono.Columns.Add("TgEstadoId", GetType(String))
        dtProgramacionAbono.Columns.Add("Estado", GetType(String))
        dtProgramacionAbono.Columns.Add("AbonDetFechaGenera", GetType(String))
        dtProgramacionAbono.Columns.Add("Temporal", GetType(String))
    End Sub
#End Region

    Private Sub frmConsultarDetalleAbono_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTablePersona()
        ConstruirTableContrato()
        ConstruirTableProgramacionAbono()
        dgvPersona.DataSource = dtPersona
        dgvContratos.DataSource = dtContrato
        dgvProgramacionAbonos.DataSource = dtProgramacionAbono
        Dim lotablageneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId(161)
        If lotablageneral IsNot Nothing Then
            MensajePrint = lotablageneral.Item(0).TgDescripcion.ToUpper
        End If
        cboCriterio2Persona.Properties.ReadOnly = True
        txtFiltroPersona.Focus()
    End Sub

    Private Sub cboCriterioPersona_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCriterioPersona.SelectedIndexChanged
        cboCriterio2Persona.Properties.ReadOnly = True
        txtFiltroPersona.Text = String.Empty
        txtFiltroPersona.Properties.ReadOnly = True
        dtPersona.Clear()
        If cboCriterioPersona.SelectedIndex = 1 Then
            cboCriterio2Persona.Properties.ReadOnly = False
            cboCriterio2Persona.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboCriterio2Persona.Properties.DisplayMember = "TgNombre"
            cboCriterio2Persona.Properties.ValueMember = "TgCodigo"
            cboCriterio2Persona.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(4)
            cboCriterio2Persona.ItemIndex = 0
        Else
            cboCriterio2Persona.Properties.DataSource = Nothing
            cboCriterio2Persona.ItemIndex = -1
            txtFiltroPersona.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub cboCriterio2Persona_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboCriterio2Persona.EditValueChanged
        Try
            Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaConsultarDetalleAbono(1, cboCriterio2Persona.EditValue)
            dtPersona.Clear()
            If ListaPersona IsNot Nothing Then
                For Each fPersona As EEPersona In ListaPersona
                    dtPersona.LoadDataRow(New Object() {fPersona.PerId, _
                    fPersona.Persona, _
                    fPersona.PerContacto, _
                    fPersona.TgDocumento, _
                    fPersona.PerNDoc,
                    fPersona.TgTipoPersona, _
                    fPersona.PerDireccion
                    }, True)
                Next
                gvPersona.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltroPersona_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroPersona.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaConsultarDetalleAbono(cboCriterioPersona.SelectedIndex, txtFiltroPersona.Text)
                dtPersona.Clear()
                If ListaPersona IsNot Nothing Then
                    For Each fPersona As EEPersona In ListaPersona
                        dtPersona.LoadDataRow(New Object() {fPersona.PerId, _
                        fPersona.Persona, _
                        fPersona.PerContacto, _
                        fPersona.TgDocumento, _
                        fPersona.PerNDoc,
                        fPersona.TgTipoPersona, _
                        fPersona.PerDireccion
                        }, True)
                    Next
                    gvPersona.SelectRow(0)
                    dgvPersona_Click(Nothing, Nothing)
                    gvPersona.BestFitColumns()
                End If
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvPersona_Click(sender As System.Object, e As System.EventArgs) Handles dgvPersona.Click
        If Me.gvPersona.DataRowCount <> 0 Then
            txtFiltroContrato.Text = gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "PerId").ToString()
            mListarContratos()
        End If
    End Sub

    Private Sub txtFiltroContrato_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroContrato.KeyDown
        If e.KeyCode = Keys.Enter Then
            mListarContratos()
        End If
    End Sub

    Private Sub mListarContratos()
        Try
            Dim ListaAbonoPEM As List(Of EEAbonoPEM) = MantenimientosBL.Instancia.abonopemListarDetalleAbono(cboCriterioContrato.SelectedIndex, txtFiltroContrato.Text)
            dtContrato.Clear()
            dtProgramacionAbono.Clear()
            If ListaAbonoPEM IsNot Nothing Then
                For Each fAbonoPEM As EEAbonoPEM In ListaAbonoPEM
                    dtContrato.LoadDataRow(New Object() {fAbonoPEM.AbonId,
                        fAbonoPEM.AbonFechaIni,
                        fAbonoPEM.AbonFechaFin,
                        fAbonoPEM.OTgTipoVehiculo.TgNombre,
                        fAbonoPEM.OTgEstado.TgNombre,
                        fAbonoPEM.OConcepto.ConId.Substring(0, 5) & " - " & fAbonoPEM.OConcepto.ConNombre,
                        fAbonoPEM.AbonNPlaca1,
                        fAbonoPEM.AbonNPlaca2,
                        fAbonoPEM.AbonNPlaca3,
                        fAbonoPEM.OTgNivel.TgNombre,
                        fAbonoPEM.AbonNroEspacio,
                        fAbonoPEM.AbonNroMeses,
                        fAbonoPEM.AbonImporte
                    }, True)
                Next
                gvContratos.SelectRow(0)
                dgvContratos_Click(Nothing, Nothing)
                gvContratos.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub gvPersona_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvPersona.CustomRowCellEditForEditing
        If Me.gvPersona.DataRowCount <> 0 Then
            txtFiltroContrato.Text = gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "PerId").ToString()
            mListarContratos()
        End If
    End Sub

    Private Sub dgvContratos_Click(sender As System.Object, e As System.EventArgs) Handles dgvContratos.Click
        If Me.gvContratos.DataRowCount <> 0 Then
            ListarDetalleAbono()
        End If
    End Sub

    Private Sub gvContratos_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvContratos.CustomRowCellEditForEditing
        If Me.gvContratos.DataRowCount <> 0 Then
            ListarDetalleAbono()
        End If
    End Sub

    Private Sub ListarDetalleAbono()
        Try
            Dim loAbonoPEM As EEAbonoPEM = MantenimientosBL.Instancia.abonopemListarDetalleXAbonId(gvContratos.GetRowCellValue(Me.gvContratos.GetSelectedRows(0), "AbonId").ToString())
            dtProgramacionAbono.Clear()

            Dim ldMontoAPagar As Decimal = 0
            Dim ldMontoPagado As Decimal = 0
            Dim ldMontoAPagarTotal As Decimal = 0

            If loAbonoPEM IsNot Nothing Then
                For Each fAbonoDetPEM As EEAbonoPEM.EEAbonoDetPEM In loAbonoPEM.ListaAbonoDetPEM
                    dtProgramacionAbono.LoadDataRow(New Object() {fAbonoDetPEM.AbonDetId,
                        fAbonoDetPEM.OAbonoPEM.AbonId,
                        fAbonoDetPEM.AbonDetNroCuota,
                        fAbonoDetPEM.AbonDetFechaIni,
                        fAbonoDetPEM.AbonDetFechaFin,
                        Format(fAbonoDetPEM.AbonDetFecPago, "dd/MM/yyyy HH:mm:ss"),
                        fAbonoDetPEM.AbonDetPagado,
                        fAbonoDetPEM.AbonDetImporte,
                        fAbonoDetPEM.OTgEstado.TgCodigo,
                        fAbonoDetPEM.OTgEstado.TgNombre,
                        Format(fAbonoDetPEM.AbonDetFechaGenera, "dd/MM/yyyy HH:mm:ss"),
                        True
                    }, True)

                    If fAbonoDetPEM.AbonDetPagado = True AndAlso fAbonoDetPEM.OTgEstado.TgCodigo <> "04" Then
                        ldMontoPagado = ldMontoPagado + fAbonoDetPEM.AbonDetImporte
                    End If

                    If fAbonoDetPEM.AbonDetPagado = False AndAlso fAbonoDetPEM.OTgEstado.TgCodigo <> "04" Then
                        ldMontoAPagar = ldMontoAPagar + fAbonoDetPEM.AbonDetImporte
                    End If

                    If fAbonoDetPEM.OTgEstado.TgCodigo <> "04" Then
                        ldMontoAPagarTotal = ldMontoAPagarTotal + fAbonoDetPEM.AbonDetImporte
                    End If

                Next


                txtMontoAPagar.Text = ldMontoAPagarTotal
                txtMontoPagado.Text = ldMontoPagado
                txtMontoXPagar.Text = ldMontoAPagar
                gvProgramacionAbonos.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Try
            If SaimtMessageBox.mostrarAlertaPregunta("¿Es seguro que desea guardar los cambios en los abonos del contrato del usuario?") Then
                Dim loAbonoPEM As EEAbonoPEM = New EEAbonoPEM()
                loAbonoPEM.AbonId = gvContratos.GetRowCellValue(Me.gvContratos.GetSelectedRows(0), "AbonId").ToString()
                For Each fRow As DataRow In dtProgramacionAbono.Rows
                    Dim loAbonoDetPEM As EEAbonoPEM.EEAbonoDetPEM = New EEAbonoPEM.EEAbonoDetPEM()
                    loAbonoDetPEM.AbonDetId = fRow("AbonDetId").ToString()
                    loAbonoDetPEM.AbonDetNroCuota = Convert.ToInt16(fRow("AbonDetNroCuota").ToString())
                    loAbonoDetPEM.AbonDetFechaIni = Convert.ToDateTime(fRow("AbonDetFechaIni").ToString())
                    loAbonoDetPEM.AbonDetFechaFin = Convert.ToDateTime(fRow("AbonDetFechaFin").ToString())
                    'loAbonoDetPEM.AbonDetFecPago = fRow("AbonDetFecPago")
                    loAbonoDetPEM.OTgEstado = New EETablaGeneral()
                    loAbonoDetPEM.OTgEstado.TgCodigo = fRow("TgEstadoId").ToString()
                    loAbonoDetPEM.AbonDetPagado = Convert.ToBoolean(fRow("AbonDetPagado").ToString())
                    loAbonoDetPEM.AbonDetImporte = Convert.ToDecimal(fRow("AbonDetImporte").ToString())
                    loAbonoDetPEM.AbonDetPerReg = EEComun._PerId
                    loAbonoDetPEM.GuardarOrUpdate = Convert.ToBoolean(fRow("Temporal").ToString())
                    loAbonoPEM.ListaAbonoDetPEM.Add(loAbonoDetPEM)
                Next
                MantenimientosBL.Instancia.abonopemGuardarDetalle(loAbonoPEM)
                SaimtMessageBox.mostrarAlertaInformativa("Se Guardo Correctamente")
                ListarDetalleAbono()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub gvProgramacionAbonos_RowStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvProgramacionAbonos.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim lsEstadoId As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("TgEstadoId"))
            If lsEstadoId = "01" Then
                e.Appearance.BackColor = Color.FromArgb(&HED, &HF2, &H95)
            ElseIf lsEstadoId = "02" Then
                e.Appearance.BackColor = Color.FromArgb(&H84, &HD4, &H97)
            ElseIf lsEstadoId = "03" Then
                e.Appearance.BackColor = Color.FromArgb(&HDA, &H96, &H94)
            ElseIf lsEstadoId = "04" Then
                e.Appearance.BackColor = Color.FromArgb(&H73, &HB1, &HEA)
            End If
        End If
    End Sub

    Private Sub btnAgregarCuota_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarCuota.Click
        Dim liNroCuotasAdd As Int16 = spnNroCuotas.Value
        Dim liTotalFilas As Integer = 0
        Dim liNroCuotaNueva As Integer = 0
        Dim loTablaGeneral As EETablaGeneral = Nothing
        While liNroCuotasAdd > 0
            dtProgramacionAbono.Rows.Add()
            liTotalFilas = dtProgramacionAbono.Rows.Count
            liNroCuotaNueva = liTotalFilas
            dtProgramacionAbono.Rows(liTotalFilas - 1)("AbonId") = dtProgramacionAbono.Rows(liTotalFilas - 2)("AbonId")
            dtProgramacionAbono.Rows(liTotalFilas - 1)("AbonDetImporte") = dtProgramacionAbono.Rows(liTotalFilas - 2)("AbonDetImporte")
            dtProgramacionAbono.Rows(liTotalFilas - 1)("AbonDetId") = liNroCuotaNueva.ToString().PadLeft(2, "0"c) & dtProgramacionAbono.Rows(liTotalFilas - 2)("AbonId")
            dtProgramacionAbono.Rows(liTotalFilas - 1)("AbonDetNroCuota") = liNroCuotaNueva
            dtProgramacionAbono.Rows(liTotalFilas - 1)("AbonDetPagado") = False
            dtProgramacionAbono.Rows(liTotalFilas - 1)("TgEstadoId") = "01"
            loTablaGeneral = MantenimientosBL.Instancia.tablageneralMostrarXClsIdXTgCodigo(118, "01")
            dtProgramacionAbono.Rows(liTotalFilas - 1)("Estado") = loTablaGeneral.TgNombre
            dtProgramacionAbono.Rows(liTotalFilas - 1)("Temporal") = False
            liNroCuotasAdd = liNroCuotasAdd - 1
        End While
    End Sub

    Private Sub btnQuitarCuota_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarCuota.Click
        If Me.gvProgramacionAbonos.DataRowCount <> 0 Then
            If dtProgramacionAbono.Rows(Me.gvProgramacionAbonos.GetSelectedRows(0))("Temporal") = False Then
                dtProgramacionAbono.Rows.RemoveAt(Me.gvProgramacionAbonos.GetSelectedRows(0))
                'SE VUELVE A CALCULAR LOS NUMEROS DE CUOTA POR HABER ELIMINADO UNA CUOTA
                'Y NO DEJAR EL NRO CUOTAS SALTEADOS Y SER NRO CONSECUTIVO
                Dim liPosicionCuota As Integer = 1
                Dim liFila As Integer = 0
                For Each fFilaCuota As DataRow In dtProgramacionAbono.Rows
                    dtProgramacionAbono.Rows(liFila)("AbonDetNroCuota") = liPosicionCuota
                    liPosicionCuota = liPosicionCuota + 1
                    liFila = liFila + 1
                Next
            Else
                If dtProgramacionAbono.Rows(Me.gvProgramacionAbonos.GetSelectedRows(0))("AbonDetPagado") = False Then
                    dtProgramacionAbono.Rows(Me.gvProgramacionAbonos.GetSelectedRows(0))("TgEstadoId") = "04"
                    Dim loTablaGeneral As EETablaGeneral = MantenimientosBL.Instancia.tablageneralMostrarXClsIdXTgCodigo(118, "04")
                    dtProgramacionAbono.Rows(Me.gvProgramacionAbonos.GetSelectedRows(0))("Estado") = loTablaGeneral.TgNombre
                Else
                    SaimtMessageBox.mostrarAlertaAdvertencia("La Cuota Seleccionada no se puede Extornar, ya se encuentra pagado")
                End If
            End If
        End If
    End Sub

    Private Sub gvProgramacionAbonos_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvProgramacionAbonos.CellValueChanged
        If e.Column.FieldName = "AbonDetFechaIni" Then
            dtProgramacionAbono.Rows(e.RowHandle)("AbonDetFechaIni") = e.Value
        ElseIf e.Column.FieldName = "AbonDetFechaFin" Then
            dtProgramacionAbono.Rows(e.RowHandle)("AbonDetFechaFin") = e.Value
        ElseIf e.Column.FieldName = "AbonDetPagado" Then
            dtProgramacionAbono.Rows(e.RowHandle)("AbonDetPagado") = e.Value
        End If
    End Sub

    Private Sub mCalcularTotales()

    End Sub

    Private Sub gvProgramacionAbonos_ShowingEditor(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles gvProgramacionAbonos.ShowingEditor
        If dtProgramacionAbono.Rows(Me.gvProgramacionAbonos.GetSelectedRows(0))("tgEstadoId") = "01" OrElse dtProgramacionAbono.Rows(Me.gvProgramacionAbonos.GetSelectedRows(0))("tgEstadoId") = "02" Then
            e.Cancel = False
        ElseIf dtProgramacionAbono.Rows(Me.gvProgramacionAbonos.GetSelectedRows(0))("AbonDetPagado") = True Then
            e.Cancel = False
        Else

            e.Cancel = True
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        ImprimirTicketAbonado()
    End Sub

    Private Sub ImprimirTicketAbonadoAntiguo()
        If SaimtMessageBox.mostrarAlertaPregunta("¿Esta seguro que desea mandar a imprimir el abono seleccionado?") Then
            If gvProgramacionAbonos.SelectedRowsCount > 0 Then
                If gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetPagado") = True Then
                    Try
                        xl = EEExcel.Instancia
                        xl.Workbooks.Open(EEComun.RutaReportes & "\RptTicketAbonado.xls", 1, True, 4)
                        xl.Sheets(xl.Worksheets("TicketAbonado").Index).Select()
                        xl.Range("B3").Value = "ABONO - " & Format(Date.Now, "dd/MM/yyyy")
                        xl.Cells(5, 2).Value = "RUC. 20481297223 - " & EEComun.Usuario
                        xl.Cells(5, 2).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xl.Cells(5, 1).Resize(1, 4).MergeCells = True
                        xl.Range("C6").Value = "'" & gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetId")
                        xl.Range("A7").Value = gvContratos.GetRowCellValue(Me.gvContratos.GetSelectedRows(0), "Concepto")
                        xl.Range("A8").Value = gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "Persona")
                        xl.Range("A9").Value = String.Format("{0} - {1}", gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "TgTipoDocumento"), gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "PerNdoc"))
                        xl.Range("B10").Value = gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetNroCuota")
                        xl.Range("B11").Value = gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFechaIni")
                        xl.Range("B12").Value = Format(CDate(gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFechaGenera")), "MM/dd/yyyy")
                        xl.Range("B13").Value = gvContratos.GetRowCellValue(Me.gvContratos.GetSelectedRows(0), "AbonNPlaca1")
                        xl.Range("B14").Value = gvContratos.GetRowCellValue(Me.gvContratos.GetSelectedRows(0), "AbonNPlaca3")
                        If gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFecPago").ToString <> "" Then
                            xl.Range("D10").Value = Format(CDate(gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFecPago")), "MM/dd/yyyy")
                            xl.Range("D12").Value = Format(CDate(gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFecPago")), "HH:mm:ss")
                        End If
                        xl.Range("D11").Value = gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFechaFin")
                        xl.Range("D13").Value = gvContratos.GetRowCellValue(Me.gvContratos.GetSelectedRows(0), "AbonNPlaca2")
                        xl.Range("D14").Value = gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetImporte")

                        xl.Range("A16").Value = MensajePrint

                        xl.ActiveSheet.Protect("GeneralX2011", True, True)
                        xl.ActiveWindow.Zoom = 130
                        xl.Application.Visible = True
                        xl.Application.WindowState = Excel.XlWindowState.xlMaximized
                        xl.ActiveWorkbook.PrintOutEx(1, 1, 1, False, xl.ActivePrinter, False, False, "", False)
                        EEComun.CloseAllExcel(xl)
                    Catch ex As Exception
                        SaimtMessageBox.mostrarAlertaError(ex.Message)
                    End Try
                Else
                    SaimtMessageBox.mostrarAlertaInformativa("La Cuota debe estar pagada para poder Imprimir")
                End If

            End If
        End If
    End Sub
    Private Sub ImprimirTicketAbonado()
        If SaimtMessageBox.mostrarAlertaPregunta("¿Esta seguro que desea mandar a imprimir el abono seleccionado?") Then
            If gvProgramacionAbonos.SelectedRowsCount > 0 Then
                If gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetPagado") = True Then
                    Try
                        xl = EEExcel.Instancia
                        xl.Workbooks.Open(EEComun.RutaReportes & "\RptTicketAbonado2.xls", 1, True, 4)
                        xl.Sheets(xl.Worksheets("TicketAbonado").Index).Select()
                        xl.Cells(6, 1).Value = "RUC. 20481297223 - " & EEComun.Usuario
                        xl.Cells(6, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        xl.Cells(6, 1).Resize(1, 4).MergeCells = True
                        xl.Range("C8").Value = "'" & gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetId")
                        xl.Range("A9").Value = gvContratos.GetRowCellValue(Me.gvContratos.GetSelectedRows(0), "Concepto")
                        xl.Range("A10").Value = gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "Persona")
                        xl.Range("A11").Value = String.Format("{0} - {1}", gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "TgTipoDocumento"), gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "PerNdoc"))
                        xl.Range("B12").Value = gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetNroCuota")
                        xl.Range("B13").Value = gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFechaIni")
                        xl.Range("D12").Value = Format(CDate(gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFechaGenera")), "MM/dd/yyyy")
                        xl.Range("B15").Value = gvContratos.GetRowCellValue(Me.gvContratos.GetSelectedRows(0), "AbonNPlaca1")
                        xl.Range("B16").Value = gvContratos.GetRowCellValue(Me.gvContratos.GetSelectedRows(0), "AbonNPlaca3")
                        If gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFecPago").ToString <> "" Then
                            xl.Range("B14").Value = Format(CDate(gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFecPago")), "MM/dd/yyyy")
                            xl.Range("D14").Value = Format(CDate(gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFecPago")), "HH:mm:ss")
                        End If
                        xl.Range("D13").Value = gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetFechaFin")
                        xl.Range("D15").Value = gvContratos.GetRowCellValue(Me.gvContratos.GetSelectedRows(0), "AbonNPlaca2")
                        xl.Range("D16").Value = gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonDetImporte")
                        xl.Range("A17").Value = MensajePrint

                        xl.ActiveSheet.Protect("GeneralX2011", True, True)
                        xl.ActiveWindow.Zoom = 130
                        xl.Application.Visible = True
                        xl.Application.WindowState = Excel.XlWindowState.xlMaximized
                        xl.ActiveWorkbook.PrintOutEx(1, 1, 1, False, xl.ActivePrinter, False, False, "", False)
                        EEComun.CloseAllExcel(xl)
                    Catch ex As Exception
                        SaimtMessageBox.mostrarAlertaError(ex.Message)
                    End Try
                Else
                    SaimtMessageBox.mostrarAlertaInformativa("La Cuota debe estar pagada para poder Imprimir")
                End If

            End If
        End If
    End Sub

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton1.Click
        If SaimtMessageBox.mostrarAlertaPregunta("¿Esta seguro que desea ejecutar el proceso de activacion para el usuario?") Then
            If gvProgramacionAbonos.SelectedRowsCount > 0 Then
                If MantenimientosBL.Instancia.diariopemComprobacionXAbonId(gvProgramacionAbonos.GetRowCellValue(Me.gvProgramacionAbonos.GetSelectedRows(0), "AbonId")) Then
                    SaimtMessageBox.mostrarAlertaInformativa("Activación Completa")
                    ListarDetalleAbono()
                End If
            End If
        End If
    End Sub
End Class