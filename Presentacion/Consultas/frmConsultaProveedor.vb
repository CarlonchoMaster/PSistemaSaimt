Imports Entidades
Imports SaimtControles
Imports ReglasNegocio

Public Class frmConsultaProveedor
    Inherits frmConsultas

#Region "Propiedades"
    Public Property PerId() As String
    Public Property PerProveedor() As String
    Public Property PerRUC() As String
    Public Property PerDireccion() As String
#End Region

    Dim oTable As DataTable = New DataTable()

    Private Sub ConstruirTable()
        oTable.Columns.Add("perId", GetType(String))
        oTable.Columns.Add("perRazonSocial", GetType(String))
        oTable.Columns.Add("TgTipoDoc", GetType(String))
        oTable.Columns.Add("perNDoc", GetType(String))
        oTable.Columns.Add("perDireccion", GetType(String))

        oTable.Columns("perId").ColumnMapping = MappingType.Hidden
        oTable.Columns("perRazonSocial").Caption = "Razon Social"
        oTable.Columns("TgTipoDoc").Caption = "Tipo Doc"
        oTable.Columns("perNDoc").Caption = "Nro Doc"
        oTable.Columns("perDireccion").Caption = "Dirección"
    End Sub

    Private Sub frmConsultaProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = oTable

        cboCriterioConsulta.Properties.Items.Add("Buscar por RUC")
        cboCriterioConsulta.Properties.Items.Add("Buscar por Razon Social")
        cboCriterioConsulta.SelectedIndex = 1
    End Sub

    Protected Overrides Sub buscar()
        Try
            Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaConsultarProveedorCriterios(cboCriterioConsulta.SelectedIndex, txtBuscar.Text)
            oTable.Clear()
            If ListaPersona IsNot Nothing Then
                For Each fPersona As EEPersona In ListaPersona
                    oTable.LoadDataRow(New Object() {fPersona.PerId, _
                    fPersona.PerRazonSocial, _
                    fPersona.TgTipoDoc, _
                    fPersona.PerNDoc, _
                    fPersona.PerDireccion
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

            PerId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perId").ToString()
            PerProveedor = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perRazonSocial").ToString()
            PerRUC = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perNDoc").ToString()
            PerDireccion = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perDireccion").ToString()

            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub
End Class