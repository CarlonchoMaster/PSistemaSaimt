Imports ReglasNegocio
Imports Entidades
Imports SaimtControles

Public Class frmTablaGeneral
    Dim dtTablaGeneral As DataTable = New DataTable()
    Dim dtListadoTablaGeneral As DataTable = New DataTable()
    Dim ListaTemporalTablaGeneralEliminados As List(Of String) = Nothing
    Dim ListaTemporalTablaGeneralNuevos As List(Of EETablaGeneral) = Nothing

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtTablaGeneral.Columns.Add("tgId", GetType(Integer))
        dtTablaGeneral.Columns.Add("clsId", GetType(Integer))
        dtTablaGeneral.Columns.Add("tgNombre", GetType(String))
        dtTablaGeneral.Columns.Add("tgCodigo", GetType(String))
        dtTablaGeneral.Columns.Add("tgExtra", GetType(String))
        dtTablaGeneral.Columns.Add("tgAbrev", GetType(String))
        dtTablaGeneral.Columns.Add("tgDescripcion", GetType(String))
        dtTablaGeneral.Columns.Add("tgActivo", GetType(Boolean))
        dtTablaGeneral.Columns.Add("clsExtraId", GetType(Integer))
    End Sub
#End Region

#Region "Construir Table Listado"
    Private Sub ConstruirTableListado()
        dtListadoTablaGeneral.Columns.Add("clsId", GetType(Integer))
        dtListadoTablaGeneral.Columns.Add("clsNombre", GetType(String))
        dtListadoTablaGeneral.Columns.Add("clsDescripcion", GetType(String))
    End Sub
