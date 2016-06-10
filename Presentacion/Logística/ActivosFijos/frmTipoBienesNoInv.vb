Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmTipoBienesNoInv

    Dim dtTablaGeneral As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtTablaGeneral.Columns.Add("tgId", GetType(Int32))
        dtTablaGeneral.Columns.Add("tgCodigo", GetType(String))
        dtTablaGeneral.Columns.Add("tgNombre", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvTipoBienesNoInventariados.DataRowCount <> 0 Then
                Dim loTablaGeneral As EETablaGeneral = MantenimientosBL.Instancia.tablageneralListarXTgId(Convert.ToInt32(gvTipoBienesNoInventariados.GetRowCellValue(Me.gvTipoBienesNoInventariados.GetSelectedRows(0), "tgId").ToString()))
                GIndiceSeleccionado = Me.gvTipoBienesNoInventariados.GetSelectedRows(0)
                txtCodigo.Text = loTablaGeneral.TgCodigo
                txtNombre.Text = loTablaGeneral.TgNombre
                txtSiglas.Text = loTablaGeneral.TgAbrev
                chkActivo.Checked = loTablaGeneral.TgActivo

                GIdRegistroActual = loTablaGeneral.TgId
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            dtTablaGeneral.Rows.Clear()
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterioPor.SelectedIndex
            Dim ListaTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdCriterios(153, GCriterioBuscado, GValorTextoBuscado)
            If ListaTablaGeneral IsNot Nothing Then
                For Each fTablaGeneral As EETablaGeneral In ListaTablaGeneral
                    dtTablaGeneral.LoadDataRow(New Object() {fTablaGeneral.TgId, _
                         fTablaGeneral.TgCodigo, _
                         fTablaGeneral.TgNombre
                       }, True)
                Next
                gvTipoBienesNoInventariados.BestFitColumns()
                gvTipoBienesNoInventariados.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub listar()
        Try
            dtTablaGeneral.Rows.Clear()
            For Each fTablaGeneral As EETablaGeneral In MantenimientosBL.Instancia.tablageneralListarXClsIdCriterios(153, GCriterioBuscado, GValorTextoBuscado)
                dtTablaGeneral.LoadDataRow(New Object() {fTablaGeneral.TgId, _
                     fTablaGeneral.TgCodigo, _
                     fTablaGeneral.TgNombre
                   }, True)
            Next
            MyBase.listar()
            gvTipoBienesNoInventariados.BestFitColumns()
            Me.gvTipoBienesNoInventariados.FocusedRowHandle = GIndiceSeleccionado
            dgvListado_Click(Nothing, Nothing)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
            loTablaGeneral.OClase = New EEClase()
            loTablaGeneral.OClase.ClsId = 153
            loTablaGeneral.TgCodigo = txtCodigo.Text
            loTablaGeneral.TgNombre = txtNombre.Text
            loTablaGeneral.TgAbrev = txtSiglas.Text
            loTablaGeneral.TgActivo = chkActivo.Checked
            loTablaGeneral.TgId = GIdRegistroActual

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.tablaGeneralInsertarXClsId_TgCodigoAutoGenerado(loTablaGeneral)
            Else
                MantenimientosBL.Instancia.tablageneralUpdate(loTablaGeneral)
            End If
            Me.enabledGA = False
            MyBase.guardar()
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtCodigo.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        txtCodigo.Properties.ReadOnly = True
    End Sub
#End Region

    Private Sub frmTipoBienesNoInv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvListadoTipoBienesNoInventariados.DataSource = dtTablaGeneral
    End Sub

    Private Sub gvTipoBienesNoInventariados_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvTipoBienesNoInventariados.CustomRowCellEditForEditing
        seleccionarListado()
    End Sub

    Private Sub cboCriterioPor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCriterioPor.SelectedIndexChanged
        If cboCriterioPor.SelectedIndex = 2 Then
            txtBuscarSaimt.Text = String.Empty
            txtBuscarPor.Properties.ReadOnly = True
            GCriterioBuscado = 2
            listar()
        Else
            txtBuscarPor.Properties.ReadOnly = False
            dtTablaGeneral.Clear()
            limpiarControlesTotal(Me.Controls)
        End If
    End Sub
End Class