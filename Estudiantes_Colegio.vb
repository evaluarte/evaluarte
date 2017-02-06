Imports System.Data.OleDb
Public Class Estudiantes_Colegio
    Public variable As String
    Public grupo As String
    Public grado As String
    Public fecha As Date
    Public fecha_comotal As String
    Public codigo_prueba As String
    Public codigo_estudiante As String
    Public nombre_colegio As String
    Public simulacro As String
    Public materia As String
    Public Dba As String


    Dim CONSULTA As String
    Dim DSET As New DataSet

    Sub CRYSTAL_REPORT()

        'MsgBox(variable)
        'MsgBox(grupo)
        Dim PEPE As Date
        PEPE = fecha
        PEPE = Format(PEPE, "dd/MM/yy")
        fecha_comotal = PEPE
        Dim diames As String
        Dim ano As String
        Dim fechaFinal As String
        diames = Mid(fecha_comotal, 1, 6)
        ano = Mid(fecha_comotal, 7, 10)
        fechaFinal = diames + ano

        If Control = 1 Then
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Estudiantes_Codigo WHERE codigo_colegio='" & variable & "'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "Estudiantes_Codigo")
            'DataGridView1.DataSource = DS.Tables("Estudiantes_Codigo")
            'Dim REPORTAR As New listado_estudiantes
            'REPORTAR.SetDataSource(DS)
            'CrystalReportViewer1.ReportSource = REPORTAR
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("\\Sistemas3\d\reportes\Listado_Estudiantes.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport

        End If


        If Control = 2 Then
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM listado_grupos WHERE codigo_colegios='" & variable & "' AND codigo_gupo='" & grupo & "'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "listado_grupos")
            'DataGridView1.DataSource = DS.Tables("listado_grupos")
            'Dim REPORTAR As New listar_grupos
            'REPORTAR.SetDataSource(DS)
            'CrystalReportViewer1.ReportSource = REPORTAR
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("\\Sistemas3\d\reportes\listar_grupos.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport

        End If

        If Control = 3 Then
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM listado_grupos WHERE codigo_colegios='" & variable & "' AND codigo_gupo='" & grupo & "'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "listado_grupos")
            'DataGridView1.DataSource = DS.Tables("listado_grupos")
            'Dim REPORTAR As New Control_material
            'REPORTAR.SetDataSource(DS)
            'CrystalReportViewer1.ReportSource = REPORTAR
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("\\Sistemas3\d\reportes\control_material.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport
        End If

        If Control = 4 Then
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM listado_grupos WHERE codigo_colegios='" & variable & "' AND codigo_gupo='" & grupo & "'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "listado_grupos")

            'DataGridView1.DataSource = DS.Tables("listado_grupos")
            'Dim REPORTAR As New Listar_asistencia
            'REPORTAR.SetDataSource(DS)
            'CrystalReportViewer1.ReportSource = REPORTAR

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("\\Sistemas3\d\reportes\Listar_asistencia.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport

        End If

        If Control = 5 Then
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Asistencia_simulacro_manual WHERE codigo_colegio='" & variable & "' AND codigo_gupo='" & grupo & "'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "Asistencia_simulacro_manual")

            'Dim REPORTAR As New Listado_Asistencia_Simulacro
            'REPORTAR.SetDataSource(DS)
            'CrystalReportViewer1.ReportSource = REPORTAR

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("\\Sistemas3\d\reportes\Listado_Asistencia_Simulacro.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport

        End If

        'consultar por un número
        'If Control = 6 Then
        '    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultado_Estudiante WHERE codigo_simulacro=(" & variable & ")", CN)
        '    Dim DS As New DataSet
        '    DA.Fill(DS, "Resultado_Estudiante")

        '    'Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '    'CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        '    'CrReport.Load("\\Sistemas3\d\reportes\CrystalReport2.rpt")
        '    'CrReport.SetDataSource(DS)
        '    'CrystalReportViewer1.ReportSource = CrReport

        '    Dim REPORTAR As New CrystalReport2
        '    REPORTAR.SetDataSource(DS)
        '    CrystalReportViewer1.ReportSource = REPORTAR
        'End If

        If Control = 6 Then

            'If codigo_prueba = 1 Then
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultado_Estudiante WHERE Codigo='" & codigo_estudiante & "'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "Resultado_Estudiante")

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("\\Sistemas3\d\reportes\Todos_resultados.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport
            MODIFICAR_Generales()
        End If

        'If Control = 7 Then

        '    If codigo_prueba = 1 Then
        '        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Notas_Grupo WHERE codigo_colegios='" & variable & "' AND codigo_gupo='" & grupo & "'", CN)
        '        Dim DS As New DataSet
        '        DA.Fill(DS, "Notas_Grupo")

        '        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        '        CrReport.Load("\\Sistemas3\d\reportes\npensamiento_General.rpt")
        '        CrReport.SetDataSource(DS)
        '        CrystalReportViewer1.ReportSource = CrReport
        '        MODIFICAR_Generales()
        '    ElseIf codigo_prueba = 2 Then
        '    ElseIf codigo_prueba = 3 Then
        '    Else
        '    End If

        'End If

        If Control = 8 Then

            'Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Notas_Grupo WHERE codigo_colegios='" & variable & "' AND codigo_gupo='" & grupo & "'", CN)
            Dim DS As New DataSet
            If grupo <> " " Then
                Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Notas_Grupo WHERE codigo_colegios='" & variable & "' AND codigo_gupo='" & grupo & "' ORDER BY promedio DESC", CN)
                DA.Fill(DS, "Notas_Grupo")
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Niveles_Pensamiento_Grupo_Promedios.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
            ElseIf grupo = " " Then
                Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Notas_Grupo WHERE codigo_colegios='" & variable & "' ORDER BY promedio DESC", CN)
                DA.Fill(DS, "Notas_Grupo")
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Niveles_Pensamiento_Institucion_Promedios.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
            End If



            MODIFICAR_Generales()

            'ElseIf codigo_prueba = 2 Then
            'ElseIf codigo_prueba = 3 Then
            'Else
            '    'Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Notas_Grupo WHERE codigo_colegios='" & variable & "' AND codigo_gupo='" & grupo & "'", CN)
            '    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Resultados_Saber_Decimo_Once WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND Identificacion_Prueba='" & simulacro & "'  ORDER BY proMat1 DESC, proMat2 DESC, proMat3 DESC, proMat4 DESC, proMat5 DESC, proMat6 DESC, proMat7 DESC, proMat8 DESC", CN)
            '    Dim DS As New DataSet
            '    DA.Fill(DS, "Notas_Grupo")

            '    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            '    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            '    CrReport.Load("\\Sistemas3\d\reportes\Resultados_Saber_Promedios.rpt")
            '    CrReport.SetDataSource(DS)
            '    CrystalReportViewer1.ReportSource = CrReport
            'End If

        End If

        If Control = 9 Then

            If codigo_prueba = 1 Then

                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultado_Estudiante WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Resultado_Estudiante")
                'DataGridView1.DataSource = DS.Tables("Notas_Grupo")
                'Dim REPORTAR As New npensamiento
                'REPORTAR.SetDataSource(DS)
                'CrystalReportViewer1.ReportSource = REPORTAR

                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Todos_resultados.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
                MODIFICAR()

            ElseIf codigo_prueba = 2 Then
                ' REPORTE NIVELES DE PENSAMIENTO Y ESTILOS DE APRENDIZAJE  INDIVIDUALES
                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Perfil_Profesional_Individuales WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Resultados_Perfil_Profesional_Individuales")
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Perfil_Profesional_Individuales.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
                MODIFICAR()
            ElseIf codigo_prueba = 3 Then
                If simulacro = "146" Or simulacro = "156" Or simulacro = "158" Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Resultados_Saber_Decimo_Once_Noveno.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                ElseIf simulacro = "151" Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Resultados_Saber_Decimo_Once_Noveno.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                ElseIf simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Resultados_Saber_Decimo_Once_Noveno.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                Else
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Resultados_Saber_Decimo_Once.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                End If
            ElseIf codigo_prueba = 4 Then

                If simulacro = "142" Or simulacro = "141" Then
                    ' PRIMER SIMULACRO
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Resultados_Saber_Decimo_Once.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                    'SEGUNDO SIMULACRO
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Resultados_Saber_Decimo_Once.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                End If
            End If
        End If


        If Control = 10 Then

            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Reportar_Ingresos", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "Reportar_Ingresos")

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("\\Sistemas3\d\reportes\Reportar_Ingresos.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport

        End If

        If Control = 11 Then

            'REPORTE SABER "LOS DOS" INDIVIDUALES TODOS
            ' VALIDAR CUANDO SEA UNO O EL OTRO
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Examenes WHERE codigo_simulacro='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "Resultados_Saber_Decimo_Once")

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("\\Sistemas3\d\reportes\Resultados_Saber_Decimo_Once.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport
            MODIFICAR()

        End If

        If Control = 12 Then
            'REPORTE SABER "LOS DOS" (3 5 Y 9, 10 y 11) Reporte_Saber_Grupo_Promedios_Generales   
            ' VALIDAR CUANDO SEA UNO O EL OTRO

            If codigo_prueba = 2 Then

                Dim DS As New DataSet

                If grupo <> " " Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Perfil_Profesional_Individuales WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY Ptj_Artistico DESC, Ptj_Numerico DESC, Ptj_Social DESC, Ptj_Mecanico DESC, Ptj_Cientifico DESC, Ptj_Literario DESC", CN)
                    DA.Fill(DS, "Resultados_Perfil_Profesional_Individuales")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Reporte_Perfil_Profesional_Grupo_Promedios_Generales.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport

                ElseIf grupo = " " Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Perfil_Profesional_Individuales WHERE codigo_colegio='" & variable & "' ORDER BY Ptj_Artistico DESC, Ptj_Numerico DESC, Ptj_Social DESC, Ptj_Mecanico DESC, Ptj_Cientifico DESC, Ptj_Literario DESC", CN)
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Reporte_Perfil_Profesional_Institucion_Promedios_Generales.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport

                End If

                MODIFICAR_Generales()

            ElseIf codigo_prueba = 3 Then

                Dim DS As New DataSet

                If simulacro = "146" Or simulacro = "156" Or simulacro = "158" Then

                    If grupo <> " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once  WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Reporte_Saber_Grupo_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Reporte_Saber_Institucion_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf simulacro = "151" Then

                    If grupo <> " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once  WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Reporte_Saber_Grupo_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Reporte_Saber_Institucion_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then

                    If grupo <> " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once  WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                Else
                    If grupo <> " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once  WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grupo_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Institucion_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                End If

                MODIFICAR_Generales()

            ElseIf codigo_prueba = 4 Then
                'REPORTE SABER "LOS DOS" ( 10 y 11)
                Dim DS As New DataSet

                If grupo <> " " Then

                    If simulacro = "142" Or simulacro = "141" Then
                        ' PRIMER SIMULACRO
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once  WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        'SEGUNDO SIMULACRO
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once  WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf grupo = " " Then

                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Institucion_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Institucion_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                End If

                MODIFICAR_Generales()

            ElseIf codigo_prueba = 11 Then

                Dim DS As New DataSet

                If grupo <> " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once  WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND fecha='" & fechaFinal & "' ORDER BY proTotal DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                        CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Grupo_Promedios_Generales.rpt")
                    Else
                        CrReport.Load("\\Sistemas3\d\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales.rpt")
                    End If
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                ElseIf grupo = " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND fecha='" & fechaFinal & "' ORDER BY proTotal DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                        CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Institucion_Promedios_Generales.rpt")
                    Else
                        CrReport.Load("\\Sistemas3\d\reportes\tusaber\cincomaterias\Reporte_Saber_Institucion_Promedios_Generales.rpt")
                    End If
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                End If

                MODIFICAR_Generales()

            End If

        End If

        If Control = 13 Then

            If codigo_prueba = 3 Then

                'REPORTE SABER "LOS DOS" (3 5 Y 9, 10 y 11) Reporte_Saber_Institucion_Asertividad   
                ' VALIDAR CUANDO SEA UNO O EL OTRO
                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Reporte_Asertividad_Saber WHERE codigo_simulacro='" & simulacro & "' AND  colegio='" & variable & "' AND materia='" & materia & "'  ORDER BY Procentaje_Asertivida ASC", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Reporte_Asertividad_Saber")

                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Institucion_Asertividad_3_5_9.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
                MODIFICAR_Generales()

            ElseIf codigo_prueba = 4 Then
                'REPORTE SABER "LOS DOS" (3 5 Y 9, 10 y 11) Reporte_Saber_Institucion_Asertividad   
                ' VALIDAR CUANDO SEA UNO O EL OTRO
                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Reporte_Asertividad_Saber WHERE codigo_simulacro='" & simulacro & "' AND  colegio='" & variable & "' AND materia='" & materia & "'  ORDER BY Procentaje_Asertivida ASC", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Reporte_Asertividad_Saber")

                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Institucion_Asertividad.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport

                MODIFICAR_Generales()

            End If

        End If


        If Control = 14 Then


            If codigo_prueba = 3 Then

                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Reporte_Asertividad_Saber WHERE codigo_simulacro='" & simulacro & "' AND  colegio='" & variable & "' AND  grupo='" & grupo & "' AND materia='" & materia & "'  ORDER BY Procentaje_Asertivida ASC", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Reporte_Asertividad_Saber")

                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Grupo_Asertividad.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport

                MODIFICAR_Generales()

            ElseIf codigo_prueba = 4 Then

                'REPORTE SABER "LOS DOS" (3 5 Y 9, 10 y 11) Reporte_Saber_Institucion_Asertividad   
                ' VALIDAR CUANDO SEA UNO O EL OTRO
                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Reporte_Asertividad_Saber WHERE codigo_simulacro='" & simulacro & "' AND  colegio='" & variable & "' AND  grupo='" & grupo & "' AND materia='" & materia & "'  ORDER BY Procentaje_Asertivida ASC", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Reporte_Asertividad_Saber")

                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Grupo_Asertividad.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
                MODIFICAR_Generales()

            End If

        End If

        If Control = 15 Then

            'REPORTE SABER "LOS DOS" (3 5 Y 9, 10 y 11) Reporte_Saber_Institucion_Ambitos  
            If codigo_prueba = 3 Then

                Dim DS As New DataSet
                If grupo <> " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Resultados_Saber_3_5_9 WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND Identificacion_Prueba='" & simulacro & "' ORDER BY Mat1Componentes1 DESC, Mat1Componentes2 DESC, Mat1Componentes3 DESC, Mat2Componentes1 DESC, Mat2Componentes2 DESC, Mat2Componentes3 DESC, Mat3Componentes1 DESC, Mat3Componentes2 DESC, Mat3Componentes3 DESC, Mat4Componentes1 DESC, Mat4Componentes2 DESC, Mat4Componentes3 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_3_5_9")
                ElseIf grupo = " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Resultados_Saber_3_5_9 WHERE codigo_colegio='" & variable & "' AND Identificacion_Prueba='" & simulacro & "' ORDER BY Mat1Componentes1 DESC, Mat1Componentes2 DESC, Mat1Componentes3 DESC, Mat2Componentes1 DESC, Mat2Componentes2 DESC, Mat2Componentes3 DESC, Mat3Componentes1 DESC, Mat3Componentes2 DESC, Mat3Componentes3 DESC, Mat4Componentes1 DESC, Mat4Componentes2 DESC, Mat4Componentes3 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_3_5_9")
                End If
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Institucion_Ambitos1_3_5_9.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
                MODIFICAR_Generales()

            ElseIf codigo_prueba = 4 Then

                Dim DS As New DataSet
                If grupo <> " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Resultados_Saber_Decimo_Once WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND Identificacion_Prueba='" & simulacro & "' ORDER BY Mat1Componentes1 DESC, Mat1Componentes2 DESC, Mat1Componentes3 DESC, Mat1Componentes4 DESC, Mat2Componentes1 DESC, Mat2Componentes2 DESC, Mat2Componentes3 DESC, Mat2Componentes4 DESC, Mat3Componentes1 DESC, Mat3Componentes2 DESC, Mat3Componentes3 DESC, Mat3Componentes4 DESC, Mat4Componentes1 DESC, Mat4Componentes2 DESC, Mat4Componentes3 DESC, Mat4Componentes4 DESC, Mat5Componentes1 DESC, Mat5Componentes2 DESC, Mat5Componentes3 DESC, Mat5Componentes4 DESC, Mat6Componentes1 DESC, Mat6Componentes2 DESC, Mat6Componentes3 DESC, Mat6Componentes4 DESC, Mat7Componentes1 DESC, Mat7Componentes2 DESC, Mat7Componentes3 DESC, Mat7Componentes4 DESC, Mat8Componentes1 DESC, Mat8Componentes2 DESC, Mat8Componentes3 DESC, Mat8Componentes4 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                ElseIf grupo = " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Resultados_Saber_Decimo_Once WHERE codigo_colegio='" & variable & "' AND Identificacion_Prueba='" & simulacro & "' ORDER BY Mat1Componentes1 DESC, Mat1Componentes2 DESC, Mat1Componentes3 DESC, Mat1Componentes4 DESC, Mat2Componentes1 DESC, Mat2Componentes2 DESC, Mat2Componentes3 DESC, Mat2Componentes4 DESC, Mat3Componentes1 DESC, Mat3Componentes2 DESC, Mat3Componentes3 DESC, Mat3Componentes4 DESC, Mat4Componentes1 DESC, Mat4Componentes2 DESC, Mat4Componentes3 DESC, Mat4Componentes4 DESC, Mat5Componentes1 DESC, Mat5Componentes2 DESC, Mat5Componentes3 DESC, Mat5Componentes4 DESC, Mat6Componentes1 DESC, Mat6Componentes2 DESC, Mat6Componentes3 DESC, Mat6Componentes4 DESC, Mat7Componentes1 DESC, Mat7Componentes2 DESC, Mat7Componentes3 DESC, Mat7Componentes4 DESC, Mat8Componentes1 DESC, Mat8Componentes2 DESC, Mat8Componentes3 DESC, Mat8Componentes4 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                End If
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Institucion_Ambitos1.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
                MODIFICAR_Generales()

            End If
        End If

        If Control = 16 Then
            'REPORTE SABER "LOS DOS" (3 5 Y 9, 10 y 11) Reporte_Saber_Institucion_Ambitos  

            If codigo_prueba = 3 Then

                'Dim grado As String
                'Dim DB As New OleDb.OleDbDataAdapter("SELECT  grado FROM grupos WHERE codigo_grupo='" & grupo & "' AND codigo_colegios='" & variable & "'", CN)
                'Dim DQ As New DataSet
                'DB.Fill(DQ, "grupo")
                'grado = DQ.Tables(0).Rows(0).Item(0).ToString

                Dim DS As New DataSet
                If grupo <> " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Resultados_Saber_3_5_9 WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND Identificacion_Prueba='" & simulacro & "' ORDER BY Mat1Competencia1 DESC, Mat1Competencia2 DESC, Mat1Competencia3 DESC, Mat2Competencia1 DESC, Mat2Competencia2 DESC, Mat2Competencia3 DESC, Mat3Competencia1 DESC, Mat3Competencia2 DESC, Mat3Competencia3 DESC, Mat4Competencia1 DESC, Mat4Competencia2 DESC, Mat4Competencia3 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_3_5_9")
                ElseIf grupo = " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Resultados_Saber_3_5_9 WHERE codigo_colegio='" & variable & "' AND Identificacion_Prueba='" & simulacro & "' ORDER BY Mat1Competencia1 DESC, Mat1Competencia2 DESC, Mat1Competencia3 DESC, Mat2Competencia1 DESC, Mat2Competencia2 DESC, Mat2Competencia3 DESC, Mat3Competencia1 DESC, Mat3Competencia2 DESC, Mat3Competencia3 DESC, Mat4Competencia1 DESC, Mat4Competencia2 DESC, Mat4Competencia3 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_3_5_9")
                End If
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Institucion_Competencias1_3_5_9.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport

                MODIFICAR_Generales()
            ElseIf codigo_prueba = 4 Then

                Dim DS As New DataSet
                If grupo <> " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Resultados_Saber_Decimo_Once WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND Identificacion_Prueba='" & simulacro & "' ORDER BY Mat1Competencia1 DESC, Mat1Competencia2 DESC, Mat1Competencia3 DESC, Mat2Competencia1 DESC, Mat2Competencia2 DESC, Mat2Competencia3 DESC, Mat3Competencia1 DESC, Mat3Competencia2 DESC, Mat3Competencia3 DESC, Mat4Competencia1 DESC, Mat4Competencia2 DESC, Mat4Competencia3 DESC, Mat5Competencia1 DESC, Mat5Competencia2 DESC, Mat5Competencia3 DESC, Mat6Competencia1 DESC, Mat6Competencia2 DESC, Mat6Competencia3 DESC, Mat7Competencia1 DESC, Mat7Competencia2 DESC, Mat7Competencia3 DESC, Mat8Competencia1 DESC, Mat8Competencia2 DESC, Mat8Competencia3 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                ElseIf grupo = " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Resultados_Saber_Decimo_Once WHERE codigo_colegio='" & variable & "' AND Identificacion_Prueba='" & simulacro & "' ORDER BY Mat1Competencia1 DESC, Mat1Competencia2 DESC, Mat1Competencia3 DESC, Mat2Competencia1 DESC, Mat2Competencia2 DESC, Mat2Competencia3 DESC, Mat3Competencia1 DESC, Mat3Competencia2 DESC, Mat3Competencia3 DESC, Mat4Competencia1 DESC, Mat4Competencia2 DESC, Mat4Competencia3 DESC, Mat5Competencia1 DESC, Mat5Competencia2 DESC, Mat5Competencia3 DESC, Mat6Competencia1 DESC, Mat6Competencia2 DESC, Mat6Competencia3 DESC, Mat7Competencia1 DESC, Mat7Competencia2 DESC, Mat7Competencia3 DESC, Mat8Competencia1 DESC, Mat8Competencia2 DESC, Mat8Competencia3 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                End If
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Institucion_Competencias1.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport

                MODIFICAR_Generales()
            End If

        End If


        If Control = 17 Then
            'REPORTE SABER "LOS DOS" (3 5 Y 9, 10 y 11) Reporte_Saber_Institucion_Acumulado_Pruebas 
            If codigo_prueba = 3 Then

                Dim DS As New DataSet
                If grupo <> " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Reporte_Acumulado_Simulacros_3_5_9 WHERE codigo_colegio='" & variable & "' AND codigo_gupo='" & grupo & "' ORDER BY acumulado DESC", CN)
                    DA.Fill(DS, "Reporte_Acumulado_Simulacros_3_5_9")
                ElseIf grupo = " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Reporte_Acumulado_Simulacros_3_5_9 WHERE codigo_colegio='" & variable & "' ORDER BY acumulado DESC", CN)
                    DA.Fill(DS, "Reporte_Acumulado_Simulacros_3_5_9")
                End If
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Institucion_Acumulado_Pruebas_3_5_9.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport

                MODIFICAR_Generales()
            ElseIf codigo_prueba = 4 Then

                Dim DS As New DataSet
                If grupo <> " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Reporte_Acumulado_Simulacros WHERE codigo_colegio='" & variable & "' AND codigo_gupo='" & grupo & "' ORDER BY acumulado DESC", CN)
                    DA.Fill(DS, "Reporte_Acumulado_Simulacros")
                ElseIf grupo = " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Reporte_Acumulado_Simulacros WHERE codigo_colegio='" & variable & "' ORDER BY acumulado DESC", CN)
                    DA.Fill(DS, "Reporte_Acumulado_Simulacros")
                End If
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Institucion_Acumulado_Pruebas.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport

            End If
        End If


        If Control = 18 Then

            ' REPORTE NIVELES DE PENSAMIENTO Y ESTILOS DE APRENDIZAJE  INDIVIDUALES
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultado_Estudiante WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "Resultado_Estudiante")
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("\\Sistemas3\d\reportes\Todos_resultados.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport
            MODIFICAR()

        End If

        If Control = 19 Then
            ' REPORTE NIVELES DE PENSAMIENTO Y ESTILOS DE APRENDIZAJE  INDIVIDUALES
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Formato_Examen WHERE sesion='1' AND codigo='" & simulacro & "' ORDER BY pregunta ASC", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "Formato_Examen")
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("\\Sistemas3\d\reportes\Reporte_Simulacros_Creados.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport
        End If

        If Control = 20 Then

            If codigo_prueba = 4 Then

                Dim DS As New DataSet
                If grupo <> " " And grado = Nothing Then
                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Lectura.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Lectura.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf grado <> " " And grupo = Nothing Then

                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Sa ber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Lectura.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Lectura.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf grupo = " " And grado = Nothing Then

                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Institucion_Promedios_Generales_Lectura.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Institucion_Promedios_Generales_Lectura.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                End If
                MODIFICAR_Generales()
            ElseIf codigo_prueba = 3 Then

                If simulacro = "146" Or simulacro = "156" Or simulacro = "158" Then
                    Dim DS As New DataSet
                    If grupo <> " " And grado = Nothing Then

                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grado <> " " And grupo = Nothing Then

                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Reporte_Saber_Institucion_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf simulacro = "151" Then

                    Dim DS As New DataSet
                    If grupo <> " " And grado = Nothing Then

                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grado <> " " And grupo = Nothing Then

                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Reporte_Saber_Institucion_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If


                ElseIf simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then

                    Dim DS As New DataSet
                    Dim TIPO As String
                    Dim DL As New OleDb.OleDbDataAdapter("SELECT orden FROM Formato_Examen_Cantidad WHERE codigo='" & simulacro & "' AND materia='LENGUAJE'", CN)
                    Dim DT As New DataSet
                    DL.Fill(DT, "Formato_Examen_Cantidad")
                    TXTTIPO.Text = DT.Tables(0).Rows(0).Item(0).ToString
                    TIPO = TXTTIPO.Text

                    If TIPO = "1" Then
                        If grupo <> " " And grado = Nothing Then
                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat1 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport

                        ElseIf grado <> " " And grupo = Nothing Then

                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat1 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        ElseIf grupo = " " And grado = Nothing Then
                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat1 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales_Lenguaje.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        End If
                    ElseIf TIPO = "2" Then
                        If grupo <> " " And grado = Nothing Then

                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat2 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        ElseIf grado <> " " And grupo = Nothing Then

                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat2 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        ElseIf grupo = " " And grado = Nothing Then
                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat2 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        End If
                    End If
                Else
                    Dim DS As New DataSet
                    If grupo <> " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport

                    ElseIf grado <> " " And grupo = Nothing Then

                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then

                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Institucion_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                End If

            ElseIf codigo_prueba = 11 Then

                Dim DS As New DataSet

                If grupo <> " " And grado = Nothing Then

                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

                    If Dba = 0 Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND fecha='" & fechaFinal & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                            CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Grupo_Promedios_Generales_Lectura.rpt")
                        Else
                            CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Lectura.rpt")
                        End If
                    Else
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once_Dba WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND fecha='" & fechaFinal & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once_Dba")
                        If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                        Else
                            CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Lectura_Dba.rpt")
                        End If
                    End If

                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport

                ElseIf grado <> " " And grupo = Nothing Then
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    If Dba = 0 Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' AND fecha='" & fechaFinal & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        If grado = "PREJARDÍN" Or grado = "JARDÍN" Or grado = "TRANSICIÓN" Then
                            CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Grupo_Promedios_Generales_Lectura.rpt")
                        Else
                            CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Lectura.rpt")
                        End If
                    Else
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once_Dba WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' AND fecha='" & fechaFinal & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once_Dba")
                        If grado = "PREJARDÍN" Or grado = "JARDÍN" Or grado = "TRANSICIÓN" Then
                        Else
                            CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Lectura_Dba.rpt")
                        End If
                    End If
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                ElseIf grupo = " " And grado = Nothing Then

                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

                    If Dba = 0 Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND fecha='" & fechaFinal & "'  ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                            CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Institucion_Promedios_Generales_Lectura.rpt")
                        Else
                            CrReport.Load("\\Sistemas3\d\reportes\tusaber\cincomaterias\Reporte_Saber_Institucion_Promedios_Generales_Lectura.rpt")
                        End If
                    Else
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once_Dba WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND fecha='" & fechaFinal & "'  ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once_Dba")
                        If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                        Else
                            CrReport.Load("\\Sistemas3\d\reportes\tusaber\cincomaterias\Reporte_Saber_Institucion_Promedios_Generales_Lectura_Dba.rpt")
                        End If
                    End If

                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                End If
            End If
        End If

        If Control = 21 Then

            If codigo_prueba = 4 Then
                Dim DS As New DataSet
                If grupo <> " " And grado = Nothing Then

                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf grado <> " " And grupo = Nothing Then

                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf grupo = " " And grado = Nothing Then

                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                End If

            ElseIf codigo_prueba = 3 Then

                If simulacro = "146" Or simulacro = "156" Or simulacro = "158" Then

                    Dim DS As New DataSet
                    If grupo <> " " And grado = Nothing Then

                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grado <> " " And grupo = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf simulacro = "151" Then

                    Dim DS As New DataSet
                    If grupo <> " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grado <> " " And grupo = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If


                ElseIf simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then

                    Dim DS As New DataSet

                    Dim TIPO As String
                    Dim DL As New OleDb.OleDbDataAdapter("SELECT orden FROM Formato_Examen_Cantidad WHERE codigo='" & simulacro & "' AND materia='LENGUAJE'", CN)
                    Dim DT As New DataSet
                    DL.Fill(DT, "Formato_Examen_Cantidad")
                    TXTTIPO.Text = DT.Tables(0).Rows(0).Item(0).ToString
                    TIPO = TXTTIPO.Text

                    If TIPO = "1" Then
                        If grupo <> " " And grado = Nothing Then
                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat2 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        ElseIf grado <> " " And grupo = Nothing Then
                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat2 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        ElseIf grupo = " " And grado = Nothing Then
                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat2 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        End If

                    ElseIf TIPO = "2" Then

                        If grupo <> " " And grado = Nothing Then
                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat1 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        ElseIf grado <> " " And grupo = Nothing Then
                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat1 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        ElseIf grupo = " " And grado = Nothing Then
                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat1 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales_Lenguaje.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        End If

                    End If

                Else

                    Dim DS As New DataSet
                    If grupo <> " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grado <> " " And grupo = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                End If
  
            ElseIf codigo_prueba = 11 Then

                Dim DS As New DataSet

                If grupo <> " " And grado = Nothing Then

                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

                    If Dba = 0 Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND fecha='" & fechaFinal & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                            CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        Else
                            CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        End If
                    Else
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once_Dba WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND fecha='" & fechaFinal & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once_Dba")
                        If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                        Else
                            CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Matematicas_Dba.rpt")
                        End If
                    End If

                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport

                ElseIf grado <> " " And grupo = Nothing Then

                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

                    If Dba = 0 Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' AND fecha='" & fechaFinal & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")

                        If grado = "PREJARDÍN" Or grado = "JARDÍN" Or grado = "TRANSICIÓN" Then
                            CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        Else
                            CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Matematicas.rpt")
                        End If
                    Else
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once_Dba WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' AND fecha='" & fechaFinal & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once_Dba")

                        If grado = "PREJARDÍN" Or grado = "JARDÍN" Or grado = "TRANSICIÓN" Then
                        Else
                            CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Matematicas_Dba.rpt")
                        End If
                    End If

                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                ElseIf grupo = " " And grado = Nothing Then

                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

                    If Dba = 0 Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND fecha='" & fechaFinal & "'  ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")

                        If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                            CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                        Else
                            CrReport.Load("\\Sistemas3\d\reportes\tusaber\cincomaterias\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                        End If
                    Else
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once_Dba WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND fecha='" & fechaFinal & "'  ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once_Dba")

                        If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                        Else
                            CrReport.Load("\\Sistemas3\d\reportes\tusaber\cincomaterias\Reporte_Saber_Institucion_Promedios_Generales_Matematicas_Dba.rpt")
                        End If
                    End If

                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                End If

            End If

            MODIFICAR_Generales()
        End If

        If Control = 22 Then

            If codigo_prueba = 4 Then

                Dim DS As New DataSet
                If grupo <> " " And grado = Nothing Then
                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                ElseIf grado <> " " And grupo = Nothing Then
                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                ElseIf grupo = " " And grado = Nothing Then

                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Institucion_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Institucion_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                End If

            ElseIf codigo_prueba = 3 Then

                Dim DS As New DataSet

                If simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then
                    If grupo <> " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grado <> " " And grupo = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                Else
                    If grupo <> " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grupo_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grado <> " " And grupo = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grupo_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Institucion_Promedios_Generales_Naturales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                End If

            ElseIf codigo_prueba = 11 Then

                Dim DS As New DataSet
                If grupo <> " " And grado = Nothing Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND fecha='" & fechaFinal & "' ORDER BY proMat4 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Naturales.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport

                ElseIf grado <> " " And grupo = Nothing Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' AND fecha='" & fechaFinal & "' ORDER BY proMat4 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Naturales.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                ElseIf grupo = " " And grado = Nothing Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND fecha='" & fechaFinal & "'  ORDER BY proMat4 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\tusaber\cincomaterias\Reporte_Saber_Institucion_Promedios_Generales_Naturales.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                End If

            End If

            MODIFICAR_Generales()
        End If


        If Control = 23 Then

            If codigo_prueba = 4 Then
                Dim DS As New DataSet
                If grupo <> " " And grado = Nothing Then

                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat5 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Sociales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat5 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Sociales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf grado <> " " And grupo = Nothing Then

                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat5 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Sociales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat5 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Sociales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                ElseIf grupo = " " And grado = Nothing Then

                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat5 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Institucion_Promedios_Generales_Sociales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat5 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Institucion_Promedios_Generales_Sociales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport

                    End If

                End If
            ElseIf codigo_prueba = 3 Then

                Dim DS As New DataSet

                If simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then

                    If grupo <> " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Competencias_Cidudanas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grado <> " " And grupo = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Competencias_Cidudanas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales_Competencias_Cidudanas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                Else

                    If grupo <> " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grupo_Promedios_Generales_Competencias_Cidudanas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grado <> " " And grupo = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grupo_Promedios_Generales_Competencias_Cidudanas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Institucion_Promedios_Generales_Competencias_Cidudanas.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                End If

            ElseIf codigo_prueba = 11 Then

                Dim DS As New DataSet
                If grupo <> " " And grado = Nothing Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND fecha='" & fechaFinal & "' ORDER BY proMat3 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

                    If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                        CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Grupo_Promedios_Generales_Sociales.rpt")
                    Else
                        CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Sociales.rpt")
                    End If

                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport

                ElseIf grado <> " " And grupo = Nothing Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' AND fecha='" & fechaFinal & "' ORDER BY proMat3 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    If grado = "PREJARDÍN" Or grado = "JARDÍN" Or grado = "TRANSICIÓN" Then
                        CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Grupo_Promedios_Generales_Sociales.rpt")
                    Else
                        CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Sociales.rpt")
                    End If
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                ElseIf grupo = " " And grado = Nothing Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND fecha='" & fechaFinal & "'  ORDER BY proMat3 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    If simulacro = "200" Or simulacro = "201" Or simulacro = "202" Then
                        CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Institucion_Promedios_Generales_Sociales.rpt")
                    Else
                        CrReport.Load("\\Sistemas3\d\reportes\tusaber\cincomaterias\Reporte_Saber_Institucion_Promedios_Generales_Sociales.rpt")
                    End If
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                End If

            End If

            MODIFICAR_Generales()
        End If

        If Control = 24 Then

            If codigo_prueba = 4 Then
                Dim DS As New DataSet
                If grupo <> " " And grado = Nothing Then
                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Ingles.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Ingles.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                ElseIf grado <> " " And grupo = Nothing Then
                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Ingles.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Ingles.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                ElseIf grupo = " " And grado = Nothing Then
                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Institucion_Promedios_Generales_Ingles.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport

                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Institucion_Promedios_Generales_Ingles.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport

                    End If
                End If
                MODIFICAR_Generales()

            ElseIf codigo_prueba = 3 Then

                Dim DS As New DataSet
                If simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then
                    If grupo <> " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proMat5 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Economica_Financiera.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grado <> " " And grupo = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' ORDER BY proMat5 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Economica_Financiera.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf grupo = " " And grado = Nothing Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "'  ORDER BY proMat5 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales_Economica_Financiera.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                End If

            ElseIf codigo_prueba = 11 Then

                Dim DS As New DataSet
                If grupo <> " " And grado = Nothing Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' AND fecha='" & fechaFinal & "' ORDER BY proMat5 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Ingles.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport

                ElseIf grado <> " " And grupo = Nothing Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grado & "' AND fecha='" & fechaFinal & "' ORDER BY proMat5 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\\reportes\tusaber\cincomaterias\Reporte_Saber_Grupo_Promedios_Generales_Ingles.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                ElseIf grupo = " " And grado = Nothing Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND fecha='" & fechaFinal & "'  ORDER BY proMat5 DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\tusaber\cincomaterias\Reporte_Saber_Institucion_Promedios_Generales_Ingles.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                End If

            End If

        End If

        If Control = 25 Then

            If codigo_prueba = 1 Then

                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultado_Estudiante WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Resultado_Estudiante")

                'DataGridView1.DataSource = DS.Tables("Notas_Grupo")
                'Dim REPORTAR As New npensamiento
                'REPORTAR.SetDataSource(DS)
                'CrystalReportViewer1.ReportSource = REPORTAR

                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Todos_resultados.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
                MODIFICAR()

            ElseIf codigo_prueba = 2 Then


                ' REPORTE NIVELES DE PENSAMIENTO Y ESTILOS DE APRENDIZAJE  INDIVIDUALES
                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Perfil_Profesional_Individuales WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Resultados_Perfil_Profesional_Individuales")
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Perfil_Profesional_Individuales.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport

                MODIFICAR()


            ElseIf codigo_prueba = 3 Then

                ' FALTA CUADRAR LA TABLA DE LOS RESULTADOS..............
                'Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_3_5_9 WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'", CN)
                'Dim DS As New DataSet
                'DA.Fill(DS, "Resultados_Saber_3_5_9")
                'Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                'CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                'CrReport.Load("\\Sistemas3\d\reportes\Resultados_Saber_3_5_9.rpt")
                'CrReport.SetDataSource(DS)
                'CrystalReportViewer1.ReportSource = CrReport
                'MODIFICAR()

                If simulacro = "146" Or simulacro = "156" Or simulacro = "158" Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Resultados_Saber_Decimo_Once_Noveno.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                ElseIf simulacro = "151" Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Resultados_Saber_Decimo_Once_Noveno.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()

                ElseIf simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Resultados_Saber_Decimo_Once_Noveno.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()

                Else
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Resultados_Saber_Decimo_Once_Noveno.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                End If

            ElseIf codigo_prueba = 4 Then

                If simulacro = "142" Or simulacro = "141" Then
                    'Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Resultados_Saber_Decimo_Once.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()

                ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                    'Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Resultados_Saber_Decimo_Once.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                End If

            End If

        End If

        If Control = 26 Then

            If codigo_prueba = 2 Then

                Dim DS As New DataSet

                If grupo <> " " Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Perfil_Profesional_Individuales WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY Ptj_Artistico DESC, Ptj_Numerico DESC, Ptj_Social DESC, Ptj_Mecanico DESC, Ptj_Cientifico DESC, Ptj_Literario DESC", CN)
                    DA.Fill(DS, "Resultados_Perfil_Profesional_Individuales")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Reporte_Perfil_Profesional_Grupo_Promedios_Generales.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport

                ElseIf grupo = " " Then

                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Perfil_Profesional_Individuales WHERE codigo_colegio='" & variable & "' ORDER BY Ptj_Artistico DESC, Ptj_Numerico DESC, Ptj_Social DESC, Ptj_Mecanico DESC, Ptj_Cientifico DESC, Ptj_Literario DESC", CN)
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Reporte_Perfil_Profesional_Institucion_Promedios_Generales.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport

                End If

                MODIFICAR_Generales()

            ElseIf codigo_prueba = 3 Then

                Dim DS As New DataSet
                If simulacro = "146" Or simulacro = "156" Or simulacro = "158" Then

                    If grupo <> " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0

                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Reporte_Saber_Grado_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport

                        MODIFICAR_Generales()
                    End If

                ElseIf simulacro = "151" Then

                    If grupo <> " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0

                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Reporte_Saber_Grado_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport

                        MODIFICAR_Generales()
                    End If


                ElseIf simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then

                    If grupo <> " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0

                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grado_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport

                        MODIFICAR_Generales()
                    End If
                Else
                    If grupo <> " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proTotal DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0

                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grado_Promedios_Generales.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                        MODIFICAR_Generales()
                    End If
                End If

                MODIFICAR_Generales()

            ElseIf codigo_prueba = 4 Then
                'REPORTE SABER "LOS DOS" ( 10 y 11)
                Dim DS As New DataSet
                If grupo <> " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "'   ORDER BY proTotal DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0

                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Reporte_Saber_Grado_Promedios_Generales.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport

                    MODIFICAR_Generales()
                End If

            ElseIf codigo_prueba = 11 Then

                Dim DS As New DataSet
                If grupo <> " " Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' AND fecha='" & fechaFinal & "' ORDER BY proTotal DESC", CN)
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim tipo As Integer = 0

                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

                    If grupo = "PREJARDÍN" Or grupo = "JARDÍN" Or grupo = "TRANSICIÓN" Then
                        CrReport.Load("\\Sistemas3\d\reportes\tusaber\tresmaterias\Reporte_Saber_Grado_Promedios_Generales.rpt")
                    Else
                        CrReport.Load("\\Sistemas3\d\reportes\tusaber\cincomaterias\Reporte_Saber_Grado_Promedios_Generales.rpt")
                    End If

                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport

                    MODIFICAR_Generales()
                End If

            End If

        End If

        If Control = 27 Then

            If codigo_prueba = 1 Then

                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultado_Estudiante WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Resultado_Estudiante")
                'DataGridView1.DataSource = DS.Tables("Notas_Grupo")
                'Dim REPORTAR As New npensamiento
                'REPORTAR.SetDataSource(DS)
                'CrystalReportViewer1.ReportSource = REPORTAR

                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Todos_resultados.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
                MODIFICAR()

            ElseIf codigo_prueba = 2 Then
                ' REPORTE NIVELES DE PENSAMIENTO Y ESTILOS DE APRENDIZAJE  INDIVIDUALES
                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Perfil_Profesional_Individuales WHERE codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Resultados_Perfil_Profesional_Individuales")
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("\\Sistemas3\d\reportes\Reporte_Perfil_Profesional_Individuales.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
                MODIFICAR()
            ElseIf codigo_prueba = 3 Then
                If simulacro = "146" Or simulacro = "156" Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Resultados_Saber_Decimo_Once_Noveno.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                ElseIf simulacro = "151" Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Fondo\Resultados_Saber_Decimo_Once_Noveno.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                ElseIf simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "'   ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Resultados_Saber_Decimo_Once_Noveno.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                Else
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Resultados_Saber_Decimo_Once.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                End If
            ElseIf codigo_prueba = 4 Then

                If simulacro = "142" Or simulacro = "141" Then
                    ' PRIMER SIMULACRO
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Fondo\Resultados_Saber_Decimo_Once.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                    'SEGUNDO SIMULACRO
                    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND codigo_grupo='" & grupo & "' ORDER BY proTotal", CN)
                    Dim DS As New DataSet
                    DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                    CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Fondo\Resultados_Saber_Decimo_Once.rpt")
                    CrReport.SetDataSource(DS)
                    CrystalReportViewer1.ReportSource = CrReport
                    MODIFICAR()
                End If
            End If
        End If

        If Control = 28 Then
            ' Reportes por grado Lectura Crítica
            If codigo_prueba = 4 Then
                Dim DS As New DataSet
                If grupo <> " " Then
                    If simulacro = "142" Or simulacro = "141" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Primer_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Lectura.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    ElseIf simulacro = "143" Or simulacro = "148" Or simulacro = "149" Or simulacro = "150" Or simulacro = "158" Or simulacro = "164" Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proMat4 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Segundo_Simulacro\Reporte_Saber_Grupo_Promedios_Generales_Lectura.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                End If
                MODIFICAR_Generales()

            ElseIf codigo_prueba = 3 Then

                If simulacro = "146" Or simulacro = "156" Or simulacro = "158" Then

                    Dim DS As New DataSet
                    If grupo <> " " Then

                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proMat3 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Tercero\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If

                ElseIf simulacro = "151" Then

                    Dim DS As New DataSet
                    If grupo <> " " Then

                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proMat1 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_4\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If


                ElseIf simulacro = "152" Or simulacro = "153" Or simulacro = "154" Or simulacro = "155" Or simulacro = "161" Or simulacro = "162" Or simulacro = "163" Then

                    Dim DS As New DataSet
                    Dim TIPO As String
                    Dim DL As New OleDb.OleDbDataAdapter("SELECT orden FROM Formato_Examen_Cantidad WHERE codigo='" & simulacro & "' AND materia='LENGUAJE'", CN)
                    Dim DT As New DataSet
                    DL.Fill(DT, "Formato_Examen_Cantidad")
                    TXTTIPO.Text = DT.Tables(0).Rows(0).Item(0).ToString
                    TIPO = TXTTIPO.Text

                    If TIPO = "1" Then
                        If grupo <> " " Then
                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proMat1 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        End If
                    ElseIf TIPO = "2" Then
                        If grupo <> " " Then

                            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proMat2 DESC", CN)
                            DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                            CrReport.Load("\\Sistemas3\d\reportes\Simulacro_6_7_8\Reporte_Saber_Institucion_Promedios_Generales_Matematicas.rpt")
                            CrReport.SetDataSource(DS)
                            CrystalReportViewer1.ReportSource = CrReport
                        End If
                    End If
                Else
                    Dim DS As New DataSet
                    If grupo <> " " Then
                        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Resultados_Saber_Decimo_Once WHERE Identificacion_Prueba='" & simulacro & "' AND  codigo_colegio='" & variable & "' AND grado='" & grupo & "' ORDER BY proMat2 DESC", CN)
                        DA.Fill(DS, "Resultados_Saber_Decimo_Once")
                        Dim tipo As Integer = 0
                        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        CrReport.Load("\\Sistemas3\d\reportes\Simulacro_Noveno\Reporte_Saber_Grupo_Promedios_Generales_Lenguaje.rpt")
                        CrReport.SetDataSource(DS)
                        CrystalReportViewer1.ReportSource = CrReport
                    End If
                End If
            End If

        End If







    End Sub


    Sub MODIFICAR()
        Dim PEPE As Date
        PEPE = DateTimePicker1.Value
        PEPE = Format(PEPE, "dd/MM/yyyy")
        Dim CMD As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Impresion_Individuales='" & PEPE & "'  WHERE Codigo_Colegio='" & variable & "'AND Grupo='" & grupo & "'", CN)
        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        'MsgBox("Actualizado en la base de datos")
    End Sub


    Sub MODIFICAR_Sabanas()
        Dim PEPE As Date
        PEPE = DateTimePicker1.Value
        PEPE = Format(PEPE, "dd/MM/yyyy")
        Dim CMD As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Impresion_Sabanas='" & PEPE & "'  WHERE Codigo_Colegio='" & variable & "'AND Grupo='" & grupo & "'", CN)
        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        'MsgBox("Actualizado en la base de datos")
    End Sub

    Sub MODIFICAR_Generales()
        Dim PEPE As Date
        PEPE = DateTimePicker1.Value
        PEPE = Format(PEPE, "dd/MM/yyyy")
        Dim CMD As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Impresion_Generales='" & PEPE & "'  WHERE Codigo_Colegio='" & variable & "'AND Grupo='" & grupo & "'", CN)
        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
    End Sub

    Private Sub Estudiantes_Colegio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CRYSTAL_REPORT()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
    End Sub

End Class