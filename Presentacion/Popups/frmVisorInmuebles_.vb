Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraBars.Ribbon
Imports System.IO
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop

Public Class frmVisorInmuebles_
    Inherits frmMantenimientos
    Dim dtArchivos As DataTable = New DataTable()
    Dim dtDivisiones As DataTable = New DataTable()
    Dim dtSuministros As DataTable = New DataTable()
    'Lista Manejo Archivos
    Dim ListaTemporalArchivosEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalArchivosNuevos As List(Of EEInmArchivos) = New List(Of EEInmArchivos)
    Dim ListaTemporalArchivosEditados As List(Of EEInmArchivos) = New List(Of EEInmArchivos)
    'Fin Lista
    Dim ListaTemporalSuministrosEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalSuministrosNuevos As List(Of EEInmSuministros) = New List(Of EEInmSuministros)

    Dim loInmuebleGaleria As List(Of EEInmArchivos) = Nothing
    Dim lbListado As Boolean = False
    Dim dtContrato As DataTable = New DataTable()
    Dim dtProgramacionPagos As DataTable = New DataTable()
    Dim dtProcesoJudicial As DataTable = New DataTable()
    Dim dtListado As DataTable = New DataTable()

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private lbConsulta As Boolean = False
    Private lsInmIdConsulta As String
    Public Sub New(ByVal asInmId As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lsInmIdConsulta = asInmId
        lbConsulta = True
    End Sub

#Region "Construir Table"
    Private Sub ConstruirTableArchivos()
        dtArchivos.Columns.Add("inmArchId", GetType(String))
        dtArchivos.Columns.Add("inmArchNombre", GetType(String))
        dtArchivos.Columns.Add("inmArchDescripcion", GetType(String))
        dtArchivos.Columns.Add("tgTipoArchId", GetType(String))
        dtArchivos.Columns.Add("inmArch", GetType(Byte()))
        dtArchivos.Columns.Add("inmArchExt", GetType(String))
        dtArchivos.Columns.Add("inmArchPrincipal", GetType(Boolean))

        dtArchivos.Columns("inmArchId").ColumnMapping = MappingType.Hidden
        dtArchivos.Columns("tgTipoArchId").ColumnMapping = MappingType.Hidden
        dtArchivos.Columns("inmArch").ColumnMapping = MappingType.Hidden

        dtArchivos.Columns("inmArchNombre").Caption = "Nombre"
        dtArchivos.Columns("inmArchDescripcion").Caption = "Descripcion"
        dtArchivos.Columns("inmArchExt").Caption = "Extension"
        dtArchivos.Columns("inmArchPrincipal").Caption = "Principal"
    End Sub

    Private Sub ConstruirTableSuministros()
        dtSuministros.Columns.Add("inmSumId", GetType(String))
        dtSuministros.Columns.Add("perId", GetType(String))
        dtSuministros.Columns.Add("Proveedor", GetType(String))
        dtSuministros.Columns.Add("tgTipoServicioId", GetType(String))
        dtSuministros.Columns.Add("TipoServicio", GetType(String))
        dtSuministros.Columns.Add("NroMedidor", GetType(String))
        dtSuministros.Columns.Add("Monto", GetType(Decimal))
        dtSuministros.Columns.Add("tgTipoMesId", GetType(String))
        dtSuministros.Columns.Add("Mes", GetType(String))
        dtSuministros.Columns.Add("Año", GetType(Int16))
        dtSuministros.Columns.Add("FechaVencimiento", GetType(DateTime))

        dtSuministros.Columns("inmSumId").ColumnMapping = MappingType.Hidden
        dtSuministros.Columns("perId").ColumnMapping = MappingType.Hidden
        dtSuministros.Columns("tgTipoServicioId").ColumnMapping = MappingType.Hidden
        dtSuministros.Columns("tgTipoMesId").ColumnMapping = MappingType.Hidden
    End Sub

    Private Sub ConstruirTableDivisiones()
        dtDivisiones.Columns.Add("Foto", GetType(Byte()))
        dtDivisiones.Columns.Add("Numero", GetType(String))
        dtDivisiones.Columns.Add("File", GetType(String))
        dtDivisiones.Columns.Add("UbgNombre", GetType(String))
        dtDivisiones.Columns.Add("InmDirLocalizacion", GetType(String))
        dtDivisiones.Columns.Add("NombreRubro", GetType(String))
    End Sub

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
        dtContrato.Columns.Add("inquilino", GetType(String))
    End Sub

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
    End Sub

    Private Sub ConstruirTableProcesoJudicial()
        dtProcesoJudicial.Columns.Add("InmPJudId", GetType(String))
        dtProcesoJudicial.Columns.Add("InmPJudFechaInicio", GetType(DateTime))
        dtProcesoJudicial.Columns.Add("InmPJudNroExp", GetType(String))
        dtProcesoJudicial.Columns.Add("InmPJudJuzgado", GetType(String))
        dtProcesoJudicial.Columns.Add("InmPJudMotivo", GetType(String))
        dtProcesoJudicial.Columns.Add("InmPJudEtapaProc", GetType(String))
        dtProcesoJudicial.Columns.Add("InmPJudDemandante", GetType(String))
        dtProcesoJudicial.Columns.Add("InmPJudDemandado", GetType(String))
        dtProcesoJudicial.Columns.Add("TgEstadoProcId", GetType(String))
        dtProcesoJudicial.Columns.Add("TgEstadoProceso", GetType(String))
        dtProcesoJudicial.Columns.Add("InmPJudLitisConsorte", GetType(String))
        dtProcesoJudicial.Columns.Add("InmPJudSecretario", GetType(String))
        dtProcesoJudicial.Columns.Add("InmPJudObservacion", GetType(String))
    End Sub
#End Region

#Region "Construir Table Listado"
    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("inmFile", GetType(String))
        dtListado.Columns.Add("inmFileAnt", GetType(String))
        dtListado.Columns.Add("inmDenominacion", GetType(String))
        dtListado.Columns.Add("inmUbicacion", GetType(String))
        dtListado.Columns.Add("inmId", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Private lsInmDirId As String = String.Empty
    Private lsInmPredId As String = String.Empty

    Sub mostrarInmuebleXInmId()
        Try
            If lsInmIdConsulta <> 0 Then
                Dim loInmueble As EEInmueble = MantenimientosBL.Instancia.inmuebleMostrarXInmId(lsInmIdConsulta)
                If loInmueble IsNot Nothing Then
                    Me.beiprogreso.Caption = "Cargando Información del Perfil del Inmueble... "
                    Me.riprogreso.Minimum = 0
                    Me.riprogreso.Maximum = 5
                    Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    lbListado = True
                    '  GIndiceSeleccionado = Me.gvListadoInmuebles.GetSelectedRows(0)
                    Application.DoEvents()
                    Me.beiprogreso.EditValue = 1
                    loInmuebleGaleria = loInmueble.ListaInmArchivos
                    lblNroInmueble.Text = loInmueble.InmId
                    txtNroFile.Text = loInmueble.InmFile
                    txtNroFileAntiguo.Text = loInmueble.InmFileAnt
                    txtInmueblePrincipal.Text = loInmueble.InmFilePadre
                    txtInmueblePrincipal.Tag = loInmueble.InmIdPadre
                    txtFincaInscrita.Text = loInmueble.InmInscrito
                    txtDenominacion.Text = loInmueble.InmDenominacion
                    txtDocAcredita.Text = loInmueble.InmDocAcredita
                    txtPartElectronica.Text = loInmueble.InmPartidaElec
                    txtAsiento.Text = loInmueble.InmAsiento
                    txtSaneadoObserv.Text = loInmueble.InmSaneadoObs
                    cboSFinformacion.EditValue = loInmueble.tgInmSFZonificacionId
                    cboSfUso.EditValue = loInmueble.tgInmSFUsoId
                    If loInmueble.InmDisponibilidad.HasValue Then
                        chkDisponibilidad.Checked = loInmueble.InmDisponibilidad
                    Else
                        chkDisponibilidad.Checked = False
                    End If
                    Application.DoEvents()
                    Me.beiprogreso.EditValue = 2
                    If loInmueble.InmFecMarg.HasValue Then
                        dtpFechaRegistroMargesi.EditValue = loInmueble.InmFecMarg
                    End If

                    txtObservacion.Text = loInmueble.InmObservacion
                    txtNroPisos.Text = loInmueble.InmNroPisos

                    cboUEstadoConservacion.cboUpdate.EditValue = loInmueble.tgEstInmConsvId
                    cboCondicionRegistral.EditValue = loInmueble.tgInmCondRegId
                    cboUEstadoSaneamiento.cboUpdate.EditValue = loInmueble.TgEstSanId
                    cboCondicionRegistralSub.EditValue = loInmueble.tgInmCondRegSubId
                    cboSituacionFisica.EditValue = loInmueble.tgInmSitFisicaId
                    cboTipoUnidad.EditValue = loInmueble.TgTipoUnidadId
                    cboEstadoInmueble.EditValue = loInmueble.TgInmEstado
                    cboRubroGrupos.EditValue = loInmueble.TgRubroGrupoId
                    cboRubro.EditValue = loInmueble.TgRubroId


                    If loInmueble.InmActivo.HasValue Then
                        chkInmuebleActivo.Checked = loInmueble.InmActivo
                    Else
                        chkInmuebleActivo.Checked = False
                    End If

                    Application.DoEvents()
                    Me.beiprogreso.EditValue = 3
                    'DIRECCIÓN
                    If loInmueble.OInmDireccion IsNot Nothing Then
                        lsInmDirId = loInmueble.OInmDireccion.InmDirId
                        txtLocalizacion.Text = loInmueble.OInmDireccion.InmDirLocalizacion
                        cboLocalizacion.EditValue = loInmueble.OInmDireccion.TgLocalizacionId
                        cboTipoNro.EditValue = loInmueble.OInmDireccion.TgNroId
                        txtNroUbicacion.Text = loInmueble.OInmDireccion.InmDirNro
                        cboTipoSubNro.EditValue = loInmueble.OInmDireccion.TgSubNroId
                        txtbarrio.EditValue = loInmueble.OInmDireccion.InmDirBarrio
                        txtsector.EditValue = loInmueble.OInmDireccion.InmDirSector
                        txtadicional.EditValue = loInmueble.OInmDireccion.InmDirAdicional
                        cboSubDistritos.EditValue = loInmueble.OInmDireccion.TgSubDistritosId
                        txtsubdistritoText.EditValue = loInmueble.OInmDireccion.InmDirSubDistritos
                        txtsubdistritoscbo.EditValue = loInmueble.OInmDireccion.InmDirSubDistritos
                        txtSubNro.Text = loInmueble.OInmDireccion.InmDirSubNro
                        txtFase.Text = loInmueble.OInmDireccion.InmDirFase
                        txtEtapa.Text = loInmueble.OInmDireccion.InmDirEtapa
                        txtReferencia.Text = loInmueble.OInmDireccion.InmDirReferencia
                        cboDepartamento.EditValue = loInmueble.OInmDireccion.OUbigeo.UbgDep
                        cboProvincia.EditValue = loInmueble.OInmDireccion.OUbigeo.UbgProv
                        cboDistrito.EditValue = loInmueble.OInmDireccion.OUbigeo.UbgDist
                        txtdireccion.EditValue = loInmueble.OInmDireccion.InmDireccionCompleta
                        txtadicional.EditValue = loInmueble.OInmDireccion.InmDirAdicional
                        ' BarStaticItem1.Caption = txtdireccion.EditValue
                        chkDireccion.EditValue = loInmueble.OInmDireccion.InmDirCheck
                    Else
                        chkDireccion.EditValue = False
                        lsInmDirId = Nothing
                        txtLocalizacion.Text = Nothing
                        cboLocalizacion.EditValue = Nothing
                        cboTipoNro.EditValue = Nothing
                        txtNroUbicacion.Text = Nothing
                        cboTipoSubNro.EditValue = Nothing
                        txtbarrio.EditValue = Nothing
                        txtsector.EditValue = Nothing
                        txtadicional.EditValue = Nothing
                        cboSubDistritos.EditValue = Nothing
                        txtsubdistritoText.EditValue = Nothing
                        txtsubdistritoscbo.EditValue = Nothing
                        txtSubNro.Text = Nothing
                        txtFase.Text = Nothing
                        txtEtapa.Text = Nothing
                        txtReferencia.Text = Nothing
                        cboDepartamento.EditValue = Nothing
                        cboProvincia.EditValue = Nothing
                        cboDistrito.EditValue = Nothing
                        txtdireccion.EditValue = Nothing
                        txtadicional.EditValue = Nothing
                        '  BarStaticItem1.Caption = Nothing
                    End If

                    If loInmueble.OInmDireccionIns IsNot Nothing Then
                        'DIRECCIÓN
                        txtLocalizacionIns.Text = loInmueble.OInmDireccionIns.InmDirLocalizacion
                        cboLocalizacionIns.EditValue = loInmueble.OInmDireccionIns.TgLocalizacionId
                        cboTipoNroIns.EditValue = loInmueble.OInmDireccionIns.TgNroId
                        txtNroUbicacionIns.Text = loInmueble.OInmDireccionIns.InmDirNro
                        cboTipoSubNroIns.EditValue = loInmueble.OInmDireccionIns.TgSubNroId
                        txtsubdistritoInsText.EditValue = loInmueble.OInmDireccion.InmDirSubDistritos
                        txtsubdistritosInscbo.EditValue = loInmueble.OInmDireccion.InmDirSubDistritos
                        txtSubNroIns.Text = loInmueble.OInmDireccionIns.InmDirSubNro
                        txtFaseIns.Text = loInmueble.OInmDireccionIns.InmDirFase
                        txtEtapaIns.Text = loInmueble.OInmDireccionIns.InmDirEtapa
                        cboDepartamentoIns.EditValue = loInmueble.OInmDireccionIns.OUbigeo.UbgDep
                        cboProvinciaIns.EditValue = loInmueble.OInmDireccionIns.OUbigeo.UbgProv
                        cboDistritoIns.EditValue = loInmueble.OInmDireccionIns.OUbigeo.UbgDist
                        txtbarrioIns.EditValue = loInmueble.OInmDireccionIns.InmDirBarrio
                        txtsectorIns.EditValue = loInmueble.OInmDireccionIns.InmDirSector
                        chkDireccionIns.EditValue = loInmueble.OInmDireccionIns.InmDirCheck
                        ' txtReferencia.EditValue = loInmueble.OInmDireccionIns.InmDirReferencia
                    Else
                        chkDireccionIns.EditValue = False
                        txtLocalizacionIns.Text = Nothing
                        cboLocalizacionIns.EditValue = Nothing
                        cboTipoNroIns.EditValue = Nothing
                        txtNroUbicacionIns.Text = Nothing
                        cboTipoSubNroIns.EditValue = Nothing
                        txtsubdistritoInsText.EditValue = Nothing
                        txtsubdistritosInscbo.EditValue = Nothing
                        txtSubNroIns.Text = Nothing
                        txtFaseIns.Text = Nothing
                        txtEtapaIns.Text = Nothing
                        cboDepartamentoIns.EditValue = Nothing
                        cboProvinciaIns.EditValue = Nothing
                        cboDistritoIns.EditValue = Nothing
                        txtbarrioIns.EditValue = Nothing
                        txtsectorIns.EditValue = Nothing
                        txtReferencia.EditValue = Nothing
                    End If

                    Application.DoEvents()
                    Me.beiprogreso.EditValue = 4
                    'PREDIO
                    If loInmueble.OInmPredio IsNot Nothing Then
                        lsInmPredId = loInmueble.OInmPredio.InmPredId
                        txtArea.Text = loInmueble.OInmPredio.InmPredArea
                        If loInmueble.OInmPredio.InmPredArancel.HasValue Then
                            txtArancel.Text = loInmueble.OInmPredio.InmPredArancel
                        End If
                        If loInmueble.OInmPredio.InmPredValorTerreno.HasValue Then
                            txtValorTerreno.Text = loInmueble.OInmPredio.InmPredValorTerreno
                        End If
                        If loInmueble.OInmPredio.InmPredAreaTechada.HasValue Then
                            txtAreaTechada.Text = loInmueble.OInmPredio.InmPredAreaTechada
                        End If
                        If loInmueble.OInmPredio.InmPredValorConst.HasValue Then
                            txtValorConstruccion.Text = loInmueble.OInmPredio.InmPredValorConst
                        End If
                        If loInmueble.OInmPredio.InmPredValorEdificacion.HasValue Then
                            txtValorEdificacion.Text = loInmueble.OInmPredio.InmPredValorEdificacion
                        End If
                        If loInmueble.OInmPredio.InmPredValorTotal.HasValue Then
                            txtValorTotal.Text = loInmueble.OInmPredio.InmPredValorTotal
                        End If

                        chkPredioActivo.Checked = loInmueble.OInmPredio.InmPredActivo

                        If loInmueble.OInmPredio.InmPredFecTas.HasValue Then
                            dtpFechaTasacion.EditValue = loInmueble.OInmPredio.InmPredFecTas
                        End If
                    Else
                        txtArea.Text = String.Empty
                        txtArancel.Text = String.Empty
                        txtValorTerreno.Text = "0.00"
                        txtAreaTechada.Text = String.Empty
                        txtValorConstruccion.Text = String.Empty
                        txtValorEdificacion.Text = "0.00"
                        txtValorTotal.Text = "0.00"
                        chkPredioActivo.Checked = True
                        dtpFechaTasacion.EditValue = DateTime.Now
                    End If
                    Application.DoEvents()
                    Me.beiprogreso.EditValue = 5
                    'Archivos

                    dtArchivos.Clear()
                    pbImagenPrincipal.Image = Nothing
                    If Not loInmueble.ListaInmArchivos Is Nothing Then
                        If loInmueble.ListaInmArchivos.Count > 0 Then
                            Me.riprogreso.Minimum = 0
                            Me.riprogreso.Maximum = loInmueble.ListaInmArchivos.Count
                            Me.beiprogreso.EditValue = 0
                        End If
                    End If
                    Dim loImageConver As ImageConver = New ImageConver
                    For Each fArchivos As EEInmArchivos In loInmueble.ListaInmArchivos

                        dtArchivos.LoadDataRow(New Object() { _
                                fArchivos.InmArchId, _
                                fArchivos.InmArchNombre, _
                                fArchivos.InmArchDescripcion, _
                                fArchivos.TgTipoArchId, _
                                fArchivos.InmArch, _
                                fArchivos.InmArchExt, _
                                fArchivos.InmArchPrincipal
                        }, True)
                        Application.DoEvents()
                        Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                        Me.beiprogreso.Caption = String.Format("Cargando archivos adjuntos al inmueble...({0}) ", Format(Me.beiprogreso.EditValue / Me.riprogreso.Maximum, "0%"))
                        If fArchivos.InmArchPrincipal = True And fArchivos.TgTipoArchId = "04" Then
                            pbImagenPrincipal.Image = loImageConver.Bytes2Image(fArchivos.InmArch)
                        End If
                    Next

                    'Suministros
                    dtSuministros.Clear()
                    If Not loInmueble.ListaInmSuministros Is Nothing Then
                        If loInmueble.ListaInmSuministros.Count > 0 Then
                            Me.riprogreso.Minimum = 0
                            Me.riprogreso.Maximum = loInmueble.ListaInmSuministros.Count
                            Me.beiprogreso.EditValue = 0
                        End If
                    End If
                    For Each fSuministros As EEInmSuministros In loInmueble.ListaInmSuministros
                        dtSuministros.LoadDataRow(New Object() { _
                                fSuministros.InmSumId, _
                                fSuministros.OPersona.PerId, _
                                fSuministros.OPersona.PerRazonSocial, _
                                fSuministros.TgTipoServicio.TgCodigo, _
                                fSuministros.TgTipoServicio.TgNombre, _
                                fSuministros.InmSumMedidor, _
                                fSuministros.InmSumMonto, _
                                fSuministros.TgTipoMes.TgCodigo, _
                                fSuministros.TgTipoMes.TgNombre, _
                                fSuministros.InmSumAño, _
                                fSuministros.InmSumFechaVen
                        }, True)
                        Application.DoEvents()
                        Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                        Me.beiprogreso.Caption = String.Format("Cargando pagos de suministros del inmueble...({0}) ", Format(Me.beiprogreso.EditValue / Me.riprogreso.Maximum, "0%"))
                    Next

                    'Procesos Judiciales
                    dtProcesoJudicial.Clear()
                    If Not loInmueble.ListaInmPJudiciales Is Nothing Then
                        If loInmueble.ListaInmPJudiciales.Count > 0 Then
                            Me.riprogreso.Minimum = 0
                            Me.riprogreso.Maximum = loInmueble.ListaInmPJudiciales.Count
                            Me.beiprogreso.EditValue = 0
                        End If
                    End If

                    For Each fProcesoJudicial As EEInmPJudiciales In loInmueble.ListaInmPJudiciales
                        dtProcesoJudicial.LoadDataRow(New Object() { _
                            fProcesoJudicial.InmPJudId, _
                            fProcesoJudicial.InmPJudFechaInicio, _
                            fProcesoJudicial.InmPJudNroExp, _
                            fProcesoJudicial.InmPJudJuzgado, _
                            fProcesoJudicial.InmPJudMotivo, _
                            fProcesoJudicial.InmPJudEtapaProc, _
                            fProcesoJudicial.InmPJudDemandante, _
                            fProcesoJudicial.InmPJudDemandado, _
                            fProcesoJudicial.OTgEstadoProceso.TgCodigo, _
                            fProcesoJudicial.OTgEstadoProceso.TgNombre, _
                            fProcesoJudicial.InmPJudLitisConsorte, _
                            fProcesoJudicial.InmPJudSecretario, _
                            fProcesoJudicial.InmPJudObservacion
                       }, True)

                        Application.DoEvents()
                        Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                        Me.beiprogreso.Caption = String.Format("Cargando Procesos Judiciales del Inmueble...({0}) ", Format(Me.beiprogreso.EditValue / Me.riprogreso.Maximum, "0%"))
                    Next
                    gvProcesosJudiciales.BestFitColumns()

                    'Divisiones
                    dtDivisiones.Rows.Clear()
                    If Not loInmueble.ListaDivisiones Is Nothing Then
                        If loInmueble.ListaDivisiones.Count > 0 Then
                            Me.riprogreso.Minimum = 0
                            Me.riprogreso.Maximum = loInmueble.ListaDivisiones.Count
                            Me.beiprogreso.EditValue = 0
                        End If
                    End If
                    If loInmueble.ListaDivisiones IsNot Nothing Then
                        Dim liFila As Int32 = 0
                        For Each fInmuebleDivision As EEInmueble In loInmueble.ListaDivisiones
                            dtDivisiones.LoadDataRow(New Object() { _
                                fInmuebleDivision.InmArchDivision, _
                                fInmuebleDivision.InmId, _
                                fInmuebleDivision.InmFile, _
                                fInmuebleDivision.OInmDireccion.OUbigeo.UbgNombre, _
                                fInmuebleDivision.OInmDireccion.InmDirLocalizacion, _
                                fInmuebleDivision.TgRubro
                        }, True)
                            Application.DoEvents()
                            Me.beiprogreso.EditValue = Me.beiprogreso.EditValue + 1
                            Me.beiprogreso.Caption = String.Format("Cargando divisiones del inmueble...({0}) ", Format(Me.beiprogreso.EditValue / Me.riprogreso.Maximum, "0%"))
                        Next
                    End If

                    GIdRegistroActual = loInmueble.InmId
                    MyBase.seleccionarListado()
                    hleVerGaleriaArchivosInmuebles.Enabled = True
                    Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub imprimir()
        Me.btnImprimir.Enabled = False
        EEComun.ExportarPrintForm(Me, Me.Text)
        Me.btnImprimir.Enabled = True

        MyBase.imprimir()
    End Sub

    Private Sub mControlesDeshabilitados()
        txtInmueblePrincipal.Properties.ReadOnly = True
        txtBuscarArchivo.Properties.ReadOnly = True
        txtValorTotal.Properties.ReadOnly = True
        cboTipoArchivos.Properties.ReadOnly = True
        mDeshabilitarSegunTipoUnidad()
    End Sub
#End Region

#Region "Load"
    Private Sub frmInmuebles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableArchivos()
        ConstruirTableSuministros()
        ConstruirTableDivisiones()
        ConstruirTableDetalleContrato()
        ConstruirTableProgramacionPagos()
        ConstruirTableProcesoJudicial()
        dgvArchivos.DataSource = dtArchivos
        dgvDivisiones.DataSource = dtDivisiones
        dgvSuministros.DataSource = dtSuministros
        dgvContratos.DataSource = dtContrato
        dgvProgramacionPagos.DataSource = dtProgramacionPagos
        dgvProcesosJudiciales.DataSource = dtProcesoJudicial

        cboLocalizacion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboLocalizacion.Properties.DisplayMember = "TgNombre"
        cboLocalizacion.Properties.ValueMember = "TgCodigo"
        cboLocalizacion.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(1) ' Localizacion
        cboLocalizacion.ItemIndex = 0

        cboTipoNro.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoNro.Properties.DisplayMember = "TgNombre"
        cboTipoNro.Properties.ValueMember = "TgCodigo"
        cboTipoNro.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(169) ' Tipo Nro
        cboTipoNro.ItemIndex = 0

        cboTipoSubNro.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoSubNro.Properties.DisplayMember = "TgNombre"
        cboTipoSubNro.Properties.ValueMember = "TgCodigo"
        cboTipoSubNro.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(170) ' Tipo Sub Nro
        cboTipoSubNro.ItemIndex = 0

        cboSubDistritos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSubDistritos.Properties.DisplayMember = "TgNombre"
        cboSubDistritos.Properties.ValueMember = "TgCodigo"
        cboSubDistritos.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(172) ' Tipo Urbanizaciones
        cboSubDistritos.ItemIndex = 0

        cboLocalizacionIns.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboLocalizacionIns.Properties.DisplayMember = "TgNombre"
        cboLocalizacionIns.Properties.ValueMember = "TgCodigo"
        cboLocalizacionIns.Properties.DataSource = cboLocalizacion.Properties.DataSource ' Localizacion
        cboLocalizacionIns.ItemIndex = 0

        cboTipoNroIns.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoNroIns.Properties.DisplayMember = "TgNombre"
        cboTipoNroIns.Properties.ValueMember = "TgCodigo"
        cboTipoNroIns.Properties.DataSource = cboTipoNro.Properties.DataSource  ' Tipo Nro
        cboTipoNroIns.ItemIndex = 0

        cboTipoSubNroIns.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoSubNroIns.Properties.DisplayMember = "TgNombre"
        cboTipoSubNroIns.Properties.ValueMember = "TgCodigo"
        cboTipoSubNroIns.Properties.DataSource = cboTipoSubNro.Properties.DataSource ' Tipo Sub Nro
        cboTipoSubNroIns.ItemIndex = 0

        cboSubDistritosIns.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSubDistritosIns.Properties.DisplayMember = "TgNombre"
        cboSubDistritosIns.Properties.ValueMember = "TgCodigo"
        cboSubDistritosIns.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(172) ' Tipo Urbanizaciones
        cboSubDistritosIns.ItemIndex = 0


        cboEstadoInmueble.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoInmueble.Properties.DisplayMember = "TgNombre"
        cboEstadoInmueble.Properties.ValueMember = "TgCodigo"
        cboEstadoInmueble.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(14)
        cboEstadoInmueble.ItemIndex = 0

        cboRubroGrupos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRubroGrupos.Properties.DisplayMember = "TgNombre"
        cboRubroGrupos.Properties.ValueMember = "TgCodigo"
        cboRubroGrupos.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(32)
        cboRubroGrupos.ItemIndex = 0

        cboTipoUnidad.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoUnidad.Properties.DisplayMember = "TgNombre"
        cboTipoUnidad.Properties.ValueMember = "TgCodigo"
        cboTipoUnidad.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(35)
        cboTipoUnidad.ItemIndex = 0

        cboDepartamento.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboDepartamento.Properties.DisplayMember = "UbgNombre"
        cboDepartamento.Properties.ValueMember = "UbgDep"
        cboDepartamento.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarDepartamentoALL()
        cboDepartamento.ItemIndex = 0

        cboDepartamentoIns.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboDepartamentoIns.Properties.DisplayMember = "UbgNombre"
        cboDepartamentoIns.Properties.ValueMember = "UbgDep"
        cboDepartamentoIns.Properties.DataSource = cboDepartamento.Properties.DataSource
        cboDepartamentoIns.ItemIndex = 0


        cboTipoArchivos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoArchivos.Properties.DisplayMember = "TgNombre"
        cboTipoArchivos.Properties.ValueMember = "TgCodigo"
        cboTipoArchivos.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(30)
        cboTipoArchivos.ItemIndex = 0

        'Suministros
        cboSumTipoServicio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSumTipoServicio.Properties.DisplayMember = "TgNombre"
        cboSumTipoServicio.Properties.ValueMember = "TgCodigo"
        cboSumTipoServicio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(39)
        cboSumTipoServicio.ItemIndex = 0

        cboSumMes.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSumMes.Properties.DisplayMember = "TgNombre"
        cboSumMes.Properties.ValueMember = "TgCodigo"
        cboSumMes.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(40)
        cboSumMes.ItemIndex = 0

        cboEstadoPJ.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoPJ.Properties.DisplayMember = "TgNombre"
        cboEstadoPJ.Properties.ValueMember = "TgCodigo"
        cboEstadoPJ.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(155)
        cboEstadoPJ.ItemIndex = 0

        cboCondicionRegistral.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCondicionRegistral.Properties.DisplayMember = "TgNombre"
        cboCondicionRegistral.Properties.ValueMember = "TgCodigo"
        cboCondicionRegistral.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgCondicionRegistral)
        cboCondicionRegistral.ItemIndex = 0

        cboCondicionLegal.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCondicionLegal.Properties.DisplayMember = "TgNombre"
        cboCondicionLegal.Properties.ValueMember = "TgCodigo"
        cboCondicionLegal.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgCondicionLegal)
        cboCondicionLegal.ItemIndex = 0

        cboSituacionFisica.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSituacionFisica.Properties.DisplayMember = "TgNombre"
        cboSituacionFisica.Properties.ValueMember = "TgCodigo"
        cboSituacionFisica.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgSituacionFisica)
        cboSituacionFisica.ItemIndex = 0

        cboSFinformacion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSFinformacion.Properties.DisplayMember = "TgNombre"
        cboSFinformacion.Properties.ValueMember = "TgCodigo"
        cboSFinformacion.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(clsVariablesTablaGeneral.tblgSFInformacion)
        cboSFinformacion.ItemIndex = 0

        'AddHandler cboUSituacionLegal.cboUpdate.EditValueChanged, AddressOf cboUSituacionLegal_EditValueChanged
        AddHandler cboUEstadoSaneamiento.cboUpdate.EditValueChanged, AddressOf cboUEstadoSaneamiento_EditValueChanged

        Dim ListaTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId2(30)
        Dim lsExtenciones As String = ""
        For Each fTablaGeneral As EETablaGeneral In ListaTablaGeneral
            lsExtenciones += fTablaGeneral.TgAbrev + ";"
        Next

        ofdExaminarArchivos.Filter = String.Format("Archivos({0})|{0}", lsExtenciones)
        ofdExaminarArchivos.Title = "Seleccionar Archivos"

        hleVerGaleriaArchivosInmuebles.Enabled = False
        'cboBuscarPor.Properties.ReadOnly = True
        btnActualizarPJ.Enabled = False
        mostrarInmuebleXInmId()

    End Sub
