﻿Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class ContratoInmDAS

#Region "Listar Criterio"
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Short, ByVal asCriterio As [String]) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim dr As IDataReader = Nothing
        Dim drConArchivos As IDataReader = Nothing

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ContratoInm_Criterio_pa")
            db.AddInParameter(cmd, "TipoCriterio", DbType.Int16, aiTipoCriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If
                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("conInmId").ToString()
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("conInmFecIni")), Nothing, dr("conInmFecIni"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("conInmFecFin")), Nothing, dr("conInmFecFin"))
                loInmueble = New EEInmueble()
                loInmueble.InmUbicacion = dr("inmUbicacion").ToString()
                loContratoInm.ConInmId = dr("conInmId").ToString()
                loContratoInm.OInmueble = loInmueble
                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm Criterio => " + ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#End Region

#Region "Listar ALL"
    Public Shared Function listarALL() As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim dr As IDataReader = Nothing
        Dim drConArchivos As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ContratoInm_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = Convert.ToInt32(dr("IdCon").ToString())
                loContratoInm.InmId = Convert.ToInt32(dr("IdInm").ToString())
                loContratoInm.ConInmDocRef = dr("NumRefCon").ToString()
                loContratoInm.TgModId = Convert.ToInt32(dr("ModCon").ToString())
                loContratoInm.PerId = dr("CodPer").ToString()
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("FecIniCon")), Nothing, dr("FecIniCon"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("FecFinCon")), Nothing, dr("FecFinCon"))
                loContratoInm.ConInmFecReg = IIf(IsDBNull(dr("FecRegCon")), Nothing, dr("FecRegCon"))
                loContratoInm.ConInmMerced = Convert.ToDecimal(dr("ValMerced").ToString())
                loContratoInm.ConInmDiaMaxVen = Convert.ToInt32(dr("DiaVenCon").ToString())

                'Archivos
                cmd = db.GetStoredProcCommand("Mostrar_ConInmArchivos_XConInmId_pa")
                db.AddInParameter(cmd, "ConInmId", DbType.String, loContratoInm.ConInmId)
                drConArchivos = db.ExecuteReader(cmd)
                While drConArchivos.Read()
                    Dim loConInmArchivos As EEConArchivos = New EEConArchivos()

                    loConInmArchivos.ConArchId = drConArchivos("ConInmArchId").ToString()
                    loConInmArchivos.ConInmId = drConArchivos("ConInmId").ToString()
                    loConInmArchivos.ConInmArchNombre = drConArchivos("ConInmArchNombre").ToString()
                    loConInmArchivos.ConInmArchDescripcion = drConArchivos("ConInmArchDescripcion").ToString()
                    loConInmArchivos.TgTipoArchId = drConArchivos("TgTipoArchId").ToString()
                    loConInmArchivos.ConInmArch = DirectCast(drConArchivos("ConInmArch"), Byte())
                    loConInmArchivos.ConInmArchExt = drConArchivos("ConInmArchExt").ToString()

                    loConInmArchivos.TgNombre = drConArchivos("tgNombre").ToString()
                    loContratoInm.ListaConInmArchivos.Add(loConInmArchivos)
                End While
                drConArchivos.Close()

                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ALL ContratoInm => " & ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#End Region

#Region "Listar XPerId Contrato"
    Public Shared Function listarXPerId(ByVal asPerId As [String]) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Dim drConArchivos As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ContratoInm_XPerId_pa")
            db.AddInParameter(cmd, "PerId", DbType.String, asPerId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If
                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("conInmId").ToString()
                loContratoInm.InmId = dr("inmId").ToString()
                loContratoInm.ConInmDocRef = dr("conInmDocRef").ToString()
                loContratoInm.PerId = dr("perId").ToString()
                loContratoInm.ConInmGarantia = IIf(IsDBNull(dr("conInmGarantia")), Nothing, dr("conInmGarantia"))
                loContratoInm.ConInmDerLlaves = IIf(IsDBNull(dr("ConInmDerLlaves")), Nothing, dr("ConInmDerLlaves"))
                loContratoInm.ConInmMerced = IIf(IsDBNull(dr("ConInmMerced")), Nothing, dr("ConInmMerced"))
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("conInmFecIni")), Nothing, dr("conInmFecIni"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("conInmFecFin")), Nothing, dr("conInmFecFin"))
                loContratoInm.ConInmFecReg = IIf(IsDBNull(dr("conInmFecReg")), Nothing, dr("conInmFecReg"))
                loContratoInm.ConInmFecSol = IIf(IsDBNull(dr("ConInmFecSol")), Nothing, dr("ConInmFecSol"))
                loContratoInm.ConInmFecSus = IIf(IsDBNull(dr("ConInmFecSus")), Nothing, dr("ConInmFecSus"))
                loContratoInm.conInmRegMesPart = dr("conInmRegMesPart").ToString()
                loContratoInm.ConInmDiaMaxVen = Convert.ToInt32(dr("conInmDiaMaxVen").ToString())
                loContratoInm.TgUsoId = dr("tgUsoId").ToString()
                loContratoInm.TgEstId = dr("tgEstId").ToString()
                loContratoInm.TgModId = dr("tgModId").ToString()
                loContratoInm.TgMonId = dr("tgMonId").ToString()
                loContratoInm.tgCompId = dr("tgCompId").ToString()
                loContratoInm.TgGarId = dr("tgGarId").ToString()
                loContratoInm.ConInmObs = dr("conInmObs").ToString()
                loContratoInm.InmDir = dr("inmDirCon").ToString()
                loContratoInm.InmDepartamento = dr("InmDepartamento").ToString()
                loContratoInm.InmDistrito = dr("InmDistrito").ToString()
                loContratoInm.InmProvincia = dr("InmProvincia").ToString()
                'Archivos
                cmd = db.GetStoredProcCommand("Mostrar_ConInmArchivos_XConInmId_pa")
                db.AddInParameter(cmd, "ConInmId", DbType.String, loContratoInm.ConInmId)
                drConArchivos = db.ExecuteReader(cmd)
                While drConArchivos.Read()
                    Dim loConInmArchivos As EEConArchivos = New EEConArchivos()

                    loConInmArchivos.ConArchId = drConArchivos("ConInmArchId").ToString()
                    loConInmArchivos.ConInmId = drConArchivos("ConInmId").ToString()
                    loConInmArchivos.ConInmArchNombre = drConArchivos("ConInmArchNombre").ToString()
                    loConInmArchivos.ConInmArchDescripcion = drConArchivos("ConInmArchDescripcion").ToString()
                    loConInmArchivos.TgTipoArchId = drConArchivos("TgTipoArchId").ToString()
                    If IsDBNull(drConArchivos("ConInmArch")) Then
                        loConInmArchivos.ConInmArch = Nothing
                    Else
                        loConInmArchivos.ConInmArch = DirectCast(drConArchivos("ConInmArch"), Byte())
                    End If

                    loConInmArchivos.ConInmArchExt = drConArchivos("ConInmArchExt").ToString()

                    loConInmArchivos.TgNombre = drConArchivos("tgNombre").ToString()
                    loContratoInm.ListaConInmArchivos.Add(loConInmArchivos)
                End While
                drConArchivos.Close()
                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm Por PerId => " + ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#End Region

