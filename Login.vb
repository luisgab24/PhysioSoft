Public Class Login


    Public Role As String
    Public FullName As String



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ConsultorioDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ConsultorioDataSet.Usuarios)
        Usuario.Text = ""

    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            Dim entrar = Me.UsuariosTableAdapter.Validar(Usuario.Text, Contraseña.Text)
            Dim myDataTable = UsuariosTableAdapter.GetUsuario(Usuario.Text, Contraseña.Text)
            Me.UsuariosTableAdapter.FillUsuario(myDataTable, Usuario.Text, Contraseña.Text)

            If entrar <> 0 Then
                For Each dataRow In myDataTable.Rows
                    MsgBox("Bienvenid@:   " & dataRow.Nombre)

                    Role = dataRow.Role
                    FullName = dataRow.Nombre & "" & dataRow.Apellido
                Next dataRow

                Principal.Show()
                Me.Hide()
            Else
                MsgBox("Usuario o Contraseña Inválida, intente de nuevo")
            End If


        Catch ex As Exception
            MsgBox("ERROR DE CREDENCIALES")
        End Try

    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
        Principal.Close()
        Me.Dispose()
        End
    End Sub
End Class