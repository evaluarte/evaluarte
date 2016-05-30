Imports System.Data.OleDb
Public Class Asertividad_Materias

    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Sistemas3\d\sistemaevaluarte.accdb")
    Public codigoestudiante As Integer
    Public TIPO As Double
    Dim grado_simulacro As String
    ' NUCLEO COMUN / COMPONENTES  Y NIVEL DE COMPETENCIA
    Public contador_a As Integer
    Public contador_b As Integer
    Public contador_c As Integer
    Public contador_d As Integer
    Public contador_e As Integer
    Public contador_materia_encontrada As Integer
    ' RESPUESTAS DE LAS DOS SESIONES
    Dim puntajepromedio As Double
    Dim Respuestas_Sesion1() As String
    Dim Respuestas_Sesion2() As String
    Dim Respuestas_Materia_1_Sesion1_Matematicas() As String
    Dim Respuestas_Materia_2_Sesion1_Naturales() As String
    Dim Respuestas_Materia_1_Sesion2_Ingles() As String
    Dim Respuestas_Materia_2_Sesion2_Lectura() As String
    Dim Respuestas_Materia_3_Sesion2_Sociales() As String
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Dim Materia_Cantidad_Componentes_Competencias_Sesion1(,)
    Dim Materia_Cantidad_Componentes_Competencias_Sesion2(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia1_Ingles(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(,)
    Dim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(,)
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
    'Contador_respuestas_cada_materia
    Dim Contador_respuestas_cada_materia(,)
    'guardar la cantidad de materias de cada simulacro
    Dim cantidad_materias_1 As Integer
    Dim cantidad_materias_2 As Integer
    Dim sesion1 As Array = Array.CreateInstance(GetType(Integer), 294)
    Dim sesion2 As Array = Array.CreateInstance(GetType(Integer), 146)
    Dim MyArray1 As Array = Array.CreateInstance(GetType(Integer), 44)
    Dim A As Array = Array.CreateInstance(GetType(Integer), 44)
    Dim B As Array = Array.CreateInstance(GetType(Integer), 44)
    Dim cant_registros As Integer
    Dim registros_totales As String
    Dim CODIGOEXAMEN As String
    Dim dato_aux As Double
    Dim MyArray2 As Array = Array.CreateInstance(GetType(Integer), 30)
    Dim C As Array = Array.CreateInstance(GetType(Integer), 30)
    Dim D As Array = Array.CreateInstance(GetType(Integer), 30)
    Dim cant_registros1 As Integer
    Dim CODIGOEXAMEN1 As String


    Private Sub Asertividad_Materias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR_PRUEBAS()
    End Sub

    Sub CARGAR_PRUEBAS()
        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre_prueba  FROM Pruebas", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "Pruebas")
        CBOTIPO.DataSource = DF.Tables("Pruebas")
        CBOTIPO.DisplayMember = "nombre_prueba"
    End Sub

    Sub CARGAR()
        Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT codigo_colegio  FROM Colegio_grupo_analizado", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "Colegio_grupo_analizado")
        CBOCODIGO.DataSource = DS.Tables("Colegio_grupo_analizado")
        CBOCODIGO.DisplayMember = "codigo_colegio"

        Dim DB As New OleDb.OleDbDataAdapter("SELECT DISTINCT codigo_grupo  FROM Colegio_grupo_analizado", CN)
        Dim DD As New DataSet
        DB.Fill(DD, "Colegio_grupo_analizado")
        CBOGRUPO.DataSource = DD.Tables("Colegio_grupo_analizado")
        CBOGRUPO.DisplayMember = "codigo_grupo"
    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click

        Dim TIPO As String
        Dim DL As New OleDb.OleDbDataAdapter("SELECT  codigo_prueba  FROM Pruebas WHERE nombre_prueba='" & CBOTIPO.Text & "'", CN)
        Dim DT As New DataSet
        DL.Fill(DT, "Pruebas")
        TXTTIPO.Text = DT.Tables(0).Rows(0).Item(0).ToString
        TIPO = TXTTIPO.Text

        If TIPO = "" Then
            MsgBox("Seleccione alguna Prueba", 8, "Aviso")
        Else

            If TIPO = 1 Then

                ' niveles de pensamiento y estilos de aprendizaje
                CARGAR()
                'CALIFICAR()
                Dim calificacion As Date
                calificacion = DateTimePicker2.Value
                calificacion = Format(calificacion, "dd/MM/yyyy")

                Dim CMD1 As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Fecha_Calificar='" & calificacion & "'  WHERE Codigo_Colegio='" & CBOCODIGO.Text & "'AND Grupo='" & CBOGRUPO.Text & "'AND Codigo_Simulacro='" & TIPO & "'", CN)
                CN.Open()
                CMD1.ExecuteNonQuery()
                CN.Close()

                Timer1.Start()
                'Me.Hide()
                'CARGARCNBSIMULACRO()

            ElseIf TIPO = 2 Then
                ' perfil profesional
                'CARGAR_COLEGIO_GRUPO_PERFIL_PROFESIONAL()
                'CALIFICAR_PERFIL_PROFESIONAL()
                Dim calificacion As Date
                calificacion = DateTimePicker2.Value
                calificacion = Format(calificacion, "dd/MM/yyyy")

                'LUEGO CUADRAR ESTO
                Dim CMD1 As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Fecha_Calificar='" & calificacion & "'  WHERE Codigo_Colegio='" & CBOCODIGO.Text & "'AND Grupo='" & CBOGRUPO.Text & "'AND Codigo_Simulacro='" & TIPO & "'", CN)
                CN.Open()
                CMD1.ExecuteNonQuery()
                CN.Close()
                Timer1.Start()

            ElseIf TIPO = 3 Then
                ' saber 3,5 y 9
                Dim calificacion As Date
                calificacion = DateTimePicker2.Value
                calificacion = Format(calificacion, "dd/MM/yyyy")
                'CALIFICAR_SABER359()

                Dim CMD1 As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Fecha_Calificar='" & calificacion & "'  WHERE Codigo_Colegio='" & CBOCODIGO.Text & "'AND Grupo='" & CBOGRUPO.Text & "'AND Codigo_Simulacro='" & TIPO & "'", CN)
                CN.Open()
                CMD1.ExecuteNonQuery()
                CN.Close()
                Timer1.Start()

            ElseIf TIPO = 4 Then
                'saber 10 y 11
                Dim calificacion As Date
                calificacion = DateTimePicker2.Value
                calificacion = Format(calificacion, "dd/MM/yyyy")
                'CALIFICAR_SABER1011()
                Dim CMD1 As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Fecha_Calificar='" & calificacion & "'  WHERE Codigo_Colegio='" & CBOCODIGO.Text & "'AND Grupo='" & CBOGRUPO.Text & "'AND Codigo_Simulacro='" & TIPO & "'", CN)
                CN.Open()
                CMD1.ExecuteNonQuery()
                CN.Close()

                Timer1.Start()
                'Me.Hide()
                'CARGARCNBSIMULACRO()

            ElseIf TIPO = 5 Then
                'saber 10 y 11 Nuevo
                Dim calificacion As Date
                calificacion = DateTimePicker2.Value
                calificacion = Format(calificacion, "dd/MM/yyyy")
                'CALIFICAR_SABER1011_NUEVO()
                Dim CMD1 As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Fecha_Calificar='" & calificacion & "'  WHERE Codigo_Colegio='" & CBOCODIGO.Text & "'AND Grupo='" & CBOGRUPO.Text & "'AND Codigo_Simulacro='" & TIPO & "'", CN)
                CN.Open()
                CMD1.ExecuteNonQuery()
                CN.Close()

                Timer1.Start()
                'Me.Hide()
                'CARGARCNBSIMULACRO()
            ElseIf TIPO = 6 Then
                'saber 9_Nuevo

                Dim calificacion As Date
                calificacion = DateTimePicker2.Value
                calificacion = Format(calificacion, "dd/MM/yyyy")
                'CALIFICAR_SABER9_NUEVO()
                Dim CMD1 As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Fecha_Calificar='" & calificacion & "'  WHERE Codigo_Colegio='" & CBOCODIGO.Text & "'AND Grupo='" & CBOGRUPO.Text & "'AND Codigo_Simulacro='" & TIPO & "'", CN)
                CN.Open()
                CMD1.ExecuteNonQuery()
                CN.Close()

                Timer1.Start()
                'Me.Hide()
                'CARGARCNBSIMULACRO()
            ElseIf TIPO = 7 Then
                'saber 5_Nuevo

                Dim calificacion As Date
                calificacion = DateTimePicker2.Value
                calificacion = Format(calificacion, "dd/MM/yyyy")
                'CALIFICAR_SABER5_NUEVO()
                Dim CMD1 As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Fecha_Calificar='" & calificacion & "'  WHERE Codigo_Colegio='" & CBOCODIGO.Text & "'AND Grupo='" & CBOGRUPO.Text & "'AND Codigo_Simulacro='" & TIPO & "'", CN)
                CN.Open()
                CMD1.ExecuteNonQuery()
                CN.Close()

                Timer1.Start()
                'Me.Hide()
                'CARGARCNBSIMULACRO()

            ElseIf TIPO = 8 Then
                'saber 3_Nuevo

                Dim calificacion As Date
                calificacion = DateTimePicker2.Value
                calificacion = Format(calificacion, "dd/MM/yyyy")
                'CALIFICAR_SABER3_NUEVO()
                Dim CMD1 As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Fecha_Calificar='" & calificacion & "'  WHERE Codigo_Colegio='" & CBOCODIGO.Text & "'AND Grupo='" & CBOGRUPO.Text & "'AND Codigo_Simulacro='" & TIPO & "'", CN)
                CN.Open()
                CMD1.ExecuteNonQuery()
                CN.Close()

                Timer1.Start()
                'Me.Hide()
                'CARGARCNBSIMULACRO()
            ElseIf TIPO = 9 Then
                'saber 10 y 11 cuatro abiertas
                Dim calificacion As Date
                calificacion = DateTimePicker2.Value
                calificacion = Format(calificacion, "dd/MM/yyyy")
                ASERTIVIDAD_SABER1011_4ABIERTAS()
                Timer1.Start()
                Me.Hide()
                'CARGARCNBSIMULACRO()
            Else


                MsgBox("Esta Prueba no existe", 8, "mensaje adavertencia")
            End If
        End If

    End Sub

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
        End If
        Label4.Text = ProgressBar1.Value & ("%")
    End Sub

    Sub ASERTIVIDAD_SABER1011_4ABIERTAS()

        '%%%%%%%%%%%%%%%%%%%%%% PARA SACAR LAS RESPUESTAS CONTESTADAS EN EL SIMULACRO EN LA SESION 1 %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_estudiante FROM Preguntas_Saber_Sesion2 WHERE sesion='1'  ORDER BY codigo_estudiante ASC", CN)
        Dim DQ As New DataSet
        DA.Fill(DQ, "Preguntas_Saber_Sesion2")
        NUMERO2.Text = DQ.Tables(0).Rows.Count
        cant_registros = NUMERO2.Text  'GUARDO LA CANTIDAD DE ESTUDIANTES QUE HAY 

        For n = 0 To cant_registros - 1

            ' RECORRO LOS REGISTROS DE LA SESION UNO PARA SACAR EL CODIGO DEL ESTUDIANTE
            TXTCODIGOEXAMEN1.Text = DQ.Tables(0).Rows(n).Item(0).ToString
            codigoestudiante = TXTCODIGOEXAMEN1.Text

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% OBTENER NÚMERO DE PREGUNTAS DE CADA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim DB2 As New OleDb.OleDbDataAdapter("SELECT  orden FROM Formato_Examen_Cantidad WHERE sesion='1' AND codigo='" & CBOSIMULACRO.Text & "' ORDER BY orden ASC", CN)
            Dim DV2 As New DataSet
            DB2.Fill(DV2, "Formato_Examen_Cantidad")
            cantidad_materias_1 = DV2.Tables(0).Rows.Count
            'Cantidad de Materias Sesion 1

            Dim DB3 As New OleDb.OleDbDataAdapter("SELECT  orden FROM Formato_Examen_Cantidad WHERE sesion='2' AND codigo='" & CBOSIMULACRO.Text & "' ORDER BY orden ASC", CN)
            Dim DV3 As New DataSet
            DB3.Fill(DV3, "Formato_Examen_Cantidad")
            cantidad_materias_2 = DV3.Tables(0).Rows.Count
            'Cantidad de materias Sesion 2
            '%%%%%%%%%%%%%%%%%%%%%%% CONSULTAR EL TIPO DE GRADO DEL SIMULACRO  %%%%%%%%%%%%%%%%
            Dim CMD As New OleDb.OleDbCommand("SELECT DISTINCT grado FROM Formato_Examen_Cantidad WHERE sesion='2' AND codigo='" & CBOSIMULACRO.Text & "'", CN)
            Dim DR As OleDb.OleDbDataReader
            CN.Open()
            DR = CMD.ExecuteReader
            If DR.Read Then
                grado_simulacro = DR(0)
            Else
                MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
            End If
            CN.Close()
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% OBTENER EL SIMULACRO CREADO PREDERTMINADAMENTE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            ' codigo_simulacro.Text:  codigo del simulacro
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    TODAS LAS MATERIAS  "Formato_Examen_Cantidad" %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            ReDim Materia_Cantidad_Componentes_Competencias_Sesion1(10, cantidad_materias_1 - 1)  ' G
            ReDim Materia_Cantidad_Componentes_Competencias_Sesion2(10, cantidad_materias_2 - 1)
            'ReDim Materia_Tipo_cantidadpreguntas_Flexible(2, cantidad_preguntas_flexible - 1)
            ' Materia_Cantidad_Componentes_Competencias_Sesion1 
            Dim DC As New OleDb.OleDbDataAdapter("SELECT  materia,cantidad_preguntas,cantidad_componente1,cantidad_componente2,cantidad_componente3,cantidad_componente4,cantidad_competencias1,cantidad_competencias2,cantidad_competencias3,cantidad_cuantitativo,cantidad_ciudadanas FROM Formato_Examen_Cantidad WHERE sesion='1' AND codigo='" & CBOSIMULACRO.Text & "'", CN)
            Dim DL As New DataSet
            DC.Fill(DL, "Formato_Examen_Cantidad")
            For p = 0 To cantidad_materias_1 - 1
                For i = 0 To 10
                    Materia_Cantidad_Componentes_Competencias_Sesion1(i, p) = DL.Tables(0).Rows(p).Item(i).ToString
                Next
            Next

            ' Materia_Cantidad_Componentes_Competencias_Sesion2
            Dim DC1 As New OleDb.OleDbDataAdapter("SELECT  materia,cantidad_preguntas,cantidad_componente1,cantidad_componente2,cantidad_componente3,cantidad_componente4,cantidad_competencias1,cantidad_competencias2,cantidad_competencias3,cantidad_cuantitativo,cantidad_ciudadanas FROM Formato_Examen_Cantidad WHERE sesion='2' AND codigo='" & CBOSIMULACRO.Text & "'", CN)
            Dim DL1 As New DataSet
            DC1.Fill(DL1, "Formato_Examen_Cantidad")

            For p = 0 To cantidad_materias_2 - 1
                For i = 0 To 10
                    Materia_Cantidad_Componentes_Competencias_Sesion2(i, p) = DL1.Tables(0).Rows(p).Item(i).ToString
                Next
            Next


            'TRAER TODOS LAS PREGUNTAS LAS RESPUESTAS EN LA SESION1
            'Dim DB As New OleDb.OleDbDataAdapter("SELECT  preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20,preg21,preg22,preg23,preg24,preg25,preg26,preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44,preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64,preg65,preg66,preg67,preg68,preg69,preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg89,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90,preg91,preg92,preg93,preg94,preg95, FROM Preguntas_niveles_pensamiento WHERE codigo_estudiante='" & codigoestudiante & "'", CN)

            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS

            'Dim DB_matematicas As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20,preg21,preg22,preg23,preg24,preg25,preg26,preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44,preg141 FROM Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
            'Dim MATEMATICAS As New DataSet
            'DB_matematicas.Fill(MATEMATICAS, "Preguntas_Saber_Sesion2")
            'Dim columnas_matematicas As Integer
            'columnas_matematicas = MATEMATICAS.Tables(0).Columns.Count


            'TRAER TODOS LAS PREGUNTAS LAS RESPUESTAS EN LA SESION1

            'MATEMATICAS
            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS ( 26 )
            Dim DB_matematicas As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20,preg21,preg22,preg23,preg24,preg25,preg26 FROM Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
            Dim MATEMATICAS As New DataSet
            DB_matematicas.Fill(MATEMATICAS, "Preguntas_Saber_Sesion2")
            Dim columnas_matematicas As Integer
            columnas_matematicas = MATEMATICAS.Tables(0).Columns.Count
            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ

            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS ( 24 )
            Dim DB_matematicas2 As New OleDb.OleDbDataAdapter("SELECT preg21,preg22,preg23,preg24,preg25,preg26,preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44 FROM Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
            Dim MATEMATICAS2 As New DataSet
            DB_matematicas2.Fill(MATEMATICAS2, "Preguntas_Saber_Sesion2")
            Dim columnas_matematicas2 As Integer
            columnas_matematicas2 = MATEMATICAS2.Tables(0).Columns.Count
            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ

            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS ( 2 abiertas )
            Dim DB_matematicas_abiertas As New OleDb.OleDbDataAdapter("SELECT preg141,preg142 FROM Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
            Dim MATEMATICAS_ABIERTAS As New DataSet
            DB_matematicas_abiertas.Fill(MATEMATICAS_ABIERTAS, "Preguntas_Saber_Sesion2")
            Dim columnas_matematicas_abiertas As Integer
            columnas_matematicas_abiertas = MATEMATICAS_ABIERTAS.Tables(0).Columns.Count
            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ 
            'FIN MATEMATICAS

            'NATURALES
            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE NATURALES (31)
            Dim DB_naturales As New OleDb.OleDbDataAdapter("SELECT preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108,preg109,preg110,preg111,preg112,preg113,preg114,preg115,preg116,preg117,preg118,preg119,preg120,preg121 FROM Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
            Dim NATURALES As New DataSet
            DB_naturales.Fill(NATURALES, "Preguntas_Saber_Sesion2")
            Dim columnas_naturales As Integer
            columnas_naturales = NATURALES.Tables(0).Columns.Count
            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ

            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE MATEMATICAS ( 25 + 2 abiertas )
            Dim DB_naturales2 As New OleDb.OleDbDataAdapter("SELECT preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64,preg65,preg66,preg67,preg68,preg69,preg143,preg144 FROM Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
            Dim NATURALES2 As New DataSet
            DB_naturales2.Fill(NATURALES2, "Preguntas_Saber_Sesion2")
            Dim columnas_naturales2 As Integer
            columnas_naturales2 = NATURALES2.Tables(0).Columns.Count
            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ

            'FIN NATURALES

            'SOCIALES
            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE SOCIALES
            Dim DB_sociales As New OleDb.OleDbDataAdapter("SELECT preg65,preg66,preg67,preg68,preg69,preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90 FROM Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
            Dim SOCIALES As New DataSet
            DB_sociales.Fill(SOCIALES, "Preguntas_Saber_Sesion2")
            Dim columnas_sociales As Integer
            columnas_sociales = SOCIALES.Tables(0).Columns.Count
            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ

            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE SOCIALES
            Dim DB_sociales2 As New OleDb.OleDbDataAdapter("SELECT preg1,preg2,preg3,preg4,preg5,preg6,preg7,preg8,preg9,preg10,preg11,preg12,preg13,preg14,preg15,preg16,preg17,preg18,preg19,preg20,preg141,preg142 FROM Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
            Dim SOCIALES2 As New DataSet
            DB_sociales2.Fill(SOCIALES2, "Preguntas_Saber_Sesion2")
            Dim columnas_sociales2 As Integer
            columnas_sociales2 = SOCIALES2.Tables(0).Columns.Count
            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ
            'FIN SOCIALES

            ' LECTURA
            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE LECTURA
            Dim DB_lectura As New OleDb.OleDbDataAdapter("SELECT preg27,preg28,preg29,preg30,preg31,preg32,preg33,preg34,preg35,preg36,preg37,preg38,preg39,preg40,preg41,preg42,preg43,preg44,preg45,preg46,preg47,preg48,preg49,preg50,preg51,preg52,preg53,preg54,preg55,preg56,preg57,preg58,preg59,preg60,preg61,preg62,preg63,preg64,preg143,preg144 FROM Preguntas_Saber_Sesion2 WHERE sesion='1' AND codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
            Dim LECTURA As New DataSet
            DB_lectura.Fill(LECTURA, "Preguntas_Saber_Sesion2")
            Dim columnas_lectura As Integer
            columnas_lectura = LECTURA.Tables(0).Columns.Count
            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ
            'FIN LECTURA

            ' INGLES
            ' CON EL CODIGO DEL ESTUDIANTE SACO TODAS LAS RESPUESTAS DE ESE ESTUDIANTE INGLES
            Dim DB_ingles As New OleDb.OleDbDataAdapter("SELECT preg70,preg71,preg72,preg73,preg74,preg75,preg76,preg77,preg78,preg79,preg80,preg81,preg82,preg83,preg84,preg85,preg86,preg87,preg88,preg89,preg90,preg91,preg92,preg93,preg94,preg95,preg96,preg97,preg98,preg99,preg100,preg101,preg102,preg103,preg104,preg105,preg106,preg107,preg108,preg109,preg110,preg111,preg112,preg113,preg114 FROM Preguntas_Saber_Sesion2 WHERE sesion='2' AND codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
            Dim INGLES As New DataSet
            DB_ingles.Fill(INGLES, "Preguntas_Saber_Sesion2")
            Dim columnas_ingles As Integer
            columnas_ingles = INGLES.Tables(0).Columns.Count
            'LA CANTIDAD DE COLUMNAS QUE TIENE LA TABLA PARA DARLE EL VALOR A LA MATRIZ


            'VARIABLES PARA GUARDAR LAS RESPUESTA DE CADA SESION POR MATERIA
            ReDim Respuestas_Materia_1_Sesion1_Matematicas(Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0) - 1)
            ReDim Respuestas_Materia_2_Sesion2_Lectura(Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1) - 1)

            'MATERIAS SEGUNDA SESION2
            ReDim Respuestas_Materia_3_Sesion2_Sociales(Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0) - 1)
            ReDim Respuestas_Materia_2_Sesion1_Naturales(Materia_Cantidad_Componentes_Competencias_Sesion2(1, 1) - 1)
            ReDim Respuestas_Materia_1_Sesion2_Ingles(Materia_Cantidad_Componentes_Competencias_Sesion2(1, 2) - 1)
            'ReDim Respuestas_Sesion1(columnas - 1)
            'ReDim Respuestas_Sesion2(columnas - 1)

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

            For j = 0 To 0
                For i = 0 To columnas_matematicas_abiertas - 1
                    NUMERO2.Text = MATEMATICAS_ABIERTAS.Tables(0).Rows(0).Item(i).ToString
                    Respuestas_Materia_1_Sesion1_Matematicas(i + columnas_matematicas + columnas_matematicas2) = NUMERO2.Text.ToString
                Next
            Next


            For j = 0 To 0
                For i = 0 To columnas_naturales - 1
                    NUMERO2.Text = NATURALES.Tables(0).Rows(0).Item(i).ToString
                    Respuestas_Materia_2_Sesion1_Naturales(i) = NUMERO2.Text.ToString
                Next
            Next

            For j = 0 To 0
                For i = 0 To columnas_naturales2 - 1
                    NUMERO2.Text = NATURALES2.Tables(0).Rows(0).Item(i).ToString
                    Respuestas_Materia_2_Sesion1_Naturales(i + columnas_naturales) = NUMERO2.Text.ToString
                Next
            Next


            For j = 0 To 0
                For i = 0 To columnas_ingles - 1
                    NUMERO2.Text = INGLES.Tables(0).Rows(0).Item(i).ToString
                    Respuestas_Materia_1_Sesion2_Ingles(i) = NUMERO2.Text.ToString
                Next
            Next

            For j = 0 To 0
                For i = 0 To columnas_lectura - 1
                    NUMERO2.Text = LECTURA.Tables(0).Rows(0).Item(i).ToString
                    Respuestas_Materia_2_Sesion2_Lectura(i) = NUMERO2.Text.ToString
                Next
            Next

            For j = 0 To 0
                For i = 0 To columnas_sociales - 1
                    NUMERO2.Text = SOCIALES.Tables(0).Rows(0).Item(i).ToString
                    Respuestas_Materia_3_Sesion2_Sociales(i) = NUMERO2.Text.ToString
                Next
            Next

            For j = 0 To 0
                For i = 0 To columnas_sociales2 - 1
                    NUMERO2.Text = SOCIALES2.Tables(0).Rows(0).Item(i).ToString
                    Respuestas_Materia_3_Sesion2_Sociales(i + columnas_sociales) = NUMERO2.Text.ToString
                Next
            Next

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            ' HASTA AQUI SE TIENE LAS RESPUESTAS DE CADA SESION DEL ESTUDIANTE EN LAS VARIABLES
            ' Respuestas_Materia_3_Sesion2_Sociales 

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  TENEMOS LAS RESPUESTAS DISEÑADAS EN EL FORMATO LISTAS PARA VERIFICARLAS %%%%%%%%%%%%%%%%%%%%%%%%%%

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% PRIMERA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5

            Dim CMATERIA_FORMATO1 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia,Pregunta_abierta,cuantitativo,ciudadanas FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND sesion='1' ORDER BY pregunta ASC", CN)
            Dim DATA_FORMATO1 As New DataSet
            CMATERIA_FORMATO1.Fill(DATA_FORMATO1, "Formato_Examen")
            Dim cantidad_preguntas_sesion1 As String
            cantidad_preguntas_sesion1 = DATA_FORMATO1.Tables(0).Rows.Count

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% SEGUNDA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5
            Dim CMATERIA_FORMATO2 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia,Pregunta_abierta,cuantitativo,ciudadanas FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND sesion='2' ORDER BY pregunta ASC", CN)
            Dim DATA_FORMATO2 As New DataSet
            CMATERIA_FORMATO2.Fill(DATA_FORMATO2, "Formato_Examen")
            Dim cantidad_preguntas_sesion2 As String
            cantidad_preguntas_sesion2 = DATA_FORMATO2.Tables(0).Rows.Count

            ' SESION COMPLETA TODAS LAS RESPUESTAS
            'Dim CMATERIA_FORMATO3 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND tipo_Materia=' '", CN)
            'Dim DATA_FORMATO3 As New DataSet
            'CMATERIA_FORMATO3.Fill(DATA_FORMATO3, "Formato_Examen")

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5

            'Dim CMATERIA_FLEXIBLE As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND sesion='2' AND tipo_Materia<>' '", CN)
            'Dim DATA_FLEXIBLE As New DataSet
            'CMATERIA_FLEXIBLE.Fill(DATA_FLEXIBLE, "Formato_Examen")
            'Dim cantidad_preguntas_flexibles As String
            'cantidad_preguntas_flexibles = DATA_FLEXIBLE.Tables(0).Rows.Count


            ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0) - 1 - 2, 7)
            ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(Materia_Cantidad_Componentes_Competencias_Sesion2(1, 1) - 1 - 2, 7)


            ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia1_Ingles(Materia_Cantidad_Componentes_Competencias_Sesion2(1, 2) - 1, 7)
            ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1) - 1 - 2, 7)
            ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0) - 1 - 2, 7)

            'ReDim Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1y2((CInt(cantidad_preguntas_sesion1) + CInt(cantidad_preguntas_sesion2)) - 1, 4)
            'ReDim Materia_Preguntas_Respuesta_Flexible(cantidad_preguntas_flexibles - 1, 2)

            For x = 0 To Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0) - 1 - 2   ' cantidad de materias de Matematicas
                For y = 0 To 7
                    Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(x, y) = DATA_FORMATO1.Tables(0).Rows(x).Item(y).ToString
                Next
            Next

            For x = 0 To Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1) - 1 - 2     'cantidad de materias de Lectura - 1
                For y = 0 To 7
                    Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(x, y) = DATA_FORMATO1.Tables(0).Rows(50 + x).Item(y).ToString
                Next
            Next

            ' SESION 2 '''
            For x = 0 To Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0) - 1 - 2    'cantidad de materias de Sociales - 1
                For y = 0 To 7
                    Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(x, y) = DATA_FORMATO2.Tables(0).Rows(x).Item(y).ToString
                Next
            Next

            For x = 0 To Materia_Cantidad_Componentes_Competencias_Sesion2(1, 1) - 1 - 2    'cantidad de materias de naturales - 1
                For y = 0 To 7
                    Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(x, y) = DATA_FORMATO2.Tables(0).Rows(46 + x).Item(y).ToString
                Next
            Next

            For x = 0 To Materia_Cantidad_Componentes_Competencias_Sesion2(1, 2) - 1     'cantidad de materias de Ingles - 1
                For y = 0 To 7
                    Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia1_Ingles(x, y) = DATA_FORMATO2.Tables(0).Rows(102 + x).Item(y).ToString
                Next
            Next

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% EMPEZAR A CALIFICAR EXAMENES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            'Respuestas_Sesion1
            'Respuestas_Sesion2
            'CUANTAS PREGUNTAS SON PARA SABER CUANTAS VECES HACERLO
            ' cantidad_materias_1 cantidad de materias de la primera sesion
            'For veces = 0 To (cantidad_materias_1 - 1)   ' cantidad de materias que tiene la sesion incica con 0 materia 1
            'Materia_Cantidad_Componentes_Competencias_Sesion1
            '(Cmateria1 - 1)= cantidad de preguntas de una materia

            ' ###########################   COMPONENTES Y COMPETENCIAS DE LA SESION 1 #################################
            ReDim Cantidad_Componentes_Materias_Sesion1_Matematicas(26, 0)
            ReDim Cantidad_Componentes_Materias_Sesion2_Lectura(26, 0)

            ReDim Cantidad_Componentes_Materias_Sesion2_Sociales(26, 0)
            ReDim Cantidad_Componentes_Materias_Sesion1_Naturales(26, 0)
            ReDim Cantidad_Componentes_Materias_Sesion2_Ingles(26, 0)
            'ReDim Materias_Asertividad((CInt(cantidad_preguntas_sesion1) + CInt(cantidad_preguntas_sesion2)), 10)

            Dim contador1 As Integer = 0
            Dim contador As Integer = 0
            Dim contador_competencia1 As Integer = 0
            Dim contador_competencia2 As Integer = 0
            Dim contador_competencia3 As Integer = 0
            Dim contador_componente1 As Integer = 0
            Dim contador_componente2 As Integer = 0
            Dim contador_componente3 As Integer = 0
            Dim contador_componente4 As Integer = 0
            Dim contador_cuantitativo As Integer = 0
            Dim contador_ciudadanas As Integer = 0
            Dim contador_correctas_cada_materia As Integer = 0


            contador = 0
            contador1 = 0
            contador_correctas_cada_materia = 0
            contador_componente1 = 0
            contador_componente2 = 0
            contador_componente3 = 0
            contador_componente4 = 0
            contador_competencia1 = 0
            contador_competencia2 = 0
            contador_competencia3 = 0
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            contador_cuantitativo = 0
            contador_ciudadanas = 0

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    AQUI EMPIEZA MATEMATICAS  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            For i = 0 To (Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0) - 1)

                If i = 50 Or i = 51 Then
                    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% PRIMERA ABIERTA AL VALOR TOTAL CUANTO LE SUMA) %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                    If Respuestas_Materia_1_Sesion1_Matematicas(i) = 1 Then
                        ' PREGUNTA CORRECTA SUMA 100 % 
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 1
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0)) * contador_correctas_cada_materia

                        'SABER SI SE LE SUMA A UN DETERMIDATO COMPONENTE O NO
                        If i = 50 Then
                            contador_componente2 = contador_componente2 + 1
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(1, 0) = contador_componente2
                        ElseIf i = 51 Then
                            contador_componente3 = contador_componente3 + 1
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(2, 0) = contador_componente3
                        End If

                    ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 2 Then
                        'SUMA 50% AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0.5
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0)) * contador_correctas_cada_materia

                        If i = 50 Then
                            contador_componente2 = contador_componente2 + 0.5
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(1, 0) = contador_componente2
                        ElseIf i = 51 Then
                            contador_componente3 = contador_componente3 + 0.5
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(2, 0) = contador_componente3
                        End If

                    ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 3 Then
                        'SUMA 25% AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0.25
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0)) * contador_correctas_cada_materia

                        If i = 50 Then
                            contador_componente2 = contador_componente2 + 0.25
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(1, 0) = contador_componente2
                        ElseIf i = 51 Then
                            contador_componente3 = contador_componente3 + 0.25
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(2, 0) = contador_componente3
                        End If

                    ElseIf Respuestas_Materia_1_Sesion1_Matematicas(i) = 4 Then
                        'SUMA CERO AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0)) * contador_correctas_cada_materia

                        If i = 50 Then
                            contador_componente2 = contador_componente2 + 0
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(1, 0) = contador_componente2
                        ElseIf i = 51 Then
                            contador_componente3 = contador_componente3 + 0
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(2, 0) = contador_componente3
                        End If

                    End If

                Else
                    ' RESPUESTAS NORMALES NO ABIERTAS LAS 50 DE MATEMATICAS

                    If Respuestas_Materia_1_Sesion1_Matematicas(i) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 2) Then
                        'SACAR EL RAZONAMIENTO CUANTITATIVO SABER SI LE SUMA 
                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 6) = Nothing Then
                            contador_cuantitativo = contador_cuantitativo
                        Else
                            If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 6) = 1 Then
                                contador_cuantitativo = contador_cuantitativo + 1
                                Cantidad_Componentes_Materias_Sesion1_Matematicas(24, 0) = contador_cuantitativo
                            End If
                        End If
                        'SABER SI SE LE SUMA A UN DETERMIDATO COMPONENTE O NO
                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3) = 1 Then
                            contador_componente1 = contador_componente1 + 1
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(0, 0) = contador_componente1
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3) = 2 Then
                            contador_componente2 = contador_componente2 + 1
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(1, 0) = contador_componente2
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3) = 3 Then
                            contador_componente3 = contador_componente3 + 1
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(2, 0) = contador_componente3
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 3) = 4 Then
                            contador_componente4 = contador_componente4 + 1
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(3, 0) = contador_componente4
                        End If
                        ' SABER SI SE LE SUMA A UNA DETERMINADA COMPETENCIA O NO
                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4) = 1 Then
                            contador_competencia1 = contador_competencia1 + 1
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(4, 0) = contador_competencia1
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4) = 2 Then
                            contador_competencia2 = contador_competencia2 + 1
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(5, 0) = contador_competencia2
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia1_Matematicas(i, 4) = 3 Then
                            contador_competencia3 = contador_competencia3 + 1
                            Cantidad_Componentes_Materias_Sesion1_Matematicas(6, 0) = contador_competencia3
                        End If

                        'CONTAR CUANTAS PREGUNTAS FUERON ACERTADAS DE CADA MATERIA
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 1
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0)) * contador_correctas_cada_materia
                    Else
                        'PREGUNTAS FUERON INCORRECTAS DE CADA MATERIA
                        contador_correctas_cada_materia = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Matematicas(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0)) * contador_correctas_cada_materia
                    End If
                End If 'If cierra la ultima pregunta, la pregunta abierta para saber cuanto le suma al general, a la competencia o al componente, o al cuantitativo

                ' SESION 1
                'RAZONAMIENTO (CUANTITATIVO)
                'contador_cuantitativo
                If Cantidad_Componentes_Materias_Sesion1_Matematicas(24, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(25, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(25, 0) = 100 / (Materia_Cantidad_Componentes_Competencias_Sesion1(9, 0))
                End If
                'COMPONENTE 1
                If Cantidad_Componentes_Materias_Sesion1_Matematicas(0, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(9, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(9, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(2, 0))
                End If
                'COMPONENTE 2
                If Cantidad_Componentes_Materias_Sesion1_Matematicas(1, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(10, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(10, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(3, 0))
                End If
                'COMPONENTE 3
                If Cantidad_Componentes_Materias_Sesion1_Matematicas(2, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(11, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(11, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(4, 0))
                End If
                'COMPONENTE 4
                If Cantidad_Componentes_Materias_Sesion1_Matematicas(3, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(12, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(12, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(5, 0))
                End If
                'COMPETENCIA 1
                If Cantidad_Componentes_Materias_Sesion1_Matematicas(4, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(13, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(13, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(6, 0))
                End If
                'COMPETENCIA 2
                If Cantidad_Componentes_Materias_Sesion1_Matematicas(5, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(14, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(14, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(7, 0))
                End If
                'COMPETENCIA 3
                If Cantidad_Componentes_Materias_Sesion1_Matematicas(6, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(15, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Matematicas(15, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(8, 0))
                End If

                Cantidad_Componentes_Materias_Sesion1_Matematicas(25, 0) = Cantidad_Componentes_Materias_Sesion1_Matematicas(25, 0) * Cantidad_Componentes_Materias_Sesion1_Matematicas(24, 0)
                Cantidad_Componentes_Materias_Sesion1_Matematicas(16, 0) = Cantidad_Componentes_Materias_Sesion1_Matematicas(9, 0) * Cantidad_Componentes_Materias_Sesion1_Matematicas(0, 0)
                Cantidad_Componentes_Materias_Sesion1_Matematicas(17, 0) = Cantidad_Componentes_Materias_Sesion1_Matematicas(10, 0) * Cantidad_Componentes_Materias_Sesion1_Matematicas(1, 0)
                Cantidad_Componentes_Materias_Sesion1_Matematicas(18, 0) = Cantidad_Componentes_Materias_Sesion1_Matematicas(11, 0) * Cantidad_Componentes_Materias_Sesion1_Matematicas(2, 0)
                Cantidad_Componentes_Materias_Sesion1_Matematicas(19, 0) = Cantidad_Componentes_Materias_Sesion1_Matematicas(12, 0) * Cantidad_Componentes_Materias_Sesion1_Matematicas(3, 0)
                Cantidad_Componentes_Materias_Sesion1_Matematicas(20, 0) = Cantidad_Componentes_Materias_Sesion1_Matematicas(13, 0) * Cantidad_Componentes_Materias_Sesion1_Matematicas(4, 0)
                Cantidad_Componentes_Materias_Sesion1_Matematicas(21, 0) = Cantidad_Componentes_Materias_Sesion1_Matematicas(14, 0) * Cantidad_Componentes_Materias_Sesion1_Matematicas(5, 0)
                Cantidad_Componentes_Materias_Sesion1_Matematicas(22, 0) = Cantidad_Componentes_Materias_Sesion1_Matematicas(15, 0) * Cantidad_Componentes_Materias_Sesion1_Matematicas(6, 0)
                Cantidad_Componentes_Materias_Sesion1_Matematicas(23, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 0)
            Next

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% AQUI TERMINA MATEMATICAS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  AQUI EMPIEZA NATURALES  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            contador_correctas_cada_materia = 0
            contador_componente1 = 0
            contador_componente2 = 0
            contador_componente3 = 0
            contador_componente4 = 0
            contador_competencia1 = 0
            contador_competencia2 = 0
            contador_competencia3 = 0

            For i = 0 To (Materia_Cantidad_Componentes_Competencias_Sesion2(1, 1) - 1)
                If i = 56 Or i = 57 Then
                    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% PREGUNTA ABIERTA AL VALOR TOTAL CUANTO LE SUMA (competencia, componente cuantitativo)%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                    If Respuestas_Materia_2_Sesion1_Naturales(i) = 1 Then
                        ' PREGUNTA CORRECTA SUMA 100 % 
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 1
                        Cantidad_Componentes_Materias_Sesion1_Naturales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Naturales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 1)) * contador_correctas_cada_materia

                        If i = 56 Then
                            contador_componente2 = contador_componente2 + 1
                            Cantidad_Componentes_Materias_Sesion1_Naturales(1, 0) = contador_componente2
                        ElseIf i = 57 Then
                            contador_componente3 = contador_componente3 + 1
                            Cantidad_Componentes_Materias_Sesion1_Naturales(2, 0) = contador_componente3
                        End If

                    ElseIf Respuestas_Materia_2_Sesion1_Naturales(i) = 2 Then
                        'SUMA 50% AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0.5
                        Cantidad_Componentes_Materias_Sesion1_Naturales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Naturales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 1)) * contador_correctas_cada_materia

                        If i = 56 Then
                            contador_componente2 = contador_componente2 + 0.5
                            Cantidad_Componentes_Materias_Sesion1_Naturales(1, 0) = contador_componente2
                        ElseIf i = 57 Then
                            contador_componente3 = contador_componente3 + 0.5
                            Cantidad_Componentes_Materias_Sesion1_Naturales(2, 0) = contador_componente3
                        End If

                    ElseIf Respuestas_Materia_2_Sesion1_Naturales(i) = 3 Then
                        'SUMA 25% AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0.25
                        Cantidad_Componentes_Materias_Sesion1_Naturales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Naturales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 1)) * contador_correctas_cada_materia

                        If i = 56 Then
                            contador_componente2 = contador_componente2 + 0.25
                            Cantidad_Componentes_Materias_Sesion1_Naturales(1, 0) = contador_componente2
                        ElseIf i = 57 Then
                            contador_componente3 = contador_componente3 + 0.25
                            Cantidad_Componentes_Materias_Sesion1_Naturales(2, 0) = contador_componente3
                        End If

                    ElseIf Respuestas_Materia_2_Sesion1_Naturales(i) = 4 Then
                        'SUMA CERO AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0
                        Cantidad_Componentes_Materias_Sesion1_Naturales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Naturales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 1)) * contador_correctas_cada_materia

                        If i = 56 Then
                            contador_componente2 = contador_componente2 + 0
                            Cantidad_Componentes_Materias_Sesion1_Naturales(1, 0) = contador_componente2
                        ElseIf i = 57 Then
                            contador_componente3 = contador_componente3 + 0
                            Cantidad_Componentes_Materias_Sesion1_Naturales(2, 0) = contador_componente3
                        End If
                    End If
                Else

                    If Respuestas_Materia_2_Sesion1_Naturales(i) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(i, 2) Then
                        'SACAR EL RAZONAMIENTO CUANTITATIVO SABER SI LE SUMA 
                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(i, 6) = Nothing Then
                            contador_cuantitativo = contador_cuantitativo
                        Else
                            If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(i, 6) = 1 Then
                                contador_cuantitativo = contador_cuantitativo + 1
                                Cantidad_Componentes_Materias_Sesion1_Naturales(24, 0) = contador_cuantitativo
                            End If
                        End If
                        'SABER SI SE LE SUMA A UN DETERMIDATO COMPONENTE O NO
                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(i, 3) = 1 Then
                            contador_componente1 = contador_componente1 + 1
                            Cantidad_Componentes_Materias_Sesion1_Naturales(0, 0) = contador_componente1
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(i, 3) = 2 Then
                            contador_componente2 = contador_componente2 + 1
                            Cantidad_Componentes_Materias_Sesion1_Naturales(1, 0) = contador_componente2
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(i, 3) = 3 Then
                            contador_componente3 = contador_componente3 + 1
                            Cantidad_Componentes_Materias_Sesion1_Naturales(2, 0) = contador_componente3
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(i, 3) = 4 Then
                            contador_componente4 = contador_componente4 + 1
                            Cantidad_Componentes_Materias_Sesion1_Naturales(3, 0) = contador_componente4
                        End If
                        ' SABER SI SE LE SUMA A UNA DETERMINADA COMPETENCIA O NO
                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(i, 4) = 1 Then
                            contador_competencia1 = contador_competencia1 + 1
                            Cantidad_Componentes_Materias_Sesion1_Naturales(4, 0) = contador_competencia1
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(i, 4) = 2 Then
                            contador_competencia2 = contador_competencia2 + 1
                            Cantidad_Componentes_Materias_Sesion1_Naturales(5, 0) = contador_competencia2
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1_Materia2_Naturales(i, 4) = 3 Then
                            contador_competencia3 = contador_competencia3 + 1
                            Cantidad_Componentes_Materias_Sesion1_Naturales(6, 0) = contador_competencia3
                        End If

                        'CONTAR CUANTAS PREGUNTAS FUERON ACERTADAS DE CADA MATERIA
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 1
                        Cantidad_Componentes_Materias_Sesion1_Naturales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Naturales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 1)) * contador_correctas_cada_materia
                    Else
                        'PREGUNTAS FUERON INCORRECTAS DE CADA MATERIA
                        contador_correctas_cada_materia = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Naturales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion1_Naturales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 1)) * contador_correctas_cada_materia
                    End If
                End If 'If cierra la ultima pregunta, la pregunta abierta para saber cuanto le suma al general, a la competencia o al componente, o al cuantitativo
                ' SESION 1
                'RAZONAMIENTO (CUANTITATIVO)
                'contador_cuantitativo
                If Cantidad_Componentes_Materias_Sesion1_Naturales(24, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Naturales(25, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Naturales(25, 0) = 100 / (Materia_Cantidad_Componentes_Competencias_Sesion2(9, 1))
                End If
                'COMPONENTE 1
                If Cantidad_Componentes_Materias_Sesion1_Naturales(0, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Naturales(9, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Naturales(9, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(2, 1))
                End If
                'COMPONENTE 2
                If Cantidad_Componentes_Materias_Sesion1_Naturales(1, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Naturales(10, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Naturales(10, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(3, 1))
                End If
                'COMPONENTE 3
                If Cantidad_Componentes_Materias_Sesion1_Naturales(2, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Naturales(11, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Naturales(11, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(4, 1))
                End If
                'COMPONENTE 4
                If Cantidad_Componentes_Materias_Sesion1_Naturales(3, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Naturales(12, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Naturales(12, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(5, 1))
                End If
                'COMPETENCIA 1
                If Cantidad_Componentes_Materias_Sesion1_Naturales(4, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Naturales(13, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Naturales(13, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(6, 1))
                End If
                'COMPETENCIA 2
                If Cantidad_Componentes_Materias_Sesion1_Naturales(5, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Naturales(14, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Naturales(14, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(7, 1))
                End If
                'COMPETENCIA 3
                If Cantidad_Componentes_Materias_Sesion1_Naturales(6, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion1_Naturales(15, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion1_Naturales(15, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(8, 1))
                End If

                Cantidad_Componentes_Materias_Sesion1_Naturales(25, 0) = Cantidad_Componentes_Materias_Sesion1_Naturales(25, 0) * Cantidad_Componentes_Materias_Sesion1_Naturales(24, 0)
                Cantidad_Componentes_Materias_Sesion1_Naturales(16, 0) = Cantidad_Componentes_Materias_Sesion1_Naturales(9, 0) * Cantidad_Componentes_Materias_Sesion1_Naturales(0, 0)
                Cantidad_Componentes_Materias_Sesion1_Naturales(17, 0) = Cantidad_Componentes_Materias_Sesion1_Naturales(10, 0) * Cantidad_Componentes_Materias_Sesion1_Naturales(1, 0)
                Cantidad_Componentes_Materias_Sesion1_Naturales(18, 0) = Cantidad_Componentes_Materias_Sesion1_Naturales(11, 0) * Cantidad_Componentes_Materias_Sesion1_Naturales(2, 0)
                Cantidad_Componentes_Materias_Sesion1_Naturales(19, 0) = Cantidad_Componentes_Materias_Sesion1_Naturales(12, 0) * Cantidad_Componentes_Materias_Sesion1_Naturales(3, 0)
                Cantidad_Componentes_Materias_Sesion1_Naturales(20, 0) = Cantidad_Componentes_Materias_Sesion1_Naturales(13, 0) * Cantidad_Componentes_Materias_Sesion1_Naturales(4, 0)
                Cantidad_Componentes_Materias_Sesion1_Naturales(21, 0) = Cantidad_Componentes_Materias_Sesion1_Naturales(14, 0) * Cantidad_Componentes_Materias_Sesion1_Naturales(5, 0)
                Cantidad_Componentes_Materias_Sesion1_Naturales(22, 0) = Cantidad_Componentes_Materias_Sesion1_Naturales(15, 0) * Cantidad_Componentes_Materias_Sesion1_Naturales(6, 0)
                Cantidad_Componentes_Materias_Sesion1_Naturales(23, 0) = Materia_Cantidad_Componentes_Competencias_Sesion2(0, 1)
            Next
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  AQUI TERMINA NATURALES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  AQUI INICIA LA SEGUNDA SESION   %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  AQUI EMPIEZA INGLES     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            contador_correctas_cada_materia = 0
            contador_componente1 = 0
            contador_componente2 = 0
            contador_componente3 = 0
            contador_componente4 = 0
            contador_competencia1 = 0
            contador_competencia2 = 0
            contador_competencia3 = 0

            For i = 0 To (Materia_Cantidad_Componentes_Competencias_Sesion2(1, 2) - 1)

                If Respuestas_Materia_1_Sesion2_Ingles(i) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia1_Ingles(i, 2) Then
                    'CONTAR CUANTAS PREGUNTAS FUERON ACERTADAS DE CADA MATERIA
                    contador_correctas_cada_materia = contador_correctas_cada_materia + 1
                    Cantidad_Componentes_Materias_Sesion2_Ingles(7, 0) = contador_correctas_cada_materia
                    Cantidad_Componentes_Materias_Sesion2_Ingles(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 2)) * contador_correctas_cada_materia
                Else
                    'PREGUNTAS FUERON INCORRECTAS DE CADA MATERIA
                    contador_correctas_cada_materia = contador_correctas_cada_materia
                    Cantidad_Componentes_Materias_Sesion2_Ingles(7, 0) = contador_correctas_cada_materia
                    Cantidad_Componentes_Materias_Sesion2_Ingles(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 2)) * contador_correctas_cada_materia
                End If

                Cantidad_Componentes_Materias_Sesion2_Ingles(25, 0) = Cantidad_Componentes_Materias_Sesion2_Ingles(25, 0) * Cantidad_Componentes_Materias_Sesion2_Ingles(24, 0)
                Cantidad_Componentes_Materias_Sesion2_Ingles(16, 0) = Cantidad_Componentes_Materias_Sesion2_Ingles(9, 0) * Cantidad_Componentes_Materias_Sesion2_Ingles(0, 0)
                Cantidad_Componentes_Materias_Sesion2_Ingles(17, 0) = Cantidad_Componentes_Materias_Sesion2_Ingles(10, 0) * Cantidad_Componentes_Materias_Sesion2_Ingles(1, 0)
                Cantidad_Componentes_Materias_Sesion2_Ingles(18, 0) = Cantidad_Componentes_Materias_Sesion2_Ingles(11, 0) * Cantidad_Componentes_Materias_Sesion2_Ingles(2, 0)
                Cantidad_Componentes_Materias_Sesion2_Ingles(19, 0) = Cantidad_Componentes_Materias_Sesion2_Ingles(12, 0) * Cantidad_Componentes_Materias_Sesion2_Ingles(3, 0)
                Cantidad_Componentes_Materias_Sesion2_Ingles(20, 0) = Cantidad_Componentes_Materias_Sesion2_Ingles(13, 0) * Cantidad_Componentes_Materias_Sesion2_Ingles(4, 0)
                Cantidad_Componentes_Materias_Sesion2_Ingles(21, 0) = Cantidad_Componentes_Materias_Sesion2_Ingles(14, 0) * Cantidad_Componentes_Materias_Sesion2_Ingles(5, 0)
                Cantidad_Componentes_Materias_Sesion2_Ingles(22, 0) = Cantidad_Componentes_Materias_Sesion2_Ingles(15, 0) * Cantidad_Componentes_Materias_Sesion2_Ingles(6, 0)
                Cantidad_Componentes_Materias_Sesion2_Ingles(23, 0) = Materia_Cantidad_Componentes_Competencias_Sesion2(0, 2)
            Next

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  AQUI TERMINA INGLES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  AQUI EMPIEZA LECTURA CRÍTICA     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            contador_correctas_cada_materia = 0
            contador_componente1 = 0
            contador_componente2 = 0
            contador_componente3 = 0
            contador_componente4 = 0
            contador_competencia1 = 0
            contador_competencia2 = 0
            contador_competencia3 = 0

            For i = 0 To (Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1) - 1)

                If i = 38 Or i = 39 Then
                    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% PREGUNTA ABIERTA AL VALOR TOTAL CUANTO LE SUMA (competencia, componente cuantitativo)%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                    If Respuestas_Materia_2_Sesion2_Lectura(i) = 1 Then
                        ' PREGUNTA CORRECTA SUMA 100 % 
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 1
                        Cantidad_Componentes_Materias_Sesion2_Lectura(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Lectura(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1)) * contador_correctas_cada_materia

                        If i = 38 Then
                            contador_componente1 = contador_componente1 + 1
                            Cantidad_Componentes_Materias_Sesion2_Lectura(0, 0) = contador_componente1
                        ElseIf i = 39 Then
                            contador_componente2 = contador_componente2 + 1
                            Cantidad_Componentes_Materias_Sesion2_Lectura(1, 0) = contador_componente2
                        End If

                    ElseIf Respuestas_Materia_2_Sesion2_Lectura(i) = 2 Then
                        'SUMA 50% AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0.5
                        Cantidad_Componentes_Materias_Sesion2_Lectura(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Lectura(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1)) * contador_correctas_cada_materia

                        If i = 38 Then
                            contador_componente1 = contador_componente1 + 0.5
                            Cantidad_Componentes_Materias_Sesion2_Lectura(0, 0) = contador_componente1
                        ElseIf i = 39 Then
                            contador_componente2 = contador_componente2 + 0.5
                            Cantidad_Componentes_Materias_Sesion2_Lectura(1, 0) = contador_componente2
                        End If

                    ElseIf Respuestas_Materia_2_Sesion2_Lectura(i) = 3 Then
                        'SUMA 25% AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0.25
                        Cantidad_Componentes_Materias_Sesion2_Lectura(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Lectura(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1)) * contador_correctas_cada_materia

                        If i = 38 Then
                            contador_componente1 = contador_componente1 + 0.25
                            Cantidad_Componentes_Materias_Sesion2_Lectura(0, 0) = contador_componente1
                        ElseIf i = 39 Then
                            contador_componente2 = contador_componente2 + 0.25
                            Cantidad_Componentes_Materias_Sesion2_Lectura(1, 0) = contador_componente2
                        End If

                    ElseIf Respuestas_Materia_2_Sesion2_Lectura(i) = 4 Then
                        'SUMA CERO AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0
                        Cantidad_Componentes_Materias_Sesion2_Lectura(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Lectura(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1)) * contador_correctas_cada_materia

                        If i = 38 Then
                            contador_componente1 = contador_componente1 + 0
                            Cantidad_Componentes_Materias_Sesion2_Lectura(0, 0) = contador_componente1
                        ElseIf i = 39 Then
                            contador_componente2 = contador_componente2 + 0
                            Cantidad_Componentes_Materias_Sesion2_Lectura(1, 0) = contador_componente2
                        End If
                    End If

                Else

                    If Respuestas_Materia_2_Sesion2_Lectura(i) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(i, 2) Then

                        'SABER SI SE LE SUMA A UN DETERMIDATO COMPONENTE O NO
                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(i, 3) = Nothing Then

                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(i, 3) = 1 Then
                            contador_componente1 = contador_componente1 + 1
                            Cantidad_Componentes_Materias_Sesion2_Lectura(0, 0) = contador_componente1
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(i, 3) = 2 Then
                            contador_componente2 = contador_componente2 + 1
                            Cantidad_Componentes_Materias_Sesion2_Lectura(1, 0) = contador_componente2
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(i, 3) = 3 Then
                            contador_componente3 = contador_componente3 + 1
                            Cantidad_Componentes_Materias_Sesion2_Lectura(2, 0) = contador_componente3
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(i, 3) = 4 Then
                            contador_componente4 = contador_componente4 + 1
                            Cantidad_Componentes_Materias_Sesion2_Lectura(3, 0) = contador_componente4
                        End If
                        ' SABER SI SE LE SUMA A UNA DETERMINADA COMPETENCIA O NO
                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(i, 4) = Nothing Then

                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(i, 4) = 1 Then
                            contador_competencia1 = contador_competencia1 + 1
                            Cantidad_Componentes_Materias_Sesion2_Lectura(4, 0) = contador_competencia1
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(i, 4) = 2 Then
                            contador_competencia2 = contador_competencia2 + 1
                            Cantidad_Componentes_Materias_Sesion2_Lectura(5, 0) = contador_competencia2
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia2_Lectura(i, 4) = 3 Then
                            contador_competencia3 = contador_competencia3 + 1
                            Cantidad_Componentes_Materias_Sesion2_Lectura(6, 0) = contador_competencia3
                        End If

                        'CONTAR CUANTAS PREGUNTAS FUERON ACERTADAS DE CADA MATERIA
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 1
                        Cantidad_Componentes_Materias_Sesion2_Lectura(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Lectura(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1)) * contador_correctas_cada_materia
                    Else
                        'PREGUNTAS FUERON INCORRECTAS DE CADA MATERIA
                        contador_correctas_cada_materia = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Lectura(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Lectura(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion1(1, 1)) * contador_correctas_cada_materia
                    End If
                End If 'If cierra la ultima pregunta, la pregunta abierta para saber cuanto le suma al general, a la competencia o al componente

                ' SESION 1
                'RAZONAMIENTO (CUANTITATIVO)
                'contador_cuantitativo
                If Cantidad_Componentes_Materias_Sesion2_Lectura(24, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Lectura(25, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Lectura(25, 0) = 100 / (Materia_Cantidad_Componentes_Competencias_Sesion1(9, 1))
                End If
                'COMPONENTE 1
                If Cantidad_Componentes_Materias_Sesion2_Lectura(0, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Lectura(9, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Lectura(9, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(2, 1))
                End If
                'COMPONENTE 2
                If Cantidad_Componentes_Materias_Sesion2_Lectura(1, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Lectura(10, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Lectura(10, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(3, 1))
                End If
                'COMPONENTE 3
                If Cantidad_Componentes_Materias_Sesion2_Lectura(2, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Lectura(11, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Lectura(11, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(4, 1))
                End If
                'COMPONENTE 4
                If Cantidad_Componentes_Materias_Sesion2_Lectura(3, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Lectura(12, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Lectura(12, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(5, 1))
                End If
                'COMPETENCIA 1
                If Cantidad_Componentes_Materias_Sesion2_Lectura(4, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Lectura(13, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Lectura(13, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(6, 1))
                End If
                'COMPETENCIA 2
                If Cantidad_Componentes_Materias_Sesion2_Lectura(5, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Lectura(14, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Lectura(14, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(7, 1))
                End If
                'COMPETENCIA 3
                If Cantidad_Componentes_Materias_Sesion2_Lectura(6, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Lectura(15, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Lectura(15, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion1(8, 1))
                End If

                Cantidad_Componentes_Materias_Sesion2_Lectura(25, 0) = Cantidad_Componentes_Materias_Sesion2_Lectura(25, 0) * Cantidad_Componentes_Materias_Sesion2_Lectura(24, 0)
                Cantidad_Componentes_Materias_Sesion2_Lectura(16, 0) = Cantidad_Componentes_Materias_Sesion2_Lectura(9, 0) * Cantidad_Componentes_Materias_Sesion2_Lectura(0, 0)
                Cantidad_Componentes_Materias_Sesion2_Lectura(17, 0) = Cantidad_Componentes_Materias_Sesion2_Lectura(10, 0) * Cantidad_Componentes_Materias_Sesion2_Lectura(1, 0)
                Cantidad_Componentes_Materias_Sesion2_Lectura(18, 0) = Cantidad_Componentes_Materias_Sesion2_Lectura(11, 0) * Cantidad_Componentes_Materias_Sesion2_Lectura(2, 0)
                Cantidad_Componentes_Materias_Sesion2_Lectura(19, 0) = Cantidad_Componentes_Materias_Sesion2_Lectura(12, 0) * Cantidad_Componentes_Materias_Sesion2_Lectura(3, 0)
                Cantidad_Componentes_Materias_Sesion2_Lectura(20, 0) = Cantidad_Componentes_Materias_Sesion2_Lectura(13, 0) * Cantidad_Componentes_Materias_Sesion2_Lectura(4, 0)
                Cantidad_Componentes_Materias_Sesion2_Lectura(21, 0) = Cantidad_Componentes_Materias_Sesion2_Lectura(14, 0) * Cantidad_Componentes_Materias_Sesion2_Lectura(5, 0)
                Cantidad_Componentes_Materias_Sesion2_Lectura(22, 0) = Cantidad_Componentes_Materias_Sesion2_Lectura(15, 0) * Cantidad_Componentes_Materias_Sesion2_Lectura(6, 0)
                Cantidad_Componentes_Materias_Sesion2_Lectura(23, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, 1)
            Next


            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  AQUI TERMINA LECTURA CRÍTICA %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  AQUI EMPIEZA SOCIALES    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            contador_correctas_cada_materia = 0
            contador_componente1 = 0
            contador_componente2 = 0
            contador_componente3 = 0
            contador_componente4 = 0
            contador_competencia1 = 0
            contador_competencia2 = 0
            contador_competencia3 = 0

            contador_ciudadanas = 0


            For i = 0 To (Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0) - 1)
                If i = 46 Or i = 47 Then
                    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% PREGUNTA ABIERTA AL VALOR TOTAL CUANTO LE SUMA (competencia, componente cuantitativo)%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                    If Respuestas_Materia_3_Sesion2_Sociales(i) = 1 Then
                        ' PREGUNTA CORRECTA SUMA 100 % 
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 1
                        Cantidad_Componentes_Materias_Sesion2_Sociales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Sociales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0)) * contador_correctas_cada_materia

                        If i = 46 Then
                            contador_ciudadanas = contador_ciudadanas + 1
                            Cantidad_Componentes_Materias_Sesion2_Sociales(24, 0) = contador_ciudadanas
                        ElseIf i = 47 Then
                            contador_componente1 = contador_componente1 + 1
                            Cantidad_Componentes_Materias_Sesion2_Sociales(0, 0) = contador_componente1
                        End If

                    ElseIf Respuestas_Materia_3_Sesion2_Sociales(i) = 2 Then
                        'SUMA 50% AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0.5
                        Cantidad_Componentes_Materias_Sesion2_Sociales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Sociales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0)) * contador_correctas_cada_materia

                        If i = 46 Then
                            contador_ciudadanas = contador_ciudadanas + 0.5
                            Cantidad_Componentes_Materias_Sesion2_Sociales(24, 0) = contador_ciudadanas
                        ElseIf i = 47 Then
                            contador_componente1 = contador_componente1 + 0.5
                            Cantidad_Componentes_Materias_Sesion2_Sociales(0, 0) = contador_componente1
                        End If

                    ElseIf Respuestas_Materia_3_Sesion2_Sociales(i) = 3 Then
                        'SUMA 25% AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0.25
                        Cantidad_Componentes_Materias_Sesion2_Sociales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Sociales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0)) * contador_correctas_cada_materia

                        If i = 46 Then
                            contador_ciudadanas = contador_ciudadanas + 0.25
                            Cantidad_Componentes_Materias_Sesion2_Sociales(24, 0) = contador_ciudadanas
                        ElseIf i = 47 Then
                            contador_componente1 = contador_componente1 + 0.25
                            Cantidad_Componentes_Materias_Sesion2_Sociales(0, 0) = contador_componente1
                        End If

                    ElseIf Respuestas_Materia_3_Sesion2_Sociales(i) = 4 Then
                        'SUMA CERO AL ACUMULADO DE LAS RESPUESTAS CORRECTAS
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 0
                        Cantidad_Componentes_Materias_Sesion2_Sociales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Sociales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0)) * contador_correctas_cada_materia

                        If i = 46 Then
                            contador_ciudadanas = contador_ciudadanas + 0
                            Cantidad_Componentes_Materias_Sesion2_Sociales(24, 0) = contador_ciudadanas
                        ElseIf i = 47 Then
                            contador_componente1 = contador_componente1 + 0
                            Cantidad_Componentes_Materias_Sesion2_Sociales(0, 0) = contador_componente1
                        End If

                    End If

                Else
                    If Respuestas_Materia_3_Sesion2_Sociales(i) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 2) Then
                        'SACAR EL RAZONAMIENTO CUANTITATIVO SABER SI LE SUMA 
                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 7) = Nothing Then
                            contador_ciudadanas = contador_ciudadanas
                        Else
                            If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 7) = 1 Then
                                contador_ciudadanas = contador_ciudadanas + 1
                                Cantidad_Componentes_Materias_Sesion2_Sociales(24, 0) = contador_ciudadanas
                            End If
                        End If
                        'SABER SI SE LE SUMA A UN DETERMIDATO COMPONENTE O NO

                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 3) = Nothing Then

                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 3) = 1 Then
                            contador_componente1 = contador_componente1 + 1
                            Cantidad_Componentes_Materias_Sesion2_Sociales(0, 0) = contador_componente1
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 3) = 2 Then
                            contador_componente2 = contador_componente2 + 1
                            Cantidad_Componentes_Materias_Sesion2_Sociales(1, 0) = contador_componente2
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 3) = 3 Then
                            contador_componente3 = contador_componente3 + 1
                            Cantidad_Componentes_Materias_Sesion2_Sociales(2, 0) = contador_componente3
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 3) = 4 Then
                            contador_componente4 = contador_componente4 + 1
                            Cantidad_Componentes_Materias_Sesion2_Sociales(3, 0) = contador_componente4
                        End If
                        ' SABER SI SE LE SUMA A UNA DETERMINADA COMPETENCIA O NO
                        If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 4) = Nothing Then
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 4) = 1 Then
                            contador_competencia1 = contador_competencia1 + 1
                            Cantidad_Componentes_Materias_Sesion2_Sociales(4, 0) = contador_competencia1
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 4) = 2 Then
                            contador_competencia2 = contador_competencia2 + 1
                            Cantidad_Componentes_Materias_Sesion2_Sociales(5, 0) = contador_competencia2
                        ElseIf Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2_Materia3_Sociales(i, 4) = 3 Then
                            contador_competencia3 = contador_competencia3 + 1
                            Cantidad_Componentes_Materias_Sesion2_Sociales(6, 0) = contador_competencia3
                        End If

                        'CONTAR CUANTAS PREGUNTAS FUERON ACERTADAS DE CADA MATERIA
                        contador_correctas_cada_materia = contador_correctas_cada_materia + 1
                        Cantidad_Componentes_Materias_Sesion2_Sociales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Sociales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0)) * contador_correctas_cada_materia
                    Else
                        'PREGUNTAS FUERON INCORRECTAS DE CADA MATERIA
                        contador_correctas_cada_materia = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Sociales(7, 0) = contador_correctas_cada_materia
                        Cantidad_Componentes_Materias_Sesion2_Sociales(8, 0) = (100 / Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0)) * contador_correctas_cada_materia
                    End If
                End If 'If cierra la ultima pregunta, la pregunta abierta para saber cuanto le suma al general, a la competencia o al componente, o al cuantitativo
                ' SESION 1
                'RAZONAMIENTO (CUANTITATIVO)
                'contador_cuantitativo
                If Cantidad_Componentes_Materias_Sesion2_Sociales(24, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Sociales(25, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Sociales(25, 0) = 100 / (Materia_Cantidad_Componentes_Competencias_Sesion2(10, 0))
                End If
                'COMPONENTE 1
                If Cantidad_Componentes_Materias_Sesion2_Sociales(0, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Sociales(9, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Sociales(9, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(2, 0))
                End If
                'COMPONENTE 2
                If Cantidad_Componentes_Materias_Sesion2_Sociales(1, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Sociales(10, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Sociales(10, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(3, 0))
                End If
                'COMPONENTE 3
                If Cantidad_Componentes_Materias_Sesion2_Sociales(2, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Sociales(11, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Sociales(11, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(4, 0))
                End If
                'COMPONENTE 4
                If Cantidad_Componentes_Materias_Sesion2_Sociales(3, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Sociales(12, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Sociales(12, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(5, 0))
                End If
                'COMPETENCIA 1
                If Cantidad_Componentes_Materias_Sesion2_Sociales(4, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Sociales(13, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Sociales(13, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(6, 0))
                End If
                'COMPETENCIA 2
                If Cantidad_Componentes_Materias_Sesion2_Sociales(5, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Sociales(14, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Sociales(14, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(7, 0))
                End If
                'COMPETENCIA 3
                If Cantidad_Componentes_Materias_Sesion2_Sociales(6, 0) = Nothing Then
                    Cantidad_Componentes_Materias_Sesion2_Sociales(15, 0) = 0
                Else
                    Cantidad_Componentes_Materias_Sesion2_Sociales(15, 0) = 10 / (Materia_Cantidad_Componentes_Competencias_Sesion2(8, 0))
                End If

                Cantidad_Componentes_Materias_Sesion2_Sociales(25, 0) = Cantidad_Componentes_Materias_Sesion2_Sociales(25, 0) * Cantidad_Componentes_Materias_Sesion2_Sociales(24, 0)
                Cantidad_Componentes_Materias_Sesion2_Sociales(16, 0) = Cantidad_Componentes_Materias_Sesion2_Sociales(9, 0) * Cantidad_Componentes_Materias_Sesion2_Sociales(0, 0)
                Cantidad_Componentes_Materias_Sesion2_Sociales(17, 0) = Cantidad_Componentes_Materias_Sesion2_Sociales(10, 0) * Cantidad_Componentes_Materias_Sesion2_Sociales(1, 0)
                Cantidad_Componentes_Materias_Sesion2_Sociales(18, 0) = Cantidad_Componentes_Materias_Sesion2_Sociales(11, 0) * Cantidad_Componentes_Materias_Sesion2_Sociales(2, 0)
                Cantidad_Componentes_Materias_Sesion2_Sociales(19, 0) = Cantidad_Componentes_Materias_Sesion2_Sociales(12, 0) * Cantidad_Componentes_Materias_Sesion2_Sociales(3, 0)
                Cantidad_Componentes_Materias_Sesion2_Sociales(20, 0) = Cantidad_Componentes_Materias_Sesion2_Sociales(13, 0) * Cantidad_Componentes_Materias_Sesion2_Sociales(4, 0)
                Cantidad_Componentes_Materias_Sesion2_Sociales(21, 0) = Cantidad_Componentes_Materias_Sesion2_Sociales(14, 0) * Cantidad_Componentes_Materias_Sesion2_Sociales(5, 0)
                Cantidad_Componentes_Materias_Sesion2_Sociales(22, 0) = Cantidad_Componentes_Materias_Sesion2_Sociales(15, 0) * Cantidad_Componentes_Materias_Sesion2_Sociales(6, 0)
                Cantidad_Componentes_Materias_Sesion2_Sociales(23, 0) = Materia_Cantidad_Componentes_Competencias_Sesion2(0, 0)

            Next

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% AQUI TERMINA SOCIALES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Dim suma_puntajes_materias_sesion1 As Double = 0
            Dim suma_puntajes_materias_sesion2 As Double = 0
            For i = 0 To 0
                suma_puntajes_materias_sesion1 = suma_puntajes_materias_sesion1 + Cantidad_Componentes_Materias_Sesion1_Matematicas(8, i) + Cantidad_Componentes_Materias_Sesion1_Naturales(8, i)
            Next
            For i = 0 To 0
                suma_puntajes_materias_sesion2 = suma_puntajes_materias_sesion2 + Cantidad_Componentes_Materias_Sesion2_Ingles(8, i) + Cantidad_Componentes_Materias_Sesion2_Lectura(8, i) + Cantidad_Componentes_Materias_Sesion2_Sociales(8, i)
            Next
            '################################## PUNTAJE PROMEDIO DE TODAS LAS MATERIAS  ########################################################
            puntajepromedio = (suma_puntajes_materias_sesion1 + suma_puntajes_materias_sesion2)


            'CALCULAR LA VARIANZA
            Dim suma_puntajes_materias As Double = 0
            Dim vec(0 To (cantidad_materias_1 + cantidad_materias_2) - 1) As Double
            Dim Varianza As Double
            Dim DesviacionTipica As Double
            Dim Suma As Double = 0

            vec(0) = Cantidad_Componentes_Materias_Sesion1_Matematicas(8, 0)
            vec(1) = Cantidad_Componentes_Materias_Sesion1_Naturales(8, 0)
            vec(2) = Cantidad_Componentes_Materias_Sesion2_Ingles(8, 0)
            vec(3) = Cantidad_Componentes_Materias_Sesion2_Lectura(8, 0)
            vec(4) = Cantidad_Componentes_Materias_Sesion2_Sociales(8, 0)


            For i = 0 To 4
                Suma = Suma + Math.Pow((vec(i) - (puntajepromedio / 5)), 2)
            Next i
            Varianza = Suma / (4)
            DesviacionTipica = Math.Sqrt(Varianza)

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  ESTO ES PARA GUARDAR EN EL PROMEDIO DE CADA MATERIA  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            'COMPROBAR QUE EL EXAMEN NO ESTE REPETIDO EN "Informe_Resultados", Y EN "Total_Promedio_Materias_Saber"  "ESO HAY QUE VERLO"...?

            'Dim DC2 As New OleDb.OleDbDataAdapter("SELECT  materia,tipo_Materia,cantidad_preguntas FROM Formato_Examen_Cantidad WHERE sesion='2' AND orden=' ' AND codigo='" & CBOSIMULACRO.Text & "'", CN)

            Dim CVERIFICAR As New OleDb.OleDbDataAdapter("SELECT codigo FROM Informe_Resultados WHERE codigo='" & codigoestudiante & "'AND codigo_simulacro='" & CBOSIMULACRO.Text & "'", CN)
            Dim DW As New DataSet
            CVERIFICAR.Fill(DW, "Informe_Resultados")
            CBOAUX.DataSource = DW.Tables("Informe_Resultados")
            CBOAUX.DisplayMember = "codigo"


            If CBOAUX.Text.ToString = codigoestudiante.ToString Then
                ' BORRAR EL EXAMEN ENCONTRADO IGUAL DE LA TRABLA Informe_Resultados
                Dim CMD1 As New OleDb.OleDbCommand("DELETE FROM Informe_Resultados WHERE codigo='" & codigoestudiante & "'AND codigo_simulacro='" & CBOSIMULACRO.Text & "'", CN)
                CN.Open()
                CMD1.ExecuteNonQuery()
                CN.Close()

                ' BORRAR EL EXAMEN ENCONTRADO IGUAL DE LA TRABLA Total_Promedio_Materias_Saber 
                Dim CMD2 As New OleDb.OleDbCommand("DELETE FROM Total_Promedio_Materias_Saber WHERE codigo='" & codigoestudiante & "'AND codigo_simulacro='" & CBOSIMULACRO.Text & "'", CN)
                CN.Open()
                CMD2.ExecuteNonQuery()
                CN.Close()
            End If


            If grado_simulacro = "10°" Then

                'AQUI SE TOTEA CUANDO SE CALIFICA UN SIMULACRO QUE NO TIENE COMPONENTE FLEXIBLE Y DE 10° AREGLARLO
                Dim CMD5 As New OleDb.OleDbCommand("INSERT INTO Total_Promedio_Materias_Saber VALUES ( '" & codigoestudiante.ToString & "','" & CBOSIMULACRO.Text & "','" & puntajepromedio & "','" & DesviacionTipica & "','" & Cantidad_Componentes_Materias_Sesion1(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 4) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 4) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 2) & "','" & "0" & "','" & "0" & "','" & 0 & "','" & 0 & "','" & "0" & "','" & "0" & "')", CN)
                CN.Open()
                CMD5.ExecuteNonQuery()
                CN.Close()
                'INSERTAR EN LA TABLA INFORME RESULTADOS LAS PRIMERAS 8 MATERIAS DE LAS SESION 1 DE ESE ESTUDIANTE
                ' mañana arreglar los componentes flexibles, LAS COMPETENCIAS Y LOS COMPONENTES.
                Try
                    Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO Informe_Resultados VALUES ( '" & codigoestudiante & "','" & CBOSIMULACRO.Text & "','" & Cantidad_Componentes_Materias_Sesion1(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 4) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 2) & "','" & puntajepromedio & "','" & Cantidad_Componentes_Materias_Sesion1(16, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(17, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(18, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(19, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(20, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(21, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(22, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(16, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(17, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(18, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(19, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(20, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(21, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(22, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(16, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(17, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(18, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(19, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(20, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(21, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(22, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(16, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(17, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(18, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(19, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(20, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(21, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(22, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(16, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(17, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(18, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(19, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(20, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(21, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(22, 4) & "','" & Cantidad_Componentes_Materias_Sesion2(16, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(17, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(18, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(19, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(20, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(21, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(22, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(16, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(17, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(18, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(19, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(20, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(21, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(22, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(16, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(17, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(18, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(19, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(20, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(21, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(22, 2) & "','" & "0" & "','" & 0 & "','" & "0" & "','" & 0 & "')", CN)
                    CN.Open()
                    CMD2.ExecuteNonQuery()
                    CN.Close()
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA Informe_Resultados CUANDO YA SE TENIAN EXAMENES IGUALES", 16, "ERROR")
                    Me.Hide()
                End Try

            ElseIf grado_simulacro = "10°" Then   'CASO PARA 8 MATERIAS + 2 FIJAS (V Y S, M A)
                Dim CMD5 As New OleDb.OleDbCommand("INSERT INTO Total_Promedio_Materias_Saber VALUES ( '" & codigoestudiante.ToString & "','" & CBOSIMULACRO.Text & "','" & puntajepromedio & "','" & DesviacionTipica & "','" & Cantidad_Componentes_Materias_Sesion1(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 4) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 4) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 2) & "','" & Cantidad_Materias_Flexible(0, 0) & "','" & Cantidad_Materias_Flexible(0, 1) & "','" & Cantidad_Materias_Flexible(2, 0) & "','" & Cantidad_Materias_Flexible(2, 1) & "','" & Cantidad_Materias_Flexible(3, 0) & "','" & Cantidad_Materias_Flexible(3, 1) & "')", CN)
                CN.Open()
                CMD5.ExecuteNonQuery()
                CN.Close()
                'INSERTAR EN LA TABLA INFORME RESULTADOS LAS PRIMERAS 8 MATERIAS DE LAS SESION 1 DE ESE ESTUDIANTE
                Try
                    Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO Informe_Resultados VALUES ( '" & codigoestudiante & "','" & CBOSIMULACRO.Text & "','" & Cantidad_Componentes_Materias_Sesion1(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(23, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(8, 4) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(23, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(8, 2) & "','" & puntajepromedio & "','" & Cantidad_Componentes_Materias_Sesion1(16, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(17, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(18, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(19, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(20, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(21, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(22, 0) & "','" & Cantidad_Componentes_Materias_Sesion1(16, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(17, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(18, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(19, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(20, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(21, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(22, 1) & "','" & Cantidad_Componentes_Materias_Sesion1(16, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(17, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(18, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(19, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(20, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(21, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(22, 2) & "','" & Cantidad_Componentes_Materias_Sesion1(16, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(17, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(18, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(19, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(20, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(21, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(22, 3) & "','" & Cantidad_Componentes_Materias_Sesion1(16, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(17, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(18, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(19, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(20, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(21, 4) & "','" & Cantidad_Componentes_Materias_Sesion1(22, 4) & "','" & Cantidad_Componentes_Materias_Sesion2(16, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(17, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(18, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(19, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(20, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(21, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(22, 0) & "','" & Cantidad_Componentes_Materias_Sesion2(16, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(17, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(18, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(19, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(20, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(21, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(22, 1) & "','" & Cantidad_Componentes_Materias_Sesion2(16, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(17, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(18, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(19, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(20, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(21, 2) & "','" & Cantidad_Componentes_Materias_Sesion2(22, 2) & "','" & Cantidad_Materias_Flexible(0, 0) & "','" & Cantidad_Materias_Flexible(2, 0) & "','" & Cantidad_Materias_Flexible(0, 1) & "','" & Cantidad_Materias_Flexible(2, 1) & "')", CN)
                    CN.Open()
                    CMD2.ExecuteNonQuery()
                    CN.Close()
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA Informe_Resultados CUANDO YA SE TENIAN EXAMENES IGUALES", 16, "ERROR")
                    Me.Hide()
                End Try

            ElseIf grado_simulacro = "11°" Then
                ' AQUI SE TOTEA CUANDO SE CALIFICA UN SIMULACRO QUE NO TIENE COMPONENTE FLEXIBLE Y DE 10° AREGLARLO
                Dim CMD5 As New OleDb.OleDbCommand("INSERT INTO Total_Promedio_Materias_Saber VALUES ( '" & codigoestudiante.ToString & "','" & CBOSIMULACRO.Text & "','" & puntajepromedio & "','" & DesviacionTipica & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(8, 0) & "')", CN)
                CN.Open()
                CMD5.ExecuteNonQuery()
                CN.Close()
                'INSERTAR EN LA TABLA INFORME RESULTADOS LAS PRIMERAS 8 MATERIAS DE LAS SESION 1 DE ESE ESTUDIANTE
                Try
                    Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO Informe_Resultados VALUES ( '" & codigoestudiante & "','" & CBOSIMULACRO.Text & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(8, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(23, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(8, 0) & "','" & puntajepromedio & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(16, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(17, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(18, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(19, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(20, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(21, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(22, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(16, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(17, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(18, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(19, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(20, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(21, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Naturales(22, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(16, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(17, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(18, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(19, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(20, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(21, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Ingles(22, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(16, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(17, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(18, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(19, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(20, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(21, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Lectura(22, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(16, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(17, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(18, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(19, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(20, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(21, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(22, 0) & "','" & Cantidad_Componentes_Materias_Sesion1_Matematicas(25, 0) & "','" & Cantidad_Componentes_Materias_Sesion2_Sociales(25, 0) & "')", CN)
                    CN.Open()
                    CMD2.ExecuteNonQuery()
                    CN.Close()
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA Informe_Resultados CUANDO YA SE TENIAN EXAMENES IGUALES", 16, "ERROR")
                    Me.Hide()
                End Try

            Else
                MsgBox("HA SELECCIONADO MAS DE TRES COMPONENTES FLEXIBLEX ESTE REPORTE NO HA SIDO CREADO AUN", 16, "ERROR")
            End If


            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    ESTO CREO QUE NO SIRVE   %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            'Try
            'Dim CMD5 As New OleDb.OleDbCommand("UPDATE Total_Promedio_Materias_Saber INNER JOIN (SELECT puntaje FROM Resultados_Examenes WHERE Resultados_Examenes.materias ='" & Cantidad_Componentes_Materias_Sesion2(23, 0) & "') t1 ON t1.puntaje = Total_Promedio_Materias_Saber.puntaje SET pedidos.cambios_fechas = t1.total", CN)
            'CN.Open()
            'CMD5.ExecuteNonQuery()
            'CN.Close()
            'Catch ex As Exception
            'MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA Informe_Resultados CUANDO YA SE TENIAN EXAMENES IGUALES", 16, "ERROR")
            'Me.Hide()
            'End Try
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ESTO ES CUANDO TERMINA DE CALIFICAR %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            '%%%%%%%%%%%%%%%%%%   PREGUNTAR SI ESTA EN Todas_Preguntas_Saber_Sesion2 ESTE ESTUDIANTE O EXAMEN   %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            Dim DA1 As New OleDb.OleDbDataAdapter("SELECT  COUNT(codigo_estudiante) as PEPE  FROM Todas_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
            Dim DQ1 As New DataSet
            DA1.Fill(DQ1, "Todas_Preguntas_Saber_Sesion2")
            CBOCODIGO.DataSource = DQ1.Tables("Todas_Preguntas_Saber_Sesion2")
            CBOCODIGO.DisplayMember = "PEPE"

            If CBOCODIGO.Text.ToString = "" Then

                Dim CMD6 As New OleDb.OleDbCommand("DELETE FROM Copia_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
                CN.Open()
                CMD6.ExecuteNonQuery()
                CN.Close()

                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ESTO ES PARA HACER UNA COPIA DE UN REGISTRO EN LA TABLA Copia_Preguntas_Saber_Sesion2 %%%%%%%%%%%%%%%%%%
                Try

                    ' insertar el codigo de la prueba en Copia_Preguntas_Saber_Sesion2 


                    Dim CMD1 As New OleDb.OleDbCommand("INSERT INTO Copia_Preguntas_Saber_Sesion2 SELECT * FROM Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
                    CN.Open()
                    CMD1.ExecuteNonQuery()
                    CN.Close()
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA Copia_Preguntas_Saber_Sesion2", 16, "ERROR")
                    Me.Hide()
                End Try

                Try
                    Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO Todas_Preguntas_Saber_Sesion2 SELECT * FROM Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
                    CN.Open()
                    CMD2.ExecuteNonQuery()
                    CN.Close()
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA Todas_Preguntas_Saber_Sesion2", 16, "ERROR")
                    Me.Hide()
                End Try
                'BORRAR DE LA TABLA DE LAS PREGUNTAS AUN SIN CALIFICAR... 
                Dim CMD4 As New OleDb.OleDbCommand("DELETE FROM Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
                CN.Open()
                CMD4.ExecuteNonQuery()
                CN.Close()
                MsgBox("El Examen ha sido Calificado Correctamente", 8, "Confirmación")
            Else
                '########################################################################################################
                'Dim DA2 As New OleDb.OleDbDataAdapter("SELECT  codigo_estudiante FROM Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
                'Dim DQ2 As New DataSet
                'DA2.Fill(DQ2, "Copia_Preguntas_Saber_Sesion2")
                'CBOCODIGO.DataSource = DQ2.Tables("Copia_Preguntas_Saber_Sesion2")
                'CBOCODIGO.DisplayMember = "codigo_estudiante"
                'codigoestudiante = CBOCODIGO.Text
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% BORRAR EL REGISTRO DE LAS TABLAS Todas_Preguntas_Saber_Sesion2 Y Copia_Preguntas_Saber_Sesion2
                Dim CMD5 As New OleDb.OleDbCommand("DELETE FROM Todas_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
                CN.Open()
                CMD5.ExecuteNonQuery()
                CN.Close()
                Dim CMD6 As New OleDb.OleDbCommand("DELETE FROM Copia_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
                CN.Open()
                CMD6.ExecuteNonQuery()
                CN.Close()
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ESTO ES PARA HACER UNA COPIA DE UN REGISTRO EN LA TABLA Todas_Preguntas_Saber_Sesion2 %%%%%%%%%%%%%%
                Try
                    Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO Todas_Preguntas_Saber_Sesion2 SELECT * FROM Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
                    CN.Open()
                    CMD2.ExecuteNonQuery()
                    CN.Close()
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA Todas_Preguntas_Saber_Sesion2", 16, "ERROR")
                    Me.Hide()
                End Try
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ESTO ES PARA HACER UNA COPIA DE UN REGISTRO EN LA TABLA Copia_Preguntas_Saber_Sesion2 %%%%%%%%%%%%%%%%%%
                Try
                    Dim CMD1 As New OleDb.OleDbCommand("INSERT INTO Copia_Preguntas_Saber_Sesion2 SELECT * FROM Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
                    CN.Open()
                    CMD1.ExecuteNonQuery()
                    CN.Close()
                Catch ex As Exception
                    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA Copia_Preguntas_Saber_Sesion2", 16, "ERROR")
                    Me.Hide()
                End Try
                'BORRAR DE LA TABLA DE LAS PREGUNTAS AUN SIN CALIFICAR... 
                Dim CMD4 As New OleDb.OleDbCommand("DELETE FROM Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "'", CN)
                CN.Open()
                CMD4.ExecuteNonQuery()
                CN.Close()
                'MsgBox("El Examen ha sido Calificado Correctamente", 8, "Confirmación")
            End If

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ESTO ES PARA BORRAR TODAS LOS REGISTROS DE LA TABLA Copia_Preguntas_Saber_Sesion2 %%%%%%%%%%%%%%%%%%%%%%
            'Try
            '    Dim CMD1 As New OleDb.OleDbCommand("DELETE FROM Copia_Preguntas_Saber_Sesion2 WHERE 1", CN)
            '    CN.Open()
            '    CMD1.ExecuteNonQuery()
            '    CN.Close()
            'Catch ex As Exception
            '    MsgBox("OCURRIO UN PROBLEMA 6", 16, "ERROR")
            '    Me.Hide()
            'End Try
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ESTO ES PARA OTRA COSA %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            ''SI SE QUIERE INGRESAR UN ENTERO O ALGO ASI...
            ''Dim CMD2 As New OleDb.OleDbCommand("DELETE FROM Preguntas_niveles_pensamiento WHERE codigo_estudiante=(" & codigoestudiante & ")", CN)
            ''CN.Open()
            ''CMD2.ExecuteNonQuery()
            ''CN.Close()
            ''MsgBox(CBNSIMULACRO.Text)
            'End If
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ESTO ES PARA OTRA COSA %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


        Next

        '' ESTO ES PARA ASERTIVIDAD.
        '' PARA RECORRER LOS EXAMENES DE CADA ESTUDIANTE

        'Dim TODAS_MATERIAS As Integer
        'TODAS_MATERIAS = cantidad_materias_1 + cantidad_materias_2
        '' "" RECORDAR BORRAR EN DONDE TENGO TAS LAS RESPUESTAS Y COMPONENTES EN UNA SOLA VARIABLE""
        ''cantidad_preguntas_sesion1
        'Dim CMATERIA_FORMATO11 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND sesion='1' AND tipo_Materia=' '", CN)
        'Dim DATA_FORMATO11 As New DataSet
        'CMATERIA_FORMATO11.Fill(DATA_FORMATO11, "Formato_Examen")
        'Dim cantidad_preguntas_sesion11 As String
        'cantidad_preguntas_sesion11 = DATA_FORMATO11.Tables(0).Rows.Count
        ''%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% SEGUNDA SESION %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5
        'Dim CMATERIA_FORMATO22 As New OleDb.OleDbDataAdapter("SELECT materia,pregunta,Respuesta,Componente,competencia FROM Formato_Examen WHERE codigo='" & CBOSIMULACRO.Text & "' AND sesion='2' AND tipo_Materia=' '", CN)
        'Dim DATA_FORMATO22 As New DataSet
        'CMATERIA_FORMATO22.Fill(DATA_FORMATO22, "Formato_Examen")
        'Dim cantidad_preguntas_sesion22 As String
        'cantidad_preguntas_sesion22 = DATA_FORMATO22.Tables(0).Rows.Count
        'ReDim Contador_respuestas_cada_materia((CInt(cantidad_preguntas_sesion11) + CInt(cantidad_preguntas_sesion22)) - 1, 9)
        'contador_a = 0
        'contador_b = 0
        'contador_c = 0
        'contador_d = 0
        'contador_e = 0

        'For f = 0 To (cantidad_materias_1 + cantidad_materias_2) - 1   ' cantidad de materias en este caso "8"
        '    For y = 0 To cant_registros - 1    'cant_registros: 

        '        TXTCODIGOEXAMEN1.Text = DQ.Tables(0).Rows(y).Item(0).ToString
        '        codigoestudiante = TXTCODIGOEXAMEN1.Text
        '        Dim DB1 As New OleDb.OleDbDataAdapter("SELECT  * FROM Auxiliar_Reporte_Asertividad_Preguntas_Saber_Sesion2 WHERE codigo_estudiante='" & codigoestudiante & "' ORDER BY sesion ASC", CN)
        '        Dim DV1 As New DataSet
        '        DB1.Fill(DV1, "Preguntas_Saber_Sesion2")
        '        ' RESPUESTAS DE LA SESION 1
        '        Dim columnas1 As Integer
        '        columnas1 = DV1.Tables(0).Columns.Count
        '        ReDim Respuestas_Sesion1(columnas1 - 1)
        '        ReDim Respuestas_Sesion2(columnas1 - 1)

        '        For j = 0 To 1
        '            If DV1.Tables(0).Rows(j).Item(2).ToString = 1 Then
        '                For i = 0 To columnas1 - 1
        '                    NUMERO2.Text = DV1.Tables(0).Rows(j).Item(i).ToString
        '                    sesion1(i) = NUMERO2.Text.ToString
        '                    Respuestas_Sesion1(i) = NUMERO2.Text.ToString
        '                    'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
        '                Next
        '            ElseIf DV1.Tables(0).Rows(j).Item(2).ToString = 2 Then
        '                ' RESPUESTAS DE LA SESION 2
        '                For i = 0 To columnas1 - 1
        '                    NUMERO2.Text = DV1.Tables(0).Rows(j).Item(i).ToString
        '                    sesion1(i + columnas1) = NUMERO2.Text.ToString
        '                    Respuestas_Sesion2(i) = NUMERO2.Text.ToString
        '                    'AQUI ESTAN TODAS LAS RESPUESTAS DE LA PRIMER SESION DEL SIMULACRO ESCANEADO. INCLUYENDO EL CODIGO.
        '                Next
        '            End If
        '        Next

        '        For i = 0 To (cantidad_preguntas_sesion11 - 1) ' cantidad de preguntas

        '            If f < cantidad_materias_1 Then
        '                If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f) Then
        '                    'IR CAMBIANDO LAS Respuestas_Sesion1 PREGUNTANDO POR CADA ESTUDIANTES MAÑANA 
        '                    contador_a = contador_a + 1
        '                    If Respuestas_Sesion1(i + 3) = 1 Then
        '                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
        '                        Contador_respuestas_cada_materia(i, 1) = i + 1
        '                        Contador_respuestas_cada_materia(i, 2) = Contador_respuestas_cada_materia(i, 2) + 1
        '                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
        '                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
        '                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

        '                    ElseIf Respuestas_Sesion1(i + 3) = 2 Then
        '                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
        '                        Contador_respuestas_cada_materia(i, 1) = i + 1
        '                        Contador_respuestas_cada_materia(i, 3) = Contador_respuestas_cada_materia(i, 3) + 1
        '                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
        '                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
        '                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

        '                    ElseIf Respuestas_Sesion1(i + 3) = 3 Then
        '                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
        '                        Contador_respuestas_cada_materia(i, 1) = i + 1
        '                        Contador_respuestas_cada_materia(i, 4) = Contador_respuestas_cada_materia(i, 4) + 1
        '                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
        '                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
        '                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

        '                    ElseIf Respuestas_Sesion1(i + 3) = 4 Then
        '                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
        '                        Contador_respuestas_cada_materia(i, 1) = i + 1
        '                        Contador_respuestas_cada_materia(i, 5) = Contador_respuestas_cada_materia(i, 5) + 1
        '                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
        '                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
        '                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)

        '                    ElseIf Respuestas_Sesion1(i + 3) = 5 Then
        '                        Contador_respuestas_cada_materia(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion1(0, f)
        '                        Contador_respuestas_cada_materia(i, 1) = i + 1
        '                        Contador_respuestas_cada_materia(i, 6) = Contador_respuestas_cada_materia(i, 6) + 1
        '                        Contador_respuestas_cada_materia(i, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 2)
        '                        Contador_respuestas_cada_materia(i, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 3)
        '                        Contador_respuestas_cada_materia(i, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion1(i, 4)
        '                    End If
        '                Else
        '                End If

        '                If contador_a = Materia_Cantidad_Componentes_Competencias_Sesion1(1, 0) Then
        '                    contador_a = 0
        '                    Exit For
        '                End If

        '            ElseIf f >= cantidad_materias_1 Then

        '                If Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 0) = Materia_Cantidad_Componentes_Competencias_Sesion2(0, f - cantidad_materias_1) Then
        '                    'IR CAMBIANDO LAS Respuestas_Sesion1 PREGUNTANDO POR CADA ESTUDIANTES MAÑANA 
        '                    contador_b = contador_b + 1
        '                    If Respuestas_Sesion2(i + 3) = 1 Then
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 0) = Materia_Cantidad_Componentes_Competencias_Sesion2(0, f - cantidad_materias_1)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 1) = i + cantidad_preguntas_sesion11 + 1
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 2) = Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 2) + 1
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 2)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 3)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 4)

        '                    ElseIf Respuestas_Sesion1(i + 3) = 2 Then
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 0) = Materia_Cantidad_Componentes_Competencias_Sesion2(0, f - cantidad_materias_1)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 1) = i + cantidad_preguntas_sesion11 + 1
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 3) = Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 3) + 1
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 2)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 3)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 4)

        '                    ElseIf Respuestas_Sesion2(i + 3) = 3 Then
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 0) = Materia_Cantidad_Componentes_Competencias_Sesion2(0, f - cantidad_materias_1)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 1) = i + cantidad_preguntas_sesion11 + 1
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 4) = Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 4) + 1
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 2)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 3)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 4)

        '                    ElseIf Respuestas_Sesion2(i + 3) = 4 Then
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 0) = Materia_Cantidad_Componentes_Competencias_Sesion2(0, f - cantidad_materias_1)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 1) = i + cantidad_preguntas_sesion11 + 1
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 5) = Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 5) + 1
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 2)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 3)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 4)

        '                    ElseIf Respuestas_Sesion2(i + 3) = 5 Then
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 0) = Materia_Cantidad_Componentes_Competencias_Sesion2(0, f - cantidad_materias_1)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 1) = i + cantidad_preguntas_sesion11 + 1
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 6) = Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 6) + 1
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 7) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 2)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 8) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 3)
        '                        Contador_respuestas_cada_materia(i + cantidad_preguntas_sesion11, 9) = Materia_Preguntas_Respuesta_Componente_Competencia_Sesion2(i, 4)

        '                    End If
        '                Else

        '                End If
        '                If contador_b = Materia_Cantidad_Componentes_Competencias_Sesion2(1, 0) Then
        '                    contador_b = 0
        '                    Exit For
        '                End If
        '            End If
        '        Next
        '    Next
        'Next
        ''%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    FIN  SIMULACRO EN LA SESION 1  Y 2 %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        'Try
        '    codigoestudiante = Respuestas_Sesion1(0)
        '    Dim aux_cogido_colegio As String
        '    Dim aux_codigo_grupo As String
        '    aux_cogido_colegio = Mid(codigoestudiante, 2, 3)
        '    aux_codigo_grupo = Mid(codigoestudiante, 5, 2)


        '    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% ESTO ES PARA BORRAR TODAS LOS REGISTROS DE LA TABLA asertividad_materias %%%%%%%%%%%%%%%%%%%%%%
        '    Try
        '        Dim CMD1 As New OleDb.OleDbCommand("DELETE FROM asertividad_materias WHERE codigo_simulacro='" & CBOSIMULACRO.Text & "' AND colegio='" & aux_cogido_colegio & "'AND grupo='" & aux_codigo_grupo & "'", CN)
        '        CN.Open()
        '        CMD1.ExecuteNonQuery()
        '        CN.Close()
        '    Catch ex As Exception
        '        MsgBox("OCURRIO UN PROBLEMA BORRANDO LA TABLA asertividad_materias", 16, "ERROR")
        '        Me.Hide()
        '    End Try
        '    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        '    For i = 0 To (CInt(cantidad_preguntas_sesion11) + CInt(cantidad_preguntas_sesion22)) - 1
        '        If Contador_respuestas_cada_materia(i, 7) = "1" Then
        '            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & Contador_respuestas_cada_materia(i, 1) & "','" & (Contador_respuestas_cada_materia(i, 2)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 3)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 4)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 5)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 6)) / cant_registros & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 2)) / cant_registros & "')", CN)
        '            CN.Open()
        '            CMD2.ExecuteNonQuery()
        '            CN.Close()
        '        ElseIf Contador_respuestas_cada_materia(i, 7) = "2" Then
        '            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & Contador_respuestas_cada_materia(i, 1) & "','" & (Contador_respuestas_cada_materia(i, 2)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 3)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 4)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 5)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 6)) / cant_registros & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 3)) / cant_registros & "')", CN)
        '            CN.Open()
        '            CMD2.ExecuteNonQuery()
        '            CN.Close()
        '        ElseIf Contador_respuestas_cada_materia(i, 7) = "3" Then
        '            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & Contador_respuestas_cada_materia(i, 1) & "','" & (Contador_respuestas_cada_materia(i, 2)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 3)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 4)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 5)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 6)) / cant_registros & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 4)) / cant_registros & "')", CN)
        '            CN.Open()
        '            CMD2.ExecuteNonQuery()
        '            CN.Close()
        '        ElseIf Contador_respuestas_cada_materia(i, 7) = "4" Then
        '            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & Contador_respuestas_cada_materia(i, 1) & "','" & (Contador_respuestas_cada_materia(i, 2)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 3)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 4)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 5)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 6)) / cant_registros & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 5)) / cant_registros & "')", CN)
        '            CN.Open()
        '            CMD2.ExecuteNonQuery()
        '            CN.Close()
        '        ElseIf Contador_respuestas_cada_materia(i, 7) = "5" Then
        '            Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO asertividad_materias VALUES ( '" & CBOTIPO.Text & "','" & aux_cogido_colegio & "','" & aux_codigo_grupo & "','" & CBOSIMULACRO.Text & "','" & Contador_respuestas_cada_materia(i, 0) & "','" & cant_registros & "','" & Contador_respuestas_cada_materia(i, 1) & "','" & (Contador_respuestas_cada_materia(i, 2)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 3)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 4)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 5)) / cant_registros & "','" & (Contador_respuestas_cada_materia(i, 6)) / cant_registros & "','" & Contador_respuestas_cada_materia(i, 7) & "','" & Contador_respuestas_cada_materia(i, 8) & "','" & Contador_respuestas_cada_materia(i, 9) & "','" & (Contador_respuestas_cada_materia(i, 6)) / cant_registros & "')", CN)
        '            CN.Open()
        '            CMD2.ExecuteNonQuery()
        '            CN.Close()
        '        End If
        '    Next

        'Catch ex As Exception
        '    MsgBox("OCURRIO UN PROBLEMA AL INSERTAR EN LA TABLA asertividad_materias", 16, "ERROR")
        '    Me.Hide()
        'End Try
    End Sub

End Class