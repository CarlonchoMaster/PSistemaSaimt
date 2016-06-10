Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades
Public Class ProcesosDAO

    Public Shared Function guardar(ByVal loProcesos As EEProcesos) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Procesos_pa")
            db.AddInParameter(cmd, "procid", DbType.String, loProcesos.ProcId)
            db.AddInParameter(cmd, "procnombre", DbType.String, loProcesos.ProcNombre)
            db.AddInParameter(cmd, "procdescripcion", DbType.String, loProcesos.ProcDescripcion)
            db.AddInParameter(cmd, "procactivo", DbType.Boolean, loProcesos.ProcActivo)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Guardar Procesos => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal loProcesos As EEProcesos) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Procesos_pa")
            db.AddInParameter(cmd, "procid", DbType.String, loProcesos.ProcId)
            db.AddInParameter(cmd, "procnombre", DbType.String, loProcesos.ProcNombre)
            db.AddInParameter(cmd, "procdescripcion", DbType.String, loProcesos.ProcDescripcion)
            db.AddInParameter(cmd, "procactivo", DbType.Boolean, loProcesos.ProcActivo)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Actualizar Procesos => " & ex.Message, ex)
        End Try
        Return True
    End Function

End Class
