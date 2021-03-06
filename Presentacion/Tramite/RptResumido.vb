﻿Imports ReglasNegocio
Imports SaimtControles
Imports Entidades

Public Class RptResumido
    Inherits frmConsultas
    'Dim CBus_oTable As DataTable = New DataTable()
    'Dim CExpDep_oTable As DataTable = New DataTable()
    'Dim CExpInt_oTable As DataTable = New DataTable()
    'Dim CExpSG_oTable As DataTable = New DataTable()
    Dim CExp_oTable As DataTable = New DataTable()
    Dim CExp_oTableDet As DataTable = New DataTable()

    Private Sub CExp_ConstruirTable_Detalle()
        CExp_oTableDet.Columns.Add("item", GetType(String))
        CExp_oTableDet.Columns.Add("movId", GetType(String))
        CExp_oTableDet.Columns.Add("movFechaRec", GetType(String))
        CExp_oTableDet.Columns.Add("dependencia", GetType(String))
        CExp_oTableDet.Columns.Add("persona", GetType(String))
        CExp_oTableDet.Columns.Add("personaPara", GetType(String))
        CExp_oTableDet.Columns.Add("resultado", GetType(String))
        CExp_oTableDet.Columns.Add("movFechaEnv", GetType(String))
        CExp_oTableDet.Columns.Add("dependenciaPara", GetType(String))
        CExp_oTableDet.Columns.Add("movComentario", GetType(String))
        CExp_oTableDet.Columns.Add("movTieneArch", GetType(Boolean))
    End Sub

    Private Sub CExp_ConstruirTable()
        CExp_oTable.Columns.Add("docId", GetType(String))
        CExp_oTable.Columns.Add("nroReg", GetType(String))
        'CExp_oTable.Columns.Add("parte", GetType(String))
        CExp_oTable.Columns.Add("procedimiento", GetType(String))
        CExp_oTable.Columns.Add("folio", GetType(String))
        CExp_oTable.Columns.Add("fecha", GetType(String))
        CExp_oTable.Columns.Add("dependencia", GetType(String))
        CExp_oTable.Columns.Add("area", GetType(String))
        CExp_oTable.Columns.Add("perId", GetType(String))
        CExp_oTable.Columns.Add("interesado", GetType(String))
    End Sub

