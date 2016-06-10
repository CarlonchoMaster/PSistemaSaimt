Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ProcedimientosDAO
    Public Shared Function guardar(ByVal loProcedimientos As EEProcedimientos) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Procedimientos_pa")

            db.AddInParameter(cmd, "procdid", DbType.String, loProcedimientos.ProcdId)
            db.AddInParameter(cmd, "procdnombre", DbType.String, loProcedimientos.ProcdNombre)
            db.AddInParameter(cmd, "procddescripcion", DbType.String, loProcedimientos.ProcdDescripcion)
            db.AddInParameter(cmd, "procdmaxdia", DbType.Int32, loProcedimientos.ProcdMaxDia)
            db.AddInParameter(cmd, "tgarea", DbType.String, loProcedimientos.TgArea)
            db.AddInParameter(cmd, "procdactivo", DbType.Boolean, loProcedimientos.ProcdActivo)
            db.AddInParameter(cmd, "tgcargo", DbType.String, loProcedimientos.TgCargo)
            db.AddInParameter(cmd, "subprocid", DbType.String, loProcedimientos.SubProcId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar Procedimientos => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal loProcedimientos As EEProcedimientos) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Procedimientos_pa")

            db.AddInParameter(cmd, "procdid", DbType.String, loProcedimientos.ProcdId)
            db.AddInParameter(cmd, "procdnombre", DbType.String, loProcedimientos.ProcdNombre)
            db.AddInParameter(cmd, "procddescripcion", DbType.String, loProcedimientos.ProcdDescripcion)
            db.AddInParameter(cmd, "procdmaxdia", DbType.Int32, loProcedimientos.ProcdMaxDia)
            db.AddInParameter(cmd, "tgarea", DbType.String, loProcedimientos.TgArea)
            db.AddInParameter(cmd, "procdactivo", DbType.Boolean, loProcedimientos.ProcdActivo)
            db.AddInParameter(cmd, "tgcargo", DbType.String, loProcedimientos.TgCargo)
            db.AddInParameter(cmd, "subprocid", DbType.String, loProcedimientos.SubProcId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar Procedimientos => " & ex.Message, ex)
        End Try
        Return True
    End Function
 
End Class
