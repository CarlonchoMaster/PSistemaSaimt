Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class DocumentoLOGDAS

    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EEDocumentoLOG)
        Dim ListaDocumentoLog As List(Of EEDocumentoLOG) = Nothing
        Dim loDocumentoLog As EEDocumentoLOG = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_DocumentoLog_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaDocumentoLog Is Nothing Then
                    ListaDocumentoLog = New List(Of EEDocumentoLOG)()
                End If
                loDocumentoLog = New EEDocumentoLOG()
                loDocumentoLog.DocId = dr("DocId").ToString()
                loDocumentoLog.TgTipoDocId = dr("TgTipoDocId").ToString()
                loDocumentoLog.DocNroTDoc = dr("DocNroTDoc").ToString()
                loDocumentoLog.DocSerieTDoc = dr("DocSerieTDoc").ToString()
                loDocumentoLog.DocFechaDoc = IIf(IsDBNull(dr("DocFechaDoc")), Nothing, dr("DocFechaDoc"))
                loDocumentoLog.DocFechaReg = IIf(IsDBNull(dr("DocFechaReg")), Nothing, dr("DocFechaReg"))
                loDocumentoLog.DocFechaRec = IIf(IsDBNull(dr("DocFechaRec")), Nothing, dr("DocFechaRec"))
                loDocumentoLog.TgMovId = dr("TgMovId").ToString()
                loDocumentoLog.TgEstadoId = dr("TgEstadoId").ToString()
                ListaDocumentoLog.Add(loDocumentoLog)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoLog Criterio => " + ex.Message, ex)
        End Try
        Return ListaDocumentoLog
    End Function
    Public Shared Function NewCodigo(tgMovId As String) As String
        Dim DocId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_DocumentoLOG_XtgMovId_pa")
            db.AddInParameter(cmd, "tgMovId", DbType.String, tgMovId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                DocId = dr("DocId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar DocumentoLog Criterio => " + ex.Message, ex)
        End Try
        Return DocId
    End Function
End Class
