﻿Imports System.ComponentModel
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraTab
Imports SaimtControles
Imports System.Net.NetworkInformation
Imports System.Net
Imports Entidades
Imports ReglasNegocio
Imports System.Text

Public Class frmPrincipal

#Region "Propiedades"
    Public Property UsuarioBienvenido() As String
    Public Property Usuario() As String
    Public Property UsuarioLogin() As String
    Public Property UsuarioNroDocumento() As String
    Public Property UsuarioMAC() As String
    Public Property UsuarioIP() As String
    Public Property Fecha() As String
    Public Property MenusName() As String
    Public Property Permisos() As String
    Public Property TipoDocumento() As String
#End Region

#Region "Cargar Form"
    Public Sub CargarForm(ByVal Formulario As frmGeneral)
        Me.UseWaitCursor = True
        Try
            Application.DoEvents()
            For Each Frm As Form In Me.MdiChildren
                If Frm.Name = Formulario.Name Then
                    Frm.WindowState = FormWindowState.Normal
                    Frm.BringToFront()
                    Frm.Activate()
                    Return
                End If
            Next
            Formulario.IdUsuarioOnline = EEComun.UsuIdOnline
            Dim lsMenus As String() = MenusName.Split(",")
            Dim lsEstadoMenus As String() = Permisos.Split(";")
            Dim liIndiceEstadoMenus As Integer = 0
            For Each fMenu As String In lsMenus
                Dim lsPermisos As String() = lsEstadoMenus(liIndiceEstadoMenus).Split(",")
                If Formulario.Tag = fMenu Then
                    Formulario.PuedeCrear = lsPermisos(0)
                    Formulario.PuedeEditar = lsPermisos(1)
                    Formulario.PuedeBuscar = lsPermisos(2)
                    Formulario.PuedeEliminar = lsPermisos(3)
                    Formulario.PuedeImprimir = lsPermisos(4)
                    Exit For
                End If
                liIndiceEstadoMenus = liIndiceEstadoMenus + 1
            Next
            'Formulario.MdiParent = Me
            Formulario.BringToFront()
            Formulario.Show()
            Formulario.Activate()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub
