Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class OrdenServicioDAO
    Public Shared Function guardar(ByVal aoOrdenServicio As EEOrdenServicio) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_OrdenServicio_pa")
                db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenServicio.OrdId)
                db.AddInParameter(cmd, "ordnro", DbType.String, aoOrdenServicio.OrdNro)
                db.AddInParameter(cmd, "ordfechadoc", DbType.Date, aoOrdenServicio.OrdFechaDoc)
                db.AddInParameter(cmd, "tgestadoid", DbType.String, aoOrdenServicio.TgEstadoId)
                db.AddInParameter(cmd, "tgcomppagoid", DbType.String, aoOrdenServicio.TgCompPagoId)
                db.AddInParameter(cmd, "ordnrocomppago", DbType.String, aoOrdenServicio.OrdNroCompPago)
                db.AddInParameter(cmd, "perprovid", DbType.String, aoOrdenServicio.PerProvId)
                db.AddInParameter(cmd, "ordrefdoc", DbType.String, aoOrdenServicio.OrdRefDoc)
                db.AddInParameter(cmd, "tgcuentadebeid", DbType.String, aoOrdenServicio.TgCuentaDebeId)
                db.AddInParameter(cmd, "tgcuentadebe", DbType.Decimal, aoOrdenServicio.TgCuentaDebe)
                db.AddInParameter(cmd, "tgcuentahaberid", DbType.String, aoOrdenServicio.TgCuentaHaberId)
                db.AddInParameter(cmd, "tgcuentahaber", DbType.Decimal, aoOrdenServicio.TgCuentaHaber)
                db.AddInParameter(cmd, "cerid", DbType.String, aoOrdenServicio.CerId)
                db.AddInParameter(cmd, "cerCompId", DbType.String, aoOrdenServicio.CerCompId)
                db.AddInParameter(cmd, "ordimporte", DbType.Decimal, aoOrdenServicio.OrdImporte)
                db.AddInParameter(cmd, "ordImporteIGV", DbType.Decimal, aoOrdenServicio.OrdImporteIGV)
                db.AddInParameter(cmd, "ordParIgv", DbType.Decimal, aoOrdenServicio.OrdParIGV)
                db.AddInParameter(cmd, "ordRta4taTotal", DbType.Decimal, aoOrdenServicio.ordRta4taTotal)
                db.AddInParameter(cmd, "ordAjusteTotal", DbType.Decimal, aoOrdenServicio.OrdAjusteTotal)
                db.AddInParameter(cmd, "ordSubTotal", DbType.Decimal, aoOrdenServicio.OrdSubTotal)
                db.AddInParameter(cmd, "ordTotal", DbType.Decimal, aoOrdenServicio.OrdTotal)
                db.AddInParameter(cmd, "ordSaldoI", DbType.Decimal, aoOrdenServicio.OrdSaldoI)
                db.AddInParameter(cmd, "ordSaldof", DbType.Decimal, aoOrdenServicio.OrdSaldoF)
                db.ExecuteNonQuery(cmd, transaccion)
                If aoOrdenServicio.ListaOrdenServicioDet IsNot Nothing Then
                    For Each aoOrdenServicioDet As EEOrdenServicio.EEOrdenServicioDet In aoOrdenServicio.ListaOrdenServicioDet
                        If aoOrdenServicioDet.OrdDetId = 0 Then
                            cmd = db.GetStoredProcCommand("Insertar_OrdenServicioDet_pa")
                            db.AddInParameter(cmd, "OrdDetId", DbType.Int32, aoOrdenServicioDet.OrdDetId)
                            db.AddInParameter(cmd, "ordId", DbType.String, aoOrdenServicio.OrdId)
                            db.AddInParameter(cmd, "tgCatServId", DbType.String, aoOrdenServicioDet.TgCatServId)
                            db.AddInParameter(cmd, "ordDetDescripcion", DbType.String, aoOrdenServicioDet.OrdDetDescripcion)
                            db.AddInParameter(cmd, "ordDetObservacion", DbType.String, aoOrdenServicioDet.ordDetObservacion)
                            db.AddInParameter(cmd, "ordDetPrecio", DbType.Decimal, aoOrdenServicioDet.OrdDetPrecio)
                            db.AddInParameter(cmd, "ordDetIgv", DbType.Decimal, CDbl(aoOrdenServicioDet.OrdDetIgv))
                            db.AddInParameter(cmd, "ordDetRta4ta", DbType.Decimal, CDbl(aoOrdenServicioDet.OrdDetRta4ta))
                            db.AddInParameter(cmd, "tgTipoAjusteId", DbType.String, aoOrdenServicioDet.tgTipoAjusteId)
                            db.AddInParameter(cmd, "ordDetAjuste", DbType.Decimal, CDbl(aoOrdenServicioDet.OrdDetAjuste))
                            db.ExecuteNonQuery(cmd, transaccion)
                        End If
                    Next
                End If
                If aoOrdenServicio.ListaOrdenServicioGrupoPartidas IsNot Nothing Then
                    For Each aoOrdenServicioGrupoPartidas As EEOrdenServicio.EEOrdenServicioGrupoPartidas In aoOrdenServicio.ListaOrdenServicioGrupoPartidas
                        cmd = db.GetStoredProcCommand("Insertar_OrdenServicioGrupoPartidas_pa")
                        db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenServicio.OrdId)
                        db.AddInParameter(cmd, "cerGrupoParId", DbType.Int32, aoOrdenServicioGrupoPartidas.cerGrupoParId)
                        db.AddInParameter(cmd, "cerGrupoParValImporte", DbType.Decimal, aoOrdenServicioGrupoPartidas.cerGrupoParValImporte)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoOrdenServicio.ListaOrdenServicioAreaRef IsNot Nothing Then
                    For Each aoOrdenServicioAreaRef As EEOrdenServicio.EEOrdenServicioAreaRef In aoOrdenServicio.ListaOrdenServicioAreaRef
                        cmd = db.GetStoredProcCommand("Insertar_OrdenServicioAreasRef_pa")
                        db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenServicio.OrdId)
                        db.AddInParameter(cmd, "tgAreaId", DbType.String, aoOrdenServicioAreaRef.tgAreaId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoOrdenServicio.ListaOrdenServicioDocRef IsNot Nothing Then
                    For Each aoOrdenServicioRef As EEOrdenServicio.EEOrdenServicioDocRef In aoOrdenServicio.ListaOrdenServicioDocRef
                        cmd = db.GetStoredProcCommand("Insertar_OrdenServicioDocRef_pa")
                        db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenServicio.OrdId)
                        db.AddInParameter(cmd, "año", DbType.String, aoOrdenServicioRef.año)
                        db.AddInParameter(cmd, "documento", DbType.String, aoOrdenServicioRef.documento)
                        db.AddInParameter(cmd, "area", DbType.String, aoOrdenServicioRef.area)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                cmd = db.GetStoredProcCommand("Actualizar_CertificacionLOG_cerValQuedanXcerId_pa")
                db.AddInParameter(cmd, "cerid", DbType.String, aoOrdenServicio.CerId)
                db.ExecuteNonQuery(cmd, transaccion)
                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Guardar Orden Servicio => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function

    Public Shared Function actualizar(ByVal aoOrdenServicio As EEOrdenServicio) As Boolean

        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_OrdenServicio_pa")

                    db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenServicio.OrdId)
                    db.AddInParameter(cmd, "ordnro", DbType.String, aoOrdenServicio.OrdNro)
                    db.AddInParameter(cmd, "ordfechadoc", DbType.Date, aoOrdenServicio.OrdFechaDoc)
                    db.AddInParameter(cmd, "tgestadoid", DbType.String, aoOrdenServicio.TgEstadoId)
                    db.AddInParameter(cmd, "tgcomppagoid", DbType.String, aoOrdenServicio.TgCompPagoId)
                    db.AddInParameter(cmd, "ordnrocomppago", DbType.String, aoOrdenServicio.OrdNroCompPago)
                    db.AddInParameter(cmd, "perprovid", DbType.String, aoOrdenServicio.PerProvId)
                    db.AddInParameter(cmd, "ordrefdoc", DbType.String, aoOrdenServicio.OrdRefDoc)
                    db.AddInParameter(cmd, "tgcuentadebeid", DbType.String, aoOrdenServicio.TgCuentaDebeId)
                    db.AddInParameter(cmd, "tgcuentadebe", DbType.Decimal, aoOrdenServicio.TgCuentaDebe)
                    db.AddInParameter(cmd, "tgcuentahaberid", DbType.String, aoOrdenServicio.TgCuentaHaberId)
                    db.AddInParameter(cmd, "tgcuentahaber", DbType.Decimal, aoOrdenServicio.TgCuentaHaber)
                    db.AddInParameter(cmd, "CerCompId", DbType.String, aoOrdenServicio.CerCompId)
                    db.AddInParameter(cmd, "cerid", DbType.String, aoOrdenServicio.CerId)
                    db.AddInParameter(cmd, "ordimporte", DbType.Decimal, aoOrdenServicio.OrdImporte)
                    db.AddInParameter(cmd, "ordImporteIGV", DbType.Decimal, aoOrdenServicio.OrdImporteIGV)
                    db.AddInParameter(cmd, "ordParIgv", DbType.Decimal, aoOrdenServicio.OrdParIGV)
                    db.AddInParameter(cmd, "ordRta4taTotal", DbType.Decimal, aoOrdenServicio.ordRta4taTotal)
                    db.AddInParameter(cmd, "ordAjusteTotal", DbType.Decimal, aoOrdenServicio.OrdAjusteTotal)
                    db.AddInParameter(cmd, "ordSubTotal", DbType.Decimal, aoOrdenServicio.OrdSubTotal)
                    db.AddInParameter(cmd, "ordTotal", DbType.Decimal, aoOrdenServicio.OrdTotal)
                    'db.AddInParameter(cmd, "cerValUtilizado", DbType.Decimal, aoOrdenServicio.CerValUtilizado)
                    'db.AddInParameter(cmd, "cerValdevuelto", DbType.Decimal, aoOrdenServicio.CerValdevuelto)
                    'db.AddInParameter(cmd, "cerCompValUtilizado", DbType.Decimal, aoOrdenServicio.CerCompValUtilizado)
                    'db.AddInParameter(cmd, "cerCompValdevuelto", DbType.Decimal, aoOrdenServicio.CerCompValdevuelto)
                    db.ExecuteNonQuery(cmd, transaccion)

                    If aoOrdenServicio.Lista_OrdenServicioDetElimnados IsNot Nothing Then
                        For Each loDetalle As String In aoOrdenServicio.Lista_OrdenServicioDetElimnados
                            cmd = db.GetStoredProcCommand("Eliminar_OrdenServicioDet_XOrdDetId_pa")
                            db.AddInParameter(cmd, "ordDetId", DbType.String, loDetalle)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If

                    If aoOrdenServicio.ListaOrdenServicioDet IsNot Nothing Then
                        For Each aoOrdenServicioDet As EEOrdenServicio.EEOrdenServicioDet In aoOrdenServicio.ListaOrdenServicioDet
                            If aoOrdenServicioDet.OrdDetId = 0 Then
                                cmd = db.GetStoredProcCommand("Insertar_OrdenServicioDet_pa")
                            Else
                                cmd = db.GetStoredProcCommand("Actualizar_OrdenServicioDet_pa")
                            End If
                            db.AddInParameter(cmd, "OrdDetId", DbType.Int32, aoOrdenServicioDet.OrdDetId)
                            db.AddInParameter(cmd, "ordId", DbType.String, aoOrdenServicio.OrdId)
                            db.AddInParameter(cmd, "tgCatServId", DbType.String, aoOrdenServicioDet.TgCatServId)
                            db.AddInParameter(cmd, "ordDetDescripcion", DbType.String, aoOrdenServicioDet.OrdDetDescripcion)
                            db.AddInParameter(cmd, "ordDetObservacion", DbType.String, aoOrdenServicioDet.ordDetObservacion)
                            db.AddInParameter(cmd, "ordDetPrecio", DbType.Decimal, aoOrdenServicioDet.OrdDetPrecio)
                            db.AddInParameter(cmd, "ordDetIgv", DbType.Decimal, CDbl(aoOrdenServicioDet.OrdDetIgv))
                            db.AddInParameter(cmd, "ordDetRta4ta", DbType.Decimal, CDbl(aoOrdenServicioDet.OrdDetRta4ta))
                            db.AddInParameter(cmd, "tgTipoAjusteId", DbType.String, aoOrdenServicioDet.tgTipoAjusteId)
                            db.AddInParameter(cmd, "ordDetAjuste", DbType.Decimal, CDbl(aoOrdenServicioDet.OrdDetAjuste))
                            'db.AddInParameter(cmd, "OrdDetMontoCertUtl1", DbType.Decimal, CDbl(aoOrdenServicioDet.OrdDetMontoCertUtl1))
                            'db.AddInParameter(cmd, "OrdDetMontoCertUtl2", DbType.Decimal, CDbl(aoOrdenServicioDet.OrdDetMontoCertUtl2))
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next

                    End If
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar OrdenServicio => " & ex.Message, ex)
        End Try
        Return True

    End Function

End Class


