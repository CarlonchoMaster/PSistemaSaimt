Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmConsultaInmuebleXCriterios
    Dim oTable As DataTable = New DataTable()

    Public Property InmId() As String
    Public Property SQlString() As String


    Private Sub frmConsultaXUbicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        EEComun.CargarTablasGenerales(MantenimientosBL.Instancia.tablageneralListarXClasesId("26,27,28,32,33,176,177,179"))

        cboRubroGrupos.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRubroGrupos.Properties.DisplayMember = "TgNombre"
        cboRubroGrupos.Properties.ValueMember = "TgCodigo"
        cboRubroGrupos.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgRubrosGrupos, True)

        cboCondicionRegistral.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCondicionRegistral.Properties.DisplayMember = "TgNombre"
        cboCondicionRegistral.Properties.ValueMember = "TgCodigo"
        cboCondicionRegistral.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgCondicionRegistral)

        cboCondicionLegal.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCondicionLegal.Properties.DisplayMember = "TgNombre"
        cboCondicionLegal.Properties.ValueMember = "TgCodigo"
        cboCondicionLegal.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgCondicionLegal)

        cboSituacionFisica.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSituacionFisica.Properties.DisplayMember = "TgNombre"
        cboSituacionFisica.Properties.ValueMember = "TgCodigo"
        cboSituacionFisica.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgSituacionFisica)

        cboSFinformacion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSFinformacion.Properties.DisplayMember = "TgNombre"
        cboSFinformacion.Properties.ValueMember = "TgCodigo"
        cboSFinformacion.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgSFInformacion)

        cboEstadoSaneamiento.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoSaneamiento.Properties.DisplayMember = "TgNombre"
        cboEstadoSaneamiento.Properties.ValueMember = "TgCodigo"
        cboEstadoSaneamiento.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgEstadoSaneamiento)

        cboEstadoConservacion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoConservacion.Properties.DisplayMember = "TgNombre"
        cboEstadoConservacion.Properties.ValueMember = "TgCodigo"
        cboEstadoConservacion.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgEstadoConservacion)

        cboRubroGrupos.EditValue = "00"
        cboCondicionRegistral.EditValue = "00"
        cboCondicionLegal.EditValue = "00"
        cboEstadoSaneamiento.EditValue = "04"
        cboSFinformacion.EditValue = Nothing
        cboEstadoConservacion.EditValue = Nothing
        cboSituacionFisica.EditValue = Nothing
        ConstruirTable()
        dgvResultado.DataSource = oTable
    End Sub

    Private Sub ConstruirTable()
        oTable.Columns.Add("inmFile", GetType(String))
        oTable.Columns.Add("inmFileAnt", GetType(String))
        oTable.Columns.Add("inmUbicacion", GetType(String))
        oTable.Columns.Add("inmInscrito", GetType(String))
        oTable.Columns.Add("inmDenominacion", GetType(String))
        oTable.Columns.Add("tgInmCondReg", GetType(String))
        oTable.Columns.Add("inmPartidaElec", GetType(String))
        oTable.Columns.Add("tgInmCondLegal", GetType(String))
        oTable.Columns.Add("tgEstSan", GetType(String))
        oTable.Columns.Add("tgInmSitFisica", GetType(String))
        oTable.Columns.Add("tgInmSFUso", GetType(String))
        oTable.Columns.Add("tgEstInmConsv", GetType(String))
        oTable.Columns.Add("inmDisponibilidad", GetType(String))
        oTable.Columns.Add("inmId", GetType(String))
        '  oTable.Columns.Add("TgRubro", GetType(String))
        oTable.Columns.Add("InmPredArea", GetType(Decimal))
        oTable.Columns.Add("InmValComValxMetro", GetType(String))
        oTable.Columns.Add("InmValComValTerreno", GetType(String))
        oTable.Columns.Add("InmValComValConst", GetType(String))
        oTable.Columns.Add("InmValComValTotal", GetType(String))
        oTable.Columns.Add("InmSaneadoObsMostrable", GetType(String))
    End Sub


    Protected Overrides Sub buscar()
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As New EEInmueble
        Dim criterio As String = 3

        If chkCondicionRegistral.Checked = True Then
            If cboCondicionRegistral.EditValue IsNot Nothing Then
                loInmueble.tgInmCondRegId = cboCondicionRegistral.EditValue
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione la Condición Registral")
                Return
            End If
        Else
            loInmueble.tgInmCondRegId = Nothing
        End If

        If chkPartidaElectronica.Checked = True Then
            If Len(txtPartElectronica.EditValue) <> 0 Then
                loInmueble.InmPartidaElec = IIf(txtPartElectronica.EditValue = "", Nothing, txtPartElectronica.EditValue)
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Ingrese la partida Electronica")
                Return
            End If
        Else
            loInmueble.InmPartidaElec = Nothing
        End If

        If chkCondicionLegal.Checked = True Then
            If cboCondicionLegal.EditValue IsNot Nothing Then
                loInmueble.TgInmCondLegalId = cboCondicionLegal.EditValue
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione la Condicion Legal")
                Return
            End If
        Else
            loInmueble.TgInmCondLegalId = Nothing
        End If

        If chkEstadoSanemiento.Checked = True Then
            If cboEstadoSaneamiento.EditValue IsNot Nothing Then
                loInmueble.TgEstSanId = cboEstadoSaneamiento.EditValue
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione el Estado de Sanemiento")
                Return
            End If
        Else
            loInmueble.TgEstSanId = Nothing
        End If

        If chkRubros.Checked = True Then
            If cboRubroGrupos.EditValue IsNot Nothing Then
                loInmueble.TgRubroGrupoId = cboRubroGrupos.EditValue
                If cboRubroGrupos.EditValue <> 0 Then
                    If cboRubro.EditValue IsNot Nothing Then
                        If cboRubro.EditValue = 0 Then
                            loInmueble.TgRubroId = Nothing
                        Else
                            loInmueble.TgRubroId = cboRubro.EditValue
                        End If
                    Else
                        SaimtMessageBox.mostrarAlertaInformativa("Seleccione el Rubro")
                        Return
                    End If
                Else
                    loInmueble.TgRubroGrupoId = Nothing
                End If
            End If
        Else
            loInmueble.TgRubroId = Nothing
            loInmueble.TgRubroGrupoId = Nothing
        End If

        ' informicion- EEUsuarios actual -- Acesso peatonal

        If chkSituacionFisica.Checked = True Then
            If cboSituacionFisica.EditValue IsNot Nothing Then
                loInmueble.tgInmSitFisicaId = cboSituacionFisica.EditValue
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione el Uso Actual")
                Return
            End If
        Else
            loInmueble.tgInmSitFisicaId = Nothing
        End If

        If chkEstadoConservacion.Checked = True Then
            If cboEstadoConservacion.EditValue IsNot Nothing Then
                loInmueble.tgEstInmConsvId = cboEstadoConservacion.EditValue
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione el Estado de Conservación")
                Return
            End If
        Else
            loInmueble.tgEstInmConsvId = Nothing
        End If

        If chkZonificacionUso.Checked = True Then
            If cboSFinformacion.EditValue IsNot Nothing Then
                loInmueble.tgInmSFZonificacionId = cboSFinformacion.EditValue
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione el Estado de Conservación")
                Return
            End If
        Else
            loInmueble.tgInmSFZonificacionId = Nothing
        End If

        If chkDisponibilidad.Checked = True Then
            If cboDisponibilidad.SelectedText IsNot Nothing Then
                loInmueble.InmDisponibilidad = IIf(cboDisponibilidad.SelectedIndex = 0, True, False)
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Seleccione la disponibilidad")
                Return
            End If
        Else
            loInmueble.InmDisponibilidad = Nothing
        End If
        loInmueble.TgInmEstado = IIf(chkCriteriosInmEstado1.Checked = True, "01", Nothing)
        ListaInmueble = MantenimientosBL.Instancia.inmuebleListarConsultaCriterios(criterio, loInmueble)
        Try
            oTable.Clear()
            If ListaInmueble IsNot Nothing Then
                For Each fInmueble As EEInmueble In ListaInmueble
                    oTable.LoadDataRow(New Object() {
                    String.Format("File {0} - {1}", fInmueble.InmFile, fInmueble.TgRubro), _
                    fInmueble.InmFileAnt, _
                    fInmueble.InmUbicacion, _
                    fInmueble.InmInscrito, _
                    fInmueble.InmDenominacion, _
                    fInmueble.tgInmCondReg, _
                    fInmueble.InmPartidaElec, _
                    fInmueble.TgInmCondLegal, _
                    fInmueble.tgEstSan, _
                    fInmueble.tgInmSitFisica, _
                    fInmueble.tgInmSFUso, _
                    fInmueble.tgEstInmConsv, _
                    IIf(fInmueble.InmDisponibilidad = False, "NO", "SI"), _
                    fInmueble.InmId, _
                   fInmueble.OInmPredio.InmPredArea, _
                     fInmueble.OInmValorComercial.InmValComValxMetro, _
                    fInmueble.OInmValorComercial.InmValComValTerreno, _
                    fInmueble.OInmValorComercial.InmValComValConst, _
                    fInmueble.OInmValorComercial.InmValComValTotal, _
                    fInmueble.inmSaneadoObsMostrable}, True)
                Next
                gvResultado.BestFitColumns()
                Me.Encontrado = True
                SaimtLabel7.Text = oTable.Rows.Count & " Resultados de Busquedas"
            Else
                Me.Encontrado = False
            End If

            If Encontrado = False Then
                SaimtMessageBox.mostrarAlertaInformativa("No se encontro resultados")
            End If

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub seleccionar()
        If Me.gvResultado.DataRowCount <> 0 Then
            InmId = gvResultado.GetRowCellValue(Me.gvResultado.GetSelectedRows(0), "inmId").ToString()
            Seleccionado = True
            Dim fmVisorInmuebles As frmVisorInmuebles = New frmVisorInmuebles(InmId)
            fmVisorInmuebles.MdiParent = Me.MdiParent
            fmVisorInmuebles.BringToFront()
            fmVisorInmuebles.Show()
        Else
            Seleccionado = False
        End If
        MyBase.seleccionar()
    End Sub
    Private Sub cboGRubroFile_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRubroGrupos.EditValueChanged
        Dim TgExtra As String = cboRubroGrupos.EditValue
        cboRubro.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboRubro.Properties.DisplayMember = "TgNombre"
        cboRubro.Properties.ValueMember = "TgCodigo"
        cboRubro.Properties.DataSource = EEComun.DtByClsId(clsVariablesTablaGeneral.tblgRubros, True, TgExtra)
        ' cboRubro.ItemIndex = 0
    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        Me.sfdexportar.Filter = "Archivo de Excel|*.xls"
        If sfdexportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.gvResultado.ExportToXls(Me.sfdexportar.FileName)
        End If
    End Sub


End Class