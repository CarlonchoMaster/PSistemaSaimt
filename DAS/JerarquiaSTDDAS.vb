﻿Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class JerarquiaSTDDAS

#Region "Listar Criterio"
    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EEJerarquiaSTD)
        Dim ListaJerarquiaSTD As List(Of EEJerarquiaSTD) = Nothing
        Dim loJerarquiaSTD As EEJerarquiaSTD = Nothing
        Dim loTipoDocumento As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_JerarquiaSTD_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaJerarquiaSTD Is Nothing Then
                    ListaJerarquiaSTD = New List(Of EEJerarquiaSTD)()
                End If

                loJerarquiaSTD = New EEJerarquiaSTD()
                loJerarquiaSTD.Id = dr("Id").ToString()
                loJerarquiaSTD.Cargo = dr("nombreCargo").ToString()
                ListaJerarquiaSTD.Add(loJerarquiaSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar JerarquiaSTD Criterio => " & ex.Message, ex)
        End Try
        Return ListaJerarquiaSTD
    End Function
#End Region

#Region "Listar Criterio XTipoCriterio XId"
    Public Shared Function listarCriterioXTipoCriterio_XId(aiTipoCriterio As Int32, asId As [String]) As List(Of EEJerarquiaSTD)
        Dim ListaJerarquiaSTD As List(Of EEJerarquiaSTD) = Nothing
        Dim loJerarquiaSTD As EEJerarquiaSTD = Nothing
        Dim loTipoDocumento As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_JerarquiaSTD_XId_pa")
            db.AddInParameter(cmd, "id", DbType.String, asId)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaJerarquiaSTD Is Nothing Then
                    ListaJerarquiaSTD = New List(Of EEJerarquiaSTD)()
                End If

                loJerarquiaSTD = New EEJerarquiaSTD()
                loTipoDocumento = New EETablaGeneral()
                loTipoDocumento.TgCodigo = dr("tgTDocId").ToString()
                loTipoDocumento.TgNombre = dr("nombreTipoDocumento").ToString()

                loJerarquiaSTD.JerDeId = dr("JerDeId").ToString()
                loJerarquiaSTD.JerParaId = dr("JerParaId").ToString()

                loJerarquiaSTD.CodInstitucionOrigen = dr("codigoInstitucionOrigen").ToString()
                loJerarquiaSTD.InstitucionOrigen = dr("nombreInstitucionOrigen").ToString()
                loJerarquiaSTD.CodAreaOrigen = dr("codigoAreaOrigen").ToString()
                loJerarquiaSTD.AreaOrigen = dr("nombreAreaOrigen").ToString()
                loJerarquiaSTD.CodCargoOrigen = dr("codigoCargoOrigen").ToString()
                loJerarquiaSTD.CargoOrigen = dr("nombreCargoOrigen").ToString()

                loJerarquiaSTD.CodInstitucionDestino = dr("codigoInstitucionDestino").ToString()
                loJerarquiaSTD.InstitucionDestino = dr("nombreInstitucionDestino").ToString()
                loJerarquiaSTD.CodAreaDestino = dr("codigoAreaDestino").ToString()
                loJerarquiaSTD.AreaDestino = dr("nombreAreaDestino").ToString()
                loJerarquiaSTD.CodCargoDestino = dr("codigoCargoDestino").ToString()
                loJerarquiaSTD.CargoDestino = dr("nombreCargoDestino").ToString()


                loJerarquiaSTD.OTgTipoDocumento = loTipoDocumento
                loJerarquiaSTD.JerActivo = Convert.ToBoolean(dr("JerActivo").ToString())

                ListaJerarquiaSTD.Add(loJerarquiaSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar JerarquiaSTD X TipoCriterio XId => " & ex.Message, ex)
        End Try
        Return ListaJerarquiaSTD
    End Function

    Public Shared Function listarCargosDestinosXJerDeId_tgTDocId(JerDeId As String, tgTDocId As [String], tgExtra As String) As List(Of EEJerarquiaSTD)
        Dim ListaJerarquiaSTD As List(Of EEJerarquiaSTD) = Nothing
        Dim loJerarquiaSTD As EEJerarquiaSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_JerarquiaSTD_CargoDestinos_XjerDeId_tgTDocId_pa")
            db.AddInParameter(cmd, "jerDeId", DbType.String, JerDeId)
            db.AddInParameter(cmd, "tgTDocId", DbType.String, tgTDocId)
            db.AddInParameter(cmd, "tgExtra", DbType.String, tgExtra)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaJerarquiaSTD Is Nothing Then
                    ListaJerarquiaSTD = New List(Of EEJerarquiaSTD)()
                End If
                loJerarquiaSTD = New EEJerarquiaSTD()
                loJerarquiaSTD.CodCargoDestino = dr("TgCodigo").ToString()
                loJerarquiaSTD.CargoDestino = dr("TgNombre").ToString()
                loJerarquiaSTD.JerActivo = Convert.ToBoolean(dr("JerActivo").ToString())
                ListaJerarquiaSTD.Add(loJerarquiaSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar JerarquiaSTD Cargo Destino X JerDeId y tgTDocId => " & ex.Message, ex)
        End Try
        Return ListaJerarquiaSTD
    End Function

    Public Shared Function listarCargosDestinosXJerDeId_tgAreaId(ByVal JerDeId As String, ByVal tgAreaId As [String], Optional ByVal tgInstId As String = "0001") As List(Of EEJerarquiaSTD)
        Dim ListaJerarquiaSTD As List(Of EEJerarquiaSTD) = Nothing
        Dim loJerarquiaSTD As EEJerarquiaSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_JerarquiaSTD_CargoDestinos_XjerDeId_tgAreaId_pa")
            db.AddInParameter(cmd, "jerDeId", DbType.String, JerDeId)
            db.AddInParameter(cmd, "tgAreaId", DbType.String, tgAreaId)
            db.AddInParameter(cmd, "tgInstId", DbType.String, tgInstId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaJerarquiaSTD Is Nothing Then
                    ListaJerarquiaSTD = New List(Of EEJerarquiaSTD)()
                End If
                loJerarquiaSTD = New EEJerarquiaSTD()
                loJerarquiaSTD.CodCargoDestino = dr("TgCodigo").ToString()
                loJerarquiaSTD.CargoDestino = dr("TgNombre").ToString()
                'loJerarquiaSTD.JerActivo = Convert.ToBoolean(dr("JerActivo").ToString())
                ListaJerarquiaSTD.Add(loJerarquiaSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar JerarquiaSTD Cargo Destino X JerDeId y tgAreaId => " & ex.Message, ex)
        End Try
        Return ListaJerarquiaSTD
    End Function

    Public Shared Function listarAreasDestinosXJerDeId(ByVal JerDeId As String, Optional ByVal tgInstId As String = "0001") As List(Of EEJerarquiaSTD)
        Dim ListaJerarquiaSTD As List(Of EEJerarquiaSTD) = Nothing
        Dim loJerarquiaSTD As EEJerarquiaSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_JerarquiaSTD_AreasDestinos_XjerDeId_pa")
            db.AddInParameter(cmd, "jerDeId", DbType.String, JerDeId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaJerarquiaSTD Is Nothing Then
                    ListaJerarquiaSTD = New List(Of EEJerarquiaSTD)()
                End If
                loJerarquiaSTD = New EEJerarquiaSTD()
                loJerarquiaSTD.CodAreaDestino = dr("tgCodigo").ToString()
                loJerarquiaSTD.AreaDestino = dr("tgNombre").ToString()
                ListaJerarquiaSTD.Add(loJerarquiaSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar JerarquiaSTD Area Destino X JerDeId => " & ex.Message, ex)
        End Try
        Return ListaJerarquiaSTD
    End Function

    Public Shared Function listarAreasDestinosXJerDeId_tgTDocId(JerDeId As String, tgTDocId As [String], tgExtra As String) As List(Of EEJerarquiaSTD)
        Dim ListaJerarquiaSTD As List(Of EEJerarquiaSTD) = Nothing
        Dim loJerarquiaSTD As EEJerarquiaSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_JerarquiaSTD_AreasDestinos_XjerDeId_tgTDocId_pa")
            db.AddInParameter(cmd, "jerDeId", DbType.String, JerDeId)
            db.AddInParameter(cmd, "tgTDocId", DbType.String, tgTDocId)
            db.AddInParameter(cmd, "tgExtra", DbType.String, tgExtra)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaJerarquiaSTD Is Nothing Then
                    ListaJerarquiaSTD = New List(Of EEJerarquiaSTD)()
                End If
                loJerarquiaSTD = New EEJerarquiaSTD()
                loJerarquiaSTD.CodAreaDestino = dr("tgCodigo").ToString()
                loJerarquiaSTD.AreaDestino = dr("tgNombre").ToString()
                loJerarquiaSTD.JerActivo = Convert.ToBoolean(dr("JerActivo").ToString())
                ListaJerarquiaSTD.Add(loJerarquiaSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar JerarquiaSTD Area Destino X JerDeId y tgTDocId => " & ex.Message, ex)
        End Try
        Return ListaJerarquiaSTD
    End Function

    Public Shared Function listarInsititucionDestinosXJerDeId_tgTDocId(JerDeId As String, tgTDocId As [String]) As List(Of EEJerarquiaSTD)
        Dim ListaJerarquiaSTD As List(Of EEJerarquiaSTD) = Nothing
        Dim loJerarquiaSTD As EEJerarquiaSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_JerarquiaSTD_InstitucionDestinos_XjerDeId_tgTDocId_pa")
            db.AddInParameter(cmd, "jerDeId", DbType.String, JerDeId)
            db.AddInParameter(cmd, "tgTDocId", DbType.String, tgTDocId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaJerarquiaSTD Is Nothing Then
                    ListaJerarquiaSTD = New List(Of EEJerarquiaSTD)()
                End If
                loJerarquiaSTD = New EEJerarquiaSTD()
                loJerarquiaSTD.CodInstitucionDestino = dr("tgCodigo").ToString()
                loJerarquiaSTD.InstitucionDestino = dr("tgNombre").ToString()
                loJerarquiaSTD.JerActivo = Convert.ToBoolean(dr("JerActivo").ToString())
                ListaJerarquiaSTD.Add(loJerarquiaSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar JerarquiaSTD Institucion Destino X JerDeId y tgTDocId => " & ex.Message, ex)
        End Try
        Return ListaJerarquiaSTD
    End Function

    Public Shared Function listarTipoDocumentosXJerDeId_JerParaId(ByVal JerDeId As String, ByVal JerParaId As [String]) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_JerarquiaSTD_TipoDoc_XjerDeId_jerParaId_pa")
            db.AddInParameter(cmd, "jerDeId", DbType.String, JerDeId)
            db.AddInParameter(cmd, "jerParaId", DbType.String, JerParaId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral
                loTablaGeneral.TgNombre = dr("tgNombre").ToString()
                loTablaGeneral.TgCodigo = dr("tgCodigo").ToString()
                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar JerarquiaSTD Institucion Destino X JerDeId y tgTDocId => " & ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function
#End Region

End Class