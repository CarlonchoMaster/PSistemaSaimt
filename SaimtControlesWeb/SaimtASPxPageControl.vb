Imports DevExpress.Web
Public Class SaimtASPxPageControl
    Inherits ASPxPageControl
    Public Sub New()
        Me.CssFilePath = SaimtVariables.CssFilePath
        Me.CssPostfix = SaimtVariables.CssPostfix
        Me.SpriteCssFilePath = SaimtVariables.SpriteCssFilePath
    End Sub
End Class
