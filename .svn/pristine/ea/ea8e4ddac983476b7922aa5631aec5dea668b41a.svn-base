Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Entidades

Public Class InmBajasDAS


    Public Shared Function MostrarxInmId(ByVal inmBajaId As [String]) As EEInmueble.EEInmBajas
        Dim loInmBajas As EEInmueble.EEInmBajas = Nothing
        Dim dr As IDataReader = Nothing
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(EEConexiones.CN_BDSaimt_General)
            Dim cmd As DbCommand = db.GetStoredProcCommand("Mostrar_InmBajas_xInmBajaId_pa")
            db.AddInParameter(cmd, "inmBajaId", DbType.String, inmBajaId)
            dr = db.ExecuteReader(cmd)
            While dr.Read()
                loInmBajas = New EEInmueble.EEInmBajas()
                loInmBajas.InmBajaId = dr("InmBajaId").ToString()
                loInmBajas.InmBajaNroDoc = dr("InmBajaNroDoc").ToString()
                loInmBajas.InmBajaFecha = IIf(IsDBNull(dr("InmBajaFecha")), Nothing, dr("InmBajaFecha"))
                loInmBajas.InmBajaDocFecha = IIf(IsDBNull(dr("InmBajaDocFecha")), Nothing, dr("InmBajaDocFecha"))
                loInmBajas.InmBajaDocArchivo = dr("InmBajaDocArchivo").ToString()
                loInmBajas.InmBajaObservacion = dr("InmBajaObservacion").ToString()
                loInmBajas.PerRegBajaId = dr("PerRegBajaId").ToString()
                loInmBajas.InmBajaTemporal = Convert.ToBoolean(dr("InmBajaTemporal").ToString())
                loInmBajas.InmBajaCausa = dr("InmBajaCausa").ToString()
                loInmBajas.InmBajaDatoAdicional = dr("InmBajaDatoAdicional").ToString()
            End While
            dr.Close()
        Catch ex As Exception
            Throw New Exception("Listar InmBajas Criterio => " & ex.Message, ex)
        End Try
        Return loInmBajas
    End Function
End Class

