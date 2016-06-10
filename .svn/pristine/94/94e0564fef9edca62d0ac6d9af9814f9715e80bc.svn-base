Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraBars.Ribbon
Imports System.IO
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop

Public Class frmVisorInmuebles
    Inherits frmMantenimientos

    Dim dtArchivos As DataTable = New DataTable()
    Dim dtDivisiones As DataTable = New DataTable()
    'Lista Manejo Archivos
    Dim ListaTemporalArchivosEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalArchivosNuevos As List(Of EEInmArchivos) = New List(Of EEInmArchivos)
    Dim ListaTemporalArchivosEditados As List(Of EEInmArchivos) = New List(Of EEInmArchivos)
    'Fin Lista

    Dim loInmuebleGaleria As List(Of EEInmArchivos) = Nothing
    Dim lbListado As Boolean = False
    Dim dtContrato As DataTable = New DataTable()
    Dim dtProgramacionPagos As DataTable = New DataTable()
    Dim dtProcesoJudicial As DataTable = New DataTable()
    Dim dtListado As DataTable = New DataTable()
    Dim dtNivelImp As DataTable = New DataTable()
    Dim ImprimirTipo As String = String.Empty

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private lbConsulta As Boolean = False
    Private lsInmIdConsulta As String
    Public Sub New(ByVal asInmId As String, Optional ByVal asTipoImprimir As String = Nothing)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lsInmIdConsulta = asInmId
        ImprimirTipo = asTipoImprimir
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


    Private Sub ConstruirTableNivelImp()
        dtNivelImp.Columns.Add("InmId", GetType(String))
        dtNivelImp.Columns.Add("TgNivImpId", GetType(String))
        dtNivelImp.Columns.Add("InmNivDocumentos", GetType(String))
        dtNivelImp.Columns.Add("InmNivFisico", GetType(Boolean))
        dtNivelImp.Columns.Add("InmNivDigital", GetType(Boolean))
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
        dtListado.Columns.Add("tgTipoIngreso", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Private lsInmDirId As String = String.Empty
    Private lsInmPredId As String = String.Empty

    Sub MostrarXInmId()
        Try
            If lsInmIdConsulta <> 0 Then
                Dim loInmueble As EEInmueble = MantenimientosBL.Instancia.inmuebleMostrarXInmId(lsInmIdConsulta)
                If loInmueble IsNot Nothing Then
                    Me.beiprogreso.Caption = "Cargando Información del Perfil del Inmueble... "
                    Me.riprogreso.Minimum = 0
                    Me.riprogreso.Maximum = 5
                    Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    lbListado = True
                    'GIndiceSeleccionado = Me.gvListadoInmuebles.GetSelectedRows(0)
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
                    txtDocAcreditaInscripcion.Text = loInmueble.InmDocAcredita
                    txtPartElectronica.Text = loInmueble.InmPartidaElec
                    txtAsiento.Text = loInmueble.InmAsiento
                    txtSaneadoObserv.Text = loInmueble.InmSaneadoObs
                    cboSFinformacion.EditValue = loInmueble.tgInmSFZonificacionId
                    cboSfUso.EditValue = loInmueble.tgInmSFUsoId
                    cboNivel.EditValue = loInmueble.tgNivelId
                    txtInmObsNivelImp.Text = loInmueble.InmObsNivelImp
                    txtdocacreditadominio.Text = loInmueble.InmDocAcreditaDominio
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

                    txtObservacionTecnica.Text = loInmueble.InmObservacion
                    txtNroPisos.Text = loInmueble.InmNroPisos

                    cboEstadoConservacion.EditValue = loInmueble.tgEstInmConsvId
                    cboCondicionRegistral.EditValue = loInmueble.tgInmCondRegId
                    cboEstadoSaneamiento.EditValue = loInmueble.TgEstSanId
                    cboCondicionRegistralSub.EditValue = loInmueble.tgInmCondRegSubId
                    cboSituacionFisica.EditValue = loInmueble.tgInmSitFisicaId

                    cboTipoUnidad.EditValue = loInmueble.TgTipoUnidadId
                    cboEstadoInmueble.EditValue = loInmueble.TgInmEstado
                    cboRubroGrupos.EditValue = loInmueble.TgRubroGrupoId
                    cboRubro.EditValue = loInmueble.TgRubroId
                    cboCondicionLegal.EditValue = loInmueble.TgInmCondLegalId

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
                        cboDepartamento.EditValue = loInmueble.OInmDireccion.OUbigeo.UbgDep
                        cboProvincia.EditValue = loInmueble.OInmDireccion.OUbigeo.UbgProv
                        cboDistrito.EditValue = loInmueble.OInmDireccion.OUbigeo.UbgDist
                        cboLocalizacion.EditValue = loInmueble.OInmDireccion.TgLocalizacionId
                        txtLocalizacion.Text = loInmueble.OInmDireccion.InmDirLocalizacion
                        cboTipoNro.EditValue = loInmueble.OInmDireccion.TgNroId
                        txtNroUbicacion.Text = loInmueble.OInmDireccion.InmDirNro
                        cboTipoSubNro.EditValue = loInmueble.OInmDireccion.TgSubNroId
                        txtSubNro.Text = loInmueble.OInmDireccion.InmDirSubNro
                        'Grupo de Urbanzaciones
                        cboSubDistritos.EditValue = loInmueble.OInmDireccion.TgSubDistritosId
                        txtsubdistritoText.EditValue = loInmueble.OInmDireccion.InmDirSubDistritos
                        txtsubdistritoscbo.EditValue = loInmueble.OInmDireccion.InmDirSubDistritos

                        txtEtapa.Text = loInmueble.OInmDireccion.InmDirEtapa
                        txtFase.Text = loInmueble.OInmDireccion.InmDirFase
                        txtReferencia.Text = loInmueble.OInmDireccion.InmDirReferencia
                        txtbarrio.EditValue = loInmueble.OInmDireccion.InmDirBarrio
                        txtsector.EditValue = loInmueble.OInmDireccion.InmDirSector
                        chkDireccion.EditValue = loInmueble.OInmDireccion.InmDirCheck
                        txtdireccion.EditValue = loInmueble.OInmDireccion.InmDireccionCompleta
                        txtadicional.EditValue = loInmueble.OInmDireccion.InmDirAdicional
                        BarStaticItem1.Caption = txtdireccion.EditValue

                    Else
                        cboDepartamento.EditValue = Nothing
                        cboProvincia.EditValue = Nothing
                        cboDistrito.EditValue = Nothing
                        txtLocalizacion.Text = Nothing
                        cboLocalizacion.EditValue = Nothing
                        cboTipoNro.EditValue = Nothing
                        txtNroUbicacion.Text = Nothing
                        cboTipoSubNro.EditValue = Nothing
                        cboSubDistritos.EditValue = Nothing
                        txtsubdistritoText.EditValue = Nothing
                        txtsubdistritoscbo.EditValue = Nothing
                        txtSubNro.Text = Nothing
                        txtEtapa.Text = Nothing
                        txtFase.Text = Nothing
                        txtReferencia.Text = Nothing
                        txtbarrio.EditValue = Nothing
                        txtsector.EditValue = Nothing
                        chkDireccion.EditValue = False
                        txtdireccion.EditValue = Nothing
                        txtadicional.EditValue = Nothing
                        lsInmDirId = Nothing
                        BarStaticItem1.Caption = Nothing
                    End If

                    If loInmueble.OInmDireccionIns IsNot Nothing Then
                        'DIRECCIÓN
                        cboDepartamentoIns.EditValue = loInmueble.OInmDireccionIns.OUbigeo.UbgDep
                        cboProvinciaIns.EditValue = loInmueble.OInmDireccionIns.OUbigeo.UbgProv
                        cboDistritoIns.EditValue = loInmueble.OInmDireccionIns.OUbigeo.UbgDist
                        cboLocalizacionIns.EditValue = loInmueble.OInmDireccionIns.TgLocalizacionId
                        txtLocalizacionIns.Text = loInmueble.OInmDireccionIns.InmDirLocalizacion
                        cboTipoNroIns.EditValue = loInmueble.OInmDireccionIns.TgNroId
                        txtNroUbicacionIns.Text = loInmueble.OInmDireccionIns.InmDirNro
                        cboTipoSubNroIns.EditValue = loInmueble.OInmDireccionIns.TgSubNroId
                        txtSubNroIns.Text = loInmueble.OInmDireccionIns.InmDirSubNro
                        cboSubDistritosIns.EditValue = loInmueble.OInmDireccionIns.TgSubDistritosId
                        txtsubdistritoInsText.EditValue = loInmueble.OInmDireccionIns.InmDirSubDistritos
                        txtsubdistritosInscbo.EditValue = loInmueble.OInmDireccionIns.InmDirSubDistritos
                        txtEtapaIns.Text = loInmueble.OInmDireccionIns.InmDirEtapa
                        txtFaseIns.Text = loInmueble.OInmDireccionIns.InmDirFase
                        txtbarrioIns.EditValue = loInmueble.OInmDireccionIns.InmDirBarrio
                        txtsectorIns.EditValue = loInmueble.OInmDireccionIns.InmDirSector
                        chkDireccionIns.EditValue = loInmueble.OInmDireccionIns.InmDirCheck
                        txtFincaInscrita.EditValue = loInmueble.OInmDireccionIns.InmDireccionCompleta
                        txtadicionalIns.EditValue = loInmueble.OInmDireccionIns.InmDirAdicional
                    Else
                        cboDepartamentoIns.EditValue = Nothing
                        cboProvinciaIns.EditValue = Nothing
                        cboDistritoIns.EditValue = Nothing
                        txtLocalizacionIns.Text = Nothing
                        cboLocalizacionIns.EditValue = Nothing
                        cboTipoNroIns.EditValue = Nothing
                        txtNroUbicacionIns.Text = Nothing
                        cboTipoSubNroIns.EditValue = Nothing
                        txtSubNroIns.Text = Nothing
                        cboSubDistritosIns.EditValue = Nothing
                        txtsubdistritoInsText.EditValue = Nothing
                        txtsubdistritosInscbo.EditValue = Nothing
                        txtEtapaIns.Text = Nothing
                        txtFaseIns.Text = Nothing
                        txtbarrioIns.EditValue = Nothing
                        txtsectorIns.EditValue = Nothing
                        chkDireccionIns.EditValue = False
                        txtadicionalIns.EditValue = Nothing
                    End If

                    Application.DoEvents()
                    Me.beiprogreso.EditValue = 4

                    ' Valor arancelario

                    If loInmueble.OInmArancel IsNot Nothing Then
                        cboInmAraAnio.EditValue = loInmueble.OInmArancel.InmAraAnio
                        txtInmAraValUnitario.Text = loInmueble.OInmArancel.InmAraValUnitario
                        txtInmAraTotTerreno.Text = loInmueble.OInmArancel.InmAraTotTerreno
                        txtInmAraTotConstruccion.Text = loInmueble.OInmArancel.InmAraTotConstruccion
                        txtInmAraTotAutovaluo.Text = loInmueble.OInmArancel.InmAraTotAutovaluo
                        txtInmAraAreTerreno.Text = loInmueble.OInmArancel.InmAraAreTerreno
                        txtInmAraAreConstruida.Text = loInmueble.OInmArancel.InmAraAreConstruida
                        cboInmAraFuente.EditValue = loInmueble.OInmArancel.InmAraFuente
                        txtInmAraCodPredio.Text = loInmueble.OInmArancel.InmAraCodPredio
                        txtInmAraCodCatastral.Text = loInmueble.OInmArancel.InmAraCodCatastral
                    Else
                        ' Valor Arancelario
                        cboInmAraAnio.EditValue = String.Empty
                        txtInmAraValUnitario.Text = String.Empty
                        txtInmAraTotTerreno.Text = String.Empty
                        txtInmAraTotConstruccion.Text = String.Empty
                        txtInmAraTotAutovaluo.Text = String.Empty
                        txtInmAraAreTerreno.Text = String.Empty
                        txtInmAraAreConstruida.Text = String.Empty
                        cboInmAraFuente.ItemIndex = -1
                        txtInmAraCodPredio.Text = String.Empty
                        txtInmAraCodCatastral.Text = String.Empty
                    End If

                    ''PREDIO
                    'If loInmueble.OInmPredio IsNot Nothing Then
                    '    lsInmPredId = loInmueble.OInmPredio.InmPredId
                    '    txtArea.Text = loInmueble.OInmPredio.InmPredArea
                    '    If loInmueble.OInmPredio.InmPredArancel.HasValue Then
                    '        txtArancel.Text = loInmueble.OInmPredio.InmPredArancel
                    '    End If
                    '    If loInmueble.OInmPredio.InmPredValorTerreno.HasValue Then
                    '        txtValorTerreno.Text = loInmueble.OInmPredio.InmPredValorTerreno
                    '    End If
                    '    If loInmueble.OInmPredio.InmPredAreaTechada.HasValue Then
                    '        txtAreaTechada.Text = loInmueble.OInmPredio.InmPredAreaTechada
                    '    End If
                    '    If loInmueble.OInmPredio.InmPredValorConst.HasValue Then
                    '        txtValorConstruccion.Text = loInmueble.OInmPredio.InmPredValorConst
                    '    End If
                    '    If loInmueble.OInmPredio.InmPredValorEdificacion.HasValue Then
                    '        txtValorEdificacion.Text = loInmueble.OInmPredio.InmPredValorEdificacion
                    '    End If
                    '    If loInmueble.OInmPredio.InmPredValorTotal.HasValue Then
                    '        txtValorTotal.Text = loInmueble.OInmPredio.InmPredValorTotal
                    '    End If

                    '    chkPredioActivo.Checked = loInmueble.OInmPredio.InmPredActivo

                    '    If loInmueble.OInmPredio.InmPredFecTas.HasValue Then
                    '        dtpFechaTasacion.EditValue = loInmueble.OInmPredio.InmPredFecTas
                    '    End If
                    'Else
                    '    lsInmPredId = Nothing
                    '    txtArea.Text = String.Empty
                    '    txtArancel.Text = String.Empty
                    '    txtValorTerreno.Text = "0.00"
                    '    txtAreaTechada.Text = String.Empty
                    '    txtValorConstruccion.Text = String.Empty
                    '    txtValorEdificacion.Text = "0.00"
                    '    txtValorTotal.Text = "0.00"
                    '    chkPredioActivo.Checked = True
                    '    dtpFechaTasacion.EditValue = DateTime.Now
                    'End If
                    Application.DoEvents()
                    Me.beiprogreso.EditValue = 5
                    If loInmueble.OInmValorComercial IsNot Nothing Then
                        txtvc_tasacion.Text = loInmueble.OInmValorComercial.InmValComNroTas
                        If loInmueble.OInmValorComercial.InmValComArea.HasValue Then
                            txtvc_area.Text = loInmueble.OInmValorComercial.InmValComArea
                        End If
                        If loInmueble.OInmValorComercial.InmValComValxMetro.HasValue Then
                            txtvc_valorxmetro.Text = loInmueble.OInmValorComercial.InmValComValxMetro
                        End If

                        If loInmueble.OInmValorComercial.InmValComValTerreno.HasValue Then
                            txtvc_valorterreno.Text = loInmueble.OInmValorComercial.InmValComValTerreno
                        End If
                        If loInmueble.OInmValorComercial.InmValComValConst.HasValue Then
                            txtvc_valorconstruccion.Text = loInmueble.OInmValorComercial.InmValComValConst
                        End If
                        If loInmueble.OInmValorComercial.InmValComValTotal.HasValue Then
                            txtvc_valortotal.Text = loInmueble.OInmValorComercial.InmValComValTotal
                        End If

                        '  txtvc_observacion.EditValue = loInmueble.OInmValorComercial.InmValComObservacion
                        dpvc_fechatasacion.EditValue = loInmueble.OInmValorComercial.InmValComFechaTas
                        dpvc_fechaTasacionSug.EditValue = loInmueble.OInmValorComercial.InmValComFechaTasSug
                        txtvc_Perito.Tag = loInmueble.OInmValorComercial.InmValComPeritoPerId
                        txtvc_Perito.EditValue = loInmueble.OInmValorComercial.InmValComPeritoPer
                        txtvc_cpc.Text = String.Empty
                        txtvc_repev.Text = String.Empty
                        Dim loCPC As EEPersona.EEContacto = MantenimientosBL.Instancia.MostrarContactoPersonaXPerIdTgContactoId(txtvc_Perito.Tag, 15)
                        If loCPC IsNot Nothing Then
                            txtvc_cpc.Text = loCPC.ContDescripcion
                        End If
                        Dim loREPEV As EEPersona.EEContacto = MantenimientosBL.Instancia.MostrarContactoPersonaXPerIdTgContactoId(txtvc_Perito.Tag, 16)
                        If loREPEV IsNot Nothing Then
                            txtvc_repev.Text = loREPEV.ContDescripcion
                        End If
                    Else
                        txtvc_tasacion.Text = String.Empty
                        txtvc_area.Text = "0.00"
                        txtvc_valorxmetro.Text = "0.00"
                        txtvc_valorterreno.Text = "0.00"
                        txtvc_valorconstruccion.Text = "0.00"
                        txtvc_valortotal.Text = "0.00"
                        dpvc_fechatasacion.EditValue = String.Empty
                        dpvc_fechaTasacionSug.EditValue = String.Empty
                        txtvc_Perito.Text = String.Empty
                        'txtvc_observacion.Text = String.Empty
                        txtvc_cpc.Text = String.Empty
                        txtvc_repev.Text = String.Empty
                    End If

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
                            Dim loInmArch As EEInmArchivos = MantenimientosBL.Instancia.inmuebleMostrarInmArchXInmArchId(fArchivos.InmArchId)
                            If loInmArch IsNot Nothing Then
                                pbImagenPrincipal.Image = loImageConver.Bytes2Image(loInmArch.InmArch)
                            End If
                        End If
                    Next

                    '  Dim loNivelImp As List(Of EEInmNivelImp) = MantenimientosBL.Instancia.tablageneralListarXClsId2(0)
                    ' If loNivelImp IsNot Nothing Then
                    dtNivelImp.Clear()

                    For Each frow As EEInmNivelImp In loInmueble.ListaInmNivImp
                        dtNivelImp.LoadDataRow(New Object() {frow.InmId, frow.TgNivImpId, frow.TgNivImp, frow.InmNivfisico, frow.InmNivDigital}, True)
                    Next
                    If dtNivelImp.Rows.Count = 0 Then
                        Dim loNivelImp As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(184)
                        If loNivelImp IsNot Nothing Then
                            For Each frow As EETablaGeneral In loNivelImp
                                dtNivelImp.LoadDataRow(New Object() {0, frow.TgCodigo, frow.TgNombre, False, False}, True)
                            Next
                        End If
                    End If

                    gvNivelImp.OptionsBehavior.Editable = False


                    'End If

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

                    If Len(loInmueble.inmDocAlta) = 0 Then
                        txtAltaDoc.Text = Nothing
                        dtpAltaFechaDoc.EditValue = Nothing
                        txtAltaCausa.Text = Nothing
                        txtAltaObservacion.Text = Nothing
                    Else
                        txtAltaDoc.Text = loInmueble.inmDocAlta
                        dtpAltaFechaDoc.EditValue = loInmueble.inmFecAlta
                        txtAltaCausa.Text = loInmueble.inmCausalAlta
                        txtAltaObservacion.Text = loInmueble.inmAltaObservacion
                    End If

                    'DATOS BAJAS
                    Dim loInmuebleBajas As EEInmueble.EEInmBajas = MantenimientosBL.Instancia.inmbajasxInmBajaId(loInmueble.InmId)
                    If loInmuebleBajas IsNot Nothing Then
                        txtBajaDoc.Text = loInmuebleBajas.InmBajaNroDoc
                        dtpBajaFecDoc.EditValue = loInmuebleBajas.InmBajaDocFecha
                        dtpBajaFecha.EditValue = loInmuebleBajas.InmBajaFecha
                        txtBajaCausal.Text = loInmuebleBajas.InmBajaCausa
                        txtBajaRefDocArchivo.Text = loInmuebleBajas.InmBajaDocArchivo
                        txtBajaObservacion.Text = loInmuebleBajas.InmBajaObservacion
                        'isTemporal = loInmuebleBajas.InmBajaTemporal
                        txtBajaDatoAdicional.Text = loInmuebleBajas.InmBajaDatoAdicional
                    Else
                        txtBajaDoc.Text = String.Empty
                        dtpBajaFecDoc.EditValue = Nothing
                        dtpBajaFecha.EditValue = Nothing
                        txtBajaCausal.Text = String.Empty
                        txtBajaRefDocArchivo.Text = String.Empty
                        txtBajaObservacion.Text = String.Empty
                        txtBajaDatoAdicional.Text = String.Empty
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

    Protected Overrides Sub guardar()
        If String.IsNullOrEmpty(txtNroFile.Text) Then
            SaimtMessageBox.mostrarAlertaInformativa("El Campo N° de File es obligatorio")
            txtNroFile.Focus()
            Return
        End If

        If cboTipoUnidad.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("El Campo Tipo Unidad es obligatorio")
            cboTipoUnidad.Focus()
            Return
        End If

        If cboEstadoInmueble.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("El Campo Estado es obligatorio")
            cboEstadoInmueble.Focus()
            Return
        End If

        If cboDepartamento.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("El Departamento es obligatorio")
            cboDepartamento.Focus()
            Return
        End If
        If cboRubro.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("El Rubro es obligatorio")
            cboRubro.Focus()
            Exit Sub
        End If

        If Convert.ToDecimal(txtArea.Text) < 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Información Técnica => Área No Puede Ser Negativo.")
            txtArea.Focus()
            Exit Sub
        End If

        'If Convert.ToDecimal(txtArancel.Text) < 0 Then
        '    SaimtMessageBox.mostrarAlertaAdvertencia("Información Técnica => Arancel No Puede Ser Negativo.")
        '    txtArancel.Focus()
        '    Exit Sub
        'End If

        'If Convert.ToDecimal(txtAreaTechada.Text) < 0 Then
        '    SaimtMessageBox.mostrarAlertaAdvertencia("Información Técnica => Área Techada No Puede Ser Negativo.")
        '    txtAreaTechada.Focus()
        '    Exit Sub
        'End If

        'If Convert.ToDecimal(txtValorConstruccion.Text) < 0 Then
        '    SaimtMessageBox.mostrarAlertaAdvertencia("Información Técnica => Valor Construcción No Puede Ser Negativo.")
        '    txtValorConstruccion.Focus()
        '    Exit Sub
        'End If

        Try
            Dim loInmueble As EEInmueble = New EEInmueble()
            Dim loInmDireccion As EEInmDireccion = New EEInmDireccion()
            Dim loInmDireccionIns As EEInmDireccion = New EEInmDireccion()
            Dim loInmPredio As EEInmPredio = New EEInmPredio()
            Dim loInmValorComercial As EEInmValorComercial = New EEInmValorComercial()
            Dim loUbigeo As EEUbigeo = New EEUbigeo()
            Dim loUbigeoIns As EEUbigeo = New EEUbigeo()


            loInmueble.InmId = GIdRegistroActual
            loInmueble.InmFile = txtNroFile.Text
            loInmueble.InmFileAnt = txtNroFileAntiguo.Text
            loInmueble.InmInscrito = txtFincaInscrita.Text
            loInmueble.InmDenominacion = txtDenominacion.Text
            loInmueble.InmDocAcredita = txtDocAcreditaInscripcion.Text
            loInmueble.InmPartidaElec = txtPartElectronica.Text
            loInmueble.InmAsiento = txtAsiento.Text
            loInmueble.InmSaneadoObs = txtSaneadoObserv.Text
            loInmueble.InmDisponibilidad = chkDisponibilidad.Checked
            loInmueble.InmFecMarg = dtpFechaRegistroMargesi.EditValue
            loInmueble.InmObservacion = txtObservacionTecnica.Text
            loInmueble.InmNroPisos = txtNroPisos.Text
            loInmueble.InmIdPadre = txtInmueblePrincipal.Tag
            loInmueble.InmUbicacion = txtdireccion.Text
            loInmueble.tgNivelId = cboNivel.EditValue

            loInmueble.tgEstInmConsvId = cboEstadoConservacion.EditValue
            loInmueble.tgInmCondRegId = cboCondicionRegistral.EditValue
            loInmueble.tgInmCondRegSubId = cboCondicionRegistralSub.EditValue
            loInmueble.TgInmCondLegalId = cboCondicionLegal.EditValue
            loInmueble.tgInmSitFisicaId = cboSituacionFisica.EditValue
            loInmueble.TgEstSanId = cboEstadoSaneamiento.EditValue
            loInmueble.tgInmCondRegId = cboCondicionRegistral.EditValue
            loInmueble.InmActivo = chkInmuebleActivo.Checked
            loInmueble.TgTipoUnidadId = cboTipoUnidad.EditValue
            loInmueble.TgInmEstado = cboEstadoInmueble.EditValue
            loInmueble.TgRubroId = cboRubro.EditValue
            loInmueble.tgInmSFZonificacionId = cboSFinformacion.EditValue
            loInmueble.tgInmSFUsoId = cboSfUso.EditValue
            loInmueble.InmObsNivelImp = txtInmObsNivelImp.Text
            loInmueble.InmDocAcreditaDominio = txtdocacreditadominio.Text
            'Direccion
            loUbigeo.UbgDep = cboDepartamento.EditValue
            loUbigeo.UbgProv = cboProvincia.EditValue
            loUbigeo.UbgDist = cboDistrito.EditValue
            loInmDireccion.InmDirId = lsInmDirId
            loInmDireccion.InmDirLocalizacion = txtLocalizacion.Text
            loInmDireccion.TgLocalizacionId = cboLocalizacion.EditValue
            loInmDireccion.TgNroId = cboTipoNro.EditValue
            loInmDireccion.InmDirNro = txtNroUbicacion.Text
            loInmDireccion.TgSubNroId = cboTipoSubNro.EditValue
            loInmDireccion.InmDirSubNro = txtSubNro.Text
            loInmDireccion.InmDirFase = txtFase.Text
            loInmDireccion.InmDirEtapa = txtEtapa.Text
            loInmDireccion.InmDirReferencia = txtReferencia.Text
            loInmDireccion.TgSubDistritosId = cboSubDistritos.EditValue
            loInmDireccion.InmDirSubDistritos = IIf(txtsubdistritoscbo.Visible = True, txtsubdistritoscbo.EditValue, txtsubdistritoText.EditValue)
            loInmDireccion.OUbigeo = loUbigeo
            loInmueble.OInmDireccion = loInmDireccion
            loInmDireccion.InmDirBarrio = txtbarrio.Text
            loInmDireccion.InmDirSector = txtsector.Text
            loInmDireccion.InmDirAdicional = txtadicional.Text
            loInmDireccion.InmDirCheck = chkDireccion.Checked
            'Direccion Ins
            loUbigeoIns.UbgDep = cboDepartamentoIns.EditValue
            loUbigeoIns.UbgProv = cboProvinciaIns.EditValue
            loUbigeoIns.UbgDist = cboDistritoIns.EditValue
            loInmDireccionIns.InmDirId = lsInmDirId
            loInmDireccionIns.InmDirLocalizacion = txtLocalizacionIns.Text
            loInmDireccionIns.TgLocalizacionId = cboLocalizacionIns.EditValue
            loInmDireccionIns.TgNroId = cboTipoNroIns.EditValue
            loInmDireccionIns.InmDirNro = txtNroUbicacionIns.Text
            loInmDireccionIns.TgSubNroId = cboTipoSubNroIns.EditValue
            loInmDireccionIns.InmDirSubNro = txtSubNroIns.Text
            loInmDireccionIns.InmDirFase = txtFaseIns.Text
            loInmDireccionIns.InmDirEtapa = txtEtapaIns.Text
            loInmDireccionIns.TgSubDistritosId = cboSubDistritosIns.EditValue
            loInmDireccionIns.InmDirSubDistritos = IIf(txtsubdistritosInscbo.Visible = True, txtsubdistritosInscbo.EditValue, txtsubdistritoInsText.EditValue)
            loInmDireccionIns.InmDirSector = txtsectorIns.Text
            loInmDireccionIns.InmDirBarrio = txtbarrioIns.Text
            loInmDireccionIns.InmDirAdicional = txtadicionalIns.Text
            loInmDireccionIns.InmDirCheck = chkDireccionIns.Checked
            loInmDireccionIns.OUbigeo = loUbigeoIns
            loInmueble.OInmDireccionIns = loInmDireccionIns

            ''Predio
            'loInmPredio.InmPredId = lsInmPredId
            'loInmPredio.InmPredFecTas = dtpFechaTasacion.EditValue
            'loInmPredio.InmPredArea = txtArea.Text
            'loInmPredio.InmPredArancel = txtArancel.Text
            'loInmPredio.InmPredValorTerreno = txtValorTerreno.Text
            'loInmPredio.InmPredAreaTechada = txtAreaTechada.Text
            'loInmPredio.InmPredValorConst = txtValorConstruccion.Text
            'loInmPredio.InmPredValorTotal = txtValorTotal.Text
            'loInmPredio.InmPredValorEdificacion = txtValorEdificacion.Text
            'loInmPredio.InmPredActivo = chkPredioActivo.Checked
            'loInmueble.OInmPredio = loInmPredio

            ' Valor comercial
            loInmValorComercial.InmId = GIdRegistroActual
            loInmValorComercial.InmValComNroTas = txtvc_tasacion.Text
            loInmValorComercial.InmValComArea = txtvc_area.Text
            loInmValorComercial.InmValComValxMetro = txtvc_valorxmetro.Text
            loInmValorComercial.InmValComValTerreno = txtvc_valorterreno.Text
            loInmValorComercial.InmValComValConst = txtvc_valorconstruccion.Text
            loInmValorComercial.InmValComValTotal = txtvc_valortotal.Text
            loInmValorComercial.InmValComFechaTas = dpvc_fechatasacion.EditValue
            loInmValorComercial.InmValComFechaTasSug = dpvc_fechaTasacionSug.EditValue
            loInmValorComercial.InmValComPeritoPerId = txtvc_Perito.Tag
            ' loInmValorComercial.InmValComObservacion = txtvc_observacion.EditValue
            loInmueble.OInmValorComercial = loInmValorComercial

            'Archivos
            For Each fTablaArchivos As DataRow In dtArchivos.Rows
                Dim loInmArchivos As EEInmArchivos = New EEInmArchivos()
                loInmArchivos.InmArchId = fTablaArchivos("inmArchId")
                loInmArchivos.InmArchNombre = fTablaArchivos("inmArchNombre")
                loInmArchivos.InmArchDescripcion = fTablaArchivos("inmArchDescripcion")
                loInmArchivos.TgTipoArchId = fTablaArchivos("tgTipoArchId")
                If Not IsDBNull(fTablaArchivos("inmArch")) Then
                    loInmArchivos.InmArch = fTablaArchivos("inmArch")
                End If

                loInmArchivos.InmArchExt = fTablaArchivos("inmArchExt")
                loInmArchivos.InmArchPrincipal = fTablaArchivos("inmArchPrincipal")
                loInmueble.ListaInmArchivos.Add(loInmArchivos)
            Next
            'Nivel de Inmplementacion
            For Each ftabla As DataRow In dtNivelImp.Rows
                Dim loNivelImp As EEInmNivelImp = New EEInmNivelImp() With {.InmId = ftabla("InmId"), .TgNivImpId = ftabla("TgNivImpId"), .InmNivfisico = ftabla("InmNivfisico"), .InmNivDigital = ftabla("InmNivDigital")}
                loInmueble.ListaInmNivImp.Add(loNivelImp)
            Next
            ''Suministros
            'Dim loTablaGeneral As EETablaGeneral
            'Dim loPersona As EEPersona
            'For Each fSuministros As DataRow In dtSuministros.Rows
            '    Dim loInmSuministros As EEInmSuministros = New EEInmSuministros()

            '    loTablaGeneral = New EETablaGeneral()
            '    loTablaGeneral.TgCodigo = fSuministros("tgTipoServicioId")

            '    loPersona = New EEPersona()
            '    loPersona.PerId = fSuministros("perId")

            '    loInmSuministros.OPersona = loPersona
            '    loInmSuministros.TgTipoServicio = loTablaGeneral
            '    loInmSuministros.InmSumFechaVen = fSuministros("FechaVencimiento")

            '    loTablaGeneral = New EETablaGeneral()
            '    loTablaGeneral.TgCodigo = fSuministros("tgTipoMesId")

            '    loInmSuministros.TgTipoMes = loTablaGeneral
            '    loInmSuministros.InmSumAño = CInt(fSuministros("Año"))
            '    loInmSuministros.InmSumMonto = fSuministros("Monto")
            '    loInmSuministros.InmSumMedidor = fSuministros("NroMedidor")

            '    loInmueble.ListaInmSuministros.Add(loInmSuministros)
            'Next

            'Procesos Judiciales
            For Each fProcesoJudicial As DataRow In dtProcesoJudicial.Rows
                Dim loInmPJudiciales As EEInmPJudiciales = New EEInmPJudiciales() With {.InmPJudId = fProcesoJudicial("InmPJudId"), .InmPJudFechaInicio = fProcesoJudicial("InmPJudFechaInicio"), .InmPJudNroExp = fProcesoJudicial("InmPJudNroExp"), .InmPJudJuzgado = fProcesoJudicial("InmPJudJuzgado"), .InmPJudMotivo = fProcesoJudicial("InmPJudMotivo"), .InmPJudEtapaProc = fProcesoJudicial("InmPJudEtapaProc"), .InmPJudDemandante = fProcesoJudicial("InmPJudDemandante"), .InmPJudDemandado = fProcesoJudicial("InmPJudDemandado"), .OTgEstadoProceso = New EETablaGeneral()}
                loInmPJudiciales.OTgEstadoProceso.TgCodigo = fProcesoJudicial("TgEstadoProcId")
                loInmPJudiciales.InmPJudLitisConsorte = fProcesoJudicial("InmPJudLitisConsorte")
                loInmPJudiciales.InmPJudSecretario = fProcesoJudicial("InmPJudSecretario")
                loInmPJudiciales.InmPJudObservacion = fProcesoJudicial("InmPJudObservacion")

                loInmueble.ListaInmPJudiciales.Add(loInmPJudiciales)
            Next

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.inmuebleGuardar(loInmueble)
            Else
                loInmueble.ListaInmArchivosTemporalNuevos = ListaTemporalArchivosNuevos
                loInmueble.ListaInmArchivosTemporalEliminados = ListaTemporalArchivosEliminados
                loInmueble.ListaInmArchivosEditados = ListaTemporalArchivosEditados

                '  loInmueble.ListaInmSuministrosTemporalNuevos = ListaTemporalSuministrosNuevos
                'loInmueble.ListaInmSuministrosTemporalEliminados = ListaTemporalArchivosEliminados
                MantenimientosBL.Instancia.inmuebleActualizar(loInmueble)
                ListaTemporalArchivosNuevos.Clear()
                ListaTemporalArchivosEliminados.Clear()
                ListaTemporalArchivosEditados.Clear()
                'chkDireccion.Checked = False
                ' chkDireccionIns.Checked = False
            End If
            Me.enabledGA = False
            MyBase.guardar()
            'listar()
            ' txtcriterioNroFile.Properties.ReadOnly = False
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Sub ImprimirInmNormal()
        Dim oWordN As Word.Application
        Dim oDocN As Word._Document = Nothing
        Try
            Application.DoEvents()
            oWordN = CreateObject("Word.Application")
            oDocN = oWordN.Documents.Open(EEComun.RutaReportes & "\FICHAPRINCIPALDELINMUEBLE.doc", True, True)
            Dim wRng As Word.Range

            'CÓDIGO MARGESÍ MPT
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[RUBRO]", ReplaceWith:=IIf(cboRubro.Text = Nothing Or cboRubro.Text = "", "Ninguno", cboRubro.Text), Replace:=Word.WdReplace.wdReplaceAll)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[NROFILE]", ReplaceWith:=IIf(txtNroFile.Text = Nothing Or txtNroFile.Text = "", "Ninguno", txtNroFile.Text), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content

            ' FOTO PRINCIPAL
            Try
                System.IO.Directory.CreateDirectory("c:\temp")
                Dim imagen As String = "C:\temp\" & lblNroInmueble.Text & ".jpg"
                pbImagenPrincipal.Image.Save(imagen, System.Drawing.Imaging.ImageFormat.Jpeg)
                wRng = oDocN.Content
                wRng.Document.Shapes.AddPicture(imagen, , , 100, 40, 250, 150)
                If File.Exists(imagen) Then
                    File.Delete(imagen)
                End If
            Catch ex As Exception

            End Try
            'DÁTOS BASICOS - IZQUIERDA
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FREGIST]", ReplaceWith:=IIf(dtpFechaRegistroMargesi.Text = Nothing Or dtpFechaRegistroMargesi.Text = "", "Ninguno", dtpFechaRegistroMargesi.Text), Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[TIPOUNIDA]", ReplaceWith:=IIf(cboTipoUnidad.Text = Nothing Or cboTipoUnidad.Text = "", "Ninguno", cboTipoUnidad.Text), Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[INMPRINCI]", ReplaceWith:=IIf(txtInmueblePrincipal.Text = Nothing Or txtInmueblePrincipal.Text = "", "Ninguno", txtInmueblePrincipal.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'DÁTOS BASICOS - DERECHA
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ESTADO]", ReplaceWith:=IIf(cboEstadoInmueble.Text = Nothing Or cboEstadoInmueble.Text = "", "Ninguno", cboEstadoInmueble.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[NROFILEANT]", ReplaceWith:=IIf(txtNroFileAntiguo.Text = Nothing Or txtNroFileAntiguo.Text = "", "Ninguno", txtNroFileAntiguo.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[CODINFORMATICO]", ReplaceWith:=IIf(lblNroInmueble.Text = Nothing Or lblNroInmueble.Text = "", "Ninguno", lblNroInmueble.Text), Replace:=Word.WdReplace.wdReplaceAll)

            'DENOMINACION 
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DENOMINACION]", ReplaceWith:=IIf(txtDenominacion.Text = Nothing Or txtDenominacion.Text = "", "Ninguno", txtDenominacion.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'UBICACIÓN 
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[UBICACIONDISTRITO]", ReplaceWith:=IIf(cboDistrito.Text = Nothing Or cboDistrito.Text = "", "Ninguno", cboDistrito.Text), Replace:=Word.WdReplace.wdReplaceOne)
            ' wRng = oDocN.Content
            '  wRng.Find.Execute(FindText:="[UBICACIONDIRECCION]", ReplaceWith:=IIf(txtdireccion.Text = Nothing Or txtdireccion.Text = "", "Ninguno", txtdireccion.Text), Replace:=Word.WdReplace.wdReplaceOne)

            If txtdireccion.Text IsNot Nothing Then
                For Each s As String In txtdireccion.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[UBICACIONDIRECCION]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguno", s & "[UBICACIONDIRECCION]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[UBICACIONDIRECCION]", ReplaceWith:=s1 & "[UBICACIONDIRECCION]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[UBICACIONDIRECCION]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)
            'FINCA INSCRITA 
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FINCAINSDISTRITO]", ReplaceWith:=IIf(cboDistritoIns.Text = Nothing Or cboDistritoIns.Text = "", "Ninguno", cboDistritoIns.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FINCAINSCRITA]", ReplaceWith:=IIf(txtFincaInscrita.Text = Nothing Or txtFincaInscrita.Text = "", "Ninguno", txtFincaInscrita.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'INFORMACIÓN LEGAL - Situación Legal.
            Dim lotablatemp As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgCondicionLegal, cboCondicionLegal.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[CONDICIONLEGAL]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)

            End If
            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgCondicionRegistral, cboCondicionRegistral.EditValue)
            If lotablatemp IsNot Nothing Then
                Dim CondicionRegistralSub, CondicionRegistral As String
                CondicionRegistral = lotablatemp.Item(0).TgNombre
                lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(175, cboCondicionRegistralSub.EditValue)
                CondicionRegistralSub = lotablatemp.Item(0).TgNombre
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[CONDICIONREGISTRAL]", ReplaceWith:=IIf(CondicionRegistral = Nothing Or CondicionRegistral = "", "Ninguno", CondicionRegistral & " - " & CondicionRegistralSub), Replace:=Word.WdReplace.wdReplaceOne)
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[PARTELECTRONICA]", ReplaceWith:=IIf(txtPartElectronica.Text = Nothing Or txtPartElectronica.Text = "", "NO ASIGNADO", txtPartElectronica.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ASIENTO]", ReplaceWith:=IIf(txtAsiento.Text = Nothing Or txtAsiento.Text = "", "NO ASIGNADO", txtAsiento.Text), Replace:=Word.WdReplace.wdReplaceAll)
            ' wRng = oDocN.Content
            ' wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:=IIf(txtDocAcreditaInscripcion.Text = Nothing Or txtDocAcreditaInscripcion.Text = "", "NO ASIGNADO", txtDocAcreditaInscripcion.Text), Replace:=Word.WdReplace.wdReplaceOne)
            If txtDocAcreditaInscripcion.Text IsNot Nothing Then
                For Each s As String In txtDocAcreditaInscripcion.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:=IIf(s = Nothing Or s = "", "NO ASIGNADO", s & "[TITULOINSCRIPCION]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:=s1 & "[TITULOINSCRIPCION]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)

            'INFORMACIÓN LEGAL - Proceso de Saneamiento
            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgEstadoSaneamiento, cboEstadoSaneamiento.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[ESTADOLEGAL]", ReplaceWith:=IIf(lotablatemp(0).TgNombre = Nothing Or lotablatemp(0).TgNombre = "", "Ninguno", lotablatemp(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)

            End If

            If txtdocacreditadominio.Text IsNot Nothing Then
                For Each s As String In txtdocacreditadominio.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[DOCACREDITADOMINIO]", ReplaceWith:=IIf(s = Nothing Or s = "", "NO ASIGNADO", s & "[DOCACREDITADOMINIO]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[DOCACREDITADOMINIO]", ReplaceWith:=s1 & "[DOCACREDITADOMINIO]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DOCACREDITADOMINIO]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)

            'INSPECCION TECNICA

            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgSituacionFisica, cboSituacionFisica.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[USOACTUAL]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)
            End If

            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgSFInformacion, cboSFinformacion.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[ZONIFICACIONUSO]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)
            End If
            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgEstadoConservacion, cboEstadoConservacion.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[ESTADOCONCERVACION]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)
            End If

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[EDIFICACION]", ReplaceWith:=IIf(txtNroPisos.EditValue = Nothing Or txtNroPisos.EditValue = "", "Ninguno", txtNroPisos.EditValue), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[AREA]", ReplaceWith:=IIf(txtArea.Text = Nothing Or txtArea.Text = "", "Ninguno", txtArea.Text & " m2"), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[VALORPREDIO]", ReplaceWith:=IIf(txtvc_valortotal.Text = Nothing Or txtvc_valortotal.Text = "", "Ninguno", "S/. " & txtvc_valortotal.Text), Replace:=Word.WdReplace.wdReplaceOne)
            ' ARCHIVOS
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ESTADONIVIMPLEMENTACION]", ReplaceWith:=IIf(cboNivel.Text = Nothing Or cboNivel.Text = "", "Ninguno", cboNivel.Text), Replace:=Word.WdReplace.wdReplaceOne)
            'Dim cs As Int16 = 0
            Dim nc As String = String.Empty
            If txtSaneadoObserv.Text IsNot Nothing Then
                For Each s As String In txtSaneadoObserv.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[OBSERVACIONLEGAL]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguno", s & "[OBSERVACIONLEGAL]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[OBSERVACIONLEGAL]", ReplaceWith:=s1 & "[OBSERVACIONLEGAL]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
                If txtSaneadoObserv.Text.Length < 581 Then
                    For i = CInt((txtSaneadoObserv.Text.Length / 83) + 0.5) To 7
                        nc = nc & vbCrLf
                    Next
                End If
            End If

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[OBSERVACIONLEGAL]", ReplaceWith:="" & nc, Replace:=Word.WdReplace.wdReplaceAll)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:=vbLf, ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)

            If txtObservacionTecnica.Text IsNot Nothing Then
                For Each s As String In txtObservacionTecnica.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguno", s & "[OBSERVACIONTECNICA]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=s1 & "[OBSERVACIONTECNICA]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                        ' wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=s1 & "[OBSERVACIONTECNICA]", Replace:=Word.WdReplace.wdReplaceOne)
                    End Try
                Next
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceOne)
            'DATOS DE IMPRESION
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FECHAEMISION]", ReplaceWith:=DateTime.Now().ToShortDateString(), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[USUARIO]", ReplaceWith:=IIf(EEComun.Usuario = Nothing Or EEComun.Usuario = "", "Ninguno", EEComun.Usuario), Replace:=Word.WdReplace.wdReplaceOne)

            Dim locargoPersonal As List(Of EECargoPersonal) = MantenimientosBL.Instancia.CargoListarXPerId_pa(EEComun._PerId)
            If locargoPersonal IsNot Nothing Then
                Dim area As String = locargoPersonal(0).Area
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[AREAUSUARIO]", ReplaceWith:=IIf(area = Nothing Or area = "", "Ninguno", area), Replace:=Word.WdReplace.wdReplaceOne)
            End If

            Dim lotablageneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(184)
            If lotablageneral IsNot Nothing Then
                For Each ftabla1 As EETablaGeneral In lotablageneral
                    For Each ftabla As DataRow In dtNivelImp.Rows
                        If ftabla("TgNivImpId") = ftabla1.TgCodigo Then
                            Dim v As String = CInt(ftabla("TgNivImpId"))
                            wRng = oDocN.Content
                            wRng.Find.Execute(FindText:="[f" & v & "]", ReplaceWith:=IIf(ftabla("InmNivFisico") = True, " x  ", "    "), Replace:=Word.WdReplace.wdReplaceOne)
                            wRng = oDocN.Content
                            wRng.Find.Execute(FindText:="[d" & v & "]", ReplaceWith:=IIf(ftabla("InmNivDigital") = True, " x  ", "    "), Replace:=Word.WdReplace.wdReplaceOne)
                            Exit For
                        End If
                    Next
                Next
            End If
            If fbdinmueble.ShowDialog = Windows.Forms.DialogResult.OK Then
                oWordN.ActiveDocument.SaveAs2(String.Format("{0}\File-{1}-{2}", fbdinmueble.SelectedPath, txtNroFile.Text, cboRubro.Text), 17)
                oWordN.ActiveDocument.Close(False)
                bsiMensaje.Caption = String.Format("El archivo se guardo correctamente en la ruta seleccionada con el nombre File-{0}-{1}", txtNroFile.Text, cboRubro.Text)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Sub imprimirInmBaja()
        Dim oWordN As Word.Application
        Dim oDocN As Word._Document = Nothing
        Try
            Application.DoEvents()
            oWordN = CreateObject("Word.Application")
            oDocN = oWordN.Documents.Open(EEComun.RutaReportes & "\FICHAPRINCIPALDELINMUEBLE_BAJA.doc", True, True)
            Dim wRng As Word.Range

            'CÓDIGO MARGESÍ MPT
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[RUBRO]", ReplaceWith:=IIf(cboRubro.Text = Nothing Or cboRubro.Text = "", "Ninguno", cboRubro.Text), Replace:=Word.WdReplace.wdReplaceAll)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[NROFILE]", ReplaceWith:=IIf(txtNroFile.Text = Nothing Or txtNroFile.Text = "", "Ninguno", txtNroFile.Text), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content

            ' FOTO PRINCIPAL
            Try
                System.IO.Directory.CreateDirectory("c:\temp")
                Dim imagen As String = "C:\temp\" & lblNroInmueble.Text & ".jpg"
                pbImagenPrincipal.Image.Save(imagen, System.Drawing.Imaging.ImageFormat.Jpeg)
                wRng = oDocN.Content
                wRng.Document.Shapes.AddPicture(imagen, , , 100, 40, 250, 150)
                If File.Exists(imagen) Then
                    File.Delete(imagen)
                End If
            Catch ex As Exception

            End Try
            'DÁTOS BASICOS - IZQUIERDA
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FREGIST]", ReplaceWith:=IIf(dtpFechaRegistroMargesi.Text = Nothing Or dtpFechaRegistroMargesi.Text = "", "Ninguno", dtpFechaRegistroMargesi.Text), Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[TIPOUNIDA]", ReplaceWith:=IIf(cboTipoUnidad.Text = Nothing Or cboTipoUnidad.Text = "", "Ninguno", cboTipoUnidad.Text), Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[INMPRINCI]", ReplaceWith:=IIf(txtInmueblePrincipal.Text = Nothing Or txtInmueblePrincipal.Text = "", "Ninguno", txtInmueblePrincipal.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'DÁTOS BASICOS - DERECHA
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ESTADO]", ReplaceWith:=IIf(cboEstadoInmueble.Text = Nothing Or cboEstadoInmueble.Text = "", "Ninguno", cboEstadoInmueble.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[NROFILEANT]", ReplaceWith:=IIf(txtNroFileAntiguo.Text = Nothing Or txtNroFileAntiguo.Text = "", "Ninguno", txtNroFileAntiguo.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[CODINFORMATICO]", ReplaceWith:=IIf(lblNroInmueble.Text = Nothing Or lblNroInmueble.Text = "", "Ninguno", lblNroInmueble.Text), Replace:=Word.WdReplace.wdReplaceAll)

            'DENOMINACION 
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DENOMINACION]", ReplaceWith:=IIf(txtDenominacion.Text = Nothing Or txtDenominacion.Text = "", "Ninguno", txtDenominacion.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'UBICACIÓN 
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[UBICACIONDISTRITO]", ReplaceWith:=IIf(cboDistrito.Text = Nothing Or cboDistrito.Text = "", "Ninguno", cboDistrito.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[UBICACIONDIRECCION]", ReplaceWith:=IIf(txtdireccion.Text = Nothing Or txtdireccion.Text = "", "Ninguno", txtdireccion.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'FINCA INSCRITA 
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FINCAINSDISTRITO]", ReplaceWith:=IIf(cboDistritoIns.Text = Nothing Or cboDistritoIns.Text = "", "Ninguno", cboDistritoIns.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FINCAINSCRITA]", ReplaceWith:=IIf(txtFincaInscrita.Text = Nothing Or txtFincaInscrita.Text = "", "Ninguno", txtFincaInscrita.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'INFORMACIÓN LEGAL - Situación Legal.
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[CONDICIONLEGAL]", ReplaceWith:=IIf(cboCondicionLegal.Text = Nothing Or cboCondicionLegal.Text = "", "Ninguno", cboCondicionLegal.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[CONDICIONREGISTRAL]", ReplaceWith:=IIf(cboCondicionRegistral.Text = Nothing Or cboCondicionRegistral.Text = "", "Ninguno", cboCondicionRegistral.Text & " - " & cboCondicionRegistralSub.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[PARTELECTRONICA]", ReplaceWith:=IIf(txtPartElectronica.Text = Nothing Or txtPartElectronica.Text = "", "NO ASIGNADO", txtPartElectronica.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ASIENTO]", ReplaceWith:=IIf(txtAsiento.Text = Nothing Or txtAsiento.Text = "", "NO ASIGNADO", txtAsiento.Text), Replace:=Word.WdReplace.wdReplaceAll)
            ' wRng = oDocN.Content
            ' wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:=IIf(txtDocAcreditaInscripcion.Text = Nothing Or txtDocAcreditaInscripcion.Text = "", "NO ASIGNADO", txtDocAcreditaInscripcion.Text), Replace:=Word.WdReplace.wdReplaceOne)

            If txtDocAcreditaInscripcion.Text IsNot Nothing Then
                For Each s As String In txtDocAcreditaInscripcion.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:=IIf(s = Nothing Or s = "", "NO ASIGNADO", s & "[TITULOINSCRIPCION]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:=s1 & "[TITULOINSCRIPCION]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)

            'INFORMACIÓN LEGAL - Proceso de Saneamiento
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ESTADOLEGAL]", ReplaceWith:=IIf(cboEstadoSaneamiento.Text = Nothing Or cboEstadoSaneamiento.Text = "", "Ninguno", cboEstadoSaneamiento.Text), Replace:=Word.WdReplace.wdReplaceOne)
            If txtdocacreditadominio.Text IsNot Nothing Then
                For Each s As String In txtdocacreditadominio.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[DOCACREDITADOMINIO]", ReplaceWith:=IIf(s = Nothing Or s = "", "NO ASIGNADO", s & "[DOCACREDITADOMINIO]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[DOCACREDITADOMINIO]", ReplaceWith:=s1 & "[DOCACREDITADOMINIO]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DOCACREDITADOMINIO]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)

            'INSPECCION TECNICA

            Dim lotablatemp As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgSituacionFisica, cboSituacionFisica.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[USOACTUAL]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)
            End If

            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgSFInformacion, cboSFinformacion.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[ZONIFICACIONUSO]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)
            End If
            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgEstadoConservacion, cboEstadoConservacion.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[ESTADOCONCERVACION]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)
            End If

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[EDIFICACION]", ReplaceWith:=IIf(txtNroPisos.EditValue = Nothing Or txtNroPisos.EditValue = "", "Ninguno", txtNroPisos.EditValue), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[AREA]", ReplaceWith:=IIf(txtArea.Text = Nothing Or txtArea.Text = "", "Ninguno", txtArea.Text & " m2"), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[VALORPREDIO]", ReplaceWith:=IIf(txtvc_valortotal.Text = Nothing Or txtvc_valortotal.Text = "", "Ninguno", "S/. " & txtvc_valortotal.Text), Replace:=Word.WdReplace.wdReplaceOne)
            ' ARCHIVOS
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ESTADONIVIMPLEMENTACION]", ReplaceWith:=IIf(cboNivel.Text = Nothing Or cboNivel.Text = "", "Ninguno", cboNivel.Text), Replace:=Word.WdReplace.wdReplaceOne)
            'Dim cs As Int16 = 0
            Dim nc As String = String.Empty
            If txtSaneadoObserv.Text IsNot Nothing Then
                For Each s As String In txtSaneadoObserv.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[OBSERVACIONLEGAL]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguno", s & "[OBSERVACIONLEGAL]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[OBSERVACIONLEGAL]", ReplaceWith:=s1 & "[OBSERVACIONLEGAL]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next

                If txtSaneadoObserv.Text.Length < 581 Then
                    For i = CInt((txtSaneadoObserv.Text.Length / 83) + 0.5) To 7
                        nc = nc & vbCrLf
                    Next
                End If
            End If


            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[OBSERVACIONLEGAL]", ReplaceWith:="" & nc, Replace:=Word.WdReplace.wdReplaceAll)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:=vbLf, ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)

            If txtObservacionTecnica.Text IsNot Nothing Then
                For Each s As String In txtObservacionTecnica.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguno", s & "[OBSERVACIONTECNICA]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=s1 & "[OBSERVACIONTECNICA]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                        ' wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=s1 & "[OBSERVACIONTECNICA]", Replace:=Word.WdReplace.wdReplaceOne)
                    End Try
                Next
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceOne)

            ' DATOS DE BAJA
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DOCBAJA]", ReplaceWith:=txtBajaDoc.EditValue, Replace:=Word.WdReplace.wdReplaceOne)

            If dtpBajaFecha.EditValue IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[DOCFECHA]", ReplaceWith:=dtpBajaFecha.EditValue.ToShortDateString(), Replace:=Word.WdReplace.wdReplaceOne)

            End If

            If txtBajaDatoAdicional.Text IsNot Nothing Then
                For Each s As String In txtBajaDatoAdicional.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[DATOADICIONAL]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguno", s & "[DATOADICIONAL]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[DATOADICIONAL]", ReplaceWith:=s1 & "[DATOADICIONAL]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                        ' wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=s1 & "[OBSERVACIONTECNICA]", Replace:=Word.WdReplace.wdReplaceOne)
                    End Try
                Next
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DATOADICIONAL]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceOne)



            If txtBajaObservacion.Text IsNot Nothing Then
                For Each s As String In txtBajaObservacion.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[DOCBAJAOBSERVACION]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguna", s & "[DOCBAJAOBSERVACION]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[DOCBAJAOBSERVACION]", ReplaceWith:=s1 & "[DOCBAJAOBSERVACION]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                        ' wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=s1 & "[OBSERVACIONTECNICA]", Replace:=Word.WdReplace.wdReplaceOne)
                    End Try
                Next
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DOCBAJAOBSERVACION]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceOne)


            If dtpBajaFecDoc.EditValue IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[FECHABAJA]", ReplaceWith:=dtpBajaFecDoc.EditValue.ToShortDateString(), Replace:=Word.WdReplace.wdReplaceOne)

            End If

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[CAUSABAJA]", ReplaceWith:=txtBajaCausal.EditValue, Replace:=Word.WdReplace.wdReplaceOne)


            'DATOS DE IMPRESION
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FECHAEMISION]", ReplaceWith:=DateTime.Now().ToShortDateString(), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[USUARIO]", ReplaceWith:=IIf(EEComun.Usuario = Nothing Or EEComun.Usuario = "", "Ninguno", EEComun.Usuario), Replace:=Word.WdReplace.wdReplaceOne)

            Dim locargoPersonal As List(Of EECargoPersonal) = MantenimientosBL.Instancia.CargoListarXPerId_pa(EEComun._PerId)
            If locargoPersonal IsNot Nothing Then
                Dim area As String = locargoPersonal(0).Area
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[AREAUSUARIO]", ReplaceWith:=IIf(area = Nothing Or area = "", "Ninguno", area), Replace:=Word.WdReplace.wdReplaceOne)
            End If

            Dim lotablageneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(184)
            If lotablageneral IsNot Nothing Then
                For Each ftabla1 As EETablaGeneral In lotablageneral
                    For Each ftabla As DataRow In dtNivelImp.Rows
                        If ftabla("TgNivImpId") = ftabla1.TgCodigo Then
                            Dim v As String = CInt(ftabla("TgNivImpId"))
                            wRng = oDocN.Content
                            wRng.Find.Execute(FindText:="[f" & v & "]", ReplaceWith:=IIf(ftabla("InmNivFisico") = True, " x  ", "    "), Replace:=Word.WdReplace.wdReplaceOne)
                            wRng = oDocN.Content
                            wRng.Find.Execute(FindText:="[d" & v & "]", ReplaceWith:=IIf(ftabla("InmNivDigital") = True, " x  ", "    "), Replace:=Word.WdReplace.wdReplaceOne)
                            Exit For
                        End If
                    Next
                Next
            End If
            If fbdinmueble.ShowDialog = Windows.Forms.DialogResult.OK Then
                oWordN.ActiveDocument.SaveAs2(String.Format("{0}\File-{1}-{2}", fbdinmueble.SelectedPath, txtNroFile.Text, cboRubro.Text), 17)
                oWordN.ActiveDocument.Close(False)
                bsiMensaje.Caption = String.Format("El archivo se guardo correctamente en la ruta seleccionada con el nombre File-{0}-{1}", txtNroFile.Text, cboRubro.Text)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Sub imprimirInmAlta()
        Dim oWordN As Word.Application
        Dim oDocN As Word._Document = Nothing
        Try
            Application.DoEvents()
            oWordN = CreateObject("Word.Application")
            oDocN = oWordN.Documents.Open(EEComun.RutaReportes & "\FICHAPRINCIPALDELINMUEBLE_ALTA.doc", True, True)
            Dim wRng As Word.Range

            'CÓDIGO MARGESÍ MPT
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[RUBRO]", ReplaceWith:=IIf(cboRubro.Text = Nothing Or cboRubro.Text = "", "Ninguno", cboRubro.Text), Replace:=Word.WdReplace.wdReplaceAll)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[NROFILE]", ReplaceWith:=IIf(txtNroFile.Text = Nothing Or txtNroFile.Text = "", "Ninguno", txtNroFile.Text), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content

            ' FOTO PRINCIPAL
            Try
                System.IO.Directory.CreateDirectory("c:\temp")
                Dim imagen As String = "C:\temp\" & lblNroInmueble.Text & ".jpg"
                pbImagenPrincipal.Image.Save(imagen, System.Drawing.Imaging.ImageFormat.Jpeg)
                wRng = oDocN.Content
                wRng.Document.Shapes.AddPicture(imagen, , , 100, 40, 250, 150)
                If File.Exists(imagen) Then
                    File.Delete(imagen)
                End If
            Catch ex As Exception

            End Try
            'DÁTOS BASICOS - IZQUIERDA
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FREGIST]", ReplaceWith:=IIf(dtpFechaRegistroMargesi.Text = Nothing Or dtpFechaRegistroMargesi.Text = "", "Ninguno", dtpFechaRegistroMargesi.Text), Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[TIPOUNIDA]", ReplaceWith:=IIf(cboTipoUnidad.Text = Nothing Or cboTipoUnidad.Text = "", "Ninguno", cboTipoUnidad.Text), Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[INMPRINCI]", ReplaceWith:=IIf(txtInmueblePrincipal.Text = Nothing Or txtInmueblePrincipal.Text = "", "Ninguno", txtInmueblePrincipal.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'DÁTOS BASICOS - DERECHA
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ESTADO]", ReplaceWith:=IIf(cboEstadoInmueble.Text = Nothing Or cboEstadoInmueble.Text = "", "Ninguno", cboEstadoInmueble.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[NROFILEANT]", ReplaceWith:=IIf(txtNroFileAntiguo.Text = Nothing Or txtNroFileAntiguo.Text = "", "Ninguno", txtNroFileAntiguo.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[CODINFORMATICO]", ReplaceWith:=IIf(lblNroInmueble.Text = Nothing Or lblNroInmueble.Text = "", "Ninguno", lblNroInmueble.Text), Replace:=Word.WdReplace.wdReplaceAll)

            'DENOMINACION 
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DENOMINACION]", ReplaceWith:=IIf(txtDenominacion.Text = Nothing Or txtDenominacion.Text = "", "Ninguno", txtDenominacion.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'UBICACIÓN 
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[UBICACIONDISTRITO]", ReplaceWith:=IIf(cboDistrito.Text = Nothing Or cboDistrito.Text = "", "Ninguno", cboDistrito.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[UBICACIONDIRECCION]", ReplaceWith:=IIf(txtdireccion.Text = Nothing Or txtdireccion.Text = "", "Ninguno", txtdireccion.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'FINCA INSCRITA 
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FINCAINSDISTRITO]", ReplaceWith:=IIf(cboDistritoIns.Text = Nothing Or cboDistritoIns.Text = "", "Ninguno", cboDistritoIns.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FINCAINSCRITA]", ReplaceWith:=IIf(txtFincaInscrita.Text = Nothing Or txtFincaInscrita.Text = "", "Ninguno", txtFincaInscrita.Text), Replace:=Word.WdReplace.wdReplaceOne)

            'INFORMACIÓN LEGAL - Situación Legal.

            Dim lotablatemp As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgCondicionLegal, cboCondicionLegal.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[CONDICIONLEGAL]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)

            End If
            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgCondicionRegistral, cboCondicionRegistral.EditValue)
            If lotablatemp IsNot Nothing Then
                Dim CondicionRegistralSub, CondicionRegistral As String
                CondicionRegistral = lotablatemp.Item(0).TgNombre
                CondicionRegistralSub = String.Empty
                lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(175, cboCondicionRegistralSub.EditValue)
                If lotablatemp IsNot Nothing Then
                    CondicionRegistralSub = lotablatemp.Item(0).TgNombre
                End If
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[CONDICIONREGISTRAL]", ReplaceWith:=IIf(CondicionRegistral = Nothing Or CondicionRegistral = "", "Ninguno", CondicionRegistral & " - " & CondicionRegistralSub), Replace:=Word.WdReplace.wdReplaceOne)
            End If

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[PARTELECTRONICA]", ReplaceWith:=IIf(txtPartElectronica.Text = Nothing Or txtPartElectronica.Text = "", "NO ASIGNADO", txtPartElectronica.Text), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ASIENTO]", ReplaceWith:=IIf(txtAsiento.Text = Nothing Or txtAsiento.Text = "", "NO ASIGNADO", txtAsiento.Text), Replace:=Word.WdReplace.wdReplaceAll)
            ' wRng = oDocN.Content
            ' wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:=IIf(txtDocAcreditaInscripcion.Text = Nothing Or txtDocAcreditaInscripcion.Text = "", "NO ASIGNADO", txtDocAcreditaInscripcion.Text), Replace:=Word.WdReplace.wdReplaceOne)
            If txtDocAcreditaInscripcion.Text IsNot Nothing Then
                For Each s As String In txtDocAcreditaInscripcion.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:=IIf(s = Nothing Or s = "", "NO ASIGNADO", s & "[TITULOINSCRIPCION]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:=s1 & "[TITULOINSCRIPCION]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[TITULOINSCRIPCION]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)

            'INFORMACIÓN LEGAL - Proceso de Saneamiento
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ESTADOLEGAL]", ReplaceWith:=IIf(cboEstadoSaneamiento.Text = Nothing Or cboEstadoSaneamiento.Text = "", "Ninguno", cboEstadoSaneamiento.Text), Replace:=Word.WdReplace.wdReplaceOne)
            If txtdocacreditadominio.Text IsNot Nothing Then
                For Each s As String In txtdocacreditadominio.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[DOCACREDITADOMINIO]", ReplaceWith:=IIf(s = Nothing Or s = "", "NO ASIGNADO", s & "[DOCACREDITADOMINIO]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[DOCACREDITADOMINIO]", ReplaceWith:=s1 & "[DOCACREDITADOMINIO]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DOCACREDITADOMINIO]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)

            'INSPECCION TECNICA

            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgSituacionFisica, cboSituacionFisica.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[USOACTUAL]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)
            End If

            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgSFInformacion, cboSFinformacion.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[ZONIFICACIONUSO]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)
            End If
            lotablatemp = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(clsVariablesTablaGeneral.tblgEstadoConservacion, cboEstadoConservacion.EditValue)
            If lotablatemp IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[ESTADOCONCERVACION]", ReplaceWith:=IIf(lotablatemp.Item(0).TgNombre = Nothing Or lotablatemp.Item(0).TgNombre = "", "Ninguno", lotablatemp.Item(0).TgNombre), Replace:=Word.WdReplace.wdReplaceOne)
            End If

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[EDIFICACION]", ReplaceWith:=IIf(txtNroPisos.EditValue = Nothing Or txtNroPisos.EditValue = "", "Ninguno", txtNroPisos.EditValue), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[AREA]", ReplaceWith:=IIf(txtArea.Text = Nothing Or txtArea.Text = "", "Ninguno", txtArea.Text & " m2"), Replace:=Word.WdReplace.wdReplaceOne)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[VALORPREDIO]", ReplaceWith:=IIf(txtvc_valortotal.Text = Nothing Or txtvc_valortotal.Text = "", "Ninguno", "S/. " & txtvc_valortotal.Text), Replace:=Word.WdReplace.wdReplaceOne)
            ' ARCHIVOS
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[ESTADONIVIMPLEMENTACION]", ReplaceWith:=IIf(cboNivel.Text = Nothing Or cboNivel.Text = "", "Ninguno", cboNivel.Text), Replace:=Word.WdReplace.wdReplaceOne)
            'Dim cs As Int16 = 0
            If txtSaneadoObserv.Text IsNot Nothing Then
                For Each s As String In txtSaneadoObserv.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[OBSERVACIONLEGAL]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguno", s & "[OBSERVACIONLEGAL]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[OBSERVACIONLEGAL]", ReplaceWith:=s1 & "[OBSERVACIONLEGAL]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If
            Dim nc As String = String.Empty
            If txtSaneadoObserv.Text IsNot Nothing Then
                If txtSaneadoObserv.Text.Length < 581 Then
                    For i = CInt((txtSaneadoObserv.Text.Length / 83) + 0.5) To 7
                        nc = nc & vbCrLf
                    Next
                End If
            End If

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[OBSERVACIONLEGAL]", ReplaceWith:="" & nc, Replace:=Word.WdReplace.wdReplaceAll)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:=vbLf, ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceAll)

            If txtObservacionTecnica.Text IsNot Nothing Then
                For Each s As String In txtObservacionTecnica.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguno", s & "[OBSERVACIONTECNICA]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=s1 & "[OBSERVACIONTECNICA]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                        ' wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:=s1 & "[OBSERVACIONTECNICA]", Replace:=Word.WdReplace.wdReplaceOne)
                    End Try
                Next
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[OBSERVACIONTECNICA]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceOne)

            ' DATOS DE ALTA
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DOCALTA]", ReplaceWith:=txtAltaDoc.EditValue, Replace:=Word.WdReplace.wdReplaceOne)

            'wRng = oDocN.Content
            'wRng.Find.Execute(FindText:="[DOCBAJAOBSERVACION]", ReplaceWith:=txtALTAObservacion.EditValue, Replace:=Word.WdReplace.wdReplaceOne)


            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[DOCFECHA]", ReplaceWith:=dtpAltaFechaDoc.EditValue.ToShortDateString(), Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FECHAALTA]", ReplaceWith:=dtpFechaRegistroMargesi.EditValue.ToShortDateString(), Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[CAUSAALTA]", ReplaceWith:=txtAltaCausa.EditValue, Replace:=Word.WdReplace.wdReplaceOne)


            If txtAltaObservacion.Text IsNot Nothing Then
                For Each s As String In txtAltaObservacion.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[OBSERVACIONALTA]", ReplaceWith:=IIf(s = Nothing Or s = "", "", s & "[OBSERVACIONALTA]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[OBSERVACIONALTA]", ReplaceWith:=s1 & "[OBSERVACIONALTA]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[OBSERVACIONALTA]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceOne)

            'DATOS DE IMPRESION
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FECHAEMISION]", ReplaceWith:=DateTime.Now().ToShortDateString(), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[USUARIO]", ReplaceWith:=IIf(EEComun.Usuario = Nothing Or EEComun.Usuario = "", "Ninguno", EEComun.Usuario), Replace:=Word.WdReplace.wdReplaceOne)

            Dim locargoPersonal As List(Of EECargoPersonal) = MantenimientosBL.Instancia.CargoListarXPerId_pa(EEComun._PerId)
            If locargoPersonal IsNot Nothing Then
                Dim area As String = locargoPersonal(0).Area
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[AREAUSUARIO]", ReplaceWith:=IIf(area = Nothing Or area = "", "Ninguno", area), Replace:=Word.WdReplace.wdReplaceOne)
            End If

            Dim lotablageneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(184)
            If lotablageneral IsNot Nothing Then
                For Each ftabla1 As EETablaGeneral In lotablageneral
                    For Each ftabla As DataRow In dtNivelImp.Rows
                        If ftabla("TgNivImpId") = ftabla1.TgCodigo Then
                            Dim v As String = CInt(ftabla("TgNivImpId"))
                            wRng = oDocN.Content
                            wRng.Find.Execute(FindText:="[f" & v & "]", ReplaceWith:=IIf(ftabla("InmNivFisico") = True, " x  ", "    "), Replace:=Word.WdReplace.wdReplaceOne)
                            wRng = oDocN.Content
                            wRng.Find.Execute(FindText:="[d" & v & "]", ReplaceWith:=IIf(ftabla("InmNivDigital") = True, " x  ", "    "), Replace:=Word.WdReplace.wdReplaceOne)
                            Exit For
                        End If
                    Next
                Next
            End If
            If fbdinmueble.ShowDialog = Windows.Forms.DialogResult.OK Then
                oWordN.ActiveDocument.SaveAs2(String.Format("{0}\File-{1}-{2}", fbdinmueble.SelectedPath, txtNroFile.Text, cboRubro.Text), 17)
                oWordN.ActiveDocument.Close(False)
                bsiMensaje.Caption = String.Format("El archivo se guardo correctamente en la ruta seleccionada con el nombre File-{0}-{1}", txtNroFile.Text, cboRubro.Text)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub imprimir()
        If ImprimirTipo = Nothing Then
            ImprimirInmNormal()
        ElseIf ImprimirTipo.Contains("baja") = True Then
            imprimirInmBaja()
        ElseIf ImprimirTipo.Contains("alta") = True Then
            imprimirInmAlta()
        End If
    End Sub

    Protected Overrides Sub limpiar()
        Dim temp As String = lblNroInmueble.Text
        MyBase.limpiar()
        If GEstadoNuevo = False Then
            lblNroInmueble.Text = temp
        End If
    End Sub

    Private Sub mControlesDeshabilitados()
        txtInmueblePrincipal.Properties.ReadOnly = True
        txtBuscarArchivo.Properties.ReadOnly = True
        'txtValorTotal.Properties.ReadOnly = True
        cboTipoArchivos.Properties.ReadOnly = True
        txtvc_Perito.Properties.ReadOnly = True
        txtvc_cpc.Properties.ReadOnly = True
        txtvc_repev.Properties.ReadOnly = True
        mDeshabilitarSegunTipoUnidad()
    End Sub
