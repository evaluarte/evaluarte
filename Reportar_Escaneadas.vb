Public Class Reportar_Escaneadas

    Private Sub Reportar_Escaneadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub
    Private Sub BTNCALIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCALIFICAR.Click
        MODIFICAR()
    End Sub
    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Hide()
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
    Sub CARGAR()

        Dim DH As New OleDb.OleDbDataAdapter("SELECT  ciudad  FROM colegios GROUP BY ciudad", CN)
        Dim DM As New DataSet
        DH.Fill(DM, "colegios")
        CBOCIUDADES.DataSource = DM.Tables("colegios")
        CBOCIUDADES.DisplayMember = "ciudad"

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

    End Sub

    Sub MODIFICAR()
        Dim PEPE As Date
        PEPE = DateTimePicker2.Value
        PEPE = Format(PEPE, "dd/MM/yyyy")

        If CBOCODIGOGRUPO.Text = "" Or CBOCIUDADES.Text = "" Then
            MsgBox("No se logro el registro, seleccione los datos", 16, "MENSAJE ALERTA")
        Else
            Dim CMD As New OleDb.OleDbCommand("UPDATE  Reportar_Ingresos SET Fecha_Escaneo='" & PEPE & "'  WHERE Codigo_Colegio='" & CBOCODIGOSEDE.Text & "'AND Grupo='" & CBOCODIGOGRUPO.Text & "'AND Codigo_Simulacro='" & CBOCODIGOSIMULACRO.Text & "'", CN)
            CN.Open()
            CMD.ExecuteNonQuery()
            CN.Close()
            CARGAR()
            MsgBox("Actualizado en la base de datos")
        End If

    End Sub

    Private Sub CBOCIUDADES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOCIUDADES.SelectedIndexChanged
        Dim DB As New OleDb.OleDbDataAdapter("SELECT  nombre  FROM colegios WHERE ciudad='" & CBOCIUDADES.Text & "'", CN)
        Dim DF As New DataSet
        DB.Fill(DF, "colegios")
        CBOCOLEGIOS.DataSource = DF.Tables("colegios")
        CBOCOLEGIOS.DisplayMember = "nombre"
    End Sub

    Private Sub CBOTIPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOTIPO.SelectedIndexChanged
        Dim DL As New OleDb.OleDbDataAdapter("SELECT  codigo_prueba  FROM Pruebas WHERE nombre_prueba='" & CBOTIPO.Text & "'", CN)
        Dim DQ As New DataSet
        DL.Fill(DQ, "Pruebas")
        CBOCODIGOSIMULACRO.DataSource = DQ.Tables("Pruebas")
        CBOCODIGOSIMULACRO.DisplayMember = "codigo_prueba"
    End Sub
End Class