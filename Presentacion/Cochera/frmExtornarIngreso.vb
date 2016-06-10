Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmExtornarIngreso

    Dim dtDiarioPEM As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtDiarioPEM.Columns.Add("DiarioId", GetType(String))
        dtDiarioPEM.Columns.Add("DiarioCod", GetType(String))
        dtDiarioPEM.Columns.Add("DiaNPlaca", GetType(String))
        dtDiarioPEM.Columns.Add("DiaFechaIng", GetType(DateTime))
        dtDiarioPEM.Columns.Add("DiaHoraIng", GetType(TimeSpan))
        dtDiarioPEM.Columns.Add("DiaFechaSal", GetType(DateTime))
        dtDiarioPEM.Columns.Add("DiaHoraSal", GetType(TimeSpan))
        dtDiarioPEM.Columns.Add("Importe", GetType(Decimal))
        dtDiarioPEM.Columns.Add("Estado", GetType(String))
        dtDiarioPEM.Columns.Add("TgEstadoId", GetType(String))
        dtDiarioPEM.Columns.Add("ConId", GetType(String))
        dtDiarioPEM.Columns.Add("ConNombre", GetType(String))
    End Sub
#End Region

    Private Sub frmExtornarIngreso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvExtorno.DataSource = dtDiarioPEM

        cboMotivoExtorno.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboMotivoExtorno.Properties.DisplayMember = "TgNombre"
        cboMotivoExtorno.Properties.ValueMember = "TgCodigo"
        cboMotivoExtorno.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(163)
        cboMotivoExtorno.ItemIndex = -1
        dtpfechabusqueda.EditValue = DateTime.Now
        mCargarDiario()
    End Sub

    Private Sub mCargarDiario()
        Try
            Dim ListaDiarioPEM As List(Of EEDiarioPEM) = MantenimientosBL.Instancia.diariopemListarParaExtorno_XFecha(dtpfechabusqueda.EditValue)
            dtDiarioPEM.Clear()
            If ListaDiarioPEM IsNot Nothing Then
                dtDiarioPEM.Clear()
                For Each fDiarioPEM As EEDiarioPEM In ListaDiarioPEM
                    dtDiarioPEM.LoadDataRow(New Object() {fDiarioPEM.DiarioId,
                                                         fDiarioPEM.DiarioCod,
                                                         fDiarioPEM.DiaNPlaca,
                                                         fDiarioPEM.DiaFechaIng,
                                                         fDiarioPEM.DiaHoraIngreso,
                                                         fDiarioPEM.DiaFechaSal,
                                                         fDiarioPEM.DiaHoraSalida,
                                                         fDiarioPEM.DiaPrecio,
                                                         fDiarioPEM.OTgEstado.TgNombre,
                                                         fDiarioPEM.OTgEstado.TgCodigo,
                                                         fDiarioPEM.loConcepto.ConId,
                                                         fDiarioPEM.loConcepto.ConNombre
                                    }, True)
                Next
                gvExtorno.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnExtornar_Click(sender As System.Object, e As System.EventArgs) Handles btnExtornar.Click
        If Me.gvExtorno.DataRowCount <> 0 Then
            If gvExtorno.GetRowCellValue(Me.gvExtorno.GetSelectedRows(0), "TgEstadoId").ToString() = "03" Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El Diario ya ha Sido Extornado")
                Exit Sub
            End If

            If cboMotivoExtorno.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Motivo")
                Exit Sub
            End If

            If SaimtMessageBox.mostrarAlertaPregunta("Desea Extornar") Then
                Try
                    Dim loAbonExtorno As EEAbonExtorno = New EEAbonExtorno()
                    loAbonExtorno.DiarioId = gvExtorno.GetRowCellValue(Me.gvExtorno.GetSelectedRows(0), "DiarioId").ToString()
                    loAbonExtorno.OTgTipoExt = New EETablaGeneral()
                    loAbonExtorno.OTgTipoExt.TgCodigo = cboMotivoExtorno.EditValue
                    loAbonExtorno.ExtObservacion = txtComentario.Text
                    loAbonExtorno.ExtPerId = EEComun._PerId

                    MantenimientosBL.Instancia.abonextornoGuardarExtonoDiario(loAbonExtorno)
                    SaimtMessageBox.mostrarAlertaInformativa("Se Extorno Correctamente")
                    mCargarDiario()
                Catch ex As Exception
                    SaimtMessageBox.mostrarAlertaError(ex.Message)
                End Try
            End If
        Else
            SaimtMessageBox.mostrarAlertaInformativa("Seleccione Una Fila")
            Exit Sub
        End If
    End Sub

    Private Sub gvExtorno_RowStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvExtorno.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim lsEstadoId As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("TgEstadoId"))
            If lsEstadoId = "03" Then
                e.Appearance.BackColor = System.Drawing.Color.FromArgb(218, 150, 148)
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        mCargarDiario()
    End Sub
End Class