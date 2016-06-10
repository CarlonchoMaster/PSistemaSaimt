Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmExpediente
    Inherits frmMantenimientos
    Dim _opcion As String = String.Empty
    Dim _IdNodo As String = String.Empty
    Sub New(ByVal opcion As String, ByVal IdNodo As String)

        _opcion = opcion
        _IdNodo = IdNodo
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Protected Overrides Sub nuevo()
        txtJerId.Properties.ReadOnly = True
        txtJerId.Text = _IdNodo
        MyBase.nuevo()
    End Sub

    Sub guardar_()

        If Len(Trim(txtJerId.Text)) = 0 Then
            SaimtMessageBox.mostrarAlertaInformativa("Cargue nuevamente el formulario, No se encuentra el Codigo de Carpeta")
            txtExpSaimt.Focus()
            Return
        End If

        If Len(Trim(txtExpSaimt.Text)) = 0 Then
            SaimtMessageBox.mostrarAlertaInformativa("Ingrese el Codigo del Expediente")
            txtExpSaimt.Focus()
            Return
        End If

        Dim loExpediente As New EEExpedienteArch
        loExpediente.JerId = txtJerId.Text
        loExpediente.ExpSAIMT = txtExpSaimt.Text
        loExpediente.ExpObservaciones = txtObservacion.Text
        loExpediente.ExpNroFolios = txtNroFolios.EditValue
        loExpediente.ExpFechIng = dtFechaIng.EditValue
        'loExpediente.e
        If _opcion = "new" Then
            MantenimientosBL.Instancia.expedientearchGuardar(loExpediente)
            SaimtMessageBox.mostrarAlertaInformativa("Se Guardo Correctamente")
        ElseIf _opcion = "update" Then
            MantenimientosBL.Instancia.expedientearchActualizar(loExpediente)
            SaimtMessageBox.mostrarAlertaInformativa("Se Actualizo Correctamente")
        End If

        Me.Close()

    End Sub


    Private Sub frmExpediente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case _opcion
            Case "new"
                nuevo()
            Case "update"
                editar()
        End Select
    End Sub

    Private Sub BarLargeButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem4.ItemClick
        guardar_()
    End Sub
End Class