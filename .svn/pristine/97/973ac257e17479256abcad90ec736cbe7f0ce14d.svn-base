Imports SaimtControles
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Public Class frmGeneral
    Inherits XtraForm

    ''' <summary>
    ''' Almacena el Valor del Texto Buscado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property GValorTextoBuscado() As String
    Public Property GValorCriterioBuscado() As String
    ''' <summary>
    ''' Almacena el Valor del Criterio Buscado
    ''' </summary>
    ''' <remarks></remarks>
    Public Property GCriterioBuscado() As Int16
    ''' <summary>
    ''' Almacena el Indice Seleccionado del Listado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property GIndiceSeleccionado() As Int32

    Public Property GIdRegistroActual() As Object
    ''' <summary>
    ''' Indica True = Guardar , False = Actualizar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Property GEstadoNuevo() As Boolean
    Public buttonTooltip As ToolTip = Nothing

    Public Property GMensajePermiso As String = "Usted no tiene Permiso para ejecutar esta acción. Consulte a Sistemas."

#Region "Propiedades"
    Public Property IdUsuarioOnline() As Int32
    Public Property PuedeCrear() As Boolean
    Public Property PuedeEditar() As Boolean
    Public Property PuedeEliminar() As Boolean
    Public Property PuedeImprimir() As Boolean
    Public Property PuedeBuscar() As Boolean
    Public Property PuedeImportar() As Boolean
    Public Property PuedeVisualizar() As Boolean
    Public Property PuedeEnviar() As Boolean
    Public Property PuedeVincular() As Boolean
    Public Property PuedeDesvincular() As Boolean
    Public Property PuedeVerDetalle() As Boolean
    Public Property PuedeConfirmar() As Boolean
    Public Property PuedeExportar() As Boolean
#End Region

    ''' <summary>
    ''' Agregar Tooltip a Botones
    ''' </summary>
    ''' <param name="oButton">Button</param>
    ''' <param name="asTitle">Titulo del Tooltip</param>
    ''' <param name="asMensaje">Descripcion del Tooltip</param>
    Public Sub mGSetearTool(ByVal oButton As Control, ByVal asTitle As String, ByVal asMensaje As String)
        buttonTooltip = New ToolTip()
        buttonTooltip.ToolTipTitle = asTitle
        buttonTooltip.ToolTipIcon = ToolTipIcon.Info
        buttonTooltip.UseFading = True
        buttonTooltip.UseAnimation = True
        buttonTooltip.SetToolTip(oButton, asMensaje)
    End Sub

#Region "Mensajes"
    Protected Sub mostrarMensajeBarra(ByVal asMensaje As [String])
        bsiMensaje.Caption = asMensaje
    End Sub
#End Region

    Private Sub frmGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

