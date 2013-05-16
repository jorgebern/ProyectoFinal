Imports System.Security.Permissions
Imports System.Security
Imports System.IO

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



End Class
