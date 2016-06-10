Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ArticuloDAS
    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EEArticulo)
        Dim ListaArticulo As List(Of EEArticulo) = Nothing
        Dim loArticulo As EEArticulo = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Articulo_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaArticulo Is Nothing Then
                    ListaArticulo = New List(Of EEArticulo)()
                End If
                loArticulo = New EEArticulo()
                loArticulo.ArtId = dr("ArtId").ToString()
                ' loArticulo.ArtNombre = dr("ArtNombre").ToString()
                loArticulo.ArtDescripcion = dr("ArtDescripcion").ToString()
                loArticulo.tgArtGrupoId = dr("tgArtGrupoId").ToString()
                loArticulo.tgArtGrupo = dr("tgArtGrupo").ToString()
                loArticulo.ArtActivo = Convert.ToBoolean(dr("ArtActivo").ToString())
                loArticulo.ArtCodigo = dr("ArtCodigo").ToString()
                loArticulo.tgUMedidaId = dr("tgUMId").ToString()
                loArticulo.ArtUMinimas = dr("artUniMinimas").ToString()
                ListaArticulo.Add(loArticulo)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Articulo Criterio => " + ex.Message, ex)
        End Try
        Return ListaArticulo
    End Function
    Public Shared Function generaCodigo() As String
        Dim artId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Articulo_artId")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                artId = dr("artId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Codigo Articulo => " + ex.Message, ex)
        End Try
        Return artId
    End Function
    Public Shared Function generaCodigoSAIMT() As String
        Dim servCodigo As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_articulo_artCodigo")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                servCodigo = dr("artCodigo").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Codigo Articulo => " + ex.Message, ex)
        End Try
        Return servCodigo
    End Function

End Class
