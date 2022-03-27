'-------------------------------------------Importing FireSharp. Make sure you have FireSharp installed on this project.
'-------------------------------------------For more information see here : https://github.com/ziyasal/FireSharp
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
'-------------------------------------------

Imports System.Web.Script.Serialization '(Importing System.Web.Script.Serialization) This is used to read and convert JSON strings.
Imports System.ComponentModel '(Importing System.ComponentModel) This is used to sort data on DataGridView.
Imports System.IO '(Importing System.IO) This is used for ImageToBase64 Public Functions and Base64ToImage Public Functions.

Public Class CONTAS
    Public Property NomedoUsuario2 As String
    Private x, y As Integer
    Private newpoint As Point

    Dim IMG_FileNameInput As String 'This variable is used to hold the address and file name of the image that will be displayed in the registration section.
    Dim clearDGVCol As Boolean = True

    Private dtTableGrd As DataTable 'This variable is used to search data on DataGridView.

    '-------------------------------------------Configure FireSharp
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "DwZBui2w2YLamtMyzVAscnjXXtgU2fiGCDMftN4R",
        .BasePath = "https://crud-96b20-default-rtdb.firebaseio.com/"
        }

    Private client As IFirebaseClient
    '-------------------------------------------
    '-------------------------------------------Sub to change the Enabled status Of the ToolBox In it.
    Sub DisplayRegSave(Stat As Boolean)
        TBNome.Enabled = Stat
        TBValorPG.Enabled = Stat
        TBVencimento.Enabled = Stat
        TBObs.Enabled = Stat
        BtnClearAll.Enabled = Stat
    End Sub

    Sub DisplayRecLoad(Stat As Boolean)
        TBSearch.Enabled = Stat
        CBSearchBy.Enabled = Stat
        BtnEdit.Enabled = Stat
        BtnDelete.Enabled = Stat
        BtnRefresh.Enabled = Stat
        BtnClearSelection.Enabled = Stat
        DGVUserData.Enabled = Stat
    End Sub
    Sub ShowRecord()
        Try
            Dim dtTable As New DataTable
            dtTable.Columns.Add("ID")
            dtTable.Columns.Add("Nome")
            dtTable.Columns.Add("ValorPG")
            dtTable.Columns.Add("DtVencimento")
            dtTable.Columns.Add("Observacoes")
            dtTable.Columns.Add("Situação")

            '-------------------------------------------Conditions for deleting columns. This was executed only once.
            If clearDGVCol = True Then
                DGVUserData.Columns.Clear()
                clearDGVCol = False
            End If
            '-------------------------------------------

            Dim SRRecord = client.Get("Contas/") 'To load and hold Database in JSON file format.

            '-------------------------------------------To converts the specified JSON string to an object of type T.
            '-------------------------------------------For more information see here : 
            '-------------------------------------------https://docs.microsoft.com/en-us/dotnet/api/system.web.script.serialization.javascriptserializer.deserialize?view=netframework-4.8
            Dim myJsonTool As New JavaScriptSerializer
            Dim myDeserializedItems = myJsonTool.Deserialize(Of Dictionary(Of String, GerirContas))(SRRecord.Body)
            '-------------------------------------------

            '-------------------------------------------To enter a Database (in JSON file format that has been previously converted into an object form) into a Table.
            For Each dictItem As KeyValuePair(Of String, GerirContas) In myDeserializedItems
                dtTable.Rows.Add(dictItem.Value.ID, dictItem.Value.Nome, dictItem.Value.ValorPG, dictItem.Value.DtVencimento, dictItem.Value.Observações, dictItem.Value.Estado)
            Next
            '-------------------------------------------

            DGVUserData.DataSource = dtTable 'Gets or sets the data source that the DataGridView is displaying data for.
            dtTableGrd = dtTable 'Entering data from dtTable into dtTableGrd, dtTableGrd is used to find data and display it on DataGridView.

            '-------------------------------------------

            DGVUserData.Sort(DGVUserData.Columns(0), ListSortDirection.Ascending)

            LblTotalUser.Text = "Total de Contas: " & DGVUserData.RowCount


            DisplayRecLoad(True)

            DGVUserData.ClearSelection()
        Catch ex As Exception
            If ex.Message = "One or more errors occurred." Then
                MessageBox.Show("Não foi possivel conectar ao Firebase, Favor verificar conexão!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.Message = "Object reference not set to an instance of an object." Then
                Dim dtTable As New DataTable
                dtTable.Columns.Add("ID")
                dtTable.Columns.Add("Nome")
                dtTable.Columns.Add("ValorPG")
                dtTable.Columns.Add("DtVencimento")
                dtTable.Columns.Add("Observacoes")
                dtTable.Columns.Add("Situação")
                DGVUserData.DataSource = dtTable
                MessageBox.Show("Banco de dados não encontrado ou vazio.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


            DisplayRecLoad(True)
        End Try
    End Sub
    '-------------------------------------------

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim Menu As New F_Menu
        Menu.Fnome.Text = NomedoUsuario2
        Me.Hide()
        Menu.ShowDialog()
        Me.Close()
    End Sub

    Private Sub CONTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        DisplayRecLoad(False)
        ShowRecord()
        CBSearchBy.SelectedIndex = 0
        SomarPagamentos()
    End Sub

    Private Sub BtnCreateId_Click(sender As Object, e As EventArgs) Handles BtnCreateId.Click
        Try
            TBID.Text = "Aguarde..."

            Dim r As Random = New Random
            Dim num As Integer
            num = (r.Next(1, 99999))
            Dim IDresults As String = Strings.Right("00000" & num.ToString(), 5)

            Dim Check_ID = client.Get("Alunos/" + IDresults)

            '-------------------------------------------Conditions to check whether the ID has been used.
            If Check_ID.Body <> "null" Then
                MessageBox.Show("Id já está em uso favor criar outro, aperte o Botão GERAR ID!.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                TBID.Text = IDresults
            End If
            '-------------------------------------------
        Catch ex As Exception
            If ex.Message = "One or more errors occurred." Then
                TBID.Clear()
                MessageBox.Show("Não foi possivel conectar ao Firebase, Favor verificar conexão!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                TBID.Clear()
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If BtnSave.Text = "Cadastrar" Then 'Conditions for storing data to the database.
            If TBNome.Text = Nothing Then
                MessageBox.Show("Nome está em branco." & vbCrLf & "Por favor preenchar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If TBID.Text = Nothing Then
                MessageBox.Show("Id do aluno vazio." & vbCrLf & "Por favor preencha para continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If TBValorPG.Text = Nothing Then
                MessageBox.Show("ValorPG em branco." & vbCrLf & "Por favor preencha para continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If TBVencimento.Text = Nothing Then
                MessageBox.Show("Data de Pagamento  em branco." & vbCrLf & "Por favor preencha para continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Try

                DisplayRegSave(False)


                Dim PD As New GerirContas() With
                {
                .ID = TBID.Text,
                .Nome = TBNome.Text,
                .ValorPG = TBValorPG.Text,
                .DtVencimento = TBVencimento.Text,
                .Observações = TBObs.Text,
                .Estado = TBStatus.Text
                }

                Dim save = client.Set("Contas/" + TBID.Text, PD) 'To save data to Firebase Database.

                DisplayRegSave(True)
                'Calcular ValorPG adicionado e converter ComboBox Para inteiro
                Dim linha As DataGridViewRow
                Dim ValorPG As Double
                Dim ValorPGC As String
                Dim TxtVal As Double
                Dim TxtValInt As Integer
                Dim EqVal As Integer

                If TBValorPG.Text = "" Then
                    TBValorPG.Text = "0"
                End If
                EqVal = TBValorPG.Text
                TxtVal = TBValorPG.Text
                TxtValInt = CInt(TxtVal + EqVal - EqVal)

                For Each linha In DGVUserData.Rows
                    ValorPG = ValorPG + linha.Cells(3).Value
                Next
                ValorPGC = ValorPG + TxtValInt
                'Adiciona ValorPG Calculado no Firebase

                Dim PD2 As New RelatorioMensalidades() With
                 {
                .ContasPagas = ValorPGC
                }

                Dim update2 = client.Set("Relatorios/ContasPagas", PD2) 'To save data to Firebase Database.
                MessageBox.Show("Cadastrado com Sucesso!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                BtnClearAll_Click(sender, e)
                BtnRefresh_Click(sender, e)


            Catch ex As Exception
                If ex.Message = "One or more errors occurred." Then
                    MessageBox.Show("Não foi possivel conectar ao Firebase, Favor verificar conexão!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                DisplayRegSave(True)

            End Try

        Else 'Conditions for updating data to a database.

            If TBNome.Text = Nothing Then
                MessageBox.Show("Nome do aluno está vazio." & vbCrLf & "Por favor preencha para continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If TBID.Text = Nothing Then
                MessageBox.Show("Id do aluno vazio." & vbCrLf & "Por favor preencha para continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try

                DisplayRegSave(False)

                Dim PD As New GerirContas() With
                {
                .ID = TBID.Text,
                .Nome = TBNome.Text,
                .ValorPG = TBValorPG.Text,
                .DtVencimento = TBVencimento.Text,
                .Observações = TBObs.Text,
                .Estado = TBStatus.Text
                }

                Dim update = client.Update("Contas/" + TBID.Text, PD) 'To update data to Firebase Database.

                DisplayRegSave(True)

                'Calcular ValorPG adicionado e converter ComboBox Para inteiro
                Dim linha2 As DataGridViewRow
                Dim ValorPG2 As Double
                Dim ValorPGC2 As String
                Dim TxtVal2 As Double
                Dim TxtValInt2 As Integer
                If TBValorPG.Text = "" Then
                    TBValorPG.Text = "0"
                End If
                TxtVal2 = TBValorPG.Text
                TxtValInt2 = CInt(TxtVal2)

                For Each linha2 In DGVUserData.Rows
                    ValorPG = ValorPG + linha2.Cells(2).Value
                Next
                ValorPGC2 = ValorPG2 + TxtValInt2

                'Adiciona ValorPG Calculado no Firebase
                Dim PD3 As New RelatorioMensalidades() With
                {
                .ContasPagas = ValorPGC2
                }
                Dim update2 = client.Update("Relatorios/ContasPagas", PD3) 'To save data to Firebase Database.

                MessageBox.Show("Atualizado com Sucesso!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                BtnClearAll_Click(sender, e)
                BtnRefresh_Click(sender, e)


            Catch ex As Exception
                If ex.Message = "One or more errors occurred." Then
                    MessageBox.Show("Não foi possivel conectar ao Firebase, Favor verificar conexão!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                DisplayRegSave(True)

            End Try
        End If
        Me.BtnSave.Text = "Cadastrar"
        BtnClearAll_Click(sender, e)
        SomarPagamentos()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        DisplayRecLoad(False)
        ShowRecord()
    End Sub

    Private Sub BtnClearAll_Click(sender As Object, e As EventArgs) Handles BtnClearAll.Click
        Me.TBID.Text = ""
        Me.TBNome.Text = ""
        Me.TBValorPG.Text = ""
        Me.TBVencimento.Text = ""
        Me.TBStatus.Text = ""
        Me.TBObs.Text = ""

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If DGVUserData.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor selecione um aluno para editar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        '-------------------------------------------

        '-------------------------------------------Conditions to check whether there is more than one data selected on DataGridView.
        If DGVUserData.SelectedRows.Count > 1 Then
            MessageBox.Show("Você selecionou " & DGVUserData.SelectedRows.Count & " linhas na tabela." & vbCrLf & "só é permitido uma alteração por vez.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        '-------------------------------------------

        If DGVUserData.SelectedRows.Count = 1 Then
            Me.TBID.Text = DGVUserData.SelectedRows(0).Cells("ID").Value.ToString
            Me.TBNome.Text = DGVUserData.SelectedRows(0).Cells("Nome").Value.ToString
            Me.TBValorPG.Text = DGVUserData.SelectedRows(0).Cells("ValorPG").Value.ToString
            Me.TBVencimento.Text = DGVUserData.SelectedRows(0).Cells("DtVencimento").Value.ToString
            Me.TBStatus.Text = DGVUserData.SelectedRows(0).Cells("Situação").Value.ToString
            Me.TBObs.Text = DGVUserData.SelectedRows(0).Cells("Observacoes").Value.ToString
            Me.BtnSave.Text = "Atualizar"
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        '-------------------------------------------Conditions for deleting all data in the database.
        If AllCellsSelected(DGVUserData) = True Then
            Try
                If MsgBox("Você deseja realmente excluir?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

                DisplayRecLoad(False)

                Dim deleteAll = client.Delete("Contas") 'To delete data in the Firebase Database

                MessageBox.Show("Exclusão realizada com sucesso.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                DisplayRecLoad(True)

                BtnRefresh_Click(sender, e)
                Return
            Catch ex As Exception
                If ex.Message = "One or more errors occurred." Then
                    MessageBox.Show("Não foi possível conectar ao firebase, verifique a conexão!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                DisplayRecLoad(True)
            End Try
        End If
        '-------------------------------------------

        '-------------------------------------------Conditions for deleting one data or several data in the Database.
        Try
            If DGVUserData.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor selecione uma linha para deletar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If MsgBox("Você deseja realmente excluir?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

            DisplayRecLoad(False)

            For Each row As DataGridViewRow In DGVUserData.SelectedRows
                If row.Selected = True Then
                    Dim delete = client.Delete("Contas/" & row.DataBoundItem(0).ToString)
                End If
            Next

            MessageBox.Show("Exclusão realizada com sucesso!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DisplayRecLoad(True)

            BtnRefresh_Click(sender, e)
        Catch ex As Exception
            If ex.Message = "One or more errors occurred." Then
                MessageBox.Show("Não foi possível conectar ao firebase, verifique a conexão!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            DisplayRecLoad(True)
        End Try
        '-------------------------------------------
    End Sub

    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        If dgv.RowCount = 0 Then
            AllCellsSelected = False
            Return AllCellsSelected
        End If
        AllCellsSelected = (dgv.SelectedCells.Count = (dgv.RowCount * dgv.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
        If dgv.RowCount = 1 Then
            AllCellsSelected = False
        End If
    End Function

    Private Sub BtnClearSelection_Click(sender As Object, e As EventArgs) Handles BtnClearSelection.Click
        DGVUserData.ClearSelection()
    End Sub
    Private Sub TBSearch_TextChanged(sender As Object, e As EventArgs) Handles TBSearch.TextChanged
        dtTableGrd.DefaultView.RowFilter = CBSearchBy.Text & " Like '" & TBSearch.Text & "%'" 'To search for data on the DataGridView
        DGVUserData.ClearSelection()
        SomarPagamentos()
    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        BtnEdit_Click(sender, e)
    End Sub

    Private Sub DeletarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletarToolStripMenuItem.Click
        BtnDelete_Click(sender, e)
    End Sub

    Private Sub SelecionarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarTodosToolStripMenuItem.Click
        DGVUserData.SelectAll()
    End Sub

    Private Sub LimparSeleçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparSeleçãoToolStripMenuItem.Click
        BtnClearSelection_Click(sender, e)
    End Sub

    Private Sub AtualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtualizarToolStripMenuItem.Click
        DisplayRecLoad(False)
        ShowRecord()
    End Sub

    Public Sub SomarPagamentos()

        Dim linha As DataGridViewRow
        Dim ValorPG As Double

        For Each linha In DGVUserData.Rows
            ValorPG = ValorPG + linha.Cells(2).Value
        Next
        LblValPag.Text = "ValorPG Total: " & FormatCurrency(ValorPG)
    End Sub

    Private Sub CONTAS_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub CONTAS_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class