Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class RequisitoSTDDAS

    Public Shared Function listarAllByProcId(procId As [String]) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_RequisitoVsProcedimiento_XProcId_pa")
            db.AddInParameter(cmd, "procId", DbType.String, procId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgActivo = dr("TgActivo").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Procedimientos por ProcId => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function
End Class


