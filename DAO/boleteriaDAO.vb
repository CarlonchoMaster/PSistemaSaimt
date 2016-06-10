﻿Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades
Public Class boleteriaDAO

    Public Shared Function guardarTrasferencia(ByVal aoBoleteria As EEBoleteriaRinconada) As String
        Dim DiarioCodigo As String = String.Empty
        Try

            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDRemoto)
            Dim cmd As DbCommand = db.GetStoredProcCommand("InsertarU_TransferenciaBoleteriaRinconada_pa")
            db.AddInParameter(cmd, "bolfechaing", DbType.DateTime, aoBoleteria.bolFechaIng)
            db.AddInParameter(cmd, "bolprecio", DbType.Decimal, aoBoleteria.bolPrecio)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoBoleteria.TgEstadoId)
            db.AddInParameter(cmd, "bolhoraing", DbType.DateTime, aoBoleteria.bolHoraIng)
            db.AddInParameter(cmd, "conid", DbType.String, aoBoleteria.ConId)
            db.AddInParameter(cmd, "perregid", DbType.String, aoBoleteria.PerRegId)
            db.AddInParameter(cmd, "PerRegExtId", DbType.String, aoBoleteria.PerRegExtId)
            db.AddInParameter(cmd, "bolCantidad", DbType.Int32, aoBoleteria.bolcantidad)
            db.AddInParameter(cmd, "bolcod", DbType.String, aoBoleteria.bolCod)
            db.AddOutParameter(cmd, "bolId", DbType.Int32, 9)
            db.ExecuteNonQuery(cmd)
            DiarioCodigo = db.GetParameterValue(cmd, "bolId")
        Catch ex As Exception
            Throw New Exception("Guardar Boleteria => " & ex.Message, ex)
        End Try
        Return DiarioCodigo
    End Function


    Public Shared Function guardar(ByVal aoBoleteria As EEBoleteriaRinconada) As Boolean

        Dim Enviado As Boolean = False
        Try
            If guardarRemoto(aoBoleteria) = True Then
                Enviado = True
            End If
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("InsertarU_BoleteriaRinconada_pa")
            db.AddInParameter(cmd, "bolid", DbType.Int32, aoBoleteria.bolId)
            db.AddInParameter(cmd, "bolfechaing", DbType.DateTime, aoBoleteria.bolFechaIng)
            db.AddInParameter(cmd, "bolprecio", DbType.Decimal, aoBoleteria.bolPrecio)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoBoleteria.TgEstadoId)
            db.AddInParameter(cmd, "bolhoraing", DbType.DateTime, aoBoleteria.bolHoraIng)
            db.AddInParameter(cmd, "conid", DbType.String, aoBoleteria.ConId)
            db.AddInParameter(cmd, "perregid", DbType.String, aoBoleteria.PerRegId)
            db.AddInParameter(cmd, "bolCantidad", DbType.Int32, aoBoleteria.bolcantidad)
            db.AddInParameter(cmd, "bolTransferido", DbType.Boolean, Enviado)
            db.AddInParameter(cmd, "bolcod", DbType.String, aoBoleteria.bolCod)
            db.ExecuteNonQuery(cmd)
            'DiarioCodigo = db.GetParameterValue(cmd, "bolcod")
        Catch ex As Exception
            Throw New Exception("Guardar Boleteria => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function guardarRemoto(ByVal aoBoleteria As EEBoleteriaRinconada) As Boolean
        'Dim DiarioCodigo As String = String.Empty
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDRemoto)
            Dim cmd As DbCommand = db.GetStoredProcCommand("InsertarU_BoleteriaRinconada_Remoto_pa")
            db.AddInParameter(cmd, "bolid", DbType.Int32, aoBoleteria.bolId)
            db.AddInParameter(cmd, "bolfechaing", DbType.DateTime, aoBoleteria.bolFechaIng)
            db.AddInParameter(cmd, "bolprecio", DbType.Decimal, aoBoleteria.bolPrecio)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoBoleteria.TgEstadoId)
            db.AddInParameter(cmd, "bolhoraing", DbType.DateTime, aoBoleteria.bolHoraIng)
            db.AddInParameter(cmd, "conid", DbType.String, aoBoleteria.ConId)
            db.AddInParameter(cmd, "perregid", DbType.String, aoBoleteria.PerRegId)
            db.AddInParameter(cmd, "bolCantidad", DbType.Int32, aoBoleteria.bolcantidad)
            db.AddInParameter(cmd, "bolcod", DbType.String, aoBoleteria.bolCod)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            ' Throw New Exception("Guardar Boleteria => " & ex.Message, ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function ListarPreparaTrasferenciaRinconadaXDia(ByVal bolFechaIng As Date) As List(Of EEBoleteriaRinconada)
        Dim ListaBoleteria As List(Of EEBoleteriaRinconada) = Nothing
        Dim loBoleteria As EEBoleteriaRinconada = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_BoleteriaRinconadaPreTras_DelDia_pa")
            db.AddInParameter(cmd, "bolFechaIng", DbType.DateTime, bolFechaIng)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaBoleteria Is Nothing Then
                    ListaBoleteria = New List(Of EEBoleteriaRinconada)
                End If
                loBoleteria = New EEBoleteriaRinconada()
                loBoleteria.bolCod = dr("bolCod").ToString()
                loBoleteria.bolFechaIng = IIf(IsDBNull(dr("bolFechaIng")), Nothing, dr("bolFechaIng"))
                loBoleteria.bolPrecio = Convert.ToDecimal(dr("bolPrecio").ToString())
                loBoleteria.bolcantidad = dr("bolCantidad").ToString
                loBoleteria.TgEstadoId = dr("tgEstadoId").ToString
                loBoleteria.bolHoraIng = String.Format("{0} {1}", Date.Now.Date.ToShortDateString, IIf(IsDBNull(dr("bolHoraIng")), Nothing, dr("bolHoraIng")))
                loBoleteria.PerRegId = dr("PerRegEntId").ToString
                loBoleteria.PerRegExtId = dr("PerRegExtId").ToString
                loBoleteria.ConId = dr("ConId").ToString
                loBoleteria.ConId = dr("ConId").ToString
                loBoleteria.bolModificado = dr("bolModificado").ToString
                loBoleteria.bolTransferido = dr("boltrasferido").ToString
                ListaBoleteria.Add(loBoleteria)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Boleteria => " + ex.Message, ex)
        End Try
        Return ListaBoleteria
    End Function

    Public Shared Function ListardelDia(ByVal bolFechaIng As Date) As List(Of EEBoleteriaRinconada)
        Dim ListaBoleteria As List(Of EEBoleteriaRinconada) = Nothing
        Dim loBoleteria As EEBoleteriaRinconada = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_BoleteriaRinconada_DelDia_pa")
            db.AddInParameter(cmd, "bolFechaIng", DbType.DateTime, bolFechaIng)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaBoleteria Is Nothing Then
                    ListaBoleteria = New List(Of EEBoleteriaRinconada)
                End If
                loBoleteria = New EEBoleteriaRinconada()
                loBoleteria.bolId = Convert.ToInt32(dr("bolId").ToString())
                loBoleteria.bolCod = dr("bolCod").ToString()
                loBoleteria.bolFechaIng = IIf(IsDBNull(dr("bolFechaIng")), Nothing, dr("bolFechaIng"))
                loBoleteria.bolPrecio = Convert.ToDecimal(dr("bolPrecio").ToString())
                loBoleteria.bolcantidad = dr("bolCantidad").ToString
                loBoleteria.TgEstado = dr("tgEstado").ToString
                loBoleteria.bolHoraIng = String.Format("{0} {1}", Date.Now.Date.ToShortDateString, IIf(IsDBNull(dr("bolHoraIng")), Nothing, dr("bolHoraIng")))
                ListaBoleteria.Add(loBoleteria)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Boleteria => " + ex.Message, ex)
        End Try
        Return ListaBoleteria
    End Function


    Public Shared Function ExtornarXBolCod(ByVal bolCod As String) As Boolean

        '  Dim dr As IDataReader = Nothing
        Dim bolModificado As Boolean = True
        Try
            If ExtornarXbolCod_Remoto(bolCod) = True Then
                bolModificado = False
            End If

            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_bolRinconada_Extornar_pa")
            db.AddInParameter(cmd, "bolCod", DbType.String, bolCod)
            db.AddInParameter(cmd, "bolModificado", DbType.Boolean, bolModificado)

            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Extornar Boleteria => " + ex.Message, ex)
        End Try
        Return True
    End Function


    Public Shared Function ExtornarXbolCod_Remoto(ByVal bolCod As String) As Boolean

        ' Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDRemoto)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_bolRinconada_Extornar_Remoto_pa")
            db.AddInParameter(cmd, "bolCod", DbType.String, bolCod)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            ' Throw New Exception("Extornar Boleteria => " + ex.Message, ex)
            Return False
        End Try
        Return True
    End Function

End Class
