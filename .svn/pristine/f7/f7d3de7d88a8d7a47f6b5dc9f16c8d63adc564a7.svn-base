Imports Entidades
Imports System.ComponentModel
Imports System.Threading
Imports DAS
Imports DAO

<DataObject()>
Public Class ReglasWebBL
#Region "Instancia"
    Private Shared oInstance As ReglasWebBL
    Private Shared oMutex As New Mutex()
    Public Shared ReadOnly Property Instancia() As ReglasWebBL
        Get
            oMutex.WaitOne()
            If oInstance Is Nothing Then
                oInstance = New ReglasWebBL()
            End If
            oMutex.ReleaseMutex()
            Return oInstance
        End Get
    End Property
#End Region

#Region "Reglas Concepto"
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)>
    Public Function conceptoListarXAñoXTgGrupo(ByVal KeyGridRecaudacionWEB As String) As List(Of EEConceptos)
        Dim lsSplit() As String = KeyGridRecaudacionWEB.Split("-")
        Dim ldFechaPago As Date = lsSplit(1)
        Return ConceptoDAS.listarXAñoXTgGrupo(ldFechaPago.Year, "'06','07'")
    End Function
#End Region

#Region "Reglas NivelesPEM"
    Public Function nivelespemGuardar(ByVal aoNivelesPEM As EENivelesPEM) As Boolean
        If Not ValidacionDAS.NivelesPEMValidarXInstitucionSedeNombre(aoNivelesPEM.tgInstitucionId, aoNivelesPEM.tgSedeId, aoNivelesPEM.NivNombre, aoNivelesPEM.NivId, "S") Then
            Throw New Exception("El Nombre de Nivel ya Existe en la Institucion y Sede Seleccionada")
        ElseIf Not ValidacionDAS.NivelesPEMValidarXNroPisoInicio(aoNivelesPEM.NivEspInicio, aoNivelesPEM.NivId, "S") Then
            Throw New Exception("El Espacio Inicial ya Esta Registrado. Ingrese Otro Espacio de Inicio")
        End If
        Return NivelesPEMDAO.guardar(aoNivelesPEM)
    End Function

    Public Function nivelespemActualizar(ByVal aoNivelesPEM As EENivelesPEM) As Boolean
        'If Not ValidacionDAS.NivelesPEMValidarXInstitucionSedeNombre(aoNivelesPEM.tgInstitucionId, aoNivelesPEM.tgSedeId, aoNivelesPEM.NivNombre, aoNivelesPEM.NivId, "U") Then
        '    Throw New Exception("El Nombre de Nivel ya Existe en la Institucion y Sede Seleccionada")
        'Else
        If Not ValidacionDAS.NivelesPEMValidarXNroPisoInicio(aoNivelesPEM.NivEspInicio, aoNivelesPEM.NivId, "U") Then
            Throw New Exception("El Espacio Inicial ya Esta Registrado. Ingrese Otro Espacio de Inicio")
        End If
        Return NivelesPEMDAO.actualizar(aoNivelesPEM)
    End Function

    Public Function nivelespemEliminar(ByVal aiIdNivelesPEM As String) As Boolean
        Return NivelesPEMDAO.eliminar(aiIdNivelesPEM)
    End Function

    Public Function nivelespemListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EENivelesPEM)
        Return NivelesPEMDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function NivelesPEMListarAll() As List(Of EENivelesPEM)
        Return NivelesPEMDAS.listarALL()
    End Function

    Public Function listarNivelesPEM_NivId(ByVal NivId As [String]) As EENivelesPEM
        Return NivelesPEMDAS.listarxNivId(NivId)
    End Function

    Public Function generaCodigoNivelesPEM() As String
        Return NivelesPEMDAS.GeneraCodigo()
    End Function

    Public Function niovelespemVerificarXAcuNEspacio(ByVal aiEspacio As Int16) As Boolean
        Return NivelesPEMDAS.VerificarXAcuNEspacio(aiEspacio)
    End Function
#End Region

#Region "Reglas TarifasPEM"
    Public Function guardarTarifasPEM(ByVal aoTarifasPEM As EETarifasPEM) As [Boolean]
        Return TarifasPEMDAO.guardar(aoTarifasPEM)
    End Function

    Public Function actualizarTarifasPEM(ByVal aoTarifasPEM As EETarifasPEM) As [Boolean]
        Return TarifasPEMDAO.actualizar(aoTarifasPEM)
    End Function

    Public Function eliminarTarifasPEM(ByVal aiIdTarifasPEM As String) As [Boolean]
        Return TarifasPEMDAO.eliminar(aiIdTarifasPEM)
    End Function

    Public Function listarTarifasPEMCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETarifasPEM)
        Return TarifasPEMDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    'Public Function listarTarifasPEMALL() As List(Of EETarifasPEM)
    '    Return TarifasPEMDAS.listarALL()
    'End Function

    Public Function listarTarifasPEM_TarfId(ByVal TarfId As [String]) As EETarifasPEM
        Return TarifasPEMDAS.listarxTarfId(TarfId)
    End Function

    Public Function generaCodigoTarifaPEM() As String
        Return TarifasPEMDAS.GeneraCodigo()
    End Function
