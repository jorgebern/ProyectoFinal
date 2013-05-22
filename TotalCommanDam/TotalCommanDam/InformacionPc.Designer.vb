<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformacionPc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformacionPc))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_userName = New System.Windows.Forms.Label()
        Me.Lbl_MachineName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_SoVersion = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_procesadores = New System.Windows.Forms.Label()
        Me.Lbl_servicePack = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_ticks = New System.Windows.Forms.Label()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbl_hora = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lbl_ram = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Lbl_userName
        '
        Me.Lbl_userName.AutoSize = True
        Me.Lbl_userName.Location = New System.Drawing.Point(242, 13)
        Me.Lbl_userName.Name = "Lbl_userName"
        Me.Lbl_userName.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_userName.TabIndex = 1
        Me.Lbl_userName.Text = "Label1"
        '
        'Lbl_MachineName
        '
        Me.Lbl_MachineName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_MachineName.AutoSize = True
        Me.Lbl_MachineName.Location = New System.Drawing.Point(242, 54)
        Me.Lbl_MachineName.Name = "Lbl_MachineName"
        Me.Lbl_MachineName.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_MachineName.TabIndex = 2
        Me.Lbl_MachineName.Text = "Label1"
        Me.Lbl_MachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Máquina: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Versión del SO: "
        '
        'Lbl_SoVersion
        '
        Me.Lbl_SoVersion.AutoSize = True
        Me.Lbl_SoVersion.Location = New System.Drawing.Point(161, 183)
        Me.Lbl_SoVersion.Name = "Lbl_SoVersion"
        Me.Lbl_SoVersion.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_SoVersion.TabIndex = 6
        Me.Lbl_SoVersion.Text = "Label4"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(374, 417)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 10
        Me.LineShape1.X2 = 353
        Me.LineShape1.Y1 = 253
        Me.LineShape1.Y2 = 253
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Número de procesadores: "
        '
        'Lbl_procesadores
        '
        Me.Lbl_procesadores.AutoSize = True
        Me.Lbl_procesadores.Location = New System.Drawing.Point(161, 272)
        Me.Lbl_procesadores.Name = "Lbl_procesadores"
        Me.Lbl_procesadores.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_procesadores.TabIndex = 9
        Me.Lbl_procesadores.Text = "Label5"
        '
        'Lbl_servicePack
        '
        Me.Lbl_servicePack.AutoSize = True
        Me.Lbl_servicePack.Location = New System.Drawing.Point(161, 213)
        Me.Lbl_servicePack.Name = "Lbl_servicePack"
        Me.Lbl_servicePack.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_servicePack.TabIndex = 10
        Me.Lbl_servicePack.Text = "Label5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Número de Ticks: "
        '
        'Lbl_ticks
        '
        Me.Lbl_ticks.AutoSize = True
        Me.Lbl_ticks.Location = New System.Drawing.Point(161, 309)
        Me.Lbl_ticks.Name = "Lbl_ticks"
        Me.Lbl_ticks.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ticks.TabIndex = 12
        Me.Lbl_ticks.Text = "Label6"
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.Location = New System.Drawing.Point(198, 382)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Aceptar.TabIndex = 13
        Me.Btn_Aceptar.Text = "Aceptar"
        Me.Btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(279, 382)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 14
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(161, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Hora local: "
        '
        'Lbl_hora
        '
        Me.Lbl_hora.AutoSize = True
        Me.Lbl_hora.Location = New System.Drawing.Point(242, 97)
        Me.Lbl_hora.Name = "Lbl_hora"
        Me.Lbl_hora.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_hora.TabIndex = 16
        Me.Lbl_hora.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Memoria RAM:"
        '
        'Lbl_ram
        '
        Me.Lbl_ram.AutoSize = True
        Me.Lbl_ram.Location = New System.Drawing.Point(161, 342)
        Me.Lbl_ram.Name = "Lbl_ram"
        Me.Lbl_ram.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ram.TabIndex = 18
        Me.Lbl_ram.Text = "Label8"
        '
        'InformacionPc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 417)
        Me.Controls.Add(Me.Lbl_ram)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Lbl_hora)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Aceptar)
        Me.Controls.Add(Me.Lbl_ticks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Lbl_servicePack)
        Me.Controls.Add(Me.Lbl_procesadores)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbl_SoVersion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_MachineName)
        Me.Controls.Add(Me.Lbl_userName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InformacionPc"
        Me.Text = "InformacionPc"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_userName As System.Windows.Forms.Label
    Friend WithEvents Lbl_MachineName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_SoVersion As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_procesadores As System.Windows.Forms.Label
    Friend WithEvents Lbl_servicePack As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_ticks As System.Windows.Forms.Label
    Friend WithEvents Btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lbl_hora As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Lbl_ram As System.Windows.Forms.Label
End Class
