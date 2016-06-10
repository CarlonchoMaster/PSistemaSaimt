Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class GastoComisionDAO	
	Public Shared Function guardar(aoGastoComision As EEGastoComision) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_GastoComision_pa")
            db.AddInParameter(cmd, "gascomfec", DbType.DateTime, aoGastoComision.GasComFec)
			db.AddInParameter(cmd, "gascomvalor", DbType.Decimal, aoGastoComision.GasComValor)		
			db.AddInParameter(cmd, "tgrecaudadoraid", DbType.String, aoGastoComision.TgRecaudadoraId)		
			db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Guardar GastoComision => " + ex.Message, ex)
		End Try
		Return True
	End Function
	
	Public Shared Function actualizar(aoGastoComision As EEGastoComision) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_GastoComision_pa")
            db.AddInParameter(cmd, "gascomfec", DbType.DateTime, aoGastoComision.GasComFec)
			db.AddInParameter(cmd, "gascomvalor", DbType.Decimal, aoGastoComision.GasComValor)		
			db.AddInParameter(cmd, "tgrecaudadoraid", DbType.String, aoGastoComision.TgRecaudadoraId)		
			db.ExecuteNonQuery(cmd)
		
		Catch ex As Exception
			Throw New Exception("Actualizar GastoComision => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
	Public Shared Function eliminar(aiIdGastoComision As Int32) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_GastoComision_pa")
            db.AddInParameter(cmd, "idGastoComision", DbType.Int32, aiIdGastoComision)
			db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Eliminar GastoComision => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
	
End Class
