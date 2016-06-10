Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class InmuebleDAO

#Region "Inmueble"

#Region "Guardar"
    Public Shared Function guardar(ByVal aoInmueble As EEInmueble) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Inmueble_pa")

                    'Inmueble
                    db.AddOutParameter(cmd, "inmid", DbType.String, 6)
                    db.AddInParameter(cmd, "inmfile", DbType.String, aoInmueble.InmFile)
                    db.AddInParameter(cmd, "inmfileant", DbType.String, aoInmueble.InmFileAnt)
                    db.AddInParameter(cmd, "inminscrito", DbType.String, aoInmueble.InmInscrito)
                    db.AddInParameter(cmd, "InmCodSinabip", DbType.String, aoInmueble.InmCodSinabip)
                    db.AddInParameter(cmd, "inmdenominacion", DbType.String, aoInmueble.InmDenominacion)
                    db.AddInParameter(cmd, "tgestinmconsvid", DbType.String, aoInmueble.tgEstInmConsvId)
                    db.AddInParameter(cmd, "inmdocacredita", DbType.String, aoInmueble.InmDocAcredita)
                    db.AddInParameter(cmd, "InmDocAcreditaDominio", DbType.String, aoInmueble.InmDocAcreditaDominio)
                    db.AddInParameter(cmd, "inmpartidaelec", DbType.String, aoInmueble.InmPartidaElec)
                    db.AddInParameter(cmd, "inmasiento", DbType.String, aoInmueble.InmAsiento)
                    db.AddInParameter(cmd, "inmSaneadoObsMostrable", DbType.String, aoInmueble.inmSaneadoObsMostrable)
                    db.AddInParameter(cmd, "inmsaneadoobs", DbType.String, aoInmueble.InmSaneadoObs)
                    db.AddInParameter(cmd, "inmdisponibilidad", DbType.Boolean, aoInmueble.InmDisponibilidad)
                    db.AddInParameter(cmd, "inmfecmarg", DbType.DateTime, aoInmueble.InmFecMarg)
                    db.AddInParameter(cmd, "inmactivo", DbType.Boolean, aoInmueble.InmActivo)
                    db.AddInParameter(cmd, "tgtipounidadid", DbType.String, aoInmueble.TgTipoUnidadId)
                    db.AddInParameter(cmd, "inmidpadre", DbType.String, aoInmueble.InmIdPadre)
                    db.AddInParameter(cmd, "tginmestado", DbType.String, aoInmueble.TgInmEstado)
                    db.AddInParameter(cmd, "inmnropisos", DbType.String, aoInmueble.InmNroPisos)
                    db.AddInParameter(cmd, "tgrubroid", DbType.String, aoInmueble.TgRubroId)
                    db.AddInParameter(cmd, "inmobservacion", DbType.String, aoInmueble.InmObservacion)
                    db.AddInParameter(cmd, "inmUbicacion", DbType.String, aoInmueble.InmUbicacion)
                    db.AddInParameter(cmd, "tgestsanid", DbType.String, aoInmueble.TgEstSanId)
                    'db.AddInParameter(cmd, "tgInmCondRegId", DbType.String, aoInmueble.tgInmCondRegId)
                    ' Ultima Modificaciones
                    db.AddInParameter(cmd, "tgInmCondRegId", DbType.String, aoInmueble.tgInmCondRegId)
                    db.AddInParameter(cmd, "tgInmCondRegSubId", DbType.String, aoInmueble.tgInmCondRegSubId)
                    db.AddInParameter(cmd, "TgInmCondLegalId", DbType.String, aoInmueble.TgInmCondLegalId)
                    db.AddInParameter(cmd, "TgInmSitFisicaId", DbType.String, aoInmueble.tgInmSitFisicaId)
                    db.AddInParameter(cmd, "tgInmSFInformacionId", DbType.String, aoInmueble.tgInmSFZonificacionId)
                    db.AddInParameter(cmd, "tgInmSFUsoId", DbType.String, aoInmueble.tgInmSFUsoId)
                    db.AddInParameter(cmd, "tgNivelId", DbType.String, aoInmueble.tgNivelId)
                    db.AddInParameter(cmd, "InmObsNivelImp", DbType.String, aoInmueble.InmObsNivelImp)


                    db.ExecuteNonQuery(cmd, transaccion)

                    Dim lsInmIdOut As String = db.GetParameterValue(cmd, "inmid").ToString()

                    'Direccion
                    cmd = db.GetStoredProcCommand("Insertar_InmDireccion_pa")

                    db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                    db.AddInParameter(cmd, "inmdirlocalizacion", DbType.String, aoInmueble.OInmDireccion.InmDirLocalizacion)
                    db.AddInParameter(cmd, "tglocalizacionid", DbType.String, aoInmueble.OInmDireccion.TgLocalizacionId)
                    db.AddInParameter(cmd, "tgNroid", DbType.String, aoInmueble.OInmDireccion.TgNroId)
                    db.AddInParameter(cmd, "inmdirnro", DbType.String, aoInmueble.OInmDireccion.InmDirNro)
                    db.AddInParameter(cmd, "TgSubNroId", DbType.String, aoInmueble.OInmDireccion.TgSubNroId)
                    db.AddInParameter(cmd, "inmdirSubnro", DbType.String, aoInmueble.OInmDireccion.InmDirSubNro)
                    db.AddInParameter(cmd, "tgsubdistritosId", DbType.String, aoInmueble.OInmDireccion.TgSubDistritosId)
                    db.AddInParameter(cmd, "inmdirSubdistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                    db.AddInParameter(cmd, "inmdirfase", DbType.String, aoInmueble.OInmDireccion.InmDirFase)
                    db.AddInParameter(cmd, "inmdiretapa", DbType.String, aoInmueble.OInmDireccion.InmDirEtapa)
                    db.AddInParameter(cmd, "inmdirreferencia", DbType.String, aoInmueble.OInmDireccion.InmDirReferencia)
                    db.AddInParameter(cmd, "ubgDep", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgDep)
                    db.AddInParameter(cmd, "ubgProv", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgProv)
                    db.AddInParameter(cmd, "ubgDist", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgDist)
                    db.AddInParameter(cmd, "inmDirBarrio", DbType.String, aoInmueble.OInmDireccion.InmDirBarrio)
                    db.AddInParameter(cmd, "inmDirSector", DbType.String, aoInmueble.OInmDireccion.InmDirSector)
                    db.AddInParameter(cmd, "inmDirAdicional", DbType.String, aoInmueble.OInmDireccion.InmDirAdicional)
                    db.AddInParameter(cmd, "InmDirCheck", DbType.Boolean, aoInmueble.OInmDireccion.InmDirCheck)
                    db.ExecuteNonQuery(cmd, transaccion)

                    cmd = db.GetStoredProcCommand("Insertar_InmDireccionIns_pa")

                    db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                    db.AddInParameter(cmd, "inmdirInslocalizacion", DbType.String, aoInmueble.OInmDireccionIns.InmDirLocalizacion)
                    db.AddInParameter(cmd, "tglocalizacionId", DbType.String, aoInmueble.OInmDireccionIns.TgLocalizacionId)
                    db.AddInParameter(cmd, "tgNroid", DbType.String, aoInmueble.OInmDireccionIns.TgNroId)
                    db.AddInParameter(cmd, "inmdirInsnro", DbType.String, aoInmueble.OInmDireccionIns.InmDirNro)
                    db.AddInParameter(cmd, "TgSubNroId", DbType.String, aoInmueble.OInmDireccionIns.TgSubNroId)
                    db.AddInParameter(cmd, "inmdirInsSubnro", DbType.String, aoInmueble.OInmDireccionIns.InmDirSubNro)
                    db.AddInParameter(cmd, "tgsubdistritosId", DbType.String, aoInmueble.OInmDireccionIns.TgSubDistritosId)
                    db.AddInParameter(cmd, "inmdirInsSubdistritos", DbType.String, aoInmueble.OInmDireccionIns.InmDirSubDistritos)
                    db.AddInParameter(cmd, "inmdirInsfase", DbType.String, aoInmueble.OInmDireccionIns.InmDirFase)
                    db.AddInParameter(cmd, "inmdirInsetapa", DbType.String, aoInmueble.OInmDireccionIns.InmDirEtapa)
                    ' db.AddInParameter(cmd, "inmdirInsreferencia", DbType.String, aoInmueble.OInmDireccionIns.InmDirReferencia)
                    db.AddInParameter(cmd, "ubgDep", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgDep)
                    db.AddInParameter(cmd, "ubgProv", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgProv)
                    db.AddInParameter(cmd, "ubgDist", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgDist)
                    db.AddInParameter(cmd, "inmDirInsBarrio", DbType.String, aoInmueble.OInmDireccionIns.InmDirBarrio)
                    db.AddInParameter(cmd, "inmDirInsSector", DbType.String, aoInmueble.OInmDireccionIns.InmDirSector)
                    db.AddInParameter(cmd, "InmDirInsCheck", DbType.Boolean, aoInmueble.OInmDireccionIns.InmDirCheck)
                    db.AddInParameter(cmd, "InmDirInsAdicional", DbType.String, aoInmueble.OInmDireccionIns.InmDirAdicional)
                    db.ExecuteNonQuery(cmd, transaccion)


                    ''Predio
                    If aoInmueble.OInmPredio IsNot Nothing Then
                        cmd = db.GetStoredProcCommand("Insertar_InmPredio_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                        db.AddInParameter(cmd, "inmpredarea", DbType.Decimal, aoInmueble.OInmPredio.InmPredArea)
                        db.ExecuteNonQuery(cmd, transaccion)
                    End If
               

                    'Valor Alancelario
                    If aoInmueble.OInmArancel IsNot Nothing Then
                        cmd = db.GetStoredProcCommand("InsertarU_InmArancelario_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                        db.AddInParameter(cmd, "inmAraAnio", DbType.String, aoInmueble.OInmArancel.InmAraAnio)
                        db.AddInParameter(cmd, "inmAraValUnitario", DbType.Decimal, aoInmueble.OInmArancel.InmAraValUnitario)
                        db.AddInParameter(cmd, "inmAraTotTerreno", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotTerreno)
                        db.AddInParameter(cmd, "inmAraTotConstruccion", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotConstruccion)
                        db.AddInParameter(cmd, "inmAraTotAutovaluo", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotAutovaluo)
                        db.AddInParameter(cmd, "inmAraAreTerreno", DbType.Decimal, aoInmueble.OInmArancel.InmAraAreTerreno)
                        db.AddInParameter(cmd, "inmAraAreConstruida", DbType.Decimal, aoInmueble.OInmArancel.InmAraAreConstruida)
                        db.AddInParameter(cmd, "inmAraFuente", DbType.String, aoInmueble.OInmArancel.InmAraFuente)
                        db.AddInParameter(cmd, "inmAraCodPredio", DbType.String, aoInmueble.OInmArancel.InmAraCodPredio)
                        db.AddInParameter(cmd, "inmAraCodCatastral", DbType.String, aoInmueble.OInmArancel.InmAraCodCatastral)
                        db.ExecuteNonQuery(cmd, transaccion)
                    End If
          
                    If aoInmueble.OInmValorComercial IsNot Nothing Then
                        cmd = db.GetStoredProcCommand("InsertarU_InmValorComercial_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                        db.AddInParameter(cmd, "inmvalcomnrotas", DbType.String, aoInmueble.OInmValorComercial.InmValComNroTas)
                        db.AddInParameter(cmd, "inmvalcomareatechada", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComAreaTechada)
                        db.AddInParameter(cmd, "inmvalcomarea", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComArea)
                        db.AddInParameter(cmd, "inmvalcomvalxmetro", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValxMetro)
                        db.AddInParameter(cmd, "inmvalcomvalterreno", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValTerreno)
                        db.AddInParameter(cmd, "inmvalcomvalconst", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValConst)
                        db.AddInParameter(cmd, "inmvalcomvaltotal", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValTotal)
                        db.AddInParameter(cmd, "inmvalcomfechatas", DbType.DateTime, aoInmueble.OInmValorComercial.InmValComFechaTas)
                        db.AddInParameter(cmd, "inmvalcomfechatassug", DbType.DateTime, aoInmueble.OInmValorComercial.InmValComFechaTasSug)
                        db.AddInParameter(cmd, "inmvalcomperitoperid", DbType.String, aoInmueble.OInmValorComercial.InmValComPeritoPerId)
                        db.AddInParameter(cmd, "inmvalcomObservacion", DbType.String, aoInmueble.OInmValorComercial.InmValComObservacion)
                        db.ExecuteNonQuery(cmd, transaccion)
                    End If

                    'Archivos
                    For Each fArchivos As EEInmArchivos In aoInmueble.ListaInmArchivos
                        cmd = db.GetStoredProcCommand("Insertar_InmArchivos_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                        db.AddInParameter(cmd, "inmarchnombre", DbType.String, fArchivos.InmArchNombre)
                        db.AddInParameter(cmd, "inmarchdescripcion", DbType.String, fArchivos.InmArchDescripcion)
                        db.AddInParameter(cmd, "tgtipoarchid", DbType.String, fArchivos.TgTipoArchId)
                        db.AddInParameter(cmd, "inmarch", DbType.Binary, fArchivos.InmArch)
                        db.AddInParameter(cmd, "inmarchext", DbType.String, fArchivos.InmArchExt)
                        db.AddInParameter(cmd, "inmarchprincipal", DbType.Boolean, fArchivos.InmArchPrincipal)
                        db.AddInParameter(cmd, "inmarchActivo", DbType.Boolean, fArchivos.InmArchActivo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    'Nivel de Inmplementacion
                    For Each frow As EEInmNivelImp In aoInmueble.ListaInmNivImp
                        cmd = db.GetStoredProcCommand("Insertar_InmNivelImp_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                        db.AddInParameter(cmd, "tgnivimpid", DbType.String, frow.TgNivImpId)
                        db.AddInParameter(cmd, "inmnivfisico", DbType.Boolean, frow.InmNivfisico)
                        db.AddInParameter(cmd, "inmnivdigital", DbType.Boolean, frow.InmNivDigital)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    ''Suministros
                    'For Each fSuministros As EEInmSuministros In aoInmueble.ListaInmSuministros
                    '    cmd = db.GetStoredProcCommand("Insertar_InmSuministros_pa")
                    '    db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                    '    db.AddInParameter(cmd, "perid", DbType.String, fSuministros.OPersona.PerId)
                    '    db.AddInParameter(cmd, "tgtiposervid", DbType.String, fSuministros.TgTipoServicio.TgCodigo)
                    '    db.AddInParameter(cmd, "inmsumfechaven", DbType.DateTime, fSuministros.InmSumFechaVen)
                    '    db.AddInParameter(cmd, "tgtipomesid", DbType.String, fSuministros.TgTipoMes.TgCodigo)
                    '    db.AddInParameter(cmd, "inmsuma�o", DbType.Int32, fSuministros.InmSumA�o)
                    '    db.AddInParameter(cmd, "inmsummonto", DbType.Decimal, fSuministros.InmSumMonto)
                    '    db.AddInParameter(cmd, "inmsummedidor", DbType.String, fSuministros.InmSumMedidor)
                    '    db.ExecuteNonQuery(cmd, transaccion)
                    'Next

                    'Suministros


                    'Procesos Judiciales
                    For Each fProcesoJudicial As EEInmPJudiciales In aoInmueble.ListaInmPJudiciales
                        cmd = db.GetStoredProcCommand("Insertar_InmPJudiciales_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                        db.AddInParameter(cmd, "inmpjudfechainicio", DbType.DateTime, fProcesoJudicial.InmPJudFechaInicio)
                        db.AddInParameter(cmd, "inmpjudnroexp", DbType.String, fProcesoJudicial.InmPJudNroExp)
                        db.AddInParameter(cmd, "inmpjudjuzgado", DbType.String, fProcesoJudicial.InmPJudJuzgado)
                        db.AddInParameter(cmd, "inmpjudmotivo", DbType.String, fProcesoJudicial.InmPJudMotivo)
                        db.AddInParameter(cmd, "inmpjudetapaproc", DbType.String, fProcesoJudicial.InmPJudEtapaProc)
                        db.AddInParameter(cmd, "inmpjuddemandante", DbType.String, fProcesoJudicial.InmPJudDemandante)
                        db.AddInParameter(cmd, "inmpjuddemandado", DbType.String, fProcesoJudicial.InmPJudDemandado)
                        db.AddInParameter(cmd, "tgestadoprocid", DbType.String, fProcesoJudicial.OTgEstadoProceso.TgCodigo)
                        db.AddInParameter(cmd, "inmpjudlitisconsorte", DbType.String, fProcesoJudicial.InmPJudLitisConsorte)
                        db.AddInParameter(cmd, "inmpjudsecretario", DbType.String, fProcesoJudicial.InmPJudSecretario)
                        db.AddInParameter(cmd, "inmpjudobservacion", DbType.String, fProcesoJudicial.InmPJudObservacion)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar Inmueble => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function guardarAlta(ByVal aoInmueble As EEInmueble) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_InmuebleAlta_pa")

                    'Inmueble

                    db.AddOutParameter(cmd, "inmid", DbType.String, 6)
                    db.AddInParameter(cmd, "InmCodSinabip", DbType.String, aoInmueble.InmCodSinabip)

                    db.AddInParameter(cmd, "tgTipoIngreso", DbType.String, aoInmueble.tgTipoIngreso)
                    db.AddInParameter(cmd, "perRegId", DbType.String, aoInmueble.perRegId)
                    db.AddInParameter(cmd, "inmDocAlta", DbType.String, aoInmueble.inmDocAlta)
                    db.AddInParameter(cmd, "inmFecAlta", DbType.Date, aoInmueble.inmFecAlta)
                    db.AddInParameter(cmd, "inmCausalAlta", DbType.String, aoInmueble.inmCausalAlta)
                    db.AddInParameter(cmd, "inmAltaObservacion", DbType.String, aoInmueble.inmAltaObservacion)

                    db.AddInParameter(cmd, "inmfile", DbType.String, aoInmueble.InmFile)
                    db.AddInParameter(cmd, "inmfileant", DbType.String, aoInmueble.InmFileAnt)
                    db.AddInParameter(cmd, "inminscrito", DbType.String, aoInmueble.InmInscrito)

                    'db.AddInParameter(cmd, "inmUbicacion", DbType.String, aoInmueble.InmUbicacion)
                    db.AddInParameter(cmd, "inmdenominacion", DbType.String, aoInmueble.InmDenominacion)
                    db.AddInParameter(cmd, "tgestinmconsvid", DbType.String, aoInmueble.tgEstInmConsvId)
                    db.AddInParameter(cmd, "inmdocacredita", DbType.String, aoInmueble.InmDocAcredita)
                    db.AddInParameter(cmd, "InmDocAcreditaDominio", DbType.String, aoInmueble.InmDocAcreditaDominio)
                    db.AddInParameter(cmd, "inmpartidaelec", DbType.String, aoInmueble.InmPartidaElec)
                    db.AddInParameter(cmd, "inmasiento", DbType.String, aoInmueble.InmAsiento)
                    db.AddInParameter(cmd, "inmsaneadoobs", DbType.String, aoInmueble.InmSaneadoObs)
                    db.AddInParameter(cmd, "inmSaneadoObsMostrable", DbType.String, aoInmueble.inmSaneadoObsMostrable)
                    db.AddInParameter(cmd, "inmdisponibilidad", DbType.Boolean, aoInmueble.InmDisponibilidad)
                    db.AddInParameter(cmd, "inmfecmarg", DbType.DateTime, aoInmueble.InmFecMarg)
                    db.AddInParameter(cmd, "inmactivo", DbType.Boolean, aoInmueble.InmActivo)
                    db.AddInParameter(cmd, "tgtipounidadid", DbType.String, aoInmueble.TgTipoUnidadId)
                    db.AddInParameter(cmd, "inmidpadre", DbType.String, aoInmueble.InmIdPadre)
                    db.AddInParameter(cmd, "tginmestado", DbType.String, aoInmueble.TgInmEstado)
                    db.AddInParameter(cmd, "inmnropisos", DbType.String, aoInmueble.InmNroPisos)
                    db.AddInParameter(cmd, "tgrubroid", DbType.String, aoInmueble.TgRubroId)
                    db.AddInParameter(cmd, "inmobservacion", DbType.String, aoInmueble.InmObservacion)
                    db.AddInParameter(cmd, "inmUbicacion", DbType.String, aoInmueble.InmUbicacion)
                    db.AddInParameter(cmd, "tgestsanid", DbType.String, aoInmueble.TgEstSanId)
                    'db.AddInParameter(cmd, "tgInmCondRegId", DbType.String, aoInmueble.tgInmCondRegId)
                    ' Ultima Modificaciones
                    db.AddInParameter(cmd, "tgInmCondRegId", DbType.String, aoInmueble.tgInmCondRegId)
                    db.AddInParameter(cmd, "tgInmCondRegSubId", DbType.String, aoInmueble.tgInmCondRegSubId)
                    db.AddInParameter(cmd, "TgInmCondLegalId", DbType.String, aoInmueble.TgInmCondLegalId)
                    db.AddInParameter(cmd, "TgInmSitFisicaId", DbType.String, aoInmueble.tgInmSitFisicaId)
                    db.AddInParameter(cmd, "tgInmSFInformacionId", DbType.String, aoInmueble.tgInmSFZonificacionId)
                    db.AddInParameter(cmd, "tgInmSFUsoId", DbType.String, aoInmueble.tgInmSFUsoId)
                    db.AddInParameter(cmd, "tgNivelId", DbType.String, aoInmueble.tgNivelId)
                    db.AddInParameter(cmd, "InmObsNivelImp", DbType.String, aoInmueble.InmObsNivelImp)


                    db.ExecuteNonQuery(cmd, transaccion)

                    Dim lsInmIdOut As String = db.GetParameterValue(cmd, "inmid").ToString()

                    'Direccion
                    cmd = db.GetStoredProcCommand("Insertar_InmDireccion_pa")

                    db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                    db.AddInParameter(cmd, "inmdirlocalizacion", DbType.String, aoInmueble.OInmDireccion.InmDirLocalizacion)
                    db.AddInParameter(cmd, "tglocalizacionid", DbType.String, aoInmueble.OInmDireccion.TgLocalizacionId)
                    db.AddInParameter(cmd, "tgNroid", DbType.String, aoInmueble.OInmDireccion.TgNroId)
                    db.AddInParameter(cmd, "inmdirnro", DbType.String, aoInmueble.OInmDireccion.InmDirNro)
                    db.AddInParameter(cmd, "TgSubNroId", DbType.String, aoInmueble.OInmDireccion.TgSubNroId)
                    db.AddInParameter(cmd, "inmdirSubnro", DbType.String, aoInmueble.OInmDireccion.InmDirSubNro)
                    db.AddInParameter(cmd, "tgsubdistritosId", DbType.String, aoInmueble.OInmDireccion.TgSubDistritosId)
                    db.AddInParameter(cmd, "inmdirSubdistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                    db.AddInParameter(cmd, "inmdirfase", DbType.String, aoInmueble.OInmDireccion.InmDirFase)
                    db.AddInParameter(cmd, "inmdiretapa", DbType.String, aoInmueble.OInmDireccion.InmDirEtapa)
                    db.AddInParameter(cmd, "inmdirreferencia", DbType.String, aoInmueble.OInmDireccion.InmDirReferencia)
                    db.AddInParameter(cmd, "ubgDep", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgDep)
                    db.AddInParameter(cmd, "ubgProv", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgProv)
                    db.AddInParameter(cmd, "ubgDist", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgDist)
                    db.AddInParameter(cmd, "inmDirBarrio", DbType.String, aoInmueble.OInmDireccion.InmDirBarrio)
                    db.AddInParameter(cmd, "inmDirSector", DbType.String, aoInmueble.OInmDireccion.InmDirSector)
                    db.AddInParameter(cmd, "inmDirAdicional", DbType.String, aoInmueble.OInmDireccion.InmDirAdicional)
                    db.AddInParameter(cmd, "InmDirCheck", DbType.Boolean, aoInmueble.OInmDireccion.InmDirCheck)
                    db.ExecuteNonQuery(cmd, transaccion)

                    cmd = db.GetStoredProcCommand("Insertar_InmDireccionIns_pa")

                    db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                    db.AddInParameter(cmd, "inmdirInslocalizacion", DbType.String, aoInmueble.OInmDireccionIns.InmDirLocalizacion)
                    db.AddInParameter(cmd, "tglocalizacionId", DbType.String, aoInmueble.OInmDireccionIns.TgLocalizacionId)
                    db.AddInParameter(cmd, "tgNroid", DbType.String, aoInmueble.OInmDireccionIns.TgNroId)
                    db.AddInParameter(cmd, "inmdirInsnro", DbType.String, aoInmueble.OInmDireccionIns.InmDirNro)
                    db.AddInParameter(cmd, "TgSubNroId", DbType.String, aoInmueble.OInmDireccionIns.TgSubNroId)
                    db.AddInParameter(cmd, "inmdirInsSubnro", DbType.String, aoInmueble.OInmDireccionIns.InmDirSubNro)
                    db.AddInParameter(cmd, "tgsubdistritosId", DbType.String, aoInmueble.OInmDireccionIns.TgSubDistritosId)
                    db.AddInParameter(cmd, "inmdirInsSubdistritos", DbType.String, aoInmueble.OInmDireccionIns.InmDirSubDistritos)
                    db.AddInParameter(cmd, "inmdirInsfase", DbType.String, aoInmueble.OInmDireccionIns.InmDirFase)
                    db.AddInParameter(cmd, "inmdirInsetapa", DbType.String, aoInmueble.OInmDireccionIns.InmDirEtapa)
                    ' db.AddInParameter(cmd, "inmdirInsreferencia", DbType.String, aoInmueble.OInmDireccionIns.InmDirReferencia)
                    db.AddInParameter(cmd, "ubgDep", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgDep)
                    db.AddInParameter(cmd, "ubgProv", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgProv)
                    db.AddInParameter(cmd, "ubgDist", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgDist)
                    db.AddInParameter(cmd, "inmDirInsBarrio", DbType.String, aoInmueble.OInmDireccionIns.InmDirBarrio)
                    db.AddInParameter(cmd, "inmDirInsSector", DbType.String, aoInmueble.OInmDireccionIns.InmDirSector)
                    db.AddInParameter(cmd, "InmDirInsCheck", DbType.Boolean, aoInmueble.OInmDireccionIns.InmDirCheck)
                    db.AddInParameter(cmd, "InmDirInsAdicional", DbType.String, aoInmueble.OInmDireccionIns.InmDirAdicional)
                    db.ExecuteNonQuery(cmd, transaccion)


                    ''Predio


                    cmd = db.GetStoredProcCommand("Insertar_InmPredio_pa")

                    db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                    'db.AddInParameter(cmd, "inmpredfectas", DbType.DateTime, aoInmueble.OInmPredio.InmPredFecTas)
                    db.AddInParameter(cmd, "inmpredarea", DbType.Decimal, aoInmueble.OInmPredio.InmPredArea)
                    'db.AddInParameter(cmd, "inmpredarancel", DbType.Decimal, aoInmueble.OInmPredio.InmPredArancel)
                    'db.AddInParameter(cmd, "inmpredvalorterreno", DbType.Decimal, aoInmueble.OInmPredio.InmPredValorTerreno)
                    'db.AddInParameter(cmd, "inmpredareatechada", DbType.Decimal, aoInmueble.OInmPredio.InmPredAreaTechada)
                    'db.AddInParameter(cmd, "inmpredvalorconst", DbType.Decimal, aoInmueble.OInmPredio.InmPredValorConst)
                    'db.AddInParameter(cmd, "inmpredvaloredificacion", DbType.Decimal, aoInmueble.OInmPredio.InmPredValorEdificacion)
                    'db.AddInParameter(cmd, "inmpredvalortotal", DbType.Decimal, aoInmueble.OInmPredio.InmPredValorTotal)
                    'db.AddInParameter(cmd, "inmpredactivo", DbType.Boolean, aoInmueble.OInmPredio.InmPredActivo)
                    db.ExecuteNonQuery(cmd, transaccion)

                    'Valor Alancelario
                    cmd = db.GetStoredProcCommand("InsertarU_InmArancelario_pa")
                    db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                    db.AddInParameter(cmd, "inmAraAnio", DbType.String, aoInmueble.OInmArancel.InmAraAnio)
                    db.AddInParameter(cmd, "inmAraValUnitario", DbType.Decimal, aoInmueble.OInmArancel.InmAraValUnitario)
                    db.AddInParameter(cmd, "inmAraTotTerreno", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotTerreno)
                    db.AddInParameter(cmd, "inmAraTotConstruccion", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotConstruccion)
                    db.AddInParameter(cmd, "inmAraTotAutovaluo", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotAutovaluo)
                    db.AddInParameter(cmd, "inmAraAreTerreno", DbType.Decimal, aoInmueble.OInmArancel.InmAraAreTerreno)
                    db.AddInParameter(cmd, "inmAraAreConstruida", DbType.Decimal, aoInmueble.OInmArancel.InmAraAreConstruida)
                    db.AddInParameter(cmd, "inmAraFuente", DbType.String, aoInmueble.OInmArancel.InmAraFuente)
                    db.AddInParameter(cmd, "inmAraCodPredio", DbType.String, aoInmueble.OInmArancel.InmAraCodPredio)
                    db.AddInParameter(cmd, "inmAraCodCatastral", DbType.String, aoInmueble.OInmArancel.InmAraCodCatastral)
                    db.ExecuteNonQuery(cmd, transaccion)


                    'Valor Comercial
                    cmd = db.GetStoredProcCommand("InsertarU_InmValorComercial_pa")
                    db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                    db.AddInParameter(cmd, "inmvalcomnrotas", DbType.String, aoInmueble.OInmValorComercial.InmValComNroTas)
                    db.AddInParameter(cmd, "inmvalcomareatechada", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComAreaTechada)
                    db.AddInParameter(cmd, "inmvalcomarea", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComArea)
                    db.AddInParameter(cmd, "inmvalcomvalxmetro", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValxMetro)
                    db.AddInParameter(cmd, "inmvalcomvalterreno", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValTerreno)
                    db.AddInParameter(cmd, "inmvalcomvalconst", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValConst)
                    db.AddInParameter(cmd, "inmvalcomvaltotal", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValTotal)
                    db.AddInParameter(cmd, "inmvalcomfechatas", DbType.DateTime, aoInmueble.OInmValorComercial.InmValComFechaTas)
                    db.AddInParameter(cmd, "inmvalcomfechatassug", DbType.DateTime, aoInmueble.OInmValorComercial.InmValComFechaTasSug)
                    db.AddInParameter(cmd, "inmvalcomperitoperid", DbType.String, aoInmueble.OInmValorComercial.InmValComPeritoPerId)
                    db.AddInParameter(cmd, "inmvalcomObservacion", DbType.String, aoInmueble.OInmValorComercial.InmValComObservacion)
                    db.ExecuteNonQuery(cmd, transaccion)
                    'Archivos
                    For Each fArchivos As EEInmArchivos In aoInmueble.ListaInmArchivos
                        cmd = db.GetStoredProcCommand("Insertar_InmArchivos_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                        db.AddInParameter(cmd, "inmarchnombre", DbType.String, fArchivos.InmArchNombre)
                        db.AddInParameter(cmd, "inmarchdescripcion", DbType.String, fArchivos.InmArchDescripcion)
                        db.AddInParameter(cmd, "tgtipoarchid", DbType.String, fArchivos.TgTipoArchId)
                        db.AddInParameter(cmd, "inmarch", DbType.Binary, fArchivos.InmArch)
                        db.AddInParameter(cmd, "inmarchext", DbType.String, fArchivos.InmArchExt)
                        db.AddInParameter(cmd, "inmarchprincipal", DbType.Boolean, fArchivos.InmArchPrincipal)
                        db.AddInParameter(cmd, "inmarchActivo", DbType.Boolean, fArchivos.InmArchActivo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    'Nivel de Inmplementacion
                    For Each frow As EEInmNivelImp In aoInmueble.ListaInmNivImp
                        cmd = db.GetStoredProcCommand("Insertar_InmNivelImp_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, lsInmIdOut)
                        db.AddInParameter(cmd, "tgnivimpid", DbType.String, frow.TgNivImpId)
                        db.AddInParameter(cmd, "inmnivfisico", DbType.Boolean, frow.InmNivfisico)
                        db.AddInParameter(cmd, "inmnivdigital", DbType.Boolean, frow.InmNivDigital)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

           
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar Inmueble => " + ex.Message, ex)
        End Try
        Return True
    End Function

    'Public Shared Function guardarBaja(ByVal aoInmueble As EEInmueble) As Boolean
    '    Dim transaccion As DbTransaction = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '        Using conexion As DbConnection = db.CreateConnection()
    '            Try
    '                conexion.Open()
    '                transaccion = conexion.BeginTransaction()
    '                Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_InmuebleBaja_pa")
    '                db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
    '                db.AddInParameter(cmd, "tgTipoIngreso", DbType.String, aoInmueble.tgTipoIngreso)
    '                db.AddInParameter(cmd, "perRegBajaId", DbType.String, aoInmueble.perRegBajaId)
    '                db.AddInParameter(cmd, "inmDocBaja", DbType.String, aoInmueble.inmDocBaja)
    '                db.AddInParameter(cmd, "inmFecBaja", DbType.Date, aoInmueble.inmFecBaja)
    '                db.AddInParameter(cmd, "inmFecDocBaja", DbType.Date, aoInmueble.inmFecDocBaja)
    '                db.AddInParameter(cmd, "inmCausalBaja", DbType.String, aoInmueble.inmCausalBaja)
    '                db.AddInParameter(cmd, "tginmestado", DbType.String, aoInmueble.TgInmEstado)
    '                db.AddInParameter(cmd, "inmDocRefArchivo", DbType.String, aoInmueble.inmDocRefArchivo)
    '                db.ExecuteNonQuery(cmd, transaccion)
    '                transaccion.Commit()
    '            Catch ex As Exception
    '                transaccion.Rollback()
    '                Throw New Exception(ex.Message, ex)
    '            End Try
    '        End Using
    '    Catch ex As Exception
    '        Throw New Exception("Guardar Inmueble Baja => " + ex.Message, ex)
    '    End Try
    '    Return True
    'End Function
#End Region

#Region "Actualizar"
    Public Shared Function actualizar(ByVal aoInmueble As EEInmueble) As Boolean
        Dim transaccion As DbTransaction = Nothing

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Inmueble_pa")

                    'Inmueble
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "InmCodSinabip", DbType.String, aoInmueble.InmCodSinabip)

                    db.AddInParameter(cmd, "inmfile", DbType.String, aoInmueble.InmFile)
                    db.AddInParameter(cmd, "inmfileant", DbType.String, aoInmueble.InmFileAnt)
                    db.AddInParameter(cmd, "inminscrito", DbType.String, aoInmueble.InmInscrito)
                    db.AddInParameter(cmd, "inmUbicacion", DbType.String, aoInmueble.InmUbicacion)
                    db.AddInParameter(cmd, "inmdenominacion", DbType.String, aoInmueble.InmDenominacion)
                    db.AddInParameter(cmd, "tgestinmconsvid", DbType.String, aoInmueble.tgEstInmConsvId)
                    db.AddInParameter(cmd, "inmdocacredita", DbType.String, aoInmueble.InmDocAcredita)
                    db.AddInParameter(cmd, "InmDocAcreditaDominio", DbType.String, aoInmueble.InmDocAcreditaDominio)
                    db.AddInParameter(cmd, "inmpartidaelec", DbType.String, aoInmueble.InmPartidaElec)
                    db.AddInParameter(cmd, "inmasiento", DbType.String, aoInmueble.InmAsiento)
                    db.AddInParameter(cmd, "inmsaneadoobs", DbType.String, aoInmueble.InmSaneadoObs)
                    db.AddInParameter(cmd, "inmSaneadoObsMostrable", DbType.String, aoInmueble.inmSaneadoObsMostrable)
                    db.AddInParameter(cmd, "inmdisponibilidad", DbType.Boolean, aoInmueble.InmDisponibilidad)
                    db.AddInParameter(cmd, "inmfecmarg", DbType.DateTime, aoInmueble.InmFecMarg)
                    db.AddInParameter(cmd, "inmactivo", DbType.Boolean, aoInmueble.InmActivo)
                    db.AddInParameter(cmd, "tgtipounidadid", DbType.String, aoInmueble.TgTipoUnidadId)
                    db.AddInParameter(cmd, "inmidpadre", DbType.String, aoInmueble.InmIdPadre)
                    db.AddInParameter(cmd, "tginmestado", DbType.String, aoInmueble.TgInmEstado)
                    db.AddInParameter(cmd, "inmnropisos", DbType.String, aoInmueble.InmNroPisos)
                    db.AddInParameter(cmd, "tgrubroid", DbType.String, aoInmueble.TgRubroId)
                    db.AddInParameter(cmd, "inmobservacion", DbType.String, aoInmueble.InmObservacion)
                    db.AddInParameter(cmd, "tgestsanid", DbType.String, aoInmueble.TgEstSanId)
                    ' Ultima Modificaciones
                    db.AddInParameter(cmd, "tgInmCondRegId", DbType.String, aoInmueble.tgInmCondRegId)
                    db.AddInParameter(cmd, "tgInmCondRegSubId", DbType.String, aoInmueble.tgInmCondRegSubId)
                    db.AddInParameter(cmd, "TgInmCondLegalId", DbType.String, aoInmueble.TgInmCondLegalId)
                    db.AddInParameter(cmd, "TgInmSitFisicaId", DbType.String, aoInmueble.tgInmSitFisicaId)
                    db.AddInParameter(cmd, "tgInmSFInformacionId", DbType.String, aoInmueble.tgInmSFZonificacionId)
                    db.AddInParameter(cmd, "tgInmSFUsoId", DbType.String, aoInmueble.tgInmSFUsoId)
                    db.AddInParameter(cmd, "tgNivelId", DbType.String, aoInmueble.tgNivelId)
                    db.AddInParameter(cmd, "InmObsNivelImp", DbType.String, aoInmueble.InmObsNivelImp)

                    db.ExecuteNonQuery(cmd, transaccion)

                    'Direccion
                    cmd = db.GetStoredProcCommand("Actualizar_InmDireccion_pa")

                    db.AddInParameter(cmd, "inmdirid", DbType.String, aoInmueble.OInmDireccion.InmDirId)
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "inmdirlocalizacion", DbType.String, aoInmueble.OInmDireccion.InmDirLocalizacion)
                    db.AddInParameter(cmd, "tgLocalizacionId", DbType.String, aoInmueble.OInmDireccion.TgLocalizacionId)
                    db.AddInParameter(cmd, "tgNroid", DbType.String, aoInmueble.OInmDireccion.TgNroId)
                    db.AddInParameter(cmd, "inmdirnro", DbType.String, aoInmueble.OInmDireccion.InmDirNro)
                    db.AddInParameter(cmd, "TgSubNroId", DbType.String, aoInmueble.OInmDireccion.TgSubNroId)
                    db.AddInParameter(cmd, "inmdirSubnro", DbType.String, aoInmueble.OInmDireccion.InmDirSubNro)
                    db.AddInParameter(cmd, "tgSubDistritosId", DbType.String, aoInmueble.OInmDireccion.TgSubDistritosId)
                    db.AddInParameter(cmd, "inmdirsubdistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                    db.AddInParameter(cmd, "inmdirfase", DbType.String, aoInmueble.OInmDireccion.InmDirFase)
                    db.AddInParameter(cmd, "inmdiretapa", DbType.String, aoInmueble.OInmDireccion.InmDirEtapa)
                    db.AddInParameter(cmd, "inmdirreferencia", DbType.String, aoInmueble.OInmDireccion.InmDirReferencia)
                    db.AddInParameter(cmd, "ubgDep", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgDep)
                    db.AddInParameter(cmd, "ubgProv", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgProv)
                    db.AddInParameter(cmd, "ubgDist", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgDist)
                    db.AddInParameter(cmd, "InmDirBarrio", DbType.String, aoInmueble.OInmDireccion.InmDirBarrio)
                    db.AddInParameter(cmd, "InmDirSector", DbType.String, aoInmueble.OInmDireccion.InmDirSector)
                    db.AddInParameter(cmd, "InmDirAdicional", DbType.String, aoInmueble.OInmDireccion.InmDirAdicional)
                    db.AddInParameter(cmd, "InmDirCheck", DbType.Boolean, aoInmueble.OInmDireccion.InmDirCheck)
                    db.ExecuteNonQuery(cmd, transaccion)

                    cmd = db.GetStoredProcCommand("Actualizar_InmDireccionIns_pa")

                    db.AddInParameter(cmd, "inmdirInsid", DbType.String, aoInmueble.OInmDireccionIns.InmDirId)
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "inmdirInslocalizacion", DbType.String, aoInmueble.OInmDireccionIns.InmDirLocalizacion)
                    db.AddInParameter(cmd, "tglocalizacionid", DbType.String, aoInmueble.OInmDireccionIns.TgLocalizacionId)
                    db.AddInParameter(cmd, "tgNroid", DbType.String, aoInmueble.OInmDireccionIns.TgNroId)
                    db.AddInParameter(cmd, "inmdirInsnro", DbType.String, aoInmueble.OInmDireccionIns.InmDirNro)
                    db.AddInParameter(cmd, "TgSubNroId", DbType.String, aoInmueble.OInmDireccionIns.TgSubNroId)
                    db.AddInParameter(cmd, "inmdirInsSubnro", DbType.String, aoInmueble.OInmDireccionIns.InmDirSubNro)
                    db.AddInParameter(cmd, "tgsubdistritosId", DbType.String, aoInmueble.OInmDireccionIns.TgSubDistritosId)
                    db.AddInParameter(cmd, "inmdirInsSubdistritos", DbType.String, aoInmueble.OInmDireccionIns.InmDirSubDistritos)
                    db.AddInParameter(cmd, "inmdirInsfase", DbType.String, aoInmueble.OInmDireccionIns.InmDirFase)
                    db.AddInParameter(cmd, "inmdirInsetapa", DbType.String, aoInmueble.OInmDireccionIns.InmDirEtapa)
                    db.AddInParameter(cmd, "ubgDep", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgDep)
                    db.AddInParameter(cmd, "ubgProv", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgProv)
                    db.AddInParameter(cmd, "ubgDist", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgDist)
                    db.AddInParameter(cmd, "InmDirInsBarrio", DbType.String, aoInmueble.OInmDireccionIns.InmDirBarrio)
                    db.AddInParameter(cmd, "InmDirInsSector", DbType.String, aoInmueble.OInmDireccionIns.InmDirSector)
                    db.AddInParameter(cmd, "InmDirInsCheck", DbType.Boolean, aoInmueble.OInmDireccionIns.InmDirCheck)
                    db.AddInParameter(cmd, "InmDirInsAdicional", DbType.String, aoInmueble.OInmDireccionIns.InmDirAdicional)
                    db.ExecuteNonQuery(cmd, transaccion)


                    ''Predio
                    cmd = db.GetStoredProcCommand("Actualizar_InmPredio_pa")
                    db.AddInParameter(cmd, "inmpredid", DbType.String, aoInmueble.OInmPredio.InmPredId)
                    db.AddInParameter(cmd, "inmpredarea", DbType.Decimal, aoInmueble.OInmPredio.InmPredArea)
                    db.ExecuteNonQuery(cmd, transaccion)


                    'Valor Alancelario
                    cmd = db.GetStoredProcCommand("InsertarU_InmArancelario_pa")
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "inmAraAnio", DbType.String, aoInmueble.OInmArancel.InmAraAnio)
                    db.AddInParameter(cmd, "inmAraValUnitario", DbType.Decimal, aoInmueble.OInmArancel.InmAraValUnitario)
                    db.AddInParameter(cmd, "inmAraTotTerreno", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotTerreno)
                    db.AddInParameter(cmd, "inmAraTotConstruccion", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotConstruccion)
                    db.AddInParameter(cmd, "inmAraTotAutovaluo", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotAutovaluo)
                    db.AddInParameter(cmd, "inmAraAreTerreno", DbType.Decimal, aoInmueble.OInmArancel.InmAraAreTerreno)
                    db.AddInParameter(cmd, "inmAraAreConstruida", DbType.Decimal, aoInmueble.OInmArancel.InmAraAreConstruida)
                    db.AddInParameter(cmd, "inmAraFuente", DbType.String, aoInmueble.OInmArancel.InmAraFuente)
                    db.AddInParameter(cmd, "inmAraCodPredio", DbType.String, aoInmueble.OInmArancel.InmAraCodPredio)
                    db.AddInParameter(cmd, "inmAraCodCatastral", DbType.String, aoInmueble.OInmArancel.InmAraCodCatastral)
                    db.ExecuteNonQuery(cmd, transaccion)

                    cmd = db.GetStoredProcCommand("InsertarU_InmValorComercial_pa")
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.OInmValorComercial.InmId)
                    db.AddInParameter(cmd, "inmvalcomnrotas", DbType.String, aoInmueble.OInmValorComercial.InmValComNroTas)
                    db.AddInParameter(cmd, "inmvalcomareatechada", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComAreaTechada)
                    db.AddInParameter(cmd, "inmvalcomarea", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComArea)
                    db.AddInParameter(cmd, "inmvalcomvalxmetro", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValxMetro)
                    db.AddInParameter(cmd, "inmvalcomvalterreno", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValTerreno)
                    db.AddInParameter(cmd, "inmvalcomvalconst", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValConst)
                    db.AddInParameter(cmd, "inmvalcomvaltotal", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValTotal)
                    db.AddInParameter(cmd, "inmvalcomfechatas", DbType.DateTime, aoInmueble.OInmValorComercial.InmValComFechaTas)
                    db.AddInParameter(cmd, "inmvalcomfechatassug", DbType.DateTime, aoInmueble.OInmValorComercial.InmValComFechaTasSug)
                    db.AddInParameter(cmd, "inmvalcomperitoperid", DbType.String, aoInmueble.OInmValorComercial.InmValComPeritoPerId)
                    db.AddInParameter(cmd, "inmvalcomObservacion", DbType.String, aoInmueble.OInmValorComercial.InmValComObservacion)
                    db.ExecuteNonQuery(cmd, transaccion)

                    'Archivos
                    For Each fInmArchId As String In aoInmueble.ListaInmArchivosTemporalEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_InmArchivos_pa")
                        db.AddInParameter(cmd, "inmarchid", DbType.String, fInmArchId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    For Each fArchivos As EEInmArchivos In aoInmueble.ListaInmArchivosTemporalNuevos
                        cmd = db.GetStoredProcCommand("InsertarU_InmArchivos_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                        db.AddInParameter(cmd, "inmarchnombre", DbType.String, fArchivos.InmArchNombre)
                        db.AddInParameter(cmd, "inmarchdescripcion", DbType.String, fArchivos.InmArchDescripcion)
                        db.AddInParameter(cmd, "tgtipoarchid", DbType.String, fArchivos.TgTipoArchId)
                        db.AddInParameter(cmd, "inmarch", DbType.Binary, fArchivos.InmArch)
                        db.AddInParameter(cmd, "inmarchext", DbType.String, fArchivos.InmArchExt)
                        db.AddInParameter(cmd, "inmarchprincipal", DbType.Boolean, fArchivos.InmArchPrincipal)
                        db.AddInParameter(cmd, "InmArchActivo", DbType.Boolean, fArchivos.InmArchActivo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    'Actualizar Archivos que han sido editados
                    For Each fArchivos As EEInmArchivos In aoInmueble.ListaInmArchivosEditados
                        cmd = db.GetStoredProcCommand("Actualizar_InmArchivos_pa")
                        db.AddInParameter(cmd, "inmarchid", DbType.String, fArchivos.InmArchId)
                        db.AddInParameter(cmd, "inmarchnombre", DbType.String, fArchivos.InmArchNombre)
                        db.AddInParameter(cmd, "inmarchdescripcion", DbType.String, fArchivos.InmArchDescripcion)
                        db.AddInParameter(cmd, "inmarchprincipal", DbType.Boolean, fArchivos.InmArchPrincipal)
                        db.AddInParameter(cmd, "InmArchActivo", DbType.Boolean, fArchivos.InmArchActivo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    'Nivel de Inmplementacion
                    For Each frow As EEInmNivelImp In aoInmueble.ListaInmNivImp
                        cmd = db.GetStoredProcCommand("Actualizar_InmNivelImp_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                        db.AddInParameter(cmd, "tgnivimpid", DbType.String, frow.TgNivImpId)
                        db.AddInParameter(cmd, "inmnivfisico", DbType.Boolean, frow.InmNivfisico)
                        db.AddInParameter(cmd, "inmnivdigital", DbType.Boolean, frow.InmNivDigital)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next


      

                    'Procesos Judiciales
                    For Each fProcesoJudicial As EEInmPJudiciales In aoInmueble.ListaInmPJudiciales.FindAll(Function(ac) ac.InmPJudId = "0")
                        cmd = db.GetStoredProcCommand("Insertar_InmPJudiciales_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                        db.AddInParameter(cmd, "inmpjudfechainicio", DbType.DateTime, fProcesoJudicial.InmPJudFechaInicio)
                        db.AddInParameter(cmd, "inmpjudnroexp", DbType.String, fProcesoJudicial.InmPJudNroExp)
                        db.AddInParameter(cmd, "inmpjudjuzgado", DbType.String, fProcesoJudicial.InmPJudJuzgado)
                        db.AddInParameter(cmd, "inmpjudmotivo", DbType.String, fProcesoJudicial.InmPJudMotivo)
                        db.AddInParameter(cmd, "inmpjudetapaproc", DbType.String, fProcesoJudicial.InmPJudEtapaProc)
                        db.AddInParameter(cmd, "inmpjuddemandante", DbType.String, fProcesoJudicial.InmPJudDemandante)
                        db.AddInParameter(cmd, "inmpjuddemandado", DbType.String, fProcesoJudicial.InmPJudDemandado)
                        db.AddInParameter(cmd, "tgestadoprocid", DbType.String, fProcesoJudicial.OTgEstadoProceso.TgCodigo)
                        db.AddInParameter(cmd, "inmpjudlitisconsorte", DbType.String, fProcesoJudicial.InmPJudLitisConsorte)
                        db.AddInParameter(cmd, "inmpjudsecretario", DbType.String, fProcesoJudicial.InmPJudSecretario)
                        db.AddInParameter(cmd, "inmpjudobservacion", DbType.String, fProcesoJudicial.InmPJudObservacion)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Inmueble => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizarAlta(ByVal aoInmueble As EEInmueble) As Boolean
        Dim transaccion As DbTransaction = Nothing

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_InmuebleAlta_pa")

                    'Inmueble
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "InmCodSinabip", DbType.String, aoInmueble.InmCodSinabip)
                    db.AddInParameter(cmd, "tgTipoIngreso", DbType.String, aoInmueble.tgTipoIngreso)
                    db.AddInParameter(cmd, "perRegId", DbType.String, aoInmueble.perRegId)
                    db.AddInParameter(cmd, "inmDocAlta", DbType.String, aoInmueble.inmDocAlta)
                    db.AddInParameter(cmd, "inmFecAlta", DbType.Date, aoInmueble.inmFecAlta)
                    db.AddInParameter(cmd, "inmCausalAlta", DbType.String, aoInmueble.inmCausalAlta)
                    db.AddInParameter(cmd, "inmAltaObservacion", DbType.String, aoInmueble.inmAltaObservacion)

                    db.AddInParameter(cmd, "inmfile", DbType.String, aoInmueble.InmFile)
                    db.AddInParameter(cmd, "inmfileant", DbType.String, aoInmueble.InmFileAnt)
                    db.AddInParameter(cmd, "inminscrito", DbType.String, aoInmueble.InmInscrito)
                    db.AddInParameter(cmd, "inmUbicacion", DbType.String, aoInmueble.InmUbicacion)
                    db.AddInParameter(cmd, "inmdenominacion", DbType.String, aoInmueble.InmDenominacion)
                    db.AddInParameter(cmd, "tgestinmconsvid", DbType.String, aoInmueble.tgEstInmConsvId)
                    db.AddInParameter(cmd, "inmdocacredita", DbType.String, aoInmueble.InmDocAcredita)
                    db.AddInParameter(cmd, "InmDocAcreditaDominio", DbType.String, aoInmueble.InmDocAcreditaDominio)
                    db.AddInParameter(cmd, "inmpartidaelec", DbType.String, aoInmueble.InmPartidaElec)
                    db.AddInParameter(cmd, "inmasiento", DbType.String, aoInmueble.InmAsiento)
                    db.AddInParameter(cmd, "inmsaneadoobs", DbType.String, aoInmueble.InmSaneadoObs)
                    db.AddInParameter(cmd, "inmSaneadoObsMostrable", DbType.String, aoInmueble.inmSaneadoObsMostrable)
                    db.AddInParameter(cmd, "inmdisponibilidad", DbType.Boolean, aoInmueble.InmDisponibilidad)
                    db.AddInParameter(cmd, "inmfecmarg", DbType.DateTime, aoInmueble.InmFecMarg)
                    db.AddInParameter(cmd, "inmactivo", DbType.Boolean, aoInmueble.InmActivo)
                    db.AddInParameter(cmd, "tgtipounidadid", DbType.String, aoInmueble.TgTipoUnidadId)
                    db.AddInParameter(cmd, "inmidpadre", DbType.String, aoInmueble.InmIdPadre)
                    db.AddInParameter(cmd, "tginmestado", DbType.String, aoInmueble.TgInmEstado)
                    db.AddInParameter(cmd, "inmnropisos", DbType.String, aoInmueble.InmNroPisos)
                    db.AddInParameter(cmd, "tgrubroid", DbType.String, aoInmueble.TgRubroId)
                    db.AddInParameter(cmd, "inmobservacion", DbType.String, aoInmueble.InmObservacion)
                    db.AddInParameter(cmd, "tgestsanid", DbType.String, aoInmueble.TgEstSanId)
                    ' Ultima Modificaciones
                    db.AddInParameter(cmd, "tgInmCondRegId", DbType.String, aoInmueble.tgInmCondRegId)
                    db.AddInParameter(cmd, "tgInmCondRegSubId", DbType.String, aoInmueble.tgInmCondRegSubId)
                    db.AddInParameter(cmd, "TgInmCondLegalId", DbType.String, aoInmueble.TgInmCondLegalId)
                    db.AddInParameter(cmd, "TgInmSitFisicaId", DbType.String, aoInmueble.tgInmSitFisicaId)
                    db.AddInParameter(cmd, "tgInmSFInformacionId", DbType.String, aoInmueble.tgInmSFZonificacionId)
                    db.AddInParameter(cmd, "tgInmSFUsoId", DbType.String, aoInmueble.tgInmSFUsoId)
                    db.AddInParameter(cmd, "tgNivelId", DbType.String, aoInmueble.tgNivelId)
                    db.AddInParameter(cmd, "InmObsNivelImp", DbType.String, aoInmueble.InmObsNivelImp)

                    db.ExecuteNonQuery(cmd, transaccion)

                    'Direccion
                    cmd = db.GetStoredProcCommand("Actualizar_InmDireccion_pa")

                    db.AddInParameter(cmd, "inmdirid", DbType.String, aoInmueble.OInmDireccion.InmDirId)
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "inmdirlocalizacion", DbType.String, aoInmueble.OInmDireccion.InmDirLocalizacion)
                    db.AddInParameter(cmd, "tgLocalizacionId", DbType.String, aoInmueble.OInmDireccion.TgLocalizacionId)
                    db.AddInParameter(cmd, "tgNroid", DbType.String, aoInmueble.OInmDireccion.TgNroId)
                    db.AddInParameter(cmd, "inmdirnro", DbType.String, aoInmueble.OInmDireccion.InmDirNro)
                    db.AddInParameter(cmd, "TgSubNroId", DbType.String, aoInmueble.OInmDireccion.TgSubNroId)
                    db.AddInParameter(cmd, "inmdirSubnro", DbType.String, aoInmueble.OInmDireccion.InmDirSubNro)
                    db.AddInParameter(cmd, "tgSubDistritosId", DbType.String, aoInmueble.OInmDireccion.TgSubDistritosId)
                    db.AddInParameter(cmd, "inmdirsubdistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                    db.AddInParameter(cmd, "inmdirfase", DbType.String, aoInmueble.OInmDireccion.InmDirFase)
                    db.AddInParameter(cmd, "inmdiretapa", DbType.String, aoInmueble.OInmDireccion.InmDirEtapa)
                    db.AddInParameter(cmd, "inmdirreferencia", DbType.String, aoInmueble.OInmDireccion.InmDirReferencia)
                    db.AddInParameter(cmd, "ubgDep", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgDep)
                    db.AddInParameter(cmd, "ubgProv", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgProv)
                    db.AddInParameter(cmd, "ubgDist", DbType.String, aoInmueble.OInmDireccion.OUbigeo.UbgDist)
                    db.AddInParameter(cmd, "InmDirBarrio", DbType.String, aoInmueble.OInmDireccion.InmDirBarrio)
                    db.AddInParameter(cmd, "InmDirSector", DbType.String, aoInmueble.OInmDireccion.InmDirSector)
                    db.AddInParameter(cmd, "InmDirAdicional", DbType.String, aoInmueble.OInmDireccion.InmDirAdicional)
                    db.AddInParameter(cmd, "InmDirCheck", DbType.Boolean, aoInmueble.OInmDireccion.InmDirCheck)
                    db.ExecuteNonQuery(cmd, transaccion)

                    cmd = db.GetStoredProcCommand("Actualizar_InmDireccionIns_pa")

                    db.AddInParameter(cmd, "inmdirInsid", DbType.String, aoInmueble.OInmDireccionIns.InmDirId)
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "inmdirInslocalizacion", DbType.String, aoInmueble.OInmDireccionIns.InmDirLocalizacion)
                    db.AddInParameter(cmd, "tglocalizacionid", DbType.String, aoInmueble.OInmDireccionIns.TgLocalizacionId)
                    db.AddInParameter(cmd, "tgNroid", DbType.String, aoInmueble.OInmDireccionIns.TgNroId)
                    db.AddInParameter(cmd, "inmdirInsnro", DbType.String, aoInmueble.OInmDireccionIns.InmDirNro)
                    db.AddInParameter(cmd, "TgSubNroId", DbType.String, aoInmueble.OInmDireccionIns.TgSubNroId)
                    db.AddInParameter(cmd, "inmdirInsSubnro", DbType.String, aoInmueble.OInmDireccionIns.InmDirSubNro)
                    db.AddInParameter(cmd, "tgsubdistritosId", DbType.String, aoInmueble.OInmDireccionIns.TgSubDistritosId)
                    db.AddInParameter(cmd, "inmdirInsSubdistritos", DbType.String, aoInmueble.OInmDireccionIns.InmDirSubDistritos)
                    db.AddInParameter(cmd, "inmdirInsfase", DbType.String, aoInmueble.OInmDireccionIns.InmDirFase)
                    db.AddInParameter(cmd, "inmdirInsetapa", DbType.String, aoInmueble.OInmDireccionIns.InmDirEtapa)
                    db.AddInParameter(cmd, "ubgDep", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgDep)
                    db.AddInParameter(cmd, "ubgProv", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgProv)
                    db.AddInParameter(cmd, "ubgDist", DbType.String, aoInmueble.OInmDireccionIns.OUbigeo.UbgDist)
                    db.AddInParameter(cmd, "InmDirInsBarrio", DbType.String, aoInmueble.OInmDireccionIns.InmDirBarrio)
                    db.AddInParameter(cmd, "InmDirInsSector", DbType.String, aoInmueble.OInmDireccionIns.InmDirSector)
                    db.AddInParameter(cmd, "InmDirInsCheck", DbType.Boolean, aoInmueble.OInmDireccionIns.InmDirCheck)
                    db.AddInParameter(cmd, "InmDirInsAdicional", DbType.String, aoInmueble.OInmDireccionIns.InmDirAdicional)
                    db.ExecuteNonQuery(cmd, transaccion)

                    ''Predio
                    cmd = db.GetStoredProcCommand("Actualizar_InmPredio_pa")
                    db.AddInParameter(cmd, "inmpredid", DbType.String, aoInmueble.OInmPredio.InmPredId)
                    db.AddInParameter(cmd, "inmpredarea", DbType.Decimal, aoInmueble.OInmPredio.InmPredArea)
                    db.ExecuteNonQuery(cmd, transaccion)



                    'Valor Alancelario
                    cmd = db.GetStoredProcCommand("InsertarU_InmArancelario_pa")
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "inmAraAnio", DbType.String, aoInmueble.OInmArancel.InmAraAnio)
                    db.AddInParameter(cmd, "inmAraValUnitario", DbType.Decimal, aoInmueble.OInmArancel.InmAraValUnitario)
                    db.AddInParameter(cmd, "inmAraTotTerreno", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotTerreno)
                    db.AddInParameter(cmd, "inmAraTotConstruccion", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotConstruccion)
                    db.AddInParameter(cmd, "inmAraTotAutovaluo", DbType.Decimal, aoInmueble.OInmArancel.InmAraTotAutovaluo)
                    db.AddInParameter(cmd, "inmAraAreTerreno", DbType.Decimal, aoInmueble.OInmArancel.InmAraAreTerreno)
                    db.AddInParameter(cmd, "inmAraAreConstruida", DbType.Decimal, aoInmueble.OInmArancel.InmAraAreConstruida)
                    db.AddInParameter(cmd, "inmAraFuente", DbType.String, aoInmueble.OInmArancel.InmAraFuente)
                    db.AddInParameter(cmd, "inmAraCodPredio", DbType.String, aoInmueble.OInmArancel.InmAraCodPredio)
                    db.AddInParameter(cmd, "inmAraCodCatastral", DbType.String, aoInmueble.OInmArancel.InmAraCodCatastral)
                    db.ExecuteNonQuery(cmd, transaccion)


                    cmd = db.GetStoredProcCommand("InsertarU_InmValorComercial_pa")
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "inmvalcomnrotas", DbType.String, aoInmueble.OInmValorComercial.InmValComNroTas)
                    db.AddInParameter(cmd, "inmvalcomareatechada", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComAreaTechada)
                    db.AddInParameter(cmd, "inmvalcomarea", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComArea)
                    db.AddInParameter(cmd, "inmvalcomvalxmetro", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValxMetro)
                    db.AddInParameter(cmd, "inmvalcomvalterreno", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValTerreno)
                    db.AddInParameter(cmd, "inmvalcomvalconst", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValConst)
                    db.AddInParameter(cmd, "inmvalcomvaltotal", DbType.Decimal, aoInmueble.OInmValorComercial.InmValComValTotal)
                    db.AddInParameter(cmd, "inmvalcomfechatas", DbType.DateTime, aoInmueble.OInmValorComercial.InmValComFechaTas)
                    db.AddInParameter(cmd, "inmvalcomfechatassug", DbType.DateTime, aoInmueble.OInmValorComercial.InmValComFechaTasSug)
                    db.AddInParameter(cmd, "inmvalcomperitoperid", DbType.String, aoInmueble.OInmValorComercial.InmValComPeritoPerId)
                    db.AddInParameter(cmd, "inmvalcomObservacion", DbType.String, aoInmueble.OInmValorComercial.InmValComObservacion)
                    db.ExecuteNonQuery(cmd, transaccion)

                    'Archivos
                    For Each fInmArchId As String In aoInmueble.ListaInmArchivosTemporalEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_InmArchivos_pa")
                        db.AddInParameter(cmd, "inmarchid", DbType.String, fInmArchId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    For Each fArchivos As EEInmArchivos In aoInmueble.ListaInmArchivosTemporalNuevos
                        cmd = db.GetStoredProcCommand("InsertarU_InmArchivos_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                        db.AddInParameter(cmd, "inmarchnombre", DbType.String, fArchivos.InmArchNombre)
                        db.AddInParameter(cmd, "inmarchdescripcion", DbType.String, fArchivos.InmArchDescripcion)
                        db.AddInParameter(cmd, "tgtipoarchid", DbType.String, fArchivos.TgTipoArchId)
                        db.AddInParameter(cmd, "inmarch", DbType.Binary, fArchivos.InmArch)
                        db.AddInParameter(cmd, "inmarchext", DbType.String, fArchivos.InmArchExt)
                        db.AddInParameter(cmd, "inmarchprincipal", DbType.Boolean, fArchivos.InmArchPrincipal)
                        db.AddInParameter(cmd, "InmArchActivo", DbType.Boolean, fArchivos.InmArchActivo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    'Actualizar Archivos que han sido editados
                    For Each fArchivos As EEInmArchivos In aoInmueble.ListaInmArchivosEditados
                        cmd = db.GetStoredProcCommand("Actualizar_InmArchivos_pa")
                        db.AddInParameter(cmd, "inmarchid", DbType.String, fArchivos.InmArchId)
                        db.AddInParameter(cmd, "inmarchnombre", DbType.String, fArchivos.InmArchNombre)
                        db.AddInParameter(cmd, "inmarchdescripcion", DbType.String, fArchivos.InmArchDescripcion)
                        db.AddInParameter(cmd, "inmarchprincipal", DbType.Boolean, fArchivos.InmArchPrincipal)
                        db.AddInParameter(cmd, "InmArchActivo", DbType.Boolean, fArchivos.InmArchActivo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    'Nivel de Inmplementacion
                    For Each frow As EEInmNivelImp In aoInmueble.ListaInmNivImp
                        cmd = db.GetStoredProcCommand("Actualizar_InmNivelImp_pa")
                        db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                        db.AddInParameter(cmd, "tgnivimpid", DbType.String, frow.TgNivImpId)
                        db.AddInParameter(cmd, "inmnivfisico", DbType.Boolean, frow.InmNivfisico)
                        db.AddInParameter(cmd, "inmnivdigital", DbType.Boolean, frow.InmNivDigital)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Inmueble => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Eliminar"
    Public Shared Function eliminar(ByVal aiIdInmueble As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Inmueble_pa")

            db.AddInParameter(cmd, "idInmueble", DbType.Int32, aiIdInmueble)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Inmueble => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Actualizar Proceso Judicial"
    Public Shared Function actualizarPJ(ByVal aoInmPJudiciales As EEInmPJudiciales) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_InmPJudiciales_pa")

            db.AddInParameter(cmd, "inmpjudid", DbType.String, aoInmPJudiciales.InmPJudId)
            db.AddInParameter(cmd, "inmpjudfechainicio", DbType.DateTime, aoInmPJudiciales.InmPJudFechaInicio)
            db.AddInParameter(cmd, "inmpjudnroexp", DbType.String, aoInmPJudiciales.InmPJudNroExp)
            db.AddInParameter(cmd, "inmpjudjuzgado", DbType.String, aoInmPJudiciales.InmPJudJuzgado)
            db.AddInParameter(cmd, "inmpjudmotivo", DbType.String, aoInmPJudiciales.InmPJudMotivo)
            db.AddInParameter(cmd, "inmpjudetapaproc", DbType.String, aoInmPJudiciales.InmPJudEtapaProc)
            db.AddInParameter(cmd, "inmpjuddemandante", DbType.String, aoInmPJudiciales.InmPJudDemandante)
            db.AddInParameter(cmd, "inmpjuddemandado", DbType.String, aoInmPJudiciales.InmPJudDemandado)
            db.AddInParameter(cmd, "tgestadoprocid", DbType.String, aoInmPJudiciales.OTgEstadoProceso.TgCodigo)
            db.AddInParameter(cmd, "inmpjudlitisconsorte", DbType.String, aoInmPJudiciales.InmPJudLitisConsorte)
            db.AddInParameter(cmd, "inmpjudsecretario", DbType.String, aoInmPJudiciales.InmPJudSecretario)
            db.AddInParameter(cmd, "inmpjudobservacion", DbType.String, aoInmPJudiciales.InmPJudObservacion)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar InmPJudiciales => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Guardar Proceso Judicial"
    Public Shared Function guardarPJ(ByVal aoInmueble As EEInmueble) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_InmPJudiciales_pa")

            For Each fProcesoJudicial As EEInmPJudiciales In aoInmueble.ListaInmPJudiciales.FindAll(Function(ac) ac.InmPJudId = "0")
                cmd = db.GetStoredProcCommand("Insertar_InmPJudiciales_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                db.AddInParameter(cmd, "inmpjudfechainicio", DbType.DateTime, fProcesoJudicial.InmPJudFechaInicio)
                db.AddInParameter(cmd, "inmpjudnroexp", DbType.String, fProcesoJudicial.InmPJudNroExp)
                db.AddInParameter(cmd, "inmpjudjuzgado", DbType.String, fProcesoJudicial.InmPJudJuzgado)
                db.AddInParameter(cmd, "inmpjudmotivo", DbType.String, fProcesoJudicial.InmPJudMotivo)
                db.AddInParameter(cmd, "inmpjudetapaproc", DbType.String, fProcesoJudicial.InmPJudEtapaProc)
                db.AddInParameter(cmd, "inmpjuddemandante", DbType.String, fProcesoJudicial.InmPJudDemandante)
                db.AddInParameter(cmd, "inmpjuddemandado", DbType.String, fProcesoJudicial.InmPJudDemandado)
                db.AddInParameter(cmd, "tgestadoprocid", DbType.String, fProcesoJudicial.OTgEstadoProceso.TgCodigo)
                db.AddInParameter(cmd, "inmpjudlitisconsorte", DbType.String, fProcesoJudicial.InmPJudLitisConsorte)
                db.AddInParameter(cmd, "inmpjudsecretario", DbType.String, fProcesoJudicial.InmPJudSecretario)
                db.AddInParameter(cmd, "inmpjudobservacion", DbType.String, fProcesoJudicial.InmPJudObservacion)
                db.ExecuteNonQuery(cmd)
            Next

        Catch ex As Exception
            Throw New Exception("Guardar InmPJudiciales => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Guardar Archivos"
    Public Shared Function guardarArchivos(ByVal aoInmueble As EEInmueble) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_InmPJudiciales_pa")

            For Each fArchivos As EEInmArchivos In aoInmueble.ListaInmArchivos.FindAll(Function(ac) ac.InmArchId = "")
                cmd = db.GetStoredProcCommand("Insertar_InmArchivos_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                db.AddInParameter(cmd, "inmarchnombre", DbType.String, fArchivos.InmArchNombre)
                db.AddInParameter(cmd, "inmarchdescripcion", DbType.String, fArchivos.InmArchDescripcion)
                db.AddInParameter(cmd, "tgtipoarchid", DbType.String, fArchivos.TgTipoArchId)
                db.AddInParameter(cmd, "inmarch", DbType.Binary, fArchivos.InmArch)
                db.AddInParameter(cmd, "inmarchext", DbType.String, fArchivos.InmArchExt)
                db.AddInParameter(cmd, "inmarchprincipal", DbType.Boolean, fArchivos.InmArchPrincipal)
                db.ExecuteNonQuery(cmd)
            Next

        Catch ex As Exception
            Throw New Exception("Guardar InmArchivos => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

    Public Shared Function ActualizarTgInmEstadoxInmId(ByVal InmId As String, ByVal TgInmEstado As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Update_Inmueble_tgInmEstado_pa")

            db.AddInParameter(cmd, "inmid", DbType.String, InmId)
            db.AddInParameter(cmd, "TgInmEstado", DbType.String, TgInmEstado)

            db.ExecuteNonQuery(cmd)


        Catch ex As Exception
            Throw New Exception("Actualizar Inmueble Estado => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region



#Region "Eliminar"
    Public Shared Function eliminarAlta(ByVal aiIdInmueble As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Inmueble_pa")

            db.AddInParameter(cmd, "idInmueble", DbType.Int32, aiIdInmueble)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Inmueble => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Guardar Archivos"
    Public Shared Function guardarArchivosAlta(ByVal aoInmueble As EEInmueble) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_InmPJudiciales_pa")

            For Each fArchivos As EEInmArchivos In aoInmueble.ListaInmArchivos.FindAll(Function(ac) ac.InmArchId = "")
                cmd = db.GetStoredProcCommand("Insertar_InmArchivos_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                db.AddInParameter(cmd, "inmarchnombre", DbType.String, fArchivos.InmArchNombre)
                db.AddInParameter(cmd, "inmarchdescripcion", DbType.String, fArchivos.InmArchDescripcion)
                db.AddInParameter(cmd, "tgtipoarchid", DbType.String, fArchivos.TgTipoArchId)
                db.AddInParameter(cmd, "inmarch", DbType.Binary, fArchivos.InmArch)
                db.AddInParameter(cmd, "inmarchext", DbType.String, fArchivos.InmArchExt)
                db.AddInParameter(cmd, "inmarchprincipal", DbType.Boolean, fArchivos.InmArchPrincipal)
                db.ExecuteNonQuery(cmd)
            Next

        Catch ex As Exception
            Throw New Exception("Guardar InmArchivos => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region


End Class