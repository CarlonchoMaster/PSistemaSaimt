Imports ReglasNegocio

Public Class SaimtComboBoxLookUpUpdate

    Public Enum Entidades
        Clase
        EstadoConservacion
        EstadoContrato
        EstadoSaneamiento
        SituacionInmueble
        SituacionLegal
        Via
        Ninguno
        MensajeProveido_DocInt
    End Enum

    Private _Entidad As Entidades = Entidades.Ninguno
    Public Property Entidad() As Entidades
        Get
            Return _Entidad
        End Get
        Set(ByVal value As Entidades)
            _Entidad = value
        End Set
    End Property

    Private Sub btnUpdateCbo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateCbo.Click
        listarSegunEntidad(Me.Entidad)
    End Sub

    Private Sub listarSegunEntidad(ByVal en As Entidades)
        Select Case en
            Case Entidades.Clase
                listarClase()
                Exit Select
            Case Entidades.EstadoContrato
                listarEstadoContrato()
                Exit Select
            Case Entidades.EstadoConservacion
                listarEstadoConservacion()
                Exit Select
            Case Entidades.EstadoSaneamiento
                listarEstadoSaneamiento()
                Exit Select
            Case Entidades.Via
                listarVia()
                Exit Select
            Case Entidades.SituacionInmueble
                listarSituacionInmueble()
                Exit Select
            Case Entidades.SituacionLegal
                listarSituacionLegal()
                Exit Select
            Case Entidades.MensajeProveido_DocInt
                listarMensajeDocInterno()
                Exit Select
        End Select
    End Sub
    Private Sub listarMensajeDocInterno()
        Try
            cboUpdate.Properties.Columns.Clear()
            cboUpdate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgNombre", "Nombre")})
            cboUpdate.Properties.DisplayMember = "TgNombre"
            cboUpdate.Properties.ValueMember = "TgCodigo"
            cboUpdate.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(167)
            cboUpdate.ItemIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub listarClase()
        Try
            cboUpdate.Properties.Columns.Clear()
            cboUpdate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClsNombre", "Nombre")})

            cboUpdate.Properties.DisplayMember = "ClsNombre"
            cboUpdate.Properties.ValueMember = "ClsId"
            cboUpdate.Properties.DataSource = MantenimientosBL.Instancia.claseListarALL()
            cboUpdate.ItemIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub listarVia()
        Try
            cboUpdate.Properties.Columns.Clear()
            cboUpdate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgNombre", "Nombre")})

            cboUpdate.Properties.DisplayMember = "TgNombre"
            cboUpdate.Properties.ValueMember = "TgCodigo"
            cboUpdate.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(1)
            cboUpdate.ItemIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub listarEstadoContrato()
        Try
            cboUpdate.Properties.Columns.Clear()
            cboUpdate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgNombre", "Nombre")})

            cboUpdate.Properties.DisplayMember = "TgNombre"
            cboUpdate.Properties.ValueMember = "TgCodigo"
            cboUpdate.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgEstadoContrato)
            cboUpdate.ItemIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub listarSituacionLegal()
        Try
            cboUpdate.Properties.Columns.Clear()
            cboUpdate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgNombre", "Nombre")})

            cboUpdate.Properties.DisplayMember = "TgNombre"
            cboUpdate.Properties.ValueMember = "TgCodigo"
            cboUpdate.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgCondicionRegistral)
            cboUpdate.ItemIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub listarSituacionInmueble()
        Try
            cboUpdate.Properties.Columns.Clear()
            cboUpdate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgNombre", "Nombre")})

            cboUpdate.Properties.DisplayMember = "TgNombre"
            cboUpdate.Properties.ValueMember = "TgCodigo"
            cboUpdate.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgEstadoSituacionInmueble)
            cboUpdate.ItemIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub listarEstadoSaneamiento()
        Try
            cboUpdate.Properties.Columns.Clear()
            cboUpdate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgNombre", "Nombre")})

            cboUpdate.Properties.DisplayMember = "TgNombre"
            cboUpdate.Properties.ValueMember = "TgCodigo"
            cboUpdate.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgEstadoSaneamiento)
            cboUpdate.ItemIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub listarEstadoConservacion()
        Try
            cboUpdate.Properties.Columns.Clear()
            cboUpdate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgNombre", "Nombre")})

            cboUpdate.Properties.DisplayMember = "TgNombre"
            cboUpdate.Properties.ValueMember = "TgCodigo"
            cboUpdate.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(clsVariablesTablaGeneral.tblgEstadoConservacion)
            cboUpdate.ItemIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub SaimtComboBoxUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            Dim buttonTooltip As ToolTip = New ToolTip()
            buttonTooltip.ToolTipIcon = ToolTipIcon.Info
            buttonTooltip.UseFading = True
            buttonTooltip.UseAnimation = True
            buttonTooltip.ToolTipTitle = "Actualizar"
            buttonTooltip.SetToolTip(btnUpdateCbo, "Visualizar nuevos cambios")
            listarSegunEntidad(Me.Entidad)
        End If
    End Sub
End Class
