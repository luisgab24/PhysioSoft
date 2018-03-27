Public Class Agenda
    Private Sub MonthCalendar1_BackColorChanged(sender As Object, e As EventArgs) Handles MonthCalendar1.BackColorChanged

    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim fechaprueba As Date
        fechaprueba = MonthCalendar1.SelectionRange.Start
        Label1.Text = fechaprueba
        'devuelve el dia de la semana de 1 a 7 : Dim dia = (Weekday(fechaprueba, vbUseSystem) - 1)

        'llamar función primer dia de la semana: GetDayBefore(DayOfWeek.Sunday, fechaprueba)
        'Llamar funcion ultimo dia de la semana: GetDayAfter(DayOfWeek.Monday, fechaprueba)

        'suma un dia al primer dia de la semana porque la función retorna el dia anterior de la semana
        Dim primerdia As Date = DateAdd(DateInterval.Day, 1, GetDayBefore(DayOfWeek.Sunday, fechaprueba))
        Dim ultimodia As Date = DateAdd(DateInterval.Day, -1, GetDayAfter(DayOfWeek.Monday, fechaprueba))
        Label2.Text = primerdia
        Label3.Text = ultimodia

    End Sub

    Private Function GetDayBefore(ByVal day As DayOfWeek, ByVal start As Date) As Date

        Dim returnDate As Date = New Date(start.Ticks)

        Do
            returnDate = returnDate.Subtract(TimeSpan.FromDays(1))
        Loop Until returnDate.DayOfWeek = day

        Return returnDate
    End Function

    Private Function GetDayAfter(ByVal day As DayOfWeek, ByVal start As Date) As Date

        Dim returnDate As Date = start

        Do
            returnDate = returnDate.AddDays(1)
        Loop Until returnDate.DayOfWeek = day

        Return returnDate
    End Function

    Private Sub CitasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CitasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ConsultorioDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.Fill(Me.ConsultorioDataSet.Pacientes)
        'TODO: esta línea de código carga datos en la tabla 'ConsultorioDataSet.Citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.ConsultorioDataSet.Citas)

    End Sub
End Class