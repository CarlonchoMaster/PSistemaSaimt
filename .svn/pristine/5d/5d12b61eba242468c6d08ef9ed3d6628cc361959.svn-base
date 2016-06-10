Imports SaimtControlesWeb
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors

Public Class GeneralWeb
    Inherits XtraForm
    ''' <summary>
    ''' Almacena el Valor del Texto Buscado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property GValorTextoBuscado() As String
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
    ''' 
    ''' 
    ''' 
    ''' 
    ''' 
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Property GEstadoNuevo() As Boolean
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

#Region "Habilitacion de Controles"
    ''' <summary>
    ''' Habilita o Deshabilita los Controles del Formulario Cargado
    ''' </summary>
    ''' <param name="aControles">Controles</param>
    ''' <param name="blnEstado">True = Desbloqueado, False = Bloqueado</param>
    ''' <remarks></remarks>
    Public Sub hodControlesTotal(ByVal aControles As UI.ControlCollection, ByVal blnEstado As Boolean)
        For Each fControl As Control In aControles
            controles(fControl, blnEstado)
        Next
    End Sub


    Public Sub controles(ByVal aControl As Control, ByVal blnEstado As Boolean)
        If TypeOf aControl Is SaimtASPxTextBox Then
            If DirectCast(aControl, SaimtASPxTextBox).ID.Equals("txtBuscarSaimt") Then
                DirectCast(aControl, SaimtASPxTextBox).Enabled = blnEstado
            Else
                DirectCast(aControl, SaimtASPxTextBox).Enabled = Not blnEstado
            End If
        ElseIf TypeOf aControl Is SaimtASPxCheckBox Then
            DirectCast(aControl, SaimtASPxCheckBox).Enabled = Not blnEstado

        ElseIf TypeOf aControl Is SaimtASPxComboBox Then
            DirectCast(aControl, SaimtASPxComboBox).Enabled = Not blnEstado

        ElseIf TypeOf aControl Is SaimtASPxButton Then
            DirectCast(aControl, SaimtASPxButton).Enabled = Not blnEstado

        ElseIf TypeOf aControl Is SaimtASPxDateTime Then
            DirectCast(aControl, SaimtASPxDateTime).ReadOnly = blnEstado

        ElseIf TypeOf aControl Is SaimtASPxDateEdit Then
            DirectCast(aControl, SaimtASPxDateEdit).Enabled = Not blnEstado

        ElseIf TypeOf aControl Is SaimtASPxSpinner Then
            DirectCast(aControl, SaimtASPxSpinner).ReadOnly = blnEstado

            For Each fChild As Control In aControl.Controls
                controles(fChild, blnEstado)
            Next
        End If
    End Sub
#End Region

#Region "Limpiar TEXT"
    ''' <summary>
    ''' LImpiar los text del Formulario Cargado
    ''' </summary>
    Public Sub linTextTotal(ByVal aText As UI.ControlCollection)
        For Each fText As Control In aText
            Texto(fText)
        Next
    End Sub


    Public Sub Texto(ByVal aText As Control)
        Try
            If TypeOf aText Is SaimtASPxTextBox Then
                If Not DirectCast(aText, SaimtASPxTextBox).ID.Equals("txtCodigo") Then
                    DirectCast(aText, SaimtASPxTextBox).Text = Nothing
                End If
            ElseIf TypeOf aText Is SaimtASPxDateTime Then
                DirectCast(aText, SaimtASPxDateTime).Value = Nothing

            ElseIf TypeOf aText Is SaimtASPxDateEdit Then
                DirectCast(aText, SaimtASPxDateEdit).Text = Nothing
                DirectCast(aText, SaimtASPxDateEdit).Value = Nothing

            ElseIf TypeOf aText Is SaimtASPxComboBox Then
                DirectCast(aText, SaimtASPxComboBox).Text = Nothing
                DirectCast(aText, SaimtASPxComboBox).Value = Nothing

            ElseIf TypeOf aText Is SaimtASPxSpinner Then
                DirectCast(aText, SaimtASPxSpinner).Text = Nothing
            End If
        Catch ex As Exception

        End Try


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
    ''' Mostrar Exception Obligatoria
    ''' </summary>
    ''' <param name="lsCampo">Nombre Campo</param>
    ''' <remarks></remarks>
    Public Sub mGExceptionObligatorio(ByVal lsCampo As String)
        Throw New Exception("El Campo " & lsCampo & " es obligatorio")
    End Sub




End Class




