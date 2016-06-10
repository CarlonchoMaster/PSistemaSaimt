Imports Entidades
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class NivelesPEMDAS
    Public Shared Function listarCriterio(aiTipoCriterio As Int32, asCriterio As [String]) As List(Of EENivelesPEM)
        Dim ListaNivelesPEM As List(Of EENivelesPEM) = Nothing
        Dim loNivelesPEM As EENivelesPEM = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_NivelesPEM_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaNivelesPEM Is Nothing Then
                    ListaNivelesPEM = New List(Of EENivelesPEM)()
                End If

                loNivelesPEM = New EENivelesPEM()

                loNivelesPEM.NivId = dr("NivId").ToString()
                loNivelesPEM.NivNombre = dr("NivNombre").ToString()
                loNivelesPEM.NivEspInicio = Convert.ToInt32(dr("NivEspInicio").ToString())
                loNivelesPEM.NivEspFin = Convert.ToInt32(dr("NivEspFin").ToString())
                loNivelesPEM.NivActivo = Convert.ToBoolean(dr("NivActivo").ToString())
                loNivelesPEM.tgInstitucionId = dr("TgInstitucionId").ToString()
                loNivelesPEM.tgSedeId = dr("TgSedeId").ToString()
                loNivelesPEM.tgNPisoId = dr("tgNPisoId").ToString()
                loNivelesPEM.AbreviaturaIntitucionSede = dr("abrevInstitucionSede").ToString()

                ListaNivelesPEM.Add(loNivelesPEM)
            End While
        Catch ex As Exception
            Throw New Exception("Listar NivelesPEM Criterio => " & ex.Message, ex)
        End Try
        Return ListaNivelesPEM
    End Function

    Public Shared Function listarALL() As List(Of EENivelesPEM)
        Dim ListaNivelesPEM As List(Of EENivelesPEM) = Nothing
        Dim loNivelesPEM As EENivelesPEM = Nothing
        Dim loNroPisos As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_NivelesPEM_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaNivelesPEM Is Nothing Then
                    ListaNivelesPEM = New List(Of EENivelesPEM)()
                End If

                loNivelesPEM = New EENivelesPEM()

                loNivelesPEM.NivId = dr("NivId").ToString()
                loNivelesPEM.NivNombre = dr("NivNombre").ToString()
                loNivelesPEM.NivEspInicio = Convert.ToInt32(dr("NivEspInicio").ToString())
                loNivelesPEM.NivEspFin = Convert.ToInt32(dr("NivEspFin").ToString())
                loNivelesPEM.tgInstitucionId = dr("TgInstitucionId").ToString()
                loNivelesPEM.tgSedeId = dr("TgSedeId").ToString()
                loNivelesPEM.NivActivo = Convert.ToBoolean(dr("NivActivo").ToString())

                loNroPisos = New EETablaGeneral()
                loNroPisos.TgNombre = dr("NroPiso").ToString()

                loNivelesPEM.ONroPiso = loNroPisos

                ListaNivelesPEM.Add(loNivelesPEM)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ALL NivelesPEM => " & ex.Message, ex)
        End Try
        Return ListaNivelesPEM
    End Function

    Public Shared Function listarxNivId(ByVal NivId As [String]) As EENivelesPEM
        Dim loNivPEM As EENivelesPEM = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_NivelesPEM_NivId_pa")
            db.AddInParameter(cmd, "NivId", DbType.String, NivId)


            dr = db.ExecuteReader(cmd)
            While dr.Read()

                loNivPEM = New EENivelesPEM()

                loNivPEM.NivId = dr("NivId").ToString()
                loNivPEM.NivNombre = dr("NivNombre").ToString()
                loNivPEM.NivEspInicio = dr("NivEspInicio").ToString()
                loNivPEM.NivEspFin = dr("NivEspFin").ToString()
                loNivPEM.NivActivo = dr("NivActivo").ToString()
                loNivPEM.tgInstitucionId = dr("TgInstitucionId").ToString()
                loNivPEM.tgSedeId = dr("TgSedeId").ToString()
                loNivPEM.tgNPisoId = dr("tgNPisoId").ToString()

            End While
        Catch ex As Exception
            Throw New Exception("Listar NivelesPEM NivID => " + ex.Message, ex)
        End Try
        Return loNivPEM
    End Function


    Public Shared Function GeneraCodigo() As String
        Dim dr As IDataReader = Nothing
        Dim codigo As String = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_NivelesPEM")

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                codigo = dr("nivId").ToString()
            End If

        Catch ex As Exception
            Throw New Exception("Genera codigo => " & ex.Message, ex)
        End Try
        Return codigo
    End Function

    Public Shared Function VerificarXAcuNEspacio(ByVal aiEspacio As Int16) As Boolean
        Dim rpta As Boolean = False
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Verificar_AcuerdoPEM_XAcuNEspacio_pa")

            db.AddInParameter(cmd, "acuNEspacio ", DbType.Int16, aiEspacio)

            Dim liNumFila As Integer
            liNumFila = CInt(db.ExecuteScalar(cmd))
            If liNumFila = 0 Then
                rpta = True
            End If
        Catch ex As Exception
            Throw New Exception("Verificar X AcuNEspacio => " + ex.Message, ex)
        End Try
        Return rpta
    End Function
End Class
