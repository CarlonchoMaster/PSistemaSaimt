Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ContratoPersonalDAO
#Region "Guardar"
    Public Shared Function guardar(aoContratoPersonal As EEContratoPersonal) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim perId As String = aoContratoPersonal.OPersona.PerId
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_ContratoPersonal_pa")

                    db.AddInParameter(cmd, "perid", DbType.String, aoContratoPersonal.OPersona.PerId)
                    db.AddOutParameter(cmd, "contrabid", DbType.String, 10)
                    db.AddInParameter(cmd, "contrabfecinicio", DbType.DateTime, aoContratoPersonal.ConTrabFecInicio)
                    db.AddInParameter(cmd, "contrabfecfin", DbType.DateTime, aoContratoPersonal.ConTrabFecFin)
                    db.AddInParameter(cmd, "tgestconid", DbType.String, aoContratoPersonal.OTgEstadoContrato.TgCodigo)
                    db.AddInParameter(cmd, "horid", DbType.String, aoContratoPersonal.OHorarioPer.HorId)
                    db.AddInParameter(cmd, "tgtipoconid", DbType.String, aoContratoPersonal.OTgTipoContrato.TgCodigo)
                    db.AddInParameter(cmd, "contrabnrosueldos", DbType.Int32, aoContratoPersonal.ConTrabNroSueldos)
                    db.AddInParameter(cmd, "contrabmonto", DbType.Decimal, aoContratoPersonal.ConTrabMonto)
                    db.AddInParameter(cmd, "contrabresolucion", DbType.String, aoContratoPersonal.ConTrabResolucion)
                    db.AddInParameter(cmd, "contrabfecres", DbType.DateTime, aoContratoPersonal.ConTrabFecRes)
                    db.AddInParameter(cmd, "contraboficio", DbType.String, aoContratoPersonal.ConTrabOficio)
                    db.AddInParameter(cmd, "contrabfecoficio", DbType.DateTime, aoContratoPersonal.ConTrabFecOficio)
                    db.AddInParameter(cmd, "contrabfecreq", DbType.DateTime, aoContratoPersonal.ConTrabFecReq)
                    db.AddInParameter(cmd, "contrabrequeriemiento", DbType.String, aoContratoPersonal.ConTrabRequeriemiento)
                    db.AddInParameter(cmd, "contrabproveido", DbType.String, aoContratoPersonal.ConTrabProveido)
                    db.AddInParameter(cmd, "contrabfecprov", DbType.DateTime, aoContratoPersonal.ConTrabFecProv)
                    db.AddInParameter(cmd, "contrabinforme", DbType.String, aoContratoPersonal.ConTrabInforme)
                    db.AddInParameter(cmd, "contrabfecinf", DbType.DateTime, aoContratoPersonal.ConTrabFecInf)
                    db.AddInParameter(cmd, "contrabruc", DbType.String, aoContratoPersonal.ConTrabRuc)
                    db.AddInParameter(cmd, "tgbancoid", DbType.String, aoContratoPersonal.TgBancoId)
                    db.AddInParameter(cmd, "contrabnrocuenta", DbType.String, aoContratoPersonal.ConTrabNroCuenta)
                    db.AddInParameter(cmd, "tgestadocivilid", DbType.Int32, aoContratoPersonal.TgEstadoCivilId)
                    db.AddInParameter(cmd, "contrabnrohijos", DbType.Int32, aoContratoPersonal.ConTrabNroHijos)
                    db.AddInParameter(cmd, "codsucursal", DbType.Int32, aoContratoPersonal.CodSucursal)
                    db.AddInParameter(cmd, "tgsegurosocid", DbType.Int32, aoContratoPersonal.TgSeguroSocId)
                    db.AddInParameter(cmd, "contrabnrosegsoc", DbType.String, aoContratoPersonal.NroSeguroSoc)

                    db.AddInParameter(cmd, "tgNivEduId", DbType.String, aoContratoPersonal.tgNivEduId)
                    db.AddInParameter(cmd, "tgNivRemnId", DbType.String, aoContratoPersonal.tgNivRemnId)
                    db.AddInParameter(cmd, "tgGradoOcuId", DbType.String, aoContratoPersonal.tgGradoOcuId)
                    db.AddInParameter(cmd, "tgForProfId", DbType.String, aoContratoPersonal.tgForProfId)

                    db.ExecuteNonQuery(cmd, transaccion)

                    Dim lsConTrabId As String = db.GetParameterValue(cmd, "conTrabId").ToString()
                    If aoContratoPersonal.ListaCargoPersonal IsNot Nothing Then
                        For Each fCargoPersonal As EECargoPersonal In aoContratoPersonal.ListaCargoPersonal
                            cmd = db.GetStoredProcCommand("Insertar_CargoPersonal_pa")
                            db.AddInParameter(cmd, "carPerId", DbType.String, fCargoPersonal.CarPerId)
                            db.AddInParameter(cmd, "conTraId", DbType.String, lsConTrabId)
                            db.AddInParameter(cmd, "tgTipoCargoId", DbType.String, fCargoPersonal.OTgTipoCargo.TgCodigo)
                            db.AddInParameter(cmd, "carPerFechaIni", DbType.DateTime, fCargoPersonal.CarPerFechaIni)
                            db.AddInParameter(cmd, "carPerFechaFin", DbType.DateTime, fCargoPersonal.CarPerFechaFin)
                            db.AddInParameter(cmd, "tgEstadoId", DbType.Boolean, fCargoPersonal.TgEstadoId)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar Contrato Personal => " + ex.Message, ex)
        End Try
        Try
            MigrarAsistencias(perId)
        Catch ex As Exception

        End Try
        Return True
    End Function
