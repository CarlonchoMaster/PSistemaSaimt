Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports DevExpress.XtraEditors.Repository

Public Class frmOrdenCompra
    Inherits frmMantenimientos
    Dim xl As Excel.Application
    Dim dtDetalleArticulos As DataTable = New DataTable()
    Dim dtDetalleProceso As DataTable = New DataTable()
    Dim dtDocReferencia As DataTable = New DataTable()

    Dim loGrupoPartidas As List(Of EECertificacion.EECertificacionGrupoPartida)

    Dim dtListado As DataTable = New DataTable()
    Private ListaTemporal_OrdenCompraDetNuevo As List(Of EEOrdenCompra.EEOrdenCompraDet) = New List(Of EEOrdenCompra.EEOrdenCompraDet)
    Private ListaTemporal_OrdenCompraDetElimandos As List(Of String) = New List(Of String)
    Dim MontoTotalSinDes As Decimal = 0
    'Dim MontoQuedaCer As Decimal = 0
    'Dim MontoUtilizadoCer As Decimal = 0
    Dim Accion As String
    Dim igv As Decimal
    'Dim total As Decimal
    Dim totalant As Decimal = 0
    'Dim nuevototal As Decimal
    Dim ordDetId As String = String.Empty
    Dim ruta As String

#Region "Construir Table"
    Private Sub ConstruirTableDocRef()
        dtDocReferencia.Columns.Add("documento", GetType(String))
        dtDocReferencia.Columns.Add("anio", GetType(String))
        dtDocReferencia.Columns.Add("saimt", GetType(String))
        dtDocReferencia.Columns.Add("area", GetType(String))

    End Sub

    Private Sub ConstruirTableDetalleProcesoPresupuestario()
        dtDetalleProceso.Columns.Add("cerGrupoParId", GetType(String))
        dtDetalleProceso.Columns.Add("partida", GetType(String))
        dtDetalleProceso.Columns.Add("importe", GetType(Decimal))
    End Sub

    Private Sub ConstruirTableDetalleArticulos()
        dtDetalleArticulos.Columns.Add("ordDetId", GetType(Int32))
        dtDetalleArticulos.Columns.Add("artId", GetType(String))
        dtDetalleArticulos.Columns.Add("artDescripcion", GetType(String))
        dtDetalleArticulos.Columns.Add("ordDetEncabezado", GetType(String))
        dtDetalleArticulos.Columns.Add("ordDetDescripcion", GetType(String))
        dtDetalleArticulos.Columns.Add("tgUMId", GetType(String))
        dtDetalleArticulos.Columns.Add("tgUM", GetType(String))
        dtDetalleArticulos.Columns.Add("ordDetCantidad", GetType(Decimal))
        dtDetalleArticulos.Columns.Add("ordDetPrecio", GetType(Decimal))
        dtDetalleArticulos.Columns.Add("ordDetImporte", GetType(Decimal))
    End Sub

    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("OrdId", GetType(String))
        dtListado.Columns.Add("OrdNro", GetType(String))
        dtListado.Columns.Add("OrdFechaDoc", GetType(Date))
        dtListado.Columns.Add("TgEstado", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Accion = "seleccionar"
        Try
            If Me.gvListadoOrdenCompra.DataRowCount <> 0 Then
                Dim loOrdenCompra As EEOrdenCompra = MantenimientosBL.Instancia.ordenCompraListarxOrdId(gvListadoOrdenCompra.GetRowCellValue(Me.gvListadoOrdenCompra.GetSelectedRows(0), "OrdId").ToString())
                If loOrdenCompra IsNot Nothing Then
                    GIndiceSeleccionado = Me.gvListadoOrdenCompra.GetSelectedRows(0)
                    txtOrdId.Text = loOrdenCompra.OrdId
                    txtNroOrdenCompra.Text = loOrdenCompra.OrdNro
                    dtpFechaDoc.EditValue = loOrdenCompra.OrdFechaDoc
                    cboEstadoOrdenCompra.EditValue = loOrdenCompra.TgEstadoId
                    cboComprobantePago.EditValue = loOrdenCompra.TgCompPagoId
                    txtNroComprobante.Text = loOrdenCompra.OrdNroCompPago
                    txtProveedor.Text = loOrdenCompra.PerProv
                    txtProveedor.Tag = loOrdenCompra.PerProvId

                    Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaConsultarProveedorCriterios(1, txtProveedor.Text)
                    If ListaPersona IsNot Nothing Then
                        txtDireccionProveedor.EditValue = ListaPersona.Item(0).PerDireccion
                        txtNroDocumentoProveedor.EditValue = ListaPersona.Item(0).PerNDoc
                    End If

                    txtReferenciaDoc.Text = loOrdenCompra.OrdRefDoc

                    txtCuentaDebe.Tag = loOrdenCompra.TgCuentaDebeId
                    txtCuentaDebe.EditValue = loOrdenCompra.PlanCDDescripcion
                    txtMontoDebe.Text = loOrdenCompra.TgCuentaDebe
                    txtCuentaHaber.Tag = loOrdenCompra.TgCuentaHaberId
                    txtCuentaHaber.EditValue = loOrdenCompra.PlanCHDescripcion
                    txtMontoHaber.Text = loOrdenCompra.TgCuentaHaber

                    txtCertificacion.Tag = loOrdenCompra.CerId
                    txtCertificacion.Text = loOrdenCompra.CerNro


                    cboFuenteFinanciera.EditValue = loOrdenCompra.TgFFinancieraId
                    cboMeta.EditValue = loOrdenCompra.TgMetaId
                    cboActProy.EditValue = loOrdenCompra.TgActProyId
                    txtImportePresupuesto.Text = loOrdenCompra.OrdImporte

                    txtMontoTotalCer.EditValue = loOrdenCompra.CerValTotal
                    txtMontoQuedaCer.EditValue = loOrdenCompra.CerValQuedan
                    txtMontoQuedaCer.Tag = loOrdenCompra.CerValQuedan
                    txtDescuento.EditValue = loOrdenCompra.OrdDescuento

                    txtSubTotal.EditValue = loOrdenCompra.OrdSubTotal
                    txtIgv.EditValue = loOrdenCompra.OrdImporteIGV
                    txtMontoTotal.EditValue = loOrdenCompra.OrdTotal
                    txtsaldoI.EditValue = loOrdenCompra.OrdSaldoI
                    txtsaldoF.EditValue = loOrdenCompra.OrdSaldoF

                    ListaTemporal_OrdenCompraDetNuevo.Clear()
                    ListaTemporal_OrdenCompraDetElimandos.Clear()
                    'txtMontoCertUtilizado.Tag = 0
                    txtMontoCertUtilizado.Text = 0
                    dtDetalleArticulos.Clear()
                    Dim ordenCompraDet As List(Of EEOrdenCompra.EEOrdenCompraDet) = MantenimientosBL.Instancia.ordencompraDetXOrdId(txtOrdId.Text)
                    If ordenCompraDet IsNot Nothing Then
                        For Each frow As EEOrdenCompra.EEOrdenCompraDet In ordenCompraDet
                            dtDetalleArticulos.LoadDataRow(New Object() {frow.OrdDetId, _
                                                                         frow.OArticulo.ArtId, _
                                                                         frow.OArticulo.ArtDescripcion, _
                                                                         frow.OrdDetEncabezado, _
                                                                         frow.OrdDetDescripcion, _
                                                                         frow.TgUmId, _
                                                                        frow.TgUm, _
                                                                        frow.OrdDetCantidad, _
                                                                        frow.OrdDetPrecio, _
                                                                        Format(frow.OrdDetCantidad * frow.OrdDetPrecio / (1 + igv), "##,##0.0000")
                                                                        }, True)

                        Next


                        MontoTotalSinDes = Format(CDbl(txtMontoTotal.Text), "##,##0.00")

                    End If
                    'CalcularTotal()
                    gvDetalleArticulos.BestFitColumns()
                    dtDetalleProceso.Clear()
                    Dim ordenCompraGrupoPartidas As List(Of EEOrdenCompra.EEOrdenCompraGrupoPartidas) = MantenimientosBL.Instancia.ordencompraGrupoPartidaXOrdId(txtOrdId.Text)
                    If ordenCompraGrupoPartidas IsNot Nothing Then

                        For Each frow As EEOrdenCompra.EEOrdenCompraGrupoPartidas In ordenCompraGrupoPartidas
                            txtMontoCertUtilizado.Text = txtMontoCertUtilizado.Text + frow.cerGrupoParValImporte

                            dtDetalleProceso.LoadDataRow(New Object() {frow.cerGrupoParId, _
                                                                       frow.Partida, _
                                                                       Format(frow.cerGrupoParValImporte, "##,##0.00")
                                                                        }, True)

                        Next
                    End If

                    ' Referencias del Documento
                    dtDocReferencia.Clear()
                    Dim ordenCompraDocReferencias As List(Of EEOrdenCompra.EEOrdenCompraDocRef) = MantenimientosBL.Instancia.ordencompraDocRefXOrdId(txtOrdId.Text)
                    If ordenCompraDocReferencias IsNot Nothing Then
                        For Each frow As EEOrdenCompra.EEOrdenCompraDocRef In ordenCompraDocReferencias
                            dtDocReferencia.LoadDataRow(New Object() {frow.documento, _
                                                                       frow.año, _
                                                                      "SAIMT", _
                                                                       frow.area}, True)

                        Next
                    End If

                    ' Limpiamos 
                    For i = 0 To chkListaAreas.ItemCount - 1
                        chkListaAreas.SetItemChecked(i, False)
                    Next

                    Dim ordenCompraAreaReferencias As List(Of EEOrdenCompra.EEOrdenCompraAreaRef) = MantenimientosBL.Instancia.ordencompraAreaRefXOrdId(txtOrdId.Text)
                    If ordenCompraAreaReferencias IsNot Nothing Then
                        For i = 0 To chkListaAreas.ItemCount
                            For Each frow As EEOrdenCompra.EEOrdenCompraAreaRef In ordenCompraAreaReferencias
                                If Trim(frow.tgAreaId) = chkListaAreas.GetItemValue(i) Then
                                    chkListaAreas.SetItemChecked(i, True)
                                    Exit For
                                End If
                            Next
                        Next
                    End If

                    'Actualizamos los datos de la partida
                    loGrupoPartidas = MantenimientosBL.Instancia.CertificacionGrupoPartidaXcerId(txtCertificacion.Tag)
                    If loGrupoPartidas IsNot Nothing Then
                        cboPartida.mColumnas(SaimtComboBoxLookUp.Entidades.Partida)
                        cboPartida.Properties.DisplayMember = "PartNombre"
                        cboPartida.Properties.ValueMember = "cerGrupoParId"
                        cboPartida.Properties.DataSource = loGrupoPartidas
                        cboPartida.ItemIndex = -1
                    End If
                    GIdRegistroActual = txtOrdId.Text
                    If CDbl(Val(txtDescuento.EditValue)) > 0 Then
                        chkDescuento.Checked = True
                    Else
                        chkDescuento.Checked = False
                    End If
                End If
            End If
            MyBase.seleccionarListado()
            btnImprimir.Enabled = True
            chkDescuento.Properties.ReadOnly = True
            gvDetalleArticulos.BestFitColumns()
            GridColumn1.Width = 225
            NavegacionNew(-1)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Accion = "guardar"
        Try
            If String.IsNullOrEmpty(txtNroOrdenCompra.EditValue) Then
                txtNroOrdenCompra.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro de Orden Compra")
                Return
            End If
            If String.IsNullOrEmpty(txtProveedor.Tag) Then
                txtProveedor.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado al proveedor")
                Return
            End If
            If dtDetalleArticulos.Rows.Count = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Agregue Articulo a la lista")
                Return
            End If
 
            If CDec(txtMontoQuedaCer.Text.Trim) < 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Monto Total debe ser Menor o Igual al Monto de la Certificación")
                Return
            End If

            Dim tpartidas As Decimal = 0.0
            For i = 0 To gvProcesoPresupuesto.DataRowCount - 1

                tpartidas = tpartidas + CDbl(gvProcesoPresupuesto.GetDataRow(i)("importe"))

            Next

            If tpartidas <> txtMontoTotal.Text Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Debe agregar las partidas al proceso presupuestario")
                Return
            End If


            Dim loOrdenCompra As EEOrdenCompra = New EEOrdenCompra()
            loOrdenCompra.OrdId = txtOrdId.Text
            loOrdenCompra.OrdNro = txtNroOrdenCompra.Text
            loOrdenCompra.OrdFechaDoc = dtpFechaDoc.EditValue
            loOrdenCompra.TgEstadoId = cboEstadoOrdenCompra.EditValue
            loOrdenCompra.OrdNroCompPago = txtNroComprobante.EditValue
            loOrdenCompra.TgCompPagoId = cboComprobantePago.EditValue
            loOrdenCompra.OrdRefDoc = txtReferenciaDoc.Text
            loOrdenCompra.PerProvId = txtProveedor.Tag
            'costos totales
            loOrdenCompra.OrdImporteIGV = txtIgv.Text
            loOrdenCompra.OrdSubTotal = txtSubTotal.Text
            loOrdenCompra.OrdTotal = txtMontoTotal.Text
            loOrdenCompra.OrdSaldoI = txtsaldoI.Text
            loOrdenCompra.OrdSaldoF = txtSaldoF.Text
            ' Proceso patrimonial
            loOrdenCompra.TgCuentaDebeId = txtCuentaDebe.Tag
            loOrdenCompra.TgCuentaDebe = CDec(txtMontoDebe.EditValue)

            loOrdenCompra.TgCuentaHaberId = txtCuentaHaber.Tag
            loOrdenCompra.TgCuentaHaber = CDec(txtMontoHaber.EditValue)
            'proceso presupuestario
            loOrdenCompra.CerId = txtCertificacion.Tag
            loOrdenCompra.OrdImporte = CDec(txtImportePresupuesto.EditValue)
            loOrdenCompra.OrdParIGV = igv
            If chkDescuento.Checked = True Then
                loOrdenCompra.OrdDescuento = CDec(txtDescuento.EditValue)
            Else
                loOrdenCompra.OrdDescuento = Nothing
            End If

            If CDec(txtMontoQuedaCer.Text.Trim) < 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Monto Total debe ser Menor o Igual al Monto de la Certificación")
                Return
            End If

            loOrdenCompra.CerValQuedan = CDec(txtMontoQuedaCer.EditValue)

            Dim loOrdenCompraDet As EEOrdenCompra.EEOrdenCompraDet
            loOrdenCompra.ListaOrdenCompraDet = New List(Of EEOrdenCompra.EEOrdenCompraDet)

            For Each frowDet As DataRow In dtDetalleArticulos.Rows
                loOrdenCompraDet = New EEOrdenCompra.EEOrdenCompraDet
                loOrdenCompraDet.OrdDetId = frowDet("ordDetId")
                loOrdenCompraDet.ArtId = frowDet("artId")
                loOrdenCompraDet.OrdDetEncabezado = frowDet("ordDetEncabezado").ToString
                loOrdenCompraDet.OrdDetDescripcion = frowDet("ordDetDescripcion").ToString
                loOrdenCompraDet.TgUmId = frowDet("tgUMId")
                loOrdenCompraDet.OrdDetCantidad = frowDet("ordDetCantidad")
                loOrdenCompraDet.OrdDetPrecio = frowDet("ordDetPrecio")
                ListaTemporal_OrdenCompraDetNuevo.Add(loOrdenCompraDet)
            Next
            loOrdenCompra.ListaOrdenCompraDet = ListaTemporal_OrdenCompraDetNuevo

            ' Grupo de Partidas
            Dim loOrdenCompraGrupoPartidas As EEOrdenCompra.EEOrdenCompraGrupoPartidas
            Dim ListaOrdenCompraGrupoPartidas = New List(Of EEOrdenCompra.EEOrdenCompraGrupoPartidas)
            loOrdenCompra.ListaOrdenCompraGrupoPartidas = New List(Of EEOrdenCompra.EEOrdenCompraGrupoPartidas)

            For i = 0 To gvProcesoPresupuesto.DataRowCount - 1
                loOrdenCompraGrupoPartidas = New EEOrdenCompra.EEOrdenCompraGrupoPartidas
                loOrdenCompraGrupoPartidas.cerGrupoParId = gvProcesoPresupuesto.GetDataRow(i)("cerGrupoParId")
                loOrdenCompraGrupoPartidas.cerGrupoParValImporte = gvProcesoPresupuesto.GetDataRow(i)("importe")
                ListaOrdenCompraGrupoPartidas.Add(loOrdenCompraGrupoPartidas)
            Next
            loOrdenCompra.ListaOrdenCompraGrupoPartidas = ListaOrdenCompraGrupoPartidas

            ' Areas de Referencia
            Dim ListaOrdenCompraAreaRef = New List(Of EEOrdenCompra.EEOrdenCompraAreaRef)
            loOrdenCompra.ListaOrdenCompraAreaRef = New List(Of EEOrdenCompra.EEOrdenCompraAreaRef)
            Dim loOrdenCompraAreaRef As EEOrdenCompra.EEOrdenCompraAreaRef

            For i = 0 To chkListaAreas.CheckedItemsCount
                loOrdenCompraAreaRef = New EEOrdenCompra.EEOrdenCompraAreaRef
                loOrdenCompraAreaRef.tgAreaId = chkListaAreas.CheckedItems(i)
                ListaOrdenCompraAreaRef.Add(loOrdenCompraAreaRef)
            Next
            loOrdenCompra.ListaOrdenCompraAreaRef = ListaOrdenCompraAreaRef


            ' Documento de Referencia
            Dim ListaOrdenCompraDocRef = New List(Of EEOrdenCompra.EEOrdenCompraDocRef)
            loOrdenCompra.ListaOrdenCompraDocRef = New List(Of EEOrdenCompra.EEOrdenCompraDocRef)
            Dim loOrdenCompraDocRef As EEOrdenCompra.EEOrdenCompraDocRef

            For i = 0 To gvDocReferencias.DataRowCount - 1
                loOrdenCompraDocRef = New EEOrdenCompra.EEOrdenCompraDocRef
                loOrdenCompraDocRef.documento = gvDocReferencias.GetDataRow(i)("documento").ToString
                loOrdenCompraDocRef.area = gvDocReferencias.GetDataRow(i)("area").ToString
                loOrdenCompraDocRef.año = gvDocReferencias.GetDataRow(i)("anio").ToString
                ListaOrdenCompraDocRef.Add(loOrdenCompraDocRef)
            Next
            loOrdenCompra.ListaOrdenCompraDocRef = ListaOrdenCompraDocRef


            If GEstadoNuevo Then
                MantenimientosBL.Instancia.ordencompraGuardar(loOrdenCompra)
            Else
                loOrdenCompra.Lista_OrdenCompraDetElimnados = ListaTemporal_OrdenCompraDetElimandos
                MantenimientosBL.Instancia.ordencompraActualizar(loOrdenCompra)
            End If
            ListaTemporal_OrdenCompraDetNuevo.Clear()
            ListaTemporal_OrdenCompraDetElimandos.Clear()
            dtDetalleArticulos.Clear()
            dtDetalleProceso.Clear()
            dtDocReferencia.Clear()
            enabledGA = False
            MyBase.guardar()
            btnImprimir.Enabled = False

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Sub NavegacionNew(ByVal Index As String)

        If Index <> -1 Then

            Select Case tabOrdenCompra.SelectedTabPageIndex
                Case 0
                    If String.IsNullOrEmpty(txtNroOrdenCompra.EditValue) Then
                        txtNroOrdenCompra.Focus()
                        SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro de Orden Compra")
                        Return
                    End If
                    If String.IsNullOrEmpty(dtpFechaDoc.EditValue) Then
                        dtpFechaDoc.Focus()
                        SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese la fecha de la Orden de Compra")
                        Return
                    End If
                Case 1
                    If String.IsNullOrEmpty(txtProveedor.Tag) Then
                        txtProveedor.Focus()
                        SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado al proveedor")
                        Return
                    End If
                Case 2
                    If String.IsNullOrEmpty(txtCertificacion.Tag) Then
                        txtCertificacion.Focus()
                        SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una certificación")
                        Return
                    End If
                Case 3
                    Dim paso As Boolean = False
                    For i = 0 To chkListaAreas.ItemCount
                        If chkListaAreas.GetItemChecked(i) Then
                            paso = True
                            Exit For
                        End If
                    Next
                    If paso = False Then
                        chkListaAreas.Focus()
                        SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una o mas áreas de referencias")
                        Return
                    End If
                Case 4
                    If dtDetalleArticulos.Rows.Count = 0 Then
                        SaimtMessageBox.mostrarAlertaAdvertencia("Agregue Articulo a la lista")
                        Return
                    End If
                Case 5
                    Dim tpartidas As Decimal = 0.0
                    For i = 0 To gvProcesoPresupuesto.DataRowCount - 1
                        tpartidas = tpartidas + CDbl(gvProcesoPresupuesto.GetDataRow(i)("importe"))
                    Next
                    If tpartidas <> txtMontoTotal.Text Then
                        SaimtMessageBox.mostrarAlertaAdvertencia("Debe agregar las partidas al proceso presupuestario")
                        Return
                    End If
                Case 6
                    If dtDocReferencia.Rows.Count = 0 Then
                        SaimtMessageBox.mostrarAlertaAdvertencia("Agregue documentos de referencia a la orden de compra")
                        Return
                    End If

            End Select
        End If
        For i = 0 To tabOrdenCompra.TabPages.Count - 1
            'If i <> tabOrdenCompra.TabPages.Count - 1 Then
            tabOrdenCompra.TabPages(i).PageVisible = False
            'End If
        Next
        If Index + 1 = 0 Then
            btnAtrasOrdenCompra.Enabled = False
        Else
            btnAtrasOrdenCompra.Enabled = True
        End If

        tabOrdenCompra.SelectedTabPageIndex = (Index + 1)
        tabOrdenCompra.TabPages(Index + 1).PageVisible = True

        If Accion = "nuevo" Then
            btnGuardar.Enabled = False
        ElseIf Accion = "editar" Then
            btnGuardar.Enabled = True
        End If

        If tabOrdenCompra.TabPages.Count - 1 = Index + 1 Then
            btnGuardar.Enabled = True
            btnNavOrdCompra.Enabled = False
        End If

    End Sub


    Sub NavegacionLast(ByVal Index As String)
        For i = 0 To tabOrdenCompra.TabPages.Count - 1
            tabOrdenCompra.TabPages(i).PageVisible = False
        Next
        If 0 < Index Then
            tabOrdenCompra.SelectedTabPageIndex = (Index - 1)
            tabOrdenCompra.TabPages(Index - 1).PageVisible = True
            If Index - 1 = 0 Then
                btnAtrasOrdenCompra.Enabled = False
                btnNavOrdCompra.Enabled = True
            End If
        End If
    End Sub

    Protected Overrides Sub nuevo()
        Accion = "nuevo"
        MyBase.nuevo()
        dtDetalleProceso.Clear()
        dtDetalleArticulos.Clear()
        dtDocReferencia.Clear()
        txtOrdId.EditValue = MantenimientosBL.Instancia.ordencompraGeneraCodigo
        txtOrdId.Properties.ReadOnly = True
        'txtNroOrdenCompra.EditValue = MantenimientosBL.Instancia.ordencompraGeneraCodigoSAIMT
        txtNroOrdenCompra.Properties.ReadOnly = False
        txtCertificacion.Properties.ReadOnly = True
        cboEstadoOrdenCompra.EditValue = "4"
        cboEstadoOrdenCompra.Properties.ReadOnly = True
        txtProveedor.Properties.ReadOnly = True
        txtNroDocumentoProveedor.Properties.ReadOnly = True
        cboUM.Properties.ReadOnly = True
        txtDireccionProveedor.Properties.ReadOnly = True
        txtArticulo.Properties.ReadOnly = True
        txtEncabezado.Properties.ReadOnly = True
        txtDescripcion.Properties.ReadOnly = True
        txtArticulo.Tag = Nothing
        txtArticulo.Text = Nothing
        txtDescripcion.Text = Nothing
        txtEncabezado.Text = Nothing
        txtCantidad.Properties.ReadOnly = True
        txtPrecioUnitario.Properties.ReadOnly = True
        txtCuentaDebe.Properties.ReadOnly = True
        txtCuentaHaber.Properties.ReadOnly = True
        txtCertificacion.Properties.ReadOnly = True
        txtSubTotal.Properties.ReadOnly = True
        txtIgv.Properties.ReadOnly = True
        txtMontoTotalCer.Properties.ReadOnly = True
        txtMontoQuedaCer.Properties.ReadOnly = True
        txtMontoCertUtilizado.Properties.ReadOnly = True
        txtMontoTotal.Properties.ReadOnly = True
        txtMontoDebe.Properties.ReadOnly = True
        txtMontoHaber.Properties.ReadOnly = True
        '  txtPartida.Properties.ReadOnly = True
        ' txtImportePresupuesto.Properties.ReadOnly = True
        chkDescuento.Properties.ReadOnly = False

        btnImprimir.Enabled = False
        chkDescuento.Checked = False

        txtPrecioUnitario.Text = "0.0000"
        txtMontoQuedaCer.Text = "0.00"
        txtCantidad.Text = 0
        NavegacionNew(-1)
    End Sub

    Protected Overrides Sub editar()
        Accion = "editar"
        MyBase.editar()

        txtOrdId.Properties.ReadOnly = True
        txtNroOrdenCompra.Properties.ReadOnly = False
        txtArticulo.Properties.ReadOnly = True
        txtDescripcion.Properties.ReadOnly = True
        txtEncabezado.Properties.ReadOnly = True
        cboUM.Properties.ReadOnly = True
        txtNroDocumentoProveedor.Properties.ReadOnly = True
        txtDireccionProveedor.Properties.ReadOnly = True
        txtCantidad.Properties.ReadOnly = True
        txtPrecioUnitario.Properties.ReadOnly = True
        txtCuentaDebe.Properties.ReadOnly = True
        txtCuentaHaber.Properties.ReadOnly = True
        txtCertificacion.Properties.ReadOnly = True
        txtMontoTotal.Properties.ReadOnly = True
        txtMontoDebe.Properties.ReadOnly = True
        txtMontoHaber.Properties.ReadOnly = True
 
        txtMontoTotalCer.Properties.ReadOnly = True
        chkDescuento.Properties.ReadOnly = False

        txtArticulo.Tag = Nothing
        txtArticulo.Text = Nothing
        txtDescripcion.Text = Nothing
        txtEncabezado.Text = Nothing

        btnImprimir.Enabled = False
        btnConsultarCertificacion.Enabled = False

        txtPrecioUnitario.Text = "0.0000"
        txtCantidad.Text = 0

        btnAtrasOrdenCompra.Enabled = False
        'btnNavOrdCompra.Enabled = 
    End Sub

    Protected Overrides Sub Buscar()
        Accion = "buscar"
        Try
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterio.SelectedIndex
            If GCriterioBuscado = 5 Then
                GValorTextoBuscado = cboBuscarPorEstado.EditValue
            End If
            Dim loOrdenCompra As List(Of EEOrdenCompra) = MantenimientosBL.Instancia.ordencompraListarCriterio(GCriterioBuscado, GValorTextoBuscado, cboAnioCriterio.EditValue)

            dtListado.Clear()
            dtDetalleArticulos.Clear()
            If loOrdenCompra IsNot Nothing Then
                For Each frow As EEOrdenCompra In loOrdenCompra
                    dtListado.LoadDataRow(New Object() {frow.OrdId, _
                    frow.OrdNro, _
                    frow.OrdFechaDoc, _
                    frow.TgEstado
                    }, True)
                Next
                gvListadoOrdenCompra.BestFitColumns()
                gvListadoOrdenCompra.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)

            End If
            MyBase.Buscar()
            cboBuscarPorEstado.Properties.ReadOnly = IIf(cboCriterio.SelectedIndex = 5, False, True)
            txtCantidad.Properties.ReadOnly = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub imprimir()
        Try
            xl = EEExcel.Instancia
            xl.Workbooks.Open(EEComun.RutaReportes & "\RptOrdenesCompra2013.xls", 1, True, 4)
            ExportarOrdenCompra()
            If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ruta = String.Format("{0}\OrdenCompra_{1}", fbdExportar.SelectedPath, txtNroOrdenCompra.Text.Trim & "-" & dtpFechaDoc.DateTime.Year)
                xl.ActiveWorkbook.SaveAs(ruta)
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre OrdenCompra_" & txtNroOrdenCompra.Text.Trim & "-" & dtpFechaDoc.DateTime.Year
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

    Private Sub ExportarOrdenCompra()
        xl.Sheets(xl.Worksheets("OrdenCompra").Index).Select()
        xl.Range("F1").Value = "ORDEN DE COMPRA"
        xl.Range("F2").Value = "RUC 20481297223"
        xl.Range("F2").Font.Bold = True
        xl.Range("C4").Value = txtOrdId.EditValue
        xl.Range("C4").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xl.Range("N5").Value = String.Format("{0}", dtpFechaDoc.DateTime.Day)
        xl.Range("O5").Value = String.Format("{0}", Format(dtpFechaDoc.DateTime.Month, "00"))
        xl.Range("P5").Value = String.Format("{0}", dtpFechaDoc.DateTime.Year)
        xl.Range("A7").Value = txtProveedor.EditValue
        xl.Range("C8").Value = txtDireccionProveedor.EditValue
        xl.Range("C9").Value = "'" & txtNroDocumentoProveedor.Text
        xl.Range("J9").Value = cboComprobantePago.Text
        xl.Range("M9").Value = txtNroComprobante.EditValue
        xl.Range("C10").Value = txtReferenciaDoc.Text
        xl.Range("E11").Value = "SERVICIO DE ADMINISTRACIÒN DE INMUEBLES MUNICIPALES DE TRUJILLO"
        xl.Range("C12").Value = "JR.BOLIVAR(554 - 558)"

        Dim FilaEncabezado As String = "B14"
        Dim FilaCantidad As String = "A14"
        Dim FilaCompras As String = "B14"
        Dim FilaPrecioUnitario As String = "M14"
        Dim FilaPrecioTotal As String = "N14"

        Dim FilaSubTotal As String = "N24"
        Dim FilaMontoIGV As String = "N25"
        Dim FilaIGV As String = "M25"
        Dim FilaTotal As String = "N26"
        Dim FilaSon As String = "B26"

        Dim FilaDescuento As String = "B14"
        Dim FilaMontoDescuento As String = "N14"

        Dim FilaCDebe As String = "B29"
        Dim FilaDebe As String = "C29"
        Dim FilaCHaber As String = "F29"
        Dim FilaHaber As String = "I29"
        Dim FilaAct As String = "J29"
        Dim FilaMeta As String = "K29"
        Dim FilaFF As String = "L29"
        Dim FilaPartida As String = "M29"
        Dim FilaImporte As String = "O29"
        Dim fila As Integer = 14
        
        xl.Cells.Range("A13").Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xl.Cells.Range("P13").Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        Dim c As Integer = dtDetalleArticulos.Rows.Count - 10
        If c > 1 Then
            For i = 15 To c + 14
                xl.Rows(i).Insert(Shift:=Excel.XlInsertShiftDirection.xlShiftDown, _
                                CopyOrigin:=Excel.XlInsertFormatOrigin.xlFormatFromRightOrBelow)
                xl.Range(String.Format("B{0}:L{0}", i)).MergeCells = True
                xl.Range(String.Format("N{0}:P{0}", i)).MergeCells = True
            Next
        End If

        For Each fTablaDetalleServicios As DataRow In dtDetalleArticulos.Rows
            If fTablaDetalleServicios("ordDetEncabezado") <> "" Then
                xl.Range(FilaEncabezado).Value = fTablaDetalleServicios("ordDetEncabezado")
                ' xl.Range(FilaEncabezado).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                fila = fila + 1
            End If

            FilaCantidad = "A" & fila
            xl.Range(FilaCantidad).Value = fTablaDetalleServicios("ordDetCantidad")
            ' xl.Range(FilaCantidad).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            FilaCompras = "B" & fila
            xl.Range(FilaCompras).Value = fTablaDetalleServicios("artDescripcion") & fTablaDetalleServicios("ordDetDescripcion")
            ' xl.Range(FilaCompras).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            FilaPrecioUnitario = "M" & fila
            xl.Range(FilaPrecioUnitario).Value = fTablaDetalleServicios("ordDetPrecio")

            FilaPrecioTotal = "N" & fila
            xl.Range(FilaPrecioTotal).Value = fTablaDetalleServicios("ordDetImporte")
            '  xl.Range(FilaPrecioTotal).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'xl.Cells.Range("A" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            'xl.Cells.Range("B" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            'xl.Cells.Range("M" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            'xl.Cells.Range("N" & fila).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            'xl.Cells.Range("P" & fila).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            fila = fila + 1
        Next

        If dtDetalleArticulos.Rows.Count < 10 Then
            fila = fila + (10 - dtDetalleArticulos.Rows.Count)
        End If
        If chkDescuento.Checked = True Then
            fila = fila + 1
            xl.Rows(fila).Insert(Shift:=Excel.XlInsertShiftDirection.xlShiftDown, _
                            CopyOrigin:=Excel.XlInsertFormatOrigin.xlFormatFromRightOrBelow)
            xl.Range(String.Format("B{0}:L{0}", fila)).MergeCells = True
            xl.Range(String.Format("N{0}:P{0}", fila)).MergeCells = True

            FilaDescuento = "B" & fila
            xl.Range(FilaDescuento).Value = "DESCUENTO"
            xl.Range(FilaDescuento).Font.Bold = True
            xl.Range(FilaDescuento).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(FilaMontoDescuento).Value = Val(txtDescuento.EditValue)
            xl.Range(FilaMontoDescuento).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            FilaMontoDescuento = "N" & fila
            xl.Range(FilaMontoDescuento).Value = txtDescuento.EditValue
            xl.Range(FilaMontoDescuento).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        FilaSubTotal = "N" & fila
        xl.Range(FilaSubTotal).Value = txtSubTotal.Text
        xl.Range(FilaSubTotal).Font.Bold = True
        xl.Range(FilaSubTotal).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        FilaIGV = "M" & fila + 1
        xl.Range(FilaIGV).Value = String.Format("({0}%)", CInt(igv * 100))
        xl.Range(FilaIGV).Font.Bold = True
        xl.Range(FilaIGV).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        FilaMontoIGV = "N" & fila + 1
        xl.Range(FilaMontoIGV).Value = txtIgv.Text
        xl.Range(FilaMontoIGV).Font.Bold = True
        xl.Range(FilaMontoIGV).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        FilaTotal = "N" & fila + 2
        xl.Range(FilaTotal).Value = txtMontoTotal.Text
        xl.Range(FilaTotal).Font.Bold = True

        FilaSon = "B" & fila + 2
        xl.Range(FilaSon).Value = String.Format("{0} NUEVOS SOLES", UCase(EEComun.MonedaLetras(txtMontoTotal.Text)))
        xl.Range(FilaSon).Font.Bold = True
        xl.Range(FilaSon).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        FilaCDebe = "B" & fila + 5
        If txtCuentaDebe.Tag <> "" Then
            xl.Range(FilaCDebe).Value = txtCuentaDebe.Tag.ToString.Substring(4)
            xl.Range(FilaCDebe).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Else
            xl.Range(FilaCDebe).Value = "-"
            xl.Range(FilaCDebe).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        FilaDebe = "C" & fila + 5
        xl.Range(FilaDebe).Value = txtMontoDebe.Text
        xl.Range(FilaDebe).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        FilaCHaber = "F" & fila + 5
        If txtCuentaHaber.Tag <> "" Then
            xl.Range(FilaCHaber).Value = txtCuentaHaber.Tag.ToString.Substring(4)
            xl.Range(FilaCHaber).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Else
            xl.Range(FilaCHaber).Value = "-"
            xl.Range(FilaCHaber).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        FilaHaber = "I" & fila + 5
        xl.Range(FilaHaber).Value = txtMontoHaber.Text
        xl.Range(FilaHaber).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        FilaAct = "J" & fila + 5
        xl.Range(FilaAct).Value = cboActProy.EditValue
        xl.Range(FilaAct).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        FilaMeta = "K" & fila + 5
        xl.Range(FilaMeta).Value = cboMeta.EditValue
        xl.Range(FilaMeta).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        FilaFF = "L" & fila + 5
        xl.Range(FilaFF).Value = cboFuenteFinanciera.EditValue
        xl.Range(FilaFF).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        FilaPartida = "M" & fila + 5
        'If txtPartida.Tag <> "" Then
        '    xl.Range(FilaPartida).Value = txtPartida.Tag.ToString
        '    xl.Range(FilaPartida).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'Else
        '    xl.Range(FilaPartida).Value = "-"
        '    xl.Range(FilaPartida).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'End If

        FilaImporte = "O" & fila + 5
        xl.Range(FilaImporte).Value = txtImportePresupuesto.Text
        xl.Range(FilaImporte).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    End Sub
#End Region

    Private Sub frmPedidoArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        igv = MantenimientosBL.Instancia.parametroMostrarXClsId(42)
        cboComprobantePago.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboComprobantePago.Properties.DisplayMember = "TgNombre"
        cboComprobantePago.Properties.ValueMember = "TgCodigo"
        cboComprobantePago.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(182)
        cboComprobantePago.ItemIndex = -1

        cboEstadoOrdenCompra.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoOrdenCompra.Properties.DisplayMember = "TgNombre"
        cboEstadoOrdenCompra.Properties.ValueMember = "TgCodigo"
        cboEstadoOrdenCompra.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(128)
        cboEstadoOrdenCompra.ItemIndex = -1

        cboBuscarPorEstado.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboBuscarPorEstado.Properties.DisplayMember = "TgNombre"
        cboBuscarPorEstado.Properties.ValueMember = "TgCodigo"
        cboBuscarPorEstado.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(128)
        cboBuscarPorEstado.ItemIndex = -1

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

        cboActProy.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboActProy.Properties.DisplayMember = "TgNombre"
        cboActProy.Properties.ValueMember = "TgCodigo"
        cboActProy.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(135)
        cboActProy.ItemIndex = -1

        cboUM.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboUM.Properties.DisplayMember = "TgNombre"
        cboUM.Properties.ValueMember = "TgCodigo"
        cboUM.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(105)
        cboUM.ItemIndex = -1

        cboAnioCriterio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAnioCriterio.Properties.DisplayMember = "TgNombre"
        cboAnioCriterio.Properties.ValueMember = "TgCodigo"
        cboAnioCriterio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(76)
        cboAnioCriterio.EditValue = CStr(Date.Now.Year)

        cboBuscarPorEstado.Properties.ReadOnly = True
        txtCantidad.Properties.ReadOnly = True
        cboUM.Properties.ReadOnly = True
        chkDescuento.Properties.ReadOnly = True

        ConstruirTableDetalleProcesoPresupuestario()
        dgvProcesoPresupuesto.DataSource = dtDetalleProceso

        ConstruirTableDetalleArticulos()
        dgvDetalleArticulos.DataSource = dtDetalleArticulos

        ConstruirTableListado()
        dgvListadoOrdenCompra.DataSource = dtListado

        ConstruirTableDocRef()
        dgvDocReferencias.DataSource = dtDocReferencia

        chkListaAreas.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(83, "0001")
        chkListaAreas.DisplayMember = "TgNombre"
        chkListaAreas.ValueMember = "TgCodigo"
        mAgregarCombo()
        PuedeBuscar = True
        PuedeCrear = True
        PuedeEditar = True
        PuedeImprimir = True
        PuedeEliminar = True
    End Sub

    Private Sub btnBuscarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProveedor.Click
        Using fmConsultaProveedor As frmConsultaProveedor = New frmConsultaProveedor()
            If fmConsultaProveedor.ShowDialog() = DialogResult.OK Then
                txtProveedor.Text = fmConsultaProveedor.PerProveedor
                txtProveedor.Tag = fmConsultaProveedor.PerId
                txtNroDocumentoProveedor.Text = fmConsultaProveedor.PerRUC
                txtDireccionProveedor.Text = fmConsultaProveedor.PerDireccion
            End If
        End Using
    End Sub

    Private Sub dgvDetalleArticulos_FocusedViewChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.ViewFocusEventArgs) Handles dgvDetalleArticulos.FocusedViewChanged
        Try
            If Not IsNumeric(gvDetalleArticulos.GetRowCellValue(Me.gvDetalleArticulos.GetSelectedRows(0), "ordDetCantidad")) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese un Valor Numerico Cantidad")
                Return
            End If
            If Not IsNumeric(gvDetalleArticulos.GetRowCellValue(Me.gvDetalleArticulos.GetSelectedRows(0), "ordDetPrecio")) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese un Valor Numero en el Precio Unitario")
                Return
            End If
            Dim cantidad As Integer = CInt(gvDetalleArticulos.GetRowCellValue(Me.gvDetalleArticulos.GetSelectedRows(0), "ordDetCantidad").ToString())
            Dim precio As Double = CDbl(gvDetalleArticulos.GetRowCellValue(Me.gvDetalleArticulos.GetSelectedRows(0), "ordDetPrecio").ToString())
            gvDetalleArticulos.SetRowCellValue(Me.gvDetalleArticulos.GetSelectedRows(0), "ordDetImporte", cantidad * precio)
            txtSubTotal.EditValue = 0
            For Each frow As DataRow In dtDetalleArticulos.Rows
                txtSubTotal.EditValue = txtSubTotal.EditValue + CDbl(frow("ordDetImporte"))
            Next
            txtMontoTotal.Text = txtSubTotal.Text + (txtSubTotal.Text * MantenimientosBL.Instancia.parametroMostrarXClsId(42))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnQuitarDetalleArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.Click
        If Me.gvDetalleArticulos.DataRowCount <> 0 Then
            If dtDetalleArticulos.Rows(Me.gvDetalleArticulos.GetSelectedRows(0))("ordDetId").ToString() > 0 Then
                If ListaTemporal_OrdenCompraDetElimandos Is Nothing Then
                    ListaTemporal_OrdenCompraDetElimandos = New List(Of String)
                End If
                ordDetId = dtDetalleArticulos.Rows(Me.gvDetalleArticulos.GetSelectedRows(0))("ordDetId").ToString
                ListaTemporal_OrdenCompraDetElimandos.Add(ordDetId)
            End If
            If ListaTemporal_OrdenCompraDetElimandos IsNot Nothing Then
                If ListaTemporal_OrdenCompraDetNuevo.Count > 0 Then
                    Dim liIndiceNuevoModificar As Int16 = 0
                    Dim liFila As Int16 = -1
                    For Each fTablaGeneral As DataRow In dtDetalleArticulos.Rows
                        If String.IsNullOrEmpty(fTablaGeneral("ordDetId")) And Me.gvDetalleArticulos.FocusedRowHandle = liFila Then
                            liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                        End If
                        liFila = liFila + 1
                    Next
                    ListaTemporal_OrdenCompraDetNuevo.RemoveAt(liIndiceNuevoModificar)
                End If
            End If
            Dim Temp As Decimal = 0.0
            If IsNumeric(txtMontoTotal.EditValue) Then
                Temp = Format(CDbl(txtMontoTotal.EditValue), "##,##0.00")
            End If

            ordDetId = dtDetalleArticulos.Rows(Me.gvDetalleArticulos.GetSelectedRows(0))("ordDetId").ToString
            dtDetalleArticulos.Rows.RemoveAt(Me.gvDetalleArticulos.GetSelectedRows(0))
            txtCantidad.Properties.ReadOnly = True
            txtPrecioUnitario.Properties.ReadOnly = True
            txtDescripcion.Properties.ReadOnly = True
            txtEncabezado.Properties.ReadOnly = True
            txtCantidad.EditValue = 0
            txtPrecioUnitario.EditValue = "0.00"
            txtArticulo.Tag = Nothing
            txtArticulo.Text = Nothing
            txtDescripcion.Text = Nothing
            txtEncabezado.Text = Nothing
            gvDetalleArticulos.BestFitColumns()
            GridColumn1.Width = 225


        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub


    Private Sub btnAgregarProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProductos.Click
        Dim frm As New frmConsultaArticulo
        frm.sRbBuscarPor.EditValue = 2
        If frm.ShowDialog Then
            txtArticulo.Text = frm.ArtDescripcion
            txtArticulo.Tag = frm.ArtId
            cboUM.EditValue = frm.tgUM
        End If
        If frm.ArtId IsNot Nothing Then
            txtCantidad.Properties.ReadOnly = False
            txtDescripcion.Properties.ReadOnly = False
            txtEncabezado.Properties.ReadOnly = False
            txtPrecioUnitario.Properties.ReadOnly = False
        Else
            txtCantidad.Properties.ReadOnly = True
            txtPrecioUnitario.Properties.ReadOnly = True
            txtDescripcion.Properties.ReadOnly = True
            txtEncabezado.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub btnConsultarCuentaDebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCuentaDebe.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta()
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaDebe.Tag = fmConsulta.PlanCIdCompuesto
                txtCuentaDebe.Text = String.Format("{0} - {1}", txtCuentaDebe.Tag.ToString.Substring(4), fmConsulta.PlanCDescripcion)
            End If
        End Using
    End Sub

    Private Sub btnConsultarCuentaHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCuentaHaber.Click
        Using fmConsulta As frmConsultarPlanCuenta = New frmConsultarPlanCuenta()
            If fmConsulta.ShowDialog() = DialogResult.OK Then
                txtCuentaHaber.Tag = fmConsulta.PlanCIdCompuesto
                txtCuentaHaber.Text = String.Format("{0} - {1}", txtCuentaHaber.Tag.ToString.Substring(4), fmConsulta.PlanCDescripcion)
            End If
        End Using
    End Sub

    Private Sub btnConsultarCertificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCertificacion.Click
        Dim frm As frmConsultarCertificacion = New frmConsultarCertificacion()
        Dim lsMensajeGA As String
        If frm.ShowDialog Then
            lsMensajeGA = "Esta seguro que desea utilizar la Certificación N° " + frm.cerNro + " con Monto Total " + Format(CDbl(frm.cerValTotal), "##,##0.00") + " y Monto Restante de " + Format(CDbl(frm.cerValQuedan), "##,##0.00")

            If frm.cerId = "" Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Certificación")
                txtCertificacion.Tag = ""
                txtCertificacion.Text = ""
                cboPartida.Text = Nothing
                cboActProy.EditValue = ""
                cboMeta.EditValue = ""
                cboFuenteFinanciera.EditValue = ""
                txtMontoTotalCer.Text = ""
                txtMontoQuedaCer.Text = ""
                txtReferenciaDoc.Text = ""           '
                cboPartida.Properties.DataSource = Nothing

                txtCertificacion.Focus()
                Exit Sub
            End If

            Select Case SaimtMessageBox.mostrarAlertaPregunta(lsMensajeGA)
                Case System.Windows.Forms.DialogResult.OK
                    If frm.cerValQuedan > 0 Then
                        txtCertificacion.Tag = frm.cerId
                        txtCertificacion.Text = frm.cerNro
                        cboActProy.EditValue = frm.tgActProyId
                        cboMeta.EditValue = frm.tgMetaId
                        cboFuenteFinanciera.EditValue = frm.tgFFinancieraId
                        txtMontoTotalCer.Text = frm.cerValTotal
                        txtMontoQuedaCer.Text = frm.cerValQuedan
                        txtsaldoI.Text = frm.cerValQuedan
                        txtReferenciaDoc.Text = String.Format("CERT. Nº {0}- {1} - SAIMT/OPP", txtCertificacion.Text, frm.anio)
                        loGrupoPartidas = MantenimientosBL.Instancia.CertificacionGrupoPartidaXcerId(frm.cerId)
                        If loGrupoPartidas IsNot Nothing Then
                            cboPartida.mColumnas(SaimtComboBoxLookUp.Entidades.Partida)
                            cboPartida.Properties.DisplayMember = "PartDato"
                            cboPartida.Properties.ValueMember = "cerGrupoParId"
                            cboPartida.Properties.DataSource = loGrupoPartidas
                            cboPartida.ItemIndex = -1
                        End If
                    Else
                        SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una Certificación")
                    End If
                    Exit Select

                Case System.Windows.Forms.DialogResult.Cancel
                    Exit Select
            End Select
        End If
    End Sub
    Sub CalcularTotal()
        txtSubTotal.Text = 0
        txtMontoTotal.Text = 0
        txtIgv.Text = 0
        For Each rowDetArticulo As DataRow In dtDetalleArticulos.Rows
            txtSubTotal.EditValue = CDec(txtSubTotal.EditValue) + (CDec(Val(rowDetArticulo("ordDetImporte"))))
        Next
        If IsNumeric(txtDescuento.EditValue) = False Then
            txtDescuento.Text = 0
        End If
        If chkDescuento.Checked = True Then
            txtSubTotal.BackColor = SystemColors.Info
            txtIgv.BackColor = SystemColors.Info
            txtMontoTotal.BackColor = SystemColors.Info
            txtSubTotal.EditValue = CDec(txtSubTotal.Text.Trim) - CDec(txtDescuento.Text.Trim)
        End If
        txtIgv.EditValue = CDec(txtSubTotal.Text.Trim) * igv
        txtMontoTotal.EditValue = CDec(txtSubTotal.Text.Trim) + CDec(txtIgv.Text.Trim)
        txtMontoDebe.EditValue = CDec(txtMontoTotal.Text.Trim)
        txtMontoHaber.EditValue = CDec(txtMontoTotal.Text.Trim)
    End Sub



    Private Sub btnAddProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProducto.Click

        If txtArticulo.Tag Is Nothing Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Articulo")
            txtArticulo.Focus()
            Exit Sub
        End If
        If CDbl(txtCantidad.EditValue) <= 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("La cantidad no puede ser 0")
            txtCantidad.Focus()
            Exit Sub
        End If
        If CDbl(txtPrecioUnitario.EditValue) <= 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El precio unitario no puede ser 0 soles")
            txtPrecioUnitario.Focus()
            Exit Sub
        End If

        If CDbl(txtMontoQuedaCer.Text.Trim) < CDbl(txtCantidad.Text.Trim) * CDbl(txtPrecioUnitario.Text.Trim) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El Monto Total debe ser Menor o Igual al Monto Queda de la Certificación")
            Return
        End If

        If CDbl(txtMontoQuedaCer.Text.Trim) - (CDbl(txtCantidad.Text.Trim) * CDbl(txtPrecioUnitario.Text.Trim)) < 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El Monto Total debe ser Menor o Igual al Monto de la Certificación")
            Return
        End If

        dtDetalleArticulos.LoadDataRow(New Object() {0,
                                      txtArticulo.Tag, _
                                      txtArticulo.Text, _
                                      txtEncabezado.Text, _
                                      txtDescripcion.Text, _
                                      cboUM.EditValue, _
                                      cboUM.Text, _
                                      txtCantidad.Text, _
                                      Format(CDbl(txtPrecioUnitario.Text.Trim), "##,##0.0000"), _
                                      Format(CDbl(txtCantidad.Text.Trim) * CDbl(txtPrecioUnitario.Text.Trim) / (1 + igv), "##,##0.0000")
                               }, True)

 
        txtCantidad.Properties.ReadOnly = True
        txtPrecioUnitario.Properties.ReadOnly = True
        txtDescripcion.Properties.ReadOnly = True
        txtEncabezado.Properties.ReadOnly = True
        txtCantidad.EditValue = 0
        txtPrecioUnitario.EditValue = "0.00"
        txtArticulo.Tag = Nothing
        txtArticulo.Text = Nothing
        txtDescripcion.Text = Nothing
        txtEncabezado.Text = Nothing
        gvDetalleArticulos.BestFitColumns()
        GridColumn1.Width = 225

        CalcularTotal()

    End Sub

    Private Sub cboCriterio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriterio.SelectedIndexChanged
        If cboCriterio.SelectedIndex = 5 Then
            cboBuscarPorEstado.Properties.ReadOnly = False
            txtBuscarPor.Properties.ReadOnly = True
        Else
            txtBuscarPor.Properties.ReadOnly = False
            cboBuscarPorEstado.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub cboBuscarPorEstado_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuscarPorEstado.EditValueChanged
        If cboCriterio.SelectedIndex = 5 Then
            txtBuscarPor.Properties.ReadOnly = True
            Buscar()
        End If
    End Sub

    Sub calcularDescuento()
        If chkDescuento.Checked = True Then
            txtSubTotal.EditValue = CDbl(txtSubTotal.EditValue) - CDbl(txtDescuento.EditValue)
            txtIgv.EditValue = CDbl(txtSubTotal.EditValue) * igv
            txtMontoTotal.EditValue = CDbl(txtSubTotal.EditValue) + CDbl(txtIgv.EditValue)
            txtMontoDebe.EditValue = CDbl(txtMontoTotal.EditValue)
            txtMontoHaber.EditValue = CDbl(txtMontoTotal.EditValue)
            txtImportePresupuesto.EditValue = CDbl(txtMontoTotal.EditValue)
            txtSubTotal.BackColor = SystemColors.Info
            txtIgv.BackColor = SystemColors.Info
            txtMontoTotal.BackColor = SystemColors.Info
        Else
            If IsNumeric(txtDescuento.EditValue) Then
                txtSubTotal.EditValue = CDbl(txtSubTotal.EditValue) + CDbl(txtDescuento.EditValue)
            End If
            txtIgv.EditValue = CDbl(txtSubTotal.EditValue) * igv
            txtMontoTotal.EditValue = CDbl(txtSubTotal.EditValue) + CDbl(txtIgv.EditValue)
            txtMontoDebe.EditValue = CDbl(txtMontoTotal.EditValue)
            txtMontoHaber.EditValue = CDbl(txtMontoTotal.EditValue)
            txtSubTotal.BackColor = SystemColors.Menu
            txtIgv.BackColor = SystemColors.Menu
            txtMontoTotal.BackColor = SystemColors.Menu
        End If
    End Sub

    Private Sub chkDescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDescuento.CheckedChanged
        
        If Accion = "editar" Then
            If CDbl(Val(txtDescuento.EditValue)) <= 0 Then
                If chkDescuento.Checked = True Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("El descuento no puede ser menor o igual que cero")
                    chkDescuento.Checked = Not chkDescuento.Checked
                End If
                Return
            End If
            If dtDetalleArticulos.Rows.Count = 0 Then
                If chkDescuento.Checked = True Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("No se puede efectuar descuento si no existe producto agregado")
                    chkDescuento.Checked = Not chkDescuento.Checked
                End If
                Return
            End If
        End If

        If Accion = "nuevo" Then
            If CDbl(txtDescuento.EditValue) <= 0 Then
                If chkDescuento.Checked = True Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("El descuento no puede ser menor o igual que cero")
                    chkDescuento.Checked = Not chkDescuento.Checked
                End If
                Return
            End If
            If dtDetalleArticulos.Rows.Count = 0 Then
                If chkDescuento.Checked = True Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("No se puede efectuar descuento si no existe producto agregado")
                    chkDescuento.Checked = Not chkDescuento.Checked
                End If
                Return
            End If
        End If

        CalcularTotal()
    End Sub

    Private Sub gvDetalleArticulos_CustomDrawRowIndicator(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gvDetalleArticulos.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = (e.RowHandle + 1)
            e.Info.ImageIndex = -1
        End If
        gvDetalleArticulos.IndicatorWidth = 30
    End Sub

    Private Sub txtNroOrdenCompra_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroOrdenCompra.Leave
        Dim s As String = "000000" & txtNroOrdenCompra.Text
        txtNroOrdenCompra.Text = s.Substring(Len(s) - 6)

    End Sub

    Private Sub btnElimEditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimEditor.Click
        If Me.gvDetalleArticulos.DataRowCount <> 0 Then
            If dtDetalleArticulos.Rows(Me.gvDetalleArticulos.GetSelectedRows(0))("ordDetId").ToString() > 0 Then
                If ListaTemporal_OrdenCompraDetElimandos Is Nothing Then
                    ListaTemporal_OrdenCompraDetElimandos = New List(Of String)
                End If
                Dim ordDetId As String = dtDetalleArticulos.Rows(Me.gvDetalleArticulos.GetSelectedRows(0))("ordDetId").ToString
                ListaTemporal_OrdenCompraDetElimandos.Add(ordDetId)
            End If
            If ListaTemporal_OrdenCompraDetElimandos IsNot Nothing Then
                If ListaTemporal_OrdenCompraDetNuevo.Count > 0 Then
                    Dim liIndiceNuevoModificar As Int16 = 0
                    Dim liFila As Int16 = -1
                    For Each fTablaGeneral As DataRow In dtDetalleArticulos.Rows
                        If String.IsNullOrEmpty(fTablaGeneral("ordDetId")) And Me.gvDetalleArticulos.FocusedRowHandle = liFila Then
                            liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                        End If
                        liFila = liFila + 1
                    Next
                    ListaTemporal_OrdenCompraDetNuevo.RemoveAt(liIndiceNuevoModificar)
                End If
            End If

            txtArticulo.Tag = gvDetalleArticulos.GetDataRow(Me.gvDetalleArticulos.GetSelectedRows(0)).Item(1)
            txtArticulo.Text = gvDetalleArticulos.GetDataRow(Me.gvDetalleArticulos.GetSelectedRows(0)).Item(2).ToString
            txtEncabezado.Text = gvDetalleArticulos.GetDataRow(Me.gvDetalleArticulos.GetSelectedRows(0)).Item(3).ToString
            txtDescripcion.Text = gvDetalleArticulos.GetDataRow(Me.gvDetalleArticulos.GetSelectedRows(0)).Item(4).ToString
            cboUM.EditValue = gvDetalleArticulos.GetDataRow(Me.gvDetalleArticulos.GetSelectedRows(0)).Item(5)
            txtCantidad.Text = gvDetalleArticulos.GetDataRow(Me.gvDetalleArticulos.GetSelectedRows(0)).Item(7)
            txtPrecioUnitario.Text = gvDetalleArticulos.GetDataRow(Me.gvDetalleArticulos.GetSelectedRows(0)).Item(8)
            ordDetId = dtDetalleArticulos.Rows(Me.gvDetalleArticulos.GetSelectedRows(0))("ordDetId").ToString

            dtDetalleArticulos.Rows.RemoveAt(gvDetalleArticulos.GetSelectedRows(0))


            CalcularTotal()

            txtCantidad.Properties.ReadOnly = False
            txtPrecioUnitario.Properties.ReadOnly = False
            txtDescripcion.Properties.ReadOnly = False
            txtEncabezado.Properties.ReadOnly = False
           

            gvDetalleArticulos.BestFitColumns()
            GridColumn1.Width = 225

            If dtDetalleArticulos.Rows.Count > 0 Then
                btnEliminarProducto.Enabled = True
            Else
                btnEliminarProducto.Enabled = False
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If

    End Sub


    Private Sub SaimtButton1_Click(sender As System.Object, e As System.EventArgs) Handles SaimtButton1.Click
        SaveFileDialog1.Filter = "Archivos de Excel|*.xls"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            gvDetalleArticulos.ExportToXls(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnAddProcesoPresupuestario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProcesoPresupuestario.Click
        If txtMontoTotal.Text <= 0 Then
            Return
        End If
        If cboPartida.EditValue Is Nothing Then
            Return
        End If
        If IsNumeric(txtImportePresupuesto.Text) = True Then
            If CDbl(txtImportePresupuesto.Text) < 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un numero correcto")
                Return
            End If
        Else
            SaimtMessageBox.mostrarAlertaInformativa("Ingrese un numero correcto")
            Return
        End If
        If gvProcesoPresupuesto.DataRowCount > 0 Then
            For i = 0 To gvProcesoPresupuesto.DataRowCount - 1
                If gvProcesoPresupuesto.GetDataRow(i)("cerGrupoParId") = cboPartida.EditValue Then
                    SaimtMessageBox.mostrarAlertaInformativa("La partida ya se encuentra agregada, si decea cambiar el monto puede editarlo")
                    Return
                End If
            Next
        End If


        For Each row In loGrupoPartidas
            If row.cerGrupoParId = cboPartida.EditValue Then
                If txtImportePresupuesto.Text > row.cerGrupoParValQuedan Then
                    SaimtMessageBox.mostrarAlertaInformativa("El monto del importe supera al monto de la partida")
                    Return
                End If
                Exit For
            End If
        Next

        Dim total As Decimal = 0.0
        If gvProcesoPresupuesto.DataRowCount > 0 Then
            For i = 0 To gvProcesoPresupuesto.DataRowCount - 1
                total = total + CDbl(gvProcesoPresupuesto.GetDataRow(i)("importe"))
            Next
        End If

        If total + Format(CDbl(txtImportePresupuesto.Text.Trim), "##,##0.0000") <= txtMontoTotal.Text Then
            dtDetalleProceso.LoadDataRow(New Object() {cboPartida.EditValue, _
                                 cboPartida.Text, _
                                  Format(CDbl(txtImportePresupuesto.Text.Trim), "##,##0.0000")
                          }, True)

            txtMontoCertUtilizado.Text = total + Format(CDbl(txtImportePresupuesto.Text.Trim), "##,##0.0000")
            txtsaldoF.Text = Format(CDbl(txtMontoQuedaCer.Text), "##,##0.0000") - Format(CDbl(txtMontoCertUtilizado.Text), "##,##0.0000")
        Else
            SaimtMessageBox.mostrarAlertaInformativa("El monto total supera al Total de la Orde de Compra")
        End If
 
    End Sub

 
    Private Sub cboPartida_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPartida.EditValueChanged
        txtValorQuedanPartida.Properties.ReadOnly = True
        txtValorQuedanPartida.BackColor = SystemColors.Info
        If cboPartida.EditValue Is Nothing Then
            Return
        End If
        For Each row In loGrupoPartidas
            If row.cerGrupoParId = cboPartida.EditValue Then
                txtValorQuedanPartida.Text = row.cerGrupoParValQuedan
                Exit For
            End If
        Next
        ' Ayuda al calculo
        Dim total As Decimal = 0.0
        If gvProcesoPresupuesto.DataRowCount > 0 Then
            For i = 0 To gvProcesoPresupuesto.DataRowCount - 1
                total = total + gvProcesoPresupuesto.GetDataRow(i)("importe")
            Next
        End If
        If total < txtMontoTotal.Text Then
            txtImportePresupuesto.Text = txtMontoTotal.Text - total
        End If

    End Sub

    Private Sub btnEliminarPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPartida.Click
        If gvProcesoPresupuesto.DataRowCount > 0 Then
            If Len(txtOrdId.Text) > 0 And Len(gvProcesoPresupuesto.GetDataRow(gvProcesoPresupuesto.GetSelectedRows(0))("cerGrupoParId").ToString) > 0 Then
                MantenimientosBL.Instancia.ordencompraActualizaGrupoPartidasXOrdId_cerGrupoParId(txtOrdId.Text, Me.gvProcesoPresupuesto.GetDataRow(gvProcesoPresupuesto.GetSelectedRows(0))("cerGrupoParId").ToString)
                gvProcesoPresupuesto.DeleteRow(gvProcesoPresupuesto.GetRowHandle(0))

                'Actualizamos los datos de la partida
                loGrupoPartidas = MantenimientosBL.Instancia.CertificacionGrupoPartidaXcerId(txtCertificacion.Tag)
                If loGrupoPartidas IsNot Nothing Then
                    cboPartida.mColumnas(SaimtComboBoxLookUp.Entidades.Partida)
                    cboPartida.Properties.DisplayMember = "PartNombre"
                    cboPartida.Properties.ValueMember = "cerGrupoParId"
                    cboPartida.Properties.DataSource = loGrupoPartidas
                    cboPartida.ItemIndex = -1
                End If

                'Actualizamos Montos Certificacion Utilizado
                Dim total As Decimal = 0.0
                If gvProcesoPresupuesto.DataRowCount > 0 Then
                    For i = 0 To gvProcesoPresupuesto.DataRowCount
                        total = total + CDbl(gvProcesoPresupuesto.GetDataRow(i)("importe"))
                    Next
                End If
                txtMontoCertUtilizado.Text = total
                actualizaProcesoPresupuestario()
            End If
        End If
    End Sub

    Sub actualizaProcesoPresupuestario()
        If Len(txtCertificacion.Tag) > 0 Then
            MantenimientosBL.Instancia.ordencompraActualizarCertificacionLOGcerValQuedan(txtCertificacion.Tag)
            Dim ListaCertificacion As EECertificacion = MantenimientosBL.Instancia.CertificacionMostrarCertificacionXCerId(txtCertificacion.Tag)
            If ListaCertificacion IsNot Nothing Then
                txtMontoQuedaCer.Text = ListaCertificacion.CerValQuedan
            End If
        End If
    End Sub

    Private Sub btnNavOrdCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavOrdCompra.Click
        NavegacionNew(tabOrdenCompra.SelectedTabPageIndex)
    End Sub

    Private Sub btnAtrasOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasOrdenCompra.Click
        NavegacionLast(tabOrdenCompra.SelectedTabPageIndex)
    End Sub

    Private Sub SaimtButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton10.Click
        dtDocReferencia.Rows.Add()
    End Sub
    Private Sub mAgregarCombo()
        Dim RepositorioItemsTGAnio As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim RepositorioItemsTGArea As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim RepositorioItemsTGSAIMT As New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Dim dtComboTablaAnio As DataTable = New DataTable
        dtComboTablaAnio.Columns.Add("TgNombre", GetType(String))
        dtComboTablaAnio.Columns.Add("TgCodigo", GetType(String))
        dtComboTablaAnio.Columns("TgNombre").Caption = "Nombre"
        dtComboTablaAnio.Columns("TgCodigo").Caption = "Codigo"
        dtComboTablaAnio.Columns("TgCodigo").ColumnMapping = MappingType.Hidden

        Dim dtComboTablaArea As DataTable = New DataTable
        dtComboTablaArea.Columns.Add("TgNombre", GetType(String))
        dtComboTablaArea.Columns.Add("TgCodigo", GetType(String))
        dtComboTablaArea.Columns("TgNombre").Caption = "Nombre"
        dtComboTablaArea.Columns("TgCodigo").Caption = "Codigo"
        dtComboTablaArea.Columns("TgCodigo").ColumnMapping = MappingType.Hidden


        For Each fTg As EETablaGeneral In MantenimientosBL.Instancia.tablageneralListarXClsId(76)
            dtComboTablaAnio.Rows.Add(fTg.TgNombre, fTg.TgCodigo)
        Next

        For Each fTg As EETablaGeneral In MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(83, "0001")
            dtComboTablaArea.Rows.Add(fTg.TgAbrev, fTg.TgAbrev)
        Next

        With RepositorioItemsTGAnio
            .DisplayMember = "TgNombre"
            .ValueMember = "TgCodigo"
            .DataSource = dtComboTablaAnio
            .NullText = "<<Seleccione>>"
        End With

        With RepositorioItemsTGArea
            .DisplayMember = "TgNombre"
            .ValueMember = "TgCodigo"
            .DataSource = dtComboTablaArea
            .NullText = "<<Seleccione>>"
        End With

        With RepositorioItemsTGSAIMT
            .NullText = "SAIMT"
        End With

        gcolAnio.ColumnEdit = RepositorioItemsTGAnio
        RepositorioItemsTGAnio.BestFit()

        gcolArea.ColumnEdit = RepositorioItemsTGArea
        RepositorioItemsTGArea.BestFit()

        gcolSaimt.ColumnEdit = RepositorioItemsTGSAIMT
        ' RepositorioItemsTGSAIMT.BestFit()

    End Sub
    Private Sub SaimtButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton9.Click
        If Me.gvDocReferencias.DataRowCount <> 0 Then
            gvDocReferencias.DeleteRow(Me.gvDocReferencias.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaError("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub SaimtButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton8.Click
        Dim ofrm As New frmPersona("01")
        ofrm.Text = "Registrar Proveedor"
        ofrm.ShowDialog() ' Per Ref Proveedor
    End Sub


    Private Sub CheckEdit1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then
            txtPrecioUnitario.Properties.Mask.EditMask = "n4"
        Else
            txtPrecioUnitario.Properties.Mask.EditMask = "n2"
        End If
    End Sub
End Class