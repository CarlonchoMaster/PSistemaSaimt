Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class PartidaDAS

    Public Shared Function listarCriterio(ByVal aiAño As Int32, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPartida)
        Dim ListaPartida As List(Of EEPartida) = Nothing
        Dim loPartida As EEPartida = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Partida_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            db.AddInParameter(cmd, "partAño", DbType.Int32, aiAño)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPartida Is Nothing Then
                    ListaPartida = New List(Of EEPartida)()
                End If
                loPartida = New EEPartida()
                loPartida.PartId = dr("PartId").ToString()
                loPartida.PartAño = dr("PartAño").ToString()
                loPartida.TgPartTipoId = dr("TgPartTipoId").ToString()
                loPartida.PartNombre = dr("PartNombre").ToString()
                loPartida.TgPartEstId = IIf(IsDBNull(dr("TgPartEstId")), Nothing, dr("TgPartEstId"))
                loPartida.PartDocRef = dr("PartDocRef").ToString()
                ListaPartida.Add(loPartida)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Partida Criterio => " + ex.Message, ex)
        End Try
        Return ListaPartida
    End Function

    'Public Shared Function MostrarXPartId(ByVal partId As [String]) As EEPartida
    '    Dim loPartida As EEPartida = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_Partida_XPartId_pa")
    '        db.AddInParameter(cmd, "partId", DbType.String, partId)
    '        dr = db.ExecuteReader(cmd)
    '        If dr.Read() Then
    '            loPartida = New EEPartida()
    '            loPartida.PartId = dr("partId").ToString()
    '            loPartida.PartAño = dr("partAño").ToString()
    '            loPartida.TgPartTipoId = dr("tgPartTipoId").ToString()
    '            loPartida.PartNombre = dr("partNombre").ToString()
    '            loPartida.TgPartEstId = dr("tgPartEstId").ToString()
    '            loPartida.PartDocRef = dr("partDocRef").ToString()
    '            
    '        End If
    '    Catch ex As Exception
    '        Throw New Exception("Mostrar Certificacion x CerId => " & ex.Message, ex)
    '    End Try
    '    Return loPartida
    'End Function
End Class


