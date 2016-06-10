Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class OrdenCompraDAS
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal asAnio As Integer) As List(Of EEOrdenCompra)
        Dim ListaOrdenCompra As List(Of EEOrdenCompra) = Nothing
        Dim loOrdenCompra As EEOrdenCompra = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenCompra_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            db.AddInParameter(cmd, "anio", DbType.Int32, asAnio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenCompra Is Nothing Then
                    ListaOrdenCompra = New List(Of EEOrdenCompra)()
                End If

                loOrdenCompra = New EEOrdenCompra()

                loOrdenCompra.OrdId = dr("OrdId").ToString()
                loOrdenCompra.OrdNro = dr("OrdNro").ToString()
                loOrdenCompra.OrdFechaDoc = IIf(IsDBNull(dr("OrdFechaDoc")), Nothing, dr("OrdFechaDoc"))
                loOrdenCompra.TgEstado = dr("TgEstado").ToString()
                ListaOrdenCompra.Add(loOrdenCompra)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompra Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenCompra
    End Function

    Public Shared Function ListarxOrdId(ByVal ordId As [String]) As EEOrdenCompra
        Dim loOrdenCompra As EEOrdenCompra = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenCompra_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, ordId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loOrdenCompra = New EEOrdenCompra()
                loOrdenCompra.OrdId = dr("OrdId").ToString()
                loOrdenCompra.OrdNro = dr("OrdNro").ToString()
                loOrdenCompra.OrdFechaDoc = IIf(IsDBNull(dr("OrdFechaDoc")), Nothing, dr("OrdFechaDoc"))
                loOrdenCompra.TgEstadoId = dr("TgEstadoId").ToString()
                loOrdenCompra.TgCompPagoId = dr("TgCompPagoId").ToString()
                loOrdenCompra.OrdNroCompPago = dr("OrdNroCompPago").ToString()
                loOrdenCompra.PerProvId = dr("PerProvId").ToString()
                loOrdenCompra.PerProv = dr("PerProv").ToString()
                loOrdenCompra.OrdRefDoc = dr("OrdRefDoc").ToString()
                loOrdenCompra.PlanCDDescripcion = dr("planCDDescripcion").ToString()
                loOrdenCompra.TgCuentaDebeId = dr("TgCuentaDebeId").ToString()
                loOrdenCompra.PlanCHDescripcion = dr("planCHDescripcion").ToString()
                loOrdenCompra.TgCuentaHaberId = dr("TgCuentaHaberId").ToString()
                loOrdenCompra.CerId = dr("cerId").ToString()
                loOrdenCompra.CerNro = dr("cerNro").ToString()
                loOrdenCompra.PartId = dr("PartId").ToString()
                loOrdenCompra.PartNombre = dr("PartNombre").ToString()
                loOrdenCompra.TgFFinancieraId = dr("TgFFinancieraId").ToString()
                loOrdenCompra.TgMetaId = dr("TgMetaId").ToString()
                loOrdenCompra.TgActProyId = dr("TgActProyId").ToString()
                If IsDBNull(dr("TgCuentaDebe")) = False Then
                    loOrdenCompra.TgCuentaDebe = Convert.ToDecimal(dr("TgCuentaDebe").ToString())
                End If
                If IsDBNull(dr("TgCuentaHaber")) = False Then
                    loOrdenCompra.TgCuentaHaber = Convert.ToDecimal(dr("TgCuentaHaber").ToString())
                End If
                If IsDBNull(dr("cerValTotal")) = False Then
                    loOrdenCompra.CerValTotal = Convert.ToDecimal(dr("cerValTotal").ToString())
                End If
                If IsDBNull(dr("cerValQuedan")) = False Then
                    loOrdenCompra.CerValQuedan = Convert.ToDecimal(dr("cerValQuedan").ToString)
                End If
                If IsDBNull(dr("OrdImporte")) = False Then
                    loOrdenCompra.OrdImporte = Convert.ToDecimal(dr("OrdImporte").ToString())
                End If
                If IsDBNull(dr("OrdSubTotal")) = False Then
                    loOrdenCompra.OrdSubTotal = Convert.ToDecimal(dr("OrdSubTotal").ToString())
                End If
                If IsDBNull(dr("OrdImporteIGV")) = False Then
                    loOrdenCompra.OrdImporteIGV = Convert.ToDecimal(dr("OrdImporteIGV").ToString())
                End If
                If IsDBNull(dr("ordDescuento")) = False Then
                    loOrdenCompra.OrdDescuento = Convert.ToDecimal(dr("ordDescuento").ToString())
                End If
                If IsDBNull(dr("OrdTotal")) = False Then
                    loOrdenCompra.OrdTotal = Convert.ToDecimal(dr("OrdTotal").ToString())
                End If
                If IsDBNull(dr("OrdSaldoI")) = False Then
                    loOrdenCompra.OrdSaldoI = Convert.ToDecimal(dr("OrdSaldoI").ToString())
                End If
                If IsDBNull(dr("OrdSaldoF")) = False Then
                    loOrdenCompra.OrdSaldoF = Convert.ToDecimal(dr("OrdSaldoF").ToString())
                End If
            End If
        Catch ex As Exception
            Throw New Exception("Listar OrdenServicio x ordId => " & ex.Message, ex)
        End Try
        Return loOrdenCompra
    End Function

    Public Shared Function listarDetalleXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraDet)
        Dim ListaOrdenCompraDet As List(Of EEOrdenCompra.EEOrdenCompraDet) = Nothing
        Dim loOrdenCompraDet As EEOrdenCompra.EEOrdenCompraDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenCompraDet_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenCompraDet Is Nothing Then
                    ListaOrdenCompraDet = New List(Of EEOrdenCompra.EEOrdenCompraDet)()
                End If

                loOrdenCompraDet = New EEOrdenCompra.EEOrdenCompraDet()

                loOrdenCompraDet.OrdDetId = dr("ordDetId").ToString()
                loOrdenCompraDet.OArticulo = New EEArticulo
                loOrdenCompraDet.OArticulo.ArtId = dr("artId").ToString()
                loOrdenCompraDet.OArticulo.ArtDescripcion = dr("ArtDescripcion").ToString()
                loOrdenCompraDet.OrdDetDescripcion = dr("OrdDetDescripcion").ToString()
                loOrdenCompraDet.OrdDetEncabezado = dr("OrdDetEncabezado").ToString()
                loOrdenCompraDet.TgUmId = dr("tgUmId").ToString()
                loOrdenCompraDet.TgUm = dr("tgNombre").ToString()
                loOrdenCompraDet.OrdDetCantidad = dr("OrdDetCantidad").ToString()
                loOrdenCompraDet.OrdDetCQuedan = dr("OrdDetCQuedan").ToString()
                loOrdenCompraDet.OrdDetPrecio = dr("OrdDetPrecio").ToString()
                ListaOrdenCompraDet.Add(loOrdenCompraDet)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompraDet XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenCompraDet
    End Function
    Public Shared Function listarAreaRefXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraAreaRef)
        Dim ListaOrdenCompraAreaRef As List(Of EEOrdenCompra.EEOrdenCompraAreaRef) = Nothing
        Dim loOrdenCompraAreaRef As EEOrdenCompra.EEOrdenCompraAreaRef = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenCompraAreasRef_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenCompraAreaRef Is Nothing Then
                    ListaOrdenCompraAreaRef = New List(Of EEOrdenCompra.EEOrdenCompraAreaRef)()
                End If
                loOrdenCompraAreaRef = New EEOrdenCompra.EEOrdenCompraAreaRef()
                loOrdenCompraAreaRef.tgAreaId = dr("tgAreaId").ToString()
                ListaOrdenCompraAreaRef.Add(loOrdenCompraAreaRef)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompraAreaRef XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenCompraAreaRef
    End Function


    Public Shared Function listarDocRefXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraDocRef)
        Dim ListaOrdenCompraDocRef As List(Of EEOrdenCompra.EEOrdenCompraDocRef) = Nothing
        Dim loOrdenCompraDocRef As EEOrdenCompra.EEOrdenCompraDocRef = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenCompraDocRef_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenCompraDocRef Is Nothing Then
                    ListaOrdenCompraDocRef = New List(Of EEOrdenCompra.EEOrdenCompraDocRef)()
                End If
                loOrdenCompraDocRef = New EEOrdenCompra.EEOrdenCompraDocRef()
                loOrdenCompraDocRef.documento = dr("documento").ToString()
                loOrdenCompraDocRef.año = dr("año").ToString()
                loOrdenCompraDocRef.area = dr("area").ToString()
                ListaOrdenCompraDocRef.Add(loOrdenCompraDocRef)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompraDocRef XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenCompraDocRef
    End Function


    Public Shared Function listarGrupoPartidaXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraGrupoPartidas)
        Dim ListaOrdenCompraGrupoPartida As List(Of EEOrdenCompra.EEOrdenCompraGrupoPartidas) = Nothing
        Dim loOrdenCompraGrupoPartida As EEOrdenCompra.EEOrdenCompraGrupoPartidas = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenCompraGrupoPartida_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenCompraGrupoPartida Is Nothing Then
                    ListaOrdenCompraGrupoPartida = New List(Of EEOrdenCompra.EEOrdenCompraGrupoPartidas)()
                End If

                loOrdenCompraGrupoPartida = New EEOrdenCompra.EEOrdenCompraGrupoPartidas()

                loOrdenCompraGrupoPartida.cerGrupoParId = dr("cerGrupoParId").ToString()
                loOrdenCompraGrupoPartida.cerGrupoParValImporte = dr("cerGrupoParValImporte").ToString()
                loOrdenCompraGrupoPartida.Partida = dr("partNombre").ToString()

                ListaOrdenCompraGrupoPartida.Add(loOrdenCompraGrupoPartida)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompraGrupoPartida XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenCompraGrupoPartida
    End Function

    Public Shared Function listarDetalleXOrdNro_Año(ByVal asOrdNro As String, ByVal asAnio As Short) As List(Of EEOrdenCompra.EEOrdenCompraDet)
        Dim ListaOrdenCompraDet As List(Of EEOrdenCompra.EEOrdenCompraDet) = Nothing
        Dim loOrdenCompraDet As EEOrdenCompra.EEOrdenCompraDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenCompraDet_XNroPec_Año_pa")
            db.AddInParameter(cmd, "ordnro", DbType.String, asOrdNro)
            db.AddInParameter(cmd, "anio", DbType.Int16, asAnio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenCompraDet Is Nothing Then
                    ListaOrdenCompraDet = New List(Of EEOrdenCompra.EEOrdenCompraDet)()
                End If
                loOrdenCompraDet = New EEOrdenCompra.EEOrdenCompraDet()
                loOrdenCompraDet.OrdDetId = dr("ordDetId").ToString()
                loOrdenCompraDet.OArticulo = New EEArticulo
                loOrdenCompraDet.OArticulo.ArtId = dr("artId").ToString()
                loOrdenCompraDet.OArticulo.ArtDescripcion = dr("ArtDescripcion").ToString()
                loOrdenCompraDet.OrdDetDescripcion = dr("OrdDetDescripcion").ToString()
                'loOrdenCompraDet.OrdDetEncabezado = dr("OrdDetEncabezado").ToString()
                loOrdenCompraDet.TgUmId = dr("tgUmId").ToString()
                loOrdenCompraDet.TgUm = dr("tgNombre").ToString()
                loOrdenCompraDet.OrdDetCantidad = dr("OrdDetCantidad").ToString()
                loOrdenCompraDet.OrdDetCQuedan = dr("OrdDetCQuedan").ToString()
                loOrdenCompraDet.OrdDetPrecio = dr("OrdDetPrecio").ToString()
                loOrdenCompraDet.OrdId = dr("OrdId").ToString()
                ListaOrdenCompraDet.Add(loOrdenCompraDet)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompraDet XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenCompraDet
    End Function

    Public Shared Function generaCodigo() As String
        Dim artId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_OrdenCompra_OrdId")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                artId = dr("ordId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Id Orden Compra => " + ex.Message, ex)
        End Try
        Return artId
    End Function

    Public Shared Function generaCodigoSAIMT() As String
        Dim servCodigo As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_OrdenCompra_OrdNro")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                servCodigo = dr("ordNro").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Codigo Orden Compra => " + ex.Message, ex)
        End Try
        Return servCodigo
    End Function

    Public Shared Function ConsultarlistarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEOrdenCompra)
        Dim ListaOrdenCompra As List(Of EEOrdenCompra) = Nothing
        Dim loOrdenCompra As EEOrdenCompra = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ConsultarOrdenCompra_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenCompra Is Nothing Then
                    ListaOrdenCompra = New List(Of EEOrdenCompra)()
                End If

                loOrdenCompra = New EEOrdenCompra()

                loOrdenCompra.OrdId = dr("OrdId").ToString()
                loOrdenCompra.OrdNro = dr("OrdNro").ToString()
                loOrdenCompra.OrdFechaDoc = IIf(IsDBNull(dr("OrdFechaDoc")), Nothing, dr("OrdFechaDoc"))
                loOrdenCompra.OrdDetCQuedan = dr("ordDetCQuedan").ToString()
                loOrdenCompra.OrdArtDescripcion = dr("artDescripcion").ToString()

                ListaOrdenCompra.Add(loOrdenCompra)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompra Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenCompra
    End Function

    Public Shared Function ConsultarlistarDetalleXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenCompra.EEOrdenCompraDet)
        Dim ListaOrdenCompraDet As List(Of EEOrdenCompra.EEOrdenCompraDet) = Nothing
        Dim loOrdenCompraDet As EEOrdenCompra.EEOrdenCompraDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenCompra_XordId_pa")
            db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaOrdenCompraDet Is Nothing Then
                    ListaOrdenCompraDet = New List(Of EEOrdenCompra.EEOrdenCompraDet)()
                End If

                loOrdenCompraDet = New EEOrdenCompra.EEOrdenCompraDet()

                loOrdenCompraDet.OrdDetId = dr("ordDetId").ToString()
                loOrdenCompraDet.OArticulo = New EEArticulo
                loOrdenCompraDet.OArticulo.ArtId = dr("artId").ToString()
                loOrdenCompraDet.OArticulo.ArtDescripcion = dr("ArtDescripcion").ToString()
                loOrdenCompraDet.TgUmId = dr("tgUmId").ToString()
                loOrdenCompraDet.TgUm = dr("tgNombre").ToString()
                loOrdenCompraDet.OrdDetCantidad = dr("OrdDetCantidad").ToString()
                loOrdenCompraDet.OrdDetCQuedan = dr("OrdDetCQuedan").ToString()
                loOrdenCompraDet.OrdDetPrecio = dr("OrdDetPrecio").ToString()

                ListaOrdenCompraDet.Add(loOrdenCompraDet)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompraDet XOrdId Criterio => " & ex.Message, ex)
        End Try
        Return ListaOrdenCompraDet
    End Function
End Class
