'-------------------------------------------Importing FireSharp. Make sure you have FireSharp installed on this project.
'-------------------------------------------For more information see here : https://github.com/ziyasal/FireSharp
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
'-------------------------------------------
Imports System.Web.Script.Serialization '(Importing System.Web.Script.Serialization) This is used to read and convert JSON strings.

Public Class CadNewUser
    Private x, y As Integer
    Private newpoint As Point
    '-------------------------------------------Configure FireSharp
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "DwZBui2w2YLamtMyzVAscnjXXtgU2fiGCDMftN4R",
        .BasePath = "https://crud-96b20-default-rtdb.firebaseio.com/"
        }

    Private client As IFirebaseClient


    Private Sub CadNewUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub BtnCad_Click(sender As Object, e As EventArgs)
#Region "Condition"
        If (String.IsNullOrWhiteSpace(TBNome.Text) AndAlso
            String.IsNullOrWhiteSpace(TBUser.Text) AndAlso
            String.IsNullOrWhiteSpace(TBSenha.Text) AndAlso
            String.IsNullOrWhiteSpace(TBEmail.Text)
            ) Then
            MessageBox.Show("Por favor preencha todos os campos!")
            Return
        End If
#End Region

        Dim NovoUsuario As New Usuarios() With
            {
            .Nome = TBNome.Text,
            .Usuário = TBUser.Text,
            .Senha = TBSenha.Text,
            .Email = TBEmail.Text
            }

        Dim setter = client.Set("Usuários/" + TBUser.Text, NovoUsuario)
        MessageBox.Show("Usuário Registrado com sucesso!")
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub CadNewUser_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim LoginForm As New Inicio
        Me.Hide()
        LoginForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BtnCad_Click_1(sender As Object, e As EventArgs) Handles BtnCad.Click
        BtnCad_Click(sender, e)
    End Sub

    Private Sub CadNewUser_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class