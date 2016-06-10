Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ReqDocumentoSTDDAS


    Public Shared Function listarxDocId(DocId As [String]) As List(Of EEReqDocumentoSTD)
        Dim ListaReqDocumentoSTD As List(Of EEReqDocumentoSTD) = Nothing
        Dim loReqDocumentoSTD As EEReqDocumentoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ReqDocumentoSTD_XdocId_pa")
            db.AddInParameter(cmd, "docId", DbType.String, DocId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaReqDocumentoSTD Is Nothing Then
                    ListaReqDocumentoSTD = New List(Of EEReqDocumentoSTD)()
                End If

                loReqDocumentoSTD = New EEReqDocumentoSTD()

                loReqDocumentoSTD.DocId = dr("DocId").ToString()
                loReqDocumentoSTD.TgReqId = dr("TgReqId").ToString()

                ListaReqDocumentoSTD.Add(loReqDocumentoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ReqDocumentoSTD Criterio => " + ex.Message, ex)
        End Try
        Return ListaReqDocumentoSTD
    End Function

    
End Class

