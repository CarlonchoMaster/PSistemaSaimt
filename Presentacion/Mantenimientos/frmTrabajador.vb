﻿Imports SaimtControles
Imports ReglasNegocio
Imports Entidades

Public Class frmTrabajador
    Inherits frmMantenimientos

    Dim ListaTemporalNuevos As List(Of EECargoPersonal)
    Dim ListaTemporalEliminados As List(Of String)
    Dim ListaTemporalEditados As List(Of String)

    Dim dtCargos As DataTable = New DataTable()
    Dim dtTablaContacto As DataTable = New DataTable()
    Dim dtListadoTrabajador As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtCargos.Columns.Add("carPerId", GetType(String))
        dtCargos.Columns.Add("codInstitucion", GetType(String))
        dtCargos.Columns.Add("institucion", GetType(String))
        dtCargos.Columns.Add("codArea", GetType(String))
        dtCargos.Columns.Add("area", GetType(String))
        dtCargos.Columns.Add("codCargo", GetType(String))
        dtCargos.Columns.Add("cargo", GetType(String))
        dtCargos.Columns.Add("tgTipoCargoId", GetType(String))
        dtCargos.Columns.Add("tipocargo", GetType(String))
        dtCargos.Columns.Add("carPerFechaIni", GetType(DateTime))
        dtCargos.Columns.Add("carPerFechaFin", GetType(DateTime))
        dtCargos.Columns.Add("tgEstadoId", GetType(Boolean))
    End Sub
#End Region

#Region "Construir Table Contacto"
    Private Sub ConstruirTableContacto()
        dtTablaContacto.Columns.Add("Descripcion", GetType(String))
        dtTablaContacto.Columns.Add("Contacto", GetType(String))
    End Sub
#End Region

#Region "Construir Table Trabajador Listado"
    Private Sub ConstruirTableTrabajadorListado()
        dtListadoTrabajador.Columns.Add("ConTrabId", GetType(String))
        dtListadoTrabajador.Columns.Add("Persona", GetType(String))
        dtListadoTrabajador.Columns.Add("ConTrabFecInicio", GetType(Date))
        dtListadoTrabajador.Columns.Add("ConTrabFecFin", GetType(Date))
        dtListadoTrabajador.Columns.Add("Modalidad", GetType(String))
        dtListadoTrabajador.Columns.Add("Sucursal", GetType(String))
        dtListadoTrabajador.Columns.Add("Horario", GetType(String))
    End Sub
