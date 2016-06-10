Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Imports System.IO
Imports System.Reflection
Public Class frmGaleriaDocumentos
    Inherits frmGeneral

#Region "Propiedades"
    Public Property OAnexos() As List(Of EEAnexoSTD)
#End Region

    Dim dtTableImagenes As DataTable = New DataTable()
    Dim dtTableArchivos As DataTable = New DataTable()
    Dim dtTableVideos As DataTable = New DataTable()
    Dim loImagenConver As ImageConver = New ImageConver()
    Dim foxit As AxFOXITREADEROCXLib.AxFoxitReaderOCX = Nothing
    'Dim visorPDF As AxAcroPDFLib.AxAcroPDF = Nothing
    Dim visorAutoCAD As AxACCTRLLib.AxAcCtrl = Nothing

    ''' <summary>
    ''' True = Foxit, False = Adobe PDF
    ''' </summary>
    ''' <remarks></remarks>
    Dim lbTipoVisorPDF As Boolean? = Nothing

#Region "Construir Table"
    Private Sub ConstruirTableImagenes()
        dtTableImagenes.Columns.Add("Foto", GetType(System.Drawing.Image))
        dtTableImagenes.Columns.Add("Nombre", GetType(String))
        dtTableImagenes.Columns.Add("Descripcion", GetType(String))
        dtTableImagenes.Columns.Add("Extension", GetType(String))
    End Sub

    Private Sub ConstruirTableArchivos()
        dtTableArchivos.Columns.Add("Archivo", GetType(String))
        dtTableArchivos.Columns.Add("Nombre", GetType(String))
        dtTableArchivos.Columns.Add("Descripcion", GetType(String))
        dtTableArchivos.Columns.Add("Extension", GetType(String))
        dtTableArchivos.Columns.Add("Tipo", GetType(String))
        dtTableArchivos.Columns.Add("VistaPrevia", GetType(String))
        dtTableArchivos.Columns.Add("Acción", GetType(String))
        dtTableArchivos.Columns.Add("Imprirmir", GetType(String))
    End Sub

