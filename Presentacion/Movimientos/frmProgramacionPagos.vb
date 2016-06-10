Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Public Class frmProgramacionPagos
    Inherits frmMantenimientos
    Dim dtListadoPersona As DataTable = New DataTable()
    Dim dtListadoContrato As DataTable = New DataTable()
    Dim dtProgramacionPagos As DataTable = New DataTable()
    Dim dtDetalleProgramacionPagos As DataTable = New DataTable()
    'SE OBTIENE EL IGV DE LA TABLA PARAMETRO
    Dim IGV As Decimal = String.Format("{0:0.00}", MantenimientosBL.Instancia.parametroMostrarXClsId(42))
    ''' <summary>
    ''' LISTA TEMPORAL PARA USAR CUANDO SE VA CREAR DETALLE CUOTAS DE LA PROGRAMACION DE PAGOS
    ''' </summary>
    ''' <remarks></remarks>
    Dim ListaTemporalProPagosDetalleNuevos As List(Of EEProPagos.EEProPagosDet) = Nothing
    ''' <summary>
    ''' LISTA TEMPORAL PARA USAR CUANDO SE VA EDITAR EL DETALLE CUOTAS DE LA PROGRAMCION DE PAGOS
    ''' </summary>
    ''' <remarks></remarks>
    Dim ListaTemporalProPagosDetalleEditar As List(Of EEProPagos.EEProPagosDet) = Nothing
    Dim ListaTemporalEliminadosDetalle As List(Of String) = New List(Of String)
    Dim loProPagosDet As EEProPagos.EEProPagosDet = Nothing

#Region "Construir Table Programacion Pagos"
    Private Sub ConstruirTableProgramacionPagos()
        dtProgramacionPagos.Columns.Add("propaNroCuota", GetType(String))
        dtProgramacionPagos.Columns.Add("proPaId", GetType(String))
        dtProgramacionPagos.Columns.Add("tgTipoComprobante", GetType(String))
        dtProgramacionPagos.Columns.Add("proPaFechaVen", GetType(DateTime))
        dtProgramacionPagos.Columns.Add("tgEstadoId", GetType(String))
        dtProgramacionPagos.Columns.Add("tgEstado", GetType(String))
        dtProgramacionPagos.Columns.Add("proPaFechaPag", GetType(DateTime))
        dtProgramacionPagos.Columns.Add("proPaDetIgv", GetType(Decimal))
        dtProgramacionPagos.Columns.Add("proPaPMora", GetType(Decimal))
        dtProgramacionPagos.Columns.Add("ProPaAplicaD", GetType(Boolean))
        dtProgramacionPagos.Columns.Add("tgRecaudadoraId", GetType(String))
        dtProgramacionPagos.Columns.Add("tgRecaudadora", GetType(String))
        dtProgramacionPagos.Columns.Add("tgMoneda", GetType(String))
        dtProgramacionPagos.Columns.Add("Mes", GetType(String))
        'COLUMNA TEMPORAL PARA SABER QUE CUOTAS SE AÑADIERON RECIENTEMENTE
        'SI ES FALSO SE HAN AÑADIDO RECIENTEMENTE, TRUE YA ESTAN EN LA BD
        dtProgramacionPagos.Columns.Add("temporal", GetType(Boolean))
        dtProgramacionPagos.Columns.Add("proPaComision", GetType(String))
        dtProgramacionPagos.Columns.Add("nroComprobante", GetType(String))
    End Sub
#End Region
#Region "Construir Table Programacion Pagos Detalle"
    Private Sub ConstruirTableProgramacionPagosDetalle()
        dtDetalleProgramacionPagos.Columns.Add("proPaId", GetType(String))
        dtDetalleProgramacionPagos.Columns.Add("conId", GetType(String))
        dtDetalleProgramacionPagos.Columns.Add("co" & "nNombre", GetType(String))
        dtDetalleProgramacionPagos.Columns.Add("proPaDetPConcepto", GetType(Decimal))
        dtDetalleProgramacionPagos.Columns.Add("proPaDetMonto", GetType(Decimal))
        'COLUMNA TEMPORAL PARA SABER QUE DETALLE CUOTAS SE AÑADIERON RECIENTEMENTE
        'SI ES FALSO SE HAN AÑADIDO RECIENTEMENTE, TRUE YA ESTAN EN LA BD
        dtDetalleProgramacionPagos.Columns.Add("temporal", GetType(Boolean))

        dtDetalleProgramacionPagos.Columns("proPaId").Caption = "Cod. Prog."
        dtDetalleProgramacionPagos.Columns("proPaDetMonto").Caption = "Monto"
        dtDetalleProgramacionPagos.Columns("proPaDetPConcepto").Caption = "P. Concepto"
        dtDetalleProgramacionPagos.Columns("conId").Caption = "Cod. Concepto"
        dtDetalleProgramacionPagos.Columns("conNombre").Caption = "Concepto"
    End Sub
#End Region
#Region "Construir Table Listado Persona"
    Private Sub ConstruirTableListadoPersona()
        dtListadoPersona.Columns.Add("perId", GetType(String))
        dtListadoPersona.Columns.Add("persona", GetType(String))
    End Sub
#End Region
#Region "Construir Table Listado ContratoInm"
    Private Sub ConstruirTableListadoContrato()
        dtListadoContrato.Columns.Add("conInmId", GetType(String))
        dtListadoContrato.Columns.Add("conInmFecIni", GetType(Date))
        dtListadoContrato.Columns.Add("conInmFecFin", GetType(Date))
        dtListadoContrato.Columns.Add("inmUbicacion", GetType(String))
    End Sub
