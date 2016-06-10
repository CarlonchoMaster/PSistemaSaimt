Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports System.Data
Imports Entidades

Public Class JerarquiaArchDAS

    Public Shared Function NewCodigo() As String
        Dim codigo As String = String.Empty
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_JerarquiaArch_NewCodigo")
            codigo = db.ExecuteScalar(cmd)
        Catch ex As Exception
            Throw New Exception("Nuevo Codigo JerarquiaArch => " + ex.Message, ex)
        End Try
        Return codigo
    End Function


    Public Shared Function listarAll() As List(Of EEJerarquiaArch)

        Dim ListaJerarquiaArch As List(Of EEJerarquiaArch) = Nothing
        Dim loJerarquiaArch As EEJerarquiaArch = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase()
            Dim cmd As DbCommand = db.GetStoredProcCommand("Listar_JerarquiaArch_All_pa")
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                If ListaJerarquiaArch Is Nothing Then
                    ListaJerarquiaArch = New List(Of EEJerarquiaArch)()
                End If
                loJerarquiaArch = New EEJerarquiaArch()
                loJerarquiaArch.JerId = dr("JerId").ToString()
                loJerarquiaArch.JerNombre = dr("JerNombre").ToString()
                loJerarquiaArch.JerPadre = dr("JerPadre").ToString()
                loJerarquiaArch.JerNivel = Convert.ToInt32(dr("JerNivel").ToString())
                loJerarquiaArch.JerDescripcion = dr("JerDescripcion").ToString()
                loJerarquiaArch.JerfechReg = IIf(IsDBNull(dr("JerfechReg")), Nothing, dr("JerfechReg"))
                loJerarquiaArch.JerIcono = dr("JerIcono").ToString()
                ListaJerarquiaArch.Add(loJerarquiaArch)
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar JerarquiaArch X JerId Criterio => " + ex.Message, ex)
        End Try
        Return ListaJerarquiaArch
    End Function

   




End Class

