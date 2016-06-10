Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class SucursalesDAS
    Public Shared Function listarALL() As List(Of EESucursales)
        Dim ListaSucursales As List(Of EESucursales) = Nothing
        Dim loSucursales As EESucursales = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDAsistencia)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Sucursales_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaSucursales Is Nothing Then
                    ListaSucursales = New List(Of EESucursales)()
                End If

                loSucursales = New EESucursales()
                loSucursales.CodSucursal = Convert.ToInt32(dr("CodSucursal").ToString())
                loSucursales.Sucursal = dr("Sucursal").ToString()
                ListaSucursales.Add(loSucursales)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ALL Sucursales => " & ex.Message, ex)
        End Try
        Return ListaSucursales
    End Function
End Class