#End Region
#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        ListaTemporalProPagosDetalleEditar = Nothing
        Try
            If Me.gvListadoContratos.DataRowCount <> 0 Then
                Dim loContratoInm As EEContratoInm = MantenimientosBL.Instancia.contratoInmListarXConInmIdProgramacionPagos(gvListadoContratos.GetRowCellValue(Me.gvListadoContratos.GetSelectedRows(0), "conInmId").ToString())

                'PERSONA
                txtNroDocumento.Text = loContratoInm.OPersona.PerNDoc
                txtTipoPersona.Text = loContratoInm.OPersona.perTipoPersona
                txtNombreRazon.Text = loContratoInm.OPersona.Persona
                txtTipoDocumento.Text = loContratoInm.OPersona.TgTipoDoc
                'FIN PERSONA

                txtNroContrato.Text = loContratoInm.ConInmId
                txtCodInmueble.Text = loContratoInm.InmId
                txtDirInmueble.Text = loContratoInm.InmDir

                txtFecInicio.Text = loContratoInm.ConInmFecIni
                txtFecTermino.Text = loContratoInm.ConInmFecFin
                txtMerConductiva.Text = loContratoInm.ConInmMerced
                txtGarantia.Text = IIf(loContratoInm.ConInmGarantia.HasValue, loContratoInm.ConInmGarantia, String.Empty)
                txtDerLlave.Text = IIf(loContratoInm.ConInmDerLlaves.HasValue, loContratoInm.ConInmDerLlaves, String.Empty)
                txtUso.Text = loContratoInm.OTgUso.TgNombre
                txtEstado.Text = loContratoInm.OTgEstado.TgNombre
                txtTipoMoneda.Text = loContratoInm.OTgMoneda.TgNombre

                dtProgramacionPagos.Clear()
                dtDetalleProgramacionPagos.Clear()
                Dim lbBand As Boolean = False
                For Each fProPagos In loContratoInm.ListaProgramacionPagos
                    dtProgramacionPagos.LoadDataRow(New Object() {fProPagos.ProPaNroCuota.ToString().PadLeft(2, "0"c), _
                        fProPagos.ProPaId, _
                        fProPagos.OTgTipoComprobante.TgCodigo, _
                        fProPagos.ProPaFechaVen, _
                        fProPagos.OTgEstado.TgCodigo, _
                        fProPagos.OTgEstado.TgNombre, _
                        fProPagos.ProPaFechaPag, _
                        fProPagos.ProPaDetIgv, _
                        fProPagos.ProPaPMora, _
                        CBool(fProPagos.ProPaAplicaD), _
                        fProPagos.OTgRecaudadora.TgCodigo, _
                        fProPagos.OTgRecaudadora.TgNombre, _
                        fProPagos.OTgMoneda.TgCodigo, _
                        StrConv(MonthName(fProPagos.ProPaFechaVen.Value.Month, False), VbStrConv.ProperCase), _
                        True,
                        String.Format("{0:0.00}", fProPagos.ProPaComision),
                        fProPagos.NroComprobante
                    }, True)

                    If fProPagos.ListaProgramacionPagosDetalle IsNot Nothing Then
                        For Each fProPagosDetalle In fProPagos.ListaProgramacionPagosDetalle

                            If ListaTemporalProPagosDetalleEditar Is Nothing Then
                                ListaTemporalProPagosDetalleEditar = New List(Of EEProPagos.EEProPagosDet)
                            End If

                            loProPagosDet = New EEProPagos.EEProPagosDet()
                            loProPagosDet.ProPaId = fProPagos.ProPaId
                            Dim loConcepto As EEConceptos = New EEConceptos()
                            loConcepto.ConId = fProPagosDetalle.OConcepto.ConId
                            loConcepto.ConNombre = fProPagosDetalle.OConcepto.ConNombre
                            loProPagosDet.OConcepto = loConcepto
                            loProPagosDet.ProPaDetMonto = fProPagosDetalle.ProPaDetMonto
                            loProPagosDet.ProPaDetPConcepto = fProPagosDetalle.ProPaDetPConcepto
                            loProPagosDet.ProPaDetAplicaM = "0"
                            loProPagosDet.GuardarOrUpdate = True

                            ListaTemporalProPagosDetalleEditar.Add(loProPagosDet)
                        Next
                    End If

                    lbBand = True
                Next

                Dim ls As Object = String.Empty
                gvProgramacionPagos_Click(ls, EventArgs.Empty)
                gvProgramacionPagos.BestFitColumns()
                Me.colProPaDetMontoDetalle.Width = 105
                GIdRegistroActual = loContratoInm.ConInmId

                MyBase.seleccionarListado()

                If lbBand = False Then
                    SaimtMessageBox.mostrarAlertaInformativa("- El Contrato Seleccionado es un nuevo Contrato." & Environment.NewLine & "- Para Asignarle Programaciones de Pagos Haga Clic " & _
                    Environment.NewLine & "  en el Boton Nuevo y Busque el Nuevo Contrato.")
                    mGSetearTool(btnBuscarContrato, "Buscar", "Clic para Buscar Nuevos Contratos sin Programacion de Pagos")
                    btnNuevo.Focus()
                    btnEditar.Enabled = False
                    Exit Sub
                End If

                If Not String.IsNullOrEmpty(txtEstado.Text) Then
                    If txtEstado.Text.Equals("Terminado") Or txtEstado.Text.Equals("Cancelado") Then
                        btnEditar.Enabled = False
                        mostrarMensajeBarra("El Contrato se Encuentra en Estado " & txtEstado.Text & " por lo Tanto no se Puede Editar.")
                    End If
                End If
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        If dtProgramacionPagos.Rows.Count = 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Añada Cuotas Antes de Guardar")
            Exit Sub
        Else
            For Each fCuota As DataRow In dtProgramacionPagos.Rows
                If String.IsNullOrEmpty(fCuota("proPaFechaVen").ToString()) Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Una Fecha Vencimiento en la Cuota " & fCuota("proPaId").ToString().Substring(0, 2))
                    gvProgramacionPagos.FocusedColumn = colProPaFechaVen
                    gvProgramacionPagos.FocusedRowHandle = Convert.ToInt16(fCuota("proPaId").ToString().Substring(0, 2)) - 1
                    Exit Sub
                End If

                If String.IsNullOrEmpty(fCuota("tgMoneda").ToString()) Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Una Moneda en la Cuota " & fCuota("proPaId").ToString().Substring(0, 2))
                    gvProgramacionPagos.FocusedColumn = colTgMoneda
                    gvProgramacionPagos.FocusedRowHandle = Convert.ToInt16(fCuota("proPaId").ToString().Substring(0, 2)) - 1
                    Exit Sub
                End If
            Next
        End If

        If GEstadoNuevo = True Then
            If ListaTemporalProPagosDetalleNuevos Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No Se Encontro Detalle Cuotas")
                Exit Sub
            End If
            If ListaTemporalProPagosDetalleNuevos IsNot Nothing Then
                Dim lsProPaId As String = String.Empty
                For Each fCuota As DataRow In dtProgramacionPagos.Rows
                    lsProPaId = fCuota("proPaId").ToString()
                    Dim ListaProPagosDetalleResult As List(Of EEProPagos.EEProPagosDet) = ListaTemporalProPagosDetalleNuevos.FindAll(Function(ac) ac.ProPaId = lsProPaId)

                    If ListaProPagosDetalleResult.Count = 0 Then
                        If SaimtMessageBox.mostrarAlertaPregunta("No Se Encontro Detalle Cuotas Para la Cuota " & fCuota("proPaId").ToString().Substring(0, 2)) = False Then
                            Exit Sub
                        End If
                    End If
                Next
            End If
        Else
            If ListaTemporalProPagosDetalleEditar Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No Se Encontro Detalle Cuotas")
                Exit Sub
            End If

            If ListaTemporalProPagosDetalleEditar IsNot Nothing Then
                Dim lsProPaId As String = String.Empty
                For Each fCuota As DataRow In dtProgramacionPagos.Rows
                    lsProPaId = fCuota("proPaId").ToString()
                    Dim ListaProPagosDetalleResult As List(Of EEProPagos.EEProPagosDet) = ListaTemporalProPagosDetalleEditar.FindAll(Function(ac) ac.ProPaId = lsProPaId)

                    If ListaProPagosDetalleResult.Count = 0 Then
                        If SaimtMessageBox.mostrarAlertaPregunta("No Se Encontro Detalle Cuotas Para la Cuota " & fCuota("proPaId").ToString().Substring(0, 2)) = False Then
                            Exit Sub
                        End If
                    End If
                Next
            End If
        End If

        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loProPagosSave As EEProPagos = Nothing
        Try
            For Each fCuota As DataRow In dtProgramacionPagos.Rows
                If loProPagosSave Is Nothing Then
                    loProPagosSave = New EEProPagos()
                End If
                Dim loProPagos As EEProPagos = New EEProPagos()
                loProPagos.ProPaId = fCuota("proPaId").ToString()
                loProPagos.ProPaNroCuota = fCuota("propaNroCuota").ToString()
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = fCuota("tgTipoComprobante")
                loProPagos.OTgTipoComprobante = loTablaGeneral
                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = txtNroContrato.Text
                loProPagos.OContratoInm = loContratoInm
                loProPagos.ProPaFechaVen = fCuota("proPaFechaVen").ToString()
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = fCuota("tgEstadoId").ToString()
                loProPagos.OTgEstado = loTablaGeneral
                loProPagos.ProPaDetIgv = fCuota("proPaDetIgv").ToString()
                loProPagos.ProPaPMora = fCuota("proPaPMora").ToString()
                loProPagos.ProPaAplicaD = IIf(Convert.ToBoolean(fCuota("ProPaAplicaD")) = True, "1", "0")
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = fCuota("tgRecaudadoraId").ToString()
                loProPagos.OTgRecaudadora = loTablaGeneral
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = fCuota("tgMoneda").ToString()
                loProPagos.OTgMoneda = loTablaGeneral
                loProPagos.GuardarOrUpdate = fCuota("temporal")
                loProPagos.ListaTemporalProPagosDetalleEliminados = ListaTemporalEliminadosDetalle.FindAll(Function(ac) ac.Contains(loProPagos.ProPaId))

                If loProPagosSave.ListaProPagos Is Nothing Then
                    loProPagosSave.ListaProPagos = New List(Of EEProPagos)
                End If

                If loProPagos.ListaProgramacionPagosDetalle Is Nothing Then
                    loProPagos.ListaProgramacionPagosDetalle = New List(Of EEProPagos.EEProPagosDet)
                End If

                If GEstadoNuevo = True Then
                    For Each fDetalleCuota As EEProPagos.EEProPagosDet In ListaTemporalProPagosDetalleNuevos.FindAll(Function(ac) ac.ProPaId = loProPagos.ProPaId)
                        loProPagos.ListaProgramacionPagosDetalle.Add(fDetalleCuota)
                    Next
                Else
                    For Each fDetalleCuota As EEProPagos.EEProPagosDet In ListaTemporalProPagosDetalleEditar.FindAll(Function(ac) ac.ProPaId = loProPagos.ProPaId)
                        loProPagos.ListaProgramacionPagosDetalle.Add(fDetalleCuota)
                    Next
                End If

                loProPagosSave.ListaProPagos.Add(loProPagos)
            Next

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.proPagosGuardar(loProPagosSave)
            Else
                MantenimientosBL.Instancia.proPagosActualizar(loProPagosSave)
            End If

            Me.enabledGA = False
            MyBase.guardar()
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            dtDetalleProgramacionPagos.Clear()
            dtProgramacionPagos.Clear()
            dtListadoContrato.Clear()
            GValorTextoBuscado = txtBuscarContratoPor.Text
            GCriterioBuscado = cboBuscarContratoPor.SelectedIndex
            Dim ListaContratoInm As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoInmListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            If ListaContratoInm IsNot Nothing Then
                For Each fContrato As EEContratoInm In ListaContratoInm
                    dtListadoContrato.LoadDataRow(New Object() {fContrato.ConInmId,
                                                               fContrato.ConInmFecIni,
                                                               fContrato.ConInmFecFin,
                                                               fContrato.OInmueble.InmUbicacion}, True)
                Next
                gvListadoContratos.BestFitColumns()
                gvListadoContratos.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub listar()
        Try
            dtDetalleProgramacionPagos.Clear()
            dtProgramacionPagos.Clear()
            dtListadoContrato.Clear()
            Dim ListaContratoInm As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoInmListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            If ListaContratoInm IsNot Nothing Then
                For Each fContrato As EEContratoInm In ListaContratoInm
                    dtListadoContrato.LoadDataRow(New Object() {fContrato.ConInmId,
                                                               fContrato.ConInmFecIni,
                                                               fContrato.ConInmFecFin,
                                                               fContrato.OInmueble.InmUbicacion}, True)
                Next
                gvListadoContratos.BestFitColumns()
                gvListadoContratos.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub eliminar()
        Try
            MyBase.eliminar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        ListaTemporalProPagosDetalleNuevos = Nothing
        hodControlesTotal(grbDatosContrato.Controls, False)
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        dtProgramacionPagos.Clear()
        dtDetalleProgramacionPagos.Clear()
        ListaTemporalProPagosDetalleNuevos = Nothing
        hodControlesTotal(grbDatosContrato.Controls, False)
        btnBuscarContrato.Enabled = True
        btnBuscarContrato.Focus()
    End Sub
