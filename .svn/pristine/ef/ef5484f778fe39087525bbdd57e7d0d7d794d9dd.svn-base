Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class ConceptoDAS
    Public Shared Function MostrarXConId(ByVal asConId As [String]) As EEConceptos
        Dim loConceptos As EEConceptos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_Concepto_XConId_pa")
            db.AddInParameter(cmd, "conId", DbType.String, asConId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loConceptos = New EEConceptos()
                loConceptos.ConId = dr("ConId").ToString()
                loConceptos.PartId = dr("PartId").ToString()
                loConceptos.Partida = dr("Partida").ToString()
                loConceptos.TgCenProId = dr("TgCenProId").ToString()
                loConceptos.tgFFinanciera = dr("tgFFinanciera").ToString()
                loConceptos.ConNombre = dr("ConNombre").ToString()
                loConceptos.ConPorcentaje = Convert.ToDecimal(dr("ConPorcentaje"))
                loConceptos.TgCueBanId = dr("TgCueBanId").ToString()
                loConceptos.TgCueBan = dr("TgCueBan").ToString()

                loConceptos.PcontCuenC = dr("PcontCuenC").ToString()
                loConceptos.PcontCuenA = dr("PcontCuenA").ToString()

                loConceptos.PcontCuenCNombre = dr("PcontCuenCNombre").ToString()
                loConceptos.PcontCuenANombre = dr("PcontCuenANombre").ToString()

                loConceptos.TgGrupoConId = dr("TgGrupoConId").ToString()
                loConceptos.TgGrupoCon = dr("TgGrupoCon").ToString()
                loConceptos.ConActivo = Convert.ToBoolean(dr("ConActivo").ToString())
                loConceptos.ConBaseLegal = dr("ConBaseLegal").ToString()
                loConceptos.ConApliMora = Convert.ToBoolean(dr("ConApliMora").ToString())
                loConceptos.ConCodConMPT = dr("ConCodConMPT").ToString()
                loConceptos.ConCodPresMPT = dr("ConCodPresMPT").ToString()
                loConceptos.ConAño = dr("ConAño").ToString()
                loConceptos.TgSubGrupoId = dr("TgSubGrupoId").ToString()
                loConceptos.TgSubGrupo = dr("TgSubGrupo").ToString()
                If IsDBNull(dr("ConImporte")) = False Then
                    loConceptos.ConImporte = Convert.ToDecimal(dr("ConImporte").ToString())
                End If

            End If
        Catch ex As Exception
            Throw New Exception("Listar Conceptos Criterio => " & ex.Message, ex)
        End Try
        Return loConceptos
    End Function

    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal año As Int16) As List(Of EEConceptos)
        Dim ListaConceptos As List(Of EEConceptos) = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Conceptos_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            db.AddInParameter(cmd, "conAnio", DbType.Int32, año)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaConceptos Is Nothing Then
                    ListaConceptos = New List(Of EEConceptos)()
                End If

                loConceptos = New EEConceptos()
                loConceptos.ConId = dr("ConId").ToString()
                loConceptos.PartId = dr("PartId").ToString()
                loConceptos.Partida = dr("Partida").ToString()
                loConceptos.TgCenProId = dr("TgCenProId").ToString()
                loConceptos.tgFFinanciera = dr("tgFFinanciera").ToString()
                loConceptos.ConNombre = dr("ConNombre").ToString()
                loConceptos.ConPorcentaje = Convert.ToDecimal(dr("ConPorcentaje").ToString())
                loConceptos.TgCueBanId = dr("TgCueBanId").ToString()
                loConceptos.TgCueBan = dr("TgCueBan").ToString()
                loConceptos.PcontCuenC = dr("PcontCuenC").ToString()
                loConceptos.PcontCuenA = dr("PcontCuenA").ToString()
                loConceptos.TgGrupoConId = dr("TgGrupoConId").ToString()
                loConceptos.TgGrupoCon = dr("TgGrupoCon").ToString()
                loConceptos.ConActivo = Convert.ToBoolean(dr("ConActivo").ToString())
                loConceptos.ConBaseLegal = dr("ConBaseLegal").ToString()
                loConceptos.ConApliMora = Convert.ToBoolean(dr("ConApliMora").ToString())
                loConceptos.ConCodConMPT = dr("ConCodConMPT").ToString()
                loConceptos.ConCodPresMPT = dr("ConCodPresMPT").ToString()
                loConceptos.ConAño = dr("ConAño").ToString()
                loConceptos.TgSubGrupoId = dr("TgSubGrupoId").ToString()
                loConceptos.TgSubGrupo = dr("TgSubGrupo").ToString()

                If IsDBNull(dr("ConImporte")) = False Then
                    loConceptos.ConImporte = Convert.ToDecimal(dr("ConImporte").ToString())
                End If

                ListaConceptos.Add(loConceptos)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Conceptos Criterio => " & ex.Message, ex)
        End Try
        Return ListaConceptos
    End Function

    Public Shared Function listarBCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], ByVal año As Int16) As List(Of EEConceptos)
        Dim ListaConceptos As List(Of EEConceptos) = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Conceptos_BCriterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            db.AddInParameter(cmd, "conAnio", DbType.Int32, año)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaConceptos Is Nothing Then
                    ListaConceptos = New List(Of EEConceptos)()
                End If

                loConceptos = New EEConceptos()
                loConceptos.ConId = dr("ConId").ToString()
                loConceptos.ConNombre = dr("ConNombre").ToString()
                loConceptos.TgGrupoCon = dr("TgGrupoCon").ToString()
                loConceptos.ConAño = dr("conAnio").ToString()
                loConceptos.ConActivo = Convert.ToBoolean(dr("ConActivo").ToString())
                ListaConceptos.Add(loConceptos)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Conceptos BCriterio => " & ex.Message, ex)
        End Try
        Return ListaConceptos
    End Function

