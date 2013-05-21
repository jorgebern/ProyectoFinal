Imports System.Security.Permissions
Imports System.Security
Imports System.IO
Imports System.IO.Compression

''' <summary>
''' Clase que se encarga de controlar cada panel, cogiendo, moviendo y definiendo rutas, ficheros y directorios
''' </summary>
''' <author>Jorge Bernabeu Mira</author>
''' <version>0.1</version>
''' <remarks></remarks>
Public Class Panel

    Private _ruta As String

    ''' <summary>
    ''' Constructor de la clase en el que definimos la ruta predeterminada, en mi caso he elegido el escritorio.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _ruta = My.Computer.FileSystem.SpecialDirectories.Desktop
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
        If My.Computer.FileSystem.FileExists(_ruta & "\" & archivo) Then
            Try
                Dim p As New System.Diagnostics.Process
                Dim s As New System.Diagnostics.ProcessStartInfo(_ruta & "\" & archivo)
                s.UseShellExecute = True
                s.WindowStyle = ProcessWindowStyle.Normal
                p.StartInfo = s
                p.Start()
            Catch ex As Exception
                MessageBox.Show("not found")
            End Try

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
    ''' <param name="fichero">Fichero que sera copiado</param>
    ''' <param name="destino">Ruta de destino del fichero</param>
    ''' <returns>Devuelve True si se copia bien, False si salta una excepcion</returns>
    ''' <remarks></remarks>
    Public Function Copiar(fichero As String, destino As String) As Boolean

        Dim correcto As Boolean = False
        If My.Computer.FileSystem.DirectoryExists(_ruta & "\" & fichero) Then
            Try
                My.Computer.FileSystem.CopyDirectory(_ruta & "\" & fichero, destino & "\" & fichero)
                correcto = True
            Catch ex As Exception
                correcto = False
            End Try
        Else
            Try
                My.Computer.FileSystem.CopyFile(_ruta & "\" & fichero, destino & "\" & fichero)
                correcto = True
            Catch ex As Exception
                correcto = False
            End Try

        End If
        
        Return correcto
    End Function

    ''' <summary>
    ''' Borra el archivo o directorio seleccionado
    ''' </summary>
    ''' <param name="fichero"></param>
    ''' <remarks></remarks>
    Public Sub Borrar(fichero As String)

        If My.Computer.FileSystem.FileExists(_ruta & "\" & fichero) Then
            My.Computer.FileSystem.DeleteFile(_ruta & "\" & fichero)
        End If

        If My.Computer.FileSystem.DirectoryExists(_ruta & "\" & fichero) Then
            My.Computer.FileSystem.DeleteDirectory(_ruta & "\" & fichero,FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If

    End Sub

    ''' <summary>
    ''' Renombra el directorio o el archivo indicado
    ''' </summary>
    ''' <param name="fichero"></param>
    ''' <param name="nuevoNombre"></param>
    ''' <remarks></remarks>
    Public Sub Renombrar(fichero As String, nuevoNombre As String)
        If My.Computer.FileSystem.FileExists(_ruta & "\" & fichero) Then
            My.Computer.FileSystem.RenameFile(_ruta & "\" & fichero, nuevoNombre)
        End If

        If My.Computer.FileSystem.DirectoryExists(_ruta & "\" & fichero) Then
            My.Computer.FileSystem.RenameDirectory(_ruta & "\" & fichero, nuevoNombre)
        End If
    End Sub

    Public Sub RenombrarVarios(ficheros As System.Windows.Forms.ListBox.SelectedObjectCollection, nuevoNombre As String)
        Dim nombre As String = nuevoNombre.Substring(0, nuevoNombre.LastIndexOf("."))




        For i As Integer = 0 To ficheros.Count - 1

            Dim info As FileInfo = My.Computer.FileSystem.GetFileInfo(_ruta & "\" & ficheros.Item(i).ToString)

            My.Computer.FileSystem.RenameFile(_ruta & "\" & ficheros.Item(i).ToString, nombre & "(" & i & ")" & info.Extension)
        Next

    End Sub


    ''' <summary>
    ''' Comprime la carpeta indicada(Solo carpetas)
    ''' </summary>
    ''' <param name="fichero"></param>
    ''' <remarks></remarks>
    Public Sub Comprimir(fichero As String)

        If My.Computer.FileSystem.DirectoryExists(_ruta & "\" & fichero) Then
            ZipFile.CreateFromDirectory(_ruta & "\" & fichero, _ruta & "\" & "comprimirdo.zip")
        End If

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
