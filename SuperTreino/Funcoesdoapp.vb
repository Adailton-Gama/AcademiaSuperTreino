Module Funcoesdoapp
    Public Sub Fecharapp()
        Dim resultado As MsgBoxResult
        resultado = MsgBox("Você tem certeza que deseja fechar o programa?", MsgBoxStyle.YesNo)
        If resultado = vbYes Then
            Application.Exit()
        End If
    End Sub

End Module
