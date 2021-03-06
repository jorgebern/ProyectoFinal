﻿Imports System.Security.Permissions
Imports System.Security
Imports System.IO
Imports System.IO.Compression
Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.Security.AccessControl
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

''' <summary>
''' Clase que se encarga de controlar cada panel, cogiendo, moviendo y definiendo rutas, ficheros y directorios
''' </summary>
''' <author>Jorge Bernabeu Mira</author>
''' <version>0.1</version>
''' <remarks></remarks>
Public Class Panel

    Private _ruta As String
    Private _rutaAnterior As String

    ''' <summary>
    ''' Constructor de la clase en el que definimos la ruta predeterminada, en mi caso he elegido el escritorio.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _ruta = My.Computer.FileSystem.SpecialDirectories.Desktop
        _rutaAnterior = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    End Sub

    ''' <summary>
    ''' Obtiene los directorios de la ruta donde estamos en el momento.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function obtenerdirectorios() As List(Of String)

        Dim directories As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Dim directorios As List(Of String)
        Try
            directories = My.Computer.FileSystem.GetDirectories(_ruta)
            directorios = directories.ToList()
        Catch ex As Exception

            directories = My.Computer.FileSystem.GetDirectories(_ruta.Substring(0, _ruta.LastIndexOf("\")))
            directorios = directories.ToList()
            Ruta = "\.."
            directorios.Insert(0, "--error1--")
        End Try

        Return directorios

    End Function

    ''' <summary>
    ''' Obtiene los archivos de la ruta donde estamos en el momento
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function obtenerArchivos() As List(Of String)

        Dim archivos As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Try
            archivos = My.Computer.FileSystem.GetFiles(_ruta)
        Catch ex As Exception

            archivos = My.Computer.FileSystem.GetFiles(_ruta.Substring(0, _ruta.LastIndexOf("\")))

        Finally

        End Try

        Return archivos.ToList()

    End Function

    ''' <summary>
    ''' Funcion que ejecuta un fichero con el programa predeterminado del usuario
    ''' </summary>
    ''' <param name="archivo">Ruta donde se encuentra el Archivo</param>
    ''' <remarks></remarks>
    Public Sub ejecutarArchivo(archivo As String)
        If archivo.LastIndexOf("\") >= 1 Then
            If My.Computer.FileSystem.FileExists(archivo) Then
                Try
                    Dim p As New System.Diagnostics.Process
                    Dim s As New System.Diagnostics.ProcessStartInfo(archivo)
                    s.UseShellExecute = True
                    s.WindowStyle = ProcessWindowStyle.Normal
                    p.StartInfo = s
                    p.Start()
                Catch ex As Exception
                    Return
                End Try

            End If
        Else
            If My.Computer.FileSystem.FileExists(_ruta & "\" & archivo) Then
                Try
                    Dim p As New System.Diagnostics.Process
                    Dim s As New System.Diagnostics.ProcessStartInfo(_ruta & "\" & archivo)
                    s.UseShellExecute = True
                    s.WindowStyle = ProcessWindowStyle.Normal
                    p.StartInfo = s
                    p.Start()
                Catch ex As Exception
                    Return
                End Try

            End If
        End If
    End Sub


    ''' <summary>
    ''' Obtiene la informacion de un fichero o directorio devolviendola como un String separando los parametros por el token Ä
    ''' </summary>
    ''' <param name="fichero">Fichero del que se obtendra la informacion</param>
    ''' <returns>Devuelve un String separando los parametros con el token Ä</returns>
    ''' <remarks></remarks>
    Public Function obtenerInformacion(fichero As String) As String
        Dim informacion As String

        If My.Computer.FileSystem.FileExists(_ruta & "\" & fichero) Then
            Dim info As FileInfo = My.Computer.FileSystem.GetFileInfo(_ruta & "\" & fichero)

            informacion = fichero & "Ä" & info.Extension & "Ä" & info.FullName & "Ä" & info.Length & "Ä" & info.CreationTime & "Ä" & info.LastWriteTime

        Else
            Dim info As DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(_ruta & "\" & fichero)

            informacion = fichero & "Ä" & "Carpeta de ficheros" & "Ä" & info.FullName & "Ä" & "0" & "Ä" & info.CreationTime & "Ä" & info.LastWriteTime
        End If

        Return informacion
    End Function

    ''' <summary>
    ''' Copia un archivo o directorio pasado por parametro
    ''' </summary>
    ''' <param name="ficheros">Fichero que sera copiado</param>
    ''' <param name="destino">Ruta de destino del fichero</param>
    ''' <returns>Devuelve True si se copia bien, False si salta una excepcion</returns>
    ''' <remarks></remarks>
    Public Function Copiar(ficheros As List(Of String), destino As String) As Boolean

        Dim correcto As Boolean = False
        Dim repeticiones As Integer = 0

        For i As Integer = 0 To ficheros.Count - 1

            If My.Computer.FileSystem.DirectoryExists(_ruta & "\" & ficheros.Item(i).ToString) Then
                Try
                    If My.Computer.FileSystem.DirectoryExists(destino & "\" & ficheros.Item(i).ToString) Then
                        While My.Computer.FileSystem.DirectoryExists(destino & "\" & ficheros.Item(i).ToString & "(" & repeticiones & ")")
                            repeticiones += 1
                        End While
                        My.Computer.FileSystem.CopyDirectory(_ruta & "\" & ficheros.Item(i).ToString, destino & "\" & ficheros.Item(i).ToString & "(" & repeticiones & ")", FileIO.UIOption.AllDialogs)
                        correcto = True
                    Else
                        My.Computer.FileSystem.CopyDirectory(_ruta & "\" & ficheros.Item(i).ToString, destino & "\" & ficheros.Item(i).ToString, FileIO.UIOption.AllDialogs)
                        correcto = True
                    End If

                Catch ex As Exception
                    correcto = False
                End Try
            ElseIf My.Computer.FileSystem.FileExists(_ruta & "\" & ficheros.Item(i).ToString) Then
                Try
                    If My.Computer.FileSystem.FileExists(destino & "\" & ficheros.Item(i).ToString) Then
                        Dim info As DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(_ruta & "\" & ficheros.Item(i).ToString)

                        While My.Computer.FileSystem.FileExists(destino & "\" & ficheros.Item(i).ToString.Substring(0, ficheros.Item(i).ToString.LastIndexOf(".")) & "(" & repeticiones & ")" & info.Extension)
                            repeticiones += 1
                        End While
                        My.Computer.FileSystem.CopyFile(_ruta & "\" & ficheros.Item(i).ToString, destino & "\" & ficheros.Item(i).ToString.Substring(0, ficheros.Item(i).ToString.LastIndexOf(".")) & "(" & repeticiones & ")" & info.Extension)
                        correcto = True
                    Else
                        My.Computer.FileSystem.CopyFile(_ruta & "\" & ficheros.Item(i).ToString, destino & "\" & ficheros.Item(i).ToString)
                        correcto = True
                    End If

                Catch ex As Exception
                    correcto = False
                End Try

            End If
        Next

        Return correcto
    End Function

    ''' <summary>
    ''' Borra los ficheros seleccionados
    ''' </summary>
    ''' <param name="ficheros"></param>
    ''' <remarks></remarks>
    Public Sub Borrar(ficheros As List(Of String))

        For i As Integer = 0 To ficheros.Count - 1
            If My.Computer.FileSystem.FileExists(_ruta & "\" & ficheros.Item(i).ToString) Then
                My.Computer.FileSystem.DeleteFile(_ruta & "\" & ficheros.Item(i).ToString, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            End If

            If My.Computer.FileSystem.DirectoryExists(_ruta & "\" & ficheros.Item(i).ToString) Then
                My.Computer.FileSystem.DeleteDirectory(_ruta & "\" & ficheros.Item(i).ToString, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
        Next

    End Sub


    ''' <summary>
    ''' Renombra los ficheros seleccionados
    ''' </summary>
    ''' <param name="ficheros"></param>
    ''' <param name="nuevoNombre"></param>
    ''' <remarks></remarks>
    Public Function Renombrar(ficheros As List(Of String), nuevoNombre As String) As Boolean
        Dim correcto As Boolean = False

        Dim nombre As String
        Dim info As FileInfo
        Dim ficherosRepetidos As Integer = 0
        Dim carpetasRepetidas As Integer = 0

        If nuevoNombre.LastIndexOf(".") >= 0 Then
            nombre = nuevoNombre.Substring(0, nuevoNombre.LastIndexOf("."))
        Else
            nombre = nuevoNombre
        End If

        For i As Integer = 0 To ficheros.Count - 1

            info = My.Computer.FileSystem.GetFileInfo(_ruta & "\" & ficheros.Item(i).ToString)

            If My.Computer.FileSystem.FileExists(_ruta & "\" & nombre & info.Extension) Then
                ficherosRepetidos = ficherosRepetidos + 1
            End If


            If My.Computer.FileSystem.FileExists(_ruta & "\" & ficheros.Item(i).ToString) Then
                If ficherosRepetidos = 0 Then
                    My.Computer.FileSystem.RenameFile(_ruta & "\" & ficheros.Item(i).ToString, nombre & info.Extension)
                    correcto = True
                Else
                    While (My.Computer.FileSystem.FileExists(_ruta & "\" & nombre & "(" & ficherosRepetidos & ")" & info.Extension))
                        ficherosRepetidos = ficherosRepetidos + 1
                    End While
                    My.Computer.FileSystem.RenameFile(_ruta & "\" & ficheros.Item(i).ToString, nombre & "(" & ficherosRepetidos & ")" & info.Extension)
                    correcto = True
                End If

            End If

            If My.Computer.FileSystem.DirectoryExists(_ruta & "\" & nombre) Then
                carpetasRepetidas = carpetasRepetidas + 1
            End If

            If My.Computer.FileSystem.DirectoryExists(_ruta & "\" & ficheros.Item(i).ToString) Then
                If carpetasRepetidas = 0 Then
                    My.Computer.FileSystem.RenameDirectory(_ruta & "\" & ficheros.Item(i).ToString, nombre)
                    correcto = True
                Else
                    While (My.Computer.FileSystem.DirectoryExists(_ruta & "\" & nombre & "(" & carpetasRepetidas & ")"))
                        carpetasRepetidas = carpetasRepetidas + 1
                    End While
                    My.Computer.FileSystem.RenameDirectory(_ruta & "\" & ficheros.Item(i).ToString, nombre & "(" & carpetasRepetidas & ")")
                    correcto = True
                End If

            End If
        Next

        Return correcto
    End Function


    ''' <summary>
    ''' Comprime la carpeta indicada(Solo carpetas)
    ''' </summary>
    ''' <param name="fichero"></param>
    ''' <remarks></remarks>
    Public Function Comprimir(fichero As String, nombre As String) As Boolean
        Dim correcto As Boolean = False
        Dim repeticiones As Integer = 0

        If nombre.LastIndexOf(".") <> -1 Then
            nombre = nombre.Substring(0, nombre.LastIndexOf("."))
        End If


        If My.Computer.FileSystem.DirectoryExists(_ruta & "\" & fichero) Then

            If (My.Computer.FileSystem.FileExists(_ruta & "\" & nombre & ".zip")) Then
                repeticiones = repeticiones + 1
            End If

            If repeticiones = 0 Then
                ZipFile.CreateFromDirectory(_ruta & "\" & fichero, _ruta & "\" & nombre & ".zip", CompressionLevel.Optimal, True)
                correcto = True
            Else
                While (My.Computer.FileSystem.FileExists(_ruta & "\" & nombre & "(" & repeticiones & ").zip"))
                    repeticiones = repeticiones + 1
                End While
                ZipFile.CreateFromDirectory(_ruta & "\" & fichero, _ruta & "\" & nombre & "(" & repeticiones & ").zip")
                correcto = True
            End If

        End If

        Return correcto
    End Function

    ''' <summary>
    ''' Descomprime la carpeta
    ''' </summary>
    ''' <param name="fichero"></param>
    ''' <remarks></remarks>
    Public Function Descomprimir(fichero As String) As Boolean
        Dim correcto As Boolean = False
        Dim repeticiones As Integer = 0

        If My.Computer.FileSystem.FileExists(_ruta & "\" & fichero) Then

            Dim info As FileInfo = My.Computer.FileSystem.GetFileInfo(_ruta & "\" & fichero)

            If info.Extension = ".zip" Then

                If (My.Computer.FileSystem.DirectoryExists(_ruta & "\" & fichero.Substring(0, fichero.LastIndexOf(".")))) Then
                    repeticiones = repeticiones + 1
                End If

                If repeticiones = 0 Then
                    ZipFile.ExtractToDirectory(_ruta & "\" & fichero, _ruta & "\" & fichero.Substring(0, fichero.LastIndexOf(".")))
                    correcto = True
                Else
                    While (My.Computer.FileSystem.DirectoryExists(_ruta & "\" & fichero.Substring(0, fichero.LastIndexOf(".")) & "(" & repeticiones & ")"))
                        repeticiones = repeticiones + 1
                    End While
                    ZipFile.ExtractToDirectory(_ruta & "\" & fichero, _ruta & "\" & fichero.Substring(0, fichero.LastIndexOf(".")) & "(" & repeticiones & ")")
                    correcto = True
                End If
            End If
        End If

        Return correcto
    End Function


    ''' <summary>
    ''' Crea una carpeta con el nombre pasado por parametro
    ''' </summary>
    ''' <param name="nombre">Nombre de la carpeta</param>
    ''' <remarks></remarks>
    Public Sub CrearCarpeta(nombre As String)

        Dim repeticiones As Integer = 1

        If My.Computer.FileSystem.DirectoryExists(Ruta & "\" & nombre) Then

            While My.Computer.FileSystem.DirectoryExists(Ruta & "\" & nombre & "(" & repeticiones & ")")
                repeticiones += 1
            End While
            My.Computer.FileSystem.CreateDirectory(Ruta & "\" & nombre & "(" & repeticiones & ")")
        Else
            My.Computer.FileSystem.CreateDirectory(Ruta & "\" & nombre)
        End If

    End Sub

    ''' <summary>
    ''' Crea un fichero vacio con el nombre pasado por parametro
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <remarks></remarks>
    Public Sub CrearFichero(nombre As String)

        Dim repeticiones As Integer = 1
        Dim swEscritor As StreamWriter

        If nombre.LastIndexOf(".") >= 0 Then
            nombre = nombre.Substring(0, nombre.LastIndexOf("."))
        End If


        If My.Computer.FileSystem.FileExists(Ruta & "\" & nombre & ".txt") Then

            While My.Computer.FileSystem.FileExists(Ruta & "\" & nombre & "(" & repeticiones & ").txt")
                repeticiones += 1
            End While
            swEscritor = New StreamWriter(_ruta & "\" & nombre & "(" & repeticiones & ").txt")

        Else
            swEscritor = New StreamWriter(_ruta & "\" & nombre & ".txt")
        End If

        swEscritor.Close()
    End Sub

    ''' <summary>
    ''' Cambia la extension a un fichero pasado por parametro
    ''' </summary>
    ''' <param name="fichero"></param>
    ''' <param name="extension"></param>
    ''' <remarks></remarks>
    Public Sub CambiarExtension(fichero As String, extension As String)

        If My.Computer.FileSystem.FileExists(_ruta & "\" & fichero) Then
            Dim repeticiones As Integer = 0
            Dim nombre As String = fichero.Substring(0, fichero.LastIndexOf("."))

            If My.Computer.FileSystem.FileExists(_ruta & "\" & nombre & extension) Then
                While My.Computer.FileSystem.FileExists(_ruta & "\" & nombre & "(" & repeticiones & ")" & extension)
                    repeticiones += 1
                End While
                My.Computer.FileSystem.RenameFile(_ruta & "\" & fichero, nombre & "(" & repeticiones & ")" & extension)

            Else
                My.Computer.FileSystem.RenameFile(_ruta & "\" & fichero, nombre & extension)
            End If
        End If

    End Sub

    ''' <summary>
    ''' Filtra el contenido de la carpeta segun la cadena que usemos
    ''' </summary>
    ''' <param name="palabra"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function filtrar(palabra As String) As String()

        Dim ficheros As List(Of String) = New List(Of String)

        For Each elemento As String In Directory.GetDirectories(_ruta & "\", "*" & palabra & "*", SearchOption.TopDirectoryOnly).ToList
            Dim partido As String() = elemento.Split(CChar("\"))
            ficheros.Add(partido(partido.Length - 1))
        Next

        For Each elemento As String In Directory.GetFiles(_ruta & "\", "*" & palabra & "*", SearchOption.TopDirectoryOnly)
            Dim partido As String() = elemento.Split(CChar("\"))
            ficheros.Add(partido(partido.Length - 1))
        Next

        Return ficheros.ToArray

    End Function

    ''' <summary>
    ''' Mueve los archivos pasados por parametro a la ubicacion pasada por parametro
    ''' </summary>
    ''' <param name="ficheros"></param>
    ''' <param name="destino"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function mover(ficheros As List(Of String), destino As String) As Boolean
        Dim correcto As Boolean = False
        Dim repeticiones As Integer = 0

        For i As Integer = 0 To ficheros.Count - 1

            If My.Computer.FileSystem.DirectoryExists(_ruta & "\" & ficheros.Item(i).ToString) Then
                Try
                    If My.Computer.FileSystem.DirectoryExists(destino & "\" & ficheros.Item(i).ToString) Then
                        While My.Computer.FileSystem.DirectoryExists(destino & "\" & ficheros.Item(i).ToString & "(" & repeticiones & ")")
                            repeticiones += 1
                        End While
                        My.Computer.FileSystem.MoveDirectory(_ruta & "\" & ficheros.Item(i).ToString, destino & "\" & ficheros.Item(i).ToString & "(" & repeticiones & ")", FileIO.UIOption.AllDialogs)
                        correcto = True
                    Else
                        My.Computer.FileSystem.MoveDirectory(_ruta & "\" & ficheros.Item(i).ToString, destino & "\" & ficheros.Item(i).ToString, FileIO.UIOption.AllDialogs)
                        correcto = True
                    End If

                Catch ex As Exception
                    correcto = False
                End Try
            ElseIf My.Computer.FileSystem.FileExists(_ruta & "\" & ficheros.Item(i).ToString) Then
                Try
                    If My.Computer.FileSystem.FileExists(destino & "\" & ficheros.Item(i).ToString) Then
                        Dim info As DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(_ruta & "\" & ficheros.Item(i).ToString)

                        While My.Computer.FileSystem.FileExists(destino & "\" & ficheros.Item(i).ToString.Substring(0, ficheros.Item(i).ToString.LastIndexOf(".")) & "(" & repeticiones & ")" & info.Extension)
                            repeticiones += 1
                        End While
                        My.Computer.FileSystem.MoveFile(_ruta & "\" & ficheros.Item(i).ToString, destino & "\" & ficheros.Item(i).ToString.Substring(0, ficheros.Item(i).ToString.LastIndexOf(".")) & "(" & repeticiones & ")" & info.Extension)
                        correcto = True
                    Else
                        My.Computer.FileSystem.MoveFile(_ruta & "\" & ficheros.Item(i).ToString, destino & "\" & ficheros.Item(i).ToString)
                        correcto = True
                    End If

                Catch ex As Exception
                    correcto = False
                End Try

            End If
        Next

        Return correcto
    End Function

    ''' <summary>
    ''' Compara 2 carpetas y distingue entre los ficheros que comparten
    ''' </summary>
    ''' <param name="destino"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Comparar(destino As String) As String()
        Dim faltan As List(Of String) = New List(Of String)
        Dim existe As Boolean = False

        'Carpetas
        For Each elemento As String In My.Computer.FileSystem.GetDirectories(_ruta & "\")
            existe = False
            Dim partido As String() = elemento.Split(CChar("\"))

            If Not My.Computer.FileSystem.DirectoryExists(destino & "\" & partido(partido.Length - 1)) Then
                faltan.Add(partido(partido.Length - 1))
            End If
        Next

        'ficheros
        For Each elemento As String In My.Computer.FileSystem.GetFiles(_ruta & "\")
            existe = False
            Dim partido As String() = elemento.Split(CChar("\"))

            If Not My.Computer.FileSystem.FileExists(destino & "\" & partido(partido.Length - 1)) Then
                faltan.Add(partido(partido.Length - 1))
            End If
        Next
        Return faltan.ToArray

    End Function

    ''' <summary>
    ''' Busca en las subcarpetas archivos relacionados con la cadena
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscar(nombre As String) As String()

        Dim archivos As List(Of String) = New List(Of String)
        Try
            For Each elemento As String In Directory.GetDirectories(_ruta & "\", "*" & nombre & "*", SearchOption.AllDirectories)
                archivos.Add(elemento)
            Next

        Catch ex As Exception

        End Try

        Try
            For Each elemento As String In Directory.GetFiles(_ruta & "\", "*" & nombre & "*", SearchOption.AllDirectories)
                archivos.Add(elemento)
            Next
        Catch ex As Exception

        End Try

        Return archivos.ToArray
    End Function


    ''' <summary>
    ''' Manda la ruta de los archivos recientes
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ArchivosRecientes() As String

        Return Environment.GetFolderPath(Environment.SpecialFolder.Recent)
    End Function

    ''' <summary>
    ''' Ordena una lista alfabeticamente
    ''' </summary>
    ''' <param name="archivos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function OrdenarAlfabeticamente(archivos As String()) As String()

        Dim ordenados As List(Of String) = archivos.ToList

        ordenados.RemoveAt(0)
        ordenados.Sort()
        ordenados.Insert(0, "\..")


        Return ordenados.ToArray
    End Function

    ''' <summary>
    ''' Ordena una lista de archivos segun la fecha que fueron creados
    ''' </summary>
    ''' <param name="archivos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function OrdenarPorFecha(archivos As String()) As String()

        Dim direInfo As DirectoryInfo
        Dim direInfo2 As DirectoryInfo
        Dim aux As String

        For i As Integer = 2 To archivos.Length
            For j As Integer = 0 To archivos.Length - i
                direInfo = My.Computer.FileSystem.GetDirectoryInfo(_ruta & "\" & archivos(j))
                direInfo2 = My.Computer.FileSystem.GetDirectoryInfo(_ruta & "\" & archivos(j + 1))
                If direInfo.CreationTime.CompareTo(direInfo2.CreationTime) >= 1 Then
                    aux = archivos(j).ToString
                    archivos(j) = archivos(j + 1)
                    archivos(j + 1) = aux
                End If
            Next
        Next

        Return archivos
    End Function

    ''' <summary>
    ''' Permite mandar un Email con el archivo indicado
    ''' </summary>
    ''' <param name="email">direccion del emisor</param>
    ''' <param name="contrasenya">contraseña</param>
    ''' <param name="nombre">nombre del emisor</param>
    ''' <param name="destino">Direccion del receptor</param>
    ''' <param name="Asunto">asunto del correo</param>
    ''' <param name="mensaje">mensaje del correo</param>
    ''' <param name="archivos">archivos adjuntos al mensaje</param>
    ''' <returns>devuelve el codigo de error o en caso de funcionar bien 0</returns>
    ''' <remarks></remarks>
    Public Function enviarArchivo(email As String, contrasenya As String, nombre As String, destino As String, Asunto As String, mensaje As String, archivos As String()) As Integer

        Dim err As Integer = 0

        '25Mb --> Gmail
        '25Mb --> Hotmail
        '25Mb --> Yahoo
        If tamanyoFicheros(archivos) < 25 Then
            Dim _Message As New System.Net.Mail.MailMessage()
            Dim _SMTP As New System.Net.Mail.SmtpClient

            _SMTP.Credentials = New System.Net.NetworkCredential(email, contrasenya)

            Dim direccion As String() = email.Split(CChar("@"))

            If direccion(direccion.Length - 1).Substring(0, direccion(direccion.Length - 1).LastIndexOf(".")) = "hotmail" Then
                _SMTP.Host = "smtp.live.com"
                _SMTP.Port = 25
            ElseIf direccion(direccion.Length - 1).Substring(0, direccion(direccion.Length - 1).LastIndexOf(".")) = "gmail" Then
                _SMTP.Host = "smtp.gmail.com"
                _SMTP.Port = 587
            ElseIf direccion(direccion.Length - 1).Substring(0, direccion(direccion.Length - 1).LastIndexOf(".")) = "yahoo" Then
                _SMTP.Host = "smtp.mail.yahoo.com"
                _SMTP.Port = 465
            End If

            _SMTP.EnableSsl = True
            _SMTP.Timeout = 300000

            _Message.[To].Add(destino) 'Cuenta de Correo al que se le quiere enviar el e-mail
            _Message.From = New System.Net.Mail.MailAddress(email, nombre, System.Text.Encoding.UTF8) 'Quien lo envía
            _Message.Subject = Asunto 'Sujeto del e-mail
            _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
            _Message.Body = mensaje 'contenido del mail
            For Each elemento As String In archivos
                If My.Computer.FileSystem.FileExists(_ruta & "\" & elemento) Then
                    _Message.Attachments.Add(New Net.Mail.Attachment(_ruta & "\" & elemento))
                End If
            Next

            _Message.BodyEncoding = System.Text.Encoding.UTF8
            _Message.Priority = System.Net.Mail.MailPriority.Normal
            _Message.IsBodyHtml = False


            Try
                _SMTP.EnableSsl = True
                _SMTP.Send(_Message)
                err = 0
            Catch ex As System.Net.Mail.SmtpException

                err = 1
            End Try
        Else
            err = 2
        End If

        Return err
    End Function

    ''' <summary>
    ''' Calcula el tamaño del fichero para comprobar si el emisor del correo lo admitira
    ''' </summary>
    ''' <param name="ficheros">ficheros a analizar</param>
    ''' <returns>tamaño en Mb</returns>
    ''' <remarks></remarks>
    Public Function tamanyoFicheros(ficheros As String()) As Long
        Dim tamanyo As Long = 0
        Dim info As FileInfo

        For Each elemento As String In ficheros
            info = My.Computer.FileSystem.GetFileInfo(_ruta & "\" & elemento)

            tamanyo += info.Length
        Next

        tamanyo = CLng(tamanyo / 1048576)

        Return tamanyo
    End Function

    ''' <summary>
    ''' Imprime un documento con una programa asociado a su impresion
    ''' </summary>
    ''' <param name="archivos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Imprimir(archivos As String()) As Boolean
        Dim correcto As Boolean = False

        Dim MyProcess As New Process

        For Each elemento As String In archivos

            If My.Computer.FileSystem.FileExists(_ruta & "\" & elemento) Or My.Computer.FileSystem.FileExists(elemento) Then
                If elemento.LastIndexOf("\") >= 1 Then
                    MyProcess.StartInfo.FileName = elemento
                Else
                    MyProcess.StartInfo.FileName = _ruta & "\" & elemento
                End If
                MyProcess.StartInfo.CreateNoWindow = False

                MyProcess.StartInfo.Verb = "Print"

                Try
                    MyProcess.Start()
                Catch ex As Exception
                    ImprimirPlano(elemento)
                End Try

            End If

        Next

        correcto = True

        Return correcto
    End Function

    ''' <summary>
    ''' Imprime documentos sin programas asociados a su impresion(.txt, .exe....)
    ''' </summary>
    ''' <param name="fichero"></param>
    ''' <remarks></remarks>
    Public Sub ImprimirPlano(fichero As String)
        Dim impresora As Printer = New Printer
        impresora.DocumentName = fichero
        Dim sangrado As Boolean = True
        impresora.CurrentX = 700
        impresora.CurrentY = 500

        Dim Linea As String

        Try
            Dim srLector As StreamReader = New StreamReader(_ruta & "\" & fichero)

            Linea = srLector.ReadLine()

            Do While Not (Linea Is Nothing)
                If sangrado Then
                    impresora.CurrentX = 700
                    sangrado = False
                Else
                    impresora.CurrentX = 300
                End If
                If Linea.Length >= 80 Then

                    While Linea.Length > 80
                        impresora.Print(Linea.Substring(0, 80))
                        Linea = Linea.Remove(0, 80)
                        impresora.CurrentX = 300
                    End While

                    impresora.Print(Linea)
                Else
                    impresora.Print(Linea)
                End If

                If Linea.LastIndexOf(".") = Linea.Length - 1 Then
                    sangrado = True
                End If

                Linea = srLector.ReadLine()
            Loop

            srLector.Close()
        Catch ex As Exception

        End Try

        impresora.EndDoc()

    End Sub



    ''' <summary>
    ''' Propiedad que devuelve y asigna la ruta del panel
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Ruta As String
        Get
            Return _ruta
        End Get
        Set(value As String)
            RutaAnterior = _ruta
            If value = "\.." Then
                If _ruta.LastIndexOf("\") = 2 Then
                    _ruta = _ruta.Substring(0, _ruta.LastIndexOf("\")) & "\"
                Else
                    _ruta = _ruta.Substring(0, _ruta.LastIndexOf("\"))
                End If
            Else
                _ruta = _ruta & "\" & value
            End If

        End Set
    End Property

    ''' <summary>
    ''' Permite cargar o escribir la ruta anterior
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RutaAnterior As String
        Get
            Return _rutaAnterior
        End Get
        Set(value As String)

            _rutaAnterior = value

        End Set
    End Property


    ''' <summary>
    ''' propiedad que define la ruta entera, implementada para los marcadores
    ''' </summary>
    ''' <value>Valor nuevo</value>
    ''' <returns>Ruta</returns>
    ''' <remarks></remarks>
    Public Property RutaEntera As String
        Get
            Return _ruta
        End Get
        Set(value As String)
            _ruta = value
        End Set
    End Property

End Class
