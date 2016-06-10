Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ParametroDAS

    ''' <summary>
    ''' RETORNA EL VALOR DE LA TABLA PARAMETRO
    ''' SEGUN LA CLASE ID
    ''' </summary>
    ''' <param name="aiClsId">ClsId</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function mostrarXClsId(aiClsId As Int32) As Decimal
        Dim ldValor As Decimal? = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_Parametro_XClsId_pa")
            db.AddInParameter(cmd, "clsId", DbType.String, aiClsId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                ldValor = Convert.ToDecimal(dr("ParValor").ToString())
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Parametro XClsId => " + ex.Message, ex)
        End Try
        Return ldValor
    End Function


    Public Shared Function mostrarXClsId_parAnio(ByVal aiClsId As Int32, ByVal parAnio As String) As Decimal
        Dim ldValor As Decimal? = 0
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_Parametro_XClsId_ParAnio_pa")
            db.AddInParameter(cmd, "clsId", DbType.String, aiClsId)
            db.AddInParameter(cmd, "parAnio", DbType.String, parAnio)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                ldValor = Convert.ToDecimal(dr("ParValor").ToString())
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Parametro X ClsId parAnio => " + ex.Message, ex)
        End Try
        Return ldValor
    End Function
End Class
