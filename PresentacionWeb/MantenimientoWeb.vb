Imports SaimtControlesWeb

Public Class MantenimientoWeb
    Inherits GeneralWeb



#Region "Enumerado Botones y Listado"
    ''' <summary>
    ''' Tipo de botones.
    ''' </summary>
    Public Enum Botones
        '''<sumary>
        '''Boton Nuevo
        '''</sumary>
        Nuevo
        '''<sumary>
        '''Boton Editar
        '''</sumary>
        Editar
        '''<sumary>
        '''Boton Guardar
        '''</sumary>
        Guardar
        '''<sumary>
        '''Boton Eliminar
        '''</sumary>
        Eliminar
        '''<sumary>
        '''Boton Cancelar Nuevo
        '''</sumary>
        CancelarNuevo
        ''' <summary>
        ''' Boton Cancelar Editar
        ''' </summary>
        CancelarEditar
        ''' <summary>
        ''' Boton Cancelar Data
        ''' </summary>
        CancelarData
        '''<sumary>
        '''ListBox Listado
        '''</sumary>
        ListBoxListado

        Load

        Limpiar
    End Enum
#End Region

#Region "Controles Formulario Saimt Para Luego Asignar"
    Public Property ButtonNuevo() As SaimtASPxButton
    Public Property ButtonEditar() As SaimtASPxButton
    Public Property ButtonLimpiar() As SaimtASPxButton
    Public Property ButtonCancelar() As SaimtASPxButton
    Public Property ButtonCancelarData() As SaimtASPxButton
    Public Property ButtonGuardar() As SaimtASPxButton
    Public Property ButtonEliminar() As SaimtASPxButton
    Public Property ButtonImprimir() As SaimtASPxButton
    Public Property lstListado() As SaimtASPxListBox
    Public Property txtBuscarSaimt() As SaimtASPxTextBox
    Public Property ButtonImportar() As SaimtASPxButton
    Public Property ButtonVisualizar() As SaimtASPxButton
    Public Property ButtonEnviar() As SaimtASPxButton
    Public Property ButtonVincular() As SaimtASPxButton
    Public Property ButtonDesVincular() As SaimtASPxButton
    Public Property ButtonVerDetalle() As SaimtASPxButton
    Public Property ButtonConfirmar() As SaimtASPxButton
    Public Property ButtonExportar() As SaimtASPxButton

#End Region

#Region "Activado y Desactivado de Botones"

    Public Sub ActivarBoton(ByVal aControles As UI.ControlCollection, ByVal boton As Integer)

        Dim blnLimpiar As Boolean
        Dim blnNuevo As Boolean
        Dim blnEditar As Boolean
        Dim blnGuardar As Boolean
        Dim blnEliminar As Boolean
        Dim blnCancelar As Boolean
        Dim blnImprimir As Boolean
        Select Case boton
            Case Botones.Nuevo
                hodControlesTotal(aControles, False)
                linTextTotal(aControles)
                blnLimpiar = True
                blnNuevo = False
                blnEditar = False
                blnGuardar = True
                blnEliminar = False
                blnCancelar = True
                blnImprimir = True

                Exit Select
            Case Botones.Editar
                hodControlesTotal(aControles, False)
                blnLimpiar = True
                blnNuevo = False
                blnEditar = False
                blnGuardar = True
                blnEliminar = True
                blnCancelar = True
                blnImprimir = True

                Exit Select
            Case Botones.CancelarNuevo
                hodControlesTotal(aControles, True)
                linTextTotal(aControles)
                blnLimpiar = False
                blnNuevo = True
                blnEditar = False
                blnGuardar = False
                blnEliminar = False
                blnCancelar = False
                blnImprimir = True


                Exit Select
            Case Botones.CancelarEditar
                hodControlesTotal(aControles, True)
                linTextTotal(aControles)
                blnLimpiar = False
                blnNuevo = True
                blnEditar = True
                blnGuardar = False
                blnEliminar = True
                blnCancelar = False
                blnImprimir = True
                Exit Select
            Case Botones.Eliminar
                hodControlesTotal(aControles, True)
                linTextTotal(aControles)
                blnLimpiar = False
                blnNuevo = True
                blnEditar = False
                blnGuardar = False
                blnEliminar = False
                blnCancelar = False
                blnImprimir = True

                Exit Select
            Case Botones.Guardar
                hodControlesTotal(aControles, True)
                linTextTotal(aControles)
                blnLimpiar = False
                blnNuevo = True
                blnEditar = False
                blnGuardar = False
                blnEliminar = False
                blnCancelar = False
                blnImprimir = True

                Exit Select
            Case Botones.ListBoxListado
                hodControlesTotal(aControles, True)
                blnLimpiar = False
                blnNuevo = True
                blnEditar = True
                blnGuardar = False
                blnEliminar = True
                blnCancelar = False
                blnImprimir = True
                Exit Select

            Case Botones.Load
                hodControlesTotal(aControles, True)
                linTextTotal(aControles)
                blnLimpiar = False
                blnNuevo = True
                blnEditar = False
                blnGuardar = False
                blnEliminar = False
                blnCancelar = False
                blnImprimir = False

                Exit Select
        End Select
        For Each fControl As Control In aControles
            If TypeOf fControl Is SaimtASPxButton Then
                If DirectCast(fControl, SaimtASPxButton).ID = "btnLimpiar" Then
                    DirectCast(fControl, SaimtASPxButton).Enabled = blnLimpiar
                End If
                If DirectCast(fControl, SaimtASPxButton).ID = "btnNuevo" Then
                    DirectCast(fControl, SaimtASPxButton).Enabled = blnNuevo
                End If
                If DirectCast(fControl, SaimtASPxButton).ID = "btnEditar" Then
                    DirectCast(fControl, SaimtASPxButton).Enabled = blnEditar
                End If
                If DirectCast(fControl, SaimtASPxButton).ID = "btnGuardar" Then
                    DirectCast(fControl, SaimtASPxButton).Enabled = blnGuardar
                End If
                If DirectCast(fControl, SaimtASPxButton).ID = "btnEliminar" Then
                    DirectCast(fControl, SaimtASPxButton).Enabled = blnEliminar
                End If
                If DirectCast(fControl, SaimtASPxButton).ID = "btnCancelar" Then
                    DirectCast(fControl, SaimtASPxButton).Enabled = blnCancelar
                End If
                If DirectCast(fControl, SaimtASPxButton).ID = "btnImprimir" Then
                    DirectCast(fControl, SaimtASPxButton).Enabled = blnImprimir
                End If
            End If

        Next
    End Sub

#End Region


End Class
