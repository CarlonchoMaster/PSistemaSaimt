Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Public Class frmRptContratos
    Dim dtContratos As DataTable = New DataTable("contratos")
    Dim dtPropaDet As DataTable = New DataTable("propagosdet")
    Dim ListaContratos As List(Of EEContratoInm) = Nothing
    Dim locontrato As EEContratoInm = Nothing
    Dim lolistareporte As List(Of EEReportesGeneral) = Nothing
    Dim loReporte As EEReportesGeneral = Nothing
    Dim itemscontrato As Short = 0
    Dim dsReporte As DataSet = New DataSet
    Private Sub ConstruirTablaContratos()
        dtContratos.Columns.Add("item", GetType(String))
        dtContratos.Columns.Add("codcontrato", GetType(String))
        dtContratos.Columns.Add("codinquilino", GetType(String))
        dtContratos.Columns.Add("persona", GetType(String))
        dtContratos.Columns.Add("contacto", GetType(String))
        dtContratos.Columns.Add("codfinca", GetType(String))
        dtContratos.Columns.Add("direccion", GetType(String))
        dtContratos.Columns.Add("fechaini", GetType(Date))
        dtContratos.Columns.Add("fechafin", GetType(Date))
        dtContratos.Columns.Add("uso", GetType(String))
        dtContratos.Columns.Add("mconductiva", GetType(Decimal))
        dtContratos.Columns.Add("tipogar", GetType(String))
        dtContratos.Columns.Add("montogar", GetType(String))
        dtContratos.Columns.Add("fechasus", GetType(Date))
        dtContratos.Columns.Add("estado", GetType(String))
        dtContratos.Columns.Add("observacion", GetType(String))
    End Sub
    Private Sub ConstruirTablaDetalle()
        dtPropaDet.Columns.Add("nrocuota", GetType(Short))
        dtPropaDet.Columns.Add("codconcepto", GetType(String))
        dtPropaDet.Columns.Add("concepto", GetType(String))
        dtPropaDet.Columns.Add("fechaven", GetType(Date))
        dtPropaDet.Columns.Add("monto", GetType(Decimal))
        dtPropaDet.Columns.Add("ingsaimt", GetType(Decimal))
        dtPropaDet.Columns.Add("ingmpt", GetType(Decimal))
        dtPropaDet.Columns.Add("comision", GetType(Decimal))
        dtPropaDet.Columns.Add("netosaimt", GetType(Decimal))
        dtPropaDet.Columns.Add("estado", GetType(String))
        dtPropaDet.Columns.Add("codcontrato", GetType(String))
    End Sub
    Private Sub frmRptContratos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ConstruirTablaContratos()
            ConstruirTablaDetalle()
            Dim ListaAños As List(Of String) = MantenimientosBL.Instancia.proPagosListarAñosProPagos_EnPivotProPagos()
            For Each fAños As String In ListaAños
                cboAños.Properties.Items.Add(fAños)
            Next
            cboAños.SelectedIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnVerReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnVerReporte.Click
        Try
            itemscontrato = 0
            dtPropaDet.Clear()
            dtContratos.Clear()
            dsReporte.Clear()
            dsReporte.Relations.Clear()
            dtPropaDet.Constraints.Clear()
            dtContratos.Constraints.Clear()
            dsReporte.Tables.Clear()
            ListaContratos = MantenimientosBL.Instancia.contratoInmListarXanio(Me.cboAños.EditValue)
            If ListaContratos IsNot Nothing Then
                For Each frowContratos In ListaContratos
                    itemscontrato = itemscontrato + 1
                    dtContratos.LoadDataRow(New Object() {itemscontrato, _
                                                          frowContratos.ConInmId, _
                                                          frowContratos.OPersona.PerId, _
                                                          frowContratos.OPersona.PerNombres, _
                                                          frowContratos.OPersona.PerContacto, _
                                                          frowContratos.InmId, _
                                                          frowContratos.InmDir, _
                                                          frowContratos.ConInmFecIni, _
                                                          frowContratos.ConInmFecFin, _
                                                          frowContratos.OTgUso.TgNombre, _
                                                          frowContratos.ConInmMerced, _
                                                          frowContratos.OTgGarantia.TgNombre, _
                                                          frowContratos.ConInmGarantia, _
                                                          frowContratos.ConInmFecSus, _
                                                          frowContratos.OTgEstado.TgNombre, _
                                                          frowContratos.ConInmObs
                                                          }, True)

                    lolistareporte = MantenimientosBL.Instancia.ReporteProgramacionPagDet_XconInmId(frowContratos.ConInmId)
                    If lolistareporte IsNot Nothing Then
                        If lolistareporte.Count > 0 Then
                            For Each frow In lolistareporte
                                dtPropaDet.LoadDataRow(New Object() {frow.ProPaNroCuota, _
                                                                     frow.ConId, _
                                                                     frow.ConNombre, _
                                                                     frow.ProPaFechaVen, _
                                                                     frow.Monto, _
                                                                     frow.IngresoSAIMT, _
                                                                     frow.IngresoMuni, _
                                                                     frow.ProPaComision, _
                                                                     frow.NetoSaimt, _
                                                                     frow.Estado, _
                                                                     frow.conInmId}, True)

                            Next
                        End If
                    End If
                Next
            End If
            If dtPropaDet.Rows.Count > 0 Then
                dsReporte.Tables.Add(dtContratos)
                dsReporte.Tables.Add(dtPropaDet)
                Dim colmaestro() As DataColumn = {dsReporte.Tables("contratos").Columns("codcontrato")}
                Dim coldetalle() As DataColumn = {dsReporte.Tables("propagosdet").Columns("codcontrato")}
                dsReporte.Relations.Add("reporteContratos", colmaestro, coldetalle)
            Else
                dsReporte.Tables.Add(dtContratos)
            End If

            gcRptContratos.DataSource = dsReporte
            gcRptContratos.DataMember = "contratos"
            gvRptContratos.BestFitColumns()
            gvProDet.BestFitColumns()
            GridColumn17.GroupIndex = 0
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click
        sfdExportar.Filter = "Archivo de Excel|*.xls"
        If sfdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            gcRptContratos.ExportToXls(sfdExportar.FileName)

        End If
    End Sub

    Private Sub gvRptContratos_MasterRowExpanded(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles gvRptContratos.MasterRowExpanded

    End Sub

    Private Sub gvProDet_GroupRowExpanded(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowEventArgs) Handles gvProDet.GroupRowExpanded
        'gvProDet.BestFitColumns()

    End Sub
End Class