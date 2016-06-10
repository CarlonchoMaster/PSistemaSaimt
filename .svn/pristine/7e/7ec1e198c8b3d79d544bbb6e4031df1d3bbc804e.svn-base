Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports System.Drawing.Printing
Imports System.IO
Public Class frmConsultaProgramacionPagos
    Inherits frmConsultas

    ''' <summary>
    ''' Para Usarlo Cundo Se Selecciona una Fila en el Visor de Inmueble
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Persona As String

    Dim liCuotasPagadas As Int16 = 0
    Dim liCuotasNoPagadas As Int16 = 0
    Dim liMontoTotal As Decimal = 0
    Dim liMontoTotalConcepto As Decimal = 0
    Dim dtPersona As DataTable = New DataTable()
    Dim dtInmueble As DataTable = New DataTable()
    Dim dtContrato As DataTable = New DataTable()
    Dim dtProgramacionPagos As DataTable = New DataTable()
    Dim dtProgramacionPagosDetalle As DataTable = New DataTable()

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Sub New(ByVal asPersona As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Persona = asPersona
    End Sub

#Region "Construir Table Inmuebles"
    Private Sub ConstruirTableInmuebles()
        dtInmueble.Columns.Add("inmId", GetType(String))
        dtInmueble.Columns.Add("inmFile", GetType(String))
        dtInmueble.Columns.Add("inmDenominacion", GetType(String))
        dtInmueble.Columns.Add("inmInscrito", GetType(String))
        dtInmueble.Columns.Add("inmPartidaElec", GetType(String))
        dtInmueble.Columns.Add("inmUbicacion", GetType(String))
        dtInmueble.Columns.Add("inmFileAnt", GetType(String))
        dtInmueble.Columns.Add("inmDisponibilidad", GetType(Boolean))
        dtInmueble.Columns.Add("tgInmCondReg", GetType(String))
        dtInmueble.Columns.Add("tgInmEstadoId", GetType(String))
        dtInmueble.Columns.Add("inmFecMarg", GetType(DateTime))
        dtInmueble.Columns("inmId").Caption = "Cod. Inmueble"
        dtInmueble.Columns("inmFile").Caption = "File"
        dtInmueble.Columns("inmDenominacion").Caption = "Denominación"
        dtInmueble.Columns("inmInscrito").Caption = "Finca Inscrita"
        dtInmueble.Columns("inmPartidaElec").Caption = "Partida Electronica"
        dtInmueble.Columns("inmUbicacion").Caption = "Ubicación"
        dtInmueble.Columns("inmFileAnt").Caption = "File Antiguo"
        dtInmueble.Columns("inmDisponibilidad").Caption = "Disponibilidad"
        dtInmueble.Columns("tgInmCondReg").Caption = "Situación Legal"
        dtInmueble.Columns("tgInmEstadoId").Caption = "Estado"
        dtInmueble.Columns("inmFecMarg").Caption = "Fecha Margesí"
    End Sub
#End Region

#Region "Construir Table Personas"
    Private Sub ConstruirTablePersonas()
        dtPersona.Columns.Add("perId", GetType(String))
        dtPersona.Columns.Add("perPersona", GetType(String))
        dtPersona.Columns.Add("perContacto", GetType(String))
        dtPersona.Columns.Add("perNDoc", GetType(String))
        dtPersona.Columns.Add("tgTipoPersId", GetType(String))
        dtPersona.Columns.Add("perDireccion", GetType(String))

        dtPersona.Columns("perId").Caption = "Codigo"
        dtPersona.Columns("perPersona").Caption = "Persona"
        dtPersona.Columns("perContacto").Caption = "Contacto"
        dtPersona.Columns("perNDoc").Caption = "Nro. Documento"
        dtPersona.Columns("tgTipoPersId").Caption = "Tipo Persona"
        dtPersona.Columns("perDireccion").Caption = "Dirección"
    End Sub
#End Region

#Region "Construir Table Contrato"
    Private Sub ConstruirTableDetalleContrato()
        dtContrato.Columns.Add("conInmId", GetType(String))
        dtContrato.Columns.Add("inmId", GetType(String))
        dtContrato.Columns.Add("conInmFecIni", GetType(DateTime))
        dtContrato.Columns.Add("conInmFecFin", GetType(DateTime))
        dtContrato.Columns.Add("conInmDiaMaxVen", GetType(String))
        dtContrato.Columns.Add("inmDirLocalizacion", GetType(String))
        dtContrato.Columns.Add("tgUso", GetType(String))
        dtContrato.Columns.Add("tgEstado", GetType(String))
        dtContrato.Columns.Add("tgMoneda", GetType(String))
        dtContrato.Columns.Add("tgModalidad", GetType(String))
        dtContrato.Columns.Add("conInmObs", GetType(String))
        dtContrato.Columns.Add("Anexos", GetType(Int16))

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
        dtProgramacionPagos.Columns.Add("nroComprobante", GetType(String))
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

#Region "Load"
    Private Sub frmVisorProgramacionPagos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTableInmuebles()
        ConstruirTablePersonas()
        ConstruirTableDetalleContrato()
        ConstruirTableProgramacionPagos()
        ConstruirTableProgramacionPagosDetalle()

        dgvPersona.DataSource = dtPersona
        dgvInmueble.DataSource = dtInmueble
        dgvContratos.DataSource = dtContrato
        dgvProgramacionPagos.DataSource = dtProgramacionPagos
        dgvDetalleProgramacionPagos.DataSource = dtProgramacionPagosDetalle

        dgvPersona.Dock = DockStyle.Fill
        dgvInmueble.Dock = DockStyle.Fill

        dgvInmueble.Visible = False

        If Not String.IsNullOrEmpty(Persona) Then
            txtBuscarPersona.Text = Persona
            txtBuscarPersona.Focus()
            Dim key As KeyEventArgs = New KeyEventArgs(Keys.Enter)
            txtBuscarPersona_KeyDown(Nothing, key)
        End If
        AddHandler Me.bbicalcmora.ItemClick, AddressOf btnCalcularM_Click
        AddHandler Me.bbicalcmorasc.ItemClick, AddressOf MostrarSimuladorMora_ItemClick
    End Sub
#End Region

    Private Sub txtBuscarPersona_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarPersona.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtPersona.Clear()
            dtContrato.Clear()
            dtProgramacionPagos.Clear()
            dtProgramacionPagosDetalle.Clear()

            dgvPersona.Visible = True
            dgvInmueble.Visible = False

            mLimpiarText()

            Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaListarCriterioConsultaProgramacionPagos(rdbCriteriosPersona.EditValue, txtBuscarPersona.Text)
            If ListaPersona IsNot Nothing Then
                For Each fPersona As EEPersona In ListaPersona
                    dtPersona.LoadDataRow(New Object() {fPersona.PerId, _
                    fPersona.perNombresoRazon, _
                    fPersona.PerContacto, _
                    fPersona.PerNDoc, _
                    fPersona.perTipoPersona, _
                    fPersona.PerDireccion
                            }, True)
                Next
                gvPersona.BestFitColumns()
                gvPersona_Click(Nothing, Nothing)
                Me.Encontrado = True
            Else
                Me.Encontrado = False
            End If
            MyBase.buscar()
            Me.gvPersona.BestFitColumns()
        End If
    End Sub

    Private Sub txtBuscarInmueble_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarInmueble.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtInmueble.Clear()
            dtContrato.Clear()
            dtProgramacionPagos.Clear()
            dtProgramacionPagosDetalle.Clear()
            dgvPersona.Visible = False
            dgvInmueble.Visible = True
            mLimpiarText()
            Dim ListaInmueble As List(Of EEInmueble) = MantenimientosBL.Instancia.inmuebleListarCriterioConsultaProgramacionPagos(rdbCriteriosInmueble.EditValue, txtBuscarInmueble.Text)
            If ListaInmueble IsNot Nothing Then
                For Each fInmueble As EEInmueble In ListaInmueble
                    Dim lsUbicacion As String = ""
                    dtInmueble.LoadDataRow(New Object() {
                    fInmueble.InmId, _
                    fInmueble.InmFile, _
                    fInmueble.InmDenominacion, _
                    fInmueble.InmInscrito, _
                    fInmueble.InmPartidaElec, _
                    fInmueble.InmUbicacion, _
                    fInmueble.InmFileAnt, _
                    fInmueble.InmDisponibilidad, _
                    fInmueble.tgInmCondReg, _
                    fInmueble.TgInmEstadoNombre, _
                    fInmueble.InmFecMarg
                    }, True)
                Next
                gvInmueble.BestFitColumns()
                Me.Encontrado = True
            Else
                Me.Encontrado = False
            End If
            MyBase.buscar()
            Me.gvInmueble.BestFitColumns()
        End If
    End Sub

    Private Sub gvPersona_Click(sender As System.Object, e As System.EventArgs) Handles gvPersona.Click
        mMostrarContratosXPersona()
    End Sub

    Private Sub gvPersona_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvPersona.CustomRowCellEditForEditing
        mMostrarContratosXPersona()
    End Sub

    Private Sub gvInmueble_Click(sender As System.Object, e As System.EventArgs) Handles gvInmueble.Click
        mMostrarContratosXInmueble()
    End Sub

    Private Sub gvInmueble_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvInmueble.CustomRowCellEditForEditing
        mMostrarContratosXInmueble()
    End Sub

    Private Sub gvContrato_Click(sender As System.Object, e As System.EventArgs) Handles gvContrato.Click
        mMostrarProgramacionPagos()
    End Sub

    Private Sub gvContrato_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvContrato.CustomRowCellEditForEditing
        mMostrarProgramacionPagos()
    End Sub

    Private Sub gvProgramacionPagos_Click(sender As System.Object, e As System.EventArgs) Handles gvProgramacionPagos.Click
        mMostrarDetalleProgramacionPagos()
    End Sub

    Private Sub gvProgramacionPagos_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvProgramacionPagos.CustomRowCellEditForEditing
        mMostrarDetalleProgramacionPagos()
    End Sub

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

    Private Sub chkFiltroBusqueda_CloseUp(sender As System.Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles chkFiltroBusqueda.CloseUp
        If e.AcceptValue = True Then
            If Me.gvProgramacionPagos.DataRowCount <> 0 Then
                Dim lsProPaId As String = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaId").ToString()
                Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarProPagosDetalleXProPaId(lsProPaId)
                dtProgramacionPagosDetalle.Clear()
                If ListaProPagos IsNot Nothing Then
                    liMontoTotalConcepto = 0
                    For Each fProPagos As EEProPagos In ListaProPagos
                        For Each fProPagosDetalle As EEProPagos.EEProPagosDet In fProPagos.ListaProgramacionPagosDetalle
                            dtProgramacionPagosDetalle.LoadDataRow(New Object() {fProPagos.ProPaId, _
                                fProPagosDetalle.OConcepto.ConId, _
                                fProPagosDetalle.OConcepto.ConNombre, _
                                fProPagosDetalle.ProPaDetPConcepto, _
                                fProPagosDetalle.ProPaDetMonto
                             }, True)
                            liMontoTotalConcepto = liMontoTotalConcepto + fProPagosDetalle.ProPaDetMonto
                        Next
                        gvDetalleProgramacionPagos.BestFitColumns()
                        lblNroCuota.Text = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaNroCuota").ToString() & " :"
                        txtTotalConcepto.Text = liMontoTotalConcepto
                    Next
                Else
                    SaimtControles.SaimtMessageBox.mostrarAlertaInformativa("No se encontro Detalle Programacion de Pagos para el Pago Seleccionado.")
                End If
            End If
            For Each fItems As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkFiltroBusqueda.Properties.Items
                If fItems.CheckState = CheckState.Unchecked Then
                    Dim liFila As Integer = 0
                    For Each fDetalle As DataRow In dtProgramacionPagosDetalle.Rows
                        If fItems.Value.ToString() = fDetalle("conId").ToString() Then
                            Dim lsMonto As Decimal = Convert.ToDecimal(fDetalle("proPaDetMonto").ToString())
                            txtTotalConcepto.Text = liMontoTotalConcepto - lsMonto
                            dtProgramacionPagosDetalle.Rows.RemoveAt(liFila)
                            Exit For
                        End If
                        liFila = liFila + 1
                    Next
                End If
            Next
        End If
    End Sub

#Region "Mostrar Contratos X Persona"
    Private Sub mMostrarContratosXPersona()
        If Me.gvPersona.DataRowCount <> 0 Then
            chkFiltroBusqueda.Properties.Items.Clear()

            Dim lsPerId As String = gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "perId").ToString()

            Dim ListaContratos As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoInmListarXPerId_O_XInmIdConsultaProgramacionPagos(lsPerId, Nothing)

            dtContrato.Clear()
            dtProgramacionPagos.Clear()
            dtProgramacionPagosDetalle.Clear()

            mLimpiarText()

            If ListaContratos IsNot Nothing Then
                For Each fContratoInm As EEContratoInm In ListaContratos
                    dtContrato.LoadDataRow(New Object() {fContratoInm.ConInmId, _
                    fContratoInm.OInmueble.InmId, _
                    fContratoInm.ConInmFecIni, _
                    fContratoInm.ConInmFecFin, _
                    fContratoInm.ConInmDiaMaxVen, _
                    fContratoInm.OInmueble.OInmDireccion.InmDireccionCompleta, _
                    fContratoInm.OTgUso.TgNombre, _
                    fContratoInm.OTgEstado.TgNombre, _
                    fContratoInm.OTgMoneda.TgNombre, _
                    fContratoInm.OTgModalidad.TgNombre, _
                    fContratoInm.ConInmObs, _
                    fContratoInm.Anexos
                    }, True)
                Next
                gvContrato.BestFitColumns()
                gvContrato_Click(Nothing, Nothing)
            Else
                SaimtControles.SaimtMessageBox.mostrarAlertaInformativa("No se encontro Contratos para la Persona seleccionada.")
            End If
        End If
    End Sub
#End Region

#Region "Mostrar Contratos X Inmueble"
    Private Sub mMostrarContratosXInmueble()
        If Me.gvInmueble.DataRowCount <> 0 Then
            chkFiltroBusqueda.Properties.Items.Clear()

            Dim lsInmId As String = gvInmueble.GetRowCellValue(Me.gvInmueble.GetSelectedRows(0), "inmId").ToString()

            Dim ListaContratos As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoInmListarXPerId_O_XInmIdConsultaProgramacionPagos(Nothing, lsInmId)

            dtContrato.Clear()
            dtProgramacionPagos.Clear()
            dtProgramacionPagosDetalle.Clear()

            mLimpiarText()

            If ListaContratos IsNot Nothing Then
                For Each fContratoInm As EEContratoInm In ListaContratos
                    Dim lsUbicacion As String = ""

                    dtContrato.LoadDataRow(New Object() {fContratoInm.ConInmId, _
                    fContratoInm.OInmueble.InmId, _
                    fContratoInm.ConInmFecIni, _
                    fContratoInm.ConInmFecFin, _
                    fContratoInm.ConInmDiaMaxVen, _
                    lsUbicacion, _
                    fContratoInm.OTgUso.TgNombre, _
                    fContratoInm.OTgEstado.TgNombre, _
                    fContratoInm.OTgMoneda.TgNombre, _
                    fContratoInm.OTgModalidad.TgNombre
                    }, True)

                Next
                gvContrato.BestFitColumns()
                gvContrato_Click(Nothing, Nothing)
            Else
                SaimtControles.SaimtMessageBox.mostrarAlertaInformativa("No se encontro Contratos para el Inmueble seleccionado.")
            End If
        End If
    End Sub
#End Region

#Region "Mostrar Programacion Pagos"
    Private Sub mMostrarProgramacionPagos()
        If Me.gvContrato.DataRowCount <> 0 Then
            chkFiltroBusqueda.Properties.Items.Clear()

            Dim lsConInmId As String = gvContrato.GetRowCellValue(Me.gvContrato.GetSelectedRows(0), "conInmId").ToString()

            Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarXConInmIdConsultaProgramacionPagos(lsConInmId)

            dtProgramacionPagos.Clear()
            dtProgramacionPagosDetalle.Clear()

            If ListaProPagos IsNot Nothing Then
                liCuotasPagadas = 0
                liCuotasNoPagadas = 0

                For Each fProPagos As EEProPagos In ListaProPagos
                    If fProPagos.OTgEstado.TgCodigo = "N" Then
                        liCuotasNoPagadas = liCuotasNoPagadas + 1
                    ElseIf fProPagos.OTgEstado.TgCodigo = "P" Then
                        liCuotasPagadas = liCuotasPagadas + 1
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
                   fProPagos.OTgEstado.TgCodigo,
                                                fProPagos.NroComprobante
                }, True)
                Next
                gvProgramacionPagos.BestFitColumns()

                txtCuotasPagadas.Text = liCuotasPagadas
                txtCuotasNoPagadas.Text = liCuotasNoPagadas
                txtTotalPagado.Text = MantenimientosBL.Instancia.proPagosMostrarProPagosMontoTotalXEstadoXConInmIdConsultaProgramacionPagos(lsConInmId, "P")
                txtPorPagar.Text = MantenimientosBL.Instancia.proPagosMostrarProPagosMontoTotalXEstadoXConInmIdConsultaProgramacionPagos(lsConInmId, "N")
                txtTotalPagar.Text = Convert.ToDecimal(txtTotalPagado.Text) + Convert.ToDecimal(txtPorPagar.Text)

                gvProgramacionPagos_Click(Nothing, Nothing)
            Else
                SaimtControles.SaimtMessageBox.mostrarAlertaInformativa("No se encontro Programacion de Pagos para el Contrato Seleccionado.")
            End If
        End If
    End Sub
