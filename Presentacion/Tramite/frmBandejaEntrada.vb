Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTreeList.Nodes
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Public Class frmBandejaEntrada
    Inherits frmGeneral
    'Dim DsBandeja, recDs As New DataSet
    Dim dtRemitente, dtTablaContacto, dtTablaRequisitos, dtArchivos, dtBandeja, dtMovimiento, dtBandejaDet, dtVincular As DataTable
    Dim lAnexoSTD As List(Of EEAnexoSTD) = Nothing
    Dim lMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
    Dim lpersonas As List(Of EEPersona) = Nothing
    Dim tlpadre As TreeListNode
    Dim tlhijo As TreeListNode
    Dim vDocID, vTMovID, vtDocID, opcion, cargoOrigen, VEstMovId As String
    Dim ActualizaRow As Boolean = False
    Dim dtAcciones As DataTable = New DataTable
    Dim _PagN, _Pag, _Treg, _Nreg As Integer
    Dim dtMovimienoArch As DataTable = New DataTable()
    Enum Cls_TramiteDoc
        tgInstitucion = 82
        tgArea = 83
        tgCargo = 84
        tgEstadoTramite = 89
        tgTipoDestino = 96
    End Enum

#Region "Construir Tablas"
  
 
    Private Sub ConstruirTableRemitente()
        dtRemitente = New DataTable
        dtRemitente.Columns.Add("movId", GetType(String))
        dtRemitente.Columns.Add("movPara", GetType(String))
        dtRemitente.Columns.Add("docId", GetType(String))
        dtRemitente.Columns.Add("tOrigen", GetType(String))
        dtRemitente.Columns.Add("movRead", GetType(String))
        dtRemitente.Columns.Add("origen", GetType(String))
        dtRemitente.Columns.Add("cargoOrigen", GetType(String))
        dtRemitente.Columns.Add("destino", GetType(String))
        dtRemitente.Columns.Add("cargoDestino", GetType(String))
        dtRemitente.Columns.Add("movComentario", GetType(String))
        dtRemitente.Columns.Add("docNReg", GetType(String))
        dtRemitente.Columns.Add("tgTipoDoc", GetType(String))
        dtRemitente.Columns.Add("docAux", GetType(String))
        dtRemitente.Columns.Add("movFechaEnvio", GetType(String))
        dtRemitente.Columns.Add("tgEstadoTramite", GetType(String))
        dtRemitente.Columns.Add("tgTipoDestino", GetType(String))
        '   dtRemitente.Columns.Add("movNroTDestino", GetType(String))
        dtRemitente.Columns.Add("docAsunto", GetType(String))
        dtRemitente.Columns.Add("conAnexo", GetType(Boolean))
        dtRemitente.Columns.Add("grupomovFechaEnvio", GetType(Date))
        dtRemitente.Columns.Add("tgEstadoTramiteId", GetType(String))
        dtRemitente.Columns.Add("movAnulado", GetType(Boolean))
        dtRemitente.Columns.Add("movgaf", GetType(Integer))
        dtRemitente.Columns.Add("movEnviado", GetType(Boolean))
        dtRemitente.Columns.Add("movRecepcionado", GetType(Boolean))
        dtRemitente.Columns.Add("movVinculado", GetType(Boolean))
    End Sub
    Private Sub ConstruirTableBandeja()
        dtBandeja = New DataTable("DtBandeja")
        dtBandeja.Columns.Add("carPerId", GetType(String))
        dtBandeja.Columns.Add("cargo", GetType(String))
    End Sub
    Private Sub ConstruirTableBandejaDet()
        dtBandejaDet = New DataTable("DtBandeja")
        dtBandejaDet.Columns.Add("carPerId", GetType(String))
        dtBandejaDet.Columns.Add("todos", GetType(String))
        dtBandejaDet.Columns.Add("enviados", GetType(String))
        dtBandejaDet.Columns.Add("recibidos", GetType(String))
    End Sub

    Private Sub ConstruirTableContacto()
        dtTablaContacto = New DataTable
        dtTablaContacto.Columns.Add("Contacto", GetType(String))
        dtTablaContacto.Columns.Add("Descripcion", GetType(String))

    End Sub


    Private Sub ConstruirTableVincular()
        dtVincular = New DataTable
        dtVincular.Columns.Add("docId", GetType(String))
        dtVincular.Columns.Add("docParte", GetType(String))
        dtVincular.Columns.Add("docAsunto", GetType(String))
        dtVincular.Columns.Add("docNroReg", GetType(String))
        dtVincular.Columns.Add("docFechaReg", GetType(DateTime))
        dtVincular.Columns.Add("tgInstPerInt", GetType(String))
        dtVincular.Columns.Add("tgAreaPerInt", GetType(String))
        dtVincular.Columns.Add("perInteresado", GetType(String))
    End Sub

    Private Sub ConstruirTableMovimiento()
        dtMovimiento = New DataTable
        dtMovimiento.Columns.Add("movId", GetType(String))
        dtMovimiento.Columns.Add("perNombreOrigen", GetType(String))
        dtMovimiento.Columns.Add("perCargoOrigen", GetType(String))
        dtMovimiento.Columns.Add("perNombreDestino", GetType(String))
        dtMovimiento.Columns.Add("perCargoDestino", GetType(String))
        dtMovimiento.Columns.Add("movDiasTenencia", GetType(String))
        dtMovimiento.Columns.Add("movFechaRec", GetType(String))
        dtMovimiento.Columns.Add("tgEstadoMov", GetType(String))
        dtMovimiento.Columns.Add("movFechaEnv", GetType(String))
        dtMovimiento.Columns.Add("movTieneArch", GetType(Boolean))
    End Sub

    Private Sub ConstruirTableRequisito()
        dtTablaRequisitos = New DataTable
        dtTablaRequisitos.Columns.Add("tgId", GetType(Integer))
        dtTablaRequisitos.Columns.Add("procId", GetType(String))
        dtTablaRequisitos.Columns.Add("reqId", GetType(String))
        dtTablaRequisitos.Columns.Add("requisito", GetType(String))
        dtTablaRequisitos.Columns.Add("nOrden", GetType(String))
        dtTablaRequisitos.Columns.Add("tgActivo", GetType(Boolean))
        dtTablaRequisitos.Columns.Add("tgDescripcion", GetType(String))
        dtTablaRequisitos.Columns.Add("reqPresento", GetType(Boolean))
    End Sub

    Private Sub construirTableAcciones()
        dtAcciones.Columns.Add("TgCodigo", GetType(String))
        dtAcciones.Columns.Add("TgNombre", GetType(String))
    End Sub