#End Region

    Private Sub txtArea_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArea.Leave
        mCalcularValorTerreno()
    End Sub

    Private Sub txtArancel_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArancel.Leave
        mCalcularValorTerreno()
    End Sub

    Private Sub txtAreaTechada_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAreaTechada.Leave
        mCalcularValorEdificacion()
    End Sub

    Private Sub txtValorConstruccion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorConstruccion.Leave
        mCalcularValorEdificacion()
    End Sub

    Private Sub txtValorTerreno_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorTerreno.EditValueChanged
        mCalcularValorTotal()
    End Sub

    Private Sub txtValorEdificacion_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorEdificacion.EditValueChanged
        mCalcularValorTotal()
    End Sub

#Region "Metodos Calculo"
    Public Sub mCalcularValorTerreno()
        Dim lbArea As Boolean
        Dim lbArancel As Boolean
        Decimal.TryParse(txtArea.Text, lbArea)
        Decimal.TryParse(txtArancel.Text, lbArancel)

        If lbArea And lbArancel Then
            Dim ldValorTerreno As Decimal = Convert.ToDecimal(txtArea.Text) * Convert.ToDecimal(txtArancel.Text)
            txtValorTerreno.Text = FormatNumber(ldValorTerreno, 2)
        End If
    End Sub

    Public Sub mCalcularValorEdificacion()
        Dim lbAreaTechada As Boolean
        Dim lbValorConstruccion As Boolean
        Decimal.TryParse(txtAreaTechada.Text, lbAreaTechada)
        Decimal.TryParse(txtValorConstruccion.Text, lbValorConstruccion)
        If lbAreaTechada And lbValorConstruccion Then
            Dim ldValorEdificacion As Decimal = Convert.ToDecimal(txtAreaTechada.Text) * Convert.ToDecimal(txtValorConstruccion.Text)
            txtValorEdificacion.Text = FormatNumber(ldValorEdificacion, 2)
        End If
    End Sub

    Public Sub mCalcularValorTotal()
        Try
            Dim ldValorTotal As Decimal = Convert.ToDecimal(txtValorTerreno.Text) + Convert.ToDecimal(txtValorEdificacion.Text)
            txtValorTotal.Text = FormatNumber(ldValorTotal, 2)
        Catch ex As Exception

        End Try
    End Sub