#End Region

#Region "Mostrar Detalle Programacion Pagos"
    Private Sub mMostrarDetalleProgramacionPagos()
        If Me.gvProgramacionPagos.DataRowCount <> 0 Then

            Dim lsProPaId As String = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaId").ToString()

            Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarProPagosDetalleXProPaId(lsProPaId)

            dtProgramacionPagosDetalle.Clear()

            If ListaProPagos IsNot Nothing Then
                liMontoTotalConcepto = 0

                chkFiltroBusqueda.Properties.Items.Clear()

                For Each fProPagos As EEProPagos In ListaProPagos

                    For Each fProPagosDetalle As EEProPagos.EEProPagosDet In fProPagos.ListaProgramacionPagosDetalle
                        dtProgramacionPagosDetalle.LoadDataRow(New Object() {fProPagos.ProPaId, _
                            fProPagosDetalle.OConcepto.ConId, _
                            fProPagosDetalle.OConcepto.ConNombre, _
                            fProPagosDetalle.ProPaDetPConcepto, _
                            fProPagosDetalle.ProPaDetMonto
                         }, True)

                        Me.chkFiltroBusqueda.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem(CType(fProPagosDetalle.OConcepto.ConId, String), fProPagosDetalle.OConcepto.ConId & " - " & fProPagosDetalle.OConcepto.ConNombre, CheckState.Checked)})

                        liMontoTotalConcepto = liMontoTotalConcepto + fProPagosDetalle.ProPaDetMonto
                    Next
                    gvDetalleProgramacionPagos.BestFitColumns()
                    lblNroCuota.Text = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaNroCuota").ToString() & " :"
                    txtTotalConcepto.Text = liMontoTotalConcepto
                Next
            Else
                SaimtControles.SaimtMessageBox.mostrarAlertaInformativa("No se encontro Detalle Programacion de Pagos para el Pago Seleccionado.")
            End If
        End If
    End Sub
