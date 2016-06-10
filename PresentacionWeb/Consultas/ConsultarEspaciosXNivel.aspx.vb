Imports ReglasNegocio
Imports Entidades
Public Class ConsultarEspaciosXNivel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Nivel As EENivelesPEM
        Dim Colum As Integer = 10
        Dim Filas As Integer = 5
        Dim CountRow As Integer = 0
        Dim Countcol As Integer = 0
        Nivel = ReglasWebBL.Instancia.listarNivelesPEM_NivId(Request("NivelId").ToString())
        If Nivel IsNot Nothing Then
            Dim Niv As Integer
            'Dim b As SaimtControlesWeb.SaimtASPxButton = New SaimtControlesWeb.SaimtASPxButton()
            'b.Text =
            'b.ID = fniveles.NivId
            Dim espacioInicial As Integer = Nivel.NivEspInicio
            Dim script As StringBuilder = New StringBuilder()
            script.Append("<table width='100%' border='0' cellpadding='1'>")
            While espacioInicial <= Nivel.NivEspFin

                If (Countcol Mod Filas = 0 Or Nivel.NivEspInicio = espacioInicial) Then
                    script.Append("<tr>")
                    script.Append("<td>")
                    Countcol = Countcol + 1
                Else
                    script.Append("<td>")
                    Countcol = Countcol + 1
                End If

                If ReglasWebBL.Instancia.niovelespemVerificarXAcuNEspacio(espacioInicial) Then
                    script.Append("<a href='javascript:close();' name='btn" & espacioInicial & "' id='btn" & espacioInicial & "'  onclick=""window.opener.document.getElementById('txtEspacioSelec_I').value='" & espacioInicial & "';"" class='medium button blue'>" & espacioInicial & "</a>")
                Else
                    script.Append("<a name='btn" & espacioInicial & "' id='btn" & espacioInicial & "'  onclick=""window.alert('El espacio Esta ocupado');"" class='medium button red'>" & espacioInicial & "</a>")
                End If



                If (Countcol Mod Filas = 0 Or Nivel.NivEspInicio = espacioInicial) Then
                    script.Append("</td>")
                    If espacioInicial = Nivel.NivEspFin Then
                        script.Append("</tr>")
                    End If
                Else
                    script.Append("</td>")
                End If

                espacioInicial = espacioInicial + 1
            End While
            script.Append("</table>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "TEspacio", script.ToString())
            Niv = Niv + 1
        End If
    End Sub

End Class