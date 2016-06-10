﻿Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Imports System.IO
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop

Public Class frmAgrupacionDoc
    Inherits frmMantenimientos
    Dim DocID As String = String.Empty
    Dim DocAsunto As String = String.Empty
    Dim DocfechaIng As String = String.Empty
    Dim DocNroReg As String = String.Empty

    Dim DocSecID As String = String.Empty
    Dim DocSecAsunto As String = String.Empty
    Dim DocSecfechaIng As String = String.Empty
    Dim DocSecNroReg As String = String.Empty

    Dim dtTablaExpediente As DataTable = New DataTable()
    Dim ListaTemporalNuevos As New List(Of String)
    Dim ListaTemporalEliminados As New List(Of String)

#Region "Construir Tabla Expediente"
    Private Sub ConstruirTableExpediente()
        dtTablaExpediente.Columns.Add("docSecId", GetType(String))
        dtTablaExpediente.Columns.Add("docSecNroReg", GetType(String))
        dtTablaExpediente.Columns.Add("docSecAsunto", GetType(String))
        dtTablaExpediente.Columns.Add("docSecfechaIng", GetType(String))
    End Sub
#End Region

#Region "Funciones SobreEscritas"
    

    Protected Overrides Sub guardar()
        Try
            Dim ListaExpedienteSTD As EEExpedienteSTD = New EEExpedienteSTD()
            ListaExpedienteSTD.DocId = DocID
            ListaExpedienteSTD.ListaDocumentosSecundariosNuevos = ListaTemporalNuevos
            ListaExpedienteSTD.ListaDocumentosSecundariosEliminados = ListaTemporalEliminados
            MantenimientosBL.Instancia.expedienteSTDGuardar(ListaExpedienteSTD)
            ListaTemporalEliminados.Clear()
            ListaTemporalNuevos.Clear()
            Me.enabledGA = False
            MyBase.guardar()
            '  Me.lstListado.SelectionMode = SelectionMode.One
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

