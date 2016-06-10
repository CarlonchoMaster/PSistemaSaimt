Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class TarifasPEMDAO	
	Public Shared Function guardar(aoTarifasPEM As EETarifasPEM) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase()
			Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_TarifasPEM_pa")
			
            db.AddInParameter(cmd, "conid", DbType.String, aoTarifasPEM.ConId)
			db.AddInParameter(cmd, "tarfini", DbType.DateTime, aoTarifasPEM.TarfIni)		
			db.AddInParameter(cmd, "tarffin", DbType.DateTime, aoTarifasPEM.TarfFin)		
            db.AddInParameter(cmd, "tgtipovehid", DbType.String, aoTarifasPEM.tgTipoVehId)
            db.AddInParameter(cmd, "tginstitucionid", DbType.String, aoTarifasPEM.tgInstitucionId)
            db.AddInParameter(cmd, "tgsedeid", DbType.String, aoTarifasPEM.tgSedeId)
            db.AddInParameter(cmd, "acuprecio", DbType.Decimal, aoTarifasPEM.AcuPrecio)
            db.AddInParameter(cmd, "tarfactivo", DbType.Boolean, aoTarifasPEM.TarfActivo)
            db.AddInParameter(cmd, "tarfnrodias", DbType.Int16, aoTarifasPEM.TarfNroDias)
            db.AddInParameter(cmd, "tarfnrohoras", DbType.Int16, aoTarifasPEM.TarfNroHoras)
            db.AddInParameter(cmd, "tgTipoClienteId", DbType.String, aoTarifasPEM.TgTipoClienteId)
			db.ExecuteNonQuery(cmd)
			
		Catch ex As Exception
			Throw New Exception("Guardar TarifasPEM => " + ex.Message, ex)
		End Try
		Return True
	End Function
	
	Public Shared Function actualizar(aoTarifasPEM As EETarifasPEM) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase()
			Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_TarifasPEM_pa")
			
            db.AddInParameter(cmd, "tarfid", DbType.String, aoTarifasPEM.TarfId)
            db.AddInParameter(cmd, "conid", DbType.String, aoTarifasPEM.ConId)
            db.AddInParameter(cmd, "tarfini", DbType.DateTime, aoTarifasPEM.tarfIni)
            db.AddInParameter(cmd, "tarffin", DbType.DateTime, aoTarifasPEM.tarfFin)
            db.AddInParameter(cmd, "tgtipovehid", DbType.String, aoTarifasPEM.tgTipoVehId)
            db.AddInParameter(cmd, "tginstitucionid", DbType.String, aoTarifasPEM.tgInstitucionId)
            db.AddInParameter(cmd, "tgsedeid", DbType.String, aoTarifasPEM.tgSedeId)
            db.AddInParameter(cmd, "acuprecio", DbType.Decimal, aoTarifasPEM.AcuPrecio)
            db.AddInParameter(cmd, "tarfactivo", DbType.Boolean, aoTarifasPEM.TarfActivo)
            db.AddInParameter(cmd, "tarfnrodias", DbType.Int16, aoTarifasPEM.TarfNroDias)
            db.AddInParameter(cmd, "tarfnrohoras", DbType.Int16, aoTarifasPEM.TarfNroHoras)
            db.AddInParameter(cmd, "tgTipoClienteId", DbType.String, aoTarifasPEM.TgTipoClienteId)
            db.ExecuteNonQuery(cmd)
		
		Catch ex As Exception
			Throw New Exception("Actualizar TarifasPEM => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
    Public Shared Function eliminar(ByVal aiIdTarifasPEM As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_TarifasPEM_pa")

            db.AddInParameter(cmd, "tarfid", DbType.String, aiIdTarifasPEM)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar TarifasPEM => " & ex.Message, ex)
        End Try
        Return True
    End Function
	

End Class
