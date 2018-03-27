Public Class Valoraciones_Visualizar

    Public codigodoc As String
    Private Sub ValoracionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ValoracionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ValoracionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Valoraciones_Visualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultorioDataSet.Valoraciones' table. You can move, or remove it, as needed.
        Me.ValoracionesTableAdapter.FillbyCod(Me.ConsultorioDataSet.Valoraciones, codigodoc)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class