Public Class Mostrar_Reporte_Estudiante

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click
        Control = 6
        'Estudiantes_Colegio.codigo_prueba = CBOCODIGOSIMULACRO.Text
        Estudiantes_Colegio.codigo_estudiante = TXTCODIGOESTUDIANTE.Text
        Estudiantes_Colegio.Show()
    End Sub

    Private Sub Mostrar_Reporte_Estudiante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Sub CARGAR()

        Dim DG As New OleDb.OleDbDataAdapter("SELECT  nombre_prueba  FROM Pruebas", CN)
        Dim DL As New DataSet
        DG.Fill(DL, "Pruebas")
        CBOTIPO.DataSource = DL.Tables("Pruebas")
        CBOTIPO.DisplayMember = "nombre_prueba"
    End Sub

    Private Sub CODIGO_SIMULACRO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOTIPO.SelectedIndexChanged
        Dim DL As New OleDb.OleDbDataAdapter("SELECT  codigo_prueba  FROM Pruebas WHERE nombre_prueba='" & CBOTIPO.Text & "'", CN)
        Dim DQ As New DataSet
        DL.Fill(DQ, "Pruebas")
        CBOCODIGOSIMULACRO.DataSource = DQ.Tables("Pruebas")
        CBOCODIGOSIMULACRO.DisplayMember = "codigo_prueba"
    End Sub

End Class