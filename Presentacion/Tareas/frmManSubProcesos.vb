﻿
Imports ReglasNegocio
Imports SaimtControles
Imports Entidades

Public Class frmManSubProcesos
    Inherits frmMantenimientos
    Dim dtTablaProcesos As New DataTable
    Dim dtTablaSubProcesos As New DataTable
    Dim ListaTemporalEliminados As List(Of String) = New List(Of String)
    ' Dim ListaTemporalNuevos As List(Of EESubProcesos) = Nothing
#Region "Funciones Sobrescritas"

    Private Sub ConstruirTable()
        dtTablaProcesos.Columns.Add("procId", GetType(String))
        dtTablaProcesos.Columns.Add("procNombre", GetType(String))
    End Sub

    Private Sub ConstruirTableDetalle()
        dtTablaSubProcesos.Columns.Add("procId", GetType(String))
        dtTablaSubProcesos.Columns.Add("subProcId", GetType(String))
        dtTablaSubProcesos.Columns.Add("subProcNombre", GetType(String))
        dtTablaSubProcesos.Columns.Add("subProcDescripcion", GetType(String))
        dtTablaSubProcesos.Columns.Add("subProcActivo", GetType(Boolean))
        ' dtTablaSubProcesos.Columns.Add("editar", GetType(String))
    End Sub

    Protected Overrides Sub guardar()
        Try

            If String.IsNullOrEmpty(txtProcNombre.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Proceso no se ha seleccionado")
                'txtProcId.Focus()
                Return
            End If
 
            Dim ListaSubProcesos As List(Of EESubProcesos) = Nothing
            Dim loProceso As EESubProcesos = Nothing
            For Each row As DataRow In dtTablaSubProcesos.Rows
                If ListaSubProcesos Is Nothing Then
                    ListaSubProcesos = New List(Of EESubProcesos)
                End If
                loProceso = New EESubProcesos() With {.ProcId = txtProcNombre.Tag,
                                                    .SubProcId = row("subProcId").ToString,
                                                      .SubProcNombre = row("subProcNombre").ToString,
                                                    .SubProcDescripcion = row("subProcDescripcion").ToString,
                                                    .SubProcActivo = row("subProcActivo").ToString
                                                  }
                ListaSubProcesos.Add(loProceso)
            Next
        
            MantenimientosBL.Instancia.subprocesosInsertarU(ListaSubProcesos)

            Me.enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        'txtProcId.Text = MantenimientosBL.Instancia.procesosNewCodigo()
        'txtProcId.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub Buscar()
        Try
            dtTablaProcesos.Rows.Clear()
            GValorTextoBuscado = txtBuscar.Text
            GCriterioBuscado = cbBuscarPor.SelectedIndex
            Dim ListaProcesos As List(Of EEProcesos) = MantenimientosBL.Instancia.procesosListarXCriterios(GCriterioBuscado, GValorTextoBuscado)
            If ListaProcesos IsNot Nothing Then
                For Each frow As EEProcesos In ListaProcesos
                    dtTablaProcesos.LoadDataRow(New Object() {frow.ProcId, frow.ProcNombre}, True)
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

                txtProcNombre.Tag = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "procId").ToString()
                txtProcNombre.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "procNombre").ToString()
                dtTablaSubProcesos.Rows.Clear()
                Dim ListaSubProcesos As List(Of EESubProcesos) = Nothing
                ListaSubProcesos = MantenimientosBL.Instancia.subprocesosXProcId(txtProcNombre.Tag)
                If ListaSubProcesos IsNot Nothing Then
                    For Each frow As EESubProcesos In ListaSubProcesos
                        dtTablaSubProcesos.LoadDataRow(New Object() {frow.ProcId, frow.SubProcId, frow.SubProcNombre, frow.SubProcDescripcion, frow.SubProcActivo}, True)
                    Next
                    gvListado.BestFitColumns()
                    ' gvListado.SelectRow(0)
                    ' dgvListado_Click(Nothing, Nothing)
                End If
                MyBase.seleccionarListado()

                Editar()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub



    Protected Overrides Sub Editar()
        MyBase.editar()
        txtProcNombre.Properties.ReadOnly = True
    End Sub
#End Region


    Private Sub frmManProcesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PuedeBuscar = True
        PuedeCrear = True
        PuedeImprimir = True
        PuedeEditar = True
        ConstruirTable()
        dgvListadosubProc.DataSource = dtTablaProcesos
        ConstruirTableDetalle()
        dgvSubProcesos.DataSource = dtTablaSubProcesos
    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If String.IsNullOrEmpty(txtSubProcNombre.Text) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Nombre del Subproceso")
            txtSubProcNombre.Focus()
            Exit Sub
        End If

        For Each row As DataRow In dtTablaSubProcesos.Rows
            If row("subProcNombre") = txtSubProcNombre.Text Then
                SaimtMessageBox.mostrarAlertaInformativa("Ya se encuentra agregado " & txtSubProcNombre.Text)
                Exit Sub
            End If
        Next

        dtTablaSubProcesos.LoadDataRow(New Object() {txtProcNombre.Tag, _
            IIf(Len(txtSubProcNombre.Tag) = 0, 0, txtSubProcNombre.Tag), _
            txtSubProcNombre.Text, _
            txtSubProcDescripcion.Text, _
            chkSubProcActivo.Checked
        }, True)

        'If ListaTemporalNuevos Is Nothing Then
        '    ListaTemporalNuevos = New List(Of EESubProcesos)
        'End If

        'Dim loSubProcesos As EESubProcesos = New EESubProcesos()
        'loSubProcesos.SubProcId = 0
        'loSubProcesos.SubProcNombre = txtSubProcNombre.Text
        'loSubProcesos.SubProcDescripcion = txtSubProcDescripcion.Text
        'loSubProcesos.SubProcActivo = chkSubProcActivo.Checked
        'c.Add(loSubProcesos)
    End Sub

   
    Private Sub gvSubProcesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvSubProcesos.Click
        'If  = 0 Then
        '    '' Process 1st column click
        'ElseIf e.Column.AbsoluteIndex = 1 Then
        '    '' Process 2nd column click
        'End If
    End Sub

    Private Sub btnElimEditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimEditor.Click
        If Me.gvSubProcesos.DataRowCount <> 0 Then
            txtSubProcNombre.Tag = gvSubProcesos.GetDataRow(Me.gvSubProcesos.GetSelectedRows(0)).Item("subProcId")
            txtSubProcNombre.Text = gvSubProcesos.GetDataRow(Me.gvSubProcesos.GetSelectedRows(0)).Item("subProcNombre")
            txtSubProcDescripcion.Text = gvSubProcesos.GetDataRow(Me.gvSubProcesos.GetSelectedRows(0)).Item("subProcDescripcion")
            chkSubProcActivo.Checked = gvSubProcesos.GetDataRow(Me.gvSubProcesos.GetSelectedRows(0)).Item("subProcActivo")
            dtTablaSubProcesos.Rows.RemoveAt(Me.gvSubProcesos.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub
End Class