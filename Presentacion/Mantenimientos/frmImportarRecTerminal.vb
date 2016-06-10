Imports ReglasNegocio
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports SaimtControles
Public Class frmImportarRecTerminal
    Inherits frmGeneral
    Dim data(11) As String
    Dim xl As Excel.Application = EEExcel.Instancia
    Dim Recaudador As String
    Dim fechaPago As Date
    Dim movimiento As String = "05"
    Dim diarioEst As String = "01"
    Dim fila As Integer = 0
    Dim oTable As DataTable = New DataTable()
    Private Sub btnImpArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpArchivo.Click
        Me.ofdimportar.Filter = "Archivos de Excel(*.xls;*.xlsx;*.xlsx)|*.xls;*.xlsx;*.xlsm"
        If Me.ofdimportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.btnImpArchivo.Text = Me.ofdimportar.FileName.Trim
            CargarVisor(Me.btnImpArchivo.Text.Trim)
        End If
    End Sub
    Sub AñadirNodos(ByVal n As Integer)
        For i As Integer = 0 To n
            tlImportar.Columns.Add()
        Next
    End Sub
    Private Sub CargarVisor(ByVal path As String)
        fila = 1
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
        tlc1.Caption = "NOMBRES"
        tlc2.Caption = "TIPO DOC"
        tlc3.Caption = "ID DOC"
        tlc4.Caption = "NRO DOC"
        tlc5.Caption = "PLACA"
        tlc6.Caption = "TIPO COMP"
        tlc7.Caption = "ID"
        tlc8.Caption = "SERIE"
        tlc9.Caption = "N°"
        tlc10.Caption = "CONCEPTOS"
        tlc11.Caption = "CODIGO"
        tlc12.Caption = "PRECIO"
        'tlc13.Visible = False
   
        If Not Trim(xl.Cells(2, 2).Value) <> "" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("No se ha indicado el recaudador, vuelva a intentar cargar el archivo")
            Exit Sub
        Else
            Recaudador = Trim(xl.Cells(2, 2).Value)
        End If

        If Not Trim(xl.Cells(3, 2).Value) <> "" Or IsDate(xl.Cells(3, 2).Value) = False Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Debe indicar la fecha del reporte, vuelva a intentar cargar el archivo")
            Exit Sub
        Else
            fechaPago = Trim(xl.Cells(3, 2).Value)
        End If

        While Trim(xl.Cells(fila, 1).Value) <> "NOMBRES" And fila < 20
            fila = fila + 1
        End While
        If Not Trim(xl.Cells(fila, 4).Value) = "NRO DOC" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 6).Value) = "TIPO COMP" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        If Not Trim(xl.Cells(fila, 10).Value) = "CONCEPTOS" Then
            SaimtMessageBox.mostrarAlertaAdvertencia("El reporte no coincide con el formato predefinido, vuelva a intentar cargar el archivo")
            Exit Sub
        End If
        fila = fila + 1

        While xl.Cells(fila, 1).Value <> String.Empty
            data(0) = xl.Cells(fila, 1).Value.ToString.Replace("_", " ")
            data(1) = xl.Cells(fila, 2).Value
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
            Me.tlImportar.AppendNode(data, -1)
            fila = fila + 1
        End While
        xl.ActiveWorkbook.Close()
    End Sub

    Private Sub btnimportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimportar.Click
        Dim NroInsert As Integer
        If Me.tlImportar.Nodes.Count > 0 Then
            If SaimtMessageBox.mostrarAlertaPregunta("¿Esta seguro que desea importar los datos mostrados en el Visor?") Then
                For fil As Integer = 0 To Me.tlImportar.Nodes.Count - 2
                    If tlImportar.Nodes(fil).GetValue(tlc3) Is Nothing Then 'Tipo Doc
                        SaimtMessageBox.mostrarAlertaError("Error de Formato-> Clientes IDTipoDoc no validos, fila " & fil)
                        Exit Sub
                    End If

                    If tlImportar.Nodes(fil).GetValue(tlc4) Is Nothing Then 'NroDoc
                        SaimtMessageBox.mostrarAlertaError("Error de Formato-> Clientes NroDoc no validos, fila " & fil)
                        Exit Sub
                    End If

                    If tlImportar.Nodes(fil).GetValue(tlc7) Is Nothing Then
                        SaimtMessageBox.mostrarAlertaError("Error de Formato-> ComprobanteId no Valido, fila " & fil)
                        Exit Sub
                    End If

                    If tlImportar.Nodes(fil).GetValue(tlc8) Is Nothing Then
                        SaimtMessageBox.mostrarAlertaError("Error de Formato-> Serie Comprobante no valida, fila " & fil)
                        Exit Sub
                    End If
                    If tlImportar.Nodes(fil).GetValue(tlc9) Is Nothing Then
                        SaimtMessageBox.mostrarAlertaError("Error de Formato-> Nro Comprobante no valida, fila " & fil)
                        Exit Sub
                    End If

                    If tlImportar.Nodes(fil).GetValue(tlc11) Is Nothing Then
                        SaimtMessageBox.mostrarAlertaError("Error de Formato-> ConceptoID no valido , fila " & fil)
                        Exit Sub
                    End If

                    If tlImportar.Nodes(fil).GetValue(tlc12) Is Nothing Or Val(tlImportar.Nodes(fil).GetValue(tlc12)) <= 0 Then
                        SaimtMessageBox.mostrarAlertaError("Error de Formato-> Monto no valido , fila " & fil)
                        Exit Sub
                    End If
                Next

                For fil As Integer = 0 To tlImportar.Nodes.Count - 2
                    Dim loMovimiento As EEMovimiento = New EEMovimiento()
                    Dim loDiarioTTSC As EEDiarioTTSC = New EEDiarioTTSC()
                    Dim loPersona As EEPersona = New EEPersona()

                    If tlImportar.Nodes(fil).GetValue(tlc1) Is Nothing Then
                        loPersona.PerNombres = String.Empty
                    Else
                        loPersona.PerNombres = tlImportar.Nodes(fil).GetValue(tlc1).ToString.Trim()
                    End If

                    loPersona.TgTipoDoc = tlImportar.Nodes(fil).GetValue(tlc3).ToString.Trim()
                    loPersona.PerNDoc = tlImportar.Nodes(fil).GetValue(tlc4).ToString.Trim()

                    If tlImportar.Nodes(fil).GetValue(tlc5) Is Nothing Then
                        loDiarioTTSC.DTTSCPlaca = String.Empty
                    Else
                        loDiarioTTSC.DTTSCPlaca = tlImportar.Nodes(fil).GetValue(tlc5).ToString.Trim()
                    End If

                    loDiarioTTSC.ConId = tlImportar.Nodes(fil).GetValue(tlc11).ToString.Trim()
                    loDiarioTTSC.DTTSCMonto = Val(tlImportar.Nodes(fil).GetValue(tlc12).ToString)
                    loDiarioTTSC.PerId = MantenimientosBL.Instancia.personaConsultaryCreaXtgTipoDo_perNDoc(loPersona)
                    loDiarioTTSC.DTTSCFechaPag = fechaPago
                    loDiarioTTSC.TgEstdTTSCId = diarioEst
                    loMovimiento.MovFechaPag = fechaPago
                    loMovimiento.TgRecaudadoraId = Recaudador
                    loMovimiento.TgComprobanteId = tlImportar.Nodes(fil).GetValue(tlc7).ToString.Trim
                    loMovimiento.MovSerie = tlImportar.Nodes(fil).GetValue(tlc8).ToString.Trim
                    loMovimiento.MovNro = tlImportar.Nodes(fil).GetValue(tlc9).ToString.Trim
                    loMovimiento.TgMonedaId = "S"
                    loMovimiento.TgMovimientoId = movimiento
                    loMovimiento.MovId = MantenimientosBL.Instancia.DiarioTTSCGuardar(loDiarioTTSC)
                    If MantenimientosBL.Instancia.MovimientoGuardar(loMovimiento) = True Then
                        NroInsert = NroInsert + 1
                    End If
                Next
                If NroInsert = tlImportar.Nodes.Count - 1 Then
                    btnImpArchivo.Text = ""
                    tlImportar.ClearNodes()
                    SaimtMessageBox.mostrarAlertaAdvertencia("La Importacion se llevo a cabo correctamente")
                End If
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Existen Datos que Importar")
        End If
    End Sub

    Private Sub frmImportarRecdTTSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ConstruirTable()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DateNImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateNImp.Click
        cargardatos()
    End Sub
    Sub cargardatos()
        Try
            lblFecha.Text = DateNImp.DateTime.Date
            Dim ListaDiarioTTSC As List(Of EEDiarioTTSC) = MantenimientosBL.Instancia.DiarioTTSC_XdTTSCFechaPag_pa(DateNImp.DateTime.Date)
            oTable.Clear()
            TxtTotalIngreso.Text = 0.0
            If ListaDiarioTTSC IsNot Nothing Then
                For Each fDiarioTTSC As EEDiarioTTSC In ListaDiarioTTSC
                    oTable.LoadDataRow(New Object() {fDiarioTTSC.DTTSCId, _
                    fDiarioTTSC.DTTSCFechaPag, _
                    fDiarioTTSC.DTTSCPlaca, _
                    fDiarioTTSC.DTTSCMonto, _
                    fDiarioTTSC.ConId, _
                    fDiarioTTSC.Concepto, _
                    fDiarioTTSC.Persona, _
                    fDiarioTTSC.PerId, _
                    fDiarioTTSC.TgEstdTTSCId, _
                    fDiarioTTSC.TgEstdTTSC, _
                    fDiarioTTSC.DTTSCId2
                            }, True)
                    TxtTotalIngreso.Text = TxtTotalIngreso.Text + fDiarioTTSC.DTTSCMonto
                Next
                dgvResultado.DataSource = oTable
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Private Sub ConstruirTable()
        oTable.Columns.Add("DTTSCId", GetType(String))
        oTable.Columns.Add("DTTSCFechaPag", GetType(String))
        oTable.Columns.Add("DTTSCPlaca", GetType(String))
        oTable.Columns.Add("DTTSCMonto", GetType(String))
        oTable.Columns.Add("ConId", GetType(String))
        oTable.Columns.Add("Concepto", GetType(String))
        oTable.Columns.Add("Persona", GetType(String))
        oTable.Columns.Add("PerId", GetType(String))
        oTable.Columns.Add("TgEstdTTSCId", GetType(String))
        oTable.Columns.Add("TgEstdTTSC", GetType(String))
        oTable.Columns.Add("DTTSCId2", GetType(String))

        oTable.Columns("DTTSCId").Caption = "Codigo Diario"
        oTable.Columns("DTTSCFechaPag").Caption = "Fecha Pago"
        oTable.Columns("DTTSCPlaca").Caption = "Placa"
        oTable.Columns("DTTSCMonto").Caption = "Monto"
        oTable.Columns("ConId").Caption = "Con ID"
        oTable.Columns("Concepto").Caption = "Concepto"
        oTable.Columns("Persona").Caption = "Persona"
        oTable.Columns("PerId").Caption = "PerID"
        oTable.Columns("TgEstdTTSCId").Caption = "EstadoID"
        oTable.Columns("TgEstdTTSC").Caption = "Estado"
        oTable.Columns("DTTSCId2").Caption = "Codigo Diario 2"
       
        tlc1.Caption = "NOMBRES"
        tlc2.Caption = "TIPO DOC"
        tlc3.Caption = "ID DOC"
        tlc4.Caption = "NRO DOC"
        tlc5.Caption = "PLACA"
        tlc6.Caption = "TIPO COMP"
        tlc7.Caption = "ID"
        tlc8.Caption = "SERIE"
        tlc9.Caption = "N°"
        tlc10.Caption = "CONCEPTOS"
        tlc11.Caption = "CODIGO"
        tlc12.Caption = "PRECIO"
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If DateNImp.DateTime.Date.ToString <> "" Then
                If MantenimientosBL.Instancia.DiarioTTSC_Eliminar(DateNImp.DateTime.Date) = True Then
                    oTable.Clear()
                    dgvResultado.DataSource = oTable
                    SaimtMessageBox.mostrarAlertaInformativa("Se elimino correctamente la Importacion del día " & DateNImp.DateTime.Date)
                End If
            Else
                SaimtMessageBox.mostrarAlertaError("Seleccione Fecha de Importacion")
            End If

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub rblrecaudador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargardatos()
    End Sub
End Class