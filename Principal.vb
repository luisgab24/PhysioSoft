Public Class Principal


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Historia_Clinica.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Principal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Me.Dispose()
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Agenda_Dia.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) 
        Editor.Show()
    End Sub
End Class