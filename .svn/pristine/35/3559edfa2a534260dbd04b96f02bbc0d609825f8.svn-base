Imports LibReniec
Imports System.Net
Imports System.IO

Public Class Info_Reniec
    Public Enum Resul
        ''' <summary>
        ''' Se encontro la persona
        ''' </summary>
        Ok = 0
        ''' <summary>
        ''' No se encontro la persona
        ''' </summary>
        NoResul = 1
        ''' <summary>
        ''' la imagen capcha no es valida
        ''' </summary>
        ErrorCapcha = 2
        ''' <summary>
        ''' Error no especificado
        ''' </summary>
        [Error] = 3
    End Enum

    Private myResul As Resul
    Private _Nombres As String
    Private _ApePaterno As String
    Private _ApeMaterno As String
    Private myCookie As CookieContainer

#Region "Propiedades"

    ''' <summary>
    ''' Devuelve la imagen para el reto capcha
    ''' </summary>
    Public ReadOnly Property GetCapcha() As Image
        Get
            Return ReadCapcha()
        End Get
    End Property

    ''' <summary>
    ''' Si no Hubo error en la lectura de datos devuelve los nombres 
    ''' de la persona caso contrario devuelve ""
    ''' </summary>
    Public ReadOnly Property Nombres() As String
        Get
            Return _Nombres
        End Get
    End Property

    ''' <summary>
    ''' Si no Hubo error en la lectura de datos devuelve el Apellido Paterno
    ''' de la persona caso contrario devuelve ""
    ''' </summary>
    Public ReadOnly Property ApePaterno() As String
        Get
            Return _ApePaterno
        End Get
    End Property

    ''' <summary>
    ''' Si no Hubo error en la lectura de datos devuelve el Apellido Materno
    ''' de la persona caso contrario devuelve ""
    '''</summary>
    Public ReadOnly Property ApeMaterno() As String
        Get
            Return _ApeMaterno
        End Get
    End Property

    ''' <summary>
    ''' Devuelve el resultado de la busqueda de DNI
    ''' </summary>
    Public ReadOnly Property GetResul() As Resul
        Get
            Return myResul
        End Get
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Try
            myCookie = Nothing
            myCookie = New CookieContainer()
            ' ReadCapcha()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    ''' <summary>
    ''' Carga la imagen Capcha
    ''' </summary>
    Private Function ReadCapcha() As Image
        Try
            Dim myUrl As String = "https://cel.reniec.gob.pe/valreg/codigo.do"

            Dim myWebRequest As HttpWebRequest = DirectCast(WebRequest.Create(myUrl), HttpWebRequest)
            myWebRequest.CookieContainer = myCookie

            Dim proxy = New WebProxy()

            proxy.Credentials = New NetworkCredential("Cascoy", "GeneralX2010", "SAIMT")
            myWebRequest.Proxy = proxy

            ' myWenRequest.Credentials = CredentialCache.DefaultCredentials;

            Dim myHttpWebResponse As HttpWebResponse = DirectCast(myWebRequest.GetResponse(), HttpWebResponse)

            Dim myImgStream As Stream = myHttpWebResponse.GetResponseStream()

            'myWebResponse.Close();

            Return Image.FromStream(myImgStream)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Inicia la carga de los datos de la persona 
    ''' </summary>
    ''' <param name="numDni"></param>
    ''' <param name="ImgCapcha"></param>
    Public Sub GetInfo(ByVal numDni As String, ByVal ImgCapcha As String)
        Try
            Dim line As String = String.Empty
            Dim count As Integer = -1
            Dim myUrl As String = [String].Format("https://cel.reniec.gob.pe/valreg/valreg.do?accion=buscar&nuDni={0}&imagen={1}", numDni, ImgCapcha)


            Dim myWebRequest As HttpWebRequest = DirectCast(WebRequest.Create(myUrl), HttpWebRequest)
            myWebRequest.CookieContainer = myCookie

            Dim proxy = New WebProxy()

            proxy.Credentials = New NetworkCredential("Administrador", "GeneralX2010", "SAIMT")
            myWebRequest.Proxy = proxy



            ' myWebRequest.Credentials = CredentialCache.DefaultCredentials;

            Dim myHttpWebResponse As HttpWebResponse = DirectCast(myWebRequest.GetResponse(), HttpWebResponse)

            Dim myStream As Stream = myHttpWebResponse.GetResponseStream()

            Dim myStreamReader As New StreamReader(myStream)

            'Comenzar a leer el html devuelvto por el servidor desde la linea 150
            While (InlineAssignHelper(line, myStreamReader.ReadLine())) IsNot Nothing
                count += 1
                If count >= 150 Then
                    Dim tmp As String = line.Trim()

                    If tmp <> "" Then
                        tmp = tmp.Substring(0, 4).Trim()
                    End If

                    Select Case tmp
                        Case ""
                            myResul = Resul.Ok
                            Exit Select
                        Case "<tr>"
                            myResul = Resul.NoResul
                            Exit Select
                        Case "<td"
                            myResul = Resul.ErrorCapcha
                            Exit Select
                        Case Else
                            myResul = Resul.[Error]
                            Exit Select
                    End Select

                    If myResul = Resul.Ok Then
                        line = myStreamReader.ReadLine()
                        'linea 151
                        line = myStreamReader.ReadLine()
                        'linea 152
                        Me._Nombres = myStreamReader.ReadLine().Trim()
                        'linea 153
                        Me._ApePaterno = myStreamReader.ReadLine().Trim()
                        'linea 154
                        Me._ApeMaterno = myStreamReader.ReadLine().Trim()
                        'linea 155
                        'para borrar el <br>
                        Me._ApeMaterno = Me._ApeMaterno.Substring(0, Me._ApeMaterno.Length - 4)
                        Exit While
                    Else
                        Exit While
                    End If
                End If
            End While

            myHttpWebResponse.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
End Class

