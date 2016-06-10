Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ProPagosDAO

#Region "Guardar Programacion de Pagos"
    Public Shared Function guardar(ByVal aoProPagos As EEProPagos) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()

                    For Each fProPagos As EEProPagos In aoProPagos.ListaProPagos
                        cmd = db.GetStoredProcCommand("Insertar_ProPagos_FormularioProPagos_pa")
                        db.AddInParameter(cmd, "propaid", DbType.String, fProPagos.ProPaId)
                        db.AddInParameter(cmd, "propanrocuota", DbType.Int32, fProPagos.ProPaNroCuota)
                        db.AddInParameter(cmd, "tgtipocompid", DbType.String, fProPagos.OTgTipoComprobante.TgCodigo)
                        db.AddInParameter(cmd, "coninmid", DbType.String, fProPagos.OContratoInm.ConInmId)
                        db.AddInParameter(cmd, "propafechaven", DbType.DateTime, fProPagos.ProPaFechaVen)
                        db.AddInParameter(cmd, "tgestadoid", DbType.String, fProPagos.OTgEstado.TgCodigo)
                        db.AddInParameter(cmd, "propadetigv", DbType.Decimal, fProPagos.ProPaDetIgv)
                        db.AddInParameter(cmd, "propapmora", DbType.Decimal, fProPagos.ProPaPMora)
                        db.AddInParameter(cmd, "propaaplicad", DbType.String, fProPagos.ProPaAplicaD)
                        db.AddInParameter(cmd, "tgrecaudadoraid", DbType.String, fProPagos.OTgRecaudadora.TgCodigo)
                        db.AddInParameter(cmd, "tgmonedaid", DbType.String, fProPagos.OTgMoneda.TgCodigo)
                        'db.AddInParameter(cmd, "tgcambioid", DbType.Decimal, fProPagos.TgCambioId)
                        'db.AddInParameter(cmd, "propacomision", DbType.Decimal, fProPagos.ProPaComision)
                        db.ExecuteNonQuery(cmd, transaccion)

                        For Each fProPagosDetalle As EEProPagos.EEProPagosDet In fProPagos.ListaProgramacionPagosDetalle
                            cmd = db.GetStoredProcCommand("Insertar_ProPagosDet_FormularioProPagos_pa")
                            db.AddInParameter(cmd, "propaid", DbType.String, fProPagosDetalle.ProPaId)
                            db.AddInParameter(cmd, "conid", DbType.String, fProPagosDetalle.OConcepto.ConId)
                            db.AddInParameter(cmd, "propadetmonto", DbType.Decimal, fProPagosDetalle.ProPaDetMonto)
                            db.AddInParameter(cmd, "propadetpconcepto", DbType.Decimal, fProPagosDetalle.ProPaDetPConcepto)
                            db.AddInParameter(cmd, "propadetaplicam", DbType.String, fProPagosDetalle.ProPaDetAplicaM)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar ProPagos => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Actualizar Programacion de Pagos"
    Public Shared Function actualizar(ByVal aoProPagos As EEProPagos) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()

                    For Each fProPagos As EEProPagos In aoProPagos.ListaProPagos
                        For Each fProPaDetEliminado As String In fProPagos.ListaTemporalProPagosDetalleEliminados
                            Dim aspro As String() = fProPaDetEliminado.Split("-")
                            cmd = db.GetStoredProcCommand("Eliminar_ProPagosDet_XProPaId_XConId_pa")
                            db.AddInParameter(cmd, "propaid", DbType.String, aspro(0))
                            db.AddInParameter(cmd, "conid", DbType.String, aspro(1))
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next

                        If fProPagos.GuardarOrUpdate = True Then
                            cmd = db.GetStoredProcCommand("Actualizar_ProPagos_FormularioProPagos_pa")
                            db.AddInParameter(cmd, "propaid", DbType.String, fProPagos.ProPaId)
                            db.AddInParameter(cmd, "tgtipocompid", DbType.String, fProPagos.OTgTipoComprobante.TgCodigo)
                            db.AddInParameter(cmd, "propaaplicad", DbType.String, fProPagos.ProPaAplicaD)
                            db.AddInParameter(cmd, "propafechaven", DbType.DateTime, fProPagos.ProPaFechaVen)
                            db.AddInParameter(cmd, "tgestadoid", DbType.String, fProPagos.OTgEstado.TgCodigo)
                            db.AddInParameter(cmd, "tgmonedaid", DbType.String, fProPagos.OTgMoneda.TgCodigo)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Else
                            cmd = db.GetStoredProcCommand("Insertar_ProPagos_FormularioProPagos_pa")
                            db.AddInParameter(cmd, "propaid", DbType.String, fProPagos.ProPaId)
                            db.AddInParameter(cmd, "propanrocuota", DbType.Int32, fProPagos.ProPaNroCuota)
                            db.AddInParameter(cmd, "tgtipocompid", DbType.String, fProPagos.OTgTipoComprobante.TgCodigo)
                            db.AddInParameter(cmd, "coninmid", DbType.String, fProPagos.OContratoInm.ConInmId)
                            db.AddInParameter(cmd, "propafechaven", DbType.DateTime, fProPagos.ProPaFechaVen)
                            db.AddInParameter(cmd, "tgestadoid", DbType.String, fProPagos.OTgEstado.TgCodigo)
                            db.AddInParameter(cmd, "propadetigv", DbType.Decimal, fProPagos.ProPaDetIgv)
                            db.AddInParameter(cmd, "propapmora", DbType.Decimal, fProPagos.ProPaPMora)
                            db.AddInParameter(cmd, "propaaplicad", DbType.String, fProPagos.ProPaAplicaD)
                            db.AddInParameter(cmd, "tgrecaudadoraid", DbType.String, fProPagos.OTgRecaudadora.TgCodigo)
                            db.AddInParameter(cmd, "tgmonedaid", DbType.String, fProPagos.OTgMoneda.TgCodigo)
                            'db.AddInParameter(cmd, "tgcambioid", DbType.Decimal, fProPagos.TgCambioId)
                            'db.AddInParameter(cmd, "propacomision", DbType.Decimal, fProPagos.ProPaComision)
                            db.ExecuteNonQuery(cmd, transaccion)
                        End If


                        For Each fProPagosDetalle As EEProPagos.EEProPagosDet In fProPagos.ListaProgramacionPagosDetalle
                            If fProPagosDetalle.GuardarOrUpdate = True Then
                                cmd = db.GetStoredProcCommand("Actualizar_ProPagosDet_FormularioProPagos_pa")
                                db.AddInParameter(cmd, "propaid", DbType.String, fProPagosDetalle.ProPaId)
                                db.AddInParameter(cmd, "conid", DbType.String, fProPagosDetalle.OConcepto.ConId)
                                db.AddInParameter(cmd, "propadetmonto", DbType.Decimal, fProPagosDetalle.ProPaDetMonto)
                                db.ExecuteNonQuery(cmd, transaccion)
                            Else
                                cmd = db.GetStoredProcCommand("Insertar_ProPagosDet_FormularioProPagos_pa")
                                db.AddInParameter(cmd, "propaid", DbType.String, fProPagosDetalle.ProPaId)
                                db.AddInParameter(cmd, "conid", DbType.String, fProPagosDetalle.OConcepto.ConId)
                                db.AddInParameter(cmd, "propadetmonto", DbType.Decimal, fProPagosDetalle.ProPaDetMonto)
                                db.AddInParameter(cmd, "propadetpconcepto", DbType.Decimal, fProPagosDetalle.ProPaDetPConcepto)
                                db.AddInParameter(cmd, "propadetaplicam", DbType.String, fProPagosDetalle.ProPaDetAplicaM)
                                db.ExecuteNonQuery(cmd, transaccion)
                            End If
                        Next
                    Next

                    cmd = db.GetStoredProcCommand("Actualizar_ContratoInm_Terminado_ProgramacionPagos_pa")
                    db.AddInParameter(cmd, "coninmid", DbType.String, aoProPagos.ListaProPagos(0).OContratoInm.ConInmId)
                    db.ExecuteNonQuery(cmd, transaccion)


                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar ProPagos => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Actualizar Detracciones"
    Public Shared Function actualizarDetracciones(ByVal alProPaIds As List(Of String)) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)

            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()

                    For Each fProPaIds As String In alProPaIds
                        cmd = db.GetStoredProcCommand("Actualizar_ProgramacionPagos_Detracciones_pa")
                        db.AddInParameter(cmd, "propaid", DbType.String, fProPaIds)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Detracciones => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Importador"
    Public Shared Function importar(ByVal aoProPagos As EEProPagos) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_GastoComision_pa")
                    db.AddInParameter(cmd, "gascomfec", DbType.DateTime, aoProPagos.OGastoComision.GasComFec)
                    db.AddInParameter(cmd, "gascomvalor", DbType.Decimal, aoProPagos.OGastoComision.GasComValor)
                    db.AddInParameter(cmd, "tgrecaudadoraid", DbType.String, aoProPagos.OGastoComision.TgRecaudadoraId)
                    db.ExecuteNonQuery(cmd, transaccion)
                    For Each fTemp_ProPagos As EETemp_ProPagos In aoProPagos.ListaTempProPagos
                        cmd = db.GetStoredProcCommand("Insertar_Temp_ProPagos_pa")
                        db.AddInParameter(cmd, "propaid", DbType.String, fTemp_ProPagos.ProPaId)
                        db.AddInParameter(cmd, "propaaño", DbType.String, fTemp_ProPagos.ProPaAño)
                        db.AddInParameter(cmd, "contid", DbType.String, fTemp_ProPagos.ContId)
                        db.AddInParameter(cmd, "perid", DbType.String, fTemp_ProPagos.PerId)
                        db.AddInParameter(cmd, "pernombre", DbType.String, fTemp_ProPagos.Persona)
                        db.AddInParameter(cmd, "contdescripcion", DbType.String, fTemp_ProPagos.Contacto)
                        db.AddInParameter(cmd, "propanrocuota", DbType.Int32, fTemp_ProPagos.ProPaNroCuota)
                        db.AddInParameter(cmd, "conid", DbType.String, fTemp_ProPagos.ConId)
                        db.AddInParameter(cmd, "connombre", DbType.String, fTemp_ProPagos.ConNombre)
                        db.AddInParameter(cmd, "propa_psaimt", DbType.Decimal, fTemp_ProPagos.ProPa_PSaimt)
                        db.AddInParameter(cmd, "propa_pmpt", DbType.Decimal, fTemp_ProPagos.ProPa_PMpt)
                        db.AddInParameter(cmd, "propafecven", DbType.Date, fTemp_ProPagos.ProPaFecVen)
                        db.AddInParameter(cmd, "propadetmonto", DbType.Decimal, fTemp_ProPagos.ProPaDetMonto)
                        db.AddInParameter(cmd, "tgestadoid", DbType.String, fTemp_ProPagos.TgEstadoId)
                        db.AddInParameter(cmd, "propafecpag", DbType.Date, fTemp_ProPagos.ProPaFecPag)
                        db.AddInParameter(cmd, "propactasaimt", DbType.Decimal, fTemp_ProPagos.ProPaCtaSaimt)
                        db.AddInParameter(cmd, "propactampt", DbType.Decimal, fTemp_ProPagos.ProPaCtaMpt)
                        db.AddInParameter(cmd, "propamorasaimt", DbType.Decimal, fTemp_ProPagos.ProPaMoraSaimt)
                        db.AddInParameter(cmd, "propamorampt", DbType.Decimal, fTemp_ProPagos.ProPaMoraMpt)
                        db.AddInParameter(cmd, "propacomctasaimt", DbType.Decimal, fTemp_ProPagos.ProPaComCtaSaimt)
                        db.AddInParameter(cmd, "propacomctampt", DbType.Decimal, fTemp_ProPagos.ProPaComCtaMpt)
                        db.AddInParameter(cmd, "propatotal", DbType.Decimal, fTemp_ProPagos.ProPaTotal)
                        db.AddInParameter(cmd, "propaactualizado", DbType.Boolean, fTemp_ProPagos.proPaActualizado)
                        db.AddInParameter(cmd, "propafecact", DbType.Date, fTemp_ProPagos.proPaFecAct)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    For Each fProPagos As EEProPagos In aoProPagos.ListaProPagos
                        cmd = db.GetStoredProcCommand("Actualizar_ProPagos_XProPaId_Importador_pa")
                        db.AddInParameter(cmd, "propaid", DbType.String, fProPagos.ProPaId)
                        db.AddInParameter(cmd, "tgestadoid", DbType.String, fProPagos.OTgEstado.TgCodigo)
                        db.AddInParameter(cmd, "propafechapag", DbType.DateTime, fProPagos.ProPaFechaPag)
                        db.AddInParameter(cmd, "propacomision", DbType.Decimal, (fProPagos.ProPaComision))
                        db.AddInParameter(cmd, "tgmonedaid", DbType.String, fProPagos.OTgMoneda.TgCodigo)
                        db.AddInParameter(cmd, "tgrecaudadoraid", DbType.String, fProPagos.OTgRecaudadora.TgCodigo)
                        db.AddInParameter(cmd, "coninmid", DbType.String, fProPagos.OContratoInm.ConInmId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    Dim ListaTempProPagosConceptoMora As List(Of EETemp_ProPagos) = aoProPagos.ListaTempProPagos.FindAll(Function(pred) pred.ConId = "S0835")
                    For Each fTemp_ProPagos As EETemp_ProPagos In ListaTempProPagosConceptoMora
                        cmd = db.GetStoredProcCommand("Actualizar_ProPagosDet_XProPaId_XConId_pa")
                        db.AddInParameter(cmd, "propaid", DbType.String, fTemp_ProPagos.ProPaId)
                        db.AddInParameter(cmd, "conid", DbType.String, fTemp_ProPagos.ConId)
                        db.AddInParameter(cmd, "propadetmonto", DbType.Decimal, fTemp_ProPagos.ProPaTotal)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    Dim ListaTempProPagosConceptoFincas As List(Of EETemp_ProPagos) = aoProPagos.ListaTempProPagos.FindAll(Function(pred) pred.ConId = "S0001")
                    Dim CantItemXProPaId As Decimal = ListaTempProPagosConceptoFincas.Count
                    Dim ComisionXitem As Decimal = 0.25 / CantItemXProPaId
                    For Each fTemp_ProPagos As EETemp_ProPagos In ListaTempProPagosConceptoFincas
                        cmd = db.GetStoredProcCommand("Actualizar_ProPagosDet_XProPaId")
                        db.AddInParameter(cmd, "propaid", DbType.String, fTemp_ProPagos.ProPaId)
                        db.AddInParameter(cmd, "proPaDetComision", DbType.Decimal, ComisionXitem)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    cmd = db.GetStoredProcCommand("verificar_mora_propagos_pa")
                    db.ExecuteNonQuery(cmd, transaccion)
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Importar ProPagos => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

End Class
