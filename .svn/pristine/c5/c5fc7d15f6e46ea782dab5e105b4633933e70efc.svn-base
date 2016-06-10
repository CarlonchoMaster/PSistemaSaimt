Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class EtapaSTDDAO

#Region "Guardar"
    Public Shared Function guardar(aoEtapaSTD As EEEtapaSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_EtapaSTD_pa")

            db.AddInParameter(cmd, "etainstarea", DbType.String, aoEtapaSTD.EtaInstArea)
            db.AddInParameter(cmd, "etanro", DbType.Int32, aoEtapaSTD.EtaNro)
            db.AddInParameter(cmd, "etanombre", DbType.String, aoEtapaSTD.EtaNombre)
            db.AddInParameter(cmd, "etamaxdia", DbType.Int32, aoEtapaSTD.EtaMaxDia)
            db.AddInParameter(cmd, "etamaxhoras", DbType.Decimal, aoEtapaSTD.EtaMaxHoras)
            db.AddInParameter(cmd, "etafinaliza", DbType.Boolean, aoEtapaSTD.EtaFinaliza)
            db.AddInParameter(cmd, "etaobservacion", DbType.String, aoEtapaSTD.EtaObservacion)
            db.AddInParameter(cmd, "procid", DbType.String, aoEtapaSTD.OProcedimientoSTD.ProcId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar EtapaSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Actualizar"
    Public Shared Function actualizar(aoEtapaSTD As EEEtapaSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_EtapaSTD_pa")

            db.AddInParameter(cmd, "etacod", DbType.String, aoEtapaSTD.EtaCod)
            db.AddInParameter(cmd, "etainstarea", DbType.String, aoEtapaSTD.EtaInstArea)
            db.AddInParameter(cmd, "etanro", DbType.Int32, aoEtapaSTD.EtaNro)
            db.AddInParameter(cmd, "etanombre", DbType.String, aoEtapaSTD.EtaNombre)
            db.AddInParameter(cmd, "etamaxdia", DbType.Int32, aoEtapaSTD.EtaMaxDia)
            db.AddInParameter(cmd, "etamaxhoras", DbType.Decimal, aoEtapaSTD.EtaMaxHoras)
            db.AddInParameter(cmd, "etafinaliza", DbType.Boolean, aoEtapaSTD.EtaFinaliza)
            db.AddInParameter(cmd, "etaobservacion", DbType.String, aoEtapaSTD.EtaObservacion)
            db.AddInParameter(cmd, "procid", DbType.String, aoEtapaSTD.OProcedimientoSTD.ProcId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar EtapaSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

    Public Shared Function eliminar(aiIdEtapaSTD As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_EtapaSTD_pa")

            db.AddInParameter(cmd, "idEtapaSTD", DbType.Int32, aiIdEtapaSTD)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar EtapaSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
