Public Class EEInmueble

    Public Property InmId() As String
    Public Property InmCodSinabip() As String
    Public Property TgTipoUnidadNombre() As String
    Public Property InmFile() As String
    Public Property InmFileAnt() As String
    Public Property InmInscrito() As String
    Public Property InmUbicacion() As String
    Public Property InmDenominacion() As String
    Public Property tgEstInmConsvId() As String
    Public Property tgEstInmConsv() As String
    Public Property InmDocAcredita() As String ' inscripcion
    Public Property InmDocAcreditaDominio() As String
    Public Property tgInmCondRegSubId() As String
    Public Property tgInmCondRegSub() As String
    Public Property tgInmCondRegId() As String
    Public Property tgInmCondReg() As String
    Public Property InmPartidaElec() As String
    Public Property InmAsiento() As String
    Public Property TgEstSanId() As String
    Public Property tgEstSan() As String
    Public Property inmSaneadoObsMostrable() As String
    Public Property InmSaneadoObs() As String
    Public Property InmDisponibilidad() As Boolean?
    Public Property TgInmCondLegalId() As String
    Public Property TgInmCondLegal() As String
    Public Property tgInmSitFisicaId() As String
    Public Property tgInmSitFisica() As String
    Public Property InmFecMarg() As DateTime?
    Public Property InmFecReg() As DateTime?
    Public Property InmActivo() As Boolean?
    Public Property TgTipoUnidadId() As String
    Public Property InmIdPadre() As String
    Public Property InmArchPrincipal As Byte()


    Public Property InmFilePadre() As String
    Public Property TgInmEstado() As String
    Public Property TgInmEstado2() As String
    Public Property TgInmEstadoNombre() As String
    Public Property InmNroPisos() As String
    Public Property TgRubroGrupoId() As String
    Public Property TgRubroGrupo() As String
    Public Property TgRubroId() As String
    Public Property TgRubro() As String
    Public Property InmObservacion() As String
    Public Property TgExtraId() As String
    Public Property InmEstContrato() As String
    Public Property tgInmSFZonificacionId As String ' Situacion Fisica Informacion
    Public Property tgInmSFZonificacion As String ' Situacion Fisica Informacion
    Public Property tgInmSFUsoId As String ' Situacion Fisica Uso
    Public Property tgInmSFUso As String ' Situacion Fisica Uso
    Public Property tgNivelId As String ' Nivel de Implementacion
    Public Property InmObsNivelImp As String ' Observacion Nivel de Inmplementacion
    Public Property UsuarioRegAlta As String
    Public Property perRegId As String
    Public Property inmDocRefArchivo As String

    Public Property tgTipoIngreso As String ' Si es Alta es 01 , 02 si es baja, 00
    'EEinmAltas
    Public Property inmDocAlta As String
    Public Property inmFecAlta As String
    Public Property inmCausalAlta As String
    Public Property inmAltaObservacion As String

    ' Variables Conjunto

    Public Property InmTipoActualizacion As String
    Public Property InmCausalAltaoBaja As String
    Public Property InmFechaAltaoBaja As String
    Public Property InmDocAltaoBaja As String
    Public Property InmObservacionAltaoBaja As String
    Public Property InmDatoAdicionalAltaoBaja() As String



    Public Class EEInmBajas
        Public Property InmBajaId() As String
        Public Property InmBajaNroDoc() As String
        Public Property InmBajaCausa() As String
        Public Property InmBajaFecha() As DateTime?
        Public Property InmBajaDocFecha() As DateTime?
        Public Property InmBajaDocArchivo() As String
        Public Property InmBajaObservacion() As String
        Public Property InmBajaDatoAdicional() As String
        Public Property InmBajaTemporal() As Boolean
        Public Property PerRegBajaId() As String
    End Class


    Public Class EEInmLogs
        Public Property InmId() As String
        Public Property Nro() As String
        Public Property InmCodigo() As String
        Public Property InmUbicacion() As String
        Public Property InmUpdId() As String
        Public Property InmUpdFechaReg() As String
        Public Property InmUpdPerId() As String

        Public Property InmUpdDetId() As String
        Public Property inmUpdDoc() As String
        Public Property inmUpdSupId() As String
        Public Property inmUpdSup() As String
        Public Property inmUpdObservacion() As String
        Public Property inmUpdMotivo() As String
        Public Property InmUpdFecDoc() As Date?
        Public Property InmUpdFecRegUpd() As DateTime?
        Public Property tgTipoUpdId() As String
        Public Property tgTipoUpd() As String
        Public Property InmUpdPerUpdId() As String
        Public Property inmUpdActualizado() As String




        Public Property ListaInmLogsDet As List(Of EEInmueble.EEInmLogs.EEInmLogsDet)
        Public Property ListaInmNivImp() As List(Of EEInmNivelImp) = New List(Of EEInmNivelImp)
        'Listados
        Public Property _usuLogin() As String
        Public Property _InmUpdDetCampo() As String
        Public Property _InmUpdDetCampoText() As String
        Public Property _InmUpdDetValorOld() As String
        Public Property _InmUpdDetValorNew() As String
        Public Property _InmUpdDetValorNew2() As String



        Public Property tgNivelId() As String
