Public Class Imprimir_Todos

    Public TIPO As Double

    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click

        Control = 9
        Estudiantes_Colegio.simulacro = CBOSIMULACRO.Text
        Estudiantes_Colegio.variable = CBOCODIGOSEDE.Text
        Estudiantes_Colegio.grupo = CBOCODIGOGRUPO.Text
        'Estudiantes_Colegio.fecha = DateTimePicker1.Value
        Estudiantes_Colegio.codigo_prueba = CBOCODIGOSIMULACRO.Text
        Estudiantes_Colegio.Show()
        Estudiantes_Colegio.Show()
    End Sub

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
    End Sub

    Private Sub Imprimir_Todos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Sub CARGAR()

        Dim DH As New OleDb.OleDbDataAdapter("SELECT  ciudad  FROM colegios GROUP BY ciudad", CN)
        Dim DM As New DataSet
        DH.Fill(DM, "colegios")
        CBOCIUDADES.DataSource = DM.Tables("colegios")
        CBOCIUDADES.DisplayMember = "ciudad"

        Dim DB As New OleDb.OleDbDataAdapter("SELECT DISTINCT codigo  FROM Formato_Examen_Cantidad", CN)
        Dim DD As New DataSet
        DB.Fill(DD, "Formato_Examen_Cantidad")
        CBOSIMULACRO.DataSource = DD.Tables("Formato_Examen_Cantidad")
        CBOSIMULACRO.DisplayMember = "codigo"
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

        Dim Cantidad_Estudiantes As Integer = 0

        Dim DA As New OleDb.OleDbDataAdapter("SELECT  matriculados  FROM grupos WHERE   codigo_gupo='" & CBOCODIGOGRUPO.Text & "'AND codigo_colegios='" & CBOCODIGOSEDE.Text & "'", CN)
        Dim DS As New DataSet
        DA.Fill(DS, "grupos")
        CBOGRADO.DataSource = DS.Tables("grupos")  ' MATRICULADOS
        CBOGRADO.DisplayMember = "matriculados"

    End Sub

    Private Sub CODIGO_SIMULACRO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOTIPO.SelectedIndexChanged
        Dim DL As New OleDb.OleDbDataAdapter("SELECT  codigo_prueba  FROM Pruebas WHERE nombre_prueba='" & CBOTIPO.Text & "'", CN)
        Dim DQ As New DataSet
        DL.Fill(DQ, "Pruebas")
        CBOCODIGOSIMULACRO.DataSource = DQ.Tables("Pruebas")
        CBOCODIGOSIMULACRO.DisplayMember = "codigo_prueba"

        CARGAR_TIPO()

        If TIPO = 1 Then
            CBOSIMULACRO.Visible = False
            Label10.Visible = False
        ElseIf TIPO = 2 Then
            CBOSIMULACRO.Visible = False
            Label10.Visible = False
        ElseIf TIPO = 3 Then
            CBOSIMULACRO.Visible = True
            Label10.Visible = True
        ElseIf TIPO = 4 Then
            CBOSIMULACRO.Visible = True
            Label10.Visible = True
        End If


    End Sub

    Sub CARGAR_TIPO()
        Dim CMD As New OleDb.OleDbCommand("SELECT  codigo_prueba  FROM Pruebas WHERE nombre_prueba='" & CBOTIPO.Text & "'", CN)
        Dim DR As OleDb.OleDbDataReader
        CN.Open()
        DR = CMD.ExecuteReader
        If DR.Read Then
            TIPO = DR(0)
        Else
            'MsgBox("ERROR NO SE ENCONTRO EL REGISTRO")
        End If
        CN.Close()
    End Sub

    Private Sub CBOCIUDADES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCIUDADES.SelectedIndexChanged
        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios WHERE ciudad='" & CBOCIUDADES.Text & "'", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "colegios")
        CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        CBOCOLEGIOS.DisplayMember = "nombre"
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub
End Class