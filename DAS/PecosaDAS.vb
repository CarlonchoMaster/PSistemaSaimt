Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class PecosaDAS

    Public Shared Function MostrarXpecId(ByVal pecId As [String]) As EEPecosa
        Dim loPecosa As EEPecosa = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_pecosa_XpecId_pa")
            db.AddInParameter(cmd, "pecId", DbType.String, pecId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loPecosa = New EEPecosa()
                loPecosa.PecId = dr("pecId").ToString()
                loPecosa.PecNro = dr("pecNro").ToString()
                loPecosa.TgAreaDesId = dr("tgAreaDesId").ToString()
                loPecosa.TgCarDesId = dr("tgCarDesId").ToString()
                loPecosa.PecFecha = IIf(IsDBNull(dr("pecFecha")), Nothing, dr("pecFecha"))
                loPecosa.PerSolicitaId = dr("perSolicitaId").ToString()
                loPecosa.PerSolicita = dr("perSolicita").ToString()
                loPecosa.PecObservacion = dr("pecObservacion").ToString()
                loPecosa.PlanCDDescripcion = dr("planCDDescripcion").ToString()
                loPecosa.TgCuentaDebeId = dr("tgCuentaDebeId").ToString()
                loPecosa.TgCuentaDebe = Convert.ToDecimal(dr("tgCuentaDebe").ToString())
                loPecosa.PlanCHDescripcion = dr("planCHDescripcion").ToString()
                loPecosa.TgCuentaHaberId = dr("tgCuentaHaberId").ToString()
                loPecosa.TgCuentaHaber = Convert.ToDecimal(dr("tgCuentaHaber").ToString())
                loPecosa.TgMetaId = dr("tgMetaId").ToString()
                loPecosa.TgActProyId = dr("tgActProyId").ToString()
                loPecosa.pecAnulado = dr("pecAnulado").ToString()
            End If
        Catch ex As Exception
            Throw New Exception("Mostrar Pecosa x PecId => " & ex.Message, ex)
        End Try
        Return loPecosa
    End Function
    Public Shared Function listarBCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal asAnio As Int16) As List(Of EEPecosa)
        Dim ListaPecosa As List(Of EEPecosa) = Nothing
        Dim loPecosa As EEPecosa = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Pecosa_BCriterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            db.AddInParameter(cmd, "anio", DbType.Int32, asAnio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPecosa Is Nothing Then
                    ListaPecosa = New List(Of EEPecosa)()
                End If
                loPecosa = New EEPecosa()
                loPecosa.PecId = dr("pecId").ToString()
                loPecosa.PecNro = dr("pecNro").ToString()
                loPecosa.TgAreaDes = dr("tgAreaDes").ToString()
                loPecosa.PecFecha = IIf(IsDBNull(dr("pecFecha")), Nothing, dr("pecFecha"))
                ListaPecosa.Add(loPecosa)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Salida Articulo Almacen Criterio => " & ex.Message, ex)
        End Try
        Return ListaPecosa
    End Function

    

    Public Shared Function listarDetalleXPecId(ByVal asPecId As [String]) As List(Of EEPecosa.EEPecosaDet)
        Dim ListaPecosaDet As List(Of EEPecosa.EEPecosaDet) = Nothing
        Dim loPecosaDet As EEPecosa.EEPecosaDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_PecosaDet_XpecId_pa")
            db.AddInParameter(cmd, "pecId", DbType.String, asPecId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPecosaDet Is Nothing Then
                    ListaPecosaDet = New List(Of EEPecosa.EEPecosaDet)()
                End If
                loPecosaDet = New EEPecosa.EEPecosaDet()
                loPecosaDet.PecDetId = dr("pecDetId").ToString()
                loPecosaDet.OArticulo = New EEArticulo
                loPecosaDet.OArticulo.ArtId = dr("artId").ToString()
                loPecosaDet.OArticulo.ArtDescripcion = dr("ArtDescripcion").ToString()
                loPecosaDet.TgUmId = dr("tgUmId").ToString()
                loPecosaDet.TgUm = dr("tgUm").ToString()
                loPecosaDet.PecDetCanTotal = dr("pecDetCanTotal")
                loPecosaDet.PecDetImpTotal = dr("pecDetImpTotal")
                loPecosaDet.PecDetDescripcion = dr("pecDescripcion").ToString
                loPecosaDet.OrdId = dr("ordId").ToString
                loPecosaDet.OrdDetId = dr("ordDetId")
                loPecosaDet.PecDetPrecio = dr("pecDetPrecioUnit")
                loPecosaDet.OCNro = dr("ordNro").ToString
                ListaPecosaDet.Add(loPecosaDet)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompraDet XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaPecosaDet
    End Function

    Public Shared Function listarDetalleXPecOCDetId(ByVal asPecDetId As [String], ByVal asArtId As [String]) As List(Of EEPecosa.EEPecosaOCDet)
        Dim ListaPecosaDet As List(Of EEPecosa.EEPecosaOCDet) = Nothing
        Dim loPecosaOCDet As EEPecosa.EEPecosaOCDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_PecosaOrdenCompraDet_XpecDetIdXartId_pa")
            db.AddInParameter(cmd, "pecDetId", DbType.String, asPecDetId)
            db.AddInParameter(cmd, "artId", DbType.String, asArtId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPecosaDet Is Nothing Then
                    ListaPecosaDet = New List(Of EEPecosa.EEPecosaOCDet)()
                End If
                loPecosaOCDet = New EEPecosa.EEPecosaOCDet()
                loPecosaOCDet.PecOrdComDetId = dr("pecOrdComDetId").ToString()
                loPecosaOCDet.PecDetId = dr("pecDetId").ToString()
                loPecosaOCDet.OArticulo = New EEArticulo
                loPecosaOCDet.OArticulo.ArtId = dr("artId").ToString()
                loPecosaOCDet.CanOrdComDet = dr("canOrdComDet").ToString()
                loPecosaOCDet.OrdId = dr("ordId").ToString()
                loPecosaOCDet.PrecOrdComDet = dr("precOrdComDet").ToString()
                ListaPecosaDet.Add(loPecosaOCDet)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompraDet XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaPecosaDet
    End Function

    Public Shared Function generaCodigo() As String
        Dim pecId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Pecosa_pecId")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                pecId = dr("pecId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Id Orden Compra => " + ex.Message, ex)
        End Try
        Return pecId
    End Function

    Public Shared Function generaCodigoSAIMT() As String
        Dim pecNro As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Pecosa_PecNro")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                pecNro = dr("pecNro").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Nro Pecosa => " + ex.Message, ex)
        End Try
        Return pecNro
    End Function
End Class
