Imports Microsoft.Office.Interop.Word
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop

Public Class Valoraciones



    Public nombrepaciente As String
    Dim codigo As String
    Private Sub ValoracionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ValoracionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ValoracionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub

    Private Sub Valoraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PacientesTableAdapter.Fill(Me.ConsultorioDataSet.Pacientes)
        Me.ValoracionesTableAdapter.Fill(Me.ConsultorioDataSet.Valoraciones)
        Button2.Visible = False
        'codigo paciente
        Nombre_CompletoComboBox.Items.Clear()
        Dim myDataTable = PacientesTableAdapter.GetPaciente()
        For Each dataRow In myDataTable.Rows
            Nombre_CompletoComboBox.Items.Add(dataRow.Nombre_Completo)
        Next dataRow


        'a_F_frecuencia
        A_F_FrecuenciaComboBox.Items.Clear()
        A_F_FrecuenciaComboBox.Items.Add("")
        A_F_FrecuenciaComboBox.Items.Add("Diaria")
        A_F_FrecuenciaComboBox.Items.Add("Dia por medio")
        A_F_FrecuenciaComboBox.Items.Add("Cada tercer dia")
        A_F_FrecuenciaComboBox.Items.Add("Semanal")
        A_F_FrecuenciaComboBox.Items.Add("Quincenal")
        A_F_FrecuenciaComboBox.Items.Add("Mensual")

        'Dolor_Frecuencia1ComboBox
        Dolor_Frecuencia1ComboBox.Items.Clear()
        Dolor_Frecuencia1ComboBox.Items.Add("")
        Dolor_Frecuencia1ComboBox.Items.Add("Intermitente")
        Dolor_Frecuencia1ComboBox.Items.Add("Continua")
        'Dolor_Frecuencia2ComboBox
        Dolor_Frecuencia2ComboBox.Items.Clear()
        Dolor_Frecuencia2ComboBox.Items.Add("")
        Dolor_Frecuencia2ComboBox.Items.Add("Intermitente")
        Dolor_Frecuencia2ComboBox.Items.Add("Continua")
        'Dolor_Frecuencia3ComboBox
        Dolor_Frecuencia3ComboBox.Items.Clear()
        Dolor_Frecuencia3ComboBox.Items.Add("")
        Dolor_Frecuencia3ComboBox.Items.Add("Intermitente")
        Dolor_Frecuencia3ComboBox.Items.Add("Continua")
        'Palpacion_Dolor_FrecuenciaComboBox
        Palpacion_Dolor_FrecuenciaComboBox.Items.Clear()
        Palpacion_Dolor_FrecuenciaComboBox.Items.Add("")
        Palpacion_Dolor_FrecuenciaComboBox.Items.Add("Intermitente")
        Palpacion_Dolor_FrecuenciaComboBox.Items.Add("Continua")
        'Cicatriz_Dolor_FrecuenciaComboBox
        Cicatriz_Dolor_FrecuenciaComboBox.Items.Clear()
        Cicatriz_Dolor_FrecuenciaComboBox.Items.Add("")
        Cicatriz_Dolor_FrecuenciaComboBox.Items.Add("Intermitente")
        Cicatriz_Dolor_FrecuenciaComboBox.Items.Add("Continua")


        'Dolor_Tipo1ComboBox
        Dolor_Tipo1ComboBox.Items.Clear()
        Dolor_Tipo1ComboBox.Items.Add("")
        Dolor_Tipo1ComboBox.Items.Add("Irradiado")
        Dolor_Tipo1ComboBox.Items.Add("Tensión")
        Dolor_Tipo1ComboBox.Items.Add("Tirante")
        Dolor_Tipo1ComboBox.Items.Add("Neuropático")
        Dolor_Tipo1ComboBox.Items.Add("Somático")
        Dolor_Tipo1ComboBox.Items.Add("Punzante")
        Dolor_Tipo1ComboBox.Items.Add("Quemante")
        Dolor_Tipo1ComboBox.Items.Add("Vasculogénico")
        'Dolor_Tipo2ComboBox
        Dolor_Tipo2ComboBox.Items.Clear()
        Dolor_Tipo2ComboBox.Items.Add("")
        Dolor_Tipo2ComboBox.Items.Add("Irradiado")
        Dolor_Tipo2ComboBox.Items.Add("Tensión")
        Dolor_Tipo2ComboBox.Items.Add("Tirante")
        Dolor_Tipo2ComboBox.Items.Add("Neuropático")
        Dolor_Tipo2ComboBox.Items.Add("Somático")
        Dolor_Tipo2ComboBox.Items.Add("Punzante")
        Dolor_Tipo2ComboBox.Items.Add("Quemante")
        Dolor_Tipo2ComboBox.Items.Add("Vasculogénico")
        'Dolor_Tipo3ComboBox
        Dolor_Tipo3ComboBox.Items.Clear()
        Dolor_Tipo3ComboBox.Items.Add("")
        Dolor_Tipo3ComboBox.Items.Add("Irradiado")
        Dolor_Tipo3ComboBox.Items.Add("Tensión")
        Dolor_Tipo3ComboBox.Items.Add("Tirante")
        Dolor_Tipo3ComboBox.Items.Add("Neuropático")
        Dolor_Tipo3ComboBox.Items.Add("Somático")
        Dolor_Tipo3ComboBox.Items.Add("Punzante")
        Dolor_Tipo3ComboBox.Items.Add("Quemante")
        Dolor_Tipo3ComboBox.Items.Add("Vasculogénico")
        'Palpacion_Dolor_TipoComboBox
        Palpacion_Dolor_TipoComboBox.Items.Clear()
        Palpacion_Dolor_TipoComboBox.Items.Add("")
        Palpacion_Dolor_TipoComboBox.Items.Add("Irradiado")
        Palpacion_Dolor_TipoComboBox.Items.Add("Tensión")
        Palpacion_Dolor_TipoComboBox.Items.Add("Tirante")
        Palpacion_Dolor_TipoComboBox.Items.Add("Neuropático")
        Palpacion_Dolor_TipoComboBox.Items.Add("Somático")
        Palpacion_Dolor_TipoComboBox.Items.Add("Punzante")
        Palpacion_Dolor_TipoComboBox.Items.Add("Quemante")
        Palpacion_Dolor_TipoComboBox.Items.Add("Vasculogénico")
        'CicatrizComboBox
        CicatrizComboBox.Items.Clear()
        CicatrizComboBox.Items.Add("")
        CicatrizComboBox.Items.Add("Presenta")
        CicatrizComboBox.Items.Add("No Presenta")
        'Cicatriz_Dolor_TipoComboBox
        Cicatriz_Dolor_TipoComboBox.Items.Clear()
        Cicatriz_Dolor_TipoComboBox.Items.Add("")
        Cicatriz_Dolor_TipoComboBox.Items.Add("Irradiado")
        Cicatriz_Dolor_TipoComboBox.Items.Add("Tensión")
        Cicatriz_Dolor_TipoComboBox.Items.Add("Tirante")
        Cicatriz_Dolor_TipoComboBox.Items.Add("Neuropático")
        Cicatriz_Dolor_TipoComboBox.Items.Add("Somático")
        Cicatriz_Dolor_TipoComboBox.Items.Add("Punzante")
        Cicatriz_Dolor_TipoComboBox.Items.Add("Quemante")
        Cicatriz_Dolor_TipoComboBox.Items.Add("Vasculogénico")

        'Sensibilidad_ClaseComboBox
        Sensibilidad_ClaseComboBox.Items.Clear()
        Sensibilidad_ClaseComboBox.Items.Add("Superficial")
        Sensibilidad_ClaseComboBox.Items.Add("Cortical")

        'Cicatriz_AlteracionComboBox
        Cicatriz_AlteracionComboBox.Items.Clear()
        Cicatriz_AlteracionComboBox.Items.Add("Ninguna")
        Cicatriz_AlteracionComboBox.Items.Add("Queloide")
        Cicatriz_AlteracionComboBox.Items.Add("Hipertrófica")
        Cicatriz_AlteracionComboBox.Items.Add("Hipercrómica")
        Cicatriz_AlteracionComboBox.Items.Add("Hipocrómica")

        'SensibilidadB_ClaseComboBox
        SensibilidadB_claseComboBox.Items.Clear()
        SensibilidadB_claseComboBox.Items.Add("No Aplica")
        SensibilidadB_claseComboBox.Items.Add("Superficial")
        SensibilidadB_claseComboBox.Items.Add("Cortical")

        'SensibilidadC_ClaseComboBox
        SensibilidadC_claseComboBox.Items.Clear()
        SensibilidadC_claseComboBox.Items.Add("No Aplica")
        SensibilidadC_claseComboBox.Items.Add("Superficial")
        SensibilidadC_claseComboBox.Items.Add("Cortical")


        'SensibilidadD_ClaseComboBox
        SensibilidadD_claseComboBox.Items.Clear()
        SensibilidadD_claseComboBox.Items.Add("No Aplica")
        SensibilidadD_claseComboBox.Items.Add("Superficial")
        SensibilidadD_claseComboBox.Items.Add("Cortical")

        'actividad_fisica
        Actividad_FisicaComboBox.Items.Clear()
        Actividad_FisicaComboBox.Items.Add("Niega")
        Actividad_FisicaComboBox.Items.Add("Si")

        'DOlor_1
        Dolor1ComboBox.Items.Clear()
        Dolor1ComboBox.Items.Add("Niega")
        Dolor1ComboBox.Items.Add("Si")

        'Dolor2ComboBox
        Dolor2ComboBox.Items.Clear()
        Dolor2ComboBox.Items.Add("Niega")
        Dolor2ComboBox.Items.Add("Si")

        'Dolor3ComboBox
        Dolor3ComboBox.Items.Clear()
        Dolor3ComboBox.Items.Add("Niega")
        Dolor3ComboBox.Items.Add("Si")

        'Palpacion_DolorComboBox
        Palpacion_DolorComboBox.Items.Clear()
        Palpacion_DolorComboBox.Items.Add("Niega")
        Palpacion_DolorComboBox.Items.Add("Si")

        'Cicatriz_DolorComboBox
        Cicatriz_DolorComboBox.Items.Clear()
        Cicatriz_DolorComboBox.Items.Add("Niega")
        Cicatriz_DolorComboBox.Items.Add("Si")

        'EdemaComboBox
        EdemaComboBox.Items.Clear()
        EdemaComboBox.Items.Add("Presenta")
        EdemaComboBox.Items.Add("No Presenta")

        'EdemaSignoFoveaComboBox
        Edema_Signo_FoveaComboBox.Items.Clear()
        Edema_Signo_FoveaComboBox.Items.Add("Presenta")
        Edema_Signo_FoveaComboBox.Items.Add("No Presenta")

        'Circulacion_Llenado_CapilarComboBox
        Circulacion_Llenado_CapilarComboBox.Items.Clear()
        Circulacion_Llenado_CapilarComboBox.Items.Add("Conservada")
        Circulacion_Llenado_CapilarComboBox.Items.Add("Distal")
        Circulacion_Llenado_CapilarComboBox.Items.Add("Proximal")

        'Patron_RespiratorioComboBox
        Patron_RespiratorioComboBox.Items.Clear()
        Patron_RespiratorioComboBox.Items.Add("Ninguno")
        Patron_RespiratorioComboBox.Items.Add("Costal")
        Patron_RespiratorioComboBox.Items.Add("Diafragmático")
        Patron_RespiratorioComboBox.Items.Add("Costodiafragmático")



        Me.ValoracionesTableAdapter.Fill2(ConsultorioDataSet.Valoraciones, "")

        Nombre_CompletoComboBox.Text = ""
        Nombre_CompletoComboBox.Text = nombrepaciente
        CiudadTextBox.Text = "Bogotá"

    End Sub


    Private Sub Sensibilidad_ClaseComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Sensibilidad_ClaseComboBox.SelectedValueChanged
        If Sensibilidad_ClaseComboBox.Text = "Superficial" Then

            Sensibilidad_tipoComboBox.Items.Clear()
            Sensibilidad_tipoComboBox.Items.Add("Conservada")
            Sensibilidad_tipoComboBox.Items.Add("Alterada")
            Sensibilidad_tipoComboBox.Visible = True
            Sensibilidad_tipo2ComboBox.Visible = False
            Label39.Visible = False
            Sensibilidad_lugarTextBox.Visible = False
            Label40.Visible = False
            Label46.Visible = True
            Sensibilidad_descripciónTextBox.Visible = False
            Label55.Visible = False
        End If

        If Sensibilidad_ClaseComboBox.Text = "Cortical" Then

            Sensibilidad_tipoComboBox.Items.Clear()
            Sensibilidad_tipoComboBox.Items.Add("Barognosia")
            Sensibilidad_tipoComboBox.Items.Add("Grafestesia")
            Sensibilidad_tipoComboBox.Items.Add("Esterognosia")
            Sensibilidad_tipoComboBox.Items.Add("Propiocepción")
            Sensibilidad_tipoComboBox.Items.Add("Articular")
            Sensibilidad_tipo2ComboBox.Visible = False
            Label39.Visible = False
            Sensibilidad_lugarTextBox.Visible = False
            Label40.Visible = False
            Label46.Visible = True
            Sensibilidad_descripciónTextBox.Visible = False
            Label55.Visible = False
            Sensibilidad_lugarTextBox.Text = ""
            Sensibilidad_descripciónTextBox.Text = ""

        End If

    End Sub


    Private Sub Sensibilidad_tipoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Sensibilidad_tipoComboBox.SelectedValueChanged
        If Sensibilidad_tipoComboBox.Text = "Alterada" Then

            Sensibilidad_tipo2ComboBox.Visible = True
            Label39.Visible = True
            Label40.Visible = True
            Sensibilidad_lugarTextBox.Visible = True
            Sensibilidad_descripciónTextBox.Visible = True
            Label55.Visible = True
            Sensibilidad_tipo2ComboBox.Items.Clear()
            Sensibilidad_tipo2ComboBox.Items.Add("Hipoestesia")
            Sensibilidad_tipo2ComboBox.Items.Add("Hiperestesia")
            Sensibilidad_tipo2ComboBox.Items.Add("Hiperalgia")
            Sensibilidad_tipo2ComboBox.Items.Add("Alodinia")

        End If
        If Sensibilidad_tipoComboBox.Text = "Conservada" Then

            Sensibilidad_tipo2ComboBox.Items.Clear()
            Sensibilidad_tipo2ComboBox.Visible = False
            Sensibilidad_lugarTextBox.Visible = False
            Sensibilidad_descripciónTextBox.Visible = False
            Label55.Visible = False
            Label39.Visible = False
            Label40.Visible = False
            Sensibilidad_lugarTextBox.Text = ""
            Sensibilidad_descripciónTextBox.Text = ""

        ElseIf Sensibilidad_tipoComboBox.Text <> "Alterada" Then

            Sensibilidad_tipo2ComboBox.Items.Clear()
            Sensibilidad_tipo2ComboBox.Visible = False
            Sensibilidad_lugarTextBox.Visible = False
            Sensibilidad_descripciónTextBox.Visible = True
            Label55.Visible = True
            Label39.Visible = False
            Sensibilidad_lugarTextBox.Text = ""
            Sensibilidad_descripciónTextBox.Text = ""
        End If
    End Sub



    Private Sub SensibilidadB_ClaseComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SensibilidadB_claseComboBox.SelectedValueChanged
        If SensibilidadB_claseComboBox.Text = "Superficial" Then

            SensibilidadB_tipoComboBox.Items.Clear()
            SensibilidadB_tipoComboBox.Items.Add("Conservada")
            SensibilidadB_tipoComboBox.Items.Add("Alterada")
            SensibilidadB_tipoComboBox.Visible = True
            SensibilidadB_tipo2ComboBox.Visible = False
            Label43.Visible = False
            SensibilidadB_lugarTextBox.Visible = False
            Label42.Visible = False
            Label44.Visible = True
            SensibilidadB_descripciónTextBox.Visible = False
            Label56.Visible = False
        End If

        If SensibilidadB_claseComboBox.Text = "Cortical" Then

            SensibilidadB_tipoComboBox.Items.Clear()
            SensibilidadB_tipoComboBox.Items.Add("Barognosia")
            SensibilidadB_tipoComboBox.Items.Add("Grafestesia")
            SensibilidadB_tipoComboBox.Items.Add("Esterognosia")
            SensibilidadB_tipoComboBox.Items.Add("Propiocepción")
            SensibilidadB_tipoComboBox.Items.Add("Articular")
            SensibilidadB_tipoComboBox.Visible = True
            SensibilidadB_tipo2ComboBox.Visible = False
            Label43.Visible = False
            SensibilidadB_lugarTextBox.Visible = False
            Label42.Visible = False
            Label44.Visible = True
            SensibilidadB_descripciónTextBox.Visible = True
            Label56.Visible = True
            SensibilidadB_lugarTextBox.Text = ""
            SensibilidadB_descripciónTextBox.Text = ""

        End If
        If SensibilidadB_claseComboBox.Text = "No Aplica" Then

            SensibilidadB_tipoComboBox.Items.Clear()
            SensibilidadB_tipo2ComboBox.Items.Clear()
            SensibilidadB_lugarTextBox.Text = ""
            SensibilidadB_descripciónTextBox.Text = ""
            Label44.Visible = False
            Label56.Visible = False
            SensibilidadB_tipo2ComboBox.Visible = False
            SensibilidadB_tipoComboBox.Visible = False
            SensibilidadB_lugarTextBox.Visible = False
            SensibilidadB_descripciónTextBox.Visible = False
            Label43.Visible = False
            Label42.Visible = False


        End If
    End Sub


    Private Sub SensibilidadB_tipoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SensibilidadB_tipoComboBox.SelectedValueChanged
        If SensibilidadB_tipoComboBox.Text = "Alterada" Then

            SensibilidadB_tipo2ComboBox.Visible = True
            Label43.Visible = True
            Label42.Visible = True
            Label56.Visible = True
            SensibilidadB_lugarTextBox.Visible = True
            SensibilidadB_descripciónTextBox.Visible = True
            SensibilidadB_tipo2ComboBox.Items.Clear()
            SensibilidadB_tipo2ComboBox.Items.Add("Hipoestesia")
            SensibilidadB_tipo2ComboBox.Items.Add("Hiperestesia")
            SensibilidadB_tipo2ComboBox.Items.Add("Hiperalgia")
            SensibilidadB_tipo2ComboBox.Items.Add("Alodinia")
        End If
        If SensibilidadB_tipoComboBox.Text = "Conservada" Then

            SensibilidadB_tipo2ComboBox.Items.Clear()
            SensibilidadB_tipo2ComboBox.Visible = False
            SensibilidadB_lugarTextBox.Visible = False
            SensibilidadB_descripciónTextBox.Visible = False
            Label56.Visible = False
            Label43.Visible = False
            Label42.Visible = False
            SensibilidadB_lugarTextBox.Text = ""
            SensibilidadB_descripciónTextBox.Text = ""


        ElseIf SensibilidadB_tipoComboBox.Text <> "Alterada" Then
            SensibilidadB_tipo2ComboBox.Items.Clear()
            SensibilidadB_tipo2ComboBox.Visible = False
            SensibilidadB_lugarTextBox.Visible = False
            SensibilidadB_descripciónTextBox.Visible = True
            Label56.Visible = True
            Label39.Visible = False
            SensibilidadB_lugarTextBox.Text = ""
            SensibilidadB_descripciónTextBox.Text = ""
        End If
    End Sub




    Private Sub SensibilidadC_ClaseComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SensibilidadC_claseComboBox.SelectedValueChanged
        If SensibilidadC_claseComboBox.Text = "Superficial" Then

            SensibilidadC_tipoComboBox.Items.Clear()
            SensibilidadC_tipoComboBox.Items.Add("Conservada")
            SensibilidadC_tipoComboBox.Items.Add("Alterada")
            SensibilidadC_tipoComboBox.Visible = True
            SensibilidadC_tipo2ComboBox.Visible = False
            Label49.Visible = False
            SensibilidadC_lugarTextBox.Visible = False
            Label48.Visible = False
            Label47.Visible = True
            SensibilidadC_descripciónTextBox.Visible = False
            Label57.Visible = False
        End If

        If SensibilidadC_claseComboBox.Text = "Cortical" Then

            SensibilidadC_tipoComboBox.Items.Clear()
            SensibilidadC_tipoComboBox.Items.Add("Barognosia")
            SensibilidadC_tipoComboBox.Items.Add("Grafestesia")
            SensibilidadC_tipoComboBox.Items.Add("Esterognosia")
            SensibilidadC_tipoComboBox.Items.Add("Propiocepción")
            SensibilidadC_tipoComboBox.Items.Add("Articular")
            SensibilidadC_tipoComboBox.Visible = True
            SensibilidadC_tipo2ComboBox.Visible = False
            Label49.Visible = False
            SensibilidadC_lugarTextBox.Visible = False
            Label48.Visible = False
            Label47.Visible = True
            SensibilidadC_descripciónTextBox.Visible = True
            Label57.Visible = True
            SensibilidadC_lugarTextBox.Text = ""
            SensibilidadC_descripciónTextBox.Text = ""

        End If
        If SensibilidadC_claseComboBox.Text = "No Aplica" Then

            SensibilidadC_tipoComboBox.Items.Clear()
            SensibilidadC_tipo2ComboBox.Items.Clear()
            SensibilidadC_lugarTextBox.Text = ""
            SensibilidadC_descripciónTextBox.Text = ""
            Label47.Visible = False
            Label57.Visible = False

            SensibilidadC_tipo2ComboBox.Visible = False
            SensibilidadC_tipoComboBox.Visible = False
            SensibilidadC_lugarTextBox.Visible = False
            SensibilidadC_descripciónTextBox.Visible = False
            Label49.Visible = False
            Label48.Visible = False


        End If
    End Sub


    Private Sub SensibilidadC_tipoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SensibilidadC_tipoComboBox.SelectedValueChanged
        If SensibilidadC_tipoComboBox.Text = "Alterada" Then


            Label49.Visible = True
            Label48.Visible = True
            Label57.Visible = True
            SensibilidadC_tipo2ComboBox.Visible = True
            SensibilidadC_lugarTextBox.Visible = True
            SensibilidadC_descripciónTextBox.Visible = True
            SensibilidadC_tipo2ComboBox.Items.Clear()
            SensibilidadC_tipo2ComboBox.Items.Add("Hipoestesia")
            SensibilidadC_tipo2ComboBox.Items.Add("Hiperestesia")
            SensibilidadC_tipo2ComboBox.Items.Add("Hiperalgia")
            SensibilidadC_tipo2ComboBox.Items.Add("Alodinia")
        End If
        If SensibilidadC_tipoComboBox.Text = "Conservada" Then

            SensibilidadC_tipo2ComboBox.Items.Clear()
            Label49.Visible = False
            Label48.Visible = False
            Label57.Visible = False
            SensibilidadC_tipo2ComboBox.Visible = False
            SensibilidadC_lugarTextBox.Visible = False
            SensibilidadC_descripciónTextBox.Visible = False
            SensibilidadC_lugarTextBox.Text = ""
            SensibilidadC_descripciónTextBox.Text = ""

        ElseIf SensibilidadC_tipoComboBox.Text <> "Alterada" Then
            SensibilidadC_tipo2ComboBox.Items.Clear()
            SensibilidadC_tipo2ComboBox.Visible = False
            SensibilidadC_lugarTextBox.Visible = False
            SensibilidadC_descripciónTextBox.Visible = True
            Label57.Visible = True
            Label39.Visible = False
            SensibilidadC_lugarTextBox.Text = ""
            SensibilidadC_descripciónTextBox.Text = ""
        End If
    End Sub


    Private Sub SensibilidadD_ClaseComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SensibilidadD_claseComboBox.SelectedValueChanged
        If SensibilidadD_claseComboBox.Text = "Superficial" Then

            SensibilidadD_tipoComboBox.Items.Clear()
            SensibilidadD_tipoComboBox.Items.Add("Conservada")
            SensibilidadD_tipoComboBox.Items.Add("Alterada")
            SensibilidadD_tipoComboBox.Visible = True
            SensibilidadD_tipo2ComboBox.Visible = False
            Label53.Visible = False
            SensibilidadD_lugarTextBox.Visible = False
            Label52.Visible = False
            Label51.Visible = True
            SensibilidadD_descripciónTextBox.Visible = False
            Label58.Visible = False
        End If

        If SensibilidadD_claseComboBox.Text = "Cortical" Then

            SensibilidadD_tipoComboBox.Items.Clear()
            SensibilidadD_tipoComboBox.Items.Add("Barognosia")
            SensibilidadD_tipoComboBox.Items.Add("Grafestesia")
            SensibilidadD_tipoComboBox.Items.Add("Esterognosia")
            SensibilidadD_tipoComboBox.Items.Add("Propiocepción")
            SensibilidadD_tipoComboBox.Items.Add("Articular")
            SensibilidadD_tipoComboBox.Visible = True
            SensibilidadD_tipo2ComboBox.Visible = False
            SensibilidadD_lugarTextBox.Visible = False
            SensibilidadD_descripciónTextBox.Visible = True

            Label53.Visible = False
            Label52.Visible = False
            Label51.Visible = True
            Label58.Visible = True

            SensibilidadD_lugarTextBox.Text = ""
            SensibilidadD_descripciónTextBox.Text = ""

        End If
        If SensibilidadD_claseComboBox.Text = "No Aplica" Then

            SensibilidadD_tipoComboBox.Items.Clear()
            SensibilidadD_tipo2ComboBox.Items.Clear()
            SensibilidadD_lugarTextBox.Text = ""
            SensibilidadD_descripciónTextBox.Text = ""


            SensibilidadD_tipo2ComboBox.Visible = False
            SensibilidadD_tipoComboBox.Visible = False
            SensibilidadD_lugarTextBox.Visible = False
            SensibilidadD_descripciónTextBox.Visible = False


            Label53.Visible = False
            Label52.Visible = False
            Label51.Visible = False
            Label58.Visible = False


        End If
    End Sub


    Private Sub SensibilidadD_tipoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SensibilidadD_tipoComboBox.SelectedValueChanged
        If SensibilidadD_tipoComboBox.Text = "Alterada" Then

            SensibilidadD_tipo2ComboBox.Visible = True
            Label53.Visible = True
            Label52.Visible = True
            Label58.Visible = True
            SensibilidadD_lugarTextBox.Visible = True
            SensibilidadD_descripciónTextBox.Visible = True
            SensibilidadD_tipo2ComboBox.Items.Clear()
            SensibilidadD_tipo2ComboBox.Items.Add("Hipoestesia")
            SensibilidadD_tipo2ComboBox.Items.Add("Hiperestesia")
            SensibilidadD_tipo2ComboBox.Items.Add("Hiperalgia")
            SensibilidadD_tipo2ComboBox.Items.Add("Alodinia")
        End If
        If SensibilidadD_tipoComboBox.Text = "Conservada" Then

            SensibilidadD_tipo2ComboBox.Items.Clear()
            SensibilidadD_tipo2ComboBox.Visible = False
            SensibilidadD_lugarTextBox.Visible = False
            SensibilidadD_descripciónTextBox.Visible = False
            Label53.Visible = False
            Label52.Visible = False
            Label58.Visible = False
            SensibilidadD_lugarTextBox.Text = ""
            SensibilidadD_descripciónTextBox.Text = ""

        ElseIf SensibilidadD_tipoComboBox.Text <> "Alterada" Then
            SensibilidadD_tipo2ComboBox.Items.Clear()
            SensibilidadD_tipo2ComboBox.Visible = False
            SensibilidadD_lugarTextBox.Visible = False
            SensibilidadD_descripciónTextBox.Visible = False
            Label58.Visible = False
            Label39.Visible = False
            SensibilidadD_lugarTextBox.Text = ""
            SensibilidadD_descripciónTextBox.Text = ""
        End If
    End Sub






    Private Sub Nombre_CompletoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Nombre_CompletoComboBox.SelectedValueChanged
        If Nombre_CompletoComboBox.Text <> "" Then

            TabControl1.Visible = True
            Button2.Visible = True
            PictureBox1.Visible = False

            Dim myDataTable = PacientesTableAdapter.GetCode(Nombre_CompletoComboBox.Text)
            For Each dataRow In myDataTable.Rows
                Codigo_PacienteTextBox.Text = dataRow.Codigo_Paciente
            Next dataRow

        Else
            TabControl1.Visible = False
            Button2.Visible = False
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()
        Historia_Clinica.Show()

    End Sub

    Private Sub Actividad_FisicaComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Actividad_FisicaComboBox.SelectedValueChanged
        If Actividad_FisicaComboBox.Text = "Si" Then
            GroupBox1.Visible = True


        Else
            GroupBox1.Visible = False

            A_F_TipoTextBox.Text = ""
            A_F_FrecuenciaComboBox.Text = ""
            A_F_DuraciónNumericUpDown.Value = 0
        End If
    End Sub

    Private Sub Dolor1ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Dolor1ComboBox.SelectedValueChanged
        If Dolor1ComboBox.Text = "Si" Then
            GroupBox2.Visible = True
            Label36.Visible = True
            Dolor2ComboBox.Visible = True

        Else
            GroupBox2.Visible = False
            Label36.Visible = False
            Dolor2ComboBox.Visible = False
            Dolor_Localizacion1TextBox.Text = ""
            Dolor_EVA1NumericUpDown.Value = 1
            Dolor_Frecuencia1ComboBox.Text = ""
            Dolor_Tipo1ComboBox.Text = ""
            Dolor_Exacerbacion1TextBox.Text = ""
            Dolor_Disminucion1TextBox.Text = ""

        End If
    End Sub

    Private Sub Dolor2ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Dolor2ComboBox.SelectedValueChanged
        If Dolor2ComboBox.Text = "Si" Then
            GroupBox3.Visible = True
            Label37.Visible = True
            Dolor3ComboBox.Visible = True

        Else
            GroupBox3.Visible = False
            Label37.Visible = False
            Dolor3ComboBox.Visible = False
            Dolor_Localizacion2TextBox.Text = ""
            Dolor_EVA2NumericUpDown.Value = 1
            Dolor_Frecuencia2ComboBox.Text = ""
            Dolor_Tipo2ComboBox.Text = ""
            Dolor_Exacerbacion2TextBox.Text = ""
            Dolor_Disminucion2TextBox.Text = ""
        End If
    End Sub

    Private Sub Dolor3ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Dolor3ComboBox.SelectedValueChanged
        If Dolor3ComboBox.Text = "Si" Then
            GroupBox4.Visible = True

        Else
            GroupBox4.Visible = False
            Dolor_Localizacion3TextBox.Text = ""
            Dolor_EVA3NumericUpDown.Value = 1
            Dolor_Frecuencia3ComboBox.Text = ""
            Dolor_Tipo3ComboBox.Text = ""
            Dolor_Exacerbacion3TextBox.Text = ""
            Dolor_Disminucion3TextBox.Text = ""

        End If
    End Sub

    Private Sub Palpacion_DolorComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Palpacion_DolorComboBox.SelectedValueChanged
        If Palpacion_DolorComboBox.Text = "Si" Then
            GroupBox5.Visible = True


        Else
            GroupBox5.Visible = False
            Palpacion_Dolor_LocalizacionTextBox.Text = ""
            Palpacion_Dolor_EVANumericUpDown.Value = 1
            Palpacion_Dolor_FrecuenciaComboBox.Text = ""
            Palpacion_Dolor_TipoComboBox.Text = ""
            Palpacion_Dolor_ExacerbacionTextBox.Text = ""
            Palpacion_Dolor_DisminucionTextBox.Text = ""
        End If
    End Sub

    Private Sub Cicatriz_DolorComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cicatriz_DolorComboBox.SelectedValueChanged
        If Cicatriz_DolorComboBox.Text = "Si" Then
            GroupBox6.Visible = True


        Else
            GroupBox6.Visible = False
            Cicatriz_Dolor_LocalizacionTextBox.Text = ""
            Cicatriz_Dolor_EVANumericUpDown.Value = 1
            Cicatriz_Dolor_FrecuenciaComboBox.Text = ""
            Cicatriz_Dolor_TipoComboBox.Text = ""
            Cicatriz_Dolor_ExacerbacionTextBox.Text = ""
            Cicatriz_Dolor_DisminucionTextBox.Text = ""
        End If
    End Sub

    Private Sub EdemaComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles EdemaComboBox.SelectedValueChanged
        If EdemaComboBox.Text = "Presenta" Then
            GroupBox7.Visible = True


        Else
            GroupBox7.Visible = False
            Edema_Medida_CircunferencialNumericUpDown.Value = 0
            Edema_Signo_FoveaComboBox.Text = ""
            Edema_signo_Fovea_TiempoNumericUpDown.Value = 0

        End If
    End Sub

    Private Sub Edema_Signo_FoveaComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Edema_Signo_FoveaComboBox.SelectedValueChanged
        If EdemaComboBox.Text = "Presenta" Then
            Edema_signo_Fovea_TiempoNumericUpDown.Visible = True


        Else
            Edema_signo_Fovea_TiempoNumericUpDown.Visible = False
            Edema_signo_Fovea_TiempoNumericUpDown.Value = 0

        End If
    End Sub

    Private Sub Circulacion_Llenado_CapilarComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Circulacion_Llenado_CapilarComboBox.SelectedValueChanged
        If Circulacion_Llenado_CapilarComboBox.Text <> "" And Circulacion_Llenado_CapilarComboBox.Text <> "Conservada" Then
            Circulacion_TiempoNumericUpDown.Visible = True


        Else
            Circulacion_TiempoNumericUpDown.Visible = False
            Circulacion_TiempoNumericUpDown.Value = 0

        End If
    End Sub

    Private Sub Patron_RespiratorioComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Patron_RespiratorioComboBox.SelectedValueChanged
        If Patron_RespiratorioComboBox.Text <> "" And Patron_RespiratorioComboBox.Text <> "Ninguno" Then
            Patron_Respiratorio_CmNumericUpDown.Visible = True


        Else
            Patron_Respiratorio_CmNumericUpDown.Visible = False
            Patron_Respiratorio_CmNumericUpDown.Value = 0

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Codigo_PacienteTextBox.Text <> "" Then

            If FechaDateTimePicker.Value = "01/01/2017" Or HoraDateTimePicker.Value = "00:00" Or Actividad_FisicaComboBox.Text = "" Or
                    Dolor1ComboBox.Text = "" Or Sensibilidad_ClaseComboBox.Text = "" Or Palpacion_localizacionTextBox.Text = "" Or
                    Palpacion_DolorComboBox.Text = "" Or Cicatriz_LocalizacionTextBox.Text = "" Or Cicatriz_DolorComboBox.Text = "" Or
                    EdemaComboBox.Text = "" Or Circulacion_Llenado_CapilarComboBox.Text = "" Or Patron_RespiratorioComboBox.Text = "" Then
                MsgBox("Debe llenar todos los datos requeridos")
            Else


                Dim consecutivo As Integer
                Dim prefijo, consecutivostr As String

                consecutivo = Me.ValoracionesTableAdapter.Cantidad_Val(Codigo_PacienteTextBox.Text)
                consecutivo = consecutivo + 1
                consecutivostr = consecutivo.ToString("D4")
                prefijo = Codigo_PacienteTextBox.Text & "-" & "VA-" & consecutivostr



                If MsgBox("Está seguro que Crear la Valoración: " & prefijo, vbOKCancel, "Confirmación") = vbOK Then
                    Try
                        Me.Validate()
                        Me.ValoracionesBindingSource.EndEdit()
                        Me.ValoracionesTableAdapter.Crear_Val(Codigo_Paciente:=Codigo_PacienteTextBox.Text, Acompañante:=AcompañanteTextBox.Text, Parentezco:=ParentezcoTextBox.Text, Fecha:=FechaDateTimePicker.Value,
                                                                Hora:=HoraDateTimePicker.Value, Ciudad:=CiudadTextBox.Text, Motivo_Consulta:=Motivo_ConsultaTextBox.Text, Enfermedad_Actual:=Enfermedad_ActualTextBox.Text,
                                                                Examenes_Diagnosticos:=Examenes_DiagnosticosTextBox.Text, Paraclinicos:=ParaclinicosTextBox.Text, Patologicos:=PatologicosTextBox.Text, Hospitalarios:=HospitalariosTextBox.Text,
                                                                Quirurgicos:=QuirurgicosTextBox.Text, Toxicos:=ToxicosTextBox.Text, Alergicos:=AlergicosTextBox.Text, Traumáticos:=TraumáticosTextBox.Text,
                                                                Familiares:=FamiliaresTextBox.Text, Ginecologicos:=GinecologicosTextBox.Text, Actividad_Fisica:=Actividad_FisicaComboBox.Text, A_F_Tipo:=A_F_TipoTextBox.Text,
                                                                A_F_Frecuencia:=A_F_FrecuenciaComboBox.Text, A_F_Duración:=A_F_DuraciónNumericUpDown.Value,
                                                                Dolor1:=Dolor1ComboBox.Text, Dolor_Localizacion1:=Dolor_Localizacion1TextBox.Text, Dolor_EVA1:=Dolor_EVA1NumericUpDown.Value, Dolor_Frecuencia1:=Dolor_Frecuencia1ComboBox.Text,
                                                                Dolor_Tipo1:=Dolor_Tipo1ComboBox.Text, Dolor_Exacerbacion1:=Dolor_Exacerbacion1TextBox.Text, Dolor_Disminucion1:=Dolor_Disminucion1TextBox.Text,
                                                                Dolor2:=Dolor2ComboBox.Text, Dolor_Localizacion2:=Dolor_Localizacion2TextBox.Text, Dolor_EVA2:=Dolor_EVA2NumericUpDown.Value, Dolor_Frecuencia2:=Dolor_Frecuencia2ComboBox.Text,
                                                                Dolor_Tipo2:=Dolor_Tipo2ComboBox.Text, Dolor_Exacerbacion2:=Dolor_Exacerbacion2TextBox.Text, Dolor_Disminucion2:=Dolor_Disminucion2TextBox.Text,
                                                                Dolor3:=Dolor3ComboBox.Text, Dolor_Localizacion3:=Dolor_Localizacion3TextBox.Text, Dolor_EVA3:=Dolor_EVA3NumericUpDown.Value, Dolor_Frecuencia3:=Dolor_Frecuencia3ComboBox.Text,
                                                                Dolor_Tipo3:=Dolor_Tipo3ComboBox.Text, Dolor_Exacerbacion3:=Dolor_Exacerbacion3TextBox.Text, Dolor_Disminucion3:=Dolor_Disminucion3TextBox.Text,
                                                                Sensibilidad_Clase:=Sensibilidad_ClaseComboBox.Text, Sensibilidad_tipo:=Sensibilidad_tipoComboBox.Text, Sensibilidad_tipo2:=Sensibilidad_tipo2ComboBox.Text,
                                                                Palpacion_localizacion:=Palpacion_localizacionTextBox.Text, Palpacion_hallazgos:=Palpacion_hallazgosTextBox.Text,
                                                                Palpacion_Dolor:=Palpacion_DolorComboBox.Text, Palpacion_Dolor_Localizacion:=Palpacion_Dolor_LocalizacionTextBox.Text, Palpacion_Dolor_EVA:=Palpacion_Dolor_EVANumericUpDown.Value, Palpacion_Dolor_Frecuencia:=Palpacion_Dolor_FrecuenciaComboBox.Text,
                                                                Palpacion_Dolor_Tipo:=Palpacion_Dolor_TipoComboBox.Text, Palpacion_Dolor_Exacerbacion:=Palpacion_Dolor_ExacerbacionTextBox.Text, Palpacion_Dolor_Disminucion:=Palpacion_Dolor_DisminucionTextBox.Text,
                                                                Cicatriz_Localizacion:=Cicatriz_LocalizacionTextBox.Text, Cicatriz_Hallazgos:=Cicatriz_HallazgosTextBox.Text, Cicatriz_Alteracion:=Cicatriz_AlteracionComboBox.Text,
                                                                Cicatriz_Dolor:=Cicatriz_DolorComboBox.Text, Cicatriz_Dolor_Localizacion:=Cicatriz_Dolor_LocalizacionTextBox.Text, Cicatriz_Dolor_EVA:=Cicatriz_Dolor_EVANumericUpDown.Value, Cicatriz_Dolor_Frecuencia:=Cicatriz_Dolor_FrecuenciaComboBox.Text,
                                                                Cicatriz_Dolor_Tipo:=Cicatriz_Dolor_TipoComboBox.Text, Cicatriz_Dolor_Exacerbacion:=Cicatriz_Dolor_ExacerbacionTextBox.Text, Cicatriz_Dolor_Disminucion:=Cicatriz_Dolor_DisminucionTextBox.Text,
                                                                Edema:=EdemaComboBox.Text, Edema_Medida_Circunferencial:=Edema_Medida_CircunferencialNumericUpDown.Value, Edema_Signo_Fovea:=Edema_Signo_FoveaComboBox.Text, Edema_signo_Fovea_Tiempo:=Edema_signo_Fovea_TiempoNumericUpDown.Value,
                                                                Circulacion_Llenado_Capilar:=Circulacion_Llenado_CapilarComboBox.Text, Circulacion_Tiempo:=Circulacion_TiempoNumericUpDown.Value,
                                                                Patron_Respiratorio:=Patron_RespiratorioComboBox.Text, Patron_Respiratorio_Cm:=Patron_Respiratorio_CmNumericUpDown.Value,
                                                                Segmento_A_Evaluar:=Segmento_A_EvaluarRichTextBox.Text, Codigo_Documento:=prefijo, Tipo:="Valoración", Sensibilidad_lugar:=Sensibilidad_lugarTextBox.Text, SensibilidadB_lugar:=SensibilidadB_lugarTextBox.Text, SensibilidadB_clase:=SensibilidadB_claseComboBox.Text,
                                                                SensibilidadB_tipo:=SensibilidadB_tipoComboBox.Text, SensibilidadB_tipo2:=SensibilidadB_tipo2ComboBox.Text)
                        MsgBox("Valoración creada Satisfactoriamente")
                        Me.Close()
                        Me.Dispose()
                        Historia_Clinica.Show()

                    Catch ex As Exception
                        MsgBox("error de guardado")
                    End Try



                End If
            End If

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dermatomas.Show()
    End Sub

    Private Sub CicatrizComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles CicatrizComboBox.SelectedValueChanged
        If CicatrizComboBox.Text = "" Or CicatrizComboBox.Text = "No Presenta" Then
            GroupBox8.Visible = False
        Else
            GroupBox8.Visible = True
        End If
    End Sub

    Private Sub Pruebas_especificasTextBox_TextChanged(sender As Object, e As EventArgs) Handles Pruebas_especificasTextBox.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        MsgBox("El TDR se guardará en : C:\VisualStudio\salida.docx")
        FileCopy("C:\VisualStudio\plantilla_video.docx", "C:\VisualStudio\salida.docx")
        Documento = MSWord.Documents.Open("C:\VisualStudio\salida.docx")

        Documento.Bookmarks.Item("nombre").Range.Text = Nombre_CompletoComboBox.Text


        Documento.Save()
        MSWord.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim consecutivo As Integer
        Dim prefijo, consecutivostr As String

        consecutivo = Me.ValoracionesTableAdapter.Cantidad_Val(Codigo_PacienteTextBox.Text)
        consecutivo = consecutivo + 1
        consecutivostr = consecutivo.ToString("D4")
        prefijo = Codigo_PacienteTextBox.Text & "-" & "VA-" & consecutivostr

        If consecutivo <> "" Then
            Dim myDataTable = PacientesTableAdapter.GetDatosPaciente(Nombre_CompletoComboBox.Text)
            For Each dataRow In myDataTable.Rows
                'Codigo_PacienteTextBox.Text = dataRow.Codigo_Paciente
                'GeneroTextBox.Text = dataRow.Genero
                'DireccionTextBox.Text = dataRow.Direccion
                'TelefonoTextBox.Text = dataRow.Telefono
                'CelularTextBox.Text = dataRow.Celular
                'EmailTextBox.Text = dataRow.Email
                'OcupacionTextBox.Text = dataRow.Ocupacion

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
End Class