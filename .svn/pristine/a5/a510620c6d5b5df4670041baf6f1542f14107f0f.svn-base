Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmGeneracionOrdenPago
    Inherits frmGeneral

    Dim dtProgramacionPagosGenerar As DataTable = New DataTable()
    Dim dtProgramacionPagosAnular As DataTable = New DataTable()
    Dim dtProgramacionPagosDet As DataTable = New DataTable()
    Dim SerieF, SerieB As String
    Dim NroFactura As Integer
    Dim NroBoleta As Integer

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtProgramacionPagosGenerar.Columns.Add("marcado", GetType(Boolean))
        dtProgramacionPagosGenerar.Columns.Add("tgtipoCompId", GetType(String))
        dtProgramacionPagosGenerar.Columns.Add("conInmId", GetType(String))
        dtProgramacionPagosGenerar.Columns.Add("inmId", GetType(String))
        dtProgramacionPagosGenerar.Columns.Add("Persona", GetType(String))
        dtProgramacionPagosGenerar.Columns.Add("Año", GetType(String))
        dtProgramacionPagosGenerar.Columns.Add("proPaNroCuota", GetType(String))
        dtProgramacionPagosGenerar.Columns.Add("proPaFechaPag", GetType(DateTime))
        dtProgramacionPagosGenerar.Columns.Add("Monto", GetType(Decimal))
        dtProgramacionPagosGenerar.Columns.Add("Detracion", GetType(Decimal))
        dtProgramacionPagosGenerar.Columns.Add("ProPaId", GetType(String))


        dtProgramacionPagosDet.Columns.Add("SerieComp", GetType(String))
        dtProgramacionPagosDet.Columns.Add("NroComp", GetType(String))
        dtProgramacionPagosDet.Columns.Add("tgtipoCompId", GetType(String))
        dtProgramacionPagosDet.Columns.Add("conInmId", GetType(String))
        dtProgramacionPagosDet.Columns.Add("inmId", GetType(String))
        dtProgramacionPagosDet.Columns.Add("Persona", GetType(String))
        dtProgramacionPagosDet.Columns.Add("Año", GetType(String))
        dtProgramacionPagosDet.Columns.Add("proPaNroCuota", GetType(String))
        dtProgramacionPagosDet.Columns.Add("proPaFechaPag", GetType(DateTime))
        dtProgramacionPagosDet.Columns.Add("Monto", GetType(Decimal))
        dtProgramacionPagosDet.Columns.Add("Detracion", GetType(Decimal))
        dtProgramacionPagosDet.Columns.Add("PropaId", GetType(String))



        dtProgramacionPagosAnular.Columns.Add("marcado", GetType(Boolean))
        dtProgramacionPagosAnular.Columns.Add("SerieComp", GetType(String))
        dtProgramacionPagosAnular.Columns.Add("NroComp", GetType(String))
        dtProgramacionPagosAnular.Columns.Add("tgtipoCompId", GetType(String))
        dtProgramacionPagosAnular.Columns.Add("conInmId", GetType(String))
        dtProgramacionPagosAnular.Columns.Add("inmId", GetType(String))
        dtProgramacionPagosAnular.Columns.Add("Persona", GetType(String))
        dtProgramacionPagosAnular.Columns.Add("Año", GetType(String))
        dtProgramacionPagosAnular.Columns.Add("proPaNroCuota", GetType(String))
        dtProgramacionPagosAnular.Columns.Add("proPaFechaPag", GetType(DateTime))
        dtProgramacionPagosAnular.Columns.Add("Monto", GetType(Decimal))
        dtProgramacionPagosAnular.Columns.Add("Detracion", GetType(Decimal))
        dtProgramacionPagosAnular.Columns.Add("PropaId", GetType(String))

    End Sub

