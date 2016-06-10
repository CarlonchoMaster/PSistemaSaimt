Imports DevExpress.Web.ASPxTreeList
Public Class SaimtASPxTreeList
    Inherits ASPxTreeList
    Public Sub New()
        Me.CssFilePath = SaimtVariables.CssFilePath
        Me.CssPostfix = SaimtVariables.CssPostfix
        Me.SpriteCssFilePathInternal = SaimtVariables.SpriteCssFilePath
        Me.Images.LoadingPanel.Url = "~/App_Themes/PlasticBlue/Scheduler/Loading.gif"
    End Sub
End Class
