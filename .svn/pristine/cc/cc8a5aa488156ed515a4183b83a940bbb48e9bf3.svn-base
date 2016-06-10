Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ProcedimientosMovDAO
    Public Shared Function guardar(ByVal loMovimientosProcedimientos As EEProcedimientosMov) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("InsertarU_ProcedimientosMov_pa")

                    db.AddInParameter(cmd, "solid", DbType.String, loMovimientosProcedimientos.SolId)
                    db.AddInParameter(cmd, "procdid", DbType.String, loMovimientosProcedimientos.ProcdId)
                    db.AddInParameter(cmd, "estado", DbType.String, loMovimientosProcedimientos.Estado)
                    db.AddInParameter(cmd, "tgAreaCargo", DbType.String, loMovimientosProcedimientos.TgAreaCargo)
                    db.AddInParameter(cmd, "perid", DbType.String, loMovimientosProcedimientos.PerId)
                    db.AddOutParameter(cmd, "movprocdid", DbType.Int32, 11)
                    db.ExecuteNonQuery(cmd, transaccion)
                    Dim movprocdid As String = db.GetParameterValue(cmd, "movprocdid").ToString()
                    For Each loProcedimientosAct As EEProcedimientosAct In loMovimientosProcedimientos.ListaProcedimientosAct
                        cmd = db.GetStoredProcCommand("InsertarU_ProcedimientosAct_pa")
                        db.AddInParameter(cmd, "movprocdid", DbType.String, movprocdid)
                        db.AddInParameter(cmd, "actividad", DbType.String, loProcedimientosAct.Actividad)
                        db.AddInParameter(cmd, "nro", DbType.Int32, loProcedimientosAct.Nro)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar Movimientos Procedimiento Inmueble => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal loMovimientosProcedimientos As EEProcedimientosMov) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_MovimientosProcedimientos_pa")

            db.AddInParameter(cmd, "solid", DbType.String, loMovimientosProcedimientos.SolId)
            db.AddInParameter(cmd, "procdid", DbType.String, loMovimientosProcedimientos.ProcdId)
            db.AddInParameter(cmd, "estado", DbType.String, loMovimientosProcedimientos.Estado)
            db.AddInParameter(cmd, "tgAreaCargo", DbType.String, loMovimientosProcedimientos.TgAreaCargo)
            db.AddInParameter(cmd, "perid", DbType.String, loMovimientosProcedimientos.PerId)
            db.AddInParameter(cmd, "movprocid", DbType.Int32, loMovimientosProcedimientos.MovProcdId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar MovimientosProcedimientos => " & ex.Message, ex)
        End Try
        Return True
    End Function

End Class


