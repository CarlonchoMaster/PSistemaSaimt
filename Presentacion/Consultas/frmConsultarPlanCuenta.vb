Imports Entidades
Imports ReglasNegocio
Imports SaimtControles

Public Class frmConsultarPlanCuenta
    Dim AñoCriterio As String = String.Empty
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal criterioAño As String)
        AñoCriterio = criterioAño
        InitializeComponent()
    End Sub
#Region "Propiedades"
    Public Property PlanCId() As String
    Public Property PlanCAño() As String
    Public Property PlanCDescripcion() As String
    Public Property PlanCIdCompuesto() As String
#End Region

    Dim dtPlanCuenta As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtPlanCuenta.Columns.Add("planCId", GetType(String))
        dtPlanCuenta.Columns.Add("planCDescripcion", GetType(String))
        dtPlanCuenta.Columns.Add("planCAño", GetType(String))
    End Sub
#End Region

    Private Sub frmConsultarPlanCuenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultadoPlanCuenta.DataSource = dtPlanCuenta

        cboAñoPor.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAñoPor.Properties.DisplayMember = "TgNombre"
        cboAñoPor.Properties.ValueMember = "TgCodigo"
        cboAñoPor.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)

        If AñoCriterio <> String.Empty Then
            cboAñoPor.EditValue = AñoCriterio
            cboAñoPor.Properties.ReadOnly = True
        Else
            cboAñoPor.EditValue = CStr(Year(Now))
        End If

        cboCriterioPor.SelectedIndex = 0
        Me.cboTipoCuentaCriterio.Properties.ReadOnly = True
    End Sub

    Protected Overrides Sub buscar()
        Try
            GValorTextoBuscado = cboAñoPor.Text & txtBuscarPor.Text
            GCriterioBuscado = cboCriterioPor.SelectedIndex
            Dim ListaPlanCuenta As List(Of EEPlanCuenta) = MantenimientosBL.Instancia.plancuentaListarCriterio(GCriterioBuscado, GValorTextoBuscado)
            dtPlanCuenta.Clear()
            If ListaPlanCuenta IsNot Nothing Then
                For Each frow As EEPlanCuenta In ListaPlanCuenta
                    dtPlanCuenta.LoadDataRow(New Object() {frow.PlanCId, _
                        frow.PlanCDescripcion, _
                        frow.PlanCAño
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

    Protected Overrides Sub seleccionar()
        If Me.gvResultado.DataRowCount <> 0 Then
            PlanCId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "planCId").ToString()
            PlanCDescripcion = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "planCDescripcion").ToString()
            PlanCAño = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "planCAño").ToString()
            PlanCIdCompuesto = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "planCAño").ToString() & gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "planCId").ToString()
            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub cboCriterio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCriterioPor.SelectedIndexChanged
        txtBuscarPor.Properties.ReadOnly = True
        GValorTextoBuscado = Nothing
        If cboCriterioPor.SelectedIndex = 2 Then
            cboAñoPor.ItemIndex = 0
        ElseIf cboCriterioPor.SelectedIndex = 3 Then
            cboTipoCuentaCriterio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoCuentaCriterio.Properties.DisplayMember = "TgNombre"
            cboTipoCuentaCriterio.Properties.ValueMember = "TgCodigo"
            cboTipoCuentaCriterio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(131)
            cboTipoCuentaCriterio.ItemIndex = -1
        ElseIf cboCriterioPor.SelectedIndex = 4 Then
            cboTipoCuentaCriterio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoCuentaCriterio.Properties.DisplayMember = "TgNombre"
            cboTipoCuentaCriterio.Properties.ValueMember = "TgCodigo"
            cboTipoCuentaCriterio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(132)
            cboTipoCuentaCriterio.ItemIndex = -1
        End If

        If cboCriterioPor.SelectedIndex < 2 Then
            txtBuscarPor.Properties.ReadOnly = False
            cboTipoCuentaCriterio.Properties.ReadOnly = True
            cboTipoCuentaCriterio.Properties.DataSource = Nothing
            cboTipoCuentaCriterio.ItemIndex = -1
            GCriterioBuscado = cboCriterioPor.SelectedIndex
            GValorTextoBuscado = cboAñoPor.Text
        ElseIf cboCriterioPor.SelectedIndex > 2 Then
            cboTipoCuentaCriterio.Properties.ReadOnly = False
            GCriterioBuscado = cboCriterioPor.SelectedIndex
            GValorTextoBuscado = cboAñoPor.Text & cboTipoCuentaCriterio.Text
        End If

    End Sub

    Private Sub cboTipoCuentaCriterio_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoCuentaCriterio.EditValueChanged
        If GValorTextoBuscado IsNot Nothing Then
            GCriterioBuscado = cboCriterioPor.SelectedIndex
            GValorTextoBuscado = cboAñoPor.Text & cboTipoCuentaCriterio.EditValue
            buscar()
        End If
    End Sub

    Private Sub cboAñoPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cboCriterioPor.SelectedIndex = 2 Then
            If cboAñoPor.Text <> "" Then
                GCriterioBuscado = cboCriterioPor.SelectedIndex
                GValorTextoBuscado = cboAñoPor.Text
                buscar()
            End If
        End If
    End Sub
End Class