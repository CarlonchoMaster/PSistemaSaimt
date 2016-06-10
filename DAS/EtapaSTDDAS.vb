Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class EtapaSTDDAS

#Region "Listar Criterio"
    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EEEtapaSTD)
        Dim ListaEtapaSTD As List(Of EEEtapaSTD) = Nothing
        Dim loEtapaSTD As EEEtapaSTD = Nothing
        Dim loProcedimientoSTD As EEProcedimientoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_EtapaSTD_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaEtapaSTD Is Nothing Then
                    ListaEtapaSTD = New List(Of EEEtapaSTD)()
                End If
                loEtapaSTD = New EEEtapaSTD()

                loEtapaSTD.EtaCod = dr("EtaCod").ToString()
                loEtapaSTD.EtaInstArea = dr("EtaInstArea").ToString()
                loEtapaSTD.EtaNro = Convert.ToInt32(dr("EtaNro").ToString())
                loEtapaSTD.EtaNombre = dr("EtaNombre").ToString()
                loEtapaSTD.EtaMaxDia = Convert.ToInt32(dr("EtaMaxDia").ToString())
                loEtapaSTD.EtaMaxHoras = Convert.ToDecimal(dr("EtaMaxHoras").ToString())
                loEtapaSTD.EtaFinaliza = Convert.ToBoolean(dr("EtaFinaliza").ToString())
                loEtapaSTD.EtaObservacion = dr("EtaObservacion").ToString()
                loEtapaSTD.Institucion = dr("NombreInstitucion").ToString()
                loEtapaSTD.CodInstitucion = dr("CodigoInstitucion").ToString()
                loEtapaSTD.Area = dr("NombreArea").ToString()
                loEtapaSTD.CodArea = dr("CodigoArea").ToString()

                loProcedimientoSTD = New EEProcedimientoSTD()
                loProcedimientoSTD.ProcId = dr("ProcId").ToString()
                loProcedimientoSTD.ProcNombre = dr("procNombre").ToString()

                loEtapaSTD.OProcedimientoSTD = loProcedimientoSTD

                ListaEtapaSTD.Add(loEtapaSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar EtapaSTD Criterio => " & ex.Message, ex)
        End Try
        Return ListaEtapaSTD
    End Function
#End Region

End Class
