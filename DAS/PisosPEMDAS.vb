Imports Entidades
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class PisosPEMDAS
    Public Shared Function PisosXInstitucion(ByVal asInstitucion As [String]) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loPisosPEM As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Pisos_XIntitucion_pa")

            db.AddInParameter(cmd, "institucion", DbType.String, asInstitucion)


            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loPisosPEM = New EETablaGeneral()
                loPisosPEM.TgId = Convert.ToInt32(dr("TgId").ToString())
                loPisosPEM.TgNombre = dr("TgNombre").ToString()
                loPisosPEM.TgDescripcion = dr("TgDescripcion").ToString()
                loPisosPEM.TgCodigo = dr("TgCodigo").ToString()
                loPisosPEM.TgExtra = dr("TgExtra").ToString()
                loPisosPEM.TgAbrev = dr("TgAbrev").ToString()
                loPisosPEM.TgActivo = dr("TgActivo").ToString()

                ListaTablaGeneral.Add(loPisosPEM)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase and criterio => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

    Public Shared Function PisosXPisoId(ByVal asPisos As [String]) As EETablaGeneral
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loPisosPEM As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Pisos_XPisoId_pa")

            db.AddInParameter(cmd, "PisoId", DbType.String, asPisos)


            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loPisosPEM = New EETablaGeneral()
                loPisosPEM.TgId = Convert.ToInt32(dr("TgId").ToString())
                loPisosPEM.TgNombre = dr("TgNombre").ToString()
                loPisosPEM.TgDescripcion = dr("TgDescripcion").ToString()
                loPisosPEM.TgCodigo = dr("TgCodigo").ToString()
                loPisosPEM.TgExtra = dr("TgExtra").ToString()
                loPisosPEM.TgAbrev = dr("TgAbrev").ToString()
                loPisosPEM.TgActivo = dr("TgActivo").ToString()

                ListaTablaGeneral.Add(loPisosPEM)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase and criterio => " + ex.Message, ex)
        End Try
        Return loPisosPEM
    End Function
End Class
