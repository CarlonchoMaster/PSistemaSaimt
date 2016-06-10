﻿Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades
Public Class MovimientoSTDDAO
    Public Shared Function guardar(ByVal aoMovimientoSTD As EEMovimientoSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_MovimientoSTD_pa")
            'Movimiento Actual -- Para actualizar el envio
            db.AddInParameter(cmd, "movId", DbType.String, aoMovimientoSTD.MovId)

            db.AddInParameter(cmd, "movde", DbType.String, aoMovimientoSTD.MovDe)
            db.AddInParameter(cmd, "movPerIdDe", DbType.String, aoMovimientoSTD.MovPerIdDe)
            db.AddInParameter(cmd, "movPerIdPara", DbType.String, aoMovimientoSTD.MovPerIdPara)
            db.AddInParameter(cmd, "movpara", DbType.String, aoMovimientoSTD.MovPara)
            db.AddInParameter(cmd, "movcomentario", DbType.String, aoMovimientoSTD.MovComentario)
            db.AddInParameter(cmd, "docid", DbType.String, aoMovimientoSTD.DocId)
            db.AddInParameter(cmd, "tgEstadoMovId", DbType.String, aoMovimientoSTD.TgEstadoMovId)
            db.AddInParameter(cmd, "tgTDestinoId", DbType.String, aoMovimientoSTD.TgTDestinoId)
            db.AddInParameter(cmd, "movArch", DbType.Binary, aoMovimientoSTD.MovArch)
            db.AddInParameter(cmd, "movNroDocInt", DbType.String, aoMovimientoSTD.MovNroDocInt)
            db.AddInParameter(cmd, "movTgTDocId", DbType.String, aoMovimientoSTD.MovTgTDocId)
            db.ExecuteNonQuery(cmd)

            'Para conocimiento
            If aoMovimientoSTD.MovParaCC <> "" Then
                cmd = db.GetStoredProcCommand("Insertar_MovimientoSTD_pa")
                db.AddInParameter(cmd, "movde", DbType.String, aoMovimientoSTD.MovDe)
                db.AddInParameter(cmd, "movPerIdDe", DbType.String, aoMovimientoSTD.MovPerIdDe)
                db.AddInParameter(cmd, "movPerIdPara", DbType.String, aoMovimientoSTD.MovPerIdParaCC)
                db.AddInParameter(cmd, "movpara", DbType.String, aoMovimientoSTD.MovParaCC)
                db.AddInParameter(cmd, "movcomentario", DbType.String, aoMovimientoSTD.MovComentario)
                db.AddInParameter(cmd, "docid", DbType.String, aoMovimientoSTD.DocId)
                db.AddInParameter(cmd, "tgEstadoMovId", DbType.String, aoMovimientoSTD.TgEstadoMovId)
                db.AddInParameter(cmd, "tgTDestinoId", DbType.String, aoMovimientoSTD.TgTDestinoId)
                db.AddInParameter(cmd, "movArch", DbType.Binary, aoMovimientoSTD.MovArch)
                db.AddInParameter(cmd, "movNroDocInt", DbType.String, aoMovimientoSTD.MovNroDocInt)
                db.AddInParameter(cmd, "movTgTDocId", DbType.String, aoMovimientoSTD.MovTgTDocId)
                db.AddInParameter(cmd, "movIsCopia", DbType.Boolean, True)
                db.ExecuteNonQuery(cmd)
            End If
        Catch ex As Exception
            Throw New Exception("Guardar MovimientoSTD => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function ActualizarLectura(MovId As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_MovimientoSTD_Lectura_pa")
            db.AddInParameter(cmd, "movid", DbType.String, MovId)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Actualizar MovimientoSTD Lectura => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function ActualizarEstadoMov(MovId As String, EstadoMovId As Integer, Comentario As String, cargo As String, docId As String, Optional autoenvio As Boolean = False) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_MovimientoSTD_tgEstadoMovId_movId_pa")
            db.AddInParameter(cmd, "movid", DbType.String, MovId)
            db.AddInParameter(cmd, "movComentario", DbType.String, " --> Comentario Final " & cargo & ": " & Comentario)
            db.AddInParameter(cmd, "tgEstadoMovId", DbType.Int32, EstadoMovId)
            db.AddInParameter(cmd, "docid", DbType.String, docId)
            db.AddInParameter(cmd, "autoenvio", DbType.Boolean, autoenvio)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Actualizar MovimientoSTD  Estado MovId => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function ActualizarRecepcionManual(ByVal MovId As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_MovimientoSTD_Recepcion_X_movId_pa")
            db.AddInParameter(cmd, "movid", DbType.String, MovId)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Actualizar MovimientoSTD Rececpion x MovId => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function EliminarXMovId(ByVal MovId As Integer) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_MovimientoSTD_XmovId_pa")
            db.AddInParameter(cmd, "movid", DbType.String, MovId)
            db.ExecuteNonQuery(cmd)
        Catch ex As Exception
            Throw New Exception("Eliminar MovimientoSTD X MovId => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class