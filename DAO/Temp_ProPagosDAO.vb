Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class Temp_ProPagosDAO

#Region "Guardar"
    Public Shared Function guardar(ByVal aoTemp_ProPagos As EETemp_ProPagos) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Temp_ProPagos_pa")
            db.AddInParameter(cmd, "propaid", DbType.String, aoTemp_ProPagos.ProPaId)
            db.AddInParameter(cmd, "propaaño", DbType.String, aoTemp_ProPagos.ProPaAño)
            db.AddInParameter(cmd, "contid", DbType.String, aoTemp_ProPagos.ContId)
            db.AddInParameter(cmd, "perid", DbType.String, aoTemp_ProPagos.PerId)
            db.AddInParameter(cmd, "pernombre", DbType.String, aoTemp_ProPagos.Persona)
            db.AddInParameter(cmd, "contdescripcion", DbType.String, aoTemp_ProPagos.Contacto)
            db.AddInParameter(cmd, "propanrocuota", DbType.Int32, aoTemp_ProPagos.ProPaNroCuota)
            db.AddInParameter(cmd, "conid", DbType.String, aoTemp_ProPagos.ConId)
            db.AddInParameter(cmd, "connombre", DbType.String, aoTemp_ProPagos.ConNombre)
            db.AddInParameter(cmd, "propa_psaimt", DbType.Decimal, aoTemp_ProPagos.ProPa_PSaimt)
            db.AddInParameter(cmd, "propa_pmpt", DbType.Decimal, aoTemp_ProPagos.ProPa_PMpt)
            db.AddInParameter(cmd, "propafecven", DbType.Date, aoTemp_ProPagos.ProPaFecVen)
            db.AddInParameter(cmd, "propadetmonto", DbType.Decimal, aoTemp_ProPagos.ProPaDetMonto)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoTemp_ProPagos.TgEstadoId)
            db.AddInParameter(cmd, "propafecpag", DbType.Date, aoTemp_ProPagos.ProPaFecPag)
            db.AddInParameter(cmd, "propactasaimt", DbType.Decimal, aoTemp_ProPagos.ProPaCtaSaimt)
            db.AddInParameter(cmd, "propactampt", DbType.Decimal, aoTemp_ProPagos.ProPaCtaMpt)
            db.AddInParameter(cmd, "propamorasaimt", DbType.Decimal, aoTemp_ProPagos.ProPaMoraSaimt)
            db.AddInParameter(cmd, "propamorampt", DbType.Decimal, aoTemp_ProPagos.ProPaMoraMpt)
            db.AddInParameter(cmd, "propacomctasaimt", DbType.Decimal, aoTemp_ProPagos.ProPaComCtaSaimt)
            db.AddInParameter(cmd, "propacomctampt", DbType.Decimal, aoTemp_ProPagos.ProPaComCtaMpt)
            db.AddInParameter(cmd, "propatotal", DbType.Decimal, aoTemp_ProPagos.ProPaTotal)
            db.AddInParameter(cmd, "propaactualizado", DbType.Boolean, aoTemp_ProPagos.proPaActualizado)
            db.AddInParameter(cmd, "propafecact", DbType.Date, aoTemp_ProPagos.proPaFecAct)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Guardar Temp_ProPagos => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Actualizar"
    Public Shared Function actualizar(ByVal aoTemp_ProPagos As EETemp_ProPagos) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Temp_ProPagos_pa")

            db.AddInParameter(cmd, "propaid", DbType.String, aoTemp_ProPagos.ProPaId)
            db.AddInParameter(cmd, "propaaño", DbType.String, aoTemp_ProPagos.ProPaAño)
            db.AddInParameter(cmd, "contid", DbType.String, aoTemp_ProPagos.ContId)
            db.AddInParameter(cmd, "perid", DbType.String, aoTemp_ProPagos.PerId)
            db.AddInParameter(cmd, "pernombre", DbType.String, aoTemp_ProPagos.Persona)
            db.AddInParameter(cmd, "contdescripcion", DbType.String, aoTemp_ProPagos.Contacto)
            db.AddInParameter(cmd, "propanrocuota", DbType.Int32, aoTemp_ProPagos.ProPaNroCuota)
            db.AddInParameter(cmd, "conid", DbType.String, aoTemp_ProPagos.ConId)
            db.AddInParameter(cmd, "connombre", DbType.String, aoTemp_ProPagos.ConNombre)
            db.AddInParameter(cmd, "propa_psaimt", DbType.Decimal, aoTemp_ProPagos.ProPa_PSaimt)
            db.AddInParameter(cmd, "propa_pmpt", DbType.Decimal, aoTemp_ProPagos.ProPa_PMpt)
            db.AddInParameter(cmd, "propafecven", DbType.DateTime, aoTemp_ProPagos.ProPaFecVen)
            db.AddInParameter(cmd, "propadetmonto", DbType.Decimal, aoTemp_ProPagos.ProPaDetMonto)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoTemp_ProPagos.TgEstadoId)
            db.AddInParameter(cmd, "propafecpag", DbType.DateTime, aoTemp_ProPagos.ProPaFecPag)
            db.AddInParameter(cmd, "propactasaimt", DbType.Decimal, aoTemp_ProPagos.ProPaCtaSaimt)
            db.AddInParameter(cmd, "propactampt", DbType.Decimal, aoTemp_ProPagos.ProPaCtaMpt)
            db.AddInParameter(cmd, "propamorasaimt", DbType.Decimal, aoTemp_ProPagos.ProPaMoraSaimt)
            db.AddInParameter(cmd, "propamorampt", DbType.Decimal, aoTemp_ProPagos.ProPaMoraMpt)
            db.AddInParameter(cmd, "propacomctasaimt", DbType.Decimal, aoTemp_ProPagos.ProPaComCtaSaimt)
            db.AddInParameter(cmd, "propacomctampt", DbType.Decimal, aoTemp_ProPagos.ProPaComCtaMpt)
            db.AddInParameter(cmd, "propatotal", DbType.Decimal, aoTemp_ProPagos.ProPaTotal)
            db.AddInParameter(cmd, "propaactualizado", DbType.Boolean, aoTemp_ProPagos.proPaActualizado)
            db.AddInParameter(cmd, "propafecact", DbType.DateTime, aoTemp_ProPagos.proPaFecAct)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Actualizar Temp_ProPagos => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

    Public Shared Function eliminar(ByVal aiIdTemp_ProPagos As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Temp_ProPagos_pa")
            db.AddInParameter(cmd, "idTemp_ProPagos", DbType.Int32, aiIdTemp_ProPagos)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Eliminar Temp_ProPagos => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
