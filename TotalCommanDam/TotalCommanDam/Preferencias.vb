Imports System.IO

Public Class Preferencias

    ''' <summary>
    ''' Escribe las preferencias en un fichero
    ''' </summary>
    ''' <param name="tutorial"></param>
    ''' <param name="color"></param>
    ''' <param name="tamanyo"></param>
    ''' <remarks></remarks>
    Public Sub EscribirPreferencias(tutorial As Boolean, color As Integer, tamanyo As Single)

        Dim swEscritor As StreamWriter

        swEscritor = New StreamWriter("pref.pre")

        swEscritor.WriteLine(tutorial & "Ä" & color & "Ä" & tamanyo)

        swEscritor.Close()
    End Sub

    ''' <summary>
    ''' Lee las opciones predeterminadas
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerPreferencias() As String()

        Dim Linea As String
        Dim ContadorLin As Integer = 1

        Try

        
        Dim srLector As StreamReader = New StreamReader("pref.pre")

            Linea = srLector.ReadLine()
            srLector.Close()
        Catch ex As Exception
            Linea = "trueÄ1Ä8.25"
        End Try

        Return Linea.Split(CChar("Ä"))

    End Function



    Public Sub EscribirFavoritos(usuario As String, ruta As String, nombre As String)

        Dim swEscritor As StreamWriter

        swEscritor = New StreamWriter("favoritos.fav", True)

        swEscritor.WriteLine(usuario & "Ä" & ruta & "Ä" & nombre)

        swEscritor.Close()
    End Sub


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
                    favoritos.Add(datos(1) & "Ä" & datos(2))
                End If

                Linea = srLector.ReadLine()

            Loop
            srLector.Close()
        Catch ex As Exception

        Finally

        End Try

        Return favoritos.ToArray

    End Function

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

End Class
