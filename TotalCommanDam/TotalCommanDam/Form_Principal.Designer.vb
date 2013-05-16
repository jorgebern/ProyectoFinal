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
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeTotalComanDamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lbl_izquierda = New System.Windows.Forms.Label()
        Me.Ltb_izquierda = New System.Windows.Forms.ListBox()
        Me.Ltb_derecha = New System.Windows.Forms.ListBox()
        Me.Lbl_derecha = New System.Windows.Forms.Label()
        Me.Tmr_Limpiar = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Sts_Bar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.Ts_favoritos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem3, Me.ToolStripMenuItem2})
        Me.Ts_favoritos.Image = CType(resources.GetObject("Ts_favoritos.Image"), System.Drawing.Image)
        Me.Ts_favoritos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ts_favoritos.Name = "Ts_favoritos"
        Me.Ts_favoritos.Size = New System.Drawing.Size(84, 20)
        Me.Ts_favoritos.Text = "Favoritos"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem4.Text = "Descargas"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem3.Text = "Mis documentos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem2.Text = "Escritorio"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(566, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.TabStop = True
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
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
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaciónToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.InformaciónToolStripMenuItem.Text = "Información"
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
        Me.Lbl_izquierda.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_izquierda.Location = New System.Drawing.Point(12, 64)
        Me.Lbl_izquierda.Name = "Lbl_izquierda"
        Me.Lbl_izquierda.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_izquierda.TabIndex = 3
        Me.Lbl_izquierda.Text = "Label1"
        '
        'Ltb_izquierda
        '
        Me.Ltb_izquierda.AllowDrop = True
        Me.Ltb_izquierda.FormattingEnabled = True
        Me.Ltb_izquierda.Location = New System.Drawing.Point(12, 80)
        Me.Ltb_izquierda.Name = "Ltb_izquierda"
        Me.Ltb_izquierda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Ltb_izquierda.Size = New System.Drawing.Size(267, 251)
        Me.Ltb_izquierda.TabIndex = 0
        '
        'Ltb_derecha
        '
        Me.Ltb_derecha.AllowDrop = True
        Me.Ltb_derecha.Location = New System.Drawing.Point(287, 80)
        Me.Ltb_derecha.Name = "Ltb_derecha"
        Me.Ltb_derecha.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Ltb_derecha.Size = New System.Drawing.Size(267, 251)
        Me.Ltb_derecha.TabIndex = 1
        '
        'Lbl_derecha
        '
        Me.Lbl_derecha.AutoSize = True
        Me.Lbl_derecha.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_derecha.Location = New System.Drawing.Point(284, 64)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(566, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Form_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(566, 361)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Lbl_derecha)
        Me.Controls.Add(Me.Ltb_derecha)
        Me.Controls.Add(Me.Ltb_izquierda)
        Me.Controls.Add(Me.Lbl_izquierda)
        Me.Controls.Add(Me.Sts_Bar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(582, 399)
        Me.Name = "Form_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Total Comman-Dam-"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Sts_Bar.ResumeLayout(False)
        Me.Sts_Bar.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ntf_Icon As System.Windows.Forms.NotifyIcon
    Friend WithEvents Sts_Bar As System.Windows.Forms.StatusStrip
    Friend WithEvents Ts_user As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
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
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents InformaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
