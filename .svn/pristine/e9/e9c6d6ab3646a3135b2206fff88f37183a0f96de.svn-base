Imports ReglasNegocio
Imports SaimtControles
Imports Entidades

Public Class frmConsultaContratosEnProgramacionPagos
    Inherits frmConsultas

#Region "Propiedades"
    Public Property ConInmId() As String
    Public Property InmId() As String
    Public Property InmDir() As String
    Public Property PerId() As String
    Public Property ConInmFecIni() As String
    Public Property ConInmFecFin() As String
    Public Property TgUsoId() As String
    Public Property TgNombreUso() As String
    Public Property TgEstId() As String
    Public Property TgNombreEstado() As String
    Public Property TgMonId() As String
    Public Property TgNombreMoneda() As String
    Public Property TgModId() As String
    Public Property TgNombreModalidad() As String
    Public Property Persona() As String
    Public Property PerNroDocumento() As String
    Public Property TgTipoPersId() As String
    Public Property ConInmGarantia() As String
    Public Property ConInmDerLlaves() As String
    Public Property ConInmMerced() As String
    Public Property TgCompId() As String
    Public Property TgNombreComprobante() As String
#End Region

    Dim dtContrato As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtContrato.Columns.Add("conInmId", GetType(String))
        dtContrato.Columns.Add("inmId", GetType(String))
        dtContrato.Columns.Add("inmDirCon", GetType(String))
        dtContrato.Columns.Add("perId", GetType(String))
        dtContrato.Columns.Add("conInmFecIni", GetType(String))
        dtContrato.Columns.Add("conInmFecFin", GetType(String))
        dtContrato.Columns.Add("tgUsoId", GetType(String))
        dtContrato.Columns.Add("tgNombreUso", GetType(String))
        dtContrato.Columns.Add("tgEstId", GetType(String))
        dtContrato.Columns.Add("tgNombreEstado", GetType(String))
        dtContrato.Columns.Add("tgMonId", GetType(String))
        dtContrato.Columns.Add("tgNombreMoneda", GetType(String))
        dtContrato.Columns.Add("tgModId", GetType(String))
        dtContrato.Columns.Add("tgNombreModalidad", GetType(String))
        dtContrato.Columns.Add("persona", GetType(String))
        dtContrato.Columns.Add("perNDoc", GetType(String))
        dtContrato.Columns.Add("tgTipoPersId", GetType(String))
        dtContrato.Columns.Add("conInmGarantia", GetType(String))
        dtContrato.Columns.Add("conInmDerLlaves", GetType(String))
        dtContrato.Columns.Add("conInmMerced", GetType(String))
        dtContrato.Columns.Add("tgCompId", GetType(String))
        dtContrato.Columns.Add("tgNombreComprobante", GetType(String))
    End Sub
#End Region

    Private Sub frmConsultaContratosEnProgramacionPagos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = dtContrato
    End Sub

#Region "Funciones Sobreescritas"
    Protected Overrides Sub buscar()
        Try
            Dim ListaContrato As List(Of EEContratoInm) = MantenimientosBL.Instancia.contratoListarCriterioEnConsultaContratoPP(rgbCriterios.EditValue, txtBuscar.Text)
            dtContrato.Clear()
            If ListaContrato IsNot Nothing Then
                For Each fContrato As EEContratoInm In ListaContrato
                    dtContrato.LoadDataRow(New Object() {fContrato.ConInmId, _
                        fContrato.InmId, _
                        fContrato.InmDir, _
                        fContrato.OPersona.PerId, _
                        fContrato.ConInmFecIni, _
                        fContrato.ConInmFecFin, _
                        fContrato.OTgUso.TgCodigo, _
                        fContrato.OTgUso.TgNombre, _
                        fContrato.OTgEstado.TgCodigo, _
                        fContrato.OTgEstado.TgNombre, _
                        fContrato.OTgMoneda.TgCodigo, _
                        fContrato.OTgMoneda.TgNombre, _
                        fContrato.OTgModalidad.TgCodigo, _
                        fContrato.OTgModalidad.TgNombre, _
                        fContrato.OPersona.perNombresoRazon, _
                        fContrato.OPersona.PerNDoc, _
                        fContrato.OPersona.TgTipoPersId, _
                        fContrato.ConInmGarantia, _
                        fContrato.ConInmDerLlaves, _
                        fContrato.ConInmMerced,
                        fContrato.OTgComprobante.TgCodigo, _
                        fContrato.OTgComprobante.TgNombre
                    }, True)
                Next
                gvResultado.BestFitColumns()
                Me.Encontrado = True
            Else
                Me.Encontrado = False
            End If
            MyBase.buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub seleccionar()
        If Me.gvResultado.DataRowCount <> 0 Then
            ConInmId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "conInmId").ToString()
            InmId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "inmId").ToString()
            InmDir = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "inmDirCon").ToString()
            PerId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perId").ToString()
            ConInmFecIni = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "conInmFecIni").ToString()
            ConInmFecFin = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "conInmFecFin").ToString()
            TgUsoId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgUsoId").ToString()
            TgNombreUso = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgNombreUso").ToString()
            TgEstId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgEstId").ToString()
            TgNombreEstado = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgNombreEstado").ToString()
            TgMonId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgMonId").ToString()
            TgNombreMoneda = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgNombreMoneda").ToString()
            TgModId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgModId").ToString()
            TgNombreModalidad = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgNombreModalidad").ToString()
            Persona = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "persona").ToString()
            PerNroDocumento = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perNDoc").ToString()
            TgTipoPersId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgTipoPersId").ToString()
            ConInmGarantia = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "conInmGarantia").ToString()
            ConInmDerLlaves = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "conInmDerLlaves").ToString()
            ConInmMerced = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "conInmMerced").ToString()
            TgCompId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgCompId").ToString()
            TgNombreComprobante = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgNombreComprobante").ToString()

            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub
#End Region

End Class