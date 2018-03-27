Public Class Agendar_Cita
    Private Sub CitasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CitasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Agendar_Cita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsuariosTableAdapter.Fill(Me.ConsultorioDataSet.Usuarios)
        Me.PacientesTableAdapter.Fill(Me.ConsultorioDataSet.Pacientes)
        Me.CitasTableAdapter.Fill(Me.ConsultorioDataSet.Citas)

        'tipo de cita
        TipoComboBox.Items.Clear()
        TipoComboBox.Items.Add("")
        TipoComboBox.Items.Add("Intervención")
        TipoComboBox.Items.Add("Valoración")


        'Nombre Paciente
        PacienteComboBox.Items.Clear()
        PacienteComboBox.Items.Add("")
        Dim myDataTable = PacientesTableAdapter.GetPaciente()
        For Each dataRow In myDataTable.Rows
            PacienteComboBox.Items.Add(dataRow.Nombre_Completo)
        Next dataRow

        'Nombre Especialista
        EspecialistaComboBox.Items.Clear()
        EspecialistaComboBox.Items.Add("")
        Dim myDataTable2 = UsuariosTableAdapter.GetEspecialista("Fisioterapeuta")
        For Each dataRow In myDataTable2.Rows
            EspecialistaComboBox.Items.Add(dataRow.FullName)
        Next dataRow

        Me.CitasTableAdapter.Fill2(ConsultorioDataSet.Citas, "01/01/1900", "Programada")
        Dim fechaprueba As String
        fechaprueba = Today.ToLongDateString
        HoraDateTimePicker.Value = fechaprueba
        FechaDateTimePicker.Value = "01/01/2018"
        'HoraDateTimePicker.Value = "30/12/1899 12:00 AM"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
        Agenda_Dia.Show()
    End Sub

    Private Sub PacienteComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles PacienteComboBox.SelectedValueChanged
        If PacienteComboBox.Text <> "" Then


            Dim myDataTable = PacientesTableAdapter.GetCode(PacienteComboBox.Text)
            For Each dataRow In myDataTable.Rows
                Codigo_PacienteTextBox.Text = dataRow.Codigo_Paciente
            Next dataRow

        Else
            Codigo_PacienteTextBox.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If FechaDateTimePicker.Value.Date = "01/01/2018" Then
            MsgBox("Debe seleccionar una fecha válidad para la cita")
        Else

            If (HoraDateTimePicker.Value.Hour = "00" And HoraDateTimePicker.Value.Minute = "00") Then
                MsgBox("La hora deber ser diferente de las 00:00")
            Else

                If PacienteComboBox.Text = "" Or Codigo_PacienteTextBox.Text = "" Or TipoComboBox.Text = "" Or EspecialistaComboBox.Text = "" Then

                    MsgBox("Debe llenar todos los campos de la cita")
                Else

                    Dim hora, minuto, codigo
                    hora = Format(HoraDateTimePicker.Value, "HH")
                    minuto = Format(HoraDateTimePicker.Value, "mm")
                    codigo = "Cita" & Format(HoraDateTimePicker.Value, "yyyy") & Format(HoraDateTimePicker.Value, "MM") & Format(HoraDateTimePicker.Value, "dd")

                    If MsgBox("Está seguro que Crear  la cita del paciente: " & PacienteComboBox.Text & " la fecha: " & FechaDateTimePicker.Value.Date.ToLongDateString & " a la hora: " & hora & ":" & minuto, vbOKCancel, "Confirmación") = vbOK Then
                        Try
                            Me.CitasTableAdapter.CrearCita(Fecha:=FechaDateTimePicker.Value.Date, Hora:=(HoraDateTimePicker.Value.ToShortTimeString), Paciente:=PacienteComboBox.Text,
                                                   Codigo_Paciente:=Codigo_PacienteTextBox.Text, Especialista:=EspecialistaComboBox.Text, Tipo:=TipoComboBox.Text,
                                                   Estado:="Programada", Codigo_Documento:=codigo)
                            MsgBox("Cita creada Satisfactoriamente")
                            Me.Close()
                            Me.Dispose()
                            Agenda_Dia.Show()

                        Catch ex As Exception
                            MsgBox("Error creando cita")
                        End Try

                    End If
                End If

            End If
        End If

    End Sub
End Class