Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class GrupoFormulariosDAS
   
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As String) As List(Of EEGrupoFormularios)
        Dim ListaGrupoFormularios As List(Of EEGrupoFormularios) = Nothing
        Dim loGrupoFormularios As EEGrupoFormularios = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_GrupoFormularios_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaGrupoFormularios Is Nothing Then
                    ListaGrupoFormularios = New List(Of EEGrupoFormularios)()
                End If

                loGrupoFormularios = New EEGrupoFormularios()

                loGrupoFormularios.GrfId = Convert.ToInt32(dr("GrfId").ToString())
                loGrupoFormularios.GrfNombre = dr("GrfNombre").ToString()
                loGrupoFormularios.GrfDescripcion = dr("GrfDescripcion").ToString()

                ListaGrupoFormularios.Add(loGrupoFormularios)
            End While
        Catch ex As Exception
            Throw New Exception("Listar GrupoFormularios Criterio => " & ex.Message, ex)
        End Try
        Return ListaGrupoFormularios
    End Function

#Region "Listar ALL En Usuarios"
    ''' <summary>
    ''' LISTA TODOS LOS FORMULARIOS CON SU RESPECTIVO GRUPO
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function listarALL_EnUsuarios() As List(Of EEGrupoFormularios)
        Dim ListaGrupoFormularios As List(Of EEGrupoFormularios) = Nothing
        Dim loGrupoFormularios As EEGrupoFormularios = Nothing
        Dim loMenuFormularios As EEMenuFormularios = Nothing
        Dim dr As IDataReader = Nothing
        Dim drMenuFormularios As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_GrupoFormularios_All_EnUsuarios_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaGrupoFormularios Is Nothing Then
                    ListaGrupoFormularios = New List(Of EEGrupoFormularios)()
                End If

                loGrupoFormularios = New EEGrupoFormularios()

                loGrupoFormularios.GrfId = Convert.ToInt32(dr("GrfId").ToString())
                loGrupoFormularios.GrfNombre = dr("GrfNombre").ToString()

                cmd = db.GetStoredProcCommand("Mostrar_MenuFormularios_XGrfId_EnUsuarios_pa")
                db.AddInParameter(cmd, "@grfid", DbType.Int16, loGrupoFormularios.GrfId)

                drMenuFormularios = db.ExecuteReader(cmd)
                While drMenuFormularios.Read()
                    If loGrupoFormularios.ListaMenuFormularios Is Nothing Then
                        loGrupoFormularios.ListaMenuFormularios = New List(Of EEMenuFormularios)()
                    End If

                    loMenuFormularios = New EEMenuFormularios()

                    loMenuFormularios.MfrId = Convert.ToInt16(drMenuFormularios("MfrId").ToString())
                    loMenuFormularios.MfrTitulo = drMenuFormularios("MfrTitulo").ToString()
                    loMenuFormularios.MfrNombre = drMenuFormularios("MfrNombre").ToString()

                    loGrupoFormularios.ListaMenuFormularios.Add(loMenuFormularios)
                End While
                drMenuFormularios.Close()

                ListaGrupoFormularios.Add(loGrupoFormularios)
            End While
        Catch ex As Exception
            Throw New Exception("Listar All En Formularios => " & ex.Message, ex)
        End Try
        Return ListaGrupoFormularios
    End Function
#End Region

#Region "Listar Criterio Grupo En MenuFormularios"
    ''' <summary>
    ''' LISTA TODOS LOS FORMULARIOS CON SU RESPECTIVO GRUPO EN MENUFORMULARIOS
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function listarCriterio_EnMenuFomulario(ByVal aiTipoCriterio As Int32, ByVal asCriterio As String) As List(Of EEGrupoFormularios)
        Dim ListaGrupoFormularios As List(Of EEGrupoFormularios) = Nothing
        Dim loGrupoFormularios As EEGrupoFormularios = Nothing
        Dim loMenuFormularios As EEMenuFormularios = Nothing
        Dim dr As IDataReader = Nothing
        Dim drMenuFormularios As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_GrupoFormularios_Criterio_EnMenuFormularios_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaGrupoFormularios Is Nothing Then
                    ListaGrupoFormularios = New List(Of EEGrupoFormularios)()
                End If

                loGrupoFormularios = New EEGrupoFormularios()

                loGrupoFormularios.GrfId = Convert.ToInt32(dr("GrfId").ToString())
                loGrupoFormularios.GrfNombre = dr("GrfNombre").ToString()

                cmd = db.GetStoredProcCommand("Mostrar_MenuFormularios_XGrfId_EnMenuFormularios_pa")
                db.AddInParameter(cmd, "@grfid", DbType.Int16, loGrupoFormularios.GrfId)

                drMenuFormularios = db.ExecuteReader(cmd)
                While drMenuFormularios.Read()
                    If loGrupoFormularios.ListaMenuFormularios Is Nothing Then
                        loGrupoFormularios.ListaMenuFormularios = New List(Of EEMenuFormularios)()
                    End If

                    loMenuFormularios = New EEMenuFormularios()

                    loMenuFormularios.MfrId = Convert.ToInt16(drMenuFormularios("MfrId").ToString())
                    loMenuFormularios.MfrNombre = drMenuFormularios("MfrNombre").ToString()
                    loMenuFormularios.MfrTitulo = drMenuFormularios("MfrTitulo").ToString()
                    loMenuFormularios.MfrDescripcion = drMenuFormularios("MfrDescripcion").ToString()
                    loMenuFormularios.MfrTag = drMenuFormularios("MfrTag").ToString()

                    loGrupoFormularios.ListaMenuFormularios.Add(loMenuFormularios)
                End While
                drMenuFormularios.Close()

                ListaGrupoFormularios.Add(loGrupoFormularios)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Criterio En MenuFormularios => " & ex.Message, ex)
        End Try
        Return ListaGrupoFormularios
    End Function
#End Region
End Class
