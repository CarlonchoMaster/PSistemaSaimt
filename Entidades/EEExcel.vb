Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Public Class EEExcel
    Inherits EEComun

    Private Shared ReadOnly _instancia As Excel.Application = CreateObject("Excel.Application")
    Public Shared ReadOnly Property Instancia() As Excel.Application
        Get
            Return _instancia
        End Get
    End Property

    Private Sub New()

    End Sub

End Class
