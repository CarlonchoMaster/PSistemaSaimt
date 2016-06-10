Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class RecaudacionDAO
    Public Shared Function guardar(ByVal aoRecaudacion As EERecaudacion) As Boolean
        Dim IsSaved As Boolean = False
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Recaudacion_pa")
            db.AddInParameter(cmd, "recid", DbType.Int32, aoRecaudacion.RecId)
            db.AddInParameter(cmd, "recfecpago", DbType.DateTime, aoRecaudacion.RecFecPago)
            db.AddInParameter(cmd, "recnroorden", DbType.String, aoRecaudacion.RecNroOrden)
            db.AddInParameter(cmd, "conid", DbType.String, aoRecaudacion.ConId)
            db.AddInParameter(cmd, "recnro", DbType.String, aoRecaudacion.RecNro)
            db.AddInParameter(cmd, "tgtipodoc", DbType.String, aoRecaudacion.TgTipoDoc)
            db.AddInParameter(cmd, "pernrodoc", DbType.String, aoRecaudacion.PerNroDoc)
            db.AddInParameter(cmd, "pernombre", DbType.String, aoRecaudacion.PerNombre)
            db.AddInParameter(cmd, "recmonto", DbType.Decimal, aoRecaudacion.RecMonto)
            db.AddInParameter(cmd, "conporcentaje", DbType.Decimal, aoRecaudacion.ConPorcentaje)
            db.AddInParameter(cmd, "rectotaling", DbType.Decimal, aoRecaudacion.RecTotalIng)
            db.AddInParameter(cmd, "recvcomision", DbType.Decimal, aoRecaudacion.RecVComision)
            db.AddInParameter(cmd, "reccomision", DbType.Decimal, aoRecaudacion.RecComision)
            db.AddInParameter(cmd, "recneto", DbType.Decimal, aoRecaudacion.RecNeto)
            db.AddInParameter(cmd, "usuid", DbType.Int32, aoRecaudacion.UsuId)
            db.AddInParameter(cmd, "tgrecaudadorid", DbType.String, aoRecaudacion.TgRecaudadorId)
            db.AddInParameter(cmd, "recact", DbType.String, aoRecaudacion.RecAct)
            db.AddInParameter(cmd, "recfecact", DbType.DateTime, aoRecaudacion.RecFecAct)
            If db.ExecuteNonQuery(cmd) > 0 Then
                IsSaved = True
            Else
                IsSaved = False
            End If
        Catch ex As Exception
            Throw New Exception("Guardar Recaudacion => " + ex.Message, ex)
        End Try
        Return IsSaved
    End Function

    Public Shared Function guardarTransferencia(ByVal aoRecaudacion As EERecaudacion) As Int16
        Dim RecId As Int16 = False
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDRemoto)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Recaudacion_Trasnferencia_pa")
            db.AddOutParameter(cmd, "recid", DbType.Int32, 11)
            db.AddInParameter(cmd, "recfecpago", DbType.DateTime, aoRecaudacion.RecFecPago)
            db.AddInParameter(cmd, "recnroorden", DbType.String, aoRecaudacion.RecNroOrden)
            db.AddInParameter(cmd, "conid", DbType.String, aoRecaudacion.ConId)
            db.AddInParameter(cmd, "recnro", DbType.String, aoRecaudacion.RecNro)
            db.AddInParameter(cmd, "tgtipodoc", DbType.String, aoRecaudacion.TgTipoDoc)
            db.AddInParameter(cmd, "pernrodoc", DbType.String, aoRecaudacion.PerNroDoc)
            db.AddInParameter(cmd, "pernombre", DbType.String, aoRecaudacion.PerNombre)
            db.AddInParameter(cmd, "recmonto", DbType.Decimal, aoRecaudacion.RecMonto)
            db.AddInParameter(cmd, "conporcentaje", DbType.Decimal, aoRecaudacion.ConPorcentaje)
            db.AddInParameter(cmd, "rectotaling", DbType.Decimal, aoRecaudacion.RecTotalIng)
            db.AddInParameter(cmd, "recvcomision", DbType.Decimal, aoRecaudacion.RecVComision)
            db.AddInParameter(cmd, "reccomision", DbType.Decimal, aoRecaudacion.RecComision)
            db.AddInParameter(cmd, "recneto", DbType.Decimal, aoRecaudacion.RecNeto)
            db.AddInParameter(cmd, "usuid", DbType.Int32, aoRecaudacion.UsuId)
            db.AddInParameter(cmd, "tgrecaudadorid", DbType.String, aoRecaudacion.TgRecaudadorId)
            db.AddInParameter(cmd, "recact", DbType.String, aoRecaudacion.RecAct)
            ' db.AddInParameter(cmd, "recfecact", DbType.DateTime, aoRecaudacion.RecFecAct)
            db.ExecuteNonQuery(cmd)
            RecId = db.GetParameterValue(cmd, "recId")

        Catch ex As Exception
            Throw New Exception("Guardar Recaudacion => " + ex.Message, ex)
        End Try
        Return RecId
    End Function

    Public Shared Function actualizar(ByVal aoRecaudacion As EERecaudacion, ByVal tipoCriterio As String) As Boolean
        Dim IsUpdated As Boolean = False
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Recaudacion_pa")
            db.AddInParameter(cmd, "tipocriterio", DbType.String, tipoCriterio)
            db.AddInParameter(cmd, "recid", DbType.Int32, aoRecaudacion.RecId)
            db.AddInParameter(cmd, "recfecpago", DbType.DateTime, aoRecaudacion.RecFecPago)
            db.AddInParameter(cmd, "recnroorden", DbType.String, aoRecaudacion.RecNroOrden)
            db.AddInParameter(cmd, "conid", DbType.String, aoRecaudacion.ConId)
            db.AddInParameter(cmd, "recnro", DbType.String, aoRecaudacion.RecNro)
            db.AddInParameter(cmd, "tgTipoDoc", DbType.String, aoRecaudacion.TgTipoDoc)
            db.AddInParameter(cmd, "pernrodoc", DbType.String, aoRecaudacion.PerNroDoc)
            db.AddInParameter(cmd, "pernombre", DbType.String, aoRecaudacion.PerNombre)
            db.AddInParameter(cmd, "recmonto", DbType.Decimal, aoRecaudacion.RecMonto)
            db.AddInParameter(cmd, "conporcentaje", DbType.Decimal, aoRecaudacion.ConPorcentaje)
            db.AddInParameter(cmd, "rectotaling", DbType.Decimal, aoRecaudacion.RecTotalIng)
            db.AddInParameter(cmd, "recvcomision", DbType.Decimal, aoRecaudacion.RecVComision)
            db.AddInParameter(cmd, "reccomision", DbType.Decimal, aoRecaudacion.RecComision)
            db.AddInParameter(cmd, "recneto", DbType.Decimal, aoRecaudacion.RecNeto)
            db.AddInParameter(cmd, "tgRecaudadorId", DbType.String, aoRecaudacion.TgRecaudadorId)
            db.AddInParameter(cmd, "recFecLiquidacion", DbType.DateTime, aoRecaudacion.RecFechaLiquidacion)
            If db.ExecuteNonQuery(cmd) > 0 Then
                IsUpdated = True
            Else
                IsUpdated = False
            End If

        Catch ex As Exception
            Throw New Exception("Actualizar Recaudacion => " & ex.Message, ex)
        End Try
        Return IsUpdated
    End Function

    Public Shared Function eliminar(ByVal recFecPago As Date, ByVal tgRecaudadorId As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_RecaudacionXrecFecPago_tgRecaudadorId")

            db.AddInParameter(cmd, "recFecPago", DbType.Date, recFecPago)
            db.AddInParameter(cmd, "tgRecaudadorId", DbType.String, tgRecaudadorId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Recaudacion => " & ex.Message, ex)
        End Try
        Return True
    End Function


#Region "WEB"
    Public Shared Function guardarWEB(ByVal alstRecaudacion As List(Of EERecaudacion)) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    For Each aoRecaudacion As EERecaudacion In alstRecaudacion
                        cmd = db.GetStoredProcCommand("Insertar_Recaudacion_WEB_pa")
                        db.AddInParameter(cmd, "recid", DbType.Int32, aoRecaudacion.RecId)
                        db.AddInParameter(cmd, "recfecpago", DbType.DateTime, aoRecaudacion.RecFecPago)
                        db.AddInParameter(cmd, "recnroorden", DbType.String, aoRecaudacion.RecNroOrden)
                        db.AddInParameter(cmd, "conid", DbType.String, aoRecaudacion.ConId)
                        db.AddInParameter(cmd, "recnro", DbType.String, aoRecaudacion.RecNro)
                        db.AddInParameter(cmd, "tgtipodoc", DbType.String, aoRecaudacion.TgTipoDoc)
                        db.AddInParameter(cmd, "pernrodoc", DbType.String, aoRecaudacion.PerNroDoc)
                        db.AddInParameter(cmd, "pernombre", DbType.String, aoRecaudacion.PerNombre)
                        db.AddInParameter(cmd, "recmonto", DbType.Decimal, aoRecaudacion.RecMonto)
                        db.AddInParameter(cmd, "conporcentaje", DbType.Decimal, aoRecaudacion.ConPorcentaje)
                        db.AddInParameter(cmd, "rectotaling", DbType.Decimal, aoRecaudacion.RecTotalIng)
                        db.AddInParameter(cmd, "recvcomision", DbType.Decimal, aoRecaudacion.RecVComision)
                        db.AddInParameter(cmd, "reccomision", DbType.Decimal, aoRecaudacion.RecComision)
                        db.AddInParameter(cmd, "recneto", DbType.Decimal, aoRecaudacion.RecNeto)
                        db.AddInParameter(cmd, "usuid", DbType.Int32, aoRecaudacion.UsuId)
                        db.AddInParameter(cmd, "tgrecaudadorid", DbType.String, aoRecaudacion.TgRecaudadorId)
                        db.AddInParameter(cmd, "recact", DbType.String, aoRecaudacion.RecAct)
                        db.AddInParameter(cmd, "recfecact", DbType.DateTime, aoRecaudacion.RecFecAct)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar Recaudacion => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizarFechaLiquidacionWEB(ByVal adtFechaLiquidacion As DateTime?, ByVal aiRecId As Int32, ByVal adRecFecPago As Date, ByVal asTgRecaudadorId As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Recaudacion_FechaLiquidacion_WEB_pa")
            db.AddInParameter(cmd, "recid", DbType.Int32, aiRecId)
            db.AddInParameter(cmd, "recfecpago", DbType.Date, adRecFecPago)
            db.AddInParameter(cmd, "tgrecaudadorid", DbType.String, asTgRecaudadorId)
            db.AddInParameter(cmd, "recfecliquidacion", DbType.DateTime, adtFechaLiquidacion)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar Recaudacion Fecha Liquidación => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function guardarDetalleWEB(ByVal aoRecaudacionDet As EERecaudacion.EERecaudacionDet) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_RecaudacionDet_pa")

            db.AddInParameter(cmd, "recid", DbType.Int32, aoRecaudacionDet.RecId)
            db.AddInParameter(cmd, "recfecpago", DbType.DateTime, aoRecaudacionDet.RecFecPago)
            db.AddInParameter(cmd, "tgrecaudadorid", DbType.String, aoRecaudacionDet.TgRecaudadorId)
            db.AddInParameter(cmd, "conid", DbType.String, aoRecaudacionDet.ConId)
            db.AddInParameter(cmd, "recdmonto", DbType.Decimal, aoRecaudacionDet.RecDMonto)
            db.AddInParameter(cmd, "conporcentaje", DbType.Decimal, aoRecaudacionDet.ConPorcentaje)
            db.AddInParameter(cmd, "recdtotaling", DbType.Decimal, aoRecaudacionDet.RecDTotalIng)
            db.AddInParameter(cmd, "recDFechaLiquidacion", DbType.DateTime, aoRecaudacionDet.RecDFechaLiquidacion)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar RecaudacionDet => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminarDetalleWEB(ByVal aiRecId As Int32, ByVal adRecFecPago As Date, ByVal asTgRecaudadorId As String, ByVal asConId As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_RecaudacionDet_WEB_pa")

            db.AddInParameter(cmd, "recId", DbType.Int32, aiRecId)
            db.AddInParameter(cmd, "recFecPago", DbType.Date, adRecFecPago)
            db.AddInParameter(cmd, "tgRecaudadorId", DbType.String, asTgRecaudadorId)
            db.AddInParameter(cmd, "conid", DbType.String, asConId)

            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Validar Recaudacion Detalle => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminarXFechaPagoWEB(ByVal adRecFecPago As Date) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Recaudacion_XRecFecPago_WEB_pa")

            db.AddInParameter(cmd, "recFecPago", DbType.Date, adRecFecPago)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Recaudacion X FechaPago WEB => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

End Class



