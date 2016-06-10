Imports SaimtControles
Imports Entidades
Imports ReglasNegocio
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmConsultarMora
    Inherits frmConsultas

    Dim liMontoTotalConcepto As Integer

    Public Property PerId As String
    Public Property ConInmId As String

    Dim dtContrato As DataTable = New DataTable()
    Dim dtProgramacionPagos As DataTable = New DataTable()
    Dim dtProgramacionPagosDetalle As DataTable = New DataTable()
    'PARA MANIPULAR EL DETALLE DE LA PROGRAMACION PAGOS EN MEMORIA
    Dim ListaProPagosDetalle As List(Of EEProPagos.EEProPagosDet) = Nothing

#Region "Construir Table Contrato"
    Private Sub ConstruirTableContrato()
        dtContrato.Columns.Add("conInmId", GetType(String))
        dtContrato.Columns.Add("inmId", GetType(String))
        dtContrato.Columns.Add("conInmFecIni", GetType(DateTime))
        dtContrato.Columns.Add("conInmFecFin", GetType(DateTime))
        dtContrato.Columns.Add("conInmDiaMaxVen", GetType(String))
        dtContrato.Columns.Add("inmDireccionCompleta", GetType(String))
        dtContrato.Columns.Add("tgUso", GetType(String))
        dtContrato.Columns.Add("tgEstado", GetType(String))
        dtContrato.Columns.Add("tgMoneda", GetType(String))
        dtContrato.Columns.Add("tgModalidad", GetType(String))
    End Sub
#End Region

#Region "Construir Table Programacion Pagos"
    Private Sub ConstruirTableProgramacionPagos()
        dtProgramacionPagos.Columns.Add("proPaNroCuota", GetType(String))
        dtProgramacionPagos.Columns.Add("proPaId", GetType(String))
        dtProgramacionPagos.Columns.Add("tgTipoComprobante", GetType(String))
        dtProgramacionPagos.Columns.Add("proPaFechaPag", GetType(DateTime))
        dtProgramacionPagos.Columns.Add("Mes", GetType(String))
        dtProgramacionPagos.Columns.Add("proPaFechaVen", GetType(DateTime))
        dtProgramacionPagos.Columns.Add("tgEstado", GetType(String))
        dtProgramacionPagos.Columns.Add("proPaDetIgv", GetType(Decimal))
        dtProgramacionPagos.Columns.Add("proPaPMora", GetType(Decimal))
        dtProgramacionPagos.Columns.Add("proPaAplicaD", GetType(Boolean))
        dtProgramacionPagos.Columns.Add("tgRecaudadora", GetType(String))
        dtProgramacionPagos.Columns.Add("tgMoneda", GetType(String))
        dtProgramacionPagos.Columns.Add("proPaComision", GetType(String))
        dtProgramacionPagos.Columns.Add("tgEstadoId", GetType(String))
    End Sub
#End Region

#Region "Construir Table Programacion Pagos Detalle"
    Private Sub ConstruirTableProgramacionPagosDetalle()
        dtProgramacionPagosDetalle.Columns.Add("proPaId", GetType(String))
        dtProgramacionPagosDetalle.Columns.Add("conId", GetType(String))
        dtProgramacionPagosDetalle.Columns.Add("conNombre", GetType(String))
        dtProgramacionPagosDetalle.Columns.Add("proPaDetPConcepto", GetType(Decimal))
        dtProgramacionPagosDetalle.Columns.Add("proPaDetMonto", GetType(Decimal))
    End Sub
