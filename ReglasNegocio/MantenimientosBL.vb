﻿Imports System.Threading
Imports DAO
Imports Entidades
Imports DAS
Imports System.ComponentModel

Public Class MantenimientosBL


#Region "Reglas JerarquiaArch"
    Public Function jerarquiaarchGuardar(ByVal voJerarquiaArch As EEJerarquiaArch) As [Boolean]
        Return JerarquiaArchDAO.guardar(voJerarquiaArch)
    End Function

    Public Function jerarquiaarchActualizar(ByVal voJerarquiaArch As EEJerarquiaArch) As [Boolean]
        Return JerarquiaArchDAO.actualizar(voJerarquiaArch)
    End Function

    Public Function jerarquiaarchNewCodigo() As String
        Return JerarquiaArchDAS.NewCodigo()
    End Function

    Public Function jerarquiaArchAll() As List(Of EEJerarquiaArch)
        Return JerarquiaArchDAS.listarAll()
    End Function
#End Region

#Region "Reglas ExpedienteArch"
    Public Function expedientearchGuardar(ByVal voExpedienteArch As EEExpedienteArch) As [Boolean]
        Return ExpedienteArchDAO.guardar(voExpedienteArch)
    End Function

    Public Function expedientearchActualizar(ByVal voExpedienteArch As EEExpedienteArch) As [Boolean]
        Return ExpedienteArchDAO.actualizar(voExpedienteArch)
    End Function
#End Region

#Region "Instancia"
    Private Shared oInstance As MantenimientosBL
    Private Shared oMutex As New Mutex()
    Public Shared ReadOnly Property Instancia() As MantenimientosBL
        Get
            oMutex.WaitOne()
            If oInstance Is Nothing Then
                oInstance = New MantenimientosBL()
            End If
            oMutex.ReleaseMutex()
            Return oInstance
        End Get
    End Property
#End Region

#Region "Reglas Concepto"
    Public Function conceptoListarXAñoXTgGrupo(ByVal asAño As String, ByVal asTgGrupo As String) As List(Of EEConceptos)
        Return ConceptoDAS.listarXAñoXTgGrupo(asAño, asTgGrupo)
    End Function

    Public Function conceptoListarXAñoXTgGrupoXTgSubGrupo(ByVal asAño As String, ByVal asTgGrupo As String, ByVal asTgSubGrupo As String) As List(Of EEConceptos)
        Return ConceptoDAS.listarXAñoXTgGrupoXTgSubGrupo(asAño, asTgGrupo, asTgSubGrupo)
    End Function

    Public Function conceptoListarAbono() As List(Of EEConceptos)
        Return ConceptoDAS.listarAbono()
    End Function

    Public Function conceptoListarAbono_XTgSubGrupoId(ByVal asTgSubGrupoId As String) As List(Of EEConceptos)
        Return ConceptoDAS.listarAbono_XTgSubGrupoId(asTgSubGrupoId)
    End Function

    Public Function conceptoMostrarImporte_XConId(ByVal asConId As String) As Decimal?
        Return ConceptoDAS.mostrarImporte_XConId(asConId)
    End Function

    Public Function conceptosGuardar(ByVal aoConceptos As EEConceptos) As Boolean
        Return ConceptosDAO.guardar(aoConceptos)
    End Function

    Public Function conceptosActualizar(ByVal aoConceptos As EEConceptos) As Boolean
        Return ConceptosDAO.actualizar(aoConceptos)
    End Function

    Public Function conceptosListarBCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal año As Int16) As List(Of EEConceptos)
        Return ConceptoDAS.listarBCriterio(aiTipoCriterio, asCriterio, año)
    End Function

    Public Function conceptosListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal año As Int16) As List(Of EEConceptos)
        Return ConceptoDAS.listarCriterio(aiTipoCriterio, asCriterio, año)
    End Function

    Public Function conceptosMostrarXConId(ByVal asConId As [String]) As EEConceptos
        Return ConceptoDAS.MostrarXConId(asConId)
    End Function
#End Region

#Region "Reglas Clase"
    Public Function claseGuardar(ByVal aoClase As EEClase) As [Boolean]
        If aoClase.ClsNombre Is Nothing Then
            Throw New Exception("El Nombre de la Clase es Obligatorio")
        End If
        If aoClase.ClsNombre.Length > 100 Then
            Throw New Exception("El Nombre de la Clase debe tener 100 Caracteres como maximo")
        End If
        If aoClase.ClsDescripcion IsNot Nothing Then
            If aoClase.ClsDescripcion.Length > 400 Then
                Throw New Exception("La descripcion debe tener 400 Caracteres como maximo")
            End If
        End If
        Return ClaseDAO.guardar(aoClase)
    End Function

    Public Function claseActualizar(ByVal aoClase As EEClase) As [Boolean]
        If aoClase.ClsNombre Is Nothing Then
            Throw New Exception("El Nombre de la Clase es Obligatorio")
        End If
        If aoClase.ClsNombre.Length > 30 Then
            Throw New Exception("El Nombre de la Clase debe tener 30 Caracteres como maximo")
        End If
        If aoClase.ClsDescripcion IsNot Nothing Then
            If aoClase.ClsDescripcion.Length > 50 Then
                Throw New Exception("La descripcion debe tener 50 Caracteres como maximo")
            End If
        End If
        Return ClaseDAO.actualizar(aoClase)
    End Function

    Public Function claseEliminar(ByVal aiIdClase As Int32) As [Boolean]
        Return ClaseDAO.eliminar(aiIdClase)
    End Function

    Public Function claseListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEClase)
        Return ClaseDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function claseListarALL() As List(Of EEClase)
        Return ClaseDAS.listarALL()
    End Function
#End Region

#Region "geracion de codigos"
    Public Function InstitucionNewCodigo() As String
        Return TablaGeneralDAS.GetInstitucionCodigoGenerado()
    End Function

    Public Function AreaNewCodigo(ByVal sInstitucionId As String) As String
        Return TablaGeneralDAS.GetAreaCodigoGenerado(sInstitucionId)
    End Function

    Public Function CargosNewCodigo(ByVal sInstitucionId As String, ByVal sAreaId As String) As String
        Return TablaGeneralDAS.GetCargoCodigoGenerado(sInstitucionId, sAreaId)
    End Function

    Public Function RequisitosNewCodigo() As String
        Return TablaGeneralDAS.GetRequisitosCodigoGenerado()
    End Function

    Public Function ProcedimientoSTDNewCodigo() As String
        Return TablaGeneralDAS.GetProcedimientoCodigoGenerado()
    End Function

    Public Function TablaGeneralNewCodigo(ByVal ncaracteres As Integer, ByVal clsid As Integer, Optional ByVal tgExtra As Integer = -1) As String
        Return TablaGeneralDAS.GetCodigoGenerado_by_ncaracteres_clsid(ncaracteres, clsid, tgExtra)
    End Function

    Public Function AbonoPEMGeneraCodigo() As String
        Return AbonoPEMDAS.GeneraCodigo()
    End Function
#End Region

