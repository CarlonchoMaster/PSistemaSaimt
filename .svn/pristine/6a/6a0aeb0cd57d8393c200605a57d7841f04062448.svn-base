
Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraTreeList.Nodes

Public Class frmVisualizadorTareasxArea
    Inherits frmMantenimientos
    Dim dtTablaActividades As DataTable = New DataTable()
    Dim dtTablaHistorialActividades As DataTable = New DataTable()
    Dim dtTablaProcedimientos As DataTable = New DataTable()
    Dim dtTablaHistorialProcedimientos As DataTable = New DataTable()
    Dim tgAreaCargo As String
    Dim perId As String
    Dim procdId As String = String.Empty
    Dim SubprocId As String = String.Empty
    Dim estadoProc As String = String.Empty
    Dim Listaprocedimiento As List(Of EEProcedimientos) = Nothing

#Region "Construir Table Actividades"
    Private Sub ConstruirTableHistorialActividades()
        dtTablaHistorialActividades.Columns.Add("Actividad", GetType(String))
        dtTablaHistorialActividades.Columns.Add("Nro", GetType(String))
    End Sub

    Private Sub ConstruirTableActividades()
        dtTablaActividades.Columns.Add("Actividad", GetType(String))
        dtTablaActividades.Columns.Add("Nro", GetType(String))
    End Sub

    Private Sub ConstruirTableProcedimientos()
        dtTablaProcedimientos.Columns.Add("procdId", GetType(String))
        dtTablaProcedimientos.Columns.Add("procdNombre", GetType(String))
        dtTablaProcedimientos.Columns.Add("procdDescripcion", GetType(String))
        dtTablaProcedimientos.Columns.Add("procdMaxDia", GetType(String))
        dtTablaProcedimientos.Columns.Add("tgArea", GetType(String))
        dtTablaProcedimientos.Columns.Add("tgCargo", GetType(String))
        dtTablaProcedimientos.Columns.Add("subProcId", GetType(String))
    End Sub

    Private Sub ConstruirTableHistorialProcedimientos()
        dtTablaHistorialProcedimientos.Columns.Add("movProcdId", GetType(String))
        dtTablaHistorialProcedimientos.Columns.Add("procdNombre", GetType(String))
        dtTablaHistorialProcedimientos.Columns.Add("procdDescripcion", GetType(String))
        dtTablaHistorialProcedimientos.Columns.Add("procdMaxDia", GetType(String))
        dtTablaHistorialProcedimientos.Columns.Add("fechaReg", GetType(Date))
        dtTablaHistorialProcedimientos.Columns.Add("fechaFin", GetType(Date))
        dtTablaHistorialProcedimientos.Columns.Add("tgArea", GetType(String))
        dtTablaHistorialProcedimientos.Columns.Add("tgCargo", GetType(String))
        dtTablaHistorialProcedimientos.Columns.Add("persona", GetType(String))
    End Sub
