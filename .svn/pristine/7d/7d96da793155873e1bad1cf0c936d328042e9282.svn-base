Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class CargoTipoDocSTDDAO

#Region "Actualizar"
    Public Shared Function actualizar(aoCargoTipoDocSTD As EECargoTipoDocSTD) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = Nothing

                    For Each fId As String In aoCargoTipoDocSTD.ListaTemporalEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_CargoTipoDocSTD_pa")
                        db.AddInParameter(cmd, "id", DbType.String, fId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    For Each fCargoTipoDocSTD As EECargoTipoDocSTD In aoCargoTipoDocSTD.ListaTemporalNuevos
                        cmd = db.GetStoredProcCommand("InsertarU_CargoTipoDocSTD_pa")
                        db.AddInParameter(cmd, "cartipodocid", DbType.String, fCargoTipoDocSTD.CarTipoDocId)
                        db.AddInParameter(cmd, "cartipodocnroini", DbType.Int32, fCargoTipoDocSTD.CarTipoDocNroIni)
                        db.AddInParameter(cmd, "tgtdocid", DbType.String, fCargoTipoDocSTD.OTgTipoDocumento.TgCodigo)
                        db.AddInParameter(cmd, "cartipoaño", DbType.String, fCargoTipoDocSTD.CarTipoAño)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar CargoTipoDocSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

    Public Shared Function eliminar(aiIdCargoTipoDocSTD As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_CargoTipoDocSTD_pa")

            db.AddInParameter(cmd, "idCargoTipoDocSTD", DbType.Int32, aiIdCargoTipoDocSTD)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar CargoTipoDocSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
