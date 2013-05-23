Public Class Tutorial4

    Dim Anterior As Tutorial3
    Dim siguiente As Tutorial5

    Private Sub Tutorial4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Anterior = New Tutorial3()
        siguiente = New Tutorial5()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Anterior.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        siguiente.ShowDialog()

    End Sub
End Class