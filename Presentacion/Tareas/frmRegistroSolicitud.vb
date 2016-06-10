
Imports ReglasNegocio
Imports SaimtControles
Imports Entidades

Public Class frmRegistroSolicitud
    Inherits frmMantenimientos
    Dim dtTablaSolicitud As New DataTable
    Dim dtTablaProcedimientos As New DataTable
#Region "Funciones Sobrescritas"

    Private Sub ConstruirTable_Solicitudes()
        dtTablaSolicitud.Columns.Add("solId", GetType(String))
        dtTablaSolicitud.Columns.Add("solNombre", GetType(String))
        dtTablaSolicitud.Columns.Add("solDescripcion", GetType(String))
        dtTablaSolicitud.Columns.Add("solActivo", GetType(Boolean))
        dtTablaSolicitud.Columns.Add("subProcId", GetType(String))
    End Sub

    Private Sub ConstruirTable()
        dtTablaProcedimientos.Columns.Add("procdId", GetType(String))
        dtTablaProcedimientos.Columns.Add("procdNombre", GetType(String))
        dtTablaProcedimientos.Columns.Add("procdDescripcion", GetType(String))
        dtTablaProcedimientos.Columns.Add("procdMaxDia", GetType(String))
        dtTablaProcedimientos.Columns.Add("tgArea", GetType(String))
        dtTablaProcedimientos.Columns.Add("tgCargo", GetType(String))
        dtTablaProcedimientos.Columns.Add("subProcId", GetType(String))

    End Sub

    Protected Overrides Sub guardar()
        Try

            If String.IsNullOrEmpty(cboProceso.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Proceso")
                cboProceso.Focus()
                Return
            End If
            If String.IsNullOrEmpty(cboSubProceso.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Proceso")
                cboSubProceso.Focus()
                Return
            End If
            If String.IsNullOrEmpty(txtSolId.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El codigo de la Solicitud no se ha Generado")
                txtSolId.Focus()
                Return
            End If

            If String.IsNullOrEmpty(txtSolNombre.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nombre de la Solicitud")
                txtSolNombre.Focus()
                Return
            End If

            If String.IsNullOrEmpty(txtSolDescripcion.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("La Descripcion de la Solicitud es necesaria")
                txtSolDescripcion.Focus()
                Return
            End If

            Dim loSolicitudes As EESolicitudes = New EESolicitudes() With {.SolId = txtSolId.Text,
                                                                 .SubProcId = cboSubProceso.EditValue,
                                                                 .SolNombre = txtSolNombre.Text,
                                                                 .SolDescripcion = txtSolDescripcion.Text,
                                                                 .SolActivo = chkSolActivo.Checked,
                                                                 .SolDocRef = txtSolDocRef.EditValue,
                                                                 .SolFecha = dtpSolFecha.EditValue,
                                                                 .PerId = EEComun._PerId,
                                                                 .procdId = IIf(chkDesde.Checked = True, cboProcedimientoDesde.EditValue, Nothing)}

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.solicitudesGuardar(loSolicitudes)
            Else
                MantenimientosBL.Instancia.solicitudesActualizar(loSolicitudes)
            End If
            Me.enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtSolId.Text = MantenimientosBL.Instancia.solicitudesNewCodigo()
        txtSolId.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub Buscar()
        Try
            dtTablaSolicitud.Rows.Clear()
            GValorTextoBuscado = txtBuscar.Text
            GCriterioBuscado = cbBuscarPor.SelectedIndex

            Dim ListaSolicitudes As List(Of EESolicitudes) = MantenimientosBL.Instancia.solicitudesListarXCriterios(GCriterioBuscado, GValorTextoBuscado)
            If ListaSolicitudes IsNot Nothing Then
                For Each frow As EESolicitudes In ListaSolicitudes
                    dtTablaSolicitud.LoadDataRow(New Object() {frow.SolId,
                                                              frow.SolNombre,
                                                              frow.SolDescripcion,
                                                              frow.SolActivo,
                                                              frow.SubProcId}, True)
                Next
                gvListado.BestFitColumns()
                gvListado.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvListado.DataRowCount <> 0 Then

                txtSolId.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "solId").ToString()
                GIdRegistroActual = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "solId").ToString()
                txtSolNombre.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "solNombre").ToString()
                txtSolDescripcion.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "solDescripcion").ToString()
                chkSolActivo.Checked = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "solActivo").ToString()
                cboProceso.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "subProcId").ToString().Substring(0, 4)
                cboSubProceso.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "subProcId").ToString()


                Dim loSolicitudes As EESolicitudes = Nothing
                loSolicitudes = MantenimientosBL.Instancia.solicitudesMostrarXSolId_SubProcId(txtSolId.EditValue, cboSubProceso.EditValue)
                If loSolicitudes IsNot Nothing Then
                    txtSolDocRef.Text = loSolicitudes.SolDocRef
                    dtpSolFecha.Text = loSolicitudes.SolFecha
                    chkDesde.Checked = IIf(Len(loSolicitudes.procdId) > 0, True, False)
                    cboProcedimientoDesde.EditValue = loSolicitudes.procdId

                    'cboProceso.EditValue = loSolicitudes.
                    ' cboSubProceso.EditValue = loSolicitudes.SubProcId
                End If
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub



    Protected Overrides Sub Editar()
        MyBase.editar()
        txtSolId.Properties.ReadOnly = True
    End Sub
