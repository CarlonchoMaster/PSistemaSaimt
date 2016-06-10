﻿Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Imports Word = Microsoft.Office.Interop.Word
Imports System.Drawing.Printing
Imports System.IO

Public Class frmContrato

    Dim dtConArchivos As DataTable = New DataTable()
    Dim dtListadoPersona As DataTable = New DataTable
    Dim dtListadoContratos As DataTable = New DataTable
    'Lista Manejo Archivoss
    Dim ListaTemporalConArchivosEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalConArchivosNuevos As List(Of EEConArchivos) = New List(Of EEConArchivos)
    Dim ListaTemporalConArchivosEditados As List(Of EEConArchivos) = New List(Of EEConArchivos)
    Dim listaArrendatarios As List(Of EEPersona) = Nothing
    Dim listaContratos As List(Of EEContratoInm) = Nothing
    'Fin Lista
    Dim loConInmGaleria As List(Of EEConArchivos) = New List(Of EEConArchivos)
    Dim liPerId As String = String.Empty

#Region "Construir Table"
    Private Sub ConstruirTableArchivos()
        dtConArchivos.Columns.Add("conInmArchId", GetType(String))
        dtConArchivos.Columns.Add("conInmArchNombre", GetType(String))
        dtConArchivos.Columns.Add("conInmArchDescripcion", GetType(String))
        dtConArchivos.Columns.Add("tgTipoArchId", GetType(String))
        dtConArchivos.Columns.Add("conInmArch", GetType(Byte()))
        dtConArchivos.Columns.Add("conInmArchExt", GetType(String))

        dtConArchivos.Columns("conInmArchId").ColumnMapping = MappingType.Hidden
        dtConArchivos.Columns("tgTipoArchId").ColumnMapping = MappingType.Hidden
        dtConArchivos.Columns("conInmArch").ColumnMapping = MappingType.Hidden

        dtConArchivos.Columns("conInmArchNombre").Caption = "Nombre"
        dtConArchivos.Columns("conInmArchDescripcion").Caption = "Descripcion"
        dtConArchivos.Columns("conInmArchExt").Caption = "Extension"

    End Sub
    Private Sub ConstruirTableListadoPersona()
        dtListadoPersona.Columns.Add("CodPersona", GetType(String))
        dtListadoPersona.Columns.Add("Persona", GetType(String))
    End Sub

    Private Sub ConstruirTablaListadoContratos()
        dtListadoContratos.Columns.Add("CodContrato", GetType(String))
        dtListadoContratos.Columns.Add("FechaIni", GetType(Date))
        dtListadoContratos.Columns.Add("FechaFin", GetType(Date))
    End Sub
#End Region

#Region "Propiedades"
    Private _ConEstId As String
    Public Property ConEstId() As String
        Get
            Return _ConEstId
        End Get
        Set(ByVal value As String)
            _ConEstId = value
        End Set
    End Property
    Private _ConInmId As String
    Public Property ConInmId() As String
        Get
            Return _ConInmId
        End Get
        Set(ByVal value As String)
            _ConInmId = value
        End Set
    End Property
    Private _ConObs As String
    Public Property ConObs() As String
        Get
            Return _ConObs
        End Get
        Set(ByVal value As String)
            _ConObs = value
        End Set
    End Property
    Private _PerDistrito As String
    Public Property PerDistrito() As String
        Get
            Return _PerDistrito
        End Get
        Set(ByVal value As String)
            _PerDistrito = value
        End Set
    End Property
    Private _PerProvincia As String
    Public Property PerProvincia() As String
        Get
            Return _PerProvincia
        End Get
        Set(ByVal value As String)
            _PerProvincia = value
        End Set
    End Property
    Private _PerDepartamento As String
    Public Property PerDepartamento() As String
        Get
            Return _PerDepartamento
        End Get
        Set(ByVal value As String)
            _PerDepartamento = value
        End Set
    End Property

    Private _InmDistrito As String
    Public Property InmDistrito() As String
        Get
            Return _InmDistrito
        End Get
        Set(ByVal value As String)
            _InmDistrito = value
        End Set
    End Property
    Private _InmProvincia As String
    Public Property InmProvincia() As String
        Get
            Return _InmProvincia
        End Get
        Set(ByVal value As String)
            _InmProvincia = value
        End Set
    End Property
    Private _InmDepartamento As String
    Public Property InmDepartamento() As String
        Get
            Return _InmDepartamento
        End Get
        Set(ByVal value As String)
            _InmDepartamento = value
        End Set
    End Property
#End Region