#Region "Consultas"
    Sub MostrarDetalleExpedienteXTgInstitucionId(ByVal criterio As String, ByVal año As String)
        Dim ListaExpedientes As List(Of EEDocumentoSTD) = Nothing
        ListaExpedientes = MantenimientosBL.Instancia.documentosSTD_MostrarDetalleExpedienteXTgInstitucionId(criterio, año)

        CExp_oTableDet.Clear()
        CExp_oTable.Clear()
        If ListaExpedientes IsNot Nothing Then
            Dim i As Int16 = 0
            For Each frow As EEDocumentoSTD In ListaExpedientes
                '  i = i + 1
                CExp_oTable.LoadDataRow(New Object() {frow.DocId, frow.DocNReg.Insert(5, "-"), frow.DocAsunto, frow.DocNFolio, frow.DocFechaIng.ToString, frow.OPersonaInteresada.OPerCargoPersonal.Institucion, frow.OPersonaInteresada.OPerCargoPersonal.Area, frow.OPersonaInteresada.PerId, frow.OPersonaInteresada.PerNombreCompleto}, True)
            Next
            Encontrado = True
        Else
            Encontrado = False
        End If
        If Encontrado = False Then
            CExp_lblResultados.Text = "No se encontraron resultados de Búsqueda"
        Else
            CExp_lblResultados.Text = CExp_oTable.Rows.Count & " Resultados de Busquedas"

            CExp_dgvResultado.DataSource = CExp_oTable
            CExp_gvResultado.BestFitColumns()
            CExp_gvResultado_FocusedRowChanged(Nothing, Nothing)
        End If
    End Sub

    Sub MostrarDetalleExpedienteXPerIntId(ByVal criterio As String, ByVal año As String)
        Dim ListaExpedientes As List(Of EEDocumentoSTD) = Nothing
        ListaExpedientes = MantenimientosBL.Instancia.documentosSTD_MostrarDetalleExpedienteXPerIntId(criterio, año)

        CExp_oTableDet.Clear()
        CExp_oTable.Clear()
        If ListaExpedientes IsNot Nothing Then
            ' Dim i As Int16 = 0
            For Each frow As EEDocumentoSTD In ListaExpedientes
                ' i = i + 1
                CExp_oTable.LoadDataRow(New Object() {frow.DocId, frow.DocNReg.Insert(5, "-"), frow.DocAsunto, frow.DocNFolio, frow.DocFechaIng.ToString, frow.OPersonaInteresada.OPerCargoPersonal.Institucion, frow.OPersonaInteresada.OPerCargoPersonal.Area, frow.OPersonaInteresada.PerId, frow.OPersonaInteresada.PerNombreCompleto}, True)
            Next
            Encontrado = True
        Else
            Encontrado = False
        End If
        If Encontrado = False Then
            CExp_lblResultados.Text = "No se encontraron resultados de Búsqueda"
        Else
            CExp_lblResultados.Text = CExp_oTable.Rows.Count & " Resultados de Busquedas"

            CExp_dgvResultado.DataSource = CExp_oTable
            CExp_gvResultado.BestFitColumns()
            CExp_gvResultado_FocusedRowChanged(Nothing, Nothing)
        End If
    End Sub

    Sub MostrarDetalleExpedienteXNroReg(ByVal criterio As String, ByVal año As String)
        Dim ListaExpedientes As List(Of EEDocumentoSTD) = Nothing
        ListaExpedientes = MantenimientosBL.Instancia.documentosSTD_MostrarDetalleExpedientexNroReg(criterio, año)

        CExp_oTableDet.Clear()
        CExp_oTable.Clear()
        If ListaExpedientes IsNot Nothing Then
            ' Dim i As Int16 = 0
            For Each frow As EEDocumentoSTD In ListaExpedientes
                'i = i + 1
                CExp_oTable.LoadDataRow(New Object() {frow.DocId, frow.DocNReg.Insert(5, "-"), frow.DocAsunto, frow.DocNFolio, frow.DocFechaIng.ToString, frow.OPersonaInteresada.OPerCargoPersonal.Institucion, frow.OPersonaInteresada.OPerCargoPersonal.Area, frow.OPersonaInteresada.PerId, frow.OPersonaInteresada.PerNombreCompleto}, True)
            Next
            Encontrado = True
        Else
            Encontrado = False
        End If
        If Encontrado = False Then
            CExp_lblResultados.Text = "No se encontraron resultados de Búsqueda"
        Else
            CExp_lblResultados.Text = CExp_oTable.Rows.Count & " Resultados de Busquedas"

            CExp_dgvResultado.DataSource = CExp_oTable
            CExp_gvResultado.BestFitColumns()
            CExp_gvResultado_FocusedRowChanged(Nothing, Nothing)
        End If
    End Sub

    Sub MostrarDetalleExpedienteXDocAsunto(ByVal criterio As String, ByVal año As String)
        Dim ListaExpedientes As List(Of EEDocumentoSTD) = Nothing
        ListaExpedientes = MantenimientosBL.Instancia.documentosSTD_MostrarDetalleExpedientexDocAsunto(criterio, año)

        CExp_oTableDet.Clear()
        CExp_oTable.Clear()
        If ListaExpedientes IsNot Nothing Then
            ' Dim i As Int16 = 0
            For Each frow As EEDocumentoSTD In ListaExpedientes
                ' i = i + 1
                CExp_oTable.LoadDataRow(New Object() {frow.DocId, frow.DocNReg.Insert(5, "-"), frow.DocAsunto, frow.DocNFolio, frow.DocFechaIng.ToString, frow.OPersonaInteresada.OPerCargoPersonal.Institucion, frow.OPersonaInteresada.OPerCargoPersonal.Area, frow.OPersonaInteresada.PerId, frow.OPersonaInteresada.PerNombreCompleto}, True)
            Next
            Encontrado = True
        Else
            Encontrado = False
        End If
        If Encontrado = False Then
            CExp_lblResultados.Text = "No se encontraron resultados de Búsqueda"
        Else
            CExp_lblResultados.Text = CExp_oTable.Rows.Count & " Resultados de Busquedas"

            CExp_dgvResultado.DataSource = CExp_oTable
            CExp_gvResultado.BestFitColumns()
            CExp_gvResultado_FocusedRowChanged(Nothing, Nothing)
        End If
    End Sub
