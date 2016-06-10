Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class SolicitudesDAS

    Public Shared Function NewCodigo() As String
        Dim codigo As String = String.Empty
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_Solicitudes_NewCodigo")
            codigo = db.ExecuteScalar(cmd)
        Catch ex As Exception
            Throw New Exception("Nuevo Codigo Solicitudes => " + ex.Message, ex)
        End Try
        Return codigo
    End Function

    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EESolicitudes)
        Dim ListaSolicitudes As List(Of EESolicitudes) = Nothing
        Dim loSolicitudes As EESolicitudes = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Solicitudes_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaSolicitudes Is Nothing Then
                    ListaSolicitudes = New List(Of EESolicitudes)()
                End If

                loSolicitudes = New EESolicitudes()

                loSolicitudes.SolId = dr("SolId").ToString()
                loSolicitudes.SolNombre = dr("SolNombre").ToString()
                loSolicitudes.SolDescripcion = dr("SolDescripcion").ToString()
                loSolicitudes.SolActivo = Convert.ToBoolean(dr("SolActivo").ToString())
                loSolicitudes.SolDocRef = dr("SolDocRef").ToString()
                loSolicitudes.SolFechaReg = IIf(IsDBNull(dr("SolFechaReg")), Nothing, dr("SolFechaReg"))
                loSolicitudes.SolFecha = IIf(IsDBNull(dr("SolFecha")), Nothing, dr("SolFecha"))
                loSolicitudes.SubProcId = dr("SubProcId").ToString()


                ListaSolicitudes.Add(loSolicitudes)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Solicitudes Criterio => " + ex.Message, ex)
        End Try
        Return ListaSolicitudes
    End Function


    Public Shared Function MostrarXSolId_SubProcId(ByVal vSolId As String, ByVal subProcId As String) As EESolicitudes

        Dim ListaSolicitudes As List(Of EESolicitudes) = Nothing
        Dim loSolicitudes As EESolicitudes = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_Solicitudes_XSolId_SubProcId_pa")
            db.AddInParameter(cmd, "SolId", DbType.String, vSolId)
            db.AddInParameter(cmd, "subProcId", DbType.String, subProcId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loSolicitudes = New EESolicitudes()
                loSolicitudes.SolId = dr("SolId").ToString()
                loSolicitudes.SolNombre = dr("SolNombre").ToString()
                loSolicitudes.SolDescripcion = dr("SolDescripcion").ToString()
                loSolicitudes.SolActivo = Convert.ToBoolean(dr("SolActivo").ToString())
                loSolicitudes.SolDocRef = dr("SolDocRef").ToString()
                loSolicitudes.SolFechaReg = IIf(IsDBNull(dr("SolFechaReg")), Nothing, dr("SolFechaReg"))
                loSolicitudes.SolFecha = IIf(IsDBNull(dr("SolFecha")), Nothing, dr("SolFecha"))
                loSolicitudes.procdId = dr("procdId").ToString()
                loSolicitudes.solestado = dr("solestado").ToString()

                ' ListaSolicitudes.Add(loSolicitudes)
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Solicitudes X SolId Criterio => " + ex.Message, ex)
        End Try
        Return loSolicitudes
    End Function


    Public Shared Function listarxTgAreaId(ByVal TgAreaId As [String], Optional ByVal estadoSol As String = "", Optional ByVal fechaInicio As Date = Nothing, Optional ByVal fechaFin As Date = Nothing) As List(Of EEProcesos)
        Dim ListaProcesos As List(Of EEProcesos) = Nothing
        Dim loProcesos As EEProcesos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Solicitudes_Procesos_SubProcesos_XTgArea_pa")
            If TgAreaId <> "" Then
                db.AddInParameter(cmd, "tgareaId", DbType.String, TgAreaId)
            End If

            If estadoSol <> "" Then
                db.AddInParameter(cmd, "solestado", DbType.String, estadoSol)
            End If

            If fechaInicio <> "#12:00:00 AM#" And fechaFin <> "#12:00:00 AM#" Then
                db.AddInParameter(cmd, "fechaI", DbType.Date, fechaInicio)
                db.AddInParameter(cmd, "fechaF", DbType.Date, fechaFin)
            End If
          

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProcesos Is Nothing Then
                    ListaProcesos = New List(Of EEProcesos)()
                End If
                loProcesos = New EEProcesos()
                loProcesos.ProcId = dr("procId").ToString()
                loProcesos.ProcNombre = dr("ProcNombre").ToString()
                loProcesos.loSubProcesos = New EESubProcesos
                loProcesos.loSubProcesos.SubProcId = dr("SubProcId").ToString()
                loProcesos.loSubProcesos.SubProcNombre = dr("SubProcNombre").ToString()
                loProcesos.loSubProcesos.loSolicitudes = New EESolicitudes
                loProcesos.loSubProcesos.loSolicitudes.SolId = dr("SolId").ToString()
                loProcesos.loSubProcesos.loSolicitudes.SolNombre = dr("SolNombre").ToString()
                ListaProcesos.Add(loProcesos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Solicitudes Criterio => " + ex.Message, ex)
        End Try
        Return ListaProcesos
    End Function


End Class
