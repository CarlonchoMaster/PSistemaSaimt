﻿Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common

Public Class InmuebleDAS
#Region "Altas"

    Public Shared Function GenerarCodigoInmFile(ByVal tgRubroId As [String]) As String
        Dim InmFile As String = String.Empty
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Inmueble_File_XTgRubroId")
            db.AddInParameter(cmd, "tgRubroId", DbType.String, tgRubroId)

            drInmueble = db.ExecuteReader(cmd)
            If drInmueble.Read() Then
                InmFile = drInmueble("InmFile").ToString()
            End If
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Genera Codigo File x tgRubroId => " & ex.Message, ex)
        End Try
        Return InmFile
    End Function


    Public Shared Function GenerarCodigoInmId() As String
        Dim InmFile As String = String.Empty
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Genera_Codigo_Inmueble_InmId")

            drInmueble = db.ExecuteReader(cmd)
            If drInmueble.Read() Then
                InmFile = drInmueble("InmId").ToString()
            End If
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Genera Codigo InmuebleId o Codigo Informatico => " & ex.Message, ex)
        End Try
        Return InmFile
    End Function
#End Region


    Public Shared Function listarBajas() As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Bajas_pa")
            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Busquedas Bajas => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function

    Public Shared Function listarBajas_BCriterios(Optional ByVal tgRubroId As String = Nothing, Optional ByVal tgGRubroId As String = Nothing, Optional ByVal file As String = Nothing, Optional ByVal fileA As String = Nothing, Optional ByVal direccion As String = Nothing, Optional ByVal inmId As String = Nothing, Optional ByVal inmDenominacion As String = Nothing) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Bajas_BCriterios_pa")
            If tgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, tgRubroId)
            End If
            If tgGRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, tgGRubroId)
            End If
            If file IsNot Nothing Then
                db.AddInParameter(cmd, "file", DbType.String, file)
            End If
            If fileA IsNot Nothing Then
                db.AddInParameter(cmd, "fileA", DbType.String, fileA)
            End If
            If direccion IsNot Nothing Then
                db.AddInParameter(cmd, "direccion", DbType.String, direccion)
            End If
            If inmDenominacion IsNot Nothing Then
                db.AddInParameter(cmd, "inmDenominacion", DbType.String, inmDenominacion)
            End If
            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Busquedas Bajas => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function


    Public Shared Function listarAltasMargesi_BCriterios(Optional ByVal tgRubroId As String = Nothing, Optional ByVal tgGRubroId As String = Nothing, Optional ByVal direccion As String = Nothing) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_InmuebleAltasMargesi_BCriterios_pa")
            If tgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, tgRubroId)
            End If
            If tgGRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, tgGRubroId)
            End If
            If direccion IsNot Nothing Then
                db.AddInParameter(cmd, "direccion", DbType.String, direccion)
            End If

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Busquedas Altas => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function

    Public Shared Function listarAltas() As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Altas_pa")

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Busquedas Altas => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function
#Region "Listar Criterio"
    Public Shared Function listarTrasnferidoBCriterio(Optional ByVal tgRubroId As String = Nothing, Optional ByVal tgGRubroId As String = Nothing, Optional ByVal file As String = Nothing, Optional ByVal fileA As String = Nothing, Optional ByVal direccion As String = Nothing, Optional ByVal inmId As String = Nothing, Optional ByVal inmDenominacion As String = Nothing) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Trasferencia_propiedad_BCriterio_pa")
            If tgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, tgRubroId)
            End If
            If tgGRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, tgGRubroId)
            End If
            If file IsNot Nothing Then
                db.AddInParameter(cmd, "file", DbType.String, file)
            End If
            If fileA IsNot Nothing Then
                db.AddInParameter(cmd, "fileA", DbType.String, fileA)
            End If
            If direccion IsNot Nothing Then
                db.AddInParameter(cmd, "direccion", DbType.String, direccion)
            End If
            If inmId IsNot Nothing Then
                db.AddInParameter(cmd, "inmId", DbType.String, inmId)
            End If
            If inmDenominacion IsNot Nothing Then
                db.AddInParameter(cmd, "inmDenominacion", DbType.String, inmDenominacion)
            End If
            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Busquedas Transferencia de Propiedad Inmueble => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function

    Public Shared Function listarBCriterio(Optional ByVal tgRubroId As String = Nothing, Optional ByVal tgGRubroId As String = Nothing, Optional ByVal file As String = Nothing, Optional ByVal fileA As String = Nothing, Optional ByVal direccion As String = Nothing, Optional ByVal inmId As String = Nothing, Optional ByVal inmDenominacion As String = Nothing, Optional ByVal tgInmEstado As String = Nothing, Optional ByVal ntgInmEstado As String = Nothing) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_BCriterio_pa")
            If tgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, tgRubroId)
            End If
            If tgGRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, tgGRubroId)
            End If
            If file IsNot Nothing Then
                db.AddInParameter(cmd, "file", DbType.String, file)
            End If
            If fileA IsNot Nothing Then
                db.AddInParameter(cmd, "fileA", DbType.String, fileA)
            End If
            If direccion IsNot Nothing Then
                db.AddInParameter(cmd, "direccion", DbType.String, direccion)
            End If
            If inmId IsNot Nothing Then
                db.AddInParameter(cmd, "inmId", DbType.String, inmId)
            End If
            If inmDenominacion IsNot Nothing Then
                db.AddInParameter(cmd, "inmDenominacion", DbType.String, inmDenominacion)
            End If
            If tgInmEstado IsNot Nothing Then
                db.AddInParameter(cmd, "tgInmEstado", DbType.String, tgInmEstado)
            End If
            If ntgInmEstado IsNot Nothing Then
                db.AddInParameter(cmd, "NtgInmEstado", DbType.String, ntgInmEstado)
            End If

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                loInmueble.tgTipoIngreso = drInmueble("tgTipoIngreso").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Busquedas Inmueble => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function

    Public Shared Function listarAltaBCriterio(Optional ByVal perRegID As String = Nothing, Optional ByVal tgRubroId As String = Nothing, Optional ByVal tgGRubroId As String = Nothing, Optional ByVal direccion As String = Nothing) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_InmuebleAlta_BCriterio_pa")

            If perRegID IsNot Nothing Then
                db.AddInParameter(cmd, "perRegId", DbType.String, perRegID)
            End If

            If tgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, tgRubroId)
            End If
            If tgGRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, tgGRubroId)
            End If

            If direccion IsNot Nothing Then
                db.AddInParameter(cmd, "direccion", DbType.String, direccion)
            End If

            'If tgInmEstado IsNot Nothing Then
            '    db.AddInParameter(cmd, "tgInmEstado", DbType.String, tgInmEstado)
            'End If
            'If ntgInmEstado IsNot Nothing Then
            '    db.AddInParameter(cmd, "NtgInmEstado", DbType.String, ntgInmEstado)
            'End If

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                loInmueble.UsuarioRegAlta = drInmueble("UsuarioRegAlta").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Busquedas Inmueble => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function
    Public Shared Function listarConsultaCriterioWebDireccion(ByVal aoInmueble As EEInmueble) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_ConsultasWeb_Direccion_Criterios_pa")
            If aoInmueble.TgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, aoInmueble.TgRubroId)
            End If
            If aoInmueble.TgRubroGrupoId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, aoInmueble.TgRubroGrupoId)
            End If
            If aoInmueble.TgInmEstado IsNot Nothing Then
                db.AddInParameter(cmd, "TgInmEstadoId", DbType.String, aoInmueble.TgInmEstado)
            Else
                db.AddInParameter(cmd, "NTgInmEstadoId", DbType.String, "01")
            End If

            If aoInmueble.OInmDireccion IsNot Nothing Then
                If aoInmueble.OInmDireccion.TgLocalizacionId IsNot Nothing Then
                    db.AddInParameter(cmd, "tglocalizacionId", DbType.String, aoInmueble.OInmDireccion.TgLocalizacionId)
                End If
                If aoInmueble.OInmDireccion.InmDirLocalizacion IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirLocalizacion", DbType.String, aoInmueble.OInmDireccion.InmDirLocalizacion)
                End If
                If aoInmueble.OInmDireccion.TgNroId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgnroId", DbType.String, aoInmueble.OInmDireccion.TgNroId)
                End If
                If aoInmueble.OInmDireccion.InmDirNro IsNot Nothing Then
                    db.AddInParameter(cmd, "nro", DbType.String, aoInmueble.OInmDireccion.InmDirNro)
                End If
                If aoInmueble.OInmDireccion.TgSubNroId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgsubnroId", DbType.String, aoInmueble.OInmDireccion.TgSubNroId)
                End If
                If aoInmueble.OInmDireccion.InmDirSubNro IsNot Nothing Then
                    db.AddInParameter(cmd, "subnro", DbType.String, aoInmueble.OInmDireccion.InmDirSubNro)
                End If
                If aoInmueble.OInmDireccion.TgSubDistritosId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgSubDistritosId", DbType.String, aoInmueble.OInmDireccion.TgSubDistritosId)
                End If
                If aoInmueble.OInmDireccion.InmDirSubDistritos IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirSubDistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                End If
                If aoInmueble.OInmDireccion.InmDirEtapa IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirEtapa", DbType.String, aoInmueble.OInmDireccion.InmDirEtapa)
                End If
                If aoInmueble.OInmDireccion.InmDirBarrio IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirBarrio", DbType.String, aoInmueble.OInmDireccion.InmDirBarrio)
                End If
                If aoInmueble.OInmDireccion.InmDirSector IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirSector", DbType.String, aoInmueble.OInmDireccion.InmDirSector)
                End If
                If aoInmueble.OInmDireccion.UbgId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgDPDId", DbType.String, aoInmueble.OInmDireccion.UbgId)
                End If
                If aoInmueble.OInmDireccion.InmDirAdicional IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirAdicional", DbType.String, aoInmueble.OInmDireccion.InmDirAdicional)
                End If
                If aoInmueble.OInmDireccion.InmDirReferencia IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirReferencia", DbType.String, aoInmueble.OInmDireccion.InmDirReferencia)
                End If
            End If

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.InmFile = drInmueble("inmFile").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                loInmueble.TgRubroGrupo = drInmueble("tgGRubro").ToString()
                loInmueble.OInmDireccion = New EEInmDireccion
                loInmueble.OInmDireccion.OUbigeo = New EEUbigeo
                loInmueble.OInmDireccion.OUbigeo.UbgDistNombre = drInmueble("UbgDistrito").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Consultas Inmueble web Direccion=> " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function


    Public Shared Function listarConsultaAltasyBajas(ByVal tipo As String, ByVal tgGRubroId As String, ByVal tgRubroId As String, Optional ByVal inicio As Date = Nothing, Optional ByVal fin As Date = Nothing, Optional ByVal inmFile As String = Nothing, Optional ByVal inmFileAnt As String = Nothing) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Consultas_AltasyBajas_pa")
            db.AddInParameter(cmd, "tipo", DbType.String, tipo)
            If tgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, tgRubroId)
            End If
            If tgGRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, tgGRubroId)
            End If
            If inicio <> "#12:00:00 AM#" Then
                db.AddInParameter(cmd, "fechaInicio", DbType.Date, inicio)
            End If
            If fin <> "#12:00:00 AM#" Then
                db.AddInParameter(cmd, "fechaFin", DbType.Date, fin)
            End If
            If inmFile IsNot Nothing Then
                db.AddInParameter(cmd, "inmFile", DbType.String, inmFile)
            End If
            If inmFileAnt IsNot Nothing Then
                db.AddInParameter(cmd, "inmFileAnt", DbType.String, inmFileAnt)
            End If
            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmFile = drInmueble("inmFileRubro").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                loInmueble.InmTipoActualizacion = drInmueble("InmTipoActualizacion").ToString()
                loInmueble.InmCausalAltaoBaja = drInmueble("InmCausal").ToString()
                loInmueble.InmFechaAltaoBaja = drInmueble("InmFechaAltaoBaja").ToString()
                loInmueble.InmDocAltaoBaja = drInmueble("InmDocAltaoBaja").ToString()
                loInmueble.InmObservacionAltaoBaja = drInmueble("InmObservacionAltaoBaja").ToString()
                loInmueble.InmDatoAdicionalAltaoBaja = drInmueble("InmDatoAdicionalAltaoBaja").ToString()

                loInmueble.OInmPredio = New EEInmPredio
                If IsDBNull(drInmueble("inmPredArea")) = False Then
                    loInmueble.OInmPredio.InmPredArea = Convert.ToDecimal(drInmueble("inmPredArea"))
                End If
                loInmueble.OInmValorComercial = New EEInmValorComercial
                If IsDBNull(drInmueble("inmValComValTotal")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTotal = Convert.ToDecimal(drInmueble("inmValComValTotal"))
                End If

                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Consultas Inmueble => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function
    Public Shared Function listarConsultaCriterioxItem(ByVal tipocriterio As String, ByVal aoInmueble As EEInmueble) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Consultas_CriterioxItem_pa")
            db.AddInParameter(cmd, "tipocriterio", DbType.String, tipocriterio)
            If aoInmueble.TgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, aoInmueble.TgRubroId)
            End If
            If aoInmueble.TgRubroGrupoId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, aoInmueble.TgRubroGrupoId)
            End If
            If aoInmueble.InmFile IsNot Nothing Then
                db.AddInParameter(cmd, "file", DbType.String, aoInmueble.InmFile)
            End If
            If aoInmueble.InmFileAnt IsNot Nothing Then
                db.AddInParameter(cmd, "fileA", DbType.String, aoInmueble.InmFileAnt)
            End If
            If aoInmueble.TgInmEstado IsNot Nothing Then
                db.AddInParameter(cmd, "TgInmEstadoId", DbType.String, aoInmueble.TgInmEstado)
            Else
                db.AddInParameter(cmd, "NTgInmEstadoId", DbType.String, "01")
            End If

            If aoInmueble.TgInmEstado2 IsNot Nothing Then
                db.AddInParameter(cmd, "TgInmEstadoId2", DbType.String, aoInmueble.TgInmEstado2)
            End If

            If aoInmueble.tgInmCondRegId IsNot Nothing Then
                db.AddInParameter(cmd, "tgInmCondRegId", DbType.String, aoInmueble.tgInmCondRegId)
            End If

            If aoInmueble.InmPartidaElec IsNot Nothing Then
                db.AddInParameter(cmd, "InmPartidaElec", DbType.String, aoInmueble.InmPartidaElec)
            End If

            If aoInmueble.TgInmCondLegalId IsNot Nothing Then
                db.AddInParameter(cmd, "TgInmCondLegalId", DbType.String, aoInmueble.TgInmCondLegalId)
            End If

            If aoInmueble.TgEstSanId IsNot Nothing Then
                db.AddInParameter(cmd, "TgEstSanId", DbType.String, aoInmueble.TgEstSanId)
            End If

            If aoInmueble.tgInmSitFisicaId IsNot Nothing Then
                db.AddInParameter(cmd, "tgInmSitFisicaId", DbType.String, aoInmueble.tgInmSitFisicaId)
            End If

            If aoInmueble.tgEstInmConsvId IsNot Nothing Then
                db.AddInParameter(cmd, "tgEstInmConsvId", DbType.String, aoInmueble.tgEstInmConsvId)
            End If

            If aoInmueble.tgInmSFZonificacionId IsNot Nothing Then
                db.AddInParameter(cmd, "tgInmSFZonificacionId", DbType.String, aoInmueble.tgInmSFZonificacionId)
            End If

            If aoInmueble.InmDenominacion IsNot Nothing Then
                db.AddInParameter(cmd, "InmDenominacion", DbType.String, aoInmueble.InmDenominacion)
            End If
            If aoInmueble.InmDisponibilidad IsNot Nothing Then
                db.AddInParameter(cmd, "InmDisponibilidad", DbType.Boolean, aoInmueble.InmDisponibilidad)
            End If
            If aoInmueble.OInmDireccion IsNot Nothing Then
                If aoInmueble.OInmDireccion.TgLocalizacionId IsNot Nothing Then
                    db.AddInParameter(cmd, "tglocalizacionId", DbType.String, aoInmueble.OInmDireccion.TgLocalizacionId)
                End If
                If aoInmueble.OInmDireccion.InmDirLocalizacion IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirLocalizacion", DbType.String, aoInmueble.OInmDireccion.InmDirLocalizacion)
                End If
                If aoInmueble.OInmDireccion.TgNroId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgnroId", DbType.String, aoInmueble.OInmDireccion.TgNroId)
                End If
                If aoInmueble.OInmDireccion.InmDirNro IsNot Nothing Then
                    db.AddInParameter(cmd, "nro", DbType.String, aoInmueble.OInmDireccion.InmDirNro)
                End If
                If aoInmueble.OInmDireccion.TgSubNroId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgsubnroId", DbType.String, aoInmueble.OInmDireccion.TgSubNroId)
                End If
                If aoInmueble.OInmDireccion.InmDirSubNro IsNot Nothing Then
                    db.AddInParameter(cmd, "subnro", DbType.String, aoInmueble.OInmDireccion.InmDirSubNro)
                End If
                If aoInmueble.OInmDireccion.TgSubDistritosId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgSubDistritosId", DbType.String, aoInmueble.OInmDireccion.TgSubDistritosId)
                End If
                If aoInmueble.OInmDireccion.InmDirSubDistritos IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirSubDistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                End If
                'If aoInmueble.OInmDireccion.InmDirSubDistritos IsNot Nothing Then
                '    db.AddInParameter(cmd, "InmDirSubDistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                'End If
                If aoInmueble.OInmDireccion.InmDirEtapa IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirEtapa", DbType.String, aoInmueble.OInmDireccion.InmDirEtapa)
                End If
                If aoInmueble.OInmDireccion.InmDirBarrio IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirBarrio", DbType.String, aoInmueble.OInmDireccion.InmDirBarrio)
                End If
                If aoInmueble.OInmDireccion.InmDirSector IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirSector", DbType.String, aoInmueble.OInmDireccion.InmDirSector)
                End If
                If aoInmueble.OInmDireccion.UbgId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgDPDId", DbType.String, aoInmueble.OInmDireccion.UbgId)
                End If
                If aoInmueble.OInmDireccion.InmDirAdicional IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirAdicional", DbType.String, aoInmueble.OInmDireccion.InmDirAdicional)
                End If
                If aoInmueble.OInmDireccion.InmDirReferencia IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirReferencia", DbType.String, aoInmueble.OInmDireccion.InmDirReferencia)
                End If
            End If

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmFile = drInmueble("inmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("inmFileAnt").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                loInmueble.InmInscrito = drInmueble("inmInscrito").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.tgInmCondReg = drInmueble("tgInmCondReg").ToString()
                loInmueble.InmPartidaElec = drInmueble("inmPartidaElec").ToString()
                loInmueble.TgInmCondLegal = drInmueble("tgInmCondLegal").ToString()
                loInmueble.tgEstSan = drInmueble("tgEstSan").ToString()
                loInmueble.tgInmSitFisica = drInmueble("tgInmSitFisica").ToString()
                loInmueble.TgRubro = drInmueble("tgRubro").ToString()
                loInmueble.OInmPredio = New EEInmPredio
                If IsDBNull(drInmueble("InmPredArea")) = False Then
                    loInmueble.OInmPredio.InmPredArea = Convert.ToDecimal(drInmueble("InmPredArea").ToString())
                End If
                loInmueble.OInmValorComercial = New EEInmValorComercial
                If IsDBNull(drInmueble("inmValComValxMetro")) = False Then
                    loInmueble.OInmValorComercial.InmValComValxMetro = Convert.ToDecimal(drInmueble("inmValComValxMetro"))
                End If
                If IsDBNull(drInmueble("inmValComValConst")) = False Then
                    loInmueble.OInmValorComercial.InmValComValConst = Convert.ToDecimal(drInmueble("inmValComValConst"))
                End If
                If IsDBNull(drInmueble("inmValComValTerreno")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTerreno = Convert.ToDecimal(drInmueble("inmValComValTerreno"))
                End If
                If IsDBNull(drInmueble("inmValComValTotal")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTotal = Convert.ToDecimal(drInmueble("inmValComValTotal"))
                End If
                loInmueble.tgInmSFUso = drInmueble("tgInmSFUso").ToString()
                loInmueble.tgEstInmConsv = drInmueble("tgEstInmConsv").ToString()
                loInmueble.InmDisponibilidad = drInmueble("inmDisponibilidad").ToString()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.TgInmEstado = drInmueble("tgInmEstado").ToString()
                loInmueble.inmSaneadoObsMostrable = drInmueble("inmSaneadoObsMostrable").ToString()
                If IsDBNull(drInmueble("InmArch")) = False Then
                    loInmueble.InmArchPrincipal = DirectCast(drInmueble("InmArch"), Byte())
                End If


                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Consultas Inmueble => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function
    Public Shared Function listarConsultaImgCriterio(ByVal tipocriterio As String, ByVal aoInmueble As EEInmueble) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_ConsultasImg_Criterio_pa")
            db.AddInParameter(cmd, "tipocriterio", DbType.String, tipocriterio)
            If aoInmueble.TgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, aoInmueble.TgRubroId)
            End If
            If aoInmueble.TgRubroGrupoId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, aoInmueble.TgRubroGrupoId)
            End If
            If aoInmueble.InmFile IsNot Nothing Then
                db.AddInParameter(cmd, "file", DbType.String, aoInmueble.InmFile)
            End If
            If aoInmueble.InmFileAnt IsNot Nothing Then
                db.AddInParameter(cmd, "fileA", DbType.String, aoInmueble.InmFileAnt)
            End If
            If aoInmueble.TgInmEstado IsNot Nothing Then
                db.AddInParameter(cmd, "TgInmEstadoId", DbType.String, aoInmueble.TgInmEstado)
            Else
                db.AddInParameter(cmd, "NTgInmEstadoId", DbType.String, "01")
            End If

            If aoInmueble.tgInmCondRegId IsNot Nothing Then
                db.AddInParameter(cmd, "tgInmCondRegId", DbType.String, aoInmueble.tgInmCondRegId)
            End If

            If aoInmueble.InmPartidaElec IsNot Nothing Then
                db.AddInParameter(cmd, "InmPartidaElec", DbType.String, aoInmueble.InmPartidaElec)
            End If

            If aoInmueble.TgInmCondLegalId IsNot Nothing Then
                db.AddInParameter(cmd, "TgInmCondLegalId", DbType.String, aoInmueble.TgInmCondLegalId)
            End If

            If aoInmueble.TgEstSanId IsNot Nothing Then
                db.AddInParameter(cmd, "TgEstSanId", DbType.String, aoInmueble.TgEstSanId)
            End If

            If aoInmueble.tgInmSitFisicaId IsNot Nothing Then
                db.AddInParameter(cmd, "tgInmSitFisicaId", DbType.String, aoInmueble.tgInmSitFisicaId)
            End If

            If aoInmueble.tgEstInmConsvId IsNot Nothing Then
                db.AddInParameter(cmd, "tgEstInmConsvId", DbType.String, aoInmueble.tgEstInmConsvId)
            End If

            If aoInmueble.tgInmSFZonificacionId IsNot Nothing Then
                db.AddInParameter(cmd, "tgInmSFZonificacionId", DbType.String, aoInmueble.tgInmSFZonificacionId)
            End If

            If aoInmueble.InmDenominacion IsNot Nothing Then
                db.AddInParameter(cmd, "InmDenominacion", DbType.String, aoInmueble.InmDenominacion)
            End If
            If aoInmueble.InmDisponibilidad IsNot Nothing Then
                db.AddInParameter(cmd, "InmDisponibilidad", DbType.Boolean, aoInmueble.InmDisponibilidad)
            End If
            If aoInmueble.OInmDireccion IsNot Nothing Then
                If aoInmueble.OInmDireccion.TgLocalizacionId IsNot Nothing Then
                    db.AddInParameter(cmd, "tglocalizacionId", DbType.String, aoInmueble.OInmDireccion.TgLocalizacionId)
                End If
                If aoInmueble.OInmDireccion.InmDirLocalizacion IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirLocalizacion", DbType.String, aoInmueble.OInmDireccion.InmDirLocalizacion)
                End If
                If aoInmueble.OInmDireccion.TgNroId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgnroId", DbType.String, aoInmueble.OInmDireccion.TgNroId)
                End If
                If aoInmueble.OInmDireccion.InmDirNro IsNot Nothing Then
                    db.AddInParameter(cmd, "nro", DbType.String, aoInmueble.OInmDireccion.InmDirNro)
                End If
                If aoInmueble.OInmDireccion.TgSubNroId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgsubnroId", DbType.String, aoInmueble.OInmDireccion.TgSubNroId)
                End If
                If aoInmueble.OInmDireccion.InmDirSubNro IsNot Nothing Then
                    db.AddInParameter(cmd, "subnro", DbType.String, aoInmueble.OInmDireccion.InmDirSubNro)
                End If
                If aoInmueble.OInmDireccion.TgSubDistritosId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgSubDistritosId", DbType.String, aoInmueble.OInmDireccion.TgSubDistritosId)
                End If
                If aoInmueble.OInmDireccion.InmDirSubDistritos IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirSubDistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                End If
                'If aoInmueble.OInmDireccion.InmDirSubDistritos IsNot Nothing Then
                '    db.AddInParameter(cmd, "InmDirSubDistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                'End If
                If aoInmueble.OInmDireccion.InmDirEtapa IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirEtapa", DbType.String, aoInmueble.OInmDireccion.InmDirEtapa)
                End If
                If aoInmueble.OInmDireccion.InmDirBarrio IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirBarrio", DbType.String, aoInmueble.OInmDireccion.InmDirBarrio)
                End If
                If aoInmueble.OInmDireccion.InmDirSector IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirSector", DbType.String, aoInmueble.OInmDireccion.InmDirSector)
                End If
                If aoInmueble.OInmDireccion.UbgId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgDPDId", DbType.String, aoInmueble.OInmDireccion.UbgId)
                End If
                If aoInmueble.OInmDireccion.InmDirAdicional IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirAdicional", DbType.String, aoInmueble.OInmDireccion.InmDirAdicional)
                End If
                If aoInmueble.OInmDireccion.InmDirReferencia IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirReferencia", DbType.String, aoInmueble.OInmDireccion.InmDirReferencia)
                End If
            End If

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmFile = drInmueble("inmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("inmFileAnt").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                loInmueble.InmInscrito = drInmueble("inmInscrito").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.tgInmCondReg = drInmueble("tgInmCondReg").ToString()
                loInmueble.InmPartidaElec = drInmueble("inmPartidaElec").ToString()
                loInmueble.TgInmCondLegal = drInmueble("tgInmCondLegal").ToString()
                loInmueble.tgEstSan = drInmueble("tgEstSan").ToString()
                loInmueble.tgInmSitFisica = drInmueble("tgInmSitFisica").ToString()
                loInmueble.TgRubro = drInmueble("tgRubro").ToString()
                If IsDBNull(drInmueble("InmArch")) = False Then
                    loInmueble.InmArchPrincipal = DirectCast(drInmueble("InmArch"), Byte())
                End If
                loInmueble.OInmPredio = New EEInmPredio
                If IsDBNull(drInmueble("InmPredArea")) = False Then
                    loInmueble.OInmPredio.InmPredArea = Convert.ToDecimal(drInmueble("InmPredArea").ToString())
                End If
                loInmueble.OInmValorComercial = New EEInmValorComercial
                If IsDBNull(drInmueble("inmValComValxMetro")) = False Then
                    loInmueble.OInmValorComercial.InmValComValxMetro = Convert.ToDecimal(drInmueble("inmValComValxMetro"))
                End If
                If IsDBNull(drInmueble("inmValComValConst")) = False Then
                    loInmueble.OInmValorComercial.InmValComValConst = Convert.ToDecimal(drInmueble("inmValComValConst"))
                End If
                If IsDBNull(drInmueble("inmValComValTerreno")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTerreno = Convert.ToDecimal(drInmueble("inmValComValTerreno"))
                End If
                If IsDBNull(drInmueble("inmValComValTotal")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTotal = Convert.ToDecimal(drInmueble("inmValComValTotal"))
                End If
                loInmueble.tgInmSFUso = drInmueble("tgInmSFUso").ToString()
                loInmueble.tgEstInmConsv = drInmueble("tgEstInmConsv").ToString()
                loInmueble.InmDisponibilidad = drInmueble("inmDisponibilidad").ToString()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.TgInmEstado = drInmueble("tgInmEstado").ToString()
                loInmueble.inmSaneadoObsMostrable = drInmueble("inmSaneadoObsMostrable").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Consultas Inmueble => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function

    Public Shared Function listarConsultaCriterio(ByVal tipocriterio As String, ByVal aoInmueble As EEInmueble) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Consultas_Criterio_pa")
            db.AddInParameter(cmd, "tipocriterio", DbType.String, tipocriterio)
            If aoInmueble.TgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, aoInmueble.TgRubroId)
            End If
            If aoInmueble.TgRubroGrupoId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, aoInmueble.TgRubroGrupoId)
            End If
            If aoInmueble.InmFile IsNot Nothing Then
                db.AddInParameter(cmd, "file", DbType.String, aoInmueble.InmFile)
            End If
            If aoInmueble.InmFileAnt IsNot Nothing Then
                db.AddInParameter(cmd, "fileA", DbType.String, aoInmueble.InmFileAnt)
            End If
            If aoInmueble.TgInmEstado IsNot Nothing Then
                db.AddInParameter(cmd, "TgInmEstadoId", DbType.String, aoInmueble.TgInmEstado)
            Else
                db.AddInParameter(cmd, "NTgInmEstadoId", DbType.String, "01")
            End If

            If aoInmueble.tgInmCondRegId IsNot Nothing Then
                db.AddInParameter(cmd, "tgInmCondRegId", DbType.String, aoInmueble.tgInmCondRegId)
            End If

            If aoInmueble.InmPartidaElec IsNot Nothing Then
                db.AddInParameter(cmd, "InmPartidaElec", DbType.String, aoInmueble.InmPartidaElec)
            End If

            If aoInmueble.TgInmCondLegalId IsNot Nothing Then
                db.AddInParameter(cmd, "TgInmCondLegalId", DbType.String, aoInmueble.TgInmCondLegalId)
            End If

            If aoInmueble.TgEstSanId IsNot Nothing Then
                db.AddInParameter(cmd, "TgEstSanId", DbType.String, aoInmueble.TgEstSanId)
            End If

            If aoInmueble.tgInmSitFisicaId IsNot Nothing Then
                db.AddInParameter(cmd, "tgInmSitFisicaId", DbType.String, aoInmueble.tgInmSitFisicaId)
            End If

            If aoInmueble.tgEstInmConsvId IsNot Nothing Then
                db.AddInParameter(cmd, "tgEstInmConsvId", DbType.String, aoInmueble.tgEstInmConsvId)
            End If

            If aoInmueble.tgInmSFZonificacionId IsNot Nothing Then
                db.AddInParameter(cmd, "tgInmSFZonificacionId", DbType.String, aoInmueble.tgInmSFZonificacionId)
            End If

            If aoInmueble.InmDenominacion IsNot Nothing Then
                db.AddInParameter(cmd, "InmDenominacion", DbType.String, aoInmueble.InmDenominacion)
            End If
            If aoInmueble.InmDisponibilidad IsNot Nothing Then
                db.AddInParameter(cmd, "InmDisponibilidad", DbType.Boolean, aoInmueble.InmDisponibilidad)
            End If
            If aoInmueble.OInmDireccion IsNot Nothing Then
                If aoInmueble.OInmDireccion.TgLocalizacionId IsNot Nothing Then
                    db.AddInParameter(cmd, "tglocalizacionId", DbType.String, aoInmueble.OInmDireccion.TgLocalizacionId)
                End If
                If aoInmueble.OInmDireccion.InmDirLocalizacion IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirLocalizacion", DbType.String, aoInmueble.OInmDireccion.InmDirLocalizacion)
                End If
                If aoInmueble.OInmDireccion.TgNroId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgnroId", DbType.String, aoInmueble.OInmDireccion.TgNroId)
                End If
                If aoInmueble.OInmDireccion.InmDirNro IsNot Nothing Then
                    db.AddInParameter(cmd, "nro", DbType.String, aoInmueble.OInmDireccion.InmDirNro)
                End If
                If aoInmueble.OInmDireccion.TgSubNroId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgsubnroId", DbType.String, aoInmueble.OInmDireccion.TgSubNroId)
                End If
                If aoInmueble.OInmDireccion.InmDirSubNro IsNot Nothing Then
                    db.AddInParameter(cmd, "subnro", DbType.String, aoInmueble.OInmDireccion.InmDirSubNro)
                End If
                If aoInmueble.OInmDireccion.TgSubDistritosId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgSubDistritosId", DbType.String, aoInmueble.OInmDireccion.TgSubDistritosId)
                End If
                If aoInmueble.OInmDireccion.InmDirSubDistritos IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirSubDistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                End If
                'If aoInmueble.OInmDireccion.InmDirSubDistritos IsNot Nothing Then
                '    db.AddInParameter(cmd, "InmDirSubDistritos", DbType.String, aoInmueble.OInmDireccion.InmDirSubDistritos)
                'End If
                If aoInmueble.OInmDireccion.InmDirEtapa IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirEtapa", DbType.String, aoInmueble.OInmDireccion.InmDirEtapa)
                End If
                If aoInmueble.OInmDireccion.InmDirBarrio IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirBarrio", DbType.String, aoInmueble.OInmDireccion.InmDirBarrio)
                End If
                If aoInmueble.OInmDireccion.InmDirSector IsNot Nothing Then
                    db.AddInParameter(cmd, "inmDirSector", DbType.String, aoInmueble.OInmDireccion.InmDirSector)
                End If
                If aoInmueble.OInmDireccion.UbgId IsNot Nothing Then
                    db.AddInParameter(cmd, "tgDPDId", DbType.String, aoInmueble.OInmDireccion.UbgId)
                End If
                If aoInmueble.OInmDireccion.InmDirAdicional IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirAdicional", DbType.String, aoInmueble.OInmDireccion.InmDirAdicional)
                End If
                If aoInmueble.OInmDireccion.InmDirReferencia IsNot Nothing Then
                    db.AddInParameter(cmd, "InmDirReferencia", DbType.String, aoInmueble.OInmDireccion.InmDirReferencia)
                End If
            End If

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmFile = drInmueble("inmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("inmFileAnt").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                loInmueble.InmInscrito = drInmueble("inmInscrito").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.tgInmCondReg = drInmueble("tgInmCondReg").ToString()
                loInmueble.InmPartidaElec = drInmueble("inmPartidaElec").ToString()
                loInmueble.TgInmCondLegal = drInmueble("tgInmCondLegal").ToString()
                loInmueble.tgEstSan = drInmueble("tgEstSan").ToString()
                loInmueble.tgInmSitFisica = drInmueble("tgInmSitFisica").ToString()
                loInmueble.TgRubro = drInmueble("tgRubro").ToString()
                loInmueble.OInmPredio = New EEInmPredio
                If IsDBNull(drInmueble("InmPredArea")) = False Then
                    loInmueble.OInmPredio.InmPredArea = Convert.ToDecimal(drInmueble("InmPredArea").ToString())
                End If
                loInmueble.OInmValorComercial = New EEInmValorComercial
                If IsDBNull(drInmueble("inmValComValxMetro")) = False Then
                    loInmueble.OInmValorComercial.InmValComValxMetro = Convert.ToDecimal(drInmueble("inmValComValxMetro"))
                End If
                If IsDBNull(drInmueble("inmValComValConst")) = False Then
                    loInmueble.OInmValorComercial.InmValComValConst = Convert.ToDecimal(drInmueble("inmValComValConst"))
                End If
                If IsDBNull(drInmueble("inmValComValTerreno")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTerreno = Convert.ToDecimal(drInmueble("inmValComValTerreno"))
                End If
                If IsDBNull(drInmueble("inmValComValTotal")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTotal = Convert.ToDecimal(drInmueble("inmValComValTotal"))
                End If
                loInmueble.tgInmSFUso = drInmueble("tgInmSFUso").ToString()
                loInmueble.tgEstInmConsv = drInmueble("tgEstInmConsv").ToString()
                loInmueble.InmDisponibilidad = drInmueble("inmDisponibilidad").ToString()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.TgInmEstado = drInmueble("tgInmEstado").ToString()
                loInmueble.inmSaneadoObsMostrable = drInmueble("inmSaneadoObsMostrable").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Consultas Inmueble => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function

    Public Shared Function listarConsultaWebCriterio(ByVal aoInmueble As EEInmueble) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_ConsultasWeb_Criterio_pa")

            If aoInmueble.TgRubroGrupoId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, aoInmueble.TgRubroGrupoId)
            End If

            If aoInmueble.InmUbicacion IsNot Nothing Then
                db.AddInParameter(cmd, "inmUbicacion", DbType.String, aoInmueble.InmUbicacion)
            End If


            If aoInmueble.TgInmEstado IsNot Nothing Then
                db.AddInParameter(cmd, "TgInmEstadoId", DbType.String, aoInmueble.TgInmEstado)
            Else
                db.AddInParameter(cmd, "NTgInmEstadoId", DbType.String, "01")
            End If

            If aoInmueble.OInmDireccion IsNot Nothing Then
                If aoInmueble.OInmDireccion.UbgId IsNot Nothing Then
                    db.AddInParameter(cmd, "dpdId", DbType.String, aoInmueble.OInmDireccion.UbgId)
                End If

            End If

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.InmFile = drInmueble("inmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("inmFileAnt").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.TgRubro = drInmueble("tgRubro").ToString()
                loInmueble.OInmPredio = New EEInmPredio
                If IsDBNull(drInmueble("InmPredArea")) = False Then
                    loInmueble.OInmPredio.InmPredArea = Convert.ToDecimal(drInmueble("InmPredArea").ToString())
                End If

                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Consultas Inmueble => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function

    Public Shared Function listarByAnio_TgRubroId(ByVal anio As String, Optional ByVal tgRubroId As String = Nothing) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_by_anio_tgRubroId_pa")

            If tgRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, tgRubroId)
            End If
            If anio IsNot Nothing Then
                db.AddInParameter(cmd, "anio", DbType.String, anio)
            End If
            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmFile = drInmueble("inmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("inmFileAnt").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()
                loInmueble.InmInscrito = drInmueble("inmInscrito").ToString()
                loInmueble.InmDenominacion = drInmueble("inmDenominacion").ToString()
                loInmueble.tgInmCondReg = drInmueble("tgInmCondReg").ToString()
                loInmueble.InmPartidaElec = drInmueble("inmPartidaElec").ToString()
                loInmueble.TgInmCondLegal = drInmueble("tgInmCondLegal").ToString()
                loInmueble.tgEstSan = drInmueble("tgEstSan").ToString()

                '  loInmueble.TgRubro = drInmueble("tgRubro").ToString()
                loInmueble.TgRubroId = drInmueble("tgRubroId").ToString()
                loInmueble.OInmPredio = New EEInmPredio


                If IsDBNull(drInmueble("InmPredArea")) = False Then
                    loInmueble.OInmPredio.InmPredArea = Convert.ToDecimal(drInmueble("InmPredArea").ToString())
                End If
                loInmueble.OInmValorComercial = New EEInmValorComercial
                If IsDBNull(drInmueble("InmValComArea")) = False Then
                    loInmueble.OInmValorComercial.InmValComArea = Convert.ToDecimal(drInmueble("InmValComArea"))
                End If
                If IsDBNull(drInmueble("inmValComAreaTechada")) = False Then
                    loInmueble.OInmValorComercial.InmValComAreaTechada = Convert.ToDecimal(drInmueble("inmValComAreaTechada"))
                End If
                If IsDBNull(drInmueble("inmValComValxMetro")) = False Then
                    loInmueble.OInmValorComercial.InmValComValxMetro = Convert.ToDecimal(drInmueble("inmValComValxMetro"))
                End If
                If IsDBNull(drInmueble("inmValComValConst")) = False Then
                    loInmueble.OInmValorComercial.InmValComValConst = Convert.ToDecimal(drInmueble("inmValComValConst"))
                End If
                If IsDBNull(drInmueble("inmValComValTerreno")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTerreno = Convert.ToDecimal(drInmueble("inmValComValTerreno"))
                End If
                If IsDBNull(drInmueble("inmValComValTotal")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTotal = Convert.ToDecimal(drInmueble("inmValComValTotal"))
                End If
                loInmueble.tgInmSitFisica = drInmueble("tgInmSitFisica").ToString() '178
                loInmueble.tgInmSFUso = drInmueble("tgInmSFUso").ToString() '180
                loInmueble.tgEstInmConsv = drInmueble("tgEstInmConsv").ToString()
                loInmueble.InmDisponibilidad = drInmueble("inmDisponibilidad").ToString()
                loInmueble.InmId = drInmueble("inmId").ToString()
                loInmueble.TgInmEstado = drInmueble("tgInmEstado").ToString()
                loInmueble.inmSaneadoObsMostrable = drInmueble("inmSaneadoObsMostrable").ToString()
                ' ()
                'If Not IsDBNull(drInmueble("inmArchivo")) Then
                '    loInmueble.InmArchDivision = DirectCast(drInmueble("inmArchivo"), Byte())
                'End If

                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Rpt Final => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function

    Public Shared Function listarAltasByAnio_TgGRubroId(ByVal anio As String, Optional ByVal tgGRubroId As String = Nothing) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Altas_By_Anio_tgGRubroId_pa")

            If tgGRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, tgGRubroId)
            End If
            If anio IsNot Nothing Then
                db.AddInParameter(cmd, "anio", DbType.String, anio)
            End If
            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmFile = drInmueble("inmFile").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()

                loInmueble.OInmPredio = New EEInmPredio
                If IsDBNull(drInmueble("InmPredArea")) = False Then
                    loInmueble.OInmPredio.InmPredArea = Convert.ToDecimal(drInmueble("InmPredArea").ToString())
                End If
                loInmueble.OInmValorComercial = New EEInmValorComercial
                If IsDBNull(drInmueble("inmValComValTotal")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTotal = Convert.ToDecimal(drInmueble("inmValComValTotal"))
                End If
                loInmueble.inmCausalAlta = drInmueble("inmCausalAlta").ToString()
                loInmueble.inmAltaObservacion = drInmueble("inmAltaObservacion").ToString()
                loInmueble.inmDocAlta = drInmueble("inmDocAlta").ToString()
                loInmueble.InmFecReg = drInmueble("inmFecReg").ToString()
                loInmueble.InmId = drInmueble("inmId").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Rpt Final => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function

    Public Shared Function listarBajasByAnio_TgGRubroId(ByVal anio As String, Optional ByVal tgGRubroId As String = Nothing) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Bajas_By_Anio_tgGRubroId_pa")

            If tgGRubroId IsNot Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, tgGRubroId)
            End If
            If anio IsNot Nothing Then
                db.AddInParameter(cmd, "anio", DbType.String, anio)
            End If
            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmFile = drInmueble("inmFile").ToString()
                loInmueble.InmUbicacion = drInmueble("inmUbicacion").ToString()

                loInmueble.OInmPredio = New EEInmPredio
                If IsDBNull(drInmueble("InmPredArea")) = False Then
                    loInmueble.OInmPredio.InmPredArea = Convert.ToDecimal(drInmueble("InmPredArea").ToString())
                End If
                loInmueble.OInmValorComercial = New EEInmValorComercial
                If IsDBNull(drInmueble("inmValComValTotal")) = False Then
                    loInmueble.OInmValorComercial.InmValComValTotal = Convert.ToDecimal(drInmueble("inmValComValTotal"))
                End If
                loInmueble.OInmBajas = New EEInmueble.EEInmBajas
                loInmueble.OInmBajas.InmBajaCausa = drInmueble("inmBajaCausa").ToString()
                loInmueble.OInmBajas.InmBajaFecha = drInmueble("inmBajaFecha").ToString()
                loInmueble.OInmBajas.InmBajaNroDoc = drInmueble("InmBajaNroDoc").ToString()
                loInmueble.OInmBajas.InmBajaDatoAdicional = drInmueble("InmBajaDatoAdicional").ToString()
                loInmueble.OInmBajas.InmBajaObservacion = drInmueble("InmBajaObservacion").ToString()
                loInmueble.InmId = drInmueble("inmId").ToString()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Rpt Final => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function

    Public Shared Function MostrarTotalesByAnio(ByVal anio As String) As EEInmueble.EEVariablesRpt
        Dim loInmVariablesRpt As EEInmueble.EEVariablesRpt = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_Inmueble_Totales_by_anio_pa")


            If anio IsNot Nothing Then
                db.AddInParameter(cmd, "anio", DbType.String, anio)
            End If
            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                loInmVariablesRpt = New EEInmueble.EEVariablesRpt


                loInmVariablesRpt.TotalBienesPropios = Convert.ToInt16(drInmueble("TotalBienesPropios"))
                loInmVariablesRpt.TotalAltasBienesPropios = Convert.ToInt16(drInmueble("TotalAltasBienesPropios"))
                loInmVariablesRpt.TotalBajasBienesPropios = Convert.ToInt16(drInmueble("TotalBajasBienesPropios"))
                loInmVariablesRpt.TotalAreaBienesPropios = Convert.ToDecimal(drInmueble("TotalAreaBienesPropios"))
                loInmVariablesRpt.TotalAreaAltasBienesPropios = Convert.ToDecimal(drInmueble("TotalAreaAltasBienesPropios"))
                loInmVariablesRpt.TotalAreaBajasBienesPropios = Convert.ToDecimal(drInmueble("TotalAreaBajasBienesPropios"))
                loInmVariablesRpt.TotalAreaTechadaBienesPropios = Convert.ToDecimal(drInmueble("TotalAreaTechadaBienesPropios"))
                loInmVariablesRpt.TotalValorBienesPropios = Convert.ToDecimal(drInmueble("TotalValorBienesPropios"))
                loInmVariablesRpt.TotalValorAltasBienesPropios = Convert.ToDecimal(drInmueble("TotalValorAltasBienesPropios"))
                loInmVariablesRpt.TotalValorBajasBienesPropios = Convert.ToDecimal(drInmueble("TotalValorBajasBienesPropios"))

                loInmVariablesRpt.CountBP_BienesPropios = Convert.ToInt16(drInmueble("CountBP_BienesPropios"))
                loInmVariablesRpt.itemAreaBP_BienesPropio = Convert.ToDecimal(drInmueble("itemAreaBP_BienesPropio"))
                loInmVariablesRpt.itemAreaTechadaBP_BienesPropio = Convert.ToDecimal(drInmueble("itemAreaTechadaBP_BienesPropio"))
                loInmVariablesRpt.itemValorBP_BienesPropios = Convert.ToDecimal(drInmueble("itemValorBP_BienesPropios"))

                loInmVariablesRpt.CountBP_Vias = Convert.ToInt16(drInmueble("CountBP_Vias"))
                loInmVariablesRpt.itemAreaBP_Vias = Convert.ToDecimal(drInmueble("itemAreaBP_Vias"))
                loInmVariablesRpt.itemAreaTechadaBP_Vias = Convert.ToDecimal(drInmueble("itemAreaTechadaBP_Vias"))
                loInmVariablesRpt.itemValorBP_Vias = Convert.ToDecimal(drInmueble("itemValorBP_Vias"))


                loInmVariablesRpt.TotalOtrosFines = Convert.ToInt16(drInmueble("TotalOtrosFines"))
                loInmVariablesRpt.TotalAltasOtrosFines = Convert.ToInt16(drInmueble("TotalAltasOtrosFines"))
                loInmVariablesRpt.TotalBajasOtrosFines = Convert.ToInt16(drInmueble("TotalBajasOtrosFines"))
                loInmVariablesRpt.TotalAreaOtrosFines = Convert.ToDecimal(drInmueble("TotalAreaOtrosFines"))
                loInmVariablesRpt.TotalAreaAltasOtrosFines = Convert.ToDecimal(drInmueble("TotalAreaAltasOtrosFines"))
                loInmVariablesRpt.TotalAreaBajasOtrosFines = Convert.ToDecimal(drInmueble("TotalAreaBajasOtrosFines"))
                loInmVariablesRpt.TotalAreaTechadaOtrosFines = Convert.ToDecimal(drInmueble("TotalAreaTechadaOtrosFines"))
                loInmVariablesRpt.TotalValorOtrosFines = Convert.ToDecimal(drInmueble("TotalValorOtrosFines"))
                loInmVariablesRpt.TotalValorAltasOtrosFines = Convert.ToDecimal(drInmueble("TotalValorAltasOtrosFines"))
                loInmVariablesRpt.TotalValorBajasOtrosFines = Convert.ToDecimal(drInmueble("TotalValorBajasOtrosFines"))


                loInmVariablesRpt.CountOF_OtrosFines = Convert.ToInt16(drInmueble("CountOF_OtrosFines"))
                loInmVariablesRpt.itemAreaOF_OtrosFines = Convert.ToDecimal(drInmueble("itemAreaOF_OtrosFines"))
                loInmVariablesRpt.itemAreaTechadaOF_OtrosFines = Convert.ToDecimal(drInmueble("itemAreaTechadaOF_OtrosFines"))
                loInmVariablesRpt.itemValorOF_OtrosFines = Convert.ToDecimal(drInmueble("itemValorOF_OtrosFines"))



                loInmVariablesRpt.TotalSerpar = Convert.ToInt16(drInmueble("TotalSerpar"))
                loInmVariablesRpt.TotalAltasSerpar = Convert.ToInt16(drInmueble("TotalAltasSerpar"))
                loInmVariablesRpt.TotalBajasSerpar = Convert.ToInt16(drInmueble("TotalBajasSerpar"))
                loInmVariablesRpt.TotalAreaSerpar = Convert.ToDecimal(drInmueble("TotalAreaSerpar"))
                loInmVariablesRpt.TotalAreaAltasSerpar = Convert.ToDecimal(drInmueble("TotalAreaAltasSerpar"))
                loInmVariablesRpt.TotalAreaBajasSerpar = Convert.ToDecimal(drInmueble("TotalAreaBajasSerpar"))
                loInmVariablesRpt.TotalAreaTechadaSerpar = Convert.ToDecimal(drInmueble("TotalAreaTechadaSerpar"))
                loInmVariablesRpt.TotalValorSerpar = Convert.ToDecimal(drInmueble("TotalValorSerpar"))
                loInmVariablesRpt.TotalValorAltasSerpar = Convert.ToDecimal(drInmueble("TotalValorAltasSerpar"))
                loInmVariablesRpt.TotalValorBajasSerpar = Convert.ToDecimal(drInmueble("TotalValorBajasSerpar"))

                loInmVariablesRpt.CountS_Serpar = Convert.ToInt16(drInmueble("CountS_Serpar"))
                loInmVariablesRpt.itemAreaS_Serpar = Convert.ToDecimal(drInmueble("itemAreaS_Serpar"))
                loInmVariablesRpt.itemAreaTechadaS_Serpar = Convert.ToDecimal(drInmueble("itemAreaTechadaS_Serpar"))
                loInmVariablesRpt.itemValorS_Serpar = Convert.ToDecimal(drInmueble("itemValorS_Serpar"))

                loInmVariablesRpt.TotalAreasVerdes = Convert.ToInt16(drInmueble("TotalAreasVerdes"))
                loInmVariablesRpt.TotalAltasAreasVerdes = Convert.ToInt16(drInmueble("TotalAltasAreasVerdes"))
                loInmVariablesRpt.TotalBajasAreasVerdes = Convert.ToInt16(drInmueble("TotalBajasAreasVerdes"))
                loInmVariablesRpt.TotalAreaAreasVerdes = Convert.ToDecimal(drInmueble("TotalAreaAreasVerdes"))
                loInmVariablesRpt.TotalAreaAltasAreasVerdes = Convert.ToDecimal(drInmueble("TotalAreaAltasAreasVerdes"))
                loInmVariablesRpt.TotalAreaBajasAreasVerdes = Convert.ToDecimal(drInmueble("TotalAreaBajasAreasVerdes"))
                loInmVariablesRpt.TotalAreaTechadaAreasVerdes = Convert.ToDecimal(drInmueble("TotalAreaTechadaAreasVerdes"))
                loInmVariablesRpt.TotalValorAreasVerdes = Convert.ToDecimal(drInmueble("TotalValorAreasVerdes"))
                loInmVariablesRpt.TotalValorAltasAreasVerdes = Convert.ToDecimal(drInmueble("TotalValorAltasAreasVerdes"))
                loInmVariablesRpt.TotalValorBajasAreasVerdes = Convert.ToDecimal(drInmueble("TotalValorBajasAreasVerdes"))

                loInmVariablesRpt.CountAV_Parques = Convert.ToInt16(drInmueble("CountAV_Parques"))
                loInmVariablesRpt.itemAreaAV_Parques = Convert.ToDecimal(drInmueble("itemAreaAV_Parques"))
                loInmVariablesRpt.itemAreaTechadaAV_Parques = Convert.ToDecimal(drInmueble("itemAreaTechadaAV_Parques"))
                loInmVariablesRpt.itemValorAV_Parques = Convert.ToDecimal(drInmueble("itemValorAV_Parques"))

                loInmVariablesRpt.CountAV_Plazuelas = Convert.ToInt16(drInmueble("CountAV_Plazuelas"))
                loInmVariablesRpt.itemAreaAV_Plazuelas = Convert.ToDecimal(drInmueble("itemAreaAV_Plazuelas"))
                loInmVariablesRpt.itemAreaTechadaAV_Plazuelas = Convert.ToDecimal(drInmueble("itemAreaTechadaAV_Plazuelas"))
                loInmVariablesRpt.itemValorAV_Plazuelas = Convert.ToDecimal(drInmueble("itemValorAV_Plazuelas"))

                loInmVariablesRpt.CountAV_Bermas = Convert.ToInt16(drInmueble("CountAV_Bermas"))
                loInmVariablesRpt.itemAreaAV_Bermas = Convert.ToDecimal(drInmueble("itemAreaAV_Bermas"))
                loInmVariablesRpt.itemAreaTechadaAV_Bermas = Convert.ToDecimal(drInmueble("itemAreaTechadaAV_Bermas"))
                loInmVariablesRpt.itemValorAV_Bermas = Convert.ToDecimal(drInmueble("itemValorAV_Bermas"))

                loInmVariablesRpt.CountAV_Viveros = Convert.ToInt16(drInmueble("CountAV_Viveros"))
                loInmVariablesRpt.itemAreaAV_Viveros = Convert.ToDecimal(drInmueble("itemAreaAV_Viveros"))
                loInmVariablesRpt.itemAreaTechadaAV_Viveros = Convert.ToDecimal(drInmueble("itemAreaTechadaAV_Viveros"))
                loInmVariablesRpt.itemValorAV_Viveros = Convert.ToDecimal(drInmueble("itemValorAV_Viveros"))
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Rpt Final => " & ex.Message, ex)
        End Try
        Return loInmVariablesRpt
    End Function

    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim loUbigeo As EEUbigeo = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim drInmueble As IDataReader = Nothing
        Dim drDireccion As IDataReader = Nothing
        Dim drPredio As IDataReader = Nothing
        Dim drArchivos As IDataReader = Nothing
        Dim drDivisiones As IDataReader = Nothing
        Dim drSuministros As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If

                loInmueble = New EEInmueble()

                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
                loInmueble.InmPartidaElec = drInmueble("InmPartidaElec").ToString()
                loInmueble.TgRubroGrupo = drInmueble("tgGrupoRubro").ToString()
                loInmueble.TgRubro = drInmueble("tgRubro").ToString()
                'Direccion
                cmd = db.GetStoredProcCommand("Mostrar_InmDireccion_XImnId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDireccion = db.ExecuteReader(cmd)
                If drDireccion.Read Then
                    loInmDireccion = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    loUbigeo.UbgDepNombre = drDireccion("Departamento").ToString()
                    loUbigeo.UbgProvNombre = drDireccion("Provincia").ToString()
                    loUbigeo.UbgDistNombre = drDireccion("Distrito").ToString()
                    loInmDireccion.OUbigeo = loUbigeo
                    loInmDireccion.InmDireccionCompleta = drDireccion("InmDirCon").ToString()

                    loInmueble.OInmDireccion = loInmDireccion
                End If
                drDireccion.Close()
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Inmueble => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function
#End Region

#Region "Mostrar XInmId"
    Public Shared Function MostrarXInmId(ByVal asInmId As [String]) As EEInmueble
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim loInmDireccionIns As EEInmDireccion = Nothing
        Dim loUbigeo As EEUbigeo = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim drInmueble As IDataReader = Nothing
        Dim drDireccion As IDataReader = Nothing
        Dim drDireccionIns As IDataReader = Nothing
        Dim drArancel As IDataReader = Nothing
        Dim drValorComercial As IDataReader = Nothing
        Dim drArchivos As IDataReader = Nothing
        Dim drDivisiones As IDataReader = Nothing
        ' Dim drSuministros As IDataReader = Nothing
        Dim drPredio As IDataReader = Nothing
        Dim drProcesosJudicales As IDataReader = Nothing
        Dim drNivImp As IDataReader = Nothing

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_Inmueble_XInmId_pa")
            db.AddInParameter(cmd, "inmid", DbType.String, asInmId)

            drInmueble = db.ExecuteReader(cmd)
            If drInmueble.Read() Then
                loInmueble = New EEInmueble()
                ' Alta
                loInmueble.inmDocAlta = drInmueble("inmDocAlta").ToString()
                If drInmueble("inmFecAlta") IsNot DBNull.Value Then
                    loInmueble.inmFecAlta = Convert.ToDateTime(drInmueble("inmFecAlta"))
                End If
                loInmueble.inmCausalAlta = drInmueble("inmCausalAlta").ToString()
                loInmueble.inmAltaObservacion = drInmueble("inmAltaObservacion").ToString()

                ' Datos Generales
                loInmueble.InmCodSinabip = drInmueble("InmCodSinabip").ToString()
                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmInscrito = drInmueble("InmInscrito").ToString()
                loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
                loInmueble.tgEstInmConsvId = drInmueble("TgEstInmConsvId").ToString()
                loInmueble.InmDocAcredita = drInmueble("InmDocAcredita").ToString()
                loInmueble.InmDocAcreditaDominio = drInmueble("InmDocAcreditaDominio").ToString()
                loInmueble.InmPartidaElec = drInmueble("InmPartidaElec").ToString()
                loInmueble.InmAsiento = drInmueble("InmAsiento").ToString()
                loInmueble.InmSaneadoObs = drInmueble("InmSaneadoObs").ToString()
                loInmueble.inmSaneadoObsMostrable = drInmueble("inmSaneadoObsMostrable").ToString()
                loInmueble.tgInmSFZonificacionId = drInmueble("tgInmSFInformacionId").ToString()
                loInmueble.tgInmSFUsoId = drInmueble("tgInmSFUsoId").ToString()
                loInmueble.InmObsNivelImp = drInmueble("InmObsNivelImp").ToString()
                loInmueble.InmDisponibilidad = IIf(IsDBNull(drInmueble("InmDisponibilidad")), False, Convert.ToBoolean(drInmueble("InmDisponibilidad")))
                If drInmueble("InmFecMarg") IsNot DBNull.Value Then
                    loInmueble.InmFecMarg = Convert.ToDateTime(drInmueble("InmFecMarg"))
                End If
                loInmueble.TgEstSanId = drInmueble("TgEstSanId").ToString()
                If drInmueble("InmActivo") IsNot DBNull.Value Then
                    loInmueble.InmActivo = Convert.ToBoolean(drInmueble("InmActivo"))
                End If
                loInmueble.TgTipoUnidadId = drInmueble("TgTipoUnidadId").ToString()
                loInmueble.InmIdPadre = drInmueble("InmIdPadre").ToString()
                loInmueble.InmFilePadre = drInmueble("InmFilePadre").ToString()
                loInmueble.TgInmEstado = drInmueble("TgInmEstado").ToString()
                loInmueble.InmNroPisos = drInmueble("InmNroPisos").ToString()
                loInmueble.TgRubroGrupoId = drInmueble("tgGRubroId").ToString()
                loInmueble.TgRubroId = drInmueble("TgRubroId").ToString()
                loInmueble.InmObservacion = drInmueble("InmObservacion").ToString()
                loInmueble.InmUbicacion = drInmueble("InmUbicacion").ToString()
                loInmueble.tgInmCondRegId = drInmueble("tgInmCondRegId").ToString()
                loInmueble.tgInmCondRegSubId = drInmueble("tgInmCondRegSubId").ToString()
                loInmueble.tgInmSitFisicaId = drInmueble("TgInmSitFisicaId").ToString()
                loInmueble.TgInmCondLegalId = drInmueble("TgInmCondLegalId").ToString()
                loInmueble.tgInmSFZonificacionId = drInmueble("tgInmSFInformacionId").ToString()
                loInmueble.tgInmSFUsoId = drInmueble("tgInmSFUsoId").ToString()
                loInmueble.tgNivelId = drInmueble("tgNivelId").ToString()
                drInmueble.Close()

                'Direccion
                cmd = db.GetStoredProcCommand("Mostrar_InmDireccion_XImnId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDireccion = db.ExecuteReader(cmd)
                If drDireccion.Read Then
                    loInmDireccion = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    loUbigeo.UbgId = drDireccion("UbgId").ToString()
                    loUbigeo.UbgDep = drDireccion("UbgDep").ToString()
                    loUbigeo.UbgProv = drDireccion("UbgProv").ToString()
                    loUbigeo.UbgDist = drDireccion("UbgDist").ToString()
                    loUbigeo.UbgNombre = drDireccion("UbgNombre").ToString()

                    loInmDireccion.InmDirId = drDireccion("InmDirId").ToString()
                    loInmDireccion.InmId = drDireccion("InmId").ToString()
                    loInmDireccion.OUbigeo = loUbigeo
                    loInmDireccion.InmDirLocalizacion = drDireccion("InmDirLocalizacion").ToString()
                    loInmDireccion.TgLocalizacionId = drDireccion("TgLocalizacionId").ToString()
                    loInmDireccion.TgNroId = drDireccion("TgNroId").ToString()
                    loInmDireccion.InmDirNro = drDireccion("InmDirNro").ToString()
                    loInmDireccion.TgSubNroId = drDireccion("TgSubNroId").ToString()
                    loInmDireccion.InmDirSubNro = drDireccion("InmDirSubNro").ToString()
                    loInmDireccion.TgSubDistritosId = drDireccion("tgSubDistritosId").ToString()
                    loInmDireccion.InmDirSubDistritos = drDireccion("InmDirsubDistritos").ToString()
                    loInmDireccion.InmDirFase = drDireccion("InmDirFase").ToString()
                    loInmDireccion.InmDirEtapa = drDireccion("InmDirEtapa").ToString()
                    loInmDireccion.InmDirReferencia = drDireccion("InmDirReferencia").ToString()
                    loInmDireccion.InmDireccionCompleta = drDireccion("InmDirCon").ToString()
                    loInmDireccion.InmDirBarrio = drDireccion("InmDirBarrio").ToString()
                    loInmDireccion.InmDirSector = drDireccion("InmDirSector").ToString()
                    loInmDireccion.InmDirAdicional = drDireccion("InmDirAdicional").ToString()
                    If IsDBNull(drDireccion("InmDirCheck")) = False Then
                        loInmDireccion.InmDirCheck = Convert.ToBoolean(drDireccion("InmDirCheck"))
                    Else
                        loInmDireccion.InmDirCheck = False
                    End If

                    loInmueble.OInmDireccion = loInmDireccion
                End If
                drDireccion.Close()

                'Direccion
                cmd = db.GetStoredProcCommand("Mostrar_InmDireccionIns_XImnId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDireccionIns = db.ExecuteReader(cmd)
                If drDireccionIns.Read Then
                    loInmDireccionIns = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    loUbigeo.UbgId = drDireccionIns("UbgId").ToString()
                    loUbigeo.UbgDep = drDireccionIns("UbgDep").ToString()
                    loUbigeo.UbgProv = drDireccionIns("UbgProv").ToString()
                    loUbigeo.UbgDist = drDireccionIns("UbgDist").ToString()
                    loUbigeo.UbgNombre = drDireccionIns("UbgNombre").ToString()

                    loInmDireccionIns.InmDirId = drDireccionIns("InmDirInsId").ToString()
                    loInmDireccionIns.InmId = drDireccionIns("InmId").ToString()
                    loInmDireccionIns.OUbigeo = loUbigeo
                    loInmDireccionIns.InmDirLocalizacion = drDireccionIns("InmDirInsLocalizacion").ToString()
                    loInmDireccionIns.TgLocalizacionId = drDireccionIns("TglocalizacionId").ToString()
                    loInmDireccionIns.TgNroId = drDireccionIns("TgNroId").ToString()
                    loInmDireccionIns.InmDirNro = drDireccionIns("InmDirInsNro").ToString()
                    loInmDireccionIns.TgSubNroId = drDireccionIns("TgSubNroId").ToString()
                    loInmDireccionIns.InmDirSubNro = drDireccionIns("InmDirInsSubNro").ToString()
                    loInmDireccionIns.TgSubDistritosId = drDireccionIns("tgSubDistritosId").ToString()
                    loInmDireccionIns.InmDirSubDistritos = drDireccionIns("InmDirInsSubDistritos").ToString()
                    loInmDireccionIns.InmDirFase = drDireccionIns("InmDirInsFase").ToString()
                    loInmDireccionIns.InmDirEtapa = drDireccionIns("InmDirInsEtapa").ToString()
                    loInmDireccionIns.InmDirBarrio = drDireccionIns("InmDirInsBarrio").ToString()
                    loInmDireccionIns.InmDirSector = drDireccionIns("InmDirInsSector").ToString()
                    loInmDireccionIns.InmDirAdicional = drDireccionIns("InmDirInsAdicional").ToString()
                    loInmDireccionIns.InmDireccionCompleta = drDireccionIns("InmDirCon").ToString()
                    If IsDBNull(drDireccionIns("InmDirInsCheck")) = False Then
                        loInmDireccionIns.InmDirCheck = Convert.ToBoolean(drDireccionIns("InmDirInsCheck"))
                    Else
                        loInmDireccionIns.InmDirCheck = False
                    End If
                    loInmueble.OInmDireccionIns = loInmDireccionIns
                End If
                drDireccionIns.Close()


                cmd = db.GetStoredProcCommand("Mostrar_InmArancelario_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                db.AddInParameter(cmd, "inmAraAnio", DbType.String, Year(Date.Now))

                drArancel = db.ExecuteReader(cmd)
                If drArancel.Read Then
                    Dim loInmArancel As EEInmArancelario = New EEInmArancelario()
                    loInmArancel.InmId = drArancel("inmId").ToString()
                    loInmArancel.InmAraAnio = drArancel("inmAraAnio").ToString()
                    If Not IsDBNull(drArancel("inmAraValUnitario")) Then
                        loInmArancel.InmAraValUnitario = Convert.ToDecimal(drArancel("inmAraValUnitario").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraTotTerreno")) Then
                        loInmArancel.InmAraTotTerreno = Convert.ToDecimal(drArancel("inmAraTotTerreno").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraTotConstruccion")) Then
                        loInmArancel.InmAraTotConstruccion = Convert.ToDecimal(drArancel("inmAraTotConstruccion").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraTotAutovaluo")) Then
                        loInmArancel.InmAraTotAutovaluo = Convert.ToDecimal(drArancel("inmAraTotAutovaluo").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraAreTerreno")) Then
                        loInmArancel.InmAraAreTerreno = Convert.ToDecimal(drArancel("inmAraAreTerreno").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraAreConstruida")) Then
                        loInmArancel.InmAraAreConstruida = Convert.ToDecimal(drArancel("inmAraAreConstruida").ToString())
                    End If
                    loInmArancel.InmAraFuente = drArancel("inmAraFuente").ToString
                    loInmArancel.InmAraCodPredio = drArancel("inmAraCodPredio").ToString
                    loInmArancel.InmAraCodCatastral = drArancel("inmAraCodCatastral").ToString
                    loInmueble.OInmArancel = loInmArancel
                End If
                drArancel.Close()

                ''Predio
                cmd = db.GetStoredProcCommand("Mostrar_InmPredio_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drPredio = db.ExecuteReader(cmd)
                If drPredio.Read Then
                    Dim loInmPredio As EEInmPredio = New EEInmPredio()
                    loInmPredio.InmPredArea = Convert.ToDecimal(drPredio("InmPredArea").ToString())
                    loInmPredio.InmPredId = drPredio("InmPredId").ToString()
                    loInmueble.OInmPredio = loInmPredio
                End If

                drPredio.Close()
                '    
                '    loInmPredio.InmId = drPredio("InmId").ToString()

                '    If Not IsDBNull(drPredio("InmPredFecTas")) Then
                '        loInmPredio.InmPredFecTas = Convert.ToDateTime(drPredio("InmPredFecTas"))
                '    End If

                '    loInmPredio.InmPredAño = drPredio("InmPredAño").ToString()

                '    If Not IsDBNull(drPredio("InmPredArancel")) Then
                '        loInmPredio.InmPredArancel = Convert.ToDecimal(drPredio("InmPredArancel"))
                '    End If

                '    If Not IsDBNull(drPredio("InmPredValorTerreno")) Then
                '        loInmPredio.InmPredValorTerreno = Convert.ToDecimal(drPredio("InmPredValorTerreno"))
                '    End If

                '    If Not IsDBNull(drPredio("InmPredAreaTechada")) Then
                '        loInmPredio.InmPredAreaTechada = Convert.ToDecimal(drPredio("InmPredAreaTechada"))
                '    End If

                '    If Not IsDBNull(drPredio("InmPredValorConst")) Then
                '        loInmPredio.InmPredValorConst = Convert.ToDecimal(drPredio("InmPredValorConst"))
                '    End If

                '    If Not IsDBNull(drPredio("InmPredValorEdificacion")) Then
                '        loInmPredio.InmPredValorEdificacion = Convert.ToDecimal(drPredio("InmPredValorEdificacion"))
                '    End If

                '    If Not IsDBNull(drPredio("InmPredValorTotal")) Then
                '        loInmPredio.InmPredValorTotal = Convert.ToDecimal(drPredio("InmPredValorTotal"))
                '    End If

                '    loInmPredio.InmPredActivo = Convert.ToBoolean(drPredio("InmPredActivo"))

                'End If


                'Valor Comercial
                cmd = db.GetStoredProcCommand("Mostrar_InmValorComercial_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drValorComercial = db.ExecuteReader(cmd)
                If drValorComercial.Read Then
                    Dim loInmValorComercial As EEInmValorComercial = New EEInmValorComercial()
                    loInmValorComercial.InmId = drValorComercial("InmId").ToString()
                    loInmValorComercial.InmValComNroTas = drValorComercial("InmValComNroTas").ToString()
                    loInmValorComercial.InmValComArea = Convert.ToDecimal(drValorComercial("InmValComArea").ToString())
                    loInmValorComercial.InmValComAreaTechada = Convert.ToDecimal(drValorComercial("InmValComAreaTechada").ToString())
                    loInmValorComercial.InmValComValxMetro = Convert.ToDecimal(drValorComercial("InmValComValxMetro").ToString())
                    loInmValorComercial.InmValComValTerreno = Convert.ToDecimal(drValorComercial("InmValComValTerreno").ToString())
                    loInmValorComercial.InmValComValConst = Convert.ToDecimal(drValorComercial("InmValComValConst").ToString())
                    loInmValorComercial.InmValComValTotal = Convert.ToDecimal(drValorComercial("InmValComValTotal").ToString())
                    loInmValorComercial.InmValComFechaTas = IIf(IsDBNull(drValorComercial("InmValComFechaTas")), Nothing, drValorComercial("InmValComFechaTas"))
                    loInmValorComercial.InmValComFechaTasSug = IIf(IsDBNull(drValorComercial("InmValComFechaTasSug")), Nothing, drValorComercial("InmValComFechaTasSug"))
                    loInmValorComercial.InmValComPeritoPerId = drValorComercial("InmValComPeritoPerId").ToString()
                    loInmValorComercial.InmValComPeritoPer = drValorComercial("InmValComPeritoPer").ToString()
                    loInmueble.OInmValorComercial = loInmValorComercial
                End If
                drValorComercial.Close()

                'Archivos
                cmd = db.GetStoredProcCommand("Mostrar_InmArchivos_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drArchivos = db.ExecuteReader(cmd)
                While drArchivos.Read()
                    Dim loInmArchivos As EEInmArchivos = New EEInmArchivos()

                    loInmArchivos.InmArchId = drArchivos("InmArchId").ToString()
                    loInmArchivos.InmId = drArchivos("InmId").ToString()
                    loInmArchivos.InmArchNombre = drArchivos("InmArchNombre").ToString()
                    loInmArchivos.InmArchDescripcion = drArchivos("InmArchDescripcion").ToString()
                    loInmArchivos.TgTipoArchId = drArchivos("TgTipoArchId").ToString()
                    loInmArchivos.InmArchExt = drArchivos("InmArchExt").ToString()
                    loInmArchivos.InmArchPrincipal = Convert.ToBoolean(drArchivos("InmArchPrincipal").ToString())
                    loInmArchivos.TgNombre = drArchivos("tgNombre").ToString()
                    If IsDBNull(drArchivos("InmArchActivo")) = False Then
                        loInmArchivos.InmArchActivo = Convert.ToBoolean(drArchivos("InmArchActivo"))
                    End If
                    loInmueble.ListaInmArchivos.Add(loInmArchivos)
                End While
                drArchivos.Close()

                ' Nivel de Inmplementacion
                cmd = db.GetStoredProcCommand("Mostrar_InmNivelImp_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drNivImp = db.ExecuteReader(cmd)
                While drNivImp.Read()
                    Dim loInmNivelImp As EEInmNivelImp = New EEInmNivelImp() With {.InmId = drNivImp("InmId").ToString(), .TgNivImp = drNivImp("TgNivImp").ToString(), .TgNivImpId = drNivImp("TgNivImpId").ToString(), .InmNivfisico = Convert.ToBoolean(drNivImp("InmNivfisico").ToString()), .InmNivDigital = Convert.ToBoolean(drNivImp("InmNivDigital").ToString())}
                    loInmueble.ListaInmNivImp.Add(loInmNivelImp)
                End While
                drNivImp.Close()

                'Procesos Judiciales
                cmd = db.GetStoredProcCommand("Mostrar_InmPJudiciales_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drProcesosJudicales = db.ExecuteReader(cmd)
                While drProcesosJudicales.Read()
                    Dim loInmPJudiciales As EEInmPJudiciales = New EEInmPJudiciales()

                    loInmPJudiciales.InmPJudId = drProcesosJudicales("InmPJudId").ToString()
                    If Not IsDBNull(drProcesosJudicales("InmPJudFechaInicio")) Then
                        loInmPJudiciales.InmPJudFechaInicio = Convert.ToDateTime(drProcesosJudicales("InmPJudFechaInicio"))
                    End If

                    loInmPJudiciales.InmPJudNroExp = drProcesosJudicales("InmPJudNroExp").ToString()
                    loInmPJudiciales.InmPJudJuzgado = drProcesosJudicales("InmPJudJuzgado").ToString()
                    loInmPJudiciales.InmPJudMotivo = drProcesosJudicales("InmPJudMotivo").ToString()
                    loInmPJudiciales.InmPJudEtapaProc = drProcesosJudicales("InmPJudEtapaProc").ToString()
                    loInmPJudiciales.InmPJudDemandante = drProcesosJudicales("InmPJudDemandante").ToString()
                    loInmPJudiciales.InmPJudDemandado = drProcesosJudicales("InmPJudDemandado").ToString()
                    loInmPJudiciales.OTgEstadoProceso = New EETablaGeneral()
                    loInmPJudiciales.OTgEstadoProceso.TgCodigo = drProcesosJudicales("TgEstadoProcId").ToString()
                    loInmPJudiciales.OTgEstadoProceso.TgNombre = drProcesosJudicales("tgNombreEstadoProceso").ToString()
                    loInmPJudiciales.InmPJudLitisConsorte = drProcesosJudicales("InmPJudLitisConsorte").ToString()
                    loInmPJudiciales.InmPJudSecretario = drProcesosJudicales("InmPJudSecretario").ToString()
                    loInmPJudiciales.InmPJudObservacion = drProcesosJudicales("InmPJudObservacion").ToString()

                    loInmueble.ListaInmPJudiciales.Add(loInmPJudiciales)
                End While
                drProcesosJudicales.Close()

                'Divisiones
                cmd = db.GetStoredProcCommand("Mostrar_Inmueble_Divisiones_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDivisiones = db.ExecuteReader(cmd)
                Dim loInmuebleDivisiones As EEInmueble = Nothing
                While drDivisiones.Read()
                    If loInmueble.ListaDivisiones Is Nothing Then
                        loInmueble.ListaDivisiones = New List(Of EEInmueble)
                    End If

                    loInmuebleDivisiones = New EEInmueble()
                    loInmuebleDivisiones.InmId = drDivisiones("InmId").ToString()
                    loInmuebleDivisiones.InmFile = drDivisiones("InmFile").ToString()
                    loInmuebleDivisiones.TgRubro = drDivisiones("NombreRubro").ToString()

                    loInmDireccion = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    loUbigeo.UbgNombre = drDivisiones("UbgNombre").ToString()
                    loInmDireccion.OUbigeo = loUbigeo
                    loInmDireccion.InmDirLocalizacion = drDivisiones("InmDirLocalizacion").ToString()
                    loInmuebleDivisiones.OInmDireccion = loInmDireccion
                    If Not IsDBNull(drDivisiones("inmArchivo")) Then
                        loInmuebleDivisiones.InmArchDivision = DirectCast(drDivisiones("inmArchivo"), Byte())
                    End If
                    loInmueble.ListaDivisiones.Add(loInmuebleDivisiones)
                End While
                drDivisiones.Close()
            End If

        Catch ex As Exception
            Throw New Exception("Mostrar Inmueble XInmId => " & ex.Message, ex)
        End Try
        Return loInmueble
    End Function

    Public Shared Function MostrarAltaXInmId(ByVal asInmId As [String]) As EEInmueble
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim loInmDireccionIns As EEInmDireccion = Nothing
        Dim loUbigeo As EEUbigeo = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim drInmueble As IDataReader = Nothing
        Dim drDireccion As IDataReader = Nothing
        Dim drDireccionIns As IDataReader = Nothing
        Dim drArancel As IDataReader = Nothing
        Dim drValorComercial As IDataReader = Nothing
        Dim drArchivos As IDataReader = Nothing
        Dim drPredio As IDataReader = Nothing
        Dim drDivisiones As IDataReader = Nothing
        Dim drNivImp As IDataReader = Nothing

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_InmuebleAlta_XInmId_pa")
            db.AddInParameter(cmd, "inmid", DbType.String, asInmId)

            drInmueble = db.ExecuteReader(cmd)
            If drInmueble.Read() Then
                loInmueble = New EEInmueble()

                loInmueble.tgTipoIngreso = drInmueble("tgTipoIngreso").ToString()
                loInmueble.perRegId = drInmueble("perRegId").ToString()
                loInmueble.inmDocAlta = drInmueble("inmDocAlta").ToString()
                loInmueble.InmCodSinabip = drInmueble("InmCodSinabip").ToString()
                If drInmueble("inmFecAlta") IsNot DBNull.Value Then
                    loInmueble.inmFecAlta = Convert.ToDateTime(drInmueble("inmFecAlta"))
                End If
                loInmueble.inmCausalAlta = drInmueble("inmCausalAlta").ToString()
                loInmueble.inmAltaObservacion = drInmueble("inmAltaObservacion").ToString()
                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmInscrito = drInmueble("InmInscrito").ToString()
                loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
                loInmueble.tgEstInmConsvId = drInmueble("TgEstInmConsvId").ToString()
                loInmueble.InmDocAcredita = drInmueble("InmDocAcredita").ToString()
                loInmueble.InmDocAcreditaDominio = drInmueble("InmDocAcreditaDominio").ToString()
                loInmueble.InmPartidaElec = drInmueble("InmPartidaElec").ToString()
                loInmueble.InmAsiento = drInmueble("InmAsiento").ToString()
                loInmueble.InmSaneadoObs = drInmueble("InmSaneadoObs").ToString()
                loInmueble.inmSaneadoObsMostrable = drInmueble("inmSaneadoObsMostrable").ToString()
                loInmueble.tgInmSFZonificacionId = drInmueble("tgInmSFInformacionId").ToString()
                loInmueble.tgInmSFUsoId = drInmueble("tgInmSFUsoId").ToString()
                loInmueble.InmObsNivelImp = drInmueble("InmObsNivelImp").ToString()
                loInmueble.InmDisponibilidad = IIf(IsDBNull(drInmueble("InmDisponibilidad")), False, Convert.ToBoolean(drInmueble("InmDisponibilidad")))
                If drInmueble("InmFecMarg") IsNot DBNull.Value Then
                    loInmueble.InmFecMarg = Convert.ToDateTime(drInmueble("InmFecMarg"))
                End If
                loInmueble.TgEstSanId = drInmueble("TgEstSanId").ToString()
                If drInmueble("InmActivo") IsNot DBNull.Value Then
                    loInmueble.InmActivo = Convert.ToBoolean(drInmueble("InmActivo"))
                End If
                loInmueble.TgTipoUnidadId = drInmueble("TgTipoUnidadId").ToString()
                loInmueble.InmIdPadre = drInmueble("InmIdPadre").ToString()
                loInmueble.InmFilePadre = drInmueble("InmFilePadre").ToString()
                loInmueble.TgInmEstado = drInmueble("TgInmEstado").ToString()
                loInmueble.InmNroPisos = drInmueble("InmNroPisos").ToString()
                loInmueble.TgRubroGrupoId = drInmueble("tgGRubroId").ToString()
                loInmueble.TgRubroId = drInmueble("TgRubroId").ToString()
                loInmueble.InmObservacion = drInmueble("InmObservacion").ToString()
                loInmueble.InmUbicacion = drInmueble("InmUbicacion").ToString()
                loInmueble.tgInmCondRegId = drInmueble("tgInmCondRegId").ToString()
                loInmueble.tgInmCondRegSubId = drInmueble("tgInmCondRegSubId").ToString()
                loInmueble.tgInmSitFisicaId = drInmueble("TgInmSitFisicaId").ToString()
                loInmueble.TgInmCondLegalId = drInmueble("TgInmCondLegalId").ToString()
                loInmueble.tgInmSFZonificacionId = drInmueble("tgInmSFInformacionId").ToString()
                loInmueble.tgInmSFUsoId = drInmueble("tgInmSFUsoId").ToString()
                loInmueble.tgNivelId = drInmueble("tgNivelId").ToString()
                drInmueble.Close()

                'Direccion
                cmd = db.GetStoredProcCommand("Mostrar_InmDireccion_XImnId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDireccion = db.ExecuteReader(cmd)
                If drDireccion.Read Then
                    loInmDireccion = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    loUbigeo.UbgId = drDireccion("UbgId").ToString()
                    loUbigeo.UbgDep = drDireccion("UbgDep").ToString()
                    loUbigeo.UbgProv = drDireccion("UbgProv").ToString()
                    loUbigeo.UbgDist = drDireccion("UbgDist").ToString()
                    loUbigeo.UbgNombre = drDireccion("UbgNombre").ToString()

                    loInmDireccion.InmDirId = drDireccion("InmDirId").ToString()
                    loInmDireccion.InmId = drDireccion("InmId").ToString()
                    loInmDireccion.OUbigeo = loUbigeo
                    loInmDireccion.InmDirLocalizacion = drDireccion("InmDirLocalizacion").ToString()
                    loInmDireccion.TgLocalizacionId = drDireccion("TgLocalizacionId").ToString()
                    loInmDireccion.TgNroId = drDireccion("TgNroId").ToString()
                    loInmDireccion.InmDirNro = drDireccion("InmDirNro").ToString()
                    loInmDireccion.TgSubNroId = drDireccion("TgSubNroId").ToString()
                    loInmDireccion.InmDirSubNro = drDireccion("InmDirSubNro").ToString()
                    loInmDireccion.TgSubDistritosId = drDireccion("tgSubDistritosId").ToString()
                    loInmDireccion.InmDirSubDistritos = drDireccion("InmDirsubDistritos").ToString()
                    loInmDireccion.InmDirFase = drDireccion("InmDirFase").ToString()
                    loInmDireccion.InmDirEtapa = drDireccion("InmDirEtapa").ToString()
                    loInmDireccion.InmDirReferencia = drDireccion("InmDirReferencia").ToString()
                    loInmDireccion.InmDireccionCompleta = drDireccion("InmDirCon").ToString()
                    loInmDireccion.InmDirBarrio = drDireccion("InmDirBarrio").ToString()
                    loInmDireccion.InmDirSector = drDireccion("InmDirSector").ToString()
                    loInmDireccion.InmDirAdicional = drDireccion("InmDirAdicional").ToString()
                    If IsDBNull(drDireccion("InmDirCheck")) = False Then
                        loInmDireccion.InmDirCheck = Convert.ToBoolean(drDireccion("InmDirCheck"))
                    Else
                        loInmDireccion.InmDirCheck = False
                    End If

                    loInmueble.OInmDireccion = loInmDireccion
                End If
                drDireccion.Close()

                'Direccion
                cmd = db.GetStoredProcCommand("Mostrar_InmDireccionIns_XImnId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDireccionIns = db.ExecuteReader(cmd)
                If drDireccionIns.Read Then
                    loInmDireccionIns = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    loUbigeo.UbgId = drDireccionIns("UbgId").ToString()
                    loUbigeo.UbgDep = drDireccionIns("UbgDep").ToString()
                    loUbigeo.UbgProv = drDireccionIns("UbgProv").ToString()
                    loUbigeo.UbgDist = drDireccionIns("UbgDist").ToString()
                    loUbigeo.UbgNombre = drDireccionIns("UbgNombre").ToString()

                    loInmDireccionIns.InmDirId = drDireccionIns("InmDirInsId").ToString()
                    loInmDireccionIns.InmId = drDireccionIns("InmId").ToString()
                    loInmDireccionIns.OUbigeo = loUbigeo
                    loInmDireccionIns.InmDirLocalizacion = drDireccionIns("InmDirInsLocalizacion").ToString()
                    loInmDireccionIns.TgLocalizacionId = drDireccionIns("TglocalizacionId").ToString()
                    loInmDireccionIns.TgNroId = drDireccionIns("TgNroId").ToString()
                    loInmDireccionIns.InmDirNro = drDireccionIns("InmDirInsNro").ToString()
                    loInmDireccionIns.TgSubNroId = drDireccionIns("TgSubNroId").ToString()
                    loInmDireccionIns.InmDirSubNro = drDireccionIns("InmDirInsSubNro").ToString()
                    loInmDireccionIns.TgSubDistritosId = drDireccionIns("tgSubDistritosId").ToString()
                    loInmDireccionIns.InmDirSubDistritos = drDireccionIns("InmDirInsSubDistritos").ToString()
                    loInmDireccionIns.InmDirFase = drDireccionIns("InmDirInsFase").ToString()
                    loInmDireccionIns.InmDirEtapa = drDireccionIns("InmDirInsEtapa").ToString()
                    loInmDireccionIns.InmDirBarrio = drDireccionIns("InmDirInsBarrio").ToString()
                    loInmDireccionIns.InmDirSector = drDireccionIns("InmDirInsSector").ToString()
                    loInmDireccionIns.InmDirAdicional = drDireccionIns("InmDirInsAdicional").ToString()
                    loInmDireccionIns.InmDireccionCompleta = drDireccionIns("InmDirCon").ToString()
                    If IsDBNull(drDireccionIns("InmDirInsCheck")) = False Then
                        loInmDireccionIns.InmDirCheck = Convert.ToBoolean(drDireccionIns("InmDirInsCheck"))
                    Else
                        loInmDireccionIns.InmDirCheck = False
                    End If
                    loInmueble.OInmDireccionIns = loInmDireccionIns
                End If
                drDireccionIns.Close()
                'Arancelario
                cmd = db.GetStoredProcCommand("Mostrar_InmArancelario_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                db.AddInParameter(cmd, "inmAraAnio", DbType.String, Year(Date.Now))
                drArancel = db.ExecuteReader(cmd)
                If drArancel.Read Then
                    Dim loInmArancel As EEInmArancelario = New EEInmArancelario()
                    loInmArancel.InmId = drArancel("inmId").ToString()
                    loInmArancel.InmAraAnio = drArancel("inmAraAnio").ToString()
                    If Not IsDBNull(drArancel("inmAraValUnitario")) Then
                        loInmArancel.InmAraValUnitario = Convert.ToDecimal(drArancel("inmAraValUnitario").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraTotTerreno")) Then
                        loInmArancel.InmAraTotTerreno = Convert.ToDecimal(drArancel("inmAraTotTerreno").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraTotConstruccion")) Then
                        loInmArancel.InmAraTotConstruccion = Convert.ToDecimal(drArancel("inmAraTotConstruccion").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraTotAutovaluo")) Then
                        loInmArancel.InmAraTotAutovaluo = Convert.ToDecimal(drArancel("inmAraTotAutovaluo").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraAreTerreno")) Then
                        loInmArancel.InmAraAreTerreno = Convert.ToDecimal(drArancel("inmAraAreTerreno").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraAreConstruida")) Then
                        loInmArancel.InmAraAreConstruida = Convert.ToDecimal(drArancel("inmAraAreConstruida").ToString())
                    End If
                    loInmArancel.InmAraFuente = drArancel("inmAraFuente").ToString
                    loInmArancel.InmAraCodPredio = drArancel("inmAraCodPredio").ToString
                    loInmArancel.InmAraCodCatastral = drArancel("inmAraCodCatastral").ToString
                    loInmueble.OInmArancel = loInmArancel
                End If
                drArancel.Close()
                ''Predio
                cmd = db.GetStoredProcCommand("Mostrar_InmPredio_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drPredio = db.ExecuteReader(cmd)
                If drPredio.Read Then
                    Dim loInmPredio As EEInmPredio = New EEInmPredio()
                    loInmPredio.InmPredArea = Convert.ToDecimal(drPredio("InmPredArea").ToString())
                    loInmPredio.InmPredId = drPredio("InmPredId").ToString()
                End If
                drPredio.Close()
                'Valor Comercial
                cmd = db.GetStoredProcCommand("Mostrar_InmValorComercial_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drValorComercial = db.ExecuteReader(cmd)
                If drValorComercial.Read Then
                    Dim loInmValorComercial As EEInmValorComercial = New EEInmValorComercial()
                    loInmValorComercial.InmId = drValorComercial("InmId").ToString()
                    loInmValorComercial.InmValComNroTas = drValorComercial("InmValComNroTas").ToString()
                    loInmValorComercial.InmValComArea = Convert.ToDecimal(drValorComercial("InmValComArea").ToString())
                    loInmValorComercial.InmValComAreaTechada = Convert.ToDecimal(drValorComercial("InmValComAreaTechada").ToString())
                    loInmValorComercial.InmValComValxMetro = Convert.ToDecimal(drValorComercial("InmValComValxMetro").ToString())
                    loInmValorComercial.InmValComValTerreno = Convert.ToDecimal(drValorComercial("InmValComValTerreno").ToString())
                    loInmValorComercial.InmValComValConst = Convert.ToDecimal(drValorComercial("InmValComValConst").ToString())
                    loInmValorComercial.InmValComValTotal = Convert.ToDecimal(drValorComercial("InmValComValTotal").ToString())
                    loInmValorComercial.InmValComFechaTas = IIf(IsDBNull(drValorComercial("InmValComFechaTas")), Nothing, drValorComercial("InmValComFechaTas"))
                    loInmValorComercial.InmValComFechaTasSug = IIf(IsDBNull(drValorComercial("InmValComFechaTasSug")), Nothing, drValorComercial("InmValComFechaTasSug"))
                    loInmValorComercial.InmValComPeritoPerId = drValorComercial("InmValComPeritoPerId").ToString()
                    loInmValorComercial.InmValComPeritoPer = drValorComercial("InmValComPeritoPer").ToString()
                    loInmValorComercial.InmValComObservacion = drValorComercial("InmValComObservacion").ToString()
                    loInmueble.OInmValorComercial = loInmValorComercial
                End If
                drValorComercial.Close()
                'Archivos
                cmd = db.GetStoredProcCommand("Mostrar_InmArchivos_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drArchivos = db.ExecuteReader(cmd)
                While drArchivos.Read()
                    Dim loInmArchivos As EEInmArchivos = New EEInmArchivos()

                    loInmArchivos.InmArchId = drArchivos("InmArchId").ToString()
                    loInmArchivos.InmId = drArchivos("InmId").ToString()
                    loInmArchivos.InmArchNombre = drArchivos("InmArchNombre").ToString()
                    loInmArchivos.InmArchDescripcion = drArchivos("InmArchDescripcion").ToString()
                    loInmArchivos.TgTipoArchId = drArchivos("TgTipoArchId").ToString()
                    loInmArchivos.InmArchExt = drArchivos("InmArchExt").ToString()
                    loInmArchivos.InmArchPrincipal = Convert.ToBoolean(drArchivos("InmArchPrincipal").ToString())
                    loInmArchivos.TgNombre = drArchivos("tgNombre").ToString()
                    If IsDBNull(drArchivos("InmArchActivo")) = False Then
                        loInmArchivos.InmArchActivo = Convert.ToBoolean(drArchivos("InmArchActivo"))
                    End If
                    loInmueble.ListaInmArchivos.Add(loInmArchivos)
                End While
                drArchivos.Close()

                ' Nivel de Inmplementacion
                cmd = db.GetStoredProcCommand("Mostrar_InmNivelImp_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drNivImp = db.ExecuteReader(cmd)
                While drNivImp.Read()
                    Dim loInmNivelImp As EEInmNivelImp = New EEInmNivelImp() With {.InmId = drNivImp("InmId").ToString(), .TgNivImp = drNivImp("TgNivImp").ToString(), .TgNivImpId = drNivImp("TgNivImpId").ToString(), .InmNivfisico = Convert.ToBoolean(drNivImp("InmNivfisico").ToString()), .InmNivDigital = Convert.ToBoolean(drNivImp("InmNivDigital").ToString())}
                    loInmueble.ListaInmNivImp.Add(loInmNivelImp)
                End While
                drNivImp.Close()


                'Divisiones
                cmd = db.GetStoredProcCommand("Mostrar_Inmueble_Divisiones_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDivisiones = db.ExecuteReader(cmd)
                Dim loInmuebleDivisiones As EEInmueble = Nothing
                While drDivisiones.Read()
                    If loInmueble.ListaDivisiones Is Nothing Then
                        loInmueble.ListaDivisiones = New List(Of EEInmueble)
                    End If

                    loInmuebleDivisiones = New EEInmueble()
                    loInmuebleDivisiones.InmId = drDivisiones("InmId").ToString()
                    loInmuebleDivisiones.InmFile = drDivisiones("InmFile").ToString()
                    loInmuebleDivisiones.TgRubro = drDivisiones("NombreRubro").ToString()

                    loInmDireccion = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    loUbigeo.UbgNombre = drDivisiones("UbgNombre").ToString()
                    loInmDireccion.OUbigeo = loUbigeo
                    loInmDireccion.InmDirLocalizacion = drDivisiones("InmDirLocalizacion").ToString()
                    loInmuebleDivisiones.OInmDireccion = loInmDireccion
                    If Not IsDBNull(drDivisiones("inmArchivo")) Then
                        loInmuebleDivisiones.InmArchDivision = DirectCast(drDivisiones("inmArchivo"), Byte())
                    End If
                    loInmueble.ListaDivisiones.Add(loInmuebleDivisiones)
                End While
                drDivisiones.Close()
            End If

        Catch ex As Exception
            Throw New Exception("Mostrar Inmueble XInmId => " & ex.Message, ex)
        End Try
        Return loInmueble
    End Function

    Public Shared Function MostrarDatosBajaXInmId(ByVal asInmId As [String]) As EEInmueble.EEInmBajas
        Dim loInmueble As EEInmueble = Nothing
        Dim drInmueble As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_InmuebleDatosBaja_XInmId_pa")
            db.AddInParameter(cmd, "inmid", DbType.String, asInmId)

            drInmueble = db.ExecuteReader(cmd)
            If drInmueble.Read() Then
                loInmueble = New EEInmueble
                loInmueble.OInmBajas = New EEInmueble.EEInmBajas
                loInmueble.OInmBajas.InmBajaNroDoc = drInmueble("InmBajaNroDoc").ToString()
                If drInmueble("inmBajaFecha") IsNot DBNull.Value Then
                    loInmueble.OInmBajas.InmBajaFecha = Convert.ToDateTime(drInmueble("inmBajaFecha"))
                End If
                If drInmueble("inmBajaDocFecha") IsNot DBNull.Value Then
                    loInmueble.OInmBajas.InmBajaDocFecha = Convert.ToDateTime(drInmueble("inmBajaDocFecha"))
                End If
                loInmueble.OInmBajas.InmBajaCausa = drInmueble("inmBajaCausa").ToString()
                loInmueble.OInmBajas.InmBajaTemporal = drInmueble("InmBajaTemporal").ToString()

            End If

        Catch ex As Exception
            Throw New Exception("Mostrar Inmueble XInmId => " & ex.Message, ex)
        End Try
        Return loInmueble.OInmBajas
    End Function

    Public Shared Function MostrarBajaXInmId(ByVal asInmId As [String]) As EEInmueble
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim loInmDireccionIns As EEInmDireccion = Nothing
        Dim loUbigeo As EEUbigeo = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim drInmueble As IDataReader = Nothing
        Dim drDireccion As IDataReader = Nothing
        Dim drDireccionIns As IDataReader = Nothing
        Dim drArancel As IDataReader = Nothing
        Dim drValorComercial As IDataReader = Nothing
        Dim drArchivos As IDataReader = Nothing
        Dim drDivisiones As IDataReader = Nothing
        Dim drNivImp As IDataReader = Nothing
        Dim drPredio As IDataReader = Nothing

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()

            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_InmuebleBaja_XInmId_pa")
            db.AddInParameter(cmd, "inmid", DbType.String, asInmId)

            drInmueble = db.ExecuteReader(cmd)
            If drInmueble.Read() Then
                loInmueble = New EEInmueble()

                loInmueble.tgTipoIngreso = drInmueble("tgTipoIngreso").ToString()
                loInmueble.perRegId = drInmueble("perRegId").ToString()
                loInmueble.InmCodSinabip = drInmueble("InmCodSinabip").ToString()

                'loInmueble.inmDocBaja = drInmueble("inmDocBaja").ToString()
                'If drInmueble("inmFecBaja") IsNot DBNull.Value Then
                '    loInmueble.inmFecBaja = Convert.ToDateTime(drInmueble("inmFecBaja"))
                'End If
                'If drInmueble("inmFecDocBaja") IsNot DBNull.Value Then
                '    loInmueble.inmFecBaja = Convert.ToDateTime(drInmueble("inmFecDocBaja"))
                'End If
                'loInmueble.inmCausalBaja = drInmueble("inmCausalBaja").ToString()

                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmInscrito = drInmueble("InmInscrito").ToString()
                loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
                loInmueble.tgEstInmConsvId = drInmueble("TgEstInmConsvId").ToString()
                loInmueble.InmDocAcredita = drInmueble("InmDocAcredita").ToString()
                loInmueble.InmDocAcreditaDominio = drInmueble("InmDocAcreditaDominio").ToString()
                loInmueble.InmPartidaElec = drInmueble("InmPartidaElec").ToString()
                loInmueble.InmAsiento = drInmueble("InmAsiento").ToString()
                loInmueble.InmSaneadoObs = drInmueble("InmSaneadoObs").ToString()
                loInmueble.inmSaneadoObsMostrable = drInmueble("inmSaneadoObsMostrable").ToString()
                loInmueble.tgInmSFZonificacionId = drInmueble("tgInmSFInformacionId").ToString()
                loInmueble.tgInmSFUsoId = drInmueble("tgInmSFUsoId").ToString()
                loInmueble.InmObsNivelImp = drInmueble("InmObsNivelImp").ToString()
                loInmueble.InmDisponibilidad = IIf(IsDBNull(drInmueble("InmDisponibilidad")), False, Convert.ToBoolean(drInmueble("InmDisponibilidad")))
                If drInmueble("InmFecMarg") IsNot DBNull.Value Then
                    loInmueble.InmFecMarg = Convert.ToDateTime(drInmueble("InmFecMarg"))
                End If
                loInmueble.TgEstSanId = drInmueble("TgEstSanId").ToString()
                If drInmueble("InmActivo") IsNot DBNull.Value Then
                    loInmueble.InmActivo = Convert.ToBoolean(drInmueble("InmActivo"))
                End If
                loInmueble.TgTipoUnidadId = drInmueble("TgTipoUnidadId").ToString()
                loInmueble.InmIdPadre = drInmueble("InmIdPadre").ToString()
                loInmueble.InmFilePadre = drInmueble("InmFilePadre").ToString()
                loInmueble.TgInmEstado = drInmueble("TgInmEstado").ToString()
                loInmueble.InmNroPisos = drInmueble("InmNroPisos").ToString()
                loInmueble.TgRubroGrupoId = drInmueble("tgGRubroId").ToString()
                loInmueble.TgRubroId = drInmueble("TgRubroId").ToString()
                loInmueble.InmObservacion = drInmueble("InmObservacion").ToString()
                loInmueble.InmUbicacion = drInmueble("InmUbicacion").ToString()
                loInmueble.tgInmCondRegId = drInmueble("tgInmCondRegId").ToString()
                loInmueble.tgInmCondRegSubId = drInmueble("tgInmCondRegSubId").ToString()
                loInmueble.tgInmSitFisicaId = drInmueble("TgInmSitFisicaId").ToString()
                loInmueble.TgInmCondLegalId = drInmueble("TgInmCondLegalId").ToString()
                loInmueble.tgInmSFZonificacionId = drInmueble("tgInmSFInformacionId").ToString()
                loInmueble.tgInmSFUsoId = drInmueble("tgInmSFUsoId").ToString()
                loInmueble.tgNivelId = drInmueble("tgNivelId").ToString()
                drInmueble.Close()

                'Direccion
                cmd = db.GetStoredProcCommand("Mostrar_InmDireccion_XImnId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDireccion = db.ExecuteReader(cmd)
                If drDireccion.Read Then
                    loInmDireccion = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    loUbigeo.UbgId = drDireccion("UbgId").ToString()
                    loUbigeo.UbgDep = drDireccion("UbgDep").ToString()
                    loUbigeo.UbgProv = drDireccion("UbgProv").ToString()
                    loUbigeo.UbgDist = drDireccion("UbgDist").ToString()
                    loUbigeo.UbgNombre = drDireccion("UbgNombre").ToString()

                    loInmDireccion.InmDirId = drDireccion("InmDirId").ToString()
                    loInmDireccion.InmId = drDireccion("InmId").ToString()
                    loInmDireccion.OUbigeo = loUbigeo
                    loInmDireccion.InmDirLocalizacion = drDireccion("InmDirLocalizacion").ToString()
                    loInmDireccion.TgLocalizacionId = drDireccion("TgLocalizacionId").ToString()
                    loInmDireccion.TgNroId = drDireccion("TgNroId").ToString()
                    loInmDireccion.InmDirNro = drDireccion("InmDirNro").ToString()
                    loInmDireccion.TgSubNroId = drDireccion("TgSubNroId").ToString()
                    loInmDireccion.InmDirSubNro = drDireccion("InmDirSubNro").ToString()
                    loInmDireccion.TgSubDistritosId = drDireccion("tgSubDistritosId").ToString()
                    loInmDireccion.InmDirSubDistritos = drDireccion("InmDirsubDistritos").ToString()
                    loInmDireccion.InmDirFase = drDireccion("InmDirFase").ToString()
                    loInmDireccion.InmDirEtapa = drDireccion("InmDirEtapa").ToString()
                    loInmDireccion.InmDirReferencia = drDireccion("InmDirReferencia").ToString()
                    loInmDireccion.InmDireccionCompleta = drDireccion("InmDirCon").ToString()
                    loInmDireccion.InmDirBarrio = drDireccion("InmDirBarrio").ToString()
                    loInmDireccion.InmDirSector = drDireccion("InmDirSector").ToString()
                    loInmDireccion.InmDirAdicional = drDireccion("InmDirAdicional").ToString()
                    If IsDBNull(drDireccion("InmDirCheck")) = False Then
                        loInmDireccion.InmDirCheck = Convert.ToBoolean(drDireccion("InmDirCheck"))
                    Else
                        loInmDireccion.InmDirCheck = False
                    End If

                    loInmueble.OInmDireccion = loInmDireccion
                End If
                drDireccion.Close()

                'Direccion
                cmd = db.GetStoredProcCommand("Mostrar_InmDireccionIns_XImnId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDireccionIns = db.ExecuteReader(cmd)
                If drDireccionIns.Read Then
                    loInmDireccionIns = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    loUbigeo.UbgId = drDireccionIns("UbgId").ToString()
                    loUbigeo.UbgDep = drDireccionIns("UbgDep").ToString()
                    loUbigeo.UbgProv = drDireccionIns("UbgProv").ToString()
                    loUbigeo.UbgDist = drDireccionIns("UbgDist").ToString()
                    loUbigeo.UbgNombre = drDireccionIns("UbgNombre").ToString()

                    loInmDireccionIns.InmDirId = drDireccionIns("InmDirInsId").ToString()
                    loInmDireccionIns.InmId = drDireccionIns("InmId").ToString()
                    loInmDireccionIns.OUbigeo = loUbigeo
                    loInmDireccionIns.InmDirLocalizacion = drDireccionIns("InmDirInsLocalizacion").ToString()
                    loInmDireccionIns.TgLocalizacionId = drDireccionIns("TglocalizacionId").ToString()
                    loInmDireccionIns.TgNroId = drDireccionIns("TgNroId").ToString()
                    loInmDireccionIns.InmDirNro = drDireccionIns("InmDirInsNro").ToString()
                    loInmDireccionIns.TgSubNroId = drDireccionIns("TgSubNroId").ToString()
                    loInmDireccionIns.InmDirSubNro = drDireccionIns("InmDirInsSubNro").ToString()
                    loInmDireccionIns.TgSubDistritosId = drDireccionIns("tgSubDistritosId").ToString()
                    loInmDireccionIns.InmDirSubDistritos = drDireccionIns("InmDirInsSubDistritos").ToString()
                    loInmDireccionIns.InmDirFase = drDireccionIns("InmDirInsFase").ToString()
                    loInmDireccionIns.InmDirEtapa = drDireccionIns("InmDirInsEtapa").ToString()
                    loInmDireccionIns.InmDirBarrio = drDireccionIns("InmDirInsBarrio").ToString()
                    loInmDireccionIns.InmDirSector = drDireccionIns("InmDirInsSector").ToString()
                    loInmDireccionIns.InmDirAdicional = drDireccionIns("InmDirInsAdicional").ToString()
                    loInmDireccionIns.InmDireccionCompleta = drDireccionIns("InmDirCon").ToString()
                    If IsDBNull(drDireccionIns("InmDirInsCheck")) = False Then
                        loInmDireccionIns.InmDirCheck = Convert.ToBoolean(drDireccionIns("InmDirInsCheck"))
                    Else
                        loInmDireccionIns.InmDirCheck = False
                    End If
                    loInmueble.OInmDireccionIns = loInmDireccionIns
                End If
                drDireccionIns.Close()
                'Predio

                cmd = db.GetStoredProcCommand("Mostrar_InmPredio_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drPredio = db.ExecuteReader(cmd)
                If drPredio.Read Then
                    Dim loInmPredio As EEInmPredio = New EEInmPredio()
                    loInmPredio.InmPredArea = Convert.ToDecimal(drPredio("InmPredArea").ToString())
                    loInmPredio.InmPredId = drPredio("InmPredId").ToString()
                    loInmueble.OInmPredio = loInmPredio
                End If
                drPredio.Close()
                'Arancel
                cmd = db.GetStoredProcCommand("Mostrar_InmArancelario_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                db.AddInParameter(cmd, "inmAraAnio", DbType.String, Year(Date.Now))
                drArancel = db.ExecuteReader(cmd)
                If drArancel.Read Then
                    Dim loInmArancel As EEInmArancelario = New EEInmArancelario()
                    loInmArancel.InmId = drArancel("inmId").ToString()
                    loInmArancel.InmAraAnio = drArancel("inmAraAnio").ToString()
                    If Not IsDBNull(drArancel("inmAraValUnitario")) Then
                        loInmArancel.InmAraValUnitario = Convert.ToDecimal(drArancel("inmAraValUnitario").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraTotTerreno")) Then
                        loInmArancel.InmAraTotTerreno = Convert.ToDecimal(drArancel("inmAraTotTerreno").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraTotConstruccion")) Then
                        loInmArancel.InmAraTotConstruccion = Convert.ToDecimal(drArancel("inmAraTotConstruccion").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraTotAutovaluo")) Then
                        loInmArancel.InmAraTotAutovaluo = Convert.ToDecimal(drArancel("inmAraTotAutovaluo").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraAreTerreno")) Then
                        loInmArancel.InmAraAreTerreno = Convert.ToDecimal(drArancel("inmAraAreTerreno").ToString())
                    End If
                    If Not IsDBNull(drArancel("inmAraAreConstruida")) Then
                        loInmArancel.InmAraAreConstruida = Convert.ToDecimal(drArancel("inmAraAreConstruida").ToString())
                    End If
                    loInmArancel.InmAraFuente = drArancel("inmAraFuente").ToString
                    loInmArancel.InmAraCodPredio = drArancel("inmAraCodPredio").ToString
                    loInmArancel.InmAraCodCatastral = drArancel("inmAraCodCatastral").ToString
                    loInmueble.OInmArancel = loInmArancel
                End If
                drArancel.Close()


         

                'Valor Comercial
                cmd = db.GetStoredProcCommand("Mostrar_InmValorComercial_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drValorComercial = db.ExecuteReader(cmd)
                If drValorComercial.Read Then
                    Dim loInmValorComercial As EEInmValorComercial = New EEInmValorComercial()
                    loInmValorComercial.InmId = drValorComercial("InmId").ToString()
                    loInmValorComercial.InmValComNroTas = drValorComercial("InmValComNroTas").ToString()
                    loInmValorComercial.InmValComArea = Convert.ToDecimal(drValorComercial("InmValComArea").ToString())
                    loInmValorComercial.InmValComAreaTechada = Convert.ToDecimal(drValorComercial("InmValComAreaTechada").ToString())
                    loInmValorComercial.InmValComValxMetro = Convert.ToDecimal(drValorComercial("InmValComValxMetro").ToString())
                    loInmValorComercial.InmValComValTerreno = Convert.ToDecimal(drValorComercial("InmValComValTerreno").ToString())
                    loInmValorComercial.InmValComValConst = Convert.ToDecimal(drValorComercial("InmValComValConst").ToString())
                    loInmValorComercial.InmValComValTotal = Convert.ToDecimal(drValorComercial("InmValComValTotal").ToString())
                    loInmValorComercial.InmValComFechaTas = IIf(IsDBNull(drValorComercial("InmValComFechaTas")), Nothing, drValorComercial("InmValComFechaTas"))
                    loInmValorComercial.InmValComFechaTasSug = IIf(IsDBNull(drValorComercial("InmValComFechaTasSug")), Nothing, drValorComercial("InmValComFechaTasSug"))
                    loInmValorComercial.InmValComPeritoPerId = drValorComercial("InmValComPeritoPerId").ToString()
                    loInmValorComercial.InmValComPeritoPer = drValorComercial("InmValComPeritoPer").ToString()
                    loInmueble.OInmValorComercial = loInmValorComercial
                End If
                drValorComercial.Close()

                'Archivos
                cmd = db.GetStoredProcCommand("Mostrar_InmArchivos_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drArchivos = db.ExecuteReader(cmd)
                While drArchivos.Read()
                    Dim loInmArchivos As EEInmArchivos = New EEInmArchivos()

                    loInmArchivos.InmArchId = drArchivos("InmArchId").ToString()
                    loInmArchivos.InmId = drArchivos("InmId").ToString()
                    loInmArchivos.InmArchNombre = drArchivos("InmArchNombre").ToString()
                    loInmArchivos.InmArchDescripcion = drArchivos("InmArchDescripcion").ToString()
                    loInmArchivos.TgTipoArchId = drArchivos("TgTipoArchId").ToString()
                    loInmArchivos.InmArchExt = drArchivos("InmArchExt").ToString()
                    loInmArchivos.InmArchPrincipal = Convert.ToBoolean(drArchivos("InmArchPrincipal").ToString())
                    loInmArchivos.TgNombre = drArchivos("tgNombre").ToString()
                    If IsDBNull(drArchivos("InmArchActivo")) = False Then
                        loInmArchivos.InmArchActivo = Convert.ToBoolean(drArchivos("InmArchActivo"))
                    End If
                    loInmueble.ListaInmArchivos.Add(loInmArchivos)
                End While
                drArchivos.Close()

                ' Nivel de Inmplementacion
                cmd = db.GetStoredProcCommand("Mostrar_InmNivelImp_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drNivImp = db.ExecuteReader(cmd)
                While drNivImp.Read()
                    Dim loInmNivelImp As EEInmNivelImp = New EEInmNivelImp() With {.InmId = drNivImp("InmId").ToString(), .TgNivImp = drNivImp("TgNivImp").ToString(), .TgNivImpId = drNivImp("TgNivImpId").ToString(), .InmNivfisico = Convert.ToBoolean(drNivImp("InmNivfisico").ToString()), .InmNivDigital = Convert.ToBoolean(drNivImp("InmNivDigital").ToString())}
                    loInmueble.ListaInmNivImp.Add(loInmNivelImp)
                End While
                drNivImp.Close()


                'Divisiones
                cmd = db.GetStoredProcCommand("Mostrar_Inmueble_Divisiones_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDivisiones = db.ExecuteReader(cmd)
                Dim loInmuebleDivisiones As EEInmueble = Nothing
                While drDivisiones.Read()
                    If loInmueble.ListaDivisiones Is Nothing Then
                        loInmueble.ListaDivisiones = New List(Of EEInmueble)
                    End If

                    loInmuebleDivisiones = New EEInmueble()
                    loInmuebleDivisiones.InmId = drDivisiones("InmId").ToString()
                    loInmuebleDivisiones.InmFile = drDivisiones("InmFile").ToString()
                    loInmuebleDivisiones.TgRubro = drDivisiones("NombreRubro").ToString()

                    loInmDireccion = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    loUbigeo.UbgNombre = drDivisiones("UbgNombre").ToString()
                    loInmDireccion.OUbigeo = loUbigeo
                    loInmDireccion.InmDirLocalizacion = drDivisiones("InmDirLocalizacion").ToString()
                    loInmuebleDivisiones.OInmDireccion = loInmDireccion
                    If Not IsDBNull(drDivisiones("inmArchivo")) Then
                        loInmuebleDivisiones.InmArchDivision = DirectCast(drDivisiones("inmArchivo"), Byte())
                    End If
                    loInmueble.ListaDivisiones.Add(loInmuebleDivisiones)
                End While
                drDivisiones.Close()
            End If

        Catch ex As Exception
            Throw New Exception("Mostrar Inmueble XInmId => " & ex.Message, ex)
        End Try
        Return loInmueble
    End Function
#End Region
    Public Shared Function MostrarInmArchXInmArchId(ByVal InmArchId As [String]) As EEInmArchivos
        Dim loInmArchivos As EEInmArchivos = New EEInmArchivos()
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim drArchivos As IDataReader = Nothing
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_InmArchivos_InmArch_XInmArchId_pa")
            db.AddInParameter(cmd, "inmArchId", DbType.String, InmArchId)
            drArchivos = db.ExecuteReader(cmd)
            If drArchivos.Read() Then
                loInmArchivos.InmArch = DirectCast(drArchivos("InmArch"), Byte())
            End If
            drArchivos.Close()
        Catch ex As Exception

        End Try
        Return loInmArchivos
    End Function

#Region "Listar ALL"
    'Public Shared Function listarALL() As List(Of EEInmueble)
    '    Dim ListaInmueble As List(Of EEInmueble) = Nothing
    '    Dim loInmueble As EEInmueble = Nothing
    '    Dim loTablaGeneral As EETablaGeneral = Nothing
    '    Dim loPersona As EEPersona = Nothing
    '    Dim drInmueble As IDataReader = Nothing
    '    Dim drDireccion As IDataReader = Nothing
    '    Dim drPredio As IDataReader = Nothing
    '    Dim drArchivos As IDataReader = Nothing
    '    Dim drDivisiones As IDataReader = Nothing
    '    Dim drSuministros As IDataReader = Nothing
    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase()
    '        Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_ALL_pa")

    '        drInmueble = db.ExecuteReader(cmd)
    '        While drInmueble.Read()
    '            If ListaInmueble Is Nothing Then
    '                ListaInmueble = New List(Of EEInmueble)()
    '            End If

    '            loInmueble = New EEInmueble()

    '            loInmueble.InmId = drInmueble("InmId").ToString()
    '            loInmueble.InmFile = drInmueble("InmFile").ToString()
    '            loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
    '            loInmueble.InmInscrito = drInmueble("InmInscrito").ToString()
    '            loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
    '            loInmueble.TgEstInmConsvId = drInmueble("TgEstInmConsvId").ToString()
    '            loInmueble.InmDocAcredita = drInmueble("InmDocAcredita").ToString()
    '            loInmueble.tgInmCondRegId = drInmueble("tgInmCondRegId").ToString()
    '            loInmueble.InmPartidaElec = drInmueble("InmPartidaElec").ToString()
    '            loInmueble.InmAsiento = drInmueble("InmAsiento").ToString()
    '            loInmueble.TgEstSanId = drInmueble("TgEstSanId").ToString()
    '            loInmueble.InmSaneadoObs = drInmueble("InmSaneadoObs").ToString()
    '            loInmueble.InmFecMarg = IIf(IsDBNull(drInmueble("InmFecMarg")), Nothing, drInmueble("InmFecMarg"))
    '            loInmueble.InmDisponibilidad = IIf(IsDBNull(drInmueble("InmDisponibilidad")), False, drInmueble("InmDisponibilidad"))
    '            ' loInmueble.TgInmSituacionId = drInmueble("TgInmSituacionId").ToString()
    '            loInmueble.InmActivo = IIf(IsDBNull(drInmueble("InmActivo")), False, drInmueble("InmActivo"))
    '            loInmueble.TgTipoUnidadId = drInmueble("TgTipoUnidadId").ToString()
    '            loInmueble.TgTipoUnidadNombre = drInmueble("TgTipoUnidadNombre").ToString()
    '            loInmueble.InmIdPadre = drInmueble("InmIdPadre").ToString()
    '            'loInmueble.InmFilePadre = drInmueble("InmFilePadre").ToString()
    '            loInmueble.TgInmEstado = drInmueble("TgInmEstado").ToString()
    '            loInmueble.InmNroPisos = drInmueble("InmNroPisos").ToString()
    '            loInmueble.TgRubroGrupoId = drInmueble("TgRubroId").ToString()
    '            loInmueble.TgRubroId = drInmueble("TgRubroId").ToString()
    '            loInmueble.InmObservacion = drInmueble("InmObservacion").ToString()
    '            loInmueble.TgExtraId = drInmueble("TgExtraId").ToString()

    '            'Direccion
    '            cmd = db.GetStoredProcCommand("Mostrar_InmDireccion_XImnId_pa")
    '            db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
    '            drDireccion = db.ExecuteReader(cmd)

    '            If drDireccion.Read Then
    '                Dim loInmDireccion As EEInmDireccion = New EEInmDireccion()
    '                Dim loUbigeo As EEUbigeo = New EEUbigeo()
    '                loUbigeo.UbgId = drDireccion("UbgId").ToString()
    '                loUbigeo.UbgDep = drDireccion("UbgDep").ToString()
    '                loUbigeo.UbgProv = drDireccion("UbgProv").ToString()
    '                loUbigeo.UbgDist = drDireccion("UbgDist").ToString()
    '                loUbigeo.UbgNombre = drDireccion("UbgNombre").ToString()

    '                loInmDireccion.InmDirId = drDireccion("InmDirId").ToString()
    '                loInmDireccion.InmId = drDireccion("InmId").ToString()
    '                loInmDireccion.OUbigeo = loUbigeo
    '                loInmDireccion.InmDirLocalizacion = drDireccion("InmDirLocalizacion").ToString()
    '                loInmDireccion.TgLocalizacionId = drDireccion("tgLocalizacionId").ToString()
    '                loInmDireccion.InmDirNro = drDireccion("InmDirNro").ToString()
    '                'loInmDireccion.InmDirNroInt = drDireccion("InmDirNroInt").ToString()
    '                'loInmDireccion.InmDirManz = drDireccion("InmDirManz").ToString()
    '                'loInmDireccion.InmDirLote = drDireccion("InmDirLote").ToString()
    '                'loInmDireccion.InmDirSubLote = drDireccion("InmDirSubLote").ToString()
    '                loInmDireccion.InmDirFase = drDireccion("InmDirFase").ToString()
    '                loInmDireccion.InmDirEtapa = drDireccion("InmDirEtapa").ToString()
    '                loInmDireccion.InmDirFechaReg = Convert.ToDateTime(drDireccion("InmDirFechaReg").ToString())
    '                loInmDireccion.InmDirReferencia = drDireccion("InmDirReferencia").ToString()
    '                ' loInmDireccion.InmDirActivo = Convert.ToBoolean(drDireccion("InmDirActivo").ToString())

    '                loInmueble.OInmDireccion = loInmDireccion
    '            End If

    '            drDireccion.Close()

    '            'Predio
    '            cmd = db.GetStoredProcCommand("Mostrar_InmPredio_XInmId_pa")
    '            db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
    '            drPredio = db.ExecuteReader(cmd)

    '            If drPredio.Read Then
    '                Dim loInmPredio As EEInmPredio = New EEInmPredio()

    '                loInmPredio.InmPredId = drPredio("InmPredId").ToString()
    '                loInmPredio.InmId = drPredio("InmId").ToString()
    '                loInmPredio.InmPredFecTas = IIf(IsDBNull(drPredio("InmPredFecTas")), Nothing, drPredio("InmPredFecTas"))
    '                loInmPredio.InmPredAño = drPredio("InmPredAño").ToString()
    '                loInmPredio.InmPredArea = Convert.ToDecimal(drPredio("InmPredArea").ToString())
    '                loInmPredio.InmPredArancel = Convert.ToDecimal(drPredio("InmPredArancel").ToString())
    '                loInmPredio.InmPredValorTerreno = Convert.ToDecimal(drPredio("InmPredValorTerreno").ToString())
    '                loInmPredio.InmPredAreaTechada = Convert.ToDecimal(drPredio("InmPredAreaTechada").ToString())
    '                loInmPredio.InmPredValorConst = Convert.ToDecimal(drPredio("InmPredValorConst").ToString())
    '                loInmPredio.InmPredValorEdificacion = Convert.ToDecimal(drPredio("InmPredValorEdificacion").ToString())
    '                loInmPredio.InmPredValorTotal = Convert.ToDecimal(drPredio("InmPredValorTotal").ToString())
    '                loInmPredio.InmPredActivo = Convert.ToBoolean(drPredio("InmPredActivo").ToString())

    '                loInmueble.OInmPredio = loInmPredio
    '            End If
    '            drPredio.Close()

    '            'Archivos
    '            cmd = db.GetStoredProcCommand("Mostrar_InmArchivos_XInmId_pa")
    '            db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
    '            drArchivos = db.ExecuteReader(cmd)
    '            While drArchivos.Read()
    '                Dim loInmArchivos As EEInmArchivos = New EEInmArchivos()

    '                loInmArchivos.InmArchId = drArchivos("InmArchId").ToString()
    '                loInmArchivos.InmId = drArchivos("InmId").ToString()
    '                loInmArchivos.InmArchNombre = drArchivos("InmArchNombre").ToString()
    '                loInmArchivos.InmArchDescripcion = drArchivos("InmArchDescripcion").ToString()
    '                loInmArchivos.TgTipoArchId = drArchivos("TgTipoArchId").ToString()
    '                loInmArchivos.InmArch = DirectCast(drArchivos("InmArch"), Byte())
    '                loInmArchivos.InmArchExt = drArchivos("InmArchExt").ToString()
    '                loInmArchivos.InmArchPrincipal = Convert.ToBoolean(drArchivos("InmArchPrincipal").ToString())
    '                loInmArchivos.TgNombre = drArchivos("tgNombre").ToString()
    '                loInmueble.ListaInmArchivos.Add(loInmArchivos)
    '            End While
    '            drArchivos.Close()

    '            'Suministros
    '            cmd = db.GetStoredProcCommand("Mostrar_InmSuministros_XInmId_pa")
    '            db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
    '            drSuministros = db.ExecuteReader(cmd)
    '            While drSuministros.Read()
    '                Dim loInmSuministros As EEInmSuministros = New EEInmSuministros()

    '                loInmSuministros.InmSumId = drSuministros("InmSumId").ToString()
    '                loInmSuministros.InmId = drSuministros("InmId").ToString()

    '                loPersona = New EEPersona()
    '                loPersona.PerId = drSuministros("PerId").ToString()
    '                loPersona.PerRazonSocial = drSuministros("perRazonSocial").ToString()

    '                loInmSuministros.OPersona = loPersona

    '                loTablaGeneral = New EETablaGeneral()
    '                loTablaGeneral.TgNombre = drSuministros("tgTipoServNombre").ToString()
    '                loTablaGeneral.TgCodigo = drSuministros("tgTipoServId").ToString()

    '                loInmSuministros.TgTipoServicio = loTablaGeneral
    '                loInmSuministros.InmSumFechaVen = IIf(IsDBNull(drSuministros("InmSumFechaVen")), Nothing, drSuministros("InmSumFechaVen"))

    '                loTablaGeneral = New EETablaGeneral()
    '                loTablaGeneral.TgNombre = drSuministros("tgTipoMesNombre").ToString()
    '                loTablaGeneral.TgCodigo = drSuministros("tgTipoMesId").ToString()

    '                loInmSuministros.TgTipoMes = loTablaGeneral

    '                loInmSuministros.InmSumAño = Convert.ToInt32(drSuministros("InmSumAño").ToString())
    '                loInmSuministros.InmSumMonto = Convert.ToDecimal(drSuministros("InmSumMonto").ToString())
    '                loInmSuministros.InmSumMedidor = drSuministros("InmSumMedidor").ToString()

    '                loInmueble.ListaInmSuministros.Add(loInmSuministros)
    '            End While
    '            drSuministros.Close()

    '            'Divisiones
    '            cmd = db.GetStoredProcCommand("Mostrar_Inmueble_Divisiones_XInmId_pa")
    '            db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
    '            drDivisiones = db.ExecuteReader(cmd)
    '            While drDivisiones.Read()
    '                If loInmueble.ListaDivisiones Is Nothing Then
    '                    loInmueble.ListaDivisiones = New List(Of EEInmueble)
    '                End If

    '                Dim loInmuebleDivisiones As EEInmueble = New EEInmueble()
    '                loInmuebleDivisiones.InmId = drDivisiones("InmId").ToString()

    '                If Not IsDBNull(drDivisiones("inmArchivo")) Then
    '                    loInmuebleDivisiones.InmArchDivision = DirectCast(drDivisiones("inmArchivo"), Byte())
    '                End If

    '                loInmueble.ListaDivisiones.Add(loInmuebleDivisiones)
    '            End While
    '            drDivisiones.Close()

    '            ListaInmueble.Add(loInmueble)
    '        End While

    '    Catch ex As Exception
    '        Throw New Exception("Listar ALL Inmueble => " & ex.Message, ex)
    '    End Try
    '    Return ListaInmueble
    'End Function
#End Region

#Region "Consulta Buscar Inmueble Para Contratos"
    Public Shared Function listarBCriterioEnContrato(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim drInmueble As IDataReader = Nothing

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_BCriterio_Contrato_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If
                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
                loInmueble.InmEstContrato = drInmueble("estContrato").ToString()
                loInmueble.InmUbicacion = drInmueble("InmUbicacion").ToString()
                loInmueble.InmDisponibilidad = IIf(IsDBNull(drInmueble("InmDisponibilidad")), False, drInmueble("InmDisponibilidad"))
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Busquedas de Criterio Inmueble En Contrato => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function
#End Region

#Region "Consulta Inmueble Por Distintos Criterios"
    'Public Shared Function inmuebleListarXSql(ByVal Sqlwhere As [String]) As List(Of EEInmueble)
    '    Dim ListaInmueble As List(Of EEInmueble) = Nothing
    '    Dim loInmueble As EEInmueble = Nothing
    '    Dim drInmueble As IDataReader = Nothing
    '    Dim sql As String = ""

    '    If Sqlwhere <> "" Then
    '        Dim sql2 As Char() = RTrim(Sqlwhere.ToCharArray())
    '        If sql2(sql2.Length - 1) = Char.Parse("R") Then
    '            Sqlwhere = Sqlwhere.Substring(0, Sqlwhere.Length - 3)
    '        ElseIf sql2(sql2.Length - 1) = Char.Parse("D") Then
    '            Sqlwhere = Sqlwhere.Substring(0, Sqlwhere.Length - 4)
    '        End If
    '        sql = String.Format("{0} AND {1}", "SELECT Inmueble.inmId,(SELECT tgNombre FROM TablaGeneral WHERE clsId=14 and tgCodigo=TgInmEstado) AS TgInmEstadoNombre,inmFile,inmFileAnt,inmInscrito,inmDenominacion,tgEstInmConsvId,inmDocAcredita,tgInmCondRegId,(SELECT tgNombre FROM TablaGeneral WHERE clsId=27 and tgCodigo=tgInmCondRegId) AS tgInmCondReg,inmPartidaElec,inmAsiento,tgEstSanId,inmSaneadoObs,inmDisponibilidad,inmFecMarg,tgInmSituacionId,inmActivo,tgTipoUnidadId,(SELECT tgNombre FROM TablaGeneral WHERE clsId=35 and tgCodigo=tgTipoUnidadId) AS tgTipoUnidadNombre,inmIdPadre,tgInmEstado,inmNroPisos,tgRubroId,(SELECT tgExtra FROM TablaGeneral WHERE clsId=33 and tgCodigo=tgRubroId) AS tgExtraId,inmObservacion,inmDirLocalizacion,(SELECT tgNombre FROM TablaGeneral WHERE clsId=1 and tgCodigo=InmDireccion.tgLocalizacionId) AS TgViaNombre,(SELECT tgAbrev FROM TablaGeneral WHERE clsId=1 and tgCodigo=InmDireccion.tgLocalizacionId) AS TgViaAbrev,InmDirNro,inmDirNroInt,InmDirManz,InmDirLote,InmDirSubLote,InmDirFase,InmDirEtapa,InmDirReferencia FROM Inmueble INNER JOIN InmDireccion ON Inmueble.inmId = InmDireccion.inmId LEFT JOIN TablaGeneral e ON e.tgCodigo=Inmueble.tgRubroId and e.clsId=33 WHERE inmDirActivo=1", Sqlwhere)
    '    Else
    '        sql = "SELECT Inmueble.inmId,(SELECT tgNombre FROM TablaGeneral WHERE clsId=14 and tgCodigo=TgInmEstado) AS TgInmEstadoNombre,inmFile,inmFileAnt,inmInscrito,inmDenominacion,tgEstInmConsvId,inmDocAcredita,tgInmCondRegId,(SELECT tgNombre FROM TablaGeneral WHERE clsId=27 and tgCodigo=tgInmCondRegId) AS tgInmCondReg,inmPartidaElec,inmAsiento,tgEstSanId,inmSaneadoObs,inmDisponibilidad,inmFecMarg,tgInmSituacionId,inmActivo,tgTipoUnidadId,(SELECT tgNombre FROM TablaGeneral WHERE clsId=35 and tgCodigo=tgTipoUnidadId) AS tgTipoUnidadNombre,inmIdPadre,tgInmEstado,inmNroPisos,tgRubroId,(SELECT tgExtra FROM TablaGeneral WHERE clsId=33 and tgCodigo=tgRubroId) AS tgExtraId,inmObservacion,inmDirLocalizacion,(SELECT tgNombre FROM TablaGeneral WHERE clsId=1 and tgCodigo=InmDireccion.tgLocalizacionId) AS TgViaNombre,(SELECT tgAbrev FROM TablaGeneral WHERE clsId=1 and tgCodigo=InmDireccion.tgLocalizacionId) AS TgViaAbrev,InmDirNro,inmDirNroInt,InmDirManz,InmDirLote,InmDirSubLote,InmDirFase,InmDirEtapa,InmDirReferencia  FROM Inmueble INNER JOIN InmDireccion ON Inmueble.inmId = InmDireccion.inmId WHERE inmDirActivo=1"
    '    End If

    '    Try
    '        Dim db As Database = DatabaseFactory.CreateDatabase()
    '        Dim cmd As DbCommand = db.GetSqlStringCommand(sql)

    '        drInmueble = db.ExecuteReader(cmd)
    '        While drInmueble.Read()
    '            If ListaInmueble Is Nothing Then
    '                ListaInmueble = New List(Of EEInmueble)()
    '            End If

    '            loInmueble = New EEInmueble()

    '            loInmueble.InmId = drInmueble("InmId").ToString()
    '            loInmueble.InmFile = drInmueble("InmFile").ToString()
    '            loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
    '            loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
    '            loInmueble.InmPartidaElec = drInmueble("InmPartidaElec").ToString()
    '            loInmueble.InmFecMarg = IIf(IsDBNull(drInmueble("InmFecMarg")), Nothing, drInmueble("InmFecMarg"))
    '            loInmueble.tgInmCondReg = drInmueble("tgInmCondReg").ToString()
    '            loInmueble.TgInmEstadoNombre = drInmueble("TgInmEstadoNombre").ToString()
    '            loInmueble.InmDisponibilidad = IIf(IsDBNull(drInmueble("InmDisponibilidad")), False, drInmueble("InmDisponibilidad"))
    '            If drInmueble("inmInscrito") Is DBNull.Value Then
    '                loInmueble.InmInscrito = String.Empty
    '            Else
    '                loInmueble.InmInscrito = drInmueble("inmInscrito").ToString
    '            End If
    '            'Direccion               
    '            Dim loInmDireccion As EEInmDireccion = New EEInmDireccion()
    '            loInmDireccion.InmDirLocalizacion = drInmueble("InmDirLocalizacion").ToString()
    '            loInmDireccion.TgViaNombre = drInmueble("TgViaNombre").ToString()
    '            loInmDireccion.TgViaAbrev = drInmueble("TgViaAbrev").ToString()
    '            loInmDireccion.InmDirNro = drInmueble("InmDirNro").ToString()
    '            loInmDireccion.InmDirNroInt = drInmueble("inmDirNroInt").ToString()
    '            loInmDireccion.InmDirManz = drInmueble("InmDirManz").ToString()
    '            loInmDireccion.InmDirLote = drInmueble("InmDirLote").ToString()
    '            loInmDireccion.InmDirSubLote = drInmueble("InmDirSubLote").ToString()
    '            loInmDireccion.InmDirFase = drInmueble("InmDirFase").ToString()
    '            loInmDireccion.InmDirEtapa = drInmueble("InmDirEtapa").ToString()
    '            loInmDireccion.InmDirReferencia = drInmueble("InmDirReferencia").ToString()

    '            loInmueble.OInmDireccion = loInmDireccion
    '            ListaInmueble.Add(loInmueble)
    '        End While
    '        drInmueble.Close()
    '    Catch ex As Exception
    '        Throw New Exception("Consultar Inmueble XInmId => " & ex.Message, ex)
    '    End Try
    '    Return ListaInmueble
    'End Function
#End Region

#Region "Consulta Inmueble Por Ubicación"
    Public Shared Function inmuebleListarXUbicacionSql(ByVal Sqlwhere As [String]) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim drInmueble As IDataReader = Nothing
        Dim sql As String = ""

        If Sqlwhere <> "" Then
            Dim sql2 As Char() = RTrim(Sqlwhere.ToCharArray())
            If sql2(sql2.Length - 1) = Char.Parse("R") Then
                Sqlwhere = Sqlwhere.Substring(0, Sqlwhere.Length - 3)
            ElseIf sql2(sql2.Length - 1) = Char.Parse("D") Then
                Sqlwhere = Sqlwhere.Substring(0, Sqlwhere.Length - 4)
            End If
            sql = String.Format("{0} AND ({1})", "SELECT Inmueble.inmId,(SELECT tgNombre FROM TablaGeneral WHERE clsId=14 and tgCodigo=TgInmEstado) AS TgInmEstadoNombre,inmFile,inmFileAnt,inmInscrito,inmDenominacion,(SELECT tgNombre FROM TablaGeneral WHERE clsId=27 and tgCodigo=tgInmCondRegId) AS tgInmCondReg,inmPartidaElec,inmDisponibilidad,inmFecMarg,(SELECT tgNombre FROM TablaGeneral WHERE clsId=35 and tgCodigo=tgTipoUnidadId) AS tgTipoUnidadNombre,tgInmEstado,inmDirLocalizacion,(SELECT tgNombre FROM TablaGeneral WHERE clsId=1 and tgCodigo=InmDireccion.tgLocalizacionId) AS TgViaNombre,(SELECT tgAbrev FROM TablaGeneral WHERE clsId=1 and tgCodigo=InmDireccion.tgLocalizacionId) AS TgViaAbrev,InmDirNro,inmDirNroInt,InmDirManz,InmDirLote,InmDirSubLote,InmDirFase,InmDirEtapa,InmDirReferencia FROM Inmueble INNER JOIN InmDireccion ON Inmueble.inmId = InmDireccion.inmId INNER JOIN Ubigeo U ON u.ubgId=InmDireccion.ubgId WHERE inmDirActivo=1", Sqlwhere)
        Else
            sql = "SELECT Inmueble.inmId,(SELECT tgNombre FROM TablaGeneral WHERE clsId=14 and tgCodigo=TgInmEstado) AS TgInmEstadoNombre,inmFile,inmFileAnt,inmInscrito,inmDenominacion,(SELECT tgNombre FROM TablaGeneral WHERE clsId=27 and tgCodigo=tgInmCondRegId) AS tgInmCondReg,inmPartidaElec,inmDisponibilidad,inmFecMarg,(SELECT tgNombre FROM TablaGeneral WHERE clsId=35 and tgCodigo=tgTipoUnidadId) AS tgTipoUnidadNombre,tgInmEstado,inmDirLocalizacion,(SELECT tgNombre FROM TablaGeneral WHERE clsId=1 and tgCodigo=InmDireccion.tgLocalizacionId) AS TgViaNombre,(SELECT tgAbrev FROM TablaGeneral WHERE clsId=1 and tgCodigo=InmDireccion.tgLocalizacionId) AS TgViaAbrev,InmDirNro,inmDirNroInt,InmDirManz,InmDirLote,InmDirSubLote,InmDirFase,InmDirEtapa,InmDirReferencia FROM Inmueble INNER JOIN InmDireccion ON Inmueble.inmId = InmDireccion.inmId INNER JOIN Ubigeo U ON u.ubgId=InmDireccion.ubgId WHERE inmDirActivo=1"
        End If

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetSqlStringCommand(sql)

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If

                loInmueble = New EEInmueble()

                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
                loInmueble.InmPartidaElec = drInmueble("InmPartidaElec").ToString()
                loInmueble.InmFecMarg = IIf(IsDBNull(drInmueble("InmFecMarg")), Nothing, drInmueble("InmFecMarg"))
                loInmueble.tgInmCondReg = drInmueble("tgInmCondReg").ToString()
                loInmueble.TgInmEstadoNombre = drInmueble("TgInmEstadoNombre").ToString()
                loInmueble.InmDisponibilidad = IIf(IsDBNull(drInmueble("InmDisponibilidad")), False, drInmueble("InmDisponibilidad"))
                If drInmueble("inmInscrito") Is DBNull.Value Then
                    loInmueble.InmInscrito = String.Empty
                Else
                    loInmueble.InmInscrito = drInmueble("inmInscrito").ToString
                End If
                'Direccion               
                'Dim loInmDireccion As EEInmDireccion = New EEInmDireccion()
                'loInmDireccion.InmDirLocalizacion = drInmueble("InmDirLocalizacion").ToString()
                'loInmDireccion.TgViaNombre = drInmueble("TgViaNombre").ToString()
                'loInmDireccion.TgViaAbrev = drInmueble("TgViaAbrev").ToString()
                'loInmDireccion.InmDirNro = drInmueble("InmDirNro").ToString()
                'loInmDireccion.InmDirNroInt = drInmueble("inmDirNroInt").ToString()
                'loInmDireccion.InmDirManz = drInmueble("InmDirManz").ToString()
                'loInmDireccion.InmDirLote = drInmueble("InmDirLote").ToString()
                'loInmDireccion.InmDirSubLote = drInmueble("InmDirSubLote").ToString()
                'loInmDireccion.InmDirFase = drInmueble("InmDirFase").ToString()
                'loInmDireccion.InmDirEtapa = drInmueble("InmDirEtapa").ToString()
                'loInmDireccion.InmDirReferencia = drInmueble("InmDirReferencia").ToString()

                ' loInmueble.OInmDireccion = loInmDireccion
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Inmueble X Ubicación InmId => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function
#End Region

#Region "Listar Criterio Consulta Programacion Pagos"
    Public Shared Function listarCriterioConsultaProgramacionPagos(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim drInmueble As IDataReader = Nothing
        Dim drDireccion As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_Inmueble_Criterio_EnConsultorProgramacionPagos_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If

                loInmueble = New EEInmueble()
                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
                loInmueble.InmPartidaElec = drInmueble("InmPartidaElec").ToString()
                loInmueble.InmFecMarg = IIf(IsDBNull(drInmueble("InmFecMarg")), Nothing, drInmueble("InmFecMarg"))
                loInmueble.tgInmCondReg = drInmueble("tgInmCondReg").ToString()
                loInmueble.TgInmEstadoNombre = drInmueble("TgInmEstadoNombre").ToString()
                loInmueble.InmUbicacion = drInmueble("InmUbicacion").ToString()
                loInmueble.InmDisponibilidad = IIf(IsDBNull(drInmueble("InmDisponibilidad")), False, drInmueble("InmDisponibilidad"))
                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Listar Criterio Consulta Programacion Pagos => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function
#End Region
    'WEB
#Region "Consulta Inmueble Por Distintos Criterios WEB"
    Public Shared Function listarCriteriosWEB(ByVal SqlWhere As [String]) As List(Of EEInmueble)
        Dim ListaInmueble As List(Of EEInmueble) = Nothing
        Dim loInmueble As EEInmueble = Nothing
        Dim loUbigeo As EEUbigeo = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim drInmueble As IDataReader = Nothing
        Dim lsSQL As String = String.Empty
        Dim lsSQLResultado As String = String.Empty

        lsSQL = "SELECT Inmueble.inmId,inmFile,inmFileAnt,inmDenominacion,(SELECT inmArch FROM InmArchivos WHERE InmArchivos.inmId=Inmueble.inmId AND inmArchPrincipal=1) AS inmArchivo," & _
           "ubgNombre, case when len(ISNULL(t1.tgAbrev,''))=0 then '' else ISNULL(t1.tgAbrev,'') end +" & _
    "case when len(ISNULL(inmDirLocalizacion,''))=0 then '' else ' ' + ISNULL(inmDirLocalizacion,'') end +" & _
    "case when len(ISNULL(inmDirNro,''))=0 then '' else ' N° ' + ISNULL(inmDirNro,'') end +" & _
    "case when len(ISNULL(inmDirNroInt,''))=0 then '' else ' Int.' + ISNULL(inmDirNroInt,'') end +" & _
    "case when len(ISNULL(inmDirManz,''))=0 then '' else ' Mz.' + ISNULL(inmDirManz,'') end +" & _
    "case when len(ISNULL(inmDirLote,''))=0 then '' else ' Lt.' + ISNULL(inmDirLote,'') end +" & _
    "case when len(ISNULL(inmDirSubLote,''))=0 then '' else ' S-Lt.' + ISNULL(inmDirSubLote,'') end +" & _
    "case when len(ISNULL(inmDirFase,''))=0 then '' else ' ' + ISNULL(inmDirFase,'') end +" & _
    "case when len(ISNULL(inmDirEtapa,''))=0 then '' else ' ' + ISNULL(inmDirEtapa,'') end as inmDirLocalizacion,inmDisponibilidad,(SELECT tgDescripcion FROM TablaGeneral WHERE tgCodigo=Inmueble.tgRubroId AND clsId=33) AS nombreRubro " & _
    "FROM Inmueble INNER JOIN InmDireccion ON Inmueble.inmId = InmDireccion.inmId " & _
    "inner join TablaGeneral t1 on t1.tgCodigo=InmDireccion.tgLocalizacionId and t1.clsId=1" & _
    "LEFT JOIN TablaGeneral e ON e.tgCodigo=Inmueble.tgRubroId and e.clsId=33" & _
    "LEFT JOIN Ubigeo ON InmDireccion.ubgId=Ubigeo.ubgId WHERE inmDirActivo=1 and cast(Inmueble.inmId as int)>264"

        If Not SqlWhere.Equals("0") Then
            Dim sql2 As Char() = RTrim(SqlWhere.ToCharArray())
            If sql2(sql2.Length - 1) = Char.Parse("R") Then
                SqlWhere = SqlWhere.Substring(0, SqlWhere.Length - 3)
            ElseIf sql2(sql2.Length - 1) = Char.Parse("D") Then
                SqlWhere = SqlWhere.Substring(0, SqlWhere.Length - 4)
            End If
            lsSQLResultado = String.Format("{0} AND {1}", lsSQL, SqlWhere)
        Else
            lsSQLResultado = lsSQL
        End If


        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetSqlStringCommand(lsSQLResultado)

            drInmueble = db.ExecuteReader(cmd)
            While drInmueble.Read()
                If ListaInmueble Is Nothing Then
                    ListaInmueble = New List(Of EEInmueble)()
                End If

                loInmueble = New EEInmueble()

                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
                loInmueble.TgRubro = drInmueble("NombreRubro").ToString()

                loInmDireccion = New EEInmDireccion()

                loUbigeo = New EEUbigeo()
                'loUbigeo.UbgId = drDireccion("UbgId").ToString()
                'loUbigeo.UbgDep = drDireccion("UbgDep").ToString()
                'loUbigeo.UbgProv = drDireccion("UbgProv").ToString()
                'loUbigeo.UbgDist = drDireccion("UbgDist").ToString()
                loUbigeo.UbgNombre = drInmueble("UbgNombre").ToString()

                'loInmDireccion.InmDirId = drDireccion("InmDirId").ToString()
                'loInmDireccion.InmId = drDireccion("InmId").ToString()
                loInmDireccion.OUbigeo = loUbigeo
                loInmDireccion.InmDirLocalizacion = drInmueble("InmDirLocalizacion").ToString()

                loInmueble.OInmDireccion = loInmDireccion

                If Not IsDBNull(drInmueble("inmArchivo")) Then
                    loInmueble.InmArchDivision = DirectCast(drInmueble("inmArchivo"), Byte())
                End If

                loInmueble.InmDisponibilidad = IIf(IsDBNull(drInmueble("InmDisponibilidad")), False, drInmueble("InmDisponibilidad"))

                ListaInmueble.Add(loInmueble)
            End While
            drInmueble.Close()
        Catch ex As Exception
            Throw New Exception("Consultar Inmueble XInmId => " & ex.Message, ex)
        End Try
        Return ListaInmueble
    End Function
#End Region

#Region "Consultar Inmueble XInmId WEB"
    Public Shared Function consultarXInmIdWEB(ByVal asInmId As [String]) As EEInmueble
        Dim loInmueble As EEInmueble = Nothing
        Dim loInmDireccion As EEInmDireccion = Nothing
        Dim loTablaGeneral As EETablaGeneral = Nothing
        Dim loUbigeo As EEUbigeo = Nothing
        Dim loPersona As EEPersona = Nothing
        Dim drInmueble As IDataReader = Nothing
        Dim drDireccion As IDataReader = Nothing
        Dim drPredio As IDataReader = Nothing
        Dim drArchivos As IDataReader = Nothing
        Dim drDivisiones As IDataReader = Nothing
        Dim drSuministros As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Consultar_Inmueble_XInmId_WEB_pa")
            db.AddInParameter(cmd, "inmid", DbType.String, asInmId)

            drInmueble = db.ExecuteReader(cmd)
            If drInmueble.Read() Then
                loInmueble = New EEInmueble()

                loInmueble.InmId = drInmueble("InmId").ToString()
                loInmueble.InmFile = drInmueble("InmFile").ToString()
                loInmueble.InmDenominacion = drInmueble("InmDenominacion").ToString()
                loInmueble.TgTipoUnidadNombre = drInmueble("tgTipoUnidadNombre").ToString()
                loInmueble.InmInscrito = drInmueble("InmInscrito").ToString()
                loInmueble.TgInmEstadoNombre = drInmueble("tgEstadoNombre").ToString()
                loInmueble.InmIdPadre = drInmueble("InmIdPadre").ToString()
                loInmueble.InmFilePadre = drInmueble("InmFilePadre").ToString()
                loInmueble.InmFecMarg = IIf(IsDBNull(drInmueble("InmFecMarg")), Nothing, drInmueble("InmFecMarg"))
                loInmueble.InmFileAnt = drInmueble("InmFileAnt").ToString()
                loInmueble.TgRubroGrupo = drInmueble("tgRubroGrupoNombre").ToString()
                loInmueble.TgRubro = drInmueble("tgRubroEspecifico").ToString()
                loInmueble.InmDisponibilidad = IIf(IsDBNull(drInmueble("InmDisponibilidad")), False, drInmueble("InmDisponibilidad"))
                loInmueble.InmDocAcredita = drInmueble("InmDocAcredita").ToString()
                loInmueble.tgInmCondReg = drInmueble("tgSituacionLegalNombre").ToString()
                ' loInmueble.TgInmSituacionNombre = drInmueble("tgSituacionNombre").ToString()
                loInmueble.InmPartidaElec = drInmueble("InmPartidaElec").ToString()
                loInmueble.InmAsiento = drInmueble("InmAsiento").ToString()
                loInmueble.tgEstSan = drInmueble("tgEstadoSaneadoNombre").ToString()
                loInmueble.InmActivo = IIf(IsDBNull(drInmueble("InmActivo")), False, drInmueble("InmActivo"))
                loInmueble.InmSaneadoObs = drInmueble("inmSaneadoObs").ToString()
                loInmueble.tgEstInmConsv = drInmueble("tgEstadoConservacionNombre").ToString()
                loInmueble.InmNroPisos = drInmueble("InmNroPisos").ToString()
                loInmueble.InmObservacion = drInmueble("InmObservacion").ToString()

                'Direccion
                cmd = db.GetStoredProcCommand("Mostrar_InmDireccion_XImnId_WEB_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDireccion = db.ExecuteReader(cmd)

                If drDireccion.Read Then
                    loInmDireccion = New EEInmDireccion()

                    loInmDireccion.InmDirId = drDireccion("InmDirId").ToString()
                    loInmDireccion.InmId = drDireccion("InmId").ToString()
                    loInmDireccion.InmDirDepartamento = drDireccion("Departamento").ToString()
                    loInmDireccion.InmDirProvincia = drDireccion("Provincia").ToString()
                    loInmDireccion.InmDirDistrito = drDireccion("Distrito").ToString()
                    loInmDireccion.InmDirLocalizacion = drDireccion("InmDirLocalizacion").ToString()
                    ' loInmDireccion.TgViaNombre = drDireccion("tgViaNombre").ToString()
                    loInmDireccion.InmDirNro = drDireccion("InmDirNro").ToString()
                    '  loInmDireccion.InmDirNroInt = drDireccion("InmDirNroInt").ToString()
                    ' loInmDireccion.InmDirManz = drDireccion("InmDirManz").ToString()
                    '  loInmDireccion.InmDirLote = drDireccion("InmDirLote").ToString()
                    '   loInmDireccion.InmDirSubLote = drDireccion("InmDirSubLote").ToString()
                    loInmDireccion.InmDirFase = drDireccion("InmDirFase").ToString()
                    loInmDireccion.InmDirEtapa = drDireccion("InmDirEtapa").ToString()
                    loInmDireccion.InmDirReferencia = drDireccion("InmDirReferencia").ToString()
                    '     loInmDireccion.InmDirActivo = Convert.ToBoolean(drDireccion("InmDirActivo").ToString())

                    loInmueble.OInmDireccion = loInmDireccion
                End If

                drDireccion.Close()

                'Predio
                cmd = db.GetStoredProcCommand("Mostrar_InmPredio_XInmId_WEB_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drPredio = db.ExecuteReader(cmd)

                If drPredio.Read Then
                    Dim loInmPredio As EEInmPredio = New EEInmPredio()

                    loInmPredio.InmPredId = drPredio("InmPredId").ToString()
                    loInmPredio.InmId = drPredio("InmId").ToString()
                    loInmPredio.InmPredFecTas = IIf(IsDBNull(drPredio("InmPredFecTas")), Nothing, drPredio("InmPredFecTas"))
                    loInmPredio.InmPredAño = drPredio("InmPredAño").ToString()

                    loInmPredio.InmPredArea = IIf(IsDBNull(drPredio("InmPredArea")), Nothing, drPredio("InmPredArea"))
                    loInmPredio.InmPredArancel = IIf(IsDBNull(drPredio("InmPredArancel")), Nothing, drPredio("InmPredArancel"))
                    loInmPredio.InmPredValorTerreno = IIf(IsDBNull(drPredio("InmPredValorTerreno")), Nothing, drPredio("InmPredValorTerreno"))
                    loInmPredio.InmPredAreaTechada = IIf(IsDBNull(drPredio("InmPredAreaTechada")), Nothing, drPredio("InmPredAreaTechada"))
                    loInmPredio.InmPredValorConst = IIf(IsDBNull(drPredio("InmPredValorConst")), Nothing, drPredio("InmPredValorConst"))
                    loInmPredio.InmPredValorEdificacion = IIf(IsDBNull(drPredio("InmPredValorEdificacion")), Nothing, drPredio("InmPredValorEdificacion"))
                    loInmPredio.InmPredValorTotal = IIf(IsDBNull(drPredio("InmPredValorTotal")), Nothing, drPredio("InmPredValorTotal"))
                    loInmPredio.InmPredActivo = IIf(IsDBNull(drPredio("InmPredActivo")), Nothing, drPredio("InmPredActivo"))

                    loInmueble.OInmPredio = loInmPredio
                End If
                drPredio.Close()

                'Archivos
                cmd = db.GetStoredProcCommand("Mostrar_InmArchivos_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drArchivos = db.ExecuteReader(cmd)
                While drArchivos.Read()
                    Dim loInmArchivos As EEInmArchivos = New EEInmArchivos()

                    loInmArchivos.InmArchId = drArchivos("InmArchId").ToString()
                    loInmArchivos.InmId = drArchivos("InmId").ToString()
                    loInmArchivos.InmArchNombre = drArchivos("InmArchNombre").ToString()
                    loInmArchivos.InmArchDescripcion = drArchivos("InmArchDescripcion").ToString()
                    loInmArchivos.TgTipoArchId = drArchivos("TgTipoArchId").ToString()
                    loInmArchivos.InmArchExt = drArchivos("InmArchExt").ToString()
                    loInmArchivos.InmArchPrincipal = Convert.ToBoolean(drArchivos("InmArchPrincipal").ToString())
                    loInmArchivos.TgNombre = drArchivos("tgNombre").ToString()
                    If IsDBNull(drArchivos("InmArchActivo")) = False Then
                        loInmArchivos.InmArchActivo = Convert.ToBoolean(drArchivos("InmArchActivo"))
                    End If
                    loInmueble.ListaInmArchivos.Add(loInmArchivos)
                End While
                drArchivos.Close()

                'Suministros
                cmd = db.GetStoredProcCommand("Mostrar_InmSuministros_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drSuministros = db.ExecuteReader(cmd)
                While drSuministros.Read()
                    Dim loInmSuministros As EEInmSuministros = New EEInmSuministros()
                    loInmSuministros.InmSumId = drSuministros("InmSumId").ToString()
                    loInmSuministros.InmId = drSuministros("InmId").ToString()
                    loPersona = New EEPersona()
                    loPersona.PerId = drSuministros("PerId").ToString()
                    loPersona.PerRazonSocial = drSuministros("perRazonSocial").ToString()
                    loInmSuministros.OPersona = loPersona
                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgNombre = drSuministros("tgTipoServNombre").ToString()
                    loTablaGeneral.TgCodigo = drSuministros("tgTipoServId").ToString()
                    loInmSuministros.TgTipoServicio = loTablaGeneral
                    loInmSuministros.InmSumFechaVen = IIf(IsDBNull(drSuministros("InmSumFechaVen")), Nothing, drSuministros("InmSumFechaVen"))
                    loTablaGeneral = New EETablaGeneral()
                    loTablaGeneral.TgNombre = drSuministros("tgTipoMesNombre").ToString()
                    loTablaGeneral.TgCodigo = drSuministros("tgTipoMesId").ToString()
                    loInmSuministros.TgTipoMes = loTablaGeneral
                    loInmSuministros.InmSumAño = Convert.ToInt32(drSuministros("InmSumAño").ToString())
                    loInmSuministros.InmSumMonto = Convert.ToDecimal(drSuministros("InmSumMonto").ToString())
                    loInmSuministros.InmSumMedidor = drSuministros("InmSumMedidor").ToString()
                    loInmueble.ListaInmSuministros.Add(loInmSuministros)
                End While
                drSuministros.Close()

                'Divisiones
                cmd = db.GetStoredProcCommand("Mostrar_Inmueble_Divisiones_XInmId_pa")
                db.AddInParameter(cmd, "inmid", DbType.String, loInmueble.InmId)
                drDivisiones = db.ExecuteReader(cmd)

                Dim loInmuebleDivisiones As EEInmueble = Nothing
                While drDivisiones.Read()
                    If loInmueble.ListaDivisiones Is Nothing Then
                        loInmueble.ListaDivisiones = New List(Of EEInmueble)
                    End If

                    loInmuebleDivisiones = New EEInmueble()
                    loInmuebleDivisiones.InmId = drDivisiones("InmId").ToString()
                    loInmuebleDivisiones.InmFile = drDivisiones("InmFile").ToString()
                    loInmuebleDivisiones.TgRubro = drDivisiones("NombreRubro").ToString()

                    loInmDireccion = New EEInmDireccion()

                    loUbigeo = New EEUbigeo()
                    'loUbigeo.UbgId = drDireccion("UbgId").ToString()
                    'loUbigeo.UbgDep = drDireccion("UbgDep").ToString()
                    'loUbigeo.UbgProv = drDireccion("UbgProv").ToString()
                    'loUbigeo.UbgDist = drDireccion("UbgDist").ToString()
                    loUbigeo.UbgNombre = drDivisiones("UbgNombre").ToString()

                    'loInmDireccion.InmDirId = drDireccion("InmDirId").ToString()
                    'loInmDireccion.InmId = drDireccion("InmId").ToString()
                    loInmDireccion.OUbigeo = loUbigeo
                    loInmDireccion.InmDirLocalizacion = drDivisiones("InmDirLocalizacion").ToString()

                    loInmuebleDivisiones.OInmDireccion = loInmDireccion

                    If Not IsDBNull(drDivisiones("inmArchivo")) Then
                        loInmuebleDivisiones.InmArchDivision = DirectCast(drDivisiones("inmArchivo"), Byte())
                    End If
                    loInmueble.ListaDivisiones.Add(loInmuebleDivisiones)
                End While
                drDivisiones.Close()
            End If

        Catch ex As Exception
            Throw New Exception("Listar Criterio Inmueble => " & ex.Message, ex)
        End Try
        Return loInmueble
    End Function
#End Region

End Class