<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RelPag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelPag))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblPdf = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblValPag = New System.Windows.Forms.Label()
        Me.LblTotalUser = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TITULO = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVRelatorio = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorPG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtPg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacoes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVRelatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblPdf
        '
        Me.LblPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPdf.AutoSize = True
        Me.LblPdf.BackColor = System.Drawing.Color.Transparent
        Me.LblPdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblPdf.ForeColor = System.Drawing.Color.Black
        Me.LblPdf.Location = New System.Drawing.Point(290, 613)
        Me.LblPdf.Name = "LblPdf"
        Me.LblPdf.Size = New System.Drawing.Size(76, 17)
        Me.LblPdf.TabIndex = 85
        Me.LblPdf.Text = "Gerar PDF"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(95, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 32)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "RELATÓRIO DE MENSALIDADES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblValPag
        '
        Me.LblValPag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblValPag.AutoSize = True
        Me.LblValPag.BackColor = System.Drawing.Color.Transparent
        Me.LblValPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblValPag.ForeColor = System.Drawing.Color.Black
        Me.LblValPag.Location = New System.Drawing.Point(542, 588)
        Me.LblValPag.Name = "LblValPag"
        Me.LblValPag.Size = New System.Drawing.Size(0, 17)
        Me.LblValPag.TabIndex = 84
        Me.LblValPag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalUser
        '
        Me.LblTotalUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTotalUser.AutoSize = True
        Me.LblTotalUser.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblTotalUser.ForeColor = System.Drawing.Color.Black
        Me.LblTotalUser.Location = New System.Drawing.Point(12, 588)
        Me.LblTotalUser.Name = "LblTotalUser"
        Me.LblTotalUser.Size = New System.Drawing.Size(111, 17)
        Me.LblTotalUser.TabIndex = 83
        Me.LblTotalUser.Text = "Total de Alunos:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TITULO)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 96)
        Me.Panel1.TabIndex = 82
        '
        'TITULO
        '
        Me.TITULO.AutoSize = True
        Me.TITULO.BackColor = System.Drawing.Color.Transparent
        Me.TITULO.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.TITULO.ForeColor = System.Drawing.Color.White
        Me.TITULO.Location = New System.Drawing.Point(202, 32)
        Me.TITULO.Name = "TITULO"
        Me.TITULO.Size = New System.Drawing.Size(319, 32)
        Me.TITULO.TabIndex = 39
        Me.TITULO.Text = "GESTÃO DE ALUNOS"
        Me.TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Inicio.My.Resources.Resources.back_to_200px
        Me.PictureBox2.Location = New System.Drawing.Point(613, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 55)
        Me.Button1.TabIndex = 37
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DGVRelatorio
        '
        Me.DGVRelatorio.AllowUserToAddRows = False
        Me.DGVRelatorio.AllowUserToDeleteRows = False
        Me.DGVRelatorio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVRelatorio.BackgroundColor = System.Drawing.Color.White
        Me.DGVRelatorio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVRelatorio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVRelatorio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nome, Me.Plano, Me.ValorPG, Me.dtPg, Me.Telefone, Me.Observacoes, Me.Situacao})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVRelatorio.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVRelatorio.EnableHeadersVisualStyles = False
        Me.DGVRelatorio.Location = New System.Drawing.Point(4, 219)
        Me.DGVRelatorio.Name = "DGVRelatorio"
        Me.DGVRelatorio.ReadOnly = True
        Me.DGVRelatorio.RowHeadersVisible = False
        Me.DGVRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRelatorio.Size = New System.Drawing.Size(673, 357)
        Me.DGVRelatorio.TabIndex = 81
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
        Me.dtPg.HeaderText = "Pagamento"
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
        Me.Observacoes.HeaderText = "Observações"
        Me.Observacoes.Name = "Observacoes"
        Me.Observacoes.ReadOnly = True
        '
        'Situacao
        '
        Me.Situacao.HeaderText = "situacao"
        Me.Situacao.Name = "Situacao"
        Me.Situacao.ReadOnly = True
        '
        'CBSearchBy
        '
        Me.CBSearchBy.FormattingEnabled = True
        Me.CBSearchBy.Items.AddRange(New Object() {"", "Pago", "Pendente"})
        Me.CBSearchBy.Location = New System.Drawing.Point(556, 192)
        Me.CBSearchBy.Name = "CBSearchBy"
        Me.CBSearchBy.Size = New System.Drawing.Size(121, 21)
        Me.CBSearchBy.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(95, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 32)
        Me.Label2.TabIndex = 88
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RelPag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(681, 639)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBSearchBy)
        Me.Controls.Add(Me.LblPdf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblValPag)
        Me.Controls.Add(Me.LblTotalUser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVRelatorio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RelPag"
        Me.Text = "RelPag"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVRelatorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPdf As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblValPag As Label
    Friend WithEvents LblTotalUser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TITULO As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DGVRelatorio As DataGridView
    Friend WithEvents CBSearchBy As ComboBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Plano As DataGridViewTextBoxColumn
    Friend WithEvents ValorPG As DataGridViewTextBoxColumn
    Friend WithEvents dtPg As DataGridViewTextBoxColumn
    Friend WithEvents Telefone As DataGridViewTextBoxColumn
    Friend WithEvents Observacoes As DataGridViewTextBoxColumn
    Friend WithEvents Situacao As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
