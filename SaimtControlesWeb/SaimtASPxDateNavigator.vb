﻿Imports DevExpress.Web.ASPxScheduler
Public Class SaimtASPxDateNavigator
    Inherits ASPxDateNavigator
    Public Sub New()
        Me.CssFilePath = SaimtVariables.CssFilePath
        Me.CssPostfix = SaimtVariables.CssPostfix
        Me.SpriteCssFilePath = SaimtVariables.SpriteCssFilePath
    End Sub
End Class
