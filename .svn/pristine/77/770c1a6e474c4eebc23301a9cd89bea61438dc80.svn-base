Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ExpedienteSTDDAS
    Public Shared Function ListarXDocId(ByVal vDocId As String) As List(Of EEExpedienteSTD)
        Dim ListaExpedienteSTD As List(Of EEExpedienteSTD) = Nothing
        Dim loExpedienteSTD As EEExpedienteSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ExpedienteSTD_XDocId_pa")
            db.AddInParameter(cmd, "DocId", DbType.String, vDocId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaExpedienteSTD Is Nothing Then
                    ListaExpedienteSTD = New List(Of EEExpedienteSTD)
                End If
                loExpedienteSTD = New EEExpedienteSTD()
                loExpedienteSTD.DocId = dr("DocId").ToString()
                loExpedienteSTD.DocSecId = dr("docSecId").ToString()
                loExpedienteSTD.loDocumento = New EEDocumentoSTD
                loExpedienteSTD.loDocumento.DocAsunto = dr("docAsunto").ToString()
                loExpedienteSTD.loDocumento.DocId = dr("DocId").ToString()
                loExpedienteSTD.loDocumento.DocNRegT = dr("docNRegT").ToString()
                loExpedienteSTD.loDocumento.DocFechaIng = Convert.ToDateTime(dr("docFechaIng").ToString())
                ListaExpedienteSTD.Add(loExpedienteSTD) 'loExpedienteSTD.loDocumento.DocFechaReg = Convert.ToDateTime(dr("docFechaReg").ToString())   
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ExpedienteSTD X DocId Criterio => " + ex.Message, ex)
        End Try
        Return ListaExpedienteSTD
    End Function

    Public Shared Function MostrarXDocId(ByVal vDocId As String) As EEExpedienteSTD

        Dim loExpedienteSTD As EEExpedienteSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_ExpedienteSTD_XDocId_pa")
            db.AddInParameter(cmd, "DocId", DbType.String, vDocId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loExpedienteSTD = New EEExpedienteSTD()
                loExpedienteSTD.DocId = dr("DocId").ToString()
                loExpedienteSTD.loDocumento = New EEDocumentoSTD
                loExpedienteSTD.loDocumento.DocAsunto = dr("docAsunto").ToString()
                loExpedienteSTD.loDocumento.DocId = dr("docId").ToString()
                loExpedienteSTD.loDocumento.DocNRegT = dr("docNRegT").ToString()
                loExpedienteSTD.loDocumento.DocFechaIng = Convert.ToDateTime(dr("docFechaIng").ToString())
                'loExpedienteSTD.loDocumento.DocFechaReg = Convert.ToDateTime(dr("docFechaReg").ToString())   
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ExpedienteSTD X DocId Criterio => " + ex.Message, ex)
        End Try
        Return loExpedienteSTD
    End Function


    Public Shared Function listarVinculadosXDocId(ByVal vDocId As String) As List(Of EEExpedienteSTD)
        Dim ListaExpedienteSTD As List(Of EEExpedienteSTD) = Nothing
        Dim loExpedienteSTD As EEExpedienteSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_DocVinculadosSTD_XDocId_pa")
            db.AddInParameter(cmd, "DocId", DbType.String, vDocId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaExpedienteSTD Is Nothing Then
                    ListaExpedienteSTD = New List(Of EEExpedienteSTD)
                End If
                loExpedienteSTD = New EEExpedienteSTD()
                loExpedienteSTD.DocId = dr("DocId").ToString()
                loExpedienteSTD.loDocumento = New EEDocumentoSTD
                loExpedienteSTD.loDocumento.DocAsunto = dr("docAsunto").ToString()
                loExpedienteSTD.loDocumento.DocId = dr("docId").ToString()
                loExpedienteSTD.loDocumento.DocNRegT = dr("docNRegT").ToString()
                loExpedienteSTD.loDocumento.DocFechaReg = Convert.ToDateTime(dr("docFechaReg").ToString())
                loExpedienteSTD.loDocumento.oPersonaInteresada = New EEPersona
                loExpedienteSTD.loDocumento.oPersonaInteresada.perNombreCompleto = dr("perInteresado").ToString()
                loExpedienteSTD.loDocumento.oPersonaInteresada.oPerCargoPersonal = New EECargoPersonal
                loExpedienteSTD.loDocumento.oPersonaInteresada.oPerCargoPersonal.Institucion = dr("perIntTgInst").ToString()
                loExpedienteSTD.loDocumento.oPersonaInteresada.oPerCargoPersonal.Area = dr("perIntTgArea").ToString()
                ListaExpedienteSTD.Add(loExpedienteSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ExpedienteSTD X DocId Criterio => " + ex.Message, ex)
        End Try
        Return ListaExpedienteSTD
    End Function


End Class



