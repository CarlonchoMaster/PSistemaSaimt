Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class MarcacionesDAS
    Public Shared Function listarXTrab(ByVal asFecha1 As String, ByVal asFecha2 As String, ByVal aiCodTrabajador As Int32) As List(Of EEMarcaciones)
        Dim ListaMarcaciones As List(Of EEMarcaciones) = Nothing
        Dim loMarcaciones As EEMarcaciones = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDAsistencia)
            Dim cmd As DbCommand = db.GetStoredProcCommand("ListarMarcacionesXTrab")
            db.AddInParameter(cmd, "Fech1", DbType.String, asFecha1)
            db.AddInParameter(cmd, "Fech2", DbType.String, asFecha2)
            db.AddInParameter(cmd, "CodigoTra", DbType.Int32, aiCodTrabajador)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMarcaciones Is Nothing Then
                    ListaMarcaciones = New List(Of EEMarcaciones)()
                End If

                loMarcaciones = New EEMarcaciones()
                If dr("Num_Marca") Is DBNull.Value Then
                    loMarcaciones.NumMarca = 0
                Else
                    loMarcaciones.NumMarca = Convert.ToInt32(dr("Num_Marca").ToString())
                End If
                If dr("CodTarjeta") Is DBNull.Value Then
                    loMarcaciones.CodTarjeta = String.Empty
                Else
                    loMarcaciones.CodTarjeta = dr("CodTarjeta").ToString()
                End If
                If dr("Trabajador") Is DBNull.Value Then
                    loMarcaciones.Trabajador = String.Empty
                Else
                    loMarcaciones.Trabajador = dr("Trabajador").ToString()
                End If
                If dr("TipoTrabajador") Is DBNull.Value Then
                    loMarcaciones.TipoTrabajador = String.Empty
                Else
                    loMarcaciones.TipoTrabajador = dr("TipoTrabajador").ToString()
                End If
                If dr("UnidadOrg") Is DBNull.Value Then
                    loMarcaciones.UnidadOrg = String.Empty
                Else
                    loMarcaciones.UnidadOrg = dr("UnidadOrg").ToString()
                End If
                If dr("Documento") Is DBNull.Value Then
                    loMarcaciones.Documento = String.Empty
                Else
                    loMarcaciones.Documento = dr("Documento").ToString()
                End If
                If dr("FechaMar") Is DBNull.Value Then
                    loMarcaciones.FechaMar = CDate("01/01/1970")
                Else
                    loMarcaciones.FechaMar = dr("FechaMar").ToString()
                End If
                
                loMarcaciones.Hora = dr("Hora").ToString()
                If dr("CodTrabajador") Is DBNull.Value Then
                    loMarcaciones.CodTrabajador = 0
                Else
                    loMarcaciones.CodTrabajador = Convert.ToInt32(dr("CodTrabajador").ToString())
                End If
                If dr("Incidencia") Is DBNull.Value Then
                    loMarcaciones.Incidencia = String.Empty
                Else
                    loMarcaciones.Incidencia = dr("Incidencia").ToString()
                End If
                If dr("Estado") Is DBNull.Value Then
                    loMarcaciones.Estado = String.Empty
                Else
                    loMarcaciones.Estado = dr("Estado").ToString()
                End If
                If dr("Temprano") Is DBNull.Value Then
                    loMarcaciones.Temprano = String.Empty
                Else
                    loMarcaciones.Temprano = dr("Temprano").ToString()
                End If
                If dr("Tardanza") Is DBNull.Value Then
                    loMarcaciones.Tardanza = String.Empty
                Else
                    loMarcaciones.Tardanza = dr("Tardanza").ToString()
                End If
                If dr("Tipo") Is DBNull.Value Then
                    loMarcaciones.Tipo = String.Empty
                Else
                    loMarcaciones.Tipo = dr("Tipo").ToString()
                End If
                If dr("Obs") Is DBNull.Value Then
                    loMarcaciones.Observacion = String.Empty
                Else
                    loMarcaciones.Observacion = dr("Obs").ToString()
                End If

                ListaMarcaciones.Add(loMarcaciones)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Marcaciones XTrab => " & ex.Message, ex)
        End Try
        Return ListaMarcaciones
    End Function

    Public Shared Function listarXTrabEstado(ByVal asFecha1 As String, ByVal asFecha2 As String, ByVal aiCodTrabajador As Int32, ByVal asEstado As String) As List(Of EEMarcaciones)
        Dim ListaMarcaciones As List(Of EEMarcaciones) = Nothing
        Dim loMarcaciones As EEMarcaciones = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDAsistencia)
            Dim cmd As DbCommand = db.GetStoredProcCommand("ListarMarcacionesXTrabXEst")
            db.AddInParameter(cmd, "Fech1", DbType.String, asFecha1)
            db.AddInParameter(cmd, "Fech2", DbType.String, asFecha2)
            db.AddInParameter(cmd, "CodigoTra", DbType.Int32, aiCodTrabajador)
            db.AddInParameter(cmd, "Estado", DbType.String, asEstado)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaMarcaciones Is Nothing Then
                    ListaMarcaciones = New List(Of EEMarcaciones)()
                End If

                loMarcaciones = New EEMarcaciones()
                loMarcaciones.NumMarca = Convert.ToInt32(dr("Num_Marca").ToString())
                loMarcaciones.CodTarjeta = dr("CodTarjeta").ToString()
                loMarcaciones.Trabajador = dr("Trabajador").ToString()
                loMarcaciones.TipoTrabajador = dr("TipoTrabajador").ToString()
                loMarcaciones.UnidadOrg = dr("UnidadOrg").ToString()
                loMarcaciones.Documento = dr("Documento").ToString()
                loMarcaciones.FechaMar = dr("FechaMar").ToString()
                loMarcaciones.Hora = dr("HoraMar").ToString()
                loMarcaciones.CodTrabajador = Convert.ToInt32(dr("CodTrabajador").ToString())
                loMarcaciones.Incidencia = dr("Incidencia").ToString()
                loMarcaciones.SalidaOficial = Convert.ToDateTime(dr("SalidaOficial").ToString())
                loMarcaciones.DiferenciaMinutos = dr("DiferenciaMin").ToString()
                loMarcaciones.Estado = dr("Estado").ToString()
                loMarcaciones.Temprano = dr("Temprano").ToString()
                loMarcaciones.Tardanza = dr("Tardanza").ToString()
                loMarcaciones.Tipo = dr("Tipo").ToString()
                loMarcaciones.Observacion = dr("Obs").ToString()

                ListaMarcaciones.Add(loMarcaciones)
            End While
        Catch ex As Exception
            Throw New Exception("Listar Marcaciones XTrab => " & ex.Message, ex)
        End Try
        Return ListaMarcaciones
    End Function
End Class