#End Region

    Sub CargarDocumento(ByVal docId As String, Optional ByVal movId As String = Nothing)
        Try
            If docId IsNot Nothing Then
                Dim loDocumentoStd As EEDocumentoSTD
                loDocumentoStd = MantenimientosBL.Instancia.documentoSTDMostrarXdocId(docId, movId)
                Dim codProcedimiento As String = Nothing
                Dim frmman As New frmMantenimientos
                frmman.limpiarControlesTotal(GBoxDatosDocumento.Controls)
                frmman.limpiarControlesTotal(GBoxDatosAdicionales.Controls)
                If loDocumentoStd IsNot Nothing Then
                    sRdbOrigen.SelectedIndex = IIf(loDocumentoStd.DocOrigen = 1, 0, 1)
                    sRbTupac.SelectedIndex = IIf(loDocumentoStd.DocTupac = True, 0, 1)
                    txtMovDoc.EditValue = loDocumentoStd.TgMovTramite
                    vTMovID = loDocumentoStd.TgMovTramiteId
                    TxtTipoDoc.EditValue = loDocumentoStd.TgTDoc
                    vtDocID = loDocumentoStd.TgTDocId
                    'Numero Registro
                    TxtNdocReg.EditValue = loDocumentoStd.DocNReg
                    txtAño.EditValue = loDocumentoStd.DocAño
                    sTxtSiglas.EditValue = loDocumentoStd.DocSiglas
                    txtIntitucion.EditValue = loDocumentoStd.TgInstitucion
                    txtArea.EditValue = loDocumentoStd.TgArea
                    txtdocid.EditValue = loDocumentoStd.DocId
                    vDocID = loDocumentoStd.DocId
                    ssFolios.EditValue = loDocumentoStd.DocNFolio
                    txtDocFechaIng.EditValue = loDocumentoStd.DocFechaIng.ToString.Substring(0, 10)
                    txtDocFecha.EditValue = loDocumentoStd.DocFechaDoc.ToString.Substring(0, 10)
                    TxtProcedimiento.EditValue = loDocumentoStd.procNombre
                    txtasunto.EditValue = loDocumentoStd.DocAsunto
                    TxtProcedimientoVer.Text = loDocumentoStd.procNombre
                    'TxtPrioridad.EditValue = loDocumentoStd.TgPrioridad
                    'ssDocParte.EditValue = loDocumentoStd.DocNParte
                    chkReqActivos.Checked = loDocumentoStd.DocConfReq
                    TxtInteresado.EditValue = loDocumentoStd.perNombreOrigen
                    TxtDireccionPerInt.EditValue = loDocumentoStd.perDireccion
                    TxtInstitucionInt.EditValue = loDocumentoStd.TgInstitucionInt
                    TxtAreaInt.EditValue = loDocumentoStd.TgAreaInt
                    TxtCargoInt.EditValue = loDocumentoStd.TgCargoInt
                    TxtDocRef.EditValue = loDocumentoStd.DocNRef
                    txtcomentario.EditValue = loDocumentoStd.DocComentario
                    codProcedimiento = loDocumentoStd.ProcId
                    txtDocumentoAux.EditValue = loDocumentoStd.DocAux
                    CargarContactoPersona(loDocumentoStd.PerId)
                End If
                dtTablaRequisitos.Clear()
                ' dtArchivos.Clear()
                Dim loReqDocumento As New List(Of EEReqDocumentoSTD)
                loReqDocumento = MantenimientosBL.Instancia.reqdocumentostdXdocId(txtdocid.EditValue)
                Dim lTablaGeneral As New List(Of EETablaGeneral)
                lTablaGeneral = MantenimientosBL.Instancia.RequisitosListarxProcId(codProcedimiento)
                dtTablaRequisitos.Clear()
                Dim Activar As Boolean = False
                If lTablaGeneral IsNot Nothing Then
                    For Each fTablaGeneral As EETablaGeneral In lTablaGeneral
                        If loReqDocumento IsNot Nothing Then
                            For Each freqDoc As EEReqDocumentoSTD In loReqDocumento
                                If fTablaGeneral.TgExtra = freqDoc.TgReqId Then
                                    Activar = True
                                    Exit For
                                End If
                            Next
                        End If
                        dtTablaRequisitos.LoadDataRow(New Object() {fTablaGeneral.TgId, fTablaGeneral.TgExtra.Substring(4, 4), _
                              fTablaGeneral.TgExtra.Substring(0, 4), _
                               fTablaGeneral.TgNombre, _
                               fTablaGeneral.TgCodigo, _
                               fTablaGeneral.TgActivo, _
                               fTablaGeneral.TgDescripcion, _
                                Activar
                       }, True)
                    Next
                    gvReqvsProc.BestFitColumns()
                End If
                'If lAnexoSTD IsNot Nothing Then
                '    lAnexoSTD = New List(Of EEAnexoSTD)
                'End If
                'lAnexoSTD = MantenimientosBL.Instancia.anexostdListarxDocId(txtdocid.EditValue)
                'dtArchivos.Clear()
                'If lAnexoSTD IsNot Nothing Then
                '    For Each fAnexos As EEAnexoSTD In lAnexoSTD
                '        dtArchivos.LoadDataRow(New Object() {fAnexos.DocId, _
                '                                             fAnexos.TgTipoArchId, _
                '                                             fAnexos.AneId, _
                '                                             fAnexos.AneNombre, _
                '                                             fAnexos.AneDescripcion, _
                '                                             fAnexos.TgTipoArch, _
                '                                             fAnexos.AneArchExt, _
                '                                             fAnexos.AneArch, _
                '                                             fAnexos.AneArchNew
                '          }, True)
                '    Next
                'End If
                dtMovimiento.Clear()
                'dtMovimienoArch.Clear()
                If lMovimientoSTD IsNot Nothing Then
                    lMovimientoSTD = New List(Of EEMovimientoSTD)
                End If
                lMovimientoSTD = MantenimientosBL.Instancia.movimientoSTDListarxDocId(txtdocid.EditValue)
                If Not lMovimientoSTD Is Nothing Then
                    For Each fmovimiento As EEMovimientoSTD In lMovimientoSTD
                        dtMovimiento.LoadDataRow(New Object() {fmovimiento.MovId, fmovimiento.OPersonaOrigen.PerNombreCompleto, _
                                                           fmovimiento.OPersonaOrigen.OPerCargoPersonal.Cargo, _
                                                           fmovimiento.OPersonaDestino.PerNombreCompleto, _
                                                           fmovimiento.OPersonaDestino.OPerCargoPersonal.Cargo, _
                                                             fmovimiento.MovDiasTenencia, _
                                                             fmovimiento.MovFechaRec, _
                                                             fmovimiento.TgEstadoMov, _
                                                             fmovimiento.MovFechaEnv, _
                                                             fmovimiento.MovTieneArch}, True)



                    Next

                End If
                dtVincular.Clear()
                Dim loDocumentoVinSTD As List(Of EEExpedienteSTD)
                loDocumentoVinSTD = MantenimientosBL.Instancia.expedienteSTDListarVinculadosXDocId(txtdocid.EditValue)
                If loDocumentoVinSTD IsNot Nothing Then
                    Dim i As Int16 = 0
                    For Each fDocumentoSTD As EEExpedienteSTD In loDocumentoVinSTD
                        i = i + 1
                        dtVincular.LoadDataRow(New Object() { _
                            fDocumentoSTD.DocId, _
                                 i, _
                            fDocumentoSTD.loDocumento.DocAsunto, _
                            fDocumentoSTD.loDocumento.DocNRegT, _
                            fDocumentoSTD.loDocumento.DocFechaReg, _
                            fDocumentoSTD.loDocumento.OPersonaInteresada.OPerCargoPersonal.Institucion, _
                            fDocumentoSTD.loDocumento.OPersonaInteresada.OPerCargoPersonal.Area, _
                            fDocumentoSTD.loDocumento.OPersonaInteresada.PerNombreCompleto
                        }, True)
                    Next
                End If
                dgvMovimientos.DataSource = dtMovimiento
                gvMovimientos.BestFitColumns()
                gvReqvsProc.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Sub CargarContactoPersona(ByVal PerID As String)
        Dim loContacto As EEPersona
        loContacto = MantenimientosBL.Instancia.PersonaContactoXPerId(PerID)
        If loContacto IsNot Nothing Then
            dtTablaContacto.Clear()
            For Each fContacto As EEPersona.EEContacto In loContacto.ListaContacto
                dtTablaContacto.LoadDataRow(New Object() {fContacto.OTablaGeneral.TgNombre, _
                     IIf(fContacto.ContDescripcion Is Nothing, "", fContacto.ContDescripcion)
                   }, True)

            Next
            dgvDatosAdicionales.DataSource = dtTablaContacto
            gvDatosAdicionales.BestFitColumns()
        End If
    End Sub

    Private Sub frmBandejaEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Nreg = 100
        _Pag = 1
        ssNrow.EditValue = _Nreg
        'txtNActual.EditValue = _Pag

        ConstruirTableBandeja()
        ConstruirTableRemitente()
        ConstruirTableContacto()
        ConstruirTableRequisito()
        'ConstruirTableArchivos()
        ConstruirTableMovimiento()
        ConstruirTableVincular()
        construirTableAcciones()
        'ConstruirTableMovimientoArch()
        'dgvArchivos.DataSource = dtMovimienoArch
        dgvDocumentosVinculados.DataSource = dtVincular
        Dim loTablaGeneral As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId(96)
        If loTablaGeneral IsNot Nothing Then
            dtAcciones.LoadDataRow(New Object() {"0", "00 - Todos"}, True)
            For Each frow As EETablaGeneral In loTablaGeneral
                dtAcciones.LoadDataRow(New Object() {frow.TgCodigo, frow.TgNombre}, True)
            Next
        End If
        cboAccion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAccion.Properties.DisplayMember = "TgNombre"
        cboAccion.Properties.ValueMember = "TgCodigo"
        cboAccion.Properties.DataSource = dtAcciones ' MantenimientosBL.Instancia.tablageneralListarXClsId(96)
        cboAccion.ItemIndex = 0
        CboCriterioAnio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        CboCriterioAnio.Properties.DisplayMember = "TgNombre"
        CboCriterioAnio.Properties.ValueMember = "TgCodigo"
        CboCriterioAnio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(76)
        CboCriterioAnio.EditValue = Trim(Year(Date.Now))
        cboCriterioMes.SelectedIndex = 0
        Dim loCargoPersonal As New List(Of EECargoPersonal)
        loCargoPersonal = MantenimientosBL.Instancia.CargoListarXPerId_pa(EEComun._PerId)
        If loCargoPersonal IsNot Nothing Then
            Dim i As Int16 = 0
            For Each fCargoPersonal As EECargoPersonal In loCargoPersonal
                Dim data(1) As String
                data(0) = fCargoPersonal.CarPerId
                data(1) = fCargoPersonal.Cargo
                EEComun.PerCargo = fCargoPersonal.Cargo
                EEComun.PerCargoID = fCargoPersonal.CarPerId
                tlpadre = sTLBandeja.AppendNode(data, -1)
                tlpadre.ImageIndex = 5
                tlpadre.SelectImageIndex = 5
                Dim dataDet(1) As String
                'dataDet(0) = "0"
                'dataDet(1) = "Todos"
                'tlhijo = sTLBandeja.AppendNode(dataDet, tlpadre)
                'tlhijo.ImageIndex = 1
                'tlhijo.SelectImageIndex = 1
                dataDet(0) = "1"
                dataDet(1) = "Recibidos"
                tlhijo = sTLBandeja.AppendNode(dataDet, tlpadre)
                tlhijo.ImageIndex = 15
                tlhijo.SelectImageIndex = 15
                dataDet(0) = "2"
                dataDet(1) = "Enviados"
                tlhijo = sTLBandeja.AppendNode(dataDet, tlpadre)
                tlhijo.ImageIndex = 0
                tlhijo.SelectImageIndex = 0
                dataDet(0) = "4"
                dataDet(1) = "Doc. Anulados"
                tlhijo = sTLBandeja.AppendNode(dataDet, tlpadre)
                tlhijo.ImageIndex = 16
                tlhijo.SelectImageIndex = 16

            Next
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Usted no tiene permisos de envio de documentos")
            Return
        End If
        '  dgvArchivos.DataSource = dtArchivos
        dgvReqvsProc.DataSource = dtTablaRequisitos
        ' CargarInteresado(EEComun.PerId)
        XtraTabPage2.PageVisible = False
        tlCargo.ImageIndex = Me.sTLBandeja.Nodes(0).ImageIndex
        tlCargo.Caption = Me.sTLBandeja.Nodes(0).GetDisplayText(tlCargo)
        chkMostrarNrow.Checked = True
        Me.sTLBandeja.SetFocusedNode(Me.sTLBandeja.Nodes(0).Nodes(0))
        Paginacion("")
        ssNrow.Enabled = True
        sTLBandeja.ExpandAll()

        '   txtNRegistros.EditValue = MantenimientosBL.Instancia.movimientoSTDxCriterioCount(opcion, cargoOrigen, CboCriterioAnio.EditValue, cboCriterioMes.SelectedIndex)
        ' ssNrow.EditValue = IIf(txtNRegistros.EditValue > 200, 200, txtNRegistros.EditValue)

        'txtNRegistros.Enabled = False

        'Navegación

    End Sub

    Private Sub btnAbrirDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirDoc.Click
        If gvRemitente.RowCount <> 0 Then
            If Me.gvRemitente.GetSelectedRows(0) >= 0 Then
                VEstMovId = gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "tgEstadoTramiteId").ToString()
                If gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "tOrigen").ToString() = "1" And gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "movRead").ToString() = "0" Then
                    MantenimientosBL.Instancia.movimientostdActualizarLectura(gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "movId").ToString())
                End If
                CargarDocumento(gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "docId").ToString(), gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "movId").ToString())
                XtraTabPage1.PageVisible = False
                XtraTabPage2.PageVisible = True
                SaimtXtraTabControl1.SelectedTabPageIndex = 1
                btnSiguiente.Enabled = True
                btnAtras.Enabled = True
            End If
        End If
    End Sub

    Private Sub TxtBuscarPor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarPor.TextChanged
        Try
            If TxtBuscarPor IsNot Nothing Then
                Dim ListaMov As New List(Of EEMovimientoSTD)
                Dim tcriterio As String = sRbtipoCriterio.EditValue
                Dim criterio As String = TxtBuscarPor.EditValue
                Dim BindingSource As New BindingSource
                BindingSource.DataSource = dtRemitente
                Select Case tcriterio
                    Case 0 'N Registro
                        BindingSource.Filter = "[docNReg] like '%" & criterio & "%'"
                    Case 1 ' Asunto
                        BindingSource.Filter = "[docAsunto] like '%" & criterio & "%'"
                        'Case 2 ' Fecha Registro
                        '    Try

                        '        BindingSource.Filter = "[grupomovFechaEnvio]  = " & criterio
                        '    Catch ex As Exception

                        '    End Try
                    Case 3 ' Remitente
                        BindingSource.Filter = "[origen] like '%" & criterio & "%'"
                    Case 4 ' Cargo Remitente
                        BindingSource.Filter = "[cargoOrigen] like '%" & criterio & "%'"
                    Case 5 ' destino
                        BindingSource.Filter = "[destino] like '%" & criterio & "%'"
                    Case 6 ' destino
                        BindingSource.Filter = "[cargoDestino] like '%" & criterio & "%'"
                End Select
                dgvRemitente.DataSource = BindingSource.DataSource
                _Treg = gvRemitente.RowCount
                _Pag = 1
                Paginacion("")
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Sub Paginacion(ByVal opcion As String)
        If chkMostrarNrow.Checked = True Then
            _Nreg = ssNrow.EditValue
        Else
            _Nreg = _Treg
        End If
        If (_Treg = _Nreg) Then
            _PagN = (_Treg / (_Nreg + 1))
        Else
            _PagN = (_Treg / (_Nreg + 1)) + 1
        End If


        If opcion = ">" Then
            If _PagN > _Pag Then
                _Pag = _Pag + 1
                If _PagN = _Pag Then
                    btnPagAdelante.Enabled = False
                    btnPagUltimo.Enabled = False
                Else
                    btnPagAdelante.Enabled = True
                    btnPagUltimo.Enabled = True
                End If
                btnPagAtras.Enabled = True
                btnPagInicio.Enabled = True
            Else
                btnPagAdelante.Enabled = False
                btnPagUltimo.Enabled = False
            End If
        ElseIf opcion = "<" Then
            If _Pag > 1 Then
                _Pag = _Pag - 1
                If _Pag = 1 Then
                    btnPagAtras.Enabled = False
                    btnPagInicio.Enabled = False
                Else
                    btnPagAdelante.Enabled = True
                    btnPagUltimo.Enabled = True
                End If

            Else
                btnPagAtras.Enabled = False
                btnPagInicio.Enabled = False
            End If
        ElseIf opcion = "<<" Then
            _Pag = 1
            btnPagAtras.Enabled = False
            btnPagInicio.Enabled = False
        ElseIf opcion = ">>" Then
            _Pag = _PagN
            btnPagAdelante.Enabled = False
            btnPagUltimo.Enabled = False
        Else
            If _Pag = 1 Then
                btnPagAtras.Enabled = False
                btnPagInicio.Enabled = False
            Else
                btnPagAdelante.Enabled = True
                btnPagUltimo.Enabled = True
            End If

            If _PagN = 1 Then
                btnPagAtras.Enabled = False
                btnPagInicio.Enabled = False
                btnPagAdelante.Enabled = False
                btnPagUltimo.Enabled = False

                ' ssNrow.EditValue = _Treg
            Else
                btnPagAtras.Enabled = False
                btnPagInicio.Enabled = False
                btnPagAdelante.Enabled = True
                btnPagUltimo.Enabled = True
            End If

        End If

        ssNrow.EditValue = IIf(_Treg < _Nreg, _Treg, _Nreg)
        txtNRegistros.EditValue = _PagN
        txtNActual.EditValue = _Pag



    End Sub

    Sub CargarBandeja(Optional ByVal accion As String = "")
        Paginacion(accion)
        Dim listaMov As New List(Of EEMovimientoSTD)
        listaMov = MantenimientosBL.Instancia.movimientoSTDxCriterioPaginacion(Me.GCriterioBuscado, Me.GValorCriterioBuscado, _Pag, _Nreg, CboCriterioAnio.EditValue, (cboCriterioMes.SelectedIndex + 1))
        dtRemitente.Clear()
        If Not listaMov Is Nothing Then
            For Each fmovimiento As EEMovimientoSTD In listaMov
                dtRemitente.LoadDataRow(New Object() {fmovimiento.MovId,
                                                  fmovimiento.MovPara, _
                                                  fmovimiento.DocId, _
                                                 IIf(fmovimiento.MovPara = cargoOrigen, 1, 2), _
                                                 IIf(fmovimiento.MovRead = True, 1, 0), _
                                                  fmovimiento.ODocumento.perNombreOrigen, _
                                                  fmovimiento.OJerarquia.CargoOrigen, _
                                                  fmovimiento.ODocumento.perPara,
                                                  fmovimiento.OJerarquia.CargoDestino, _
                                                  fmovimiento.MovComentario, _
                                                  fmovimiento.ODocumento.DocNReg, _
                                                  fmovimiento.ODocumento.TgTDoc, _
                                                  fmovimiento.ODocumento.DocAux, _
                                                  fmovimiento.MovFechaEnv, _
                                                  fmovimiento.TgEstadoMov, _
                                                  fmovimiento.TgTDestino, _
                                                  fmovimiento.ODocumento.DocAsunto, _
                                                  fmovimiento.ODocumento.tieneAnexo, _
                                                 fmovimiento.MovFechaEnv, _
                                                 fmovimiento.TgEstadoMovId, _
                                                 fmovimiento.MovAnulado, _
                                                 fmovimiento.DiasPasados, _
                                                 fmovimiento.MovEnviado, _
                                                 fmovimiento.MovRecepcionado, fmovimiento.MovVinculado}, True)
            Next
            dgvRemitente.DataSource = dtRemitente
            gvRemitente.BestFitColumns()
            'Me.gcPrioridad.Width = 40
            Me.gcAdjunto.Width = 35
            Me.gctOrigen.Width = 40
            ' Me.gcMovRead.Width = 35
            Me.gcAsunto.Width = 400
            btnAnularEnvio.Enabled = False
            Select Case opcion
                Case "0"
                    gctOrigen.Visible = True
                    cDestino.Visible = True
                    gcDestinoCargo.Visible = True
                    gcOrigen.Visible = True
                    gcOrigenCargo.Visible = True
                    ' gcPrioridad.Visible = True
                    '  gcMovRead.Visible = True
                    gcMovEnviado.Visible = True
                    gcAsunto.Visible = True
                    gcMovFechaEnvio.Visible = True
                    gcTipoDestino.Visible = True
                    gcMovComentario.Visible = True
                    gcDocNReg.Visible = True
                    gcTipoDoc.Visible = True
                    gcDocumento.Visible = True
                    gctgEstadoTramite.Visible = True
                    'Definimos el orden de las columnas de la bandeja
                    gctOrigen.VisibleIndex = 0
                    ' gcPrioridad.VisibleIndex = 1
                    ' gcMovRead.VisibleIndex = 2
                    gcMovEnviado.VisibleIndex = 3
                    gcAsunto.VisibleIndex = 4
                    gcOrigen.VisibleIndex = 5
                    gcOrigenCargo.VisibleIndex = 6
                    cDestino.VisibleIndex = 7
                    gcDestinoCargo.VisibleIndex = 8
                    gcMovFechaEnvio.VisibleIndex = 9
                    gcTipoDestino.VisibleIndex = 10
                    gcMovComentario.VisibleIndex = 11
                    gcDocNReg.VisibleIndex = 12
                    gcTipoDoc.VisibleIndex = 13
                    gcDocumento.VisibleIndex = 14
                    gctgEstadoTramite.VisibleIndex = 15

                Case "1"
                    gctOrigen.Visible = False
                    gcOrigen.Visible = True
                    gcOrigenCargo.Visible = True
                    gcRecepcionado.Visible = True
                    cDestino.Visible = False
                    gcDestinoCargo.Visible = False
                    ' gcPrioridad.Visible = True
                    'gcMovRead.Visible = True
                    gcMovEnviado.Visible = True
                    gcAsunto.Visible = True
                    gcMovFechaEnvio.Visible = True
                    gcTipoDestino.Visible = True
                    gcTipoDoc.Visible = True
                    gcMovComentario.Visible = True
                    gcDocNReg.Visible = True
                    gctgEstadoTramite.Visible = True
                    'Definimos el orden de las columnas de la bandeja
                    ' gcPrioridad.VisibleIndex = 0
                    '  gcMovRead.VisibleIndex = 1
                    gcRecepcionado.VisibleIndex = 2
                    gcMovEnviado.VisibleIndex = 3
                    gcAsunto.VisibleIndex = 4
                    gcOrigen.VisibleIndex = 5
                    gcOrigenCargo.VisibleIndex = 6
                    gcMovFechaEnvio.VisibleIndex = 7
                    gcTipoDestino.VisibleIndex = 8
                    gcMovComentario.VisibleIndex = 9
                    gcDocNReg.VisibleIndex = 10
                    gcTipoDoc.VisibleIndex = 11
                    gcDocumento.VisibleIndex = 12
                    gctgEstadoTramite.VisibleIndex = 13
                Case "2"
                    btnAnularEnvio.Enabled = True
                    gctOrigen.Visible = False
                    gcOrigen.Visible = False
                    gcRecepcionado.Visible = False
                    gcOrigenCargo.Visible = False
                    cDestino.Visible = True
                    gcDestinoCargo.Visible = True
                    ' gcPrioridad.Visible = True
                    ' gcMovRead.Visible = True
                    gcMovEnviado.Visible = False
                    gcAsunto.Visible = True
                    gcMovFechaEnvio.Visible = True
                    gcTipoDestino.Visible = True
                    gcTipoDoc.Visible = True
                    gcMovComentario.Visible = True
                    gcDocNReg.Visible = True
                    gctgEstadoTramite.Visible = True
                    'Definimos el orden de las columnas de la bandeja
                    '  gcPrioridad.VisibleIndex = 0
                    '  gcMovRead.VisibleIndex = 1
                    gcAsunto.VisibleIndex = 2
                    cDestino.VisibleIndex = 3
                    gcDestinoCargo.VisibleIndex = 4
                    gcMovFechaEnvio.VisibleIndex = 5
                    gcTipoDestino.VisibleIndex = 6
                    gcMovComentario.VisibleIndex = 7
                    gcDocNReg.VisibleIndex = 8
                    gcTipoDoc.VisibleIndex = 9
                    gcDocumento.VisibleIndex = 10
                    gctgEstadoTramite.VisibleIndex = 11
                Case "3"
                    btnAnularEnvio.Enabled = True
                    gctOrigen.Visible = False
                    gcOrigen.Visible = False
                    gcRecepcionado.Visible = False
                    gcOrigenCargo.Visible = False
                    cDestino.Visible = True
                    gcDestinoCargo.Visible = True
                    ' gcPrioridad.Visible = True
                    ' gcMovRead.Visible = True
                    gcMovEnviado.Visible = False
                    gcAsunto.Visible = True
                    gcMovFechaEnvio.Visible = True
                    gcTipoDestino.Visible = True
                    gcTipoDoc.Visible = True
                    gcMovComentario.Visible = True
                    gcDocNReg.Visible = True
                    gctgEstadoTramite.Visible = True
                    'Definimos el orden de las columnas de la bandeja
                    ' gcPrioridad.VisibleIndex = 0
                    ' gcMovRead.VisibleIndex = 1
                    'gcMovEnviado.VisibleIndex = 2
                    gcAsunto.VisibleIndex = 2
                    cDestino.VisibleIndex = 3
                    gcDestinoCargo.VisibleIndex = 4
                    gcMovFechaEnvio.VisibleIndex = 5
                    gcTipoDestino.VisibleIndex = 6
                    gcMovComentario.VisibleIndex = 7
                    gcDocNReg.VisibleIndex = 8
                    gcTipoDoc.VisibleIndex = 9
                    gcDocumento.VisibleIndex = 10
                    gctgEstadoTramite.VisibleIndex = 11
            End Select
            Me.gvRemitente.ExpandAllGroups()
        End If
    End Sub

    Private Sub sTLBandeja_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles sTLBandeja.FocusedNodeChanged
        ' Dim cambio As Boolean = False
        If sTLBandeja.Nodes.Count > 0 Then
            If e.Node.Level = 0 Then
                cargoOrigen = e.Node.GetValue(0)
            ElseIf e.Node.Level = 1 Then
                opcion = e.Node.GetValue(0)
                If opcion = 3 Then
                    opcion = 4
                End If
            End If
        End If
        If cargoOrigen IsNot Nothing And opcion IsNot Nothing Then
            _Treg = MantenimientosBL.Instancia.movimientoSTDxCriterioCount(opcion, cargoOrigen, CboCriterioAnio.EditValue, (cboCriterioMes.SelectedIndex + 1))


            _Pag = 1
            Me.GCriterioBuscado = opcion
            Me.GValorCriterioBuscado = cargoOrigen
            CargarBandeja()
        End If

    End Sub

    Private Sub ActualizarBandeja()
        If sTLBandeja.Nodes.Count > 0 Then
            If sTLBandeja.FocusedNode.Level = 0 Then
                cargoOrigen = sTLBandeja.FocusedNode.GetValue(0)
            ElseIf sTLBandeja.FocusedNode.Level = 1 Then
                opcion = sTLBandeja.FocusedNode.GetValue(0)
            End If
        End If

        If cargoOrigen IsNot Nothing And opcion IsNot Nothing Then
            _Treg = MantenimientosBL.Instancia.movimientoSTDxCriterioCount(opcion, cargoOrigen, CboCriterioAnio.EditValue, (cboCriterioMes.SelectedIndex + 1))
            Me.GCriterioBuscado = opcion
            Me.GValorCriterioBuscado = cargoOrigen
            _Pag = 1
            CargarBandeja()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        'ActualizarBandeja()
        XtraTabPage2.PageVisible = False
        XtraTabPage1.PageVisible = True
        SaimtXtraTabControl1.TabIndex = 0
    End Sub

    Private Sub btnReenviar_Click(sender As System.Object, e As System.EventArgs) Handles btnReenviar.Click
        If SaimtMessageBox.mostrarAlertaPregunta("¿Desea Enviar el Documento?") = True Then
            XtraTabPage2.PageVisible = True
            XtraTabPage1.PageVisible = False
            Using fEnviarDoc As frmEnviarDoc = New frmEnviarDoc(txtdocid.Text, sRdbOrigen.EditValue)
                fEnviarDoc.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub dgvRemitente_DoubleClick(sender As System.Object, e As System.EventArgs) Handles dgvRemitente.DoubleClick
        If gvRemitente.RowCount <> 0 Then
            If Me.gvRemitente.GetSelectedRows(0) >= 0 Then
                VEstMovId = gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "tgEstadoTramiteId").ToString()
                If gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "tOrigen").ToString() = "1" And gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "movRead").ToString() = "0" Then
                    MantenimientosBL.Instancia.movimientostdActualizarLectura(gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "movId").ToString())
                End If
                CargarDocumento(gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "docId").ToString())
                XtraTabPage1.PageVisible = False
                XtraTabPage2.PageVisible = True
                SaimtXtraTabControl1.SelectedTabPageIndex = 1
                btnSiguiente.Enabled = True
                btnAtras.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnAtras_Click(sender As System.Object, e As System.EventArgs) Handles btnAtras.Click
        If Me.dtRemitente.Rows.Count <> 0 Then
            gvRemitente.MovePrev()
            Dim index As Integer = Me.gvRemitente.GetSelectedRows(0)
            If index >= 0 Then
                CargarDocumento(dtRemitente.Rows(index)("docId").ToString())
                If index = 0 Then
                    btnAtras.Enabled = False
                End If
            End If
            btnSiguiente.Enabled = True
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
        If Me.dtRemitente.Rows.Count <> 0 Then
            gvRemitente.MoveNext()
            Dim index As Integer = Me.gvRemitente.GetSelectedRows(0)
            If index = -2 Then
                gvRemitente.MoveNext()
                index = Me.gvRemitente.GetSelectedRows(0)
            End If
            If index < Me.gvRemitente.RowCount And index >= 0 Then
                CargarDocumento(dtRemitente.Rows(index)("docId").ToString())
                If index = Me.gvRemitente.RowCount - 1 Then
                    btnSiguiente.Enabled = False
                End If
            End If
            btnAtras.Enabled = True
        End If
    End Sub

    Private Sub ripcdestino_Click(sender As System.Object, e As System.EventArgs) Handles ripcdestino.Click
        lpersonas = MantenimientosBL.Instancia.personaListarXCargoId(dtRemitente.Rows(Me.gvRemitente.GetSelectedRows(0))("movPara").ToString())
        'Me.lbdestino.DataSource = lpersonas
        'Me.lbdestino.DisplayMember = "PerNombreCompleto"
    End Sub


    Private Sub sTLBandeja_AfterFocusNode(sender As System.Object, e As DevExpress.XtraTreeList.NodeEventArgs) Handles sTLBandeja.AfterFocusNode
        tlCargo.ImageIndex = e.Node.ImageIndex
        If e.Node.ParentNode Is Nothing Then
            tlCargo.Caption = e.Node.GetDisplayText(tlCargo)
        Else
            tlCargo.Caption = e.Node.GetDisplayText(tlCargo) & " - " & e.Node.ParentNode.GetDisplayText(tlCargo)
        End If
    End Sub


    Private Sub cbagrupar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbagrupar.CheckedChanged
        If cbagrupar.Checked Then
            gcTipoDestino.GroupIndex = 0
            gcGrupoMovFechaEnv.GroupIndex = 1
            Me.gvRemitente.ExpandAllGroups()
        Else
            gcGrupoMovFechaEnv.GroupIndex = -1
            gcGrupoMovFechaEnv.Visible = False
        End If
    End Sub

    Private Sub btnTerminar_Click(sender As System.Object, e As System.EventArgs) Handles btnTerminar.Click
        If dtRemitente.Rows.Count <> 0 Then
            If Me.gvRemitente.GetSelectedRows(0) >= 0 Then
                If Me.gvRemitente.GetFocusedRowCellValue("movRead") = 1 Then

                    Dim frmCambiarEstado As New frmCambiarEstadoSTD(gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "movId").ToString())
                    frmCambiarEstado.ShowDialog()
                Else
                    SaimtMessageBox.mostrarAlertaAdvertencia("Debe abrir primero el documento para poder agregar un comentario y cambiar el estado.")
                End If
            End If
        End If
    End Sub

    Private Sub btnrefrescar_Click(sender As System.Object, e As System.EventArgs) Handles btnrefrescar.Click
        ActualizarBandeja()
    End Sub


    Private Sub btnAnexos_Click(sender As System.Object, e As System.EventArgs) Handles btnAnexos.Click
        Try
            Dim fmGaleriaDocumentos As frmGaleriaDocumentos = New frmGaleriaDocumentos()
            fmGaleriaDocumentos.OAnexos = lAnexoSTD
            fmGaleriaDocumentos.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnVisorDoc_Click(sender As System.Object, e As System.EventArgs) Handles btnVisorDoc.Click
        If txtvinId.Properties.Tag IsNot Nothing Or btnVisorDoc.Text <> "" Then
            Using fmVisorDoc As frmVisorDocumento = New frmVisorDocumento(txtvinId.Properties.Tag)
                fmVisorDoc.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub dgvDocumentosVinculados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.lvDocumentosVinculados.DataRowCount <> 0 Then
                Dim docId As String = lvDocumentosVinculados.GetRowCellValue(Me.lvDocumentosVinculados.GetSelectedRows(0), "docVinId").ToString()
                Dim fmVisorDoc As frmVisorDocumento = New frmVisorDocumento(docId)
                fmVisorDoc.MdiParent = Me.MdiParent
                fmVisorDoc.BringToFront()
                fmVisorDoc.Show()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimirFlujo_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimirFlujo.Click
        Dim xl As Excel.Application
        xl = EEExcel.Instancia
        xl.Workbooks.Open(EEComun.RutaReportes & "\RptImprimirAcciones.xls", 1, True, 4)
        Dim ListaMovimiento As List(Of EEMovimientoSTD)
        Dim fecha As Date = Nothing
        If chkMovFechaEnv.Checked = True Then
            ListaMovimiento = MantenimientosBL.Instancia.movimientoSTD_Reportex_TgDestinoId_MovDeId(cboAccion.EditValue, cargoOrigen, dtpfechaIngDoc.EditValue)
        Else
            ListaMovimiento = MantenimientosBL.Instancia.movimientoSTD_Reportex_TgDestinoId_MovDeId(cboAccion.EditValue, cargoOrigen)
        End If
        If ListaMovimiento IsNot Nothing Then
            Dim fila As Integer = 6
            Dim i As Integer = 0
            For Each fMov In ListaMovimiento
                i = i + 1
                xl.Cells(fila, 1).Value = i
                xl.Cells(fila, 2).Value = fMov.ODocumento.DocNReg
                xl.Cells(fila, 3).Value = fMov.ODocumento.DocFechaIng
                xl.Cells(fila, 4).Value = fMov.ODocumento.perNombreOrigen
                xl.Cells(fila, 5).Value = fMov.ODocumento.TgCargoInt
                xl.Cells(fila, 6).Value = fMov.ODocumento.DocAsunto
                xl.Cells(fila, 6).WrapText = True
                xl.Cells(fila, 7).Value = fMov.ODocumento.TgTDoc
                xl.Cells(fila, 8).Value = fMov.ODocumento.DocFechaDoc
                xl.Cells(fila, 9).Value = fMov.ODocumento.DocFechaDoc.Value.Year
                xl.Cells(fila, 10).Value = fMov.ODocumento.DocAux
                xl.Cells(fila, 10).WrapText = True
                xl.Cells(fila, 11).Value = fMov.ODocumento.DocNRef
                xl.Cells(fila, 12).Value = fMov.MovFechaEnv
                xl.Cells(fila, 13).Value = fMov.OJerarquia.InstitucionOrigen
                xl.Cells(fila, 14).Value = fMov.OJerarquia.InstitucionDestino
                fila = fila + 1
            Next
        End If
        xl.Application.Visible = True
    End Sub

    'Private Sub ssNrow_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles ssNrow.EditValueChanged
    '    If ActualizaRow = True Then
    '        ActualizarBandeja()
    '    End If
    'End Sub


    Private Sub chkMostrarNrow_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMostrarNrow.CheckedChanged
        ssNrow.Enabled = chkMostrarNrow.Checked
        If chkMostrarNrow.Checked = False And ActualizaRow = True Then
            ActualizarBandeja()
        End If
        ActualizaRow = True
    End Sub

    Private Sub cboCriterioMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCriterioMes.SelectedIndexChanged
        'ssNrow.Enabled = chkMostrarNrow.Checked
        'If chkMostrarNrow.Checked = False And ActualizaRow = True Then
        ActualizarBandeja()
        'End If
        'ActualizaRow = True
    End Sub

    Private Sub CboCriterioAnio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCriterioAnio.EditValueChanged
        'ssNrow.Enabled = chkMostrarNrow.Checked
        'If chkMostrarNrow.Checked = False And ActualizaRow = True Then
        ActualizarBandeja()
        'End If
        'ActualizaRow = True
    End Sub

    Private Sub btnExportargrilla_Click(sender As System.Object, e As System.EventArgs) Handles btnExportargrilla.Click
        Me.sfdExportar.Filter = "Archivo de Excel|*.xls"
        If sfdExportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            gvRemitente.ExportToXls(sfdExportar.FileName)
        End If
    End Sub

    Private Sub SaimtButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularEnvio.Click
        If SaimtMessageBox.mostrarAlertaPreguntaYESNO("¿Esta seguro que desea eliminar el envio del documento?") Then
            If sTLBandeja.Nodes.Count > 0 Then
                If sTLBandeja.FocusedNode.Level = 1 Then
                    If sTLBandeja.FocusedNode.GetValue(0) = 2 Then
                        ' Que seleccione DataGrid
                        If dtRemitente.Rows.Count <> 0 Then
                            If Me.gvRemitente.GetSelectedRows(0) >= 0 Then
                                MantenimientosBL.Instancia.movimientostdEliminarXMovId(gvRemitente.GetRowCellValue(Me.gvRemitente.GetSelectedRows(0), "movId").ToString())
                                SaimtMessageBox.mostrarAlertaInformativa("El Menseje se Anulo Correctamente")
                                btnrefrescar_Click(Nothing, Nothing)
                            Else
                                'validacion para seleccionar mensaje a eliminar
                                SaimtMessageBox.mostrarAlertaInformativa("Seleccione el mensaje a eliminar")
                            End If
                        Else
                            'validacion cuando no encontraron datos
                            SaimtMessageBox.mostrarAlertaInformativa("No se encontraron datos")
                        End If

                    Else
                        'Validacion para solo eliminar mensajes enviados
                        SaimtMessageBox.mostrarAlertaInformativa("Solo se permite eliminar Mensajes Enviados")
                    End If

                End If
            End If
        End If
    End Sub
    Private Sub CheckButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckButton1.CheckedChanged
        gvRemitente.FormatConditions.Item(1).ApplyToRow = CheckButton1.Checked
        gvRemitente.FormatConditions.Item(2).ApplyToRow = CheckButton1.Checked
        gvRemitente.FormatConditions.Item(3).ApplyToRow = CheckButton1.Checked
    End Sub

    Private Sub ssNrow_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ssNrow.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnrefrescar.PerformClick()
        End If
    End Sub

    Private Sub btnPagAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagAdelante.Click
        ' Paginacion(">")
        CargarBandeja(">")
    End Sub

    Private Sub btnPagUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagUltimo.Click
        'Paginacion(">>")
        CargarBandeja(">>")
    End Sub

    Private Sub btnPagAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagAtras.Click
        'Paginacion("<")
        CargarBandeja("<")
    End Sub

    Private Sub btnPagInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagInicio.Click
        ' Paginacion("<<")
        CargarBandeja("<<")
    End Sub

    'Private Sub gclinkArchv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If Me.gvArchivos.DataRowCount <> 0 Then
    '            Dim movId As String = String.Empty
    '            movId = gvArchivos.GetRowCellValue(gvArchivos.GetSelectedRows(0), "movId").ToString()
    '            Dim frm As New frmVisorDocWord(, movId)
    '            frm.Show()
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub gvRemitente_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvRemitente.CellValueChanging
        If Me.gvRemitente.DataRowCount <> 0 Then
            If e.Column.Name = "gcRecepcionado" Then
                ' Dim recepcionado As Boolean = IIf(IsDBNull(gvRemitente.GetRowCellValue(gvRemitente.GetSelectedRows(0), "movRecepcionado")), False, gvRemitente.GetRowCellValue(gvRemitente.GetSelectedRows(0), "movRecepcionado"))
                If e.Value = True Then
                    If gvRemitente.GetRowCellValue(e.RowHandle, "movId").ToString <> "" Then
                        MantenimientosBL.Instancia.movimientostdActualizarRecepcionManual(gvRemitente.GetRowCellValue(e.RowHandle, "movId").ToString)
                        'gvRemitente.
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit3.CheckedChanged
        If Me.gvRemitente.DataRowCount <> 0 Then
            If gvRemitente.GetRowCellValue(gvRemitente.GetSelectedRows(0), "movRecepcionado") = True Then
                gvRemitente.SetRowCellValue(gvRemitente.GetSelectedRows(0), "movRecepcionado", True)
                SaimtMessageBox.mostrarAlertaInformativa("No se puede cambiar el estado de Recepcion, Comuniquese con el Area de Sistemas")
            End If
        End If
    End Sub

    Private Sub gvMovimientos_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gvMovimientos.DoubleClick
        Dim movId As String = String.Empty
        Dim rutaFile As String = String.Empty
        Dim loImagenConver As ImageConver = New ImageConver()
        Try
            If Me.gvMovimientos.DataRowCount <> 0 Then

                If CBool(gvMovimientos.GetFocusedRowCellValue("movTieneArch")) Then
                    movId = gvMovimientos.GetFocusedRowCellValue("movId").ToString()
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
