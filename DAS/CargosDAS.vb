Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Public Class CargosDAS

    Public Shared Function listarCargosXcriterio(tpCriterio As Int16, ByVal criterio As String) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Cargos_by_criterio_pa")
            db.AddInParameter(cmd, "tpCriterio", DbType.Int16, tpCriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgDescripcion = dr("tgDescripcion").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgActivo = dr("tgActivo").ToString()

                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Cargos X Criterio => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function


    Public Shared Function listarCargosXBcriterio(ByVal tpCriterio As String, ByVal criterio As String) As List(Of EECargo)
        Dim ListaCargo As List(Of EECargo) = Nothing
        Dim loCargo As EECargo = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Cargos_by_Bcriterio_pa")
            db.AddInParameter(cmd, "tCriterio", DbType.String, tpCriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCargo Is Nothing Then
                    ListaCargo = New List(Of EECargo)()
                End If

                loCargo = New EECargo()
                loCargo.tgCargoId = dr("tgCargoId").ToString()
                loCargo.tgCargo = dr("tgCargo").ToString()
                loCargo.tgArea = dr("tgArea").ToString()
                loCargo.tgInstitucion = dr("tgInstitucion").ToString()
                ListaCargo.Add(loCargo)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Cargos X BCriterio => " + ex.Message, ex)
        End Try
        Return ListaCargo
    End Function
    
End Class
