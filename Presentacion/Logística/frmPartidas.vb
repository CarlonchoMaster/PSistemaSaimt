Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Imports System.IO
Public Class frmPartidas
    Dim dtPartida As DataTable = New DataTable

    Private Sub ConstruirTablePartida()
        dtPartida.Columns.Add("partId", GetType(String))
        dtPartida.Columns.Add("partAño", GetType(String))
        dtPartida.Columns.Add("tgPartTipoId", GetType(String))
        dtPartida.Columns.Add("partNombre", GetType(String))
        dtPartida.Columns.Add("tgPartEstId", GetType(Boolean))
        dtPartida.Columns.Add("partDocRef", GetType(String))
    End Sub

#Region "Funciones Sobrescritas"

    Protected Overrides Sub guardar()
        Try
            Dim loPartida As EEPartida = New EEPartida()

            loPartida.PartId = txtPartId.EditValue
            loPartida.PartAño = cboAnio.EditValue
            loPartida.TgPartTipoId = cboTipoPartida.EditValue
            loPartida.PartNombre = txtPartNombre.Text
            loPartida.TgPartEstId = chkHabilitado.Checked
            loPartida.PartDocRef = txtDocRef.EditValue

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.partidaGuardar(loPartida)
            Else
                MantenimientosBL.Instancia.partidaActualizar(loPartida)
            End If
            Me.enabledGA = False
            MyBase.guardar()
            btnNuevoDetalle.Enabled = False
            btnEditarDetalle.Enabled = False
            btnGuardarDetalle.Enabled = False
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cbBuscarPor.SelectedIndex
            Dim loPartida As List(Of EEPartida)
            loPartida = MantenimientosBL.Instancia.partidaListarCriterio(cboAños.EditValue, cbBuscarPor.SelectedIndex, txtBuscarPor.Text)
            dtPartida.Clear()

            If loPartida IsNot Nothing Then
                For Each frow As EEPartida In loPartida
                    dtPartida.LoadDataRow(New Object() {frow.PartId, _
                                                        frow.PartAño, _
                                                        frow.TgPartTipoId.TrimEnd, _
                                                        frow.PartNombre, _
                                                        frow.TgPartEstId, _
                                                        frow.PartDocRef}, True)
                Next
                gvResultados.BestFitColumns()
                gvResultados.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvResultados.DataRowCount <> 0 Then
                Dim loPartida As List(Of EEPartida) = MantenimientosBL.Instancia.partidaListarCriterio(cboAños.EditValue, cbBuscarPor.SelectedIndex, txtBuscarPor.Text)
                
                txtPartId.Text = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "partId").ToString()
                cboAnio.EditValue = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "partAño").ToString()
                txtPartNombre.EditValue = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "partNombre").ToString()
                cboTipoPartida.EditValue = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "tgPartTipoId").ToString()
                chkHabilitado.Checked = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "tgPartEstId").ToString()
                txtDocRef.Text = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "partDocRef").ToString()
            End If
            MyBase.seleccionarListado()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Editar()
        MyBase.editar()
        txtPartId.Properties.ReadOnly = True
    End Sub
    Protected Overrides Sub limpiar()
        MyBase.limpiar()
    End Sub

    Protected Overrides Sub cancelar()
        MyBase.cancelar()
    End Sub

    Protected Overrides Sub Nuevo()
        cboAños.EditValue = 5
        MyBase.nuevo()
    End Sub

    Protected Overrides Sub eliminar()
        Try
            MantenimientosBL.Instancia.partidaEliminar(GIdRegistroActual)
            MyBase.eliminar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
#End Region


    Private Sub frmPartidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeConfirmar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeImprimir = True
        ConstruirTablePartida()
        dgvResultados.DataSource = dtPartida

        cboTipoPartida.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoPartida.Properties.DisplayMember = "TgNombre"
        cboTipoPartida.Properties.ValueMember = "TgCodigo"
        cboTipoPartida.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(19)
        cboTipoPartida.ItemIndex = 0

        cboAnio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAnio.Properties.DisplayMember = "TgNombre"
        cboAnio.Properties.ValueMember = "TgCodigo"
        cboAnio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(76)
        cboAnio.ItemIndex = 5

        cboAños.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAños.Properties.DisplayMember = "TgNombre"
        cboAños.Properties.ValueMember = "TgCodigo"
        cboAños.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(76)
        cboAños.ItemIndex = 5
    End Sub
End Class