Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class CompProgramacionDAS
    Public Shared Function ValidarSugerir(asNroCompI As String, asNroCompF As String, Serie As String) As List(Of EECompProgramacion)
        Dim ListaCompProgramacion As List(Of EECompProgramacion) = Nothing
        Dim loCompProgramacion As EECompProgramacion = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Validar_CompProgramacion_pa")
            db.AddInParameter(cmd, "nroInicio", DbType.String, asNroCompI)
            db.AddInParameter(cmd, "nroFinal", DbType.String, asNroCompF)
            db.AddInParameter(cmd, "serie", DbType.String, Serie)
            db.AddOutParameter(cmd, "nromax", DbType.Int32, 8)
            db.AddOutParameter(cmd, "count", DbType.Int32, 8)
            db.ExecuteNonQuery(cmd)
            If ListaCompProgramacion Is Nothing Then
                ListaCompProgramacion = New List(Of EECompProgramacion)()
            End If
            loCompProgramacion = New EECompProgramacion()
            loCompProgramacion.NroMaxComp = IIf(IsDBNull(db.GetParameterValue(cmd, "nromax")), 0, db.GetParameterValue(cmd, "nromax"))
            loCompProgramacion.CountComp = IIf(IsDBNull(db.GetParameterValue(cmd, "count")), 0, db.GetParameterValue(cmd, "count"))

            ListaCompProgramacion.Add(loCompProgramacion)

        Catch ex As Exception
            Throw New Exception("Listar Validar y Sugerir Comp Programacion => " + ex.Message, ex)
        End Try
        Return ListaCompProgramacion
    End Function

    Public Shared Function Existe(asProPaId As String) As List(Of EECompProgramacion)
        Dim ListaCompProgramacion As List(Of EECompProgramacion) = Nothing
        Dim loCompProgramacion As EECompProgramacion = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Existe_CompProgramacion_by_propaId_pa")
            db.AddInParameter(cmd, "ProPaId", DbType.String, asProPaId)
            dr = db.ExecuteReader(cmd)

            While dr.Read()
                If ListaCompProgramacion Is Nothing Then
                    ListaCompProgramacion = New List(Of EECompProgramacion)
                End If
                loCompProgramacion = New EECompProgramacion()
                loCompProgramacion.ProPaId = dr("ProPaId").ToString.Trim
                loCompProgramacion.TgTipoCompId = dr("tgTipoCompId").ToString.Trim
                loCompProgramacion.CompProPagNro = dr("compProPagNro").ToString.Trim
                loCompProgramacion.CompProPagSerie = dr("compProPagSerie").ToString.Trim

                ListaCompProgramacion.Add(loCompProgramacion)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Existe Comp Programacion => " + ex.Message, ex)
        End Try
        Return ListaCompProgramacion
    End Function
End Class
