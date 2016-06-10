Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class ContratoInmDAO
    Public Shared Function guardaryGProgramacion(ByVal aoContratoInm As EEContratoInm) As String
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_ContratoInm_GProgramacion_pa")
            db.AddOutParameter(cmd, "coninmid", DbType.String, 10)
            db.AddInParameter(cmd, "inmid", DbType.String, aoContratoInm.InmId)
            db.AddInParameter(cmd, "coninmdocref", DbType.String, aoContratoInm.ConInmDocRef)
            db.AddInParameter(cmd, "conInmRegMesPart", DbType.String, aoContratoInm.conInmRegMesPart)
            db.AddInParameter(cmd, "perid", DbType.String, aoContratoInm.PerId)
            'db.AddInParameter(cmd, "usuid", DbType.String, aoContratoInm.UsuId)
            db.AddInParameter(cmd, "coninmgarantia", DbType.Decimal, aoContratoInm.ConInmGarantia)
            db.AddInParameter(cmd, "coninmderllaves", DbType.Decimal, aoContratoInm.ConInmDerLlaves)
            db.AddInParameter(cmd, "coninmmerced", DbType.Decimal, aoContratoInm.ConInmMerced)
            db.AddInParameter(cmd, "coninmfecini", DbType.DateTime, aoContratoInm.ConInmFecIni)
            db.AddInParameter(cmd, "coninmfecfin", DbType.DateTime, aoContratoInm.ConInmFecFin)
            db.AddInParameter(cmd, "coninmfecSol", DbType.DateTime, aoContratoInm.ConInmFecSol)
            db.AddInParameter(cmd, "coninmfecSus", DbType.DateTime, aoContratoInm.ConInmFecSus)
            'db.AddInParameter(cmd, "coninmfecreg", DbType.DateTime, aoContratoInm.ConInmFecReg)
            db.AddInParameter(cmd, "coninmdiamaxven", DbType.Int32, aoContratoInm.ConInmDiaMaxVen)
            db.AddInParameter(cmd, "tgusoid", DbType.String, aoContratoInm.TgUsoId)
            db.AddInParameter(cmd, "tgestid", DbType.String, aoContratoInm.TgEstId)
            db.AddInParameter(cmd, "tgmonid", DbType.String, aoContratoInm.TgMonId)
            db.AddInParameter(cmd, "tgmodid", DbType.String, aoContratoInm.TgModId)
            db.AddInParameter(cmd, "tgCompId", DbType.String, aoContratoInm.tgCompId)
            db.AddInParameter(cmd, "tgGarId", DbType.String, aoContratoInm.TgGarId)
            db.AddInParameter(cmd, "coninmobs", DbType.String, aoContratoInm.ConInmObs)
            db.ExecuteNonQuery(cmd)

            Dim lsConInmIdOut As String = db.GetParameterValue(cmd, "ConInmid").ToString()
            For Each fArchivos As EEConArchivos In aoContratoInm.ListaConInmArchivos
                cmd = db.GetStoredProcCommand("Insertar_ConInmArchivos_pa")
                db.AddInParameter(cmd, "ConInmid", DbType.String, lsConInmIdOut)
                db.AddInParameter(cmd, "ConInmArchNombre", DbType.String, fArchivos.ConInmArchNombre)
                db.AddInParameter(cmd, "ConInmArchDescripcion", DbType.String, fArchivos.ConInmArchDescripcion)
                db.AddInParameter(cmd, "tgtipoarchid", DbType.String, fArchivos.TgTipoArchId)
                db.AddInParameter(cmd, "ConInmArch", DbType.Binary, fArchivos.ConInmArch)
                db.AddInParameter(cmd, "ConInmArchExt", DbType.String, fArchivos.ConInmArchExt)
                db.ExecuteNonQuery(cmd)
            Next


            Return (db.GetParameterValue(cmd, "coninmid"))

        Catch ex As Exception
            Throw New Exception("Guardar ContratoInm => " + ex.Message, ex)
        End Try
        Return True
    End Function
    Public Shared Function guardar(ByVal aoContratoInm As EEContratoInm) As String
        Try

            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Insertar_ContratoInm_pa")
            db.AddOutParameter(cmd, "coninmid", DbType.String, 10)
            'db.AddInParameter(cmd, "coninmid", DbType.String, aoContratoInm.ConInmId)
            db.AddInParameter(cmd, "inmid", DbType.String, aoContratoInm.InmId)
            db.AddInParameter(cmd, "coninmdocref", DbType.String, aoContratoInm.ConInmDocRef)
            db.AddInParameter(cmd, "conInmRegMesPart", DbType.String, aoContratoInm.conInmRegMesPart)
            db.AddInParameter(cmd, "perid", DbType.String, aoContratoInm.PerId)
            'db.AddInParameter(cmd, "usuid", DbType.String, aoContratoInm.UsuId)
            db.AddInParameter(cmd, "coninmgarantia", DbType.Decimal, aoContratoInm.ConInmGarantia)
            db.AddInParameter(cmd, "coninmderllaves", DbType.Decimal, aoContratoInm.ConInmDerLlaves)
            db.AddInParameter(cmd, "coninmmerced", DbType.Decimal, aoContratoInm.ConInmMerced)
            db.AddInParameter(cmd, "coninmfecini", DbType.DateTime, aoContratoInm.ConInmFecIni)
            db.AddInParameter(cmd, "coninmfecfin", DbType.DateTime, aoContratoInm.ConInmFecFin)
            db.AddInParameter(cmd, "coninmfecSol", DbType.DateTime, aoContratoInm.ConInmFecSol)
            db.AddInParameter(cmd, "coninmfecSus", DbType.DateTime, aoContratoInm.ConInmFecSus)
            'db.AddInParameter(cmd, "coninmfecreg", DbType.DateTime, aoContratoInm.ConInmFecReg)
            db.AddInParameter(cmd, "coninmdiamaxven", DbType.Int32, aoContratoInm.ConInmDiaMaxVen)
            db.AddInParameter(cmd, "tgusoid", DbType.String, aoContratoInm.TgUsoId)
            db.AddInParameter(cmd, "tgestid", DbType.String, aoContratoInm.TgEstId)
            db.AddInParameter(cmd, "tgmonid", DbType.String, aoContratoInm.TgMonId)
            db.AddInParameter(cmd, "tgmodid", DbType.String, aoContratoInm.TgModId)
            db.AddInParameter(cmd, "tgCompId", DbType.String, aoContratoInm.tgCompId)
            db.AddInParameter(cmd, "tgGarId", DbType.String, aoContratoInm.TgGarId)
            db.AddInParameter(cmd, "coninmobs", DbType.String, aoContratoInm.ConInmObs)



            'Archivos
         
            

            db.ExecuteNonQuery(cmd)
            Return (db.GetParameterValue(cmd, "coninmid"))
        Catch ex As Exception
            Throw New Exception("Guardar ContratoInm => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function actualizar(ByVal aoContratoInm As EEContratoInm) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_ContratoInm_pa")
            db.AddInParameter(cmd, "coninmid", DbType.String, aoContratoInm.ConInmId)
            db.AddInParameter(cmd, "inmid", DbType.String, aoContratoInm.InmId)
            db.AddInParameter(cmd, "coninmdocref", DbType.String, aoContratoInm.ConInmDocRef)
            db.AddInParameter(cmd, "conInmRegMesPart", DbType.String, aoContratoInm.conInmRegMesPart)
            ' db.AddInParameter(cmd, "perid", DbType.String, aoContratoInm.PerId)
            'db.AddInParameter(cmd, "usuid", DbType.String, aoContratoInm.UsuId)
            db.AddInParameter(cmd, "coninmgarantia", DbType.Decimal, aoContratoInm.ConInmGarantia)
            db.AddInParameter(cmd, "coninmderllaves", DbType.Decimal, aoContratoInm.ConInmDerLlaves)
            db.AddInParameter(cmd, "coninmmerced", DbType.Decimal, aoContratoInm.ConInmMerced)
            db.AddInParameter(cmd, "coninmfecini", DbType.DateTime, aoContratoInm.ConInmFecIni)
            db.AddInParameter(cmd, "coninmfecfin", DbType.DateTime, aoContratoInm.ConInmFecFin)
            db.AddInParameter(cmd, "coninmfecSol", DbType.DateTime, aoContratoInm.ConInmFecSol)
            db.AddInParameter(cmd, "coninmfecSus", DbType.DateTime, aoContratoInm.ConInmFecSus)
            'db.AddInParameter(cmd, "coninmfecreg", DbType.DateTime, aoContratoInm.ConInmFecReg)
            db.AddInParameter(cmd, "coninmdiamaxven", DbType.Int32, aoContratoInm.ConInmDiaMaxVen)
            db.AddInParameter(cmd, "tgusoid", DbType.String, aoContratoInm.TgUsoId)
            db.AddInParameter(cmd, "tgestid", DbType.String, aoContratoInm.TgEstId)
            db.AddInParameter(cmd, "tgmonid", DbType.String, aoContratoInm.TgMonId)
            db.AddInParameter(cmd, "tgmodid", DbType.String, aoContratoInm.TgModId)
            db.AddInParameter(cmd, "tgCompId", DbType.String, aoContratoInm.tgCompId)
            db.AddInParameter(cmd, "tgGarId", DbType.String, aoContratoInm.TgGarId)
            db.AddInParameter(cmd, "coninmobs", DbType.String, aoContratoInm.ConInmObs)
            db.ExecuteNonQuery(cmd)


            'Archivos
            For Each fConInmArchId As String In aoContratoInm.ListaConInmArchivosTemporalEliminados
                cmd = db.GetStoredProcCommand("Eliminar_ConInmArchivos_pa")
                db.AddInParameter(cmd, "coninmarchid", DbType.String, fConInmArchId)
                db.ExecuteNonQuery(cmd)
            Next

            For Each fArchivos As EEConArchivos In aoContratoInm.ListaConInmArchivosTemporalNuevos
                cmd = db.GetStoredProcCommand("InsertarU_ConInmArchivos_pa")
                db.AddInParameter(cmd, "coninmid", DbType.String, aoContratoInm.ConInmId)
                db.AddInParameter(cmd, "coninmarchnombre", DbType.String, fArchivos.ConInmArchNombre)
                db.AddInParameter(cmd, "coninmarchdescripcion", DbType.String, fArchivos.ConInmArchDescripcion)
                db.AddInParameter(cmd, "tgtipoarchid", DbType.String, fArchivos.TgTipoArchId)
                db.AddInParameter(cmd, "coninmarch", DbType.Binary, fArchivos.ConInmArch)
                db.AddInParameter(cmd, "coninmarchext", DbType.String, fArchivos.ConInmArchExt)

                db.ExecuteNonQuery(cmd)
            Next

            'Actualizar Archivos que han sido editados
            For Each fArchivos As EEConArchivos In aoContratoInm.ListaConInmArchivosEditados
                cmd = db.GetStoredProcCommand("Actualizar_ConInmArchivos_pa")
                db.AddInParameter(cmd, "coninmarchid", DbType.String, fArchivos.ConArchId)
                db.AddInParameter(cmd, "coninmarchnombre", DbType.String, fArchivos.ConInmArchNombre)
                db.AddInParameter(cmd, "coninmarchdescripcion", DbType.String, fArchivos.ConInmArchDescripcion)
                db.ExecuteNonQuery(cmd)
            Next





        Catch ex As Exception
            Throw New Exception("Actualizar ContratoInm => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function cancelarContrato(ByVal aoContratoInm As EEContratoInm) As Boolean
        Dim transaccion As DbTransaction = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Using conexion As DbConnection = db.CreateConnection()
                Try
                    conexion.Open()
                    transaccion = conexion.BeginTransaction()
                    Dim cmd As DbCommand = db.GetStoredProcCommand("Actualizar_ContratoInm_Cancelacion_pa")
                    db.AddInParameter(cmd, "coninmid", DbType.String, aoContratoInm.ConInmId)
                    db.AddInParameter(cmd, "coninmfecCan", DbType.DateTime, aoContratoInm.ConInmFecCan)
                    db.AddInParameter(cmd, "coninmobs", DbType.String, aoContratoInm.ConInmObs)
                    db.AddInParameter(cmd, "coninmicuotacan", DbType.Int32, aoContratoInm.ConInmICuotaCan)
                    db.AddInParameter(cmd, "tgEstId", DbType.String, aoContratoInm.TgEstId)
                    db.ExecuteNonQuery(cmd, transaccion)

                    cmd = db.GetStoredProcCommand("Actualizar_ProPagos_Anulacion_pa")
                    db.AddInParameter(cmd, "coninmid", DbType.String, aoContratoInm.ConInmId)
                    db.AddInParameter(cmd, "cuotadesde", DbType.Int32, aoContratoInm.ConInmICuotaCan)
                    db.ExecuteNonQuery(cmd, transaccion)

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw New Exception(ex.Message, ex)
                End Try
            End Using
        Catch ex As Exception
            Throw New Exception("Cancelar Contrato => " + ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function eliminar(ByVal aiIdContratoInm As Int32) As Boolean
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Eliminar_ContratoInm_pa")

            db.AddInParameter(cmd, "idContratoInm", DbType.Int32, aiIdContratoInm)
            db.ExecuteNonQuery(cmd)

        Catch ex As Exception
            Throw New Exception("Eliminar ContratoInm => " & ex.Message, ex)
        End Try
        Return True
    End Function

    Public Shared Function listarCriterio(ByVal aiTipoCriterio As Int32, ByVal asCriterio As [String]) As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ContratoInm_Criterio_pa")
            db.AddInParameter(cmd, "criterio", DbType.String, asCriterio)
            db.AddInParameter(cmd, "tipoCriterio", DbType.Int32, aiTipoCriterio)

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()

                loContratoInm.ConInmId = dr("ConInmId").ToString()
                loContratoInm.InmId = dr("InmId").ToString()
                loContratoInm.ConInmDocRef = dr("ConInmDocRef").ToString()
                loContratoInm.PerId = dr("PerId").ToString()
                'loContratoInm.UsuId = dr("UsuId").ToString()
                loContratoInm.ConInmGarantia = Convert.ToDecimal(dr("ConInmGarantia").ToString())
                loContratoInm.ConInmDerLlaves = Convert.ToDecimal(dr("ConInmDerLlaves").ToString())
                loContratoInm.ConInmMerced = Convert.ToDecimal(dr("ConInmMerced").ToString())
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("ConInmFecIni")), Nothing, dr("ConInmFecIni"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("ConInmFecFin")), Nothing, dr("ConInmFecFin"))
                loContratoInm.ConInmFecReg = IIf(IsDBNull(dr("ConInmFecReg")), Nothing, dr("ConInmFecReg"))
                loContratoInm.ConInmDiaMaxVen = Convert.ToInt32(dr("ConInmDiaMaxVen").ToString())
                loContratoInm.TgUsoId = dr("TgUsoId").ToString()
                loContratoInm.TgEstId = dr("TgEstId").ToString()
                loContratoInm.TgMonId = dr("TgMonId").ToString()
                loContratoInm.TgModId = dr("TgModId").ToString()
                loContratoInm.ConInmObs = dr("ConInmObs").ToString()

                ListaContratoInm.Add(loContratoInm)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ContratoInm Criterio => " + ex.Message, ex)
        End Try
        Return ListaContratoInm
    End Function

    Public Shared Function listarALL() As List(Of EEContratoInm)
        Dim ListaContratoInm As List(Of EEContratoInm) = Nothing
        Dim loContratoInm As EEContratoInm = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_ContratoInm_ALL_pa")

            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaContratoInm Is Nothing Then
                    ListaContratoInm = New List(Of EEContratoInm)()
                End If

                loContratoInm = New EEContratoInm()

                loContratoInm.ConInmId = dr("ConInmId").ToString()
                loContratoInm.InmId = dr("InmId").ToString()
                loContratoInm.ConInmDocRef = dr("ConInmDocRef").ToString()
                loContratoInm.PerId = dr("PerId").ToString()
                'loContratoInm.UsuId = dr("UsuId").ToString()
                loContratoInm.ConInmGarantia = Convert.ToDecimal(dr("ConInmGarantia").ToString())
                loContratoInm.ConInmDerLlaves = Convert.ToDecimal(dr("ConInmDerLlaves").ToString())
                loContratoInm.ConInmMerced = Convert.ToDecimal(dr("ConInmMerced").ToString())
                loContratoInm.ConInmFecIni = IIf(IsDBNull(dr("ConInmFecIni")), Nothing, dr("ConInmFecIni"))
                loContratoInm.ConInmFecFin = IIf(IsDBNull(dr("ConInmFecFin")), Nothing, dr("ConInmFecFin"))
                loContratoInm.ConInmFecReg = IIf(IsDBNull(dr("ConInmFecReg")), Nothing, dr("ConInmFecReg"))
                loContratoInm.ConInmDiaMaxVen = Convert.ToInt32(dr("ConInmDiaMaxVen").ToString())
                loContratoInm.TgUsoId = dr("TgUsoId").ToString()
                loContratoInm.TgEstId = dr("TgEstId").ToString()
                loContratoInm.TgMonId = dr("TgMonId").ToString()
                loContratoInm.TgModId = dr("TgModId").ToString()
                loContratoInm.ConInmObs = dr("ConInmObs").ToString()


                ListaContratoInm.Add(loContratoInm)
            End While
        Catch ex As Exception
            Throw New Exception("Listar ALL ContratoInm => " & ex.Message, ex)

        End Try
        Return ListaContratoInm
    End Function
End Class


