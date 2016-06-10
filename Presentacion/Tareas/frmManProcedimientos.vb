
Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraTreeList.Nodes

Public Class frmManProcedimientos
    Inherits frmMantenimientos
    Dim dtTablaProcedimientos As New DataTable
    Dim tlpadre As TreeListNode
    Dim tlhijo As TreeListNode
    Dim loProcesosDistinct As List(Of String) = Nothing
    Dim loSubProcesosDistinct As List(Of String) = Nothing
    Dim loProcedimientosDistinct As List(Of String) = Nothing
#Region "Funciones Sobrescritas"

    Private Sub ConstruirTable()
        dtTablaProcedimientos.Columns.Add("procId", GetType(String))
        dtTablaProcedimientos.Columns.Add("procNombre", GetType(String))
        dtTablaProcedimientos.Columns.Add("subProcId", GetType(String))
        dtTablaProcedimientos.Columns.Add("subProcNombre", GetType(String))
        dtTablaProcedimientos.Columns.Add("procdId", GetType(String))
        dtTablaProcedimientos.Columns.Add("procdNombre", GetType(String))
        dtTablaProcedimientos.Columns.Add("procdDescripcion", GetType(String))
        dtTablaProcedimientos.Columns.Add("procdActivo", GetType(Boolean))
        dtTablaProcedimientos.Columns.Add("tgAreaId", GetType(String))
        dtTablaProcedimientos.Columns.Add("tgCargoId", GetType(Boolean))

    End Sub

    Protected Overrides Sub guardar()
        Try
            If String.IsNullOrEmpty(txtProcdId.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El codigo del Procedimiento no se ha Generado")
                txtProcdId.Focus()
                Return
            End If
            If String.IsNullOrEmpty(TxtProcdNombre.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nombre del Procedimiento")
                TxtProcdNombre.Focus()
                Return
            End If
            If String.IsNullOrEmpty(txtProcdDescripcion.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("La Descripcion del Procedimiento es necesaria")
                txtProcdDescripcion.Focus()
                Return
            End If
            If String.IsNullOrEmpty(cboProceso.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Proceso")
                txtProcdDescripcion.Focus()
                Return
            End If
            If String.IsNullOrEmpty(cboSubProceso.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Sub Proceso")
                txtProcdDescripcion.Focus()
                Return
            End If
            If String.IsNullOrEmpty(cboArea.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Area")
                txtProcdDescripcion.Focus()
                Return
            End If
            If String.IsNullOrEmpty(cboArea.EditValue) Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Cargo")
                txtProcdDescripcion.Focus()
                Return
            End If

            Dim loProcedimientos As EEProcedimientos = New EEProcedimientos() With {.ProcdId = txtProcdId.Text,
                                                                 .ProcdNombre = TxtProcdNombre.Text,
                                                                 .ProcdDescripcion = txtProcdDescripcion.Text,
                                                                 .ProcdActivo = chkProcdActivo.Checked,
                                                                 .ProcdMaxDia = txtNroDias.EditValue,
                                                                 .TgArea = cboArea.EditValue,
                                                                 .TgCargo = cboCargo.EditValue,
                                                                 .SubProcId = cboSubProceso.EditValue}


            If GEstadoNuevo Then
                MantenimientosBL.Instancia.procedimientosGuardar(loProcedimientos)
            Else
                MantenimientosBL.Instancia.procedimientosActualizar(loProcedimientos)
            End If
            Me.enabledGA = False
            MyBase.guardar()
            cargarLista()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        txtProcdId.Text = cboSubProceso.EditValue & MantenimientosBL.Instancia.procedimientosNewCodigo(cboSubProceso.EditValue)
        txtProcdId.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub Buscar()
        Try
            'dtTablaProcedimientos.Rows.Clear()
            'GValorTextoBuscado = txtBuscar.Text
            'GCriterioBuscado = cbBuscarPor.SelectedIndex

            'Dim ListaProcedimientos As List(Of EEProcedimientos) = MantenimientosBL.Instancia.procedimientosListarXCriterios(GCriterioBuscado, GValorTextoBuscado)
            'If ListaProcedimientos IsNot Nothing Then
            '    For Each frow As EEProcedimientos In ListaProcedimientos
            '        dtTablaProcedimientos.LoadDataRow(New Object() {frow.ProcId, frow.ProcNombre, frow.SubProcId, frow.SubProcNombre, frow.ProcdId, frow.ProcdNombre, frow.ProcdDescripcion, frow.ProcdActivo, frow.TgArea, frow.TgCargo}, True)
            '    Next
            '    gvProcedimientos.BestFitColumns()
            '    gvProcedimientos.SelectRow(0)
            '    dgvListado_Click(Nothing, Nothing)
            'End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    'Protected Overrides Sub seleccionarListado()
    '    Try
    '        If Me.gvListado.DataRowCount <> 0 Then

    '            txtProcId.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "procId").ToString()
    '            GIdRegistroActual = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "procId").ToString()
    '            txtProcNombre.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "procNombre").ToString()
    '            txtProcDescripcion.EditValue = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "procDescripcion").ToString()
    '            chkProcActivo.Checked = gvListado.GetRowCellValue(Me.gvListado.GetSelectedRows(0), "procActivo").ToString()
    '            MyBase.seleccionarListado()
    '        End If
    '    Catch ex As Exception
    '        SaimtMessageBox.mostrarAlertaError(ex.Message)
    '    End Try
    'End Sub

    'Protected Overrides Sub Editar()
    '    MyBase.editar()
    '    txtProcId.Properties.ReadOnly = True
    'End Sub

#End Region

    Private Sub frmManProcedimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PuedeBuscar = True
        PuedeCrear = True
        PuedeImprimir = True
        PuedeEditar = True

        cboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboArea.Properties.DisplayMember = "TgNombre"
        cboArea.Properties.ValueMember = "TgCodigo"
        cboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(83, "0001")
        cboArea.ItemIndex = 0

        cboProceso.mColumnas(SaimtComboBoxLookUp.Entidades.Procesos)
        cboProceso.Properties.DisplayMember = "ProcNombre"
        cboProceso.Properties.ValueMember = "ProcId"
        cboProceso.Properties.DataSource = MantenimientosBL.Instancia.procesosListarActivos()
        cboProceso.ItemIndex = 0
        ConstruirTable()

        cargarLista()
 
    End Sub
    Sub cargarLista()
        Dim ListaProcesos As List(Of EEProcesos) = MantenimientosBL.Instancia.procedimientosListarProcesosSubProcesosActivos()
        loProcesosDistinct = New List(Of String)
        For Each loprocesos As EEProcesos In ListaProcesos
            If TreeView1.Nodes(loprocesos.ProcId) Is Nothing Then
                TreeView1.Nodes.Add(loprocesos.ProcId, loprocesos.ProcNombre)
            End If

            If TreeView1.Nodes(loprocesos.ProcId) IsNot Nothing And TreeView1.Nodes(loprocesos.ProcId).Nodes(loprocesos.loSubProcesos.SubProcId) Is Nothing Then
                TreeView1.Nodes(loprocesos.ProcId).Nodes.Add(loprocesos.loSubProcesos.SubProcId, loprocesos.loSubProcesos.SubProcNombre)
            End If

            If TreeView1.Nodes(loprocesos.ProcId) IsNot Nothing And TreeView1.Nodes(loprocesos.ProcId).Nodes(loprocesos.loSubProcesos.SubProcId) IsNot Nothing And TreeView1.Nodes(loprocesos.ProcId).Nodes(loprocesos.loSubProcesos.SubProcId).Nodes(loprocesos.loSubProcesos.loProcedimientos.ProcdId) Is Nothing Then
                If Len(loprocesos.loSubProcesos.loProcedimientos.ProcdId) > 0 Then
                    TreeView1.Nodes(loprocesos.ProcId).Nodes(loprocesos.loSubProcesos.SubProcId).Nodes.Add(loprocesos.loSubProcesos.loProcedimientos.ProcdId, loprocesos.loSubProcesos.loProcedimientos.ProcdNombre)
                End If
            End If
        Next
        TreeView1.ExpandAll()
    End Sub
    Private Sub cboArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.EditValueChanged
        If cboArea.EditValue IsNot Nothing Then
            cboCargo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboCargo.Properties.DisplayMember = "TgNombre"
            cboCargo.Properties.ValueMember = "TgCodigo"
            cboCargo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(84, cboArea.EditValue & "0001")
            cboCargo.ItemIndex = 0
        End If
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



    Private Sub TreeView1_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If TreeView1.Nodes.Count > 0 Then
     
            Select Case e.Node.Level
                Case 0
                    cboProceso.Properties.ReadOnly = True
                    cboSubProceso.Properties.ReadOnly = True
                    txtProcdId.Properties.ReadOnly = True
                    cboProceso.ItemIndex = -1
                    cboSubProceso.ItemIndex = -1
                    cboArea.ItemIndex = -1
                    cboCargo.ItemIndex = -1
                    txtProcdId.Text = String.Empty
                    TxtProcdNombre.Text = String.Empty
                    txtProcdDescripcion.Text = String.Empty
                    cboArea.EditValue = String.Empty
                    cboCargo.EditValue = String.Empty
                    chkProcdActivo.Checked = False
                    txtNroDias.EditValue = String.Empty
                Case 1

                    cboProceso.Properties.ReadOnly = True
                    cboSubProceso.Properties.ReadOnly = True
                    txtProcdId.Properties.ReadOnly = True
                    cboArea.ItemIndex = -1
                    cboCargo.ItemIndex = -1
                    txtNroDias.EditValue = 0
                    cboProceso.EditValue = e.Node.Parent.Name
                    cboSubProceso.EditValue = e.Node.Name
                    nuevo()
                Case 2
                    MyBase.editar()
                    cboProceso.Properties.ReadOnly = True
                    cboSubProceso.Properties.ReadOnly = True
                    txtProcdId.Properties.ReadOnly = True
                    cboSubProceso.EditValue = e.Node.Parent.Name
                    Dim loprocedimiento As EEProcedimientos = MantenimientosBL.Instancia.procedimientosMostrarXProcId_subProcId_procdId(e.Node.Name)
                    If loprocedimiento IsNot Nothing Then
                        txtProcdId.Text = e.Node.Name
                        TxtProcdNombre.Text = e.Node.Text
                        txtProcdDescripcion.Text = loprocedimiento.ProcdDescripcion
                        cboArea.EditValue = loprocedimiento.TgArea
                        cboCargo.EditValue = loprocedimiento.TgCargo
                        chkProcdActivo.Checked = loprocedimiento.ProcdActivo
                        txtNroDias.EditValue = loprocedimiento.ProcdMaxDia
                    End If

            End Select
        End If
    End Sub

   
End Class