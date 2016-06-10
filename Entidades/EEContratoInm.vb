Public Class EEContratoInm
    'Inherits EEComun

    Public Property ConInmId() As String
    Public Property InmId() As String
    Public Property OInmueble() As EEInmueble
    Public Property ConInmDocRef() As String
    Public Property PerId() As String
    Public Property OPersona() As EEPersona
    Public Property ConInmGarantia() As Decimal?
    Public Property ConInmDerLlaves() As Decimal?
    Public Property ConInmMerced() As Decimal?
    Public Property ConInmFecIni() As DateTime?
    Public Property ConInmFecFin() As DateTime?
    Public Property ConInmFecReg() As DateTime?
    Public Property ConInmFecCan() As DateTime?
    Public Property ConInmICuotaCan() As Int32?
    Public Property ConInmDiaMaxVen() As Int32?
    Public Property AnioAnt() As Int32?
    Public Property inmPredArea() As Double?
    Public Property inmPartidaElec() As String
    Public Property tgCompId() As String
    Public Property TgUsoId() As String
    Public Property TgEstId() As String
    Public Property TgMonId() As String
    Public Property TgModId() As String
    Public Property TgGarId() As String
    Public Property ConInmObs() As String
    Public Property InmDistrito() As String
    Public Property InmProvincia() As String
    Public Property InmDepartamento() As String
    Public Property InmDir() As String
    Public Property ConNroCuota() As String
    Public Property ConInmFecSol() As DateTime?
    Public Property ConInmFecSus() As DateTime?
    Public Property conInmRegMesPart() As String
    Public Property OTgUso() As EETablaGeneral
    Public Property OTgEstado() As EETablaGeneral
    Public Property OTgMoneda() As EETablaGeneral
    Public Property OTgModalidad() As EETablaGeneral
    Public Property OTgComprobante() As EETablaGeneral
    Public Property OTgGarantia() As EETablaGeneral
    Public Property OContacto As EEPersona.EEContacto
    Public Property Anexos As Int16?
       
    Public ReadOnly Property DatoContrato() As String
        Get
            If ConInmFecIni Is Nothing Or ConInmFecFin Is Nothing Then
                Return ConInmId
            Else
                Return String.Format("{0} | {1} - {2}", ConInmId, ConInmFecIni.Value.ToShortDateString, ConInmFecFin.Value.ToShortDateString)
            End If
        End Get
    End Property

#Region "Lista Temporales"

    Public Property ListaProgramacionPagos() As List(Of EEProPagos) = New List(Of EEProPagos)

#Region "Archivos"
    Public Property ListaConInmArchivosTemporalEliminados() As List(Of String)
    Public Property ListaConInmArchivosTemporalNuevos() As List(Of EEConArchivos)
    Public Property ListaConInmArchivosEditados() As List(Of EEConArchivos)
    Public Property ListaConInmArchivos() As List(Of EEConArchivos) = New List(Of EEConArchivos)
#End Region

#End Region

End Class
