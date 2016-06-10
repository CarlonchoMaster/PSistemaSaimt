Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class CargoTipoAccionSTDDAO

#Region "Actualizar"
    Public Shared Function actualizar(aoCargoTipoAccionSTD As EECargoTipoAccionSTD) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = Nothing

                    For Each fId As String In aoCargoTipoAccionSTD.ListaTemporalEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_CargoTipoAccionSTD_pa")
                        db.AddInParameter(cmd, "id", DbType.String, fId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    For Each fCargoTipoAccionSTD As EECargoTipoAccionSTD In aoCargoTipoAccionSTD.ListaTemporalNuevos
                        cmd = db.GetStoredProcCommand("InsertarU_CargoTipoAccionSTD_pa")
                        db.AddInParameter(cmd, "cartipoaccid", DbType.String, fCargoTipoAccionSTD.CarTipoAccId)
                        db.AddInParameter(cmd, "tgtaccionid", DbType.String, fCargoTipoAccionSTD.OTgAccion.TgCodigo)
                        db.AddInParameter(cmd, "cartipoaccaño", DbType.String, fCargoTipoAccionSTD.CarTipoAccAño)
                        db.AddInParameter(cmd, "cartipoaccnroini", DbType.Int32, fCargoTipoAccionSTD.CarTipoAccNroIni)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar CargoTipoAccionSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

    Public Shared Function eliminar(aiIdCargoTipoAccionSTD As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_CargoTipoAccionSTD_pa")

            db.AddInParameter(cmd, "idCargoTipoAccionSTD", DbType.Int32, aiIdCargoTipoAccionSTD)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar CargoTipoAccionSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
