Public Class F_Menu

    Private x, y As Integer
    Private newpoint As Point


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim LoginForm As New Inicio
        Me.Hide()
        LoginForm.ShowDialog()
        Me.Close()
    End Sub
    Private Sub F_Menu_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub BtnGAluno_Click(sender As Object, e As EventArgs) Handles BtnGAluno.Click
        Dim GestaoAluno As New MATRICULAS
        GestaoAluno.NomedoUsuario2 = Fnome.Text
        Me.Hide()
        GestaoAluno.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BtnDiarias_Click(sender As Object, e As EventArgs) Handles BtnDiarias.Click, Button2.Click
        Dim RelGeral As New RelGeral
        RelGeral.NomedoUsuario2 = Fnome.Text
        Me.Hide()
        RelGeral.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BtnContas_Click(sender As Object, e As EventArgs) Handles BtnContas.Click
        Dim Contas As New CONTAS
        Contas.NomedoUsuario2 = Fnome.Text
        Me.Hide()
        Contas.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BtnMensalidades_Click(sender As Object, e As EventArgs) Handles BtnMensalidades.Click
        Dim CadastroAluno As New CadAluno
        CadastroAluno.NomedoUsuario2 = Fnome.Text
        Me.Hide()
        CadastroAluno.ShowDialog()
        Me.Close()
    End Sub



    Private Sub F_Menu_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub F_Menu_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Panel4_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel4.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class