#End Region
    Private Sub cboDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.EditValueChanged
        Dim lsUbgDep As String = cboDepartamento.EditValue
        cboProvincia.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboProvincia.Properties.DisplayMember = "UbgNombre"
        cboProvincia.Properties.ValueMember = "UbgProv"
        cboProvincia.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarProvinciaXUbgDep(lsUbgDep)
        cboProvincia.ItemIndex = 0
        'LlenarDireccion()
    End Sub

    Private Sub cboDepartamentoRef_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamentoIns.EditValueChanged
        Dim lsUbgDep As String = cboDepartamentoIns.EditValue
        cboProvinciaIns.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboProvinciaIns.Properties.DisplayMember = "UbgNombre"
        cboProvinciaIns.Properties.ValueMember = "UbgProv"
        cboProvinciaIns.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarProvinciaXUbgDep(lsUbgDep)
        cboProvinciaIns.ItemIndex = 0
    End Sub

    Private Sub cboProvincia_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.EditValueChanged
        Dim lsUbgDep As String = cboDepartamento.EditValue
        Dim lsUbgProv As String = cboProvincia.EditValue
        cboDistrito.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboDistrito.Properties.DisplayMember = "UbgNombre"
        cboDistrito.Properties.ValueMember = "UbgDist"
        cboDistrito.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarDistritoXUbgDepXUbgProv(lsUbgDep, lsUbgProv)
        cboDistrito.ItemIndex = 0
        'LlenarDireccion()
    End Sub

    Private Sub cboProvinciaRef_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvinciaIns.EditValueChanged
        Dim lsUbgDep As String = cboDepartamentoIns.EditValue
        Dim lsUbgProv As String = cboProvinciaIns.EditValue
        cboDistritoIns.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboDistritoIns.Properties.DisplayMember = "UbgNombre"
        cboDistritoIns.Properties.ValueMember = "UbgDist"
        cboDistritoIns.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarDistritoXUbgDepXUbgProv(lsUbgDep, lsUbgProv)
        cboDistritoIns.ItemIndex = 0
    End Sub

    Private Sub cboRubroGrupos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRubroGrupos.EditValueChanged
        Dim lsTgcodigo As String = cboRubroGrupos.EditValue
        cboRubro.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRubro.Properties.DisplayMember = "TgNombre"
        cboRubro.Properties.ValueMember = "TgCodigo"
        cboRubro.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(33, lsTgcodigo)
        cboRubro.ItemIndex = 0
    End Sub


    Private Sub btnConsultaInmueblePadre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaInmueblePadre.Click
        Dim fmConsultaInmuebleDivision As frmConsultaInmueblePrincipal = New frmConsultaInmueblePrincipal

        If fmConsultaInmuebleDivision.ShowDialog() = DialogResult.OK Then
            txtInmueblePrincipal.Tag = fmConsultaInmuebleDivision.InmId
            txtInmueblePrincipal.Text = fmConsultaInmuebleDivision.InmFile
        End If
    End Sub

    Private Sub hleVerGaleriaArchivosInmuebles_OpenLink(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles hleVerGaleriaArchivosInmuebles.OpenLink
        Try
            Dim fmGaleriaInmueble As frmGaleriaInmueble = New frmGaleriaInmueble()
            fmGaleriaInmueble.OInmuebleArchivos = loInmuebleGaleria
            fmGaleriaInmueble.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregarSuministro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarSuministro.Click
        dtSuministros.LoadDataRow(New Object() { _
               0, _
               txtSumProveedor.Tag, _
               txtSumProveedor.Text, _
               cboSumTipoServicio.EditValue, _
               cboSumTipoServicio.Text, _
               txtSumNroMedidor.Text, _
               txtSumMonto.Text, _
               cboSumMes.EditValue, _
               cboSumMes.Text, _
               txtSumAño.Text, _
               dtpFechaVencimiento.EditValue
        }, True)
    End Sub

    Private Sub btnQuitarSuministro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarSuministro.Click
        If Me.gvSuministros.DataRowCount <> 0 Then
            If GEstadoNuevo = False Then
                If Not String.IsNullOrEmpty(dtSuministros.Rows(Me.gvSuministros.GetSelectedRows(0))("inmSumId").ToString()) Then
                    ListaTemporalSuministrosEliminados.Add(dtSuministros.Rows(Me.gvSuministros.GetSelectedRows(0))("inmSumId").ToString())
                End If
            End If

            If ListaTemporalSuministrosNuevos.Count > 0 Then
                Dim liIndiceNuevo As Int32 = 0
                Dim liIndiceNuevoRemove As Int32
                For Each fTablaSuministros As DataRow In dtSuministros.Rows
                    If fTablaSuministros("inmSumId") <> Nothing Then
                        liIndiceNuevo = liIndiceNuevo + 1
                    End If
                Next

                liIndiceNuevoRemove = liIndiceNuevo - Me.gvSuministros.GetSelectedRows(0)
                ListaTemporalSuministrosNuevos.RemoveAt(liIndiceNuevoRemove)
            End If

            dtSuministros.Rows.RemoveAt(Me.gvSuministros.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaError("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub btnSumConsultarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumConsultarProveedor.Click
        Dim fmConsultaProveedor As frmConsultaProveedor = New frmConsultaProveedor()

        If fmConsultaProveedor.ShowDialog() = DialogResult.OK Then
            txtSumProveedor.Text = fmConsultaProveedor.PerProveedor
            txtSumProveedor.Tag = fmConsultaProveedor.PerId
        End If
    End Sub

    Private Sub cboTipoUnidad_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoUnidad.EditValueChanged
        mDeshabilitarSegunTipoUnidad()
    End Sub

    Private Sub mDeshabilitarSegunTipoUnidad()
        If cboTipoUnidad.EditValue = "01" Then
            btnConsultaInmueblePadre.Enabled = False
        Else
            btnConsultaInmueblePadre.Enabled = True
        End If
    End Sub

    Private Sub cboTipoArchivos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoArchivos.EditValueChanged
        If cboTipoArchivos.EditValue <> "04" Then
            chkArchPrincipal.Checked = False
            chkArchPrincipal.Properties.ReadOnly = True
        Else
            chkArchPrincipal.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub dgvArchivos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvArchivos.DoubleClick
        If Me.gvArchivos.DataRowCount <> 0 Then

            Dim fmCambiarArchivo As frmCambiarArchivo = New frmCambiarArchivo()
            fmCambiarArchivo.txtNombreArchivo.Text = dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArchNombre").ToString()
            fmCambiarArchivo.txtDescripcionArchivo.Text = dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArchDescripcion").ToString()
            fmCambiarArchivo.chkArchPrincipal.Checked = dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArchPrincipal").ToString()
            fmCambiarArchivo.TipoArchivo = dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArchExt").ToString()

            If fmCambiarArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If GEstadoNuevo = False Then
                    Dim liIndice As Int16

                    If String.IsNullOrEmpty(dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArchId").ToString()) Then
                        Dim liIndiceNuevoModificar As Int16 = 0
                        Dim liFila As Int16 = -1

                        For Each fTablaArchivos As DataRow In dtArchivos.Rows
                            If String.IsNullOrEmpty(fTablaArchivos("inmArchId")) And Me.gvArchivos.FocusedRowHandle = liFila Then
                                liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                            End If
                            liFila = liFila + 1
                        Next

                        ListaTemporalArchivosNuevos(liIndiceNuevoModificar).InmArchNombre = fmCambiarArchivo.txtNombreArchivo.Text
                        ListaTemporalArchivosNuevos(liIndiceNuevoModificar).InmArchDescripcion = fmCambiarArchivo.txtDescripcionArchivo.Text
                        ListaTemporalArchivosNuevos(liIndiceNuevoModificar).InmArchPrincipal = fmCambiarArchivo.chkArchPrincipal.Checked
                    Else
                        liIndice = ListaTemporalArchivosEditados.FindIndex(Function(s) s.InmArchId = dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArchId").ToString())

                        If liIndice = -1 Then
                            Dim loInmArchivos As EEInmArchivos = New EEInmArchivos()
                            loInmArchivos.InmArchId = dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArchId").ToString()
                            loInmArchivos.InmArchNombre = fmCambiarArchivo.txtNombreArchivo.Text
                            loInmArchivos.InmArchDescripcion = fmCambiarArchivo.txtDescripcionArchivo.Text
                            loInmArchivos.InmArchPrincipal = fmCambiarArchivo.chkArchPrincipal.Checked

                            ListaTemporalArchivosEditados.Add(loInmArchivos)
                        Else
                            ListaTemporalArchivosEditados(liIndice).InmArchNombre = fmCambiarArchivo.txtNombreArchivo.Text
                            ListaTemporalArchivosEditados(liIndice).InmArchDescripcion = fmCambiarArchivo.txtDescripcionArchivo.Text
                            ListaTemporalArchivosEditados(liIndice).InmArchPrincipal = fmCambiarArchivo.chkArchPrincipal.Checked
                        End If
                    End If
                End If

                If fmCambiarArchivo.chkArchPrincipal.Checked = True Then
                    For Each fTablaArchivos As DataRow In dtArchivos.Rows
                        fTablaArchivos("inmArchPrincipal") = False
                    Next

                    Dim loImageConver As ImageConver = New ImageConver
                    pbImagenPrincipal.Image = loImageConver.Bytes2Image(dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArch"))
                End If

                dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArchNombre") = fmCambiarArchivo.txtNombreArchivo.Text
                dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArchDescripcion") = fmCambiarArchivo.txtDescripcionArchivo.Text
                dtArchivos.Rows(Me.gvArchivos.FocusedRowHandle())("inmArchPrincipal") = fmCambiarArchivo.chkArchPrincipal.Checked
            End If
        End If
    End Sub

    Private Sub lvInmueblesDivisiones_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvInmueblesDivisiones.DoubleClick
        Try
            If Me.lvInmueblesDivisiones.DataRowCount <> 0 Then
                Dim InmId As String = lvInmueblesDivisiones.GetRowCellValue(Me.lvInmueblesDivisiones.GetSelectedRows(0), colNroDivision).ToString()
                Dim fmVisorInmuebles As frmVisorInmuebles = New frmVisorInmuebles(InmId)
                fmVisorInmuebles.MdiParent = Me.MdiParent
                fmVisorInmuebles.BringToFront()
                fmVisorInmuebles.Show()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub txtInmueblePrincipal_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInmueblePrincipal.DoubleClick
        If Not String.IsNullOrEmpty(txtInmueblePrincipal.Text) Then
            Dim fmVisorInmuebles As frmVisorInmuebles = New frmVisorInmuebles(txtInmueblePrincipal.Tag)
            fmVisorInmuebles.MdiParent = Me.MdiParent
            fmVisorInmuebles.BringToFront()
            fmVisorInmuebles.Show()
        End If
    End Sub

    'Private Sub cboUSituacionLegal_EditValueChanged(sender As Object, e As EventArgs)
    '    If lbListado = False Then
    '        If cboUSituacionLegal.cboUpdate.EditValue = "03" Then
    '            cboUEstadoSaneamiento.cboUpdate.EditValue = "03"
    '            mCambiarSegunSituacionLegal_Saneamiento("---", True)
    '        Else
    '            mCambiarSegunSituacionLegal_Saneamiento("", False)
    '        End If
    '    End If
    'End Sub

    Private Sub mCambiarSegunSituacionLegal_Saneamiento(ByVal asText As String, ByVal abReadOnly As Boolean, Optional ByVal abText As Boolean = True)
        'If abText Then
        '    txtDocAcredita.Text = asText
        '    txtPartElectronica.Text = asText
        '    txtAsiento.Text = asText
        'End If
        txtDocAcredita.Properties.ReadOnly = abReadOnly
        txtPartElectronica.Properties.ReadOnly = abReadOnly
        txtAsiento.Properties.ReadOnly = abReadOnly
    End Sub

    Private Sub cboUEstadoSaneamiento_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If lbListado = False Then
            If cboUEstadoSaneamiento.cboUpdate.EditValue = "04" Then
                mCambiarSegunSituacionLegal_Saneamiento("---", True)
            Else
                mCambiarSegunSituacionLegal_Saneamiento("", False)
            End If
        End If
    End Sub

    Private Sub mMostrarContratosXInmueble()
        Dim lsInmId As String = lblNroInmueble.EditValue

        Dim ListaContratos As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoInmListarXInmId_EnInmuebles(lsInmId)

        dtContrato.Clear()
        dtProgramacionPagos.Clear()
        If ListaContratos IsNot Nothing Then
            For Each fContratoInm As EEContratoInm In ListaContratos
                dtContrato.LoadDataRow(New Object() {fContratoInm.ConInmId, _
                fContratoInm.OInmueble.InmId, _
                fContratoInm.ConInmFecIni, _
                fContratoInm.ConInmFecFin, _
                fContratoInm.ConInmDiaMaxVen, _
                fContratoInm.InmDir, _
                fContratoInm.OTgUso.TgNombre, _
                fContratoInm.OTgEstado.TgNombre, _
                fContratoInm.OTgMoneda.TgNombre, _
                fContratoInm.OTgModalidad.TgNombre, _
                fContratoInm.OPersona.perNombresoRazon
                }, True)
            Next
            gvContrato.FocusedRowHandle = 0
            gvContrato.BestFitColumns()
            mMostrarProgramacionPagos()
        Else
            SaimtControles.SaimtMessageBox.mostrarAlertaInformativa("No se encontro Contratos para el Inmueble seleccionado.")
        End If

    End Sub

    Private Sub dgvContratos_CustomRowCellEditForEditing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvContrato.CustomRowCellEditForEditing
        mMostrarProgramacionPagos()
    End Sub

    Private Sub dgvContratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvContratos.Click
        mMostrarProgramacionPagos()
    End Sub

    Private Sub mMostrarProgramacionPagos()
        If Me.gvContrato.DataRowCount <> 0 Then
            Dim lsConInmId As String = gvContrato.GetRowCellValue(Me.gvContrato.GetSelectedRows(0), "conInmId").ToString()
            Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarXConInmIdConsultaProgramacionPagos(lsConInmId)
            dtProgramacionPagos.Clear()
            If ListaProPagos IsNot Nothing Then
                For Each fProPagos As EEProPagos In ListaProPagos
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
                    String.Format("{0:0.00}", fProPagos.ProPaComision)
                    }, True)
                Next
                gvProgramacionPagos.BestFitColumns()

            Else
                SaimtControles.SaimtMessageBox.mostrarAlertaInformativa("No se encontro Programacion de Pagos para el Contrato Seleccionado.")
            End If
        End If
    End Sub

    Private Sub dgvContratos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvContratos.DoubleClick
        If Me.gvContrato.DataRowCount <> 0 Then
            Dim fmConsultaProgramacionPagos As frmConsultaProgramacionPagos = New frmConsultaProgramacionPagos(gvContrato.GetRowCellValue(Me.gvContrato.GetSelectedRows(0), "inquilino").ToString())

            fmConsultaProgramacionPagos.MdiParent = Me.MdiParent
            fmConsultaProgramacionPagos.BringToFront()
            fmConsultaProgramacionPagos.Show()
        End If
    End Sub


    Private liFilaSeleccionadaPJ As Int16 = -1

#Region "Propio del Visor"
    Private Sub btnLimpiarPJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarPJ.Click
        GLimpiarControlesTotal(grbProcesoJudicial.Controls)
        btnAgregarPJ.Enabled = True
        btnActualizarPJ.Enabled = False
        btnGuardarPJ.Enabled = True
    End Sub

    Private Sub btnAgregarPJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPJ.Click
        dtProcesoJudicial.LoadDataRow(New Object() { _
          0, _
          dtpFechaInicioPJ.EditValue, _
          txtNroExpedientePJ.Text, _
          txtJuzgadoPJ.Text, _
          txtMotivoPJ.Text, _
          txtEtapaPJ.Text, _
          txtDemandantePJ.Text, _
          txtDemandadoPJ.Text, _
          cboEstadoPJ.EditValue, _
          cboEstadoPJ.Text, _
          txtLitisConsortePJ.Text, _
          txtSecretarioJudicialPJ.Text, _
          txtObservacioProcesoPJ.Text
     }, True)
        gvProcesosJudiciales.BestFitColumns()
    End Sub

    Private Sub btnActualizarPJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarPJ.Click
        Try
            If liFilaSeleccionadaPJ <> -1 Then
                If txtDemandantePJ.Tag <> "0" Then
                    'Actualizar BD
                    Dim loInmPJudiciales As EEInmPJudiciales = New EEInmPJudiciales()
                    loInmPJudiciales.InmPJudId = Trim(txtDemandantePJ.Tag)
                    loInmPJudiciales.InmPJudFechaInicio = dtpFechaInicioPJ.EditValue
                    loInmPJudiciales.InmPJudNroExp = Trim(txtNroExpedientePJ.Text)
                    loInmPJudiciales.InmPJudJuzgado = Trim(txtJuzgadoPJ.Text)
                    loInmPJudiciales.InmPJudMotivo = Trim(txtMotivoPJ.Text)
                    loInmPJudiciales.InmPJudEtapaProc = Trim(txtEtapaPJ.Text)
                    loInmPJudiciales.InmPJudDemandante = Trim(txtDemandantePJ.Text)
                    loInmPJudiciales.InmPJudDemandado = Trim(txtDemandadoPJ.Text)
                    loInmPJudiciales.OTgEstadoProceso = New EETablaGeneral()
                    loInmPJudiciales.OTgEstadoProceso.TgCodigo = cboEstadoPJ.EditValue
                    loInmPJudiciales.InmPJudLitisConsorte = Trim(txtLitisConsortePJ.Text)
                    loInmPJudiciales.InmPJudSecretario = Trim(txtSecretarioJudicialPJ.Text)
                    loInmPJudiciales.InmPJudObservacion = Trim(txtObservacioProcesoPJ.Text)

                    MantenimientosBL.Instancia.inmuebleActualizarPJ(loInmPJudiciales)

                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudDemandante") = Trim(txtDemandantePJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudDemandado") = Trim(txtDemandadoPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudFechaInicio") = dtpFechaInicioPJ.EditValue
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudNroExp") = Trim(txtNroExpedientePJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudJuzgado") = Trim(txtJuzgadoPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudMotivo") = Trim(txtMotivoPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudEtapaProc") = Trim(txtEtapaPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("TgEstadoProcId") = cboEstadoPJ.EditValue
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("TgEstadoProceso") = Trim(cboEstadoPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudLitisConsorte") = Trim(txtLitisConsortePJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudSecretario") = Trim(txtSecretarioJudicialPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudObservacion") = Trim(txtObservacioProcesoPJ.Text)

                    SaimtMessageBox.mostrarAlertaInformativa(String.Format("La Fila {0} Se Actualizo Correctamente.", liFilaSeleccionadaPJ))
                Else
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudDemandante") = Trim(txtDemandantePJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudDemandado") = Trim(txtDemandadoPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudFechaInicio") = dtpFechaInicioPJ.EditValue
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudNroExp") = Trim(txtNroExpedientePJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudJuzgado") = Trim(txtJuzgadoPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudMotivo") = Trim(txtMotivoPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudEtapaProc") = Trim(txtEtapaPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("TgEstadoProcId") = cboEstadoPJ.EditValue
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("TgEstadoProceso") = Trim(cboEstadoPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudLitisConsorte") = Trim(txtLitisConsortePJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudSecretario") = Trim(txtSecretarioJudicialPJ.Text)
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudObservacion") = Trim(txtObservacioProcesoPJ.Text)
                End If
                GLimpiarControlesTotal(grbProcesoJudicial.Controls)
                liFilaSeleccionadaPJ = -1
                btnAgregarPJ.Enabled = True
                btnActualizarPJ.Enabled = False
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    '   Private liFilaSeleccionadaPJ As Int16 = -1
    Private Sub gvProcesosJudiciales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvProcesosJudiciales.DoubleClick
        liFilaSeleccionadaPJ = Me.gvProcesosJudiciales.GetSelectedRows(0)
        txtDemandantePJ.Tag = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudId").ToString()
        txtDemandantePJ.Text = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudDemandante").ToString()
        txtDemandadoPJ.Text = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudDemandado").ToString()
        dtpFechaInicioPJ.EditValue = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudFechaInicio").ToString()
        txtNroExpedientePJ.Text = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudNroExp").ToString()
        txtJuzgadoPJ.Text = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudJuzgado").ToString()
        txtMotivoPJ.Text = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudMotivo").ToString()
        txtEtapaPJ.Text = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudEtapaProc").ToString()
        cboEstadoPJ.EditValue = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "TgEstadoProcId").ToString()
        txtLitisConsortePJ.Text = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudLitisConsorte").ToString()
        txtSecretarioJudicialPJ.Text = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudSecretario").ToString()
        txtObservacioProcesoPJ.Text = gvProcesosJudiciales.GetRowCellValue(Me.gvProcesosJudiciales.GetSelectedRows(0), "InmPJudObservacion").ToString()

        btnAgregarPJ.Enabled = False
        btnActualizarPJ.Enabled = True
        btnGuardarPJ.Enabled = False
    End Sub

    Private Sub btnGuardarPJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPJ.Click
        Try
            If SaimtMessageBox.mostrarAlertaPregunta("Desea Guardar ?", "Guardar Proceso Judicial") Then
                Dim loInmueble As EEInmueble = New EEInmueble()
                loInmueble.InmId = lsInmIdConsulta
                For Each fProcesoJudicial As DataRow In dtProcesoJudicial.Rows
                    Dim loInmPJudiciales As EEInmPJudiciales = New EEInmPJudiciales()
                    loInmPJudiciales.InmPJudId = Trim(fProcesoJudicial("InmPJudId"))
                    loInmPJudiciales.InmPJudFechaInicio = fProcesoJudicial("InmPJudFechaInicio")
                    loInmPJudiciales.InmPJudNroExp = Trim(fProcesoJudicial("InmPJudNroExp"))
                    loInmPJudiciales.InmPJudJuzgado = Trim(fProcesoJudicial("InmPJudJuzgado"))
                    loInmPJudiciales.InmPJudMotivo = Trim(fProcesoJudicial("InmPJudMotivo"))
                    loInmPJudiciales.InmPJudEtapaProc = Trim(fProcesoJudicial("InmPJudEtapaProc"))
                    loInmPJudiciales.InmPJudDemandante = Trim(fProcesoJudicial("InmPJudDemandante"))
                    loInmPJudiciales.InmPJudDemandado = Trim(fProcesoJudicial("InmPJudDemandado"))
                    loInmPJudiciales.OTgEstadoProceso = New EETablaGeneral()
                    loInmPJudiciales.OTgEstadoProceso.TgCodigo = Trim(fProcesoJudicial("TgEstadoProcId"))
                    loInmPJudiciales.InmPJudLitisConsorte = Trim(fProcesoJudicial("InmPJudLitisConsorte"))
                    loInmPJudiciales.InmPJudSecretario = Trim(fProcesoJudicial("InmPJudSecretario"))
                    loInmPJudiciales.InmPJudObservacion = Trim(fProcesoJudicial("InmPJudObservacion"))

                    loInmueble.ListaInmPJudiciales.Add(loInmPJudiciales)
                Next

                MantenimientosBL.Instancia.inmuebleGuardarPJ(loInmueble)

                '    mConsultaInmuebleXInmId(lsInmIdConsulta)

                SaimtMessageBox.mostrarAlertaInformativa("Se Guardo Correctamente")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnExaminarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminarArchivo.Click
        If ofdExaminarArchivos.ShowDialog() = DialogResult.OK Then
            Dim lsArchSplit As String() = ofdExaminarArchivos.FileName.Split(".")
            Dim loTablaGeneralArchivo As EETablaGeneral = MantenimientosBL.Instancia.tablageneralListarXTgAbrev(lsArchSplit(lsArchSplit.Length - 1))
            Dim f2 As FileInfo = New FileInfo(ofdExaminarArchivos.FileName)
            If (f2.Length / 1024) > loTablaGeneralArchivo.TgExtra Then
                SaimtMessageBox.mostrarAlertaError(String.Format("El Archivo Seleccionado Tiene {0} KB.{1}El Peso Requerido Para los Archivos {2} es de {3} KB.", (f2.Length / 1024), Environment.NewLine, loTablaGeneralArchivo.TgNombre, loTablaGeneralArchivo.TgExtra))
            Else
                txtBuscarArchivo.Text = ofdExaminarArchivos.FileName
                cboTipoArchivos.EditValue = loTablaGeneralArchivo.TgCodigo

                If loTablaGeneralArchivo.TgCodigo = "04" Then
                    chkArchPrincipal.Enabled = True
                Else
                    chkArchPrincipal.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub btnNuevoArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoArchivo.Click
        txtBuscarArchivo.Text = String.Empty
        txtNombreArchivo.Text = String.Empty
        txtDescripcionArchivo.Text = String.Empty
        chkArchPrincipal.Checked = False
    End Sub

    Private Sub btnAgregarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarArchivo.Click
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

            If chkArchPrincipal.Checked = True Then
                For Each fTablaArchivos As DataRow In dtArchivos.Rows
                    fTablaArchivos("inmArchPrincipal") = False
                Next
                pbImagenPrincipal.Image = loImageConver.Bytes2Image(loImageConver.FileToByteArray(txtBuscarArchivo.Text))
            End If

            dtArchivos.LoadDataRow(New Object() { _
                    "", _
                    txtNombreArchivo.Text, _
                    txtDescripcionArchivo.Text, _
                    cboTipoArchivos.EditValue, _
                    loImageConver.FileToByteArray(txtBuscarArchivo.Text), _
                    "." + lsArchSplit(lsArchSplit.Length - 1), _
                    chkArchPrincipal.Checked
            }, True)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarArchivo.Click
        Try
            If SaimtMessageBox.mostrarAlertaPregunta("Desea Guardar ?", "Guardar Archivos") Then
                Dim loInmueble As EEInmueble = New EEInmueble()
                loInmueble.InmId = lsInmIdConsulta
                For Each fTablaArchivos As DataRow In dtArchivos.Rows
                    Dim loInmArchivos As EEInmArchivos = New EEInmArchivos()
                    loInmArchivos.InmArchId = fTablaArchivos("inmArchId")
                    loInmArchivos.InmArchNombre = fTablaArchivos("inmArchNombre")
                    loInmArchivos.InmArchDescripcion = fTablaArchivos("inmArchDescripcion")
                    loInmArchivos.TgTipoArchId = fTablaArchivos("tgTipoArchId")
                    loInmArchivos.InmArch = fTablaArchivos("inmArch")
                    loInmArchivos.InmArchExt = fTablaArchivos("inmArchExt")
                    loInmArchivos.InmArchPrincipal = fTablaArchivos("inmArchPrincipal")

                    loInmueble.ListaInmArchivos.Add(loInmArchivos)
                Next

                MantenimientosBL.Instancia.inmuebleGuardarArchivos(loInmueble)

                SaimtMessageBox.mostrarAlertaInformativa("Se Guardo Correctamente")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region
End Class
