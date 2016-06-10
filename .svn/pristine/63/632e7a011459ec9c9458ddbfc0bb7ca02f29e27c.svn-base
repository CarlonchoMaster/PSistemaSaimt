Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class SubProcesosDAS

    Public Shared Function NewCodigo() As String
        Dim codigo As String = String.Empty
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_SubProcesos_NewCodigo")
            codigo = db.ExecuteScalar(cmd)
        Catch ex As Exception
            Throw New Exception("Nuevo Codigo SubProcesos => " + ex.Message, ex)
        End Try
        Return codigo
    End Function
    Public Shared Function listarXProcId(ByVal sProcId As String) As List(Of EESubProcesos)

        Dim ListaSubProcesos As List(Of EESubProcesos) = Nothing
        Dim loSubProcesos As EESubProcesos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_SubProcesos_XProcId_pa")
            db.AddInParameter(cmd, "ProcId", DbType.String, sProcId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaSubProcesos Is Nothing Then
                    ListaSubProcesos = New List(Of EESubProcesos)()
                End If
                loSubProcesos = New EESubProcesos()
                loSubProcesos.ProcId = dr("ProcId").ToString()
                loSubProcesos.SubProcNombre = dr("SubProcNombre").ToString()
                loSubProcesos.SubProcDescripcion = dr("SubProcDescripcion").ToString()
                loSubProcesos.SubProcActivo = Convert.ToBoolean(dr("SubProcActivo").ToString())
                loSubProcesos.SubProcId = dr("SubProcId").ToString()
                ListaSubProcesos.Add(loSubProcesos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar SubProcesos X ProcId Criterio => " + ex.Message, ex)
        End Try
        Return ListaSubProcesos
    End Function

    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EESubProcesos)
        Dim ListaSubProcesos As List(Of EESubProcesos) = Nothing
        Dim loSubProcesos As EESubProcesos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_SubProcesos_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaSubProcesos Is Nothing Then
                    ListaSubProcesos = New List(Of EESubProcesos)()
                End If

                loSubProcesos = New EESubProcesos()

                loSubProcesos.ProcId = dr("ProcId").ToString()
                loSubProcesos.SubProcNombre = dr("SubProcNombre").ToString()
                loSubProcesos.SubProcDescripcion = dr("SubProcDescripcion").ToString()
                loSubProcesos.SubProcActivo = Convert.ToBoolean(dr("SubProcActivo").ToString())
                loSubProcesos.SubProcId = dr("SubProcId").ToString()


                ListaSubProcesos.Add(loSubProcesos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar SubProcesos Criterio => " + ex.Message, ex)
        End Try
        Return ListaSubProcesos
    End Function











End Class
