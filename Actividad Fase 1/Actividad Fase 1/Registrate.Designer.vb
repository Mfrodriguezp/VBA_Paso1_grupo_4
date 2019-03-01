<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrate
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
        Me.nombre = New System.Windows.Forms.Label()
        Me.nombres = New System.Windows.Forms.TextBox()
        Me.apellidos = New System.Windows.Forms.TextBox()
        Me.Apellido = New System.Windows.Forms.Label()
        Me.telefonos = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.Label()
        Me.correo = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Rpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.registrar = New System.Windows.Forms.Button()
        Me.atras = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(58, 138)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(52, 13)
        Me.nombre.TabIndex = 1
        Me.nombre.Text = "Nombres:"
        '
        'nombres
        '
        Me.nombres.Location = New System.Drawing.Point(143, 135)
        Me.nombres.Name = "nombres"
        Me.nombres.Size = New System.Drawing.Size(179, 20)
        Me.nombres.TabIndex = 2
        Me.nombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'apellidos
        '
        Me.apellidos.Location = New System.Drawing.Point(143, 176)
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Size = New System.Drawing.Size(179, 20)
        Me.apellidos.TabIndex = 4
        Me.apellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Apellido
        '
        Me.Apellido.AutoSize = True
        Me.Apellido.Location = New System.Drawing.Point(58, 179)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(52, 13)
        Me.Apellido.TabIndex = 3
        Me.Apellido.Text = "Apellidos:"
        '
        'telefonos
        '
        Me.telefonos.Location = New System.Drawing.Point(143, 217)
        Me.telefonos.Name = "telefonos"
        Me.telefonos.Size = New System.Drawing.Size(179, 20)
        Me.telefonos.TabIndex = 6
        Me.telefonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Telefono
        '
        Me.Telefono.AutoSize = True
        Me.Telefono.Location = New System.Drawing.Point(58, 220)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(52, 13)
        Me.Telefono.TabIndex = 5
        Me.Telefono.Text = "Telefono:"
        '
        'correo
        '
        Me.correo.Location = New System.Drawing.Point(143, 257)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(179, 20)
        Me.correo.TabIndex = 8
        Me.correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(58, 260)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(39, 13)
        Me.Email.TabIndex = 7
        Me.Email.Text = "E-Mail:"
        '
        'User
        '
        Me.User.Location = New System.Drawing.Point(143, 295)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(179, 20)
        Me.User.TabIndex = 10
        Me.User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Usuario:"
        '
        'Pass
        '
        Me.Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.Location = New System.Drawing.Point(143, 333)
        Me.Pass.Name = "Pass"
        Me.Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pass.Size = New System.Drawing.Size(179, 26)
        Me.Pass.TabIndex = 12
        Me.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Contraseña:"
        '
        'Rpass
        '
        Me.Rpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rpass.Location = New System.Drawing.Point(143, 369)
        Me.Rpass.Name = "Rpass"
        Me.Rpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Rpass.Size = New System.Drawing.Size(179, 26)
        Me.Rpass.TabIndex = 14
        Me.Rpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(57, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 35)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Repita Contraseña:"
        '
        'registrar
        '
        Me.registrar.Location = New System.Drawing.Point(159, 407)
        Me.registrar.Name = "registrar"
        Me.registrar.Size = New System.Drawing.Size(75, 23)
        Me.registrar.TabIndex = 15
        Me.registrar.Text = "Registrate!"
        Me.registrar.UseVisualStyleBackColor = True
        '
        'atras
        '
        Me.atras.Location = New System.Drawing.Point(288, 12)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(75, 23)
        Me.atras.TabIndex = 16
        Me.atras.Text = "Atras"
        Me.atras.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Actividad_Fase_1.My.Resources.Resources.Registrate
        Me.PictureBox1.Location = New System.Drawing.Point(132, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Registrate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 455)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.registrar)
        Me.Controls.Add(Me.Rpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.correo)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.telefonos)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.apellidos)
        Me.Controls.Add(Me.Apellido)
        Me.Controls.Add(Me.nombres)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Registrate"
        Me.Text = "Registrate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nombre As Label
    Friend WithEvents nombres As TextBox
    Friend WithEvents apellidos As TextBox
    Friend WithEvents Apellido As Label
    Friend WithEvents telefonos As TextBox
    Friend WithEvents Telefono As Label
    Friend WithEvents correo As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents User As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Rpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents registrar As Button
    Friend WithEvents atras As Button
End Class
