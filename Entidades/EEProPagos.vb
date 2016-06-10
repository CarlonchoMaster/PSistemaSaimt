
Public Class EEProPagos
    Inherits EEComun

    Public Property ProPaId() As String
    Public Property ProPaNroCuota() As Int32
    Public Property ProPaTotalCuotas() As Int32
    Public Property OCompProgramacion() As EECompProgramacion
    Public Property OTgTipoComprobante() As EETablaGeneral
    Public Property OContratoInm() As EEContratoInm
    Public Property ProPaFechaVen() As DateTime?
    Public Property ProPaFechaReg() As DateTime?
    ''' <summary>
    '''  Estado Programacion de Pagos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property OTgEstado() As EETablaGeneral
    Public Property ProPaFechaPag() As DateTime?
    Public Property ProPaDetIgv() As Decimal
    Public Property OTgRecaudadora() As EETablaGeneral
    Public Property ProPaPMora() As Decimal?
    Public Property ProPaAplicaD() As String
    Public Property ProPaComision() As Decimal?
    Public Property OTgMoneda() As EETablaGeneral
    Public Property ProPaDireccionFinca As String
    ''' <summary>
    ''' Nro Comprobante = Serie - Numero
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NroComprobante As String
    Public Property OPersona As EEPersona

    'Otros

    Public Property Monto() As Decimal?
    Public Property Detraccion() As Decimal?
    Public Property Año() As String
    Public Property OContacto() As EEPersona.EEContacto
       
    ''' <summary>
    ''' True = Actualizar ProPagos, False = Insertar una ProPagos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property GuardarOrUpdate() As Boolean

#Region "Detalle Programacion de Pagos"

    Public Property ListaProgramacionPagosDetalle() As List(Of EEProPagosDet)

    Public Class EEProPagosDet
        Public Property OConcepto() As EEConceptos
        Public Property ProPaDetMonto() As Decimal?
        Public Property ProPaDetPConcepto() As Decimal?
        Public Property ProPaDetAplicaM() As String
        Public Property ProPaId() As String

        ''' <summary>
        ''' True = Actualizar Detalle ProPagos, False = Insertar un Detalle de ProPagos
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GuardarOrUpdate() As Boolean
    End Class
#End Region

#Region "Monto En Grid Programacion Pagos"
    Public Property TempMonto() As Decimal
#End Region

    'PARA EL IMPORTADOR
    Public Property OGastoComision() As EEGastoComision
    Public Property ListaTempProPagos() As List(Of EETemp_ProPagos)
    Public Property ListaProPagos() As List(Of EEProPagos)


    ''' <summary>
    ''' Para Almacenar el Detalle Eliminado del Formulario Programacion de Pagos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ListaTemporalProPagosDetalleEliminados() As List(Of String)
End Class