#Region "Reglas TablaGeneral"
    Public Function tablageneralActualizar(ByVal aoTablaGeneral As EETablaGeneral) As [Boolean]
        Return TablaGeneralDAO.actualizar(aoTablaGeneral)
    End Function
    Public Function tablageneralUpdate(ByVal aoTablaGeneral As EETablaGeneral) As [Boolean]
        Return TablaGeneralDAO.Update(aoTablaGeneral)
    End Function
    Public Function tablageneralEliminar(ByVal aiIdTablaGeneral As Int32) As [Boolean]
        Return TablaGeneralDAO.eliminar(aiIdTablaGeneral)
    End Function

    Public Function tablageneralinsertar(ByVal aoTablaGeneral As EETablaGeneral) As [Boolean]
        Return TablaGeneralDAO.insertar(aoTablaGeneral)
    End Function

    Public Function tablageneralListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function
    Public Function tablageneralValidaItgCodigo(ByVal aiClsId As Int32, ByVal asTgCodigo As [String]) As [Boolean]
        Return TablaGeneralDAS.ValidaITgCodigo(aiClsId, asTgCodigo)
    End Function
    Public Function tablageneralValidaUtgCodigo(ByVal aiClsId As Int32, ByVal asTgId As Int16, ByVal asTgCodigo2 As [String]) As [Boolean]
        Return TablaGeneralDAS.ValidaUTgCodigo(aiClsId, asTgId, asTgCodigo2)
    End Function
    Public Function tablageneralListarALL() As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarALL()
    End Function

    Public Function tablageneralListarXClsId(ByVal aiClsId As Int32) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarXClsId(aiClsId)
    End Function

    Public Function tablageneralListarXClsId2(ByVal aiClsId As Int32) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarXClsId2(aiClsId)
    End Function

    Public Function tablageneralListarXClasesId(ByVal aiClsId As String) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarXClasesId(aiClsId)
    End Function

    Public Function tablageneralListarXClsIdOrderbytgOrden(ByVal aiClsId As Int32) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarXClsId_OrderBy_tgOrden(aiClsId)
    End Function
    Public Function tablageneralListarXClsIdtgCodigo(ByVal aiClsId As Int32, ByVal asTgcodigo As String) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarXClsIdTgcodigos(aiClsId, asTgcodigo)
    End Function
    Public Function tablageneralListarXClsId_Opcion_tgCodigo_tgAbrev_tgExtra_pa(ByVal aiClsId As Int32, Optional ByVal asTgCodigo As String = Nothing, Optional ByVal asTgAbrev As String = Nothing, Optional ByVal asTgExtra As String = Nothing) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.Listar_XClsId_Opcional_tgCodigo_tgAbrev_tgExtra_pa(aiClsId, asTgCodigo, asTgAbrev, asTgExtra)
    End Function

    Public Function tablageneralListarXClsIdListarCriterio(ByVal aiClsId As Int32, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarXClsIdTgListarCriterio(aiClsId, aiTipoCriterio, asCriterio)
    End Function

    Public Function ListarPisosXInstitucion(ByVal asInstitucion As [String]) As List(Of EETablaGeneral)
        Return PisosPEMDAS.PisosXInstitucion(asInstitucion)
    End Function

    Public Function ListarPisosXPisoId(ByVal asPisos As [String]) As EETablaGeneral
        Return PisosPEMDAS.PisosXPisoId(asPisos)
    End Function

    Public Function tablageneralListarXClsId1_IN_ClsId2_ListarCriterio(ByVal aiClsId1 As Int32, ByVal aiClsId2 As Int32, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarXClsId1_IN_ClsId2_ListarCriterio(aiClsId1, aiClsId2, aiTipoCriterio, asCriterio)
    End Function




    ''' <summary>
    ''' Listar Sub Items Segun ClsId y TgExtra
    ''' </summary>
    ''' <param name="aiClsId">ClsId</param>
    ''' <param name="asTgExtra">TgExtra = TgCodigo Campo Seleccionado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function tablageneralListar_XClsId_XTgExtra(ByVal aiClsId As Int32, ByVal asTgExtra As String) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listar_XClsId_XTgExtra(aiClsId, asTgExtra)
    End Function
    Public Function tablageneralListarXClsIdXTgExtraListarCriterio(ByVal aiClsId As Int32, ByVal asTgCodigo As String, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarXClsIdXTgExtraListarCriterio(aiClsId, asTgCodigo, aiTipoCriterio, asCriterio)
    End Function

    Public Function tablageneralListarXTgAbrev(ByVal asTgAbrev As String) As EETablaGeneral
        Return TablaGeneralDAS.listarXTgAbrev(asTgAbrev)
    End Function

    ''' <summary>
    ''' MUESTRA UN SOLO RESULTADO X ClsId y TgCodigo
    ''' </summary>
    ''' <param name="aiClsId">Clase Id</param>
    ''' <param name="asTgCodigo">TgCodigo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function tablageneralMostrarXClsIdXTgCodigo(ByVal aiClsId As Int32, ByVal asTgCodigo As String) As EETablaGeneral
        Return TablaGeneralDAS.mostrarXClsIdXTgCodigo(aiClsId, asTgCodigo)
    End Function
    Public Function tablageneralListarXClsIdXTgExtraId(ByVal aiClsId As Int32, ByVal asTgExtra As String) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.ListarXClsIdXTgExtraId(aiClsId, asTgExtra)
    End Function

    Public Function tablageneralListarXClsIdCriterios(ByVal aiClsId As Int32, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.listarXClsIdCriterios(aiClsId, aiTipoCriterio, asCriterio)
    End Function

    Public Function tablageneralListarXTgId(ByVal aiTgId As Int32) As EETablaGeneral
        Return TablaGeneralDAS.listarXTgId(aiTgId)
    End Function

    Public Function tablaGeneralInsertarXClsId_TgCodigoAutoGenerado(ByVal aoTablaGeneral As EETablaGeneral) As Boolean
        Return TablaGeneralDAO.insertarXClsId_TgCodigoAutoGenerado(aoTablaGeneral)
    End Function

    Public Function tablageneralMostrarXClsId(ByVal aiClsId As Int32) As List(Of EETablaGeneral)
        Return TablaGeneralDAS.mostrarXClsId(aiClsId)
    End Function
#End Region

#Region "Requisitos"
    'Public Function RequisitosListarxProcId(ByVal asProcId As String) As List(Of EEReqDocumentoSTD)
    '    Return RequerimientoSTDDAS.listarAllByProcId(asProcId)
    'End Function

    Public Function RequisitosListarxProcId(ByVal asProcId As String) As List(Of EETablaGeneral)
        Return RequisitoSTDDAS.listarAllByProcId(asProcId)
    End Function
#End Region

#Region "Ubigeo"
    Public Function ubigeoListarDepartamentoALL() As List(Of EEUbigeo)
        Return UbigeoDAS.listarDepartamentoALL()
    End Function

    Public Function ubigeoListarProvinciaXUbgDep(ByVal asUbgDep As [String]) As List(Of EEUbigeo)
        Return UbigeoDAS.listarProvinciaXUbgDep(asUbgDep)
    End Function

    Public Function ubigeoListarDistritoXUbgDepXUbgProv(ByVal asUbgDep As [String], ByVal asUbgProv As [String]) As List(Of EEUbigeo)
        Return UbigeoDAS.listarDistritoXUbgDepXUbgProv(asUbgDep, asUbgProv)
    End Function
#End Region

#Region "Reglas Persona"
    Public Function personaGeneraCodigo() As String
        Return PersonaDAS.GeneraCodigo()
    End Function
    ''' <summary>
    ''' PERSONA LISTAR CRITERIO
    ''' </summary>
    ''' <param name="aiTipoCriterio">1=DNI,2=RUC</param>
    ''' <param name="asCriterio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function personaListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPersona)
        Return PersonaDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function
    Public Function PersonaContactoXPerId(ByVal PerId As [String]) As EEPersona
        Return PersonaDAS.ConsultarPersonaContactoXPerId(PerId)
    End Function

    Public Function MostrarContactoPersonaXPerIdTgContactoId(ByVal PerId As [String], ByVal tgContactoId As String) As EEPersona.EEContacto
        Return PersonaDAS.MostrarContactoPersonaXPerId_tgContactoId(PerId, tgContactoId)
    End Function

    Public Function personaValidarHomonimia(ByVal aoPersona As EEPersona) As Boolean
        If Not ValidacionDAS.PersonaValidarXNombresORazon(aoPersona.PerId, aoPersona.perNombresoRazon, aoPersona.TgTipoPersId, "S") Then
            Return True
        End If
        Return False
    End Function
    Public Function MostrarPersonaUsuarioxPerId(Optional ByVal PerId As [String] = Nothing) As EEPersona
        Return PersonaDAS.MostrarPersonaUsuarioxPerId(PerId)
    End Function
    Public Function MostrarPersonaUsuario() As List(Of EEPersona)
        Return PersonaDAS.MostrarPersonaUsuario()
    End Function
    Public Function personaGuardar(ByVal aoPersona As EEPersona) As Boolean
        If Not ValidacionDAS.PersonaValidarXPerNDoc(aoPersona.PerId, aoPersona.TgTipoDoc, aoPersona.PerNDoc, "S") Then
            Throw New Exception("El Numero de Documento Ya Existe")
        End If

        Dim longitud As Int16? = Nothing
        'longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perNDoc")
        'If aoPersona.PerNDoc.Length > longitud Then
        '    mExceptionLongitud("Número de Documento", longitud, aoPersona.PerNDoc.Length)
        'End If

        If aoPersona.TgTipoPersId = "N" Then
            longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perNombres")
            If aoPersona.PerNombres.Length > longitud Then
                mExceptionLongitud("Nombres o Razon", longitud, aoPersona.PerNombres.Length)
            End If
            longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perApePaterno")
            If aoPersona.PerApePaterno.Length > longitud Then
                mExceptionLongitud("Ap. Paterno", longitud, aoPersona.PerApePaterno.Length)
            End If
            longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perApeMaterno")
            If aoPersona.PerApeMaterno.Length > longitud Then
                mExceptionLongitud("Ap. Materno", longitud, aoPersona.PerApeMaterno.Length)
            End If
        End If

        If aoPersona.TgTipoPersId = "J" Then
            longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perRazonSocial")
            If aoPersona.PerRazonSocial.Length > longitud Then
                mExceptionLongitud("Nombres o Razon", longitud, aoPersona.PerRazonSocial.Length)
            End If
        End If

        If aoPersona.PerDireccion IsNot Nothing Then
            longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perDireccion")
            If aoPersona.PerDireccion.Length > longitud Then
                mExceptionLongitud("Dirección", longitud, aoPersona.PerDireccion.Length)
            End If
        End If
        Return PersonaDAO.guardar(aoPersona)
    End Function

    Public Function personaActualizar(ByVal aoPersona As EEPersona) As Boolean
        If Not ValidacionDAS.PersonaValidarXPerNDoc(aoPersona.PerId, aoPersona.TgTipoDoc, aoPersona.PerNDoc, "U") Then
            Throw New Exception("El Numero de Documento Ya Existe")
        End If

        Dim longitud As Int16? = Nothing
        'longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perNDoc")
        'If aoPersona.PerNDoc.Length > longitud Then
        '    mExceptionLongitud("Número de Documento", longitud, aoPersona.PerNDoc.Length)
        'End If

        If aoPersona.TgTipoPersId = "N" Then
            longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perNombres")
            If aoPersona.PerNombres.Length > longitud Then
                mExceptionLongitud("Nombres o Razon", longitud, aoPersona.PerNombres.Length)
            End If
            longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perApePaterno")
            If aoPersona.PerApePaterno.Length > longitud Then
                mExceptionLongitud("Ap. Paterno", longitud, aoPersona.PerApePaterno.Length)
            End If
            longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perApeMaterno")
            If aoPersona.PerApeMaterno.Length > longitud Then
                mExceptionLongitud("Ap. Materno", longitud, aoPersona.PerApeMaterno.Length)
            End If
        End If

        If aoPersona.TgTipoPersId = "J" Then
            longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perRazonSocial")
            If aoPersona.PerRazonSocial.Length > longitud Then
                mExceptionLongitud("Nombres o Razon", longitud, aoPersona.PerRazonSocial.Length)
            End If
        End If

        If aoPersona.PerDireccion IsNot Nothing Then
            longitud = ValidacionDAS.ValidarCampoLongitud("Persona", "perDireccion")
            If aoPersona.PerDireccion.Length > longitud Then
                mExceptionLongitud("Dirección", longitud, aoPersona.PerDireccion.Length)
            End If
        End If
        Return PersonaDAO.actualizar(aoPersona)
    End Function

    ''' <summary>
    ''' Consultar Conyuge X Nombre, Paterno o Materno
    ''' </summary>
    ''' <param name="asPerTexto">Texto a Buscar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function personaConsultarConyuge(ByVal asPerTexto As [String]) As List(Of EEPersona)
        Return PersonaDAS.ConsultarConyuge(asPerTexto)
    End Function

    Public Function personaListarXPerId(ByVal asPerId As [String]) As EEPersona
        Return PersonaDAS.listarxPerId(asPerId)
    End Function

    Public Function personaMostrarNombresXPerId(ByVal asPerId As [String]) As String
        Return PersonaDAS.MostrarNombresxPerId(asPerId)
    End Function

    Public Function personaListarCriterioProgramacionPagos(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPersona)
        Return PersonaDAS.listarCriterioProgramacionPagos(aiTipoCriterio, asCriterio)
    End Function

    Public Function personaConsultarProveedor(ByVal asPerTexto As [String]) As List(Of EEPersona)
        Return PersonaDAS.ConsultarProveedor(asPerTexto)
    End Function

    Public Function personaConsultarProveedorCriterios(ByVal aiTipoCriterio As [String], ByVal asCriterio As String) As List(Of EEPersona)
        Return PersonaDAS.ConsultarProveedorCriterios(aiTipoCriterio, asCriterio)
    End Function

    Public Function personaConsultarPersonaUsuario(ByVal asPerTexto As [String]) As List(Of EEPersona)
        Return PersonaDAS.ConsultarPersonaUsuario(asPerTexto)
    End Function

    Public Function personaListarCriterioConsultaProgramacionPagos(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPersona)
        Return PersonaDAS.listarCriterioConsultaProgramacionPagos(aiTipoCriterio, asCriterio)
    End Function

    Public Function personaConsultaryCreaXtgTipoDo_perNDoc(ByVal aoPersona As EEPersona) As String
        Return PersonaDAO.Existe_y_creaXtgTipoDoc_y_perNDoc(aoPersona)
    End Function
    ' CarPerId => Institucion & Area & CargosNewCodigo
    Public Function personaListarXCargoId(Optional ByVal carPerID As [String] = Nothing) As List(Of EEPersona)
        Return PersonaDAS.ListarXCargoId(carPerID)
    End Function
    Public Function personaListarXDocSTD_Id(ByVal docID As [String]) As List(Of EEPersona)
        Return PersonaDAS.ListarX_DocSTD_Id(docID)
    End Function

    Public Function personaListarCriterioAbonados(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], Optional ByVal asCriterio1 As String = Nothing) As List(Of EEPersona)
        Return PersonaDAS.listarCriterioAbonados(aiTipoCriterio, asCriterio, asCriterio1)
    End Function

    ''' <summary>
    ''' Elimina Persona Cambiando de estado PerEliminado
    ''' </summary>
    ''' <param name="asPerId">PerId</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function personaEliminar(ByVal asPerId As String) As Boolean
        Return PersonaDAO.eliminar(asPerId)
    End Function

    ''' <summary>
    ''' CONSULTAR PERSONA GENERAL
    ''' </summary>
    ''' <param name="aiTipoPersona">1=PERSONA NATURAL, 2=PERSONA JURIDICA, 3=AMBOS</param>
    ''' <param name="asCriterio">TEXTO A CONSULTAR</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function personaConsultarGeneral(ByVal aiTipoPersona As Int16, ByVal aiTipoCriterio As Int16, ByVal asCriterio As String) As List(Of EEPersona)
        Return PersonaDAS.consultarGeneral(aiTipoPersona, aiTipoCriterio, asCriterio)
    End Function

    Public Function ConsultarPerVehiculoPEMCriterio(ByVal aiTipoPersona As Int16, ByVal asCriterio As String) As List(Of EEPersona)
        Return PersonaDAS.consultarPerVehiculo(aiTipoPersona, asCriterio)
    End Function

    Public Function personaConsultarDetalleAbono(ByVal aiTipoCriterio As Int16, ByVal asCriterio As String) As List(Of EEPersona)
        Return PersonaDAS.consultarDetalleAbono(aiTipoCriterio, asCriterio)
    End Function
#End Region

#Region "Inmueble Update"
    Public Function inmuebleUpdateGuardar(ByVal aoInmueble As EEInmueble.EEInmLogs) As [Boolean]
        Return InmUpdateDAO.guardar(aoInmueble)
    End Function

    Public Function inmuebleUpdateGuardarBaja(ByVal aoInmueble As EEInmueble.EEInmLogs) As [Boolean]
        Return InmUpdateDAO.guardarBaja(aoInmueble)
    End Function

    Public Function inmuebleUpdateActualizar(ByVal aoInmueble As EEInmueble.EEInmLogs) As [Boolean]
        Return InmUpdateDAO.Update(aoInmueble)
    End Function

    Public Function inmuebleUpdateActualizarObservacion(ByVal aoInmueble As EEInmueble.EEInmLogs) As [Boolean]
        Return InmUpdateDAO.UpdateObservacion(aoInmueble)
    End Function

    Public Function inmuebleUpdateEliminar(ByVal InmUpdDetId As Integer) As [Boolean]
        Return InmUpdateDAO.EliminarXinmUpdDetId(InmUpdDetId)
    End Function


    Public Function inmuebleUpdateTraspaso_Inmueble(ByVal inmUpdId As String) As [Boolean]
        Return InmUpdateDAO.Update_Traspaso_Inmueble(inmUpdId)
    End Function

    Public Function inmuebleUpdateListarxCriterios(ByVal tpCriterio As String, ByVal criterio As String, Optional ByVal anio As String = Nothing) As List(Of EEInmueble.EEInmLogs)
        Return InmUpdateDAS.listarXcriterio(tpCriterio, criterio, anio)
    End Function

    Public Function inmuebleUpdateMostrarIsPendienteXInmId(ByVal inmId As String) As List(Of EEInmueble.EEInmLogs)
        Return InmUpdateDAS.IsPendienteXInmId(inmId)
    End Function


    Public Function inmuebleUpdateMostrarInmUpdDocXInmId(ByVal inmId As String) As String
        Return InmUpdateDAS.InmUpdDocXInmId(inmId)
    End Function

    Public Function inmuebleUpdateProcesadosListarxCriterios(ByVal aoVariablesConsultas As EECriterios) As List(Of EEInmueble.EEInmLogs)
        Return InmUpdateDAS.ProcesadoslistarXcriterio(aoVariablesConsultas)
    End Function

    Public Function inmuebleUpdateListarCriteriosBusquedas(ByVal tp As Integer, ByVal c As String) As List(Of EEInmueble.EEInmLogs)
        Return InmUpdateDAS.listarCriteriosBuscar(tp, c)
    End Function

    Public Function inmuebleUpdateMostrarInmUpdatexInmUpdId(ByVal InmUpdId As String) As EEInmueble.EEInmLogs
        Return InmUpdateDAS.InmUpdateXInmUpdId(InmUpdId)
    End Function


    Public Function inmuebleUpdateMostrarInmUpdDetCampoTextxInmUpdId(ByVal InmUpdId As String) As List(Of EEInmueble.EEInmLogs.EEInmLogsDet)
        Return InmUpdateDAS.InmUpdDetCampoTextXInmUpdId(InmUpdId)
    End Function



    Public Function inmuebleUpdateMostrarInmUpdValorOld_NewxInmUpdId(ByVal InmUpdDetId As String) As EEInmueble.EEInmLogs.EEInmLogsDet
        Return InmUpdateDAS.InmUpdDetValorOld_NewXInmUpdDetId(InmUpdDetId)
    End Function
#End Region

#Region "Reglas Inmueble"
    Public Function inmuebleGuardar(ByVal aoInmueble As EEInmueble) As [Boolean]
        Return InmuebleDAO.guardar(aoInmueble)
    End Function

    Public Function inmuebleGuardarAlta(ByVal aoInmueble As EEInmueble) As [Boolean]
        Return InmuebleDAO.guardarAlta(aoInmueble)
    End Function
    'Public Function inmuebleActualizarBaja(ByVal aoInmueble As EEInmueble) As [Boolean]
    '    Return InmuebleDAO.guardarBaja(aoInmueble)
    'End Function
    Public Function inmuebleActualizar(ByVal aoInmueble As EEInmueble) As [Boolean]
        Return InmuebleDAO.actualizar(aoInmueble)
    End Function

    Public Function inmuebleActualizarAlta(ByVal aoInmueble As EEInmueble) As [Boolean]
        Return InmuebleDAO.actualizarAlta(aoInmueble)
    End Function

    ' Todas las opciones para busquedas rapidas
    Public Function inmuebleListarBCriterio(Optional ByVal tgRubroId As String = Nothing, Optional ByVal tgGRubroId As String = Nothing, Optional ByVal file As String = Nothing, Optional ByVal fileA As String = Nothing, Optional ByVal direccion As String = Nothing, Optional ByVal inmId As String = Nothing, Optional ByVal inmDenominacion As String = Nothing, Optional ByVal tgInmEstado As String = Nothing, Optional ByVal NtgInmEstado As String = Nothing) As List(Of EEInmueble)
        Return InmuebleDAS.listarBCriterio(tgRubroId, tgGRubroId, file, fileA, direccion, inmId, inmDenominacion, tgInmEstado, NtgInmEstado)
    End Function
    Public Function inmuebleListarBajas() As List(Of EEInmueble)
        Return InmuebleDAS.listarBajas()
    End Function

    Public Function inmuebleListarBajas_BCriterio(Optional ByVal tgRubroId As String = Nothing, Optional ByVal tgGRubroId As String = Nothing, Optional ByVal file As String = Nothing, Optional ByVal fileA As String = Nothing, Optional ByVal direccion As String = Nothing, Optional ByVal inmDenominacion As String = Nothing) As List(Of EEInmueble)
        Return InmuebleDAS.listarBajas_BCriterios(tgRubroId, tgGRubroId, file, fileA, direccion, inmDenominacion)
    End Function

    Public Function inmuebleListarXAnio_tgRubroId(ByVal anio As String, Optional ByVal tgRubroId As String = Nothing) As List(Of EEInmueble)
        Return InmuebleDAS.listarByAnio_TgRubroId(anio, tgRubroId)
    End Function

    Public Function inmuebleListarAltasXAnio_tgGRubroId(ByVal anio As String, Optional ByVal tgGRubroId As String = Nothing) As List(Of EEInmueble)
        Return InmuebleDAS.listarAltasByAnio_TgGRubroId(anio, tgGRubroId)
    End Function
    Public Function inmuebleListarBajasXAnio_tgGRubroId(ByVal anio As String, Optional ByVal tgGRubroId As String = Nothing) As List(Of EEInmueble)
        Return InmuebleDAS.listarBajasByAnio_TgGRubroId(anio, tgGRubroId)
    End Function

    Public Function inmuebleMostrarTotalesByAnio(ByVal anio As String) As EEInmueble.EEVariablesRpt
        Return InmuebleDAS.MostrarTotalesByAnio(anio)
    End Function


    Public Function inmuebleListarAltas() As List(Of EEInmueble)
        Return InmuebleDAS.listarAltas()
    End Function

    Public Function inmuebleListarAltasMargesi_BCriterio(Optional ByVal tgRubroId As String = Nothing, Optional ByVal tgGRubroId As String = Nothing, Optional ByVal direccion As String = Nothing) As List(Of EEInmueble)
        Return InmuebleDAS.listarAltasMargesi_BCriterios(tgRubroId, tgGRubroId, direccion)
    End Function


    Public Function inmuebleListarTrasferidosBCriterio(Optional ByVal tgRubroId As String = Nothing, Optional ByVal tgGRubroId As String = Nothing, Optional ByVal file As String = Nothing, Optional ByVal fileA As String = Nothing, Optional ByVal direccion As String = Nothing, Optional ByVal inmId As String = Nothing, Optional ByVal inmDenominacion As String = Nothing) As List(Of EEInmueble)
        Return InmuebleDAS.listarTrasnferidoBCriterio(tgRubroId, tgGRubroId, file, fileA, direccion, inmId, inmDenominacion)
    End Function

    Public Function inmuebleAltaListarBCriterio(Optional ByVal perRegID As String = Nothing, Optional ByVal tgRubroId As String = Nothing, Optional ByVal tgGRubroId As String = Nothing, Optional ByVal direccion As String = Nothing) As List(Of EEInmueble)
        Return InmuebleDAS.listarAltaBCriterio(perRegID, tgRubroId, tgGRubroId, direccion)
    End Function

    Public Function inmuebleListarBCriterio_EnContrato(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEInmueble)
        Return InmuebleDAS.listarBCriterioEnContrato(aiTipoCriterio, asCriterio)
    End Function


    Public Function inmuebleEliminar(ByVal aiIdInmueble As Int32) As [Boolean]
        Return InmuebleDAO.eliminar(aiIdInmueble)
    End Function

    Public Function inmuebleListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEInmueble)
        Return InmuebleDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function inmuebleListarXUbicacionSql(ByVal asCriterio As [String]) As List(Of EEInmueble)
        Return InmuebleDAS.inmuebleListarXUbicacionSql(asCriterio)
    End Function

    Public Function inmuebleListarConsultaImgCriterios(ByVal tipocriterio As String, ByVal aoInmueble As EEInmueble) As List(Of EEInmueble)
        Return InmuebleDAS.listarConsultaImgCriterio(tipocriterio, aoInmueble)
    End Function

    Public Function inmuebleListarConsultaCriterios(ByVal tipocriterio As String, ByVal aoInmueble As EEInmueble) As List(Of EEInmueble)
        Return InmuebleDAS.listarConsultaCriterio(tipocriterio, aoInmueble)
    End Function

    Public Function inmuebleListarConsultaCriteriosxItem(ByVal tipocriterio As String, ByVal aoInmueble As EEInmueble) As List(Of EEInmueble)
        Return InmuebleDAS.listarConsultaCriterioxItem(tipocriterio, aoInmueble)
    End Function

    Public Function inmuebleListarConsultaWebCriterios(ByVal aoInmueble As EEInmueble) As List(Of EEInmueble)
        Return InmuebleDAS.listarConsultaWebCriterio(aoInmueble)
    End Function

    Public Function inmuebleListarConsultaAltasyBajas(ByVal tipocriterio As String, ByVal tgGRubroId As String, ByVal tgRubroId As String, Optional ByVal inicio As Date = Nothing, Optional ByVal fin As Date = Nothing, Optional ByVal inmFile As String = Nothing, Optional ByVal INmFileAnt As String = Nothing) As List(Of EEInmueble)
        Return InmuebleDAS.listarConsultaAltasyBajas(tipocriterio, tgGRubroId, tgRubroId, inicio, fin, inmFile, INmFileAnt)
    End Function

    Public Function inmuebleListarConsultaCriteriosWebDireccion(ByVal aoInmueble As EEInmueble) As List(Of EEInmueble)
        Return InmuebleDAS.listarConsultaCriterioWebDireccion(aoInmueble)
    End Function
    'Public Function inmuebleListarALL() As List(Of EEInmueble)
    '    Return InmuebleDAS.listarALL()
    'End Function

    Public Function inmuebleListarCriterioConsultaProgramacionPagos(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEInmueble)
        Return InmuebleDAS.listarCriterioConsultaProgramacionPagos(aiTipoCriterio, asCriterio)
    End Function



    Public Function inmuebleListarXInmId(ByVal asInmId As [String]) As EEInmueble
        Return InmuebleDAS.MostrarXInmId(asInmId)
    End Function

    Public Function inmuebleMostrarXInmId(ByVal asInmId As [String]) As EEInmueble
        Return InmuebleDAS.MostrarXInmId(asInmId)
    End Function

    Public Function inmuebleAltaMostrarXInmId(ByVal asInmId As [String]) As EEInmueble
        Return InmuebleDAS.MostrarAltaXInmId(asInmId)
    End Function

    Public Function inmuebleBajaMostrarXInmId(ByVal asInmId As [String]) As EEInmueble
        Return InmuebleDAS.MostrarBajaXInmId(asInmId)
    End Function

    Public Function inmuebleMostrarDatosBajaXInmId(ByVal asInmId As [String]) As EEInmueble.EEInmBajas
        Return InmuebleDAS.MostrarDatosBajaXInmId(asInmId)
    End Function

    Public Function inmuebleMostrarInmArchXInmArchId(ByVal InmArchId As [String]) As EEInmArchivos
        Return InmuebleDAS.MostrarInmArchXInmArchId(InmArchId)
    End Function

    ''' <summary>
    ''' Actualizar Proceso Judicial
    ''' </summary>
    ''' <param name="aoInmPJudiciales"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function inmuebleActualizarPJ(ByVal aoInmPJudiciales As EEInmPJudiciales) As Boolean
        Return InmuebleDAO.actualizarPJ(aoInmPJudiciales)
    End Function

    ''' <summary>
    ''' Guardar Proceso Judicial
    ''' </summary>
    ''' <param name="aoInmueble"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function inmuebleGuardarPJ(ByVal aoInmueble As EEInmueble) As Boolean
        Return InmuebleDAO.guardarPJ(aoInmueble)
    End Function

    Public Function inmuebleGuardarArchivos(ByVal aoInmueble As EEInmueble) As Boolean
        Return InmuebleDAO.guardarArchivos(aoInmueble)
    End Function

    Public Function inmuebleGeneraCodigoInmFilexTgRubroId(ByVal TgRubroId As String) As String
        Return InmuebleDAS.GenerarCodigoInmFile(TgRubroId)
    End Function

    Public Function inmuebleGeneraCodigoInmId() As String
        Return InmuebleDAS.GenerarCodigoInmId()
    End Function

    Public Function inmuebleActualizar_tgInmEstadoxInmId(ByVal InmId As String, ByVal tgInmEstado As String) As Boolean
        Return InmuebleDAO.ActualizarTgInmEstadoxInmId(InmId, tgInmEstado)
    End Function
#End Region

#Region "Sistema de Tramite Documentario web"
    Public Function documentosSTD_ListarConsultaCriterios(ByVal docFechaIng As Date, ByVal docFechaFin As Date, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.listarCriterio(docFechaIng, docFechaFin, aiTipoCriterio, asCriterio)
    End Function

    Public Function documentosSTD_ListarConsultaxDependencia(ByVal docFechaIng As Date, ByVal docFechaFin As Date, ByVal dependencia As [String], Optional ByVal area As String = "", Optional ByVal resultado As String = "") As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.listarCriterioXDependencia(docFechaIng, docFechaFin, dependencia, area, resultado)
    End Function

    Public Function documentosSTD_ListarConsultaxInteresadoProcedimientoAsunto(ByVal docFechaIng As Date, ByVal docFechaFin As Date, ByVal interesado As [String], Optional ByVal procId As String = "", Optional ByVal asunto As String = "") As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.listarCriterioXInteresadoProcedimientoAsunto(docFechaIng, docFechaFin, interesado, procId, asunto)
    End Function

    Public Function documentosSTD_ListarConsultaxMovPerParaDocEstado(ByVal docFechaIng As Date, ByVal docFechaFin As Date, ByVal movPerIdPara As [String], ByVal docEstado As String) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.listarCriterioXMovPerParaDocEstado(docFechaIng, docFechaFin, movPerIdPara, docEstado)
    End Function

    Public Function documentosSTD_MostrarDatosExpedientexFiltros_pa(ByVal loParametrosRptResumidoSTD As EERptResumidoSTD) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.MostrarDatosExpedientexFiltros_pa(loParametrosRptResumidoSTD)
    End Function

    Public Function documentosSTD_MostrarDatosExpedientexNroExpediente_Anio_Dependencia(ByVal NroExpediente As String, ByVal Anio As String, ByVal dependencia As String) As EEDocumentoSTD
        Return DocumentoSTDDAS.MostrarDatosXExpediente_Anio_Dependencia(NroExpediente, Anio, dependencia)
    End Function


    Public Function movimientosSTD_ListarMovimientosxDocId(ByVal DocId As String) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.listarxDocId(DocId)
    End Function

    'Consultas 
    Public Function documentosSTD_MostrarDetalleExpedientexDocAsunto(ByVal DocAsunto As String, Optional ByVal Anio As String = Nothing) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.MostrarDetalleExpedienteXdocAsunto(DocAsunto, Anio)
    End Function

    Public Function documentosSTD_MostrarDetalleExpedientexNroReg(ByVal NroReg As String, Optional ByVal Anio As String = Nothing) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.MostrarDetalleExpedienteXNroReg(NroReg, Anio)
    End Function

    Public Function documentosSTD_MostrarDetalleExpedienteXTgInstitucionId(ByVal TgInstitucionPerInt As String, Optional ByVal Anio As String = Nothing) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.MostrarDetalleExpedienteXtgIntitucionId(TgInstitucionPerInt, Anio)
    End Function
    Public Function documentosSTD_MostrarDetalleExpedienteXPerIntId(ByVal perIntId As String, Optional ByVal Anio As String = Nothing) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.MostrarDetalleExpedienteXPerIntId(perIntId, Anio)
    End Function

#End Region

#Region "Programacion de Pagos"
    ''' <summary>
    ''' Guardar Programacion de Pagos
    ''' </summary>
    ''' <param name="aoProPagos">Objeto EEProPagos</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function proPagosGuardar(ByVal aoProPagos As EEProPagos) As Boolean
        Return ProPagosDAO.guardar(aoProPagos)
    End Function

    Public Function proPagosListarNroCuotasNoPagadasXConInmId(ByVal asConInmId As [String]) As List(Of EEProPagos)
        Return ProPagosDAS.listarNroCuotasNoPagadasXConInmId(asConInmId)
    End Function

    Public Function proPagosMostrarNroCuotasALLXConInmId(ByVal asConInmId As [String]) As Int32
        Return ProPagosDAS.mostrarNroCuotasALLXConInmId(asConInmId)
    End Function

    Public Function proPagosListarXConInmIdConsultaProgramacionPagos(ByVal asConInmId As [String]) As List(Of EEProPagos)
        Return ProPagosDAS.listarXConInmIdConsultaProgramacionPagos(asConInmId)
    End Function

    Public Function proPagosListarProPagosDetalleXProPaId(ByVal asProPaId As [String]) As List(Of EEProPagos)
        Return ProPagosDAS.listarProPagosDetalleXProPaId(asProPaId)
    End Function

    Public Function proPagosActualizar(ByVal aoProPagos As EEProPagos) As [Boolean]
        Return ProPagosDAO.actualizar(aoProPagos)
    End Function

    Public Function proPagosMostrarProPagosMontoTotalXEstadoXConInmIdConsultaProgramacionPagos(ByVal asConInmId As [String], ByVal asEstado As [String], Optional ByVal asNiConId As [String] = Nothing) As Decimal
        Return ProPagosDAS.mostrarProPagosMontoTotalXEstadoXConInmIdConsultaProgramacionPagos(asConInmId, asEstado)
    End Function

    Public Function proPagosImportar(ByVal aoProPagos As EEProPagos) As Boolean
        Return ProPagosDAO.importar(aoProPagos)
    End Function

    Public Function proPagosExportar() As List(Of EETemp_ProPagos)
        Return ProPagosDAS.exportar()
    End Function

    Public Function proPagosReporte_OrdenPagoCab(ByVal aoProPaId As String) As List(Of EEProPagos)
        Return ProPagosDAS.Reporte_ProPagosXPropaId(aoProPaId)
    End Function
    Public Function proPagosListarDetraccionesXPersonaXAño(ByVal asPersona As String, ByVal asAño As String) As List(Of EEProPagos)
        Return ProPagosDAS.listarDetraccionesXPersonaXAño(asPersona, asAño)
    End Function

    Public Function proPagosListarDetraccionesXMesXAño(ByVal asMes As String, ByVal asAño As String) As List(Of EEProPagos)
        Return ProPagosDAS.listarDetraccionesXMesXAño(asMes, asAño)
    End Function

    Public Function proPagosActualizarDetracciones(ByVal alProPaIds As List(Of String)) As Boolean
        Return ProPagosDAO.actualizarDetracciones(alProPaIds)
    End Function

    Public Function proPagosListarGeneracionOrdenesPagoCriterio(ByVal asEstCompId As String, Optional ByVal asAnio As [String] = Nothing, Optional ByVal asMes As [String] = Nothing, Optional ByVal asCliente As [String] = Nothing) As List(Of EEProPagos)
        Return ProPagosDAS.listarGeneracionOrdenesPagoCriterio(asEstCompId, asAnio, asMes, asCliente)
    End Function

    Public Function proPagosListarOrdenesPagoCriterio(Optional ByVal asAnio As [String] = Nothing, Optional ByVal asMes As [String] = Nothing, Optional ByVal asCliente As [String] = Nothing, Optional ByVal asNrocomp As [String] = Nothing) As List(Of EEProPagos)
        Return ProPagosDAS.listarOrdenesPagoCriterio(asAnio, asMes, asCliente, asNrocomp)
    End Function

    Public Function CompProgramacionValidarSugerir(ByVal asNroCompI As Integer, ByVal asNroCompF As Integer, ByVal Serie As String) As List(Of EECompProgramacion)
        Return CompProgramacionDAS.ValidarSugerir(asNroCompI, asNroCompF, Serie)
    End Function
    Public Function AñosProgPagos() As List(Of EEProPagos)
        Return ProPagosDAS.AñosProgPagos()
    End Function

    Public Function proPagosListarAñosProPagos_EnPivotProPagos() As List(Of String)
        Return ProPagosDAS.listarAñosProPagos_EnPivotProPagos()
    End Function

    Public Function proPagosListarProPagosDetalleXProPaIdXEstado_EnConsultarMora(ByVal asProPaId As String, ByVal asEstado As String) As List(Of EEProPagos)
        Return ProPagosDAS.listarProPagosDetalleXProPaIdXEstado_EnConsultarMora(asProPaId, asEstado)
    End Function

    Public Function proPagosMostrarMercedCondutivaXProPaId_EnConsultarMora(ByVal lsProPaId As String) As Decimal
        Return ProPagosDAS.mostrarMercedCondutivaXProPaId_EnConsultarMora(lsProPaId)
    End Function
#End Region

#Region "Reglas ContratoInm"
    Public Function contratoInmGuardar(ByVal aoContratoInm As EEContratoInm) As String
        Return ContratoInmDAO.guardar(aoContratoInm)
    End Function

    Public Function contratoInmGuardarGProgramacion(ByVal aoContratoInm As EEContratoInm) As String
        Return ContratoInmDAO.guardaryGProgramacion(aoContratoInm)
    End Function

    Public Function contratoInmActualizar(ByVal aoContratoInm As EEContratoInm) As [Boolean]
        Return ContratoInmDAO.actualizar(aoContratoInm)
    End Function

    Public Function contratoInmCancelarContrato(ByVal aoContratoInm As EEContratoInm) As Boolean
        Return ContratoInmDAO.cancelarContrato(aoContratoInm)
    End Function

    Public Function contratoInmEliminar(ByVal aiIdContratoInm As Int32) As [Boolean]
        Return ContratoInmDAO.eliminar(aiIdContratoInm)
    End Function

    Public Function contratoInmListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEContratoInm)
        Return ContratoInmDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function contratoInmListarALL() As List(Of EEContratoInm)
        Return ContratoInmDAS.listarALL()
    End Function

    Public Function contratoInmListarXPerIdProgramacionPagos(ByVal asPerId As String) As List(Of EEContratoInm)
        Return ContratoInmDAS.listarXPerIdProgramacionPagos(asPerId)
    End Function

    Public Function contratoInmListarXConInmIdProgramacionPagos(ByVal asConInmId As [String]) As EEContratoInm
        Return ContratoInmDAS.listarXConInmIdProgramacionPagos(asConInmId)
    End Function

    Public Function contratoInmListarXanio(ByVal asAnio As String) As List(Of EEContratoInm)
        Return ContratoInmDAS.listarXAnio(asAnio)
    End Function
    Public Function contratoInmListarDifAnteriorXanio(ByVal asAnio As String) As List(Of EEContratoInm)
        Return ContratoInmDAS.listarDiferenciaAnteriorXAnio(asAnio)
    End Function
    Public Function contratoInmListarXPerId(ByVal asPerId As String) As List(Of EEContratoInm)
        Return ContratoInmDAS.listarXPerId(asPerId)
    End Function

    Public Function contratoInmListarXPerId_O_XInmIdConsultaProgramacionPagos(ByVal asPerId As String, ByVal asInmId As String) As List(Of EEContratoInm)
        Return ContratoInmDAS.listarXPerId_O_XInmIdConsultaProgramacionPagos(asPerId, asInmId)
    End Function

    ''' <summary>
    ''' Listar Contratos Por InmId en Inmuebles
    ''' </summary>
    ''' <param name="asInmId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function contratoInmListarXInmId_EnInmuebles(ByVal asInmId As String) As List(Of EEContratoInm)
        Return ContratoInmDAS.listarXInmId_EnInmuebles(asInmId)
    End Function

    Public Function ContratoDatosAdicionalesXConInmId(ByVal ConInmId As String) As List(Of EEContratoInm)
        Return ContratoInmDAS.listarDatosAdicionalesXConInmId(ConInmId)
    End Function

    Public Function contratoListarCriterioEnConsultaContratoPP(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEContratoInm)
        Return ContratoInmDAS.listarCriterioEnConsultaContratoPP(aiTipoCriterio, asCriterio)
    End Function

    ''' <summary>
    ''' Muestra El Contrato Con su Programación de Pagos Respectivo
    ''' </summary>
    ''' <param name="asPerId">PerId</param>
    ''' <param name="asConInmId">ConInmId</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function contratoMostrarXPerIdXConInmId_EnConsultarMora(ByVal asPerId As String, ByVal asConInmId As String) As List(Of EEContratoInm)
        Return ContratoInmDAS.mostrarXPerIdXConInmId_EnConsultarMora(asPerId, asConInmId)
    End Function

    Public Function contratoListarArchivosXConInmId(ByVal asConInmId As [String]) As List(Of EEConArchivos)
        Return ContratoInmDAS.listarArchivosXConInmId(asConInmId)
    End Function

    Public Function contratoInmMostrarXConInmId(ByVal asConInmId As [String]) As EEContratoInm
        Return ContratoInmDAS.mostrarXConInmId(asConInmId)
    End Function

    Public Function contratoInmMostrarMercedConductivaXPerId_InmId(ByVal asPerId As [String], ByVal asInmId As String) As Decimal
        Return ContratoInmDAS.mostrarMercedConductivaXPerId_InmId(asPerId, asInmId)
    End Function
    Public Function ReporteProgramacionPagDet_XconInmId(ByVal conInmId As String) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.reporteProgramacionPagosDetXconInmId(conInmId)
    End Function

#End Region

#Region "Reglas Prueba"
    Public Function pruebaGuardar(ByVal aoPrueba As EEPrueba) As [Boolean]
        Return PruebaDAO.guardar(aoPrueba)
    End Function

    Public Function pruebaActualizar(ByVal aoPrueba As EEPrueba) As [Boolean]
        Return PruebaDAO.actualizar(aoPrueba)
    End Function

    Public Function pruebaEliminar(ByVal aiIdPrueba As Int32) As [Boolean]
        Return PruebaDAO.eliminar(aiIdPrueba)
    End Function

    Public Function pruebaListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPrueba)
        Return PruebaDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function pruebaListarALL() As List(Of EEPrueba)
        Return PruebaDAS.listarALL()
    End Function
#End Region

#Region "Reglas Usuarios"
    Private loEncriptador As CCryptorEngine = New CCryptorEngine()
    Public Function usuariosGuardar(ByVal aoUsuarios As EEUsuarios) As [Boolean]
        Dim longitud As Int16? = Nothing

        If aoUsuarios.UsuLogin.Length < 6 Then
            Throw New Exception("El Usuario debe tener al menos 6 caracteres")
        End If

        longitud = ValidacionDAS.ValidarCampoLongitud("Usuarios", "usuLogin")
        If aoUsuarios.UsuLogin.Length > longitud Then
            mExceptionLongitud("Usuario", longitud, aoUsuarios.UsuLogin.Length)
        End If

        If aoUsuarios.UsuPassword.Length < 6 Then
            Throw New Exception("El Password debe tener al menos 6 caracteres")
        End If

        longitud = ValidacionDAS.ValidarCampoLongitud("Usuarios", "usuPassword")
        If aoUsuarios.UsuPassword.Length > longitud Then
            mExceptionLongitud("Password", longitud, aoUsuarios.UsuPassword.Length)
        End If

        If ValidacionDAS.UsuariosValidarXUsuLogin(aoUsuarios.UsuLogin, aoUsuarios.UsuId) Then
            aoUsuarios.UsuPassword = loEncriptador.Encriptar(aoUsuarios.UsuPassword)
            Return UsuariosDAO.guardar(aoUsuarios)
        Else
            Throw New Exception("El Usuario Ya Existe")
        End If
    End Function

    Public Function usuariosActualizar(ByVal aoUsuarios As EEUsuarios) As [Boolean]
        Dim longitud As Int16? = Nothing

        If aoUsuarios.UsuLogin.Length < 6 Then
            Throw New Exception("El Usuario debe tener al menos 6 caracteres")
        End If

        longitud = ValidacionDAS.ValidarCampoLongitud("Usuarios", "usuLogin")
        If aoUsuarios.UsuLogin.Length > longitud Then
            mExceptionLongitud("Usuario", longitud, aoUsuarios.UsuLogin.Length)
        End If

        If aoUsuarios.UsuPassword.Length < 6 Then
            Throw New Exception("El Password debe tener al menos 6 caracteres")
        End If

        longitud = ValidacionDAS.ValidarCampoLongitud("Usuarios", "usuPassword")
        If aoUsuarios.UsuPassword.Length > longitud Then
            mExceptionLongitud("Password", longitud, aoUsuarios.UsuPassword.Length)
        End If

        If ValidacionDAS.UsuariosValidarXUsuLogin(aoUsuarios.UsuLogin, aoUsuarios.UsuId) Then
            aoUsuarios.UsuPassword = loEncriptador.Encriptar(aoUsuarios.UsuPassword)
            Return UsuariosDAO.actualizar(aoUsuarios)
        Else
            Throw New Exception("El Usuario Ya Existe")
        End If
    End Function

    Public Function usuariosEliminar(ByVal aiIdUsuarios As Int32) As [Boolean]
        Return UsuariosDAO.eliminar(aiIdUsuarios)
    End Function

    Public Function usuariosListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEUsuarios)
        Return UsuariosDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function usuariosLogin(ByVal asUsuario As String, ByVal asPassword As String) As EEUsuarios
        If asUsuario Is Nothing Then
            Throw New Exception("Ingrese Usuario")
        End If
        If asUsuario.Length = 0 Then
            Throw New Exception("El Usuario no puede tener espacios en blanco")
        End If
        If asPassword Is Nothing Then
            Throw New Exception("Ingrese Password")
        End If
        If asPassword.Length = 0 Then
            Throw New Exception("El Password no puede tener espacios en blanco")
        End If

        asPassword = loEncriptador.Encriptar(asPassword)
        Return UsuariosDAS.login(asUsuario, asPassword)
    End Function

    Public Function FechaServidor() As Date
        Return UsuariosDAS.login()
    End Function

    Public Function usuariosCambiarPassword(ByVal aiIdUsuario As Integer, ByVal asAntiguoPassword As String, ByVal asNuevoPassword As String) As Boolean
        If asAntiguoPassword Is Nothing Then
            Throw New Exception("Ingrese Antiguo Password")
        End If
        If asNuevoPassword Is Nothing Then
            Throw New Exception("Ingrese Nuevo Password")
        End If
        If Not UsuariosDAS.verificarAntiguoPassword(aiIdUsuario, loEncriptador.Encriptar(asAntiguoPassword)) Then
            Throw New Exception("El Antiguo Password no coincide con el Actual")
        End If

        asNuevoPassword = loEncriptador.Encriptar(asNuevoPassword)
        Return UsuariosDAO.cambiarPassword(aiIdUsuario, asNuevoPassword)
    End Function

    Public Function usuariosListarActualizarPermisos_XUsuId(ByVal aiUsuId As Int32) As EEUsuarios
        Return UsuariosDAS.listarActualizarPermisos_XUsuId(aiUsuId)
    End Function

#Region "Desencriptar Password para mostrarlo en los listados"
    Private Shared loDesencriptador As CCryptorEngine
    Public Shared Function mDesencriptarPassword(ByVal asPassword As String) As String
        If loDesencriptador Is Nothing Then
            loDesencriptador = New CCryptorEngine()
        End If
        Return loDesencriptador.Desencriptar(asPassword)
    End Function
#End Region
#End Region

#Region "Reglas Temp_ProPagos"
    Public Function temp_propagosGuardar(ByVal aoTemp_ProPagos As EETemp_ProPagos) As [Boolean]
        Return Temp_ProPagosDAO.guardar(aoTemp_ProPagos)
    End Function

    Public Function temp_propagosActualizar(ByVal aoTemp_ProPagos As EETemp_ProPagos) As [Boolean]
        Return Temp_ProPagosDAO.actualizar(aoTemp_ProPagos)
    End Function

    Public Function temp_propagosEliminar(ByVal aiIdTemp_ProPagos As Int32) As [Boolean]
        Return Temp_ProPagosDAO.eliminar(aiIdTemp_ProPagos)
    End Function

    Public Function temp_propagosListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETemp_ProPagos)
        Return Temp_ProPagosDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function temp_propagosListarALL() As List(Of EETemp_ProPagos)
        Return Temp_ProPagosDAS.listarALL()
    End Function
    Public Function temp_propagosListarXfecha(ByVal ascriterio As DateTime) As List(Of EETemp_ProPagos)
        Return Temp_ProPagosDAS.listarXFecha(ascriterio)
    End Function

    Public Function temp_propagosListarDatosImportadosXFechaPago(ByVal adtFechaPago As Date) As List(Of EETemp_ProPagos)
        Return Temp_ProPagosDAS.listarDatosImportadosXFechaPago(adtFechaPago)
    End Function
#End Region

#Region "Reglas GastoComision"
    Public Function gastocomisionGuardar(ByVal aoGastoComision As EEGastoComision) As [Boolean]
        Return GastoComisionDAO.guardar(aoGastoComision)
    End Function

    Public Function gastocomisionActualizar(ByVal aoGastoComision As EEGastoComision) As [Boolean]
        Return GastoComisionDAO.actualizar(aoGastoComision)
    End Function

    Public Function gastocomisionEliminar(ByVal aiIdGastoComision As Int32) As [Boolean]
        Return GastoComisionDAO.eliminar(aiIdGastoComision)
    End Function

    Public Function gastocomisionListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEGastoComision)
        Return Nothing
        'Return GastoComisionDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function gastocomisionListarALL() As List(Of EEGastoComision)
        Return Nothing
        'Return GastoComisionDAS.listarALL()
    End Function
#End Region

#Region "Reglas Recaudacion"
    Public Function RecaudacionGuardar(ByVal aoRecaudacion As EERecaudacion) As [Boolean]
        Return RecaudacionDAO.guardar(aoRecaudacion)
    End Function

    Public Function RecaudacionGuardarTrasnferencia(ByVal aoRecaudacion As EERecaudacion) As Int16
        Return RecaudacionDAO.guardarTransferencia(aoRecaudacion)
    End Function

    Public Function RecaudacionActualizar(ByVal aoRecaudacion As EERecaudacion, ByVal tipoCriterio As String) As [Boolean]
        Return RecaudacionDAO.actualizar(aoRecaudacion, tipoCriterio)
    End Function
    Public Function RecaudacionDetGuardar(ByVal aoRecaudacion As EERecaudacionDet) As [Boolean]
        Return RecaudacionDetDAO.guardar(aoRecaudacion)
    End Function
    Public Function RecaudacionDetEliminar(ByVal aoRecaudacion As EERecaudacionDet, ByVal aoTipoCriterio As Integer) As [Boolean]
        Return RecaudacionDetDAO.eliminar(aoRecaudacion, aoTipoCriterio)
    End Function
    Public Function RecaudacionDetValida_recDMonto(ByVal aoRecaudacion As EERecaudacionDet) As [Boolean]
        Return RecaudacionDetDAO.ValidaMontoRec(aoRecaudacion)
    End Function
    Public Function GeneraCodigo_RecIdxFechaPago(ByVal fechaPago As Date) As Integer
        Return RecaudacionDAS.GenerarRecIdByFechaPago(fechaPago)
    End Function


    Public Function ListarAñosRec() As List(Of EERecaudacion)
        Return RecaudacionDAS.ListarAñosRecaudacion()
    End Function
    Public Function ListarRecaudacionXAño(ByVal aoTipoCriterio As Short, Optional ByVal año As Short = Nothing, Optional ByVal FechaRecaudacion As Date = Nothing) As List(Of EERecaudacion)
        Return RecaudacionDAS.ListarRecaudacionXAño(aoTipoCriterio, año, FechaRecaudacion)
    End Function

    Public Function RecaudacionEliminar(ByVal recFecPago As Date, ByVal tgRecaudadorId As String) As [Boolean]
        Return RecaudacionDAO.eliminar(recFecPago, tgRecaudadorId)
    End Function
    Public Function RecaudacionALLXrecFechaReg_tgRecaudadorId(ByVal recFecPago As Date, ByVal tgRecaudadorId As String) As List(Of EERecaudacion)
        Return RecaudacionDAS.listarALLxrecFecPago_tgRecaudadorId(recFecPago, tgRecaudadorId)
    End Function

    Public Function RecaudacionPreTrasDelDia(ByVal recFecPago As Date) As List(Of EERecaudacion)
        Return RecaudacionDAS.listarXPreTrasDelDia(recFecPago)
    End Function


    Public Function RecaudacionXrecFechaPago_recId(ByVal recFecPago As Date, ByVal recId As String) As EERecaudacion
        Return RecaudacionDAS.MostrarxRecFecPago_recId(recFecPago, recId)
    End Function
#End Region

#Region "Reglas Movimientos"
    Public Function MovimientoGuardar(ByVal aoMovimiento As EEMovimiento) As [Boolean]
        Return MovimientoDAO.guardar(aoMovimiento)
    End Function

#End Region

#Region "Reglas Diario Terminal"
    Public Function DiarioTTSCGuardar(ByVal aoDiarioTTSC As EEDiarioTTSC) As String
        Return DiarioTTSCDAO.guardar(aoDiarioTTSC)
    End Function
    Public Function DiarioTTSC_XdTTSCFechaPag_pa(ByVal dTTSCFechaPag As String) As List(Of EEDiarioTTSC)
        Return DiarioTTSCDAO.listar_DiarioTTSC_XdTTSCFechaPag_pa(dTTSCFechaPag)
    End Function

    Public Function DiarioTTSC_Eliminar(ByVal dTTSCFechaPag As Date) As [Boolean]
        Return DiarioTTSCDAO.eliminar(dTTSCFechaPag)
    End Function
#End Region

#Region "Reglas Parametro"
    ''' <summary>
    ''' RETORNA EL VALOR DE LA TABLA PARAMETRO
    ''' SEGUN LA CLASE ID
    ''' </summary>
    ''' <param name="aiClsId">ClsId</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function parametroMostrarXClsId(ByVal aiClsId As Int32) As Decimal
        Return ParametroDAS.mostrarXClsId(aiClsId)
    End Function

    Public Function parametroMostrarXClsId_ParAnio(ByVal aiClsId As Int32, ByVal parAnio As String) As Decimal
        Return ParametroDAS.mostrarXClsId_parAnio(aiClsId, parAnio)
    End Function
#End Region

#Region "Mensaje Excepciones"
    ''' <summary>
    ''' Mostrar Exception por Longitud
    ''' </summary>
    ''' <param name="lsCampo">Campo</param>
    ''' <param name="lsLongitudAceptada">Longitud Aceptada</param>
    ''' <param name="lsLongitudActual">Longitud Actual</param>
    ''' <remarks></remarks>
    Private Sub mExceptionLongitud(ByVal lsCampo As String, ByVal lsLongitudAceptada As String, ByVal lsLongitudActual As String)
        Throw New Exception("El Campo " & lsCampo & " no puede tener mas de " & lsLongitudAceptada & " caracteres." & Environment.NewLine & "El Campo " & lsCampo & " Tiene " & lsLongitudActual & " Caracteres ")
    End Sub

    ''' <summary>
    ''' Mostrar Exception Obligatoria
    ''' </summary>
    ''' <param name="lsCampo">Campo</param>
    ''' <remarks></remarks>
    Private Sub mExceptionObligatorio(ByVal lsCampo As String)
        Throw New Exception("El Campo " & lsCampo & " es obligatorio")
    End Sub
#End Region

#Region "Reglas CompProgramacion"
    Public Function compprogramacionGuardar(ByVal aoCompProgramacion As EECompProgramacion) As [Boolean]
        Return CompProgramacionDAO.guardar(aoCompProgramacion)
    End Function
    Public Function compprogramacionExiste(ByVal ProPaId As String) As List(Of EECompProgramacion)
        Return CompProgramacionDAS.Existe(ProPaId)
    End Function
    Public Function compprogramacionActualizar(ByVal aoCompProgramacion As EECompProgramacion) As [Boolean]
        Return CompProgramacionDAO.actualizar(aoCompProgramacion)
    End Function
#End Region

#Region "Reglas Recaudacion Detalle"
    Public Function RecaudacionDetPreTrasDelDia(ByVal fechapag As Date) As List(Of EERecaudacionDet)
        Return RecaudacionDetDAS.listarRinconadaXPreTrasDelDia(fechapag)
    End Function

    Public Function RecaudacionDetGuardarTrasnferencia(ByVal aoRecaudacion As EERecaudacionDet, ByVal recID As Int16) As [Boolean]
        Return RecaudacionDetDAO.guardarTranferencia(aoRecaudacion, recID)
    End Function

    Public Function RecaudacionDet_by_recid_fechaPag_recdid(ByVal recid As String, ByVal fechapag As Date, ByVal recdid As String) As List(Of EERecaudacionDet)
        Return RecaudacionDetDAS.listar_by_recid_fechaPag_recdid(recid, fechapag, recdid)
    End Function
    Public Function RecaudacionDet_by_fechaPag(ByVal fechapag As Date, Optional ByVal RecaudadorId As String = Nothing) As List(Of EERecaudacionDet)
        Return RecaudacionDetDAS.listar_by_fechaPag_RecaudadorId(fechapag, RecaudadorId)
    End Function
    Public Function RecaudacionDet_by_fechaPag_tgGrupoIng(ByVal fechapag As Date, Optional ByVal tgGrupoIng As String = Nothing) As List(Of EERecaudacionDet)
        Return RecaudacionDetDAS.listar_by_fechaPag_GrupoConId(fechapag, tgGrupoIng)
    End Function
#End Region

#Region "Reglas GrupoFormularios"
    Public Function grupoformulariosGuardar(ByVal aoGrupoFormularios As EEGrupoFormularios) As [Boolean]
        Return GrupoFormulariosDAO.guardar(aoGrupoFormularios)
    End Function

    Public Function grupoformulariosActualizar(ByVal aoGrupoFormularios As EEGrupoFormularios) As [Boolean]
        Return GrupoFormulariosDAO.actualizar(aoGrupoFormularios)
    End Function

    Public Function grupoformulariosEliminar(ByVal aiIdGrupoFormularios As Int32) As [Boolean]
        Return GrupoFormulariosDAO.eliminar(aiIdGrupoFormularios)
    End Function

    Public Function grupoformulariosListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEGrupoFormularios)
        Return GrupoFormulariosDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function grupoformulariosListarALL_EnUsuarios() As List(Of EEGrupoFormularios)
        Return GrupoFormulariosDAS.listarALL_EnUsuarios()
    End Function

    ''' <summary>
    ''' LISTA TODOS LOS FORMULARIOS CON SU RESPECTIVO GRUPO EN MENUFORMULARIOS
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function grupoformulariosListarCriterio_EnMenuFomulario(ByVal aiTipoCriterio As Int32, ByVal asCriterio As String) As List(Of EEGrupoFormularios)
        Return GrupoFormulariosDAS.listarCriterio_EnMenuFomulario(aiTipoCriterio, asCriterio)
    End Function
#End Region

#Region "Reglas MenuFormularios"
    Public Function menuformulariosActualizar(ByVal aoMenuFormularios As EEMenuFormularios) As Boolean
        Return MenuFormulariosDAO.actualizar(aoMenuFormularios)
    End Function
#End Region

#Region "Reglas ContratoPersonal"
    Public Function contratopersonalGuardar(ByVal aoContratoPersonal As EEContratoPersonal) As Boolean
        Return ContratoPersonalDAO.guardar(aoContratoPersonal)
    End Function

    Public Function contratopersonalActualizar(ByVal aoContratoPersonal As EEContratoPersonal) As Boolean
        Return ContratoPersonalDAO.actualizar(aoContratoPersonal)
    End Function

    Public Function contratopersonalEliminar(ByVal aiIdContratoPersonal As Int32) As Boolean
        Return ContratoPersonalDAO.eliminar(aiIdContratoPersonal)
    End Function

    Public Function contratopersonalListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEContratoPersonal)
        Return ContratoPersonalDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function contratopersonalListarXConTrabId(ByVal asContrabId As [String]) As EEContratoPersonal
        Return ContratoPersonalDAS.listarXConTrabId(asContrabId)
    End Function



