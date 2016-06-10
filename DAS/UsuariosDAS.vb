Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class UsuariosDAS

#Region "Listar Criterio"
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEUsuarios)
        Dim ListaUsuarios As List(Of EEUsuarios) = Nothing
        Dim loUsuarios As EEUsuarios = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim loUsuariosFormularios As EEUsuarios.EEUsuariosFormularios = Nothing
        Dim loMenuFormularios As EEMenuFormularios = Nothing
        Dim dr As IDataReader = Nothing
        Dim drUsuariosFormularios As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Usuarios_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaUsuarios Is Nothing Then
                    ListaUsuarios = New List(Of EEUsuarios)()
                End If

                loUsuarios = New EEUsuarios()
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()

                loUsuarios.UsuId = Convert.ToInt32(dr("UsuId").ToString())
                loUsuarios.OPersona = loPersona
                loUsuarios.UsuLogin = dr("UsuLogin").ToString()
                loUsuarios.UsuPassword = mDesencriptarPassword(dr("UsuPassword").ToString())

                cmd = db.GetStoredProcCommand("Mostrar_UsuariosFormularios_XUsuId_pa")
                db.AddInParameter(cmd, "usuid", DbType.Int32, loUsuarios.UsuId)
                drUsuariosFormularios = db.ExecuteReader(cmd)
                While drUsuariosFormularios.Read()
                    If loUsuarios.ListaUsuariosFormularios Is Nothing Then
                        loUsuarios.ListaUsuariosFormularios = New List(Of EEUsuarios.EEUsuariosFormularios)
                    End If

                    loUsuariosFormularios = New EEUsuarios.EEUsuariosFormularios()

                    loMenuFormularios = New EEMenuFormularios()
                    loMenuFormularios.MfrId = Convert.ToInt16(drUsuariosFormularios("MfrId").ToString())
                    loUsuariosFormularios.OMenuFormularios = loMenuFormularios
                    loUsuariosFormularios.UsfPermisos = drUsuariosFormularios("usfPermisos").ToString()

                    loUsuarios.ListaUsuariosFormularios.Add(loUsuariosFormularios)
                End While
                drUsuariosFormularios.Close()

                ListaUsuarios.Add(loUsuarios)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Usuarios Criterio => " & ex.Message, ex)
        End Try
        Return ListaUsuarios
    End Function
#End Region

#Region "Listar Actualizar Permisos XUsuId"
    Public Shared Function listarActualizarPermisos_XUsuId(ByVal aiUsuId As Int32) As EEUsuarios
        Dim loUsuarios As EEUsuarios = Nothing
        Dim loUsuariosFormularios As EEUsuarios.EEUsuariosFormularios = Nothing
        Dim loMenuFormularios As EEMenuFormularios = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Actualizar_Permisos_XUsuId_pa")
            db.AddInParameter(cmd, "usuid", DbType.Int32, aiUsuId)

            dr = db.ExecuteReader(cmd)
            loUsuarios = New EEUsuarios()
            While dr.Read()
                If loUsuarios.ListaUsuariosFormularios Is Nothing Then
                    loUsuarios.ListaUsuariosFormularios = New List(Of EEUsuarios.EEUsuariosFormularios)
                End If

                loUsuariosFormularios = New EEUsuarios.EEUsuariosFormularios()

                loMenuFormularios = New EEMenuFormularios()
                loMenuFormularios.MfrNombre = dr("MfrNombre").ToString()
                loUsuariosFormularios.OMenuFormularios = loMenuFormularios
                loUsuariosFormularios.UsfPermisos = dr("UsfPermisos").ToString()

                loUsuarios.ListaUsuariosFormularios.Add(loUsuariosFormularios)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Actualizar Permisos XUsuId => " & ex.Message, ex)
        End Try
        Return loUsuarios
    End Function
#End Region

