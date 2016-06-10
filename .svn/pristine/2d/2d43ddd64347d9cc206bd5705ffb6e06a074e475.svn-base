Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class ValidacionDAS

#Region "Validar Longitud Campo"
    ''' <summary>
    ''' Validar
    ''' </summary>
    ''' <param name="asTabla">Nombre Tabla BD</param>
    ''' <param name="asCampo">Campo de Tabla BD</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ValidarCampoLongitud(ByVal asTabla As String, ByVal asCampo As String) As Int16?
        Dim liLongitud As Int16? = Nothing
        Dim drLongitud As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Validar_Longitud_Campos")

            db.AddInParameter(cmd, "tabla", DbType.String, asTabla)
            db.AddInParameter(cmd, "campo", DbType.String, asCampo)

            drLongitud = db.ExecuteReader(cmd)

            While drLongitud.Read
                If IsDBNull(drLongitud("LongitudCampo")) Then
                    liLongitud = Nothing
                Else
                    liLongitud = Convert.ToInt16(drLongitud("LongitudCampo"))
                End If
            End While
            drLongitud.Close()
        Catch ex As Exception
            Throw New Exception("Validar Campo Longitud => " & ex.Message, ex)
        End Try
        Return liLongitud
    End Function
#End Region

#Region "Usuarios"
    ''' <summary>
    ''' Validar Usuario X UsuLogin
    ''' </summary>
    ''' <param name="asUsuLogin">Usuario</param>
    ''' <param name="aiUsuId">0 = Save, > 0 = Update</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function UsuariosValidarXUsuLogin(ByVal asUsuLogin As String, ByVal aiUsuId As Int32) As Boolean
        Dim rpta As Boolean = False
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Valida_Usuarios_XUsuLogin_pa")

            db.AddInParameter(cmd, "usulogin", DbType.String, asUsuLogin)
            db.AddInParameter(cmd, "usuid", DbType.Int32, aiUsuId)
            'db.ExecuteNonQuery(cmd)
            Dim liNumFila As Integer
            liNumFila = CInt(db.ExecuteScalar(cmd))
            If liNumFila = 0 Then
                rpta = True
            End If
        Catch ex As Exception
            Throw New Exception("Validar Usuarios X UsuLogin => " + ex.Message, ex)
        End Try
        Return rpta
    End Function
#End Region

#Region "Recaudacion"
    ''' <summary>
    ''' Validar Recaudacion Detalle
    ''' </summary>
    ''' <param name="aiRecId"></param>
    ''' <param name="adRecFecPago"></param>
    ''' <param name="asTgRecaudadorId"></param>
    ''' <returns>True=No Existe, False = Existe</returns>
    ''' <remarks></remarks>
    Public Shared Function RecaudacionDetalleValidar(ByVal aiRecId As Int32, ByVal adRecFecPago As Date, ByVal asTgRecaudadorId As String, ByVal asConId As String) As Boolean
        Dim rpta As Boolean = False
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Validar_RecaudacionDet_WEB_pa")

            db.AddInParameter(cmd, "recId", DbType.Int32, aiRecId)
            db.AddInParameter(cmd, "recFecPago", DbType.Date, adRecFecPago)
            db.AddInParameter(cmd, "tgRecaudadorId", DbType.String, asTgRecaudadorId)
            db.AddInParameter(cmd, "conid", DbType.String, asConId)

            Dim liNumFila As Integer
            liNumFila = CInt(db.ExecuteScalar(cmd))
            If liNumFila = 0 Then
                rpta = True
            End If
        Catch ex As Exception
            Throw New Exception("Validar Recaudacion Detalle => " + ex.Message, ex)
        End Try
        Return rpta
    End Function
#End Region

