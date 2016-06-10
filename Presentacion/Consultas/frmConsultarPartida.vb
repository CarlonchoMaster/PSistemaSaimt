Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmConsultarPartida
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
    Public Property PartId() As String
    Public Property PartNombre() As String
    Public Property PartAño As String
    Public Property tgPartTipId As String
    Public Property tgPartTipo As String
    Public Property PartIdCompuesta() As String
    Public Property PartPIM() As Decimal
#End Region

    Dim oTable As DataTable = New DataTable()

    Private Sub ConstruirTable()
        oTable.Columns.Add("partId", GetType(String))
        oTable.Columns.Add("partNombre", GetType(String))
        oTable.Columns.Add("partAño", GetType(String))
        oTable.Columns.Add("tgPartTipId", GetType(String))
        oTable.Columns.Add("tgPartTipo", GetType(String))
        oTable.Columns.Add("partPIM", GetType(Decimal))
    End Sub

    Protected Overrides Sub buscar()
        Try
            Dim ListaPartida As List(Of EEPartida) = MantenimientosBL.Instancia.partidaListarCriterio(cbAño.EditValue, cbBuscarPor.SelectedIndex, txtBuscar.EditValue)
            oTable.Clear()
            If ListaPartida IsNot Nothing Then
                For Each fPartida As EEPartida In ListaPartida
                    oTable.LoadDataRow(New Object() {fPartida.PartId, _
                    fPartida.PartNombre, _
                    fPartida.PartAño,
                    fPartida.TgPartTipoId,
                    fPartida.TgPartTipo}, True)
                Next
                Me.Encontrado = True
            Else
                Me.Encontrado = False
            End If
            MyBase.buscar()
            Me.gvResultadosPartida.BestFitColumns()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub seleccionar()
        If Me.gvResultadosPartida.DataRowCount <> 0 Then
            PartId = gvResultadosPartida.GetRowCellValue(Me.gvResultadosPartida.GetSelectedRows(0), "partId").ToString()
            PartNombre = gvResultadosPartida.GetRowCellValue(Me.gvResultadosPartida.GetSelectedRows(0), "partNombre").ToString()
            PartAño = gvResultadosPartida.GetRowCellValue(Me.gvResultadosPartida.GetSelectedRows(0), "partAño").ToString()
            tgPartTipId = gvResultadosPartida.GetRowCellValue(Me.gvResultadosPartida.GetSelectedRows(0), "tgPartTipId").ToString()
            tgPartTipo = gvResultadosPartida.GetRowCellValue(Me.gvResultadosPartida.GetSelectedRows(0), "tgPartTipo").ToString()
            'PartPIM = gvResultadosPartida.GetRowCellValue(Me.gvResultadosPartida.GetSelectedRows(0), "partPIM").ToString()
            ''PartIdCompuesta = PartAño & PartId

            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub




    Private Sub frmConsultarPartida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        gcResultadosPartida.DataSource = oTable
        cbAño.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cbAño.Properties.DisplayMember = "TgNombre"
        cbAño.Properties.ValueMember = "TgCodigo"
        cbAño.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)

        If AñoCriterio <> String.Empty Then
            cbAño.EditValue = AñoCriterio
            cbAño.Properties.ReadOnly = True
        Else
            cbAño.EditValue = CStr(Year(Now))
        End If

        cbBuscarPor.SelectedIndex = 0
    End Sub
End Class