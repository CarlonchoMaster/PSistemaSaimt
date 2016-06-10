Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class DocInternoSTDDAO
    Public Shared Function guardar(ByVal aoDocInternoSTD As EEDocInternoSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_DocInternoSTD_pa")

            db.AddInParameter(cmd, "docid", DbType.String, aoDocInternoSTD.DocId)
            db.AddInParameter(cmd, "tgmovdocid", DbType.String, aoDocInternoSTD.TgMovDocId)
            db.AddInParameter(cmd, "tgmeddocid", DbType.String, aoDocInternoSTD.TgMedDocId)
            db.AddInParameter(cmd, "tgtipodocid", DbType.String, aoDocInternoSTD.TgTipoDocId)
            db.AddInParameter(cmd, "docnro", DbType.String, aoDocInternoSTD.DocNro)
            db.AddInParameter(cmd, "docnroref", DbType.String, aoDocInternoSTD.DocNroRef)
            db.AddInParameter(cmd, "docperde", DbType.String, aoDocInternoSTD.DocPerDe)
            db.AddInParameter(cmd, "docperpara", DbType.String, aoDocInternoSTD.DocPerPara)
            db.AddInParameter(cmd, "perdeid", DbType.String, aoDocInternoSTD.PerDeId)
            db.AddInParameter(cmd, "perparaid", DbType.String, aoDocInternoSTD.PerParaId)
            db.AddInParameter(cmd, "DocFechaDoc", DbType.DateTime, aoDocInternoSTD.DocFechaDoc)
            db.AddInParameter(cmd, "docFechaRecEmi", DbType.DateTime, aoDocInternoSTD.docFechaRecEmi)
            db.AddInParameter(cmd, "tgestadodocid", DbType.String, aoDocInternoSTD.TgEstadoDocId)
            db.AddInParameter(cmd, "docnroprov", DbType.String, aoDocInternoSTD.DocNroProv)
            db.AddInParameter(cmd, "docnroregprov", DbType.String, aoDocInternoSTD.DocNroRegProv)
            db.AddInParameter(cmd, "docasunto", DbType.String, aoDocInternoSTD.DocAsunto)
            db.AddInParameter(cmd, "docresumen", DbType.String, aoDocInternoSTD.DocResumen)
            db.AddInParameter(cmd, "tgmensajeprovid", DbType.String, aoDocInternoSTD.TgMensajeProvId)
            db.AddInParameter(cmd, "TgPrioridadId", DbType.String, aoDocInternoSTD.TgPrioridadId)
            db.AddInParameter(cmd, "docperreg", DbType.String, aoDocInternoSTD.DocPerReg)
            db.AddInParameter(cmd, "perregid", DbType.String, aoDocInternoSTD.PerRegId)
            db.AddInParameter(cmd, "docNroFolio", DbType.String, aoDocInternoSTD.docNroFolio)

            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar DocInternoSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal aoDocInternoSTD As EEDocInternoSTD) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_DocInternoSTD_pa")

            db.AddInParameter(cmd, "docid", DbType.String, aoDocInternoSTD.DocId)
            db.AddInParameter(cmd, "tgmovdocid", DbType.String, aoDocInternoSTD.TgMovDocId)
            db.AddInParameter(cmd, "tgmeddocid", DbType.String, aoDocInternoSTD.TgMedDocId)
            db.AddInParameter(cmd, "tgtipodocid", DbType.String, aoDocInternoSTD.TgTipoDocId)
            db.AddInParameter(cmd, "docnro", DbType.String, aoDocInternoSTD.DocNro)
            db.AddInParameter(cmd, "docnroref", DbType.String, aoDocInternoSTD.DocNroRef)
            db.AddInParameter(cmd, "docperde", DbType.String, aoDocInternoSTD.DocPerDe)
            db.AddInParameter(cmd, "docperpara", DbType.String, aoDocInternoSTD.DocPerPara)
            db.AddInParameter(cmd, "perdeid", DbType.String, aoDocInternoSTD.PerDeId)
            db.AddInParameter(cmd, "perparaid", DbType.String, aoDocInternoSTD.PerParaId)
            db.AddInParameter(cmd, "DocFechaDoc", DbType.DateTime, aoDocInternoSTD.DocFechaDoc)
            db.AddInParameter(cmd, "docFechaRecEmi", DbType.DateTime, aoDocInternoSTD.DocFechaRecEmi)
            db.AddInParameter(cmd, "tgestadodocid", DbType.String, aoDocInternoSTD.TgEstadoDocId)
            db.AddInParameter(cmd, "docnroprov", DbType.String, aoDocInternoSTD.DocNroProv)
            db.AddInParameter(cmd, "docnroregprov", DbType.String, aoDocInternoSTD.DocNroRegProv)
            db.AddInParameter(cmd, "docasunto", DbType.String, aoDocInternoSTD.DocAsunto)
            db.AddInParameter(cmd, "docresumen", DbType.String, aoDocInternoSTD.DocResumen)
            db.AddInParameter(cmd, "tgmensajeprovid", DbType.String, aoDocInternoSTD.TgMensajeProvId)
            db.AddInParameter(cmd, "TgPrioridadId", DbType.String, aoDocInternoSTD.TgPrioridadId)
            db.AddInParameter(cmd, "docperreg", DbType.String, aoDocInternoSTD.DocPerReg)
            db.AddInParameter(cmd, "perregid", DbType.String, aoDocInternoSTD.PerRegId)
            db.AddInParameter(cmd, "docNroFolio", DbType.String, aoDocInternoSTD.docNroFolio)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar DocInternoSTD => " & ex.Message, ex)
        End Try
        Return True
    End Function


End Class
