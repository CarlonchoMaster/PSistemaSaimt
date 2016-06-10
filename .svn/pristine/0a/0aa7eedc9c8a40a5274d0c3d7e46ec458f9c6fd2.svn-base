Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class JerarquiaSTDDAO	
#Region "Guardar"
    Public Shared Function guardar(aoJerarquiaSTD As EEJerarquiaSTD) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = Nothing

                    For Each fJerarquiaSTD As EEJerarquiaSTD In aoJerarquiaSTD.ListaJerarquiaSTD
                        cmd = db.GetStoredProcCommand("Insertar_JerarquiaSTD_pa")
                        db.AddInParameter(cmd, "jerdeid", DbType.String, fJerarquiaSTD.JerDeId)
                        db.AddInParameter(cmd, "jerparaid", DbType.String, fJerarquiaSTD.JerParaId)
                        db.AddInParameter(cmd, "tgtdocid", DbType.String, fJerarquiaSTD.OTgTipoDocumento.TgCodigo)
                        db.AddInParameter(cmd, "jeractivo", DbType.Boolean, fJerarquiaSTD.JerActivo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar JerarquiaSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Actualizar"
    Public Shared Function actualizar(aoJerarquiaSTD As EEJerarquiaSTD) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = Nothing

                    For Each fJerId As String In aoJerarquiaSTD.ListaTemporalEliminados
                        cmd = db.GetStoredProcCommand("Eliminar_JerarquiaSTD_pa")
                        db.AddInParameter(cmd, "jerid", DbType.String, fJerId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    For Each fJerarquiaSTD As EEJerarquiaSTD In aoJerarquiaSTD.ListaTemporalNuevos
                        cmd = db.GetStoredProcCommand("InsertarU_JerarquiaSTD_pa")
                        db.AddInParameter(cmd, "jerdeid", DbType.String, fJerarquiaSTD.JerDeId)
                        db.AddInParameter(cmd, "jerparaid", DbType.String, fJerarquiaSTD.JerParaId)
                        db.AddInParameter(cmd, "tgtdocid", DbType.String, fJerarquiaSTD.OTgTipoDocumento.TgCodigo)
                        db.AddInParameter(cmd, "jeractivo", DbType.Boolean, fJerarquiaSTD.JerActivo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar JerarquiaSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

	Public Shared Function eliminar(aiIdJerarquiaSTD As Int32) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_JerarquiaSTD_pa")
			
			db.AddInParameter(cmd, "idJerarquiaSTD", DbType.Int32, aiIdJerarquiaSTD)			
			db.ExecuteNonQuery(cmd)
			
		Catch ex As Exception
			Throw New Exception("Eliminar JerarquiaSTD => " & ex.Message, ex)
		End Try
		Return True
    End Function
End Class
