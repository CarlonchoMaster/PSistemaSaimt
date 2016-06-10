Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmNuevaCarp
    Inherits frmMantenimientos
    Dim level As Int16 = 0
    Dim namePadre As String = String.Empty
    Dim _opcion As String = String.Empty
    Dim IdPadre As String = String.Empty
    Dim _IdNodo As String = String.Empty
    Sub New(ByVal nivel As Int16, ByVal NodoPadre As String, ByVal NodoIDPadre As String, ByVal opcion As String, Optional ByVal IdNodo As String = "")

        level = nivel
        namePadre = NodoPadre
        IdPadre = NodoIDPadre
        _opcion = opcion
        _IdNodo = IdNodo
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Protected Overrides Sub editar()
        txtNivel.Properties.ReadOnly = True
        txtPadre.Properties.ReadOnly = True
        txtCodigo.Properties.ReadOnly = True
        txtPadre.Text = namePadre
        txtPadre.Tag = IdPadre
        txtNivel.Text = level
        txtCodigo.Text = _IdNodo
        MyBase.editar()
    End Sub

    Protected Overrides Sub nuevo()
        txtNivel.Properties.ReadOnly = True
        txtPadre.Properties.ReadOnly = True
        txtCodigo.Properties.ReadOnly = True
        txtPadre.Text = namePadre
        txtPadre.Tag = IdPadre
        txtNivel.Text = level + 1
        txtCodigo.Text = MantenimientosBL.Instancia.jerarquiaarchNewCodigo
        MyBase.nuevo()
    End Sub

    Sub guardar_()
        If Len(Trim(txtNombre.Text)) = 0 Then
            SaimtMessageBox.mostrarAlertaInformativa("Ingrese el Nombre del Nivel")
            txtNombre.Focus()
            Return
        End If
        Dim loJerarquia As New EEJerarquiaArch
        loJerarquia.JerId = txtCodigo.Text
        loJerarquia.JerNombre = txtNombre.Text
        loJerarquia.JerDescripcion = txtDescripcion.Text
        loJerarquia.JerNivel = txtNivel.EditValue
        loJerarquia.JerIcono = cboColor.EditValue
        loJerarquia.JerPadre = txtPadre.Tag
        If _opcion = "new" Then
            MantenimientosBL.Instancia.jerarquiaarchGuardar(loJerarquia)
            SaimtMessageBox.mostrarAlertaInformativa("Se Guardo Correctamente")
        ElseIf _opcion = "update" Then
            MantenimientosBL.Instancia.jerarquiaarchActualizar(loJerarquia)
            SaimtMessageBox.mostrarAlertaInformativa("Se Actualizo Correctamente")
        End If

        Me.Close()

    End Sub

    Private Sub frmNuevaCarp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 40
            cboColor.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem("color " & i + 1, i, i))
        Next
        cboColor.Properties.SmallImages = IconosArchivo
        cboColor.SelectedIndex = cboColor.Properties.Items.Count - 1
        Select Case _opcion
            Case "new"
                nuevo()
            Case "update"
                editar()
        End Select
    End Sub

 
    Private Sub btnGuardar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        guardar_()
    End Sub
End Class