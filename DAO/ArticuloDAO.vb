Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades
Public Class ArticuloDAO
    Public Shared Function guardar(aoArticulo As EEArticulo) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase()
        ' Dim lsArtIdOut As String = Nothing
        Using conexion As DbConnection = db.CreateConnection()
            Try

                conexion.Open()
                transaccion = conexion.BeginTransaction()
                Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_Articulo_pa")
                db.AddOutParameter(cmd, "artid", DbType.String, 6)
                ' db.AddInParameter(cmd, "artnombre", DbType.String, aoArticulo.ArtNombre)
                db.AddInParameter(cmd, "artdescripcion", DbType.String, aoArticulo.ArtDescripcion)
                db.AddInParameter(cmd, "tgArtGrupoId", DbType.String, aoArticulo.tgArtGrupoId)
                db.AddInParameter(cmd, "artactivo", DbType.Boolean, aoArticulo.ArtActivo)
                db.AddInParameter(cmd, "artcodigo", DbType.String, aoArticulo.ArtCodigo)
                db.AddInParameter(cmd, "tgUMId", DbType.String, aoArticulo.tgUMedidaId)
                db.AddInParameter(cmd, "artUniMinimas", DbType.String, aoArticulo.ArtUMinimas)
                db.ExecuteNonQuery(cmd, transaccion)
                '  Dim lsArtIdOut As String = db.GetParameterValue(cmd, "artid").ToString()

                Dim lsDetIdOut As String = db.GetParameterValue(cmd, "artid").ToString()

                For Each fDetalle As EEArticulo.EEDetalle In aoArticulo.ListaDetalle
                    cmd = db.GetStoredProcCommand("Insertar_TablaGeneral_pa")
                    db.AddInParameter(cmd, "tgDescripcion", DbType.String, fDetalle.OTablaGeneral.TgDescripcion)
                    db.AddInParameter(cmd, "tgAbrev", DbType.String, fDetalle.OTablaGeneral.TgAbrev)
                    db.AddInParameter(cmd, "tgCodigo", DbType.String, lsDetIdOut)
                    db.AddInParameter(cmd, "clsId", DbType.String, fDetalle.OTablaGeneral.OClase.ClsId)
                    db.AddInParameter(cmd, "tgExtra", DbType.String, fDetalle.OTablaGeneral.TgExtra)
                    db.AddInParameter(cmd, "tgNombre", DbType.String, fDetalle.OTablaGeneral.TgNombre)
                    db.AddInParameter(cmd, "tgActivo", DbType.String, fDetalle.OTablaGeneral.TgActivo)

                    db.ExecuteNonQuery(cmd, transaccion)

                Next

                transaccion.Commit()

            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception("Guardar Articulo => " + ex.Message, ex)
            End Try
        End Using
        Return True
    End Function

    Public Shared Function actualizar(aoArticulo As EEArticulo) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_Articulo_pa")
                    db.AddInParameter(cmd, "artid", DbType.String, aoArticulo.ArtId)
                    db.AddInParameter(cmd, "artdescripcion", DbType.String, aoArticulo.ArtDescripcion)
                    db.AddInParameter(cmd, "tgArtGrupoId", DbType.String, aoArticulo.tgArtGrupoId)
                    db.AddInParameter(cmd, "artactivo", DbType.Boolean, aoArticulo.ArtActivo)
                    db.AddInParameter(cmd, "tgUMId", DbType.String, aoArticulo.tgUMedidaId)
                    db.AddInParameter(cmd, "artUniMinimas", DbType.String, aoArticulo.ArtUMinimas)
                    '  db.AddInParameter(cmd, "artcodigo", DbType.String, aoArticulo.ArtCodigo)
                    db.ExecuteNonQuery(cmd, transaccion)

                    cmd = db.GetStoredProcCommand("Eliminar_TablaGeneral_XClsId_tgCodigo_pa")
                    db.AddInParameter(cmd, "clsId", DbType.String, 130)
                    db.AddInParameter(cmd, "tgcodigo", DbType.String, aoArticulo.ArtId)
                    db.ExecuteNonQuery(cmd, transaccion)

                    For Each fDetalle As EEArticulo.EEDetalle In aoArticulo.ListaDetalle
                        cmd = db.GetStoredProcCommand("Insertar_TablaGeneral_pa")
                        db.AddInParameter(cmd, "tgDescripcion", DbType.String, fDetalle.OTablaGeneral.TgDescripcion)
                        db.AddInParameter(cmd, "tgAbrev", DbType.String, fDetalle.OTablaGeneral.TgAbrev)
                        db.AddInParameter(cmd, "tgCodigo", DbType.String, aoArticulo.ArtId)
                        db.AddInParameter(cmd, "clsId", DbType.String, fDetalle.OTablaGeneral.OClase.ClsId)
                        db.AddInParameter(cmd, "tgExtra", DbType.String, fDetalle.OTablaGeneral.TgExtra)
                        db.AddInParameter(cmd, "tgNombre", DbType.String, fDetalle.OTablaGeneral.TgNombre)
                        db.AddInParameter(cmd, "tgActivo", DbType.String, fDetalle.OTablaGeneral.TgActivo)
                        db.ExecuteNonQuery(cmd, transaccion)
                    Next

                    'cmd = db.GetStoredProcCommand("Eliminar_TablaGeneral_XClsId_pa")
                    'db.AddInParameter(cmd, "clsid", DbType.Int32, 130)
                    'db.ExecuteNonQuery(cmd, transaccion)

                    'If aoArticulo.ListaDatosAdicionalesNuevos IsNot Nothing Then
                    '    For Each fTablaGeneral As EETablaGeneral In aoArticulo.ListaDatosAdicionalesNuevos
                    '        cmd = db.GetStoredProcCommand("InsertarU_TablaGeneral_pa")
                    '        db.AddInParameter(cmd, "tgdescripcion", DbType.String, fTablaGeneral.TgDescripcion)
                    '        db.AddInParameter(cmd, "clsid", DbType.Int32, fTablaGeneral.OClase.ClsId)
                    '        db.AddInParameter(cmd, "tgcodigo", DbType.String, fTablaGeneral.TgCodigo)
                    '        db.AddInParameter(cmd, "tgextra", DbType.String, fTablaGeneral.TgExtra)
                    '        db.AddInParameter(cmd, "tgnombre", DbType.String, fTablaGeneral.TgNombre)
                    '        db.AddInParameter(cmd, "tgactivo", DbType.Boolean, fTablaGeneral.TgActivo)
                    '        db.ExecuteNonQuery(cmd, transaccion)
                    '    Next
                    'End If
                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Guardar Articulo => " + ex.Message, ex)
        End Try
        Return True
                
    End Function
End Class