#Region "Listar X Año y TgGrupo"
    Public Shared Function listarXAñoXTgGrupo(ByVal asAño As String, ByVal asTgGrupo As String) As List(Of EEConceptos)
        Dim ListaConceptos As List(Of EEConceptos) = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Conceptos_XAño_XTgGrupo_pa")
            db.AddInParameter(cmd, "año", DbType.String, asAño)
            db.AddInParameter(cmd, "tggrupo", DbType.String, asTgGrupo)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaConceptos Is Nothing Then
                    ListaConceptos = New List(Of EEConceptos)()
                End If

                loConceptos = New EEConceptos()
                loConceptos.ConId = dr("ConId").ToString()
                loConceptos.ConNombre = dr("ConNombre").ToString()
                loConceptos.ConPorcentaje = dr("ConPorcentaje").ToString()
                loConceptos.ConGrupo = dr("ConGrupo").ToString()
                If Not IsDBNull(dr("ConImporte")) Then
                    loConceptos.ConImporte = Convert.ToDecimal(dr("ConImporte").ToString())
                End If
                loConceptos.TgSubGrupoId = dr("tgSubGrupoId").ToString()

                ListaConceptos.Add(loConceptos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Conceptos Alquiler Fincas => " & ex.Message, ex)
        End Try
        Return ListaConceptos
    End Function
#End Region

    Public Shared Function listarXAñoXTgGrupoXTgSubGrupo(ByVal asAño As String, ByVal asTgGrupo As String, ByVal asTgSubGrupo As String) As List(Of EEConceptos)
        Dim ListaConceptos As List(Of EEConceptos) = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Conceptos_XAño_XTgGrupo_XTgSubGrupo_pa")
            db.AddInParameter(cmd, "año", DbType.String, asAño)
            db.AddInParameter(cmd, "tggrupo", DbType.String, asTgGrupo)
            db.AddInParameter(cmd, "tgsubgrupo", DbType.String, asTgSubGrupo)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaConceptos Is Nothing Then
                    ListaConceptos = New List(Of EEConceptos)()
                End If

                loConceptos = New EEConceptos()
                loConceptos.ConId = dr("ConId").ToString()
                loConceptos.ConNombre = dr("ConNombre").ToString()
                loConceptos.ConPorcentaje = dr("ConPorcentaje").ToString()
                loConceptos.ConGrupo = dr("ConGrupo").ToString()
                loConceptos.ConImporte = dr("ConImporte").ToString()
                loConceptos.TgSubGrupoId = dr("tgSubGrupoId").ToString()
                ListaConceptos.Add(loConceptos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar conceptos x TgsubGrupo => " & ex.Message, ex)
        End Try
        Return ListaConceptos
    End Function

#Region "Listar Conceptos Abono"
    Public Shared Function listarAbono() As List(Of EEConceptos)
        Dim ListaConceptos As List(Of EEConceptos) = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Conceptos_Abono_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaConceptos Is Nothing Then
                    ListaConceptos = New List(Of EEConceptos)()
                End If

                loConceptos = New EEConceptos()
                loConceptos.ConId = dr("ConId").ToString()
                loConceptos.ConNombre = dr("ConNombre").ToString()

                ListaConceptos.Add(loConceptos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Conceptos Abono => " & ex.Message, ex)
        End Try
        Return ListaConceptos
    End Function
#End Region

#Region "Listar Conceptos Abono XTgSubGrupoId"
    Public Shared Function listarAbono_XTgSubGrupoId(ByVal asTgSubGrupoId As String) As List(Of EEConceptos)
        Dim ListaConceptos As List(Of EEConceptos) = Nothing
        Dim loConceptos As EEConceptos = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Conceptos_Abono_XTgSubGrupoId_pa")
            db.AddInParameter(cmd, "tgsubgrupoid", DbType.String, asTgSubGrupoId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaConceptos Is Nothing Then
                    ListaConceptos = New List(Of EEConceptos)()
                End If

                loConceptos = New EEConceptos()
                loConceptos.ConId = dr("ConId").ToString()
                loConceptos.ConNombre = dr("ConNombre").ToString()

                ListaConceptos.Add(loConceptos)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Conceptos Abono XTgSubGrupoId=> " & ex.Message, ex)
        End Try
        Return ListaConceptos
    End Function
#End Region

#Region "Mostrar Importe Concepto XConId"
    Public Shared Function mostrarImporte_XConId(ByVal asConId As String) As Decimal?
        Dim ldImporteConcepto As Decimal?
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Concepto_Mostrar_Importe_XConId")
            db.AddInParameter(cmd, "conid", DbType.String, asConId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then

                ldImporteConcepto = dr("ConImporte").ToString()

            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Importe XConId => " & ex.Message, ex)
        End Try
        Return ldImporteConcepto
    End Function
#End Region

End Class
