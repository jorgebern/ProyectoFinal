Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 100
            ListView1.Items.Add(i & "")
        Next



    End Sub
End Class