#End Region

    Private Sub frmTablaGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeEditar = True
        Me.PuedeCrear = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        ConstruirTable()
        ConstruirTableListado()
        dgvTablaGeneral.DataSource = dtTablaGeneral
        dgvListadoTablaGeneral.DataSource = dtListadoTablaGeneral

        If ListaTemporalTablaGeneralNuevos Is Nothing Then
            ListaTemporalTablaGeneralNuevos = New List(Of EETablaGeneral)
        End If

        If ListaTemporalTablaGeneralEliminados Is Nothing Then
            ListaTemporalTablaGeneralEliminados = New List(Of String)
        End If

        mGSetearTool(chkActivarClaseExtra, "Activar", "Check para Activar Clase Extra")
    End Sub

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvListadoTablaGeneral.DataRowCount <> 0 Then
                'limpiarControlesTotal(grbDatosPersonales.Controls)

                Dim ListaTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralMostrarXClsId(gvListadoTablaGeneral.GetRowCellValue(Me.gvListadoTablaGeneral.GetSelectedRows(0), "clsId").ToString())
                GIndiceSeleccionado = Me.gvListadoTablaGeneral.GetSelectedRows(0)

                cboUClase.cboUpdate.EditValue = Convert.ToInt32(gvListadoTablaGeneral.GetRowCellValue(Me.gvListadoTablaGeneral.GetSelectedRows(0), "clsId").ToString())

                dtTablaGeneral.Clear()
                If ListaTablaGeneral IsNot Nothing Then
                    For Each fTablaGeneral As EETablaGeneral In ListaTablaGeneral
                        dtTablaGeneral.LoadDataRow(New Object() { _
                               fTablaGeneral.TgId, _
                               gvListadoTablaGeneral.GetRowCellValue(Me.gvListadoTablaGeneral.GetSelectedRows(0), "clsId").ToString(), _
                               fTablaGeneral.TgNombre, _
                               fTablaGeneral.TgCodigo, _
                               fTablaGeneral.TgExtra, _
                               fTablaGeneral.TgAbrev, _
                               fTablaGeneral.TgDescripcion, _
                               fTablaGeneral.TgActivo,
                               fTablaGeneral.OClaseExtra.ClsId
                       }, True)
                    Next
                End If

                MyBase.seleccionarListado()
                Me.gvTablaGeneral.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            dtListadoTablaGeneral.Rows.Clear()
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = 1
            Dim ListadoClase As List(Of EEClase) = MantenimientosBL.Instancia.claseListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            If ListadoClase IsNot Nothing Then
                For Each fClase As EEClase In ListadoClase
                    dtListadoTablaGeneral.LoadDataRow(New Object() {fClase.ClsId, _
                         fClase.ClsNombre, _
                         fClase.ClsDescripcion
                       }, True)
                Next
                gvListadoTablaGeneral.BestFitColumns()
                gvListadoTablaGeneral.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub listar()
        Try
            dtListadoTablaGeneral.Rows.Clear()
            For Each fClase As EEClase In MantenimientosBL.Instancia.claseListarCriterio(GCriterioBuscado, GValorTextoBuscado)
                dtListadoTablaGeneral.LoadDataRow(New Object() {fClase.ClsId, _
                         fClase.ClsNombre, _
                         fClase.ClsDescripcion
                       }, True)
            Next
            MyBase.listar()
            Me.gvListadoTablaGeneral.FocusedRowHandle = GIndiceSeleccionado
            dgvListado_Click(Nothing, Nothing)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            Dim loTablaGeneral As EETablaGeneral = Nothing
            Dim loTablaGeneralSA As EETablaGeneral = New EETablaGeneral()

            Dim loClase As EEClase = Nothing
            Dim loClaseExtra As EEClase = Nothing

            For Each fTablaGeneral As DataRow In dtTablaGeneral.Rows
                loTablaGeneral = New EETablaGeneral()
                loClase = New EEClase()
                loClaseExtra = New EEClase()

                If loTablaGeneralSA.ListaTablaGeneral Is Nothing Then
                    loTablaGeneralSA.ListaTablaGeneral = New List(Of EETablaGeneral)
                End If

                loClase.ClsId = fTablaGeneral("clsId")
                If Not String.IsNullOrEmpty(fTablaGeneral("clsExtraId").ToString()) Then
                    loClaseExtra.ClsId = fTablaGeneral("clsExtraId")
                Else
                    loClaseExtra.ClsId = Nothing
                End If

                loTablaGeneral.TgId = fTablaGeneral("tgId")
                loTablaGeneral.TgNombre = fTablaGeneral("tgNombre")
                If IsDBNull(fTablaGeneral("tgExtra")) Then
                    loTablaGeneral.TgExtra = Nothing
                Else
                    loTablaGeneral.TgExtra = fTablaGeneral("tgExtra")
                End If

                If IsDBNull(fTablaGeneral("tgDescripcion")) Then
                    loTablaGeneral.TgDescripcion = Nothing
                Else
                    loTablaGeneral.TgDescripcion = fTablaGeneral("tgDescripcion")
                End If

                If IsDBNull(fTablaGeneral("tgAbrev")) Then
                    loTablaGeneral.TgAbrev = Nothing
                Else
                    loTablaGeneral.TgAbrev = fTablaGeneral("tgAbrev")
                End If

                loTablaGeneral.TgCodigo = fTablaGeneral("tgCodigo")
                loTablaGeneral.TgActivo = fTablaGeneral("tgActivo")
                loTablaGeneral.OClase = loClase
                loTablaGeneral.OClaseExtra = loClaseExtra

                loTablaGeneralSA.ListaTablaGeneral.Add(loTablaGeneral)
            Next

            loTablaGeneralSA.ListaTablaGeneralTemporalNuevos = ListaTemporalTablaGeneralNuevos
            loTablaGeneralSA.ListaTablaGeneralTemporalEliminados = ListaTemporalTablaGeneralEliminados
            MantenimientosBL.Instancia.tablageneralActualizar(loTablaGeneralSA)

            ListaTemporalTablaGeneralEliminados.Clear()
            ListaTemporalTablaGeneralNuevos.Clear()
            Me.enabledGA = False
            MyBase.guardar()
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub eliminar()
        Try
            MantenimientosBL.Instancia.tablageneralEliminar(GIdRegistroActual)
            MyBase.eliminar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub editar()
        MyBase.editar()
        cboUClase.cboUpdate.Properties.ReadOnly = True
        cboUClase.btnUpdateCbo.Enabled = False

        chkActivarClaseExtra.Checked = False
    End Sub
