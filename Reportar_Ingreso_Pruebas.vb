Public Class Reportar_Ingreso_Pruebas

    Private Sub Reportar_Ingreso_Pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Sub CARGAR()

        'Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios", CN)
        'Dim DF As New DataSet
        'DB.Fill(DF, "colegios")
        'CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        'CBOCOLEGIOS.DisplayMember = "nombre"

        Dim DG As New OleDb.OleDbDataAdapter("SELECT  nombre_prueba  FROM Pruebas", CN)
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

    Private Sub CARGAR_ESTUDIANTES(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCODIGOGRUPO.DropDownClosed

        'Dim DD As New OleDb.OleDbDataAdapter("SELECT  matriculados  FROM grupos WHERE   codigo_gupo='" & CBOCODIGOGRUPO.Text & "'AND codigo_colegios='" & CBOCODIGOSEDE.Text & "'", CN)
        'Dim PP As New DataSet
        ' DD.Fill(PP, "grupos")
        'TXTCANTESTUDIANTES.Text = PP.Tables(0).Rows(0).Item(0).ToString


        Dim DD As New OleDb.OleDbDataAdapter("SELECT matriculados  FROM grupos WHERE   codigo_gupo='" & CBOCODIGOGRUPO.Text & "'AND codigo_colegios='" & CBOCODIGOSEDE.Text & "'", CN)
        Dim PB As New DataSet
        DD.Fill(PB, "grupos")
        CBOCANTIDAD.DataSource = PB.Tables("grupos")
        CBOCANTIDAD.DisplayMember = "matriculados"


        Dim DF As New OleDb.OleDbDataAdapter("SELECT ciudad FROM colegios WHERE codigo_colegio='" & CBOCODIGOSEDE.Text & "'", CN)
        Dim PA As New DataSet
        DF.Fill(PA, "colegios")
        CBOCIUDAD.DataSource = PA.Tables("colegios")
        CBOCIUDAD.DisplayMember = "ciudad"

        Dim DT As New OleDb.OleDbDataAdapter("SELECT grado FROM grupos WHERE codigo_gupo='" & CBOCODIGOGRUPO.Text & "'AND codigo_colegios='" & CBOCODIGOSEDE.Text & "'", CN)
        Dim PE As New DataSet
        DT.Fill(PE, "grupos")
        CBOGRADO.DataSource = PE.Tables("grupos")
        CBOGRADO.DisplayMember = "grado"

    End Sub

    Private Sub CODIGO_SIMULACRO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOTIPO.SelectedIndexChanged
        Dim DL As New OleDb.OleDbDataAdapter("SELECT  codigo_prueba  FROM Pruebas WHERE nombre_prueba='" & CBOTIPO.Text & "'", CN)
        Dim DQ As New DataSet
        DL.Fill(DQ, "Pruebas")
        CBOCODIGOSIMULACRO.DataSource = DQ.Tables("Pruebas")
        CBOCODIGOSIMULACRO.DisplayMember = "codigo_prueba"
    End Sub

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click

        If CBOCANTIDAD.Text = "" Then
            MsgBox("NO SE ENCUENTRAN ESTUDIANTES REGISTRADOS PARA ESTE GRUPO", 16, "MENSAJE ERROR")
        Else

            Try

                Dim PEPE As Date
                PEPE = DateTimePicker2.Value
                PEPE = Format(PEPE, "dd/MM/yyyy")

                Dim PEPE1 As Date
                PEPE1 = DateTimePicker1.Value
                PEPE1 = Format(PEPE1, "dd/MM/yyyy")

                Dim query As String = "INSERT INTO Reportar_Ingresos(Codigo_Colegio,Colegio,Ciudad,Grado,Grupo,Numero_Estudiantes,Codigo_Simulacro,Nombre_Prueba," & _
               "Fecha_Aplicacion,Fecha_Ingreso,Fecha_Escaneo,Fecha_Analizar,Fecha_Calificar,Impresion_Individuales,Impresion_Sabanas,Impresion_Generales,Fecha_Salida)" & _
               "VALUES (@codigo_colegio,@colegio,@ciudad,@grado,@grupo,@numero_estudiantes,@codigo_simulacro,@nombre_prueba,@fecha_aplicacion,@fecha_ingreso,@fecha_escaneo,@fecha_analizar,@fecha_calificar,@impresion_individuales,@impresion_sabanas,@impresion_generales,@fecha_salida)"

                Dim CMD As New OleDb.OleDbCommand(query, CN)
                CMD.Parameters.AddWithValue("@codigo_colegio", CBOCODIGOSEDE.Text)
                CMD.Parameters.AddWithValue("@colegio", CBOCOLEGIOS.Text)
                CMD.Parameters.AddWithValue("@ciudad", CBOCIUDAD.Text)
                CMD.Parameters.AddWithValue("@grado", CBOGRADO.Text)
                CMD.Parameters.AddWithValue("@grupo", CBOCODIGOGRUPO.Text)
                CMD.Parameters.AddWithValue("@numero_estudiantes", CBOCANTIDAD.Text)
                CMD.Parameters.AddWithValue("@codigo_simulacro", CBOCODIGOSIMULACRO.Text)
                CMD.Parameters.AddWithValue("@nombre_prueba", CBOTIPO.Text)
                CMD.Parameters.AddWithValue("@fecha_aplicacion", PEPE1)
                CMD.Parameters.AddWithValue("@fecha_ingreso", PEPE)
                CMD.Parameters.AddWithValue("@fecha_escaneo", DBNull.Value)
                CMD.Parameters.AddWithValue("@fecha_analizar", DBNull.Value)
                CMD.Parameters.AddWithValue("@fecha_calificar", DBNull.Value)
                CMD.Parameters.AddWithValue("@impresion_individuales", DBNull.Value)
                CMD.Parameters.AddWithValue("@impresion_sabanas", DBNull.Value)
                CMD.Parameters.AddWithValue("@impresion_generales", DBNull.Value)
                CMD.Parameters.AddWithValue("@fecha_salida", DBNull.Value)
                CN.Open()
                CMD.ExecuteNonQuery()
                CN.Close()

                'Dim CMD2 As New OleDb.OleDbCommand("INSERT INTO Reportar_Ingresos VALUES ('" & CBOCODIGOSEDE.Text & "','" & CBOCOLEGIOS.Text & "','" & CBOCIUDAD.Text & "','" & CBOGRADO.Text & "','" & CBOCODIGOGRUPO.Text & "','" & CBOCANTIDAD.Text & "','" & CBOCODIGOSIMULACRO.Text & "','" & CBOTIPO.Text & "','" & PEPE1 & "','" & IsDBNull() & "','" & IsDBNull() & "','" & IsDBNull() & "','" & IsDBNull() & "','" & IsDBNull() & "','" & IsDBNull() & "','" & IsDBNull() & "','" & IsDBNull() & "')", CN)
                'CN.Open()
                'CMD2.ExecuteNonQuery()
                'CN.Close()
                MsgBox("Datos Registrados Correctamente", 8, "MENSAJE")

            Catch ex As Exception

                MsgBox("ALGO OCURRIO", 16, "MENSAJE ERROR")
                Me.Hide()

            End Try
        End If

    End Sub

    Private Sub CBOCIUDADES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCIUDADES.SelectedIndexChanged

        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios WHERE ciudad='" & CBOCIUDADES.Text & "'", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "colegios")
        CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        CBOCOLEGIOS.DisplayMember = "nombre"
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class