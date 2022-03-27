<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadNewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadNewUser))
        Me.Login = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnClearAll = New System.Windows.Forms.Button()
        Me.BtnCad = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNome = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FotoTopo = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TITULO = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.FotoTopo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.BackColor = System.Drawing.Color.Black
        Me.Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.ForeColor = System.Drawing.Color.White
        Me.Login.Location = New System.Drawing.Point(198, 452)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(147, 20)
        Me.Login.TabIndex = 26
        Me.Login.Text = "Se sim click aqui!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(58, 452)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Já Possui Usuário?"
        '
        'BtnClearAll
        '
        Me.BtnClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnClearAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearAll.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearAll.Location = New System.Drawing.Point(236, 386)
        Me.BtnClearAll.Name = "BtnClearAll"
        Me.BtnClearAll.Size = New System.Drawing.Size(97, 27)
        Me.BtnClearAll.TabIndex = 24
        Me.BtnClearAll.Text = "Limpar"
        Me.BtnClearAll.UseVisualStyleBackColor = False
        '
        'BtnCad
        '
        Me.BtnCad.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnCad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCad.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCad.Location = New System.Drawing.Point(125, 386)
        Me.BtnCad.Name = "BtnCad"
        Me.BtnCad.Size = New System.Drawing.Size(105, 27)
        Me.BtnCad.TabIndex = 23
        Me.BtnCad.Text = "Cadastrar"
        Me.BtnCad.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "E-mail:"
        '
        'TBEmail
        '
        Me.TBEmail.BackColor = System.Drawing.Color.Black
        Me.TBEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TBEmail.ForeColor = System.Drawing.Color.White
        Me.TBEmail.Location = New System.Drawing.Point(125, 332)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(208, 30)
        Me.TBEmail.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Senha:"
        '
        'TBSenha
        '
        Me.TBSenha.BackColor = System.Drawing.Color.Black
        Me.TBSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TBSenha.ForeColor = System.Drawing.Color.White
        Me.TBSenha.Location = New System.Drawing.Point(125, 286)
        Me.TBSenha.Name = "TBSenha"
        Me.TBSenha.Size = New System.Drawing.Size(208, 30)
        Me.TBSenha.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Usuário:"
        '
        'TBUser
        '
        Me.TBUser.BackColor = System.Drawing.Color.Black
        Me.TBUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TBUser.ForeColor = System.Drawing.Color.White
        Me.TBUser.Location = New System.Drawing.Point(125, 239)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(208, 30)
        Me.TBUser.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nome:"
        '
        'TBNome
        '
        Me.TBNome.BackColor = System.Drawing.Color.Black
        Me.TBNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TBNome.ForeColor = System.Drawing.Color.White
        Me.TBNome.Location = New System.Drawing.Point(125, 193)
        Me.TBNome.Name = "TBNome"
        Me.TBNome.Size = New System.Drawing.Size(208, 30)
        Me.TBNome.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FotoTopo)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 70)
        Me.Panel1.TabIndex = 25
        '
        'FotoTopo
        '
        Me.FotoTopo.BackColor = System.Drawing.Color.Transparent
        Me.FotoTopo.Image = Global.Inicio.My.Resources.Resources.TOPO
        Me.FotoTopo.Location = New System.Drawing.Point(73, 4)
        Me.FotoTopo.Name = "FotoTopo"
        Me.FotoTopo.Size = New System.Drawing.Size(309, 55)
        Me.FotoTopo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoTopo.TabIndex = 0
        Me.FotoTopo.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(11, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 55)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TITULO
        '
        Me.TITULO.AutoSize = True
        Me.TITULO.BackColor = System.Drawing.Color.Black
        Me.TITULO.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.TITULO.ForeColor = System.Drawing.Color.White
        Me.TITULO.Location = New System.Drawing.Point(76, 107)
        Me.TITULO.Name = "TITULO"
        Me.TITULO.Size = New System.Drawing.Size(257, 64)
        Me.TITULO.TabIndex = 20
        Me.TITULO.Text = "CADASTRO DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NOVO USUÁRIO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CadNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(380, 491)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnClearAll)
        Me.Controls.Add(Me.BtnCad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBSenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBNome)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TITULO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CadNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.FotoTopo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnClearAll As Button
    Friend WithEvents BtnCad As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBSenha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBNome As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FotoTopo As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TITULO As Label
End Class
