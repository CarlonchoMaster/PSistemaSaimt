Imports DevExpress.LookAndFeel
Imports SaimtControles
Imports Entidades
Imports ReglasNegocio
Imports System.Threading
Imports System.Net.NetworkInformation
Imports System.IO
Imports System.Text

Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        Application.EnableVisualStyles()
        EEComun.IP = mObtenerLocalIP()
        EEComun.Mac = mObtenerMAC()
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Dim loUsuarios As EEUsuarios = Nothing
        Dim lsMenusName As StringBuilder = Nothing
        Dim lsPermisos As StringBuilder = Nothing
        'Dim lsRutaSqlSeguridad As String = "\\192.168.1.251\SQLSeguridad\"
        Try
            loUsuarios = MantenimientosBL.Instancia.usuariosLogin(txtUsuario.Text, txtPassword.Text)
            If loUsuarios IsNot Nothing Then
                Dim fPrincipal As frmPrincipal = New frmPrincipal()

                fPrincipal.UsuarioBienvenido = "Bienvenido : " & loUsuarios.OPersona.PerNombres & " " & loUsuarios.OPersona.PerApePaterno & " " & loUsuarios.OPersona.PerApeMaterno & "   "
                fPrincipal.Usuario = loUsuarios.OPersona.PerNombres & " " & loUsuarios.OPersona.PerApeMaterno & " " & loUsuarios.OPersona.PerApePaterno & "   "
                fPrincipal.UsuarioNroDocumento = loUsuarios.OPersona.PerNDoc & "   "
                fPrincipal.TipoDocumento = loUsuarios.OPersona.TgTipoDoc
                fPrincipal.UsuarioLogin = txtUsuario.Text & "   "
                fPrincipal.Fecha = "Fecha : " & EEComun.FechaServidor.Value.ToLongDateString.ToUpper() & " " & EEComun.FechaServidor.Value.ToLongTimeString.ToUpper() & "   "
                fPrincipal.UsuarioIP = EEComun.IP
                fPrincipal.UsuarioMAC = EEComun.Mac
                EEComun.PerNombreCompleto = fPrincipal.Usuario
                EEComun._PerId = loUsuarios.OPersona.PerId
                EEComun.Usuario = txtUsuario.Text
                EEComun.PerDireccion = loUsuarios.OPersona.PerDireccion

                Dim loCargo As EECargoPersonal = MantenimientosBL.Instancia.CargoMostrarXPerId_pa(EEComun._PerId)
                If loCargo IsNot Nothing Then
                    EEComun.PerCargoID = loCargo.CarPerId
                    EEComun.PerCargo = loCargo.Cargo
                    EEComun.PerCargoSigla = loCargo.CargoSigla
                End If
                lsMenusName = New StringBuilder()
                lsPermisos = New StringBuilder()
                For Each fUsuariosFormularios As EEUsuarios.EEUsuariosFormularios In loUsuarios.ListaUsuariosFormularios
                    lsMenusName.Append(fUsuariosFormularios.OMenuFormularios.MfrNombre)
                    lsMenusName.Append(",")
                    lsPermisos.Append(fUsuariosFormularios.UsfPermisos)
                    lsPermisos.Append(";")
                Next
                fPrincipal.MenusName = lsMenusName.ToString().Substring(0, lsMenusName.Length - 1)
                fPrincipal.Permisos = lsPermisos.ToString.Substring(0, lsPermisos.Length - 1)
                txtUsuario.Text = String.Empty
                txtPassword.Text = String.Empty
                DialogResult = DialogResult.OK
           
                fPrincipal.Show()
                Hide()
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Usuario o Password Incorrectos")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

#Region "Metodos Obtener MAC y IP del PC"
    ''' <summary>
    ''' Obtener la MAC de la PC
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function mObtenerMAC() As String
        Try
            Dim computerProperties As IPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties()
            Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface
            For Each adapter In nics
                Return adapter.GetPhysicalAddress().ToString()
            Next adapter
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError("Obtener MAC => " & ex.Message)
        End Try
        Return ""
    End Function

    ''' <summary>
    ''' Obtener la IP de la PC
    ''' </summary>
    Public Function mObtenerLocalIP() As String
        Dim _IP As String = Nothing

        Try
            ' Resolves a host name or IP address to an IPHostEntry instance.
            ' IPHostEntry - Provides a container class for Internet host address information. 
            Dim _IPHostEntry As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())

            ' IPAddress class contains the address of a computer on an IP network. 
            For Each _IPAddress As System.Net.IPAddress In _IPHostEntry.AddressList
                ' InterNetwork indicates that an IP version 4 address is expected 
                ' when a Socket connects to an endpoint
                If _IPAddress.AddressFamily.ToString() = "InterNetwork" Then
                    _IP = _IPAddress.ToString()
                    Exit For
                End If
            Next _IPAddress
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError("Obtener IP => " & ex.Message)
        End Try
        Return _IP
    End Function
#End Region

    Private Sub frmLogin_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class