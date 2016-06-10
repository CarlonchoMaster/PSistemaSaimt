Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class CargoTipoAccionSTDDAS

#Region "Listar Criterio"
    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EECargoTipoAccionSTD)
        Dim ListaCargoTipoAccionSTD As List(Of EECargoTipoAccionSTD) = Nothing
        Dim loCargoTipoAccionSTD As EECargoTipoAccionSTD = Nothing
        Dim loTipoAccion As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CargoTipoAccionSTD_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCargoTipoAccionSTD Is Nothing Then
                    ListaCargoTipoAccionSTD = New List(Of EECargoTipoAccionSTD)()
                End If

                loCargoTipoAccionSTD = New EECargoTipoAccionSTD()
                loTipoAccion = New EETablaGeneral()
                loTipoAccion.TgCodigo = dr("TgTAccionId").ToString()
                loTipoAccion.TgNombre = dr("nombreTipoAccion").ToString()

                loCargoTipoAccionSTD.CarTipoAccId = dr("CarTipoAccId").ToString()
                loCargoTipoAccionSTD.CarTipoAccNroIni = Convert.ToInt32(dr("CarTipoAccNroIni").ToString())
                loCargoTipoAccionSTD.OTgAccion = loTipoAccion
                loCargoTipoAccionSTD.CarTipoAccAño = dr("CarTipoAccAño").ToString()

                loCargoTipoAccionSTD.CodInstitucion = dr("CodigoInstitucion").ToString()
                loCargoTipoAccionSTD.Institucion = dr("NombreInstitucion").ToString()
                loCargoTipoAccionSTD.CodArea = dr("CodigoArea").ToString()
                loCargoTipoAccionSTD.Area = dr("NombreArea").ToString()
                loCargoTipoAccionSTD.CodCargo = dr("CodigoCargo").ToString()
                loCargoTipoAccionSTD.Cargo = dr("NombreCargo").ToString()

                ListaCargoTipoAccionSTD.Add(loCargoTipoAccionSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar CargoTipoAccion Criterio => " & ex.Message, ex)
        End Try
        Return ListaCargoTipoAccionSTD
    End Function
#End Region

End Class
