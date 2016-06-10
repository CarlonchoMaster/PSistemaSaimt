﻿Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Imports System.IO
Public Class frmVisorDocumento
    Inherits frmMantenimientos
    Dim VInstitucionCod, VInstitucionIntCod, VInstitucionSiglas, VInstitucionNombre As String
    Dim CodProcedimiento, CodPerInteresado, Interesado, direccion As String
    Dim claseRequisitos As Integer = 92
    Dim dtTablaContacto As DataTable = New DataTable
    Dim dtTablaRequisitos As DataTable = New DataTable
    Dim dtVincular As DataTable = New DataTable()
    'Dim dtArchivos As DataTable = New DataTable()
    Dim dtMovimiento As DataTable = New DataTable("DTMovimientos")
    Dim dtMovimientoDet As DataTable = New DataTable("DTMovimientosDet")
    Dim recDs As New DataSet
    Dim ListaTemporalArchivosEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalArchivosNuevos As List(Of EEAnexoSTD) = New List(Of EEAnexoSTD)
    Dim ListaTemporalArchivosEditados As List(Of EEAnexoSTD) = New List(Of EEAnexoSTD)
    Dim lAnexoSTD As List(Of EEAnexoSTD) = Nothing
    Dim lMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
    Dim lpersonas As List(Of EEPersona) = Nothing
    Dim cargoOrigen As String = Nothing
    Dim vDocID, vTMovID, vtDocID, vOrigenId As String
    Dim dtMovimienoArch As DataTable = New DataTable()
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private lsDocIdConsulta As String
    Public Sub New(ByVal asDocId As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lsDocIdConsulta = asDocId
    End Sub


#Region "Construir Tablas"
    Private Sub ConstruirTableMovimientoArch()
        dtMovimienoArch.Columns.Add("movId", GetType(String))
        dtMovimienoArch.Columns.Add("movTgTDoc", GetType(String))
        dtMovimienoArch.Columns.Add("movNroDocInt", GetType(String))
        dtMovimienoArch.Columns.Add("movComentario", GetType(String))
        '  dtMovimienoArch.Columns.Add("movArchName", GetType(String))

    End Sub

    Private Sub ConstruirTableVincular()
        dtVincular.Columns.Add("docId", GetType(String))
        dtVincular.Columns.Add("docVinId", GetType(String))
        dtVincular.Columns.Add("docNParte", GetType(String))
        dtVincular.Columns.Add("nroDocumento", GetType(String))
        dtVincular.Columns.Add("año", GetType(String))
        dtVincular.Columns.Add("siglas", GetType(String))
        dtVincular.Columns.Add("institucionId", GetType(String))
        dtVincular.Columns.Add("asunto", GetType(String))
        dtVincular.Columns.Add("nroRegistro", GetType(String))
        dtVincular.Columns.Add("fechaRegistro", GetType(DateTime))
        dtVincular.Columns.Add("institucion", GetType(String))
        dtVincular.Columns.Add("area", GetType(String))
    End Sub

    'Private Sub ConstruirTableArchivos()
    '    dtArchivos.Columns.Add("docId", GetType(String))
    '    dtArchivos.Columns.Add("tgTipoArchId", GetType(String))
    '    dtArchivos.Columns.Add("AneId", GetType(String))
    '    dtArchivos.Columns.Add("AneNombre", GetType(String))
    '    dtArchivos.Columns.Add("AneDescripcion", GetType(String))
    '    dtArchivos.Columns.Add("tgTipoArch", GetType(String))
    '    dtArchivos.Columns.Add("AneArchExt", GetType(String))
    '    dtArchivos.Columns.Add("AneArch", GetType(String))
    '    dtArchivos.Columns.Add("AneArchNew", GetType(String))
    'End Sub
    Private Sub ConstruirTableContacto()
        dtTablaContacto.Columns.Add("Contacto", GetType(String))
        dtTablaContacto.Columns.Add("Descripcion", GetType(String))

    End Sub
    Private Sub ConstruirTableMovimiento()
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
        dtTablaRequisitos.Columns.Add("tgId", GetType(Integer))
        dtTablaRequisitos.Columns.Add("procId", GetType(String))
        dtTablaRequisitos.Columns.Add("reqId", GetType(String))
        dtTablaRequisitos.Columns.Add("requisito", GetType(String))
        dtTablaRequisitos.Columns.Add("nOrden", GetType(String))
        dtTablaRequisitos.Columns.Add("tgActivo", GetType(Boolean))
        dtTablaRequisitos.Columns.Add("tgDescripcion", GetType(String))
        dtTablaRequisitos.Columns.Add("reqPresento", GetType(Boolean))
    End Sub
#End Region

    Private Sub frmDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableContacto()
        ConstruirTableRequisito()
        ConstruirTableMovimiento()
        ConstruirTableVincular()
        ConstruirTableMovimientoArch()
        dgvArchivos.DataSource = dtMovimienoArch
        dgvDocumentosVinculados.DataSource = dtVincular
        dgvReqvsProc.DataSource = dtTablaRequisitos

        'sCboPrioridad.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        'sCboPrioridad.Properties.DisplayMember = "TgNombre"
        'sCboPrioridad.Properties.ValueMember = "TgCodigo"
        'sCboPrioridad.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(87)
        'sCboPrioridad.ItemIndex = 0

        mostrarDatosDocumento()
        BackstageViewControl1.SelectedTabIndex = 1
        BackstageViewControl1.SelectedTabIndex = 3
        BackstageViewControl1.SelectedTabIndex = 5


  
    End Sub

    Sub CargarInteresado(ByVal perID As String)
        CargarPersona(perID)
        CargarContactoPersona(perID)
        CodPerInteresado = perID
        TxtInteresado.Text = Interesado
        TxtDireccionPerInt.Text = direccion
    End Sub

    Sub CargarPersona(ByVal PerID As String)
        Dim loPersona As List(Of EEPersona)
        loPersona = MantenimientosBL.Instancia.personaListarCriterio(4, PerID)
        Interesado = Nothing
        direccion = Nothing
        For Each fpersona In loPersona
            Interesado = fpersona.PerApePaterno & " " & fpersona.PerApeMaterno & " " & fpersona.PerNombres
            direccion = fpersona.PerDireccion
        Next
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

    Private Sub btnInstitucion_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstitucion.ButtonClick
        If sCboMovTram.EditValue <> 0 Then
            Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(82)
                If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                    btnInstitucion.EditValue = fmConsultaTablaGeneral.TgNombre
                    VInstitucionCod = fmConsultaTablaGeneral.TgCodigo
                    sTxtSiglas.Text = fmConsultaTablaGeneral.TgSiglas
                    CargarAreas(VInstitucionCod)
                End If
            End Using
        End If
    End Sub

    Sub CargarAreas(ByVal InstitucionID As String)
        sCboAreas.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        sCboAreas.Properties.DisplayMember = "TgNombre"
        sCboAreas.Properties.ValueMember = "TgCodigo"
        sCboAreas.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, InstitucionID)
        sCboAreas.ItemIndex = 0
    End Sub

    Sub CargarAreasInt(ByVal InstitucionID As String)
        sCboAreaInt.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        sCboAreaInt.Properties.DisplayMember = "TgNombre"
        sCboAreaInt.Properties.ValueMember = "TgCodigo"
        sCboAreaInt.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, InstitucionID)
        sCboAreaInt.ItemIndex = 0
    End Sub


    'Sub RestringeTipoDoc()
    '    sCboMovTram.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
    '    sCboMovTram.Properties.DisplayMember = "TgNombre"
    '    sCboMovTram.Properties.ValueMember = "TgCodigo"
    '    sCboMovTram.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(101, sRdbOrigen.EditValue)
    '    sCboMovTram.ItemIndex = 0

    '    sCboTipoDocumento.mColumnas(SaimtComboBoxLookUp.Entidades.TipoDocumentoSTD)
    '    sCboTipoDocumento.Properties.DisplayMember = "TgNombre"
    '    sCboTipoDocumento.Properties.ValueMember = "TgCodigo"
    '    If cargoOrigen IsNot Nothing Then
    '        If sRdbOrigen.EditValue = 1 Then
    '            sCboTipoDocumento.Properties.DataSource = MantenimientosBL.Instancia.cargotipodocstdListarCriterio(1, cargoOrigen)
    '        ElseIf sRdbOrigen.EditValue = 2 Then
    '            sCboTipoDocumento.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(86)
    '        End If
    '        sCboTipoDocumento.ItemIndex = 0
    '    End If
    'End Sub

    Sub PropiedadesByOrigen(ByVal index As Integer)
        If index = 1 Then
            sCboMovTram.EditValue = "0"
            sRbTupac.SelectedIndex = 2
            sRbTupac.Properties.ReadOnly = True
            TxtProcedimiento.EditValue = Nothing
            CodProcedimiento = Nothing
            TxtProcedimientoVer.EditValue = Nothing
            TxtDireccionPerInt.Properties.ReadOnly = True
            TxtInteresado.Properties.ReadOnly = True
            'btnInteresado.Enabled = False
            btnInstitucionInt.Properties.ReadOnly = True
            sCboAreaInt.Properties.ReadOnly = True
            SCboCargoInt.Properties.ReadOnly = True
            CargarInteresado(EEComun._PerId)
            VInstitucionIntCod = VInstitucionCod
            btnInstitucionInt.EditValue = btnInstitucion.EditValue
            CargarAreasInt(VInstitucionIntCod)
            sCboAreaInt.EditValue = sCboAreas.EditValue
            ' CargarCargosInt(sCboAreaInt.EditValue & VInstitucionIntCod)
            SCboCargoInt.EditValue = cargoOrigen.Substring(7, 2)
        Else
            sRbTupac.SelectedIndex = 1
            sRbTupac.Properties.ReadOnly = False
            btnInstitucionInt.Properties.ReadOnly = False
            sCboAreaInt.Properties.ReadOnly = False
            SCboCargoInt.Properties.ReadOnly = False
            TxtDireccionPerInt.Properties.ReadOnly = False
            TxtInteresado.Properties.ReadOnly = False
            'btnInteresado.Enabled = True

            LimpiarInteresado()
        End If
    End Sub

    Sub LimpiarInteresado()
        CodPerInteresado = Nothing
        TxtDireccionPerInt.EditValue = Nothing
        TxtInteresado.EditValue = Nothing
        btnInstitucionInt.EditValue = Nothing
        VInstitucionIntCod = Nothing
        sCboAreaInt.Properties.DataSource = Nothing
        SCboCargoInt.Properties.DataSource = Nothing
        sCboAreaInt.EditValue = Nothing
        SCboCargoInt.EditValue = Nothing
        dgvDatosAdicionales.DataSource = Nothing
    End Sub

    Private Sub sRdbOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sRdbOrigen.SelectedIndexChanged
        'RestringeTipoDoc()
        If cargoOrigen IsNot Nothing Then
            PropiedadesByOrigen(sRdbOrigen.EditValue)
        End If
        'Dim lotablaGeneral As EETablaGeneral = MantenimientosBL.Instancia.tablageneralMostrarXClsIdXTgCodigo(82, cargoOrigen.Substring(0, 4))
        'If lotablaGeneral IsNot Nothing Then
        '    btnInstitucion.EditValue = lotablaGeneral.TgNombre
        '    VInstitucionNombre = lotablaGeneral.TgNombre
        '    VInstitucionCod = lotablaGeneral.TgCodigo
        '    VInstitucionSiglas = lotablaGeneral.TgAbrev
        '    sTxtSiglas.Text = lotablaGeneral.TgAbrev
        '    CargarAreas(VInstitucionCod)
        '    sCboAreas.EditValue = cargoOrigen.Substring(4, 3)
        'End If
        'If sRdbOrigen.EditValue = 1 Then
        '    btnInstitucion.Properties.ReadOnly = True
        '    sCboAreas.Properties.ReadOnly = True
        'Else
        '    btnInstitucion.Properties.ReadOnly = False
        '    sCboAreas.Properties.ReadOnly = False
        'End If
    End Sub

    Private Sub btnProcedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Using fmConsultaProcedimiento As frmConsultaProcedimiento = New frmConsultaProcedimiento()
            If fmConsultaProcedimiento.ShowDialog() = DialogResult.OK Then
                TxtProcedimiento.EditValue = fmConsultaProcedimiento.ProcNombre
                TxtProcedimientoVer.EditValue = fmConsultaProcedimiento.ProcNombre
                CodProcedimiento = fmConsultaProcedimiento.ProcId
                Dim lTablaGeneral As List(Of EETablaGeneral)
                lTablaGeneral = MantenimientosBL.Instancia.RequisitosListarxProcId(CodProcedimiento)
                dtTablaRequisitos.Clear()
                If lTablaGeneral IsNot Nothing Then
                    For Each fTablaGeneral As EETablaGeneral In lTablaGeneral
                        dtTablaRequisitos.LoadDataRow(New Object() {fTablaGeneral.TgId, fTablaGeneral.TgExtra.Substring(0, 4), _
                              fTablaGeneral.TgExtra.Substring(4, 4), _
                               fTablaGeneral.TgNombre, _
                               fTablaGeneral.TgCodigo, _
                               fTablaGeneral.TgActivo, _
                               fTablaGeneral.TgDescripcion, _
                                False
                       }, True)
                    Next
                    gvReqvsProc.BestFitColumns()
                End If
            End If
        End Using
    End Sub

    Sub CargarCargosInt(ByVal AreaInstitucion As String)
        SCboCargoInt.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        SCboCargoInt.Properties.DisplayMember = "TgNombre"
        SCboCargoInt.Properties.ValueMember = "TgCodigo"
        SCboCargoInt.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(84, AreaInstitucion)
        SCboCargoInt.ItemIndex = 0
    End Sub

    Private Sub sCboAreaInt_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sCboAreaInt.EditValueChanged
        If sCboAreaInt.EditValue IsNot Nothing Then
            CargarCargosInt(sCboAreaInt.EditValue & VInstitucionIntCod)
        End If
    End Sub

    Private Sub btnAnexos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexos.Click
        Try
            Dim fmGaleriaDocumentos As frmGaleriaDocumentos = New frmGaleriaDocumentos()
            fmGaleriaDocumentos.OAnexos = lAnexoSTD
            fmGaleriaDocumentos.Show()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub sCboTipoDocumento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'generarCodigo()
    End Sub

    Private Sub gvReqvsProc_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvReqvsProc.CellValueChanging
        If Me.gvReqvsProc.DataRowCount <> 0 Then
            Dim countReq As Int16
            dtTablaRequisitos.Rows(Me.gvReqvsProc.GetSelectedRows(0))("reqPresento") = e.Value
            For i As Integer = 0 To gvReqvsProc.DataRowCount - 1
                If dtTablaRequisitos.Rows(i)("reqPresento") = True Then
                    countReq = countReq + 1
                End If
            Next
            If countReq = Me.gvReqvsProc.DataRowCount Then
                chkReqActivos.Checked = True
            Else
                chkReqActivos.Checked = False
            End If
        End If
    End Sub
    'Private Sub btnVincular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim fConsultaStd As New frmConsultorSTD
    '        If fConsultaStd.ShowDialog = DialogResult.OK Then
    '            txtvinId.EditValue = fConsultaStd.docId
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub btnInstitucionInt_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnInstitucionInt.ButtonClick

        Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(82)
            If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
                btnInstitucionInt.EditValue = fmConsultaTablaGeneral.TgNombre
                VInstitucionIntCod = fmConsultaTablaGeneral.TgCodigo
                If VInstitucionIntCod IsNot Nothing Then
                    CargarAreasInt(VInstitucionIntCod)
                End If
            End If
        End Using
    End Sub

    'Private Sub btnVisorDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisorDoc.Click
    '    If txtvinId.EditValue IsNot Nothing Or btnVisorDoc.Text <> "" Then
    '        Using fmVisorDoc As frmVisorDocumento = New frmVisorDocumento(txtvinId.EditValue)
    '            fmVisorDoc.ShowDialog()
    '        End Using
    '    End If
    'End Sub

    Private Sub dgvDocumentosVinculados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDocumentosVinculados.DoubleClick
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

    Private Sub mostrarDatosDocumento()
        Dim loDocumentoStd As EEDocumentoSTD = MantenimientosBL.Instancia.documentoSTDMostrarXdocId(lsDocIdConsulta)

        'Cabecera
        sRdbOrigen.SelectedIndex = IIf(loDocumentoStd.DocOrigen = 1, 0, 1)
        vOrigenId = IIf(loDocumentoStd.DocOrigen = 1, 0, 1)
        sRbTupac.SelectedIndex = IIf(loDocumentoStd.DocTupac = True, 0, 1)
        sCboMovTram.Text = loDocumentoStd.TgMovTramite
        vTMovID = loDocumentoStd.TgMovTramiteId
        sCboTipoDocumento.Text = loDocumentoStd.TgTDoc
        vtDocID = loDocumentoStd.TgTDocId
        'Numero Registro
        TxtNdocReg.EditValue = loDocumentoStd.DocNReg
        txtAño.EditValue = loDocumentoStd.DocAño
        sTxtSiglas.EditValue = loDocumentoStd.DocSiglas
        VInstitucionSiglas = loDocumentoStd.DocSiglas
        VInstitucionCod = loDocumentoStd.TgInstitucionId
        btnInstitucion.EditValue = loDocumentoStd.TgInstitucion
        VInstitucionNombre = loDocumentoStd.TgInstitucion
        CargarAreas(VInstitucionCod)
        sCboAreas.EditValue = loDocumentoStd.TgAreaId
        txtdocid.EditValue = loDocumentoStd.DocId
        vDocID = loDocumentoStd.DocId
        ssFolios.EditValue = loDocumentoStd.DocNFolio
        dtpDocFechaIng.EditValue = loDocumentoStd.DocFechaIng
        dtpFechaDoc.EditValue = loDocumentoStd.DocFechaDoc
        CodProcedimiento = IIf(loDocumentoStd.ProcId.Length = 0, Nothing, loDocumentoStd.ProcId)
        TxtProcedimiento.EditValue = loDocumentoStd.procNombre
        txtasunto.EditValue = loDocumentoStd.DocAsunto
        TxtProcedimientoVer.Text = loDocumentoStd.procNombre
        'sCboPrioridad.EditValue = loDocumentoStd.TgPrioridadId
        'ssDocParte.EditValue = loDocumentoStd.DocNParte
        ' txtvinId.EditValue = loDocumentoStd.DocVinId
        chkReqActivos.Checked = loDocumentoStd.DocConfReq
        'txtvinId.EditValue = loDocumentoStd.DocVinId
        'txtexpedienteMPT1.EditValue = loDocumentoStd.DocExpMPT1
        'txtexpedienteMPT2.EditValue = loDocumentoStd.DocExpMPT2
        'txtexpedienteMPT3.EditValue = loDocumentoStd.DocExpMPT3
        txtDocAux.EditValue = loDocumentoStd.DocAux
        'Interesado
        CodPerInteresado = loDocumentoStd.PerId
        TxtInteresado.EditValue = loDocumentoStd.perNombreOrigen
        TxtDireccionPerInt.EditValue = loDocumentoStd.perDireccion
        VInstitucionIntCod = loDocumentoStd.TgInstitucionIntId
        btnInstitucionInt.EditValue = loDocumentoStd.TgInstitucionInt
        CargarAreasInt(loDocumentoStd.TgInstitucionIntId)
        sCboAreaInt.EditValue = loDocumentoStd.TgAreaIntId
        CargarCargosInt(loDocumentoStd.TgAreaIntId & loDocumentoStd.TgInstitucionIntId)
        SCboCargoInt.EditValue = loDocumentoStd.TgCargoIntId
        'Carga Contacto
        dtTablaContacto.Clear()
        CargarContactoPersona(CodPerInteresado)

        TxtDocRef.EditValue = loDocumentoStd.DocNRef
        'txtSumilla.EditValue = loDocumentoStd.DocSumilla
        txtcomentario.EditValue = loDocumentoStd.DocComentario


        Dim loReqDocumento As List(Of EEReqDocumentoSTD)
        loReqDocumento = MantenimientosBL.Instancia.reqdocumentostdXdocId(txtdocid.EditValue)
        Dim lTablaGeneral As List(Of EETablaGeneral)
        lTablaGeneral = MantenimientosBL.Instancia.RequisitosListarxProcId(CodProcedimiento)
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

        dtMovimiento.Clear()
        ' dtMovimienoArch.Clear()
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
                                                    fmovimiento.MovTieneArch
                                                                             }, True)



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
        gvDatosAdicionales.BestFitColumns()
        gvArchivos.BestFitColumns()

        dgvArchivos.Enabled = True
        dgvDatosAdicionales.Enabled = True
        dgvMovimientos.Enabled = True
        dgvReqvsProc.Enabled = True
        btnAnexos.Enabled = True
    End Sub

    Private Sub gvMovimientos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvMovimientos.DoubleClick
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