#End Region

#Region "Reglas AcuerdoPEM"
    Public Function listarAcuerdoPEMCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEAcuerdoPEM)
        Return AcuerdoPEMDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function listarAcuerdoPEM_AcuId(ByVal AcuId As [String]) As EEAcuerdoPEM
        Return AcuerdoPEMDAS.listarxAcuId(AcuId)
    End Function

    Public Function generaCodigoAcuerdoPEM() As String
        Return AcuerdoPEMDAO.GeneraCodigo()
    End Function
    Public Function acuerdopemGuardar(ByVal aoAcuerdoPEM As EEAcuerdoPEM) As Boolean
        Return AcuerdoPEMDAO.guardar(aoAcuerdoPEM)
    End Function

    Public Function acuerdopemActualizar(ByVal aoAcuerdoPEM As EEAcuerdoPEM) As Boolean
        Return AcuerdoPEMDAO.actualizar(aoAcuerdoPEM)
    End Function

    Public Function acuerdopemEliminar(ByVal aiIdAcuerdoPEM As String) As [Boolean]
        Return AcuerdoPEMDAO.eliminar(aiIdAcuerdoPEM)
    End Function

    Public Function acuerdopemListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEAcuerdoPEM)
        Return AcuerdoPEMDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function acuerdopemListarALL() As List(Of EEAcuerdoPEM)
        Return AcuerdoPEMDAS.listarALL()
    End Function

    Public Function AcuerdoPEM_Mostrar_acuEstado_XacuNPlaca_perId_pa(ByVal acuNPlaca1 As [String], ByVal acuNPlaca2 As [String], ByVal acuNPlaca3 As [String], ByVal perId As [String]) As String
        Return AcuerdoPEMDAS.Mostrar_acuEstado_XacuNPlaca_perId_pa(acuNPlaca1, acuNPlaca2, acuNPlaca3, perId)
    End Function

    Public Function acuerdopemConsultarAcuerdoXNPlaca_Estacionamiento(ByVal asNPlaca As String) As EEAcuerdoPEM
        Return AcuerdoPEMDAS.consultarAcuerdoXNPlaca_Estacionamiento(asNPlaca)
    End Function
    Public Function acuerdoValidaAcuerdoVigenteXPerId(ByVal asPerID As String) As String
        Return AcuerdoPEMDAS.ValidaAcuerdoVigenteXPerId(asPerID)
    End Function
#End Region

#Region "Reglas VehiculoDetPEM"

    'Public Function vehiculodetpemListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEVehiculoDetPEM)
    '    Return VehiculoDetPEMDAS.listarCriterio(aiTipoCriterio, asCriterio)
    'End Function

    'Public Function vehiculodetpemGuardar(ByVal aoVehiculoDetPEM As EEVehiculoDetPEM) As Boolean
    '    Return VehiculoDetPEMDAO.guardar(aoVehiculoDetPEM)
    'End Function

    'Public Function vehiculodetpemEliminar(ByVal nPlaca As String) As Boolean
    '    Return VehiculoDetPEMDAO.eliminar(nPlaca)
    'End Function

  
#End Region

#Region "DiarioPEM"
    'Public Function diariopemGuardar(aoDiarioPEM As EEDiarioPEM) As Boolean
    '    Return DiarioPEMDAO.guardar(aoDiarioPEM)
    'End Function

    'Public Function diariopemActualizar(aoDiarioPEM As EEDiarioPEM) As Boolean
    '    Return DiarioPEMDAO.actualizar(aoDiarioPEM)
    'End Function

    'Public Function diariopemExtornar(ByVal asDiarioId As String) As Boolean
    '    Return DiarioPEMDAO.extornar(asDiarioId)
    'End Function

    'Public Function diariopemConsultarXNPlaca_Estacionamiento(ByVal asNPlaca As [String]) As EEDiarioPEM
    '    Return DiarioPEMDAS.consultarXNPlaca_Estacionamiento(asNPlaca)
    'End Function

    'Public Function diariopemConsultarX_Estacionamiento(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDiarioPEM)
    '    Return DiarioPEMDAS.consultarX_Estacionamiento(aiTipoCriterio, asCriterio)
    'End Function
#End Region

#Region "Reporte Ingresos PEM"
   ' <DataObjectMethodAttribute(DataObjectMethodType.Select, True)>
    'Public Function reporteIngresosPEM(ByVal sqlIngresosPEM As String)
    '    Return DiarioPEMDAS.reporteIngresosPEM(sqlIngresosPEM)
    'End Function
#End Region

