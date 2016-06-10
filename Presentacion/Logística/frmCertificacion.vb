Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports DevExpress.XtraEditors.Repository

Public Class frmCerticicacion
    Inherits frmMantenimientos

    Dim xl As Excel.Application
    Dim dtListado As DataTable = New DataTable()
    Dim dtDetalleCerGrupoPartida As DataTable = New DataTable()
    Private ListaTemporal_CertificacionGrupoPartidaNuevo As List(Of EECertificacion.EECertificacionGrupoPartida) = New List(Of EECertificacion.EECertificacionGrupoPartida)
    Private ListaTemporal_CertificacionGrupoPartidaElimandos As List(Of String) = New List(Of String)
    Dim monTotCert As Decimal = 0

#Region "Construir Table"
    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("cerId", GetType(String))
        dtListado.Columns.Add("cerNro", GetType(String))
        dtListado.Columns.Add("partId", GetType(String))
        dtListado.Columns.Add("cerFecha", GetType(Date))
        dtListado.Columns.Add("partNombre", GetType(String))
        'dtListado.Columns.Add("partAño", GetType(String))
    End Sub
    Private Sub ConstruirTableDetalleCerGrupoPartidas()
        dtDetalleCerGrupoPartida.Columns.Add("cerGrupoParId", GetType(String))
        dtDetalleCerGrupoPartida.Columns.Add("partId", GetType(String))
        dtDetalleCerGrupoPartida.Columns.Add("partNombre", GetType(String))
        dtDetalleCerGrupoPartida.Columns.Add("partAnio", GetType(String))
        dtDetalleCerGrupoPartida.Columns.Add("cerGrupoParValImporte", GetType(Decimal))
    End Sub
#End Region

