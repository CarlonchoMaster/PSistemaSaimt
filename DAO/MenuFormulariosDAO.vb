Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class MenuFormulariosDAO
   #Region "Actualizar"
    Public Shared Function actualizar(ByVal aoMenuFormularios As EEMenuFormularios) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = Nothing

                    For Each fMfrId As String In aoMenuFormularios.ListaTemporalEliminados
                        cmd = db.GetStoredProcCommand("EliminarU_MenuFormularios_pa")
                        db.AddInParameter(cmd, "mfrId", DbType.Int16, fMfrId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    For Each fMenuFormularios As EEMenuFormularios In aoMenuFormularios.ListaTemporalNuevos
                        cmd = db.GetStoredProcCommand("InsertarU_MenuFormularios_pa")
                        db.AddInParameter(cmd, "mfrNombre", DbType.String, fMenuFormularios.MfrNombre)
                        db.AddInParameter(cmd, "mfrTitulo", DbType.String, fMenuFormularios.MfrTitulo)
                        db.AddInParameter(cmd, "grfId", DbType.String, fMenuFormularios.OGrupoFormularios.GrfId)
                        db.AddInParameter(cmd, "mfrDescripcion", DbType.String, fMenuFormularios.MfrDescripcion)
                        db.AddInParameter(cmd, "mfrTag", DbType.String, fMenuFormularios.MfrTag)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar MenuFormularios => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

    Public Shared Function eliminar(aiIdMenuFormularios As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_MenuFormularios_pa")

            db.AddInParameter(cmd, "idMenuFormularios", DbType.Int32, aiIdMenuFormularios)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar MenuFormularios => " & ex.Message, ex)
        End Try
        Return True
    End Function

End Class
