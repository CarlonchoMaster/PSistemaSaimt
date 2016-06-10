Imports Entidades
Imports SaimtControles
Imports ReglasNegocio

Public Class frmMenuFormularios
    Dim dtMenuFormularios As DataTable = New DataTable()
    Dim ListaTemporalEliminados As List(Of String) = New List(Of String)
    Dim ListaTemporalNuevos As List(Of EEMenuFormularios) = Nothing

#Region "Construir Table"
    Private Sub ConstruirTable()
        dtMenuFormularios.Columns.Add("mfrId", GetType(Int16))
        dtMenuFormularios.Columns.Add("mfrNombre", GetType(String))
        dtMenuFormularios.Columns.Add("mfrTitulo", GetType(String))
        dtMenuFormularios.Columns.Add("mfrDescripcion", GetType(String))
    End Sub
#End Region

    Private Sub frmMenuFormularios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PuedeBuscar = True
        Me.PuedeCrear = True
        Me.PuedeEditar = True
        Me.PuedeExportar = True
        Me.PuedeImprimir = True
        ConstruirTable()
        dgvMenuFormularios.DataSource = dtMenuFormularios
    End Sub

#Region "Funciones Sobrescritas"
    Protected Overrides Sub seleccionarListado()
        Try
            If lstGrupoFormularios.SelectedItem IsNot Nothing Then
                limpiarControlesTotal(grbDatos.Controls)

                Dim loGrupoFormularios As EEGrupoFormularios = DirectCast(lstGrupoFormularios.SelectedValue, EEGrupoFormularios)
                txtGrupo.Text = loGrupoFormularios.GrfNombre
                txtGrupo.Tag = loGrupoFormularios.GrfId

                dtMenuFormularios.Rows.Clear()
                If loGrupoFormularios.ListaMenuFormularios IsNot Nothing Then
                    For Each fMenuFormularios As EEMenuFormularios In loGrupoFormularios.ListaMenuFormularios
                        dtMenuFormularios.LoadDataRow(New Object() { _
                               fMenuFormularios.MfrId, _
                               fMenuFormularios.MfrNombre, _
                               fMenuFormularios.MfrTitulo, _
                               fMenuFormularios.MfrDescripcion
                       }, True)
                    Next
                End If

                MyBase.seleccionarListado()
                Me.gvMenuFormularios.BestFitColumns()
            End If
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Buscar()
        Try
            lstGrupoFormularios.DisplayMember = "GrfNombre"
            lstGrupoFormularios.DataSource = MantenimientosBL.Instancia.grupoformulariosListarCriterio_EnMenuFomulario(1, txtBuscarPor.Text)
            MyBase.Buscar()
        Catch ex As Exception
            SaimtMessageBox.mostrarAlertaError(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub guardar()
        Try
            Dim loMenuFormularios As EEMenuFormularios = Nothing
            Dim loMenuFormulariosSA As EEMenuFormularios = New EEMenuFormularios()

            Dim loGrupoFormularios As EEGrupoFormularios = Nothing

            For Each fMenuFormularios As DataRow In dtMenuFormularios.Rows
                loMenuFormularios = New EEMenuFormularios()
                loGrupoFormularios = New EEGrupoFormularios()

                If loMenuFormulariosSA.ListaMenuFormularios Is Nothing Then
                    loMenuFormulariosSA.ListaMenuFormularios = New List(Of EEMenuFormularios)
                End If

                loGrupoFormularios.GrfId = Convert.ToInt16(txtGrupo.Tag.ToString())

                loMenuFormularios.MfrId = Convert.ToInt16(fMenuFormularios("mfrId"))
                loMenuFormularios.MfrNombre = fMenuFormularios("mfrNombre")
                loMenuFormularios.MfrTitulo = fMenuFormularios("mfrTitulo")
                loMenuFormularios.MfrDescripcion = mGVerificarNull(fMenuFormularios("MfrDescripcion"))
                loMenuFormularios.OGrupoFormularios = loGrupoFormularios

                loMenuFormulariosSA.ListaMenuFormularios.Add(loMenuFormularios)
            Next

            loMenuFormulariosSA.ListaTemporalNuevos = ListaTemporalNuevos
            loMenuFormulariosSA.ListaTemporalEliminados = ListaTemporalEliminados
            MantenimientosBL.Instancia.menuformulariosActualizar(loMenuFormulariosSA)

            Me.enabledGA = False
            MyBase.guardar()
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

    Protected Overrides Sub editar()
        MyBase.editar()
        txtGrupo.Properties.ReadOnly = True
    End Sub
#End Region

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If String.IsNullOrEmpty(txtNombre.Text) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Name")
            txtNombre.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtTitulo.Text) Then
            SaimtMessageBox.mostrarAlertaAdvertencia("Ingrese Título")
            txtTitulo.Focus()
            Exit Sub
        End If

        dtMenuFormularios.LoadDataRow(New Object() { _
            0, _
            txtNombre.Text, _
            txtTitulo.Text, _
            txtDescripcion.Text
        }, True)

        If ListaTemporalNuevos Is Nothing Then
            ListaTemporalNuevos = New List(Of EEMenuFormularios)
        End If

        Dim loMenuFormularios As EEMenuFormularios = New EEMenuFormularios()
        Dim loGrupoFormularios As EEGrupoFormularios = New EEGrupoFormularios()
        loGrupoFormularios.GrfId = Convert.ToInt16(txtGrupo.Tag.ToString())

        loMenuFormularios.MfrNombre = txtNombre.Text
        loMenuFormularios.MfrTitulo = txtTitulo.Text
        loMenuFormularios.MfrDescripcion = txtDescripcion.Text
        loMenuFormularios.OGrupoFormularios = loGrupoFormularios

        ListaTemporalNuevos.Add(loMenuFormularios)
    End Sub

    Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click
        If Me.gvMenuFormularios.DataRowCount <> 0 Then
            If Not String.IsNullOrEmpty(dtMenuFormularios.Rows(Me.gvMenuFormularios.GetSelectedRows(0))("mfrId").ToString()) Then
                ListaTemporalEliminados.Add(dtMenuFormularios.Rows(Me.gvMenuFormularios.GetSelectedRows(0))("mfrId").ToString())
            End If

            If ListaTemporalNuevos Is Nothing Then
                ListaTemporalNuevos = New List(Of EEMenuFormularios)
            End If

            If ListaTemporalNuevos.Count > 0 Then
                Dim liIndiceNuevoModificar As Int16 = 0
                Dim liFila As Int16 = -1

                For Each fMenuFormularios As DataRow In dtMenuFormularios.Rows
                    If String.IsNullOrEmpty(fMenuFormularios("mfrId")) And Me.gvMenuFormularios.FocusedRowHandle = liFila Then
                        liIndiceNuevoModificar = liIndiceNuevoModificar + 1
                    End If
                    liFila = liFila + 1
                Next
                ListaTemporalNuevos.RemoveAt(liIndiceNuevoModificar)
            End If

            dtMenuFormularios.Rows.RemoveAt(Me.gvMenuFormularios.GetSelectedRows(0))
        Else
            SaimtMessageBox.mostrarAlertaAdvertencia("No Hay Ninguna Fila Seleccionada")
        End If
    End Sub
End Class
