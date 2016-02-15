Public Class Reporte_Simulacros_Creados

    Private Sub Reporte_Simulacros_Creados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Sub CARGAR()

        Dim DB As New OleDb.OleDbDataAdapter("SELECT  DISTINCT codigo  FROM Formato_Examen_Cantidad", CN)
        Dim DD As New DataSet
        DB.Fill(DD, "Formato_Examen_Cantidad")
        CBOSIMULACRO.DataSource = DD.Tables("Formato_Examen_Cantidad")
        CBOSIMULACRO.DisplayMember = "codigo"

    End Sub

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click
        Control = 19
        Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
        Estudiantes_Colegio.Show()
        Reporte.simulacro = CBOSIMULACRO.Text
        Reporte.Show()

    End Sub
End Class