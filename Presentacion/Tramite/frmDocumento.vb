﻿Imports ReglasNegocio
Imports SaimtControles
Imports Entidades
Imports DevExpress.XtraEditors.Controls
Imports System.IO
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop

Public Class frmDocumento
    Inherits frmMantenimientos
    Dim xl As Excel.Application
    Dim VInstitucionCod, VInstitucionIntCod, VInstitucionSiglas, VInstitucionNombre As String
    Dim CodPerInteresado, Interesado, direccion As String
    Dim claseRequisitos As Integer = 92
    Dim dtTablaContacto As DataTable = New DataTable
    Dim dtTablaRequisitos As DataTable = New DataTable
    Dim dtVincular As DataTable = New DataTable()
    Dim dtAcciones As DataTable = New DataTable()
    Dim dtMovimiento As DataTable = New DataTable("DTMovimientos")
    Dim dtMovimienoArch As DataTable = New DataTable()
    Dim dtAreas As DataTable = New DataTable()
    Dim dtMovimientoDet As DataTable = New DataTable("DTMovimientosDet")
    Dim dtBusqueda As DataTable = New DataTable("DTBusqueda")
    Dim recDs As New DataSet
    Dim lAnexoSTD As List(Of EEAnexoSTD) = Nothing
    Dim lMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
    Dim lpersonas As List(Of EEPersona) = Nothing
    Dim vDocID, vTMovID, vtDocID, vOrigenId As String
    Dim docCarPerEdit As String = Nothing
    Dim dtListadoDocumento As DataTable = New DataTable()
    Dim ListaAcciones As List(Of EETablaGeneral) = Nothing

#Region "Construir Table Documento Listado"
    Private Sub ConstruirTableDocumentoListado()
        dtListadoDocumento.Columns.Add("docId", GetType(String))
        dtListadoDocumento.Columns.Add("docFechaReg", GetType(String))
        dtListadoDocumento.Columns.Add("docFechaIng", GetType(Date))
        dtListadoDocumento.Columns.Add("docAsunto", GetType(String))
        dtListadoDocumento.Columns.Add("docNRegT", GetType(String))
    End Sub
#End Region

