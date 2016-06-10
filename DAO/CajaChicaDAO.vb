Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class CajaChicaDAO

    Public Shared Function guardarDet(ByVal aoCajaChicaDet As EECajaChica.EECajaChicaDet) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_CajaChicaDet_pa")

            db.AddInParameter(cmd, "ccConfId", DbType.String, aoCajaChicaDet.ccConfId)
            db.AddInParameter(cmd, "cajid", DbType.String, aoCajaChicaDet.CajId)
            db.AddInParameter(cmd, "cajdetfechamov", DbType.DateTime, aoCajaChicaDet.CajDetFechaMov)
            db.AddInParameter(cmd, "perid", DbType.String, aoCajaChicaDet.PerId)
            db.AddInParameter(cmd, "perAreaId", DbType.String, aoCajaChicaDet.PerAreaId)
            db.AddInParameter(cmd, "conid", DbType.String, aoCajaChicaDet.ConId)
            db.AddInParameter(cmd, "partid", DbType.String, aoCajaChicaDet.PartId)
            db.AddInParameter(cmd, "cajdetdescripcion", DbType.String, aoCajaChicaDet.CajDetDescripcion)
            db.AddInParameter(cmd, "tgtipodocid", DbType.String, aoCajaChicaDet.TgTipoDocId)
            db.AddInParameter(cmd, "cajdetdocnro", DbType.String, aoCajaChicaDet.CajDetDocNro)
            db.AddInParameter(cmd, "cajdetdocserie", DbType.String, aoCajaChicaDet.CajDetDocSerie)
            db.AddInParameter(cmd, "cajdetimporte", DbType.Decimal, aoCajaChicaDet.CajDetImporte)
            db.AddInParameter(cmd, "usuid", DbType.Int32, aoCajaChicaDet.UsuId)
            db.AddInParameter(cmd, "cajdetanulada", DbType.Boolean, aoCajaChicaDet.CajDetAnulada)
            db.AddInParameter(cmd, "tggrupoid", DbType.String, aoCajaChicaDet.TgGrupoId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar CajaChicaDet => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizarDet(ByVal aoCajaChicaDet As EECajaChica.EECajaChicaDet) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_CajaChicaDet_pa")

            db.AddInParameter(cmd, "cajdetid", DbType.String, aoCajaChicaDet.CajDetId)
            db.AddInParameter(cmd, "cajid", DbType.String, aoCajaChicaDet.CajId)
            db.AddInParameter(cmd, "cajdetfechamov", DbType.DateTime, aoCajaChicaDet.CajDetFechaMov)
            db.AddInParameter(cmd, "perid", DbType.String, aoCajaChicaDet.PerId)
            db.AddInParameter(cmd, "perAreaId", DbType.String, aoCajaChicaDet.PerAreaId)
            db.AddInParameter(cmd, "conid", DbType.String, aoCajaChicaDet.ConId)
            db.AddInParameter(cmd, "partid", DbType.String, aoCajaChicaDet.PartId)
            db.AddInParameter(cmd, "cajdetdescripcion", DbType.String, aoCajaChicaDet.CajDetDescripcion)
            db.AddInParameter(cmd, "tgtipodocid", DbType.String, aoCajaChicaDet.TgTipoDocId)
            db.AddInParameter(cmd, "cajdetdocnro", DbType.String, aoCajaChicaDet.CajDetDocNro)
            db.AddInParameter(cmd, "cajdetdocserie", DbType.String, aoCajaChicaDet.CajDetDocSerie)
            db.AddInParameter(cmd, "cajdetimporte", DbType.Decimal, aoCajaChicaDet.CajDetImporte)
            db.AddInParameter(cmd, "usuid", DbType.Int32, aoCajaChicaDet.UsuId)
            db.AddInParameter(cmd, "cajdetanulada", DbType.Boolean, aoCajaChicaDet.CajDetAnulada)
            db.AddInParameter(cmd, "tggrupoid", DbType.String, aoCajaChicaDet.TgGrupoId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar CajaChicaDet => " & ex.Message, ex)
        End Try
        Return True
    End Function
    Public Shared Function listarDetxCajId(ByVal CajId As String) As List(Of EECajaChica.EECajaChicaDet)
        Dim ListaCajaChicaDet As List(Of EECajaChica.EECajaChicaDet) = Nothing
        Dim loCajaChicaDet As EECajaChica.EECajaChicaDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CajaChicaDet_XcajId_pa")
            db.AddInParameter(cmd, "CajId", DbType.String, CajId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCajaChicaDet Is Nothing Then
                    ListaCajaChicaDet = New List(Of EECajaChica.EECajaChicaDet)
                End If
                loCajaChicaDet = New EECajaChica.EECajaChicaDet()
                loCajaChicaDet.CajNro = dr("CajNro").ToString()
                loCajaChicaDet.CajId = dr("CajId").ToString()
                loCajaChicaDet.CajDetFechaMov = IIf(IsDBNull(dr("CajDetFechaMov")), Nothing, dr("CajDetFechaMov"))
                loCajaChicaDet.Persona = dr("Persona").ToString()
                loCajaChicaDet.PerNDoc = dr("perNDoc").ToString()
                loCajaChicaDet.Area = dr("Area").ToString()
                loCajaChicaDet.AreaS = dr("AreaS").ToString()
                ' loCajaChicaDet.Cargo = dr("Cargo").ToString()
                loCajaChicaDet.TgGrupo = dr("TgGrupo").ToString()
                loCajaChicaDet.tgTipoDoc = dr("tgTipoDoc").ToString()
                loCajaChicaDet.CajDetDescripcion = dr("CajDetDescripcion").ToString()
                loCajaChicaDet.CajDetDocSerie = dr("CajDetDocSerie").ToString()
                loCajaChicaDet.CajDetDocNro = dr("CajDetDocNro").ToString()
                loCajaChicaDet.CajDetImporte = Convert.ToDecimal(dr("CajDetImporte").ToString())
                loCajaChicaDet.PartId = dr("partId").ToString()
                loCajaChicaDet.usuario = dr("usuLogin").ToString()
                loCajaChicaDet.CajDetAnulada = Convert.ToBoolean(dr("CajDetAnulada").ToString())
                ListaCajaChicaDet.Add(loCajaChicaDet)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar CajaChicaDet Criterio => " & ex.Message, ex)
        End Try
        Return ListaCajaChicaDet
    End Function

    Public Shared Function listarDetResumenPartidasxCajId(ByVal CajId As String) As List(Of EECajaChica.EECajaChicaDet)
        Dim ListaCajaChicaDet As List(Of EECajaChica.EECajaChicaDet) = Nothing
        Dim loCajaChicaDet As EECajaChica.EECajaChicaDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CajaChicaDet_ResumenPartidas_XcajId_pa")
            db.AddInParameter(cmd, "CajId", DbType.String, CajId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCajaChicaDet Is Nothing Then
                    ListaCajaChicaDet = New List(Of EECajaChica.EECajaChicaDet)
                End If
                loCajaChicaDet = New EECajaChica.EECajaChicaDet()
                loCajaChicaDet.CajDetImporte = Convert.ToDecimal(dr("CajDetImporte").ToString())
                loCajaChicaDet.PartId = dr("partId").ToString()
                ListaCajaChicaDet.Add(loCajaChicaDet)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar CajaChicaDet Criterio => " & ex.Message, ex)
        End Try
        Return ListaCajaChicaDet
    End Function

    Public Shared Function listarDetxCajDetId(ByVal CajDetId As String) As EECajaChica.EECajaChicaDet
        Dim loCajaChicaDet As EECajaChica.EECajaChicaDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CajaChicaDet_XcajDetId_pa")
            db.AddInParameter(cmd, "CajDetId", DbType.String, CajDetId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loCajaChicaDet = New EECajaChica.EECajaChicaDet()
                loCajaChicaDet.CajNro = dr("CajNro").ToString()
                loCajaChicaDet.CajDetId = dr("CajDetId").ToString()
                loCajaChicaDet.CajId = dr("CajId").ToString()
                loCajaChicaDet.CajDetFechaMov = IIf(IsDBNull(dr("CajDetFechaMov")), Nothing, dr("CajDetFechaMov"))
                loCajaChicaDet.Persona = dr("Persona").ToString()
                loCajaChicaDet.PerId = dr("PerId").ToString()
                loCajaChicaDet.PerAreaId = dr("PerAreaId").ToString()
                loCajaChicaDet.Area = dr("Area").ToString()
                loCajaChicaDet.Cargo = dr("Cargo").ToString()
                loCajaChicaDet.TgGrupo = dr("TgGrupo").ToString()
                loCajaChicaDet.TgGrupoId = dr("TgGrupoId").ToString()
                loCajaChicaDet.tgTipoDoc = dr("tgTipoDoc").ToString()
                loCajaChicaDet.TgTipoDocId = dr("tgTipoDocId").ToString()
                loCajaChicaDet.CajDetDescripcion = dr("CajDetDescripcion").ToString()
                loCajaChicaDet.CajDetDocSerie = dr("cajDetDocSerie").ToString
                loCajaChicaDet.CajDetDocNro = dr("cajDetDocNro").ToString
                'loCajaChicaDet.DocSerieNumero = String.Format("{0}-{1}", dr("cajDetDocSerie"), dr("cajDetDocNro"))
                loCajaChicaDet.CajDetImporte = Convert.ToDecimal(dr("CajDetImporte").ToString())
                loCajaChicaDet.PartId = dr("partId").ToString()
                loCajaChicaDet.usuario = dr("usuLogin").ToString()
                loCajaChicaDet.CajDetAnulada = Convert.ToBoolean(dr("CajDetAnulada").ToString())
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar CajaChicaDet Criterio => " & ex.Message, ex)
        End Try
        Return loCajaChicaDet
    End Function

    Public Shared Function BlistarDetxCriterios(ByVal tipocriterio As Int16, ByVal criterio As String) As List(Of EECajaChica.EECajaChicaDet)
        Dim ListaCajaChicaDet As List(Of EECajaChica.EECajaChicaDet) = Nothing
        Dim loCajaChicaDet As EECajaChica.EECajaChicaDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CajaChicaDet_X_BCriterio_pa")
            db.AddInParameter(cmd, "tipocriterio", DbType.Int16, tipocriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCajaChicaDet Is Nothing Then
                    ListaCajaChicaDet = New List(Of EECajaChica.EECajaChicaDet)
                End If
                loCajaChicaDet = New EECajaChica.EECajaChicaDet()
                loCajaChicaDet.CajDetId = dr("CajDetId").ToString()
                loCajaChicaDet.CajNro = dr("CajNro").ToString()
                loCajaChicaDet.CajId = dr("CajId").ToString()
                loCajaChicaDet.CajDetFechaMov = IIf(IsDBNull(dr("CajDetFechaMov")), Nothing, dr("CajDetFechaMov"))
                loCajaChicaDet.Persona = dr("Persona").ToString()
                ListaCajaChicaDet.Add(loCajaChicaDet)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar CajaChicaDet Criterio => " & ex.Message, ex)
        End Try
        Return ListaCajaChicaDet
    End Function


#Region "Caja Chica Configuración"

    Public Shared Function guardarCajaChicaConfig(ByVal aoCajaChicaConfig As EECajaChica.EECajaChicaConfiguracion) As Boolean

        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_CajaChicaConfig_pa")

                db.AddInParameter(cmd, "ccConfId", DbType.String, aoCajaChicaConfig.CcConfId)
                db.AddInParameter(cmd, "tgAreaId", DbType.String, aoCajaChicaConfig.TgAreaId)
                'db.AddInParameter(cmd, "ccConfNCajasInTime", DbType.Int16, aoCajaChicaConfig.CcConfNCajasInTime)
                db.AddInParameter(cmd, "ccConfMaxCajasxAnio", DbType.String, aoCajaChicaConfig.CcConfMaxCajasxAnio)
                db.AddInParameter(cmd, "ccConfMaxFondoTotal", DbType.Decimal, aoCajaChicaConfig.CcConfMaxFondoTotal)
                db.AddInParameter(cmd, "ccConfMinPorCierre", DbType.Int16, aoCajaChicaConfig.ccConfMinPorCierre)
                db.AddInParameter(cmd, "ccConfActivo", DbType.Boolean, aoCajaChicaConfig.CcConfActivo)
                'db.AddInParameter(cmd, "CcConfInicioNroDoc", DbType.String, aoCajaChicaConfig.ccConfInicioNroDoc)
                ' db.AddInParameter(cmd, "CcConfInicioSerieDoc", DbType.String, aoCajaChicaConfig.ccConfInicioSerieDoc)
                db.ExecuteNonQuery(cmd, transaccion)
                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Guardar CajaChicaConfig => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function

    Public Shared Function actualizarCajaChicaConfig(ByVal aoCajaChicaConfig As EECajaChica.EECajaChicaConfiguracion) As Boolean

        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_CajaChicaConfig_pa")

                db.AddInParameter(cmd, "ccConfId", DbType.String, aoCajaChicaConfig.CcConfId)
                db.AddInParameter(cmd, "tgAreaId", DbType.String, aoCajaChicaConfig.TgAreaId)
                ' db.AddInParameter(cmd, "ccConfNCajasInTime", DbType.String, aoCajaChicaConfig.CcConfNCajasInTime)
                db.AddInParameter(cmd, "ccConfMaxCajasxAnio", DbType.String, aoCajaChicaConfig.CcConfMaxCajasxAnio)
                db.AddInParameter(cmd, "ccConfMaxFondoTotal", DbType.Decimal, aoCajaChicaConfig.CcConfMaxFondoTotal)
                db.AddInParameter(cmd, "ccConfMinPorCierre", DbType.Int16, aoCajaChicaConfig.ccConfMinPorCierre)
                db.AddInParameter(cmd, "ccConfActivo", DbType.Boolean, aoCajaChicaConfig.CcConfActivo)
                ' db.AddInParameter(cmd, "CcConfInicioNroDoc", DbType.String, aoCajaChicaConfig.ccConfInicioNroDoc)
                ' db.AddInParameter(cmd, "CcConfInicioSerieDoc", DbType.String, aoCajaChicaConfig.ccConfInicioSerieDoc)
                db.ExecuteNonQuery(cmd, transaccion)
                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Actualizar CajaChicaConfig => " + ex.Message, ex)
            End Try
        End Using
        Return True

    End Function

#End Region

#Region "Caja Chica"
    Public Shared Function guardar(ByVal aoCajaChica As EECajaChica) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_CajaChica_pa")

            'db.AddInParameter(cmd, "cajid", DbType.String, aoCajaChica.CajId)
            db.AddInParameter(cmd, "tganioid", DbType.String, aoCajaChica.loCajaChicaConfiguracion.CcConfAnio)
            db.AddInParameter(cmd, "TgAreaId", DbType.String, aoCajaChica.loCajaChicaConfiguracion.TgAreaId)
            db.AddInParameter(cmd, "tgbancoid", DbType.String, aoCajaChica.TgBancoId)
            db.AddInParameter(cmd, "cajfondoretiro", DbType.Decimal, aoCajaChica.CajFondoRetiro)
            db.AddInParameter(cmd, "cajfondoanterior", DbType.String, aoCajaChica.CajFondoAnterior)
            db.AddInParameter(cmd, "cajfondototal", DbType.Decimal, aoCajaChica.CajFondoTotal)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoCajaChica.TgEstadoId)
            db.AddInParameter(cmd, "cajfechainicio", DbType.DateTime, aoCajaChica.CajFechaInicio)
            db.AddInParameter(cmd, "cajfechafin", DbType.DateTime, aoCajaChica.CajFechaFin)

            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar CajaChica => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal aoCajaChica As EECajaChica) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_CajaChica_pa")

            db.AddInParameter(cmd, "cajid", DbType.String, aoCajaChica.CajId)
            'db.AddInParameter(cmd, "tgbancoid", DbType.String, aoCajaChica.TgBancoId)
            'db.AddInParameter(cmd, "cajfondoretiro", DbType.Decimal, aoCajaChica.CajFondoRetiro)
            'db.AddInParameter(cmd, "cajfondoanterior", DbType.String, aoCajaChica.CajFondoAnterior)
            db.AddInParameter(cmd, "cajfondocierre", DbType.Decimal, aoCajaChica.CajFondoCierre)
            db.AddInParameter(cmd, "tgestadoid", DbType.String, aoCajaChica.TgEstadoId)
            ' db.AddInParameter(cmd, "cajfechainicio", DbType.DateTime, aoCajaChica.CajFechaInicio)
            db.AddInParameter(cmd, "cajfechafin", DbType.DateTime, aoCajaChica.CajFechaFin)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar CajaChica => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region
End Class


