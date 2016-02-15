<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Niveles_pensamiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Niveles_pensamiento))
        Me.BTNCALIFICAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.NUMERO = New System.Windows.Forms.Label()
        Me.NUMERO2 = New System.Windows.Forms.Label()
        Me.CBNSIMULACRO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTCODIGOEXAMEN1 = New System.Windows.Forms.Label()
        Me.HOLA = New System.Windows.Forms.DataGridView()
        Me.TXTCODIGOEXAMEN = New System.Windows.Forms.Label()
        Me.CBOCODIGOPRUEBA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTNUMEROEXAMENES = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.CBOTIPO = New System.Windows.Forms.ComboBox()
        Me.TXTTIPO = New System.Windows.Forms.Label()
        Me.CBOGRUPO = New System.Windows.Forms.ComboBox()
        Me.CBOCODIGO = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.COPIAR_ENTABLA = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numero3 = New System.Windows.Forms.Label()
        Me.TXTDATOAUX = New System.Windows.Forms.Label()
        Me.CBOAUX = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBOSIMULACRO = New System.Windows.Forms.ComboBox()
        CType(Me.HOLA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNCALIFICAR
        '
        Me.BTNCALIFICAR.BackgroundImage = CType(resources.GetObject("BTNCALIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNCALIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCALIFICAR.Location = New System.Drawing.Point(96, 280)
        Me.BTNCALIFICAR.Name = "BTNCALIFICAR"
        Me.BTNCALIFICAR.Size = New System.Drawing.Size(46, 43)
        Me.BTNCALIFICAR.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BTNCALIFICAR, "Calificar")
        Me.BTNCALIFICAR.UseVisualStyleBackColor = True
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.Location = New System.Drawing.Point(176, 280)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(49, 43)
        Me.BTNSALIR.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.BTNSALIR, "Salir")
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'NUMERO
        '
        Me.NUMERO.AutoSize = True
        Me.NUMERO.Location = New System.Drawing.Point(73, 3)
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.Size = New System.Drawing.Size(51, 13)
        Me.NUMERO.TabIndex = 45
        Me.NUMERO.Text = "numero 2"
        Me.NUMERO.Visible = False
        '
        'NUMERO2
        '
        Me.NUMERO2.AutoSize = True
        Me.NUMERO2.BackColor = System.Drawing.Color.White
        Me.NUMERO2.Location = New System.Drawing.Point(142, 3)
        Me.NUMERO2.Name = "NUMERO2"
        Me.NUMERO2.Size = New System.Drawing.Size(92, 13)
        Me.NUMERO2.TabIndex = 48
        Me.NUMERO2.Text = "numero preguntas"
        Me.NUMERO2.Visible = False
        '
        'CBNSIMULACRO
        '
        Me.CBNSIMULACRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNSIMULACRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNSIMULACRO.Location = New System.Drawing.Point(512, 31)
        Me.CBNSIMULACRO.Name = "CBNSIMULACRO"
        Me.CBNSIMULACRO.Size = New System.Drawing.Size(62, 23)
        Me.CBNSIMULACRO.TabIndex = 49
        Me.CBNSIMULACRO.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(402, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 14)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "No. Simulacro:"
        Me.Label1.Visible = False
        '
        'TXTCODIGOEXAMEN1
        '
        Me.TXTCODIGOEXAMEN1.AutoSize = True
        Me.TXTCODIGOEXAMEN1.Location = New System.Drawing.Point(308, 3)
        Me.TXTCODIGOEXAMEN1.Name = "TXTCODIGOEXAMEN1"
        Me.TXTCODIGOEXAMEN1.Size = New System.Drawing.Size(39, 13)
        Me.TXTCODIGOEXAMEN1.TabIndex = 51
        Me.TXTCODIGOEXAMEN1.Text = "Label2"
        Me.TXTCODIGOEXAMEN1.Visible = False
        '
        'HOLA
        '
        Me.HOLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HOLA.Location = New System.Drawing.Point(250, 273)
        Me.HOLA.Name = "HOLA"
        Me.HOLA.Size = New System.Drawing.Size(46, 43)
        Me.HOLA.TabIndex = 52
        Me.HOLA.Visible = False
        '
        'TXTCODIGOEXAMEN
        '
        Me.TXTCODIGOEXAMEN.AutoSize = True
        Me.TXTCODIGOEXAMEN.Location = New System.Drawing.Point(263, 3)
        Me.TXTCODIGOEXAMEN.Name = "TXTCODIGOEXAMEN"
        Me.TXTCODIGOEXAMEN.Size = New System.Drawing.Size(39, 13)
        Me.TXTCODIGOEXAMEN.TabIndex = 53
        Me.TXTCODIGOEXAMEN.Text = "Label2"
        Me.TXTCODIGOEXAMEN.Visible = False
        '
        'CBOCODIGOPRUEBA
        '
        Me.CBOCODIGOPRUEBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOPRUEBA.Enabled = False
        Me.CBOCODIGOPRUEBA.FormattingEnabled = True
        Me.CBOCODIGOPRUEBA.Location = New System.Drawing.Point(395, 3)
        Me.CBOCODIGOPRUEBA.Name = "CBOCODIGOPRUEBA"
        Me.CBOCODIGOPRUEBA.Size = New System.Drawing.Size(62, 21)
        Me.CBOCODIGOPRUEBA.TabIndex = 54
        Me.CBOCODIGOPRUEBA.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 14)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Tipo Prueba:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 14)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Cantidad Examenes:"
        '
        'TXTNUMEROEXAMENES
        '
        Me.TXTNUMEROEXAMENES.AutoSize = True
        Me.TXTNUMEROEXAMENES.BackColor = System.Drawing.Color.White
        Me.TXTNUMEROEXAMENES.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNUMEROEXAMENES.Location = New System.Drawing.Point(281, 144)
        Me.TXTNUMEROEXAMENES.Name = "TXTNUMEROEXAMENES"
        Me.TXTNUMEROEXAMENES.Size = New System.Drawing.Size(0, 14)
        Me.TXTNUMEROEXAMENES.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(57, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "0 %"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(59, 332)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(242, 17)
        Me.ProgressBar1.TabIndex = 60
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(142, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 14)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Fecha Aplicación:"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(133, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 14)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Fecha Calificación:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(284, 79)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker1.TabIndex = 63
        Me.DateTimePicker1.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(284, 170)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker2.TabIndex = 64
        '
        'CBOTIPO
        '
        Me.CBOTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOTIPO.FormattingEnabled = True
        Me.CBOTIPO.Location = New System.Drawing.Point(284, 196)
        Me.CBOTIPO.Name = "CBOTIPO"
        Me.CBOTIPO.Size = New System.Drawing.Size(266, 21)
        Me.CBOTIPO.TabIndex = 65
        '
        'TXTTIPO
        '
        Me.TXTTIPO.AutoSize = True
        Me.TXTTIPO.Location = New System.Drawing.Point(12, 3)
        Me.TXTTIPO.Name = "TXTTIPO"
        Me.TXTTIPO.Size = New System.Drawing.Size(39, 13)
        Me.TXTTIPO.TabIndex = 66
        Me.TXTTIPO.Text = "Label2"
        Me.TXTTIPO.Visible = False
        '
        'CBOGRUPO
        '
        Me.CBOGRUPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOGRUPO.Enabled = False
        Me.CBOGRUPO.FormattingEnabled = True
        Me.CBOGRUPO.Location = New System.Drawing.Point(15, 361)
        Me.CBOGRUPO.MaxDropDownItems = 50
        Me.CBOGRUPO.Name = "CBOGRUPO"
        Me.CBOGRUPO.Size = New System.Drawing.Size(10, 21)
        Me.CBOGRUPO.TabIndex = 94
        '
        'CBOCODIGO
        '
        Me.CBOCODIGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGO.Enabled = False
        Me.CBOCODIGO.FormattingEnabled = True
        Me.CBOCODIGO.Location = New System.Drawing.Point(15, 334)
        Me.CBOCODIGO.MaxDropDownItems = 50
        Me.CBOCODIGO.Name = "CBOCODIGO"
        Me.CBOCODIGO.Size = New System.Drawing.Size(10, 21)
        Me.CBOCODIGO.TabIndex = 93
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(451, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 13)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Si se corrigieron algunos datos en la "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(451, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(201, 13)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "tabla auxliar por favor actualizalos con el "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(451, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 13)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "boton de abajo, de lo contrario no lo hagas"
        '
        'COPIAR_ENTABLA
        '
        Me.COPIAR_ENTABLA.BackgroundImage = CType(resources.GetObject("COPIAR_ENTABLA.BackgroundImage"), System.Drawing.Image)
        Me.COPIAR_ENTABLA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.COPIAR_ENTABLA.Location = New System.Drawing.Point(467, 336)
        Me.COPIAR_ENTABLA.Name = "COPIAR_ENTABLA"
        Me.COPIAR_ENTABLA.Size = New System.Drawing.Size(49, 46)
        Me.COPIAR_ENTABLA.TabIndex = 98
        Me.ToolTip1.SetToolTip(Me.COPIAR_ENTABLA, "Restaurar Datos ")
        Me.COPIAR_ENTABLA.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(607, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 46)
        Me.Button1.TabIndex = 106
        Me.ToolTip1.SetToolTip(Me.Button1, "Eliminar Datos de la Tabla Auxiliar")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'numero3
        '
        Me.numero3.AutoSize = True
        Me.numero3.BackColor = System.Drawing.Color.White
        Me.numero3.Location = New System.Drawing.Point(9, 204)
        Me.numero3.Name = "numero3"
        Me.numero3.Size = New System.Drawing.Size(87, 13)
        Me.numero3.TabIndex = 99
        Me.numero3.Text = "numero_registros"
        Me.numero3.Visible = False
        '
        'TXTDATOAUX
        '
        Me.TXTDATOAUX.AutoSize = True
        Me.TXTDATOAUX.Location = New System.Drawing.Point(9, 31)
        Me.TXTDATOAUX.Name = "TXTDATOAUX"
        Me.TXTDATOAUX.Size = New System.Drawing.Size(51, 13)
        Me.TXTDATOAUX.TabIndex = 100
        Me.TXTDATOAUX.Text = "numero 2"
        Me.TXTDATOAUX.Visible = False
        '
        'CBOAUX
        '
        Me.CBOAUX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOAUX.Enabled = False
        Me.CBOAUX.FormattingEnabled = True
        Me.CBOAUX.Location = New System.Drawing.Point(15, 270)
        Me.CBOAUX.MaxDropDownItems = 50
        Me.CBOAUX.Name = "CBOAUX"
        Me.CBOAUX.Size = New System.Drawing.Size(25, 21)
        Me.CBOAUX.TabIndex = 101
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(186, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 14)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Simulacro:"
        Me.Label10.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(517, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 25)
        Me.Panel1.TabIndex = 104
        Me.Panel1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(56, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(34, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Si"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(366, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 14)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Componente Flexible:"
        Me.Label11.Visible = False
        '
        'CBOSIMULACRO
        '
        Me.CBOSIMULACRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOSIMULACRO.FormattingEnabled = True
        Me.CBOSIMULACRO.Location = New System.Drawing.Point(284, 231)
        Me.CBOSIMULACRO.Name = "CBOSIMULACRO"
        Me.CBOSIMULACRO.Size = New System.Drawing.Size(57, 21)
        Me.CBOSIMULACRO.TabIndex = 107
        Me.CBOSIMULACRO.Visible = False
        '
        'Niveles_pensamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 394)
        Me.Controls.Add(Me.CBOSIMULACRO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CBOAUX)
        Me.Controls.Add(Me.TXTDATOAUX)
        Me.Controls.Add(Me.numero3)
        Me.Controls.Add(Me.COPIAR_ENTABLA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBOGRUPO)
        Me.Controls.Add(Me.CBOCODIGO)
        Me.Controls.Add(Me.TXTTIPO)
        Me.Controls.Add(Me.CBOTIPO)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTNUMEROEXAMENES)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBOCODIGOPRUEBA)
        Me.Controls.Add(Me.TXTCODIGOEXAMEN)
        Me.Controls.Add(Me.HOLA)
        Me.Controls.Add(Me.TXTCODIGOEXAMEN1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBNSIMULACRO)
        Me.Controls.Add(Me.NUMERO2)
        Me.Controls.Add(Me.NUMERO)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNCALIFICAR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Niveles_pensamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calificar Examenes"
        CType(Me.HOLA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNCALIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents NUMERO As System.Windows.Forms.Label
    Friend WithEvents NUMERO2 As System.Windows.Forms.Label
    Friend WithEvents CBNSIMULACRO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTCODIGOEXAMEN1 As System.Windows.Forms.Label
    Friend WithEvents HOLA As System.Windows.Forms.DataGridView
    Friend WithEvents TXTCODIGOEXAMEN As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOPRUEBA As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTNUMEROEXAMENES As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBOTIPO As System.Windows.Forms.ComboBox
    Friend WithEvents TXTTIPO As System.Windows.Forms.Label
    Friend WithEvents CBOGRUPO As System.Windows.Forms.ComboBox
    Friend WithEvents CBOCODIGO As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents COPIAR_ENTABLA As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents numero3 As System.Windows.Forms.Label
    Friend WithEvents TXTDATOAUX As System.Windows.Forms.Label
    Friend WithEvents CBOAUX As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CBOSIMULACRO As System.Windows.Forms.ComboBox
End Class
