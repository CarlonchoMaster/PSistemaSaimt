Imports DevExpress.XtraBars.Ribbon
Imports SaimtControles
Imports DevExpress.XtraTab
Imports DevExpress.XtraBars
Imports Entidades
Imports ReglasNegocio
Imports System.Text

Public Class frmUsuarios
    Inherits frmMantenimientos

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If lstUsuarios.SelectedItem IsNot Nothing Then
                mLimpiarCheckBoxes()
                Dim loUsuarios As EEUsuarios = DirectCast(lstUsuarios.SelectedItem, EEUsuarios)

                txtUsuario.Text = loUsuarios.UsuLogin
                txtPassword.Text = loUsuarios.UsuPassword
                txtDatosUsuarios.Text = loUsuarios.OPersona.PerNombres & " " & loUsuarios.OPersona.PerApePaterno & " " & loUsuarios.OPersona.PerApeMaterno
                txtDatosUsuarios.Tag = loUsuarios.OPersona.PerId


                Dim lsbMenusName As StringBuilder = New StringBuilder()
                Dim lsbPermisos As StringBuilder = New StringBuilder()

                For Each fUsuariosFormularios As EEUsuarios.EEUsuariosFormularios In loUsuarios.ListaUsuariosFormularios
                    lsbMenusName.Append(fUsuariosFormularios.OMenuFormularios.MfrId)
                    lsbMenusName.Append(",")
                    lsbPermisos.Append(fUsuariosFormularios.UsfPermisos)
                    lsbPermisos.Append(";")
                Next

                Dim lsMenus As String() = lsbMenusName.ToString().Substring(0, lsbMenusName.Length - 1).Split(",")
                Dim lsEstadoMenus As String() = lsbPermisos.ToString().Substring(0, lsbPermisos.Length - 1).Split(";")
                Dim liIndiceEstadoMenus As Integer = 0
                For Each fMenus As String In lsMenus

                    'Por Menu Obtenemos los Permisos

                    Dim lsPermisos As String() = lsEstadoMenus(liIndiceEstadoMenus).Split(",")

                    'Recorrer las Vistas y Permisos
                    For Each fTabs As XtraTabPage In tabsModulos.TabPages
                        For Each fControl As Control In fTabs.Controls
                            If TypeOf fControl Is SaimtCheckBox Then
                                If DirectCast(fControl, SaimtCheckBox).Properties.Tag = fMenus Then 'Encuentra el Control Para Luego Marcarlo
                                    DirectCast(fControl, SaimtCheckBox).Checked = True

                                    For Each fControl2 As Control In fTabs.Controls 'Vuelve a Recorrer los Controles hasta ubicar el grupo de permisos que le corresponde al check seleccionado
                                        If TypeOf fControl2 Is SaimtGroupPermisos Then
                                            If DirectCast(fControl2, SaimtGroupPermisos).Tag = fMenus Then 'Se Verifica que sea el grupo correspondiente al check seleccionado

                                                DirectCast(fControl2, SaimtGroupPermisos).chkCrear.Checked = lsPermisos(0)
                                                DirectCast(fControl2, SaimtGroupPermisos).chkEditar.Checked = lsPermisos(1)
                                                DirectCast(fControl2, SaimtGroupPermisos).chkBuscar.Checked = lsPermisos(2)
                                                DirectCast(fControl2, SaimtGroupPermisos).chkEliminar.Checked = lsPermisos(3)
                                                DirectCast(fControl2, SaimtGroupPermisos).chkImprimir.Checked = lsPermisos(4)

                                                Exit For
                                            End If
                                        End If
                                    Next

                                End If
                            End If
                        Next
                    Next
                    'Fin Reacorrer Vistas y Permisos

                    'Fin Obtencion de Permisos

                    liIndiceEstadoMenus = liIndiceEstadoMenus + 1
                Next

                GIdRegistroActual = loUsuarios.UsuId
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            lstUsuarios.DisplayMember = "UsuLogin"
            lstUsuarios.DataSource = MantenimientosBL.Instancia.usuariosListarCriterio(rdbCriterios.EditValue, txtBuscar.Text)
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub guardar()
        If String.IsNullOrEmpty(txtDatosUsuarios.Text) Then
            SaimtMessageBox.mostrarAlertaError("Seleccione a un Usuario")
            btnConsultarUsuario.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtUsuario.Text) Then
            SaimtMessageBox.mostrarAlertaError("El Usuario es Obligatorio")
            txtUsuario.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtPassword.Text) Then
            SaimtMessageBox.mostrarAlertaError("El Password es Obligatorio")
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            Dim loUsuarios As EEUsuarios = New EEUsuarios()
            Dim loUsuariosFormularios As EEUsuarios.EEUsuariosFormularios = Nothing
            Dim loMenuFormularios As EEMenuFormularios = Nothing
            Dim loPersona As EEPersona = New EEPersona()
            loPersona.PerId = txtDatosUsuarios.Tag

            loUsuarios.UsuId = GIdRegistroActual
            loUsuarios.UsuLogin = txtUsuario.Text
            loUsuarios.UsuPassword = txtPassword.Text
            loUsuarios.OPersona = loPersona

            'Recorrer las Vistas y Permisos
            For Each fTabs As XtraTabPage In tabsModulos.TabPages
                For Each fControl As Control In fTabs.Controls
                    If TypeOf fControl Is SaimtCheckBox Then
                        If DirectCast(fControl, SaimtCheckBox).Checked Then 'ENCUENTRA EL CONTROL Y LUEGO BUSCA EL GRUPO DE PERMISOS DE USUARIO
                            'VUELVE A RECORRER LOS CONTROLES HASTA UBICAR EL GRUPO DE PERMISO QUE LE CORRESPONDE AL CHECK SELECCIONADO
                            For Each fControl2 As Control In fTabs.Controls
                                If TypeOf fControl2 Is SaimtGroupPermisos Then
                                    'SE VERIFICA QUE SEA EL GRUPO CORRESPONDIENTE AL CHECK SELECCIONADO
                                    If DirectCast(fControl2, SaimtGroupPermisos).Tag = DirectCast(fControl, SaimtCheckBox).Properties.Tag Then
                                        Dim lchkSaimt As SaimtGroupPermisos = DirectCast(fControl2, SaimtGroupPermisos)

                                        loUsuariosFormularios = New EEUsuarios.EEUsuariosFormularios()

                                        If loUsuarios.ListaUsuariosFormularios Is Nothing Then
                                            loUsuarios.ListaUsuariosFormularios = New List(Of EEUsuarios.EEUsuariosFormularios)
                                        End If

                                        'OBTENEMOS EL ID DE MENU FORMULARIOS
                                        loMenuFormularios = New EEMenuFormularios()
                                        loMenuFormularios.MfrId = Convert.ToInt16(lchkSaimt.Tag)
                                        loUsuariosFormularios.OMenuFormularios = loMenuFormularios

                                        loUsuariosFormularios.UsfPermisos = lchkSaimt.chkCrear.Checked & "," & lchkSaimt.chkEditar.Checked & "," & lchkSaimt.chkBuscar.Checked & "," & lchkSaimt.chkEliminar.Checked & "," & lchkSaimt.chkImprimir.Checked

                                        loUsuarios.ListaUsuariosFormularios.Add(loUsuariosFormularios)
                                        Exit For
                                    End If
                                End If
                            Next
                        End If
                    End If
                Next
            Next

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.usuariosGuardar(loUsuarios)
            Else
                MantenimientosBL.Instancia.usuariosActualizar(loUsuarios)
            End If
            Me.enabledGA = False
            MyBase.guardar()

            tabsModulos.Enabled = False
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtDatosUsuarios.Tag = 0
        txtDatosUsuarios.Properties.ReadOnly = True
        mLimpiarCheckBoxes()
        tabsModulos.Enabled = True
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        txtDatosUsuarios.Properties.ReadOnly = True
        tabsModulos.Enabled = True
    End Sub

    Protected Overrides Sub eliminar()
        Try
            MyBase.eliminar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Load"
    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PuedeBuscar = True
            Me.PuedeCrear = True
            Me.PuedeEditar = True
            Me.PuedeExportar = True
            Me.PuedeImprimir = True
            mLlenarTabs()

            'For Each fControl As Control In tabsModulos.TabPages
            '    hodControlesTotal(fControl.Controls, False)
            'Next

            tabsModulos.Enabled = False
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Llenar Tabs"
    ''' <summary>
    ''' Llena el Control Tab con todas las pestañas del formulario principal
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub mLlenarTabs()
        Dim ListaGrupoFormularios As List(Of EEGrupoFormularios) = MantenimientosBL.Instancia.grupoformulariosListarALL_EnUsuarios()
        For Each fGrupoFormularios As EEGrupoFormularios In ListaGrupoFormularios
            Dim liChkAccesoX As Integer = 14
            Dim liChkAccesoY As Integer = 12

            Dim xtpTabsModulos As XtraTabPage = New XtraTabPage()
            xtpTabsModulos.Text = fGrupoFormularios.GrfNombre

            For Each fMenuFormularios As EEMenuFormularios In fGrupoFormularios.ListaMenuFormularios
                Dim chkAccesos As SaimtCheckBox = New SaimtCheckBox()
                chkAccesos.Text = fMenuFormularios.MfrTitulo
                chkAccesos.Location = New Point(liChkAccesoX, liChkAccesoY)
                chkAccesos.Tag = "Vistas"
                chkAccesos.Properties.Tag = fMenuFormularios.MfrId
                chkAccesos.Properties.AutoWidth = True

                Dim chkPermisosVistas As SaimtGroupPermisos = New SaimtGroupPermisos()
                chkPermisosVistas.Name = fMenuFormularios.MfrId
                chkPermisosVistas.Tag = fMenuFormularios.MfrId
                liChkAccesoX += 150
                chkPermisosVistas.Location = New Point(tabsModulos.Width - (chkPermisosVistas.Width + 10), liChkAccesoY - 4)

                chkAccesos.Properties.AutoWidth = True

                liChkAccesoY += 25
                liChkAccesoX = 14

                xtpTabsModulos.Controls.Add(chkAccesos)
                xtpTabsModulos.Controls.Add(chkPermisosVistas)
            Next
            xtpTabsModulos.AutoScroll = True
            tabsModulos.TabPages.Add(xtpTabsModulos)
        Next
    End Sub
