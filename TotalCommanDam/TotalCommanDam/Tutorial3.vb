Public Class Tutorial3

    Dim Anterior As Tutorial2
    Dim siguiente As Tutorial4

    Private Sub Tutorial3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Anterior = New Tutorial2()
        siguiente = New Tutorial4()

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