#Region "Funciones Sobrescritas"

    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvResultados.DataRowCount <> 0 Then
                Dim lstCertificacion As EECertificacion = Nothing
                GIndiceSeleccionado = Me.gvResultados.GetSelectedRows(0)
                lstCertificacion = MantenimientosBL.Instancia.CertificacionMostrarCertificacionXCerId(gvResultados.GetRowCellValue(GIndiceSeleccionado, "cerId").ToString())

                If lstCertificacion IsNot Nothing Then
                    txtCerId.Text = lstCertificacion.CerId
                    txtCerNro.Text = lstCertificacion.CerNro
                    dtpFechaCer.EditValue = lstCertificacion.CerFecha
                    cboAreaSolicitante.EditValue = lstCertificacion.TgAreaSolicitanteId
                    txtSolicitadoCon.Text = lstCertificacion.CerSolicitadoCon
                    txtContExp.Text = lstCertificacion.CerContExpediente
                    txtJustificacion.Text = lstCertificacion.CerJustificacion
                    cboActProy.EditValue = lstCertificacion.TgActProyId
                    cboMeta.EditValue = lstCertificacion.TgMetaId
                    cboFuenteFinanciera.EditValue = lstCertificacion.TgFFinancieraId

                    txtObservacion.Text = lstCertificacion.CerObservacion

                    dtDetalleCerGrupoPartida.Clear()
                    ListaTemporal_CertificacionGrupoPartidaNuevo.Clear()
                    ListaTemporal_CertificacionGrupoPartidaElimandos.Clear()

                    Dim CertificacionGrupoPartida As List(Of EECertificacion.EECertificacionGrupoPartida) = MantenimientosBL.Instancia.CertificacionGrupoPartidaXcerId(txtCerId.Text)
                    If CertificacionGrupoPartida IsNot Nothing Then
                        txtImporteTotal.Text = 0
                        For Each frow As EECertificacion.EECertificacionGrupoPartida In CertificacionGrupoPartida
                            dtDetalleCerGrupoPartida.LoadDataRow(New Object() {frow.cerGrupoParId,
                                                                               frow.partId, _
                                                                               frow.PartNombre, _
                                                                               frow.partAnio, _
                                                                               Format(CDbl(frow.cerGrupoParValImporte), "##,##0.00")
                                                                         },
                                                                     True)

                            txtImporteTotal.Text = txtImporteTotal.Text + frow.cerGrupoParValImporte
                        Next
                    End If
                    gvDetalleCerGrupoPartida.BestFitColumns()
                    GIdRegistroActual = txtCerId.Text
                End If
                GIdRegistroActual = txtCerId.Text
            End If
            MyBase.seleccionarListado()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtCerId.EditValue = MantenimientosBL.Instancia.CertificacionGeneraCodigo
        txtCerId.Properties.ReadOnly = True
        txtPartida.Properties.ReadOnly = True

        cboAreaSolicitante.EditValue = "005"
        cboActProy.EditValue = "1000267"
        cboMeta.EditValue = "0001"
        cboFuenteFinanciera.EditValue = "09"

        txtSolicitadoCon.Text = "Proveído N° -" & CStr(Year(Now)) & "-SAIMT-GAF"

        txtObservacion.Text = "Visto el expediente cuyo contenido se detalla en el numeral 03 del presente documento y en amparo de lo dispuesto en el Art 11° de la Directiva N°001-2010-EF/76.01, se aprueba la presente Certificación por los importes y en las partidas señaladas, para que se continúe con el trámite respectivo."
        dtDetalleCerGrupoPartida.Clear()
        ListaTemporal_CertificacionGrupoPartidaNuevo.Clear()
        ListaTemporal_CertificacionGrupoPartidaElimandos.Clear()
        txtImporte.Text = 0
        monTotCert = 0
    End Sub
    Protected Overrides Sub cancelar()
        MyBase.cancelar()
        btnNuevo.Enabled = True
    End Sub

    Protected Overrides Sub guardar()
        Try
            If String.IsNullOrEmpty(dtpFechaCer.EditValue) Then
                dtpFechaCer.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Selecciones la Fecha de la Certificación")
                Return
            End If
            If String.IsNullOrEmpty(cboAreaSolicitante.Text) Then
                cboAreaSolicitante.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Area de Solicitante")
                Return
            End If
            If String.IsNullOrEmpty(txtPartida.Tag) Then
                txtPartida.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione la Partida")
                Return
            End If

            Dim loCertificacion As EECertificacion = New EECertificacion()
            'datos orden compra
            loCertificacion.CerId = txtCerId.Text
            loCertificacion.CerNro = txtCerNro.Text
            loCertificacion.CerFecha = dtpFechaCer.Text
            loCertificacion.CerSolicitadoCon = txtSolicitadoCon.Text
            loCertificacion.TgAreaSolicitanteId = cboAreaSolicitante.EditValue
            loCertificacion.CerContExpediente = txtContExp.Text
            loCertificacion.CerJustificacion = txtJustificacion.Text
            loCertificacion.TgActProyId = cboActProy.EditValue
            loCertificacion.TgMetaId = cboMeta.EditValue
            loCertificacion.TgFFinancieraId = cboFuenteFinanciera.EditValue
            loCertificacion.CerValTotal = CDec(txtImporteTotal.EditValue)
            loCertificacion.CerObservacion = txtObservacion.Text

            Dim loCertificacionGrupoPartidas As EECertificacion.EECertificacionGrupoPartida
            loCertificacion.ListaCertificacionGrupoPartidas = New List(Of EECertificacion.EECertificacionGrupoPartida)

            For Each frowDet As DataRow In dtDetalleCerGrupoPartida.Rows
                loCertificacionGrupoPartidas = New EECertificacion.EECertificacionGrupoPartida
                loCertificacionGrupoPartidas.cerGrupoParId = frowDet("cerGrupoParId")
                loCertificacionGrupoPartidas.cerId = txtCerId.EditValue
                loCertificacionGrupoPartidas.partId = frowDet("partId")
                loCertificacionGrupoPartidas.partAnio = frowDet("partAnio").ToString
                loCertificacionGrupoPartidas.cerGrupoParValImporte = CDec(frowDet("cerGrupoParValImporte"))
                loCertificacionGrupoPartidas.cerGrupoParValQuedan = CDec(frowDet("cerGrupoParValImporte"))
                ListaTemporal_CertificacionGrupoPartidaNuevo.Add(loCertificacionGrupoPartidas)
            Next
            loCertificacion.ListaCertificacionGrupoPartidas = ListaTemporal_CertificacionGrupoPartidaNuevo

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.CertificacionGuardar(loCertificacion)
            End If
            enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterio.SelectedIndex

            Dim loCertificacion As List(Of EECertificacion) = MantenimientosBL.Instancia.CertificacionListarBCriterio(GCriterioBuscado, GValorTextoBuscado, cboAnioCriterio.EditValue)

            dtListado.Clear()
            If loCertificacion IsNot Nothing Then
                For Each frow As EECertificacion In loCertificacion
                    dtListado.LoadDataRow(New Object() {frow.CerId, frow.CerNro, frow.PartId, frow.CerFecha}, True)
                Next
                gvResultados.BestFitColumns()
                gvResultados.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub imprimir()
        Try
            xl = EEExcel.Instancia
            xl.Workbooks.Open(EEComun.RutaReportes & "\RptCertificacion.xls", 1, True, 4)
            ExportarCertificacion()
            xl.Application.Visible = True
            '=======
            'If sfdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '    xl.ActiveWorkbook.SaveAs(String.Format("{0}\Certificacion_Nro_{1}", sfdExportar.SelectedPath, Trim(txtCerNro.Text) & "-" & Year(dtpFechaCer.DateTime).ToString))
            '    xl.ActiveWorkbook.Close()
            '    Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada, con el nombre " & "Certificacion_Nro_" & Trim(txtCerNro.Text) & "-" & Year(dtpFechaCer.DateTime).ToString
            'End If

            '>>>>>>> .r3278
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
        MyBase.imprimir()
    End Sub
