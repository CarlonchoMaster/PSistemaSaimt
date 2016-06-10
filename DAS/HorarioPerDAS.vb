Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class HorarioPerDAS

#Region "CONSULTAR HORARIO"
    ''' <summary>
    ''' Consultar Horario en Formulario Trabajador
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Shared Function ListarHorario() As List(Of EEHorarioPer)
        Dim ListaHorarioPer As List(Of EEHorarioPer) = Nothing
        Dim loHorarioPer As EEHorarioPer = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_HorarioPer_All_pa")
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaHorarioPer Is Nothing Then
                    ListaHorarioPer = New List(Of EEHorarioPer)()
                End If

                loHorarioPer = New EEHorarioPer()
                loHorarioPer.HorId = Convert.ToInt32(dr("HorId").ToString())
                loHorarioPer.HorDescripcion = dr("HorDescripcion").ToString()
                ListaHorarioPer.Add(loHorarioPer)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar HorarioPer => " & ex.Message, ex)
        End Try
        Return ListaHorarioPer
    End Function
    Public Shared Function consultarHorario(ByVal asCriterio As [String]) As List(Of EEHorarioPer)
        Dim ListaHorarioPer As List(Of EEHorarioPer) = Nothing
        Dim loHorarioPer As EEHorarioPer = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Consultar_HorarioPer_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaHorarioPer Is Nothing Then
                    ListaHorarioPer = New List(Of EEHorarioPer)()
                End If

                loHorarioPer = New EEHorarioPer()
                loHorarioPer.HorId = Convert.ToInt32(dr("HorId").ToString())
                loHorarioPer.HorDescripcion = dr("HorDescripcion").ToString()
                loHorarioPer.HorEntrada = Convert.ToDateTime(dr("HorEntrada").ToString())
                loHorarioPer.HorRecesoIni = Convert.ToDateTime(dr("HorRecesoIni").ToString())
                loHorarioPer.HorRecesoFin = Convert.ToDateTime(dr("HorRecesoFin").ToString())
                loHorarioPer.HorSalida = Convert.ToDateTime(dr("HorSalida").ToString())

                ListaHorarioPer.Add(loHorarioPer)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar HorarioPer => " & ex.Message, ex)
        End Try
        Return ListaHorarioPer
    End Function
#End Region

End Class
