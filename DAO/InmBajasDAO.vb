﻿Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class InmBajasDAO
    Public Shared Function guardar(ByVal aoInmBajas As EEInmueble.EEInmBajas) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("InsertarU_InmBajas_pa")

            db.AddInParameter(cmd, "inmbajaid", DbType.String, aoInmBajas.InmBajaId)
            db.AddInParameter(cmd, "inmbajanrodoc", DbType.String, aoInmBajas.InmBajaNroDoc)
            db.AddInParameter(cmd, "inmbajafecha", DbType.DateTime, aoInmBajas.InmBajaFecha)
            db.AddInParameter(cmd, "inmbajadocfecha", DbType.DateTime, aoInmBajas.InmBajaDocFecha)
            db.AddInParameter(cmd, "inmbajadocarchivo", DbType.String, aoInmBajas.InmBajaDocArchivo)
            db.AddInParameter(cmd, "inmbajaobservacion", DbType.String, aoInmBajas.InmBajaObservacion)
            db.AddInParameter(cmd, "inmBajaDatoAdicional", DbType.String, aoInmBajas.InmBajaDatoAdicional)
            db.AddInParameter(cmd, "perregbajaid", DbType.String, aoInmBajas.PerRegBajaId)
            db.AddInParameter(cmd, "inmbajatemporal", DbType.Boolean, aoInmBajas.InmBajaTemporal)
            db.AddInParameter(cmd, "inmbajacausa", DbType.String, aoInmBajas.InmBajaCausa)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Guardar InmBajas => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function InmuebleGuardar(ByVal aoInmueble As EEInmueble) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Dim cmd As DbCommand
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    cmd = db.GetStoredProcCommand("Actualizar_InmuebleBaja_pa")

                    'Inmueble

                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "InmCodSinabip", DbType.String, aoInmueble.InmCodSinabip)
                    db.AddInParameter(cmd, "tgNivelId", DbType.String, aoInmueble.tgNivelId)
                    db.AddInParameter(cmd, "inmobservacion", DbType.String, aoInmueble.InmObservacion)
                    db.AddInParameter(cmd, "tgInmCondRegId", DbType.String, aoInmueble.tgInmCondRegId)
                    db.AddInParameter(cmd, "tgInmCondRegSubId", DbType.String, aoInmueble.tgInmCondRegSubId)
                    db.AddInParameter(cmd, "inmpartidaelec", DbType.String, aoInmueble.InmPartidaElec)
                    db.AddInParameter(cmd, "inmasiento", DbType.String, aoInmueble.InmAsiento)
                    db.AddInParameter(cmd, "TgInmCondLegalId", DbType.String, aoInmueble.TgInmCondLegalId)
                    db.AddInParameter(cmd, "tgestsanid", DbType.String, aoInmueble.TgEstSanId)
                    db.AddInParameter(cmd, "inmdocacredita", DbType.String, aoInmueble.InmDocAcredita)
                    db.AddInParameter(cmd, "InmDocAcreditaDominio", DbType.String, aoInmueble.InmDocAcreditaDominio)
                    db.AddInParameter(cmd, "inmsaneadoobs", DbType.String, aoInmueble.InmSaneadoObs)
                    db.AddInParameter(cmd, "inmdisponibilidad", DbType.Boolean, aoInmueble.InmDisponibilidad)
                    db.AddInParameter(cmd, "inmactivo", DbType.Boolean, aoInmueble.InmActivo)
                    db.AddInParameter(cmd, "tgestinmconsvid", DbType.String, aoInmueble.tgEstInmConsvId)
                    db.AddInParameter(cmd, "TgInmSitFisicaId", DbType.String, aoInmueble.tgInmSitFisicaId)
                    db.AddInParameter(cmd, "tgInmSFInformacionId", DbType.String, aoInmueble.tgInmSFZonificacionId)
                    db.AddInParameter(cmd, "tgInmSFUsoId", DbType.String, aoInmueble.tgInmSFUsoId)
                    db.AddInParameter(cmd, "inmnropisos", DbType.String, aoInmueble.InmNroPisos)
                    db.AddInParameter(cmd, "InmObsNivelImp", DbType.String, aoInmueble.InmObsNivelImp)

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
                    db.AddInParameter(cmd, "inmAraFuente", DbType.Decimal, aoInmueble.OInmArancel.InmAraFuente)
                    db.AddInParameter(cmd, "inmAraCodPredio", DbType.String, aoInmueble.OInmArancel.InmAraCodPredio)
                    db.AddInParameter(cmd, "inmAraCodCatastral", DbType.String, aoInmueble.OInmArancel.InmAraCodCatastral)
                    db.ExecuteNonQuery(cmd, transaccion)

                    ''Predio
                    cmd = db.GetStoredProcCommand("Actualizar_InmPredio_pa")

                    db.AddInParameter(cmd, "inmpredid", DbType.String, aoInmueble.OInmPredio.InmPredId)
                    db.AddInParameter(cmd, "inmid", DbType.String, aoInmueble.InmId)
                    db.AddInParameter(cmd, "inmpredarea", DbType.Decimal, aoInmueble.OInmPredio.InmPredArea)
                    'db.AddInParameter(cmd, "inmpredarancel", DbType.Decimal, aoInmueble.OInmPredio.InmPredArancel)
                    'db.AddInParameter(cmd, "inmpredvalorterreno", DbType.Decimal, aoInmueble.OInmPredio.InmPredValorTerreno)
                    'db.AddInParameter(cmd, "inmpredareatechada", DbType.Decimal, aoInmueble.OInmPredio.InmPredAreaTechada)
                    'db.AddInParameter(cmd, "inmpredvalorconst", DbType.Decimal, aoInmueble.OInmPredio.InmPredValorConst)
                    'db.AddInParameter(cmd, "inmpredvaloredificacion", DbType.Decimal, aoInmueble.OInmPredio.InmPredValorEdificacion)
                    'db.AddInParameter(cmd, "inmpredvalortotal", DbType.Decimal, aoInmueble.OInmPredio.InmPredValorTotal)
                    'db.AddInParameter(cmd, "inmpredactivo", DbType.Boolean, aoInmueble.OInmPredio.InmPredActivo)
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
            Throw New Exception("Guardar Inmueble Bajas => " + ex.Message, ex)
        End Try
        Return True
    End Function
    Public Shared Function ActualizarInmbajaDocArchivo(ByVal aoInmBajas As EEInmueble.EEInmBajas) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Update_InmBajas_inmbajadocarchivo_pa")
            db.AddInParameter(cmd, "inmbajaid", DbType.String, aoInmBajas.InmBajaId)
            db.AddInParameter(cmd, "inmbajadocarchivo", DbType.String, aoInmBajas.InmBajaDocArchivo)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Guardar InmBajas => " + ex.Message, ex)
        End Try
        Return True
    End Function




End Class
