Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class AbonExtornoDAO	
    Public Shared Function guardarExtonoAbono(aoAbonExtorno As EEAbonExtorno) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_AbonExtorno_Abono_pa")

            db.AddInParameter(cmd, "abonid", DbType.String, aoAbonExtorno.OAbonoPEM.AbonId)
            db.AddInParameter(cmd, "tgtipoextid", DbType.String, aoAbonExtorno.OTgTipoExt.TgCodigo)
            db.AddInParameter(cmd, "extobservacion", DbType.String, aoAbonExtorno.ExtObservacion)
            db.AddInParameter(cmd, "ExtDesdeCuota", DbType.String, aoAbonExtorno.ExtDesdeCuota)
            db.AddInParameter(cmd, "perExtId", DbType.String, aoAbonExtorno.ExtPerId)
            db.ExecuteNonQuery(cmd)

            cmd = db.GetStoredProcCommand("Actualizar_AbonoPEM_ExtornoAbono_pa")
            db.AddInParameter(cmd, "abonid", DbType.String, aoAbonExtorno.OAbonoPEM.AbonId)
            db.AddInParameter(cmd, "cuotaDesde", DbType.String, aoAbonExtorno.ExtDesdeCuota)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar AbonExtorno Abono => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function guardarListaExtornosAbono(ByVal loAbonExtorno As List(Of EEAbonExtorno)) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            If loAbonExtorno IsNot Nothing Then
                For Each aoAbonExtorno As EEAbonExtorno In loAbonExtorno
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_AbonExtorno_Abono_pa")
                    db.AddInParameter(cmd, "abonid", DbType.String, aoAbonExtorno.OAbonoPEM.AbonId)
                    db.AddInParameter(cmd, "tgtipoextid", DbType.String, aoAbonExtorno.OTgTipoExt.TgCodigo)
                    db.AddInParameter(cmd, "extobservacion", DbType.String, aoAbonExtorno.ExtObservacion)
                    db.AddInParameter(cmd, "ExtDesdeCuota", DbType.String, aoAbonExtorno.ExtDesdeCuota)
                    db.AddInParameter(cmd, "perExtId", DbType.String, aoAbonExtorno.ExtPerId)
                    db.ExecuteNonQuery(cmd)

                    cmd = db.GetStoredProcCommand("Actualizar_AbonoPEM_ExtornoAbono_XAbonId_pa")
                    db.AddInParameter(cmd, "abonid", DbType.String, aoAbonExtorno.OAbonoPEM.AbonId)
                    db.AddInParameter(cmd, "cuotaDesde", DbType.String, aoAbonExtorno.ExtDesdeCuota)
                    db.ExecuteNonQuery(cmd)
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Guardar AbonExtorno Abono => " & ex.Message, ex)
        End Try
        Return True
    End Function
    Public Shared Function guardarRinconadaExtornoDiario(ByVal aoAbonExtorno As EEAbonExtorno) As Boolean
        Try
            Dim transferido As Boolean = False
            If guardarRinconadaExtornoDiario_Remoto(aoAbonExtorno) = True Then
                transferido = True
            End If

            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_DiarioRinconadaExtorno_pa")

            db.AddInParameter(cmd, "diarioid", DbType.Int32, aoAbonExtorno.DiarioId)
            db.AddInParameter(cmd, "tgtipoextid", DbType.String, aoAbonExtorno.OTgTipoExt.TgCodigo)
            db.AddInParameter(cmd, "extobservacion", DbType.String, aoAbonExtorno.ExtObservacion)
            db.AddInParameter(cmd, "perExtId", DbType.String, aoAbonExtorno.ExtPerId)
            db.AddInParameter(cmd, "transferido", DbType.String, transferido)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar AbonExtorno Diario => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function guardarRinconadaExtornoDiario_Remoto(ByVal aoAbonExtorno As EEAbonExtorno) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDRemoto)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_DiarioRinconadaExtorno_Remoto_pa")

            db.AddInParameter(cmd, "diarioCod", DbType.String, aoAbonExtorno.DiarioCod)
            db.AddInParameter(cmd, "tgtipoextid", DbType.String, aoAbonExtorno.OTgTipoExt.TgCodigo)
            db.AddInParameter(cmd, "extobservacion", DbType.String, aoAbonExtorno.ExtObservacion)
            db.AddInParameter(cmd, "perExtId", DbType.String, aoAbonExtorno.ExtPerId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar AbonExtorno Remoto Diario => " & ex.Message, ex)
        End Try
        Return True
    End Function


    Public Shared Function guardarExtonoDiario(aoAbonExtorno As EEAbonExtorno) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_AbonExtorno_Diario_pa")

            db.AddInParameter(cmd, "diarioid", DbType.Int32, aoAbonExtorno.DiarioId)
            db.AddInParameter(cmd, "tgtipoextid", DbType.String, aoAbonExtorno.OTgTipoExt.TgCodigo)
            db.AddInParameter(cmd, "extobservacion", DbType.String, aoAbonExtorno.ExtObservacion)
            db.AddInParameter(cmd, "perExtId", DbType.String, aoAbonExtorno.ExtPerId)
            db.ExecuteNonQuery(cmd)

            cmd = db.GetStoredProcCommand("Actualizar_DiarioPEM_ExtornoDiario_pa")
            db.AddInParameter(cmd, "diarioid", DbType.Int32, aoAbonExtorno.DiarioId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar AbonExtorno Diario => " & ex.Message, ex)
        End Try
        Return True
    End Function
	
End Class
