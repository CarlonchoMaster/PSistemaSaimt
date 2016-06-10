Imports System.Windows.Forms
Imports Entidades
Imports ReglasNegocio
Imports SaimtControles

Public Class frmDialogConfirmacionUpd
    Public Property result() As Boolean
    Dim InmUpdId As String = String.Empty

    Public Sub New(ByVal codigo As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        InmUpdId = codigo
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        result = True
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        result = False
        Me.Close()
    End Sub

    Private Sub frmDialogConfirmacionUpd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboCampoUpd.mColumnas(SaimtComboBoxLookUp.Entidades.InmCampoActualiza)
        cboCampoUpd.Properties.DisplayMember = "InmUpdDetCampoText"
        cboCampoUpd.Properties.ValueMember = "InmUpdDetId"
        cboCampoUpd.Properties.DataSource = MantenimientosBL.Instancia.inmuebleUpdateMostrarInmUpdDetCampoTextxInmUpdId(InmUpdId)
        cboCampoUpd.ItemIndex = 0
    End Sub

    Private Sub cboCampoUpd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampoUpd.EditValueChanged
        If cboCampoUpd.EditValue IsNot Nothing Then
            Dim loInmUpdDet As EEInmueble.EEInmLogs.EEInmLogsDet = MantenimientosBL.Instancia.inmuebleUpdateMostrarInmUpdValorOld_NewxInmUpdId(cboCampoUpd.EditValue)
            txtCampoOld.Text = loInmUpdDet.InmUpdDetValorOld
            txtCampoNew.Text = loInmUpdDet.InmUpdDetValorNew
        End If
    End Sub
End Class
