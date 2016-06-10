Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class DiarioPEMDAO	
    Public Shared Function guardar(ByVal aoDiarioPEM As EEDiarioPEM) As String
        Dim DiarioCodigo As String = String.Empty
        Try

            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("InsertarU_DiarioPEM_pa")

            db.AddInParameter(cmd, "diarioid", DbType.Int32, aoDiarioPEM.DiarioId)
            db.AddInParameter(cmd, "dianplaca", DbType.String, aoDiarioPEM.DiaNPlaca)
            db.AddInParameter(cmd, "diafechaing", DbType.DateTime, aoDiarioPEM.DiaFechaIng)
            db.AddInParameter(cmd, "diafechasal", DbType.DateTime, aoDiarioPEM.DiaFechaSal)
            db.AddInParameter(cmd, "diaprecio", DbType.Decimal, aoDiarioPEM.DiaPrecio)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoDiarioPEM.TgEstadoId)
            db.AddInParameter(cmd, "diahoraing", DbType.DateTime, aoDiarioPEM.DiaHoraIng)
            db.AddInParameter(cmd, "diahorasal", DbType.DateTime, aoDiarioPEM.DiaHoraSal)
            db.AddInParameter(cmd, "tgtipoabonoid", DbType.String, aoDiarioPEM.TgTipoAbonoId)
            db.AddInParameter(cmd, "conid", DbType.String, aoDiarioPEM.ConId)
            db.AddInParameter(cmd, "perregid", DbType.String, aoDiarioPEM.PerRegId)
            db.AddInParameter(cmd, "abonDetid", DbType.String, aoDiarioPEM.AbonDetId)
            db.AddOutParameter(cmd, "diariocod", DbType.String, 9)
            db.ExecuteNonQuery(cmd)
            DiarioCodigo = db.GetParameterValue(cmd, "diariocod")
        Catch ex As Exception
            Throw New Exception("Guardar DiarioPEM => " & ex.Message, ex)
        End Try
        Return DiarioCodigo
    End Function

    Public Shared Function ActualizarRinconada(ByVal aoDiarioCRR As EEDiarioPEM) As String
        Dim DiarioCodigo As String = String.Empty
        Dim diamodificado As Boolean = False
        Try

            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_DiarioRinconada_pa")

            db.AddInParameter(cmd, "diafechasal", DbType.DateTime, aoDiarioCRR.DiaFechaSal)
            db.AddInParameter(cmd, "diaprecio", DbType.Decimal, aoDiarioCRR.DiaPrecio)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoDiarioCRR.TgEstadoId)
            db.AddInParameter(cmd, "diahorasal", DbType.DateTime, aoDiarioCRR.DiaHoraSal)
            db.AddInParameter(cmd, "perregid", DbType.String, aoDiarioCRR.PerRegId)
            db.AddInParameter(cmd, "diarioId", DbType.String, aoDiarioCRR.DiarioId)
            db.AddOutParameter(cmd, "diariocod", DbType.String, 9)
            db.ExecuteNonQuery(cmd)
            DiarioCodigo = db.GetParameterValue(cmd, "diariocod")
            aoDiarioCRR.DiarioCod = DiarioCodigo
            If ActualizarRinconadaRemoto(aoDiarioCRR) = False Then
                ActualizardiaModificado(aoDiarioCRR.DiarioCod, True)
            End If
        Catch ex As Exception
            Throw New Exception("Update Diario Rinconada => " & ex.Message, ex)
        End Try
        Return DiarioCodigo
    End Function

    Public Shared Function ActualizardiaModificado(ByVal DiarioCod As String, ByVal diamodificado As Boolean) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDRemoto)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_DiarioRinconada_DiaModificado_pa")
            db.AddInParameter(cmd, "diariocod", DbType.String, DiarioCod)
            db.AddInParameter(cmd, "diamodificado", DbType.Boolean, diamodificado)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function



    Public Shared Function ActualizarRinconadaRemoto(ByVal aoDiarioCRR As EEDiarioPEM) As Boolean
        ' Dim diamodificado As Boolean = False
        Try

            'If guardarRemoto(aoDiarioCRR) = True Then
            '    diamodificado = True
            'End If

            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDRemoto)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_DiarioRinconada_Remoto_pa")

            db.AddInParameter(cmd, "diafechasal", DbType.DateTime, aoDiarioCRR.DiaFechaSal)
            db.AddInParameter(cmd, "diaprecio", DbType.Decimal, aoDiarioCRR.DiaPrecio)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoDiarioCRR.TgEstadoId)
            db.AddInParameter(cmd, "diahorasal", DbType.DateTime, aoDiarioCRR.DiaHoraSal)
            db.AddInParameter(cmd, "perregid", DbType.String, aoDiarioCRR.PerRegId)
            db.AddInParameter(cmd, "diariocod", DbType.String, aoDiarioCRR.DiarioCod)
            ' db.AddInParameter(cmd, "diamodificado", DbType.Boolean, diamodificado)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Shared Function guardarRinconada(ByVal aoDiarioPEM As EEDiarioPEM) As Boolean
        ' Dim DiarioCodigo As String = String.Empty
        Dim diatransferido As Boolean = False
        Try

            If guardarRemoto(aoDiarioPEM) = True Then
                diatransferido = True
            End If

            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("InsertarU_DiarioRinconada_pa")

            db.AddInParameter(cmd, "diarioid", DbType.Int32, aoDiarioPEM.DiarioId)
            db.AddInParameter(cmd, "dianplaca", DbType.String, aoDiarioPEM.DiaNPlaca)
            db.AddInParameter(cmd, "diafechaing", DbType.DateTime, aoDiarioPEM.DiaFechaIng)
            db.AddInParameter(cmd, "diafechasal", DbType.DateTime, aoDiarioPEM.DiaFechaSal)
            db.AddInParameter(cmd, "diaprecio", DbType.Decimal, aoDiarioPEM.DiaPrecio)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoDiarioPEM.TgEstadoId)
            db.AddInParameter(cmd, "diahoraing", DbType.DateTime, aoDiarioPEM.DiaHoraIng)
            db.AddInParameter(cmd, "diahorasal", DbType.DateTime, aoDiarioPEM.DiaHoraSal)
            db.AddInParameter(cmd, "tgtipoabonoid", DbType.String, aoDiarioPEM.TgTipoAbonoId)
            db.AddInParameter(cmd, "conid", DbType.String, aoDiarioPEM.ConId)
            db.AddInParameter(cmd, "perregid", DbType.String, aoDiarioPEM.PerRegId)
            db.AddInParameter(cmd, "diariocod", DbType.String, aoDiarioPEM.DiarioCod)
            db.AddInParameter(cmd, "diatransferido", DbType.Boolean, diatransferido)
            db.ExecuteNonQuery(cmd)
            'DiarioCodigo = db.GetParameterValue(cmd, "diariocod")
        Catch ex As Exception
            Throw New Exception("Guardar DiarioPEM => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function guardarRemoto(ByVal aoDiarioPEM As EEDiarioPEM) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDRemoto)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_DiarioRinconada_Remoto_pa")
            db.AddInParameter(cmd, "dianplaca", DbType.String, aoDiarioPEM.DiaNPlaca)
            db.AddInParameter(cmd, "diafechaing", DbType.DateTime, aoDiarioPEM.DiaFechaIng)
            db.AddInParameter(cmd, "diafechasal", DbType.DateTime, aoDiarioPEM.DiaFechaSal)
            db.AddInParameter(cmd, "diaprecio", DbType.Decimal, aoDiarioPEM.DiaPrecio)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoDiarioPEM.TgEstadoId)
            db.AddInParameter(cmd, "diahoraing", DbType.DateTime, aoDiarioPEM.DiaHoraIng)
            db.AddInParameter(cmd, "diahorasal", DbType.DateTime, aoDiarioPEM.DiaHoraSal)
            db.AddInParameter(cmd, "tgtipoabonoid", DbType.String, aoDiarioPEM.TgTipoAbonoId)
            db.AddInParameter(cmd, "conid", DbType.String, aoDiarioPEM.ConId)
            db.AddInParameter(cmd, "perregid", DbType.String, aoDiarioPEM.PerRegId)
            db.AddInParameter(cmd, "diariocod", DbType.String, aoDiarioPEM.DiarioCod)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function


    Public Shared Function guardarTransferencia(ByVal aoDiarioPEM As EEDiarioPEM) As Boolean
        Try

            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDRemoto)
            Dim cmd As DbCommand = db.GetStoredProcCommand("InsertarU_TransferenciaDiarioRinconada_pa")
            db.AddInParameter(cmd, "dianplaca", DbType.String, aoDiarioPEM.DiaNPlaca)
            db.AddInParameter(cmd, "diafechaing", DbType.DateTime, aoDiarioPEM.DiaFechaIng)
            db.AddInParameter(cmd, "diafechasal", DbType.DateTime, aoDiarioPEM.DiaFechaSal)
            db.AddInParameter(cmd, "diaprecio", DbType.Decimal, aoDiarioPEM.DiaPrecio)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoDiarioPEM.TgEstadoId)
            db.AddInParameter(cmd, "diahoraing", DbType.DateTime, aoDiarioPEM.DiaHoraIng)
            db.AddInParameter(cmd, "diahorasal", DbType.DateTime, aoDiarioPEM.DiaHoraSal)
            db.AddInParameter(cmd, "tgtipoabonoid", DbType.String, aoDiarioPEM.TgTipoAbonoId)
            db.AddInParameter(cmd, "conid", DbType.String, aoDiarioPEM.ConId)
            db.AddInParameter(cmd, "perRegEntId", DbType.String, aoDiarioPEM.PerRegEntId)
            db.AddInParameter(cmd, "perRegSalId", DbType.String, aoDiarioPEM.PerRegSalId)
            db.AddInParameter(cmd, "diariocod", DbType.String, aoDiarioPEM.DiarioCod)
            db.AddInParameter(cmd, "diarioId", DbType.String, aoDiarioPEM.DiarioId)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Shared Function ComprobacionXAbonId(ByVal asAbonId As String) As Boolean
        Try

            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Comprobacion_DiariaPEM_XAbonId")

            db.AddInParameter(cmd, "abonId", DbType.String, asAbonId)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Comprobacion DiarioPEM xAbonId => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
