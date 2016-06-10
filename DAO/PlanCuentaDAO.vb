Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class PlanCuentaDAO	
	Public Shared Function guardar(aoPlanCuenta As EEPlanCuenta) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_PlanCuenta_pa")
			
			db.AddInParameter(cmd, "plancid", DbType.String, aoPlanCuenta.PlanCId)		
			db.AddInParameter(cmd, "plancaño", DbType.Int32, aoPlanCuenta.PlanCAño)		
			db.AddInParameter(cmd, "plancdescripcion", DbType.String, aoPlanCuenta.PlanCDescripcion)		
			db.AddInParameter(cmd, "plancctadebe", DbType.String, aoPlanCuenta.PlanCCtaDebe)		
			db.AddInParameter(cmd, "plancctahaber", DbType.String, aoPlanCuenta.PlanCCtaHaber)		
            db.AddInParameter(cmd, "planctipocuenta", DbType.Int32, aoPlanCuenta.TgPlanCTipoCuenta.TgCodigo)
            db.AddInParameter(cmd, "planctipoauxiliar", DbType.Int32, aoPlanCuenta.TgPlanCTipoAuxiliar.TgCodigo)
			db.ExecuteNonQuery(cmd)
			
		Catch ex As Exception
			Throw New Exception("Guardar PlanCuenta => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
	Public Shared Function actualizar(aoPlanCuenta As EEPlanCuenta) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_PlanCuenta_pa")
			
			db.AddInParameter(cmd, "plancid", DbType.String, aoPlanCuenta.PlanCId)		
			db.AddInParameter(cmd, "plancaño", DbType.Int32, aoPlanCuenta.PlanCAño)		
			db.AddInParameter(cmd, "plancdescripcion", DbType.String, aoPlanCuenta.PlanCDescripcion)		
			db.AddInParameter(cmd, "plancctadebe", DbType.String, aoPlanCuenta.PlanCCtaDebe)		
			db.AddInParameter(cmd, "plancctahaber", DbType.String, aoPlanCuenta.PlanCCtaHaber)		
            db.AddInParameter(cmd, "planctipocuenta", DbType.Int32, aoPlanCuenta.TgPlanCTipoCuenta.TgCodigo)
            db.AddInParameter(cmd, "planctipoauxiliar", DbType.Int32, aoPlanCuenta.TgPlanCTipoAuxiliar.TgCodigo)
			db.ExecuteNonQuery(cmd)
		
		Catch ex As Exception
			Throw New Exception("Actualizar PlanCuenta => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
    Public Shared Function eliminar(aoPlanCuenta As EEPlanCuenta) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_PlanCuenta_pa")

            db.AddInParameter(cmd, "plancid", DbType.String, aoPlanCuenta.PlanCId)
            db.AddInParameter(cmd, "plancaño", DbType.Int32, aoPlanCuenta.PlanCAño)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar PlanCuenta => " & ex.Message, ex)
        End Try
        Return True
    End Function
	
	
End Class
