Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class AcuerdoPEMDAO	
	Public Shared Function guardar(aoAcuerdoPEM As EEAcuerdoPEM) As Boolean
		Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
			Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_AcuerdoPEM_pa")
			
            db.AddInParameter(cmd, "nivid", DbType.String, aoAcuerdoPEM.NivId)
            db.AddInParameter(cmd, "tginstitucionid", DbType.String, aoAcuerdoPEM.tgInstitucionId)
            db.AddInParameter(cmd, "tgsedeid", DbType.String, aoAcuerdoPEM.tgSedeId)
            db.AddInParameter(cmd, "tarfid", DbType.String, aoAcuerdoPEM.TarfId)
			db.AddInParameter(cmd, "acuprecio", DbType.Decimal, aoAcuerdoPEM.AcuPrecio)		
            db.AddInParameter(cmd, "acufechaini", DbType.DateTime, aoAcuerdoPEM.AcuFechaIni)
			db.AddInParameter(cmd, "acufechafin", DbType.DateTime, aoAcuerdoPEM.AcuFechaFin)		
            db.AddInParameter(cmd, "acuestado", DbType.String, aoAcuerdoPEM.AcuEstado)
            db.AddInParameter(cmd, "perid", DbType.String, aoAcuerdoPEM.PerId)
			db.AddInParameter(cmd, "tgtipovehid", DbType.String, aoAcuerdoPEM.TgTipoVehId)		
            db.AddInParameter(cmd, "acunplaca1", DbType.String, aoAcuerdoPEM.AcuNPlaca1)
            db.AddInParameter(cmd, "acunplaca2", DbType.String, aoAcuerdoPEM.AcuNPlaca2)
            db.AddInParameter(cmd, "acunplaca3", DbType.String, aoAcuerdoPEM.AcuNPlaca3)
            db.AddInParameter(cmd, "acuhoini", DbType.DateTime, aoAcuerdoPEM.AcuHoIni)
            db.AddInParameter(cmd, "acuhofin", DbType.DateTime, aoAcuerdoPEM.AcuHoFin)
			db.AddInParameter(cmd, "acunespacio", DbType.Int32, aoAcuerdoPEM.AcuNEspacio)		
			db.ExecuteNonQuery(cmd)
			
		Catch ex As Exception
			Throw New Exception("Guardar AcuerdoPEM => " + ex.Message, ex)
		End Try
		Return True
	End Function
	
	Public Shared Function actualizar(aoAcuerdoPEM As EEAcuerdoPEM) As Boolean
		Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
			Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_AcuerdoPEM_pa")
			
            db.AddInParameter(cmd, "acuid", DbType.String, aoAcuerdoPEM.AcuId)
            db.AddInParameter(cmd, "tginstitucionid", DbType.String, aoAcuerdoPEM.tgInstitucionId)
            db.AddInParameter(cmd, "tgsedeid", DbType.String, aoAcuerdoPEM.tgSedeId)
			db.AddInParameter(cmd, "nivid", DbType.String, aoAcuerdoPEM.NivId)		
			db.AddInParameter(cmd, "tarfid", DbType.String, aoAcuerdoPEM.TarfId)		
			db.AddInParameter(cmd, "acuprecio", DbType.Decimal, aoAcuerdoPEM.AcuPrecio)		
            db.AddInParameter(cmd, "acufechaini", DbType.DateTime, aoAcuerdoPEM.AcuFechaIni)
			db.AddInParameter(cmd, "acufechafin", DbType.DateTime, aoAcuerdoPEM.AcuFechaFin)		
            db.AddInParameter(cmd, "acuestado", DbType.String, aoAcuerdoPEM.AcuEstado)
            db.AddInParameter(cmd, "perid", DbType.String, aoAcuerdoPEM.PerId)
			db.AddInParameter(cmd, "tgtipovehid", DbType.String, aoAcuerdoPEM.TgTipoVehId)		
            db.AddInParameter(cmd, "acunplaca1", DbType.String, aoAcuerdoPEM.AcuNPlaca1)
            db.AddInParameter(cmd, "acunplaca2", DbType.String, aoAcuerdoPEM.AcuNPlaca2)
            db.AddInParameter(cmd, "acunplaca3", DbType.String, aoAcuerdoPEM.AcuNPlaca3)
            db.AddInParameter(cmd, "acuhoini", DbType.DateTime, aoAcuerdoPEM.AcuHoIni)
            db.AddInParameter(cmd, "acuhofin", DbType.DateTime, aoAcuerdoPEM.AcuHoFin)
			db.AddInParameter(cmd, "acunespacio", DbType.Int32, aoAcuerdoPEM.AcuNEspacio)		
			db.ExecuteNonQuery(cmd)
		
		Catch ex As Exception
			Throw New Exception("Actualizar AcuerdoPEM => " & ex.Message, ex)
		End Try
		Return True
	End Function
	
    Public Shared Function eliminar(ByVal aiIdAcuerdoPEM As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_AcuerdoPEM_pa")

            db.AddInParameter(cmd, "acuId", DbType.String, aiIdAcuerdoPEM)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar AcuerdoPEM => " & ex.Message, ex)
        End Try
        Return True
    End Function
	
    Public Shared Function GeneraCodigo() As String
        Dim dr As IDataReader = Nothing
        Dim codigo As String = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_AcuerdoPEM")

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                codigo = dr("acuId").ToString()
            End If

        Catch ex As Exception
            Throw New Exception("Genera codigo => " & ex.Message, ex)
        End Try
        Return codigo
    End Function
End Class
