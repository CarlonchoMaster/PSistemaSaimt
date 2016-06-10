Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ClaseDAO	
#Region "Guardar"
    Public Shared Function guardar(aoClase As EEClase) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Clase_pa")

            db.AddInParameter(cmd, "clsnombre", DbType.String, aoClase.ClsNombre)
            db.AddInParameter(cmd, "clsdescripcion", DbType.String, aoClase.ClsDescripcion)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar Clase => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Actualizar"
    Public Shared Function actualizar(aoClase As EEClase) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Clase_pa")

            db.AddInParameter(cmd, "clsid", DbType.Int32, aoClase.ClsId)
            db.AddInParameter(cmd, "clsnombre", DbType.String, aoClase.ClsNombre)
            db.AddInParameter(cmd, "clsdescripcion", DbType.String, aoClase.ClsDescripcion)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar Clase => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region
	
    Public Shared Function eliminar(ByVal aiIdClase As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Clase_pa")

            db.AddInParameter(cmd, "idClase", DbType.Int32, aiIdClase)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Clase => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
