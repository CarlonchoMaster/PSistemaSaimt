Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmSeleccionCargoSTD
    Inherits frmConsultas
    Public Sub New(EECargoPersonal As List(Of EECargoPersonal))
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ListaCargoPersonal = EECargoPersonal
    End Sub
#Region "Propiedades"
    Public Property ListaCargoPersonal As List(Of EECargoPersonal)
    Public Property CarPerId As String
#End Region

    Private Sub frmConsultaConyuge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ListaCargoPersonal IsNot Nothing Then
            LstCargos.DataSource = ListaCargoPersonal
            LstCargos.DisplayMember = "Cargo"
            LstCargos.ValueMember = "CarPerId"
            LstCargos.SelectedIndex = 0
        End If
    End Sub
    Protected Overrides Sub seleccionar()
        If Me.LstCargos.Items.Count <> 0 Then
            CarPerId = LstCargos.SelectedItems(0)
            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub
    
    Private Sub btnSeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionar.Click
        If Me.LstCargos.SelectedItems(0) IsNot Nothing Then
            CarPerId = LstCargos.SelectedValue
            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
    End Sub
End Class