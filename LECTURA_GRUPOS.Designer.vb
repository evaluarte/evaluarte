﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LECTURA_GRUPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LECTURA_GRUPOS))
        Me.CBOSIMULACRO = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBOTIPO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNCALIFICAR = New System.Windows.Forms.Button()
        Me.CBOCIUDADES = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBOCODIGOGRUPO = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBOCODIGOSEDE = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBOCOLEGIOS = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FECHA = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DBA1 = New System.Windows.Forms.RadioButton()
        Me.DBA = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'CBOSIMULACRO
        '
        Me.CBOSIMULACRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOSIMULACRO.FormattingEnabled = True
        Me.CBOSIMULACRO.Location = New System.Drawing.Point(169, 208)
        Me.CBOSIMULACRO.Name = "CBOSIMULACRO"
        Me.CBOSIMULACRO.Size = New System.Drawing.Size(57, 21)
        Me.CBOSIMULACRO.TabIndex = 143
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(82, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "Simulacro:"
        '
        'CBOTIPO
        '
        Me.CBOTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOTIPO.FormattingEnabled = True
        Me.CBOTIPO.Location = New System.Drawing.Point(169, 177)
        Me.CBOTIPO.Name = "CBOTIPO"
        Me.CBOTIPO.Size = New System.Drawing.Size(269, 21)
        Me.CBOTIPO.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(73, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 14)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Tipo Prueba:"
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.Location = New System.Drawing.Point(269, 291)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(44, 43)
        Me.BTNSALIR.TabIndex = 139
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'BTNCALIFICAR
        '
        Me.BTNCALIFICAR.BackgroundImage = CType(resources.GetObject("BTNCALIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNCALIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCALIFICAR.Location = New System.Drawing.Point(170, 291)
        Me.BTNCALIFICAR.Name = "BTNCALIFICAR"
        Me.BTNCALIFICAR.Size = New System.Drawing.Size(44, 43)
        Me.BTNCALIFICAR.TabIndex = 138
        Me.BTNCALIFICAR.UseVisualStyleBackColor = True
        '
        'CBOCIUDADES
        '
        Me.CBOCIUDADES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCIUDADES.FormattingEnabled = True
        Me.CBOCIUDADES.Location = New System.Drawing.Point(169, 69)
        Me.CBOCIUDADES.MaxDropDownItems = 50
        Me.CBOCIUDADES.Name = "CBOCIUDADES"
        Me.CBOCIUDADES.Size = New System.Drawing.Size(269, 21)
        Me.CBOCIUDADES.TabIndex = 136
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Ciudad:"
        '
        'CBOCODIGOGRUPO
        '
        Me.CBOCODIGOGRUPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOGRUPO.FormattingEnabled = True
        Me.CBOCODIGOGRUPO.Location = New System.Drawing.Point(169, 150)
        Me.CBOCODIGOGRUPO.MaxDropDownItems = 50
        Me.CBOCODIGOGRUPO.Name = "CBOCODIGOGRUPO"
        Me.CBOCODIGOGRUPO.Size = New System.Drawing.Size(42, 21)
        Me.CBOCODIGOGRUPO.TabIndex = 132
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 14)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Código Grupo:"
        '
        'CBOCODIGOSEDE
        '
        Me.CBOCODIGOSEDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOSEDE.Enabled = False
        Me.CBOCODIGOSEDE.FormattingEnabled = True
        Me.CBOCODIGOSEDE.Location = New System.Drawing.Point(169, 123)
        Me.CBOCODIGOSEDE.MaxDropDownItems = 50
        Me.CBOCODIGOSEDE.Name = "CBOCODIGOSEDE"
        Me.CBOCODIGOSEDE.Size = New System.Drawing.Size(66, 21)
        Me.CBOCODIGOSEDE.TabIndex = 131
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 14)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "Código Colegio:"
        '
        'CBOCOLEGIOS
        '
        Me.CBOCOLEGIOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCOLEGIOS.FormattingEnabled = True
        Me.CBOCOLEGIOS.Location = New System.Drawing.Point(169, 96)
        Me.CBOCOLEGIOS.MaxDropDownItems = 50
        Me.CBOCOLEGIOS.Name = "CBOCOLEGIOS"
        Me.CBOCOLEGIOS.Size = New System.Drawing.Size(269, 21)
        Me.CBOCOLEGIOS.TabIndex = 130
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(48, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 14)
        Me.Label18.TabIndex = 133
        Me.Label18.Text = "Nombre Colegio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 14)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Fecha Calificación:"
        '
        'FECHA
        '
        Me.FECHA.Location = New System.Drawing.Point(169, 239)
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Size = New System.Drawing.Size(200, 20)
        Me.FECHA.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 14)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "DBA:"
        '
        'DBA1
        '
        Me.DBA1.AutoSize = True
        Me.DBA1.Location = New System.Drawing.Point(211, 46)
        Me.DBA1.Name = "DBA1"
        Me.DBA1.Size = New System.Drawing.Size(41, 17)
        Me.DBA1.TabIndex = 183
        Me.DBA1.TabStop = True
        Me.DBA1.Text = "NO"
        Me.DBA1.UseVisualStyleBackColor = False
        '
        'DBA
        '
        Me.DBA.AutoSize = True
        Me.DBA.Location = New System.Drawing.Point(170, 46)
        Me.DBA.Name = "DBA"
        Me.DBA.Size = New System.Drawing.Size(35, 17)
        Me.DBA.TabIndex = 182
        Me.DBA.TabStop = True
        Me.DBA.Text = "SI"
        Me.DBA.UseVisualStyleBackColor = False
        '
        'LECTURA_GRUPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(489, 369)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DBA1)
        Me.Controls.Add(Me.DBA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FECHA)
        Me.Controls.Add(Me.CBOSIMULACRO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CBOTIPO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNCALIFICAR)
        Me.Controls.Add(Me.CBOCIUDADES)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBOCODIGOGRUPO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBOCODIGOSEDE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBOCOLEGIOS)
        Me.Controls.Add(Me.Label18)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LECTURA_GRUPOS"
        Me.Text = "LECTURA_GRUPOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBOSIMULACRO As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CBOTIPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents BTNCALIFICAR As System.Windows.Forms.Button
    Friend WithEvents CBOCIUDADES As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOGRUPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOSEDE As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBOCOLEGIOS As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DBA1 As System.Windows.Forms.RadioButton
    Friend WithEvents DBA As System.Windows.Forms.RadioButton
End Class
