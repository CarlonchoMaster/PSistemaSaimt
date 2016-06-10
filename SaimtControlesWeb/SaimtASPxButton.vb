Imports DevExpress.Web
Public Class SaimtASPxButton
    Inherits ASPxButton
    Public Sub New()
        Me.CssFilePath = SaimtVariables.CssFilePath
        Me.CssPostfix = SaimtVariables.CssPostfix
        Me.SpriteCssFilePath = SaimtVariables.SpriteCssFilePath
    End Sub

    Private Property _SaimtToolTip As String
    Public Property SaimtToolTip As String
        Get
            Return _SaimtToolTip
        End Get
        Set(value As String)
            _SaimtToolTip = value
            If Not String.IsNullOrEmpty(_SaimtToolTip) Then
                Dim lspCadena() As String = _SaimtToolTip.Split(";"c)
                Me.ToolTip = "<u><b>" & lspCadena(0) & "</u></b><br />" & lspCadena(1) & "."
            End If
        End Set
    End Property
End Class
