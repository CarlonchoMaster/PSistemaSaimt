﻿Imports DevExpress.Web
Public Class SaimtASPxTextBox
    Inherits ASPxTextBox
    Public Sub New()
        Me.CssFilePath = SaimtVariables.CssFilePath
        Me.CssPostfix = SaimtVariables.CssPostfix
        Me.SpriteCssFilePath = SaimtVariables.SpriteCssFilePath
    End Sub

    Public Overrides Property Text As String
        Get
            If String.IsNullOrEmpty(MyBase.Text.Trim()) Then
                Return Nothing
            Else
                Return MyBase.Text.Trim()
            End If
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
        End Set
    End Property
End Class