#Region "Funciones Sobreescritas"
    Protected Overrides Sub guardar()
        Try
            If Me.txtPerId.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaInformativa("Debe de buscar una Persona para registrar el Contrato")
                Exit Sub
            End If

            'frmContrato.txtCodInmueble
            If Me.txtCodInmueble.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaInformativa("Debe de buscar un inmueble para registrar el Contrato")
                Exit Sub
            End If

            If Val(txtMerced.Text) <= 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("El monto de la Merced no puede ser 0.00, ingrese un valor correcto")
                Exit Sub
            End If

            If Val(txtDiaMaxVen.Text) <= 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Los dias max de vencimiento deben ser mayores que 1")
                Exit Sub
            End If

            Dim loContratoInm As EEContratoInm = New EEContratoInm() With {.ConInmId = GIdRegistroActual, .InmId = txtCodInmueble.Text, .InmDir = txtDirInmueble.Text, .TgEstId = cboEstadoContrato.EditValue, .TgModId = cbModalidad.EditValue, .TgMonId = cboTipoMoneda.EditValue, .TgUsoId = cboUso.EditValue, .ConInmFecIni = dtFechaInicio.EditValue, .ConInmFecFin = dtFechaFin.EditValue, .ConInmMerced = txtMerced.Text, .ConInmGarantia = txtGarantia.Text, .ConInmDerLlaves = txtDerLlave.Text, .ConInmObs = txtObsCon.Text, .ConInmDiaMaxVen = txtDiaMaxVen.Text, .ConInmDocRef = txtDocRef.Text, .PerId = txtPerId.Text, .tgCompId = cboTipoComprobante.EditValue, .ConInmFecSol = dtFechaSol.EditValue, .ConInmFecSus = dtFechaSus.EditValue, .conInmRegMesPart = txtRegMesPart.Text, .TgGarId = cboTipoGarantia.EditValue}
            If GEstadoNuevo Then
                If SaimtMessageBox.mostrarAlertaPregunta("Desea Generar Automaticamente las Programaciones de Pagos") Then
                    Application.DoEvents()
                    Me.RepositoryItemMarqueeProgressBar1.Stopped = False
                    Me.bieprogresomarque.Caption = "Gererando Programaciones de Pago..."
                    Me.bieprogresomarque.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Application.DoEvents()
                    'Archivos
                    For Each fTablaArchivos As DataRow In dtConArchivos.Rows
                        Dim loConInmArchivos As EEConArchivos = New EEConArchivos()
                        loConInmArchivos.ConArchId = fTablaArchivos("ConInmArchId")
                        loConInmArchivos.ConInmArchNombre = fTablaArchivos("ConInmArchNombre")
                        loConInmArchivos.ConInmArchDescripcion = fTablaArchivos("ConInmArchDescripcion")
                        loConInmArchivos.TgTipoArchId = fTablaArchivos("tgTipoArchId")
                        loConInmArchivos.ConInmArch = fTablaArchivos("ConInmArch")
                        loConInmArchivos.ConInmArchExt = fTablaArchivos("ConInmArchExt")
                        loContratoInm.ListaConInmArchivos.Add(loConInmArchivos)
                    Next

                    GIdRegistroActual = MantenimientosBL.Instancia.contratoInmGuardarGProgramacion(loContratoInm)
                    Me.bieprogresomarque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.RepositoryItemMarqueeProgressBar1.Stopped = True
                Else
                    Application.DoEvents()
                    Me.RepositoryItemMarqueeProgressBar1.Stopped = False
                    Me.bieprogresomarque.Caption = "Gererando Programaciones de Pago..."
                    Me.bieprogresomarque.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Application.DoEvents()
                    GIdRegistroActual = MantenimientosBL.Instancia.contratoInmGuardar(loContratoInm)
                    Me.bieprogresomarque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.RepositoryItemMarqueeProgressBar1.Stopped = True
                End If
                If SaimtMessageBox.mostrarAlertaPregunta(String.Format("Desea Imprimir el contrato {0} Generado", GIdRegistroActual)) Then
                    Print()
                End If
            Else

                loContratoInm.ListaConInmArchivosTemporalNuevos = ListaTemporalConArchivosNuevos
                loContratoInm.ListaConInmArchivosTemporalEliminados = ListaTemporalConArchivosEliminados
                loContratoInm.ListaConInmArchivosEditados = ListaTemporalConArchivosEditados
                MantenimientosBL.Instancia.contratoInmActualizar(loContratoInm)

                ListaTemporalConArchivosNuevos.Clear()
                ListaTemporalConArchivosEliminados.Clear()
                ListaTemporalConArchivosEditados.Clear()
            End If
            Me.enabledGA = False
            MyBase.guardar()
            txtBuscarPersonaPor.Properties.ReadOnly = False
            ' listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            dtListadoContratos.Clear()
            GValorTextoBuscado = txtBuscarContratoPor.Text
            GCriterioBuscado = cboBuscarContratoPor.SelectedIndex
            Dim ListaContratoInm As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoInmListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            If ListaContratoInm IsNot Nothing Then
                For Each fContrato As EEContratoInm In ListaContratoInm
                    dtListadoContratos.LoadDataRow(New Object() {fContrato.ConInmId,
                                                               fContrato.ConInmFecIni,
                                                               fContrato.ConInmFecFin
                                   }, True)
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
            dtListadoContratos.Clear()
            Dim ListaContratoInm As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoInmListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            If ListaContratoInm IsNot Nothing Then
                For Each fContrato As EEContratoInm In ListaContratoInm
                    dtListadoContratos.LoadDataRow(New Object() {fContrato.ConInmId,
                                                               fContrato.ConInmFecIni,
                                                               fContrato.ConInmFecFin
                                   }, True)
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

    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvListadoContratos.DataRowCount <> 0 Then
                Dim loContratoInm As EEContratoInm = MantenimientosBL.Instancia.contratoInmMostrarXConInmId(gvListadoContratos.GetRowCellValue(Me.gvListadoContratos.GetSelectedRows(0), "CodContrato").ToString())

                If loContratoInm IsNot Nothing Then


                    'PERSONA
                    txtPerId.Text = loContratoInm.OPersona.PerId
                    txtNroDocumento.Text = loContratoInm.OPersona.PerNDoc
                    cboTipoPersona.EditValue = loContratoInm.OPersona.TgTipoPersId
                    txtNombreRazon.Text = loContratoInm.OPersona.Persona
                    Me.txtNombreRazon.Tag = String.Empty
                    txtTipoDocumento.Text = loContratoInm.OPersona.TgTipoDoc
                    txtObsPer.Text = loContratoInm.OPersona.PerObservacion
                    txtDireccion.Text = loContratoInm.OPersona.PerDireccion
                    PerDistrito = loContratoInm.OPersona.PerDistrito
                    PerDepartamento = loContratoInm.OPersona.PerDepartamento
                    PerProvincia = loContratoInm.OPersona.PerProvincia
                    'FIN PERSONA

                    'Datos Contrato

                    loConInmGaleria = loContratoInm.ListaConInmArchivos
                    cboTipoComprobante.EditValue = loContratoInm.tgCompId
                    txtNroContrato.Text = loContratoInm.ConInmId
                    txtCodInmueble.Text = loContratoInm.InmId
                    txtDirInmueble.Text = loContratoInm.InmDir
                    cboEstadoContrato.EditValue = loContratoInm.TgEstId
                    cbModalidad.EditValue = loContratoInm.TgModId
                    cboTipoMoneda.EditValue = loContratoInm.TgMonId
                    txtMerced.Text = loContratoInm.ConInmMerced
                    txtGarantia.Text = loContratoInm.ConInmGarantia
                    cboTipoGarantia.EditValue = loContratoInm.TgGarId
                    cboUso.EditValue = loContratoInm.TgUsoId
                    dtFechaInicio.EditValue = loContratoInm.ConInmFecIni
                    dtFechaFin.EditValue = loContratoInm.ConInmFecFin
                    dtFechaSus.EditValue = loContratoInm.ConInmFecSus
                    dtFechaSol.EditValue = loContratoInm.ConInmFecSol
                    txtDerLlave.Text = loContratoInm.ConInmDerLlaves
                    txtObsCon.Text = loContratoInm.ConInmObs
                    txtDiaMaxVen.Text = loContratoInm.ConInmDiaMaxVen
                    txtDocRef.Text = loContratoInm.ConInmDocRef
                    txtRegMesPart.Text = loContratoInm.conInmRegMesPart
                    GIdRegistroActual = loContratoInm.ConInmId
                    InmDistrito = loContratoInm.InmDistrito
                    InmDepartamento = loContratoInm.InmDepartamento
                    InmProvincia = loContratoInm.InmProvincia

                    'Archivos
                    txtNroContrato1.Text = loContratoInm.ConInmId

                    dtConArchivos.Clear()
                    btnArchivosAnexados.Visible = False
                    For Each fArchivos As EEConArchivos In loContratoInm.ListaConInmArchivos

                        dtConArchivos.LoadDataRow(New Object() { _
                                fArchivos.ConArchId, _
                                fArchivos.ConInmArchNombre, _
                                fArchivos.ConInmArchDescripcion, _
                                fArchivos.TgTipoArchId, _
                                fArchivos.ConInmArch, _
                                fArchivos.ConInmArchExt
                        }, True)

                        btnArchivosAnexados.Visible = True
                    Next

                    If loContratoInm.TgEstId = 1 Then
                        btnCancelarContrato.Enabled = True
                    Else
                        btnCancelarContrato.Enabled = False
                    End If
                    btnArchivosAnexados.Enabled = True
                    MyBase.seleccionarListado()
                    txtBuscarPersonaPor.Properties.ReadOnly = False
                End If

            Else
                MyBase.limpiar()
            End If
            btnVerArchivos.Enabled = True
            dgvArchivos.Enabled = True

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        txtPerId.Properties.ReadOnly = True
        txtNroDocumento.Properties.ReadOnly = True
        cboTipoPersona.Properties.ReadOnly = True
        txtNombreRazon.Properties.ReadOnly = True
        txtDireccion.Properties.ReadOnly = True
        txtObsPer.Properties.ReadOnly = True
        txtCodInmueble.Properties.ReadOnly = True
        txtDirInmueble.Properties.ReadOnly = True
        txtNroContrato.Properties.ReadOnly = True
        cboEstadoContrato.Properties.ReadOnly = True
        txtTipoDocumento.Properties.ReadOnly = True
        btnBuscarPersona.Enabled = False
        btnConsultarConyuge.Enabled = False
        txtBuscarArchivo.Properties.ReadOnly = True
        If cboEstadoContrato.Text = "Terminado" Then
            btnCancelarContrato.Enabled = False
        Else
            btnCancelarContrato.Enabled = True
        End If
        Dim proPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarNroCuotasNoPagadasXConInmId(txtNroContrato.Text)
        If proPagos IsNot Nothing Then
            If proPagos.Count = proPagos.Item(0).ProPaTotalCuotas Then
                txtMerced.Properties.ReadOnly = False
                btnincrementar.Enabled = True
            Else
                txtMerced.Properties.ReadOnly = True
                btnincrementar.Enabled = False
            End If
        Else
            txtMerced.Properties.ReadOnly = True
            btnincrementar.Enabled = False
        End If
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtPerId.Properties.ReadOnly = True
        txtNroDocumento.Properties.ReadOnly = True
        cboTipoPersona.Properties.ReadOnly = True
        txtNombreRazon.Properties.ReadOnly = True
        txtDireccion.Properties.ReadOnly = True
        txtObsPer.Properties.ReadOnly = True
        txtCodInmueble.Properties.ReadOnly = True
        txtDirInmueble.Properties.ReadOnly = True
        txtNroContrato.Properties.ReadOnly = True
        btnCancelarContrato.Enabled = False
        cboEstadoContrato.ItemIndex = 0
        cboEstadoContrato.Properties.ReadOnly = True
        txtTipoDocumento.Properties.ReadOnly = True
        btnBuscarPersona.Enabled = True
        btnConsultarConyuge.Enabled = True
        btnImprimir.Enabled = True
        cboTipoMoneda.ItemIndex = 3
        cbModalidad.ItemIndex = 0
        txtDerLlave.Text = 0
        txtGarantia.Text = 0
        txtDiaMaxVen.Text = 4
    End Sub
