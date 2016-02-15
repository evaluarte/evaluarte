<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Examenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_Examenes))
        Me.CBOCODIGOEXAMEN = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBOCODIGOPRUEBA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBOCODIGOGRUPO = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBOCODIGOSEDE = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBOCOLEGIO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.TXTCESTUDIANTE = New System.Windows.Forms.Label()
        Me.LABELCODIGO = New System.Windows.Forms.Label()
        Me.CBOCODIGOESTUDIANTE = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CBOCODIGOEXAMEN
        '
        Me.CBOCODIGOEXAMEN.AccessibleDescription = ""
        Me.CBOCODIGOEXAMEN.AccessibleName = ""
        Me.CBOCODIGOEXAMEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOEXAMEN.FormattingEnabled = True
        Me.CBOCODIGOEXAMEN.Items.AddRange(New Object() {"5", "5", "5", "5", "5"})
        Me.CBOCODIGOEXAMEN.Location = New System.Drawing.Point(396, 158)
        Me.CBOCODIGOEXAMEN.Name = "CBOCODIGOEXAMEN"
        Me.CBOCODIGOEXAMEN.Size = New System.Drawing.Size(252, 21)
        Me.CBOCODIGOEXAMEN.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Código Examen:"
        '
        'CBOCODIGOPRUEBA
        '
        Me.CBOCODIGOPRUEBA.AccessibleDescription = ""
        Me.CBOCODIGOPRUEBA.AccessibleName = ""
        Me.CBOCODIGOPRUEBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOPRUEBA.FormattingEnabled = True
        Me.CBOCODIGOPRUEBA.Location = New System.Drawing.Point(160, 156)
        Me.CBOCODIGOPRUEBA.Name = "CBOCODIGOPRUEBA"
        Me.CBOCODIGOPRUEBA.Size = New System.Drawing.Size(109, 21)
        Me.CBOCODIGOPRUEBA.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Código Prueba:"
        '
        'CBOCODIGOGRUPO
        '
        Me.CBOCODIGOGRUPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOGRUPO.FormattingEnabled = True
        Me.CBOCODIGOGRUPO.Location = New System.Drawing.Point(160, 193)
        Me.CBOCODIGOGRUPO.Name = "CBOCODIGOGRUPO"
        Me.CBOCODIGOGRUPO.Size = New System.Drawing.Size(109, 21)
        Me.CBOCODIGOGRUPO.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 14)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Código Grupo:"
        '
        'CBOCODIGOSEDE
        '
        Me.CBOCODIGOSEDE.FormattingEnabled = True
        Me.CBOCODIGOSEDE.Location = New System.Drawing.Point(438, 84)
        Me.CBOCODIGOSEDE.Name = "CBOCODIGOSEDE"
        Me.CBOCODIGOSEDE.Size = New System.Drawing.Size(210, 21)
        Me.CBOCODIGOSEDE.TabIndex = 45
        Me.CBOCODIGOSEDE.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(319, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 14)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Colegio:"
        Me.Label6.Visible = False
        '
        'CBOCOLEGIO
        '
        Me.CBOCOLEGIO.AccessibleDescription = ""
        Me.CBOCOLEGIO.AccessibleName = ""
        Me.CBOCOLEGIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCOLEGIO.FormattingEnabled = True
        Me.CBOCOLEGIO.Location = New System.Drawing.Point(349, 200)
        Me.CBOCOLEGIO.Name = "CBOCOLEGIO"
        Me.CBOCOLEGIO.Size = New System.Drawing.Size(299, 21)
        Me.CBOCOLEGIO.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 14)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Colegio:"
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.Location = New System.Drawing.Point(608, 244)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(40, 40)
        Me.BTNBUSCAR.TabIndex = 49
        Me.BTNBUSCAR.UseVisualStyleBackColor = True
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackgroundImage = CType(resources.GetObject("BTNGUARDAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNGUARDAR.Location = New System.Drawing.Point(536, 244)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(40, 40)
        Me.BTNGUARDAR.TabIndex = 48
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'TXTCESTUDIANTE
        '
        Me.TXTCESTUDIANTE.AutoSize = True
        Me.TXTCESTUDIANTE.Location = New System.Drawing.Point(435, 39)
        Me.TXTCESTUDIANTE.Name = "TXTCESTUDIANTE"
        Me.TXTCESTUDIANTE.Size = New System.Drawing.Size(99, 13)
        Me.TXTCESTUDIANTE.TabIndex = 56
        Me.TXTCESTUDIANTE.Text = "codigo_estudiantes"
        Me.TXTCESTUDIANTE.Visible = False
        '
        'LABELCODIGO
        '
        Me.LABELCODIGO.AutoSize = True
        Me.LABELCODIGO.Location = New System.Drawing.Point(368, 39)
        Me.LABELCODIGO.Name = "LABELCODIGO"
        Me.LABELCODIGO.Size = New System.Drawing.Size(39, 13)
        Me.LABELCODIGO.TabIndex = 55
        Me.LABELCODIGO.Text = "codigo"
        Me.LABELCODIGO.Visible = False
        '
        'CBOCODIGOESTUDIANTE
        '
        Me.CBOCODIGOESTUDIANTE.AccessibleDescription = ""
        Me.CBOCODIGOESTUDIANTE.AccessibleName = ""
        Me.CBOCODIGOESTUDIANTE.FormattingEnabled = True
        Me.CBOCODIGOESTUDIANTE.Location = New System.Drawing.Point(175, 244)
        Me.CBOCODIGOESTUDIANTE.Name = "CBOCODIGOESTUDIANTE"
        Me.CBOCODIGOESTUDIANTE.Size = New System.Drawing.Size(148, 21)
        Me.CBOCODIGOESTUDIANTE.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 14)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Codigo Estudiante:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 59
        '
        'Registrar_Examenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(659, 334)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CBOCODIGOESTUDIANTE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTCESTUDIANTE)
        Me.Controls.Add(Me.LABELCODIGO)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.CBOCOLEGIO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBOCODIGOSEDE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBOCODIGOGRUPO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBOCODIGOPRUEBA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CBOCODIGOEXAMEN)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registrar_Examenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar_Examenes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBOCODIGOEXAMEN As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOPRUEBA As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOGRUPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOSEDE As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBOCOLEGIO As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents TXTCESTUDIANTE As System.Windows.Forms.Label
    Friend WithEvents LABELCODIGO As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOESTUDIANTE As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
