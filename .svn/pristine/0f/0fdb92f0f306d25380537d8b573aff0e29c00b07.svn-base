Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class CertificacionDAO
    Public Shared Function guardar(ByVal aoCertificacion As EECertificacion) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Certificacion_pa")

                db.AddInParameter(cmd, "cerid", DbType.String, aoCertificacion.CerId)
                db.AddInParameter(cmd, "cerNro", DbType.String, aoCertificacion.CerNro)
                db.AddInParameter(cmd, "cerFecha", DbType.Date, aoCertificacion.CerFecha)
                db.AddInParameter(cmd, "cerSolicitadoCon", DbType.String, aoCertificacion.CerSolicitadoCon)
                db.AddInParameter(cmd, "tgAreaSolicitanteId", DbType.String, aoCertificacion.TgAreaSolicitanteId)
                db.AddInParameter(cmd, "cerContExpediente", DbType.String, aoCertificacion.CerContExpediente)
                db.AddInParameter(cmd, "cerJustificacion", DbType.String, aoCertificacion.CerJustificacion)
                db.AddInParameter(cmd, "tgActProyId", DbType.String, aoCertificacion.TgActProyId)
                db.AddInParameter(cmd, "tgMetaId", DbType.String, aoCertificacion.TgMetaId)
                db.AddInParameter(cmd, "tgFFinancieraId", DbType.String, aoCertificacion.TgFFinancieraId)
                db.AddInParameter(cmd, "cerValTotal", DbType.Decimal, aoCertificacion.CerValTotal)
                db.AddInParameter(cmd, "cerObservacion", DbType.String, aoCertificacion.CerObservacion)
                db.ExecuteNonQuery(cmd, transaccion)


                If aoCertificacion.ListaCertificacionGrupoPartidas IsNot Nothing Then
                    For Each aoCertificacionGrupoPartidas As EECertificacion.EECertificacionGrupoPartida In aoCertificacion.ListaCertificacionGrupoPartidas
                        If aoCertificacionGrupoPartidas.cerGrupoParId = 0 Then
                            cmd = db.GetStoredProcCommand("Insertar_CertificacionGrupoPartidas_pa")
                            db.AddInParameter(cmd, "cerGrupoParId", DbType.Int32, aoCertificacionGrupoPartidas.cerGrupoParId)
                            db.AddInParameter(cmd, "cerid", DbType.String, aoCertificacionGrupoPartidas.cerId)
                            db.AddInParameter(cmd, "partId", DbType.String, aoCertificacionGrupoPartidas.partId)
                            db.AddInParameter(cmd, "partAnio", DbType.String, aoCertificacionGrupoPartidas.partAnio)
                            db.AddInParameter(cmd, "cerGrupoParValImporte", DbType.Decimal, CDbl(aoCertificacionGrupoPartidas.cerGrupoParValImporte))
                            db.AddInParameter(cmd, "cerGrupoParValQuedan", DbType.Decimal, CDbl(aoCertificacionGrupoPartidas.cerGrupoParValQuedan))
                            db.ExecuteNonQuery(cmd, transaccion)
                        End If
                    Next
                End If
                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Guardar Certificación => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function
End Class


