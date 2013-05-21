''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class Form_Principal

    Dim total As TotalComander = New TotalComander()
    Dim informacio As informacion
    '0 = izquierda
    '1 = derecha
    Dim panelEnFoco As Integer

    Dim color_Items As Brush
    Dim color_Selected As Brush
    Dim color_fondo As Color

    ''' <summary>
    ''' Load del form principal, cambia los colores de fondo, los carga y refresca el formulairo por primera vez
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        color_Items = Brushes.LightBlue
        color_Selected = Brushes.CadetBlue
        color_fondo = Color.PowderBlue

        Ltb_derecha.AllowDrop = True
        Ltb_izquierda.AllowDrop = True

        Lbl_izquierda.Width = Ltb_izquierda.Width
        Me.refrescarFormulario()

        Ts_user.Text = Environment.UserName
    End Sub

    ''' <summary>
    ''' Se encarga de manipular los elementos para que quepan en la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form_Principal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        Ltb_izquierda.Width = CInt((Me.Width / 2) - 30)

        Ltb_derecha.Location = New Point(Ltb_izquierda.Width + 20, Ltb_izquierda.Location.Y)
        Ltb_derecha.Width = CInt((Me.Width / 2) - 15)


        Ltb_izquierda.Height = Me.Height - 150
        Ltb_derecha.Height = Me.Height - 150


        Lbl_derecha.Location = New Point(Ltb_izquierda.Width + 20, Lbl_izquierda.Location.Y)

    End Sub

    ''' <summary>
    ''' Refresca el formulario dibujando los items en las diferentes ListBox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub refrescarFormulario()

        Me.BackColor = color_fondo

        'Limpiar listbox
        Ltb_izquierda.Items.Clear()


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
        Ltb_derecha.Items.Clear()

        'Labels
        Lbl_izquierda.Text = total.obtenerRuta("izquierda")
        Lbl_derecha.Text = total.obtenerRuta("derecha")

        'Derecha

        lista = total.obtenerArchivos("derecha")
        For Each elemento As String In lista
            If elemento = "--error1--" Then
                Ntf_Icon.BalloonTipText = "Usted no dispone de permisos para abrir esa carpeta"
                Ntf_Icon.BalloonTipTitle = "Permisos"
                Ntf_Icon.BalloonTipIcon = ToolTipIcon.Warning
                Ntf_Icon.ShowBalloonTip(5)
                Continue For
            End If
            Ltb_derecha.Items.Add(elemento)
        Next

    End Sub

    

    '---------------------------------------------------------------------------------------------
    'IZQUIERDA
    '---------------------------------------------------------------------------------------------

    ''' <summary>
    ''' Dibuja los items en diferentes colores, dependiendo si esta seleccionado o no o si es impar o par
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_izquierda_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Ltb_izquierda.DrawItem
        If e.Index <> -1 Then

            e.DrawBackground()

            If e.Index Mod 2 = 0 Then
                e.Graphics.FillRectangle(color_Items, e.Bounds)
            End If


            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                e.Graphics.FillRectangle(color_Selected, e.Bounds)
            End If
            Using b As New SolidBrush(e.ForeColor)
                e.Graphics.DrawString(Ltb_izquierda.GetItemText(Ltb_izquierda.Items(e.Index)), e.Font, b, e.Bounds)
            End Using

            e.DrawFocusRectangle()
        End If
    End Sub


    ''' <summary>
    ''' Maneja el doble click en el panel izquierdo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_izquierda_DoubleClick(sender As Object, e As EventArgs) Handles Ltb_izquierda.DoubleClick
        If panelEnFoco = 0 Then
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

    

    ''' <summary>
    ''' Controla el click con el mouse, seleccionando asi el elemento i preparandolo para el Drag and Drop
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_izquierda_MouseDown(sender As Object, e As MouseEventArgs) Handles Ltb_izquierda.MouseDown

        If e.Clicks = 2 Then
            Return
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Return
        End If


        Dim index As Integer = Ltb_izquierda.IndexFromPoint(e.X, e.Y)

        If index = -1 Then
            Ltb_izquierda.SelectedIndex = -1
        End If

        If index >= 0 Then
            Dim dde1 As DragDropEffects = Ltb_izquierda.DoDragDrop(Ltb_izquierda.Items(index).ToString, DragDropEffects.All)

        End If
    End Sub

    ''' <summary>
    ''' Acciones que se ejecutaran al realizarse el Drag and Drop
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_izquierda_DragDrop(sender As Object, e As DragEventArgs) Handles Ltb_izquierda.DragDrop
        If e.Data.GetDataPresent(DataFormats.StringFormat) Then
            Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))
            ToolStripProgressBar1.Value = 100
            Ntf_Icon.BalloonTipTitle = "Copia"
            Ntf_Icon.BalloonTipText = "Archivo copiado correctamente"
            Ntf_Icon.ShowBalloonTip(10)
            Ltb_izquierda.Items.Add(str)
            Tmr_Limpiar.Start()
            total.Copiar("derecha", Ltb_derecha.SelectedItems)
        End If
    End Sub

    ''' <summary>
    ''' Cambia los colores para dar un aspecto "realzado" al panel cuando este obtiene el foco
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_izquierda_GotFocus(sender As Object, e As EventArgs) Handles Ltb_izquierda.GotFocus
        panelEnFoco = 0
        Lbl_derecha.BackColor = color_fondo
        Lbl_derecha.ForeColor = Color.Black
        Ltb_derecha.BackColor = Color.WhiteSmoke

        Lbl_izquierda.ForeColor = Color.White
        Lbl_izquierda.BackColor = SystemColors.Highlight
        Ltb_izquierda.BackColor = Color.White

    End Sub

    ''' <summary>
    ''' Obtiene la señal correcta que permite hacer el Drag and Drop
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_izquierda_DragOver(sender As Object, e As DragEventArgs) Handles Ltb_izquierda.DragOver
        If panelEnFoco = 0 Then
            e.Effect = Nothing
        Else
            e.Effect = DragDropEffects.All
        End If
    End Sub

    '---------------------------------------------------------------------------------------------
    'DERECHA
    '---------------------------------------------------------------------------------------------

    ''' <summary>
    ''' Dibuja los items en diferentes colores, dependiendo si esta seleccionado o no o si es impar o par
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_derecha_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Ltb_derecha.DrawItem
        If e.Index <> -1 Then
            e.DrawBackground()

            If e.Index Mod 2 = 0 Then
                e.Graphics.FillRectangle(color_Items, e.Bounds)
            End If

            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                e.Graphics.FillRectangle(color_Selected, e.Bounds)

            End If
            Using b As New SolidBrush(e.ForeColor)
                e.Graphics.DrawString(Ltb_derecha.GetItemText(Ltb_derecha.Items(e.Index)), e.Font, b, e.Bounds)
            End Using

            e.DrawFocusRectangle()
        End If

    End Sub


    ''' <summary>
    ''' Controla el doble click sobre un archivo para ejecutarlo o navegar en las carpetas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_derecha_DoubleClick(sender As Object, e As EventArgs) Handles Ltb_derecha.DoubleClick
        If panelEnFoco = 1 Then
            If Ltb_derecha.SelectedIndex >= 0 Then
                If My.Computer.FileSystem.DirectoryExists(total.obtenerRuta("derecha") & "\" & Ltb_derecha.SelectedItem.ToString) Then
                    total.CambiarRuta("derecha", Ltb_derecha.SelectedItem.ToString)
                    refrescarFormulario()
                Else
                    total.ejecutarFichero("derecha", Ltb_derecha.SelectedItem.ToString)
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Controla el click con el mouse, seleccionando asi el elemento i preparandolo para el Drag and Drop 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_derecha_MouseDown(sender As Object, e As MouseEventArgs) Handles Ltb_derecha.MouseDown

        If e.Clicks = 2 Then
            Return
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Return
        End If


        Dim index As Integer = Ltb_derecha.IndexFromPoint(e.X, e.Y)

        If index = -1 Then
            Ltb_derecha.SelectedIndex = -1
        End If


        If index >= 0 Then

            Dim dde1 As DragDropEffects = Ltb_derecha.DoDragDrop(Ltb_derecha.SelectedItems, DragDropEffects.All)

        End If
    End Sub


    ''' <summary>
    ''' Acciones que se ejecutaran al realizarse el Drag and Drop
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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
            total.Copiar("izquierda", Ltb_izquierda.SelectedItems)
        End If
    End Sub

    ''' <summary>
    ''' Cambia los colores para dar un aspecto "realzado" al panel cuando este obtiene el foco
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_Derecha_GotFocus(sender As Object, e As EventArgs) Handles Ltb_derecha.GotFocus

        panelEnFoco = 1
        Lbl_izquierda.BackColor = color_fondo
        Lbl_izquierda.ForeColor = Color.Black
        Ltb_izquierda.BackColor = Color.WhiteSmoke

        Lbl_derecha.ForeColor = Color.White
        Lbl_derecha.BackColor = SystemColors.Highlight
        Ltb_derecha.BackColor = Color.White


    End Sub


    ''' <summary>
    ''' Obtiene la señal correcta que permite hacer el Drag and Drop
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_derecha_DragOver(sender As Object, e As DragEventArgs) Handles Ltb_derecha.DragOver
        If panelEnFoco = 1 Then
            e.Effect = Nothing
        Else
            e.Effect = DragDropEffects.All
        End If
    End Sub


    '---------------------------------------------------------------------------------------------
    'OTROS
    '---------------------------------------------------------------------------------------------

    Private Sub Ts_recargar_Click(sender As Object, e As EventArgs) Handles Ts_recargar.Click
        Me.refrescarFormulario()
    End Sub

    

    
    
    '--------------------------
    'Aspectos
    '--------------------------
    Private Sub GrassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrassToolStripMenuItem.Click

        GrassToolStripMenuItem.Checked = True
        AzulToolStripMenuItem.Checked = False
        FlowersToolStripMenuItem.Checked = False

        Me.color_fondo = Color.LimeGreen
        Me.color_Items = Brushes.LightGreen
        Me.color_Selected = Brushes.Chocolate
        refrescarFormulario()

    End Sub

    Private Sub AzulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AzulToolStripMenuItem.Click

        GrassToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = True
        FlowersToolStripMenuItem.Checked = False
        DarkToolStripMenuItem.Checked = False

        Me.color_fondo = Color.PowderBlue
        Me.color_Items = Brushes.LightBlue
        Me.color_Selected = Brushes.CadetBlue
        refrescarFormulario()
    End Sub

    Private Sub FlowersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlowersToolStripMenuItem.Click

        GrassToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = False
        FlowersToolStripMenuItem.Checked = True
        DarkToolStripMenuItem.Checked = False


        Me.color_fondo = Color.Plum
        Me.color_Items = Brushes.LightPink
        Me.color_Selected = Brushes.Violet
        refrescarFormulario()

    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click

        GrassToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = False
        FlowersToolStripMenuItem.Checked = False
        DarkToolStripMenuItem.Checked = True


        Me.color_fondo = Color.Silver
        Me.color_Items = Brushes.LightGray
        Me.color_Selected = Brushes.Indigo
        refrescarFormulario()
    End Sub


   


    '----------------------------------------------------
    'Opciones
    '----------------------------------------------------


    'RENOMBRAR
    '---------------------------------------------------------
    Private Sub RenombrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenombrarToolStripMenuItem.Click

        Renombrar()

    End Sub

    Private Sub RenombrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RenombrarToolStripMenuItem1.Click
        Renombrar()
    End Sub

    Public Sub Renombrar()

        Dim respuesta As String
        Dim mensaje As String = "¿Está seguro de que desea renombrar el/los archivos?: "

        If panelEnFoco = 0 Then
            For Each elemento As String In Ltb_izquierda.SelectedItems
                mensaje = mensaje & vbCrLf & vbTab & "- " & elemento
            Next
            respuesta = InputBox(mensaje, "Nuevo nombre: ")

            If respuesta <> "" Then
                total.RenombrarVarios("izquierda", Ltb_izquierda.SelectedItems, respuesta)
            End If

        ElseIf panelEnFoco = 1 Then
            For Each elemento As String In Ltb_derecha.SelectedItems
                mensaje = mensaje & vbCrLf & vbTab & "- " & elemento
            Next
            respuesta = InputBox(mensaje, "Nuevo nombre: ")

            If respuesta <> "" Then
                total.RenombrarVarios("derecha", Ltb_derecha.SelectedItems, respuesta)
            End If

        End If
        refrescarFormulario()
    End Sub


    '----------------------------------------------------------------------------


    'BORRAR
    '---------------------------------------------------------------------------
    Private Sub BorrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem1.Click
        Me.Borrar()
    End Sub

    ''' <summary>
    ''' BORRAR
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        Me.Borrar()
    End Sub

    Public Sub Borrar()

        Dim mensaje As String = "¿Está seguro de que desea eliminar el/los archivos?: "
        

        If panelEnFoco = 0 Then

            For Each elemento As String In Ltb_izquierda.SelectedItems
                mensaje = mensaje & vbCrLf & vbTab & "- " & elemento
            Next

            If MsgBox(mensaje, MsgBoxStyle.YesNo, "Borrar") = MsgBoxResult.Yes Then
                total.Borrar("izquierda", Ltb_izquierda.SelectedItems)
                Me.refrescarFormulario()
            End If
        ElseIf panelEnFoco = 1 Then

            For Each elemento As String In Ltb_derecha.SelectedItems
                mensaje = mensaje & vbCrLf & vbTab & "- " & elemento
            Next

            If MsgBox(mensaje, MsgBoxStyle.YesNo, "Borrar") = MsgBoxResult.Yes Then
                total.Borrar("derecha", Ltb_derecha.SelectedItems)
                Me.refrescarFormulario()
            End If
        End If
    End Sub



    '----------------------------------------------------------------------------

    'INFORMACION
    '-----------------------------------------------------------------------------
    Private Sub InformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónToolStripMenuItem.Click
        informacio = New informacion()

        If panelEnFoco = 0 Then
            informacio.obtenerParametros(total.obtenerInformacion("izquierda", Ltb_izquierda.SelectedItem.ToString))
            informacio.Show()
        ElseIf panelEnFoco = 1 Then
            informacio.obtenerParametros(total.obtenerInformacion("derecha", Ltb_derecha.SelectedItem.ToString))
            informacio.Show()
        End If
    End Sub
    '-----------------------------------------------------------------------------

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        If panelEnFoco = 0 Then
            If Ltb_izquierda.SelectedIndex = -1 Then
                MsgBox("Selecciona un archivo")
            Else
                total.Copiar("izquierda", Ltb_izquierda.SelectedItems)
            End If
        ElseIf panelEnFoco = 1 Then
            If Ltb_derecha.SelectedIndex = -1 Then
                MsgBox("Selecciona un archivo")
            Else
                total.Copiar("derecha", Ltb_derecha.SelectedItems)
            End If
        End If

    End Sub

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


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        total.Comprimir("izquierda", Ltb_izquierda.SelectedItem.ToString)
    End Sub


    '---------------------------------------------------------------
    'RUTAS
    '---------------------------------------------------------------

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If panelEnFoco = 0 Then
            total.CambiarRutaEntera("izquierda", Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
            Me.refrescarFormulario()
        ElseIf panelEnFoco = 1 Then
            total.CambiarRutaEntera("derecha", Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
            Me.refrescarFormulario()
        End If
    End Sub

    Private Sub ArchivosDeProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivosDeProgramaToolStripMenuItem.Click
        If panelEnFoco = 0 Then
            total.CambiarRutaEntera("izquierda", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86))
            Me.refrescarFormulario()
        ElseIf panelEnFoco = 1 Then
            total.CambiarRutaEntera("derecha", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86))
            Me.refrescarFormulario()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If panelEnFoco = 0 Then
            total.CambiarRutaEntera("izquierda", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
            Me.refrescarFormulario()
        ElseIf panelEnFoco = 1 Then
            total.CambiarRutaEntera("derecha", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
            Me.refrescarFormulario()
        End If
    End Sub

End Class
