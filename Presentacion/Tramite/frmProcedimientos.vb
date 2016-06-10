﻿Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Public Class frmProcedimientos
    Dim claseCalificacion As Integer = 88
    Dim claseArea As Integer = 83
    Dim claseInstitucion As Integer = 82
    Dim codAreaInicia As String
    Dim codAreaFin As String
    Dim codInstitucion, codInstitucionr As String

#Region "Funciones Sobreescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If LstProcedimiento.SelectedItem IsNot Nothing Then
                limpiarControlesTotal(SaimtGroupBox2.Controls)
                Dim loProcedimiento As EEProcedimientoSTD = DirectCast(LstProcedimiento.SelectedValue, EEProcedimientoSTD)
                If loProcedimiento IsNot Nothing Then
                    txtcodProc.EditValue = loProcedimiento.ProcId
                    txtNombreProc.EditValue = loProcedimiento.ProcNombre
                    TxtComentario.EditValue = loProcedimiento.ProcDescripcion
                    TxtNroDias.EditValue = loProcedimiento.ProcMaxDia
                    sCboCalificacion.EditValue = loProcedimiento.TgCalificacionId
                    codAreaInicia = loProcedimiento.OUTablaGeneralAreaInicio.TgCodigo
                    txtAreaInicio.Text = loProcedimiento.OUTablaGeneralAreaInicio.TgNombre
                    codAreaFin = loProcedimiento.OUTablaGeneralAreaFin.TgCodigo
                    TxtAreaResuelve.Text = loProcedimiento.OUTablaGeneralAreaFin.TgNombre
                    txtinstitucion.Text = loProcedimiento.OUTablaGeneralInstitucion.TgNombre
                    txtinstitucionr.Text = loProcedimiento.OUTablaGeneralInstitucionR.TgNombre
                    codInstitucion = loProcedimiento.OUTablaGeneralInstitucion.TgCodigo
                    codInstitucionr = loProcedimiento.OUTablaGeneralInstitucionR.TgCodigo
                    TxtFinalidad.EditValue = loProcedimiento.ProcFinalidad
                    TxtBaseLegal.EditValue = loProcedimiento.ProcBaseLegal
                    TxtDerechoTramite.EditValue = loProcedimiento.ProcDerTramite
                    chkActivo.EditValue = loProcedimiento.ProcActivo
                    TxtPorUIT.EditValue = loProcedimiento.ProcPUIT
                End If
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub listar()
        Try
            LstProcedimiento.DisplayMember = "ProcNombre"
            LstProcedimiento.DataSource = MantenimientosBL.Instancia.procedimientostdListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            MyBase.listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub Buscar()
        Try
            LstProcedimiento.DisplayMember = "ProcNombre"
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = sRdbBuscarPor.EditValue
            LstProcedimiento.DataSource = MantenimientosBL.Instancia.procedimientostdListarCriterio(sRdbBuscarPor.EditValue, txtBuscarPor.Text)
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub
    Protected Overrides Sub Nuevo()
        MyBase.nuevo()

        txtcodProc.Text = MantenimientosBL.Instancia.ProcedimientoSTDNewCodigo()
        txtcodProc.Properties.ReadOnly = True
        txtinstitucion.Properties.ReadOnly = True
        txtinstitucionr.Properties.ReadOnly = True
        txtAreaInicio.Properties.ReadOnly = True
        TxtAreaResuelve.Properties.ReadOnly = True
        txtinstitucion.Properties.ReadOnly = True
        txtinstitucionr.Properties.ReadOnly = True
        txtNombreProc.Focus()
    End Sub

    Protected Overrides Sub guardar()
        Try


            If txtcodProc.EditValue = "" Or txtcodProc.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No se ha generado el Codigo procedimiento, es imposible guardar")
                Return
            End If
            If txtNombreProc.EditValue = "" Or txtNombreProc.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No se ha Ingresado el Nombre del procedimiento")
                txtNombreProc.Focus()
                Return
            End If
            If TxtNroDias.EditValue < 0 Or TxtNroDias.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No se ha Ingresado el Nro de Dias del procedimiento")
                TxtNroDias.Focus()
                Return
            End If

            If sCboCalificacion.EditValue = "" Or sCboCalificacion.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No se ha seleccionado la calificacion del Procedimiento")
                sCboCalificacion.Focus()
                Return
            End If
     
            If codAreaInicia = "" Or codAreaInicia Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No se ha seleccionado el Area donde Inicia el Procedimiento")
                btnAreaOrigen.Focus()
                Return
            End If
            If codAreaFin = "" Or codAreaFin Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No se ha seleccionado el Area donde se Resuelve el Procedimiento")
                BtnAreaResuelve.Focus()
                Return
            End If
  

            If TxtPorUIT.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No se ha proporcionado el Porcentaje de la UIT")
                TxtPorUIT.Focus()
                Return
            End If


            Dim loProcedimiento As New EEProcedimientoSTD
            loProcedimiento.ProcId = txtcodProc.EditValue
            loProcedimiento.ProcNombre = txtNombreProc.EditValue
            loProcedimiento.ProcDescripcion = TxtComentario.EditValue
            loProcedimiento.ProcMaxDia = TxtNroDias.EditValue
            loProcedimiento.TgCalificacionId = sCboCalificacion.EditValue
            loProcedimiento.TgAreaInicio = codAreaInicia & codInstitucion
            loProcedimiento.TgAreaFin = codAreaFin & codInstitucionr
            loProcedimiento.ProcFinalidad = TxtFinalidad.EditValue
            loProcedimiento.ProcBaseLegal = TxtBaseLegal.EditValue
            loProcedimiento.ProcDerTramite = TxtDerechoTramite.EditValue
            loProcedimiento.ProcActivo = chkActivo.EditValue
            loProcedimiento.ProcPUIT = TxtPorUIT.EditValue
            If GEstadoNuevo Then
                MantenimientosBL.Instancia.procedimientostdGuardar(loProcedimiento)
            Else
                MantenimientosBL.Instancia.procedimientostdActualizar(loProcedimiento)
            End If

            Me.enabledGA = False
            MyBase.guardar()
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub frmProcedimientos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        sCboCalificacion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        sCboCalificacion.Properties.DisplayMember = "TgNombre"
        sCboCalificacion.Properties.ValueMember = "TgCodigo"
        sCboCalificacion.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(claseCalificacion)
        sCboCalificacion.ItemIndex = 0
    End Sub

    Private Sub btnAreaOrigen_Click(sender As System.Object, e As System.EventArgs) Handles btnAreaOrigen.Click
        If codInstitucion.Length > 0 Then
            Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(claseArea, codInstitucion)
                If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                    txtAreaInicio.EditValue = fmConsultaTablaGeneral.tgNombre
                    codAreaInicia = fmConsultaTablaGeneral.tgCodigo
                End If
            End Using
        End If
     
    End Sub

    Private Sub BtnAreaResuelve_Click(sender As System.Object, e As System.EventArgs) Handles BtnAreaResuelve.Click
        If codInstitucion.Length > 0 Then
            Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(claseArea, codInstitucionr)
                If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                    TxtAreaResuelve.EditValue = fmConsultaTablaGeneral.TgNombre
                    codAreaFin = fmConsultaTablaGeneral.TgCodigo
                End If
            End Using
        End If
    End Sub

    Private Sub btnInstitucion_Click(sender As System.Object, e As System.EventArgs) Handles btnInstitucion.Click
        Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(claseInstitucion)
            If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                txtinstitucion.EditValue = fmConsultaTablaGeneral.TgNombre
                codInstitucion = fmConsultaTablaGeneral.TgCodigo
            End If
        End Using
    End Sub

    Private Sub btnInstitucionR_Click(sender As System.Object, e As System.EventArgs) Handles btnInstitucionR.Click
        Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(claseInstitucion)
            If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                txtinstitucionr.EditValue = fmConsultaTablaGeneral.TgNombre
                codInstitucionr = fmConsultaTablaGeneral.TgCodigo
            End If
        End Using
    End Sub
End Class