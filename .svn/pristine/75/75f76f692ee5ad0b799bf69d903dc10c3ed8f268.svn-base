Imports Entidades
Imports ReglasNegocio
Imports SaimtControles
Public Class frmGerarquia
    Inherits frmMantenimientos
    Dim nivel As Int16 = 0
    Dim nnodo As String = String.Empty
    Dim IdPadreNodo As String = String.Empty
    Dim dtTablaJer As DataTable = New DataTable()

#Region "Construir Table"
    Private Sub ConstruirTableJerarquia()
        dtTablaJer.Columns.Add("JerId", GetType(String))
        dtTablaJer.Columns.Add("JerNombre", GetType(String))
        dtTablaJer.Columns.Add("JerPadre", GetType(String))
        dtTablaJer.Columns.Add("JerNivel", GetType(Integer))
        dtTablaJer.Columns.Add("JerDescripcion", GetType(String))
        dtTablaJer.Columns.Add("JerfechReg", GetType(DateTime))
        dtTablaJer.Columns.Add("JerIcono", GetType(String))

    End Sub
#End Region
    Private Sub btnNuevo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        If nivel = 4 Then
            SaimtMessageBox.mostrarAlertaInformativa("Solo es permitido crear hasta el 4 Nivel")
            Exit Sub
        End If

        Dim frm As New frmNuevaCarp(nivel, nnodo, IdPadreNodo, "new")
        frm.ShowDialog()
        CargarJerarquias()
    End Sub
    Sub CargarJerarquias()
        Dim ListaJerarquias As List(Of EEJerarquiaArch) = MantenimientosBL.Instancia.jerarquiaArchAll()
        If ListaJerarquias IsNot Nothing Then
            For Each frow As EEJerarquiaArch In ListaJerarquias
                dtTablaJer.LoadDataRow(New Object() {frow.JerId, _
                     frow.JerNombre, _
                     frow.JerPadre, _
                     frow.JerNivel, _
                     frow.JerDescripcion, _
                     frow.JerfechReg, _
                     frow.JerIcono
                   }, True)
            Next
            tlJerarquia.Nodes.Clear()
            For Each loprocesos As EEJerarquiaArch In ListaJerarquias
                If loprocesos.JerNivel = 0 Then
                    If tlJerarquia.Nodes(loprocesos.JerId) Is Nothing Then
                        tlJerarquia.Nodes.Add(loprocesos.JerId, loprocesos.JerNombre, loprocesos.JerIcono)
                    End If
                End If
                If loprocesos.JerNivel = 1 Then
                    If tlJerarquia.Nodes(loprocesos.JerPadre) IsNot Nothing Then
                        tlJerarquia.Nodes(loprocesos.JerPadre).Nodes.Add(loprocesos.JerId, loprocesos.JerNombre, loprocesos.JerIcono)
                    End If
                End If
                If loprocesos.JerNivel = 2 Then
                    If tlJerarquia.Nodes(SacarPadreNivel2(loprocesos.JerPadre, ListaJerarquias)).Nodes(loprocesos.JerPadre) IsNot Nothing Then
                        tlJerarquia.Nodes(SacarPadreNivel2(loprocesos.JerPadre, ListaJerarquias)).Nodes(loprocesos.JerPadre).Nodes.Add(loprocesos.JerId, loprocesos.JerNombre, loprocesos.JerIcono)
                    End If
                End If
                If loprocesos.JerNivel = 3 Then
                    If tlJerarquia.Nodes(SacarPadreNivel3(loprocesos.JerPadre, ListaJerarquias)).Nodes(SacarPadreNivel2(loprocesos.JerPadre, ListaJerarquias)).Nodes(loprocesos.JerPadre) IsNot Nothing Then
                        tlJerarquia.Nodes(SacarPadreNivel3(loprocesos.JerPadre, ListaJerarquias)).Nodes(SacarPadreNivel2(loprocesos.JerPadre, ListaJerarquias)).Nodes(loprocesos.JerPadre).Nodes.Add(loprocesos.JerId, loprocesos.JerNombre, loprocesos.JerIcono)
                    End If
                End If
                If loprocesos.JerNivel = 4 Then
                    If tlJerarquia.Nodes(SacarPadreNivel4(loprocesos.JerPadre, ListaJerarquias)).Nodes(SacarPadreNivel3(loprocesos.JerPadre, ListaJerarquias)).Nodes(SacarPadreNivel2(loprocesos.JerPadre, ListaJerarquias)).Nodes(loprocesos.JerPadre) IsNot Nothing Then
                        tlJerarquia.Nodes(SacarPadreNivel4(loprocesos.JerPadre, ListaJerarquias)).Nodes(SacarPadreNivel3(loprocesos.JerPadre, ListaJerarquias)).Nodes(SacarPadreNivel2(loprocesos.JerPadre, ListaJerarquias)).Nodes(loprocesos.JerPadre).Nodes.Add(loprocesos.JerId, loprocesos.JerNombre, loprocesos.JerIcono)
                    End If
                End If
            Next
            tlJerarquia.ExpandAll()
        End If
    End Sub
    Function SacarPadreNivel4(ByVal JerPadre As String, ByVal ListaJerarquias As List(Of EEJerarquiaArch))
        Dim Id As String = String.Empty
        Dim JerAbuelo As String = String.Empty
        For Each loprocesos As EEJerarquiaArch In ListaJerarquias
            If JerPadre = loprocesos.JerId Then
                Id = loprocesos.JerPadre
                Exit For
            End If
        Next
        For Each loprocesos As EEJerarquiaArch In ListaJerarquias
            If Id = loprocesos.JerId Then
                JerAbuelo = loprocesos.JerPadre
                Exit For
            End If
        Next
        For Each loprocesos As EEJerarquiaArch In ListaJerarquias
            If JerAbuelo = loprocesos.JerId Then
                Id = loprocesos.JerPadre
                Exit For
            End If
        Next
        Return Id
    End Function

    Function SacarPadreNivel3(ByVal JerPadre As String, ByVal ListaJerarquias As List(Of EEJerarquiaArch))
        Dim Id As String = String.Empty
        For Each loprocesos As EEJerarquiaArch In ListaJerarquias
            If JerPadre = loprocesos.JerId Then
                Id = loprocesos.JerPadre
                Exit For
            End If
        Next
        For Each loprocesos As EEJerarquiaArch In ListaJerarquias
            If Id = loprocesos.JerId Then
                Id = loprocesos.JerPadre
                Exit For
            End If
        Next
        Return Id
    End Function

    Function SacarPadreNivel2(ByVal JerPadre As String, ByVal ListaJerarquias As List(Of EEJerarquiaArch))
        Dim Id As String = String.Empty
        For Each loprocesos As EEJerarquiaArch In ListaJerarquias
            If JerPadre = loprocesos.JerId Then
                Id = loprocesos.JerPadre
                Exit For
            End If
        Next
        Return Id
    End Function


    Private Sub frmGerarquia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruirTableJerarquia()
        CargarJerarquias()
        For i = 0 To IconosArchivo.Images.Count - 1
            ImageList1.Images.Add(IconosArchivo.Images(i))
        Next
        tlJerarquia.ImageList = ImageList1
        nivel = -1
        nnodo = "RAIZ"
        IdPadreNodo = Nothing
    End Sub

    'Private Sub tlJerarquia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlJerarquia.Click
    '    If tlJerarquia.SelectedNode IsNot Nothing Then
    '        nodo = tlJerarquia.SelectedNode.Level
    '        nnodo = tlJerarquia.SelectedNode.Text
    '        IdPadreNodo = tlJerarquia.SelectedNode.Name
    '    End If

    'End Sub

    Private Sub BarLargeButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem5.ItemClick
        CargarJerarquias()
    End Sub

    Private Sub tlJerarquia_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tlJerarquia.AfterSelect
        If tlJerarquia.SelectedNode IsNot Nothing Then
            nivel = tlJerarquia.SelectedNode.Level
            nnodo = tlJerarquia.SelectedNode.Text
            IdPadreNodo = tlJerarquia.SelectedNode.Name
            'IdNodo = tlJerarquia.SelectedNode.i
        End If
    End Sub

    Private Sub BarLargeButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem3.ItemClick
        Dim frm As New frmNuevaCarp(nivel, nnodo, IdPadreNodo, "update")
        frm.ShowDialog()
        CargarJerarquias()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbtiNuevoExpediente.Click
        Dim frm As New frmExpediente("new", IdPadreNodo)
        frm.ShowDialog()
    End Sub
End Class