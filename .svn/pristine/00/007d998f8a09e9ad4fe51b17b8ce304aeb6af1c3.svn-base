Imports Entidades
Imports SaimtControles
Imports ReglasNegocio

Public Class frmConsultaTrabajador
    Inherits frmConsultas

#Region "Propiedades"
    Public Property PerId() As String
    Public Property PerTrabajador() As String
    Public Property PerTraFecInicio() As String
    Public Property PerTraFecFin() As String
    Public Property PerModalidad() As String
    Public Property PerSucursal() As String
    Public Property PerHorario() As String
#End Region

    Dim oTable As DataTable = New DataTable()


    Private Sub ConstruirTable()
        oTable.Columns.Add("ConTrabId", GetType(String))
        oTable.Columns.Add("Persona", GetType(String))
        oTable.Columns.Add("ConTrabFecInicio", GetType(Date))
        oTable.Columns.Add("ConTrabFecFin", GetType(Date))
        oTable.Columns.Add("Modalidad", GetType(String))
        oTable.Columns.Add("Sucursal", GetType(String))
        oTable.Columns.Add("Horario", GetType(String))

        oTable.Columns("ConTrabId").ColumnMapping = MappingType.Hidden
        oTable.Columns("Persona").Caption = "Persona"
        oTable.Columns("ConTrabFecInicio").Caption = "Fecha Inicio"
        oTable.Columns("ConTrabFecFin").Caption = "Fecha Fin"
        oTable.Columns("Modalidad").Caption = "Modalidad"
        oTable.Columns("Sucursal").Caption = "Sucursal"
        oTable.Columns("Horario").Caption = "Horario"
    End Sub

    Private Sub frmConsultaProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = oTable

        cboCriterioConsulta.Properties.Items.Add("Buscar por Fecha Inicio Contrato")
        cboCriterioConsulta.Properties.Items.Add("Buscar por Apellidos y Nombres")
        cboCriterioConsulta.SelectedIndex = 1
    End Sub

    Protected Overrides Sub buscar()
        Try
            Dim ListaContratoPersonal As List(Of EEContratoPersonal) = MantenimientosBL.Instancia.contratopersonalListarCriterio(cboCriterioConsulta.SelectedIndex, txtBuscar.Text)
            oTable.Clear()
            If ListaContratoPersonal IsNot Nothing Then
                For Each fContratoPersonal As EEContratoPersonal In ListaContratoPersonal
                    oTable.LoadDataRow(New Object() {fContratoPersonal.ConTrabId, _
                         fContratoPersonal.Trabajador, _
                         fContratoPersonal.ConTrabFecInicio, _
                         fContratoPersonal.ConTrabFecFin, _
                         fContratoPersonal.OTgTipoContrato.TgNombre, _
                         fContratoPersonal.Sucursal, _
                         fContratoPersonal.HorarioNombre
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

            PerId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "ConTrabId").ToString()
            PerTrabajador = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "Persona").ToString()
            PerTraFecInicio = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "ConTrabFecInicio").ToString()
            PerTraFecFin = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "ConTrabFecFin").ToString()
            PerModalidad = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "Modalidad").ToString()
            PerSucursal = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "Sucursal").ToString()
            PerHorario = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "Horario").ToString()

            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub
End Class