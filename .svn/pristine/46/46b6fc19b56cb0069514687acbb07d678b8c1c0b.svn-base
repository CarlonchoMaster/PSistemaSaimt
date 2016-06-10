Imports SaimtControles
Imports Entidades
Imports ReglasNegocio

Public Class frmConsultaInmueblePrincipal
    Inherits frmConsultas

#Region "Propiedades"
    Public Property InmId() As String
    Public Property InmFile() As String
#End Region

    Dim oTable As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        oTable.Columns.Add("inmId", GetType(String))
        oTable.Columns.Add("inmFile", GetType(String))
        oTable.Columns.Add("inmDenominacion", GetType(String))
        'oTable.Columns.Add("tgViaNombre", GetType(String))
        oTable.Columns.Add("inmDirUbicacion", GetType(String))
        'oTable.Columns.Add("inmDirLocalizacion", GetType(String))
        'oTable.Columns.Add("inmDirNro", GetType(String))
        'oTable.Columns.Add("inmDirManz", GetType(String))
        'oTable.Columns.Add("inmDirLote", GetType(String))
        'oTable.Columns.Add("inmDirSubLote", GetType(String))
        'oTable.Columns.Add("inmDirFase", GetType(String))
        'oTable.Columns.Add("inmDirEtapa", GetType(String))
        'oTable.Columns.Add("inmDirReferencia", GetType(String))

        oTable.Columns("inmId").ColumnMapping = MappingType.Hidden
        oTable.Columns("inmFile").Caption = "File"
        oTable.Columns("inmDenominacion").Caption = "Denominacion"
        oTable.Columns("inmDirUbicacion").Caption = "Dirección del Inmueble"
        'oTable.Columns("tgViaNombre").Caption = "Via"
        'oTable.Columns("inmDirLocalizacion").Caption = "Localizacion"
        'oTable.Columns("inmDirNro").Caption = "Nro"
        'oTable.Columns("inmDirManz").Caption = "Manzana"
        'oTable.Columns("inmDirLote").Caption = "Lote"
        'oTable.Columns("inmDirSubLote").Caption = "Sub Lote"
        'oTable.Columns("inmDirFase").Caption = "Fase"
        'oTable.Columns("inmDirEtapa").Caption = "Etapa"
        'oTable.Columns("inmDirReferencia").Caption = "Referencia"
    End Sub
#End Region

    Private Sub frmConsultaInmuebleDivision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = oTable
    End Sub

    Protected Overrides Sub buscar()
        Try
            Dim ListaInmueble As List(Of EEInmueble) = Nothing
            If rdbCriterios.SelectedIndex = 0 Then
                ListaInmueble = MantenimientosBL.Instancia.inmuebleListarBCriterio(, , , , , , txtBuscar.Text)
            End If
            If rdbCriterios.SelectedIndex = 1 Then
                ListaInmueble = MantenimientosBL.Instancia.inmuebleListarBCriterio(, , , , txtBuscar.Text, , )
            End If
            If rdbCriterios.SelectedIndex = 2 Then
                ListaInmueble = MantenimientosBL.Instancia.inmuebleListarBCriterio(, , txtBuscar.Text, , , , )
            End If
            oTable.Clear()
            If ListaInmueble IsNot Nothing Then
                For Each fInmueble As EEInmueble In ListaInmueble
                    oTable.LoadDataRow(New Object() {fInmueble.InmId, _
                    fInmueble.InmFile, _
                    fInmueble.InmDenominacion, _
                    fInmueble.InmUbicacion
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
            InmId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "inmId").ToString()
            InmFile = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "inmFile").ToString()
            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
    End Sub


End Class