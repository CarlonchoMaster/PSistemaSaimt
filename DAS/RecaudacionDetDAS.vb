﻿Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class RecaudacionDetDAS
    Public Shared Function listarRinconadaXPreTrasDelDia(ByVal fechapag As Date) As List(Of EERecaudacionDet)
        Dim ListaRecaudacionDet As List(Of EERecaudacionDet) = Nothing
        Dim loRecaudacionDet As EERecaudacionDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_RecaudacionDet_PreTras_DelDia_pa")
            db.AddInParameter(cmd, "recFecPago", DbType.Date, fechapag)
            
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaRecaudacionDet Is Nothing Then
                    ListaRecaudacionDet = New List(Of EERecaudacionDet)()
                End If
                loRecaudacionDet = New EERecaudacionDet()
                loRecaudacionDet.RecId = Convert.ToInt32(dr("RecId").ToString())
                loRecaudacionDet.RecFecPago = IIf(IsDBNull(dr("RecFecPago")), Nothing, dr("RecFecPago"))
                loRecaudacionDet.TgRecaudadorId = dr("TgRecaudadorId").ToString()
                loRecaudacionDet.ConId = dr("ConId").ToString()

                loRecaudacionDet.RecDMonto = Convert.ToDouble(dr("RecDMonto").ToString())
                loRecaudacionDet.ConPorcentaje = Convert.ToDouble(dr("ConPorcentaje").ToString())
                loRecaudacionDet.RecDTotalIng = Convert.ToDouble(dr("RecDTotalIng").ToString())
                If dr("recDFechaLiquidacion") Is DBNull.Value Then
                    loRecaudacionDet.RecDFechaLiquidacion = CDate("12:00:00 a.m.")
                Else
                    loRecaudacionDet.RecDFechaLiquidacion = CDate(dr("recDFechaLiquidacion"))
                End If
                If dr("recDFechaReg") Is DBNull.Value Then
                    loRecaudacionDet.RecDFechaReg = CDate("12:00:00 a.m.")
                Else
                    loRecaudacionDet.RecDFechaReg = CDate(dr("recDFechaReg"))
                End If
                ListaRecaudacionDet.Add(loRecaudacionDet)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Tranferencia => " + ex.Message, ex)
        End Try
        Return ListaRecaudacionDet
    End Function


    Public Shared Function listar_by_fechaPag_RecaudadorId(ByVal fechapag As Date, Optional ByVal RecaudadorId As String = Nothing) As List(Of EERecaudacionDet)
        Dim ListaRecaudacionDet As List(Of EERecaudacionDet) = Nothing
        Dim loRecaudacionDet As EERecaudacionDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_RecaudacionDet_by_recFecPago_tgRecaudadorId_pa")
            db.AddInParameter(cmd, "recFecPago", DbType.Date, fechapag)
            If RecaudadorId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRecaudadorId", DbType.String, RecaudadorId)
            End If
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaRecaudacionDet Is Nothing Then
                    ListaRecaudacionDet = New List(Of EERecaudacionDet)()
                End If
                loRecaudacionDet = New EERecaudacionDet()
                loRecaudacionDet.RecId = Convert.ToInt32(dr("RecId").ToString())
                loRecaudacionDet.RecFecPago = IIf(IsDBNull(dr("RecFecPago")), Nothing, dr("RecFecPago"))
                loRecaudacionDet.TgRecaudadorId = dr("TgRecaudadorId").ToString()
                loRecaudacionDet.ConId = dr("ConId").ToString()
                loRecaudacionDet.Concepto = dr("Concepto").ToString()
                loRecaudacionDet.RecDMonto = Convert.ToDouble(dr("RecDMonto").ToString())
                loRecaudacionDet.ConPorcentaje = Convert.ToDouble(dr("ConPorcentaje").ToString())
                loRecaudacionDet.RecDTotalIng = Convert.ToDouble(dr("RecDTotalIng").ToString())
                If dr("recDFechaLiquidacion") Is DBNull.Value Then
                    loRecaudacionDet.RecDFechaLiquidacion = CDate("12:00:00 a.m.")
                Else
                    loRecaudacionDet.RecDFechaLiquidacion = CDate(dr("recDFechaLiquidacion"))
                End If
                ListaRecaudacionDet.Add(loRecaudacionDet)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("listar_by_fechaPag_RecaudadorId => " + ex.Message, ex)
        End Try
        Return ListaRecaudacionDet
    End Function

    Public Shared Function listar_by_fechaPag_GrupoConId(ByVal fechapag As Date, Optional ByVal GrupoConId As String = Nothing) As List(Of EERecaudacionDet)
        Dim ListaRecaudacionDet As List(Of EERecaudacionDet) = Nothing
        Dim loRecaudacionDet As EERecaudacionDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_RecaudacionDet_by_recFecPago_tgGrupoConId_pa")
            db.AddInParameter(cmd, "recFecPago", DbType.Date, fechapag)
            If GrupoConId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGrupoConId", DbType.String, GrupoConId)
            End If
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaRecaudacionDet Is Nothing Then
                    ListaRecaudacionDet = New List(Of EERecaudacionDet)()
                End If
                loRecaudacionDet = New EERecaudacionDet()
                loRecaudacionDet.RecId = Convert.ToInt32(dr("RecId").ToString())
                loRecaudacionDet.RecFecPago = IIf(IsDBNull(dr("RecFecPago")), Nothing, dr("RecFecPago"))
                loRecaudacionDet.TgRecaudadorId = dr("TgRecaudadorId").ToString()
                loRecaudacionDet.ConId = dr("ConId").ToString()
                loRecaudacionDet.Concepto = dr("Concepto").ToString()
                loRecaudacionDet.RecDMonto = Convert.ToDouble(dr("RecDMonto").ToString())
                loRecaudacionDet.ConPorcentaje = Convert.ToDouble(dr("ConPorcentaje").ToString())
                loRecaudacionDet.RecDTotalIng = Convert.ToDouble(dr("RecDTotalIng").ToString())
                If dr("recDFechaLiquidacion") Is DBNull.Value Then
                    loRecaudacionDet.RecDFechaLiquidacion = CDate("12:00:00 a.m.")
                Else
                    loRecaudacionDet.RecDFechaLiquidacion = CDate(dr("recDFechaLiquidacion"))
                End If
                If dr("tgGrupoConId") Is DBNull.Value Then
                    loRecaudacionDet.tgGrupoConId = String.Empty
                Else
                    loRecaudacionDet.tgGrupoConId = Trim(dr("tgGrupoConId"))
                End If
                If dr("pcontCuenA") Is DBNull.Value Then
                    loRecaudacionDet.pcontCuenA = String.Empty
                Else
                    loRecaudacionDet.pcontCuenA = Trim(dr("pcontCuenA"))
                End If
                If dr("pcontCuenC") Is DBNull.Value Then
                    loRecaudacionDet.pcontCuenC = String.Empty
                Else
                    loRecaudacionDet.pcontCuenC = Trim(dr("pcontCuenC"))
                End If
                ListaRecaudacionDet.Add(loRecaudacionDet)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("listar_by_fechaPag_GrupoConId => " + ex.Message, ex)
        End Try
        Return ListaRecaudacionDet
    End Function

    Public Shared Function listar_by_recid_fechaPag_recdid(ByVal recid As String, ByVal fechapag As Date, ByVal recdid As String) As List(Of EERecaudacionDet)
        Dim ListaRecaudacionDet As List(Of EERecaudacionDet) = Nothing
        Dim loRecaudacionDet As EERecaudacionDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_RecaudacionDet_by_recId_recFecPago_tgRecaudadorId_pa")
            db.AddInParameter(cmd, "recid", DbType.String, recid)
            db.AddInParameter(cmd, "recFecPago", DbType.Date, fechapag)
            db.AddInParameter(cmd, "tgRecaudadorId", DbType.String, recdid)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaRecaudacionDet Is Nothing Then
                    ListaRecaudacionDet = New List(Of EERecaudacionDet)()
                End If

                loRecaudacionDet = New EERecaudacionDet()

                loRecaudacionDet.RecId = Convert.ToInt32(dr("RecId").ToString())
                loRecaudacionDet.RecFecPago = IIf(IsDBNull(dr("RecFecPago")), Nothing, dr("RecFecPago"))
                loRecaudacionDet.TgRecaudadorId = dr("TgRecaudadorId").ToString()
                loRecaudacionDet.ConId = dr("ConId").ToString()
                loRecaudacionDet.Concepto = dr("Concepto").ToString()
                loRecaudacionDet.RecDMonto = Convert.ToDouble(dr("RecDMonto").ToString())
                loRecaudacionDet.ConPorcentaje = Convert.ToDouble(dr("ConPorcentaje").ToString())
                loRecaudacionDet.RecDTotalIng = Convert.ToDouble(dr("RecDTotalIng").ToString())
                If dr("recDFechaLiquidacion") Is DBNull.Value Then
                    loRecaudacionDet.RecDFechaLiquidacion = CDate("12:00:00 a.m.")
                Else
                    loRecaudacionDet.RecDFechaLiquidacion = CDate(dr("recDFechaLiquidacion"))
                End If
                ListaRecaudacionDet.Add(loRecaudacionDet)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar RecaudacionDet Criterio => " + ex.Message, ex)
        End Try
        Return ListaRecaudacionDet
    End Function

    Public Shared Function listarALL() As List(Of EERecaudacionDet)
        Dim ListaRecaudacionDet As List(Of EERecaudacionDet) = Nothing
        Dim loRecaudacionDet As EERecaudacionDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_RecaudacionDet_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaRecaudacionDet Is Nothing Then
                    ListaRecaudacionDet = New List(Of EERecaudacionDet)()
                End If

                loRecaudacionDet = New EERecaudacionDet()

                loRecaudacionDet.RecId = Convert.ToInt32(dr("RecId").ToString())
                loRecaudacionDet.RecFecPago = IIf(IsDBNull(dr("RecFecPago")), Nothing, dr("RecFecPago"))
                loRecaudacionDet.TgRecaudadorId = dr("TgRecaudadorId").ToString()
                loRecaudacionDet.ConId = dr("ConId").ToString()
                loRecaudacionDet.RecDMonto = Convert.ToDouble(dr("RecDMonto").ToString())
                loRecaudacionDet.ConPorcentaje = Convert.ToDouble(dr("ConPorcentaje").ToString())
                loRecaudacionDet.RecDTotalIng = Convert.ToDouble(dr("RecDTotalIng").ToString())
                loRecaudacionDet.RecDFechaReg = IIf(IsDBNull(dr("RecDFechaReg")), Nothing, dr("RecDFechaReg"))
                loRecaudacionDet.UsuId = Convert.ToInt32(dr("UsuId").ToString())
                loRecaudacionDet.RecDEstado = dr("RecDEstado").ToString()
                ListaRecaudacionDet.Add(loRecaudacionDet)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ALL RecaudacionDet => " & ex.Message, ex)
        End Try
        Return ListaRecaudacionDet
    End Function
End Class
