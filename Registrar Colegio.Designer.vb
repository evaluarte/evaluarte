<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Colegio
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Codigo_colegioLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_Colegio))
        Me.SistemaevaluarteDataSet = New evaluarte.sistemaevaluarteDataSet()
        Me.ColegiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColegiosTableAdapter = New evaluarte.sistemaevaluarteDataSetTableAdapters.colegiosTableAdapter()
        Me.TableAdapterManager = New evaluarte.sistemaevaluarteDataSetTableAdapters.TableAdapterManager()
        Me.ColegiosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ColegiosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ColegiosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNAGREGARGRUPO = New System.Windows.Forms.Button()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BTNMODIFICARGRUPO = New System.Windows.Forms.Button()
        Me.Codigo_colegioTextBox = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Codigo_colegioLabel1 = New System.Windows.Forms.Label()
        CType(Me.SistemaevaluarteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColegiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColegiosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ColegiosBindingNavigator.SuspendLayout()
        CType(Me.ColegiosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.White
        NombreLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(419, 178)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(61, 14)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.BackColor = System.Drawing.Color.White
        DireccionLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(21, 215)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(68, 14)
        DireccionLabel.TabIndex = 6
        DireccionLabel.Text = "Dirección:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.BackColor = System.Drawing.Color.White
        CiudadLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadLabel.Location = New System.Drawing.Point(419, 220)
        CiudadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(56, 14)
        CiudadLabel.TabIndex = 8
        CiudadLabel.Text = "Ciudad:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.White
        TelefonoLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(21, 255)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(66, 14)
        TelefonoLabel.TabIndex = 10
        TelefonoLabel.Text = "Telefono:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.BackColor = System.Drawing.Color.White
        FechaLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(419, 255)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(129, 14)
        FechaLabel.TabIndex = 12
        FechaLabel.Text = "Fecha Vencimiento:"
        '
        'Codigo_colegioLabel1
        '
        Codigo_colegioLabel1.AutoSize = True
        Codigo_colegioLabel1.Location = New System.Drawing.Point(21, 181)
        Codigo_colegioLabel1.Name = "Codigo_colegioLabel1"
        Codigo_colegioLabel1.Size = New System.Drawing.Size(101, 14)
        Codigo_colegioLabel1.TabIndex = 44
        Codigo_colegioLabel1.Text = "codigo colegio:"
        '
        'SistemaevaluarteDataSet
        '
        Me.SistemaevaluarteDataSet.DataSetName = "sistemaevaluarteDataSet"
        Me.SistemaevaluarteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColegiosBindingSource
        '
        Me.ColegiosBindingSource.DataMember = "colegios"
        Me.ColegiosBindingSource.DataSource = Me.SistemaevaluarteDataSet
        '
        'ColegiosTableAdapter
        '
        Me.ColegiosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.colegiosTableAdapter = Me.ColegiosTableAdapter
        Me.TableAdapterManager.estudiantesTableAdapter = Nothing
        Me.TableAdapterManager.gruposTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = evaluarte.sistemaevaluarteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ColegiosBindingNavigator
        '
        Me.ColegiosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ColegiosBindingNavigator.BindingSource = Me.ColegiosBindingSource
        Me.ColegiosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ColegiosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ColegiosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ColegiosBindingNavigatorSaveItem})
        Me.ColegiosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ColegiosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ColegiosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ColegiosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ColegiosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ColegiosBindingNavigator.Name = "ColegiosBindingNavigator"
        Me.ColegiosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ColegiosBindingNavigator.Size = New System.Drawing.Size(823, 25)
        Me.ColegiosBindingNavigator.TabIndex = 0
        Me.ColegiosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.ToolTipText = "AGREGAR NUEVO COLEGIO"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número Total de Items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover al Inicio"
        Me.BindingNavigatorMoveFirstItem.ToolTipText = "MOVER AL PRIMERO"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover al Anterior"
        Me.BindingNavigatorMovePreviousItem.ToolTipText = "MOVER AL ANTERIOR"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición Actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        Me.BindingNavigatorMoveNextItem.ToolTipText = "MOVER AL SIGUIENTE"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover al Ultimo"
        Me.BindingNavigatorMoveLastItem.ToolTipText = "MOVER AL ULTIMO"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ColegiosBindingNavigatorSaveItem
        '
        Me.ColegiosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ColegiosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ColegiosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ColegiosBindingNavigatorSaveItem.Name = "ColegiosBindingNavigatorSaveItem"
        Me.ColegiosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ColegiosBindingNavigatorSaveItem.Tag = "7"
        Me.ColegiosBindingNavigatorSaveItem.Text = "Save Data"
        Me.ColegiosBindingNavigatorSaveItem.ToolTipText = "GUARDAR DATOS"
        '
        'ColegiosDataGridView
        '
        Me.ColegiosDataGridView.AllowUserToAddRows = False
        Me.ColegiosDataGridView.AllowUserToDeleteRows = False
        Me.ColegiosDataGridView.AutoGenerateColumns = False
        Me.ColegiosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.ColegiosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ColegiosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ColegiosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ColegiosDataGridView.DataSource = Me.ColegiosBindingSource
        Me.ColegiosDataGridView.Location = New System.Drawing.Point(24, 283)
        Me.ColegiosDataGridView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ColegiosDataGridView.Name = "ColegiosDataGridView"
        Me.ColegiosDataGridView.Size = New System.Drawing.Size(760, 287)
        Me.ColegiosDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codigo_colegio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codigo_colegio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 5
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 5
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 5
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn5.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 5
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 5
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColegiosBindingSource, "nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(556, 175)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(228, 22)
        Me.NombreTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.NombreTextBox, "Nombre del Colegio")
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColegiosBindingSource, "direccion", True))
        Me.DireccionTextBox.Enabled = False
        Me.DireccionTextBox.Location = New System.Drawing.Point(134, 212)
        Me.DireccionTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(265, 22)
        Me.DireccionTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.DireccionTextBox, "Direccion")
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColegiosBindingSource, "ciudad", True))
        Me.CiudadTextBox.Enabled = False
        Me.CiudadTextBox.Location = New System.Drawing.Point(556, 215)
        Me.CiudadTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(228, 22)
        Me.CiudadTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.CiudadTextBox, "Ciudad")
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColegiosBindingSource, "telefono", True))
        Me.TelefonoTextBox.Enabled = False
        Me.TelefonoTextBox.Location = New System.Drawing.Point(134, 252)
        Me.TelefonoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(265, 22)
        Me.TelefonoTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TelefonoTextBox, "Teléfono")
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.BackgroundImage = CType(resources.GetObject("BTNMODIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNMODIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(507, 64)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(57, 51)
        Me.BTNMODIFICAR.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.BTNMODIFICAR, "MODIFICAR")
        Me.BTNMODIFICAR.UseVisualStyleBackColor = True
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.Location = New System.Drawing.Point(727, 64)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(57, 51)
        Me.BTNSALIR.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.BTNSALIR, "SALIR")
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'BTNAGREGARGRUPO
        '
        Me.BTNAGREGARGRUPO.BackgroundImage = CType(resources.GetObject("BTNAGREGARGRUPO.BackgroundImage"), System.Drawing.Image)
        Me.BTNAGREGARGRUPO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNAGREGARGRUPO.Location = New System.Drawing.Point(581, 64)
        Me.BTNAGREGARGRUPO.Name = "BTNAGREGARGRUPO"
        Me.BTNAGREGARGRUPO.Size = New System.Drawing.Size(57, 51)
        Me.BTNAGREGARGRUPO.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.BTNAGREGARGRUPO, "AGREGAR GRUPO")
        Me.BTNAGREGARGRUPO.UseVisualStyleBackColor = True
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ColegiosBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(556, 255)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(228, 22)
        Me.FechaDateTimePicker.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.FechaDateTimePicker, "FECHA VENCIMIENTO")
        Me.FechaDateTimePicker.Value = New Date(2012, 6, 27, 0, 0, 0, 0)
        '
        'BTNMODIFICARGRUPO
        '
        Me.BTNMODIFICARGRUPO.BackgroundImage = CType(resources.GetObject("BTNMODIFICARGRUPO.BackgroundImage"), System.Drawing.Image)
        Me.BTNMODIFICARGRUPO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNMODIFICARGRUPO.Location = New System.Drawing.Point(655, 64)
        Me.BTNMODIFICARGRUPO.Name = "BTNMODIFICARGRUPO"
        Me.BTNMODIFICARGRUPO.Size = New System.Drawing.Size(57, 51)
        Me.BTNMODIFICARGRUPO.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.BTNMODIFICARGRUPO, "MODIFICAR GRUPO")
        Me.BTNMODIFICARGRUPO.UseVisualStyleBackColor = True
        '
        'Codigo_colegioTextBox
        '
        Me.Codigo_colegioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColegiosBindingSource, "codigo_colegio", True))
        Me.Codigo_colegioTextBox.Enabled = False
        Me.Codigo_colegioTextBox.Location = New System.Drawing.Point(134, 178)
        Me.Codigo_colegioTextBox.MaxLength = 3
        Me.Codigo_colegioTextBox.Name = "Codigo_colegioTextBox"
        Me.Codigo_colegioTextBox.Size = New System.Drawing.Size(53, 22)
        Me.Codigo_colegioTextBox.TabIndex = 1
        '
        'Registrar_Colegio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(823, 582)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.BTNMODIFICARGRUPO)
        Me.Controls.Add(Codigo_colegioLabel1)
        Me.Controls.Add(Me.Codigo_colegioTextBox)
        Me.Controls.Add(Me.BTNAGREGARGRUPO)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNMODIFICAR)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.ColegiosDataGridView)
        Me.Controls.Add(Me.ColegiosBindingNavigator)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Registrar_Colegio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar_Colegio"
        CType(Me.SistemaevaluarteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColegiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColegiosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ColegiosBindingNavigator.ResumeLayout(False)
        Me.ColegiosBindingNavigator.PerformLayout()
        CType(Me.ColegiosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SistemaevaluarteDataSet As evaluarte.sistemaevaluarteDataSet
    Friend WithEvents ColegiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ColegiosTableAdapter As evaluarte.sistemaevaluarteDataSetTableAdapters.colegiosTableAdapter
    Friend WithEvents TableAdapterManager As evaluarte.sistemaevaluarteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ColegiosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColegiosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColegiosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents BTNAGREGARGRUPO As System.Windows.Forms.Button
    Friend WithEvents Codigo_colegioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BTNMODIFICARGRUPO As System.Windows.Forms.Button
End Class