#End Region

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            txtInstitucion.Text = String.Empty
            cboArea.Properties.DataSource = Nothing
            cboCargo.Properties.DataSource = Nothing
            dtpFechaInicioCargos.EditValue = Nothing
            dtpFechaFinCargos.EditValue = Nothing
            If Me.gvListadoTrabajador.DataRowCount <> 0 Then
                Dim loContratoPersonal As EEContratoPersonal = MantenimientosBL.Instancia.contratopersonalListarXConTrabId(gvListadoTrabajador.GetRowCellValue(Me.gvListadoTrabajador.GetSelectedRows(0), "ConTrabId").ToString())
                GIndiceSeleccionado = Me.gvListadoTrabajador.GetSelectedRows(0)
                txtCodigoContrato.Text = loContratoPersonal.ConTrabId
                txtPersona.Text = loContratoPersonal.OPersona.perNombresoRazon
                txtCodigoPersona.Text = loContratoPersonal.OPersona.PerId
                txtDomicilio.Text = loContratoPersonal.OPersona.PerDireccion
                dtpFechaInicioDC.EditValue = loContratoPersonal.ConTrabFecInicio
                dtpFechaFinDC.EditValue = loContratoPersonal.ConTrabFecFin
                cboEstadoContrato.EditValue = loContratoPersonal.OTgEstadoContrato.TgCodigo
                txtDepartamento.EditValue = loContratoPersonal.OPersona.PerDepartamento
                txtProvincia.EditValue = loContratoPersonal.OPersona.PerProvincia
                txtDistrito.EditValue = loContratoPersonal.OPersona.PerDistrito
                txtDomicilio.EditValue = loContratoPersonal.OPersona.PerDireccion
                'txtHorario.Text = loContratoPersonal.OHorarioPer.HorDescripcion
                cbHorario.EditValue = loContratoPersonal.OHorarioPer.HorId

                cboNivelEstudio.EditValue = loContratoPersonal.tgNivEduId
                cboNivelRemunerativo.EditValue = loContratoPersonal.tgNivRemnId
                cboGradoOcupacional.EditValue = loContratoPersonal.tgGradoOcuId
                cboFormacionProfecional.EditValue = loContratoPersonal.tgForProfId

                'tieHoraEntrada.EditValue = loContratoPersonal.OHorarioPer.HorEntrada
                'tieHoraSalida.EditValue = loContratoPersonal.OHorarioPer.HorSalida
                'tieHoraSalidaRefrigerio.EditValue = loContratoPersonal.OHorarioPer.HorRecesoIni
                'tieHoraEntradaRefrigerio.EditValue = loContratoPersonal.OHorarioPer.HorRecesoFin
                cboTipoContrato.EditValue = loContratoPersonal.OTgTipoContrato.TgCodigo.ToString.TrimEnd
                spnNroSueldos.EditValue = loContratoPersonal.ConTrabNroSueldos
                txtRemuneracion.Text = loContratoPersonal.ConTrabMonto
                txtRefResolucion.Text = loContratoPersonal.ConTrabResolucion
                dtpFechaResolucion.EditValue = loContratoPersonal.ConTrabFecRes
                txtRefOficio.Text = loContratoPersonal.ConTrabOficio
                dtpFechaOficio.EditValue = loContratoPersonal.ConTrabFecOficio
                txtRefRequerimiento.Text = loContratoPersonal.ConTrabRequeriemiento
                dtpFechaRequerimiento.EditValue = loContratoPersonal.ConTrabFecReq
                txtRefProveido.Text = loContratoPersonal.ConTrabProveido
                dtpFechaProveido.EditValue = loContratoPersonal.ConTrabFecProv
                txtRefInforme.Text = loContratoPersonal.ConTrabInforme
                dtpFechaInforme.EditValue = loContratoPersonal.ConTrabFecInf
                cboBanco.EditValue = loContratoPersonal.TgBancoId
                txtNroCuenta.Text = loContratoPersonal.ConTrabNroCuenta
                cboEstadoCivil.EditValue = loContratoPersonal.TgEstadoCivilId.ToString()
                If loContratoPersonal.CodSucursal.HasValue Then
                    cboSucursal.EditValue = loContratoPersonal.CodSucursal
                End If
                If loContratoPersonal.ConTrabNroHijos.HasValue Then
                    txtCantidadHijos.Text = loContratoPersonal.ConTrabNroHijos
                End If
                cboSeguroSocial.EditValue = loContratoPersonal.TgSeguroSocId
                txtNroSeguroSocial.Text = loContratoPersonal.NroSeguroSoc
                txtRUC.Text = loContratoPersonal.ConTrabRuc
                dtCargos.Clear()
                For Each fCargoPersonal As EECargoPersonal In loContratoPersonal.ListaCargoPersonal
                    dtCargos.LoadDataRow(New Object() { _
                            fCargoPersonal.CarPerId, _
                            fCargoPersonal.CodInstitucion, _
                            fCargoPersonal.Institucion, _
                            fCargoPersonal.CodArea, _
                            fCargoPersonal.Area, _
                            fCargoPersonal.CodCargo, _
                            fCargoPersonal.Cargo, _
                            fCargoPersonal.OTgTipoCargo.TgCodigo, _
                            fCargoPersonal.OTgTipoCargo.TgNombre, _
                            fCargoPersonal.CarPerFechaIni, _
                            fCargoPersonal.CarPerFechaFin, _
                            fCargoPersonal.TgEstadoId
                    }, True)
                Next
                gvCargos.BestFitColumns()

                dtTablaContacto.Rows.Clear()
                For Each fContacto As EEPersona.EEContacto In loContratoPersonal.OPersona.ListaContacto
                    dtTablaContacto.LoadDataRow(New Object() {fContacto.ContDescripcion, _
                         fContacto.OTablaGeneral.TgCodigo
                       }, True)
                Next
                gvDatosAdicionales.BestFitColumns()

                GIdRegistroActual = loContratoPersonal.ConTrabId
            End If
            MyBase.seleccionarListado()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            dtListadoTrabajador.Rows.Clear()
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = cboCriterios.SelectedIndex
            Dim ListaContratoPersonal As List(Of EEContratoPersonal) = MantenimientosBL.Instancia.contratopersonalListarCriterio(cboCriterios.SelectedIndex, txtBuscarPor.Text)
            If ListaContratoPersonal IsNot Nothing Then
                For Each fContratoPersonal As EEContratoPersonal In ListaContratoPersonal
                    dtListadoTrabajador.LoadDataRow(New Object() {fContratoPersonal.ConTrabId, _
                         fContratoPersonal.Trabajador, _
                         fContratoPersonal.ConTrabFecInicio, _
                         fContratoPersonal.ConTrabFecFin, _
                         fContratoPersonal.OTgTipoContrato.TgNombre, _
                         fContratoPersonal.Sucursal, _
                         fContratoPersonal.HorarioNombre
                       }, True)
                Next
                gvListadoTrabajador.BestFitColumns()
                gvListadoTrabajador.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub listar()
        Try
            dtListadoTrabajador.Rows.Clear()
            For Each fContratoPersonal As EEContratoPersonal In MantenimientosBL.Instancia.contratopersonalListarCriterio(GCriterioBuscado, GValorTextoBuscado)
                dtListadoTrabajador.LoadDataRow(New Object() {fContratoPersonal.ConTrabId, _
                     fContratoPersonal.Trabajador, _
                     fContratoPersonal.ConTrabFecInicio, _
                     fContratoPersonal.ConTrabFecFin, _
                     fContratoPersonal.OTgTipoContrato.TgNombre, _
                     fContratoPersonal.Sucursal, _
                     fContratoPersonal.HorarioNombre
                   }, True)
            Next
            MyBase.listar()
            Me.gvListadoTrabajador.FocusedRowHandle = GIndiceSeleccionado
            dgvListado_Click(Nothing, Nothing)
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            If txtPersona.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una Persona")
                btnConsultarPersona.Focus()
                Exit Sub
            End If

            If cbHorario.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione un Horario")
                '   btnConsultarHorario.Focus()
                Exit Sub
            End If

            If cboTipoContrato.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione el tipo contrato")
                '   btnConsultarHorario.Focus()
                Exit Sub
            End If

            If dtpFechaInicioDC.EditValue Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione la Fecha Inicio de Contrato")
                '   btnConsultarHorario.Focus()
                Exit Sub
            End If

            'If dtpFechaFinDC.EditValue Is Nothing Then
            '    SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione la Fecha Fin de Contrato")
            '    '   btnConsultarHorario.Focus()
            '    Exit Sub
            'End If
            Dim loContratoPersonal As EEContratoPersonal = New EEContratoPersonal()
            Dim loPersona As EEPersona = New EEPersona()
            Dim loEstadoContrato As EETablaGeneral = New EETablaGeneral()
            Dim loTipoContrato As EETablaGeneral = New EETablaGeneral()
            Dim loHorarioPer As EEHorarioPer = New EEHorarioPer()

            loPersona.PerId = txtCodigoPersona.Text
            loContratoPersonal.ConTrabId = GIdRegistroActual
            loContratoPersonal.OPersona = loPersona
            'DATOS PARA EL CONTRATO
            loContratoPersonal.ConTrabFecInicio = dtpFechaInicioDC.EditValue
            loContratoPersonal.ConTrabFecFin = dtpFechaFinDC.EditValue
            loEstadoContrato.TgCodigo = cboEstadoContrato.EditValue
            loContratoPersonal.OTgEstadoContrato = loEstadoContrato
            loHorarioPer.HorId = cbHorario.EditValue
            loContratoPersonal.OHorarioPer = loHorarioPer
            loTipoContrato.TgCodigo = cboTipoContrato.EditValue
            loContratoPersonal.OTgTipoContrato = loTipoContrato
            loContratoPersonal.ConTrabNroSueldos = Convert.ToInt32(spnNroSueldos.EditValue)
            loContratoPersonal.ConTrabMonto = txtRemuneracion.Text
            loContratoPersonal.ConTrabResolucion = txtRefResolucion.Text
            loContratoPersonal.ConTrabFecRes = dtpFechaResolucion.EditValue
            loContratoPersonal.ConTrabOficio = txtRefOficio.Text
            loContratoPersonal.ConTrabFecOficio = dtpFechaOficio.EditValue
            loContratoPersonal.ConTrabFecReq = dtpFechaRequerimiento.EditValue
            loContratoPersonal.ConTrabRequeriemiento = txtRefRequerimiento.Text
            loContratoPersonal.ConTrabProveido = txtRefProveido.Text
            loContratoPersonal.ConTrabFecProv = dtpFechaProveido.EditValue
            loContratoPersonal.ConTrabInforme = txtRefInforme.Text
            loContratoPersonal.ConTrabFecInf = dtpFechaInforme.EditValue
            loContratoPersonal.TgBancoId = cboBanco.EditValue
            loContratoPersonal.ConTrabNroCuenta = txtNroCuenta.Text
            loContratoPersonal.TgEstadoCivilId = CInt(cboEstadoCivil.EditValue)
            loContratoPersonal.CodSucursal = cboSucursal.EditValue
            loContratoPersonal.ConTrabNroHijos = txtCantidadHijos.Text
            loContratoPersonal.TgSeguroSocId = cboSeguroSocial.EditValue
            loContratoPersonal.NroSeguroSoc = txtNroSeguroSocial.Text
            loContratoPersonal.ConTrabRuc = txtRUC.Text

            loContratoPersonal.tgNivEduId = cboNivelEstudio.EditValue
            loContratoPersonal.tgNivRemnId = cboNivelRemunerativo.EditValue
            loContratoPersonal.tgGradoOcuId = cboGradoOcupacional.EditValue
            loContratoPersonal.tgForProfId = cboFormacionProfecional.EditValue

            For Each fTablaCargoPersonal As DataRow In dtCargos.Rows
                Dim loCargoPersonal As EECargoPersonal = New EECargoPersonal()
                Dim loTipoCargo As EETablaGeneral = New EETablaGeneral()
                loTipoCargo.TgCodigo = fTablaCargoPersonal("tgTipoCargoId")
                loCargoPersonal.CarPerId = fTablaCargoPersonal("codInstitucion") & fTablaCargoPersonal("codArea") & fTablaCargoPersonal("codCargo")
                loCargoPersonal.OTgTipoCargo = loTipoCargo
                loCargoPersonal.CarPerFechaIni = fTablaCargoPersonal("carPerFechaIni")
                loCargoPersonal.CarPerFechaFin = IIf(IsDBNull(fTablaCargoPersonal("carPerFechaFin")), Nothing, fTablaCargoPersonal("carPerFechaFin"))
                loCargoPersonal.TgEstadoId = fTablaCargoPersonal("tgEstadoId")
                loContratoPersonal.ListaCargoPersonal.Add(loCargoPersonal)
            Next

            If GEstadoNuevo Then
                MantenimientosBL.Instancia.contratopersonalGuardar(loContratoPersonal)
            Else
                loContratoPersonal.ListaTemporalNuevos = ListaTemporalNuevos
                loContratoPersonal.ListaTemporalEliminados = ListaTemporalEliminados
                loContratoPersonal.ListaTemporalEditados = ListaTemporalEditados
                MantenimientosBL.Instancia.contratopersonalActualizar(loContratoPersonal)

                ListaTemporalEliminados.Clear()
                ListaTemporalNuevos.Clear()
            End If
            Me.enabledGA = False
            MyBase.guardar()
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub eliminar()
        Try
            MyBase.eliminar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        'hodControlesTotal(grbDatosTrabajador.Controls, False)
        btnConsultarPersona.Enabled = True
        CargarIntitucion()
        'txtInstitucion.Properties.Enabled = True
        'cbhorario.Properties.ReadOnly = True
        'tieHoraEntrada.Properties.ReadOnly = True
        'tieHoraSalida.Properties.ReadOnly = True
        'tieHoraSalidaRefrigerio.Properties.ReadOnly = True
        'tieHoraEntradaRefrigerio.Properties.ReadOnly = True
        txtInstitucion.Properties.ReadOnly = True
        txtCodigoPersona.Properties.ReadOnly = True
        txtPersona.Properties.ReadOnly = True
        txtDomicilio.Properties.ReadOnly = True
        txtDepartamento.Properties.ReadOnly = True
        txtDistrito.Properties.ReadOnly = True
        txtProvincia.Properties.ReadOnly = True
        txtCodigoContrato.Properties.ReadOnly = True
        cboEstadoContrato.ItemIndex = 0
        dtCargos.Clear()
    End Sub
    Sub CargarIntitucion()
        txtInstitucion.Text = "SERVICIO DE ADMINISTRACION DE INMUEBLES MUNICIPALES"
        txtInstitucion.Tag = "0001"
        If mGVerificarNull(txtInstitucion.Tag) IsNot Nothing Then
            cboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboArea.Properties.DisplayMember = "TgNombre"
            cboArea.Properties.ValueMember = "TgCodigo"
            cboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucion.Tag)
            cboArea.ItemIndex = 0

            cboCargo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboCargo.Properties.DisplayMember = "TgNombre"
            cboCargo.Properties.ValueMember = "TgCodigo"
            cboCargo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(84, cboArea.EditValue & txtInstitucion.Tag)
            cboCargo.ItemIndex = 0
        Else
            cboArea.Properties.DataSource = Nothing
        End If
    End Sub
    Protected Overrides Sub editar()
        MyBase.editar()
        'hodControlesTotal(grbDatosTrabajador.Controls, False)
        btnConsultarPersona.Enabled = True
        CargarIntitucion()
        '  cbhorario.Properties.ReadOnly = True
        'tieHoraEntrada.Properties.ReadOnly = True
        'tieHoraSalida.Properties.ReadOnly = True
        'tieHoraSalidaRefrigerio.Properties.ReadOnly = True
        'tieHoraEntradaRefrigerio.Properties.ReadOnly = True
        txtInstitucion.Properties.ReadOnly = True
        btnConsultarPersona.Enabled = False
    End Sub
