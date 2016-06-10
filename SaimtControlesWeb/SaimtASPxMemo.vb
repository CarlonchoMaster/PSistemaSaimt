Imports DevExpress.Web
Public Class SaimtASPxMemo
    Inherits ASPxMemo
    Public Sub New()
        Me.CssFilePath = SaimtVariables.CssFilePath
        Me.CssPostfix = SaimtVariables.CssPostfix
        Me.SpriteCssFilePath = SaimtVariables.SpriteCssFilePath
    End Sub
End Class