#End Region

    Dim lsMensaje As String
    Dim lsTitulo As String
    Dim liNumero As Integer
    Dim h, w As Integer
    Dim loPersona As EEPersona = Nothing
    Dim ListaPersona As List(Of EEPersona)
    Dim mayAsunto, mayCom As Integer
    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tmrMarquee.Start()
        'tmrBandeja.Start()
        bsiUsuarioDNI.Caption = String.Format("{0} : {1}", TipoDocumento, UsuarioNroDocumento)
        bsiUsuarioLogin.Caption &= UsuarioLogin
        bsiBienvenido.Caption = UsuarioBienvenido
        bsiFecha.Caption = Fecha
        bsiNombrePC.Caption &= Environment.MachineName
        bsiUsuarioMAC.Caption &= UsuarioMAC
        bsiUsuarioIP.Caption &= UsuarioIP
        'Deshabilitar Todos Los Menus
        For Each rpTabsMenuPrincipal As RibbonPage In rcMenuPrincipal.Pages
            For Each rpgGrupoModulos As RibbonPageGroup In rpTabsMenuPrincipal.Groups
                For i As Integer = 0 To rpgGrupoModulos.ItemLinks.RecentLinkCount - 1
                    rpgGrupoModulos.ItemLinks.Item(i).Item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Next
            Next
        Next
        'Fin Deshabilitar Todos Los Menus

        'Habilitar Menus Segun Permisos
        Dim lsMenus As String() = MenusName.Split(",")
        For Each rpTabsMenuPrincipal As RibbonPage In rcMenuPrincipal.Pages
            For Each rpgGrupoModulos As RibbonPageGroup In rpTabsMenuPrincipal.Groups
                For i As Integer = 0 To rpgGrupoModulos.ItemLinks.RecentLinkCount - 1
                    For Each fMenus As String In lsMenus
                        If rpgGrupoModulos.ItemLinks.Item(i).Item.Name = fMenus Then
                            rpgGrupoModulos.ItemLinks.Item(i).Item.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            Exit For
                        End If
                    Next
                Next
            Next
        Next
        'Fin Habilitar Menus Segun Permisos

        'Ocultar Pestañas En Caso No Halla Ningun Menu Permitido
        For Each rpTabsMenuPrincipal As RibbonPage In rcMenuPrincipal.Pages
            Dim liVisibles As Int32 = 0
            Dim liNoVisibles As Int32 = 0
            For Each rpgGrupoModulos As RibbonPageGroup In rpTabsMenuPrincipal.Groups
                For i As Integer = 0 To rpgGrupoModulos.ItemLinks.RecentLinkCount - 1
                    liVisibles = liVisibles + 1
                Next

                For i As Integer = 0 To rpgGrupoModulos.ItemLinks.RecentLinkCount - 1
                    If rpgGrupoModulos.ItemLinks.Item(i).Item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                        liNoVisibles = liNoVisibles + 1
                    End If
                Next
            Next
            If liVisibles = liNoVisibles Then
                rpTabsMenuPrincipal.Visible = False
            End If
        Next
        'Fin Ocultar Pestañas En Caso No Halla Ningun Menu Permitido

    End Sub

    Private Sub btiFinca_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiInmuebles.ItemClick
        CargarForm(New frmInmuebles())
    End Sub

    Private Sub btiClientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPersona.ItemClick
        CargarForm(New frmPersona())
    End Sub

    Private Sub btiInmuebles_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiContrato.ItemClick
        CargarForm(New frmContrato())
    End Sub

    Private Sub btiUsuarios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiUsuarios.ItemClick
        CargarForm(New frmUsuarios())
    End Sub

    Private Sub bbiClase_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiClase.ItemClick
        CargarForm(New frmClase())
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiTablaGeneral.ItemClick
        CargarForm(New frmTablaGeneral())
    End Sub

    Private Sub btiProgPag_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiProgPag.ItemClick
        CargarForm(New frmProgramacionPagos())
    End Sub

    Private Sub btiConsultaInm_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiConsultaInm.ItemClick
        CargarForm(New frmConsultorMargesiXItem())
    End Sub

    Private Sub frmPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If SaimtMessageBox.mostrarAlertaPregunta("Desea Salir de la Aplicación", "Salir") = True Then
            e.Cancel = False
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btiCambiarPassword_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiCambiarPassword.ItemClick
        CargarForm(New frmCambiarPassword())
    End Sub

    Private Sub btiProgPagIE_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiProgPagIE.ItemClick
        CargarForm(New frmProPagMant())
    End Sub

    Private Sub bbiOcultarMostrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOcultarMostrar.ItemClick
        pnlMarquee.Visible = bbiOcultarMostrar.Down
        If pnlMarquee.Visible Then
            Me.tmrMarquee.Start()
            bbiOcultarMostrar.Caption = "Ocultar"
        Else
            Me.tmrMarquee.Stop()
            bbiOcultarMostrar.Caption = "Mostrar"
        End If
    End Sub

    Private Sub BarButtonItem5_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiConsultorProgramacionPagos.ItemClick
        CargarForm(New frmConsultaProgramacionPagos())
    End Sub

    Private Sub btiRecaudacionIE_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiRecaudacionIE.ItemClick
        CargarForm(New frmImportarRecSatt())
    End Sub

    Private Sub btiPivotRecaudacion_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotRecaudacion.ItemClick
        frmRptReSatt.Show()
    End Sub

    Private Sub btiActualizarDetracciones_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiActualizarDetracciones.ItemClick
        CargarForm(New frmActualizarDetraccion())
    End Sub

    Private Sub btiGeneracionOrdenPago_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiGeneracionOrdenPago.ItemClick
        CargarForm(New frmGeneracionOrdenPago())
    End Sub

    Private Sub btiBuscarPersonaXDNI_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiBuscarPersonaXDNI.ItemClick
        CargarForm(New frmReniec())
    End Sub

    Private Sub btiImportacionTerminal_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiImportacionTerminal.ItemClick
        CargarForm(New frmImportarRecTerminal())
    End Sub
    Private Sub bbemostrar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbemostrar.ItemClick
        pnlMarquee.Visible = Not pnlMarquee.Visible
        Me.tmrMarquee.Enabled = Not Me.tmrMarquee.Enabled
        bbiOcultarMostrar.Down = Not bbiOcultarMostrar.Down
        If pnlMarquee.Visible Then
            bbiOcultarMostrar.Caption = "Ocultar"
            Me.bbemostrar.Caption = "Ocultar"
        Else
            Me.bbemostrar.Caption = "Mostrar"
            bbiOcultarMostrar.Caption = "Mostrar"
        End If
    End Sub

    Private Sub btiReportesDecoin_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiReportesDecoin.ItemClick
        CargarForm(New frmRptDecoin())
    End Sub

    Private Sub btiPivotearProPagos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotearProPagos.ItemClick
        Dim fmRptPivotProPagos As frmRptPivotProPagos = New frmRptPivotProPagos()
        fmRptPivotProPagos.ShowInTaskbar = True
        fmRptPivotProPagos.WindowState = FormWindowState.Maximized
        fmRptPivotProPagos.Show()
    End Sub

    Private Sub btiGrupoFormularios_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiGrupoFormularios.ItemClick
        CargarForm(New frmGrupoFormulario())
    End Sub

    Private Sub btiMenuFormularios_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiMenuFormularios.ItemClick
        CargarForm(New frmMenuFormularios())
    End Sub

    Private Sub btiSimuladorProPagos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiSimuladorProPagos.ItemClick
        CargarForm(New frmSimulador())
    End Sub

    Private Sub btiInstituciones_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiInstituciones.ItemClick
        CargarForm(New frmInstitucion())
    End Sub

    Private Sub btiAreas_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiAreas.ItemClick
        CargarForm(New frmAreas())
    End Sub

    Private Sub btiCargos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiCargos.ItemClick
        CargarForm(New frmCargos())
    End Sub

    Private Sub btiDocumento_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiDocumento.ItemClick
        CargarForm(New frmDocumento())
    End Sub

    Private Sub btiProcedimiento_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiProcedimiento.ItemClick
        CargarForm(New frmProcedimientos())
    End Sub

    Private Sub btiRequisitos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiRequisitos.ItemClick
        CargarForm(New frmRequisito())
    End Sub

    Private Sub btiProcReq_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiProcReq.ItemClick
        CargarForm(New frmProcReq())
    End Sub

    Private Sub btiEtapas_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiEtapas.ItemClick
        CargarForm(New frmEtapas())
    End Sub

    Private Sub btiBandejaEnt_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiBandejaEnt.ItemClick
        frmBandejaEntrada.Show()
    End Sub

    Private Sub btiTrabajador_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiTrabajador.ItemClick
        CargarForm(New frmTrabajador())
    End Sub

    Private Sub btiPermisosSTD_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPermisosSTD.ItemClick
        CargarForm(New frmPermisosSTD())
    End Sub

    Private Sub btiTipoDocumentoCargos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiTipoDocumentoCargos.ItemClick
        CargarForm(New frmCargoTipoDoc())
    End Sub

    Private Sub btiVincularDesvincularDocumento_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiVincularDesvincularDocumento.ItemClick
        CargarForm(New frmAgrupacionDoc())
    End Sub

    Private Sub btiEstadoTramite_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiEstadoTramite.ItemClick
        CargarForm(New frmEstadoSiguiente())
    End Sub

    Private Sub btiEstadovsAcciones_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiEstadovsAcciones.ItemClick
        CargarForm(New frmAccionesVsEstadoMovSTD())
    End Sub

    Private Sub btiCargoTipoAccion_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiCargoTipoAccion.ItemClick
        CargarForm(New frmCargoTipoAccionSTD())
    End Sub

    Private Sub btiActualizarPermisos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiActualizarPermisos.ItemClick
        Try
            Dim loUsuarios As EEUsuarios = MantenimientosBL.Instancia.usuariosListarActualizarPermisos_XUsuId(EEComun.UsuIdOnline)
            Dim lsMenusName As StringBuilder = New StringBuilder()
            Dim lsPermisos As StringBuilder = New StringBuilder()
            For Each fUsuariosFormularios As EEUsuarios.EEUsuariosFormularios In loUsuarios.ListaUsuariosFormularios
                lsMenusName.Append(fUsuariosFormularios.OMenuFormularios.MfrNombre)
                lsMenusName.Append(",")
                lsPermisos.Append(fUsuariosFormularios.UsfPermisos)
                lsPermisos.Append(";")
            Next
            MenusName = lsMenusName.ToString().Substring(0, lsMenusName.Length - 1)
            Permisos = lsPermisos.ToString.Substring(0, lsPermisos.Length - 1)
            'Deshabilitar Todos Los Menus
            For Each rpTabsMenuPrincipal As RibbonPage In rcMenuPrincipal.Pages
                For Each rpgGrupoModulos As RibbonPageGroup In rpTabsMenuPrincipal.Groups
                    For i As Integer = 0 To rpgGrupoModulos.ItemLinks.RecentLinkCount - 1
                        rpgGrupoModulos.ItemLinks.Item(i).Item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Next
                Next
            Next
            'Fin Deshabilitar Todos Los Menus
            'Habilitar Menus Segun Permisos
            Dim lsMenus As String() = MenusName.Split(",")
            For Each rpTabsMenuPrincipal As RibbonPage In rcMenuPrincipal.Pages
                For Each rpgGrupoModulos As RibbonPageGroup In rpTabsMenuPrincipal.Groups
                    For i As Integer = 0 To rpgGrupoModulos.ItemLinks.RecentLinkCount - 1
                        For Each fMenus As String In lsMenus
                            If rpgGrupoModulos.ItemLinks.Item(i).Item.Name = fMenus Then
                                rpgGrupoModulos.ItemLinks.Item(i).Item.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                                Exit For
                            End If
                        Next
                    Next
                Next
            Next
            'Fin Habilitar Menus Segun Permisos
            'Ocultar Pestañas En Caso No Halla Ningun Menu Permitido
            For Each rpTabsMenuPrincipal As RibbonPage In rcMenuPrincipal.Pages
                Dim liVisibles As Int32 = 0
                Dim liNoVisibles As Int32 = 0
                For Each rpgGrupoModulos As RibbonPageGroup In rpTabsMenuPrincipal.Groups
                    For i As Integer = 0 To rpgGrupoModulos.ItemLinks.RecentLinkCount - 1
                        liVisibles = liVisibles + 1
                    Next

                    For i As Integer = 0 To rpgGrupoModulos.ItemLinks.RecentLinkCount - 1
                        If rpgGrupoModulos.ItemLinks.Item(i).Item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
                            liNoVisibles = liNoVisibles + 1
                        End If
                    Next
                Next
                If liVisibles = liNoVisibles Then
                    rpTabsMenuPrincipal.Visible = False
                End If
            Next
            'Fin Ocultar Pestañas En Caso No Halla Ningun Menu Permitido
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btiConsultorSTD_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiConsultorSTD.ItemClick
        CargarForm(New RptResumido)
    End Sub

    Private xPos As Integer = 0
    Private YPos As Integer = 9

    Private Sub tmrMarquee_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMarquee.Tick
        If Me.Width = xPos Then
            'repeat marquee
            Me.lblText.Location = New System.Drawing.Point(0, YPos)
            xPos = 0
        Else
            Me.lblText.Location = New System.Drawing.Point(xPos, YPos)
            xPos += 2
        End If
    End Sub

    Private Sub tmrBandeja_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBandeja.Tick
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = MantenimientosBL.Instancia.movimientoSTD_consultar_noleidos_XPerId(EEComun._PerId)
        If ListaMovimientoSTD IsNot Nothing Then
            liNumero = 1
            mayAsunto = -1
            mayCom = -1
            lsTitulo = String.Empty
            lsMensaje = String.Empty
            lsTitulo = "Usted Tiene " & ListaMovimientoSTD.Count & " Mensajes Sin Leer"
            For Each fMovimientoSTD As EEMovimientoSTD In ListaMovimientoSTD
                lsMensaje &= "<b>" & liNumero & ".</b>  <b>Asunto:</b> " & fMovimientoSTD.ODocumento.DocAsunto & " - <b>Comentario Envio:</b> " & fMovimientoSTD.MovComentario & Environment.NewLine & " <b>Remitente:</b> (" & fMovimientoSTD.OJerarquia.CargoOrigen & ")" & vbNewLine
                ListaPersona = MantenimientosBL.Instancia.personaListarXCargoId(fMovimientoSTD.MovDe)
                For Each Me.loPersona In ListaPersona
                    lsMensaje &= "   - " & loPersona.PerNombreCompleto & Environment.NewLine
                Next
                liNumero = liNumero + 1
                If fMovimientoSTD.ODocumento.DocAsunto.Length > mayAsunto Then
                    mayAsunto = fMovimientoSTD.ODocumento.DocAsunto.Length
                End If
                If fMovimientoSTD.MovComentario.Length > mayCom Then
                    mayCom = fMovimientoSTD.MovComentario.Length
                End If
            Next
            acMensaje.Show(Me.FindForm, lsTitulo, lsMensaje, lsMensaje, Me.ImageCollection2.Images(2))
        End If
    End Sub

    Private Sub acMensaje_ButtonClick(sender As System.Object, e As DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs) Handles acMensaje.ButtonClick
        If e.ButtonName = acMensaje.Buttons.Item(0).Name Then
            tmrBandeja.Stop()
        End If
        If e.ButtonName = acMensaje.Buttons.Item(1).Name Then
            frmBandejaEntrada.Show()
        End If
    End Sub

    Private Sub acMensaje_AlertClick(sender As System.Object, e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles acMensaje.AlertClick
        frmBandejaEntrada.Show()
    End Sub

    Private Sub acMensaje_BeforeFormShow(sender As System.Object, e As DevExpress.XtraBars.Alerter.AlertFormEventArgs) Handles acMensaje.BeforeFormShow
        If acMensaje.AutoHeight Then
            w = 260 + mayAsunto * 5 + mayCom * 5
        End If
        e.AlertForm.Size = New Size(w, 100)
    End Sub

    Private Sub btiOrigenDocVsMovDoc_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiOrigenDocVsMovDoc.ItemClick
        CargarForm(New frmOrigenDocvsTipoAccion())
    End Sub

    Private Sub btiDetalleRecaudacion_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiDetalleRecaudacion.ItemClick
        Dim ofrmIngresos As New frmRptIngresos()
        ofrmIngresos.Show()
    End Sub

    Private Sub btiUnidadMedida_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiUnidadMedida.ItemClick
        CargarForm(New frmUnidadMedida())
    End Sub

    Private Sub btiArtFamilia_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiArtFamilia.ItemClick
        CargarForm(New frmGruposArt())
    End Sub

    Private Sub btiArticulo_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiArticulo.ItemClick
        CargarForm(New frmArticulo())
        ' CargarForm(New frmRequerimientoLog())
    End Sub

    Private Sub btiProveedor_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiProveedor.ItemClick
        Dim ofrm As New frmPersona("01")
        ofrm.Text = "Registrar Proveedor"
        CargarForm(ofrm) ' Per Ref Proveedor
    End Sub

    Private Sub btiOrdenCompra_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiOrdenCompra.ItemClick
        CargarForm(New frmOrdenCompra())
    End Sub

    Private Sub btiOrdenCompraServicio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiOrdenServicio.ItemClick
        CargarForm(New frmOrdenServicio())
    End Sub

    Private Sub btiReporteTrabajadores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiReporteTrabajadores.ItemClick
        CargarForm(New frmReporteAsistencias())
    End Sub

    Private Sub btiPartidas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPartidas.ItemClick
        CargarForm(New frmPartidas())
    End Sub

    Private Sub btiPlanCuentas_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPlanCuentas.ItemClick
        CargarForm(New frmPlanCuentas())
    End Sub

    Private Sub btiPivotTrabajador_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotTrabajador.ItemClick
        Dim ofrm As New frmReporteTrabajadores()
        ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub

    Private Sub btiTipoBienesNoInventariados_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiTipoBienesNoInventariados.ItemClick
        CargarForm(New frmTipoBienesNoInv())
    End Sub

    Private Sub btiNotaSalidaLog_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPecosa.ItemClick
        CargarForm(New frmPecosa())
    End Sub

    Private Sub btiIngresoVehiculo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiIngresoVehiculo.ItemClick
        CargarForm(New frmIngresoVehiculos())
    End Sub

    Private Sub btiRegistroAbonados_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiRegistroAbonados.ItemClick
        Dim ofrm As New frmPersona("04")
        ofrm.Text = "Registrar Abonado"
        CargarForm(ofrm) ' Per Ref Proveedor
    End Sub

    Private Sub btiSalidaCaja_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiSalidaCaja.ItemClick
        CargarForm(New frmSalidaCaja())
    End Sub

    Private Sub btiExtornoAbono_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiExtornoAbono.ItemClick
        CargarForm(New frmExtornarAbonos())
    End Sub

    Private Sub btiReportesGeneralPEM_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiReportesGeneralPEM.ItemClick
        CargarForm(New frmReportesGeneralPEM())
    End Sub

    Private Sub btiConsultaDetalleAbono_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiConsultaDetalleAbono.ItemClick
        CargarForm(New frmConsultarDetalleAbono())
    End Sub

    Private Sub btiContratosAbonados_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiContratosAbonados.ItemClick
        Dim ofrm As New frmAbonos()
        ofrm.btnCancelarContrato.Visible = False
        ofrm.Show()
    End Sub

    Private Sub btiExtornoHoraFraccion_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiExtornoHoraFraccion.ItemClick
        CargarForm(New frmExtornarIngreso())
    End Sub

    Private Sub btiPivotearPorConceptos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotearPorConceptos.ItemClick
        Dim ofrm As frmPivotearPEM = New frmPivotearPEM
        ofrm.ShowInTaskbar = True
        ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub



    Private Sub bticonceptos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bticonceptos.ItemClick
        CargarForm(New frmConceptos)
    End Sub

    Private Sub btiConsultorUbicacion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiConsultorUbicacion.ItemClick
        CargarForm(New frmConsultaInmuebleXCriterios())
    End Sub

    Private Sub btiPivotDocumentosExternos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotDocumentosExternos.ItemClick
        Dim ofrm As frmReporteDocumentos = New frmReporteDocumentos
        ofrm.ShowInTaskbar = True
        ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub

    Private Sub btiPivotOrdenServicio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotOrdenServicio.ItemClick
        Dim ofrm As New frmRptPivotOrdenesServicio()
        ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub

    Private Sub btiPivotOrdenCompra_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotOrdenCompra.ItemClick
        Dim ofrm As New frmRptPivotOrdenesCompra()
        ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub

    Private Sub btiPartida_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPartida.ItemClick
        Dim ofrm As New frmPartidas()
        'ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub

    Private Sub btiPivotPecosa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotPecosa.ItemClick
        Dim ofrm As New frmRptPivotPecosa()
        ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub

    Private Sub btiCompPago_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiCompPago.ItemClick
        Dim ofrm As New frmComprobantePago()
        'ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub

    Private Sub btiCajaChica_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiCajaChica.ItemClick
        Dim ofrm As New frmCajaChica()
        ofrm.Show()
    End Sub

    Private Sub btiCertificacion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiCertificacion.ItemClick
        Dim ofrm As New frmCerticicacion()
        ofrm.Show()
    End Sub

    Private Sub btiContratosFincas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiContratosFincas.ItemClick
        Dim ofrm As New frmRptContratos
        ofrm.Show()
    End Sub

    Private Sub btiCajaChicaConfig_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiCajaChicaConfig.ItemClick
        Dim ofrm As New frmCajaChicaConfiguracion()
        ofrm.Show()
    End Sub

    Private Sub btiCajaChicaMovimiento_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiCajaChicaMovimiento.ItemClick
        Dim ofrm As New frmCajaChicaMovimiento()
        ofrm.Show()
    End Sub

    Private Sub btiInmuebleAltas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiInmuebleAltas.ItemClick
        Dim ofrm As New frmInmueblesAlta()
        ofrm.Show()
    End Sub

    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiCajaChicaMovimientoReporte.ItemClick
        Dim ofrm As New frmCajaChicaMovimientoReporte()
        ofrm.Show()
    End Sub

    Private Sub btiPivotearCajaChica_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotearCajaChica.ItemClick
        Dim ofrm As New frmPivotearCajaChica
        ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub

    Private Sub btiPivotResumenOrdenServicio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotResumenOrdenServicio.ItemClick
        Dim ofrm As New frmRptPivotResumenOrdenesServicio()
        ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub

    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiInmuebleBajas.ItemClick
        Dim ofrm As New frmInmueblesBaja()
        ofrm.WindowState = FormWindowState.Maximized
        ofrm.Show()
    End Sub

    Private Sub btiConsultordeAltasyBajas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiConsultordeAltasyBajas.ItemClick
        CargarForm(New frmInmueblesConsultorAltasyBajas())
    End Sub

    Private Sub btiRecaudacionDiaria_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiRecaudacionDiaria.ItemClick
        CargarForm(New frmRecaudacionDiaria())
    End Sub

    Private Sub btiInmueblesRptFinal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiInmueblesRptFinal.ItemClick
        CargarForm(New frmInmueblesRptFinal())
    End Sub

 
    Private Sub btiActualizacionPendientesMargesi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiConsultorActualizacionMargesi.ItemClick
        CargarForm(New frmInmueblesActualizaciones())
    End Sub

    Private Sub btiConsActualizacionMargesi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiConsActualizacionMargesi.ItemClick
        CargarForm(New frmInmueblesConsultorActualizaciones())
    End Sub

    Private Sub btiReportesResumenSTD_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiReportesResumenSTD.ItemClick
        CargarForm(New RptResumido())
    End Sub

    Private Sub BarButtonItem9_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiRinconadaIngreso.ItemClick
        CargarForm(New frmParqueoRinconada())
    End Sub

    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiRinconadaSalida.ItemClick
        CargarForm(New frmSalidaCajaRinconada())
    End Sub

    Private Sub btiRinconadaBoleteria_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiRinconadaBoleteria.ItemClick
        CargarForm(New frmBoleteriaRinconada())
    End Sub

    Private Sub btiPivotearRinconada_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiPivotearRinconada.ItemClick
        CargarForm(New frmPivotearRinconada())
    End Sub

    Private Sub btiExtornoDiarioRinconada_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiExtornoDiarioRinconada.ItemClick
        CargarForm(New frmExtornarIngresoRinconada())
    End Sub

    Private Sub btiTransferenciaRiconada_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiTransferenciaRiconada.ItemClick
        CargarForm(New frmTransferencia())
    End Sub

    Private Sub btiRincoRecaudacion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiRincoRecaudacion.ItemClick
        CargarForm(New frmImportarRecSatt())
    End Sub

    Private Sub btiProcesos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiProcesos.ItemClick
        CargarForm(New frmManProcesos())
    End Sub

    Private Sub btiSubProcesos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiSubProcesos.ItemClick
        CargarForm(New frmManSubProcesos())
    End Sub

    Private Sub btiprocedimientos_ItemClick_2(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        CargarForm(New frmManProcedimientos())
    End Sub

    Private Sub BarButtonItem10_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btiSolicitudes.ItemClick
        CargarForm(New frmRegistroSolicitud())
    End Sub

    Private Sub BarButtonItem11_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bitMovimientosProcd.ItemClick
        CargarForm(New frmVisualizadorTareasxArea())
    End Sub
End Class