#Region "Archivos"
        Public Property ListaInmArchivosTemporalEliminados() As List(Of String)
        Public Property ListaInmArchivosTemporalNuevos() As List(Of EEInmArchivos)
        Public Property ListaInmArchivosEditados() As List(Of EEInmArchivos)

#End Region


        Public Class EEInmLogsDet
            Public Property InmId() As String
            Public Property InmUpdDetId() As String
            Public Property InmUpdDetCampo() As String
            Public Property InmUpdDetCampoText() As String
            Public Property InmUpdDetValorOld() As String
            Public Property InmUpdDetValorNew() As String
            Public Property InmUpdDetValorOld2() As String
            Public Property InmUpdDetValorNew2() As String
        End Class
    End Class


    Public Class EEVariablesRpt

        Public Property TotalBienesPropios As Integer
        Public Property TotalAltasBienesPropios As Integer
        Public Property TotalBajasBienesPropios As Integer
        Public Property TotalAreaBienesPropios As Decimal
        Public Property TotalAreaAltasBienesPropios As Decimal
        Public Property TotalAreaBajasBienesPropios As Decimal
        Public Property TotalAreaTechadaBienesPropios As Decimal
        Public Property TotalValorBienesPropios As Decimal
        Public Property TotalValorAltasBienesPropios As Decimal
        Public Property TotalValorBajasBienesPropios As Decimal

        Public Property CountBP_BienesPropios As Integer
        Public Property itemAreaBP_BienesPropio As Decimal
        Public Property itemAreaTechadaBP_BienesPropio As Decimal
        Public Property itemValorBP_BienesPropios As Decimal


        Public Property CountBP_Vias As Integer
        Public Property itemAreaBP_Vias As Decimal
        Public Property itemAreaTechadaBP_Vias As Decimal
        Public Property itemValorBP_Vias As Decimal


        Public Property TotalOtrosFines As Integer
        Public Property TotalAltasOtrosFines As Integer
        Public Property TotalBajasOtrosFines As Integer
        Public Property TotalAreaOtrosFines As Decimal
        Public Property TotalAreaAltasOtrosFines As Decimal
        Public Property TotalAreaBajasOtrosFines As Decimal
        Public Property TotalAreaTechadaOtrosFines As Decimal
        Public Property TotalValorOtrosFines As Decimal
        Public Property TotalValorAltasOtrosFines As Decimal
        Public Property TotalValorBajasOtrosFines As Decimal

        Public Property CountOF_OtrosFines As Integer
        Public Property itemAreaOF_OtrosFines As Decimal
        Public Property itemAreaTechadaOF_OtrosFines As Decimal
        Public Property itemValorOF_OtrosFines As Decimal



        Public Property TotalSerpar As Integer
        Public Property TotalAltasSerpar As Integer
        Public Property TotalBajasSerpar As Integer
        Public Property TotalAreaSerpar As Decimal
        Public Property TotalAreaAltasSerpar As Decimal
        Public Property TotalAreaBajasSerpar As Decimal
        Public Property TotalAreaTechadaSerpar As Decimal
        Public Property TotalValorSerpar As Decimal
        Public Property TotalValorAltasSerpar As Decimal
        Public Property TotalValorBajasSerpar As Decimal

        Public Property CountS_Serpar As Integer
        Public Property itemAreaS_Serpar As Decimal
        Public Property itemAreaTechadaS_Serpar As Decimal
        Public Property itemValorS_Serpar As Decimal



        Public Property TotalAreasVerdes As Integer
        Public Property TotalAltasAreasVerdes As Integer
        Public Property TotalBajasAreasVerdes As Integer
        Public Property TotalAreaAreasVerdes As Decimal
        Public Property TotalAreaAltasAreasVerdes As Decimal
        Public Property TotalAreaBajasAreasVerdes As Decimal
        Public Property TotalAreaTechadaAreasVerdes As Decimal
        Public Property TotalValorAreasVerdes As Decimal
        Public Property TotalValorAltasAreasVerdes As Decimal
        Public Property TotalValorBajasAreasVerdes As Decimal

        Public Property CountAV_Parques As Integer
        Public Property itemAreaAV_Parques As Decimal
        Public Property itemAreaTechadaAV_Parques As Decimal
        Public Property itemValorAV_Parques As Decimal

        Public Property CountAV_Plazuelas As Integer
        Public Property itemAreaAV_Plazuelas As Decimal
        Public Property itemAreaTechadaAV_Plazuelas As Decimal
        Public Property itemValorAV_Plazuelas As Decimal

        Public Property CountAV_Bermas As Integer
        Public Property itemAreaAV_Bermas As Decimal
        Public Property itemAreaTechadaAV_Bermas As Decimal
        Public Property itemValorAV_Bermas As Decimal

        Public Property CountAV_Viveros As Integer
        Public Property itemAreaAV_Viveros As Decimal
        Public Property itemAreaTechadaAV_Viveros As Decimal
        Public Property itemValorAV_Viveros As Decimal
    End Class


