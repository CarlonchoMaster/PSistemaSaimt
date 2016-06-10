Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class TablaGeneralDAO	

#Region "Actualizar"
    Public Shared Function actualizar(ByVal aoTablaGeneral As EETablaGeneral) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = Nothing

                    ''Tabla General
                    If aoTablaGeneral.ListaTablaGeneralTemporalEliminados IsNot Nothing Then
                        For Each fTgId As String In aoTablaGeneral.ListaTablaGeneralTemporalEliminados
                            cmd = db.GetStoredProcCommand("EliminarU_TablaGeneral_pa")
                            db.AddInParameter(cmd, "tgId", DbType.Int32, fTgId)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If

                    If aoTablaGeneral.ListaTablaGeneralTemporalNuevos IsNot Nothing Then
                        For Each fTablaGeneral As EETablaGeneral In aoTablaGeneral.ListaTablaGeneralTemporalNuevos
                            cmd = db.GetStoredProcCommand("InsertarU_TablaGeneral_pa")
                            db.AddInParameter(cmd, "tgdescripcion", DbType.String, fTablaGeneral.TgDescripcion)
                            db.AddInParameter(cmd, "clsid", DbType.Int32, fTablaGeneral.OClase.ClsId)
                            If fTablaGeneral.TgAbrev IsNot Nothing Then
                                db.AddInParameter(cmd, "tgabrev", DbType.String, fTablaGeneral.TgAbrev)
                            End If
                            db.AddInParameter(cmd, "tgcodigo", DbType.String, fTablaGeneral.TgCodigo)
                            db.AddInParameter(cmd, "tgextra", DbType.String, fTablaGeneral.TgExtra)
                            db.AddInParameter(cmd, "tgnombre", DbType.String, fTablaGeneral.TgNombre)
                            db.AddInParameter(cmd, "tgactivo", DbType.Boolean, fTablaGeneral.TgActivo)
                            If fTablaGeneral.OClaseExtra IsNot Nothing Then
                                db.AddInParameter(cmd, "clsextraid", DbType.Int32, fTablaGeneral.OClaseExtra.ClsId)
                            End If
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
            Throw New Exception("Actualizar TablaGeneral => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

    Public Shared Function insertarXClsId_TgCodigoAutoGenerado(ByVal aoTablaGeneral As EETablaGeneral) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_TablaGeneral_XClsId_CodigoAutoIncrementado_pa")

            db.AddInParameter(cmd, "tgid", DbType.Int32, aoTablaGeneral.TgId)
            db.AddInParameter(cmd, "tgdescripcion", DbType.String, aoTablaGeneral.TgDescripcion)
            db.AddInParameter(cmd, "clsid", DbType.Int32, aoTablaGeneral.OClase.ClsId)
            db.AddInParameter(cmd, "tgabrev", DbType.String, aoTablaGeneral.TgAbrev)
            db.AddInParameter(cmd, "tgextra", DbType.String, aoTablaGeneral.TgExtra)
            db.AddInParameter(cmd, "tgnombre", DbType.String, aoTablaGeneral.TgNombre)
            db.AddInParameter(cmd, "tgactivo", DbType.Boolean, aoTablaGeneral.TgActivo)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Inserta TablaGeneral => " & ex.Message, ex)
        End Try
        Return True
    End Function


    Public Shared Function insertar(ByVal aoTablaGeneral As EETablaGeneral) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_TablaGeneral_pa")

            db.AddInParameter(cmd, "tgdescripcion", DbType.String, aoTablaGeneral.TgDescripcion)
            db.AddInParameter(cmd, "clsid", DbType.Int32, aoTablaGeneral.OClase.ClsId)
            db.AddInParameter(cmd, "tgabrev", DbType.String, aoTablaGeneral.TgAbrev)
            db.AddInParameter(cmd, "tgcodigo", DbType.String, aoTablaGeneral.TgCodigo)
            db.AddInParameter(cmd, "tgextra", DbType.String, aoTablaGeneral.TgExtra)
            db.AddInParameter(cmd, "tgnombre", DbType.String, aoTablaGeneral.TgNombre)
            db.AddInParameter(cmd, "tgactivo", DbType.Boolean, aoTablaGeneral.TgActivo)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Inserta TablaGeneral => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function Update(ByVal aoTablaGeneral As EETablaGeneral) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_TablaGeneral_pa")

            db.AddInParameter(cmd, "tgdescripcion", DbType.String, aoTablaGeneral.TgDescripcion)
            db.AddInParameter(cmd, "clsid", DbType.Int32, aoTablaGeneral.OClase.ClsId)
            db.AddInParameter(cmd, "tgabrev", DbType.String, aoTablaGeneral.TgAbrev)
            db.AddInParameter(cmd, "tgcodigo", DbType.String, aoTablaGeneral.TgCodigo)
            db.AddInParameter(cmd, "tgextra", DbType.String, aoTablaGeneral.TgExtra)
            db.AddInParameter(cmd, "tgnombre", DbType.String, aoTablaGeneral.TgNombre)
            db.AddInParameter(cmd, "tgactivo", DbType.Boolean, aoTablaGeneral.TgActivo)
            db.AddInParameter(cmd, "TgId", DbType.Int16, aoTablaGeneral.TgId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar TablaGeneral => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(ByVal aiIdTablaGeneral As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("EliminarU_TablaGeneral_pa")

            db.AddInParameter(cmd, "tgid", DbType.Int32, aiIdTablaGeneral)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar TablaGeneral => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
