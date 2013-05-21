''' <summary>
''' Clase "principal" 
''' </summary>
''' <remarks></remarks>
Public Class TotalComander

    Dim izquierda As Panel
    Dim derecha As Panel
    Dim preferencias As Preferencias

    ''' <summary>
    ''' Constructor de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        izquierda = New Panel()
        derecha = New Panel()
        preferencias = New Preferencias()

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
            For Each elemento As String In derecha.obtenerdirectorios()

                Dim partido As String() = elemento.Split(CChar("\"))
                archivos.Add(partido(partido.Length - 1))
            Next


            For Each elemento As String In derecha.obtenerArchivos()
                Dim partido As String() = elemento.Split(CChar("\"))
                archivos.Add(partido(partido.Length - 1))
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
    ''' Borra elementos seleccionados de un panel
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="fichero"></param>
    ''' <remarks></remarks>
    Public Sub Borrar(panel As String, fichero As System.Windows.Forms.ListBox.SelectedObjectCollection)

        If panel = "izquierda" Then
            izquierda.Borrar(fichero)
        Else
            derecha.Borrar(fichero)
        End If


    End Sub


    ''' <summary>
    ''' Renombra los ficheros seleccionados
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="nuevoNombre"></param>
    ''' <remarks></remarks>
    Public Sub RenombrarVarios(panel As String, ficheros As System.Windows.Forms.ListBox.SelectedObjectCollection, nuevoNombre As String)

        If panel = "izquierda" Then
            izquierda.RenombrarVarios(ficheros, nuevoNombre)
        Else
            derecha.RenombrarVarios(ficheros, nuevoNombre)
        End If

    End Sub


    ''' <summary>
    ''' Comprime las carpetas seleccionadas
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="fichero"></param>
    ''' <remarks></remarks>
    Public Sub Comprimir(panel As String, fichero As String, nombre As String)
        If panel = "izquierda" Then
            izquierda.Comprimir(fichero, nombre)
        Else
            derecha.Comprimir(fichero, nombre)
        End If

    End Sub


    ''' <summary>
    ''' Manda a descomprimir los archivos dependiendo del panel
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="fichero"></param>
    ''' <remarks></remarks>
    Public Sub Descomprimir(panel As String, fichero As String)
        If Panel = "izquierda" Then
            izquierda.Descomprimir(fichero)
        Else
            derecha.Descomprimir(fichero)
        End If
    End Sub


    ''' <summary>
    ''' Cambia la ruta a la que acceden los paneles
    ''' </summary>
    ''' <param name="panel">Panel al que se va a acceder</param>
    ''' <param name="ruta"></param>
    ''' <remarks></remarks>
    Public Sub CambiarRuta(panel As String, ruta As String)
        If panel = "izquierda" Then
            izquierda.Ruta = ruta
        Else
            derecha.Ruta = ruta
        End If

    End Sub

    ''' <summary>
    ''' Cambia la ruta entera, sirve para cargar los favoritos
    ''' </summary>
    ''' <param name="panel">Panel al que afecta</param>
    ''' <param name="ruta">Nueva ruta</param>
    ''' <remarks></remarks>
    Public Sub CambiarRutaEntera(panel As String, ruta As String)
        If panel = "izquierda" Then
            izquierda.RutaEntera = ruta
        Else
            derecha.RutaEntera = ruta
        End If

    End Sub

    ''' <summary>
    ''' Ejecuta un fichero seleccionado
    ''' </summary>
    ''' <param name="panel">Panel al que afectara</param>
    ''' <param name="ruta">Fichero al que se abrira</param>
    ''' <remarks></remarks>
    Public Sub ejecutarFichero(panel As String, ruta As String)

        If panel = "izquierda" Then
            izquierda.ejecutarArchivo(ruta)
        Else
            derecha.ejecutarArchivo(ruta)
        End If

    End Sub

    ''' <summary>
    ''' Obtiene informacion de un fichero o directorio seleccionado
    ''' </summary>
    ''' <param name="panel">Panel al que afecta</param>
    ''' <param name="fichero">Fichero que obtendra la informacion</param>
    ''' <returns>Devuelve la informacion en forma de array de String</returns>
    ''' <remarks></remarks>
    Public Function obtenerInformacion(panel As String, fichero As String) As String()
        Dim info As String()

        If panel = "izquierda" Then
            info = izquierda.obtenerInformacion(fichero).Split(CChar("Ä"))
        Else
            info = derecha.obtenerInformacion(fichero).Split(CChar("Ä"))
        End If

        Return info

    End Function

    ''' <summary>
    ''' Copia un fichero al panel incativo
    ''' </summary>
    ''' <param name="panel">Panel al que afectara</param>
    ''' <param name="f">Ficheor que va a copiarse</param>
    ''' <returns>Devuelve true si se copio bien, False si se copio mal</returns>
    ''' <remarks></remarks>
    Public Function Copiar(panel As String, f As System.Windows.Forms.ListBox.SelectedObjectCollection) As Boolean

        Dim correcto As Boolean

        If panel = "izquierda" Then

            izquierda.Copiar(f, derecha.Ruta)

        Else

            derecha.Copiar(f, izquierda.Ruta)

        End If
        Return correcto
    End Function


    ''' <summary>
    ''' Carga la ruta anterior
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <remarks></remarks>
    Public Sub RutaAnterior(panel As String)

        If panel = "izquierda" Then

            izquierda.RutaEntera = izquierda.RutaAnterior

        Else

            derecha.RutaEntera = derecha.RutaAnterior

        End If
    End Sub

    ''' <summary>
    ''' Guarda las preferencias al cerrar el fichero
    ''' </summary>
    ''' <param name="tutorial"></param>
    ''' <param name="color"></param>
    ''' <param name="tamanyo"></param>
    ''' <remarks></remarks>
    Public Sub GuardarPreferencias(tutorial As Boolean, color As Integer, tamanyo As Single)

        preferencias.EscribirPreferencias(tutorial, color, tamanyo)

    End Sub

    ''' <summary>
    ''' Carga las preferencias al iniciar el formulario
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CargarPreferencias() As String()

        Return preferencias.ObtenerPreferencias
    End Function

End Class
