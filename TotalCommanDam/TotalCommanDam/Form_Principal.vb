''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class Form_Principal

    Private Const MARGEN_BORDE As Long = 60
    Public total As TotalComander = New TotalComander()

    Private Sub Form_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Ltb_derecha.AllowDrop = True
        Ltb_izquierda.AllowDrop = True
        Lbl_izquierda.Width = Ltb_izquierda.Width
        Me.refrescarFormulario()

        Ts_user.Text = Environment.UserName


    End Sub


    Private Sub Form_Principal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        Ltb_izquierda.Width = CInt((Me.Width / 2) - 30)

        Ltb_derecha.Location = New Point(Ltb_izquierda.Width + 20, Ltb_izquierda.Location.Y)
        Ltb_derecha.Width = CInt((Me.Width / 2) - 15)


        Ltb_izquierda.Height = Me.Height - 150
        Ltb_derecha.Height = Me.Height - 150


        Lbl_derecha.Location = New Point(Ltb_izquierda.Width + 20, Lbl_izquierda.Location.Y)

    End Sub

    Private Sub refrescarFormulario()

        'Limpiar listbox
        Ltb_izquierda.Items.Clear()
        Ltb_derecha.Items.Clear()

        Dim lista As List(Of String)
        'Izquierda
        lista = total.obtenerArchivos("izquierda")
        For Each elemento As String In lista
            If elemento = "--error1--" Then
                Ntf_Icon.BalloonTipText = "No tiene permisos para abrir esa carpeta"
                Ntf_Icon.BalloonTipTitle = "Error"
                Ntf_Icon.BalloonTipIcon = ToolTipIcon.Error
                Ntf_Icon.ShowBalloonTip(5)
                Continue For
            End If
            Ltb_izquierda.Items.Add(elemento)
        Next

        'Labels
        Lbl_izquierda.Text = total.obtenerRuta("izquierda")
        Lbl_derecha.Text = total.obtenerRuta("derecha")

        'Derecha
        lista = total.obtenerArchivos("derecha")

        For Each elemento As String In lista
            Ltb_derecha.Items.Add(elemento)

        Next
    End Sub

    Private Sub Ltb_izquierda_DoubleClick(sender As Object, e As EventArgs) Handles Ltb_izquierda.DoubleClick
        If Ltb_izquierda.Focused Then
            If Ltb_izquierda.SelectedIndex >= 0 Then
                If My.Computer.FileSystem.DirectoryExists(total.obtenerRuta("izquierda") & "\" & Ltb_izquierda.SelectedItem.ToString) Then
                    total.CambiarRuta("izquierda", Ltb_izquierda.SelectedItem.ToString)
                    refrescarFormulario()
                Else
                    total.ejecutarFichero("izquierda", Ltb_izquierda.SelectedItem.ToString)
                End If
                
            End If

        End If
    End Sub

    '---------------------------------------------------------------------------------------------
    'IZQUIERDA
    '---------------------------------------------------------------------------------------------

    Private Sub Ltb_izquierda_MouseDown(sender As Object, e As MouseEventArgs) Handles Ltb_izquierda.MouseDown

        If e.Clicks = 2 Then
            Return
        End If

        Dim index As Integer = Ltb_izquierda.IndexFromPoint(e.X, e.Y)

        If index >= 0 Then
            Dim dde1 As DragDropEffects = Ltb_izquierda.DoDragDrop(Ltb_izquierda.Items(index).ToString, DragDropEffects.All)

        End If
    End Sub


    Private Sub Ltb_izquierda_DragDrop(sender As Object, e As DragEventArgs) Handles Ltb_izquierda.DragDrop
        If e.Data.GetDataPresent(DataFormats.StringFormat) Then
            Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))
            ToolStripProgressBar1.Value = 100
            Ntf_Icon.BalloonTipTitle = "Copia"
            Ntf_Icon.BalloonTipText = "Archivo copiado correctamente"
            Ntf_Icon.ShowBalloonTip(10)
            Ltb_izquierda.Items.Add(str)
            Tmr_Limpiar.Start()
        End If
    End Sub

    Private Sub Ltb_izquierda_GotFocus(sender As Object, e As EventArgs) Handles Ltb_izquierda.GotFocus

        Lbl_derecha.BackColor = SystemColors.Control
        Lbl_derecha.ForeColor = Color.Black

        Lbl_izquierda.ForeColor = Color.White
        Lbl_izquierda.BackColor = SystemColors.Highlight

    End Sub

    Private Sub Ltb_izquierda_DragOver(sender As Object, e As DragEventArgs) Handles Ltb_izquierda.DragOver
        If Ltb_izquierda.Focused Then
            e.Effect = Nothing
        Else
            e.Effect = DragDropEffects.All
        End If
    End Sub

    '---------------------------------------------------------------------------------------------
    'DERECHA
    '---------------------------------------------------------------------------------------------
    Private Sub Ltb_derecha_DoubleClick(sender As Object, e As EventArgs) Handles Ltb_derecha.DoubleClick
        If Ltb_derecha.Focused Then
            total.CambiarRuta("derecha", Ltb_derecha.SelectedItem.ToString)
            refrescarFormulario()
        End If

    End Sub

    Private Sub Ltb_derecha_DragOver(sender As Object, e As DragEventArgs) Handles Ltb_derecha.DragOver
        If Ltb_derecha.Focused Then
            e.Effect = Nothing
        Else
            e.Effect = DragDropEffects.All
        End If

    End Sub

    Private Sub Ltb_derecha_DragDrop(sender As Object, e As DragEventArgs) Handles Ltb_derecha.DragDrop
        If e.Data.GetDataPresent(DataFormats.StringFormat) Then
            If Ltb_derecha.Focused Then
                Return
            End If
            Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))
            ToolStripProgressBar1.Value = 100
            Ntf_Icon.BalloonTipTitle = "Copia"
            Ntf_Icon.BalloonTipText = "Archivo copiado correctamente"
            Ntf_Icon.ShowBalloonTip(10)
            Ltb_derecha.Items.Add(str)
            Tmr_Limpiar.Start()
        End If
    End Sub


    Private Sub Ltb_Derecha_GotFocus(sender As Object, e As EventArgs) Handles Ltb_derecha.GotFocus

        Lbl_izquierda.BackColor = SystemColors.Control
        Lbl_izquierda.ForeColor = Color.Black

        Lbl_derecha.ForeColor = Color.White
        Lbl_derecha.BackColor = SystemColors.Highlight

    End Sub

    Private Sub Ltb_derecha_MouseDown(sender As Object, e As MouseEventArgs) Handles Ltb_derecha.MouseDown

        If e.Clicks = 2 Then
            Return
        End If

        Dim index As Integer = Ltb_derecha.IndexFromPoint(e.X, e.Y)

        If index >= 0 Then
            Dim dde1 As DragDropEffects = Ltb_derecha.DoDragDrop(Ltb_derecha.Items(index).ToString, DragDropEffects.All)

        End If
    End Sub

    '---------------------------------------------------------------------------------------------
    'OTROS
    '---------------------------------------------------------------------------------------------



    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AcercaDeTotalComanDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeTotalComanDamToolStripMenuItem.Click
        acercaDe.ShowDialog()
    End Sub

    Private Sub Tmr_Limpiar_Tick(sender As Object, e As EventArgs) Handles Tmr_Limpiar.Tick
        ToolStripProgressBar1.Value = 0
        Tmr_Limpiar.Stop()
    End Sub

    Private Sub InformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónToolStripMenuItem.Click

    End Sub
End Class
