Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ExpedienteSTDDAO
    Public Shared Function guardar(ByVal loExpedienteSTD As EEExpedienteSTD) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = Nothing

                    Dim docSecId As String = String.Empty
                    If loExpedienteSTD.ListaDocumentosSecundariosEliminados IsNot Nothing Then
                        For Each loDocSecId In loExpedienteSTD.ListaDocumentosSecundariosEliminados
                            cmd = db.GetStoredProcCommand("Eliminar_ExpedienteSTD_pa")
                            db.AddInParameter(cmd, "docid", DbType.String, loExpedienteSTD.DocId)
                            db.AddInParameter(cmd, "docsecid", DbType.String, loDocSecId.ToString)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If
                
                    If loExpedienteSTD.ListaDocumentosSecundariosNuevos IsNot Nothing Then
                        For Each loDocSecId In loExpedienteSTD.ListaDocumentosSecundariosNuevos
                            cmd = db.GetStoredProcCommand("InsertarU_ExpedienteSTD_pa")
                            db.AddInParameter(cmd, "docid", DbType.String, loExpedienteSTD.DocId)
                            db.AddInParameter(cmd, "docsecid", DbType.String, loDocSecId.ToString)
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
            Throw New Exception("Insertar ExpedienteSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function
 
End Class
