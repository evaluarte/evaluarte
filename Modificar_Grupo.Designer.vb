<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Grupo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Grupo))
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.CBOGRADO = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBOJORNADA = New System.Windows.Forms.ComboBox()
        Me.TXTNUMEROESTUDIANTES = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBOMODALIDAD = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBOCODIGOGRUPO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTCOD = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.Location = New System.Drawing.Point(348, 227)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(40, 40)
        Me.BTNBUSCAR.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.BTNBUSCAR, "SALIR")
        Me.BTNBUSCAR.UseVisualStyleBackColor = True
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackgroundImage = CType(resources.GetObject("BTNGUARDAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNGUARDAR.Location = New System.Drawing.Point(276, 227)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(40, 40)
        Me.BTNGUARDAR.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.BTNGUARDAR, "GUARDAR")
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'CBOGRADO
        '
        Me.CBOGRADO.FormattingEnabled = True
        Me.CBOGRADO.Location = New System.Drawing.Point(408, 151)
        Me.CBOGRADO.Name = "CBOGRADO"
        Me.CBOGRADO.Size = New System.Drawing.Size(54, 21)
        Me.CBOGRADO.TabIndex = 77
        Me.CBOGRADO.Text = "11°"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(290, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 14)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Grado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 14)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Maximo Estudiantes:"
        '
        'CBOJORNADA
        '
        Me.CBOJORNADA.FormattingEnabled = True
        Me.CBOJORNADA.Location = New System.Drawing.Point(408, 182)
        Me.CBOJORNADA.Name = "CBOJORNADA"
        Me.CBOJORNADA.Size = New System.Drawing.Size(102, 21)
        Me.CBOJORNADA.TabIndex = 74
        Me.CBOJORNADA.Text = "MAÑANA"
        '
        'TXTNUMEROESTUDIANTES
        '
        Me.TXTNUMEROESTUDIANTES.Location = New System.Drawing.Point(190, 182)
        Me.TXTNUMEROESTUDIANTES.MaxLength = 2
        Me.TXTNUMEROESTUDIANTES.Name = "TXTNUMEROESTUDIANTES"
        Me.TXTNUMEROESTUDIANTES.Size = New System.Drawing.Size(44, 20)
        Me.TXTNUMEROESTUDIANTES.TabIndex = 73
        Me.TXTNUMEROESTUDIANTES.Text = "99"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(290, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 14)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Jornada:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 14)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Modalidad:"
        '
        'CBOMODALIDAD
        '
        Me.CBOMODALIDAD.Enabled = False
        Me.CBOMODALIDAD.FormattingEnabled = True
        Me.CBOMODALIDAD.Location = New System.Drawing.Point(190, 146)
        Me.CBOMODALIDAD.MaxLength = 1
        Me.CBOMODALIDAD.Name = "CBOMODALIDAD"
        Me.CBOMODALIDAD.Size = New System.Drawing.Size(44, 21)
        Me.CBOMODALIDAD.TabIndex = 70
        Me.CBOMODALIDAD.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 14)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Código Grupo:"
        '
        'CBOCODIGOGRUPO
        '
        Me.CBOCODIGOGRUPO.FormattingEnabled = True
        Me.CBOCODIGOGRUPO.Location = New System.Drawing.Point(408, 113)
        Me.CBOCODIGOGRUPO.MaxDropDownItems = 100
        Me.CBOCODIGOGRUPO.MaxLength = 2
        Me.CBOCODIGOGRUPO.Name = "CBOCODIGOGRUPO"
        Me.CBOCODIGOGRUPO.Size = New System.Drawing.Size(54, 21)
        Me.CBOCODIGOGRUPO.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.CBOCODIGOGRUPO, "INGRESE GRUPO")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 14)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Código Colegio:"
        '
        'TXTCOD
        '
        Me.TXTCOD.Enabled = False
        Me.TXTCOD.Location = New System.Drawing.Point(190, 109)
        Me.TXTCOD.MaxLength = 3
        Me.TXTCOD.Name = "TXTCOD"
        Me.TXTCOD.Size = New System.Drawing.Size(44, 20)
        Me.TXTCOD.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.TXTCOD, "CODIGO COLEGIO")
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "ACTUALIZAR"
        '
        'Modificar_Grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(548, 299)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.CBOGRADO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBOJORNADA)
        Me.Controls.Add(Me.TXTNUMEROESTUDIANTES)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBOMODALIDAD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBOCODIGOGRUPO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTCOD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Grupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar_Grupo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents CBOGRADO As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBOJORNADA As System.Windows.Forms.ComboBox
    Friend WithEvents TXTNUMEROESTUDIANTES As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBOMODALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOGRUPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTCOD As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