#End Region

#Region "Reglas ProcedimientoSTD"
    Public Function procedimientostdGuardar(ByVal aoProcedimientoSTD As EEProcedimientoSTD) As [Boolean]
        Return ProcedimientoSTDDAO.guardar(aoProcedimientoSTD)
    End Function

    Public Function procedimientostdActualizar(ByVal aoProcedimientoSTD As EEProcedimientoSTD) As [Boolean]
        Return ProcedimientoSTDDAO.actualizar(aoProcedimientoSTD)
    End Function

    Public Function procedimientostdListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEProcedimientoSTD)
        Return ProcedimientoSTDDAO.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function procedimientostdListarALL() As List(Of EEProcedimientoSTD)
        Return ProcedimientoSTDDAO.listarALL()
    End Function
#End Region

#Region "Reglas HorarioPer"
    ''' <summary>
    ''' Consultar Horario en Formulario Trabajador
    ''' </summary>
    ''' <param name="asCriterio">Texto a Buscar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function horarioperConsultarHorario(ByVal asCriterio As [String]) As List(Of EEHorarioPer)
        Return HorarioPerDAS.consultarHorario(asCriterio)
    End Function

    Public Function horarioperListarAllHorario() As List(Of EEHorarioPer)
        Return HorarioPerDAS.ListarHorario()
    End Function
