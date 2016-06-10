Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class MovimientoDAO
    Public Shared Function guardar(ByVal aoMovimiento As EEMovimiento) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Movimiento_pa")
            db.AddInParameter(cmd, "movid", DbType.String, aoMovimiento.MovId)
            db.AddInParameter(cmd, "movnro", DbType.String, aoMovimiento.MovNro)
            db.AddInParameter(cmd, "movserie", DbType.String, aoMovimiento.MovSerie)
            db.AddInParameter(cmd, "tgmonedaid", DbType.String, aoMovimiento.TgMonedaId)
            db.AddInParameter(cmd, "movfechapag", DbType.DateTime, aoMovimiento.MovFechaPag)
            db.AddInParameter(cmd, "tgrecaudadoraid", DbType.String, aoMovimiento.TgRecaudadoraId)
            db.AddInParameter(cmd, "tgcomprobanteid", DbType.String, aoMovimiento.TgComprobanteId)
            db.AddInParameter(cmd, "tgMovimientoId", DbType.String, aoMovimiento.TgMovimientoId)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Guardar Movimiento => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal aoMovimiento As EEMovimiento) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Movimiento_pa")

            db.AddInParameter(cmd, "movid", DbType.String, aoMovimiento.MovId)
            db.AddInParameter(cmd, "movnro", DbType.String, aoMovimiento.MovNro)
            db.AddInParameter(cmd, "movserie", DbType.String, aoMovimiento.MovSerie)
            db.AddInParameter(cmd, "tgmonedaid", DbType.String, aoMovimiento.TgMonedaId)
            db.AddInParameter(cmd, "tgcambioid", DbType.Decimal, aoMovimiento.TgCambioId)
            db.AddInParameter(cmd, "movfechapag", DbType.DateTime, aoMovimiento.MovFechaPag)
            db.AddInParameter(cmd, "tgrecaudadoraid", DbType.String, aoMovimiento.TgRecaudadoraId)
            db.AddInParameter(cmd, "tgcomprobanteid", DbType.String, aoMovimiento.TgComprobanteId)
            db.AddInParameter(cmd, "movfechareg", DbType.DateTime, aoMovimiento.MovFechaReg)
            db.AddInParameter(cmd, "tgmovimientoid", DbType.String, aoMovimiento.TgMovimientoId)
            db.AddInParameter(cmd, "moveliminado", DbType.String, aoMovimiento.MovEliminado)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar Movimiento => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(ByVal aiIdMovimiento As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Movimiento_pa")

            db.AddInParameter(cmd, "idMovimiento", DbType.Int32, aiIdMovimiento)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Movimiento => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEMovimiento)
        Dim ListaMovimiento As List(Of EEMovimiento) = Nothing
        Dim loMovimiento As EEMovimiento = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Movimiento_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimiento Is Nothing Then
                    ListaMovimiento = New List(Of EEMovimiento)()
                End If

                loMovimiento = New EEMovimiento()

                loMovimiento.MovId = dr("MovId").ToString()
                loMovimiento.MovNro = dr("MovNro").ToString()
                loMovimiento.MovSerie = dr("MovSerie").ToString()
                loMovimiento.TgMonedaId = dr("TgMonedaId").ToString()
                loMovimiento.TgCambioId = Convert.ToDecimal(dr("TgCambioId").ToString())
                loMovimiento.MovFechaPag = IIf(IsDBNull(dr("MovFechaPag")), Nothing, dr("MovFechaPag"))
                loMovimiento.TgRecaudadoraId = dr("TgRecaudadoraId").ToString()
                loMovimiento.TgComprobanteId = dr("TgComprobanteId").ToString()
                loMovimiento.MovFechaReg = IIf(IsDBNull(dr("MovFechaReg")), Nothing, dr("MovFechaReg"))
                loMovimiento.TgMovimientoId = dr("TgMovimientoId").ToString()
                loMovimiento.MovEliminado = dr("MovEliminado").ToString()


                ListaMovimiento.Add(loMovimiento)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Movimiento Criterio => " + ex.Message, ex)
        End Try
        Return ListaMovimiento
    End Function

    Public Shared Function listarALL() As List(Of EEMovimiento)
        Dim ListaMovimiento As List(Of EEMovimiento) = Nothing
        Dim loMovimiento As EEMovimiento = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Movimiento_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimiento Is Nothing Then
                    ListaMovimiento = New List(Of EEMovimiento)()
                End If

                loMovimiento = New EEMovimiento()

                loMovimiento.MovId = dr("MovId").ToString()
                loMovimiento.MovNro = dr("MovNro").ToString()
                loMovimiento.MovSerie = dr("MovSerie").ToString()
                loMovimiento.TgMonedaId = dr("TgMonedaId").ToString()
                loMovimiento.TgCambioId = Convert.ToDecimal(dr("TgCambioId").ToString())
                loMovimiento.MovFechaPag = IIf(IsDBNull(dr("MovFechaPag")), Nothing, dr("MovFechaPag"))
                loMovimiento.TgRecaudadoraId = dr("TgRecaudadoraId").ToString()
                loMovimiento.TgComprobanteId = dr("TgComprobanteId").ToString()
                loMovimiento.MovFechaReg = IIf(IsDBNull(dr("MovFechaReg")), Nothing, dr("MovFechaReg"))
                loMovimiento.TgMovimientoId = dr("TgMovimientoId").ToString()
                loMovimiento.MovEliminado = dr("MovEliminado").ToString()


                ListaMovimiento.Add(loMovimiento)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ALL Movimiento => " & ex.Message, ex)
        End Try
        Return ListaMovimiento
    End Function
End Class