Public Class Calificar_examenes

    Public usuario As String
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdministrarEstudianteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrarEstudianteToolStripMenuItem1.Click

        Dim MDIForm As New Registrar_Estudiantes
        MDIForm.MdiParent = Me
        MDIForm.Show()

        'Dim MDIForm As New Administrar_estudiantes
        'MDIForm.MdiParent = Me
        'MDIForm.Show()
    End Sub

    Private Sub Calificar_examenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LABELUSUARIO.Text = usuario.ToUpper

        My.Settings.usuario = 1
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub NIVELESDEPENSAMIENTOYESTILOSDEAPRENDIZAJEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MDIForm As New Niveles_pensamiento
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub RegistrarExamenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarExamenesToolStripMenuItem.Click
        'Dim MDIForm As New Registrar_Examenes
        'MDIForm.MdiParent = Me
        'MDIForm.Show()
    End Sub


    Private Sub RegistraColegioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistraColegioToolStripMenuItem.Click
        Dim MDIForm As New Registrar_Colegio
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub


    Private Sub ActualizarMatriculaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarMatriculaToolStripMenuItem1.Click
        Dim MDIForm As New Actualizar_Matricula
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub BuscarEstudianteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarEstudianteToolStripMenuItem.Click
        Dim MDIForm As New Buscar_Estudiante
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub AnalizarExamenesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalizarExamenesToolStripMenuItem1.Click
        Shell("analizador.exe", AppWinStyle.NormalFocus)

    End Sub

    Private Sub CalificarExamenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalificarExamenesToolStripMenuItem.Click
        Dim MDIForm As New Niveles_pensamiento
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub ColegioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColegioToolStripMenuItem1.Click
        Dim MDIForm As New Llamar_Reporte_Estudiantes
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GrupoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoToolStripMenuItem1.Click
        Dim MDIForm As New Llamar_Reporte_Grupos
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub ControlMaterialToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlMaterialToolStripMenuItem1.Click
        Dim MDIForm As New Llamar_Reporte_Material
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub ListarAsistenciaClasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarAsistenciaClasesToolStripMenuItem.Click
        Dim MDIForm As New Listar_Asistencia_Clase
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub ListarAsistenciaSimulacroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarAsistenciaSimulacroToolStripMenuItem.Click
        Dim MDIForm As New LLamar_Reporte_Simulacro_manual
        MDIForm.MdiParent = Me

        MDIForm.Show()
    End Sub

    Private Sub ImprimirResultadosEstudiantesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MDIForm As New Mostrar_Reporte_Estudiante
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub SimulacrosPresentadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimulacrosPresentadosToolStripMenuItem.Click
        Dim MDIForm As New Simulacros_Presentados
        MDIForm.MdiParent = Me
        MDIForm.Show()

    End Sub

    Private Sub NotasGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MDIForm As New Notras_Grupo
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub NotasColegioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MDIForm As New Reporte_Grupo_Promedios_Niveles_Pensamiento
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub ImprimirResultadosTodosLosEstudiantesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MDIForm As New Imprimir_Todos
        MDIForm.MdiParent = Me
        MDIForm.Show()

    End Sub

    Private Sub ReportarIngresoPruebasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarIngresoPruebasToolStripMenuItem.Click
        Dim MDIForm As New Reportar_Ingreso_Pruebas
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub ReportarEscaneoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarEscaneoToolStripMenuItem.Click
        Dim MDIForm As New Reportar_Escaneadas
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub ReportarSalidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarSalidaToolStripMenuItem.Click
        Dim MDIForm As New Reportar_Salida
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim MDIForm As New Crear_Simulacro
        MDIForm.MdiParent = Me
        MDIForm.Show()

    End Sub

    Private Sub ControlCalificacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlCalificacionToolStripMenuItem.Click
        Dim MDIForm As New Control_Calificacion
        MDIForm.MdiParent = Me
        MDIForm.Show()

    End Sub

    Private Sub IndividualesToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualesToolStripMenuItem3.Click
        Dim MDIForm As New Reporte_Saber_Individuales_Lectura
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub PromediosGeneralesToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromediosGeneralesToolStripMenuItem6.Click
        Dim MDIForm As New Reporte_Saber_Grupo_Promedios_Generales
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub AmbitosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmbitosToolStripMenuItem2.Click
        Dim MDIForm As New Reporte_Saber_Grupo_Ambitos
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub CompetenciasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompetenciasToolStripMenuItem2.Click
        Dim MDIForm As New Reporte_Saber_Grupo_Competencias
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub AsertividadToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsertividadToolStripMenuItem2.Click
        Dim MDIForm As New Reporte_Saber_Grupo_Asertividad
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub AcumuladoDeVariasPruebasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcumuladoDeVariasPruebasToolStripMenuItem1.Click
        Dim MDIForm As New Reporte_Saber_Grupo_Acumulado_Pruebas
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub PromediosGeneralesToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromediosGeneralesToolStripMenuItem7.Click
        Dim MDIForm As New Reporte_Saber_Institucion_Promedios_Generales
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub AmbitosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmbitosToolStripMenuItem3.Click
        Dim MDIForm As New Reporte_Saber_Institucion_Ambitos
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub CompetenciasToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompetenciasToolStripMenuItem3.Click
        Dim MDIForm As New Reporte_Saber_Institucion_Competencias
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub AsertividadToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsertividadToolStripMenuItem3.Click
        Dim MDIForm As New Reporte_Saber_Institucion_Asertividad
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub AcumuladoDeVariasPruebasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcumuladoDeVariasPruebasToolStripMenuItem2.Click
        Dim MDIForm As New Reporte_Saber_Institucion_Acumulado_Pruebas
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub IndividualesToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualesToolStripMenuItem5.Click
        Dim MDIForm As New Reporte_Niveles_Estilos_Individuales
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub PromediosNivelesDePensamientoToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromediosNivelesDePensamientoToolStripMenuItem3.Click
        'institucion
        Dim MDIForm As New Reporte_Institucion_Promedios_Niveles_Pensamiento
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub PromediosNivelesDePensamientoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromediosNivelesDePensamientoToolStripMenuItem2.Click
        'grupo
        Dim MDIForm As New Reporte_Grupo_Promedios_Niveles_Pensamiento
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub EstudianteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstudianteToolStripMenuItem.Click
        ' REPORTE POR ESTUDIANTE INDIVIDUAL
        Dim MDIForm As New Mostrar_Reporte_Estudiante
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub SimulacrosCreadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimulacrosCreadosToolStripMenuItem.Click
        ' REPORTE SIMULACROS CREADOS
        Dim MDIForm As New Reporte_Simulacros_Creados
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub IndividualesToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualesToolStripMenuItem4.Click
        Dim MDIForm As New Reporte_Perfil_Profesional_Individuales
        MDIForm.MdiParent = Me
        MDIForm.Show()

    End Sub

    Private Sub PromediosGeneralesToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromediosGeneralesToolStripMenuItem5.Click
        Dim MDIForm As New Reporte_Perfil_Profesional_Institucion_Promedios_Generales
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub PromediosGeneralesToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromediosGeneralesToolStripMenuItem4.Click
        Dim MDIForm As New Reporte_Perfil_Profesional_Grupo_Promedios_Generales
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub PromediosEstilosDeAprendizajeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromediosEstilosDeAprendizajeToolStripMenuItem2.Click
        'Dim MDIForm As New Reporte_Grupo_Promedios_Niveles_Pensamiento
        ' MDIForm.MdiParent = Me
        'MDIForm.Show()
    End Sub

    Private Sub PromediosEstilosDeAprendizajeToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromediosEstilosDeAprendizajeToolStripMenuItem3.Click
        'Dim MDIForm As New Reporte_Perfil_Profesional_Grupo_Promedios_Generales
        'MDIForm.MdiParent = Me
        'MDIForm.Show()
    End Sub

    Private Sub GeneralesLecturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MDIForm As New Reporte_Saber_Individuales_Lectura
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub


    Private Sub LecturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LecturaToolStripMenuItem.Click
        Dim MDIForm As New LECTURA
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesMatematicasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesMatematicasToolStripMenuItem.Click
        Dim MDIForm As New MATEMATICAS
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesCienciasNaturalesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesCienciasNaturalesToolStripMenuItem1.Click
        Dim MDIForm As New CIENCIAS_NATURALES
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesSocialesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesSocialesToolStripMenuItem1.Click
        Dim MDIForm As New SOCIALES
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub


    Private Sub GeneralesInglesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesInglesToolStripMenuItem1.Click
        Dim MDIForm As New INGLES
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesLecturaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesLecturaToolStripMenuItem.Click
        Dim MDIForm As New LECTURA_GRUPOS
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesMatematicasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesMatematicasToolStripMenuItem1.Click
        Dim MDIForm As New MATEMATICAS_GRUPOS
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesCienciasNaturalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesCienciasNaturalesToolStripMenuItem.Click
        Dim MDIForm As New CIENCIAS_NATURALES_GRUPO
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesSocialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesSocialesToolStripMenuItem.Click
        Dim MDIForm As New SOCIALES_GRUPO
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesInglesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesInglesToolStripMenuItem.Click
        Dim MDIForm As New INGLES_GRUPO
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub IndividualesGradoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualesGradoToolStripMenuItem.Click
        Dim MDIForm As New Reporte_Saber_Individuales_Grado
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub PromediosGeneralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromediosGeneralesToolStripMenuItem.Click
        Dim MDIForm As New Reporte_Saber_Grado_Promedios_Generales
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub


    Private Sub AsertividadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsertividadToolStripMenuItem.Click
        Dim MDIForm As New Asertividad_Materias
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesLecturaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesLecturaToolStripMenuItem1.Click
        Dim MDIForm As New LECTURA_GRADO
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesMatematicasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesMatematicasToolStripMenuItem2.Click
        Dim MDIForm As New MATEMATICAS_GRADO
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesCienciasNaturalesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesCienciasNaturalesToolStripMenuItem2.Click
        Dim MDIForm As New CIENCIAS_NATURALES_GRADO
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesSocialesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesSocialesToolStripMenuItem2.Click
        Dim MDIForm As New SOCIALES_GRADO
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GeneralesInglesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralesInglesToolStripMenuItem2.Click
        Dim MDIForm As New INGLES_GRADO
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub
End Class
