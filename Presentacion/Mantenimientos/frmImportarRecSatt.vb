Imports ReglasNegocio
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports SaimtControles
Public Class frmImportarRecSatt

    Dim data() As String
    Dim xl As Excel.Application = EEExcel.Instancia
    Dim Recaudador As String
    Dim fila As Integer = 0
    Dim myInfo As Info_Reniec
    Dim oTable As DataTable = New DataTable("DtRecaudacion")
    Dim oTableDet As DataTable = New DataTable("DtRecaudacionDet")
    Dim recDs As New DataSet
    Dim EjecutaEvento As Boolean = False
    Public Property vRecId() As String
    Public Property vfechaPago() As Date
    Public Property vRecaudadorID() As String
    Public Property vRecMonto() As Decimal
    Public Property vdepositante() As String
    Public Property vGrupoCon() As String
    Public Property vtipoDoc() As String
    Public Property vNDoc() As String
    Public Property vconId() As String
    Public Property vFechDep As Date


    Private Sub btnImpArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpArchivo.Click
        Me.ofdimportar.Filter = "Archivos de Excel(*.xls;*.xlsx)|*.xls;*.xlsx"
        If Me.ofdimportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.btnImpArchivo.Text = Me.ofdimportar.FileName.Trim
            CargarVisor(Me.btnImpArchivo.Text.Trim)
            Me.tlImportar.BestFitColumns()
        End If
    End Sub
    Sub AñadirNodos(ByVal n As Integer)
        For i As Integer = 0 To n
            tlImportar.Columns.Add()
        Next
    End Sub
    Private Sub CargarVisor(ByVal path As String)
        fila = 1
        Application.DoEvents()
        Me.beiprogreso.Caption = "Cargando Datos al Visor..."
        Me.ripprogreso.Stopped = False
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Application.DoEvents()
        Me.tlImportar.Nodes.Clear()
        xl.Workbooks.Open(path, 1, True, 4)
        xl.Sheets(1).Select()
        tlc1.Visible = True
        tlc2.Visible = True
        tlc3.Visible = True
        tlc4.Visible = True
        tlc5.Visible = True
        tlc6.Visible = True
        tlc7.Visible = True
        tlc8.Visible = True
        tlc9.Visible = True
        tlc10.Visible = True
        tlc11.Visible = True
        Application.DoEvents()
        If rbRecaudador.SelectedIndex = 0 Then ' CAJA TRUJILLO
            ReDim data(7)
            tlc1.Caption = "DNI"
            tlc2.Caption = "Nombre"
            tlc3.Caption = "Codigo Operac."
            tlc4.Caption = "Operacion"
            tlc5.Caption = "Monto"
            tlc6.Caption = "CTA1 SAIMT"
            tlc7.Caption = "CTA2 MPT"
            tlc8.Caption = "Fecha Pago"
            tlc9.Visible = False
            tlc10.Visible = False
            tlc11.Visible = False
            tlc12.Visible = False
            Application.DoEvents()
            Recaudador = "02"
            While Trim(xl.Cells(fila, 1).Value) <> "DNI" And fila < 20
                fila = fila + 1
            End While
            If Not Trim(xl.Cells(fila, 1).Value) = "DNI" Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(fila, 4).Value) = "Monto" Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(fila, 5).Value) = "CTA1 SAIMT" Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            If Not Trim(xl.Cells(fila, 7).Value) = "Fecha Pago" Then
                SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
                Exit Sub
            End If
            ' CargarImagen()
            fila = fila + 1
            Dim dni As String
            Application.DoEvents()
            ' Dim caracter As String = InputBox("Ingrese los caracteres de la Imagen", "Validacion Imagen")
            Application.DoEvents()
            While CStr(xl.Cells(fila, 1).Value) <> String.Empty
                Application.DoEvents()
                data(0) = xl.Cells(fila, 1).Value
                Try
                    dni = xl.Cells(fila, 1).Value
                    Application.DoEvents()
                    Dim loPersona As List(Of EEPersona) = MantenimientosBL.Instancia.personaListarCriterio(1, dni)
                    
                    If loPersona IsNot Nothing Then
                        If loPersona.Count = 1 Then
                            data(1) = loPersona(0).PerNombreCompleto
                        End If
                    Else
                        'myInfo.GetInfo(dni, caracter) 'Imagen Capcher Reniec
                        'Select Case myInfo.GetResul
                        '    Case LibReniec.Info.Resul.Ok
                        '        data(1) = [String].Format(("{0} {1} {2}"), myInfo.ApePaterno, myInfo.ApeMaterno, myInfo.Nombres)
                        'End Select
                    End If
                Catch ex As Exception
                    '  Application.DoEvents()
                End Try
                data(2) = xl.Cells(fila, 2).Value & Year(xl.Cells(fila, 7).Value)
        data(3) = xl.Cells(fila, 3).Value
        data(4) = Format(xl.Cells(fila, 4).Value, "###,##0.00")
        data(5) = Format(xl.Cells(fila, 5).Value, "###,##0.00")
        data(6) = Format(xl.Cells(fila, 6).Value, "###,##0.00")
        If IsDate(xl.Cells(fila, 7).Value) Then
            data(7) = xl.Cells(fila, 7).Value
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Hay una fecha errada en la fila " & fila & ", favor de revisar el archivo y corregir")
            Exit Sub
        End If
        Me.tlImportar.AppendNode(data, -1)
        Application.DoEvents()
        fila = fila + 1
            End While
        data(0) = ""
        data(1) = ""
        data(2) = ""
        data(3) = xl.Cells(fila, 3).Value 'Comision
        data(4) = xl.Cells(fila, 4).Value 'Monto Comision
        data(5) = xl.Cells(fila, 5).Value 'Monto SAIMT Comision
        data(6) = xl.Cells(fila, 6).Value 'Monto MPT Comision
        data(7) = ""
        Application.DoEvents()
        Me.tlImportar.AppendNode(data, -1)
        Else ' SATT
        ReDim data(10)
        Recaudador = "01"
        tlc1.Caption = "Fecha_Pago"
        tlc2.Caption = "OrdenPago"
        tlc3.Caption = "idConcepto"
        tlc4.Caption = "Recibo"
        tlc5.Caption = "Nombre"
        tlc6.Caption = "Monto"
        tlc7.Caption = "Porc_SAIMT"
        tlc8.Caption = "Tot_Ingreso"
        tlc9.Caption = "Porc_SATT"
        tlc10.Caption = "Ing_satt"
        tlc11.Caption = "Neto_SAIMT"
        tlc12.Visible = False
        Application.DoEvents()
        While Trim(xl.Cells(fila, 1).Value) <> "Fecha_Pago" And fila < 20
            fila = fila + 1
        End While
        If Not Trim(xl.Cells(fila, 1).Value) = "Fecha_Pago" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 2).Value) = "OrdenPago" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 3).Value) = "idConcepto" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 4).Value) = "Recibo" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 5).Value) = "Nombre" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 6).Value) = "Monto" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 7).Value) = "Porc_SAIMT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 8).Value) = "Tot_Ingreso" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 9).Value) = "Porc_SATT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 10).Value) = "Ing_satt" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 11).Value) = "Neto_SAIMT" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        fila = fila + 1
        Application.DoEvents()
        While CStr(xl.Cells(fila, 3).Value) <> String.Empty
            If IsDate(xl.Cells(fila, 1).Value) Then
                data(0) = xl.Cells(fila, 1).Value
            Else
                SaimtMessageBox.mostrarAlertaAdvertencia("Hay una fecha errada en la fila " & fila & ", favor de revisar el archivo y corregir")
                Exit Sub
            End If
            data(1) = xl.Cells(fila, 2).Value
            data(2) = Format(CInt(xl.Cells(fila, 3).Value), "0000")
            data(3) = xl.Cells(fila, 4).Value
            data(4) = xl.Cells(fila, 5).Value
            data(5) = Format(xl.Cells(fila, 6).Value, "###,##0.00")
            data(6) = xl.Cells(fila, 7).Value
            data(7) = Format(xl.Cells(fila, 8).Value, "###,##0.00")
            data(8) = xl.Cells(fila, 9).Value
            data(9) = Format(xl.Cells(fila, 10).Value, "###,##0.00")
            data(10) = Format(xl.Cells(fila, 11).Value, "###,##0.00")
            Me.tlImportar.AppendNode(data, -1)
            fila = fila + 1
        End While
        End If
        xl.ActiveWorkbook.Close()
        Me.ripprogreso.Stopped = True
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub btnimportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimportar.Click
        Dim NroInsert As Integer
        If Me.tlImportar.Nodes.Count > 0 Then
            If SaimtMessageBox.mostrarAlertaPregunta("¿Esta seguro que desea importar los datos mostrados en el Visor?") Then
                For col As Integer = 0 To Me.tlImportar.Nodes.Count - 2
                    If Recaudador = "01" Then 'SATT
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlc1) Is Nothing And Me.tlImportar.Nodes(col).GetValue(Me.tlc3) Is Nothing Then
                            SaimtMessageBox.mostrarAlertaError("Error de Formato-> Campos no validos para la Inserción")
                            Exit Sub
                        End If
                    End If
                    If Recaudador = "02" Then 'CAJA TRUJILLO
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlc1) Is Nothing And Me.tlImportar.Nodes(col).GetValue(Me.tlc2) Is Nothing Then
                            SaimtMessageBox.mostrarAlertaError("Error de Formato-> Campos no validos para la Inserción")
                            Exit Sub
                        End If
                    End If
                Next
                Dim loRecaudacion As EERecaudacion = Nothing
                If Recaudador = "01" Then 'Fecha_Pago
                    NroInsert = 0
                    For col As Integer = 0 To tlImportar.Nodes.Count - 1
                        loRecaudacion = New EERecaudacion()
                        loRecaudacion.TgRecaudadorId = Recaudador
                        loRecaudacion.RecFecPago = Me.tlImportar.Nodes(col).GetValue(Me.tlc1).ToString.Trim
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlc2) Is Nothing Then
                            loRecaudacion.RecNroOrden = String.Empty
                        Else
                            loRecaudacion.RecNroOrden = Me.tlImportar.Nodes(col).GetValue(Me.tlc2).ToString.Trim
                        End If
                        loRecaudacion.ConId = "0" & Me.tlImportar.Nodes(col).GetValue(Me.tlc3).ToString.Trim & Year(loRecaudacion.RecFecPago)
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlc4) Is Nothing Then
                            loRecaudacion.RecNro = String.Empty
                        Else
                            loRecaudacion.RecNro = Me.tlImportar.Nodes(col).GetValue(Me.tlc4).ToString.Trim
                        End If
                        loRecaudacion.PerNombre = Me.tlImportar.Nodes(col).GetValue(Me.tlc5).ToString.Trim
                        loRecaudacion.RecMonto = tlImportar.Nodes(col).GetValue(tlc6).ToString.Trim
                        loRecaudacion.ConPorcentaje = CDec(tlImportar.Nodes(col).GetValue(tlc7)) / 100
                        loRecaudacion.RecNeto = CDec(tlImportar.Nodes(col).GetValue(tlc11))
                        loRecaudacion.RecComision = CDec(tlImportar.Nodes(col).GetValue(tlc9)) / 100
                        loRecaudacion.RecVComision = tlImportar.Nodes(col).GetValue(tlc10).ToString.Trim
                        loRecaudacion.RecTotalIng = tlImportar.Nodes(col).GetValue(tlc8).ToString.Trim
                        loRecaudacion.RecId = col + 1
                        loRecaudacion.UsuId = EEComun.UsuIdOnline
                        'No Guardamos Neto SAIMT
                        If MantenimientosBL.Instancia.RecaudacionGuardar(loRecaudacion) = True Then
                            NroInsert = NroInsert + 1
                        End If
                    Next
                    If NroInsert = tlImportar.Nodes.Count Then
                        tlImportar.ClearNodes()
                        SaimtMessageBox.mostrarAlertaInformativa("La Importacion se llevo a cabo correctamente")
                    Else
                        SaimtMessageBox.mostrarAlertaInformativa("No se pudo llevar a cabo la importación completa de los registros, favor de revisar si la información subio por completo. Si no fue asi, favor de revisar data e intentarlo de nuevo")
                    End If
                ElseIf Recaudador = "02" Then 'DNI
                    NroInsert = 0
                    For col As Integer = 0 To tlImportar.Nodes.Count - 2
                        loRecaudacion = New EERecaudacion()
                        loRecaudacion.TgRecaudadorId = Recaudador
                        loRecaudacion.PerNroDoc = tlImportar.Nodes(col).GetValue(tlc1).ToString.Trim
                        If Me.tlImportar.Nodes(col).GetValue(Me.tlc2) Is Nothing Then
                            loRecaudacion.PerNombre = String.Empty
                        Else
                            loRecaudacion.PerNombre = Me.tlImportar.Nodes(col).GetValue(Me.tlc2).ToString.Trim
                        End If
                        loRecaudacion.TgTipoDoc = 1 'DNI
                        loRecaudacion.ConId = tlImportar.Nodes(col).GetValue(tlc3).ToString.Trim
                        loRecaudacion.RecMonto = tlImportar.Nodes(col).GetValue(tlc5).ToString.Trim
                        loRecaudacion.RecTotalIng = CDec(tlImportar.Nodes(col).GetValue(tlc6))
                        loRecaudacion.ConPorcentaje = (loRecaudacion.RecTotalIng / loRecaudacion.RecMonto)
                        loRecaudacion.RecNeto = CDec(tlImportar.Nodes(col).GetValue(tlc6)) - CDec(tlImportar.Nodes(tlImportar.Nodes.Count - 1).GetValue(tlc6)) / CDec(tlImportar.Nodes.Count - 1)
                        loRecaudacion.RecFecPago = tlImportar.Nodes(col).GetValue(tlc8).ToString.Trim
                        'Solo de la Ultima Fila
                        loRecaudacion.RecVComision = CDec(tlImportar.Nodes(tlImportar.Nodes.Count - 1).GetValue(tlc6)) / CDec(tlImportar.Nodes.Count - 1)
                        loRecaudacion.RecComision = loRecaudacion.RecVComision / loRecaudacion.RecTotalIng
                        loRecaudacion.RecId = col + 1
                        If MantenimientosBL.Instancia.RecaudacionGuardar(loRecaudacion) = True Then
                            NroInsert = NroInsert + 1
                        End If
                    Next
                    If NroInsert = (tlImportar.Nodes.Count - 1) Then
                        tlImportar.ClearNodes()
                        SaimtMessageBox.mostrarAlertaInformativa("La Importacion se llevo a cabo correctamente")
                    Else
                        tlImportar.ClearNodes()
                        SaimtMessageBox.mostrarAlertaInformativa("No se pudo llevar a cabo la importación completa de los registros, favor de revisar si la información subio por completo. Si no fue asi, favor de revisar data e intentarlo de nuevo")
                    End If
                End If
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Existen Datos que Importar")
        End If

    End Sub

    Private Sub frmImportarRecSatt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.DateNImp.DateTime = EEComun.FechaServidor
            ConstruirTable()
            '  CargarImagen()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CargarImagen()
        Try
            If myInfo Is Nothing Then
                myInfo = New Info_Reniec
            End If
            'Me.pictureCapcha.Image = myInfo.GetCapcha
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub cargardatos(ByVal fechaM As Date)
        Dim ListaRecaudacionDet As List(Of EERecaudacionDet) = Nothing
        Dim ListaRecaudacion As List(Of EERecaudacion) = Nothing
        Try
            lblFecha.Text = fechaM
            ListaRecaudacion = MantenimientosBL.Instancia.RecaudacionALLXrecFechaReg_tgRecaudadorId(fechaM, rblrecaudador.EditValue)
            oTableDet.Clear()
            oTable.Clear()
            recDs.Clear()
            recDs.Relations.Clear()
            oTableDet.Constraints.Clear()
            oTable.Constraints.Clear()
            recDs.Tables.Clear()
            lblmRecaudador.Text = rblrecaudador.Text
            TxtTotalIngreso.Text = 0.0
            If ListaRecaudacion IsNot Nothing Then
                For Each fRecaudacion As EERecaudacion In ListaRecaudacion
                    oTable.LoadDataRow(New Object() {fRecaudacion.RecId, _
                    fRecaudacion.RecFecPago, _
                    fRecaudacion.RecNroOrden, _
                    fRecaudacion.ConId, _
                    fRecaudacion.RecNro, _
                    fRecaudacion.TgNombreTipoDoc, _
                    fRecaudacion.PerNroDoc, _
                    fRecaudacion.PerNombre, _
                    fRecaudacion.RecMonto, _
                    fRecaudacion.ConPorcentaje, _
                    fRecaudacion.RecTotalIng, _
                    fRecaudacion.RecVComision, _
                    fRecaudacion.RecComision, _
                    fRecaudacion.RecNeto, _
                    fRecaudacion.RecFechaReg, _
                    fRecaudacion.UsuId, _
                    fRecaudacion.TgNombreRecaudador, _
                    fRecaudacion.TgRecaudadorId, _
                    fRecaudacion.ConNombre, _
                    fRecaudacion.TgTipoDoc, _
                    fRecaudacion.RecFechaLiquidacion, _
                                                     fRecaudacion.TgGrupoConId}, True)
                    TxtTotalIngreso.Text = CDbl(TxtTotalIngreso.Text) + fRecaudacion.RecMonto
                    ListaRecaudacionDet = MantenimientosBL.Instancia.RecaudacionDet_by_recid_fechaPag_recdid(fRecaudacion.RecId, fRecaudacion.RecFecPago, fRecaudacion.TgRecaudadorId)
                    If Not ListaRecaudacionDet Is Nothing Then
                        If ListaRecaudacionDet.Count > 0 Then
                            For Each fRecaudacionDet As EERecaudacionDet In ListaRecaudacionDet
                                oTableDet.LoadDataRow(New Object() {fRecaudacionDet.ConId, fRecaudacionDet.Concepto, fRecaudacionDet.RecDMonto, fRecaudacionDet.ConPorcentaje, fRecaudacionDet.RecDTotalIng, fRecaudacionDet.RecId, fRecaudacionDet.RecFecPago, fRecaudacionDet.TgRecaudadorId, fRecaudacionDet.RecDFechaLiquidacion}, True)
                            Next
                        End If
                    End If
                Next
                If oTableDet.Rows.Count > 0 Then
                    recDs.Tables.Add(oTable)
                    recDs.Tables.Add(oTableDet)
                    Dim colmaestro() As DataColumn = {recDs.Tables("DtRecaudacion").Columns("RecId"), recDs.Tables("DtRecaudacion").Columns("RecFecPago"), recDs.Tables("DtRecaudacion").Columns("TgRecaudadorId")}
                    Dim coldetalle() As DataColumn = {recDs.Tables("DtRecaudacionDet").Columns("RecId"), recDs.Tables("DtRecaudacionDet").Columns("RecFecPago"), recDs.Tables("DtRecaudacionDet").Columns("TgRecaudadorId")}
                    recDs.Relations.Add("RecaudacionDet", colmaestro, coldetalle)
                Else
                    recDs.Tables.Add(oTable)
                End If
                dgvResultado.DataSource = recDs
                dgvResultado.DataMember = "DtRecaudacion"
                Me.dgvMostrarRecaudacion.BestFitColumns()
                Me.dgvRecaudacionDet.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Private Sub ConstruirTable()
        oTable.Columns.Add("RecId", GetType(Int32))
        oTable.Columns.Add("RecFecPago", GetType(Date))
        oTable.Columns.Add("RecNroOrden", GetType(String))
        oTable.Columns.Add("ConId", GetType(String))
        oTable.Columns.Add("RecNro", GetType(String))
        oTable.Columns.Add("TgNombreTipoDoc", GetType(String))
        oTable.Columns.Add("PerNroDoc", GetType(String))
        oTable.Columns.Add("PerNombre", GetType(String))
        oTable.Columns.Add("RecMonto", GetType(Decimal))
        oTable.Columns.Add("ConPorcentaje", GetType(Decimal))
        oTable.Columns.Add("RecTotalIng", GetType(Decimal))
        oTable.Columns.Add("RecVComision", GetType(Decimal))
        oTable.Columns.Add("RecComision", GetType(Decimal))
        oTable.Columns.Add("RecNeto", GetType(Decimal))
        oTable.Columns.Add("RecFechaReg", GetType(Date))
        oTable.Columns.Add("UsuId", GetType(String))
        oTable.Columns.Add("TgNombreRecaudador", GetType(String))
        oTable.Columns.Add("TgRecaudadorId", GetType(String))
        oTable.Columns.Add("Concepto", GetType(String))
        oTable.Columns.Add("TgTipoDoc", GetType(String))
        oTable.Columns.Add("RecFechaLiquidacion", GetType(Date))
        oTable.Columns.Add("TgGrupoConId", GetType(String))

        'oTable.Columns("RecId").Caption = "Rec Id"
        'oTable.Columns("RecFecPago").Caption = "Fecha Pago"
        'oTable.Columns("RecNroOrden").Caption = "Nro Orden"
        'oTable.Columns("ConId").Caption = "Concepto Id"
        'oTable.Columns("RecNro").Caption = "Recibo"
        'oTable.Columns("TgNombreTipoDoc").Caption = "Documento"
        'oTable.Columns("PerNroDoc").Caption = "Nro Documento"
        'oTable.Columns("PerNombre").Caption = "Nombres"
        'oTable.Columns("RecMonto").Caption = "Monto"
        'oTable.Columns("ConPorcentaje").Caption = "% Concepto"
        'oTable.Columns("RecTotalIng").Caption = "Rec Total Ing"
        'oTable.Columns("RecVComision").Caption = "Valor Comision"
        'oTable.Columns("RecComision").Caption = "% Comision"
        'oTable.Columns("RecNeto").Caption = "Neto"
        'oTable.Columns("RecFechaReg").Caption = "Fecha Reg"
        'oTable.Columns("UsuId").Caption = "Usuario"
        '' oTable.Columns("RecContrato").Caption = "Recibo"
        'oTable.Columns("TgNombreRecaudador").Caption = "Recaudador"
        'oTable.Columns("TgRecaudadorId").Caption = "RecaudadorID"
        'oTable.Columns("TgRecaudadorId").ColumnMapping = MappingType.Hidden


        oTableDet.Columns.Add("conid", GetType(String))
        oTableDet.Columns.Add("concepto", GetType(String))
        oTableDet.Columns.Add("montodep", GetType(Decimal))
        oTableDet.Columns.Add("porsaimt", GetType(Decimal))
        oTableDet.Columns.Add("ingsaimt", GetType(Decimal))
        oTableDet.Columns.Add("RecId", GetType(Int32))
        oTableDet.Columns.Add("RecFecPago", GetType(Date))
        oTableDet.Columns.Add("TgRecaudadorId", GetType(String))
        oTableDet.Columns.Add("FechaLiq", GetType(Date))

        'oTableDet.Columns("conid").Caption = "ID Concepto"
        'oTableDet.Columns("concepto").Caption = "Concepto"
        'oTableDet.Columns("montodep").Caption = "Monto Depositado"
        'oTableDet.Columns("porsaimt").Caption = "% Saimt"
        'oTableDet.Columns("ingsaimt").Caption = "Ing. Saimt"
        'oTableDet.Columns("recid").Caption = "Rec Id"
        'oTableDet.Columns("RecFecPago").Caption = "Fecha Pago"
        'oTableDet.Columns("TgRecaudadorId").Caption = "Recaudador Id"


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If SaimtMessageBox.mostrarAlertaPregunta("Esta Seguro que decea eliminar estos detalles?") = True Then
                If DateNImp.DateTime.Date.ToString <> "" Then
                    If MantenimientosBL.Instancia.RecaudacionEliminar(DateNImp.DateTime.Date, rblrecaudador.EditValue) = True Then
                        oTable.Clear()
                        dgvResultado.DataSource = oTable
                        SaimtMessageBox.mostrarAlertaInformativa("Se elimino correctamente la Importacion del día " & DateNImp.DateTime.Date)
                    End If
                Else
                    SaimtMessageBox.mostrarAlertaError("Seleccione Fecha de Importacion")
                End If
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub rblrecaudador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rblrecaudador.SelectedIndexChanged
        cargardatos(Me.DateNImp.DateTime.Date)
    End Sub

    Private Sub DateNImp_EditDateModified(sender As System.Object, e As System.EventArgs) Handles DateNImp.EditDateModified
        If IsDate(Me.DateNImp.DateTime.Date) Then
            If EjecutaEvento Then
                cargardatos(DateNImp.SelectionEnd.Date)
                EjecutaEvento = Not EjecutaEvento
            Else
                EjecutaEvento = Not EjecutaEvento
            End If
        End If
    End Sub

    Private Sub btnexportar_Click(sender As System.Object, e As System.EventArgs) Handles btnexportar.Click
        sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.dgvMostrarRecaudacion.ExportToXls(sfdexportar.FileName)
        End If
    End Sub


    Private Sub btndetalle_Click(sender As System.Object, e As System.EventArgs) Handles btndetalle.Click

        If Me.dgvMostrarRecaudacion.DataRowCount <> 0 Then
            vdepositante = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "PerNombre").ToString()
            vtipoDoc = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "TgTipoDoc").ToString()
            vNDoc = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "PerNroDoc").ToString()
            vconId = String.Format("{0} - {1}", dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "ConId"), dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "Concepto"))
            vRecId = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "RecId").ToString()
            vfechaPago = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "RecFecPago").ToString()
            vRecaudadorID = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "TgRecaudadorId").ToString()
            vRecMonto = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "RecMonto").ToString()
            vFechDep = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "RecFechaLiquidacion")
            vGrupoCon = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "TgGrupoConId")
            Dim fmRecaudacionDet As frmRecaudacionDet = New frmRecaudacionDet(vRecId, vfechaPago, vRecaudadorID, vRecMonto, vdepositante, vtipoDoc, vNDoc, vconId, vFechDep, vGrupoCon)
            fmRecaudacionDet.MdiParent = Me.MdiParent
            fmRecaudacionDet.BringToFront()
            fmRecaudacionDet.Show()
        End If
    End Sub

    
    Private Sub dgvMostrarRecaudacion_MasterRowExpanded(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles dgvMostrarRecaudacion.MasterRowExpanded
        Me.dgvMostrarRecaudacion.BestFitColumns()
        Me.dgvRecaudacionDet.BestFitColumns()
        'MsgBox("hola")
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'If Me.dgvMostrarRecaudacion.DataRowCount <> 0 Then
        '    vRecId = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "RecId").ToString()
        'End If
        Dim frm As New frmRecaudacionDiaria(Me.DateNImp.DateTime.Date, vRecId)
        frm.Show()
    End Sub


    Private Sub btnElimEditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If Me.dgvMostrarRecaudacion.DataRowCount <> 0 Then
            vRecId = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "RecId").ToString()
            vRecMonto = dgvMostrarRecaudacion.GetRowCellValue(Me.dgvMostrarRecaudacion.GetSelectedRows(0), "RecMonto").ToString()
        End If
        If vRecId > 0 Then
            If vRecMonto = 0 Then
                Dim frm As New frmRecaudacionDiaria(Me.DateNImp.DateTime.Date, vRecId)
                frm.Show()
            Else
                If EEComun.Usuario = "administrador" Then
                    Dim frm As New frmRecaudacionDiaria(Me.DateNImp.DateTime.Date, vRecId)
                    frm.Show()
                Else
                    SaimtMessageBox.mostrarAlertaInformativa("Usted no tiene Permiso para modificar")
                End If
            End If
        Else
            SaimtMessageBox.mostrarAlertaInformativa("Debe Seleccionar un Item")
        End If
       
    End Sub

 
  
End Class