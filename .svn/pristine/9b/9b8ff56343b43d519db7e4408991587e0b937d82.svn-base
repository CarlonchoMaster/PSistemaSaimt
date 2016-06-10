Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class CompProgramacionDAO
    Public Shared Function guardar(aoCompProgramacion As EECompProgramacion) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_CompProgramacion_pa")

            db.AddInParameter(cmd, "propaid", DbType.String, aoCompProgramacion.ProPaId)
            db.AddInParameter(cmd, "comppropagserie", DbType.String, aoCompProgramacion.CompProPagSerie)
            db.AddInParameter(cmd, "comppropagnro", DbType.String, aoCompProgramacion.CompProPagNro)
            db.AddInParameter(cmd, "tgtipocompid", DbType.String, aoCompProgramacion.TgTipoCompId)
            db.AddInParameter(cmd, "tgestcompid", DbType.String, aoCompProgramacion.TgEstCompId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar CompProgramacion => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(aoCompProgramacion As EECompProgramacion) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_CompProgramacion_tgEstCompId_pa")

            db.AddInParameter(cmd, "propaid", DbType.String, aoCompProgramacion.ProPaId)
            db.AddInParameter(cmd, "comppropagserie", DbType.String, aoCompProgramacion.CompProPagSerie)
            db.AddInParameter(cmd, "comppropagnro", DbType.String, aoCompProgramacion.CompProPagNro)
            db.AddInParameter(cmd, "tgtipocompid", DbType.String, aoCompProgramacion.TgTipoCompId)
            db.AddInParameter(cmd, "tgestcompid", DbType.String, aoCompProgramacion.TgEstCompId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar CompProgramacion => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(aiIdCompProgramacion As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_CompProgramacion_pa")

            db.AddInParameter(cmd, "idCompProgramacion", DbType.Int32, aiIdCompProgramacion)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar CompProgramacion => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EECompProgramacion)
        Dim ListaCompProgramacion As List(Of EECompProgramacion) = Nothing
        Dim loCompProgramacion As EECompProgramacion = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CompProgramacion_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCompProgramacion Is Nothing Then
                    ListaCompProgramacion = New List(Of EECompProgramacion)()
                End If

                loCompProgramacion = New EECompProgramacion()

                loCompProgramacion.ProPaId = dr("ProPaId").ToString()
                loCompProgramacion.CompProPagSerie = dr("CompProPagSerie").ToString()
                loCompProgramacion.CompProPagNro = dr("CompProPagNro").ToString()
                loCompProgramacion.TgTipoCompId = dr("TgTipoCompId").ToString()
                loCompProgramacion.TgEstComp = dr("TgEstComp").ToString()


                ListaCompProgramacion.Add(loCompProgramacion)
            End While
        Catch ex As Exception
            Throw New Exception("Listar CompProgramacion Criterio => " + ex.Message, ex)
        End Try
        Return ListaCompProgramacion
    End Function

    Public Shared Function listarALL() As List(Of EECompProgramacion)
        Dim ListaCompProgramacion As List(Of EECompProgramacion) = Nothing
        Dim loCompProgramacion As EECompProgramacion = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_CompProgramacion_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaCompProgramacion Is Nothing Then
                    ListaCompProgramacion = New List(Of EECompProgramacion)()
                End If

                loCompProgramacion = New EECompProgramacion()

                loCompProgramacion.ProPaId = dr("ProPaId").ToString()
                loCompProgramacion.CompProPagSerie = dr("CompProPagSerie").ToString()
                loCompProgramacion.CompProPagNro = dr("CompProPagNro").ToString()
                loCompProgramacion.TgTipoCompId = dr("TgTipoCompId").ToString()
                loCompProgramacion.TgEstComp = dr("TgEstComp").ToString()


                ListaCompProgramacion.Add(loCompProgramacion)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ALL CompProgramacion => " & ex.Message, ex)
        End Try
        Return ListaCompProgramacion
    End Function
End Class



