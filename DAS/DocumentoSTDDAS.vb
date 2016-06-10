﻿Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class DocumentoSTDDAS
#Region "Listar Criterio"
    Public Shared Function MostrarxDocId(ByVal docId As [String], Optional ByVal movId As String = Nothing) As EEDocumentoSTD
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_DocumentoSTD_xDocId_pa")
            db.AddInParameter(cmd, "docId", DbType.String, docId)
            db.AddInParameter(cmd, "movId", DbType.String, movId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("DocId").ToString()
                loDocumentoSTD.DocOrigen = dr("DocOrigen").ToString()
                loDocumentoSTD.DocTupac = Convert.ToBoolean(dr("DocTupac").ToString())
                loDocumentoSTD.DocNReg = dr("DocNReg").ToString()
                loDocumentoSTD.DocNRegT = dr("DocNRegT").ToString()
                loDocumentoSTD.DocAño = dr("DocAño").ToString()
                loDocumentoSTD.DocSiglas = dr("DocSiglas").ToString()
                loDocumentoSTD.DocNFolio = Convert.ToInt32(IIf(IsDBNull(dr("DocNFolio")), 0, dr("DocNFolio")))
                loDocumentoSTD.DocFechaIng = IIf(IsDBNull(dr("DocFechaIng")), Nothing, dr("DocFechaIng"))
                loDocumentoSTD.DocAsunto = dr("DocAsunto").ToString()
                ' loDocumentoSTD.DocNParte = Convert.ToInt32(dr("DocNParte").ToString())
                loDocumentoSTD.DocConfReq = Convert.ToBoolean(dr("DocConfReq").ToString())
                loDocumentoSTD.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loDocumentoSTD.DocNRef = dr("DocNRef").ToString()
                loDocumentoSTD.DocCargoIdEdit = IIf(IsDBNull(dr("docCargoIdEdit")), Nothing, dr("docCargoIdEdit"))
                loDocumentoSTD.DocPerIdEdit = IIf(IsDBNull(dr("docPerIdEdit")), Nothing, dr("docPerIdEdit"))
                loDocumentoSTD.DocAux = dr("docAux").ToString()
                ' loDocumentoSTD.DocSumilla = dr("DocSumilla").ToString()
                loDocumentoSTD.DocComentario = dr("DocComentario").ToString()

                loDocumentoSTD.PerId = dr("PerId").ToString()
                loDocumentoSTD.perNombreOrigen = dr("PerNombres").ToString()
                loDocumentoSTD.perDireccion = dr("PerDireccion").ToString()

                loDocumentoSTD.TgTDocId = dr("TgTDocId").ToString()
                loDocumentoSTD.TgTDoc = dr("TgTDoc").ToString()
                loDocumentoSTD.TgMovTramiteId = dr("TgMovTramiteId").ToString()
                loDocumentoSTD.TgMovTramite = dr("TgMovTramite").ToString()
                loDocumentoSTD.TgInstitucionId = IIf(dr("TgInstitucionId") Is Nothing, "", dr("TgInstitucionId").ToString())
                loDocumentoSTD.TgInstitucion = dr("TgInstitucion").ToString()
                loDocumentoSTD.TgInstitucionInt = dr("TgInstitucionInt").ToString()
                loDocumentoSTD.TgInstitucionIntId = dr("TgInstitucionIntId").ToString()
                loDocumentoSTD.TgArea = dr("TgArea").ToString()
                loDocumentoSTD.TgAreaId = dr("TgAreaId").ToString()
                loDocumentoSTD.TgAreaIntId = dr("TgAreaIntId").ToString()
                loDocumentoSTD.TgAreaInt = dr("TgAreaInt").ToString()
                loDocumentoSTD.TgCargoIntId = dr("TgCargoIntId").ToString()
                loDocumentoSTD.TgCargoInt = dr("TgCargoInt").ToString()

                loDocumentoSTD.ProcId = dr("ProcId").ToString()
                loDocumentoSTD.procNombre = dr("ProcNombre").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD x DocId => " + ex.Message, ex)
        End Try
        Return loDocumentoSTD
    End Function

    Public Shared Function listarCriterio(ByVal docFechaIng As Date, ByVal docFechaFin As Date, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_DocumentoSTD_Buscar_Criterios_pa")
            'db.AddInParameter(cmd, "docFechaIng", DbType.String, docFechaIng)
            'db.AddInParameter(cmd, "docFechaFin", DbType.String, docFechaFin)
            db.AddInParameter(cmd, "docFechaIng", DbType.Date, docFechaIng.ToShortDateString)
            db.AddInParameter(cmd, "docFechaFin", DbType.Date, docFechaFin.ToShortDateString)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tpCriterio", DbType.Int32, aiTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("docId").ToString()
                loDocumentoSTD.DocNRegT = dr("docNRegT").ToString()
                'loDocumentoSTD.DocExpMPT1 = dr("docExpMPT").ToString()
                loDocumentoSTD.TgArea = dr("area").ToString()
                loDocumentoSTD.dependencia = dr("dependencia").ToString()
                loDocumentoSTD.DocAsunto = dr("docAsunto").ToString()
                loDocumentoSTD.perNombreOrigen = dr("PerNombres").ToString()
                loDocumentoSTD.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loDocumentoSTD.DocComentario = dr("docComentario").ToString()
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function

    Public Shared Function listarCriterioXInteresadoProcedimientoAsunto(ByVal docFechaIng As Date, ByVal docFechaFin As Date, Optional ByVal interesado As String = "", Optional ByVal procId As [String] = "", Optional ByVal asunto As String = "") As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_DocumentoSTD_Consultar_InteresadoProcedimientoAsunto_pa")
            'db.AddInParameter(cmd, "docFechaIng", DbType.String, docFechaIng)
            'db.AddInParameter(cmd, "docFechaFin", DbType.String, docFechaFin)
            db.AddInParameter(cmd, "docFechaIng", DbType.Date, docFechaIng.ToShortDateString)
            db.AddInParameter(cmd, "docFechaFin", DbType.Date, docFechaFin.ToShortDateString)

            If interesado <> String.Empty Then
                db.AddInParameter(cmd, "interesado", DbType.String, interesado)
            End If
            If procId <> String.Empty Then
                db.AddInParameter(cmd, "procId", DbType.String, procId)
            End If
            If asunto <> String.Empty Then
                db.AddInParameter(cmd, "asunto", DbType.String, asunto)
            End If

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("docId").ToString()
                loDocumentoSTD.DocNRegT = dr("docNRegT").ToString()
                'loDocumentoSTD.DocExpMPT1 = dr("docExpMPT").ToString()
                loDocumentoSTD.TgArea = dr("area").ToString()
                loDocumentoSTD.dependencia = dr("dependencia").ToString()
                loDocumentoSTD.indicador = dr("indicador").ToString()
                loDocumentoSTD.TgTDoc = dr("TgTDoc").ToString()
                loDocumentoSTD.DocEstado = dr("docEstado").ToString()
                loDocumentoSTD.DocDias = dr("docdias").ToString()
                loDocumentoSTD.DocAsunto = dr("docAsunto").ToString()
                loDocumentoSTD.perNombreOrigen = dr("Interesado").ToString()
                loDocumentoSTD.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loDocumentoSTD.DocComentario = dr("docComentario").ToString()
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio x Dependencia => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function


    Public Shared Function listarCriterioXMovPerParaDocEstado(ByVal docFechaIng As Date, ByVal docFechaFin As Date, ByVal movPerIdPara As String, ByVal docEstado As [String]) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_DocumentoSTD_Consultar_xMovPerIdPara_docEstado_pa")
            db.AddInParameter(cmd, "docFechaIng", DbType.Date, docFechaIng.ToShortDateString)
            db.AddInParameter(cmd, "docFechaFin", DbType.Date, docFechaFin.ToShortDateString)
            db.AddInParameter(cmd, "docEstado", DbType.String, docEstado)
            db.AddInParameter(cmd, "movPerIdPara", DbType.String, movPerIdPara)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("docId").ToString()
                loDocumentoSTD.DocNRegT = dr("docNRegT").ToString()
                'loDocumentoSTD.DocExpMPT1 = dr("docExpMPT").ToString()
                loDocumentoSTD.TgArea = dr("area").ToString()
                loDocumentoSTD.dependencia = dr("dependencia").ToString()
                loDocumentoSTD.indicador = dr("indicador").ToString()
                loDocumentoSTD.TgTDoc = dr("TgTDoc").ToString()
                loDocumentoSTD.DocEstado = dr("docEstado").ToString()
                loDocumentoSTD.DocDias = dr("docdias").ToString()
                loDocumentoSTD.DocAsunto = dr("docAsunto").ToString()
                loDocumentoSTD.perNombreOrigen = dr("Interesado").ToString()
                loDocumentoSTD.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loDocumentoSTD.DocComentario = dr("docComentario").ToString()
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio Para SGeneral => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function


    Public Shared Function listarCriterioXDependencia(ByVal docFechaIng As Date, ByVal docFechaFin As Date, ByVal dependencia As String, Optional ByVal area As [String] = "", Optional ByVal resultado As String = "") As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_DocumentoSTD_Consultar_Dependencia_pa")
            db.AddInParameter(cmd, "docFechaIng", DbType.Date, docFechaIng.ToShortDateString)
            db.AddInParameter(cmd, "docFechaFin", DbType.Date, docFechaFin.ToShortDateString)
            db.AddInParameter(cmd, "dependencia", DbType.String, dependencia)
            If area <> String.Empty Then
                db.AddInParameter(cmd, "area", DbType.String, area)
            End If
            If resultado <> String.Empty Then
                db.AddInParameter(cmd, "resultado", DbType.String, resultado)
            End If

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("docId").ToString()
                loDocumentoSTD.DocNRegT = dr("docNRegT").ToString()
                ' loDocumentoSTD.DocExpMPT1 = dr("docExpMPT").ToString()
                loDocumentoSTD.TgArea = dr("area").ToString()
                loDocumentoSTD.indicador = dr("indicador").ToString()
                loDocumentoSTD.TgTDoc = dr("TgTDoc").ToString()
                loDocumentoSTD.docEstado = dr("docEstado").ToString()
                loDocumentoSTD.DocDias = dr("docdias").ToString()
                loDocumentoSTD.DocAsunto = dr("docAsunto").ToString()
                loDocumentoSTD.perNombreOrigen = dr("Interesado").ToString()
                loDocumentoSTD.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loDocumentoSTD.DocComentario = dr("docComentario").ToString()
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio x Dependencia => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function



    Public Shared Function MostrarDatosXExpediente_Anio_Dependencia(ByVal NroExpediente As String, ByVal Anio As String, ByVal dependencia As String) As EEDocumentoSTD

        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_DatosGenerales_Persona_By_Nro_Expediente_Anio_Dependencia_pa")
            db.AddInParameter(cmd, "nroexp", DbType.String, NroExpediente)
            If Anio IsNot Nothing Then
                db.AddInParameter(cmd, "anio", DbType.String, Anio)
            End If
            If dependencia IsNot Nothing Then
                db.AddInParameter(cmd, "dependencia", DbType.String, dependencia)
            End If


            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                'If ListaDocumentoSTD Is Nothing Then
                '    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                'End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocNReg = dr("DocNReg").ToString()
                ' loDocumentoSTD.DocParte = dr("docNParte").ToString()
                loDocumentoSTD.DocFechaIng = IIf(IsDBNull(dr("docFechaIng")), Nothing, dr("docFechaIng"))
                loDocumentoSTD.perDireccion = dr("perDireccion").ToString()
                loDocumentoSTD.perDoc = dr("perNDoc").ToString()
                loDocumentoSTD.perNombreOrigen = dr("perNombres").ToString()
                loDocumentoSTD.DocComentario = dr("docComentario").ToString()
                ' ListaDocumentoSTD.Add(loDocumentoSTD)
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio => " + ex.Message, ex)
        End Try
        Return loDocumentoSTD
    End Function
    Public Shared Function MostrarDatosExpedientexFiltros_pa(ByVal loParametrosRptResumidoSTD As EERptResumidoSTD) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_ExpedientesSTD_by_Criterios_pa")
            'db.AddInParameter(cmd, "nroexp", DbType.String, NroExpediente)

            If loParametrosRptResumidoSTD.NroExpediente IsNot Nothing Then
                db.AddInParameter(cmd, "nroexp", DbType.String, loParametrosRptResumidoSTD.NroExpediente)
            End If
            If loParametrosRptResumidoSTD.perIntId IsNot Nothing Then
                db.AddInParameter(cmd, "perIntId", DbType.String, loParametrosRptResumidoSTD.perIntId)
            End If
            If loParametrosRptResumidoSTD.InstitucionID IsNot Nothing Then
                db.AddInParameter(cmd, "instId", DbType.String, loParametrosRptResumidoSTD.InstitucionId)
            End If
            If loParametrosRptResumidoSTD.Asunto IsNot Nothing Then
                db.AddInParameter(cmd, "asunto", DbType.String, loParametrosRptResumidoSTD.Asunto)
            End If
            If loParametrosRptResumidoSTD.año IsNot Nothing Then
                db.AddInParameter(cmd, "anio", DbType.String, loParametrosRptResumidoSTD.año)
            End If
            'If loParametrosRptResumidoSTD.dependencia IsNot Nothing Then
            '    db.AddInParameter(cmd, "dependencia", DbType.String, loParametrosRptResumidoSTD.dependencia)
            'End If
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocNReg = dr("DocNReg").ToString()
                'loDocumentoSTD.DocParte = dr("docNParte").ToString()
                'loDocumentoSTD.DocFechaIng = IIf(IsDBNull(dr("docFechaIng")), Nothing, dr("docFechaIng"))
                'loDocumentoSTD.perDireccion = dr("perDireccion").ToString()
                'loDocumentoSTD.perDoc = dr("perNDoc").ToString()
                'loDocumentoSTD.perNombre = dr("perNombres").ToString()
                loDocumentoSTD.DocComentario = dr("docComentario").ToString()
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function

    Public Shared Function MostrarDetalleExpedienteXdocAsunto(ByVal docAsunto As String, Optional ByVal docAño As String = Nothing) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_DetDocumentoSTD_X_docAsunto_pa")
            db.AddInParameter(cmd, "docAsunto", DbType.String, docAsunto)
            db.AddInParameter(cmd, "docaño", DbType.String, docaño)


            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("docId").ToString()
                loDocumentoSTD.DocNReg = dr("docNReg").ToString()
                loDocumentoSTD.DocAsunto = dr("docAsunto").ToString()
                loDocumentoSTD.DocNFolio = IIf(IsDBNull(dr("docNFolio")), 0, dr("docNFolio").ToString)
                loDocumentoSTD.DocFechaIng = IIf(IsDBNull(dr("docFechaIng")), Nothing, dr("docFechaIng"))
                loDocumentoSTD.OPersonaInteresada = New EEPersona
                loDocumentoSTD.OPersonaInteresada.PerId = dr("perId").ToString()
                loDocumentoSTD.OPersonaInteresada.PerNombreCompleto = dr("perIntNombres").ToString()
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal = New EECargoPersonal
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal.Institucion = dr("perIntTgInstitucion").ToString()
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal.Area = dr("perIntTgArea").ToString()
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function

    Public Shared Function MostrarDetalleExpedienteXtgIntitucionId(ByVal tgIntitucionPerInt As String, Optional ByVal docAño As String = Nothing) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_DetDocumentoSTD_X_tgIntitucionId_pa")
            db.AddInParameter(cmd, "tgInstitucionId", DbType.String, tgIntitucionPerInt)
            db.AddInParameter(cmd, "docAño", DbType.String, docAño)


            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("docId").ToString()
                loDocumentoSTD.DocNReg = dr("docNReg").ToString()
                loDocumentoSTD.DocAsunto = dr("docAsunto").ToString()
                loDocumentoSTD.DocNFolio = IIf(IsDBNull(dr("docNFolio")), 0, dr("docNFolio").ToString)
                loDocumentoSTD.DocFechaIng = IIf(IsDBNull(dr("docFechaIng")), Nothing, dr("docFechaIng"))
                loDocumentoSTD.OPersonaInteresada = New EEPersona
                loDocumentoSTD.OPersonaInteresada.PerId = dr("perId").ToString()
                loDocumentoSTD.OPersonaInteresada.PerNombreCompleto = dr("perIntNombres").ToString()
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal = New EECargoPersonal
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal.Institucion = dr("perIntTgInstitucion").ToString()
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal.Area = dr("perIntTgArea").ToString()
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function

    Public Shared Function MostrarDetalleExpedienteXNroReg(ByVal NroReg As String, Optional ByVal docAño As String = Nothing) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_DetDocumentoSTD_X_NReg_pa")
            db.AddInParameter(cmd, "docNReg", DbType.String, NroReg)
            db.AddInParameter(cmd, "docAño", DbType.String, docAño)


            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("docId").ToString()
                loDocumentoSTD.DocNReg = dr("docNReg").ToString()
                loDocumentoSTD.DocAsunto = dr("docAsunto").ToString()
                loDocumentoSTD.DocNFolio = IIf(IsDBNull(dr("docNFolio")), 0, dr("docNFolio").ToString)
                loDocumentoSTD.DocFechaIng = IIf(IsDBNull(dr("docFechaIng")), Nothing, dr("docFechaIng"))
                loDocumentoSTD.OPersonaInteresada = New EEPersona
                loDocumentoSTD.OPersonaInteresada.PerId = dr("perId").ToString()
                loDocumentoSTD.OPersonaInteresada.PerNombreCompleto = dr("perIntNombres").ToString()
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal = New EECargoPersonal
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal.Institucion = dr("perIntTgInstitucion").ToString()
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal.Area = dr("perIntTgArea").ToString()
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function

    Public Shared Function MostrarDetalleExpedienteXPerIntId(ByVal PerIntId As String, Optional ByVal docAño As String = Nothing) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_DetDocumentoSTD_X_PerIntId_pa")
            db.AddInParameter(cmd, "perId", DbType.String, PerIntId)
            db.AddInParameter(cmd, "docAño", DbType.String, docAño)


            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("docId").ToString()
                loDocumentoSTD.DocNReg = dr("docNReg").ToString()
                loDocumentoSTD.DocAsunto = dr("docAsunto").ToString()
                loDocumentoSTD.DocNFolio = IIf(IsDBNull(dr("docNFolio")), 0, dr("docNFolio").ToString)
                loDocumentoSTD.DocFechaIng = IIf(IsDBNull(dr("docFechaIng")), Nothing, dr("docFechaIng"))
                loDocumentoSTD.OPersonaInteresada = New EEPersona
                loDocumentoSTD.OPersonaInteresada.PerId = dr("perId").ToString()
                loDocumentoSTD.OPersonaInteresada.PerNombreCompleto = dr("perIntNombres").ToString()
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal = New EECargoPersonal
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal.Institucion = dr("perIntTgInstitucion").ToString()
                loDocumentoSTD.OPersonaInteresada.OPerCargoPersonal.Area = dr("perIntTgArea").ToString()
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function

    'Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EEDocumentoSTD)
    '    Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
    '    Dim loDocumentoSTD As EEDocumentoSTD = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_DocumentoSTD_Criterio_pa")
    '        db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
    '        db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
    '        dr = db.ExecuteReader(cmd)
    '        While dr.Read()
    '            If ListaDocumentoSTD Is Nothing Then
    '                ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
    '            End If
    '            loDocumentoSTD = New EEDocumentoSTD()
    '            loDocumentoSTD.DocOrigen = dr("DocOrigen").ToString()
    '            loDocumentoSTD.DocTupac = Convert.ToBoolean(dr("DocTupac").ToString())
    '            loDocumentoSTD.TgTDocId = dr("TgTDocId").ToString()
    '            loDocumentoSTD.TgTDoc = dr("TgTDoc").ToString()
    '            loDocumentoSTD.DocNReg = dr("DocNReg").ToString()
    '            loDocumentoSTD.DocNRegT = dr("DocNRegT").ToString()
    '            loDocumentoSTD.DocVinNRegT = dr("DocVinNRegT").ToString()
    '            loDocumentoSTD.DocAño = dr("DocAño").ToString()
    '            loDocumentoSTD.DocSiglas = dr("DocSiglas").ToString()
    '            loDocumentoSTD.DocNFolio = Convert.ToInt32(IIf(IsDBNull(dr("DocNFolio")), 0, dr("DocNFolio")))
    '            loDocumentoSTD.DocFechaIng = IIf(IsDBNull(dr("DocFechaIng")), Nothing, dr("DocFechaIng"))
    '            loDocumentoSTD.ProcId = dr("ProcId").ToString()
    '            loDocumentoSTD.procNombre = dr("ProcNombre").ToString()
    '            loDocumentoSTD.DocAsunto = dr("DocAsunto").ToString()
    '            'loDocumentoSTD.TgPrioridadId = dr("TgPrioridadId").ToString()
    '            'loDocumentoSTD.TgPrioridad = dr("TgPrioridad").ToString()
    '            'loDocumentoSTD.DocNParte = Convert.ToInt32(dr("DocNParte").ToString())
    '            loDocumentoSTD.DocId = dr("DocId").ToString()
    '            'loDocumentoSTD.DocVinId = dr("DocVinId").ToString()
    '            loDocumentoSTD.DocConfReq = Convert.ToBoolean(dr("DocConfReq").ToString())
    '            loDocumentoSTD.PerId = dr("PerId").ToString()
    '            loDocumentoSTD.perNombreOrigen = dr("PerNombres").ToString()
    '            loDocumentoSTD.perDireccion = dr("PerDireccion").ToString()
    '            ' loDocumentoSTD.DocSumilla = dr("DocSumilla").ToString()
    '            loDocumentoSTD.DocComentario = dr("DocComentario").ToString()
    '            loDocumentoSTD.TgMovTramiteId = dr("TgMovTramiteId").ToString()
    '            loDocumentoSTD.TgMovTramite = dr("TgMovTramite").ToString()
    '            loDocumentoSTD.TgInstitucionId = IIf(dr("TgInstitucionId") Is Nothing, "", dr("TgInstitucionId").ToString())
    '            loDocumentoSTD.TgInstitucion = dr("TgInstitucion").ToString()
    '            loDocumentoSTD.TgInstitucionInt = dr("TgInstitucionInt").ToString()
    '            loDocumentoSTD.TgInstitucionIntId = dr("TgInstitucionIntId").ToString()
    '            loDocumentoSTD.TgArea = dr("TgArea").ToString()
    '            loDocumentoSTD.TgAreaId = dr("TgAreaId").ToString()
    '            loDocumentoSTD.TgAreaIntId = dr("TgAreaIntId").ToString()
    '            loDocumentoSTD.TgAreaInt = dr("TgAreaInt").ToString()
    '            loDocumentoSTD.TgCargoIntId = dr("TgCargoIntId").ToString()
    '            loDocumentoSTD.TgCargoInt = dr("TgCargoInt").ToString()
    '            loDocumentoSTD.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
    '            loDocumentoSTD.DocNRef = dr("DocNRef").ToString()
    '            loDocumentoSTD.DocCargoIdEdit = IIf(IsDBNull(dr("docCargoIdEdit")), Nothing, dr("docCargoIdEdit"))
    '            loDocumentoSTD.DocPerIdEdit = IIf(IsDBNull(dr("docPerIdEdit")), Nothing, dr("docPerIdEdit"))
    '            'loDocumentoSTD.DocExpMPT1 = dr("docExpMPT1").ToString()
    '            'loDocumentoSTD.DocExpMPT2 = dr("docExpMPT2").ToString()
    '            'loDocumentoSTD.DocExpMPT3 = dr("docExpMPT3").ToString()
    '            'loDocumentoSTD.DocExpMPTAño1 = dr("docExpMPTAño1")
    '            'loDocumentoSTD.DocExpMPTAño2 = dr("docExpMPTAño2")
    '            'loDocumentoSTD.DocExpMPTAño3 = dr("docExpMPTAño3")
    '            'loDocumentoSTD.DocExpFoliosMPT1 = dr("docNroFoliosMPT1")
    '            'loDocumentoSTD.DocExpFoliosMPT2 = dr("docNroFoliosMPT2")
    '            'loDocumentoSTD.DocExpFoliosMPT3 = dr("docNroFoliosMPT3")
    '            'loDocumentoSTD.DocExpMPTParte1 = dr("DocExpMPTParte1").ToString
    '            'loDocumentoSTD.DocExpMPTParte2 = dr("DocExpMPTParte2").ToString
    '            'loDocumentoSTD.DocExpMPTParte3 = dr("DocExpMPTParte3").ToString
    '            'loDocumentoSTD.DocExpSAIMT = dr("docExpSAIMT").ToString()
    '            loDocumentoSTD.DocAux = dr("docAux").ToString()
    '            loDocumentoSTD.DocEliminado = Convert.ToBoolean(dr("DocEliminado").ToString())
    '            ListaDocumentoSTD.Add(loDocumentoSTD)
    '        End While
    '        dr.Close()
    '    Catch ex As Exception
    '        Throw New Exception("Listar DocumentoSTD Criterio => " + ex.Message, ex)
    '    End Try
    '    Return ListaDocumentoSTD
    'End Function

    Public Shared Function listarDocNRegTCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], Optional ByVal asCriterio2 As [String] = Nothing, Optional ByVal anio As String = Nothing) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_DocumentoSTD_BCriterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "criterio2", DbType.String, asCriterio2)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            db.AddInParameter(cmd, "anio", DbType.String, anio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocNRegT = dr("DocNRegT").ToString()
                loDocumentoSTD.DocId = dr("DocId").ToString()
                loDocumentoSTD.DocAsunto = dr("DocAsunto").ToString()
                If Not IsDBNull(dr("DocFechaIng")) Then
                    loDocumentoSTD.DocFechaIng = Convert.ToDateTime(dr("DocFechaIng"))
                End If
                If Not IsDBNull(dr("DocFechaReg")) Then
                    loDocumentoSTD.DocFechaReg = Convert.ToDateTime(dr("DocFechaReg"))
                End If
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD DocNRegT Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function
#End Region

#Region "Listar Criterio Vincular"
    ''' <summary>
    ''' Listar Documentos en Vinculas
    ''' </summary>
    ''' <param name="aiTipoCriterio">1 Nro Registro, 2 Asunto, 3 Asunto TUPA, 4 Fec. Ingreso, 5 Siglas, 6 Prioridad</param>
    ''' <param name="asCriterio">Criterio</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function listarCriterioVincular(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim loDocumentoSTDVinculo As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Dim drVinculo As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_DocumentoSTD_Vincular_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If

                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("DocId").ToString()
                ' loDocumentoSTD.DocVinId = dr("DocVinId").ToString()
                loDocumentoSTD.DocAsunto = dr("DocAsunto").ToString()
                loDocumentoSTD.TgArea = dr("TgArea").ToString()
                loDocumentoSTD.DocNRegT = dr("DocNRegT").ToString()
                loDocumentoSTD.DocNro = dr("DocNro").ToString()
                loDocumentoSTD.DocAño = dr("DocAño").ToString()
                loDocumentoSTD.DocSiglas = dr("DocSiglas").ToString()
                loDocumentoSTD.TgInstitucionId = dr("TgInstitucionId").ToString()
                '  loDocumentoSTD.DocNParte = dr("DocNParte").ToString()

                cmd = db.GetStoredProcCommand("Listar_DocumentoSTD_Vincular_XDocId_pa")
                db.AddInParameter(cmd, "docid", DbType.String, loDocumentoSTD.DocId)
                drVinculo = db.ExecuteReader(cmd)
                While drVinculo.Read()
                    loDocumentoSTDVinculo = New EEDocumentoSTD()
                    loDocumentoSTDVinculo.DocId = drVinculo("DocId").ToString()
                    loDocumentoSTDVinculo.DocNRegT = drVinculo("DocNRegT").ToString()
                    'loDocumentoSTDVinculo.DocVinId = drVinculo("DocVinId").ToString()
                    ' loDocumentoSTDVinculo.DocNParte = drVinculo("DocNParte").ToString()
                    loDocumentoSTDVinculo.DocNro = drVinculo("DocNro").ToString()
                    loDocumentoSTDVinculo.DocAño = drVinculo("DocAño").ToString()
                    loDocumentoSTDVinculo.DocSiglas = drVinculo("DocSiglas").ToString()
                    loDocumentoSTDVinculo.TgInstitucionId = drVinculo("TgInstitucionId").ToString()
                    loDocumentoSTDVinculo.TgInstitucion = drVinculo("TgInstitucion").ToString()
                    loDocumentoSTDVinculo.TgArea = drVinculo("TgArea").ToString()
                    loDocumentoSTDVinculo.DocAsunto = drVinculo("DAsunto").ToString()
                    loDocumentoSTDVinculo.DocFechaReg = Convert.ToDateTime(drVinculo("DocFechaReg").ToString())
                    loDocumentoSTD.ListaDocumentosVinculados.Add(loDocumentoSTDVinculo)
                End While
                drVinculo.Close()

                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function

    Public Shared Function listarCriterioVincularxDocId(docID As [String]) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTDVinculo As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd = db.GetStoredProcCommand("Listar_DocumentoSTD_Vincular_XDocId_pa")
            db.AddInParameter(cmd, "docId", DbType.String, docID)
            dr = db.ExecuteReader(cmd)
            If ListaDocumentoSTD Is Nothing Then
                ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
            End If
            ' loDocumentoSTD = New EEDocumentoSTD()
            While dr.Read()
                loDocumentoSTDVinculo = New EEDocumentoSTD()
                loDocumentoSTDVinculo.DocId = dr("DocId").ToString()
                loDocumentoSTDVinculo.DocNRegT = dr("DocNRegT").ToString()
                ' loDocumentoSTDVinculo.DocVinId = dr("DocVinId").ToString()
                '  loDocumentoSTDVinculo.DocNParte = dr("DocNParte").ToString()
                loDocumentoSTDVinculo.DocNro = dr("DocNro").ToString()
                loDocumentoSTDVinculo.DocAño = dr("DocAño").ToString()
                loDocumentoSTDVinculo.DocSiglas = dr("DocSiglas").ToString()
                loDocumentoSTDVinculo.TgInstitucionId = dr("TgInstitucionId").ToString()
                loDocumentoSTDVinculo.TgInstitucion = dr("TgInstitucion").ToString()
                loDocumentoSTDVinculo.TgArea = dr("TgArea").ToString()
                loDocumentoSTDVinculo.DocAsunto = dr("DAsunto").ToString()
                loDocumentoSTDVinculo.DocFechaReg = Convert.ToDateTime(dr("DocFechaReg").ToString())
                'loDocumentoSTD.ListaDocumentosVinculados.Add(loDocumentoSTDVinculo)
                ListaDocumentoSTD.Add(loDocumentoSTDVinculo)
            End While
            dr.Close()

        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD x DocID => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function
#End Region

    Public Shared Function NewCodigo() As String
        Dim dr As IDataReader = Nothing
        Dim DocID As String = vbEmpty
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_DocumentoSTD")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                DocID = dr("docId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD NewCodigo => " + ex.Message, ex)
        End Try
        Return DocID
    End Function

    Public Shared Function NewCodigoInterno(ByVal tgCargoId As String, ByVal tgTipoDocId As String) As String
        Dim dr As IDataReader = Nothing
        Dim docNreg As String = vbEmpty
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_CodigoI_DocumentoSTD_X_carTipoDocId_TgTDocId")
            db.AddInParameter(cmd, "carTipoDocId", DbType.String, tgCargoId)
            db.AddInParameter(cmd, "tgTDocId", DbType.String, tgTipoDocId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                docNreg = dr("docNreg").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD NewCodigoInterno => " + ex.Message, ex)
        End Try
        Return docNreg
    End Function


    Public Shared Function NewCodigoExterno() As String
        Dim dr As IDataReader = Nothing
        Dim docNreg As String = vbEmpty
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_CodigoE_DocumentoSTD")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                docNreg = dr("docNreg").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD NewCodigoExterno => " + ex.Message, ex)
        End Try
        Return docNreg
    End Function

    Public Shared Function ListarXSql(ByVal Sqlwhere As [String]) As List(Of EEDocumentoSTD)
        Dim ListaDocumentoSTD As List(Of EEDocumentoSTD) = Nothing
        Dim loDocumentoSTD As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Dim sql As String = ""
        Dim sql1 As String = "SELECT" & _
"        d.docId " & _
",(SUBSTRING(docNReg,1,5)+'-'+SUBSTRING(docNReg,6,4)+'-'+ RTRIM(SUBSTRING(docNReg,10,9))+'/MP - '+ CONVERT(VARCHAR,d.docFechaReg,103)+' '+CONVERT(VARCHAR,d.docFechaReg,108)+' - '+ ISNULL(D.docAsunto, P.procNombre)) docNRegT " & _
",TD.tgNombre TgTDoc " & _
",O.tgNombre Origen " & _
",MT.tgNombre tgMovTramite " & _
",ISNULL(D.docAsunto,P.procNombre) docAsunto " & _
",d.docFechaIng " & _
",d.docFechaDoc " & _
",ISNULL(per.perRazonSocial, per.perApePaterno+' '+per.perApeMaterno+' '+ per.perNombres) as PerNombres " & _
",II.tgNombre tgInstitucionInt " & _
",AI.tgNombre tgAreaInt " & _
",CI.tgNombre  tgCargoInt " & _
",D.docNFolio " & _
",D.docAnexo tieneAnexo " & _
",(SELECT CASE WHEN COUNT(r.tgReqId)>0 THEN 1 ELSE 0 END  FROM ReqDocumentoSTD r where r.docId= D.docId) tieneRequisitos " & _
"FROM DocumentoSTD d " & _
"	LEFT OUTER JOIN ProcedimientoSTD p ON p.procId=d.procId " & _
"	INNER JOIN Persona per on Per.perId=d.perId " & _
"	LEFT JOIN Tablageneral MT ON MT.clsId='96' AND MT.tgCodigo= tgMovTramiteId " & _
"	INNER JOIN Tablageneral II ON II.clsId='82' AND II.tgCodigo= LEFT(docInt,4) " & _
"	INNER JOIN Tablageneral AI ON AI.clsId='83' AND AI.tgCodigo= right(LEFT(docInt,7),3) and AI.tgExtra=LEFT(docInt,4) " & _
"	INNER JOIN Tablageneral CI ON CI.clsId='84' AND CI.tgCodigo= right(docInt,2) and CI.tgExtra=RIGHT(LEFT(docInt,7),3)+ LEFT(docInt,4) " & _
"	INNER JOIN Tablageneral TD ON TD.clsId='86' AND TD.tgCodigo= tgTDocId " & _
"	INNER JOIN TablaGeneral O ON O.clsId='85' AND O.tgCodigo=d.docOrigen "
        If Sqlwhere <> "" Then
            Dim sql2 As Char() = RTrim(Sqlwhere.ToCharArray())
            If sql2(sql2.Length - 1) = Char.Parse("R") Then
                Sqlwhere = Sqlwhere.Substring(0, Sqlwhere.Length - 3)
            ElseIf sql2(sql2.Length - 1) = Char.Parse("D") Then
                Sqlwhere = Sqlwhere.Substring(0, Sqlwhere.Length - 4)
            End If
            sql = String.Format("{0} {1} {2}", sql1, " WHERE", Sqlwhere)
        Else
            sql = sql1
        End If
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetSqlStringCommand(sql)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoSTD Is Nothing Then
                    ListaDocumentoSTD = New List(Of EEDocumentoSTD)()
                End If
                loDocumentoSTD = New EEDocumentoSTD()
                loDocumentoSTD.DocId = dr("DocId").ToString()
                loDocumentoSTD.DocNRegT = dr("DocNRegT").ToString()
                'loDocumentoSTD.TgTDocId = dr("TgTDocId").ToString()
                loDocumentoSTD.TgTDoc = dr("TgTDoc").ToString()
                'loDocumentoSTD.DocOrigen = dr("DocOrigen").ToString()
                loDocumentoSTD.Origen = dr("Origen").ToString()
                'loDocumentoSTD.TgMovTramiteId = dr("TgMovTramiteId").ToString()
                loDocumentoSTD.TgMovTramite = dr("TgMovTramite").ToString()
                loDocumentoSTD.DocAsunto = dr("DocAsunto").ToString()
                loDocumentoSTD.DocFechaIng = IIf(IsDBNull(dr("DocFechaIng")), Nothing, dr("DocFechaIng"))
                loDocumentoSTD.DocFechaDoc = IIf(IsDBNull(dr("docFechaDoc")), Nothing, dr("docFechaDoc"))
                loDocumentoSTD.perNombreOrigen = dr("PerNombres").ToString()
                ' loDocumentoSTD.TgInstitucionIntId = dr("TgInstitucionIntId").ToString()
                loDocumentoSTD.TgInstitucionInt = dr("TgInstitucionInt").ToString()
                'loDocumentoSTD.TgAreaIntId = dr("TgAreaIntId").ToString()
                loDocumentoSTD.TgAreaInt = dr("TgAreaInt").ToString()
                'loDocumentoSTD.TgCargoIntId = dr("TgCargoIntId").ToString()
                loDocumentoSTD.TgCargoInt = dr("TgCargoInt").ToString()
                loDocumentoSTD.DocNFolio = Convert.ToInt32(dr("DocNFolio").ToString())
                loDocumentoSTD.tieneAnexo = IIf(IsDBNull(dr("tieneAnexo")), 0, dr("tieneAnexo"))
                loDocumentoSTD.tieneRequisitos = dr("tieneRequisitos").ToString()
                'loDocumentoSTD.tieneVinculos = dr("tieneVinculos")
                'loDocumentoSTD.DocExpMPT1 = dr("docExpMPT1").ToString()
                'loDocumentoSTD.DocExpMPT2 = dr("docExpMPT2").ToString()
                'loDocumentoSTD.DocExpMPT3 = dr("docExpMPT3").ToString()
                'loDocumentoSTD.DocExpMPTAño1 = dr("docExpMPTAño1").ToString()
                'loDocumentoSTD.DocExpMPTAño2 = dr("docExpMPTAño2").ToString()
                'loDocumentoSTD.DocExpMPTAño3 = dr("docExpMPTAño3").ToString()
                'loDocumentoSTD.DocExpFoliosMPT1 = dr("docNroFoliosMPT1").ToString()
                'loDocumentoSTD.DocExpFoliosMPT2 = dr("docNroFoliosMPT2").ToString()
                'loDocumentoSTD.DocExpFoliosMPT3 = dr("docNroFoliosMPT3").ToString()
                'loDocumentoSTD.DocExpMPTParte1 = dr("DocExpMPTParte1").ToString
                'loDocumentoSTD.DocExpMPTParte2 = dr("DocExpMPTParte2").ToString
                'loDocumentoSTD.DocExpMPTParte3 = dr("DocExpMPTParte3").ToString
                '  loDocumentoSTD.DocAux = dr("docAux").ToString()
                ListaDocumentoSTD.Add(loDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD x SQL Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocumentoSTD
    End Function
End Class