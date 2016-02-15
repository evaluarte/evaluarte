Public Class Reporte_Perfil_Profesional_Institucion_Promedios_Generales

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

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Sub CARGAR()
        'Dim DG As New OleDb.OleDbDataAdapter("SELECT  nombre_prueba  FROM Pruebas WHERE codigo_prueba='3' OR codigo_prueba='4' ", CN)
        'Dim DL As New DataSet
        'DG.Fill(DL, "Pruebas")
        'CBOTIPO.DataSource = DL.Tables("Pruebas")
        'CBOTIPO.DisplayMember = "nombre_prueba"

        Dim DH As New OleDb.OleDbDataAdapter("SELECT  ciudad  FROM colegios GROUP BY ciudad", CN)
        Dim DM As New DataSet
        DH.Fill(DM, "colegios")
        CBOCIUDADES.DataSource = DM.Tables("colegios")
        CBOCIUDADES.DisplayMember = "ciudad"
    End Sub

    Private Sub Reporte_Perfil_Profesional_Institucion_Promedios_Generales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click

            Control = 12
            Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
            Estudiantes_Colegio.codigo_prueba = 2
            Estudiantes_Colegio.grupo = " "
            Estudiantes_Colegio.Show()
    End Sub
End Class