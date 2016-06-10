Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ProPagosDAS

#Region "Mostrar Numero Cuotas No Pagadas En Cancelacion Contrato XConInmId"
    Public Shared Function listarNroCuotasNoPagadasXConInmId(ByVal asConInmId As [String]) As List(Of EEProPagos)
        Dim ListaProPagos As List(Of EEProPagos) = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_NroCuotasNoPagadas_XConInmId_pa")
            db.AddInParameter(cmd, "ConInmId", DbType.String, asConInmId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProPagos Is Nothing Then
                    ListaProPagos = New List(Of EEProPagos)()
                End If
                loProPagos = New EEProPagos()
                loProPagos.ProPaNroCuota = dr("proPaNroCuota").ToString()
                loProPagos.ProPaTotalCuotas = dr("NroCuotas").ToString()
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgEstadoId").ToString()

                loProPagos.OTgEstado = loTablaGeneral

                ListaProPagos.Add(loProPagos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Nro Cuotas No Pagadas XConInmId  => " + ex.Message, ex)
        End Try
        Return ListaProPagos
    End Function
#End Region

#Region "Mostrar Numero Cuotas ALL XConInmId"
    Public Shared Function mostrarNroCuotasALLXConInmId(ByVal asConInmId As [String]) As Int32
        Dim dr As IDataReader = Nothing
        Dim NrosCuotas As Int32 = 0
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_NroCuotasALL_XConInmId_pa")
            db.AddInParameter(cmd, "ConInmId", DbType.String, asConInmId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                NrosCuotas = Convert.ToInt32(dr("NumeroCuotas").ToString)
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Nro Cuotas ALL XConInmId  => " + ex.Message, ex)
        End Try
        Return NrosCuotas
    End Function
#End Region

#Region "Mostrar la Programacion de Pagos X Contrato"
    ''' <summary>
    ''' Mostrar la Programacion de Pagos X Contrato
    ''' </summary>
    ''' <param name="asConInmId">ContratoId</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function listarXConInmIdConsultaProgramacionPagos(ByVal asConInmId As [String]) As List(Of EEProPagos)
        Dim ListaProPagos As List(Of EEProPagos) = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProPagos_XConInmId_EnConsultorProgramacionPagos_pa")
            db.AddInParameter(cmd, "conInmId", DbType.String, asConInmId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProPagos Is Nothing Then
                    ListaProPagos = New List(Of EEProPagos)()
                End If
                loProPagos = New EEProPagos()
                loProPagos.ProPaId = dr("ProPaId").ToString()
                loProPagos.ProPaNroCuota = Convert.ToInt32(dr("ProPaNroCuota").ToString())
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("TgTipoCompId").ToString()
                loTablaGeneral.TgNombre = dr("TgNombreComprobante").ToString()
                loProPagos.OTgTipoComprobante = loTablaGeneral
                loProPagos.ProPaFechaVen = IIf(IsDBNull(dr("ProPaFechaVen")), Nothing, dr("ProPaFechaVen"))
                loProPagos.ProPaFechaPag = IIf(IsDBNull(dr("ProPaFechaPag")), Nothing, dr("ProPaFechaPag"))
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgEstadoId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreEstado").ToString()
                loTablaGeneral.TgExtra = dr("tgExtraEstado").ToString()
                loProPagos.OTgEstado = loTablaGeneral
                loProPagos.ProPaDetIgv = IIf(IsDBNull(dr("ProPaDetIgv")), Nothing, dr("ProPaDetIgv"))
                loProPagos.ProPaAplicaD = dr("ProPaAplicaD").ToString()
                loProPagos.ProPaPMora = Convert.ToDecimal(dr("ProPaPMora").ToString())
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgRecaudadoraId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreRecaudadora").ToString()
                loProPagos.OTgRecaudadora = loTablaGeneral
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgMonedaId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreMoneda").ToString()
                loProPagos.OTgMoneda = loTablaGeneral
                If Not IsDBNull(dr("ProPaComision")) Then
                    loProPagos.ProPaComision = Convert.ToDecimal(dr("ProPaComision").ToString())
                End If
                loProPagos.NroComprobante = dr("nroComprobante").ToString()
                ListaProPagos.Add(loProPagos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ProPagos Criterio => " + ex.Message, ex)
        End Try
        Return ListaProPagos
    End Function
#End Region

#Region "Listar la Programacion Pagos Detalle XProPaId"
    ''' <summary>
    ''' Listar la Programacion Pagos Detalle X ProPaId
    ''' </summary>
    ''' <param name="asProPaId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function listarProPagosDetalleXProPaId(ByVal asProPaId As [String]) As List(Of EEProPagos)
        Dim ListaProPagos As List(Of EEProPagos) = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim loProPagosDetalle As EEProPagos.EEProPagosDet = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProPagosDet_XProPaId_pa")
            db.AddInParameter(cmd, "proPaId", DbType.String, asProPaId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProPagos Is Nothing Then
                    ListaProPagos = New List(Of EEProPagos)()
                End If
                loProPagos = New EEProPagos()
                If loProPagos.ListaProgramacionPagosDetalle Is Nothing Then
                    loProPagos.ListaProgramacionPagosDetalle = New List(Of EEProPagos.EEProPagosDet)
                End If
                loProPagos.ProPaId = dr("ProPaId").ToString()
                loProPagosDetalle = New EEProPagos.EEProPagosDet()
                loProPagosDetalle.ProPaDetMonto = Convert.ToDecimal(dr("ProPaDetMonto").ToString())
                loProPagosDetalle.ProPaDetPConcepto = Convert.ToDecimal(dr("ProPaDetPConcepto").ToString())
                loConceptos = New EEConceptos()
                loConceptos.ConId = dr("ConId").ToString()
                loConceptos.ConNombre = dr("ConNombre").ToString()
                loProPagosDetalle.OConcepto = loConceptos
                loProPagos.ListaProgramacionPagosDetalle.Add(loProPagosDetalle)
                ListaProPagos.Add(loProPagos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ProPagos Detalle XProPaId Consulta Programacion Pagos => " + ex.Message, ex)
        End Try
        Return ListaProPagos
    End Function
#End Region

#Region "Mostrar Total Pagado o Por Pagar"
    ''' <summary>
    ''' Mostrar el Total Pagado si estado es P = Pagado o el Total por pagar si el estado es N = No Pagado
    ''' </summary>
    ''' <param name="asConInmId">ContratoId</param>
    ''' <param name="asEstado">Estado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function mostrarProPagosMontoTotalXEstadoXConInmIdConsultaProgramacionPagos(ByVal asConInmId As [String], ByVal asEstado As String, Optional asNiConId As String = Nothing) As Decimal
        Dim ldMonto As Decimal = 0
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_ProPagos_MontoTotal_XEstado_XConInmId_pa")
            db.AddInParameter(cmd, "conInmId", DbType.String, asConInmId)
            db.AddInParameter(cmd, "tgEstado", DbType.String, asEstado)
            If asNiConId IsNot Nothing Then
                db.AddInParameter(cmd, "niConId", DbType.String, asNiConId)
            End If
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                ldMonto = IIf(IsDBNull(dr("MontoTotal")), 0, dr("MontoTotal"))
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar ProPago Monto Total XEstado XConInmId ConsultaProgramacionPagos => " + ex.Message, ex)
        End Try
        Return ldMonto
    End Function
#End Region

#Region "Exportar Programacion de Pagos"
    Public Shared Function exportar() As List(Of EETemp_ProPagos)
        Dim ListaTemp_ProPagos As List(Of EETemp_ProPagos) = Nothing
        Dim loTemp_ProPagos As EETemp_ProPagos = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim ListaProPagos As List(Of EEProPagos) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Exportar_ProPagos")
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTemp_ProPagos Is Nothing Then
                    ListaTemp_ProPagos = New List(Of EETemp_ProPagos)()
                End If
                'loProPagos = New EEProPagos
                'loProPagos.ProPaId = dr("proPaId")
                'loProPagos.ProPaNroCuota = dr("proPaNroCuota")
                'loProPagos.OContratoInm.ConInmId = dr("ContId")
                'loProPagos.ProPaFechaVen = dr("proPaFechaVen")
                'loProPagos.ProPaFechaPag = dr("proPaFechaPag")
                'loProPagos.ProPaDetIgv = dr("proPaDetIgv")
                'loProPagos.ProPaPMora = dr("proPaPMora")
                'loProPagos.ProPaAplicaD = dr("proPaAplicaD")
                'loProPagos.OTgMoneda.TgCodigo = dr("tgMonedaId")
                'loProPagos.OContratoInm.InmId = dr("inmId")
                'loProPagos.ProPaDireccionFinca = dr("DireccionFinca")
                'loProPagos.OPersona.PerId = dr("perId")
                'loProPagos.OPersona.PerApePaterno = dr("perApePaterno")
                'loProPagos.OPersona.PerApeMaterno = dr("perApeMaterno")
                'loProPagos.OPersona.PerNombres = dr("perNombres")
                'ListaProPagos.Add(loProPagos)

                loTemp_ProPagos = New EETemp_ProPagos()
                loTemp_ProPagos.ProPaId = dr("ProPaId").ToString()
                loTemp_ProPagos.ProPaAño = dr("ProPaAño").ToString()
                loTemp_ProPagos.ContId = dr("ContId").ToString()
                loTemp_ProPagos.PerId = dr("PerId").ToString()
                loTemp_ProPagos.Persona = dr("Persona").ToString()
                loTemp_ProPagos.Contacto = dr("Contacto").ToString()
                loTemp_ProPagos.ProPaNroCuota = Convert.ToInt32(dr("NroCuota").ToString())
                loTemp_ProPagos.ConId = dr("ConceptoId").ToString()
                loTemp_ProPagos.ConNombre = dr("Concepto").ToString()
                loTemp_ProPagos.ProPa_PSaimt = Convert.ToDecimal(dr("P_SAIMT").ToString())
                loTemp_ProPagos.ProPa_PMpt = Convert.ToDecimal(dr("P_MPT").ToString())
                loTemp_ProPagos.ProPaFecVen = Convert.ToDateTime(IIf(IsDBNull(dr("FechaVen")), Nothing, dr("FechaVen")))
                loTemp_ProPagos.ProPaDetMonto = Convert.ToDecimal(dr("Monto").ToString())
                loTemp_ProPagos.TgEstadoId = dr("TgEstadoId").ToString()
                loTemp_ProPagos.ProPaFecPag = IIf(IsDBNull(dr("FechaPago")), Nothing, dr("FechaPago"))
                loTemp_ProPagos.ProPaCtaSaimt = Convert.ToDecimal(dr("Cta_SAIMT").ToString())
                loTemp_ProPagos.ProPaCtaMpt = Convert.ToDecimal(dr("Cta_MPT").ToString())
                loTemp_ProPagos.ProPaMoraSaimt = Convert.ToDecimal(dr("Mora_Cta_SAIMT").ToString())
                loTemp_ProPagos.ProPaMoraMpt = Convert.ToDecimal(dr("Mora_Cta_MPT").ToString())
                loTemp_ProPagos.ProPaComCtaSaimt = Convert.ToDecimal(dr("Com_Cta_SAIMT").ToString())
                loTemp_ProPagos.ProPaComCtaMpt = Convert.ToDecimal(dr("Com_Cta_MPT").ToString())
                ListaTemp_ProPagos.Add(loTemp_ProPagos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Exportar Programacion de Pagos => " & ex.Message, ex)
        End Try
        Return ListaTemp_ProPagos
    End Function
#End Region

#Region "Reporte Programacion Pagos XProPaId"
    Public Shared Function Reporte_ProPagosXPropaId(ByVal asProPaid As String) As List(Of EEProPagos)
        Dim ListaProPagos As List(Of EEProPagos) = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loMoneda As EETablaGeneral = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim loTipoComprobante As EETablaGeneral = Nothing
        Dim loContacto As EEPersona.EEContacto = Nothing
        Try
            Dim dr As IDataReader = Nothing
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Reporte_ProPagosXProPaId")
            db.AddInParameter(cmd, "proPaId", DbType.String, asProPaid)
            dr = db.ExecuteReader(cmd)
            While dr.Read
                If ListaProPagos Is Nothing Then
                    ListaProPagos = New List(Of EEProPagos)
                End If
                loProPagos = New EEProPagos
                If dr("proPaId") Is DBNull.Value Then
                    loProPagos.ProPaId = String.Empty
                Else
                    loProPagos.ProPaId = dr("proPaId").ToString.Trim
                End If
                If dr("proPaNroCuota") Is DBNull.Value Then
                    loProPagos.ProPaNroCuota = String.Empty
                Else
                    loProPagos.ProPaNroCuota = CInt(dr("proPaNroCuota"))
                End If
                If dr("proPaFechaVen") Is DBNull.Value Then
                    loProPagos.ProPaFechaVen = Now
                Else
                    loProPagos.ProPaFechaVen = CDate(dr("proPaFechaVen"))
                End If
                If dr("proPaFechaPag") Is DBNull.Value Then
                    loProPagos.ProPaFechaPag = Now
                Else
                    loProPagos.ProPaFechaPag = CDate(dr("proPaFechaPag"))
                End If
                If dr("proPaDetIgv") Is DBNull.Value Then
                    loProPagos.ProPaDetIgv = 0
                Else
                    loProPagos.ProPaDetIgv = CDec(dr("proPaDetIgv"))
                End If
                If dr("proPaPMora") Is DBNull.Value Then
                    loProPagos.ProPaPMora = 0
                Else
                    loProPagos.ProPaPMora = CDec(dr("proPaPMora"))
                End If
                If dr("proPaAplicaD") Is DBNull.Value Then
                    loProPagos.ProPaAplicaD = String.Empty
                Else
                    loProPagos.ProPaAplicaD = dr("proPaAplicaD").ToString.Trim
                End If
                If dr("DireccionFinca") Is DBNull.Value Then
                    loProPagos.ProPaDireccionFinca = String.Empty
                Else
                    loProPagos.ProPaDireccionFinca = dr("DireccionFinca").ToString.Trim
                End If
                loContratoInm = New EEContratoInm
                If dr("conInmId") Is DBNull.Value Then
                    loContratoInm.ConInmId = String.Empty
                Else
                    loContratoInm.ConInmId = dr("conInmId").ToString.Trim
                End If
                If dr("inmId") Is DBNull.Value Then
                    loContratoInm.InmId = String.Empty
                Else
                    loContratoInm.InmId = dr("inmId").ToString.Trim
                End If
                loProPagos.OContratoInm = loContratoInm
                loMoneda = New EETablaGeneral
                If dr("tgMonedaId") Is DBNull.Value Then
                    loMoneda.TgCodigo = String.Empty
                Else
                    loMoneda.TgCodigo = dr("tgMonedaId").ToString.Trim
                End If
                If dr("tgDescripcion") Is DBNull.Value Then
                    loMoneda.TgDescripcion = String.Empty
                Else
                    loMoneda.TgDescripcion = dr("tgDescripcion").ToString.Trim
                End If
                loProPagos.OTgMoneda = loMoneda
                loPersona = New EEPersona

                If dr("perId") Is DBNull.Value Then
                    loPersona.PerId = String.Empty
                Else
                    loPersona.PerId = dr("perId").ToString.Trim
                End If
                If dr("perApePaterno") Is DBNull.Value Then
                    loPersona.PerApePaterno = String.Empty
                Else
                    loPersona.PerApePaterno = dr("perApePaterno").ToString.Trim
                End If
                If dr("perApeMaterno") Is DBNull.Value Then
                    loPersona.PerApeMaterno = String.Empty
                Else
                    loPersona.PerApeMaterno = dr("perApeMaterno").ToString.Trim
                End If
                If dr("perNombres") Is DBNull.Value Then
                    loPersona.PerNombres = String.Empty
                Else
                    loPersona.PerNombres = dr("perNombres")
                End If
                If dr("perRazonSocial") Is DBNull.Value Then
                    loPersona.PerRazonSocial = String.Empty
                Else
                    loPersona.PerRazonSocial = dr("perRazonSocial").ToString
                End If
                loProPagos.OPersona = loPersona

                loPersona.PerId = dr("perId")
                loPersona.PerApePaterno = IIf(IsDBNull(dr("perApePaterno")), String.Empty, dr("perApePaterno"))
                loPersona.PerApeMaterno = IIf(IsDBNull(dr("perApeMaterno")), String.Empty, dr("perApeMaterno"))
                loPersona.PerNombres = IIf(IsDBNull(dr("perNombres")), String.Empty, dr("perNombres"))
                loPersona.PerRazonSocial = IIf(IsDBNull(dr("perRazonSocial")), String.Empty, dr("perRazonSocial"))
                loProPagos.OPersona = loPersona

                loTipoComprobante = New EETablaGeneral
                If dr("tgTipoCompId") Is DBNull.Value Then
                    loTipoComprobante.TgCodigo = String.Empty
                Else
                    loTipoComprobante.TgCodigo = dr("tgTipoCompId")
                End If
                loProPagos.OTgTipoComprobante = loTipoComprobante
                loContacto = New EEPersona.EEContacto
                If dr("contDescripcion") Is DBNull.Value Then
                    loContacto.ContDescripcion = String.Empty
                Else
                    loContacto.ContDescripcion = dr("contDescripcion")
                End If
                loProPagos.OContacto = loContacto
                ListaProPagos.Add(loProPagos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Reporte_ProPagosXPropaId => " + ex.Message, ex)
        End Try
        Return ListaProPagos
    End Function
#End Region

#Region "Listar Programacion de Pagos Detracciones"
    Public Shared Function listarDetraccionesXMesXAño(ByVal asMes As String, ByVal asAño As String) As List(Of EEProPagos)
        Dim ListaProPagos As List(Of EEProPagos) = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProgramacionPagos_Detracciones_XMes_XAño_pa")
            db.AddInParameter(cmd, "mes", DbType.String, asMes)
            db.AddInParameter(cmd, "año", DbType.String, asAño)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProPagos Is Nothing Then
                    ListaProPagos = New List(Of EEProPagos)()
                End If
                loProPagos = New EEProPagos()
                loProPagos.ProPaId = dr("ProPaId").ToString()
                loProPagos.ProPaNroCuota = Convert.ToInt32(dr("ProPaNroCuota").ToString())
                loProPagos.ProPaFechaPag = IIf(IsDBNull(dr("ProPaFechaPag")), Nothing, dr("ProPaFechaPag"))
                loProPagos.Año = dr("Año").ToString()
                loProPagos.Monto = dr("Monto").ToString()
                loProPagos.Detraccion = dr("Detraccion").ToString()

                loInmueble = New EEInmueble()
                loInmueble.InmId = dr("InmId").ToString

                loPersona = New EEPersona()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("ConInmId").ToString()
                loContratoInm.OInmueble = loInmueble
                loContratoInm.OPersona = loPersona

                loProPagos.OContratoInm = loContratoInm

                ListaProPagos.Add(loProPagos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Detracciones => " + ex.Message, ex)
        End Try
        Return ListaProPagos
    End Function

    Public Shared Function listarDetraccionesXPersonaXAño(ByVal asPersona As String, ByVal asAño As String) As List(Of EEProPagos)
        Dim ListaProPagos As List(Of EEProPagos) = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProgramacionPagos_Detracciones_XPersona_XAño_pa")
            db.AddInParameter(cmd, "percliente", DbType.String, asPersona)
            db.AddInParameter(cmd, "año", DbType.String, asAño)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProPagos Is Nothing Then
                    ListaProPagos = New List(Of EEProPagos)()
                End If
                loProPagos = New EEProPagos()
                loProPagos.ProPaId = dr("ProPaId").ToString()
                loProPagos.ProPaNroCuota = Convert.ToInt32(dr("ProPaNroCuota").ToString())
                loProPagos.ProPaFechaPag = IIf(IsDBNull(dr("ProPaFechaPag")), Nothing, dr("ProPaFechaPag"))
                loProPagos.Año = dr("Año").ToString()
                loProPagos.Monto = CDbl(dr("Monto").ToString())
                loProPagos.Detraccion = CDbl(dr("Detraccion").ToString())

                loInmueble = New EEInmueble()
                loInmueble.InmId = dr("InmId").ToString

                loPersona = New EEPersona()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("ConInmId").ToString()
                loContratoInm.OInmueble = loInmueble
                loContratoInm.OPersona = loPersona

                loProPagos.OContratoInm = loContratoInm

                ListaProPagos.Add(loProPagos)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Detracciones x Persona => " + ex.Message, ex)
        End Try
        Return ListaProPagos
    End Function
#End Region

#Region "Listar Programacion de Pagos Generacion Ordenes Pago Criterio"
    Public Shared Function listarGeneracionOrdenesPagoCriterio(astgEstCompId As String, Optional ByVal asAnio As [String] = Nothing, Optional ByVal asMes As [String] = Nothing, Optional asCliente As [String] = Nothing) As List(Of EEProPagos)
        Dim ListaProPagos As List(Of EEProPagos) = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim loTgTipoComprobante As EETablaGeneral = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProgramacionPagos_GeneracionOrdenesPago_Criterio_pa")
            db.AddInParameter(cmd, "anio", DbType.String, asAnio)
            db.AddInParameter(cmd, "mes", DbType.String, asMes)
            db.AddInParameter(cmd, "cliente", DbType.String, asCliente)
            db.AddInParameter(cmd, "tgEstCompId", DbType.String, astgEstCompId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProPagos Is Nothing Then
                    ListaProPagos = New List(Of EEProPagos)()
                End If
                loProPagos = New EEProPagos()
                loProPagos.ProPaId = dr("ProPaId").ToString()
                loProPagos.ProPaNroCuota = Convert.ToInt32(dr("ProPaNroCuota").ToString())
                loProPagos.ProPaFechaPag = IIf(IsDBNull(dr("ProPaFechaPag")), Nothing, dr("ProPaFechaPag"))
                loProPagos.Año = dr("Año").ToString()
                loProPagos.Monto = dr("Monto").ToString()
                loProPagos.Detraccion = dr("Detraccion")

                loTgTipoComprobante = New EETablaGeneral()
                loProPagos.OTgTipoComprobante = loTgTipoComprobante
                loProPagos.OTgTipoComprobante.TgCodigo = dr("tgTipoCompId")
                loProPagos.OTgTipoComprobante.TgNombre = dr("tgTipoComp")

                loInmueble = New EEInmueble()
                loInmueble.InmId = dr("InmId").ToString

                loPersona = New EEPersona()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("ConInmId").ToString()
                loContratoInm.OInmueble = loInmueble
                loContratoInm.OPersona = loPersona

                loProPagos.OContratoInm = loContratoInm

                ListaProPagos.Add(loProPagos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Programacion de Pagos Generacion Ordenes de Pago => " + ex.Message, ex)
        End Try
        Return ListaProPagos
    End Function

    Public Shared Function listarOrdenesPagoCriterio(Optional ByVal asAnio As [String] = Nothing, Optional ByVal asMes As [String] = Nothing, Optional asCliente As [String] = Nothing, Optional asNrocomp As [String] = Nothing) As List(Of EEProPagos)
        Dim ListaProPagos As List(Of EEProPagos) = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim loCompProgramacion As EECompProgramacion = Nothing
        Dim loTgTipoComprobante As EETablaGeneral = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProgramacionPagos_OrdenPagos_Criterio_pa")
            db.AddInParameter(cmd, "anio", DbType.String, asAnio)
            db.AddInParameter(cmd, "mes", DbType.String, asMes)
            db.AddInParameter(cmd, "cliente", DbType.String, asCliente)
            db.AddInParameter(cmd, "nrocomp", DbType.String, asNrocomp)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProPagos Is Nothing Then
                    ListaProPagos = New List(Of EEProPagos)()
                End If
                loProPagos = New EEProPagos()
                loProPagos.ProPaId = dr("ProPaId").ToString()
                loProPagos.ProPaNroCuota = Convert.ToInt32(dr("ProPaNroCuota").ToString())
                loProPagos.ProPaFechaPag = IIf(IsDBNull(dr("ProPaFechaPag")), Nothing, dr("ProPaFechaPag"))
                loProPagos.Año = dr("Año").ToString()
                loProPagos.Monto = dr("Monto").ToString()
                loProPagos.Detraccion = dr("Detraccion")

                loCompProgramacion = New EECompProgramacion()
                loCompProgramacion.CompProPagNro = dr("CompProPagNro").ToString()
                loCompProgramacion.CompProPagSerie = dr("CompProPagSerie").ToString()

                loTgTipoComprobante = New EETablaGeneral()
                loProPagos.OTgTipoComprobante = loTgTipoComprobante
                loProPagos.OTgTipoComprobante.TgCodigo = dr("tgTipoCompId")
                loProPagos.OTgTipoComprobante.TgNombre = dr("tgTipoComp")

                loInmueble = New EEInmueble()
                loInmueble.InmId = dr("InmId").ToString

                loPersona = New EEPersona()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("ConInmId").ToString()
                loContratoInm.OInmueble = loInmueble
                loContratoInm.OPersona = loPersona
                loProPagos.OCompProgramacion = loCompProgramacion
                loProPagos.OContratoInm = loContratoInm

                ListaProPagos.Add(loProPagos)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Programacion de Pagos Generacion Ordenes de Pago => " + ex.Message, ex)
        End Try
        Return ListaProPagos
    End Function
#End Region

#Region "Mostrar Años de Programacion de Pagos"
    Public Shared Function AñosProgPagos() As List(Of EEProPagos)
        Dim loProPagos As EEProPagos = Nothing
        Dim loListaAños As List(Of EEProPagos) = Nothing
        Try
            Dim dr As IDataReader = Nothing
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetSqlStringCommand("select [Años] from [dbo].[vAñosProPagos]")
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If loListaAños Is Nothing Then
                    loListaAños = New List(Of EEProPagos)
                End If
                loProPagos = New EEProPagos
                loProPagos.Año = CInt(dr("Años"))
                loListaAños.Add(loProPagos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Años de Programacion de Pagos => " + ex.Message, ex)
        End Try
        Return loListaAños
    End Function
#End Region

#Region "Mostrar Años de Programacion de Pagos en PivotProPagos"
    Public Shared Function listarAñosProPagos_EnPivotProPagos() As List(Of String)
        Dim ListaAños As List(Of String) = Nothing
        Try
            Dim dr As IDataReader = Nothing
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProPagos_Años_EnPivotProPagos_pa")
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaAños Is Nothing Then
                    ListaAños = New List(Of String)
                End If

                ListaAños.Add(dr("año").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Años de Programacion Pagos en PivotProPagos => " & ex.Message, ex)
        End Try
        Return ListaAños
    End Function
#End Region

#Region "Listar la Programacion Pagos Detalle XProPaId En Consultar Mora"
    ''' <summary>
    ''' Listar la Programacion Pagos Detalle X ProPaId En Consultar Mora
    ''' </summary>
    ''' <param name="asProPaId">ProPaId</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function listarProPagosDetalleXProPaIdXEstado_EnConsultarMora(ByVal asProPaId As String, ByVal asEstado As String) As List(Of EEProPagos)
        Dim ListaProPagos As List(Of EEProPagos) = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim loProPagosDetalle As EEProPagos.EEProPagosDet = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ProPagosDet_XProPaId_XEstado_EnConsultarMora_pa")
            db.AddInParameter(cmd, "proPaId", DbType.String, asProPaId)
            db.AddInParameter(cmd, "tgEstado", DbType.String, asEstado)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaProPagos Is Nothing Then
                    ListaProPagos = New List(Of EEProPagos)()
                End If
                loProPagos = New EEProPagos()
                If loProPagos.ListaProgramacionPagosDetalle Is Nothing Then
                    loProPagos.ListaProgramacionPagosDetalle = New List(Of EEProPagos.EEProPagosDet)
                End If
                loProPagos.ProPaId = dr("ProPaId").ToString()
                loProPagosDetalle = New EEProPagos.EEProPagosDet()
                loProPagosDetalle.ProPaId = dr("ProPaId").ToString()
                loProPagosDetalle.ProPaDetMonto = Convert.ToDecimal(dr("ProPaDetMonto").ToString())
                loProPagosDetalle.ProPaDetPConcepto = Convert.ToDecimal(dr("ProPaDetPConcepto").ToString())
                loConceptos = New EEConceptos()
                loConceptos.ConId = dr("ConId").ToString()
                loConceptos.ConNombre = dr("ConNombre").ToString()
                loProPagosDetalle.OConcepto = loConceptos
                loProPagos.ListaProgramacionPagosDetalle.Add(loProPagosDetalle)
                ListaProPagos.Add(loProPagos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar la Programacion Pagos Detalle XProPaId En Consultar Mora => " + ex.Message, ex)
        End Try
        Return ListaProPagos
    End Function
#End Region

#Region "Consultar Merced Conductiva X ProPaId"
    Public Shared Function mostrarMercedCondutivaXProPaId_EnConsultarMora(ByVal lsProPaId As String) As Decimal
        Dim dr As IDataReader = Nothing
        Dim ldMercedConductiva As Decimal = 0
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Consultar_MercedConductiva_XProPaId_EnConsultarMora")
            db.AddInParameter(cmd, "propaid", DbType.String, lsProPaId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                ldMercedConductiva = Convert.ToDecimal(dr("MercedConductiva").ToString())
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Merced Conductiva X ProPaId  => " + ex.Message, ex)
        End Try
        Return ldMercedConductiva
    End Function
#End Region


End Class