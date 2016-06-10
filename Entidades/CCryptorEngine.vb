Imports System.Text
Imports System.Security.Cryptography

Public Class CCryptorEngine
    Private key As String = String.Empty
    ''' <summary>
    ''' Constructor de la clase CCryptorEngine
    ''' </summary>
    Public Sub New()
        ' Establecer una clave. La misma clave debe ser utilizada para descifrar los datos que 
        ' son cifrados con esta clave. pueden ser los caracteres que uno desee
        key = "saimtgeneral"
    End Sub

    ''' <summary>
    ''' Cifrar una cadena utilizando el método de cifrado. Regresa un texto de cifrado.
    ''' </summary>
    ''' <param name="texto">cadena de caracteres que se va a encriptar</param>
    ''' <returns></returns>
    ''' 
    Public Function Encriptar(ByVal texto As String) As String
        'arreglo de bytes donde guardaremos la llave
        Dim keyArray As Byte()
        'arreglo de bytes donde guardaremos el texto que vamos a encriptar
        Dim Arreglo_a_Cifrar As Byte() = UTF8Encoding.UTF8.GetBytes(texto)

        'se utilizan las clases de encriptacion proveidas por el Framework
        'Algritmo MD5
        Dim hashmd5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        'se guarda la llave para que se le realice hashing
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
        hashmd5.Clear()

        'Algoritmo 3DAS
        Dim tdes As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
        tdes.Key = keyArray
        tdes.Mode = CipherMode.ECB
        tdes.Padding = PaddingMode.PKCS7

        'se empieza con la transformaion de la cadena
        Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()

        'arreglo de bytes donde se guarda la cadena cifrada
        Dim ArrayResultado As Byte() = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length)
        tdes.Clear()
        'se regresa el resultado en forma de una cadena
        Return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length)
    End Function

    ''' <summary>
    ''' Desencripta un texto usando el metodo de deble cadena Regresa una cadena desencriptada. 
    ''' </summary>    
    ''' <returns>the decrypted string</returns>
    Public Function Desencriptar(ByVal textoEncriptado As String) As String
        Dim keyArray As Byte()
        'convierte el texto en una secuencia de bytes
        Dim Array_a_Descifrar As Byte() = Convert.FromBase64String(textoEncriptado)

        'se llama a las clases ke tienen los algoritmos de encriptacion
        'se le aplica hashing
        Dim hashmd5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
        hashmd5.Clear()

        Dim tdes As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
        tdes.Key = keyArray
        tdes.Mode = CipherMode.ECB
        tdes.Padding = PaddingMode.PKCS7

        Dim cTransform As ICryptoTransform = tdes.CreateDecryptor()
        Dim resultArray As Byte() = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length)

        tdes.Clear()
        Dim res As String = UTF8Encoding.UTF8.GetString(resultArray)
        Return res
    End Function

End Class
