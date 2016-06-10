﻿Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Public Class frmReporteDocumentos
    Dim dtMovimiento As DataTable = New DataTable("DTMovimientos")
    Dim lMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
    Dim lpersonas As List(Of EEPersona) = Nothing
    Dim listaaños As List(Of EETablaGeneral) = Nothing
    Dim VDocID As String
    Dim VDocNRegT As String
#Region "ConstruirTablas"
    Private Sub ConstruirTablaMovimientos()
        dtMovimiento.Columns.Add("origen", GetType(String))
        dtMovimiento.Columns.Add("cargoOrigen", GetType(String))
        dtMovimiento.Columns.Add("destino", GetType(String))
        dtMovimiento.Columns.Add("cargoDestino", GetType(String))
        dtMovimiento.Columns.Add("diasTenencia", GetType(String))
        dtMovimiento.Columns.Add("fechaRecepcion", GetType(String))
        dtMovimiento.Columns.Add("estadoTramite", GetType(String))
        dtMovimiento.Columns.Add("fechaEnvio", GetType(String))
        dtMovimiento.Columns.Add("diasProcedimiento", GetType(String))
        dtMovimiento.Columns.Add("comentarioenvio", GetType(String))
        dtMovimiento.Columns.Add("docid", GetType(String))
        dtMovimiento.Columns.Add("docnreg", GetType(String))
        dtMovimiento.Columns.Add("mes", GetType(String))
        dtMovimiento.Columns.Add("accion", GetType(String))
    End Sub