#End Region

#Region "Actualizar"
    Public Shared Function actualizar(aoContratoPersonal As EEContratoPersonal) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim perId As String = aoContratoPersonal.OPersona.PerId
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_ContratoPersonal_pa")

                    db.AddInParameter(cmd, "perid", DbType.String, aoContratoPersonal.OPersona.PerId)
                    db.AddInParameter(cmd, "contrabid", DbType.String, aoContratoPersonal.ConTrabId)
                    db.AddInParameter(cmd, "contrabfecinicio", DbType.DateTime, aoContratoPersonal.ConTrabFecInicio)
                    db.AddInParameter(cmd, "contrabfecfin", DbType.DateTime, aoContratoPersonal.ConTrabFecFin)
                    db.AddInParameter(cmd, "tgestconid", DbType.String, aoContratoPersonal.OTgEstadoContrato.TgCodigo)
                    db.AddInParameter(cmd, "horid", DbType.String, aoContratoPersonal.OHorarioPer.HorId)
                    db.AddInParameter(cmd, "tgtipoconid", DbType.String, aoContratoPersonal.OTgTipoContrato.TgCodigo)
                    db.AddInParameter(cmd, "contrabnrosueldos", DbType.Int32, aoContratoPersonal.ConTrabNroSueldos)
                    db.AddInParameter(cmd, "contrabmonto", DbType.Decimal, aoContratoPersonal.ConTrabMonto)
                    db.AddInParameter(cmd, "contrabresolucion", DbType.String, aoContratoPersonal.ConTrabResolucion)
                    db.AddInParameter(cmd, "contrabfecres", DbType.DateTime, aoContratoPersonal.ConTrabFecRes)
                    db.AddInParameter(cmd, "contraboficio", DbType.String, aoContratoPersonal.ConTrabOficio)
                    db.AddInParameter(cmd, "contrabfecoficio", DbType.DateTime, aoContratoPersonal.ConTrabFecOficio)
                    db.AddInParameter(cmd, "contrabfecreq", DbType.DateTime, aoContratoPersonal.ConTrabFecReq)
                    db.AddInParameter(cmd, "contrabrequeriemiento", DbType.String, aoContratoPersonal.ConTrabRequeriemiento)
                    db.AddInParameter(cmd, "contrabproveido", DbType.String, aoContratoPersonal.ConTrabProveido)
                    db.AddInParameter(cmd, "contrabfecprov", DbType.DateTime, aoContratoPersonal.ConTrabFecProv)
                    db.AddInParameter(cmd, "contrabinforme", DbType.String, aoContratoPersonal.ConTrabInforme)
                    db.AddInParameter(cmd, "contrabfecinf", DbType.DateTime, aoContratoPersonal.ConTrabFecInf)
                    db.AddInParameter(cmd, "contrabruc", DbType.String, aoContratoPersonal.ConTrabRuc)
                    db.AddInParameter(cmd, "tgbancoid", DbType.String, aoContratoPersonal.TgBancoId)
                    db.AddInParameter(cmd, "contrabnrocuenta", DbType.String, aoContratoPersonal.ConTrabNroCuenta)
                    db.AddInParameter(cmd, "tgestadocivilid", DbType.Int32, aoContratoPersonal.TgEstadoCivilId)
                    db.AddInParameter(cmd, "contrabnrohijos", DbType.Int32, aoContratoPersonal.ConTrabNroHijos)
                    db.AddInParameter(cmd, "codsucursal", DbType.Int32, aoContratoPersonal.CodSucursal)
                    db.AddInParameter(cmd, "tgsegurosocid", DbType.Int32, aoContratoPersonal.TgSeguroSocId)
                    db.AddInParameter(cmd, "contrabnrosegsoc", DbType.String, aoContratoPersonal.NroSeguroSoc)

                    db.AddInParameter(cmd, "tgNivEduId", DbType.String, aoContratoPersonal.tgNivEduId)
                    db.AddInParameter(cmd, "tgNivRemnId", DbType.String, aoContratoPersonal.tgNivRemnId)
                    db.AddInParameter(cmd, "tgGradoOcuId", DbType.String, aoContratoPersonal.tgGradoOcuId)
                    db.AddInParameter(cmd, "tgForProfId", DbType.String, aoContratoPersonal.tgForProfId)
                    db.ExecuteNonQuery(cmd, transaccion)

                    For Each fCarPerId As String In aoContratoPersonal.ListaTemporalEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_CargoPersonal_pa")
                        db.AddInParameter(cmd, "carPerId", DbType.String, fCarPerId)
                        db.AddInParameter(cmd, "contraid", DbType.String, aoContratoPersonal.ConTrabId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    For Each fCarPerIdE As String In aoContratoPersonal.ListaTemporalEditados
                        cmd = db.GetStoredProcCommand("Actualizar_Estado_CargoPersonal_pa")
                        db.AddInParameter(cmd, "carPerId", DbType.String, fCarPerIdE)
                        db.AddInParameter(cmd, "contraid", DbType.String, aoContratoPersonal.ConTrabId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    For Each fCargoPersonal As EECargoPersonal In aoContratoPersonal.ListaTemporalNuevos
                        cmd = db.GetStoredProcCommand("InsertarU_CargoPersonal_pa")
                        db.AddInParameter(cmd, "carPerId", DbType.String, fCargoPersonal.CarPerId)
                        db.AddInParameter(cmd, "conTraId", DbType.String, aoContratoPersonal.ConTrabId)
                        db.AddInParameter(cmd, "tgTipoCargoId", DbType.String, fCargoPersonal.OTgTipoCargo.TgCodigo)
                        db.AddInParameter(cmd, "carPerFechaIni", DbType.DateTime, fCargoPersonal.CarPerFechaIni)
                        db.AddInParameter(cmd, "carPerFechaFin", DbType.DateTime, fCargoPersonal.CarPerFechaFin)
                        db.AddInParameter(cmd, "tgEstadoId", DbType.Boolean, fCargoPersonal.TgEstadoId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()

                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Contrato Personal => " + ex.Message, ex)
        End Try
        Try
            MigrarAsistencias(perId)
        Catch ex As Exception

        End Try

        Return True
    End Function
#End Region
    Public Shared Function MigrarAsistencias(asPerId As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Trabajadores_Asistencias_by_perId_pa")
            db.AddInParameter(cmd, "perId", DbType.String, asPerId)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Migrar Asistencias => " & ex.Message, ex)
        End Try
        Return True
    End Function
    Public Shared Function eliminar(aiIdContratoPersonal As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_ContratoPersonal_pa")

            db.AddInParameter(cmd, "idContratoPersonal", DbType.Int32, aiIdContratoPersonal)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar ContratoPersonal => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
