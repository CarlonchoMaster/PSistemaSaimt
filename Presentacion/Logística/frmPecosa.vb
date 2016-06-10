﻿Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports DevExpress.XtraEditors.Repository

Public Class frmPecosa
    Inherits frmMantenimientos

    Dim xl As Excel.Application
    Dim dt_detalleArticulos As DataTable = New DataTable("detArt")
    Public dt_detalleOrdenCompra As DataTable = New DataTable("detOrdComp")
    Dim dtArticulos As DataTable = New DataTable
    Dim recDs As New DataSet
    Dim dtListado As DataTable = New DataTable()
    Private ListaTemporal_PecosaDetNuevo As List(Of EEPecosa.EEPecosaDet) = New List(Of EEPecosa.EEPecosaDet)
    Private ListaTemporal_PecosaDetElimandos As List(Of String) = New List(Of String)
    Private ListaTemporal_PecosaOCDetNuevo As List(Of EEPecosa.EEPecosaOCDet) = New List(Of EEPecosa.EEPecosaOCDet)
    Private ListaTemporal_PecosaOCDetElimandos As List(Of String) = New List(Of String)
    Dim OrdenCompra As EEOrdenCompra = Nothing
    Dim ruta As String = String.Empty
#Region "Construir Table"
    Private Sub ConstruirTableDetalleArticulos()
        dt_detalleArticulos.Columns.Add("pecDetId", GetType(String))
        dt_detalleArticulos.Columns.Add("artId", GetType(String))
        dt_detalleArticulos.Columns.Add("artNombre", GetType(String))
        dt_detalleArticulos.Columns.Add("artDescripcion", GetType(String))
        dt_detalleArticulos.Columns.Add("tgUMId", GetType(String))
        dt_detalleArticulos.Columns.Add("tgUM", GetType(String))
        dt_detalleArticulos.Columns.Add("pecDetCanTotal", GetType(Decimal))
        dt_detalleArticulos.Columns.Add("pecDetImpTotal", GetType(Decimal))
        dt_detalleArticulos.Columns.Add("pecDetPrecio", GetType(Decimal))
        dt_detalleArticulos.Columns.Add("ordId", GetType(String))
        dt_detalleArticulos.Columns.Add("ordDetId", GetType(Integer))
        dt_detalleArticulos.Columns.Add("NroOC", GetType(String))
        dt_detalleArticulos.Columns.Add("guardado", GetType(Boolean))

    End Sub

    Private Sub ConstruirTableOrdenCompraDetalleArticulos()
        dt_detalleOrdenCompra.Columns.Add("pecOrdComDetId", GetType(String))
        dt_detalleOrdenCompra.Columns.Add("pecDetId", GetType(String))
        dt_detalleOrdenCompra.Columns.Add("artId", GetType(String))
        dt_detalleOrdenCompra.Columns.Add("canOrdComDet", GetType(String))
        dt_detalleOrdenCompra.Columns.Add("ordId", GetType(String))
        dt_detalleOrdenCompra.Columns.Add("precOrdComDet", GetType(Decimal))

    End Sub
    Private Sub contruirTablaListaArticulos()
        dtArticulos.Columns.Add("artId", GetType(String))
        dtArticulos.Columns.Add("artDescripcion", GetType(String))
        dtArticulos.Columns.Add("ordDetDescripcion", GetType(String))
        dtArticulos.Columns.Add("ordId", GetType(String))
        dtArticulos.Columns.Add("ordDetId", GetType(Integer))
        dtArticulos.Columns.Add("ordDetCantidad", GetType(Decimal))
        dtArticulos.Columns.Add("umId", GetType(String))
        dtArticulos.Columns.Add("tgUm", GetType(String))
    End Sub
    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("pecId", GetType(String))
        dtListado.Columns.Add("pecNro", GetType(String))
        dtListado.Columns.Add("tgAreaDes", GetType(String))
        dtListado.Columns.Add("pecFecha", GetType(Date))
    End Sub


#End Region

