Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Imports System.IO
Public Class frmArticulo
    Inherits frmMantenimientos
    Dim dtTablaDetalle As DataTable = New DataTable()
    ' Lista de Clases
#Region "Constantes Clases"
    Private Const ClsIdArtGrupo As Integer = 106
    Private Const ClsIdGrupo As String = "01"
#End Region
#Region "DataTable"
    Dim dtArticulo As DataTable = New DataTable()
#End Region
#Region "Tablas"

    Private Sub ConstruirTableArticulo()
        dtArticulo.Columns.Add("artId", GetType(String))
        dtArticulo.Columns.Add("artCodigo", GetType(String))
        '  dtArticulo.Columns.Add("artNombre", GetType(String))
        dtArticulo.Columns.Add("artDescripcion", GetType(String))
        dtArticulo.Columns.Add("tgartGrupoId", GetType(String))
        dtArticulo.Columns.Add("tgartGrupo", GetType(String))
        dtArticulo.Columns.Add("artActivo", GetType(Boolean))
        dtArticulo.Columns.Add("tgUMId", GetType(String))
        dtArticulo.Columns.Add("artUniMinimas", GetType(String))
    End Sub
#End Region

#Region "Construir Table Contacto"
    Private Sub ConstruirTableDetalle()
        dtTablaDetalle.Columns.Add("Dato", GetType(String))
        dtTablaDetalle.Columns.Add("Descripcion", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"

    Protected Overrides Sub guardar()
        Try

            If String.IsNullOrEmpty(txtArtId.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Identificador del Articulo no ha sido Generado")
                txtArtId.Focus()
                Return
            End If

            If String.IsNullOrEmpty(txtArtCodigo.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Codigo del Articulo no ha sido Generado")
                txtArtCodigo.Focus()
                Return
            End If


            If String.IsNullOrEmpty(txtDescripcion.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese la Descripcion del Articulo")
                txtDescripcion.Focus()
                Return
            End If

            If String.IsNullOrEmpty(txtGrupo.Tag) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Grupo")
                txtGrupo.Focus()
                Return
            End If

            If String.IsNullOrEmpty(cboUM.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Unidad de Medida")
                cboUM.Focus()
                Return
            End If

            If String.IsNullOrEmpty(txtUMinimas.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese la Unidad Minima")
                txtUMinimas.Focus()
                Return
            End If



            Dim loArticulo As EEArticulo = New EEArticulo() With {.ArtId = GIdRegistroActual, .ArtDescripcion = txtDescripcion.Text, .tgArtGrupoId = txtGrupo.Tag, .ArtActivo = chkArtActivo.Checked, .ArtCodigo = txtArtCodigo.Text, .tgUMedidaId = cboUM.EditValue, .ArtUMinimas = txtUMinimas.Text}
            For Each fTablaContacto As DataRow In dtTablaDetalle.Rows
                Dim loContacto As EEArticulo.EEDetalle = New EEArticulo.EEDetalle()
                Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
                Dim loClase As EEClase = New EEClase()
                loClase.ClsId = 130
                loTablaGeneral.TgAbrev = fTablaContacto("Dato")
                loTablaGeneral.TgDescripcion = fTablaContacto("Descripcion")
                loTablaGeneral.OClase = loClase
                loTablaGeneral.TgActivo = 1
                loContacto.OTablaGeneral = loTablaGeneral

                loArticulo.ListaDetalle.Add(loContacto)
            Next
            If GEstadoNuevo Then
                MantenimientosBL.Instancia.articuloGuardar(loArticulo)
            Else
                MantenimientosBL.Instancia.articuloActualizar(loArticulo)
            End If
            Me.enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    'Protected Overrides Sub listar()

    'End Sub

    Protected Overrides Sub Buscar()
        Try
            dtArticulo.Rows.Clear()
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cbBuscarPor.SelectedIndex
            If GCriterioBuscado = 3 Then
                GValorTextoBuscado = cboBuscarPorGrupo.EditValue
            End If

            Dim ListaArticulos As List(Of EEArticulo) = MantenimientosBL.Instancia.articuloListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            If ListaArticulos IsNot Nothing Then
                For Each frow As EEArticulo In ListaArticulos
                    dtArticulo.LoadDataRow(New Object() {frow.ArtId, frow.ArtCodigo, frow.ArtDescripcion, frow.tgArtGrupoId, frow.tgArtGrupo, frow.ArtActivo, frow.tgUMedidaId, frow.ArtUMinimas}, True)
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
                Dim loDetalle As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(130, gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "artId").ToString())

                txtArtId.EditValue = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "artId").ToString()
                GIdRegistroActual = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "artId").ToString()
                txtArtCodigo.EditValue = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "artCodigo").ToString()
                txtDescripcion.EditValue = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "artDescripcion").ToString()
                txtGrupo.Tag = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "tgartGrupoId").ToString()
                txtGrupo.EditValue = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "tgartGrupo").ToString()
                chkArtActivo.Checked = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "artActivo").ToString()
                cboUM.EditValue = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "tgUMId").ToString()
                txtUMinimas.EditValue = gvResultados.GetRowCellValue(Me.gvResultados.GetSelectedRows(0), "artUniMinimas").ToString()
                dtTablaDetalle.Clear()
                If loDetalle IsNot Nothing Then
                    For Each frow As EETablaGeneral In loDetalle
                        dtTablaDetalle.LoadDataRow(New Object() {frow.TgAbrev, _
                            frow.TgDescripcion
                           }, True)
                        gvDatosAdicionales.BestFitColumns()
                    Next
                End If

                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtArtId.Text = MantenimientosBL.Instancia.articuloGeneraCodigo()
        txtArtCodigo.Text = MantenimientosBL.Instancia.articuloGeneraCodigoSAIMT()
        txtGrupo.Properties.ReadOnly = True
        txtArtCodigo.Properties.ReadOnly = True
        txtArtId.Properties.ReadOnly = True

        dtTablaDetalle.Rows.Clear()
    End Sub

    Protected Overrides Sub Editar()
        MyBase.editar()
        'cboTipoPersona.Properties.ReadOnly = True
        txtGrupo.Properties.ReadOnly = True
        txtArtId.Properties.ReadOnly = True
        

    End Sub
