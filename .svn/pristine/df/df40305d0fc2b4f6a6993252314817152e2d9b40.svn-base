Imports SaimtControles

Public Class frmConsultas
    Inherits frmGeneral

    Public Property Encontrado() As Boolean
    Public Property Seleccionado() As Boolean

#Region "Controles"
    Private _ButtonBuscar As SaimtButton
    Public Property ButtonBuscar() As SaimtButton
        Get
            Return _ButtonBuscar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonBuscar = value
        End Set
    End Property

    Private _ButtonSeleccionar As SaimtButton
    Public Property ButtonSeleccionar() As SaimtButton
        Get
            Return _ButtonSeleccionar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonSeleccionar = value
        End Set
    End Property

    Private _SaimtGrid As SaimtDataGrid
    Public Property SaimtGrid() As SaimtDataGrid
        Get
            Return _SaimtGrid
        End Get
        Set(ByVal value As SaimtDataGrid)
            _SaimtGrid = value
        End Set
    End Property
#End Region

    Private Sub frmConsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.ButtonBuscar IsNot Nothing Then
            AddHandler Me.ButtonBuscar.Click, AddressOf ButtonBuscar_Click
            Me.AcceptButton = Me.ButtonBuscar
        End If
        If Me.ButtonSeleccionar IsNot Nothing Then
            AddHandler Me.ButtonSeleccionar.Click, AddressOf ButtonSeleccionar_Click
        End If
        If Me.SaimtGrid IsNot Nothing Then
            AddHandler Me.SaimtGrid.DoubleClick, AddressOf SaimtGrid_DoubleClick
        End If
    End Sub

    Private Sub ButtonBuscar_Click(ByVal sender As Object, ByVal e As EventArgs)
        buscar()
    End Sub

    Private Sub ButtonSeleccionar_Click(ByVal sender As Object, ByVal e As EventArgs)
        seleccionar()
    End Sub

    Private Sub SaimtGrid_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        ButtonSeleccionar.PerformClick()
    End Sub

    Protected Overridable Sub buscar()
        If Encontrado = False Then
            mostrarMensajeBarra("No Se Encontraron Resultados")
        Else
            mostrarMensajeBarra("")
        End If
    End Sub

    Protected Overridable Sub seleccionar()
        If Seleccionado = False Then
            mostrarMensajeBarra("Seleccione una Fila")
        End If
    End Sub
End Class