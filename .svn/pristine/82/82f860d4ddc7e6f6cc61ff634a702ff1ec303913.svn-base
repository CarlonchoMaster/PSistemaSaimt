Imports SaimtControles
Imports Entidades
Imports ReglasNegocio

Public Class frmConsultaInmueble
    Inherits frmConsultas

#Region "Propiedades"
    Public Property InmId() As String
    Public Property InmDir() As String
#End Region

    Dim oTable As DataTable

    Private Sub ConstruirTable()
        oTable = New DataTable
        oTable.Columns.Add("inmId", GetType(String))
        oTable.Columns.Add("inmFile", GetType(String))
        oTable.Columns.Add("inmDireccion", GetType(String))
        oTable.Columns.Add("inmDisponible", GetType(String))
        oTable.Columns.Add("estContrato", GetType(String))

        oTable.Columns("inmId").Caption = "Codigo"
        oTable.Columns("inmFile").Caption = "File"
        oTable.Columns("inmDireccion").Caption = "Dirección"
        oTable.Columns("inmDisponible").Caption = "Disponible"
        oTable.Columns("estContrato").Caption = "Con Contrato"

    End Sub

    Private Sub frmConsultaInmueble_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = oTable
    End Sub

    Protected Overrides Sub buscar()
        Dim fInmueble As EEInmueble
        Dim ListaInmueble As List(Of EEInmueble)
        Try
            ListaInmueble = MantenimientosBL.Instancia.inmuebleListarBCriterio_EnContrato(rdbBuscarPor.EditValue, txtBuscar.Text)

            oTable.Clear()
            If ListaInmueble IsNot Nothing Then
                For Each fInmueble In ListaInmueble

                    oTable.LoadDataRow(New Object() {fInmueble.InmId, _
                    fInmueble.InmFile, _
                 fInmueble.InmUbicacion, _
                   IIf(fInmueble.InmDisponibilidad = False, "NO", "SI"), fInmueble.InmEstContrato}, True)
                    'IIf(fInmueble.OInmDireccion.TgViaAbrev = "", "", fInmueble.OInmDireccion.TgViaAbrev) + IIf(fInmueble.OInmDireccion.InmDirLocalizacion = "", "", " " & fInmueble.OInmDireccion.InmDirLocalizacion) + IIf(fInmueble.OInmDireccion.InmDirNro = "", "", " N° " & fInmueble.OInmDireccion.InmDirNro) + IIf(fInmueble.OInmDireccion.InmDirNroInt = "", "", " Int." & fInmueble.OInmDireccion.InmDirNroInt) + IIf(fInmueble.OInmDireccion.InmDirManz.ToString = "", "", " Mz." + fInmueble.OInmDireccion.InmDirManz) + IIf(fInmueble.OInmDireccion.InmDirLote.ToString = "", "", " Lt." + fInmueble.OInmDireccion.InmDirLote) + IIf(fInmueble.OInmDireccion.InmDirSubLote.ToString = "", "", " Sub Lote: " + fInmueble.OInmDireccion.InmDirSubLote) + IIf(fInmueble.OInmDireccion.InmDirFase.ToString = "", "", " Fase: " + fInmueble.OInmDireccion.InmDirFase) + IIf(fInmueble.OInmDireccion.InmDirEtapa.ToString = "", "", " Etapa: " + fInmueble.OInmDireccion.InmDirEtapa) + IIf(fInmueble.OInmDireccion.InmDirReferencia.ToString = "", "", " Referencia: " + fInmueble.OInmDireccion.InmDirReferencia), _
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
            If gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "estContrato").ToString() = "SI" Then
                SaimtMessageBox.mostrarAlertaInformativa("El Inmueble Seleccionado Ya tiene un contrato disponible")
                Seleccionado = False
            Else
                InmId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "inmId").ToString.Trim
                InmDir = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "inmDireccion").ToString.Trim
                Seleccionado = True
                DialogResult = DialogResult.OK
            End If
        Else
            Seleccionado = False
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

    End Sub
End Class