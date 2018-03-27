Public Class Validar_Cita

    Public codigoP As String
    Public fechap As Date
    Public estadoc As String
    Public paciente As String



    Private Sub CitasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CitasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Validar_Cita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ConsultorioDataSet.Citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.ConsultorioDataSet.Citas)
        DateTimePicker1.Value = Today
        TextBox1.Text = ""
        TextBox2.Text = ""

        Button1.Visible = False
        Button2.Visible = False

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        ComboBox1.Items.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        Button1.Visible = False
        Button2.Visible = False


        Dim myDataTable = CitasTableAdapter.GetCita2(DateTimePicker1.Value.Date.ToShortDateString)
        For Each dataRow In myDataTable.Rows
            ComboBox1.Items.Add(dataRow.Paciente)
            'TextBox1.Text = dataRow.Codigo_Paciente
        Next dataRow


    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged


        Dim myDataTable = CitasTableAdapter.GetCitaPaciente(DateTimePicker1.Value.Date.ToShortDateString, ComboBox1.Text)
        For Each dataRow In myDataTable.Rows
            TextBox1.Text = dataRow.Codigo_Paciente
            TextBox2.Text = dataRow.Tipo
        Next dataRow

        If TextBox1.Text = "" Then
            Button1.Visible = False
            Button2.Visible = False
            paciente = ""
        Else
            Button1.Visible = True
            Button2.Visible = True
            paciente = ComboBox1.Text
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Está seguro de validar la cita del paciente: " & ComboBox1.Text, vbOKCancel, "Confirmación") = vbOK Then
            codigoP = TextBox1.Text
            fechap = DateTimePicker1.Value.ToShortDateString
            estadoc = TextBox2.Text

            Try
                Me.Validate()
                Me.CitasBindingSource.EndEdit()
                Me.CitasTableAdapter.UpdateEstado(Original_Fecha:=fechap, Estado:="Asistió", Original_Codigo_Paciente:=codigoP)
                Me.Close()
                Me.Dispose()

                If estadoc = "Intervención" Then
                    Nota_Evolucion.fechaNota = fechap
                    Nota_Evolucion.codigopac = codigoP
                    Nota_Evolucion.Show()
                End If

                If estadoc = "Valoración" Then
                    Valoraciones.nombrepaciente = paciente
                    Valoraciones.Show()
                End If

            Catch ex As Exception
                MsgBox("Error creando Usuario")
                End Try




        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Me.Dispose()
        Agenda_Dia.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Está seguro de validar la cita del paciente: " & ComboBox1.Text, vbOKCancel, "Confirmación") = vbOK Then
            codigoP = TextBox1.Text
            fechap = DateTimePicker1.Value.ToShortDateString
            estadoc = TextBox2.Text

            Try
                Me.Validate()
                Me.CitasBindingSource.EndEdit()
                Me.CitasTableAdapter.UpdateEstado(Original_Fecha:=fechap, Estado:="No Asistió", Original_Codigo_Paciente:=codigoP)
                Me.Close()
                Me.Dispose()

                Agenda_Dia.Show()

            Catch ex As Exception
                MsgBox("Error creando Usuario")
            End Try




        End If
    End Sub
End Class