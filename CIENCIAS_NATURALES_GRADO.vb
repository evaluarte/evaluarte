Public Class CIENCIAS_NATURALES_GRADO

    Private Sub CIENCIAS_NATURALES_GRADO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Sub CARGAR()
        Dim DG As New OleDb.OleDbDataAdapter("SELECT  nombre_prueba  FROM Pruebas WHERE codigo_prueba='3' OR codigo_prueba='4' OR codigo_prueba='10' OR codigo_prueba='11' OR codigo_prueba='13' ", CN)
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
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  grado  FROM grupos WHERE codigo_colegios='" & CBOCODIGOSEDE.Text & "' GROUP BY grado", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "grupos")
        CBOCODIGOGRUPO.DataSource = DS.Tables("grupos")
        CBOCODIGOGRUPO.DisplayMember = "grado"
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
        ElseIf CBOTIPO.Text = "Tu saber" Then

            Dim DB As New OleDb.OleDbDataAdapter("SELECT  DISTINCT codigo  FROM Codigos_Pruebas  WHERE codigo_prueba='11'", CN)
            Dim DD As New DataSet
            DB.Fill(DD, "Codigos_Pruebas")
            CBOSIMULACRO.DataSource = DD.Tables("Codigos_Pruebas")
            CBOSIMULACRO.DisplayMember = "codigo"

        ElseIf CBOTIPO.Text = "Mi Saber Aprueba" Then

            Dim DB As New OleDb.OleDbDataAdapter("SELECT  DISTINCT codigo  FROM Codigos_Pruebas  WHERE codigo_prueba='13'", CN)
            Dim DD As New DataSet
            DB.Fill(DD, "Codigos_Pruebas")
            CBOSIMULACRO.DataSource = DD.Tables("Codigos_Pruebas")
            CBOSIMULACRO.DisplayMember = "codigo"
        End If

    End Sub

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click

        Control = 22
        Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
        Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
        Estudiantes_Colegio.grado = CBOCODIGOGRUPO.Text
        Estudiantes_Colegio.fecha = FECHA.Text
        If CBOTIPO.Text = "saber 3,5 y 9" Or CBOTIPO.Text = "saber 4,6,7 y 8" Then
            Estudiantes_Colegio.codigo_prueba = 3
        ElseIf CBOTIPO.Text = "saber 10 y 11" Then
            Estudiantes_Colegio.codigo_prueba = 4
        ElseIf CBOTIPO.Text = "Tu saber" Then
            Estudiantes_Colegio.codigo_prueba = 11
        ElseIf CBOTIPO.Text = "Mi Saber Aprueba" Then
            Estudiantes_Colegio.codigo_prueba = 13
        End If
        Estudiantes_Colegio.Show()

    End Sub
End Class