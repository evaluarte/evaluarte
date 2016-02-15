<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mostrar_Reporte_Estudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mostrar_Reporte_Estudiante))
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNCALIFICAR = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CBOTIPO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTCODIGOESTUDIANTE = New System.Windows.Forms.TextBox()
        Me.CBOCODIGOSIMULACRO = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.Location = New System.Drawing.Point(274, 152)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(44, 43)
        Me.BTNSALIR.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.BTNSALIR, "Salir")
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'BTNCALIFICAR
        '
        Me.BTNCALIFICAR.BackgroundImage = CType(resources.GetObject("BTNCALIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNCALIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCALIFICAR.Location = New System.Drawing.Point(183, 152)
        Me.BTNCALIFICAR.Name = "BTNCALIFICAR"
        Me.BTNCALIFICAR.Size = New System.Drawing.Size(44, 43)
        Me.BTNCALIFICAR.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.BTNCALIFICAR, "Vista Preliminar ")
        Me.BTNCALIFICAR.UseVisualStyleBackColor = True
        '
        'CBOTIPO
        '
        Me.CBOTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOTIPO.FormattingEnabled = True
        Me.CBOTIPO.Location = New System.Drawing.Point(138, 64)
        Me.CBOTIPO.Name = "CBOTIPO"
        Me.CBOTIPO.Size = New System.Drawing.Size(244, 21)
        Me.CBOTIPO.TabIndex = 107
        Me.CBOTIPO.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(42, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 14)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Tipo Prueba:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(47, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 14)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Codigo Estudiante:"
        '
        'TXTCODIGOESTUDIANTE
        '
        Me.TXTCODIGOESTUDIANTE.Location = New System.Drawing.Point(184, 105)
        Me.TXTCODIGOESTUDIANTE.Name = "TXTCODIGOESTUDIANTE"
        Me.TXTCODIGOESTUDIANTE.Size = New System.Drawing.Size(97, 20)
        Me.TXTCODIGOESTUDIANTE.TabIndex = 110
        '
        'CBOCODIGOSIMULACRO
        '
        Me.CBOCODIGOSIMULACRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOSIMULACRO.Enabled = False
        Me.CBOCODIGOSIMULACRO.FormattingEnabled = True
        Me.CBOCODIGOSIMULACRO.Location = New System.Drawing.Point(3, 220)
        Me.CBOCODIGOSIMULACRO.MaxDropDownItems = 50
        Me.CBOCODIGOSIMULACRO.Name = "CBOCODIGOSIMULACRO"
        Me.CBOCODIGOSIMULACRO.Size = New System.Drawing.Size(10, 21)
        Me.CBOCODIGOSIMULACRO.TabIndex = 111
        '
        'Mostrar_Reporte_Estudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(403, 240)
        Me.Controls.Add(Me.CBOCODIGOSIMULACRO)
        Me.Controls.Add(Me.TXTCODIGOESTUDIANTE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBOTIPO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNCALIFICAR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mostrar_Reporte_Estudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Imprimir Resultados Estudiante"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents BTNCALIFICAR As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CBOTIPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTCODIGOESTUDIANTE As System.Windows.Forms.TextBox
    Friend WithEvents CBOCODIGOSIMULACRO As System.Windows.Forms.ComboBox
End Class
