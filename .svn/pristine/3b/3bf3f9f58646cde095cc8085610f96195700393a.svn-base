Imports DevExpress.XtraEditors

Public Class SaimtDateTimePicker
    Inherits DateEdit

    Public Overrides Property EditValue As Object
        Get
            If String.IsNullOrEmpty(MyBase.EditValue) Then
                Return Nothing
            End If
            Return Convert.ToDateTime(MyBase.EditValue)
        End Get
        Set(ByVal value As Object)
            MyBase.EditValue = value
        End Set
    End Property
End Class
