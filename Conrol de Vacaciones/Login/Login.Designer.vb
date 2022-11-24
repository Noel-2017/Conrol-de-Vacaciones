<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Linea = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.Contraseña = New System.Windows.Forms.TextBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button1.Location = New System.Drawing.Point(323, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(412, 4)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Linea
        '
        Me.Linea.BackColor = System.Drawing.Color.Silver
        Me.Linea.Enabled = False
        Me.Linea.FlatAppearance.BorderSize = 0
        Me.Linea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Linea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Linea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Linea.ForeColor = System.Drawing.Color.AliceBlue
        Me.Linea.Location = New System.Drawing.Point(323, 275)
        Me.Linea.Name = "Linea"
        Me.Linea.Size = New System.Drawing.Size(412, 4)
        Me.Linea.TabIndex = 21
        Me.Linea.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(332, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 39)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "RECURSOS HUMANOS"
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.Black
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.LockOpen
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 40
        Me.IconButton2.Location = New System.Drawing.Point(454, 394)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(164, 46)
        Me.IconButton2.TabIndex = 17
        Me.IconButton2.Text = "INGRESAR"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'Usuario
        '
        Me.Usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.ForeColor = System.Drawing.Color.Black
        Me.Usuario.Location = New System.Drawing.Point(323, 252)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(412, 31)
        Me.Usuario.TabIndex = 23
        Me.Usuario.Text = "USUARIO"
        '
        'Contraseña
        '
        Me.Contraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contraseña.ForeColor = System.Drawing.Color.Black
        Me.Contraseña.Location = New System.Drawing.Point(323, 314)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(412, 31)
        Me.Contraseña.TabIndex = 24
        Me.Contraseña.Text = "CONTRASEÑA"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.IconButton1.IconColor = System.Drawing.Color.Red
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.Location = New System.Drawing.Point(1042, 586)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(47, 38)
        Me.IconButton1.TabIndex = 25
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.Black
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 40
        Me.IconButton3.Location = New System.Drawing.Point(838, 533)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(192, 49)
        Me.IconButton3.TabIndex = 26
        Me.IconButton3.Text = "Manual de usuario"
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1090, 626)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Linea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconButton2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Linea As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Usuario As TextBox
    Friend WithEvents Contraseña As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
End Class
