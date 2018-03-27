Public Class Nota_Evolucion

    Public fechaNota As String
    Public codigopac As String
    Private Sub Notas_EvolucionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Notas_EvolucionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Notas_EvolucionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Nota_Evolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Notas_EvolucionTableAdapter.Fill(Me.ConsultorioDataSet.Notas_Evolucion)

        FechaDateTimePicker.Value = fechaNota
        Codigo_PacienteTextBox.Text = codigopac

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NotaTextBox.Text <> "" Then

            If MsgBox("Está seguro de crear la Nota de Evolución?", vbOKCancel, "Confirmación") = vbOK Then

                Dim codigop, fechap, codigo
                codigop = Codigo_PacienteTextBox.Text
                fechap = FechaDateTimePicker.Value.ToShortDateString
                codigo = "NE-" & Format(FechaDateTimePicker.Value, "yyyy") & Format(FechaDateTimePicker.Value, "MM") & Format(FechaDateTimePicker.Value, "dd")
                fechap = Format(FechaDateTimePicker.Value, "dd/MM/yyyy")
                Try
                    Me.Validate()
                    Me.Notas_EvolucionBindingSource.EndEdit()
                    Me.Notas_EvolucionTableAdapter.InsertarNota(Codigo_Paciente:=Codigo_PacienteTextBox.Text, Fecha:=FechaDateTimePicker.Value, Tipo:="Nota de Evolución", Codigo_Documento:=codigo, Nota:=NotaTextBox.Text)
                    Me.Close()
                    Me.Dispose()
                    MsgBox("Nota Creada")
                    Agenda_Dia.Show()

                Catch ex As Exception
                    MsgBox("Error creando Nota de Evolución")
                End Try

            End If


        Else
            MsgBox("Debe llenar las Notas")
        End If
    End Sub
End Class