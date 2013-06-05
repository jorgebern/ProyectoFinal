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
    Public Sub Borrar(panel As String, fichero As List(Of String))

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
    Public Sub Renombrar(panel As String, ficheros As List(Of String), nuevoNombre As String)

        If panel = "izquierda" Then
            izquierda.Renombrar(ficheros, nuevoNombre)
        Else
            derecha.Renombrar(ficheros, nuevoNombre)
        End If

    End Sub


    ''' <summary>
    ''' Comprime las carpetas seleccionadas
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="fichero"></param>
    ''' <remarks></remarks>
    Public Function Comprimir(panel As String, fichero As String, nombre As String) As Boolean
        Dim correcto As Boolean = False
        If panel = "izquierda" Then
            correcto = izquierda.Comprimir(fichero, nombre)
        Else
            correcto = derecha.Comprimir(fichero, nombre)
        End If
        Return correcto
    End Function


    ''' <summary>
    ''' Manda a descomprimir los archivos dependiendo del panel
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="fichero"></param>
    ''' <remarks></remarks>
    Public Function Descomprimir(panel As String, fichero As String) As Boolean
        Dim correcto As Boolean = False

        If panel = "izquierda" Then
            correcto = izquierda.Descomprimir(fichero)
        Else
            correcto = derecha.Descomprimir(fichero)
        End If

        Return correcto

    End Function


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
    Public Function Copiar(panel As String, f As List(Of String)) As Boolean

        Dim correcto As Boolean

        If panel = "izquierda" Then

            correcto = izquierda.Copiar(f, derecha.Ruta)

        Else

            correcto = derecha.Copiar(f, izquierda.Ruta)

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
    Public Sub GuardarPreferencias(tutorial As Boolean, color As Integer, tamanyo As Single, predeterminada As String)

        preferencias.EscribirPreferencias(Environment.UserName, tutorial, color, tamanyo, predeterminada)

    End Sub

    ''' <summary>
    ''' Carga las preferencias al iniciar el formulario
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CargarPreferencias() As String()

        Return preferencias.ObtenerPreferencias(Environment.UserName)
    End Function

    ''' <summary>
    ''' Elimina de favoritos la ruta del actual panel
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <remarks></remarks>
    Public Sub EliminarFavorito(panel As String)
        If panel = "izquierda" Then
            preferencias.eliminarFavoritos(Environment.UserName, izquierda.Ruta)
        Else
            preferencias.eliminarFavoritos(Environment.UserName, derecha.Ruta)
        End If

    End Sub

    ''' <summary>
    ''' Carga los favoritos existentes en fichero
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CargarFavoritos(usuario As String) As String()

        Return preferencias.ObtenerFavoritos(usuario)
    End Function

    ''' <summary>
    ''' Guarda los favoritos 
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="panel"></param>
    ''' <param name="nombre"></param>
    ''' <remarks></remarks>
    Public Sub GuardarFavoritos(usuario As String, panel As String, nombre As String)

        If panel = "izquierda" Then
            If nombre = "" Then
                nombre = izquierda.Ruta
            End If
            preferencias.EscribirFavoritos(usuario, izquierda.Ruta, nombre, False)
        Else
            If nombre = "" Then
                nombre = derecha.Ruta
            End If
            preferencias.EscribirFavoritos(usuario, derecha.Ruta, nombre, False)
        End If
    End Sub


    ''' <summary>
    ''' Crea una carpta vacia
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="nombre"></param>
    ''' <remarks></remarks>
    Public Sub crearCarpeta(panel As String, nombre As String)

        If panel = "izquierda" Then
            izquierda.CrearCarpeta(nombre)
        Else
            derecha.CrearCarpeta(nombre)
        End If

    End Sub

    ''' <summary>
    ''' Crea un fichero vacio
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="nombre"></param>
    ''' <remarks></remarks>
    Public Sub crearfichero(panel As String, nombre As String)


        If panel = "izquierda" Then
            izquierda.CrearFichero(nombre)
        Else
            derecha.CrearFichero(nombre)
        End If

    End Sub

    ''' <summary>
    ''' Obtiene la informacion de el archivo seleccionado
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function obtenerInformacionPc() As String()

        Dim datos As List(Of String) = New List(Of String)


        datos.Add(Environment.UserName)
        datos.Add(Environment.MachineName)
        datos.Add(My.Computer.Info.OSFullName)
        datos.Add(Environment.OSVersion.ServicePack.ToString)
        datos.Add(Environment.ProcessorCount.ToString)
        datos.Add(Environment.TickCount.ToString)

        datos.Add(My.Computer.Info.TotalPhysicalMemory.ToString)
        datos.Add(My.Computer.Clock.LocalTime.ToString())


        Return datos.ToArray


    End Function


    ''' <summary>
    ''' Cambia la extension de un fichero
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="nombre"></param>
    ''' <param name="extension"></param>
    ''' <remarks></remarks>
    Public Sub cambiarExtension(panel As String, nombre As String, extension As String)


        If panel = "izquierda" Then
            izquierda.CambiarExtension(nombre, extension)
        Else
            derecha.CambiarExtension(nombre, extension)
        End If

    End Sub

    ''' <summary>
    ''' Filtra el contenido del panel segun el panel seleccionado
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="palabra"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function filtrar(panel As String, palabra As String) As String()
        Dim ficheros As String()

        If panel = "izquierda" Then
            ficheros = izquierda.filtrar(palabra)
        Else
            ficheros = derecha.filtrar(palabra)
        End If

        Return ficheros
    End Function

    ''' <summary>
    ''' Mueve los ficheros seleccionados a una nueva ubicacion
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="f"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function mover(panel As String, f As List(Of String)) As Boolean

        Dim correcto As Boolean

        If panel = "izquierda" Then
            correcto = izquierda.mover(f, derecha.Ruta)
        Else
            correcto = derecha.mover(f, izquierda.Ruta)
        End If
        Return correcto
    End Function

    ''' <summary>
    ''' Compara los 2 paneles mostrando en el panel activo los archivos que no tiene el otro panel
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function comparar(panel As String) As String()
        Dim faltan As String()

        If panel = "izquierda" Then
            faltan = izquierda.Comparar(derecha.Ruta)
        Else
            faltan = derecha.Comparar(izquierda.Ruta)
        End If

        Return faltan
    End Function


    Public Sub encriptar(fichero As String)
        'izquierda.EncryptFile(fichero, "Password")
    End Sub

    Public Sub desencriptar(fichero As String)
        'izquierda.DecryptFile(fichero, "Password")

    End Sub

    ''' <summary>
    ''' Busca en las subcarpetas los archivos con la cadena escrita
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="palabra"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscar(panel As String, palabra As String) As String()
        Dim archivos As String() = Nothing
        If panel = "izquierda" Then

            archivos = izquierda.buscar(palabra)
        ElseIf panel = "derecha" Then
            archivos = derecha.buscar(palabra)
        End If

        Return archivos
    End Function


    ''' <summary>
    ''' Manda la ruta de los archivos recientes para mostrarla
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ArchivosRecientes(panel As String) As String
        Dim ruta As String = ""

        If panel = "izquierda" Then
            ruta = izquierda.ArchivosRecientes

        ElseIf panel = "derecha" Then
            ruta = derecha.ArchivosRecientes
        End If


        Return ruta
    End Function

    ''' <summary>
    ''' Ordena los archivos alfabeticamente
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="archivos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Ordenar(panel As String, archivos As String()) As String()
        Dim ordenados As String() = Nothing

        If Panel = "izquierda" Then
            ordenados = izquierda.OrdenarAlfabeticamente(archivos)

        ElseIf Panel = "derecha" Then
            ordenados = derecha.OrdenarAlfabeticamente(archivos)
        End If

        Return ordenados
    End Function

    ''' <summary>
    ''' Ordena la lista de archivos por fecha de creacion
    ''' </summary>
    ''' <param name="archvos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function OrdenarPorFecha(panel As String, archvos As String()) As String()

        Dim ordenados As String() = Nothing

        If panel = "izquierda" Then
            ordenados = izquierda.OrdenarPorFecha(archvos)

        ElseIf panel = "derecha" Then
            ordenados = derecha.OrdenarPorFecha(archvos)
        End If

        Return ordenados
    End Function

    ''' <summary>
    ''' Guarda nuestros favoritos despues de editarlos
    ''' </summary>
    ''' <param name="ficheros"></param>
    ''' <remarks></remarks>
    Public Sub guardarFavoritos(ficheros As String())
        preferencias.GuardarFavoritos(ficheros)

    End Sub

    ''' <summary>
    ''' Se encarga de mandar los datos a la capa inferior para mandar un Email con los ficheros seleccionados
    ''' </summary>
    ''' <param name="email">Email del emisor</param>
    ''' <param name="contrasenya">contraseña del emisor</param>
    ''' <param name="nombre">nombre del emisor</param>
    ''' <param name="destino">Email del receptor</param>
    ''' <param name="Asunto">asunto del mensaje</param>
    ''' <param name="mensaje">mensaje</param>
    ''' <param name="archivos">ficheros que se adjuntaran al email</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function mandarEmail(panel As String, email As String, contrasenya As String, nombre As String, destino As String, Asunto As String, mensaje As String, archivos As String()) As Integer
        Dim correcto As Integer = 0

        If panel = "izquierda" Then
            correcto = izquierda.enviarArchivo(email, contrasenya, nombre, destino, Asunto, mensaje, archivos)
        Else
            correcto = derecha.enviarArchivo(email, contrasenya, nombre, destino, Asunto, mensaje, archivos)

        End If

        Return correcto
    End Function

    ''' <summary>
    ''' manda a los paneles los archivos a imprimir
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="archivos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function imprimir(panel As String, archivos As String()) As Boolean
        Dim correcto As Boolean = False

        If panel = "izquierda" Then
            correcto = izquierda.Imprimir(archivos)

        Else
            correcto = derecha.Imprimir(archivos)
        End If

        Return correcto
    End Function

End Class