#End Region

    Private Sub frmProgramacionPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        ConstruirTableProgramacionPagos()
        ConstruirTableProgramacionPagosDetalle()
        ConstruirTableListadoPersona()
        ConstruirTableListadoContrato()

        dgvProgramacionPagos.DataSource = dtProgramacionPagos
        dgvDetalleProgramacionPagos.DataSource = dtDetalleProgramacionPagos
        dgvListadoPersona.DataSource = dtListadoPersona
        dgvListadoContratos.DataSource = dtListadoContrato

        cboConcepto.mColumnas(SaimtComboBoxLookUp.Entidades.Concepto)
        cboConcepto.Properties.DisplayMember = "ConIdConNombre"
        cboConcepto.Properties.ValueMember = "ConIdProcentaje"
        'cboConcepto.Properties.DataSource = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupo(Date.Now.Year, "01")
        'cboConcepto.ItemIndex = 0

        mGSetearTool(btnBuscarContrato, "Buscar", "Clic Para Buscar Contratos Nuevos que Aún no Tienen Programación de Pagos.")
        mGSetearTool(btnAgregarCuota, "Agregar", "Clic Para Agregar Programaciones de Pago.")
        mGSetearTool(btnQuitarCuota, "Quitar", "Clic Para Quitar la Programación de Pago que esta Seleccionado.")
        mGSetearTool(btnAgregarDetallle, "Agregar", "Clic Para Agregar un Concepto.")
        mGSetearTool(btnQuitarDetalle, "Quitar", "Clic Para Quitar el Concepto que esta Seleccionado.")
        mGSetearTool(btnComprobante, "Marcar", "Clic Para Asignar el Mismo Comprobante de la Primera Fila a Todas las Cuotas.")
        mGSetearTool(btnAplicaDetraccion, "Marcar", "Clic Para Marcar Detracción de la Primera Fila a Todas las Cuotas.")
        mAgregarComboMoneda()
        mAgregarComboComprobantes()

        cboTipoUso.Properties.ReadOnly = True
    End Sub

    Private Sub gvProgramacionPagos_Click(sender As System.Object, e As System.EventArgs) Handles gvProgramacionPagos.Click
        mMostrarDetalleProgramacionPagos()
    End Sub

    Private Sub gvProgramacionPagos_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvProgramacionPagos.CustomRowCellEditForEditing
        mMostrarDetalleProgramacionPagos()
    End Sub

