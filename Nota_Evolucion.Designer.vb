<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nota_Evolucion
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
        Dim Codigo_PacienteLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim NotaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nota_Evolucion))
        Me.Notas_EvolucionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Notas_EvolucionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Notas_EvolucionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Codigo_PacienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Notas_EvolucionTableAdapter = New PhysioSoft.consultorioDataSetTableAdapters.Notas_EvolucionTableAdapter()
        Me.TableAdapterManager = New PhysioSoft.consultorioDataSetTableAdapters.TableAdapterManager()
        Me.NotaTextBox = New System.Windows.Forms.TextBox()
        Codigo_PacienteLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        NotaLabel = New System.Windows.Forms.Label()
        CType(Me.Notas_EvolucionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Notas_EvolucionBindingNavigator.SuspendLayout()
        CType(Me.Notas_EvolucionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultorioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Codigo_PacienteLabel
        '
        Codigo_PacienteLabel.AutoSize = True
        Codigo_PacienteLabel.Location = New System.Drawing.Point(12, 72)
        Codigo_PacienteLabel.Name = "Codigo_PacienteLabel"
        Codigo_PacienteLabel.Size = New System.Drawing.Size(88, 13)
        Codigo_PacienteLabel.TabIndex = 3
        Codigo_PacienteLabel.Text = "Codigo Paciente:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(12, 99)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "Fecha:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(12, 124)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 7
        TipoLabel.Text = "Tipo:"
        '
        'NotaLabel
        '
        NotaLabel.AutoSize = True
        NotaLabel.Location = New System.Drawing.Point(12, 151)
        NotaLabel.Name = "NotaLabel"
        NotaLabel.Size = New System.Drawing.Size(33, 13)
        NotaLabel.TabIndex = 11
        NotaLabel.Text = "Nota:"
        '
        'Notas_EvolucionBindingNavigator
        '
        Me.Notas_EvolucionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Notas_EvolucionBindingNavigator.BindingSource = Me.Notas_EvolucionBindingSource
        Me.Notas_EvolucionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Notas_EvolucionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Notas_EvolucionBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Notas_EvolucionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Notas_EvolucionBindingNavigatorSaveItem})
        Me.Notas_EvolucionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Notas_EvolucionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Notas_EvolucionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Notas_EvolucionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Notas_EvolucionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Notas_EvolucionBindingNavigator.Name = "Notas_EvolucionBindingNavigator"
        Me.Notas_EvolucionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Notas_EvolucionBindingNavigator.Size = New System.Drawing.Size(600, 25)
        Me.Notas_EvolucionBindingNavigator.TabIndex = 0
        Me.Notas_EvolucionBindingNavigator.Text = "BindingNavigator1"
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
        'Notas_EvolucionBindingSource
        '
        Me.Notas_EvolucionBindingSource.DataMember = "Notas_Evolucion"
        Me.Notas_EvolucionBindingSource.DataSource = Me.ConsultorioDataSet
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
        'Notas_EvolucionBindingNavigatorSaveItem
        '
        Me.Notas_EvolucionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Notas_EvolucionBindingNavigatorSaveItem.Image = CType(resources.GetObject("Notas_EvolucionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Notas_EvolucionBindingNavigatorSaveItem.Name = "Notas_EvolucionBindingNavigatorSaveItem"
        Me.Notas_EvolucionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Notas_EvolucionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Codigo_PacienteTextBox
        '
        Me.Codigo_PacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Notas_EvolucionBindingSource, "Codigo_Paciente", True))
        Me.Codigo_PacienteTextBox.Location = New System.Drawing.Point(119, 69)
        Me.Codigo_PacienteTextBox.Name = "Codigo_PacienteTextBox"
        Me.Codigo_PacienteTextBox.ReadOnly = True
        Me.Codigo_PacienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Codigo_PacienteTextBox.TabIndex = 4
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Notas_EvolucionBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(119, 95)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 6
        Me.FechaDateTimePicker.Value = New Date(2018, 1, 22, 0, 0, 0, 0)
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Notas_EvolucionBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(119, 121)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.ReadOnly = True
        Me.TipoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TipoTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Location = New System.Drawing.Point(480, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 48)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Crear Nota de Evolución"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Notas_EvolucionTableAdapter
        '
        Me.Notas_EvolucionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.Notas_EvolucionTableAdapter = Me.Notas_EvolucionTableAdapter
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PhysioSoft.consultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.ValoracionesTableAdapter = Nothing
        '
        'NotaTextBox
        '
        Me.NotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Notas_EvolucionBindingSource, "Nota", True))
        Me.NotaTextBox.Location = New System.Drawing.Point(119, 148)
        Me.NotaTextBox.Multiline = True
        Me.NotaTextBox.Name = "NotaTextBox"
        Me.NotaTextBox.Size = New System.Drawing.Size(460, 252)
        Me.NotaTextBox.TabIndex = 12
        '
        'Nota_Evolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(600, 412)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Codigo_PacienteLabel)
        Me.Controls.Add(Me.Codigo_PacienteTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(NotaLabel)
        Me.Controls.Add(Me.NotaTextBox)
        Me.Controls.Add(Me.Notas_EvolucionBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "Nota_Evolucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota_Evolucion"
        CType(Me.Notas_EvolucionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Notas_EvolucionBindingNavigator.ResumeLayout(False)
        Me.Notas_EvolucionBindingNavigator.PerformLayout()
        CType(Me.Notas_EvolucionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultorioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConsultorioDataSet As consultorioDataSet
    Friend WithEvents Notas_EvolucionBindingSource As BindingSource
    Friend WithEvents Notas_EvolucionTableAdapter As consultorioDataSetTableAdapters.Notas_EvolucionTableAdapter
    Friend WithEvents TableAdapterManager As consultorioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Notas_EvolucionBindingNavigator As BindingNavigator
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
    Friend WithEvents Notas_EvolucionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Codigo_PacienteTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NotaTextBox As TextBox
End Class
