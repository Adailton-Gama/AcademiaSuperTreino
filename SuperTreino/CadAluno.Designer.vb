<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadAluno
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadAluno))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnClearAll = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNome = New System.Windows.Forms.TextBox()
        Me.TITULO = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnClearSelection = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBObs = New System.Windows.Forms.TextBox()
        Me.TBPlano = New System.Windows.Forms.ComboBox()
        Me.TBDtPag = New System.Windows.Forms.ComboBox()
        Me.DGVUserData = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorPG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtPg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacoes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Situação = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMSUserDataTable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeletarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelecionarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LimparSeleçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblTotalUser = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.BtnCreateId = New System.Windows.Forms.Button()
        Me.TBValorPG = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblValPag = New System.Windows.Forms.Label()
        Me.TBStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblRelatorio = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUserData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSUserDataTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClearAll
        '
        Me.BtnClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnClearAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearAll.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearAll.ForeColor = System.Drawing.Color.White
        Me.BtnClearAll.Location = New System.Drawing.Point(722, 193)
        Me.BtnClearAll.Name = "BtnClearAll"
        Me.BtnClearAll.Size = New System.Drawing.Size(123, 33)
        Me.BtnClearAll.TabIndex = 10
        Me.BtnClearAll.Text = "Limpar"
        Me.BtnClearAll.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(593, 193)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(123, 33)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Cadastrar"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Dia de Pagamento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(304, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Valor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Plano:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nome:"
        '
        'TBNome
        '
        Me.TBNome.BackColor = System.Drawing.Color.Black
        Me.TBNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TBNome.ForeColor = System.Drawing.Color.White
        Me.TBNome.Location = New System.Drawing.Point(90, 116)
        Me.TBNome.Name = "TBNome"
        Me.TBNome.Size = New System.Drawing.Size(492, 30)
        Me.TBNome.TabIndex = 2
        '
        'TITULO
        '
        Me.TITULO.AutoSize = True
        Me.TITULO.BackColor = System.Drawing.Color.Transparent
        Me.TITULO.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.TITULO.ForeColor = System.Drawing.Color.White
        Me.TITULO.Location = New System.Drawing.Point(68, 19)
        Me.TITULO.Name = "TITULO"
        Me.TITULO.Size = New System.Drawing.Size(363, 32)
        Me.TITULO.TabIndex = 17
        Me.TITULO.Text = "CADASTRO DE ALUNOS"
        Me.TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TITULO)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnRefresh)
        Me.Panel1.Controls.Add(Me.BtnClearSelection)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 70)
        Me.Panel1.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Location = New System.Drawing.Point(544, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Nome do Usuário"
        Me.Label11.Visible = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblUser.Location = New System.Drawing.Point(437, 6)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(89, 13)
        Me.lblUser.TabIndex = 79
        Me.lblUser.Text = "Nome do Usuário"
        Me.lblUser.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Inicio.My.Resources.Resources.back_to_200px
        Me.PictureBox2.Location = New System.Drawing.Point(801, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(6, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 55)
        Me.Button1.TabIndex = 18
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Location = New System.Drawing.Point(424, 24)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(89, 25)
        Me.BtnEdit.TabIndex = 39
        Me.BtnEdit.Text = "Editar"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEdit.UseVisualStyleBackColor = False
        Me.BtnEdit.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(518, 24)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(64, 25)
        Me.BtnDelete.TabIndex = 40
        Me.BtnDelete.Text = "Deletar"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDelete.UseVisualStyleBackColor = False
        Me.BtnDelete.Visible = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Location = New System.Drawing.Point(588, 24)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(72, 25)
        Me.BtnRefresh.TabIndex = 41
        Me.BtnRefresh.Text = "Atualizar"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRefresh.UseVisualStyleBackColor = False
        Me.BtnRefresh.Visible = False
        '
        'BtnClearSelection
        '
        Me.BtnClearSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnClearSelection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearSelection.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearSelection.ForeColor = System.Drawing.Color.White
        Me.BtnClearSelection.Location = New System.Drawing.Point(665, 24)
        Me.BtnClearSelection.Name = "BtnClearSelection"
        Me.BtnClearSelection.Size = New System.Drawing.Size(65, 25)
        Me.BtnClearSelection.TabIndex = 41
        Me.BtnClearSelection.Text = "Limpar Seleção"
        Me.BtnClearSelection.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClearSelection.UseVisualStyleBackColor = False
        Me.BtnClearSelection.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(304, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Telefone:"
        '
        'TBTel
        '
        Me.TBTel.BackColor = System.Drawing.Color.Black
        Me.TBTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TBTel.ForeColor = System.Drawing.Color.White
        Me.TBTel.Location = New System.Drawing.Point(405, 196)
        Me.TBTel.Name = "TBTel"
        Me.TBTel.Size = New System.Drawing.Size(177, 30)
        Me.TBTel.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(20, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 25)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Observações:"
        '
        'TBObs
        '
        Me.TBObs.BackColor = System.Drawing.Color.Black
        Me.TBObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TBObs.ForeColor = System.Drawing.Color.White
        Me.TBObs.Location = New System.Drawing.Point(161, 236)
        Me.TBObs.Multiline = True
        Me.TBObs.Name = "TBObs"
        Me.TBObs.Size = New System.Drawing.Size(421, 28)
        Me.TBObs.TabIndex = 8
        '
        'TBPlano
        '
        Me.TBPlano.BackColor = System.Drawing.Color.Black
        Me.TBPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TBPlano.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPlano.ForeColor = System.Drawing.Color.White
        Me.TBPlano.FormattingEnabled = True
        Me.TBPlano.Items.AddRange(New Object() {"MENSALIDADE", "15 DIAS", "10 DIAS", "7 DIAS", "4 DIAS", "1 DIA"})
        Me.TBPlano.Location = New System.Drawing.Point(90, 155)
        Me.TBPlano.Name = "TBPlano"
        Me.TBPlano.Size = New System.Drawing.Size(208, 32)
        Me.TBPlano.TabIndex = 3
        '
        'TBDtPag
        '
        Me.TBDtPag.BackColor = System.Drawing.Color.Black
        Me.TBDtPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TBDtPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDtPag.ForeColor = System.Drawing.Color.White
        Me.TBDtPag.FormattingEnabled = True
        Me.TBDtPag.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.TBDtPag.Location = New System.Drawing.Point(201, 194)
        Me.TBDtPag.Name = "TBDtPag"
        Me.TBDtPag.Size = New System.Drawing.Size(97, 32)
        Me.TBDtPag.TabIndex = 5
        '
        'DGVUserData
        '
        Me.DGVUserData.AllowUserToAddRows = False
        Me.DGVUserData.AllowUserToDeleteRows = False
        Me.DGVUserData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUserData.BackgroundColor = System.Drawing.Color.Black
        Me.DGVUserData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVUserData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUserData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVUserData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nome, Me.Plano, Me.ValorPG, Me.dtPg, Me.Telefone, Me.Observacoes, Me.Situação})
        Me.DGVUserData.ContextMenuStrip = Me.CMSUserDataTable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVUserData.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVUserData.EnableHeadersVisualStyles = False
        Me.DGVUserData.Location = New System.Drawing.Point(21, 316)
        Me.DGVUserData.Name = "DGVUserData"
        Me.DGVUserData.ReadOnly = True
        Me.DGVUserData.RowHeadersVisible = False
        Me.DGVUserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUserData.Size = New System.Drawing.Size(825, 146)
        Me.DGVUserData.TabIndex = 33
        '
        'ID
        '
        Me.ID.FillWeight = 35.53299!
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Nome
        '
        Me.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nome.FillWeight = 110.7445!
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'Plano
        '
        Me.Plano.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Plano.FillWeight = 110.7445!
        Me.Plano.HeaderText = "Plano"
        Me.Plano.Name = "Plano"
        Me.Plano.ReadOnly = True
        '
        'ValorPG
        '
        Me.ValorPG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ValorPG.FillWeight = 110.7445!
        Me.ValorPG.HeaderText = "ValorPG"
        Me.ValorPG.Name = "ValorPG"
        Me.ValorPG.ReadOnly = True
        '
        'dtPg
        '
        Me.dtPg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dtPg.FillWeight = 110.7445!
        Me.dtPg.HeaderText = "dtPg"
        Me.dtPg.Name = "dtPg"
        Me.dtPg.ReadOnly = True
        '
        'Telefone
        '
        Me.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Telefone.FillWeight = 110.7445!
        Me.Telefone.HeaderText = "Telefone"
        Me.Telefone.Name = "Telefone"
        Me.Telefone.ReadOnly = True
        '
        'Observacoes
        '
        Me.Observacoes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Observacoes.FillWeight = 110.7445!
        Me.Observacoes.HeaderText = "Observacoes"
        Me.Observacoes.Name = "Observacoes"
        Me.Observacoes.ReadOnly = True
        '
        'Situação
        '
        Me.Situação.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Situação.HeaderText = "Situação"
        Me.Situação.Name = "Situação"
        Me.Situação.ReadOnly = True
        '
        'CMSUserDataTable
        '
        Me.CMSUserDataTable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.ToolStripSeparator3, Me.DeletarToolStripMenuItem, Me.ToolStripSeparator1, Me.SelecionarTodosToolStripMenuItem, Me.ToolStripSeparator2, Me.LimparSeleçãoToolStripMenuItem, Me.AtualizarToolStripMenuItem})
        Me.CMSUserDataTable.Name = "CMSUserDataTable"
        Me.CMSUserDataTable.Size = New System.Drawing.Size(163, 132)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(159, 6)
        '
        'DeletarToolStripMenuItem
        '
        Me.DeletarToolStripMenuItem.Name = "DeletarToolStripMenuItem"
        Me.DeletarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DeletarToolStripMenuItem.Text = "Deletar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'SelecionarTodosToolStripMenuItem
        '
        Me.SelecionarTodosToolStripMenuItem.Name = "SelecionarTodosToolStripMenuItem"
        Me.SelecionarTodosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SelecionarTodosToolStripMenuItem.Text = "Selecionar Todos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(159, 6)
        '
        'LimparSeleçãoToolStripMenuItem
        '
        Me.LimparSeleçãoToolStripMenuItem.Name = "LimparSeleçãoToolStripMenuItem"
        Me.LimparSeleçãoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LimparSeleçãoToolStripMenuItem.Text = "Limpar Seleção"
        '
        'AtualizarToolStripMenuItem
        '
        Me.AtualizarToolStripMenuItem.Name = "AtualizarToolStripMenuItem"
        Me.AtualizarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AtualizarToolStripMenuItem.Text = "Atualizar"
        '
        'LblTotalUser
        '
        Me.LblTotalUser.AutoSize = True
        Me.LblTotalUser.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblTotalUser.ForeColor = System.Drawing.Color.White
        Me.LblTotalUser.Location = New System.Drawing.Point(22, 465)
        Me.LblTotalUser.Name = "LblTotalUser"
        Me.LblTotalUser.Size = New System.Drawing.Size(111, 17)
        Me.LblTotalUser.TabIndex = 34
        Me.LblTotalUser.Text = "Total de Alunos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 25)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Pesquisar:"
        '
        'TBSearch
        '
        Me.TBSearch.BackColor = System.Drawing.Color.Black
        Me.TBSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TBSearch.ForeColor = System.Drawing.Color.White
        Me.TBSearch.Location = New System.Drawing.Point(115, 281)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(573, 30)
        Me.TBSearch.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(694, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 25)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Por:"
        '
        'CBSearchBy
        '
        Me.CBSearchBy.BackColor = System.Drawing.Color.Black
        Me.CBSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSearchBy.ForeColor = System.Drawing.Color.White
        Me.CBSearchBy.FormattingEnabled = True
        Me.CBSearchBy.ItemHeight = 24
        Me.CBSearchBy.Items.AddRange(New Object() {"ID", "Nome", "Plano", "Situação"})
        Me.CBSearchBy.Location = New System.Drawing.Point(748, 277)
        Me.CBSearchBy.Name = "CBSearchBy"
        Me.CBSearchBy.Size = New System.Drawing.Size(97, 32)
        Me.CBSearchBy.TabIndex = 12
        Me.CBSearchBy.Text = "Nome"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(17, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 25)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Id:"
        '
        'TBID
        '
        Me.TBID.BackColor = System.Drawing.Color.Black
        Me.TBID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TBID.ForeColor = System.Drawing.Color.White
        Me.TBID.Location = New System.Drawing.Point(57, 76)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(90, 30)
        Me.TBID.TabIndex = 1
        '
        'BtnCreateId
        '
        Me.BtnCreateId.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnCreateId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCreateId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreateId.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateId.ForeColor = System.Drawing.Color.White
        Me.BtnCreateId.Location = New System.Drawing.Point(153, 77)
        Me.BtnCreateId.Name = "BtnCreateId"
        Me.BtnCreateId.Size = New System.Drawing.Size(123, 33)
        Me.BtnCreateId.TabIndex = 0
        Me.BtnCreateId.Text = "Gerar Id"
        Me.BtnCreateId.UseVisualStyleBackColor = False
        '
        'TBValorPG
        '
        Me.TBValorPG.BackColor = System.Drawing.Color.Black
        Me.TBValorPG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TBValorPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBValorPG.ForeColor = System.Drawing.Color.White
        Me.TBValorPG.FormattingEnabled = True
        Me.TBValorPG.Items.AddRange(New Object() {" R$40,00 ", " R$25,00 ", " R$20,00 ", " R$18,00 ", " R$15,00 ", " R$5,00"})
        Me.TBValorPG.Location = New System.Drawing.Point(374, 153)
        Me.TBValorPG.Name = "TBValorPG"
        Me.TBValorPG.Size = New System.Drawing.Size(208, 32)
        Me.TBValorPG.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(21, 273)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(825, 1)
        Me.Panel3.TabIndex = 46
        '
        'LblValPag
        '
        Me.LblValPag.AutoSize = True
        Me.LblValPag.BackColor = System.Drawing.Color.Transparent
        Me.LblValPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblValPag.ForeColor = System.Drawing.Color.White
        Me.LblValPag.Location = New System.Drawing.Point(662, 465)
        Me.LblValPag.Name = "LblValPag"
        Me.LblValPag.Size = New System.Drawing.Size(204, 17)
        Me.LblValPag.TabIndex = 47
        Me.LblValPag.Text = "ValorPG Total de Pagamentos:"
        Me.LblValPag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBStatus
        '
        Me.TBStatus.BackColor = System.Drawing.Color.Black
        Me.TBStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TBStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBStatus.ForeColor = System.Drawing.Color.White
        Me.TBStatus.FormattingEnabled = True
        Me.TBStatus.Items.AddRange(New Object() {"Pago", "Pendente"})
        Me.TBStatus.Location = New System.Drawing.Point(593, 147)
        Me.TBStatus.Name = "TBStatus"
        Me.TBStatus.Size = New System.Drawing.Size(252, 32)
        Me.TBStatus.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(588, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(206, 25)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Status de Pagamento:"
        '
        'LblRelatorio
        '
        Me.LblRelatorio.AutoSize = True
        Me.LblRelatorio.BackColor = System.Drawing.Color.Transparent
        Me.LblRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblRelatorio.ForeColor = System.Drawing.Color.White
        Me.LblRelatorio.Location = New System.Drawing.Point(371, 465)
        Me.LblRelatorio.Name = "LblRelatorio"
        Me.LblRelatorio.Size = New System.Drawing.Size(106, 17)
        Me.LblRelatorio.TabIndex = 78
        Me.LblRelatorio.Text = "Gerar Relatório"
        '
        'CadAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(862, 491)
        Me.Controls.Add(Me.LblRelatorio)
        Me.Controls.Add(Me.TBStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblValPag)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TBValorPG)
        Me.Controls.Add(Me.BtnCreateId)
        Me.Controls.Add(Me.TBID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CBSearchBy)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblTotalUser)
        Me.Controls.Add(Me.DGVUserData)
        Me.Controls.Add(Me.TBDtPag)
        Me.Controls.Add(Me.TBPlano)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBObs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBTel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnClearAll)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBNome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadAluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadAluno"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUserData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSUserDataTable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClearAll As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBNome As TextBox
    Friend WithEvents TITULO As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TBTel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBObs As TextBox
    Friend WithEvents TBPlano As ComboBox
    Friend WithEvents TBDtPag As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DGVUserData As DataGridView
    Friend WithEvents CMSUserDataTable As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeletarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecionarTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimparSeleçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LblTotalUser As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CBSearchBy As ComboBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnClearSelection As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TBID As TextBox
    Friend WithEvents BtnCreateId As Button
    Friend WithEvents AtualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TBValorPG As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblValPag As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Plano As DataGridViewTextBoxColumn
    Friend WithEvents ValorPG As DataGridViewTextBoxColumn
    Friend WithEvents dtPg As DataGridViewTextBoxColumn
    Friend WithEvents Telefone As DataGridViewTextBoxColumn
    Friend WithEvents Observacoes As DataGridViewTextBoxColumn
    Friend WithEvents Situação As DataGridViewTextBoxColumn
    Friend WithEvents TBStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents LblRelatorio As Label
    Friend WithEvents Label11 As Label
End Class
