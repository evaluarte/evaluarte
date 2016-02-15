Public Class Registrar_Colegio

    'Public DATO As Integer
    Private Sub ColegiosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColegiosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ColegiosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SistemaevaluarteDataSet)
            Me.ColegiosTableAdapter.Fill(Me.SistemaevaluarteDataSet.colegios)
            Me.BindingNavigatorAddNewItem.Visible = True

            BTNAGREGARGRUPO.Visible = True
            BTNMODIFICARGRUPO.Visible = True
            BTNMODIFICAR.Visible = True

            Codigo_colegioTextBox.Enabled = False
            NombreTextBox.Enabled = False
            DireccionTextBox.Enabled = False
            CiudadTextBox.Enabled = False
            TelefonoTextBox.Enabled = False
            FechaDateTimePicker.Enabled = False
        Catch ex As Exception
            MsgBox("ESTA SEDE YA FUE REGISTRADA", 16, "MENSAJE ERROR")
        End Try

    End Sub

    Private Sub Registrar_Colegio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SistemaevaluarteDataSet.colegios' table. You can move, or remove it, as needed.
        Try
            Me.ColegiosTableAdapter.Fill(Me.SistemaevaluarteDataSet.colegios)
        Catch ex As Exception
            MsgBox("HA OCURRIDO UN ERROR AL CARGAR LOS DATOS", 16, "error")
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Codigo_colegioTextBox.Enabled = True
        NombreTextBox.Enabled = True
        DireccionTextBox.Enabled = True
        CiudadTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
        FechaDateTimePicker.Enabled = True
    End Sub

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNAGREGARGRUPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGARGRUPO.Click

        'MsgBox(Codigo_colegioTextBox.Text)
        EditAgregar_Grupo.codigocolegio = Codigo_colegioTextBox.Text
        'My.Settings.dato = Codigo_colegioTextBox.Text
        'My.Settings.Save()
        'My.Settings.Reload()
        EditAgregar_Grupo.Show()
    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Try
            Me.BindingNavigatorAddNewItem.Visible = False
            BTNAGREGARGRUPO.Visible = False
            BTNMODIFICARGRUPO.Visible = False
            BTNMODIFICAR.Visible = False

            Codigo_colegioTextBox.Enabled = True
            NombreTextBox.Enabled = True
            DireccionTextBox.Enabled = True
            CiudadTextBox.Enabled = True
            TelefonoTextBox.Enabled = True
            FechaDateTimePicker.Enabled = True
        Catch ex As Exception

            Me.ColegiosTableAdapter.Fill(Me.SistemaevaluarteDataSet.colegios)

        End Try

    End Sub

    Private Sub BTNMODIFICARGRUPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICARGRUPO.Click
        My.Settings.dato = Codigo_colegioTextBox.Text
        My.Settings.Save()
        My.Settings.Reload()
        Modificar_Grupo.Show()
    End Sub

    Private Sub ColegiosBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColegiosBindingNavigator.RefreshItems

    End Sub
End Class