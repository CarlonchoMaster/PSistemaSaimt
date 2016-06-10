Imports DevExpress.LookAndFeel
Imports SaimtControles
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Public Class frmMantenimientos
    Inherits frmGeneral

#Region "Carga Load"
    Private Sub frmMantenimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Me.ButtonNuevo IsNot Nothing Then
                AddHandler Me.ButtonNuevo.Click, AddressOf ButtonNuevo_Click
                ButtonNuevo.Text = "Nuevo"
                mGSetearTool(ButtonNuevo, "Nuevo", "Generar Nuevo Registro")
            End If
            If Me.ButtonEditar IsNot Nothing Then
                AddHandler Me.ButtonEditar.Click, AddressOf ButtonEditar_Click
                ButtonEditar.Text = "Editar"
                mGSetearTool(ButtonEditar, "Editar", "Editar datos")
            End If
            If Me.ButtonLimpiar IsNot Nothing Then
                AddHandler Me.ButtonLimpiar.Click, AddressOf ButtonLimpiar_Click
                ButtonLimpiar.Text = "Limpiar"
                mGSetearTool(ButtonLimpiar, "Limpiar", "Limpiar campos")
            End If
            If Me.ButtonCancelar IsNot Nothing Then
                AddHandler Me.ButtonCancelar.Click, AddressOf ButtonCancelar_Click
                ButtonCancelar.Text = "Cancelar"
                mGSetearTool(ButtonCancelar, "Cancelar", "Cancelar Edicion y/o nuevo Registro")
            End If
            If Me.ButtonCancelarData IsNot Nothing Then
                AddHandler Me.ButtonCancelarData.Click, AddressOf ButtonCancelarData_Click
                'ButtonCancelarData.Text = "Cancelar"
                mGSetearTool(ButtonCancelarData, "Cancelar Data", "Cancelar Datos")
            End If
            If Me.ButtonGuardar IsNot Nothing Then
                AddHandler Me.ButtonGuardar.Click, AddressOf ButtonGuardar_Click
                ButtonGuardar.Text = "Guardar"
                mGSetearTool(ButtonGuardar, "Guardar", "Guardar nuevo registro y/o cambios efectuados")
            End If
            If Me.ButtonEliminar IsNot Nothing Then
                AddHandler Me.ButtonEliminar.Click, AddressOf ButtonEliminar_Click
                ButtonEliminar.Text = "Eliminar"
                mGSetearTool(ButtonEliminar, "Eliminar", "Eliminar registros")
            End If
            If Me.ButtonImprimir IsNot Nothing Then
                AddHandler Me.ButtonImprimir.Click, AddressOf ButtonImprimir_Click
                ButtonImprimir.Text = "Imprimir"
                mGSetearTool(ButtonImprimir, "Imprimir", "Mostrar en PDF e Imprimirlo")
            End If
            If Me.lstListado IsNot Nothing Then
                AddHandler Me.lstListado.SelectedValueChanged, AddressOf lstListado_SelectedValueChanged
            End If
            If Me.dgvListado IsNot Nothing Then
                AddHandler Me.dgvListado.Click, AddressOf dgvListado_Click
            End If
            If Me.txtBuscarSaimt IsNot Nothing Then
                AddHandler Me.txtBuscarSaimt.KeyDown, AddressOf txtBuscarSaimt_KeyDown
            End If
            'Debe subir
            Me.hodControlesTotal(Me.Controls, False)
            Me.ActivarBotones(False, True, False, False, False, False, False)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaInformativa("Load Mantenimientos => " & ex.Message)
        End Try
    End Sub
#End Region

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
    End Enum
#End Region