#End Region

#Region "Load"
    Private Sub frmInmuebles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        ConstruirTableArchivos()
        ConstruirTableDivisiones()
        ConstruirTableDetalleContrato()
        ConstruirTableProgramacionPagos()
        ConstruirTableListado()
        ConstruirTableProcesoJudicial()
        ConstruirTableNivelImp()

        dgvArchivos.DataSource = dtArchivos
        dgvDivisiones.DataSource = dtDivisiones
        'dgvSuministros.DataSource = dtSuministros
        dgvContratos.DataSource = dtContrato
        dgvProgramacionPagos.DataSource = dtProgramacionPagos
        dgvProcesosJudiciales.DataSource = dtProcesoJudicial
        dgvNivelImp.DataSource = dtNivelImp

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
        cboRubroGrupos.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(32)
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

        cboEstadoSaneamiento.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoSaneamiento.Properties.DisplayMember = "TgNombre"
        cboEstadoSaneamiento.Properties.ValueMember = "TgCodigo"
        cboEstadoSaneamiento.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgEstadoSaneamiento)
        cboEstadoSaneamiento.ItemIndex = 0


        cboEstadoConservacion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoConservacion.Properties.DisplayMember = "TgNombre"
        cboEstadoConservacion.Properties.ValueMember = "TgCodigo"
        cboEstadoConservacion.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgEstadoConservacion)
        cboEstadoConservacion.ItemIndex = 0

        cboNivel.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboNivel.Properties.DisplayMember = "TgNombre"
        cboNivel.Properties.ValueMember = "TgCodigo"
        cboNivel.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgNiveInmpld)
        cboNivel.ItemIndex = 0
        '  AddHandler cboEstadoSaneamiento.EditValueChanged, AddressOf cboEstadoSaneamiento_EditValueChanged

        Dim ListaTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId2(30)
        Dim lsExtenciones As String = ""
        For Each fTablaGeneral As EETablaGeneral In ListaTablaGeneral
            lsExtenciones += fTablaGeneral.TgAbrev + ";"
        Next

        ofdExaminarArchivos.Filter = String.Format("Archivos({0})|{0}", lsExtenciones)
        ofdExaminarArchivos.Title = "Seleccionar Archivos"

        hleVerGaleriaArchivosInmuebles.Enabled = False
        Dim loNivelImp As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(184)
        If loNivelImp IsNot Nothing Then
            For Each frow As EETablaGeneral In loNivelImp
                dtNivelImp.LoadDataRow(New Object() {0, frow.TgCodigo, frow.TgNombre, False, False}, True)
            Next
        End If
        btnActualizarPJ.Enabled = False
        MostrarXInmId()
    End Sub
