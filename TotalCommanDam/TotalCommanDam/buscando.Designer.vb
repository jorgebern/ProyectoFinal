<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscando
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(buscando))
        Me.Pgb_buscando = New System.Windows.Forms.ProgressBar()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Lbl_buscando = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Pgb_buscando
        '
        Me.Pgb_buscando.Location = New System.Drawing.Point(13, 81)
        Me.Pgb_buscando.Name = "Pgb_buscando"
        Me.Pgb_buscando.Size = New System.Drawing.Size(349, 23)
        Me.Pgb_buscando.TabIndex = 0
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(287, 110)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 1
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Lbl_buscando
        '
        Me.Lbl_buscando.AutoSize = True
        Me.Lbl_buscando.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_buscando.Location = New System.Drawing.Point(124, 9)
        Me.Lbl_buscando.Name = "Lbl_buscando"
        Me.Lbl_buscando.Size = New System.Drawing.Size(109, 26)
        Me.Lbl_buscando.TabIndex = 2
        Me.Lbl_buscando.Text = "Buscando"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'buscando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 145)
        Me.Controls.Add(Me.Lbl_buscando)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Pgb_buscando)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "buscando"
        Me.Text = "buscando"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pgb_buscando As System.Windows.Forms.ProgressBar
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Lbl_buscando As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
