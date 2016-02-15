Public Class Simulacros_Presentados

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click
        CARGAR1()
    End Sub

    Private Sub BTNBUSQUEDACOLEGIO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSQUEDACOLEGIO.Click
        CARGAR3()
    End Sub

    Sub CARGAR()
        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "colegios")
        CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        CBOCOLEGIOS.DisplayMember = "nombre"
    End Sub

    Private Sub CARGAR_CODIGO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCOLEGIOS.SelectedIndexChanged
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios WHERE nombre='" & CBOCOLEGIOS.Text & "'", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "colegios")
        CBOCODIGOSEDE.DataSource = DS.Tables("colegios")
        CBOCODIGOSEDE.DisplayMember = "codigo_colegio"
    End Sub

    Sub CARGAR1()
        Try
            Dim DA As New OleDb.OleDbDataAdapter("SELECT codigo_estudiante,codigo_prueba,fecha,nombre_prueba AS Prueba FROM Simulacros_Presentados WHERE codigo_estudiante LIKE'%" & TXTNOMBRE.Text & "%'", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "Simulacros_Presentados")
            DataGridView1.DataSource = DS.Tables("Simulacros_Presentados")
            TXTCANTIDADPRESENTADOS.Text = DS.Tables("Simulacros_Presentados").Rows.Count
        Catch ex As Exception
            MsgBox("ocurrio un error en la busqueda", 8, "Mensaje Error")
        End Try
    End Sub

    Sub CARGAR3()

        Dim DA As New OleDb.OleDbDataAdapter("SELECT COUNT(matriculados) FROM (SELECT matriculados FROM simulacros_presentados_matriculados WHERE (nombre LIKE'%" & CBOCOLEGIOS.Text & "%' OR  colegio_perteneciente LIKE'%" & CBOCOLEGIOS.Text & "%'))", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "simulacros_presentados_matriculados")
        TXTCANTIDADPRESENTADOS.Text = DS.Tables(0).Rows(0).Item(0).ToString


        Dim DB As New OleDb.OleDbDataAdapter("SELECT nombre_prueba AS PRUEBA,fecha AS FECHA,nombre as COLEGIO,colegio_perteneciente AS SEDE,codigo_estudiante as CODIGO FROM (SELECT nombre_prueba,fecha,nombre,colegio_perteneciente,codigo_estudiante FROM simulacros_presentados_matriculados WHERE nombre LIKE'%" & CBOCOLEGIOS.Text & "%' OR  colegio_perteneciente LIKE'%" & CBOCOLEGIOS.Text & "%')" & "') ORDER BY fecha ASC", CN)
        Dim DW As New DataSet
        DB.Fill(DW, "simulacros_presentados_matriculados")
        DataGridView1.DataSource = DW.Tables("simulacros_presentados_matriculados")

    End Sub




    'Sub CARGAR1()
    '    Try
    '        Dim DA As New OleDb.OleDbDataAdapter("SELECT codigo_estudiante,codigo_simulacro,fecha,nombre_prueba AS Prueba FROM Simulacros_Presentados WHERE codigo_estudiante LIKE'%" & TXTNOMBRE.Text & "%'", CN)
    '        Dim DS As New DataSet
    '        DA.Fill(DS, "Simulacros_Presentados")
    '        DataGridView1.DataSource = DS.Tables("Simulacros_Presentados")
    '        TXTCANTIDADPRESENTADOS.Text = DS.Tables("Simulacros_Presentados").Rows.Count
    '    Catch ex As Exception
    '        MsgBox("ocurrio un error en la busqueda", 8, "Mensaje Error")
    '    End Try
    'End Sub



    'Sub CARGAR2()

    '    'Dim aplicacion As Date
    '    'aplicacion = DateTimePicker1.Value
    '    'aplicacion = Format(aplicacion, "dd/MM/yyyy")

    '    'Dim aplicacion1 As Date
    '    'aplicacion1 = DateTimePicker2.Value
    '    'aplicacion1 = Format(aplicacion1, "dd/MM/yyyy")

    '    'MsgBox(aplicacion.ToString)
    '    'fecha1.Text = aplicacion.ToString
    '    'Format(Me.TextoDesde, mm dd yyy)

    '    'Try
    '    'Dim DA As New OleDb.OleDbDataAdapter("SELECT nombre_prueba,fecha,nombre as SEDE,codigo_estudiante FROM simulacros_presentados_matriculados WHERE fecha>=#" & aplicacion & "# AND fecha<=#" & aplicacion1 & "#", CN)
    '    'Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM simulacros_presentados_matriculados WHERE fecha>=#03/04/2012# AND fecha<=#13/04/2012#", CN)
    '    'Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM simulacros_presentados_matriculados WHERE fecha BETWEEN #13/05/2012# AND #30/06/2012#", CN)

    '    Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM simulacros_presentados_matriculados WHERE fecha >= datevalue('" & DateTimePicker1.Value & "') ORDER BY fecha ASC", CN)
    '    'Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM simulacros_presentados_matriculados WHERE fecha >= #" & aplicacion & "# ORDER BY fecha ASC", CN)
    '    Dim DS As New DataSet
    '    DA.Fill(DS, "Simulacros_Presentados")
    '    DataGridView1.DataSource = DS.Tables("Simulacros_Presentados")
    '    TXTCANTIDADPRESENTADOS.Text = DS.Tables("Simulacros_Presentados").Rows.Count
    '    'Catch ex As Exception
    '    'MsgBox("ocurrio un error en la busqueda", 8, "Mensaje Error")
    '    ' End Try
    'End Sub

    'Sub CARGAR3()
    '    'Try
    '    'Dim DA As New OleDb.OleDbDataAdapter("SELECT SUM(matriculados) FROM (SELECT DISTINCT matriculados FROM simulacros_presentados_matriculados)", CN)
    '    'dejar como estaba Dim DA As New OleDb.OleDbDataAdapter("SELECT count(matriculados) FROM (SELECT matriculados FROM simulacros_presentados_matriculados WHERE nombre LIKE'%" & TXTNOMBRECOLEGIO.Text & "%' OR  colegio_perteneciente LIKE'%" & TXTNOMBRECOLEGIO.Text & "%')", CN)
    '    'dejar como estaba Dim DS As New DataSet
    '    'dejar como estaba  DA.Fill(DS, "simulacros_presentados_matriculados")
    '    'dejar como estaba TXTCANTIDADPRESENTADOS.Text = DS.Tables(0).Rows(0).Item(0).ToString


    '    Dim DA As New OleDb.OleDbDataAdapter("SELECT COUNT(matriculados) FROM (SELECT matriculados FROM simulacros_presentados_matriculados WHERE (nombre LIKE'%" & TXTNOMBRECOLEGIO.Text & "%' OR  colegio_perteneciente LIKE'%" & TXTNOMBRECOLEGIO.Text & "%') AND (fecha >= datevalue('" & DateTimePicker1.Value & "')))", CN)
    '    Dim DS As New DataSet
    '    DA.Fill(DS, "simulacros_presentados_matriculados")
    '    TXTCANTIDADPRESENTADOS.Text = DS.Tables(0).Rows(0).Item(0).ToString


    '    Dim DB As New OleDb.OleDbDataAdapter("SELECT nombre_prueba AS PRUEBA,fecha AS FECHA,nombre as COLEGIO,colegio_perteneciente AS SEDE,codigo_estudiante as CODIGO FROM (SELECT nombre_prueba,fecha,nombre,colegio_perteneciente,codigo_estudiante FROM simulacros_presentados_matriculados WHERE nombre LIKE'%" & TXTNOMBRECOLEGIO.Text & "%' OR  colegio_perteneciente LIKE'%" & TXTNOMBRECOLEGIO.Text & "%')" & " WHERE fecha >= datevalue('" & DateTimePicker1.Value & "') ORDER BY fecha ASC", CN)

    '    'funciona Dim DB As New OleDb.OleDbDataAdapter("SELECT nombre_prueba,fecha,nombre as SEDE,codigo_estudiante FROM (SELECT nombre_prueba,fecha,nombre,codigo_estudiante FROM simulacros_presentados_matriculados WHERE nombre LIKE'%" & TXTNOMBRECOLEGIO.Text & "%' OR  colegio_perteneciente LIKE'%" & TXTNOMBRECOLEGIO.Text & "%' AND (fecha>=#" & aplicacion & "# AND fecha<=#" & aplicacion1 & "#) )", CN)
    '    'Dim DA As New OleDb.OleDbDataAdapter("SELECT DISTINCT SUM([matriculados]) FROM simulacros_presentados_matriculados", CN)
    '    'Dim DA As New OleDb.OleDbDataAdapter("SELECT SUM(matriculados) FROM (SELECT DISTINCT matriculados FROM simulacros_presentados_matriculados),codigo_colegio FROM simulacros_presentados_matriculados WHERE nombre LIKE'%" & TXTNOMBRECOLEGIO.Text & "%' OR  colegio_perteneciente LIKE'%" & TXTNOMBRECOLEGIO.Text & "%' GROUP BY codigo_colegio", CN)
    '    Dim DW As New DataSet
    '    DB.Fill(DW, "simulacros_presentados_matriculados")
    '    DataGridView1.DataSource = DW.Tables("simulacros_presentados_matriculados")


    '    'Catch ex As Exception
    '    'MsgBox("FALLO ALGO", 8)
    '    'End Try

    'End Sub



    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNBUSQUEDACOLEGIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  CARGAR3()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNESTUDIANTE.Click
        Busqueda_codigo.Visible = True
        Buscar_Colegio.Visible = False
        BTNCOLEGIO.Visible = True
        BTNESTUDIANTE.Visible = False
    End Sub

    Private Sub Simulacros_Presentados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Private Sub BTNCOLEGIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCOLEGIO.Click
        Busqueda_codigo.Visible = False
        Buscar_Colegio.Visible = True
        BTNCOLEGIO.Visible = False
        BTNESTUDIANTE.Visible = True
    End Sub


End Class