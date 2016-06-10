Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmRptReSatt
    Dim loRecaudacionAños As EERecaudacion = Nothing
    Dim listaRecaudacion As List(Of EERecaudacion) = Nothing
    Dim dtpivot As DataTable = New DataTable()
    Dim loRecaudacion As EERecaudacion = Nothing
    Dim Registro(25) As Object
#Region "Construir Table"
    Private Sub ConstruirTableRecaudacion()
        dtpivot.Columns.Add("recFecPago", GetType(Date))
        dtpivot.Columns.Add("recNroOrden", GetType(String))
        dtpivot.Columns.Add("conId", GetType(String))
        dtpivot.Columns.Add("partId", GetType(String))
        dtpivot.Columns.Add("CentroProd", GetType(String))
        dtpivot.Columns.Add("conNombre", GetType(String))
        dtpivot.Columns.Add("tgCueBanId", GetType(String))
        dtpivot.Columns.Add("pcontCuenC", GetType(String))
        dtpivot.Columns.Add("pcontCuenA", GetType(String))
        dtpivot.Columns.Add("Grupo", GetType(String))
        dtpivot.Columns.Add("conCodConMPT", GetType(String))
        dtpivot.Columns.Add("conCodPresMPT", GetType(String))
        dtpivot.Columns.Add("recNro", GetType(String))
        dtpivot.Columns.Add("perNroDoc", GetType(String))
        dtpivot.Columns.Add("perNombre", GetType(String))
        dtpivot.Columns.Add("recMonto", GetType(Decimal))
        dtpivot.Columns.Add("conPorcentaje", GetType(Decimal))
        dtpivot.Columns.Add("recTotalIng", GetType(Decimal))
        dtpivot.Columns.Add("recVComision", GetType(Decimal))
        dtpivot.Columns.Add("recComision", GetType(Decimal))
        dtpivot.Columns.Add("recNeto", GetType(Decimal))
        dtpivot.Columns.Add("Recaudadora", GetType(String))
        dtpivot.Columns.Add("Año", GetType(String))
        dtpivot.Columns.Add("Mes_Id", GetType(Short))
        dtpivot.Columns.Add("Mes", GetType(String))
        dtpivot.Columns.Add("recIngMuni", GetType(Decimal))
    End Sub
