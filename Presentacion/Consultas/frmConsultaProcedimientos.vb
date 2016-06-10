﻿Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmConsultaProcedimiento
    Inherits frmConsultas

#Region "Propiedades"
    Public Property ProcId() As String
    Public Property ProcNombre() As String
#End Region

    Dim oTable As DataTable = New DataTable()

    Private Sub ConstruirTable()
        oTable.Columns.Add("procId", GetType(String))
        oTable.Columns.Add("procNombre", GetType(String))
        oTable.Columns.Add("procMaxDia", GetType(Integer))
        oTable.Columns.Add("tgCalificacion", GetType(String))
        oTable.Columns.Add("tgAreaInicio", GetType(String))
        oTable.Columns.Add("tgAreaFin", GetType(String))
        oTable.Columns.Add("procPUIT", GetType(Decimal))
    End Sub

    Private Sub frmConsultaConyuge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = oTable
    End Sub

    Protected Overrides Sub buscar()
        Dim ListaProcedimiento As List(Of EEProcedimientoSTD) = MantenimientosBL.Instancia.procedimientostdListarCriterio(1, txtBuscar.Text)
        Try
            oTable.Clear()
            If ListaProcedimiento IsNot Nothing Then
                For Each fProc As EEProcedimientoSTD In ListaProcedimiento
                    oTable.LoadDataRow(New Object() {fProc.ProcId, _
                    fProc.ProcNombre, _
                    fProc.ProcMaxDia, _
                    fProc.OUTablaGeneralCalificacion.TgNombre, _
                    fProc.OUTablaGeneralAreaInicio.TgNombre, _
                    fProc.OUTablaGeneralAreaFin.TgNombre, _
                    fProc.ProcPUIT}, True)
                Next
                Me.Encontrado = True
            Else
                Me.Encontrado = False
            End If
            MyBase.buscar()
            Me.gvResultado.BestFitColumns()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Private Sub btnAgregarProcedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProcedimiento.Click
        Dim fmProcedimiento As frmProcedimientos = New frmProcedimientos()
        If fmProcedimiento.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Protected Overrides Sub seleccionar()
        If Me.gvResultado.DataRowCount <> 0 Then

            ProcId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "procId").ToString()
            ProcNombre = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "procNombre").ToString()

            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub

    
End Class