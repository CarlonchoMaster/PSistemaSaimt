Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Imports System.IO
Imports System.Reflection

Public Class frmGaleriaContrato
    Inherits frmGeneral


#Region "Propiedades"
    Public Property OConInmArchivos() As List(Of EEConArchivos)
#End Region

    Dim dtTableImagenes As DataTable = New DataTable()
    Dim dtTableArchivos As DataTable = New DataTable()
    Dim dtTableVideos As DataTable = New DataTable()
    Dim loImagenConver As ImageConver = New ImageConver()
    Dim visorvideo As wpfReproductor
    Dim foxit As AxFOXITREADEROCXLib.AxFoxitReaderOCX = Nothing
    'Dim visorPDF As AxAcroPDFLib.AxAcroPDF = Nothing


    ''' <summary>
    ''' True = Foxit, False = Adobe PDF
    ''' </summary>
    ''' <remarks></remarks>
    Dim lbTipoVisorPDF As Boolean? = Nothing

#Region "Construir Table"
    Private Sub ConstruirTableImagenes()
        dtTableImagenes.Columns.Add("Foto", GetType(Byte()))
        dtTableImagenes.Columns.Add("Nombre", GetType(String))
        dtTableImagenes.Columns.Add("Descripcion", GetType(String))
    End Sub

    Private Sub ConstruirTableArchivos()
        dtTableArchivos.Columns.Add("Archivo", GetType(Byte()))
        dtTableArchivos.Columns.Add("Nombre", GetType(String))
        dtTableArchivos.Columns.Add("Descripcion", GetType(String))
        dtTableArchivos.Columns.Add("Extension", GetType(String))
        dtTableArchivos.Columns.Add("Tipo", GetType(String))
        dtTableArchivos.Columns.Add("VistaPrevia", GetType(String))
        dtTableArchivos.Columns.Add("Acción", GetType(String))
        dtTableArchivos.Columns.Add("Imprirmir", GetType(String))
    End Sub

    'Private Sub ConstruirTableVideos()
    '    dtTableVideos.Columns.Add("Foto", GetType(Byte()))
    '    dtTableVideos.Columns.Add("Nombre", GetType(String))
    '    dtTableVideos.Columns.Add("Descripcion", GetType(String))
    '    dtTableVideos.Columns.Add("Accion1", GetType(String))
    '    dtTableVideos.Columns.Add("Accion2", GetType(String))
    '    dtTableVideos.Columns.Add("Extension", GetType(String))
    '    dtTableVideos.Columns.Add("Archivo", GetType(Byte()))
    '    dtTableVideos.Columns.Add("Tipo", GetType(String))
    'End Sub
