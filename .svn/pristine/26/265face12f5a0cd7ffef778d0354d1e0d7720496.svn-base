Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmInstitucion
    Inherits frmMantenimientos
    Dim dt_Listado As DataTable = New DataTable
    Private Sub ConstruirTableListado()
        dt_Listado.Columns.Add("tgInstitucion", GetType(String))
        dt_Listado.Columns.Add("tgInstitucionId", GetType(String))
        dt_Listado.Columns.Add("tgSiglas", GetType(String))
        dt_Listado.Columns.Add("tgId", GetType(String))
        dt_Listado.Columns.Add("tgActivo", GetType(Boolean))
    End Sub
    Protected Overrides Sub guardar()
        Try
            Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral
            Dim loClase As EEClase = New EEClase

            If TxtNombre.Text.Length = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Nombre de la Institución")
                Return
            End If

            If TxtCodInstitucion.Text.Length = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Codigo de la Institución")
                Return
            End If

            If txtSiglas.Text.Length = 0 Then
                SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese el Codigo de las Siglas de la Institución")
                Return
            End If

            loTablaGeneral.TgId = GIdRegistroActual
            loTablaGeneral.TgNombre = TxtNombre.Text
            loTablaGeneral.TgCodigo = TxtCodInstitucion.Text
            loTablaGeneral.TgAbrev = txtSiglas.Text
            loTablaGeneral.TgActivo = chkActivo.Checked
            loClase.ClsId = 82
            loTablaGeneral.OClase = loClase
            Dim Graba As Boolean = False
            If GEstadoNuevo Then
                If MantenimientosBL.Instancia.tablageneralValidaItgCodigo(82, loTablaGeneral.TgCodigo) = False Then
                    MantenimientosBL.Instancia.tablageneralinsertar(loTablaGeneral)
                    Graba = True
                End If
            Else
                If MantenimientosBL.Instancia.tablageneralValidaUtgCodigo(82, loTablaGeneral.TgId, loTablaGeneral.TgCodigo) = False Then
                    MantenimientosBL.Instancia.tablageneralUpdate(loTablaGeneral)
                    Graba = True
                End If
            End If
            If Graba = False Then
                SaimtMessageBox.mostrarAlertaInformativa("El codigo Ingresado ya se encuentra registrado, Intente Otro")
                Return
            End If
            Me.enabledGA = False
            MyBase.guardar()
            listar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub listar()
        Try
            dt_Listado.Clear()
            Dim ListaInstituciones As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(82, sRbBuscarPor.EditValue, GValorTextoBuscado)
            If ListaInstituciones IsNot Nothing Then
                For Each frow As EETablaGeneral In ListaInstituciones
                    dt_Listado.LoadDataRow(New Object() {frow.TgNombre,
                                                         frow.TgCodigo,
                                                         frow.TgAbrev,
                                                        frow.TgId,
                                                         frow.TgActivo
                                   }, True)
                Next
                gvResultadoBusqueda.BestFitColumns()
                gvResultadoBusqueda.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
                MyBase.listar()
            End If

        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            'lstInstitucion.DisplayMember = "TgNombre"
            GValorTextoBuscado = txtBuscarPor.Text
            GCriterioBuscado = 1
            dt_Listado.Clear()
            Dim ListaInstituciones As List(Of EETablaGeneral) = MantenimientosBL.Instancia.tablageneralListarXClsIdListarCriterio(82, sRbBuscarPor.EditValue, txtBuscarPor.Text)
            If ListaInstituciones IsNot Nothing Then
                For Each frow As EETablaGeneral In ListaInstituciones
                    dt_Listado.LoadDataRow(New Object() {frow.TgNombre,
                                                         frow.TgCodigo,
                                                         frow.TgAbrev,
                                                        frow.TgId,
                                                         frow.TgActivo
                                   }, True)
                Next
                gvResultadoBusqueda.BestFitColumns()
                gvResultadoBusqueda.SelectRow(0)
                dgvListado_Click(Nothing, Nothing)
            End If
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub seleccionarListado()
        Try
            If Me.gvResultadoBusqueda.DataRowCount <> 0 Then
                TxtNombre.Text = gvResultadoBusqueda.GetRowCellValue(gvResultadoBusqueda.GetSelectedRows(0), "tgInstitucion").ToString()
                GIdRegistroActual = gvResultadoBusqueda.GetRowCellValue(gvResultadoBusqueda.GetSelectedRows(0), "tgId").ToString()
                txtSiglas.Text = gvResultadoBusqueda.GetRowCellValue(gvResultadoBusqueda.GetSelectedRows(0), "tgSiglas").ToString()
                TxtCodInstitucion.Text = gvResultadoBusqueda.GetRowCellValue(gvResultadoBusqueda.GetSelectedRows(0), "tgInstitucionId").ToString()
                chkActivo.Checked = gvResultadoBusqueda.GetRowCellValue(gvResultadoBusqueda.GetSelectedRows(0), "tgActivo")
                MyBase.seleccionarListado()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try

    End Sub

    Protected Overrides Sub nuevo()
        MyBase.nuevo()
        TxtCodInstitucion.Text = MantenimientosBL.Instancia.InstitucionNewCodigo()
        TxtCodInstitucion.Properties.ReadOnly = False
        TxtCodInstitucion.Enabled = False
        TxtNombre.Focus()
    End Sub

    Private Sub frmInstitucion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True

        sRbBuscarPor.SelectedIndex = 0
        ConstruirTableListado()
        dgvResultadoBusqueda.DataSource = dt_Listado
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

    End Sub
End Class