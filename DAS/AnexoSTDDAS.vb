Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades
Public Class AnexoSTDDAS

    Public Shared Function listarXDocId(DocId As [String]) As List(Of EEAnexoSTD)
        Dim ListaAnexoSTD As List(Of EEAnexoSTD) = Nothing
        Dim loAnexoSTD As EEAnexoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_AnexoSTD_XDocId_pa")
            db.AddInParameter(cmd, "docId", DbType.String, DocId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaAnexoSTD Is Nothing Then
                    ListaAnexoSTD = New List(Of EEAnexoSTD)()
                End If

                loAnexoSTD = New EEAnexoSTD()
                loAnexoSTD.DocId = dr("DocId").ToString()
                loAnexoSTD.AneId = dr("AneId").ToString()
                loAnexoSTD.AneNombre = dr("AneNombre").ToString()
                loAnexoSTD.AneDescripcion = dr("AneDescripcion").ToString()
                loAnexoSTD.TgTipoArchId = dr("TgTipoArchId").ToString()
                loAnexoSTD.TgTipoArch = dr("TgTipoArch").ToString()
                loAnexoSTD.AneArch = dr("AneArch").ToString()
                loAnexoSTD.AneArchExt = dr("AneArchExt").ToString()

                ListaAnexoSTD.Add(loAnexoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar AnexoSTD x DocID => " + ex.Message, ex)
        End Try
        Return ListaAnexoSTD
    End Function

#Region "Listar AnexoSTD XFechaServidor TransferirAnexos"
    Public Shared Function listarXFechaServidor(adtFecha As Date) As List(Of EEAnexoSTD)
        Dim ListaAnexoSTD As List(Of EEAnexoSTD) = Nothing
        Dim loAnexoSTD As EEAnexoSTD = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_AnexoSTD_XFechaServidor_TransferirAnexo_pa")
            db.AddInParameter(cmd, "fechaservidor", DbType.Date, adtFecha)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaAnexoSTD Is Nothing Then
                    ListaAnexoSTD = New List(Of EEAnexoSTD)()
                End If

                loAnexoSTD = New EEAnexoSTD()
                loAnexoSTD.DocId = dr("DocId").ToString()
                loAnexoSTD.AneId = dr("AneId").ToString()
                loAnexoSTD.AneArch = dr("AneArch").ToString()
                loAnexoSTD.AneArchExt = dr("AneArchExt").ToString()

                ListaAnexoSTD.Add(loAnexoSTD)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar AnexoSTD x DocID => " + ex.Message, ex)
        End Try
        Return ListaAnexoSTD
    End Function
#End Region


End Class

