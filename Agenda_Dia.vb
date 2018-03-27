Public Class Agenda_Dia
    Private Sub CitasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CitasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Agenda_Dia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.CitasTableAdapter.Fill2(Me.ConsultorioDataSet.Citas, "01/01/1900", "Programada")
        Me.CitasTableAdapter.Fill3(Me.ConsultorioDataSet.Citas, "01/01/1900")
        'MonthCalendar1.SetDate(Today)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Agendar_Cita.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
        Principal.Show()
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim fechaprueba As Date
        fechaprueba = MonthCalendar1.SelectionRange.Start
        Label1.Text = fechaprueba
        'Me.CitasTableAdapter.Fill2(ConsultorioDataSet.Citas, fechaprueba, "Programada")
        Me.CitasTableAdapter.Fill3(ConsultorioDataSet.Citas, fechaprueba)


        Label3.Text = MonthCalendar1.SelectionRange.Start.ToLongDateString

    End Sub

    Private Sub Agenda_Dia_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Dim fechaprueba As Date
            fechaprueba = MonthCalendar1.SelectionRange.Start
            Label1.Text = fechaprueba
            'Me.CitasTableAdapter.Fill2(ConsultorioDataSet.Citas, fechaprueba, "Programada")
            Me.CitasTableAdapter.Fill3(ConsultorioDataSet.Citas, fechaprueba)

            Label3.Text = MonthCalendar1.SelectionRange.Start.ToLongDateString

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Validar_Cita.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Paciente_Nuevo2.Show()
    End Sub
End Class