Imports ReglasNegocio
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports SaimtControles
Public Class frmProPagMant
    Inherits frmGeneral

    Dim data(21) As String
    Dim xl As Excel.Application = EEExcel.Instancia

    Dim listagastocomision As List(Of EEGastoComision)
    Dim fechacomision As Date
    Dim fila As Integer = 0
    ''' <summary>
    ''' Para Hacer que el Evento al Seleccionar Fecha Se Ejecute despues de Load
    ''' </summary>
    ''' <remarks></remarks>
    Dim lbCargaDatosImportados As Boolean = True
    Dim dtTempProPagos As DataTable = New DataTable()

#Region "Construir Table Temp ProPagos"
    Private Sub ConstruirTableTempProPagos()
        dtTempProPagos.Columns.Add("proPaId", GetType(String))
        dtTempProPagos.Columns.Add("año", GetType(Int16))
        dtTempProPagos.Columns.Add("codContrato", GetType(String))
        dtTempProPagos.Columns.Add("codPersona", GetType(String))
        dtTempProPagos.Columns.Add("persona", GetType(String))
        dtTempProPagos.Columns.Add("contacto", GetType(String))
        dtTempProPagos.Columns.Add("nroCuota", GetType(Int16))
        dtTempProPagos.Columns.Add("codConcepto", GetType(String))
        dtTempProPagos.Columns.Add("concepto", GetType(String))
        dtTempProPagos.Columns.Add("p_saimt", GetType(Decimal))
        dtTempProPagos.Columns.Add("p_mpt", GetType(Decimal))
        dtTempProPagos.Columns.Add("fechaVencimiento", GetType(Date))
        dtTempProPagos.Columns.Add("monto", GetType(Decimal))
        dtTempProPagos.Columns.Add("estado", GetType(String))
        dtTempProPagos.Columns.Add("fechaPago", GetType(Date))
        dtTempProPagos.Columns.Add("cta_saimt", GetType(Decimal))
        dtTempProPagos.Columns.Add("cta_mpt", GetType(Decimal))
        dtTempProPagos.Columns.Add("moraSaimt", GetType(Decimal))
        dtTempProPagos.Columns.Add("moraMpt", GetType(Decimal))
        dtTempProPagos.Columns.Add("com_cta_saimt", GetType(Decimal))
        dtTempProPagos.Columns.Add("com_cta_mpt", GetType(Decimal))
        dtTempProPagos.Columns.Add("totalPagar", GetType(Decimal))
    End Sub
