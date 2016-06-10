Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class UbigeoDAS

#Region "Listar Depatamento ALL"
    Public Shared Function listarDepartamentoALL() As List(Of EEUbigeo)
        Dim ListaUbigeo As List(Of EEUbigeo) = Nothing
        Dim loUbigeo As EEUbigeo = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Ubigeo_Departamento_All_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaUbigeo Is Nothing Then
                    ListaUbigeo = New List(Of EEUbigeo)()
                End If

                loUbigeo = New EEUbigeo()

                loUbigeo.UbgId = dr("UbgId").ToString()
                loUbigeo.UbgDep = dr("UbgDep").ToString()
                loUbigeo.UbgProv = dr("UbgProv").ToString()
                loUbigeo.UbgDist = dr("UbgDist").ToString()
                loUbigeo.UbgNombre = dr("UbgNombre").ToString()

                ListaUbigeo.Add(loUbigeo)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Departamento ALL => " & ex.Message, ex)
        End Try
        Return ListaUbigeo
    End Function
#End Region

#Region "Listar Provincia X UbgDep"
    Public Shared Function listarProvinciaXUbgDep(ByVal asUbgDep As [String]) As List(Of EEUbigeo)
        Dim ListaUbigeo As List(Of EEUbigeo) = Nothing
        Dim loUbigeo As EEUbigeo = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Ubigeo_Provincia_XUbgDep_pa")
            db.AddInParameter(cmd, "@ubgDep", DbType.String, asUbgDep)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaUbigeo Is Nothing Then
                    ListaUbigeo = New List(Of EEUbigeo)()
                End If

                loUbigeo = New EEUbigeo()

                loUbigeo.UbgId = dr("UbgId").ToString()
                loUbigeo.UbgDep = dr("UbgDep").ToString()
                loUbigeo.UbgProv = dr("UbgProv").ToString()
                loUbigeo.UbgDist = dr("UbgDist").ToString()
                loUbigeo.UbgNombre = dr("UbgNombre").ToString()

                ListaUbigeo.Add(loUbigeo)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Provincia XUbgDep => " & ex.Message, ex)
        End Try
        Return ListaUbigeo
    End Function
#End Region

#Region "Listar Distrito X UbgDep y UbgProv"
    Public Shared Function listarDistritoXUbgDepXUbgProv(ByVal asUbgDep As [String], ByVal asUbgProv As [String]) As List(Of EEUbigeo)
        Dim ListaUbigeo As List(Of EEUbigeo) = Nothing
        Dim loUbigeo As EEUbigeo = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Ubigeo_Distrito_XUbgDep_XUbgProv_pa")
            db.AddInParameter(cmd, "ubgdep", DbType.String, asUbgDep)
            db.AddInParameter(cmd, "ubgprov", DbType.String, asUbgProv)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaUbigeo Is Nothing Then
                    ListaUbigeo = New List(Of EEUbigeo)()
                End If
                loUbigeo = New EEUbigeo()
                loUbigeo.UbgId = dr("UbgId").ToString()
                loUbigeo.UbgDep = dr("UbgDep").ToString()
                loUbigeo.UbgProv = dr("UbgProv").ToString()
                loUbigeo.UbgDist = dr("UbgDist").ToString()
                loUbigeo.UbgNombre = dr("UbgNombre").ToString()
                ListaUbigeo.Add(loUbigeo)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ALL Ubigeo => " & ex.Message, ex)
        End Try
        Return ListaUbigeo
    End Function
#End Region

End Class
