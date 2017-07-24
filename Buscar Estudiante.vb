Imports System.Data.OleDb
Public Class Buscar_Estudiante

    Private Sub Buscar_Estudiante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SistemaevaluarteDataSet.Listado_Estudiantes' table. You can move, or remove it, as needed.
    End Sub
    'Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Sistemas3\d\sistemaevaluarte.accdb")

    Sub CARGAR1()

        If TXTNOMBRE.Text = "" Then
            TXTNOMBRE.Text = "."
        End If
        If TXTNOMBRE.Text = "" Then
            TXTNOMBRE.Text = "."
        End If
        If TXTAPELLIDO.Text = "" Then
            TXTAPELLIDO.Text = "."
        End If
        If TXTCOLEGIO.Text = "" Then
            TXTCOLEGIO.Text = "."
        End If


        Dim DA As New OleDb.OleDbDataAdapter("SELECT *  FROM Listado_Estudiantes WHERE Nombres LIKE'" & TXTNOMBRE.Text.Trim & "%' OR Apellidos LIKE'" & TXTAPELLIDO.Text.Trim & "%' OR nombre LIKE'" & TXTCOLEGIO.Text.Trim & "%'", CN)
        Dim DS As New DataSet
        Try
            DA.Fill(DS, "Listado_Estudiantes")
            DataGridView1.DataSource = DS.Tables("Listado_Estudiantes")
            TXTCANTIDADREGISTROS.Text = DS.Tables("Listado_Estudiantes").Rows.Count

        Catch ex As Exception

        End Try

    End Sub
    Sub CARGAR2()
        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Listado_Estudiantes WHERE Nombres LIKE'" & TXTNOMBRE.Text & "' OR  Apellidos LIKE'" & TXTAPELLIDO.Text & "' OR  nombre LIKE'" & TXTCOLEGIO.Text & "'", CN)
        Dim DS As New DataSet
        Try
            DA.Fill(DS, "Listado_Estudiantes")
            DataGridView1.DataSource = DS.Tables("Listado_Estudiantes")

            TXTCANTIDADREGISTROS.Text = DS.Tables("Listado_Estudiantes").Rows.Count
        Catch ex As Exception

        End Try
    End Sub

    Sub CARGAR3()
        If TXTNOMBRE.Text = "" Then
            TXTNOMBRE.Text = "."
        End If
        If TXTNOMBRE.Text = "" Then
            TXTNOMBRE.Text = "."
        End If
        If TXTAPELLIDO.Text = "" Then
            TXTAPELLIDO.Text = "."
        End If
        If TXTCOLEGIO.Text = "" Then
            TXTCOLEGIO.Text = "."
        End If

        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM Listado_Estudiantes WHERE Nombres LIKE'%" & TXTNOMBRE.Text & "%' OR  Apellidos LIKE'%" & TXTAPELLIDO.Text & "%' OR  nombre LIKE'%" & TXTCOLEGIO.Text & "%'", CN)
        Dim DS As New DataSet
        Try
            DA.Fill(DS, "Listado_Estudiantes")
            DataGridView1.DataSource = DS.Tables("Listado_Estudiantes")

            TXTCANTIDADREGISTROS.Text = DS.Tables("Listado_Estudiantes").Rows.Count
        Catch ex As Exception

        End Try
    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        CARGAR1()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        CARGAR3()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        CARGAR2()
    End Sub
End Class