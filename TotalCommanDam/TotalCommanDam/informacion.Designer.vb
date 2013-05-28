<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class informacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(informacion))
        Me.Lbl_tipo = New System.Windows.Forms.Label()
        Me.Lbl_extension = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Lbl_ubicacion_1 = New System.Windows.Forms.Label()
        Me.Lbl_tamanyo_1 = New System.Windows.Forms.Label()
        Me.Lbl_ubicacion = New System.Windows.Forms.Label()
        Me.Lbl_tamanyo = New System.Windows.Forms.Label()
        Me.Lbl_creacion_1 = New System.Windows.Forms.Label()
        Me.Lbl_modificacion_1 = New System.Windows.Forms.Label()
        Me.Lbl_creacion = New System.Windows.Forms.Label()
        Me.Lbl_modificado = New System.Windows.Forms.Label()
        Me.Btn_aceptar = New System.Windows.Forms.Button()
        Me.Btn_cancelar = New System.Windows.Forms.Button()
        Me.Btn_aplicar = New System.Windows.Forms.Button()
        Me.Cbx_atributos = New System.Windows.Forms.CheckBox()
        Me.Lbl_atributos_1 = New System.Windows.Forms.Label()
        Me.Lbl_nombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_tipo
        '
        Me.Lbl_tipo.AutoSize = True
        Me.Lbl_tipo.Location = New System.Drawing.Point(13, 76)
        Me.Lbl_tipo.Name = "Lbl_tipo"
        Me.Lbl_tipo.Size = New System.Drawing.Size(87, 13)
        Me.Lbl_tipo.TabIndex = 6
        Me.Lbl_tipo.Text = "Tipo de archivo: "
        '
        'Lbl_extension
        '
        Me.Lbl_extension.AutoSize = True
        Me.Lbl_extension.Location = New System.Drawing.Point(117, 76)
        Me.Lbl_extension.Name = "Lbl_extension"
        Me.Lbl_extension.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_extension.TabIndex = 12
        Me.Lbl_extension.Text = "Label2"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(356, 405)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Enabled = False
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 15
        Me.LineShape4.X2 = 339
        Me.LineShape4.Y1 = 286
        Me.LineShape4.Y2 = 286
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Enabled = False
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 16
        Me.LineShape3.X2 = 340
        Me.LineShape3.Y1 = 193
        Me.LineShape3.Y2 = 193
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 16
        Me.LineShape2.X2 = 340
        Me.LineShape2.Y1 = 114
        Me.LineShape2.Y2 = 114
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 16
        Me.LineShape1.X2 = 340
        Me.LineShape1.Y1 = 54
        Me.LineShape1.Y2 = 54
        '
        'Lbl_ubicacion_1
        '
        Me.Lbl_ubicacion_1.AutoSize = True
        Me.Lbl_ubicacion_1.Location = New System.Drawing.Point(13, 134)
        Me.Lbl_ubicacion_1.Name = "Lbl_ubicacion_1"
        Me.Lbl_ubicacion_1.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_ubicacion_1.TabIndex = 7
        Me.Lbl_ubicacion_1.Text = "Ubicación: "
        '
        'Lbl_tamanyo_1
        '
        Me.Lbl_tamanyo_1.AutoSize = True
        Me.Lbl_tamanyo_1.Location = New System.Drawing.Point(13, 163)
        Me.Lbl_tamanyo_1.Name = "Lbl_tamanyo_1"
        Me.Lbl_tamanyo_1.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_tamanyo_1.TabIndex = 8
        Me.Lbl_tamanyo_1.Text = "Tamaño: "
        '
        'Lbl_ubicacion
        '
        Me.Lbl_ubicacion.AutoSize = True
        Me.Lbl_ubicacion.Location = New System.Drawing.Point(117, 134)
        Me.Lbl_ubicacion.Name = "Lbl_ubicacion"
        Me.Lbl_ubicacion.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ubicacion.TabIndex = 13
        Me.Lbl_ubicacion.Text = "Label5"
        '
        'Lbl_tamanyo
        '
        Me.Lbl_tamanyo.AutoSize = True
        Me.Lbl_tamanyo.Location = New System.Drawing.Point(117, 163)
        Me.Lbl_tamanyo.Name = "Lbl_tamanyo"
        Me.Lbl_tamanyo.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_tamanyo.TabIndex = 14
        Me.Lbl_tamanyo.Text = "Label6"
        '
        'Lbl_creacion_1
        '
        Me.Lbl_creacion_1.AutoSize = True
        Me.Lbl_creacion_1.Location = New System.Drawing.Point(13, 213)
        Me.Lbl_creacion_1.Name = "Lbl_creacion_1"
        Me.Lbl_creacion_1.Size = New System.Drawing.Size(47, 13)
        Me.Lbl_creacion_1.TabIndex = 9
        Me.Lbl_creacion_1.Text = "Creado: "
        '
        'Lbl_modificacion_1
        '
        Me.Lbl_modificacion_1.AutoSize = True
        Me.Lbl_modificacion_1.Location = New System.Drawing.Point(13, 244)
        Me.Lbl_modificacion_1.Name = "Lbl_modificacion_1"
        Me.Lbl_modificacion_1.Size = New System.Drawing.Size(60, 13)
        Me.Lbl_modificacion_1.TabIndex = 10
        Me.Lbl_modificacion_1.Text = "Modicado: "
        '
        'Lbl_creacion
        '
        Me.Lbl_creacion.AutoSize = True
        Me.Lbl_creacion.Location = New System.Drawing.Point(117, 213)
        Me.Lbl_creacion.Name = "Lbl_creacion"
        Me.Lbl_creacion.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_creacion.TabIndex = 15
        Me.Lbl_creacion.Text = "Label9"
        '
        'Lbl_modificado
        '
        Me.Lbl_modificado.AutoSize = True
        Me.Lbl_modificado.Location = New System.Drawing.Point(117, 244)
        Me.Lbl_modificado.Name = "Lbl_modificado"
        Me.Lbl_modificado.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_modificado.TabIndex = 16
        Me.Lbl_modificado.Text = "Label10"
        '
        'Btn_aceptar
        '
        Me.Btn_aceptar.Location = New System.Drawing.Point(117, 370)
        Me.Btn_aceptar.Name = "Btn_aceptar"
        Me.Btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_aceptar.TabIndex = 0
        Me.Btn_aceptar.Text = "Aceptar"
        Me.Btn_aceptar.UseVisualStyleBackColor = True
        '
        'Btn_cancelar
        '
        Me.Btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_cancelar.Location = New System.Drawing.Point(198, 370)
        Me.Btn_cancelar.Name = "Btn_cancelar"
        Me.Btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_cancelar.TabIndex = 1
        Me.Btn_cancelar.Text = "Cancelar"
        Me.Btn_cancelar.UseVisualStyleBackColor = True
        '
        'Btn_aplicar
        '
        Me.Btn_aplicar.Enabled = False
        Me.Btn_aplicar.Location = New System.Drawing.Point(278, 370)
        Me.Btn_aplicar.Name = "Btn_aplicar"
        Me.Btn_aplicar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_aplicar.TabIndex = 2
        Me.Btn_aplicar.Text = "Aplicar"
        Me.Btn_aplicar.UseVisualStyleBackColor = True
        '
        'Cbx_atributos
        '
        Me.Cbx_atributos.AutoSize = True
        Me.Cbx_atributos.Location = New System.Drawing.Point(120, 297)
        Me.Cbx_atributos.Name = "Cbx_atributos"
        Me.Cbx_atributos.Size = New System.Drawing.Size(82, 17)
        Me.Cbx_atributos.TabIndex = 4
        Me.Cbx_atributos.Text = "Sólo lectura"
        Me.Cbx_atributos.UseVisualStyleBackColor = True
        '
        'Lbl_atributos_1
        '
        Me.Lbl_atributos_1.AutoSize = True
        Me.Lbl_atributos_1.Location = New System.Drawing.Point(16, 297)
        Me.Lbl_atributos_1.Name = "Lbl_atributos_1"
        Me.Lbl_atributos_1.Size = New System.Drawing.Size(54, 13)
        Me.Lbl_atributos_1.TabIndex = 11
        Me.Lbl_atributos_1.Text = "Atributos: "
        '
        'Lbl_nombre
        '
        Me.Lbl_nombre.AutoSize = True
        Me.Lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombre.Location = New System.Drawing.Point(120, 13)
        Me.Lbl_nombre.Name = "Lbl_nombre"
        Me.Lbl_nombre.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_nombre.TabIndex = 17
        Me.Lbl_nombre.Text = "Label1"
        '
        'informacion
        '
        Me.AcceptButton = Me.Btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_cancelar
        Me.ClientSize = New System.Drawing.Size(356, 405)
        Me.Controls.Add(Me.Lbl_nombre)
        Me.Controls.Add(Me.Lbl_atributos_1)
        Me.Controls.Add(Me.Cbx_atributos)
        Me.Controls.Add(Me.Btn_aplicar)
        Me.Controls.Add(Me.Btn_cancelar)
        Me.Controls.Add(Me.Btn_aceptar)
        Me.Controls.Add(Me.Lbl_modificado)
        Me.Controls.Add(Me.Lbl_creacion)
        Me.Controls.Add(Me.Lbl_modificacion_1)
        Me.Controls.Add(Me.Lbl_creacion_1)
        Me.Controls.Add(Me.Lbl_tamanyo)
        Me.Controls.Add(Me.Lbl_ubicacion)
        Me.Controls.Add(Me.Lbl_tamanyo_1)
        Me.Controls.Add(Me.Lbl_ubicacion_1)
        Me.Controls.Add(Me.Lbl_extension)
        Me.Controls.Add(Me.Lbl_tipo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(372, 443)
        Me.MinimumSize = New System.Drawing.Size(372, 443)
        Me.Name = "informacion"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Información"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents Lbl_extension As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Lbl_ubicacion_1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_tamanyo_1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_ubicacion As System.Windows.Forms.Label
    Friend WithEvents Lbl_tamanyo As System.Windows.Forms.Label
    Friend WithEvents Lbl_creacion_1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_modificacion_1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_creacion As System.Windows.Forms.Label
    Friend WithEvents Lbl_modificado As System.Windows.Forms.Label
    Friend WithEvents Btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_aplicar As System.Windows.Forms.Button
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Cbx_atributos As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_atributos_1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_nombre As System.Windows.Forms.Label
End Class
