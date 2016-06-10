Imports DevExpress.Web
Public Class SaimtASPxBinaryImage
    Inherits ASPxBinaryImage
    Public Sub New()
        Me.CssFilePath = SaimtVariables.CssFilePath
        Me.CssPostfix = SaimtVariables.CssPostfix
        Me.SpriteCssFilePathInternal = SaimtVariables.SpriteCssFilePath
    End Sub
End Class
