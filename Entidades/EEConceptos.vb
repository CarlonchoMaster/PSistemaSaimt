
Public Class EEConceptos

    Public Property ConId() As String
    Public Property PartId() As String
    Public Property Partida() As String
    Public Property TgCenProId() As String
    Public Property tgFFinanciera() As String

    Public Property ConNombre() As String
    Public Property ConGrupo() As String
    Public Property ConPorcentaje() As Decimal?
    Public Property TgCueBanId() As String
    Public Property TgCueBan() As String

    Public Property PcontCuenC() As String 'Debe
    Public Property PcontCuenA() As String  'Haber

    Public Property PcontCuenCNombre() As String
    Public Property PcontCuenANombre() As String

    Public Property TgGrupoConId() As String
    Public Property TgGrupoCon() As String
    Public Property TgSubGrupoId() As String
    Public Property TgSubGrupo() As String
    Public Property ConActivo() As Boolean?
    Public Property ConBaseLegal() As String
    Public Property ConApliMora() As Boolean?
    Public Property ConCodConMPT() As String
    Public Property ConCodPresMPT() As String
    Public Property ConAño() As String
    Public Property ConImporte() As Decimal?


#Region "ReadOnly"
    ''' <summary>
    ''' Para Ponerlo en ValueMember en Programacion Pagos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ConIdProcentaje() As String
        Get
            Return String.Format("{0}-{1}", ConId, ConPorcentaje)
        End Get
    End Property

    Public ReadOnly Property ConIdConNombre() As String
        Get
            Return String.Format("{0} - {1}", ConId.ToString().Substring(0, 5), ConNombre)
        End Get
    End Property
#End Region

End Class
