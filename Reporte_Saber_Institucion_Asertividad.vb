Public Class Reporte_Saber_Institucion_Asertividad

    Public contador_preguntas_de_una_materia As Integer
    Public contador_b As Integer
    Public contador_c As Integer
    Public contador_d As Integer
    Public contador_e As Integer

    Public codigoestudiante As Integer
    'Contador_respuestas_cada_materia
    Dim Contador_respuestas_cada_materia(,)

    Dim Respuestas_Sesion1() As String
    Dim Respuestas_Sesion2() As String

    'guardar la cantidad de materias de cada simulacro
    Dim cantidad_materias_1 As Integer
    Dim cantidad_materias_2 As Integer

    Dim cant_registros As Integer
    Dim sesion1 As Array = Array.CreateInstance(GetType(Integer), 298)

    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Dim Materia_Cantidad_Componentes_Competencias_Sesion1(,)
    Dim Materia_Cantidad_Componentes_Competencias_Sesion2(,)

    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(,)

    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(,)
    Dim Respuestas_Materia_1_Sesion1_Matematicas() As String





    Private Sub CBOCIUDADES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCIUDADES.SelectedIndexChanged
        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios WHERE ciudad='" & CBOCIUDADES.Text & "'", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "colegios")
        CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        CBOCOLEGIOS.DisplayMember = "nombre"
    End Sub


    Private Sub CBOCOLEGIOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCOLEGIOS.SelectedIndexChanged
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios WHERE nombre='" & CBOCOLEGIOS.Text & "'", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "colegios")
        CBOCODIGOSEDE.DataSource = DS.Tables("colegios")
        CBOCODIGOSEDE.DisplayMember = "codigo_colegio"
    End Sub

    Private Sub Reporte_Saber_Institucion_Asertividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Sub CARGAR()
        Dim DG As New OleDb.OleDbDataAdapter("SELECT  nombre_prueba  FROM Pruebas WHERE codigo_prueba='3' OR codigo_prueba='4' ", CN)
        Dim DL As New DataSet
        DG.Fill(DL, "Pruebas")
        CBOTIPO.DataSource = DL.Tables("Pruebas")
        CBOTIPO.DisplayMember = "nombre_prueba"

        Dim DH As New OleDb.OleDbDataAdapter("SELECT  ciudad  FROM colegios GROUP BY ciudad", CN)
        Dim DM As New DataSet
        DH.Fill(DM, "colegios")
        CBOCIUDADES.DataSource = DM.Tables("colegios")
        CBOCIUDADES.DisplayMember = "ciudad"

        'Dim DB As New OleDb.OleDbDataAdapter("SELECT  DISTINCT codigo  FROM Formato_Examen_Cantidad", CN)
        'Dim DD As New DataSet
        'DB.Fill(DD, "Formato_Examen_Cantidad")
        'CBOSIMULACRO.DataSource = DD.Tables("Formato_Examen_Cantidad")
        'CBOSIMULACRO.DisplayMember = "codigo"

    End Sub

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click


        If CBOTIPO.Text = "saber 3,5 y 9" Then

            'AQUI TODO CAMBIA PORQUE SOLO SON 4 MATERIAS MAXIMO
            'VERIFICAR ESO
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% BORRAR DATOS TABLA %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim CMD1 As New OleDb.OleDbCommand("DELETE FROM asertividad_materias WHERE 1", CN)
            CN.Open()
            CMD1.ExecuteNonQuery()
            CN.Close()
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% PRIMERA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5
            Dim CMATERIA_FORMATO1 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND sesion='1' AND tipo_Materia=' '  ORDER BY pregunta ASC", CN)
            Dim DATA_FORMATO1 As New DataSet
            CMATERIA_FORMATO1.Fill(DATA_FORMATO1, "Formato_Examen")
            'Dim cantidad_preguntas_sesion1 As String
            Dim cantidad_preguntas_simulacro_creado As String
            cantidad_preguntas_simulacro_creado = DATA_FORMATO1.Tables(0).Rows.Count
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% OBTENER NÚMERO DE PREGUNTAS DE CADA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim DA As New OleDb.OleDbDataAdapter("SELECT codigo_estudiante FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_3_5_9 WHERE codigo_colegio='" & CBOCODIGOSEDE.Text & "'  ORDER BY codigo_estudiante ASC", CN)
            Dim DQ As New DataSet
            DA.Fill(DQ, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_3_5_9")
            cant_registros = DQ.Tables(0).Rows.Count

            If cant_registros = 0 Then
                MsgBox("NO EXISTEN REGISTROS EN LA TABLA", 16, "ERROR")
                Me.Hide()
            Else

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% OBTENER EL FORMATO DEL EXAMEN  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                Dim DB2 As New OleDb.OleDbDataAdapter("SELECT  orden FROM Formato_Examen_Cantidad WHERE sesion='1' AND tipo_Materia=' ' AND codigo='" & CBOSIMULACRO.Text & "' ORDER BY orden ASC", CN)
                Dim DV2 As New DataSet
                DB2.Fill(DV2, "Formato_Examen_Cantidad")
                cantidad_materias_1 = DV2.Tables(0).Rows.Count
                ' PARA RECORRER LOS EXAMENES DE CADA ESTUDIANTE
                Dim TODAS_MATERIAS As Integer
                TODAS_MATERIAS = cantidad_materias_1

                'cantidad_preguntas_sesion1
                Dim CMATERIA_FORMATO11 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND sesion='1' AND tipo_Materia=' '", CN)
                Dim DATA_FORMATO11 As New DataSet
                CMATERIA_FORMATO11.Fill(DATA_FORMATO11, "Formato_Examen")
                Dim cantidad_preguntas_sesion11 As String
                cantidad_preguntas_sesion11 = DATA_FORMATO11.Tables(0).Rows.Count

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    TODAS LAS MATERIAS  "Formato_Examen_Cantidad" %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                ReDim Materia_Cantidad_Componentes_Competencias_Sesion1(8, cantidad_materias_1 - 1)
                'Materia_Cantidad_Componentes_Competencias_Sesion1 
                Dim DC As New OleDb.OleDbDataAdapter("SELECT  materia,cantidad_preguntas,cantidad_componente1,cantidad_componente2,cantidad_componente3,cantidad_componente4,cantidad_competencias1,cantidad_competencias2,cantidad_competencias3 FROM Formato_Examen_Cantidad WHERE sesion='1' AND codigo='" & CBOSIMULACRO.Text & "'", CN)
                Dim DL As New DataSet
                DC.Fill(DL, "Formato_Examen_Cantidad")

                For p = 0 To cantidad_materias_1 - 1
                    For i = 0 To 8
                        ' DATOS DE LA TABLA Formato_Examen_Cantidad SESION 1
                        Materia_Cantidad_Componentes_Competencias_Sesion1(i, p) = DL.Tables(0).Rows(p).Item(i).ToString
                    Next
                Next

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5
                ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(cantidad_preguntas_simulacro_creado - 1, 4)
                'ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(cantidad_preguntas_sesion2 - 1, 4)


                For x = 0 To cantidad_preguntas_simulacro_creado - 1
                    For y = 0 To 4
                        ' datos de la tabla Formato_Examen  Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1 simulacro creado
                        Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(x, y) = DATA_FORMATO1.Tables(0).Rows(x).Item(y).ToString
                    Next
                Next

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  ASERTIVIDAD %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                ReDim Contador_respuestas_cada_materia((CInt(cantidad_preguntas_sesion11)) - 1, 9)
                contador_preguntas_de_una_materia = 0

                For y = 0 To cant_registros - 1    'cant_registros: 

                    codigoestudiante = DQ.Tables(0).Rows(y).Item(0).ToString
                    Dim DB1 As New OleDb.OleDbDataAdapter("SELECT  * FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_3_5_9 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'", CN)
                    Dim DV1 As New DataSet
                    DB1.Fill(DV1, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_3_5_9")
                    ' RESPUESTAS DE LA SESION 1
                    Dim columnas1 As Integer
                    columnas1 = DV1.Tables(0).Columns.Count
                    ReDim Respuestas_Sesion1(columnas1 - 1)
                    'ReDim Respuestas_Sesion2(columnas1 - 1)

                    For i = 0 To columnas1 - 1
                        NUMERO2.Text = DV1.Tables(0).Rows(0).Item(i).ToString
                        If NUMERO2.Text.ToString = "" Then
                            NUMERO2.Text = 0
                        End If
                        sesion1(i) = NUMERO2.Text.ToString
                        Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                        'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                    Next


                    For f = 0 To (cantidad_materias_1) - 1

                        For i = 0 To (cantidad_preguntas_sesion11) - 1 ' cantidad de preguntas

                            If f < cantidad_materias_1 Then

                                If i = cantidad_preguntas_sesion11 Then
                                    contador_preguntas_de_una_materia = 0
                                    Exit For
                                End If

                                If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f) Then
                                    'IR CAMBIANDO LAS Respuestas_Sesion1 PREGUNTANDO POR CADA ESTUDIANTES MAÑANA 

                                    contador_preguntas_de_una_materia = contador_preguntas_de_una_materia + 1

                                    If Respuestas_Sesion1(i + 3) = 1 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = i + 1
                                        Contador_respuestas_cada_materia(i, 2) = Contador_respuestas_cada_materia(i, 2) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 2 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = i + 1
                                        Contador_respuestas_cada_materia(i, 3) = Contador_respuestas_cada_materia(i, 3) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 3 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = i + 1
                                        Contador_respuestas_cada_materia(i, 4) = Contador_respuestas_cada_materia(i, 4) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 4 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = i + 1
                                        Contador_respuestas_cada_materia(i, 5) = Contador_respuestas_cada_materia(i, 5) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 5 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = i + 1
                                        Contador_respuestas_cada_materia(i, 6) = Contador_respuestas_cada_materia(i, 6) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)
                                    End If
                                Else
                                    If contador_preguntas_de_una_materia = Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0) Then
                                        contador_preguntas_de_una_materia = 0
                                        'f = f + 1
                                        i = i - 1
                                        Exit For
                                    End If
                                End If
                            End If

                        Next
                    Next
                Next

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    FIN  SIMULACRO EN LA SESION 1  Y 2 %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                Try
                    codigoestudiante = Respuestas_Sesion1(0)
                    Dim aux_cogido_colegio As String
                    Dim aux_codigo_grupo As String
                    aux_cogido_colegio = Mid(codigoestudiante, 2, 3)
                    aux_codigo_grupo = Mid(codigoestudiante, 5, 2)

                    For i = 0 To (CInt(cantidad_preguntas_sesion11)) - 1

                        If Contador_respuestas_cada_materia(i, 7) = "1" Then

                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 2) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 7) = "2" Then
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 3) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 7) = "3" Then
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 4) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 7) = "4" Then
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 5) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 7) = "5" Then
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 6) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        End If
                    Next
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA asertividad_materias", 16, "ERROR")
                    Me.Hide()
                End Try
                Control = 13
                Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
                Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
                Estudiantes_Colegio.materia = CBOMATERIA.Text
                Estudiantes_Colegio.codigo_prueba = 3
                Estudiantes_Colegio.Show()

            End If

        ElseIf CBOTIPO.Text = "saber 10 y 11" Then


            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% BORRAR DATOS TABLA %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim CMD1 As New OleDb.OleDbCommand("DELETE FROM asertividad_materias_calculada WHERE 1", CN)
            CN.Open()
            CMD1.ExecuteNonQuery()
            CN.Close()
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% OBTENER NÚMERO DE PREGUNTAS DE CADA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim codigosede As String
            codigosede = CBOCODIGOSEDE.Text

            Dim DA As New OleDb.OleDbDataAdapter("SELECT codigo_estudiante FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_colegio='" & codigosede & "' AND Identificacion_Prueba= '" & CBOSIMULACRO.Text & "' AND sesion='1'  ORDER BY codigo_estudiante ASC", CN)
            Dim DQ As New DataSet
            DA.Fill(DQ, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
            cant_registros = DQ.Tables(0).Rows.Count


            If cant_registros = 0 Then
                MsgBox("NO EXISTEN REGISTROS EN LA TABLA", 16, "ERROR")
                Me.Hide()
            Else
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% SACAR LA MATERIA RESPUESTA COMPONENTE ESTRUCTURA%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5
                Dim CMATERIA_FORMATO14 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND materia= '" & CBOMATERIA.Text & "' ORDER BY pregunta ASC", CN)
                Dim DATA_FORMATO14 As New DataSet
                CMATERIA_FORMATO14.Fill(DATA_FORMATO14, "Formato_Examen")

                Dim cantidadPreguntasMateria As Integer
                cantidadPreguntasMateria = DATA_FORMATO14.Tables(0).Rows.Count

                ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(cantidadPreguntasMateria - 1, 7)
                For x = 0 To cantidadPreguntasMateria - 1   ' cantidad de materias de cada materia
                    For y = 0 To 4
                        Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(x, y) = DATA_FORMATO14.Tables(0).Rows(x).Item(y).ToString
                    Next
                Next
                ReDim Contador_respuestas_cada_materia(cantidadPreguntasMateria - 1, 13)
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    TODAS LAS MATERIAS  "Formato_Examen_Cantidad" %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                ReDim Materia_Cantidad_Componentes_Competencias_Sesion1(8, 4)
                Dim DC As New OleDb.OleDbDataAdapter("SELECT  materia,cantidad_preguntas,cantidad_componente1,cantidad_componente2,cantidad_componente3,cantidad_componente4,cantidad_competencias1,cantidad_competencias2,cantidad_competencias3 FROM Formato_Examen_Cantidad WHERE codigo='" & CBOSIMULACRO.Text & "'", CN)
                Dim DL As New DataSet
                DC.Fill(DL, "Formato_Examen_Cantidad")

                For p = 0 To DL.Tables(0).Rows.Count - 1
                    For i = 0 To 8
                        Materia_Cantidad_Componentes_Competencias_Sesion1(i, p) = DL.Tables(0).Rows(p).Item(i).ToString
                    Next
                Next
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  ASERTIVIDAD %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                For y = 0 To cant_registros - 1    'cant_registros: numero de estudiantes de ese grupo con el filtro por colegio y simulacro
                    codigoestudiante = DQ.Tables(0).Rows(y).Item(0).ToString      'codigo de cada estudiante

                    If CBOMATERIA.Text = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 0) Then
                        'MATEMATICAS
                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS ( 26 )
                        Dim DB_matematicas As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20,preg21,preg22,preg23,preg24,preg25,preg26 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND sesion='1' ORDER BY sesion ASC", CN)
                        Dim MATEMATICAS As New DataSet
                        DB_matematicas.Fill(MATEMATICAS, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_matematicas As Integer
                        columnas_matematicas = MATEMATICAS.Tables(0).Columns.Count
                        'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ
                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS ( 24 )
                        Dim DB_matematicas2 As New OleDb.OleDbDataAdapter("SELECT preg21,preg22,preg23,preg24,preg25,preg26,preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND sesion='2' ORDER BY sesion ASC", CN)
                        Dim MATEMATICAS2 As New DataSet
                        DB_matematicas2.Fill(MATEMATICAS2, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_matematicas2 As Integer
                        columnas_matematicas2 = MATEMATICAS2.Tables(0).Columns.Count

                        ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)
                        '%%%%%%%%%%%%%%% GUARDAR LAS RESPUESTA DE MATEMATICAS DEL ESTUDIANTE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        For j = 0 To 0
                            For i = 0 To columnas_matematicas - 1
                                NUMERO2.Text = MATEMATICAS.Tables(0).Rows(0).Item(i).ToString
                                Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                            Next
                        Next
                        For j = 0 To 0
                            For i = 0 To columnas_matematicas2 - 1
                                NUMERO2.Text = MATEMATICAS2.Tables(0).Rows(0).Item(i).ToString
                                Respuestas_Materia_1_Sesion1_Matematicas(i + columnas_matematicas) = NUMERO2.Text.ToString
                            Next
                        Next

                    ElseIf CBOMATERIA.Text = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 1) Then
                        'lectura critica

                        ' LECTURA
                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE LECTURA
                        Dim DB_lectura As New OleDb.OleDbDataAdapter("SELECT preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44,preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND sesion='1' ORDER BY sesion ASC", CN)
                        Dim LECTURA As New DataSet
                        DB_lectura.Fill(LECTURA, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_lectura As Integer
                        columnas_lectura = LECTURA.Tables(0).Columns.Count

                        ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)
                        For j = 0 To 0
                            For i = 0 To columnas_lectura - 1
                                NUMERO2.Text = LECTURA.Tables(0).Rows(0).Item(i).ToString
                                Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                            Next
                        Next

                    ElseIf CBOMATERIA.Text = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 2) Then
                        'ciencias sociales

                        'SOCIALES
                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE SOCIALES
                        Dim DB_sociales As New OleDb.OleDbDataAdapter("SELECT preg65,preg66,preg67,preg68,preg69,preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND sesion='1' ORDER BY sesion ASC", CN)
                        Dim SOCIALES As New DataSet
                        DB_sociales.Fill(SOCIALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_sociales As Integer
                        columnas_sociales = SOCIALES.Tables(0).Columns.Count
                        'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ

                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE SOCIALES
                        Dim DB_sociales2 As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND sesion='2' ORDER BY sesion ASC", CN)
                        Dim SOCIALES2 As New DataSet
                        DB_sociales2.Fill(SOCIALES2, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_sociales2 As Integer
                        columnas_sociales2 = SOCIALES2.Tables(0).Columns.Count

                        ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)

                        For j = 0 To 0
                            For i = 0 To columnas_sociales - 1
                                NUMERO2.Text = SOCIALES.Tables(0).Rows(0).Item(i).ToString
                                Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                            Next
                        Next

                        For j = 0 To 0
                            For i = 0 To columnas_sociales2 - 1
                                NUMERO2.Text = SOCIALES2.Tables(0).Rows(0).Item(i).ToString
                                Respuestas_Materia_1_Sesion1_Matematicas(i + columnas_sociales) = NUMERO2.Text.ToString
                            Next
                        Next

                    ElseIf CBOMATERIA.Text = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 3) Then
                        'ciencias naturales

                        'NATURALES
                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE NATURALES (31)
                        Dim DB_naturales As New OleDb.OleDbDataAdapter("SELECT preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108,preg109,preg110,preg111,preg112,preg113,preg114,preg115,preg116,preg117,preg118,preg119,preg120,preg121 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND sesion='1' ORDER BY sesion ASC", CN)
                        Dim NATURALES As New DataSet
                        DB_naturales.Fill(NATURALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_naturales As Integer
                        columnas_naturales = NATURALES.Tables(0).Columns.Count
                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS (25)
                        Dim DB_naturales2 As New OleDb.OleDbDataAdapter("SELECT preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64,preg65,preg66,preg67,preg68,preg69 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND sesion='2' ORDER BY sesion ASC", CN)
                        Dim NATURALES2 As New DataSet
                        DB_naturales2.Fill(NATURALES2, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_naturales2 As Integer
                        columnas_naturales2 = NATURALES2.Tables(0).Columns.Count

                        ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)
                        For j = 0 To 0
                            For i = 0 To columnas_naturales - 1
                                NUMERO2.Text = NATURALES.Tables(0).Rows(0).Item(i).ToString
                                Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                            Next
                        Next

                        For j = 0 To 0
                            For i = 0 To columnas_naturales2 - 1
                                NUMERO2.Text = NATURALES2.Tables(0).Rows(0).Item(i).ToString
                                Respuestas_Materia_1_Sesion1_Matematicas(i + columnas_naturales) = NUMERO2.Text.ToString
                            Next
                        Next

                    ElseIf CBOMATERIA.Text = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 4) Then
                        'ingles

                        ' INGLES
                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE INGLES
                        Dim DB_ingles As New OleDb.OleDbDataAdapter("SELECT preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90,preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108,preg109,preg110,preg111,preg112,preg113,preg114 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND sesion='2' ORDER BY sesion ASC", CN)
                        Dim INGLES As New DataSet
                        DB_ingles.Fill(INGLES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_ingles As Integer
                        columnas_ingles = INGLES.Tables(0).Columns.Count

                        ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)
                        For j = 0 To 0
                            For i = 0 To columnas_ingles - 1
                                NUMERO2.Text = INGLES.Tables(0).Rows(0).Item(i).ToString
                                Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                            Next
                        Next

                    End If


                    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%   MAGIA  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                    For i = 0 To cantidadPreguntasMateria - 1
                        If Respuestas_Materia_1_Sesion1_Matematicas(i) = 1 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text 'MATERIA
                            Contador_respuestas_cada_materia(i, 1) = i + 1                                                   'NUMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 2) = Contador_respuestas_cada_materia(i, 2) + 1              'CANTIDAD PREGUNTA  A

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 2 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = i + 1
                            Contador_respuestas_cada_materia(i, 3) = Contador_respuestas_cada_materia(i, 3) + 1             'CANTIDAD PREGUNTA  B

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 3 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = i + 1
                            Contador_respuestas_cada_materia(i, 4) = Contador_respuestas_cada_materia(i, 4) + 1              'CANTIDAD PREGUNTA  C

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 4 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = i + 1
                            Contador_respuestas_cada_materia(i, 5) = Contador_respuestas_cada_materia(i, 5) + 1             'CANTIDAD PREGUNTA  D

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 5 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = i + 1
                            Contador_respuestas_cada_materia(i, 6) = Contador_respuestas_cada_materia(i, 6) + 1             'CANTIDAD PREGUNTA  e

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 6 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = i + 1
                            Contador_respuestas_cada_materia(i, 7) = Contador_respuestas_cada_materia(i, 7) + 1             'CANTIDAD PREGUNTA  f

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 7 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = i + 1
                            Contador_respuestas_cada_materia(i, 8) = Contador_respuestas_cada_materia(i, 8) + 1             'CANTIDAD PREGUNTA  g

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA


                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 8 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = i + 1
                            Contador_respuestas_cada_materia(i, 9) = Contador_respuestas_cada_materia(i, 9) + 1             'CANTIDAD PREGUNTA  h

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        End If
                    Next
                Next

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    FIN  SIMULACRO EN LA SESION 1  Y 2 %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                Try

                    Dim aux_cogido_colegio As String
                    Dim aux_codigo_grupo As String
                    aux_cogido_colegio = Mid(codigoestudiante, 2, 3)
                    aux_codigo_grupo = Mid(codigoestudiante, 5, 2)

                    For i = 0 To cantidadPreguntasMateria - 1
                        If Contador_respuestas_cada_materia(i, 10) = "1" Then   'SI ES A
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & CInt(Contador_respuestas_cada_materia(i, 7)) & "','" & CInt(Contador_respuestas_cada_materia(i, 8)) & "','" & CInt(Contador_respuestas_cada_materia(i, 9)) & "','" & CInt(Contador_respuestas_cada_materia(i, 10)) & "','" & Contador_respuestas_cada_materia(i, 11) & "','" & Contador_respuestas_cada_materia(i, 12) & "','" & (Contador_respuestas_cada_materia(i, 2) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 10) = "2" Then  'SI ES B
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & CInt(Contador_respuestas_cada_materia(i, 7)) & "','" & CInt(Contador_respuestas_cada_materia(i, 8)) & "','" & CInt(Contador_respuestas_cada_materia(i, 9)) & "','" & CInt(Contador_respuestas_cada_materia(i, 10)) & "','" & Contador_respuestas_cada_materia(i, 11) & "','" & Contador_respuestas_cada_materia(i, 12) & "','" & (Contador_respuestas_cada_materia(i, 3) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 10) = "3" Then 'SI ES C
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & CInt(Contador_respuestas_cada_materia(i, 7)) & "','" & CInt(Contador_respuestas_cada_materia(i, 8)) & "','" & CInt(Contador_respuestas_cada_materia(i, 9)) & "','" & CInt(Contador_respuestas_cada_materia(i, 10)) & "','" & Contador_respuestas_cada_materia(i, 11) & "','" & Contador_respuestas_cada_materia(i, 12) & "','" & (Contador_respuestas_cada_materia(i, 4) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 10) = "4" Then  'SI ES D
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & CInt(Contador_respuestas_cada_materia(i, 7)) & "','" & CInt(Contador_respuestas_cada_materia(i, 8)) & "','" & CInt(Contador_respuestas_cada_materia(i, 9)) & "','" & CInt(Contador_respuestas_cada_materia(i, 10)) & "','" & Contador_respuestas_cada_materia(i, 11) & "','" & Contador_respuestas_cada_materia(i, 12) & "','" & (Contador_respuestas_cada_materia(i, 5) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 10) = "5" Then  'SI ES E
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & CInt(Contador_respuestas_cada_materia(i, 7)) & "','" & CInt(Contador_respuestas_cada_materia(i, 8)) & "','" & CInt(Contador_respuestas_cada_materia(i, 9)) & "','" & CInt(Contador_respuestas_cada_materia(i, 10)) & "','" & Contador_respuestas_cada_materia(i, 11) & "','" & Contador_respuestas_cada_materia(i, 12) & "','" & (Contador_respuestas_cada_materia(i, 6) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()

                        ElseIf Contador_respuestas_cada_materia(i, 10) = "6" Then  'SI ES F
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & CInt(Contador_respuestas_cada_materia(i, 7)) & "','" & CInt(Contador_respuestas_cada_materia(i, 8)) & "','" & CInt(Contador_respuestas_cada_materia(i, 9)) & "','" & CInt(Contador_respuestas_cada_materia(i, 10)) & "','" & Contador_respuestas_cada_materia(i, 11) & "','" & Contador_respuestas_cada_materia(i, 12) & "','" & (Contador_respuestas_cada_materia(i, 7) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()

                        ElseIf Contador_respuestas_cada_materia(i, 10) = "7" Then  'SI ES G
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & CInt(Contador_respuestas_cada_materia(i, 7)) & "','" & CInt(Contador_respuestas_cada_materia(i, 8)) & "','" & CInt(Contador_respuestas_cada_materia(i, 9)) & "','" & CInt(Contador_respuestas_cada_materia(i, 10)) & "','" & Contador_respuestas_cada_materia(i, 11) & "','" & Contador_respuestas_cada_materia(i, 12) & "','" & (Contador_respuestas_cada_materia(i, 8) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()

                        ElseIf Contador_respuestas_cada_materia(i, 10) = "8" Then  'SI ES H
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & CInt(Contador_respuestas_cada_materia(i, 7)) & "','" & CInt(Contador_respuestas_cada_materia(i, 8)) & "','" & CInt(Contador_respuestas_cada_materia(i, 9)) & "','" & CInt(Contador_respuestas_cada_materia(i, 10)) & "','" & CInt(Contador_respuestas_cada_materia(i, 11)) & "','" & CInt(Contador_respuestas_cada_materia(i, 12)) & "','" & (Contador_respuestas_cada_materia(i, 9) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()


                        End If
                    Next

                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA asertividad_materias", 16, "ERROR")
                    Me.Hide()
                End Try

                Control = 13
                Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
                Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
                Estudiantes_Colegio.materia = CBOMATERIA.Text
                Estudiantes_Colegio.codigo_prueba = 4
                Estudiantes_Colegio.Show()
            End If
        End If

    End Sub

    Private Sub CBOTIPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOTIPO.SelectedIndexChanged

        If CBOTIPO.Text = "saber 3,5 y 9" Then
            Dim DB As New OleDb.OleDbDataAdapter("SELECT  DISTINCT codigo  FROM Formato_Examen_Cantidad WHERE grado='3°' OR grado='5°' OR grado='9°'", CN)
            Dim DD As New DataSet
            DB.Fill(DD, "Formato_Examen_Cantidad")
            CBOSIMULACRO.DataSource = DD.Tables("Formato_Examen_Cantidad")
            CBOSIMULACRO.DisplayMember = "codigo"

            Dim Dp As New OleDb.OleDbDataAdapter("SELECT  DISTINCT materia  FROM Materias WHERE prueba='2'", CN)
            Dim DBA As New DataSet
            Dp.Fill(DBA, "Materias")
            CBOMATERIA.DataSource = DBA.Tables("Materias")
            CBOMATERIA.DisplayMember = "materia"

        ElseIf CBOTIPO.Text = "saber 10 y 11" Then
            Dim DB As New OleDb.OleDbDataAdapter("SELECT  DISTINCT codigo  FROM Formato_Examen_Cantidad  WHERE grado='10°' OR grado='11°'", CN)
            Dim DD As New DataSet
            DB.Fill(DD, "Formato_Examen_Cantidad")
            CBOSIMULACRO.DataSource = DD.Tables("Formato_Examen_Cantidad")
            CBOSIMULACRO.DisplayMember = "codigo"

            Dim Dp As New OleDb.OleDbDataAdapter("SELECT  DISTINCT materia  FROM Materias WHERE prueba='1'", CN)
            Dim DBA As New DataSet
            Dp.Fill(DBA, "Materias")
            CBOMATERIA.DataSource = DBA.Tables("Materias")
            CBOMATERIA.DisplayMember = "materia"

        End If

    End Sub

End Class