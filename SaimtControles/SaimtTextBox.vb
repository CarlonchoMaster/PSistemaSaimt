Imports DevExpress.XtraEditors

Public Class SaimtTextBox
    Inherits TextEdit

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
