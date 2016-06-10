Imports SaimtControles
Imports Entidades
Imports ReglasNegocio

Public Class frmConsultaPersonaUsuarios
    Inherits frmConsultas

#Region "Propiedades"
    Public Property PerId() As String
    Public Property PerUsuario() As String
#End Region

    Dim oTable As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        oTable.Columns.Add("perId", GetType(String))
        oTable.Columns.Add("perNombres", GetType(String))
        oTable.Columns.Add("perApePaterno", GetType(String))
        oTable.Columns.Add("perApeMaterno", GetType(String))
        oTable.Columns.Add("perNDoc", GetType(String))

        oTable.Columns("perId").ColumnMapping = MappingType.Hidden
        oTable.Columns("perNombres").Caption = "Nombres"
        oTable.Columns("perApePaterno").Caption = "Apellido Paterno"
        oTable.Columns("perApeMaterno").Caption = "Apellido Materno"
        oTable.Columns("perNDoc").Caption = "Nro. Documento"
    End Sub
#End Region

    Private Sub frmConsultaPersonaUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = oTable
    End Sub

    Protected Overrides Sub buscar()
        Try
            Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaConsultarPersonaUsuario(txtBuscar.Text)
            oTable.Clear()
            If ListaPersona IsNot Nothing Then
                For Each fPersona As EEPersona In ListaPersona
                    oTable.LoadDataRow(New Object() {fPersona.PerId, _
                    fPersona.PerNombres, _
                    fPersona.PerApePaterno,
                    fPersona.PerApeMaterno,
                    fPersona.PerNDoc
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
            PerUsuario = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perApePaterno").ToString() & " " & _
                         gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perApeMaterno").ToString() & " " & _
                         gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perNombres").ToString()

            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub
End Class