#End Region

#Region "Load"
    Private Sub frmContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PuedeBuscar = True
            Me.PuedeCrear = True
            Me.PuedeEditar = True
            Me.PuedeExportar = True
            Me.PuedeImprimir = True
            ConstruirTableArchivos()
            ConstruirTableListadoPersona()
            ConstruirTablaListadoContratos()
            dgvArchivos.DataSource = dtConArchivos
            dgvListadoPersona.DataSource = dtListadoPersona
            dgvListadoContratos.DataSource = dtListadoContratos

            cboTipoComprobante.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoComprobante.Properties.DisplayMember = "TgNombre"
            cboTipoComprobante.Properties.ValueMember = "TgCodigo"
            cboTipoComprobante.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(36)
            cboTipoComprobante.ItemIndex = 0

            cboTipoPersona.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoPersona.Properties.DisplayMember = "TgNombre"
            cboTipoPersona.Properties.ValueMember = "TgCodigo"
            cboTipoPersona.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(6)
            cboTipoPersona.ItemIndex = 0

            cboTipoMoneda.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoMoneda.Properties.DisplayMember = "TgNombre"
            cboTipoMoneda.Properties.ValueMember = "TgCodigo"
            cboTipoMoneda.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(5)
            cboTipoMoneda.ItemIndex = 0

            cboUso.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboUso.Properties.DisplayMember = "TgNombre"
            cboUso.Properties.ValueMember = "TgCodigo"
            cboUso.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(16)
            cboUso.ItemIndex = 0

            cboEstadoContrato.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboEstadoContrato.Properties.DisplayMember = "TgNombre"
            cboEstadoContrato.Properties.ValueMember = "TgCodigo"
            cboEstadoContrato.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(17)
            cboEstadoContrato.ItemIndex = 0

            cbModalidad.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cbModalidad.Properties.DisplayMember = "TgNombre"
            cbModalidad.Properties.ValueMember = "TgCodigo"
            cbModalidad.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(38)

            cboTipoGarantia.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoGarantia.Properties.DisplayMember = "TgNombre"
            cboTipoGarantia.Properties.ValueMember = "TgCodigo"
            cboTipoGarantia.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(77)

            cboTipoArchivos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoArchivos.Properties.DisplayMember = "TgNombre"
            cboTipoArchivos.Properties.ValueMember = "TgCodigo"
            cboTipoArchivos.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(30)
            cboTipoArchivos.ItemIndex = 0

            Dim ListaTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId(30)
            Dim lsExtenciones As String = ""
            For Each fTablaGeneral As EETablaGeneral In ListaTablaGeneral
                lsExtenciones += fTablaGeneral.TgAbrev + ";"
            Next

            ofdExaminarArchivos.Filter = "Archivos(" + lsExtenciones + ")|" + lsExtenciones
            ofdExaminarArchivos.Title = "Seleccionar Archivos"

            btnVerArchivos.Enabled = False

            cboTipoUso.Properties.ReadOnly = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub btnBuscarPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPersona.Click
        Using fmConsultaPersona As frmConsultaPersonaGeneral = New frmConsultaPersonaGeneral(3)
            If fmConsultaPersona.ShowDialog() = DialogResult.OK Then
                cboTipoPersona.EditValue = fmConsultaPersona.PerTipo
                txtNombreRazon.Text = fmConsultaPersona.PerNombre
                txtDireccion.Text = fmConsultaPersona.PerDireccion
                txtTipoDocumento.Text = fmConsultaPersona.PerTipoDoc
                txtNroDocumento.Text = fmConsultaPersona.perNdoc
                txtObsPer.Text = fmConsultaPersona.PerObs
                txtPerId.Text = fmConsultaPersona.PerId
                Me.txtNombreRazon.Tag = fmConsultaPersona.OContacto
            End If
        End Using
    End Sub

    Private Sub btnConsultarConyuge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarConyuge.Click
        Using fmConsultainmueble As frmConsultaInmueble = New frmConsultaInmueble()
            If fmConsultainmueble.ShowDialog() = DialogResult.OK Then
                txtCodInmueble.Text = fmConsultainmueble.InmId
                txtDirInmueble.Text = fmConsultainmueble.InmDir
            End If
        End Using
    End Sub

    Private Sub btnCancelarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarContrato.Click
        Dim fmContratoCancelacion As frmContratoCancelacion = New frmContratoCancelacion()
        fmContratoCancelacion.txtNroContrato.Text = txtNroContrato.Text
        fmContratoCancelacion.txtObsContrato.Text = txtObsCon.Text
        Me.fmCancelacionData = fmContratoCancelacion
    End Sub

    Private Sub Print()
        Dim oWordN As Word.Application
        Dim oDocN As Word._Document = Nothing
        Dim loContratoDatosAnt As List(Of EEContratoInm) = Nothing
        Try
            Try
                loContratoDatosAnt = MantenimientosBL.Instancia.ContratoDatosAdicionalesXConInmId(GIdRegistroActual)
            Catch ex As Exception

            End Try
            If loContratoDatosAnt IsNot Nothing Then
                Me.ripprogreso.Maximum = 3 + loContratoDatosAnt.Count
            Else
                Me.ripprogreso.Maximum = 3
            End If
            Application.DoEvents()
            Me.bieprogreso.Caption = "Exportando Contrato... "
            Me.bieprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            oWordN = CreateObject("Word.Application")
            Application.DoEvents()
            Me.bieprogreso.EditValue = 1
            Select Case cboUso.EditValue
                Case 0
                    SaimtMessageBox.mostrarAlertaAdvertencia("No se ha seleccionado el tipo de uso, debe de seleccionar el uso para poder definir el formato del contrato")
                    Me.bieprogreso.EditValue = 0
                    Me.bieprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Exit Sub
                Case 1
                    oDocN = oWordN.Documents.Open(EEComun.RutaReportes & "\CONTRATOSUSOCASAHABITACION.doc", Nothing, False)
                    Exit Select
                Case 2
                    oDocN = oWordN.Documents.Open(EEComun.RutaReportes & "\CONTRATOSUSOLOCALCOMERCIAL.doc", Nothing, False)
                    Exit Select
                Case 3
                    oDocN = oWordN.Documents.Open(EEComun.RutaReportes & "\CONTRATOSUSOSTANDCOMERCIAL.doc", Nothing, False)
                    Exit Select
            End Select
            Application.DoEvents()
            Me.bieprogreso.EditValue = 2
            oDocN.Sections(1).Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).LinkToPrevious = False
            oDocN.Sections(1).Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.Text = "CONTRATO N° " & GIdRegistroActual & " - SAIMT - DECOIN"
            oDocN.Sections(1).Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            Dim wRng As Word.Range
            wRng = oDocN.Content
            If cboTipoPersona.EditValue = "N" Then
                wRng.Find.Execute(FindText:="[ARRENDATARIO]", ReplaceWith:=IIf(txtNombreRazon.Text.Length = 0, "[ARRENDATARIO]", "Don/Doña " & txtNombreRazon.Text), Replace:=Word.WdReplace.wdReplaceAll)
            Else
                wRng.Find.Execute(FindText:="[ARRENDATARIO]", ReplaceWith:=IIf(txtNombreRazon.Text.Length = 0, "[ARRENDATARIO]", txtNombreRazon.Text), Replace:=Word.WdReplace.wdReplaceAll)
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DISTRITO]", ReplaceWith:=IIf(PerDistrito.Length = 0, "[DISTRITO]", StrConv(PerDistrito, VbStrConv.ProperCase)), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[PROVINCIA]", ReplaceWith:=IIf(PerProvincia.Length = 0, "[PROVINCIA]", StrConv(PerProvincia, VbStrConv.ProperCase)), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DEPARTAMENTO]", ReplaceWith:=IIf(PerDepartamento.Length = 0, "[DEPARTAMENTO]", StrConv(PerDepartamento, VbStrConv.ProperCase)), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DISTRITOINM]", ReplaceWith:=IIf(InmDistrito.Length = 0, "[DISTRITOINM]", StrConv(InmDistrito, VbStrConv.ProperCase)), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[PROVINCIAINM]", ReplaceWith:=IIf(InmProvincia.Length = 0, "[PROVINCIAINM]", StrConv(InmProvincia, VbStrConv.ProperCase)), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DEPARTAMENTOINM]", ReplaceWith:=IIf(InmDepartamento.Length = 0, "[DEPARTAMENTOINM]", StrConv(InmDepartamento, VbStrConv.ProperCase)), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[TIPODOC]", ReplaceWith:=IIf(cboTipoPersona.EditValue = "N", "con DNI Nº [DocumentoDNI],", "con RUC Nº [DocumentoRUC], debidamente representada por Don/Doña " & Me.txtNombreRazon.Tag.ToString & ","))
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DocumentoDNI]", ReplaceWith:=txtNroDocumento.Text, Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DocumentoRUC]", ReplaceWith:=txtNroDocumento.Text, Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DOMICILIO]", ReplaceWith:=IIf(txtDireccion.Text.Length = 0, "[DOMICILIO]", txtDireccion.Text), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[TIPOUSO]", ReplaceWith:=IIf(cboUso.Text.Length = 0, "[TIPOUSO]", cboUso.Text), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FECHASOLICITUD]", ReplaceWith:=IIf(dtFechaSol.Text.Length = 0, "[FECHASOLICITUD]", String.Format("{0} de {1} del {2}", Format(dtFechaSol.DateTime, "dd"), StrConv(Format(dtFechaSol.DateTime, "MMMM"), VbStrConv.ProperCase), Format(dtFechaSol.DateTime, "yyyy"))), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ANIOACTUAL]", ReplaceWith:=IIf(dtFechaFin.Text.Length = 0, "[ANIOACTUAL]", dtFechaFin.DateTime.Year), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FECHAINICIOCONT]", ReplaceWith:=IIf(dtFechaFin.Text.Length = 0, "[FECHAINICIOCONT]", String.Format("{0} de {1} del {2}", Format(dtFechaInicio.DateTime, "dd"), StrConv(Format(dtFechaInicio.DateTime, "MMMM"), VbStrConv.ProperCase), Format(dtFechaInicio.DateTime, "yyyy"))), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FECHAFINCONT]", ReplaceWith:=IIf(dtFechaFin.Text.Length = 0, "[FECHAFINCONT]", String.Format("{0} de {1} del {2}", Format(dtFechaFin.DateTime, "dd"), StrConv(Format(dtFechaFin.DateTime, "MMMM"), VbStrConv.ProperCase), Format(dtFechaFin.DateTime, "yyyy"))), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            Application.DoEvents()
            Me.bieprogreso.EditValue = 3
            wRng.Find.Execute(FindText:="[DIRECCIONINMUEBLE]", ReplaceWith:=IIf(txtDirInmueble.Text.Length = 0, "[DIRECCIONINMUEBLE]", txtDirInmueble.Text), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[MERCED]", ReplaceWith:=IIf(txtMerced.Text.Length = 0, "[MERCED]", Format(CDec(txtMerced.Text), "###,##0.00")), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[MERCEDLETRAS]", ReplaceWith:=IIf(txtMerced.Text.Length = 0, "[MERCEDLETRAS]", UCase(EEComun.MonedaLetras(CDec(txtMerced.Text)))), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[GARANTIA]", ReplaceWith:=Format(CDec(txtMerced.Text) * 3, "###,##0.00"), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[GARANTIALETRA]", ReplaceWith:=IIf(txtMerced.Text.Length = 0, "[GARANTIALETRA]", UCase(EEComun.MonedaLetras(CDec(txtMerced.Text) * 3))), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DIAMAXPAGO]", ReplaceWith:=IIf(txtDiaMaxVen.Text.Length = 0, 4, txtDiaMaxVen.Text), Replace:=Word.WdReplace.wdReplaceAll) ' Default 4
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DIAMAXPAGOLETRAS]", ReplaceWith:=EEComun.NumerosLetras(txtDiaMaxVen.Text), Replace:=Word.WdReplace.wdReplaceAll) ' Default 4
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[MESLETRAS]", ReplaceWith:=EEComun.NumMeses(dtFechaSus.DateTime.Month), Replace:=Word.WdReplace.wdReplaceAll) ' Default 4
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[AÑOLETRAS]", ReplaceWith:=EEComun.NumerosLetras(dtFechaSus.DateTime.Year), Replace:=Word.WdReplace.wdReplaceAll) ' Default 4
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FECHASUSCRIPCION]", ReplaceWith:=String.Format("{0}, {1} de {2} del {3}", StrConv(Format(dtFechaSus.DateTime, "dddd"), VbStrConv.ProperCase), Format(dtFechaSus.DateTime, "dd"), StrConv(Format(dtFechaSus.DateTime, "MMMM"), VbStrConv.ProperCase), Format(dtFechaSus.DateTime, "yyyy")), Replace:=Word.WdReplace.wdReplaceAll)
            If loContratoDatosAnt IsNot Nothing Then
                For Each i As EEContratoInm In loContratoDatosAnt
                    Application.DoEvents()
                    Me.bieprogreso.EditValue = Me.bieprogreso.EditValue + 1
                    wRng = oDocN.Content
                    wRng.Find.Execute(FindText:="[ANIOANT]", ReplaceWith:=IIf(i.AnioAnt = 0, "[ANIOANT]", i.AnioAnt), Replace:=Word.WdReplace.wdReplaceAll)
                    wRng = oDocN.Content
                    wRng.Find.Execute(FindText:="[FECHAINICIOCONTANT]", ReplaceWith:=IIf(IsDBNull(i.ConInmFecIni), "[FECHAINICIOCONTANT]", String.Format("{0} de {1} del {2}", Format(i.ConInmFecIni, "dd"), StrConv(Format(i.ConInmFecIni, "MMMM"), VbStrConv.ProperCase), Format(i.ConInmFecIni, "yyyy"))), Replace:=Word.WdReplace.wdReplaceAll)
                    wRng = oDocN.Content
                    wRng.Find.Execute(FindText:="[FECHAFINCONTANT]", ReplaceWith:=IIf(IsDBNull(i.ConInmFecFin), "[FECHAFINCONTANT]", String.Format("{0} de {1} del {2}", Format(i.ConInmFecFin, "dd"), StrConv(Format(i.ConInmFecFin, "MMMM"), VbStrConv.ProperCase), Format(i.ConInmFecFin, "yyyy"))), Replace:=Word.WdReplace.wdReplaceAll)
                    wRng = oDocN.Content
                    wRng.Find.Execute(FindText:="[FECHAANTERIORSUS]", ReplaceWith:=IIf(IsDBNull(i.ConInmFecSus), "[FECHAANTERIORSUS]", String.Format("{0} de {1} del {2}", Format(i.ConInmFecSus, "dd"), Format(i.ConInmFecSus, "MMMM"), Format(i.ConInmFecSus, "yyyy"))), Replace:=Word.WdReplace.wdReplaceAll)
                    wRng = oDocN.Content
                    wRng.Find.Execute(FindText:="[AREA]", ReplaceWith:=IIf(i.inmPredArea = 0, "[AREA]", Format(CDbl(i.inmPredArea), "###,##0.00")), Replace:=Word.WdReplace.wdReplaceAll)
                    wRng = oDocN.Content
                    wRng.Find.Execute(FindText:="[PARTIDAELECTRONICA]", ReplaceWith:=IIf(i.inmPartidaElec.Length = 0, "[PARTIDAELECTRONICA]", i.inmPartidaElec), Replace:=Word.WdReplace.wdReplaceAll)
                Next
            End If
            oDocN.Sections(1).Footers(1).PageNumbers.Add(PageNumberAlignment:=Word.WdPageNumberAlignment.wdAlignPageNumberRight, FirstPage:=True)
            If fbdcontrato.ShowDialog = Windows.Forms.DialogResult.OK Then
                oWordN.ActiveDocument.SaveAs2(fbdcontrato.SelectedPath & "\CONTRATO_Nro_" & GIdRegistroActual & "-SAIMT-DECOIN")
                oWordN.ActiveDocument.Close()
                bsiMensaje.Caption = "El archivo se guardo correctamente en la ruta seleccionada con el nombre CONTRATO_Nro_" & GIdRegistroActual & "-SAIMT-DECOIN"
            End If
            Me.bieprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        My.Computer.Clipboard.Clear()
        Print()
        My.Computer.Clipboard.Clear()
    End Sub

    Private Sub txtGarantia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGarantia.GotFocus
        If cboTipoGarantia.EditValue = 0 Then
            txtGarantia.Text = 0
            txtGarantia.Enabled = False
        ElseIf cboTipoGarantia.EditValue = 1 Then 'REINTEGRO
            If txtMerced.Text = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Merced Conductiva")
            Else
                If txtMerced.Tag = "" Then
                    txtMerced.Tag = 0
                End If

                If (txtMerced.Text - Convert.ToDouble(txtMerced.Tag)) = 0 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Verifique si necesitará incrementar la merced conductiva para este contrato")
                End If
                txtGarantia.Text = (txtMerced.Text - txtMerced.Tag) * 3
                txtGarantia.Enabled = True
            End If
        ElseIf cboTipoGarantia.EditValue = 2 Then 'NUEVO
            If txtMerced.Text = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Merced Conductiva")
            Else
                txtGarantia.Text = txtMerced.Text * 3
                txtGarantia.Enabled = True
            End If

        End If
    End Sub

    Private Sub btnExaminarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminarArchivo.Click
        If ofdExaminarArchivos.ShowDialog() = DialogResult.OK Then
            Dim lsArchSplit As String() = ofdExaminarArchivos.FileName.Split(".")
            Dim loTablaGeneralArchivo As EETablaGeneral = MantenimientosBL.Instancia.tablageneralListarXTgAbrev(lsArchSplit(lsArchSplit.Length - 1))
            Dim f2 As FileInfo = New FileInfo(ofdExaminarArchivos.FileName)
            If (f2.Length / 1024) > loTablaGeneralArchivo.TgExtra Then
                SaimtMessageBox.mostrarAlertaError("El Archivo Seleccionado Tiene " & (f2.Length / 1024) & " KB." & Environment.NewLine & "El Peso Requerido Para los Archivos " & loTablaGeneralArchivo.TgNombre & " es de " & loTablaGeneralArchivo.TgExtra & " KB.")
            Else
                txtBuscarArchivo.Text = ofdExaminarArchivos.FileName
                cboTipoArchivos.EditValue = loTablaGeneralArchivo.TgCodigo
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If txtBuscarArchivo.Text Is Nothing Then
                Throw New Exception("Seleccione Un Archivo.")
            ElseIf txtNombreArchivo.Text Is Nothing Then
                Throw New Exception("Ingrese Un Nombre al Archivo")
            ElseIf txtDescripcionArchivo.Text Is Nothing Then
                Throw New Exception("Ingrese Una Descripcion del Archivo")
            End If
            Dim lsArchSplit As String() = txtBuscarArchivo.Text.Split(".")
            Dim loImageConver As ImageConver = New ImageConver
            dtConArchivos.LoadDataRow(New Object() { _
                    "", _
                    txtNombreArchivo.Text, _
                    txtDescripcionArchivo.Text, _
                    cboTipoArchivos.EditValue, _
                    loImageConver.FileToByteArray(txtBuscarArchivo.Text), _
                    "." + lsArchSplit(lsArchSplit.Length - 1)}, True)
            If GEstadoNuevo = False Then
                Dim loConArchivos As EEConArchivos = New EEConArchivos()
                loConArchivos.ConInmArchNombre = txtNombreArchivo.Text
                loConArchivos.ConInmArchDescripcion = txtDescripcionArchivo.Text
                loConArchivos.TgTipoArchId = cboTipoArchivos.EditValue
                loConArchivos.ConInmArch = loImageConver.FileToByteArray(txtBuscarArchivo.Text)
                loConArchivos.ConInmArchExt = "." + lsArchSplit(lsArchSplit.Length - 1)
                ListaTemporalConArchivosNuevos.Add(loConArchivos)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        If Me.gvArchivos.DataRowCount <> 0 Then
            If GEstadoNuevo = False Then
                If Not String.IsNullOrEmpty(dtConArchivos.Rows(Me.gvArchivos.GetSelectedRows(0))("conInmArchId").ToString()) Then
                    ListaTemporalConArchivosEliminados.Add(dtConArchivos.Rows(Me.gvArchivos.GetSelectedRows(0))("conInmArchId").ToString())
                End If
            End If
            If ListaTemporalConArchivosNuevos.Count > 0 Then
                Dim liIndiceNuevoModificar As Int16 = 0
                Dim liFila As Int16 = -1
                For Each fTablaArchivos As DataRow In dtConArchivos.Rows
                    If String.IsNullOrEmpty(fTablaArchivos("conInmArchId")) And Me.gvArchivos.FocusedRowHandle = liFila Then
                        liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                    End If
                    liFila = liFila + 1
                Next

                ListaTemporalConArchivosNuevos.RemoveAt(liIndiceNuevoModificar)
            End If

            dtConArchivos.Rows.RemoveAt(Me.gvArchivos.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaError("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub btnVerArchivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerArchivos.Click
        Try
            Dim frmGaleriaContrato As frmGaleriaContrato = New frmGaleriaContrato()
            frmGaleriaContrato.OConInmArchivos = loConInmGaleria
            frmGaleriaContrato.Show()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnArchivosAnexados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchivosAnexados.Click
        tabDetContrato.SelectedTabPageIndex = 1
    End Sub

    Private Sub txtBuscarPersonaPor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarPersonaPor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If PuedeBuscar Then
                Try
                    GValorTextoBuscado = txtBuscarPersonaPor.EditValue
                    GCriterioBuscado = cboBuscarPersonaPor.SelectedIndex
                    dtListadoPersona.Clear()
                    Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaListarCriterioProgramacionPagos(GCriterioBuscado, GValorTextoBuscado)
                    If ListaPersona IsNot Nothing Then
                        For Each fPersona As EEPersona In ListaPersona
                            dtListadoPersona.LoadDataRow(New Object() {fPersona.PerId,
                                                                       fPersona.perNombresoRazon
                                           }, True)
                        Next
                        gvListadoPersona.BestFitColumns()
                        gvListadoPersona.SelectRow(0)
                        gvListadoPersona_FocusedRowChanged(Nothing, Nothing)
                        ' dgvListado_Click(Nothing, Nothing)
                    End If
                Catch ex As Exception
                    SaimtMessageBox.mostrarAlertaError(ex.Message)
                End Try
            Else
                mostrarMensajeBarra(GMensajePermiso)
            End If
        End If
    End Sub

    Private Sub cboTipoUso_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoUso.EditValueChanged
        If GValorTextoBuscado IsNot Nothing Then
            GCriterioBuscado = cboBuscarContratoPor.SelectedIndex
            GValorTextoBuscado = cboTipoUso.EditValue
            listar()
        End If
    End Sub

    Private Sub cboBuscarContratoPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuscarContratoPor.SelectedIndexChanged
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

    Private Sub btnincrementar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnincrementar.Click
        If txtMerced.Text Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("El Campo Merced Conductiva esta vacio.")
            Exit Sub
        Else
            txtMerced.Text = Convert.ToDecimal(txtMerced.Text) + (Convert.ToDecimal(txtMerced.Text) * txtPorcentajeInc.Value)
            txtMerced.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            txtMerced.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub btnObtenerMCAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObtenerMCAnt.Click
        If txtPerId.Text Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("Debe de Buscar una Persona.")
            Exit Sub
        End If

        If txtCodInmueble.Text Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("Debe de Seleccionar el inmueble.")
            Exit Sub
        End If
        Try
            Dim ldMercedConductiva As Decimal = MantenimientosBL.Instancia.contratoInmMostrarMercedConductivaXPerId_InmId(txtPerId.Text, txtCodInmueble.Text)
            txtMerced.Text = ldMercedConductiva
            txtMerced.Tag = ldMercedConductiva
            txtMerced.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular)
            txtMerced.BackColor = Color.White
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub gvListadoPersona_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvListadoPersona.FocusedRowChanged
        Try
            Dim lsPerId As String = String.Empty
            txtBuscarContratoPor.Text = String.Empty
            dtListadoContratos.Clear()
            If Me.gvListadoPersona.DataRowCount <> 0 Then
                lsPerId = gvListadoPersona.GetRowCellValue(Me.gvListadoPersona.GetSelectedRows(0), "CodPersona").ToString()
                txtBuscarContratoPor.Text = lsPerId
                cboBuscarContratoPor.SelectedIndex = 0
                Dim ListaContratoInm As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoInmListarCriterio(cboBuscarContratoPor.SelectedIndex, lsPerId)
                For Each fContrato As EEContratoInm In ListaContratoInm
                    dtListadoContratos.LoadDataRow(New Object() {fContrato.ConInmId,
                                                               fContrato.ConInmFecIni,
                                                               fContrato.ConInmFecFin
                                   }, True)
                Next
                gvListadoContratos.BestFitColumns()
                gvListadoContratos.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub gvListadoContratos_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvListadoContratos.FocusedRowChanged
        seleccionarListado()
    End Sub

    Private Sub cboUso_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUso.EditValueChanged
        If cboUso.EditValue IsNot Nothing Then
            cboTipoGarantia.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoGarantia.Properties.DisplayMember = "TgNombre"
            cboTipoGarantia.Properties.ValueMember = "TgCodigo"
            Select Case cboUso.EditValue
                Case 0
                    cboTipoGarantia.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(77, "0")
                Case 1, 2, 3
                    cboTipoGarantia.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(77, "0','1','2")
                Case 4, 5
                    cboTipoGarantia.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(77)
            End Select
        End If
    End Sub

  
End Class