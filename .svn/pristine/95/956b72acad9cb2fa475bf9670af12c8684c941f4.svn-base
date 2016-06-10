Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmConsultaArticulo
    Inherits frmConsultas

#Region "Propiedades"
    Public Property ArtId() As String
    Public Property ArtCodigo() As String
    Public Property ArtNombre() As String
    Public Property ArtDescripcion() As String
    Public Property tgArtFamilia() As String
    Public Property tgUM() As String
    Public Property ArtUMinimas() As String
#End Region

    Dim oTable As DataTable = New DataTable()

    Private Sub ConstruirTable()
        oTable.Columns.Add("artId", GetType(String))
        oTable.Columns.Add("artCodigo", GetType(String))
        oTable.Columns.Add("artNombre", GetType(String))
        oTable.Columns.Add("artDescripcion", GetType(String))
        oTable.Columns.Add("tgArtFamilia", GetType(String))
        oTable.Columns.Add("tgUMId", GetType(String))
        oTable.Columns.Add("artUniMinimas", GetType(String))

    End Sub

    Private Sub frmConsultaConyuge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = oTable
    End Sub

    Protected Overrides Sub buscar()
        Try
            Dim ListaArticulos As List(Of EEArticulo) = MantenimientosBL.Instancia.articuloListarCriterio(sRbBuscarPor.EditValue, txtBuscar.Text)
            oTable.Clear()
            If ListaArticulos IsNot Nothing Then
                For Each frow As EEArticulo In ListaArticulos
                    oTable.LoadDataRow(New Object() {frow.ArtId, _
                    frow.ArtCodigo, _
                    frow.ArtNombre, _
                    frow.ArtDescripcion, _
                    frow.tgArtGrupo, _
                    frow.tgUMedidaId, _
                    frow.ArtUMinimas
                            }, True)
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

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frm As frmArticulo = New frmArticulo()
        If frm.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Protected Overrides Sub seleccionar()
        If Me.gvResultado.DataRowCount <> 0 Then

            ArtId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "artId").ToString()
            ArtCodigo = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "artCodigo").ToString()
            ArtNombre = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "artNombre").ToString()
            ArtDescripcion = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "artDescripcion").ToString()
            tgArtFamilia = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgArtFamilia").ToString()
            tgUM = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgUMId").ToString()
            ArtUMinimas = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "artUniMinimas").ToString()
            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub

  
End Class