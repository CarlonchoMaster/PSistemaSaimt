Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ServicioDAO
    Public Shared Function guardar(aoServicio As EEServicio) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try

                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Servicio_pa")

                db.AddOutParameter(cmd, "servid", DbType.String, 4)
                db.AddInParameter(cmd, "servnombre", DbType.String, aoServicio.ServNombre)
                db.AddInParameter(cmd, "servdescripcion", DbType.String, aoServicio.ServDescripcion)
                db.AddInParameter(cmd, "tgservgrupoid", DbType.String, aoServicio.TgServGrupoId)
                db.AddInParameter(cmd, "servactivo", DbType.Boolean, aoServicio.ServActivo)
                db.AddInParameter(cmd, "serveliminado", DbType.Boolean, aoServicio.ServEliminado)
                db.AddInParameter(cmd, "servcodigo", DbType.String, aoServicio.ServCodigo)
                db.ExecuteNonQuery(cmd, transaccion)

                Dim lsServIdOut As String = db.GetParameterValue(cmd, "servId").ToString()

                If aoServicio.ListaProveedorNuevos IsNot Nothing Then
                    For Each frow As EETablaGeneral In aoServicio.ListaProveedorNuevos
                        cmd = db.GetStoredProcCommand("InsertarU_TablaGeneral_pa")
                        db.AddInParameter(cmd, "tgdescripcion", DbType.String, frow.TgDescripcion)
                        db.AddInParameter(cmd, "clsid", DbType.Int32, frow.OClase.ClsId)
                        If frow.TgAbrev IsNot Nothing Then
                            db.AddInParameter(cmd, "tgabrev", DbType.String, frow.TgAbrev)
                        End If
                        db.AddInParameter(cmd, "tgcodigo", DbType.String, frow.TgCodigo)
                        db.AddInParameter(cmd, "tgextra", DbType.String, lsServIdOut)
                        db.AddInParameter(cmd, "tgnombre", DbType.String, frow.TgNombre)
                        db.AddInParameter(cmd, "tgactivo", DbType.Boolean, frow.TgActivo)
                        If frow.OClaseExtra IsNot Nothing Then
                            db.AddInParameter(cmd, "clsextraid", DbType.Int32, frow.OClaseExtra.ClsId)
                        End If
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If
                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Guardar Servicio => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function

    Public Shared Function actualizar(aoServicio As EEServicio) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        Using conexion As DbConnection = db.CreateConnection()
            Try

                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Servicio_pa")

                db.AddInParameter(cmd, "servid", DbType.String, aoServicio.ServId)
                db.AddInParameter(cmd, "servnombre", DbType.String, aoServicio.ServNombre)
                db.AddInParameter(cmd, "servdescripcion", DbType.String, aoServicio.ServDescripcion)
                db.AddInParameter(cmd, "tgservgrupoid", DbType.String, aoServicio.TgServGrupoId)
                db.AddInParameter(cmd, "servactivo", DbType.Boolean, aoServicio.ServActivo)
                db.AddInParameter(cmd, "serveliminado", DbType.Boolean, aoServicio.ServEliminado)
                db.AddInParameter(cmd, "servcodigo", DbType.String, aoServicio.ServCodigo)
                db.ExecuteNonQuery(cmd, transaccion)

                If aoServicio.ListaProveedorEliminados IsNot Nothing Then
                    For Each frow As String In aoServicio.ListaProveedorEliminados
                        cmd = db.GetStoredProcCommand("EliminarU_TablaGeneral_pa")
                        db.AddInParameter(cmd, "tgId", DbType.Int32, frow)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If

                If aoServicio.ListaProveedorNuevos IsNot Nothing Then
                    For Each frow As EETablaGeneral In aoServicio.ListaProveedorNuevos
                        cmd = db.GetStoredProcCommand("InsertarU_TablaGeneral_pa")
                        db.AddInParameter(cmd, "tgdescripcion", DbType.String, frow.TgDescripcion)
                        db.AddInParameter(cmd, "clsid", DbType.Int32, frow.OClase.ClsId)
                        If frow.TgAbrev IsNot Nothing Then
                            db.AddInParameter(cmd, "tgabrev", DbType.String, frow.TgAbrev)
                        End If
                        db.AddInParameter(cmd, "tgcodigo", DbType.String, frow.TgCodigo)
                        db.AddInParameter(cmd, "tgextra", DbType.String, frow.TgExtra)
                        db.AddInParameter(cmd, "tgnombre", DbType.String, frow.TgNombre)
                        db.AddInParameter(cmd, "tgactivo", DbType.Boolean, frow.TgActivo)
                        If frow.OClaseExtra IsNot Nothing Then
                            db.AddInParameter(cmd, "clsextraid", DbType.Int32, frow.OClaseExtra.ClsId)
                        End If
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                End If
                transaccion.Commit()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Actualizar Servicio => " & ex.Message, ex)
            End Try
        End Using
        Return True
    End Function

    Public Shared Function eliminar(aiIdServicio As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Servicio_pa")

            db.AddInParameter(cmd, "idServicio", DbType.Int32, aiIdServicio)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Servicio => " & ex.Message, ex)
        End Try
        Return True
    End Function


End Class