#Region "Mostrar Detalle Programacion Pagos"
    Private Sub mMostrarDetalleProgramacionPagos()
        If Me.gvProgramacionPagos.DataRowCount <> 0 Then
            dtDetalleProgramacionPagos.Clear()

            'SE OBTIENE EL AÑO PARA LISTAR LOS CONCEPTOS RESPECTIVOS
            Dim lsAño As String = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaFechaVen").ToString()
            If Not String.IsNullOrEmpty(lsAño) Then
                cboConcepto.Properties.DataSource = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupo(CDate(lsAño).Year.ToString, "01")
                cboConcepto.ItemIndex = 0
            End If

            Dim lsProPaId As String = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaId").ToString()

            'SI EL ESTADO ES ACTUALIZAR SE LISTA EL DETALLE  SEGUN PROPAID
            If GEstadoNuevo = False Then
                If ListaTemporalProPagosDetalleEditar IsNot Nothing Then
                    'LISTA DE PAGOS RESULTANTE SEGUN LA PROGRAMACION DE PAGOS ID
                    Dim ListaProPagosDetalleResult As List(Of EEProPagos.EEProPagosDet) = ListaTemporalProPagosDetalleEditar.FindAll(Function(ac) ac.ProPaId = lsProPaId)

                    'SE VERIFICA QUE LA LISTA RESULTANTE TENGA ALGO
                    If ListaProPagosDetalleResult.Count > 0 Then
                        'SI TIENE ALGO SE MUESTRA EN EL GRID DE DETALLE CUOTAS
                        For Each fProPagosDetalle As EEProPagos.EEProPagosDet In ListaProPagosDetalleResult
                            dtDetalleProgramacionPagos.LoadDataRow(New Object() {fProPagosDetalle.ProPaId, _
                                fProPagosDetalle.OConcepto.ConId, _
                                fProPagosDetalle.OConcepto.ConNombre, _
                                fProPagosDetalle.ProPaDetPConcepto, _
                                fProPagosDetalle.ProPaDetMonto,
                                fProPagosDetalle.GuardarOrUpdate
                             }, True)
                        Next
                        gvDetalleProgramacionPagos.BestFitColumns()
                        Me.colProPaDetMontoDetalle.Width = 105
                    Else
                        dtDetalleProgramacionPagos.Clear()
                    End If
                End If
            Else
                If ListaTemporalProPagosDetalleNuevos IsNot Nothing Then
                    'LISTA DE PAGOS RESULTANTE SEGUN LA PROGRAMACION DE PAGOS ID
                    Dim ListaProPagosDetalleResult As List(Of EEProPagos.EEProPagosDet) = ListaTemporalProPagosDetalleNuevos.FindAll(Function(ac) ac.ProPaId = lsProPaId)

                    'SE VERIFICA QUE LA LISTA RESULTANTE TENGA ALGO
                    If ListaProPagosDetalleResult.Count > 0 Then
                        'SI TIENE ALGO SE MUESTRA EN EL GRID DE DETALLE CUOTAS
                        For Each fProPagosDetalle As EEProPagos.EEProPagosDet In ListaProPagosDetalleResult
                            dtDetalleProgramacionPagos.LoadDataRow(New Object() {fProPagosDetalle.ProPaId, _
                                fProPagosDetalle.OConcepto.ConId, _
                                fProPagosDetalle.OConcepto.ConNombre, _
                                fProPagosDetalle.ProPaDetPConcepto, _
                                fProPagosDetalle.ProPaDetMonto,
                                fProPagosDetalle.GuardarOrUpdate
                             }, True)
                        Next
                        gvDetalleProgramacionPagos.BestFitColumns()
                        Me.colProPaDetMontoDetalle.Width = 105
                    Else
                        dtDetalleProgramacionPagos.Clear()
                    End If
                End If
            End If

        End If
    End Sub
#End Region

#Region "Colorear Filas Programacion Pagos"
    Private ListaEstadoProPagos As List(Of EETablaGeneral) = Nothing
    Private Sub gvProgramacionPagos_RowStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvProgramacionPagos.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            If ListaEstadoProPagos Is Nothing Then
                ListaEstadoProPagos = MantenimientosBL.Instancia.tablageneralListarXClsId(18)
            End If

            Dim lsEstadoId As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("tgEstadoId"))
            If Not String.IsNullOrEmpty(lsEstadoId) Then
                Dim lsExtra As String = ListaEstadoProPagos.Find(Function(ac) ac.TgCodigo = lsEstadoId).TgExtra
                Dim lsExtraColor As String() = lsExtra.Split(",")
                e.Appearance.BackColor = System.Drawing.Color.FromArgb(lsExtraColor(0), lsExtraColor(1), lsExtraColor(2))
            End If
        End If
    End Sub
#End Region

#Region "Quitar Detalle"
    Private Sub btnQuitarDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarDetalle.Click
        If Me.gvDetalleProgramacionPagos.DataRowCount <> 0 Then
            If gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "tgEstadoId").ToString().Equals("A") Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No Puede Quitar Conceptos a Una Cuota Anulada")
                Exit Sub
            ElseIf gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "tgEstadoId").ToString().Equals("P") Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No Puede Quitar Conceptos a Una Cuota Pagada")
                Exit Sub
            End If

            Dim lsProPaId As String = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaId").ToString()
            Dim lsConId As String = gvDetalleProgramacionPagos.GetRowCellValue(Me.gvDetalleProgramacionPagos.GetSelectedRows(0), "conId").ToString()
            'SI EL ESTADO ES NUEVO SE VERIFCA LA LISTA TEMPORAL NUEVOS PARA IR QUITANDO 
            'SEGUN LA FILA SELECCIONADA
            If GEstadoNuevo = True Then
                Dim liIndiceListaExiste As Integer = ListaTemporalProPagosDetalleNuevos.FindIndex(Function(ac) ac.ProPaId = lsProPaId And ac.OConcepto.ConId = lsConId)
                If liIndiceListaExiste > -1 Then
                    ListaTemporalProPagosDetalleNuevos.RemoveAt(liIndiceListaExiste)
                End If
                'CASO CONTRARIO SE VERIFICA LA LISTA TEMPORAL EDITADOS
            Else

                ListaTemporalEliminadosDetalle.Add(lsProPaId & "-" & lsConId)


                Dim liIndiceListaExiste As Integer = ListaTemporalProPagosDetalleEditar.FindIndex(Function(ac) ac.ProPaId = lsProPaId And ac.OConcepto.ConId = lsConId)
                If liIndiceListaExiste > -1 Then
                    ListaTemporalProPagosDetalleEditar.RemoveAt(liIndiceListaExiste)
                End If
            End If

            dtDetalleProgramacionPagos.Rows.RemoveAt(Me.gvDetalleProgramacionPagos.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub
#End Region

#Region "Agregar Detalle"
    Private Sub btnAgregarDetallle_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarDetallle.Click
        If gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "tgEstadoId").ToString().Equals("A") Then
            SaimtMessageBox.mostrarAlertaAdvertencia("No Puede Agregar Conceptos a Una Cuota Anulada")
            Exit Sub
        ElseIf gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "tgEstadoId").ToString().Equals("P") Then
            SaimtMessageBox.mostrarAlertaAdvertencia("No Puede Quitar Conceptos a Una Cuota Pagada")
            Exit Sub
        End If

        If Me.gvProgramacionPagos.DataRowCount = 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Una Cuota Antes de Agregar el Detalle")
            Exit Sub
        End If

        If String.IsNullOrEmpty(cboConcepto.Text) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Concepto")
            cboConcepto.Focus()
            Exit Sub
        End If

        'If txtMonto.Text = "0.00" Then
        '    SaimtMessageBox.mostrarAlertaError("Ingrese un Monto Mayor a 0.00")
        '    txtMonto.Focus()
        '    Exit Sub
        'End If

        Dim lsProPaId As String = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaId").ToString()
        Dim lsplitConcepto As String() = cboConcepto.EditValue.ToString().Split("-") '0 ConId, 1 Porcentaje

        Dim liPosicionDetalleCuota As Int16 = 0
        Dim lbBand As Boolean = False
        'VERIFICAR SI EL CONCEPTO YA EXISTE SOLO SE AUMENTA EL MONTO
        For Each fDetalleCuota As DataRow In dtDetalleProgramacionPagos.Rows
            If fDetalleCuota("conId").Equals(lsplitConcepto(0)) Then
                dtDetalleProgramacionPagos.Rows(liPosicionDetalleCuota)("proPaDetMonto") = Convert.ToDecimal(dtDetalleProgramacionPagos.Rows(liPosicionDetalleCuota)("proPaDetMonto")) + Convert.ToDecimal(txtMonto.Text)
                lbBand = True
                Exit For
            End If
            liPosicionDetalleCuota = liPosicionDetalleCuota + 1
        Next

        If lbBand = False Then
            dtDetalleProgramacionPagos.LoadDataRow(New Object() {lsProPaId, _
                lsplitConcepto(0), _
                cboConcepto.Text.Substring(8, cboConcepto.Text.Length - 8), _
               (lsplitConcepto(1) / 100), _
                txtMonto.Text,
                False
            }, True)

            gvDetalleProgramacionPagos.BestFitColumns()
        End If

        'SI EL ESTADO ES NUEVO SE CREA UNA LISTA TEMPORAL DEL DETALLE PARA
        'IR ALMACENANDO LOS VALORES DEL DETALLE POR CUOTA
        If GEstadoNuevo = True Then
            If ListaTemporalProPagosDetalleNuevos Is Nothing Then
                ListaTemporalProPagosDetalleNuevos = New List(Of EEProPagos.EEProPagosDet)
            End If

            loProPagosDet = New EEProPagos.EEProPagosDet()
            loProPagosDet.ProPaId = lsProPaId

            Dim loConcepto As EEConceptos = New EEConceptos()
            loConcepto.ConId = lsplitConcepto(0)
            loConcepto.ConNombre = cboConcepto.Text.Substring(8, cboConcepto.Text.Length - 8)
            loProPagosDet.OConcepto = loConcepto
            loProPagosDet.ProPaDetMonto = txtMonto.Text
            loProPagosDet.ProPaDetPConcepto = (lsplitConcepto(1) / 100)
            loProPagosDet.ProPaDetAplicaM = "0"
            loProPagosDet.GuardarOrUpdate = False

            'SE VERIFICA SI EXISTE UN PROPAID EN LA LISTA TEMPORAL PARA SOLO AUMENTARLE MONTO SI EN CASO EXISTA
            'Y NO REPETIR EL MISMO PROPAID EN EL DETALLE
            Dim liIndiceListaExiste As Integer = ListaTemporalProPagosDetalleNuevos.FindIndex(Function(ac) ac.ProPaId = lsProPaId And ac.OConcepto.ConId = loConcepto.ConId)

            If liIndiceListaExiste > -1 Then
                ListaTemporalProPagosDetalleNuevos(liIndiceListaExiste).ProPaDetMonto = ListaTemporalProPagosDetalleNuevos(liIndiceListaExiste).ProPaDetMonto + Convert.ToDecimal(txtMonto.Text)
            Else
                ListaTemporalProPagosDetalleNuevos.Add(loProPagosDet)
            End If
        Else
            'CASO CONTRARIO EN LA MISMA LISTA TEMPORAL DE PROPAGOS EDITAR SE AÑADEN NUEVOS DETALLE O SE MODIFICA EL MONTO
            'SEGUN EL CASO
            If ListaTemporalProPagosDetalleEditar Is Nothing Then
                ListaTemporalProPagosDetalleEditar = New List(Of EEProPagos.EEProPagosDet)
            End If

            loProPagosDet = New EEProPagos.EEProPagosDet()
            loProPagosDet.ProPaId = lsProPaId

            Dim loConcepto As EEConceptos = New EEConceptos()
            loConcepto.ConId = lsplitConcepto(0)
            loConcepto.ConNombre = cboConcepto.Text.Substring(8, cboConcepto.Text.Length - 8)
            loProPagosDet.OConcepto = loConcepto
            loProPagosDet.ProPaDetMonto = txtMonto.Text
            loProPagosDet.ProPaDetPConcepto = (lsplitConcepto(1) / 100)
            loProPagosDet.ProPaDetAplicaM = "0"

            'SE VERIFICA SI EXISTE UN PROPAID EN LA LISTA TEMPORAL PARA SOLO AUMENTARLE MONTO SI EN CASO EXISTA
            'Y NO REPETIR EL MISMO PROPAID EN EL DETALLE
            Dim liIndiceListaExiste As Integer = ListaTemporalProPagosDetalleEditar.FindIndex(Function(ac) ac.ProPaId = lsProPaId And ac.OConcepto.ConId = loConcepto.ConId)

            If liIndiceListaExiste > -1 Then
                ListaTemporalProPagosDetalleEditar(liIndiceListaExiste).ProPaDetMonto = ListaTemporalProPagosDetalleEditar(liIndiceListaExiste).ProPaDetMonto + Convert.ToDecimal(txtMonto.Text)
            Else
                ListaTemporalProPagosDetalleEditar.Add(loProPagosDet)
            End If
        End If
        'FIN
    End Sub