#Region "Listas Temporales"

#Region "Archivos"
    Public Property ListaInmArchivosTemporalEliminados() As List(Of String)
    Public Property ListaInmArchivosTemporalNuevos() As List(Of EEInmArchivos)
    Public Property ListaInmArchivosEditados() As List(Of EEInmArchivos)

#End Region

#Region "Suministros"
    Public Property ListaInmSuministrosTemporalEliminados() As List(Of String)
    Public Property ListaInmSuministrosTemporalNuevos() As List(Of EEInmSuministros)
#End Region

#End Region

#Region "Divisiones"
    Public Property InmArchDivision() As Byte()
    Public Property ListaDivisiones() As List(Of EEInmueble)
#End Region

#Region "Relaciones"
    Public Property OInmDireccion() As EEInmDireccion
    Public Property OInmDireccionIns() As EEInmDireccion
    Public Property OInmPredio() As EEInmPredio
    Public Property OInmArancel() As EEInmArancelario

    Public Property OInmVariablesRpt() As EEInmueble.EEVariablesRpt
    Public Property OInmBajas() As EEInmueble.EEInmBajas

    Public Property OInmValorComercial() As EEInmValorComercial
    Public Property ListaInmArchivos() As List(Of EEInmArchivos) = New List(Of EEInmArchivos)
    Public Property ListaInmSuministros() As List(Of EEInmSuministros) = New List(Of EEInmSuministros)
    Public Property ListaInmPJudiciales() As List(Of EEInmPJudiciales) = New List(Of EEInmPJudiciales)
    Public Property ListaInmNivImp() As List(Of EEInmNivelImp) = New List(Of EEInmNivelImp)





#End Region

#Region "Propiedades ReadOnly"
    Public ReadOnly Property DatosInmueble() As String
        Get
            If OInmDireccion IsNot Nothing Then
                Return InmFile & " - " & InmDenominacion & " - " & OInmDireccion.InmDirLocalizacion & " - " & OInmDireccion.InmDirNro & " - " & InmId
            End If
            Return InmFile & " - " & InmDenominacion & " - " & InmId
        End Get
    End Property
#End Region


End Class
