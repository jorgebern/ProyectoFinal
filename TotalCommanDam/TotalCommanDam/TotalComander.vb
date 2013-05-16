''' <summary>
''' Clase "principal" 
''' </summary>
''' <remarks></remarks>
Public Class TotalComander

    Dim izquierda As Panel
    Dim derecha As Panel

    ''' <summary>
    ''' Constructor de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        izquierda = New Panel()
        derecha = New Panel()

    End Sub

    ''' <summary>
    ''' Obtiene los ficheros y los directorios de un panel determinado
    ''' </summary>
    ''' <param name="panel">Panel al que se accede</param>
    ''' <returns>devuelve la lista con los nombres de ficheros</returns>
    ''' <remarks></remarks>
    Public Function obtenerArchivos(panel As String) As List(Of String)

        Dim archivos As List(Of String) = New List(Of String)

        If panel = "izquierda" Then

            For Each elemento As String In izquierda.obtenerdirectorios()

                Dim partido As String() = elemento.Split(CChar("\"))
                archivos.Add(partido(partido.Length - 1))
            Next


            For Each elemento As String In izquierda.obtenerArchivos()
                Dim partido As String() = elemento.Split(CChar("\"))
                archivos.Add(partido(partido.Length - 1))
            Next

        Else
            archivos = derecha.obtenerdirectorios()

            For Each elemento As String In derecha.obtenerArchivos()
                archivos.Add(elemento)
            Next

        End If

        archivos.Insert(0, "\..")

        Return archivos

    End Function


    ''' <summary>
    ''' Obtiene la ruta a la que esta accediendo un panel
    ''' </summary>
    ''' <param name="panel">Panel al que se accede</param>
    ''' <returns>Devuelve la ruta obtenida</returns>
    ''' <remarks></remarks>
    Public Function obtenerRuta(panel As String) As String

        If panel = "izquierda" Then
            Return izquierda.Ruta
        ElseIf panel = "derecha" Then
            Return derecha.Ruta
        End If

        Return ""
    End Function

    ''' <summary>
    ''' Cambia la ruta a la que acceden los paneles
    ''' </summary>
    ''' <param name="panel">Panel al que se va a acceder</param>
    ''' <param name="ruta"></param>
    ''' <remarks></remarks>
    Public Sub CambiarRuta(panel As String, ruta As String)
        If panel = "izquierda" Then

            'If My.Computer.FileSystem.SpecialDirectories.
            izquierda.Ruta = ruta
        Else
            derecha.Ruta = ruta
        End If

    End Sub

    Public Sub ejecutarFichero(panel As String, ruta As String)

        If panel = "izquierda" Then
            izquierda.ejecutarArchivo(ruta)
        Else
            derecha.ejecutarArchivo(ruta)
        End If

    End Sub




End Class
