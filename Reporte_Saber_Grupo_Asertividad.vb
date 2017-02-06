Imports System.Data.OleDb
Public Class Reporte_Saber_Grupo_Asertividad
    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Sistemas3\d\sistemaevaluarte.accdb")
    Public contador_preguntas_de_una_materia As Integer
    Public contador_a As Integer
    Public contador_b As Integer
    Public contador_c As Integer
    Public contador_d As Integer
    Public contador_e As Integer
    Public contador_f As Integer
    Public contador_g As Integer
    Public contador_h As Integer

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
    Public TIPO As Double
    Dim grado_simulacro As String

    Public contador_materia_encontrada As Integer
    ' RESPUESTAS DE LAS DOS SESIONES
    Dim Respuestas_Materia_1_Sesion1_Matematicas() As String
    Dim Respuestas_Materia_2_Sesion1_Naturales() As String
    Dim Respuestas_Materia_1_Sesion2_Ingles() As String
    Dim Respuestas_Materia_2_Sesion2_Lectura() As String
    Dim Respuestas_Materia_3_Sesion2_Sociales() As String


    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia1_Ingles(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1y2(,)
    Dim Materia_Preguntas_Respuesta_Flexible(,)
    ' para guardar los components de cada materia por sesion
    Dim Cantidad_Componentes_Materias_Sesion1(,)
    Dim Cantidad_Componentes_Materias_Sesion2(,)


    Dim Cantidad_Componentes_Materias_Sesion1_Matematicas(,)
    Dim Cantidad_Componentes_Materias_Sesion1_Naturales(,)
    Dim Cantidad_Componentes_Materias_Sesion2_Ingles(,)
    Dim Cantidad_Componentes_Materias_Sesion2_Lectura(,)
    Dim Cantidad_Componentes_Materias_Sesion2_Sociales(,)
    'Para guardar la acertividad de las materias en una instucion
    'Dim Materias_Asertividad(,)
    ' guardar la preguntas acertadas y el primedio de cada materia del componente flexible
    Dim Cantidad_Materias_Flexible(,)
    Dim contador_correctas_cada_materia As Object
    'Contador_respuestas_cada_materia

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

    Private Sub Reporte_Saber_Grupo_Asertividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Sub CARGAR()
        Dim DG As New OleDb.OleDbDataAdapter("SELECT  nombre_prueba  FROM Pruebas", CN)
        Dim DL As New DataSet
        DG.Fill(DL, "Pruebas")
        CBOTIPO.DataSource = DL.Tables("Pruebas")
        CBOTIPO.DisplayMember = "nombre_prueba"

        Dim DH As New OleDb.OleDbDataAdapter("SELECT  ciudad  FROM colegios GROUP BY ciudad", CN)
        Dim DM As New DataSet
        DH.Fill(DM, "colegios")
        CBOCIUDADES.DataSource = DM.Tables("colegios")
        CBOCIUDADES.DisplayMember = "ciudad"
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
            Dim CMATERIA_FORMATO1 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia, orden FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND sesion='1' AND tipo_Materia=' '  ORDER BY pregunta ASC", CN)
            Dim DATA_FORMATO1 As New DataSet
            CMATERIA_FORMATO1.Fill(DATA_FORMATO1, "Formato_Examen")
            'Dim cantidad_preguntas_sesion1 As String
            Dim cantidad_preguntas_simulacro_creado As String
            cantidad_preguntas_simulacro_creado = DATA_FORMATO1.Tables(0).Rows.Count
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% OBTENER NÚMERO DE PREGUNTAS DE CADA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim DA As New OleDb.OleDbDataAdapter("SELECT codigo_estudiante FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_3_5_9 WHERE codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "'  ORDER BY codigo_estudiante ASC", CN)
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
                    For y = 0 To 5
                        ' datos de la tabla Formato_Examen  Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1 simulacro creado
                        Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(x, y) = DATA_FORMATO1.Tables(0).Rows(x).Item(y).ToString
                    Next
                Next

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  ASERTIVIDAD %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                ReDim Contador_respuestas_cada_materia((CInt(cantidad_preguntas_sesion11)) - 1, 9)
                contador_preguntas_de_una_materia = 0

                For y = 0 To cant_registros - 1    'cant_registros: 

                    codigoestudiante = DQ.Tables(0).Rows(y).Item(0).ToString
                    Dim DB1 As New OleDb.OleDbDataAdapter("SELECT  * FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_3_5_9 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "'", CN)

                    Dim DV1 As New DataSet
                    DB1.Fill(DV1, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_3_5_9")
                    ' RESPUESTAS DE LA SESION 1
                    Dim columnas1 As Integer
                    columnas1 = DV1.Tables(0).Columns.Count
                    ReDim Respuestas_Sesion1(columnas1 - 1)

                    For i = 0 To columnas1 - 1
                        NUMERO2.Text = DV1.Tables(0).Rows(0).Item(i).ToString
                        If NUMERO2.Text.ToString = "" Then
                            NUMERO2.Text = 0
                        End If
                        sesion1(i) = NUMERO2.Text.ToString
                        Respuestas_Sesion1(i) = NUMERO2.Text.ToString
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
                                        Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 5)
                                        Contador_respuestas_cada_materia(i, 2) = Contador_respuestas_cada_materia(i, 2) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 2 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 5)
                                        Contador_respuestas_cada_materia(i, 3) = Contador_respuestas_cada_materia(i, 3) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 3 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 5)
                                        Contador_respuestas_cada_materia(i, 4) = Contador_respuestas_cada_materia(i, 4) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 4 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 5)
                                        Contador_respuestas_cada_materia(i, 5) = Contador_respuestas_cada_materia(i, 5) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 5 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 5)
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

                Control = 14
                Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
                Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
                Estudiantes_Colegio.materia = CBOMATERIA.Text
                Estudiantes_Colegio.grupo = CBOCODIGOGRUPO.Text
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
            Dim DA As New OleDb.OleDbDataAdapter("SELECT codigo_estudiante FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "'AND Identificacion_Prueba= '" & CBOSIMULACRO.Text & "'  ORDER BY codigo_estudiante ASC", CN)
            Dim DQ As New DataSet
            DA.Fill(DQ, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
            cant_registros = DQ.Tables(0).Rows.Count

            If cant_registros = 0 Then
                MsgBox("NO EXISTEN REGISTROS EN LA TABLA", 16, "ERROR")
                Me.Hide()
            Else
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% SACAR LA MATERIA RESPUESTA COMPONENTE ESTRUCTURA%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5
                Dim CMATERIA_FORMATO14 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia, orde FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND materia= '" & CBOMATERIA.Text & "' ORDER BY pregunta ASC", CN)
                Dim DATA_FORMATO14 As New DataSet
                CMATERIA_FORMATO14.Fill(DATA_FORMATO14, "Formato_Examen")

                Dim cantidadPreguntasMateria As Integer
                cantidadPreguntasMateria = DATA_FORMATO14.Tables(0).Rows.Count

                ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(cantidadPreguntasMateria - 1, 7)
                For x = 0 To cantidadPreguntasMateria - 1   ' cantidad de materias de cada materia
                    For y = 0 To 5
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
                        Dim DB_matematicas As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20,preg21,preg22,preg23,preg24,preg25,preg26 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "' AND sesion='1' ORDER BY sesion ASC", CN)
                        Dim MATEMATICAS As New DataSet
                        DB_matematicas.Fill(MATEMATICAS, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_matematicas As Integer
                        columnas_matematicas = MATEMATICAS.Tables(0).Columns.Count
                        'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ
                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS ( 24 )
                        Dim DB_matematicas2 As New OleDb.OleDbDataAdapter("SELECT preg21,preg22,preg23,preg24,preg25,preg26,preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "' AND sesion='2' ORDER BY sesion ASC", CN)
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
                        Dim DB_lectura As New OleDb.OleDbDataAdapter("SELECT preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44,preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "' AND sesion='1' ORDER BY sesion ASC", CN)
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
                        Dim DB_sociales As New OleDb.OleDbDataAdapter("SELECT preg65,preg66,preg67,preg68,preg69,preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "' AND sesion='1' ORDER BY sesion ASC", CN)
                        Dim SOCIALES As New DataSet
                        DB_sociales.Fill(SOCIALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_sociales As Integer
                        columnas_sociales = SOCIALES.Tables(0).Columns.Count
                        'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ

                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE SOCIALES
                        Dim DB_sociales2 As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "' AND sesion='2' ORDER BY sesion ASC", CN)
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
                        Dim DB_naturales As New OleDb.OleDbDataAdapter("SELECT preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108,preg109,preg110,preg111,preg112,preg113,preg114,preg115,preg116,preg117,preg118,preg119,preg120,preg121 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "' AND sesion='1' ORDER BY sesion ASC", CN)
                        Dim NATURALES As New DataSet
                        DB_naturales.Fill(NATURALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                        Dim columnas_naturales As Integer
                        columnas_naturales = NATURALES.Tables(0).Columns.Count
                        ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS (25)
                        Dim DB_naturales2 As New OleDb.OleDbDataAdapter("SELECT preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64,preg65,preg66,preg67,preg68,preg69 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "' AND sesion='2' ORDER BY sesion ASC", CN)
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
                        Dim DB_ingles As New OleDb.OleDbDataAdapter("SELECT preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90,preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108,preg109,preg110,preg111,preg112,preg113,preg114 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "' AND sesion='2' ORDER BY sesion ASC", CN)
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
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)    'NUMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 2) = Contador_respuestas_cada_materia(i, 2) + 1              'CANTIDAD PREGUNTA  A

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 2 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)
                            Contador_respuestas_cada_materia(i, 3) = Contador_respuestas_cada_materia(i, 3) + 1             'CANTIDAD PREGUNTA  B

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 3 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)
                            Contador_respuestas_cada_materia(i, 4) = Contador_respuestas_cada_materia(i, 4) + 1              'CANTIDAD PREGUNTA  C

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 4 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)
                            Contador_respuestas_cada_materia(i, 5) = Contador_respuestas_cada_materia(i, 5) + 1             'CANTIDAD PREGUNTA  D

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 5 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)
                            Contador_respuestas_cada_materia(i, 6) = Contador_respuestas_cada_materia(i, 6) + 1             'CANTIDAD PREGUNTA  e

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 6 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)
                            Contador_respuestas_cada_materia(i, 7) = Contador_respuestas_cada_materia(i, 7) + 1             'CANTIDAD PREGUNTA  f

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA

                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 7 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)
                            Contador_respuestas_cada_materia(i, 8) = Contador_respuestas_cada_materia(i, 8) + 1             'CANTIDAD PREGUNTA  g

                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA


                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 8 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)
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

                Control = 14
                Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
                Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
                Estudiantes_Colegio.materia = CBOMATERIA.Text
                Estudiantes_Colegio.grupo = CBOCODIGOGRUPO.Text
                Estudiantes_Colegio.codigo_prueba = 4
                Estudiantes_Colegio.Show()
            End If

        ElseIf CBOTIPO.Text = "Tu saber" Then

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% BORRAR DATOS TABLA %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim CMD1 As New OleDb.OleDbCommand("DELETE FROM asertividad_materias_calculada WHERE 1", CN)
            CN.Open()
            CMD1.ExecuteNonQuery()
            CN.Close()
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% OBTENER NÚMERO DE PREGUNTAS DE CADA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim DA As New OleDb.OleDbDataAdapter("SELECT codigo_estudiante FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "'AND Identificacion_Prueba= '" & CBOSIMULACRO.Text & "'  ORDER BY codigo_estudiante ASC", CN)
            Dim DQ As New DataSet
            DA.Fill(DQ, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
            cant_registros = DQ.Tables(0).Rows.Count

            If cant_registros = 0 Then
                MsgBox("NO EXISTEN REGISTROS EN LA TABLA", 16, "ERROR")
                Me.Hide()
            Else
                ' CONSULTAR EL TIPO DE GRADO DEL SIMULACRO 
                Dim CMD As New OleDb.OleDbCommand("SELECT DISTINCT grado FROM Formato_Examen_Cantidad WHERE sesion='1' AND codigo='" & CBOSIMULACRO.Text & "'", CN)
                Dim DR As OleDb.OleDbDataReader
                CN.Open()
                DR = CMD.ExecuteReader
                If DR.Read Then
                    grado_simulacro = DR(0)
                Else
                    MsgBox("ERROR. NO SE ENCONTRO EL REGISTRO, EL GRADO NO EXISTE")
                End If
                CN.Close()
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% SACAR LA MATERIA RESPUESTA Formato_Examen %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5
                Dim CMATERIA_FORMATO14 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia,orden FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND materia= '" & CBOMATERIA.Text & "' ORDER BY pregunta ASC", CN)
                Dim DATA_FORMATO14 As New DataSet
                CMATERIA_FORMATO14.Fill(DATA_FORMATO14, "Formato_Examen")

                Dim cantidadPreguntasMateria As Integer
                cantidadPreguntasMateria = DATA_FORMATO14.Tables(0).Rows.Count

                ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(cantidadPreguntasMateria - 1, 7)
                For x = 0 To cantidadPreguntasMateria - 1   ' cantidad de materias de cada materia
                    For y = 0 To 5
                        Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(x, y) = DATA_FORMATO14.Tables(0).Rows(x).Item(y).ToString
                    Next
                Next
                ReDim Contador_respuestas_cada_materia(cantidadPreguntasMateria - 1, 13)
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    TODAS LAS MATERIAS  "Formato_Examen_Cantidad" %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                ReDim Materia_Cantidad_Componentes_Competencias_Sesion1(13, 4)
                Dim DC As New OleDb.OleDbDataAdapter("SELECT  materia,cantidad_preguntas,cantidad_componente1,cantidad_componente2,cantidad_componente3,cantidad_componente4,cantidad_competencias1,cantidad_competencias2,cantidad_competencias3,cantidad_competencias4,cantidad_competencias5,cantidad_competencias6, cantidad_competencias7, cantidad_competencias8  FROM Formato_Examen_Cantidad WHERE codigo='" & CBOSIMULACRO.Text & "'", CN)
                Dim DL As New DataSet
                DC.Fill(DL, "Formato_Examen_Cantidad")

                For p = 0 To DL.Tables(0).Rows.Count - 1
                    For i = 0 To 13
                        Materia_Cantidad_Componentes_Competencias_Sesion1(i, p) = DL.Tables(0).Rows(p).Item(i).ToString
                    Next
                Next
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  ASERTIVIDAD %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                For y = 0 To cant_registros - 1    'cant_registros: numero de estudiantes de ese grupo con el filtro por colegio y simulacro
                    codigoestudiante = DQ.Tables(0).Rows(y).Item(0).ToString      'codigo de cada estudiante
                    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  LAS RESPUESTAS DISEÑADAS EN EL FORMATO LISTAS PARA VERIFICARLAS %%%%%%%%%%%%%%%%%%%%%%%%%%

                    If grado_simulacro = "PREJARDÍN" Then
                        Dim DV As New DataSet
                        If CBOSIMULACRO.Text = "600" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber_Prejardin_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber_Prejardin_Simulacro3")
                        ElseIf CBOSIMULACRO.Text = "900" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber_Prejardin_Simulacro8 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber_Prejardin_Simulacro8")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber_Prejardin WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber_Prejardin")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count

                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "JARDÍN" Then

                        Dim DV As New DataSet
                        If CBOSIMULACRO.Text = "301" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber_Jardin_Simulacro2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber_Jardin_Simulacro2")
                        ElseIf CBOSIMULACRO.Text = "601" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber_Jardin_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber_Jardin_Simulacro3")
                        ElseIf CBOSIMULACRO.Text = "901" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber_Jardin_Simulacro8 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber_Jardin_Simulacro8")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber_Jardin WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber_Jardin")
                        End If
                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count
                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "TRANSICIÓN" Then
                        Dim DV As New DataSet
                        If CBOSIMULACRO.Text = "902" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber_Transicion_Simulacro8 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber_Transicion_Simulacro8")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber_Transicion WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber_Transicion")
                        End If
                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count

                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "1°" Then
                        Dim DV As New DataSet
                        If CBOSIMULACRO.Text = "303" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber1_Simulacro2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber1_Simulacro2")
                        ElseIf CBOSIMULACRO.Text = "403" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber1_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber1_Simulacro3")
                        ElseIf CBOSIMULACRO.Text = "503" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber1_Simulacro4 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber1_Simulacro4")
                        ElseIf CBOSIMULACRO.Text = "603" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber1_Simulacro5 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber1_Simulacro5")
                        ElseIf CBOSIMULACRO.Text = "703" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber1_Simulacro6 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber1_Simulacro6")
                        ElseIf CBOSIMULACRO.Text = "803" Or CBOSIMULACRO.Text = "903" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber1_Simulacro7 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber1_Simulacro7")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber1 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber1")
                        End If

                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count

                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If

                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                            Next
                        Next

                    ElseIf grado_simulacro = "2°" Then

                        Dim DV As New DataSet

                        If CBOSIMULACRO.Text = "304" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber2_Simulacro2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber2_Simulacro2")
                        ElseIf CBOSIMULACRO.Text = "404" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber2_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber2_Simulacro3")
                        ElseIf CBOSIMULACRO.Text = "504" Or CBOSIMULACRO.Text = "604" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber2_Simulacro4 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber2_Simulacro4")
                        ElseIf CBOSIMULACRO.Text = "704" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber2_Simulacro6 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber2_Simulacro6")
                        ElseIf CBOSIMULACRO.Text = "804" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber2_Simulacro7 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber2_Simulacro7")
                        ElseIf CBOSIMULACRO.Text = "904" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber2_Simulacro8 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber2_Simulacro8")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber2")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count

                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "3°" Then

                        Dim DV As New DataSet
                        If CBOSIMULACRO.Text = "305" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber3_Simulacro2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber3_Simulacro2")
                        ElseIf CBOSIMULACRO.Text = "405" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber3_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber3_Simulacro3")
                        ElseIf CBOSIMULACRO.Text = "505" Or CBOSIMULACRO.Text = "605" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber3_Simulacro4 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber3_Simulacro4")
                        ElseIf CBOSIMULACRO.Text = "705" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber3_Simulacro6 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber3_Simulacro6")
                        ElseIf CBOSIMULACRO.Text = "805" Or CBOSIMULACRO.Text = "905" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber3_Simulacro7 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber3_Simulacro7")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber3")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count

                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "4°" Then
                        Dim DV As New DataSet

                        If CBOSIMULACRO.Text = "306" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber4_Simulacro2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber4_Simulacro2")
                        ElseIf CBOSIMULACRO.Text = "406" Or CBOSIMULACRO.Text = "506" Or CBOSIMULACRO.Text = "606" Or CBOSIMULACRO.Text = "706" Or CBOSIMULACRO.Text = "806" Or CBOSIMULACRO.Text = "906" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber4_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber4_Simulacro3")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber4 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber4")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count

                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "5°" Then

                        Dim DV As New DataSet

                        If CBOSIMULACRO.Text = "307" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber5_Simulacro2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber5_Simulacro2")
                        ElseIf CBOSIMULACRO.Text = "407" Or CBOSIMULACRO.Text = "507" Or CBOSIMULACRO.Text = "607" Or CBOSIMULACRO.Text = "707" Or CBOSIMULACRO.Text = "807" Or CBOSIMULACRO.Text = "907" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber5_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber5_Simulacro3")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber5 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber5")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count

                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "6°" Then

                        Dim DV As New DataSet
                        If CBOSIMULACRO.Text = "408" Or CBOSIMULACRO.Text = "508" Or CBOSIMULACRO.Text = "608" Or CBOSIMULACRO.Text = "708" Or CBOSIMULACRO.Text = "808" Or CBOSIMULACRO.Text = "908" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber6_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber6_Simulacro3")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber6 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber6")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count

                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "7°" Then

                        Dim DV As New DataSet
                        If CBOSIMULACRO.Text = "409" Or CBOSIMULACRO.Text = "509" Or CBOSIMULACRO.Text = "609" Or CBOSIMULACRO.Text = "709" Or CBOSIMULACRO.Text = "809" Or CBOSIMULACRO.Text = "909" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber7_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber7_Simulacro3")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber7 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber7")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count

                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "8°" Then

                        Dim DV As New DataSet

                        If CBOSIMULACRO.Text = "410" Or CBOSIMULACRO.Text = "510" Or CBOSIMULACRO.Text = "610" Or CBOSIMULACRO.Text = "710" Or CBOSIMULACRO.Text = "810" Or CBOSIMULACRO.Text = "910" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber8_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber8_Simulacro3")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber8 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber8")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count

                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "9°" Then

                        Dim DV As New DataSet
                        If CBOSIMULACRO.Text = "411" Or CBOSIMULACRO.Text = "511" Or CBOSIMULACRO.Text = "611" Or CBOSIMULACRO.Text = "711" Or CBOSIMULACRO.Text = "811" Or CBOSIMULACRO.Text = "911" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber9_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber9_Simulacro3")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber9 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber9")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count
                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "10°" Then

                        Dim DV As New DataSet
                        If CBOSIMULACRO.Text = "312" Or CBOSIMULACRO.Text = "512" Or CBOSIMULACRO.Text = "612" Or CBOSIMULACRO.Text = "712" Or CBOSIMULACRO.Text = "812" Or CBOSIMULACRO.Text = "912" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber10_Simulacro2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber10_Simulacro2")
                        ElseIf CBOSIMULACRO.Text = "412" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber10_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber10_Simulacro3")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber10 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber10")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count
                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString

                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next

                    ElseIf grado_simulacro = "11°" Then

                        Dim DV As New DataSet
                        If CBOSIMULACRO.Text = "313" Or CBOSIMULACRO.Text = "513" Or CBOSIMULACRO.Text = "613" Or CBOSIMULACRO.Text = "713" Or CBOSIMULACRO.Text = "813" Or CBOSIMULACRO.Text = "913" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber11_Simulacro2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber11_Simulacro2")
                        ElseIf CBOSIMULACRO.Text = "413" Then
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber11_Simulacro3 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber11_Simulacro3")
                        Else
                            Dim DB As New OleDb.OleDbDataAdapter("SELECT  * FROM Asertividad_Preguntas_Tusaber11 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY codigo_estudiante ASC", CN)
                            DB.Fill(DV, "Asertividad_Preguntas_Tusaber11")
                        End If

                        'COLUMNAS DE LA TABLA Preguntas_Saber_Sesion2
                        Dim columnas As Integer
                        columnas = DV.Tables(0).Columns.Count
                        'Para guardar las respuestas
                        ReDim Respuestas_Sesion1(columnas - 1)

                        For j = 0 To 0
                            For i = 0 To columnas - 1
                                NUMERO2.Text = DV.Tables(0).Rows(j).Item(i).ToString
                                If NUMERO2.Text = "" Then
                                    NUMERO2.Text = "0"
                                End If
                                sesion1(i) = NUMERO2.Text.ToString
                                Respuestas_Sesion1(i) = NUMERO2.Text.ToString
                                'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
                            Next
                        Next
                    End If

                    ' %%%%%%%%%%%%%%%%%%%%%%%%% VALIDA LAS MATERIAS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                    ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)
                    If CBOMATERIA.Text = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 0) Then
                        'MATEMATICAS
                        '%%%%%%%%%%%%%%% GUARDAR LAS RESPUESTA DE MATEMATICAS DEL ESTUDIANTE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        For i = 0 To cantidadPreguntasMateria - 1
                            Respuestas_Materia_1_Sesion1_Matematicas(i) = Respuestas_Sesion1(i + 4)
                        Next
                    ElseIf CBOMATERIA.Text = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 1) Then
                        'LENGUAJE
                        For i = 0 To cantidadPreguntasMateria - 1
                            Respuestas_Materia_1_Sesion1_Matematicas(i) = Respuestas_Sesion1(i + 4 + Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0))
                        Next
                    ElseIf CBOMATERIA.Text = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 2) Then
                        'SOCIALES Y CIUDADANAS
                        For i = 0 To cantidadPreguntasMateria - 1
                            Respuestas_Materia_1_Sesion1_Matematicas(i) = Respuestas_Sesion1(i + 4 + Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0) + Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1))
                        Next
                    ElseIf CBOMATERIA.Text = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 3) Then
                        'CIENCIAS NATURALES
                        For i = 0 To cantidadPreguntasMateria - 1
                            Respuestas_Materia_1_Sesion1_Matematicas(i) = Respuestas_Sesion1(i + 4 + Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0) + Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1) + Materia_Cantidad_Componentes_Competencias_Sesion1(1, 2))
                        Next
                    ElseIf CBOMATERIA.Text = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 4) Then
                        'INGLES
                        For i = 0 To cantidadPreguntasMateria - 1
                            Respuestas_Materia_1_Sesion1_Matematicas(i) = Respuestas_Sesion1(i + 4 + Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0) + Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1) + Materia_Cantidad_Componentes_Competencias_Sesion1(1, 2) + Materia_Cantidad_Componentes_Competencias_Sesion1(1, 3))
                        Next
                    End If

                    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%   MAGIA  cantidadPreguntasMateria
                    For i = 0 To cantidadPreguntasMateria - 1
                        If Respuestas_Materia_1_Sesion1_Matematicas(i) = 1 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text 'MATERIA
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)    'NUMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 2) = Contador_respuestas_cada_materia(i, 2) + 1              'CANTIDAD PREGUNTA  A
                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 2 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)    'NUMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 3) = Contador_respuestas_cada_materia(i, 3) + 1             'CANTIDAD PREGUNTA  B
                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 3 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)    'NUMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 4) = Contador_respuestas_cada_materia(i, 4) + 1              'CANTIDAD PREGUNTA  C
                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 4 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)    'NUMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 5) = Contador_respuestas_cada_materia(i, 5) + 1             'CANTIDAD PREGUNTA  D
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
                        End If
                    Next
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA asertividad_materias", 16, "ERROR")
                    Me.Hide()
                End Try
                Control = 14
                Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
                Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
                Estudiantes_Colegio.materia = CBOMATERIA.Text
                Estudiantes_Colegio.grupo = CBOCODIGOGRUPO.Text
                Estudiantes_Colegio.codigo_prueba = 4
                Estudiantes_Colegio.Show()
            End If

        ElseIf CBOTIPO.Text = "saber 10 y 11 4 Preguntas Abiertas" Or CBOTIPO.Text = "saber 10 y 11_Nuevo" Or CBOTIPO.Text = "saber 3_Nuevo" Or CBOTIPO.Text = "saber 5_Nuevo" Or CBOTIPO.Text = "saber 9_Nuevo" Then

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% BORRAR DATOS TABLA %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim CMD1 As New OleDb.OleDbCommand("DELETE FROM asertividad_materias_calculada WHERE 1", CN)
            CN.Open()
            CMD1.ExecuteNonQuery()
            CN.Close()
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% OBTENER NÚMERO DE PREGUNTAS DE CADA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim DA As New OleDb.OleDbDataAdapter("SELECT codigo_estudiante FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "'AND Identificacion_Prueba= '" & CBOSIMULACRO.Text & "'  ORDER BY codigo_estudiante ASC", CN)
            Dim DQ As New DataSet
            DA.Fill(DQ, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
            cant_registros = DQ.Tables(0).Rows.Count

            If cant_registros = 0 Then
                MsgBox("NO EXISTEN REGISTROS EN LA TABLA", 16, "ERROR")
                Me.Hide()
            Else
                ' CONSULTAR EL TIPO DE GRADO DEL SIMULACRO 
                Dim CMD As New OleDb.OleDbCommand("SELECT DISTINCT grado FROM Formato_Examen_Cantidad WHERE sesion='1' AND codigo='" & CBOSIMULACRO.Text & "'", CN)
                Dim DR As OleDb.OleDbDataReader
                CN.Open()
                DR = CMD.ExecuteReader
                If DR.Read Then
                    grado_simulacro = DR(0)
                Else
                    MsgBox("ERROR. NO SE ENCONTRO EL REGISTRO, EL GRADO NO EXISTE")
                End If
                CN.Close()
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% SACAR LA MATERIA RESPUESTA Formato_Examen %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5
                Dim CMATERIA_FORMATO14 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia, orden  FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND materia= '" & CBOMATERIA.Text & "' ORDER BY pregunta ASC", CN)
                Dim DATA_FORMATO14 As New DataSet
                CMATERIA_FORMATO14.Fill(DATA_FORMATO14, "Formato_Examen")

                Dim cantidadPreguntasMateria As Integer
                cantidadPreguntasMateria = DATA_FORMATO14.Tables(0).Rows.Count

                ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(cantidadPreguntasMateria - 1, 7)
                For x = 0 To cantidadPreguntasMateria - 1   ' cantidad de materias de cada materia
                    For y = 0 To 5
                        Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(x, y) = DATA_FORMATO14.Tables(0).Rows(x).Item(y).ToString
                    Next
                Next
                ReDim Contador_respuestas_cada_materia(cantidadPreguntasMateria - 1, 13)
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    TODAS LAS MATERIAS  "Formato_Examen_Cantidad" %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                ReDim Materia_Cantidad_Componentes_Competencias_Sesion1(13, 4)
                Dim DC As New OleDb.OleDbDataAdapter("SELECT  materia,cantidad_preguntas,cantidad_componente1,cantidad_componente2,cantidad_componente3,cantidad_componente4,cantidad_competencias1,cantidad_competencias2,cantidad_competencias3,cantidad_competencias4,cantidad_competencias5,cantidad_competencias6, cantidad_competencias7, cantidad_competencias8  FROM Formato_Examen_Cantidad WHERE codigo='" & CBOSIMULACRO.Text & "'", CN)
                Dim DL As New DataSet
                DC.Fill(DL, "Formato_Examen_Cantidad")

                For p = 0 To DL.Tables(0).Rows.Count - 1
                    For i = 0 To 13
                        Materia_Cantidad_Componentes_Competencias_Sesion1(i, p) = DL.Tables(0).Rows(p).Item(i).ToString
                    Next
                Next

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  ASERTIVIDAD %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                For y = 0 To cant_registros - 1    'cant_registros: numero de estudiantes de ese grupo con el filtro por colegio y simulacro
                    codigoestudiante = DQ.Tables(0).Rows(y).Item(0).ToString      'codigo de cada estudiante

                    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  LAS RESPUESTAS DISEÑADAS EN EL FORMATO LISTAS PARA VERIFICARLAS %%%%%%%%%%%%%%%%%%%%%%%%%%
                    If CBOTIPO.Text = "saber 10 y 11 4 Preguntas Abiertas" Then
                        Dim DV As New DataSet
                        ' %%%%%%%%%%%%%%%%%%%%%%%%% VALIDA LAS MATERIAS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)
                        If CBOMATERIA.Text = "MATEMÁTICAS" Then
                            'MATEMATICAS
                            Dim MATEMATICAS As New DataSet
                            Dim MATEMATICAS2 As New DataSet
                            Dim columnas_matematicas As Integer
                            Dim columnas_matematicas2 As Integer
                            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS ( 26 )
                            Dim DB_matematicas As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20,preg21,preg22,preg23,preg24,preg25,preg26 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim DB_matematicas2 As New OleDb.OleDbDataAdapter("SELECT preg21,preg22,preg23,preg24,preg25,preg26,preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "'  ORDER BY sesion ASC", CN)
                            DB_matematicas.Fill(MATEMATICAS, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            columnas_matematicas = MATEMATICAS.Tables(0).Columns.Count
                            DB_matematicas2.Fill(MATEMATICAS2, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            columnas_matematicas2 = MATEMATICAS2.Tables(0).Columns.Count

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

                        ElseIf CBOMATERIA.Text = "LECTURA CRÍTICA" Then
                            'LENGUAJE
                            ' LECTURA
                            Dim DB_lectura As New OleDb.OleDbDataAdapter("SELECT preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44,preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim LECTURA As New DataSet
                            DB_lectura.Fill(LECTURA, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_lectura As Integer
                            columnas_lectura = LECTURA.Tables(0).Columns.Count
                            For j = 0 To 0
                                For i = 0 To columnas_lectura - 1
                                    NUMERO2.Text = LECTURA.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "CIENCIAS SOCIALES" Then
                            'SOCIALES Y CIUDADANAS
                            'SOCIALES
                            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE SOCIALES
                            Dim DB_sociales As New OleDb.OleDbDataAdapter("SELECT preg65,preg66,preg67,preg68,preg69,preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim SOCIALES As New DataSet
                            DB_sociales.Fill(SOCIALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_sociales As Integer
                            columnas_sociales = SOCIALES.Tables(0).Columns.Count
                            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ
                            '  SOCIALES
                            Dim DB_sociales2 As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim SOCIALES2 As New DataSet
                            DB_sociales2.Fill(SOCIALES2, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_sociales2 As Integer
                            columnas_sociales2 = SOCIALES2.Tables(0).Columns.Count

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

                        ElseIf CBOMATERIA.Text = "CIENCIAS NATURALES" Then
                            'CIENCIAS NATURALES
                            'NATURALES
                            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE NATURALES (31)
                            Dim DB_naturales As New OleDb.OleDbDataAdapter("SELECT preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108,preg109,preg110,preg111,preg112,preg113,preg114,preg115,preg116,preg117,preg118,preg119,preg120,preg121 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim NATURALES As New DataSet
                            DB_naturales.Fill(NATURALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_naturales As Integer
                            columnas_naturales = NATURALES.Tables(0).Columns.Count
                            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ
                            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS ( 25 + 2 abiertas )
                            Dim DB_naturales2 As New OleDb.OleDbDataAdapter("SELECT preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64,preg65,preg66,preg67,preg68,preg69 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim NATURALES2 As New DataSet
                            DB_naturales2.Fill(NATURALES2, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_naturales2 As Integer
                            columnas_naturales2 = NATURALES2.Tables(0).Columns.Count

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
                        ElseIf CBOMATERIA.Text = "INGLES" Then
                            ' INGLES
                            Dim DB_ingles As New OleDb.OleDbDataAdapter("SELECT preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90,preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108,preg109,preg110,preg111,preg112,preg113,preg114 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim INGLES As New DataSet
                            DB_ingles.Fill(INGLES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_ingles As Integer
                            columnas_ingles = INGLES.Tables(0).Columns.Count
                            For j = 0 To 0
                                For i = 0 To columnas_ingles - 1
                                    NUMERO2.Text = INGLES.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next
                        End If

                    ElseIf CBOTIPO.Text = "saber 10 y 11_Nuevo" Then

                        Dim DV As New DataSet
                        ' %%%%%%%%%%%%%%%%%%%%%%%%% VALIDA LAS MATERIAS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)
                        If CBOMATERIA.Text = "MATEMÁTICAS" Then
                            'MATEMATICAS
                            Dim DB_matematicas As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20,preg21,preg22,preg23,preg24,preg25,preg26,preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44,preg141 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim MATEMATICAS As New DataSet
                            DB_matematicas.Fill(MATEMATICAS, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_matematicas As Integer
                            columnas_matematicas = MATEMATICAS.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_matematicas - 1
                                    NUMERO2.Text = MATEMATICAS.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "LECTURA CRÍTICA" Then
                            'LENGUAJE
                            Dim DB_lectura As New OleDb.OleDbDataAdapter("SELECT preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64,preg65,preg66,preg67,preg68,preg69,preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg142 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim LECTURA As New DataSet
                            DB_lectura.Fill(LECTURA, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_lectura As Integer
                            columnas_lectura = LECTURA.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_lectura - 1
                                    NUMERO2.Text = LECTURA.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "CIENCIAS SOCIALES" Then
                            'SOCIALES Y CIUDADANAS
                            Dim DB_sociales As New OleDb.OleDbDataAdapter("SELECT preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90,preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108,preg109 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim SOCIALES As New DataSet
                            DB_sociales.Fill(SOCIALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_sociales As Integer
                            columnas_sociales = SOCIALES.Tables(0).Columns.Count
                            'SEGUNDA SESION
                            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE SOCIALES  ( 14 segunda sesion  + 1 abierta  )
                            Dim DB_sociales2 As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg141 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' ORDER BY sesion ASC", CN)
                            Dim SOCIALES2 As New DataSet
                            DB_sociales2.Fill(SOCIALES2, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_sociales2 As Integer
                            columnas_sociales2 = SOCIALES2.Tables(0).Columns.Count

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

                        ElseIf CBOMATERIA.Text = "CIENCIAS NATURALES" Then
                            'CIENCIAS NATURALES
                            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE NATURALES (54 + 1 abierta)
                            Dim DB_naturales As New OleDb.OleDbDataAdapter("SELECT preg15,preg16,preg17,preg18,preg19,preg20,preg21,preg22,preg23,preg24,preg25,preg26,preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44,preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64,preg65,preg66,preg67,preg68,preg142 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim NATURALES As New DataSet
                            DB_naturales.Fill(NATURALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_naturales As Integer
                            columnas_naturales = NATURALES.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_naturales - 1
                                    NUMERO2.Text = NATURALES.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "INGLES" Then
                            ' INGLES
                            Dim DB_ingles As New OleDb.OleDbDataAdapter("SELECT preg69,preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90,preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108,preg109,preg110,preg111,preg112,preg113 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim INGLES As New DataSet
                            DB_ingles.Fill(INGLES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_ingles As Integer
                            columnas_ingles = INGLES.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_ingles - 1
                                    NUMERO2.Text = INGLES.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next
                        End If

                    ElseIf CBOTIPO.Text = "saber 3_Nuevo" Then

                        Dim DV As New DataSet
                        ' %%%%%%%%%%%%%%%%%%%%%%%%% VALIDA LAS MATERIAS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)
                        If CBOMATERIA.Text = "MATEMÁTICAS" Then

                            Dim DB_matematicas As New OleDb.OleDbDataAdapter("SELECT preg21,preg22,preg23,preg24,preg25,preg26,preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim MATEMATICAS As New DataSet
                            DB_matematicas.Fill(MATEMATICAS, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_matematicas As Integer
                            columnas_matematicas = MATEMATICAS.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_matematicas - 1
                                    NUMERO2.Text = MATEMATICAS.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "LENGUAJE" Then

                            Dim DB_lectura As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20  FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim LENGUAJE As New DataSet
                            DB_lectura.Fill(LENGUAJE, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_lenguaje As Integer
                            columnas_lenguaje = LENGUAJE.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_lenguaje - 1
                                    NUMERO2.Text = LENGUAJE.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next
                        End If

                    ElseIf CBOTIPO.Text = "saber 5_Nuevo" Then
                        Dim DV As New DataSet
                        ' %%%%%%%%%%%%%%%%%%%%%%%%% VALIDA LAS MATERIAS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)
                        If CBOMATERIA.Text = "MATEMÁTICAS" Then
                            Dim DB_matematicas As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20,preg21,preg22,preg23,preg24,preg25,preg26,preg27 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim MATEMATICAS As New DataSet
                            DB_matematicas.Fill(MATEMATICAS, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_matematicas As Integer
                            columnas_matematicas = MATEMATICAS.Tables(0).Columns.Count

                            For j = 0 To 0
                                ' If MATEMATICAS.Tables(0).Rows(j).Item(1).ToString = 1 Then
                                For i = 0 To columnas_matematicas - 1
                                    NUMERO2.Text = MATEMATICAS.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "LENGUAJE" Then
                            Dim DB_lectura As New OleDb.OleDbDataAdapter("SELECT preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44,preg45,preg46,preg47,preg48 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim LENGUAJE As New DataSet
                            DB_lectura.Fill(LENGUAJE, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_lenguaje As Integer
                            columnas_lenguaje = LENGUAJE.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_lenguaje - 1
                                    NUMERO2.Text = LENGUAJE.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "COMPETENCIAS CIUDADANAS" Then
                            Dim DB_sociales As New OleDb.OleDbDataAdapter("SELECT preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90,preg91,preg92,preg93,preg94,preg95,preg96 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim SOCIALES As New DataSet
                            DB_sociales.Fill(SOCIALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_sociales As Integer
                            columnas_sociales = SOCIALES.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_sociales - 1
                                    NUMERO2.Text = SOCIALES.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "CIENCIAS NATURALES" Then
                            Dim DB_naturales As New OleDb.OleDbDataAdapter("SELECT preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64,preg65,preg66,preg67,preg68,preg69 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim NATURALES As New DataSet
                            DB_naturales.Fill(NATURALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_naturales As Integer
                            columnas_naturales = NATURALES.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_naturales - 1
                                    NUMERO2.Text = NATURALES.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next
                        End If

                    ElseIf CBOTIPO.Text = "saber 9_Nuevo" Then
                        Dim DV As New DataSet
                        ' %%%%%%%%%%%%%%%%%%%%%%%%% VALIDA LAS MATERIAS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        ReDim Respuestas_Materia_1_Sesion1_Matematicas(cantidadPreguntasMateria - 1)
                        If CBOMATERIA.Text = "MATEMÁTICAS" Then

                            Dim DB_matematicas As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20,preg21,preg22,preg23,preg24,preg25,preg26,preg27 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim MATEMATICAS As New DataSet
                            DB_matematicas.Fill(MATEMATICAS, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_matematicas As Integer
                            columnas_matematicas = MATEMATICAS.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_matematicas - 1
                                    NUMERO2.Text = MATEMATICAS.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "LENGUAJE" Then
                            Dim DB_lectura As New OleDb.OleDbDataAdapter("SELECT preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44,preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim LENGUAJE As New DataSet
                            DB_lectura.Fill(LENGUAJE, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_lenguaje As Integer
                            columnas_lenguaje = LENGUAJE.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_lenguaje - 1
                                    NUMERO2.Text = LENGUAJE.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "COMPETENCIAS CIUDADANAS" Then

                            Dim DB_sociales As New OleDb.OleDbDataAdapter("SELECT preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90,preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim SOCIALES As New DataSet
                            DB_sociales.Fill(SOCIALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_sociales As Integer
                            columnas_sociales = SOCIALES.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_sociales - 1
                                    NUMERO2.Text = SOCIALES.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next

                        ElseIf CBOMATERIA.Text = "CIENCIAS NATURALES" Then

                            Dim DB_naturales As New OleDb.OleDbDataAdapter("SELECT preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64,preg65,preg66,preg67,preg68,preg69,preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81 FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "' AND Identificacion_Prueba='" & CBOSIMULACRO.Text & "' ORDER BY sesion ASC", CN)
                            Dim NATURALES As New DataSet
                            DB_naturales.Fill(NATURALES, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                            Dim columnas_naturales As Integer
                            columnas_naturales = NATURALES.Tables(0).Columns.Count

                            For j = 0 To 0
                                For i = 0 To columnas_naturales - 1
                                    NUMERO2.Text = NATURALES.Tables(0).Rows(0).Item(i).ToString
                                    Respuestas_Materia_1_Sesion1_Matematicas(i) = NUMERO2.Text.ToString
                                Next
                            Next
                        End If

                    End If

                    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%   MAGIA  cantidadPreguntasMateria
                    For i = 0 To cantidadPreguntasMateria - 1
                        If Respuestas_Materia_1_Sesion1_Matematicas(i) = 1 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text 'MATERIA
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)   'NUMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 2) = Contador_respuestas_cada_materia(i, 2) + 1              'CANTIDAD PREGUNTA  A
                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 2 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)   'NUMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 3) = Contador_respuestas_cada_materia(i, 3) + 1             'CANTIDAD PREGUNTA  B
                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 3 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)   'NUMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 4) = Contador_respuestas_cada_materia(i, 4) + 1              'CANTIDAD PREGUNTA  C
                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 4 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)   'NUMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 5) = Contador_respuestas_cada_materia(i, 5) + 1             'CANTIDAD PREGUNTA  D
                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 5 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)   'UMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 6) = Contador_respuestas_cada_materia(i, 6) + 1             'CANTIDAD PREGUNTA  E
                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 6 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)   'UMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 7) = Contador_respuestas_cada_materia(i, 7) + 1             'CANTIDAD PREGUNTA  F
                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 7 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)   'UMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 8) = Contador_respuestas_cada_materia(i, 8) + 1             'CANTIDAD PREGUNTA  G
                            Contador_respuestas_cada_materia(i, 10) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2)   'RESPUESTA CORRECTA
                            Contador_respuestas_cada_materia(i, 11) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3)   'COMPONENTE
                            Contador_respuestas_cada_materia(i, 12) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4)   'COMPETENCIA
                        ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 8 Then
                            Contador_respuestas_cada_materia(i, 0) = CBOMATERIA.Text
                            Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 5)   'UMERO_PREGUNTA
                            Contador_respuestas_cada_materia(i, 9) = Contador_respuestas_cada_materia(i, 9) + 1             'CANTIDAD PREGUNTA  H
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
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & CInt(Contador_respuestas_cada_materia(i, 7)) & "','" & CInt(Contador_respuestas_cada_materia(i, 8)) & "','" & CInt(Contador_respuestas_cada_materia(i, 9)) & "','" & CInt(Contador_respuestas_cada_materia(i, 10)) & "','" & Contador_respuestas_cada_materia(i, 11) & "','" & Contador_respuestas_cada_materia(i, 12) & "','" & (Contador_respuestas_cada_materia(i, 9) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()

                        End If
                    Next
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA asertividad_materias", 16, "ERROR")
                    Me.Hide()
                End Try
                Control = 14
                Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
                Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
                Estudiantes_Colegio.materia = CBOMATERIA.Text
                Estudiantes_Colegio.grupo = CBOCODIGOGRUPO.Text
                Estudiantes_Colegio.codigo_prueba = 4
                Estudiantes_Colegio.Show()
            End If


        ElseIf CBOTIPO.Text = "saber 4,6,7 y 8" Then

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% BORRAR DATOS TABLA %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim CMD1 As New OleDb.OleDbCommand("DELETE FROM asertividad_materias_calculada WHERE 1", CN)
            CN.Open()
            CMD1.ExecuteNonQuery()
            CN.Close()
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% PRIMERA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5
            Dim CMATERIA_FORMATO1 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia, orden FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND sesion='1'  ORDER BY pregunta ASC", CN)
            Dim DATA_FORMATO1 As New DataSet
            CMATERIA_FORMATO1.Fill(DATA_FORMATO1, "Formato_Examen")
            'Dim cantidad_preguntas_sesion1 As String
            Dim cantidad_preguntas_simulacro_creado As String
            cantidad_preguntas_simulacro_creado = DATA_FORMATO1.Tables(0).Rows.Count
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% OBTENER NÚMERO DE PREGUNTAS DE CADA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim DA As New OleDb.OleDbDataAdapter("SELECT codigo_estudiante FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "'AND Identificacion_Prueba= '" & CBOSIMULACRO.Text & "'  ORDER BY codigo_estudiante ASC", CN)
            Dim DQ As New DataSet
            DA.Fill(DQ, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
            cant_registros = DQ.Tables(0).Rows.Count

            If cant_registros = 0 Then
                MsgBox("NO EXISTEN REGISTROS EN LA TABLA", 16, "ERROR")
                Me.Hide()
            Else

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% OBTENER EL FORMATO DEL EXAMEN  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                Dim DB2 As New OleDb.OleDbDataAdapter("SELECT  orden FROM Formato_Examen_Cantidad WHERE sesion='1' AND codigo='" & CBOSIMULACRO.Text & "' ORDER BY orden ASC", CN)
                Dim DV2 As New DataSet
                DB2.Fill(DV2, "Formato_Examen_Cantidad")
                cantidad_materias_1 = DV2.Tables(0).Rows.Count
                ' PARA RECORRER LOS EXAMENES DE CADA ESTUDIANTE
                Dim TODAS_MATERIAS As Integer
                TODAS_MATERIAS = cantidad_materias_1

                'cantidad_preguntas_sesion1
                Dim CMATERIA_FORMATO11 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND sesion='1'", CN)
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
                    For y = 0 To 5
                        ' datos de la tabla Formato_Examen  Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1 simulacro creado
                        Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(x, y) = DATA_FORMATO1.Tables(0).Rows(x).Item(y).ToString
                    Next
                Next

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  ASERTIVIDAD %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                ReDim Contador_respuestas_cada_materia((CInt(cantidad_preguntas_sesion11)) - 1, 9)
                contador_preguntas_de_una_materia = 0

                For y = 0 To cant_registros - 1    'cant_registros: 

                    codigoestudiante = DQ.Tables(0).Rows(y).Item(0).ToString
                    Dim DB1 As New OleDb.OleDbDataAdapter("SELECT  * FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' AND codigo_colegio='" & CBOCODIGOSEDE.Text & "'AND codigo_grupo='" & CBOCODIGOGRUPO.Text & "'AND Identificacion_Prueba= '" & CBOSIMULACRO.Text & "'", CN)

                    Dim DV1 As New DataSet
                    DB1.Fill(DV1, "Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2")
                    ' RESPUESTAS DE LA SESION 1
                    Dim columnas1 As Integer
                    columnas1 = DV1.Tables(0).Columns.Count
                    ReDim Respuestas_Sesion1(columnas1 - 1)

                    For i = 0 To columnas1 - 1
                        NUMERO2.Text = DV1.Tables(0).Rows(0).Item(i).ToString
                        If NUMERO2.Text.ToString = "" Then
                            NUMERO2.Text = 0
                        End If
                        sesion1(i) = NUMERO2.Text.ToString
                        Respuestas_Sesion1(i) = NUMERO2.Text.ToString
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
                                        Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 5)
                                        Contador_respuestas_cada_materia(i, 2) = Contador_respuestas_cada_materia(i, 2) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 2 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 5)
                                        Contador_respuestas_cada_materia(i, 3) = Contador_respuestas_cada_materia(i, 3) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 3 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 5)
                                        Contador_respuestas_cada_materia(i, 4) = Contador_respuestas_cada_materia(i, 4) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 4 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 5)
                                        Contador_respuestas_cada_materia(i, 5) = Contador_respuestas_cada_materia(i, 5) + 1

                                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
                                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
                                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

                                    ElseIf Respuestas_Sesion1(i + 3) = 5 Then
                                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
                                        Contador_respuestas_cada_materia(i, 1) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 5)
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

                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 2) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 7) = "2" Then
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 3) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 7) = "3" Then
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 4) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 7) = "4" Then
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 5) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        ElseIf Contador_respuestas_cada_materia(i, 7) = "5" Then
                            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias_calculada VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & CInt(Contador_respuestas_cada_materia(i, 1)) & "','" & CInt(Contador_respuestas_cada_materia(i, 2)) & "','" & CInt(Contador_respuestas_cada_materia(i, 3)) & "','" & CInt(Contador_respuestas_cada_materia(i, 4)) & "','" & CInt(Contador_respuestas_cada_materia(i, 5)) & "','" & CInt(Contador_respuestas_cada_materia(i, 6)) & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 6) / cant_registros) * 100 & "')", CN)
                            CN.Open()
                            CMD2.ExecuteNonQuery()
                            CN.Close()
                        End If
                    Next
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA asertividad_materias", 16, "ERROR")
                    Me.Hide()
                End Try

                Control = 14
                Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
                Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
                Estudiantes_Colegio.materia = CBOMATERIA.Text
                Estudiantes_Colegio.grupo = CBOCODIGOGRUPO.Text
                Estudiantes_Colegio.codigo_prueba = 3
                Estudiantes_Colegio.Show()

            End If

        End If

    End Sub

    Private Sub CBOCODIGOSEDE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCODIGOSEDE.SelectedIndexChanged
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_gupo  FROM grupos WHERE codigo_colegios='" & CBOCODIGOSEDE.Text & "' GROUP BY codigo_gupo", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "grupos")
        CBOCODIGOGRUPO.DataSource = DS.Tables("grupos")
        CBOCODIGOGRUPO.DisplayMember = "codigo_gupo"
    End Sub

    Private Sub CBOTIPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOTIPO.SelectedIndexChanged

        Dim DB As New OleDb.OleDbDataAdapter("SELECT  DISTINCT codigo  FROM simulacros_pruebas  WHERE nombre_prueba='" & CBOTIPO.Text & "'", CN)
        Dim DD As New DataSet
        DB.Fill(DD, "simulacros_pruebas")
        CBOSIMULACRO.DataSource = DD.Tables("simulacros_pruebas")
        CBOSIMULACRO.DisplayMember = "codigo"

    End Sub

    Private Sub CBOSIMULACRO_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CBOSIMULACRO.SelectedIndexChanged

        Dim Dp As New OleDb.OleDbDataAdapter("SELECT materia FROM Formato_Examen_Cantidad WHERE codigo='" & CBOSIMULACRO.Text & "' ORDER BY orden ASC", CN)
        Dim DBA As New DataSet
        Dp.Fill(DBA, "Formato_Examen_Cantidad")
        CBOMATERIA.DataSource = DBA.Tables("Formato_Examen_Cantidad")
        CBOMATERIA.DisplayMember = "materia"

    End Sub

End Class