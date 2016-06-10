Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class VehiculoPEMDAS
    Public Shared Function MostrarTgTipoVehIdXVehNPlaca(ByVal asVehNPlaca As [String]) As EEVehiculoPEM
        Dim loVehiculoPEM As EEVehiculoPEM = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_VehiculoPEM_XVehNPlaca_pa")
            db.AddInParameter(cmd, "vehNPlaca", DbType.String, asVehNPlaca)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loVehiculoPEM = New EEVehiculoPEM()
                loVehiculoPEM.TgTipoVehId = dr("TgTipoVehId").ToString()
                loVehiculoPEM.VehNPlaca = dr("VehNPlaca").ToString()
                loVehiculoPEM.VehEliminado = Convert.ToBoolean(dr("VehEliminado").ToString())
            End If
        Catch ex As Exception
            Throw New Exception("Listar VehiculoPEM x VehNPlaca => " & ex.Message, ex)
        End Try
        Return loVehiculoPEM
    End Function


End Class

