Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class DocInternoSTDDAS
    Public Shared Function NewCodigo() As String
        Dim _NewCodigo As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Generar_Codigo_DocInternoSTD")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                _NewCodigo = dr("docId").ToString()
            End If
        Catch ex As Exception
            Throw New Exception("Listar DocInternoSTD Criterio => " + ex.Message, ex)
        End Try
        Return _NewCodigo
    End Function
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEDocInternoSTD)
        Dim ListaDocInternoSTD As List(Of EEDocInternoSTD) = Nothing
        Dim loDocInternoSTD As EEDocInternoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_DocInternoSTD_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocInternoSTD Is Nothing Then
                    ListaDocInternoSTD = New List(Of EEDocInternoSTD)()
                End If

                loDocInternoSTD = New EEDocInternoSTD()

                loDocInternoSTD.DocId = dr("DocId").ToString()
                loDocInternoSTD.TgMovDocId = dr("TgMovDocId").ToString()
                loDocInternoSTD.TgMovDoc = dr("TgMovDoc").ToString()
                loDocInternoSTD.TgMedDocId = dr("TgMedDocId").ToString()
                loDocInternoSTD.TgMedDoc = dr("TgMedDoc").ToString()
                loDocInternoSTD.TgTipoDocId = dr("TgTipoDocId").ToString()
                loDocInternoSTD.TgTipoDoc = dr("TgTipoDoc").ToString()
                loDocInternoSTD.DocNro = dr("DocNro").ToString()
                loDocInternoSTD.DocNroRef = dr("DocNroRef").ToString()
                loDocInternoSTD.DocPerDe = dr("DocPerDe").ToString()
                loDocInternoSTD.DocPerPara = dr("DocPerPara").ToString()
                loDocInternoSTD.PerDeId = dr("PerDeId").ToString()
                loDocInternoSTD.PerDe = dr("PerDe").ToString()
                loDocInternoSTD.PerParaId = dr("PerParaId").ToString()
                loDocInternoSTD.PerPara = dr("PerPara").ToString()
                loDocInternoSTD.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loDocInternoSTD.DocFechaRecEmi = IIf(IsDBNull(dr("DocFechaRecEmi")), Nothing, dr("DocFechaRecEmi"))
                loDocInternoSTD.TgEstadoDocId = dr("TgEstadoDocId").ToString()
                loDocInternoSTD.TgEstadoDoc = dr("TgEstadoDoc").ToString()
                loDocInternoSTD.DocNroProv = dr("DocNroProv").ToString()
                loDocInternoSTD.DocNroRegProv = dr("DocNroRegProv").ToString()
                loDocInternoSTD.DocAsunto = dr("DocAsunto").ToString()
                loDocInternoSTD.DocResumen = dr("DocResumen").ToString()
                loDocInternoSTD.TgMensajeProvId = dr("TgMensajeProvId").ToString()
                loDocInternoSTD.TgPrioridadId = dr("tgPrioridadId").ToString()
                loDocInternoSTD.docNroFolio = IIf(IsDBNull(dr("docNroFolio")), 0, dr("docNroFolio"))
                ListaDocInternoSTD.Add(loDocInternoSTD)
            End While
        Catch ex As Exception
            Throw New Exception("Listar DocInternoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocInternoSTD
    End Function

    Public Shared Function pivotearXFechaIni_XFechaFin(ByVal adFechaInicio As Date, ByVal adFechaFin As Date) As List(Of EEDocInternoSTD)
        Dim ListaDocInternoSTD As List(Of EEDocInternoSTD) = Nothing
        Dim loDocInternoSTD As EEDocInternoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Pivotear_DocInternoSTD_pa")
            db.AddInParameter(cmd, "fechainicio", DbType.Date, adFechaInicio)
            db.AddInParameter(cmd, "fechafin", DbType.Date, adFechaFin)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocInternoSTD Is Nothing Then
                    ListaDocInternoSTD = New List(Of EEDocInternoSTD)()
                End If

                loDocInternoSTD = New EEDocInternoSTD()

                loDocInternoSTD.DocId = dr("DocId").ToString()
                loDocInternoSTD.TgMovDocId = dr("TgMovDocId").ToString()
                loDocInternoSTD.TgMovDoc = dr("TgMovDoc").ToString()
                loDocInternoSTD.TgMedDocId = dr("TgMedDocId").ToString()
                loDocInternoSTD.TgMedDoc = dr("TgMedDoc").ToString()
                loDocInternoSTD.TgTipoDocId = dr("TgTipoDocId").ToString()
                loDocInternoSTD.TgTipoDoc = dr("TgTipoDoc").ToString()
                loDocInternoSTD.DocNro = dr("DocNro").ToString()
                loDocInternoSTD.DocNroRef = dr("DocNroRef").ToString()
                loDocInternoSTD.DocPerDe = dr("DocPerDe").ToString()
                loDocInternoSTD.DocPerPara = dr("DocPerPara").ToString()
                loDocInternoSTD.PerDeId = dr("PerDeId").ToString()
                loDocInternoSTD.PerDe = dr("PerDe").ToString()
                loDocInternoSTD.PerParaId = dr("PerParaId").ToString()
                loDocInternoSTD.PerPara = dr("PerPara").ToString()
                loDocInternoSTD.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loDocInternoSTD.DocFechaRecEmi = IIf(IsDBNull(dr("DocFechaRecEmi")), Nothing, dr("DocFechaRecEmi"))
                loDocInternoSTD.TgEstadoDocId = dr("TgEstadoDocId").ToString()
                loDocInternoSTD.TgEstadoDoc = dr("TgEstadoDoc").ToString()
                loDocInternoSTD.DocNroProv = dr("DocNroProv").ToString()
                loDocInternoSTD.DocNroRegProv = dr("DocNroRegProv").ToString()
                loDocInternoSTD.DocAsunto = dr("DocAsunto").ToString()
                loDocInternoSTD.DocResumen = dr("DocResumen").ToString()
                loDocInternoSTD.TgMensajeProvId = dr("TgMensajeProvId").ToString()
                loDocInternoSTD.TgMensajeProv = dr("tgMensajeProv").ToString()
                loDocInternoSTD.TgPrioridadId = dr("tgPrioridadId").ToString()
                loDocInternoSTD.docNroFolio = IIf(IsDBNull(dr("docNroFolio")), 0, dr("docNroFolio"))

                ListaDocInternoSTD.Add(loDocInternoSTD)
            End While
        Catch ex As Exception
            Throw New Exception("Listar DocInternoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocInternoSTD
    End Function
End Class