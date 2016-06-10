Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class PersonaDAO	
#Region "Guardar"
    Public Shared Function guardar(aoPersona As EEPersona) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()

                    Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Persona_pa")
                    db.AddOutParameter(cmd, "perid", DbType.String, 8)
                    db.AddInParameter(cmd, "pernombres", DbType.String, aoPersona.PerNombres)
                    db.AddInParameter(cmd, "perapematerno", DbType.String, aoPersona.PerApeMaterno)
                    db.AddInParameter(cmd, "perapepaterno", DbType.String, aoPersona.PerApePaterno)
                    db.AddInParameter(cmd, "tgtipopersid", DbType.String, aoPersona.TgTipoPersId)
                    db.AddInParameter(cmd, "perrazonsocial", DbType.String, aoPersona.PerRazonSocial)
                    db.AddInParameter(cmd, "tgtipodoc", DbType.String, aoPersona.TgTipoDoc)
                    db.AddInParameter(cmd, "perndoc", DbType.String, aoPersona.PerNDoc)
                    'db.AddInParameter(cmd, "perruc", DbType.String, aoPersona.PerRuc)
                    'db.AddInParameter(cmd, "perdni", DbType.String, aoPersona.PerDni)
                    db.AddInParameter(cmd, "perdireccion", DbType.String, aoPersona.PerDireccion)
                    db.AddInParameter(cmd, "ubgDep", DbType.String, aoPersona.OUbigeo.UbgDep)
                    db.AddInParameter(cmd, "ubgProv", DbType.String, aoPersona.OUbigeo.UbgProv)
                    db.AddInParameter(cmd, "ubgDist", DbType.String, aoPersona.OUbigeo.UbgDist)
                    db.AddInParameter(cmd, "perobservacion", DbType.String, aoPersona.PerObservacion)
                    db.AddInParameter(cmd, "peractivo", DbType.Boolean, aoPersona.PerActivo)
                    db.AddInParameter(cmd, "peridconyuge", DbType.String, aoPersona.PerIdConyuge)
                    db.AddInParameter(cmd, "perRef", DbType.String, aoPersona.PerRef)
                    db.AddInParameter(cmd, "usuid", DbType.Int32, EEComun.UsuIdOnline)
                    db.AddInParameter(cmd, "mac", DbType.String, EEComun.Mac)
                    db.AddInParameter(cmd, "ip", DbType.String, EEComun.IP)
                    db.AddInParameter(cmd, "perFechaNac", DbType.Date, aoPersona.PerFechaNac)
                    db.AddInParameter(cmd, "TgGeneroId", DbType.String, aoPersona.TgGeneroId)

                    db.ExecuteNonQuery(cmd, transaccion)

                    Dim lsPerIdOut As String = db.GetParameterValue(cmd, "perid").ToString()

                    For Each fContacto As EEPersona.EEContacto In aoPersona.ListaContacto
                        cmd = db.GetStoredProcCommand("Insertar_Contacto_pa")
                        db.AddInParameter(cmd, "contdescripcion", DbType.String, fContacto.ContDescripcion)
                        db.AddInParameter(cmd, "tgtipocontid", DbType.String, fContacto.OTablaGeneral.TgCodigo)
                        db.AddInParameter(cmd, "perId", DbType.String, lsPerIdOut)
                        db.AddInParameter(cmd, "usuid", DbType.Int32, EEComun.UsuIdOnline)
                        db.AddInParameter(cmd, "mac", DbType.String, EEComun.Mac)
                        db.AddInParameter(cmd, "ip", DbType.String, EEComun.IP)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception("Guardar Persona Rollback => " + ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar Persona => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Actualizar"
    Public Shared Function actualizar(aoPersona As EEPersona) As Boolean
        Dim transaccion As DbTransaction = Nothing

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()

                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Persona_pa")
                    db.AddInParameter(cmd, "perid", DbType.String, aoPersona.PerId)
                    db.AddInParameter(cmd, "pernombres", DbType.String, aoPersona.PerNombres)
                    db.AddInParameter(cmd, "perapematerno", DbType.String, aoPersona.PerApeMaterno)
                    db.AddInParameter(cmd, "perapepaterno", DbType.String, aoPersona.PerApePaterno)
                    db.AddInParameter(cmd, "tgtipopersid", DbType.String, aoPersona.TgTipoPersId)
                    db.AddInParameter(cmd, "perrazonsocial", DbType.String, aoPersona.PerRazonSocial)
                    db.AddInParameter(cmd, "tgtipodoc", DbType.String, aoPersona.TgTipoDoc)
                    db.AddInParameter(cmd, "perndoc", DbType.String, aoPersona.PerNDoc)
                    'db.AddInParameter(cmd, "perruc", DbType.String, aoPersona.PerRuc)
                    'db.AddInParameter(cmd, "perdni", DbType.String, aoPersona.PerDni)
                    db.AddInParameter(cmd, "perdireccion", DbType.String, aoPersona.PerDireccion)
                    db.AddInParameter(cmd, "ubgDep", DbType.String, aoPersona.OUbigeo.UbgDep)
                    db.AddInParameter(cmd, "ubgProv", DbType.String, aoPersona.OUbigeo.UbgProv)
                    db.AddInParameter(cmd, "ubgDist", DbType.String, aoPersona.OUbigeo.UbgDist)
                    db.AddInParameter(cmd, "perobservacion", DbType.String, aoPersona.PerObservacion)
                    db.AddInParameter(cmd, "peractivo", DbType.Boolean, aoPersona.PerActivo)
                    db.AddInParameter(cmd, "peridconyuge", DbType.String, aoPersona.PerIdConyuge)
                    db.AddInParameter(cmd, "perRef", DbType.String, aoPersona.PerRef)
                    db.AddInParameter(cmd, "perFechaNac", DbType.Date, aoPersona.PerFechaNac)
                    db.AddInParameter(cmd, "TgGeneroId", DbType.String, aoPersona.TgGeneroId)
                    db.ExecuteNonQuery(cmd, transaccion)

                    cmd = db.GetStoredProcCommand("Eliminar_Contacto_XPerId_pa")
                    db.AddInParameter(cmd, "perId", DbType.String, aoPersona.PerId)
                    db.ExecuteNonQuery(cmd, transaccion)

                    For Each fContacto As EEPersona.EEContacto In aoPersona.ListaContacto
                        cmd = db.GetStoredProcCommand("Actualizar_Contacto_pa")
                        db.AddInParameter(cmd, "contdescripcion", DbType.String, fContacto.ContDescripcion)
                        db.AddInParameter(cmd, "tgtipocontid", DbType.String, fContacto.OTablaGeneral.TgCodigo)
                        db.AddInParameter(cmd, "perId", DbType.String, aoPersona.PerId)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Actualizar Persona => " + ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

#Region "Eliminar Persona"
    ''' <summary>
    ''' Elimina Persona Cambiando de estado PerEliminado
    ''' </summary>
    ''' <param name="asPerId">PerId</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function eliminar(ByVal asPerId As String) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("EliminarU_Persona_pa")

            db.AddInParameter(cmd, "perid", DbType.String, asPerId)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar Persona => " & ex.Message, ex)
        End Try
        Return True
    End Function
#End Region

    Public Shared Function Existe_y_creaXtgTipoDoc_y_perNDoc(ByVal aoPersona As EEPersona) As String

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Existe_y_Crea_Persona_XtgTipoDoc_y_perNDoc")

            db.AddInParameter(cmd, "perNDoc", DbType.String, aoPersona.PerNDoc)
            db.AddInParameter(cmd, "tgTipoDoc", DbType.String, aoPersona.TgTipoDoc)
            db.AddInParameter(cmd, "perNombres ", DbType.String, aoPersona.PerNombres)
            db.AddOutParameter(cmd, "perID", DbType.String, 8)
            db.ExecuteNonQuery(cmd)
            Return db.GetParameterValue(cmd, "PerId")
        Catch ex As Exception
            Throw New Exception("Existe y Crea Persona => " & ex.Message, ex)
        End Try
    End Function

End Class
