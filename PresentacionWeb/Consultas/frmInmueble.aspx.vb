Imports Entidades
Imports ReglasNegocio

Public Class frmInmueble
    Inherits System.Web.UI.Page

    Dim dtTableArchivos As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTableArchivos()
        dtTableArchivos.Columns.Add("inmArchId", GetType(String))
        dtTableArchivos.Columns.Add("inmArchNombre", GetType(String))
        dtTableArchivos.Columns.Add("inmArchDescripcion", GetType(String))
        dtTableArchivos.Columns.Add("tgTipoArchId", GetType(String))
        dtTableArchivos.Columns.Add("inmArch", GetType(Byte()))
        dtTableArchivos.Columns.Add("inmArchExt", GetType(String))
        dtTableArchivos.Columns.Add("inmArchPrincipal", GetType(Boolean))

        'dtTableArchivos.Columns("inmArchId").ColumnMapping = MappingType.Hidden
        'dtTableArchivos.Columns("tgTipoArchId").ColumnMapping = MappingType.Hidden
        'dtTableArchivos.Columns("inmArch").ColumnMapping = MappingType.Hidden
    End Sub
#End Region

    Public Sub mConsultaInmuebleXInmId(ByVal asInmId As String)
        Dim loInmueble As EEInmueble = ReglasWebBL.Instancia.inmuebleConsultarXInmIdWEB(asInmId)
        'loInmuebleGaleria = loInmueble.ListaInmArchivos

        lblNroInmueble.Text = loInmueble.InmId
        txtNroFile.Text = loInmueble.InmFile
        txtDenominacion.Text = loInmueble.InmDenominacion
        txtTipoUnidad.Text = loInmueble.TgTipoUnidadNombre
        txtFincaInscrita.Text = loInmueble.InmInscrito
        txtEstadoInmueble.Text = loInmueble.TgInmEstadoNombre
        txtInmueblePrincipal.Text = loInmueble.InmFilePadre
        'txtInmueblePrincipal.Tag = loInmueble.InmIdPadre
        If loInmueble.InmFecMarg IsNot Nothing Then
            txtFechaRegistroMargesi.Text = loInmueble.InmFecMarg
        End If

        txtNroFileAnterior.Text = loInmueble.InmFileAnt
        txtRubroGrupo.Text = loInmueble.TgRubroGrupo
        txtRubroEspecifico.Text = loInmueble.TgRubro
        chkDisponibilidad.Checked = loInmueble.InmDisponibilidad
        txtDocAcredita.Text = loInmueble.InmDocAcredita
        txtSituacionLegal.Text = loInmueble.tgInmCondReg
        'txtSituacion.Text = loInmueble.TgInmSituacionNombre
        txtPartidaElectronica.Text = loInmueble.InmPartidaElec
        txtAsiento.Text = loInmueble.InmAsiento
        chkInmuebleActivo.Checked = loInmueble.InmActivo
        txtEstadoSaneamiento.Text = loInmueble.tgEstSan
        txtObservacionLegal.Text = loInmueble.InmSaneadoObs
        txtEstadoConservacion.Text = loInmueble.tgEstInmConsv
        txtNroPisos.Text = loInmueble.InmNroPisos
        txtObservacionTecnica.Text = loInmueble.InmObservacion

        'Direccion
        'lsInmDirId = loInmueble.OInmDireccion.InmDirId
        txtDepartamento.Text = loInmueble.OInmDireccion.InmDirDepartamento
        txtProvincia.Text = loInmueble.OInmDireccion.InmDirProvincia
        txtDistrito.Text = loInmueble.OInmDireccion.InmDirDistrito
        ' txtDirVia.Text = loInmueble.OInmDireccion.TgViaNombre
        txtDirNumero.Text = loInmueble.OInmDireccion.InmDirNro
        ' txtDirLote.Text = loInmueble.OInmDireccion.InmDirLote
        txtDirEtapa.Text = loInmueble.OInmDireccion.InmDirEtapa
        txtDirLocalizacion.Text = loInmueble.OInmDireccion.InmDirLocalizacion
        ' txtDirManzana.Text = loInmueble.OInmDireccion.InmDirManz
        'txtDirSubLote.Text = loInmueble.OInmDireccion.InmDirSubLote
        ' txtDirFase.Text = loInmueble.OInmDireccion.InmDirFase
        txtDirReferencia.Text = loInmueble.OInmDireccion.InmDirReferencia
        ' txtDirNroInterior.Text = loInmueble.OInmDireccion.InmDirNroInt
        ' chkDirActiva.Checked = loInmueble.OInmDireccion.InmDirActivo

        'Predio
        If loInmueble.OInmPredio IsNot Nothing Then
            'lsInmPredId = loInmueble.OInmPredio.InmPredId
            txtPredArea.Text = loInmueble.OInmPredio.InmPredArea.ToString()
            txtPredArancel.Text = loInmueble.OInmPredio.InmPredArancel.ToString()
            txtPredValorArancelario.Text = loInmueble.OInmPredio.InmPredValorTerreno.ToString()
            txtPredAreaTechada.Text = loInmueble.OInmPredio.InmPredAreaTechada.ToString()
            txtPredValorConstruccion.Text = loInmueble.OInmPredio.InmPredValorConst.ToString()
            txtPredValorTotalConstruccion.Text = loInmueble.OInmPredio.InmPredValorEdificacion.ToString()
            txtFechaTasacion.Text = loInmueble.OInmPredio.InmPredFecTas.ToString()
            chkPredActivo.Checked = loInmueble.OInmPredio.InmPredActivo.ToString()
            txtPredValorTotal.Text = loInmueble.OInmPredio.InmPredValorTotal.ToString()
        End If

        ''Archivos
        'dtTableArchivos.Clear()
        'pbImagenPrincipal.Image = Nothing
        'Dim loImageConver As ImageConver = New ImageConver
        For Each fArchivos As EEInmArchivos In loInmueble.ListaInmArchivos
            dtTableArchivos.LoadDataRow(New Object() { _
                   fArchivos.InmArchId, _
                   fArchivos.InmArchNombre, _
                   fArchivos.InmArchDescripcion, _
                   fArchivos.TgTipoArchId, _
                   fArchivos.InmArch, _
                   fArchivos.InmArchExt, _
                   fArchivos.InmArchPrincipal
           }, True)

            If fArchivos.InmArchPrincipal = True And fArchivos.TgTipoArchId = "04" Then
                imgPrincipal.Value = fArchivos.InmArch
            End If
        Next

        dgvArchivos.DataSource = dtTableArchivos
        dgvArchivos.DataBind()

        ''Suministros
        'dtTableSuministros.Clear()
        'For Each fSuministros As EEInmSuministros In loInmueble.ListaInmSuministros
        '    dtTableSuministros.LoadDataRow(New Object() { _
        '            fSuministros.InmSumId, _
        '            fSuministros.OPersona.PerId, _
        '            fSuministros.OPersona.PerRazonSocial, _
        '            fSuministros.TgTipoServicio.TgCodigo, _
        '            fSuministros.TgTipoServicio.TgNombre, _
        '            fSuministros.InmSumMedidor, _
        '            fSuministros.InmSumMonto, _
        '            fSuministros.TgTipoMes.TgCodigo, _
        '            fSuministros.TgTipoMes.TgNombre, _
        '            fSuministros.InmSumAño, _
        '            fSuministros.InmSumFechaVen
        '    }, True)
        'Next

        ''Divisiones
        'dtTableDivisiones.Rows.Clear()
        'If loInmueble.ListaDivisiones IsNot Nothing Then
        '    Dim liFila As Int32 = 0
        '    For Each fInmuebleDivision As EEInmueble In loInmueble.ListaDivisiones
        '        '
        '        dtTableDivisiones.LoadDataRow(New Object() { _
        '            fInmuebleDivision.InmArchDivision, _
        '            fInmuebleDivision.InmId, _
        '            fInmuebleDivision.InmFile, _
        '            fInmuebleDivision.OInmDireccion.OUbigeo.UbgNombre, _
        '            fInmuebleDivision.OInmDireccion.InmDirLocalizacion, _
        '            fInmuebleDivision.TgRubroNombre
        '    }, True)

        '    Next
        'End If
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ConstruirTableArchivos()
        


        Dim lsInmId As String = Request.QueryString("id")
        If Not String.IsNullOrEmpty(lsInmId) Then
            lsInmId = lsInmId.PadLeft(6, "0"c)
            mConsultaInmuebleXInmId(lsInmId)
        End If

    End Sub

End Class