#Region "Controles Formulario Saimt Para Luego Asignar"
    Private _ButtonNuevo As SaimtButton
    Public Property ButtonNuevo() As SaimtButton
        Get
            If _ButtonNuevo IsNot Nothing Then
                '_ButtonNuevo.Text = "Nuevo"
                _ButtonNuevo.Image = Presentacion.My.Resources.nuevo48
                mAsignarPosicionImagenBoton(_ButtonNuevo)
            End If
            Return _ButtonNuevo
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonNuevo = value
        End Set
    End Property

    Private _ButtonEditar As SaimtButton
    Public Property ButtonEditar() As SaimtButton
        Get
            If _ButtonEditar IsNot Nothing Then
                '_ButtonEditar.Text = "Editar"
                _ButtonEditar.Image = Presentacion.My.Resources.editar48
                mAsignarPosicionImagenBoton(_ButtonEditar)
            End If
            Return _ButtonEditar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonEditar = value
        End Set
    End Property

    Private _ButtonLimpiar As SaimtButton
    Public Property ButtonLimpiar() As SaimtButton
        Get
            If _ButtonLimpiar IsNot Nothing Then
                '_ButtonLimpiar.Text = "Limpiar"
                _ButtonLimpiar.Image = Presentacion.My.Resources.limpiar48
                mAsignarPosicionImagenBoton(_ButtonLimpiar)
            End If
            Return _ButtonLimpiar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonLimpiar = value
        End Set
    End Property

    Private _ButtonCancelar As SaimtButton
    Public Property ButtonCancelar() As SaimtButton
        Get
            If _ButtonCancelar IsNot Nothing Then
                '_ButtonCancelar.Text = "Cancelar"
                _ButtonCancelar.Image = Presentacion.My.Resources.cancelar48
                mAsignarPosicionImagenBoton(_ButtonCancelar)
            End If
            Return _ButtonCancelar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonCancelar = value
        End Set
    End Property

    Private _ButtonCancelarData As SaimtButton
    Public Property ButtonCancelarData() As SaimtButton
        Get
            If _ButtonCancelarData IsNot Nothing Then
                '_ButtonCancelar.Text = "Cancelar"
                _ButtonCancelarData.Image = Presentacion.My.Resources.cancelardata48
                mAsignarPosicionImagenBoton(_ButtonCancelarData)
            End If
            Return _ButtonCancelarData
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonCancelarData = value
        End Set
    End Property

    Private _ButtonGuardar As SaimtButton
    Public Property ButtonGuardar() As SaimtButton
        Get
            If _ButtonGuardar IsNot Nothing Then
                '_ButtonGuardar.Text = "Guardar"
                _ButtonGuardar.Image = Presentacion.My.Resources.guardar48
                mAsignarPosicionImagenBoton(_ButtonGuardar)
            End If
            Return _ButtonGuardar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonGuardar = value
        End Set
    End Property

    Private _ButtonEliminar As SaimtButton
    Public Property ButtonEliminar() As SaimtButton
        Get
            If _ButtonEliminar IsNot Nothing Then
                '_ButtonEliminar.Text = "Eliminar"
                _ButtonEliminar.Image = Presentacion.My.Resources.eliminar48
                mAsignarPosicionImagenBoton(_ButtonEliminar)
            End If
            Return _ButtonEliminar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonEliminar = value
        End Set
    End Property

    Private _ButtonImprimir As SaimtButton
    Public Property ButtonImprimir() As SaimtButton
        Get
            If _ButtonImprimir IsNot Nothing Then
                '_ButtonImprimir.Text = "Imprimir"
                _ButtonImprimir.Image = Presentacion.My.Resources.imprimir48
                mAsignarPosicionImagenBoton(_ButtonImprimir)
            End If
            Return _ButtonImprimir
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonImprimir = value
        End Set
    End Property

    Private _lstListado As SaimtListBox
    Public Property lstListado() As SaimtListBox
        Get
            If _lstListado IsNot Nothing Then
                _lstListado.Name = "lstListado"
            End If
            Return _lstListado
        End Get
        Set(ByVal value As SaimtListBox)
            _lstListado = value
        End Set
    End Property

    Private _dgvListado As SaimtDataGrid
    Public Property dgvListado() As SaimtDataGrid
        Get
            If _dgvListado IsNot Nothing Then
                _dgvListado.Name = "dgvListado"
            End If
            Return _dgvListado
        End Get
        Set(ByVal value As SaimtDataGrid)
            _dgvListado = value
        End Set
    End Property

    Private _txtBuscarSaimt As SaimtTextBox
    Public Property txtBuscarSaimt() As SaimtTextBox
        Get
            If _txtBuscarSaimt IsNot Nothing Then
                _txtBuscarSaimt.Name = "txtBuscarSaimt"
            End If
            Return _txtBuscarSaimt
        End Get
        Set(ByVal value As SaimtTextBox)
            _txtBuscarSaimt = value
        End Set
    End Property

    Private _ButtonImportar As SaimtButton
    Public Property ButtonImportar() As SaimtButton
        Get
            Return _ButtonImportar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonImportar = value
        End Set
    End Property

    Private _ButtonVisualizar As SaimtButton
    Public Property ButtonVisualizar() As SaimtButton
        Get
            Return _ButtonVisualizar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonVisualizar = value
        End Set
    End Property

    Private _ButtonEnviar As SaimtButton
    Public Property ButtonEnviar() As SaimtButton
        Get
            Return _ButtonEnviar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonEnviar = value
        End Set
    End Property

    Private _ButtonVincular As SaimtButton
    Public Property ButtonVincular() As SaimtButton
        Get
            Return _ButtonVincular
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonVincular = value
        End Set
    End Property

    Private _ButtonDesVincular As SaimtButton
    Public Property ButtonDesVincular() As SaimtButton
        Get
            Return _ButtonDesVincular
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonDesVincular = value
        End Set
    End Property

    Private _ButtonVerDetalle As SaimtButton
    Public Property ButtonVerDetalle() As SaimtButton
        Get
            Return _ButtonVerDetalle
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonVerDetalle = value
        End Set
    End Property

    Private _ButtonConfirmar As SaimtButton
    Public Property ButtonConfirmar() As SaimtButton
        Get
            Return _ButtonConfirmar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonConfirmar = value
        End Set
    End Property

    Private _ButtonExportar As SaimtButton
    Public Property ButtonExportar() As SaimtButton
        Get
            Return _ButtonExportar
        End Get
        Set(ByVal value As SaimtButton)
            _ButtonExportar = value
        End Set
    End Property

    Private Sub mAsignarPosicionImagenBoton(ByVal abuButton As SaimtButton)
        abuButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        'abuButton.Width = 64
        'abuButton.Height = 64
    End Sub
