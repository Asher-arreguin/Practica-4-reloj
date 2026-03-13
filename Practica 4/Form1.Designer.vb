<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Horas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Dias = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.picturebox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Configuracion = New System.Windows.Forms.Label()
        CType(Me.picturebox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Horas
        '
        Me.Horas.AutoSize = True
        Me.Horas.BackColor = System.Drawing.Color.White
        Me.Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horas.ForeColor = System.Drawing.Color.Red
        Me.Horas.Location = New System.Drawing.Point(348, 313)
        Me.Horas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(55, 37)
        Me.Horas.TabIndex = 0
        Me.Horas.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(399, 313)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'Minutos
        '
        Me.Minutos.AutoSize = True
        Me.Minutos.BackColor = System.Drawing.Color.White
        Me.Minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutos.ForeColor = System.Drawing.Color.Red
        Me.Minutos.Location = New System.Drawing.Point(434, 313)
        Me.Minutos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(55, 37)
        Me.Minutos.TabIndex = 2
        Me.Minutos.Text = "00"
        '
        'Dias
        '
        Me.Dias.AutoSize = True
        Me.Dias.BackColor = System.Drawing.Color.White
        Me.Dias.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dias.ForeColor = System.Drawing.Color.Red
        Me.Dias.Location = New System.Drawing.Point(138, 313)
        Me.Dias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(85, 29)
        Me.Dias.TabIndex = 3
        Me.Dias.Text = "Lunes"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.Color.White
        Me.Fecha.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.Red
        Me.Fecha.Location = New System.Drawing.Point(142, 342)
        Me.Fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(165, 16)
        Me.Fecha.TabIndex = 4
        Me.Fecha.Text = "09 de marzo del 2026"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'picturebox2
        '
        Me.picturebox2.BackColor = System.Drawing.Color.Transparent
        Me.picturebox2.Image = Global.Practica_4.My.Resources.Resources._5720427
        Me.picturebox2.Location = New System.Drawing.Point(496, 314)
        Me.picturebox2.Name = "picturebox2"
        Me.picturebox2.Size = New System.Drawing.Size(26, 28)
        Me.picturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturebox2.TabIndex = 6
        Me.picturebox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Image = Global.Practica_4.My.Resources.Resources.Sin_título
        Me.PictureBox1.Location = New System.Drawing.Point(-13, -25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(670, 473)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Configuracion)
        Me.Panel1.Location = New System.Drawing.Point(145, 361)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 66)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(4, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Configuracion
        '
        Me.Configuracion.AutoSize = True
        Me.Configuracion.Font = New System.Drawing.Font("MS Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion.ForeColor = System.Drawing.Color.Red
        Me.Configuracion.Location = New System.Drawing.Point(3, 0)
        Me.Configuracion.Name = "Configuracion"
        Me.Configuracion.Size = New System.Drawing.Size(151, 15)
        Me.Configuracion.TabIndex = 0
        Me.Configuracion.Text = "Configuraciones "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(662, 449)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picturebox2)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Dias)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Horas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("MS Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Form1"
        Me.Text = "Reloj digital"
        CType(Me.picturebox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Horas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Minutos As Label
    Friend WithEvents Dias As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents picturebox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Configuracion As Label
End Class