#End Region

#Region "Limpiar Text"
    Private Sub mLimpiarText()
        txtCuotasPagadas.Text = 0
        txtCuotasNoPagadas.Text = 0
        txtTotalPagado.Text = 0
        txtTotalConcepto.Text = 0
        txtTotalPagar.Text = 0
        txtPorPagar.Text = 0
    End Sub
#End Region

    Private Sub btnimprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnimprimir.Click
        If Me.gvProgramacionPagos.GetSelectedRows.Length > 0 Then
            If Me.gvDetalleProgramacionPagos.RowCount > 0 Then
                Me.btnimprimir.Enabled = False
                Dim xl As Excel.Application = EEExcel.Instancia
                xl.Workbooks.Open(EEComun.RutaReportes & "\RptOrdenPago.xls", 1, True, 4)
                ExportarOrdenPago(xl.Sheets(1), Me.gvProgramacionPagos.GetFocusedRowCellValue("proPaId").ToString.Trim, 7)
                Me.btnimprimir.Enabled = True
                xl.Application.Visible = True
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("La Cuota seleccionada no tienes Detalles de Programación")
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Debe seleccionar alguna de los contratos mostrados")
        End If
    End Sub

    Private Sub ExportarOrdenPago(ByVal xlhoja As Excel.Worksheet, ByVal aopropaid As String, ByVal fila As Integer)
        Me.pgbprogreso.Maximum = dtProgramacionPagosDetalle.Rows.Count
        Me.pgbprogreso.Minimum = 0
        Application.DoEvents()
        Me.bieprogreso.Caption = "Exportando... "
        Me.bieprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Dim CabOrdenPago As List(Of EEProPagos) = Nothing
        Dim sumaT As Double = Nothing
        Dim NroProPag As Integer = Nothing
        Dim enc As Boolean = False
        Try
            CabOrdenPago = MantenimientosBL.Instancia.proPagosReporte_OrdenPagoCab(aopropaid)
            NroProPag = 0
            sumaT = 0
            Application.DoEvents()
            Me.bieprogreso.EditValue = 1
            xlhoja.Select()
            xlhoja.Cells(fila, 6) = MantenimientosBL.Instancia.FechaServidor
            xlhoja.Cells(fila, 6).NumberFormat = "dd/mm/yyyy hh:mm"
            fila = fila + 1
            xlhoja.Cells(fila, 6) = CabOrdenPago.Item(0).ProPaFechaVen
            xlhoja.Cells(fila, 2) = Format(CabOrdenPago.Item(0).ProPaNroCuota, "00")
            fila = fila + 1
            xlhoja.Cells(fila, 2) = CabOrdenPago.Item(0).OContratoInm.ConInmId
            xlhoja.Cells(fila, 6) = CabOrdenPago.Item(0).OTgMoneda.TgDescripcion
            fila = fila + 1
            xlhoja.Cells(fila, 2) = CabOrdenPago.Item(0).OPersona.PerApePaterno & Space(1) & CabOrdenPago.Item(0).OPersona.PerApeMaterno & ", " & CabOrdenPago.Item(0).OPersona.PerNombres & " - " & CabOrdenPago.Item(0).OPersona.PerRazonSocial
            fila = fila + 1
            xlhoja.Cells(fila, 2) = CabOrdenPago.Item(0).ProPaDireccionFinca
            fila = fila + 1
            xlhoja.Cells(fila, 2) = UCase(MonthName(Month(CabOrdenPago.Item(0).ProPaFechaVen)))
            xlhoja.Cells(fila, 4) = Year(CabOrdenPago.Item(0).ProPaFechaVen)
            xlhoja.Cells(fila, 6) = CabOrdenPago.Item(0).ProPaNroCuota & CabOrdenPago.Item(0).OContratoInm.ConInmId
            fila = fila + 3
            For NroProPag = 0 To dtProgramacionPagosDetalle.Rows.Count - 1
                Application.DoEvents()
                Me.bieprogreso.EditValue = Me.bieprogreso.EditValue + 1
                xlhoja.Cells(fila, 1) = dtProgramacionPagosDetalle.Rows(NroProPag).Item("conId").ToString.Substring(0, 5)
                xlhoja.Cells(fila, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                xlhoja.Cells(fila, 2) = dtProgramacionPagosDetalle.Rows(NroProPag).Item("conNombre").ToString
                xlhoja.Cells(fila, 6) = Convert.ToDouble(dtProgramacionPagosDetalle.Rows(NroProPag).Item("proPaDetMonto"))
                xlhoja.Cells(fila, 6).NumberFormat = "###,##0.00"
                xlhoja.Cells(fila, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                sumaT = sumaT + Convert.ToDouble(dtProgramacionPagosDetalle.Rows(NroProPag).Item("proPaDetMonto"))
                fila = fila + 1
            Next
            xlhoja.Cells(fila, 6) = sumaT
            xlhoja.Cells(fila, 6).NumberFormat = "###,##0.00"
            xlhoja.Cells(fila, 6).Font.Bold = True
            xlhoja.Cells(fila, 6).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlhoja.Cells(fila, 6).Interior.Color = RGB(217, 217, 217)
            xlhoja.Cells(fila, 5) = "Total Cuota N° " & Format(CabOrdenPago.Item(0).ProPaNroCuota, "00")
            xlhoja.Cells(fila, 5).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlhoja.Cells(fila, 5).Font.Bold = True
            fila = fila + 2
            xlhoja.Cells(fila, 2) = "SON: " & UCase(EEComun.MonedaLetras(sumaT.ToString.Trim)) & Space(1) & IIf(CabOrdenPago.Item(0).OTgMoneda.TgCodigo = "S", "NUEVOS SOLES", "DÓLARES AMERICANOS")
            xlhoja.Cells(fila, 2).Font.Size = 7
            xlhoja.Cells(fila, 2).Font.Bold = True
            xlhoja.Cells(fila, 2).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            xlhoja.Cells(fila, 2).Resize(1, 5).MergeCells = True
            xlhoja.Cells(fila, 2).Resize(1, 5).WrapText = True
            xlhoja.Cells(fila, 2).RowHeight = 19.5
            Me.bieprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError("ExportarOrdenPago => " & ex.Message)
        End Try
    End Sub

    Private Sub btnimprimirf_Click(sender As System.Object, e As System.EventArgs) Handles btnimprimirf.Click
        If Me.gvProgramacionPagos.GetSelectedRows.Length > 0 Then
            Me.btnimprimirf.Enabled = False
            EEComun.ExportarPrintForm(Me, Me.Text)
            Me.btnimprimirf.Enabled = True
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Debe Seleccionar Algún Contrato Seleccionado")
        End If
    End Sub

    Private Sub btnCalcularM_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcularM.Click
        If gvContrato.FocusedRowHandle > -1 Then
            Dim fmConsultaMora As frmConsultarMora = New frmConsultarMora()
            fmConsultaMora.PerId = gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "perId").ToString()
            fmConsultaMora.ConInmId = gvContrato.GetRowCellValue(Me.gvContrato.GetSelectedRows(0), "conInmId").ToString()
            fmConsultaMora.MdiParent = Me.MdiParent
            fmConsultaMora.BringToFront()
            fmConsultaMora.Show()
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Debe Seleccionar un Contrato")
        End If
    End Sub


    Private Sub btnCalcularMora_ItemClick()
        If gvContrato.FocusedRowHandle > -1 Then
            Dim fmConsultaMora As frmConsultarMora = New frmConsultarMora()
            fmConsultaMora.PerId = gvPersona.GetRowCellValue(Me.gvPersona.GetSelectedRows(0), "perId").ToString()
            fmConsultaMora.ConInmId = gvContrato.GetRowCellValue(Me.gvContrato.GetSelectedRows(0), "conInmId").ToString()
            fmConsultaMora.MdiParent = Me.MdiParent
            fmConsultaMora.BringToFront()
            fmConsultaMora.Show()
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Debe Seleccionar un Contrato")
        End If
    End Sub


    Private Sub MostrarSimuladorMora_ItemClick()
        Dim ofrm As New frmSimulador
        ofrm.MdiParent = Me.MdiParent
        ofrm.Show()
    End Sub

    Private Sub VerGaleriaDeArchivosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerGaleriaDeArchivosToolStripMenuItem.Click
        If Convert.ToInt16(gvContrato.GetRowCellValue(Me.gvContrato.GetSelectedRows(0), "Anexos")) = 1 Then
            Try
                Dim frmGaleriaContrato As frmGaleriaContrato = New frmGaleriaContrato()
                frmGaleriaContrato.OConInmArchivos = MantenimientosBL.Instancia.contratoListarArchivosXConInmId(gvContrato.GetRowCellValue(Me.gvContrato.GetSelectedRows(0), "conInmId").ToString())
                frmGaleriaContrato.Show()
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnComprobantePago_Click(sender As System.Object, e As System.EventArgs) Handles btnComprobantePago.Click
        If Me.gvProgramacionPagos.DataRowCount <> 0 Then
            Dim propaId As String
            propaId = gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "proPaId").ToString()
            Dim fmCompProgramacion As frmCompProgramacion = New frmCompProgramacion(propaId, gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "tgTipoComprobante").ToString(), gvProgramacionPagos.GetRowCellValue(Me.gvProgramacionPagos.GetSelectedRows(0), "nroComprobante").ToString())
            If fmCompProgramacion.ShowDialog() = DialogResult.OK Then
                dtProgramacionPagos.Rows(Me.gvProgramacionPagos.GetSelectedRows(0))("nroComprobante") = fmCompProgramacion.Serie & "-" & fmCompProgramacion.Numero
            End If
        End If
    End Sub
End Class