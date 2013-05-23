Public Class Tutorial1

    Dim siguiente As Tutorial2

    Private Sub Tutorial1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        siguiente = New Tutorial2()
        'Me.ShowInTaskbar = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        siguiente.ShowDialog()

    End Sub

    
End Class