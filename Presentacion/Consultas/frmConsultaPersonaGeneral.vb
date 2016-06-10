﻿Imports Entidades
Imports ReglasNegocio
Imports SaimtControles

Public Class frmConsultaPersonaGeneral
    Inherits frmConsultas

#Region "Propiedades"
    Public Property PerId() As String
    Public Property PerNombre() As String
    Public Property PerTipo() As String
    Public Property PerTipoDoc() As String
    Public Property PerDireccion() As String
    Public Property perNdoc() As String
    Public Property PerObs() As String
    Public Property OContacto As String
    Public Property perDistrito As String
    Public Property perProvincia As String
    Public Property perDepartamento As String
#End Region

    Private Property TipoPersona As Int16?
    Dim dtPersona As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtPersona.Columns.Add("perId", GetType(String))
        dtPersona.Columns.Add("persona", GetType(String))
        dtPersona.Columns.Add("tgTipoPersId", GetType(String))
        dtPersona.Columns.Add("tgTipoDoc", GetType(String))
        dtPersona.Columns.Add("perNdoc", GetType(String))
        dtPersona.Columns.Add("contacto", GetType(String))
        dtPersona.Columns.Add("perDireccion", GetType(String))
        dtPersona.Columns.Add("perObservacion", GetType(String))
        dtPersona.Columns.Add("perDistrito", GetType(String))
        dtPersona.Columns.Add("perProvincia", GetType(String))
        dtPersona.Columns.Add("perDepartamento", GetType(String))

        dtPersona.Columns("perId").ColumnMapping = MappingType.Hidden
        dtPersona.Columns("persona").Caption = "Persona"
        dtPersona.Columns("contacto").Caption = "Contacto"
        dtPersona.Columns("tgTipoPersId").Caption = "Tipo Per"
        dtPersona.Columns("tgTipoDoc").Caption = "Tipo Doc"
        dtPersona.Columns("perNdoc").Caption = "Documento"
        dtPersona.Columns("perDireccion").Caption = "Direccion"
        dtPersona.Columns("perObservacion").Caption = "Observacion"
        dtPersona.Columns("perDistrito").Caption = "perDistrito"
        dtPersona.Columns("perProvincia").Caption = "perProvincia"
        dtPersona.Columns("perDepartamento").Caption = "perDepartamento"
    End Sub
#End Region

    ''' <summary>
    ''' ABRE LA CONSULTA SEGUN EL TIPO PERSONA
    ''' </summary>
    ''' <param name="aiTipoPersona">1=PERSONA NATURAL, 2=PERSONA JURIDICA, 3=AMBOS</param>
    ''' <remarks></remarks>
    Public Sub New(aiTipoPersona As Int16)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        TipoPersona = aiTipoPersona
    End Sub

    Private Sub frmConsultaPersonaCriterio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvResultado.DataSource = dtPersona

        cboCriterioConsulta.Properties.Items.Clear()
        If TipoPersona = 1 Then
            cboCriterioConsulta.Properties.Items.Add("Buscar por DNI")
            cboCriterioConsulta.Properties.Items.Add("Buscar por Apellidos y Nombres")
            cboCriterioConsulta.SelectedIndex = 1
        ElseIf TipoPersona = 2 Then
            cboCriterioConsulta.Properties.Items.Add("Buscar por RUC")
            cboCriterioConsulta.Properties.Items.Add("Buscar por Razon Social")
            cboCriterioConsulta.SelectedIndex = 1
        ElseIf TipoPersona = 3 Then
            cboCriterioConsulta.Properties.Items.Add("Buscar por DNI")
            cboCriterioConsulta.Properties.Items.Add("Buscar por Apellidos y Nombres")
            cboCriterioConsulta.Properties.Items.Add("Buscar por RUC")
            cboCriterioConsulta.Properties.Items.Add("Buscar por Razon Social")
            cboCriterioConsulta.SelectedIndex = 1
        End If
    End Sub

    Protected Overrides Sub buscar()
        Try
            Dim ListaPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaConsultarGeneral(TipoPersona, cboCriterioConsulta.SelectedIndex, txtBuscar.Text)
            dtPersona.Clear()
            If ListaPersona IsNot Nothing Then
                For Each fPersona As EEPersona In ListaPersona
                    dtPersona.LoadDataRow(New Object() {fPersona.PerId, _
                    fPersona.Persona, _
                    fPersona.TgTipoPersId, _
                    fPersona.TgDocumento, _
                    fPersona.PerNDoc,
                    fPersona.PerContacto, _
                    fPersona.PerDireccion,
                    fPersona.PerObservacion,
                    fPersona.PerDistrito, fPersona.PerProvincia, fPersona.PerDepartamento
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
            PerNombre = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "persona").ToString()
            perNdoc = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perNdoc").ToString()
            PerTipo = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgTipoPersId").ToString()
            PerTipoDoc = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "tgTipoDoc").ToString()
            PerDireccion = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perDireccion").ToString()
            PerObs = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perObservacion").ToString()
            Me.OContacto = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "contacto").ToString()
            perDistrito = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perDistrito").ToString()
            perProvincia = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perProvincia").ToString()
            perDepartamento = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "perDepartamento").ToString()

            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub

   
End Class