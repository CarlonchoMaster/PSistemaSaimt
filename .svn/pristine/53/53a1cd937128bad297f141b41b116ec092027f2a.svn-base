Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports DevExpress.XtraEditors.Repository
Public Class frmOrdenServicio
    Inherits frmMantenimientos
    Dim xl As Excel.Application
    Dim dtDetalleServicios As DataTable = New DataTable()
    Dim dtDetalleProceso As DataTable = New DataTable()
    Dim dtDocReferencia As DataTable = New DataTable()
    Dim dtListado As DataTable = New DataTable()
    Private ListaTemporal_OrdenServicioDetNuevo As List(Of EEOrdenServicio.EEOrdenServicioDet) = New List(Of EEOrdenServicio.EEOrdenServicioDet)
    Private ListaTemporal_OrdenServicioDetElimandos As List(Of String) = New List(Of String)
    Dim _pigv As Decimal
    Dim _p4ta As Decimal
    Dim ruta As String
    Dim loGrupoPartidas As List(Of EECertificacion.EECertificacionGrupoPartida)
    Dim locertificacion As EECertificacion = Nothing
    Dim locertificacioncomp As EECertificacion = Nothing

#Region "Construir Table"
    Private Sub ConstruirTableDetalleServicios()
        dtDetalleServicios.Columns.Add("ordDetId", GetType(String))
        dtDetalleServicios.Columns.Add("tgCatServId", GetType(String))
        dtDetalleServicios.Columns.Add("tgCatServ", GetType(String))
        dtDetalleServicios.Columns.Add("ordDetDescripcion", GetType(String))
        dtDetalleServicios.Columns.Add("ordDetObservacion", GetType(String))
        dtDetalleServicios.Columns.Add("ordDetPrecio", GetType(Decimal))
        dtDetalleServicios.Columns.Add("ordDetIgv", GetType(Decimal))
        dtDetalleServicios.Columns.Add("ordDetRta4ta", GetType(Decimal))
        dtDetalleServicios.Columns.Add("tgTipoAjusteId", GetType(String))
        dtDetalleServicios.Columns.Add("tgTipoAjuste", GetType(String))
        dtDetalleServicios.Columns.Add("ordDetAjuste", GetType(Decimal))
        dtDetalleServicios.Columns.Add("ordDetImporte", GetType(Decimal))
        dtDetalleServicios.Columns.Add("cerMontoUtl1", GetType(Decimal))
        dtDetalleServicios.Columns.Add("cerMontoUtl2", GetType(Decimal))
    End Sub
    Private Sub ConstruirTableDocRef()
        dtDocReferencia.Columns.Add("documento", GetType(String))
        dtDocReferencia.Columns.Add("anio", GetType(String))
        dtDocReferencia.Columns.Add("saimt", GetType(String))
        dtDocReferencia.Columns.Add("area", GetType(String))

    End Sub
    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("OrdId", GetType(String))
        dtListado.Columns.Add("OrdNro", GetType(String))
        dtListado.Columns.Add("OrdFechaDoc", GetType(Date))
        dtListado.Columns.Add("TgEstado", GetType(String))
    End Sub


    Private Sub ConstruirTableDetalleProcesoPresupuestario()
        dtDetalleProceso.Columns.Add("cerGrupoParId", GetType(String))
        dtDetalleProceso.Columns.Add("cerId", GetType(String))
        dtDetalleProceso.Columns.Add("certificacion", GetType(String))
        dtDetalleProceso.Columns.Add("partida", GetType(String))
        dtDetalleProceso.Columns.Add("importe", GetType(Decimal))

    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvListado.DataRowCount <> 0 Then
                Dim loOrdenServicio As EEOrdenServicio = MantenimientosBL.Instancia.ordenServicioListarxOrdId(gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "OrdId").ToString())
                If loOrdenServicio IsNot Nothing Then
                    GIndiceSeleccionado = Me.gvListado.GetSelectedRows(0)
                    txtOrdId.Text = loOrdenServicio.OrdId
                    txtNroOrdenServicio.Text = loOrdenServicio.OrdNro
                    dtpFechaDoc.EditValue = loOrdenServicio.OrdFechaDoc
                    cboEstadoOrdenServicio.EditValue = loOrdenServicio.TgEstadoId
                    cboComprobantePago.EditValue = loOrdenServicio.TgCompPagoId
                    txtNroComprobante.Text = loOrdenServicio.OrdNroCompPago
                    txtProveedor.Text = loOrdenServicio.PerProv
                    txtProveedor.Tag = loOrdenServicio.PerProvId
                    Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaConsultarProveedorCriterios(1, txtProveedor.Text)
                    If ListaPersona IsNot Nothing Then
                        txtDireccionProveedor.EditValue = ListaPersona.Item(0).PerDireccion
                        txtNroDocumentoProveedor.EditValue = ListaPersona.Item(0).PerNDoc
                    End If
                    txtReferenciaDoc.Text = loOrdenServicio.OrdRefDoc
                    txtCuentaDebe.Tag = loOrdenServicio.TgCuentaDebeId
                    txtCuentaDebe.EditValue = loOrdenServicio.PlanCDDescripcion
                    txtMontoDebe.Text = loOrdenServicio.TgCuentaDebe
                    txtCuentaHaber.Tag = loOrdenServicio.TgCuentaHaberId
                    txtCuentaHaber.EditValue = loOrdenServicio.PlanCHDescripcion
                    txtMontoHaber.Text = loOrdenServicio.TgCuentaHaber
                    '-------------------------------------------------
                    txtCertificacion.Tag = loOrdenServicio.CerId
                    txtCertificacion.Text = loOrdenServicio.CerNro
                    txtMontoTotalCer.Text = loOrdenServicio.CerValTotal
                    '-------------------------------------------------
                    txtCertificacionComp.Tag = loOrdenServicio.CerCompId
                    txtCertificacionComp.Text = loOrdenServicio.CerCompNro
                    txtMontoTotalCerComp.Text = loOrdenServicio.CerCompValTotal
                    txtsaldoI.EditValue = loOrdenServicio.OrdSaldoI
                    txtsaldoF.EditValue = loOrdenServicio.OrdSaldoF
                    '-------------------------------------------------
                    txtSubTotal.EditValue = loOrdenServicio.OrdSubTotal
                    txtIgv.EditValue = loOrdenServicio.OrdImporteIGV
                    txtRta4ta.EditValue = loOrdenServicio.ordRta4taTotal
                    txtAjuste.EditValue = loOrdenServicio.OrdAjusteTotal
                    txtMontoTotal.EditValue = loOrdenServicio.OrdTotal

                    If Len(loOrdenServicio.CerCompId) > 0 Then
                        txtMontoCertUtilizadoComp.Text = loOrdenServicio.CerCompValUtilizado
                        txtMontoQuedaCerComp.Text = loOrdenServicio.CerCompValQuedan
                    Else
                        ' txtMontoCertUtilizadoComp.Tag = 0.0
                        txtMontoCertUtilizadoComp.Text = 0.0
                    End If
                    If Len(loOrdenServicio.CerId) > 0 Then
                        txtMontoCertUtilizado.Text = loOrdenServicio.CerValUtilizado
                        txtMontoQuedaCer.Text = loOrdenServicio.CerValQuedan
                    Else
                        txtMontoQuedaCerComp.Text = 0.0
                        'txtMontoQuedaCerComp.Tag = 0.0
                    End If
                    '--------------------------------------------------

                    '----------------------------------------------------
                    LimpiarControlesAdd()
                    dtDetalleServicios.Clear()
                    ListaTemporal_OrdenServicioDetNuevo.Clear()
                    ListaTemporal_OrdenServicioDetElimandos.Clear()

                    Dim ordenServicioDet As List(Of EEOrdenServicio.EEOrdenServicioDet) = MantenimientosBL.Instancia.ordenServicioDetXOrdId(txtOrdId.Text)
                    dtDetalleServicios.Clear()
                    If ordenServicioDet IsNot Nothing Then
                        For Each frow As EEOrdenServicio.EEOrdenServicioDet In ordenServicioDet
                            Dim vAjuste As Decimal = 0.0
                            Dim vImportet As Decimal = 0.0
                            If frow.OrdDetIgv = 0 Then
                                vImportet = Format((frow.OrdDetPrecio - frow.OrdDetRta4ta), "##,##0.00")
                            Else
                                'vImportet = Format(frow.OrdDetPrecio * (1 + loOrdenServicio.OrdParIGV) - frow.ordDetRta4ta, "##,##0.00")
                                vImportet = Format((frow.OrdDetPrecio + frow.OrdDetIgv - frow.OrdDetRta4ta), "##,##0.00")
                            End If

                            If frow.tgTipoAjusteId IsNot Nothing Then
                                vAjuste = IIf(frow.tgTipoAjusteId = "A", vImportet + CDbl(frow.OrdDetAjuste), vImportet - CDbl(frow.OrdDetAjuste))
                            Else
                                vAjuste = vImportet
                            End If
                            dtDetalleServicios.LoadDataRow(New Object() {frow.OrdDetId, _
                                                                         frow.TgCatServId, _
                                                                         frow.TgCatServ, _
                                                                         frow.OrdDetDescripcion, _
                                                                         frow.OrdDetObservacion, _
                                                                         frow.OrdDetPrecio, _
                                                                         frow.OrdDetIgv, _
                                                                         frow.OrdDetRta4ta, _
                                                                         frow.tgTipoAjusteId, _
                                                                         frow.tgTipoAjuste, _
                                                                         frow.OrdDetAjuste, _
                                                                         vAjuste, _
                                                                         frow.OrdDetMontoCertUtl1, _
                                                                         frow.OrdDetMontoCertUtl2},
                                                                     True)
                        Next

                    End If
                    gvDetalleServicios.BestFitColumns()

                    dtDetalleProceso.Clear()
                    Dim ordenServicioGrupoPartidas As List(Of EEOrdenServicio.EEOrdenServicioGrupoPartidas) = MantenimientosBL.Instancia.ordenservicioGrupoPartidaXOrdId(txtOrdId.Text)
                    If ordenServicioGrupoPartidas IsNot Nothing Then
                        Dim totalUtl As Decimal = 0
                        For Each frow As EEOrdenServicio.EEOrdenServicioGrupoPartidas In ordenServicioGrupoPartidas


                            dtDetalleProceso.LoadDataRow(New Object() {frow.cerGrupoParId, _
                                                                       frow.CerId, _
                                                                       frow.Certificacion, _
                                                                       frow.Partida, _
                                                                       Format(frow.cerGrupoParValImporte, "##,##0.00")
                                                                        }, True)
                            totalUtl = totalUtl + frow.cerGrupoParValImporte

                        Next
                        txtMontoCertUtilizado.Text = totalUtl
                    End If

                    ' Referencias del Documento
                    dtDocReferencia.Clear()
                    Dim ordenCompraDocReferencias As List(Of EEOrdenServicio.EEOrdenServicioDocRef) = MantenimientosBL.Instancia.ordenServicioDocRefXOrdId(txtOrdId.Text)
                    If ordenCompraDocReferencias IsNot Nothing Then
                        For Each frow As EEOrdenServicio.EEOrdenServicioDocRef In ordenCompraDocReferencias
                            dtDocReferencia.LoadDataRow(New Object() {frow.documento, _
                                                                       frow.año, _
                                                                      "SAIMT", _
                                                                       frow.area}, True)

                        Next
                    End If

                    ' Limpiamos 
                    For i = 0 To chkListaAreas.ItemCount
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
                End If
            End If

            MyBase.seleccionarListado()
            cboTipoAjuste.EditValue = ""
            chkRta4ta.Checked = False
            chkAfecto.Checked = False
            btnImprimir.Enabled = True
            txtValAjuste.Properties.ReadOnly = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            If String.IsNullOrEmpty(txtNroOrdenServicio.EditValue) Then
                txtNroOrdenServicio.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro de Orden Servicio")
                Return
            End If
            If String.IsNullOrEmpty(txtProveedor.Tag) Then
                txtProveedor.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado al proveedor")
                Return
            End If

            If dtDetalleServicios.Rows.Count < 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Debe haber un detalle como minimo para guardar")
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


            Dim loOrdenServicio As EEOrdenServicio = New EEOrdenServicio()
            loOrdenServicio.OrdId = txtOrdId.Text
            loOrdenServicio.OrdNro = txtNroOrdenServicio.Text
            loOrdenServicio.OrdFechaDoc = dtpFechaDoc.EditValue
            loOrdenServicio.TgEstadoId = cboEstadoOrdenServicio.EditValue
            loOrdenServicio.OrdNroCompPago = txtNroComprobante.EditValue
            loOrdenServicio.TgCompPagoId = cboComprobantePago.EditValue
            loOrdenServicio.OrdRefDoc = txtReferenciaDoc.Text
            loOrdenServicio.PerProvId = txtProveedor.Tag
            'costos totales
            loOrdenServicio.OrdImporteIGV = CDbl(txtIgv.Text)
            loOrdenServicio.ordRta4taTotal = CDbl(txtRta4ta.Text)
            loOrdenServicio.OrdAjusteTotal = CDbl(txtAjuste.Text)
            loOrdenServicio.OrdSubTotal = CDbl(txtSubTotal.Text)
            loOrdenServicio.OrdTotal = CDbl(txtMontoTotal.Text)
            loOrdenServicio.OrdParIGV = _pigv
            loOrdenServicio.OrdSaldoI = txtsaldoI.Text
            loOrdenServicio.OrdSaldoF = txtsaldoF.Text
            ' Proceso patrimonial
            loOrdenServicio.TgCuentaDebeId = txtCuentaDebe.Tag
            loOrdenServicio.TgCuentaDebe = CDec(txtMontoDebe.Text)

            loOrdenServicio.TgCuentaHaberId = txtCuentaHaber.Tag
            loOrdenServicio.TgCuentaHaber = CDbl(txtMontoHaber.Text)
            'proceso presupuestario
            loOrdenServicio.CerId = txtCertificacion.Tag
            loOrdenServicio.CerCompId = txtCertificacionComp.Tag


            Dim loOrdenServicioDet As EEOrdenServicio.EEOrdenServicioDet
            loOrdenServicio.ListaOrdenServicioDet = New List(Of EEOrdenServicio.EEOrdenServicioDet)
            ListaTemporal_OrdenServicioDetNuevo.Clear()
            For Each frowDet As DataRow In dtDetalleServicios.Rows
                loOrdenServicioDet = New EEOrdenServicio.EEOrdenServicioDet
                loOrdenServicioDet.OrdDetId = frowDet("ordDetId")
                loOrdenServicioDet.OrdId = txtOrdId.EditValue
                loOrdenServicioDet.TgCatServId = frowDet("tgCatServId")
                loOrdenServicioDet.OrdDetDescripcion = frowDet("ordDetDescripcion").ToString
                loOrdenServicioDet.OrdDetObservacion = frowDet("ordDetObservacion").ToString
                loOrdenServicioDet.OrdDetPrecio = CDbl(frowDet("ordDetPrecio"))
                loOrdenServicioDet.OrdDetIgv = CDbl(frowDet("ordDetIgv"))
                loOrdenServicioDet.OrdDetRta4ta = CDbl(frowDet("ordDetRta4ta"))
                loOrdenServicioDet.tgTipoAjusteId = frowDet("tgTipoAjusteId").ToString
                loOrdenServicioDet.OrdDetAjuste = CDbl(frowDet("ordDetAjuste"))
                ListaTemporal_OrdenServicioDetNuevo.Add(loOrdenServicioDet)
            Next
            loOrdenServicio.ListaOrdenServicioDet = ListaTemporal_OrdenServicioDetNuevo

            Dim loOrdenCompraGrupoPartidas As EEOrdenServicio.EEOrdenServicioGrupoPartidas
            Dim ListaOrdenCompraGrupoPartidas = New List(Of EEOrdenServicio.EEOrdenServicioGrupoPartidas)
            loOrdenServicio.ListaOrdenServicioGrupoPartidas = New List(Of EEOrdenServicio.EEOrdenServicioGrupoPartidas)
            'For Each frowDet As DataRow In dtDetalleProceso.Rows
            For i = 0 To gvProcesoPresupuesto.DataRowCount - 1
                loOrdenCompraGrupoPartidas = New EEOrdenServicio.EEOrdenServicioGrupoPartidas
                loOrdenCompraGrupoPartidas.cerGrupoParId = gvProcesoPresupuesto.GetDataRow(i)("cerGrupoParId")
                loOrdenCompraGrupoPartidas.cerGrupoParValImporte = gvProcesoPresupuesto.GetDataRow(i)("importe")
                tpartidas = tpartidas + gvProcesoPresupuesto.GetDataRow(i)("importe")
                ListaOrdenCompraGrupoPartidas.Add(loOrdenCompraGrupoPartidas)
            Next
            loOrdenServicio.ListaOrdenServicioGrupoPartidas = ListaOrdenCompraGrupoPartidas

            ' Areas de Referencia
            Dim ListaOrdenServicioAreaRef = New List(Of EEOrdenServicio.EEOrdenServicioAreaRef)
            loOrdenServicio.ListaOrdenServicioAreaRef = New List(Of EEOrdenServicio.EEOrdenServicioAreaRef)
            Dim loOrdenServicioAreaRef As EEOrdenServicio.EEOrdenServicioAreaRef

            For i = 0 To chkListaAreas.CheckedItemsCount
                loOrdenServicioAreaRef = New EEOrdenServicio.EEOrdenServicioAreaRef
                loOrdenServicioAreaRef.tgAreaId = chkListaAreas.CheckedItems(i)
                ListaOrdenServicioAreaRef.Add(loOrdenServicioAreaRef)
            Next
            loOrdenServicio.ListaOrdenServicioAreaRef = ListaOrdenServicioAreaRef

            ' Documento de Referencia
            Dim ListaOrdenServicioDocRef = New List(Of EEOrdenServicio.EEOrdenServicioDocRef)
            loOrdenServicio.ListaOrdenServicioDocRef = New List(Of EEOrdenServicio.EEOrdenServicioDocRef)
            Dim loOrdenServicioDocRef As EEOrdenServicio.EEOrdenServicioDocRef

            For i = 0 To gvDocReferencias.DataRowCount - 1
                loOrdenServicioDocRef = New EEOrdenServicio.EEOrdenServicioDocRef
                loOrdenServicioDocRef.documento = gvDocReferencias.GetDataRow(i)("documento")
                loOrdenServicioDocRef.area = gvDocReferencias.GetDataRow(i)("area")
                loOrdenServicioDocRef.año = gvDocReferencias.GetDataRow(i)("anio")
                ListaOrdenServicioDocRef.Add(loOrdenServicioDocRef)
            Next
            loOrdenServicio.ListaOrdenServicioDocRef = ListaOrdenServicioDocRef


            If GEstadoNuevo Then
                MantenimientosBL.Instancia.ordenServicioGuardar(loOrdenServicio)
            Else
                loOrdenServicio.Lista_OrdenServicioDetElimnados = ListaTemporal_OrdenServicioDetElimandos
                MantenimientosBL.Instancia.ordenServicioActualizar(loOrdenServicio)
            End If
            ListaTemporal_OrdenServicioDetNuevo.Clear()
            ListaTemporal_OrdenServicioDetElimandos.Clear()
            dtDetalleServicios.Clear()
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
                    If String.IsNullOrEmpty(txtNroOrdenServicio.EditValue) Then
                        txtNroOrdenServicio.Focus()
                        SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro de Orden Servicio")
                        Return
                    End If
                    If String.IsNullOrEmpty(dtpFechaDoc.EditValue) Then
                        dtpFechaDoc.Focus()
                        SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese la fecha de la Orden de Servicio")
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
                    If dtDetalleServicios.Rows.Count = 0 Then
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
            btnAtrasOrdenServicio.Enabled = False
        Else
            btnAtrasOrdenServicio.Enabled = True
        End If

        tabOrdenCompra.SelectedTabPageIndex = (Index + 1)
        tabOrdenCompra.TabPages(Index + 1).PageVisible = True
        btnGuardar.Enabled = False

        If tabOrdenCompra.TabPages.Count - 1 = Index + 1 Then
            btnGuardar.Enabled = True
            btnNavOrdServicio.Enabled = False
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
                btnAtrasOrdenServicio.Enabled = False
                btnNavOrdServicio.Enabled = True
            End If
        End If
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        dtDetalleProceso.Clear()
        dtDetalleServicios.Clear()
        dtDocReferencia.Clear()
        txtOrdId.EditValue = MantenimientosBL.Instancia.ordenServicioGeneraCodigo
        txtOrdId.Properties.ReadOnly = True
        'txtNroOrdenServicio.EditValue = MantenimientosBL.Instancia.ordenServicioGeneraCodigoSAIMT
        txtNroOrdenServicio.Properties.ReadOnly = False
        cboEstadoOrdenServicio.EditValue = "4"
        cboEstadoOrdenServicio.Properties.ReadOnly = True
        txtProveedor.Properties.ReadOnly = True
        txtNroDocumentoProveedor.Properties.ReadOnly = True
        txtServicio.Properties.ReadOnly = True
        'txtValIgv.Properties.ReadOnly = True
        txtValRta4taCat.Properties.ReadOnly = True
        txtValImporte.Properties.ReadOnly = True
        txtValAjuste.Properties.ReadOnly = True
        txtDescripcionServicio.Properties.ReadOnly = True
        txtObservacion.Properties.ReadOnly = True
        cboTipoAjuste.Properties.ReadOnly = True
        txtSubTotal.Properties.ReadOnly = True
        txtIgv.Properties.ReadOnly = True
        txtRta4ta.Properties.ReadOnly = True
        txtAjuste.Properties.ReadOnly = True
        txtMontoTotal.Properties.ReadOnly = True
        txtCuentaDebe.Properties.ReadOnly = True
        txtCuentaHaber.Properties.ReadOnly = True
        ' txtPartida.Properties.ReadOnly = True
        txtDireccionProveedor.Properties.ReadOnly = True
        txtCertificacion.Properties.ReadOnly = True
        txtMontoTotalCer.Properties.ReadOnly = True
        txtMontoQuedaCer.Properties.ReadOnly = True
        txtCertificacionComp.Properties.ReadOnly = True
        txtMontoTotalCerComp.Properties.ReadOnly = True
        txtMontoQuedaCerComp.Properties.ReadOnly = True
        txtMontoDebe.Properties.ReadOnly = True
        txtMontoHaber.Properties.ReadOnly = True
        ' txtImportePresupuesto.Properties.ReadOnly = True
        txtMontoCertUtilizado.Properties.ReadOnly = True
        txtMontoCertUtilizadoComp.Properties.ReadOnly = True

        btnImprimir.Enabled = False
        chkRta4ta.Checked = False
        txtServicio.Tag = Nothing
        txtServicio.Text = Nothing
        txtValImporte.Text = 0
        txtMontoCertUtilizado.Tag = 0
        txtMontoCertUtilizadoComp.Tag = 0
        btnAgregarServicio.Enabled = False
        btnAddServicio.Enabled = False
        btnEliminarServicio.Enabled = False

        chkRta4ta.Properties.ReadOnly = True
        chkAfecto.Properties.ReadOnly = True
        chkRta4ta.Checked = False
        chkAfecto.Checked = False
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()

        txtOrdId.Properties.ReadOnly = True
        txtServicio.Properties.ReadOnly = True
        txtSubTotal.Properties.ReadOnly = True
        txtIgv.Properties.ReadOnly = True
        txtRta4ta.Properties.ReadOnly = True
        txtAjuste.Properties.ReadOnly = True
        txtValRta4taCat.Properties.ReadOnly = True
        txtValImporte.Properties.ReadOnly = True
        txtValAjuste.Properties.ReadOnly = True
        txtDescripcionServicio.Properties.ReadOnly = True
        txtObservacion.Properties.ReadOnly = True
        cboTipoAjuste.Properties.ReadOnly = True
        txtMontoTotal.Properties.ReadOnly = True
        txtCuentaDebe.Properties.ReadOnly = True
        txtCuentaHaber.Properties.ReadOnly = True
        ' txtPartida.Properties.ReadOnly = True
        txtMontoDebe.Properties.ReadOnly = True
        txtMontoHaber.Properties.ReadOnly = True
        ' txtImportePresupuesto.Properties.ReadOnly = True
        txtMontoTotalCer.Properties.ReadOnly = True
        txtMontoTotalCerComp.Properties.ReadOnly = True
        txtNroOrdenServicio.Properties.ReadOnly = False
        txtNroDocumentoProveedor.Properties.ReadOnly = True
        txtDireccionProveedor.Properties.ReadOnly = True
        txtCertificacionComp.Properties.ReadOnly = True
        txtReferenciaDocComp.Properties.ReadOnly = True
        btnImprimir.Enabled = False
        btnConsultarCertificacion.Enabled = False
        btnConsultarCertificacionComp.Enabled = False
        txtValImporte.Text = "#,##0.00"
        chkRta4ta.Properties.ReadOnly = True
        chkAfecto.Properties.ReadOnly = True
        chkRta4ta.Checked = False
        chkAfecto.Checked = False

        gcImporte.OptionsColumn.ReadOnly = False
    End Sub

    Protected Overrides Sub Buscar()
        Try
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterio.SelectedIndex
            If GCriterioBuscado = 5 Then
                GValorTextoBuscado = cboBuscarPorEstado.EditValue
            End If
            Dim loOrdenServicio As List(Of EEOrdenServicio) = MantenimientosBL.Instancia.ordenServicioListarCriterio(GCriterioBuscado, GValorTextoBuscado, cboAnioCriterio.EditValue)

            dtListado.Clear()
            dtDetalleServicios.Clear()
            If loOrdenServicio IsNot Nothing Then
                For Each frow As EEOrdenServicio In loOrdenServicio
                    dtListado.LoadDataRow(New Object() {frow.OrdId, _
                    frow.OrdNro, _
                    frow.OrdFechaDoc, _
                    frow.TgEstado
                    }, True)
                Next
                gvListado.BestFitColumns()
                gvListado.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
            cboBuscarPorEstado.Properties.ReadOnly = IIf(cboCriterio.SelectedIndex = 5, False, True)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub imprimir()
        Try

            xl = EEExcel.Instancia
            xl.Workbooks.Open(EEComun.RutaReportes & "\RptOrdenesServicio2013.xls", 1, True, 4)
            ExportarOrdenServicio()
            If fbdExportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ruta = String.Format("{0}\OrdenCompra_{1}", fbdExportar.SelectedPath, txtNroOrdenServicio.Text.Trim & "-" & dtpFechaDoc.DateTime.Year)
                xl.ActiveWorkbook.SaveAs(ruta)
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada con el nombre OrdenCompra_" & txtNroOrdenServicio.Text.Trim & "-" & dtpFechaDoc.DateTime.Year
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

    Private Sub ExportarOrdenServicio()
        xl.Sheets(xl.Worksheets("OrdenServicio").Index).Select()
        xl.Range("F1").Value = "ORDEN DE SERVICIO"
        xl.Range("F2").Value = "RUC 20481297223"
        xl.Range("F2").Font.Bold = True
        xl.Range("C4").Value = txtNroOrdenServicio.EditValue
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

        Dim FilaServicios As String = "A14"
        Dim FilaObservacion As String = "A15"
        Dim FilaAfecto As String = "J20"
        Dim FilaSubTotal As String = "N19"
        Dim FilaRta4taCat As String = "M20"
        Dim FilaMontoRta4taCat As String = "N20"
        Dim FilaMontoIGV As String = "N21"
        Dim FilaIGV As String = "M21"
        Dim FilaAjuste As String = "M22"
        Dim FilaMontoAjuste As String = "N22"
        Dim FilaTotal As String = "N23"
        Dim FilaSon As String = "B23"
        Dim FilaPrecioUnitario As String = "M14"
        Dim FilaPrecioTotal As String = "N14"
        Dim FilaCDebe As String = "B26"
        Dim FilaDebe As String = "C26"
        Dim FilaCHaber As String = "F26"
        Dim FilaHaber As String = "I26"
        Dim FilaAct As String = "J26"
        Dim FilaMeta As String = "K26"
        Dim FilaFF As String = "L26"
        Dim FilaPartida As String = "M26"
        Dim FilaImporte As String = "O26"

        Dim fila As Integer = 14
        Dim i As Integer = 13

        For Each fTablaDetalleServicios As DataRow In dtDetalleServicios.Rows
            FilaServicios = "A" & fila
            xl.Range(FilaServicios).Value = fTablaDetalleServicios("tgCatServ") & " " & fTablaDetalleServicios("ordDetDescripcion")
            xl.Range(FilaServicios).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            If fTablaDetalleServicios("ordDetObservacion") <> "" Then
                FilaObservacion = "A" & fila + 1
                xl.Range(FilaObservacion).Value = fTablaDetalleServicios("ordDetObservacion")
                xl.Range(FilaObservacion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End If

            FilaPrecioUnitario = "N" & fila
            xl.Range(FilaPrecioUnitario).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xl.Range(FilaPrecioUnitario).Value = fTablaDetalleServicios("ordDetPrecio")
            fila = fila + 1
            i = i + 1
        Next
        xl.Range(FilaSubTotal).Value = txtSubTotal.Text
        xl.Range(FilaSubTotal).Font.Bold = True
        xl.Range(FilaSubTotal).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        Dim Rta4taCat As Decimal = MantenimientosBL.Instancia.parametroMostrarXClsId(178)
        xl.Range(FilaRta4taCat).Value = String.Format("({0}%)", CInt(Rta4taCat * 100))
        xl.Range(FilaRta4taCat).Font.Bold = True
        xl.Range(FilaRta4taCat).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        If txtRta4ta.EditValue <> 0 Then
            xl.Range(FilaAfecto).Value = "SI"
            xl.Range(FilaAfecto).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Else
            xl.Range(FilaAfecto).Value = "NO"
            xl.Range(FilaAfecto).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        xl.Range(FilaMontoRta4taCat).Value = txtRta4ta.Text
        xl.Range(FilaMontoRta4taCat).Font.Bold = True
        xl.Range(FilaMontoRta4taCat).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        Dim igv As Decimal = MantenimientosBL.Instancia.parametroMostrarXClsId(42)
        xl.Range(FilaIGV).Value = String.Format("({0}%)", CInt(igv * 100))
        xl.Range(FilaIGV).Font.Bold = True
        xl.Range(FilaIGV).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        xl.Range(FilaMontoIGV).Value = txtIgv.EditValue
        xl.Range(FilaMontoIGV).Font.Bold = True
        xl.Range(FilaMontoIGV).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        xl.Range(FilaMontoAjuste).Value = txtAjuste.EditValue
        xl.Range(FilaMontoAjuste).Font.Bold = True
        xl.Range(FilaMontoAjuste).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        xl.Range(FilaTotal).Value = txtMontoTotal.Text
        xl.Range(FilaTotal).Font.Bold = True

        xl.Range(FilaSon).Value = String.Format("{0} NUEVOS SOLES", UCase(EEComun.MonedaLetras(txtMontoTotal.Text)))
        xl.Range(FilaSon).Font.Bold = True
        xl.Range(FilaSon).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        If txtCuentaDebe.Tag <> "" Then
            xl.Range(FilaCDebe).Value = txtCuentaDebe.Tag.ToString.Substring(4)
            xl.Range(FilaCDebe).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Else
            xl.Range(FilaCDebe).Value = "-"
            xl.Range(FilaCDebe).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        xl.Range(FilaDebe).Value = txtMontoDebe.Text
        xl.Range(FilaDebe).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        If txtCuentaHaber.Tag <> "" Then
            xl.Range(FilaCHaber).Value = txtCuentaHaber.Tag.ToString.Substring(4)
            xl.Range(FilaCHaber).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Else
            xl.Range(FilaCHaber).Value = "-"
            xl.Range(FilaCHaber).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        xl.Range(FilaHaber).Value = txtMontoHaber.Text
        xl.Range(FilaHaber).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        xl.Range(FilaAct).Value = cboActProy.EditValue
        xl.Range(FilaAct).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        xl.Range(FilaMeta).Value = cboMeta.EditValue
        xl.Range(FilaMeta).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        xl.Range(FilaFF).Value = cboFuenteFinanciera.EditValue
        xl.Range(FilaFF).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'If txtPartida.Tag <> "" Then
        '    xl.Range(FilaPartida).Value = txtPartida.Tag.ToString
        '    xl.Range(FilaPartida).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'Else
        '    xl.Range(FilaPartida).Value = "-"
        '    xl.Range(FilaPartida).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'End If

        '  xl.Range(FilaImporte).Value = txtImportePresupuesto.Text
        xl.Range(FilaImporte).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub
#End Region

    Private Sub frmPedidoServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        _p4ta = MantenimientosBL.Instancia.parametroMostrarXClsId(178)
        _pigv = MantenimientosBL.Instancia.parametroMostrarXClsId(42)
        cboComprobantePago.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboComprobantePago.Properties.DisplayMember = "TgNombre"
        cboComprobantePago.Properties.ValueMember = "TgCodigo"
        cboComprobantePago.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(182)
        cboComprobantePago.ItemIndex = -1

        cboTipoAjuste.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoAjuste.Properties.DisplayMember = "TgNombre"
        cboTipoAjuste.Properties.ValueMember = "TgCodigo"
        cboTipoAjuste.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(174)
        cboTipoAjuste.ItemIndex = -1

        cboEstadoOrdenServicio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoOrdenServicio.Properties.DisplayMember = "TgNombre"
        cboEstadoOrdenServicio.Properties.ValueMember = "TgCodigo"
        cboEstadoOrdenServicio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(128)
        cboEstadoOrdenServicio.ItemIndex = -1

        cboBuscarPorEstado.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboBuscarPorEstado.Properties.DisplayMember = "TgNombre"
        cboBuscarPorEstado.Properties.ValueMember = "TgCodigo"
        cboBuscarPorEstado.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(128)
        cboBuscarPorEstado.ItemIndex = -1

        cboAnioCriterio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAnioCriterio.Properties.DisplayMember = "TgNombre"
        cboAnioCriterio.Properties.ValueMember = "TgCodigo"
        cboAnioCriterio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(76)
        cboAnioCriterio.EditValue = CStr(Date.Now.Year)


        cboFuenteFinanciera.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboFuenteFinanciera.Properties.DisplayMember = "TgNombre"
        cboFuenteFinanciera.Properties.ValueMember = "TgCodigo"
        cboFuenteFinanciera.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(23)
        cboFuenteFinanciera.ItemIndex = -1
        cboFuenteFinanciera.Properties.ReadOnly = False

        cboMeta.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboMeta.Properties.DisplayMember = "TgNombre"
        cboMeta.Properties.ValueMember = "TgCodigo"
        cboMeta.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(136)
        cboMeta.ItemIndex = -1
        cboMeta.Properties.ReadOnly = False

        cboActProy.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboActProy.Properties.DisplayMember = "TgNombre"
        cboActProy.Properties.ValueMember = "TgCodigo"
        cboActProy.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(135)
        cboActProy.ItemIndex = -1
        cboActProy.Properties.ReadOnly = False

        ConstruirTableDetalleServicios()
        dgvDetalleServicios.DataSource = dtDetalleServicios

        ConstruirTableListado()
        dgvListadoOrdenServicio.DataSource = dtListado


        ConstruirTableDetalleProcesoPresupuestario()
        dgvProcesoPresupuesto.DataSource = dtDetalleProceso

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

    Private Sub btnAgregarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarServicio.Click
        Using fmConsultaServicio As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(106, "02")
            If fmConsultaServicio.ShowDialog() = DialogResult.OK Then
                txtServicio.Text = fmConsultaServicio.TgNombre
                txtServicio.Tag = fmConsultaServicio.TgCodigo
            End If
            If fmConsultaServicio.TgCodigo IsNot Nothing Then
                txtValImporte.Properties.ReadOnly = False
                cboTipoAjuste.Properties.ReadOnly = False
                txtDescripcionServicio.Properties.ReadOnly = False
                txtObservacion.Properties.ReadOnly = False
                chkAfecto.Properties.ReadOnly = False
                chkRta4ta.Properties.ReadOnly = False
                If Len(txtCertificacionComp.Tag) > 0 Then
                    txtDetMontoCer1.Visible = True
                    txtDetMontoCer2.Visible = True
                    lblDetCert1.Visible = True
                    lblDetCert2.Visible = True
                End If
            Else
                txtValImporte.Properties.ReadOnly = True
                cboTipoAjuste.Properties.ReadOnly = True
            End If
        End Using
    End Sub

    'Private Sub dgvDetalleServicios_FocusedViewChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.ViewFocusEventArgs)
    '    Try
    '        If Not IsNumeric(gvDetalleServicios.GetRowCellValue(Me.gvDetalleServicios.GetSelectedRows(0), "tgCatServId")) Then
    '            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese una descripción")
    '            Return
    '        End If
    '        If Not IsNumeric(gvDetalleServicios.GetRowCellValue(Me.gvDetalleServicios.GetSelectedRows(0), "ordDetPrecio")) Then
    '            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese un Valor Numero en el Precio Unitario")
    '            Return
    '        End If
    '        txtSubTotal.EditValue = 0
    '        For Each frow As DataRow In dtDetalleServicios.Rows
    '            txtSubTotal.EditValue = txtSubTotal.EditValue + CDbl(frow("ordDetPrecio"))
    '        Next
    '        txtMontoTotal.Text = txtSubTotal.Text + (txtSubTotal.Text * MantenimientosBL.Instancia.parametroMostrarXClsId(42))
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub btnEliminarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarServicio.Click
        If Me.gvDetalleServicios.DataRowCount <> 0 Then
            If dtDetalleServicios.Rows(Me.gvDetalleServicios.GetSelectedRows(0))("ordDetId").ToString() > 0 Then
                If ListaTemporal_OrdenServicioDetElimandos Is Nothing Then
                    ListaTemporal_OrdenServicioDetElimandos = New List(Of String)
                End If
                Dim ordDetId As String = dtDetalleServicios.Rows(Me.gvDetalleServicios.GetSelectedRows(0))("ordDetId").ToString
                ListaTemporal_OrdenServicioDetElimandos.Add(ordDetId)
            End If
            If ListaTemporal_OrdenServicioDetElimandos IsNot Nothing Then
                If ListaTemporal_OrdenServicioDetNuevo.Count > 0 Then
                    Dim liIndiceNuevoModificar As Int16 = 0
                    Dim liFila As Int16 = -1
                    For Each fTablaGeneral As DataRow In dtDetalleServicios.Rows
                        If String.IsNullOrEmpty(fTablaGeneral("ordDetId")) And Me.gvDetalleServicios.FocusedRowHandle = liFila Then
                            liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                        End If
                        liFila = liFila + 1
                    Next
                    ListaTemporal_OrdenServicioDetNuevo.RemoveAt(liIndiceNuevoModificar)
                End If
            End If
            dtDetalleServicios.Rows.RemoveAt(Me.gvDetalleServicios.GetSelectedRows(0))
            CalCuloDeTotales()
            LimpiarControlesAdd()
            If dtDetalleServicios.Rows.Count > 0 Then
                btnEliminarServicio.Enabled = True
            Else
                btnEliminarServicio.Enabled = False
            End If

        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
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

    Private Sub btnConsultarPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As frmConsultarPartida = New frmConsultarPartida()
        If frm.ShowDialog Then
            'If frm.PartPIM <> 0 Then
            '    txtPartida.Tag = frm.PartIdCompuesta
            '    txtPartida.Text = String.Format("{0} - {1}", frm.PartId, frm.PartNombre)
            'Else
            '    SaimtMessageBox.mostrarAlertaAdvertencia("La Partida Seleccionada no Tiene Monto PIM Asignado")
            'End If
        End If
    End Sub


    Private Sub btnAddServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddServicio.Click
        If txtServicio.Tag Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("Seleccione un Servicio")
            Return
        End If
        If txtDescripcionServicio.Text Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("Ingrese la descripcion del Servicio")
            txtDescripcionServicio.Focus()
            Return
        End If

        If IsNumeric(txtValImporte.EditValue) = True Then
            If CDbl(txtValImporte.EditValue) < 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor correcto en el Valor Importe")
                Return
            Else
                If Len(txtCertificacionComp.Tag) > 0 Then
                    If IsNumeric(txtDetMontoCer1.EditValue) = True And IsNumeric(txtDetMontoCer2.EditValue) = True Then
                        If CDbl(txtDetMontoCer1.EditValue) + CDbl(txtDetMontoCer2.EditValue) <> CDbl(txtValImporte.EditValue) Then
                            SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor correcto en el Valor de Certificaciones")
                            Return
                        End If
                    End If
                End If
            End If
        Else
            txtValImporte.EditValue = 0
        End If
        If IsNumeric(txtValAjuste.EditValue) = True Then
            If CDbl(txtValAjuste.EditValue) < 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor correcto en el Valor de Ajuste")
                Return
            End If
        Else
            txtValAjuste.EditValue = 0
        End If

        For Each rowDetServicio As DataRow In dtDetalleServicios.Rows
            If rowDetServicio("tgCatServId") = txtServicio.Tag Then
                SaimtMessageBox.mostrarAlertaInformativa("Ya se encuentra agregado el Servicio")
                Return
            End If
        Next

        Dim vAjuste As Decimal = 0
        Dim vImporte As Decimal = 0
        Dim vImportet As Decimal = 0
        Dim vIgv As Decimal = 0
        If chkAfecto.Checked = True Then
            vImporte = CDbl(txtValImporte.EditValue) / (1 + _pigv)
            vIgv = CDbl(vImporte) * _pigv
        Else
            vImporte = CDbl(txtValImporte.EditValue)
            vIgv = 0
        End If
        vImportet = CDbl(txtValImporte.EditValue) - CDbl(txtValRta4taCat.EditValue)
        If cboTipoAjuste.EditValue IsNot Nothing Then
            vAjuste = IIf(cboTipoAjuste.EditValue = "A", vImportet + CDbl(txtValAjuste.EditValue), vImportet - CDbl(txtValAjuste.EditValue))
        Else
            vAjuste = vImportet
        End If

        'If Len(txtCertificacionComp.Text) = 0 Then
        '    If CDbl(txtMontoQuedaCer.EditValue) < vAjuste Then
        '        SaimtMessageBox.mostrarAlertaAdvertencia("El Monto Total debe ser Menor o Igual al Monto Queda de la Certificación")
        '        Return
        '    End If
        'Else
        '    If CDbl(txtMontoQuedaCerComp.EditValue) + CDbl(txtMontoQuedaCer.EditValue) < vAjuste Then
        '        SaimtMessageBox.mostrarAlertaAdvertencia("El Monto Total debe ser Menor o Igual al Monto Queda de las Certificaciónes")
        '        Return
        '    End If
        'End If

        'Dim montocer1, montocer2 As Decimal

        'If IsNumeric(txtDetMontoCer1.EditValue) Then
        '    montocer1 = Format(CDbl(txtDetMontoCer1.EditValue), "##,##0.00")
        'Else
        '    SaimtMessageBox.mostrarAlertaInformativa("Seleccione una Certificación Valida")
        '    Return
        'End If

        'If IsNumeric(txtDetMontoCer2.EditValue) Then
        '    montocer2 = Format(CDbl(txtDetMontoCer2.EditValue), "##,##0.00")
        'Else
        '    montocer2 = 0
        'End If

        dtDetalleServicios.LoadDataRow(New Object() {0,
                                                        txtServicio.Tag, _
                                                        txtServicio.Text, _
                                                        txtDescripcionServicio.Text, _
                                                        txtObservacion.Text, _
                                                        Format(vImporte, "##,##0.00"), _
                                                        Format(vIgv, "##,##0.00"), _
                                                        Format(CDbl(txtValRta4taCat.Text), "##,##0.00"), _
                                                        IIf(CDbl(txtValAjuste.Text) = 0, Nothing, cboTipoAjuste.EditValue), _
                                                        cboTipoAjuste.Text, _
                                                        Format(CDbl(txtValAjuste.Text), "##,##0.00"), _
                                                        Format(CDbl(vAjuste), "##,##0.00")
                                                        }, True)



        CalCuloDeTotales()
        LimpiarControlesAdd()
        If dtDetalleServicios.Rows.Count > 0 Then
            btnEliminarServicio.Enabled = True
        End If

    End Sub

    Sub LimpiarControlesAdd()
        txtValImporte.EditValue = 0.0
        txtValRta4taCat.EditValue = 0.0
        txtObservacion.EditValue = Nothing
        txtValAjuste.EditValue = 0.0
        chkRta4ta.Checked = False
        txtServicio.Tag = Nothing
        txtServicio.Text = Nothing
        txtDescripcionServicio.Text = Nothing
        txtDetMontoCer1.Text = 0.0
        txtDetMontoCer2.Text = 0.0
    End Sub
    Sub CalCuloDeTotales()
        txtSubTotal.EditValue = 0.0
        txtRta4ta.EditValue = 0.0
        txtAjuste.EditValue = 0.0
        txtIgv.EditValue = 0.0
        txtMontoTotal.EditValue = 0.0
        'Dim CerUtl1, CerUtl2 As Decimal
        'CerUtl1 = 0.0
        'CerUtl2 = 0
        For Each frow As DataRow In dtDetalleServicios.Rows
            If frow("tgTipoAjusteId").ToString = "" Then
                txtSubTotal.EditValue = Format(txtSubTotal.EditValue + frow("ordDetPrecio"), "##,##0.00")
            End If
            txtRta4ta.EditValue = Format(txtRta4ta.EditValue + frow("ordDetRta4ta"), "##,##0.00")
            txtAjuste.EditValue = IIf(frow("tgTipoAjusteId").ToString = "A", txtAjuste.EditValue + CDbl(frow("ordDetAjuste")), txtAjuste.EditValue - CDbl(frow("ordDetAjuste")))
            txtIgv.EditValue = txtIgv.EditValue + frow("ordDetIgv")
            'If Len(txtCertificacionComp.Text) <> 0 Then
            '    CerUtl1 = CerUtl1 + CDbl(frow("cerMontoUtl1"))
            '    CerUtl2 = CerUtl2 + CDbl(frow("cerMontoUtl2"))
            'End If
        Next
        ' txtSubTotal.EditValue = txtSubTotal.EditValue '+ txtAjuste.EditValue
        txtMontoTotal.EditValue = Format(CDbl(txtSubTotal.EditValue) + CDbl(txtIgv.EditValue) - CDbl(txtRta4ta.EditValue) + CDbl(txtAjuste.EditValue), "##,##0.00")
        'txtMontoTotal.EditValue = txtMontoTotal.EditValue + txtAjuste.EditValue
        'If Len(txtCertificacionComp.Text) = 0 Then
        '    txtMontoCertUtilizado.Text = txtMontoTotal.EditValue
        'Else
        '    txtMontoCertUtilizado.Text = CerUtl1
        '    txtMontoCertUtilizadoComp.Text = CerUtl2

        '    If IsNumeric(txtMontoCertUtilizadoComp.Tag) Then
        '        txtMontoQuedaCerComp.Text = Format(CDbl(txtMontoQuedaCerComp.Tag) + CDbl(txtMontoCertUtilizadoComp.Tag) - CDbl(txtMontoCertUtilizadoComp.Text), "##,##0.00")
        '    Else
        '        txtMontoQuedaCerComp.Text = Format(CDbl(txtMontoQuedaCerComp.Tag) - CDbl(txtMontoCertUtilizadoComp.Text), "##,##0.00")
        '    End If

        'End If

        'If IsNumeric(txtMontoCertUtilizado.Tag) Then
        '    txtMontoQuedaCer.Text = Format(CDbl(txtMontoQuedaCer.Tag) + CDbl(txtMontoCertUtilizado.Tag) - CDbl(txtMontoCertUtilizado.Text), "##,##0.00")
        'Else
        '    txtMontoQuedaCer.Text = Format(CDbl(txtMontoQuedaCer.Tag) - CDbl(txtMontoCertUtilizado.Text), "##,##0.00")
        'End If

        txtMontoDebe.EditValue = txtMontoTotal.EditValue
        txtMontoHaber.EditValue = txtMontoTotal.EditValue
        '  txtImportePresupuesto.EditValue = txtMontoTotal.EditValue
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

    Private Sub chkRta4ta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRta4ta.CheckedChanged
        If IsNumeric(txtValImporte.EditValue) = True Then
            If CDbl(txtValImporte.EditValue) < 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor correcto en el Valor Importe")
                Return
            End If
        End If
        If IsNumeric(txtValAjuste.EditValue) = True Then
            If CDbl(txtValAjuste.EditValue) < 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un valor correcto en el Valor de Ajuste")
                Return
            End If
        End If

        If chkRta4ta.Checked = True Then
            txtValRta4taCat.EditValue = Format(CDbl(Val(txtValImporte.EditValue)) * CDbl(_p4ta), "#,##0.00")
        Else
            txtValRta4taCat.EditValue = 0
        End If

    End Sub

    Private Sub cboTipoAjuste_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoAjuste.EditValueChanged
        If cboTipoAjuste.EditValue <> "0" Then
            txtValAjuste.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub btnConsultarCertificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCertificacion.Click
        Dim frm As frmConsultarCertificacion = New frmConsultarCertificacion()
        Dim lsMensajeGA As String
        '  MontoQuedanCertificacion = 0
        If frm.ShowDialog Then
            lsMensajeGA = String.Format("Esta seguro que desea utilizar la Certificación N° {0} con Monto Total {1} y Monto Restante de {2}", frm.cerNro, Format(CDbl(frm.cerValTotal), "##,##0.00"), Format(CDbl(frm.cerValQuedan), "##,##0.00"))

            If frm.cerId = "" Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Certificación")
                txtCertificacion.Tag = ""
                txtCertificacion.Text = ""
                cboActProy.EditValue = ""
                cboMeta.EditValue = ""
                cboFuenteFinanciera.EditValue = ""
                txtMontoTotalCer.Text = ""
                txtMontoQuedaCer.Text = ""
                txtReferenciaDoc.Text = "" 'CERT. Nº " + "" + "- 2013 - SAIMT/OPP"
                txtCertificacion.Focus()
                cboCertificacion.EditValue = Nothing
                cboPartida.Properties.DataSource = Nothing
                Exit Sub
            End If

            Select Case SaimtMessageBox.mostrarAlertaPregunta(lsMensajeGA)
                Case System.Windows.Forms.DialogResult.OK
                    If frm.cerValQuedan > 0 Then
                        txtCertificacion.Tag = frm.cerId
                        txtCertificacion.Text = frm.cerNro
                        txtMontoTotalCer.Text = frm.cerValTotal
                        txtMontoQuedaCer.Text = frm.cerValQuedan
                        txtReferenciaDoc.Text = "CERT. Nº " + txtCertificacion.Text + "- " & frm.cerFecha.Year & " - SAIMT/OPP"
                        btnAgregarServicio.Enabled = True
                        locertificacion = New EECertificacion
                        locertificacion.TgActProyId = frm.tgActProyId
                        locertificacion.TgMetaId = frm.tgMetaId
                        locertificacion.TgFFinancieraId = frm.tgFFinancieraId

                        locertificacioncomp = New EECertificacion
                        locertificacioncomp.TgActProyId = frm.tgActProyId
                        locertificacioncomp.TgMetaId = frm.tgMetaId
                        locertificacioncomp.TgFFinancieraId = frm.tgFFinancieraId

                    Else
                        SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una certificación")
                    End If
                    Exit Select

                Case System.Windows.Forms.DialogResult.Cancel
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub txtValImporte_KeyUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValImporte.KeyUp
        If IsNumeric(txtValImporte.Text) = True Then
            If CDbl(txtValImporte.Text) > 0 Then
                txtDetMontoCer1.Text = txtValImporte.Text
                btnAddServicio.Enabled = True
            Else
                If IsNumeric(txtValAjuste.Text) Then
                    btnAddServicio.Enabled = True
                Else
                    btnAddServicio.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub txtNroOrdenServicio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroOrdenServicio.Leave
        Dim s As String = "000000" & txtNroOrdenServicio.Text
        txtNroOrdenServicio.Text = s.Substring(Len(s) - 6)
    End Sub

    Private Sub btnConsultarCertificacionComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCertificacionComp.Click
        Dim frm As frmConsultarCertificacion = New frmConsultarCertificacion()
        Dim lsMensajeGA As String
        '  MontoQuedanCertificacion = 0
        If frm.ShowDialog Then
            lsMensajeGA = String.Format("Esta seguro que desea utilizar la Certificación N° {0} con Monto Total {1} y Monto Restante de {2}", frm.cerNro, Format(CDbl(frm.cerValTotal), "##,##0.00"), Format(CDbl(frm.cerValQuedan), "##,##0.00"))

            If frm.cerId = "" Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Certificación Complementaria")
                txtCertificacionComp.Tag = ""
                txtCertificacionComp.Text = ""
                txtMontoTotalCerComp.Text = ""
                txtMontoQuedaCerComp.Text = ""
                txtReferenciaDocComp.Text = "CERT. Nº " + "" + "- 2013 - SAIMT/OPP"
                txtCertificacionComp.Focus()
                Exit Sub
            End If

            Select Case SaimtMessageBox.mostrarAlertaPregunta(lsMensajeGA)
                Case System.Windows.Forms.DialogResult.OK
                    If frm.cerValQuedan > 0 Then
                        txtCertificacionComp.Tag = frm.cerId
                        txtCertificacionComp.Text = frm.cerNro
                        txtMontoTotalCerComp.Text = frm.cerValTotal
                        txtMontoQuedaCerComp.Text = frm.cerValQuedan
                        txtMontoQuedaCerComp.Tag = frm.cerValQuedan
                        txtReferenciaDocComp.Text = "CERT. Nº " + txtCertificacionComp.Text + "- 2013 - SAIMT/OPP"
                        btnAgregarServicio.Enabled = True
                        '  txtMontoCertUtilizadoComp.Properties.ReadOnly = False

                    Else
                        SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una certificación")
                    End If
                    Exit Select

                Case System.Windows.Forms.DialogResult.Cancel
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub gvDetalleServicios_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDetalleServicios.CellValueChanged
        If GEstadoNuevo = False Then
            If e.Column.Caption = "Precio Unitario" Then
                CalCuloDeTotales()
            End If
        End If
    End Sub

    Private Sub btnElimEditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimEditor.Click
        If Me.gvDetalleServicios.DataRowCount <> 0 Then
            If dtDetalleServicios.Rows(Me.gvDetalleServicios.GetSelectedRows(0))("ordDetId").ToString() > 0 Then
                If ListaTemporal_OrdenServicioDetElimandos Is Nothing Then
                    ListaTemporal_OrdenServicioDetElimandos = New List(Of String)
                End If
                Dim ordDetId As String = dtDetalleServicios.Rows(Me.gvDetalleServicios.GetSelectedRows(0))("ordDetId").ToString
                ListaTemporal_OrdenServicioDetElimandos.Add(ordDetId)
            End If
            If ListaTemporal_OrdenServicioDetElimandos IsNot Nothing Then
                If ListaTemporal_OrdenServicioDetNuevo.Count > 0 Then
                    Dim liIndiceNuevoModificar As Int16 = 0
                    Dim liFila As Int16 = -1
                    For Each fTablaGeneral As DataRow In dtDetalleServicios.Rows
                        If String.IsNullOrEmpty(fTablaGeneral("ordDetId")) And Me.gvDetalleServicios.FocusedRowHandle = liFila Then
                            liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                        End If
                        liFila = liFila + 1
                    Next
                    ListaTemporal_OrdenServicioDetNuevo.RemoveAt(liIndiceNuevoModificar)
                End If
            End If

            txtServicio.Tag = gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(1)
            txtServicio.Text = gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(2)
            txtDescripcionServicio.Text = gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(3)
            txtObservacion.Text = gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(4).ToString
            txtValImporte.Text = gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(5) + gvDetalleServicios.GetDataRow(gvDetalleServicios.GetSelectedRows(0)).Item(6)
            chkAfecto.Checked = IIf(gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(6) > 0, True, False)
            txtValRta4taCat.Text = gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(7)
            cboTipoAjuste.Properties.ReadOnly = False
            cboTipoAjuste.EditValue = gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(8).ToString
            txtValAjuste.Text = gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(9)
            txtDetMontoCer1.EditValue = gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(12)
            txtDetMontoCer2.EditValue = gvDetalleServicios.GetDataRow(Me.gvDetalleServicios.GetSelectedRows(0)).Item(13)

            dtDetalleServicios.Rows.RemoveAt(Me.gvDetalleServicios.GetSelectedRows(0))
            CalCuloDeTotales()
            ' LimpiarControlesAdd()
            If dtDetalleServicios.Rows.Count > 0 Then
                btnEliminarServicio.Enabled = True
            Else
                btnEliminarServicio.Enabled = False
            End If

            txtValImporte.Properties.ReadOnly = False
            cboTipoAjuste.Properties.ReadOnly = False
            txtDescripcionServicio.Properties.ReadOnly = False
            txtObservacion.Properties.ReadOnly = False
            chkAfecto.Properties.ReadOnly = False
            chkRta4ta.Properties.ReadOnly = False
            If Len(txtCertificacionComp.Tag) > 0 Then
                txtDetMontoCer1.Visible = True
                txtDetMontoCer2.Visible = True
                lblDetCert1.Visible = True
                lblDetCert2.Visible = True
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

    End Sub

    Private Sub cboCertificacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCertificacion.SelectedIndexChanged

        If cboCertificacion.SelectedIndex = 0 And Len(txtCertificacion.Tag) > 0 Then
            loGrupoPartidas = MantenimientosBL.Instancia.CertificacionGrupoPartidaXcerId(txtCertificacion.Tag)
        ElseIf cboCertificacion.SelectedIndex = 1 Then
            If Len(txtCertificacionComp.Tag) > 0 Then
                loGrupoPartidas = MantenimientosBL.Instancia.CertificacionGrupoPartidaXcerId(txtCertificacionComp.Tag)
            Else
                cboActProy.ItemIndex = -1
                cboMeta.ItemIndex = -1
                cboFuenteFinanciera.ItemIndex = -1
                loGrupoPartidas = Nothing
                cboPartida.Properties.DataSource = Nothing
                SaimtMessageBox.mostrarAlertaInformativa("No ha seleccionado la Certificación 2")
            End If

        End If
        If loGrupoPartidas IsNot Nothing Then
            cboPartida.mColumnas(SaimtComboBoxLookUp.Entidades.Partida)
            cboPartida.Properties.DisplayMember = "PartDato"
            cboPartida.Properties.ValueMember = "cerGrupoParId"
            cboPartida.Properties.DataSource = loGrupoPartidas
            cboPartida.ItemIndex = -1
            If locertificacion Is Nothing Then
                locertificacion = MantenimientosBL.Instancia.CertificacionMostrarCertificacionXCerId(txtCertificacion.Tag)
            End If
            If locertificacioncomp Is Nothing Then
                locertificacioncomp = MantenimientosBL.Instancia.CertificacionMostrarCertificacionXCerId(txtCertificacionComp.Tag)
            End If
            If cboCertificacion.SelectedIndex = 0 Then
                cboActProy.EditValue = locertificacion.TgActProyId
                cboMeta.EditValue = locertificacion.TgMetaId
                cboFuenteFinanciera.EditValue = locertificacion.TgFFinancieraId
            ElseIf cboCertificacion.SelectedIndex = 1 Then
                cboActProy.EditValue = locertificacioncomp.TgActProyId
                cboMeta.EditValue = locertificacioncomp.TgMetaId
                cboFuenteFinanciera.EditValue = locertificacioncomp.TgFFinancieraId
            End If

        End If
    End Sub

    Private Sub btnAddProcesoPresupuestario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProcesoPresupuestario.Click
        If txtMontoTotal.Text <= 0 Then
            Return
        End If
        If cboCertificacion.SelectedIndex = -1 Or Len(txtCertificacion.Tag) = 0 Then
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
        Dim totalComp As Decimal = 0.0
        If gvProcesoPresupuesto.DataRowCount > 0 Then
            For i = 0 To gvProcesoPresupuesto.DataRowCount - 1
                total = total + CDbl(gvProcesoPresupuesto.GetDataRow(i)("importe"))
            Next
        End If

        If total + Format(CDbl(txtImportePresupuesto.Text.Trim), "##,##0.0000") <= txtMontoTotal.Text Then
            dtDetalleProceso.LoadDataRow(New Object() {cboPartida.EditValue, _
                                 IIf(cboCertificacion.SelectedIndex = 0, txtCertificacion.Tag, txtCertificacionComp.Tag), _
                                 IIf(cboCertificacion.SelectedIndex = 0, txtCertificacion.Text, txtCertificacionComp.Text), _
                                 cboPartida.Text, _
                                Format(CDbl(txtImportePresupuesto.Text.Trim), "##,##0.0000")
                                 }, True)

            ' txtMontoCertUtilizado.Text = total + Format(CDbl(txtImportePresupuesto.Text.Trim), "##,##0.0000")
        Else
            SaimtMessageBox.mostrarAlertaInformativa("El monto total supera al Total de la Orde de Compra")

        End If


        total = 0.0

        If gvProcesoPresupuesto.DataRowCount > 0 Then
            For i = 0 To gvProcesoPresupuesto.DataRowCount - 1
                If txtCertificacion.Tag = gvProcesoPresupuesto.GetDataRow(i)("cerId") Then
                    total = total + CDbl(gvProcesoPresupuesto.GetDataRow(i)("importe"))
                End If
                If txtCertificacionComp.Tag = gvProcesoPresupuesto.GetDataRow(i)("cerId") Then
                    totalComp = totalComp + CDbl(gvProcesoPresupuesto.GetDataRow(i)("importe"))
                End If
            Next
        End If
        txtMontoCertUtilizado.Text = total
        txtMontoCertUtilizadoComp.Text = totalComp
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
                Dim totalComp As Decimal = 0.0
                If gvProcesoPresupuesto.DataRowCount > 0 Then
                    For i = 0 To gvProcesoPresupuesto.DataRowCount
                        If txtCertificacion.Tag = gvProcesoPresupuesto.GetDataRow(i)("cerId") Then
                            total = total + CDbl(gvProcesoPresupuesto.GetDataRow(i)("importe"))
                        End If
                        If txtCertificacionComp.Tag = gvProcesoPresupuesto.GetDataRow(i)("cerId") Then
                            totalComp = totalComp + CDbl(gvProcesoPresupuesto.GetDataRow(i)("importe"))
                        End If
                    Next
                End If
                txtMontoCertUtilizado.Text = total
                txtMontoCertUtilizadoComp.Text = totalComp
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

        If Len(txtCertificacionComp.Tag) > 0 Then
            MantenimientosBL.Instancia.ordencompraActualizarCertificacionLOGcerValQuedan(txtCertificacionComp.Tag)
            Dim ListaCertificacion As EECertificacion = MantenimientosBL.Instancia.CertificacionMostrarCertificacionXCerId(txtCertificacionComp.Tag)
            If ListaCertificacion IsNot Nothing Then
                txtMontoQuedaCerComp.Text = ListaCertificacion.CerValQuedan
            End If
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

    Private Sub SaimtButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavOrdServicio.Click
        NavegacionNew(tabOrdenCompra.SelectedTabPageIndex)
    End Sub

    Private Sub SaimtButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton10.Click
        dtDocReferencia.Rows.Add()
    End Sub

    Private Sub SaimtButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton9.Click
        If Me.gvDocReferencias.DataRowCount <> 0 Then
            gvDocReferencias.DeleteRow(Me.gvDocReferencias.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaError("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub btnAtrasOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasOrdenServicio.Click
        NavegacionLast(tabOrdenCompra.SelectedTabPageIndex)
    End Sub
End Class