#End Region


    Private Sub RptResumido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CExp_ConstruirTable()
        CExp_ConstruirTable_Detalle()
        CExp_cboAño.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        CExp_cboAño.Properties.DisplayMember = "TgNombre"
        CExp_cboAño.Properties.ValueMember = "TgCodigo"
        CExp_cboAño.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsIdOrderbytgOrden(76)

    End Sub

    Private Sub CExp_btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CExp_btnConsultar.Click
        Dim paso As Boolean = True
        If CExp_txtNroExpediente.EditValue = "" Then
            CExp_lblNroExpediente.ForeColor = Drawing.Color.Red
            paso = False
        Else
            CExp_lblNroExpediente.ForeColor = Drawing.Color.Black
        End If
        Dim año As String = Nothing
        If CExp_lblcboAño.Checked = True Then
            If CExp_cboAño.EditValue = "" Then
                CExp_lblcboAño.ForeColor = Drawing.Color.Red
            Else
                CExp_lblcboAño.ForeColor = Drawing.Color.Black
                año = CExp_cboAño.EditValue
            End If
        End If
        If paso = True Then
            Try
                MostrarDetalleExpedienteXNroReg(CExp_txtNroExpediente.EditValue, año)
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaInformativa(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SaimtButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton2.Click
        Me.sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.CExp_gvResultado.ExportToXls(Me.sfdexportar.FileName)
        End If
    End Sub

    Sub tagocultar()
        CExp_oTable.Clear()
        CExp_oTableDet.Clear()
    End Sub
    Private Sub CExp_txtNroExpediente_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CExp_txtNroExpediente.KeyUp
        If e.KeyCode = Keys.Enter Then
            CExp_btnConsultar.PerformClick()
        End If
    End Sub
    Private Sub CExp_gvResultado_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles CExp_gvResultado.FocusedRowChanged
        If Me.CExp_gvResultado.DataRowCount <> 0 Then
            CExp_lblResultadoDet.Text = ""

            Dim DocId As String = CExp_gvResultado.GetFocusedRowCellValue("docId").ToString()
            Dim parte As String = String.Empty
            If Len(DocId) > 6 Then
                parte = DocId.Substring(6)
            End If
            CExp_lblResultadoDet.Text = "Resultado de la Parte " & parte

            If DocId <> "" Then
                Dim ListaMovimientos As List(Of EEMovimientoSTD) = Nothing
                If DocId <> String.Empty Then
                    ListaMovimientos = MantenimientosBL.Instancia.movimientosSTD_ListarMovimientosxDocId(DocId)
                End If
                '  ConstruirTable_Detalle()
                CExp_oTableDet.Clear()
                Dim encontradoDet As Boolean = False
                If ListaMovimientos IsNot Nothing Then
                    Dim c As Integer = ListaMovimientos.Count
                    For Each frow As EEMovimientoSTD In ListaMovimientos
                        CExp_oTableDet.LoadDataRow(New Object() {c, frow.MovId, frow.MovFechaRec, frow.OPersonaOrigen.OPerCargoPersonal.Cargo, frow.OPersonaOrigen.PerNombreCompleto, frow.OPersonaDestino.PerNombreCompleto, frow.TgEstadoMov, frow.MovFechaEnv, frow.OPersonaDestino.OPerCargoPersonal.Cargo, frow.MovComentario, frow.MovTieneArch}, True)
                        c = c - 1
                    Next

                    encontradoDet = True
                Else
                    encontradoDet = False
                End If

                CExp_dgvResultadoDet.DataSource = CExp_oTableDet

            End If
        End If
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        xtabInteresado.PageVisible = False
        xtabInstitucion.PageVisible = False
        xtabRegistro.PageVisible = False
        xtabasunto.PageVisible = False

        Select Case RadioGroup1.EditValue
            Case 0
                XtraTabControl2.SelectedTabPageIndex = 0
                xtabRegistro.PageVisible = True

            Case 1
                XtraTabControl2.SelectedTabPageIndex = 1
                xtabInteresado.PageVisible = True
           
            Case 2
                XtraTabControl2.SelectedTabPageIndex = 2
                xtabInstitucion.PageVisible = True
           
            Case 3
                XtraTabControl2.SelectedTabPageIndex = 2
                xtabasunto.PageVisible = True
              
        End Select
    End Sub

    Private Sub SaimtButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton4.Click
        Dim frm As New frmConsultaPersonaGeneral(3)
        frm.ShowDialog()
        txtPersona.Text = frm.PerNombre
        txtPersona.Tag = frm.PerId
    End Sub


    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarxInt.Click
        Dim paso As Boolean = True
        If txtPersona.Tag = "" Then
            lblInteresado.ForeColor = Drawing.Color.Red
            paso = False
        Else
            lblInteresado.ForeColor = Drawing.Color.Black
        End If
        Dim año As String = Nothing
        If CExp_lblcboAño.Checked = True Then
            If CExp_cboAño.EditValue = "" Then
                CExp_lblcboAño.ForeColor = Drawing.Color.Red
            Else
                CExp_lblcboAño.ForeColor = Drawing.Color.Black
                año = CExp_cboAño.EditValue
            End If
        End If

        If paso = True Then
            Try
                MostrarDetalleExpedienteXPerIntId(txtPersona.Tag, año)
                txtPersona.Tag = Nothing
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaInformativa(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SaimtButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaimtButton3.Click
        Dim paso As Boolean = True
        If txtInstitucion.Tag = "" Then
            lblInstitucion.ForeColor = Drawing.Color.Red
            paso = False
        Else
            lblInstitucion.ForeColor = Drawing.Color.Black
        End If
        Dim año As String = Nothing
        If CExp_lblcboAño.Checked = True Then
            If CExp_cboAño.EditValue = "" Then
                CExp_lblcboAño.ForeColor = Drawing.Color.Red
            Else
                CExp_lblcboAño.ForeColor = Drawing.Color.Black
                año = CExp_cboAño.EditValue
            End If
        End If
        If paso = True Then
            Try

           
                MostrarDetalleExpedienteXTgInstitucionId(txtInstitucion.Tag, año)
           
                txtPersona.Tag = Nothing
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaInformativa(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBuscarPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPersona.Click
        Dim frm As New frmConsultaTablaGeneral(82)
        frm.ShowDialog()
        txtInstitucion.Text = frm.TgNombre
        txtInstitucion.Tag = frm.TgCodigo
    End Sub

 


    Private Sub btnConsultarAsunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarAsunto.Click
        Dim paso As Boolean = True
        If txtAsunto.Text = "" Then
            lblAsunto.ForeColor = Drawing.Color.Red
            paso = False
        Else
            lblAsunto.ForeColor = Drawing.Color.Black
        End If
        Dim año As String = Nothing
        If CExp_lblcboAño.Checked = True Then
            If CExp_cboAño.EditValue = "" Then
                CExp_lblcboAño.ForeColor = Drawing.Color.Red
            Else
                CExp_lblcboAño.ForeColor = Drawing.Color.Black
                año = CExp_cboAño.EditValue
            End If
        End If

        If paso = True Then
            Try

                MostrarDetalleExpedienteXDocAsunto(txtAsunto.Text, año)

             
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaInformativa(ex.Message)
            End Try
        End If
    End Sub

 
 

    Private Sub CExp_gvResultado_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles CExp_gvResultado.RowCellClick
        If CExp_gvResultado.DataRowCount > 0 Then
            If e.Column.Name = "gcPerNombreInt" Then
                Dim perId As String = CExp_gvResultado.GetFocusedRowCellValue("perId").ToString()
                Dim frm As New frmPersona("00", perId)
                frm.Show()
            End If
          
            If e.Column.Name = "gcDocAsunto" Then
                Dim docId As String = CExp_gvResultado.GetFocusedRowCellValue("docId").ToString()
                Dim frm As New frmVisorDocumento(docId)
                frm.Show()
            End If
          
        End If

   
    End Sub

    Private Sub gvMovimientos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CExp_gvResultadoDet.DoubleClick
        Dim movId As String = String.Empty
        Dim rutaFile As String = String.Empty
        Dim loImagenConver As ImageConver = New ImageConver()
        Try
            If Me.CExp_gvResultadoDet.DataRowCount <> 0 Then

                If CBool(CExp_gvResultadoDet.GetFocusedRowCellValue("movTieneArch")) Then
                    movId = CExp_gvResultadoDet.GetFocusedRowCellValue("movId").ToString()
                    'Dim frm As New frmVisorDocWord(String.Empty, movId)
                    'frm.Show()

                    If movId <> String.Empty Then
                        Dim loMovimientoSTD As EEMovimientoSTD
                        loMovimientoSTD = MantenimientosBL.Instancia.movimientoSTDMostrarMovArchXMovId(movId)
                        If loMovimientoSTD IsNot Nothing Then
                            Dim byA As Byte() = loMovimientoSTD.MovArch
                            loImagenConver.ByteArrayToFile(String.Format("{0}SaimtTemporal{1}", System.IO.Path.GetTempPath(), ".doc"), byA)
                            rutaFile = String.Format("{0}SaimtTemporal{1}", System.IO.Path.GetTempPath(), ".doc")
                            Process.Start(rutaFile)
                        End If

                    End If
                Else
                    SaimtMessageBox.mostrarAlertaInformativa("El movimiento seleccionado no tiene archivo adjunto")
                End If
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
End Class