#Region "Construir Tablas"
    Private Sub ConstruirTableVincular()
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

    Private Sub ConstruirTableAreas()
        dtAreas.Columns.Add("TgCodigo", GetType(String))
        dtAreas.Columns.Add("TgNombre", GetType(String))
    End Sub

    Private Sub ConstruirTableAcciones()
        dtAcciones.Columns.Add("TgCodigo", GetType(String))
        dtAcciones.Columns.Add("TgNombre", GetType(String))
    End Sub

    Private Sub ConstruirTableContacto()
        dtTablaContacto.Columns.Add("Contacto", GetType(String))
        dtTablaContacto.Columns.Add("Descripcion", GetType(String))
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

    Private Sub ContruirTablaBusqueda()
        dtBusqueda.Columns.Add("codigo", GetType(Short))
        dtBusqueda.Columns.Add("descripcion", GetType(String))
        dtBusqueda.LoadDataRow(New Object() {1, "N° Registro"}, True)
        dtBusqueda.LoadDataRow(New Object() {4, "Fec. Ingreso"}, True)
        dtBusqueda.LoadDataRow(New Object() {2, "Asunto"}, True)
        dtBusqueda.LoadDataRow(New Object() {5, "Siglas Dep."}, True)
        dtBusqueda.LoadDataRow(New Object() {3, "Asunto TUPA"}, True)
        dtBusqueda.LoadDataRow(New Object() {6, "Cod. Int."}, True)
        dtBusqueda.LoadDataRow(New Object() {81, "Internos"}, True)
        dtBusqueda.LoadDataRow(New Object() {82, "Externos"}, True)
        dtBusqueda.LoadDataRow(New Object() {10, "Expediente MPT"}, True)
        dtBusqueda.LoadDataRow(New Object() {11, "Documento"}, True)
        dtBusqueda.LoadDataRow(New Object() {12, "Expediente SAIMT"}, True)
        dtBusqueda.LoadDataRow(New Object() {13, "Apellidos y Nombres del Interesado"}, True)
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            limpiarControlesTotal(GBoxDatosAdicionales.Controls)
            limpiarControlesTotal(GBoxDatosDocumento.Controls)
            If Me.gvListadoDocumento.DataRowCount <> 0 Then
                'Cabecera
                Dim loDocumentoStd As EEDocumentoSTD = MantenimientosBL.Instancia.documentoSTDMostrarXdocId(gvListadoDocumento.GetRowCellValue(Me.gvListadoDocumento.GetSelectedRows(0), "docId").ToString())

                docCarPerEdit = loDocumentoStd.DocCargoIdEdit
                Try
                    sRdbOrigen.EditValue = loDocumentoStd.DocOrigen 'IIf(loDocumentoStd.DocOrigen = 1, 0, 1)
                Catch ex As Exception

                End Try
                vOrigenId = IIf(loDocumentoStd.DocOrigen = 1, 0, 1)
                sRbTupac.SelectedIndex = IIf(loDocumentoStd.DocTupac = True, 0, 1)
                sCboTipoAccion.EditValue = loDocumentoStd.TgMovTramiteId
                vTMovID = loDocumentoStd.TgMovTramiteId
                cbTipoDocAux.EditValue = loDocumentoStd.TgTDocId
                vtDocID = loDocumentoStd.TgTDocId
                'Numero Registro
                TxtNdocReg.EditValue = loDocumentoStd.DocNReg
                spañoReg.Value = loDocumentoStd.DocAño
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
                TxtProcedimiento.Tag = IIf(loDocumentoStd.ProcId.Length = 0, Nothing, loDocumentoStd.ProcId)
                TxtProcedimiento.EditValue = loDocumentoStd.procNombre
                txtasunto.EditValue = loDocumentoStd.DocAsunto
                TxtProcedimientoVer.Text = loDocumentoStd.procNombre

                chkReqActivos.Checked = loDocumentoStd.DocConfReq

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

                dtTablaContacto.Clear()
                CargarContactoPersona(CodPerInteresado)
                TxtDocRef.EditValue = loDocumentoStd.DocNRef
                ' txtSumilla.EditValue = loDocumentoStd.DocSumilla
                txtcomentario.EditValue = loDocumentoStd.DocComentario

                If vOrigenId = 1 Then
                    Dim loReqDocumento As List(Of EEReqDocumentoSTD)
                    loReqDocumento = MantenimientosBL.Instancia.reqdocumentostdXdocId(txtdocid.EditValue)

                    Dim lTablaGeneral As List(Of EETablaGeneral)
                    lTablaGeneral = MantenimientosBL.Instancia.RequisitosListarxProcId(TxtProcedimiento.Tag)
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

                End If



                dtMovimiento.Clear()
                dtMovimienoArch.Clear()
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
                            fDocumentoSTD.loDocumento.oPersonaInteresada.oPerCargoPersonal.Institucion, _
                            fDocumentoSTD.loDocumento.oPersonaInteresada.oPerCargoPersonal.Area, _
                            fDocumentoSTD.loDocumento.oPersonaInteresada.perNombreCompleto
                        }, True)
                    Next
                End If


                dgvMovimientos.DataSource = dtMovimiento
                gvMovimientos.BestFitColumns()
                gvReqvsProc.BestFitColumns()
                gvDatosAdicionales.BestFitColumns()
                'gvArchivos.BestFitColumns()
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            GValorTextoBuscado = TxtBuscarPor.Text
            GCriterioBuscado = cmbopciones.EditValue
            Dim tcriterio As Integer = IIf(cmbopciones.EditValue.ToString.Substring(0, 1) = 8, 8, cmbopciones.EditValue)
            Dim criterio, criterio2 As String
            criterio2 = Nothing
            If tcriterio = 8 Then
                criterio = cmbopciones.EditValue.ToString.Substring(1, 1)
                criterio2 = TxtBuscarPor.EditValue
                If criterio2 = "" Then
                    Return
                End If
            Else
                criterio = TxtBuscarPor.Text
                If tcriterio = 13 Then
                    criterio = TxtBuscarPor.Tag
                End If
            End If
            dtListadoDocumento.Clear()
            Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = MantenimientosBL.Instancia.documentostdListarDocNRegTCriterio(tcriterio, criterio, criterio2, spaño.Value)
            If ListaDocumentoSTD IsNot Nothing Then
                For Each fDocumentoSTD As EEDocumentoSTD In ListaDocumentoSTD
                    dtListadoDocumento.LoadDataRow(New Object() { _
                        fDocumentoSTD.DocId, _
                        fDocumentoSTD.DocFechaReg, _
                        fDocumentoSTD.DocFechaIng, _
                        fDocumentoSTD.DocAsunto, _
                         fDocumentoSTD.DocNRegT
                    }, True)
                Next
                gvListadoDocumento.BestFitColumns()
                gvListadoDocumento.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
                spaño.Properties.ReadOnly = False
                cmbopciones.Properties.ReadOnly = False
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub guardar()
        Try
            Dim lodocumentoSTD As EEDocumentoSTD = New EEDocumentoSTD()
            If sRdbOrigen.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el Origen del documento")
                sRdbOrigen.Focus()
                Return
            Else
                If sRdbOrigen.EditValue = 1 Then
                    cbTipoDocAux.EditValue = "00"
                    txtDocAux.EditValue = Nothing
                End If
            End If
            If sRbTupac.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione Si el Documento aplicara el Tupac del documento")
                sRbTupac.Focus()
                Return
            End If
            If txtdocid.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No se ha generado el Numero del DocId")
                sRbTupac.Focus()
                Return
            Else
                If Len(txtdocid.Text) = 0 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("No se ha generado el Numero del DocId")
                    sRbTupac.Focus()
                    Return
                End If
            End If
            If Len(TxtNdocReg.Text.Trim) <> 5 Then
                TxtNdocReg.Focus()
                SaimtMessageBox.mostrarAlertaAdvertencia("No se ha generado el Numero de Registro Correctamente, vuelva a intentar generar nuevamente")
                Exit Sub
            End If
            Dim siglas As String = (sTxtSiglas.Text & Space(9 - Len(sTxtSiglas.Text)))
            Dim Nreg As String = TxtNdocReg.EditValue & spañoReg.EditValue & siglas & VInstitucionCod & sCboAreas.EditValue
            If Nreg.Length < 15 Then
                If TxtNdocReg.EditValue Is Nothing Or Len(TxtNdocReg.Text.Trim) = 0 Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("No se ha generado el Numero de Registro Correctamente, vuelva a intentar generar nuevamente")
                    TxtNdocReg.Focus()
                    Exit Sub
                End If
                If spañoReg.EditValue Is Nothing Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("No se ha generado el año correctamente")
                    spañoReg.Focus()
                    Return
                End If
                If VInstitucionSiglas Is Nothing Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado la Institucion")
                    btnInstitucion.Focus()
                    Return
                End If
                If VInstitucionCod Is Nothing Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado la Institucion")
                    btnInstitucion.Focus()
                    Return
                End If
                If sCboAreas.EditValue Is Nothing Then
                    SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado el area")
                    sCboAreas.Focus()
                    Return
                End If
                Return
            End If

            If ssFolios.EditValue <= 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Nro de Folio Ingresado no es Valido")
                ssFolios.Focus()
                Return
            End If

            If TxtProcedimiento.Tag Is Nothing And sRbTupac.EditValue = 1 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado el procedimiento")
                btnProcedimiento.Focus()
                Return
            End If
            If txtasunto.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el asunto del Documento")
                txtasunto.Focus()
                Return
            End If

            If txtdocid.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha generado el DocID del documento")
                txtdocid.Focus()
                Return
            End If
            If TxtDocRef.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha ingresado el Nro de Referencia del Documento")
                TxtDocRef.Focus()
                Return
            End If
            If CodPerInteresado Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha Seleccionado el Interesado del Documento")
                btnInteresado.Focus()
                Return
            End If
            Dim DocInt As String = VInstitucionIntCod & sCboAreaInt.EditValue & SCboCargoInt.EditValue
            If DocInt.Length <> 9 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado el Cargo del Interesado")
                btnInstitucionInt.Focus()
                Return
            End If

            'If txtSumilla.EditValue Is Nothing Then
            '    SaimtMessageBox.mostrarAlertaAdvertencia("No ha Ingresado la Sumilla del Documento")
            '    txtSumilla.Focus()
            '    Return
            'End If
            If sCboTipoAccion.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado el Moviento del Documento")
                sCboTipoAccion.Focus()
                Return
            End If
            If cbTipoDocAux.EditValue Is Nothing And sRbTupac.EditValue = 2 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado el Tipo Documento")
                cbTipoDocAux.Focus()
                Return
            End If
            If dtpFechaDoc.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No ha seleccionado la fecha del Documento")
                dtpFechaDoc.Focus()
                Return
            End If

            If DateDiff(DateInterval.Day, dtpFechaDoc.EditValue, Date.Now) < 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("La Fecha del Documento no puede ser posterior a la de hoy")
                dtpFechaDoc.Focus()
                Return
            End If
            If DateDiff(DateInterval.Day, dtpDocFechaIng.EditValue, Date.Now) < 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("La Fecha de Ingreso del Documento no puede ser posterior a la de hoy")
                dtpDocFechaIng.Focus()
                Return
            End If
            For Each fTablaReqDoc As DataRow In dtTablaRequisitos.Rows
                If fTablaReqDoc("tgActivo") <> fTablaReqDoc("reqPresento") Then
                    Exit For
                    SaimtMessageBox.mostrarAlertaAdvertencia("Requisitos obligatorios no se estan seleccionando")
                    Return
                End If
            Next

            lodocumentoSTD.DocOrigen = sRdbOrigen.EditValue
            lodocumentoSTD.DocTupac = sRbTupac.EditValue
            lodocumentoSTD.TgTDocId = cbTipoDocAux.EditValue
            lodocumentoSTD.DocNReg = Nreg
            lodocumentoSTD.DocNFolio = ssFolios.EditValue
            lodocumentoSTD.DocFechaIng = dtpDocFechaIng.EditValue
            lodocumentoSTD.ProcId = TxtProcedimiento.Tag
            lodocumentoSTD.DocAsunto = txtasunto.EditValue
            lodocumentoSTD.DocId = txtdocid.EditValue
            lodocumentoSTD.DocConfReq = chkReqActivos.Checked
            lodocumentoSTD.PerId = CodPerInteresado
            lodocumentoSTD.DocInt = DocInt
            lodocumentoSTD.DocComentario = txtcomentario.EditValue
            lodocumentoSTD.TgMovTramiteId = sCboTipoAccion.EditValue
            lodocumentoSTD.DocFechaDoc = dtpFechaDoc.EditValue
            lodocumentoSTD.DocNRef = TxtDocRef.EditValue
            lodocumentoSTD.DocCargoIdEdit = EEComun.PerCargoID
            lodocumentoSTD.DocPerIdEdit = EEComun._PerId
            lodocumentoSTD.DocAux = txtDocAux.EditValue

            'Requisitos
            For Each fTablaReqDoc As DataRow In dtTablaRequisitos.Rows
                Dim loReqDoc As EEReqDocumentoSTD = New EEReqDocumentoSTD()
                If fTablaReqDoc("reqPresento") = True Then
                    loReqDoc.DocId = lodocumentoSTD.DocId
                    loReqDoc.TgReqId = fTablaReqDoc("reqId") & fTablaReqDoc("procId")
                    lodocumentoSTD.ListaRequisitosDoc.Add(loReqDoc)
                End If
            Next

            Dim guardado As Boolean
            If GEstadoNuevo Then
                guardado = MantenimientosBL.Instancia.documentostdGuardar(lodocumentoSTD)
            Else
                guardado = MantenimientosBL.Instancia.documentostdActualizar(lodocumentoSTD)
            End If



            Me.enabledGA = False
            MyBase.guardar()
            If guardado = True Then
                If SaimtMessageBox.mostrarAlertaPregunta("¿Desea Enviar el Documento?") = True Then
                    Using fEnviarDoc As frmEnviarDoc = New frmEnviarDoc(lodocumentoSTD.DocId, lodocumentoSTD.DocOrigen)
                        fEnviarDoc.ShowDialog()
                    End Using
                End If
            End If
            VInstitucionSiglas = Nothing
            TxtProcedimiento.Tag = Nothing
            VInstitucionCod = Nothing
            CodPerInteresado = Nothing
            '  tgTipoDocId = "00"
            dtMovimiento.Clear()
            dtTablaRequisitos.Clear()
            dtTablaContacto.Clear()
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub editar()
        If docCarPerEdit IsNot Nothing Then
            If docCarPerEdit = EEComun.PerCargoID Then
                MyBase.editar()
                TxtProcedimiento.Properties.ReadOnly = True
                TxtNdocReg.Properties.ReadOnly = True
                txtdocid.Properties.ReadOnly = True
                spañoReg.Properties.ReadOnly = True
                chkReqActivos.Properties.ReadOnly = True
            Else
                SaimtMessageBox.mostrarAlertaInformativa("Usted no tiene Permisos de Edicion del Documento, Solo le es permitido editar a la Persona que creo el Documento")
            End If
        End If
    End Sub
    Protected Overrides Sub cancelar()
        MyBase.cancelar()
        VInstitucionSiglas = Nothing
        dtMovimiento.Clear()
        'dtArchivos.Clear()
        dtTablaRequisitos.Clear()
        dtTablaContacto.Clear()
        LimpiarInteresado()
        btnInstitucion.EditValue = ""
        VInstitucionCod = Nothing
        cbTipoDocAux.ItemIndex = -1
        cbTipoDocAux.EditValue = Nothing
        sCboAreas.ItemIndex = -1
        sCboAreas.EditValue = Nothing
        chkReqActivos.Checked = False
        sCboTipoAccion.ItemIndex = -1
        sCboTipoAccion.EditValue = Nothing
        TxtProcedimiento.Tag = Nothing
        VInstitucionCod = Nothing
        CodPerInteresado = Nothing
        txtdocid.EditValue = Nothing
        TxtNdocReg.EditValue = Nothing
        spaño.Properties.ReadOnly = False
        cmbopciones.Properties.ReadOnly = False
        btnNuevo.Enabled = True
    End Sub
    Protected Overrides Sub nuevo()
        If EEComun.PerCargoID IsNot Nothing Then
            MyBase.nuevo()
            TxtProcedimiento.Properties.ReadOnly = True
            TxtProcedimientoVer.Properties.ReadOnly = True
            TxtNdocReg.Properties.ReadOnly = True
            txtdocid.Properties.ReadOnly = True
            spañoReg.Properties.ReadOnly = True
            sTxtSiglas.Properties.ReadOnly = True
            btnInstitucion.Properties.ReadOnly = True
            sCboAreas.Properties.ReadOnly = True
            spañoReg.Value = Date.Now.Year
            VInstitucionSiglas = Nothing
            TxtProcedimiento.Tag = Nothing
            VInstitucionCod = Nothing
            CodPerInteresado = Nothing
            sCboTipoAccion.ItemIndex = -1
            sCboTipoAccion.EditValue = Nothing
            sRdbOrigen.SelectedIndex = 2
            sRbTupac.SelectedIndex = 2
            btnEnviar.Enabled = False
            dtMovimiento.Clear()
            dtTablaRequisitos.Clear()
            dtTablaContacto.Clear()
            LimpiarInteresado()
            btnInstitucion.EditValue = ""
            VInstitucionCod = Nothing
            cbTipoDocAux.ItemIndex = -1
            cbTipoDocAux.EditValue = Nothing
            sCboAreas.ItemIndex = -1
            sCboAreas.EditValue = Nothing
            chkReqActivos.Checked = False
            chkReqActivos.Properties.ReadOnly = True
            spaño.Properties.ReadOnly = False
            cmbopciones.Properties.ReadOnly = False
            btnInstitucion.EditValue = "SERVICIO DE ADMINISTRACIÓN DE INMUEBLES MUNICIPALES DE TRUJILLO"
            VInstitucionNombre = "SERVICIO DE ADMINISTRACIÓN DE INMUEBLES MUNICIPALES DE TRUJILLO"
            VInstitucionCod = "0001"
            VInstitucionSiglas = "SAIMT"
            sTxtSiglas.Text = "SAIMT"
            sCboAreas.EditValue = EEComun.PerCargoID.Substring(4, 3)
            txtdocid.EditValue = MantenimientosBL.Instancia.documentosGenerarCodigo()
            TxtNdocReg.EditValue = MantenimientosBL.Instancia.documentosGenerarCodigoExterno()
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Usted No puede Crear Documentos, comunique al Area de Sistemas")
            Return
        End If
    End Sub

    Protected Overrides Sub imprimir()
        Dim oWordN As Word.Application
        Dim oDocN As Word._Document = Nothing
        Try
            Application.DoEvents()
            oWordN = CreateObject("Word.Application")
            oDocN = oWordN.Documents.Open(EEComun.RutaReportes & "\FichaTramiteDoc.docx", True, True)
            Dim wRng As Word.Range

            'CÓDIGO MARGESÍ MPT
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[INTERESADO]", ReplaceWith:=TxtInteresado.Text, Replace:=Word.WdReplace.wdReplaceAll)
            wRng = oDocN.Content

            If TxtProcedimiento.Text IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[ASUNTO]", ReplaceWith:=TxtProcedimiento.Text.ToUpper.Trim, Replace:=Word.WdReplace.wdReplaceAll)
            ElseIf txtasunto.Text IsNot Nothing Then
                wRng = oDocN.Content
                wRng.Find.Execute(FindText:="[ASUNTO]", ReplaceWith:=txtasunto.Text.ToUpper.Trim, Replace:=Word.WdReplace.wdReplaceAll)
            End If
       
            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[REFERENCIA]", ReplaceWith:="Registro N° " & TxtNdocReg.Text & "-" & spañoReg.Text & "-" & sTxtSiglas.Text, Replace:=Word.WdReplace.wdReplaceAll)

            wRng = oDocN.Content
            wRng.Find.Execute(FindText:="[FECHA]", ReplaceWith:=dtpDocFechaIng.EditValue, Replace:=Word.WdReplace.wdReplaceAll)

            oWordN.Visible = True


        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
        MyBase.imprimir()
    End Sub