#End Region

    Private Sub frmTrabajador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeEditar = True
        Me.PuedeCrear = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        ConstruirTable()
        ConstruirTableContacto()
        ConstruirTableTrabajadorListado()

        dgvCargos.DataSource = dtCargos
        dgvDatosAdicionales.DataSource = dtTablaContacto
        dgvListado.DataSource = dtListadoTrabajador

        If ListaTemporalNuevos Is Nothing Then
            ListaTemporalNuevos = New List(Of EECargoPersonal)
        End If

        If ListaTemporalEditados Is Nothing Then
            ListaTemporalEditados = New List(Of String)
        End If

        If ListaTemporalEliminados Is Nothing Then
            ListaTemporalEliminados = New List(Of String)
        End If

        cboEstadoContrato.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoContrato.Properties.DisplayMember = "TgNombre"
        cboEstadoContrato.Properties.ValueMember = "TgCodigo"
        cboEstadoContrato.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(17)
        cboEstadoContrato.ItemIndex = 0

        cboTipoContrato.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoContrato.Properties.DisplayMember = "TgNombre"
        cboTipoContrato.Properties.ValueMember = "TgCodigo"
        cboTipoContrato.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(95)
        cboTipoContrato.ItemIndex = 0

        cboTipoCargo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboTipoCargo.Properties.DisplayMember = "TgNombre"
        cboTipoCargo.Properties.ValueMember = "TgCodigo"
        cboTipoCargo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(94)
        cboTipoCargo.ItemIndex = 0

        cbHorario.mColumnas(SaimtComboBoxLookUp.Entidades.Horarios)
        cbHorario.Properties.DisplayMember = "HorDescripcion"
        cbHorario.Properties.ValueMember = "HorId"
        cbHorario.Properties.DataSource = MantenimientosBL.Instancia.horarioperListarAllHorario()
        cbHorario.ItemIndex = 0

        cboSucursal.mColumnas(SaimtComboBoxLookUp.Entidades.Sucursales)
        cboSucursal.Properties.DisplayMember = "Sucursal"
        cboSucursal.Properties.ValueMember = "CodSucursal"
        cboSucursal.Properties.DataSource = MantenimientosBL.Instancia.sucursalesListarALL()
        cboSucursal.ItemIndex = 0

        cboEstadoCivil.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboEstadoCivil.Properties.DisplayMember = "TgNombre"
        cboEstadoCivil.Properties.ValueMember = "TgCodigo"
        cboEstadoCivil.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(120)
        cboEstadoCivil.ItemIndex = 0

        cboBanco.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboBanco.Properties.DisplayMember = "TgNombre"
        cboBanco.Properties.ValueMember = "TgCodigo"
        cboBanco.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(121)
        cboBanco.ItemIndex = 0

        cboSeguroSocial.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboSeguroSocial.Properties.DisplayMember = "TgNombre"
        cboSeguroSocial.Properties.ValueMember = "TgCodigo"
        cboSeguroSocial.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(122)
        cboSeguroSocial.ItemIndex = 0



        cboNivelEstudio.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboNivelEstudio.Properties.DisplayMember = "TgNombre"
        cboNivelEstudio.Properties.ValueMember = "TgCodigo"
        cboNivelEstudio.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(141)
        cboNivelEstudio.ItemIndex = 0

        cboFormacionProfecional.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboFormacionProfecional.Properties.DisplayMember = "TgNombre"
        cboFormacionProfecional.Properties.ValueMember = "TgCodigo"
        cboFormacionProfecional.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(140)
        cboFormacionProfecional.ItemIndex = 0

        cboGradoOcupacional.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboGradoOcupacional.Properties.DisplayMember = "TgNombre"
        cboGradoOcupacional.Properties.ValueMember = "TgCodigo"
        cboGradoOcupacional.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(139)
        cboGradoOcupacional.ItemIndex = 0

        cboNivelRemunerativo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboNivelRemunerativo.Properties.DisplayMember = "TgNombre"
        cboNivelRemunerativo.Properties.ValueMember = "TgCodigo"
        cboNivelRemunerativo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(138)
        cboNivelRemunerativo.ItemIndex = 0

        cboAFP.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboAFP.Properties.DisplayMember = "TgNombre"
        cboAFP.Properties.ValueMember = "TgCodigo"
        cboAFP.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(143)
        cboAFP.ItemIndex = 0
        mAgregarComboContacto()

        cboBuscarPor.Properties.ReadOnly = True
    End Sub

