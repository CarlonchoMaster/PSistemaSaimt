Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class SolicitudesDAO
    Public Shared Function guardar(ByVal loSolicitudes As EESolicitudes) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Solicitudes_pa")

            db.AddInParameter(cmd, "solid", DbType.String, loSolicitudes.SolId)
            db.AddInParameter(cmd, "solnombre", DbType.String, loSolicitudes.SolNombre)
            db.AddInParameter(cmd, "soldescripcion", DbType.String, loSolicitudes.SolDescripcion)
            db.AddInParameter(cmd, "solactivo", DbType.Boolean, loSolicitudes.SolActivo)
            db.AddInParameter(cmd, "soldocref", DbType.String, loSolicitudes.SolDocRef)
            db.AddInParameter(cmd, "solfecha", DbType.DateTime, loSolicitudes.SolFecha)
            db.AddInParameter(cmd, "subprocid", DbType.String, loSolicitudes.SubProcId)
            db.AddInParameter(cmd, "perId", DbType.String, loSolicitudes.PerId)
            db.AddInParameter(cmd, "procdId", DbType.String, loSolicitudes.procdId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar Solicitudes => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal loSolicitudes As EESolicitudes) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Solicitudes_pa")

            db.AddInParameter(cmd, "solid", DbType.String, loSolicitudes.SolId)
            db.AddInParameter(cmd, "solnombre", DbType.String, loSolicitudes.SolNombre)
            db.AddInParameter(cmd, "soldescripcion", DbType.String, loSolicitudes.SolDescripcion)
            db.AddInParameter(cmd, "solactivo", DbType.Boolean, loSolicitudes.SolActivo)
            db.AddInParameter(cmd, "soldocref", DbType.String, loSolicitudes.SolDocRef)
            db.AddInParameter(cmd, "solfecha", DbType.DateTime, loSolicitudes.SolFecha)
            db.AddInParameter(cmd, "subprocid", DbType.String, loSolicitudes.SubProcId)
            db.AddInParameter(cmd, "perId", DbType.String, loSolicitudes.PerId)
            db.AddInParameter(cmd, "procdId", DbType.String, loSolicitudes.procdId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar Solicitudes => " & ex.Message, ex)
        End Try
        Return True
    End Function

End Class