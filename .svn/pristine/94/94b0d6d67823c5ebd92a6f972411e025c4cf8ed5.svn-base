Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class DocumentoSTDDAO
    Public Shared Function guardar(aoDocumentoSTD As EEDocumentoSTD) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_DocumentoSTD_pa")

                    db.AddInParameter(cmd, "docorigen", DbType.String, aoDocumentoSTD.DocOrigen)
                    db.AddInParameter(cmd, "doctupac", DbType.Boolean, aoDocumentoSTD.DocTupac)
                    db.AddInParameter(cmd, "tgtdocid", DbType.String, aoDocumentoSTD.TgTDocId)
                    db.AddInParameter(cmd, "docnreg", DbType.String, aoDocumentoSTD.DocNReg)
                    db.AddInParameter(cmd, "docnfolio", DbType.Int32, aoDocumentoSTD.DocNFolio)
                    db.AddInParameter(cmd, "docfechaing", DbType.DateTime, aoDocumentoSTD.DocFechaIng)
                    db.AddInParameter(cmd, "procid", DbType.String, aoDocumentoSTD.ProcId)
                    db.AddInParameter(cmd, "docasunto", DbType.String, aoDocumentoSTD.DocAsunto)
                    db.AddInParameter(cmd, "docid", DbType.String, aoDocumentoSTD.DocId)
                    db.AddInParameter(cmd, "docconfreq", DbType.Boolean, aoDocumentoSTD.DocConfReq)
                    db.AddInParameter(cmd, "perid", DbType.String, aoDocumentoSTD.PerId)
                    db.AddInParameter(cmd, "doccomentario", DbType.String, aoDocumentoSTD.DocComentario)
                    db.AddInParameter(cmd, "tgmovtramiteid", DbType.String, aoDocumentoSTD.TgMovTramiteId)
                    db.AddInParameter(cmd, "docfechadoc", DbType.DateTime, aoDocumentoSTD.DocFechaDoc)
                    db.AddInParameter(cmd, "docnref", DbType.String, aoDocumentoSTD.DocNRef)
                    db.AddInParameter(cmd, "docInt", DbType.String, aoDocumentoSTD.DocInt)
                    db.AddInParameter(cmd, "docAux", DbType.String, aoDocumentoSTD.DocAux)
                    db.AddInParameter(cmd, "docCargoIdEdit", DbType.String, aoDocumentoSTD.DocCargoIdEdit)
                    db.AddInParameter(cmd, "docPerIdEdit", DbType.String, aoDocumentoSTD.DocPerIdEdit)
                    db.AddInParameter(cmd, "docFormReg", DbType.Int16, aoDocumentoSTD.DocFormReg)
                    db.ExecuteNonQuery(cmd, transaccion)

                    'Requisitos
                    If aoDocumentoSTD.ListaRequisitosDoc IsNot Nothing Then
                        For Each aoReqDocumentoSTD As EEReqDocumentoSTD In aoDocumentoSTD.ListaRequisitosDoc
                            cmd = db.GetStoredProcCommand("Insertar_ReqDocumentoSTD_pa")
                            db.AddInParameter(cmd, "docid", DbType.String, aoReqDocumentoSTD.DocId)
                            db.AddInParameter(cmd, "tgreqid", DbType.String, aoReqDocumentoSTD.TgReqId)
                            db.ExecuteNonQuery(cmd, transaccion)
                        Next
                    End If
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar DocumentoSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(aoDocumentoSTD As EEDocumentoSTD) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_DocumentoSTD_pa")
                    db.AddInParameter(cmd, "docorigen", DbType.String, aoDocumentoSTD.DocOrigen)
                    db.AddInParameter(cmd, "doctupac", DbType.Boolean, aoDocumentoSTD.DocTupac)
                    db.AddInParameter(cmd, "tgtdocid", DbType.String, aoDocumentoSTD.TgTDocId)
                    db.AddInParameter(cmd, "docnreg", DbType.String, aoDocumentoSTD.DocNReg)
                    db.AddInParameter(cmd, "docnfolio", DbType.Int32, aoDocumentoSTD.DocNFolio)
                    db.AddInParameter(cmd, "docfechaing", DbType.DateTime, aoDocumentoSTD.DocFechaIng)
                    db.AddInParameter(cmd, "procid", DbType.String, aoDocumentoSTD.ProcId)
                    db.AddInParameter(cmd, "docasunto", DbType.String, aoDocumentoSTD.DocAsunto)
                    db.AddInParameter(cmd, "docid", DbType.String, aoDocumentoSTD.DocId)
                    db.AddInParameter(cmd, "docconfreq", DbType.Boolean, aoDocumentoSTD.DocConfReq)
                    db.AddInParameter(cmd, "perid", DbType.String, aoDocumentoSTD.PerId)
                    db.AddInParameter(cmd, "doccomentario", DbType.String, aoDocumentoSTD.DocComentario)
                    db.AddInParameter(cmd, "tgmovtramiteid", DbType.String, aoDocumentoSTD.TgMovTramiteId)
                    db.AddInParameter(cmd, "docfechadoc", DbType.DateTime, aoDocumentoSTD.DocFechaDoc)
                    db.AddInParameter(cmd, "docnref", DbType.String, aoDocumentoSTD.DocNRef)
                    db.AddInParameter(cmd, "docInt", DbType.String, aoDocumentoSTD.DocInt)
                    db.AddInParameter(cmd, "docAux", DbType.String, aoDocumentoSTD.DocAux)
                    db.AddInParameter(cmd, "doceliminado", DbType.Boolean, aoDocumentoSTD.DocEliminado)
                    db.ExecuteNonQuery(cmd, transaccion)
                    'Requisitos Eliminino
                    cmd = db.GetStoredProcCommand("Eliminar_ReqDocumentoSTD_pa")
                    db.AddInParameter(cmd, "docId", DbType.String, aoDocumentoSTD.DocId)
                    db.ExecuteNonQuery(cmd, transaccion)
                    'Requisitos
                    For Each aoReqDocumentoSTD As EEReqDocumentoSTD In aoDocumentoSTD.ListaRequisitosDoc
                        cmd = db.GetStoredProcCommand("Insertar_ReqDocumentoSTD_pa")
                        db.AddInParameter(cmd, "docid", DbType.String, aoReqDocumentoSTD.DocId)
                        db.AddInParameter(cmd, "tgreqid", DbType.String, aoReqDocumentoSTD.TgReqId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualiza DocumentoSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function

    '#Region "Actualizar Vincular Desvincular"
    '    Public Shared Function vincular(asDocId As String, asDocVinId As String, aiDocNPartePrincipal As Int16, aiDocNParteVinculado As Int16) As Boolean
    '        Try
    '            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_DocumentoSTD_Vinculo_pa")

    '            db.AddInParameter(cmd, "docid", DbType.String, asDocId)
    '            db.AddInParameter(cmd, "docvinid", DbType.String, asDocVinId)
    '            db.AddInParameter(cmd, "docnpartevinculado", DbType.Int16, aiDocNParteVinculado)
    '            db.AddInParameter(cmd, "docnparteprincipal", DbType.Int16, aiDocNPartePrincipal)
    '            db.ExecuteNonQuery(cmd)

    '        Catch ex As Exception
    '            Throw New Exception("Actualizar DocumentoSTD Vinculo => " & ex.Message, ex)
    '        End Try
    '        Return True
    '    End Function

    '    Public Shared Function desvincular(asDocId As String) As Boolean
    '        Try
    '            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_DocumentoSTD_Desvincular_pa")

    '            db.AddInParameter(cmd, "docid", DbType.String, asDocId)
    '            db.ExecuteNonQuery(cmd)

    '        Catch ex As Exception
    '            Throw New Exception("Actualizar DocumentoSTD DesVincular => " & ex.Message, ex)
    '        End Try
    '        Return True
    '    End Function
    '#End Region

    Public Shared Function eliminar(aiIdDocumentoSTD As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_DocumentoSTD_pa")
            db.AddInParameter(cmd, "idDocumentoSTD", DbType.Int32, aiIdDocumentoSTD)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Eliminar DocumentoSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class
