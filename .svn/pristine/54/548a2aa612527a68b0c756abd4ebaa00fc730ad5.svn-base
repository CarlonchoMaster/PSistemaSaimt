Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ProcedimientosActDAS

    Public Shared Function listarXMovProcdId(ByVal viMovProcdId As String) As List(Of EEProcedimientosAct)

        Dim ListaProcedimientosAct As List(Of EEProcedimientosAct) = Nothing
        Dim loProcedimientosAct As EEProcedimientosAct = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProcedimientosAct_XmovProcdId_pa")
            db.AddInParameter(cmd, "MovProcdId", DbType.String, viMovProcdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProcedimientosAct Is Nothing Then
                    ListaProcedimientosAct = New List(Of EEProcedimientosAct)()
                End If
                loProcedimientosAct = New EEProcedimientosAct()
                loProcedimientosAct.movprocdId = Convert.ToInt32(dr("MovProcdId").ToString())
                loProcedimientosAct.Actividad = dr("Actividad").ToString()
                loProcedimientosAct.Nro = Convert.ToInt32(dr("Nro").ToString())
                loProcedimientosAct.eliminado = IIf(IsDBNull(dr("Eliminado")), False, dr("Eliminado"))
                ListaProcedimientosAct.Add(loProcedimientosAct)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ProcedimientosAct X MovProcdId Criterio => " + ex.Message, ex)
        End Try
        Return ListaProcedimientosAct
    End Function







End Class

