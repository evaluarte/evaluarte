Public Class Notras_Grupo

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Private Sub Notras_Grupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click
        Control = 7
        Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
        Estudiantes_Colegio.grupo = CBOCODIGOGRUPO.Text
        Estudiantes_Colegio.codigo_prueba = CBOCODIGOSIMULACRO.Text
        Estudiantes_Colegio.Show()
        Reporte.variable = CBOCODIGOSEDE.Text
        Reporte.grupo = CBOCODIGOGRUPO.Text
        Reporte.codigo_prueba = CBOCODIGOSIMULACRO.Text
        Reporte.Show()
    End Sub

    Sub CARGAR()
        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "colegios")
        CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        CBOCOLEGIOS.DisplayMember = "nombre"


        Dim DG As New OleDb.OleDbDataAdapter("SELECT  nombre_prueba  FROM Pruebas", CN)
        Dim DL As New DataSet
        DG.Fill(DL, "Pruebas")
        CBOTIPO.DataSource = DL.Tables("Pruebas")
        CBOTIPO.DisplayMember = "nombre_prueba"

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


    Private Sub CODIGO_SIMULACRO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOTIPO.SelectedIndexChanged
        Dim DL As New OleDb.OleDbDataAdapter("SELECT  codigo_prueba  FROM Pruebas WHERE nombre_prueba='" & CBOTIPO.Text & "'", CN)
        Dim DQ As New DataSet
        DL.Fill(DQ, "Pruebas")
        CBOCODIGOSIMULACRO.DataSource = DQ.Tables("Pruebas")
        CBOCODIGOSIMULACRO.DisplayMember = "codigo_prueba"
    End Sub

End Class