#End Region

#Region "Agregar Cuota"
    Private Sub btnAgregarCuota_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarCuota.Click
        If String.IsNullOrEmpty(txtNroContrato.Text) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Contrato Seleccionado.")
            Exit Sub
        End If

        Dim liNroCuotasAdd As Int16 = spnNroCuotas.Value
        Dim liTotalFilas As Integer = dtProgramacionPagos.Rows.Count
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim ldMercedConductiva As Decimal = Convert.ToDecimal(txtMerConductiva.Text)

        If GEstadoNuevo = False Then
            While liNroCuotasAdd > 0
                dtProgramacionPagos.Rows.Add()
                liTotalFilas = dtProgramacionPagos.Rows.Count
                'SE OBTIENE EL NUMERO DE CUOTA APARTIR DEL TOTAL DE FILAS
                Dim liNroCuotaNueva As Integer = liTotalFilas

                dtProgramacionPagos.Rows(liTotalFilas - 1)("temporal") = False
                dtProgramacionPagos.Rows(liTotalFilas - 1)("propaNroCuota") = liNroCuotaNueva.ToString().PadLeft(2, "0"c)

                'SE OBTIENE EL NRO DE CONTRATO PARA DESPUES CONCATENARLO CON LA CUOTA Y SEGUIR LA SECUENCIA DEL PROPAID
                Dim liProPaId As String = txtNroContrato.Text

                'ASIGNACION DE VALORES PARA LAS FILAS NUEVAS
                dtProgramacionPagos.Rows(liTotalFilas - 1)("proPaId") = liNroCuotaNueva.ToString().PadLeft(2, "0"c) & liProPaId
                loTablaGeneral = MantenimientosBL.Instancia.tablageneralMostrarXClsIdXTgCodigo(18, "N")
                dtProgramacionPagos.Rows(liTotalFilas - 1)("tgEstadoId") = loTablaGeneral.TgCodigo
                dtProgramacionPagos.Rows(liTotalFilas - 1)("tgEstado") = loTablaGeneral.TgNombre
                dtProgramacionPagos.Rows(liTotalFilas - 1)("tgTipoComprobante") = dtProgramacionPagos.Rows(liTotalFilas - 2)("tgTipoComprobante").ToString()
                dtProgramacionPagos.Rows(liTotalFilas - 1)("tgRecaudadoraId") = dtProgramacionPagos.Rows(liTotalFilas - 2)("tgRecaudadoraId").ToString()
                dtProgramacionPagos.Rows(liTotalFilas - 1)("tgRecaudadora") = dtProgramacionPagos.Rows(liTotalFilas - 2)("tgRecaudadora").ToString()
                dtProgramacionPagos.Rows(liTotalFilas - 1)("ProPaAplicaD") = dtProgramacionPagos.Rows(liTotalFilas - 2)("ProPaAplicaD").ToString()
                dtProgramacionPagos.Rows(liTotalFilas - 1)("tgMoneda") = dtProgramacionPagos.Rows(liTotalFilas - 2)("tgMoneda").ToString()

                Try
                    dtProgramacionPagos.Rows(liTotalFilas - 1)("proPaDetIgv") = IGV
                    'SE OBTIENE LA MORA DE LA TABLA PARAMETRO
                    dtProgramacionPagos.Rows(liTotalFilas - 1)("proPaPMora") = MantenimientosBL.Instancia.parametroMostrarXClsId(72)
                Catch ex As Exception
                    SaimtMessageBox.mostrarAlertaError(ex.Message)
                End Try

                liNroCuotasAdd = liNroCuotasAdd - 1
            End While
            gvProgramacionPagos.BestFitColumns()
        Else
            If liTotalFilas > 0 Then
                While liNroCuotasAdd > 0
                    dtProgramacionPagos.Rows.Add()

                    'SE OBTIENE EL NUMERO DE CUOTA ANTERIOR Y SUMA 1 PARA SEGUIR LA SECUENCIA
                    Dim liNroCuotaNueva As Integer = Convert.ToInt32(dtProgramacionPagos.Rows(liTotalFilas - 1)("propaNroCuota")) + 1

                    dtProgramacionPagos.Rows(liTotalFilas)("temporal") = False
                    dtProgramacionPagos.Rows(liTotalFilas)("propaNroCuota") = liNroCuotaNueva.ToString().PadLeft(2, "0"c)

                    'SE OBTIENE EL ID PROGRAMACION PAGOS Y PARA DESPUES CONCATENARLO CON LA CUOTA Y SIGUIR LA SECUENCIA
                    Dim liProPaId As String = txtNroContrato.Text

                    'ASIGNACION DE VALORES PARA LAS FILAS NUEVAS
                    dtProgramacionPagos.Rows(liTotalFilas)("proPaId") = liNroCuotaNueva.ToString().PadLeft(2, "0"c) & liProPaId
                    dtProgramacionPagos.Rows(liTotalFilas)("proPaFechaVen") = CDate(dtProgramacionPagos.Rows(liTotalFilas - 1)("proPaFechaVen")).AddMonths(1)

                    loTablaGeneral = MantenimientosBL.Instancia.tablageneralMostrarXClsIdXTgCodigo(18, "N")
                    dtProgramacionPagos.Rows(liTotalFilas)("tgEstadoId") = loTablaGeneral.TgCodigo
                    dtProgramacionPagos.Rows(liTotalFilas)("tgEstado") = loTablaGeneral.TgNombre

                    dtProgramacionPagos.Rows(liTotalFilas)("tgTipoComprobante") = lsCompId

                    loTablaGeneral = MantenimientosBL.Instancia.tablageneralMostrarXClsIdXTgCodigo(34, "02")
                    dtProgramacionPagos.Rows(liTotalFilas)("tgRecaudadoraId") = loTablaGeneral.TgCodigo
                    dtProgramacionPagos.Rows(liTotalFilas)("tgRecaudadora") = loTablaGeneral.TgNombre

                    If ldMercedConductiva + (ldMercedConductiva * IGV) >= 700 Then
                        dtProgramacionPagos.Rows(liTotalFilas)("ProPaAplicaD") = True
                    Else
                        dtProgramacionPagos.Rows(liTotalFilas)("ProPaAplicaD") = False
                    End If

                    Try
                        dtProgramacionPagos.Rows(liTotalFilas)("proPaDetIgv") = IGV
                        'SE OBTIENE LA MORA DE LA TABLA PARAMETRO
                        dtProgramacionPagos.Rows(liTotalFilas)("proPaPMora") = MantenimientosBL.Instancia.parametroMostrarXClsId(72)
                    Catch ex As Exception
                        SaimtMessageBox.mostrarAlertaError(ex.Message)
                    End Try

                    liNroCuotasAdd = liNroCuotasAdd - 1
                    liTotalFilas = dtProgramacionPagos.Rows.Count
                End While
                gvProgramacionPagos.BestFitColumns()
                Me.colProPaDetMontoDetalle.Width = 105
            Else
                Dim liNroCuota As Int16 = 1
                Dim liFila As Int16 = 0
                Dim lsFechaInicioContrato As String = "04" & txtFecInicio.Text.ToString().Substring(2, 8)
                While liNroCuotasAdd > 0
                    dtProgramacionPagos.Rows.Add()

                    dtProgramacionPagos.Rows(liFila)("temporal") = False
                    dtProgramacionPagos.Rows(liFila)("propaNroCuota") = liNroCuota.ToString().PadLeft(2, "0"c)

                    'SE OBTIENE EL ID PROGRAMACION PAGOS Y PARA DESPUES CONCATENARLO CON LA CUOTA Y SIGUIR LA SECUENCIA
                    Dim liProPaId As String = txtNroContrato.Text

                    'ASIGNACION DE VALORES PARA LAS FILAS NUEVAS
                    dtProgramacionPagos.Rows(liFila)("proPaId") = liNroCuota.ToString().PadLeft(2, "0"c) & liProPaId
                    dtProgramacionPagos.Rows(liFila)("proPaFechaVen") = CDate(lsFechaInicioContrato).AddMonths(liFila).ToString()

                    loTablaGeneral = MantenimientosBL.Instancia.tablageneralMostrarXClsIdXTgCodigo(18, "N")
                    dtProgramacionPagos.Rows(liFila)("tgEstadoId") = loTablaGeneral.TgCodigo
                    dtProgramacionPagos.Rows(liFila)("tgEstado") = loTablaGeneral.TgNombre

                    dtProgramacionPagos.Rows(liFila)("tgTipoComprobante") = lsCompId

                    loTablaGeneral = MantenimientosBL.Instancia.tablageneralMostrarXClsIdXTgCodigo(34, "02")
                    dtProgramacionPagos.Rows(liFila)("tgRecaudadoraId") = loTablaGeneral.TgCodigo
                    dtProgramacionPagos.Rows(liFila)("tgRecaudadora") = loTablaGeneral.TgNombre

                    If ldMercedConductiva + (ldMercedConductiva * IGV) >= 700 Then
                        dtProgramacionPagos.Rows(liFila)("ProPaAplicaD") = True
                    Else
                        dtProgramacionPagos.Rows(liFila)("ProPaAplicaD") = False
                    End If

                    Try
                        dtProgramacionPagos.Rows(liFila)("proPaDetIgv") = IGV
                        'SE OBTIENE LA MORA DE LA TABLA PARAMETRO
                        dtProgramacionPagos.Rows(liFila)("proPaPMora") = MantenimientosBL.Instancia.parametroMostrarXClsId(72)
                    Catch ex As Exception
                        SaimtMessageBox.mostrarAlertaError(ex.Message)
                    End Try

                    liNroCuotasAdd = liNroCuotasAdd - 1
                    liFila = liFila + 1
                    liNroCuota = liNroCuota + 1
                End While
                gvProgramacionPagos.BestFitColumns()
            End If
        End If
    End Sub
