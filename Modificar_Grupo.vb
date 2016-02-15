Imports System.Data.OleDb
Public Class Modificar_Grupo

    Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\sistemaevaluarte.accdb")


    Private Sub Modificar_Grupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SistemaevaluarteDataSet.grupos' table. You can move, or remove it, as needed.
        cargar()
    End Sub


    Sub cargar()
        TXTCOD.Text = My.Settings.dato
        'MsgBox(TXTCOD.Text)
        'Dim DZ As New OleDb.OleDbDataAdapter("SELECT  codigo_colegios  FROM grupos", CN)
        'Dim DY As New DataSet
        'DZ.Fill(DY, "grupos")

        ' CBOCODIGOGRUPO.Text = DY.Tables(0).Rows(0).Item(0).ToString


        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_gupo  FROM grupos  WHERE codigo_colegios='" & TXTCOD.Text & "' GROUP BY codigo_gupo ", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "grupos")
        CBOCODIGOGRUPO.DataSource = DS.Tables("grupos")
        CBOCODIGOGRUPO.DisplayMember = "codigo_gupo"

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


    Sub GUARDAR()

        If CBOCODIGOGRUPO.Text = "" Or TXTNUMEROESTUDIANTES.Text = "" Then
            MsgBox("FALTA LLENAR EL CAMPO NÚMERO DE ESTUDIATES", 16, "ERROR")
            'ElseIf TXTCODIGOESTUDIANTE.Text = codigo_estudiante.ToString Then
            '    MsgBox("CODIGO REPETIDO", 16, "ERROR")
        Else

            Try
                'Dim codigo_colegio As String

                'Dim DE As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios WHERE nombre='" & "1" & "' GROUP BY codigo_colegio", CN)
                ' Dim DT As New DataSet
                'DE.Fill(DT, "colegios")

                'LABELCODIGO.Text = DT.Tables(0).Rows(0).Item(0).ToString
                'codigo_colegio = LABELCODIGO.Text

                'codigo_gupo='" & CBOCODIGOGRUPO.Text & "', codigo_colegios='" & TXTCOD.Text & "',

                Dim CMD As New OleDb.OleDbCommand("UPDATE  grupos SET  modalidad='" & CBOMODALIDAD.Text & "', cantidad_estudiantes='" & TXTNUMEROESTUDIANTES.Text & "', jornada='" & CBOJORNADA.Text & "', matriculados='" & "" & "', grado='" & CBOGRADO.Text & "', restantes='" & 0 & "'WHERE codigo_colegios='" & TXTCOD.Text & "' AND  codigo_gupo='" & CBOCODIGOGRUPO.Text & "'", CN)
                CN.Open()
                CMD.ExecuteNonQuery()
                CN.Close()
                'MOSTRAR()
                MsgBox("HA SIDO ACTUALIZADO EN LA BASE DE DATOS")


                'MsgBox(TXTNUMEROESTUDIANTES.Text + 1) TXTNUMEROESTUDIANTES.Text.ToString Db.OleDbCommand("INSERT INTO grupo.ToString.ToUpper OCODIGOGRUPO.Text & "','" & TXTCOD.Text & "','" & CBOMODALIDAD.Text & codigo_colegiosROESTUDIANTES.Text & "','" & CBOJORNADA.Text & "','" & numero & "','" & CBOGRADO.Text & "')", CN)
                'CN.Open()
                ' CMD1.ExecuteNonQuery()
                ' CN.Close()
                ' MsgBox("Guardado en la base de datos", 8, "Confirmación")


                'Dim CMD2 As New OleDb.OleDbCommand("DELETE FROM Preguntas_aux WHERE codigo='" & CBOCODIGOEXAMEN.Text & "'", CN)
                'CN.Open()
                'CMD2.ExecuteNonQuery()
                'CN.Close()

                'cargar()

            Catch ex As Exception
                'MsgBox("CODIGO DUPLICADO'ESTE GRUPO YA ESTA REGISTARADO!", 16, "MENSAJE ERROR")
                ' Me.Hide()
            End Try
        End If

    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        Me.Hide()
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        GUARDAR()
    End Sub


End Class