﻿Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class MovimientoSTDDAS
    Public Shared Function PivotearMovimientosSTD(criterio As String, tipocriterio As Short, anio As Short) As List(Of EEMovimientoSTD)
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim loJerarquia As EEJerarquiaSTD = Nothing
        Dim loDocumento As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Pivotear_DocumentosSTD_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)
            db.AddInParameter(cmd, "tipocriterio", DbType.Int16, tipocriterio)
            db.AddInParameter(cmd, "anio", DbType.Int16, anio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimientoSTD Is Nothing Then
                    ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
                End If
                loMovimientoSTD = New EEMovimientoSTD()
                loJerarquia = New EEJerarquiaSTD
                loDocumento = New EEDocumentoSTD
                loMovimientoSTD.movDiasTenencia = Math.Abs(IIf(IsDBNull(dr("DiasTenencia")), 0, dr("DiasTenencia")))
                loMovimientoSTD.MovFechaRec = IIf(IsDBNull(dr("MovFechaRec")), Nothing, dr("MovFechaRec"))
                loMovimientoSTD.TgEstadoMov = dr("TgEstadoMov").ToString()
                loMovimientoSTD.Mes = dr("Mes").ToString()
                loMovimientoSTD.MovPara = dr("MovPara").ToString()
                loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("MovFechaEnv")), Nothing, dr("MovFechaEnv"))
                loMovimientoSTD.DiasProcedimiento = Math.Abs(IIf(IsDBNull(dr("DiasProcedimiento")), 0, dr("DiasProcedimiento")))
                loMovimientoSTD.MovComentario = dr("MovComentario").ToString()
                loMovimientoSTD.tgTDestinoExtra = dr("tgTDestinoExtra").ToString()
                loDocumento.DocId = dr("docId").ToString()
                loDocumento.DocNReg = dr("DocNReg").ToString()
                loDocumento.perNombreOrigen = dr("Interesado").ToString()
                loJerarquia.CargoOrigen = dr("nombreCargoOrigen").ToString()
                loJerarquia.CargoDestino = dr("nombreCargoDestino").ToString()
                loMovimientoSTD.OJerarquia = loJerarquia
                loMovimientoSTD.ODocumento = loDocumento
                ListaMovimientoSTD.Add(loMovimientoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaMovimientoSTD
    End Function


    'Public Shared Function MovimientosSTDXDocId(ByVal DocId As String) As List(Of EEMovimientoSTD)
    '    Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
    '    Dim loMovimientoSTD As EEMovimientoSTD = Nothing
    '    Dim loJerarquia As EEJerarquiaSTD = Nothing
    '    Dim loDocumento As EEDocumentoSTD = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_MovimientoSTD_XdocId_pa")
    '        db.AddInParameter(cmd, "docId", DbType.String, DocId)
    '        dr = db.ExecuteReader(cmd)
    '        While dr.Read()
    '            If ListaMovimientoSTD Is Nothing Then
    '                ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
    '            End If
    '            loMovimientoSTD = New EEMovimientoSTD()
    '            loMovimientoSTD.MovFechaRec = IIf(IsDBNull(dr("MovFechaRec")), Nothing, dr("MovFechaRec"))
    '            loMovimientoSTD.MovPerDe = dr("Persona").ToString()
    '            loMovimientoSTD.MovPerPara = dr("PersonaPara").ToString()
    '            loMovimientoSTD.MovPara = dr("DependenciaPara").ToString()
    '            loMovimientoSTD.MovDe = dr("Dependencia").ToString()
    '            loMovimientoSTD.TgEstadoMov = dr("resultado").ToString()
    '            loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("MovFechaEnv")), Nothing, dr("MovFechaEnv"))
    '            loMovimientoSTD.MovId = dr("MovId").ToString()
    '            loMovimientoSTD.MovComentario = dr("MovComentario").ToString()
    '            ListaMovimientoSTD.Add(loMovimientoSTD)
    '        End While
    '        dr.Close()
    '    Catch ex As Exception
    '        Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
    '    End Try
    '    Return ListaMovimientoSTD
    'End Function

    Public Shared Function listarxDocId(docId As String) As List(Of EEMovimientoSTD)
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim loJerarquia As EEJerarquiaSTD = Nothing
        Dim loDocumento As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_MovimientoSTD_XDocId_pa")
            db.AddInParameter(cmd, "docId", DbType.String, docId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimientoSTD Is Nothing Then
                    ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
                End If
                loMovimientoSTD = New EEMovimientoSTD()
                ' loJerarquia = New EEJerarquiaSTD
                '   loDocumento = New EEDocumentoSTD

                loMovimientoSTD.MovId = dr("MovId").ToString()
                loMovimientoSTD.OPersonaDestino = New EEPersona
                loMovimientoSTD.OPersonaDestino.PerNombreCompleto = dr("perNombresDestino").ToString()
                loMovimientoSTD.OPersonaOrigen = New EEPersona
                loMovimientoSTD.OPersonaOrigen.OPerCargoPersonal = New EECargoPersonal
                loMovimientoSTD.OPersonaOrigen.PerNombreCompleto = dr("perNombresOrigen").ToString()
                loMovimientoSTD.OPersonaOrigen.OPerCargoPersonal.Cargo = dr("nombreCargoOrigen").ToString()
                loMovimientoSTD.OPersonaDestino.OPerCargoPersonal = New EECargoPersonal
                loMovimientoSTD.OPersonaDestino.OPerCargoPersonal.Cargo = dr("nombreCargoDestino").ToString()
                loMovimientoSTD.MovDiasTenencia = Math.Abs(IIf(IsDBNull(dr("movDiasTenencia")), 0, dr("movDiasTenencia")))
                loMovimientoSTD.MovFechaRec = IIf(IsDBNull(dr("movFechaRec")), Nothing, dr("movFechaRec"))
                loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("movFechaEnv")), Nothing, dr("movFechaEnv"))
                loMovimientoSTD.TgEstadoMov = dr("TgEstadoMov").ToString()
                loMovimientoSTD.MovComentario = dr("movComentario").ToString()
                loMovimientoSTD.MovNroDocInt = dr("movNroDocInt").ToString()
                loMovimientoSTD.MovTieneArch = IIf(IsDBNull(dr("movTieneArch")), Nothing, dr("movTieneArch"))   'dr("movTieneArch").ToString()
                ListaMovimientoSTD.Add(loMovimientoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaMovimientoSTD
    End Function


    Public Shared Function listarxTgDestino_MovDe(tgDestinoId As String, MovParaId As String, Optional fecha As Date = Nothing) As List(Of EEMovimientoSTD)
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim loJerarquia As EEJerarquiaSTD = Nothing
        Dim loDocumento As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_MovimientoSTD_XTgDestinoId_MovDeId_pa")
            db.AddInParameter(cmd, "tgTDestinoId", DbType.String, tgDestinoId)
            db.AddInParameter(cmd, "movDe", DbType.String, MovParaId)
            If fecha <> "#12:00:00 AM#" Then
                db.AddInParameter(cmd, "docFechaIng", DbType.DateTime, fecha)
            End If
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimientoSTD Is Nothing Then
                    ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
                End If
                loMovimientoSTD = New EEMovimientoSTD()
                loJerarquia = New EEJerarquiaSTD
                loDocumento = New EEDocumentoSTD
                loDocumento.DocNReg = dr("DocNReg").ToString()
                loDocumento.DocFechaIng = IIf(IsDBNull(dr("docFechaIng")), Nothing, dr("docFechaIng"))
                loDocumento.perNombreOrigen = dr("Interesado").ToString()
                loDocumento.TgCargoInt = dr("TgCargoInt").ToString()
                loDocumento.DocAsunto = dr("asunto").ToString()
                loDocumento.TgTDoc = dr("tgTipoDocumento").ToString()
                loDocumento.DocFechaDoc = IIf(IsDBNull(dr("docFechaDoc")), Nothing, dr("docFechaDoc"))
                loDocumento.DocAux = dr("docAux").ToString()
                loDocumento.DocNRef = dr("docNRef").ToString()
                loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("movFechaEnv")), Nothing, dr("movFechaEnv"))
                loJerarquia.InstitucionOrigen = dr("nombreInstitucionOrigen").ToString()
                loJerarquia.InstitucionDestino = dr("nombreInstitucionDestino").ToString()
                loMovimientoSTD.ODocumento = loDocumento
                loMovimientoSTD.OJerarquia = loJerarquia
                ListaMovimientoSTD.Add(loMovimientoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaMovimientoSTD
    End Function
    Public Shared Function MostrarXMovId(ByVal movId As Integer) As EEMovimientoSTD

        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
 
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_MovimientoSTD_XMovId_pa")
            db.AddInParameter(cmd, "movId", DbType.Int16, movId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
     
                loMovimientoSTD = New EEMovimientoSTD()
                loMovimientoSTD.MovId = dr("MovId").ToString()
                loMovimientoSTD.DocId = dr("docId").ToString()
                loMovimientoSTD.ODocumento = New EEDocumentoSTD
                loMovimientoSTD.ODocumento.TgTDoc = dr("tgTipoDoc").ToString()
                loMovimientoSTD.ODocumento.DocAsunto = dr("docAsunto").ToString()
                loMovimientoSTD.ODocumento.DocTupac = dr("docTupac").ToString()
                loMovimientoSTD.ODocumento.DocNFolio = dr("docNFolio").ToString()
                loMovimientoSTD.ODocumento.DocFechaIng = dr("docFechaIng").ToString()
                loMovimientoSTD.ODocumento.DocComentario = dr("docComentario").ToString()
                loMovimientoSTD.ODocumento.DocNRef = dr("docNRef").ToString()
                loMovimientoSTD.ODocumento.DocNReg = dr("docNReg").ToString()
                loMovimientoSTD.ODocumento.DocAux = dr("docAux").ToString()
                loMovimientoSTD.ODocumento.PerId = dr("perId").ToString()
                loMovimientoSTD.ODocumento.OPersonaInteresada = New EEPersona
                loMovimientoSTD.ODocumento.OPersonaInteresada.PerNombreCompleto = dr("PerNombresInteresado").ToString()
                loMovimientoSTD.ODocumento.OPersonaInteresada.PerId = dr("perId").ToString()
                loMovimientoSTD.ODocumento.OPersonaInteresada.PerDireccion = dr("PerDireccionInteresado").ToString()
                loMovimientoSTD.ODocumento.OPersonaInteresada.OPerCargoPersonal = New EECargoPersonal
                loMovimientoSTD.ODocumento.OPersonaInteresada.OPerCargoPersonal.Institucion = dr("TgInstInteresado").ToString()
                loMovimientoSTD.ODocumento.OPersonaInteresada.OPerCargoPersonal.CodInstitucion = dr("TgInstInteresadoId").ToString()
                loMovimientoSTD.ODocumento.OPersonaInteresada.OPerCargoPersonal.Area = dr("TgAreaInteresado").ToString()
                loMovimientoSTD.ODocumento.OPersonaInteresada.OPerCargoPersonal.CodArea = dr("TgAreaInteresadoId").ToString()
                loMovimientoSTD.ODocumento.OPersonaInteresada.OPerCargoPersonal.Cargo = dr("TgCargoInteresado").ToString()
                loMovimientoSTD.ODocumento.OPersonaInteresada.OPerCargoPersonal.CodCargo = dr("TgCargoInteresadoId").ToString()
                loMovimientoSTD.OPersonaOrigen = New EEPersona
                loMovimientoSTD.OPersonaOrigen.PerNombreCompleto = dr("PerNombresOrigen").ToString()
                loMovimientoSTD.OPersonaOrigen.OPerCargoPersonal = New EECargoPersonal
                loMovimientoSTD.OPersonaOrigen.OPerCargoPersonal.Cargo = dr("TgCargoOrigen").ToString()
                loMovimientoSTD.OPersonaDestino = New EEPersona
                loMovimientoSTD.OPersonaDestino.PerNombreCompleto = dr("PerNombresOrigen").ToString()
                loMovimientoSTD.OPersonaDestino.OPerCargoPersonal = New EECargoPersonal
                loMovimientoSTD.OPersonaDestino.OPerCargoPersonal.Cargo = dr("TgCargoOrigen").ToString()
                loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("MovFechaEnv")), Nothing, dr("MovFechaEnv"))
                loMovimientoSTD.MovFechaRec = IIf(IsDBNull(dr("MovFechaRec")), Nothing, dr("MovFechaRec"))
                loMovimientoSTD.MovComentario = dr("MovComentario").ToString()
                loMovimientoSTD.TgEstadoMovId = dr("TgEstadoMovId").ToString()
                loMovimientoSTD.TgTDestino = dr("TgTipoDestino").ToString()
                loMovimientoSTD.TgTDestinoId = dr("tgTDestinoId").ToString()

            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return loMovimientoSTD
    End Function
    Public Shared Function listarxCriterio(ByVal tcriterio As Integer, ByVal criterio As String) As List(Of EEMovimientoSTD)
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim loJerarquia As EEJerarquiaSTD = Nothing
        Dim loDocumento As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_MovimientoSTD_XCriterio_pa")
            db.AddInParameter(cmd, "tcriterio", DbType.Int16, tcriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimientoSTD Is Nothing Then
                    ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
                End If
                loMovimientoSTD = New EEMovimientoSTD()
                loJerarquia = New EEJerarquiaSTD
                loDocumento = New EEDocumentoSTD
                loMovimientoSTD.MovId = dr("MovId").ToString()
                loMovimientoSTD.MovDe = dr("MovDe").ToString()
                loMovimientoSTD.MovPara = dr("MovPara").ToString()
                loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("MovFechaEnv")), Nothing, dr("MovFechaEnv"))
                loMovimientoSTD.MovComentario = dr("MovComentario").ToString()
                loMovimientoSTD.DocId = dr("DocId").ToString()
                loMovimientoSTD.MovFechaRec = IIf(IsDBNull(dr("MovFechaRec")), Nothing, dr("MovFechaRec"))
                loMovimientoSTD.TgEstadoMovId = dr("TgEstadoMovId").ToString()
                loMovimientoSTD.TgEstadoMov = dr("TgEstadoMov").ToString()
                loMovimientoSTD.TgTDestinoId = dr("tgTDestinoId").ToString()
                loMovimientoSTD.TgTDestino = dr("tgTDestino").ToString()
                loMovimientoSTD.OJerarquia = loJerarquia
                loMovimientoSTD.MovDiasTenencia = IIf(IsDBNull(dr("DiasTenencia")), 0, dr("DiasTenencia"))
                loMovimientoSTD.DiasProcedimiento = IIf(IsDBNull(dr("DiasProcedimiento")), 0, dr("DiasProcedimiento"))
                loMovimientoSTD.MovRead = dr("MovRead").ToString
                loMovimientoSTD.MovNroTDestino = IIf(IsDBNull(dr("movNroTDestino")), 0, dr("movNroTDestino"))
                loJerarquia.CodInstitucionOrigen = dr("codigoInstitucionOrigen").ToString()
                loJerarquia.InstitucionOrigen = dr("nombreInstitucionOrigen").ToString()
                loJerarquia.CodInstitucionDestino = dr("codigoInstitucionDestino").ToString()
                loJerarquia.InstitucionDestino = dr("nombreInstitucionDestino").ToString()
                loJerarquia.CodAreaOrigen = dr("codigoAreaOrigen").ToString()
                loJerarquia.AreaOrigen = dr("nombreAreaOrigen").ToString()
                loJerarquia.CodAreaDestino = dr("codigoAreaDestino").ToString()
                loJerarquia.AreaDestino = dr("nombreAreaDestino").ToString()
                loJerarquia.CodCargoOrigen = dr("codigoCargoOrigen").ToString()
                loJerarquia.CargoOrigen = dr("nombreCargoOrigen").ToString()
                loJerarquia.CodCargoDestino = dr("codigoCargoDestino").ToString()
                loJerarquia.CargoDestino = dr("nombreCargoDestino").ToString()
                loDocumento.perNombreOrigen = dr("Interesado").ToString()
                loDocumento.perPara = dr("PerPara").ToString()
                loDocumento.DocNReg = dr("DocNReg").ToString()
                loDocumento.TgTDocId = dr("tgTDocId").ToString()
                loDocumento.TgTDoc = dr("tgTipoDocumento").ToString()
                loDocumento.DocAsunto = dr("asunto").ToString()
                loDocumento.tieneAnexo = dr("conAnexo").ToString()
                loDocumento.DocAux = dr("docAux").ToString()
                loDocumento.DocTupac = dr("docTupac").ToString()
                loDocumento.DocNFolio = dr("docNFolio").ToString()
                loDocumento.DocFechaIng = dr("docFechaIng").ToString()
                loDocumento.DocComentario = dr("docComentario").ToString()
                loDocumento.DocNRef = dr("docNRef").ToString()
                loDocumento.PerId = dr("perId").ToString()
                loDocumento.DocInt = dr("docInt").ToString()
                loMovimientoSTD.ODocumento = loDocumento
                ListaMovimientoSTD.Add(loMovimientoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaMovimientoSTD
    End Function

    Public Shared Function listarxCriterioTop(ByVal tcriterio As Integer, ByVal criterio As String, ByVal top As Integer, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As List(Of EEMovimientoSTD)
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim loJerarquia As EEJerarquiaSTD = Nothing
        Dim loDocumento As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_MovimientoSTD_XCriterio_top2_pa")
            db.AddInParameter(cmd, "tcriterio", DbType.Int16, tcriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)
            db.AddInParameter(cmd, "top", DbType.String, top)
            db.AddInParameter(cmd, "anio", DbType.String, anio)
            db.AddInParameter(cmd, "mes", DbType.String, mes)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimientoSTD Is Nothing Then
                    ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
                End If
                loMovimientoSTD = New EEMovimientoSTD()
                loJerarquia = New EEJerarquiaSTD
                loDocumento = New EEDocumentoSTD

                loMovimientoSTD.MovId = dr("MovId").ToString()
                loMovimientoSTD.MovPara = dr("MovPara").ToString()
                loMovimientoSTD.DocId = dr("DocId").ToString()
                loMovimientoSTD.MovRead = dr("MovRead").ToString
                loMovimientoSTD.MovComentario = dr("MovComentario").ToString()
                loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("MovFechaEnv")), Nothing, dr("MovFechaEnv"))
                loMovimientoSTD.TgEstadoMov = dr("TgEstadoMov").ToString()
                loMovimientoSTD.tgTDestino = dr("tgTDestino").ToString()
                loMovimientoSTD.MovNroTDestino = IIf(IsDBNull(dr("movNroTDestino")), 0, dr("movNroTDestino"))
                loMovimientoSTD.TgEstadoMovId = dr("TgEstadoMovId").ToString()
                loMovimientoSTD.movEnviado = IIf(IsDBNull(dr("movEnviado")), False, dr("movEnviado"))
                loMovimientoSTD.DiasPasados = IIf(IsDBNull(dr("DiasPasados")), 0, dr("DiasPasados"))
                loMovimientoSTD.movDiasTenencia = IIf(IsDBNull(dr("DiasTenencia")), 0, dr("DiasTenencia"))
                loDocumento.perNombreOrigen = dr("Interesado").ToString()
                loDocumento.perPara = dr("PerPara").ToString()
                loDocumento.DocNReg = dr("DocNReg").ToString()
                loDocumento.TgTDoc = dr("tgTipoDocumento").ToString()
                loDocumento.DocAux = dr("docAux").ToString()
                loDocumento.DocAsunto = dr("asunto").ToString()
                '  loDocumento.TgPrioridadId = dr("tgPrioridadId").ToString()
                loDocumento.tieneAnexo = dr("conAnexo").ToString()
                loJerarquia.CargoDestino = dr("nombreCargoDestino").ToString()
                loMovimientoSTD.OJerarquia = loJerarquia
                loMovimientoSTD.ODocumento = loDocumento
                ListaMovimientoSTD.Add(loMovimientoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaMovimientoSTD
    End Function

    Public Shared Function listarxCriterioPag(ByVal tcriterio As Integer, ByVal criterio As String, ByVal pagina As Integer, ByVal NReg As Integer, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As List(Of EEMovimientoSTD)
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim loJerarquia As EEJerarquiaSTD = Nothing
        Dim loDocumento As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_MovimientoSTD_XCriterio_paginacion_pa")
            db.AddInParameter(cmd, "tcriterio", DbType.Int16, tcriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)
            db.AddInParameter(cmd, "pagina", DbType.String, pagina)
            db.AddInParameter(cmd, "regxpag", DbType.String, NReg)
            db.AddInParameter(cmd, "anio", DbType.String, anio)
            db.AddInParameter(cmd, "mes", DbType.String, mes)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimientoSTD Is Nothing Then
                    ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
                End If
                loMovimientoSTD = New EEMovimientoSTD()
                loJerarquia = New EEJerarquiaSTD
                loDocumento = New EEDocumentoSTD

                loMovimientoSTD.MovId = dr("MovId").ToString()
                loMovimientoSTD.MovPara = dr("MovPara").ToString()
                loMovimientoSTD.DocId = dr("DocId").ToString()
                loMovimientoSTD.MovRead = dr("MovRead").ToString
                loMovimientoSTD.MovVinculado = dr("MovVinculado").ToString
                loMovimientoSTD.MovRecepcionado = IIf(IsDBNull(dr("MovRecepcionado")), False, dr("MovRecepcionado"))
                loMovimientoSTD.MovComentario = dr("MovComentario").ToString()
                loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("MovFechaEnv")), Nothing, dr("MovFechaEnv"))
                loMovimientoSTD.TgEstadoMov = dr("TgEstadoMov").ToString()
                loMovimientoSTD.tgTDestino = dr("tgTDestino").ToString()
                ' loMovimientoSTD.MovNroTDestino = IIf(IsDBNull(dr("movNroTDestino")), 0, dr("movNroTDestino"))
                loMovimientoSTD.TgEstadoMovId = dr("TgEstadoMovId").ToString()
                loMovimientoSTD.movEnviado = IIf(IsDBNull(dr("movEnviado")), False, dr("movEnviado"))
                loMovimientoSTD.DiasPasados = IIf(IsDBNull(dr("DiasPasados")), 0, dr("DiasPasados"))
                loMovimientoSTD.movDiasTenencia = IIf(IsDBNull(dr("DiasTenencia")), 0, dr("DiasTenencia"))
                loDocumento.perNombreOrigen = dr("Interesado").ToString()
                loDocumento.perPara = dr("PerPara").ToString()
                loDocumento.DocNReg = dr("DocNReg").ToString()
                loDocumento.TgTDoc = dr("tgTipoDocumento").ToString()
                loDocumento.DocAux = dr("docAux").ToString()
                loDocumento.DocAsunto = dr("asunto").ToString()
                'loDocumento.TgPrioridadId = dr("tgPrioridadId").ToString()
                loDocumento.tieneAnexo = IIf(IsDBNull(dr("conAnexo")), False, dr("conAnexo"))
                loJerarquia.CargoDestino = dr("nombreCargoDestino").ToString()
                loMovimientoSTD.OJerarquia = loJerarquia
                loMovimientoSTD.ODocumento = loDocumento
                ListaMovimientoSTD.Add(loMovimientoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaMovimientoSTD
    End Function


    Public Shared Function MostrarArchvxMovId(ByVal MovId As String) As EEMovimientoSTD

        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_MovimientoSTD_movArch_by_movId_pa")
            db.AddInParameter(cmd, "movId", DbType.String, MovId)
    
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loMovimientoSTD = New EEMovimientoSTD()
                loMovimientoSTD.MovArch = dr("MovArch")
                'loMovimientoSTD.MovArchName = dr("MovArchName").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return loMovimientoSTD
    End Function



    Public Shared Function listarResponderxCriterioPag(ByVal tcriterio As Integer, ByVal criterio As String, ByVal pagina As Integer, ByVal NReg As Integer, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As List(Of EEMovimientoSTD)
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim loJerarquia As EEJerarquiaSTD = Nothing
        Dim loDocumento As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_MovimientoResponderSTD_XCriterio_paginacion_pa")
            db.AddInParameter(cmd, "tcriterio", DbType.Int16, tcriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)
            db.AddInParameter(cmd, "pagina", DbType.String, pagina)
            db.AddInParameter(cmd, "regxpag", DbType.String, NReg)
            db.AddInParameter(cmd, "anio", DbType.String, anio)
            db.AddInParameter(cmd, "mes", DbType.String, mes)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimientoSTD Is Nothing Then
                    ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
                End If
                loMovimientoSTD = New EEMovimientoSTD()
                loJerarquia = New EEJerarquiaSTD
                loDocumento = New EEDocumentoSTD
                loMovimientoSTD.MovId = dr("MovId").ToString()
                loMovimientoSTD.MovPara = dr("MovPara").ToString()
                loMovimientoSTD.DocId = dr("DocId").ToString()
                loMovimientoSTD.MovRead = dr("MovRead").ToString
                loMovimientoSTD.MovComentario = dr("MovComentario").ToString()
                loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("MovFechaEnv")), Nothing, dr("MovFechaEnv"))
                loMovimientoSTD.TgEstadoMov = dr("TgEstadoMov").ToString()
                loMovimientoSTD.tgTDestino = dr("tgTDestino").ToString()
                loMovimientoSTD.MovNroTDestino = IIf(IsDBNull(dr("movNroTDestino")), 0, dr("movNroTDestino"))
                loMovimientoSTD.TgEstadoMovId = dr("TgEstadoMovId").ToString()
                loMovimientoSTD.movEnviado = IIf(IsDBNull(dr("movEnviado")), False, dr("movEnviado"))
                loMovimientoSTD.DiasPasados = IIf(IsDBNull(dr("DiasPasados")), 0, dr("DiasPasados"))
                loMovimientoSTD.movDiasTenencia = IIf(IsDBNull(dr("DiasTenencia")), 0, dr("DiasTenencia"))
                loDocumento.perNombreOrigen = dr("Interesado").ToString()
                loDocumento.perPara = dr("PerPara").ToString()
                loDocumento.DocNReg = dr("DocNReg").ToString()
                loDocumento.TgTDoc = dr("tgTipoDocumento").ToString()
                loDocumento.DocAux = dr("docAux").ToString()
                loDocumento.DocAsunto = dr("asunto").ToString()
                '   loDocumento.TgPrioridadId = dr("tgPrioridadId").ToString()
                loDocumento.tieneAnexo = dr("conAnexo").ToString()
                loJerarquia.CargoDestino = dr("nombreCargoDestino").ToString()
                loMovimientoSTD.OJerarquia = loJerarquia
                loMovimientoSTD.ODocumento = loDocumento
                ListaMovimientoSTD.Add(loMovimientoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaMovimientoSTD
    End Function

    Public Shared Function listarResponderxCriterioTop(ByVal tcriterio As Integer, ByVal criterio As String, ByVal top As Integer, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As List(Of EEMovimientoSTD)
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim loJerarquia As EEJerarquiaSTD = Nothing
        Dim loDocumento As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_MovimientoResponderSTD_XCriterio_TOP2_pa")
            db.AddInParameter(cmd, "tcriterio", DbType.Int16, tcriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)
            db.AddInParameter(cmd, "top", DbType.String, top)
            db.AddInParameter(cmd, "anio", DbType.String, anio)
            db.AddInParameter(cmd, "mes", DbType.String, mes)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimientoSTD Is Nothing Then
                    ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
                End If
                loMovimientoSTD = New EEMovimientoSTD()
                loJerarquia = New EEJerarquiaSTD
                loDocumento = New EEDocumentoSTD
                loMovimientoSTD.MovId = dr("MovId").ToString()
                loMovimientoSTD.MovPara = dr("MovPara").ToString()
                loMovimientoSTD.DocId = dr("DocId").ToString()
                loMovimientoSTD.MovRead = dr("MovRead").ToString
                loMovimientoSTD.MovComentario = dr("MovComentario").ToString()
                loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("MovFechaEnv")), Nothing, dr("MovFechaEnv"))
                loMovimientoSTD.TgEstadoMov = dr("TgEstadoMov").ToString()
                loMovimientoSTD.tgTDestino = dr("tgTDestino").ToString()
                loMovimientoSTD.MovNroTDestino = IIf(IsDBNull(dr("movNroTDestino")), 0, dr("movNroTDestino"))
                loMovimientoSTD.TgEstadoMovId = dr("TgEstadoMovId").ToString()
                loMovimientoSTD.movEnviado = IIf(IsDBNull(dr("movEnviado")), False, dr("movEnviado"))
                loMovimientoSTD.DiasPasados = IIf(IsDBNull(dr("DiasPasados")), 0, dr("DiasPasados"))
                loMovimientoSTD.movDiasTenencia = IIf(IsDBNull(dr("DiasTenencia")), 0, dr("DiasTenencia"))
                loDocumento.perNombreOrigen = dr("Interesado").ToString()
                loDocumento.perPara = dr("PerPara").ToString()
                loDocumento.DocNReg = dr("DocNReg").ToString()
                loDocumento.TgTDoc = dr("tgTipoDocumento").ToString()
                loDocumento.DocAux = dr("docAux").ToString()
                loDocumento.DocAsunto = dr("asunto").ToString()
                'loDocumento.TgPrioridadId = dr("tgPrioridadId").ToString()
                loDocumento.tieneAnexo = dr("conAnexo").ToString()
                loJerarquia.CargoDestino = dr("nombreCargoDestino").ToString()
                loMovimientoSTD.OJerarquia = loJerarquia
                loMovimientoSTD.ODocumento = loDocumento
                ListaMovimientoSTD.Add(loMovimientoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaMovimientoSTD
    End Function

    Public Shared Function listarResponderxCriterioCount(ByVal tcriterio As Integer, ByVal criterio As String, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As Integer
        Dim dr As IDataReader = Nothing
        Dim count = New Integer
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_MovimientoResponderSTD_XCriterio_Count_pa")
            db.AddInParameter(cmd, "tcriterio", DbType.Int16, tcriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)
            db.AddInParameter(cmd, "anio", DbType.String, anio)
            db.AddInParameter(cmd, "mes", DbType.String, mes)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                count = dr("nro").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Count Criterio => " + ex.Message, ex)
        End Try
        Return count
    End Function
    Public Shared Function listarxCriterioCount(ByVal tcriterio As Integer, ByVal criterio As String, Optional ByVal anio As String = Nothing, Optional ByVal mes As String = Nothing) As Integer

        Dim dr As IDataReader = Nothing
        Dim count = New Integer
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_MovimientoSTD_XCriterio_Count_pa")
            db.AddInParameter(cmd, "tcriterio", DbType.Int16, tcriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)
            db.AddInParameter(cmd, "anio", DbType.String, anio)
            db.AddInParameter(cmd, "mes", DbType.String, mes)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                count = dr("nro").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar MovimientoSTD Count Criterio => " + ex.Message, ex)
        End Try
        Return count
    End Function
    Public Shared Function ListarXSql(ByVal Sqlwhere As [String]) As List(Of EEMovimientoSTD)
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim loJerarquia As EEJerarquiaSTD = Nothing
        Dim dr As IDataReader = Nothing
        Dim sql As String = ""
        Dim sql1 As String = "SELECT [movId]," & _
       " [movDe]," & _
       " [movPara] " & _
       ",LEFT(MSTD.movDe,4) codigoInstitucionOrigen " & _
       ",IO.tgNombre nombreInstitucionOrigen  " & _
       ",LEFT(MSTD.movPara,4) codigoInstitucionDestino " & _
       ",ID.tgNombre  nombreInstitucionDestino " & _
      ",SUBSTRING(MSTD.movDe,5,3) codigoAreaOrigen " & _
      ",AO.tgNombre as nombreAreaOrigen " & _
      ",SUBSTRING(MSTD.movPara,5,3) codigoAreaDestino " & _
      ",AD.tgNombre nombreAreaDestino " & _
      ",RIGHT(MSTD.movDe,2) codigoCargoOrigen  " & _
      ",CO.tgNombre nombreCargoOrigen  " & _
      ",RIGHT(MSTD.movPara,2) codigoCargoDestino " & _
      ",CD.tgNombre  nombreCargoDestino " & _
      ",convert(char(10),[movFechaEnv],103) movFechaEnv,[movComentario] " & _
      ",MSTD.[docId]  " & _
      ",convert(char(10),[movFechaRec],103) movFechaRec" & _
      ",tgEstadoMovId  " & _
      ",EM.tgNombre tgEstadoMov  " & _
      ",ISNULL([movRead],0) movRead  " & _
      ",tgTDestinoId " & _
      ",TD.tgNombre tgTDestino " & _
      ",MSTD.movNroTDestino " & _
"FROM [DB_SAIMT_GENERAL].[dbo].[MovimientoSTD] MSTD " & _
"INNER JOIN TablaGeneral IO ON IO.clsId=82 AND  LEFT(MSTD.movDe,4)=IO.tgCodigo  " & _
"INNER JOIN TablaGeneral ID ON ID.clsId=82 AND  LEFT(MSTD.movPara,4)=ID.tgCodigo  " & _
"INNER JOIN TablaGeneral AO ON AO.clsId=83 AND  SUBSTRING(MSTD.movDe,5,3)=AO.tgCodigo AND LEFT(MSTD.movDe,4)=AO.tgExtra " & _
"INNER JOIN TablaGeneral AD ON AD.clsId=83 AND  SUBSTRING(MSTD.movPara,5,3)=AD.tgCodigo AND LEFT(MSTD.movPara,4)=AD.tgExtra  " & _
"INNER JOIN TablaGeneral CO ON CO.clsId=84 AND  RIGHT(MSTD.movDe,2)=CO.tgCodigo AND  SUBSTRING(MSTD.movDe,5,3)=LEFT(CO.tgExtra,3) AND LEFT(MSTD.movDe,4)=RIGHT(CO.tgExtra,4) " & _
"INNER JOIN TablaGeneral CD ON CD.clsId=84 AND  RIGHT(MSTD.movPara,2)=CD.tgCodigo AND  SUBSTRING(MSTD.movPara,5,3)=LEFT(CD.tgExtra,3) AND LEFT(MSTD.movPara,4)=RIGHT(CD.tgExtra,4)" & _
"INNER JOIN TablaGeneral EM ON EM.clsId=89 AND EM.tgCodigo=tgEstadoMovId  " & _
"INNER JOIN TablaGeneral TD ON TD.clsId=96 AND TD.tgCodigo=tgTDestinoId "
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
                If ListaMovimientoSTD Is Nothing Then
                    ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
                End If
                loMovimientoSTD = New EEMovimientoSTD()
                loJerarquia = New EEJerarquiaSTD
                loMovimientoSTD.MovId = dr("MovId").ToString()
                loMovimientoSTD.MovDe = dr("MovDe").ToString()
                loMovimientoSTD.MovPara = dr("MovPara").ToString()
                loMovimientoSTD.MovFechaEnv = IIf(IsDBNull(dr("MovFechaEnv")), Nothing, dr("MovFechaEnv"))
                loMovimientoSTD.MovComentario = dr("MovComentario").ToString()
                loMovimientoSTD.DocId = dr("DocId").ToString()
                loMovimientoSTD.MovFechaRec = IIf(IsDBNull(dr("MovFechaRec")), Nothing, dr("MovFechaRec"))
                loMovimientoSTD.TgEstadoMovId = dr("TgEstadoMovId").ToString()
                loMovimientoSTD.TgEstadoMov = dr("TgEstadoMov").ToString()
                loMovimientoSTD.tgTDestinoId = dr("tgTDestinoId").ToString()
                loMovimientoSTD.tgTDestino = dr("tgTDestino").ToString()
                loMovimientoSTD.OJerarquia = loJerarquia
                loMovimientoSTD.MovRead = Convert.ToBoolean(dr("MovRead").ToString())
                loMovimientoSTD.MovNroTDestino = IIf(IsDBNull(dr("movNroTDestino")), 0, dr("movNroTDestino"))
                loJerarquia.CodInstitucionOrigen = dr("codigoInstitucionOrigen").ToString()
                loJerarquia.InstitucionOrigen = dr("nombreInstitucionOrigen").ToString()
                loJerarquia.CodInstitucionDestino = dr("codigoInstitucionDestino").ToString()
                loJerarquia.InstitucionDestino = dr("nombreInstitucionDestino").ToString()
                loJerarquia.CodAreaOrigen = dr("codigoAreaOrigen").ToString()
                loJerarquia.AreaOrigen = dr("nombreAreaOrigen").ToString()
                loJerarquia.CodAreaDestino = dr("codigoAreaDestino").ToString()
                loJerarquia.AreaDestino = dr("nombreAreaDestino").ToString()
                loJerarquia.CodCargoOrigen = dr("codigoCargoOrigen").ToString()
                loJerarquia.CargoOrigen = dr("nombreCargoOrigen").ToString()
                loJerarquia.CodCargoDestino = dr("codigoCargoDestino").ToString()
                loJerarquia.CargoDestino = dr("nombreCargoDestino").ToString()
                ListaMovimientoSTD.Add(loMovimientoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoSTD x SQL Criterio => " + ex.Message, ex)
        End Try
        Return ListaMovimientoSTD
    End Function

    Public Shared Function MostrarEstadoMovId_UltimoXdocId(ByVal docId As String) As EEMovimientoSTD
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_Movimiento_tgEstadoMovId_X_docId_pa")
            db.AddInParameter(cmd, "docId", DbType.String, docId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                loMovimientoSTD = New EEMovimientoSTD()
                loMovimientoSTD.TgEstadoMovId = dr("TgEstadoMovId").ToString()
                loMovimientoSTD.TgEstadoMov = dr("TgEstadoMov").ToString()
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Ultimo EstadoMovId X docId Criterio => " + ex.Message, ex)
        End Try
        Return loMovimientoSTD
    End Function

    Public Shared Function consultar_noleidos_XPerId(ByVal asPerId As String) As List(Of EEMovimientoSTD)
        Dim ListaMovimientoSTD As List(Of EEMovimientoSTD) = Nothing
        Dim loMovimientoSTD As EEMovimientoSTD = Nothing
        Dim loJerarquia As EEJerarquiaSTD = Nothing
        Dim loDocumento As EEDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Consultar_MovimientoSTD_NoLeidos_XPerId_pa")
            db.AddInParameter(cmd, "perId", DbType.String, asPerId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMovimientoSTD Is Nothing Then
                    ListaMovimientoSTD = New List(Of EEMovimientoSTD)()
                End If
                loMovimientoSTD = New EEMovimientoSTD()
                loMovimientoSTD.MovId = dr("MovId").ToString()
                loMovimientoSTD.MovDe = dr("MovDe").ToString()
                loMovimientoSTD.MovPara = dr("MovPara").ToString()
                If Not IsDBNull(dr("MovFechaEnv")) Then
                    loMovimientoSTD.MovFechaEnv = Convert.ToDateTime(dr("MovFechaEnv").ToString())
                End If
                loMovimientoSTD.MovComentario = dr("MovComentario").ToString()
                loJerarquia = New EEJerarquiaSTD()
                loJerarquia.CargoOrigen = dr("nombreCargoDe").ToString()
                loJerarquia.CargoDestino = dr("nombreCargoPara").ToString()
                loMovimientoSTD.OJerarquia = loJerarquia
                loDocumento = New EEDocumentoSTD()
                loDocumento.DocAsunto = dr("Asunto").ToString()
                loMovimientoSTD.ODocumento = loDocumento
                ListaMovimientoSTD.Add(loMovimientoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar MovimientoSTD No Leidos XPerId => " + ex.Message, ex)
        End Try
        Return ListaMovimientoSTD
    End Function




End Class