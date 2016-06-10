Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class CargoPersonalDAS
    Public Shared Function listarxPerId(perID As String) As List(Of EECargoPersonal)
        Dim listaCargoPersonal As List(Of EECargoPersonal) = Nothing
        Dim loCargoPersonal As EECargoPersonal = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try

            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CargoPersonal_XPerId_pa")
            db.AddInParameter(cmd, "perId", DbType.String, perID)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If listaCargoPersonal Is Nothing Then
                    listaCargoPersonal = New List(Of EECargoPersonal)()
                End If

                loCargoPersonal = New EECargoPersonal()
                loCargoPersonal.CarPerId = dr("CarPerId").ToString()
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("NombreTipoCargo").ToString()
                loTablaGeneral.TgCodigo = dr("TgTipoCargoId").ToString()
                loCargoPersonal.OTgTipoCargo = loTablaGeneral

                If Not IsDBNull(dr("CarPerFechaIni")) Then
                    loCargoPersonal.CarPerFechaIni = Convert.ToDateTime(dr("CarPerFechaIni"))
                End If

                If Not IsDBNull(dr("CarPerFechaFin")) Then
                    loCargoPersonal.CarPerFechaFin = Convert.ToDateTime(dr("CarPerFechaFin"))
                End If
                loCargoPersonal.TgEstadoId = Convert.ToBoolean(dr("TgEstadoId").ToString())
                loCargoPersonal.Institucion = dr("NombreInstitucion").ToString()
                loCargoPersonal.CodInstitucion = dr("CodigoInstitucion").ToString()
                loCargoPersonal.Area = dr("NombreArea").ToString()
                loCargoPersonal.CodArea = dr("CodigoArea").ToString()
                loCargoPersonal.Cargo = dr("NombreCargo").ToString()
                loCargoPersonal.CodCargo = dr("CodigoCargo").ToString()
                listaCargoPersonal.Add(loCargoPersonal)
            End While

            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoPersonal Criterio => " & ex.Message, ex)
        End Try
        Return listaCargoPersonal

    End Function


    Public Shared Function MostrarxPerId(ByVal perID As String) As EECargoPersonal
        Dim listaCargoPersonal As List(Of EECargoPersonal) = Nothing
        Dim loCargoPersonal As EECargoPersonal = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_CargoPersonal_XPerId_pa")
            db.AddInParameter(cmd, "perId", DbType.String, perID)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
             
                loCargoPersonal = New EECargoPersonal()
                loCargoPersonal.CarPerId = dr("CarPerId").ToString()
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("NombreTipoCargo").ToString()
                loTablaGeneral.TgCodigo = dr("TgTipoCargoId").ToString()
                loCargoPersonal.OTgTipoCargo = loTablaGeneral

                If Not IsDBNull(dr("CarPerFechaIni")) Then
                    loCargoPersonal.CarPerFechaIni = Convert.ToDateTime(dr("CarPerFechaIni"))
                End If

                If Not IsDBNull(dr("CarPerFechaFin")) Then
                    loCargoPersonal.CarPerFechaFin = Convert.ToDateTime(dr("CarPerFechaFin"))
                End If
                loCargoPersonal.TgEstadoId = Convert.ToBoolean(dr("TgEstadoId").ToString())
                loCargoPersonal.Institucion = dr("NombreInstitucion").ToString()
                loCargoPersonal.CodInstitucion = dr("CodigoInstitucion").ToString()
                loCargoPersonal.Area = dr("NombreArea").ToString()
                loCargoPersonal.CodArea = dr("CodigoArea").ToString()
                loCargoPersonal.Cargo = dr("NombreCargo").ToString()
                loCargoPersonal.CargoSigla = dr("NombreCargoSigla").ToString()
                loCargoPersonal.CodCargo = dr("CodigoCargo").ToString()

            End If

            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Cargo x PerId => " & ex.Message, ex)
        End Try
        Return loCargoPersonal

    End Function


End Class