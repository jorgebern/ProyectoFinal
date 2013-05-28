Public Class Favoritos

    Dim favoritos As String()

    ''' <summary>
    ''' Carga los favoritos 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Favoritos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Set view property
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        'Add column header
        ListView1.Columns.Add("Nombre", 100)
        ListView1.Columns.Add("Ruta", ListView1.Width - 121)

        'Add items in the listview
        Dim arr(3) As String
        Dim itm As ListViewItem

        For Each elemento As String In favoritos

            Dim datos As String() = elemento.Split(CChar("Ä"))

            arr(0) = datos(0)
            arr(1) = datos(1)
            itm = New ListViewItem(arr)
            ListView1.Items.Add(itm)
        Next

    End Sub

    ''' <summary>
    ''' Evita que las columnas se puedan agrandar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListView1_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles ListView1.ColumnWidthChanging

        e.Cancel = True

        If e.ColumnIndex = 1 Then
            e.NewWidth = ListView1.Width - 121
        Else
            e.NewWidth = 100
        End If


    End Sub

    ''' <summary>
    ''' Añade la lista de favoritos
    ''' </summary>
    ''' <param name="favoritos"></param>
    ''' <remarks></remarks>
    Public Sub anyadirFavoritos(favoritos As String())
        Me.favoritos = favoritos

    End Sub

    ''' <summary>
    ''' Permite borrar mediante la tecla Delete
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown

        If e.KeyCode = Keys.Delete Then
            For i As Integer = 0 To ListView1.SelectedItems.Count - 1
                ListView1.SelectedItems(0).Remove()
            Next

            ListView1.Update()
        End If
    End Sub
    ''' <summary>
    ''' Cuerra el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Acepta el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class