#Region "Funciones Sobrescritas"

    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvResultados.DataRowCount <> 0 Then
                Dim ListaPecosaOCDet As List(Of EEPecosa.EEPecosaOCDet) = Nothing
                Dim lstPecosa As EEPecosa = Nothing
                GIndiceSeleccionado = Me.gvResultados.GetSelectedRows(0)
                lstPecosa = MantenimientosBL.Instancia.PecosaMostrarPecosaXPecId(gvResultados.GetRowCellValue(GIndiceSeleccionado, "pecId").ToString())

                If lstPecosa IsNot Nothing Then
                    txtPecosaId.Text = lstPecosa.PecId
                    txtPecNro.Text = lstPecosa.PecNro
                    cboAreaDestino.EditValue = lstPecosa.TgAreaDesId
                    dtpFechaPec.EditValue = lstPecosa.PecFecha
                    txtpersona.Text = lstPecosa.PerSolicita
                    txtpersona.Tag = lstPecosa.PerSolicitaId
                    meeObservacion.Text = lstPecosa.PecObservacion
                    txtCuentaDebe.Tag = lstPecosa.TgCuentaDebeId
                    txtCuentaDebe.EditValue = lstPecosa.PlanCDDescripcion
                    txtMontoDebe.Text = lstPecosa.TgCuentaDebe
                    txtCuentaHaber.Tag = lstPecosa.TgCuentaHaberId
                    txtCuentaHaber.EditValue = lstPecosa.PlanCHDescripcion
                    txtMontoHaber.Text = lstPecosa.TgCuentaHaber
                    cboActProy.EditValue = lstPecosa.TgActProyId
                    cboMeta.EditValue = lstPecosa.TgMetaId
                    chbAnulado.Checked = lstPecosa.pecAnulado
                    recDs.Clear()
                    ListaTemporal_PecosaDetNuevo.Clear()
                    ListaTemporal_PecosaDetElimandos.Clear()
                    txtMontoTotal.Text = 0
                    dt_detalleArticulos.Rows.Clear()
                    Dim igv As Decimal = MantenimientosBL.Instancia.parametroMostrarXClsId(42)
                    Dim PecosaDet As List(Of EEPecosa.EEPecosaDet) = MantenimientosBL.Instancia.PecosaDetXPecId(txtPecosaId.Text)
                    If PecosaDet IsNot Nothing Then
                        For Each frow As EEPecosa.EEPecosaDet In PecosaDet
                            dt_detalleArticulos.LoadDataRow(New Object() {frow.PecDetId, _
                                                                         frow.OArticulo.ArtId, _
                                                                         frow.OArticulo.ArtDescripcion, _
                                                                         frow.PecDetDescripcion, _
                                                                         frow.TgUmId, _
                                                                         frow.TgUm, _
                                                                         frow.PecDetCanTotal, _
                                                                         frow.PecDetImpTotal, _
                                                                         frow.PecDetPrecio, _
                                                                         frow.OrdId, _
                                                                         frow.OrdDetId, _
                                                                          frow.OCNro, True}, True)
                            txtMontoTotal.EditValue = CDec(txtMontoTotal.EditValue) + CDec(frow.PecDetImpTotal)
                        Next
                    End If
                End If
                dgvDetalleArticulos.DataSource = dt_detalleArticulos
                Me.gvDetalleArticulos.BestFitColumns()
                pcDescripcion.Width = 200
                GIdRegistroActual = txtPecosaId.Text
                txtaño.Text = Year(Now)
            End If
            MyBase.seleccionarListado()
            btnImprimir.Enabled = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        recDs.Clear()
        txtPecosaId.EditValue = MantenimientosBL.Instancia.PecosaGeneraCodigo
        txtPecosaId.Properties.ReadOnly = True
        txtPecNro.EditValue = MantenimientosBL.Instancia.PecosaGeneraCodigoSAIMT
        txtPecNro.Properties.ReadOnly = True
        txtNroOrd.Properties.ReadOnly = True
        cboAreaDestino.EditValue = "1"
        txtpersona.Properties.ReadOnly = True
        cboBuscarArea.Properties.ReadOnly = True
        txtCuentaDebe.Properties.ReadOnly = True
        txtCuentaHaber.Properties.ReadOnly = True
        txtMontoTotal.Properties.ReadOnly = True
        txtMontoTotal.Text = 0
        txtMontoDebe.Text = 0
        txtMontoHaber.Text = 0
        txtaño.Text = Year(Now)
        btnImprimir.Enabled = False
        txtNroOrd.Properties.ReadOnly = False
        cboUnidadMed.ItemIndex = 0
        chbAnulado.Checked = False
        dt_detalleArticulos.Rows.Clear()
        dtArticulos.Rows.Clear()
        dtListado.Rows.Clear()

    End Sub

    Protected Overrides Sub guardar()
        Try
            If String.IsNullOrEmpty(dtpFechaPec.EditValue) Then
                dtpFechaPec.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Selecciones la Fecha de la Pecosa")
                Return
            End If
            If String.IsNullOrEmpty(cboAreaDestino.Text) Then
                cboAreaDestino.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Area de Destino")
                Return
            End If
            If String.IsNullOrEmpty(txtpersona.Tag) Then
                txtpersona.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un solicitante valido")
                Return
            End If

            If dt_detalleArticulos.Rows.Count <= 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("La lista de articulos a entregar no puede estar vacia")
                Exit Sub
            End If

            Dim loPecosa As EEPecosa = New EEPecosa()
            'datos orden compra
            loPecosa.PecId = txtPecosaId.Text
            loPecosa.PecNro = txtPecNro.Text
            'Datos Pecosa
            loPecosa.PecFecha = dtpFechaPec.EditValue
            loPecosa.TgActProyId = cboActProy.EditValue
            loPecosa.TgMetaId = cboMeta.EditValue
            loPecosa.PerSolicitaId = txtpersona.Tag
            loPecosa.PecObservacion = meeObservacion.EditValue
            Dim loCargos As List(Of EECargoPersonal) = MantenimientosBL.Instancia.CargoListarXPerId_pa(loPecosa.PerSolicitaId)
            Dim carPerId As String = String.Empty
            If loCargos IsNot Nothing Then
                carPerId = MantenimientosBL.Instancia.CargoListarXPerId_pa(loPecosa.PerSolicitaId).Item(0).CarPerId
            Else
                SaimtMessageBox.mostrarAlertaInformativa("La Persona " & txtpersona.Text & " No tiene cargo, comunique al área encargada")
                Return
            End If
            loPecosa.PecCarPerId = "0001" & cboAreaDestino.EditValue & carPerId
            ' Proceso patrimonial
            loPecosa.TgCuentaDebeId = txtCuentaDebe.Tag
            loPecosa.TgCuentaDebe = CDec(txtMontoDebe.EditValue)
            loPecosa.TgCuentaHaberId = txtCuentaHaber.Tag
            loPecosa.TgCuentaHaber = CDec(txtMontoHaber.EditValue)
            loPecosa.pecAnulado = chbAnulado.Checked
            'Grid pricipal
            ListaTemporal_PecosaDetNuevo.Clear()
            Dim loPecosaDet As EEPecosa.EEPecosaDet
            loPecosa.ListaPecosaDet = New List(Of EEPecosa.EEPecosaDet)
            Dim loPecosaOCDet As EEPecosa.EEPecosaOCDet = Nothing
            For Each frowDet As DataRow In dt_detalleArticulos.Rows
                If Not CBool(frowDet("guardado")) Then
                    loPecosaDet = New EEPecosa.EEPecosaDet
                    loPecosaDet.PecDetId = frowDet("pecDetId")
                    loPecosaDet.ArtId = frowDet("artId")
                    loPecosaDet.PecDetCanTotal = CDec(frowDet("pecDetCanTotal"))
                    loPecosaDet.PecId = txtPecosaId.Text.Trim
                    loPecosaDet.PecDetImpTotal = CDec(frowDet("pecDetImpTotal"))
                    loPecosaDet.TgUmId = frowDet("tgUmId")
                    loPecosaDet.PecDetDescripcion = frowDet("artDescripcion")
                    loPecosaDet.OrdId = frowDet("ordId")
                    loPecosaDet.OrdDetId = frowDet("ordDetId")
                    loPecosaDet.PecDetPrecio = CDec(frowDet("pecDetPrecio"))
                    ListaTemporal_PecosaDetNuevo.Add(loPecosaDet)
                End If
            Next
            loPecosa.ListaPecosaDet = ListaTemporal_PecosaDetNuevo
            If GEstadoNuevo Then
                MantenimientosBL.Instancia.PecosaGuardar(loPecosa)
            Else
                loPecosa.Lista_PecosaDetElimnados = ListaTemporal_PecosaDetElimandos
                MantenimientosBL.Instancia.PecosaActualizar(loPecosa)
            End If
            ListaTemporal_PecosaDetNuevo.Clear()
            ListaTemporal_PecosaDetElimandos.Clear()
            ListaTemporal_PecosaOCDetNuevo.Clear()
            ListaTemporal_PecosaOCDetElimandos.Clear()
            recDs.Clear()
            enabledGA = False
            MyBase.guardar()

            btnImprimir.Enabled = False
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterio.SelectedIndex
            If GCriterioBuscado = 2 Then
                GValorTextoBuscado = cboBuscarArea.EditValue
            End If
            Dim loPecosa As List(Of EEPecosa) = MantenimientosBL.Instancia.PecosaListarBCriterio(GCriterioBuscado, GValorTextoBuscado, cboAnioCriterio.EditValue)
            dtArticulos.Rows.Clear()
            dt_detalleArticulos.Rows.Clear()
            dtListado.Rows.Clear()
            recDs.Clear()
            If loPecosa IsNot Nothing Then
                For Each frow As EEPecosa In loPecosa
                    dtListado.LoadDataRow(New Object() {frow.PecId, frow.PecNro, frow.TgAreaDes, frow.PecFecha}, True)
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
            xl.Workbooks.Open(EEComun.RutaReportes & "\RptPecosa2013.xls", 1, True, 4)
            ExportarOrdenCompra()
            If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ruta = String.Format("{0}\PecosaNro_{1}", fbdExportar.SelectedPath, txtPecNro.Text.Trim & "_" & Year(Now))
                xl.ActiveWorkbook.SaveAs(ruta)
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre PecosaNro_" & txtPecNro.Text.Trim & "_" & Year(Now)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
        MyBase.imprimir()
    End Sub
