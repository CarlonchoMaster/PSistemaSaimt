Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmConsultarCertificacion
#Region "Propiedades"
    Public Property cerId() As String
    Public Property cerNro() As String
    Public Property partId As String
    Public Property partNombre As String
    Public Property tgActProyId As String
    Public Property tgMetaId As String
    Public Property tgFFinancieraId As String
    Public Property cerFecha As Date
    Public Property cerValTotal As Decimal
    Public Property cerValQuedan As Decimal

    Public Property anio As Int16
#End Region

    Dim oTable As DataTable = New DataTable()
    Dim oTableDet As DataTable = New DataTable()

    Private Sub ConstruirTable()
        oTable.Columns.Add("cerId", GetType(String))
        oTable.Columns.Add("cerNro", GetType(String))
        oTable.Columns.Add("cerFecha", GetType(String))
        oTable.Columns.Add("cerJustificacion", GetType(String))
        oTable.Columns.Add("cerValQuedan", GetType(Decimal))
        oTable.Columns.Add("cerValTotal", GetType(Decimal))
        oTable.Columns.Add("tgActProyId", GetType(String))
        oTable.Columns.Add("tgMetaId", GetType(String))
        oTable.Columns.Add("tgFFinancieraId", GetType(String))
    End Sub

    Private Sub ConstruirTableDetalle()
        oTableDet.Columns.Add("cerGrupoParId", GetType(String))
        oTableDet.Columns.Add("partId", GetType(String))
        oTableDet.Columns.Add("partNombre", GetType(String))
        oTableDet.Columns.Add("partAnio", GetType(String))
        oTableDet.Columns.Add("cerGrupoParValImporte", GetType(Decimal))
        oTableDet.Columns.Add("cerGrupoParValQuedan", GetType(Decimal))
    End Sub


    Protected Overrides Sub buscar()
        Try
            GValorTextoBuscado = txtBuscar.Text
            GCriterioBuscado = cboBuscarPor.SelectedIndex

            Dim ListaCertificacion As List(Of EECertificacion) = MantenimientosBL.Instancia.CertificacionListarBCriterio(GCriterioBuscado, GValorTextoBuscado, cboAnioCriterio.EditValue)
            oTable.Clear()
            If ListaCertificacion IsNot Nothing Then
                For Each fCertificacion As EECertificacion In ListaCertificacion
                    oTable.LoadDataRow(New Object() {fCertificacion.CerId, _
                                                    fCertificacion.CerNro, _
                                                    fCertificacion.CerFecha, _
                                                    fCertificacion.CerJustificacion, _
                                                    Format(CDbl(fCertificacion.CerValQuedan), "##,##0.00"), _
                                                    Format(CDbl(fCertificacion.CerValTotal), "##,##0.00"), _
                                                     fCertificacion.TgActProyId, _
                                                     fCertificacion.TgMetaId, _
                                                     fCertificacion.TgFFinancieraId
                                                    }, True)
                Next
                Me.Encontrado = True
            Else
                Me.Encontrado = False
            End If
            MyBase.buscar()
            Me.gvResultadosCertificacion.BestFitColumns()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub seleccionar()
        If Me.gvResultadosCertificacion.DataRowCount <> 0 Then
            cerId = gvResultadosCertificacion.GetRowCellValue(Me.gvResultadosCertificacion.GetSelectedRows(0), "cerId").ToString()
            cerNro = gvResultadosCertificacion.GetRowCellValue(Me.gvResultadosCertificacion.GetSelectedRows(0), "cerNro").ToString()
            ' partId = gvResultadosCertificacion.GetRowCellValue(Me.gvResultadosCertificacion.GetSelectedRows(0), "partId").ToString() + " - " + gvResultadosCertificacion.GetRowCellValue(Me.gvResultadosCertificacion.GetSelectedRows(0), "partNombre").ToString()
            tgActProyId = gvResultadosCertificacion.GetRowCellValue(Me.gvResultadosCertificacion.GetSelectedRows(0), "tgActProyId").ToString()
            tgMetaId = gvResultadosCertificacion.GetRowCellValue(Me.gvResultadosCertificacion.GetSelectedRows(0), "tgMetaId").ToString()
            tgFFinancieraId = gvResultadosCertificacion.GetRowCellValue(Me.gvResultadosCertificacion.GetSelectedRows(0), "tgFFinancieraId").ToString()
            cerFecha = gvResultadosCertificacion.GetRowCellValue(Me.gvResultadosCertificacion.GetSelectedRows(0), "cerFecha").ToString()
            cerValTotal = gvResultadosCertificacion.GetRowCellValue(Me.gvResultadosCertificacion.GetSelectedRows(0), "cerValTotal").ToString()
            cerValQuedan = gvResultadosCertificacion.GetRowCellValue(Me.gvResultadosCertificacion.GetSelectedRows(0), "cerValQuedan").ToString()

            anio = cboAnioCriterio.EditValue


            Seleccionado = True
            DialogResult = DialogResult.OK
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub

    Private Sub frmConsultarPartida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTable()
        ConstruirTableDetalle()
        gcResultadosCertificacion.DataSource = oTable
        dgvResultadosGrupoPartidas.DataSource = oTableDet
        cboBuscarPor.SelectedIndex = 0
        cboAnioCriterio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAnioCriterio.Properties.DisplayMember = "TgNombre"
        cboAnioCriterio.Properties.ValueMember = "TgCodigo"
        cboAnioCriterio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId2(76)
        cboAnioCriterio.EditValue = CStr(Date.Now.Year)
    End Sub

    Private Sub gvResultadosCertificacion_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvResultadosCertificacion.RowClick
        If Me.gvResultadosCertificacion.DataRowCount <> 0 Then
            SaimtLabel4.Text = ""
            Try
                Dim ListaCertGrupoPartidas As List(Of EECertificacion.EECertificacionGrupoPartida) = MantenimientosBL.Instancia.CertificacionGrupoPartidaXcerId(Me.gvResultadosCertificacion.GetDataRow(gvResultadosCertificacion.GetSelectedRows(0)).Item("cerId").ToString)
                oTableDet.Clear()
                If ListaCertGrupoPartidas IsNot Nothing Then
                    For Each fCertGrupoPartidas As EECertificacion.EECertificacionGrupoPartida In ListaCertGrupoPartidas
                        oTableDet.LoadDataRow(New Object() {fCertGrupoPartidas.cerGrupoParId, _
                                                        fCertGrupoPartidas.partId, _
                                                        fCertGrupoPartidas.PartNombre, _
                                                        fCertGrupoPartidas.partAnio, _
                                                        Format(CDbl(fCertGrupoPartidas.cerGrupoParValImporte), "##,##0.00"), _
                                                        Format(CDbl(fCertGrupoPartidas.cerGrupoParValQuedan), "##,##0.00")
                                                        }, True)
                    Next
                    Me.Encontrado = True
                    SaimtLabel4.Text = "Certificacion Nro " & Me.gvResultadosCertificacion.GetDataRow(gvResultadosCertificacion.GetSelectedRows(0)).Item("cerNro").ToString
                Else
                    Me.Encontrado = False
                End If
                ' MyBase.buscar()
                Me.gvResultadosGrupoPartidas.BestFitColumns()
            Catch ex As Exception
                SaimtMessageBox.mostrarAlertaError(ex.Message)
            End Try
        End If
     
    End Sub

 
    Private Sub gvResultadosCertificacion_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gvResultadosCertificacion.RowCellClick
        gvResultadosCertificacion_RowClick(sender, e)
    End Sub

    Private Sub gvResultadosCertificacion_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvResultadosCertificacion.CellValueChanged
        gvResultadosCertificacion_RowClick(Nothing, Nothing)
    End Sub


    Private Sub gvResultadosCertificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvResultadosCertificacion.Click
        gvResultadosCertificacion_RowClick(Nothing, Nothing)
    End Sub
End Class