#End Region

    Public Sub mMarcarPermisoVista(ByVal asPermiso As String, ByVal lbEstadoChecked As Boolean)
        For Each fControl As Control In tabsModulos.SelectedTabPage.Controls
            If TypeOf fControl Is SaimtCheckBox Then
                If DirectCast(fControl, SaimtCheckBox).Tag = asPermiso Then
                    DirectCast(fControl, SaimtCheckBox).Checked = lbEstadoChecked
                End If
            End If
        Next
    End Sub

    Private Sub btnConsultarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarUsuario.Click
        Using fmConsultaPersonaUsuarios As frmConsultaPersonaGeneral = New frmConsultaPersonaGeneral(1)
            If fmConsultaPersonaUsuarios.ShowDialog() = DialogResult.OK Then
                txtDatosUsuarios.Text = fmConsultaPersonaUsuarios.PerNombre
                txtDatosUsuarios.Tag = fmConsultaPersonaUsuarios.PerId
            End If
        End Using
    End Sub

    Private Sub btnMarcarVistas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarVistas.Click
        mMarcarPermisoVista("Vistas", True)
    End Sub

    Private Sub btnDesmarcarVistas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmarcarVistas.Click
        mMarcarPermisoVista("Vistas", False)
    End Sub

#Region "Limpiar CheckBoxes"
    ''' <summary>
    ''' LIMPIA LAS VISTAS COMO EL GRUPO DE PERMISOS
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub mLimpiarCheckBoxes()
        For Each fControl As Control In tabsModulos.TabPages
            For Each fControl2 As Control In fControl.Controls
                If TypeOf fControl2 Is SaimtCheckBox Then
                    DirectCast(fControl2, SaimtCheckBox).Checked = False
                ElseIf TypeOf fControl2 Is SaimtGroupPermisos Then
                    DirectCast(fControl2, SaimtGroupPermisos).chkCrear.Checked = False
                    DirectCast(fControl2, SaimtGroupPermisos).chkEditar.Checked = False
                    DirectCast(fControl2, SaimtGroupPermisos).chkBuscar.Checked = False
                    DirectCast(fControl2, SaimtGroupPermisos).chkEliminar.Checked = False
                    DirectCast(fControl2, SaimtGroupPermisos).chkImprimir.Checked = False
                End If
            Next
        Next
    End Sub
#End Region

    Private Sub btnRevelarPassword_Click(sender As System.Object, e As System.EventArgs) Handles btnRevelarPassword.Click
        If Not String.IsNullOrEmpty(txtPassword.Text) Then
            Dim fmMostrarPassword As frmMostrarPassword = New frmMostrarPassword()
            fmMostrarPassword.PasswordEncriptado = txtPassword.Text
            fmMostrarPassword.ShowDialog()
        End If
    End Sub

    Private Sub SaimtButton1_Click(sender As System.Object, e As System.EventArgs)
        Dim fmTA As frmTransferirAnexos = New frmTransferirAnexos()
        fmTA.ShowDialog()
    End Sub
End Class