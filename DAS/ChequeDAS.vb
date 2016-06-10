Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ChequeDAS

    'Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEOrdenServicio)
    '    Dim ListaOrdenServicio As List(Of EEOrdenServicio) = Nothing
    '    Dim loOrdenServicio As EEOrdenServicio = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenServicio_Criterio_pa")
    '        db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
    '        db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

    '        dr = db.ExecuteReader(cmd)
    '        While dr.Read()
    '            If ListaOrdenServicio Is Nothing Then
    '                ListaOrdenServicio = New List(Of EEOrdenServicio)()
    '            End If

    '            loOrdenServicio = New EEOrdenServicio()

    '            loOrdenServicio.OrdId = dr("OrdId").ToString()
    '            loOrdenServicio.OrdNro = dr("OrdNro").ToString()
    '            loOrdenServicio.OrdFechaDoc = IIf(IsDBNull(dr("OrdFechaDoc")), Nothing, dr("OrdFechaDoc"))
    '            loOrdenServicio.TgEstadoId = dr("TgEstadoId").ToString()
    '            loOrdenServicio.TgCompPagoId = dr("TgCompPagoId").ToString()
    '            loOrdenServicio.OrdNroCompPago = dr("OrdNroCompPago").ToString()
    '            loOrdenServicio.PerProvId = dr("PerProvId").ToString()
    '            loOrdenServicio.PerProv = dr("PerProv").ToString()
    '            loOrdenServicio.OrdRefCert = dr("OrdRefCert").ToString()
    '            loOrdenServicio.OrdRefDoc = dr("OrdRefDoc").ToString()

    '            loOrdenServicio.PlanCDDescripcion = dr("planCDDescripcion").ToString()
    '            loOrdenServicio.TgCuentaDebeId = dr("TgCuentaDebeId").ToString()
    '            loOrdenServicio.TgCuentaDebe = Convert.ToDecimal(dr("TgCuentaDebe").ToString())

    '            loOrdenServicio.PlanCHDescripcion = dr("planCHDescripcion").ToString()
    '            loOrdenServicio.TgCuentaHaberId = dr("TgCuentaHaberId").ToString()
    '            loOrdenServicio.TgCuentaHaber = Convert.ToDecimal(dr("TgCuentaHaber").ToString())

    '            loOrdenServicio.PartId = dr("PartId").ToString()
    '            loOrdenServicio.PartNombre = dr("PartNombre").ToString()
    '            loOrdenServicio.PartAnio = dr("PartAño").ToString()
    '            loOrdenServicio.TgFFinancieraId = dr("TgFFinancieraId").ToString()
    '            loOrdenServicio.TgMetaId = dr("TgMetaId").ToString()
    '            loOrdenServicio.TgActProyId = dr("TgActProyId").ToString()
    '            loOrdenServicio.OrdImporte = Convert.ToDecimal(dr("OrdImporte").ToString())

    '            ListaOrdenServicio.Add(loOrdenServicio)
    '        End While
    '    Catch ex As Exception
    '        Throw New Exception("Listar OrdenServicio Criterio => " & ex.Message, ex)
    '    End Try
    '    Return ListaOrdenServicio
    'End Function

    'Public Shared Function listarDetalleXOrdId(ByVal asOrdId As [String]) As List(Of EEOrdenServicio.EEOrdenServicioDet)
    '    Dim ListaOrdenServicioDet As List(Of EEOrdenServicio.EEOrdenServicioDet) = Nothing
    '    Dim loOrdenServicioDet As EEOrdenServicio.EEOrdenServicioDet = Nothing
    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_OrdenServicio_XordId_pa")
    '        db.AddInParameter(cmd, "ordId", DbType.String, asOrdId)

    '        dr = db.ExecuteReader(cmd)
    '        While dr.Read()
    '            If ListaOrdenServicioDet Is Nothing Then
    '                ListaOrdenServicioDet = New List(Of EEOrdenServicio.EEOrdenServicioDet)()
    '            End If

    '            loOrdenServicioDet = New EEOrdenServicio.EEOrdenServicioDet()

    '            loOrdenServicioDet.OrdDetId = dr("ordDetId").ToString()
    '            loOrdenServicioDet.OrdId = dr("ordId").ToString()
    '            loOrdenServicioDet.TgCatServId = dr("tgCatServId").ToString()
    '            loOrdenServicioDet.TgCatServ = dr("tgCatServ").ToString()
    '            loOrdenServicioDet.OrdDetDescripcion = dr("ordDetDescripcion").ToString()
    '            loOrdenServicioDet.ordDetObservacion = dr("ordDetObservacion").ToString()
    '            loOrdenServicioDet.OrdDetPrecio = dr("ordDetPrecio").ToString()
    '            loOrdenServicioDet.ordDetIgv = dr("ordDetIgv").ToString()
    '            loOrdenServicioDet.ordDetRta4ta = dr("ordDetRta4ta").ToString()
    '            loOrdenServicioDet.tgTipoAjusteId = dr("tgTipoAjusteId").ToString()
    '            loOrdenServicioDet.tgTipoAjuste = dr("tgTipoAjuste").ToString()
    '            loOrdenServicioDet.ordDetAjuste = dr("ordDetAjuste").ToString()
    '            ListaOrdenServicioDet.Add(loOrdenServicioDet)
    '        End While
    '    Catch ex As Exception
    '        Throw New Exception("Listar OrdenServicioDet XOrdId Criterio => " & ex.Message, ex)
    '    End Try
    '    Return ListaOrdenServicioDet
    'End Function

    Public Shared Function generaCodigo() As String
        Dim CajIngId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_CajaChicaIngreso_CajIngId")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                CajIngId = dr("cajIngId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Genera Id Caja Chica Ingreso => " + ex.Message, ex)
        End Try
        Return CajIngId
    End Function
End Class