#End Region

    Protected Overrides Sub editar()
        MyBase.editar()
        dpFechaReg.Properties.ReadOnly = True
        dpFechaSol.Properties.ReadOnly = True
        cboSolEstado.Properties.ReadOnly = True
        TxtSolId.Properties.ReadOnly = True
        txtSolDocRef.Properties.ReadOnly = True
        txtSolNombre.Properties.ReadOnly = True
        txtSolDescripcion.Properties.ReadOnly = True

        txtprocdNombre.Properties.ReadOnly = True
        cboArea.Properties.ReadOnly = True
        cboCargo.Properties.ReadOnly = True
        txtQuedan.Properties.ReadOnly = True
        txtDiasMax.Properties.ReadOnly = True


        txtprocdNombre.Text = String.Empty
        txtprocdNombre.Tag = String.Empty
        cboArea.EditValue = String.Empty
        cboCargo.EditValue = String.Empty
        txtDiasMax.Text = String.Empty
        ' Dim DiaHasta As Date = String.Empty
        txtQuedan.Text = String.Empty
        cboEstadoProc.EditValue = String.Empty
        estadoProc = String.Empty
    End Sub

    Protected Overrides Sub guardar()
        Try
            If Len(tgAreaCargo) = 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Usted no puede realizar esta operación por que se desconoce su Cargo Asignado")
            End If
            Dim loMovimiento As New EEProcedimientosMov
            loMovimiento.solId = TxtSolId.Text
            loMovimiento.ProcdId = txtprocdNombre.Tag
            loMovimiento.TgAreaCargo = tgAreaCargo
            loMovimiento.PerId = PerId
            loMovimiento.Estado = cboEstadoProc.EditValue
            If cboEstadoProc.EditValue = "01" And dtTablaActividades.Rows.Count > 0 Then
                loMovimiento.Estado = "02"
            End If
            Dim ListaActividades As New List(Of EEProcedimientosAct)
            Dim loActividades As New EEProcedimientosAct
            For Each row As DataRow In dtTablaActividades.Rows
                loActividades = New EEProcedimientosAct
                loActividades.Actividad = row("Actividad").ToString
                loActividades.Nro = row("Nro").ToString
                ListaActividades.Add(loActividades)
            Next
            loMovimiento.ListaProcedimientosAct = ListaActividades
            MantenimientosBL.Instancia.movimientosprocedimientosGuardar(loMovimiento)
            Me.enabledGA = False
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub frmVisualizadorTareas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PuedeBuscar = True
        PuedeCrear = True
        PuedeImprimir = True
        PuedeEditar = True

        Dim locargoPersonal As EECargoPersonal = MantenimientosBL.Instancia.CargoMostrarXPerId_pa(EEComun._PerId)
        If locargoPersonal IsNot Nothing Then
            tgAreaCargo = locargoPersonal.CodArea & locargoPersonal.CodCargo
            XtraTabControl1.TabPages.Item(0).PageVisible = True
        Else
            XtraTabControl1.TabPages.Item(0).PageVisible = False
        End If
        perId = EEComun._PerId
        'Mesa Partes


        cboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboArea.Properties.DisplayMember = "TgNombre"
        cboArea.Properties.ValueMember = "TgCodigo"
        cboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(83, "0001")
        cboArea.ItemIndex = 0

        cboSolEstado.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSolEstado.Properties.DisplayMember = "TgNombre"
        cboSolEstado.Properties.ValueMember = "TgCodigo"
        cboSolEstado.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(206)
        cboSolEstado.ItemIndex = 0

        cboEstadoProc.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoProc.Properties.DisplayMember = "TgNombre"
        cboEstadoProc.Properties.ValueMember = "TgCodigo"
        cboEstadoProc.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(207)
        cboEstadoProc.ItemIndex = 0

        ConstruirTableActividades()
        dgvActividades.DataSource = dtTablaActividades

        ConstruirTableHistorialActividades()
        dgvHistorialActividad.DataSource = dtTablaHistorialActividades

        ConstruirTableProcedimientos()
        dgvProcedimientos.DataSource = dtTablaProcedimientos

        ConstruirTableHistorialProcedimientos()
        dgvHistorialProcedimientos.DataSource = dtTablaHistorialProcedimientos

        RadioGroup1.SelectedIndex = 0
        CheckEdit1.Checked = False
        cargarLista()

    End Sub

    Sub cargarLista()
        Dim fechaI As Date = Nothing
        Dim FechaF As Date = Nothing
        If CheckEdit1.Checked = True Then
            If dpSolFechaI.EditValue IsNot Nothing And dpSolFechaF.EditValue IsNot Nothing Then
                fechaI = dpSolFechaI.EditValue
                FechaF = dpSolFechaF.EditValue
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione correctamente el Rango de Fechas")
            End If
        End If
        Dim cargo As String = String.Empty
        If tgAreaCargo IsNot Nothing Then
            cargo = tgAreaCargo.Substring(0, 3)
        End If
        Dim ListaProcesos As List(Of EEProcesos) = MantenimientosBL.Instancia.solicitudesListarxTgAreaId(cargo, RadioGroup1.SelectedIndex, fechaI, FechaF)
        Dim cs As Int16 = 0
        TreeView1.Nodes.Clear()
        If ListaProcesos IsNot Nothing Then
            For Each loprocesos As EEProcesos In ListaProcesos
                If TreeView1.Nodes(loprocesos.ProcId) Is Nothing Then
                    TreeView1.Nodes.Add(loprocesos.ProcId, loprocesos.ProcNombre)
                End If
                If TreeView1.Nodes(loprocesos.ProcId) IsNot Nothing And TreeView1.Nodes(loprocesos.ProcId).Nodes(loprocesos.loSubProcesos.SubProcId) Is Nothing Then
                    TreeView1.Nodes(loprocesos.ProcId).Nodes.Add(loprocesos.loSubProcesos.SubProcId, loprocesos.loSubProcesos.SubProcNombre)
                End If
                If TreeView1.Nodes(loprocesos.ProcId) IsNot Nothing And TreeView1.Nodes(loprocesos.ProcId).Nodes(loprocesos.loSubProcesos.SubProcId) IsNot Nothing And TreeView1.Nodes(loprocesos.ProcId).Nodes(loprocesos.loSubProcesos.SubProcId).Nodes(loprocesos.loSubProcesos.loSolicitudes.SolId) Is Nothing Then
                    If Len(loprocesos.loSubProcesos.loSolicitudes.SolId) > 0 Then
                        TreeView1.Nodes(loprocesos.ProcId).Nodes(loprocesos.loSubProcesos.SubProcId).Nodes.Add(loprocesos.loSubProcesos.loSolicitudes.SolId, loprocesos.loSubProcesos.loSolicitudes.SolNombre)
                    End If
                End If
            Next
        End If

        TreeView1.ExpandAll()
    End Sub
    Sub CargarProcedimientos(ByVal node As String)
        If Listaprocedimiento Is Nothing Then
            SubprocId = node
            Listaprocedimiento = MantenimientosBL.Instancia.procedimientosListarXSubProcId(SubprocId)
            
        Else
            If SubprocId <> Listaprocedimiento(0).SubProcId Then
                Listaprocedimiento = MantenimientosBL.Instancia.procedimientosListarXSubProcId(SubprocId)
              
            End If
        End If
        dtTablaProcedimientos.Clear()
        If Listaprocedimiento IsNot Nothing Then
            For Each loProcedimiento As EEProcedimientos In Listaprocedimiento
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

    End Sub
    Private Sub TreeView1_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If TreeView1.Nodes.Count > 0 Then

            Select Case e.Node.Level
                Case 0
                    'cboProceso.Properties.ReadOnly = True
                    'cboSubProceso.Properties.ReadOnly = True
                    'txtProcdId.Properties.ReadOnly = True
                    'cboProceso.ItemIndex = -1
                    'cboSubProceso.ItemIndex = -1
                    'cboArea.ItemIndex = -1
                    'cboCargo.ItemIndex = -1
                    'txtProcdId.Text = String.Empty
                    'TxtProcdNombre.Text = String.Empty
                    'txtProcdDescripcion.Text = String.Empty
                    'cboArea.EditValue = String.Empty
                    'cboCargo.EditValue = String.Empty
                    'chkProcdActivo.Checked = False
                    'txtNroDias.EditValue = String.Empty
                Case 1
                    'nuevo()
                    'cboProceso.Properties.ReadOnly = True
                    'cboSubProceso.Properties.ReadOnly = True
                    'txtProcdId.Properties.ReadOnly = True
                    'cboArea.ItemIndex = -1
                    'cboCargo.ItemIndex = -1
                    'txtNroDias.EditValue = 0
                    'cboProceso.EditValue = e.Node.Parent.Name
                    'cboSubProceso.EditValue = e.Node.Name
                Case 2
                    editar()
                    Dim loSolicitudes As EESolicitudes = Nothing
                    If e.Node.Name <> TxtSolId.EditValue Or SubprocId <> e.Node.Parent.Name Then
                        loSolicitudes = MantenimientosBL.Instancia.solicitudesMostrarXSolId_SubProcId(e.Node.Name, e.Node.Parent.Name)
                        If loSolicitudes IsNot Nothing Then
                            TxtSolId.Text = e.Node.Name
                            txtSolNombre.Text = e.Node.Text
                            txtSolDescripcion.Text = loSolicitudes.SolDescripcion
                            txtSolDocRef.Text = loSolicitudes.SolDocRef
                            dpFechaReg.Text = loSolicitudes.SolFechaReg
                            dpFechaSol.Text = loSolicitudes.SolFecha
                            cboSolEstado.EditValue = loSolicitudes.solestado
                        End If
                    End If

                    Dim ProcdId As String = MantenimientosBL.Instancia.procedimientosMovMostrarProcdIdXSolId(TxtSolId.Text)

                    CargarProcedimientos(e.Node.Parent.Name)
                    
                    btnGuardar.Enabled = False
                    btnAgregar.Enabled = False
                    If Listaprocedimiento IsNot Nothing Then
                        Dim Area As String = String.Empty

                        If tgAreaCargo IsNot Nothing Then
                            Area = tgAreaCargo.Substring(0, 3)
                        End If
                        For Each loProcedimientos As EEProcedimientos In Listaprocedimiento
                            If ProcdId = loProcedimientos.ProcdId And Area = loProcedimientos.TgAreaId Then
                                btnGuardar.Enabled = True
                                btnAgregar.Enabled = True
                                txtprocdNombre.Text = loProcedimientos.ProcdNombre
                                txtprocdNombre.Tag = loProcedimientos.ProcdId
                                cboArea.EditValue = loProcedimientos.TgAreaId
                                cboCargo.EditValue = loProcedimientos.TgCargoId
                                txtDiasMax.Text = loProcedimientos.ProcdMaxDia
                                Dim DiaHasta As Date = DateAdd(DateInterval.Day, txtDiasMax.EditValue, dpFechaSol.EditValue)
                                txtQuedan.Text = DateDiff(DateInterval.Day, EEComun.FechaServidor.Value, DiaHasta)
                                cboEstadoProc.EditValue = MantenimientosBL.Instancia.procedimientosMovMostrarEstadoXSolIdprocdId(TxtSolId.Text, ProcdId)
                                estadoProc = cboEstadoProc.EditValue
                                Exit For
                            End If
                        Next
                    End If

                    Dim movProcdId As String = String.Empty
                    Dim ListaProcedimientosMov As List(Of EEProcedimientosMov) = MantenimientosBL.Instancia.procedimientosMovListarXSolId(TxtSolId.Text)
                    dtTablaHistorialProcedimientos.Clear()
                    For Each loProcedimientoMov As EEProcedimientosMov In ListaProcedimientosMov
                        If loProcedimientoMov.ProcdId = ProcdId Then
                            movProcdId = loProcedimientoMov.MovProcdId
                        End If
                        dtTablaHistorialProcedimientos.LoadDataRow(New Object() {loProcedimientoMov.MovProcdId, _
                                                                                 loProcedimientoMov.ProcdNombre, _
                                                                                 loProcedimientoMov.ProcdDescripcion, _
                                                                                 loProcedimientoMov.procdMaxDia, _
                                                                                 loProcedimientoMov.FechaReg, _
                                                                                 loProcedimientoMov.FechaFin, _
                                                                                 loProcedimientoMov.TgArea, _
                                                                                 loProcedimientoMov.TgCargo, _
                                                                                 loProcedimientoMov.Persona}, True)
                      
                    Next
                    Dim ListaProcedimientosAct As List(Of EEProcedimientosAct) = MantenimientosBL.Instancia.procedimientosactXMovProcdId(movProcdId)
                    dtTablaActividades.Clear()
                    If ListaProcedimientosAct IsNot Nothing Then
                        For Each loProcedimientosAct As EEProcedimientosAct In ListaProcedimientosAct
                            dtTablaActividades.LoadDataRow(New Object() {loProcedimientosAct.Actividad, dtTablaActividades.Rows.Count + 1}, True)
                        Next
                    End If


            End Select
        End If
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

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        dtTablaActividades.LoadDataRow(New Object() {"", dtTablaActividades.Rows.Count + 1}, True)
    End Sub


 
    Private Sub cboEstadoProc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstadoProc.EditValueChanged
        If cboEstadoProc.EditValue IsNot Nothing And Len(estadoProc) > 0 Then
            If estadoProc = "02" And cboEstadoProc.EditValue = "01" Then
                SaimtMessageBox.mostrarAlertaInformativa("No se puede cambiar el estado Activo, a Pendiente")
            End If
        End If
    End Sub

    Private Sub gvHistorialProcedimientos_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvHistorialProcedimientos.RowClick
        Dim ListaProcedimientosAct As List(Of EEProcedimientosAct) = MantenimientosBL.Instancia.procedimientosactXMovProcdId(gvHistorialProcedimientos.GetRowCellValue(gvHistorialProcedimientos.GetSelectedRows(0), "movProcdId").ToString())
        dtTablaHistorialActividades.Clear()
        If ListaProcedimientosAct IsNot Nothing Then
            For Each loProcedimientosAct As EEProcedimientosAct In ListaProcedimientosAct
                dtTablaHistorialActividades.LoadDataRow(New Object() {loProcedimientosAct.Actividad, loProcedimientosAct.Nro}, True)
            Next
        End If

    End Sub

    'Private Sub cboAreaPM_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cboAreaPM.EditValue IsNot Nothing Then
    '        cboCargoPM.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
    '        cboCargoPM.Properties.DisplayMember = "TgNombre"
    '        cboCargoPM.Properties.ValueMember = "TgCodigo"
    '        cboCargoPM.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(84, cboAreaPM.EditValue & "0001")
    '        cboCargoPM.ItemIndex = 0
    '        tgAreaCargo = cboAreaPM.EditValue
    '    End If

    '    'tgAreaCargo = cboAreaPM.EditValue ' "01001"
    '    'perId = "00000343"
    '    ''Logistica
    '    'tgAreaCargo = "01801"
    '    'perId = "00000330"
    '    ''GG
    '    'tgAreaCargo = "10001"
    '    'perId = "00000306"
    '    ''GGI
    '    'tgAreaCargo = "140001"
    '    'perId = "00003489"
    '    ''DECOIN
    '    'tgAreaCargo = "0110001"
    '    'perId = "00000360"
    'End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        dpSolFechaI.Properties.ReadOnly = Not CheckEdit1.Checked
        dpSolFechaF.Properties.ReadOnly = Not CheckEdit1.Checked
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        cargarLista()
    End Sub
End Class