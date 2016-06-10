Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class AcuerdoPEMDAS
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEAcuerdoPEM)
        Dim ListaAcuerdoPEM As List(Of EEAcuerdoPEM) = Nothing

        Dim loAcuerdoPEM As EEAcuerdoPEM = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_AcuerdoPEM_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaAcuerdoPEM Is Nothing Then
                    ListaAcuerdoPEM = New List(Of EEAcuerdoPEM)()
                End If

                loAcuerdoPEM = New EEAcuerdoPEM()


                loAcuerdoPEM.AcuId = dr("AcuId").ToString()
                loAcuerdoPEM.tgInstitucionId = dr("TgInstitucionId").ToString()
                loAcuerdoPEM.tgSedeId = dr("TgSedeId").ToString()
                loAcuerdoPEM.NivId = dr("NivId").ToString()
                loAcuerdoPEM.TarfId = dr("TarfId").ToString()
                loAcuerdoPEM.AcuPrecio = Convert.ToDecimal(dr("AcuPrecio").ToString())
                loAcuerdoPEM.AcuFechaReg = IIf(IsDBNull(dr("AcuFechaReg")), Nothing, dr("AcuFechaReg"))
                loAcuerdoPEM.AcuFechaIni = IIf(IsDBNull(dr("AcuFechaIni")), Nothing, dr("AcuFechaIni"))
                loAcuerdoPEM.AcuFechaFin = IIf(IsDBNull(dr("AcuFechaFin")), Nothing, dr("AcuFechaFin"))
                loAcuerdoPEM.AcuEstado = dr("AcuEstado").ToString()
                loAcuerdoPEM.PerId = dr("PerId").ToString()
                loAcuerdoPEM.TgTipoVehId = dr("TgTipoVehId").ToString()
                loAcuerdoPEM.tgTipoVeh = dr("TgTipoVeh").ToString()
                loAcuerdoPEM.AcuNPlaca1 = dr("AcuNPlaca1").ToString()
                loAcuerdoPEM.AcuNPlaca2 = dr("AcuNPlaca2").ToString()
                loAcuerdoPEM.AcuNPlaca3 = dr("AcuNPlaca3").ToString()
                loAcuerdoPEM.AcuHoIni = Convert.ToDateTime(dr("AcuHoIni").ToString())
                loAcuerdoPEM.AcuHoFin = Convert.ToDateTime(dr("AcuHoFin").ToString())
                loAcuerdoPEM.AcuNEspacio = Convert.ToInt32(dr("AcuNEspacio").ToString())
                loAcuerdoPEM.Persona = dr("Persona").ToString()
                loAcuerdoPEM.AcuDatos = dr("AcuId").ToString() & " - " & IIf(IsDBNull(dr("AcuFechaIni")), Nothing, dr("AcuFechaIni")) & " | " & IIf(IsDBNull(dr("AcuFechaFin")), Nothing, dr("AcuFechaFin"))

                ListaAcuerdoPEM.Add(loAcuerdoPEM)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar AcuerdoPEM Criterio => " + ex.Message, ex)
        End Try
        Return ListaAcuerdoPEM
    End Function

    Public Shared Function listarALL() As List(Of EEAcuerdoPEM)
        Dim ListaAcuerdoPEM As List(Of EEAcuerdoPEM) = Nothing
        Dim loAcuerdoPEM As EEAcuerdoPEM = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_AcuerdoPEM_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaAcuerdoPEM Is Nothing Then
                    ListaAcuerdoPEM = New List(Of EEAcuerdoPEM)()
                End If

                loAcuerdoPEM = New EEAcuerdoPEM()

                loAcuerdoPEM.AcuId = dr("AcuId").ToString()
                loAcuerdoPEM.tgInstitucionId = dr("TgInstitucionId").ToString()
                loAcuerdoPEM.tgSedeId = dr("TgSedeId").ToString()
                loAcuerdoPEM.NivId = dr("NivId").ToString()
                loAcuerdoPEM.TarfId = dr("TarfId").ToString()
                loAcuerdoPEM.AcuPrecio = Convert.ToDecimal(dr("AcuPrecio").ToString())
                loAcuerdoPEM.AcuFechaReg = IIf(IsDBNull(dr("AcuFechaReg")), Nothing, dr("AcuFechaReg"))
                loAcuerdoPEM.AcuFechaIni = IIf(IsDBNull(dr("AcuFechaIni")), Nothing, dr("AcuFechaIni"))
                loAcuerdoPEM.AcuFechaFin = IIf(IsDBNull(dr("AcuFechaFin")), Nothing, dr("AcuFechaFin"))
                loAcuerdoPEM.AcuEstado = dr("AcuEstado").ToString()
                loAcuerdoPEM.PerId = dr("PerId").ToString()
                loAcuerdoPEM.TgTipoVehId = dr("TgTipoVehId").ToString()
                loAcuerdoPEM.AcuNPlaca1 = dr("AcuNPlaca1").ToString()
                loAcuerdoPEM.AcuNPlaca2 = dr("AcuNPlaca2").ToString()
                loAcuerdoPEM.AcuNPlaca3 = dr("AcuNPlaca3").ToString()
                loAcuerdoPEM.AcuHoIni = Convert.ToDateTime(dr("AcuHoIni").ToString())
                loAcuerdoPEM.AcuHoFin = Convert.ToDateTime(dr("AcuHoFin").ToString())
                loAcuerdoPEM.AcuNEspacio = Convert.ToInt32(dr("AcuNEspacio").ToString())


                ListaAcuerdoPEM.Add(loAcuerdoPEM)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ALL AcuerdoPEM => " & ex.Message, ex)
        End Try
        Return ListaAcuerdoPEM
    End Function

    Public Shared Function listarxAcuId(ByVal AcuId As [String]) As EEAcuerdoPEM
        Dim loAcuerdoPEM As EEAcuerdoPEM = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_AcuerdoPEM_AcuId_pa")
            db.AddInParameter(cmd, "AcuId", DbType.String, AcuId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()

                loAcuerdoPEM = New EEAcuerdoPEM()
                loAcuerdoPEM.AcuId = dr("AcuId").ToString()
                loAcuerdoPEM.tgInstitucionId = dr("TgInstitucionId").ToString()
                loAcuerdoPEM.tgSedeId = dr("TgSedeId").ToString()
                loAcuerdoPEM.NivId = dr("NivId").ToString()
                loAcuerdoPEM.TarfId = dr("TarfId").ToString()
                loAcuerdoPEM.AcuPrecio = Convert.ToDecimal(dr("AcuPrecio").ToString())
                loAcuerdoPEM.AcuFechaReg = IIf(IsDBNull(dr("AcuFechaReg")), Nothing, dr("AcuFechaReg"))
                loAcuerdoPEM.AcuFechaIni = IIf(IsDBNull(dr("AcuFechaIni")), Nothing, dr("AcuFechaIni"))
                loAcuerdoPEM.AcuFechaFin = IIf(IsDBNull(dr("AcuFechaFin")), Nothing, dr("AcuFechaFin"))
                loAcuerdoPEM.AcuEstado = dr("AcuEstado").ToString()
                loAcuerdoPEM.PerId = dr("perId").ToString()
                loAcuerdoPEM.Persona = dr("Persona").ToString()
                loAcuerdoPEM.TgTipoVehId = dr("TgTipoVehId").ToString()
                loAcuerdoPEM.AcuNPlaca1 = dr("AcuNPlaca1").ToString()
                loAcuerdoPEM.AcuNPlaca2 = dr("AcuNPlaca2").ToString()
                loAcuerdoPEM.AcuNPlaca3 = dr("AcuNPlaca3").ToString()
                loAcuerdoPEM.AcuHoIni = Convert.ToDateTime(dr("AcuHoIni").ToString())
                loAcuerdoPEM.AcuHoFin = Convert.ToDateTime(dr("AcuHoFin").ToString())
                loAcuerdoPEM.AcuNEspacio = Convert.ToInt32(dr("AcuNEspacio").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar AcuerdoPEM AcuID => " + ex.Message, ex)
        End Try
        Return loAcuerdoPEM
    End Function

    Public Shared Function Mostrar_acuEstado_XacuNPlaca_perId_pa(ByVal acuNPlaca1 As [String], ByVal acuNPlaca2 As [String], ByVal acuNPlaca3 As [String], ByVal perId As String) As String
        Dim acuEstado As String = False
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_AcuerdoPEM_acuEstado_XacuNPlaca_perId_pa")
            db.AddInParameter(cmd, "acuNPlaca1", DbType.String, acuNPlaca1)
            db.AddInParameter(cmd, "acuNPlaca2", DbType.String, acuNPlaca2)
            db.AddInParameter(cmd, "acuNPlaca3", DbType.String, acuNPlaca3)
            db.AddInParameter(cmd, "perId", DbType.String, perId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then


                acuEstado = dr("acuEstado").ToString()

            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar AcuerdoPEM AcuID => " + ex.Message, ex)
        End Try
        Return acuEstado
    End Function


    Public Shared Function consultarAcuerdoXNPlaca_Estacionamiento(ByVal asNPlaca As String) As EEAcuerdoPEM
        Dim loAcuerdoPEM As EEAcuerdoPEM = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Consultar_AcuerdoPEM_XNPlaca_Estacionamiento_pa")
            db.AddInParameter(cmd, "acunplaca", DbType.String, asNPlaca)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loAcuerdoPEM = New EEAcuerdoPEM()
                loAcuerdoPEM.AcuNEspacio = dr("acuNEspacio").ToString()
                loAcuerdoPEM.TgTipoVehId = dr("tgTipoVehId").ToString()
                loAcuerdoPEM.Persona = dr("persona").ToString()
                loAcuerdoPEM.AcuEstado = dr("acuEstado").ToString()
                loAcuerdoPEM.MensajeAcuerdo = dr("mensajeAcuerdo").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Acuerdo XNPlaca Estacionamiento => " & ex.Message, ex)
        End Try
        Return loAcuerdoPEM
    End Function

    Public Shared Function ValidaAcuerdoVigenteXPerId(ByVal PerId As String) As String
        Dim AcuId As String = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Valida_Acuerdo_Vigente_by_perId_pa")
            db.AddInParameter(cmd, "PerId", DbType.String, PerId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                AcuId = dr("acuId").ToString()
            End If
        Catch ex As Exception
            Throw New Exception("Validar Acuerdo Vigente X perId => " & ex.Message, ex)
        End Try
        Return AcuId
    End Function

End Class
