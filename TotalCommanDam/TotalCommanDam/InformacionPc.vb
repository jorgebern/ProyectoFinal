Public Class InformacionPc


    Dim datos As String()
    Dim tamanyo As Single

    Private Sub InformacionPc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Font = New Font("Microsoft Sans Serif", tamanyo)

        Lbl_userName.Text = datos(0)
        Lbl_MachineName.Text = datos(1)

        Lbl_SoVersion.Text = datos(2)
        Lbl_servicePack.Text = datos(3)
        Lbl_procesadores.Text = datos(4)
        Lbl_ticks.Text = datos(5)

        Lbl_hora.Text = datos(7)


        Dim ram As Double = CDbl(datos(6))

        ram = ram / 1024
        ram = ram / 1024
        ram = ram / 1024

        ram = Math.Round(ram, 2)

        Lbl_ram.Text = ram.ToString & " GB"



    End Sub


    Public Sub obtenerParametros(informacion As String(), tamanyo As Single)
        datos = informacion
        Me.tamanyo = tamanyo
    End Sub

    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        Me.Close()

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub
End Class