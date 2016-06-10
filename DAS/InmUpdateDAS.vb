Imports Entidades
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Public Class InmUpdateDAS

    Public Shared Function listarXcriterio(ByVal tpCriterio As String, ByVal criterio As String, Optional ByVal anio As String = Nothing) As List(Of EEInmueble.EEInmLogs)
        Dim ListaInmueblesUpdate As List(Of EEInmueble.EEInmLogs) = Nothing
        Dim loInmueblesUpdate As EEInmueble.EEInmLogs = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_InmUpdate_XCriterios_pa")
            db.AddInParameter(cmd, "tpCriterio", DbType.Int16, tpCriterio)
            db.AddInParameter(cmd, "criterio", DbType.String, criterio)
            db.AddInParameter(cmd, "anio", DbType.String, anio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaInmueblesUpdate Is Nothing Then
                    ListaInmueblesUpdate = New List(Of EEInmueble.EEInmLogs)()
                End If
                loInmueblesUpdate = New EEInmueble.EEInmLogs()
                loInmueblesUpdate.InmId = dr("InmId").ToString()
                loInmueblesUpdate.InmCodigo = dr("InmCodigo").ToString()
                loInmueblesUpdate.InmUbicacion = dr("InmUbicacion").ToString()
                loInmueblesUpdate.InmUpdFechaReg = dr("InmUpdFechaReg").ToString()
                loInmueblesUpdate._usuLogin = dr("usuLogin").ToString()
                loInmueblesUpdate.InmUpdId = dr("inmUpdId").ToString()
                loInmueblesUpdate.InmUpdDetId = dr("inmUpdDetId").ToString()
                loInmueblesUpdate._InmUpdDetCampoText = dr("inmUpdDetCampoText").ToString()
                loInmueblesUpdate._InmUpdDetValorOld = dr("inmUpdDetValorOld").ToString()
                loInmueblesUpdate._InmUpdDetValorNew = dr("inmUpdDetValorNew").ToString()
                ListaInmueblesUpdate.Add(loInmueblesUpdate)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Inmuebles Updates X Criterio => " + ex.Message, ex)
        End Try
        Return ListaInmueblesUpdate
    End Function
    Public Shared Function InmUpdDocXInmId(ByVal inmId As String) As String
        Dim InmUpdDoc As String = String.Empty
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_InmUpdate_InmUpdDoc_XInmId_pa")
            db.AddInParameter(cmd, "inmId", DbType.String, inmId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                InmUpdDoc = dr("InmUpdDoc").ToString()
            End If
 
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Inmuebles Updates InmUpdDoc => " + ex.Message, ex)
        End Try
        Return InmUpdDoc
    End Function

    Public Shared Function IsPendienteXInmId(ByVal inmId As String) As List(Of EEInmueble.EEInmLogs)
        Dim ListaInmueblesUpdate As List(Of EEInmueble.EEInmLogs) = Nothing
        Dim loInmueblesUpdate As EEInmueble.EEInmLogs = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_InmUpdate_IsPendiente_By_InmId_pa")
            db.AddInParameter(cmd, "inmId", DbType.String, inmId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaInmueblesUpdate Is Nothing Then
                    ListaInmueblesUpdate = New List(Of EEInmueble.EEInmLogs)()
                End If
                loInmueblesUpdate = New EEInmueble.EEInmLogs()
                loInmueblesUpdate.InmCodigo = dr("InmCodigo").ToString()
                loInmueblesUpdate._InmUpdDetCampoText = dr("inmUpdDetCampoText").ToString()
                loInmueblesUpdate._InmUpdDetValorOld = dr("inmUpdDetValorOld").ToString()
                loInmueblesUpdate._InmUpdDetValorNew = dr("inmUpdDetValorNew").ToString()
                ListaInmueblesUpdate.Add(loInmueblesUpdate)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Inmuebles Updates X Criterio => " + ex.Message, ex)
        End Try
        Return ListaInmueblesUpdate
    End Function


    Public Shared Function ProcesadoslistarXcriterio(ByVal aoVariableConsultas As EECriterios) As List(Of EEInmueble.EEInmLogs)
        Dim ListaInmueblesUpdate As List(Of EEInmueble.EEInmLogs) = Nothing
        Dim loInmueblesUpdate As EEInmueble.EEInmLogs = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_InmUpdateProcesadas_XCriterios_pa")
            If aoVariableConsultas.FechaInicio <> "#12:00:00 AM#" Then
                db.AddInParameter(cmd, "fechaInicio", DbType.Date, aoVariableConsultas.FechaInicio)
            End If
            If aoVariableConsultas.FechaFin <> "#12:00:00 AM#" Then
                db.AddInParameter(cmd, "fechaFin", DbType.Date, aoVariableConsultas.FechaFin)
            End If
            If aoVariableConsultas.tgRubroId <> Nothing Then
                db.AddInParameter(cmd, "tgRubroId", DbType.String, aoVariableConsultas.tgRubroId)
            End If
            If aoVariableConsultas.tgGRubroId <> Nothing Then
                db.AddInParameter(cmd, "tgGRubroId", DbType.String, aoVariableConsultas.tgGRubroId)
            End If
            If aoVariableConsultas.inmFile <> Nothing Then
                db.AddInParameter(cmd, "inmfile", DbType.String, aoVariableConsultas.inmFile)
            End If
            If aoVariableConsultas.inmFileAnt <> Nothing Then
                db.AddInParameter(cmd, "inmfileAnt", DbType.String, aoVariableConsultas.inmFileAnt)
            End If
            If aoVariableConsultas.inmUpdDetCampo <> Nothing Then
                db.AddInParameter(cmd, "inmUpdDetCampo", DbType.String, aoVariableConsultas.inmUpdDetCampo)
            End If
            If aoVariableConsultas.inmUpdDetValorNew <> Nothing Then
                db.AddInParameter(cmd, "inmUpdDetValorNew", DbType.String, aoVariableConsultas.inmUpdDetValorNew)
            End If
            If aoVariableConsultas.tpCriterio <> Nothing Then
                db.AddInParameter(cmd, "tpCriterio", DbType.Int16, aoVariableConsultas.tpCriterio)
            End If
            If aoVariableConsultas.Criterio <> Nothing Then
                db.AddInParameter(cmd, "criterio", DbType.String, aoVariableConsultas.Criterio)
            End If
            If aoVariableConsultas.anio <> Nothing Then
                db.AddInParameter(cmd, "anio", DbType.String, aoVariableConsultas.anio)
            End If

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaInmueblesUpdate Is Nothing Then
                    ListaInmueblesUpdate = New List(Of EEInmueble.EEInmLogs)()
                End If
                loInmueblesUpdate = New EEInmueble.EEInmLogs()
                loInmueblesUpdate.tgTipoUpd = dr("tgTipoUpd").ToString()
                loInmueblesUpdate.inmUpdSup = dr("inmUpdSup").ToString()
                loInmueblesUpdate.Nro = dr("Nro").ToString()
                loInmueblesUpdate.InmId = dr("InmId").ToString()
                loInmueblesUpdate.InmUpdId = dr("InmUpdId").ToString()
                loInmueblesUpdate.InmCodigo = dr("InmCodigo").ToString()
                loInmueblesUpdate.InmUbicacion = dr("InmUbicacion").ToString()
                loInmueblesUpdate.InmUpdFechaReg = dr("InmUpdFechaReg").ToString()
                loInmueblesUpdate.InmUpdFecRegUpd = dr("InmUpdFecRegUpd").ToString()
                loInmueblesUpdate.InmUpdFecDoc = dr("InmUpdFecDoc").ToString()
                loInmueblesUpdate.inmUpdDoc = dr("inmUpdDoc").ToString()
                loInmueblesUpdate._InmUpdDetCampo = dr("inmUpdDetCampo").ToString()
                loInmueblesUpdate._InmUpdDetCampoText = dr("inmUpdDetCampoText").ToString()
                loInmueblesUpdate._InmUpdDetValorOld = dr("inmUpdDetValorOld").ToString()
                loInmueblesUpdate._InmUpdDetValorNew = dr("inmUpdDetValorNew").ToString()
                loInmueblesUpdate._InmUpdDetValorNew2 = dr("inmUpdDetValorNew2").ToString()
                loInmueblesUpdate.inmUpdObservacion = dr("inmUpdObs").ToString()
                loInmueblesUpdate.inmUpdMotivo = dr("inmUpdMov").ToString()
                ListaInmueblesUpdate.Add(loInmueblesUpdate)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Inmuebles Procesados Updates X Criterio => " + ex.Message, ex)
        End Try
        Return ListaInmueblesUpdate
    End Function


    Public Shared Function listarCriteriosBuscar(ByVal tp As Integer, ByVal c As String) As List(Of EEInmueble.EEInmLogs)
        Dim ListaInmueblesUpdate As List(Of EEInmueble.EEInmLogs) = Nothing
        Dim loInmueblesUpdate As EEInmueble.EEInmLogs = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_InmUpdate_CboCriteriosBusquedas_pa")
            db.AddInParameter(cmd, "c", DbType.String, c)
            db.AddInParameter(cmd, "tp", DbType.String, tp)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaInmueblesUpdate Is Nothing Then
                    ListaInmueblesUpdate = New List(Of EEInmueble.EEInmLogs)()
                End If
                loInmueblesUpdate = New EEInmueble.EEInmLogs()
                If tp = 1 Then
                    loInmueblesUpdate._InmUpdDetCampoText = dr("InmUpdDetCampoText").ToString()
                    loInmueblesUpdate._InmUpdDetCampo = dr("InmUpdDetCampo").ToString()
                ElseIf tp = 2 Then
                    loInmueblesUpdate._InmUpdDetValorNew = dr("InmUpdDetValorNew").ToString()
                    loInmueblesUpdate._InmUpdDetValorNew2 = dr("InmUpdDetValorNew2").ToString()
                End If
             
                
                ListaInmueblesUpdate.Add(loInmueblesUpdate)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar Inmuebles Procesados Updates X Criterio => " + ex.Message, ex)
        End Try
        Return ListaInmueblesUpdate
    End Function

    Public Shared Function InmUpdDetCampoTextXInmUpdId(ByVal inmUpdId As String) As List(Of EEInmueble.EEInmLogs.EEInmLogsDet)
        Dim ListaInmueblesUpdateDet As List(Of EEInmueble.EEInmLogs.EEInmLogsDet) = Nothing
        Dim loInmueblesUpdateDet As EEInmueble.EEInmLogs.EEInmLogsDet = Nothing

        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_inmUpdDetCampoText_XInmUpdId_pa")
            db.AddInParameter(cmd, "inmUpdId", DbType.String, inmUpdId)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaInmueblesUpdateDet Is Nothing Then
                    ListaInmueblesUpdateDet = New List(Of EEInmueble.EEInmLogs.EEInmLogsDet)()
                End If
                loInmueblesUpdateDet = New EEInmueble.EEInmLogs.EEInmLogsDet()
                loInmueblesUpdateDet.InmUpdDetId = dr("inmUpdDetId").ToString()
                loInmueblesUpdateDet.InmUpdDetCampoText = dr("inmUpdDetCampoText").ToString()
                ListaInmueblesUpdateDet.Add(loInmueblesUpdateDet)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("CampoText X InmUpdId => " + ex.Message, ex)
        End Try
        Return ListaInmueblesUpdateDet
    End Function
    Public Shared Function InmUpdateXInmUpdId(ByVal inmUpdId As String) As EEInmueble.EEInmLogs
        Dim loInmueblesUpdate As EEInmueble.EEInmLogs = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_InmUpdate_XInmUpdId_pa")
            db.AddInParameter(cmd, "inmUpdId", DbType.String, inmUpdId)
            dr = db.ExecuteReader(cmd)
            If dr.Read() Then
                loInmueblesUpdate = New EEInmueble.EEInmLogs
                loInmueblesUpdate.inmUpdDoc = dr("inmUpdDoc").ToString()
                loInmueblesUpdate.inmUpdObservacion = dr("inmUpdObs").ToString()
                loInmueblesUpdate.inmUpdMotivo = dr("inmUpdMov").ToString()
                loInmueblesUpdate.inmUpdSupId = dr("inmUpdSupId").ToString()

                If IsDate(dr("InmUpdFecDoc")) Then
                    loInmueblesUpdate.InmUpdFecDoc = dr("InmUpdFecDoc")
                End If
                If IsDate(dr("InmUpdFecRegUpd")) Then
                    loInmueblesUpdate.InmUpdFecRegUpd = dr("InmUpdFecRegUpd")
                End If
                loInmueblesUpdate.InmUpdPerUpdId = dr("inmUpdPerUpdId").ToString()
                loInmueblesUpdate.tgTipoUpdId = dr("tgTipoUpdId").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("InmuebleUpdate X InmUpdId => " + ex.Message, ex)
        End Try
        Return loInmueblesUpdate
    End Function
    Public Shared Function InmUpdDetValorOld_NewXInmUpdDetId(ByVal inmUpdDetId As String) As EEInmueble.EEInmLogs.EEInmLogsDet
        Dim loInmueblesUpdateDet As EEInmueble.EEInmLogs.EEInmLogsDet = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_inmUpdDetValorOld_New_XinmUpdDetId_pa")
            db.AddInParameter(cmd, "inmUpdDetId", DbType.String, inmUpdDetId)

            dr = db.ExecuteReader(cmd)
            If dr.Read() Then

                loInmueblesUpdateDet = New EEInmueble.EEInmLogs.EEInmLogsDet()
                loInmueblesUpdateDet.InmUpdDetValorOld = dr("inmUpdDetValorOld").ToString()
                loInmueblesUpdateDet.InmUpdDetValorNew = dr("inmUpdDetValorNew").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            Throw New Exception("ValorOld_New X InmUpdId => " + ex.Message, ex)
        End Try
        Return loInmueblesUpdateDet
    End Function
End Class

