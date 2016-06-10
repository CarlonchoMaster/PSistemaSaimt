Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports Word = Microsoft.Office.Interop.Word
Imports System.IO
Public Class frmInmueblesFichaActualizacionPrint
    Dim IsAdministrador As Boolean = False
    Dim dtArchivos As DataTable = New DataTable()
    'Lista Manejo Archivos
    Dim ListaTemporalArchivosEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalArchivosNuevos As List(Of EEInmArchivos) = New List(Of EEInmArchivos)
    Dim ListaTemporalArchivosEditados As List(Of EEInmArchivos) = New List(Of EEInmArchivos)
    Dim ListaLogDet As List(Of EEInmueble.EEInmLogs.EEInmLogsDet)
    Dim dtNivelImp As DataTable = New DataTable()
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Dim lstcodigo As String = String.Empty
    Public Sub New(ByVal codigo As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lstcodigo = codigo
    End Sub
    Private Sub ConstruirTableNivelImp()
        dtNivelImp.Columns.Add("InmId", GetType(String))
        dtNivelImp.Columns.Add("TgNivImpId", GetType(String))
        dtNivelImp.Columns.Add("InmNivDocumentos", GetType(String))
        dtNivelImp.Columns.Add("InmNivFisico", GetType(Boolean))
        dtNivelImp.Columns.Add("InmNivDigital", GetType(Boolean))
    End Sub
    Private Sub ConstruirTableArchivos()
        dtArchivos.Columns.Add("inmArchId", GetType(String))
        dtArchivos.Columns.Add("inmArchNombre", GetType(String))
        dtArchivos.Columns.Add("inmArchDescripcion", GetType(String))
        dtArchivos.Columns.Add("tgTipoArchId", GetType(String))
        dtArchivos.Columns.Add("inmArch", GetType(Byte()))
        dtArchivos.Columns.Add("inmArchExt", GetType(String))
        dtArchivos.Columns.Add("inmArchPrincipal", GetType(Boolean))
        dtArchivos.Columns.Add("inmArchActivo", GetType(Boolean))

        dtArchivos.Columns("inmArchId").ColumnMapping = MappingType.Hidden
        dtArchivos.Columns("tgTipoArchId").ColumnMapping = MappingType.Hidden
        dtArchivos.Columns("inmArch").ColumnMapping = MappingType.Hidden

        dtArchivos.Columns("inmArchNombre").Caption = "Nombre"
        dtArchivos.Columns("inmArchDescripcion").Caption = "Descripcion"
        dtArchivos.Columns("inmArchExt").Caption = "Extension"
        dtArchivos.Columns("inmArchPrincipal").Caption = "Principal"
        dtArchivos.Columns("inmArchActivo").Caption = "Activo"
    End Sub
#Region "Funciones Sobrescritas"

    Protected Overrides Sub Buscar()
        Try
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub guardar()
        If Len(lstcodigo) = 0 Then
            SaimtMessageBox.mostrarAlertaInformativa("No existe un codigo, vuelva a cargar el formulario")
            Return
        End If
        Dim loInmLogs = New EEInmueble.EEInmLogs
        loInmLogs.InmUpdId = lstcodigo
        loInmLogs.inmUpdObservacion = txtObservacion.Text
        loInmLogs.inmUpdMotivo = txtMotivo.Text
        If IsAdministrador = True Then
            If MantenimientosBL.Instancia.inmuebleUpdateActualizarObservacion(loInmLogs) = True Then
                SaimtMessageBox.mostrarAlertaInformativa("La Observacion se actualizo Correctamente")
            End If
        End If
        MyBase.guardar()
    End Sub

    Protected Overrides Sub Editar()
        MyBase.editar()
        txtInmCodigo.Properties.ReadOnly = True
        txtInmUbicacion.Properties.ReadOnly = True
        txtFechaModificación.Properties.ReadOnly = True
        cboTipoUpd.Properties.ReadOnly = True
        cboSupuestoUpd.Properties.ReadOnly = True
        cboCampoUpd.Properties.ReadOnly = True
        txtCampoOld.Properties.ReadOnly = True
        txtCampoNew.Properties.ReadOnly = True
        txtDocUpd.Properties.ReadOnly = True
        dtFechaDocUpd.Properties.ReadOnly = True
        dtFechaRegUpd.Properties.ReadOnly = True
        txtObservacion.Properties.ReadOnly = False
        txtMotivo.Properties.ReadOnly = False
    End Sub
#End Region
 

    Private Sub frmInmueblesFichaActualizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim loAdministrado As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(189, EEComun._PerId)
        If loAdministrado IsNot Nothing Then
            IsAdministrador = True
        Else
            IsAdministrador = False
        End If
        Dim loinmUpd As EEInmueble.EEInmLogs = MantenimientosBL.Instancia.inmuebleUpdateMostrarInmUpdatexInmUpdId(lstcodigo)
        If loinmUpd IsNot Nothing Then
            txtObservacion.Text = loinmUpd.inmUpdObservacion
        End If
        If IsAdministrador = True Then
            Editar()
        End If
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim oWordN As Word.Application
        Dim oDocN As Word._Document = Nothing
        Try
            Application.DoEvents()
            oWordN = CreateObject("Word.Application")
            oDocN = oWordN.Documents.Open(EEComun.RutaReportes & "\FICHA PRINCIPAL DEL INMUEBLE_actualizacion.docx", True, True)
            Dim wRng As Word.Range
            Dim file As String = String.Empty
            Dim rubro As String = String.Empty

            file = Trim(txtInmCodigo.Text.Substring(0, 9).Replace("File", "").Replace(" ", ""))
            rubro = Trim(txtInmCodigo.Text.Substring(9).Replace("-", ""))
            'CÓDIGO MARGESÍ MPT
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[Rubro]", ReplaceWith:=rubro, Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[File]", ReplaceWith:=file, Replace:=Word.WdReplace.wdReplaceOne)

            If txtInmUbicacion.Text IsNot Nothing Then
                For Each s As String In txtInmUbicacion.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[Direccion]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguno", s & "[Direccion]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[Direccion]", ReplaceWith:=s1 & "[Direccion]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If
            wRng.Find.Execute(FindText:="[Direccion]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FechaModificacion]", ReplaceWith:=txtFechaModificación.EditValue.ToString().Substring(0, 10), Replace:=Word.WdReplace.wdReplaceOne)

            Dim v_cboTipoUpd As String = cboTipoUpd.Text

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[TipoActualizacion]", ReplaceWith:=v_cboTipoUpd, Replace:=Word.WdReplace.wdReplaceOne)

            Dim v_cboSupuestoUpd As String = cboSupuestoUpd.Text

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[SupuestoActualizacion]", ReplaceWith:=v_cboSupuestoUpd, Replace:=Word.WdReplace.wdReplaceOne)

            Dim v_cboCampoUpd As String = cboCampoUpd.Text

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[CampoActualizacion]", ReplaceWith:=v_cboCampoUpd, Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[InformacionAntigua]", ReplaceWith:=txtCampoOld.EditValue, Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[InformacionActual]", ReplaceWith:=txtCampoNew.EditValue, Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[Documento]", ReplaceWith:=txtDocUpd.EditValue, Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FechaDocumento]", ReplaceWith:=dtFechaDocUpd.EditValue.ToShortDateString(), Replace:=Word.WdReplace.wdReplaceOne)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FechaRegistro]", ReplaceWith:=dtFechaRegUpd.EditValue.ToShortDateString(), Replace:=Word.WdReplace.wdReplaceOne)

            If txtObservacion.Text IsNot Nothing Then
                For Each s As String In txtObservacion.Text.Split(vbLf)
                    Try
                        wRng = oDocN.Content
                        wRng.Find.Execute(FindText:="[Observacion]", ReplaceWith:=IIf(s = Nothing Or s = "", "Ninguno", s & "[Observacion]"), Replace:=Word.WdReplace.wdReplaceOne)
                    Catch ex As Exception
                        Dim iC As Integer = 0
                        Dim fC As Integer = 230
                        Try
                            Dim s1 As String = String.Empty
                            Dim s2 As String = String.Empty
                            For i = 0 To CInt(s.Length / 230)
                                s1 = s.Substring(iC, fC)
                                s2 = s2 & s1
                                iC = s2.Length
                                If s2.Length + 230 > s.Length Then
                                    fC = s.Length - s2.Length
                                Else
                                    fC = 230
                                End If
                                wRng = oDocN.Content
                                wRng.Find.Execute(FindText:="[Observacion]", ReplaceWith:=s1 & "[Observacion]", Replace:=Word.WdReplace.wdReplaceOne)
                            Next
                        Catch ex1 As Exception
                        End Try
                    End Try
                Next
            End If
            wRng.Find.Execute(FindText:="[Observacion]", ReplaceWith:="", Replace:=Word.WdReplace.wdReplaceOne)
            'DATOS DE IMPRESION
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FechaEmision]", ReplaceWith:=DateTime.Now().ToShortDateString(), Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[Usuario]", ReplaceWith:=IIf(EEComun.Usuario = Nothing Or EEComun.Usuario = "", "Ninguno", EEComun.Usuario), Replace:=Word.WdReplace.wdReplaceOne)

            Dim locargoPersonal As List(Of EECargoPersonal) = MantenimientosBL.Instancia.CargoListarXPerId_pa(EEComun._PerId)
            If locargoPersonal IsNot Nothing Then
                Dim area As String = locargoPersonal(0).Area
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[Area]", ReplaceWith:=IIf(area = Nothing Or area = "", "Ninguno", area), Replace:=Word.WdReplace.wdReplaceOne)
            End If


            If fbdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
                oWordN.ActiveDocument.SaveAs(String.Format("{0}\File-{1}-{2}", fbdExportar.SelectedPath, file, rubro), 17)
                oWordN.ActiveDocument.Close(False)
                bsiMensaje.Caption = String.Format("El archivo se guardo correctamente en la ruta seleccionada con el nombre File-{0}-{1}", file, rubro)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub
End Class