#End Region


    Sub CargarDetalle(ByVal docSecId As String)
        Dim ListaExpediente As List(Of EEExpedienteSTD) = MantenimientosBL.Instancia.expedienteSTDListarXDocId(docSecId)
        If ListaExpediente IsNot Nothing Then
            DocID = ListaExpediente.Item(0).DocId
            If DocID <> docSecId Then
                Dim loExpedientePrincipal As EEExpedienteSTD = MantenimientosBL.Instancia.expedienteSTDMostrarXDocId(DocID)
                If loExpedientePrincipal IsNot Nothing Then
                    txtDocId.Text = loExpedientePrincipal.loDocumento.DocAsunto
                    DocID = loExpedientePrincipal.loDocumento.DocId
                    txtDocId.Text = loExpedientePrincipal.loDocumento.DocAsunto
                    DocAsunto = loExpedientePrincipal.loDocumento.DocAsunto
                    lnkDocId.Text = loExpedientePrincipal.loDocumento.DocNRegT
                    DocNroReg = loExpedientePrincipal.loDocumento.DocNRegT
                    DocfechaIng = loExpedientePrincipal.loDocumento.DocFechaIng
                    lblDocIdFecha.Text = loExpedientePrincipal.loDocumento.DocFechaIng
                End If
            End If
            dtTablaExpediente.Clear()
            For Each loExpediente As EEExpedienteSTD In ListaExpediente
                dtTablaExpediente.LoadDataRow(New Object() {loExpediente.DocSecId, loExpediente.loDocumento.DocNRegT, loExpediente.loDocumento.DocAsunto, loExpediente.loDocumento.DocFechaIng.ToString.Substring(0, 10)}, True)
            Next
            gvDocumentosSecundarios.BestFitColumns()
        End If
    End Sub
    ' Dim DocNroRegistro As String = String.Empty
    Private Sub btnBuscarDocId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDocId.Click
        Try
            Dim frm As New frmConsultorSTD
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                DocID = String.Empty
                DocAsunto = String.Empty
                txtDocId.Text = String.Empty

                txtDocId.Text = frm.docAsunto
                DocID = frm.docId
                DocAsunto = frm.docAsunto
                lnkDocId.Text = frm.docNroRegistro.Substring(1, 23)
                DocNroReg = frm.docNroRegistro.Substring(1, 23)
                DocfechaIng = frm.docFechaIng
                lblDocIdFecha.Text = frm.docFechaIng

                CargarDetalle(DocID)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarDocSecId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDocSecId.Click
        Try
            Dim frm As New frmConsultorSTD
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                DocSecID = String.Empty
                DocSecAsunto = String.Empty
                ' DocNroRegistro = String.Empty
                txtDocSecId.Text = String.Empty

                txtDocSecId.Text = frm.docAsunto
                DocSecID = frm.docId
                DocSecAsunto = frm.docAsunto
                lnkDocSecId.Text = frm.docNroRegistro.Substring(1, 23)
                DocSecNroReg = frm.docNroRegistro.Substring(1, 23)
                DocSecfechaIng = frm.docFechaIng
                lblDocSecIdFecha.Text = frm.docFechaIng
                '  DocNroRegistro = String.Empty
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If String.IsNullOrEmpty(txtDocId.Text) Then
            SaimtMessageBox.mostrarAlertaInformativa("Seleccione el Documento Principal")
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtDocSecId.Text) Then
            SaimtMessageBox.mostrarAlertaInformativa("Seleccione el Documento Secundario")
            Exit Sub
        End If
        'Validar que no sea el principal
        If DocID = DocSecID Then
            SaimtMessageBox.mostrarAlertaInformativa("Los documentos son iguales!, Seleccione otro documento secundario")
            Exit Sub
        End If

        'Validar que no este incluido
        If dtTablaExpediente.Rows.Count > 0 Then
            For Each row As DataRow In dtTablaExpediente.Rows
                If row("docSecId") = DocSecID Then
                    SaimtMessageBox.mostrarAlertaInformativa("Ya se encuentra agregado, como complemento")
                    Exit Sub
                End If
            Next
            'Exit Sub
        End If

        'Validar Fechas

        dtTablaExpediente.LoadDataRow(New Object() {DocSecID, DocSecNroReg, DocSecAsunto, DocSecfechaIng.ToString.Substring(0, 10)}, True)

        ListaTemporalNuevos.Add(DocSecID)
        txtDocSecId.Text = String.Empty
        DocSecID = String.Empty
        DocSecAsunto = String.Empty
        DocSecfechaIng = String.Empty
        DocSecNroReg = String.Empty
        lnkDocSecId.Text = String.Empty
        lblDocSecIdFecha.Text = String.Empty
        gvDocumentosSecundarios.BestFitColumns()

    End Sub

    Private Sub frmAgrupacionDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableExpediente()
        dgvDocumentosSecundarios.DataSource = dtTablaExpediente
        txtDocSecId.Properties.ReadOnly = True
        txtDocId.Properties.ReadOnly = True
        PuedeEditar = True
        PuedeImprimir = True
        PuedeEliminar = True
        MyBase.seleccionarListado()
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If Me.gvDocumentosSecundarios.DataRowCount <> 0 Then
            If GEstadoNuevo = False Then
                If Not String.IsNullOrEmpty(dtTablaExpediente.Rows(Me.gvDocumentosSecundarios.GetSelectedRows(0))("docSecId").ToString()) Then
                    ListaTemporalEliminados.Add(dtTablaExpediente.Rows(Me.gvDocumentosSecundarios.GetSelectedRows(0))("docSecId").ToString())
                End If
            End If
            If ListaTemporalNuevos.Count > 0 Then
                Dim liIndiceNuevoModificar As Int16 = 0
                Dim liFila As Int16 = -1
                For Each frow As DataRow In dtTablaExpediente.Rows
                    If String.IsNullOrEmpty(frow("docSecId")) And Me.gvDocumentosSecundarios.FocusedRowHandle = liFila Then
                        liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                    End If
                    liFila = liFila + 1
                Next
                ListaTemporalNuevos.RemoveAt(liIndiceNuevoModificar)
            End If
            dtTablaExpediente.Rows.RemoveAt(Me.gvDocumentosSecundarios.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub lnkDocId_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDocId.LinkClicked
        Dim frm As New frmVisorDocumento(DocID)
        frm.ShowDialog()
    End Sub

    Private Sub lnkDocSecId_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDocSecId.LinkClicked
        Dim frm As New frmVisorDocumento(DocSecID)
        frm.ShowDialog()
    End Sub

    Private Sub gclinkDetalleDocSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gclinkDetalleDocSec.Click
        If Me.gvDocumentosSecundarios.DataRowCount <> 0 Then
            Dim movId As String = String.Empty
            movId = gvDocumentosSecundarios.GetRowCellValue(gvDocumentosSecundarios.GetSelectedRows(0), "docSecId").ToString()
            Dim frm As New frmVisorDocumento(DocSecID)
            frm.ShowDialog()
        End If
    End Sub
End Class