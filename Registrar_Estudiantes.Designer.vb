<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Estudiantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_Estudiantes))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CBOCODIGOEXAMEN = New System.Windows.Forms.ComboBox()
        Me.CBOCODIGOSEDE = New System.Windows.Forms.ComboBox()
        Me.CBOCODIGOGRUPO = New System.Windows.Forms.ComboBox()
        Me.TXTNOMBRES = New System.Windows.Forms.TextBox()
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TXTIDENTIFICACION = New System.Windows.Forms.TextBox()
        Me.TXTDIRECCION = New System.Windows.Forms.TextBox()
        Me.TXTTELEFONO = New System.Windows.Forms.TextBox()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.CBOANO = New System.Windows.Forms.ComboBox()
        Me.TXTMATRICULADO = New System.Windows.Forms.TextBox()
        Me.TXTCODIGOESTUDIANTE = New System.Windows.Forms.TextBox()
        Me.BTNMATRICULAROTRO = New System.Windows.Forms.Button()
        Me.CBOGRADO = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBOCOLEGIOS = New System.Windows.Forms.ComboBox()
        Me.CBOASOCIADO = New System.Windows.Forms.ComboBox()
        Me.LABELCODIGO = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTCESTUDIANTE = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LABELNOM = New System.Windows.Forms.Label()
        Me.LABELCANTIDAD = New System.Windows.Forms.Label()
        Me.CBOTIPOPRUEBA = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXTRESTANTES = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CBOCIUDADES = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(451, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(544, 347)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(287, 20)
        Me.DateTimePicker1.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.DateTimePicker1, "Fecha Ingreso")
        '
        'CBOCODIGOEXAMEN
        '
        Me.CBOCODIGOEXAMEN.AccessibleDescription = ""
        Me.CBOCODIGOEXAMEN.AccessibleName = ""
        Me.CBOCODIGOEXAMEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOEXAMEN.FormattingEnabled = True
        Me.CBOCODIGOEXAMEN.Items.AddRange(New Object() {"5", "5", "5", "5", "5"})
        Me.CBOCODIGOEXAMEN.Location = New System.Drawing.Point(411, 11)
        Me.CBOCODIGOEXAMEN.Name = "CBOCODIGOEXAMEN"
        Me.CBOCODIGOEXAMEN.Size = New System.Drawing.Size(119, 21)
        Me.CBOCODIGOEXAMEN.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.CBOCODIGOEXAMEN, "Código Examen")
        Me.CBOCODIGOEXAMEN.Visible = False
        '
        'CBOCODIGOSEDE
        '
        Me.CBOCODIGOSEDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOSEDE.FormattingEnabled = True
        Me.CBOCODIGOSEDE.Location = New System.Drawing.Point(136, 249)
        Me.CBOCODIGOSEDE.MaxDropDownItems = 50
        Me.CBOCODIGOSEDE.Name = "CBOCODIGOSEDE"
        Me.CBOCODIGOSEDE.Size = New System.Drawing.Size(66, 21)
        Me.CBOCODIGOSEDE.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.CBOCODIGOSEDE, "Código Colegio")
        '
        'CBOCODIGOGRUPO
        '
        Me.CBOCODIGOGRUPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOGRUPO.FormattingEnabled = True
        Me.CBOCODIGOGRUPO.Location = New System.Drawing.Point(384, 249)
        Me.CBOCODIGOGRUPO.MaxDropDownItems = 50
        Me.CBOCODIGOGRUPO.Name = "CBOCODIGOGRUPO"
        Me.CBOCODIGOGRUPO.Size = New System.Drawing.Size(50, 21)
        Me.CBOCODIGOGRUPO.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CBOCODIGOGRUPO, "Código Grupo")
        '
        'TXTNOMBRES
        '
        Me.TXTNOMBRES.Location = New System.Drawing.Point(136, 313)
        Me.TXTNOMBRES.Name = "TXTNOMBRES"
        Me.TXTNOMBRES.Size = New System.Drawing.Size(269, 20)
        Me.TXTNOMBRES.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.TXTNOMBRES, "Nombres")
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(542, 317)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(289, 20)
        Me.TXTAPELLIDOS.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.TXTAPELLIDOS, "Apellidos")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 14)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Código Colegio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 14)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Código Grupo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(451, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Apellidos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombres:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Código Examen:"
        Me.Label1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(642, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Código Estudiante:"
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.Location = New System.Drawing.Point(848, 461)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(40, 40)
        Me.BTNBUSCAR.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.BTNBUSCAR, "Salir")
        Me.BTNBUSCAR.UseVisualStyleBackColor = True
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackgroundImage = CType(resources.GetObject("BTNGUARDAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNGUARDAR.Location = New System.Drawing.Point(765, 461)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(40, 40)
        Me.BTNGUARDAR.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BTNGUARDAR, "GUARDAR")
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        Me.BTNGUARDAR.Visible = False
        '
        'TXTIDENTIFICACION
        '
        Me.TXTIDENTIFICACION.Location = New System.Drawing.Point(136, 377)
        Me.TXTIDENTIFICACION.Name = "TXTIDENTIFICACION"
        Me.TXTIDENTIFICACION.Size = New System.Drawing.Size(269, 20)
        Me.TXTIDENTIFICACION.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.TXTIDENTIFICACION, "Nombres")
        '
        'TXTDIRECCION
        '
        Me.TXTDIRECCION.Location = New System.Drawing.Point(544, 383)
        Me.TXTDIRECCION.Name = "TXTDIRECCION"
        Me.TXTDIRECCION.Size = New System.Drawing.Size(287, 20)
        Me.TXTDIRECCION.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.TXTDIRECCION, "Apellidos")
        '
        'TXTTELEFONO
        '
        Me.TXTTELEFONO.Location = New System.Drawing.Point(136, 413)
        Me.TXTTELEFONO.Name = "TXTTELEFONO"
        Me.TXTTELEFONO.Size = New System.Drawing.Size(269, 20)
        Me.TXTTELEFONO.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.TXTTELEFONO, "Nombres")
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Location = New System.Drawing.Point(544, 413)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(287, 20)
        Me.TXTEMAIL.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.TXTEMAIL, "Apellidos")
        '
        'CBOANO
        '
        Me.CBOANO.AccessibleDescription = ""
        Me.CBOANO.DisplayMember = "2012"
        Me.CBOANO.FormattingEnabled = True
        Me.CBOANO.Location = New System.Drawing.Point(512, 251)
        Me.CBOANO.Name = "CBOANO"
        Me.CBOANO.Size = New System.Drawing.Size(56, 21)
        Me.CBOANO.TabIndex = 4
        Me.CBOANO.Tag = ""
        Me.CBOANO.Text = "2012"
        Me.ToolTip1.SetToolTip(Me.CBOANO, "AÑO")
        '
        'TXTMATRICULADO
        '
        Me.TXTMATRICULADO.Enabled = False
        Me.TXTMATRICULADO.Location = New System.Drawing.Point(706, 250)
        Me.TXTMATRICULADO.Name = "TXTMATRICULADO"
        Me.TXTMATRICULADO.Size = New System.Drawing.Size(222, 20)
        Me.TXTMATRICULADO.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TXTMATRICULADO, "Nombres")
        '
        'TXTCODIGOESTUDIANTE
        '
        Me.TXTCODIGOESTUDIANTE.Enabled = False
        Me.TXTCODIGOESTUDIANTE.Location = New System.Drawing.Point(793, 50)
        Me.TXTCODIGOESTUDIANTE.Name = "TXTCODIGOESTUDIANTE"
        Me.TXTCODIGOESTUDIANTE.Size = New System.Drawing.Size(144, 20)
        Me.TXTCODIGOESTUDIANTE.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.TXTCODIGOESTUDIANTE, "Apellidos")
        '
        'BTNMATRICULAROTRO
        '
        Me.BTNMATRICULAROTRO.BackgroundImage = CType(resources.GetObject("BTNMATRICULAROTRO.BackgroundImage"), System.Drawing.Image)
        Me.BTNMATRICULAROTRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNMATRICULAROTRO.Location = New System.Drawing.Point(777, 461)
        Me.BTNMATRICULAROTRO.Name = "BTNMATRICULAROTRO"
        Me.BTNMATRICULAROTRO.Size = New System.Drawing.Size(40, 40)
        Me.BTNMATRICULAROTRO.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.BTNMATRICULAROTRO, "ACTIVAR NUEVO GRUPO")
        Me.BTNMATRICULAROTRO.UseVisualStyleBackColor = True
        Me.BTNMATRICULAROTRO.Visible = False
        '
        'CBOGRADO
        '
        Me.CBOGRADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOGRADO.FormattingEnabled = True
        Me.CBOGRADO.Location = New System.Drawing.Point(136, 443)
        Me.CBOGRADO.MaxDropDownItems = 50
        Me.CBOGRADO.Name = "CBOGRADO"
        Me.CBOGRADO.Size = New System.Drawing.Size(83, 21)
        Me.CBOGRADO.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.CBOGRADO, "Código Colegio")
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(895, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button1, "ACTIVAR CODIGO")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CBOCOLEGIOS
        '
        Me.CBOCOLEGIOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCOLEGIOS.FormattingEnabled = True
        Me.CBOCOLEGIOS.Location = New System.Drawing.Point(136, 202)
        Me.CBOCOLEGIOS.MaxDropDownItems = 50
        Me.CBOCOLEGIOS.Name = "CBOCOLEGIOS"
        Me.CBOCOLEGIOS.Size = New System.Drawing.Size(269, 21)
        Me.CBOCOLEGIOS.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.CBOCOLEGIOS, "Código Colegio")
        '
        'CBOASOCIADO
        '
        Me.CBOASOCIADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOASOCIADO.FormattingEnabled = True
        Me.CBOASOCIADO.Location = New System.Drawing.Point(136, 346)
        Me.CBOASOCIADO.MaxDropDownItems = 50
        Me.CBOASOCIADO.Name = "CBOASOCIADO"
        Me.CBOASOCIADO.Size = New System.Drawing.Size(269, 21)
        Me.CBOASOCIADO.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.CBOASOCIADO, "Código Colegio")
        '
        'LABELCODIGO
        '
        Me.LABELCODIGO.AutoSize = True
        Me.LABELCODIGO.Location = New System.Drawing.Point(867, 288)
        Me.LABELCODIGO.Name = "LABELCODIGO"
        Me.LABELCODIGO.Size = New System.Drawing.Size(39, 13)
        Me.LABELCODIGO.TabIndex = 45
        Me.LABELCODIGO.Text = "codigo"
        Me.LABELCODIGO.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(451, 383)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 14)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Dirección:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 14)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Identificación:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(451, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 14)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Email:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 414)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 14)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Teléfono:"
        '
        'TXTCESTUDIANTE
        '
        Me.TXTCESTUDIANTE.AutoSize = True
        Me.TXTCESTUDIANTE.Location = New System.Drawing.Point(845, 271)
        Me.TXTCESTUDIANTE.Name = "TXTCESTUDIANTE"
        Me.TXTCESTUDIANTE.Size = New System.Drawing.Size(99, 13)
        Me.TXTCESTUDIANTE.TabIndex = 54
        Me.TXTCESTUDIANTE.Text = "codigo_estudiantes"
        Me.TXTCESTUDIANTE.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(470, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 14)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Año:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(591, 251)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 14)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Matriculado por:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label15.Location = New System.Drawing.Point(12, 277)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(253, 25)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "DATOS PERSONALES"
        '
        'LABELNOM
        '
        Me.LABELNOM.AutoSize = True
        Me.LABELNOM.Location = New System.Drawing.Point(883, 311)
        Me.LABELNOM.Name = "LABELNOM"
        Me.LABELNOM.Size = New System.Drawing.Size(45, 13)
        Me.LABELNOM.TabIndex = 63
        Me.LABELNOM.Text = "Label16"
        Me.LABELNOM.Visible = False
        '
        'LABELCANTIDAD
        '
        Me.LABELCANTIDAD.AutoSize = True
        Me.LABELCANTIDAD.BackColor = System.Drawing.Color.White
        Me.LABELCANTIDAD.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABELCANTIDAD.Location = New System.Drawing.Point(867, 356)
        Me.LABELCANTIDAD.Name = "LABELCANTIDAD"
        Me.LABELCANTIDAD.Size = New System.Drawing.Size(61, 14)
        Me.LABELCANTIDAD.TabIndex = 65
        Me.LABELCANTIDAD.Text = "cantidad"
        Me.LABELCANTIDAD.Visible = False
        '
        'CBOTIPOPRUEBA
        '
        Me.CBOTIPOPRUEBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOTIPOPRUEBA.FormattingEnabled = True
        Me.CBOTIPOPRUEBA.Location = New System.Drawing.Point(544, 448)
        Me.CBOTIPOPRUEBA.Name = "CBOTIPOPRUEBA"
        Me.CBOTIPOPRUEBA.Size = New System.Drawing.Size(40, 21)
        Me.CBOTIPOPRUEBA.TabIndex = 16
        Me.CBOTIPOPRUEBA.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(451, 455)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 14)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "Tipo Prueba:"
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 450)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 14)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "Grado:"
        '
        'TXTRESTANTES
        '
        Me.TXTRESTANTES.AutoSize = True
        Me.TXTRESTANTES.BackColor = System.Drawing.Color.White
        Me.TXTRESTANTES.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRESTANTES.Location = New System.Drawing.Point(860, 396)
        Me.TXTRESTANTES.Name = "TXTRESTANTES"
        Me.TXTRESTANTES.Size = New System.Drawing.Size(68, 14)
        Me.TXTRESTANTES.TabIndex = 70
        Me.TXTRESTANTES.Text = "restantes"
        Me.TXTRESTANTES.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 204)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 14)
        Me.Label18.TabIndex = 71
        Me.Label18.Text = "Nombre Colegio:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 347)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 14)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Colegio Asociado:"
        '
        'CBOCIUDADES
        '
        Me.CBOCIUDADES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCIUDADES.FormattingEnabled = True
        Me.CBOCIUDADES.Location = New System.Drawing.Point(136, 175)
        Me.CBOCIUDADES.MaxDropDownItems = 50
        Me.CBOCIUDADES.Name = "CBOCIUDADES"
        Me.CBOCIUDADES.Size = New System.Drawing.Size(269, 21)
        Me.CBOCIUDADES.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Ciudad:"
        '
        'Registrar_Estudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(972, 515)
        Me.Controls.Add(Me.CBOCIUDADES)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBOASOCIADO)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.CBOCOLEGIOS)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TXTRESTANTES)
        Me.Controls.Add(Me.CBOGRADO)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CBOTIPOPRUEBA)
        Me.Controls.Add(Me.LABELCANTIDAD)
        Me.Controls.Add(Me.LABELNOM)
        Me.Controls.Add(Me.BTNMATRICULAROTRO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXTCODIGOESTUDIANTE)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TXTMATRICULADO)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CBOANO)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TXTCESTUDIANTE)
        Me.Controls.Add(Me.TXTTELEFONO)
        Me.Controls.Add(Me.TXTEMAIL)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TXTIDENTIFICACION)
        Me.Controls.Add(Me.TXTDIRECCION)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LABELCODIGO)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CBOCODIGOEXAMEN)
        Me.Controls.Add(Me.CBOCODIGOSEDE)
        Me.Controls.Add(Me.CBOCODIGOGRUPO)
        Me.Controls.Add(Me.TXTNOMBRES)
        Me.Controls.Add(Me.TXTAPELLIDOS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registrar_Estudiantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Registrar_Estudiantes"
        Me.ToolTip1.SetToolTip(Me, "ACTIVAR")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBOCODIGOEXAMEN As System.Windows.Forms.ComboBox
    Friend WithEvents CBOCODIGOSEDE As System.Windows.Forms.ComboBox
    Friend WithEvents CBOCODIGOGRUPO As System.Windows.Forms.ComboBox
    Friend WithEvents TXTNOMBRES As System.Windows.Forms.TextBox
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LABELCODIGO As System.Windows.Forms.Label
    Friend WithEvents TXTIDENTIFICACION As System.Windows.Forms.TextBox
    Friend WithEvents TXTDIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTTELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents TXTEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTCESTUDIANTE As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CBOANO As System.Windows.Forms.ComboBox
    Friend WithEvents TXTMATRICULADO As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXTCODIGOESTUDIANTE As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNMATRICULAROTRO As System.Windows.Forms.Button
    Friend WithEvents LABELNOM As System.Windows.Forms.Label
    Friend WithEvents LABELCANTIDAD As System.Windows.Forms.Label
    Friend WithEvents CBOTIPOPRUEBA As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CBOGRADO As System.Windows.Forms.ComboBox
    Friend WithEvents TXTRESTANTES As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CBOCOLEGIOS As System.Windows.Forms.ComboBox
    Friend WithEvents CBOASOCIADO As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CBOCIUDADES As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
