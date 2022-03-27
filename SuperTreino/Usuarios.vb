Public Class Usuarios
    Public NomedoUsuario As String
    Public Property Nome() As String = ""
    Public Property Usuário() As String = ""
    Public Property Senha() As String = ""
    Public Property Email() As String = ""


    Private Shared TheError As String = "Usuário Não encontrado"



    Public Shared Sub ShowError()
        MessageBox.Show(TheError)
    End Sub

    Public Shared Function IsEqual(User1 As Usuarios, User2 As Usuarios)
        If (User1 Is Nothing Or User2 Is Nothing) Then
            TheError = "Usuário Não encontrado"
            Return False
        End If

        If (User1.Usuário <> User2.Usuário) Then
            TheError = "Usuário Não encontrado"
            Return False

        ElseIf (User1.Senha <> User2.Senha) Then
            TheError = "Usuário e Senha Invalidos"
            Return False
        End If
        Return True
    End Function
End Class
