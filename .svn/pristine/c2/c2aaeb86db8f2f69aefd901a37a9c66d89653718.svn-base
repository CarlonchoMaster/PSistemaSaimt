Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ComprobantePagoDAO
    Public Shared Function guardar(ByVal aoComprobantePago As EEComprobantePago) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_ComprobantePago_pa")

                db.AddInParameter(cmd, "comPagId", DbType.String, aoComprobantePago.ComPagId)
                db.AddInParameter(cmd, "comPagNro", DbType.String, aoComprobantePago.ComPagNro)
                ''db.AddInParameter(cmd, "comPagNroOrden", DbType.String, aoComprobantePago.ComPagNroOrden)
                ''db.AddInParameter(cmd, "comPagFecha", DbType.Date, aoComprobantePago.ComPagFecha)
                ''db.AddInParameter(cmd, "tgEstadoId", DbType.String, aoComprobantePago.TgEstadoId)
                ''db.AddInParameter(cmd, "perProvId", DbType.String, aoComprobantePago.PerProvId)
                ''db.AddInParameter(cmd, "perRespId", DbType.String, aoComprobantePago.PerRespId)
                db.AddInParameter(cmd, "tgBancoId", DbType.String, aoComprobantePago.TgBancoId)
                ''db.AddInParameter(cmd, "tgTipoComId", DbType.String, aoComprobantePago.TgTipoComId)
                ''db.AddInParameter(cmd, "comPagCtaCorriente", DbType.String, aoComprobantePago.ComPagCtaCorriente)
                ''db.AddInParameter(cmd, "comPagConcepto", DbType.String, aoComprobantePago.ComPagConcepto)
                ''db.AddInParameter(cmd, "comPagImpTotal", DbType.Decimal, aoComprobantePago.ComPagImpTotal)
                ''db.AddInParameter(cmd, "comPagImpDeduccion", DbType.Decimal, aoComprobantePago.ComPagImpDeduccion)
                ''db.AddInParameter(cmd, "comPagImpPagar", DbType.Decimal, aoComprobantePago.ComPagImpPagar)
                'Codificacion Programatica
                ''db.AddInParameter(cmd, "comPagSector", DbType.String, aoComprobantePago.ComPagSector)
                ''db.AddInParameter(cmd, "comPagPliego", DbType.String, aoComprobantePago.ComPagPliego)
                ''db.AddInParameter(cmd, "comPagFuncion", DbType.String, aoComprobantePago.ComPagFuncion)
                ''db.AddInParameter(cmd, "comPagPrograma", DbType.String, aoComprobantePago.ComPagPrograma)
                ''db.AddInParameter(cmd, "comPagSubPrograma", DbType.String, aoComprobantePago.ComPagSubPrograma)
                'db.AddInParameter(cmd, "tgActProyId", DbType.String, aoComprobantePago.TgActProyId)
                'db.AddInParameter(cmd, "tgMetaId", DbType.String, aoComprobantePago.TgMetaId)
                'db.AddInParameter(cmd, "tgFFinancieraId", DbType.String, aoComprobantePago.TgFFinancieraId)
                'Contabilidad Presupuestal
                ''db.AddInParameter(cmd, "tgCuentaDebeId", DbType.String, aoComprobantePago.TgCuentaDebeId)
                ''db.AddInParameter(cmd, "tgCuentaDebe", DbType.Decimal, aoComprobantePago.TgCuentaDebe)
                ''db.AddInParameter(cmd, "tgCuentaHaberId", DbType.String, aoComprobantePago.TgCuentaHaberId)
                ''db.AddInParameter(cmd, "tgCuentaHaber", DbType.Decimal, aoComprobantePago.TgCuentaHaber)
                'Contabilidad
                ''db.AddInParameter(cmd, "tgCuentaDebe2Id", DbType.String, aoComprobantePago.TgCuentaDebe2Id)
                ''db.AddInParameter(cmd, "tgCuentaDebe2", DbType.Decimal, aoComprobantePago.TgCuentaDebe2)
                ''db.AddInParameter(cmd, "tgCuentaHaber2Id", DbType.String, aoComprobantePago.TgCuentaHaber2Id)
                ''db.AddInParameter(cmd, "tgCuentaHaber2", DbType.Decimal, aoComprobantePago.TgCuentaHaber2)
                db.ExecuteNonQuery(cmd, transaccion)
                ''If aoComprobantePago.ListaComprobantePagoDet IsNot Nothing Then
                ''    For Each aoComprobantePagoDet As EEComprobantePago.EEComprobantePagoDet In aoComprobantePago.ListaComprobantePagoDet
                ''        If aoComprobantePagoDet.ComDetId = 0 Then
                ''            cmd = db.GetStoredProcCommand("Insertar_ComprobantePagoDet_pa")
                ''        Else
                ''            cmd = db.GetStoredProcCommand("Actualizar_ComprobantePagoDet_pa")
                ''        End If
                ''        db.AddInParameter(cmd, "comDetId", DbType.Int32, aoComprobantePagoDet.ComDetId)
                ''        'db.AddInParameter(cmd, "partId", DbType.String, aoComprobantePagoDet.PartId)
                ''        'db.AddInParameter(cmd, "comDetImpParcial", DbType.String, aoComprobantePagoDet.ComDetImpParcial)
                ''        'db.AddInParameter(cmd, "comDetImpTotal", DbType.String, aoComprobantePagoDet.ComDetImpTotal)
                ''        db.AddInParameter(cmd, "comDetImpDeduccion", DbType.Int32, aoComprobantePagoDet.ComDetImpDeduccion)
                ''        db.ExecuteNonQuery(cmd, transaccion)
                ''    Next
                ''End If

                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Guardar Articulo => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function

    Public Shared Function actualizar(ByVal aoComprobantePago As EEComprobantePago) As Boolean

        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_OrdenCompra_pa")

                    db.AddInParameter(cmd, "comPagId", DbType.String, aoComprobantePago.ComPagId)
                    db.AddInParameter(cmd, "comPagNro", DbType.String, aoComprobantePago.ComPagNro)
                    db.AddInParameter(cmd, "comPagNroOrden", DbType.String, aoComprobantePago.ComPagNroOrden)
                    db.AddInParameter(cmd, "comPagFecha", DbType.Date, aoComprobantePago.ComPagFecha)
                    db.AddInParameter(cmd, "tgEstadoId", DbType.String, aoComprobantePago.TgEstadoId)
                    db.AddInParameter(cmd, "perProvId", DbType.String, aoComprobantePago.PerProvId)
                    db.AddInParameter(cmd, "perRespId", DbType.String, aoComprobantePago.PerRespId)
                    db.AddInParameter(cmd, "tgBancoId", DbType.String, aoComprobantePago.TgBancoId)
                    db.AddInParameter(cmd, "tgTipoComId", DbType.String, aoComprobantePago.TgTipoComId)
                    db.AddInParameter(cmd, "comPagCtaCorriente", DbType.String, aoComprobantePago.ComPagCtaCorriente)
                    db.AddInParameter(cmd, "comPagConcepto", DbType.String, aoComprobantePago.ComPagConcepto)
                    db.AddInParameter(cmd, "comPagImpTotal", DbType.Decimal, aoComprobantePago.ComPagImpTotal)
                    db.AddInParameter(cmd, "comPagImpDeduccion", DbType.Decimal, aoComprobantePago.ComPagImpDeduccion)
                    db.AddInParameter(cmd, "comPagImpPagar", DbType.Decimal, aoComprobantePago.ComPagImpPagar)
                    'Codificacion Programatica
                    db.AddInParameter(cmd, "comPagSector", DbType.String, aoComprobantePago.ComPagSector)
                    db.AddInParameter(cmd, "comPagPliego", DbType.String, aoComprobantePago.ComPagPliego)
                    db.AddInParameter(cmd, "comPagFuncion", DbType.String, aoComprobantePago.ComPagFuncion)
                    db.AddInParameter(cmd, "comPagPrograma", DbType.String, aoComprobantePago.ComPagPrograma)
                    db.AddInParameter(cmd, "comPagSubPrograma", DbType.String, aoComprobantePago.ComPagSubPrograma)
                    db.AddInParameter(cmd, "tgActProyId", DbType.String, aoComprobantePago.TgActProyId)
                    db.AddInParameter(cmd, "tgMetaId", DbType.String, aoComprobantePago.TgMetaId)
                    db.AddInParameter(cmd, "tgFFinancieraId", DbType.String, aoComprobantePago.TgFFinancieraId)
                    'Contabilidad Presupuestal
                    db.AddInParameter(cmd, "tgCuentaDebeId", DbType.String, aoComprobantePago.TgCuentaDebeId)
                    db.AddInParameter(cmd, "tgCuentaDebe", DbType.Decimal, aoComprobantePago.TgCuentaDebe)
                    db.AddInParameter(cmd, "tgCuentaHaberId", DbType.String, aoComprobantePago.TgCuentaHaberId)
                    db.AddInParameter(cmd, "tgCuentaHaber", DbType.Decimal, aoComprobantePago.TgCuentaHaber)
                    'Contabilidad
                    db.AddInParameter(cmd, "tgCuentaDebe2Id", DbType.String, aoComprobantePago.TgCuentaDebe2Id)
                    db.AddInParameter(cmd, "tgCuentaDebe2", DbType.Decimal, aoComprobantePago.TgCuentaDebe2)
                    db.AddInParameter(cmd, "tgCuentaHaber2Id", DbType.String, aoComprobantePago.TgCuentaHaber2Id)
                    db.AddInParameter(cmd, "tgCuentaHaber2", DbType.Decimal, aoComprobantePago.TgCuentaHaber2)
                    db.ExecuteNonQuery(cmd, transaccion)

                    If aoComprobantePago.Lista_ComprobantePagoDetElimnados IsNot Nothing Then
                        For Each loDetalle As String In aoComprobantePago.Lista_ComprobantePagoDetElimnados
                            cmd = db.GetStoredProcCommand("Eliminar_ComprobantePagoDet_XComDetId_pa")
                            db.AddInParameter(cmd, "comDetId", DbType.String, loDetalle)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If


                    If aoComprobantePago.ListaComprobantePagoDet IsNot Nothing Then
                        For Each aoComprobantePagoDet As EEComprobantePago.EEComprobantePagoDet In aoComprobantePago.ListaComprobantePagoDet
                            If aoComprobantePagoDet.ComDetId = 0 Then
                                cmd = db.GetStoredProcCommand("Insertar_ComprobantePagoDet_pa")
                            Else
                                cmd = db.GetStoredProcCommand("Actualizar_ComprobantePagoDet_pa")
                            End If
                            db.AddInParameter(cmd, "comDetId", DbType.Int32, aoComprobantePagoDet.ComDetId)
                            db.AddInParameter(cmd, "partId", DbType.String, aoComprobantePagoDet.PartId)
                            db.AddInParameter(cmd, "comDetImpParcial", DbType.String, aoComprobantePagoDet.ComDetImpParcial)
                            db.AddInParameter(cmd, "comDetImpTotal", DbType.String, aoComprobantePagoDet.ComDetImpTotal)
                            db.AddInParameter(cmd, "comDetImpDeduccion", DbType.Int32, aoComprobantePagoDet.ComDetImpDeduccion)
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
            Throw New Exception("Actualizar OrdenCompra => " & ex.Message, ex)
        End Try
        Return True

    End Function

End Class


