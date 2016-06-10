Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class UsuariosDAO
#Region "Guardar"
    Public Shared Function guardar(ByVal aoUsuarios As EEUsuarios) As Boolean
        Dim liUsuId As Int32 = 0
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()

                    Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Usuarios_pa")

                    db.AddOutParameter(cmd, "usuid", DbType.Int32, 8)
                    db.AddInParameter(cmd, "perid", DbType.String, aoUsuarios.OPersona.PerId)
                    db.AddInParameter(cmd, "usulogin", DbType.String, aoUsuarios.UsuLogin)
                    db.AddInParameter(cmd, "usupassword", DbType.String, aoUsuarios.UsuPassword)
                    db.ExecuteNonQuery(cmd, transaccion)

                    liUsuId = Convert.ToInt32(db.GetParameterValue(cmd, "usuid").ToString())

                    For Each fUsuariosFormularios As EEUsuarios.EEUsuariosFormularios In aoUsuarios.ListaUsuariosFormularios
                        cmd = db.GetStoredProcCommand("Insertar_UsuariosFormularios_pa")

                        db.AddInParameter(cmd, "mfrId", DbType.String, fUsuariosFormularios.OMenuFormularios.MfrId)
                        db.AddInParameter(cmd, "usuId", DbType.String, liUsuId)
                        db.AddInParameter(cmd, "usfPermisos", DbType.String, fUsuariosFormularios.UsfPermisos)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar Usuarios => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Actualizar"
    Public Shared Function actualizar(ByVal aoUsuarios As EEUsuarios) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()

                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Usuarios_pa")

                    db.AddInParameter(cmd, "usuid", DbType.Int32, aoUsuarios.UsuId)
                    db.AddInParameter(cmd, "perid", DbType.String, aoUsuarios.OPersona.PerId)
                    db.AddInParameter(cmd, "usulogin", DbType.String, aoUsuarios.UsuLogin)
                    db.AddInParameter(cmd, "usupassword", DbType.String, aoUsuarios.UsuPassword)
                    db.ExecuteNonQuery(cmd, transaccion)

                    cmd = db.GetStoredProcCommand("Eliminar_UsuariosFormularios_XUsuId_pa")
                    db.AddInParameter(cmd, "usuid", DbType.String, aoUsuarios.UsuId)
                    db.ExecuteNonQuery(cmd, transaccion)

                    For Each fUsuariosFormularios As EEUsuarios.EEUsuariosFormularios In aoUsuarios.ListaUsuariosFormularios
                        cmd = db.GetStoredProcCommand("Insertar_UsuariosFormularios_pa")

                        db.AddInParameter(cmd, "mfrId", DbType.String, fUsuariosFormularios.OMenuFormularios.MfrId)
                        db.AddInParameter(cmd, "usuId", DbType.String, aoUsuarios.UsuId)
                        db.AddInParameter(cmd, "usfPermisos", DbType.String, fUsuariosFormularios.UsfPermisos)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Usuarios => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Eliminar"
    Public Shared Function eliminar(ByVal aiIdUsuarios As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Usuarios_pa")

            db.AddInParameter(cmd, "idUsuarios", DbType.Int32, aiIdUsuarios)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Usuarios => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Actualizar Password"
    Public Shared Function cambiarPassword(ByVal aiIdUsuario As Integer, ByVal asNuevoPassword As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Usuarios_Password_pa")

            db.AddInParameter(cmd, "usuid", DbType.Int32, aiIdUsuario)
            db.AddInParameter(cmd, "usupassword", DbType.String, asNuevoPassword)

            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar Usuarios Password => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

End Class
