﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Mns_menu = New System.Windows.Forms.MenuStrip()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarpetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentoDeTextotxtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefrescarPanelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenombrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarExtensiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónDelPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AzulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TamañoLetraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompararToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComprimirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescomprimirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.OrdenarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlfabéticamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MandarArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavoritosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirFavoritosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarFavoritosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeTotalComanDamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lbl_izquierda = New System.Windows.Forms.Label()
        Me.Ltb_izquierda = New System.Windows.Forms.ListBox()
        Me.Ctm_paneles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenombrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarpetaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentoDeTextotxtToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tb_buscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.Sts_Bar.SuspendLayout()
        Me.Mns_menu.SuspendLayout()
        Me.Ctm_paneles.SuspendLayout()
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
        Me.Sts_Bar.BackColor = System.Drawing.Color.Transparent
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
        Me.Ts_favoritos.Image = CType(resources.GetObject("Ts_favoritos.Image"), System.Drawing.Image)
        Me.Ts_favoritos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ts_favoritos.Name = "Ts_favoritos"
        Me.Ts_favoritos.Size = New System.Drawing.Size(84, 20)
        Me.Ts_favoritos.Text = "Favoritos"
        '
        'Mns_menu
        '
        Me.Mns_menu.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Mns_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mns_menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.Mns_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.FavoritosToolStripMenuItem, Me.AyudaToolStripMenuItem})
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
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu1ToolStripMenuItem, Me.RefrescarPanelesToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ArchivosToolStripMenuItem.Text = "&Archivo"
        '
        'Menu1ToolStripMenuItem
        '
        Me.Menu1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarpetaToolStripMenuItem, Me.DocumentoDeTextotxtToolStripMenuItem})
        Me.Menu1ToolStripMenuItem.Name = "Menu1ToolStripMenuItem"
        Me.Menu1ToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.Menu1ToolStripMenuItem.Text = "Nuevo"
        '
        'CarpetaToolStripMenuItem
        '
        Me.CarpetaToolStripMenuItem.Image = CType(resources.GetObject("CarpetaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CarpetaToolStripMenuItem.Name = "CarpetaToolStripMenuItem"
        Me.CarpetaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CarpetaToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.CarpetaToolStripMenuItem.Text = "Carpeta"
        '
        'DocumentoDeTextotxtToolStripMenuItem
        '
        Me.DocumentoDeTextotxtToolStripMenuItem.Image = CType(resources.GetObject("DocumentoDeTextotxtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DocumentoDeTextotxtToolStripMenuItem.Name = "DocumentoDeTextotxtToolStripMenuItem"
        Me.DocumentoDeTextotxtToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.DocumentoDeTextotxtToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.DocumentoDeTextotxtToolStripMenuItem.Text = "Documento de texto(.txt)"
        '
        'RefrescarPanelesToolStripMenuItem
        '
        Me.RefrescarPanelesToolStripMenuItem.Name = "RefrescarPanelesToolStripMenuItem"
        Me.RefrescarPanelesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefrescarPanelesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RefrescarPanelesToolStripMenuItem.Text = "Refrescar paneles"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.MoverToolStripMenuItem2, Me.ToolStripSeparator4, Me.RenombrarToolStripMenuItem1, Me.CambiarExtensiónToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.BorrarToolStripMenuItem.Text = "Eliminar"
        '
        'MoverToolStripMenuItem2
        '
        Me.MoverToolStripMenuItem2.Name = "MoverToolStripMenuItem2"
        Me.MoverToolStripMenuItem2.Size = New System.Drawing.Size(178, 22)
        Me.MoverToolStripMenuItem2.Text = "Mover"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(175, 6)
        '
        'RenombrarToolStripMenuItem1
        '
        Me.RenombrarToolStripMenuItem1.Name = "RenombrarToolStripMenuItem1"
        Me.RenombrarToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RenombrarToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.RenombrarToolStripMenuItem1.Text = "Renombrar"
        '
        'CambiarExtensiónToolStripMenuItem
        '
        Me.CambiarExtensiónToolStripMenuItem.Name = "CambiarExtensiónToolStripMenuItem"
        Me.CambiarExtensiónToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CambiarExtensiónToolStripMenuItem.Text = "Cambiar Extensión"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaciónToolStripMenuItem, Me.InformaciónDelPCToolStripMenuItem, Me.ToolStripSeparator2, Me.ColorToolStripMenuItem, Me.TamañoLetraToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.VerToolStripMenuItem.Text = "&Ver"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.InformaciónToolStripMenuItem.Text = "Información"
        '
        'InformaciónDelPCToolStripMenuItem
        '
        Me.InformaciónDelPCToolStripMenuItem.Name = "InformaciónDelPCToolStripMenuItem"
        Me.InformaciónDelPCToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.InformaciónDelPCToolStripMenuItem.Text = "Información del PC"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(175, 6)
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AzulToolStripMenuItem, Me.FlowersToolStripMenuItem, Me.GrassToolStripMenuItem, Me.DarkToolStripMenuItem, Me.DarkToolStripMenuItem1})
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'AzulToolStripMenuItem
        '
        Me.AzulToolStripMenuItem.Checked = True
        Me.AzulToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AzulToolStripMenuItem.Name = "AzulToolStripMenuItem"
        Me.AzulToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AzulToolStripMenuItem.Text = "Sky"
        '
        'FlowersToolStripMenuItem
        '
        Me.FlowersToolStripMenuItem.Name = "FlowersToolStripMenuItem"
        Me.FlowersToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.FlowersToolStripMenuItem.Text = "Flowers"
        '
        'GrassToolStripMenuItem
        '
        Me.GrassToolStripMenuItem.Name = "GrassToolStripMenuItem"
        Me.GrassToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.GrassToolStripMenuItem.Text = "Grass"
        '
        'DarkToolStripMenuItem
        '
        Me.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem"
        Me.DarkToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DarkToolStripMenuItem.Text = "Silver"
        '
        'DarkToolStripMenuItem1
        '
        Me.DarkToolStripMenuItem1.Name = "DarkToolStripMenuItem1"
        Me.DarkToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.DarkToolStripMenuItem1.Text = "Dark"
        '
        'TamañoLetraToolStripMenuItem
        '
        Me.TamañoLetraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.GrandeToolStripMenuItem})
        Me.TamañoLetraToolStripMenuItem.Name = "TamañoLetraToolStripMenuItem"
        Me.TamañoLetraToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.TamañoLetraToolStripMenuItem.Text = "Tamaño Letra"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Checked = True
        Me.ToolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem4.Text = "Pequeña"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem5.Text = "Mediana"
        '
        'GrandeToolStripMenuItem
        '
        Me.GrandeToolStripMenuItem.Name = "GrandeToolStripMenuItem"
        Me.GrandeToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.GrandeToolStripMenuItem.Text = "Grande"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompararToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ToolStripSeparator5, Me.ComprimirToolStripMenuItem1, Me.DescomprimirToolStripMenuItem1, Me.ToolStripSeparator9, Me.OrdenarToolStripMenuItem, Me.MandarArchivosToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Herramientas"
        '
        'CompararToolStripMenuItem
        '
        Me.CompararToolStripMenuItem.Name = "CompararToolStripMenuItem"
        Me.CompararToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CompararToolStripMenuItem.Text = "Comparar"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(162, 6)
        '
        'ComprimirToolStripMenuItem1
        '
        Me.ComprimirToolStripMenuItem1.Name = "ComprimirToolStripMenuItem1"
        Me.ComprimirToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ComprimirToolStripMenuItem1.Text = "Comprimir"
        '
        'DescomprimirToolStripMenuItem1
        '
        Me.DescomprimirToolStripMenuItem1.Name = "DescomprimirToolStripMenuItem1"
        Me.DescomprimirToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.DescomprimirToolStripMenuItem1.Text = "Descomprimir"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(162, 6)
        '
        'OrdenarToolStripMenuItem
        '
        Me.OrdenarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FechaToolStripMenuItem, Me.AlfabéticamenteToolStripMenuItem})
        Me.OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        Me.OrdenarToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.OrdenarToolStripMenuItem.Text = "Ordenar por"
        '
        'FechaToolStripMenuItem
        '
        Me.FechaToolStripMenuItem.Name = "FechaToolStripMenuItem"
        Me.FechaToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FechaToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.FechaToolStripMenuItem.Text = "Fecha creación"
        '
        'AlfabéticamenteToolStripMenuItem
        '
        Me.AlfabéticamenteToolStripMenuItem.Name = "AlfabéticamenteToolStripMenuItem"
        Me.AlfabéticamenteToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AlfabéticamenteToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.AlfabéticamenteToolStripMenuItem.Text = "alfabéticamente"
        '
        'MandarArchivosToolStripMenuItem
        '
        Me.MandarArchivosToolStripMenuItem.Name = "MandarArchivosToolStripMenuItem"
        Me.MandarArchivosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MandarArchivosToolStripMenuItem.Text = "Mandar archivos"
        '
        'FavoritosToolStripMenuItem
        '
        Me.FavoritosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirFavoritosToolStripMenuItem, Me.EliminarFavoritosToolStripMenuItem, Me.PreferenciasToolStripMenuItem})
        Me.FavoritosToolStripMenuItem.Name = "FavoritosToolStripMenuItem"
        Me.FavoritosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.FavoritosToolStripMenuItem.Text = "&Favoritos"
        '
        'AñadirFavoritosToolStripMenuItem
        '
        Me.AñadirFavoritosToolStripMenuItem.Name = "AñadirFavoritosToolStripMenuItem"
        Me.AñadirFavoritosToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AñadirFavoritosToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.AñadirFavoritosToolStripMenuItem.Text = "Añadir favoritos"
        '
        'EliminarFavoritosToolStripMenuItem
        '
        Me.EliminarFavoritosToolStripMenuItem.Name = "EliminarFavoritosToolStripMenuItem"
        Me.EliminarFavoritosToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.EliminarFavoritosToolStripMenuItem.Text = "Eliminar favoritos"
        '
        'PreferenciasToolStripMenuItem
        '
        Me.PreferenciasToolStripMenuItem.Name = "PreferenciasToolStripMenuItem"
        Me.PreferenciasToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.PreferenciasToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.PreferenciasToolStripMenuItem.Text = "Preferencias"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeTotalComanDamToolStripMenuItem, Me.TutorialToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'AcercaDeTotalComanDamToolStripMenuItem
        '
        Me.AcercaDeTotalComanDamToolStripMenuItem.Name = "AcercaDeTotalComanDamToolStripMenuItem"
        Me.AcercaDeTotalComanDamToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.AcercaDeTotalComanDamToolStripMenuItem.Text = "Acerca de Total Coman-Dam-"
        '
        'TutorialToolStripMenuItem
        '
        Me.TutorialToolStripMenuItem.Name = "TutorialToolStripMenuItem"
        Me.TutorialToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.TutorialToolStripMenuItem.Text = "Tutorial"
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
        Me.Ltb_izquierda.ContextMenuStrip = Me.Ctm_paneles
        Me.Ltb_izquierda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Ltb_izquierda.FormattingEnabled = True
        Me.Ltb_izquierda.Location = New System.Drawing.Point(12, 80)
        Me.Ltb_izquierda.Name = "Ltb_izquierda"
        Me.Ltb_izquierda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Ltb_izquierda.Size = New System.Drawing.Size(267, 251)
        Me.Ltb_izquierda.TabIndex = 0
        '
        'Ctm_paneles
        '
        Me.Ctm_paneles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem1, Me.MoverToolStripMenuItem, Me.BorrarToolStripMenuItem1, Me.ToolStripSeparator7, Me.RenombrarToolStripMenuItem, Me.NuevoToolStripMenuItem, Me.ImprimirToolStripMenuItem1})
        Me.Ctm_paneles.Name = "ContextMenuStrip1"
        Me.Ctm_paneles.Size = New System.Drawing.Size(134, 142)
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
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(130, 6)
        '
        'RenombrarToolStripMenuItem
        '
        Me.RenombrarToolStripMenuItem.Name = "RenombrarToolStripMenuItem"
        Me.RenombrarToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RenombrarToolStripMenuItem.Text = "Renombrar"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarpetaToolStripMenuItem1, Me.DocumentoDeTextotxtToolStripMenuItem1})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'CarpetaToolStripMenuItem1
        '
        Me.CarpetaToolStripMenuItem1.Name = "CarpetaToolStripMenuItem1"
        Me.CarpetaToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.CarpetaToolStripMenuItem1.Text = "Carpeta"
        '
        'DocumentoDeTextotxtToolStripMenuItem1
        '
        Me.DocumentoDeTextotxtToolStripMenuItem1.Name = "DocumentoDeTextotxtToolStripMenuItem1"
        Me.DocumentoDeTextotxtToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.DocumentoDeTextotxtToolStripMenuItem1.Text = "Documento de texto(.txt)"
        '
        'ImprimirToolStripMenuItem1
        '
        Me.ImprimirToolStripMenuItem1.Name = "ImprimirToolStripMenuItem1"
        Me.ImprimirToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.ImprimirToolStripMenuItem1.Text = "Imprimir"
        '
        'Ltb_derecha
        '
        Me.Ltb_derecha.AllowDrop = True
        Me.Ltb_derecha.BackColor = System.Drawing.SystemColors.Window
        Me.Ltb_derecha.ContextMenuStrip = Me.Ctm_paneles
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.Ts_recargar, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripButton8, Me.ToolStripButton11, Me.ToolStripSeparator6, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator8, Me.Tb_buscar, Me.ToolStripButton7, Me.ToolStripButton9, Me.ToolStripButton10})
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
        Me.ToolStripButton2.Text = "Atras"
        '
        'Ts_recargar
        '
        Me.Ts_recargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Ts_recargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ts_recargar.Image = CType(resources.GetObject("Ts_recargar.Image"), System.Drawing.Image)
        Me.Ts_recargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ts_recargar.Name = "Ts_recargar"
        Me.Ts_recargar.Size = New System.Drawing.Size(23, 22)
        Me.Ts_recargar.Text = "Refrescar"
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
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Añadir a favoritos"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Archivos recientes"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Imprimir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Nueva carpeta"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Nuevo fichero de texto(.txt)"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'Tb_buscar
        '
        Me.Tb_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb_buscar.Name = "Tb_buscar"
        Me.Tb_buscar.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Comparar"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Ordenar"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Mandar archivo por correo"
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 175)
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
        Me.Ctm_paneles.ResumeLayout(False)
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
    Friend WithEvents Lbl_derecha As System.Windows.Forms.Label
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeTotalComanDamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tmr_Limpiar As System.Windows.Forms.Timer
    Friend WithEvents Ts_favoritos As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Ts_recargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents InformaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ctm_paneles As System.Windows.Forms.ContextMenuStrip
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
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CarpetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentoDeTextotxtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarpetaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentoDeTextotxtToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarExtensiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TutorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefrescarPanelesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FavoritosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirFavoritosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarFavoritosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tb_buscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents MoverToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompararToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprimirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescomprimirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DarkToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlfabéticamenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MandarArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel

End Class
