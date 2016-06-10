Imports SaimtControles
Imports DevExpress.XtraEditors

Public Class frmPopup
    Inherits frmGeneral

#Region "Enumerado Botones y Listado"
    ''' <summary>
    ''' Tipo de botones.
    ''' </summary>
    Protected Enum Botones
        '''<sumary>
        '''Boton Nuevo
        '''</sumary>
        Nuevo
        '''<sumary>
        '''Boton Guardar
        '''</sumary>
        Guardar
    End Enum
#End Region

#Region "Controles Formulario Saimt Para Luego Asignar"
    Private _ButtonNuevo As SaimtButton
    Public Property ButtonNuevo() As SaimtButton
        Get
            Return _ButtonNuevo
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonNuevo = value
        End Set
    End Property

    Private _ButtonEditar As SaimtButton
    Public Property ButtonEditar() As SaimtButton
        Get
            Return _ButtonEditar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonEditar = value
        End Set
    End Property

    Private _ButtonGuardar As SaimtButton
    Public Property ButtonGuardar() As SaimtButton
        Get
            Return _ButtonGuardar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonGuardar = value
        End Set
    End Property
#End Region

    Private Sub frmPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.ButtonNuevo IsNot Nothing Then
            AddHandler Me.ButtonNuevo.Click, AddressOf ButtonNuevo_Click
            mGSetearTool(ButtonNuevo, "Nuevo", "Generar Nuevo Registro")
        End If
        If Me.ButtonGuardar IsNot Nothing Then
            AddHandler Me.ButtonGuardar.Click, AddressOf ButtonGuardar_Click
            mGSetearTool(ButtonGuardar, "Guardar", "Guardar nuevo registro y/o cambios efectuados")
        End If
        hodControlesTotal(Me.Controls, False)
        Me.ActivarBotones(True, False)
    End Sub

#Region "Metodos Botones"
    Protected Overridable Sub nuevo()
        Me.GEstadoNuevo = True
        Me.GIdRegistroActual = 0
        limpiarControlesTotal(ActiveForm.Controls)
        hodControlesTotal(ActiveForm.Controls, True)
        ActivarBoton(Botones.Nuevo)
    End Sub

    ''' <summary>
    ''' Para Indicar Despues del Guardado o Actualizar 
    ''' el enabled de los controles
    ''' </summary>
    Public enabledGA As [Boolean]
    Protected Overridable Sub guardar()
        If Me.GEstadoNuevo Then
            'mostrarAlertaInformativa("Se Guardo Correctamente");
            mostrarMensajeBarra("Se Guardo Correctamente")
        Else
            Me.GIdRegistroActual = 0
            'mostrarAlertaInformativa("Se Actualizo Correctamente");
            mostrarMensajeBarra("Se Actualizo Correctamente")
        End If
        hodControlesTotal(Me.Controls, enabledGA)
        ActivarBoton(Botones.Guardar)
    End Sub
#End Region

#Region "Eventos Handler"
    Private Sub ButtonNuevo_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.nuevo()
    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.guardar()
    End Sub
#End Region

#Region "Activado y Desactivado de Botones"
    Protected Sub ActivarBotones(ByVal blnNuevo As Boolean, ByVal blnGuardar As Boolean)
        If Me._ButtonNuevo IsNot Nothing Then
            Me._ButtonNuevo.Enabled = blnNuevo
        End If
        If Me._ButtonGuardar IsNot Nothing Then
            Me._ButtonGuardar.Enabled = blnGuardar
        End If
    End Sub

    Protected Sub ActivarBoton(ByVal boton As Botones)
        Select Case boton
            Case Botones.Nuevo
                Me.ActivarBotones(False, True)
                Exit Select
            Case Botones.Guardar
                Me.ActivarBotones(True, False)
                Exit Select
        End Select
    End Sub
#End Region

    '#Region "Habilitacion de Controles"
    '    Public Sub hodControlesTotal(ByVal Controles__1 As Control.ControlCollection, ByVal blnEstado As Boolean)
    '        For Each ctrl As Control In Controles__1
    '            If TypeOf ctrl Is SaimtTextBox Then
    '                DirectCast(ctrl, SaimtTextBox).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtCheckBox Then
    '                DirectCast(ctrl, SaimtCheckBox).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtButton Then
    '                DirectCast(ctrl, SaimtButton).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtDateTimePicker Then
    '                DirectCast(ctrl, SaimtDateTimePicker).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtSpinner Then
    '                DirectCast(ctrl, SaimtSpinner).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtSpinner Then
    '                DirectCast(ctrl, SaimtSpinner).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtGroupBox Then
    '                If ctrl.Controls.Count > 0 Then
    '                    controles(ctrl.Controls, blnEstado)
    '                End If
    '            End If
    '        Next
    '    End Sub

    '    Public Sub controles(ByVal Controles__1 As Control.ControlCollection, ByVal blnEstado As Boolean)
    '        For Each ctrl As Control In Controles__1
    '            If TypeOf ctrl Is SaimtTextBox Then
    '                DirectCast(ctrl, SaimtTextBox).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtCheckBox Then
    '                DirectCast(ctrl, SaimtCheckBox).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtTextBoxMultiline Then
    '                DirectCast(ctrl, SaimtTextBoxMultiline).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtTabs Then
    '                DirectCast(ctrl, SaimtTabs).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtButton Then
    '                DirectCast(ctrl, SaimtButton).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtDateTimePicker Then
    '                DirectCast(ctrl, SaimtDateTimePicker).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtTextBoxMultiline Then
    '                DirectCast(ctrl, SaimtTextBoxMultiline).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtComboBoxLookUp Then
    '                DirectCast(ctrl, SaimtComboBoxLookUp).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtComboBoxLookUpUpdate Then
    '                DirectCast(ctrl, SaimtComboBoxLookUpUpdate).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtDataGrid Then
    '                DirectCast(ctrl, SaimtDataGrid).Enabled = blnEstado
    '            ElseIf TypeOf ctrl Is SaimtGroupBox Then
    '                If ctrl.Controls.Count > 0 Then
    '                    controles(ctrl.Controls, blnEstado)
    '                End If
    '            End If
    '        Next
    '    End Sub
    '#End Region

#Region "Limpiado de Controles"
    Public Sub limpiarControlesTotal(ByVal Controles As Control.ControlCollection)
        For Each fControl As Control In Controles
            LimpiarControles(fControl)
        Next
        Me.GIdRegistroActual = 0
        mostrarMensajeBarra("")
    End Sub

    Private Sub LimpiarControles(ByVal aControl As Control)
        If TypeOf aControl Is SaimtTextBox Then
            DirectCast(aControl, SaimtTextBox).Text = String.Empty
        ElseIf TypeOf aControl Is SaimtTextBoxMultiline Then
            DirectCast(aControl, SaimtTextBoxMultiline).Text = String.Empty
        ElseIf TypeOf aControl Is MemoExEdit Then
            DirectCast(aControl, MemoExEdit).Text = String.Empty
        ElseIf TypeOf aControl Is SaimtCheckBox Then
            DirectCast(aControl, SaimtCheckBox).Checked = True
        ElseIf TypeOf aControl Is SaimtDateTimePicker Then
            DirectCast(aControl, SaimtDateTimePicker).Text = Nothing
        ElseIf TypeOf aControl Is SaimtListBox Then
            DirectCast(aControl, SaimtListBox).DataSource = Nothing
        ElseIf TypeOf aControl Is SaimtComboBoxLookUp Then
            If CType(aControl, SaimtComboBoxLookUp).Properties.DataSource IsNot Nothing Then
                DirectCast(aControl, SaimtComboBoxLookUp).ItemIndex = 0
            End If
        ElseIf TypeOf aControl Is SaimtComboBoxLookUpUpdate Then
            If CType(aControl, SaimtComboBoxLookUpUpdate).cboUpdate.Properties.DataSource IsNot Nothing Then
                DirectCast(aControl, SaimtComboBoxLookUpUpdate).cboUpdate.ItemIndex = 0
            End If
        Else
            For Each fChild As Control In aControl.Controls
                LimpiarControles(fChild)
            Next
        End If
    End Sub
#End Region
End Class