#End Region

#Region "Eventos Handler"
    Private Sub ButtonImportar_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeImportar Then
            Me.importar()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonVisualizar_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeVisualizar Then
            Me.visualizar()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonEnviar_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeEnviar Then
            Me.enviar()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonVincular_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeVincular Then
            Me.vincular()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonDesVincular_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeDesvincular Then
            Me.desvincular()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonVerDetalle_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeVerDetalle Then
            Me.verdetalle()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonConfirmar_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeConfirmar Then
            Me.confirmar()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonExportar_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeExportar Then
            Me.exportar()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonImprimir_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeImprimir Then
            Me.imprimir()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonNuevo_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeCrear Then
            Me.nuevo()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonEditar_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeEditar Then
            Me.editar()
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.limpiar()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.cancelar()
    End Sub

    ''' <summary>
    ''' Mantenimientos => Asignar Formulario de Cancelacion
    ''' </summary>
    ''' <remarks></remarks>
    Public fmCancelacionData As frmCancelacion
    Private Sub ButtonCancelarData_Click(ByVal sender As Object, ByVal e As EventArgs)
        If fmCancelacionData IsNot Nothing Then
            If fmCancelacionData.ShowDialog() = DialogResult.OK Then

            End If
        End If
        'Me.cancelar()
    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim lsMensajeGA As String
        If Me.GEstadoNuevo Then
            lsMensajeGA = "Esta Seguro de Guardar"
        Else
            lsMensajeGA = "Esta Seguro de Actualizar"
        End If

        Select Case SaimtMessageBox.mostrarAlertaPregunta(lsMensajeGA)
            Case System.Windows.Forms.DialogResult.OK
                Me.guardar()
                Exit Select

            Case System.Windows.Forms.DialogResult.Cancel
                Exit Select
        End Select
    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PuedeEliminar Then
            Select Case SaimtMessageBox.mostrarAlertaPregunta("Esta Seguro que desea Eliminar")
                Case System.Windows.Forms.DialogResult.OK
                    Me.eliminar()
                    Exit Select

                Case System.Windows.Forms.DialogResult.Cancel
                    Exit Select
            End Select
        Else
            mostrarMensajeBarra(GMensajePermiso)
        End If
    End Sub

    Public Sub lstListado_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.seleccionarListado()
    End Sub

    Public Sub dgvListado_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.seleccionarListado()
    End Sub

    Private Sub txtBuscarSaimt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If PuedeBuscar Then
                Me.Buscar()
            Else
                mostrarMensajeBarra(GMensajePermiso)
            End If
        End If
    End Sub
