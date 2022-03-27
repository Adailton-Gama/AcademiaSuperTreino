<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Menu))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnContas = New System.Windows.Forms.Button()
        Me.BtnDiarias = New System.Windows.Forms.Button()
        Me.BtnGAluno = New System.Windows.Forms.Button()
        Me.BtnMensalidades = New System.Windows.Forms.Button()
        Me.Fnome = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Nome = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FotoTopo = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.FotoTopo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Inicio.My.Resources.Resources.BACKGROUND_PRETO
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(878, 530)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Location = New System.Drawing.Point(67, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(713, 483)
        Me.Panel4.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(13, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(238, 281)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Inicio.My.Resources.Resources.BACKGROUND_CINZA
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.BtnContas)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BtnDiarias)
        Me.Panel1.Controls.Add(Me.BtnGAluno)
        Me.Panel1.Controls.Add(Me.BtnMensalidades)
        Me.Panel1.Controls.Add(Me.Fnome)
        Me.Panel1.Controls.Add(Me.LblUsuario)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Nome)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(221, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 447)
        Me.Panel1.TabIndex = 0
        '
        'BtnContas
        '
        Me.BtnContas.BackColor = System.Drawing.Color.Transparent
        Me.BtnContas.BackgroundImage = Global.Inicio.My.Resources.Resources.BOTAO_MENU1
        Me.BtnContas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnContas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnContas.FlatAppearance.BorderSize = 0
        Me.BtnContas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnContas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContas.ForeColor = System.Drawing.Color.White
        Me.BtnContas.Image = Global.Inicio.My.Resources.Resources.DESPESAICO
        Me.BtnContas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnContas.Location = New System.Drawing.Point(256, 233)
        Me.BtnContas.Name = "BtnContas"
        Me.BtnContas.Size = New System.Drawing.Size(201, 63)
        Me.BtnContas.TabIndex = 3
        Me.BtnContas.Text = "CONTAS"
        Me.BtnContas.UseVisualStyleBackColor = False
        '
        'BtnDiarias
        '
        Me.BtnDiarias.BackColor = System.Drawing.Color.Transparent
        Me.BtnDiarias.BackgroundImage = Global.Inicio.My.Resources.Resources.BOTAO_MENU1
        Me.BtnDiarias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDiarias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDiarias.FlatAppearance.BorderSize = 0
        Me.BtnDiarias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDiarias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDiarias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDiarias.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDiarias.ForeColor = System.Drawing.Color.White
        Me.BtnDiarias.Image = CType(resources.GetObject("BtnDiarias.Image"), System.Drawing.Image)
        Me.BtnDiarias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDiarias.Location = New System.Drawing.Point(49, 233)
        Me.BtnDiarias.Name = "BtnDiarias"
        Me.BtnDiarias.Size = New System.Drawing.Size(201, 63)
        Me.BtnDiarias.TabIndex = 0
        Me.BtnDiarias.Text = "        DIARIAS"
        Me.BtnDiarias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDiarias.UseVisualStyleBackColor = False
        '
        'BtnGAluno
        '
        Me.BtnGAluno.BackColor = System.Drawing.Color.Transparent
        Me.BtnGAluno.BackgroundImage = Global.Inicio.My.Resources.Resources.BOTAO_MENU1
        Me.BtnGAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGAluno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGAluno.FlatAppearance.BorderSize = 0
        Me.BtnGAluno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnGAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnGAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGAluno.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGAluno.ForeColor = System.Drawing.Color.White
        Me.BtnGAluno.Image = CType(resources.GetObject("BtnGAluno.Image"), System.Drawing.Image)
        Me.BtnGAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGAluno.Location = New System.Drawing.Point(49, 149)
        Me.BtnGAluno.Name = "BtnGAluno"
        Me.BtnGAluno.Size = New System.Drawing.Size(201, 63)
        Me.BtnGAluno.TabIndex = 3
        Me.BtnGAluno.Text = "    GESTÃO DE ALUNOS"
        Me.BtnGAluno.UseVisualStyleBackColor = False
        '
        'BtnMensalidades
        '
        Me.BtnMensalidades.BackColor = System.Drawing.Color.Transparent
        Me.BtnMensalidades.BackgroundImage = Global.Inicio.My.Resources.Resources.BOTAO_MENU1
        Me.BtnMensalidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMensalidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMensalidades.FlatAppearance.BorderSize = 0
        Me.BtnMensalidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnMensalidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnMensalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMensalidades.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMensalidades.ForeColor = System.Drawing.Color.White
        Me.BtnMensalidades.Image = Global.Inicio.My.Resources.Resources.ENTRADAICO
        Me.BtnMensalidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMensalidades.Location = New System.Drawing.Point(256, 150)
        Me.BtnMensalidades.Name = "BtnMensalidades"
        Me.BtnMensalidades.Size = New System.Drawing.Size(201, 63)
        Me.BtnMensalidades.TabIndex = 0
        Me.BtnMensalidades.Text = "      MENSALIDADES"
        Me.BtnMensalidades.UseVisualStyleBackColor = False
        '
        'Fnome
        '
        Me.Fnome.AutoSize = True
        Me.Fnome.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fnome.ForeColor = System.Drawing.Color.White
        Me.Fnome.Location = New System.Drawing.Point(36, 410)
        Me.Fnome.Name = "Fnome"
        Me.Fnome.Size = New System.Drawing.Size(124, 17)
        Me.Fnome.TabIndex = 9
        Me.Fnome.Text = "Usuário Logado:"
        Me.Fnome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.White
        Me.LblUsuario.Location = New System.Drawing.Point(36, 391)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(151, 18)
        Me.LblUsuario.TabIndex = 8
        Me.LblUsuario.Text = "Usuário Logado:"
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Inicio.My.Resources.Resources.BOTAO_MENU1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.Inicio.My.Resources.Resources.DESLOGARICO
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(263, 381)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(185, 51)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "DESLOGAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome.ForeColor = System.Drawing.Color.White
        Me.Nome.Location = New System.Drawing.Point(143, 106)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(193, 32)
        Me.Nome.TabIndex = 2
        Me.Nome.Text = "BEM VINDO"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Inicio.My.Resources.Resources.BACK_TOPO
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.FotoTopo)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 95)
        Me.Panel2.TabIndex = 1
        '
        'FotoTopo
        '
        Me.FotoTopo.Image = Global.Inicio.My.Resources.Resources.TOPO
        Me.FotoTopo.Location = New System.Drawing.Point(18, 3)
        Me.FotoTopo.Name = "FotoTopo"
        Me.FotoTopo.Size = New System.Drawing.Size(427, 77)
        Me.FotoTopo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoTopo.TabIndex = 0
        Me.FotoTopo.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Inicio.My.Resources.Resources.BOTAO_MENU1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(49, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(408, 63)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "         RELATÓRIO GERAL"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'F_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 530)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.FotoTopo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Nome As Label
    Friend WithEvents FotoTopo As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnContas As Button
    Friend WithEvents BtnDiarias As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnMensalidades As Button
    Friend WithEvents BtnGAluno As Button
    Friend WithEvents LblUsuario As Label
    Friend WithEvents Fnome As Label
    Friend WithEvents Button2 As Button
End Class
