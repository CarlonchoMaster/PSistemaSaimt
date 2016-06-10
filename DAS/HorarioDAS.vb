Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class HorarioDAS
    Public Shared Function listarALL() As List(Of EEHorarios)
        Dim ListaHorarios As List(Of EEHorarios) = Nothing
        Dim loHorarios As EEHorarios = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDAsistencia)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Horarios_All_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaHorarios Is Nothing Then
                    ListaHorarios = New List(Of EEHorarios)()
                End If

                loHorarios = New EEHorarios()
                loHorarios.CodHorario = Convert.ToInt16(dr("Cod_Horario").ToString())
                loHorarios.Nombre = dr("Nombre").ToString()
                ListaHorarios.Add(loHorarios)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ALL Horarios => " & ex.Message, ex)
        End Try
        Return ListaHorarios
    End Function
End Class
