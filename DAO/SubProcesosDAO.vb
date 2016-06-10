Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class SubProcesosDAO

    Public Shared Function InsertarU(ByVal listaSubProcesos As List(Of EESubProcesos)) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand
            For Each loSubProcesos As EESubProcesos In listaSubProcesos
                cmd = db.GetStoredProcCommand("InsertarU_SubProcesos_pa")
                db.AddInParameter(cmd, "procid", DbType.String, loSubProcesos.ProcId)
                db.AddInParameter(cmd, "subprocnombre", DbType.String, loSubProcesos.SubProcNombre)
                db.AddInParameter(cmd, "subprocdescripcion", DbType.String, loSubProcesos.SubProcDescripcion)
                db.AddInParameter(cmd, "subprocactivo", DbType.Boolean, loSubProcesos.SubProcActivo)
                db.AddInParameter(cmd, "subprocid", DbType.String, loSubProcesos.SubProcId)
                db.ExecuteNonQuery(cmd)
            Next


        Catch ex As Exception
            Throw New Exception("Actualizar SubProcesos => " & ex.Message, ex)
        End Try
        Return True
    End Function

End Class