#End Region


    Private Sub btnMostrarDatos_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrarDatos.Click
        btnMostrarDatos.Enabled = False
        mpbprogreso.Caption = "Cargando Datos para visualizar..."
        bsiMensaje.Caption = String.Empty
        Application.DoEvents()
        mpbprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Application.DoEvents()
        dtMovimiento.Clear()
        If lMovimientoSTD IsNot Nothing Then
            lMovimientoSTD = New List(Of EEMovimientoSTD)
        End If
        Application.DoEvents()
        Select Case cbopciones.SelectedIndex
            Case 0
                lMovimientoSTD = MantenimientosBL.Instancia.movimientoSTDPivotear(Nothing, 0, cmbaños.EditValue)
            Case 1
                lMovimientoSTD = MantenimientosBL.Instancia.movimientoSTDPivotear(Trim(txtregistro.Text), 1, cmbaños.EditValue)
            Case 2
                lMovimientoSTD = MantenimientosBL.Instancia.movimientoSTDPivotear(Trim(txtregistro.Text), 2, cmbaños.EditValue)
            Case 3
                lMovimientoSTD = MantenimientosBL.Instancia.movimientoSTDPivotear(Trim(txtregistro.Tag), 3, cmbaños.EditValue)
            Case 4
                lMovimientoSTD = MantenimientosBL.Instancia.movimientoSTDPivotear(Trim(txtregistro.Tag), 4, cmbaños.EditValue)
            Case 5
                lMovimientoSTD = MantenimientosBL.Instancia.movimientoSTDPivotear(Nothing, 5, cmbaños.EditValue)
            Case 6
                lMovimientoSTD = MantenimientosBL.Instancia.movimientoSTDPivotear(Nothing, 6, cmbaños.EditValue)
            Case 7
                lMovimientoSTD = MantenimientosBL.Instancia.movimientoSTDPivotear(Trim(txtregistro.Tag) & sCboArea.EditValue, 7, cmbaños.EditValue)
        End Select
        Application.DoEvents()
        pgprogreso.Caption = "Cargando Datos para visualizar..."
        mpbprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        pgprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        riprogreso.Minimum = 0
        pgprogreso.EditValue = 0
        If Not lMovimientoSTD Is Nothing Then
            riprogreso.Maximum = lMovimientoSTD.Count - 1
            Application.DoEvents()
            pgprogreso.Caption = "Cargando Datos..."
            Dim PerNombreCompleto As String = String.Empty
            For Each fmovimiento As EEMovimientoSTD In lMovimientoSTD
                If lpersonas IsNot Nothing Then
                    For Each orow As EEPersona In lpersonas
                        If orow.PerId = fmovimiento.MovPara Then
                            PerNombreCompleto = orow.PerNombreCompleto
                            Exit For
                        End If
                    Next
                End If
                dtMovimiento.LoadDataRow(New Object() {fmovimiento.ODocumento.perNombreOrigen, _
                                                  fmovimiento.OJerarquia.CargoOrigen, _
                                                  PerNombreCompleto, _
                                                  fmovimiento.OJerarquia.CargoDestino, _
                fmovimiento.movDiasTenencia, _
                fmovimiento.MovFechaRec, _
                fmovimiento.TgEstadoMov, _
                fmovimiento.MovFechaEnv, _
                fmovimiento.DiasProcedimiento, _
                fmovimiento.movComentario, _
                fmovimiento.docId, _
                fmovimiento.ODocumento.DocNReg, _
                String.Format("{0} - {1}/{2}", fmovimiento.Mes, EEComun.NumMeses(fmovimiento.Mes), fmovimiento.MovFechaEnv.Value.Year), _
                fmovimiento.TgTDestinoExtra
                                         }, True)
                pgprogreso.EditValue = pgprogreso.EditValue + 1
                Application.DoEvents()
                pgprogreso.Caption = String.Format("Cargando Datos...({0})", Format(pgprogreso.EditValue / riprogreso.Maximum, "0%"))
            Next
            gcresultado.DataSource = dtMovimiento
            gvresultado.BestFitColumns()
            gvresultado.ExpandAllGroups()
        Else
            bsiMensaje.Caption = "No se encontro ninguna coincidencia en la busqueda requerida."
        End If
        btnMostrarDatos.Enabled = True
        pgprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub frmReporteDocumentos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTablaMovimientos()
        listaaños = MantenimientosBL.Instancia.tablageneralListarXClsId(76)
        lpersonas = MantenimientosBL.Instancia.personaListarXCargoId(Nothing)
        cmbaños.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cmbaños.Properties.DisplayMember = "TgNombre"
        cmbaños.Properties.ValueMember = "TgCodigo"
        cmbaños.Properties.DataSource = listaaños
        cmbaños.ItemIndex = (listaaños.Count - 1)

    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarExcel.Click
        Try
            sfdExportar.Filter = "Archivos de Excel|.xls"
            If sfdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
                gvresultado.ExportToXls(sfdExportar.FileName)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub


    Private Sub cbopciones_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbopciones.SelectedIndexChanged
        If cbopciones.SelectedIndex = 3 Or cbopciones.SelectedIndex = 4 Or cbopciones.SelectedIndex = 7 Then
            btnbuscar.Enabled = True
            txtregistro.Properties.ReadOnly = True
        Else
            btnbuscar.Enabled = False
            txtregistro.Properties.ReadOnly = False
            txtregistro.Text = String.Empty
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscar.Click
        If cbopciones.SelectedIndex = 3 Then
            Dim frm As frmConsultaPersonaGeneral = New frmConsultaPersonaGeneral(3)
            If frm.ShowDialog Then
                txtregistro.Text = frm.PerNombre
                txtregistro.Tag = frm.PerId
            End If
        ElseIf cbopciones.SelectedIndex = 4 Or cbopciones.SelectedIndex = 7 Then
            Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(82)
                If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                    txtregistro.Text = fmConsultaTablaGeneral.TgNombre
                    txtregistro.Tag = fmConsultaTablaGeneral.TgCodigo
                    If cbopciones.SelectedIndex = 7 Then
                        sCboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                        sCboArea.Properties.DisplayMember = "TgNombre"
                        sCboArea.Properties.ValueMember = "TgCodigo"
                        sCboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, fmConsultaTablaGeneral.TgCodigo)
                        sCboArea.ItemIndex = 0
                        sCboArea.Properties.ReadOnly = False
                    Else
                        sCboArea.Properties.ReadOnly = True
                    End If
                End If
            End Using
        End If
    End Sub

    Private Sub VerFormulario_Click(sender As System.Object, e As System.EventArgs) Handles VerFormulario.Click

        If Me.gvresultado.DataRowCount <> 0 Then

            If Not gvresultado.GetFocusedRowCellValue("docid") Is Nothing Then
                VDocID = gvresultado.GetFocusedRowCellValue("docid").ToString
                Dim fmVisorDocumento As frmVisorDocumento = New frmVisorDocumento(VDocID)
                fmVisorDocumento.ShowDialog()
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("Tiene que seleccionar cualquier fila de los movimientos")
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No hay ningun documento para mostrar en el formulario")
        End If
    End Sub
End Class