Public Class buscando

    Dim ticks As Integer = 0

    Private Sub buscando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ticks = 3 Then
            ticks = 0
            Lbl_buscando.Text = "Buscando"
        Else
            Lbl_buscando.Text = Lbl_buscando.Text & "."
            ticks += 1
        End If

    End Sub

    Private Sub buscando_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Public Sub LlenarBarra(progreso As Integer)
        Pgb_buscando.Increment(progreso)
    End Sub

End Class