#Region "Agregar Combo A Grilla"
    Private Sub mAgregarComboContacto()
        Dim RepositorioItemsContacto As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim dtComboContacto As DataTable = New DataTable
        dtComboContacto.Columns.Add("TgNombre", GetType(String))
        dtComboContacto.Columns.Add("TgCodigo", GetType(String))

        dtComboContacto.Columns("TgNombre").Caption = "Nombre"
        dtComboContacto.Columns("TgCodigo").Caption = "Codigo"
        dtComboContacto.Columns("TgCodigo").ColumnMapping = MappingType.Hidden

        For Each fTg As EETablaGeneral In MantenimientosBL.Instancia.tablageneralListarXClsId(15)
            dtComboContacto.Rows.Add(fTg.TgNombre, fTg.TgCodigo)
        Next

        With RepositorioItemsContacto
            .DisplayMember = "TgNombre"
            .ValueMember = "TgCodigo"
            .DataSource = dtComboContacto
            .NullText = "<<Seleccione>>"
        End With

        colContacto.ColumnEdit = RepositorioItemsContacto
        RepositorioItemsContacto.BestFit()
    End Sub
#End Region

    Private Sub btnConsultarPersona_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultarPersona.Click
        Using fmConsultaPersona As frmConsultaPersonaGeneral = New frmConsultaPersonaGeneral(1)
            If fmConsultaPersona.ShowDialog() = DialogResult.OK Then
                If fmConsultaPersona.perNdoc = String.Empty Then
                    SaimtMessageBox.mostrarAlertaInformativa("La Persona no posee documento de Identidad")
                    Return
                End If
                txtPersona.Text = fmConsultaPersona.PerNombre
                txtDomicilio.Text = fmConsultaPersona.PerDireccion
                txtCodigoPersona.Text = fmConsultaPersona.PerId
                txtDepartamento.Text = fmConsultaPersona.perDepartamento
                txtDistrito.Text = fmConsultaPersona.perDistrito
                txtProvincia.Text = fmConsultaPersona.perProvincia

            End If
        End Using
    End Sub

    'Private Sub btnConsultarHorario_Click(sender As System.Object, e As System.EventArgs)
    '    Using fmConsultaHorarioPer As frmConsultaHorarioPer = New frmConsultaHorarioPer()
    '        If fmConsultaHorarioPer.ShowDialog() = DialogResult.OK Then
    '            txtHorario.Text = fmConsultaHorarioPer.HorDescripcion
    '            txtHorario.Tag = fmConsultaHorarioPer.HorId
    '            tieHoraEntrada.EditValue = fmConsultaHorarioPer.HorEntrada
    '            tieHoraSalida.EditValue = fmConsultaHorarioPer.HorSalida
    '            tieHoraSalidaRefrigerio.EditValue = fmConsultaHorarioPer.HorRecesoIni
    '            tieHoraEntradaRefrigerio.EditValue = fmConsultaHorarioPer.HorRecesoFin
    '        End If
    '    End Using
    'End Sub

    'Private Sub btnConsultarInstitucion_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultarInstitucion.Click
    '    Using fmConsultaTablaGeneral As frmConsultaTablaGeneral = New frmConsultaTablaGeneral(82)
    '        If fmConsultaTablaGeneral.ShowDialog() = DialogResult.OK Then
    '            txtInstitucion.Text = fmConsultaTablaGeneral.TgNombre
    '            txtInstitucion.Tag = fmConsultaTablaGeneral.TgCodigo
    '        End If
    '    End Using

    '    If mGVerificarNull(txtInstitucion.Tag) IsNot Nothing Then
    '        cboArea.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
    '        cboArea.Properties.DisplayMember = "TgNombre"
    '        cboArea.Properties.ValueMember = "TgCodigo"
    '        cboArea.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(83, txtInstitucion.Tag)
    '        cboArea.ItemIndex = 0
    '    Else
    '        cboArea.Properties.DataSource = Nothing
    '    End If
    'End Sub

    Private Sub cboArea_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboArea.EditValueChanged
        cboCargo.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
        cboCargo.Properties.DisplayMember = "TgNombre"
        cboCargo.Properties.ValueMember = "TgCodigo"
        cboCargo.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListar_XClsId_XTgExtra(84, cboArea.EditValue & txtInstitucion.Tag)
        cboCargo.ItemIndex = 0
    End Sub

    Private Sub btnAgregarCargo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarCargo.Click
        Try
            If txtInstitucion.Text Is Nothing Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Seleccione una Institución")
                Exit Sub
            End If

            For Each fRowCargos As DataRow In dtCargos.Rows
                If fRowCargos("tgEstadoId") = True Then
                    fRowCargos("tgEstadoId") = False

                    Dim loCargoPersonal As EECargoPersonal = New EECargoPersonal()
                    ListaTemporalEditados.Add(fRowCargos("carPerId").ToString())
                End If
            Next

            dtCargos.LoadDataRow(New Object() { _
                    Nothing, _
                    txtInstitucion.Tag, _
                    txtInstitucion.Text, _
                    cboArea.EditValue, _
                    cboArea.Text, _
                    cboCargo.EditValue, _
                    cboCargo.Text, _
                    cboTipoCargo.EditValue, _
                    cboTipoCargo.Text, _
                    dtpFechaInicioCargos.EditValue, _
                    dtpFechaFinCargos.EditValue, _
                    chkCargoActivo.Checked
            }, True)

            gvCargos.BestFitColumns()

            If GEstadoNuevo = False Then

                If ListaTemporalNuevos.Count > 1 Then
                    For fIndice As Integer = 0 To ListaTemporalNuevos.Count Step 1
                        ListaTemporalNuevos(fIndice).TgEstadoId = False
                    Next
                End If

                Dim loCargos As EECargoPersonal = New EECargoPersonal()
                Dim loTipoCargo As EETablaGeneral = New EETablaGeneral()
                Dim loContratoPersonal As EEContratoPersonal = New EEContratoPersonal()

                loTipoCargo.TgCodigo = cboTipoCargo.EditValue
                loContratoPersonal.ConTrabId = txtCodigoContrato.Text

                loCargos.CarPerId = txtInstitucion.Tag & cboArea.EditValue & cboCargo.EditValue
                loCargos.OContratoPersonal = loContratoPersonal
                loCargos.OTgTipoCargo = loTipoCargo
                loCargos.CarPerFechaIni = dtpFechaInicioCargos.EditValue
                loCargos.CarPerFechaFin = dtpFechaFinCargos.EditValue
                loCargos.TgEstadoId = chkCargoActivo.Checked

                ListaTemporalNuevos.Add(loCargos)
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Private Sub btnQuitarCargo_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarCargo.Click
        If Me.gvCargos.DataRowCount <> 0 Then
            If GEstadoNuevo = False Then
                If Not String.IsNullOrEmpty(dtCargos.Rows(Me.gvCargos.GetSelectedRows(0))("carPerId").ToString()) Then
                    ListaTemporalEliminados.Add(dtCargos.Rows(Me.gvCargos.GetSelectedRows(0))("carPerId").ToString())
                End If
            End If

            If ListaTemporalNuevos.Count > 0 Then
                Dim liIndiceNuevoModificar As Int16 = 0
                Dim liFila As Int16 = -1

                For Each fTablaCargoPersonal As DataRow In dtCargos.Rows
                    If String.IsNullOrEmpty(fTablaCargoPersonal("carPerId")) And Me.gvCargos.FocusedRowHandle = liFila Then
                        liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                    End If

                    liFila = liFila + 1
                Next

                ListaTemporalNuevos.RemoveAt(liIndiceNuevoModificar)
            End If

            dtCargos.Rows.RemoveAt(Me.gvCargos.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub btnDesactivarCargo_Click(sender As System.Object, e As System.EventArgs) Handles btnDesactivarCargo.Click
        If Me.gvCargos.DataRowCount <> 0 Then
            If dtCargos.Rows(Me.gvCargos.GetSelectedRows(0))("tgEstadoId") = True Then
                dtCargos.Rows(Me.gvCargos.GetSelectedRows(0))("tgEstadoId") = False

                Dim loCargoPersonal As EECargoPersonal = New EECargoPersonal()
                ListaTemporalEditados.Add(dtCargos.Rows(Me.gvCargos.GetSelectedRows(0))("carPerId").ToString())
            End If
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub

    Private Sub gvListadoTrabajador_CustomRowCellEditForEditing(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvListadoTrabajador.CustomRowCellEditForEditing
        seleccionarListado()
    End Sub

    Private Sub cboCriterios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCriterios.SelectedIndexChanged
        cboBuscarPor.Properties.ReadOnly = False
        GValorTextoBuscado = Nothing

        If cboCriterios.SelectedIndex = 3 Then
            cboBuscarPor.mColumnas(SaimtComboBoxLookUp.Entidades.Sucursales)
            cboBuscarPor.Properties.DisplayMember = "Sucursal"
            cboBuscarPor.Properties.ValueMember = "CodSucursal"
            cboBuscarPor.Properties.DataSource = MantenimientosBL.Instancia.sucursalesListarALL()
            cboBuscarPor.ItemIndex = 0
        ElseIf cboCriterios.SelectedIndex = 4 Then
            cboBuscarPor.mColumnas(SaimtComboBoxLookUp.Entidades.TablaGeneral)
            cboBuscarPor.Properties.DisplayMember = "TgNombre"
            cboBuscarPor.Properties.ValueMember = "TgCodigo"
            cboBuscarPor.Properties.DataSource = MantenimientosBL.Instancia.tablageneralListarXClsId(95)
            cboBuscarPor.ItemIndex = 0
        ElseIf cboCriterios.SelectedIndex = 5 Then
            cboBuscarPor.mColumnas(SaimtComboBoxLookUp.Entidades.HorariosAsistencia)
            cboBuscarPor.Properties.DisplayMember = "Nombre"
            cboBuscarPor.Properties.ValueMember = "CodHorario"
            cboBuscarPor.Properties.DataSource = MantenimientosBL.Instancia.horariosListarALL()
            cboBuscarPor.ItemIndex = 0
        End If

        If cboCriterios.SelectedIndex > 2 Then
            txtBuscarPor.Properties.ReadOnly = True
            GCriterioBuscado = cboCriterios.SelectedIndex
            GValorTextoBuscado = cboBuscarPor.EditValue
            listar()
        Else
            cboBuscarPor.Properties.ReadOnly = True
            cboBuscarPor.Properties.DataSource = Nothing
            cboBuscarPor.ItemIndex = -1

            txtBuscarPor.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub cboBuscarPor_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboBuscarPor.EditValueChanged
        If GValorTextoBuscado IsNot Nothing Then
            GCriterioBuscado = cboCriterios.SelectedIndex
            GValorTextoBuscado = cboBuscarPor.EditValue
            listar()
        End If
    End Sub

    Private Sub cboAFP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAFP.EditValueChanged
        Try
            Dim ListaComision As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(144, , cboAFP.EditValue)

            txtAporteObligatorioAFP.EditValue = ListaComision.Item(0).TgExtra
            txtComisionAFP.EditValue = ListaComision.Item(1).TgExtra
            txtPrimaSegAFP.EditValue = ListaComision.Item(2).TgExtra

        Catch ex As Exception

        End Try


    End Sub
End Class