#End Region

#Region "Reglas DocumentoSTD"
    Public Function documentostdGuardar(ByVal aoDocumentoSTD As EEDocumentoSTD) As [Boolean]
        Return DocumentoSTDDAO.guardar(aoDocumentoSTD)
    End Function

    Public Function documentostdActualizar(ByVal aoDocumentoSTD As EEDocumentoSTD) As [Boolean]
        Return DocumentoSTDDAO.actualizar(aoDocumentoSTD)
    End Function

    Public Function documentostdEliminar(ByVal aiIdDocumentoSTD As Int32) As [Boolean]
        Return DocumentoSTDDAO.eliminar(aiIdDocumentoSTD)
    End Function

    Public Function documentoSTDMostrarXdocId(ByVal docId As [String], Optional ByVal movId As String = Nothing) As EEDocumentoSTD
        Return DocumentoSTDDAS.MostrarxDocId(docId, movId)
    End Function
    'Public Function documentostdListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocumentoSTD)
    '    Return DocumentoSTDDAS.listarCriterio(aiTipoCriterio, asCriterio)
    'End Function
    Public Function documentostdListarDocNRegTCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], Optional ByVal asCriterio2 As [String] = Nothing, Optional ByVal anio As String = Nothing) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.listarDocNRegTCriterio(aiTipoCriterio, asCriterio, asCriterio2, anio)
    End Function

    Public Function documentostdListarxSQL(ByVal SQL As [String]) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.ListarXSql(SQL)
    End Function

    Public Function documentosGenerarCodigo() As String
        Return DocumentoSTDDAS.NewCodigo()
    End Function
    Public Function documentosGenerarCodigoInterno(ByVal tgCargoId As String, ByVal tgTipoDocId As String) As String
        Return DocumentoSTDDAS.NewCodigoInterno(tgCargoId, tgTipoDocId)
    End Function

    Public Function documentosGenerarCodigoExterno() As String
        Return DocumentoSTDDAS.NewCodigoExterno()
    End Function

    ''' <summary>
    ''' Listar Documentos en Vinculas
    ''' </summary>
    ''' <param name="aiTipoCriterio">1 Nro Registro, 2 Asunto, 3 Asunto TUPA, 4 Fec. Ingreso, 5 Siglas, 6 Prioridad</param>
    ''' <param name="asCriterio">Criterio</param>
    ''' <returns></returns>
    ''' <remarks></remarks>




    Public Function documentostdListarCriterioVincular(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.listarCriterioVincular(aiTipoCriterio, asCriterio)
    End Function
    Public Function documentostdListarCriterioVincularxDocID(ByVal docID As [String]) As List(Of EEDocumentoSTD)
        Return DocumentoSTDDAS.listarCriterioVincularxDocId(docID)
    End Function

    'Public Function documentostdVincular(ByVal asDocId As String, ByVal asDocVinId As String, ByVal aiDocNPartePrincipal As Int16, ByVal aiDocNParteVinculado As Int16) As Boolean
    '    Return DocumentoSTDDAO.vincular(asDocId, asDocVinId, aiDocNPartePrincipal, aiDocNParteVinculado)
    'End Function

    'Public Function documentostdDesvincular(ByVal asDocId As String) As Boolean
    '    Return DocumentoSTDDAO.desvincular(asDocId)
    'End Function
#End Region

#Region "Reglas Cargos"
    Public Function CargosListarXCriterio_pa(ByVal tpCriterio As Int16, ByVal criterio As [String]) As List(Of EETablaGeneral)
        Return CargosDAS.listarCargosXcriterio(tpCriterio, criterio)
    End Function


#End Region

#Region "Reglas Cargo Personal"
    Public Function CargoListarXPerId_pa(ByVal perID As [String]) As List(Of EECargoPersonal)
        Return CargoPersonalDAS.listarxPerId(perID)
    End Function

    Public Function CargoMostrarXPerId_pa(ByVal perID As [String]) As EECargoPersonal
        Return CargoPersonalDAS.MostrarxPerId(perID)
    End Function

#End Region

#Region "Reglas ReqDocumentoSTD"
    Public Function reqdocumentostdGuardar(ByVal aoReqDocumentoSTD As EEReqDocumentoSTD) As [Boolean]
        Return ReqDocumentoSTDDAO.guardar(aoReqDocumentoSTD)
    End Function

    Public Function reqdocumentostdActualizar(ByVal aoReqDocumentoSTD As EEReqDocumentoSTD) As [Boolean]
        Return ReqDocumentoSTDDAO.actualizar(aoReqDocumentoSTD)
    End Function

    Public Function reqdocumentostdEliminar(ByVal aiIdReqDocumentoSTD As Int32) As [Boolean]
        Return ReqDocumentoSTDDAO.eliminar(aiIdReqDocumentoSTD)
    End Function

    Public Function reqdocumentostdXdocId(ByVal docID As [String]) As List(Of EEReqDocumentoSTD)
        Return ReqDocumentoSTDDAS.listarxDocId(docID)
    End Function

#End Region

#Region "Reglas JerarquiaSTD"
    Public Function jerarquiastdGuardar(ByVal aoJerarquiaSTD As EEJerarquiaSTD) As Boolean
        Return JerarquiaSTDDAO.guardar(aoJerarquiaSTD)
    End Function

    Public Function jerarquiastdActualizar(ByVal aoJerarquiaSTD As EEJerarquiaSTD) As Boolean
        Return JerarquiaSTDDAO.actualizar(aoJerarquiaSTD)
    End Function

    Public Function jerarquiastdEliminar(ByVal aiIdJerarquiaSTD As Int32) As Boolean
        Return JerarquiaSTDDAO.eliminar(aiIdJerarquiaSTD)
    End Function

    Public Function jerarquiastdListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEJerarquiaSTD)
        Return JerarquiaSTDDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function jerarquiastdListarCriterioXTipoCriterio_XId(ByVal aiTipoCriterio As Int32, ByVal asId As [String]) As List(Of EEJerarquiaSTD)
        Return JerarquiaSTDDAS.listarCriterioXTipoCriterio_XId(aiTipoCriterio, asId)
    End Function
    Public Function jerarquiastdListarCargosDestinosXJerDeId_tgAreaId(ByVal JerDeId As String, ByVal tgAreaId As String, Optional ByVal tgInstId As String = "0001") As List(Of EEJerarquiaSTD)
        Return JerarquiaSTDDAS.listarCargosDestinosXJerDeId_tgAreaId(JerDeId, tgAreaId)
    End Function
    Public Function jerarquiastdListarCargosDestinosXJerDeId_tgTDocId(ByVal JerDeId As String, ByVal tgTDocId As [String], ByVal tgExtra As String) As List(Of EEJerarquiaSTD)
        Return JerarquiaSTDDAS.listarCargosDestinosXJerDeId_tgTDocId(JerDeId, tgTDocId, tgExtra)
    End Function
    Public Function jerarquiastdListarAreasDestinosXJerDeId(ByVal JerDeId As String, Optional ByVal tgInstId As String = "0001") As List(Of EEJerarquiaSTD)
        Return JerarquiaSTDDAS.listarAreasDestinosXJerDeId(JerDeId)
    End Function
    Public Function jerarquiastdListarAreasDestinosXJerDeId_tgTDocId(ByVal JerDeId As String, ByVal tgTDocId As [String], ByVal tgExtra As String) As List(Of EEJerarquiaSTD)
        Return JerarquiaSTDDAS.listarAreasDestinosXJerDeId_tgTDocId(JerDeId, tgTDocId, tgExtra)
    End Function
    Public Function jerarquiastdListarInstitucionDestinosXJerDeId_tgTDocId(ByVal JerDeId As String, ByVal tgTDocId As [String]) As List(Of EEJerarquiaSTD)
        Return JerarquiaSTDDAS.listarInsititucionDestinosXJerDeId_tgTDocId(JerDeId, tgTDocId)
    End Function

    Public Function jerarquiaSTDListarTipoDocumentosXJerDeId_JerParaId(ByVal JerDeId As String, ByVal JerParaId As [String]) As List(Of EETablaGeneral)
        Return JerarquiaSTDDAS.listarTipoDocumentosXJerDeId_JerParaId(JerDeId, JerParaId)
    End Function
#End Region

#Region "Reglas AnexoSTD"
    Public Function anexostdGuardar(ByVal aoAnexoSTD As EEAnexoSTD) As [Boolean]
        Return AnexoSTDDAO.guardar(aoAnexoSTD)
    End Function

    Public Function anexostdActualizar(ByVal aoAnexoSTD As EEAnexoSTD) As [Boolean]
        Return AnexoSTDDAO.actualizar(aoAnexoSTD)
    End Function

    Public Function anexostdEliminar(ByVal aiIdAnexoSTD As Int32) As [Boolean]
        Return AnexoSTDDAO.eliminar(aiIdAnexoSTD)
    End Function

    Public Function anexostdListarxDocId(ByVal asDocId As [String]) As List(Of EEAnexoSTD)
        Return AnexoSTDDAS.listarXDocId(asDocId)
    End Function

    Public Function anexostdListarXFechaServidor(ByVal adtFecha As Date) As List(Of EEAnexoSTD)
        Return AnexoSTDDAS.listarXFechaServidor(adtFecha)
    End Function

    Public Function anexostdActualizarTransferencia(ByVal aListaAnexoSTD As List(Of EEAnexoSTD)) As Boolean
        Return AnexoSTDDAO.actualizarTransferencia(aListaAnexoSTD)
    End Function
#End Region

#Region "Reglas CargoTipoDocSTD"
    Public Function cargotipodocstdActualizar(ByVal aoCargoTipoDocSTD As EECargoTipoDocSTD) As Boolean
        Return CargoTipoDocSTDDAO.actualizar(aoCargoTipoDocSTD)
    End Function

    Public Function cargotipodocstdEliminar(ByVal aiIdCargoTipoDocSTD As Int32) As Boolean
        Return CargoTipoAccionSTDDAO.eliminar(aiIdCargoTipoDocSTD)
    End Function

    Public Function cargotipodocstdListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EECargoTipoDocSTD)
        Return CargoTipoDocSTDDAs.listarCriterio(aiTipoCriterio, asCriterio)
    End Function
#End Region

#Region "Reglas MovimientoSTD"

    Public Function movimientoSTDGuardar(ByVal aoMovimientoSTD As EEMovimientoSTD) As [Boolean]
        Return MovimientoSTDDAO.guardar(aoMovimientoSTD)
    End Function

    Public Function movimientostdActualizarLectura(ByVal MovId As String) As [Boolean]
        Return MovimientoSTDDAO.ActualizarLectura(MovId)
    End Function

    Public Function movimientostdEliminarXMovId(ByVal MovId As String) As [Boolean]
        Return MovimientoSTDDAO.EliminarXMovId(MovId)
    End Function

    Public Function movimientostdActualizarEstadoMov(ByVal MovId As String, ByVal EstadoMovId As Integer, ByVal comentario As String, ByVal cargo As String, ByVal docId As String, ByVal autoenvio As Boolean) As [Boolean]
        Return MovimientoSTDDAO.ActualizarEstadoMov(MovId, EstadoMovId, comentario, cargo, docId, autoenvio)
    End Function

    Public Function movimientostdActualizarRecepcionManual(ByVal MovId As String) As [Boolean]
        Return MovimientoSTDDAO.ActualizarRecepcionManual(MovId)
    End Function

    Public Function movimientoSTDxMovId(ByVal movId As Integer) As EEMovimientoSTD
        Return MovimientoSTDDAS.MostrarXMovId(movId)
    End Function

    Public Function movimientoSTDxCriterio(ByVal tcriterio As Integer, ByVal criterio As String) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.listarxCriterio(tcriterio, criterio)
    End Function

    Public Function movimientoSTDMostrarMovArchXMovId(ByVal MovId As String) As EEMovimientoSTD
        Return MovimientoSTDDAS.MostrarArchvxMovId(MovId)
    End Function

    Public Function movimientoSTDxCriterioTop(ByVal tcriterio As Integer, ByVal criterio As String, ByVal top As Integer, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.listarxCriterioTop(tcriterio, criterio, top, anio, mes)
    End Function
    Public Function movimientoSTDxCriterioPaginacion(ByVal tcriterio As Integer, ByVal criterio As String, ByVal Pagina As Integer, ByVal Nreg As Integer, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.listarxCriterioPag(tcriterio, criterio, Pagina, Nreg, anio, mes)
    End Function
    Public Function movimientorResponderSTDxCriterioPaginacion(ByVal tcriterio As Integer, ByVal criterio As String, ByVal Pagina As Integer, ByVal Nreg As Integer, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.listarResponderxCriterioPag(tcriterio, criterio, Pagina, Nreg, anio, mes)
    End Function

    Public Function movimientorResponderSTDxCriterioTop(ByVal tcriterio As Integer, ByVal criterio As String, ByVal top As Integer, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.listarResponderxCriterioTop(tcriterio, criterio, top, anio, mes)
    End Function
    Public Function movimientoSTDxCriterioCount(ByVal tcriterio As Integer, ByVal criterio As String, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As Integer
        Return MovimientoSTDDAS.listarxCriterioCount(tcriterio, criterio, anio, mes)
    End Function

    Public Function movimientoResponderSTDxCriterioCount(ByVal tcriterio As Integer, ByVal criterio As String, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As Integer
        Return MovimientoSTDDAS.listarResponderxCriterioCount(tcriterio, criterio, anio, mes)
    End Function

    Public Function movimientoSTD_Reportex_TgDestinoId_MovDeId(ByVal tgDestinoId As String, ByVal movParaId As String, Optional ByVal fecha As Date = Nothing) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.listarxTgDestino_MovDe(tgDestinoId, movParaId, fecha)
    End Function
    Public Function movimientoSTD_Ultimo_tgEstadoMovIdxDocId(ByVal docId As String) As EEMovimientoSTD
        Return MovimientoSTDDAS.MostrarEstadoMovId_UltimoXdocId(docId)
    End Function

    Public Function movimientoSTDListarxSQL(ByVal SQL As [String]) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.ListarXSql(SQL)
    End Function

    Public Function movimientoSTD_consultar_noleidos_XPerId(ByVal asPerId As String) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.consultar_noleidos_XPerId(asPerId)
    End Function

    Public Function movimientoSTDListarxDocId(ByVal docId As String) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.listarxDocId(docId)
    End Function
    Public Function movimientoSTDPivotear(ByVal criterio As String, ByVal tipocriterio As Short, ByVal anio As Short) As List(Of EEMovimientoSTD)
        Return MovimientoSTDDAS.PivotearMovimientosSTD(criterio, tipocriterio, anio)
    End Function
#End Region

#Region "Reglas EtapaSTD"
    Public Function etapastdGuardar(ByVal aoEtapaSTD As EEEtapaSTD) As Boolean
        Return EtapaSTDDAO.guardar(aoEtapaSTD)
    End Function

    Public Function etapastdActualizar(ByVal aoEtapaSTD As EEEtapaSTD) As Boolean
        Return EtapaSTDDAO.actualizar(aoEtapaSTD)
    End Function

    Public Function etapastdEliminar(ByVal aiIdEtapaSTD As Int32) As Boolean
        Return EtapaSTDDAO.eliminar(aiIdEtapaSTD)
    End Function

    Public Function etapastdListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEEtapaSTD)
        Return EtapaSTDDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function
#End Region

#Region "Reglas CargoTipoAccionSTD"
    Public Function cargotipoaccionstdActualizar(ByVal aoCargoTipoAccionSTD As EECargoTipoAccionSTD) As Boolean
        Return CargoTipoAccionSTDDAO.actualizar(aoCargoTipoAccionSTD)
    End Function

    Public Function cargotipoaccionstdEliminar(ByVal aiIdCargoTipoAccionSTD As Int32) As Boolean
        Return CargoTipoAccionSTDDAO.eliminar(aiIdCargoTipoAccionSTD)
    End Function

    Public Function cargotipoaccionstdListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EECargoTipoAccionSTD)
        Return CargoTipoAccionSTDDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function
#End Region

#Region "Reglas Articulo"
    Public Function articuloGuardar(ByVal aoArticulo As EEArticulo) As [Boolean]
        Return ArticuloDAO.guardar(aoArticulo)
    End Function

    Public Function articuloActualizar(ByVal aoArticulo As EEArticulo) As [Boolean]
        Return ArticuloDAO.actualizar(aoArticulo)
    End Function

    Public Function articuloListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEArticulo)
        Return ArticuloDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function articuloGeneraCodigo() As String
        Return ArticuloDAS.generaCodigo
    End Function

    Public Function articuloGeneraCodigoSAIMT() As String
        Return ArticuloDAS.generaCodigoSAIMT
    End Function

#End Region

#Region "Reglas Certificacion"
    Public Function CertificacionGeneraCodigo() As String
        Return CertificacionDAS.generaCodigo
    End Function

    'Public Function CertificacionGeneraCodigoSAIMT() As String
    '    Return CertificacionDAS.generaCodigoSAIMT
    'End Function

    Public Function CertificacionGuardar(ByVal aoCertificacion As EECertificacion) As Boolean
        Return CertificacionDAO.guardar(aoCertificacion)
    End Function

    Public Function CertificacionListarBCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal anio As Int16) As List(Of EECertificacion)
        Return CertificacionDAS.listarBCriterio(aiTipoCriterio, asCriterio, anio)
    End Function

    'Public Function CertificacionListarConsultaCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal anio As Integer) As List(Of EECertificacion)
    '    Return CertificacionDAS.listarConsultaCriterio(aiTipoCriterio, asCriterio, anio)
    'End Function

    'Public Function CertificacionListarDetPartidasXCerId(ByVal cerId As String) As List(Of EECertificacion)
    '    Return CertificacionDAS.listarDetPartidasXCerId(cerId)
    'End Function

    Public Function CertificacionMostrarCertificacionXCerId(ByVal CerId As [String]) As EECertificacion
        Return CertificacionDAS.MostrarXCerId(CerId)
    End Function

    Public Function CertificacionGrupoPartidaXcerId(ByVal CerId As [String]) As List(Of EECertificacion.EECertificacionGrupoPartida)
        Return CertificacionDAS.ListaCertGrupoPartidaXCerId(CerId)
    End Function

#End Region

#Region "Reglas Pecosa"
    Public Function PecosaGeneraCodigo() As String
        Return PecosaDAS.generaCodigo
    End Function

    Public Function PecosaGeneraCodigoSAIMT() As String
        Return PecosaDAS.generaCodigoSAIMT
    End Function

    Public Function PecosaGuardar(ByVal aoPecosa As EEPecosa) As Boolean
        Return PecosaDAO.guardar(aoPecosa)
    End Function

    Public Function PecosaActualizar(ByVal aoPecosa As EEPecosa) As Boolean
        Return PecosaDAO.Actualizar(aoPecosa)
    End Function

    Public Function PecosaListarBCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal asAnio As Int16) As List(Of EEPecosa)
        Return PecosaDAS.listarBCriterio(aiTipoCriterio, asCriterio, asAnio)
    End Function

    Public Function PecosaMostrarPecosaXPecId(ByVal PecId As [String]) As EEPecosa
        Return PecosaDAS.MostrarXpecId(PecId)
    End Function

    Public Function PecosaDetXPecId(ByVal PecId As [String]) As List(Of EEPecosa.EEPecosaDet)
        Return PecosaDAS.listarDetalleXPecId(PecId)
    End Function

    Public Function PecosaOCDetXPecId(ByVal PecDetId As [String], ByVal ArtId As [String]) As List(Of EEPecosa.EEPecosaOCDet)
        Return PecosaDAS.listarDetalleXPecOCDetId(PecDetId, ArtId)
    End Function

#End Region

#Region "Reglas OrdenCompra"
    Public Function ordencompraGuardar(ByVal aoOrdenCompra As EEOrdenCompra) As Boolean
        Return OrdenCompraDAO.guardar(aoOrdenCompra)
    End Function

    Public Function ordencompraActualizaGrupoPartidasXOrdId_cerGrupoParId(ByVal asOrdId As String, ByVal cerGrupoParId As Integer) As Boolean
        Return OrdenCompraDAO.ActualizaOrdenCompraGrupoPartidasXOrdId_cerGrupoParId(asOrdId, cerGrupoParId)
    End Function

    Public Function ordencompraActualizarGrupoPartidascerGrupoParValQuedan() As Boolean
        Return OrdenCompraDAO.ActualizarOrdenCompraGrupoPartidas_cerGrupoParValQuedan()
    End Function

    Public Function ordencompraActualizarCertificacionLOGcerValQuedan(ByVal cerId As String) As Boolean
        Return OrdenCompraDAO.ActualizarOrdenCompraCertificacionLOGcerValQuedan(cerId)
    End Function



    Public Function ordencompraActualizar(ByVal aoOrdenCompra As EEOrdenCompra) As Boolean
        Return OrdenCompraDAO.actualizar(aoOrdenCompra)
    End Function

    Public Function ordencompraGeneraCodigo() As String
        Return OrdenCompraDAS.generaCodigo
    End Function

    Public Function ordencompraGeneraCodigoSAIMT() As String
        Return OrdenCompraDAS.generaCodigoSAIMT
    End Function

    Public Function ordencompraListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal asAnio As Int16) As List(Of EEOrdenCompra)
        Return OrdenCompraDAS.listarCriterio(aiTipoCriterio, asCriterio, asAnio)
    End Function

    Public Function ordencompraDetXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraDet)
        Return OrdenCompraDAS.listarDetalleXOrdId(OrdId)
    End Function

    Public Function ordencompraGrupoPartidaXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraGrupoPartidas)
        Return OrdenCompraDAS.listarGrupoPartidaXOrdId(OrdId)
    End Function

    Public Function ordencompraDocRefXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraDocRef)
        Return OrdenCompraDAS.listarDocRefXOrdId(OrdId)
    End Function

    Public Function ordencompraAreaRefXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraAreaRef)
        Return OrdenCompraDAS.listarAreaRefXOrdId(OrdId)
    End Function

    Public Function ordenCompraListarxOrdId(ByVal ordID As [String]) As EEOrdenCompra
        Return OrdenCompraDAS.ListarxOrdId(ordID)
    End Function

    Public Function consultarordencompraListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEOrdenCompra)
        Return OrdenCompraDAS.ConsultarlistarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function consultarordencompraDetXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraDet)
        Return OrdenCompraDAS.ConsultarlistarDetalleXOrdId(OrdId)
    End Function

    Public Function mostrarOrdenCompDetXOrdNro_Anio(ByVal asOrdNro As String, ByVal asAnio As Short) As List(Of EEOrdenCompra.EEOrdenCompraDet)
        Return OrdenCompraDAS.listarDetalleXOrdNro_Año(asOrdNro, asAnio)
    End Function
#End Region

#Region "Reglas Comprobante de Pago"
    Public Function comprobantePagoGuardar(ByVal aoComprobantePago As EEComprobantePago) As Boolean
        Return ComprobantePagoDAO.guardar(aoComprobantePago)
    End Function

    Public Function comprobantePagoActualizar(ByVal aoComprobantePago As EEComprobantePago) As Boolean
        Return ComprobantePagoDAO.actualizar(aoComprobantePago)
    End Function

    Public Function comprobantePagoGeneraCodigo() As String
        Return ComprobantePagoDAS.generaCodigo
    End Function

    Public Function comprobantePagoGeneraCodigoSAIMT(ByVal asCriterio As [String]) As String
        Return ComprobantePagoDAS.generaCodigo(asCriterio)
    End Function

    Public Function comprobantePagoListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEComprobantePago)
        Return ComprobantePagoDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    'Public Function ordencompraGeneraCodigo() As String
    '    Return OrdenCompraDAS.generaCodigo
    'End Function

    'Public Function ordencompraGeneraCodigoSAIMT() As String
    '    Return OrdenCompraDAS.generaCodigoSAIMT
    'End Function

    'Public Function ordencompraListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEOrdenCompra)
    '    Return OrdenCompraDAS.listarCriterio(aiTipoCriterio, asCriterio)
    'End Function

    'Public Function ordencompraDetXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraDet)
    '    Return OrdenCompraDAS.listarDetalleXOrdId(OrdId)
    'End Function

    'Public Function consultarordencompraListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEOrdenCompra)
    '    Return OrdenCompraDAS.ConsultarlistarCriterio(aiTipoCriterio, asCriterio)
    'End Function

    'Public Function consultarordencompraDetXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraDet)
    '    Return OrdenCompraDAS.ConsultarlistarDetalleXOrdId(OrdId)
    'End Function
#End Region

#Region "Reglas Servicio"

    Public Function ordenServicioDocRefXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenServicio.EEOrdenServicioDocRef)
        Return OrdenServicioDAS.listarDocRefXOrdId(OrdId)
    End Function

    Public Function ordenservicioAreaRefXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenServicio.EEOrdenServicioAreaRef)
        Return OrdenServicioDAS.listarAreaRefXOrdId(OrdId)
    End Function

    Public Function ordenServicioGuardar(ByVal aoOrdenServicio As EEOrdenServicio) As Boolean
        Return OrdenServicioDAO.guardar(aoOrdenServicio)
    End Function

    Public Function ordenServicioActualizar(ByVal aoOrdenServicio As EEOrdenServicio) As Boolean
        Return OrdenServicioDAO.actualizar(aoOrdenServicio)
    End Function

    Public Function ordenServicioGeneraCodigo() As String
        Return OrdenServicioDAS.generaCodigo
    End Function

    Public Function ordenServicioGeneraCodigoSAIMT() As String
        Return OrdenServicioDAS.generaCodigoSAIMT
    End Function

    Public Function ordenservicioGrupoPartidaXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenServicio.EEOrdenServicioGrupoPartidas)
        Return OrdenServicioDAS.listarGrupoPartidaXOrdId(OrdId)
    End Function

    Public Function ordenServicioListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal asAnio As Int16) As List(Of EEOrdenServicio)
        Return OrdenServicioDAS.listarCriterio(aiTipoCriterio, asCriterio, asAnio)
    End Function
    Public Function ordenServicioListarxOrdId(ByVal ordID As [String]) As EEOrdenServicio
        Return OrdenServicioDAS.ListarxOrdId(ordID)
    End Function
    Public Function ordenServicioDetXOrdId(ByVal OrdId As [String]) As List(Of EEOrdenServicio.EEOrdenServicioDet)
        Return OrdenServicioDAS.listarDetalleXOrdId(OrdId)
    End Function

    'Public Function ordenServicioListarALL() As List(Of EEOrdenServicio)
    '    Return OrdenServicioDAS.listarALL()
    'End Function
#End Region

#Region "Reglas Caja Chica Configuración"
    Public Function cajaChicaConfigGenerarCodigoxtgAnioId(ByVal tgAnioId As String) As String
        Return CajaChicaDAS.generaCodigoCajaChicaConfig(tgAnioId)
    End Function

    Public Function cajaChicaConfigGuardar(ByVal loCajaChicaConfig As EECajaChica.EECajaChicaConfiguracion) As Boolean
        Return CajaChicaDAO.guardarCajaChicaConfig(loCajaChicaConfig)
    End Function

    Public Function cajaChicaConfigActualizar(ByVal loCajaChicaConfig As EECajaChica.EECajaChicaConfiguracion) As Boolean
        Return CajaChicaDAO.actualizarCajaChicaConfig(loCajaChicaConfig)
    End Function

    Public Function cajaChicaConfigListarxTgAreaId_TgAnioId(ByVal tgAreaID As [String], ByVal tgAnioID As [String]) As EECajaChica.EECajaChicaConfiguracion
        Return CajaChicaDAS.ListarConfiguracionXtgAreaId_tgAnioId(tgAreaID, tgAnioID)
    End Function

    Public Function cajaChicaConfigActivaxTgAreaId(ByVal tgAreaID As [String]) As EECajaChica.EECajaChicaConfiguracion
        Return CajaChicaDAS.ListarConfiguracionActivaXtgAreaId(tgAreaID)
    End Function

    Public Function cajaChicaConfigListarAreasxTgAnioId(ByVal tgAnioId As [String]) As List(Of EECajaChica.EECajaChicaConfiguracion)
        Return CajaChicaDAS.ListarConfigAreasXtgAnioId(tgAnioId)
    End Function


    Public Function cajaChicaGuardar(ByVal loCajaChica As EECajaChica) As Boolean
        Return CajaChicaDAO.guardar(loCajaChica)
    End Function

    Public Function cajaChicaActualizar(ByVal loCajaChica As EECajaChica) As Boolean
        Return CajaChicaDAO.actualizar(loCajaChica)
    End Function

    Public Function cajaChicaContarCajasXTgAreaId_tgEstadoId(ByVal tgAreaId As String, ByVal tgestadoId As String) As String
        Return CajaChicaDAS.CountXtgAreaId_TgEstadoId(tgAreaId, tgestadoId)
    End Function

    Public Function cajaChicaListarxTgAreaId_TgAnioId(ByVal tgAreaID As [String], ByVal tgAnioID As [String]) As List(Of EECajaChica)
        Return CajaChicaDAS.ListarXtgAreaId_tgAnioId(tgAreaID, tgAnioID)
    End Function

    Public Function cajaChicaListarCajNroxTgAreaId_TgAnioId(ByVal tgAreaID As [String], ByVal tgAnioID As [String]) As List(Of EECajaChica)
        Return CajaChicaDAS.ListarCajNroXtgAreaId_tgAnioId(tgAreaID, tgAnioID)
    End Function

    Public Function cajaChicaMostrarAnteriorFondoCierrexTgAreaId_TgAnioId(ByVal tgAreaID As [String], ByVal tgAnioID As [String]) As Decimal
        Return CajaChicaDAS.MostrarAnteriorFondoCierreXtgAreaId_tgAnioId(tgAreaID, tgAnioID)
    End Function

    Public Function cajaChicaMostrarAbiertaxTgAreaId(ByVal tgAreaID As [String]) As EECajaChica
        Return CajaChicaDAS.MostrarCajaAbiertaXtgAreaId(tgAreaID)
    End Function

    Public Function cajaChicaMostrarxCajId(ByVal CajId As [String]) As EECajaChica
        Return CajaChicaDAS.MostrarCajaXCajId(CajId)
    End Function

    Public Function cajaChicaMostrarMontoUtilizadoxCajId(ByVal CajID As [String]) As Decimal
        Return CajaChicaDAS.MostrarCajaMontoUtilizadoXCajID(CajID)
    End Function
#End Region

#Region "Reglas CajaChicaDet"
    Public Function cajachicadetGuardar(ByVal aoCajaChicaDet As EECajaChica.EECajaChicaDet) As Boolean
        Return CajaChicaDAO.guardarDet(aoCajaChicaDet)
    End Function

    Public Function cajachicadetActualizar(ByVal aoCajaChicaDet As EECajaChica.EECajaChicaDet) As Boolean
        Return CajaChicaDAO.actualizarDet(aoCajaChicaDet)
    End Function
    Public Function cajachicadetListarXCajId(ByVal cajId As String) As List(Of EECajaChica.EECajaChicaDet)
        Return CajaChicaDAO.listarDetxCajId(cajId)
    End Function
    Public Function cajachicadetListarResumenPartidasXCajId(ByVal cajId As String) As List(Of EECajaChica.EECajaChicaDet)
        Return CajaChicaDAO.listarDetResumenPartidasxCajId(cajId)
    End Function
    Public Function cajachicadetListarXCajDetId(ByVal cajDetId As String) As EECajaChica.EECajaChicaDet
        Return CajaChicaDAO.listarDetxCajDetId(cajDetId)
    End Function
    Public Function cajachicadetBListarXcriterios(ByVal tipocriterio As Int16, ByVal criterio As String) As List(Of EECajaChica.EECajaChicaDet)
        Return CajaChicaDAO.BlistarDetxCriterios(tipocriterio, criterio)
    End Function
    Public Function PivotearCajaChica(ByVal anio As String) As List(Of EEReportesGeneral)
        Return ReportesGeneralDAS.Pivotear_CajaChica(anio)
    End Function
#End Region

#Region "Reglas Sucursales"
    Public Function sucursalesListarALL() As List(Of EESucursales)
        Return SucursalesDAS.listarALL()
    End Function
#End Region

#Region "Reglas Horarios"
    Public Function horariosListarALL() As List(Of EEHorarios)
        Return HorarioDAS.listarALL()
    End Function
#End Region

#Region "Reglas Trabajador"

    Public Function TrabajadorListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEContratoPersonal)
        Return ContratoPersonalDAS.listarTrabajadorCriterio(aiTipoCriterio, asCriterio)
    End Function

#End Region

#Region "Reglas Pedido"
    Public Function PedidoServLOGListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocumentoLOG)
        Return PedidoLOGDAS.listarServCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function PedidoDetServLOGxPedId(ByVal pedId As [String]) As List(Of EEDocumentoLOG.EEPedServDetLOG)
        Return PedidoLOGDAS.listarDetallePedServXPedId(pedId)
    End Function

    Public Function PedidoArtLOGListarPedidoArtCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocumentoLOG)
        Return PedidoLOGDAS.listarPedidoArtCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function PedidoArtLOGListarPedidoArtXDocId(ByVal asDocId As String) As EEDocumentoLOG
        Return PedidoLOGDAS.listarPedidoArtXDocId(asDocId)
    End Function

    Public Function PedidoLOGNewDocCodigoXTipo(ByVal asTipo As String) As String
        Return PedidoLOGDAS.NewDocCodigo(asTipo)
    End Function

    Public Function PedidoArtLOGListarPedidoArtActivos_Criterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocumentoLOG)
        Return PedidoLOGDAS.listarPedidoArtActivos_Criterio(aiTipoCriterio, asCriterio)
    End Function
#End Region

#Region "Reglas Partida"
    Public Function partidaGuardar(ByVal aoPartida As EEPartida) As [Boolean]
        Return PartidaDAO.guardar(aoPartida)
    End Function

    Public Function partidaActualizar(ByVal aoPartida As EEPartida) As [Boolean]
        Return PartidaDAO.actualizar(aoPartida)
    End Function

    Public Function partidaListarCriterio(ByVal aiAño As Int32, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPartida)
        Return PartidaDAS.listarCriterio(aiAño, aiTipoCriterio, asCriterio)
    End Function

    'Public Function partidaMostrarPartidaXPartId(ByVal PartId As [String]) As EEPartida
    '    Return PartidaDAS.MostrarXPartId(PartId)
    'End Function

    Public Function partidaEliminar(ByVal aoPartida As EEPartida) As [Boolean]
        Return PartidaDAO.eliminar(aoPartida)
    End Function
#End Region

#Region "Reglas PlanCuenta"
    Public Function plancuentaGuardar(ByVal aoPlanCuenta As EEPlanCuenta) As Boolean
        Return PlanCuentaDAO.guardar(aoPlanCuenta)
    End Function

    Public Function plancuentaActualizar(ByVal aoPlanCuenta As EEPlanCuenta) As Boolean
        Return PlanCuentaDAO.actualizar(aoPlanCuenta)
    End Function

    Public Function plancuentaEliminar(ByVal aoPlanCuenta As EEPlanCuenta) As Boolean
        Return PlanCuentaDAO.eliminar(aoPlanCuenta)
    End Function

    Public Function plancuentaListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPlanCuenta)
        Return PlanCuentaDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function plancuentaListarXPlanCId_XPlanCAño(ByVal asPlanCId As String, ByVal aiAño As Int16) As EEPlanCuenta
        Return PlanCuentaDAS.listarXPlanCId_XPlanCAño(asPlanCId, aiAño)
    End Function

    Public Function plancuentaListarAños() As List(Of String)
        Return PlanCuentaDAS.listarAños()
    End Function

    Public Function plancuentaListarXPlanCAño(ByVal aiAño As Int16) As List(Of EEPlanCuenta)
        Return PlanCuentaDAS.listarXPlanCAño(aiAño)
    End Function
#End Region
#Region "boleteria"
    Public Function boleteriaRinconadaGuardar(ByVal aoBoleteria As EEBoleteriaRinconada) As Boolean
        Return boleteriaDAO.guardar(aoBoleteria)
    End Function

    Public Function boleteriaRinconadaGenerarBolCodigo() As String
        Return BoleteriaDAS.GenerarCodigoBolCodigo
    End Function

    Public Function boleteriaTransferirRinconadaGuardar(ByVal aoBoleteria As EEBoleteriaRinconada) As String
        Return boleteriaDAO.guardarTrasferencia(aoBoleteria)
    End Function

    Public Function boleteriaRinconadaListarIngresosDelDia(ByVal bolFechaIng As Date) As List(Of EEBoleteriaRinconada)
        Return boleteriaDAO.ListardelDia(bolFechaIng)
    End Function

    Public Function boleteriaRinconadaListarPreTrasDelDia(ByVal bolFechaIng As Date) As List(Of EEBoleteriaRinconada)
        Return boleteriaDAO.ListarPreparaTrasferenciaRinconadaXDia(bolFechaIng)
    End Function
#End Region

#Region "Reglas DiarioPEM"
    Public Function diariopemGuardar(ByVal aoDiarioPEM As EEDiarioPEM) As String
        Return DiarioPEMDAO.guardar(aoDiarioPEM)
    End Function

    Public Function diarioRinconadaActualizar(ByVal aoDiarioPEM As EEDiarioPEM) As String
        Return DiarioPEMDAO.ActualizarRinconada(aoDiarioPEM)
    End Function

    Public Function diarioRinconadaGuardar(ByVal aoDiarioPEM As EEDiarioPEM) As Boolean
        Return DiarioPEMDAO.guardarRinconada(aoDiarioPEM)
    End Function

    Public Function diarioRinconadaTransferenciaGuardar(ByVal aoDiarioPEM As EEDiarioPEM) As String
        Return DiarioPEMDAO.guardarTransferencia(aoDiarioPEM)
    End Function


    Public Function diarioRinconadaGenerarDiaCodigo() As String
        Return DiarioPEMDAS.RinconadaGenerarCodigo
    End Function

    Public Function diariopemComprobacionXAbonId(ByVal asAbonId As String) As Boolean
        Return DiarioPEMDAO.ComprobacionXAbonId(asAbonId)
    End Function
    Public Function diariopemMostrarXtgEstadoIdXdiaNPlaca(ByVal astgEstadoId As [String], ByVal asdiaNPlaca As [String]) As EEDiarioPEM
        Return DiarioPEMDAS.MostrarXtgEstadoIdXdiaNPlaca(astgEstadoId, asdiaNPlaca)
    End Function

    Public Function diarioRinconadaMostrarXtgEstadoIdXdiaNPlaca(ByVal astgEstadoId As [String], ByVal asdiaNPlaca As [String]) As EEDiarioPEM
        Return DiarioPEMDAS.MostrarRinconadaXtgEstadoIdXdiaNPlaca(astgEstadoId, asdiaNPlaca)
    End Function


    Public Function diariopemMostrarDatosIngresoXdiaNPlaca(ByVal asdiaNPlaca As [String]) As EEDiarioPEM
        Return DiarioPEMDAS.MostrarDatosIngresoXdiaNPlaca(asdiaNPlaca)
    End Function

    Public Function diarioRinconadaMostrarDatosIngresoXdiaNPlaca(ByVal asdiaNPlaca As [String]) As EEDiarioPEM
        Return DiarioPEMDAS.MostrarRinconadaDatosIngresoXdiaNPlaca(asdiaNPlaca)
    End Function

    Public Function diariopemMostrarDatosIngresoXdiaNroTicket(ByVal asdiaNroTicket As [String]) As EEDiarioPEM
        Return DiarioPEMDAS.MostrarDatosIngresoXdiaNroTicket(asdiaNroTicket)
    End Function

    Public Function diarioRinconadaMostrarDatosIngresoXdiaNroTicket(ByVal asdiaNroTicket As [String]) As EEDiarioPEM
        Return DiarioPEMDAS.MostrarRinconadaDatosIngresoXdiaNroTicket(asdiaNroTicket)
    End Function

    Public Function diariopemMostrarCapacidadXtgTipoVehiculoId(ByVal astgTipoVehiculoId As [String]) As Integer
        Return DiarioPEMDAS.MostrarCapacidadXtgTipoVehiculoId(astgTipoVehiculoId)
    End Function
    Public Function diarioRinconadaMostrarCapacidadXtgTipoVehiculoId(ByVal astgTipoVehiculoId As [String]) As Integer
        Return DiarioPEMDAS.MostrarRincondaCapacidadXtgTipoVehiculoId(astgTipoVehiculoId)
    End Function
    Public Function diariopemListarXtgEstadoIdXconId(ByVal asTgEstadoId As [String], ByVal asConID As [String]) As List(Of EEDiarioPEM)
        Return DiarioPEMDAS.ListarXtgEstadoIdXConId(asTgEstadoId, asConID)
    End Function

    Public Function diarioRinconadaListarXtgEstadoIdXconId(ByVal asTgEstadoId As [String], ByVal asConID As [String]) As List(Of EEDiarioPEM)
        Return DiarioPEMDAS.ListarRinconadaXtgEstadoIdXConId(asTgEstadoId, asConID)
    End Function

    Public Function diarioRinconadaListarPreTrasDelDia(ByVal fecha As Date) As List(Of EEDiarioPEM)
        Return DiarioPEMDAS.ListarRinconadaXPreTrasDelDia(fecha)
    End Function

    Public Function diariopemListarParaExtorno_XFecha(ByVal adFecha As DateTime) As List(Of EEDiarioPEM)
        Return DiarioPEMDAS.listarParaExtorno_XFecha(adFecha)
    End Function

    Public Function diarioRinconadaListarParaExtorno_XFecha(ByVal adFecha As DateTime) As List(Of EEDiarioPEM)
        Return DiarioPEMDAS.listarRinconadaParaExtorno_XFecha(adFecha)
    End Function

    Public Function boleteriaRinconadaExtornoXBolCod(ByVal BolCod As String) As Boolean
        Return boleteriaDAO.ExtornarXBolCod(BolCod)
    End Function


    Public Function diariopemlistarDetalleEnReportePEM_XAbonFechaFin(ByVal adFecha As DateTime) As List(Of EEAbonoPEM)
        Return AbonoPEMDAS.listarDetalleEnReportePEMXAbonDetFecha(1, adFecha)
    End Function

    Public Function diariopemReporteXFechasXtgEstadoIdXOPtgTipoVehiculoIdXOPConId(ByVal adFechaIni As Date, ByVal adFechaFin As Date, ByVal astgEstadoId As [String], Optional ByVal asTgTipoVehiculoId As String = Nothing, Optional ByVal asConId As [String] = Nothing, Optional ByVal asTgTipoAbonId As [String] = Nothing) As List(Of EEDiarioPEM)
        Return DiarioPEMDAS.ReporteXFechasXtgEstadoIdXOPtgTipoVehiculoIdXOPConId(adFechaIni, adFechaFin, astgEstadoId, asTgTipoVehiculoId, asConId, asTgTipoAbonId)
    End Function

    Public Function anbonopemListarNroCuotasNoPagadasXAbonId(ByVal asAbonId As [String]) As List(Of EEAbonoPEM.EEAbonoDetPEM)
        Return AbonoPEMDAS.listarNroCuotasNoPagadasXConAbonId(asAbonId)
    End Function

    ''' <summary>
    ''' REPORTE X FECHA
    ''' </summary>
    ''' <param name="aiTipo">0 = FECHA INGRESO, 1 = FECHA SALIDA, </param>
    ''' <param name="adFecha">FECHA</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function diariopemReporteXFecha(ByVal aiTipo As Int16, ByVal adFecha As Date) As List(Of EEDiarioPEM)
        Return DiarioPEMDAS.ReporteXFecha(aiTipo, adFecha)
    End Function
