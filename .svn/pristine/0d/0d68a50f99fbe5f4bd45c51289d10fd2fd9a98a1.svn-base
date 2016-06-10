Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Public Class frmPivotRecaudacionDet
    Inherits frmMantenimientos
    Dim dtRecaudacionDet As DataTable = New DataTable()
    Dim ListaRecaudacionDet As List(Of EERecaudacionDet)
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private ReadOnly lsRecfecPag As Date
    Private ReadOnly lsRecGrupoIng As String
    Public Sub New(ByVal RecfecPag As Date, ByVal RecGrupoIng As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lsRecfecPag = RecfecPag
        lsRecGrupoIng = RecGrupoIng
    End Sub
    Private Sub frmRecaudacionDet_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        cmbGrupoIngresos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cmbGrupoIngresos.Properties.DisplayMember = "TgNombre"
        cmbGrupoIngresos.Properties.ValueMember = "TgCodigo"
        cmbGrupoIngresos.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(25)
        ricmbgrupoingreso.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(25)
        ricmbgrupoingreso.DisplayMember = "TgNombre"
        ricmbgrupoingreso.ValueMember = "TgCodigo"
        Me.dtpRecfecPago.Properties.ReadOnly = False
        dtpRecfecPago.DateTime = lsRecfecPag
        cmbGrupoIngresos.EditValue = lsRecGrupoIng
        cmbGrupoIngresos.Properties.ReadOnly = True
        cargardatos()
        hodControlesTotal(Me.Controls, True)
    End Sub

    Private Sub ConstruirTable()
        dtRecaudacionDet.Columns.Add("conid", GetType(String))
        dtRecaudacionDet.Columns.Add("concepto", GetType(String))
        dtRecaudacionDet.Columns.Add("montodep", GetType(Decimal))
        dtRecaudacionDet.Columns.Add("porsaimt", GetType(Decimal))
        dtRecaudacionDet.Columns.Add("ingsaimt", GetType(Decimal))
        dtRecaudacionDet.Columns.Add("fechaLiq", GetType(Date))
        dtRecaudacionDet.Columns.Add("tgGrupoConId", GetType(String))
        dtRecaudacionDet.Columns.Add("CuentaCargo", GetType(String))
        dtRecaudacionDet.Columns.Add("CuentaAbono", GetType(String))
    End Sub

    Sub cargardatos()
        Try
            ListaRecaudacionDet = MantenimientosBL.Instancia.RecaudacionDet_by_fechaPag_tgGrupoIng(dtpRecfecPago.DateTime, cmbGrupoIngresos.EditValue)
            dtRecaudacionDet.Clear()
            If ListaRecaudacionDet IsNot Nothing Then
                For Each fRecaudacionDet As EERecaudacionDet In ListaRecaudacionDet
                    dtRecaudacionDet.LoadDataRow(New Object() {fRecaudacionDet.ConId, fRecaudacionDet.Concepto, fRecaudacionDet.RecDMonto, fRecaudacionDet.ConPorcentaje, fRecaudacionDet.RecDTotalIng, fRecaudacionDet.RecDFechaLiquidacion, fRecaudacionDet.tgGrupoConId, fRecaudacionDet.pcontCuenC, fRecaudacionDet.pcontCuenA}, True)
                Next
                dgvRecaudacionDet.DataSource = dtRecaudacionDet
                Me.gvRecaudacionDet.BestFitColumns()
                Me.gvRecaudacionDet.ExpandAllGroups()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnrefrescar_Click(sender As System.Object, e As System.EventArgs) Handles btnrefrescar.Click
        cargardatos()
    End Sub
End Class