#End Region
    Private Sub frmRptReSatt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.cmbaños.Properties.Items.Add("Todos los Años")
        For Each Me.loRecaudacionAños In MantenimientosBL.Instancia.ListarAñosRec
            Me.cmbaños.Properties.Items.Add(loRecaudacionAños.RecAño)
        Next
        Me.cmbaños.SelectedItem = Me.cmbaños.Properties.Items(1)
        ConstruirTableRecaudacion()
        cmbgrupoingreso.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cmbgrupoingreso.Properties.DisplayMember = "TgNombre"
        cmbgrupoingreso.Properties.ValueMember = "TgCodigo"
        cmbgrupoingreso.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(25)
        cmbgrupoingreso.ItemIndex = 0
    End Sub

    Private Sub btnexportar_Click(sender As System.Object, e As System.EventArgs) Handles btnexportar.Click
        sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            pgcrecaudacion.ExportToXls(sfdexportar.FileName)
        End If
    End Sub
    Sub mostrarRecaudacion(ByVal aoTipoCriterio As Short, Optional ByVal año As Int16 = Nothing, Optional ByVal fecha As Date = Nothing)
        dtpivot.Rows.Clear()
        Me.pgcrecaudacion.DataSource = Nothing
        If año = 0 Then
            listaRecaudacion = MantenimientosBL.Instancia.ListarRecaudacionXAño(aoTipoCriterio, año, fecha)
            beiprogreso.Caption = String.Format("Cargando Datos del {0}...", Nothing, fecha)
        ElseIf fecha = Nothing Then
            listaRecaudacion = MantenimientosBL.Instancia.ListarRecaudacionXAño(aoTipoCriterio, año, fecha)
            beiprogreso.Caption = String.Format("Cargando Datos del {0}...", año, Nothing)
        End If

        If listaRecaudacion IsNot Nothing Then
            ripprogreso.Minimum = 0
            ripprogreso.Maximum = listaRecaudacion.Count
            beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            For Each Me.loRecaudacion In listaRecaudacion
                Application.DoEvents()
                beiprogreso.EditValue = beiprogreso.EditValue + 1
                Registro(0) = loRecaudacion.RecFecPago
                Registro(1) = loRecaudacion.RecNroOrden
                Registro(2) = loRecaudacion.OConcepto.ConId
                Registro(3) = loRecaudacion.OConcepto.PartId
                Registro(4) = loRecaudacion.OTCentroProduccion.TgNombre
                Registro(5) = loRecaudacion.OConcepto.ConNombre
                Registro(6) = loRecaudacion.OTBancos.TgCodigo
                Registro(7) = loRecaudacion.OConcepto.PcontCuenC
                Registro(8) = loRecaudacion.OConcepto.PcontCuenA
                Registro(9) = loRecaudacion.OTGrupo.TgNombre
                Registro(10) = loRecaudacion.OConcepto.ConCodConMPT
                Registro(11) = loRecaudacion.OConcepto.ConCodPresMPT
                Registro(12) = loRecaudacion.RecNro
                Registro(13) = loRecaudacion.PerNroDoc
                Registro(14) = loRecaudacion.PerNombre
                Registro(15) = loRecaudacion.RecMonto
                Registro(16) = loRecaudacion.ConPorcentaje
                Registro(17) = loRecaudacion.RecTotalIng
                Registro(18) = loRecaudacion.RecVComision
                Registro(19) = loRecaudacion.RecComision
                Registro(20) = loRecaudacion.RecNeto
                Registro(21) = loRecaudacion.OTRecaudadora.TgNombre
                Registro(22) = loRecaudacion.RecAño
                Registro(23) = loRecaudacion.RecMesId
                Registro(24) = loRecaudacion.RecMesNombre
                Registro(25) = loRecaudacion.recIngMuni
                dtpivot.Rows.Add(Registro)
            Next
            beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            beiprogreso.EditValue = 0
            Me.pgcrecaudacion.DataSource = dtpivot
            Me.pgcrecaudacion.BestFit()
        End If
    End Sub
    Private Sub btnmostrarxaño_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrarxaño.Click
        If cmbaños.SelectedIndex = 0 Then
            mostrarRecaudacion(cmbaños.SelectedIndex)
        Else
            mostrarRecaudacion(cmbaños.SelectedIndex, CShort(Me.cmbaños.SelectedItem))
        End If
    End Sub

    Private Sub btnverreporte_Click(sender As System.Object, e As System.EventArgs) Handles btnverreporte.Click
        Select Case Me.cmbreportes.SelectedIndex
            Case 0
                LimpiarPivot()
                pgfaño.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                pgfidmes.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                pgfmes.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                pgfcuentaabono.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                pgfcodconcepto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                pgfconcepto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                pgfmontopagado.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                pgfingresorec.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                'Me.fieldMUNI.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                pgfingresoSAIMT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                pgfporcrecaudacion.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                pgfingresorec.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                pgfneto.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Case 1
                LimpiarPivot()
                pgfaño.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                pgfidmes.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                pgfmes.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                pgffechapago.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                pgfneto.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                pgfcodconcepto.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                pgfcuentaabono.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        End Select
    End Sub
    Private Sub LimpiarPivot()
        pgfaño.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfcentroprod.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfcodconcepto.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfconcepto.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfcuentabanco.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfcuentacargo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfcuentacont.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfcuentapres.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgffechapago.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfgrupo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfidmes.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfingresorec.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfingresoSAIMT.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfmontopagado.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfneto.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfnro.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfnrodoc.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfnroorden.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfpartida.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfpersona.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfporcentajeSAIMT.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfporcrecaudacion.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfrecaudadora.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfidmes.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfmes.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        pgfcuentaabono.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
    End Sub

    Private Sub SaimtButton1_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrarxfecha.Click
        mostrarRecaudacion(Me.cmbaños.SelectedIndex, fecha:=dtpFechaRecaudacion.DateTime)
    End Sub

    Private Sub btnmostrardet_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrardet.Click
        If dtpFechaRecaudacion.EditValue Is Nothing Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Debe Seleccionar la fecha del detalle que desea ver")
        Else
            Dim fmPivotRecaudacionDet As frmPivotRecaudacionDet = New frmPivotRecaudacionDet(Me.dtpFechaRecaudacion.EditValue, cmbgrupoingreso.EditValue) With {.MdiParent = Me.MdiParent}
            fmPivotRecaudacionDet.BringToFront()
            fmPivotRecaudacionDet.Show()
        End If
    End Sub
End Class