Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmActualizarDetraccion
    Inherits frmGeneral

    Dim dtDetracciones As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtDetracciones.Columns.Add("proPaId", GetType(String))
        dtDetracciones.Columns.Add("conInmId", GetType(String))
        dtDetracciones.Columns.Add("inmId", GetType(String))
        dtDetracciones.Columns.Add("Persona", GetType(String))
        dtDetracciones.Columns.Add("Año", GetType(String))
        dtDetracciones.Columns.Add("proPaNroCuota", GetType(String))
        dtDetracciones.Columns.Add("proPaFechaPag", GetType(DateTime))
        dtDetracciones.Columns.Add("Monto", GetType(String))
        dtDetracciones.Columns.Add("Detraccion", GetType(String))
        dtDetracciones.Columns.Add("Pagado", GetType(Boolean))

        dtDetracciones.Columns("proPaId").Caption = "Cod. Prog."
        dtDetracciones.Columns("conInmId").Caption = "Cod. Contrato"
        dtDetracciones.Columns("inmId").Caption = "Cod. Inmueble"
        dtDetracciones.Columns("proPaNroCuota").Caption = "Nro. Cuota"
        dtDetracciones.Columns("proPaFechaPag").Caption = "Fecha Pago"
    End Sub
#End Region

    Private Sub frmActualizarDetraccion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboMes.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboMes.Properties.DisplayMember = "TgNombre"
        cboMes.Properties.ValueMember = "TgCodigo"
        cboMes.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(40)
        cboMes.ItemIndex = 0

        cboAño.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAño.Properties.DisplayMember = "TgNombre"
        cboAño.Properties.ValueMember = "TgCodigo"
        cboAño.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(76)
        cboAño.ItemIndex = 0

        ConstruirTable()
        dgvDetracciones.DataSource = dtDetracciones

        btnActualizar.Enabled = False
        mGSetearTool(btnActualizar, "Actualizar", "Clic Para Actualizar Detracciones")
    End Sub

    Private Sub btnBuscarDetracciones_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarDetracciones.Click
        If String.IsNullOrEmpty(txtCliente.Text) Then
            SaimtMessageBox.mostrarAlertaInformativa("Ingrese un Cliente")
            txtCliente.Focus()
            Exit Sub
        End If
        Try
            If txtCliente.Text.Length > 0 Then
                Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarDetraccionesXPersonaXAño(txtCliente.Text, cboAño.EditValue)
                dtDetracciones.Clear()
                If ListaProPagos IsNot Nothing Then
                    For Each fProPagos As EEProPagos In ListaProPagos
                        dtDetracciones.LoadDataRow(New Object() {fProPagos.ProPaId, _
                               fProPagos.OContratoInm.ConInmId, _
                               fProPagos.OContratoInm.OInmueble.InmId, _
                               fProPagos.OContratoInm.OPersona.perNombresoRazon, _
                               fProPagos.Año, _
                               fProPagos.ProPaNroCuota, _
                               fProPagos.ProPaFechaPag, _
                               fProPagos.Monto, _
                               fProPagos.Detraccion, _
                               False
                         }, True)
                    Next
                    gvDetracciones.BestFitColumns()
                    mostrarMensajeBarra("")
                    btnActualizar.Enabled = True
                Else
                    mostrarMensajeBarra("No se Encontraron Resultados")
                    btnActualizar.Enabled = False
                End If
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub chkMarcarTodo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMarcarTodo.CheckedChanged
        If chkMarcarTodo.Checked Then
            For Each fRow As DataRow In dtDetracciones.Rows
                fRow("Pagado") = True
            Next
        Else
            For Each fRow As DataRow In dtDetracciones.Rows
                fRow("Pagado") = False
            Next
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Try
            Dim ListaProPaId As List(Of String) = Nothing

            For Each fRow As DataRow In dtDetracciones.Rows
                If Convert.ToBoolean(fRow("Pagado")) = True Then
                    If ListaProPaId Is Nothing Then
                        ListaProPaId = New List(Of String)
                    End If

                    ListaProPaId.Add(fRow("proPaId"))
                End If
            Next

            If ListaProPaId Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No se Selecciono Ninguna Fila")
            Else
                MantenimientosBL.Instancia.proPagosActualizarDetracciones(ListaProPaId)
                SaimtMessageBox.mostrarAlertaInformativa("Las Detracciones Fueron Actualizadas Correctamente")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarMes_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarMes.Click
        Try
            Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarDetraccionesXMesXAño(cboMes.EditValue, cboAño.EditValue)
            dtDetracciones.Clear()
            If ListaProPagos IsNot Nothing Then
                For Each fProPagos As EEProPagos In ListaProPagos
                    dtDetracciones.LoadDataRow(New Object() {fProPagos.ProPaId, _
                           fProPagos.OContratoInm.ConInmId, _
                           fProPagos.OContratoInm.OInmueble.InmId, _
                           fProPagos.OContratoInm.OPersona.perNombresoRazon, _
                           fProPagos.Año, _
                           fProPagos.ProPaNroCuota, _
                           fProPagos.ProPaFechaPag, _
                           fProPagos.Monto, _
                           fProPagos.Detraccion, _
                           False
                     }, True)
                Next

                gvDetracciones.BestFitColumns()
                mostrarMensajeBarra("")
                btnActualizar.Enabled = True
            Else
                mostrarMensajeBarra("No se Encontraron Resultados")
                btnActualizar.Enabled = False
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
End Class