Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Public Class GastoComisionDAS
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEGastoComision)
        Dim ListaGastoComision As List(Of EEGastoComision) = Nothing
        Dim loGastoComision As EEGastoComision = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_GastoComision_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaGastoComision Is Nothing Then
                    ListaGastoComision = New List(Of EEGastoComision)()
                End If
                loGastoComision = New EEGastoComision()
                loGastoComision.GasComFec = IIf(IsDBNull(dr("GasComFec")), Nothing, dr("GasComFec"))
                loGastoComision.GasComValor = Convert.ToDecimal(dr("GasComValor").ToString())
                loGastoComision.TgRecaudadoraId = dr("TgRecaudadoraId").ToString()
                ListaGastoComision.Add(loGastoComision)
            End While
        Catch ex As Exception
            Throw New Exception("Listar GastoComision Criterio => " + ex.Message, ex)
        End Try
        Return ListaGastoComision
    End Function

    Public Shared Function listarALL() As List(Of EEGastoComision)
        Dim ListaGastoComision As List(Of EEGastoComision) = Nothing
        Dim loGastoComision As EEGastoComision = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_GastoComision_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaGastoComision Is Nothing Then
                    ListaGastoComision = New List(Of EEGastoComision)()
                End If

                loGastoComision = New EEGastoComision()
                loGastoComision.GasComFec = IIf(IsDBNull(dr("GasComFec")), Nothing, dr("GasComFec"))
                loGastoComision.GasComValor = Convert.ToDecimal(dr("GasComValor").ToString())
                loGastoComision.TgRecaudadoraId = dr("TgRecaudadoraId").ToString()


                ListaGastoComision.Add(loGastoComision)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ALL GastoComision => " & ex.Message, ex)
        End Try
        Return ListaGastoComision
    End Function
End Class
