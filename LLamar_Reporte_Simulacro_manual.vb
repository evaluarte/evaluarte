Public Class LLamar_Reporte_Simulacro_manual

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click
        Control = 5
        Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
        Estudiantes_Colegio.grupo = CBOCODIGOGRUPO.Text
        Estudiantes_Colegio.Show()
    End Sub

    Sub CARGAR()
        Dim DH As New OleDb.OleDbDataAdapter("SELECT  ciudad  FROM colegios GROUP BY ciudad", CN)
        Dim DM As New DataSet
        DH.Fill(DM, "colegios")
        CBOCIUDADES.DataSource = DM.Tables("colegios")
        CBOCIUDADES.DisplayMember = "ciudad"
    End Sub

    Private Sub CARGAR_CODIGO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCOLEGIOS.SelectedIndexChanged
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios WHERE nombre='" & CBOCOLEGIOS.Text & "'", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "colegios")
        CBOCODIGOSEDE.DataSource = DS.Tables("colegios")
        CBOCODIGOSEDE.DisplayMember = "codigo_colegio"
    End Sub

    Private Sub CARGAR_GRUPOS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCODIGOSEDE.SelectedIndexChanged
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_gupo  FROM grupos WHERE codigo_colegios='" & CBOCODIGOSEDE.Text & "' GROUP BY codigo_gupo", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "grupos")
        CBOCODIGOGRUPO.DataSource = DS.Tables("grupos")
        CBOCODIGOGRUPO.DisplayMember = "codigo_gupo"
    End Sub

    Private Sub LLamar_Reporte_Simulacro_manual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Private Sub CBOCIUDADES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCIUDADES.SelectedIndexChanged
        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios WHERE ciudad='" & CBOCIUDADES.Text & "'", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "colegios")
        CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        CBOCOLEGIOS.DisplayMember = "nombre"
    End Sub
End Class