Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class CajaChicaDAS

    Public Shared Function MostrarAnteriorFondoCierreXtgAreaId_tgAnioId(ByVal tgAreaId As [String], ByVal tgAnioId As [String]) As Decimal
        Dim dr As IDataReader = Nothing
        Dim FondoCierre As Decimal
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_CajaChicaAnteriorFondoCierre_XTgAreaId_tgAnioId_pa")
            db.AddInParameter(cmd, "tgAreaId", DbType.String, tgAreaId)
            db.AddInParameter(cmd, "tgAnioId", DbType.String, tgAnioId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                FondoCierre = Convert.ToDecimal(dr("cajFondoCierre").ToString())
            End If

        Catch ex As Exception
            Throw New Exception("Mostrar Fondo Cierre X Area y Anio => " & ex.Message, ex)
        End Try
        Return FondoCierre
    End Function

    Public Shared Function ListarXtgAreaId_tgAnioId(ByVal tgAreaId As [String], ByVal tgAnioId As [String]) As List(Of EECajaChica)
        Dim ListaCajaChica As List(Of EECajaChica) = Nothing
        Dim loCajaChica As EECajaChica = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CajaChica_XTgAreaId_TgAnioId_pa")
            db.AddInParameter(cmd, "tgAreaId", DbType.String, tgAreaId)
            db.AddInParameter(cmd, "tgAnioId", DbType.String, tgAnioId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCajaChica Is Nothing Then
                    ListaCajaChica = New List(Of EECajaChica)
                End If
                loCajaChica = New EECajaChica()
                loCajaChica.CajId = dr("CajId").ToString()
                loCajaChica.CajFondoRetiro = Convert.ToDecimal(dr("CajFondoRetiro").ToString())
                loCajaChica.CajFondoAnterior = dr("CajFondoAnterior").ToString()
                loCajaChica.CajFondoTotal = Convert.ToDecimal(dr("CajFondoTotal").ToString())
                loCajaChica.TgEstadoId = dr("TgEstadoId").ToString()
                loCajaChica.TgEstado = dr("TgEstado").ToString()
                loCajaChica.CajFechaInicio = IIf(IsDBNull(dr("CajFechaInicio")), Nothing, dr("CajFechaInicio"))
                loCajaChica.CajFechaFin = IIf(IsDBNull(dr("CajFechaFin")), Nothing, dr("CajFechaFin"))
           
                ListaCajaChica.Add(loCajaChica)
            End While

        Catch ex As Exception
            Throw New Exception("Listar x TgAreaId y TgAnio  => " & ex.Message, ex)
        End Try
        Return ListaCajaChica
    End Function

    Public Shared Function ListarCajNroXtgAreaId_tgAnioId(ByVal tgAreaId As [String], ByVal tgAnioId As [String]) As List(Of EECajaChica)
        Dim ListaCajaChica As List(Of EECajaChica) = Nothing
        Dim loCajaChica As EECajaChica = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CajasChica_CajNro_XTgAreaId_TgAnioId_pa")
            db.AddInParameter(cmd, "tgAreaId", DbType.String, tgAreaId)
            db.AddInParameter(cmd, "tgAnioId", DbType.String, tgAnioId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCajaChica Is Nothing Then
                    ListaCajaChica = New List(Of EECajaChica)
                End If
                loCajaChica = New EECajaChica()
                loCajaChica.CajId = dr("CajId").ToString()
                loCajaChica.CajNro = dr("CajNro").ToString()
                ListaCajaChica.Add(loCajaChica)
            End While

        Catch ex As Exception
            Throw New Exception("Listar x TgAreaId y TgAnio  => " & ex.Message, ex)
        End Try
        Return ListaCajaChica
    End Function

    Public Shared Function MostrarCajaAbiertaXtgAreaId(ByVal tgAreaId As [String]) As EECajaChica
        Dim loCajaChica As EECajaChica = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_CajaChicaAbierta_XTgAreaId_pa")
            db.AddInParameter(cmd, "tgAreaId", DbType.String, tgAreaId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loCajaChica = New EECajaChica()
                loCajaChica.CajId = dr("CajId").ToString()
                loCajaChica.CajFondoTotal = Convert.ToDecimal(dr("CajFondoTotal").ToString())
                loCajaChica.CajFondoAnterior = Convert.ToDecimal(dr("CajFondoAnterior").ToString())
                loCajaChica.CajFondoRetiro = Convert.ToDecimal(dr("CajFondoRetiro").ToString())
            End If
        Catch ex As Exception
            Throw New Exception("Mostrar Caja Abierta x TgAreaId => " & ex.Message, ex)
        End Try
        Return loCajaChica
    End Function


    Public Shared Function MostrarCajaXCajId(ByVal CajId As [String]) As EECajaChica
        Dim loCajaChica As EECajaChica = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_CajaChica_XCajId_pa")
            db.AddInParameter(cmd, "CajId", DbType.String, CajId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loCajaChica = New EECajaChica()
                loCajaChica.CajId = dr("CajId").ToString()
                loCajaChica.CajFondoTotal = Convert.ToDecimal(dr("CajFondoTotal").ToString())
                loCajaChica.CajFondoAnterior = Convert.ToDecimal(dr("CajFondoAnterior").ToString())
                loCajaChica.CajFondoRetiro = Convert.ToDecimal(dr("CajFondoRetiro").ToString())
                loCajaChica.TgEstadoId = dr("TgEstadoId").ToString()
                loCajaChica.CajFechaInicio = IIf(IsDBNull(dr("CajFechaInicio")), Nothing, dr("CajFechaInicio"))
                loCajaChica.CajFechaFin = IIf(IsDBNull(dr("CajFechaFin")), Nothing, dr("CajFechaFin"))
            End If
        Catch ex As Exception
            Throw New Exception("Mostrar Caja Abierta x TgAreaId => " & ex.Message, ex)
        End Try
        Return loCajaChica
    End Function


    Public Shared Function MostrarCajaMontoUtilizadoXCajID(ByVal CajId As [String]) As Decimal
        Dim CajMontoUtilizado As Decimal
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_CajaChicaMontoUtilizado_XCajId_pa")
            db.AddInParameter(cmd, "CajId", DbType.String, CajId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                CajMontoUtilizado = Convert.ToDecimal(dr("CajMontoUtilizado").ToString())
            End If
        Catch ex As Exception
            Throw New Exception("Mostrar Caja Abierta x TgAreaId => " & ex.Message, ex)
        End Try
        Return CajMontoUtilizado
    End Function

    Public Shared Function ListarConfiguracionXtgAreaId_tgAnioId(ByVal tgAreaId As [String], ByVal tgAnioId As [String]) As EECajaChica.EECajaChicaConfiguracion
        Dim loCajaChicaConfig As EECajaChica.EECajaChicaConfiguracion = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CajaChicaConfig_XtgAreaId_tgAnioId_pa")
            db.AddInParameter(cmd, "tgAreaId", DbType.String, tgAreaId)
            db.AddInParameter(cmd, "tgAnioId", DbType.String, tgAnioId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loCajaChicaConfig = New EECajaChica.EECajaChicaConfiguracion()
                loCajaChicaConfig.CcConfId = dr("ccConfId").ToString()
                loCajaChicaConfig.CcConfAnio = dr("ccConfAnio").ToString()
                loCajaChicaConfig.TgAreaId = dr("tgAreaId").ToString()
                loCajaChicaConfig.CcConfMaxCajasxAnio = dr("CcConfMaxCajasxAnio").ToString()
                loCajaChicaConfig.CcConfMaxFondoTotal = Convert.ToDecimal(dr("CcConfMaxFondoTotal").ToString())
                loCajaChicaConfig.CcConfActivo = dr("CcConfActivo").ToString()
                '0  loCajaChicaConfig.ccConfInicioNroDoc = dr("ccConfInicioNroDoc").ToString()
                ' loCajaChicaConfig.ccConfInicioSerieDoc = dr("CcConfInicioSerieDoc").ToString()
            End If
        Catch ex As Exception
            Throw New Exception("Listar Configuracion x TgAreaId y TgAnio  => " & ex.Message, ex)
        End Try
        Return loCajaChicaConfig
    End Function

    Public Shared Function ListarConfiguracionActivaXtgAreaId(ByVal tgAreaId As [String]) As EECajaChica.EECajaChicaConfiguracion
        Dim loCajaChicaConfig As EECajaChica.EECajaChicaConfiguracion = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CajaChicaConfigActivo_XtgAreaId_pa")
            db.AddInParameter(cmd, "tgAreaId", DbType.String, tgAreaId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loCajaChicaConfig = New EECajaChica.EECajaChicaConfiguracion()
                loCajaChicaConfig.CcConfId = dr("ccConfId").ToString()
                loCajaChicaConfig.CcConfAnio = dr("ccConfAnio").ToString()
                loCajaChicaConfig.TgAreaId = dr("tgAreaId").ToString()
                loCajaChicaConfig.CcConfMaxCajasxAnio = dr("CcConfMaxCajasxAnio").ToString()
                loCajaChicaConfig.CcConfMaxFondoTotal = Convert.ToDecimal(dr("CcConfMaxFondoTotal").ToString())
                loCajaChicaConfig.CcConfActivo = dr("CcConfActivo").ToString()
                ' loCajaChicaConfig.ccConfInicioNroDoc = dr("ccConfInicioNroDoc").ToString()
                ' loCajaChicaConfig.ccConfInicioSerieDoc = dr("CcConfInicioSerieDoc").ToString()
            End If
        Catch ex As Exception
            Throw New Exception("Listar Configuracion x TgAreaId y TgAnio  => " & ex.Message, ex)
        End Try
        Return loCajaChicaConfig
    End Function

    Public Shared Function generaCodigoCajaChicaConfig(ByVal aiAnio As String) As String
        Dim ccConfId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_CajaChicaConfig_ccConfId")
            db.AddInParameter(cmd, "anio", DbType.Int32, aiAnio)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                ccConfId = dr("ccConfId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Id Caja Chica Configuración => " + ex.Message, ex)
        End Try
        Return ccConfId
    End Function

    Public Shared Function ListarConfigAreasXtgAnioId(ByVal tgAnioId As String) As List(Of EECajaChica.EECajaChicaConfiguracion)
        Dim loCajaChicaConfiguracion As EECajaChica.EECajaChicaConfiguracion
        Dim ListaCajaChicaConf As List(Of EECajaChica.EECajaChicaConfiguracion) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CajaChicaConfig_Areas_XTgAnioId_pa")
            db.AddInParameter(cmd, "tgAnioId", DbType.Int32, tgAnioId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCajaChicaConf Is Nothing Then
                    ListaCajaChicaConf = New List(Of EECajaChica.EECajaChicaConfiguracion)
                End If
                loCajaChicaConfiguracion = New EECajaChica.EECajaChicaConfiguracion
                loCajaChicaConfiguracion.TgArea = dr("tgArea").ToString()
                loCajaChicaConfiguracion.TgAreaId = dr("tgAreaId").ToString()
                ListaCajaChicaConf.Add(loCajaChicaConfiguracion)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Area XTgAnioId => " + ex.Message, ex)
        End Try
        Return ListaCajaChicaConf
    End Function

    Public Shared Function CountXtgAreaId_TgEstadoId(ByVal tgAreaId As String, ByVal tgEstadoId As String) As Integer
        Dim count As Integer = 0
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_CajaChica_Count_XTgAreaId_TgEstadoId_pa")
            db.AddInParameter(cmd, "tgAreaId", DbType.String, tgAreaId)
            db.AddInParameter(cmd, "tgEstadoId", DbType.String, tgEstadoId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                count = IIf(IsDBNull(dr("nCajas")), 0, dr("nCajas"))
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Contar Nro de Cajas X Area y Estado => " + ex.Message, ex)
        End Try
        Return count
    End Function

   
End Class
