Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class CertificacionDAS

    Public Shared Function MostrarXCerId(ByVal cerId As [String]) As EECertificacion
        Dim loCertificacion As EECertificacion = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_certificacion_XcerId_pa")
            db.AddInParameter(cmd, "cerId", DbType.String, cerId)


            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loCertificacion = New EECertificacion()
                loCertificacion.CerId = dr("cerId").ToString()
                loCertificacion.CerNro = dr("cerNro").ToString()
                loCertificacion.CerFecha = IIf(IsDBNull(dr("cerFecha")), Nothing, dr("cerFecha"))
                loCertificacion.CerSolicitadoCon = dr("cerSolicitadoCon").ToString()
                loCertificacion.TgAreaSolicitanteId = dr("tgAreaSolicitanteId").ToString()
                loCertificacion.CerContExpediente = dr("cerContExpediente").ToString()
                loCertificacion.CerJustificacion = dr("cerJustificacion").ToString()
                loCertificacion.TgActProyId = dr("tgActProyId").ToString()
                loCertificacion.TgMetaId = dr("tgMetaId").ToString()
                loCertificacion.TgFFinancieraId = dr("tgFFinancieraId").ToString()
                loCertificacion.CerValTotal = Convert.ToDecimal(dr("cerValTotal").ToString())
                loCertificacion.CerValQuedan = Convert.ToDecimal(dr("CerValQuedan").ToString())
                loCertificacion.CerObservacion = dr("cerObservacion").ToString()
            End If
        Catch ex As Exception
            Throw New Exception("Mostrar Certificacion x CerId => " & ex.Message, ex)
        End Try
        Return loCertificacion
    End Function

    Public Shared Function ListaCertGrupoPartidaXCerId(ByVal asOrdId As [String]) As List(Of EECertificacion.EECertificacionGrupoPartida)
        Dim ListaCertGrupoPartida As List(Of EECertificacion.EECertificacionGrupoPartida) = Nothing
        Dim loCertGrupoPartida As EECertificacion.EECertificacionGrupoPartida = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CertGrupoPartida_XcerId_pa")
            db.AddInParameter(cmd, "cerId", DbType.String, asOrdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCertGrupoPartida Is Nothing Then
                    ListaCertGrupoPartida = New List(Of EECertificacion.EECertificacionGrupoPartida)()
                End If

                loCertGrupoPartida = New EECertificacion.EECertificacionGrupoPartida()

                loCertGrupoPartida.cerGrupoParId = dr("cerGrupoParId").ToString()
                loCertGrupoPartida.partId = dr("partId").ToString()
                loCertGrupoPartida.PartNombre = dr("PartNombre").ToString()
                loCertGrupoPartida.PartDato = dr("partId").ToString() & "-" & dr("PartNombre").ToString()
                loCertGrupoPartida.partAnio = dr("partAnio").ToString()
                loCertGrupoPartida.cerGrupoParValImporte = CDbl(dr("cerGrupoParValImporte"))
                loCertGrupoPartida.cerGrupoParValQuedan = CDbl(dr("cerGrupoParValQuedan"))
                ListaCertGrupoPartida.Add(loCertGrupoPartida)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenServicioDet XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaCertGrupoPartida
    End Function

    Public Shared Function listarBCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal asAnio As Int16) As List(Of EECertificacion)
        Dim ListaCertificacion As List(Of EECertificacion) = Nothing
        Dim loCertificacion As EECertificacion = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Certificacion_BCriterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            db.AddInParameter(cmd, "anio", DbType.Int32, asAnio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCertificacion Is Nothing Then
                    ListaCertificacion = New List(Of EECertificacion)()
                End If

                loCertificacion = New EECertificacion()

                loCertificacion.CerId = dr("cerId").ToString()
                loCertificacion.CerNro = dr("cerNro").ToString()
                loCertificacion.CerJustificacion = dr("CerJustificacion").ToString()
                loCertificacion.TgActProyId = dr("tgActProyId").ToString()
                loCertificacion.TgMetaId = dr("tgMetaId").ToString()
                loCertificacion.TgFFinancieraId = dr("tgFFinancieraId").ToString()
                loCertificacion.CerFecha = dr("cerFecha").ToString()
                loCertificacion.CerValTotal = CDbl(dr("cerValTotal"))
                loCertificacion.CerValQuedan = CDbl(dr("cerValQuedan"))
                ListaCertificacion.Add(loCertificacion)
            End While
        Catch ex As Exception
            Throw New Exception("Busqueda rapida por Criterio => " & ex.Message, ex)
        End Try
        Return ListaCertificacion
    End Function

    'Public Shared Function listarConsultaCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal anio As Integer) As List(Of EECertificacion)
    '    Dim ListaCertificacion As List(Of EECertificacion) = Nothing
    '    Dim loCertificacion As EECertificacion = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Certificacion_Consulta_Criterio_pa")
    '        db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
    '        db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
    '        db.AddInParameter(cmd, "anio", DbType.Int32, anio)

    '        dr = db.ExecuteReader(cmd)
    '        While dr.Read()
    '            If ListaCertificacion Is Nothing Then
    '                ListaCertificacion = New List(Of EECertificacion)()
    '            End If
    '            loCertificacion = New EECertificacion()
    '            loCertificacion.CerId = dr("cerId").ToString()
    '            loCertificacion.CerNro = dr("cerNro").ToString()
    '            ' loCertificacion.PartId = dr("partId").ToString()
    '            'loCertificacion.CerAnio = dr("partAnio").ToString()
    '            ' loCertificacion.PartNombre = dr("partNombre").ToString()
    '            ' loCertificacion.TgActProyId = dr("tgActProyId").ToString()
    '            'loCertificacion.TgMetaId = dr("tgMetaId").ToString()
    '            'loCertificacion.TgFFinancieraId = dr("tgFFinancieraId").ToString()
    '            loCertificacion.CerFecha = dr("cerFecha").ToString()
    '            'loCertificacion.cerGrupoParValImporte = CDbl(dr("cerGrupoParValImporte"))
    '            'oCertificacion.cerGrupoParValQuedan = CDbl(dr("cerGrupoParValQuedan"))
    '            loCertificacion.CerValQuedan = CDbl(dr("cerValQuedan"))
    '            loCertificacion.CerValTotal = CDbl(dr("cerValTotal"))
    '            'loCertificacion.CerDato = dr("cerId").ToString() & " - " & dr("cerNro").ToString() & " : " & CDbl(dr("cerValQuedan")) & " de " & CDbl(dr("cerValTotal"))
    '            ListaCertificacion.Add(loCertificacion)
    '        End While
    '    Catch ex As Exception
    '        Throw New Exception("Listar Salida Articulo Almacen Criterio => " & ex.Message, ex)
    '    End Try
    '    Return ListaCertificacion
    'End Function

    'Public Shared Function listarDetPartidasXCerId(ByVal cerId As [String]) As List(Of EECertificacion)
    '    Dim ListaCertificacion As List(Of EECertificacion) = Nothing
    '    Dim loCertificacion As EECertificacion = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Certificacion_PartidaDet_cerId_pa")
    '        db.AddInParameter(cmd, "cerId", DbType.String, cerId)
    '        dr = db.ExecuteReader(cmd)
    '        While dr.Read()
    '            If ListaCertificacion Is Nothing Then
    '                ListaCertificacion = New List(Of EECertificacion)()
    '            End If
    '            loCertificacion = New EECertificacion()
    '            loCertificacion.PartId = dr("partId").ToString()
    '            loCertificacion.CerAnio = dr("partAnio").ToString()
    '            loCertificacion.PartNombre = dr("partNombre").ToString()
    '            loCertificacion.TgActProyId = dr("tgActProyId").ToString()
    '            loCertificacion.TgMetaId = dr("tgMetaId").ToString()
    '            loCertificacion.TgFFinancieraId = dr("tgFFinancieraId").ToString()
    '            loCertificacion.cerGrupoParValImporte = CDbl(dr("cerGrupoParValImporte"))
    '            loCertificacion.cerGrupoParValQuedan = CDbl(dr("cerGrupoParValQuedan"))
    '            ListaCertificacion.Add(loCertificacion)
    '        End While
    '    Catch ex As Exception
    '        Throw New Exception("Listar Detalle partidas CerId => " & ex.Message, ex)
    '    End Try
    '    Return ListaCertificacion
    'End Function
    Public Shared Function generaCodigo() As String
        Dim cerId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Certificacion_CerId")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                cerId = dr("cerId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Id Certificación => " + ex.Message, ex)
        End Try
        Return cerId
    End Function

    'Public Shared Function generaCodigoSAIMT() As String
    '    Dim cerNro As String = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase()
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Certificacion_CerNro")
    '        dr = db.ExecuteReader(cmd)
    '        If dr.Read() Then
    '            cerNro = dr("cerNro").ToString()
    '        End If
    '        dr.Close()
    '    Catch ex As Exception
    '        Throw New Exception("Genera Nro Certificación => " + ex.Message, ex)
    '    End Try
    '    Return cerNro
    'End Function
End Class
