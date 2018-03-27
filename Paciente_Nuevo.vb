Public Class Paciente_Nuevo
    Private Sub PacientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PacientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PacientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Paciente_Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ConsultorioDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.Fill(Me.ConsultorioDataSet.Pacientes)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Fecha_NacimientoDateTimePicker.Value = "01/01/1900" Or NombreTextBox.Text = "" Or ApellidoTextBox.Text = "" Or
                GeneroComboBox.Text = "" Or Numero_DocumentoTextBox.Text = "" Or CiudadTextBox.Text = "" Or DireccionTextBox.Text = "" Or
                (TelefonoTextBox.Text = "" And CelularTextBox.Text = "") Or OcupacionTextBox.Text = "" Or Estado_CivilComboBox.Text = "" Then
            MsgBox("Debe llenar todos los datos necesarios")
        Else
            Dim codigo, FullName As String

            codigo = Tipo_DocumentoComboBox.Text & Numero_DocumentoTextBox.Text
            FullName = NombreTextBox.Text & " " & ApellidoTextBox.Text
            If MsgBox("Está seguro que Crear  el paciente: " & FullName & " con código: " & codigo, vbOKCancel, "Confirmación") = vbOK Then
                Try
                    Dim unico As Integer
                    unico = Me.PacientesTableAdapter.Existe_Paciente(codigo)

                    If unico > 0 Then
                        MsgBox("EL codigo de paciente ya existe, por favor verifique los datos")
                    Else
                        Me.PacientesTableAdapter.Insertar_Paciente(Nombre:=NombreTextBox.Text, Apellido:=ApellidoTextBox.Text, Tipo_Documento:=Tipo_DocumentoComboBox.Text, Numero_Documento:=Numero_DocumentoTextBox.Text,
                                                                   Genero:=GeneroComboBox.Text, Fecha_Nacimiento:=Fecha_NacimientoDateTimePicker.Value, Entidad:=EntidadTextBox.Text, Ciudad:=CiudadTextBox.Text, Direccion:=DireccionTextBox.Text,
                                                                   Barrio:=BarrioTextBox.Text, Telefono:=TelefonoTextBox.Text, Celular:=CelularTextBox.Text, Email:=EmailTextBox.Text, Ocupacion:=OcupacionTextBox.Text,
                                                                   Codigo_Paciente:=codigo, Nombre_Completo:=FullName, Estado_Civil:=Estado_CivilComboBox.Text, edad:="")
                        MsgBox("Usuario creado Satisfactoriamente")
                        Me.Close()
                        Me.Dispose()
                        Historia_Clinica.Show()
                    End If


                Catch ex As Exception
                    MsgBox("Error creando Usuario")
                End Try
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
        Historia_Clinica.Show()
    End Sub

    Private Sub Numero_DocumentoTextBox_TextChanged(sender As Object, e As EventArgs) Handles Numero_DocumentoTextBox.TextChanged

    End Sub

End Class