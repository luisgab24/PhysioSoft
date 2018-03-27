<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paciente_Nuevo2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Estado_CivilLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim Tipo_DocumentoLabel As System.Windows.Forms.Label
        Dim Numero_DocumentoLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim Fecha_NacimientoLabel As System.Windows.Forms.Label
        Dim EntidadLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim BarrioLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim OcupacionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Paciente_Nuevo2))
        Me.Estado_CivilComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_DocumentoComboBox = New System.Windows.Forms.ComboBox()
        Me.Numero_DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.GeneroComboBox = New System.Windows.Forms.ComboBox()
        Me.Fecha_NacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EntidadTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.BarrioTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.OcupacionTextBox = New System.Windows.Forms.TextBox()
        Me.ConsultorioDataSet = New PhysioSoft.consultorioDataSet()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New PhysioSoft.consultorioDataSetTableAdapters.PacientesTableAdapter()
        Me.TableAdapterManager = New PhysioSoft.consultorioDataSetTableAdapters.TableAdapterManager()
        Me.PacientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PacientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Estado_CivilLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        Tipo_DocumentoLabel = New System.Windows.Forms.Label()
        Numero_DocumentoLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        Fecha_NacimientoLabel = New System.Windows.Forms.Label()
        EntidadLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        BarrioLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        OcupacionLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultorioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PacientesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Estado_CivilLabel
        '
        Estado_CivilLabel.AutoSize = True
        Estado_CivilLabel.Location = New System.Drawing.Point(397, 118)
        Estado_CivilLabel.Name = "Estado_CivilLabel"
        Estado_CivilLabel.Size = New System.Drawing.Size(65, 13)
        Estado_CivilLabel.TabIndex = 68
        Estado_CivilLabel.Text = "Estado Civil:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(25, 84)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 36
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(417, 84)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 38
        ApellidoLabel.Text = "Apellido:"
        '
        'Tipo_DocumentoLabel
        '
        Tipo_DocumentoLabel.AutoSize = True
        Tipo_DocumentoLabel.Location = New System.Drawing.Point(25, 118)
        Tipo_DocumentoLabel.Name = "Tipo_DocumentoLabel"
        Tipo_DocumentoLabel.Size = New System.Drawing.Size(89, 13)
        Tipo_DocumentoLabel.TabIndex = 40
        Tipo_DocumentoLabel.Text = "Tipo Documento:"
        '
        'Numero_DocumentoLabel
        '
        Numero_DocumentoLabel.AutoSize = True
        Numero_DocumentoLabel.Location = New System.Drawing.Point(206, 118)
        Numero_DocumentoLabel.Name = "Numero_DocumentoLabel"
        Numero_DocumentoLabel.Size = New System.Drawing.Size(79, 13)
        Numero_DocumentoLabel.TabIndex = 42
        Numero_DocumentoLabel.Text = "N. Documento:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(575, 119)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(45, 13)
        GeneroLabel.TabIndex = 44
        GeneroLabel.Text = "Genero:"
        '
        'Fecha_NacimientoLabel
        '
        Fecha_NacimientoLabel.AutoSize = True
        Fecha_NacimientoLabel.Location = New System.Drawing.Point(25, 158)
        Fecha_NacimientoLabel.Name = "Fecha_NacimientoLabel"
        Fecha_NacimientoLabel.Size = New System.Drawing.Size(96, 13)
        Fecha_NacimientoLabel.TabIndex = 46
        Fecha_NacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'EntidadLabel
        '
        EntidadLabel.AutoSize = True
        EntidadLabel.Location = New System.Drawing.Point(271, 161)
        EntidadLabel.Name = "EntidadLabel"
        EntidadLabel.Size = New System.Drawing.Size(46, 13)
        EntidadLabel.TabIndex = 48
        EntidadLabel.Text = "Entidad:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(506, 161)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 50
        CiudadLabel.Text = "Ciudad:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(25, 194)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 52
        DireccionLabel.Text = "Direccion:"
        '
        'BarrioLabel
        '
        BarrioLabel.AutoSize = True
        BarrioLabel.Location = New System.Drawing.Point(465, 197)
        BarrioLabel.Name = "BarrioLabel"
        BarrioLabel.Size = New System.Drawing.Size(37, 13)
        BarrioLabel.TabIndex = 54
        BarrioLabel.Text = "Barrio:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(25, 233)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 56
        TelefonoLabel.Text = "Telefono:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(417, 233)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 58
        CelularLabel.Text = "Celular:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(25, 272)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 60
        EmailLabel.Text = "Email:"
        '
        'OcupacionLabel
        '
        OcupacionLabel.AutoSize = True
        OcupacionLabel.Location = New System.Drawing.Point(417, 272)
        OcupacionLabel.Name = "OcupacionLabel"
        OcupacionLabel.Size = New System.Drawing.Size(62, 13)
        OcupacionLabel.TabIndex = 62
        OcupacionLabel.Text = "Ocupacion:"
        '
        'Estado_CivilComboBox
        '
        Me.Estado_CivilComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Estado_CivilComboBox.FormattingEnabled = True
        Me.Estado_CivilComboBox.Location = New System.Drawing.Point(468, 115)
        Me.Estado_CivilComboBox.Name = "Estado_CivilComboBox"
        Me.Estado_CivilComboBox.Size = New System.Drawing.Size(101, 21)
        Me.Estado_CivilComboBox.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 24)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Crear Paciente Nuevo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(653, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(260, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(136, 81)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(243, 20)
        Me.NombreTextBox.TabIndex = 37
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.Location = New System.Drawing.Point(484, 81)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(244, 20)
        Me.ApellidoTextBox.TabIndex = 39
        '
        'Tipo_DocumentoComboBox
        '
        Me.Tipo_DocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo_DocumentoComboBox.FormattingEnabled = True
        Me.Tipo_DocumentoComboBox.Location = New System.Drawing.Point(136, 115)
        Me.Tipo_DocumentoComboBox.Name = "Tipo_DocumentoComboBox"
        Me.Tipo_DocumentoComboBox.Size = New System.Drawing.Size(55, 21)
        Me.Tipo_DocumentoComboBox.TabIndex = 41
        '
        'Numero_DocumentoTextBox
        '
        Me.Numero_DocumentoTextBox.Location = New System.Drawing.Point(291, 116)
        Me.Numero_DocumentoTextBox.Name = "Numero_DocumentoTextBox"
        Me.Numero_DocumentoTextBox.Size = New System.Drawing.Size(103, 20)
        Me.Numero_DocumentoTextBox.TabIndex = 43
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Location = New System.Drawing.Point(626, 114)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(102, 21)
        Me.GeneroComboBox.TabIndex = 45
        '
        'Fecha_NacimientoDateTimePicker
        '
        Me.Fecha_NacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_NacimientoDateTimePicker.Location = New System.Drawing.Point(136, 154)
        Me.Fecha_NacimientoDateTimePicker.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Fecha_NacimientoDateTimePicker.Name = "Fecha_NacimientoDateTimePicker"
        Me.Fecha_NacimientoDateTimePicker.Size = New System.Drawing.Size(128, 20)
        Me.Fecha_NacimientoDateTimePicker.TabIndex = 47
        Me.Fecha_NacimientoDateTimePicker.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'EntidadTextBox
        '
        Me.EntidadTextBox.Location = New System.Drawing.Point(334, 158)
        Me.EntidadTextBox.Name = "EntidadTextBox"
        Me.EntidadTextBox.Size = New System.Drawing.Size(155, 20)
        Me.EntidadTextBox.TabIndex = 49
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.Location = New System.Drawing.Point(560, 155)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(168, 20)
        Me.CiudadTextBox.TabIndex = 51
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(136, 191)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(309, 20)
        Me.DireccionTextBox.TabIndex = 53
        '
        'BarrioTextBox
        '
        Me.BarrioTextBox.Location = New System.Drawing.Point(528, 194)
        Me.BarrioTextBox.Name = "BarrioTextBox"
        Me.BarrioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BarrioTextBox.TabIndex = 55
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(136, 230)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonoTextBox.TabIndex = 57
        '
        'CelularTextBox
        '
        Me.CelularTextBox.Location = New System.Drawing.Point(528, 230)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CelularTextBox.TabIndex = 59
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(136, 269)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 61
        '
        'OcupacionTextBox
        '
        Me.OcupacionTextBox.Location = New System.Drawing.Point(528, 269)
        Me.OcupacionTextBox.Name = "OcupacionTextBox"
        Me.OcupacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OcupacionTextBox.TabIndex = 63
        '
        'ConsultorioDataSet
        '
        Me.ConsultorioDataSet.DataSetName = "consultorioDataSet"
        Me.ConsultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.ConsultorioDataSet
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
        'Me.TableAdapterManager.Pacientes2TableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Me.PacientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = PhysioSoft.consultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.ValoracionesTableAdapter = Nothing
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
        Me.PacientesBindingNavigator.Size = New System.Drawing.Size(760, 25)
        Me.PacientesBindingNavigator.TabIndex = 70
        Me.PacientesBindingNavigator.Text = "BindingNavigator1"
        Me.PacientesBindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PacientesBindingNavigatorSaveItem
        '
        Me.PacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PacientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PacientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PacientesBindingNavigatorSaveItem.Name = "PacientesBindingNavigatorSaveItem"
        Me.PacientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PacientesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Paciente_Nuevo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 376)
        Me.Controls.Add(Me.PacientesBindingNavigator)
        Me.Controls.Add(Me.Estado_CivilComboBox)
        Me.Controls.Add(Estado_CivilLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Tipo_DocumentoLabel)
        Me.Controls.Add(Me.Tipo_DocumentoComboBox)
        Me.Controls.Add(Numero_DocumentoLabel)
        Me.Controls.Add(Me.Numero_DocumentoTextBox)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.GeneroComboBox)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Paciente_Nuevo2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paciente_Nuevo2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultorioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PacientesBindingNavigator.ResumeLayout(False)
        Me.PacientesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Estado_CivilComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents Tipo_DocumentoComboBox As ComboBox
    Friend WithEvents Numero_DocumentoTextBox As TextBox
    Friend WithEvents GeneroComboBox As ComboBox
    Friend WithEvents Fecha_NacimientoDateTimePicker As DateTimePicker
    Friend WithEvents EntidadTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents BarrioTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents OcupacionTextBox As TextBox
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
End Class
