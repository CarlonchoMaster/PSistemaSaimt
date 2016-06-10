Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class PlanCuentaDAS
    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EEPlanCuenta)
        Dim ListaPlanCuenta As List(Of EEPlanCuenta) = Nothing
        Dim loPlanCuenta As EEPlanCuenta = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_PlanCuenta_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPlanCuenta Is Nothing Then
                    ListaPlanCuenta = New List(Of EEPlanCuenta)()
                End If

                loPlanCuenta = New EEPlanCuenta()

                loPlanCuenta.PlanCId = dr("PlanCId").ToString()
                loPlanCuenta.PlanCAño = Convert.ToInt32(dr("PlanCAño").ToString())
                loPlanCuenta.PlanCDescripcion = dr("PlanCDescripcion").ToString()
               
                ListaPlanCuenta.Add(loPlanCuenta)
            End While
        Catch ex As Exception
            Throw New Exception("Listar PlanCuenta Criterio => " & ex.Message, ex)
        End Try
        Return ListaPlanCuenta
    End Function

    Public Shared Function listarXPlanCId_XPlanCAño(asPlanCId As String, aiAño As Int16) As EEPlanCuenta
        Dim loPlanCuenta As EEPlanCuenta = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_PlanCuenta_XPlanCId_XPlanCAño_pa")
            db.AddInParameter(cmd, "plancid", DbType.String, asPlanCId)
            db.AddInParameter(cmd, "plancaño", DbType.Int32, aiAño)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                loPlanCuenta = New EEPlanCuenta()

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("CuentaCodigo").ToString()
                loTablaGeneral.TgNombre = dr("Cuenta").ToString()
                loPlanCuenta.TgPlanCTipoCuenta = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("CuentaAuxCodigo").ToString()
                loTablaGeneral.TgNombre = dr("CuentaAuxiliar").ToString()
                loPlanCuenta.TgPlanCTipoAuxiliar = loTablaGeneral

                loPlanCuenta.PlanCId = dr("PlanCId").ToString()
                loPlanCuenta.PlanCAño = Convert.ToInt32(dr("PlanCAño").ToString())
                loPlanCuenta.PlanCDescripcion = dr("PlanCDescripcion").ToString()
                loPlanCuenta.PlanCCtaDebe = dr("PlanCCtaDebe").ToString()
                loPlanCuenta.PlanCCtaHaber = dr("PlanCCtaHaber").ToString()
                loPlanCuenta.PlanCCtaNombreDebe = dr("CtaNombreDebe").ToString()
                loPlanCuenta.PlanCCtaNombreHaber = dr("CtaNombreHaber").ToString()
            End While
        Catch ex As Exception
            Throw New Exception("Listar PlanCuenta XPlanCId y XPlanCAño => " & ex.Message, ex)
        End Try
        Return loPlanCuenta
    End Function

    Public Shared Function listarXPlanCAño(aiAño As Int16) As List(Of EEPlanCuenta)
        Dim ListaPlanCuenta As List(Of EEPlanCuenta) = Nothing
        Dim loPlanCuenta As EEPlanCuenta = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_PlanCuenta_XPlanCAño_pa")
            db.AddInParameter(cmd, "plancaño", DbType.Int32, aiAño)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPlanCuenta Is Nothing Then
                    ListaPlanCuenta = New List(Of EEPlanCuenta)()
                End If

                loPlanCuenta = New EEPlanCuenta()

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("CuentaCodigo").ToString()
                loTablaGeneral.TgNombre = dr("Cuenta").ToString()
                loPlanCuenta.TgPlanCTipoCuenta = loTablaGeneral

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("CuentaAuxCodigo").ToString()
                loTablaGeneral.TgNombre = dr("CuentaAuxiliar").ToString()
                loPlanCuenta.TgPlanCTipoAuxiliar = loTablaGeneral

                loPlanCuenta.PlanCId = dr("PlanCId").ToString()
                loPlanCuenta.PlanCAño = Convert.ToInt32(dr("PlanCAño").ToString())
                loPlanCuenta.PlanCDescripcion = dr("PlanCDescripcion").ToString()
                loPlanCuenta.PlanCCtaDebe = dr("PlanCCtaDebe").ToString()
                loPlanCuenta.PlanCCtaHaber = dr("PlanCCtaHaber").ToString()
                loPlanCuenta.PlanCCtaNombreDebe = dr("CtaNombreDebe").ToString()
                loPlanCuenta.PlanCCtaNombreHaber = dr("CtaNombreHaber").ToString()

                ListaPlanCuenta.Add(loPlanCuenta)
            End While
        Catch ex As Exception
            Throw New Exception("Listar PlanCuenta XPlanCAño => " & ex.Message, ex)
        End Try
        Return ListaPlanCuenta
    End Function

    Public Shared Function listarAños() As List(Of String)
        Dim ListaAños As List(Of String) = Nothing
        Dim dr As IDataReader = Nothing
        Dim lsAño As String = String.Empty
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Años_PlanCuenta_pa")
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaAños Is Nothing Then
                    ListaAños = New List(Of String)()
                End If
                lsAño = dr("planCAño").ToString()
                ListaAños.Add(lsAño)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ALL PlanCuenta Años => " & ex.Message, ex)
        End Try
        Return ListaAños
    End Function
End Class
