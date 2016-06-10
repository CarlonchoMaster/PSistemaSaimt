Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class PartidaDetalleDAO
    Public Shared Function guardar(ByVal aoPartidaDetalle As EEPartidaDetalle) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_PartidaDetalle_pa")

            db.AddInParameter(cmd, "partid", DbType.String, aoPartidaDetalle.PartId)
            db.AddInParameter(cmd, "partdde", DbType.String, aoPartidaDetalle.PartDDe)
            db.AddInParameter(cmd, "partdpara", DbType.String, aoPartidaDetalle.PartDPara)
            db.AddInParameter(cmd, "partdaño", DbType.String, aoPartidaDetalle.PartAño)
            db.AddInParameter(cmd, "partdmonto", DbType.Decimal, aoPartidaDetalle.PartDMonto)
            db.AddInParameter(cmd, "partddocref", DbType.String, aoPartidaDetalle.PartDDocRef)
            db.AddInParameter(cmd, "partdfechaaprueba", DbType.DateTime, aoPartidaDetalle.PartDFechaAprueba)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Guardar PartidaDetalle => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal aoPartidaDetalle As EEPartidaDetalle) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_PartidaDetalle_pa")

            db.AddInParameter(cmd, "partDid", DbType.String, aoPartidaDetalle.PartDId)
            db.AddInParameter(cmd, "partid", DbType.String, aoPartidaDetalle.PartId)
            db.AddInParameter(cmd, "partdde", DbType.String, aoPartidaDetalle.PartDDe)
            db.AddInParameter(cmd, "partdpara", DbType.String, aoPartidaDetalle.PartDPara)
            db.AddInParameter(cmd, "partdaño", DbType.String, aoPartidaDetalle.PartAño)
            db.AddInParameter(cmd, "partdmonto", DbType.Decimal, aoPartidaDetalle.PartDMonto)
            db.AddInParameter(cmd, "partddocref", DbType.String, aoPartidaDetalle.PartDDocRef)
            db.AddInParameter(cmd, "partdfechaaprueba", DbType.DateTime, aoPartidaDetalle.PartDFechaAprueba)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Actualizar PartidaDetalle => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(ByVal aiIdPartidaDetalle As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_PartidaDetalle_pa")

            db.AddInParameter(cmd, "idPartidaDetalle", DbType.Int32, aiIdPartidaDetalle)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar PartidaDetalle => " & ex.Message, ex)
        End Try
        Return True
    End Function
End Class



