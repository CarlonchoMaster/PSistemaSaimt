Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class AbonoPEMDAO	
	Public Shared Function guardar(aoAbonoPEM As EEAbonoPEM) As Boolean
		Try
			Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
			Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_AbonoPEM_pa")
			
            db.AddInParameter(cmd, "perid", DbType.String, aoAbonoPEM.OPersona.PerId)
            db.AddInParameter(cmd, "conid", DbType.String, aoAbonoPEM.OConcepto.ConId)
            db.AddInParameter(cmd, "abonfechaini", DbType.DateTime, aoAbonoPEM.AbonFechaIni)
            db.AddInParameter(cmd, "abonfechafin", DbType.DateTime, aoAbonoPEM.AbonFechaFin)
            db.AddInParameter(cmd, "abonHoraini", DbType.Time, aoAbonoPEM.AbonHoraIni)
            db.AddInParameter(cmd, "abonHorafin", DbType.Time, aoAbonoPEM.AbonHoraFin)
            db.AddInParameter(cmd, "abonAplicaHora", DbType.Boolean, aoAbonoPEM.abonAplicaHora)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoAbonoPEM.OTgEstado.TgCodigo)
            db.AddInParameter(cmd, "perregistra", DbType.String, aoAbonoPEM.PerRegistra)
            db.AddInParameter(cmd, "abonnplaca1", DbType.String, aoAbonoPEM.AbonNPlaca1)
            db.AddInParameter(cmd, "abonimporte", DbType.Decimal, aoAbonoPEM.AbonImporte)
            db.AddInParameter(cmd, "abonnplaca2", DbType.String, aoAbonoPEM.AbonNPlaca2)
            db.AddInParameter(cmd, "tgnivelid", DbType.String, aoAbonoPEM.OTgNivel.TgCodigo)
            db.AddInParameter(cmd, "abonnroespacio", DbType.Int32, aoAbonoPEM.AbonNroEspacio)
            db.AddInParameter(cmd, "abonnromeses", DbType.Int32, aoAbonoPEM.AbonNroMeses)
            db.AddInParameter(cmd, "abonnplaca3", DbType.String, aoAbonoPEM.AbonNPlaca3)
            db.AddInParameter(cmd, "tgtipovehid", DbType.String, aoAbonoPEM.OTgTipoVehiculo.TgCodigo)
			db.ExecuteNonQuery(cmd)
			
		Catch ex As Exception
			Throw New Exception("Guardar AbonoPEM => " & ex.Message, ex)
		End Try
		Return True
    End Function

    Public Shared Function Actualizar(ByVal aoAbonoPEM As EEAbonoPEM) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_AbonoPEM_pa")

            db.AddInParameter(cmd, "AbonId", DbType.String, aoAbonoPEM.AbonId)
            db.AddInParameter(cmd, "abonnplaca1", DbType.String, aoAbonoPEM.AbonNPlaca1)
            db.AddInParameter(cmd, "abonnplaca2", DbType.String, aoAbonoPEM.AbonNPlaca2)
            db.AddInParameter(cmd, "abonnplaca3", DbType.String, aoAbonoPEM.AbonNPlaca3)

            If aoAbonoPEM.abonReprogramar = True Then
                db.AddInParameter(cmd, "abonReprogramar", DbType.Boolean, IIf(aoAbonoPEM.abonReprogramar = True, 1, 0))
                db.AddInParameter(cmd, "conid", DbType.String, aoAbonoPEM.OConcepto.ConId)
                db.AddInParameter(cmd, "abonfechaini", DbType.DateTime, aoAbonoPEM.AbonFechaIni)
                db.AddInParameter(cmd, "abonfechafin", DbType.DateTime, aoAbonoPEM.AbonFechaFin)
                db.AddInParameter(cmd, "abonHoraini", DbType.Time, aoAbonoPEM.AbonHoraIni)
                db.AddInParameter(cmd, "abonHorafin", DbType.Time, aoAbonoPEM.AbonHoraFin)
                db.AddInParameter(cmd, "abonAplicaHora", DbType.Boolean, aoAbonoPEM.abonAplicaHora)
                db.AddInParameter(cmd, "perregistra", DbType.String, aoAbonoPEM.PerRegistra)
                db.AddInParameter(cmd, "abonimporte", DbType.Decimal, aoAbonoPEM.AbonImporte)
                db.AddInParameter(cmd, "tgnivelid", DbType.String, aoAbonoPEM.OTgNivel.TgCodigo)
                db.AddInParameter(cmd, "abonnroespacio", DbType.Int32, aoAbonoPEM.AbonNroEspacio)
                db.AddInParameter(cmd, "abonnromeses", DbType.Int32, aoAbonoPEM.AbonNroMeses)
                db.AddInParameter(cmd, "tgtipovehid", DbType.String, aoAbonoPEM.OTgTipoVehiculo.TgCodigo)
            End If
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar AbonoPEM => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function guardarDetalle(aoAbonoPEM As EEAbonoPEM) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = Nothing

            For Each fDetalle As EEAbonoPEM.EEAbonoDetPEM In aoAbonoPEM.ListaAbonoDetPEM.FindAll(Function(ac) ac.GuardarOrUpdate = False)
                cmd = db.GetStoredProcCommand("Insertar_AbonoDetPEM_pa")
                db.AddInParameter(cmd, "abondetnrocuota", DbType.Int32, fDetalle.AbonDetNroCuota)
                db.AddInParameter(cmd, "abondetfechaini", DbType.DateTime, fDetalle.AbonDetFechaIni)
                db.AddInParameter(cmd, "abondetfechafin", DbType.DateTime, fDetalle.AbonDetFechaFin)
                db.AddInParameter(cmd, "abondetfecpago", DbType.DateTime, fDetalle.AbonDetFecPago)
                db.AddInParameter(cmd, "tgestadoid", DbType.String, fDetalle.OTgEstado.TgCodigo)
                db.AddInParameter(cmd, "abondetpagado", DbType.Boolean, fDetalle.AbonDetPagado)
                db.AddInParameter(cmd, "abondetimporte", DbType.Decimal, fDetalle.AbonDetImporte)
                db.AddInParameter(cmd, "abonid", DbType.String, aoAbonoPEM.AbonId)
                db.AddInParameter(cmd, "abondetperreg", DbType.String, fDetalle.AbonDetPerReg)
                db.ExecuteNonQuery(cmd)
            Next

            For Each fDetalle As EEAbonoPEM.EEAbonoDetPEM In aoAbonoPEM.ListaAbonoDetPEM.FindAll(Function(ac) ac.GuardarOrUpdate = True)
                cmd = db.GetStoredProcCommand("Actualizar_AbonoDetPEM_pa")
                db.AddInParameter(cmd, "abondetid", DbType.String, fDetalle.AbonDetId)
                db.AddInParameter(cmd, "tgestadoid", DbType.String, fDetalle.OTgEstado.TgCodigo)
                db.AddInParameter(cmd, "abondetpagado", DbType.Boolean, fDetalle.AbonDetPagado)
                db.AddInParameter(cmd, "abondetperreg", DbType.String, fDetalle.AbonDetPerReg)
                db.ExecuteNonQuery(cmd)
            Next
        Catch ex As Exception
            Throw New Exception("Guardar Detalle => " & ex.Message, ex)
        End Try
        Return True
    End Function
	
    'Public Shared Function actualizar(aoAbonoPEM As EEAbonoPEM) As Boolean
    '	Try
    '		Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '		Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_AbonoPEM_pa")

    '		db.AddInParameter(cmd, "perid", DbType.String, aoAbonoPEM.PerId)		
    '		db.AddInParameter(cmd, "abonid", DbType.String, aoAbonoPEM.AbonId)		
    '		db.AddInParameter(cmd, "conid", DbType.String, aoAbonoPEM.ConId)		
    '		db.AddInParameter(cmd, "abonfechaini", DbType.DateTime, aoAbonoPEM.AbonFechaIni)		
    '		db.AddInParameter(cmd, "abonfechafin", DbType.DateTime, aoAbonoPEM.AbonFechaFin)		
    '           db.AddInParameter(cmd, "abonhorareg", DbType.Time, aoAbonoPEM.AbonHoraReg)
    '		db.AddInParameter(cmd, "abonfechareg", DbType.DateTime, aoAbonoPEM.AbonFechaReg)		
    '		db.AddInParameter(cmd, "tgestadoid", DbType.String, aoAbonoPEM.TgEstadoId)		
    '		db.AddInParameter(cmd, "perregistra", DbType.String, aoAbonoPEM.PerRegistra)		
    '		db.AddInParameter(cmd, "abonnplaca", DbType.String, aoAbonoPEM.AbonNPlaca)		
    '		db.AddInParameter(cmd, "abonimporte", DbType.Decimal, aoAbonoPEM.AbonImporte)		
    '		db.ExecuteNonQuery(cmd)

    '	Catch ex As Exception
    '		Throw New Exception("Actualizar AbonoPEM => " & ex.Message, ex)
    '	End Try
    '	Return True
    'End Function
	
    'Public Shared Function eliminar(aiIdAbonoPEM As Int32) As Boolean
    '	Try
    '		Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '		Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_AbonoPEM_pa")

    '		db.AddInParameter(cmd, "idAbonoPEM", DbType.Int32, aiIdAbonoPEM)			
    '		db.ExecuteNonQuery(cmd)

    '	Catch ex As Exception
    '		Throw New Exception("Eliminar AbonoPEM => " & ex.Message, ex)
    '	End Try
    '	Return True
    'End Function	
End Class
