Imports ReglasNegocio
Imports Entidades
Imports SaimtControlesWeb
Imports DevExpress.Web
Imports Microsoft.Office.Interop
Imports System.IO
Imports DevExpress.Web.ASPxTreeList

Public Class frmImportarRec
    Inherits System.Web.UI.Page

    Private Shared Property dtImportar As DataTable
    'Private Shared misDatosReniec As EEReniec


#Region "Tabla Importar Recaudacion"
    Private Sub ConstruirTable()
        dtImportar.Columns.Add("tlc1", GetType(String))
        dtImportar.Columns.Add("tlc2", GetType(String))
        dtImportar.Columns.Add("tlc3", GetType(String))
        dtImportar.Columns.Add("tlc4", GetType(String))
        dtImportar.Columns.Add("tlc5", GetType(String))
        dtImportar.Columns.Add("tlc6", GetType(String))
        dtImportar.Columns.Add("tlc7", GetType(String))
        dtImportar.Columns.Add("tlc8", GetType(String))
        dtImportar.Columns.Add("tlc9", GetType(String))
        dtImportar.Columns.Add("tlc10", GetType(String))
        dtImportar.Columns.Add("tlc11", GetType(String))
        dtImportar.Columns.Add("tlc12", GetType(String))
    End Sub
#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Try
                calFechaMostrarRecaudacion.SelectedDate = DateTime.Now

                'misDatosReniec = New EEReniec()
                'imgCaptcha.Value = imageToByteArray(misDatosReniec.GetCapcha())

                dtImportar = New DataTable()

                ConstruirTable()
                dgvImportarRecaudacion.DataSource = dtImportar
                dgvImportarRecaudacion.DataBind()
            Catch ex As Exception
                MensajeScript(ex.Message)
            End Try
        End If
    End Sub

    Public Function imageToByteArray(imageIn As System.Drawing.Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Protected Sub calFechaMostrarRecaudacion_ValueChanged(sender As Object, e As EventArgs) Handles calFechaMostrarRecaudacion.ValueChanged

    End Sub

    Protected Sub dgvRecaudacionDetalle_BeforePerformDataSelect(sender As Object, e As EventArgs)
        Session("KeyGridRecaudacionWEB") = DirectCast(sender, SaimtASPxGridView).GetMasterRowKeyValue()
    End Sub

    Protected Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        gveExportarGridRecaudacion.WriteXlsToResponse()
    End Sub

    Protected Sub odsRecaudacionDetalle_Inserting(sender As Object, e As System.Web.UI.WebControls.ObjectDataSourceMethodEventArgs)
        Dim gvRecaudacionDetalle As SaimtASPxGridView = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(dgvMostrarRecaudacion.FocusedRowIndex, "dgvRecaudacionDetalle"), SaimtASPxGridView)
        Dim cboConcepto As SaimtASPxComboBox = DirectCast(gvRecaudacionDetalle.FindEditFormTemplateControl("cboConceptoDetalle"), SaimtASPxComboBox)
        Dim txtMonto As SaimtASPxTextBox = DirectCast(gvRecaudacionDetalle.FindEditFormTemplateControl("txtMontoDepositadoDetalle"), SaimtASPxTextBox)
        Dim dtpFechaLiquidacion As SaimtASPxDateEdit = DirectCast(gvRecaudacionDetalle.FindEditFormTemplateControl("dtpFechaLiquidacion"), SaimtASPxDateEdit)

        e.InputParameters("KeyGridRecaudacionWEB") = Session("KeyGridRecaudacionWEB")
        e.InputParameters("asConcepto") = cboConcepto.Value
        e.InputParameters("asMonto") = txtMonto.Text

        If String.IsNullOrEmpty(dtpFechaLiquidacion.Value) Then
            e.InputParameters("adtFechaLiquidacion") = Nothing
        Else
            e.InputParameters("adtFechaLiquidacion") = dtpFechaLiquidacion.Value
        End If

        gvRecaudacionDetalle.CancelEdit()
    End Sub

    Protected Sub dgvMostrarRecaudacion_DetailRowExpandedChanged(sender As Object, e As DevExpress.Web.ASPxGridViewDetailRowEventArgs) Handles dgvMostrarRecaudacion.DetailRowExpandedChanged
        If e.Expanded Then
            Dim asTgRecaudadorId As String = dgvMostrarRecaudacion.GetRowValues(e.VisibleIndex, "TgRecaudadorId")
            Session("TgRecaudadorId") = asTgRecaudadorId
            Dim liRowIndex As Int32 = e.VisibleIndex

            dgvMostrarRecaudacion.FocusedRowIndex = liRowIndex

            For fRow As Int32 = 0 To dgvMostrarRecaudacion.VisibleRowCount - 1
                If dgvMostrarRecaudacion.GetRowValues(fRow, "ConId").ToString().StartsWith("S0490") Then
                    Dim gvRecaudacionDetalle As SaimtASPxGridView = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(fRow, "dgvRecaudacionDetalle"), SaimtASPxGridView)
                    Dim dtpFechaLiquidacion As SaimtASPxDateEdit = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(fRow, "dtpFechaLiquidacion"), SaimtASPxDateEdit)
                    Dim lblFechaLiquidacion As SaimtASPxLabel = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(fRow, "lblFechaLiquidacion"), SaimtASPxLabel)
                    Dim btnGuardarFechaLiquidación As SaimtASPxButton = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(fRow, "btnGuardarFechaLiquidación"), SaimtASPxButton)

                    If gvRecaudacionDetalle IsNot Nothing Then
                        gvRecaudacionDetalle.Visible = False
                        dtpFechaLiquidacion.Visible = False
                        lblFechaLiquidacion.Visible = False
                        btnGuardarFechaLiquidación.Visible = False
                    End If
                End If
            Next

            If dgvMostrarRecaudacion.GetRowValues(liRowIndex, "ConId").ToString().StartsWith("S0490") Then

                Dim gvRecaudacionDetalle As SaimtASPxGridView = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(liRowIndex, "dgvRecaudacionDetalle"), SaimtASPxGridView)
                Dim dtpFechaLiquidacion As SaimtASPxDateEdit = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(liRowIndex, "dtpFechaLiquidacion"), SaimtASPxDateEdit)
                Dim lblFechaLiquidacion As SaimtASPxLabel = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(liRowIndex, "lblFechaLiquidacion"), SaimtASPxLabel)
                Dim btnGuardarFechaLiquidación As SaimtASPxButton = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(liRowIndex, "btnGuardarFechaLiquidación"), SaimtASPxButton)

                gvRecaudacionDetalle.Visible = False
                dtpFechaLiquidacion.Visible = False
                lblFechaLiquidacion.Visible = False
                btnGuardarFechaLiquidación.Visible = False
            End If
        Else
            dgvMostrarRecaudacion.FocusedRowIndex = e.VisibleIndex
        End If
    End Sub

    Protected Sub odsRecaudacionDetalle_Deleting(sender As Object, e As System.Web.UI.WebControls.ObjectDataSourceMethodEventArgs)
        e.InputParameters("KeyGridRecaudacionDetalleWEB") = Session("KeyGridRecaudacionDetalleWEB")
    End Sub

    Protected Sub dgvRecaudacionDetalle_RowDeleting(sender As Object, e As DevExpress.Web.Data.ASPxDataDeletingEventArgs)
        Session("KeyGridRecaudacionDetalleWEB") = e.Values("KeyGridRecaudacionDetalleWEB").ToString()
        odsRecaudacionDetalle.Delete()
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            '  ReglasWebBL.Instancia.recaudacionEliminarXFechaPagoWEB(calFechaMostrarRecaudacion.SelectedDate)
            Dim sbMensajeExito As StringBuilder = New StringBuilder()
            sbMensajeExito.Append("<script type='text/javascript'>")
            sbMensajeExito.AppendFormat("alert('{0}');", "Las Recaudaciones Se Eliminaron con Exito")
            sbMensajeExito.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensajeExito.ToString())

            dgvMostrarRecaudacion.DataBind()
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub

    Protected Sub dgvRecaudacionDetalle_RowValidating(sender As Object, e As DevExpress.Web.Data.ASPxDataValidationEventArgs)
        Dim gvRecaudacionDetalle As SaimtASPxGridView = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(dgvMostrarRecaudacion.FocusedRowIndex, "dgvRecaudacionDetalle"), SaimtASPxGridView)
        Dim cboConcepto As SaimtASPxComboBox = DirectCast(gvRecaudacionDetalle.FindEditFormTemplateControl("cboConceptoDetalle"), SaimtASPxComboBox)
        Dim txtMonto As SaimtASPxTextBox = DirectCast(gvRecaudacionDetalle.FindEditFormTemplateControl("txtMontoDepositadoDetalle"), SaimtASPxTextBox)

        If cboConcepto.Value Is Nothing Then
            e.RowError = "- Seleccione un Concepto."
            cboConcepto.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtMonto.Text) Then
            e.RowError = "- Ingrese Monto."
            txtMonto.Focus()
            Exit Sub
        End If

        Dim adMontoResult As Decimal = 0
        If Decimal.TryParse(txtMonto.Text, adMontoResult) = False Then
            e.RowError = "- El Monto Debe Ser Númerico."
            txtMonto.Focus()
            Exit Sub
        End If

        Dim lsConceptoSplit() As String = cboConcepto.Value.Split("-")
        Session("KeyGridRecaudacionWEB") = Session("KeyGridRecaudacionWEB").ToString().Substring(0, Session("KeyGridRecaudacionWEB").ToString().Length - 2) & Session("TgRecaudadorId").ToString()
        'If Not ReglasWebBL.Instancia.recaudaciondetalleValidar(Session("KeyGridRecaudacionWEB").ToString(), lsConceptoSplit(0)) = True Then
        '    e.RowError = "- El Concepto Seleccionado Ya Existe. Seleccione Otro."
        '    Exit Sub
        'End If
    End Sub

    Public Sub mostrarErrorFormatoExcel(ByVal asMensaje As String)
        lblMsgErrorImportarRecaudacion.Text = asMensaje
        lblMsgErrorImportarRecaudacion.Visible = True
        dgvImportarRecaudacion.DataSource = Nothing
        dgvImportarRecaudacion.DataBind()
        btnGuardarImportacionRecaudacion.Enabled = False
    End Sub

    Private Sub CargarVisor(ByVal path As String)
        Dim liFila As Int32 = 1
        Dim lsRecaudador As String = String.Empty
        Dim lsAData() As String
        ReDim lsAData(dgvImportarRecaudacion.Columns.Count)
        Dim xl As Excel.Application = CreateObject("Excel.Application")
        dtImportar.Clear()

        dgvImportarRecaudacion.DataSource = dtImportar
        xl.Workbooks.Open(path, 1, True, 4)
        xl.Sheets(1).Select()

        If rdbCriteriosImportarRecaudacion.Value = "02" Then ' CAJA TRUJILLO
            dgvImportarRecaudacion.Columns("tlc1").Caption = "DNI"
            dgvImportarRecaudacion.Columns("tlc2").Caption = "Nombre"
            dgvImportarRecaudacion.Columns("tlc3").Caption = "Codigo Operac."
            dgvImportarRecaudacion.Columns("tlc4").Caption = "Operacion"
            dgvImportarRecaudacion.Columns("tlc5").Caption = "Monto"
            dgvImportarRecaudacion.Columns("tlc6").Caption = "CTA1 SAIMT"
            dgvImportarRecaudacion.Columns("tlc7").Caption = "CTA2 MPT"
            dgvImportarRecaudacion.Columns("tlc8").Caption = "Fecha Pago"
            dgvImportarRecaudacion.Columns("tlc9").Visible = False
            dgvImportarRecaudacion.Columns("tlc10").Visible = False
            dgvImportarRecaudacion.Columns("tlc11").Visible = False
            dgvImportarRecaudacion.Columns("tlc12").Visible = False

            lsRecaudador = "02"
            While Trim(xl.Cells(liFila, 1).Value) <> "DNI" And liFila < 20
                liFila = liFila + 1
            End While
            If Not Trim(xl.Cells(liFila, 1).Value) = "DNI" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 4).Value) = "Monto" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 5).Value) = "CTA1 SAIMT" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 7).Value) = "Fecha Pago" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            liFila = liFila + 1
            Dim dni As String

            'Dim caracter As String = txtCaptcha.Text
            While CStr(xl.Cells(liFila, 1).Value) <> String.Empty

                lsAData(0) = xl.Cells(liFila, 1).Value
                Try
                    dni = xl.Cells(liFila, 1).Value
                    Dim loPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaListarCriterio(1, dni)

                    If loPersona IsNot Nothing Then
                        If loPersona.Count = 1 Then
                            lsAData(1) = loPersona(0).PerNombreCompleto
                        End If
                    End If

                    'misDatosReniec.GetInfo(dni, caracter) 'Imagen Capcher Reniec

                    'Select Case misDatosReniec.GetResul
                    '    Case LibReniec.Info.Resul.Ok
                    '        lsAData(1) = [String].Format(("{0} {1} {2}"), misDatosReniec.Nombres, misDatosReniec.ApePaterno, misDatosReniec.ApeMaterno)
                    'End Select
                Catch ex As Exception

                End Try

                lsAData(2) = xl.Cells(liFila, 2).Value & Year(xl.Cells(liFila, 7).Value)
                lsAData(3) = xl.Cells(liFila, 3).Value
                lsAData(4) = xl.Cells(liFila, 4).Value
                lsAData(5) = xl.Cells(liFila, 5).Value
                lsAData(6) = xl.Cells(liFila, 6).Value
                If IsDate(xl.Cells(liFila, 7).Value) Then
                    lsAData(7) = xl.Cells(liFila, 7).Value
                Else
                    lblMsgErrorImportarRecaudacion.Text = "Hay una fecha errada en la fila " & liFila & ", favor de revisar el archivo y corregir"
                    Exit Sub
                End If

                dtImportar.LoadDataRow(New Object() {
                                   lsAData(0), _
                                   lsAData(1), _
                                   lsAData(2), _
                                   lsAData(3), _
                                   lsAData(4), _
                                   lsAData(5), _
                                   lsAData(6), _
                                   lsAData(7), _
                                   "", _
                                   "", _
                                   "", _
                                   ""
                           }, True)

                liFila = liFila + 1
            End While
            lsAData(0) = ""
            lsAData(1) = ""
            lsAData(2) = ""
            lsAData(3) = xl.Cells(liFila, 3).Value 'Comision
            lsAData(4) = xl.Cells(liFila, 4).Value 'Monto Comision
            lsAData(5) = xl.Cells(liFila, 5).Value 'Monto SAIMT Comision
            lsAData(6) = xl.Cells(liFila, 6).Value 'Monto MPT Comision
            lsAData(7) = ""
            lsAData(8) = ""
            lsAData(9) = ""
            lsAData(10) = ""
            lsAData(11) = ""

            dtImportar.LoadDataRow(New Object() {
                        lsAData(0), _
                        lsAData(1), _
                        lsAData(2), _
                        lsAData(3), _
                        lsAData(4), _
                        lsAData(5), _
                        lsAData(6), _
                        lsAData(7), _
                        lsAData(8), _
                        lsAData(9), _
                        lsAData(10), _
                        lsAData(11)
                }, True)

        Else ' SATT
            lsRecaudador = "01"

            dgvImportarRecaudacion.Columns("tlc1").Caption = "Fecha_Pago"
            dgvImportarRecaudacion.Columns("tlc2").Caption = "OrdenPago"
            dgvImportarRecaudacion.Columns("tlc3").Caption = "Cod. Concepto"
            dgvImportarRecaudacion.Columns("tlc4").Caption = "Recibo"
            dgvImportarRecaudacion.Columns("tlc5").Caption = "Nombre"
            dgvImportarRecaudacion.Columns("tlc6").Caption = "Monto"
            dgvImportarRecaudacion.Columns("tlc7").Caption = "Porc_SAIMT"
            dgvImportarRecaudacion.Columns("tlc8").Caption = "Tot_Ingreso"
            dgvImportarRecaudacion.Columns("tlc9").Caption = "Porc_SATT"
            dgvImportarRecaudacion.Columns("tlc10").Caption = "Ing_satt"
            dgvImportarRecaudacion.Columns("tlc11").Caption = "Neto_SAIMT"
            dgvImportarRecaudacion.Columns("tlc12").Visible = False

            While Trim(xl.Cells(liFila, 1).Value) <> "Fecha_Pago" And liFila < 20
                liFila = liFila + 1
            End While
            If Not Trim(xl.Cells(liFila, 1).Value) = "Fecha_Pago" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 2).Value) = "OrdenPago" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 3).Value) = "idConcepto" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 4).Value) = "Recibo" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 5).Value) = "Nombre" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 6).Value) = "Monto" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 7).Value) = "Porc_SAIMT" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 8).Value) = "Tot_Ingreso" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 9).Value) = "Porc_SATT" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 10).Value) = "Ing_satt" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(liFila, 11).Value) = "Neto_SAIMT" Then
                mostrarErrorFormatoExcel("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            liFila = liFila + 1

            While CStr(xl.Cells(liFila, 3).Value) <> String.Empty
                If IsDate(xl.Cells(liFila, 1).Value) Then
                    lsAData(0) = xl.Cells(liFila, 1).Value
                Else
                    lblMsgErrorImportarRecaudacion.Text = "Hay una fecha errada en la fila " & liFila & ", favor de revisar el archivo y corregir"
                    Exit Sub
                End If
                lsAData(1) = xl.Cells(liFila, 2).Value
                lsAData(2) = Format(xl.Cells(liFila, 3).Value, "0000")
                lsAData(3) = xl.Cells(liFila, 4).Value
                lsAData(4) = xl.Cells(liFila, 5).Value
                lsAData(5) = xl.Cells(liFila, 6).Value
                lsAData(6) = xl.Cells(liFila, 7).Value
                lsAData(7) = xl.Cells(liFila, 8).Value
                lsAData(8) = xl.Cells(liFila, 9).Value
                lsAData(9) = xl.Cells(liFila, 10).Value
                lsAData(10) = xl.Cells(liFila, 11).Value

                dtImportar.LoadDataRow(New Object() {
                       lsAData(0), _
                       lsAData(1), _
                       lsAData(2), _
                       lsAData(3), _
                       lsAData(4), _
                       lsAData(5), _
                       lsAData(6), _
                       lsAData(7), _
                       lsAData(8), _
                       lsAData(9), _
                       lsAData(10), _
                       lsAData(11)
               }, True)

                liFila = liFila + 1
            End While
        End If
        xl.ActiveWorkbook.Close()
        xl.Workbooks.Close()
        xl.Quit()
        xl = Nothing

        dgvImportarRecaudacion.DataBind()

        btnGuardarImportacionRecaudacion.Enabled = True
        lblMsgErrorImportarRecaudacion.Visible = False
    End Sub

    Protected Sub btnCargarArchivo_Click(sender As Object, e As EventArgs) Handles btnCargarArchivo.Click

    End Sub

    Protected Sub uploadImportarRecaudacion_FileUploadComplete(sender As Object, e As DevExpress.Web.FileUploadCompleteEventArgs) Handles uploadImportarRecaudacion.FileUploadComplete
        Dim lsRuta As String = Server.MapPath("~/archivos_temporales/" & DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss tt") & " - " & e.UploadedFile.FileName)
        e.UploadedFile.SaveAs(lsRuta)
        CargarVisor(lsRuta)
    End Sub

    'Protected Sub linkCaptcha_Click(sender As Object, e As EventArgs) Handles linkCaptcha.Click
    'If rdbCriteriosImportarRecaudacion.Value = "02" Then ' CAJA TRUJILLO
    'VERIFICAR SI EL CAPTCHA ES CORRECTO
    'misDatosReniec.GetInfo("45237603", txtCaptcha.Text)

    'Select Case misDatosReniec.GetResul
    '    Case LibReniec.Info.Resul.ErrorCapcha
    '        txtCaptcha.ErrorText = "Los Caracteres Ingresados No Son Validos."
    '        imgCaptcha.Value = imageToByteArray(misDatosReniec.GetCapcha())
    '        txtCaptcha.IsValid = False
    '        Exit Select
    '    Case LibReniec.Info.Resul.Ok
    '        txtCaptcha.IsValid = True
    '        uploadImportarRecaudacion.Enabled = True
    '        linkActualizarCaptcha.Visible = False
    '        Exit Select
    'End Select
    'End If
    'End Sub

    Protected Sub btnGuardarImportacionRecaudacion_Click(sender As Object, e As EventArgs) Handles btnGuardarImportacionRecaudacion.Click
        If dtImportar.Rows.Count = 0 Then
            lblMsgErrorImportarRecaudacion.Text = "No Se Encotraron Datos a Importar. Seleccione un Archivo con Datos"
            lblMsgErrorImportarRecaudacion.Visible = True
            Exit Sub
        End If

        Dim ListaRecaudacion As List(Of EERecaudacion) = Nothing
        Dim liRecId As Int32 = 1

        Try
            For Each fRecaudacion As DataRow In dtImportar.Rows
                If ListaRecaudacion Is Nothing Then
                    ListaRecaudacion = New List(Of EERecaudacion)
                End If

                Dim loRecaudacion As EERecaudacion = New EERecaudacion()

                If rdbCriteriosImportarRecaudacion.Value = "01" Then 'SATT
                    loRecaudacion.TgRecaudadorId = rdbCriteriosImportarRecaudacion.Value
                    loRecaudacion.RecFecPago = Convert.ToDateTime(fRecaudacion("tlc1").ToString())
                    loRecaudacion.RecNroOrden = fRecaudacion("tlc2").ToString()
                    loRecaudacion.ConId = fRecaudacion("tlc3").ToString().PadLeft(5, "0"c) & Year(loRecaudacion.RecFecPago)
                    loRecaudacion.RecNro = fRecaudacion("tlc4").ToString()
                    loRecaudacion.PerNombre = fRecaudacion("tlc5").ToString()
                    loRecaudacion.RecMonto = fRecaudacion("tlc6").ToString()
                    loRecaudacion.ConPorcentaje = Convert.ToDecimal(fRecaudacion("tlc7").ToString()) / 100
                    loRecaudacion.RecNeto = Convert.ToDecimal(fRecaudacion("tlc11").ToString())
                    loRecaudacion.RecComision = Convert.ToDecimal(fRecaudacion("tlc9").ToString()) / 100
                    loRecaudacion.RecVComision = fRecaudacion("tlc10").ToString()
                    loRecaudacion.RecTotalIng = fRecaudacion("tlc8").ToString()
                    loRecaudacion.RecId = liRecId
                    loRecaudacion.UsuId = 0
                Else    'CAJA TRUJILLO
                    loRecaudacion.TgRecaudadorId = rdbCriteriosImportarRecaudacion.Value
                    loRecaudacion.PerNroDoc = fRecaudacion("tlc1").ToString()
                    loRecaudacion.PerNombre = fRecaudacion("tlc2").ToString()
                    loRecaudacion.TgTipoDoc = 1 'DNI
                    loRecaudacion.ConId = fRecaudacion("tlc3").ToString()
                    loRecaudacion.RecMonto = Convert.ToDecimal(fRecaudacion("tlc5").ToString())
                    loRecaudacion.RecTotalIng = Convert.ToDecimal(fRecaudacion("tlc6").ToString())
                    loRecaudacion.ConPorcentaje = (loRecaudacion.RecTotalIng / loRecaudacion.RecMonto)
                    loRecaudacion.RecNeto = Convert.ToDecimal(fRecaudacion("tlc6").ToString()) - Convert.ToDecimal(dtImportar.Rows(dtImportar.Rows.Count - 1)("tlc6").ToString()) / Convert.ToDecimal(dtImportar.Rows.Count - 1)
                    loRecaudacion.RecFecPago = Convert.ToDateTime(fRecaudacion("tlc8").ToString())
                    'Solo de la Ultima Fila
                    loRecaudacion.RecVComision = Convert.ToDecimal(dtImportar.Rows(dtImportar.Rows.Count - 1)("tlc6").ToString()) / Convert.ToDecimal(dtImportar.Rows.Count - 1)
                    loRecaudacion.RecComision = loRecaudacion.RecVComision / loRecaudacion.RecTotalIng
                    loRecaudacion.RecId = liRecId
                    loRecaudacion.UsuId = 0
                End If

                ListaRecaudacion.Add(loRecaudacion)

                If rdbCriteriosImportarRecaudacion.Value = "02" AndAlso liRecId = dtImportar.Rows.Count - 1 Then
                    Exit For
                End If
                liRecId = liRecId + 1
            Next

            ReglasWebBL.Instancia.recaudacionGuardarWEB(ListaRecaudacion)

            MensajeScript("Los Datos se Importaron Correctamente")

            limpiarImportarRecaudacion()
            rdbCriteriosImportarRecaudacion.SelectedIndex = 0
            'txtCaptcha.Enabled = True
            'linkCaptcha.Enabled = True
            'imgCaptcha.Value = imageToByteArray(misDatosReniec.GetCapcha())
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub

    Protected Sub rdbCriteriosImportarRecaudacion_ValueChanged(sender As Object, e As EventArgs) Handles rdbCriteriosImportarRecaudacion.ValueChanged
        limpiarImportarRecaudacion()

        If rdbCriteriosImportarRecaudacion.Value = "01" Then 'SATT
            uploadImportarRecaudacion.Enabled = True
            'txtCaptcha.Text = "SAIMT"
            'txtCaptcha.Enabled = False
            'linkCaptcha.Enabled = False
            'linkActualizarCaptcha.Visible = False
        Else
            'imgCaptcha.Value = imageToByteArray(misDatosReniec.GetCapcha)
            'txtCaptcha.Text = ""
            'txtCaptcha.Enabled = True
            'linkCaptcha.Enabled = True
            'linkActualizarCaptcha.Visible = True
            uploadImportarRecaudacion.Enabled = False
        End If
    End Sub

    Public Sub limpiarImportarRecaudacion()
        Dim liColumna As Int16 = 1
        For Each fcolum As GridViewColumn In dgvImportarRecaudacion.Columns
            fcolum.Caption = "tlc" & liColumna
            fcolum.Visible = True
            liColumna = liColumna + 1
        Next
        uploadImportarRecaudacion.Enabled = False
        btnGuardarImportacionRecaudacion.Enabled = False
        'txtCaptcha.Text = ""
        dtImportar.Clear()
        dgvImportarRecaudacion.DataBind()
    End Sub

    Public Sub MensajeScript(ByVal asMensaje)
        Dim sbMensaje As StringBuilder = New StringBuilder()
        sbMensaje.Append("<script type='text/javascript'>")
        sbMensaje.AppendFormat("alert('{0}');", asMensaje)
        sbMensaje.Append("</script>")
        ClientScript.RegisterClientScriptBlock(Me.GetType(), "Mensaje", sbMensaje.ToString())
    End Sub

    'Protected Sub linkActualizarCaptcha_Click(sender As Object, e As EventArgs) Handles linkActualizarCaptcha.Click
    'imgCaptcha.Value = imageToByteArray(misDatosReniec.GetCapcha)
    'End Sub

    Protected Sub btnGuardarFechaLiquidación_Click(sender As Object, e As EventArgs)
        Try
            Dim dtpFechaLiquidacion As SaimtASPxDateEdit = DirectCast(dgvMostrarRecaudacion.FindDetailRowTemplateControl(dgvMostrarRecaudacion.FocusedRowIndex, "dtpFechaLiquidacion"), SaimtASPxDateEdit)
            Session("KeyGridRecaudacionWEB") = Session("KeyGridRecaudacionWEB").ToString().Substring(0, Session("KeyGridRecaudacionWEB").ToString().Length - 2) & Session("TgRecaudadorId").ToString()

            ReglasWebBL.Instancia.recaudacionActualizarFechaLiquidacionWEB(Session("KeyGridRecaudacionWEB").ToString(), dtpFechaLiquidacion.Value)

            dgvMostrarRecaudacion.DataBind()
            MensajeScript("La Fecha de Liquidación se Actualizo Correctamente")
        Catch ex As Exception
            MensajeScript(ex.Message)
        End Try
    End Sub
End Class