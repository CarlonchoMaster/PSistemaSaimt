Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class PecosaDAO
    Public Shared Function guardar(ByVal aoPecosa As EEPecosa) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Pecosa_pa")
                Dim pecid As String

                db.AddInParameter(cmd, "pecid", DbType.String, aoPecosa.PecId)
                db.AddInParameter(cmd, "pecNro", DbType.String, aoPecosa.PecNro)
                db.AddInParameter(cmd, "pecCarPerId", DbType.String, aoPecosa.PecCarPerId)
                db.AddInParameter(cmd, "pecFecha", DbType.Date, aoPecosa.PecFecha)
                db.AddInParameter(cmd, "perSolicitaId", DbType.String, aoPecosa.PerSolicitaId)
                db.AddInParameter(cmd, "pecObservacion", DbType.String, aoPecosa.PecObservacion)
                db.AddInParameter(cmd, "tgcuentadebeid", DbType.String, aoPecosa.TgCuentaDebeId)
                db.AddInParameter(cmd, "tgcuentadebe", DbType.Decimal, aoPecosa.TgCuentaDebe)
                db.AddInParameter(cmd, "tgcuentahaberid", DbType.String, aoPecosa.TgCuentaHaberId)
                db.AddInParameter(cmd, "tgcuentahaber", DbType.Decimal, aoPecosa.TgCuentaHaber)
                db.AddInParameter(cmd, "tgmetaid", DbType.String, aoPecosa.TgMetaId)
                db.AddInParameter(cmd, "tgactproyid", DbType.String, aoPecosa.TgActProyId)
                db.AddInParameter(cmd, "pecAnulado", DbType.Boolean, aoPecosa.pecAnulado)
                db.ExecuteNonQuery(cmd, transaccion)

                pecid = db.GetParameterValue(cmd, "pecid").ToString()

                Dim pecdetid As Integer

                If aoPecosa.ListaPecosaDet IsNot Nothing Then
                    For Each aoPecosaDet As EEPecosa.EEPecosaDet In aoPecosa.ListaPecosaDet

                        cmd = db.GetStoredProcCommand("Insertar_PecosaDet_pa")

                        db.AddOutParameter(cmd, "pecdetid", DbType.Int32, 11)
                        db.AddInParameter(cmd, "artid", DbType.String, aoPecosaDet.ArtId)
                        db.AddInParameter(cmd, "pecDetCanTotal", DbType.Decimal, aoPecosaDet.PecDetCanTotal)
                        db.AddInParameter(cmd, "pecId", DbType.String, pecid)
                        db.AddInParameter(cmd, "pecDetImpTotal", DbType.Decimal, aoPecosaDet.PecDetImpTotal)
                        db.AddInParameter(cmd, "tgUmId", DbType.String, aoPecosaDet.TgUmId)
                        db.AddInParameter(cmd, "pecDescripcion", DbType.String, aoPecosaDet.PecDetDescripcion)
                        db.AddInParameter(cmd, "OrdId", DbType.String, aoPecosaDet.OrdId)
                        db.AddInParameter(cmd, "OrdDetid", DbType.Int32, aoPecosaDet.OrdDetId)
                        db.AddInParameter(cmd, "pecDetPrecioUnit", DbType.Decimal, aoPecosaDet.PecDetPrecio)
                        db.ExecuteNonQuery(cmd, transaccion)
                        pecdetid = db.GetParameterValue(cmd, "pecdetid").ToString()
                    Next
                End If
                If aoPecosa.Lista_PecosaDetElimnados IsNot Nothing Then
                    For Each aoPecosaDetId As String In aoPecosa.Lista_PecosaDetElimnados
                        cmd = db.GetStoredProcCommand("Eliminar_PecosaDet")
                        db.AddInParameter(cmd, "pecDetId", DbType.Int32, aoPecosaDetId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Guardar Articulo => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function
    Public Shared Function Actualizar(ByVal aoPecosa As EEPecosa) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Pecosa")
                Dim pecid As String

                db.AddInParameter(cmd, "pecid", DbType.String, aoPecosa.PecId)
                db.AddInParameter(cmd, "pecCarPerId", DbType.String, aoPecosa.PecCarPerId)
                db.AddInParameter(cmd, "pecFecha", DbType.Date, aoPecosa.PecFecha)
                db.AddInParameter(cmd, "perSolicitaId", DbType.String, aoPecosa.PerSolicitaId)
                db.AddInParameter(cmd, "pecObservacion", DbType.String, aoPecosa.PecObservacion)
                db.AddInParameter(cmd, "tgcuentadebeid", DbType.String, aoPecosa.TgCuentaDebeId)
                db.AddInParameter(cmd, "tgcuentadebe", DbType.Decimal, aoPecosa.TgCuentaDebe)
                db.AddInParameter(cmd, "tgcuentahaberid", DbType.String, aoPecosa.TgCuentaHaberId)
                db.AddInParameter(cmd, "tgcuentahaber", DbType.Decimal, aoPecosa.TgCuentaHaber)
                db.AddInParameter(cmd, "tgactproyid", DbType.String, aoPecosa.TgActProyId)
                db.AddInParameter(cmd, "tgmetaid", DbType.String, aoPecosa.TgMetaId)
                db.AddInParameter(cmd, "pecNro", DbType.String, aoPecosa.PecNro)
                db.AddInParameter(cmd, "pecAnulado", DbType.Boolean, aoPecosa.pecAnulado)
                db.ExecuteNonQuery(cmd, transaccion)

                pecid = db.GetParameterValue(cmd, "pecid").ToString()

                Dim pecdetid As Integer

                If aoPecosa.ListaPecosaDet IsNot Nothing Then
                    For Each aoPecosaDet As EEPecosa.EEPecosaDet In aoPecosa.ListaPecosaDet
                        cmd = db.GetStoredProcCommand("Insertar_PecosaDet_pa")
                        db.AddOutParameter(cmd, "pecdetid", DbType.Int32, 11)
                        db.AddInParameter(cmd, "artid", DbType.String, aoPecosaDet.ArtId)
                        db.AddInParameter(cmd, "pecDetCanTotal", DbType.Decimal, aoPecosaDet.PecDetCanTotal)
                        db.AddInParameter(cmd, "pecId", DbType.String, pecid)
                        db.AddInParameter(cmd, "pecDetImpTotal", DbType.Decimal, aoPecosaDet.PecDetImpTotal)
                        db.AddInParameter(cmd, "tgUmId", DbType.String, aoPecosaDet.TgUmId)
                        db.AddInParameter(cmd, "pecDescripcion", DbType.String, aoPecosaDet.PecDetDescripcion)
                        db.AddInParameter(cmd, "OrdId", DbType.String, aoPecosaDet.OrdId)
                        db.AddInParameter(cmd, "OrdDetid", DbType.Int32, aoPecosaDet.OrdDetId)
                        db.AddInParameter(cmd, "pecDetPrecioUnit", DbType.Decimal, aoPecosaDet.PecDetPrecio)
                        db.ExecuteNonQuery(cmd, transaccion)
                        pecdetid = db.GetParameterValue(cmd, "pecdetid").ToString()
                    Next
                End If
                If aoPecosa.Lista_PecosaDetElimnados IsNot Nothing Then
                    For Each aoPecosaDetId As String In aoPecosa.Lista_PecosaDetElimnados
                        cmd = db.GetStoredProcCommand("Eliminar_PecosaDet")
                        db.AddInParameter(cmd, "pecDetId", DbType.Int32, aoPecosaDetId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Guardar Articulo => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function
End Class