#End Region

#Region "Reglas VehiculoPEM"
    'Public Function vehiculopemGuardar(ByVal aoVehiculoPEM As EEVehiculoPEM) As Boolean
    '    Return VehiculoPEMDAO.guardar(aoVehiculoPEM)
    'End Function

    Public Function vehiculopemMostrarTgTipoVehIdXVehNPlaca(ByVal asVehNPlaca As [String]) As EEVehiculoPEM
        Return VehiculoPEMDAS.MostrarTgTipoVehIdXVehNPlaca(asVehNPlaca)
    End Function


#End Region

#Region "Reglas AbonoPEM"
    Public Function abonopemGuardar(ByVal aoAbonoPEM As EEAbonoPEM) As Boolean
        Return AbonoPEMDAO.guardar(aoAbonoPEM)
    End Function

    Public Function abonopemActualizar(ByVal aoAbonoPEM As EEAbonoPEM) As Boolean
        Return AbonoPEMDAO.Actualizar(aoAbonoPEM)
    End Function

    Public Function abonopemGuardarDetalle(ByVal aoAbonoPEM As EEAbonoPEM) As Boolean
        Return AbonoPEMDAO.guardarDetalle(aoAbonoPEM)
    End Function

    Public Function abonopemMostrarAbonadoActivoXabonNPlaca(ByVal asAbonNPlaca As [String]) As EEAbonoPEM
        Return AbonoPEMDAS.AbonadoActivoXabonNPlaca(asAbonNPlaca)
    End Function

    Public Function abonopemListarParaExtorno_XCriterios(ByVal tipocriterio As Int16, ByVal criterio As String) As List(Of EEAbonoPEM)
        Return AbonoPEMDAS.listarParaExtorno_XCriterios(tipocriterio, criterio)
    End Function
    Public Function abonopemListarXtgEstadoId_XconId(ByVal astgEstadoId As String, ByVal asConId As String) As List(Of EEAbonoPEM)
        Return AbonoPEMDAS.listarXtgEstadoId_XConId(astgEstadoId, asConId)
    End Function

    Public Function abonopemReporteXFechasXtgEstadoIdXOPtgTipoVehiculoIdXOPConId(ByVal adFechaIni As Date, ByVal adFechaFin As Date, ByVal astgEstadoId As [String], Optional ByVal asTgTipoVehiculoId As String = Nothing, Optional ByVal asConId As [String] = Nothing) As List(Of EEAbonoPEM)
        Return AbonoPEMDAS.ReporteXFechasXtgEstadoIdXOPtgTipoVehiculoIdXOPConId(adFechaIni, adFechaFin, astgEstadoId, asTgTipoVehiculoId, asConId)
    End Function

    Public Function abonopemListarDetalleAbono(ByVal aiTipoCriterio As Int16, ByVal asCriterio As String) As List(Of EEAbonoPEM)
        Return AbonoPEMDAS.listarDetalleAbono(aiTipoCriterio, asCriterio)
    End Function

    Public Function abonopemListarCriterios(ByVal aiTipoCriterio As Int16, ByVal asCriterio As String) As List(Of EEAbonoPEM)
        Return AbonoPEMDAS.listarCriterios(aiTipoCriterio, asCriterio)
    End Function

    Public Function abonopemListarXAbonId(ByVal asAbonId As String) As EEAbonoPEM
        Return AbonoPEMDAS.listarXAbonId(asAbonId)
    End Function

    Public Function abonopemMostrarAbonadoActivoPendienteXabonNPlacaXAbonDetFechaIni(ByVal asAbonNPlaca As [String], ByVal adAbonDetFechaIni As Date) As EEAbonoPEM
        Return AbonoPEMDAS.AbonadoActivoPendienteXabonNPlacaXAbonDetFechaIni(asAbonNPlaca, adAbonDetFechaIni)
    End Function

    Public Function abonopemListarDetalleXAbonId(ByVal asAbonId As String) As EEAbonoPEM
        Return AbonoPEMDAS.listarDetalleXAbonId(asAbonId)
    End Function

    Public Function abonoDetpemListarNroCuotasNoPagadasXAbonId(ByVal asAbonId As [String]) As List(Of EEAbonoPEM.EEAbonoDetPEM)
        Return AbonoPEMDAS.listarNroCuotasNoPagadasXConAbonId(asAbonId)
    End Function

    Public Function abonoDetpemMostrarNroCuotasALLXAbonId(ByVal asAbonId As [String]) As Int32
        Return AbonoPEMDAS.mostrarNroCuotasALLXAbonId(asAbonId)
    End Function

    Public Function abonoDetpemValidarNroCuotasNoPagadasXAbonPlaca(ByVal asAbonPlaca As [String]) As Int16
        Return AbonoPEMDAS.ValidarNroCuotasNoPagadasXAbonPlaca(asAbonPlaca)
    End Function

    Public Function abonoPEMMostrarPuedeEditar(ByVal asAbonId As [String]) As Boolean
        Return AbonoPEMDAS.MostrarPuedeEditar_XabonId_pa(asAbonId)
    End Function

    ''' <summary>
    ''' LISTAR DETALLE ABONO EN REPORTE X FECHA
    ''' </summary>
    ''' <param name="aiTipo">0 = FECHA INICIO, 1 = FECHA FIN</param>
    ''' <param name="adAbonFecha">FECHA</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function abonodetpemListarDetalleEnReportePEMXAbonDetFecha(ByVal aiTipo As Int16, ByVal adAbonFecha As Date) As List(Of EEAbonoPEM)
        Return AbonoPEMDAS.listarDetalleEnReportePEMXAbonDetFecha(aiTipo, adAbonFecha)
    End Function
#End Region

#Region "Reglas AbonExtorno"
    Public Function abonextornoGuardarExtonoAbono(ByVal aoAbonExtorno As EEAbonExtorno) As Boolean
        Return AbonExtornoDAO.guardarExtonoAbono(aoAbonExtorno)
    End Function

    Public Function abonextornoGuardarExtonoAbono(ByVal loAbonExtorno As List(Of EEAbonExtorno)) As Boolean
        Return AbonExtornoDAO.guardarListaExtornosAbono(loAbonExtorno)
    End Function

    Public Function abonextornoGuardarExtonoDiario(ByVal aoAbonExtorno As EEAbonExtorno) As Boolean
        Return AbonExtornoDAO.guardarExtonoDiario(aoAbonExtorno)
    End Function

    Public Function diarioRinconadaExtornoGuardar(ByVal aoAbonExtorno As EEAbonExtorno) As Boolean
        Return AbonExtornoDAO.guardarRinconadaExtornoDiario(aoAbonExtorno)
    End Function
#End Region

#Region "Reglas DocInternoSTD"
    Public Function docinternostdGuardar(ByVal aoDocInternoSTD As EEDocInternoSTD) As Boolean
        Return DocInternoSTDDAO.guardar(aoDocInternoSTD)
    End Function

    Public Function docinternostdActualizar(ByVal aoDocInternoSTD As EEDocInternoSTD) As Boolean
        Return DocInternoSTDDAO.actualizar(aoDocInternoSTD)
    End Function

    Public Function docinternostdListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocInternoSTD)
        Return DocInternoSTDDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function documentosInternoGenerarCodigo() As String
        Return DocInternoSTDDAS.NewCodigo()
    End Function

    Public Function docinternostdPivotearXFechaIni_XFechaFin(ByVal adFechaInicio As Date, ByVal adFechaFin As Date) As List(Of EEDocInternoSTD)
        Return DocInternoSTDDAS.pivotearXFechaIni_XFechaFin(adFechaInicio, adFechaFin)
    End Function
#End Region

#Region "Reglas Reporte Orden Servicio"

#End Region

#Region "Cargos General Tramite Doc"
    Public Function cargoListarBCriterio(ByVal asTCriterio As [String], ByVal asCriterio As [String]) As List(Of EECargo)
        Return CargosDAS.listarCargosXBcriterio(asTCriterio, asCriterio)
    End Function
#End Region

#Region "Reglas InmBajas"
    Public Function inmbajasGuardar(ByVal aoInmuebleBajas As EEInmueble.EEInmBajas) As Boolean
        Return InmBajasDAO.guardar(aoInmuebleBajas)
    End Function
    Public Function inmbajasInmueblesGuardar(ByVal aoInmueble As EEInmueble) As Boolean
        Return InmBajasDAO.InmuebleGuardar(aoInmueble)
    End Function

    Public Function inmbajasUpdateInmbajaDocArchivo(ByVal aoInmBajas As EEInmueble.EEInmBajas) As Boolean
        Return InmBajasDAO.ActualizarInmbajaDocArchivo(aoInmBajas)
    End Function

    Public Function inmbajasxInmBajaId(ByVal InmBajaId As [String]) As EEInmueble.EEInmBajas
        Return InmBajasDAS.MostrarxInmId(InmBajaId)
    End Function





    'Public Function inmbajasListarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEInmBajas)
    '    Return InmBajasDAS.listarCriterio(aiTipoCriterio, asCriterio)
    'End Function
#End Region


#Region "Reglas Procesos"
    Public Function procesosNewCodigo() As String
        Return ProcesosDAS.NewCodigo()
    End Function
    Public Function procesosGuardar(ByVal loProcesos As EEProcesos) As [Boolean]
        Return ProcesosDAO.guardar(loProcesos)
    End Function

    Public Function procesosActualizar(ByVal loProcesos As EEProcesos) As [Boolean]
        Return ProcesosDAO.actualizar(loProcesos)
    End Function

    Public Function procesosListarXCriterios(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEProcesos)
        Return ProcesosDAS.listarCriterio(aiTipoCriterio, asCriterio)
    End Function

    Public Function procesosListarActivos() As List(Of EEProcesos)
        Return ProcesosDAS.listarActivos()
    End Function



#End Region

#Region "Reglas Sub Procesos"

    Public Function subprocesosNewCodigo() As String
        Return SubProcesosDAS.NewCodigo()
    End Function

    Public Function subprocesosInsertarU(ByVal loProcesos As List(Of EESubProcesos)) As [Boolean]
        Return SubProcesosDAO.InsertarU(loProcesos)
    End Function

    Public Function subprocesosXProcId(ByVal sSubProcId As String) As List(Of EESubProcesos)
        Return SubProcesosDAS.listarXProcId(sSubProcId)
    End Function
#End Region

#Region "Reglas Procedimientos"

    Public Function procedimientosNewCodigo(ByVal subProcId As String) As [String]
        Return ProcedimientosDAS.NewCodigo(subProcId)
    End Function

    Public Function procedimientosGuardar(ByVal voProcedimientos As EEProcedimientos) As [Boolean]
        Return ProcedimientosDAO.guardar(voProcedimientos)
    End Function

    Public Function procedimientosActualizar(ByVal voProcedimientos As EEProcedimientos) As [Boolean]
        Return ProcedimientosDAO.actualizar(voProcedimientos)
    End Function

    Public Function procedimientosListarXCriterios(ByVal viTipoCriterio As Int32, ByVal vsCriterio As [String]) As List(Of EEProcedimientos)
        Return ProcedimientosDAS.listarCriterio(viTipoCriterio, vsCriterio)
    End Function

    Public Function procedimientosMostrarXProcId_subProcId_procdId(ByVal ProcdId As [String]) As EEProcedimientos
        Return ProcedimientosDAS.MostrarxProcdId(ProcdId)
    End Function

    Public Function procedimientosListarXSubProcId(ByVal subProcId As [String]) As List(Of EEProcedimientos)
        Return ProcedimientosDAS.ListarXSubProcId(subProcId)
    End Function

    Public Function procedimientosListarProcesosSubProcesosActivos() As List(Of EEProcesos)
        Return ProcedimientosDAS.listar_procedimientos_subprocesos_procesos_Activos()
    End Function

#End Region

#Region "Reglas Solicitudes"

    Public Function solicitudesNewCodigo() As [String]
        Return SolicitudesDAS.NewCodigo()
    End Function

    Public Function solicitudesGuardar(ByVal voSolicitudes As EESolicitudes) As [Boolean]
        Return SolicitudesDAO.guardar(voSolicitudes)
    End Function

    Public Function solicitudesActualizar(ByVal voSolicitudes As EESolicitudes) As [Boolean]
        Return SolicitudesDAO.actualizar(voSolicitudes)
    End Function

    Public Function solicitudesListarXCriterios(ByVal viTipoCriterio As Int32, ByVal vsCriterio As [String]) As List(Of EESolicitudes)
        Return SolicitudesDAS.listarCriterio(viTipoCriterio, vsCriterio)
    End Function

    Public Function solicitudesMostrarXSolId_SubProcId(ByVal vSolId As String, ByVal SubProcId As String) As EESolicitudes
        Return SolicitudesDAS.MostrarXSolId_SubProcId(vSolId, SubProcId)
    End Function

    Public Function solicitudesListarxTgAreaId(ByVal TgAreaId As String, Optional ByVal estadoSol As String = "", Optional ByVal fechaInicio As Date = Nothing, Optional ByVal fechaFin As Date = Nothing) As List(Of EEProcesos)
        Return SolicitudesDAS.listarxTgAreaId(TgAreaId, estadoSol, fechaInicio, fechaFin)
    End Function
#End Region

#Region "Reglas MovimientosProcedimientos"

    Public Function movimientosprocedimientosGuardar(ByVal voMovimientosProcedimientos As EEProcedimientosMov) As [Boolean]
        Return ProcedimientosMovDAO.guardar(voMovimientosProcedimientos)
    End Function

    Public Function procedimientosactXMovProcdId(ByVal viMovProcdId As String) As List(Of EEProcedimientosAct)
        Return ProcedimientosActDAS.listarXMovProcdId(viMovProcdId)
    End Function

    Public Function procedimientosMovMostrarProcdIdXSolId(ByVal SolId As String) As String
        Return ProcedimientosMovDAS.MostrarProcdIdXSolId(SolId)
    End Function

    Public Function procedimientosMovListarXSolId(ByVal SolId As String) As List(Of EEProcedimientosMov)
        Return ProcedimientosMovDAS.ListarXSolId(SolId)
    End Function

    Public Function procedimientosMovMostrarEstadoXSolIdprocdId(ByVal SolId As String, ByVal procdId As String) As String
        Return ProcedimientosMovDAS.MostrarEstadoXSolIdProcdId(SolId, procdId)
    End Function
#End Region

#Region "Reglas ExpedienteSTD"
    Public Function expedienteSTDGuardar(ByVal loExpedienteSTD As EEExpedienteSTD) As [Boolean]
        Return ExpedienteSTDDAO.guardar(loExpedienteSTD)
    End Function

    Public Function expedienteSTDListarVinculadosXDocId(ByVal vDocId As String) As List(Of EEExpedienteSTD)
        Return ExpedienteSTDDAS.listarVinculadosXDocId(vDocId)
    End Function

    Public Function expedienteSTDMostrarXDocId(ByVal vDocId As String) As EEExpedienteSTD
        Return ExpedienteSTDDAS.MostrarXDocId(vDocId)
    End Function

    Public Function expedienteSTDListarXDocId(ByVal vDocId As String) As List(Of EEExpedienteSTD)
        Return ExpedienteSTDDAS.ListarXDocId(vDocId)
    End Function
#End Region


End Class
