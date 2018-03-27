

Public Class Usuario_Consultar

    Private Sub PacientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PacientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PacientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Usuario_Consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.ValoracionesTableAdapter.Fill(Me.ConsultorioDataSet.Valoraciones)
            Me.PacientesTableAdapter.Fill(Me.ConsultorioDataSet.Pacientes)

        Catch ex As Exception
            MsgBox("error de cargue")
        End Try


        'codigo paciente
        Nombre_CompletoComboBox.Items.Clear()
        Dim myDataTable = PacientesTableAdapter.GetPaciente()
        For Each dataRow In myDataTable.Rows
            Nombre_CompletoComboBox.Items.Add(dataRow.Nombre_Completo)
        Next dataRow

        Me.ValoracionesTableAdapter.Fill2(ConsultorioDataSet.Valoraciones, "")
        Me.PacientesTableAdapter.Fill2(ConsultorioDataSet.Pacientes, "")

    End Sub

    Private Sub Nombre_CompletoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Nombre_CompletoComboBox.SelectedValueChanged

        If Nombre_CompletoComboBox.Text <> "" Then
            Dim myDataTable = PacientesTableAdapter.GetDatosPaciente(Nombre_CompletoComboBox.Text)
            For Each dataRow In myDataTable.Rows
                Codigo_PacienteTextBox.Text = dataRow.Codigo_Paciente
                GeneroTextBox.Text = dataRow.Genero
                DireccionTextBox.Text = dataRow.Direccion
                TelefonoTextBox.Text = dataRow.Telefono
                CelularTextBox.Text = dataRow.Celular
                EmailTextBox.Text = dataRow.Email
                OcupacionTextBox.Text = dataRow.Ocupacion

            Next dataRow

            Dim myDataTable2 = Me.ValoracionesTableAdapter.GetPrueba(Codigo_PacienteTextBox.Text, Codigo_PacienteTextBox.Text, Codigo_PacienteTextBox.Text)
            Dim mydt3 = myDataTable2.DefaultView.ToTable(True, "Fecha", "Codigo_Documento", "Tipo")
            DataGridView1.DataSource = mydt3
            DataGridView1.Sort(DataGridView1.Columns("Fecha"), System.ComponentModel.ListSortDirection.Ascending)

        Else

            Me.PacientesTableAdapter.Fill2(ConsultorioDataSet.Pacientes, "")
            Me.ValoracionesTableAdapter.Fill2(ConsultorioDataSet.Valoraciones, "")

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()
        Historia_Clinica.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim cod2 As String = Convert.ToString(DataGridView1.CurrentRow.Cells(1).Value)
        Dim tipo As String = Convert.ToString(DataGridView1.CurrentRow.Cells(2).Value)

        If tipo = "Valoración" Then
            Valoraciones_Visualizar.codigodoc = cod2
            Valoraciones_Visualizar.Show()

        End If

    End Sub

End Class