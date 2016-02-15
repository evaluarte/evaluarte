Public Class Reporte

    Private Sub Reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CRYSTAL_REPORT()
    End Sub

    Public simulacro As String
    Public variable As String
    Public grupo As String
    Public fecha As String
    Public fecha_comotal As String
    Public codigo_prueba As String
    Dim CONSULTA As String

    Dim DSET As New DataSet

    Sub CRYSTAL_REPORT()

        'MsgBox(variable)

        ''MsgBox(grupo)
        'Dim PEPE As Date
        'PEPE = fecha
        'PEPE = Format(PEPE, "dd/MM/yyyy")
        'fecha_comotal = PEPE
        'Dim diames As String
        'Dim ano As String
        'Dim fechaFinal As String
        'diames = Mid(fecha_comotal, 1, 6)
        'ano = Mid(fecha_comotal, 9, 10)
        'fechaFinal = diames + ano

        If Control = 7 Then

            If codigo_prueba = 1 Then

                Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Notas_Grupo WHERE codigo_colegios='" & variable & "'", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Notas_Grupo")
                'DataGridView1.DataSource = DS.Tables("Notas_Grupo")
                'Dim REPORTAR As New Estilos_Aprendizaje_Colegio
                'REPORTAR.SetDataSource(DS)
                'CrystalReportViewer1.ReportSource = REPORTAR

                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("D:\reportes\Estilos_Aprendizaje_General.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport

                MODIFICAR_Generales()

            ElseIf codigo_prueba = 2 Then

            ElseIf codigo_prueba = 3 Then

            Else

            End If

        End If

        If Control = 8 Then


            If grupo <> " " Then

                Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Notas_Grupo WHERE codigo_colegios='" & variable & "' AND codigo_gupo='" & grupo & "'", CN)
                'Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Notas_Grupo WHERE codigo_colegios='" & variable & "' AND codigo_gupo='" & grupo & "' ORDER BY activo DESC, reflexivo DESC, sensorial DESC, intuitivo DESC, visual DESC, verbal DESC, secuencial DESC, global DESC", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Notas_Grupo")
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("D:\reportes\Estilos_Aprendizaje_Colegio.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport
            ElseIf grupo = " " Then

                Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Notas_Grupo WHERE codigo_colegios='" & variable & "'", CN)
                'Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT * FROM Notas_Grupo WHERE codigo_colegios='" & variable & "' AND codigo_gupo='" & grupo & "' ORDER BY activo DESC, reflexivo DESC, sensorial DESC, intuitivo DESC, visual DESC, verbal DESC, secuencial DESC, global DESC", CN)
                Dim DS As New DataSet
                DA.Fill(DS, "Notas_Grupo")
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load("D:\reportes\Estilos_Aprendizaje_Colegio.rpt")
                CrReport.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = CrReport

            End If



            MODIFICAR_Sabanas()

        End If

        If Control = 15 Then
            'REPORTE SABER "LOS DOS" (3 5 Y 9, 10 y 11) Reporte_Saber_Institucion_Ambitos  
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
            CrReport.Load("D:\reportes\Reporte_Saber_Institucion_Ambitos2.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport

        End If

        If Control = 16 Then
            'REPORTE SABER "LOS DOS" (3 5 Y 9, 10 y 11) Reporte_Saber_Institucion_Ambitos  
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
            CrReport.Load("D:\reportes\Reporte_Saber_Institucion_Competencias2.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport
        End If

        If Control = 19 Then
            ' REPORTE NIVELES DE PENSAMIENTO Y ESTILOS DE APRENDIZAJE  INDIVIDUALES
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Formato_Examen WHERE sesion='2' AND codigo='" & simulacro & "' ORDER BY pregunta ASC", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "Formato_Examen")
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load("D:\reportes\Reporte_Simulacros_Creados.rpt")
            CrReport.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = CrReport
        End If

    End Sub

    Sub MODIFICAR_Sabanas()
        Dim PEPE As Date
        PEPE = DateTimePicker1.Value
        PEPE = Format(PEPE, "dd/MM/yyyy")
        Dim CMD As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Impresion_Sabanas='" & PEPE & "'  WHERE Codigo_Colegio='" & variable & "'AND Grupo='" & grupo & "'", CN)
        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
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

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class