#End Region

    Private Sub frmOrdenPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdbOpciones.SelectedIndex = 0
        cboAnioGenerar.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAnioGenerar.Properties.DisplayMember = "TgNombre"
        cboAnioGenerar.Properties.ValueMember = "TgCodigo"
        cboAnioGenerar.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(76)
        cboAnioGenerar.ItemIndex = 0

        cboMesGenerar.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboMesGenerar.Properties.DisplayMember = "TgNombre"
        cboMesGenerar.Properties.ValueMember = "TgCodigo"
        cboMesGenerar.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(40)
        cboMesGenerar.ItemIndex = 0

        cbAnioAnular.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cbAnioAnular.Properties.DisplayMember = "TgNombre"
        cbAnioAnular.Properties.ValueMember = "TgCodigo"
        cbAnioAnular.Properties.DataSource = cboAnioGenerar.Properties.DataSource
        cbAnioAnular.ItemIndex = 0

        cbMesAnular.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cbMesAnular.Properties.DisplayMember = "TgNombre"
        cbMesAnular.Properties.ValueMember = "TgCodigo"
        cbMesAnular.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(40)
        cbMesAnular.ItemIndex = 0

        ConstruirTable()
        dgvProgramacionAnular.DataSource = dtProgramacionPagosAnular
        gvProgramacionPagosAnular.BestFitColumns()
        dgvProgramacionPagos.DataSource = dtProgramacionPagosGenerar
        gvProgramacionPagos.BestFitColumns()
        dgvProgramacionPagosDet.DataSource = dtProgramacionPagosDet
        gvProgramacionPagosDet.BestFitColumns()

    End Sub

    Private Sub btnBuscarXAnioMesGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarXMesGenerar.Click
        Try
            If rdbOpciones.SelectedIndex = -1 Then
                rdbOpciones.SelectedIndex = 0
                Return
            End If

            If cboAnioGenerar.EditValue = "" Then
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione el Anio que decea mostrar")
                Return
            End If
            If cboMesGenerar.EditValue = "" Then
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione el mes que decea mostrar")
                Return
            End If
            Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarGeneracionOrdenesPagoCriterio(rdbOpciones.EditValue, cboAnioGenerar.EditValue, cboMesGenerar.EditValue, Nothing)
            dtProgramacionPagosGenerar.Clear()
            If ListaProPagos IsNot Nothing Then
                For Each fProPagos As EEProPagos In ListaProPagos
                    dtProgramacionPagosGenerar.LoadDataRow(New Object() {False, _
                           fProPagos.OTgTipoComprobante.TgNombre, _
                           fProPagos.OContratoInm.ConInmId, _
                           fProPagos.OContratoInm.OInmueble.InmId, _
                           fProPagos.OContratoInm.OPersona.perNombresoRazon, _
                           fProPagos.Año, _
                           fProPagos.ProPaNroCuota, _
                           fProPagos.ProPaFechaPag, _
                           fProPagos.Monto, _
                           fProPagos.Detraccion, _
                           fProPagos.ProPaId
                     }, True)
                Next

                dgvProgramacionPagos.DataSource = dtProgramacionPagosGenerar
                gvProgramacionPagos.BestFitColumns()
                mostrarMensajeBarra("")
            Else
                mostrarMensajeBarra("No se Encontraron Resultados")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnAsignar_Click(sender As System.Object, e As System.EventArgs) Handles btnAsignar.Click
        Try

            Dim pasa As Boolean = False
            Dim b As Integer
            Dim f As Integer
            For Each fRowDet As DataRow In dtProgramacionPagosGenerar.Rows
                If fRowDet("marcado") = True Then

                    If Convert.ToString(fRowDet("tgtipoCompId")) = "Boleta" Then
                        b = b + 1
                    End If
                    If Convert.ToString(fRowDet("tgtipoCompId")) = "Factura" Then
                        f = f + 1
                    End If
                    pasa = True
                    If b > 0 And f > 0 Then
                        Exit For
                    End If
                End If
            Next

            SerieF = txtSerieFactura.Text
            NroFactura = Val(txtNroInicioFactura.Text)
            SerieB = txtSerieBoleta.Text
            NroBoleta = Val(TxtNroInicioBoleta.Text)

            If f > 0 Then
                If SerieF Is Nothing Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese la Serie de la Factura")
                    txtSerieFactura.Select()
                    Return
                End If
                If Val(txtNroInicioFactura.Text) <= 0 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro Inicial de Factura")
                    TxtNroInicioBoleta.Select()
                    Return
                End If

                If Val(txtNroFinFactura.Text) <= 0 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro Final de Factura")
                    txtNroFinFactura.Select()
                    Return
                End If

                If Val(txtNroFinFactura.Text) < Val(txtNroInicioFactura.Text) Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro Final no debe ser menor que el Inicial de Factura")
                    txtNroFinFactura.Select()
                    Return
                End If
                Dim FNroMax, FCountRep As Integer
                Dim ListaFCompProgramacion As List(Of EECompProgramacion) = MantenimientosBL.Instancia.CompProgramacionValidarSugerir(txtNroInicioFactura.Text, txtNroFinFactura.Text, txtSerieFactura.Text)
                If ListaFCompProgramacion IsNot Nothing Then
                    For Each fCompPro As EECompProgramacion In ListaFCompProgramacion
                        FCountRep = fCompPro.CountComp
                        FNroMax = fCompPro.NroMaxComp
                    Next
                End If
                If FCountRep > 0 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia(String.Format("Los numeros comprendidos de {0} - {1} al {2} - {3}, Ya se encuentran registrados", txtSerieFactura.Text.ToUpper, txtNroInicioFactura.Text, txtSerieFactura.Text, txtNroFinFactura.Text))
                    SaimtMessageBox.mostrarAlertaAdvertencia(String.Format("Sugerencia: el ultimo numero registrado de la serie {0} fue {1}", txtSerieFactura.Text.ToUpper, FNroMax))
                    Return
                End If
            End If

            If b > 0 Then
                If SerieB Is Nothing Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese la Serie de la Boleta")
                    txtSerieBoleta.Select()
                    Return
                End If
                If Val(TxtNroInicioBoleta.Text) <= 0 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro Inicial de Boleta")
                    TxtNroInicioBoleta.Select()
                    Return
                End If

                If Val(txtNroFinBoleta.Text) <= 0 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro Final de Boleta")
                    txtNroFinBoleta.Select()
                    Return
                End If

                If Val(txtNroFinBoleta.Text) < Val(txtNroFinBoleta.Text) Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nro Final no debe ser menor que el Inicial de Boleta")
                    txtNroFinBoleta.Select()
                    Return
                End If
                Dim BNroMax, BCountRep As Integer
                Dim ListaBCompProgramacion As List(Of EECompProgramacion) = MantenimientosBL.Instancia.CompProgramacionValidarSugerir(TxtNroInicioBoleta.Text, txtNroFinBoleta.Text, txtSerieBoleta.Text)
                If ListaBCompProgramacion IsNot Nothing Then
                    For Each fCompPro As EECompProgramacion In ListaBCompProgramacion
                        BCountRep = fCompPro.CountComp
                        BNroMax = fCompPro.NroMaxComp
                    Next
                End If

                If BCountRep > 0 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia(String.Format("Los numeros comprendidos de {0}-{1} al {2} - {3}, Ya se encuentran registrados", txtSerieBoleta.Text.ToUpper, TxtNroInicioBoleta.Text, txtSerieBoleta.Text, txtNroFinBoleta.Text))
                    SaimtMessageBox.mostrarAlertaAdvertencia(String.Format("Sugerencia: el ultimo numero registrado de la serie {0} fue {1}", txtSerieBoleta.Text.ToUpper, BNroMax))
                    Return
                End If
            End If

            If pasa = False Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese los datos: Serie, Nro Inicial, Nro Final de la Factura o Boleta correctamente para ser asignado")
                Return
            End If
            If dtProgramacionPagosGenerar.Rows.Count > 0 Then
                For Each fRow As DataRow In dtProgramacionPagosGenerar.Rows
                    Dim existe As Boolean = False
                    If Convert.ToBoolean(fRow("marcado")) = True Then

                        For Each fRowDet As DataRow In dtProgramacionPagosDet.Rows
                            If fRowDet("conInmId") = fRow("conInmId") And fRowDet("ProPaNroCuota") = fRow("ProPaNroCuota") Then
                                If fRowDet("SerieComp") = SerieB And fRowDet("NroComp") = NroBoleta Then
                                    existe = True
                                    Exit For
                                End If
                            End If
                        Next

                        If existe = False Then
                            If Convert.ToString(fRow("tgtipoCompId")) = "Boleta" And NroBoleta <= txtNroFinBoleta.Text And NroBoleta > 0 Then

                                dtProgramacionPagosDet.LoadDataRow(New Object() {
                                      SerieB, _
                                      NroBoleta, _
                                           fRow("tgtipoCompId"), _
                                           fRow("conInmId"), _
                                           fRow("inmId"), _
                                           fRow("Persona"), _
                                           fRow("Año"), _
                                           fRow("ProPaNroCuota"), _
                                           fRow("ProPaFechaPag"), _
                                           fRow("Monto"), _
                                           fRow("Detracion"), _
                                           fRow("ProPaId")
                                     }, True)
                                NroBoleta = NroBoleta + 1
                            ElseIf Convert.ToString(fRow("tgtipoCompId")) = "Factura" And NroFactura <= txtNroFinFactura.Text And NroFactura > 0 Then

                                dtProgramacionPagosDet.LoadDataRow(New Object() {
                                      SerieF, _
                                      NroFactura, _
                                      fRow("tgtipoCompId"), _
                                      fRow("conInmId"), _
                                      fRow("inmId"), _
                                      fRow("Persona"), _
                                      fRow("Año"), _
                                      fRow("ProPaNroCuota"), _
                                      fRow("ProPaFechaPag"), _
                                      fRow("Monto"), _
                                      fRow("Detracion"), _
                                      fRow("ProPaId")
                                }, True)
                                NroFactura = NroFactura + 1
                            End If
                        End If
                    End If
                    gvProgramacionPagosDet.BestFitColumns()
                Next

            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("No Existe Programaciones de pagos seleccionados")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkMarcarTodo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMarcarTodo.CheckedChanged
        If chkMarcarTodo.Checked Then
            For Each fRow As DataRow In dtProgramacionPagosGenerar.Rows
                fRow("marcado") = True
            Next
        Else
            For Each fRow As DataRow In dtProgramacionPagosGenerar.Rows
                fRow("marcado") = False
            Next
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim loCompProgramacion As EECompProgramacion = New EECompProgramacion()
        Dim NroInsert As Integer
        If dtProgramacionPagosDet.Rows.Count > 0 Then

            For Each fRowDet As DataRow In dtProgramacionPagosDet.Rows
                loCompProgramacion.CompProPagSerie = fRowDet("SerieComp")
                loCompProgramacion.CompProPagNro = fRowDet("NroComp")
                loCompProgramacion.ProPaId = fRowDet("ProPaId")
                loCompProgramacion.TgEstCompId = "P"
                loCompProgramacion.TgTipoCompId = IIf(fRowDet("tgtipoCompId") = "Boleta", "B", "F")
                If MantenimientosBL.Instancia.compprogramacionGuardar(loCompProgramacion) = True Then
                    NroInsert = NroInsert + 1
                End If
            Next
            If NroInsert = dtProgramacionPagosDet.Rows.Count Then
                SaimtMessageBox.mostrarAlertaInformativa("Se guardo correctamente")
                dtProgramacionPagosGenerar.Clear()
                dgvProgramacionPagos.DataSource = dtProgramacionPagosGenerar
                dtProgramacionPagosDet.Clear()
                dgvProgramacionPagosDet.DataSource = dtProgramacionPagosDet
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Existen Datos a Guardar")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        dtProgramacionPagosGenerar.Clear()
        dgvProgramacionPagos.DataSource = dtProgramacionPagosGenerar
        dtProgramacionPagosDet.Clear()
        dgvProgramacionPagosDet.DataSource = dtProgramacionPagosDet
    End Sub

    Private Sub btnMostrarAnioMesAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrarAnioMesAnular.Click
        Try

            If cbAnioAnular.EditValue = "" Then
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione el Anio que decea mostrar")
                Return
            End If
            If cbMesAnular.EditValue = "" Then
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione el mes que decea mostrar")
                Return
            End If
            Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarOrdenesPagoCriterio(cbAnioAnular.EditValue, cbMesAnular.EditValue)
            dtProgramacionPagosAnular.Clear()
            If ListaProPagos IsNot Nothing Then
                For Each fProPagos As EEProPagos In ListaProPagos
                    dtProgramacionPagosAnular.LoadDataRow(New Object() {False,
                                            fProPagos.OCompProgramacion.CompProPagSerie, _
                                            fProPagos.OCompProgramacion.CompProPagNro, _
                                            fProPagos.OTgTipoComprobante.TgCodigo, _
                                            fProPagos.OContratoInm.ConInmId, _
                                            fProPagos.OContratoInm.InmId, _
                                            fProPagos.OContratoInm.OPersona.perNombresoRazon, _
                                            fProPagos.Año, _
                                            fProPagos.ProPaNroCuota, _
                                            fProPagos.ProPaFechaPag, _
                                            fProPagos.TempMonto, _
                                            fProPagos.Detraccion, _
                                            fProPagos.ProPaId
                                      }, True)
                Next

                gvProgramacionPagosAnular.BestFitColumns()
                mostrarMensajeBarra("")
            Else
                mostrarMensajeBarra("No se Encontraron Resultados")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub


    Private Sub btnNroCompCliente_Click(sender As System.Object, e As System.EventArgs) Handles btnNroCompCliente.Click
        Try
            Dim Nrocomp, cliente, anio, mes As String
            If txtBuscarNroCompCliente.Text = "" Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el valor a buscar")
                txtBuscarNroCompCliente.Focus()
                Return
            End If

            Nrocomp = txtBuscarNroCompCliente.Text
            cliente = txtBuscarNroCompCliente.Text
            If rbNroCompCliente.SelectedIndex = 0 Then
                cliente = Nothing
            ElseIf rbNroCompCliente.SelectedIndex = 1 Then
                Nrocomp = Nothing
            End If

            If chkAnioMesAnular.Checked = True Then
                anio = cbAnioAnular.EditValue
                mes = cbMesAnular.EditValue
            Else
                anio = Nothing
                mes = Nothing
            End If

            Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarOrdenesPagoCriterio(anio, mes, cliente, Nrocomp)
            dtProgramacionPagosAnular.Clear()
            If ListaProPagos IsNot Nothing Then
                For Each fProPagos As EEProPagos In ListaProPagos
                    dtProgramacionPagosAnular.LoadDataRow(New Object() {False,
                                            fProPagos.OCompProgramacion.CompProPagSerie, _
                                            fProPagos.OCompProgramacion.CompProPagNro, _
                                            fProPagos.OTgTipoComprobante.TgCodigo, _
                                            fProPagos.OContratoInm.ConInmId, _
                                            fProPagos.OContratoInm.InmId, _
                                            fProPagos.OContratoInm.OPersona.perNombresoRazon, _
                                            fProPagos.Año, _
                                            fProPagos.ProPaNroCuota, _
                                            fProPagos.ProPaFechaPag, _
                                            fProPagos.TempMonto, _
                                            fProPagos.Detraccion, _
                                            fProPagos.ProPaId
                                      }, True)
                Next

                gvProgramacionPagosAnular.BestFitColumns()
                mostrarMensajeBarra("")
            Else
                mostrarMensajeBarra("No se Encontraron Resultados")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click
        If SaimtMessageBox.mostrarAlertaPregunta("Esta Seguro que desea anular los item seleccionados?") = True Then
            Dim loCompProgramacion As EECompProgramacion = New EECompProgramacion()
            Dim NroInsert, marcados As Integer
            For Each fRowDet As DataRow In dtProgramacionPagosAnular.Rows
                If fRowDet("marcado") = True Then
                    marcados = marcados + 1
                End If
            Next

            If marcados > 0 Then

                For Each fRowDet As DataRow In dtProgramacionPagosAnular.Rows
                    If fRowDet("marcado") = True Then
                        loCompProgramacion.CompProPagSerie = fRowDet("SerieComp").ToString.TrimEnd
                        loCompProgramacion.CompProPagNro = fRowDet("NroComp").ToString.TrimEnd
                        loCompProgramacion.ProPaId = fRowDet("ProPaId").ToString.TrimEnd
                        loCompProgramacion.TgEstCompId = "A"
                        loCompProgramacion.TgTipoCompId = fRowDet("tgtipoCompId").ToString.TrimEnd
                        If MantenimientosBL.Instancia.compprogramacionActualizar(loCompProgramacion) = True Then
                            NroInsert = NroInsert + 1
                        End If
                    End If

                Next
                If NroInsert = marcados Then
                    SaimtMessageBox.mostrarAlertaInformativa("Se guardo correctamente")
                    dtProgramacionPagosAnular.Clear()
                    dgvProgramacionAnular.DataSource = dtProgramacionPagosAnular
                End If
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("No Existen Datos a Guardar")
            End If
        End If
    End Sub

    Private Sub SaimtButton1_Click(sender As System.Object, e As System.EventArgs) Handles SaimtButton1.Click
        If SaimtMessageBox.mostrarAlertaPregunta("Esta Seguro que desea Cancelar los item seleccionados?") = True Then
            Dim loCompProgramacion As EECompProgramacion = New EECompProgramacion()
            Dim NroInsert, marcados As Integer
            For Each fRowDet As DataRow In dtProgramacionPagosAnular.Rows
                If fRowDet("marcado") = True Then
                    marcados = marcados + 1
                End If
            Next

            If marcados > 0 Then

                For Each fRowDet As DataRow In dtProgramacionPagosAnular.Rows
                    If fRowDet("marcado") = True Then
                        loCompProgramacion.CompProPagSerie = fRowDet("SerieComp").ToString.TrimEnd
                        loCompProgramacion.CompProPagNro = fRowDet("NroComp").ToString.TrimEnd
                        loCompProgramacion.ProPaId = fRowDet("ProPaId").ToString.TrimEnd
                        loCompProgramacion.TgEstCompId = "C"
                        loCompProgramacion.TgTipoCompId = fRowDet("tgtipoCompId").ToString.TrimEnd
                        If MantenimientosBL.Instancia.compprogramacionActualizar(loCompProgramacion) = True Then
                            NroInsert = NroInsert + 1
                        End If
                    End If

                Next
                If NroInsert = marcados Then
                    SaimtMessageBox.mostrarAlertaInformativa("Se guardo correctamente los item cancelados")
                    dtProgramacionPagosAnular.Clear()
                    dgvProgramacionAnular.DataSource = dtProgramacionPagosAnular
                End If
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("No Existen Datos a Guardar")
            End If
        End If
    End Sub

    Private Sub btnBuscarXClienteGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarXClienteGenerar.Click
        Dim anio As String = Nothing
        Dim mes As String = Nothing
        If txtClienteGenerar.Text = "" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el cliente a buscar")
            Return
        End If
        If rdbOpciones.SelectedIndex = -1 Then
            rdbOpciones.SelectedIndex = 0
            Return
        End If
        If chkaplicaaniomes.Checked = True Then
            anio = cboAnioGenerar.EditValue
            mes = cboMesGenerar.EditValue
        End If
        Try
            Dim ListaProPagos As List(Of EEProPagos) = MantenimientosBL.Instancia.proPagosListarGeneracionOrdenesPagoCriterio(rdbOpciones.EditValue, anio, mes, txtClienteGenerar.Text)
            dtProgramacionPagosGenerar.Clear()
            If ListaProPagos IsNot Nothing Then
                For Each fProPagos As EEProPagos In ListaProPagos
                    dtProgramacionPagosGenerar.LoadDataRow(New Object() {False, _
                           fProPagos.OTgTipoComprobante.TgNombre, _
                           fProPagos.OContratoInm.ConInmId, _
                           fProPagos.OContratoInm.OInmueble.InmId, _
                           fProPagos.OContratoInm.OPersona.perNombresoRazon, _
                           fProPagos.Año, _
                           fProPagos.ProPaNroCuota, _
                           fProPagos.ProPaFechaPag, _
                           fProPagos.Monto, _
                           fProPagos.Detraccion, _
                           fProPagos.ProPaId
                     }, True)
                Next

                dgvProgramacionPagos.DataSource = dtProgramacionPagosGenerar
                gvProgramacionPagos.BestFitColumns()
                mostrarMensajeBarra("")
            Else
                mostrarMensajeBarra("No se Encontraron Resultados")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
End Class