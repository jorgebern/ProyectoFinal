<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Principal))
        Me.Ntf_Icon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Sts_Bar = New System.Windows.Forms.StatusStrip()
        Me.Ts_user = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Ts_favoritos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivosDeProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mns_menu = New System.Windows.Forms.MenuStrip()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenombrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónDelPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AzulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TamañoLetraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeTotalComanDamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lbl_izquierda = New System.Windows.Forms.Label()
        Me.Ltb_izquierda = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenombrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ltb_derecha = New System.Windows.Forms.ListBox()
        Me.Lbl_derecha = New System.Windows.Forms.Label()
        Me.Tmr_Limpiar = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Ts_recargar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GrandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Sts_Bar.SuspendLayout()
        Me.Mns_menu.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ntf_Icon
        '
        Me.Ntf_Icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Ntf_Icon.Icon = CType(resources.GetObject("Ntf_Icon.Icon"), System.Drawing.Icon)
        Me.Ntf_Icon.Text = "Total Comman-Dam-"
        Me.Ntf_Icon.Visible = True
        '
        'Sts_Bar
        '
        Me.Sts_Bar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Sts_Bar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ts_user, Me.ToolStripProgressBar1, Me.Ts_favoritos})
        Me.Sts_Bar.Location = New System.Drawing.Point(0, 339)
        Me.Sts_Bar.Name = "Sts_Bar"
        Me.Sts_Bar.Size = New System.Drawing.Size(566, 22)
        Me.Sts_Bar.TabIndex = 5
        '
        'Ts_user
        '
        Me.Ts_user.Name = "Ts_user"
        Me.Ts_user.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'Ts_favoritos
        '
        Me.Ts_favoritos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem2, Me.ArchivosDeProgramaToolStripMenuItem, Me.ToolStripSeparator4})
        Me.Ts_favoritos.Image = CType(resources.GetObject("Ts_favoritos.Image"), System.Drawing.Image)
        Me.Ts_favoritos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ts_favoritos.Name = "Ts_favoritos"
        Me.Ts_favoritos.Size = New System.Drawing.Size(84, 20)
        Me.Ts_favoritos.Text = "Favoritos"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(216, 22)
        Me.ToolStripMenuItem3.Text = "Mis documentos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(216, 22)
        Me.ToolStripMenuItem2.Text = "Escritorio"
        '
        'ArchivosDeProgramaToolStripMenuItem
        '
        Me.ArchivosDeProgramaToolStripMenuItem.Name = "ArchivosDeProgramaToolStripMenuItem"
        Me.ArchivosDeProgramaToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ArchivosDeProgramaToolStripMenuItem.Text = "Archivos de programa(x86)"
        '
        'Mns_menu
        '
        Me.Mns_menu.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Mns_menu.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mns_menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.Mns_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.Mns_menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.Mns_menu.Location = New System.Drawing.Point(0, 0)
        Me.Mns_menu.Name = "Mns_menu"
        Me.Mns_menu.Size = New System.Drawing.Size(566, 24)
        Me.Mns_menu.TabIndex = 4
        Me.Mns_menu.TabStop = True
        Me.Mns_menu.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu1ToolStripMenuItem, Me.Menu2ToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'Menu1ToolStripMenuItem
        '
        Me.Menu1ToolStripMenuItem.Name = "Menu1ToolStripMenuItem"
        Me.Menu1ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.Menu1ToolStripMenuItem.Text = "menu1"
        '
        'Menu2ToolStripMenuItem
        '
        Me.Menu2ToolStripMenuItem.Name = "Menu2ToolStripMenuItem"
        Me.Menu2ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.Menu2ToolStripMenuItem.Text = "menu2"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.RenombrarToolStripMenuItem1})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'RenombrarToolStripMenuItem1
        '
        Me.RenombrarToolStripMenuItem1.Name = "RenombrarToolStripMenuItem1"
        Me.RenombrarToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.RenombrarToolStripMenuItem1.Text = "Renombrar"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaciónToolStripMenuItem, Me.InformaciónDelPCToolStripMenuItem, Me.ToolStripSeparator2, Me.ColorToolStripMenuItem, Me.TamañoLetraToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.InformaciónToolStripMenuItem.Text = "Información"
        '
        'InformaciónDelPCToolStripMenuItem
        '
        Me.InformaciónDelPCToolStripMenuItem.Name = "InformaciónDelPCToolStripMenuItem"
        Me.InformaciónDelPCToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.InformaciónDelPCToolStripMenuItem.Text = "Información del PC"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AzulToolStripMenuItem, Me.FlowersToolStripMenuItem, Me.GrassToolStripMenuItem, Me.DarkToolStripMenuItem})
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'AzulToolStripMenuItem
        '
        Me.AzulToolStripMenuItem.Checked = True
        Me.AzulToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AzulToolStripMenuItem.Name = "AzulToolStripMenuItem"
        Me.AzulToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AzulToolStripMenuItem.Text = "Sky"
        '
        'FlowersToolStripMenuItem
        '
        Me.FlowersToolStripMenuItem.Name = "FlowersToolStripMenuItem"
        Me.FlowersToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.FlowersToolStripMenuItem.Text = "Flowers"
        '
        'GrassToolStripMenuItem
        '
        Me.GrassToolStripMenuItem.Name = "GrassToolStripMenuItem"
        Me.GrassToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.GrassToolStripMenuItem.Text = "Grass"
        '
        'DarkToolStripMenuItem
        '
        Me.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem"
        Me.DarkToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.DarkToolStripMenuItem.Text = "Silver"
        '
        'TamañoLetraToolStripMenuItem
        '
        Me.TamañoLetraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.GrandeToolStripMenuItem})
        Me.TamañoLetraToolStripMenuItem.Name = "TamañoLetraToolStripMenuItem"
        Me.TamañoLetraToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.TamañoLetraToolStripMenuItem.Text = "Tamaño Letra"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Checked = True
        Me.ToolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem4.Text = "Pequeña"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem5.Text = "Mediana"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeTotalComanDamToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeTotalComanDamToolStripMenuItem
        '
        Me.AcercaDeTotalComanDamToolStripMenuItem.Name = "AcercaDeTotalComanDamToolStripMenuItem"
        Me.AcercaDeTotalComanDamToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.AcercaDeTotalComanDamToolStripMenuItem.Text = "Acerca de Total Coman-Dam-"
        '
        'Lbl_izquierda
        '
        Me.Lbl_izquierda.AutoSize = True
        Me.Lbl_izquierda.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Lbl_izquierda.Location = New System.Drawing.Point(12, 60)
        Me.Lbl_izquierda.Name = "Lbl_izquierda"
        Me.Lbl_izquierda.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_izquierda.TabIndex = 3
        Me.Lbl_izquierda.Text = "Label1"
        '
        'Ltb_izquierda
        '
        Me.Ltb_izquierda.AllowDrop = True
        Me.Ltb_izquierda.BackColor = System.Drawing.SystemColors.Window
        Me.Ltb_izquierda.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Ltb_izquierda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Ltb_izquierda.FormattingEnabled = True
        Me.Ltb_izquierda.Location = New System.Drawing.Point(12, 80)
        Me.Ltb_izquierda.Name = "Ltb_izquierda"
        Me.Ltb_izquierda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Ltb_izquierda.Size = New System.Drawing.Size(267, 251)
        Me.Ltb_izquierda.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem1, Me.MoverToolStripMenuItem, Me.BorrarToolStripMenuItem1, Me.RenombrarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 92)
        '
        'CopiarToolStripMenuItem1
        '
        Me.CopiarToolStripMenuItem1.Name = "CopiarToolStripMenuItem1"
        Me.CopiarToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.CopiarToolStripMenuItem1.Text = "Copiar"
        '
        'MoverToolStripMenuItem
        '
        Me.MoverToolStripMenuItem.Name = "MoverToolStripMenuItem"
        Me.MoverToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MoverToolStripMenuItem.Text = "Mover"
        '
        'BorrarToolStripMenuItem1
        '
        Me.BorrarToolStripMenuItem1.Name = "BorrarToolStripMenuItem1"
        Me.BorrarToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.BorrarToolStripMenuItem1.Text = "Eliminar"
        '
        'RenombrarToolStripMenuItem
        '
        Me.RenombrarToolStripMenuItem.Name = "RenombrarToolStripMenuItem"
        Me.RenombrarToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RenombrarToolStripMenuItem.Text = "Renombrar"
        '
        'Ltb_derecha
        '
        Me.Ltb_derecha.AllowDrop = True
        Me.Ltb_derecha.BackColor = System.Drawing.SystemColors.Window
        Me.Ltb_derecha.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Ltb_derecha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Ltb_derecha.Location = New System.Drawing.Point(287, 80)
        Me.Ltb_derecha.Name = "Ltb_derecha"
        Me.Ltb_derecha.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Ltb_derecha.Size = New System.Drawing.Size(267, 251)
        Me.Ltb_derecha.TabIndex = 1
        '
        'Lbl_derecha
        '
        Me.Lbl_derecha.AutoSize = True
        Me.Lbl_derecha.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Lbl_derecha.Location = New System.Drawing.Point(284, 60)
        Me.Lbl_derecha.Name = "Lbl_derecha"
        Me.Lbl_derecha.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_derecha.TabIndex = 2
        Me.Lbl_derecha.Text = "Label2"
        '
        'Tmr_Limpiar
        '
        Me.Tmr_Limpiar.Interval = 2000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.Ts_recargar, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(566, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'Ts_recargar
        '
        Me.Ts_recargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Ts_recargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ts_recargar.Image = CType(resources.GetObject("Ts_recargar.Image"), System.Drawing.Image)
        Me.Ts_recargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ts_recargar.Name = "Ts_recargar"
        Me.Ts_recargar.Size = New System.Drawing.Size(23, 22)
        Me.Ts_recargar.Text = "Recargar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Comprimir"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Descomprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'GrandeToolStripMenuItem
        '
        Me.GrandeToolStripMenuItem.Name = "GrandeToolStripMenuItem"
        Me.GrandeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GrandeToolStripMenuItem.Text = "Grande"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(213, 6)
        '
        'Form_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(566, 361)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Lbl_derecha)
        Me.Controls.Add(Me.Ltb_derecha)
        Me.Controls.Add(Me.Ltb_izquierda)
        Me.Controls.Add(Me.Lbl_izquierda)
        Me.Controls.Add(Me.Sts_Bar)
        Me.Controls.Add(Me.Mns_menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Mns_menu
        Me.MinimumSize = New System.Drawing.Size(582, 399)
        Me.Name = "Form_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Total Comman-Dam-"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Sts_Bar.ResumeLayout(False)
        Me.Sts_Bar.PerformLayout()
        Me.Mns_menu.ResumeLayout(False)
        Me.Mns_menu.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ntf_Icon As System.Windows.Forms.NotifyIcon
    Friend WithEvents Sts_Bar As System.Windows.Forms.StatusStrip
    Friend WithEvents Ts_user As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Mns_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lbl_izquierda As System.Windows.Forms.Label
    Friend WithEvents Ltb_izquierda As System.Windows.Forms.ListBox
    Friend WithEvents Ltb_derecha As System.Windows.Forms.ListBox
    Friend WithEvents Menu1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lbl_derecha As System.Windows.Forms.Label
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeTotalComanDamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tmr_Limpiar As System.Windows.Forms.Timer
    Friend WithEvents Ts_favoritos As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Ts_recargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents InformaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AzulToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlowersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenombrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivosDeProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RenombrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaciónDelPCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TamañoLetraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrandeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator

End Class
