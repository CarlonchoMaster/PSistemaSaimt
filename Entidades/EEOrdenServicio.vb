
Public Class EEOrdenServicio
	
	Public Property OrdId() As String
	Public Property OrdNro() As String
    Public Property OrdFechaDoc() As Date?
    Public Property Item() As Integer
    Public Property OrdDia() As String
    Public Property OrdTipoDoc() As String
    Public Property OrdNroDoc() As String
    Public Property OrdNroCompPago() As String
    Public Property OrdRefCert() As String
    Public Property OrdRefDoc() As String
    Public Property TgEstadoId() As String
    Public Property TgEstado() As String
    Public Property TgCompPagoId() As String
    Public Property TgCompPago() As String
    Public Property TgCuentaDebeId() As String
    Public Property TgPlanCDId() As String
    Public Property TgPlanCHId() As String
    Public Property TgCuentaDebe() As Decimal?
    Public Property TgFFinancieraId() As String
    Public Property TgMetaId() As String
    Public Property TgActProyId() As String
    Public Property TgCuentaHaberId() As String
    Public Property TgCuentaHaber() As Decimal?
    Public Property PerProvId() As String
    Public Property PerProv() As String
    Public Property PerProvNDoc() As String
    Public Property PlanCHDescripcion() As String
    Public Property PlanCDDescripcion() As String
    Public Property PartId() As String
    Public Property CerId() As String
    Public Property CerCompId() As String
    Public Property CerNro() As String
    Public Property CerCompNro() As String
    Public Property CerValTotal() As Decimal?
    Public Property CerCompValTotal() As Decimal?
    Public Property CerValQuedan() As Decimal?
    Public Property CerCompValQuedan() As Decimal?
    Public Property CerValUtilizado() As Decimal?
    Public Property CerCompValUtilizado() As Decimal?
    Public Property CerValdevuelto() As Decimal?
    Public Property CerCompValdevuelto() As Decimal?
    Public Property PartAnio() As String
    Public Property PartNombre() As String
    Public Property OrdImporte() As Decimal?
    Public Property OrdImporteIGV() As Decimal?
    Public Property ordRta4taTotal() As Decimal?
    Public Property OrdAjusteTotal() As Decimal?
    Public Property OrdSubTotal() As Decimal?
    Public Property OrdTotal() As Decimal?
    Public Property OrdNetoPagado() As Decimal?
    Public Property OrdParIGV() As Decimal?
    Public Property OrdSaldoI() As Decimal?
    Public Property OrdSaldoF() As Decimal?

    Public Property OrdenServicioDet() As EEOrdenServicio.EEOrdenServicioDet
    Public Property ListaOrdenServicioDet() As List(Of EEOrdenServicio.EEOrdenServicioDet)
    Public Property ListaOrdenServicioGrupoPartidas() As List(Of EEOrdenServicio.EEOrdenServicioGrupoPartidas)
    Public Property ListaOrdenServicioAreaRef() As List(Of EEOrdenServicio.EEOrdenServicioAreaRef)
    Public Property ListaOrdenServicioDocRef() As List(Of EEOrdenServicio.EEOrdenServicioDocRef)
    Public Property Lista_OrdenServicioDetElimnados As List(Of String)

    Public Class EEOrdenServicioGrupoPartidas
        Public Property ordId() As String
        Public Property cerGrupoParValImporte() As Decimal
        Public Property cerGrupoParId() As Integer
        Public Property Partida() As String
        Public Property CerId() As String
        Public Property Certificacion() As String
    End Class

    Public Class EEOrdenServicioDet
        Public Property OServicio() As EEServicio
        Public Property OrdDetId() As String
        Public Property OrdId() As String
        Public Property TgCatServId() As String
        Public Property TgCatServ() As String
        Public Property OrdDetDescripcion() As String
        Public Property OrdDetObservacion() As String
        Public Property OrdDetIgv() As Decimal?
        Public Property OrdDetRta4ta() As Decimal?
        Public Property tgTipoAjusteId() As String
        Public Property tgTipoAjuste() As String
        Public Property OrdDetAjuste() As String
        Public Property OrdDetPrecio() As Decimal?
        Public Property OrdDetImporte() As Decimal?
        Public Property OrdDetMontoCertUtl1() As Decimal?
        Public Property OrdDetMontoCertUtl2() As Decimal?

    End Class

    Public Class EEOrdenServicioAreaRef
        Public Property ordId() As String
        Public Property tgAreaId() As String
    End Class

    Public Class EEOrdenServicioDocRef
        Public Property ordId() As String
        Public Property documento() As String
        Public Property año() As String
        Public Property area() As String
    End Class
End Class
