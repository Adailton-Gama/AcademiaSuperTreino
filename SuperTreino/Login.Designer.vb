<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Btn_entrar = New System.Windows.Forms.Button()
        Me.Btn_Sair = New System.Windows.Forms.Button()
        Me.Text_Usuario = New ZBobb.AlphaBlendTextBox()
        Me.TextSenha = New ZBobb.AlphaBlendTextBox()
        Me.BtnCadUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_entrar
        '
        Me.Btn_entrar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_entrar.FlatAppearance.BorderSize = 0
        Me.Btn_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_entrar.Location = New System.Drawing.Point(346, 381)
        Me.Btn_entrar.Name = "Btn_entrar"
        Me.Btn_entrar.Size = New System.Drawing.Size(124, 45)
        Me.Btn_entrar.TabIndex = 3
        Me.Btn_entrar.UseVisualStyleBackColor = False
        '
        'Btn_Sair
        '
        Me.Btn_Sair.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Sair.FlatAppearance.BorderSize = 0
        Me.Btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Sair.Location = New System.Drawing.Point(567, 381)
        Me.Btn_Sair.Name = "Btn_Sair"
        Me.Btn_Sair.Size = New System.Drawing.Size(124, 45)
        Me.Btn_Sair.TabIndex = 4
        Me.Btn_Sair.UseVisualStyleBackColor = False
        '
        'Text_Usuario
        '
        Me.Text_Usuario.BackAlpha = 10
        Me.Text_Usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Text_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_Usuario.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Usuario.ForeColor = System.Drawing.Color.DarkGray
        Me.Text_Usuario.Location = New System.Drawing.Point(346, 173)
        Me.Text_Usuario.Name = "Text_Usuario"
        Me.Text_Usuario.Size = New System.Drawing.Size(345, 33)
        Me.Text_Usuario.TabIndex = 1
        '
        'TextSenha
        '
        Me.TextSenha.BackAlpha = 10
        Me.TextSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TextSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextSenha.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSenha.ForeColor = System.Drawing.Color.DarkGray
        Me.TextSenha.Location = New System.Drawing.Point(346, 293)
        Me.TextSenha.Name = "TextSenha"
        Me.TextSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextSenha.Size = New System.Drawing.Size(345, 33)
        Me.TextSenha.TabIndex = 2
        '
        'BtnCadUser
        '
        Me.BtnCadUser.BackColor = System.Drawing.Color.Transparent
        Me.BtnCadUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadUser.FlatAppearance.BorderSize = 0
        Me.BtnCadUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCadUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCadUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadUser.Location = New System.Drawing.Point(540, 479)
        Me.BtnCadUser.Name = "BtnCadUser"
        Me.BtnCadUser.Size = New System.Drawing.Size(116, 23)
        Me.BtnCadUser.TabIndex = 5
        Me.BtnCadUser.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Inicio.My.Resources.Resources.LOGIN
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(878, 530)
        Me.Controls.Add(Me.BtnCadUser)
        Me.Controls.Add(Me.TextSenha)
        Me.Controls.Add(Me.Text_Usuario)
        Me.Controls.Add(Me.Btn_Sair)
        Me.Controls.Add(Me.Btn_entrar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_entrar As System.Windows.Forms.Button
    Friend WithEvents Btn_Sair As System.Windows.Forms.Button
    Friend WithEvents Text_Usuario As ZBobb.AlphaBlendTextBox
    Friend WithEvents TextSenha As ZBobb.AlphaBlendTextBox
    Friend WithEvents BtnCadUser As Button
End Class