#End Region

#Region "Quitar Cuota"
    Private Sub btnQuitarCuota_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarCuota.Click
        If Me.gvProgramacionPagos.DataRowCount <> 0 Then
            'PARA VERIFICAR SI LA CUOTA YA HA EXISTIDO O ES UNA CUOTA RECIEN AGREGADA
            If dtProgramacionPagos.Rows(Me.gvProgramacionPagos.GetSelectedRows(0))("temporal") = True Then
                Dim lsEstadoPagoCuota As String = IIf(IsDBNull(dtProgramacionPagos.Rows(Me.gvProgramacionPagos.GetSelectedRows(0))("tgEstado")), String.Empty, dtProgramacionPagos.Rows(Me.gvProgramacionPagos.GetSelectedRows(0))("tgEstado"))
                If lsEstadoPagoCuota.Equals("Pagado") OrElse lsEstadoPagoCuota.Equals("Anulado") Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Las Cuotas en Estado Pagado o Anulado ya no se pueden cambiar de estado.")
                Else
                    Dim loTablaGeneral As EETablaGeneral = MantenimientosBL.Instancia.tablageneralMostrarXClsIdXTgCodigo(18, "A")

                    dtProgramacionPagos.Rows(Me.gvProgramacionPagos.GetSelectedRows(0))("tgEstadoId") = loTablaGeneral.TgCodigo
                    dtProgramacionPagos.Rows(Me.gvProgramacionPagos.GetSelectedRows(0))("tgEstado") = loTablaGeneral.TgNombre
                End If
            Else
                If GEstadoNuevo = True Then
                    'SE VERIFICA LA LISTA TEMPORAL DE DETALLE NUEVOS PARA LA PROGRAMACION SELECCIONADA 
                    'PARA TAMBIEN ELIMINARLO DE LA LISTA TEMPORAL
                    If ListaTemporalProPagosDetalleNuevos IsNot Nothing Then
                        Dim lsProPaId As String = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaId").ToString()
                        ListaTemporalProPagosDetalleNuevos.RemoveAll(Function(ac) ac.ProPaId = lsProPaId)
                    End If
                Else
                    'SE VERIFICA LA LISTA TEMPORAL DE DETALLE A EDITAR PARA LA PROGRAMACION SELECCIONADA 
                    'PARA TAMBIEN ELIMINARLO DE LA LISTA TEMPORAL
                    If ListaTemporalProPagosDetalleEditar IsNot Nothing Then
                        Dim lsProPaId As String = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaId").ToString()
                        ListaTemporalProPagosDetalleEditar.RemoveAll(Function(ac) ac.ProPaId = lsProPaId)
                    End If
                End If

                'SI ES UNA CUOTA RECIEN AGREGADA LA PODEMOS ELIMINAR LA FILA DIRECTAMENTE
                dtProgramacionPagos.Rows.RemoveAt(Me.gvProgramacionPagos.GetSelectedRows(0))

                'SE VUELVE A CALCULAR LOS NUMEROS DE CUOTA POR HABER ELIMINADO UNA CUOTA
                'Y NO DEJAR EL NRO CUOTAS SALTEADOS Y SER NRO CONSECUTIVO
                Dim liPosicionCuota As Integer = 1
                Dim liFila As Integer = 0
                For Each fFilaCuota As DataRow In dtProgramacionPagos.Rows
                    dtProgramacionPagos.Rows(liFila)("propaNroCuota") = liPosicionCuota.ToString().PadLeft(2, "0"c)
                    dtProgramacionPagos.Rows(liFila)("proPaId") = liPosicionCuota.ToString().PadLeft(2, "0"c) & txtNroContrato.Text
                    liPosicionCuota = liPosicionCuota + 1
                    liFila = liFila + 1
                Next
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada.")
        End If
    End Sub
