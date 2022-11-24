<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Principal))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnAusencias = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnReportes = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnVacaciones = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnRegistrarPersonal = New FontAwesome.Sharp.IconButton()
        Me.Btnmenu = New System.Windows.Forms.PictureBox()
        Me.Tmocultarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.Tmmostrarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.Btncerrar = New FontAwesome.Sharp.IconButton()
        Me.Btnmaximizar = New FontAwesome.Sharp.IconButton()
        Me.Btnminimizar = New FontAwesome.Sharp.IconButton()
        Me.Btnrestaurar = New FontAwesome.Sharp.IconButton()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        CType(Me.Btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconButton2)
        Me.PanelMenu.Controls.Add(Me.Panel6)
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Controls.Add(Me.Panel5)
        Me.PanelMenu.Controls.Add(Me.BtnAusencias)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.BtnReportes)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.BtnVacaciones)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.BtnRegistrarPersonal)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.Btnmenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.ForeColor = System.Drawing.Color.Transparent
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(280, 946)
        Me.PanelMenu.TabIndex = 2
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.IconButton2.IconColor = System.Drawing.Color.DarkRed
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(2, 891)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(60, 52)
        Me.IconButton2.TabIndex = 0
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(280, 72)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1198, 41)
        Me.Panel6.TabIndex = 6
        '
        'IconButton1
        '
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton1.IconSize = 50
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(9, 376)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(271, 50)
        Me.IconButton1.TabIndex = 10
        Me.IconButton1.Text = "Usuarios"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(2, 322)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(7, 50)
        Me.Panel5.TabIndex = 8
        '
        'BtnAusencias
        '
        Me.BtnAusencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAusencias.FlatAppearance.BorderSize = 0
        Me.BtnAusencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BtnAusencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnAusencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAusencias.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAusencias.ForeColor = System.Drawing.Color.White
        Me.BtnAusencias.IconChar = FontAwesome.Sharp.IconChar.Envelope
        Me.BtnAusencias.IconColor = System.Drawing.Color.White
        Me.BtnAusencias.IconFont = FontAwesome.Sharp.IconFont.Regular
        Me.BtnAusencias.IconSize = 50
        Me.BtnAusencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAusencias.Location = New System.Drawing.Point(0, 323)
        Me.BtnAusencias.Name = "BtnAusencias"
        Me.BtnAusencias.Size = New System.Drawing.Size(280, 50)
        Me.BtnAusencias.TabIndex = 9
        Me.BtnAusencias.Text = "Permisos"
        Me.BtnAusencias.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Location = New System.Drawing.Point(2, 373)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(7, 50)
        Me.Panel4.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(2, 424)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(7, 50)
        Me.Panel3.TabIndex = 4
        '
        'BtnReportes
        '
        Me.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportes.ForeColor = System.Drawing.Color.White
        Me.BtnReportes.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.BtnReportes.IconColor = System.Drawing.Color.White
        Me.BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.BtnReportes.IconSize = 50
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(0, 425)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(280, 50)
        Me.BtnReportes.TabIndex = 5
        Me.BtnReportes.Text = "     Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(2, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(7, 50)
        Me.Panel2.TabIndex = 2
        '
        'BtnVacaciones
        '
        Me.BtnVacaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVacaciones.FlatAppearance.BorderSize = 0
        Me.BtnVacaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BtnVacaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVacaciones.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVacaciones.ForeColor = System.Drawing.Color.White
        Me.BtnVacaciones.IconChar = FontAwesome.Sharp.IconChar.UmbrellaBeach
        Me.BtnVacaciones.IconColor = System.Drawing.Color.White
        Me.BtnVacaciones.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.BtnVacaciones.IconSize = 50
        Me.BtnVacaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVacaciones.Location = New System.Drawing.Point(0, 271)
        Me.BtnVacaciones.Name = "BtnVacaciones"
        Me.BtnVacaciones.Size = New System.Drawing.Size(280, 50)
        Me.BtnVacaciones.TabIndex = 3
        Me.BtnVacaciones.Text = "     Vacaciones"
        Me.BtnVacaciones.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(2, 217)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(7, 50)
        Me.Panel1.TabIndex = 0
        '
        'BtnRegistrarPersonal
        '
        Me.BtnRegistrarPersonal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrarPersonal.FlatAppearance.BorderSize = 0
        Me.BtnRegistrarPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BtnRegistrarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnRegistrarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarPersonal.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarPersonal.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrarPersonal.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.BtnRegistrarPersonal.IconColor = System.Drawing.Color.White
        Me.BtnRegistrarPersonal.IconFont = FontAwesome.Sharp.IconFont.Regular
        Me.BtnRegistrarPersonal.IconSize = 50
        Me.BtnRegistrarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrarPersonal.Location = New System.Drawing.Point(0, 218)
        Me.BtnRegistrarPersonal.Name = "BtnRegistrarPersonal"
        Me.BtnRegistrarPersonal.Size = New System.Drawing.Size(280, 50)
        Me.BtnRegistrarPersonal.TabIndex = 0
        Me.BtnRegistrarPersonal.Text = "     Registrar Personal"
        Me.BtnRegistrarPersonal.UseVisualStyleBackColor = True
        '
        'Btnmenu
        '
        Me.Btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnmenu.Image = CType(resources.GetObject("Btnmenu.Image"), System.Drawing.Image)
        Me.Btnmenu.Location = New System.Drawing.Point(225, 0)
        Me.Btnmenu.Name = "Btnmenu"
        Me.Btnmenu.Size = New System.Drawing.Size(55, 41)
        Me.Btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btnmenu.TabIndex = 0
        Me.Btnmenu.TabStop = False
        '
        'Tmocultarmenu
        '
        '
        'Tmmostrarmenu
        '
        '
        'Btncerrar
        '
        Me.Btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btncerrar.BackgroundImage = CType(resources.GetObject("Btncerrar.BackgroundImage"), System.Drawing.Image)
        Me.Btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncerrar.FlatAppearance.BorderSize = 0
        Me.Btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncerrar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Btncerrar.IconColor = System.Drawing.Color.Black
        Me.Btncerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btncerrar.Location = New System.Drawing.Point(1342, 0)
        Me.Btncerrar.Name = "Btncerrar"
        Me.Btncerrar.Size = New System.Drawing.Size(40, 40)
        Me.Btncerrar.TabIndex = 0
        Me.Btncerrar.UseVisualStyleBackColor = True
        '
        'Btnmaximizar
        '
        Me.Btnmaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnmaximizar.BackgroundImage = CType(resources.GetObject("Btnmaximizar.BackgroundImage"), System.Drawing.Image)
        Me.Btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnmaximizar.FlatAppearance.BorderSize = 0
        Me.Btnmaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btnmaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btnmaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnmaximizar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Btnmaximizar.IconColor = System.Drawing.Color.Black
        Me.Btnmaximizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btnmaximizar.Location = New System.Drawing.Point(1299, 0)
        Me.Btnmaximizar.Name = "Btnmaximizar"
        Me.Btnmaximizar.Size = New System.Drawing.Size(40, 40)
        Me.Btnmaximizar.TabIndex = 1
        Me.Btnmaximizar.UseVisualStyleBackColor = True
        '
        'Btnminimizar
        '
        Me.Btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnminimizar.BackgroundImage = CType(resources.GetObject("Btnminimizar.BackgroundImage"), System.Drawing.Image)
        Me.Btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnminimizar.FlatAppearance.BorderSize = 0
        Me.Btnminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnminimizar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Btnminimizar.IconColor = System.Drawing.Color.Black
        Me.Btnminimizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btnminimizar.Location = New System.Drawing.Point(1264, 0)
        Me.Btnminimizar.Name = "Btnminimizar"
        Me.Btnminimizar.Size = New System.Drawing.Size(40, 40)
        Me.Btnminimizar.TabIndex = 2
        Me.Btnminimizar.UseVisualStyleBackColor = True
        '
        'Btnrestaurar
        '
        Me.Btnrestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnrestaurar.BackgroundImage = CType(resources.GetObject("Btnrestaurar.BackgroundImage"), System.Drawing.Image)
        Me.Btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnrestaurar.FlatAppearance.BorderSize = 0
        Me.Btnrestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btnrestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btnrestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnrestaurar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Btnrestaurar.IconColor = System.Drawing.Color.Black
        Me.Btnrestaurar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btnrestaurar.Location = New System.Drawing.Point(1299, 0)
        Me.Btnrestaurar.Name = "Btnrestaurar"
        Me.Btnrestaurar.Size = New System.Drawing.Size(40, 40)
        Me.Btnrestaurar.TabIndex = 4
        Me.Btnrestaurar.UseVisualStyleBackColor = True
        Me.Btnrestaurar.Visible = False
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelCabecera.Controls.Add(Me.Btnrestaurar)
        Me.PanelCabecera.Controls.Add(Me.Btnminimizar)
        Me.PanelCabecera.Controls.Add(Me.Btnmaximizar)
        Me.PanelCabecera.Controls.Add(Me.Btncerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(280, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1382, 40)
        Me.PanelCabecera.TabIndex = 6
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackgroundImage = CType(resources.GetObject("PanelContenedor.BackgroundImage"), System.Drawing.Image)
        Me.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(280, 40)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1382, 906)
        Me.PanelContenedor.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Menu_Principal
        '
        Me.AccessibleName = "Menu"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1662, 946)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelCabecera)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.Btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCabecera.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Btnmenu As PictureBox
    Friend WithEvents Tmocultarmenu As Timer
    Friend WithEvents Tmmostrarmenu As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRegistrarPersonal As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnReportes As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnVacaciones As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnAusencias As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btncerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents Btnmaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents Btnminimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents Btnrestaurar As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
