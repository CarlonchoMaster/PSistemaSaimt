Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class RecaudacionDetDAO
    Public Shared Function guardar(aoRecaudacionDet As EERecaudacionDet) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_RecaudacionDet_pa")

            db.AddInParameter(cmd, "recid", DbType.Int32, aoRecaudacionDet.RecId)
            db.AddInParameter(cmd, "recfecpago", DbType.DateTime, aoRecaudacionDet.RecFecPago)
            db.AddInParameter(cmd, "tgrecaudadorid", DbType.String, aoRecaudacionDet.TgRecaudadorId)
            db.AddInParameter(cmd, "conid", DbType.String, aoRecaudacionDet.ConId)
            db.AddInParameter(cmd, "recdmonto", DbType.Decimal, aoRecaudacionDet.RecDMonto)
            db.AddInParameter(cmd, "conporcentaje", DbType.Decimal, aoRecaudacionDet.ConPorcentaje)
            db.AddInParameter(cmd, "recdtotaling", DbType.Decimal, aoRecaudacionDet.RecDTotalIng)
            db.AddInParameter(cmd, "recDFechaLiquidacion", DbType.DateTime, aoRecaudacionDet.RecDFechaLiquidacion)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar RecaudacionDet => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function guardarTranferencia(ByVal aoRecaudacionDet As EERecaudacionDet, ByVal RecID As Int16) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDRemoto)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_RecaudacionDet_Trasnferencia_pa")
            db.AddInParameter(cmd, "recid", DbType.Int32, RecID)
            db.AddInParameter(cmd, "recfecpago", DbType.DateTime, aoRecaudacionDet.RecFecPago)
            db.AddInParameter(cmd, "tgrecaudadorid", DbType.String, aoRecaudacionDet.TgRecaudadorId)
            db.AddInParameter(cmd, "conid", DbType.String, aoRecaudacionDet.ConId)
            db.AddInParameter(cmd, "recdmonto", DbType.Decimal, aoRecaudacionDet.RecDMonto)
            db.AddInParameter(cmd, "conporcentaje", DbType.Decimal, aoRecaudacionDet.ConPorcentaje)
            db.AddInParameter(cmd, "recdtotaling", DbType.Decimal, aoRecaudacionDet.RecDTotalIng)
            db.AddInParameter(cmd, "recDFechaLiquidacion", DbType.DateTime, aoRecaudacionDet.RecDFechaLiquidacion)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Guardar RecaudacionDet => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(ByVal aoRecaudacionDet As EERecaudacionDet, ByVal aoTipoCriterio As Integer) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_RecaudacionDet_pa")
            db.AddInParameter(cmd, "tipocriterio", DbType.Int32, aoTipoCriterio)
            db.AddInParameter(cmd, "recid", DbType.Int32, aoRecaudacionDet.RecId)
            db.AddInParameter(cmd, "recfecpago", DbType.DateTime, aoRecaudacionDet.RecFecPago)
            db.AddInParameter(cmd, "tgrecaudadorid", DbType.String, aoRecaudacionDet.TgRecaudadorId)
            db.AddInParameter(cmd, "conId", DbType.String, aoRecaudacionDet.ConId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar RecaudacionDet => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function ValidaMontoRec(aoRecaudacionDet As EERecaudacionDet) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("valida_Recaudacion_RecaudacionDet_XrecDMonto_pa")

            db.AddInParameter(cmd, "recid", DbType.Int32, aoRecaudacionDet.RecId)
            db.AddInParameter(cmd, "recfecpago", DbType.DateTime, aoRecaudacionDet.RecFecPago)
            db.AddInParameter(cmd, "tgrecaudadorid", DbType.String, aoRecaudacionDet.TgRecaudadorId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Valida RecaudacionDet => " & ex.Message, ex)
        End Try
        Return True
    End Function

End Class