#End Region


    Private Sub frmManProcesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PuedeBuscar = True
        PuedeCrear = True
        PuedeImprimir = True
        PuedeEditar = True
        ConstruirTable()
        dgvProcedimientos.DataSource = dtTablaProcedimientos
        ConstruirTable_Solicitudes()
        dgvListadoRegSol.DataSource = dtTablaSolicitud
        cboProceso.mColumnas(SaimtComboBoxLookUp.Entidades.Procesos)
        cboProceso.Properties.DisplayMember = "ProcNombre"
        cboProceso.Properties.ValueMember = "ProcId"
        cboProceso.Properties.DataSource = MantenimientosBL.Instancia.procesosListarActivos()
        cboProceso.ItemIndex = 0
    End Sub


    Private Sub cboProceso_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProceso.EditValueChanged
        If cboProceso.EditValue IsNot Nothing Then
            cboSubProceso.mColumnas(SaimtComboBoxLookUp.Entidades.SubProcesos)
            cboSubProceso.Properties.DisplayMember = "SubProcNombre"
            cboSubProceso.Properties.ValueMember = "SubProcId"
            cboSubProceso.Properties.DataSource = MantenimientosBL.Instancia.subprocesosXProcId(cboProceso.EditValue)
            cboSubProceso.ItemIndex = 0
        End If
    End Sub

    Private Sub cboSubProceso_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubProceso.EditValueChanged
        If cboSubProceso.EditValue IsNot Nothing Then
            Dim ListarProcedimientos As List(Of EEProcedimientos) = MantenimientosBL.Instancia.procedimientosListarXSubProcId(cboSubProceso.EditValue)
            cboProcedimientoDesde.mColumnas(SaimtComboBoxLookUp.Entidades.Procedientos)
            cboProcedimientoDesde.Properties.DisplayMember = "ProcdNombre"
            cboProcedimientoDesde.Properties.ValueMember = "ProcdId"
            cboProcedimientoDesde.Properties.DataSource = ListarProcedimientos
            cboProcedimientoDesde.ItemIndex = 0

            If ListarProcedimientos IsNot Nothing Then
                For Each loProcedimiento As EEProcedimientos In ListarProcedimientos
                    dtTablaProcedimientos.LoadDataRow(New Object() {loProcedimiento.ProcdId, _
                   loProcedimiento.ProcdNombre, _
                  loProcedimiento.ProcdDescripcion, _
                 loProcedimiento.ProcdMaxDia, _
                  loProcedimiento.TgArea, _
                  loProcedimiento.TgCargo, _
                  loProcedimiento.SubProcId
              }, True)
                Next
            End If
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDesde.CheckedChanged
        cboProcedimientoDesde.Properties.ReadOnly = Not chkDesde.Checked
    End Sub
End Class