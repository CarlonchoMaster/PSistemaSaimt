
Public Class EETipoCambio
    Inherits EEComun

    Public Property TipCamId() As Int32
    Public Property TipCamFecha() As DateTime?
    Public Property TgMonedaId() As String
    Public Property TipCamCompra() As Decimal
    Public Property TipCamVenta() As Decimal

#Region "Propiedades ReadOnly"
    Public ReadOnly Property TipCamMoneda() As String
        Get
            If String.IsNullOrEmpty(TipCamCompra) Then
                Return ""
            End If
            Return "C = " + TipCamCompra.ToString + " - V = " + TipCamVenta.ToString
        End Get
    End Property
#End Region
End Class
