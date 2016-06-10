Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class NivelesPEMDAO	
	Public Shared Function guardar(aoNivelesPEM As EENivelesPEM) As Boolean
		Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_NivelesPEM_pa")

			db.AddInParameter(cmd, "nivnombre", DbType.String, aoNivelesPEM.NivNombre)		
			db.AddInParameter(cmd, "nivespinicio", DbType.Int32, aoNivelesPEM.NivEspInicio)		
			db.AddInParameter(cmd, "nivespfin", DbType.Int32, aoNivelesPEM.NivEspFin)		
            db.AddInParameter(cmd, "nivactivo", DbType.Boolean, aoNivelesPEM.NivActivo)
            db.AddInParameter(cmd, "tginstitucionid", DbType.String, aoNivelesPEM.tgInstitucionId)
            db.AddInParameter(cmd, "tgsedeid", DbType.String, aoNivelesPEM.tgSedeId)
            db.AddInParameter(cmd, "tgnpisoid", DbType.String, aoNivelesPEM.ONroPiso.TgCodigo)

			db.ExecuteNonQuery(cmd)
			
		Catch ex As Exception
			Throw New Exception("Guardar NivelesPEM => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
	Public Shared Function actualizar(aoNivelesPEM As EENivelesPEM) As Boolean
		Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
			Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_NivelesPEM_pa")
			
			db.AddInParameter(cmd, "nivid", DbType.String, aoNivelesPEM.NivId)		
			db.AddInParameter(cmd, "nivnombre", DbType.String, aoNivelesPEM.NivNombre)		
			db.AddInParameter(cmd, "nivespinicio", DbType.Int32, aoNivelesPEM.NivEspInicio)		
			db.AddInParameter(cmd, "nivespfin", DbType.Int32, aoNivelesPEM.NivEspFin)		
            db.AddInParameter(cmd, "nivactivo", DbType.Boolean, aoNivelesPEM.NivActivo)
            db.AddInParameter(cmd, "tginstitucionid", DbType.String, aoNivelesPEM.tgInstitucionId)
            db.AddInParameter(cmd, "tgsedeid", DbType.String, aoNivelesPEM.tgSedeId)
            db.AddInParameter(cmd, "tgnpisoid", DbType.String, aoNivelesPEM.ONroPiso.TgCodigo)
			db.ExecuteNonQuery(cmd)
		
		Catch ex As Exception
			Throw New Exception("Actualizar NivelesPEM => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
    Public Shared Function eliminar(ByVal aiIdNivelesPEM As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_NivelesPEM_pa")

            db.AddInParameter(cmd, "nivid", DbType.String, aiIdNivelesPEM)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar NivelesPEM => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
