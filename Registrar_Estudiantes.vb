Imports System.Data.OleDb

Public Class Registrar_Estudiantes


    Public pepe1 As String

    'Dim CN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Sistemas3\d\sistemaevaluarte.accdb")
    Dim b As Integer
    Public cantidad As String
    Public CONTROL As Boolean = False
    Public estudianteuno As String = "00"
    Public restoestudiantes As String
    Public CODIGOEXAMEN As String
    Public CODEXAMEN As Integer = 0

    Public cantidad_estudiantes As String
    Public cantidad_restantes As String
    Public numero_comotal As String

    Public AUX_NUMERO As String

    Sub CARGAR()

        'Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_prueba  FROM Preguntas GROUP BY codigo_prueba ", CN)
        'Dim DS As New DataSet
        'DA.Fill(DS, "Preguntas")
        'CBOCODIGOPRUEBA.DataSource = DS.Tables("Preguntas")
        'CBOCODIGOPRUEBA.DisplayMember = "codigo_prueba"
        'CBOCODIGOPRUEBA.Enabled = False

        'Dim b As String
        'Dim DD As New OleDb.OleDbDataAdapter("SELECT  *  FROM colegios", CN)
        'Dim DR As New DataSet
        'DD.Fill(DR, "colegios")
        'CBOCODIGOSEDE.DataSource = DR.Tables("colegios")
        'CBOCODIGOSEDE.DisplayMember = "codigo_colegio"
        'CBOCODIGOSEDE.Enabled = False
        'b = CBOCODIGOSEDE.Text

        BTNMATRICULAROTRO.Visible = False
        BTNGUARDAR.Visible = False
        TXTMATRICULADO.Text = Calificar_examenes.LABELUSUARIO.Text


        'Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios", CN)
        'Dim DF As New DataSet
        'DB.Fill(DF, "colegios")
        'CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        'CBOCOLEGIOS.DisplayMember = "nombre"

        Dim DH As New OleDb.OleDbDataAdapter("SELECT  ciudad  FROM colegios GROUP BY ciudad", CN)
        Dim DM As New DataSet
        DH.Fill(DM, "colegios")
        CBOCIUDADES.DataSource = DM.Tables("colegios")
        CBOCIUDADES.DisplayMember = "ciudad"


        'Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios", CN)
        'Dim DS As New DataSet
        'DA.Fill(DS, "colegios")
        'CBOCODIGOSEDE.DataSource = DS.Tables("colegios")
        'CBOCODIGOSEDE.DisplayMember = "codigo_colegio"




        'CBOCODIGOGRUPO.Enabled = False
        'Dim DE As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios", CN)
        'Dim DT As New DataSet
        'DE.Fill(DT, "colegios")
        'CBOCOLEGIO.DataSource = DT.Tables("colegios")
        'CBOCOLEGIO.DisplayMember = "nombre"
        ''CBOCOLEGIO.Enabled = False

        CBOANO.Items.Add("2012")
        CBOANO.Items.Add("2013")
        CBOANO.Items.Add("2014")
        CBOANO.Items.Add("2015")
        CBOANO.Items.Add("2016")
        CBOANO.Items.Add("2017")
        CBOANO.Items.Add("2018")
        CBOANO.Items.Add("2019")
        CBOANO.Items.Add("2020")

        CBOTIPOPRUEBA.Items.Add("1")
        CBOTIPOPRUEBA.Items.Add("2")
        CBOTIPOPRUEBA.Items.Add("3")
        CBOTIPOPRUEBA.Items.Add("4")

    End Sub

    'Sub COPIA()
    '   If Calificar_examenes.Y = 0 Then
    ' Dim CMD1 As New OleDb.OleDbCommand("INSERT INTO Preguntas_aux( codigo ) SELECT codigo FROM Preguntas ", CN)
    '        CN.Open()
    '        CMD1.ExecuteNonQuery()
    '        CN.Close()
    '    End If
    '    Calificar_examenes.Y = 1
    'End Sub

    Sub NUEVO()

        'Dim codigo_estudiante As String

        ' Dim DC As New OleDb.OleDbDataAdapter("SELECT  codigo  FROM estudiantes WHERE codigo='" & TXTCODIGOESTUDIANTE.Text & "'", CN)
        ' Dim DF As New DataSet
        ' DC.Fill(DF, "estudiantes")
        'TXTCESTUDIANTE.Text = DF.Tables(0).Rows(0).Item(0).ToString
        'codigo_estudiante = TXTCESTUDIANTE.Text

        If TXTCODIGOESTUDIANTE.Text = "" Or TXTNOMBRES.Text = "" Or TXTAPELLIDOS.Text = "" Then
            MsgBox("FALTA LLENAR ALGUNOS CAMPOS IMPORTANTES EN EL FORMULARIO ", 16, "ERROR")
            'ElseIf TXTCODIGOESTUDIANTE.Text = codigo_estudiante.ToString Then
            '    MsgBox("CODIGO REPETIDO", 16, "ERROR")
        Else
            Try
                'Dim codigo_colegio As String


                'Dim DE As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios WHERE nombre='" & .Text & "' GROUP BY codigo_colegio", CN)
                'Dim DT As New DataSet
                'DE.Fill(DT, "colegios")

                'LABELCODIGO.Text = DT.Tables(0).Rows(0).Item(0).ToString
                'codigo_colegio = LABELCODIGO.Text

                'MsgBox(TXTCODIGOESTUDIANTE.Text)

                Dim PEPE As Date
                PEPE = DateTimePicker1.Value
                PEPE = Format(PEPE, "dd/MM/yyyy")
                ' CODEXAMEN = CODEXAMEN + 1

                'MsgBox(CBOASOCIADO.Text)


                Dim CMD As New OleDb.OleDbCommand("INSERT INTO estudiantes VALUES ( '" & TXTCODIGOESTUDIANTE.Text & "','" & CBOCODIGOSEDE.Text & "','" & CBOASOCIADO.Text & "','" & CBOCODIGOGRUPO.Text & "','" & TXTNOMBRES.Text.ToUpper & "','" & TXTAPELLIDOS.Text.ToUpper & "','" & PEPE & "','" & TXTMATRICULADO.Text & "','" & TXTIDENTIFICACION.Text & "','" & TXTDIRECCION.Text.ToUpper & "','" & TXTTELEFONO.Text & "','" & TXTEMAIL.Text & "')", CN)
                CN.Open()
                CMD.ExecuteNonQuery()
                CN.Close()
                MsgBox("Guardado en la base de datos", 8, "Confirmación")


                Dim CMD1 As New OleDb.OleDbCommand("UPDATE  grupos SET restantes='" & cantidad_restantes & "' WHERE codigo_colegios='" & CBOCODIGOSEDE.Text & "' AND  codigo_gupo='" & CBOCODIGOGRUPO.Text & "'", CN)
                CN.Open()
                CMD1.ExecuteNonQuery()
                CN.Close()


                Dim CMD2 As New OleDb.OleDbCommand("UPDATE  grupos SET matriculados='" & AUX_NUMERO & "' WHERE codigo_colegios='" & CBOCODIGOSEDE.Text & "' AND  codigo_gupo='" & CBOCODIGOGRUPO.Text & "'", CN)
                CN.Open()
                CMD2.ExecuteNonQuery()
                CN.Close()
                'CN.Close()
                'MOSTRAR()
                'MsgBox("HA SIDO ACTUALIZADO EN LA BASE DE DATOS")


                ' Dim CMD1 As New OleDb.OleDbCommand("INSERT INTO examenes VALUES ( '" & CODEXAMEN & "','" & CBOCODIGOSEDE.Text & "','" & CBOCODIGOGRUPO.Text & "','" & CBOTIPOPRUEBA.Text & "','" & TXTCODIGOESTUDIANTE.Text & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "')", CN)
                ' CN.Open()
                'CMD1.ExecuteNonQuery()
                ' CN.Close()
                'MsgBox("Guardado en la base de datos", 8, "Confirmación")



                'Dim CMD2 As New OleDb.OleDbCommand("DELETE FROM Preguntas_aux WHERE codigo='" & CBOCODIGOEXAMEN.Text & "'", CN)
                'CN.Open()
                'CMD2.ExecuteNonQuery()
                'CN.Close()

                'CARGAR()


            Catch ex As Exception
                MsgBox("CODIGO DUPLICADO! o ERROR AL INSERTAR EN LA TABLA ESTUDIANTES", 16, "MENSAJE ERROR")
                Me.Hide()
            End Try


        End If

    End Sub

    Sub LIMPIAR()

        TXTNOMBRES.Text = ""
        TXTAPELLIDOS.Text = ""
        TXTIDENTIFICACION.Text = ""

        TXTEMAIL.Text = ""
        TXTDIRECCION.Text = ""
        TXTTELEFONO.Text = ""
        TXTCODIGOESTUDIANTE.Text = ""
    End Sub


    Private Sub Registrar_Estudiantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        Me.Hide()
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If TXTCODIGOESTUDIANTE.Text = "" Or TXTNOMBRES.Text = "" Or TXTAPELLIDOS.Text = "" Then
            MsgBox("FALTA LLENAR ALGUNOS CAMPOS IMPORTANTES EN EL FORMULARIO ", 16, "ERROR")
            'ElseIf TXTCODIGOESTUDIANTE.Text = codigo_estudiante.ToString Then
            '    MsgBox("CODIGO REPETIDO", 16, "ERROR")
        Else
            NUEVO()
            LIMPIAR()
            Button1.Enabled = True
            BTNGUARDAR.Visible = False
            BTNMATRICULAROTRO.Visible = True

        End If
    End Sub

    Sub CONTARCANTIDAD()
        Dim DZ As New OleDb.OleDbDataAdapter("SELECT  cantidad_estudiantes  FROM grupos WHERE codigo_gupo='" & CBOCODIGOGRUPO.Text & "' GROUP BY cantidad_estudiantes", CN)
        Dim DY As New DataSet
        DZ.Fill(DY, "grupos")
        LABELCODIGO.Text = DY.Tables(0).Rows(0).Item(0).ToString
        cantidad = LABELCODIGO.Text
    End Sub


    Sub CREARCODIGO()


        Dim DD As New OleDb.OleDbDataAdapter("SELECT  cantidad_estudiantes  FROM grupos WHERE   codigo_gupo='" & CBOCODIGOGRUPO.Text & "'AND codigo_colegios='" & CBOCODIGOSEDE.Text & "'", CN)
        Dim PP As New DataSet
        DD.Fill(PP, "grupos")

        LABELCANTIDAD.Text = PP.Tables(0).Rows(0).Item(0).ToString
        cantidad_estudiantes = LABELCANTIDAD.Text
        'MsgBox(cantidad_estudiantes)


        Dim DE As New OleDb.OleDbDataAdapter("SELECT  restantes  FROM grupos WHERE   codigo_gupo='" & CBOCODIGOGRUPO.Text & "'AND codigo_colegios='" & CBOCODIGOSEDE.Text & "'", CN)
        Dim PQ As New DataSet
        DE.Fill(PQ, "grupos")

        TXTRESTANTES.Text = PQ.Tables(0).Rows(0).Item(0).ToString
        cantidad_restantes = TXTRESTANTES.Text
        'MsgBox(cantidad_restantes)


        cantidad_restantes = cantidad_restantes - 1


        'If cantidad_restantes = 0 Then
        'MsgBox("TERMINO DE REGISTRAR TODOS LOS ESTUDIANTES DE ESTE GRUPO", 16, "ALERTA")
        'Button1.Enabled = False
        'Me.Hide()
        'Else

        If cantidad_restantes = -1 Then

            cantidad_restantes = 98

            Dim codigocolegio As String = Nothing
            Dim codigogrupo As String = Nothing
            Dim ANO As String = Nothing
            Dim TOTALCODIGO As String = Nothing
            Dim recorte As String

            AUX_NUMERO = cantidad_estudiantes - cantidad_restantes

            restoestudiantes = "0" + CChar(AUX_NUMERO)
            'MsgBox(restoestudiantes)
            codigocolegio = CBOCODIGOSEDE.Text
            codigogrupo = CBOCODIGOGRUPO.Text
            ANO = CBOANO.Text
            recorte = Mid(ANO, 4, 4)

            TOTALCODIGO = recorte + codigocolegio + codigogrupo + restoestudiantes
            TXTCODIGOESTUDIANTE.Text = TOTALCODIGO
            'MsgBox(TOTALCODIGO)
        Else

            If (cantidad_estudiantes - cantidad_restantes) < 10 Then


                Dim codigocolegio As String = Nothing
                Dim codigogrupo As String = Nothing
                Dim ANO As String = Nothing
                Dim TOTALCODIGO As String = Nothing
                Dim recorte As String

                AUX_NUMERO = cantidad_estudiantes - cantidad_restantes


                restoestudiantes = "0" + CChar(AUX_NUMERO)
                'MsgBox(restoestudiantes)

                codigocolegio = CBOCODIGOSEDE.Text
                codigogrupo = CBOCODIGOGRUPO.Text
                ANO = CBOANO.Text
                recorte = Mid(ANO, 4, 4)

                TOTALCODIGO = recorte + codigocolegio + codigogrupo + restoestudiantes

                TXTCODIGOESTUDIANTE.Text = TOTALCODIGO
                'MsgBox(TOTALCODIGO)
            Else



                Dim codigocolegio As String = Nothing
                Dim codigogrupo As String = Nothing
                Dim ANO As String = Nothing
                Dim TOTALCODIGO As String = Nothing
                Dim recorte As String

                AUX_NUMERO = cantidad_estudiantes - cantidad_restantes


                restoestudiantes = AUX_NUMERO
                'MsgBox(restoestudiantes)

                codigocolegio = CBOCODIGOSEDE.Text
                codigogrupo = CBOCODIGOGRUPO.Text
                ANO = CBOANO.Text
                recorte = Mid(ANO, 4, 4)

                TOTALCODIGO = recorte + codigocolegio + codigogrupo + restoestudiantes

                TXTCODIGOESTUDIANTE.Text = TOTALCODIGO
                'MsgBox(TOTALCODIGO)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            CREARCODIGO()
            BTNMATRICULAROTRO.Visible = False
            BTNGUARDAR.Visible = True

            CBOCODIGOSEDE.Enabled = False
            CBOCODIGOGRUPO.Enabled = False
            CBOANO.Enabled = False
            Button1.Enabled = False
            CBOCOLEGIOS.Enabled = False


            Dim DA As New OleDb.OleDbDataAdapter("SELECT  grado  FROM grupos WHERE codigo_gupo='" & CBOCODIGOGRUPO.Text & "' GROUP BY grado", CN)
            Dim DS As New DataSet
            DA.Fill(DS, "grupos")
            CBOGRADO.DataSource = DS.Tables("grupos")
            CBOGRADO.DisplayMember = "grado"
            CBOGRADO.Enabled = False

            Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios", CN)
            Dim DF As New DataSet
            DB.Fill(DF, "colegios")
            CBOASOCIADO.DataSource = DF.Tables("colegios")
            CBOASOCIADO.DisplayMember = "nombre"

        Catch ex As Exception
            MsgBox("ESTE COLEGIO NO TIENE GRUPOS CREADOS", 16, "MENSAJE ERROR")
            Me.Hide()
        End Try

    End Sub


    Private Sub CBOCODIGOSEDE_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CBOCODIGOSEDE.MouseClick
        'Dim DC As New OleDb.OleDbDataAdapter("SELECT  *  FROM grupos WHERE codigo_colegio ='" & CBOCODIGOSEDE.Text & "'", CN)
        'Dim DQ As New DataSet
        'DC.Fill(DQ, "grupos")
        'CBOCODIGOGRUPO.DataSource = DQ.Tables("grupos")
        'CBOCODIGOGRUPO.DisplayMember = "codigo_gupo"
    End Sub

    Private Sub CBOCODIGOGRUPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'MsgBox("HOLA MUNDO")
        'Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_gupo  FROM grupos WHERE codigo_colegios='" & CBOCODIGOSEDE.Text & "' GROUP BY codigo_gupo", CN)
        'Dim DS As New DataSet
        'DA.Fill(DS, "colegios")
        ' CBOCODIGOSEDE.DataSource = DS.Tables("colegios")
        'CBOCODIGOSEDE.DisplayMember = "codigo_colegio"
    End Sub
    Private Sub CBOCODIGOGRUPO_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCODIGOSEDE.SelectedIndexChanged
        'MsgBox(CBOCODIGOSEDE.Text)
        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_gupo  FROM grupos WHERE codigo_colegios='" & CBOCODIGOSEDE.Text & "' GROUP BY codigo_gupo", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "grupos")
        CBOCODIGOGRUPO.DataSource = DS.Tables("grupos")
        CBOCODIGOGRUPO.DisplayMember = "codigo_gupo"

    End Sub

    Private Sub BTNMATRICULAROTRO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMATRICULAROTRO.Click
        CBOCODIGOGRUPO.Enabled = True
        CBOANO.Enabled = True
    End Sub

    Private Sub CARGAR_CODIGO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCOLEGIOS.SelectedIndexChanged

        Dim DA As New OleDb.OleDbDataAdapter("SELECT  codigo_colegio  FROM colegios WHERE nombre='" & CBOCOLEGIOS.Text & "'", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "colegios")
        CBOCODIGOSEDE.DataSource = DS.Tables("colegios")
        CBOCODIGOSEDE.DisplayMember = "codigo_colegio"
    End Sub

    Private Sub CBOCIUDADES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCIUDADES.SelectedIndexChanged

        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios WHERE ciudad='" & CBOCIUDADES.Text & "'", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "colegios")
        CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        CBOCOLEGIOS.DisplayMember = "nombre"

    End Sub

End Class