#End Region

    Private Sub frmConsultarMora_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        hodControlesTotal(grbDatosPersona.Controls, False)

        txtCuotasNoPagadas.Properties.ReadOnly = True
        txtCuotasPagadas.Properties.ReadOnly = True
        txtTotalPagado.Properties.ReadOnly = True
        txtTotalPagar.Properties.ReadOnly = True
        txtPorPagar.Properties.ReadOnly = True
        txtTotalMora.Properties.ReadOnly = True
        txtTotalMoraRecalculo.Properties.ReadOnly = True

        ConstruirTableContrato()
        ConstruirTableProgramacionPagos()
        ConstruirTableProgramacionPagosDetalle()

        dgvContratos.DataSource = dtContrato
        dgvProgramacionPagos.DataSource = dtProgramacionPagos
        dgvProgramacionPagosDetalle.DataSource = dtProgramacionPagosDetalle

        txtTotalMoraRecalculo.Text = "0.00"

        Try
            Dim ListaContrato As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoMostrarXPerIdXConInmId_EnConsultarMora(PerId, ConInmId)
            For Each fContratoInm As EEContratoInm In ListaContrato
                txtCodigoPersona.Text = fContratoInm.OPersona.PerId
                txtPersona.Text = fContratoInm.OPersona.perNombresoRazon
                txtTipoDocumento.Text = fContratoInm.OPersona.TgDocumento
                txtNroDocumento.Text = fContratoInm.OPersona.PerNDoc

                dtContrato.LoadDataRow(New Object() { _
                    fContratoInm.ConInmId, _
                    fContratoInm.OInmueble.InmId, _
                    fContratoInm.ConInmFecIni, _
                    fContratoInm.ConInmFecFin, _
                    fContratoInm.ConInmDiaMaxVen, _
                    fContratoInm.OInmueble.OInmDireccion.InmDireccionCompleta, _
                    fContratoInm.OTgUso.TgNombre, _
                    fContratoInm.OTgEstado.TgNombre, _
                    fContratoInm.OTgMoneda.TgNombre, _
                    fContratoInm.OTgModalidad.TgNombre
                   }, True)

                gvContrato.BestFitColumns()

                Dim liCuotasPagadas As Int16 = 0
                Dim liCuotasNoPagadas As Int16 = 0
                Dim liCuotasPagoParcial As Int16 = 0
                

                For Each fProPagos As EEProPagos In fContratoInm.ListaProgramacionPagos
                    If fProPagos.OTgEstado.TgCodigo = "N" Then
                        liCuotasNoPagadas = liCuotasNoPagadas + 1
                    ElseIf fProPagos.OTgEstado.TgCodigo = "P" Then
                        liCuotasPagadas = liCuotasPagadas + 1
                    ElseIf fProPagos.OTgEstado.TgCodigo = "S" Then
                        liCuotasPagoParcial = liCuotasPagoParcial + 1
                    End If

                    dtProgramacionPagos.LoadDataRow(New Object() {fProPagos.ProPaNroCuota.ToString().PadLeft(2, "0"c), _
                        fProPagos.ProPaId, _
                        fProPagos.OTgTipoComprobante.TgNombre, _
                        fProPagos.ProPaFechaPag, _
                        MonthName(fProPagos.ProPaFechaVen.Value.Month, False), _
                        fProPagos.ProPaFechaVen, _
                        fProPagos.OTgEstado.TgNombre, _
                        fProPagos.ProPaDetIgv, _
                        fProPagos.ProPaPMora, _
                        CBool(fProPagos.ProPaAplicaD), _
                        fProPagos.OTgRecaudadora.TgNombre, _
                        fProPagos.OTgMoneda.TgNombre, _
                        String.Format("{0:0.00}", fProPagos.ProPaComision), _
                        fProPagos.OTgEstado.TgCodigo}, True)
                 
                Next

                txtCuotasPagadas.Text = liCuotasPagadas
                txtCuotasNoPagadas.Text = liCuotasNoPagadas
                txtCuotasParciales.Text = liCuotasPagoParcial
                txtTotalPagado.Text = CDec(MantenimientosBL.Instancia.proPagosMostrarProPagosMontoTotalXEstadoXConInmIdConsultaProgramacionPagos(ConInmId, "S", "S6177")) + CDec(MantenimientosBL.Instancia.proPagosMostrarProPagosMontoTotalXEstadoXConInmIdConsultaProgramacionPagos(ConInmId, "P"))
                txtPorPagar.Text = CDec(MantenimientosBL.Instancia.proPagosMostrarProPagosMontoTotalXEstadoXConInmIdConsultaProgramacionPagos(ConInmId, "N"))
                txtTotalPagar.Text = CDec(MantenimientosBL.Instancia.proPagosMostrarProPagosMontoTotalXEstadoXConInmIdConsultaProgramacionPagos(ConInmId, "P", "S0835"))
             
            Next

            'CONSULTAMOS TODOS LOS DETALLE X PROGRAMACION DE PAGOS
            Dim liTotalMora As Decimal = 0
            Dim lsProPaId As String = String.Empty
            Dim lsEstadoProPagos As String = String.Empty
            For Each fRow As DataRow In dtProgramacionPagos.Rows
                lsProPaId = fRow("proPaId").ToString()
                If fRow("tgEstado").ToString() = "No Pagado" Then
                    lsEstadoProPagos = "N"
                Else
                    lsEstadoProPagos = String.Empty
                End If

                If ListaProPagosDetalle Is Nothing Then
                    ListaProPagosDetalle = New List(Of EEProPagos.EEProPagosDet)
                End If

                Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarProPagosDetalleXProPaIdXEstado_EnConsultarMora(lsProPaId, lsEstadoProPagos)
                If ListaProPagos IsNot Nothing Then
                    For Each fProPagos As EEProPagos In ListaProPagos
                        For Each fProPagosDetalle As EEProPagos.EEProPagosDet In fProPagos.ListaProgramacionPagosDetalle
                            ListaProPagosDetalle.Add(fProPagosDetalle)
                            Dim ldtgEstado As String
                            ldtgEstado = fRow("tgEstado")
                            If (ldtgEstado = "Sin Detración" Or ldtgEstado = "Pagado") And fProPagosDetalle.OConcepto.ConId = "S0835" & DatePart(DateInterval.Year, fRow("proPaFechaVen")) Then
                                liTotalMora = liTotalMora + fProPagosDetalle.ProPaDetMonto
                            End If
                        Next                        '
                    Next
                End If

            Next
            txtTotalMora.Text = liTotalMora
            gvProgramacionPagos.BestFitColumns()
            mMostrarDetalleProgramacionPagos()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