#Region "Habilitacion de Controles"
    ''' <summary>
    ''' Habilita o Deshabilita los Controles del Formulario Cargado
    ''' </summary>
    ''' <param name="aControles">Controles</param>
    ''' <param name="blnEstado">True = Desbloqueado, False = Bloqueado</param>
    ''' <remarks></remarks>
    Public Sub hodControlesTotal(ByVal aControles As Control.ControlCollection, ByVal blnEstado As Boolean)
        For Each fControl As Control In aControles
            controles(fControl, blnEstado)
        Next
    End Sub

    Public Sub controles(ByVal aControl As Control, ByVal blnEstado As Boolean)

        Dim tag As String = String.Empty
        If TypeOf aControl Is SaimtTextBox Then
            If Not DirectCast(aControl, SaimtTextBox).Name.Equals("txtBuscarSaimt") Then
                tag = DirectCast(aControl, SaimtTextBox).Tag
                If tag <> "NotClear" Then
                    If tag Is Nothing Or tag = String.Empty Then
                        DirectCast(aControl, SaimtTextBox).Properties.ReadOnly = Not blnEstado
                    End If
                End If
            End If
        ElseIf TypeOf aControl Is MemoEdit Then
            DirectCast(aControl, MemoEdit).Properties.ReadOnly = Not blnEstado
        ElseIf TypeOf aControl Is SaimtCheckBox Then
            If DirectCast(aControl, SaimtCheckBox).Tag <> "NotClear" Then
                DirectCast(aControl, SaimtCheckBox).Properties.ReadOnly = Not blnEstado
            End If
        ElseIf TypeOf aControl Is SaimtButton Then
            tag = DirectCast(aControl, SaimtButton).Tag
            If tag <> "NotClear" Then
                If tag Is Nothing Or tag = String.Empty Then
                    DirectCast(aControl, SaimtButton).Enabled = blnEstado
                End If
            End If
            ' DirectCast(aControl, SaimtButton).Enabled = blnEstado
        ElseIf TypeOf aControl Is SaimtDateTimePicker Then
            DirectCast(aControl, SaimtDateTimePicker).Properties.ReadOnly = Not blnEstado
        ElseIf TypeOf aControl Is SaimtSpinner Then
            DirectCast(aControl, SaimtSpinner).Properties.ReadOnly = Not blnEstado
        ElseIf TypeOf aControl Is SaimtTextBoxMultiline Then
            DirectCast(aControl, SaimtTextBoxMultiline).Properties.ReadOnly = Not blnEstado
        ElseIf TypeOf aControl Is SaimtListBox Then
            If DirectCast(aControl, SaimtListBox).Tag Is Nothing Then
                If Not DirectCast(aControl, SaimtListBox).Name.Equals("lstListado") Then
                    DirectCast(aControl, SaimtListBox).Appearance.BackColor = Color.WhiteSmoke
                End If
            End If
        ElseIf TypeOf aControl Is SaimtDataGrid Then
            If DirectCast(aControl, SaimtDataGrid).Tag Is Nothing Then
                If Not DirectCast(aControl, SaimtDataGrid).Name.Equals("dgvListado") Then
                    DirectCast(aControl, SaimtDataGrid).Enabled = True
                End If
            End If
        ElseIf TypeOf aControl Is SaimtDateTimePicker Then
            DirectCast(aControl, SaimtDateTimePicker).Properties.ReadOnly = Not blnEstado
        ElseIf TypeOf aControl Is MemoExEdit Then
            DirectCast(aControl, MemoExEdit).Properties.ReadOnly = Not blnEstado
        ElseIf TypeOf aControl Is SaimtComboBoxLookUp Then
            If DirectCast(aControl, SaimtComboBoxLookUp).Tag IsNot Nothing Then
                DirectCast(aControl, SaimtComboBoxLookUp).Properties.ReadOnly = False
            Else
                DirectCast(aControl, SaimtComboBoxLookUp).Properties.ReadOnly = Not blnEstado
            End If
        ElseIf TypeOf aControl Is SaimtComboBox Then
            If DirectCast(aControl, SaimtComboBox).Tag IsNot Nothing Then
                DirectCast(aControl, SaimtComboBox).Properties.ReadOnly = False
            Else
                DirectCast(aControl, SaimtComboBox).Properties.ReadOnly = Not blnEstado
            End If
        ElseIf TypeOf aControl Is SaimtComboBoxLookUpUpdate Then
            DirectCast(aControl, SaimtComboBoxLookUpUpdate).cboUpdate.Properties.ReadOnly = Not blnEstado
            DirectCast(aControl, SaimtComboBoxLookUpUpdate).btnUpdateCbo.Enabled = blnEstado
        ElseIf TypeOf aControl Is SaimtDataGrid Then
            DirectCast(aControl, SaimtDataGrid).Enabled = True
        ElseIf TypeOf aControl Is SaimtTimeEdit Then
            DirectCast(aControl, SaimtTimeEdit).Properties.ReadOnly = Not blnEstado
        ElseIf TypeOf aControl Is SaimtRadioGroup Then
            If DirectCast(aControl, SaimtRadioGroup).Tag IsNot Nothing Then
                DirectCast(aControl, SaimtRadioGroup).Properties.ReadOnly = Not blnEstado
            End If
        ElseIf TypeOf aControl Is SaimtButtonEdit Then
            DirectCast(aControl, SaimtButtonEdit).Properties.ReadOnly = Not blnEstado
        Else
            For Each fChild As Control In aControl.Controls
                controles(fChild, blnEstado)
            Next
        End If
    End Sub
#End Region
    ''' <summary>
    ''' RETORNA VALOR NULL SI ES QUE EL OBJECT ES NULL
    ''' </summary>
    ''' <param name="loValor">Valor a Verificar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function mGVerificarNull(ByVal loValor As Object) As String
        If String.IsNullOrEmpty(loValor.ToString()) Then
            Return Nothing
        Else
            Return loValor.ToString()
        End If
    End Function

    ''' <summary>
    ''' Para se usado cuando se herada directo de frmGeneral
    ''' </summary>
    ''' <param name="Controles">Coleccion de Controles</param>
    ''' <remarks></remarks>
    Public Sub GLimpiarControlesTotal(ByVal Controles As Control.ControlCollection)
        For Each fControl As Control In Controles
            GLimpiarControles(fControl)
        Next
    End Sub

    Private Sub GLimpiarControles(ByVal aControl As Control)
        If TypeOf aControl Is SaimtTextBox Then
            DirectCast(aControl, SaimtTextBox).Text = String.Empty
            DirectCast(aControl, SaimtTextBox).Tag = String.Empty
        ElseIf TypeOf aControl Is SaimtTextBoxMultiline Then
            DirectCast(aControl, SaimtTextBoxMultiline).Text = String.Empty
        ElseIf TypeOf aControl Is MemoExEdit Then
            DirectCast(aControl, MemoExEdit).Text = String.Empty
        ElseIf TypeOf aControl Is MemoEdit Then
            DirectCast(aControl, MemoEdit).Text = String.Empty
        ElseIf TypeOf aControl Is SaimtCheckBox Then
            DirectCast(aControl, SaimtCheckBox).Checked = True
        ElseIf TypeOf aControl Is SaimtDateTimePicker Then
            DirectCast(aControl, SaimtDateTimePicker).Text = Nothing
        ElseIf TypeOf aControl Is SaimtListBox Then
            DirectCast(aControl, SaimtListBox).DataSource = Nothing
        Else
            For Each fChild As Control In aControl.Controls
                GLimpiarControles(fChild)
            Next
        End If
    End Sub
    ''' <summary>
    ''' Mostrar Exception Obligatoria
    ''' </summary>
    ''' <param name="lsCampo">Nombre Campo</param>
    ''' <remarks></remarks>
    Public Sub mGExceptionObligatorio(ByVal lsCampo As String)
        Throw New Exception("El Campo " & lsCampo & " es obligatorio")
    End Sub
End Class