#End Region

    Private Sub frmArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboUM.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboUM.Properties.DisplayMember = "TgNombre"
        cboUM.Properties.ValueMember = "TgCodigo"
        cboUM.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(105)
        cboUM.ItemIndex = -1
        ConstruirTableArticulo()
        ConstruirTableDetalle()
        dgvResultados.DataSource = dtArticulo
        dgvDatosAdicionales.DataSource = dtTablaDetalle
        mAgregarComboContacto()
        Me.PuedeBuscar = True
        Me.PuedeConfirmar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeEliminar = True
        Me.PuedeImprimir = True
        Me.PuedeVisualizar = True
    End Sub

    Private Sub cbBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBuscarPor.SelectedIndexChanged
        If cbBuscarPor.SelectedIndex = 3 Then
            cboBuscarPorGrupo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboBuscarPorGrupo.Properties.DisplayMember = "TgNombre"
            cboBuscarPorGrupo.Properties.ValueMember = "TgCodigo"
            cboBuscarPorGrupo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(106)
            cboBuscarPorGrupo.ItemIndex = 0
        End If
    End Sub

    Private Sub cboBuscarPorGrupo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuscarPorGrupo.EditValueChanged
        If cbBuscarPor.SelectedIndex = 3 Then
            Buscar()
        End If
    End Sub

    Private Sub btnBuscarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarGrupo.Click
        Dim frmConsultar As New frmConsultaTablaGeneral(ClsIdArtGrupo)
        If frmConsultar.ShowDialog Then
            txtGrupo.Tag = frmConsultar.TgCodigo
            txtGrupo.Text = frmConsultar.TgNombre
        End If
    End Sub

    Private Sub btnAddDatosAdicionales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDatosAdicionales.Click
        dtTablaDetalle.Rows.Add()
    End Sub

#Region "Agregar Combo A Grilla"
    Private Sub mAgregarComboContacto()
        Dim RepositorioItemsContacto As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim dtComboContacto As DataTable = New DataTable
        dtComboContacto.Columns.Add("TgNombre", GetType(String))
        dtComboContacto.Columns.Add("TgCodigo", GetType(String))

        dtComboContacto.Columns("TgNombre").Caption = "Nombre"
        dtComboContacto.Columns("TgCodigo").Caption = "Codigo"
        dtComboContacto.Columns("TgCodigo").ColumnMapping = MappingType.Hidden

        For Each fTg As EETablaGeneral In MantenimientosBL.Instancia.tablageneralListarXClsId(129)
            dtComboContacto.Rows.Add(fTg.TgNombre, fTg.TgCodigo)
        Next

        With RepositorioItemsContacto
            .DisplayMember = "TgNombre"
            .ValueMember = "TgCodigo"
            .DataSource = dtComboContacto
            .NullText = "<<Seleccione>>"
        End With

        colContacto.ColumnEdit = RepositorioItemsContacto
        RepositorioItemsContacto.BestFit()
    End Sub
#End Region

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton1.Click
        If Me.gvDatosAdicionales.DataRowCount <> 0 Then
            dtTablaDetalle.Rows.RemoveAt(Me.gvDatosAdicionales.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaError("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub
End Class