#End Region

#Region "Metodos Botones"

    Protected Overridable Sub importar()

    End Sub

    Protected Overridable Sub visualizar()

    End Sub

    Protected Overridable Sub enviar()

    End Sub

    Protected Overridable Sub vincular()

    End Sub

    Protected Overridable Sub desvincular()

    End Sub

    Protected Overridable Sub verdetalle()

    End Sub

    Protected Overridable Sub confirmar()

    End Sub

    Protected Overridable Sub exportar()

    End Sub

    Protected Overridable Sub imprimir()

    End Sub

    Protected Overridable Sub nuevo()
        Me.GEstadoNuevo = True
        Me.GIdRegistroActual = 0
        If lstListado IsNot Nothing Then
            RemoveHandler lstListado.SelectedValueChanged, AddressOf lstListado_SelectedValueChanged

            Me.lstListado.SelectionMode = SelectionMode.None
            Me.lstListado.SelectionMode = SelectionMode.One

            AddHandler lstListado.SelectedValueChanged, AddressOf lstListado_SelectedValueChanged
        End If
        limpiarControlesTotal(Controls)
        hodControlesTotal(Controls, True)
        ActivarBoton(Botones.Nuevo)
    End Sub

    Protected Overridable Sub editar()
        Me.GEstadoNuevo = False
        If lstListado IsNot Nothing Then
            Me.lstListado.SelectionMode = SelectionMode.One
        End If
        hodControlesTotal(Controls, True)
        ActivarBoton(Botones.Editar)
    End Sub

    Protected Overridable Sub eliminar()
        Me.GIdRegistroActual = 0
        If lstListado IsNot Nothing Then
            'Me.lstListado.SelectionMode = SelectionMode.None
            Me.lstListado.DataSource = Nothing
        End If
        limpiarControlesTotal(Controls)
        mostrarMensajeBarra("Se Elimino Correctamente")
        hodControlesTotal(Controls, False)
        ActivarBoton(Botones.Eliminar)
    End Sub

    Protected Overridable Sub cancelar()
        If lstListado IsNot Nothing Then
            Me.lstListado.SelectionMode = SelectionMode.One
        End If
        If Me.GEstadoNuevo Then
            limpiarControlesTotal(Controls)
            ActivarBoton(Botones.CancelarNuevo)
        Else
            ActivarBoton(Botones.CancelarEditar)
        End If
        hodControlesTotal(Controls, False)
    End Sub

    ''' <summary>
    ''' Para Indicar Despues del Guardado o Actualizar 
    ''' el enabled de los controles
    ''' </summary>
    Public enabledGA As [Boolean]
    Protected Overridable Sub guardar()
        If lstListado IsNot Nothing Then
            Me.lstListado.SelectionMode = SelectionMode.None
        End If
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

    Protected Overridable Sub limpiar()
        limpiarControlesTotal(Controls)
    End Sub

    Protected Overridable Sub seleccionarListado()
        mostrarMensajeBarra("")
        hodControlesTotal(Controls, False)
        ActivarBoton(Botones.ListBoxListado)
       
    End Sub

    Protected Overridable Sub Buscar()
        If lstListado IsNot Nothing Then
            Me.lstListado.SelectionMode = SelectionMode.One
            If lstListado.DataSource Is Nothing Then
                limpiarControlesTotal(Controls)
                mostrarMensajeBarra("No se encontraron resultados")
                Me.ActivarBotones(False, True, False, False, False, False, True)
            Else
                Me.lstListado.SelectedIndex = 0
                mostrarMensajeBarra("")
            End If
        ElseIf dgvListado IsNot Nothing Then
            If DirectCast(dgvListado.DataSource, DataTable).Rows.Count = 0 Then
                limpiarControlesTotal(Controls)
                mostrarMensajeBarra("No se encontraron resultados")
                Me.ActivarBotones(False, True, False, False, False, False, True)
            Else
                mostrarMensajeBarra("")
            End If
        End If
    End Sub

    Protected Overridable Sub listar()
        If lstListado IsNot Nothing Then
            If lstListado.DataSource IsNot Nothing Then
                'lstListado.SelectedIndex = 0;
                Me.lstListado.SelectionMode = SelectionMode.One
            End If
        End If
    End Sub
