Imports System.IO

Public Class Preferencias

    ''' <summary>
    ''' Escribe las preferencias en un fichero
    ''' </summary>
    ''' <param name="tutorial"></param>
    ''' <param name="color"></param>
    ''' <param name="tamanyo"></param>
    ''' <remarks></remarks>
    Public Sub EscribirPreferencias(usuario As String, tutorial As Boolean, color As Integer, tamanyo As Single, predeterminada As String)

        Dim linea As String
        Dim listas As List(Of String) = New List(Of String)


        Try
            Dim srLector As StreamReader = New StreamReader("pref.pre")

            linea = srLector.ReadLine()

            Do While Not (linea Is Nothing)

                Dim datos As String() = linea.Split(CChar("Ä"))

                If datos(0) <> usuario Then
                    listas.Add(linea)
                End If

                linea = srLector.ReadLine()

            Loop

            srLector.Close()
        Catch ex As Exception

        End Try

        Dim swEscritor As StreamWriter

        swEscritor = New StreamWriter("pref.pre")

        For Each elemento As String In listas
            swEscritor.WriteLine(elemento)
        Next
        swEscritor.WriteLine(usuario & "Ä" & tutorial & "Ä" & color & "Ä" & tamanyo & "Ä" & predeterminada)

        swEscritor.Close()
    End Sub

    ''' <summary>
    ''' Lee las opciones predeterminadas
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerPreferencias(usuario As String) As String()

        Dim Linea As String
        Dim ContadorLin As Integer = 1
        Dim lista As List(Of String) = New List(Of String)
        Dim datosUsuario As String = ""

        Try
            Dim srLector As StreamReader = New StreamReader("pref.pre")

            Linea = srLector.ReadLine()

            Do While Not (Linea Is Nothing)

                Dim datos As String() = Linea.Split(CChar("Ä"))

                If datos(0) = usuario Then
                    datosUsuario = Linea
                End If

                Linea = srLector.ReadLine()

            Loop

            srLector.Close()
        Catch ex As Exception
            datosUsuario = usuario & "ÄtrueÄ1Ä8.25Ä" & My.Computer.FileSystem.SpecialDirectories.Desktop

        End Try

        Return datosUsuario.Split(CChar("Ä"))

    End Function


    ''' <summary>
    ''' Escribe en el fichero de favoritos el favorito añadido recientemente
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="ruta"></param>
    ''' <param name="nombre"></param>
    ''' <remarks></remarks>
    Public Sub EscribirFavoritos(usuario As String, ruta As String, nombre As String, predeterminado As Boolean)

        Dim swEscritor As StreamWriter

        swEscritor = New StreamWriter("favoritos.fav", True)

        swEscritor.WriteLine(usuario & "Ä" & ruta & "Ä" & nombre & "Ä" & predeterminado)

        swEscritor.Close()
    End Sub


    ''' <summary>
    ''' Obtiene una lista de favoritos del usuario activo
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerFavoritos(usuario As String) As String()

        Dim ContadorLin As Integer = 1
        Dim favoritos As List(Of String) = New List(Of String)
        Dim srLector As StreamReader

        Try
            srLector = New StreamReader("favoritos.fav")

            Dim Linea As String



            Linea = srLector.ReadLine()

            Do While Not (Linea Is Nothing)

                Dim datos As String() = Linea.Split(CChar("Ä"))

                If datos(0) = usuario Then
                    favoritos.Add(datos(1) & "Ä" & datos(2) & "Ä" & datos(3))
                End If

                Linea = srLector.ReadLine()

            Loop
            srLector.Close()
        Catch ex As Exception

        Finally

        End Try

        Return favoritos.ToArray

    End Function

    ''' <summary>
    ''' Elimina un favorito de la lista
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="favoritos"></param>
    ''' <remarks></remarks>
    Public Sub eliminarFavoritos(usuario As String, favoritos As String)
        Dim ContadorLin As Integer = 1
        Dim srLector As StreamReader
        Dim fav As List(Of String) = New List(Of String)


        Try
            srLector = New StreamReader("favoritos.fav")

            Dim Linea As String

            Linea = srLector.ReadLine()

            Do While Not (Linea Is Nothing)

                Dim datos As String() = Linea.Split(CChar("Ä"))

                If datos(0) = usuario And (datos(1) = favoritos Or datos(2) = favoritos) Then
                    'Borrado
                Else
                    fav.Add(Linea)
                End If

                Linea = srLector.ReadLine()

            Loop
            srLector.Close()
        Catch ex As Exception

        Finally

        End Try


        Dim swEscritor As StreamWriter

        swEscritor = New StreamWriter("favoritos.fav",False)

        For Each elemento As String In fav
            swEscritor.WriteLine(elemento)
        Next

        swEscritor.Close()


    End Sub

    ''' <summary>
    ''' Guarda los favoritos al cambiar de nombre
    ''' </summary>
    ''' <param name="favoritos"></param>
    ''' <remarks></remarks>
    Public Sub GuardarFavoritos(favoritos As String())
        Dim ContadorLin As Integer = 1
        Dim srLector As StreamReader
        Dim fav As List(Of String) = New List(Of String)


        Try
            srLector = New StreamReader("favoritos.fav")

            Dim Linea As String

            Linea = srLector.ReadLine()

            Do While Not (Linea Is Nothing)

                Dim datos As String() = Linea.Split(CChar("Ä"))

                If datos(0) = Environment.UserName Then
                    'Borrado
                Else
                    fav.Add(Linea)
                End If

                Linea = srLector.ReadLine()

            Loop
            srLector.Close()
        Catch ex As Exception

        Finally

        End Try


        Dim swEscritor As StreamWriter

        swEscritor = New StreamWriter("favoritos.fav", False)

        For Each elemento As String In fav
            swEscritor.WriteLine(Environment.UserName & "Ä" & elemento)
        Next

        For i As Integer = 3 To favoritos.Length - 1
            Dim datos As String() = favoritos(i).Split(CChar("Ä"))
            swEscritor.WriteLine(Environment.UserName & "Ä" & datos(1) & "Ä" & datos(0) & "Ä" & datos(2))
        Next

        swEscritor.Close()

    End Sub




End Class
