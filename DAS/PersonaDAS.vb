Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports Entidades
Imports System.Data.Common

Public Class PersonaDAS

    Public Shared Function MostrartgAreaTgCargoxPerId(ByVal PerId As [String]) As String
        Dim DatosPersona As String = String.Empty
        Dim dr As IDataReader = Nothing

        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Mostrar_TgArea_TgCargo_XPerId_pa")
            db.AddInParameter(cmd, "PerId", DbType.String, PerId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                DatosPersona = dr("DatosPersona").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Area y Cargo por PerId => " + ex.Message, ex)
        End Try
        Return DatosPersona
    End Function


#Region "Listar Persona PerId"
    Public Shared Function listarxPerId(ByVal PerId As [String]) As EEPersona
        Dim loPersona As EEPersona = Nothing
        Dim loUbigeo As EEUbigeo = Nothing
        Dim dr As IDataReader = Nothing
        Dim dr2 As IDataReader = Nothing
        Dim dr3 As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Listar_Persona_XPerId_pa")
            db.AddInParameter(cmd, "PerId", DbType.String, PerId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                loPersona = New EEPersona()
                loUbigeo = New EEUbigeo()
                loUbigeo.UbgId = dr("UbgId").ToString()
                loUbigeo.UbgDep = dr("UbgDep").ToString()
                loUbigeo.UbgProv = dr("UbgProv").ToString()
                loUbigeo.UbgDist = dr("UbgDist").ToString()
                loUbigeo.UbgNombre = dr("UbgNombre").ToString()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.TgTipoPersId = dr("TgTipoPersId").ToString()
                loPersona.TgTipoDoc = dr("TgTipoDoc").ToString()
                loPersona.PerNDoc = dr("PerNDoc").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()
                loPersona.PerDireccion = dr("PerDireccion").ToString()
                loPersona.OUbigeo = loUbigeo
                loPersona.PerObservacion = dr("PerObservacion").ToString()
                loPersona.PerActivo = Convert.ToBoolean(dr("PerActivo").ToString())
                loPersona.PerIdConyuge = dr("PerIdConyuge").ToString()
                loPersona.PerFechaNac = IIf(IsDBNull(dr("PerFechaNac")), Nothing, dr("PerFechaNac"))
                loPersona.TgGeneroId = dr("TgGeneroId").ToString

                cmd = db.GetStoredProcCommand("Listar_PersonaContacto_XIdPersona_pa")
                db.AddInParameter(cmd, "perid", DbType.String, loPersona.PerId)
                dr2 = db.ExecuteReader(cmd)

                While dr2.Read()
                    Dim loContacto As EEPersona.EEContacto = New EEPersona.EEContacto()
                    Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgCodigo = dr2("TgCodigo").ToString()
                    loTablaGeneral.TgNombre = dr2("TgNombre").ToString()
                    loContacto.ContDescripcion = dr2("ContDescripcion").ToString()
                    loContacto.OTablaGeneral = loTablaGeneral
                    loPersona.ListaContacto.Add(loContacto)
                End While
                dr2.Close()

                If Not String.IsNullOrEmpty(loPersona.PerIdConyuge) Then
                    cmd = db.GetStoredProcCommand("Mostrar_Conyuge_XPerId_pa")
                    db.AddInParameter(cmd, "perid", DbType.String, loPersona.PerIdConyuge)
                    dr3 = db.ExecuteReader(cmd)
                    If dr3.Read() Then
                        Dim loPerConyuge As EEPersona = New EEPersona()
                        loPerConyuge.PerNombres = dr3("PerNombres").ToString()
                        loPerConyuge.PerApeMaterno = dr3("PerApeMaterno").ToString()
                        loPerConyuge.PerApePaterno = dr3("PerApePaterno").ToString()
                        loPerConyuge.PerDni = dr("PerNDoc").ToString()

                        loPersona.OPerConyuge = loPerConyuge
                    End If

                    dr3.Close()
                End If
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona por PerId => " + ex.Message, ex)
        End Try
        Return loPersona
    End Function

#End Region
    Public Shared Function MostrarNombresxPerId(ByVal PerId As [String]) As String
        Dim DatosPersona As String = String.Empty
        Dim dr As IDataReader = Nothing

        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Mostrar_Persona_Nombres_XPerId_pa")
            db.AddInParameter(cmd, "PerId", DbType.String, PerId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                DatosPersona = dr("DatosPersona").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Mostrar Nombre Persona por PerId => " + ex.Message, ex)
        End Try
        Return DatosPersona
    End Function
#Region "Listar Criterio"
    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        'Dim loUbigeo As EEUbigeo = Nothing
        Dim dr As IDataReader = Nothing
        Dim dr2 As IDataReader = Nothing
        Dim dr3 As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Listar_Persona_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If

                loPersona = New EEPersona()
                'loUbigeo = New EEUbigeo()
                'loUbigeo.UbgId = dr("UbgId").ToString()
                'loUbigeo.UbgDep = dr("UbgDep").ToString()
                'loUbigeo.UbgProv = dr("UbgProv").ToString()
                'loUbigeo.UbgDist = dr("UbgDist").ToString()
                'loUbigeo.UbgNombre = dr("UbgNombre").ToString()

                loPersona.PerId = dr("PerId").ToString()
                loPersona.Persona = dr("Persona").ToString()
                'loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                'loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                'loPersona.TgTipoPersId = dr("TgTipoPersId").ToString()

                'loPersona.PerNombreCompleto = IIf(dr("TgTipoPersId").ToString() = "J", dr("PerRazonSocial").ToString(), dr("PerNombres").ToString() & " " & dr("PerApePaterno").ToString() & " " & dr("PerApeMaterno").ToString())
                loPersona.TgTipoDoc = dr("tgDocumento").ToString()
                loPersona.TgTipoPersona = dr("tgTipoPersona").ToString()
                loPersona.PerNDoc = dr("PerNDoc").ToString()
                'loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()
                'loPersona.PerDireccion = dr("PerDireccion").ToString()
                'loPersona.OUbigeo = loUbigeo
                'loPersona.PerObservacion = dr("PerObservacion").ToString()
                'loPersona.PerActivo = Convert.ToBoolean(dr("PerActivo").ToString())
                'loPersona.PerIdConyuge = dr("PerIdConyuge").ToString()
                loPersona.PerRef = dr("Referencia").ToString()

                'cmd = db.GetStoredProcCommand("Listar_PersonaContacto_XIdPersona_pa")
                'db.AddInParameter(cmd, "perid", DbType.String, loPersona.PerId)
                'dr2 = db.ExecuteReader(cmd)

                'While dr2.Read()
                '    Dim loContacto As EEPersona.EEContacto = New EEPersona.EEContacto()
                '    Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
                '    loTablaGeneral.TgCodigo = dr2("TgCodigo").ToString()
                '    loTablaGeneral.TgNombre = dr2("TgNombre").ToString()
                '    loContacto.ContDescripcion = dr2("ContDescripcion").ToString()
                '    loContacto.OTablaGeneral = loTablaGeneral
                '    loPersona.ListaContacto.Add(loContacto)
                'End While
                'dr2.Close()

                'If Not String.IsNullOrEmpty(loPersona.PerIdConyuge) Then
                '    cmd = db.GetStoredProcCommand("Mostrar_Conyuge_XPerId_pa")
                '    db.AddInParameter(cmd, "perid", DbType.String, loPersona.PerIdConyuge)
                '    dr3 = db.ExecuteReader(cmd)
                '    If dr3.Read() Then
                '        Dim loPerConyuge As EEPersona = New EEPersona()
                '        loPerConyuge.PerNombres = dr3("PerNombres").ToString()
                '        loPerConyuge.PerApeMaterno = dr3("PerApeMaterno").ToString()
                '        loPerConyuge.PerApePaterno = dr3("PerApePaterno").ToString()
                '        loPerConyuge.PerDni = dr("PerNDoc").ToString()

                '        loPersona.OPerConyuge = loPerConyuge
                '    End If

                '    dr3.Close()
                'End If
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona Criterio => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function
#End Region

#Region "Listar Criterio Programacion Pagos"
    Public Shared Function listarCriterioProgramacionPagos(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim dr3 As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Listar_Persona_Criterio_EnProgramacionPagos_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()
                loPersona.PerContacto = dr("PerContacto").ToString()
                loPersona.PerNDoc = dr("PerNDoc").ToString()
                loPersona.TgTipoPersId = dr("TgTipoPersId").ToString()
                loPersona.TgTipoDoc = dr("tgTipoDoc").ToString()
                loPersona.PerNDoc = dr("perNdoc").ToString()
                loPersona.TgDocumento = dr("tgDocumento").ToString()
                loPersona.PerDireccion = dr("PerDireccion").ToString()
                loPersona.PerDepartamento = dr("PerDepartamento").ToString()
                loPersona.PerProvincia = dr("PerProvincia").ToString()
                loPersona.PerDistrito = dr("PerDistrito").ToString()
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona Criterio => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function
#End Region

#Region "Listar Criterio Consultor Programacion Pagos"
    Public Shared Function listarCriterioConsultaProgramacionPagos(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing

        Dim dr As IDataReader = Nothing
        Dim dr3 As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Listar_Persona_Criterio_EnConsultorProgramacionPagos_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If

                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()
                loPersona.PerContacto = dr("PerContacto").ToString()
                loPersona.PerNDoc = dr("PerNDoc").ToString()
                loPersona.TgTipoPersId = dr("TgTipoPersId").ToString()
                loPersona.PerDireccion = dr("PerDireccion").ToString()
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona Criterio Consulta Programacion Pagos => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function
#End Region

#Region "Listar Persona Criterios en Abonados"
    Public Shared Function listarCriterioAbonados(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String], Optional ByVal asCriterio1 As String = Nothing) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim dr3 As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Listar_Persona_Criterio_EnAbonados_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "criterio1", DbType.String, asCriterio1)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.Persona = dr("Persona").ToString()
                loPersona.PerNDoc = dr("PerNDoc").ToString()
                loPersona.TgTipoDoc = dr("tgTipoDoc").ToString()
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona Criterio Abonados=> " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function

#End Region

#Region "Consultar Conyuge"
    Public Shared Function ConsultarConyuge(ByVal asPerTexto As [String]) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Consultar_Conyuge_pa")
            db.AddInParameter(cmd, "perTexto", DbType.String, asPerTexto)
            dr = db.ExecuteReader(cmd)

            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerNDoc = dr("PerNDoc").ToString()
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Conyuge => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function
#End Region

#Region "Consultar Proveedor"
    Public Shared Function ConsultarProveedor(ByVal asPerTexto As [String]) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Consultar_Proveedor_pa")
            db.AddInParameter(cmd, "perTexto", DbType.String, asPerTexto)
            dr = db.ExecuteReader(cmd)

            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()
                loPersona.PerRuc = dr("PerRuc").ToString()
                loPersona.PerDireccion = dr("PerDireccion").ToString()
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Proveedor => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function

    Public Shared Function ConsultarProveedorCriterios(ByVal aiTipoCriterio As Int16, ByVal asCriterio As [String]) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Consultar_Proveedor_Criterio_pa")
            db.AddInParameter(cmd, "tipocriterio", DbType.String, aiTipoCriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            dr = db.ExecuteReader(cmd)

            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerRazonSocial = dr("PerRazonSocial").ToString()
                loPersona.PerNDoc = dr("perNDoc").ToString()
                loPersona.TgTipoDoc = dr("tgTipoDoc").ToString()
                loPersona.TgTipoDocId = dr("tgTipoDocId").ToString()
                loPersona.PerDireccion = dr("PerDireccion").ToString()
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Proveedor Criterios => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function
#End Region

#Region "Consultar Persona Usuario"
    Public Shared Function ConsultarPersonaUsuario(ByVal asPerTexto As [String]) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Consultar_PersonaUsuario_pa")
            db.AddInParameter(cmd, "perTexto", DbType.String, asPerTexto)
            dr = db.ExecuteReader(cmd)

            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerNDoc = dr("perNDoc").ToString()

                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Persona Usuario => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function
#End Region

#Region "Consulta Persona Contacto XPerId"
    Public Shared Function ConsultarPersonaContactoXPerId(ByVal asPerId As [String]) As EEPersona
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Listar_PersonaContacto_XIdPersona_pa")
            db.AddInParameter(cmd, "perId", DbType.String, asPerId)
            dr = db.ExecuteReader(cmd)

            While dr.Read()
                If loPersona Is Nothing Then
                    loPersona = New EEPersona
                End If
                Dim loContacto As EEPersona.EEContacto = New EEPersona.EEContacto()
                Dim loTablaGeneral As EETablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loContacto.ContDescripcion = dr("ContDescripcion").ToString()
                loContacto.OTablaGeneral = loTablaGeneral
                loPersona.PerId = dr("perId").ToString()
                loPersona.ListaContacto.Add(loContacto)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Conyuge => " + ex.Message, ex)
        End Try
        Return loPersona
    End Function


    Public Shared Function MostrarContactoPersonaXPerId_tgContactoId(ByVal asPerId As [String], ByVal astgContactoId As String) As EEPersona.EEContacto
        Dim loContacto As EEPersona.EEContacto = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Mostrar_ContactoPersona_XPerId_TgContactoId_pa")
            db.AddInParameter(cmd, "perId", DbType.String, asPerId)
            db.AddInParameter(cmd, "TgContactoId", DbType.String, astgContactoId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loContacto = New EEPersona.EEContacto()
                loTablaGeneral = New EETablaGeneral()
                loTablaGeneral.TgCodigo = dr("TgCodigo").ToString()
                loTablaGeneral.TgNombre = dr("TgNombre").ToString()
                loContacto.ContDescripcion = dr("ContDescripcion").ToString()
                loContacto.OTablaGeneral = loTablaGeneral
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Contacto x PerSona y ContactoId => " + ex.Message, ex)
        End Try
        Return loContacto
    End Function
#End Region

#Region "Lista Personas por Cargo"
    Public Shared Function ListarXCargoId(Optional ByVal ascarPerId As [String] = Nothing) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Listar_Personas_XcarPerId_pa")
            If ascarPerId IsNot Nothing Then
                db.AddInParameter(cmd, "carPerId", DbType.String, ascarPerId)
            End If

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerNombreCompleto = dr("PerApePaterno").ToString() & " " & dr("PerApeMaterno").ToString() & " " & dr("PerNombres").ToString()
                loPersona.PerNDoc = dr("perNDoc").ToString()
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona por CargoID  => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function

    Public Shared Function ListarX_DocSTD_Id(ByVal docId As [String]) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim locargoPersonal As EECargoPersonal = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Listar_Personas_MoviminetoSTD_XDocId_pa")
            db.AddInParameter(cmd, "docId", DbType.String, docId)
            dr = db.ExecuteReader(cmd)

            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                locargoPersonal = New EECargoPersonal
                loPersona.PerId = dr("PerId").ToString()
                loPersona.PerNombres = dr("PerNombres").ToString()
                loPersona.PerApeMaterno = dr("PerApeMaterno").ToString()
                loPersona.PerApePaterno = dr("PerApePaterno").ToString()
                loPersona.PerDireccion = dr("PerDireccion").ToString()
                loPersona.PerNDoc = dr("perNDoc").ToString()
                locargoPersonal.CarPerFechaIni = dr("carPerFechaIni").ToString()
                locargoPersonal.CarPerId = dr("carPerId").ToString()
                loPersona.OPerCargoPersonal = locargoPersonal
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona por CargoID  => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function

#End Region

#Region "Consultar Persona General"
    ''' <summary>
    ''' CONSULTAR PERSONA GENERAL
    ''' </summary>
    ''' <param name="aiTipoPersona">1=PERSONA NATURAL, 2=PERSONA JURIDICA, 3=AMBOS</param>
    ''' <param name="asCriterio">TEXTO A CONSULTAR</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function consultarGeneral(ByVal aiTipoPersona As Int16, aiTipoCriterio As Int16, ByVal asCriterio As String) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim dr2 As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Consultar_Persona_General_pa")
            db.AddInParameter(cmd, "tipopersona", DbType.Int16, aiTipoPersona)
            db.AddInParameter(cmd, "tipocriterio", DbType.Int16, aiTipoCriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.Persona = dr("Persona").ToString()
                loPersona.PerContacto = dr("PerContacto").ToString()
                loPersona.PerNDoc = dr("PerNDoc").ToString()
                loPersona.TgTipoPersId = dr("TgTipoPersId").ToString()
                loPersona.TgTipoPersona = dr("TgTipoPersona").ToString()
                loPersona.TgTipoDoc = dr("tgTipoDoc").ToString()
                loPersona.PerNDoc = dr("perNdoc").ToString()
                loPersona.TgDocumento = dr("tgDocumento").ToString()
                loPersona.PerDireccion = dr("PerDireccion").ToString()
                loPersona.PerDepartamento = dr("PerDepartamento").ToString()
                loPersona.PerProvincia = dr("PerProvincia").ToString()
                loPersona.PerDistrito = dr("PerDistrito").ToString()
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona Criterio => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function
#End Region

#Region "Consultar Persona vehiculo "
    Public Shared Function consultarPerVehiculo(ByVal aiTipoCriterio As Int16, ByVal asCriterio As String) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing

        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Consultar_PerVehiculoPEM_criterio_pa")
            db.AddInParameter(cmd, "tipocriterio", DbType.Int16, aiTipoCriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.Persona = dr("Persona").ToString()
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Personas que tiene Vehiculo => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function
#End Region

#Region "Genera Codigo Persona"

    Public Shared Function GeneraCodigo() As String
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Dim Codigo As String = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Genera_Codigo_Persona")
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then

                Codigo = dr("PerId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona Genera Codigo => " + ex.Message, ex)
        End Try
        Return Codigo
    End Function
#End Region

    Public Shared Function MostrarPersonaUsuarioxPerId(ByVal asPerId As [String]) As EEPersona
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Mostrar_PersonaUsuario_XPerId_pa")
            db.AddInParameter(cmd, "perId", DbType.String, asPerId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.Persona = dr("Persona").ToString()
                loPersona.Usuario = dr("Usuario").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona Usuario => " + ex.Message, ex)
        End Try
        Return loPersona
    End Function

    Public Shared Function MostrarPersonaUsuario() As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Mostrar_PersonaUsuario_XPerId_pa")
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.Persona = dr("Persona").ToString()
                loPersona.Usuario = dr("Usuario").ToString()
                ListaPersona.Add(loPersona)
            End While


            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Persona Usuario => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function

#Region "Consultar Persona Detalle Abono"
    Public Shared Function consultarDetalleAbono(aiTipoCriterio As Int16, ByVal asCriterio As String) As List(Of EEPersona)
        Dim ListaPersona As List(Of EEPersona) = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim dr As IDataReader = Nothing
        Dim cmd As DbCommand = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            cmd = db.GetStoredProcCommand("Consultar_Persona_DetalleAbono_pa")
            db.AddInParameter(cmd, "tipocriterio", DbType.Int16, aiTipoCriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaPersona Is Nothing Then
                    ListaPersona = New List(Of EEPersona)()
                End If
                loPersona = New EEPersona()
                loPersona.PerId = dr("PerId").ToString()
                loPersona.Persona = dr("Persona").ToString()
                loPersona.PerContacto = dr("PerContacto").ToString()
                loPersona.PerNDoc = dr("PerNDoc").ToString()
                'loPersona.TgTipoPersId = dr("TgTipoPersId").ToString()
                loPersona.TgTipoPersona = dr("TgTipoPersona").ToString()
                'loPersona.TgTipoDoc = dr("tgTipoDoc").ToString()
                loPersona.PerNDoc = dr("perNdoc").ToString()
                loPersona.TgDocumento = dr("tgDocumento").ToString()
                loPersona.PerDireccion = dr("PerDireccion").ToString()
                'loPersona.PerDepartamento = dr("PerDepartamento").ToString()
                'loPersona.PerProvincia = dr("PerProvincia").ToString()
                'loPersona.PerDistrito = dr("PerDistrito").ToString()
                ListaPersona.Add(loPersona)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Persona Detalle Abono => " + ex.Message, ex)
        End Try
        Return ListaPersona
    End Function
#End Region

End Class
