Public Class EEOrdenCompra
    Public Property OrdId() As String
    Public Property OrdNro() As String
    Public Property OrdArtDescripcion() As String
    Public Property OrdFechaDoc() As Date?
    Public Property OrdNroCompPago() As String
    Public Property OrdDetCQuedan() As String
    Public Property OrdRefCert() As String
    Public Property OrdRefDoc() As String
    Public Property PlanCDDescripcion() As String
    Public Property PlanCHDescripcion() As String
    Public Property CerId() As String
    Public Property CerNro() As String
    Public Property CerValTotal() As Decimal?
    Public Property CerValQuedan() As Decimal?
    Public Property PartId() As String
    Public Property PartNombre() As String
    Public Property PartAnio() As String
    Public Property TgEstadoId() As String
    Public Property TgEstado() As String
    Public Property TgCompPagoId() As String
    Public Property TgCompPago() As String
    Public Property TgCuentaDebeId() As String
    Public Property TgCuentaDebe() As Decimal?
    Public Property TgCuentaHaberId() As String
    Public Property TgCuentaHaber() As Decimal?
    Public Property TgFFinancieraId() As String
    Public Property TgMetaId() As String
    Public Property TgActProyId() As String
    Public Property OrdImporte() As Decimal?
    Public Property OrdImporteIGV() As Decimal?
    Public Property OrdParIGV() As Decimal?
    Public Property OrdSubTotal() As Decimal?
    Public Property OrdTotal() As Decimal?
    Public Property OrdSaldoI() As Decimal?
    Public Property OrdSaldoF() As Decimal?
    Public Property OrdDescuento() As Decimal?
    Public Property PerProvId() As String
    Public Property PerProv() As String
    Public Property PerProvNDoc() As String
    Public Property informacionComplementaria() As String
    Public Property tipoContratacion() As String
    Public Property ObjectoContratacion() As String
    Public Property Idgeneral() As String
    Public Property Descripcion() As String
    Public Property tipoMoneda() As String
    Public Property tipocambio() As String



    Public Property OrdenCompraDet() As EEOrdenCompra.EEOrdenCompraDet
    Public Property ListaOrdenCompraDet() As List(Of EEOrdenCompra.EEOrdenCompraDet)
    Public Property ListaOrdenCompraGrupoPartidas() As List(Of EEOrdenCompra.EEOrdenCompraGrupoPartidas)
    Public Property ListaOrdenCompraAreaRef() As List(Of EEOrdenCompra.EEOrdenCompraAreaRef)
    Public Property ListaOrdenCompraDocRef() As List(Of EEOrdenCompra.EEOrdenCompraDocRef)
    Public Property Lista_OrdenCompraDetElimnados As List(Of String)

    Public Class EEOrdenCompraDet
        Public Property OArticulo() As EEArticulo
        Public Property ArtId() As String
        Public Property TgUmId() As String
        Public Property TgUm() As String
        Public Property OrdDetId() As String
        Public Property OrdDetCantidad() As Decimal
        Public Property OrdDetEncabezado() As String
        Public Property OrdDetDescripcion() As String
        Public Property OrdDetCQuedan() As Decimal
        Public Property OrdDetPrecio() As Decimal
        Public Property OrdLlevar() As Boolean
        Public Property OrdCanLlevar() As Decimal
        Public Property OrdId() As String
    End Class

    Public Class EEOrdenCompraGrupoPartidas
        Public Property ordId() As String
        Public Property cerGrupoParValImporte() As Decimal
        Public Property cerGrupoParId() As Integer
        Public Property Partida() As String
    End Class

    Public Class EEOrdenCompraAreaRef
        Public Property ordId() As String
        Public Property tgAreaId() As String
    End Class

    Public Class EEOrdenCompraDocRef
        Public Property ordId() As String
        Public Property documento() As String
        Public Property año() As String
        Public Property area() As String
    End Class
End Class

