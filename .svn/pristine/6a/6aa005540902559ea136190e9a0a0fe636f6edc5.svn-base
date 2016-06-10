
Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraTreeList.Nodes

Public Class frmVisualizadorTareas
    Inherits frmMantenimientos
    Private Sub dgvArchivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmVisualizadorTareas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PuedeBuscar = True
        PuedeCrear = True
        PuedeImprimir = True
        PuedeEditar = True
        cboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboArea.Properties.DisplayMember = "TgNombre"
        cboArea.Properties.ValueMember = "TgCodigo"
        cboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(83, "0001")
        cboArea.ItemIndex = 0
        cargarLista()
    End Sub


    Sub cargarLista()
        Dim ListaProcesos As List(Of EEProcesos) = MantenimientosBL.Instancia.solicitudesListarxTgAreaId(String.Empty)
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
                    MyBase.editar()
                    Dim loSolicitudes As EESolicitudes = MantenimientosBL.Instancia.solicitudesMostrarXSolId_SubProcId(e.Node.Name, e.Node.Parent.Name)
                    If loSolicitudes IsNot Nothing Then
                        TxtSolId.Text = e.Node.Name
                        txtSolNombre.Text = e.Node.Text
                        txtSolDescripcion.Text = loSolicitudes.SolDescripcion
                        txtSolDocRef.Text = loSolicitudes.SolDocRef
                        dpFechaReg.Text = loSolicitudes.SolFechaReg
                        dpFechaSol.Text = loSolicitudes.SolFecha
                    End If
                    Dim Listaprocedimiento As List(Of EEProcedimientos) = MantenimientosBL.Instancia.procedimientosListarXSubProcId(e.Node.Name)


            End Select
        End If
    End Sub

    Private Sub SaimtGroupBox4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SaimtGroupBox4.Paint

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
End Class