#End Region

#Region "Agregar Combo a la Columnas"
    Private Sub mAgregarComboMoneda()
        Dim RepositorioItemsMoneda As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim dtComboMoneda As DataTable = New DataTable
        dtComboMoneda.Columns.Add("TgNombre", GetType(String))
        dtComboMoneda.Columns.Add("TgCodigo", GetType(String))

        dtComboMoneda.Columns("TgNombre").Caption = "Nombre"
        dtComboMoneda.Columns("TgCodigo").Caption = "Codigo"
        dtComboMoneda.Columns("TgCodigo").ColumnMapping = MappingType.Hidden

        For Each fTg As EETablaGeneral In MantenimientosBL.Instancia.tablageneralListarXClsId(5)
            dtComboMoneda.Rows.Add(fTg.TgNombre, fTg.TgCodigo)
        Next

        With RepositorioItemsMoneda
            .DisplayMember = "TgNombre"
            .ValueMember = "TgCodigo"
            .DataSource = dtComboMoneda
            .NullText = "<<Seleccione>>"
        End With

        colTgMoneda.ColumnEdit = RepositorioItemsMoneda
        RepositorioItemsMoneda.BestFit()
    End Sub

    Private Sub mAgregarComboComprobantes()
        Dim RepositorioItemsComprobante As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim dtComboComprobante As DataTable = New DataTable
        dtComboComprobante.Columns.Add("TgNombre", GetType(String))
        dtComboComprobante.Columns.Add("TgCodigo", GetType(String))

        dtComboComprobante.Columns("TgNombre").Caption = "Nombre"
        dtComboComprobante.Columns("TgCodigo").Caption = "Codigo"
        dtComboComprobante.Columns("TgCodigo").ColumnMapping = MappingType.Hidden

        For Each fTg As EETablaGeneral In MantenimientosBL.Instancia.tablageneralListarXClsId(36)
            dtComboComprobante.Rows.Add(fTg.TgNombre, fTg.TgCodigo)
        Next

        With RepositorioItemsComprobante
            .DisplayMember = "TgNombre"
            .ValueMember = "TgCodigo"
            .DataSource = dtComboComprobante
            .NullText = "<<Seleccione>>"
        End With

        colTgTipoComprobante.ColumnEdit = RepositorioItemsComprobante
        RepositorioItemsComprobante.BestFit()
    End Sub
