Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ConceptosDAO
    Public Shared Function guardar(ByVal aoConceptos As EEConceptos) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Conceptos_pa")

            db.AddInParameter(cmd, "conid", DbType.String, aoConceptos.ConId)
            db.AddInParameter(cmd, "partid", DbType.String, aoConceptos.PartId)
            db.AddInParameter(cmd, "tgcenproid", DbType.String, aoConceptos.TgCenProId)
            db.AddInParameter(cmd, "connombre", DbType.String, aoConceptos.ConNombre)
            db.AddInParameter(cmd, "conporcentaje", DbType.Decimal, aoConceptos.ConPorcentaje)
            db.AddInParameter(cmd, "tgcuebanid", DbType.String, aoConceptos.TgCueBanId)

            db.AddInParameter(cmd, "pcontcuenc", DbType.String, aoConceptos.PcontCuenC)
            db.AddInParameter(cmd, "pcontcuena", DbType.String, aoConceptos.PcontCuenA)

            db.AddInParameter(cmd, "tggrupoconid", DbType.String, aoConceptos.TgGrupoConId)
            db.AddInParameter(cmd, "conactivo", DbType.Boolean, aoConceptos.ConActivo)
            db.AddInParameter(cmd, "conbaselegal", DbType.String, aoConceptos.ConBaseLegal)
            db.AddInParameter(cmd, "conaplimora", DbType.Boolean, aoConceptos.ConApliMora)
            db.AddInParameter(cmd, "concodconmpt", DbType.String, aoConceptos.ConCodConMPT)
            db.AddInParameter(cmd, "concodpresmpt", DbType.String, aoConceptos.ConCodPresMPT)
            db.AddInParameter(cmd, "conaño", DbType.String, aoConceptos.ConAño)
            db.AddInParameter(cmd, "tgsubgrupoid", DbType.String, aoConceptos.TgSubGrupoId)
            db.AddInParameter(cmd, "conimporte", DbType.Decimal, aoConceptos.ConImporte)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar Conceptos => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal aoConceptos As EEConceptos) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Conceptos_pa")

            db.AddInParameter(cmd, "conid", DbType.String, aoConceptos.ConId)
            db.AddInParameter(cmd, "partid", DbType.String, aoConceptos.PartId)
            db.AddInParameter(cmd, "tgcenproid", DbType.String, aoConceptos.TgCenProId)
            db.AddInParameter(cmd, "connombre", DbType.String, aoConceptos.ConNombre)
            db.AddInParameter(cmd, "conporcentaje", DbType.Decimal, aoConceptos.ConPorcentaje)
            db.AddInParameter(cmd, "tgcuebanid", DbType.String, aoConceptos.TgCueBanId)
            db.AddInParameter(cmd, "pcontcuenc", DbType.String, aoConceptos.PcontCuenC)
            db.AddInParameter(cmd, "pcontcuena", DbType.String, aoConceptos.PcontCuenA)
            db.AddInParameter(cmd, "tggrupoconid", DbType.String, aoConceptos.TgGrupoConId)
            db.AddInParameter(cmd, "conactivo", DbType.Boolean, aoConceptos.ConActivo)
            db.AddInParameter(cmd, "conbaselegal", DbType.String, aoConceptos.ConBaseLegal)
            db.AddInParameter(cmd, "conaplimora", DbType.Boolean, aoConceptos.ConApliMora)
            db.AddInParameter(cmd, "concodconmpt", DbType.String, aoConceptos.ConCodConMPT)
            db.AddInParameter(cmd, "concodpresmpt", DbType.String, aoConceptos.ConCodPresMPT)
            db.AddInParameter(cmd, "conaño", DbType.String, aoConceptos.ConAño)
            db.AddInParameter(cmd, "tgsubgrupoid", DbType.String, aoConceptos.TgSubGrupoId)
            db.AddInParameter(cmd, "conimporte", DbType.Decimal, aoConceptos.ConImporte)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar Conceptos => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(ByVal aiIdConceptos As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_Conceptos_pa")

            db.AddInParameter(cmd, "idConceptos", DbType.Int32, aiIdConceptos)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Conceptos => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class


