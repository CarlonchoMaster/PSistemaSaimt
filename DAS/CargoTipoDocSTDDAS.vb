Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class CargoTipoDocSTDDAs

#Region "Listar Criterio"
    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EECargoTipoDocSTD)
        Dim ListaCargoTipoDocSTD As List(Of EECargoTipoDocSTD) = Nothing
        Dim loCargoTipoDocSTD As EECargoTipoDocSTD = Nothing
        Dim loTipoDocumento As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CargoTipoDocSTD_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCargoTipoDocSTD Is Nothing Then
                    ListaCargoTipoDocSTD = New List(Of EECargoTipoDocSTD)()
                End If

                loCargoTipoDocSTD = New EECargoTipoDocSTD()
                loTipoDocumento = New EETablaGeneral()
                loTipoDocumento.TgCodigo = dr("tgTDocId").ToString()
                loTipoDocumento.TgNombre = dr("nombreTipoDocumento").ToString()

                loCargoTipoDocSTD.CarTipoDocId = dr("CarTipoDocId").ToString()
                loCargoTipoDocSTD.CarTipoDocNroIni = Convert.ToInt32(dr("CarTipoDocNroIni").ToString())
                loCargoTipoDocSTD.OTgTipoDocumento = loTipoDocumento
                loCargoTipoDocSTD.CarTipoAño = dr("CarTipoAño").ToString()

                loCargoTipoDocSTD.CodArea = dr("codigoArea").ToString()
                loCargoTipoDocSTD.Area = dr("nombreArea").ToString()
                loCargoTipoDocSTD.CodCargo = dr("codigoCargo").ToString()
                loCargoTipoDocSTD.Cargo = dr("nombreCargo").ToString()

                ListaCargoTipoDocSTD.Add(loCargoTipoDocSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar CargoTipoDocSTD Criterio => " & ex.Message, ex)
        End Try
        Return ListaCargoTipoDocSTD
    End Function
#End Region

End Class