#End Region

    Private Sub gvProgramacionPagos_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvProgramacionPagos.CellValueChanged
        'AL SELECCIONAR UNA FECHA VENCIMIENTO OBTENER EL NOMBRE DEL MES
        If e.Column.FieldName = "proPaFechaVen" Then
            Dim liDiasInicio As Integer = DateDiff(("d"), txtFecInicio.Text, e.Value)
            Dim liDiasFin As Integer = DateDiff(("d"), e.Value, txtFecTermino.Text)
            If liDiasInicio < 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una Fecha en el Rango de Fecha Inicio y Termino del contrato")
                dtProgramacionPagos.Rows(e.RowHandle)("proPaFechaVen") = DBNull.Value
                Exit Sub
            ElseIf liDiasFin < 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una Fecha en el Rango de Fecha Inicio y Termino del contrato")
                dtProgramacionPagos.Rows(e.RowHandle)("proPaFechaVen") = DBNull.Value
                Exit Sub
            Else
                dtProgramacionPagos.Rows(e.RowHandle)("Mes") = StrConv(MonthName(CDate(e.Value).Month, False), VbStrConv.ProperCase)
                dtProgramacionPagos.Rows(Me.gvProgramacionPagos.GetSelectedRows(0))("proPaFechaVen") = e.Value
                cboConcepto.Properties.DataSource = MantenimientosBL.Instancia.conceptoListarXAñoXTgGrupo(CDate(e.Value).Year, "01")
                cboConcepto.ItemIndex = 0
            End If
        End If
    End Sub

    Private Sub gvProgramacionPagos_ShowingEditor(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles gvProgramacionPagos.ShowingEditor
        'SI LA COLUMNA TEMPORAL ESTA EN FALSO TENEMOS LA OPCION DE SELECCIONAR
        'UNA FECHA VENCIMIENTO COMO MONEDA POR SER LA FILA NUEVA
        If dtProgramacionPagos.Rows(Me.gvProgramacionPagos.GetSelectedRows(0))("temporal") = False Then
            'PARA PERMITIR SELECCIONAR O EDITAR UNA CELDA DE UNA FILA
            e.Cancel = False
            gvProgramacionPagos.BestFitColumns()
            Me.colProPaDetMontoDetalle.Width = 105
        Else
            'BLOQUEA LA EDICION O SELECCION DE LA CELDA DE UNA FILA
            If dtProgramacionPagos.Rows(Me.gvProgramacionPagos.GetSelectedRows(0))("tgEstadoId").Equals("N") Then
                If gvProgramacionPagos.FocusedColumn.FieldName = "proPaFechaVen" Then
                    e.Cancel = False
                    gvProgramacionPagos.BestFitColumns()
                    Me.colProPaDetMontoDetalle.Width = 105
                ElseIf gvProgramacionPagos.FocusedColumn.FieldName = "tgTipoComprobante" Then
                    e.Cancel = False
                    gvProgramacionPagos.BestFitColumns()
                    Me.colProPaDetMontoDetalle.Width = 93
                ElseIf gvProgramacionPagos.FocusedColumn.FieldName = "ProPaAplicaD" Then
                    e.Cancel = False
                    gvProgramacionPagos.BestFitColumns()
                    Me.colProPaDetMontoDetalle.Width = 105
                Else
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        End If
    End Sub

#Region "Boton Buscar Contrato"
    Dim lsCompId As String = String.Empty
    Private Sub btnBuscarContrato_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarContrato.Click
        Using fmConsultaContrato As frmConsultaContratosEnProgramacionPagos = New frmConsultaContratosEnProgramacionPagos
            If fmConsultaContrato.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtNroContrato.Text = fmConsultaContrato.ConInmId
                txtTipoPersona.Text = IIf(fmConsultaContrato.TgTipoPersId.Equals("N"), "NATURAL", "JURIDICA")
                txtNroDocumento.Text = fmConsultaContrato.PerNroDocumento
                txtNombreRazon.Text = fmConsultaContrato.Persona
                txtCodInmueble.Text = fmConsultaContrato.InmId
                txtDirInmueble.Text = fmConsultaContrato.InmDir
                txtEstado.Text = fmConsultaContrato.TgNombreEstado
                txtTipoMoneda.Text = fmConsultaContrato.TgNombreMoneda
                txtFecInicio.Text = CDate(fmConsultaContrato.ConInmFecIni)
                txtFecTermino.Text = CDate(fmConsultaContrato.ConInmFecFin)
                txtUso.Text = fmConsultaContrato.TgNombreUso
                txtDerLlave.Text = fmConsultaContrato.ConInmDerLlaves
                txtGarantia.Text = fmConsultaContrato.ConInmGarantia
                txtMerConductiva.Text = fmConsultaContrato.ConInmMerced
                lsCompId = fmConsultaContrato.TgCompId

                hodControlesTotal(grbDatosContrato.Controls, False)
                btnBuscarContrato.Enabled = True
            End If
        End Using
    End Sub
#End Region

    Private Sub btnComprobante_Click(sender As System.Object, e As System.EventArgs) Handles btnComprobante.Click
        If dtDetalleProgramacionPagos.Rows.Count > 0 Then
            Dim lsTgTipoComprobant As String = dtProgramacionPagos.Rows(0)("tgTipoComprobante").ToString()
            For i As Int16 = 1 To dtProgramacionPagos.Rows.Count - 1 Step 1
                dtProgramacionPagos.Rows(i)("tgTipoComprobante") = lsTgTipoComprobant
            Next
        End If
    End Sub

    Private Sub btnAplicaDetraccion_Click(sender As System.Object, e As System.EventArgs) Handles btnAplicaDetraccion.Click
        If dtDetalleProgramacionPagos.Rows.Count > 0 Then
            Dim lbProPaAplicaD As Boolean = dtProgramacionPagos.Rows(0)("ProPaAplicaD")
            For i As Int16 = 1 To dtProgramacionPagos.Rows.Count - 1 Step 1
                dtProgramacionPagos.Rows(i)("ProPaAplicaD") = lbProPaAplicaD
            Next
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Me.btnImprimir.Enabled = False
        EEComun.ExportarPrintForm(Me, Me.Text)
        Me.btnImprimir.Enabled = True
    End Sub

    Private Sub SaimtButton1_Click(sender As System.Object, e As System.EventArgs) Handles btnComprobantePago.Click
        If Me.gvProgramacionPagos.DataRowCount <> 0 Then
            Dim propaId As String
            propaId = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaId").ToString()
            Dim fmCompProgramacion As frmCompProgramacion = New frmCompProgramacion(propaId, gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "tgTipoComprobante").ToString(), gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "nroComprobante").ToString())
            If fmCompProgramacion.ShowDialog() = DialogResult.OK Then
                dtProgramacionPagos.Rows(Me.gvProgramacionPagos.GetSelectedRows(0))("nroComprobante") = fmCompProgramacion.Serie & "-" & fmCompProgramacion.Numero
            End If
        End If
    End Sub

    Private Sub gvListadoPersona_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvListadoPersona.CustomRowCellEditForEditing
        Try
            Dim lsPerId As String = gvListadoPersona.GetRowCellValue(Me.gvListadoPersona.GetSelectedRows(0), "perId").ToString()
            txtBuscarContratoPor.Text = lsPerId
            dtListadoContrato.Clear()
            cboBuscarContratoPor.SelectedIndex = 0
            Dim ListaContratoInm As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoInmListarCriterio(cboBuscarContratoPor.SelectedIndex, lsPerId)
            For Each fContrato As EEContratoInm In ListaContratoInm
                dtListadoContrato.LoadDataRow(New Object() {fContrato.ConInmId,
                                                           fContrato.ConInmFecIni,
                                                           fContrato.ConInmFecFin,
                                                            fContrato.OInmueble.InmUbicacion
                               }, True)
            Next
            gvListadoContratos.BestFitColumns()
            gvListadoContratos.SelectRow(0)
            dgvListado_Click(Nothing, Nothing)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub txtBuscarPersonaPor_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarPersonaPor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If PuedeBuscar Then
                Try
                    dtDetalleProgramacionPagos.Clear()
                    dtProgramacionPagos.Clear()
                    dtListadoPersona.Clear()
                    GValorTextoBuscado = txtBuscarPersonaPor.Text
                    GCriterioBuscado = cboBuscarPersonaPor.SelectedIndex
                    Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaListarCriterioProgramacionPagos(GCriterioBuscado, GValorTextoBuscado)
                    If ListaPersona IsNot Nothing Then
                        For Each fPersona As EEPersona In ListaPersona
                            dtListadoPersona.LoadDataRow(New Object() {fPersona.PerId,
                                                                       fPersona.perNombresoRazon
                                           }, True)
                        Next
                        gvListadoPersona.BestFitColumns()
                        gvListadoPersona.SelectRow(0)
                        gvListadoPersona_CustomRowCellEditForEditing(Nothing, Nothing)
                    End If
                Catch ex As Exception
                    SaimtMessageBox.mostrarAlertaError(ex.Message)
                End Try
            Else
                mostrarMensajeBarra(GMensajePermiso)
            End If
        End If
    End Sub

    Private Sub cboBuscarContratoPor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboBuscarContratoPor.SelectedIndexChanged
        cboTipoUso.Properties.ReadOnly = False
        GValorTextoBuscado = Nothing

        If cboBuscarContratoPor.SelectedIndex = 3 Then
            cboTipoUso.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoUso.Properties.DisplayMember = "TgNombre"
            cboTipoUso.Properties.ValueMember = "TgCodigo"
            cboTipoUso.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(16)
            cboTipoUso.ItemIndex = 0
        End If
        If cboBuscarContratoPor.SelectedIndex = 3 Then
            txtBuscarContratoPor.Properties.ReadOnly = True
            GCriterioBuscado = cboBuscarContratoPor.SelectedIndex
            GValorTextoBuscado = cboTipoUso.EditValue
            listar()
        Else
            cboTipoUso.Properties.ReadOnly = True
            cboTipoUso.Properties.DataSource = Nothing
            cboTipoUso.ItemIndex = -1
            txtBuscarContratoPor.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub cboTipoUso_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoUso.EditValueChanged
        If GValorTextoBuscado IsNot Nothing Then
            GCriterioBuscado = cboBuscarContratoPor.SelectedIndex
            GValorTextoBuscado = cboTipoUso.EditValue
            listar()
        End If
    End Sub

    Private Sub gvListadoContratos_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvListadoContratos.CustomRowCellEditForEditing
        seleccionarListado()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

    End Sub
End Class