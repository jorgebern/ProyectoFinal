Public Class Favoritos

    Dim favoritos As List(Of String)
    Dim _aceptar As Boolean
    Dim _predeterminado As String
    Dim mostrar As Boolean = True

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

        For i As Integer = 0 To favoritos.Count - 1

            Dim datos As String() = favoritos(i).Split(CChar("Ä"))

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
    ''' Permite borrar mediante la tecla Delete
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown

        If e.KeyCode = Keys.Delete Then
            Dim cuenta As Integer = 0
            For Each elemento As Integer In ListView1.SelectedIndices

                If ListView1.Items(elemento).SubItems(1).Text = _predeterminado Then
                    _predeterminado = My.Computer.FileSystem.SpecialDirectories.Desktop
                End If

                favoritos.RemoveAt(elemento - cuenta)
                cuenta += 1
            Next

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
        _aceptar = False
        Me.Close()
    End Sub

    ''' <summary>
    ''' Acepta el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim compro As Boolean = True

        For i As Integer = 0 To ListView1.Items.Count - 1
            favoritos(i).Replace("True", "False")
            If ListView1.Items(i).Checked Then
                favoritos.RemoveAt(i)
                favoritos.Insert(i, ListView1.Items(i).Text & "Ä" & ListView1.Items(i).SubItems(1).Text & "Ä" & True)
                _predeterminado = ListView1.Items(i).SubItems(1).Text
                compro = False
            End If
        Next

        If compro Then
            _predeterminado = _predeterminado
        End If

        _aceptar = True
        Me.Close()
    End Sub

    
    ''' <summary>
    ''' Permite editar el nombre de nuestro favorito
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick

        ListView1.SelectedItems(0).BeginEdit()

    End Sub

    ''' <summary>
    ''' Guarda el nombre de nuestro favorito
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListView1_AfterLabelEdit(sender As Object, e As LabelEditEventArgs) Handles ListView1.AfterLabelEdit

        If e.Label <> "" Then
            Dim datos As String() = favoritos(e.Item).Split(CChar("Ä"))

            favoritos.RemoveAt(e.Item)
            favoritos.Insert(e.Item, e.Label & "Ä" & datos(1) & "Ä" & False)

        End If

    End Sub

    ''' <summary>
    ''' Activa las Check box para seleccionar la ruta predeterminada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Btn_elegir_Click(sender As Object, e As EventArgs) Handles Btn_elegir.Click


        If mostrar Then
            ListView1.CheckBoxes = True
            Btn_elegir.Text = "ocultar seleccion"
            mostrar = False
        Else
            ListView1.CheckBoxes = False
            Btn_elegir.Text = "Elegir predeterminada"
            mostrar = True
        End If


    End Sub

    ''' <summary>
    ''' Selecciona un check box unicamente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListView1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ListView1.ItemCheck
        If e.CurrentValue <> CheckState.Indeterminate Then
            e.NewValue = CheckState.Unchecked
        End If

        If e.CurrentValue = CheckState.Unchecked Then
            e.NewValue = CheckState.Checked
        End If

        If e.CurrentValue = CheckState.Checked Then
            e.NewValue = CheckState.Unchecked
        End If

        If e.NewValue = CheckState.Checked Then

            For i As Integer = 0 To ListView1.Items.Count - 1
                ListView1.Items(i).Checked = False
            Next

            e.NewValue = CheckState.Checked
        End If


    End Sub

    ''' <summary>
    ''' Propiedad de los favoritos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FavoritosProp As String()
        Get
            Return favoritos.ToArray
        End Get
        Set(value As String())
            Me.favoritos = value.ToList
        End Set
    End Property

    ''' <summary>
    ''' Propiedad de Aceptar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Aceptar As Boolean
        Get
            Return _aceptar
        End Get
        Set(value As Boolean)
            _aceptar = value
        End Set
    End Property

    Public Property Predeterminado As String
        Get
            Return _predeterminado
        End Get
        Set(value As String)
            _predeterminado = value
        End Set
    End Property

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim cuenta As Integer = 0
        For Each elemento As Integer In ListView1.SelectedIndices

            If ListView1.Items(elemento).SubItems(1).Text = _predeterminado Then
                _predeterminado = My.Computer.FileSystem.SpecialDirectories.Desktop
            End If

            favoritos.RemoveAt(elemento - cuenta)
            cuenta += 1
        Next

        For i As Integer = 0 To ListView1.SelectedItems.Count - 1
            ListView1.SelectedItems(0).Remove()

        Next

        ListView1.Update()
    End Sub

    Private Sub RenombrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenombrarToolStripMenuItem.Click
        ListView1.SelectedItems(0).BeginEdit()
    End Sub
End Class