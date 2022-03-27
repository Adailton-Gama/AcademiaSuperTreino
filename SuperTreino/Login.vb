Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class Inicio
    Private x, y As Integer
    Private newpoint As Point
    '-------------------------------------------Configure FireSharp
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "DwZBui2w2YLamtMyzVAscnjXXtgU2fiGCDMftN4R",
        .BasePath = "https://crud-96b20-default-rtdb.firebaseio.com/"
        }

    Private client As IFirebaseClient

    Private Sub Btn_Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Sair.Click

        Call Fecharapp()

    End Sub

    Private Sub Btn_entrar_Click(sender As Object, e As EventArgs) Handles Btn_entrar.Click
        If Me.Text_Usuario.Text = "" And Me.TextSenha.Text = "" Then
            MessageBox.Show("Usuário e Senha não foram preenchidos, Favor preencher!!")
            Me.Text_Usuario.Focus()
        Else

#Region "Condition"
            If (String.IsNullOrWhiteSpace(Text_Usuario.Text) AndAlso String.IsNullOrWhiteSpace(TextSenha.Text)) Then
                MessageBox.Show("Por favor Preencha os campos")
            End If
#End Region

            Dim res = client.Get("Usuários/" + Text_Usuario.Text)
            Dim ResUsuario = res.ResultAs(Of Usuarios)

            Dim CurUser As New Usuarios With
                {
                .Usuário = Text_Usuario.Text,
                .Senha = TextSenha.Text
                }

            If (Usuarios.IsEqual(ResUsuario, CurUser)) Then
                Dim Menu As New F_Menu
                Menu.Fnome.Text = ResUsuario.Nome
                Me.Hide()
                Menu.ShowDialog()
                Me.Close()
            Else
                Usuarios.ShowError()
                Me.Text_Usuario.Text = ""
                Me.TextSenha.Text = ""
                Me.Text_Usuario.Focus()
            End If
        End If

    End Sub

    Private Sub BtnCadUser_Click(sender As Object, e As EventArgs) Handles BtnCadUser.Click
        Dim reg As New CadNewUser
        reg.ShowDialog()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Inicio_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Inicio_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class
