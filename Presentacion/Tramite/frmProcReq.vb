Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Public Class frmProcReq
    Inherits frmMantenimientos
    Dim claseRequerimiento As Int16 = 92
    Dim claseReqVsProc As Int16 = 93
    Dim dtTablaGeneral As DataTable = New DataTable()
    Dim ListaTemporalTablaGeneralEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalTablaGeneralNuevos As List(Of EETablaGeneral) = Nothing
#Region "Construir Table"
    Private Sub ConstruirTable()
        dtTablaGeneral.Columns.Add("tgId", GetType(Integer))
        dtTablaGeneral.Columns.Add("procId", GetType(String))
        dtTablaGeneral.Columns.Add("reqId", GetType(String))
        dtTablaGeneral.Columns.Add("requisito", GetType(String))
        dtTablaGeneral.Columns.Add("nOrden", GetType(String))
        dtTablaGeneral.Columns.Add("tgActivo", GetType(Boolean))
        dtTablaGeneral.Columns.Add("tgDescripcion", GetType(String))
    End Sub
#End Region

    Protected Overrides Sub guardar()
        Try
            'Dim loTablaGeneral As EETablaGeneral = Nothing
            Dim loTablaGeneralSA As EETablaGeneral = New EETablaGeneral()
            'Dim loClase As EEClase = Nothing
            'Dim loClaseExtra As EEClase = Nothing

            'For Each fTablaGeneral As DataRow In dtTablaGeneral.Rows
            '    loTablaGeneral = New EETablaGeneral()
            '    loClase = New EEClase()
            '    loClaseExtra = New EEClase()

            'If loTablaGeneralSA.ListaTablaGeneral Is Nothing Then
            '    loTablaGeneralSA.ListaTablaGeneral = New List(Of EETablaGeneral)
            'End If
            '    loClase.ClsId = claseReqVsProc
            '    loTablaGeneral.TgId = fTablaGeneral("tgId")
            '    loTablaGeneral.TgCodigo = fTablaGeneral("nOrden")
            '    loTablaGeneral.TgActivo = fTablaGeneral("tgActivo")
            '    loTablaGeneral.TgExtra = fTablaGeneral("reqId") & fTablaGeneral("procId")
            '    loTablaGeneral.TgDescripcion = IIf(IsDBNull(fTablaGeneral("tgDescripcion")), Nothing, fTablaGeneral("tgDescripcion"))
            '    loTablaGeneral.OClase = loClase
            '    loTablaGeneralSA.ListaTablaGeneral.Add(loTablaGeneral)
            'Next

            loTablaGeneralSA.ListaTablaGeneralTemporalNuevos = ListaTemporalTablaGeneralNuevos
            loTablaGeneralSA.ListaTablaGeneralTemporalEliminados = ListaTemporalTablaGeneralEliminados
            MantenimientosBL.Instancia.tablageneralActualizar(loTablaGeneralSA)
            ListaTemporalTablaGeneralNuevos = Nothing
            ListaTemporalTablaGeneralEliminados = Nothing
            'dtTablaGeneral = Nothing
            Me.enabledGA = False
            MyBase.guardar()
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        TxtProcedimiento.Properties.ReadOnly = True
        btnProcedimiento.Enabled = False
        txtCodProc.Properties.ReadOnly = False
        txtCodProc.Enabled = False
        TxtRequisito.Properties.ReadOnly = True
        TxtCodReq.Properties.ReadOnly = False
        TxtCodReq.Enabled = False

    End Sub
    Protected Overrides Sub seleccionarListado()
        Try
            If lstResultados.SelectedItem IsNot Nothing Then
                limpiarControlesTotal(SaimtGroupBox2.Controls)
                Dim loProcedimiento As EEProcedimientoSTD = DirectCast(lstResultados.SelectedValue, EEProcedimientoSTD)
                If loProcedimiento IsNot Nothing Then
                    txtCodProc.EditValue = loProcedimiento.ProcId
                    TxtProcedimiento.EditValue = loProcedimiento.ProcNombre
                    Dim lTablaGeneral As List(Of EETablaGeneral)
                    lTablaGeneral = MantenimientosBL.Instancia.RequisitosListarxProcId(loProcedimiento.ProcId)
                    dtTablaGeneral.Clear()
                    If lTablaGeneral IsNot Nothing Then
                        For Each fTablaGeneral As EETablaGeneral In lTablaGeneral
                            dtTablaGeneral.LoadDataRow(New Object() {fTablaGeneral.TgId, fTablaGeneral.TgExtra.Substring(4, 4), _
                                  fTablaGeneral.TgExtra.Substring(0, 4), _
                                   fTablaGeneral.TgNombre, _
                                   fTablaGeneral.TgCodigo, _
                                   fTablaGeneral.TgActivo, _
                                   fTablaGeneral.TgDescripcion
                           }, True)
                        Next
                    End If
                End If
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub listar()
        Try
            lstResultados.DisplayMember = "ProcNombre"
            lstResultados.DataSource = MantenimientosBL.Instancia.procedimientostdListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            MyBase.listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub Buscar()
        Try
            lstResultados.DisplayMember = "ProcNombre"
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = sRdbBuscarPor.EditValue
            lstResultados.DataSource = MantenimientosBL.Instancia.procedimientostdListarCriterio(sRdbBuscarPor.EditValue, TxtBuscarPor.Text)
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub sbtnRequisito_Click(sender As System.Object, e As System.EventArgs) Handles sbtnRequisito.Click

        Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(claseRequerimiento)
            If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                TxtRequisito.EditValue = fmConsultaTablaGeneral.tgNombre
                TxtCodReq.EditValue = fmConsultaTablaGeneral.tgCodigo
            End If
        End Using

    End Sub

    Private Sub btnProcedimiento_Click(sender As System.Object, e As System.EventArgs) Handles btnProcedimiento.Click
        Using fmConsultaProcedimiento As frmConsultaProcedimiento = New frmConsultaProcedimiento()
            If fmConsultaProcedimiento.ShowDialog() = DialogResult.OK Then
                TxtProcedimiento.EditValue = fmConsultaProcedimiento.procNombre
                txtCodProc.EditValue = fmConsultaProcedimiento.procId
                TxtProcedimiento.Properties.ReadOnly = True
                txtCodProc.Properties.ReadOnly = True
            End If
        End Using
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If String.IsNullOrEmpty(TxtProcedimiento.EditValue) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Procedimiento")
            TxtProcedimiento.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(TxtRequisito.EditValue) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Requisito")
            TxtRequisito.Focus()
            Exit Sub
        End If

        If ssNroOrden.EditValue = 0 Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro de Orden del Requisito")
            ssNroOrden.Focus()
            Exit Sub
        End If

        For Each fTablaGeneral As DataRow In dtTablaGeneral.Rows
            If CInt(ssNroOrden.EditValue) = CInt(fTablaGeneral("nOrden")) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("ya se encuentra ingresado el Nro de Orden del Requisito")
                ssNroOrden.Focus()
                Return
            End If
        Next

        dtTablaGeneral.LoadDataRow(New Object() {0, _
        txtCodProc.EditValue, _
        TxtCodReq.EditValue, _
          TxtRequisito.EditValue, _
        ssNroOrden.EditValue, _
          chkActivo.EditValue, _
    TxtObservacion.EditValue
        }, True)

        If ListaTemporalTablaGeneralNuevos Is Nothing Then
            ListaTemporalTablaGeneralNuevos = New List(Of EETablaGeneral)
        End If

        Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
        Dim loClase As EEClase = New EEClase()
        loClase.ClsId = claseReqVsProc
        loTablaGeneral.TgCodigo = ssNroOrden.EditValue
        loTablaGeneral.TgActivo = chkActivo.Checked
        loTablaGeneral.TgExtra = TxtCodReq.EditValue & txtCodProc.EditValue
        loTablaGeneral.TgDescripcion = TxtObservacion.EditValue
        loTablaGeneral.OClase = loClase
        ListaTemporalTablaGeneralNuevos.Add(loTablaGeneral)
        ssNroOrden.EditValue = CInt(ssNroOrden.EditValue) + 1
        chkActivo.Checked = True
        TxtCodReq.EditValue = Nothing
        TxtRequisito.EditValue = Nothing
        TxtObservacion.EditValue = Nothing
    End Sub

    Private Sub btnRemover_Click(sender As System.Object, e As System.EventArgs) Handles btnRemover.Click
        If Me.gvReqvsProc.DataRowCount <> 0 Then

            If dtTablaGeneral.Rows(Me.gvReqvsProc.GetSelectedRows(0))("tgId").ToString() > 0 Then
                If ListaTemporalTablaGeneralEliminados Is Nothing Then
                    ListaTemporalTablaGeneralEliminados = New List(Of String)
                End If
                ListaTemporalTablaGeneralEliminados.Add(dtTablaGeneral.Rows(Me.gvReqvsProc.GetSelectedRows(0))("tgId").ToString())

            End If

            If ListaTemporalTablaGeneralNuevos IsNot Nothing Then

                If ListaTemporalTablaGeneralNuevos.Count > 0 Then
                    Dim liIndiceNuevoModificar As Int16 = 0
                    Dim liFila As Int16 = -1

                    For Each fTablaGeneral As DataRow In dtTablaGeneral.Rows
                        If String.IsNullOrEmpty(fTablaGeneral("tgId")) And Me.gvReqvsProc.FocusedRowHandle = liFila Then
                            liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                        End If
                        liFila = liFila + 1
                    Next
                    ListaTemporalTablaGeneralNuevos.RemoveAt(liIndiceNuevoModificar)
                End If
            End If

            dtTablaGeneral.Rows.RemoveAt(Me.gvReqvsProc.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub frmProcReq_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        ConstruirTable()
        dgvReqvsProc.DataSource = dtTablaGeneral
    End Sub
End Class