#Region "Recaudacion"
    Public Function recaudacionGuardarWEB(ByVal alstRecaudacion As List(Of EERecaudacion)) As Boolean
        Return RecaudacionDAO.guardarWEB(alstRecaudacion)
    End Function

    Public Function recaudacionActualizarFechaLiquidacionWEB(ByVal KeyGridRecaudacionWEB As String, ByVal adtFechaLiquidacion As DateTime?) As Boolean
        Dim lsSplit() As String = KeyGridRecaudacionWEB.Split("-")
        Dim liRecId As Int32 = lsSplit(0)
        Dim ldFechaPago As Date = lsSplit(1)
        Dim lsRecaudadorId As String = lsSplit(2)
        Return RecaudacionDAO.actualizarFechaLiquidacionWEB(adtFechaLiquidacion, liRecId, ldFechaPago, lsRecaudadorId)
    End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Insert, True)>
    Public Function recaudaciondetalleGuardarWEB(ByVal KeyGridRecaudacionWEB As String, ByVal asConcepto As String, ByVal asMonto As Decimal, ByVal adtFechaLiquidacion As DateTime?) As Boolean
        Dim lsSplit() As String = KeyGridRecaudacionWEB.Split("-")
        Dim liRecId As Int32 = lsSplit(0)
        Dim ldFechaPago As Date = lsSplit(1)
        Dim lsRecaudadorId As String = lsSplit(2)

        Dim lsConceptoSplit() As String = asConcepto.Split("-")

        Dim loRecaudacionDet As EERecaudacion.EERecaudacionDet = New EERecaudacion.EERecaudacionDet()
        loRecaudacionDet.RecId = liRecId
        loRecaudacionDet.RecFecPago = ldFechaPago
        loRecaudacionDet.TgRecaudadorId = lsRecaudadorId
        loRecaudacionDet.RecDMonto = asMonto
        loRecaudacionDet.ConId = lsConceptoSplit(0)
        loRecaudacionDet.ConPorcentaje = lsConceptoSplit(1) / 100
        loRecaudacionDet.RecDTotalIng = (asMonto * Convert.ToDecimal(lsConceptoSplit(1))) / 100
        loRecaudacionDet.RecDFechaLiquidacion = adtFechaLiquidacion

        Return RecaudacionDAO.guardarDetalleWEB(loRecaudacionDet)
    End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Delete, True)>
    Public Function recaudaciondetalleEliminarWEB(ByVal KeyGridRecaudacionDetalleWEB As String) As Boolean
        Dim lsSplit() As String = KeyGridRecaudacionDetalleWEB.Split("-")
        Dim liRecId As Int32 = lsSplit(0)
        Dim ldFechaPago As Date = lsSplit(1)
        Dim lsRecaudadorId As String = lsSplit(2)
        Dim asConId As String = lsSplit(3)

        Return RecaudacionDAO.eliminarDetalleWEB(liRecId, ldFechaPago, lsRecaudadorId, asConId)
    End Function

    Public Function recaudaciondetalleValidar(ByVal KeyGridRecaudacionWEB As String, ByVal asConId As String) As Boolean
        Dim lsSplit() As String = KeyGridRecaudacionWEB.Split("-")
        Dim liRecId As Int32 = lsSplit(0)
        Dim ldFechaPago As Date = lsSplit(1)
        Dim lsRecaudadorId As String = lsSplit(2)

        Return ValidacionDAS.RecaudacionDetalleValidar(liRecId, ldFechaPago, lsRecaudadorId, asConId)
    End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)>
    Public Function recaudacionListarXFecPago_XRecaudadora_WEB(ByVal adFechaPago As Date, ByVal asRecaudadorId As String) As List(Of EERecaudacion)
        Return RecaudacionDAS.listarXFecPago_XRecaudadora_WEB(adFechaPago, asRecaudadorId)
    End Function

    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)>
    Public Function mostrarDetalleRecaudacionXRecId_XFecPago_XRecaudadora_WEB(ByVal KeyGridRecaudacionWEB As String) As List(Of EERecaudacion.EERecaudacionDet)
        Dim lsSplit() As String = KeyGridRecaudacionWEB.Split("-")
        Dim liRecId As Int32 = lsSplit(0)
        Dim ldFechaPago As Date = lsSplit(1)
        Dim lsRecaudadorId As String = lsSplit(2)
        Return RecaudacionDAS.mostrarDetalleRecaudacionXRecId_XFecPago_XRecaudadora_WEB(liRecId, ldFechaPago, lsRecaudadorId)
    End Function

    Public Function recaudacionEliminarXFechaPagoWEB(ByVal adRecFecPago As Date) As Boolean
        Return RecaudacionDAO.eliminarXFechaPagoWEB(adRecFecPago)
    End Function
#End Region

#Region "Inmueble"
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)>
    Public Function inmuebleListarCriteriosWEB(ByVal SqlWhere As [String]) As List(Of EEInmueble)
        Return InmuebleDAS.listarCriteriosWEB(SqlWhere)
    End Function

    Public Function inmuebleConsultarXInmIdWEB(ByVal asInmId As [String]) As EEInmueble
        Return InmuebleDAS.consultarXInmIdWEB(asInmId)
    End Function
#End Region

End Class
