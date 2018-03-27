<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agendar_Cita
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim HoraLabel As System.Windows.Forms.Label
        Dim PacienteLabel As System.Windows.Forms.Label
        Dim Codigo_PacienteLabel As System.Windows.Forms.Label
        Dim EspecialistaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agendar_Cita))
        Me.CitasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CitasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HoraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PacienteComboBox = New System.Windows.Forms.ComboBox()
        Me.Codigo_PacienteTextBox = New System.Windows.Forms.TextBox()
        Me.EspecialistaComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CitasTableAdapter = New PhysioSoft.consultorioDataSetTableAdapters.CitasTableAdapter()
        Me.TableAdapterManager = New PhysioSoft.consultorioDataSetTableAdapters.TableAdapterManager()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New PhysioSoft.consultorioDataSetTableAdapters.PacientesTableAdapter()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New PhysioSoft.consultorioDataSetTableAdapters.UsuariosTableAdapter()
        FechaLabel = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        PacienteLabel = New System.Windows.Forms.Label()
        Codigo_PacienteLabel = New System.Windows.Forms.Label()
        EspecialistaLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CType(Me.CitasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CitasBindingNavigator.SuspendLayout()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultorioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(19, 135)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 3
        FechaLabel.Text = "Fecha:"
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Location = New System.Drawing.Point(278, 135)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(33, 13)
        HoraLabel.TabIndex = 5
        HoraLabel.Text = "Hora:"
        '
        'PacienteLabel
        '
        PacienteLabel.AutoSize = True
        PacienteLabel.Location = New System.Drawing.Point(19, 162)
        PacienteLabel.Name = "PacienteLabel"
        PacienteLabel.Size = New System.Drawing.Size(52, 13)
        PacienteLabel.TabIndex = 7
        PacienteLabel.Text = "Paciente:"
        '
        'Codigo_PacienteLabel
        '
        Codigo_PacienteLabel.AutoSize = True
        Codigo_PacienteLabel.Location = New System.Drawing.Point(19, 189)
        Codigo_PacienteLabel.Name = "Codigo_PacienteLabel"
        Codigo_PacienteLabel.Size = New System.Drawing.Size(88, 13)
        Codigo_PacienteLabel.TabIndex = 9
        Codigo_PacienteLabel.Text = "Codigo Paciente:"
        '
        'EspecialistaLabel
        '
        EspecialistaLabel.AutoSize = True
        EspecialistaLabel.Location = New System.Drawing.Point(19, 215)
        EspecialistaLabel.Name = "EspecialistaLabel"
        EspecialistaLabel.Size = New System.Drawing.Size(66, 13)
        EspecialistaLabel.TabIndex = 11
        EspecialistaLabel.Text = "Especialista:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(278, 189)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 13
        TipoLabel.Text = "Tipo:"
        '
        'CitasBindingNavigator
        '
        Me.CitasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CitasBindingNavigator.BindingSource = Me.CitasBindingSource
        Me.CitasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CitasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CitasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CitasBindingNavigatorSaveItem})
        Me.CitasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CitasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CitasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CitasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CitasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CitasBindingNavigator.Name = "CitasBindingNavigator"
        Me.CitasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CitasBindingNavigator.Size = New System.Drawing.Size(538, 25)
        Me.CitasBindingNavigator.TabIndex = 0
        Me.CitasBindingNavigator.Text = "BindingNavigator1"
        Me.CitasBindingNavigator.Visible = False
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
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "Citas"
        Me.CitasBindingSource.DataSource = Me.ConsultorioDataSet
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
        'CitasBindingNavigatorSaveItem
        '
        Me.CitasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CitasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CitasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CitasBindingNavigatorSaveItem.Name = "CitasBindingNavigatorSaveItem"
        Me.CitasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CitasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Checked = False
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CitasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(113, 131)
        Me.FechaDateTimePicker.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
        Me.FechaDateTimePicker.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(136, 20)
        Me.FechaDateTimePicker.TabIndex = 4
        '
        'HoraDateTimePicker
        '
        Me.HoraDateTimePicker.CustomFormat = "HH:mm"
        Me.HoraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CitasBindingSource, "Hora", True))
        Me.HoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HoraDateTimePicker.Location = New System.Drawing.Point(372, 131)
        Me.HoraDateTimePicker.Name = "HoraDateTimePicker"
        Me.HoraDateTimePicker.ShowUpDown = True
        Me.HoraDateTimePicker.Size = New System.Drawing.Size(136, 20)
        Me.HoraDateTimePicker.TabIndex = 6
        Me.HoraDateTimePicker.Value = New Date(2017, 11, 1, 0, 0, 0, 0)
        '
        'PacienteComboBox
        '
        Me.PacienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "Paciente", True))
        Me.PacienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PacienteComboBox.FormattingEnabled = True
        Me.PacienteComboBox.Location = New System.Drawing.Point(113, 159)
        Me.PacienteComboBox.Name = "PacienteComboBox"
        Me.PacienteComboBox.Size = New System.Drawing.Size(395, 21)
        Me.PacienteComboBox.TabIndex = 8
        '
        'Codigo_PacienteTextBox
        '
        Me.Codigo_PacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "Codigo_Paciente", True))
        Me.Codigo_PacienteTextBox.Location = New System.Drawing.Point(113, 186)
        Me.Codigo_PacienteTextBox.Name = "Codigo_PacienteTextBox"
        Me.Codigo_PacienteTextBox.ReadOnly = True
        Me.Codigo_PacienteTextBox.Size = New System.Drawing.Size(136, 20)
        Me.Codigo_PacienteTextBox.TabIndex = 10
        '
        'EspecialistaComboBox
        '
        Me.EspecialistaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "Especialista", True))
        Me.EspecialistaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EspecialistaComboBox.FormattingEnabled = True
        Me.EspecialistaComboBox.Location = New System.Drawing.Point(113, 212)
        Me.EspecialistaComboBox.Name = "EspecialistaComboBox"
        Me.EspecialistaComboBox.Size = New System.Drawing.Size(395, 21)
        Me.EspecialistaComboBox.TabIndex = 12
        '
        'TipoComboBox
        '
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "Tipo", True))
        Me.TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Location = New System.Drawing.Point(372, 186)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(136, 21)
        Me.TipoComboBox.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Crear Cita"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(407, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Crear Nueva Cita"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Me.CitasTableAdapter
        Me.TableAdapterManager.Notas_EvolucionTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PhysioSoft.consultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.ValoracionesTableAdapter = Nothing
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
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ConsultorioDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'Agendar_Cita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 301)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(HoraLabel)
        Me.Controls.Add(Me.HoraDateTimePicker)
        Me.Controls.Add(PacienteLabel)
        Me.Controls.Add(Me.PacienteComboBox)
        Me.Controls.Add(Codigo_PacienteLabel)
        Me.Controls.Add(Me.Codigo_PacienteTextBox)
        Me.Controls.Add(EspecialistaLabel)
        Me.Controls.Add(Me.EspecialistaComboBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoComboBox)
        Me.Controls.Add(Me.CitasBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agendar_Cita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agendar_Cita"
        CType(Me.CitasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CitasBindingNavigator.ResumeLayout(False)
        Me.CitasBindingNavigator.PerformLayout()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultorioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConsultorioDataSet As consultorioDataSet
    Friend WithEvents CitasBindingSource As BindingSource
    Friend WithEvents CitasTableAdapter As consultorioDataSetTableAdapters.CitasTableAdapter
    Friend WithEvents TableAdapterManager As consultorioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CitasBindingNavigator As BindingNavigator
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
    Friend WithEvents CitasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents HoraDateTimePicker As DateTimePicker
    Friend WithEvents PacienteComboBox As ComboBox
    Friend WithEvents Codigo_PacienteTextBox As TextBox
    Friend WithEvents EspecialistaComboBox As ComboBox
    Friend WithEvents TipoComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As consultorioDataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As consultorioDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
