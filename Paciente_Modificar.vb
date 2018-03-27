Public Class Paciente_Modificar
    Private Sub PacientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PacientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PacientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Paciente_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ConsultorioDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
        'Me.PacientesTableAdapter.Fill(Me.ConsultorioDataSet.Pacientes)

        'a_F_frecuencia
        GeneroComboBox.Items.Clear()
        GeneroComboBox.Items.Add("")
        GeneroComboBox.Items.Add("Femenino")
        GeneroComboBox.Items.Add("Masculino")

        'a_F_frecuencia
        Tipo_DocumentoComboBox.Items.Clear()
        Tipo_DocumentoComboBox.Items.Add("")
        Tipo_DocumentoComboBox.Items.Add("CC")
        Tipo_DocumentoComboBox.Items.Add("TI")
        Tipo_DocumentoComboBox.Items.Add("CE")
        Tipo_DocumentoComboBox.Items.Add("RC")
        Tipo_DocumentoComboBox.Items.Add("NIT")

        'Estado_CivilComboBox
        Estado_CivilComboBox.Items.Clear()
        Estado_CivilComboBox.Items.Add("")
        Estado_CivilComboBox.Items.Add("Soltero")
        Estado_CivilComboBox.Items.Add("Casado")
        Estado_CivilComboBox.Items.Add("Union Libre")
        Estado_CivilComboBox.Items.Add("Separado")

        Me.PacientesTableAdapter.Fill2(ConsultorioDataSet.Pacientes, "")

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Me.PacientesTableAdapter.Fill2(ConsultorioDataSet.Pacientes, TextBox1.Text)
            'Me.PacientesTableAdapter.FillUsuarioCasi(ConsultorioDataSet.Pacientes, TextBox1.Text)

            ComboBox1.Items.Clear()
            Me.PacientesTableAdapter.Fill2(ConsultorioDataSet.Pacientes, "")

            Dim myDataTable = PacientesTableAdapter.GetUsuarioCasi(TextBox1.Text)
            For Each dataRow In myDataTable.Rows
                ComboBox1.Items.Add(dataRow.Nombre_Completo)
            Next dataRow

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
        Historia_Clinica.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Fecha_NacimientoDateTimePicker.Value = "01/01/1900" Or NombreTextBox.Text = "" Or ApellidoTextBox.Text = "" Or
               GeneroComboBox.Text = "" Or Numero_DocumentoTextBox.Text = "" Or CiudadTextBox.Text = "" Or DireccionTextBox.Text = "" Or
               (TelefonoTextBox.Text = "" And CelularTextBox.Text = "") Or OcupacionTextBox.Text = "" Or Estado_CivilComboBox.Text = "" Then
            MsgBox("Debe llenar todos los datos necesarios")
        Else
            Dim codigo, FullName As String

            codigo = Tipo_DocumentoComboBox.Text & Numero_DocumentoTextBox.Text
            FullName = NombreTextBox.Text & " " & ApellidoTextBox.Text
            If MsgBox("Está seguro que Modificar el paciente: " & FullName & " con código: " & codigo, vbOKCancel, "Confirmación") = vbOK Then
                Try
                    'Dim unico As Integer
                    'unico = Me.PacientesTableAdapter.Existe_Paciente(codigo)
                    Me.Validate()
                    Me.PacientesBindingSource.EndEdit()
                    Me.PacientesTableAdapter.Update(Me.ConsultorioDataSet.Pacientes)
                    'Me.PacientesTableAdapter.UpdatePaciente(Nombre:=NombreTextBox.Text, Apellido:=ApellidoTextBox.Text, Tipo_Documento:=Tipo_DocumentoComboBox.Text, Numero_Documento:=Numero_DocumentoTextBox.Text,
                    'Genero:=GeneroComboBox.Text, Fecha_Nacimiento:=Fecha_NacimientoDateTimePicker.Value, Entidad:=EntidadTextBox.Text, Ciudad:=CiudadTextBox.Text, Direccion:=DireccionTextBox.Text,
                    'Barrio:=BarrioTextBox.Text, Telefono:=TelefonoTextBox.Text, Celular:=CelularTextBox.Text, Email:=EmailTextBox.Text, Ocupacion:=OcupacionTextBox.Text,
                    'Codigo_Paciente:=codigo, Nombre_Completo:=FullName, Estado_Civil:=Estado_CivilComboBox.Text, edad:="")
                    MsgBox("Usuario modificado Satisfactoriamente")
                    Me.Close()
                    Me.Dispose()
                    Historia_Clinica.Show()

                Catch ex As Exception
                    MsgBox("Error creando Usuario")
                End Try
            End If

        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Me.PacientesTableAdapter.FillPrueba(ConsultorioDataSet.Pacientes, ComboBox1.Text)

    End Sub


End Class