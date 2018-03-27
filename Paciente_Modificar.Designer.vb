<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paciente_Modificar
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
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim Fecha_NacimientoLabel As System.Windows.Forms.Label
        Dim EntidadLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim BarrioLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim OcupacionLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Estado_CivilLabel As System.Windows.Forms.Label
        Dim Tipo_DocumentoLabel As System.Windows.Forms.Label
        Dim Numero_DocumentoLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Paciente_Modificar))
        Dim Codigo_PacienteLabel As System.Windows.Forms.Label
        Me.PacientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultorioDataSet = New PhysioSoft.consultorioDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PacientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_NacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EntidadTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.BarrioTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.OcupacionTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Estado_CivilComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipo_DocumentoComboBox = New System.Windows.Forms.ComboBox()
        Me.GeneroComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Numero_DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.PacientesTableAdapter = New PhysioSoft.consultorioDataSetTableAdapters.PacientesTableAdapter()
        Me.TableAdapterManager = New PhysioSoft.consultorioDataSetTableAdapters.TableAdapterManager()
        Me.Codigo_PacienteTextBox = New System.Windows.Forms.TextBox()
        ApellidoLabel = New System.Windows.Forms.Label()
        Fecha_NacimientoLabel = New System.Windows.Forms.Label()
        EntidadLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        BarrioLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        OcupacionLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Estado_CivilLabel = New System.Windows.Forms.Label()
        Tipo_DocumentoLabel = New System.Windows.Forms.Label()
        Numero_DocumentoLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Codigo_PacienteLabel = New System.Windows.Forms.Label()
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PacientesBindingNavigator.SuspendLayout()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultorioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(418, 100)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 37
        ApellidoLabel.Text = "Apellido:"
        '
        'Fecha_NacimientoLabel
        '
        Fecha_NacimientoLabel.AutoSize = True
        Fecha_NacimientoLabel.Location = New System.Drawing.Point(26, 174)
        Fecha_NacimientoLabel.Name = "Fecha_NacimientoLabel"
        Fecha_NacimientoLabel.Size = New System.Drawing.Size(96, 13)
        Fecha_NacimientoLabel.TabIndex = 45
        Fecha_NacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'EntidadLabel
        '
        EntidadLabel.AutoSize = True
        EntidadLabel.Location = New System.Drawing.Point(272, 177)
        EntidadLabel.Name = "EntidadLabel"
        EntidadLabel.Size = New System.Drawing.Size(46, 13)
        EntidadLabel.TabIndex = 47
        EntidadLabel.Text = "Entidad:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(507, 177)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 49
        CiudadLabel.Text = "Ciudad:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(26, 210)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 51
        DireccionLabel.Text = "Direccion:"
        '
        'BarrioLabel
        '
        BarrioLabel.AutoSize = True
        BarrioLabel.Location = New System.Drawing.Point(466, 213)
        BarrioLabel.Name = "BarrioLabel"
        BarrioLabel.Size = New System.Drawing.Size(37, 13)
        BarrioLabel.TabIndex = 53
        BarrioLabel.Text = "Barrio:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(26, 249)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 55
        TelefonoLabel.Text = "Telefono:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(418, 249)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 57
        CelularLabel.Text = "Celular:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(26, 288)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 59
        EmailLabel.Text = "Email:"
        '
        'OcupacionLabel
        '
        OcupacionLabel.AutoSize = True
        OcupacionLabel.Location = New System.Drawing.Point(418, 288)
        OcupacionLabel.Name = "OcupacionLabel"
        OcupacionLabel.Size = New System.Drawing.Size(62, 13)
        OcupacionLabel.TabIndex = 61
        OcupacionLabel.Text = "Ocupacion:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(26, 100)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 66
        NombreLabel.Text = "Nombre:"
        '
        'Estado_CivilLabel
        '
        Estado_CivilLabel.AutoSize = True
        Estado_CivilLabel.Location = New System.Drawing.Point(398, 137)
        Estado_CivilLabel.Name = "Estado_CivilLabel"
        Estado_CivilLabel.Size = New System.Drawing.Size(65, 13)
        Estado_CivilLabel.TabIndex = 75
        Estado_CivilLabel.Text = "Estado Civil:"
        '
        'Tipo_DocumentoLabel
        '
        Tipo_DocumentoLabel.AutoSize = True
        Tipo_DocumentoLabel.Location = New System.Drawing.Point(26, 137)
        Tipo_DocumentoLabel.Name = "Tipo_DocumentoLabel"
        Tipo_DocumentoLabel.Size = New System.Drawing.Size(89, 13)
        Tipo_DocumentoLabel.TabIndex = 69
        Tipo_DocumentoLabel.Text = "Tipo Documento:"
        '
        'Numero_DocumentoLabel
        '
        Numero_DocumentoLabel.AutoSize = True
        Numero_DocumentoLabel.Location = New System.Drawing.Point(207, 137)
        Numero_DocumentoLabel.Name = "Numero_DocumentoLabel"
        Numero_DocumentoLabel.Size = New System.Drawing.Size(44, 13)
        Numero_DocumentoLabel.TabIndex = 71
        Numero_DocumentoLabel.Text = "N. Doc:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(576, 138)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(45, 13)
        GeneroLabel.TabIndex = 73
        GeneroLabel.Text = "Genero:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(139, 64)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(43, 13)
        Label2.TabIndex = 77
        Label2.Text = "Buscar:"
        '
        'PacientesBindingNavigator
        '
        Me.PacientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PacientesBindingNavigator.BindingSource = Me.PacientesBindingSource
        Me.PacientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PacientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PacientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PacientesBindingNavigatorSaveItem})
        Me.PacientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PacientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PacientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PacientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PacientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PacientesBindingNavigator.Name = "PacientesBindingNavigator"
        Me.PacientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PacientesBindingNavigator.Size = New System.Drawing.Size(749, 25)
        Me.PacientesBindingNavigator.TabIndex = 0
        Me.PacientesBindingNavigator.Text = "BindingNavigator1"
        Me.PacientesBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.ConsultorioDataSet
        '
        'ConsultorioDataSet
        '
        Me.ConsultorioDataSet.DataSetName = "consultorioDataSet"
        Me.ConsultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PacientesBindingNavigatorSaveItem
        '
        Me.PacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PacientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PacientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PacientesBindingNavigatorSaveItem.Name = "PacientesBindingNavigatorSaveItem"
        Me.PacientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PacientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 24)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Editar Paciente Nuevo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(637, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 31)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(485, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 31)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(485, 97)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(244, 20)
        Me.ApellidoTextBox.TabIndex = 38
        '
        'Fecha_NacimientoDateTimePicker
        '
        Me.Fecha_NacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PacientesBindingSource, "Fecha_Nacimiento", True))
        Me.Fecha_NacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_NacimientoDateTimePicker.Location = New System.Drawing.Point(137, 170)
        Me.Fecha_NacimientoDateTimePicker.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Fecha_NacimientoDateTimePicker.Name = "Fecha_NacimientoDateTimePicker"
        Me.Fecha_NacimientoDateTimePicker.Size = New System.Drawing.Size(128, 20)
        Me.Fecha_NacimientoDateTimePicker.TabIndex = 46
        Me.Fecha_NacimientoDateTimePicker.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'EntidadTextBox
        '
        Me.EntidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Entidad", True))
        Me.EntidadTextBox.Location = New System.Drawing.Point(335, 174)
        Me.EntidadTextBox.Name = "EntidadTextBox"
        Me.EntidadTextBox.Size = New System.Drawing.Size(155, 20)
        Me.EntidadTextBox.TabIndex = 48
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(561, 171)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(168, 20)
        Me.CiudadTextBox.TabIndex = 50
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(137, 207)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(309, 20)
        Me.DireccionTextBox.TabIndex = 52
        '
        'BarrioTextBox
        '
        Me.BarrioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Barrio", True))
        Me.BarrioTextBox.Location = New System.Drawing.Point(529, 210)
        Me.BarrioTextBox.Name = "BarrioTextBox"
        Me.BarrioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BarrioTextBox.TabIndex = 54
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(137, 246)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonoTextBox.TabIndex = 56
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(529, 246)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CelularTextBox.TabIndex = 58
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(137, 285)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 60
        '
        'OcupacionTextBox
        '
        Me.OcupacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Ocupacion", True))
        Me.OcupacionTextBox.Location = New System.Drawing.Point(529, 285)
        Me.OcupacionTextBox.Name = "OcupacionTextBox"
        Me.OcupacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OcupacionTextBox.TabIndex = 62
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(137, 97)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(262, 20)
        Me.NombreTextBox.TabIndex = 67
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(187, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 68
        '
        'Estado_CivilComboBox
        '
        Me.Estado_CivilComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Estado_Civil", True))
        Me.Estado_CivilComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Estado_CivilComboBox.FormattingEnabled = True
        Me.Estado_CivilComboBox.Location = New System.Drawing.Point(469, 134)
        Me.Estado_CivilComboBox.Name = "Estado_CivilComboBox"
        Me.Estado_CivilComboBox.Size = New System.Drawing.Size(101, 21)
        Me.Estado_CivilComboBox.TabIndex = 76
        '
        'Tipo_DocumentoComboBox
        '
        Me.Tipo_DocumentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Tipo_Documento", True))
        Me.Tipo_DocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo_DocumentoComboBox.FormattingEnabled = True
        Me.Tipo_DocumentoComboBox.Location = New System.Drawing.Point(137, 134)
        Me.Tipo_DocumentoComboBox.Name = "Tipo_DocumentoComboBox"
        Me.Tipo_DocumentoComboBox.Size = New System.Drawing.Size(55, 21)
        Me.Tipo_DocumentoComboBox.TabIndex = 70
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Genero", True))
        Me.GeneroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Location = New System.Drawing.Point(627, 133)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(102, 21)
        Me.GeneroComboBox.TabIndex = 74
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(380, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(278, 21)
        Me.ComboBox1.TabIndex = 78
        '
        'Numero_DocumentoTextBox
        '
        Me.Numero_DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Numero_Documento", True))
        Me.Numero_DocumentoTextBox.Location = New System.Drawing.Point(257, 135)
        Me.Numero_DocumentoTextBox.Name = "Numero_DocumentoTextBox"
        Me.Numero_DocumentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Numero_DocumentoTextBox.TabIndex = 79
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.Notas_EvolucionTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Me.PacientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = PhysioSoft.consultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.ValoracionesTableAdapter = Nothing
        '
        'Codigo_PacienteLabel
        '
        Codigo_PacienteLabel.AutoSize = True
        Codigo_PacienteLabel.Location = New System.Drawing.Point(26, 332)
        Codigo_PacienteLabel.Name = "Codigo_PacienteLabel"
        Codigo_PacienteLabel.Size = New System.Drawing.Size(88, 13)
        Codigo_PacienteLabel.TabIndex = 79
        Codigo_PacienteLabel.Text = "Codigo Paciente:"
        '
        'Codigo_PacienteTextBox
        '
        Me.Codigo_PacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Codigo_Paciente", True))
        Me.Codigo_PacienteTextBox.Location = New System.Drawing.Point(137, 329)
        Me.Codigo_PacienteTextBox.Name = "Codigo_PacienteTextBox"
        Me.Codigo_PacienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Codigo_PacienteTextBox.TabIndex = 80
        '
        'Paciente_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 380)
        Me.Controls.Add(Codigo_PacienteLabel)
        Me.Controls.Add(Me.Codigo_PacienteTextBox)
        Me.Controls.Add(Me.Numero_DocumentoTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Estado_CivilComboBox)
        Me.Controls.Add(Estado_CivilLabel)
        Me.Controls.Add(Tipo_DocumentoLabel)
        Me.Controls.Add(Me.Tipo_DocumentoComboBox)
        Me.Controls.Add(Numero_DocumentoLabel)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.GeneroComboBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Fecha_NacimientoLabel)
        Me.Controls.Add(Me.Fecha_NacimientoDateTimePicker)
        Me.Controls.Add(EntidadLabel)
        Me.Controls.Add(Me.EntidadTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(BarrioLabel)
        Me.Controls.Add(Me.BarrioTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(OcupacionLabel)
        Me.Controls.Add(Me.OcupacionTextBox)
        Me.Controls.Add(Me.PacientesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Paciente_Modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paciente_Modificar"
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PacientesBindingNavigator.ResumeLayout(False)
        Me.PacientesBindingNavigator.PerformLayout()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultorioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConsultorioDataSet As consultorioDataSet
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As consultorioDataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents TableAdapterManager As consultorioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PacientesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PacientesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents Fecha_NacimientoDateTimePicker As DateTimePicker
    Friend WithEvents EntidadTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents BarrioTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents OcupacionTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Estado_CivilComboBox As ComboBox
    Friend WithEvents Tipo_DocumentoComboBox As ComboBox
    Friend WithEvents GeneroComboBox As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Numero_DocumentoTextBox As TextBox
    Friend WithEvents Codigo_PacienteTextBox As TextBox
End Class
