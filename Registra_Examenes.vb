Imports System.Data.OleDb
Public Class Registrar_Examenes



    'Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Sistemas3\d\sistemaevaluarte.accdb")

    Private Sub Registrar_Examenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        COPIA()
        CARGAR()
    End Sub


    Sub COPIA()
        MsgBox(My.Settings.usuario)

        If My.Settings.usuario = 1 Then
            Dim CMD1 As New OleDb.OleDbCommand("INSERT INTO Preguntas_aux( codigo ) SELECT codigo FROM Preguntas ", CN)
            CN.Open()
            CMD1.ExecuteNonQuery()
            CN.Close()

            My.Settings.usuario = 0
            My.Settings.Save()
            My.Settings.Reload()
        Else
            MsgBox(My.Settings.usuario)

            Dim CMD1 As New OleDb.OleDbCommand("DELETE FROM Preguntas_aux ", CN)
            CN.Open()
            CMD1.ExecuteNonQuery()
            CN.Close()

            My.Settings.usuario = 1
            My.Settings.Save()
            My.Settings.Reload()

            BTNBUSCAR.Enabled = False
            BTNGUARDAR.Enabled = False

        End If

    End Sub

    Sub CARGAR()
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_prueba  FROM Preguntas GROUP BY codigo_prueba ", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "Preguntas")
        CBOCODIGOPRUEBA.DataSource = DS.Tables("Preguntas")
        CBOCODIGOPRUEBA.DisplayMember = "codigo_prueba"
        CBOCODIGOPRUEBA.Enabled = False

        Dim DB As New OleDb.OleDbDataAdapter("SELECT  *  FROM Preguntas_aux", CN)
        Dim DP As New DataSet
        DB.Fill(DP, "Preguntas_aux")
        CBOCODIGOEXAMEN.DataSource = DP.Tables("Preguntas_aux")
        CBOCODIGOEXAMEN.DisplayMember = "codigo"

        'Dim DC As New OleDb.OleDbDataAdapter("SELECT  *  FROM Preguntas", CN)
        'Dim DQ As New DataSet
        'DC.Fill(DQ, "Preguntas")
        ' CBOCODIGOGRUPO.DataSource = DQ.Tables("Preguntas")
        'CBOCODIGOGRUPO.DisplayMember = "codigo_grupo"
        'CBOCODIGOGRUPO.Enabled = False

        Dim DD As New OleDb.OleDbDataAdapter("SELECT  *  FROM Preguntas", CN)
        Dim DR As New DataSet
        DD.Fill(DR, "Preguntas")
        CBOCODIGOSEDE.DataSource = DR.Tables("Preguntas")
        CBOCODIGOSEDE.DisplayMember = "codigocolegio"
        'CBOCODIGOSEDE.Enabled = False

        Dim DE As New OleDb.OleDbDataAdapter("SELECT  codigocolegio  FROM Preguntas GROUP BY codigocolegio ", CN)
        Dim DT As New DataSet
        DE.Fill(DT, "Preguntas")
        CBOCOLEGIO.DataSource = DT.Tables("Preguntas")
        CBOCOLEGIO.DisplayMember = "codigocolegio"
        CBOCOLEGIO.Enabled = False

        Dim DPP As New OleDb.OleDbDataAdapter("SELECT  codigo_grupo  FROM Preguntas GROUP BY codigo_grupo ", CN)
        Dim DTT As New DataSet
        DPP.Fill(DTT, "Preguntas")
        CBOCODIGOGRUPO.DataSource = DTT.Tables("Preguntas")
        CBOCODIGOGRUPO.DisplayMember = "codigo_grupo"
        CBOCODIGOGRUPO.Enabled = False


        'Dim DE As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios WHERE nombre='" & "1" & "' GROUP BY codigo_colegio", CN)
        'Dim DT As New DataSet
        'DE.Fill(DT, "colegios")
        'CBOCOLEGIO.Text = DT.Tables(0).Rows(0).Item(0).ToString
    End Sub


    Sub NUEVO()


        If CBOCODIGOGRUPO.Text = "" Then
            MsgBox("DEBE INGRESAR UN CODIGO DE GRUPO", 16, "ERROR")
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


                Dim CMD As New OleDb.OleDbCommand("INSERT INTO examenes VALUES ( '" & CBOCODIGOEXAMEN.Text & "','" & CBOCOLEGIO.Text & "','" & CBOCODIGOGRUPO.Text & "','" & CBOCODIGOPRUEBA.Text & "','" & CBOCODIGOESTUDIANTE.Text & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "')", CN)
                CN.Open()
                CMD.ExecuteNonQuery()
                CN.Close()
                MsgBox("Guardado en la base de datos", 8, "Confirmación")


                Dim CMD2 As New OleDb.OleDbCommand("DELETE FROM Preguntas_aux WHERE codigo='" & CBOCODIGOEXAMEN.Text & "'", CN)
                CN.Open()
                CMD2.ExecuteNonQuery()
                CN.Close()

                CARGAR()

            Catch ex As Exception
                MsgBox("CODIGO DUPLICADO EXAMEN YA REGISTARADO!", 16, "MENSAJE ERROR")
                Me.Hide()
            End Try
        End If

    End Sub

    Sub LIMPIAR()
        'TXTNOMBRES.Text = ""
        'TXTAPELLIDOS.Text = ""
        'TXTIDENTIFICACION.Text = ""
        'TXTEMAIL.Text = ""
        'TXTDIRECCION.Text = ""
        'TXTTELEFONO.Text = ""
        'TXTCODIGOESTUDIANTE.Text = ""
        CBOCODIGOESTUDIANTE.Text = " "
    End Sub


    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        NUEVO()
        LIMPIAR()
        If CBOCODIGOEXAMEN.Text = "" Then
            BTNGUARDAR.Enabled = False
            MsgBox("TERMINO DE REGISTRAR TODOS LOS EXAMENES", 32, "FINALIZACIÓN")
        End If
    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        Me.Hide()
    End Sub

    Private Sub CBOCODIGOPRUEBA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCODIGOPRUEBA.SelectedIndexChanged

    End Sub
End Class