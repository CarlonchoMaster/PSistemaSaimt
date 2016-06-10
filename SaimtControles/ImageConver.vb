Imports System.IO
Imports System.Drawing.Imaging
Public Class ImageConver
    Public Function Bytes2Image(ByVal bytes As Byte()) As Image
        If bytes Is Nothing Then
            Return Nothing
        End If
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function
    Public Function FileToByteArray(ByVal lsFileName As String) As Byte()
        Dim lbyBuffer As Byte() = Nothing

        Try
            ' Open file for reading
            Dim _FileStream As New System.IO.FileStream(lsFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read)

            ' attach filestream to binary reader
            Dim _BinaryReader As New System.IO.BinaryReader(_FileStream)

            ' get total byte length of the file
            Dim liTotalBytes As Int32 = New System.IO.FileInfo(lsFileName).Length


            ' read entire file into buffer
            lbyBuffer = _BinaryReader.ReadBytes(liTotalBytes)

            ' close file reader
            _FileStream.Close()
            _FileStream.Dispose()
            _BinaryReader.Close()
        Catch _Exception As Exception
            ' Error
            Console.WriteLine("Exception caught in process: {0}", _Exception.ToString())
        End Try

        Return lbyBuffer
    End Function
    Public Sub ByteArrayToFile(ByVal lsFileName As String, ByVal datos As Byte())
        'Dim lbyBuffer As Byte() = Nothing

        Try
            ' Create file for writing
            Dim _FileStream As New System.IO.FileStream(lsFileName, System.IO.FileMode.Create, System.IO.FileAccess.Write)

            ' attach filestream to binary reader
            Dim _BinaryWriter As New System.IO.BinaryWriter(_FileStream)

            ' get total byte length of the file
            'Dim liTotalBytes As Int32 = New System.IO.FileInfo(lsFileName).Length


            ' read entire file into buffer
            _BinaryWriter.Write(datos)

            ' close file reader
            _FileStream.Close()
            _FileStream.Dispose()
            _BinaryWriter.Close()
        Catch _Exception As Exception
            ' Error
            Console.WriteLine("Exception caught in process: {0}", _Exception.ToString())
        End Try
    End Sub
    Public Function Image2Bytes(ByVal imagen As Image, ByVal size As Integer) As Byte()
        Dim filetemp As String = Path.GetTempFileName 'creo un archivo temporal con nombre unico y obtengo su nombre 
        Dim files As New FileStream(filetemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        imagen.Save(files, ImageFormat.Png)
        files.Position = 0
        Dim imagenlong As Integer = CInt(files.Length)
        Dim bytes(0 To imagenlong - 1) As Byte
        files.Read(bytes, 0, imagenlong)
        files.Close()
        bytes = ResizeImageFile(bytes, size)
        Return bytes
    End Function

    Public Function Image2Bytes(ByVal imagen As Image) As Byte()
        Dim filetemp As String = Path.GetTempFileName 'creo un archivo temporal con nombre unico y obtengo su nombre 
        Dim files As New FileStream(filetemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        imagen.Save(files, ImageFormat.Png)
        files.Position = 0
        Dim imagenlong As Integer = CInt(files.Length)
        Dim bytes(0 To imagenlong - 1) As Byte
        files.Read(bytes, 0, imagenlong)
        files.Close()
        bytes = bytes
        Return bytes
    End Function
    Public Function ResizeImageFile(ByVal imagen As Byte(), ByVal size As Integer) As Byte()
        Dim original As Image = Image.FromStream(New MemoryStream(imagen))
        Dim targeth, targetw As Integer
        If original.Height > original.Width Then
            targeth = size
            targetw = Int(original.Height * (size / original.Width))
        Else
            targeth = size
            targetw = Int(original.Height * (size / original.Width))
        End If
        Dim imgfoto As Image = Image.FromStream(New MemoryStream(imagen))
        Dim bmpfoto As New Bitmap(targetw, targeth, PixelFormat.Format24bppRgb)
        Dim grfoto As Graphics
        bmpfoto.SetResolution(72, 72)
        grfoto = Graphics.FromImage(bmpfoto)
        grfoto.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        grfoto.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        grfoto.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        grfoto.DrawImage(imgfoto, New Rectangle(0, 0, targetw, targeth), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel)
        Dim mm As New MemoryStream
        bmpfoto.Save(mm, ImageFormat.Jpeg)
        original.Dispose()
        imgfoto.Dispose()
        bmpfoto.Dispose()
        grfoto.Dispose()
        Return mm.GetBuffer()
    End Function
    Public Function ZoomImageToBytes(ByVal imagen As Byte(), ByVal escala As Decimal) As Byte()
        Dim original As Image = Image.FromStream(New MemoryStream(imagen))
        Dim targeth, targetw As Integer
        targeth = original.Height * escala
        targetw = original.Width * escala

        Dim imgfoto As Image = Image.FromStream(New MemoryStream(imagen))
        Dim bmpfoto As New Bitmap(targetw, targeth, PixelFormat.Format24bppRgb)
        Dim grfoto As Graphics
        bmpfoto.SetResolution(72, 72)
        grfoto = Graphics.FromImage(bmpfoto)
        grfoto.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        grfoto.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        grfoto.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        grfoto.DrawImage(imgfoto, New Rectangle(0, 0, targetw, targeth), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel)
        Dim mm As New MemoryStream
        bmpfoto.Save(mm, ImageFormat.Jpeg)
        original.Dispose()
        imgfoto.Dispose()
        bmpfoto.Dispose()
        grfoto.Dispose()
        Return mm.GetBuffer()
    End Function
    Public Function ZoomImageToImage(ByVal imagen As Byte(), ByVal escala As Decimal) As Image
        Dim original As Image = Image.FromStream(New MemoryStream(imagen))
        Dim targeth, targetw As Integer
        targeth = original.Height * escala
        targetw = original.Width * escala

        Dim imgfoto As Image = Image.FromStream(New MemoryStream(imagen))
        Dim bmpfoto As New Bitmap(targetw, targeth, PixelFormat.Format24bppRgb)
        Dim grfoto As Graphics
        bmpfoto.SetResolution(72, 72)
        grfoto = Graphics.FromImage(bmpfoto)
        grfoto.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        grfoto.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        grfoto.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        grfoto.DrawImage(imgfoto, New Rectangle(0, 0, targetw, targeth), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel)
        Dim mm As New MemoryStream
        bmpfoto.Save(mm, ImageFormat.Jpeg)
        original.Dispose()
        imgfoto.Dispose()
        bmpfoto.Dispose()
        grfoto.Dispose()
        Return Bytes2Image(mm.GetBuffer())
    End Function
End Class
