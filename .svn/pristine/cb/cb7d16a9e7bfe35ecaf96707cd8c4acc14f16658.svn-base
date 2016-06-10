Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Public Class frmCompProgramacion
    Property Serie As String
    Property Numero As String

    ReadOnly vProPagId As String
    ReadOnly lsTipoComprobante As String
    ReadOnly lsSerie As String
    ReadOnly lsNumero As String

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Sub New(ProPagId As String, asTipoComprobante As String, asNroComprobante As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vProPagId = ProPagId
        If asTipoComprobante.Length > 1 Then
            If asTipoComprobante = "Boleta" Then
                lsTipoComprobante = "B"
            Else
                lsTipoComprobante = "F"
            End If
        Else
            lsTipoComprobante = asTipoComprobante
        End If

        If asNroComprobante <> "" Then
            lsSerie = asNroComprobante.Split("-")(0)
            lsNumero = asNroComprobante.Split("-")(1)
        End If
    End Sub

    Private Sub frmCompProgramacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'nuevo()
        Try
            'hodControlesTotal(SaimtGroupBox1.Controls, True)
            cboTipoComprobante.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboTipoComprobante.Properties.DisplayMember = "TgNombre"
            cboTipoComprobante.Properties.ValueMember = "TgCodigo"
            cboTipoComprobante.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(36)
            cboTipoComprobante.ItemIndex = 0

            txtProPaId.Text = vProPagId
            txtProPaId.Properties.ReadOnly = True
            cboTipoComprobante.EditValue = lsTipoComprobante
            cboTipoComprobante.Properties.ReadOnly = True
            txtSerie.Text = lsSerie
            txtNroComp.Text = lsNumero

            'Dim ListaCompProgramacion As List(Of EECompProgramacion) = MantenimientosBL.Instancia.compprogramacionExiste(vProPagId)
            'If ListaCompProgramacion IsNot Nothing Then
            '    For Each lcp As EECompProgramacion In ListaCompProgramacion
            '        txtProPaId.Text = lcp.ProPaId
            '        txtSerie.Text = lcp.CompProPagSerie
            '        txtNroComp.Text = lcp.CompProPagNro
            '        'cboTipoComprobante.EditValue = lcp.TgTipoCompId
            '    Next
            'End If

            txtSerie.Properties.ReadOnly = False
            txtNroComp.Properties.ReadOnly = False
            btnguardar.Enabled = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Dim loCompProgramacion As EECompProgramacion = New EECompProgramacion()
        Dim NroInsert As Integer = 0
        If txtProPaId.Text.Length = 0 Then
            SaimtMessageBox.mostrarAlertaInformativa("Ingrese el Nro de Programacion ID de Comprobante")
            Return
        End If
        If txtSerie.Text.Length = 0 Then
            SaimtMessageBox.mostrarAlertaInformativa("Ingrese el nro de Serie del Comprobante")
            Return
        End If
        If txtNroComp.Text.Length = 0 Then
            SaimtMessageBox.mostrarAlertaInformativa("Ingrese el nro del Comprobante")
            Return
        End If

        loCompProgramacion.CompProPagSerie = txtSerie.Text.Trim
        loCompProgramacion.CompProPagNro = txtNroComp.Text.Trim
        loCompProgramacion.ProPaId = txtProPaId.Text.Trim
        loCompProgramacion.TgEstCompId = "EP"
        loCompProgramacion.TgTipoCompId = IIf(cboTipoComprobante.Text.Trim = "Boleta", "B", "F")
        If MantenimientosBL.Instancia.compprogramacionGuardar(loCompProgramacion) = True Then
            SaimtMessageBox.mostrarAlertaInformativa("Se guardo correctamente")
            Serie = txtSerie.Text.Trim
            Numero = txtNroComp.Text.Trim
            DialogResult = DialogResult.OK
        End If
        MyBase.guardar()
    End Sub
End Class