#End Region

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

        'xl.Cells.Range("K" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("K" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("K" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("K" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        'xl.Cells.Range("L" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("L" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("L" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("L" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        'xl.Cells.Range("M" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("M" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("M" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("M" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        'xl.Cells.Range("N" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("N" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("N" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("N" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        'xl.Cells.Range("O" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("O" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("O" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("O" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        'xl.Cells.Range("P" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("P" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("P" & fila).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        'xl.Cells.Range("P" & fila).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

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

    Private Sub ExportarOrdenCompra()
        xl.Sheets(xl.Worksheets("SalidaArticuloAlmacen").Index).Select()
        xl.Range("I1").Value = txtPecNro.EditValue
        xl.Range("D4").Value = txtpersona.Text
        xl.Range("D5").Value = cboAreaDestino.Text
        xl.Range("G4").Value = "'" & String.Format("{0}/{1}/{2}", dtpFechaPec.DateTime.Day, Format(dtpFechaPec.DateTime.Month, "00"), dtpFechaPec.DateTime.Year)
        xl.Range("G5").Value = cboAreaDestino.EditValue

        If cboActProy.EditValue <> "" Then
            xl.Range("I4").Value = cboActProy.EditValue
        Else
            xl.Range("I4").Value = "-"
        End If

        If cboMeta.EditValue <> "" Then
            xl.Range("I5").Value = cboMeta.EditValue
        Else
            xl.Range("I5").Value = "-"
        End If

        Dim FilaItem As String = "A9"
        Dim FilaCantidad As String = "B9"
        Dim FilaUMedida As String = "C9"
        Dim FilaProducto As String = "D9"
        Dim FilaCodProducto As String = "E9"
        Dim FilaPrecioUnitario As String = "F9"
        Dim FilaTotalXProducto As String = "G9"
        Dim FilaNroOrdenCompra As String = "J9"
        'Calculos de los resumenes
        Dim FilaTextoTotal As String = "I10"
        Dim FilaTotal As String = "J10"
        Dim FilaCDebe As String = "K19"
        Dim FilaCHaber As String = "L19"
        Dim FilaTexto As String = "G12"
        Dim FilaTexto2 As String = "G13"
        Dim FilaFechaRecep As String = "L13"
        Dim FilaSolicitante As String = "B17"
        Dim FilaLogistica As String = "E17"
        Dim FilaAlmacen As String = "I17"
        Dim fila As Integer = 9
        Dim ContItems As Integer = 0
        Dim total As Decimal
        Dim i As Integer = 12

        For Each fTablaDetalleArticulos As DataRow In dt_detalleArticulos.Rows

            '  For Each fTablaDetalleOrdenCompra As DataRow In dt_detalleOrdenCompra.Rows

            ContItems = ContItems + 1
            FilaItem = "A" & fila
            xl.Range(FilaItem).Value = ContItems
            xl.Range(FilaItem).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells.Range(FilaItem).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaItem).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaItem).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaItem).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

            FilaCantidad = "B" & fila
            xl.Range(FilaCantidad).Value = CInt(fTablaDetalleArticulos("pecDetCanTotal"))
            xl.Range(FilaCantidad).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells.Range(FilaCantidad).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaCantidad).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaCantidad).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaCantidad).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

            FilaUMedida = "C" & fila
            xl.Range(FilaUMedida).Value = fTablaDetalleArticulos("tgUM")
            xl.Range(FilaUMedida).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells.Range(FilaUMedida).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaUMedida).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaUMedida).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaUMedida).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

            FilaProducto = "D" & fila
            xl.Range(FilaProducto).Value = fTablaDetalleArticulos("artDescripcion")
            xl.Cells.Range(FilaProducto).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaProducto).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaProducto).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaProducto).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Range(FilaProducto).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'xl.Cells.Range(String.Format("{0}:G{1}", FilaProducto, fila)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            'xl.Cells.Range(String.Format("{0}:G{1}", FilaProducto, fila)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            'xl.Cells.Range(String.Format("{0}:G{1}", FilaProducto, fila)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            'xl.Cells.Range(String.Format("{0}:G{1}", FilaProducto, fila)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            ' xl.Range(String.Format("{0}:G{1}", FilaProducto, fila)).Resize(1, 4).MergeCells = True
            FilaCodProducto = "E" & fila
            xl.Range(FilaCodProducto).Value = fTablaDetalleArticulos("artId")
            xl.Range(FilaCodProducto).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells.Range(FilaCodProducto).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaCodProducto).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaCodProducto).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaCodProducto).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

            FilaProducto = "D" & fila
            xl.Range(FilaProducto).Value = fTablaDetalleArticulos("artNombre") & " - " & fTablaDetalleArticulos("artDescripcion")
            xl.Range(FilaProducto).Font.Size = 10
            xl.Cells.Range(FilaProducto).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaProducto).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaProducto).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaProducto).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Range(FilaProducto).WrapText = True
            xl.Range(FilaProducto).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            'FilaTotalXProducto = "G" & fila
            'total = total + fTablaDetalleArticulos("pecDetImpTotal")
            'xl.Range(FilaTotalXProducto).Value = fTablaDetalleArticulos("pecDetImpTotal") 'fTablaDetalleOrdenCompra("canOrdComDet") * fTablaDetalleOrdenCompra("precOrdComDet")
            'xl.Cells.Range(FilaTotalXProducto).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            'xl.Cells.Range(FilaTotalXProducto).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            'xl.Cells.Range(FilaTotalXProducto).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            'xl.Cells.Range(FilaTotalXProducto).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous



            FilaCodProducto = "E" & fila
            xl.Range(FilaCodProducto).Value = fTablaDetalleArticulos("artId")
            xl.Range(FilaCodProducto).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells.Range(FilaCodProducto).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaCodProducto).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaCodProducto).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaCodProducto).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous


            FilaPrecioUnitario = "F" & fila
            xl.Range(FilaPrecioUnitario).Value = CDec(fTablaDetalleArticulos("pecDetPrecio"))
            xl.Cells.Range(FilaPrecioUnitario).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaPrecioUnitario).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaPrecioUnitario).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaPrecioUnitario).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous


            FilaTotalXProducto = "G" & fila
            total = total + CDec(fTablaDetalleArticulos("pecDetImpTotal"))
            xl.Range(FilaTotalXProducto).Value = CDec(fTablaDetalleArticulos("pecDetImpTotal"))
            xl.Cells.Range(FilaTotalXProducto).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaTotalXProducto).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaTotalXProducto).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaTotalXProducto).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous


            If txtCuentaDebe.Tag <> "" Then
                FilaCDebe = "H" & fila
                xl.Range(FilaCDebe).Value = txtCuentaDebe.Tag.ToString.Substring(4)
                xl.Range(FilaCDebe).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Cells.Range(FilaCDebe).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCDebe).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCDebe).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCDebe).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            Else
                FilaCDebe = "H" & fila
                xl.Range(FilaCDebe).Value = "-"
                xl.Range(FilaCDebe).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Cells.Range(FilaCDebe).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCDebe).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCDebe).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCDebe).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            End If

            If txtCuentaHaber.Tag <> "" Then
                FilaCHaber = "I" & fila
                xl.Range(FilaCHaber).Value = txtCuentaHaber.Tag.ToString.Substring(4)
                xl.Range(FilaCHaber).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Cells.Range(FilaCHaber).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCHaber).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCHaber).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCHaber).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            Else
                FilaCHaber = "I" & fila
                xl.Range(FilaCHaber).Value = "-"
                xl.Range(FilaCHaber).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xl.Cells.Range(FilaCHaber).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCHaber).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCHaber).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                xl.Cells.Range(FilaCHaber).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            End If

            FilaNroOrdenCompra = "J" & fila
            OrdenCompra = MantenimientosBL.Instancia.ordenCompraListarxOrdId(fTablaDetalleArticulos("ordId").ToString)
            xl.Range(FilaNroOrdenCompra).Value = OrdenCompra.OrdNro & " - " & Year(OrdenCompra.OrdFechaDoc)
            xl.Range(FilaNroOrdenCompra).Font.Size = 9
            xl.Range(FilaNroOrdenCompra).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Cells.Range(FilaNroOrdenCompra).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaNroOrdenCompra).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaNroOrdenCompra).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            xl.Cells.Range(FilaNroOrdenCompra).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            fila = fila + 1
            i = i + 1

        Next
        FilaTextoTotal = "F" & fila
        xl.Range(FilaTextoTotal).Value = "TOTAL S/."
        xl.Range(FilaTextoTotal).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        xl.Range(FilaTextoTotal).Characters.Font.Bold = True

        FilaTotal = "G" & fila
        xl.Range(FilaTotal).Value = total
        xl.Cells.Range(FilaTotal).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(FilaTotal).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(FilaTotal).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(FilaTotal).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        fila = fila + 2
        FilaTexto = "D" & fila
        xl.Range(FilaTexto).Value = "Formulario utilizado hasta el renglón"
        xl.Range(FilaTexto).Characters.Font.Size = 8
        xl.Range(FilaTexto).Font.Underline = True
        'xl.Range(String.Format("{0}:G{1}", FilaTexto, fila)).Resize(1, 4).MergeCells = True
        xl.Range(FilaTexto).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells.Range(FilaTexto).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(FilaTexto).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(FilaTexto).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

        fila = fila + 1
        FilaTexto2 = "D" & fila
        xl.Range(FilaTexto2).Value = "N° " & ContItems & " LINEAS USADAS (Inclusive)"
        xl.Range(FilaTexto2).Characters.Font.Size = 11
        'xl.Range(String.Format("{0}:G{1}", FilaTexto2, fila)).Resize(1, 4).MergeCells = True
        xl.Range(FilaTexto2).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        xl.Cells.Range(FilaTexto2).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(FilaTexto2).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range(FilaTexto2).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

        FilaFechaRecep = "I" & fila
        xl.Range(FilaFechaRecep).Value = "Fecha de Recepción"
        xl.Range(FilaFechaRecep).Characters.Font.Size = 11
        xl.Range(String.Format("{0}:J{1}", FilaFechaRecep, fila)).Resize(1, 2).MergeCells = True
        xl.Range(FilaFechaRecep).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Cells.Range(String.Format("{0}:J{1}", FilaFechaRecep, fila)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous

        fila = fila + 6
        FilaSolicitante = "B" & fila
        xl.Range(FilaSolicitante).Value = "SOLICITANTE"
        xl.Range(FilaSolicitante).Characters.Font.Size = 11
        xl.Range(FilaSolicitante).Characters.Font.Bold = True
        xl.Range(String.Format("{0}:C{1}", FilaSolicitante, fila)).Resize(1, 2).MergeCells = True
        xl.Range(FilaSolicitante).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'xl.Cells.Range(String.Format("{0}:C{1}", FilaSolicitante, fila)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous

        FilaLogistica = "D" & fila
        xl.Range(FilaLogistica).Value = "JEFE DE LOGISTICA"
        xl.Range(FilaLogistica).Characters.Font.Size = 11
        xl.Range(FilaLogistica).Characters.Font.Bold = True
        xl.Range(FilaLogistica).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight


        FilaAlmacen = "I" & fila
        xl.Range(FilaAlmacen).Value = "JEFE DE ALMACEN"
        xl.Range(FilaAlmacen).Characters.Font.Size = 11
        xl.Range(FilaAlmacen).Characters.Font.Bold = True
        xl.Range(String.Format("{0}:J{1}", FilaAlmacen, fila)).Resize(1, 2).MergeCells = True
        xl.Range(FilaAlmacen).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'xl.Cells.Range(String.Format("{0}:J{1}", FilaAlmacen, fila)).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
    End Sub

#End Region

    Private Sub btnConsultarOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarOC.Click
        If txtNroOrd.Text.Length <> 0 Then
            If CShort(txtaño.Text.Trim) > 1970 Then
                Dim listaOrdCompraDet As List(Of EEOrdenCompra.EEOrdenCompraDet) = Nothing
                listaOrdCompraDet = MantenimientosBL.Instancia.mostrarOrdenCompDetXOrdNro_Anio(StrDup(6 - Len(txtNroOrd.Text.Trim), "0") & txtNroOrd.Text.Trim, txtaño.Text.Trim)
                If listaOrdCompraDet IsNot Nothing Then
                    dtArticulos.Rows.Clear()
                    For Each loArticulosDet As EEOrdenCompra.EEOrdenCompraDet In listaOrdCompraDet
                        dtArticulos.LoadDataRow(New Object() {loArticulosDet.OArticulo.ArtId, _
                                                                         loArticulosDet.OArticulo.ArtDescripcion, _
                                                                      loArticulosDet.OrdDetDescripcion, _
                                                                         loArticulosDet.OrdId, _
                                                                       loArticulosDet.OrdDetId, _
                                                                        loArticulosDet.OrdDetCantidad, _
                                                                      loArticulosDet.TgUmId, _
                                                                     loArticulosDet.TgUm}, True)
                    Next
                    cmbArticulos.Properties.DataSource = dtArticulos
                    cmbArticulos.Properties.ValueMember = "ordDetId"
                    cmbArticulos.Properties.DisplayMember = "artDescripcion"
                    cmbArticulos.ItemIndex = 0
                    txtNroOrd.Tag = cmbArticulos.GetColumnValue("ordId").ToString
                Else
                    SaimtMessageBox.mostrarAlertaAdvertencia("No hay detalle de compra para esa Orden de Compra")
                End If
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("Falta ingresar el año para consultar las ordenes de compra")
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Falta ingresar el Nro. Orden de Compra para consultar")
        End If

    End Sub

    Private Sub frmPecosa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True

        cboAreaDestino.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAreaDestino.Properties.DisplayMember = "TgNombre"
        cboAreaDestino.Properties.ValueMember = "TgCodigo"
        cboAreaDestino.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, "0001")
        cboAreaDestino.ItemIndex = -1

        cboActProy.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboActProy.Properties.DisplayMember = "TgNombre"
        cboActProy.Properties.ValueMember = "TgCodigo"
        cboActProy.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(135)
        cboActProy.ItemIndex = -1

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

        cboBuscarArea.Properties.ReadOnly = True

        ConstruirTableDetalleArticulos()
        dgvDetalleArticulos.DataSource = dt_detalleArticulos

        ConstruirTableListado()
        dgvResultados.DataSource = dtListado

        ConstruirTableOrdenCompraDetalleArticulos()
        contruirTablaListaArticulos()
        'recDs.Tables.Add(dt_detalleArticulos)
        'recDs.Tables.Add(dt_detalleOrdenCompra)
        'Dim colmaestro() As DataColumn = {recDs.Tables("detArt").Columns("artId")}
        'Dim coldetalle() As DataColumn = {recDs.Tables("detOrdComp").Columns("artId")}
        'recDs.Relations.Add("DetallaOrdenCompra", colmaestro, coldetalle)
        cboUnidadMed.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboUnidadMed.Properties.DisplayMember = "TgNombre"
        cboUnidadMed.Properties.ValueMember = "TgCodigo"
        cboUnidadMed.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(105)
        cboUnidadMed.ItemIndex = 0
        ListaTemporal_PecosaDetNuevo.Clear()
        ListaTemporal_PecosaDetElimandos.Clear()

    End Sub

    Private Sub SaimtButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCuentaDebe.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta()
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaDebe.Tag = fmConsulta.PlanCIdCompuesto
                txtCuentaDebe.Text = String.Format("{0} - {1}", txtCuentaDebe.Tag.ToString.Substring(4), fmConsulta.PlanCDescripcion)
            End If
        End Using
    End Sub

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCuentaHaber.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta()
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaHaber.Tag = fmConsulta.PlanCIdCompuesto
                txtCuentaHaber.Text = String.Format("{0} - {1}", txtCuentaHaber.Tag.ToString.Substring(4), fmConsulta.PlanCDescripcion)
            End If
        End Using
    End Sub

    Private Sub dgvResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvResultados.Click
        Me.seleccionarListado()
    End Sub

    Sub Cargar_CargoDest(ByVal carPerID As String)
        Dim lPersona As List(Of EEPersona)
        lPersona = MantenimientosBL.Instancia.personaListarXCargoId(carPerID)
       
    End Sub

    Private Sub cboAreaDestino_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAreaDestino.EditValueChanged
        If cboAreaDestino.EditValue IsNot Nothing Then
           
        End If
    End Sub

    Private Sub cboCargoDestino_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub lstTrabajadores_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub cboCriterio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriterio.SelectedIndexChanged
        If cboCriterio.SelectedIndex = 2 Then
            cboBuscarArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboBuscarArea.Properties.DisplayMember = "TgNombre"
            cboBuscarArea.Properties.ValueMember = "TgCodigo"
            cboBuscarArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, "0001")
            cboBuscarArea.ItemIndex = 0
            cboBuscarArea.Properties.ReadOnly = False
            txtBuscarPor.Properties.ReadOnly = True
        Else
            cboBuscarArea.Properties.ReadOnly = True
            txtBuscarPor.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub cboBuscarArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuscarArea.EditValueChanged
        If cboCriterio.SelectedIndex = 2 Then
            Buscar()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub txtimporte_GotFocus(sender As Object, e As System.EventArgs) Handles txtimporte.GotFocus
        txtimporte.Text = CDec(txtpreciounit.Text.Trim) * CDec(txtcantidad.Text.Trim)
    End Sub

   
  
    Private Sub cmbArticulos_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbArticulos.EditValueChanged
        lblmensaje.Text = "Se compro " & cmbArticulos.GetColumnValue("ordDetCantidad").ToString & Space(1) & cmbArticulos.GetColumnValue("tgUm").ToString
        txtDescripcion.Text = cmbArticulos.GetColumnValue("ordDetDescripcion").ToString
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If Len(txtNroOrd.Tag.ToString) = 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Tiene que buscar la Orden de Compra para poder agregar")
            Exit Sub
        End If
        If cboUnidadMed.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Debe seleccionar una unidad de medida de la Lista")
            Exit Sub
        End If
        If CDec(txtcantidad.Text.Trim) <= 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("La cantidad tiene que ser mayor a 0")
            Exit Sub
        End If
        If CDec(txtpreciounit.Text.Trim) <= 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("La cantidad tiene que ser mayor a 0")
            Exit Sub
        End If
        If CDec(txtimporte.Text.Trim) <= 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione la caja de texto del importe para que se calcule el mismo")
            Exit Sub
        End If
        Dim fila() As DataRow = dt_detalleArticulos.Select("artDescripcion='" & cmbArticulos.GetColumnValue("ordDetDescripcion").ToString & "' and artNombre='" & cmbArticulos.GetColumnValue("artDescripcion").ToString & "'")
        If fila.Length <= 0 Then
            agregarItemPec()
        Else
            If SaimtMessageBox.mostrarAlertaPreguntaYESNO("No puede agregar un producto que ya ha sido agregado, pero ¿Desea agregarlo de todas maneras?") Then
                agregarItemPec()
            End If
        End If
    End Sub

    Private Sub agregarItemPec()
        Dim loPecosaDet As New EEPecosa.EEPecosaDet
        loPecosaDet.ArtId = cmbArticulos.GetColumnValue("artId")
        loPecosaDet.OArticulo = New EEArticulo
        loPecosaDet.OArticulo.ArtNombre = cmbArticulos.GetColumnValue("artDescripcion")
        loPecosaDet.PecDetCanTotal = CDec(txtcantidad.Text.Trim)
        loPecosaDet.PecId = txtPecosaId.Text.Trim
        loPecosaDet.PecDetImpTotal = CDec(txtimporte.Text.Trim)
        loPecosaDet.TgUmId = cboUnidadMed.EditValue
        loPecosaDet.TgUm = cboUnidadMed.Text.Trim
        loPecosaDet.PecDetDescripcion = txtDescripcion.Text.Trim
        loPecosaDet.OrdId = cmbArticulos.GetColumnValue("ordId").ToString
        loPecosaDet.OrdDetId = cmbArticulos.GetColumnValue("ordDetId").ToString
        loPecosaDet.PecDetPrecio = CDec(txtpreciounit.Text.Trim)
        loPecosaDet.OCNro = txtNroOrd.Text.Trim
        dt_detalleArticulos.LoadDataRow(New Object() {"0", _
                                                      loPecosaDet.ArtId, _
                                                      loPecosaDet.OArticulo.ArtNombre, _
                                                      loPecosaDet.PecDetDescripcion, _
                                                      loPecosaDet.TgUmId, _
                                                      loPecosaDet.TgUm, _
                                                      loPecosaDet.PecDetCanTotal, _
                                                      loPecosaDet.PecDetImpTotal, _
                                                      loPecosaDet.PecDetPrecio, _
                                                      loPecosaDet.OrdId, _
                                                      loPecosaDet.OrdDetId, loPecosaDet.OCNro, False}, True)

        Me.gvDetalleArticulos.BestFitColumns()
        pcDescripcion.Width = 200
        txtMontoTotal.Text = CalcularSuma()
        cmbArticulos.ItemIndex = -1
        txtcantidad.Text = 0
        txtpreciounit.Text = 0
        txtimporte.Text = 0
    End Sub

    Private Sub btnRemover_Click(sender As System.Object, e As System.EventArgs) Handles btnRemover.Click
        If CBool(gvDetalleArticulos.GetFocusedDataRow.Item("guardado")) Then
            ListaTemporal_PecosaDetElimandos.Add(gvDetalleArticulos.GetFocusedDataRow.Item("pecDetId").ToString)
        End If
        dt_detalleArticulos.Rows.Remove(gvDetalleArticulos.GetFocusedDataRow())
        txtMontoTotal.Text = CalcularSuma()
    End Sub

   
    
    Private Sub SaimtButton1_Click_1(sender As System.Object, e As System.EventArgs) Handles SaimtButton1.Click
        Using fmConsultaPersona As frmConsultaPersonaGeneral = New frmConsultaPersonaGeneral(3)
            If fmConsultaPersona.ShowDialog() = DialogResult.OK Then
                txtpersona.Tag = fmConsultaPersona.PerId
                txtpersona.Text = fmConsultaPersona.PerNombre
            End If
        End Using
    End Sub

    Private Function CalcularSuma() As Decimal
        Dim cont As Integer = 0
        Dim sum As Decimal = 0
        For cont = 0 To gvDetalleArticulos.RowCount - 1
            sum = sum + CDec(gvDetalleArticulos.GetRowCellValue(cont, "pecDetImpTotal"))
        Next
        Return sum
    End Function
   

 
    Private Sub btnElimEditor_Click(sender As System.Object, e As System.EventArgs) Handles btnElimEditor.Click
        cboUnidadMed.EditValue = gvDetalleArticulos.GetFocusedRowCellValue("tgUMId")
        txtcantidad.Text = CDec(gvDetalleArticulos.GetFocusedRowCellValue("pecDetCanTotal"))
        txtpreciounit.Text = CDec(gvDetalleArticulos.GetFocusedRowCellValue("pecDetPrecio"))
        txtimporte.Text = CDec(gvDetalleArticulos.GetFocusedRowCellValue("pecDetImpTotal"))
        txtNroOrd.Text = gvDetalleArticulos.GetFocusedRowCellValue("NroOC").ToString
        dtArticulos.Rows.Clear()
        btnConsultarOC.PerformClick()
        txtDescripcion.Text = gvDetalleArticulos.GetFocusedRowCellValue("artDescripcion").ToString
        btnRemover.PerformClick()
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then
            txtpreciounit.Properties.Mask.EditMask = "n4"
            txtimporte.Properties.Mask.EditMask = "n4"
            GridColumn5.DisplayFormat.FormatString = "n4"
            GridColumn23.DisplayFormat.FormatString = "n4"
        Else
            txtpreciounit.Properties.Mask.EditMask = "n2"
            txtimporte.Properties.Mask.EditMask = "n2"
            GridColumn5.DisplayFormat.FormatString = "n2"
            GridColumn23.DisplayFormat.FormatString = "n2"
        End If
    End Sub
End Class
