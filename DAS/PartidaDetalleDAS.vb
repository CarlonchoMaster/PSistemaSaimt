Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class PartidaDetalleDAS

    Public Shared Function listarXPartId_partAño(ByVal aipartAño As Int32, ByVal aspartId As [String]) As List(Of EEPartidaDetalle)
        Dim ListaPartidaDetalle As List(Of EEPartidaDetalle) = Nothing
        Dim loPartidaDetalle As EEPartidaDetalle = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_PartidaDetalle_XpartId_partAño_pa")
            db.AddInParameter(cmd, "partId", DbType.String, aspartId)
            db.AddInParameter(cmd, "partAño", DbType.Int32, aipartAño)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPartidaDetalle Is Nothing Then
                    ListaPartidaDetalle = New List(Of EEPartidaDetalle)()
                End If

                loPartidaDetalle = New EEPartidaDetalle()

                loPartidaDetalle.PartDDe = dr("PartDDe").ToString()
                loPartidaDetalle.PartDPara = dr("PartDPara").ToString()
                loPartidaDetalle.PartAño = dr("PartAño").ToString()
                loPartidaDetalle.PartDMonto = Convert.ToDecimal(dr("PartDMonto").ToString())
                loPartidaDetalle.PartDFechaReg = IIf(IsDBNull(dr("PartDFechaReg")), Nothing, dr("PartDFechaReg"))
                loPartidaDetalle.PartDDocRef = dr("PartDDocRef").ToString()
                loPartidaDetalle.PartDFechaAprueba = IIf(IsDBNull(dr("PartDFechaAprueba")), Nothing, dr("PartDFechaAprueba"))
                loPartidaDetalle.PartId = dr("PartId").ToString()
                loPartidaDetalle.PartDId = Convert.ToInt32(dr("PartDId").ToString())


                ListaPartidaDetalle.Add(loPartidaDetalle)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar PartidaDetalle Criterio => " + ex.Message, ex)
        End Try
        Return ListaPartidaDetalle
    End Function

End Class


