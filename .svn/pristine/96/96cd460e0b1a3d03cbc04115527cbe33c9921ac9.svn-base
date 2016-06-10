Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmConsultaTablaGeneral
    Inherits frmConsultas
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private ReadOnly lsClsId As String
    Private ReadOnly lstgExtraId As String

    Public Sub New(clsID As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lsClsId = clsID
    End Sub

    Public Sub New(clsID As String, tgExtraID As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lstgExtraId = tgExtraID
        lsClsId = clsID
    End Sub
#Region "Propiedades"
    Public Property TgCodigo() As String
    Public Property TgNombre() As String
    Public Property TgSiglas() As String
    Public Property TgDescripcion() As String
#End Region

    Dim dtTableGeneral As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtTableGeneral.Columns.Add("tgCodigo", GetType(String))
        dtTableGeneral.Columns.Add("tgNombre", GetType(String))
        dtTableGeneral.Columns.Add("tgAbrev", GetType(String))
        dtTableGeneral.Columns.Add("tgDescripcion", GetType(String))
    End Sub
#End Region

    Private Sub frmConsultaConyuge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = dtTableGeneral

        'If lstgExtraId IsNot Nothing Then
        '    CbotgExtra.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        '    CbotgExtra.Properties.DisplayMember = "TgNombre"
        '    CbotgExtra.Properties.ValueMember = "TgCodigo"
        '    CbotgExtra.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(lsClsId, lstgExtraId)
        '    CbotgExtra.ItemIndex = 0
        '    CbotgExtra.Visible = True
        'Else
        '    CbotgExtra.Visible = False
        'End If
    
    End Sub

    Protected Overrides Sub buscar()
        Try
            Dim ListaTablaGeneral As List(Of EETablaGeneral)
            Dim tipocriterio As Int16
            Select Case cboBuscarPor.SelectedIndex
                Case 0
                    tipocriterio = 1
                Case 1
                    tipocriterio = 3
            End Select
            If lstgExtraId IsNot Nothing Then

                ListaTablaGeneral = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraListarCriterio(lsClsId, lstgExtraId, tipocriterio, txtBuscar.Text)

            Else
          
                ListaTablaGeneral = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(lsClsId, tipocriterio, txtBuscar.Text)

            End If
            dtTableGeneral.Clear()
            If ListaTablaGeneral IsNot Nothing Then
                For Each fTableGeneral As EETablaGeneral In ListaTablaGeneral
                    dtTableGeneral.LoadDataRow(New Object() {fTableGeneral.TgCodigo, _
                    fTableGeneral.TgNombre, _
                    fTableGeneral.TgAbrev, _
                    fTableGeneral.TgDescripcion
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
            TgCodigo = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgCodigo").ToString()
            TgNombre = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgNombre").ToString()
            TgSiglas = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgAbrev").ToString()
            TgDescripcion = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgDescripcion").ToString()
            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub

    Private Sub gvResultado_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvResultado.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.btnSeleccionar.PerformClick()
        End If
    End Sub


    Private Sub gvResultado_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gvResultado.DoubleClick
        Me.btnSeleccionar.PerformClick()
    End Sub

End Class