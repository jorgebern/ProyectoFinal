Imports System.Threading

''' <summary>
''' Formulario principal que se encarga de manejar la mayoria de la opciones y acciones del proyecto
''' </summary>
''' <remarks></remarks>
Public Class Form_Principal

    Dim total As TotalComander = New TotalComander()
    Dim informacio As informacion
    Dim infoPc As InformacionPc
    Dim formBuscar As buscando
    Dim favoritos As Favoritos
    Dim email As MandarEmail


    Dim background As Thread
    ' Delegate Sub Set_ListBox(ByVal [valor] As Integer)

    '0 = izquierda
    '1 = derecha
    Dim panelEnFoco As Integer
    Dim predeterminada As String

    Dim tutorial As Boolean = False
    Dim tamanyoFuente As Single = 8.25

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

        'hilos
        'Un objeto no puede ser invocado por varios hilos al mismo tiempo
        CheckForIllegalCrossThreadCalls = False


        Dim pref As String() = total.CargarPreferencias

        tutorial = CBool(pref(1))

        If tutorial Then

            Tutorial1.ShowDialog()

            tutorial = False


        End If

        If pref(2) = "0" Then
            pintarVerde()
        ElseIf pref(2) = "1" Then
            pintarAzul()
        ElseIf pref(2) = "2" Then
            pintarRosa()
        ElseIf pref(2) = "3" Then
            pintarPlata()
        ElseIf pref(2) = "4" Then
            pintarOscuro()
        End If

        If pref(3) = "8.25" Then
            TamanyoPequenyo()
        ElseIf pref(3) = "10" Then
            TamanyoMediano()
        ElseIf pref(3) = "12" Then
            TamanyoGrande()
        End If

        predeterminada = pref(4)
        total.CambiarRutaEntera("izquierda", predeterminada)
        total.CambiarRutaEntera("derecha", predeterminada)

        CargarFavoritos()

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

        RefrescarIzquierda()
        refrescarDerecha()
        
        
    End Sub

    ''' <summary>
    ''' Refresca el formulario de la izquierda
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RefrescarIzquierda()
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


        'Labels
        Lbl_izquierda.Text = total.obtenerRuta("izquierda")
    End Sub

    ''' <summary>
    ''' Refresca el formulario de la derecha
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub refrescarDerecha()
        Dim lista As List(Of String)
        Lbl_derecha.Text = total.obtenerRuta("derecha")

        'Derecha
        Ltb_derecha.Items.Clear()

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

        If panelEnFoco = 0 Then
            Ltb_izquierda.Focus()
        Else
            Ltb_derecha.Focus()
        End If


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
            Tmr_Limpiar.Start()
            total.Copiar("derecha", Ltb_derecha.SelectedItems)
            refrescarFormulario()
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

        Lbl_izquierda.BackColor = SystemColors.Highlight

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

            Dim dde1 As DragDropEffects = Ltb_derecha.DoDragDrop(Ltb_derecha.Items(index).ToString, DragDropEffects.All)

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
            Tmr_Limpiar.Start()
            total.Copiar("izquierda", Ltb_izquierda.SelectedItems)
            refrescarFormulario()
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

        Lbl_derecha.BackColor = SystemColors.Highlight


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

    ''' <summary>
    ''' Accion de recargar al ejecutar el boton "Recargar"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ts_recargar_Click(sender As Object, e As EventArgs) Handles Ts_recargar.Click
        Me.refrescarFormulario()
    End Sub

    '--------------------------
    'Aspectos
    '--------------------------
    ''' <summary>
    ''' Carga el Aspecto "Cesped"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GrassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrassToolStripMenuItem.Click

        pintarVerde()
        refrescarFormulario()

    End Sub

    ''' <summary>
    ''' Carga el aspecto "cielo"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AzulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AzulToolStripMenuItem.Click

        pintarAzul()
        refrescarFormulario()
    End Sub

    ''' <summary>
    ''' Carga el aspecto "Flores"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FlowersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlowersToolStripMenuItem.Click

        pintarRosa()
        refrescarFormulario()

    End Sub

    ''' <summary>
    ''' Carga el aspecto "plateado"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click

        pintarPlata()
        refrescarFormulario()
    End Sub

    '----------------------------------------------------
    'Opciones
    '----------------------------------------------------


    'RENOMBRAR
    '---------------------------------------------------------
    ''' <summary>
    ''' Renombra los ficheros seleccionados
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RenombrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenombrarToolStripMenuItem.Click

        Renombrar()

    End Sub
    ''' <summary>
    ''' Renombra los ficheros seleccionados
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RenombrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RenombrarToolStripMenuItem1.Click
        Renombrar()
    End Sub

    ''' <summary>
    ''' Accion de renombrar los ficheros seleccionados
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Renombrar()

        Dim respuesta As String
        Dim mensaje As String = "Usted va a renombrar los siguientes archivos: "

        If panelEnFoco = 0 Then
            If Ltb_izquierda.SelectedIndex = -1 Then
                MsgBox("Seleccione un archivo")
            Else
                For Each elemento As String In Ltb_izquierda.SelectedItems
                    mensaje = mensaje & vbCrLf & vbTab & "- " & elemento
                Next
                respuesta = InputBox(mensaje, "Nuevo nombre: ")

                If respuesta <> "" Then
                    total.RenombrarVarios("izquierda", Ltb_izquierda.SelectedItems, respuesta)
                End If
            End If


        ElseIf panelEnFoco = 1 Then
            If Ltb_derecha.SelectedIndex = -1 Then
                MsgBox("Seleccione un archivo")
            Else
                For Each elemento As String In Ltb_derecha.SelectedItems
                    mensaje = mensaje & vbCrLf & vbTab & "- " & elemento
                Next
                respuesta = InputBox(mensaje, "Nuevo nombre: ")

                If respuesta <> "" Then
                    total.RenombrarVarios("derecha", Ltb_derecha.SelectedItems, respuesta)
                End If
            End If

        End If
        refrescarFormulario()
    End Sub


    '----------------------------------------------------------------------------


    'BORRAR
    '---------------------------------------------------------------------------
    ''' <summary>
    ''' Borra los ficheros seleccionados
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BorrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem1.Click

        background = New Thread(AddressOf Me.Borrar)
        background.Start()
    End Sub

    ''' <summary>
    ''' BORRAR
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click

        background = New Thread(AddressOf Me.Borrar)
        background.Start()
    End Sub

    ''' <summary>
    ''' Accion de borrar los ficheros seleccionados
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Borrar()
        Dim mensaje As String = "¿Está seguro de que desea eliminar el/los archivos?: "


        If panelEnFoco = 0 Then
            If Ltb_izquierda.SelectedIndex = -1 Then
                MsgBox("Seleccione un archivo")
            Else
                For Each elemento As String In Ltb_izquierda.SelectedItems
                    mensaje = mensaje & vbCrLf & vbTab & "- " & elemento
                Next

                If MsgBox(mensaje, MsgBoxStyle.YesNo, "Borrar") = MsgBoxResult.Yes Then
                    total.Borrar("izquierda", Ltb_izquierda.SelectedItems)
                    Me.refrescarFormulario()
                End If
            End If

        ElseIf panelEnFoco = 1 Then
            If Ltb_derecha.SelectedIndex = -1 Then
                MsgBox("Seleccione un archivo")
            Else
                For Each elemento As String In Ltb_derecha.SelectedItems
                    mensaje = mensaje & vbCrLf & vbTab & "- " & elemento
                Next

                If MsgBox(mensaje, MsgBoxStyle.YesNo, "Borrar") = MsgBoxResult.Yes Then
                    total.Borrar("derecha", Ltb_derecha.SelectedItems)
                    Me.refrescarFormulario()
                End If
            End If
        End If

        background.Abort()
    End Sub



    '----------------------------------------------------------------------------

    'INFORMACION
    '---------------------------------------------------------------------------

    ''' <summary>
    ''' Muestra el menu de informacion con la informacion del archivo seleccionado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub InformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónToolStripMenuItem.Click


        informacio = New informacion()

        If panelEnFoco = 0 Then
            If Ltb_izquierda.SelectedIndex = -1 Then
                MsgBox("Seleccione un archivo")
            Else
                informacio.obtenerParametros(total.obtenerInformacion("izquierda", Ltb_izquierda.SelectedItem.ToString), tamanyoFuente)
                informacio.Show()
            End If

        ElseIf panelEnFoco = 1 Then
            If Ltb_derecha.SelectedIndex = -1 Then
                MsgBox("Seleccione un archivo")
            Else
                informacio.obtenerParametros(total.obtenerInformacion("derecha", Ltb_derecha.SelectedItem.ToString), tamanyoFuente)
                informacio.Show()
            End If
        End If



    End Sub
    '-----------------------------------------------------------------------------

    ''' <summary>
    ''' Opcion copiar del menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        background = New Thread(AddressOf Me.Copiar)

        background.Start()


    End Sub

    ''' <summary>
    ''' Opcion salir, cierra el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Opcion Acerca De, Muestra la ventana
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AcercaDeTotalComanDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeTotalComanDamToolStripMenuItem.Click
        acercaDe.ShowDialog()
    End Sub

    ''' <summary>
    ''' Limpia la barra de procesos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Tmr_Limpiar_Tick(sender As Object, e As EventArgs) Handles Tmr_Limpiar.Tick

        ToolStripProgressBar1.Value = 0
        Tmr_Limpiar.Stop()
    End Sub

    ''' <summary>
    ''' Opcion Comprimir
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        background = New Thread(AddressOf Me.Comprimir)

        background.Start()

    End Sub

    ''' <summary>
    ''' Accion de comprimir una carpeta
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Comprimir()
        Dim correcto As Boolean
        Dim respuesta As String


        Dim mensaje As String = "Comprimiendo carpeta: "




            If panelEnFoco = 0 Then
                If Ltb_izquierda.SelectedIndex <> -1 Then
                respuesta = InputBox(mensaje, "Nombre: ")
                If respuesta <> "" Then
                    correcto = total.Comprimir("izquierda", Ltb_izquierda.SelectedItem.ToString, respuesta)
                    refrescarFormulario()
                    If correcto Then
                        Ntf_Icon.BalloonTipTitle = "Comprimir"
                        Ntf_Icon.BalloonTipText = "Carpeta comprimida correctamente"
                        Ntf_Icon.ShowBalloonTip(10)
                    Else
                        Ntf_Icon.BalloonTipTitle = "Comprimir"
                        Ntf_Icon.BalloonTipText = "Algo no funciono bien, vuelva a intentarlo. Recuerda que solo puedes comprimir carpetas"
                        Ntf_Icon.ShowBalloonTip(10)
                    End If
                End If
                Else
                    MsgBox("Seleccione una carpeta")
                End If
            ElseIf panelEnFoco = 1 Then
                If Ltb_derecha.SelectedIndex <> -1 Then
                respuesta = InputBox(mensaje, "Nombre: ")
                If respuesta <> "" Then
                    correcto = total.Comprimir("derecha", Ltb_derecha.SelectedItem.ToString, respuesta)
                    refrescarFormulario()
                    If correcto Then
                        Ntf_Icon.BalloonTipTitle = "Comprimir"
                        Ntf_Icon.BalloonTipText = "Carpeta comprimida correctamente"
                        Ntf_Icon.ShowBalloonTip(10)
                    Else
                        Ntf_Icon.BalloonTipTitle = "Comprimir"
                        Ntf_Icon.BalloonTipText = "Algo no funciono bien, vuelva a intentarlo.Recuerda que solo puedes comprimir carpetas"
                        Ntf_Icon.ShowBalloonTip(10)
                    End If
                End If
                    
                Else
                    MsgBox("Seleccione una carpeta")
                End If
            End If

            

        background.Abort()

    End Sub

    ''' <summary>
    ''' Accion que se ejecuta al presionar el boton, atras
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        If panelEnFoco = 0 Then
            total.RutaAnterior("izquierda")
            Me.refrescarFormulario()
        ElseIf panelEnFoco = 1 Then
            total.RutaAnterior("derecha")
            Me.refrescarFormulario()
        End If
    End Sub

    ''' <summary>
    ''' Descomprime un fichero
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        background = New Thread(AddressOf Me.Descomprimir)

        background.Start()
    End Sub

    ''' <summary>
    ''' Accion de descomprimir una carpeta
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Descomprimir()

        Dim correcto As Boolean = False

        If panelEnFoco = 0 Then
            If Ltb_izquierda.SelectedIndex <> -1 Then
                correcto = total.Descomprimir("izquierda", Ltb_izquierda.SelectedItem.ToString)
                If correcto Then
                    Ntf_Icon.BalloonTipTitle = "Descomprimir"
                    Ntf_Icon.BalloonTipText = "Archivo Descomprimido correctamente"
                    Ntf_Icon.ShowBalloonTip(10)
                Else
                    Ntf_Icon.BalloonTipTitle = "Descomprimir"
                    Ntf_Icon.BalloonTipText = "Algo no funciono bien, vuelva a intentarlo"
                    Ntf_Icon.ShowBalloonTip(10)
                End If

                Me.refrescarFormulario()
                
            Else
                MsgBox("Seleccione un archivo")
            End If

        ElseIf panelEnFoco = 1 Then
            If Ltb_derecha.SelectedIndex <> -1 Then
                correcto = total.Descomprimir("derecha", Ltb_derecha.SelectedItem.ToString)
                If correcto Then
                    Ntf_Icon.BalloonTipTitle = "Descomprimir"
                    Ntf_Icon.BalloonTipText = "Archivo Descomprimido correctamente"
                    Ntf_Icon.ShowBalloonTip(10)
                Else
                    Ntf_Icon.BalloonTipTitle = "Descomprimir"
                    Ntf_Icon.BalloonTipText = "Algo no funciono bien, vuelva a intentarlo"
                    Ntf_Icon.ShowBalloonTip(10)
                End If
                Me.refrescarFormulario()
            Else
                MsgBox("Seleccione un archivo")
            End If
        End If

        


        background.Abort()
    End Sub

    ''' <summary>
    ''' Guarda las preferencias en un fichero
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim color As Integer

        If GrassToolStripMenuItem.Checked Then
            color = 0
        ElseIf AzulToolStripMenuItem.Checked Then
            color = 1
        ElseIf FlowersToolStripMenuItem.Checked Then
            color = 2
        ElseIf DarkToolStripMenuItem.Checked Then
            color = 3
        ElseIf DarkToolStripMenuItem1.Checked Then
            color = 4
        End If

        total.GuardarPreferencias(tutorial, color, tamanyoFuente, predeterminada)
    End Sub

    ''' <summary>
    ''' Pinta el el aspecto Sky
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub pintarAzul()

        GrassToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = True
        FlowersToolStripMenuItem.Checked = False
        DarkToolStripMenuItem.Checked = False

        Me.color_fondo = Color.PowderBlue
        Me.color_Items = Brushes.LightBlue
        Me.color_Selected = Brushes.CadetBlue

        Lbl_izquierda.ForeColor = DefaultForeColor
        Lbl_derecha.ForeColor = DefaultForeColor
        Me.ForeColor = DefaultForeColor

        Ltb_izquierda.BackColor = DefaultBackColor
        Ltb_derecha.BackColor = DefaultBackColor
        Ltb_izquierda.ForeColor = DefaultForeColor
        Ltb_derecha.ForeColor = DefaultForeColor
    End Sub

    ''' <summary>
    ''' Pinta el aspecto grass
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub pintarVerde()

        GrassToolStripMenuItem.Checked = True
        AzulToolStripMenuItem.Checked = False
        FlowersToolStripMenuItem.Checked = False
        DarkToolStripMenuItem.Checked = False
        DarkToolStripMenuItem1.Checked = False

        Me.color_fondo = Color.LimeGreen
        Me.color_Items = Brushes.LightGreen
        Me.color_Selected = Brushes.Chocolate

        Lbl_izquierda.ForeColor = DefaultForeColor
        Lbl_derecha.ForeColor = DefaultForeColor
        Me.ForeColor = DefaultForeColor

        Ltb_izquierda.BackColor = DefaultBackColor
        Ltb_derecha.BackColor = DefaultBackColor
        Ltb_izquierda.ForeColor = DefaultForeColor
        Ltb_derecha.ForeColor = DefaultForeColor
    End Sub

    ''' <summary>
    ''' Pinta el aspecto flowers
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub pintarRosa()
        GrassToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = False
        FlowersToolStripMenuItem.Checked = True
        DarkToolStripMenuItem.Checked = False
        DarkToolStripMenuItem1.Checked = False

        Me.color_fondo = Color.Plum
        Me.color_Items = Brushes.LightPink
        Me.color_Selected = Brushes.Violet

        Lbl_izquierda.ForeColor = DefaultForeColor
        Lbl_derecha.ForeColor = DefaultForeColor
        Me.ForeColor = DefaultForeColor

        Ltb_izquierda.BackColor = DefaultBackColor
        Ltb_derecha.BackColor = DefaultBackColor
        Ltb_izquierda.ForeColor = DefaultForeColor
        Ltb_derecha.ForeColor = DefaultForeColor
    End Sub

    ''' <summary>
    ''' Pinta el aspecto silver
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub pintarPlata()

        GrassToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = False
        FlowersToolStripMenuItem.Checked = False
        DarkToolStripMenuItem.Checked = True
        DarkToolStripMenuItem1.Checked = False

        Me.color_fondo = Color.Silver
        Me.color_Items = Brushes.LightGray
        Me.color_Selected = Brushes.Indigo

        Lbl_izquierda.ForeColor = DefaultForeColor
        Lbl_derecha.ForeColor = DefaultForeColor
        Me.ForeColor = DefaultForeColor

        Ltb_izquierda.BackColor = DefaultBackColor
        Ltb_derecha.BackColor = DefaultBackColor
        Ltb_izquierda.ForeColor = DefaultForeColor
        Ltb_derecha.ForeColor = DefaultForeColor
    End Sub

    Public Sub pintarOscuro()
        GrassToolStripMenuItem.Checked = False
        AzulToolStripMenuItem.Checked = False
        FlowersToolStripMenuItem.Checked = False
        DarkToolStripMenuItem.Checked = False
        DarkToolStripMenuItem1.Checked = True

        Me.color_fondo = Color.Black

        Me.color_Items = Brushes.DimGray
        Me.color_Selected = Brushes.SandyBrown


        Lbl_izquierda.ForeColor = Color.White
        Lbl_derecha.ForeColor = Color.White
        Me.ForeColor = Color.White

        Ltb_izquierda.BackColor = Color.FromArgb(0, 0, 66)
        Ltb_derecha.BackColor = Color.FromArgb(0, 0, 66)
        Ltb_izquierda.ForeColor = Color.White
        Ltb_derecha.ForeColor = Color.White
    End Sub


    ''' <summary>
    ''' Controla el tamaño de la letra pequeña
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        TamanyoPequenyo()
    End Sub

    ''' <summary>
    ''' Actualiza el tamaño de la letra poniendolo pequeño
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub TamanyoPequenyo()
        Lbl_izquierda.Font = New Font("Microsoft Sans Serif", 8.25)
        Ltb_izquierda.Font = New Font("Microsoft Sans Serif", 8.25)
        Ltb_izquierda.ItemHeight = 13

        Lbl_derecha.Font = New Font("Microsoft Sans Serif", 8.25)
        Ltb_derecha.Font = New Font("Microsoft Sans Serif", 8.25)
        Ltb_derecha.ItemHeight = 13

        Mns_menu.Font = New Font("Microsoft Sans Serif", 8.25)

        ToolStripMenuItem4.Checked = True
        ToolStripMenuItem5.Checked = False
        GrandeToolStripMenuItem.Checked = False
        tamanyoFuente = 8.25

    End Sub


    ''' <summary>
    ''' Constrola el tamaño de la letra mediana
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        TamanyoMediano()
    End Sub

    ''' <summary>
    ''' Actualiza el tamaño de la letra poniendo el mediano
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub TamanyoMediano()
        Lbl_izquierda.Font = New Font("Microsoft Sans Serif", 10)
        Ltb_izquierda.Font = New Font("Microsoft Sans Serif", 10)
        Ltb_izquierda.ItemHeight = 15

        Lbl_derecha.Font = New Font("Microsoft Sans Serif", 10)
        Ltb_derecha.Font = New Font("Microsoft Sans Serif", 10)
        Ltb_derecha.ItemHeight = 15

        Mns_menu.Font = New Font("Microsoft Sans Serif", 10)


        ToolStripMenuItem4.Checked = False
        ToolStripMenuItem5.Checked = True
        GrandeToolStripMenuItem.Checked = False
        tamanyoFuente = 10

    End Sub


    ''' <summary>
    ''' Controla el tamaño de la letra grande
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GrandeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrandeToolStripMenuItem.Click
        TamanyoGrande()

    End Sub

    ''' <summary>
    ''' Actualiza el tamaño de la letra poniendolo grande
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub TamanyoGrande()
        Lbl_izquierda.Font = New Font("Microsoft Sans Serif", 12)
        Ltb_izquierda.Font = New Font("Microsoft Sans Serif", 12)
        Ltb_izquierda.ItemHeight = 20

        Lbl_derecha.Font = New Font("Microsoft Sans Serif", 12)
        Ltb_derecha.Font = New Font("Microsoft Sans Serif", 12)
        Ltb_derecha.ItemHeight = 20


        Mns_menu.Font = New Font("Microsoft Sans Serif", 12)

        ToolStripMenuItem4.Checked = False
        ToolStripMenuItem5.Checked = False
        GrandeToolStripMenuItem.Checked = True
        tamanyoFuente = 12
    End Sub

    ''' <summary>
    ''' Recarga la barra de favoritos añadiendo los nuevos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarFavoritos()

        Dim anyadir As Boolean


        Ts_favoritos.DropDownItems.Clear()

        Ts_favoritos.DropDownItems.Add("Mis documentos")
        Ts_favoritos.DropDownItems(Ts_favoritos.DropDownItems.Count - 1).Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Ts_favoritos.DropDownItems.Add("Escritorio")
        Ts_favoritos.DropDownItems(Ts_favoritos.DropDownItems.Count - 1).Tag = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Ts_favoritos.DropDownItems.Add("Archivos de programa(x86)")
        Ts_favoritos.DropDownItems(Ts_favoritos.DropDownItems.Count - 1).Tag = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)


        For Each elemento As String In total.CargarFavoritos(Environment.UserName)
            anyadir = True

            Dim datos As String() = elemento.Split(CChar("Ä"))

            For i As Integer = 0 To Ts_favoritos.DropDownItems.Count - 1
                If datos(1) = Ts_favoritos.DropDownItems(i).Text Then
                    anyadir = False
                End If
            Next

            If anyadir Then
                Ts_favoritos.DropDownItems.Add(datos(1))
                Ts_favoritos.DropDownItems(Ts_favoritos.DropDownItems.Count - 1).Tag = datos(0)

                'If CBool(datos(2)) = True Then
                '    predeterminada = datos(0)

                'End If

            End If
        Next
        marcarPredeterminado()

    End Sub


    ''' <summary>
    ''' Boton para guardar favoritos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

        GuardarFavoritos()


    End Sub

    ''' <summary>
    ''' Selecciona un elemento de la lista favoritos y carga su ruta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ts_favoritos_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Ts_favoritos.DropDownItemClicked

        If panelEnFoco = 0 Then
            total.CambiarRutaEntera("izquierda", e.ClickedItem.Tag.ToString)
        Else
            total.CambiarRutaEntera("derecha", e.ClickedItem.Tag.ToString)
        End If

        refrescarFormulario()

    End Sub

    ''' <summary>
    ''' Boton de crear carpeta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        CrearCarpeta()
    End Sub

    ''' <summary>
    ''' Accion de crear una carpeta
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CrearCarpeta()
        Dim respuesta As String
        Dim mensaje As String = "Nombre: "

        respuesta = InputBox(mensaje, "Nuevo nombre: ", "Nueva carpeta")

        If respuesta <> "" Then
            If panelEnFoco = 0 Then
                total.crearCarpeta("izquierda", respuesta)

            Else
                total.crearCarpeta("derecha", respuesta)
            End If
             refrescarFormulario()
        End If


    End Sub

    ''' <summary>
    ''' Accion de crear un fichero vacio
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CrearFichero()
        Dim respuesta As String
        Dim mensaje As String = "Nombre: "

        respuesta = InputBox(mensaje, "Nuevo nombre: ", "Nuevo fichero.txt")

        If respuesta <> "" Then
            If panelEnFoco = 0 Then
                total.crearfichero("izquierda", respuesta)

            Else
                total.crearfichero("derecha", respuesta)
            End If
            refrescarFormulario()
        End If

    End Sub

    ''' <summary>
    ''' Boton de crear un fichero vacio
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        CrearFichero()
    End Sub

    ''' <summary>
    ''' Boton del menu de crear una carpeta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CarpetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarpetaToolStripMenuItem.Click
        CrearCarpeta()
    End Sub

    ''' <summary>
    ''' Boton del menu de crear un fichero
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DocumentoDeTextotxtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentoDeTextotxtToolStripMenuItem.Click
        CrearFichero()
    End Sub

    ''' <summary>
    ''' Boton del context menu para crear ficheros
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DocumentoDeTextotxtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DocumentoDeTextotxtToolStripMenuItem1.Click
        CrearFichero()
    End Sub

    ''' <summary>
    ''' Boton para obtener la informacion del PC
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub InformaciónDelPCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónDelPCToolStripMenuItem.Click
        infoPc = New InformacionPc()
        infoPc.obtenerParametros(total.obtenerInformacionPc, tamanyoFuente)

        infoPc.Show()

    End Sub

    ''' <summary>
    ''' Boton del menu para copiar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CopiarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem1.Click
        background = New Thread(AddressOf Me.Copiar)

        background.Start()
    End Sub

    ''' <summary>
    ''' Accion de copiar
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Copiar()
        Dim correcto As Boolean

        If panelEnFoco = 0 Then
            If Ltb_izquierda.SelectedIndex = -1 Then
                MsgBox("Selecciona un archivo")
            Else
                correcto = total.Copiar("izquierda", Ltb_izquierda.SelectedItems)
                If correcto Then
                    Ntf_Icon.BalloonTipTitle = "Copiar"
                    Ntf_Icon.BalloonTipText = "Archivo copiado correctamente"
                    Ntf_Icon.ShowBalloonTip(10)
                Else
                    Ntf_Icon.BalloonTipTitle = "Copiar"
                    Ntf_Icon.BalloonTipText = "Algo no funciono bien, vuelva a intentarlo"
                    Ntf_Icon.ShowBalloonTip(10)
                End If
            End If
        ElseIf panelEnFoco = 1 Then
            If Ltb_derecha.SelectedIndex = -1 Then
                MsgBox("Selecciona un archivo")
            Else
                correcto = total.Copiar("derecha", Ltb_derecha.SelectedItems)
                If correcto Then
                    Ntf_Icon.BalloonTipTitle = "Copiar"
                    Ntf_Icon.BalloonTipText = "Archivo copiado correctamente"
                    Ntf_Icon.ShowBalloonTip(10)
                Else
                    Ntf_Icon.BalloonTipTitle = "Copiar"
                    Ntf_Icon.BalloonTipText = "Algo no funciono bien, vuelva a intentarlo"
                    Ntf_Icon.ShowBalloonTip(10)
                End If
            End If
        End If

       
        refrescarFormulario()
        background.Abort()
    End Sub

    ''' <summary>
    ''' Mueve un archivo a fichero a una nueva posicion
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub mover()
        Dim correcto As Boolean
        If panelEnFoco = 0 Then
            If Ltb_izquierda.SelectedIndex = -1 Then
                MsgBox("Selecciona un archivo")
            Else
                correcto = total.mover("izquierda", Ltb_izquierda.SelectedItems)

                If correcto Then
                    Ntf_Icon.BalloonTipTitle = "Mover"
                    Ntf_Icon.BalloonTipText = "Archivo Movido correctamente"
                    Ntf_Icon.ShowBalloonTip(10)
                Else
                    Ntf_Icon.BalloonTipTitle = "Mover"
                    Ntf_Icon.BalloonTipIcon = ToolTipIcon.Warning
                    Ntf_Icon.BalloonTipText = "Algo no funciono bien, vuelva a intentarlo"
                    Ntf_Icon.ShowBalloonTip(10)
                End If
            End If
        ElseIf panelEnFoco = 1 Then
            If Ltb_derecha.SelectedIndex = -1 Then
                MsgBox("Selecciona un archivo")
            Else
                correcto = total.mover("derecha", Ltb_derecha.SelectedItems)
                If correcto Then
                    Ntf_Icon.BalloonTipTitle = "Mover"
                    Ntf_Icon.BalloonTipText = "Archivo Movido correctamente"
                    Ntf_Icon.ShowBalloonTip(10)
                Else
                    Ntf_Icon.BalloonTipTitle = "Mover"
                    Ntf_Icon.BalloonTipIcon = ToolTipIcon.Warning
                    Ntf_Icon.BalloonTipText = "Algo no funciono bien, vuelva a intentarlo"
                    Ntf_Icon.ShowBalloonTip(10)
                End If
            End If
        End If

       

        refrescarFormulario()
        background.Abort()
    End Sub


    ''' <summary>
    ''' boton de cambiar extension
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CambiarExtensiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarExtensiónToolStripMenuItem.Click

        Dim respuesta As String
        Dim mensaje As String = "Extensión: "


        If panelEnFoco = 0 And Ltb_izquierda.SelectedIndex <> -1 Then

            respuesta = InputBox(mensaje, "Nueva extensión: ", ".txt")

            If respuesta <> "" Then
                total.cambiarExtension("izquierda", Ltb_izquierda.SelectedItem.ToString, respuesta)
            End If

        ElseIf panelEnFoco = 1 And Ltb_derecha.SelectedIndex <> -1 Then
            respuesta = InputBox(mensaje, "Nueva extensión: ", ".txt")
            If respuesta <> "" Then
                total.cambiarExtension("derecha", Ltb_derecha.SelectedItem.ToString, respuesta)
            End If

        Else
            MsgBox("Seleccione un archivo")
        End If
        refrescarFormulario()

    End Sub

    ''' <summary>
    ''' Boton para mostrar el tutorial
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TutorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorialToolStripMenuItem.Click
        Tutorial1.ShowDialog()
    End Sub

    ''' <summary>
    ''' Menu para refrescar los paneles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RefrescarPanelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefrescarPanelesToolStripMenuItem.Click
        refrescarFormulario()
    End Sub

    ''' <summary>
    ''' Menu para añadir a favoritos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AñadirFavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirFavoritosToolStripMenuItem.Click
        GuardarFavoritos()
    End Sub

    ''' <summary>
    ''' Accion de guardar en favoritos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GuardarFavoritos()
        Dim respuesta As String
        Dim mensaje As String = "Nombre: "

        respuesta = InputBox(mensaje, "Nuevo nombre: ")

        If panelEnFoco = 0 Then
            total.GuardarFavoritos(Environment.UserName, "izquierda", respuesta)

        Else
            total.GuardarFavoritos(Environment.UserName, "derecha", respuesta)
        End If
        CargarFavoritos()

    End Sub

    ''' <summary>
    ''' opcion del menu contextual para crear carpetas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CarpetaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CarpetaToolStripMenuItem1.Click
        CrearCarpeta()
    End Sub

    ''' <summary>
    ''' Elimina los favoritos de la lista y los vuelve a cargar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EliminarFavoritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarFavoritosToolStripMenuItem.Click
        If panelEnFoco = 0 Then
            total.EliminarFavorito("izquierda")
        ElseIf panelEnFoco = 1 Then
            total.EliminarFavorito("derecha")
        End If

        CargarFavoritos()
    End Sub

    ''' <summary>
    ''' Boton mover del menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MoverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoverToolStripMenuItem.Click
        background = New Thread(AddressOf Me.mover)

        background.Start()
    End Sub

    ''' <summary>
    ''' Boton mover del menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MoverToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MoverToolStripMenuItem2.Click
        background = New Thread(AddressOf Me.mover)

        background.Start()
    End Sub


    ''' <summary>
    ''' Navegacion mediante teclas en izquierda
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_izquierda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ltb_izquierda.KeyPress
        If e.KeyChar = CChar(vbCrLf) Then

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
        End If

        If e.KeyChar = vbBack Then
            total.RutaAnterior("izquierda")
            refrescarFormulario()
        End If

    End Sub

    ''' <summary>
    ''' Navegacion mediante teclas derecha
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ltb_derecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ltb_derecha.KeyPress
        If e.KeyChar = CChar(vbCrLf) Then

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
        End If


        If e.KeyChar = vbBack Then
            total.RutaAnterior("derecha")
            refrescarFormulario()
        End If


    End Sub

    ''' <summary>
    ''' Busca un archivo con el nombre indicado en cada pulso del Textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Tb_buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb_buscar.KeyPress

        If e.KeyChar = CChar(vbBack) Then
            If Tb_buscar.Text.Length = 3 Then
                If panelEnFoco = 0 Then
                    RefrescarIzquierda()
                    Tb_buscar.Focus()
                ElseIf panelEnFoco = 1 Then
                    refrescarDerecha()
                    Tb_buscar.Focus()
                End If
                
            End If
        End If


    End Sub

    ''' <summary>
    ''' Busca un archivo con el nombre indicado en cada pulso del Textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Tb_buscar_KeyUp(sender As Object, e As KeyEventArgs) Handles Tb_buscar.KeyUp
        If Tb_buscar.Text.Length >= 3 Then
            If panelEnFoco = 0 Then
                Ltb_izquierda.Items.Clear()

                For Each elemento As String In total.filtrar("izquierda", Tb_buscar.Text)
                    Ltb_izquierda.Items.Add(elemento)
                Next
            ElseIf panelEnFoco = 1 Then
                Ltb_derecha.Items.Clear()

                For Each elemento As String In total.filtrar("derecha", Tb_buscar.Text)
                    Ltb_derecha.Items.Add(elemento)
                Next

            End If
            
        End If
    End Sub

    ''' <summary>
    ''' Boton de comparar 2 paneles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click

        Comparar()

    End Sub

    ''' <summary>
    ''' Accion de comparar 2 paneles
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Comparar()
        If panelEnFoco = 0 Then
            Ltb_izquierda.Items.Clear()

            For Each elemento As String In total.comparar("izquierda")
                Ltb_izquierda.Items.Add(elemento)
            Next
        ElseIf panelEnFoco = 1 Then
            Ltb_derecha.Items.Clear()

            For Each elemento As String In total.comparar("derecha")
                Ltb_derecha.Items.Add(elemento)
            Next
        End If
    End Sub


    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click

        If panelEnFoco = 0 Then
            total.CambiarRutaEntera("izquierda", total.ArchivosRecientes("izquierda"))
        ElseIf panelEnFoco = 1 Then
            total.CambiarRutaEntera("derecha", total.ArchivosRecientes("derecha"))

        End If

        refrescarFormulario()

    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        OrdenarAlfabeticamente()
    End Sub

    ''' <summary>
    ''' Boton de comparar 2 paneles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CompararToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompararToolStripMenuItem.Click
        Comparar()
    End Sub

    ''' <summary>
    ''' Ejecuta la compresion en un hilo de fondo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ComprimirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprimirToolStripMenuItem1.Click
        background = New Thread(AddressOf Me.Comprimir)

        background.Start()
    End Sub

    ''' <summary>
    ''' ejecuta la descompresion en un hilo de fondo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DescomprimirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescomprimirToolStripMenuItem1.Click
        background = New Thread(AddressOf Me.Descomprimir)

        background.Start()
    End Sub

    ''' <summary>
    ''' Pinta el color oscuro 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DarkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem1.Click
        pintarOscuro()
        refrescarFormulario()
    End Sub

    ''' <summary>
    ''' Ordena alfabeticamente el panel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AlfabéticamenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlfabéticamenteToolStripMenuItem.Click
        OrdenarAlfabeticamente()
    End Sub

    ''' <summary>
    ''' Accion de ordenar el panel seleccionado
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub OrdenarAlfabeticamente()
        Dim archivos As List(Of String) = New List(Of String)
        If panelEnFoco = 0 Then

            For Each elemento As String In Ltb_izquierda.Items
                archivos.Add(elemento)
            Next

            Ltb_izquierda.Items.Clear()
            For Each elemento As String In total.Ordenar("izquierda", archivos.ToArray)
                Ltb_izquierda.Items.Add(elemento)
            Next
        ElseIf panelEnFoco = 1 Then

            For Each elemento As String In Ltb_derecha.Items
                archivos.Add(elemento)
            Next

            Ltb_derecha.Items.Clear()
            For Each elemento As String In total.Ordenar("derecha", archivos.ToArray)
                Ltb_derecha.Items.Add(elemento)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Ordena el panel seleccionado segun la fecha de creacion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechaToolStripMenuItem.Click
        Dim archivos As List(Of String) = New List(Of String)
        If panelEnFoco = 0 Then
            For Each elemento As String In Ltb_izquierda.Items
                archivos.Add(elemento)
            Next

            Ltb_izquierda.Items.Clear()
            For Each elemento As String In total.OrdenarPorFecha("izquierda", archivos.ToArray)
                Ltb_izquierda.Items.Add(elemento)
            Next
        ElseIf panelEnFoco = 1 Then

            For Each elemento As String In Ltb_derecha.Items
                archivos.Add(elemento)
            Next

            Ltb_derecha.Items.Clear()
            For Each elemento As String In total.OrdenarPorFecha("derecha", archivos.ToArray)
                Ltb_derecha.Items.Add(elemento)
            Next

        End If
        
    End Sub

    ''' <summary>
    ''' Ejecuta el formulario de buscar y otro hilo para ejecutar la busqueda
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click

        formBuscar = New buscando()
        formBuscar.Show()

        background = New Thread(AddressOf Me.buscar)
        background.Start()
    End Sub

    ''' <summary>
    ''' Accion de buscar que se ejecuta en segundo plano
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub buscar()
        Dim respuesta As String
        Dim mensaje As String = "Nombre: "

        respuesta = InputBox(mensaje, "Archivo a buscar: ")

        If panelEnFoco = 0 Then

            Ltb_izquierda.Items.Clear()
            For Each elemento As String In total.buscar("izquierda", respuesta)
                Ltb_izquierda.Items.Add(elemento)
            Next
            For i As Integer = 0 To 100
                formBuscar.LlenarBarra(1)
            Next
        Else
            ' total.GuardarFavoritos(Environment.UserName, "derecha", respuesta)
        End If
        background.Abort()
    End Sub

    ''' <summary>
    ''' Muestra el formulario de favoritos para administrarlos con mejor facilidad
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PreferenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferenciasToolStripMenuItem.Click

        favoritos = New Favoritos()
        Dim lista As List(Of String) = New List(Of String)

        For i As Integer = 0 To Ts_favoritos.DropDownItems.Count - 1
            If Ts_favoritos.DropDownItems(i).Tag.ToString = predeterminada Then
                lista.Add(Ts_favoritos.DropDownItems(i).Text & "Ä" & Ts_favoritos.DropDownItems(i).Tag.ToString & "Ä" & True)
            Else
                lista.Add(Ts_favoritos.DropDownItems(i).Text & "Ä" & Ts_favoritos.DropDownItems(i).Tag.ToString & "Ä" & False)
            End If

        Next

        favoritos.FavoritosProp = lista.ToArray
        favoritos.Predeterminado = predeterminada
        favoritos.ShowDialog()
        If favoritos.Aceptar Then
            total.GuardarFavoritos(favoritos.FavoritosProp)
            predeterminada = favoritos.Predeterminado

            CargarFavoritos()
        End If
   
    End Sub

    ''' <summary>
    ''' Marca la ruta predeterminada de rojo en el Ts_favoritos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub marcarPredeterminado()

        For i As Integer = 0 To Ts_favoritos.DropDownItems.Count - 1
            If Ts_favoritos.DropDownItems(i).Tag.ToString = predeterminada Then
                Ts_favoritos.DropDownItems(i).ForeColor = Color.Red
            End If
        Next

    End Sub

    ''' <summary>
    ''' Boton mandar un Email de la barra de herramientas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        background = New Thread(AddressOf Me.MandarEmail)
        background.Start()

    End Sub

    ''' <summary>
    ''' boton de mandar email de la barra de edicion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MandarArchivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MandarArchivosToolStripMenuItem.Click
        background = New Thread(AddressOf Me.MandarEmail)
        background.Start()
    End Sub

    ''' <summary>
    ''' Accion de mandar un email
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub MandarEmail()

        Dim err As Integer = 0
        email = New MandarEmail()

        Dim ficheros As List(Of String) = New List(Of String)

        If panelEnFoco = 0 Then
            If Ltb_izquierda.SelectedItems.Count <> 0 Then
                For Each elemento As String In Ltb_izquierda.SelectedItems
                    ficheros.Add(elemento)
                Next
            Else
                Return
            End If
           
        ElseIf panelEnFoco = 1 Then
            If Ltb_derecha.SelectedItems.Count <> 0 Then
                For Each elemento As String In Ltb_derecha.SelectedItems
                    ficheros.Add(elemento)
                Next
            Else
                Return
            End If

        End If


            email.ShowDialog()
        If email.Aceptar Then
            If panelEnFoco = 0 Then
                err = total.mandarEmail("izquierda", email.Email, email.Contrasenya, email.Nombre, email.Destinatario, email.Asunto, email.Mensaje, ficheros.ToArray)
            ElseIf panelEnFoco = 1 Then
                err = total.mandarEmail("derecha", email.Email, email.Contrasenya, email.Nombre, email.Destinatario, email.Asunto, email.Mensaje, ficheros.ToArray)
            End If

            If err = 1 Then
                MsgBox("Usuario o contraseña incorrectos")
            ElseIf err = 2 Then
                MsgBox("Error, el tamaño del fichero excede el permitido. Maximo 25Mb")
            ElseIf err = 0 Then
                Ntf_Icon.BalloonTipIcon = ToolTipIcon.Info
                Ntf_Icon.BalloonTipTitle = "Email"
                Ntf_Icon.BalloonTipText = "Archivo enviado correctamente"
                Ntf_Icon.ShowBalloonTip(10)
            End If

        End If
        background.Abort()
    End Sub

    ''' <summary>
    ''' Boton imprimir de la barra de herramientas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        background = New Thread(AddressOf Me.imprimir)
        background.Start()
    End Sub

    ''' <summary>
    ''' Accion de imprimir
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub imprimir()

        Dim archivos As List(Of String) = New List(Of String)

        If panelEnFoco = 0 And Ltb_izquierda.SelectedIndex <> -1 Then

            For Each elemento As String In Ltb_izquierda.SelectedItems
                archivos.Add(elemento)
            Next


            total.imprimir("izquierda", archivos.ToArray)
        ElseIf panelEnFoco = 1 And Ltb_derecha.SelectedIndex <> -1 Then

            For Each elemento As String In Ltb_derecha.SelectedItems
                archivos.Add(elemento)
            Next


            total.imprimir("derecha", archivos.ToArray)
        Else
            MsgBox("Seleccione un archivo")
        End If

        background.Abort()
    End Sub

    ''' <summary>
    ''' Boton de imprimir del menu Archivos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        background = New Thread(AddressOf Me.imprimir)
        background.Start()
    End Sub

    ''' <summary>
    ''' Boton de imprimir del menu contextual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ImprimirToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem1.Click
        background = New Thread(AddressOf Me.imprimir)
        background.Start()
    End Sub

End Class
