Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class GrupoFormulariosDAO	
	Public Shared Function guardar(aoGrupoFormularios As EEGrupoFormularios) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_GrupoFormularios_pa")
			
			db.AddInParameter(cmd, "grfnombre", DbType.String, aoGrupoFormularios.GrfNombre)		
			db.AddInParameter(cmd, "grfdescripcion", DbType.String, aoGrupoFormularios.GrfDescripcion)		
			db.ExecuteNonQuery(cmd)
			
		Catch ex As Exception
			Throw New Exception("Guardar GrupoFormularios => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
	Public Shared Function actualizar(aoGrupoFormularios As EEGrupoFormularios) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_GrupoFormularios_pa")
			
			db.AddInParameter(cmd, "grfid", DbType.Int32, aoGrupoFormularios.GrfId)		
			db.AddInParameter(cmd, "grfnombre", DbType.String, aoGrupoFormularios.GrfNombre)		
			db.AddInParameter(cmd, "grfdescripcion", DbType.String, aoGrupoFormularios.GrfDescripcion)		
			db.ExecuteNonQuery(cmd)
		
		Catch ex As Exception
			Throw New Exception("Actualizar GrupoFormularios => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
	Public Shared Function eliminar(aiIdGrupoFormularios As Int32) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_GrupoFormularios_pa")
			
			db.AddInParameter(cmd, "idGrupoFormularios", DbType.Int32, aiIdGrupoFormularios)			
			db.ExecuteNonQuery(cmd)
			
		Catch ex As Exception
			Throw New Exception("Eliminar GrupoFormularios => " & ex.Message, ex)
		End Try
		Return True
	End Function
End Class
