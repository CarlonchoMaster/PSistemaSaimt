Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmExtornarAbonos

    Dim dtAbonoPEM As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtAbonoPEM.Columns.Add("AbonId", GetType(String))
        dtAbonoPEM.Columns.Add("AbonNPlaca1", GetType(String))
        dtAbonoPEM.Columns.Add("AbonNPlaca2", GetType(String))
        dtAbonoPEM.Columns.Add("AbonNPlaca3", GetType(String))
        dtAbonoPEM.Columns.Add("AbonFechaIni", GetType(DateTime))
        dtAbonoPEM.Columns.Add("AbonFechaFin", GetType(DateTime))
        dtAbonoPEM.Columns.Add("AbonImporte", GetType(Decimal))
        dtAbonoPEM.Columns.Add("Estado", GetType(String))
        dtAbonoPEM.Columns.Add("TgEstadoId", GetType(String))
        dtAbonoPEM.Columns.Add("Persona", GetType(String))
        dtAbonoPEM.Columns.Add("TipoDocumento", GetType(String))
        dtAbonoPEM.Columns.Add("NroDocumento", GetType(String))
    End Sub
#End Region

    Private Sub frmExtornarAbonos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        dgvAbono.DataSource = dtAbonoPEM

        dtpfechabusqueda.EditValue = Date.Now

        mCargarAbonos()
    End Sub

    Private Sub mCargarAbonos(Optional ByVal opcion As Int16 = 0)
        Try
            If opcion = 0 Then
                GValorTextoBuscado = dtpfechabusqueda.DateTime.Date
            ElseIf opcion = 1 Then
                GValorTextoBuscado = txtPersona.EditValue
            End If

            If Len(GValorTextoBuscado) = 0 Then
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese un Valor para la Opción")
                Return
            End If

            Dim ListaAbonoPEM As List(Of EEAbonoPEM) = MantenimientosBL.Instancia.abonopemListarParaExtorno_XCriterios(opcion, GValorTextoBuscado)
            If ListaAbonoPEM IsNot Nothing Then
                dtAbonoPEM.Clear()
                For Each fAbonoPEM As EEAbonoPEM In ListaAbonoPEM
                    dtAbonoPEM.LoadDataRow(New Object() {fAbonoPEM.AbonId,
                                      fAbonoPEM.AbonNPlaca1,
                                                         fAbonoPEM.AbonNPlaca2,
                                                         fAbonoPEM.AbonNPlaca3,
                                                         fAbonoPEM.AbonFechaIni,
                                                         fAbonoPEM.AbonFechaFin,
                                                         fAbonoPEM.AbonImporte,
                                                         fAbonoPEM.OTgEstado.TgNombre,
                                                         fAbonoPEM.OTgEstado.TgCodigo,
                                                         fAbonoPEM.OPersona.Persona,
                                                         fAbonoPEM.OPersona.TgDocumento,
                                                         fAbonoPEM.OPersona.PerNDoc
                                    }, True)
                Next
                gvAbono.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnExtornar_Click(sender As System.Object, e As System.EventArgs) Handles btnExtornar.Click
        'If gvAbono.GetFocusedRowCellValue("TgEstadoId").ToString <> "02" Then
        Dim fmContrato As frmExtornarCuotaLista = New frmExtornarCuotaLista()
        fmContrato.txtNroContrato.Text = gvAbono.GetRowCellValue(Me.gvAbono.GetSelectedRows(0), "AbonId")
        'fmContratoCancelacion.txtObsContrato.Text = txtObsCon.Text
        If fmContrato.ShowDialog() Then
            mCargarAbonos()
        End If
        ' Else
        ' SaimtMessageBox.mostrarAlertaAdvertencia("No se puede extornar un Abono cuyo contrato este Terminado o sea Abonado Día")
        ' End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        mCargarAbonos()
    End Sub

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton1.Click
        mCargarAbonos(1)
    End Sub
End Class