#End Region

    Private Sub frmDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeConfirmar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeEnviar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        If EEComun.PerCargoID Is Nothing Then
            CargoPersona()
        End If

        ConstruirTableContacto()
        ConstruirTableRequisito()
        ConstruirTableMovimiento()
        ConstruirTableAcciones()
        ConstruirTableVincular()
        ConstruirTableDocumentoListado()
        ContruirTablaBusqueda()
        ConstruirTableAreas()
        dgvDocumentosVinculados.DataSource = dtVincular
        'dgvArchivos.DataSource = dtMovimienoArch
        dgvReqvsProc.DataSource = dtTablaRequisitos
        dgvListadoDocumento.DataSource = dtListadoDocumento
        cmbopciones.Properties.ReadOnly = False
        spaño.Properties.ReadOnly = False
        cmbopciones.Properties.DataSource = dtBusqueda
        cmbopciones.Properties.DisplayMember = "descripcion"
        cmbopciones.Properties.ValueMember = "codigo"
        cmbopciones.ItemIndex = 0
        spaño.Value = Year(Now)
        btnBuscar.Enabled = False

        Dim ListaAreasSAIMT As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, "0001")
        If ListaAreasSAIMT IsNot Nothing Then
            For Each loarea As EETablaGeneral In ListaAreasSAIMT
                dtAreas.LoadDataRow(New Object() {loarea.TgCodigo, loarea.TgNombre}, True)
            Next
            sCboAreas.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            sCboAreas.Properties.DisplayMember = "TgNombre"
            sCboAreas.Properties.ValueMember = "TgCodigo"
            sCboAreas.Properties.DataSource = dtAreas
        End If

        cbTipoDocAux.mColumnas(SaimtComboBoxLookUp.Entidades.TipoDocumentoSTD)
        cbTipoDocAux.Properties.DisplayMember = "TgNombre"
        cbTipoDocAux.Properties.ValueMember = "TgCodigo"
        cbTipoDocAux.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(86)
        cbTipoDocAux.ItemIndex = 0

        ListaAcciones = MantenimientosBL.Instancia.tablageneralListarXClsId(101)

    End Sub

    Sub CargoPersona()

        Dim loCargoPersonal As List(Of EECargoPersonal)
        loCargoPersonal = MantenimientosBL.Instancia.CargoListarXPerId_pa(EEComun._PerId)
        If loCargoPersonal IsNot Nothing Then
            If loCargoPersonal.Count = 1 Then
                For Each fCargoPersonal As EECargoPersonal In loCargoPersonal
                    EEComun.PerCargoID = fCargoPersonal.CarPerId
                Next
            Else
                Using frmSeleccionCargo As frmSeleccionCargoSTD = New frmSeleccionCargoSTD(loCargoPersonal)
                    If frmSeleccionCargo.ShowDialog() = DialogResult.OK Then
                        ' cargoOrigen = frmSeleccionCargo.CarPerId
                        EEComun.PerCargoID = frmSeleccionCargo.CarPerId
                        'EEComun.PerCargo = frmSeleccionCargo.LstCargos.
                    End If
                End Using
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("Usted no tiene permisos de envio de documentos")
            Return
        End If

    End Sub

    Sub CargarInteresado(ByVal perID As String)
        '  CargarPersona(perID)
        CargarContactoPersona(perID)
        CodPerInteresado = perID
        TxtInteresado.Text = Interesado
        TxtDireccionPerInt.Text = direccion
    End Sub

    Sub CargarPersona(ByVal PerID As String)
        Dim loPersona As EEPersona
        loPersona = MantenimientosBL.Instancia.personaListarXPerId(PerID)
        Interesado = Nothing
        direccion = Nothing
        If loPersona Is Nothing Then
            Interesado = String.Format("{0} {1} {2}", loPersona.PerApePaterno, loPersona.PerApeMaterno, loPersona.PerNombres)
            direccion = loPersona.PerDireccion
        End If
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
        If sCboTipoAccion.EditValue <> 0 Then
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
        If InstitucionID = "0001" Then
            sCboAreas.Properties.DataSource = dtAreas
        Else
            sCboAreas.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, InstitucionID)
        End If
        sCboAreas.ItemIndex = 0
    End Sub

    Sub CargarAreasInt(ByVal InstitucionID As String)
        sCboAreaInt.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        sCboAreaInt.Properties.DisplayMember = "TgNombre"
        sCboAreaInt.Properties.ValueMember = "TgCodigo"
        If InstitucionID = "0001" Then
            sCboAreaInt.Properties.DataSource = dtAreas
        Else
            sCboAreaInt.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, InstitucionID)
        End If

        sCboAreaInt.ItemIndex = 0
    End Sub

    Sub PropiedadesByOrigen(ByVal index As Integer)

        If index = 1 Then
            sRbTupac.SelectedIndex = 2
            sRbTupac.Properties.ReadOnly = True
            btnProcedimiento.Enabled = False
            TxtProcedimiento.EditValue = Nothing
            TxtProcedimiento.Tag = Nothing
            TxtProcedimientoVer.EditValue = Nothing
            TxtDireccionPerInt.Properties.ReadOnly = True
            TxtInteresado.Properties.ReadOnly = True
            btnInteresado.Enabled = False
            btnInstitucionInt.Properties.ReadOnly = True
            sCboAreaInt.Properties.ReadOnly = True
            SCboCargoInt.Properties.ReadOnly = True
            VInstitucionIntCod = VInstitucionCod
            btnInstitucionInt.EditValue = btnInstitucion.EditValue

            sCboAreaInt.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            sCboAreaInt.Properties.DisplayMember = "TgNombre"
            sCboAreaInt.Properties.ValueMember = "TgCodigo"
            sCboAreaInt.Properties.DataSource = dtAreas
            'sCboAreaInt.ItemIndex = 0
            sCboAreaInt.EditValue = sCboAreas.EditValue
            SCboCargoInt.EditValue = EEComun.PerCargoID.Substring(7, 2)

            CargarAreasInt(VInstitucionIntCod)
            CargarContactoPersona(EEComun._PerId)
            CodPerInteresado = EEComun._PerId
            TxtInteresado.Text = EEComun.PerNombreCompleto
            TxtDireccionPerInt.Text = EEComun.PerDireccion 'direccion
            lblTipoDoc.Visible = False
            cbTipoDocAux.Visible = False
            lblNroDoc.Visible = False
            txtDocAux.Visible = False
            SaimtLabel5.Visible = False
            sRbTupac.Visible = False
            BVTabRequisitos.Visible = False
            chkReqActivos.Visible = False
            SaimtLabel13.Visible = False
            TxtProcedimiento.Visible = False
            btnProcedimiento.Visible = False


        Else
            sRbTupac.SelectedIndex = 1
            sRbTupac.Properties.ReadOnly = False
            btnProcedimiento.Enabled = True
            btnInstitucionInt.Properties.ReadOnly = False
            sCboAreaInt.Properties.ReadOnly = False
            SCboCargoInt.Properties.ReadOnly = False
            TxtDireccionPerInt.Properties.ReadOnly = False
            TxtInteresado.Properties.ReadOnly = False
            btnInteresado.Enabled = True
            cbTipoDocAux.ItemIndex = -1
            cbTipoDocAux.EditValue = Nothing
            lblTipoDoc.Visible = True
            cbTipoDocAux.Visible = True
            lblNroDoc.Visible = True
            txtDocAux.Visible = True
            SaimtLabel5.Visible = True
            sRbTupac.Visible = True
            BVTabRequisitos.Visible = True
            chkReqActivos.Visible = True
            SaimtLabel13.Visible = True
            TxtProcedimiento.Visible = True
            btnProcedimiento.Visible = True
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
        If ListaAcciones IsNot Nothing Then
            dtAcciones.Clear()
            For Each loaccion As EETablaGeneral In ListaAcciones
                If loaccion.TgExtra = sRdbOrigen.EditValue Then
                    dtAcciones.LoadDataRow(New Object() {loaccion.TgCodigo, loaccion.TgNombre}, True)
                End If
            Next
            sCboTipoAccion.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            sCboTipoAccion.Properties.DisplayMember = "TgNombre"
            sCboTipoAccion.Properties.ValueMember = "TgCodigo"
            sCboTipoAccion.Properties.DataSource = dtAcciones

            If sRdbOrigen.SelectedIndex = 1 Then
                sCboTipoAccion.EditValue = "05"
            Else
                sCboTipoAccion.EditValue = "04"
            End If
        Else
            SaimtMessageBox.mostrarAlertaInformativa("Error, reinicie el formulario")
            Exit Sub
        End If


        If GEstadoNuevo Then
            If EEComun.PerCargoID IsNot Nothing Then
                PropiedadesByOrigen(sRdbOrigen.EditValue)
                btnInstitucion.EditValue = "SERVICIO DE ADMINISTRACIÓN DE INMUEBLES MUNICIPALES DE TRUJILLO"
                VInstitucionNombre = "SERVICIO DE ADMINISTRACIÓN DE INMUEBLES MUNICIPALES DE TRUJILLO"
                VInstitucionCod = "0001"
                VInstitucionSiglas = "SAIMT"
                sTxtSiglas.Text = "SAIMT"
                sCboAreas.EditValue = EEComun.PerCargoID.Substring(4, 3)
            End If
        End If


    End Sub

    Private Sub btnProcedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcedimiento.Click
        Using fmConsultaProcedimiento As frmConsultaProcedimiento = New frmConsultaProcedimiento()
            If fmConsultaProcedimiento.ShowDialog() = DialogResult.OK Then
                TxtProcedimiento.EditValue = fmConsultaProcedimiento.ProcNombre
                TxtProcedimientoVer.EditValue = fmConsultaProcedimiento.ProcNombre
                TxtProcedimiento.Tag = fmConsultaProcedimiento.ProcId
                Dim lTablaGeneral As List(Of EETablaGeneral)
                lTablaGeneral = MantenimientosBL.Instancia.RequisitosListarxProcId(TxtProcedimiento.Tag)
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

    Private Sub sRbTupac_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sRbTupac.SelectedIndexChanged
        If sRdbOrigen.EditValue = 2 And sRbTupac.EditValue = 1 Then
            btnProcedimiento.Enabled = True

        Else
            btnProcedimiento.Enabled = False
            TxtProcedimiento.EditValue = Nothing
        End If
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

    Private Sub btnInteresado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInteresado.Click
        Using fmConsultaPersona As frmConsultaPersonaGeneral = New frmConsultaPersonaGeneral(3)
            If fmConsultaPersona.ShowDialog() = DialogResult.OK Then
                TxtInteresado.EditValue = fmConsultaPersona.PerNombre
                TxtDireccionPerInt.EditValue = fmConsultaPersona.PerDireccion
                CodPerInteresado = fmConsultaPersona.PerId
                CargarContactoPersona(fmConsultaPersona.PerId)
                If sRdbOrigen.EditValue = 2 Then
                    Dim loCargoPersonal As List(Of EECargoPersonal)
                    loCargoPersonal = MantenimientosBL.Instancia.CargoListarXPerId_pa(CodPerInteresado)
                    If loCargoPersonal IsNot Nothing Then
                        If loCargoPersonal.Count = 1 Then
                            For Each fcargo As EECargoPersonal In loCargoPersonal
                                VInstitucionIntCod = fcargo.CodInstitucion
                                btnInstitucionInt.EditValue = fcargo.Institucion
                                CargarAreasInt(VInstitucionIntCod)
                                sCboAreaInt.EditValue = fcargo.CodArea
                                CargarCargosInt(sCboAreaInt.EditValue & VInstitucionIntCod)
                                SCboCargoInt.EditValue = fcargo.CodCargo
                            Next
                        Else
                            Using fmSelCargo As frmSeleccionCargoSTD = New frmSeleccionCargoSTD(loCargoPersonal)
                                If fmSelCargo.ShowDialog() = DialogResult.OK Then
                                    Dim carperiD As String = fmSelCargo.CarPerId
                                    VInstitucionIntCod = carperiD.Substring(0, 4)
                                    CargarAreasInt(VInstitucionIntCod)
                                    sCboAreaInt.EditValue = carperiD.Substring(4, 3)
                                    CargarCargosInt(sCboAreaInt.EditValue & VInstitucionIntCod)
                                    SCboCargoInt.EditValue = carperiD.Substring(7, 2)
                                End If
                            End Using
                        End If
                        btnInstitucionInt.Properties.ReadOnly = True
                        sCboAreaInt.Properties.ReadOnly = True
                        SCboCargoInt.Properties.ReadOnly = True
                    Else
                        btnInstitucionInt.EditValue = Nothing
                        VInstitucionIntCod = Nothing
                        sCboAreaInt.Properties.DataSource = Nothing
                        sCboAreaInt.EditValue = Nothing
                        SCboCargoInt.Properties.DataSource = Nothing
                        SCboCargoInt.EditValue = Nothing
                        btnInstitucionInt.Properties.ReadOnly = False
                        sCboAreaInt.Properties.ReadOnly = False
                        SCboCargoInt.Properties.ReadOnly = False
                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub btnAnexos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexos.Click
        Try
            Dim fmGaleriaDocumentos As frmGaleriaDocumentos = New frmGaleriaDocumentos()
            fmGaleriaDocumentos.OAnexos = lAnexoSTD
            fmGaleriaDocumentos.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        If SaimtMessageBox.mostrarAlertaPregunta("¿Desea Enviar el Documento?") = True Then
            'Dim LoMovimiento As EEMovimientoSTD
            'LoMovimiento = MantenimientosBL.Instancia.movimientoSTD_Ultimo_tgEstadoMovIdxDocId(txtdocid.EditValue)
            Dim fEnviarDoc As frmEnviarDoc
            'If LoMovimiento IsNot Nothing Then
            fEnviarDoc = New frmEnviarDoc(txtdocid.EditValue, sRdbOrigen.EditValue)
            'Else
            'fEnviarDoc = New frmEnviarDoc(txtdocid.EditValue)
            '  End If
            fEnviarDoc.Show()
        End If
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

    'Private Sub sCboMovTram_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sCboMovTram.EditValueChanged
    '    'If sCboMovTram.EditValue = 1 Then
    '    '    btnEnviar.Enabled = True
    '    'Else
    '    '    btnEnviar.Enabled = False
    '    'End If
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

    Private Sub btnVisorDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisorDoc.Click
        'If txtvinId.Properties.Tag IsNot Nothing Or btnVisorDoc.Text <> "" Then
        '    Using fmVisorDoc As frmVisorDocumento = New frmVisorDocumento(txtvinId.Properties.Tag)
        '        fmVisorDoc.ShowDialog()
        '    End Using
        'End If
    End Sub

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

    Private Sub gvListadoDocumento_CustomRowCellEditForEditing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvListadoDocumento.CustomRowCellEditForEditing
        seleccionarListado()
    End Sub

    'Private Sub rgopciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If GEstadoNuevo Then
    '        If rgopciones.EditValue = 0 Then
    '            generarCodigo()
    '            btnbuscarReg.Enabled = False
    '            txtvinId.Properties.Tag = ""
    '            txtvinId.EditValue = ""
    '        ElseIf rgopciones.EditValue = 1 Then
    '            btnbuscarReg.Enabled = True
    '            TxtNdocReg.Text = ""
    '        End If
    '    End If
    'End Sub

    'Private Sub btnbuscarReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim fConsultaStd As New frmConsultorSTD
    '        If fConsultaStd.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '            txtvinId.Properties.Tag = fConsultaStd.docId
    '            txtvinId.Text = fConsultaStd.docNroRegistro
    '            TxtNdocReg.Text = fConsultaStd.docId.Substring(0, 5).Trim
    '        End If
    '    Catch ex As Exception
    '        SaimtMessageBox.mostrarAlertaError(ex.Message)
    '    End Try
    'End Sub

    'Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

    'End Sub

    Private Sub cmbopciones_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbopciones.EditValueChanged
        If cmbopciones.EditValue = 13 Then
            btnBuscar.Enabled = True
        Else
            btnBuscar.Enabled = False
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim frm As frmConsultaPersonaGeneral = New frmConsultaPersonaGeneral(3)
        If frm.ShowDialog Then
            TxtBuscarPor.Text = frm.PerNombre
            TxtBuscarPor.Tag = frm.PerId
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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

    End Sub
End Class