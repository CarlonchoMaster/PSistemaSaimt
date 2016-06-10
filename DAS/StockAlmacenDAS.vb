Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class StockAlmacenDAS
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEStockAlmacen)
        Dim ListaStockAlmacen As List(Of EEStockAlmacen) = Nothing
        Dim loStockAlmacen As EEStockAlmacen = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_StockAlmacen_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaStockAlmacen Is Nothing Then
                    ListaStockAlmacen = New List(Of EEStockAlmacen)()
                End If

                loStockAlmacen = New EEStockAlmacen()

                loStockAlmacen.OrdId = dr("OrdId").ToString()
                loStockAlmacen.OrdNro = dr("OrdNro").ToString()
                loStockAlmacen.OrdFechaDoc = IIf(IsDBNull(dr("OrdFechaDoc")), Nothing, dr("OrdFechaDoc"))
                loStockAlmacen.TgAreaId = dr("TgAreaId").ToString()
                ListaStockAlmacen.Add(loStockAlmacen)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Stock Almacen Criterio => " & ex.Message, ex)
        End Try
        Return ListaStockAlmacen
    End Function

    'Public Shared Function listarDetalleXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraDet)
    '    Dim ListaOrdenCompraDet As List(Of EEOrdenCompra.EEOrdenCompraDet) = Nothing
    '    Dim loOrdenCompraDet As EEOrdenCompra.EEOrdenCompraDet = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenCompra_XordId_pa")
    '        db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

    '        dr = db.ExecuteReader(cmd)
    '        While dr.Read()
    '            If ListaOrdenCompraDet Is Nothing Then
    '                ListaOrdenCompraDet = New List(Of EEOrdenCompra.EEOrdenCompraDet)()
    '            End If

    '            loOrdenCompraDet = New EEOrdenCompra.EEOrdenCompraDet()

    '            loOrdenCompraDet.OrdDetId = dr("ordDetId").ToString()
    '            loOrdenCompraDet.OArticulo = New EEArticulo
    '            loOrdenCompraDet.OArticulo.ArtId = dr("artId").ToString()
    '            loOrdenCompraDet.OArticulo.ArtDescripcion = dr("ArtDescripcion").ToString()
    '            loOrdenCompraDet.TgUmId = dr("tgUmId").ToString()
    '            loOrdenCompraDet.TgUm = dr("tgNombre").ToString()
    '            loOrdenCompraDet.OrdDetCantidad = dr("OrdDetCantidad").ToString()
    '            loOrdenCompraDet.OrdDetPrecio = dr("OrdDetPrecio").ToString()

    '            ListaOrdenCompraDet.Add(loOrdenCompraDet)
    '        End While
    '    Catch ex As Exception
    '        Throw New Exception("Listar OrdenCompraDet XOrdId Criterio => " & ex.Message, ex)
    '    End Try
    '    Return ListaOrdenCompraDet
    'End Function

    'Public Shared Function generaCodigo() As String
    '    Dim artId As String = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase()
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_OrdenCompra_OrdId")
    '        dr = db.ExecuteReader(cmd)
    '        If dr.Read() Then
    '            artId = dr("ordId").ToString()
    '        End If
    '        dr.Close()
    '    Catch ex As Exception
    '        Throw New Exception("Genera Id Orden Compra => " + ex.Message, ex)
    '    End Try
    '    Return artId
    'End Function

    'Public Shared Function generaCodigoSAIMT() As String
    '    Dim servCodigo As String = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase()
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_OrdenCompra_OrdNro")
    '        dr = db.ExecuteReader(cmd)
    '        If dr.Read() Then
    '            servCodigo = dr("ordNro").ToString()
    '        End If
    '        dr.Close()
    '    Catch ex As Exception
    '        Throw New Exception("Genera Codigo Orden Compra => " + ex.Message, ex)
    '    End Try
    '    Return servCodigo
    'End Function
End Class
