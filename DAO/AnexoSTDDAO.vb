Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class AnexoSTDDAO
    Public Shared Function guardar(aoAnexoSTD As EEAnexoSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_AnexoSTD_pa")

            db.AddInParameter(cmd, "docid", DbType.String, aoAnexoSTD.DocId)
            db.AddInParameter(cmd, "aneid", DbType.String, aoAnexoSTD.AneId)
            db.AddInParameter(cmd, "anenombre", DbType.String, aoAnexoSTD.AneNombre)
            db.AddInParameter(cmd, "anedescripcion", DbType.String, aoAnexoSTD.AneDescripcion)
            db.AddInParameter(cmd, "tgtipoarchid", DbType.String, aoAnexoSTD.TgTipoArchId)
            db.AddInParameter(cmd, "anearch", DbType.String, aoAnexoSTD.AneArch)
            db.AddInParameter(cmd, "anearchext", DbType.String, aoAnexoSTD.AneArchExt)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar AnexoSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(aoAnexoSTD As EEAnexoSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_AnexoSTD_pa")

            db.AddInParameter(cmd, "docid", DbType.String, aoAnexoSTD.DocId)
            db.AddInParameter(cmd, "aneid", DbType.String, aoAnexoSTD.AneId)
            db.AddInParameter(cmd, "anenombre", DbType.String, aoAnexoSTD.AneNombre)
            db.AddInParameter(cmd, "anedescripcion", DbType.String, aoAnexoSTD.AneDescripcion)
            db.AddInParameter(cmd, "tgtipoarchid", DbType.String, aoAnexoSTD.TgTipoArchId)
            db.AddInParameter(cmd, "anearch", DbType.String, aoAnexoSTD.AneArch)
            db.AddInParameter(cmd, "anearchext", DbType.String, aoAnexoSTD.AneArchExt)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar AnexoSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function

#Region "ACTUALIZAR TRANSFERENCIA"
    Public Shared Function actualizarTransferencia(aListaAnexoSTD As List(Of EEAnexoSTD)) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = Nothing

                    For Each fAnexoSTD As EEAnexoSTD In aListaAnexoSTD
                        cmd = db.GetStoredProcCommand("Actualizar_AnexoSTD_Transferencia_pa")
                        db.AddInParameter(cmd, "docid", DbType.String, fAnexoSTD.DocId)
                        db.AddInParameter(cmd, "aneid", DbType.String, fAnexoSTD.AneId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar AnexoSTD Transferencia => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

    Public Shared Function eliminar(aiIdAnexoSTD As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_AnexoSTD_pa")

            db.AddInParameter(cmd, "idAnexoSTD", DbType.Int32, aiIdAnexoSTD)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar AnexoSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
