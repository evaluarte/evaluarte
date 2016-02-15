Imports System.Data.OleDb
Public Class Administrar_estudiantes
    Dim N As Integer

    Private Sub EstudiantesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.EstudiantesBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.SistemaevaluarteDataSet)
    End Sub

    Private Sub matricular_estudiante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SistemaevaluarteDataSet.colegios' table. You can move, or remove it, as needed.
        'Me.ColegiosTableAdapter.Fill(Me.SistemaevaluarteDataSet.colegios)
        'TODO: This line of code loads data into the 'SistemaevaluarteDataSet.estudiantes' table. You can move, or remove it, as needed.
        ' Me.EstudiantesTableAdapter.Fill(Me.SistemaevaluarteDataSet.estudiantes)
        MOSTRAR()
        CARGAR()
        BLOQUEAR()
        CARGAR_CBO()
    End Sub


    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        BUSCAR_CODIGO()
    End Sub

    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\sistemaevaluarte.accdb")
    Sub MOSTRAR()
        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM estudiantes", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "estudiantes")
        DataGridView1.DataSource = DS.Tables("estudiantes")
    End Sub

    Sub BUSCAR_CODIGO()
        Dim CMD As New OleDb.OleDbCommand("SELECT * FROM estudiantes WHERE Codigo='" & CBOCODIGOEXAMEN.Text & "'", CN)
        Dim DR As OleDb.OleDbDataReader
        CN.Open()
        DR = CMD.ExecuteReader
        If DR.Read Then
            TXTNOMBRES.Text = DR(1)
            TXTAPELLIDOS.Text = DR(2)
            TXTCOLEGIO.Text = DR(3)
            CBOCODIGOGRUPO.Text = DR(4)
            CBOCODIGOSEDE.Text = DR(5)
        Else
            MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
        End If
        CN.Close()
    End Sub




    Sub CARGAR_CBO()
        CBOCODIGOGRUPO.Items.Add("030")
        CBOCODIGOGRUPO.Items.Add("031")
        CBOCODIGOGRUPO.Items.Add("032")
        CBOCODIGOGRUPO.Items.Add("033")

        CBOCODIGOSEDE.Items.Add("01")
        CBOCODIGOSEDE.Items.Add("02")
        CBOCODIGOSEDE.Items.Add("03")
        CBOCODIGOSEDE.Items.Add("04")

    End Sub

    Sub CARGAR()
        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM estudiantes", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "estudiantes")
        CBOCODIGOEXAMEN.DataSource = DS.Tables("estudiantes")
        CBOCODIGOEXAMEN.DisplayMember = "Codigo"

    End Sub


    Sub NUEVO()
        If CBOCODIGOEXAMEN.Text = "" Then
            MsgBox("DEBE INGRESAR UN CODIGO", 16, "ERROR")
        Else
            Dim CMD As New OleDb.OleDbCommand("INSERT INTO estudiantes VALUES ( '" & CBOCODIGOEXAMEN.Text & "','" & TXTNOMBRES.Text & "','" & TXTAPELLIDOS.Text & "','" & TXTCOLEGIO.Text & "','" & CBOCODIGOSEDE.Text & "','" & CBOCODIGOGRUPO.Text & "','" & DateTimePicker1.Value & "','" & "ADMINISTRADOR" & "','" & "" & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "')", CN)
            CN.Open()
            CMD.ExecuteNonQuery()
            CN.Close()
            MOSTRAR()
            MsgBox("guardado en la base de datos")
        End If
    End Sub

    Sub MODIFICAR()
        Dim CMD As New OleDb.OleDbCommand("UPDATE  estudiantes SET Codigo='" & CBOCODIGOEXAMEN.Text & "', Nombres='" & TXTNOMBRES.Text & "', Apellidos='" & TXTAPELLIDOS.Text & "', Colegio='" & TXTCOLEGIO.Text & "', codigo_sede='" & CBOCODIGOSEDE.Text & "', codigo_grupo='" & CBOCODIGOGRUPO.Text & "', Fecha_registro='" & DateTimePicker1.Value & "', usuario_registro='" & " " & "', identificacion='" & " " & "', Direccion='" & " " & "', Telefono='" & " " & "', Ciudad='" & " " & "', email='" & " " & "'  WHERE Codigo='" & CBOCODIGOEXAMEN.Text & "'", CN)
        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        MOSTRAR()
        MsgBox("ACTUALIZADO en la base de datos")
    End Sub

    Sub LIMPIAR()
        TXTNOMBRES.Clear()
        TXTAPELLIDOS.Clear()
        TXTCOLEGIO.Clear()
        CBOCODIGOEXAMEN.Text = ""
        CBOCODIGOGRUPO.Text = ""
        CBOCODIGOSEDE.Text = ""
    End Sub

    Sub BLOQUEAR()
        BTNBUSCAR.Enabled = True
        BTNNUEVO.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNMODIFICAR.Enabled = True
        BTNELIMINAR.Enabled = True
        BTNCANCELAR.Enabled = False
    End Sub

    Sub DESBLOQUEAR()
        BTNBUSCAR.Enabled = False
        BTNNUEVO.Enabled = False
        BTNGUARDAR.Enabled = True
        BTNMODIFICAR.Enabled = False
        BTNELIMINAR.Enabled = False
        BTNCANCELAR.Enabled = True
    End Sub


    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        DESBLOQUEAR()
        LIMPIAR()
        N = 1

    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        DESBLOQUEAR()
        N = 2

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If N = 1 Then
            NUEVO()
        ElseIf N = 2 Then
            MODIFICAR()
        End If
        BLOQUEAR()
        LIMPIAR()
        CARGAR()
        N = 0

        'MsgBox("Su Registro ha sido Guardado", 0, "REGISTRO CORRECTO")
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        BLOQUEAR()
        LIMPIAR()
        N = 0
    End Sub

    Private Sub CBOCODIGOEXAMEN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCODIGOEXAMEN.SelectedIndexChanged
        BUSCAR_CODIGO()
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Dim CMD As New OleDb.OleDbCommand("DELETE FROM estudiantes WHERE Codigo='" & CBOCODIGOEXAMEN.Text & "'", CN)
        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        LIMPIAR()
        CARGAR()
        MOSTRAR()
        MsgBox("EL REGISRO SE HA ELIMINADO")

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ColegiosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.ColegiosBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.SistemaevaluarteDataSet)

    End Sub

    Private Sub CBOCODIGOSEDE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCODIGOSEDE.SelectedIndexChanged

    End Sub
End Class