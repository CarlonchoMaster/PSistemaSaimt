Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class Temp_ProPagosDAS

#Region "Listar Criterio"
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETemp_ProPagos)
        Dim ListaTemp_ProPagos As List(Of EETemp_ProPagos) = Nothing
        Dim loTemp_ProPagos As EETemp_ProPagos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Temp_ProPagos_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTemp_ProPagos Is Nothing Then
                    ListaTemp_ProPagos = New List(Of EETemp_ProPagos)()
                End If

                loTemp_ProPagos = New EETemp_ProPagos()

                loTemp_ProPagos.ProPaId = dr("ProPaId").ToString()
                loTemp_ProPagos.ProPaAño = dr("ProPaAño").ToString()
                loTemp_ProPagos.ContId = dr("ContId").ToString()
                loTemp_ProPagos.PerId = dr("PerId").ToString()
                loTemp_ProPagos.Persona = dr("PerNombre").ToString()
                loTemp_ProPagos.Contacto = dr("ContDescripcion").ToString()
                loTemp_ProPagos.ProPaNroCuota = Convert.ToInt32(dr("ProPaNroCuota").ToString())
                loTemp_ProPagos.ConId = dr("ConId").ToString()
                loTemp_ProPagos.ConNombre = dr("ConNombre").ToString()
                loTemp_ProPagos.ProPa_PSaimt = Convert.ToDecimal(dr("ProPa_PSaimt").ToString())
                loTemp_ProPagos.ProPa_PMpt = Convert.ToDecimal(dr("ProPa_PMpt").ToString())
                loTemp_ProPagos.ProPaFecVen = IIf(IsDBNull(dr("ProPaFecVen")), Nothing, dr("ProPaFecVen"))
                loTemp_ProPagos.ProPaDetMonto = Convert.ToDecimal(dr("ProPaDetMonto").ToString())
                loTemp_ProPagos.TgEstadoId = dr("TgEstadoId").ToString()
                loTemp_ProPagos.ProPaFecPag = IIf(IsDBNull(dr("ProPaFecPag")), Nothing, dr("ProPaFecPag"))
                loTemp_ProPagos.ProPaCtaSaimt = Convert.ToDecimal(dr("ProPaCtaSaimt").ToString())
                loTemp_ProPagos.ProPaCtaMpt = Convert.ToDecimal(dr("ProPaCtaMpt").ToString())
                loTemp_ProPagos.ProPaMoraSaimt = Convert.ToDecimal(dr("ProPaMoraSaimt").ToString())
                loTemp_ProPagos.ProPaMoraMpt = Convert.ToDecimal(dr("ProPaMoraMpt").ToString())
                loTemp_ProPagos.ProPaComCtaSaimt = Convert.ToDecimal(dr("ProPaComCtaSaimt").ToString())
                loTemp_ProPagos.ProPaComCtaMpt = Convert.ToDecimal(dr("ProPaComCtaMpt").ToString())
                loTemp_ProPagos.ProPaTotal = Convert.ToDecimal(dr("ProPaTotal").ToString())
                loTemp_ProPagos.proPaActualizado = Convert.ToBoolean(dr("proPaActualizado").ToString())
                loTemp_ProPagos.proPaFecAct = Convert.ToDateTime(dr("proPaFecAct").ToString())
                ListaTemp_ProPagos.Add(loTemp_ProPagos)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Temp_ProPagos Criterio => " + ex.Message, ex)
        End Try
        Return ListaTemp_ProPagos
    End Function
#End Region

