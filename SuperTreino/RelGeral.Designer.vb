<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelGeral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelGeral))
        Me.LblPdf = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblValPag = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TITULO = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbldiarias = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblMensa = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblcontas = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblPdf
        '
        Me.LblPdf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPdf.AutoSize = True
        Me.LblPdf.BackColor = System.Drawing.Color.Transparent
        Me.LblPdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblPdf.ForeColor = System.Drawing.Color.Black
        Me.LblPdf.Location = New System.Drawing.Point(362, 565)
        Me.LblPdf.Name = "LblPdf"
        Me.LblPdf.Size = New System.Drawing.Size(76, 17)
        Me.LblPdf.TabIndex = 94
        Me.LblPdf.Text = "Gerar PDF"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(155, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 32)
        Me.Label1.TabIndex = 89
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
        Me.LblValPag.Location = New System.Drawing.Point(712, 575)
        Me.LblValPag.Name = "LblValPag"
        Me.LblValPag.Size = New System.Drawing.Size(0, 17)
        Me.LblValPag.TabIndex = 93
        Me.LblValPag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel1.Size = New System.Drawing.Size(800, 96)
        Me.Panel1.TabIndex = 91
        '
        'TITULO
        '
        Me.TITULO.AutoSize = True
        Me.TITULO.BackColor = System.Drawing.Color.Transparent
        Me.TITULO.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.TITULO.ForeColor = System.Drawing.Color.White
        Me.TITULO.Location = New System.Drawing.Point(259, 26)
        Me.TITULO.Name = "TITULO"
        Me.TITULO.Size = New System.Drawing.Size(300, 32)
        Me.TITULO.TabIndex = 39
        Me.TITULO.Text = "RELATÓRIO GERAL"
        Me.TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Inicio.My.Resources.Resources.back_to_200px
        Me.PictureBox2.Location = New System.Drawing.Point(732, 21)
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
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbldiarias)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(332, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 142)
        Me.Panel2.TabIndex = 96
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(100, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "DIARIAS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(283, 36)
        Me.Panel3.TabIndex = 95
        '
        'lbldiarias
        '
        Me.lbldiarias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldiarias.AutoSize = True
        Me.lbldiarias.BackColor = System.Drawing.Color.Transparent
        Me.lbldiarias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbldiarias.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lbldiarias.ForeColor = System.Drawing.Color.Black
        Me.lbldiarias.Location = New System.Drawing.Point(70, 62)
        Me.lbldiarias.Name = "lbldiarias"
        Me.lbldiarias.Size = New System.Drawing.Size(147, 37)
        Me.lbldiarias.TabIndex = 94
        Me.lbldiarias.Text = "R$ 00,00"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.LblMensa)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(29, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(285, 142)
        Me.Panel4.TabIndex = 96
        '
        'LblMensa
        '
        Me.LblMensa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMensa.AutoSize = True
        Me.LblMensa.BackColor = System.Drawing.Color.Transparent
        Me.LblMensa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblMensa.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblMensa.ForeColor = System.Drawing.Color.Black
        Me.LblMensa.Location = New System.Drawing.Point(70, 62)
        Me.LblMensa.Name = "LblMensa"
        Me.LblMensa.Size = New System.Drawing.Size(147, 37)
        Me.LblMensa.TabIndex = 94
        Me.LblMensa.Text = "R$ 00,00"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(283, 36)
        Me.Panel5.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(73, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 20)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "MENSALIDADE"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lblsaldo)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(332, 170)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(285, 142)
        Me.Panel6.TabIndex = 96
        '
        'lblsaldo
        '
        Me.lblsaldo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsaldo.AutoSize = True
        Me.lblsaldo.BackColor = System.Drawing.Color.Transparent
        Me.lblsaldo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblsaldo.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblsaldo.ForeColor = System.Drawing.Color.Black
        Me.lblsaldo.Location = New System.Drawing.Point(70, 62)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(147, 37)
        Me.lblsaldo.TabIndex = 94
        Me.lblsaldo.Text = "R$ 00,00"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(283, 36)
        Me.Panel7.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(67, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 20)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "SALDO LIQUIDO"
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lblcontas)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Location = New System.Drawing.Point(29, 170)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(285, 142)
        Me.Panel8.TabIndex = 96
        '
        'lblcontas
        '
        Me.lblcontas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcontas.AutoSize = True
        Me.lblcontas.BackColor = System.Drawing.Color.Transparent
        Me.lblcontas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblcontas.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblcontas.ForeColor = System.Drawing.Color.Black
        Me.lblcontas.Location = New System.Drawing.Point(70, 62)
        Me.lblcontas.Name = "lblcontas"
        Me.lblcontas.Size = New System.Drawing.Size(147, 37)
        Me.lblcontas.TabIndex = 94
        Me.lblcontas.Text = "R$ 00,00"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(283, 36)
        Me.Panel9.TabIndex = 95
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(101, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "CONTAS"
        '
        'Panel10
        '
        Me.Panel10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel10.Controls.Add(Me.Panel8)
        Me.Panel10.Controls.Add(Me.Panel6)
        Me.Panel10.Controls.Add(Me.Panel4)
        Me.Panel10.Controls.Add(Me.Panel2)
        Me.Panel10.Location = New System.Drawing.Point(67, 169)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(626, 326)
        Me.Panel10.TabIndex = 97
        '
        'RelGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 591)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.LblPdf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblValPag)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RelGeral"
        Me.Text = "RelGeral"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPdf As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblValPag As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TITULO As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbldiarias As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LblMensa As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblsaldo As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblcontas As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel10 As Panel
End Class