#End Region

#Region "Imprimir"

    Private Sub ExportarCertificacion()
        xl.Sheets(xl.Worksheets("Certificacion").Index).Select()

        SetCelda("K1", txtCerNro.Text)
        SetCelda("D3", txtSolicitadoCon.Text)
        SetCelda("D5", cboAreaSolicitante.Text)
        SetCelda("E7", txtContExp.Text)
        SetCelda("D9", txtJustificacion.Text)

        Dim file As Integer = 12
        Dim SUMA As Decimal = 0
        For Each row As DataRow In dtDetalleCerGrupoPartida.Rows
            SetCelda("A" & file, cboActProy.Text, True)
            xl.Cells(file, 1).Resize(1, 4).borders(Excel.XlBordersIndex.xlEdgeBottom).linestyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(file, 1).Resize(1, 4).MergeCells = True
            xl.Cells(file, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            SetCelda("E" & file, row("partId"), True)
            xl.Cells(file, 5).Resize(1, 5).borders(Excel.XlBordersIndex.xlEdgeBottom).linestyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(file, 5).Resize(1, 5).MergeCells = True
            SetCelda("J" & file, cboFuenteFinanciera.EditValue, True)
            SetCelda("k" & file, cboMeta.EditValue, True)
            xl.Cells(file, 11).Resize(1, 2).borders(Excel.XlBordersIndex.xlEdgeBottom).linestyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(file, 11).Resize(1, 2).MergeCells = True
            SetCelda("M" & file, row("cerGrupoParValImporte"), True)
            xl.Cells(file, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells(file, 13).Resize(1, 4).borders(Excel.XlBordersIndex.xlEdgeRight).linestyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(file, 13).Resize(1, 4).borders(Excel.XlBordersIndex.xlEdgeBottom).linestyle = Excel.XlLineStyle.xlContinuous
            xl.Cells(file, 13).Resize(1, 4).MergeCells = True
            SUMA = SUMA + row("cerGrupoParValImporte")
            file = file + 1
        Next
        xl.Cells(file, 12) = "TOTAL"
        xl.Cells(file, 12).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells(file, 12).Font.Bold = True
        xl.Cells(file, 11).Resize(1, 2).MergeCells = True
        xl.Cells(file, 13).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        SetCelda(String.Format("M{0}:P{0}", file), SUMA, True, , True, , , , True)
        SetCelda(String.Format("A{0}:P{0}", file + 2), txtObservacion.Text, , , , , , True, True)
        xl.Cells(file, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
        xl.Cells(file + 2, 1).RowHeight = 40

        'Fecha
        Dim fechas As Date = dtpFechaCer.EditValue
        SetCelda("C" & file + 4, "Trujillo" & fechas.Date.ToLongDateString.ToLower.Replace("lunes", "").Replace("martes", "").Replace("miércoles", "").Replace("jueves", "").Replace("viernes", "").Replace("sábado", "").Replace("domingo", ""))
        ' xl.Range("C19").Value = ' String.Format("{0}", dtpFechaCer.DateTime.Day) + "de " + String.Format("{0}", Format(dtpFechaCer.DateTime.Month, "00")) + "de " + String.Format("{0}", dtpFechaCer.DateTime.Year)
    End Sub
#End Region
    Sub SetContorno(ByVal celda As String)
        xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub
    Sub SetCelda(ByVal celda As String, ByVal valor As String, Optional ByVal contorno As Boolean = False, Optional ByVal aliniar As Int16 = 0, Optional ByVal negrita As Boolean = False, Optional ByVal subrayado As Boolean = False, Optional ByVal formato As String = "", Optional ByVal AjustarTexto As Boolean = False, Optional ByVal unir As Boolean = False)
        If unir = True Then
            xl.Cells.Range(celda).Merge()
            ' xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            ' xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            '  xl.Cells.Range(celda).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        End If
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

    Private Sub frmPecosa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboAreaSolicitante.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAreaSolicitante.Properties.DisplayMember = "TgNombre"
        cboAreaSolicitante.Properties.ValueMember = "TgCodigo"
        cboAreaSolicitante.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, "0001")
        cboAreaSolicitante.ItemIndex = -1

        cboActProy.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboActProy.Properties.DisplayMember = "TgNombre"
        cboActProy.Properties.ValueMember = "TgCodigo"
        cboActProy.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(135)
        cboActProy.ItemIndex = -1

        cboFuenteFinanciera.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboFuenteFinanciera.Properties.DisplayMember = "TgNombre"
        cboFuenteFinanciera.Properties.ValueMember = "TgCodigo"
        cboFuenteFinanciera.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(23)
        cboFuenteFinanciera.ItemIndex = -1

        cboMeta.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboMeta.Properties.DisplayMember = "TgNombre"
        cboMeta.Properties.ValueMember = "TgCodigo"
        cboMeta.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(136)
        cboMeta.ItemIndex = -1


        cboAnioCriterio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAnioCriterio.Properties.DisplayMember = "TgNombre"
        cboAnioCriterio.Properties.ValueMember = "TgCodigo"
        cboAnioCriterio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(76)
        cboAnioCriterio.EditValue = CStr(Date.Now.Year)


        txtPartida.Properties.ReadOnly = True

        ConstruirTableListado()
        dgvResultados.DataSource = dtListado

        ConstruirTableDetalleCerGrupoPartidas()
        dgvDetalleCerGrupoPartida.DataSource = dtDetalleCerGrupoPartida

        PuedeBuscar = True
        PuedeCrear = True
        PuedeEditar = True
        PuedeImprimir = True
        PuedeEliminar = True
    End Sub

    Private Sub dgvResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvResultados.Click
        Me.seleccionarListado()
    End Sub

    Private Sub btnConsultarPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarPartida.Click
        Dim frm As frmConsultarPartida = New frmConsultarPartida()
        If frm.ShowDialog Then
            'If frm.PartPIM <> 0 Then
            txtPartida.Tag = frm.PartId
            txtCerAnio.Tag = frm.PartAño
            txtPartida.Text = frm.PartNombre
            'txtPartida.Text = String.Format("{0} - {1}", frm.PartId, frm.PartNombre)
            'Else
            '    SaimtMessageBox.mostrarAlertaAdvertencia("La Partida Seleccionada no Tiene Monto PIM Asignado")
            'End If
        End If
    End Sub

    Private Sub btnAddPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPartida.Click
        If txtCerAnio.Tag Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("No esta definido un año")
            Return
        End If
        If txtPartida.Text Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("Seleccione una partida")
            txtPartida.Focus()
            Return
        End If
        If txtPartida.Tag Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("Seleccione una partida")
            Exit Sub
        End If

        If IsNumeric(txtImporte.EditValue) = True Then
            If CDbl(txtImporte.EditValue) < 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor correcto en el Valor Importe")
                Exit Sub
            End If
        Else
            txtImporte.EditValue = 0
        End If

        For Each rowDetCerGrupoPartida As DataRow In dtDetalleCerGrupoPartida.Rows
            If rowDetCerGrupoPartida("partId") = txtPartida.Tag Then
                If rowDetCerGrupoPartida("partAño") = txtCerAnio.Tag Then
                    SaimtMessageBox.mostrarAlertaInformativa("Ya se encuentra agregado la partida")
                    Exit Sub
                End If
            End If
        Next

        dtDetalleCerGrupoPartida.LoadDataRow(New Object() {0,
                                                                txtPartida.Tag, _
                                                                txtPartida.Text, _
                                                                txtCerAnio.Tag, _
                                                                Format(CDbl(txtImporte.Text), "##,##0.00")
                                                                }, True)
        monTotCert = monTotCert + CDec(txtImporte.Text)
        Me.txtImporteTotal.Text = monTotCert
    End Sub

    Private Sub btnEliminarPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPartida.Click
        If Me.gvDetalleCerGrupoPartida.DataRowCount <> 0 Then
            If dtDetalleCerGrupoPartida.Rows(Me.gvDetalleCerGrupoPartida.GetSelectedRows(0))("cerGrupoParId").ToString() > 0 Then
                If ListaTemporal_CertificacionGrupoPartidaElimandos Is Nothing Then
                    ListaTemporal_CertificacionGrupoPartidaElimandos = New List(Of String)
                End If
                Dim ordDetId As String = dtDetalleCerGrupoPartida.Rows(Me.gvDetalleCerGrupoPartida.GetSelectedRows(0))("cerGrupoParId").ToString
                ListaTemporal_CertificacionGrupoPartidaElimandos.Add(ordDetId)
            End If
            If ListaTemporal_CertificacionGrupoPartidaElimandos IsNot Nothing Then
                If ListaTemporal_CertificacionGrupoPartidaNuevo.Count > 0 Then
                    Dim liIndiceNuevoModificar As Int16 = 0
                    Dim liFila As Int16 = -1
                    For Each fTablaGeneral As DataRow In dtDetalleCerGrupoPartida.Rows
                        If String.IsNullOrEmpty(fTablaGeneral("cerGrupoParId")) And Me.gvDetalleCerGrupoPartida.FocusedRowHandle = liFila Then
                            liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                        End If
                        liFila = liFila + 1
                    Next
                    ListaTemporal_CertificacionGrupoPartidaNuevo.RemoveAt(liIndiceNuevoModificar)
                End If
            End If
            If monTotCert > 0 Then
                monTotCert = monTotCert - CDec(Me.gvDetalleCerGrupoPartida.GetFocusedRowCellValue("cerGrupoParValImporte"))
            Else
                monTotCert = 0
            End If
            Me.txtImporteTotal.Text = monTotCert
            dtDetalleCerGrupoPartida.Rows.RemoveAt(Me.gvDetalleCerGrupoPartida.GetSelectedRows(0))

            If dtDetalleCerGrupoPartida.Rows.Count > 0 Then
                btnEliminarPartida.Enabled = True
            Else
                btnEliminarPartida.Enabled = False
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub


    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub txtCerNro_LostFocus(sender As Object, e As System.EventArgs) Handles txtCerNro.LostFocus
        Dim s As String = "000" & txtCerNro.Text.Trim
        txtCerNro.Text = s.Substring(Len(s) - 3)
    End Sub


End Class
