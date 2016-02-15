<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simulacros_Presentados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simulacros_Presentados))
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNCALIFICAR = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTNBUSQUEDACOLEGIO = New System.Windows.Forms.Button()
        Me.BTNESTUDIANTE = New System.Windows.Forms.Button()
        Me.BTNCOLEGIO = New System.Windows.Forms.Button()
        Me.TXTCANTIDADPRESENTADOS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Busqueda_codigo = New System.Windows.Forms.FlowLayoutPanel()
        Me.Buscar_Colegio = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CBOCOLEGIOS = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBOCODIGOSEDE = New System.Windows.Forms.ComboBox()
        Me.CBOCODIGOSIMULACRO = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Busqueda_codigo.SuspendLayout()
        Me.Buscar_Colegio.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(157, 3)
        Me.TXTNOMBRE.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(146, 21)
        Me.TXTNOMBRE.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo Estudiante:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(69, 302)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(736, 343)
        Me.DataGridView1.TabIndex = 11
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.Location = New System.Drawing.Point(755, 32)
        Me.BTNSALIR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(50, 45)
        Me.BTNSALIR.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.BTNSALIR, "Salir")
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'BTNCALIFICAR
        '
        Me.BTNCALIFICAR.BackgroundImage = CType(resources.GetObject("BTNCALIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNCALIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCALIFICAR.Location = New System.Drawing.Point(311, 3)
        Me.BTNCALIFICAR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNCALIFICAR.Name = "BTNCALIFICAR"
        Me.BTNCALIFICAR.Size = New System.Drawing.Size(41, 36)
        Me.BTNCALIFICAR.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.BTNCALIFICAR, "Buscar")
        Me.BTNCALIFICAR.UseVisualStyleBackColor = True
        '
        'BTNBUSQUEDACOLEGIO
        '
        Me.BTNBUSQUEDACOLEGIO.BackgroundImage = CType(resources.GetObject("BTNBUSQUEDACOLEGIO.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSQUEDACOLEGIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSQUEDACOLEGIO.Location = New System.Drawing.Point(397, 3)
        Me.BTNBUSQUEDACOLEGIO.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNBUSQUEDACOLEGIO.Name = "BTNBUSQUEDACOLEGIO"
        Me.BTNBUSQUEDACOLEGIO.Size = New System.Drawing.Size(41, 36)
        Me.BTNBUSQUEDACOLEGIO.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.BTNBUSQUEDACOLEGIO, "Buscar")
        Me.BTNBUSQUEDACOLEGIO.UseVisualStyleBackColor = True
        '
        'BTNESTUDIANTE
        '
        Me.BTNESTUDIANTE.BackgroundImage = CType(resources.GetObject("BTNESTUDIANTE.BackgroundImage"), System.Drawing.Image)
        Me.BTNESTUDIANTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNESTUDIANTE.Location = New System.Drawing.Point(585, 184)
        Me.BTNESTUDIANTE.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNESTUDIANTE.Name = "BTNESTUDIANTE"
        Me.BTNESTUDIANTE.Size = New System.Drawing.Size(50, 45)
        Me.BTNESTUDIANTE.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.BTNESTUDIANTE, "BUSCAR POR ESTUDIANTE")
        Me.BTNESTUDIANTE.UseVisualStyleBackColor = True
        '
        'BTNCOLEGIO
        '
        Me.BTNCOLEGIO.BackgroundImage = CType(resources.GetObject("BTNCOLEGIO.BackgroundImage"), System.Drawing.Image)
        Me.BTNCOLEGIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCOLEGIO.Location = New System.Drawing.Point(585, 186)
        Me.BTNCOLEGIO.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNCOLEGIO.Name = "BTNCOLEGIO"
        Me.BTNCOLEGIO.Size = New System.Drawing.Size(50, 45)
        Me.BTNCOLEGIO.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.BTNCOLEGIO, "BUSCAR POR COLEGIO")
        Me.BTNCOLEGIO.UseVisualStyleBackColor = True
        Me.BTNCOLEGIO.Visible = False
        '
        'TXTCANTIDADPRESENTADOS
        '
        Me.TXTCANTIDADPRESENTADOS.AutoSize = True
        Me.TXTCANTIDADPRESENTADOS.BackColor = System.Drawing.Color.White
        Me.TXTCANTIDADPRESENTADOS.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCANTIDADPRESENTADOS.ForeColor = System.Drawing.Color.Black
        Me.TXTCANTIDADPRESENTADOS.Location = New System.Drawing.Point(777, 272)
        Me.TXTCANTIDADPRESENTADOS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TXTCANTIDADPRESENTADOS.Name = "TXTCANTIDADPRESENTADOS"
        Me.TXTCANTIDADPRESENTADOS.Size = New System.Drawing.Size(0, 18)
        Me.TXTCANTIDADPRESENTADOS.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(565, 275)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 14)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "CANTIDAD DE ESTUDIANTES:"
        '
        'Busqueda_codigo
        '
        Me.Busqueda_codigo.BackColor = System.Drawing.Color.White
        Me.Busqueda_codigo.Controls.Add(Me.Label1)
        Me.Busqueda_codigo.Controls.Add(Me.TXTNOMBRE)
        Me.Busqueda_codigo.Controls.Add(Me.BTNCALIFICAR)
        Me.Busqueda_codigo.Location = New System.Drawing.Point(69, 184)
        Me.Busqueda_codigo.Name = "Busqueda_codigo"
        Me.Busqueda_codigo.Size = New System.Drawing.Size(378, 69)
        Me.Busqueda_codigo.TabIndex = 51
        Me.Busqueda_codigo.Visible = False
        '
        'Buscar_Colegio
        '
        Me.Buscar_Colegio.BackColor = System.Drawing.Color.White
        Me.Buscar_Colegio.Controls.Add(Me.Label18)
        Me.Buscar_Colegio.Controls.Add(Me.CBOCOLEGIOS)
        Me.Buscar_Colegio.Controls.Add(Me.BTNBUSQUEDACOLEGIO)
        Me.Buscar_Colegio.Controls.Add(Me.Label7)
        Me.Buscar_Colegio.Controls.Add(Me.CBOCODIGOSEDE)
        Me.Buscar_Colegio.Location = New System.Drawing.Point(69, 187)
        Me.Buscar_Colegio.Name = "Buscar_Colegio"
        Me.Buscar_Colegio.Size = New System.Drawing.Size(489, 91)
        Me.Buscar_Colegio.TabIndex = 52
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 14)
        Me.Label18.TabIndex = 105
        Me.Label18.Text = "Nombre Colegio:"
        '
        'CBOCOLEGIOS
        '
        Me.CBOCOLEGIOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCOLEGIOS.FormattingEnabled = True
        Me.CBOCOLEGIOS.Location = New System.Drawing.Point(121, 3)
        Me.CBOCOLEGIOS.MaxDropDownItems = 50
        Me.CBOCOLEGIOS.Name = "CBOCOLEGIOS"
        Me.CBOCOLEGIOS.Size = New System.Drawing.Size(269, 23)
        Me.CBOCOLEGIOS.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 14)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Código Colegio:"
        '
        'CBOCODIGOSEDE
        '
        Me.CBOCODIGOSEDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOSEDE.Enabled = False
        Me.CBOCODIGOSEDE.FormattingEnabled = True
        Me.CBOCODIGOSEDE.Location = New System.Drawing.Point(116, 45)
        Me.CBOCODIGOSEDE.MaxDropDownItems = 50
        Me.CBOCODIGOSEDE.Name = "CBOCODIGOSEDE"
        Me.CBOCODIGOSEDE.Size = New System.Drawing.Size(55, 23)
        Me.CBOCODIGOSEDE.TabIndex = 104
        '
        'CBOCODIGOSIMULACRO
        '
        Me.CBOCODIGOSIMULACRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCODIGOSIMULACRO.Enabled = False
        Me.CBOCODIGOSIMULACRO.FormattingEnabled = True
        Me.CBOCODIGOSIMULACRO.Location = New System.Drawing.Point(12, 622)
        Me.CBOCODIGOSIMULACRO.MaxDropDownItems = 50
        Me.CBOCODIGOSIMULACRO.Name = "CBOCODIGOSIMULACRO"
        Me.CBOCODIGOSIMULACRO.Size = New System.Drawing.Size(10, 23)
        Me.CBOCODIGOSIMULACRO.TabIndex = 105
        '
        'Simulacros_Presentados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(838, 656)
        Me.Controls.Add(Me.Busqueda_codigo)
        Me.Controls.Add(Me.CBOCODIGOSIMULACRO)
        Me.Controls.Add(Me.BTNCOLEGIO)
        Me.Controls.Add(Me.BTNESTUDIANTE)
        Me.Controls.Add(Me.Buscar_Colegio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTCANTIDADPRESENTADOS)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Simulacros_Presentados"
        Me.Text = "Simulacros_Presentados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Busqueda_codigo.ResumeLayout(False)
        Me.Busqueda_codigo.PerformLayout()
        Me.Buscar_Colegio.ResumeLayout(False)
        Me.Buscar_Colegio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BTNCALIFICAR As System.Windows.Forms.Button
    Friend WithEvents TXTCANTIDADPRESENTADOS As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Busqueda_codigo As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Buscar_Colegio As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CBOCOLEGIOS As System.Windows.Forms.ComboBox
    Friend WithEvents BTNBUSQUEDACOLEGIO As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBOCODIGOSEDE As System.Windows.Forms.ComboBox
    Friend WithEvents BTNESTUDIANTE As System.Windows.Forms.Button
    Friend WithEvents BTNCOLEGIO As System.Windows.Forms.Button
    Friend WithEvents CBOCODIGOSIMULACRO As System.Windows.Forms.ComboBox
End Class
