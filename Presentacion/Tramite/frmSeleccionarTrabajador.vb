﻿Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports System.Windows.Forms

Public Class frmSeleccionarTrabajador
    Dim tgInstId As String = "0001"
    Dim BuscarConJerarquia As Boolean = False
    Dim JerDeId As String = String.Empty
    'Dim tgTipoDocId As String = String.Empty
    Dim tgCargoId As String = String.Empty
    Dim tgAreaId As String = String.Empty

    Public Sub New(Optional ByVal _BuscarConJerarquia As Boolean = False, Optional ByVal _JerDeId As String = Nothing, Optional ByVal _tgAreaId As String = Nothing, Optional ByVal _tgCargoId As String = Nothing)
        ' Llamada necesaria para el diseñador.
        JerDeId = _JerDeId
        '  tgTipoDocId = _tgTipoDocId
        'tgCargoId = _tgCargoId
        tgAreaId = _tgAreaId
        tgCargoId = _tgCargoId
        BuscarConJerarquia = _BuscarConJerarquia
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Sub CargarTrabajadoresXtgAreaId_tgCargoId(ByVal tgAreaId As String, ByVal tgCargoId As String)
        Dim lPersona As List(Of EEPersona)
        Dim carPerId As String = tgInstId & tgAreaId & tgCargoId
        lPersona = MantenimientosBL.Instancia.personaListarXCargoId(carPerId)
        lstTrabajador.DataSource = Nothing
        If lPersona IsNot Nothing Then
            lstTrabajador.ValueMember = "PerId"
            lstTrabajador.DisplayMember = "PerNombreCompleto"
            lstTrabajador.DataSource = lPersona
        End If
    End Sub
 
    Private Sub frmSeleccionarTrabajador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If BuscarConJerarquia = True Then
            cboArea.mColumnas(SaimtComboBoxLookUp.Entidades.JerAreaDestino)
            cboArea.Properties.DisplayMember = "AreaDestino"
            cboArea.Properties.ValueMember = "CodAreaDestino"
            cboArea.Properties.DataSource = MantenimientosBL.Instancia.jerarquiastdListarAreasDestinosXJerDeId(JerDeId)
            cboArea.Text.ToUpper()
        Else
            cboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboArea.Properties.DisplayMember = "TgNombre"
            cboArea.Properties.ValueMember = "TgCodigo"
            cboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, tgInstId)
            cboArea.Text.ToUpper()

        End If

        If tgAreaId IsNot Nothing Then
            cboArea.EditValue = tgAreaId
        Else
            cboArea.ItemIndex = 0
        End If

    End Sub

    Private Sub cboCargo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCargo.EditValueChanged
        lstTrabajador.Items.Clear()
        lstTrabajador.DataSource = Nothing
        If cboCargo.EditValue IsNot Nothing Then
            CargarTrabajadoresXtgAreaId_tgCargoId(cboArea.EditValue, cboCargo.EditValue)
        End If
    End Sub

    Private Sub lstTrabajador_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstTrabajador.MouseDoubleClick
        If lstTrabajador.ItemCount <> -1 Then
            If lstTrabajador.SelectedValue <> "" Then
                Me.Close()
            End If
        End If
    End Sub

 
    Private Sub cboArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.EditValueChanged
        lstTrabajador.Items.Clear()
        lstTrabajador.DataSource = Nothing
        cboCargo.Properties.DataSource = Nothing
        If cboArea.EditValue IsNot Nothing Then
            If BuscarConJerarquia = True Then
                cboCargo.mColumnas(SaimtComboBoxLookUp.Entidades.JerCargoDestino)
                cboCargo.Properties.ValueMember = "CodCargoDestino"
                cboCargo.Properties.DisplayMember = "CargoDestino"
                cboCargo.Properties.DataSource = MantenimientosBL.Instancia.jerarquiastdListarCargosDestinosXJerDeId_tgAreaId(JerDeId, cboArea.EditValue, tgInstId)
                ' cboCargo.ItemIndex = 0
            Else

                cboCargo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
                cboCargo.Properties.DisplayMember = "TgNombre"
                cboCargo.Properties.ValueMember = "TgCodigo"
                cboCargo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(84, cboArea.EditValue & tgInstId)
                '  cboCargo.ItemIndex = 0
            End If

            If tgCargoId IsNot Nothing Then
                cboCargo.EditValue = tgCargoId
            End If
        End If
    End Sub
End Class
