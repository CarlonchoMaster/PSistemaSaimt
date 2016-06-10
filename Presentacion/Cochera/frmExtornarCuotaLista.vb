Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Public Class frmExtornarCuotaLista
    Inherits frmCancelacion
    Dim dtProgramacionAbono As DataTable = New DataTable()
    Dim loAbonoPEM As EEAbonoPEM
    Private Sub ConstruirTableProgramacionAbono()
        dtProgramacionAbono.Columns.Add("AbonDetId", GetType(String))
        dtProgramacionAbono.Columns.Add("AbonDetNroCuota", GetType(Int16))
        dtProgramacionAbono.Columns.Add("AbonDetFechaIni", GetType(DateTime))
        dtProgramacionAbono.Columns.Add("AbonDetFechaFin", GetType(DateTime))
        dtProgramacionAbono.Columns.Add("AbonDetImporte", GetType(Decimal))
    End Sub
    Private Sub frmExtornarCuotaLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cboMotivoExtorno.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboMotivoExtorno.Properties.DisplayMember = "TgNombre"
            cboMotivoExtorno.Properties.ValueMember = "TgCodigo"
            cboMotivoExtorno.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(159)
            cboMotivoExtorno.ItemIndex = -1

            txtNroContrato.Properties.ReadOnly = True
            dtpFechaCancelacion.EditValue = DateTime.Now
            Dim ListaProPagos As List(Of EEAbonoPEM.EEAbonoDetPEM) = MantenimientosBL.Instancia.abonoDetpemListarNroCuotasNoPagadasXAbonId(txtNroContrato.Text)

            If ListaProPagos IsNot Nothing Then
                cboCanDesde.mColumnas(SaimtComboBoxLookUp.Entidades.abonDetNroCuota)
                cboCanDesde.Properties.DisplayMember = "AbonDetNroCuota"
                cboCanDesde.Properties.ValueMember = "AbonDetNroCuota"
                cboCanDesde.Properties.DataSource = ListaProPagos
                txtNroCuotasPendientes.Text = ListaProPagos.Count
            End If

            txtNroTotalCuotas.Text = MantenimientosBL.Instancia.abonoDetpemMostrarNroCuotasALLXAbonId(txtNroContrato.Text)
            txtNroCuotasPagadas.Text = Convert.ToInt32(txtNroTotalCuotas.Text) - Convert.ToInt32(txtNroCuotasPendientes.Text)
            txtNroTotalCuotas.Properties.ReadOnly = True
            txtNroCuotasPendientes.Properties.ReadOnly = True
            txtNroCuotasPagadas.Properties.ReadOnly = True

            ConstruirTableProgramacionAbono()
            dgvProgramacionAbonos.DataSource = dtProgramacionAbono

            loAbonoPEM = MantenimientosBL.Instancia.abonopemListarDetalleXAbonId(txtNroContrato.Text)
            dtProgramacionAbono.Clear()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
       
            If loAbonoPEM IsNot Nothing Then
                For Each row As DataRow In dtProgramacionAbono.Rows
                    If row("AbonDetNroCuota") = cboCanDesde.EditValue Then
                        SaimtMessageBox.mostrarAlertaInformativa(String.Format("Ya se encuentra Agregada la cuota {0} para su extorno", cboCanDesde.EditValue))
                        Return
                    End If
                Next

                For Each fAbonoDetPEM As EEAbonoPEM.EEAbonoDetPEM In loAbonoPEM.ListaAbonoDetPEM
                    If cboCanDesde.EditValue = fAbonoDetPEM.AbonDetNroCuota Then
                        dtProgramacionAbono.LoadDataRow(New Object() {fAbonoDetPEM.AbonDetId,
                            fAbonoDetPEM.AbonDetNroCuota,
                            fAbonoDetPEM.AbonDetFechaIni,
                            fAbonoDetPEM.AbonDetFechaFin,
                             fAbonoDetPEM.AbonDetImporte}, True)
                        Exit For
                    End If
                Next
                gvProgramacionAbonos.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarCancelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCancelacion.Click
        Try
            If cboMotivoExtorno.EditValue Is Nothing Then

                SaimtMessageBox.mostrarAlertaInformativa("Seleccione Motivo de Extorno")
                Return
            End If

            If cboCanDesde.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione Cuota a cancelar")
                Return
            End If
            Dim ListaAbonoExtorno As List(Of EEAbonExtorno) = Nothing
            Dim aoAbonExtorno As EEAbonExtorno
            For Each row As DataRow In dtProgramacionAbono.Rows

                If ListaAbonoExtorno Is Nothing Then
                    ListaAbonoExtorno = New List(Of EEAbonExtorno)
                End If
                aoAbonExtorno = New EEAbonExtorno()
                aoAbonExtorno.OAbonoPEM = New EEAbonoPEM
                aoAbonExtorno.OAbonoPEM.AbonId = txtNroContrato.Text
                aoAbonExtorno.OTgTipoExt = New EETablaGeneral
                aoAbonExtorno.OTgTipoExt.TgCodigo = cboMotivoExtorno.EditValue
                aoAbonExtorno.ExtObservacion = txtObsContrato.Text
                aoAbonExtorno.ExtDesdeCuota = row("AbonDetNroCuota").ToString
                aoAbonExtorno.ExtPerId = EEComun._PerId
                ListaAbonoExtorno.Add(aoAbonExtorno)
            Next
            MantenimientosBL.Instancia.abonextornoGuardarExtonoAbono(ListaAbonoExtorno)
            MyBase.guardar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaInformativa(ex.Message)
        End Try
    End Sub
End Class