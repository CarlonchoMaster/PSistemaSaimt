Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ServicioDAS

    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EEServicio)
        Dim ListaServicio As List(Of EEServicio) = Nothing
        Dim loServicio As EEServicio = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Servicio_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaServicio Is Nothing Then
                    ListaServicio = New List(Of EEServicio)()
                End If

                loServicio = New EEServicio()

                loServicio.ServId = dr("ServId").ToString()
                loServicio.ServNombre = dr("ServNombre").ToString()
                loServicio.ServDescripcion = dr("ServDescripcion").ToString()
                loServicio.TgServGrupoId = dr("TgServGrupoId").ToString()
                loServicio.TgServGrupo = dr("TgServGrupo").ToString()
                loServicio.ServActivo = Convert.ToBoolean(dr("ServActivo").ToString())
                loServicio.ServCodigo = dr("ServCodigo").ToString()


                ListaServicio.Add(loServicio)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Servicio Criterio => " + ex.Message, ex)
        End Try
        Return ListaServicio
    End Function

    Public Shared Function listarXReqId_Criterios(ByVal reqId As String, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEServicio)
        Dim ListaServicio As List(Of EEServicio) = Nothing
        Dim loServicio As EEServicio = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ServicioReqPendientes_xReqId_Criterio_pa")
            db.AddInParameter(cmd, "reqId", DbType.String, reqId)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaServicio Is Nothing Then
                    ListaServicio = New List(Of EEServicio)()
                End If
                loServicio = New EEServicio()
                loServicio.ServId = dr("ServId").ToString()
                loServicio.ServNombre = dr("ServNombre").ToString()
                loServicio.ServDescripcion = dr("ServDescripcion").ToString()
                loServicio.TgServGrupoId = dr("TgServGrupoId").ToString()
                loServicio.TgServGrupo = dr("TgServGrupo").ToString()
                loServicio.ServActivo = Convert.ToBoolean(dr("ServActivo").ToString())
                loServicio.ServCodigo = dr("ServCodigo").ToString()
                ListaServicio.Add(loServicio)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Servicio XReqId Criterio => " + ex.Message, ex)
        End Try
        Return ListaServicio
    End Function
    Public Shared Function generaCodigo() As String
        Dim artId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Servicio")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                artId = dr("servId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Codigo Servicio => " + ex.Message, ex)
        End Try
        Return artId
    End Function

    Public Shared Function generaCodigoSAIMT() As String
        Dim servCodigo As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Servicio_servCodigo")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                servCodigo = dr("servCodigo").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Codigo Servicio => " + ex.Message, ex)
        End Try
        Return servCodigo
    End Function

    Public Shared Function listarProveedorbyServId(ArtId As [String]) As List(Of EETablaGeneral)
        Dim ListaProveedor As List(Of EETablaGeneral) = Nothing
        Dim loProveedor As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Proveedor_by_ServId_pa")
            db.AddInParameter(cmd, "servId", DbType.String, ArtId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProveedor Is Nothing Then
                    ListaProveedor = New List(Of EETablaGeneral)()
                End If
                loProveedor = New EETablaGeneral()
                loProveedor.TgId = dr("tgId").ToString()
                loProveedor.TgExtra = dr("artId").ToString()
                loProveedor.TgCodigo = dr("provId").ToString()
                loProveedor.TgNombre = dr("prov").ToString()
                loProveedor.TgAbrev = dr("pcProv").ToString()
                loProveedor.TgActivo = Convert.ToBoolean(dr("pProv").ToString())
                ListaProveedor.Add(loProveedor)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Proveedor Articulo Criterio => " + ex.Message, ex)
        End Try
        Return ListaProveedor
    End Function
End Class



