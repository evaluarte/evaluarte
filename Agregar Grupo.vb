Imports System.Data.OleDb
Public Class EditAgregar_Grupo
    Public codigocolegio As String
    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\sistemaevaluarte.accdb")


    Private Sub Agregar_Grupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SistemaevaluarteDataSet.grupos' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'SistemaevaluarteDataSet.grupos' table. You can move, or remove it, as needed
        cargar()
        CARGARPREDEFINIDOS()

    End Sub

    Sub cargar()

        'MsgBox(codigocolegio)

        TXTCODIGO.Text = codigocolegio
        'Dim DZ As New OleDb.OleDbDataAdapter("SELECT  codigo_colegios  FROM grupos", CN)
        'Dim DY As New DataSet
        'DZ.Fill(DY, "grupos")
        ' CBOCODIGOGRUPO.Text = DY.Tables(0).Rows(0).Item(0).ToString

        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_gupo  FROM grupos  WHERE codigo_colegios='" & codigocolegio & "' GROUP BY codigo_gupo ", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "grupos")
        CBOCODIGOGRUPO.DataSource = DS.Tables("grupos")
        CBOCODIGOGRUPO.DisplayMember = "codigo_gupo"
    End Sub

    Sub CARGARPREDEFINIDOS()
        CBOMODALIDAD.Items.Add("A")
        CBOMODALIDAD.Items.Add("B")
        CBOMODALIDAD.Items.Add("C")
        CBOMODALIDAD.Items.Add("D")

        CBOJORNADA.Items.Add("MAÑANA")
        CBOJORNADA.Items.Add("TARDE")
        CBOJORNADA.Items.Add("MAÑANA Y TARDE")

        CBOGRADO.Items.Add("3°")
        CBOGRADO.Items.Add("4°")
        CBOGRADO.Items.Add("5°")
        CBOGRADO.Items.Add("6°")
        CBOGRADO.Items.Add("7°")
        CBOGRADO.Items.Add("8°")
        CBOGRADO.Items.Add("9°")
        CBOGRADO.Items.Add("10°")
    End Sub

    Sub LIMPIAR()
        'CBOMODALIDAD.Text = ""
        CBOCODIGOGRUPO.Text = ""
        'TXTNUMEROESTUDIANTES.Text = ""

    End Sub

    Private Sub BTNMATRICULAROTRO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMATRICULAROTRO.Click
        LIMPIAR()
    End Sub
    Sub GUARDAR()

        If CBOCODIGOGRUPO.Text = "" Or TXTNUMEROESTUDIANTES.Text = "" Then
            MsgBox("FALTA LLENAR EL CAMPO NÚMERO DE ESTUDIATES", 16, "ERROR")
            'ElseIf TXTCODIGOESTUDIANTE.Text = codigo_estudiante.ToString Then
            '    MsgBox("CODIGO REPETIDO", 16, "ERROR")
        Else

            ' 
            'Dim codigo_colegio As String
            'Dim DE As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios WHERE nombre='" & "1" & "' GROUP BY codigo_colegio", CN)
            ' Dim DT As New DataSet
            'DE.Fill(DT, "colegios")
            'LABELCODIGO.Text = DT.Tables(0).Rows(0).Item(0).ToString
            'codigo_colegio = LABELCODIGO.Text
            Dim numero As Integer = 0
            Dim matriculados As String = ""
            'MsgBox(CBOCODIGOGRUPO.Text)
            'MsgBox(TXTCOD.Text)
            'MsgBox(CBOMODALIDAD.Text)
            'MsgBox(TXTNUMEROESTUDIANTES.Text)
            'MsgBox(CBOJORNADA.Text)
            'MsgBox(CBOGRADO.Text)
            'MsgBox(numero)

            Try


                Dim query As String = "INSERT INTO grupos (codigo_gupo,codigo_colegios,modalidad,cantidad_estudiantes,jornada," &
                    "matriculados,grado,restantes)" & "VALUES(@codigo,@colegio,@modalidad,@cantidad,@jornada,@matriculados,@grado,@restantes)"

                Dim CMD As New OleDb.OleDbCommand(query, CN)
                CMD.Parameters.AddWithValue("@codigo", CBOCODIGOGRUPO.Text)
                CMD.Parameters.AddWithValue("@colegio", TXTCODIGO.Text)
                CMD.Parameters.AddWithValue("@modalidad", CBOMODALIDAD.Text)
                CMD.Parameters.AddWithValue("@cantidad", TXTNUMEROESTUDIANTES.Text)
                CMD.Parameters.AddWithValue("@jornada", CBOJORNADA.Text)
                CMD.Parameters.AddWithValue("@matriculados", matriculados)
                CMD.Parameters.AddWithValue("@grado", CBOGRADO.Text)
                CMD.Parameters.AddWithValue("@restantes", numero)

                CN.Open()
                CMD.ExecuteNonQuery()
                CN.Close()

                ' Dim CMD1 As New OleDb.OleDbCommand("INSERT INTO grupos VALUES ( '" & CBOCODIGOGRUPO.Text & "','" & TXTCOD.Text & "','" & CBOMODALIDAD.Text & "','" & TXTNUMEROESTUDIANTES.Text & "','" & CBOJORNADA.Text & "','" & "" & "','" & CBOGRADO.Text & "','" & numero & "')", CN)
                'CN.Open()
                'CMD1.ExecuteNonQuery()
                'CN.Close()
                MsgBox("Guardado en la base de datos", 8, "Confirmación")


            Catch ex As Exception
                MsgBox("CODIGO DUPLICADO ESTE GRUPO YA ESTA REGISTARADO!", 16, "MENSAJE ERROR")
                Me.Hide()


            End Try

            'Dim CMD2 As New OleDb.OleDbCommand("DELETE FROM Preguntas_aux WHERE codigo='" & CBOCODIGOEXAMEN.Text & "'", CN)
            'CN.Open()
            'CMD2.ExecuteNonQuery()
            'CN.Close()
            'cargar()

            'Catch ex As Exception
            '    MsgBox("CODIGO DUPLICADO ESTE GRUPO YA ESTA REGISTARADO!", 16, "MENSAJE ERROR")
            '    Me.Hide()
            'End Try

        End If

    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        Me.Close()
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        GUARDAR()
        cargar()
        LIMPIAR()
    End Sub


End Class