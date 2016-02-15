<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportar_Ingreso_Pruebas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportar_Ingreso_Pruebas))
        Me.CBOCOLEGIOS = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CBOCODIGOSEDE = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBOCODIGOGRUPO = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBOTIPO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNCALIFICAR = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.CBOCODIGOSIMULACRO = New System.Windows.Forms.ComboBox()
        Me.CBOGRADO = New System.Windows.Forms.ComboBox()
        Me.CBOCIUDAD = New System.Windows.Forms.ComboBox()
        Me.CBOCIUDADES = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBOCANTIDAD = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'CBOCOLEGIOS
        '
        Me.CBOCOLEGIOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCOLEGIOS.FormattingEnabled = True
        Me.CBOCOLEGIOS.Location = New System.Drawing.Point(240, 152)
        Me.CBOCOLEGIOS.MaxDropDownItems = 50
        Me.CBOCOLEGIOS.Name = "CBOCOLEGIOS"
        Me.CBOCOLEGIOS.Size = New System.Drawing.Size(269, 21)
        Me.CBOCOLEGIOS.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(119, 154)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 14)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "Nombre Colegio:"
        '
        'CBOCODIGOSEDE
        '
        Me.CBOCODIGOSEDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOSEDE.Enabled = False
        Me.CBOCODIGOSEDE.FormattingEnabled = True
        Me.CBOCODIGOSEDE.Location = New System.Drawing.Point(240, 183)
        Me.CBOCODIGOSEDE.MaxDropDownItems = 50
        Me.CBOCODIGOSEDE.Name = "CBOCODIGOSEDE"
        Me.CBOCODIGOSEDE.Size = New System.Drawing.Size(66, 21)
        Me.CBOCODIGOSEDE.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(124, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 14)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Código Colegio:"
        '
        'CBOCODIGOGRUPO
        '
        Me.CBOCODIGOGRUPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOGRUPO.FormattingEnabled = True
        Me.CBOCODIGOGRUPO.Location = New System.Drawing.Point(240, 210)
        Me.CBOCODIGOGRUPO.MaxDropDownItems = 50
        Me.CBOCODIGOGRUPO.Name = "CBOCODIGOGRUPO"
        Me.CBOCODIGOGRUPO.Size = New System.Drawing.Size(42, 21)
        Me.CBOCODIGOGRUPO.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(133, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 14)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Código Grupo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 14)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Cantidad Estudiantes:"
        '
        'CBOTIPO
        '
        Me.CBOTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOTIPO.FormattingEnabled = True
        Me.CBOTIPO.Location = New System.Drawing.Point(240, 267)
        Me.CBOTIPO.Name = "CBOTIPO"
        Me.CBOTIPO.Size = New System.Drawing.Size(269, 21)
        Me.CBOTIPO.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(140, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 14)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Tipo Prueba:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(240, 294)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(113, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 14)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Fecha Aplicacion:"
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.Location = New System.Drawing.Point(351, 354)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(49, 46)
        Me.BTNSALIR.TabIndex = 8
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'BTNCALIFICAR
        '
        Me.BTNCALIFICAR.BackgroundImage = CType(resources.GetObject("BTNCALIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNCALIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCALIFICAR.Location = New System.Drawing.Point(273, 354)
        Me.BTNCALIFICAR.Name = "BTNCALIFICAR"
        Me.BTNCALIFICAR.Size = New System.Drawing.Size(49, 46)
        Me.BTNCALIFICAR.TabIndex = 7
        Me.BTNCALIFICAR.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(240, 320)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker2.TabIndex = 86
        Me.DateTimePicker2.Visible = False
        '
        'CBOCODIGOSIMULACRO
        '
        Me.CBOCODIGOSIMULACRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOSIMULACRO.Enabled = False
        Me.CBOCODIGOSIMULACRO.FormattingEnabled = True
        Me.CBOCODIGOSIMULACRO.Location = New System.Drawing.Point(3, 339)
        Me.CBOCODIGOSIMULACRO.MaxDropDownItems = 50
        Me.CBOCODIGOSIMULACRO.Name = "CBOCODIGOSIMULACRO"
        Me.CBOCODIGOSIMULACRO.Size = New System.Drawing.Size(10, 21)
        Me.CBOCODIGOSIMULACRO.TabIndex = 87
        '
        'CBOGRADO
        '
        Me.CBOGRADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOGRADO.Enabled = False
        Me.CBOGRADO.FormattingEnabled = True
        Me.CBOGRADO.Location = New System.Drawing.Point(3, 313)
        Me.CBOGRADO.MaxDropDownItems = 50
        Me.CBOGRADO.Name = "CBOGRADO"
        Me.CBOGRADO.Size = New System.Drawing.Size(10, 21)
        Me.CBOGRADO.TabIndex = 88
        '
        'CBOCIUDAD
        '
        Me.CBOCIUDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCIUDAD.Enabled = False
        Me.CBOCIUDAD.FormattingEnabled = True
        Me.CBOCIUDAD.Location = New System.Drawing.Point(3, 286)
        Me.CBOCIUDAD.MaxDropDownItems = 50
        Me.CBOCIUDAD.Name = "CBOCIUDAD"
        Me.CBOCIUDAD.Size = New System.Drawing.Size(10, 21)
        Me.CBOCIUDAD.TabIndex = 89
        '
        'CBOCIUDADES
        '
        Me.CBOCIUDADES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCIUDADES.FormattingEnabled = True
        Me.CBOCIUDADES.Location = New System.Drawing.Point(240, 125)
        Me.CBOCIUDADES.MaxDropDownItems = 50
        Me.CBOCIUDADES.Name = "CBOCIUDADES"
        Me.CBOCIUDADES.Size = New System.Drawing.Size(269, 21)
        Me.CBOCIUDADES.TabIndex = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Ciudad:"
        '
        'CBOCANTIDAD
        '
        Me.CBOCANTIDAD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBOCANTIDAD.FormattingEnabled = True
        Me.CBOCANTIDAD.Location = New System.Drawing.Point(240, 241)
        Me.CBOCANTIDAD.MaxDropDownItems = 50
        Me.CBOCANTIDAD.Name = "CBOCANTIDAD"
        Me.CBOCANTIDAD.Size = New System.Drawing.Size(42, 21)
        Me.CBOCANTIDAD.TabIndex = 92
        '
        'Reportar_Ingreso_Pruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(608, 412)
        Me.Controls.Add(Me.CBOCANTIDAD)
        Me.Controls.Add(Me.CBOCIUDADES)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBOCIUDAD)
        Me.Controls.Add(Me.CBOGRADO)
        Me.Controls.Add(Me.CBOCODIGOSIMULACRO)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNCALIFICAR)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBOTIPO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBOCODIGOGRUPO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBOCODIGOSEDE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBOCOLEGIOS)
        Me.Controls.Add(Me.Label18)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reportar_Ingreso_Pruebas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportar_Ingreso_Pruebas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBOCOLEGIOS As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOSEDE As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOGRUPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBOTIPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents BTNCALIFICAR As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBOCODIGOSIMULACRO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOGRADO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOCIUDAD As System.Windows.Forms.ComboBox
    Friend WithEvents CBOCIUDADES As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBOCANTIDAD As System.Windows.Forms.ComboBox
End Class
