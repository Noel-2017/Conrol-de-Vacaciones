<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrar_Usuarios
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
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim Nombre_De_UsuarioLabel As System.Windows.Forms.Label
        Dim Correo_ElectronioLabel As System.Windows.Forms.Label
        Dim ComparadorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_Usuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComparadorTextBox = New System.Windows.Forms.TextBox()
        Me.Registrar_UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Control_de_VacacionesDataSet = New Conrol_de_Vacaciones.Control_de_VacacionesDataSet()
        Me.Correo_ElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_De_UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEditar = New FontAwesome.Sharp.IconButton()
        Me.BtnEliminar = New FontAwesome.Sharp.IconButton()
        Me.BtnGuardar = New FontAwesome.Sharp.IconButton()
        Me.BtnNuevo = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnminimizar = New FontAwesome.Sharp.IconButton()
        Me.btncerrar = New FontAwesome.Sharp.IconButton()
        Me.Registrar_UsuariosTableAdapter = New Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.Registrar_UsuariosTableAdapter()
        Me.TableAdapterManager = New Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.TableAdapterManager()
        Me.DGUsuarios = New System.Windows.Forms.DataGridView()
        ContraseñaLabel = New System.Windows.Forms.Label()
        Nombre_De_UsuarioLabel = New System.Windows.Forms.Label()
        Correo_ElectronioLabel = New System.Windows.Forms.Label()
        ComparadorLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Registrar_UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Control_de_VacacionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.ForeColor = System.Drawing.Color.Black
        ContraseñaLabel.Location = New System.Drawing.Point(34, 197)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(120, 25)
        ContraseñaLabel.TabIndex = 15
        ContraseñaLabel.Text = "Contraseña:"
        '
        'Nombre_De_UsuarioLabel
        '
        Nombre_De_UsuarioLabel.AutoSize = True
        Nombre_De_UsuarioLabel.ForeColor = System.Drawing.Color.Black
        Nombre_De_UsuarioLabel.Location = New System.Drawing.Point(28, 83)
        Nombre_De_UsuarioLabel.Name = "Nombre_De_UsuarioLabel"
        Nombre_De_UsuarioLabel.Size = New System.Drawing.Size(189, 25)
        Nombre_De_UsuarioLabel.TabIndex = 13
        Nombre_De_UsuarioLabel.Text = "Nombre De Usuario:"
        '
        'Correo_ElectronioLabel
        '
        Correo_ElectronioLabel.AutoSize = True
        Correo_ElectronioLabel.ForeColor = System.Drawing.Color.Black
        Correo_ElectronioLabel.Location = New System.Drawing.Point(33, 133)
        Correo_ElectronioLabel.Name = "Correo_ElectronioLabel"
        Correo_ElectronioLabel.Size = New System.Drawing.Size(169, 25)
        Correo_ElectronioLabel.TabIndex = 16
        Correo_ElectronioLabel.Text = "Correo Electronio:"
        '
        'ComparadorLabel
        '
        ComparadorLabel.AutoSize = True
        ComparadorLabel.ForeColor = System.Drawing.Color.Black
        ComparadorLabel.Location = New System.Drawing.Point(34, 256)
        ComparadorLabel.Name = "ComparadorLabel"
        ComparadorLabel.Size = New System.Drawing.Size(97, 25)
        ComparadorLabel.TabIndex = 17
        ComparadorLabel.Text = "Confirmar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox1.Controls.Add(ComparadorLabel)
        Me.GroupBox1.Controls.Add(Me.ComparadorTextBox)
        Me.GroupBox1.Controls.Add(Correo_ElectronioLabel)
        Me.GroupBox1.Controls.Add(Me.Correo_ElectronicoTextBox)
        Me.GroupBox1.Controls.Add(ContraseñaLabel)
        Me.GroupBox1.Controls.Add(Me.ContraseñaTextBox)
        Me.GroupBox1.Controls.Add(Nombre_De_UsuarioLabel)
        Me.GroupBox1.Controls.Add(Me.Nombre_De_UsuarioTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(30, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 327)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Usuario"
        '
        'ComparadorTextBox
        '
        Me.ComparadorTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ComparadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registrar_UsuariosBindingSource, "Comparador", True))
        Me.ComparadorTextBox.ForeColor = System.Drawing.Color.Black
        Me.ComparadorTextBox.Location = New System.Drawing.Point(297, 256)
        Me.ComparadorTextBox.Name = "ComparadorTextBox"
        Me.ComparadorTextBox.Size = New System.Drawing.Size(241, 30)
        Me.ComparadorTextBox.TabIndex = 18
        '
        'Registrar_UsuariosBindingSource
        '
        Me.Registrar_UsuariosBindingSource.DataMember = "Registrar_Usuarios"
        Me.Registrar_UsuariosBindingSource.DataSource = Me.Control_de_VacacionesDataSet
        '
        'Control_de_VacacionesDataSet
        '
        Me.Control_de_VacacionesDataSet.DataSetName = "Control_de_VacacionesDataSet"
        Me.Control_de_VacacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Correo_ElectronicoTextBox
        '
        Me.Correo_ElectronicoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Correo_ElectronicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registrar_UsuariosBindingSource, "Correo_Electronio", True))
        Me.Correo_ElectronicoTextBox.ForeColor = System.Drawing.Color.Black
        Me.Correo_ElectronicoTextBox.Location = New System.Drawing.Point(297, 133)
        Me.Correo_ElectronicoTextBox.Name = "Correo_ElectronicoTextBox"
        Me.Correo_ElectronicoTextBox.Size = New System.Drawing.Size(241, 30)
        Me.Correo_ElectronicoTextBox.TabIndex = 17
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registrar_UsuariosBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox.ForeColor = System.Drawing.Color.Black
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(297, 192)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(241, 30)
        Me.ContraseñaTextBox.TabIndex = 16
        '
        'Nombre_De_UsuarioTextBox
        '
        Me.Nombre_De_UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registrar_UsuariosBindingSource, "Nombre_De_Usuario", True))
        Me.Nombre_De_UsuarioTextBox.Location = New System.Drawing.Point(297, 80)
        Me.Nombre_De_UsuarioTextBox.Name = "Nombre_De_UsuarioTextBox"
        Me.Nombre_De_UsuarioTextBox.Size = New System.Drawing.Size(241, 30)
        Me.Nombre_De_UsuarioTextBox.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Controls.Add(Me.BtnEditar)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.BtnGuardar)
        Me.GroupBox2.Controls.Add(Me.BtnNuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(650, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 327)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.LightBlue
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.UserPen
        Me.BtnEditar.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEditar.IconSize = 40
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(32, 206)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(208, 57)
        Me.BtnEditar.TabIndex = 25
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserXmark
        Me.BtnEliminar.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEliminar.IconSize = 40
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(32, 143)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(208, 57)
        Me.BtnEliminar.TabIndex = 24
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.DarkBlue
        Me.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.BtnGuardar.IconColor = System.Drawing.Color.DodgerBlue
        Me.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(32, 83)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(208, 54)
        Me.BtnGuardar.TabIndex = 23
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnNuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.DarkBlue
        Me.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.BtnNuevo.IconColor = System.Drawing.Color.DodgerBlue
        Me.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(32, 16)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(208, 54)
        Me.BtnNuevo.TabIndex = 22
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(336, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 32)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Registro de Usuarios"
        '
        'btnminimizar
        '
        Me.btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimizar.BackColor = System.Drawing.Color.Crimson
        Me.btnminimizar.BackgroundImage = CType(resources.GetObject("btnminimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminimizar.FlatAppearance.BorderSize = 0
        Me.btnminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnminimizar.IconColor = System.Drawing.Color.Black
        Me.btnminimizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnminimizar.Location = New System.Drawing.Point(902, 0)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnminimizar.TabIndex = 26
        Me.btnminimizar.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Crimson
        Me.btncerrar.BackgroundImage = CType(resources.GetObject("btncerrar.BackgroundImage"), System.Drawing.Image)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btncerrar.IconColor = System.Drawing.Color.Black
        Me.btncerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btncerrar.Location = New System.Drawing.Point(942, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(40, 40)
        Me.btncerrar.TabIndex = 25
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'Registrar_UsuariosTableAdapter
        '
        Me.Registrar_UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PermisosTableAdapter = Nothing
        Me.TableAdapterManager.Registrar_UsuariosTableAdapter = Me.Registrar_UsuariosTableAdapter
        Me.TableAdapterManager.Registro_de_EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_VacacionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VacacionesTableAdapter = Nothing
        '
        'DGUsuarios
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGUsuarios.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.DGUsuarios.Location = New System.Drawing.Point(30, 494)
        Me.DGUsuarios.Name = "DGUsuarios"
        Me.DGUsuarios.RowHeadersWidth = 51
        Me.DGUsuarios.RowTemplate.Height = 24
        Me.DGUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGUsuarios.Size = New System.Drawing.Size(897, 150)
        Me.DGUsuarios.TabIndex = 27
        '
        'Registrar_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(982, 679)
        Me.Controls.Add(Me.DGUsuarios)
        Me.Controls.Add(Me.btnminimizar)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registrar_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Registrar_UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Control_de_VacacionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Control_de_VacacionesDataSet As Control_de_VacacionesDataSet
    Friend WithEvents Registrar_UsuariosBindingSource As BindingSource
    Friend WithEvents Registrar_UsuariosTableAdapter As Control_de_VacacionesDataSetTableAdapters.Registrar_UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As Control_de_VacacionesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents Nombre_De_UsuarioTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnminimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents btncerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents Correo_ElectronicoTextBox As TextBox
    Friend WithEvents ComparadorTextBox As TextBox
    Friend WithEvents BtnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents DGUsuarios As DataGridView
End Class