#End Region

    Sub LlenarDireccion()

        Dim distrito, localizacion, tipoNro, tipoNroSub, subdistritos, etapa, fase, barrio, sector, adicional, cadena As String

        distrito = IIf((cboDistrito.EditValue = "00" Or cboDistrito.EditValue = Nothing Or cboDistrito.EditValue = ""), "", "- " & cboDistrito.Text)
        localizacion = IIf((cboLocalizacion.EditValue = "00" Or cboLocalizacion.EditValue = Nothing Or cboLocalizacion.EditValue = ""), "", cboLocalizacion.Text)
        tipoNro = IIf((cboTipoNro.EditValue = "00" Or cboTipoNro.EditValue = Nothing Or cboTipoNro.EditValue = ""), "", "- " & cboTipoNro.Text)
        tipoNroSub = IIf((cboTipoSubNro.EditValue = "00" Or cboTipoSubNro.EditValue = Nothing Or cboTipoSubNro.EditValue = ""), "", "- " & cboTipoSubNro.Text)
        subdistritos = IIf((cboSubDistritos.EditValue = "00" Or cboSubDistritos.EditValue = Nothing Or cboSubDistritos.EditValue = ""), "", String.Format("- {0} {1}", cboSubDistritos.Text, IIf(txtsubdistritoscbo.Text <> "", txtsubdistritoscbo.Text, txtsubdistritoText.Text)))
        etapa = IIf(txtEtapa.Text <> "", "- Etapa " & txtEtapa.Text, "")
        fase = IIf(txtFase.Text <> "", "- Fase " & txtFase.Text, "")
        barrio = IIf(txtbarrio.Text <> "", "- Barrio " & txtbarrio.Text, "")
        sector = IIf(txtsector.Text <> "", "- Sector " & txtsector.Text, "")
        adicional = txtadicional.Text
        cadena = String.Format("{1} {2} {3} {4} {5} {6} {7} {9} {10} {11} {12} {13} {0}", distrito, _
                                                                                      localizacion, _
                                                                                      txtLocalizacion.EditValue, _
                                                                                      tipoNro, _
                                                                                      txtNroUbicacion.Text, _
                                                                                      tipoNroSub, _
                                                                                      txtSubNro.Text, _
                                                                                      subdistritos, _
                                                                                      txtsubdistritoText.Text,
                                                                                      etapa, _
                                                                                      fase, _
                                                                                      barrio, _
                                                                                      sector, _
                                                                                      adicional)
        cadena = cadena.Replace("    ", " ").Replace("   ", " ").Replace("  ", " ")
        cadena = LTrim(cadena)
        If cadena.Length > 0 Then

            txtdireccion.Text = IIf(cadena.Substring(0, 1) = "-", cadena.Substring(1), cadena)
        Else
            txtdireccion.Text = cadena
        End If

    End Sub

    Sub LlenarDireccionIns()
        Dim distrito, localizacion, tipoNro, tipoNroSub, subdistritos, etapa, fase, barrio, sector, cadena As String

        distrito = IIf((cboDistritoIns.EditValue = "00" Or cboDistritoIns.EditValue = Nothing Or cboDistritoIns.EditValue = ""), "", "- " & cboDistritoIns.Text)
        localizacion = IIf((cboLocalizacionIns.EditValue = "00" Or cboLocalizacionIns.EditValue = "" Or cboLocalizacionIns.EditValue = Nothing), "", cboLocalizacionIns.Text)
        tipoNro = IIf((cboTipoNroIns.EditValue = "00" Or cboTipoNroIns.EditValue = Nothing Or cboTipoNroIns.EditValue = ""), "", "- " & cboTipoNroIns.Text)
        tipoNroSub = IIf((cboTipoSubNroIns.EditValue = "00" Or cboTipoSubNroIns.EditValue = Nothing Or cboTipoSubNroIns.EditValue = ""), "", "- " & cboTipoSubNroIns.Text)
        subdistritos = IIf((cboSubDistritosIns.EditValue = "00" Or cboSubDistritosIns.EditValue = Nothing Or cboSubDistritosIns.EditValue = ""), "", String.Format(" - {0} {1}", cboSubDistritosIns.Text, IIf(txtsubdistritosInscbo.Text <> "", txtsubdistritosInscbo.Text, txtsubdistritoInsText.Text)))
        etapa = IIf(txtEtapaIns.Text <> "", "- Etapa " & txtEtapaIns.Text, "")
        fase = IIf(txtFaseIns.Text <> "", "- Fase " & txtFaseIns.Text, "")
        barrio = IIf(txtbarrioIns.Text <> "", "- Barrio " & txtbarrioIns.Text, "")
        sector = IIf(txtsectorIns.Text <> "", "- Sector " & txtsectorIns.Text, "")


        cadena = String.Format("{1} {2} {3} {4} {5} {6} {7} {9} {10} {11} {12} {0}", distrito, _
                                                                                      localizacion, _
                                                                                      txtLocalizacionIns.EditValue, _
                                                                                      tipoNro, _
                                                                                      txtNroUbicacionIns.Text, _
                                                                                      tipoNroSub, _
                                                                                      txtSubNroIns.Text, _
                                                                                      subdistritos, _
                                                                                      txtsubdistritosInscbo.Text,
                                                                                      etapa, _
                                                                                      fase, _
                                                                                      barrio, _
                                                                                      sector)
        cadena = cadena.Replace("    ", " ").Replace("   ", " ").Replace("  ", " ")
        cadena = LTrim(cadena)
        If cadena.Length > 0 Then
            txtFincaInscrita.Text = IIf(cadena.Substring(0, 1) = "-", cadena.Substring(1), cadena)
        Else
            txtFincaInscrita.Text = cadena
        End If

        If txtFincaInscrita.Text = "" Or txtFincaInscrita.Text Is Nothing Then

            txtFincaInscrita.Text = "Ninguna"

        End If
    End Sub

    Private Sub cboDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.EditValueChanged
        Dim lsUbgDep As String = cboDepartamento.EditValue
        cboProvincia.mColumnas(SaimtComboBoxLookUp.Entidades.Ubigeo)
        cboProvincia.Properties.DisplayMember = "UbgNombre"
        cboProvincia.Properties.ValueMember = "UbgProv"
        cboProvincia.Properties.DataSource = MantenimientosBL.Instancia.ubigeoListarProvinciaXUbgDep(lsUbgDep)
        cboProvincia.ItemIndex = 0
        LlenarDireccion()
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
        LlenarDireccion()
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

            If GEstadoNuevo = False Then
                Dim loInmArchivos As EEInmArchivos = New EEInmArchivos()
                loInmArchivos.InmArchNombre = txtNombreArchivo.Text
                loInmArchivos.InmArchDescripcion = txtDescripcionArchivo.Text
                loInmArchivos.TgTipoArchId = cboTipoArchivos.EditValue
                loInmArchivos.InmArch = loImageConver.FileToByteArray(txtBuscarArchivo.Text)
                loInmArchivos.InmArchExt = "." + lsArchSplit(lsArchSplit.Length - 1)
                loInmArchivos.InmArchPrincipal = chkArchPrincipal.Checked
                ListaTemporalArchivosNuevos.Add(loInmArchivos)
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

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        If Me.gvArchivos.DataRowCount <> 0 Then
            If GEstadoNuevo = False Then
                If Not String.IsNullOrEmpty(dtArchivos.Rows(Me.gvArchivos.GetSelectedRows(0))("inmArchId").ToString()) Then
                    ListaTemporalArchivosEliminados.Add(dtArchivos.Rows(Me.gvArchivos.GetSelectedRows(0))("inmArchId").ToString())
                End If
            End If

            If ListaTemporalArchivosNuevos.Count > 0 Then
                Dim liIndiceNuevoModificar As Int16 = 0
                Dim liFila As Int16 = -1

                For Each fTablaArchivos As DataRow In dtArchivos.Rows
                    If String.IsNullOrEmpty(fTablaArchivos("inmArchId")) And Me.gvArchivos.FocusedRowHandle = liFila Then
                        liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                    End If

                    liFila = liFila + 1
                Next

                ListaTemporalArchivosNuevos.RemoveAt(liIndiceNuevoModificar)
            End If

            dtArchivos.Rows.RemoveAt(Me.gvArchivos.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaError("No Hay Ninguna Fila Seleccionada")
        End If
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
            fmGaleriaInmueble.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub btnAgregarSuministro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    dtSuministros.LoadDataRow(New Object() { _
    '           0, _
    '           txtSumProveedor.Tag, _
    '           txtSumProveedor.Text, _
    '           cboSumTipoServicio.EditValue, _
    '           cboSumTipoServicio.Text, _
    '           txtSumNroMedidor.Text, _
    '           txtSumMonto.Text, _
    '           cboSumMes.EditValue, _
    '           cboSumMes.Text, _
    '           txtSumAño.Text, _
    '           dtpFechaVencimiento.EditValue
    '    }, True)
    'End Sub

    'Private Sub btnQuitarSuministro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.gvSuministros.DataRowCount <> 0 Then
    '        If GEstadoNuevo = False Then
    '            If Not String.IsNullOrEmpty(dtSuministros.Rows(Me.gvSuministros.GetSelectedRows(0))("inmSumId").ToString()) Then
    '                ListaTemporalSuministrosEliminados.Add(dtSuministros.Rows(Me.gvSuministros.GetSelectedRows(0))("inmSumId").ToString())
    '            End If
    '        End If

    '        If ListaTemporalSuministrosNuevos.Count > 0 Then
    '            Dim liIndiceNuevo As Int32 = 0
    '            Dim liIndiceNuevoRemove As Int32
    '            For Each fTablaSuministros As DataRow In dtSuministros.Rows
    '                If fTablaSuministros("inmSumId") <> Nothing Then
    '                    liIndiceNuevo = liIndiceNuevo + 1
    '                End If
    '            Next

    '            liIndiceNuevoRemove = liIndiceNuevo - Me.gvSuministros.GetSelectedRows(0)
    '            ListaTemporalSuministrosNuevos.RemoveAt(liIndiceNuevoRemove)
    '        End If

    '        dtSuministros.Rows.RemoveAt(Me.gvSuministros.GetSelectedRows(0))
    '    Else
    '        SaimtMessageBox.mostrarAlertaError("No Hay Ninguna Fila Seleccionada")
    '    End If
    'End Sub

    'Private Sub btnSumConsultarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim fmConsultaProveedor As frmConsultaProveedor = New frmConsultaProveedor()

    '    If fmConsultaProveedor.ShowDialog() = DialogResult.OK Then
    '        txtSumProveedor.Text = fmConsultaProveedor.PerProveedor
    '        txtSumProveedor.Tag = fmConsultaProveedor.PerId
    '    End If
    'End Sub

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

    Private Sub bvtArrendamientos_ItemPressed(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles bvtArrendamientos.ItemPressed
        mMostrarContratosXInmueble()
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


    Private Sub gvListadoInmuebles_CustomRowCellEditForEditing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs)
        seleccionarListado()
    End Sub

    Private Sub btnLimpiarPJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarPJ.Click
        GLimpiarControlesTotal(grbProcesoJudicial.Controls)
        btnAgregarPJ.Enabled = True
        btnActualizarPJ.Enabled = False
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

    Private liFilaSeleccionadaPJ As Int16 = -1
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
    End Sub

    Private Sub btnActualizarPJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarPJ.Click
        Try
            If liFilaSeleccionadaPJ <> -1 Then
                If txtDemandantePJ.Tag <> "0" Then
                    'Actualizar BD
                    Dim loInmPJudiciales As EEInmPJudiciales = New EEInmPJudiciales()
                    loInmPJudiciales.InmPJudId = txtDemandantePJ.Tag
                    loInmPJudiciales.InmPJudFechaInicio = dtpFechaInicioPJ.EditValue
                    loInmPJudiciales.InmPJudNroExp = txtNroExpedientePJ.Text
                    loInmPJudiciales.InmPJudJuzgado = txtJuzgadoPJ.Text
                    loInmPJudiciales.InmPJudMotivo = txtMotivoPJ.Text
                    loInmPJudiciales.InmPJudEtapaProc = txtEtapaPJ.Text
                    loInmPJudiciales.InmPJudDemandante = txtDemandantePJ.Text
                    loInmPJudiciales.InmPJudDemandado = txtDemandadoPJ.Text
                    loInmPJudiciales.OTgEstadoProceso = New EETablaGeneral()
                    loInmPJudiciales.OTgEstadoProceso.TgCodigo = cboEstadoPJ.EditValue
                    loInmPJudiciales.InmPJudLitisConsorte = txtLitisConsortePJ.Text
                    loInmPJudiciales.InmPJudSecretario = txtSecretarioJudicialPJ.Text
                    loInmPJudiciales.InmPJudObservacion = txtObservacioProcesoPJ.Text

                    MantenimientosBL.Instancia.inmuebleActualizarPJ(loInmPJudiciales)

                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudDemandante") = txtDemandantePJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudDemandado") = txtDemandadoPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudFechaInicio") = dtpFechaInicioPJ.EditValue
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudNroExp") = txtNroExpedientePJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudJuzgado") = txtJuzgadoPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudMotivo") = txtMotivoPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudEtapaProc") = txtEtapaPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("TgEstadoProcId") = cboEstadoPJ.EditValue
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("TgEstadoProceso") = cboEstadoPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudLitisConsorte") = txtLitisConsortePJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudSecretario") = txtSecretarioJudicialPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudObservacion") = txtObservacioProcesoPJ.Text

                    SaimtMessageBox.mostrarAlertaInformativa(String.Format("La Fila {0} Se Actualizo Correctamente.", liFilaSeleccionadaPJ))
                Else
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudDemandante") = txtDemandantePJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudDemandado") = txtDemandadoPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudFechaInicio") = dtpFechaInicioPJ.EditValue
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudNroExp") = txtNroExpedientePJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudJuzgado") = txtJuzgadoPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudMotivo") = txtMotivoPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudEtapaProc") = txtEtapaPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("TgEstadoProcId") = cboEstadoPJ.EditValue
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("TgEstadoProceso") = cboEstadoPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudLitisConsorte") = txtLitisConsortePJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudSecretario") = txtSecretarioJudicialPJ.Text
                    dtProcesoJudicial.Rows(liFilaSeleccionadaPJ)("InmPJudObservacion") = txtObservacioProcesoPJ.Text
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


    Private Sub chkDireccionIns_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDireccionIns.CheckedChanged
        If chkDireccionIns.Checked = True Then
            LlenarDireccionIns()
        End If
    End Sub

    Private Sub chkDireccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDireccion.CheckedChanged
        If chkDireccion.Checked = True Then
            LlenarDireccion()
        End If
    End Sub

    Private Sub txtcriterioNroFile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(13) Then
            Buscar()
        End If
    End Sub

    Private Sub cboSubDistritos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubDistritos.EditValueChanged
        If cboSubDistritos.EditValue IsNot Nothing Then
            txtsubdistritoscbo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            txtsubdistritoscbo.Properties.DisplayMember = "TgNombre"
            txtsubdistritoscbo.Properties.ValueMember = "TgCodigo"
            txtsubdistritoscbo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(171, Nothing, cboDistrito.EditValue, cboSubDistritos.EditValue)
            txtsubdistritoscbo.ItemIndex = 0
            txtsubdistritoscbo.Visible = True
            txtsubdistritoText.Visible = False
        Else
            txtsubdistritoscbo.Visible = False
            txtsubdistritoText.Visible = True
        End If
        If cboSubDistritos.EditValue = "04" Or cboSubDistritos.EditValue = "05" Then
            txtsubdistritoscbo.Visible = False
            txtsubdistritoText.Visible = True
        Else
            txtsubdistritoscbo.Visible = True
            txtsubdistritoText.Visible = False

        End If
    End Sub

    Private Sub cboSubDistritosIns_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubDistritosIns.EditValueChanged
        If cboSubDistritosIns.EditValue IsNot Nothing Then
            txtsubdistritosInscbo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            txtsubdistritosInscbo.Properties.DisplayMember = "TgNombre"
            txtsubdistritosInscbo.Properties.ValueMember = "TgCodigo"
            txtsubdistritosInscbo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(171, Nothing, cboDistritoIns.EditValue, cboSubDistritosIns.EditValue)
            txtsubdistritosInscbo.ItemIndex = 0
            txtsubdistritosInscbo.Visible = True
            txtsubdistritoInsText.Visible = False
        Else
            txtsubdistritosInscbo.Visible = False
            txtsubdistritoInsText.Visible = True
        End If

        If cboSubDistritosIns.EditValue = "04" Or cboSubDistritosIns.EditValue = "05" Then
            txtsubdistritosInscbo.Visible = False
            txtsubdistritoInsText.Visible = True
        Else
            txtsubdistritosInscbo.Visible = True
            txtsubdistritoInsText.Visible = False

        End If
    End Sub

    Private Sub cboCondicionRegistral_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCondicionRegistral.EditValueChanged
        If cboCondicionRegistral.EditValue IsNot Nothing Then
            cboCondicionRegistralSub.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboCondicionRegistralSub.Properties.DisplayMember = "TgNombre"
            cboCondicionRegistralSub.Properties.ValueMember = "TgCodigo"
            cboCondicionRegistralSub.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(175, cboCondicionRegistral.EditValue)
            cboCondicionRegistralSub.ItemIndex = 0
            If cboCondicionRegistral.EditValue = "02" Then
                txtPartElectronica.Properties.ReadOnly = True
                txtAsiento.Properties.ReadOnly = True
                txtPartElectronica.Text = "Ninguno"
                txtAsiento.Text = "Ninguno"
            Else
                txtPartElectronica.Properties.ReadOnly = False
                txtAsiento.Properties.ReadOnly = False
                If txtPartElectronica.Text = "Ninguno" Then
                    txtPartElectronica.Text = ""
                End If
                If txtAsiento.Text = "Ninguno" Then
                    txtAsiento.Text = ""
                End If
                ' txtPartElectronica.Text = ""
                ' txtAsiento.Text = ""
            End If
        End If


    End Sub

    Private Sub cboSFinformacion_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSFinformacion.EditValueChanged
        cboSfUso.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSfUso.Properties.DisplayMember = "TgNombre"
        cboSfUso.Properties.ValueMember = "TgCodigo"
        cboSfUso.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(clsVariablesTablaGeneral.tblgSFUso, , , cboSFinformacion.EditValue)
        cboSfUso.ItemIndex = 0
    End Sub

    Private Sub cboEstadoSaneamiento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstadoSaneamiento.EditValueChanged
        If cboEstadoSaneamiento.EditValue IsNot Nothing Then
            If cboEstadoSaneamiento.EditValue = "03" Then
                txtDocAcreditaInscripcion.Properties.ReadOnly = True
                txtDocAcreditaInscripcion.Text = "Ninguno"
            Else
                txtDocAcreditaInscripcion.Properties.ReadOnly = False
                'txtDocAcreditaInscripcion.Text = ""
            End If
        End If
    End Sub

    Private Sub cboSFinformacion_MouseCaptureChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSFinformacion.MouseCaptureChanged
        If cboSFinformacion.Properties.ReadOnly = True Then
            cboSFinformacion.ToolTipTitle = cboSFinformacion.Text
            'cboSFinformacion.ToolTipIconType = buttonToolti
        End If
    End Sub

    Private Sub btnTasacion_BuscarPerito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTasacion_BuscarPerito.Click
        Using fmConsultaPersona As frmConsultaPersonaGeneral = New frmConsultaPersonaGeneral(3)
            If fmConsultaPersona.ShowDialog() = DialogResult.OK Then
                txtvc_Perito.EditValue = fmConsultaPersona.PerNombre
                txtvc_Perito.Tag = fmConsultaPersona.PerId
                Dim loCPC As EEPersona.EEContacto = MantenimientosBL.Instancia.MostrarContactoPersonaXPerIdTgContactoId(txtvc_Perito.Tag, 15)
                If loCPC IsNot Nothing Then
                    txtvc_cpc.Text = loCPC.ContDescripcion
                End If
                Dim loREPEV As EEPersona.EEContacto = MantenimientosBL.Instancia.MostrarContactoPersonaXPerIdTgContactoId(txtvc_Perito.Tag, 16)
                If loREPEV IsNot Nothing Then
                    txtvc_repev.Text = loREPEV.ContDescripcion
                End If
            End If
        End Using
    End Sub

    Private Sub btnLimpiarPerito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarPerito.Click
        txtvc_cpc.Text = String.Empty
        txtvc_repev.Text = String.Empty
        txtvc_Perito.EditValue = String.Empty
        txtvc_Perito.Tag = String.Empty
    End Sub

  
End Class
