Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports DevExpress.XtraEditors.Repository

Public Class frmConsultarOrdenCompra
    Dim dtListado As DataTable = New DataTable()
    Dim Preciono As Boolean = False
    Public dtDetalleArticulos As DataTable = New DataTable()
    'Private ListaTemporal_OrdenCompraDetNuevo As List(Of EEOrdenCompra.EEOrdenCompraDet) = New List(Of EEOrdenCompra.EEOrdenCompraDet)
    'Private ListaTemporal_OrdenCompraDetElimandos As List(Of String) = New List(Of String)

#Region "Construir Table"
    Private Sub ConstruirTableListado()
        dtListado.Columns.Add("OrdId", GetType(String))
        dtListado.Columns.Add("artDescripcion", GetType(String))
        dtListado.Columns.Add("OrdNro", GetType(String))
        dtListado.Columns.Add("OrdFechaDoc", GetType(Date))
        dtListado.Columns.Add("ordDetCQuedan", GetType(String))
    End Sub

    Private Sub ConstruirTableDetalleArticulos()
        dtDetalleArticulos.Columns.Add("ordDetId", GetType(String))
        dtDetalleArticulos.Columns.Add("artId", GetType(String))
        dtDetalleArticulos.Columns.Add("artDescripcion", GetType(String))
        dtDetalleArticulos.Columns.Add("tgUMId", GetType(String))
        dtDetalleArticulos.Columns.Add("tgUM", GetType(String))
        dtDetalleArticulos.Columns.Add("ordDetCantidad", GetType(Decimal))
        dtDetalleArticulos.Columns.Add("ordDetCQuedan", GetType(Decimal))
        dtDetalleArticulos.Columns.Add("ordDetPrecio", GetType(Decimal))
        dtDetalleArticulos.Columns.Add("ordDetImporte", GetType(Decimal))
        dtDetalleArticulos.Columns.Add("ordLleva", GetType(Boolean))
        dtDetalleArticulos.Columns.Add("ordCanLleva", GetType(Decimal))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub Buscar()
        Try
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterio.SelectedIndex
            
            Dim loConsultarOrdenCompra As List(Of EEOrdenCompra) = MantenimientosBL.Instancia.consultarordencompraListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            dtListado.Clear()
            dtDetalleArticulos.Clear()
            If loConsultarOrdenCompra IsNot Nothing Then
                For Each frow As EEOrdenCompra In loConsultarOrdenCompra
                    dtListado.LoadDataRow(New Object() {frow.OrdId, _
                    frow.OrdArtDescripcion, _
                    frow.OrdNro, _
                    frow.OrdFechaDoc, _
                    frow.OrdDetCQuedan
                    }, True)
                Next
                gvListadoOrdenCompra.BestFitColumns()
                gvListadoOrdenCompra.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
            'cboBuscarPorArea.Properties.ReadOnly = IIf(cboCriterio.SelectedIndex = 3, False, True)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub seleccionarListado()
        Try

            Dim frmPecosa As frmPecosa = New frmPecosa
            Dim dt_pecosa As DataTable = frmPecosa.dt_detalleOrdenCompra

            If Me.gvListadoOrdenCompra.DataRowCount <> 0 Then

                GIndiceSeleccionado = Me.gvListadoOrdenCompra.GetSelectedRows(0)
                txtCodId.Text = gvListadoOrdenCompra.GetRowCellValue(Me.gvListadoOrdenCompra.GetSelectedRows(0), "OrdId").ToString()
                txtNumOrd.Text = gvListadoOrdenCompra.GetRowCellValue(Me.gvListadoOrdenCompra.GetSelectedRows(0), "OrdNro").ToString()
                
                dtDetalleArticulos.Clear()
                
                Dim igv As Decimal = MantenimientosBL.Instancia.parametroMostrarXClsId(42)
                Dim lleva As Boolean = False
                Dim clleva As Decimal

                Dim ConsultarOrdenCompraDet As List(Of EEOrdenCompra.EEOrdenCompraDet) = MantenimientosBL.Instancia.consultarordencompraDetXOrdId(txtCodId.Text)
                If ConsultarOrdenCompraDet IsNot Nothing Then
                    For Each frow As EEOrdenCompra.EEOrdenCompraDet In ConsultarOrdenCompraDet
                        clleva = 0
                        For Each frowp As DataRow In dt_pecosa.Rows
                            If frowp("ordId") = txtCodId.Text Then
                                lleva = True
                                clleva = frowp("cantidad")
                                Exit For
                            End If
                        Next
                        dtDetalleArticulos.LoadDataRow(New Object() {frow.OrdDetId, _
                                                                     frow.OArticulo.ArtId, _
                                                                     frow.OArticulo.ArtDescripcion, _
                                                                    frow.TgUmId, _
                                                                    frow.TgUm, _
                                                                    frow.OrdDetCantidad, _
                                                                    frow.OrdDetCQuedan, _
                                                                    frow.OrdDetPrecio, _
                                                                    frow.OrdDetCantidad * frow.OrdDetPrecio, _
                                                                    lleva, _
                                                                    clleva}, True)

                        'txtSubTotal.EditValue = Val(txtSubTotal.EditValue) + (CDbl(Val(frow.OrdDetPrecio) * frow.OrdDetCantidad))
                    Next
                    'txtIGV.EditValue = txtSubTotal.EditValue * igv
                    'txtMontoTotal.EditValue = txtSubTotal.EditValue + txtIGV.Text
                End If

                gvDetalleArticulos.BestFitColumns()
                GIdRegistroActual = txtCodId.Text
            End If
            MyBase.seleccionarListado()
            btnSeleccionar.Enabled = False
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub frmConsultarOrdenCompraDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBuscarPor.Properties.ReadOnly = False
        ConstruirTableListado()
        dgvListadoOrdenCompra.DataSource = dtListado
        ConstruirTableDetalleArticulos()
        dgvDetalleArticulos.DataSource = dtDetalleArticulos
    End Sub

    Private Sub dgvDetalleArticulos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvDetalleArticulos.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.btnSeleccionar.PerformClick()
        End If
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        Preciono = True
        Me.Close()
    End Sub

    Private Sub gvDetalleArticulos_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDetalleArticulos.CellValueChanged
        If e.Value = True And e.Column.ToString = "Llevar" Then
            gvDetalleArticulos.SetRowCellValue(e.RowHandle, "ordCanLleva", gvDetalleArticulos.GetRowCellValue(e.RowHandle, "ordDetCQuedan").ToString)
        End If

        If e.Column.ToString = "Cantidad Llevar" Then
            Dim valor As Decimal = gvDetalleArticulos.GetRowCellValue(e.RowHandle, "ordDetCQuedan").ToString
            Dim Lleva As Decimal = gvDetalleArticulos.GetRowCellValue(e.RowHandle, "ordCanLleva").ToString
            If valor < e.Value Or Lleva = 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Stock insuficiente")
                btnSeleccionar.Enabled = False
            Else
                btnSeleccionar.Enabled = True
            End If
        End If

    End Sub

    Private Sub dgvListadoOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvListadoOrdenCompra.Click
        Me.seleccionarListado()
    End Sub

    Private Sub frmConsultarOrdenCompra_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Preciono = False Then
            dtDetalleArticulos.Clear()
            txtNumOrd.EditValue = Nothing
        End If
    End Sub
End Class
