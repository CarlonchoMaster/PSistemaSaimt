Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class ClaseDAS

#Region "Listar Criterio"
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEClase)
        Dim ListaClase As List(Of EEClase) = Nothing
        Dim loClase As EEClase = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Clase_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaClase Is Nothing Then
                    ListaClase = New List(Of EEClase)()
                End If

                loClase = New EEClase()

                loClase.ClsId = Convert.ToInt32(dr("ClsId").ToString())
                loClase.ClsNombre = dr("ClsNombre").ToString()
                loClase.ClsDescripcion = dr("ClsDescripcion").ToString()

                ListaClase.Add(loClase)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Clase Criterio => " + ex.Message, ex)
        End Try

        Return ListaClase
    End Function
#End Region

#Region "Listar ALL"
    Public Shared Function listarALL() As List(Of EEClase)
        Dim ListaClase As List(Of EEClase) = Nothing
        Dim loClase As EEClase = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Clase_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaClase Is Nothing Then
                    ListaClase = New List(Of EEClase)()
                End If

                loClase = New EEClase()

                loClase.ClsId = Convert.ToInt32(dr("ClsId").ToString())
                loClase.ClsNombre = dr("ClsNombre").ToString()
                loClase.ClsDescripcion = dr("ClsDescripcion").ToString()

                ListaClase.Add(loClase)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ALL Clase => " & ex.Message, ex)
        End Try
        Return ListaClase
    End Function
#End Region

End Class
