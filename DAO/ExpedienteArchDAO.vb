Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ExpedienteArchDAO
    Public Shared Function guardar(ByVal loExpedienteArch As EEExpedienteArch) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_ExpedienteArch_pa")

            db.AddInParameter(cmd, "jerid", DbType.String, loExpedienteArch.JerId)
            db.AddInParameter(cmd, "expsaimt", DbType.String, loExpedienteArch.ExpSAIMT)
            db.AddInParameter(cmd, "expfeching", DbType.DateTime, loExpedienteArch.ExpFechIng)
            db.AddInParameter(cmd, "expnrofolios", DbType.Int32, loExpedienteArch.ExpNroFolios)
            db.AddInParameter(cmd, "expobservaciones", DbType.String, loExpedienteArch.ExpObservaciones)
            db.AddInParameter(cmd, "expfechreg", DbType.DateTime, loExpedienteArch.ExpFechReg)
            'db.AddInParameter(cmd, "docnreg", DbType.String, loExpedienteArch.DocNReg)
            db.AddInParameter(cmd, "docref", DbType.String, loExpedienteArch.DocRef)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar ExpedienteArch => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal loExpedienteArch As EEExpedienteArch) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_ExpedienteArch_pa")

            db.AddInParameter(cmd, "jerid", DbType.String, loExpedienteArch.JerId)
            db.AddInParameter(cmd, "expsaimt", DbType.String, loExpedienteArch.ExpSAIMT)
            db.AddInParameter(cmd, "expfeching", DbType.DateTime, loExpedienteArch.ExpFechIng)
            db.AddInParameter(cmd, "expnrofolios", DbType.Int32, loExpedienteArch.ExpNroFolios)
            db.AddInParameter(cmd, "expobservaciones", DbType.String, loExpedienteArch.ExpObservaciones)
            '  db.AddInParameter(cmd, "expfechreg", DbType.DateTime, loExpedienteArch.ExpFechReg)
            db.AddInParameter(cmd, "docnreg", DbType.String, loExpedienteArch.DocNReg)
            db.AddInParameter(cmd, "docref", DbType.String, loExpedienteArch.DocRef)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar ExpedienteArch => " & ex.Message, ex)
        End Try
        Return True
    End Function


End Class
