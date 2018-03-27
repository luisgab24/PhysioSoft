Imports Microsoft.VisualBasic.PowerPacks.Printing

Imports Microsoft.Office.Interop.Word
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop

Public Class Valoraciones_Visualizar



    Public codigodoc As String
    Private Sub ValoracionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ValoracionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ValoracionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Valoraciones_Visualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultorioDataSet.Valoraciones' table. You can move, or remove it, as needed.
        Try
            Me.ValoracionesTableAdapter.FillbyCod(Me.ConsultorioDataSet.Valoraciones, codigodoc)
        Catch ex As Exception

        End Try

        If Dolor1TextBox.Text = "Si" Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If

        If Dolor2TextBox.Text = "Si" Then
            GroupBox3.Visible = True
            Dolor2TextBox.Visible = True
        Else
            GroupBox3.Visible = False
            Dolor2TextBox.Visible = False
            GroupBox3.Visible = False
        End If

        If Dolor3TextBox.Text = "Si" Then
            GroupBox4.Visible = True
            Dolor3TextBox.Visible = True
        Else
            GroupBox4.Visible = False
            Dolor3TextBox.Visible = False
        End If

        If Palpacion_DolorTextBox.Text = "Si" Then
            GroupBox5.Visible = True
        Else
            GroupBox5.Visible = False
        End If

        If Cicatriz_DolorTextBox.Text = "Si" Then
            GroupBox6.Visible = True
        Else
            GroupBox6.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    End Sub
End Class