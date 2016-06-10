Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class DiarioTTSCDAO

    Public Shared Function guardar(ByVal aoDiarioTTSC As EEDiarioTTSC) As String
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_DiarioTTSC_pa")
            Dim dttscid As String
            db.AddOutParameter(cmd, "dttscid", DbType.String, 8)
            db.AddInParameter(cmd, "dttscfechapag", DbType.DateTime, aoDiarioTTSC.DTTSCFechaPag)
            db.AddInParameter(cmd, "dttscplaca", DbType.String, aoDiarioTTSC.DTTSCPlaca)
            db.AddInParameter(cmd, "dttscmonto", DbType.Decimal, aoDiarioTTSC.DTTSCMonto)
            db.AddInParameter(cmd, "conid", DbType.String, aoDiarioTTSC.ConId)
            db.AddInParameter(cmd, "perid", DbType.String, aoDiarioTTSC.PerId)
            db.AddInParameter(cmd, "tgEstdTTSCId", DbType.String, aoDiarioTTSC.TgEstdTTSCId)
            db.AddInParameter(cmd, "dttscid2", DbType.String, aoDiarioTTSC.DTTSCId2)
            db.ExecuteNonQuery(cmd)
            dttscid = IIf(IsDBNull(db.GetParameterValue(cmd, "dttscid")), String.Empty, db.GetParameterValue(cmd, "dttscid"))
            Return dttscid
        Catch ex As Exception
            Throw New Exception("Guardar DiarioTTSC => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function listar_DiarioTTSC_XdTTSCFechaPag_pa(ByVal dTTSCFechaPag As Date) As List(Of EEDiarioTTSC)
        Dim ListaDiarioTTSC As List(Of EEDiarioTTSC) = Nothing
        Dim loDiarioTTSC As EEDiarioTTSC = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("listar_DiarioTTSC_XdTTSCFechaPag_pa")
            db.AddInParameter(cmd, "dTTSCFechaPag", DbType.Date, dTTSCFechaPag)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDiarioTTSC Is Nothing Then
                    ListaDiarioTTSC = New List(Of EEDiarioTTSC)()
                End If

                loDiarioTTSC = New EEDiarioTTSC()
                loDiarioTTSC.DTTSCId = dr("DTTSCId").ToString()
                loDiarioTTSC.DTTSCFechaPag = dr("DTTSCFechaPag").ToString()
                loDiarioTTSC.DTTSCPlaca = dr("DTTSCPlaca").ToString()
                loDiarioTTSC.DTTSCMonto = dr("DTTSCMonto").ToString()
                loDiarioTTSC.ConId = dr("ConId").ToString()
                loDiarioTTSC.Concepto = dr("Concepto")
                loDiarioTTSC.Persona = dr("Persona").ToString()
                loDiarioTTSC.PerId = dr("PerId").ToString()
                loDiarioTTSC.TgEstdTTSCId = dr("TgEstdTTSCId").ToString
                loDiarioTTSC.TgEstdTTSC = dr("TgEstdTTSC").ToString()
                loDiarioTTSC.DTTSCId2 = dr("DTTSCId2").ToString()
                ListaDiarioTTSC.Add(loDiarioTTSC)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Movimiento Criterio => " + ex.Message, ex)
        End Try
        Return ListaDiarioTTSC
    End Function

    Public Shared Function eliminar(ByVal dTTSCFechaPag As Date) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_DiarioTTSCXdTTSCFechaPag")

            db.AddInParameter(cmd, "dTTSCFechaPag", DbType.Date, dTTSCFechaPag)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Recaudacion => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class


