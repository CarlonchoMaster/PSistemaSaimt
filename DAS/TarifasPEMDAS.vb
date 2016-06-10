Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class TarifasPEMDAS
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETarifasPEM)
        Dim ListaTarifasPEM As List(Of EETarifasPEM) = Nothing
        Dim loTarifasPEM As EETarifasPEM = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TarifasPEM_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTarifasPEM Is Nothing Then
                    ListaTarifasPEM = New List(Of EETarifasPEM)()
                End If

                loTarifasPEM = New EETarifasPEM()

                loTarifasPEM.TarfId = dr("TarfId").ToString()
                loTarifasPEM.ConId = dr("ConId").ToString()
                loTarifasPEM.ConNombre = dr("ConNombre").ToString()
                loTarifasPEM.TarfIni = Convert.ToDateTime(dr("TarfIni").ToString())
                loTarifasPEM.TarfFin = Convert.ToDateTime(dr("TarfFin").ToString())
                loTarifasPEM.tgTipoVehId = dr("TgTipoVehId").ToString()
                loTarifasPEM.TgTipoClienteId = dr("TgTipoClienteId").ToString()
                loTarifasPEM.tgInstitucionId = dr("TgInstitucionId").ToString()
                loTarifasPEM.tgSedeId = dr("TgSedeId").ToString()
                loTarifasPEM.TarfNroDias = dr("TarfNroDias").ToString()
                loTarifasPEM.TarfNroHoras = dr("TarfNroHoras").ToString()
                loTarifasPEM.TarfActivo = Convert.ToBoolean(dr("TarfActivo").ToString())
                loTarifasPEM.AcuPrecio = IIf(IsDBNull(dr("AcuPrecio").ToString()), 0, Convert.ToDecimal(dr("AcuPrecio").ToString()))
                ListaTarifasPEM.Add(loTarifasPEM)
            End While
        Catch ex As Exception
            Throw New Exception("Listar TarifasPEM Criterio => " + ex.Message, ex)
        End Try
        Return ListaTarifasPEM
    End Function

    'Public Shared Function listarALL() As List(Of EETarifasPEM)
    '    Dim ListaTarifasPEM As List(Of EETarifasPEM) = Nothing
    '    Dim loTarifasPEM As EETarifasPEM = Nothing
    '    Dim loTipoVehiculo As EETablaGeneral = Nothing

    '    Dim dr As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase()
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TarifasPEM_ALL_pa")

    '        dr = db.ExecuteReader(cmd)
    '        While dr.Read()
    '            If ListaTarifasPEM Is Nothing Then
    '                ListaTarifasPEM = New List(Of EETarifasPEM)()
    '            End If

    '            loTarifasPEM = New EETarifasPEM()
    '            loTipoVehiculo = New EETablaGeneral()


    '            loTarifasPEM.TarfId = dr("TarfId").ToString()
    '            loTarifasPEM.ConId = dr("ConId").ToString()
    '            loTarifasPEM.ConNombre = dr("ConNombre").ToString()
    '            loTarifasPEM.TarfIni = Convert.ToDateTime(dr("TarfIni").ToString())
    '            loTarifasPEM.tarfFin = Convert.ToDateTime(dr("TarfFin").ToString())
    '            loTipoVehiculo.TgNombre = dr("TgTipoVehId").ToString()
    '            loTarifasPEM.tgInstitucionId = dr("TgInstitucionId").ToString()
    '            loTarifasPEM.tgSedeId = dr("TgSedeId").ToString()
    '            loTipoVehiculo.TgCodigo = dr("TgTipoVeh").ToString()
    '            loTarifasPEM.tgTipoVeh = loTipoVehiculo
    '            ListaTarifasPEM.Add(loTarifasPEM)
    '        End While
    '    Catch ex As Exception
    '        Throw New Exception("Listar ALL TarifasPEM => " & ex.Message, ex)
    '    End Try
    '    Return ListaTarifasPEM
    'End Function

    Public Shared Function listarxTarfId(ByVal TarfId As [String]) As EETarifasPEM
        Dim loTarifasPEM As EETarifasPEM = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TarifasPEM_TarfId_pa")
            db.AddInParameter(cmd, "TarfId", DbType.String, TarfId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()

                loTarifasPEM = New EETarifasPEM()
                loTarifasPEM.TarfId = dr("TarfId").ToString()
                loTarifasPEM.ConId = dr("ConId").ToString()
                loTarifasPEM.tarfIni = Convert.ToDateTime(dr("TarfIni").ToString())
                loTarifasPEM.tarfFin = Convert.ToDateTime(dr("TarfFin").ToString())
                loTarifasPEM.tgTipoVehId = dr("TgTipoVehId").ToString()
                loTarifasPEM.TgTipoClienteId = dr("TgTipoClienteId").ToString()
                loTarifasPEM.tgInstitucionId = dr("TgInstitucionId").ToString()
                loTarifasPEM.tgSedeId = dr("TgSedeId").ToString()
                loTarifasPEM.TarfNroDias = dr("TarfNroDias").ToString()
                loTarifasPEM.TarfNroHoras = dr("TarfNroHoras").ToString()
                loTarifasPEM.TarfActivo = Convert.ToBoolean(dr("TarfActivo").ToString())
                loTarifasPEM.AcuPrecio = IIf(IsDBNull(dr("AcuPrecio").ToString()), 0, Convert.ToDecimal(dr("AcuPrecio").ToString()))
            End While
        Catch ex As Exception
            Throw New Exception("Listar TarifasPEM TarfID => " + ex.Message, ex)
        End Try
        Return loTarifasPEM
    End Function


    Public Shared Function GeneraCodigo() As String
        Dim dr As IDataReader = Nothing
        Dim codigo As String = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_TarifaPEM")

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                codigo = dr("tarfId").ToString()
            End If

        Catch ex As Exception
            Throw New Exception("Genera codigo => " & ex.Message, ex)
        End Try
        Return codigo
    End Function
End Class
