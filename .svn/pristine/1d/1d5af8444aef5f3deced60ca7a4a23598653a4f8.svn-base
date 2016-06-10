Imports ReglasNegocio
Imports Entidades
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports SaimtControles
Imports System.IO

Public Class frmImportarExportarSunat

    Dim data() As String
    Dim xl As Excel.Application = EEExcel.Instancia
    Dim Recaudador As String
    Dim fila As Integer = 0
    Dim myInfo As Info_Reniec
    Dim oTable As DataTable = New DataTable("DtRecaudacion")
    Dim oTableDet As DataTable = New DataTable("DtRecaudacionDet")
    Dim recDs As New DataSet
    Dim EjecutaEvento As Boolean = False
    Public Property vRecId() As String
    Public Property vfechaPago() As Date
    Public Property vRecaudadorID() As String
    Public Property vRecMonto() As Decimal
    Public Property vdepositante() As String
    Public Property vGrupoCon() As String
    Public Property vtipoDoc() As String
    Public Property vNDoc() As String
    Public Property vconId() As String
    Public Property vFechDep As Date


    Private Sub btnImpArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpArchivo.Click
        Me.ofdimportar.Filter = "Archivos de Excel(*.xls;*.xlsx)|*.xls;*.xlsx"
        If Me.ofdimportar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.btnImpArchivo.Text = Me.ofdimportar.FileName.Trim
            CargarVisor(Me.btnImpArchivo.Text.Trim)
            'Me.tlImportar.BestFitColumns()
        End If
    End Sub
    Function ValidarNoNull(ByVal cadena As String, ByVal columna As Integer, ByVal fila As Integer, ByVal caracteresMax As Integer) As Boolean
        Dim valor As Boolean = True
        If cadena = String.Empty Then
            SaimtMessageBox.mostrarAlertaAdvertencia("No puede haber valor Nulos: columna " & columna & ": fila " & fila)
            valor = False
        Else
            If Len(cadena) > caracteresMax Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No puede tener mas de " & caracteresMax & " caracteres: columna " & columna & ": fila " & fila)
                valor = False
            End If
        End If

        Return valor
    End Function

    Function ValidarNull(ByVal cadena As String, ByVal columna As Integer, ByVal fila As Integer, ByVal caracteresMax As Integer) As Boolean
        Dim valor As Boolean = True
        If cadena <> String.Empty Then
            If Len(cadena) > caracteresMax Then
                SaimtMessageBox.mostrarAlertaAdvertencia("No puede tener mas de " & caracteresMax & " caracteres: columna " & columna & ": fila " & fila)
                valor = False
            End If
        End If

        Return valor
    End Function


    Private Sub CargarVisor(ByVal path As String)
        RichTextBox1.Text = String.Empty
        fila = 2
        Application.DoEvents()
        Me.beiprogreso.Caption = "Cargando Datos al Visor..."
        Me.ripprogreso.Stopped = False
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Application.DoEvents()
        xl.Workbooks.Open(path, 1, True, 4)
        'Tabla One
        xl.Sheets(4).Select()

        Dim TotalFilas As Integer
        While CStr(xl.Cells(fila, 1).Value) <> String.Empty
            If CStr(xl.Cells(fila, 1).Value) <> String.Empty Then
                TotalFilas = TotalFilas + 1
            End If
            fila = fila + 1
        End While
        fila = 2
        ReDim data(TotalFilas)
        Dim cadena As String
        Dim columna As Integer
        Dim maxcaracteres As Integer
        Dim Linea As String = String.Empty
        Dim ruta As String = String.Empty
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                ruta = FolderBrowserDialog1.SelectedPath & "\" & txtRuc.Text & "001" & txtaño.Text & txtww.Text & "." & txtNroEnvio.Text

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

        While fila <= TotalFilas + 1
            columna = 1
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 11
            'Ruc
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 2
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 2

            'Tipo doc de Identidad
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If
            columna = 3
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 15
            'Numero de documento Identidad
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If
            columna = 4
            cadena = xl.Cells(fila, columna).Value
            cadena = Trim(cadena)
            maxcaracteres = 50
            'Apellido Paterno
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 5
            cadena = xl.Cells(fila, columna).Value
            cadena = Trim(cadena)
            maxcaracteres = 50
            'Apellido Materno
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 6
            cadena = xl.Cells(fila, columna).Value
            cadena = Trim(cadena)
            maxcaracteres = 80
            'Nombres
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 7
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 100
            'Razon Socila
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & IIf(cadena = String.Empty, " ", cadena) & "|"
            Else
                Return
            End If

            columna = 8
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 10
            'Fecha de Ingreso
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 9
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 10
            'Fecha de Salida
            If cadena <> String.Empty Then
                If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                    data(fila - 1) = data(fila - 1) & cadena
                Else
                    Return
                End If
            Else
                data(fila - 1) = data(fila - 1) & IIf(Len(Date.Now.Month.ToString) = 1, "0" & Date.Now.Month, Date.Now.Month) & "/" & IIf(Len(Date.Now.Day) = 1, "0" & Date.Now.Day, Date.Now.Day) & "/" & Date.Now.Year
            End If

            Try
                If File.Exists(ruta) = False Then
                    File.Create(ruta)
                End If
                Using oSW As New StreamWriter(ruta)
                    Linea = String.Format("{0}{1}{2}", data(fila - 1), vbNewLine, Linea)
                    oSW.WriteLine(Linea)
                    oSW.Flush()
                    oSW.Close()
                End Using
            Catch ex As System.StackOverflowException

            End Try

            RichTextBox1.Text = RichTextBox1.Text & data(fila - 1) & vbNewLine

            fila = fila + 1
        End While
      
        'Tabla DOS
        RichTextBox1.Text = String.Empty
        xl.Sheets(5).Select()

        TotalFilas = 0
        fila = 2

        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                ruta = FolderBrowserDialog1.SelectedPath & "\" & txtRuc.Text & "002" & txtaño.Text & txtww.Text & "." & txtNroEnvio.Text
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        While CStr(xl.Cells(fila, 1).Value) <> String.Empty
            If CStr(xl.Cells(fila, 1).Value) <> String.Empty Then
                TotalFilas = TotalFilas + 1
            End If
            fila = fila + 1
        End While
        fila = 2
        ReDim data(TotalFilas)
        cadena = String.Empty
        columna = -1
        maxcaracteres = -1
        While fila <= TotalFilas + 1
            columna = 1
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 11
            'Ruc
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 2
            cadena = xl.Cells(fila, columna).Value
            cadena = Replace(cadena, "O", "0")
            maxcaracteres = 2

            'Tipo doc de Identidad
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If
            columna = 3
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 15
            'Numero de documento Identidad
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If
            columna = 4
            cadena = xl.Cells(fila, columna).Value
            cadena = Trim(cadena)
            maxcaracteres = 50
            'Apellido Paterno
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 5
            cadena = xl.Cells(fila, columna).Value
            cadena = Trim(cadena)
            maxcaracteres = 50
            'Apellido Materno
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 6
            cadena = xl.Cells(fila, columna).Value
            cadena = Trim(cadena)
            maxcaracteres = 80
            'Nombres
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 7
            cadena = xl.Cells(fila, columna).Value
            cadena = Trim(cadena)
            maxcaracteres = 100
            'Razon Socila
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & IIf(cadena = String.Empty, " ", cadena) & "|"
            Else
                Return
            End If

            columna = 8
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 50
            'Tipo de Ingreso
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 9
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 15
            'Porcentaje de Participacion
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                data(fila - 1) = data(fila - 1) & " |"
                ' Return
            End If


            columna = 10
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 10
            'Fecha de Ingreso
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                data(fila - 1) = data(fila - 1) & " |"
                ' Return
            End If

            columna = 11
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 15
            'Forma de pago
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                data(fila - 1) = data(fila - 1) & " |"
                ' Return
            End If

            columna = 12
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 2
            'tipo moneda
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                data(fila - 1) = data(fila - 1) & " |"
                ' Return
            End If

            columna = 13
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 15
            'importe
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & Format(CDec(cadena), "###,##0.00")
            Else
                data(fila - 1) = data(fila - 1) & " |"
                ' Return
            End If

            Try
                If File.Exists(ruta) = False Then
                    File.Create(ruta)
                End If
                Using oSW As New StreamWriter(ruta)
                    Linea = String.Format("{0}{1}{2}", data(fila - 1), vbNewLine, Linea)
                    oSW.WriteLine(Linea)
                    oSW.Flush()
                    oSW.Close()
                End Using
            Catch ex As System.StackOverflowException

            End Try

            RichTextBox1.Text = RichTextBox1.Text & data(fila - 1) & vbNewLine
            fila = fila + 1
        End While


        'Tabla TRES
        RichTextBox1.Text = String.Empty
        xl.Sheets(6).Select()

        TotalFilas = 0
        fila = 2


        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                ruta = FolderBrowserDialog1.SelectedPath & "\" & txtRuc.Text & "003" & txtaño.Text & txtww.Text & "." & txtNroEnvio.Text
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

        While CStr(xl.Cells(fila, 1).Value) <> String.Empty
            If CStr(xl.Cells(fila, 1).Value) <> String.Empty Then
                TotalFilas = TotalFilas + 1
            End If
            fila = fila + 1
        End While
        fila = 2
        ReDim data(TotalFilas)
        cadena = String.Empty
        columna = -1
        maxcaracteres = -1
        While fila <= TotalFilas + 1
            columna = 1
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 11
            'Ruc
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 2
            cadena = xl.Cells(fila, columna).Value
            cadena = Replace(cadena, "O", "0")
            maxcaracteres = 2

            'Tipo doc de Identidad
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If
            columna = 3
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 15
            'Numero de documento Identidad
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If
            columna = 4
            cadena = xl.Cells(fila, columna).Value
            cadena = Trim(cadena)
            maxcaracteres = 50
            'Apellido Paterno
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 5
            cadena = xl.Cells(fila, columna).Value
            cadena = Trim(cadena)
            maxcaracteres = 50
            'Apellido Materno
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 6
            cadena = xl.Cells(fila, columna).Value
            cadena = Trim(cadena)
            maxcaracteres = 80
            'Nombres
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 7
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 100
            'Razon Socila
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & IIf(cadena = String.Empty, " ", cadena) & "|"
            Else
                Return
            End If

            columna = 8
            cadena = xl.Cells(fila, columna).Value
            cadena = Replace(cadena, "O", "0")
            maxcaracteres = 2
            'Tipo PRESTAMO
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                Return
            End If

            columna = 9
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 10
            'FECHA PRESTAMO
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                data(fila - 1) = data(fila - 1) & " |"
            End If


            columna = 10
            cadena = xl.Cells(fila, columna).Value
            cadena = Replace(cadena, "O", "0")
            maxcaracteres = 2
            'TIPO MONEDA
            If ValidarNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & cadena & "|"
            Else
                data(fila - 1) = data(fila - 1) & "01|"
            End If

            columna = 11
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 15
            'IMPORTE
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & Format(CDec(cadena), "###,##0.00") & "|"
            Else
                Return
            End If

            columna = 12
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 15
            'tipo moneda
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & Format(CDec(cadena), "###,##0.00") & "|"
            Else
                Return
            End If

            columna = 13
            cadena = xl.Cells(fila, columna).Value
            maxcaracteres = 15
            'importe
            If ValidarNoNull(cadena, columna, fila, maxcaracteres) = True Then
                data(fila - 1) = data(fila - 1) & Format(CDec(cadena), "###,##0.00")
            Else
                Return
            End If


            Try
                If File.Exists(ruta) = False Then
                    File.Create(ruta)
                End If
                Using oSW As New StreamWriter(ruta)
                    Linea = String.Format("{0}{1}{2}", data(fila - 1), vbNewLine, Linea)
                    oSW.WriteLine(Linea)
                    oSW.Flush()
                    oSW.Close()
                End Using
            Catch ex As System.StackOverflowException

            End Try

            RichTextBox1.Text = RichTextBox1.Text & data(fila - 1) & vbNewLine
            fila = fila + 1
        End While





        xl.ActiveWorkbook.Close()
        Me.ripprogreso.Stopped = True
        Me.beiprogreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub



    Private Sub frmImportarRecSatt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            '  CargarImagen()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CargarImagen()
        Try
            If myInfo Is Nothing Then
                myInfo = New Info_Reniec
            End If
            'Me.pictureCapcha.Image = myInfo.GetCapcha
        Catch ex As Exception
            Throw ex
        End Try
    End Sub




    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rblrecaudador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateNImp_EditDateModified(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btndetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub dgvMostrarRecaudacion_MasterRowExpanded(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs)

    End Sub








    Private Sub btnimportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimportar.Click

    End Sub
End Class