Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ProcedimientosMovDAS

    Public Shared Function ListarXSolId(ByVal SolId As [String]) As List(Of EEProcedimientosMov)
        Dim ListaProcedimientosMov As List(Of EEProcedimientosMov) = Nothing
        Dim loProcedimientosMov As EEProcedimientosMov = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProcedimientosMov_XSolId_pa")
            db.AddInParameter(cmd, "SolId", DbType.String, SolId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProcedimientosMov Is Nothing Then
                    ListaProcedimientosMov = New List(Of EEProcedimientosMov)()
                End If
                loProcedimientosMov = New EEProcedimientosMov
                loProcedimientosMov.SolId = dr("SolId").ToString()
                loProcedimientosMov.ProcdId = dr("ProcdId").ToString()
                loProcedimientosMov.ProcdNombre = dr("ProcdNombre").ToString()
                loProcedimientosMov.ProcdDescripcion = dr("ProcdDescripcion").ToString()
                loProcedimientosMov.procdMaxDia = dr("procdMaxDia").ToString()
                loProcedimientosMov.FechaReg = IIf(IsDBNull(dr("FechaReg")), Nothing, dr("FechaReg"))
                loProcedimientosMov.FechaFin = IIf(IsDBNull(dr("FechaFin")), Nothing, dr("FechaFin"))
                loProcedimientosMov.Estado = dr("Estado").ToString()
                loProcedimientosMov.PerId = dr("PerId").ToString()
                loProcedimientosMov.Persona = dr("Persona").ToString()
                loProcedimientosMov.MovProcdId = Convert.ToInt32(dr("MovProcdId").ToString())
                loProcedimientosMov.TgAreaCargo = dr("TgAreaCargo").ToString()
                loProcedimientosMov.TgCargo = dr("TgCargo").ToString()
                loProcedimientosMov.TgArea = dr("TgArea").ToString()
                ListaProcedimientosMov.Add(loProcedimientosMov)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ProcedimientosMov X TgAreaCargo Criterio => " + ex.Message, ex)
        End Try
        Return ListaProcedimientosMov
    End Function


    Public Shared Function MostrarProcdIdXSolId(ByVal SolId As [String]) As String

        Dim ProcdId As String = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_ProcedimientosMov_ProcdId_XSolId_pa")
            db.AddInParameter(cmd, "SolId", DbType.String, SolId)
            ProcdId = db.ExecuteScalar(cmd)

        Catch ex As Exception
            Throw New Exception("Mostrar ProcdId x SolId => " + ex.Message, ex)
        End Try
        Return ProcdId
    End Function


    Public Shared Function MostrarEstadoXSolIdProcdId(ByVal SolId As [String], ByVal ProcdId As String) As String

        Dim estado As String = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_ProcedimientosMov_Estado_XSolId_ProcdId_pa")
            db.AddInParameter(cmd, "SolId", DbType.String, SolId)
            db.AddInParameter(cmd, "ProcdId", DbType.String, ProcdId)
            estado = db.ExecuteScalar(cmd)

        Catch ex As Exception
            Throw New Exception("Mostrar ProcdId x SolId => " + ex.Message, ex)
        End Try
        Return estado
    End Function

End Class


