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

        Dim srLector As StreamReader = New StreamReader("pref.pre")
        Dim Linea As String
        Dim ContadorLin As Integer = 1
        Linea = srLector.ReadLine()

        Return Linea.Split(CChar("Ä"))

    End Function


End Class