#End Region

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If String.IsNullOrEmpty(txtNombre.Text) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Nombre")
            txtNombre.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtCodigo.Text) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Codigo")
            txtCodigo.Focus()
            Exit Sub
        End If

        If chkActivarClaseExtra.Checked Then
            dtTablaGeneral.LoadDataRow(New Object() { _
               0, _
               cboUClase.cboUpdate.EditValue, _
               txtNombre.Text, _
               txtCodigo.Text, _
               txtExtra.Text, _
               txtAbreviatura.Text, _
               txtDescripcion.Text, _
               chkEstado.Checked,
               cboUClaseExtra.cboUpdate.EditValue
           }, True)
        Else
            dtTablaGeneral.LoadDataRow(New Object() { _
              0, _
              cboUClase.cboUpdate.EditValue, _
              txtNombre.Text, _
              txtCodigo.Text, _
              txtExtra.Text, _
              txtAbreviatura.Text, _
              txtDescripcion.Text, _
              chkEstado.Checked,
              Nothing
          }, True)
        End If

        Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
        Dim loClase As EEClase = New EEClase()
        Dim loClaseExtra As EEClase = New EEClase()

        loClase.ClsId = cboUClase.cboUpdate.EditValue

        If chkActivarClaseExtra.Checked Then
            loClaseExtra.ClsId = cboUClaseExtra.cboUpdate.EditValue
        Else
            loClaseExtra.ClsId = Nothing
        End If

        loTablaGeneral.TgNombre = txtNombre.Text
        loTablaGeneral.TgExtra = txtExtra.Text
        loTablaGeneral.TgDescripcion = txtDescripcion.Text
        loTablaGeneral.TgCodigo = txtCodigo.Text
        loTablaGeneral.TgActivo = chkEstado.Checked
        loTablaGeneral.TgAbrev = txtAbreviatura.Text
        loTablaGeneral.OClase = loClase
        loTablaGeneral.OClaseExtra = loClaseExtra

        ListaTemporalTablaGeneralNuevos.Add(loTablaGeneral)
        gvTablaGeneral.BestFitColumns()
        Me.txtNombre.Text = String.Empty
        Me.txtCodigo.Text = String.Empty
        Me.txtAbreviatura.Text = String.Empty
        Me.txtExtra.Text = String.Empty
        Me.txtDescripcion.Text = String.Empty
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If Me.gvTablaGeneral.DataRowCount <> 0 Then

            If Not String.IsNullOrEmpty(dtTablaGeneral.Rows(Me.gvTablaGeneral.GetSelectedRows(0))("tgId").ToString()) Then
                ListaTemporalTablaGeneralEliminados.Add(dtTablaGeneral.Rows(Me.gvTablaGeneral.GetSelectedRows(0))("tgId").ToString())
            End If

            If ListaTemporalTablaGeneralNuevos.Count > 0 Then
                Dim liIndiceNuevoModificar As Int16 = 0
                Dim liFila As Int16 = -1

                For Each fTablaGeneral As DataRow In dtTablaGeneral.Rows
                    If String.IsNullOrEmpty(fTablaGeneral("tgId")) And Me.gvTablaGeneral.FocusedRowHandle = liFila Then
                        liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                    End If
                    liFila = liFila + 1
                Next
                ListaTemporalTablaGeneralNuevos.RemoveAt(liIndiceNuevoModificar)
            End If

            dtTablaGeneral.Rows.RemoveAt(Me.gvTablaGeneral.GetSelectedRows(0))
            gvTablaGeneral.BestFitColumns()
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
        gvTablaGeneral.BestFitColumns()
    End Sub

    Private Sub chkActivarClaseExtra_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkActivarClaseExtra.CheckedChanged
        cboUClaseExtra.Enabled = chkActivarClaseExtra.Checked
    End Sub

    Private Sub gvListadoTablaGeneral_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvListadoTablaGeneral.CustomRowCellEditForEditing
        seleccionarListado()
    End Sub
End Class

