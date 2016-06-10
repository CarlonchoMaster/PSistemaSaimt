Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class JerarquiaArchDAO
    Public Shared Function guardar(ByVal loJerarquiaArch As EEJerarquiaArch) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_JerarquiaArch_pa")

            db.AddInParameter(cmd, "jerid", DbType.String, loJerarquiaArch.JerId)
            db.AddInParameter(cmd, "jernombre", DbType.String, loJerarquiaArch.JerNombre)
            db.AddInParameter(cmd, "jerpadre", DbType.String, loJerarquiaArch.JerPadre)
            db.AddInParameter(cmd, "jernivel", DbType.Int32, loJerarquiaArch.JerNivel)
            db.AddInParameter(cmd, "jerdescripcion", DbType.String, loJerarquiaArch.JerDescripcion)
            'db.AddInParameter(cmd, "jereliminado", DbType.Boolean, loJerarquiaArch.JerEliminado)
            ' db.AddInParameter(cmd, "jerfechreg", DbType.DateTime, loJerarquiaArch.JerfechReg)
            db.AddInParameter(cmd, "jericono", DbType.String, loJerarquiaArch.JerIcono)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar JerarquiaArch => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal loJerarquiaArch As EEJerarquiaArch) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_JerarquiaArch_pa")

            db.AddInParameter(cmd, "jerid", DbType.String, loJerarquiaArch.JerId)
            db.AddInParameter(cmd, "jernombre", DbType.String, loJerarquiaArch.JerNombre)
            db.AddInParameter(cmd, "jerpadre", DbType.String, loJerarquiaArch.JerPadre)
            db.AddInParameter(cmd, "jernivel", DbType.Int32, loJerarquiaArch.JerNivel)
            db.AddInParameter(cmd, "jerdescripcion", DbType.String, loJerarquiaArch.JerDescripcion)
            db.AddInParameter(cmd, "jericono", DbType.String, loJerarquiaArch.JerIcono)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar JerarquiaArch => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(ByVal viIdJerarquiaArch As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_JerarquiaArch_pa")

            db.AddInParameter(cmd, "idJerarquiaArch", DbType.Int32, viIdJerarquiaArch)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar JerarquiaArch => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class

