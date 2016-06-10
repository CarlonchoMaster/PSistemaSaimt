Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class PruebaDAS

    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPrueba)
        Dim ListaPrueba As List(Of EEPrueba) = Nothing
        Dim loPrueba As EEPrueba = Nothing
        Dim dr As IDataReader = Nothing

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Prueba_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPrueba Is Nothing Then
                    ListaPrueba = New List(Of EEPrueba)()
                End If

                loPrueba = New EEPrueba()

                loPrueba.PruId = Convert.ToInt32(dr("PruId").ToString())
                loPrueba.PruNombre = dr("PruNombre").ToString()
                loPrueba.PruDescripcion = dr("PruDescripcion").ToString()
                ListaPrueba.Add(loPrueba)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Prueba Criterio => " + ex.Message, ex)
        End Try
        Return ListaPrueba
    End Function

    Public Shared Function listarALL() As List(Of EEPrueba)
        Dim ListaPrueba As List(Of EEPrueba) = Nothing
        Dim loPrueba As EEPrueba = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Prueba_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPrueba Is Nothing Then
                    ListaPrueba = New List(Of EEPrueba)()
                End If

                loPrueba = New EEPrueba()

                loPrueba.PruId = Convert.ToInt32(dr("PruId").ToString())
                loPrueba.PruNombre = dr("PruNombre").ToString()
                loPrueba.PruDescripcion = dr("PruDescripcion").ToString()
                ListaPrueba.Add(loPrueba)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ALL Prueba => " & ex.Message, ex)
        End Try
        Return ListaPrueba
    End Function
End Class