#Region "Listar Datos Adicionales del Contrato"
    Public Shared Function listarDatosAdicionalesXConInmId(ByVal ConInmId As [String]) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Contrato_Datos_Adicionales_XConInmId")
            db.AddInParameter(cmd, "ConInmId", DbType.String, ConInmId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If
                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("conInmId").ToString()
                loContratoInm.inmPartidaElec = dr("inmPartidaElec").ToString()
                loContratoInm.inmPredArea = dr("inmPredArea").ToString()
                loContratoInm.AnioAnt = dr("AnioAnt").ToString()
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("conInmFecIniAnt")), Nothing, dr("conInmFecIniAnt"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("conInmFecFinAnt")), Nothing, dr("conInmFecFinAnt"))
                loContratoInm.ConInmFecSus = IIf(IsDBNull(dr("conInmFecSusAnt")), Nothing, dr("conInmFecSusAnt"))
                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm Por PerId => " + ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function

#End Region

#Region "Listar XPerId En Programacion Pagos"
    Public Shared Function listarXPerIdProgramacionPagos(ByVal asPerId As [String]) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loProPagosDetalle As EEProPagos.EEProPagosDet = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim dr As IDataReader = Nothing
        Dim drProPag As IDataReader = Nothing
        Dim drProPagDetalle As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ContratoInm_XPerId_EnProgramacionPagos_pa")
            db.AddInParameter(cmd, "PerId", DbType.String, asPerId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("conInmId").ToString()
                loContratoInm.InmId = dr("inmId").ToString()
                loContratoInm.ConInmDocRef = dr("conInmDocRef").ToString()
                loContratoInm.PerId = dr("perId").ToString()
                loContratoInm.ConInmGarantia = IIf(IsDBNull(dr("conInmGarantia")), Nothing, dr("conInmGarantia"))
                loContratoInm.ConInmDerLlaves = IIf(IsDBNull(dr("ConInmDerLlaves")), Nothing, dr("ConInmDerLlaves"))
                loContratoInm.ConInmMerced = IIf(IsDBNull(dr("ConInmMerced")), Nothing, dr("ConInmMerced"))
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("conInmFecIni")), Nothing, dr("conInmFecIni"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("conInmFecFin")), Nothing, dr("conInmFecFin"))
                loContratoInm.ConInmFecReg = IIf(IsDBNull(dr("conInmFecReg")), Nothing, dr("conInmFecReg"))
                loContratoInm.ConInmDiaMaxVen = Convert.ToInt32(dr("conInmDiaMaxVen").ToString())

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgUsoId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreUso").ToString()

                loContratoInm.OTgUso = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgEstId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreInmEstado").ToString()

                loContratoInm.OTgEstado = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgMonId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreMoneda").ToString()

                loContratoInm.OTgMoneda = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgCompId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreComp").ToString()

                loContratoInm.OTgComprobante = loTablaGeneral

                loContratoInm.ConInmObs = dr("conInmObs").ToString()
                loContratoInm.InmDir = dr("inmDirCon").ToString()

                cmd = db.GetStoredProcCommand("Mostrar_ProPagos_XConInmId_EnProgramacionPagos_pa")
                db.AddInParameter(cmd, "coninmid", DbType.String, loContratoInm.ConInmId)

                drProPag = db.ExecuteReader(cmd)
                While drProPag.Read()
                    loProPagos = New EEProPagos()

                    loProPagos.ProPaId = drProPag("ProPaId").ToString()
                    loProPagos.ProPaNroCuota = Convert.ToInt32(drProPag("ProPaNroCuota").ToString())

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("TgTipoCompId").ToString()
                    loTablaGeneral.TgNombre = drProPag("TgNombreComprobante").ToString()

                    loProPagos.OTgTipoComprobante = loTablaGeneral

                    loProPagos.ProPaFechaVen = IIf(IsDBNull(drProPag("ProPaFechaVen")), Nothing, drProPag("ProPaFechaVen"))
                    loProPagos.ProPaFechaPag = IIf(IsDBNull(drProPag("ProPaFechaPag")), Nothing, drProPag("ProPaFechaPag"))

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("tgEstadoId").ToString()
                    loTablaGeneral.TgNombre = drProPag("tgNombreEstado").ToString()
                    loTablaGeneral.TgExtra = drProPag("tgExtraEstado").ToString()

                    loProPagos.OTgEstado = loTablaGeneral

                    loProPagos.ProPaDetIgv = IIf(IsDBNull(drProPag("ProPaDetIgv")), Nothing, drProPag("ProPaDetIgv"))
                    loProPagos.ProPaAplicaD = drProPag("ProPaAplicaD").ToString()
                    loProPagos.ProPaPMora = Convert.ToDecimal(drProPag("ProPaPMora").ToString())
                    loProPagos.NroComprobante = drProPag("NroComprobante").ToString()

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("tgRecaudadoraId").ToString()
                    loTablaGeneral.TgNombre = drProPag("tgNombreRecaudadora").ToString()

                    loProPagos.OTgRecaudadora = loTablaGeneral

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("tgMonedaId").ToString()
                    loTablaGeneral.TgNombre = drProPag("tgNombreMoneda").ToString()

                    loProPagos.OTgMoneda = loTablaGeneral

                    If Not IsDBNull(drProPag("ProPaComision")) Then
                        loProPagos.ProPaComision = Convert.ToDecimal(drProPag("ProPaComision").ToString())
                    End If

                    cmd = db.GetStoredProcCommand("Listar_ProPagosDet_XProPaId_pa")
                    db.AddInParameter(cmd, "proPaId", DbType.String, loProPagos.ProPaId)
                    drProPagDetalle = db.ExecuteReader(cmd)
                    While drProPagDetalle.Read()
                        If loProPagos.ListaProgramacionPagosDetalle Is Nothing Then
                            loProPagos.ListaProgramacionPagosDetalle = New List(Of EEProPagos.EEProPagosDet)
                        End If
                        loProPagosDetalle = New EEProPagos.EEProPagosDet()
                        loProPagosDetalle.ProPaDetMonto = Convert.ToDecimal(drProPagDetalle("ProPaDetMonto").ToString())
                        loProPagosDetalle.ProPaDetPConcepto = Convert.ToDecimal(drProPagDetalle("ProPaDetPConcepto").ToString())
                        loConceptos = New EEConceptos()
                        loConceptos.ConId = drProPagDetalle("ConId").ToString()
                        loConceptos.ConNombre = drProPagDetalle("ConNombre").ToString()
                        loProPagosDetalle.OConcepto = loConceptos
                        loProPagos.ListaProgramacionPagosDetalle.Add(loProPagosDetalle)
                    End While
                    drProPagDetalle.Close()
                    loContratoInm.ListaProgramacionPagos.Add(loProPagos)
                End While
                drProPag.Close()

                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm Por PerId En Programacion Pagos => " + ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#End Region

