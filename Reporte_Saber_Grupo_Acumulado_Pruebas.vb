Public Class Reporte_Saber_Grupo_Acumulado_Pruebas

    Dim cant_registros As Integer
    Public codigoestudiante As Integer
    Dim Simulacros_Promedio(,)

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

    Private Sub CBOCODIGOSEDE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCODIGOSEDE.SelectedIndexChanged
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_gupo  FROM grupos WHERE codigo_colegios='" & CBOCODIGOSEDE.Text & "' GROUP BY codigo_gupo", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "grupos")
        CBOCODIGOGRUPO.DataSource = DS.Tables("grupos")
        CBOCODIGOGRUPO.DisplayMember = "codigo_gupo"
    End Sub

    Private Sub Reporte_Saber_Grupo_Acumulado_Pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            'BORRAR TODOS LOS DATOS DE LA TABLA Acumulado_Simulacros
            Dim CMD6 As New OleDb.OleDbCommand("DELETE FROM Acumulado_Simulacros_3_5_9 WHERE 1", CN)
            CN.Open()
            CMD6.ExecuteNonQuery()
            CN.Close()

            Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT codigo FROM Informe_Resultados_3_5_9 ORDER BY codigo ASC", CN)
            Dim DQ As New DataSet
            DA.Fill(DQ, "Informe_Resultados_3_5_9")
            cant_registros = DQ.Tables(0).Rows.Count

            For n = 0 To cant_registros - 1

                codigoestudiante = DQ.Tables(0).Rows(n).Item(0).ToString
                Dim CMATERIA_FLEXIBLE As New OleDb.OleDbDataAdapter("SELECT proTotal FROM Resultados_Saber_3_5_9 WHERE Codigo='" & codigoestudiante & "' AND Codigo_Prueba='3'", CN)
                Dim DATA_Simulacros_Promedio As New DataSet
                CMATERIA_FLEXIBLE.Fill(DATA_Simulacros_Promedio, "Resultados_Saber_3_5_9")
                Dim cantidad_simulacros As Integer
                cantidad_simulacros = DATA_Simulacros_Promedio.Tables(0).Rows.Count

                ReDim Simulacros_Promedio(0, 8)

                For i = 0 To cantidad_simulacros - 1
                    Simulacros_Promedio(0, 0) = codigoestudiante
                    Simulacros_Promedio(0, i + 1) = DATA_Simulacros_Promedio.Tables(0).Rows(i).Item(0).ToString
                Next

                For y = 0 To 6
                    If Simulacros_Promedio(0, y + 1) = Nothing Then
                    Else
                        Simulacros_Promedio(0, 8) = CDbl(Simulacros_Promedio(0, 8)) + CDbl(Simulacros_Promedio(0, y + 1))
                    End If
                Next

                Simulacros_Promedio(0, 8) = Simulacros_Promedio(0, 8) / cantidad_simulacros

                Dim CMD5 As New OleDb.OleDbCommand("INSERT INTO Acumulado_Simulacros_3_5_9 VALUES ( '" & Simulacros_Promedio(0, 0) & "','" & CDbl(Simulacros_Promedio(0, 1)) & "','" & CDbl(Simulacros_Promedio(0, 2)) & "','" & CDbl(Simulacros_Promedio(0, 3)) & "','" & CDbl(Simulacros_Promedio(0, 4)) & "','" & CDbl(Simulacros_Promedio(0, 5)) & "','" & CDbl(Simulacros_Promedio(0, 6)) & "','" & CDbl(Simulacros_Promedio(0, 7)) & "','" & CDbl(Simulacros_Promedio(0, 8)) & "')", CN)
                CN.Open()
                CMD5.ExecuteNonQuery()
                CN.Close()

            Next
            Control = 17
            Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
            Estudiantes_Colegio.grupo = CBOCODIGOGRUPO.Text
            Estudiantes_Colegio.codigo_prueba = 3
            Estudiantes_Colegio.Show()

        ElseIf CBOTIPO.Text = "saber 10 y 11" Then

            'BORRAR TODOS LOS DATOS DE LA TABLA Acumulado_Simulacros
            Dim CMD6 As New OleDb.OleDbCommand("DELETE FROM Acumulado_Simulacros WHERE 1", CN)
            CN.Open()
            CMD6.ExecuteNonQuery()
            CN.Close()

            Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT codigo FROM Informe_Resultados ORDER BY codigo ASC", CN)
            Dim DQ As New DataSet
            DA.Fill(DQ, "Informe_Resultados")
            cant_registros = DQ.Tables(0).Rows.Count

            For n = 0 To cant_registros - 1

                codigoestudiante = DQ.Tables(0).Rows(n).Item(0).ToString
                Dim CMATERIA_FLEXIBLE As New OleDb.OleDbDataAdapter("SELECT proTotal FROM Resultados_Saber_Decimo_Once WHERE codigo='" & codigoestudiante & "' AND Codigo_Prueba='4'", CN)
                Dim DATA_Simulacros_Promedio As New DataSet
                CMATERIA_FLEXIBLE.Fill(DATA_Simulacros_Promedio, "Resultados_Saber_Decimo_Once")
                Dim cantidad_simulacros As Integer
                cantidad_simulacros = DATA_Simulacros_Promedio.Tables(0).Rows.Count

                ReDim Simulacros_Promedio(0, 8)

                For i = 0 To cantidad_simulacros - 1
                    Simulacros_Promedio(0, 0) = codigoestudiante
                    Simulacros_Promedio(0, i + 1) = DATA_Simulacros_Promedio.Tables(0).Rows(i).Item(0).ToString
                Next

                For y = 0 To 6
                    If Simulacros_Promedio(0, y + 1) = Nothing Then
                    Else
                        Simulacros_Promedio(0, 8) = CDbl(Simulacros_Promedio(0, 8)) + CDbl(Simulacros_Promedio(0, y + 1))
                    End If
                Next

                Simulacros_Promedio(0, 8) = Simulacros_Promedio(0, 8) / cantidad_simulacros

                Dim CMD5 As New OleDb.OleDbCommand("INSERT INTO Acumulado_Simulacros VALUES ( '" & Simulacros_Promedio(0, 0) & "','" & CDbl(Simulacros_Promedio(0, 1)) & "','" & CDbl(Simulacros_Promedio(0, 2)) & "','" & CDbl(Simulacros_Promedio(0, 3)) & "','" & CDbl(Simulacros_Promedio(0, 4)) & "','" & CDbl(Simulacros_Promedio(0, 5)) & "','" & CDbl(Simulacros_Promedio(0, 6)) & "','" & CDbl(Simulacros_Promedio(0, 7)) & "','" & CDbl(Simulacros_Promedio(0, 8)) & "')", CN)
                CN.Open()
                CMD5.ExecuteNonQuery()
                CN.Close()

            Next
            Control = 17
            Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
            Estudiantes_Colegio.grupo = CBOCODIGOGRUPO.Text
            Estudiantes_Colegio.codigo_prueba = 4
            Estudiantes_Colegio.Show()
        End If

    End Sub

End Class