Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class InmUpdateDAO
    Public Shared Function guardarBaja(ByVal aoInmLogs As EEInmueble.EEInmLogs) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()

                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_InmUpdate_pa")

                    'Inmueble Insert
                    db.AddOutParameter(cmd, "InmUpdId", DbType.Int16, 11)
                    db.AddInParameter(cmd, "InmId", DbType.String, aoInmLogs.InmId)
                    db.AddInParameter(cmd, "InmUpdFechaReg", DbType.Date, aoInmLogs.InmUpdFechaReg)
                    db.AddInParameter(cmd, "InmUpdPerId", DbType.String, aoInmLogs.InmUpdPerId)
                    db.ExecuteNonQuery(cmd, transaccion)

                    Dim InmUpdId As String = db.GetParameterValue(cmd, "InmUpdId").ToString()

                    'Inmueble Update
                    cmd = db.GetStoredProcCommand("Actualizar_InmUpdate_pa")
                    db.AddInParameter(cmd, "inmUpdId", DbType.String, InmUpdId)
                    db.AddInParameter(cmd, "inmUpdDoc", DbType.String, aoInmLogs.inmUpdDoc)
                    db.AddInParameter(cmd, "inmUpdSupId", DbType.String, aoInmLogs.inmUpdSupId)
                    db.AddInParameter(cmd, "inmUpdObs", DbType.String, aoInmLogs.inmUpdObservacion)
                    db.AddInParameter(cmd, "inmUpdMov", DbType.String, aoInmLogs.inmUpdMotivo)
                    db.AddInParameter(cmd, "InmUpdFecDoc", DbType.Date, aoInmLogs.InmUpdFecDoc)
                    db.AddInParameter(cmd, "InmUpdFecRegUpd", DbType.Date, aoInmLogs.InmUpdFecRegUpd)
                    db.AddInParameter(cmd, "inmUpdPerUpdId", DbType.String, aoInmLogs.InmUpdPerUpdId)
                    db.AddInParameter(cmd, "tgTipoUpdId", DbType.String, aoInmLogs.tgTipoUpdId)
                    db.AddInParameter(cmd, "inmUpdActualizado", DbType.String, aoInmLogs.inmUpdActualizado)
                    db.ExecuteNonQuery(cmd, transaccion)


                    'Inmueble Update Det
                    If aoInmLogs.ListaInmLogsDet IsNot Nothing Then
                        For Each frow As EEInmueble.EEInmLogs.EEInmLogsDet In aoInmLogs.ListaInmLogsDet
                            cmd = db.GetStoredProcCommand("Insertar_InmUpdateDet_pa")
                            db.AddInParameter(cmd, "InmUpdId", DbType.String, InmUpdId)
                            db.AddInParameter(cmd, "InmUpdDetCampo", DbType.String, frow.InmUpdDetCampo)
                            db.AddInParameter(cmd, "InmUpdDetCampoText", DbType.String, frow.InmUpdDetCampoText)
                            db.AddInParameter(cmd, "InmUpdDetValorNew", DbType.String, frow.InmUpdDetValorNew)
                            db.AddInParameter(cmd, "InmUpdDetValorOld", DbType.String, frow.InmUpdDetValorOld)
                            db.AddInParameter(cmd, "InmUpdDetValorNew2", DbType.String, frow.InmUpdDetValorNew2)
                            db.AddInParameter(cmd, "InmUpdDetValorOld2", DbType.String, frow.InmUpdDetValorOld2)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If

                    If aoInmLogs.inmUpdActualizado = True Then

                        If aoInmLogs.ListaInmLogsDet IsNot Nothing Then
                            For Each lodetalle As EEInmueble.EEInmLogs.EEInmLogsDet In aoInmLogs.ListaInmLogsDet
                                cmd = db.GetStoredProcCommand("Actualizar_Inmueble_InmuebleUpdateXInmUpdDetId_pa")
                                'Inmueble Update
                                db.AddInParameter(cmd, "InmUpdDetId", DbType.String, lodetalle.InmUpdDetId)
                                db.ExecuteNonQuery(cmd, transaccion)
                            Next
                        End If
                     
                    End If
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar Inmueble Update => " + ex.Message, ex)
        End Try
        Return True
    End Function


    Public Shared Function guardar(ByVal aoInmLogs As EEInmueble.EEInmLogs) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()

                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_InmUpdate_pa")

                    'Inmueble Update
                    db.AddOutParameter(cmd, "InmUpdId", DbType.Int16, 11)
                    db.AddInParameter(cmd, "InmId", DbType.String, aoInmLogs.InmId)
                    db.AddInParameter(cmd, "InmUpdFechaReg", DbType.Date, aoInmLogs.InmUpdFechaReg)
                    db.AddInParameter(cmd, "InmUpdPerId", DbType.String, aoInmLogs.InmUpdPerId)

                    db.ExecuteNonQuery(cmd, transaccion)
                    Dim InmUpdId As String = db.GetParameterValue(cmd, "InmUpdId").ToString()
                    'Inmueble Update Det
                    For Each frow As EEInmueble.EEInmLogs.EEInmLogsDet In aoInmLogs.ListaInmLogsDet
                        cmd = db.GetStoredProcCommand("Insertar_InmUpdateDet_pa")
                        db.AddInParameter(cmd, "InmUpdId", DbType.String, InmUpdId)
                        db.AddInParameter(cmd, "InmUpdDetCampo", DbType.String, frow.InmUpdDetCampo)
                        db.AddInParameter(cmd, "InmUpdDetCampoText", DbType.String, frow.InmUpdDetCampoText)
                        db.AddInParameter(cmd, "InmUpdDetValorNew", DbType.String, frow.InmUpdDetValorNew)
                        db.AddInParameter(cmd, "InmUpdDetValorOld", DbType.String, frow.InmUpdDetValorOld)
                        db.AddInParameter(cmd, "InmUpdDetValorNew2", DbType.String, frow.InmUpdDetValorNew2)
                        db.AddInParameter(cmd, "InmUpdDetValorOld2", DbType.String, frow.InmUpdDetValorOld2)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar Inmueble Update => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function Update(ByVal aoInmLogs As EEInmueble.EEInmLogs) As Boolean
        Dim transaccion As DbTransaction = Nothing

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_InmUpdate_pa")

                    'Inmueble Update
                    db.AddInParameter(cmd, "inmUpdId", DbType.String, aoInmLogs.InmUpdId)
                    db.AddInParameter(cmd, "inmUpdDoc", DbType.String, aoInmLogs.inmUpdDoc)
                    db.AddInParameter(cmd, "inmUpdSupId", DbType.String, aoInmLogs.inmUpdSupId)
                    db.AddInParameter(cmd, "inmUpdObs", DbType.String, aoInmLogs.inmUpdObservacion)
                    db.AddInParameter(cmd, "inmUpdMov", DbType.String, aoInmLogs.inmUpdMotivo)
                    db.AddInParameter(cmd, "InmUpdFecDoc", DbType.Date, aoInmLogs.InmUpdFecDoc)
                    db.AddInParameter(cmd, "InmUpdFecRegUpd", DbType.Date, aoInmLogs.InmUpdFecRegUpd)
                    db.AddInParameter(cmd, "inmUpdPerUpdId", DbType.String, aoInmLogs.InmUpdPerUpdId)
                    db.AddInParameter(cmd, "tgTipoUpdId", DbType.String, aoInmLogs.tgTipoUpdId)
                    db.AddInParameter(cmd, "inmUpdActualizado", DbType.String, aoInmLogs.inmUpdActualizado)
                    db.ExecuteNonQuery(cmd, transaccion)


                    'If aoInmLogs.ListaInmArchivosTemporalEliminados IsNot Nothing Then
                    '    'Archivos
                    '    For Each fInmArchId As String In aoInmLogs.ListaInmArchivosTemporalEliminados
                    '        cmd = db.GetStoredProcCommand("Eliminar_InmArchivos_pa")
                    '        db.AddInParameter(cmd, "inmarchid", DbType.String, fInmArchId)
                    '        db.ExecuteNonQuery(cmd, transaccion)
                    '    Next
                    'End If

                    'If aoInmLogs.ListaInmArchivosTemporalNuevos IsNot Nothing Then
                    '    For Each fArchivos As EEInmArchivos In aoInmLogs.ListaInmArchivosTemporalNuevos
                    '        cmd = db.GetStoredProcCommand("InsertarU_InmArchivos_pa")
                    '        db.AddInParameter(cmd, "inmid", DbType.String, aoInmLogs.InmId)
                    '        db.AddInParameter(cmd, "inmarchnombre", DbType.String, fArchivos.InmArchNombre)
                    '        db.AddInParameter(cmd, "inmarchdescripcion", DbType.String, fArchivos.InmArchDescripcion)
                    '        db.AddInParameter(cmd, "tgtipoarchid", DbType.String, fArchivos.TgTipoArchId)
                    '        db.AddInParameter(cmd, "inmarch", DbType.Binary, fArchivos.InmArch)
                    '        db.AddInParameter(cmd, "inmarchext", DbType.String, fArchivos.InmArchExt)
                    '        db.AddInParameter(cmd, "inmarchprincipal", DbType.Boolean, fArchivos.InmArchPrincipal)
                    '        db.AddInParameter(cmd, "InmArchActivo", DbType.Boolean, fArchivos.InmArchActivo)
                    '        db.ExecuteNonQuery(cmd, transaccion)
                    '    Next
                    'End If

                    'If aoInmLogs.ListaInmArchivosEditados IsNot Nothing Then
                    '    'Actualizar Archivos que han sido editados
                    '    For Each fArchivos As EEInmArchivos In aoInmLogs.ListaInmArchivosEditados
                    '        cmd = db.GetStoredProcCommand("Actualizar_InmArchivos_pa")
                    '        db.AddInParameter(cmd, "inmarchid", DbType.String, fArchivos.InmArchId)
                    '        db.AddInParameter(cmd, "inmarchnombre", DbType.String, fArchivos.InmArchNombre)
                    '        db.AddInParameter(cmd, "inmarchdescripcion", DbType.String, fArchivos.InmArchDescripcion)
                    '        db.AddInParameter(cmd, "inmarchprincipal", DbType.Boolean, fArchivos.InmArchPrincipal)
                    '        db.AddInParameter(cmd, "InmArchActivo", DbType.Boolean, fArchivos.InmArchActivo)

                    '        db.ExecuteNonQuery(cmd, transaccion)
                    '    Next

                    'End If

                    'If aoInmLogs.ListaInmNivImp IsNot Nothing Then
                    '    'Nivel de Inmplementacion
                    '    For Each frow As EEInmNivelImp In aoInmLogs.ListaInmNivImp
                    '        cmd = db.GetStoredProcCommand("Actualizar_InmNivelImp_pa")
                    '        db.AddInParameter(cmd, "inmid", DbType.String, aoInmLogs.InmId)
                    '        db.AddInParameter(cmd, "tgnivimpid", DbType.String, frow.TgNivImpId)
                    '        db.AddInParameter(cmd, "inmnivfisico", DbType.Boolean, frow.InmNivfisico)
                    '        db.AddInParameter(cmd, "inmnivdigital", DbType.Boolean, frow.InmNivDigital)
                    '        db.ExecuteNonQuery(cmd, transaccion)
                    '    Next
                    'End If


                    If aoInmLogs.inmUpdActualizado = True Then

                        For Each lodetalle As EEInmueble.EEInmLogs.EEInmLogsDet In aoInmLogs.ListaInmLogsDet
                            cmd = db.GetStoredProcCommand("Actualizar_Inmueble_InmuebleUpdateXInmUpdDetId_pa")
                            'Inmueble Update
                            db.AddInParameter(cmd, "InmUpdDetId", DbType.String, lodetalle.InmUpdDetId)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If

                    ''Inmueble
                    'If aoInmLogs.tgNivelId IsNot Nothing Then
                    '    cmd = db.GetStoredProcCommand("Actualizar_Inmueble_tgNivelId_pa")
                    '    db.AddInParameter(cmd, "InmId", DbType.String, aoInmLogs.InmId)
                    '    db.AddInParameter(cmd, "tgNivelId", DbType.String, aoInmLogs.tgNivelId)
                    '    db.ExecuteNonQuery(cmd, transaccion)
                    'End If

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Inmueble Update => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function UpdateObservacion(ByVal aoInmLogs As EEInmueble.EEInmLogs) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_InmUpdate_inmUpdObs_pa")
                    db.AddInParameter(cmd, "inmUpdId", DbType.String, aoInmLogs.InmUpdId)
                    db.AddInParameter(cmd, "inmUpdObs", DbType.String, aoInmLogs.inmUpdObservacion)
                    db.AddInParameter(cmd, "inmUpdMov", DbType.String, aoInmLogs.inmUpdMotivo)
                    db.ExecuteNonQuery(cmd)
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Inmueble Update inmUpdObs => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function Update_Traspaso_Inmueble(ByVal inmUpdId As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Inmueble_InmuebleUpdate_pa")
                    'Inmueble Update
                    db.AddInParameter(cmd, "inmUpdId", DbType.String, inmUpdId)
                    db.ExecuteNonQuery(cmd)
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Información a Traspaso a Inmueble Update => " + ex.Message, ex)
        End Try
        Return True
    End Function


    Public Shared Function EliminarXinmUpdDetId(ByVal inmUpdDetId As Integer) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_InmUpdate_XInmUpdDetId_pa")
            Try
                'Inmueble Update
                db.AddInParameter(cmd, "inmUpdDetId", DbType.Int32, inmUpdDetId)
                db.ExecuteNonQuery(cmd)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try

        Catch ex As Exception
            Throw New Exception("Eliminar InmuebleUpd x InmUpdDetId => " + ex.Message, ex)
        End Try
        Return True
    End Function
End Class
