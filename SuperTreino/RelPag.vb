'-------------------------------------------Importing FireSharp. Make sure you have FireSharp installed on this project.
'-------------------------------------------For more information see here : https://github.com/ziyasal/FireSharp
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
'-------------------------------------------

Imports System.Web.Script.Serialization '(Importing System.Web.Script.Serialization) This is used to read and convert JSON strings.
Imports System.ComponentModel '(Importing System.ComponentModel) This is used to sort data on DataGridView.
Imports System.IO '(Importing System.IO) This is used for ImageToBase64 Public Functions and Base64ToImage Public Functions.

Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text

Public Class RelPag
    Dim ValorPGdt As String
    Dim SubTitulo As String
    Public Property StringStatus As String
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

    Sub ShowRecord()
        Try
            Dim dtTable As New DataTable
            dtTable.Columns.Add("ID")
            dtTable.Columns.Add("Nome")
            dtTable.Columns.Add("Plano")
            dtTable.Columns.Add("ValorPG")
            dtTable.Columns.Add("dtPg")
            dtTable.Columns.Add("Telefone")
            dtTable.Columns.Add("Observacoes")
            dtTable.Columns.Add("Situação")

            '-------------------------------------------Conditions for deleting columns. This was executed only once.
            If clearDGVCol = True Then
                DGVRelatorio.Columns.Clear()
                clearDGVCol = False
            End If
            '-------------------------------------------

            Dim SRRecord = client.Get("GerirAlunos/") 'To load and hold Database in JSON file format.

            '-------------------------------------------To converts the specified JSON string to an object of type T.
            '-------------------------------------------For more information see here : 
            '-------------------------------------------https://docs.microsoft.com/en-us/dotnet/api/system.web.script.serialization.javascriptserializer.deserialize?view=netframework-4.8
            Dim myJsonTool As New JavaScriptSerializer
            Dim myDeserializedItems = myJsonTool.Deserialize(Of Dictionary(Of String, Alunos))(SRRecord.Body)
            '-------------------------------------------

            '-------------------------------------------To enter a Database (in JSON file format that has been previously converted into an object form) into a Table.
            For Each dictItem As KeyValuePair(Of String, Alunos) In myDeserializedItems
                dtTable.Rows.Add(dictItem.Value.id, dictItem.Value.nome, dictItem.Value.plano, dictItem.Value.valorPG, dictItem.Value.dtPg, dictItem.Value.telefone, dictItem.Value.observacoes, dictItem.Value.Estado)
            Next
            '-------------------------------------------

            DGVRelatorio.DataSource = dtTable 'Gets or sets the data source that the DataGridView is displaying data for.
            dtTableGrd = dtTable 'Entering data from dtTable into dtTableGrd, dtTableGrd is used to find data and display it on DataGridView.

            '-------------------------------------------

            DGVRelatorio.Sort(DGVRelatorio.Columns(0), ListSortDirection.Ascending)


            DGVRelatorio.ClearSelection()
        Catch ex As Exception
            If ex.Message = "One or more errors occurred." Then
                MessageBox.Show("Não foi possivel conectar ao Firebase, Favor verificar conexão!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.Message = "Object reference not set to an instance of an object." Then
                Dim dtTable As New DataTable
                dtTable.Columns.Add("ID")
                dtTable.Columns.Add("Nome")
                dtTable.Columns.Add("Plano")
                dtTable.Columns.Add("ValorPG")
                dtTable.Columns.Add("dtPg")
                dtTable.Columns.Add("Telefone")
                dtTable.Columns.Add("Observacoes")
                dtTable.Columns.Add("Situação")
                DGVRelatorio.DataSource = dtTable
                MessageBox.Show("Banco de dados não encontrado ou vazio.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Try
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
    End Sub

    Private Sub RelPag_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub RelPag_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Public Sub SomarPagamentos()

        Dim linha As DataGridViewRow
        Dim ValorPG As Double

        For Each linha In DGVRelatorio.Rows
            ValorPG = ValorPG + linha.Cells(3).Value
        Next
        LblValPag.Text = "ValorPG Total: " & FormatCurrency(ValorPG)
        Dim val As String
        val = LblValPag.Text

    End Sub
    Private Sub RelPag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LblTotalUser.Text = "Total de Alunos: " & DGVRelatorio.RowCount
        ShowRecord()
        CBSearchBy.SelectedIndex = 0
        SomarPagamentos()
    End Sub

    Private Sub LblPdf_Click(sender As Object, e As EventArgs) Handles LblPdf.Click
        ValorPGdt = LblValPag.Text
        SubTitulo = CBSearchBy.Text
        If CBSearchBy.Text = "" Then
            StringStatus = ""

        ElseIf CBSearchBy.Text = "Pendente" Then
            StringStatus = "Pendentes"
        ElseIf CBSearchBy.Text = "Pago" Then
            StringStatus = "Pagas "
        End If

        Dim sfd As New SaveFileDialog With {.Filter = "Arquivos PDF (*.pdf) | *.pdf"}
        If sfd.ShowDialog = 1 Then
            If sfd.FileName = "" Then
                MsgBox("Por favor escolher nome do relatório para continuar")
            Else
                Dim paragrafo As New Paragraph
                Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 80, 20)
                Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))

                Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
                Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                wri.PageEvent = New HeaderFooter

                doc.Open()


                Dim pdfTable As New PdfPTable(8)
                Dim pdfcell As PdfPCell = Nothing
                pdfTable.TotalWidth = 550.0F
                pdfTable.LockedWidth = True
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.HeaderRows = 1
                '-------------------------------------------------- CONSERTAR
                '  Titulo
                Dim fsubtitulo As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
                Dim Estado As String
                Estado = Label2.Text
                Dim TxtSubtitulo As New PdfPTable(1)
                TxtSubtitulo.TotalWidth = doc.PageSize.Width
                TxtSubtitulo.DefaultCell.Border = 0
                pdfcell = New PdfPCell(New Paragraph(Estado, fsubtitulo))
                pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
                pdfcell.Border = 0
                TxtSubtitulo.AddCell(pdfcell)
                TxtSubtitulo.WriteSelectedRows(0, -1, doc.LeftMargin, doc.GetTop(doc.TopMargin) + 105, wri.DirectContent)


                Dim widths As Single() = New Single() {0.3F, 0.8F, 0.6F, 0.4F, 0.5F, 0.4F, 0.8F, 0.4F}
                pdfTable.SetWidths(widths)
                ' pdfTable.HorizontalAlignment = 1
                pdfTable.SpacingBefore = 4.0F



                pdfcell = New PdfPCell(New Paragraph(New Chunk("ID", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph(New Chunk("NOME", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph(New Chunk("PLANO", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph(New Chunk("ValorPG", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph(New Chunk("PAGAMENTO", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph(New Chunk("TELEFONE", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)


                pdfcell = New PdfPCell(New Paragraph(New Chunk("OBSERVAÇÕES", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph(New Chunk("SITUAÇÃO", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)


                Dim dt As DataTable = getDataTable()

                For i = 0 To dt.Rows.Count - 1
                    For Colums = 0 To dt.Columns.Count - 1
                        pdfcell = New PdfPCell(New Paragraph(dt.Rows(i)(Colums).ToString, font12Normal))
                        pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                        pdfcell.MinimumHeight = 18
                        pdfcell.PaddingLeft = 5.0F
                        pdfTable.AddCell(pdfcell)
                    Next


                Next

                '  ValorPG Total
                Dim fnormal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)

                Dim pdfValTotal As New PdfPTable(1)
                pdfValTotal.TotalWidth = doc.PageSize.Width
                pdfValTotal.DefaultCell.Border = 0
                pdfcell = New PdfPCell(New Paragraph(ValorPGdt, fnormal))
                pdfcell.HorizontalAlignment = Element.ALIGN_RIGHT
                pdfcell.Border = 0
                pdfValTotal.AddCell(pdfcell)

                pdfValTotal.WriteSelectedRows(0, -1, doc.RightMargin - 80, doc.GetBottom(doc.BottomMargin), wri.DirectContent)

                ' Total de Usuários
                Dim AlCount As String
                AlCount = LblTotalUser.Text
                Dim AlunosTotal As New PdfPTable(1)
                AlunosTotal.TotalWidth = doc.PageSize.Width
                AlunosTotal.DefaultCell.Border = 0
                pdfcell = New PdfPCell(New Paragraph(AlCount, fnormal))
                pdfcell.HorizontalAlignment = Element.ALIGN_RIGHT
                pdfcell.Border = 0
                AlunosTotal.AddCell(pdfcell)

                AlunosTotal.WriteSelectedRows(0, -1, doc.RightMargin - 80, doc.GetBottom(doc.BottomMargin + 10), wri.DirectContent)


                doc.Add(pdfTable)
                doc.Close()
                MsgBox("Relatório Gerado com Sucesso")
                Process.Start(sfd.FileName)


            End If


        End If


    End Sub
    Class HeaderFooter
        Inherits PdfPageEventHelper
        Public Overrides Sub OnEndPage(writer As PdfWriter, document As Document)
            Dim RelPag As New RelPag


            Dim sfd As New SaveFileDialog With {.Filter = "Arquivos PDF (*.pdf) | *.pdf"}
            Dim TxtTitulo As String
            TxtTitulo = "RELATÓRIO DE MENSALIDADES " + RelPag.StringStatus
            Dim TxtRodape As String
            TxtRodape = "Relatório Gerado no Dia: "


            Dim paragrafo As New Paragraph
            Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 80, 20)
            Dim fontRodape As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8.0F, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY)
            Dim ftitulo As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)


            Dim pdfcell As PdfPCell = Nothing
            Dim pdfheader As New PdfPTable(1)

            pdfheader.TotalWidth = document.PageSize.Width
            pdfheader.DefaultCell.Border = 0
            pdfcell = New PdfPCell(New Paragraph(TxtTitulo, ftitulo))
            pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
            pdfcell.Border = 0
            pdfheader.AddCell(pdfcell)
            pdfheader.WriteSelectedRows(0, -1, document.LeftMargin, document.GetTop(document.TopMargin) + 120, writer.DirectContent)

            Dim pdfrodape As New PdfPTable(1)
            pdfrodape.TotalWidth = document.PageSize.Width
            pdfrodape.DefaultCell.Border = 0
            pdfcell = New PdfPCell(New Paragraph(TxtRodape & Date.Now.ToString("dd-MM-yyyy"), fontRodape))
            pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
            pdfcell.Border = 0
            pdfrodape.AddCell(pdfcell)

            pdfrodape.WriteSelectedRows(0, -1, document.LeftMargin + 5, document.GetBottom(document.BottomMargin - 5), writer.DirectContent)


            doc.Open()
        End Sub
    End Class

    Private Function getDataTable() As DataTable
        Dim dataTable As New DataTable("dt")
        Dim coluna1 As New DataColumn(DGVRelatorio.Columns(0).HeaderText.ToString, GetType(String))
        Dim coluna2 As New DataColumn(DGVRelatorio.Columns(1).HeaderText.ToString, GetType(String))
        Dim coluna3 As New DataColumn(DGVRelatorio.Columns(2).HeaderText.ToString, GetType(String))
        Dim coluna4 As New DataColumn(DGVRelatorio.Columns(3).HeaderText.ToString, GetType(String))
        Dim coluna5 As New DataColumn(DGVRelatorio.Columns(4).HeaderText.ToString, GetType(String))
        Dim coluna6 As New DataColumn(DGVRelatorio.Columns(5).HeaderText.ToString, GetType(String))
        Dim coluna7 As New DataColumn(DGVRelatorio.Columns(6).HeaderText.ToString, GetType(String))
        Dim coluna8 As New DataColumn(DGVRelatorio.Columns(7).HeaderText.ToString, GetType(String))

        dataTable.Columns.Add(coluna1)
        dataTable.Columns.Add(coluna2)
        dataTable.Columns.Add(coluna3)
        dataTable.Columns.Add(coluna4)
        dataTable.Columns.Add(coluna5)
        dataTable.Columns.Add(coluna6)
        dataTable.Columns.Add(coluna7)
        dataTable.Columns.Add(coluna8)

        Dim dataRow As DataRow
        For i = 0 To DGVRelatorio.Rows.Count - 1
            dataRow = dataTable.NewRow
            dataRow(coluna1) = DGVRelatorio.Rows(i).Cells(0).Value.ToString
            dataRow(coluna2) = DGVRelatorio.Rows(i).Cells(1).Value.ToString
            dataRow(coluna3) = DGVRelatorio.Rows(i).Cells(2).Value.ToString
            dataRow(coluna4) = DGVRelatorio.Rows(i).Cells(3).Value.ToString
            dataRow(coluna5) = DGVRelatorio.Rows(i).Cells(4).Value.ToString
            dataRow(coluna6) = DGVRelatorio.Rows(i).Cells(5).Value.ToString
            dataRow(coluna7) = DGVRelatorio.Rows(i).Cells(6).Value.ToString
            dataRow(coluna8) = DGVRelatorio.Rows(i).Cells(7).Value.ToString

            dataTable.Rows.Add(dataRow)
        Next

        dataTable.AcceptChanges()
        Return dataTable

    End Function

    Private Sub CBSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSearchBy.SelectedIndexChanged
        dtTableGrd.DefaultView.RowFilter = " Situação Like '" & CBSearchBy.Text & "%'" 'To search for data on the DataGridView
        LblTotalUser.Text = "Total de Alunos: " & DGVRelatorio.RowCount
        Label2.Text = CBSearchBy.Text
        'Label2.Top = (Me.Height - Label2.Height) 
        Label2.Left = (Me.Width - Label2.Width) / 2
        SubTitulo = Label2.Text.ToString
        DGVRelatorio.ClearSelection()
        SomarPagamentos()
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