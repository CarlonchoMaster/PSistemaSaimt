Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ReqDocumentoSTDDAO
    Public Shared Function guardar(aoReqDocumentoSTD As EEReqDocumentoSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_ReqDocumentoSTD_pa")

            db.AddInParameter(cmd, "docid", DbType.String, aoReqDocumentoSTD.DocId)
            db.AddInParameter(cmd, "tgreqid", DbType.String, aoReqDocumentoSTD.TgReqId)

            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar ReqDocumentoSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(aoReqDocumentoSTD As EEReqDocumentoSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_ReqDocumentoSTD_pa")

            db.AddInParameter(cmd, "docid", DbType.String, aoReqDocumentoSTD.DocId)
            db.AddInParameter(cmd, "tgreqid", DbType.String, aoReqDocumentoSTD.TgReqId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar ReqDocumentoSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(aiIdReqDocumentoSTD As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_ReqDocumentoSTD_pa")

            db.AddInParameter(cmd, "docId", DbType.String, aiIdReqDocumentoSTD)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar ReqDocumentoSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
