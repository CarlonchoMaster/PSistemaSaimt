Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ProcedimientoSTDDAO
    Public Shared Function guardar(aoProcedimientoSTD As EEProcedimientoSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_ProcedimientoSTD_pa")

            db.AddInParameter(cmd, "procid", DbType.String, aoProcedimientoSTD.ProcId)
            db.AddInParameter(cmd, "procnombre", DbType.String, aoProcedimientoSTD.ProcNombre)
            db.AddInParameter(cmd, "procdescripcion", DbType.String, aoProcedimientoSTD.ProcDescripcion)
            db.AddInParameter(cmd, "procmaxdia", DbType.Int32, aoProcedimientoSTD.ProcMaxDia)
            db.AddInParameter(cmd, "tgcalificacionid", DbType.String, aoProcedimientoSTD.TgCalificacionId)
            db.AddInParameter(cmd, "tgareainicio", DbType.String, aoProcedimientoSTD.TgAreaInicio)
            db.AddInParameter(cmd, "tgareafin", DbType.String, aoProcedimientoSTD.TgAreaFin)
            db.AddInParameter(cmd, "procfinalidad", DbType.String, aoProcedimientoSTD.ProcFinalidad)
            db.AddInParameter(cmd, "procbaselegal", DbType.String, aoProcedimientoSTD.ProcBaseLegal)
            db.AddInParameter(cmd, "procdertramite", DbType.String, aoProcedimientoSTD.ProcDerTramite)
            db.AddInParameter(cmd, "procactivo", DbType.Boolean, aoProcedimientoSTD.ProcActivo)
            db.AddInParameter(cmd, "procpuit", DbType.Decimal, aoProcedimientoSTD.ProcPUIT)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar ProcedimientoSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(aoProcedimientoSTD As EEProcedimientoSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_ProcedimientoSTD_pa")

            db.AddInParameter(cmd, "procid", DbType.String, aoProcedimientoSTD.ProcId)
            db.AddInParameter(cmd, "procnombre", DbType.String, aoProcedimientoSTD.ProcNombre)
            db.AddInParameter(cmd, "procdescripcion", DbType.String, aoProcedimientoSTD.ProcDescripcion)
            db.AddInParameter(cmd, "procmaxdia", DbType.Int32, aoProcedimientoSTD.ProcMaxDia)
            db.AddInParameter(cmd, "tgcalificacionid", DbType.String, aoProcedimientoSTD.TgCalificacionId)
            db.AddInParameter(cmd, "tgareainicio", DbType.String, aoProcedimientoSTD.TgAreaInicio)
            db.AddInParameter(cmd, "tgareafin", DbType.String, aoProcedimientoSTD.TgAreaFin)
            db.AddInParameter(cmd, "procfinalidad", DbType.String, aoProcedimientoSTD.ProcFinalidad)
            db.AddInParameter(cmd, "procbaselegal", DbType.String, aoProcedimientoSTD.ProcBaseLegal)
            db.AddInParameter(cmd, "procdertramite", DbType.String, aoProcedimientoSTD.ProcDerTramite)
            db.AddInParameter(cmd, "procactivo", DbType.Boolean, aoProcedimientoSTD.ProcActivo)
            db.AddInParameter(cmd, "procpuit", DbType.Decimal, aoProcedimientoSTD.ProcPUIT)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar ProcedimientoSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(aiIdProcedimientoSTD As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_ProcedimientoSTD_pa")

            db.AddInParameter(cmd, "idProcedimientoSTD", DbType.Int32, aiIdProcedimientoSTD)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar ProcedimientoSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As String) As List(Of EEProcedimientoSTD)
        Dim ListaProcedimientoSTD As List(Of EEProcedimientoSTD) = Nothing
        Dim loProcedimientoSTD As EEProcedimientoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Dim oTGCalificacion As EETablaGeneral
        Dim oTGAreaInicio As EETablaGeneral
        Dim oTGAreaFin As EETablaGeneral

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProcedimientoSTD_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProcedimientoSTD Is Nothing Then
                    ListaProcedimientoSTD = New List(Of EEProcedimientoSTD)()
                End If
                loProcedimientoSTD = New EEProcedimientoSTD()
                loProcedimientoSTD.ProcId = dr("ProcId").ToString()
                loProcedimientoSTD.ProcNombre = dr("ProcNombre").ToString()
                loProcedimientoSTD.ProcDescripcion = dr("ProcDescripcion").ToString()
                loProcedimientoSTD.ProcMaxDia = Convert.ToInt32(dr("ProcMaxDia").ToString())
                If IsDBNull(dr("tgCalificacionId")) Then
                    loProcedimientoSTD.TgCalificacionId = String.Empty
                Else
                    loProcedimientoSTD.TgCalificacionId = dr("tgCalificacionId").ToString
                End If
                loProcedimientoSTD.TgAreaInicio = dr("TgAreaInicio").ToString()
                loProcedimientoSTD.TgAreaFin = dr("TgAreaFin").ToString()
                loProcedimientoSTD.ProcFinalidad = dr("ProcFinalidad").ToString()
                loProcedimientoSTD.ProcBaseLegal = dr("ProcBaseLegal").ToString()
                loProcedimientoSTD.ProcDerTramite = dr("ProcDerTramite").ToString()
                loProcedimientoSTD.ProcActivo = Convert.ToBoolean(dr("ProcActivo"))
                loProcedimientoSTD.ProcPUIT = Convert.ToDecimal(dr("ProcPUIT"))
                oTGCalificacion = New EETablaGeneral
                oTGCalificacion.TgNombre = dr("tgCalificacion").ToString
                oTGAreaInicio = New EETablaGeneral
                oTGAreaInicio.TgNombre = dr("tgAreaInicioNombre").ToString
                oTGAreaFin = New EETablaGeneral
                oTGAreaFin.TgNombre = dr("tgAreaFinNombre").ToString
                loProcedimientoSTD.OUTablaGeneralCalificacion = oTGCalificacion
                loProcedimientoSTD.OUTablaGeneralAreaInicio = oTGAreaInicio
                loProcedimientoSTD.OUTablaGeneralAreaFin = oTGAreaFin
                ListaProcedimientoSTD.Add(loProcedimientoSTD)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ProcedimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaProcedimientoSTD
    End Function

    Public Shared Function listarALL() As List(Of EEProcedimientoSTD)
        Dim ListaProcedimientoSTD As List(Of EEProcedimientoSTD) = Nothing
        Dim loProcedimientoSTD As EEProcedimientoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProcedimientoSTDALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProcedimientoSTD Is Nothing Then
                    ListaProcedimientoSTD = New List(Of EEProcedimientoSTD)()
                End If

                loProcedimientoSTD = New EEProcedimientoSTD()
                loProcedimientoSTD.ProcId = dr("ProcId").ToString()
                loProcedimientoSTD.ProcNombre = dr("ProcNombre").ToString()
                ListaProcedimientoSTD.Add(loProcedimientoSTD)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ALL ProcedimientoSTD => " & ex.Message, ex)
        End Try
        Return ListaProcedimientoSTD
    End Function
End Class