#End Region

    Private Sub bteruta_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bteruta.ButtonClick
        Me.ofdimportar.Filter = "Archivos de Excel(*.xls;*.xlsx)|*.xls;*.xlsx"
        If Me.ofdimportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.bteruta.Text = Me.ofdimportar.FileName.Trim

            CargarVisor(Me.bteruta.Text.Trim)
            mostrarMensajeBarra("")
            btnImportar.Enabled = True
        End If
    End Sub

    Private Sub CargarVisor(ByVal path As String)
        fila = 1
        Me.tlImportar.Nodes.Clear()
        xl.Workbooks.Open(path, 1, True, 4)
        xl.Sheets(1).Select()
        While Trim(xl.Cells(fila, 1).Value) <> "ProPaId" And fila < 20
            fila = fila + 1
        End While
        If Not Trim(xl.Cells(fila, 1).Value) = "ProPaId" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 2).Value) = "Año" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 3).Value) = "Contrato" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 4).Value) = "PerId" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 5).Value) = "Persona" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 6).Value) = "Contacto" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 7).Value) = "NroCuota" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 8).Value) = "ConceptoId" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 9).Value) = "Concepto" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 10).Value) = "P_SAIMT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 11).Value) = "P_MPT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 12).Value) = "FechaVenc" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 13).Value) = "Monto" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 14).Value) = "tgEstadoId" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 15).Value) = "FechaPago" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 16).Value) = "Cta_SAIMT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 17).Value) = "Cta_MPT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 18).Value) = "Mora_Cta_SAIMT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 19).Value) = "Mora_Cta_MPT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 20).Value) = "Com_Cta_SAIMT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 21).Value) = "Com_Cta_MPT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 22).Value) = "TotalPagar" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        fila = fila + 1
        While xl.Cells(fila, 3).Value <> String.Empty
            data(0) = Format(xl.Cells(fila, 7).Value, "00") & xl.Cells(fila, 3).Value
            data(1) = Year(xl.Cells(fila, 15).Value)
            data(2) = xl.Cells(fila, 3).Value
            data(3) = xl.Cells(fila, 4).Value
            data(4) = xl.Cells(fila, 5).Value
            data(5) = xl.Cells(fila, 6).Value
            data(6) = xl.Cells(fila, 7).Value
            data(7) = xl.Cells(fila, 8).Value
            data(8) = xl.Cells(fila, 9).Value
            data(9) = xl.Cells(fila, 10).Value
            data(10) = xl.Cells(fila, 11).Value
            data(11) = xl.Cells(fila, 12).Value
            data(12) = xl.Cells(fila, 13).Value
            data(13) = xl.Cells(fila, 14).Value
            data(14) = xl.Cells(fila, 15).Value
            data(15) = xl.Cells(fila, 16).Value
            data(16) = xl.Cells(fila, 17).Value
            data(17) = xl.Cells(fila, 18).Value
            data(18) = xl.Cells(fila, 19).Value
            data(19) = xl.Cells(fila, 20).Value
            data(20) = xl.Cells(fila, 21).Value
            data(21) = xl.Cells(fila, 22).Value
            Me.tlImportar.AppendNode(data, -1)
            fila = fila + 1
        End While
        data(0) = Format(xl.Cells(fila, 7).Value, "00") & xl.Cells(fila, 3).Value
        data(1) = Year(xl.Cells(fila, 15).Value)
        data(2) = xl.Cells(fila, 3).Value
        data(3) = xl.Cells(fila, 4).Value
        data(4) = xl.Cells(fila, 5).Value
        data(5) = xl.Cells(fila, 6).Value
        data(6) = xl.Cells(fila, 7).Value
        data(7) = xl.Cells(fila, 8).Value
        data(8) = xl.Cells(fila, 9).Value
        data(9) = xl.Cells(fila, 10).Value
        data(10) = xl.Cells(fila, 11).Value
        data(11) = xl.Cells(fila, 12).Value
        data(12) = xl.Cells(fila, 13).Value
        data(13) = xl.Cells(fila, 14).Value
        data(14) = xl.Cells(fila, 15).Value
        data(15) = xl.Cells(fila, 16).Value
        data(16) = xl.Cells(fila, 17).Value
        data(17) = xl.Cells(fila, 18).Value
        data(18) = xl.Cells(fila, 19).Value
        data(19) = xl.Cells(fila, 20).Value
        data(20) = xl.Cells(fila, 21).Value
        data(21) = xl.Cells(fila, 22).Value
        Me.tlImportar.AppendNode(data, -1)
        xl.ActiveWorkbook.Close()
        Me.tlImportar.BestFitColumns()
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Try

            If Me.tlImportar.Nodes.Count > 0 Then
                If SaimtMessageBox.mostrarAlertaPregunta("¿Esta seguro que desea importar los datos mostrados en el Visor?") Then
                    Dim loProPagos As EEProPagos = New EEProPagos()

                    Dim loComision = New EEGastoComision()
                    loComision.GasComFec = Convert.ToDateTime(Me.tlImportar.Nodes(Me.tlImportar.Nodes.Count - 1).GetValue(Me.tlcFechaPago))
                    loComision.GasComValor = Convert.ToDecimal(Me.tlImportar.Nodes(Me.tlImportar.Nodes.Count - 1).GetValue(Me.tlcMonto))
                    loComision.TgRecaudadoraId = "02"

                    loProPagos.OGastoComision = loComision

                    Dim htPropaId As Hashtable = New Hashtable()
                    Dim loTempProPagos As EETemp_ProPagos

                    For col As Integer = 0 To Me.tlImportar.Nodes.Count - 2
                        loTempProPagos = New EETemp_ProPagos()

                        If loProPagos.ListaTempProPagos Is Nothing Then
                            loProPagos.ListaTempProPagos = New List(Of EETemp_ProPagos)
                        End If


                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcProPaId) Is Nothing Then
                            loTempProPagos.ProPaId = String.Empty
                        Else
                            loTempProPagos.ProPaId = Me.tlImportar.Nodes(col).GetValue(Me.tlcProPaId).ToString.Trim()
                        End If
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcanio) Is Nothing Then
                            loTempProPagos.ProPaAño = String.Empty
                        Else
                            loTempProPagos.ProPaAño = Me.tlImportar.Nodes(col).GetValue(Me.tlcanio).ToString.Trim
                        End If
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcContrato) Is Nothing Then
                            loTempProPagos.ContId = String.Empty
                        Else
                            loTempProPagos.ContId = Me.tlImportar.Nodes(col).GetValue(Me.tlcContrato).ToString.Trim
                        End If
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcPerId) Is Nothing Then
                            loTempProPagos.PerId = String.Empty
                        Else
                            loTempProPagos.PerId = Me.tlImportar.Nodes(col).GetValue(Me.tlcPerId).ToString.Trim
                        End If
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcPersona) Is Nothing Then
                            loTempProPagos.Persona = String.Empty
                        Else
                            loTempProPagos.Persona = Me.tlImportar.Nodes(col).GetValue(Me.tlcPersona).ToString.Trim()
                        End If
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcContacto) Is Nothing Then
                            loTempProPagos.Contacto = String.Empty
                        Else
                            loTempProPagos.Contacto = Me.tlImportar.Nodes(col).GetValue(Me.tlcContacto).ToString.Trim
                        End If
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcNroCuota) Is Nothing Then
                            loTempProPagos.ProPaNroCuota = 0
                        Else
                            loTempProPagos.ProPaNroCuota = Convert.ToInt32(Me.tlImportar.Nodes(col).GetValue(Me.tlcNroCuota).ToString.Trim)
                        End If

                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcConceptoId) Is Nothing Then
                            loTempProPagos.ConId = String.Empty
                        Else
                            loTempProPagos.ConId = Me.tlImportar.Nodes(col).GetValue(Me.tlcConceptoId).ToString.Trim
                        End If
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcConcepto) Is Nothing Then
                            loTempProPagos.ConNombre = String.Empty
                        Else
                            loTempProPagos.ConNombre = Me.tlImportar.Nodes(col).GetValue(Me.tlcConcepto).ToString.Trim
                        End If
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcp_saimt) Is Nothing Then
                            loTempProPagos.ProPa_PSaimt = 0
                        Else
                            loTempProPagos.ProPa_PSaimt = Convert.ToDecimal(Me.tlImportar.Nodes(col).GetValue(Me.tlcp_saimt).ToString.Trim)
                        End If
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcp_mpt) Is Nothing Then
                            loTempProPagos.ProPa_PMpt = 0
                        Else
                            loTempProPagos.ProPa_PMpt = Convert.ToDecimal(Me.tlImportar.Nodes(col).GetValue(Me.tlcp_mpt).ToString.Trim)
                        End If
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlcFechaVenc) Is Nothing Then
                            loTempProPagos.ProPaFecVen = Nothing
                        Else
                            loTempProPagos.ProPaFecVen = CDate(Me.tlImportar.Nodes(col).GetValue(Me.tlcFechaVenc).ToString.Trim)
                        End If
                        loTempProPagos.ProPaDetMonto = Convert.ToDecimal(Me.tlImportar.Nodes(col).GetValue(Me.tlcMonto).ToString.Trim)
                        loTempProPagos.TgEstadoId = Me.tlImportar.Nodes(col).GetValue(Me.tlctgEstadoId).ToString.Trim
                        loTempProPagos.ProPaFecPag = CDate(Me.tlImportar.Nodes(col).GetValue(Me.tlcFechaPago).ToString.Trim)
                        loTempProPagos.ProPaCtaSaimt = Convert.ToDecimal(Me.tlImportar.Nodes(col).GetValue(Me.tlcCta_SAIMT).ToString.Trim)
                        loTempProPagos.ProPaCtaMpt = Convert.ToDecimal(Me.tlImportar.Nodes(col).GetValue(Me.tlcCta_MPT).ToString.Trim)
                        loTempProPagos.ProPaMoraSaimt = Convert.ToDecimal(Me.tlImportar.Nodes(col).GetValue(Me.tlcMora_Cta_SAIMT).ToString.Trim)
                        loTempProPagos.ProPaMoraMpt = Convert.ToDecimal(Me.tlImportar.Nodes(col).GetValue(Me.tlcMora_Cta_MPT).ToString.Trim)
                        loTempProPagos.ProPaComCtaSaimt = Convert.ToDecimal(Me.tlImportar.Nodes(col).GetValue(Me.tlcCom_Cta_SAIMT).ToString.Trim)
                        loTempProPagos.ProPaComCtaMpt = Convert.ToDecimal(Me.tlImportar.Nodes(col).GetValue(Me.tlcCom_Cta_MPT).ToString.Trim)
                        loTempProPagos.ProPaTotal = Convert.ToDecimal(Me.tlImportar.Nodes(col).GetValue(Me.tlcTotalPagar).ToString.Trim)
                        loTempProPagos.proPaActualizado = False
                        loTempProPagos.proPaFecAct = Nothing

                        If htPropaId(loTempProPagos.ProPaId) Is Nothing Then
                            htPropaId.Add(loTempProPagos.ProPaId, String.Format("{0}-{1}-{2}-{3}", loTempProPagos.ProPaId, loTempProPagos.TgEstadoId, loTempProPagos.ProPaFecPag, loTempProPagos.ContId))
                        End If
                        loProPagos.ListaTempProPagos.Add(loTempProPagos)
                    Next

                    Dim ldProPaComision As Decimal = 0.25
                    'CDec(loComision.GasComValor) / CDec(htPropaId.Count)
                    Dim loTablaGeneral As EETablaGeneral = Nothing
                    Dim loProPagosAct As EEProPagos = Nothing
                    Dim loContratoInm As EEContratoInm = Nothing

                    For Each fDicEntry As DictionaryEntry In htPropaId
                        loProPagosAct = New EEProPagos()
                        If loProPagos.ListaProPagos Is Nothing Then
                            loProPagos.ListaProPagos = New List(Of EEProPagos)
                        End If
                        Dim lsSplit As String() = fDicEntry.Value.ToString().Split("-")

                        'Estado Programacion Pagos
                        loTablaGeneral = New EETablaGeneral()
                        loTablaGeneral.TgCodigo = lsSplit(1)

                        loProPagosAct.OTgEstado = loTablaGeneral

                        loProPagosAct.ProPaId = lsSplit(0)

                        loProPagosAct.ProPaFechaPag = CDate(lsSplit(2))
                        loProPagosAct.ProPaComision = ldProPaComision

                        'Recaudadora 02 = Caja Trujillo
                        loTablaGeneral = New EETablaGeneral()
                        loTablaGeneral.TgCodigo = "02"
                        loProPagosAct.OTgRecaudadora = loTablaGeneral

                        'Moneda
                        loTablaGeneral = New EETablaGeneral()
                        loTablaGeneral.TgCodigo = "S"
                        loProPagosAct.OTgMoneda = loTablaGeneral

                        loContratoInm = New EEContratoInm()
                        loContratoInm.ConInmId = lsSplit(3)
                        loProPagosAct.OContratoInm = loContratoInm
                        loProPagos.ListaProPagos.Add(loProPagosAct)
                    Next
                    MantenimientosBL.Instancia.proPagosImportar(loProPagos)
                    tlImportar.Nodes.Clear()
                    mImportado()
                End If
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("No Existen Datos que Importar")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub mImportado()
        bteruta.Text = ""
        btnImportar.Enabled = False
        mostrarMensajeBarra("Los Datos Se Importo Correctamente.")
    End Sub

    Private Sub frmProPagMant_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnImportar.Enabled = False
        lbCargaDatosImportados = False
        ConstruirTableTempProPagos()
        dgvTempProPagos.DataSource = dtTempProPagos
    End Sub

    Private Sub btnexportar_Click(sender As System.Object, e As System.EventArgs) Handles btnexportar.Click
        Dim xl As Excel.Application
        Try
            xl = EEExcel.Instancia
            xl.Workbooks.Open(EEComun.RutaReportes & "\RptExportarDataFincas.xls", 1, True, 4)
            Me.btnexportar.Enabled = False
            ExportarDataProPagos(xl.Sheets(1), 2)

            If fbdexportar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                xl.ActiveWorkbook.SaveAs(String.Format("{0}\Programacion_Pagos_{1}", Me.fbdexportar.SelectedPath, Format(MantenimientosBL.Instancia.FechaServidor, "dd-MM-yyyy")))
                xl.ActiveWorkbook.Close()
                Me.bsiMensaje.Caption = "El archivo se guardo con exito en la carpeta seleccionada"
            End If
            Me.btnexportar.Enabled = True
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaAdvertencia(ex.Message)
        End Try
    End Sub

    Private Sub ExportarDataProPagos(ByVal xlHoja As Excel.Worksheet, ByVal xlfila As Integer)
        Dim ListaExportarProgramacionPagos As List(Of EETemp_ProPagos) = MantenimientosBL.Instancia.proPagosExportar()
        Try
            Me.beiprogress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.riprogress.Minimum = 1
            Me.riprogress.Maximum = ListaExportarProgramacionPagos.Count
            Me.riprogress.Step = 1
            Me.beiprogress.Caption = "Exportando Datos... "
            xlHoja.Select()
            If ListaExportarProgramacionPagos IsNot Nothing Then
                For Each fProPagos As EETemp_ProPagos In ListaExportarProgramacionPagos
                    Application.DoEvents()
                    Me.beiprogress.Caption = String.Format("Exportando Datos({0} de {1} Registros)...", xlfila, ListaExportarProgramacionPagos.Count)
                    Me.beiprogress.EditValue = xlfila
                    xl.Cells(xlfila, 1) = fProPagos.ProPaId
                    xl.Cells(xlfila, 2) = fProPagos.ProPaAño
                    xl.Cells(xlfila, 3) = fProPagos.ContId
                    xl.Cells(xlfila, 4) = fProPagos.PerId
                    xl.Cells(xlfila, 5) = fProPagos.Persona
                    xl.Cells(xlfila, 6) = fProPagos.Contacto
                    xl.Cells(xlfila, 7) = Format(fProPagos.ProPaNroCuota, "00")
                    xl.Cells(xlfila, 8) = fProPagos.ConId
                    xl.Cells(xlfila, 9) = fProPagos.ConNombre
                    xl.Cells(xlfila, 10) = fProPagos.ProPa_PSaimt
                    xl.Cells(xlfila, 11) = fProPagos.ProPa_PMpt
                    xl.Cells(xlfila, 12) = fProPagos.ProPaFecVen
                    xl.Cells(xlfila, 13) = fProPagos.ProPaDetMonto
                    xl.Cells(xlfila, 14) = fProPagos.TgEstadoId
                    xl.Cells(xlfila, 15) = fProPagos.ProPaFecPag
                    xl.Cells(xlfila, 16) = fProPagos.ProPaCtaSaimt
                    xl.Cells(xlfila, 17) = fProPagos.ProPaCtaMpt
                    xl.Cells(xlfila, 18) = fProPagos.ProPaMoraSaimt
                    xl.Cells(xlfila, 19) = fProPagos.ProPaMoraMpt
                    xl.Cells(xlfila, 20) = fProPagos.ProPaComCtaSaimt
                    xl.Cells(xlfila, 21) = fProPagos.ProPaComCtaMpt
                    xlfila = xlfila + 1
                Next
                Me.beiprogress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.bsiMensaje.Caption = "Exportación realizada con exito"
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("No Existen Datos que Exportar")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError("ExportarDataProPagos => " & ex.Message)
        End Try
    End Sub

    Private Sub sdnFechas_EditDateModified(sender As System.Object, e As System.EventArgs) Handles sdnFechas.EditDateModified
        If lbCargaDatosImportados = False Then
            Try
                Dim ListaTempProPagos As List(Of EETemp_ProPagos) = MantenimientosBL.Instancia.temp_propagosListarDatosImportadosXFechaPago(sdnFechas.DateTime.Date)
                If ListaTempProPagos IsNot Nothing Then
                    dtTempProPagos.Clear()

                    For Each fTempProPagos As EETemp_ProPagos In ListaTempProPagos
                        dtTempProPagos.LoadDataRow(New Object() {fTempProPagos.ProPaId, _
                            sdnFechas.DateTime.Year, _
                            fTempProPagos.ContId, _
                            fTempProPagos.PerId, _
                            fTempProPagos.Persona, _
                            fTempProPagos.Contacto, _
                            fTempProPagos.ProPaNroCuota, _
                            fTempProPagos.ConId, _
                            fTempProPagos.ConNombre, _
                            fTempProPagos.ProPa_PSaimt, _
                            fTempProPagos.ProPa_PMpt, _
                            fTempProPagos.ProPaFecVen, _
                            fTempProPagos.ProPaDetMonto, _
                            fTempProPagos.TgEstadoId, _
                            fTempProPagos.ProPaFecPag, _
                            fTempProPagos.ProPaCtaSaimt, _
                            fTempProPagos.ProPaCtaMpt, _
                            fTempProPagos.ProPaMoraSaimt, _
                            fTempProPagos.ProPaMoraMpt, _
                            fTempProPagos.ProPaComCtaSaimt, _
                            fTempProPagos.ProPaComCtaMpt, _
                            fTempProPagos.ProPaTotal
                        }, True)
                    Next
                    gvTempProPagos.BestFitColumns()
                Else
                    dtTempProPagos.Clear()
                End If
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnExportarGrilla_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarGrilla.Click
        sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.gvTempProPagos.ExportToXls(sfdexportar.FileName)
        End If
    End Sub

 
End Class