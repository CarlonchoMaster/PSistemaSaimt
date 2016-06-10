Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class PruebaDAO	
	Public Shared Function guardar(aoPrueba As EEPrueba) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Prueba_pa")
			
            'db.AddInParameter(cmd, "pruid", DbType.Int32, aoPrueba.PruId)		
			db.AddInParameter(cmd, "prunombre", DbType.String, aoPrueba.PruNombre)		
			db.AddInParameter(cmd, "prudescripcion", DbType.String, aoPrueba.PruDescripcion)		
			db.ExecuteNonQuery(cmd)
			
		Catch ex As Exception
			Throw New Exception("Guardar Prueba => " + ex.Message, ex)
		End Try
		Return True
	End Function
	
	Public Shared Function actualizar(aoPrueba As EEPrueba) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Prueba_pa")
			
			db.AddInParameter(cmd, "pruid", DbType.Int32, aoPrueba.PruId)		
			db.AddInParameter(cmd, "prunombre", DbType.String, aoPrueba.PruNombre)		
			db.AddInParameter(cmd, "prudescripcion", DbType.String, aoPrueba.PruDescripcion)		
			db.ExecuteNonQuery(cmd)
		
		Catch ex As Exception
			Throw New Exception("Actualizar Prueba => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
	Public Shared Function eliminar(aiIdPrueba As Int32) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Prueba_pa")
			
			db.AddInParameter(cmd, "idPrueba", DbType.Int32, aiIdPrueba)			
			db.ExecuteNonQuery(cmd)
			
		Catch ex As Exception
			Throw New Exception("Eliminar Prueba => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
End Class