#Region "Login Iniciar Sesion"
    Public Shared Function login(ByVal asUsuario As String, ByVal asPassword As String) As EEUsuarios
        Dim loUsuarios As EEUsuarios = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim loUsuariosFormularios As EEUsuarios.EEUsuariosFormularios = Nothing
        Dim loMenuFormularios As EEMenuFormularios = Nothing
        Dim dr As IDataReader = Nothing
        Dim drUsuariosFormularios As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Iniciar_Sesion_pa")
            db.AddInParameter(cmd, "usulogin", DbType.String, asUsuario)
            db.AddInParameter(cmd, "usupassword", DbType.String, asPassword)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                loUsuarios = New EEUsuarios()
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerDireccion = dr("PerDireccion").ToString()
                loPersona.PerNDoc = dr("perNDoc").ToString()
                loPersona.TgTipoDoc = dr("TgDocumento").ToString()

                loUsuarios.UsuId = Convert.ToInt32(dr("UsuId").ToString())
                loUsuarios.OPersona = loPersona
                loUsuarios.UsuLogin = dr("UsuLogin").ToString()
                loUsuarios.UsuPassword = dr("UsuPassword").ToString()
                EEComun.FechaServidor = Convert.ToDateTime(dr("fechaServidor").ToString())
                EEComun.UsuIdOnline = loUsuarios.UsuId

                cmd = db.GetStoredProcCommand("Mostrar_UsuariosFormularios_XUsuId_pa")
                db.AddInParameter(cmd, "usuid", DbType.Int32, loUsuarios.UsuId)
                drUsuariosFormularios = db.ExecuteReader(cmd)
                While drUsuariosFormularios.Read()
                    If loUsuarios.ListaUsuariosFormularios Is Nothing Then
                        loUsuarios.ListaUsuariosFormularios = New List(Of EEUsuarios.EEUsuariosFormularios)
                    End If

                    loUsuariosFormularios = New EEUsuarios.EEUsuariosFormularios()

                    loMenuFormularios = New EEMenuFormularios()
                    loMenuFormularios.MfrId = Convert.ToInt16(drUsuariosFormularios("MfrId").ToString())
                    loMenuFormularios.MfrNombre = drUsuariosFormularios("MfrNombre").ToString()
                    loUsuariosFormularios.OMenuFormularios = loMenuFormularios
                    loUsuariosFormularios.UsfPermisos = drUsuariosFormularios("UsfPermisos").ToString()

                    loUsuarios.ListaUsuariosFormularios.Add(loUsuariosFormularios)
                End While
                drUsuariosFormularios.Close()

            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Iniciar Sesion => " & ex.Message, ex)
        End Try
        Return loUsuarios
    End Function
#End Region

#Region "Login"
    Public Shared Function login() As Date
        Dim loUsuarios As EEUsuarios = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim loencriptar As New CCryptorEngine
        Dim aousuario As New EEUsuarios
        aousuario.UsuLogin = "administrador"
        aousuario.UsuPassword = loencriptar.Encriptar("123456")
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Iniciar_Sesion_pa")
            db.AddInParameter(cmd, "usulogin", DbType.String, aousuario.UsuLogin)
            db.AddInParameter(cmd, "usupassword", DbType.String, aousuario.UsuPassword)

            dr = db.ExecuteReader(cmd)
            While dr.Read()

                loUsuarios = New EEUsuarios()
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerNDoc = dr("perNDoc").ToString()

                loUsuarios.UsuId = Convert.ToInt32(dr("UsuId").ToString())
                loUsuarios.OPersona = loPersona
                loUsuarios.UsuLogin = dr("UsuLogin").ToString()
                loUsuarios.UsuPassword = dr("UsuPassword").ToString()
                EEComun.FechaServidor = Convert.ToDateTime(dr("fechaServidor").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Iniciar Sesion => " & ex.Message, ex)
        End Try
        Return EEComun.FechaServidor
    End Function
#End Region

#Region "Verificar Antiguo Password"
    Public Shared Function verificarAntiguoPassword(ByVal aiIdUsuario As Int32, ByVal asAntiguoPassword As String) As Boolean
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Verificar_Usuario_AntiguoPassword_pa")
            db.AddInParameter(cmd, "usuid", DbType.Int32, aiIdUsuario)
            db.AddInParameter(cmd, "usupassword", DbType.String, asAntiguoPassword)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                Return True
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Verificar Antiguo Password => " & ex.Message, ex)
        End Try
        Return False
    End Function
#End Region

#Region "Desencriptar Password para mostrarlo en los listados"
    Private Shared loEncriptador As CCryptorEngine
    Public Shared Function mDesencriptarPassword(ByVal asPassword As String) As String
        If loEncriptador Is Nothing Then
            loEncriptador = New CCryptorEngine()
        End If
        Return loEncriptador.Desencriptar(asPassword)
    End Function
#End Region

End Class
