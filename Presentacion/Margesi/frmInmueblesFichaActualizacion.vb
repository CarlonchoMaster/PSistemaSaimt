Imports SaimtControles
Imports ReglasNegocio
Imports Entidades
Imports Word = Microsoft.Office.Interop.Word
Imports System.IO
Public Class frmInmueblesFichaActualizacion
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

#Region "Funciones Sobrescritas"

    Protected Overrides Sub Buscar()
        Try
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub guardar()


        If Len(txtDocUpd.Text) = 0 Then
            SaimtMessageBox.mostrarAlertaInformativa("Ingrese el Documento de Actualización")
            Return
        End If
        If dtFechaDocUpd.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaInformativa("Ingrese la Fecha del Documento")
            Return
        End If

        Dim loInmLogs = New EEInmueble.EEInmLogs
        loInmLogs.InmId = txtInmCodigo.Tag
        loInmLogs.inmUpdDoc = txtDocUpd.Text
        loInmLogs.InmUpdFecDoc = dtFechaDocUpd.EditValue
        loInmLogs.InmUpdFecRegUpd = dtFechaRegUpd.EditValue
        loInmLogs.tgTipoUpdId = cboTipoUpd.EditValue
        loInmLogs.inmUpdSupId = cboSupuestoUpd.EditValue
        loInmLogs.InmUpdPerUpdId = EEComun._PerId
        loInmLogs.InmUpdId = lstcodigo
        loInmLogs.inmUpdObservacion = txtObservacion.Text
        loInmLogs.inmUpdMotivo = txtMotivo.Text
        'loInmLogs.tgNivelId = cboNivel.EditValue
        loInmLogs.ListaInmLogsDet = ListaLogDet

        'loInmLogs.inmUpdActualizado = True

        Dim actualizarPerfil As Boolean = False
        If IsAdministrador = True Then
            Dim frm As New frmDialogConfirmacionUpd(lstcodigo)
            frm.txtCodigo.Text = txtInmCodigo.Text
            If frm.ShowDialog() Then
                If frm.result = True Then
                    loInmLogs.inmUpdActualizado = True
                    actualizarPerfil = True
                Else
                    loInmLogs.inmUpdActualizado = False
                    actualizarPerfil = False
                End If
            End If
        Else
            loInmLogs.inmUpdActualizado = False
            actualizarPerfil = False
        End If
        'loInmLogs.ListaInmArchivosTemporalNuevos = ListaTemporalArchivosNuevos
        ' loInmLogs.ListaInmArchivosTemporalEliminados = ListaTemporalArchivosEliminados
        ' loInmLogs.ListaInmArchivosEditados = ListaTemporalArchivosEditados

        'For Each ftabla As DataRow In dtNivelImp.Rows
        '    Dim loNivelImp As EEInmNivelImp = New EEInmNivelImp() With {.InmId = ftabla("InmId"), .TgNivImpId = ftabla("TgNivImpId"), .InmNivfisico = ftabla("InmNivfisico"), .InmNivDigital = ftabla("InmNivDigital")}
        '    loInmLogs.ListaInmNivImp.Add(loNivelImp)
        'Next

        If MantenimientosBL.Instancia.inmuebleUpdateActualizar(loInmLogs) = True Then
            SaimtMessageBox.mostrarAlertaInformativa("Las Actualizaciones se realizarón Correctamente")
        End If
        MyBase.guardar()
    End Sub


    Protected Overrides Sub nuevo()
        MyBase.nuevo()

    End Sub

    Protected Overrides Sub Editar()
        MyBase.editar()
        txtInmCodigo.Properties.ReadOnly = True

        txtInmUbicacion.Properties.ReadOnly = True
        txtFechaModificación.Properties.ReadOnly = True
    End Sub
#End Region
    Private Sub cboCampoUpd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampoUpd.EditValueChanged
        If cboCampoUpd.EditValue IsNot Nothing Then
            Dim loInmUpdDet As EEInmueble.EEInmLogs.EEInmLogsDet = MantenimientosBL.Instancia.inmuebleUpdateMostrarInmUpdValorOld_NewxInmUpdId(cboCampoUpd.EditValue)
            txtCampoOld.Text = loInmUpdDet.InmUpdDetValorOld
            txtCampoNew.Text = loInmUpdDet.InmUpdDetValorNew

        End If

    End Sub

    Private Sub frmInmueblesFichaActualizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Editar()

        cboTipoUpd.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoUpd.Properties.DisplayMember = "TgNombre"
        cboTipoUpd.Properties.ValueMember = "TgCodigo"
        cboTipoUpd.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(194)
        cboTipoUpd.ItemIndex = 0

        ListaLogDet = MantenimientosBL.Instancia.inmuebleUpdateMostrarInmUpdDetCampoTextxInmUpdId(lstcodigo)

        cboCampoUpd.mColumnas(SaimtComboBoxLookUp.Entidades.InmCampoActualiza)
        cboCampoUpd.Properties.DisplayMember = "InmUpdDetCampoText"
        cboCampoUpd.Properties.ValueMember = "InmUpdDetId"
        cboCampoUpd.Properties.DataSource = ListaLogDet
        cboCampoUpd.ItemIndex = 1

        Dim loinmUpd As EEInmueble.EEInmLogs = MantenimientosBL.Instancia.inmuebleUpdateMostrarInmUpdatexInmUpdId(lstcodigo)
        If loinmUpd IsNot Nothing Then
            txtDocUpd.Text = loinmUpd.inmUpdDoc
            dtFechaDocUpd.EditValue = loinmUpd.InmUpdFecDoc
            dtFechaRegUpd.EditValue = loinmUpd.InmUpdFecRegUpd
            cboTipoUpd.EditValue = loinmUpd.tgTipoUpdId
            cboSupuestoUpd.EditValue = loinmUpd.inmUpdSupId
            txtObservacion.Text = loinmUpd.inmUpdObservacion
            txtMotivo.Text = loinmUpd.inmUpdMotivo
        End If


        Dim loAdministrado As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdtgCodigo(189, EEComun._PerId)
        If loAdministrado IsNot Nothing Then
            IsAdministrador = True
        Else
            IsAdministrador = False
        End If
        txtCampoOld.Properties.ReadOnly = True
        txtCampoNew.Properties.ReadOnly = True
    End Sub

    Private Sub cboTipoUpd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoUpd.EditValueChanged

        If cboTipoUpd.EditValue IsNot Nothing Then
            cboSupuestoUpd.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboSupuestoUpd.Properties.DisplayMember = "TgNombre"
            cboSupuestoUpd.Properties.ValueMember = "TgCodigo"
            cboSupuestoUpd.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdXTgExtraId(195, cboTipoUpd.EditValue)
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

            If txtFechaModificación.EditValue IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[FechaModificacion]", ReplaceWith:=txtFechaModificación.EditValue.ToString().Substring(0, 10), Replace:=Word.WdReplace.wdReplaceOne)

            End If

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

            If dtFechaDocUpd.EditValue IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[FechaDocumento]", ReplaceWith:=dtFechaDocUpd.EditValue.ToShortDateString(), Replace:=Word.WdReplace.wdReplaceOne)

            End If

            If dtFechaRegUpd.EditValue IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[FechaRegistro]", ReplaceWith:=dtFechaRegUpd.EditValue.ToShortDateString(), Replace:=Word.WdReplace.wdReplaceOne)

            End If
        
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

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton1.Click
        Dim frm As New frmInmueblesEditActualizaciones(txtInmCodigo.Tag)
        frm.ShowDialog()
    End Sub
End Class