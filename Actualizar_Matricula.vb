Public Class Actualizar_Matricula


    Private Sub Actualizar_Matricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SistemaevaluarteDataSet.estudiantes' table. You can move, or remove it, as needed.
        CARGAR()
    End Sub

    Sub CARGAR()



        Dim DH As New OleDb.OleDbDataAdapter("SELECT  ciudad  FROM colegios GROUP BY ciudad", CN)
        Dim DM As New DataSet
        DH.Fill(DM, "colegios")
        CBOCIUDADES.DataSource = DM.Tables("colegios")
        CBOCIUDADES.DisplayMember = "ciudad"

    End Sub

    Private Sub CARGAR_DATOS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCODIGOEXAMEN.SelectedIndexChanged

        BUSCAR_CODIGO()

    End Sub



    Sub BUSCAR_CODIGO()

        Dim CMD As New OleDb.OleDbCommand("SELECT * FROM estudiantes WHERE Codigo='" & CBOCODIGOEXAMEN.Text & "'AND codigo_colegio='" & TXTCODIGOCOLEGIO.Text & "'", CN)
        Dim DR As OleDb.OleDbDataReader
        CN.Open()
        DR = CMD.ExecuteReader
        If DR.Read Then

            Dim pepe As Integer
            'Dim pepe1 As New Object
            'Dim pepe2 As VariantType
            'Dim pepe3 As String
            pepe = VarType(DR(2))
            'pepe1 = VarType(DR(2))
            'pepe2 = VarType(DR(2))
            'pepe3 = VarType(DR(2))

            If VarType(DR(2)) = 1 Then
                TXTCODIGOCOLEGIO.Text = DR(1)
                TXTASOCIADO.Text = ""
                TXTCODIGOGRUPO.Text = CStr(DR(3))
                TXTNOMBRES.Text = CStr(DR(4))
                TXTAPELLIDOS.Text = CStr(DR(5))
                DateTimePicker1.Value = DR(6)
                TXTUSUARIO.Text = CStr(DR(7))
                TXTIDENTIFICACION.Text = ""
                TXTDIRECCION.Text = ""
                TXTTELEFONO.Text = ""
                TXTEMAIL.Text = ""
            Else
                TXTCODIGOCOLEGIO.Text = DR(1)
                TXTASOCIADO.Text = CStr(DR(2))
                TXTCODIGOGRUPO.Text = CStr(DR(3))
                TXTNOMBRES.Text = CStr(DR(4))
                TXTAPELLIDOS.Text = CStr(DR(5))
                DateTimePicker1.Value = DR(6)
                TXTUSUARIO.Text = CStr(DR(7))
                TXTIDENTIFICACION.Text = CStr(DR(8))
                TXTDIRECCION.Text = CStr(DR(9))
                TXTTELEFONO.Text = CStr(DR(10))
                TXTEMAIL.Text = CStr(DR(11))
            End If
        Else
            'MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
        End If
        CN.Close()

    End Sub

    Sub MODIFICAR()
        Dim CMD As New OleDb.OleDbCommand("UPDATE  estudiantes SET Codigo='" & CBOCODIGOEXAMEN.Text & "', codigo_colegio='" & TXTCODIGOCOLEGIO.Text & "', colegio_perteneciente='" & TXTASOCIADO.Text & "', codigo_grupo='" & TXTCODIGOGRUPO.Text & "', Nombres='" & TXTNOMBRES.Text & "', Apellidos='" & TXTAPELLIDOS.Text & "',  Fecha_registro='" & DateTimePicker1.Value & "', usuario_registro='" & TXTUSUARIO.Text & "',  identificacion='" & TXTIDENTIFICACION.Text & "', Direccion='" & TXTDIRECCION.Text & "', Telefono='" & TXTTELEFONO.Text & "', email='" & TXTEMAIL.Text & "'  WHERE Codigo='" & CBOCODIGOEXAMEN.Text & "'", CN)
        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        CARGAR()
        MsgBox("ACTUALIZADO en la base de datos")
    End Sub

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click
        MODIFICAR()
    End Sub

    Private Sub CARGAR_COLEGIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARGAR_COLEGIOS.Click
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "colegios")
        TXTASOCIADO.DataSource = DS.Tables("colegios")
        TXTASOCIADO.DisplayMember = "nombre"
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

        TXTCODIGOCOLEGIO.Text = DS.Tables(0).Rows(0).Item(0).ToString


        Dim Db As New OleDb.OleDbDataAdapter("SELECT * FROM estudiantes WHERE codigo_colegio='" & TXTCODIGOCOLEGIO.Text & "'", CN)
        Dim Dg As New DataSet
        Db.Fill(Dg, "estudiantes")
        CBOCODIGOEXAMEN.DataSource = Dg.Tables("estudiantes")
        CBOCODIGOEXAMEN.DisplayMember = "Codigo"

    End Sub
End Class