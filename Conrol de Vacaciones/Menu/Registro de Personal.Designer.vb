<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro_de_Personal
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
        Dim Id_IdentidadLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim Cargo_NominalLabel As System.Windows.Forms.Label
        Dim Cargo_FuncionalLabel As System.Windows.Forms.Label
        Dim Fecha_de_IngresoLabel As System.Windows.Forms.Label
        Dim Modalidad_de_ContrataciónLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_de_Personal))
        Me.BtnNuevo = New FontAwesome.Sharp.IconButton()
        Me.BtnEliminar = New FontAwesome.Sharp.IconButton()
        Me.BtnBuscar = New FontAwesome.Sharp.IconButton()
        Me.BtnGuardar = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbxSexo = New System.Windows.Forms.ComboBox()
        Me.chkbAmbas = New System.Windows.Forms.RadioButton()
        Me.chkbProfilactica = New System.Windows.Forms.RadioButton()
        Me.chkbOrdinaria = New System.Windows.Forms.RadioButton()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.Registro_de_EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Control_de_VacacionesDataSet = New Conrol_de_Vacaciones.Control_de_VacacionesDataSet()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.Id_IdentidadTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpirar = New FontAwesome.Sharp.IconButton()
        Me.BtnEditar = New FontAwesome.Sharp.IconButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Modalidad_de_ContrataciónTextBox = New System.Windows.Forms.TextBox()
        Me.Cargo_NominalTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_de_IngresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cargo_FuncionalTextBox = New System.Windows.Forms.TextBox()
        Me.Registro_de_EmpleadosTableAdapter = New Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.Registro_de_EmpleadosTableAdapter()
        Me.TableAdapterManager = New Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.TableAdapterManager()
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Id_IdentidadLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        Cargo_NominalLabel = New System.Windows.Forms.Label()
        Cargo_FuncionalLabel = New System.Windows.Forms.Label()
        Fecha_de_IngresoLabel = New System.Windows.Forms.Label()
        Modalidad_de_ContrataciónLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Registro_de_EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Control_de_VacacionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_IdentidadLabel
        '
        Id_IdentidadLabel.AutoSize = True
        Id_IdentidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_IdentidadLabel.ForeColor = System.Drawing.Color.White
        Id_IdentidadLabel.Location = New System.Drawing.Point(34, 61)
        Id_IdentidadLabel.Name = "Id_IdentidadLabel"
        Id_IdentidadLabel.Size = New System.Drawing.Size(119, 25)
        Id_IdentidadLabel.TabIndex = 0
        Id_IdentidadLabel.Text = "Id Identidad:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombresLabel.ForeColor = System.Drawing.Color.White
        NombresLabel.Location = New System.Drawing.Point(34, 110)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(97, 25)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.ForeColor = System.Drawing.Color.White
        ApellidosLabel.Location = New System.Drawing.Point(444, 115)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(98, 25)
        ApellidosLabel.TabIndex = 4
        ApellidosLabel.Text = "Apellidos:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.ForeColor = System.Drawing.Color.White
        TelefonoLabel.Location = New System.Drawing.Point(34, 196)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(95, 25)
        TelefonoLabel.TabIndex = 6
        TelefonoLabel.Text = "Telefono:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.ForeColor = System.Drawing.Color.White
        DireccionLabel.Location = New System.Drawing.Point(34, 247)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(99, 25)
        DireccionLabel.TabIndex = 8
        DireccionLabel.Text = "Direccion:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(34, 278)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(94, 29)
        CorreoLabel.TabIndex = 20
        CorreoLabel.Text = "Correo:"
        '
        'Cargo_NominalLabel
        '
        Cargo_NominalLabel.AutoSize = True
        Cargo_NominalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cargo_NominalLabel.ForeColor = System.Drawing.Color.White
        Cargo_NominalLabel.Location = New System.Drawing.Point(6, 130)
        Cargo_NominalLabel.Name = "Cargo_NominalLabel"
        Cargo_NominalLabel.Size = New System.Drawing.Size(148, 25)
        Cargo_NominalLabel.TabIndex = 27
        Cargo_NominalLabel.Text = "Cargo Nominal:"
        '
        'Cargo_FuncionalLabel
        '
        Cargo_FuncionalLabel.AutoSize = True
        Cargo_FuncionalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cargo_FuncionalLabel.ForeColor = System.Drawing.Color.White
        Cargo_FuncionalLabel.Location = New System.Drawing.Point(6, 194)
        Cargo_FuncionalLabel.Name = "Cargo_FuncionalLabel"
        Cargo_FuncionalLabel.Size = New System.Drawing.Size(162, 25)
        Cargo_FuncionalLabel.TabIndex = 26
        Cargo_FuncionalLabel.Text = "Cargo Funcional:"
        '
        'Fecha_de_IngresoLabel
        '
        Fecha_de_IngresoLabel.AutoSize = True
        Fecha_de_IngresoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_de_IngresoLabel.ForeColor = System.Drawing.Color.White
        Fecha_de_IngresoLabel.Location = New System.Drawing.Point(5, 63)
        Fecha_de_IngresoLabel.Name = "Fecha_de_IngresoLabel"
        Fecha_de_IngresoLabel.Size = New System.Drawing.Size(170, 25)
        Fecha_de_IngresoLabel.TabIndex = 24
        Fecha_de_IngresoLabel.Text = "Fecha de Ingreso:"
        '
        'Modalidad_de_ContrataciónLabel
        '
        Modalidad_de_ContrataciónLabel.AutoSize = True
        Modalidad_de_ContrataciónLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Modalidad_de_ContrataciónLabel.ForeColor = System.Drawing.Color.White
        Modalidad_de_ContrataciónLabel.Location = New System.Drawing.Point(5, 261)
        Modalidad_de_ContrataciónLabel.Name = "Modalidad_de_ContrataciónLabel"
        Modalidad_de_ContrataciónLabel.Size = New System.Drawing.Size(252, 25)
        Modalidad_de_ContrataciónLabel.TabIndex = 25
        Modalidad_de_ContrataciónLabel.Text = "Modalidad de Contratación:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(34, 149)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(64, 25)
        Label2.TabIndex = 37
        Label2.Text = "Sexo:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(617, 193)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(171, 25)
        Label3.TabIndex = 39
        Label3.Text = "Tipo de Vacaciòn:"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Lavender
        Me.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.BtnNuevo.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnNuevo.IconSize = 40
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(13, 15)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(161, 52)
        Me.BtnNuevo.TabIndex = 18
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Lavender
        Me.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserXmark
        Me.BtnEliminar.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEliminar.IconSize = 40
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(345, 15)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(161, 53)
        Me.BtnEliminar.TabIndex = 19
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscar.BackColor = System.Drawing.Color.LightBlue
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.BtnBuscar.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnBuscar.IconSize = 35
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(433, 60)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(136, 40)
        Me.BtnBuscar.TabIndex = 20
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Lavender
        Me.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.BtnGuardar.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnGuardar.IconSize = 40
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(179, 14)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(161, 52)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.CbxSexo)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.chkbAmbas)
        Me.GroupBox1.Controls.Add(Me.chkbProfilactica)
        Me.GroupBox1.Controls.Add(Me.chkbOrdinaria)
        Me.GroupBox1.Controls.Add(CorreoLabel)
        Me.GroupBox1.Controls.Add(Me.CorreoTextBox)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(Id_IdentidadLabel)
        Me.GroupBox1.Controls.Add(Me.Id_IdentidadTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 349)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'CbxSexo
        '
        Me.CbxSexo.FormattingEnabled = True
        Me.CbxSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.CbxSexo.Location = New System.Drawing.Point(182, 149)
        Me.CbxSexo.Name = "CbxSexo"
        Me.CbxSexo.Size = New System.Drawing.Size(170, 37)
        Me.CbxSexo.TabIndex = 38
        '
        'chkbAmbas
        '
        Me.chkbAmbas.AutoSize = True
        Me.chkbAmbas.ForeColor = System.Drawing.Color.White
        Me.chkbAmbas.Location = New System.Drawing.Point(623, 302)
        Me.chkbAmbas.Name = "chkbAmbas"
        Me.chkbAmbas.Size = New System.Drawing.Size(108, 33)
        Me.chkbAmbas.TabIndex = 36
        Me.chkbAmbas.TabStop = True
        Me.chkbAmbas.Text = "Ambas"
        Me.chkbAmbas.UseVisualStyleBackColor = True
        '
        'chkbProfilactica
        '
        Me.chkbProfilactica.AutoSize = True
        Me.chkbProfilactica.ForeColor = System.Drawing.Color.White
        Me.chkbProfilactica.Location = New System.Drawing.Point(623, 263)
        Me.chkbProfilactica.Name = "chkbProfilactica"
        Me.chkbProfilactica.Size = New System.Drawing.Size(152, 33)
        Me.chkbProfilactica.TabIndex = 35
        Me.chkbProfilactica.TabStop = True
        Me.chkbProfilactica.Text = "Profilactica"
        Me.chkbProfilactica.UseVisualStyleBackColor = True
        '
        'chkbOrdinaria
        '
        Me.chkbOrdinaria.AutoSize = True
        Me.chkbOrdinaria.ForeColor = System.Drawing.Color.White
        Me.chkbOrdinaria.Location = New System.Drawing.Point(623, 224)
        Me.chkbOrdinaria.Name = "chkbOrdinaria"
        Me.chkbOrdinaria.Size = New System.Drawing.Size(134, 33)
        Me.chkbOrdinaria.TabIndex = 34
        Me.chkbOrdinaria.TabStop = True
        Me.chkbOrdinaria.Text = "Ordinaria"
        Me.chkbOrdinaria.UseVisualStyleBackColor = True
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(182, 278)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(245, 34)
        Me.CorreoTextBox.TabIndex = 21
        '
        'Registro_de_EmpleadosBindingSource
        '
        Me.Registro_de_EmpleadosBindingSource.DataMember = "Registro_de_Empleados"
        Me.Registro_de_EmpleadosBindingSource.DataSource = Me.Control_de_VacacionesDataSet
        '
        'Control_de_VacacionesDataSet
        '
        Me.Control_de_VacacionesDataSet.DataSetName = "Control_de_VacacionesDataSet"
        Me.Control_de_VacacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Direccion", True))
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DireccionTextBox.Location = New System.Drawing.Point(182, 242)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(360, 30)
        Me.DireccionTextBox.TabIndex = 9
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TelefonoTextBox.Location = New System.Drawing.Point(182, 193)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(170, 30)
        Me.TelefonoTextBox.TabIndex = 7
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ApellidosTextBox.Location = New System.Drawing.Point(568, 112)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(245, 30)
        Me.ApellidosTextBox.TabIndex = 5
        '
        'NombresTextBox
        '
        Me.NombresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Nombres", True))
        Me.NombresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombresTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NombresTextBox.Location = New System.Drawing.Point(182, 110)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(245, 23)
        Me.NombresTextBox.TabIndex = 3
        '
        'Id_IdentidadTextBox
        '
        Me.Id_IdentidadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_IdentidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Id_Identidad", True))
        Me.Id_IdentidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_IdentidadTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Id_IdentidadTextBox.Location = New System.Drawing.Point(182, 61)
        Me.Id_IdentidadTextBox.Name = "Id_IdentidadTextBox"
        Me.Id_IdentidadTextBox.Size = New System.Drawing.Size(245, 23)
        Me.Id_IdentidadTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(463, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(531, 43)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "REGISTRO DE EMPLEADOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.GroupBox3.Controls.Add(Me.BtnLimpirar)
        Me.GroupBox3.Controls.Add(Me.BtnEditar)
        Me.GroupBox3.Controls.Add(Me.BtnGuardar)
        Me.GroupBox3.Controls.Add(Me.BtnNuevo)
        Me.GroupBox3.Controls.Add(Me.BtnEliminar)
        Me.GroupBox3.Location = New System.Drawing.Point(239, 488)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(849, 75)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "..."
        '
        'BtnLimpirar
        '
        Me.BtnLimpirar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnLimpirar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpirar.FlatAppearance.BorderSize = 0
        Me.BtnLimpirar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpirar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLimpirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnLimpirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpirar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpirar.ForeColor = System.Drawing.Color.Lavender
        Me.BtnLimpirar.IconChar = FontAwesome.Sharp.IconChar.UserPen
        Me.BtnLimpirar.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnLimpirar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnLimpirar.IconSize = 40
        Me.BtnLimpirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpirar.Location = New System.Drawing.Point(678, 15)
        Me.BtnLimpirar.Name = "BtnLimpirar"
        Me.BtnLimpirar.Size = New System.Drawing.Size(161, 53)
        Me.BtnLimpirar.TabIndex = 23
        Me.BtnLimpirar.Text = "Limpiar"
        Me.BtnLimpirar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLimpirar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.Lavender
        Me.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.UserPen
        Me.BtnEditar.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEditar.IconSize = 40
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(512, 14)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(161, 53)
        Me.BtnEditar.TabIndex = 22
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Cargo_NominalLabel)
        Me.GroupBox2.Controls.Add(Me.Modalidad_de_ContrataciónTextBox)
        Me.GroupBox2.Controls.Add(Me.Cargo_NominalTextBox)
        Me.GroupBox2.Controls.Add(Me.Fecha_de_IngresoDateTimePicker)
        Me.GroupBox2.Controls.Add(Cargo_FuncionalLabel)
        Me.GroupBox2.Controls.Add(Fecha_de_IngresoLabel)
        Me.GroupBox2.Controls.Add(Me.Cargo_FuncionalTextBox)
        Me.GroupBox2.Controls.Add(Modalidad_de_ContrataciónLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(840, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 337)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Modalidad_de_ContrataciónTextBox
        '
        Me.Modalidad_de_ContrataciónTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Modalidad_de_ContrataciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Modalidad_de_Contratación", True))
        Me.Modalidad_de_ContrataciónTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modalidad_de_ContrataciónTextBox.ForeColor = System.Drawing.Color.Black
        Me.Modalidad_de_ContrataciónTextBox.Location = New System.Drawing.Point(286, 256)
        Me.Modalidad_de_ContrataciónTextBox.Name = "Modalidad_de_ContrataciónTextBox"
        Me.Modalidad_de_ContrataciónTextBox.Size = New System.Drawing.Size(179, 30)
        Me.Modalidad_de_ContrataciónTextBox.TabIndex = 26
        '
        'Cargo_NominalTextBox
        '
        Me.Cargo_NominalTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Cargo_NominalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Cargo_Nominal", True))
        Me.Cargo_NominalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo_NominalTextBox.ForeColor = System.Drawing.Color.Black
        Me.Cargo_NominalTextBox.Location = New System.Drawing.Point(286, 125)
        Me.Cargo_NominalTextBox.Name = "Cargo_NominalTextBox"
        Me.Cargo_NominalTextBox.Size = New System.Drawing.Size(179, 30)
        Me.Cargo_NominalTextBox.TabIndex = 28
        '
        'Fecha_de_IngresoDateTimePicker
        '
        Me.Fecha_de_IngresoDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_de_IngresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Registro_de_EmpleadosBindingSource, "Fecha_de_Ingreso", True))
        Me.Fecha_de_IngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_de_IngresoDateTimePicker.Location = New System.Drawing.Point(286, 58)
        Me.Fecha_de_IngresoDateTimePicker.Name = "Fecha_de_IngresoDateTimePicker"
        Me.Fecha_de_IngresoDateTimePicker.Size = New System.Drawing.Size(179, 30)
        Me.Fecha_de_IngresoDateTimePicker.TabIndex = 25
        '
        'Cargo_FuncionalTextBox
        '
        Me.Cargo_FuncionalTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Cargo_FuncionalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Cargo_Funcional", True))
        Me.Cargo_FuncionalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo_FuncionalTextBox.ForeColor = System.Drawing.Color.Black
        Me.Cargo_FuncionalTextBox.Location = New System.Drawing.Point(286, 189)
        Me.Cargo_FuncionalTextBox.Name = "Cargo_FuncionalTextBox"
        Me.Cargo_FuncionalTextBox.Size = New System.Drawing.Size(179, 30)
        Me.Cargo_FuncionalTextBox.TabIndex = 27
        '
        'Registro_de_EmpleadosTableAdapter
        '
        Me.Registro_de_EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PermisosTableAdapter = Nothing
        Me.TableAdapterManager.Registrar_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.Registro_de_EmpleadosTableAdapter = Me.Registro_de_EmpleadosTableAdapter
        Me.TableAdapterManager.Tipo_VacacionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VacacionesTableAdapter = Nothing
        '
        'dgEmpleados
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue
        Me.dgEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgEmpleados.Location = New System.Drawing.Point(12, 579)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.RowHeadersWidth = 51
        Me.dgEmpleados.RowTemplate.Height = 24
        Me.dgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgEmpleados.Size = New System.Drawing.Size(1367, 351)
        Me.dgEmpleados.TabIndex = 27
        '
        'IconButton2
        '
        Me.IconButton2.BackgroundImage = CType(resources.GetObject("IconButton2.BackgroundImage"), System.Drawing.Image)
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(1, -1)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(40, 40)
        Me.IconButton2.TabIndex = 28
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Registro_de_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1382, 899)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.PaleGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro_de_Personal"
        Me.Text = "Registro_de_Personal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Registro_de_EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Control_de_VacacionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents Control_de_VacacionesDataSet As Control_de_VacacionesDataSet
    Friend WithEvents Registro_de_EmpleadosBindingSource As BindingSource
    Friend WithEvents Registro_de_EmpleadosTableAdapter As Control_de_VacacionesDataSetTableAdapters.Registro_de_EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As Control_de_VacacionesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents Id_IdentidadTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents chkbAmbas As RadioButton
    Friend WithEvents chkbProfilactica As RadioButton
    Friend WithEvents chkbOrdinaria As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Modalidad_de_ContrataciónTextBox As TextBox
    Friend WithEvents Cargo_NominalTextBox As TextBox
    Friend WithEvents Fecha_de_IngresoDateTimePicker As DateTimePicker
    Friend WithEvents Cargo_FuncionalTextBox As TextBox
    Friend WithEvents dgEmpleados As DataGridView
    Friend WithEvents CbxSexo As ComboBox
    Friend WithEvents BtnEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnLimpirar As FontAwesome.Sharp.IconButton
End Class
