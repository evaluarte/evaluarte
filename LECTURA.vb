Public Class LECTURA

    Private Sub CBOCIUDADES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios WHERE ciudad='" & CBOCIUDADES.Text & "'", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "colegios")
        CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        CBOCOLEGIOS.DisplayMember = "nombre"
    End Sub

    Private Sub CBOCOLEGIOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios WHERE nombre='" & CBOCOLEGIOS.Text & "'", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "colegios")
        CBOCODIGOSEDE.DataSource = DS.Tables("colegios")
        CBOCODIGOSEDE.DisplayMember = "codigo_colegio"
    End Sub

    Private Sub CBOCODIGOSEDE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub CBOSIMULACRO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LECTURA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Sub CARGAR()
        Dim DG As New OleDb.OleDbDataAdapter("SELECT  nombre_prueba  FROM Pruebas WHERE codigo_prueba='3' OR codigo_prueba='4' OR codigo_prueba='10' ", CN)
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

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub
    Private Sub CBOCOLEGIOS_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCOLEGIOS.SelectedIndexChanged
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios WHERE nombre='" & CBOCOLEGIOS.Text & "'", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "colegios")
        CBOCODIGOSEDE.DataSource = DS.Tables("colegios")
        CBOCODIGOSEDE.DisplayMember = "codigo_colegio"
    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
    Private Sub CBOCODIGOSEDE_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCODIGOSEDE.SelectedIndexChanged

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub CBOSIMULACRO_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOSIMULACRO.SelectedIndexChanged

    End Sub
    Private Sub BTNCALIFICAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click

        If CBOTIPO.Text = "saber 3,5 y 9" Or CBOTIPO.Text = "saber 4,6,7 y 8" Then
            Control = 20
            Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
            Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
            Estudiantes_Colegio.codigo_prueba = 3
            Estudiantes_Colegio.grupo = " "
            Estudiantes_Colegio.Show()
        ElseIf CBOTIPO.Text = "saber 10 y 11" Then
            Control = 20
            Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
            Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
            Estudiantes_Colegio.codigo_prueba = 4
            Estudiantes_Colegio.grupo = " "
            Estudiantes_Colegio.Show()
        End If

    End Sub
    Private Sub BTNSALIR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub CBOTIPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOTIPO.SelectedIndexChanged
        If CBOTIPO.Text = "saber 3,5 y 9" Then

            Dim DB As New OleDb.OleDbDataAdapter("SELECT  DISTINCT codigo  FROM Formato_Examen_Cantidad WHERE grado='3°' OR grado='5°' OR grado='9°'", CN)
            Dim DD As New DataSet
            DB.Fill(DD, "Formato_Examen_Cantidad")
            CBOSIMULACRO.DataSource = DD.Tables("Formato_Examen_Cantidad")
            CBOSIMULACRO.DisplayMember = "codigo"

        ElseIf CBOTIPO.Text = "saber 4,6,7 y 8" Then

            Dim DB As New OleDb.OleDbDataAdapter("SELECT  DISTINCT codigo  FROM Formato_Examen_Cantidad WHERE grado='4°' OR grado='6°' OR grado='7°' OR grado='8°'", CN)
            Dim DD As New DataSet
            DB.Fill(DD, "Formato_Examen_Cantidad")
            CBOSIMULACRO.DataSource = DD.Tables("Formato_Examen_Cantidad")
            CBOSIMULACRO.DisplayMember = "codigo"

        ElseIf CBOTIPO.Text = "saber 10 y 11" Then
            Dim DB As New OleDb.OleDbDataAdapter("SELECT  DISTINCT codigo  FROM Formato_Examen_Cantidad  WHERE grado='10°' OR grado='11°'", CN)
            Dim DD As New DataSet
            DB.Fill(DD, "Formato_Examen_Cantidad")
            CBOSIMULACRO.DataSource = DD.Tables("Formato_Examen_Cantidad")
            CBOSIMULACRO.DisplayMember = "codigo"
        End If

    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
    Private Sub CBOCIUDADES_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCIUDADES.SelectedIndexChanged
        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios WHERE ciudad='" & CBOCIUDADES.Text & "'", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "colegios")
        CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        CBOCOLEGIOS.DisplayMember = "nombre"
    End Sub


End Class