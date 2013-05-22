Public Class informacion

    Dim nombre As String
    Dim extension As String
    Dim ruta As String
    Dim tamanyo As String
    Dim creacion As String
    Dim modificado As String
    Dim tamanyoLetra As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Font = New Font("Microsoft Sans Serif", tamanyoLetra)
        Txb_nombre.Text = nombre
        Lbl_extension.Text = extension
        Lbl_ubicacion.Text = ruta
        Lbl_tamanyo.Text = tamanyo & " bytes"
        Lbl_creacion.Text = creacion
        Lbl_modificado.Text = modificado

    End Sub

    Public Sub obtenerParametros(informacion As String(), tamanyo As Single)
        nombre = informacion(0)
        extension = informacion(1)
        ruta = informacion(2)
        Me.tamanyo = informacion(3)
        creacion = informacion(4)
        modificado = informacion(5)
        tamanyoLetra = tamanyo
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Cbx_atributos.CheckedChanged
        Btn_aplicar.Enabled = True
    End Sub

    Private Sub Txb_nombre_TextChanged(sender As Object, e As EventArgs) Handles Txb_nombre.TextChanged

        If Txb_nombre.Text <> nombre Then
            Btn_aplicar.Enabled = True
        Else
            Btn_aplicar.Enabled = False
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Btn_aceptar_Click(sender As Object, e As EventArgs) Handles Btn_aceptar.Click
        Me.Close()
    End Sub

    Private Sub Btn_aplicar_Click(sender As Object, e As EventArgs) Handles Btn_aplicar.Click

    End Sub
End Class