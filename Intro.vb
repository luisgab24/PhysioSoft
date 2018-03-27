Public NotInheritable Class Intro
    Private cuenta As Integer = 0
    Private Sub Intro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Timer1.Enabled = True
        Timer1.Interval = 10 '2000


        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try

            RectangleShape2.Width += 1
            If (RectangleShape2.Width >= 305) Then
                Timer1.Stop()
                Login.Show()
                Me.Hide()
                Timer1.Enabled = False
            End If

        Catch ex As Exception

        End Try

        'cuenta = cuenta + 1

        'If cuenta = 2 Then
        '    Dim Principal As New Principal
        '    Login.Show()
        '    Me.Hide()
        '    Timer1.Enabled = False
        'End If

    End Sub


End Class

