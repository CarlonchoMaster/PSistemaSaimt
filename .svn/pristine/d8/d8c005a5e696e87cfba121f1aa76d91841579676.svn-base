Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades
Public Class BoleteriaDAS
    Public Shared Function GenerarCodigoBolCodigo() As String
        Dim bolCodigo As String = String.Empty
        ' Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_BolRincodana")
            bolCodigo = db.ExecuteScalar(cmd)
            ' dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Codigo File x tgRubroId => " & ex.Message, ex)
        End Try
        Return bolCodigo
    End Function
End Class