#Region "Listar XFecha"
    Public Shared Function listarXFecha(ByVal asCriterio As DateTime) As List(Of EETemp_ProPagos)
        Dim ListaTemp_ProPagos As List(Of EETemp_ProPagos) = Nothing
        Dim loTemp_ProPagos As EETemp_ProPagos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_TempProPagos_XFecha")
            db.AddInParameter(cmd, "proPaFecPag", DbType.DateTime, asCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTemp_ProPagos Is Nothing Then
                    ListaTemp_ProPagos = New List(Of EETemp_ProPagos)()
                End If
                loTemp_ProPagos = New EETemp_ProPagos()
                loTemp_ProPagos.ProPaId = dr("ProPaId").ToString()
                loTemp_ProPagos.ProPaFecPag = dr("proPaFecPag").ToString
                loTemp_ProPagos.TgEstadoId = dr("tgEstadoId").ToString
                ListaTemp_ProPagos.Add(loTemp_ProPagos)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Temp_ProPagos Criterio => " + ex.Message, ex)
        End Try
        Return ListaTemp_ProPagos
    End Function

#End Region

#Region "Listar ALL"
    Public Shared Function listarALL() As List(Of EETemp_ProPagos)
        Dim ListaTemp_ProPagos As List(Of EETemp_ProPagos) = Nothing
        Dim loTemp_ProPagos As EETemp_ProPagos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Temp_ProPagos_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTemp_ProPagos Is Nothing Then
                    ListaTemp_ProPagos = New List(Of EETemp_ProPagos)()
                End If

                loTemp_ProPagos = New EETemp_ProPagos()

                loTemp_ProPagos.ProPaId = dr("ProPaId").ToString()
                loTemp_ProPagos.ProPaAño = dr("ProPaAño").ToString()
                loTemp_ProPagos.ContId = dr("ContId").ToString()
                loTemp_ProPagos.PerId = dr("PerId").ToString()
                loTemp_ProPagos.Persona = dr("PerNombre").ToString()
                loTemp_ProPagos.Contacto = dr("ContDescripcion").ToString()
                loTemp_ProPagos.ProPaNroCuota = Convert.ToInt32(dr("ProPaNroCuota").ToString())
                loTemp_ProPagos.ConId = dr("ConId").ToString()
                loTemp_ProPagos.ConNombre = dr("ConNombre").ToString()
                loTemp_ProPagos.ProPa_PSaimt = Convert.ToDecimal(dr("ProPa_PSaimt").ToString())
                loTemp_ProPagos.ProPa_PMpt = Convert.ToDecimal(dr("ProPa_PMpt").ToString())
                loTemp_ProPagos.ProPaFecVen = IIf(IsDBNull(dr("ProPaFecVen")), Nothing, dr("ProPaFecVen"))
                loTemp_ProPagos.ProPaDetMonto = Convert.ToDecimal(dr("ProPaDetMonto").ToString())
                loTemp_ProPagos.TgEstadoId = dr("TgEstadoId").ToString()
                loTemp_ProPagos.ProPaFecPag = IIf(IsDBNull(dr("ProPaFecPag")), Nothing, dr("ProPaFecPag"))
                loTemp_ProPagos.ProPaCtaSaimt = Convert.ToDecimal(dr("ProPaCtaSaimt").ToString())
                loTemp_ProPagos.ProPaCtaMpt = Convert.ToDecimal(dr("ProPaCtaMpt").ToString())
                loTemp_ProPagos.ProPaMoraSaimt = Convert.ToDecimal(dr("ProPaMoraSaimt").ToString())
                loTemp_ProPagos.ProPaMoraMpt = Convert.ToDecimal(dr("ProPaMoraMpt").ToString())
                loTemp_ProPagos.ProPaComCtaSaimt = Convert.ToDecimal(dr("ProPaComCtaSaimt").ToString())
                loTemp_ProPagos.ProPaComCtaMpt = Convert.ToDecimal(dr("ProPaComCtaMpt").ToString())
                loTemp_ProPagos.ProPaTotal = Convert.ToDecimal(dr("ProPaTotal").ToString())
                loTemp_ProPagos.proPaActualizado = Convert.ToBoolean(dr("proPaActualizado").ToString())
                loTemp_ProPagos.proPaFecAct = Convert.ToDateTime(dr("proPaFecAct").ToString())

                ListaTemp_ProPagos.Add(loTemp_ProPagos)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ALL Temp_ProPagos => " & ex.Message, ex)
        End Try
        Return ListaTemp_ProPagos
    End Function
#End Region

#Region "Listar Datos Importados X FechaPago"
    Public Shared Function listarDatosImportadosXFechaPago(ByVal adtFechaPago As Date) As List(Of EETemp_ProPagos)
        Dim ListaTemp_ProPagos As List(Of EETemp_ProPagos) = Nothing
        Dim loTemp_ProPagos As EETemp_ProPagos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Temp_ProPagos_XFechaPago")
            db.AddInParameter(cmd, "fechapago", DbType.Date, adtFechaPago)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTemp_ProPagos Is Nothing Then
                    ListaTemp_ProPagos = New List(Of EETemp_ProPagos)()
                End If

                loTemp_ProPagos = New EETemp_ProPagos()

                loTemp_ProPagos.ProPaId = dr("ProPaId").ToString()
                loTemp_ProPagos.ProPaAño = dr("ProPaAño").ToString()
                loTemp_ProPagos.ContId = dr("ContId").ToString()
                loTemp_ProPagos.PerId = dr("PerId").ToString()
                loTemp_ProPagos.Persona = dr("PerNombre").ToString()
                loTemp_ProPagos.Contacto = dr("ContDescripcion").ToString()
                loTemp_ProPagos.ProPaNroCuota = Convert.ToInt32(dr("ProPaNroCuota").ToString())
                loTemp_ProPagos.ConId = dr("ConId").ToString()
                loTemp_ProPagos.ConNombre = dr("ConNombre").ToString()
                loTemp_ProPagos.ProPa_PSaimt = Convert.ToDecimal(dr("ProPa_PSaimt").ToString())
                loTemp_ProPagos.ProPa_PMpt = Convert.ToDecimal(dr("ProPa_PMpt").ToString())
                loTemp_ProPagos.ProPaFecVen = IIf(IsDBNull(dr("ProPaFecVen")), Nothing, dr("ProPaFecVen"))
                loTemp_ProPagos.ProPaDetMonto = Convert.ToDecimal(dr("ProPaDetMonto").ToString())
                loTemp_ProPagos.TgEstadoId = dr("TgEstadoId").ToString()
                loTemp_ProPagos.ProPaFecPag = IIf(IsDBNull(dr("ProPaFecPag")), Nothing, dr("ProPaFecPag"))
                loTemp_ProPagos.ProPaCtaSaimt = Convert.ToDecimal(dr("ProPaCtaSaimt").ToString())
                loTemp_ProPagos.ProPaCtaMpt = Convert.ToDecimal(dr("ProPaCtaMpt").ToString())
                loTemp_ProPagos.ProPaMoraSaimt = Convert.ToDecimal(dr("ProPaMoraSaimt").ToString())
                loTemp_ProPagos.ProPaMoraMpt = Convert.ToDecimal(dr("ProPaMoraMpt").ToString())
                loTemp_ProPagos.ProPaComCtaSaimt = Convert.ToDecimal(dr("ProPaComCtaSaimt").ToString())
                loTemp_ProPagos.ProPaComCtaMpt = Convert.ToDecimal(dr("ProPaComCtaMpt").ToString())
                loTemp_ProPagos.ProPaTotal = Convert.ToDecimal(dr("ProPaTotal").ToString())
                loTemp_ProPagos.proPaActualizado = Convert.ToBoolean(dr("proPaActualizado").ToString())
                loTemp_ProPagos.proPaFecAct = IIf(IsDBNull(dr("proPaFecAct")), Nothing, dr("proPaFecAct").ToString())
                ListaTemp_ProPagos.Add(loTemp_ProPagos)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Temp_ProPagos Criterio => " + ex.Message, ex)
        End Try
        Return ListaTemp_ProPagos
    End Function
#End Region

End Class