#End Region

    Dim crmResource As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGaleriaInmueble))
    Private Sub frmGaleriaInmueble_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                ' SplitContainerControl4.Panel2.Controls.Add(foxit)
                'foxit.Visible = False
                lbTipoVisorPDF = True
            Catch
                'SaimtMessageBox.mostrarAlertaAdvertencia("No se encontro un visor de PDF Instalado.")
            End Try
        End Try

        Try
            visorAutoCAD = New AxACCTRLLib.AxAcCtrl()
            visorAutoCAD.Visible = True
            visorAutoCAD.Enabled = True
            visorAutoCAD.Name = "visorAutoCAD"
            visorAutoCAD.OcxState = CType(crmResource.GetObject("visorAutoCAD.OcxState"), System.Windows.Forms.AxHost.State)
            visorAutoCAD.Dock = DockStyle.Fill
            'SplitContainerControl.Panel2.Controls.Add(visorAutoCAD)
            visorAutoCAD.Visible = False
        Catch
            'SaimtMessageBox.mostrarAlertaAdvertencia("No se encontro un visor de AutoCAD Instalado")
        End Try

        ConstruirTableImagenes()
        ConstruirTableArchivos()
        dgvGaleriaImagenes.DataSource = dtTableImagenes
        dgvArchivos.DataSource = dtTableArchivos


        If OAnexos IsNot Nothing Then
            For Each fArchivos As EEAnexoSTD In OAnexos

                Select Case fArchivos.TgTipoArchId
                    Case "04"
                        Dim lsExtension As String = fArchivos.AneArchExt
                        Dim lsArchivoTemporal As String = fArchivos.AneArch & lsExtension
                        If File.Exists(lsArchivoTemporal) Then
                            dtTableImagenes.LoadDataRow(New Object() { _
                                                     Image.FromFile(lsArchivoTemporal), _
                                                     fArchivos.AneNombre, _
                                                     fArchivos.AneDescripcion, _
                                                     fArchivos.AneArchExt
                                                 }, True)
                        End If

                        Exit Select
                    Case Else
                        Try
                            dtTableArchivos.LoadDataRow(New Object() { _
                                                  fArchivos.AneArch, _
                                                  fArchivos.AneNombre, _
                                                  fArchivos.AneDescripcion, _
                                                  fArchivos.AneArchExt, _
                                                  fArchivos.TgTipoArch, _
                                                  "Vista Previa", _
                                                  "Descargar", _
                                                  "Imprimir"
                                              }, True)
                        Catch ex As Exception
                            SaimtMessageBox.mostrarAlertaAdvertencia("" & ex.Message)
                        End Try

                        Exit Select
                End Select
            Next
        End If
        Me.gvArchivos.BestFitColumns()
    End Sub

    Private Sub dgvGaleriaImagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvGaleriaImagenes.Click
        If Me.lvGaleriaImagenes.DataRowCount <> 0 Then
            pbFotoInmueble.Image = lvGaleriaImagenes.GetRowCellValue(Me.lvGaleriaImagenes.GetSelectedRows(0), "Foto")
            Me.lblzoom.Text = Format(CDec(Me.ZoomTrackBarControl1.Value) / 100, "0%")
        End If
    End Sub

    Private Sub RepositoryItemPictureEditFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemPictureEditFoto.Click
        dgvGaleriaImagenes_Click(sender, e)
    End Sub

    Private Sub rihdescargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rihdescargar.Click
        If Me.gvArchivos.DataRowCount <> 0 Then
            sfddescargar.Filter = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Tipo").ToString & Space(1) & "(*" & gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension").ToString & ")|*" & gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension").ToString
            Dim lsExtension As String = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension")
            Dim lsArchivoTemporal As String = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Archivo") & lsExtension
            sfddescargar.Title = "Guardar archivo " & gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Nombre")
            If sfddescargar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                File.Copy(lsArchivoTemporal.TrimEnd, sfddescargar.FileName)
            End If
        End If
    End Sub

    Private Sub RepositoryItemHyperLinkEditVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemHyperLinkEditVistaPrevia.Click
        If Me.gvArchivos.DataRowCount <> 0 Then

            Dim lsExtension As String = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension")
            Dim lsArchivoTemporal As String = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Archivo") & lsExtension
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

                recWord.LoadDocument(lsArchivoTemporal.TrimEnd)
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
                visorAutoCAD.Visible = False

                Try
                    If lbTipoVisorPDF IsNot Nothing Then
                        If lbTipoVisorPDF = False Then
                            visorPDF.Visible = True
                            visorPDF.LoadDocument(lsArchivoTemporal)
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

                Try
                    visorAutoCAD.Visible = True
                    visorAutoCAD.PutSourcePath(lsArchivoTemporal)
                    visorAutoCAD.BringToFront()
                Catch
                    Process.Start(lsArchivoTemporal)
                End Try
            End If
        End If
    End Sub


    Private Sub RepositoryItemHyperLinkEditImprimir_Click(sender As System.Object, e As System.EventArgs) Handles RepositoryItemHyperLinkEditImprimir.Click
        If Me.gvArchivos.DataRowCount <> 0 Then
            Dim lsExtension As String = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Extension")
            Dim lsArchivoTemporal As String = gvArchivos.GetRowCellValue(Me.gvArchivos.GetSelectedRows(0), "Archivo") & lsExtension
        End If
    End Sub

    Private Sub ZoomTrackBarControl1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles ZoomTrackBarControl1.EditValueChanged
        If Not pbFotoInmueble.Image Is Nothing Then
            'Dim lsExtension As String = lvGaleriaImagenes.GetRowCellValue(Me.lvGaleriaImagenes.GetSelectedRows(0), "Extension")
            'Dim lsArchivoTemporal As String = lvGaleriaImagenes.GetRowCellValue(Me.lvGaleriaImagenes.GetSelectedRows(0), "Foto").ToString & lsExtension
            'If File.Exists(lsArchivoTemporal) Then
            '    Image.FromFile(lsArchivoTemporal)
            '    pbFotoInmueble.Image = Image.FromFile(lsArchivoTemporal)
            '    Me.lblzoom.Text = Format(CDec(Me.ZoomTrackBarControl1.Value) / 100, "0%")
            'End If
            If Me.lvGaleriaImagenes.DataRowCount <> 0 Then
                'pbFotoInmueble.Image = loImagenConver.Bytes2Image(lvGaleriaImagenes.GetRowCellValue(Me.lvGaleriaImagenes.GetSelectedRows(0), "Foto"))
                pbFotoInmueble.Image = lvGaleriaImagenes.GetRowCellValue(Me.lvGaleriaImagenes.GetSelectedRows(0), "Foto")
                Me.lblzoom.Text = Format(CDec(Me.ZoomTrackBarControl1.Value) / 100, "0%")
            End If
        End If
    End Sub


End Class