#Region "Listar XPerId O XInmId Consulta Programacion Pagos"
    ''' <summary>
    ''' Listar Contratos Por PerId o InmId en Consulta Programacion Pagos
    ''' </summary>
    ''' <param name="asPerId"></param>
    ''' <param name="asInmId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function listarXPerId_O_XInmIdConsultaProgramacionPagos(ByVal asPerId As String, ByVal asInmId As String) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ContratoInm_XPerId_O_XInmId_EnConsultorProgramacionPagos_pa")
            db.AddInParameter(cmd, "perid", DbType.String, asPerId)
            db.AddInParameter(cmd, "inmid", DbType.String, asInmId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()

                loContratoInm.ConInmId = dr("ConInmId").ToString()
                If dr("conInmObs") Is DBNull.Value Then
                    loContratoInm.ConInmObs = String.Empty
                Else
                    loContratoInm.ConInmObs = dr("conInmObs")
                End If
                If dr("Archivos") Is DBNull.Value Then
                    loContratoInm.Anexos = 0
                Else
                    loContratoInm.Anexos = CShort(dr("Archivos"))
                End If

                loInmueble = New EEInmueble()
                loInmueble.InmId = dr("InmId").ToString()

                loInmDireccion = New EEInmDireccion()
                loInmDireccion.InmDireccionCompleta = dr("InmDirCon").ToString()

                loInmueble.OInmDireccion = loInmDireccion
                loContratoInm.OInmueble = loInmueble

                If Not IsDBNull(dr("conInmFecIni")) Then
                    loContratoInm.ConInmFecIni = Convert.ToDateTime(dr("conInmFecIni").ToString())
                End If

                If Not IsDBNull(dr("conInmFecFin")) Then
                    loContratoInm.ConInmFecFin = Convert.ToDateTime(dr("conInmFecFin"))
                End If

                loContratoInm.ConInmDiaMaxVen = dr("ConInmDiaMaxVen").ToString()

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("TgNombreUso").ToString()
                loContratoInm.OTgUso = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreEstado").ToString()
                loContratoInm.OTgEstado = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreMoneda").ToString()
                loContratoInm.OTgMoneda = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreModalidad").ToString()
                loContratoInm.OTgModalidad = loTablaGeneral

                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm XPerId O XInmId Consulta Programacion Pagos => " + ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#End Region

#Region "Listar Criterio en Consulta Contrato Programacion Pagos"
    Public Shared Function listarCriterioEnConsultaContratoPP(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Consultar_ContratoInm_Criterio_EnConsultaContratoPP_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("conInmId").ToString()
                loContratoInm.InmId = dr("inmId").ToString()
                loContratoInm.ConInmGarantia = IIf(IsDBNull(dr("conInmGarantia")), Nothing, dr("conInmGarantia"))
                loContratoInm.ConInmDerLlaves = IIf(IsDBNull(dr("ConInmDerLlaves")), Nothing, dr("ConInmDerLlaves"))
                loContratoInm.ConInmMerced = IIf(IsDBNull(dr("ConInmMerced")), Nothing, dr("ConInmMerced"))
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("conInmFecIni")), Nothing, dr("conInmFecIni"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("conInmFecFin")), Nothing, dr("conInmFecFin"))

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgUsoId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreUso").ToString()

                loContratoInm.OTgUso = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgEstId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreEstado").ToString()

                loContratoInm.OTgEstado = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgMonId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreMoneda").ToString()

                loContratoInm.OTgMoneda = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgModId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreModalidad").ToString()

                loContratoInm.OTgModalidad = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgCompId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreComprobante").ToString()

                loContratoInm.OTgComprobante = loTablaGeneral

                loContratoInm.InmDir = dr("inmDirCon").ToString()

                loPersona = New EEPersona()
                loPersona.PerId = dr("perId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()
                loPersona.PerNDoc = dr("PerNDoc").ToString()
                loPersona.TgTipoPersId = dr("TgTipoPersId").ToString()

                loContratoInm.OPersona = loPersona

                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm Criterio => " + ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#End Region

#Region "Listar XInmId En Inmuebles"
    ''' <summary>
    ''' Listar Contratos Por InmId en Inmuebles
    ''' </summary>
    ''' <param name="asInmId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function listarXInmId_EnInmuebles(ByVal asInmId As String) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ContratoInm_XInmId_EnInmuebles_pa")
            db.AddInParameter(cmd, "inmid", DbType.String, asInmId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("ConInmId").ToString()

                loPersona = New EEPersona()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()

                loContratoInm.OPersona = loPersona

                loInmueble = New EEInmueble()
                loInmueble.InmId = dr("InmId").ToString()

                loContratoInm.OInmueble = loInmueble

                If Not IsDBNull(dr("ConInmFecIni")) Then
                    loContratoInm.ConInmFecIni = Convert.ToDateTime(dr("ConInmFecIni"))
                End If

                If Not IsDBNull(dr("ConInmFecFin")) Then
                    loContratoInm.ConInmFecFin = Convert.ToDateTime(dr("ConInmFecFin"))
                End If

                loContratoInm.ConInmDiaMaxVen = dr("ConInmDiaMaxVen").ToString()

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("TgUsoId").ToString()
                loTablaGeneral.TgNombre = dr("TgNombreUso").ToString()

                loContratoInm.OTgUso = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("TgEstId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreEstado").ToString()

                loContratoInm.OTgEstado = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("TgMonId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreMoneda").ToString()

                loContratoInm.OTgMoneda = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("TgModId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreModalidad").ToString()

                loContratoInm.OTgModalidad = loTablaGeneral

                loContratoInm.InmDir = dr("InmDirCon").ToString()

                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm XInmId En Inmuebles => " + ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#End Region

#Region "Listar X Año"
    Public Shared Function listarXAnio(ByVal asAnio As String) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmuebleDireccion As EEInmDireccion = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_RptDecoin_Contrato_by_Xanio")
            db.AddInParameter(cmd, "anio", DbType.String, asAnio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("ConInmId").ToString()

                loPersona = New EEPersona()
                loPersona.PerId = dr("perid").ToString()
                loPersona.PerNombres = dr("persona").ToString()
                loPersona.PerContacto = dr("contacto").ToString()
                loContratoInm.OPersona = loPersona
                loContratoInm.InmDir = dr("inmDirCon").ToString()
                loContratoInm.InmId = dr("InmId").ToString()
                loContratoInm.ConInmGarantia = dr("conInmGarantia").ToString()
                loContratoInm.ConInmMerced = dr("ConInmMerced").ToString()
                loContratoInm.ConInmFecSus = IIf(IsDBNull(dr("ConInmFecSus")), Nothing, dr("ConInmFecSus"))
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("ConInmFecIni")), Nothing, dr("ConInmFecIni"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("ConInmFecFin")), Nothing, dr("ConInmFecFin"))
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("TgNombreUso").ToString()
                loContratoInm.OTgUso = loTablaGeneral
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreEst").ToString()
                loContratoInm.OTgEstado = loTablaGeneral
                loContratoInm.ConInmObs = dr("conInmObs").ToString()
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreGar").ToString()
                loContratoInm.OTgGarantia = loTablaGeneral

                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm XInmId Consulta Programacion Pagos => " + ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#End Region
    Public Shared Function listarDiferenciaAnteriorXAnio(ByVal asAnio As String) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmuebleDireccion As EEInmDireccion = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_RptDecoin_ContratoDiferenciaAnterior_by_Xanio")
            db.AddInParameter(cmd, "anio", DbType.String, asAnio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("ConInmId").ToString()

                loPersona = New EEPersona()
                loPersona.PerId = dr("perid").ToString()
                loPersona.PerNombres = dr("persona").ToString()
                loPersona.PerContacto = dr("contacto").ToString()
                loContratoInm.OPersona = loPersona
                loContratoInm.InmDir = dr("inmDirCon").ToString()
                loContratoInm.InmId = dr("InmId").ToString()
                loContratoInm.ConInmGarantia = dr("conInmGarantia").ToString()
                loContratoInm.ConInmMerced = dr("ConInmMerced").ToString()
                loContratoInm.ConInmFecSus = IIf(IsDBNull(dr("ConInmFecSus")), Nothing, dr("ConInmFecSus"))
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("ConInmFecIni")), Nothing, dr("ConInmFecIni"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("ConInmFecFin")), Nothing, dr("ConInmFecFin"))
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("TgNombreUso").ToString()
                loContratoInm.OTgUso = loTablaGeneral
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreEst").ToString()
                loContratoInm.OTgEstado = loTablaGeneral
                loContratoInm.ConInmObs = dr("conInmObs").ToString()
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreGar").ToString()
                loContratoInm.OTgGarantia = loTablaGeneral

                ListaContratoInm.Add(loContratoInm)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm XInmId Consulta Programacion Pagos => " + ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#Region "Mostrar XPerId y XConInmId En ConsultarMora"
    ''' <summary>
    ''' Muestra El Contrato Con su Programación de Pagos Respectivo
    ''' </summary>
    ''' <param name="asPerId">PerId</param>
    ''' <param name="asConInmId">ConInmId</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function mostrarXPerIdXConInmId_EnConsultarMora(ByVal asPerId As String, ByVal asConInmId As String) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim dr As IDataReader = Nothing
        Dim drProPag As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("ConsultarMora_ContratoInm_XPerId_XConInmId_pa")
            db.AddInParameter(cmd, "perid", DbType.String, asPerId)
            db.AddInParameter(cmd, "coninmid", DbType.String, asConInmId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()
                loPersona.PerNDoc = dr("PerNDoc").ToString()
                loPersona.TgDocumento = dr("TgNombreTipoDocumento").ToString()
                loContratoInm.OPersona = loPersona

                loContratoInm.ConInmId = dr("ConInmId").ToString()

                loInmueble = New EEInmueble()
                loInmueble.InmId = dr("InmId").ToString()

                loInmDireccion = New EEInmDireccion()
                loInmDireccion.InmDireccionCompleta = dr("InmDirCon").ToString()

                loInmueble.OInmDireccion = loInmDireccion
                loContratoInm.OInmueble = loInmueble

                If Not IsDBNull(dr("conInmFecIni")) Then
                    loContratoInm.ConInmFecIni = Convert.ToDateTime(dr("conInmFecIni").ToString())
                End If

                If Not IsDBNull(dr("conInmFecFin")) Then
                    loContratoInm.ConInmFecFin = Convert.ToDateTime(dr("conInmFecFin").ToString())
                End If

                loContratoInm.ConInmDiaMaxVen = Convert.ToInt32(dr("conInmDiaMaxVen").ToString())

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreUso").ToString()
                loContratoInm.OTgUso = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreInmEstado").ToString()
                loContratoInm.OTgEstado = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreMoneda").ToString()
                loContratoInm.OTgMoneda = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgNombre = dr("tgNombreModalidad").ToString()
                loContratoInm.OTgModalidad = loTablaGeneral

                cmd = db.GetStoredProcCommand("Mostrar_ProPagos_XConInmId_EnConsultarMora_pa")
                db.AddInParameter(cmd, "coninmid", DbType.String, loContratoInm.ConInmId)

                drProPag = db.ExecuteReader(cmd)
                While drProPag.Read()
                    loProPagos = New EEProPagos()

                    loProPagos.ProPaId = drProPag("ProPaId").ToString()
                    loProPagos.ProPaNroCuota = Convert.ToInt32(drProPag("ProPaNroCuota").ToString())

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("TgTipoCompId").ToString()
                    loTablaGeneral.TgNombre = drProPag("TgNombreComprobante").ToString()

                    loProPagos.OTgTipoComprobante = loTablaGeneral

                    If Not IsDBNull(drProPag("ProPaFechaVen")) Then
                        loProPagos.ProPaFechaVen = Convert.ToDateTime(drProPag("ProPaFechaVen").ToString())
                    End If

                    If Not IsDBNull(drProPag("ProPaFechaPag")) Then
                        loProPagos.ProPaFechaPag = Convert.ToDateTime(drProPag("ProPaFechaPag").ToString())
                    End If

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("tgEstadoId").ToString()
                    loTablaGeneral.TgNombre = drProPag("tgNombreEstado").ToString()
                    loTablaGeneral.TgExtra = drProPag("tgExtraEstado").ToString()

                    loProPagos.OTgEstado = loTablaGeneral

                    If Not IsDBNull(drProPag("ProPaDetIgv")) Then
                        loProPagos.ProPaDetIgv = Convert.ToDecimal(drProPag("ProPaDetIgv").ToString())
                    End If

                    loProPagos.ProPaAplicaD = drProPag("ProPaAplicaD").ToString()
                    loProPagos.ProPaPMora = Convert.ToDecimal(drProPag("ProPaPMora").ToString())

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("tgRecaudadoraId").ToString()
                    loTablaGeneral.TgNombre = drProPag("tgNombreRecaudadora").ToString()

                    loProPagos.OTgRecaudadora = loTablaGeneral

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("tgMonedaId").ToString()
                    loTablaGeneral.TgNombre = drProPag("tgNombreMoneda").ToString()

                    loProPagos.OTgMoneda = loTablaGeneral

                    If Not IsDBNull(drProPag("ProPaComision")) Then
                        loProPagos.ProPaComision = Convert.ToDecimal(drProPag("ProPaComision").ToString())
                    End If

                    loContratoInm.ListaProgramacionPagos.Add(loProPagos)
                End While
                drProPag.Close()

                ListaContratoInm.Add(loContratoInm)
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Contrato XPerId y XConInmId en Consultar Mora => " & ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function
#End Region

#Region "Listar Contrato Archivos XConImId"
    Public Shared Function listarArchivosXConInmId(ByVal asConInmId As [String]) As List(Of EEConArchivos)
        Dim ListaConArchivos As List(Of EEConArchivos) = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_ConInmArchivos_XConInmId_pa")
            db.AddInParameter(cmd, "ConInmId", DbType.String, asConInmId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaConArchivos Is Nothing Then
                    ListaConArchivos = New List(Of EEConArchivos)()
                End If

                Dim loConInmArchivos As EEConArchivos = New EEConArchivos()
                loConInmArchivos.ConArchId = dr("ConInmArchId").ToString()
                loConInmArchivos.ConInmId = dr("ConInmId").ToString()
                loConInmArchivos.ConInmArchNombre = dr("ConInmArchNombre").ToString()
                loConInmArchivos.ConInmArchDescripcion = dr("ConInmArchDescripcion").ToString()
                loConInmArchivos.TgTipoArchId = dr("TgTipoArchId").ToString()
                If IsDBNull(dr("ConInmArch")) Then
                    loConInmArchivos.ConInmArch = Nothing
                Else
                    loConInmArchivos.ConInmArch = DirectCast(dr("ConInmArch"), Byte())
                End If

                loConInmArchivos.ConInmArchExt = dr("ConInmArchExt").ToString()
                loConInmArchivos.TgNombre = dr("tgNombre").ToString()
                ListaConArchivos.Add(loConInmArchivos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Archivos ContratoInm XConInmId => " + ex.Message, ex)
        End Try
        Return ListaConArchivos
    End Function
#End Region

#Region "Listar XConInmId En Programacion Pagos"
    Public Shared Function listarXConInmIdProgramacionPagos(ByVal asConInmId As [String]) As EEContratoInm
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loProPagosDetalle As EEProPagos.EEProPagosDet = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim loProPagos As EEProPagos = Nothing
        Dim dr As IDataReader = Nothing
        Dim drProPag As IDataReader = Nothing
        Dim drProPagDetalle As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ContratoInm_XConInmId_EnProgramacionPagos_pa")
            db.AddInParameter(cmd, "conInmId", DbType.String, asConInmId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("conInmId").ToString()
                loContratoInm.InmId = dr("inmId").ToString()
                loContratoInm.ConInmDocRef = dr("conInmDocRef").ToString()
                loContratoInm.PerId = dr("perId").ToString()
                loContratoInm.OPersona = New EEPersona()
                loContratoInm.OPersona.Persona = dr("Persona").ToString()
                loContratoInm.OPersona.PerNDoc = dr("PerNDoc").ToString()
                loContratoInm.OPersona.TgTipoPersId = dr("TgTipoPersId").ToString()
                loContratoInm.OPersona.TgTipoDoc = dr("TgTipoDocumento").ToString()

                loContratoInm.ConInmGarantia = IIf(IsDBNull(dr("conInmGarantia")), Nothing, dr("conInmGarantia"))
                loContratoInm.ConInmDerLlaves = IIf(IsDBNull(dr("ConInmDerLlaves")), Nothing, dr("ConInmDerLlaves"))
                loContratoInm.ConInmMerced = IIf(IsDBNull(dr("ConInmMerced")), Nothing, dr("ConInmMerced"))
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("conInmFecIni")), Nothing, dr("conInmFecIni"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("conInmFecFin")), Nothing, dr("conInmFecFin"))
                loContratoInm.ConInmFecReg = IIf(IsDBNull(dr("conInmFecReg")), Nothing, dr("conInmFecReg"))
                loContratoInm.ConInmDiaMaxVen = Convert.ToInt32(dr("conInmDiaMaxVen").ToString())

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgUsoId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreUso").ToString()

                loContratoInm.OTgUso = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgEstId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreInmEstado").ToString()

                loContratoInm.OTgEstado = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgMonId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreMoneda").ToString()

                loContratoInm.OTgMoneda = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("tgCompId").ToString()
                loTablaGeneral.TgNombre = dr("tgNombreComp").ToString()

                loContratoInm.OTgComprobante = loTablaGeneral

                loContratoInm.ConInmObs = dr("conInmObs").ToString()
                loContratoInm.InmDir = dr("inmDirCon").ToString()

                cmd = db.GetStoredProcCommand("Mostrar_ProPagos_XConInmId_EnProgramacionPagos_pa")
                db.AddInParameter(cmd, "coninmid", DbType.String, loContratoInm.ConInmId)

                drProPag = db.ExecuteReader(cmd)
                While drProPag.Read()
                    loProPagos = New EEProPagos()

                    loProPagos.ProPaId = drProPag("ProPaId").ToString()
                    loProPagos.ProPaNroCuota = Convert.ToInt32(drProPag("ProPaNroCuota").ToString())

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("TgTipoCompId").ToString()
                    loTablaGeneral.TgNombre = drProPag("TgNombreComprobante").ToString()

                    loProPagos.OTgTipoComprobante = loTablaGeneral

                    loProPagos.ProPaFechaVen = IIf(IsDBNull(drProPag("ProPaFechaVen")), Nothing, drProPag("ProPaFechaVen"))
                    loProPagos.ProPaFechaPag = IIf(IsDBNull(drProPag("ProPaFechaPag")), Nothing, drProPag("ProPaFechaPag"))

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("tgEstadoId").ToString()
                    loTablaGeneral.TgNombre = drProPag("tgNombreEstado").ToString()
                    loTablaGeneral.TgExtra = drProPag("tgExtraEstado").ToString()

                    loProPagos.OTgEstado = loTablaGeneral

                    loProPagos.ProPaDetIgv = IIf(IsDBNull(drProPag("ProPaDetIgv")), Nothing, drProPag("ProPaDetIgv"))
                    loProPagos.ProPaAplicaD = drProPag("ProPaAplicaD").ToString()
                    loProPagos.ProPaPMora = Convert.ToDecimal(drProPag("ProPaPMora").ToString())
                    loProPagos.NroComprobante = drProPag("NroComprobante").ToString()

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("tgRecaudadoraId").ToString()
                    loTablaGeneral.TgNombre = drProPag("tgNombreRecaudadora").ToString()

                    loProPagos.OTgRecaudadora = loTablaGeneral

                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = drProPag("tgMonedaId").ToString()
                    loTablaGeneral.TgNombre = drProPag("tgNombreMoneda").ToString()

                    loProPagos.OTgMoneda = loTablaGeneral

                    If Not IsDBNull(drProPag("ProPaComision")) Then
                        loProPagos.ProPaComision = Convert.ToDecimal(drProPag("ProPaComision").ToString())
                    End If

                    cmd = db.GetStoredProcCommand("Listar_ProPagosDet_XProPaId_pa")
                    db.AddInParameter(cmd, "proPaId", DbType.String, loProPagos.ProPaId)
                    drProPagDetalle = db.ExecuteReader(cmd)
                    While drProPagDetalle.Read()
                        If loProPagos.ListaProgramacionPagosDetalle Is Nothing Then
                            loProPagos.ListaProgramacionPagosDetalle = New List(Of EEProPagos.EEProPagosDet)
                        End If
                        loProPagosDetalle = New EEProPagos.EEProPagosDet()
                        loProPagosDetalle.ProPaDetMonto = Convert.ToDecimal(drProPagDetalle("ProPaDetMonto").ToString())
                        loProPagosDetalle.ProPaDetPConcepto = Convert.ToDecimal(drProPagDetalle("ProPaDetPConcepto").ToString())
                        loConceptos = New EEConceptos()
                        loConceptos.ConId = drProPagDetalle("ConId").ToString()
                        loConceptos.ConNombre = drProPagDetalle("ConNombre").ToString()
                        loProPagosDetalle.OConcepto = loConceptos
                        loProPagos.ListaProgramacionPagosDetalle.Add(loProPagosDetalle)
                    End While
                    drProPagDetalle.Close()
                    loContratoInm.ListaProgramacionPagos.Add(loProPagos)
                End While
                drProPag.Close()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm Por PerId En Programacion Pagos => " + ex.Message, ex)
        End Try
        Return loContratoInm
    End Function
#End Region

#Region "Mostrar XConInmId Contrato"
    Public Shared Function mostrarXConInmId(ByVal asConInmId As [String]) As EEContratoInm
        Dim loContratoInm As EEContratoInm = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Dim drConArchivos As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ContratoInm_XConInmId_pa")
            db.AddInParameter(cmd, "coninmid", DbType.String, asConInmId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loContratoInm = New EEContratoInm()
                loContratoInm.ConInmId = dr("conInmId").ToString()
                loContratoInm.InmId = dr("inmId").ToString()
                loContratoInm.ConInmDocRef = dr("conInmDocRef").ToString()

                loContratoInm.OPersona = New EEPersona()
                loContratoInm.OPersona.PerId = dr("perId").ToString()
                loContratoInm.OPersona.Persona = dr("Persona").ToString()
                loContratoInm.OPersona.PerNDoc = dr("PerNDoc").ToString()
                loContratoInm.OPersona.TgTipoPersId = dr("TgTipoPersId").ToString()
                loContratoInm.OPersona.TgTipoDoc = dr("TgTipoDocumento").ToString()
                loContratoInm.OPersona.PerObservacion = dr("PerObservacion").ToString()
                loContratoInm.OPersona.PerDireccion = dr("PerDireccion").ToString()
                loContratoInm.OPersona.PerDepartamento = dr("PerDepartamento").ToString()
                loContratoInm.OPersona.PerProvincia = dr("PerProvincia").ToString()
                loContratoInm.OPersona.PerDistrito = dr("PerDistrito").ToString()
                loContratoInm.OPersona.PerContacto = IIf(IsDBNull(dr("PerContacto")), String.Empty, dr("PerContacto").ToString())
                loContratoInm.ConInmGarantia = IIf(IsDBNull(dr("conInmGarantia")), Nothing, dr("conInmGarantia"))
                loContratoInm.ConInmDerLlaves = IIf(IsDBNull(dr("ConInmDerLlaves")), Nothing, dr("ConInmDerLlaves"))
                loContratoInm.ConInmMerced = IIf(IsDBNull(dr("ConInmMerced")), Nothing, dr("ConInmMerced"))
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("conInmFecIni")), Nothing, dr("conInmFecIni"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("conInmFecFin")), Nothing, dr("conInmFecFin"))
                loContratoInm.ConInmFecReg = IIf(IsDBNull(dr("conInmFecReg")), Nothing, dr("conInmFecReg"))
                loContratoInm.ConInmFecSol = IIf(IsDBNull(dr("ConInmFecSol")), Nothing, dr("ConInmFecSol"))
                loContratoInm.ConInmFecSus = IIf(IsDBNull(dr("ConInmFecSus")), Nothing, dr("ConInmFecSus"))
                loContratoInm.conInmRegMesPart = dr("conInmRegMesPart").ToString()
                loContratoInm.ConInmDiaMaxVen = Convert.ToInt32(dr("conInmDiaMaxVen").ToString())
                loContratoInm.TgUsoId = dr("tgUsoId").ToString()
                loContratoInm.TgEstId = dr("tgEstId").ToString()
                loContratoInm.TgModId = dr("tgModId").ToString()
                loContratoInm.TgMonId = dr("tgMonId").ToString()
                loContratoInm.tgCompId = dr("tgCompId").ToString()
                loContratoInm.TgGarId = dr("tgGarId").ToString()
                loContratoInm.ConInmObs = dr("conInmObs").ToString()
                loContratoInm.InmDir = dr("inmDirCon").ToString()
                loContratoInm.InmDepartamento = dr("InmDepartamento").ToString()
                loContratoInm.InmDistrito = dr("InmDistrito").ToString()
                loContratoInm.InmProvincia = dr("InmProvincia").ToString()
                'Archivos
                cmd = db.GetStoredProcCommand("Mostrar_ConInmArchivos_XConInmId_pa")
                db.AddInParameter(cmd, "ConInmId", DbType.String, loContratoInm.ConInmId)
                drConArchivos = db.ExecuteReader(cmd)
                While drConArchivos.Read()
                    Dim loConInmArchivos As EEConArchivos = New EEConArchivos()

                    loConInmArchivos.ConArchId = drConArchivos("ConInmArchId").ToString()
                    loConInmArchivos.ConInmId = drConArchivos("ConInmId").ToString()
                    loConInmArchivos.ConInmArchNombre = drConArchivos("ConInmArchNombre").ToString()
                    loConInmArchivos.ConInmArchDescripcion = drConArchivos("ConInmArchDescripcion").ToString()
                    loConInmArchivos.TgTipoArchId = drConArchivos("TgTipoArchId").ToString()
                    If IsDBNull(drConArchivos("ConInmArch")) Then
                        loConInmArchivos.ConInmArch = Nothing
                    Else
                        loConInmArchivos.ConInmArch = DirectCast(drConArchivos("ConInmArch"), Byte())
                    End If

                    loConInmArchivos.ConInmArchExt = drConArchivos("ConInmArchExt").ToString()

                    loConInmArchivos.TgNombre = drConArchivos("tgNombre").ToString()
                    loContratoInm.ListaConInmArchivos.Add(loConInmArchivos)
                End While
                drConArchivos.Close()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar ContratoInm XConInmId => " + ex.Message, ex)
        End Try
        Return loContratoInm
    End Function
#End Region

#Region "Mostrar Merced Condutiva XPerId"
    Public Shared Function mostrarMercedConductivaXPerId_InmId(ByVal asPerId As [String], ByVal asInmId As String) As Decimal
        Dim loMercedConductiva As Decimal = 0
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_ContratoInm_MercedConductiva_X_PerId_InmId")
            db.AddInParameter(cmd, "PerId", DbType.String, asPerId)
            db.AddInParameter(cmd, "InmId", DbType.String, asInmId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()

                loMercedConductiva = IIf(IsDBNull(dr("ConInmMerced")), 0, dr("ConInmMerced"))

            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Merced Conductiva X PerId => " + ex.Message, ex)
        End Try
        Return loMercedConductiva
    End Function
#End Region
End Class