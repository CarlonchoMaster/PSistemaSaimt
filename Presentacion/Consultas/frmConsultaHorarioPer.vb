Imports Entidades
Imports ReglasNegocio
Imports SaimtControles

Public Class frmConsultaHorarioPer
    Inherits frmConsultas

#Region "Propiedades"
    Public Property HorId() As Int32
    Public Property HorDescripcion() As String
    Public Property HorEntrada() As String
    Public Property HorRecesoIni() As String
    Public Property HorRecesoFin() As String
    Public Property HorSalida() As String
#End Region

    Dim dtHorarioPer As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtHorarioPer.Columns.Add("horId", GetType(Int32))
        dtHorarioPer.Columns.Add("horDescripcion", GetType(String))
        dtHorarioPer.Columns.Add("horEntrada", GetType(String))
        dtHorarioPer.Columns.Add("horRecesoIni", GetType(String))
        dtHorarioPer.Columns.Add("horRecesoFin", GetType(String))
        dtHorarioPer.Columns.Add("horSalida", GetType(String))

        dtHorarioPer.Columns("horId").Caption = "Cod. Horario"
        dtHorarioPer.Columns("horDescripcion").Caption = "Descripcion"
        dtHorarioPer.Columns("horEntrada").Caption = "H. Entrada"
        dtHorarioPer.Columns("horRecesoIni").Caption = "H. Salida Refrigerio"
        dtHorarioPer.Columns("horRecesoFin").Caption = "H. Entrada Refrigerio"
        dtHorarioPer.Columns("horSalida").Caption = "H. Salida"
    End Sub
#End Region

    Private Sub frmConsultaHorarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = dtHorarioPer
    End Sub

    Protected Overrides Sub buscar()
        Try
            Dim ListaHorarioPer As List(Of EEHorarioPer) = MantenimientosBL.Instancia.horarioperConsultarHorario(txtBuscar.Text)
            dtHorarioPer.Clear()
            If ListaHorarioPer IsNot Nothing Then
                For Each fHorarioPer As EEHorarioPer In ListaHorarioPer
                    dtHorarioPer.LoadDataRow(New Object() {fHorarioPer.HorId, _
                        fHorarioPer.HorDescripcion, _
                        String.Format("{0:hh:mm tt}", fHorarioPer.HorEntrada), _
                        String.Format("{0:hh:mm tt}", fHorarioPer.HorRecesoIni), _
                        String.Format("{0:hh:mm tt}", fHorarioPer.HorRecesoFin), _
                        String.Format("{0:hh:mm tt}", fHorarioPer.HorSalida)
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
            HorId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "horId").ToString()
            HorDescripcion = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "horDescripcion").ToString()
            HorEntrada = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "horEntrada").ToString()
            HorRecesoIni = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "horRecesoIni").ToString()
            HorRecesoFin = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "horRecesoFin").ToString()
            HorSalida = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "horSalida").ToString()

            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub

End Class
