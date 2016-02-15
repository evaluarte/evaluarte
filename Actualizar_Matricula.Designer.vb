<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar_Matricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualizar_Matricula))
        Me.SistemaevaluarteDataSet = New evaluarte.sistemaevaluarteDataSet()
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudiantesTableAdapter = New evaluarte.sistemaevaluarteDataSetTableAdapters.estudiantesTableAdapter()
        Me.TableAdapterManager = New evaluarte.sistemaevaluarteDataSetTableAdapters.TableAdapterManager()
        Me.CBOCODIGOEXAMEN = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTNOMBRES = New System.Windows.Forms.TextBox()
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TXTIDENTIFICACION = New System.Windows.Forms.TextBox()
        Me.TXTUSUARIO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTTELEFONO = New System.Windows.Forms.TextBox()
        Me.TXTDIRECCION = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNCALIFICAR = New System.Windows.Forms.Button()
        Me.TXTCODIGOCOLEGIO = New System.Windows.Forms.TextBox()
        Me.TXTCODIGOGRUPO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTASOCIADO = New System.Windows.Forms.ComboBox()
        Me.CARGAR_COLEGIOS = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CBOCIUDADES = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBOCOLEGIOS = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.SistemaevaluarteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SistemaevaluarteDataSet
        '
        Me.SistemaevaluarteDataSet.DataSetName = "sistemaevaluarteDataSet"
        Me.SistemaevaluarteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "estudiantes"
        Me.EstudiantesBindingSource.DataSource = Me.SistemaevaluarteDataSet
        '
        'EstudiantesTableAdapter
        '
        Me.EstudiantesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.colegiosTableAdapter = Nothing
        Me.TableAdapterManager.estudiantesTableAdapter = Me.EstudiantesTableAdapter
        Me.TableAdapterManager.gruposTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = evaluarte.sistemaevaluarteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CBOCODIGOEXAMEN
        '
        Me.CBOCODIGOEXAMEN.AccessibleDescription = ""
        Me.CBOCODIGOEXAMEN.AccessibleName = ""
        Me.CBOCODIGOEXAMEN.FormattingEnabled = True
        Me.CBOCODIGOEXAMEN.Location = New System.Drawing.Point(168, 195)
        Me.CBOCODIGOEXAMEN.Name = "CBOCODIGOEXAMEN"
        Me.CBOCODIGOEXAMEN.Size = New System.Drawing.Size(119, 21)
        Me.CBOCODIGOEXAMEN.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Código Estudiante:"
        '
        'TXTNOMBRES
        '
        Me.TXTNOMBRES.Location = New System.Drawing.Point(102, 237)
        Me.TXTNOMBRES.Name = "TXTNOMBRES"
        Me.TXTNOMBRES.Size = New System.Drawing.Size(250, 20)
        Me.TXTNOMBRES.TabIndex = 29
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(458, 237)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(253, 20)
        Me.TXTAPELLIDOS.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(333, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 14)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Código Colegio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(380, 243)
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
        Me.Label2.Location = New System.Drawing.Point(34, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombres:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(135, 276)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 20)
        Me.DateTimePicker1.TabIndex = 31
        '
        'TXTIDENTIFICACION
        '
        Me.TXTIDENTIFICACION.Location = New System.Drawing.Point(135, 318)
        Me.TXTIDENTIFICACION.Name = "TXTIDENTIFICACION"
        Me.TXTIDENTIFICACION.Size = New System.Drawing.Size(217, 20)
        Me.TXTIDENTIFICACION.TabIndex = 36
        '
        'TXTUSUARIO
        '
        Me.TXTUSUARIO.Location = New System.Drawing.Point(523, 276)
        Me.TXTUSUARIO.Name = "TXTUSUARIO"
        Me.TXTUSUARIO.Size = New System.Drawing.Size(188, 20)
        Me.TXTUSUARIO.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(380, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 14)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Usuario Registro:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 14)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Identificacion:"
        '
        'TXTTELEFONO
        '
        Me.TXTTELEFONO.Location = New System.Drawing.Point(135, 363)
        Me.TXTTELEFONO.Name = "TXTTELEFONO"
        Me.TXTTELEFONO.Size = New System.Drawing.Size(217, 20)
        Me.TXTTELEFONO.TabIndex = 40
        '
        'TXTDIRECCION
        '
        Me.TXTDIRECCION.Location = New System.Drawing.Point(458, 320)
        Me.TXTDIRECCION.Name = "TXTDIRECCION"
        Me.TXTDIRECCION.Size = New System.Drawing.Size(253, 20)
        Me.TXTDIRECCION.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(380, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 14)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Dirección:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 365)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 14)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Teléfono:"
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Location = New System.Drawing.Point(461, 365)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(250, 20)
        Me.TXTEMAIL.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(380, 363)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 14)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(543, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 14)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Código Grupo:"
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.Location = New System.Drawing.Point(417, 403)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(44, 43)
        Me.BTNSALIR.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.BTNSALIR, "CERRAR")
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'BTNCALIFICAR
        '
        Me.BTNCALIFICAR.BackgroundImage = CType(resources.GetObject("BTNCALIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNCALIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCALIFICAR.Location = New System.Drawing.Point(318, 403)
        Me.BTNCALIFICAR.Name = "BTNCALIFICAR"
        Me.BTNCALIFICAR.Size = New System.Drawing.Size(44, 43)
        Me.BTNCALIFICAR.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.BTNCALIFICAR, "ACTUALIZAR")
        Me.BTNCALIFICAR.UseVisualStyleBackColor = True
        '
        'TXTCODIGOCOLEGIO
        '
        Me.TXTCODIGOCOLEGIO.Location = New System.Drawing.Point(446, 197)
        Me.TXTCODIGOCOLEGIO.Name = "TXTCODIGOCOLEGIO"
        Me.TXTCODIGOCOLEGIO.Size = New System.Drawing.Size(59, 20)
        Me.TXTCODIGOCOLEGIO.TabIndex = 55
        '
        'TXTCODIGOGRUPO
        '
        Me.TXTCODIGOGRUPO.Location = New System.Drawing.Point(656, 198)
        Me.TXTCODIGOGRUPO.Name = "TXTCODIGOGRUPO"
        Me.TXTCODIGOGRUPO.Size = New System.Drawing.Size(55, 20)
        Me.TXTCODIGOGRUPO.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(417, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 14)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Colegio Asociado:"
        '
        'TXTASOCIADO
        '
        Me.TXTASOCIADO.FormattingEnabled = True
        Me.TXTASOCIADO.Location = New System.Drawing.Point(542, 54)
        Me.TXTASOCIADO.Name = "TXTASOCIADO"
        Me.TXTASOCIADO.Size = New System.Drawing.Size(172, 21)
        Me.TXTASOCIADO.TabIndex = 59
        '
        'CARGAR_COLEGIOS
        '
        Me.CARGAR_COLEGIOS.BackgroundImage = CType(resources.GetObject("CARGAR_COLEGIOS.BackgroundImage"), System.Drawing.Image)
        Me.CARGAR_COLEGIOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CARGAR_COLEGIOS.Location = New System.Drawing.Point(670, 5)
        Me.CARGAR_COLEGIOS.Name = "CARGAR_COLEGIOS"
        Me.CARGAR_COLEGIOS.Size = New System.Drawing.Size(44, 43)
        Me.CARGAR_COLEGIOS.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.CARGAR_COLEGIOS, "CARGAR COLEGIOS")
        Me.CARGAR_COLEGIOS.UseVisualStyleBackColor = True
        '
        'CBOCIUDADES
        '
        Me.CBOCIUDADES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCIUDADES.FormattingEnabled = True
        Me.CBOCIUDADES.Location = New System.Drawing.Point(156, 141)
        Me.CBOCIUDADES.MaxDropDownItems = 50
        Me.CBOCIUDADES.Name = "CBOCIUDADES"
        Me.CBOCIUDADES.Size = New System.Drawing.Size(269, 21)
        Me.CBOCIUDADES.TabIndex = 96
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(35, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 14)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Ciudad:"
        '
        'CBOCOLEGIOS
        '
        Me.CBOCOLEGIOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCOLEGIOS.FormattingEnabled = True
        Me.CBOCOLEGIOS.Location = New System.Drawing.Point(156, 168)
        Me.CBOCOLEGIOS.MaxDropDownItems = 50
        Me.CBOCOLEGIOS.Name = "CBOCOLEGIOS"
        Me.CBOCOLEGIOS.Size = New System.Drawing.Size(269, 21)
        Me.CBOCOLEGIOS.TabIndex = 98
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(35, 170)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 14)
        Me.Label18.TabIndex = 99
        Me.Label18.Text = "Nombre Colegio:"
        '
        'Actualizar_Matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(772, 471)
        Me.Controls.Add(Me.CBOCOLEGIOS)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.CBOCIUDADES)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CARGAR_COLEGIOS)
        Me.Controls.Add(Me.TXTASOCIADO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXTCODIGOGRUPO)
        Me.Controls.Add(Me.TXTCODIGOCOLEGIO)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNCALIFICAR)
        Me.Controls.Add(Me.TXTEMAIL)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TXTTELEFONO)
        Me.Controls.Add(Me.TXTDIRECCION)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXTIDENTIFICACION)
        Me.Controls.Add(Me.TXTUSUARIO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TXTNOMBRES)
        Me.Controls.Add(Me.TXTAPELLIDOS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBOCODIGOEXAMEN)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Actualizar_Matricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar_Matricula"
        CType(Me.SistemaevaluarteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SistemaevaluarteDataSet As evaluarte.sistemaevaluarteDataSet
    Friend WithEvents EstudiantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstudiantesTableAdapter As evaluarte.sistemaevaluarteDataSetTableAdapters.estudiantesTableAdapter
    Friend WithEvents TableAdapterManager As evaluarte.sistemaevaluarteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CBOCODIGOEXAMEN As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTNOMBRES As System.Windows.Forms.TextBox
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTIDENTIFICACION As System.Windows.Forms.TextBox
    Friend WithEvents TXTUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTTELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents TXTDIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents BTNCALIFICAR As System.Windows.Forms.Button
    Friend WithEvents TXTCODIGOCOLEGIO As System.Windows.Forms.TextBox
    Friend WithEvents TXTCODIGOGRUPO As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTASOCIADO As System.Windows.Forms.ComboBox
    Friend WithEvents CARGAR_COLEGIOS As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CBOCIUDADES As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CBOCOLEGIOS As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
