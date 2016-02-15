Imports System.Data.OleDb

Public Class Crear_Simulacro


    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\sistemaevaluarte.accdb")

    Public pregA As Integer = 0
    Public pregB As Integer = 0
    Public pregC As Integer = 0
    Public pregD As Integer = 0
    Public pregE As Integer = 0
    Public pregF As Integer = 0
    Public pregG As Integer = 0
    Public pregH As Integer = 0
    Public pregCuantitativo As Integer = 0
    Public pregCiudadanas As Integer = 0
    Public pregAbierta As Integer = 0

    Public pepe As Integer = 63

    Public contador_pepe As Integer = 0


    Public componente1 As Integer = 0
    Public componente2 As Integer = 0
    Public componente3 As Integer = 0
    Public componente4 As Integer = 0
    Public competencia1 As Integer = 0
    Public competencia2 As Integer = 0
    Public competencia3 As Integer = 0


    Public tipo As String


    Public M2pregA As Integer = 0
    Public M2pregB As Integer = 0
    Public M2pregC As Integer = 0
    Public M2pregD As Integer = 0
    Public M2pregE As Integer = 0


    Public M2componente1 As Integer = 0
    Public M2componente2 As Integer = 0
    Public M2componente3 As Integer = 0
    Public M2componente4 As Integer = 0
    Public M2competencia1 As Integer = 0
    Public M2competencia2 As Integer = 0
    Public M2competencia3 As Integer = 0


    Public M3pregA As Integer = 0
    Public M3pregB As Integer = 0
    Public M3pregC As Integer = 0
    Public M3pregD As Integer = 0
    Public M3pregE As Integer = 0
    Public M3componente1 As Integer = 0
    Public M3componente2 As Integer = 0
    Public M3componente3 As Integer = 0
    Public M3componente4 As Integer = 0
    Public M3competencia1 As Integer = 0
    Public M3competencia2 As Integer = 0
    Public M3competencia3 As Integer = 0

    Public M4pregA As Integer = 0
    Public M4pregB As Integer = 0
    Public M4pregC As Integer = 0
    Public M4pregD As Integer = 0
    Public M4pregE As Integer = 0
    Public M4componente1 As Integer = 0
    Public M4componente2 As Integer = 0
    Public M4componente3 As Integer = 0
    Public M4componente4 As Integer = 0
    Public M4competencia1 As Integer = 0
    Public M4competencia2 As Integer = 0
    Public M4competencia3 As Integer = 0

    Public M5pregA As Integer = 0
    Public M5pregB As Integer = 0
    Public M5pregC As Integer = 0
    Public M5pregD As Integer = 0
    Public M5pregE As Integer = 0
    Public M5componente1 As Integer = 0
    Public M5componente2 As Integer = 0
    Public M5componente3 As Integer = 0
    Public M5componente4 As Integer = 0
    Public M5competencia1 As Integer = 0
    Public M5competencia2 As Integer = 0
    Public M5competencia3 As Integer = 0

    Public M6pregA As Integer = 0
    Public M6pregB As Integer = 0
    Public M6pregC As Integer = 0
    Public M6pregD As Integer = 0
    Public M6pregE As Integer = 0
    Public M6componente1 As Integer = 0
    Public M6componente2 As Integer = 0
    Public M6componente3 As Integer = 0
    Public M6componente4 As Integer = 0
    Public M6competencia1 As Integer = 0
    Public M6competencia2 As Integer = 0
    Public M6competencia3 As Integer = 0

    Public Control1 As Integer = 0

    Dim matriz(,) As String
    Dim matriz1(,) As String
    Dim matriz2(,) As String
    Dim matriz3(,) As String
    Dim matriz4(,) As String
    Dim matriz5(,) As String

    Public cant_preguntas As String = "0"
    Public NOMBRE_MATERIA As String = "0"

    Public orden_materias As String = "0"
    Public orden_materias_2 As String = "0"

    Public total_preguntas As Integer = 0
    'variable para llevar la cuenta de preguntas al examen dos


    Public Sub Crear_Simulacro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR_VALORES()
    End Sub

    Sub CARGAR3()

        '    Dim DH As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias_Profundizacion", CN)
        '    Dim DM As New DataSet
        '    DH.Fill(DM, "Materias_Profundizacion")
        '    CBOMATERIA1.DataSource = DM.Tables("Materias_Profundizacion")
        '    CBOMATERIA1.DisplayMember = "materia"

        '    Dim DA As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias_Profundizacion", CN)
        '    Dim DJ As New DataSet
        '    DA.Fill(DJ, "Materias_Profundizacion")
        '    CBOMATERIA2.DataSource = DJ.Tables("Materias_Profundizacion")
        '    CBOMATERIA2.DisplayMember = "materia"

        '    Dim DB As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias_Profundizacion", CN)
        '    Dim DK As New DataSet
        '    DB.Fill(DK, "Materias_Profundizacion")
        '    CBMATERIA3.DataSource = DK.Tables("Materias_Profundizacion")
        '    CBMATERIA3.DisplayMember = "materia"

        '    Dim DC As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias_Profundizacion", CN)
        '    Dim DL As New DataSet
        '    DC.Fill(DL, "Materias_Profundizacion")
        '    CBOMATERIA4.DataSource = DL.Tables("Materias_Profundizacion")
        '    CBOMATERIA4.DisplayMember = "materia"

        '    Dim DD As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias_Profundizacion", CN)
        '    Dim DN As New DataSet
        '    DD.Fill(DN, "Materias_Profundizacion")
        '    CBOMATERIA5.DataSource = DN.Tables("Materias_Profundizacion")
        '    CBOMATERIA5.DisplayMember = "materia"

        '    Dim DE As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias_Profundizacion", CN)
        '    Dim DP As New DataSet
        '    DE.Fill(DP, "Materias_Profundizacion")
        '    CBOMATERIA6.DataSource = DP.Tables("Materias_Profundizacion")
        '    CBOMATERIA6.DisplayMember = "materia"

    End Sub

    Sub CARGAR2()

        '    Dim DH As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias WHERE sesion='1' OR sesion='2'", CN)
        '    Dim DM As New DataSet
        '    DH.Fill(DM, "Materias")
        '    CBOMATERIA1.DataSource = DM.Tables("Materias")
        '    CBOMATERIA1.DisplayMember = "materia"


        '    Dim DA As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias WHERE sesion='1' OR sesion='2'", CN)
        '    Dim DJ As New DataSet
        '    DA.Fill(DJ, "Materias")
        '    CBOMATERIA2.DataSource = DJ.Tables("Materias")
        '    CBOMATERIA2.DisplayMember = "materia"

        '    Dim DB As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias WHERE sesion='1' OR sesion='2'", CN)
        '    Dim DK As New DataSet
        '    DB.Fill(DK, "Materias")
        '    CBMATERIA3.DataSource = DK.Tables("Materias")
        '    CBMATERIA3.DisplayMember = "materia"
    End Sub

    Sub CARGAR()

        'Dim DH As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias WHERE sesion='1' OR sesion='2'", CN)
        'Dim DM As New DataSet
        'DH.Fill(DM, "Materias")
        'CBOMATERIA1.DataSource = DM.Tables("Materias")
        'CBOMATERIA1.DisplayMember = "materia"


        'Dim DA As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias WHERE sesion='1' OR sesion='2'", CN)
        'Dim DJ As New DataSet
        'DA.Fill(DJ, "Materias")
        'CBOMATERIA2.DataSource = DJ.Tables("Materias")
        'CBOMATERIA2.DisplayMember = "materia"

        'Dim DB As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias WHERE sesion='1' OR sesion='2'", CN)
        'Dim DK As New DataSet
        'DB.Fill(DK, "Materias")
        'CBMATERIA3.DataSource = DK.Tables("Materias")
        'CBMATERIA3.DisplayMember = "materia"

        'Dim DC As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias WHERE sesion='1' OR sesion='2'", CN)
        'Dim DL As New DataSet
        'DC.Fill(DL, "Materias")
        'CBOMATERIA4.DataSource = DL.Tables("Materias")
        'CBOMATERIA4.DisplayMember = "materia"

        'Dim DD As New OleDb.OleDbDataAdapter("SELECT  materia  FROM Materias WHERE sesion='1' OR sesion='2'", CN)
        'Dim DN As New DataSet
        'DD.Fill(DN, "Materias")
        'CBOMATERIA5.DataSource = DN.Tables("Materias")
        'CBOMATERIA5.DisplayMember = "materia"

    End Sub


    Sub CARGAR_VALORES()

        CBNSESION.Items.Add("1")
        CBNSESION.Items.Add("2")

        Dim DH As New OleDb.OleDbDataAdapter("SELECT nombre_prueba  FROM Pruebas_Crear_Simulacro", CN)
        Dim DM As New DataSet
        DH.Fill(DM, "Pruebas_Crear_Simulacro")
        CBOTIPO.DataSource = DM.Tables("Pruebas_Crear_Simulacro")
        CBOTIPO.DisplayMember = "nombre_prueba"

        Dim DH1 As New OleDb.OleDbDataAdapter("SELECT DISTINCT grado FROM grupos", CN)
        Dim DM1 As New DataSet
        DH1.Fill(DM1, "grupos")
        CBOGRADO.DataSource = DM1.Tables("grupos")
        CBOGRADO.DisplayMember = "grado"
    End Sub

    Sub CARGAR_SESION2()
        CBNSESION.Items.Remove("1")
    End Sub

    Sub CARGAR_SESION4()
        CBNSESION.Items.Add("2")
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If TextBox1.Text = "" Then
    '        MsgBox("NO SE HA INGRESADO LA CANTIDAD DE PREGUNTAS", 16, "MENSAJE ERROR")
    '    ElseIf Control1 = 1 Then

    '        'total_preguntas = PREGUNTAS_SESION.Text
    '        'PREGUNTAS_SESION.Text = Double.Parse(TextBox1.Text) + PREGUNTAS_SESION.Text

    '        ReDim matriz(TextBox1.Text - 1, 8)


    '        For b As Integer = 0 To TextBox1.Text
    '            'prueba(b) = b
    '            ' TextBox1.Text  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 
    '            ' guardar el codigo del examen
    '            If (b) < TextBox1.Text Then
    '                matriz(b, 0) = TXTCODIGO.Text
    '                matriz(b, 1) = CBOMATERIA1.Text
    '                ' guardar el indicardor de cada pregunta.
    '                'matriz(b, 2) = b + 1 + total_preguntas  ' asi estaba 
    '                matriz(b, 2) = b + 1
    '                matriz(b, 6) = CBNSESION.Text

    '                Dim CMD As New OleDb.OleDbCommand("SELECT Id FROM Materias_Profundizacion WHERE materia='" & CBOMATERIA1.Text & "'", CN)
    '                Dim DR As OleDb.OleDbDataReader
    '                CN.Open()
    '                DR = CMD.ExecuteReader
    '                If DR.Read Then
    '                    tipo = DR(0)
    '                Else
    '                    MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
    '                End If
    '                CN.Close()

    '                matriz(b, 7) = tipo

    '            End If

    '            For i As Integer = 0 To 11
    '                Dim Pregunta As New CheckBox
    '                Pregunta.Name = "CheckBox" & i.ToString
    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then
    '                    Pregunta.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta.Size = New Point(15, 14)
    '                    Pregunta.TabIndex = i
    '                    Pregunta.Text = b

    '                    Me.Controls.Add(Pregunta)
    '                    AddHandler Pregunta.Click, AddressOf MiControl_Click
    '                End If
    '            Next
    '        Next

    '        BTNCALIFICAR.Enabled = False
    '        Button9.Visible = True
    '        Button9.Enabled = True

    '    Else
    '        '###################### VALIDAD SI YA EXISTE EL CODIGO DE ALGUNA FORMA ###################



    '        PREGUNTAS_SESION.Text = Double.Parse(TextBox1.Text) + Double.Parse(PREGUNTAS_SESION.Text)

    '        ReDim matriz(TextBox1.Text - 1, 8)
    '        For b As Integer = 0 To TextBox1.Text
    '            'prueba(b) = b
    '            ' TextBox1.Text  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 

    '            ' guardar el codigo del examen
    '            If (b) < TextBox1.Text Then
    '                matriz(b, 0) = TXTCODIGO.Text
    '                matriz(b, 1) = CBOMATERIA1.Text
    '                ' guardar el indicardor de cada pregunta.
    '                matriz(b, 2) = b + 1 + total_preguntas
    '                matriz(b, 6) = CBNSESION.Text
    '                matriz(b, 7) = ""
    '            End If

    '            For i As Integer = 0 To 11
    '                Dim Pregunta As New CheckBox
    '                'Dim indice_pregunta As New Label

    '                'indice_pregunta.Name = "label" & i.ToString
    '                'indice_pregunta.Text = b.ToString
    '                'indice_pregunta.Location = New Point(80, 355 + (b * 25))
    '                'indice_pregunta.Size = New Point(20, 14)
    '                'indice_pregunta.BackColor = Color.White
    '                'Me.Controls.Add(indice_pregunta)

    '                'AddHandler indice_pregunta.Click, AddressOf MiControl_Click
    '                Pregunta.Name = "CheckBox" & i.ToString

    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then
    '                    Pregunta.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta.Size = New Point(15, 14)
    '                    Pregunta.TabIndex = i
    '                    Pregunta.Text = b

    '                    Me.Controls.Add(Pregunta)
    '                    AddHandler Pregunta.Click, AddressOf MiControl_Click

    '                ElseIf i = 5 Or i = 6 Or i = 7 Or i = 8 Then
    '                    Pregunta.Location = New Point(100 + (i * 70), 355 + (b * 25))
    '                    Pregunta.Size = New Point(15, 14)
    '                    Pregunta.TabIndex = i
    '                    Pregunta.Text = b

    '                    Me.Controls.Add(Pregunta)
    '                    AddHandler Pregunta.Click, AddressOf MiControl_Click

    '                Else
    '                    Pregunta.Location = New Point(100 + (i * 80), 355 + (b * 25))
    '                    Pregunta.Size = New Point(15, 14)
    '                    Pregunta.TabIndex = i
    '                    Pregunta.Text = b

    '                    Me.Controls.Add(Pregunta)
    '                    AddHandler Pregunta.Click, AddressOf MiControl_Click
    '                    'AddHandler BTNSALIR.Click, AddressOf Me.BTNSALIR_Click
    '                End If
    '            Next
    '        Next

    '        'For c As Integer = 0 To 1
    '        '    Dim boton_limpiar As New Button
    '        '    boton_limpiar.Name = "Boton" & c.ToString
    '        '    boton_limpiar.Text = "Boton" & c.ToString
    '        '    boton_limpiar.Location = New Point(128, 279)
    '        '    boton_limpiar.Size = New Point(28, 28)
    '        '    'boton_limpiar.BackColor = Color.White
    '        '    Me.Controls.Add(boton_limpiar)
    '        '    AddHandler boton_limpiar.Click, AddressOf MiControl_Click
    '        'Next
    '        BTNCALIFICAR.Enabled = False
    '        Button9.Visible = True
    '        Button9.Enabled = True

    '    End If
    'End Sub

    Private Sub MiControl_Click(ByVal sender As Object, ByVal e As EventArgs)


        Select Case CType(sender, System.Windows.Forms.CheckBox).CheckState

            Case CheckState.Unchecked

                ' Code for unchecked state.
                If CType(sender, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    pregA = pregA - 1
                    RespA.Text = pregA.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    pregB = pregB - 1
                    RespB.Text = pregB.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    pregC = pregC - 1
                    RespC.Text = pregC.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    pregD = pregD - 1
                    RespD.Text = pregD.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    pregE = pregE - 1
                    RespE.Text = pregE.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    pregF = pregF - 1
                    RespF.Text = pregF.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    pregG = pregG - 1
                    RespG.Text = pregG.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    pregH = pregH - 1
                    RespH.Text = pregH.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    pregCuantitativo = pregCuantitativo - 1
                    RespCuantitativo.Text = pregCuantitativo.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    pregCiudadanas = pregCiudadanas - 1
                    RespCiudadanas.Text = pregCiudadanas.ToString


                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    pregAbierta = pregAbierta - 1
                    RespAbierta.Text = pregAbierta.ToString


                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    componente1 = componente1 - 1
                    Comp1.Text = componente1.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 12 Then
                    componente2 = componente2 - 1
                    Comp2.Text = componente2.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 13 Then
                    componente3 = componente3 - 1
                    Comp3.Text = componente3.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 14 Then
                    componente4 = componente4 - 1
                    Comp4.Text = componente4.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 15 Then
                    competencia1 = competencia1 - 1
                    Compe1.Text = competencia1.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 16 Then
                    competencia2 = competencia2 - 1
                    Compe2.Text = competencia2.ToString

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 17 Then
                    competencia3 = competencia3 - 1
                    Compe3.Text = competencia3.ToString
                End If

            Case CheckState.Checked

                If CType(sender, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    'MsgBox(pregA)
                    pregA = pregA + 1
                    RespA.Text = pregA.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 3) = "1"
                    'MsgBox(numero_pregunta)

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    pregB = pregB + 1
                    RespB.Text = pregB.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 3) = "2"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    pregC = pregC + 1
                    RespC.Text = pregC.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 3) = "3"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    pregD = pregD + 1
                    RespD.Text = pregD.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 3) = "4"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    pregE = pregE + 1
                    RespE.Text = pregE.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 3) = "5"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    pregF = pregF + 1
                    RespF.Text = pregF.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 3) = "6"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    pregG = pregG + 1
                    RespG.Text = pregG.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 3) = "7"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    pregH = pregH + 1
                    RespH.Text = pregH.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 3) = "8"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    pregCuantitativo = pregCuantitativo + 1
                    RespCuantitativo.Text = pregCuantitativo.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 7) = "1"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    pregCiudadanas = pregCiudadanas + 1
                    RespCiudadanas.Text = pregCiudadanas.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 8) = "1"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    pregAbierta = pregAbierta + 1
                    RespAbierta.Text = pregAbierta.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 9) = "1"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    componente1 = componente1 + 1
                    Comp1.Text = componente1.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 4) = "1"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 12 Then
                    componente2 = componente2 + 1
                    Comp2.Text = componente2.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 4) = "2"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 13 Then
                    componente3 = componente3 + 1
                    Comp3.Text = componente3.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 4) = "3"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 14 Then
                    componente4 = componente4 + 1
                    Comp4.Text = componente4.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 4) = "4"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 15 Then
                    competencia1 = competencia1 + 1
                    Compe1.Text = competencia1.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 5) = "1"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 16 Then
                    competencia2 = competencia2 + 1
                    Compe2.Text = competencia2.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 5) = "2"

                ElseIf CType(sender, System.Windows.Forms.CheckBox).TabIndex = 17 Then
                    competencia3 = competencia3 + 1
                    Compe3.Text = competencia3.ToString
                    Dim numero_pregunta As String = CType(sender, System.Windows.Forms.CheckBox).Text
                    matriz(numero_pregunta, 5) = "3"

                End If

            Case CheckState.Indeterminate
        End Select
    End Sub



    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Eliminar un elemento de cada control anteriormente creado
        'El control CERO no se puede eliminar

    End Sub


    'Public Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    '    Dim total_respuestas As Integer
    '    Dim total_componentes As Integer
    '    Dim total_competencias As Integer

    '    total_respuestas = Double.Parse(RespA.Text) + Double.Parse(RespB.Text) + Double.Parse(RespC.Text) + Double.Parse(RespD.Text) + Double.Parse(RespE.Text)
    '    total_componentes = Double.Parse(Comp1.Text) + Double.Parse(Comp2.Text) + Double.Parse(Comp3.Text) + Double.Parse(Comp4.Text)
    '    total_competencias = Double.Parse(Compe1.Text) + Double.Parse(Compe2.Text) + Double.Parse(Compe3.Text)



    '    If Control1 = 1 Then

    '        'total_respuestas = Double.Parse(RespA.Text) + Double.Parse(RespB.Text) + Double.Parse(RespC.Text) + Double.Parse(RespD.Text) + Double.Parse(RespE.Text)

    '        If (Double.Parse(TextBox1.Text) <> total_respuestas) Then
    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
    '        Else

    '            Try
    '                ' el tercer parametro es la posicion pero en este caso no importa porque se puede elegir cualquiera ya que el estudiante puede elegir difernetes materias.
    '                'esta es la materia del componente flexible..

    '                If CBOMATERIA1.Text = "LENGUAJE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA1.Text & "','" & "1" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA1.Text = "MATEMÁTICAS" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA1.Text & "','" & "2" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA1.Text = "BIOLOGÍA" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA1.Text & "','" & "3" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA1.Text = "CIENCIAS SOCIALES" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA1.Text & "','" & "4" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA1.Text = "VIOLENCIA Y SOCIEDAD" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA1.Text & "','" & "5" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA1.Text = "MEDIO AMBIENTE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA1.Text & "','" & "6" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                Else

    '                End If

    '            Catch ex As Exception
    '                MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '            End Try


    '            For b As Integer = 0 To TextBox1.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz(b, 0) & "','" & matriz(b, 1) & "','" & matriz(b, 2) & "','" & matriz(b, 3) & "','" & matriz(b, 4) & "','" & matriz(b, 5) & "','" & matriz(b, 6) & "','" & matriz(b, 7) & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next
    '            MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '            Button9.Enabled = False
    '            CBOMATERIA1.Enabled = False
    '            TextBox1.Enabled = False

    '            CBOMATERIA2.Enabled = True
    '            TextBox2.Enabled = True
    '            Button2.Enabled = True

    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"


    '            ' borrar las preguntas creadas en este caso no hay componentes ni competencias
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox1.Text + 1) * 5) + 102
    '            While counter > 102
    '                '68
    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code to use current value of counter.
    '            End While

    '            TextBox20.Text = CBOMATERIA1.Text

    '        End If
    '    Else

    '        If (Double.Parse(TextBox1.Text) <> total_respuestas) Or (Double.Parse(TextBox1.Text) <> total_componentes) Or (Double.Parse(TextBox1.Text) <> total_competencias) Then
    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")

    '        Else

    '            'guardar los datos de la materia en la base de datos
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            'matriz
    '            ' neyder angarita


    '            If CBNSESION.Text = "1" Then
    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "1" & "','" & CBOMATERIA1.Text & "','" & "" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '                TextBox7.Text = CBOMATERIA1.Text
    '            Else
    '                Try
    '                    ' si es la sexta materia que se registra en la sesion 2...
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "6" & "','" & CBOMATERIA1.Text & "','" & "" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '                TextBox12.Text = CBOMATERIA1.Text
    '            End If

    '            For b As Integer = 0 To TextBox1.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz(b, 0) & "','" & matriz(b, 1) & "','" & matriz(b, 2) & "','" & matriz(b, 3) & "','" & matriz(b, 4) & "','" & matriz(b, 5) & "','" & matriz(b, 6) & "','" & matriz(b, 7) & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next
    '            MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '            Button9.Enabled = False
    '            CBOMATERIA1.Enabled = False
    '            TextBox1.Enabled = False


    '            CBOMATERIA2.Enabled = True
    '            TextBox2.Enabled = True
    '            Button2.Enabled = True
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"


    '            '            For pepe As Integer = 67 To ((TextBox1.Text) * 23) + 2
    '            'Me.Controls.RemoveAt(pepe)
    '            'Next

    '            ' borrar las preguntas creadas
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox1.Text + 1) * 12) + 102
    '            While counter > 102

    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code to use current value of counter.
    '            End While


    '        End If

    '    End If


    '    'CBOMATERIA2.Items.RemoveAt("matematicas")

    '    ' Me.Controls.Remove(sender)


    'End Sub



    'Private Sub Button2_Click(ByVal sender1 As System.Object, ByVal eve As System.EventArgs)

    '    If TextBox2.Text = "" Then

    '        MsgBox("NO SE HA INGRESADO LA CANTIDAD DE PREGUNTAS", 16, "MENSAJE ERROR")

    '    ElseIf Control1 = 1 Then

    '        'total_preguntas = PREGUNTAS_SESION.Text
    '        'PREGUNTAS_SESION.Text = Double.Parse(TextBox2.Text) + PREGUNTAS_SESION.Text

    '        ReDim matriz1(TextBox2.Text - 1, 8)
    '        'Dim b As Integer = TextBox1.Text - 1
    '        For b As Integer = 0 To TextBox2.Text
    '            'prueba(b) = b
    '            ' TextBox1.Textsa  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 

    '            ' guardar el codigo del examen
    '            If (b) < TextBox2.Text Then
    '                matriz1(b, 0) = TXTCODIGO.Text
    '                matriz1(b, 1) = CBOMATERIA2.Text
    '                ' guardar el indicardor de cada pregunta.
    '                'matriz1(b, 2) = b + 1 + total_preguntas
    '                matriz1(b, 2) = b + 1
    '                matriz1(b, 6) = CBNSESION.Text


    '                Dim CMD As New OleDb.OleDbCommand("SELECT Id FROM Materias_Profundizacion WHERE materia='" & CBOMATERIA2.Text & "'", CN)
    '                Dim DR As OleDb.OleDbDataReader
    '                CN.Open()
    '                DR = CMD.ExecuteReader
    '                If DR.Read Then
    '                    tipo = DR(0)
    '                Else
    '                    MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
    '                End If
    '                CN.Close()

    '                matriz1(b, 7) = tipo

    '            End If

    '            For i As Integer = 0 To 11

    '                Dim Pregunta1 As New CheckBox

    '                Pregunta1.Name = "CheckBox" & i.ToString

    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then

    '                    Pregunta1.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl2_Click
    '                End If
    '            Next
    '        Next

    '        Button2.Enabled = False
    '        Button10.Visible = True
    '        Button10.Enabled = True

    '    Else
    '        PREGUNTAS_SESION.Text = Double.Parse(TextBox1.Text) + Double.Parse(TextBox2.Text) + total_preguntas

    '        ReDim matriz1(TextBox2.Text - 1, 8)
    '        'Dim b As Integer = TextBox1.Text - 1
    '        For b As Integer = 0 To TextBox2.Text
    '            'prueba(b) = b
    '            ' TextBox1.Textsa  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 

    '            ' guardar el codigo del examen
    '            If (b) < TextBox2.Text Then
    '                matriz1(b, 0) = TXTCODIGO.Text
    '                matriz1(b, 1) = CBOMATERIA2.Text
    '                ' guardar el indicardor de cada pregunta
    '                matriz1(b, 2) = b + 1 + TextBox1.Text + total_preguntas

    '                matriz1(b, 6) = CBNSESION.Text
    '                matriz1(b, 7) = ""
    '            End If

    '            For i As Integer = 0 To 11

    '                Dim Pregunta1 As New CheckBox
    '                'Dim indice_pregunta1 As New Label
    '                'indice_pregunta1.Name = "label" & i.ToString
    '                'indice_pregunta1.Text = b.ToString
    '                'indice_pregunta1.Location = New Point(80, 355 + (b * 25))
    '                'indice_pregunta1.Size = New Point(20, 14)
    '                'indice_pregunta1.BackColor = Color.White
    '                'Me.Controls.Add(indice_pregunta1)
    '                'AddHandler indice_pregunta1.Click, AddressOf MiControl2_Click

    '                Pregunta1.Name = "CheckBox" & i.ToString

    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then

    '                    Pregunta1.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl2_Click

    '                ElseIf i = 5 Or i = 6 Or i = 7 Or i = 8 Then
    '                    Pregunta1.Location = New Point(100 + (i * 70), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl2_Click

    '                Else
    '                    Pregunta1.Location = New Point(100 + (i * 80), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl2_Click
    '                    'AddHandler BTNSALIR.Click, AddressOf Me.BTNSALIR_Click
    '                End If
    '            Next
    '        Next

    '        Button2.Enabled = False
    '        Button10.Visible = True
    '        Button10.Enabled = True

    '    End If
    'End Sub


    Private Sub MiControl2_Click(ByVal sender1 As Object, ByVal eve As EventArgs)


        Select Case CType(sender1, System.Windows.Forms.CheckBox).CheckState

            Case CheckState.Unchecked

                ' Code for unchecked state.
                If CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    M2pregA = M2pregA - 1
                    RespA.Text = M2pregA.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    M2pregB = M2pregB - 1
                    RespB.Text = M2pregB.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    M2pregC = M2pregC - 1
                    RespC.Text = M2pregC.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    M2pregD = M2pregD - 1
                    RespD.Text = M2pregD.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    M2pregE = M2pregE - 1
                    RespE.Text = M2pregE.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    M2componente1 = M2componente1 - 1
                    Comp1.Text = M2componente1.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    M2componente2 = M2componente2 - 1
                    Comp2.Text = M2componente2.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    M2componente3 = M2componente3 - 1
                    Comp3.Text = M2componente3.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    M2componente4 = M2componente4 - 1
                    Comp4.Text = M2componente4.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    M2competencia1 = M2competencia1 - 1
                    Compe1.Text = M2competencia1.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    M2competencia2 = M2competencia2 - 1
                    Compe2.Text = M2competencia2.ToString

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    M2competencia3 = M2competencia3 - 1
                    Compe3.Text = M2competencia3.ToString
                End If

            Case CheckState.Checked

                If CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    M2pregA = M2pregA + 1
                    RespA.Text = M2pregA.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 3) = "1"
                    'MsgBox(numero_pregunta)

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    M2pregB = M2pregB + 1
                    RespB.Text = M2pregB.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 3) = "2"

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    M2pregC = M2pregC + 1
                    RespC.Text = M2pregC.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 3) = "3"

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    M2pregD = M2pregD + 1
                    RespD.Text = M2pregD.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 3) = "4"

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    M2pregE = M2pregE + 1
                    RespE.Text = M2pregE.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 3) = "5"

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    M2componente1 = M2componente1 + 1
                    Comp1.Text = M2componente1.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 4) = "1"

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    M2componente2 = M2componente2 + 1
                    Comp2.Text = M2componente2.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 4) = "2"

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    M2componente3 = M2componente3 + 1
                    Comp3.Text = M2componente3.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 4) = "3"

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    M2componente4 = M2componente4 + 1
                    Comp4.Text = M2componente4.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 4) = "4"

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    M2competencia1 = M2competencia1 + 1
                    Compe1.Text = M2competencia1.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 5) = "1"

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    M2competencia2 = M2competencia2 + 1
                    Compe2.Text = M2competencia2.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 5) = "2"

                ElseIf CType(sender1, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    M2competencia3 = M2competencia3 + 1
                    Compe3.Text = M2competencia3.ToString
                    Dim numero_pregunta As String = CType(sender1, System.Windows.Forms.CheckBox).Text
                    matriz1(numero_pregunta - 1, 5) = "3"

                End If
            Case CheckState.Indeterminate
        End Select
    End Sub

    'Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim total_respuestas As Integer
    '    Dim total_componentes As Integer
    '    Dim total_competencias As Integer

    '    total_respuestas = Double.Parse(RespA.Text) + Double.Parse(RespB.Text) + Double.Parse(RespC.Text) + Double.Parse(RespD.Text) + Double.Parse(RespE.Text)
    '    total_componentes = Double.Parse(Comp1.Text) + Double.Parse(Comp2.Text) + Double.Parse(Comp3.Text) + Double.Parse(Comp4.Text)
    '    total_competencias = Double.Parse(Compe1.Text) + Double.Parse(Compe2.Text) + Double.Parse(Compe3.Text)


    '    If Control1 = 1 Then


    '        If (Double.Parse(TextBox2.Text) <> total_respuestas) Then
    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
    '        Else


    '            Try
    '                ' el tercer parametro es la posicion pero en este caso no importa porque se puede elegir cualquiera ya que el estudiante puede elegir difernetes materias.
    '                'esta es la materia del componente flexible..

    '                If CBOMATERIA2.Text = "LENGUAJE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "" & "','" & CBOMATERIA2.Text & "','" & "1" & "','" & TextBox2.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA2.Text = "MATEMÁTICAS" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "" & "','" & CBOMATERIA2.Text & "','" & "2" & "','" & TextBox2.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA2.Text = "BIOLOGÍA" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "" & "','" & CBOMATERIA2.Text & "','" & "3" & "','" & TextBox2.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA2.Text = "CIENCIAS SOCIALES" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "" & "','" & CBOMATERIA2.Text & "','" & "4" & "','" & TextBox2.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA2.Text = "VIOLENCIA Y SOCIEDAD" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "" & "','" & CBOMATERIA2.Text & "','" & "5" & "','" & TextBox2.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA2.Text = "MEDIO AMBIENTE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "" & "','" & CBOMATERIA2.Text & "','" & "6" & "','" & TextBox2.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                Else

    '                End If

    '            Catch ex As Exception
    '                MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '            End Try





    '            For b As Integer = 0 To TextBox2.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz1(b, 0) & "','" & matriz1(b, 1) & "','" & matriz1(b, 2) & "','" & matriz1(b, 3) & "','" & matriz1(b, 4) & "','" & matriz1(b, 5) & "','" & matriz1(b, 6) & "','" & matriz1(b, 7) & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next
    '            MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            Button10.Enabled = False
    '            CBOMATERIA2.Enabled = False
    '            TextBox2.Enabled = False

    '            Button4.Enabled = True
    '            CBMATERIA3.Enabled = True
    '            TextBox3.Enabled = True

    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"




    '            ' borrar las preguntas creadas en este caso no hay componentes ni competencias
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox2.Text + 1) * 5) + 102
    '            While counter > 102

    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code to use current value of counter.
    '            End While

    '            TextBox19.Text = CBOMATERIA2.Text

    '        End If

    '        'Me.Close()
    '    Else

    '        If (Double.Parse(TextBox2.Text) <> total_respuestas) Or (Double.Parse(TextBox2.Text) <> total_componentes) Or (Double.Parse(TextBox2.Text) <> total_competencias) Then
    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
    '        Else
    '            'guardar los datos de la materia en la base de datos
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            'matriz

    '            If CBNSESION.Text = "1" Then
    '                Try

    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "2" & "','" & CBOMATERIA2.Text & "','" & "" & "','" & TextBox2.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '                TextBox8.Text = CBOMATERIA2.Text


    '            Else
    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "7" & "','" & CBOMATERIA2.Text & "','" & "" & "','" & TextBox2.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try

    '                TextBox13.Text = CBOMATERIA2.Text
    '            End If


    '            For b As Integer = 0 To TextBox2.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz1(b, 0) & "','" & matriz1(b, 1) & "','" & matriz1(b, 2) & "','" & matriz1(b, 3) & "','" & matriz1(b, 4) & "','" & matriz1(b, 5) & "','" & matriz1(b, 6) & "','" & matriz1(b, 7) & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next
    '            MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '            Button10.Enabled = False
    '            CBOMATERIA2.Enabled = False
    '            TextBox2.Enabled = False

    '            Button4.Enabled = True
    '            CBMATERIA3.Enabled = True
    '            TextBox3.Enabled = True

    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"

    '            ' borrar las preguntas creadas
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox2.Text + 1) * 12) + 102
    '            While counter > 102

    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code to use current value of counter.
    '            End While


    '        End If
    '    End If

    'End Sub



    'Private Sub Button4_Click(ByVal sender2 As System.Object, ByVal e As System.EventArgs)


    '    If TextBox3.Text = "" Then

    '        MsgBox("NO SE HA INGRESADO LA CANTIDAD DE PREGUNTAS", 16, "MENSAJE ERROR")

    '    ElseIf Control1 = 1 Then

    '        'total_preguntas = PREGUNTAS_SESION.Text

    '        'PREGUNTAS_SESION.Text = Double.Parse(TextBox2.Text) + PREGUNTAS_SESION.Text

    '        ReDim matriz2(TextBox3.Text - 1, 8)
    '        'Dim b As Integer = TextBox1.Text - 1
    '        For b As Integer = 0 To TextBox3.Text
    '            'prueba(b) = b
    '            ' TextBox1.Textsa  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 

    '            ' guardar el codigo del examen
    '            If (b) < TextBox3.Text Then
    '                matriz2(b, 0) = TXTCODIGO.Text
    '                matriz2(b, 1) = CBMATERIA3.Text
    '                ' guardar el indicardor de cada pregunta.
    '                'matriz1(b, 2) = b + 1 + total_preguntas
    '                matriz2(b, 2) = b + 1
    '                matriz2(b, 6) = CBNSESION.Text


    '                Dim CMD As New OleDb.OleDbCommand("SELECT Id FROM Materias_Profundizacion WHERE materia='" & CBMATERIA3.Text & "'", CN)
    '                Dim DR As OleDb.OleDbDataReader
    '                CN.Open()
    '                DR = CMD.ExecuteReader
    '                If DR.Read Then
    '                    tipo = DR(0)
    '                Else
    '                    MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
    '                End If
    '                CN.Close()

    '                matriz2(b, 7) = tipo

    '            End If

    '            For i As Integer = 0 To 11

    '                Dim Pregunta1 As New CheckBox

    '                Pregunta1.Name = "CheckBox" & i.ToString

    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then

    '                    Pregunta1.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl3_Click
    '                End If
    '            Next
    '        Next

    '        Button4.Enabled = False
    '        Button11.Visible = True
    '        Button11.Enabled = True

    '    Else

    '        PREGUNTAS_SESION.Text = Double.Parse(TextBox1.Text) + Double.Parse(TextBox2.Text) + Double.Parse(TextBox3.Text) + total_preguntas

    '        ReDim matriz2(TextBox3.Text - 1, 8)
    '        'Dim b As Integer = TextBox1.Text - 1
    '        For b As Integer = 0 To TextBox3.Text
    '            'prueba(b) = b
    '            ' TextBox3.Textsa  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 

    '            ' guardar el codigo del examen
    '            If (b) < TextBox3.Text Then
    '                matriz2(b, 0) = TXTCODIGO.Text
    '                matriz2(b, 1) = CBMATERIA3.Text
    '                ' guardar el indicardor de cada pregunta.
    '                matriz2(b, 2) = b + 1 + TextBox1.Text + TextBox2.Text + total_preguntas
    '                matriz2(b, 6) = CBNSESION.Text
    '                matriz2(b, 7) = ""

    '            End If

    '            For i As Integer = 0 To 11

    '                Dim Pregunta1 As New CheckBox

    '                Pregunta1.Name = "CheckBox" & i.ToString

    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then

    '                    Pregunta1.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl3_Click

    '                ElseIf i = 5 Or i = 6 Or i = 7 Or i = 8 Then
    '                    Pregunta1.Location = New Point(100 + (i * 70), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl3_Click

    '                Else
    '                    Pregunta1.Location = New Point(100 + (i * 80), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl3_Click
    '                    'AddHandler BTNSALIR.Click, AddressOf Me.BTNSALIR_Click
    '                End If
    '            Next

    '        Next

    '        Button4.Enabled = False
    '        Button11.Visible = True
    '        Button11.Enabled = True

    '    End If
    'End Sub



    Private Sub MiControl3_Click(ByVal sender2 As Object, ByVal eve As EventArgs)

        Select Case CType(sender2, System.Windows.Forms.CheckBox).CheckState

            Case CheckState.Unchecked

                ' Code for unchecked state.
                If CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    M3pregA = M3pregA - 1
                    RespA.Text = M3pregA.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    M3pregB = M3pregB - 1
                    RespB.Text = M3pregB.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    M3pregC = M3pregC - 1
                    RespC.Text = M3pregC.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    M3pregD = M3pregD - 1
                    RespD.Text = M3pregD.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    M3pregE = M3pregE - 1
                    RespE.Text = M3pregE.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    M3componente1 = M3componente1 - 1
                    Comp1.Text = M3componente1.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    M3componente2 = M3componente2 - 1
                    Comp2.Text = M3componente2.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    M3componente3 = M3componente3 - 1
                    Comp3.Text = M3componente3.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    M3componente4 = M3componente4 - 1
                    Comp4.Text = M3componente4.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    M3competencia1 = M3competencia1 - 1
                    Compe1.Text = M3competencia1.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    M3competencia2 = M3competencia2 - 1
                    Compe2.Text = M3competencia2.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    M3competencia3 = M3competencia3 - 1
                    Compe3.Text = M3competencia3.ToString
                End If

            Case CheckState.Checked

                If CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    M3pregA = M3pregA + 1
                    RespA.Text = M3pregA.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 3) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    M3pregB = M3pregB + 1
                    RespB.Text = M3pregB.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 3) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    M3pregC = M3pregC + 1
                    RespC.Text = M3pregC.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 3) = "3"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    M3pregD = M3pregD + 1
                    RespD.Text = M3pregD.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 3) = "4"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    M3pregE = M3pregE + 1
                    RespE.Text = M3pregE.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 3) = "5"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    M3componente1 = M3componente1 + 1
                    Comp1.Text = M3componente1.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 4) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    M3componente2 = M3componente2 + 1
                    Comp2.Text = M3componente2.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 4) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    M3componente3 = M3componente3 + 1
                    Comp3.Text = M3componente3.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 4) = "3"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    M3componente4 = M3componente4 + 1
                    Comp4.Text = M3componente4.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 4) = "4"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    M3competencia1 = M3competencia1 + 1
                    Compe1.Text = M3competencia1.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 5) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    M3competencia2 = M3competencia2 + 1
                    Compe2.Text = M3competencia2.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 5) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    M3competencia3 = M3competencia3 + 1
                    Compe3.Text = M3competencia3.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz2(numero_pregunta - 1, 5) = "3"

                End If
            Case CheckState.Indeterminate
        End Select

    End Sub

    'Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim total_respuestas As Integer
    '    Dim total_componentes As Integer
    '    Dim total_competencias As Integer

    '    total_respuestas = Double.Parse(RespA.Text) + Double.Parse(RespB.Text) + Double.Parse(RespC.Text) + Double.Parse(RespD.Text) + Double.Parse(RespE.Text)
    '    total_componentes = Double.Parse(Comp1.Text) + Double.Parse(Comp2.Text) + Double.Parse(Comp3.Text) + Double.Parse(Comp4.Text)
    '    total_competencias = Double.Parse(Compe1.Text) + Double.Parse(Compe2.Text) + Double.Parse(Compe3.Text)


    '    If Control1 = 1 Then


    '        If (Double.Parse(TextBox3.Text) <> total_respuestas) Then
    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
    '        Else


    '            Try
    '                ' el tercer parametro es la posicion pero en este caso no importa porque se puede elegir cualquiera ya que el estudiante puede elegir difernetes materias.
    '                'esta es la materia del componente flexible..

    '                If CBMATERIA3.Text = "LENGUAJE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBMATERIA3.Text & "','" & "1" & "','" & TextBox3.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBMATERIA3.Text = "MATEMÁTICAS" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBMATERIA3.Text & "','" & "2" & "','" & TextBox3.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBMATERIA3.Text = "BIOLOGÍA" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBMATERIA3.Text & "','" & "3" & "','" & TextBox3.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBMATERIA3.Text = "CIENCIAS SOCIALES" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBMATERIA3.Text & "','" & "4" & "','" & TextBox3.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBMATERIA3.Text = "VIOLENCIA Y SOCIEDAD" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBMATERIA3.Text & "','" & "5" & "','" & TextBox3.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBMATERIA3.Text = "MEDIO AMBIENTE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBMATERIA3.Text & "','" & "6" & "','" & TextBox3.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                Else

    '                End If

    '            Catch ex As Exception
    '                MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '            End Try


    '            For b As Integer = 0 To TextBox3.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz2(b, 0) & "','" & matriz2(b, 1) & "','" & matriz2(b, 2) & "','" & matriz2(b, 3) & "','" & matriz2(b, 4) & "','" & matriz2(b, 5) & "','" & matriz2(b, 6) & "','" & matriz2(b, 7) & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next
    '            MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '            Button11.Enabled = False
    '            CBMATERIA3.Enabled = False
    '            TextBox3.Enabled = False

    '            TextBox4.Enabled = True
    '            CBOMATERIA4.Enabled = True
    '            Button6.Enabled = True

    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"

    '            ' borrar las preguntas creadas en este caso no hay componentes ni competencias
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox3.Text + 1) * 5) + 102
    '            While counter > 102

    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code to use current value of counter.
    '            End While
    '            TextBox18.Text = CBMATERIA3.Text

    '        End If

    '        'Me.Close()
    '    Else

    '        If (Double.Parse(TextBox3.Text) <> total_respuestas) Or (Double.Parse(TextBox3.Text) <> total_componentes) Or (Double.Parse(TextBox3.Text) <> total_competencias) Then

    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")

    '        Else
    '            'guardar los datos de la materia en la base de datos
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            'matriz


    '            If CBNSESION.Text = "1" Then
    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "3" & "','" & CBMATERIA3.Text & "','" & "" & "','" & TextBox3.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '                TextBox9.Text = CBMATERIA3.Text

    '            Else

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "8" & "','" & CBMATERIA3.Text & "','" & "" & "','" & TextBox3.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try

    '                TextBox14.Text = CBMATERIA3.Text
    '                flexible.Visible = True
    '                flexible.Enabled = True

    '            End If

    '            For b As Integer = 0 To TextBox3.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz2(b, 0) & "','" & matriz2(b, 1) & "','" & matriz2(b, 2) & "','" & matriz2(b, 3) & "','" & matriz2(b, 4) & "','" & matriz2(b, 5) & "','" & matriz2(b, 6) & "','" & matriz2(b, 7) & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next
    '            MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '            Button11.Enabled = False
    '            CBMATERIA3.Enabled = False
    '            TextBox3.Enabled = False

    '            TextBox4.Enabled = True
    '            CBOMATERIA4.Enabled = True
    '            Button6.Enabled = True

    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"

    '            ' borrar las preguntas creadas
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox3.Text + 1) * 12) + 102
    '            While counter > 102

    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code to use current value of counter.
    '            End While

    '        End If

    '    End If

    'End Sub



    'Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If TextBox4.Text = "" Then

    '        MsgBox("NO SE HA INGRESADO LA CANTIDAD DE PREGUNTAS", 16, "MENSAJE ERROR")

    '        ' COMPONENTE FLEXIBLE

    '    ElseIf Control1 = 1 Then

    '        'total_preguntas = PREGUNTAS_SESION.Text

    '        'PREGUNTAS_SESION.Text = Double.Parse(TextBox2.Text) + PREGUNTAS_SESION.Text

    '        ReDim matriz3(TextBox4.Text - 1, 8)
    '        'Dim b As Integer = TextBox1.Text - 1
    '        For b As Integer = 0 To TextBox4.Text
    '            'prueba(b) = b
    '            ' TextBox1.Textsa  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 

    '            ' guardar el codigo del examen
    '            If (b) < TextBox4.Text Then
    '                matriz3(b, 0) = TXTCODIGO.Text
    '                matriz3(b, 1) = CBOMATERIA4.Text
    '                ' guardar el indicardor de cada pregunta.
    '                'matriz1(b, 2) = b + 1 + total_preguntas
    '                matriz3(b, 2) = b + 1
    '                matriz3(b, 6) = CBNSESION.Text


    '                Dim CMD As New OleDb.OleDbCommand("SELECT Id FROM Materias_Profundizacion WHERE materia='" & CBOMATERIA4.Text & "'", CN)
    '                Dim DR As OleDb.OleDbDataReader
    '                CN.Open()
    '                DR = CMD.ExecuteReader
    '                If DR.Read Then
    '                    tipo = DR(0)
    '                Else
    '                    MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
    '                End If
    '                CN.Close()

    '                matriz3(b, 7) = tipo

    '            End If

    '            For i As Integer = 0 To 11

    '                Dim Pregunta1 As New CheckBox

    '                Pregunta1.Name = "CheckBox" & i.ToString

    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then

    '                    Pregunta1.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl4_Click
    '                End If
    '            Next
    '        Next

    '        Button6.Enabled = False
    '        Button12.Visible = True
    '        Button12.Enabled = True

    '    Else


    '        PREGUNTAS_SESION.Text = Double.Parse(TextBox1.Text) + Double.Parse(TextBox2.Text) + Double.Parse(TextBox3.Text) + Double.Parse(TextBox4.Text)

    '        ReDim matriz3(TextBox4.Text - 1, 8)
    '        'Dim b As Integer = TextBox1.Text - 1
    '        For b As Integer = 0 To TextBox4.Text
    '            'prueba(b) = b
    '            ' TextBox3.Textsa  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 

    '            ' guardar el codigo del examen
    '            If (b) < TextBox4.Text Then
    '                matriz3(b, 0) = TXTCODIGO.Text
    '                matriz3(b, 1) = CBOMATERIA4.Text
    '                ' guardar el indicardor de cada pregunta.
    '                matriz3(b, 2) = b + 1 + TextBox1.Text + TextBox2.Text + TextBox3.Text + total_preguntas

    '                matriz3(b, 6) = CBNSESION.Text
    '                matriz3(b, 7) = ""
    '            End If

    '            For i As Integer = 0 To 11

    '                Dim Pregunta1 As New CheckBox

    '                Pregunta1.Name = "CheckBox" & i.ToString

    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then

    '                    Pregunta1.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl4_Click

    '                ElseIf i = 5 Or i = 6 Or i = 7 Or i = 8 Then
    '                    Pregunta1.Location = New Point(100 + (i * 70), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl4_Click

    '                Else
    '                    Pregunta1.Location = New Point(100 + (i * 80), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl4_Click
    '                End If
    '            Next

    '        Next

    '        Button6.Enabled = False
    '        Button12.Visible = True
    '    End If

    'End Sub


    Private Sub MiControl4_Click(ByVal sender2 As Object, ByVal eve As EventArgs)


        Select Case CType(sender2, System.Windows.Forms.CheckBox).CheckState

            Case CheckState.Unchecked

                ' Code for unchecked state.
                If CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    M4pregA = M4pregA - 1
                    RespA.Text = M4pregA.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    M4pregB = M4pregB - 1
                    RespB.Text = M4pregB.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    M4pregC = M4pregC - 1
                    RespC.Text = M4pregC.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    M4pregD = M4pregD - 1
                    RespD.Text = M4pregD.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    M4pregE = M4pregE - 1
                    RespE.Text = M4pregE.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    M4componente1 = M4componente1 - 1
                    Comp1.Text = M4componente1.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    M4componente2 = M4componente2 - 1
                    Comp2.Text = M4componente2.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    M4componente3 = M4componente3 - 1
                    Comp3.Text = M4componente3.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    M4componente4 = M4componente4 - 1
                    Comp4.Text = M4componente4.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    M3competencia1 = M3competencia1 - 1
                    Compe1.Text = M3competencia1.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    M4competencia2 = M4competencia2 - 1
                    Compe2.Text = M4competencia2.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    M4competencia3 = M4competencia3 - 1
                    Compe3.Text = M4competencia3.ToString
                End If

            Case CheckState.Checked

                If CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    M4pregA = M4pregA + 1
                    RespA.Text = M4pregA.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 3) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    M4pregB = M4pregB + 1
                    RespB.Text = M4pregB.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 3) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    M4pregC = M4pregC + 1
                    RespC.Text = M4pregC.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 3) = "3"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    M4pregD = M4pregD + 1
                    RespD.Text = M4pregD.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 3) = "4"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    M4pregE = M4pregE + 1
                    RespE.Text = M4pregE.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 3) = "5"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    M4componente1 = M4componente1 + 1
                    Comp1.Text = M4componente1.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 4) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    M4componente2 = M4componente2 + 1
                    Comp2.Text = M4componente2.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 4) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    M4componente3 = M4componente3 + 1
                    Comp3.Text = M4componente3.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 4) = "3"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    M4componente4 = M4componente4 + 1
                    Comp4.Text = M4componente4.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 4) = "4"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    M4competencia1 = M4competencia1 + 1
                    Compe1.Text = M4competencia1.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 5) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    M4competencia2 = M4competencia2 + 1
                    Compe2.Text = M4competencia2.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 5) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    M4competencia3 = M4competencia3 + 1
                    Compe3.Text = M4competencia3.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz3(numero_pregunta - 1, 5) = "3"

                End If
            Case CheckState.Indeterminate
        End Select

    End Sub

    'Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim total_respuestas As Integer
    '    Dim total_componentes As Integer
    '    Dim total_competencias As Integer

    '    total_respuestas = Double.Parse(RespA.Text) + Double.Parse(RespB.Text) + Double.Parse(RespC.Text) + Double.Parse(RespD.Text) + Double.Parse(RespE.Text)
    '    total_componentes = Double.Parse(Comp1.Text) + Double.Parse(Comp2.Text) + Double.Parse(Comp3.Text) + Double.Parse(Comp4.Text)
    '    total_competencias = Double.Parse(Compe1.Text) + Double.Parse(Compe2.Text) + Double.Parse(Compe3.Text)


    '    If Control1 = 1 Then

    '        'total_respuestas = Double.Parse(RespA.Text) + Double.Parse(RespB.Text) + Double.Parse(RespC.Text) + Double.Parse(RespD.Text) + Double.Parse(RespE.Text)

    '        If (Double.Parse(TextBox4.Text) <> total_respuestas) Then
    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
    '        Else

    '            Try
    '                ' el tercer parametro es la posicion pero en este caso no importa porque se puede elegir cualquiera ya que el estudiante puede elegir difernetes materias.
    '                'esta es la materia del componente flexible..

    '                If CBOMATERIA4.Text = "LENGUAJE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA4.Text & "','" & "1" & "','" & TextBox4.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA4.Text = "MATEMÁTICAS" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA4.Text & "','" & "2" & "','" & TextBox4.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA4.Text = "BIOLOGÍA" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA4.Text & "','" & "3" & "','" & TextBox4.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA4.Text = "CIENCIAS SOCIALES" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA4.Text & "','" & "4" & "','" & TextBox4.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA4.Text = "VIOLENCIA Y SOCIEDAD" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA4.Text & "','" & "5" & "','" & TextBox4.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA4.Text = "MEDIO AMBIENTE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA4.Text & "','" & "6" & "','" & TextBox4.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                Else

    '                End If

    '            Catch ex As Exception
    '                MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '            End Try


    '            For b As Integer = 0 To TextBox4.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz3(b, 0) & "','" & matriz3(b, 1) & "','" & matriz3(b, 2) & "','" & matriz3(b, 3) & "','" & matriz3(b, 4) & "','" & matriz3(b, 5) & "','" & matriz3(b, 6) & "','" & matriz3(b, 7) & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next

    '            MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '            Button12.Enabled = False
    '            CBOMATERIA4.Enabled = False
    '            TextBox4.Enabled = False

    '            CBOMATERIA5.Enabled = True
    '            Button8.Enabled = True
    '            TextBox5.Enabled = True

    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"


    '            ' borrar las preguntas creadas en este caso no hay componentes ni competencias
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox4.Text + 1) * 5) + 102
    '            While counter > 102
    '                '68
    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code to use current value of counter.
    '            End While

    '            TextBox17.Text = CBOMATERIA4.Text

    '        End If

    '    Else


    '        If (Double.Parse(TextBox4.Text) <> total_respuestas) Or (Double.Parse(TextBox4.Text) <> total_componentes) Or (Double.Parse(TextBox4.Text) <> total_competencias) Then
    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
    '        Else
    '            'guardar los datos de la materia en la base de datos
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            'matriz

    '            Try
    '                Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "4" & "','" & CBOMATERIA4.Text & "','" & "" & "','" & TextBox4.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                CN.Open()
    '                CMD.ExecuteNonQuery()
    '                CN.Close()

    '            Catch ex As Exception
    '                MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '            End Try



    '            For b As Integer = 0 To TextBox4.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz3(b, 0) & "','" & matriz3(b, 1) & "','" & matriz3(b, 2) & "','" & matriz3(b, 3) & "','" & matriz3(b, 4) & "','" & matriz3(b, 5) & "','" & matriz3(b, 6) & "','" & matriz3(b, 7) & "')", CN)

    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next
    '            MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '            Button12.Enabled = False
    '            CBOMATERIA4.Enabled = False
    '            TextBox4.Enabled = False

    '            CBOMATERIA5.Enabled = True
    '            Button8.Enabled = True
    '            TextBox5.Enabled = True

    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"

    '            ' borrar las preguntas creadas
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox4.Text + 1) * 12) + 102
    '            While counter > 102

    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code to use current value of counter.
    '            End While
    '            TextBox10.Text = CBOMATERIA4.Text
    '        End If

    '    End If

    'End Sub

    'Private Sub Button8_Click(ByVal sender2 As System.Object, ByVal e As System.EventArgs)

    '    If TextBox5.Text = "" Then

    '        MsgBox("NO SE HA INGRESADO LA CANTIDAD DE PREGUNTAS", 16, "MENSAJE ERROR")

    '    ElseIf Control1 = 1 Then

    '        'total_preguntas = PREGUNTAS_SESION.Text
    '        'PREGUNTAS_SESION.Text = Double.Parse(TextBox2.Text) + PREGUNTAS_SESION.Text

    '        ReDim matriz4(TextBox5.Text - 1, 8)
    '        'Dim b As Integer = TextBox1.Text - 1
    '        For b As Integer = 0 To TextBox5.Text
    '            'prueba(b) = b
    '            ' TextBox1.Textsa  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 

    '            ' guardar el codigo del examen
    '            If (b) < TextBox5.Text Then
    '                matriz4(b, 0) = TXTCODIGO.Text
    '                matriz4(b, 1) = CBOMATERIA5.Text
    '                ' guardar el indicardor de cada pregunta.
    '                'matriz1(b, 2) = b + 1 + total_preguntas
    '                matriz4(b, 2) = b + 1
    '                matriz4(b, 6) = CBNSESION.Text


    '                Dim CMD As New OleDb.OleDbCommand("SELECT Id FROM Materias_Profundizacion WHERE materia='" & CBOMATERIA5.Text & "'", CN)
    '                Dim DR As OleDb.OleDbDataReader
    '                CN.Open()
    '                DR = CMD.ExecuteReader
    '                If DR.Read Then
    '                    tipo = DR(0)
    '                Else
    '                    MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
    '                End If
    '                CN.Close()

    '                matriz4(b, 7) = tipo

    '            End If

    '            For i As Integer = 0 To 11

    '                Dim Pregunta1 As New CheckBox

    '                Pregunta1.Name = "CheckBox" & i.ToString

    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then

    '                    Pregunta1.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl5_Click
    '                End If
    '            Next
    '        Next

    '        Button8.Enabled = False
    '        Button13.Visible = True
    '        Button13.Enabled = True

    '    Else

    '        PREGUNTAS_SESION.Text = Double.Parse(TextBox1.Text) + Double.Parse(TextBox2.Text) + Double.Parse(TextBox3.Text) + Double.Parse(TextBox4.Text) + Double.Parse(TextBox5.Text)

    '        ReDim matriz4(TextBox5.Text - 1, 8)
    '        'Dim b As Integer = TextBox1.Text - 1
    '        For b As Integer = 0 To TextBox5.Text
    '            'prueba(b) = b
    '            ' TextBox3.Textsa  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 

    '            ' guardar el codigo del examen
    '            If (b) < TextBox5.Text Then
    '                matriz4(b, 0) = TXTCODIGO.Text
    '                matriz4(b, 1) = CBOMATERIA5.Text
    '                ' guardar el indicardor de cada pregunta.
    '                matriz4(b, 2) = b + 1 + TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text + total_preguntas
    '                matriz4(b, 6) = CBNSESION.Text
    '                matriz4(b, 7) = ""
    '            End If

    '            For i As Integer = 0 To 11

    '                Dim Pregunta1 As New CheckBox

    '                Pregunta1.Name = "CheckBox" & i.ToString

    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then

    '                    Pregunta1.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl5_Click

    '                ElseIf i = 5 Or i = 6 Or i = 7 Or i = 8 Then
    '                    Pregunta1.Location = New Point(100 + (i * 70), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl5_Click

    '                Else
    '                    Pregunta1.Location = New Point(100 + (i * 80), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl5_Click
    '                End If
    '            Next

    '        Next

    '        Button8.Enabled = False
    '        Button13.Visible = True

    '        total_preguntas = Double.Parse(TextBox1.Text) + Double.Parse(TextBox2.Text) + Double.Parse(TextBox3.Text) + Double.Parse(TextBox4.Text) + Double.Parse(TextBox5.Text)

    '    End If

    'End Sub


    Private Sub MiControl5_Click(ByVal sender2 As Object, ByVal eve As EventArgs)


        Select Case CType(sender2, System.Windows.Forms.CheckBox).CheckState

            Case CheckState.Unchecked

                ' Code for unchecked state.
                If CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    M5pregA = M5pregA - 1
                    RespA.Text = M5pregA.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    M5pregB = M5pregB - 1
                    RespB.Text = M5pregB.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    M5pregC = M5pregC - 1
                    RespC.Text = M5pregC.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    M5pregD = M5pregD - 1
                    RespD.Text = M5pregD.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    M5pregE = M5pregE - 1
                    RespE.Text = M5pregE.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    M5componente1 = M5componente1 - 1
                    Comp1.Text = M5componente1.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    M5componente2 = M5componente2 - 1
                    Comp2.Text = M5componente2.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    M5componente3 = M5componente3 - 1
                    Comp3.Text = M5componente3.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    M5componente4 = M5componente4 - 1
                    Comp4.Text = M5componente4.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    M5competencia1 = M5competencia1 - 1
                    Compe1.Text = M5competencia1.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    M5competencia2 = M5competencia2 - 1
                    Compe2.Text = M5competencia2.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    M5competencia3 = M5competencia3 - 1
                    Compe3.Text = M5competencia3.ToString
                End If

            Case CheckState.Checked

                If CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    M5pregA = M5pregA + 1
                    RespA.Text = M5pregA.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 3) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    M5pregB = M5pregB + 1
                    RespB.Text = M5pregB.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 3) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    M5pregC = M5pregC + 1
                    RespC.Text = M5pregC.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 3) = "3"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    M5pregD = M5pregD + 1
                    RespD.Text = M5pregD.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 3) = "4"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    M5pregE = M5pregE + 1
                    RespE.Text = M5pregE.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 3) = "5"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    M5componente1 = M5componente1 + 1
                    Comp1.Text = M5componente1.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 4) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    M5componente2 = M5componente2 + 1
                    Comp2.Text = M5componente2.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 4) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    M5componente3 = M5componente3 + 1
                    Comp3.Text = M5componente3.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 4) = "3"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    M5componente4 = M5componente4 + 1
                    Comp4.Text = M5componente4.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 4) = "4"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    M5competencia1 = M5competencia1 + 1
                    Compe1.Text = M5competencia1.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 5) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    M5competencia2 = M5competencia2 + 1
                    Compe2.Text = M5competencia2.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 5) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    M5competencia3 = M5competencia3 + 1
                    Compe3.Text = M5competencia3.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz4(numero_pregunta - 1, 5) = "3"

                End If
            Case CheckState.Indeterminate
        End Select

    End Sub


    'Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim total_respuestas As Integer
    '    Dim total_componentes As Integer
    '    Dim total_competencias As Integer

    '    total_respuestas = Double.Parse(RespA.Text) + Double.Parse(RespB.Text) + Double.Parse(RespC.Text) + Double.Parse(RespD.Text) + Double.Parse(RespE.Text)
    '    total_componentes = Double.Parse(Comp1.Text) + Double.Parse(Comp2.Text) + Double.Parse(Comp3.Text) + Double.Parse(Comp4.Text)
    '    total_competencias = Double.Parse(Compe1.Text) + Double.Parse(Compe2.Text) + Double.Parse(Compe3.Text)

    '    If Control1 = 1 Then

    '        If (Double.Parse(TextBox5.Text) <> total_respuestas) Then
    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
    '        Else


    '            Try
    '                ' el tercer parametro es la posicion pero en este caso no importa porque se puede elegir cualquiera ya que el estudiante puede elegir difernetes materias.
    '                'esta es la materia del componente flexible..


    '                If CBOMATERIA5.Text = "LENGUAJE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA5.Text & "','" & "1" & "','" & TextBox5.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA5.Text = "MATEMÁTICAS" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA5.Text & "','" & "2" & "','" & TextBox5.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA5.Text = "BIOLOGÍA" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA5.Text & "','" & "3" & "','" & TextBox5.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA5.Text = "CIENCIAS SOCIALES" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA5.Text & "','" & "4" & "','" & TextBox5.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA5.Text = "VIOLENCIA Y SOCIEDAD" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA5.Text & "','" & "5" & "','" & TextBox5.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA5.Text = "MEDIO AMBIENTE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA5.Text & "','" & "6" & "','" & TextBox5.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                Else

    '                End If

    '            Catch ex As Exception
    '                MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '            End Try


    '            For b As Integer = 0 To TextBox5.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz4(b, 0) & "','" & matriz4(b, 1) & "','" & matriz4(b, 2) & "','" & matriz4(b, 3) & "','" & matriz4(b, 4) & "','" & matriz4(b, 5) & "','" & matriz4(b, 6) & "','" & matriz4(b, 7) & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next
    '            MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '            Button13.Enabled = False       'boton azul 
    '            CBOMATERIA5.Enabled = False
    '            TextBox5.Enabled = False      'boton verde  

    '            TextBox6.Enabled = True
    '            CBOMATERIA6.Enabled = True
    '            Button15.Enabled = True        'boton verde siguiente

    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"

    '            ' borrar las preguntas creadas en este caso no hay componentes ni competencias
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox5.Text + 1) * 5) + 102
    '            While counter > 102

    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code to use current value of counter.
    '            End While

    '            TextBox16.Text = CBOMATERIA5.Text

    '        End If

    '        'Me.Close()
    '    Else


    '        If (Double.Parse(TextBox5.Text) <> total_respuestas) Or (Double.Parse(TextBox5.Text) <> total_componentes) Or (Double.Parse(TextBox5.Text) <> total_competencias) Then
    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
    '        Else
    '            'guardar los datos de la materia en la base de datos
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            'matriz
    '            Try
    '                Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & "5" & "','" & CBOMATERIA5.Text & "','" & "" & "','" & TextBox5.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                CN.Open()
    '                CMD.ExecuteNonQuery()
    '                CN.Close()

    '            Catch ex As Exception
    '                MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '            End Try


    '            For b As Integer = 0 To TextBox5.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz4(b, 0) & "','" & matriz4(b, 1) & "','" & matriz4(b, 2) & "','" & matriz4(b, 3) & "','" & matriz4(b, 4) & "','" & matriz4(b, 5) & "','" & matriz4(b, 6) & "','" & matriz4(b, 7) & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next
    '            MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '            Button13.Enabled = False
    '            CBOMATERIA5.Enabled = False
    '            TextBox5.Enabled = False
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"



    '            ' borrar las preguntas creadas
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox5.Text + 1) * 12) + 102
    '            While counter > 102

    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code to use current value of counter.
    '            End While
    '            TextBox11.Text = CBOMATERIA5.Text

    '            CBNSESION.Enabled = True
    '            CARGAR_SESION2()
    '            CARGAR_SESION4()

    '        End If

    '    End If

    'End Sub

    Private Sub CBNSESION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBNSESION.SelectedIndexChanged

        If CBNSESION.Text = 2 Then

            'flexible.Visible = True
            total_preguntas = 0
            BTNCREARMATERIA.Enabled = True
            TextBox21.Enabled = True
            TextBox21.Text = ""

            pregA = 0
            pregB = 0
            pregC = 0
            pregD = 0
            pregE = 0
            componente1 = 0
            componente2 = 0
            componente3 = 0
            componente4 = 0
            competencia1 = 0
            competencia2 = 0
            competencia3 = 0

            M2pregA = 0
            M2pregB = 0
            M2pregC = 0
            M2pregD = 0
            M2pregE = 0

            M2componente1 = 0
            M2componente2 = 0
            M2componente3 = 0
            M2componente4 = 0
            M2competencia1 = 0
            M2competencia2 = 0
            M2competencia3 = 0
            M3pregA = 0
            M3pregB = 0
            M3pregC = 0
            M3pregD = 0
            M3pregE = 0
            M3componente1 = 0
            M3componente2 = 0
            M3componente3 = 0
            M3componente4 = 0
            M3competencia1 = 0
            M3competencia2 = 0
            M3competencia3 = 0

            M4pregA = 0
            M4pregB = 0
            M4pregC = 0
            M4pregD = 0
            M4pregE = 0

            M4componente1 = 0
            M4componente2 = 0
            M4componente3 = 0
            M4componente4 = 0
            M4competencia1 = 0
            M4competencia2 = 0
            M4competencia3 = 0

            M5pregA = 0
            M5pregB = 0
            M5pregC = 0
            M5pregD = 0
            M5pregE = 0

            M5componente1 = 0
            M5componente2 = 0
            M5componente3 = 0
            M5componente4 = 0
            M5competencia1 = 0
            M5competencia2 = 0
            M5competencia3 = 0

        Else

            flexible.Visible = True
            total_preguntas = PREGUNTAS_SESION.Text
            BTNCREARMATERIA.Enabled = True
            flexible.Visible = False

            pregA = 0
            pregB = 0
            pregC = 0
            pregD = 0
            pregE = 0
            componente1 = 0
            componente2 = 0
            componente3 = 0
            componente4 = 0
            competencia1 = 0
            competencia2 = 0
            competencia3 = 0
            M2pregA = 0
            M2pregB = 0
            M2pregC = 0
            M2pregD = 0
            M2pregE = 0
            M2componente1 = 0
            M2componente2 = 0
            M2componente3 = 0
            M2componente4 = 0
            M2competencia1 = 0
            M2competencia2 = 0
            M2competencia3 = 0
            M3pregA = 0
            M3pregB = 0
            M3pregC = 0
            M3pregD = 0
            M3pregE = 0
            M3componente1 = 0
            M3componente2 = 0
            M3componente3 = 0
            M3componente4 = 0
            M3competencia1 = 0
            M3competencia2 = 0
            M3competencia3 = 0
            M4pregA = 0
            M4pregB = 0
            M4pregC = 0
            M4pregD = 0
            M4pregE = 0
            M4componente1 = 0
            M4componente2 = 0
            M4componente3 = 0
            M4componente4 = 0
            M4competencia1 = 0
            M4competencia2 = 0
            M4competencia3 = 0
            M5pregA = 0
            M5pregB = 0
            M5pregC = 0
            M5pregD = 0
            M5pregE = 0
            M5componente1 = 0
            M5componente2 = 0
            M5componente3 = 0
            M5componente4 = 0
            M5competencia1 = 0
            M5competencia2 = 0
            M5competencia3 = 0
        End If
    End Sub

    Private Sub flexible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flexible.Click

        If CBNSESION.Text = 2 Then

            Control1 = 1
            BTNCREARMATERIA.Enabled = True
            TextBox21.Enabled = True
            TextBox21.Text = ""

            pregA = 0
            pregB = 0
            pregC = 0
            pregD = 0
            pregE = 0
            componente1 = 0
            componente2 = 0
            componente3 = 0
            componente4 = 0
            competencia1 = 0
            competencia2 = 0
            competencia3 = 0
            M2pregA = 0
            M2pregB = 0
            M2pregC = 0
            M2pregD = 0
            M2pregE = 0
            M2componente1 = 0
            M2componente2 = 0
            M2componente3 = 0
            M2componente4 = 0
            M2competencia1 = 0
            M2competencia2 = 0
            M2competencia3 = 0
            M3pregA = 0
            M3pregB = 0
            M3pregC = 0
            M3pregD = 0
            M3pregE = 0
            M3componente1 = 0
            M3componente2 = 0
            M3componente3 = 0
            M3componente4 = 0
            M3competencia1 = 0
            M3competencia2 = 0
            M3competencia3 = 0
            M4pregA = 0
            M4pregB = 0
            M4pregC = 0
            M4pregD = 0
            M4pregE = 0
            M4componente1 = 0
            M4componente2 = 0
            M4componente3 = 0
            M4componente4 = 0
            M4competencia1 = 0
            M4competencia2 = 0
            M4competencia3 = 0
            M5pregA = 0
            M5pregB = 0
            M5pregC = 0
            M5pregD = 0
            M5pregE = 0
            M5componente1 = 0
            M5componente2 = 0
            M5componente3 = 0
            M5componente4 = 0
            M5competencia1 = 0
            M5competencia2 = 0
            M5competencia3 = 0
        Else
            'BTNCREARMATERIA.Enabled = True
            'TextBox21.Enabled = True
            'TextBox21.Text = ""
        End If


    End Sub


    'Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If TextBox6.Text = "" Then

    '        MsgBox("NO SE HA INGRESADO LA CANTIDAD DE PREGUNTAS", 16, "MENSAJE ERROR")

    '    ElseIf Control1 = 1 Then

    '        'total_preguntas = PREGUNTAS_SESION.Text
    '        'PREGUNTAS_SESION.Text = Double.Parse(TextBox2.Text) + PREGUNTAS_SESION.Text

    '        ReDim matriz5(TextBox6.Text - 1, 8)
    '        'Dim b As Integer = TextBox1.Text - 1
    '        For b As Integer = 0 To TextBox6.Text
    '            'prueba(b) = b
    '            ' TextBox1.Textsa  // cantidad de preguntas
    '            ' indice_pregunta.Text , b   //numero de la pregunta   
    '            ' TXTCODIGO.Text         // Codigo  del examen
    '            ' Pregunta.TabIndex      // pregunta 

    '            ' guardar el codigo del examen
    '            If (b) < TextBox6.Text Then
    '                matriz5(b, 0) = TXTCODIGO.Text
    '                matriz5(b, 1) = CBOMATERIA6.Text
    '                ' guardar el indicardor de cada pregunta.
    '                'matriz1(b, 2) = b + 1 + total_preguntas
    '                matriz5(b, 2) = b + 1
    '                matriz5(b, 6) = CBNSESION.Text


    '                Dim CMD As New OleDb.OleDbCommand("SELECT Id FROM Materias_Profundizacion WHERE materia='" & CBOMATERIA6.Text & "'", CN)
    '                Dim DR As OleDb.OleDbDataReader
    '                CN.Open()
    '                DR = CMD.ExecuteReader
    '                If DR.Read Then
    '                    tipo = DR(0)
    '                Else
    '                    MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
    '                End If
    '                CN.Close()

    '                matriz5(b, 7) = tipo

    '            End If

    '            For i As Integer = 0 To 11

    '                Dim Pregunta1 As New CheckBox

    '                Pregunta1.Name = "CheckBox" & i.ToString

    '                If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then

    '                    Pregunta1.Location = New Point(100 + (i * 40), 355 + (b * 25))
    '                    Pregunta1.Size = New Point(15, 14)
    '                    Pregunta1.TabIndex = i
    '                    Pregunta1.Text = b

    '                    Me.Controls.Add(Pregunta1)
    '                    AddHandler Pregunta1.Click, AddressOf MiControl6_Click
    '                End If
    '            Next
    '        Next

    '        Button15.Enabled = False
    '        Button15.Visible = False
    '        Button14.Visible = True
    '        Button14.Enabled = True
    '    Else
    '    End If
    'End Sub


    Private Sub MiControl6_Click(ByVal sender2 As Object, ByVal eve As EventArgs)


        Select Case CType(sender2, System.Windows.Forms.CheckBox).CheckState

            Case CheckState.Unchecked

                ' Code for unchecked state.
                If CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    M6pregA = M6pregA - 1
                    RespA.Text = M6pregA.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    M6pregB = M6pregB - 1
                    RespB.Text = M6pregB.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    M6pregC = M6pregC - 1
                    RespC.Text = M6pregC.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    M6pregD = M6pregD - 1
                    RespD.Text = M6pregD.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    M6pregE = M6pregE - 1
                    RespE.Text = M6pregE.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    M6componente1 = M6componente1 - 1
                    Comp1.Text = M6componente1.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    M6componente2 = M6componente2 - 1
                    Comp2.Text = M5componente2.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    M6componente3 = M6componente3 - 1
                    Comp3.Text = M6componente3.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    M6componente4 = M6componente4 - 1
                    Comp4.Text = M6componente4.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    M6competencia1 = M6competencia1 - 1
                    Compe1.Text = M6competencia1.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    M6competencia2 = M6competencia2 - 1
                    Compe2.Text = M6competencia2.ToString

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    M6competencia3 = M6competencia3 - 1
                    Compe3.Text = M6competencia3.ToString
                End If

            Case CheckState.Checked

                If CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 0 Then
                    M6pregA = M6pregA + 1
                    RespA.Text = M6pregA.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 3) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 1 Then
                    M6pregB = M6pregB + 1
                    RespB.Text = M6pregB.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 3) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 2 Then
                    M6pregC = M6pregC + 1
                    RespC.Text = M6pregC.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 3) = "3"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 3 Then
                    M6pregD = M6pregD + 1
                    RespD.Text = M6pregD.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 3) = "4"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 4 Then
                    M6pregE = M6pregE + 1
                    RespE.Text = M6pregE.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 3) = "5"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 5 Then
                    M6componente1 = M6componente1 + 1
                    Comp1.Text = M6componente1.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 4) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 6 Then
                    M6componente2 = M6componente2 + 1
                    Comp2.Text = M6componente2.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 4) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 7 Then
                    M6componente3 = M6componente3 + 1
                    Comp3.Text = M6componente3.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 4) = "3"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 8 Then
                    M6componente4 = M6componente4 + 1
                    Comp4.Text = M6componente4.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 4) = "4"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 9 Then
                    M6competencia1 = M6competencia1 + 1
                    Compe1.Text = M6competencia1.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 5) = "1"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 10 Then
                    M6competencia2 = M6competencia2 + 1
                    Compe2.Text = M6competencia2.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 5) = "2"

                ElseIf CType(sender2, System.Windows.Forms.CheckBox).TabIndex = 11 Then
                    M6competencia3 = M6competencia3 + 1
                    Compe3.Text = M6competencia3.ToString
                    Dim numero_pregunta As String = CType(sender2, System.Windows.Forms.CheckBox).Text
                    matriz5(numero_pregunta - 1, 5) = "3"

                End If
            Case CheckState.Indeterminate
        End Select

    End Sub

    'Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim total_respuestas As Integer
    '    Dim total_componentes As Integer
    '    Dim total_competencias As Integer

    '    total_respuestas = Double.Parse(RespA.Text) + Double.Parse(RespB.Text) + Double.Parse(RespC.Text) + Double.Parse(RespD.Text) + Double.Parse(RespE.Text)
    '    total_componentes = Double.Parse(Comp1.Text) + Double.Parse(Comp2.Text) + Double.Parse(Comp3.Text) + Double.Parse(Comp4.Text)
    '    total_competencias = Double.Parse(Compe1.Text) + Double.Parse(Compe2.Text) + Double.Parse(Compe3.Text)

    '    If Control1 = 1 Then

    '        If (Double.Parse(TextBox6.Text) <> total_respuestas) Then
    '            MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
    '        Else


    '            Try
    '                ' el tercer parametro es la posicion pero en este caso no importa porque se puede elegir cualquiera ya que el estudiante puede elegir difernetes materias.
    '                'esta es la materia del componente flexible..

    '                If CBOMATERIA6.Text = "LENGUAJE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA6.Text & "','" & "1" & "','" & TextBox6.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA6.Text = "MATEMÁTICAS" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA6.Text & "','" & "2" & "','" & TextBox6.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA6.Text = "BIOLOGÍA" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA6.Text & "','" & "3" & "','" & TextBox6.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA6.Text = "CIENCIAS SOCIALES" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA6.Text & "','" & "4" & "','" & TextBox6.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA6.Text = "VIOLENCIA Y SOCIEDAD" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA6.Text & "','" & "5" & "','" & TextBox6.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                ElseIf CBOMATERIA6.Text = "MEDIO AMBIENTE" Then
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA6.Text & "','" & "6" & "','" & TextBox6.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()
    '                Else

    '                End If

    '            Catch ex As Exception
    '                MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '            End Try


    '            For b As Integer = 0 To TextBox6.Text - 1

    '                Try
    '                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz5(b, 0) & "','" & matriz5(b, 1) & "','" & matriz5(b, 2) & "','" & matriz5(b, 3) & "','" & matriz5(b, 4) & "','" & matriz5(b, 5) & "','" & matriz5(b, 6) & "','" & matriz5(b, 7) & "')", CN)
    '                    CN.Open()
    '                    CMD.ExecuteNonQuery()
    '                    CN.Close()

    '                Catch ex As Exception
    '                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
    '                End Try
    '            Next
    '            MsgBox("Ha terminado con el registro del Simulacro.", MsgBoxStyle.OkOnly, "Alerta")
    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '            Button13.Enabled = False       'boton azul 
    '            CBOMATERIA6.Enabled = False
    '            TextBox6.Enabled = False      'boton verde  

    '            'TextBox6.Enabled = True
    '            'CBOMATERIA6.Enabled = True
    '            'Button15.Enabled = True        'boton verde siguiente

    '            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '            ' BORRAR LAS CASILLAS DE ESTA MATERIA 

    '            RespA.Text = "0"
    '            RespB.Text = "0"
    '            RespC.Text = "0"
    '            RespD.Text = "0"
    '            RespE.Text = "0"
    '            Comp1.Text = "0"
    '            Comp2.Text = "0"
    '            Comp3.Text = "0"
    '            Comp4.Text = "0"
    '            Compe1.Text = "0"
    '            Compe2.Text = "0"
    '            Compe3.Text = "0"

    '            ' borrar las preguntas creadas en este caso no hay componentes ni competencias
    '            Dim pepe As Integer = 102
    '            Dim counter As Integer = ((TextBox6.Text + 1) * 5) + 102
    '            While counter > 102

    '                counter -= 1
    '                Me.Controls.RemoveAt(pepe)
    '                ' Insert code tso use current value of counter.
    '            End While
    '            TextBox15.Text = CBOMATERIA6.Text

    '        End If

    '    Else

    '    End If

    '    Me.Close()

    'End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCREARMATERIA.Click

        BTNCREARMATERIA.Enabled = False
        Dim materias As New ComboBox
        materias.Name = "CBOMATERIA"
        materias.Location = New Point(100, 280)
        materias.Size = New Point(121, 21)
        materias.TabIndex = 1
        materias.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Controls.Add(materias)
        AddHandler materias.Click, AddressOf materias_Click
        AddHandler materias.SelectedIndexChanged, AddressOf materias_select


        Dim cant_preguntas As New TextBox
        cant_preguntas.Name = "TextBox_preguntas"
        cant_preguntas.Location = New Point(230, 280)
        cant_preguntas.Size = New Point(30, 20)
        cant_preguntas.TabIndex = 1
        Me.Controls.Add(cant_preguntas)
        AddHandler cant_preguntas.KeyPress, AddressOf cant_preguntas_Click

        TextBox21.Enabled = False
        CBNSESION.Enabled = False
        CBOGRADO.Enabled = False
        TXTCODIGO.Enabled = False
        CBOTIPO.Enabled = False

        'If CBNSESION.Text = "1" Then
        'If TextBox21.Text = "0" Then
        '    'TextBox21.Text = ""
        '    TextBox21.Enabled = True
        '    BTNCREARMATERIA.Enabled = False
        '    CBNSESION.Enabled = True
        'End If

        'Else


        'If TextBox21.Text = "0" Then
        '    'TextBox21.Text = ""
        '    TextBox21.Enabled = True
        '    BTNCREARMATERIA.Enabled = False
        '    CBNSESION.Enabled = True
        'End If

        'flexible.Visible = True
        'TextBox1.Visible = True
        'Button1.Visible = True

        'End If


    End Sub

    Private Sub materias_Click(ByVal sender As Object, ByVal eve As EventArgs)

        If CBOTIPO.Text = "saber 3,5 y 9" Then
            Dim DH As New OleDb.OleDbDataAdapter("SELECT materia FROM Materias WHERE prueba='2'", CN)
            Dim DM As New DataSet
            DH.Fill(DM, "Materias")
            CType(sender, System.Windows.Forms.ComboBox).DataSource = DM.Tables("Materias")
            CType(sender, System.Windows.Forms.ComboBox).DisplayMember = "materia"
        Else
            Dim DH As New OleDb.OleDbDataAdapter("SELECT materia FROM Materias WHERE prueba='1'", CN)
            Dim DM As New DataSet
            DH.Fill(DM, "Materias")
            CType(sender, System.Windows.Forms.ComboBox).DataSource = DM.Tables("Materias")
            CType(sender, System.Windows.Forms.ComboBox).DisplayMember = "materia"
        End If

    End Sub

    Private Sub materias_select(ByVal sender As Object, ByVal eve As EventArgs)

        NOMBRE_MATERIA = CType(sender, System.Windows.Forms.ComboBox).Text

    End Sub




    Private Sub cant_preguntas_Click(ByVal sender As Object, ByVal eve As System.Windows.Forms.KeyPressEventArgs)

        ' System.Windows.Forms.InsertKeyMode
        ' If eve1.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
        ' MsgBox("presionó enter", MsgBoxStyle.Information)
        ' End If
        ' Handles textBox1.KeyDown

        'Dim cantidad_preguntas As String
        'Dim cantidad_preguntas2 As String
        'cantidad_preguntas = eve.KeyChar
        'cantidad_preguntas = UCase(eve1.KeyChar)
        'cantidad_preguntas2 = LCase(eve1.KeyChar)

        If eve.KeyChar = Convert.ToChar(Keys.Return) Then
            'If e.KeyChar = ChrW(Keys.Return) Then
            eve.Handled = True
            cant_preguntas = CType(sender, System.Windows.Forms.TextBox).Text
            Button18.Visible = True
            'cantidad_preguntas = eve.KeyChar
        ElseIf eve.KeyChar = " "c Then
            ' si se pulsa en el punto se convertirá en coma
            eve.Handled = True
            'cantidad_preguntas = eve.KeyChar
        End If



    End Sub


    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click



        If cant_preguntas = "" Then
            MsgBox("NO SE HA INGRESADO LA CANTIDAD DE PREGUNTAS", 16, "MENSAJE ERROR")
            Button18.Visible = False


        ElseIf Control1 = 1 Then

            'total_preguntas = PREGUNTAS_SESION.Text
            'PREGUNTAS_SESION.Text = Double.Parse(TextBox1.Text) + PREGUNTAS_SESION.Text

            ReDim matriz(cant_preguntas - 1, 8)

            'ESTO ES PARA LAS DE " COMPONENTE FLEXIBLE "

            For b As Integer = 0 To cant_preguntas
                'prueba(b) = b
                ' TextBox1.Text  // cantidad de preguntas
                ' indice_pregunta.Text , b   //numero de la pregunta   
                ' TXTCODIGO.Text         // Codigo  del examen
                ' Pregunta.TabIndex      // pregunta 
                ' guardar el codigo del examen


                If (b) < cant_preguntas Then
                    matriz(b, 0) = TXTCODIGO.Text
                    matriz(b, 1) = NOMBRE_MATERIA
                    ' guardar el indicardor de cada pregunta.
                    'matriz(b, 2) = b + 1 + total_preguntas  ' asi estaba 
                    'matriz3(b, 2) = b + 1 + TextBox1.Text + TextBox2.Text + TextBox3.Text + total_preguntas


                    matriz(b, 2) = b + 1 + total_preguntas

                    matriz(b, 6) = CBNSESION.Text

                    Dim CMD As New OleDb.OleDbCommand("SELECT Id FROM Materias_Profundizacion WHERE materia='" & NOMBRE_MATERIA & "'", CN)
                    Dim DR As OleDb.OleDbDataReader
                    CN.Open()
                    DR = CMD.ExecuteReader
                    If DR.Read Then
                        tipo = DR(0)
                    Else
                        MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
                    End If
                    CN.Close()
                    matriz(b, 7) = tipo

                End If

                For i As Integer = 0 To 15
                    Dim Pregunta As New CheckBox
                    Pregunta.Name = "CheckBox" & i.ToString
                    If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then
                        Pregunta.Location = New Point(100 + (i * 40), 355 + (b * 25))
                        Pregunta.Size = New Point(15, 14)
                        Pregunta.TabIndex = i
                        Pregunta.Text = b

                        Me.Controls.Add(Pregunta)
                        AddHandler Pregunta.Click, AddressOf MiControl_Click
                    End If
                Next
            Next

            Button18.Visible = False
            Button17.Visible = True
            Button17.Enabled = True

            'PREGUNTAS_SESION.Text = Double.Parse(cant_preguntas) + Double.Parse(PREGUNTAS_SESION.Text)


            'BTNCALIFICAR.Enabled = False
            'Button9.Visible = True
            'Button9.Enabled = True


        Else
            '###################### VALIDAD SI YA EXISTE EL CODIGO DE ALGUNA FORMA ###################

            ReDim matriz(cant_preguntas - 1, 9)
            For b As Integer = 0 To cant_preguntas - 1
                'prueba(b) = b
                ' TextBox1.Text  // cantidad de preguntas
                ' indice_pregunta.Text , b   //numero de la pregunta   
                ' TXTCODIGO.Text         // Codigo  del examen
                ' Pregunta.TabIndex      // pregunta 

                ' guardar el codigo del examen
                If (b) < cant_preguntas Then
                    matriz(b, 0) = TXTCODIGO.Text
                    matriz(b, 1) = NOMBRE_MATERIA
                    ' guardar el indicardor de cada pregunta.
                    'matriz(b, 2) = b + 1

                    If CBNSESION.Text = "1" Then
                        matriz(b, 2) = b + 1 + total_preguntas
                    Else
                        'declarar un variable total_preguntas para igualarla  
                        matriz(b, 2) = b + 1 + total_preguntas
                    End If

                    matriz(b, 6) = CBNSESION.Text
                    'matriz(b, 7) = ""
                End If

                For i As Integer = 0 To 17
                    Dim Pregunta As New CheckBox
                    'Dim indice_pregunta As New Label

                    'indice_pregunta.Name = "label" & i.ToString
                    'indice_pregunta.Text = b.ToString
                    'indice_pregunta.Location = New Point(80, 355 + (b * 25))
                    'indice_pregunta.Size = New Point(20, 14)
                    'indice_pregunta.BackColor = Color.White
                    'Me.Controls.Add(indice_pregunta)

                    'AddHandler indice_pregunta.Click, AddressOf MiControl_Click
                    Pregunta.Name = "CheckBox" & i.ToString

                    If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Or i = 5 Or i = 6 Or i = 7 Then
                        Pregunta.Location = New Point(30 + (i * 40), 380 + (b * 25))
                        Pregunta.Size = New Point(15, 14)
                        Pregunta.TabIndex = i
                        Pregunta.Text = b

                        Me.Controls.Add(Pregunta)
                        AddHandler Pregunta.Click, AddressOf MiControl_Click
                    ElseIf i = 8 Or i = 9 Or i = 10 Then
                        Pregunta.Location = New Point(30 + (i * 44), 380 + (b * 25))
                        Pregunta.Size = New Point(15, 14)
                        Pregunta.TabIndex = i
                        Pregunta.Text = b

                        Me.Controls.Add(Pregunta)
                        AddHandler Pregunta.Click, AddressOf MiControl_Click

                    ElseIf i = 11 Or i = 12 Or i = 13 Or i = 14 Then
                        Pregunta.Location = New Point((i * 54), 380 + (b * 25))
                        Pregunta.Size = New Point(15, 14)
                        Pregunta.TabIndex = i
                        Pregunta.Text = b

                        Me.Controls.Add(Pregunta)
                        AddHandler Pregunta.Click, AddressOf MiControl_Click

                    Else
                        Pregunta.Location = New Point((i * 59), 380 + (b * 25))
                        Pregunta.Size = New Point(15, 14)
                        Pregunta.TabIndex = i
                        Pregunta.Text = b

                        Me.Controls.Add(Pregunta)
                        AddHandler Pregunta.Click, AddressOf MiControl_Click
                        'AddHandler BTNSALIR.Click, AddressOf Me.BTNSALIR_Click
                    End If
                Next
            Next
            Button18.Visible = False
            Button17.Visible = True
            Button17.Enabled = True

            PREGUNTAS_SESION.Text = Double.Parse(cant_preguntas) + Double.Parse(PREGUNTAS_SESION.Text)

        End If
    End Sub


    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click


        Dim total_respuestas As Integer
        Dim total_componentes As Integer
        Dim total_competencias As Integer
        Dim total_ciudadanas As Integer
        Dim total_cuantitativos As Integer


        total_respuestas = Double.Parse(RespA.Text) + Double.Parse(RespB.Text) + Double.Parse(RespC.Text) + Double.Parse(RespD.Text) + Double.Parse(RespE.Text) + Double.Parse(RespF.Text) + Double.Parse(RespG.Text) + Double.Parse(RespH.Text)
        total_componentes = Double.Parse(Comp1.Text) + Double.Parse(Comp2.Text) + Double.Parse(Comp3.Text) + Double.Parse(Comp4.Text)
        total_competencias = Double.Parse(Compe1.Text) + Double.Parse(Compe2.Text) + Double.Parse(Compe3.Text)
        total_ciudadanas = Double.Parse(RespCiudadanas.Text)
        total_cuantitativos = Double.Parse(RespCuantitativo.Text)


        If Control1 = 1 Then

            'total_respuestas = Double.Parse(RespA.Text) + Double.Parse(RespB.Text) + Double.Parse(RespC.Text) + Double.Parse(RespD.Text) + Double.Parse(RespE.Text)
            If (Double.Parse(cant_preguntas) <> total_respuestas) Then
                MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
            Else

                Try
                    ' el tercer parametro es la posicion pero en este caso no importa porque se puede elegir cualquiera ya que el estudiante puede elegir difernetes materias.
                    'esta es la materia del componente flexible..

                    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBOGRADO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & NOMBRE_MATERIA & "','" & matriz(0, 7) & "','" & cant_preguntas & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
                    CN.Open()
                    CMD.ExecuteNonQuery()
                    CN.Close()


                    'If CBOMATERIA1.Text = "LENGUAJE" Then
                    '    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & NOMBRE_MATERIA & "','" & "1" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
                    '    CN.Open()
                    '    CMD.ExecuteNonQuery()
                    '    CN.Close()
                    'ElseIf CBOMATERIA1.Text = "MATEMÁTICAS" Then
                    '    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & NOMBRE_MATERIA & "','" & "2" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
                    '    CN.Open()
                    '    CMD.ExecuteNonQuery()
                    '    CN.Close()
                    'ElseIf CBOMATERIA1.Text = "BIOLOGÍA" Then
                    '    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA1.Text & "','" & "3" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
                    '    CN.Open()
                    '    CMD.ExecuteNonQuery()
                    '    CN.Close()
                    'ElseIf CBOMATERIA1.Text = "CIENCIAS SOCIALES" Then
                    '    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA1.Text & "','" & "4" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
                    '    CN.Open()
                    '    CMD.ExecuteNonQuery()
                    '    CN.Close()
                    'ElseIf CBOMATERIA1.Text = "VIOLENCIA Y SOCIEDAD" Then
                    '    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA1.Text & "','" & "5" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
                    '    CN.Open()
                    '    CMD.ExecuteNonQuery()
                    '    CN.Close()
                    'ElseIf CBOMATERIA1.Text = "MEDIO AMBIENTE" Then
                    '    Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBNSESION.Text & "','" & " " & "','" & CBOMATERIA1.Text & "','" & "6" & "','" & TextBox1.Text & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)
                    '    CN.Open()
                    '    CMD.ExecuteNonQuery()
                    '    CN.Close()
                    'Else

                    'End If

                Catch ex As Exception
                    MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
                End Try

                For b As Integer = 0 To cant_preguntas - 1

                    Try
                        Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz(b, 0) & "','" & CBOGRADO.Text & "','" & matriz(b, 1) & "','" & matriz(b, 2) & "','" & matriz(b, 3) & "','" & matriz(b, 4) & "','" & matriz(b, 5) & "','" & matriz(b, 6) & "','" & matriz(b, 7) & "')", CN)
                        CN.Open()
                        CMD.ExecuteNonQuery()
                        CN.Close()

                    Catch ex As Exception
                        MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
                    End Try
                Next
                'restar uno a la pregunta
                TextBox21.Text = TextBox21.Text - 1

                MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                Button17.Enabled = False
                Button17.Visible = False

                'Button9.Enabled = False
                'CBOMATERIA1.Enabled = False
                'TextBox1.Enabled = False

                'CBOMATERIA2.Enabled = True
                'TextBox2.Enabled = True
                'Button2.Enabled = True

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                ' BORRAR LAS CASILLAS DE ESTA MATERIA 

                RespA.Text = "0"
                RespB.Text = "0"
                RespC.Text = "0"
                RespD.Text = "0"
                RespE.Text = "0"
                Comp1.Text = "0"
                Comp2.Text = "0"
                Comp3.Text = "0"
                Comp4.Text = "0"
                Compe1.Text = "0"
                Compe2.Text = "0"
                Compe3.Text = "0"


                ' borrar las preguntas creadas en este caso no hay componentes ni competencias
                Dim pepe As Integer = 47
                Dim counter As Integer = ((cant_preguntas + 1) * 5) + 51
                While counter > 49
                    counter -= 1
                    Me.Controls.RemoveAt(pepe)
                    ' Insert code to use current value of counter.
                End While

                'TextBox20.Text = NOMBRE_MATERIA
                If TextBox21.Text = "0" Then
                    BTNCREARMATERIA.Enabled = False
                    flexible.Enabled = False
                    Me.Close()
                Else
                    BTNCREARMATERIA.Enabled = True
                End If

                pregA = 0
                pregB = 0
                pregC = 0
                pregD = 0
                pregE = 0
                componente1 = 0
                componente2 = 0
                componente3 = 0
                componente4 = 0
                competencia1 = 0
                competencia2 = 0
                competencia3 = 0
                M2pregA = 0
                M2pregB = 0
                M2pregC = 0
                M2pregD = 0
                M2pregE = 0
                M2componente1 = 0
                M2componente2 = 0
                M2componente3 = 0
                M2componente4 = 0
                M2competencia1 = 0
                M2competencia2 = 0
                M2competencia3 = 0
                M3pregA = 0
                M3pregB = 0
                M3pregC = 0
                M3pregD = 0
                M3pregE = 0
                M3componente1 = 0
                M3componente2 = 0
                M3componente3 = 0
                M3componente4 = 0
                M3competencia1 = 0
                M3competencia2 = 0
                M3competencia3 = 0
                M4pregA = 0
                M4pregB = 0
                M4pregC = 0
                M4pregD = 0
                M4pregE = 0
                M4componente1 = 0
                M4componente2 = 0
                M4componente3 = 0
                M4componente4 = 0
                M4competencia1 = 0
                M4competencia2 = 0
                M4competencia3 = 0
                M5pregA = 0
                M5pregB = 0
                M5pregC = 0
                M5pregD = 0
                M5pregE = 0
                M5componente1 = 0
                M5componente2 = 0
                M5componente3 = 0
                M5componente4 = 0
                M5competencia1 = 0
                M5competencia2 = 0
                M5competencia3 = 0
            End If

        Else

            'If (Double.Parse(cant_preguntas) <> total_respuestas) Or (Double.Parse(cant_preguntas) <> total_componentes) Or (Double.Parse(cant_preguntas) <> total_competencias) Then
            If (Double.Parse(cant_preguntas) <> total_respuestas) Then
                MsgBox("Falta Seleccionar alguna opcion de Respuesta", MsgBoxStyle.Information, "Alerta")
            Else
                'guardar los datos de la materia en la base de datos
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                '  matriz
                '  neyder angarita


                If CBNSESION.Text = "1" Then

                    ' CALCULAR EL ORDEN CORRECTO DE LA MATERIA PARA INGRESAR EN LA TABLA Formato_Examen_Cantidad
                    orden_materias = orden_materias + 1
                    TextBox21.Text = TextBox21.Text - 1


                    Try
                        Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBOGRADO.Text & "','" & CBNSESION.Text & "','" & orden_materias & "','" & NOMBRE_MATERIA & "','" & total_cuantitativos & "','" & total_ciudadanas & "','" & cant_preguntas & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)

                        CN.Open()
                        CMD.ExecuteNonQuery()
                        CN.Close()


                    Catch ex As Exception
                        MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
                    End Try

                    If TextBox21.Text = "0" Then
                        CBNSESION.Enabled = True
                        BTNCREARMATERIA.Enabled = False
                    Else
                        BTNCREARMATERIA.Enabled = True
                    End If

                Else

                    orden_materias_2 = orden_materias_2 + 1
                    TextBox21.Text = TextBox21.Text - 1



                    Try
                        ' si es la sexta materia que se registra en la sesion 2...
                        Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen_Cantidad VALUES ( '" & TXTCODIGO.Text & "','" & CBOGRADO.Text & "','" & CBNSESION.Text & "','" & orden_materias_2 & "','" & NOMBRE_MATERIA & "','" & total_cuantitativos & "','" & total_ciudadanas & "','" & cant_preguntas & "','" & Comp1.Text & "','" & Comp2.Text & "','" & Comp3.Text & "','" & Comp4.Text & "','" & Compe1.Text & "','" & Compe2.Text & "','" & Compe3.Text & "')", CN)

                        CN.Open()
                        CMD.ExecuteNonQuery()
                        CN.Close()

                    Catch ex As Exception
                        MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
                    End Try

                    If TextBox21.Text = "0" Then
                        BTNCREARMATERIA.Enabled = False
                    Else
                        BTNCREARMATERIA.Enabled = True
                    End If

                End If

                total_preguntas = cant_preguntas + total_preguntas

                For b As Integer = 0 To cant_preguntas - 1

                    Try
                        Dim CMD As New OleDb.OleDbCommand("INSERT INTO Formato_Examen VALUES ( '" & matriz(b, 0) & "','" & CBOGRADO.Text & "','" & matriz(b, 1) & "','" & matriz(b, 2) & "','" & matriz(b, 3) & "','" & matriz(b, 4) & "','" & matriz(b, 5) & "','" & matriz(b, 6) & "','" & matriz(b, 7) & "','" & matriz(b, 8) & "','" & matriz(b, 9) & "')", CN)
                        CN.Open()
                        CMD.ExecuteNonQuery()
                        CN.Close()

                    Catch ex As Exception
                        MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error")
                    End Try
                Next


                MsgBox("Continue con la siguiente materia", MsgBoxStyle.OkOnly, "Alerta")
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                'Button9.Enabled = False
                'CBOMATERIA1.Enabled = False
                'TextBox1.Enabled = False


                ' CBOMATERIA2.Enabled = True
                ' TextBox2.Enabled = True
                ' Button2.Enabled = True

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                ' BORRAR LAS CASILLAS DE ESTA MATERIA 

                RespA.Text = "0"
                RespB.Text = "0"
                RespC.Text = "0"
                RespD.Text = "0"
                RespE.Text = "0"
                RespF.Text = "0"
                RespG.Text = "0"
                RespH.Text = "0"
                RespCuantitativo.Text = "0"
                RespCiudadanas.Text = "0"
                RespAbierta.Text = "0"

                Comp1.Text = "0"
                Comp2.Text = "0"
                Comp3.Text = "0"
                Comp4.Text = "0"

                Compe1.Text = "0"
                Compe2.Text = "0"
                Compe3.Text = "0"

                pregA = 0
                pregB = 0
                pregC = 0
                pregD = 0
                pregE = 0
                pregF = 0
                pregG = 0
                pregH = 0
                pregCuantitativo = 0
                pregCiudadanas = 0
                pregAbierta = 0

                componente1 = 0
                componente2 = 0
                componente3 = 0
                componente4 = 0
                competencia1 = 0
                competencia2 = 0
                competencia3 = 0


                M2pregA = 0
                M2pregB = 0
                M2pregC = 0
                M2pregD = 0
                M2pregE = 0
                M2componente1 = 0
                M2componente2 = 0
                M2componente3 = 0
                M2componente4 = 0
                M2competencia1 = 0
                M2competencia2 = 0
                M2competencia3 = 0


                M3pregA = 0
                M3pregB = 0

                M3pregC = 0
                M3pregD = 0
                M3pregE = 0
                M3componente1 = 0
                M3componente2 = 0
                M3componente3 = 0
                M3componente4 = 0
                M3competencia1 = 0
                M3competencia2 = 0
                M3competencia3 = 0

                M4pregA = 0
                M4pregB = 0
                M4pregC = 0
                M4pregD = 0
                M4pregE = 0
                M4componente1 = 0
                M4componente2 = 0
                M4componente3 = 0
                M4componente4 = 0
                M4competencia1 = 0
                M4competencia2 = 0
                M4competencia3 = 0

                M5pregA = 0
                M5pregB = 0
                M5pregC = 0
                M5pregD = 0
                M5pregE = 0
                M5componente1 = 0
                M5componente2 = 0
                M5componente3 = 0
                M5componente4 = 0
                M5competencia1 = 0
                M5competencia2 = 0
                M5competencia3 = 0

                ' For pepe As Integer = 67 To ((TextBox1.Text) * 23) + 2
                'Me.Controls.RemoveAt(pepe)
                'Next

                ' borrar las preguntas creadas
                ' " cuando se agrega un nuevo elemento al formulario crear simulacro el valor de donde empieza a borrar es el del While counter > 51 y luego cambiar los otros valores basados en ese"


                'Dim pepe As Integer = 58
                Dim counter As Integer = (cant_preguntas * 18)
                While counter > 0
                    counter -= 1
                    Me.Controls.RemoveAt(pepe)
                    ' Insert code to use current value of counter.
                End While
                Button17.Visible = False
                pepe += 2

            End If
            End If

            'CBOMATERIA2.Items.RemoveAt("matematicas")
            'Me.Controls.Remove(sender)
            'total_preguntas = PREGUNTAS_SESION.Text
    End Sub

End Class


