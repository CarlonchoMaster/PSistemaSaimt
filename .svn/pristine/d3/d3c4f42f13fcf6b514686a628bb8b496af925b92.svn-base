Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class OrdenCompraDAO
    Public Shared Function guardar(ByVal aoOrdenCompra As EEOrdenCompra) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_OrdenCompra_pa")

                db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                db.AddInParameter(cmd, "ordnro", DbType.String, aoOrdenCompra.OrdNro)
                db.AddInParameter(cmd, "ordfechadoc", DbType.Date, aoOrdenCompra.OrdFechaDoc)
                db.AddInParameter(cmd, "tgestadoid", DbType.String, aoOrdenCompra.TgEstadoId)
                db.AddInParameter(cmd, "tgcomppagoid", DbType.String, aoOrdenCompra.TgCompPagoId)
                db.AddInParameter(cmd, "ordnrocomppago", DbType.String, aoOrdenCompra.OrdNroCompPago)
                db.AddInParameter(cmd, "perprovid", DbType.String, aoOrdenCompra.PerProvId)
                db.AddInParameter(cmd, "ordrefdoc", DbType.String, aoOrdenCompra.OrdRefDoc)
                db.AddInParameter(cmd, "tgcuentadebeid", DbType.String, aoOrdenCompra.TgCuentaDebeId)
                db.AddInParameter(cmd, "tgcuentadebe", DbType.Decimal, aoOrdenCompra.TgCuentaDebe)
                db.AddInParameter(cmd, "tgcuentahaberid", DbType.String, aoOrdenCompra.TgCuentaHaberId)
                db.AddInParameter(cmd, "tgcuentahaber", DbType.Decimal, aoOrdenCompra.TgCuentaHaber)
                db.AddInParameter(cmd, "cerid", DbType.String, aoOrdenCompra.CerId)
                db.AddInParameter(cmd, "ordimporte", DbType.Decimal, aoOrdenCompra.OrdImporte)
                db.AddInParameter(cmd, "ordImporteIGV", DbType.Decimal, aoOrdenCompra.OrdImporteIGV)
                db.AddInParameter(cmd, "ordParIgv", DbType.Decimal, aoOrdenCompra.OrdParIGV)
                db.AddInParameter(cmd, "ordSubTotal", DbType.Decimal, aoOrdenCompra.OrdSubTotal)
                db.AddInParameter(cmd, "ordTotal", DbType.Decimal, aoOrdenCompra.OrdTotal)
                db.AddInParameter(cmd, "ordSaldoI", DbType.Decimal, aoOrdenCompra.OrdSaldoI)
                db.AddInParameter(cmd, "ordSaldof", DbType.Decimal, aoOrdenCompra.OrdSaldoF)
                db.AddInParameter(cmd, "ordDescuento", DbType.Decimal, aoOrdenCompra.OrdDescuento)

                db.ExecuteNonQuery(cmd, transaccion)
                If aoOrdenCompra.ListaOrdenCompraDet IsNot Nothing Then
                    For Each aoOrdenCompraDet As EEOrdenCompra.EEOrdenCompraDet In aoOrdenCompra.ListaOrdenCompraDet
                        If aoOrdenCompraDet.OrdDetId = 0 Then
                            cmd = db.GetStoredProcCommand("Insertar_OrdenCompraDet_pa")
                            db.AddInParameter(cmd, "ordDetCQuedan", DbType.Int32, aoOrdenCompraDet.OrdDetCQuedan)
                        Else
                            cmd = db.GetStoredProcCommand("Actualizar_OrdenCompraDet_pa")
                        End If
                        db.AddInParameter(cmd, "orddetid", DbType.Int32, aoOrdenCompraDet.OrdDetId)
                        db.AddInParameter(cmd, "artid", DbType.String, aoOrdenCompraDet.ArtId)
                        db.AddInParameter(cmd, "ordDetEncabezado", DbType.String, aoOrdenCompraDet.OrdDetEncabezado)
                        db.AddInParameter(cmd, "ordDetDescripcion", DbType.String, aoOrdenCompraDet.OrdDetDescripcion)
                        db.AddInParameter(cmd, "tgumid", DbType.String, aoOrdenCompraDet.TgUmId)
                        db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                        db.AddInParameter(cmd, "orddetcantidad", DbType.Int32, aoOrdenCompraDet.OrdDetCantidad)
                        db.AddInParameter(cmd, "orddetprecio", DbType.Decimal, aoOrdenCompraDet.OrdDetPrecio)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoOrdenCompra.ListaOrdenCompraGrupoPartidas IsNot Nothing Then
                    For Each aoOrdenCompraGrupoPartidas As EEOrdenCompra.EEOrdenCompraGrupoPartidas In aoOrdenCompra.ListaOrdenCompraGrupoPartidas
                        cmd = db.GetStoredProcCommand("Insertar_OrdenCompraGrupoPartidas_pa")
                        db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                        db.AddInParameter(cmd, "cerGrupoParId", DbType.Int32, aoOrdenCompraGrupoPartidas.cerGrupoParId)
                        db.AddInParameter(cmd, "cerGrupoParValImporte", DbType.Decimal, aoOrdenCompraGrupoPartidas.cerGrupoParValImporte)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoOrdenCompra.ListaOrdenCompraAreaRef IsNot Nothing Then
                    For Each aoOrdenCompraAreaRef As EEOrdenCompra.EEOrdenCompraAreaRef In aoOrdenCompra.ListaOrdenCompraAreaRef
                        cmd = db.GetStoredProcCommand("Insertar_OrdenCompraAreasRef_pa")
                        db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                        db.AddInParameter(cmd, "tgAreaId", DbType.String, aoOrdenCompraAreaRef.tgAreaId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoOrdenCompra.ListaOrdenCompraDocRef IsNot Nothing Then
                    For Each aoOrdenCompradocRef As EEOrdenCompra.EEOrdenCompraDocRef In aoOrdenCompra.ListaOrdenCompraDocRef
                        cmd = db.GetStoredProcCommand("Insertar_OrdenCompraDocRef_pa")
                        db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                        db.AddInParameter(cmd, "año", DbType.String, aoOrdenCompradocRef.año)
                        db.AddInParameter(cmd, "documento", DbType.String, aoOrdenCompradocRef.documento)
                        db.AddInParameter(cmd, "area", DbType.String, aoOrdenCompradocRef.area)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                cmd = db.GetStoredProcCommand("Actualizar_CertificacionLOG_cerValQuedanXcerId_pa")
                db.AddInParameter(cmd, "cerid", DbType.String, aoOrdenCompra.CerId)
                db.ExecuteNonQuery(cmd, transaccion)
                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Guardar Articulo => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function

    Public Shared Function ActualizarOrdenCompraCertificacionLOGcerValQuedan(ByVal CerId As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()

                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_CertificacionLOG_cerValQuedanXcerId_pa")
                    db.AddInParameter(cmd, "cerid", DbType.String, CerId)
                    db.ExecuteNonQuery(cmd)
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Certificacion Grupo Partidas => " & ex.Message, ex)
        End Try
        Return True

    End Function


    Public Shared Function ActualizaOrdenCompraGrupoPartidasXOrdId_cerGrupoParId(ByVal asOrdId As String, ByVal cerGrupoParId As Integer) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()

                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualiza_OrdenCompraGrupoPartidasXOrdId_cerGrupoParId_pa")
                    db.AddInParameter(cmd, "ordid", DbType.String, asOrdId)
                    db.AddInParameter(cmd, "cerGrupoParId", DbType.Int16, cerGrupoParId)
                    db.ExecuteNonQuery(cmd)

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar OrdenCompra => " & ex.Message, ex)
        End Try
        Return True

    End Function


    Public Shared Function ActualizarOrdenCompraGrupoPartidas_cerGrupoParValQuedan() As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()

                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_CertificacionGrupoPartidas_cerGrupoParValQuedan_pa")
                    db.ExecuteNonQuery(cmd)
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Certificacion Grupo Partidas => " & ex.Message, ex)
        End Try
        Return True

    End Function


    Public Shared Function actualizar(ByVal aoOrdenCompra As EEOrdenCompra) As Boolean

        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_OrdenCompra_pa")

                    db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                    db.AddInParameter(cmd, "ordnro", DbType.String, aoOrdenCompra.OrdNro)
                    db.AddInParameter(cmd, "ordfechadoc", DbType.Date, aoOrdenCompra.OrdFechaDoc)
                    db.AddInParameter(cmd, "tgestadoid", DbType.String, aoOrdenCompra.TgEstadoId)
                    db.AddInParameter(cmd, "tgcomppagoid", DbType.String, aoOrdenCompra.TgCompPagoId)
                    db.AddInParameter(cmd, "ordnrocomppago", DbType.String, aoOrdenCompra.OrdNroCompPago)
                    db.AddInParameter(cmd, "perprovid", DbType.String, aoOrdenCompra.PerProvId)
                    db.AddInParameter(cmd, "ordrefdoc", DbType.String, aoOrdenCompra.OrdRefDoc)
                    db.AddInParameter(cmd, "tgcuentadebeid", DbType.String, aoOrdenCompra.TgCuentaDebeId)
                    db.AddInParameter(cmd, "tgcuentadebe", DbType.Decimal, aoOrdenCompra.TgCuentaDebe)
                    db.AddInParameter(cmd, "tgcuentahaberid", DbType.String, aoOrdenCompra.TgCuentaHaberId)
                    db.AddInParameter(cmd, "tgcuentahaber", DbType.Decimal, aoOrdenCompra.TgCuentaHaber)
                    db.AddInParameter(cmd, "cerid", DbType.String, aoOrdenCompra.CerId)
                    db.AddInParameter(cmd, "ordimporte", DbType.Decimal, aoOrdenCompra.OrdImporte)
                    db.AddInParameter(cmd, "ordImporteIGV", DbType.Decimal, aoOrdenCompra.OrdImporteIGV)
                    db.AddInParameter(cmd, "ordParIgv", DbType.Decimal, aoOrdenCompra.OrdParIGV)
                    db.AddInParameter(cmd, "ordSubTotal", DbType.Decimal, aoOrdenCompra.OrdSubTotal)
                    db.AddInParameter(cmd, "ordTotal", DbType.Decimal, aoOrdenCompra.OrdTotal)
                    db.AddInParameter(cmd, "OrdSaldoI", DbType.Decimal, aoOrdenCompra.OrdSaldoI)
                    db.AddInParameter(cmd, "OrdSaldoF", DbType.Decimal, aoOrdenCompra.OrdSaldoF)
                    db.AddInParameter(cmd, "ordDescuento", DbType.Decimal, aoOrdenCompra.OrdDescuento)
                    db.ExecuteNonQuery(cmd, transaccion)

                    If aoOrdenCompra.Lista_OrdenCompraDetElimnados IsNot Nothing Then
                        For Each loDetalle As String In aoOrdenCompra.Lista_OrdenCompraDetElimnados
                            cmd = db.GetStoredProcCommand("Eliminar_OrdenCompraDet_XOrdDetId_pa")
                            db.AddInParameter(cmd, "ordDetId", DbType.String, loDetalle)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If
                    If aoOrdenCompra.ListaOrdenCompraDet IsNot Nothing Then
                        For Each aoOrdenCompraDet As EEOrdenCompra.EEOrdenCompraDet In aoOrdenCompra.ListaOrdenCompraDet
                            If aoOrdenCompraDet.OrdDetId = 0 Then
                                cmd = db.GetStoredProcCommand("Insertar_OrdenCompraDet_pa")
                                db.AddInParameter(cmd, "ordDetCQuedan", DbType.Int32, aoOrdenCompraDet.OrdDetCQuedan)
                            Else
                                cmd = db.GetStoredProcCommand("Actualizar_OrdenCompraDet_pa")
                            End If
                            db.AddInParameter(cmd, "orddetid", DbType.Int32, aoOrdenCompraDet.OrdDetId)
                            db.AddInParameter(cmd, "artid", DbType.String, aoOrdenCompraDet.ArtId)
                            db.AddInParameter(cmd, "ordDetEncabezado", DbType.String, aoOrdenCompraDet.OrdDetEncabezado)
                            db.AddInParameter(cmd, "ordDetDescripcion", DbType.String, aoOrdenCompraDet.OrdDetDescripcion)
                            db.AddInParameter(cmd, "tgumid", DbType.String, aoOrdenCompraDet.TgUmId)
                            db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                            db.AddInParameter(cmd, "orddetcantidad", DbType.Int32, aoOrdenCompraDet.OrdDetCantidad)
                            db.AddInParameter(cmd, "orddetprecio", DbType.Decimal, aoOrdenCompraDet.OrdDetPrecio)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If

                    If aoOrdenCompra.ListaOrdenCompraGrupoPartidas IsNot Nothing Then
                       
                        For Each aoOrdenCompraGrupoPartidas As EEOrdenCompra.EEOrdenCompraGrupoPartidas In aoOrdenCompra.ListaOrdenCompraGrupoPartidas
                            cmd = db.GetStoredProcCommand("Insertar_OrdenCompraGrupoPartidas_pa")
                            db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                            db.AddInParameter(cmd, "cerGrupoParId", DbType.Int32, aoOrdenCompraGrupoPartidas.cerGrupoParId)
                            db.AddInParameter(cmd, "cerGrupoParValImporte", DbType.Decimal, aoOrdenCompraGrupoPartidas.cerGrupoParValImporte)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If
                  
                    If aoOrdenCompra.ListaOrdenCompraAreaRef IsNot Nothing Then
                        cmd = db.GetStoredProcCommand("Eliminar_OrdenCompraAreasRef_pa")
                        db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                        db.ExecuteNonQuery(cmd, transaccion)
                        For Each aoOrdenCompraAreaRef As EEOrdenCompra.EEOrdenCompraAreaRef In aoOrdenCompra.ListaOrdenCompraAreaRef
                            cmd = db.GetStoredProcCommand("Insertar_OrdenCompraAreasRef_pa")
                            db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                            db.AddInParameter(cmd, "tgAreaId", DbType.String, aoOrdenCompraAreaRef.tgAreaId)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If

                    If aoOrdenCompra.ListaOrdenCompraDocRef IsNot Nothing Then
                        cmd = db.GetStoredProcCommand("Eliminar_OrdenCompraDocRef_pa")
                        db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                        db.ExecuteNonQuery(cmd, transaccion)
                        For Each aoOrdenCompradocRef As EEOrdenCompra.EEOrdenCompraDocRef In aoOrdenCompra.ListaOrdenCompraDocRef
                            cmd = db.GetStoredProcCommand("Insertar_OrdenCompraDocRef_pa")
                            db.AddInParameter(cmd, "ordid", DbType.String, aoOrdenCompra.OrdId)
                            db.AddInParameter(cmd, "año", DbType.String, aoOrdenCompradocRef.año)
                            db.AddInParameter(cmd, "documento", DbType.String, aoOrdenCompradocRef.documento)
                            db.AddInParameter(cmd, "area", DbType.String, aoOrdenCompradocRef.area)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If

                    cmd = db.GetStoredProcCommand("Actualizar_CertificacionLOG_cerValQuedanXcerId_pa")
                    db.AddInParameter(cmd, "cerid", DbType.String, aoOrdenCompra.CerId)
                    db.ExecuteNonQuery(cmd, transaccion)


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


