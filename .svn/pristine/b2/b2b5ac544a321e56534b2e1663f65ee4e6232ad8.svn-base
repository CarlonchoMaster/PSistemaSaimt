Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class TablaGeneralDAS
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loClase As EEClase = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If
                loTablaGeneral = New EETablaGeneral()
                loClase = New EEClase
                loClase.ClsId = Convert.ToInt32(dr("ClsId").ToString())
                loClase.ClsNombre = dr("ClsNombre").ToString()
                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                loTablaGeneral.OClase = loClase
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgActivo = Convert.ToBoolean(dr("TgActivo").ToString())
                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral Criterio => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

    Public Shared Function listarALL() As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loClase As EEClase = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_ALL_pa")
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If
                loTablaGeneral = New EETablaGeneral()
                loClase = New EEClase
                loClase.ClsId = Convert.ToInt32(dr("ClsId").ToString())
                loClase.ClsNombre = Convert.ToInt32(dr("ClsNombre").ToString())
                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                loTablaGeneral.OClase = loClase
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgActivo = Convert.ToBoolean(dr("TgActivo").ToString())
                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar ALL TablaGeneral => " & ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

    Public Shared Function listarXClsIdTgcodigos(ByVal aiClsId As Int32, asTgcodigos As String) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XIdClase_tgcodigos_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)
            db.AddInParameter(cmd, "tgcodigos", DbType.String, asTgcodigos)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()

                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

    Public Shared Function listarXClsIdTgListarCriterio(ByVal aiClsId As Int32, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XClsId_Criterio_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tcriterio", DbType.String, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgActivo = dr("TgActivo").ToString()

                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase and criterio => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

    Public Shared Function listarXClsId1_IN_ClsId2_ListarCriterio(ByVal aiClsId1 As Int32, ByVal aiClsId2 As Int32, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_X_clsId1_IN_clsId2_Criterio_pa")
            db.AddInParameter(cmd, "clsid1", DbType.Int32, aiClsId1)
            db.AddInParameter(cmd, "clsid2", DbType.Int32, aiClsId2)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tcriterio", DbType.String, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgActivo = dr("TgActivo").ToString()


                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase and criterio => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

#Region "Listar XClsId"
    Public Shared Function listarXClsId(ByVal aiClsId As Int32) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XIdClase_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()

                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function
    Public Shared Function listarXClsId2(ByVal aiClsId As Int32) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XIdClase2_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()

                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

    'Procedimiento Lista mas de 2 clases a la vez ejemplo: 23,24,25
    Public Shared Function listarXClasesId(ByVal aiClasesId As String) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XClasesId_pa")
            db.AddInParameter(cmd, "clsid", DbType.String, aiClasesId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.OClase = New EEClase()
                loTablaGeneral.OClase.ClsId = Convert.ToInt32(dr("ClsId").ToString())
                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

    Public Shared Function listarXClsId_OrderBy_tgOrden(ByVal aiClsId As Int32) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XClsId_OtgOrden_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()

                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function
#End Region

    Public Shared Function listarXClsIdXTgExtraListarCriterio(ByVal aiClsId As Int32, asTgCodigo As String, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XClsId_XTgExtra_Criterio_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)
            db.AddInParameter(cmd, "tgcodigo", DbType.String, asTgCodigo)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tcriterio", DbType.String, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgActivo = dr("TgActivo").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase XTgExtra  lista Criterios=> " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function
    ''' <summary>
    ''' Listar Items Segun ClsId Con Opcion de TgCodigo O/Y TgAbrev O/Y TgExtra
    ''' </summary>

    Public Shared Function Listar_XClsId_Opcional_tgCodigo_tgAbrev_tgExtra_pa(ByVal aiClsId As Int32, Optional ByVal asTgCodigo As String = Nothing, Optional ByVal asTgAbrev As String = Nothing, Optional ByVal asTgExtra As String = Nothing) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XClsId_OptgCodigo_OptgAbrev_OptgExtra_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)
            db.AddInParameter(cmd, "tgcodigo", DbType.String, asTgCodigo)
            db.AddInParameter(cmd, "tgabrev", DbType.String, asTgAbrev)
            db.AddInParameter(cmd, "tgextra", DbType.String, asTgExtra)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgActivo = dr("TgActivo").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase XtgCodigo XtgAbrev XtgExtra => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

    ''' <summary>
    ''' Listar Sub Items Segun ClsId y TgExtra
    ''' </summary>
    ''' <param name="aiClsId">ClsId</param>
    ''' <param name="asTgExtra">TgExtra = TgCodigo Campo Seleccionado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function listar_XClsId_XTgExtra(ByVal aiClsId As Int32, ByVal asTgExtra As String) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XClsId_XTgExtra_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)
            db.AddInParameter(cmd, "tgextra", DbType.String, asTgExtra)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgActivo = dr("TgActivo").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase XTgExtra => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

    Public Shared Function listarXTgAbrev(ByVal asTgAbrev As String) As EETablaGeneral
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XTgAbrev_pa")
            db.AddInParameter(cmd, "tgAbrev", DbType.String, asTgAbrev)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XTgAbrev => " + ex.Message, ex)
        End Try
        Return loTablaGeneral
    End Function

    Public Shared Function ValidaITgCodigo(ByVal aiClsId As Int32, ByVal asTgCodigo As [String]) As Boolean
        Dim Existe As Boolean = False

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Valida_TablaGeneral_ItgCodigo_by_ClsId")
            db.AddInParameter(cmd, "clsId", DbType.Int32, aiClsId)
            db.AddInParameter(cmd, "tgCodigo", DbType.String, asTgCodigo)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                Existe = True
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral Criterio => " + ex.Message, ex)
        End Try
        Return Existe
    End Function

    Public Shared Function ValidaUTgCodigo(ByVal aiClsId As Int32, ByVal asTgId As Int16, ByVal asTgCodigo As [String]) As Boolean
        Dim Existe As Boolean = False

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Valida_TablaGeneral_UtgCodigo_by_ClsId")
            db.AddInParameter(cmd, "clsId", DbType.Int32, aiClsId)
            db.AddInParameter(cmd, "tgId", DbType.String, asTgId)
            db.AddInParameter(cmd, "tgCodigo", DbType.String, asTgCodigo)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                Existe = True
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral Criterio => " + ex.Message, ex)
        End Try
        Return Existe
    End Function

#Region "Mostrar XClsId XTgCodigo"
    ''' <summary>
    ''' MUESTRA UN SOLO RESULTADO X ClsId y TgCodigo
    ''' </summary>
    ''' <param name="aiClsId">Clase Id</param>
    ''' <param name="asTgCodigo">TgCodigo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function mostrarXClsIdXTgCodigo(ByVal aiClsId As Int32, ByVal asTgCodigo As String) As EETablaGeneral
        Dim loTablaGeneral As EETablaGeneral = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_TablaGeneral_XClsId_XTgCodigo_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)
            db.AddInParameter(cmd, "tgcodigo", DbType.String, asTgCodigo)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar TablaGeneral XClsId XTgCodigo => " + ex.Message, ex)
        End Try
        Return loTablaGeneral
    End Function

    Public Shared Function ListarXClsIdXTgExtraId(ByVal aiClsId As Int32, ByVal asTgExtraId As String) As List(Of EETablaGeneral)
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_TablaGeneral_XClsId_XTgExtra_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)
            db.AddInParameter(cmd, "tgExtra", DbType.String, asTgExtraId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)
                End If
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgActivo = dr("TgActivo").ToString()
                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar TablaGeneral XClsId XTgExtra => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function
#End Region

#Region "Generar codigo tabla general"
    Public Shared Function GetInstitucionCodigoGenerado() As String
        Dim Codigo As String = String.Empty
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Institucion")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                Codigo = dr("tgCodigo").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Genera Codigo Institucion => " + ex.Message, ex)
        End Try
        Return Codigo
    End Function

    Public Shared Function GetCodigoGenerado_by_ncaracteres_clsid(ncaracteres As Integer, clsid As Integer, Optional tgExtra As Integer = -1) As String
        Dim Codigo As String = String.Empty
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_TablaGeneral_by_criterio_pa")
            db.AddInParameter(cmd, "ncaracteres", DbType.Int16, ncaracteres)
            db.AddInParameter(cmd, "clsid", DbType.Int16, clsid)
            If tgExtra <> -1 Then
                db.AddInParameter(cmd, "tgExtra", DbType.Int16, tgExtra)
            End If
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                Codigo = dr("tgCodigo").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Genera en Tabla General x Criterios => " + ex.Message, ex)
        End Try
        Return Codigo
    End Function

    Public Shared Function GetAreaCodigoGenerado(sInstitucionId As String) As String
        Dim Codigo As String = String.Empty
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Area")
            db.AddInParameter(cmd, "tgExtra", DbType.String, sInstitucionId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                Codigo = dr("tgCodigo").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Genera Codigo Area => " + ex.Message, ex)
        End Try
        Return Codigo
    End Function

    Public Shared Function GetCargoCodigoGenerado(sInstitucionId As String, sAreaId As String) As String
        Dim Codigo As String = String.Empty
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_cargo")
            db.AddInParameter(cmd, "tgExtra", DbType.String, sAreaId & sInstitucionId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                Codigo = dr("tgCodigo").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Genera Codigo Cargo => " + ex.Message, ex)
        End Try
        Return Codigo
    End Function


    Public Shared Function GetRequisitosCodigoGenerado() As String
        Dim Codigo As String = String.Empty
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Requisito")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                Codigo = dr("tgCodigo").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Genera Codigo Requisitos => " + ex.Message, ex)
        End Try
        Return Codigo
    End Function

    Public Shared Function GetProcedimientoCodigoGenerado() As String
        Dim Codigo As String = String.Empty
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Procedimiento")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                Codigo = dr("ProcId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Genera Codigo Procedimiento => " + ex.Message, ex)
        End Try
        Return Codigo
    End Function
#End Region

    Public Shared Function listarXTgId(ByVal aiTgId As Int32) As EETablaGeneral
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XId_pa")
            db.AddInParameter(cmd, "tgid", DbType.Int32, aiTgId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then

                loTablaGeneral = New EETablaGeneral()

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgDescripcion = dr("tgDescripcion").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgActivo = dr("TgActivo").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XTgId => " + ex.Message, ex)
        End Try
        Return loTablaGeneral
    End Function

    Public Shared Function listarXClsIdCriterios(ByVal aiClsId As Int32, ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_TablaGeneral_XClsId_Criterios_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipocriterio", DbType.String, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()

                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar TablaGeneral XIdClase Criterios => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function

#Region "Mostrar Tabla General X ClsId"
    Public Shared Function mostrarXClsId(ByVal aiClsId As Int32) As List(Of EETablaGeneral)
        Dim ListaTablaGeneral As List(Of EETablaGeneral) = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_TablaGeneral_XClsId_pa")
            db.AddInParameter(cmd, "clsid", DbType.Int32, aiClsId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaTablaGeneral Is Nothing Then
                    ListaTablaGeneral = New List(Of EETablaGeneral)()
                End If

                loTablaGeneral = New EETablaGeneral()
                Dim loClaseExtra As EEClase = New EEClase()
                If Not IsDBNull(dr("ClsExtraId")) Then
                    loClaseExtra.ClsId = Convert.ToInt32(dr("ClsExtraId").ToString())
                End If

                loTablaGeneral.TgId = Convert.ToInt32(dr("TgId").ToString())
                loTablaGeneral.TgDescripcion = dr("TgDescripcion").ToString()
                loTablaGeneral.TgAbrev = dr("TgAbrev").ToString()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgExtra = dr("TgExtra").ToString()
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loTablaGeneral.TgActivo = Convert.ToBoolean(dr("TgActivo").ToString())
                loTablaGeneral.OClaseExtra = loClaseExtra
                ListaTablaGeneral.Add(loTablaGeneral)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Tabla General X ClsId => " + ex.Message, ex)
        End Try
        Return ListaTablaGeneral
    End Function
#End Region
End Class
