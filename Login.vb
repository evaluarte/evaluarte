Public Class Login
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Public USUARIO As String
    Public CONTRASENA As String


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        CARGAR()

        If UsernameTextBox.Text = "" And PasswordTextBox.Text = "" Then
            MsgBox("Ingrese sus datos por favor", MsgBoxStyle.Information, "Contraseña Incorrecta")
        ElseIf UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Ingrese sus datos por favor", MsgBoxStyle.Information, "Contraseña Incorrecta")
        ElseIf UsernameTextBox.Text = USUARIO And PasswordTextBox.Text = CONTRASENA Then
            'MsgBox("Su conraseña es Correcta", MsgBoxStyle.Information, "Contraseña Correcta")
            Me.Hide()
            Calificar_examenes.usuario = USUARIO
            Calificar_examenes.ShowDialog()
        End If

    End Sub

    Sub CARGAR()
        'Try
        Dim DL As New OleDb.OleDbDataAdapter("SELECT  nombre FROM usuarios WHERE nombre='" & UsernameTextBox.Text & "'", CN)
        Dim DT As New DataSet
        DL.Fill(DT, "usuarios")
        LABELUSURIO.Text = DT.Tables(0).Rows(0).Item(0).ToString
        USUARIO = LABELUSURIO.Text
        'MsgBox(USUARIO)

        Dim DA As New OleDb.OleDbDataAdapter("SELECT  contrasena  FROM usuarios WHERE contrasena='" & PasswordTextBox.Text & "'", CN)
        Dim DB As New DataSet
        DA.Fill(DB, "usuarios")
        LABELCONTRASENA.Text = DB.Tables(0).Rows(0).Item(0).ToString
        CONTRASENA = LABELCONTRASENA.Text
        'MsgBox(CONTRASENA)

        'Catch ex As Exception
        '    MsgBox("Datos incorrectos", MsgBoxStyle.Information, "Datos incorrectos")
        'End Try


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.Click

    End Sub
End Class
