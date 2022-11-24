<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacaciones
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
        Dim Id_IdentidadLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim Cantidad_de_días_de_vacacionesLabel As System.Windows.Forms.Label
        Dim Cantidad_de_Días_DisponiblesLabel As System.Windows.Forms.Label
        Dim Cantidad_de_Días_SolicitadosLabel As System.Windows.Forms.Label
        Dim Fecha_InicioLabel As System.Windows.Forms.Label
        Dim Fecha_FinalLabel As System.Windows.Forms.Label
        Dim Fecha_de_RetornoLabel As System.Windows.Forms.Label
        Dim Tarjeta_de_AsistenciaLabel As System.Windows.Forms.Label
        Dim Periodo_de_VacacionesLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Tipo_de_VacacionesLabel1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.btncerrar = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.VacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Control_de_VacacionesDataSet = New Conrol_de_Vacaciones.Control_de_VacacionesDataSet()
        Me.NombresTextBox = New System.Windows.Forms.ComboBox()
        Me.btnIdentidad = New FontAwesome.Sharp.IconButton()
        Me.btnNombre = New FontAwesome.Sharp.IconButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New FontAwesome.Sharp.IconButton()
        Me.IdentidadTXT = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkAmbas = New System.Windows.Forms.RadioButton()
        Me.chkProfilactica = New System.Windows.Forms.RadioButton()
        Me.chkOrdinaria = New System.Windows.Forms.RadioButton()
        Me.Cantidad_de_Dias_SolicitadosTXT = New System.Windows.Forms.TextBox()
        Me.Fecha_InicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_de_RetornoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_FinalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cantidad_de_Días_DisponiblesTextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_de_días_de_vacacionesTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPeriodo_Vacaciones = New System.Windows.Forms.TextBox()
        Me.Tarjeta_de_AsistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New FontAwesome.Sharp.IconButton()
        Me.BtnGuardar = New FontAwesome.Sharp.IconButton()
        Me.BtnNuevo = New FontAwesome.Sharp.IconButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VacacionesTableAdapter = New Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.VacacionesTableAdapter()
        Me.TableAdapterManager = New Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.TableAdapterManager()
        Me.DGvacaciones = New System.Windows.Forms.DataGridView()
        Id_IdentidadLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        Cantidad_de_días_de_vacacionesLabel = New System.Windows.Forms.Label()
        Cantidad_de_Días_DisponiblesLabel = New System.Windows.Forms.Label()
        Cantidad_de_Días_SolicitadosLabel = New System.Windows.Forms.Label()
        Fecha_InicioLabel = New System.Windows.Forms.Label()
        Fecha_FinalLabel = New System.Windows.Forms.Label()
        Fecha_de_RetornoLabel = New System.Windows.Forms.Label()
        Tarjeta_de_AsistenciaLabel = New System.Windows.Forms.Label()
        Periodo_de_VacacionesLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Tipo_de_VacacionesLabel1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Control_de_VacacionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGvacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_IdentidadLabel
        '
        Id_IdentidadLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Id_IdentidadLabel.AutoSize = True
        Id_IdentidadLabel.Location = New System.Drawing.Point(32, 102)
        Id_IdentidadLabel.Name = "Id_IdentidadLabel"
        Id_IdentidadLabel.Size = New System.Drawing.Size(119, 25)
        Id_IdentidadLabel.TabIndex = 2
        Id_IdentidadLabel.Text = "Id Identidad:"
        '
        'NombresLabel
        '
        NombresLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(33, 46)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(97, 25)
        NombresLabel.TabIndex = 4
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(32, 167)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(98, 25)
        ApellidosLabel.TabIndex = 6
        ApellidosLabel.Text = "Apellidos:"
        '
        'Cantidad_de_días_de_vacacionesLabel
        '
        Cantidad_de_días_de_vacacionesLabel.AutoSize = True
        Cantidad_de_días_de_vacacionesLabel.Location = New System.Drawing.Point(6, 68)
        Cantidad_de_días_de_vacacionesLabel.Name = "Cantidad_de_días_de_vacacionesLabel"
        Cantidad_de_días_de_vacacionesLabel.Size = New System.Drawing.Size(296, 25)
        Cantidad_de_días_de_vacacionesLabel.TabIndex = 2
        Cantidad_de_días_de_vacacionesLabel.Text = "Cantidad de días de vacaciones:"
        '
        'Cantidad_de_Días_DisponiblesLabel
        '
        Cantidad_de_Días_DisponiblesLabel.AutoSize = True
        Cantidad_de_Días_DisponiblesLabel.Location = New System.Drawing.Point(9, 102)
        Cantidad_de_Días_DisponiblesLabel.Name = "Cantidad_de_Días_DisponiblesLabel"
        Cantidad_de_Días_DisponiblesLabel.Size = New System.Drawing.Size(274, 25)
        Cantidad_de_Días_DisponiblesLabel.TabIndex = 4
        Cantidad_de_Días_DisponiblesLabel.Text = "Cantidad de Días Disponibles:"
        '
        'Cantidad_de_Días_SolicitadosLabel
        '
        Cantidad_de_Días_SolicitadosLabel.AutoSize = True
        Cantidad_de_Días_SolicitadosLabel.Location = New System.Drawing.Point(271, 108)
        Cantidad_de_Días_SolicitadosLabel.Name = "Cantidad_de_Días_SolicitadosLabel"
        Cantidad_de_Días_SolicitadosLabel.Size = New System.Drawing.Size(157, 25)
        Cantidad_de_Días_SolicitadosLabel.TabIndex = 20
        Cantidad_de_Días_SolicitadosLabel.Text = "Días Solicitados:"
        '
        'Fecha_InicioLabel
        '
        Fecha_InicioLabel.AutoSize = True
        Fecha_InicioLabel.Location = New System.Drawing.Point(17, 116)
        Fecha_InicioLabel.Name = "Fecha_InicioLabel"
        Fecha_InicioLabel.Size = New System.Drawing.Size(123, 25)
        Fecha_InicioLabel.TabIndex = 0
        Fecha_InicioLabel.Text = "Fecha Inicio:"
        '
        'Fecha_FinalLabel
        '
        Fecha_FinalLabel.AutoSize = True
        Fecha_FinalLabel.Location = New System.Drawing.Point(17, 153)
        Fecha_FinalLabel.Name = "Fecha_FinalLabel"
        Fecha_FinalLabel.Size = New System.Drawing.Size(120, 25)
        Fecha_FinalLabel.TabIndex = 2
        Fecha_FinalLabel.Text = "Fecha Final:"
        '
        'Fecha_de_RetornoLabel
        '
        Fecha_de_RetornoLabel.AutoSize = True
        Fecha_de_RetornoLabel.Location = New System.Drawing.Point(19, 186)
        Fecha_de_RetornoLabel.Name = "Fecha_de_RetornoLabel"
        Fecha_de_RetornoLabel.Size = New System.Drawing.Size(135, 25)
        Fecha_de_RetornoLabel.TabIndex = 4
        Fecha_de_RetornoLabel.Text = "F. de Retorno:"
        '
        'Tarjeta_de_AsistenciaLabel
        '
        Tarjeta_de_AsistenciaLabel.AutoSize = True
        Tarjeta_de_AsistenciaLabel.Location = New System.Drawing.Point(6, 31)
        Tarjeta_de_AsistenciaLabel.Name = "Tarjeta_de_AsistenciaLabel"
        Tarjeta_de_AsistenciaLabel.Size = New System.Drawing.Size(201, 25)
        Tarjeta_de_AsistenciaLabel.TabIndex = 6
        Tarjeta_de_AsistenciaLabel.Text = "Tarjeta de Asistencia:"
        '
        'Periodo_de_VacacionesLabel
        '
        Periodo_de_VacacionesLabel.AutoSize = True
        Periodo_de_VacacionesLabel.Location = New System.Drawing.Point(86, 145)
        Periodo_de_VacacionesLabel.Name = "Periodo_de_VacacionesLabel"
        Periodo_de_VacacionesLabel.Size = New System.Drawing.Size(121, 50)
        Periodo_de_VacacionesLabel.TabIndex = 8
        Periodo_de_VacacionesLabel.Text = "Periodo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vacaciones:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(249, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(129, 25)
        Label1.TabIndex = 10
        Label1.Text = "Observación:"
        '
        'Tipo_de_VacacionesLabel1
        '
        Tipo_de_VacacionesLabel1.AutoSize = True
        Tipo_de_VacacionesLabel1.Location = New System.Drawing.Point(17, 43)
        Tipo_de_VacacionesLabel1.Name = "Tipo_de_VacacionesLabel1"
        Tipo_de_VacacionesLabel1.Size = New System.Drawing.Size(192, 25)
        Tipo_de_VacacionesLabel1.TabIndex = 27
        Tipo_de_VacacionesLabel1.Text = "Tipo de Vacaciones:"
        '
        'Label3
        '
        Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(434, 167)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(143, 25)
        Label3.TabIndex = 30
        Label3.Text = "Fecha Ingreso:"
        '
        'btncerrar
        '
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btncerrar.IconColor = System.Drawing.Color.Red
        Me.btncerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btncerrar.IconSize = 35
        Me.btncerrar.Location = New System.Drawing.Point(-1, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(37, 29)
        Me.btncerrar.TabIndex = 18
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.FechaIngreso)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.btnIdentidad)
        Me.GroupBox1.Controls.Add(Me.btnNombre)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.IdentidadTXT)
        Me.GroupBox1.Controls.Add(Id_IdentidadLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(63, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(774, 222)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'FechaIngreso
        '
        Me.FechaIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VacacionesBindingSource, "Fecha_Inicio", True))
        Me.FechaIngreso.Enabled = False
        Me.FechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaIngreso.Location = New System.Drawing.Point(583, 168)
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.Size = New System.Drawing.Size(108, 27)
        Me.FechaIngreso.TabIndex = 29
        Me.FechaIngreso.Value = New Date(2022, 11, 2, 0, 0, 0, 0)
        '
        'VacacionesBindingSource
        '
        Me.VacacionesBindingSource.DataMember = "Vacaciones"
        Me.VacacionesBindingSource.DataSource = Me.Control_de_VacacionesDataSet
        '
        'Control_de_VacacionesDataSet
        '
        Me.Control_de_VacacionesDataSet.DataSetName = "Control_de_VacacionesDataSet"
        Me.Control_de_VacacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VacacionesBindingSource, "Tipo_de_Vacaciones", True))
        Me.NombresTextBox.FormattingEnabled = True
        Me.NombresTextBox.Location = New System.Drawing.Point(156, 43)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(272, 33)
        Me.NombresTextBox.TabIndex = 29
        '
        'btnIdentidad
        '
        Me.btnIdentidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIdentidad.BackColor = System.Drawing.Color.LightBlue
        Me.btnIdentidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIdentidad.FlatAppearance.BorderSize = 0
        Me.btnIdentidad.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIdentidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIdentidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnIdentidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIdentidad.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnIdentidad.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnIdentidad.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnIdentidad.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnIdentidad.IconSize = 20
        Me.btnIdentidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIdentidad.Location = New System.Drawing.Point(491, 123)
        Me.btnIdentidad.Name = "btnIdentidad"
        Me.btnIdentidad.Size = New System.Drawing.Size(272, 34)
        Me.btnIdentidad.TabIndex = 29
        Me.btnIdentidad.Text = "Identidad"
        Me.btnIdentidad.UseVisualStyleBackColor = False
        Me.btnIdentidad.Visible = False
        '
        'btnNombre
        '
        Me.btnNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNombre.BackColor = System.Drawing.Color.LightBlue
        Me.btnNombre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNombre.FlatAppearance.BorderSize = 0
        Me.btnNombre.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNombre.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnNombre.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnNombre.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnNombre.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNombre.IconSize = 20
        Me.btnNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNombre.Location = New System.Drawing.Point(491, 83)
        Me.btnNombre.Name = "btnNombre"
        Me.btnNombre.Size = New System.Drawing.Size(272, 34)
        Me.btnNombre.TabIndex = 28
        Me.btnNombre.Text = "Nombre"
        Me.btnNombre.UseVisualStyleBackColor = False
        Me.btnNombre.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VacacionesBindingSource, "Apellidos", True))
        Me.txtBuscar.Location = New System.Drawing.Point(491, 49)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(272, 30)
        Me.txtBuscar.TabIndex = 27
        Me.txtBuscar.Visible = False
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VacacionesBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(156, 164)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(272, 30)
        Me.ApellidosTextBox.TabIndex = 3
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
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.BtnBuscar.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnBuscar.IconSize = 20
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(454, 46)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(31, 34)
        Me.BtnBuscar.TabIndex = 26
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'IdentidadTXT
        '
        Me.IdentidadTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VacacionesBindingSource, "Nombres", True))
        Me.IdentidadTXT.Location = New System.Drawing.Point(153, 100)
        Me.IdentidadTXT.Name = "IdentidadTXT"
        Me.IdentidadTXT.Size = New System.Drawing.Size(272, 30)
        Me.IdentidadTXT.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chkAmbas)
        Me.GroupBox2.Controls.Add(Me.chkProfilactica)
        Me.GroupBox2.Controls.Add(Me.chkOrdinaria)
        Me.GroupBox2.Controls.Add(Me.Cantidad_de_Dias_SolicitadosTXT)
        Me.GroupBox2.Controls.Add(Tipo_de_VacacionesLabel1)
        Me.GroupBox2.Controls.Add(Cantidad_de_Días_SolicitadosLabel)
        Me.GroupBox2.Controls.Add(Me.Fecha_InicioDateTimePicker)
        Me.GroupBox2.Controls.Add(Fecha_InicioLabel)
        Me.GroupBox2.Controls.Add(Me.Fecha_de_RetornoDateTimePicker)
        Me.GroupBox2.Controls.Add(Fecha_de_RetornoLabel)
        Me.GroupBox2.Controls.Add(Fecha_FinalLabel)
        Me.GroupBox2.Controls.Add(Me.Fecha_FinalDateTimePicker)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(63, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 224)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'chkAmbas
        '
        Me.chkAmbas.AutoSize = True
        Me.chkAmbas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAmbas.ForeColor = System.Drawing.Color.White
        Me.chkAmbas.Location = New System.Drawing.Point(276, 58)
        Me.chkAmbas.Name = "chkAmbas"
        Me.chkAmbas.Size = New System.Drawing.Size(72, 21)
        Me.chkAmbas.TabIndex = 39
        Me.chkAmbas.TabStop = True
        Me.chkAmbas.Text = "Ambas"
        Me.chkAmbas.UseVisualStyleBackColor = True
        '
        'chkProfilactica
        '
        Me.chkProfilactica.AutoSize = True
        Me.chkProfilactica.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProfilactica.ForeColor = System.Drawing.Color.White
        Me.chkProfilactica.Location = New System.Drawing.Point(311, 31)
        Me.chkProfilactica.Name = "chkProfilactica"
        Me.chkProfilactica.Size = New System.Drawing.Size(98, 21)
        Me.chkProfilactica.TabIndex = 38
        Me.chkProfilactica.TabStop = True
        Me.chkProfilactica.Text = "Profilactica"
        Me.chkProfilactica.UseVisualStyleBackColor = True
        '
        'chkOrdinaria
        '
        Me.chkOrdinaria.AutoSize = True
        Me.chkOrdinaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrdinaria.ForeColor = System.Drawing.Color.White
        Me.chkOrdinaria.Location = New System.Drawing.Point(217, 30)
        Me.chkOrdinaria.Name = "chkOrdinaria"
        Me.chkOrdinaria.Size = New System.Drawing.Size(88, 21)
        Me.chkOrdinaria.TabIndex = 37
        Me.chkOrdinaria.TabStop = True
        Me.chkOrdinaria.Text = "Ordinaria"
        Me.chkOrdinaria.UseVisualStyleBackColor = True
        '
        'Cantidad_de_Dias_SolicitadosTXT
        '
        Me.Cantidad_de_Dias_SolicitadosTXT.Location = New System.Drawing.Point(329, 148)
        Me.Cantidad_de_Dias_SolicitadosTXT.Name = "Cantidad_de_Dias_SolicitadosTXT"
        Me.Cantidad_de_Dias_SolicitadosTXT.Size = New System.Drawing.Size(43, 30)
        Me.Cantidad_de_Dias_SolicitadosTXT.TabIndex = 4
        Me.Cantidad_de_Dias_SolicitadosTXT.Text = "0"
        Me.Cantidad_de_Dias_SolicitadosTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fecha_InicioDateTimePicker
        '
        Me.Fecha_InicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VacacionesBindingSource, "Fecha_Inicio", True))
        Me.Fecha_InicioDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_InicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_InicioDateTimePicker.Location = New System.Drawing.Point(146, 117)
        Me.Fecha_InicioDateTimePicker.Name = "Fecha_InicioDateTimePicker"
        Me.Fecha_InicioDateTimePicker.Size = New System.Drawing.Size(108, 27)
        Me.Fecha_InicioDateTimePicker.TabIndex = 5
        Me.Fecha_InicioDateTimePicker.Value = New Date(2022, 11, 2, 0, 0, 0, 0)
        '
        'Fecha_de_RetornoDateTimePicker
        '
        Me.Fecha_de_RetornoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VacacionesBindingSource, "Fecha_de_Retorno", True))
        Me.Fecha_de_RetornoDateTimePicker.Enabled = False
        Me.Fecha_de_RetornoDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_de_RetornoDateTimePicker.Location = New System.Drawing.Point(153, 185)
        Me.Fecha_de_RetornoDateTimePicker.MaxDate = New Date(2022, 11, 2, 0, 0, 0, 0)
        Me.Fecha_de_RetornoDateTimePicker.Name = "Fecha_de_RetornoDateTimePicker"
        Me.Fecha_de_RetornoDateTimePicker.Size = New System.Drawing.Size(272, 24)
        Me.Fecha_de_RetornoDateTimePicker.TabIndex = 5
        Me.Fecha_de_RetornoDateTimePicker.Value = New Date(2022, 11, 2, 0, 0, 0, 0)
        '
        'Fecha_FinalDateTimePicker
        '
        Me.Fecha_FinalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VacacionesBindingSource, "Fecha_Final", True))
        Me.Fecha_FinalDateTimePicker.Enabled = False
        Me.Fecha_FinalDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_FinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_FinalDateTimePicker.Location = New System.Drawing.Point(146, 153)
        Me.Fecha_FinalDateTimePicker.Name = "Fecha_FinalDateTimePicker"
        Me.Fecha_FinalDateTimePicker.Size = New System.Drawing.Size(108, 27)
        Me.Fecha_FinalDateTimePicker.TabIndex = 6
        Me.Fecha_FinalDateTimePicker.Value = New Date(2022, 11, 2, 0, 0, 0, 0)
        '
        'Cantidad_de_Días_DisponiblesTextBox
        '
        Me.Cantidad_de_Días_DisponiblesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cantidad_de_Días_DisponiblesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VacacionesBindingSource, "Cantidad_de_Días_Disponibles", True))
        Me.Cantidad_de_Días_DisponiblesTextBox.Location = New System.Drawing.Point(308, 101)
        Me.Cantidad_de_Días_DisponiblesTextBox.Name = "Cantidad_de_Días_DisponiblesTextBox"
        Me.Cantidad_de_Días_DisponiblesTextBox.Size = New System.Drawing.Size(100, 30)
        Me.Cantidad_de_Días_DisponiblesTextBox.TabIndex = 5
        '
        'Cantidad_de_días_de_vacacionesTextBox
        '
        Me.Cantidad_de_días_de_vacacionesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cantidad_de_días_de_vacacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VacacionesBindingSource, "Cantidad_de_días_de_vacaciones", True))
        Me.Cantidad_de_días_de_vacacionesTextBox.Location = New System.Drawing.Point(308, 65)
        Me.Cantidad_de_días_de_vacacionesTextBox.Name = "Cantidad_de_días_de_vacacionesTextBox"
        Me.Cantidad_de_días_de_vacacionesTextBox.Size = New System.Drawing.Size(100, 30)
        Me.Cantidad_de_días_de_vacacionesTextBox.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtPeriodo_Vacaciones)
        Me.GroupBox3.Controls.Add(Periodo_de_VacacionesLabel)
        Me.GroupBox3.Controls.Add(Cantidad_de_Días_DisponiblesLabel)
        Me.GroupBox3.Controls.Add(Tarjeta_de_AsistenciaLabel)
        Me.GroupBox3.Controls.Add(Me.Tarjeta_de_AsistenciaTextBox)
        Me.GroupBox3.Controls.Add(Me.Cantidad_de_Días_DisponiblesTextBox)
        Me.GroupBox3.Controls.Add(Cantidad_de_días_de_vacacionesLabel)
        Me.GroupBox3.Controls.Add(Me.Cantidad_de_días_de_vacacionesTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(843, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(453, 221)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'txtPeriodo_Vacaciones
        '
        Me.txtPeriodo_Vacaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VacacionesBindingSource, "Tarjeta_de_Asistencia", True))
        Me.txtPeriodo_Vacaciones.Location = New System.Drawing.Point(213, 165)
        Me.txtPeriodo_Vacaciones.Name = "txtPeriodo_Vacaciones"
        Me.txtPeriodo_Vacaciones.Size = New System.Drawing.Size(195, 30)
        Me.txtPeriodo_Vacaciones.TabIndex = 9
        '
        'Tarjeta_de_AsistenciaTextBox
        '
        Me.Tarjeta_de_AsistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VacacionesBindingSource, "Tarjeta_de_Asistencia", True))
        Me.Tarjeta_de_AsistenciaTextBox.Location = New System.Drawing.Point(213, 28)
        Me.Tarjeta_de_AsistenciaTextBox.Name = "Tarjeta_de_AsistenciaTextBox"
        Me.Tarjeta_de_AsistenciaTextBox.Size = New System.Drawing.Size(195, 30)
        Me.Tarjeta_de_AsistenciaTextBox.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnEliminar)
        Me.GroupBox4.Controls.Add(Me.BtnGuardar)
        Me.GroupBox4.Controls.Add(Label1)
        Me.GroupBox4.Controls.Add(Me.BtnNuevo)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(517, 328)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(779, 224)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserXmark
        Me.BtnEliminar.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEliminar.IconSize = 40
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(625, 158)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(148, 44)
        Me.BtnEliminar.TabIndex = 25
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnGuardar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.BtnGuardar.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnGuardar.IconSize = 40
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(625, 108)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(148, 44)
        Me.BtnGuardar.TabIndex = 27
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.BtnNuevo.IconColor = System.Drawing.Color.RoyalBlue
        Me.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnNuevo.IconSize = 40
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(625, 58)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(148, 44)
        Me.BtnNuevo.TabIndex = 24
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VacacionesBindingSource, "Observación", True))
        Me.TextBox1.Location = New System.Drawing.Point(16, 58)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(591, 147)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(440, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(613, 79)
        Me.GroupBox5.TabIndex = 23
        Me.GroupBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(117, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 43)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Asignar Vacaciones"
        '
        'VacacionesTableAdapter
        '
        Me.VacacionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PermisosTableAdapter = Nothing
        Me.TableAdapterManager.Registrar_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.Registro_de_EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_VacacionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VacacionesTableAdapter = Me.VacacionesTableAdapter
        '
        'DGvacaciones
        '
        Me.DGvacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGvacaciones.Location = New System.Drawing.Point(15, 568)
        Me.DGvacaciones.Name = "DGvacaciones"
        Me.DGvacaciones.RowHeadersWidth = 51
        Me.DGvacaciones.RowTemplate.Height = 24
        Me.DGvacaciones.Size = New System.Drawing.Size(1325, 319)
        Me.DGvacaciones.TabIndex = 24
        '
        'Vacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1382, 899)
        Me.Controls.Add(Me.DGvacaciones)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vacaciones"
        Me.Text = "Vacaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Control_de_VacacionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DGvacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btncerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Control_de_VacacionesDataSet As Control_de_VacacionesDataSet
    Friend WithEvents VacacionesBindingSource As BindingSource
    Friend WithEvents VacacionesTableAdapter As Control_de_VacacionesDataSetTableAdapters.VacacionesTableAdapter
    Friend WithEvents TableAdapterManager As Control_de_VacacionesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents IdentidadTXT As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Cantidad_de_Días_DisponiblesTextBox As TextBox
    Friend WithEvents Cantidad_de_días_de_vacacionesTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Tarjeta_de_AsistenciaTextBox As TextBox
    Friend WithEvents Fecha_de_RetornoDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_InicioDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents txtPeriodo_Vacaciones As TextBox
    Friend WithEvents btnIdentidad As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNombre As FontAwesome.Sharp.IconButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents DGvacaciones As DataGridView
    Friend WithEvents NombresTextBox As ComboBox
    Friend WithEvents FechaIngreso As DateTimePicker
    Friend WithEvents Cantidad_de_Dias_SolicitadosTXT As TextBox
    Friend WithEvents chkAmbas As RadioButton
    Friend WithEvents chkProfilactica As RadioButton
    Friend WithEvents chkOrdinaria As RadioButton
    Friend WithEvents Fecha_FinalDateTimePicker As DateTimePicker
End Class
