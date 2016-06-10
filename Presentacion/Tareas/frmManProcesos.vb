﻿
Imports ReglasNegocio
Imports SaimtControles
Imports Entidades

Public Class frmManProcesos
    Inherits frmMantenimientos
    Dim dtTablaProcesos As New DataTable
#Region "Funciones Sobrescritas"

    Private Sub ConstruirTable()
        dtTablaProcesos.Columns.Add("procId", GetType(String))
        dtTablaProcesos.Columns.Add("procNombre", GetType(String))
        dtTablaProcesos.Columns.Add("procDescripcion", GetType(String))
        dtTablaProcesos.Columns.Add("procActivo", GetType(Boolean))
    End Sub

    Protected Overrides Sub guardar()
        Try

            If String.IsNullOrEmpty(txtProcId.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El codigo del Proceso no se ha Generado")
                txtProcId.Focus()
                Return
            End If

            If String.IsNullOrEmpty(txtProcNombre.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nombre del Proceso")
                txtProcNombre.Focus()
                Return
            End If

            If String.IsNullOrEmpty(txtProcDescripcion.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("La Descripcion del Proceso es necesaria")
                txtProcDescripcion.Focus()
                Return
            End If

            Dim loProceso As EEProcesos = New EEProcesos() With {.ProcId = txtProcId.Text,
                                                                 .ProcNombre = txtProcNombre.Text,
                                                                 .ProcDescripcion = txtProcDescripcion.Text,
                                                                 .ProcActivo = chkProcActivo.Checked}


            If GEstadoNuevo Then
                MantenimientosBL.Instancia.procesosGuardar(loProceso)
            Else
                MantenimientosBL.Instancia.procesosActualizar(loProceso)
            End If
            Me.enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtProcId.Text = MantenimientosBL.Instancia.procesosNewCodigo()
        txtProcId.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub Buscar()
        Try
            dtTablaProcesos.Rows.Clear()
            GValorTextoBuscado = txtBuscar.Text
            GCriterioBuscado = cbBuscarPor.SelectedIndex

            Dim ListaProcesos As List(Of EEProcesos) = MantenimientosBL.Instancia.procesosListarXCriterios(GCriterioBuscado, GValorTextoBuscado)
            If ListaProcesos IsNot Nothing Then
                For Each frow As EEProcesos In ListaProcesos
                    dtTablaProcesos.LoadDataRow(New Object() {frow.ProcId, frow.ProcNombre, frow.ProcDescripcion, frow.ProcActivo}, True)
                Next
                gvProcesos.BestFitColumns()
                gvProcesos.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvProcesos.DataRowCount <> 0 Then

                txtProcId.EditValue = gvProcesos.GetRowCellValue(Me.gvProcesos.GetSelectedRows(0), "procId").ToString()
                GIdRegistroActual = gvProcesos.GetRowCellValue(Me.gvProcesos.GetSelectedRows(0), "procId").ToString()
                txtProcNombre.EditValue = gvProcesos.GetRowCellValue(Me.gvProcesos.GetSelectedRows(0), "procNombre").ToString()
                txtProcDescripcion.EditValue = gvProcesos.GetRowCellValue(Me.gvProcesos.GetSelectedRows(0), "procDescripcion").ToString()
                chkProcActivo.Checked = gvProcesos.GetRowCellValue(Me.gvProcesos.GetSelectedRows(0), "procActivo").ToString()
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    

    Protected Overrides Sub Editar()
        MyBase.editar()
        txtProcId.Properties.ReadOnly = True
    End Sub
#End Region


    Private Sub frmManProcesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PuedeBuscar = True
        PuedeCrear = True
        PuedeImprimir = True
        PuedeEditar = True
        ConstruirTable()
        dgvProcesos.DataSource = dtTablaProcesos
    End Sub


End Class