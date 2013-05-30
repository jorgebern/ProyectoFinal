<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MandarEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MandarEmail))
        Me.Txb_Email = New System.Windows.Forms.TextBox()
        Me.Txb_Contrasenya = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Txb_destinatario = New System.Windows.Forms.TextBox()
        Me.Txb_Asunto = New System.Windows.Forms.TextBox()
        Me.Txb_Mensaje = New System.Windows.Forms.TextBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txb_Email
        '
        Me.Txb_Email.Location = New System.Drawing.Point(115, 13)
        Me.Txb_Email.MaxLength = 40
        Me.Txb_Email.Name = "Txb_Email"
        Me.Txb_Email.Size = New System.Drawing.Size(219, 20)
        Me.Txb_Email.TabIndex = 0
        '
        'Txb_Contrasenya
        '
        Me.Txb_Contrasenya.Location = New System.Drawing.Point(115, 40)
        Me.Txb_Contrasenya.MaxLength = 20
        Me.Txb_Contrasenya.Name = "Txb_Contrasenya"
        Me.Txb_Contrasenya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txb_Contrasenya.Size = New System.Drawing.Size(219, 20)
        Me.Txb_Contrasenya.TabIndex = 1
        Me.Txb_Contrasenya.UseSystemPasswordChar = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(346, 397)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 11
        Me.LineShape1.X2 = 332
        Me.LineShape1.Y1 = 80
        Me.LineShape1.Y2 = 80
        '
        'Txb_destinatario
        '
        Me.Txb_destinatario.Location = New System.Drawing.Point(115, 103)
        Me.Txb_destinatario.MaxLength = 40
        Me.Txb_destinatario.Name = "Txb_destinatario"
        Me.Txb_destinatario.Size = New System.Drawing.Size(219, 20)
        Me.Txb_destinatario.TabIndex = 3
        '
        'Txb_Asunto
        '
        Me.Txb_Asunto.Location = New System.Drawing.Point(11, 153)
        Me.Txb_Asunto.MaxLength = 70
        Me.Txb_Asunto.Name = "Txb_Asunto"
        Me.Txb_Asunto.Size = New System.Drawing.Size(322, 20)
        Me.Txb_Asunto.TabIndex = 4
        '
        'Txb_Mensaje
        '
        Me.Txb_Mensaje.Location = New System.Drawing.Point(3, 196)
        Me.Txb_Mensaje.MaxLength = 700
        Me.Txb_Mensaje.Multiline = True
        Me.Txb_Mensaje.Name = "Txb_Mensaje"
        Me.Txb_Mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txb_Mensaje.Size = New System.Drawing.Size(338, 169)
        Me.Txb_Mensaje.TabIndex = 5
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancelar.Location = New System.Drawing.Point(268, 371)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 6
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.Location = New System.Drawing.Point(187, 371)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Aceptar.TabIndex = 7
        Me.Btn_Aceptar.Text = "Enviar"
        Me.Btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Destinatario: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Asunto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mensaje: "
        '
        'MandarEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(346, 397)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Aceptar)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Txb_Mensaje)
        Me.Controls.Add(Me.Txb_Asunto)
        Me.Controls.Add(Me.Txb_destinatario)
        Me.Controls.Add(Me.Txb_Contrasenya)
        Me.Controls.Add(Me.Txb_Email)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MandarEmail"
        Me.Text = "MandarEmail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txb_Email As System.Windows.Forms.TextBox
    Friend WithEvents Txb_Contrasenya As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Txb_destinatario As System.Windows.Forms.TextBox
    Friend WithEvents Txb_Asunto As System.Windows.Forms.TextBox
    Friend WithEvents Txb_Mensaje As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