#End Region

#Region "Activado y Desactivado de Botones"
    Protected Sub ActivarBotones(ByVal blnLimpiar As Boolean, ByVal blnNuevo As Boolean, ByVal blnEditar As Boolean, ByVal blnGuardar As Boolean, ByVal blnEliminar As Boolean, ByVal blnCancelar As Boolean, _
     ByVal blnImprimir As Boolean)
        If Me._ButtonLimpiar IsNot Nothing Then
            Me._ButtonLimpiar.Enabled = blnLimpiar
        End If
        If Me._ButtonNuevo IsNot Nothing Then
            Me._ButtonNuevo.Enabled = blnNuevo
        End If
        If Me._ButtonEditar IsNot Nothing Then
            Me._ButtonEditar.Enabled = blnEditar
        End If
        If Me._ButtonGuardar IsNot Nothing Then
            Me._ButtonGuardar.Enabled = blnGuardar
        End If
        If Me._ButtonEliminar IsNot Nothing Then
            Me._ButtonEliminar.Enabled = blnEliminar
        End If
        If Me._ButtonCancelar IsNot Nothing Then
            Me._ButtonCancelar.Enabled = blnCancelar
        End If
        If Me._ButtonImprimir IsNot Nothing Then
            Me._ButtonImprimir.Enabled = blnImprimir
        End If
    End Sub

    Protected Sub ActivarBoton(ByVal boton As Botones)
        Select Case boton
            Case Botones.Nuevo
                Me.ActivarBotones(True, False, False, True, False, True, _
                 True)
                Exit Select
            Case Botones.Editar
                Me.ActivarBotones(True, False, False, True, True, True, _
                 True)
                Exit Select
            Case Botones.CancelarNuevo
                Me.ActivarBotones(False, True, False, False, False, False, _
                 True)
                Exit Select
            Case Botones.CancelarEditar
                Me.ActivarBotones(False, True, True, False, True, False, _
                 True)
                Exit Select
            Case Botones.Eliminar
                Me.ActivarBotones(False, True, False, False, False, False, _
                 True)
                Exit Select
            Case Botones.Guardar
                Me.ActivarBotones(False, True, False, False, False, False, _
                 True)
                Exit Select
            Case Botones.ListBoxListado
                Me.ActivarBotones(False, True, True, False, True, False, _
                 True)
                Exit Select
        End Select
    End Sub

#End Region

#Region "Limpiado de Controles"
    Public Sub limpiarControlesTotal(ByVal Controles As Control.ControlCollection)
        For Each fControl As Control In Controles
            LimpiarControles(fControl)
        Next
        Me.GIdRegistroActual = 0
        mostrarMensajeBarra("")
    End Sub

    Private Sub LimpiarControles(ByVal aControl As Control)
        Dim tag As String = String.Empty
        If TypeOf aControl Is SaimtTextBox Then

            If DirectCast(aControl, SaimtTextBox).Tag IsNot Nothing Then
                tag = DirectCast(aControl, SaimtTextBox).Tag.ToString()
            End If
            If DirectCast(aControl, SaimtTextBox) IsNot txtBuscarSaimt And tag <> "NotClear" Then
                DirectCast(aControl, SaimtTextBox).Text = String.Empty
                DirectCast(aControl, SaimtTextBox).Tag = String.Empty
            End If
        ElseIf TypeOf aControl Is SaimtTextBoxMultiline Then
            DirectCast(aControl, SaimtTextBoxMultiline).Text = String.Empty
        ElseIf TypeOf aControl Is MemoExEdit Then
            DirectCast(aControl, MemoExEdit).Text = String.Empty
        ElseIf TypeOf aControl Is SaimtCheckBox Then
            If DirectCast(aControl, SaimtCheckBox).Tag IsNot Nothing Then
                tag = DirectCast(aControl, SaimtCheckBox).Tag.ToString()
            End If
            If tag <> "NotClear" Then
                DirectCast(aControl, SaimtCheckBox).Checked = True
            End If
        ElseIf TypeOf aControl Is SaimtDateTimePicker Then
            DirectCast(aControl, SaimtDateTimePicker).Text = Nothing
        ElseIf TypeOf aControl Is SaimtListBox Then
            If DirectCast(aControl, SaimtListBox) IsNot lstListado Then
                If DirectCast(aControl, SaimtListBox).Tag Is Nothing Then
                    DirectCast(aControl, SaimtListBox).DataSource = Nothing
                End If
            End If
        ElseIf TypeOf aControl Is SaimtComboBoxLookUp Then
            If DirectCast(aControl, SaimtComboBoxLookUp).Tag IsNot Nothing Then
                tag = DirectCast(aControl, SaimtComboBoxLookUp).Tag.ToString()
            End If
            If CType(aControl, SaimtComboBoxLookUp).Properties.DataSource IsNot Nothing And tag <> "NotClear" Then

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

