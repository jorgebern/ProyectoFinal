Public Class Tutorial5

    Dim Anterior As Tutorial4

    Private Sub Tutorial5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Anterior = New Tutorial4
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Anterior.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class