#Region "RowStyle"
    Private ListaEstadoProPagos As List(Of EETablaGeneral) = Nothing
    Private Sub gvProgramacionPagos_RowStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvProgramacionPagos.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            If ListaEstadoProPagos Is Nothing Then
                ListaEstadoProPagos = MantenimientosBL.Instancia.tablageneralListarXClsId(18)
            End If

            Dim lsEstadoId As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("tgEstadoId"))
            Dim lsExtra As String = ListaEstadoProPagos.Find(Function(ac) ac.TgCodigo = lsEstadoId).TgExtra
            Dim lsExtraColor As String() = lsExtra.Split(",")
            e.Appearance.BackColor = System.Drawing.Color.FromArgb(lsExtraColor(0), lsExtraColor(1), lsExtraColor(2))
        End If
    End Sub
#End Region

    Private Sub gvProgramacionPagos_Click(sender As System.Object, e As System.EventArgs) Handles gvProgramacionPagos.Click
        mMostrarDetalleProgramacionPagos()
    End Sub

    Private Sub gvProgramacionPagos_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvProgramacionPagos.CustomRowCellEditForEditing
        mMostrarDetalleProgramacionPagos()
    End Sub

#Region "Mostrar Detalle Programacion Pagos"
    Private Sub mMostrarDetalleProgramacionPagos()
        If Me.gvProgramacionPagos.DataRowCount <> 0 Then
            dtProgramacionPagosDetalle.Clear()

            Dim lsProPaId As String = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaId").ToString()
            Dim tgEstadoProPagos As String = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "tgEstado").ToString()

            Dim ListaDetalle As List(Of EEProPagos.EEProPagosDet) = ListaProPagosDetalle.FindAll(Function(ac) ac.ProPaId = lsProPaId)

            If ListaDetalle.Count > 0 Then
                For Each fProPagosDetalle As EEProPagos.EEProPagosDet In ListaDetalle
                    dtProgramacionPagosDetalle.LoadDataRow(New Object() {lsProPaId, _
                                fProPagosDetalle.OConcepto.ConId, _
                                fProPagosDetalle.OConcepto.ConNombre, _
                                fProPagosDetalle.ProPaDetPConcepto, _
                                fProPagosDetalle.ProPaDetMonto
                         }, True)
                Next

                If lbCalcularMora = True AndAlso tgEstadoProPagos = "No Pagado" Then
                    Dim ldtFechaVencimiento As Date = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaFechaVen").ToString()
                    Dim liTotalMora As Decimal = 0
                    Dim liDiferenciaFecha As Int16 = DateDiff(DateInterval.Day, CDate(ldtFechaVencimiento), CDate(dtpFechaPago.EditValue))
                    If liDiferenciaFecha > 0 Then
                        Dim ldMora As Decimal = MantenimientosBL.Instancia.parametroMostrarXClsId_ParAnio(72, Year(ldtFechaVencimiento))
                        Dim ldMercedConductiva As Decimal = MantenimientosBL.Instancia.proPagosMostrarMercedCondutivaXProPaId_EnConsultarMora(lsProPaId)
                        Dim ldIGV As Decimal = Convert.ToDecimal(gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaDetIgv").ToString())

                        liTotalMora = liTotalMora + (liDiferenciaFecha * ldMora * (ldMercedConductiva + (ldMercedConductiva * ldIGV)))
                    End If

                    dtProgramacionPagosDetalle.LoadDataRow(New Object() {lsProPaId, _
                              "S0835", _
                               "MORAS ALQUILER DE FINCAS (Recálculo)", _
                               "0.00", _
                              liTotalMora
                        }, True)
                End If

                gvProgramacionPagosDetalle.BestFitColumns()
            End If
        End If
    End Sub
#End Region

    ''' <summary>
    ''' PARA SABER SI YA HIZO CLIC EN CALCULAR MORA Y ASI PODER MOSTRAR
    ''' EL CONCEPTO MORA EN EL DETALLE
    ''' </summary>
    ''' <remarks></remarks>
    Dim lbCalcularMora As Boolean = False
    Private Sub btnCalcularMora_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcularMora.Click
        If dtpFechaPago.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Una Fecha de Pago")
            dtpFechaPago.Focus()
            Exit Sub
        End If

        Dim liTotalMoraRecalculo As Decimal = 0
        Dim liDiferenciaFecha As Int16 = 0
        Dim ldMora As Decimal = 0
        Dim ldMercedConductiva As Decimal = 0
        Dim ldIGV As Decimal = 0
        Dim lsProPaId As String = String.Empty
        Dim ldtgEstado As String = String.Empty

        For Each fRow As DataRow In dtProgramacionPagos.Rows
            If fRow("tgEstado") = "No Pagado" Then
                lsProPaId = fRow("proPaId").ToString()

                liDiferenciaFecha = DateDiff(DateInterval.Day, CDate(fRow("proPaFechaVen").ToString()), CDate(dtpFechaPago.EditValue.ToString()))
                ldtgEstado = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "tgEstado").ToString()
                If liDiferenciaFecha > 0 Then
                    ldMora = MantenimientosBL.Instancia.parametroMostrarXClsId_ParAnio(72, Year(CDate(fRow("proPaFechaVen").ToString())))
                    ldMercedConductiva = MantenimientosBL.Instancia.proPagosMostrarMercedCondutivaXProPaId_EnConsultarMora(lsProPaId)
                    ldIGV = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaDetIgv").ToString()

                    liTotalMoraRecalculo = liTotalMoraRecalculo + (liDiferenciaFecha * ldMora * (ldMercedConductiva + (ldMercedConductiva * ldIGV)))
                End If
            End If
        Next

        txtTotalMoraRecalculo.Text = liTotalMoraRecalculo
        lbCalcularMora = True

        mMostrarDetalleProgramacionPagos()
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Me.btnImprimir.Enabled = False
        EEComun.ExportarPrintForm(Me, Me.Text)
        Me.btnImprimir.Enabled = True
    End Sub
End Class