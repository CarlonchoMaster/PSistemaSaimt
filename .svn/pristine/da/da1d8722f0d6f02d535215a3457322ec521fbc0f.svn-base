Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ComprobantePagoDAS
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEComprobantePago)
        Dim ListaComprobantePago As List(Of EEComprobantePago) = Nothing
        Dim loComprobantePago As EEComprobantePago = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ComprobantePago_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaComprobantePago Is Nothing Then
                    ListaComprobantePago = New List(Of EEComprobantePago)()
                End If

                loComprobantePago = New EEComprobantePago()

                'loComprobantePago.OrdId = dr("OrdId").ToString()
                'loComprobantePago.OrdNro = dr("OrdNro").ToString()
                'loComprobantePago.OrdFechaDoc = IIf(IsDBNull(dr("OrdFechaDoc")), Nothing, dr("OrdFechaDoc"))
                'loComprobantePago.TgEstadoId = dr("TgEstadoId").ToString()
                'loComprobantePago.TgCompPagoId = dr("TgCompPagoId").ToString()
                'loComprobantePago.OrdNroCompPago = dr("OrdNroCompPago").ToString()
                'loComprobantePago.PerProvId = dr("PerProvId").ToString()
                'loComprobantePago.PerProv = dr("PerProv").ToString()
                'loComprobantePago.OrdRefCert = dr("OrdRefCert").ToString()
                'loComprobantePago.OrdRefDoc = dr("OrdRefDoc").ToString()

                'loComprobantePago.PlanCDDescripcion = dr("planCDDescripcion").ToString()
                'loComprobantePago.TgCuentaDebeId = dr("TgCuentaDebeId").ToString()
                'loComprobantePago.TgCuentaDebe = Convert.ToDecimal(dr("TgCuentaDebe").ToString())

                'loComprobantePago.PlanCHDescripcion = dr("planCHDescripcion").ToString()
                'loComprobantePago.TgCuentaHaberId = dr("TgCuentaHaberId").ToString()
                'loComprobantePago.TgCuentaHaber = Convert.ToDecimal(dr("TgCuentaHaber").ToString())

                'loComprobantePago.PartId = dr("PartId").ToString()
                'loComprobantePago.PartNombre = dr("PartNombre").ToString()
                'loComprobantePago.PartAnio = dr("PartAño").ToString()
                'loComprobantePago.TgFFinancieraId = dr("TgFFinancieraId").ToString()
                'loComprobantePago.TgMetaId = dr("TgMetaId").ToString()
                'loComprobantePago.TgActProyId = dr("TgActProyId").ToString()
                'loComprobantePago.OrdImporte = Convert.ToDecimal(dr("OrdImporte").ToString())

                ListaComprobantePago.Add(loComprobantePago)
            End While
        Catch ex As Exception
            Throw New Exception("Listar OrdenCompra Criterio => " & ex.Message, ex)
        End Try
        Return ListaComprobantePago
    End Function

    Public Shared Function generaCodigo() As String
        Dim comPagId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_ComprobantePago_ComPagId")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                comPagId = dr("comPagId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Id Comprobante Pago => " + ex.Message, ex)
        End Try
        Return comPagId
    End Function

    Public Shared Function generaCodigo(ByVal asCriterio As [String]) As String
        Dim comPagCodigo As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_ComprobantePago_ComPagNro")
            db.AddInParameter(cmd, "tgBancoId", DbType.String, asCriterio)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                comPagCodigo = dr("comPagNro").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Codigo Comprobante de Pago => " + ex.Message, ex)
        End Try
        Return comPagCodigo
    End Function
End Class
