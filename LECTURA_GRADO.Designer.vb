﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LECTURA_GRADO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LECTURA_GRADO))
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
        Me.SuspendLayout()
        '
        'CBOSIMULACRO
        '
        Me.CBOSIMULACRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOSIMULACRO.FormattingEnabled = True
        Me.CBOSIMULACRO.Location = New System.Drawing.Point(169, 249)
        Me.CBOSIMULACRO.Name = "CBOSIMULACRO"
        Me.CBOSIMULACRO.Size = New System.Drawing.Size(57, 21)
        Me.CBOSIMULACRO.TabIndex = 157
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(82, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 156
        Me.Label10.Text = "Simulacro:"
        '
        'CBOTIPO
        '
        Me.CBOTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOTIPO.FormattingEnabled = True
        Me.CBOTIPO.Location = New System.Drawing.Point(169, 218)
        Me.CBOTIPO.Name = "CBOTIPO"
        Me.CBOTIPO.Size = New System.Drawing.Size(269, 21)
        Me.CBOTIPO.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(73, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 14)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Tipo Prueba:"
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.Location = New System.Drawing.Point(269, 291)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(44, 43)
        Me.BTNSALIR.TabIndex = 153
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'BTNCALIFICAR
        '
        Me.BTNCALIFICAR.BackgroundImage = CType(resources.GetObject("BTNCALIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNCALIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCALIFICAR.Location = New System.Drawing.Point(170, 291)
        Me.BTNCALIFICAR.Name = "BTNCALIFICAR"
        Me.BTNCALIFICAR.Size = New System.Drawing.Size(44, 43)
        Me.BTNCALIFICAR.TabIndex = 152
        Me.BTNCALIFICAR.UseVisualStyleBackColor = True
        '
        'CBOCIUDADES
        '
        Me.CBOCIUDADES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCIUDADES.FormattingEnabled = True
        Me.CBOCIUDADES.Location = New System.Drawing.Point(169, 110)
        Me.CBOCIUDADES.MaxDropDownItems = 50
        Me.CBOCIUDADES.Name = "CBOCIUDADES"
        Me.CBOCIUDADES.Size = New System.Drawing.Size(269, 21)
        Me.CBOCIUDADES.TabIndex = 150
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Ciudad:"
        '
        'CBOCODIGOGRUPO
        '
        Me.CBOCODIGOGRUPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOGRUPO.FormattingEnabled = True
        Me.CBOCODIGOGRUPO.Location = New System.Drawing.Point(169, 191)
        Me.CBOCODIGOGRUPO.MaxDropDownItems = 50
        Me.CBOCODIGOGRUPO.Name = "CBOCODIGOGRUPO"
        Me.CBOCODIGOGRUPO.Size = New System.Drawing.Size(42, 21)
        Me.CBOCODIGOGRUPO.TabIndex = 146
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 14)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "Grado:"
        '
        'CBOCODIGOSEDE
        '
        Me.CBOCODIGOSEDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOSEDE.Enabled = False
        Me.CBOCODIGOSEDE.FormattingEnabled = True
        Me.CBOCODIGOSEDE.Location = New System.Drawing.Point(169, 164)
        Me.CBOCODIGOSEDE.MaxDropDownItems = 50
        Me.CBOCODIGOSEDE.Name = "CBOCODIGOSEDE"
        Me.CBOCODIGOSEDE.Size = New System.Drawing.Size(66, 21)
        Me.CBOCODIGOSEDE.TabIndex = 145
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 14)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Código Colegio:"
        '
        'CBOCOLEGIOS
        '
        Me.CBOCOLEGIOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCOLEGIOS.FormattingEnabled = True
        Me.CBOCOLEGIOS.Location = New System.Drawing.Point(169, 137)
        Me.CBOCOLEGIOS.MaxDropDownItems = 50
        Me.CBOCOLEGIOS.Name = "CBOCOLEGIOS"
        Me.CBOCOLEGIOS.Size = New System.Drawing.Size(269, 21)
        Me.CBOCOLEGIOS.TabIndex = 144
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(48, 139)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 14)
        Me.Label18.TabIndex = 147
        Me.Label18.Text = "Nombre Colegio:"
        '
        'LECTURA_GRADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(485, 375)
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
        Me.Name = "LECTURA_GRADO"
        Me.Text = "LECTURA_GRADO"
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
End Class