#End Region

    Dim crmResource As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGaleriaInmueble))
    Private Sub frmGaleriaContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fgvExcel.Visible = False
        fgvExcel.Dock = DockStyle.Fill
        recWord.Visible = False
        recWord.Dock = DockStyle.Fill

        Try
            'visorPDF = New AxAcroPDFLib.AxAcroPDF()
            visorPDF.Visible = False
            visorPDF.Name = "visorPDF"
            'visorPDF.OcxState = CType(crmResource.GetObject("visorPDF.OcxState"), System.Windows.Forms.AxHost.State)
            visorPDF.Dock = DockStyle.Fill
            SaimtSplitContainerControl1.Panel2.Controls.Add(visorPDF)

            lbTipoVisorPDF = False
        Catch
            Try
                foxit = New AxFOXITREADEROCXLib.AxFoxitReaderOCX()
                foxit.Visible = False
                foxit.Name = "foxit"
                foxit.OcxState = CType(crmResource.GetObject("foxit.OcxState"), System.Windows.Forms.AxHost.State)
                foxit.Dock = DockStyle.Fill
                SaimtSplitContainerControl1.Panel2.Controls.Add(foxit)
                'foxit.Visible = False
                lbTipoVisorPDF = True
            Catch
                'SaimtMessageBox.mostrarAlertaAdvertencia("No se encontro un visor de PDF Instalado.")
            End Try
        End Try

        'Try
        '    visorAutoCAD = New AxACCTRLLib.AxAcCtrl()
        '    visorAutoCAD.Visible = True
        '    visorAutoCAD.Enabled = True
        '    visorAutoCAD.Name = "visorAutoCAD"
        '    visorAutoCAD.OcxState = CType(crmResource.GetObject("visorAutoCAD.OcxState"), System.Windows.Forms.AxHost.State)
        '    visorAutoCAD.Dock = DockStyle.Fill
        '    SplitContainerControl4.Panel2.Controls.Add(visorAutoCAD)
        '    visorAutoCAD.Visible = False
        'Catch
        '    'SaimtMessageBox.mostrarAlertaAdvertencia("No se encontro un visor de AutoCAD Instalado")
        'End Try

        ConstruirTableImagenes()
        ConstruirTableArchivos()

        dgvGaleriaImagenes.DataSource = dtTableImagenes
        dgvArchivos.DataSource = dtTableArchivos


        If OConInmArchivos IsNot Nothing Then
            For Each fArchivos As EEConArchivos In OConInmArchivos
                Select Case fArchivos.TgTipoArchId
                    Case "04"
                        dtTableImagenes.LoadDataRow(New Object() { _
                            fArchivos.ConInmArch, _
                            fArchivos.ConInmArchNombre, _
                            fArchivos.ConInmArchDescripcion
                        }, True)
                        Exit Select
                        'Case "05"
                        '    dtTableVideos.LoadDataRow(New Object() { _
                        '        loImagenConver.Image2Bytes(Me.imagenes128.Images(0)), _
                        '        fArchivos.InmArchNombre, _
                        '        fArchivos.InmArchDescripcion, _
                        '        "Descargar", _
                        '        "Vista Previa", _
                        '        fArchivos.InmArchExt, _
                        '        fArchivos.InmArch, _
                        '        fArchivos.TgNombre
                        '    }, True)
                        '    Exit Select
                    Case Else
                        dtTableArchivos.LoadDataRow(New Object() { _
                            fArchivos.ConInmArch, _
                            fArchivos.ConInmArchNombre, _
                            fArchivos.ConInmArchDescripcion, _
                            fArchivos.ConInmArchExt, _
                            fArchivos.TgNombre, _
                            "Vista Previa", _
                            "Descargar", _
                            "Imprimir"
                        }, True)
                        Exit Select
                End Select
            Next
        End If
        Me.gvArchivos.BestFitColumns()
    End Sub

    Private Sub dgvGaleriaImagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvGaleriaImagenes.Click
        If Me.lvGaleriaImagenes.DataRowCount <> 0 Then
            'pbFotoInmueble.Image = loImagenConver.Bytes2Image(lvGaleriaImagenes.GetRowCellValue(Me.lvGaleriaImagenes.GetSelectedRows(0), "Foto"))
            pbFotoInmueble.Image = loImagenConver.ZoomImageToImage(lvGaleriaImagenes.GetRowCellValue(Me.lvGaleriaImagenes.GetSelectedRows(0), "Foto"), CDec(Me.ZoomTrackBarControl1.Value) / 100)
            Me.lblzoom.Text = Format(CDec(Me.ZoomTrackBarControl1.Value) / 100, "0%")
        End If
    End Sub

    Private Sub dgvArchivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvArchivos.Click

    End Sub

    Private Sub RepositoryItemPictureEditFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemPictureEditFoto.Click
        dgvGaleriaImagenes_Click(sender, e)
    End Sub

    Private Sub rihdescargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rihdescargar.Click
        If Me.gvArchivos.DataRowCount <> 0 Then
            sfddescargar.Filter = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Tipo").ToString & Space(1) & "(*" & gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension").ToString & ")|*" & gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension").ToString

            If sfddescargar.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim byA As Byte() = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Archivo")
                loImagenConver.ByteArrayToFile(sfddescargar.FileName, byA)
            End If
        End If
    End Sub

    Private Sub RepositoryItemHyperLinkEditVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemHyperLinkEditVistaPrevia.Click
        If Me.gvArchivos.DataRowCount <> 0 Then
            Dim byA As Byte() = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Archivo")

            Dim lsExtension As String = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension")
            loImagenConver.ByteArrayToFile(System.IO.Path.GetTempPath() & "SaimtTemporal" & lsExtension, byA)

            Dim lsArchivoTemporal As String = System.IO.Path.GetTempPath() & "SaimtTemporal" & gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension")

            If lsExtension.Contains(".doc") Or lsExtension.Contains(".docx") Then
                recWord.Visible = True
                fgvExcel.Visible = False

                If lbTipoVisorPDF IsNot Nothing Then
                    If lbTipoVisorPDF = False Then
                        visorPDF.Visible = False
                    ElseIf lbTipoVisorPDF = True Then
                        foxit.Visible = False
                    End If
                End If

                recWord.LoadDocument(lsArchivoTemporal)
            ElseIf lsExtension.Contains(".xls") Or lsExtension.Contains(".xlsx") Then
                fgvExcel.Visible = True
                recWord.Visible = False

                If lbTipoVisorPDF IsNot Nothing Then
                    If lbTipoVisorPDF = False Then
                        visorPDF.Visible = False
                    ElseIf lbTipoVisorPDF = True Then
                        foxit.Visible = False
                    End If
                End If

                fgvExcel.LoadDocument(lsArchivoTemporal)
              
            ElseIf lsExtension.Contains(".pdf") Then
                recWord.Visible = False
                fgvExcel.Visible = False
                'visorAutoCAD.Visible = False

                Try
                    If lbTipoVisorPDF IsNot Nothing Then
                        If lbTipoVisorPDF = False Then
                            visorPDF.Visible = True
                            visorPDF.LoadDocument(lsArchivoTemporal)
                            SaimtSplitContainerControl1.SplitterPosition = SaimtSplitContainerControl1.SplitterPosition - 1
                            SaimtSplitContainerControl1.SplitterPosition = SaimtSplitContainerControl1.SplitterPosition + 1
                        ElseIf lbTipoVisorPDF = True Then
                            foxit.Visible = True
                            foxit.OpenFile(lsArchivoTemporal)
                        End If
                    End If
                Catch
                    Process.Start(lsArchivoTemporal)
                End Try
            ElseIf lsExtension.Contains(".dwg") Then
                recWord.Visible = False
                fgvExcel.Visible = False

                If lbTipoVisorPDF IsNot Nothing Then
                    If lbTipoVisorPDF = False Then
                        visorPDF.Visible = False
                    ElseIf lbTipoVisorPDF = True Then
                        foxit.Visible = False
                    End If
                End If

                'Try
                '    visorAutoCAD.Visible = True
                '    visorAutoCAD.PutSourcePath(lsArchivoTemporal)
                '    visorAutoCAD.BringToFront()
                'Catch
                '    Process.Start(lsArchivoTemporal)
                'End Try
            End If
        End If
    End Sub

    'Private Sub rihdescargarvid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rihdescargarvid.Click
    '    If Me.lvmultimedia.DataRowCount <> 0 Then
    '        sfddescargar.Filter = lvmultimedia.GetRowCellValue(Me.lvmultimedia.GetSelectedRows(0), "Tipo").ToString & Space(1) & "(*" & lvmultimedia.GetRowCellValue(Me.lvmultimedia.GetSelectedRows(0), "Extension").ToString & ")|*" & lvmultimedia.GetRowCellValue(Me.lvmultimedia.GetSelectedRows(0), "Extension").ToString

    '        If sfddescargar.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            Dim byA As Byte() = lvmultimedia.GetRowCellValue(Me.lvmultimedia.GetSelectedRows(0), "Archivo")
    '            loImagenConver.ByteArrayToFile(sfddescargar.FileName, byA)
    '        End If
    '    End If
    'End Sub

    'Private Sub rihvistaprevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rihvistaprevia.Click
    '    'If Me.gvArchivos.DataRowCount <> 0 Then

    '    '    Dim byA As Byte() = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Archivo")
    '    '    Dim lsExtension As String = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension")

    '    '    loImagenConver.ByteArrayToFile(System.IO.Path.GetTempPath() & "SaimtTemporal" & lsExtension, byA)

    '    '    If lsExtension.Contains(".doc") Or lsExtension.Contains(".docx") Then
    '    '        recWord.Visible = True
    '    '        fgvExcel.Visible = False
    '    '        recWord.LoadDocument(System.IO.Path.GetTempPath() & "SaimtTemporal" & gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension"))
    '    '    ElseIf lsExtension.Contains(".xls") Or lsExtension.Contains(".xlsx") Then
    '    '        recWord.Visible = False
    '    '        fgvExcel.Visible = True

    '    '        fgvExcel.LoadExcel(System.IO.Path.GetTempPath() & "SaimtTemporal" & gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension"))
    '    '        fgvExcel.AutoSizeCols()
    '    '        fgvExcel.AutoSizeRows()
    '    '    End If

    '    'End If
    '    visorvideo = New wpfReproductor("")
    '    'Me.ElementHost1.Child = visorvideo
    'End Sub

    Private Sub LoadVideo()
        'visorvideo = New f_in_box__lib.f_in_box__control
        'visorvideo.Location = New Point(12, 12)
        'visorvideo.Size = New Point(100, 100)
        'Me.SplitContainerControl3.Panel2.Controls.Add(visorvideo)
    End Sub

    Private Sub RepositoryItemHyperLinkEditImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemHyperLinkEditImprimir.Click
        If Me.gvArchivos.DataRowCount <> 0 Then
            Dim byA As Byte() = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Archivo")
            Dim lsExtension As String = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension")
            loImagenConver.ByteArrayToFile(System.IO.Path.GetTempPath() & "SaimtTemporal" & lsExtension, byA)
            Dim lsArchivoTemporal As String = System.IO.Path.GetTempPath() & "SaimtTemporal" & gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension")
            Process.Start(lsArchivoTemporal)
        End If
    End Sub

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(Me.ZoomTrackBarControl1.EditValue)
    End Sub

    Private Sub ZoomTrackBarControl1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomTrackBarControl1.EditValueChanged
        If Not pbFotoInmueble.Image Is Nothing Then
            'pbFotoInmueble.Image = loImagenConver.ZoomImageToImage(loImagenConver.Image2Bytes(pbFotoInmueble.Image), CDec(Me.ZoomTrackBarControl1.Value) / 100)
            pbFotoInmueble.Image = loImagenConver.ZoomImageToImage(lvGaleriaImagenes.GetRowCellValue(Me.lvGaleriaImagenes.GetSelectedRows(0), "Foto"), CDec(Me.ZoomTrackBarControl1.Value) / 100)
            Me.lblzoom.Text = Format(CDec(Me.ZoomTrackBarControl1.Value) / 100, "0%")
        End If
    End Sub

    Private Sub ZoomTrackBarControl1_FormatEditValue(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs) Handles ZoomTrackBarControl1.FormatEditValue

    End Sub
    
End Class