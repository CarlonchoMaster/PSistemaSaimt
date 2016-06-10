Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class PartidaDAO
    Public Shared Function guardar(ByVal aoPartida As EEPartida) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Partida_pa")
            db.AddInParameter(cmd, "partid", DbType.String, aoPartida.PartId)
            db.AddInParameter(cmd, "partaño", DbType.String, aoPartida.PartAño)
            db.AddInParameter(cmd, "tgparttipoid", DbType.String, aoPartida.TgPartTipoId)
            db.AddInParameter(cmd, "partnombre", DbType.String, aoPartida.PartNombre)
            db.AddInParameter(cmd, "tgpartestid", DbType.Boolean, aoPartida.TgPartEstId)
            db.AddInParameter(cmd, "partDocRef", DbType.String, aoPartida.PartDocRef)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Guardar Partida => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal aoPartida As EEPartida) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Partida_pa")
            db.AddInParameter(cmd, "partid", DbType.String, aoPartida.PartId)
            db.AddInParameter(cmd, "partaño", DbType.String, aoPartida.PartAño)
            db.AddInParameter(cmd, "tgparttipoid", DbType.String, aoPartida.TgPartTipoId)
            db.AddInParameter(cmd, "partnombre", DbType.String, aoPartida.PartNombre)
            db.AddInParameter(cmd, "tgpartestid", DbType.Boolean, aoPartida.TgPartEstId)
            db.AddInParameter(cmd, "partDocRef", DbType.String, aoPartida.PartDocRef)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Actualizar Partida => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(ByVal aoPartida As EEPartida) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Partida_pa")

            db.AddInParameter(cmd, "partid", DbType.String, aoPartida.PartId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Partida => " & ex.Message, ex)
        End Try
        Return True
    End Function


End Class