#Region "Persona"
    ''' <summary>
    ''' PERSONA VALIDAR X
    ''' </summary>
    ''' <param name="asPerId"></param>
    ''' <param name="asPerNDoc"></param>
    ''' <param name="asSaveUpdate"></param>
    ''' <returns>TRUE = SI NO EXISTE</returns>
    ''' <remarks></remarks>
    Public Shared Function PersonaValidarXPerNDoc(ByVal asPerId As String, ByVal asTgTipoDoc As String, ByVal asPerNDoc As String, ByVal asSaveUpdate As String) As Boolean
        Dim rpta As Boolean = False
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Validar_Persona_XPerNDoc_pa")

            db.AddInParameter(cmd, "perid", DbType.String, asPerId)
            db.AddInParameter(cmd, "tgtipodoc", DbType.String, asTgTipoDoc)
            db.AddInParameter(cmd, "perndoc", DbType.String, asPerNDoc)
            db.AddInParameter(cmd, "saveoupdate", DbType.String, asSaveUpdate)

            Dim liNumFila As Integer
            liNumFila = CInt(db.ExecuteScalar(cmd))
            If liNumFila = 0 Then
                rpta = True
            End If
        Catch ex As Exception
            Throw New Exception("Validar Persona X PerNDoc => " + ex.Message, ex)
        End Try
        Return rpta
    End Function

    Public Shared Function PersonaValidarXNombresORazon(ByVal asPerId As String, ByVal asPerNombresORazon As String, ByVal asTipoPersona As String, ByVal asSaveUpdate As String) As Boolean
        Dim rpta As Boolean = False
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Validar_Persona_XNombresORazon_pa")

            db.AddInParameter(cmd, "perid", DbType.String, asPerId)
            db.AddInParameter(cmd, "pernombresorazon", DbType.String, asPerNombresORazon)
            db.AddInParameter(cmd, "tipopersona", DbType.String, asTipoPersona)
            db.AddInParameter(cmd, "saveoupdate", DbType.String, asSaveUpdate)

            Dim liNumFila As Integer
            liNumFila = CInt(db.ExecuteScalar(cmd))
            If liNumFila = 0 Then
                rpta = True
            End If
        Catch ex As Exception
            Throw New Exception("Validar Persona X Nombres o Razon => " + ex.Message, ex)
        End Try
        Return rpta
    End Function
#End Region

#Region "NivelesPEM"
    ''' <summary>
    ''' Validar NivelesPEM X NivNombre,Institucion,Sede
    ''' </summary>
    ''' <param name="asInstitucion"></param>
    ''' <param name="asSede"></param>
    ''' <param name="asNombre"></param>
    ''' <param name="asId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function NivelesPEMValidarXInstitucionSedeNombre(ByVal asInstitucion As String, ByVal asSede As String, ByVal asNombre As String, ByVal asId As String, ByVal asSU As String) As Boolean
        Dim rpta As Boolean = False
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Validar_NivelesPEM_X_Institucion_Sede_Nombre_pa")

            db.AddInParameter(cmd, "tgInstitucionId", DbType.String, asInstitucion)
            db.AddInParameter(cmd, "tgSedeId", DbType.String, asSede)
            db.AddInParameter(cmd, "nivNombre", DbType.String, asNombre)
            db.AddInParameter(cmd, "nivid", DbType.String, asId)
            db.AddInParameter(cmd, "saveOupdate", DbType.String, asSU)

            Dim liNumFila As Integer
            liNumFila = CInt(db.ExecuteScalar(cmd))
            If liNumFila = 0 Then
                rpta = True
            End If
        Catch ex As Exception
            Throw New Exception("Validar NivelesPEM X NivNombre,Institucion,Sede=> " + ex.Message, ex)
        End Try
        Return rpta
    End Function

    Public Shared Function NivelesPEMValidarXNroPisoInicio(ByVal aiNroPisoInicio As Int16, ByVal asId As String, ByVal asSU As String) As Boolean
        Dim rpta As Boolean = False
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Validar_NivelesPEM_XNivEspInicio_pa")

            db.AddInParameter(cmd, "nivespinicio", DbType.Int16, aiNroPisoInicio)
            db.AddInParameter(cmd, "nivid", DbType.String, asId)
            db.AddInParameter(cmd, "saveOupdate", DbType.String, asSU)

            Dim liNumFila As Integer
            liNumFila = CInt(db.ExecuteScalar(cmd))
            If liNumFila = 0 Then
                rpta = True
            End If
        Catch ex As Exception
            Throw New Exception("Validar NivelesPEM X NroPisoInicio=> " + ex.Message, ex)
        End Try
        Return rpta
    End Function
#End Region
End Class