#Region "Habilitacion de Controles"
    'Public Overloads Sub hodControlesTotal(ByVal aControles As Control.ControlCollection, ByVal blnEstado As Boolean)
    '    For Each fControl As Control In aControles
    '        controles(fControl, blnEstado)
    '    Next
    'End Sub

    'Public Overloads Sub controles(ByVal aControl As Control, ByVal blnEstado As Boolean)
    '    If TypeOf aControl Is SaimtTextBox Then
    '        If DirectCast(aControl, SaimtTextBox) IsNot txtBuscarSaimt Then
    '            DirectCast(aControl, SaimtTextBox).Properties.ReadOnly = Not blnEstado
    '        End If
    '        'ElseIf TypeOf aControl Is SaimtCheckBox Then
    '        '    DirectCast(aControl, SaimtCheckBox).Properties.ReadOnly = Not blnEstado
    '        'ElseIf TypeOf aControl Is SaimtButton Then
    '        '    DirectCast(aControl, SaimtButton).Enabled = blnEstado
    '        'ElseIf TypeOf aControl Is SaimtDateTimePicker Then
    '        '    DirectCast(aControl, SaimtDateTimePicker).Properties.ReadOnly = Not blnEstado
    '        'ElseIf TypeOf aControl Is SaimtSpinner Then
    '        '    DirectCast(aControl, SaimtSpinner).Enabled = blnEstado
    '        'ElseIf TypeOf aControl Is SaimtSpinner Then
    '        '    DirectCast(aControl, SaimtSpinner).Enabled = blnEstado
    '        'ElseIf TypeOf aControl Is SaimtTextBoxMultiline Then
    '        '    DirectCast(aControl, SaimtTextBoxMultiline).Properties.ReadOnly = Not blnEstado
    '        'ElseIf TypeOf aControl Is SaimtTabs Then
    '        '    DirectCast(aControl, SaimtTabs).Enabled = blnEstado
    '    ElseIf TypeOf aControl Is SaimtListBox Then
    '        If DirectCast(aControl, SaimtListBox).Tag Is Nothing Then
    '            If Not DirectCast(aControl, SaimtListBox) Is lstListado Then
    '                DirectCast(aControl, SaimtListBox).Enabled = blnEstado
    '            End If
    '        End If
    '        'ElseIf TypeOf aControl Is SaimtDateTimePicker Then
    '        '    DirectCast(aControl, SaimtDateTimePicker).Properties.ReadOnly = Not blnEstado
    '        'ElseIf TypeOf aControl Is SaimtComboBoxLookUp Then
    '        '    DirectCast(aControl, SaimtComboBoxLookUp).Properties.ReadOnly = Not blnEstado
    '        'ElseIf TypeOf aControl Is SaimtComboBoxLookUpUpdate Then
    '        '    DirectCast(aControl, SaimtComboBoxLookUpUpdate).cboUpdate.Properties.ReadOnly = Not blnEstado
    '        '    DirectCast(aControl, SaimtComboBoxLookUpUpdate).btnUpdateCbo.Enabled = blnEstado
    '        'ElseIf TypeOf aControl Is SaimtDataGrid Then
    '        '    DirectCast(aControl, SaimtDataGrid).Enabled = blnEstado
    '    Else
    '        For Each fChild As Control In aControl.Controls
    '            controles(fChild, blnEstado)
    '        Next
    '    End If
    'End Sub
#End Region

End Class