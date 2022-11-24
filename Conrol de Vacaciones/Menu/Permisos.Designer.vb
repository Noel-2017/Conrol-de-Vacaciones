<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Permisos
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
        Dim Fecha_de_PermisoLabel As System.Windows.Forms.Label
        Dim Tipo_de_PermisoLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim DesccripcioLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Permisos))
        Me.btncerrar = New FontAwesome.Sharp.IconButton()
        Me.Control_de_VacacionesDataSet = New Conrol_de_Vacaciones.Control_de_VacacionesDataSet()
        Me.PermisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisosTableAdapter = New Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.PermisosTableAdapter()
        Me.TableAdapterManager = New Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Id_Identidad = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Registro_de_EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_de_PermisoTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_de_PermisoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Registro_de_EmpleadosTableAdapter = New Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.Registro_de_EmpleadosTableAdapter()
        Me.DesccripcionTextBox = New System.Windows.Forms.TextBox()
        Me.DGPermisos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New FontAwesome.Sharp.IconButton()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New FontAwesome.Sharp.IconButton()
        Fecha_de_PermisoLabel = New System.Windows.Forms.Label()
        Tipo_de_PermisoLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        DesccripcioLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.Control_de_VacacionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Registro_de_EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fecha_de_PermisoLabel
        '
        Fecha_de_PermisoLabel.AutoSize = True
        Fecha_de_PermisoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_de_PermisoLabel.ForeColor = System.Drawing.Color.White
        Fecha_de_PermisoLabel.Location = New System.Drawing.Point(7, 203)
        Fecha_de_PermisoLabel.Name = "Fecha_de_PermisoLabel"
        Fecha_de_PermisoLabel.Size = New System.Drawing.Size(176, 25)
        Fecha_de_PermisoLabel.TabIndex = 27
        Fecha_de_PermisoLabel.Text = "Fecha de Permiso:"
        '
        'Tipo_de_PermisoLabel
        '
        Tipo_de_PermisoLabel.AutoSize = True
        Tipo_de_PermisoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tipo_de_PermisoLabel.ForeColor = System.Drawing.Color.White
        Tipo_de_PermisoLabel.Location = New System.Drawing.Point(9, 134)
        Tipo_de_PermisoLabel.Name = "Tipo_de_PermisoLabel"
        Tipo_de_PermisoLabel.Size = New System.Drawing.Size(160, 25)
        Tipo_de_PermisoLabel.TabIndex = 26
        Tipo_de_PermisoLabel.Text = "Tipo de Permiso:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombresLabel.ForeColor = System.Drawing.Color.White
        NombresLabel.Location = New System.Drawing.Point(11, 80)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(97, 25)
        NombresLabel.TabIndex = 31
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.ForeColor = System.Drawing.Color.White
        ApellidosLabel.Location = New System.Drawing.Point(436, 78)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(98, 25)
        ApellidosLabel.TabIndex = 32
        ApellidosLabel.Text = "Apellidos:"
        '
        'DesccripcioLabel
        '
        DesccripcioLabel.AutoSize = True
        DesccripcioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesccripcioLabel.ForeColor = System.Drawing.Color.White
        DesccripcioLabel.Location = New System.Drawing.Point(1047, 193)
        DesccripcioLabel.Name = "DesccripcioLabel"
        DesccripcioLabel.Size = New System.Drawing.Size(130, 25)
        DesccripcioLabel.TabIndex = 32
        DesccripcioLabel.Text = "Desccripcion:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(11, 30)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(119, 25)
        Label2.TabIndex = 38
        Label2.Text = "Id Identidad:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(11, 25)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(119, 25)
        Label1.TabIndex = 41
        Label1.Text = "Id Identidad:"
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = CType(resources.GetObject("btncerrar.BackgroundImage"), System.Drawing.Image)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btncerrar.IconColor = System.Drawing.Color.Black
        Me.btncerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btncerrar.Location = New System.Drawing.Point(-3, -4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(40, 40)
        Me.btncerrar.TabIndex = 17
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'Control_de_VacacionesDataSet
        '
        Me.Control_de_VacacionesDataSet.DataSetName = "Control_de_VacacionesDataSet"
        Me.Control_de_VacacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PermisosBindingSource
        '
        Me.PermisosBindingSource.DataMember = "Permisos"
        Me.PermisosBindingSource.DataSource = Me.Control_de_VacacionesDataSet
        '
        'PermisosTableAdapter
        '
        Me.PermisosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PermisosTableAdapter = Me.PermisosTableAdapter
        Me.TableAdapterManager.Registrar_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.Registro_de_EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_VacacionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Conrol_de_Vacaciones.Control_de_VacacionesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VacacionesTableAdapter = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.Id_Identidad)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(Fecha_de_PermisoLabel)
        Me.GroupBox1.Controls.Add(Me.Tipo_de_PermisoTextBox)
        Me.GroupBox1.Controls.Add(Me.Fecha_de_PermisoDateTimePicker)
        Me.GroupBox1.Controls.Add(Tipo_de_PermisoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(819, 254)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Id_Identidad
        '
        Me.Id_Identidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PermisosBindingSource, "Id_Identidad", True))
        Me.Id_Identidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_Identidad.Location = New System.Drawing.Point(189, 25)
        Me.Id_Identidad.Name = "Id_Identidad"
        Me.Id_Identidad.Size = New System.Drawing.Size(246, 30)
        Me.Id_Identidad.TabIndex = 40
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(540, 73)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(259, 30)
        Me.ApellidosTextBox.TabIndex = 33
        '
        'Registro_de_EmpleadosBindingSource
        '
        Me.Registro_de_EmpleadosBindingSource.DataMember = "Registro_de_Empleados"
        Me.Registro_de_EmpleadosBindingSource.DataSource = Me.Control_de_VacacionesDataSet
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_de_EmpleadosBindingSource, "Nombres", True))
        Me.NombresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombresTextBox.Location = New System.Drawing.Point(189, 75)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(241, 30)
        Me.NombresTextBox.TabIndex = 32
        '
        'Tipo_de_PermisoTextBox
        '
        Me.Tipo_de_PermisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PermisosBindingSource, "Tipo_de_Permiso", True))
        Me.Tipo_de_PermisoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo_de_PermisoTextBox.Location = New System.Drawing.Point(189, 129)
        Me.Tipo_de_PermisoTextBox.Name = "Tipo_de_PermisoTextBox"
        Me.Tipo_de_PermisoTextBox.Size = New System.Drawing.Size(163, 30)
        Me.Tipo_de_PermisoTextBox.TabIndex = 28
        '
        'Fecha_de_PermisoDateTimePicker
        '
        Me.Fecha_de_PermisoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PermisosBindingSource, "Fecha_de_Permiso", True))
        Me.Fecha_de_PermisoDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_de_PermisoDateTimePicker.Location = New System.Drawing.Point(189, 198)
        Me.Fecha_de_PermisoDateTimePicker.Name = "Fecha_de_PermisoDateTimePicker"
        Me.Fecha_de_PermisoDateTimePicker.Size = New System.Drawing.Size(362, 30)
        Me.Fecha_de_PermisoDateTimePicker.TabIndex = 30
        '
        'Registro_de_EmpleadosTableAdapter
        '
        Me.Registro_de_EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'DesccripcionTextBox
        '
        Me.DesccripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PermisosBindingSource, "Desccripcio", True))
        Me.DesccripcionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesccripcionTextBox.Location = New System.Drawing.Point(894, 237)
        Me.DesccripcionTextBox.Multiline = True
        Me.DesccripcionTextBox.Name = "DesccripcionTextBox"
        Me.DesccripcionTextBox.Size = New System.Drawing.Size(460, 217)
        Me.DesccripcionTextBox.TabIndex = 33
        Me.DesccripcionTextBox.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DGPermisos
        '
        Me.DGPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPermisos.Location = New System.Drawing.Point(69, 534)
        Me.DGPermisos.Name = "DGPermisos"
        Me.DGPermisos.RowHeadersWidth = 51
        Me.DGPermisos.RowTemplate.Height = 24
        Me.DGPermisos.Size = New System.Drawing.Size(1245, 333)
        Me.DGPermisos.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnBuscar)
        Me.GroupBox2.Controls.Add(Me.txtIdentidad)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(69, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(826, 74)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.BtnBuscar.Location = New System.Drawing.Point(441, 32)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(35, 30)
        Me.BtnBuscar.TabIndex = 40
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'txtIdentidad
        '
        Me.txtIdentidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PermisosBindingSource, "Id_Identidad", True))
        Me.txtIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentidad.Location = New System.Drawing.Point(179, 30)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(256, 30)
        Me.txtIdentidad.TabIndex = 39
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
        Me.BtnGuardar.Location = New System.Drawing.Point(545, 476)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(161, 52)
        Me.BtnGuardar.TabIndex = 39
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1382, 899)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGPermisos)
        Me.Controls.Add(Me.DesccripcionTextBox)
        Me.Controls.Add(DesccripcioLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Permisos"
        Me.Text = "Ausencias"
        CType(Me.Control_de_VacacionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Registro_de_EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents Control_de_VacacionesDataSet As Control_de_VacacionesDataSet
    Friend WithEvents PermisosBindingSource As BindingSource
    Friend WithEvents PermisosTableAdapter As Control_de_VacacionesDataSetTableAdapters.PermisosTableAdapter
    Friend WithEvents TableAdapterManager As Control_de_VacacionesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tipo_de_PermisoTextBox As TextBox
    Friend WithEvents Fecha_de_PermisoDateTimePicker As DateTimePicker
    Friend WithEvents Registro_de_EmpleadosBindingSource As BindingSource
    Friend WithEvents Registro_de_EmpleadosTableAdapter As Control_de_VacacionesDataSetTableAdapters.Registro_de_EmpleadosTableAdapter
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents DesccripcionTextBox As TextBox
    Friend WithEvents DGPermisos As DataGridView
    Friend WithEvents Id_Identidad As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents BtnGuardar As FontAwesome.Sharp.IconButton
End Class
