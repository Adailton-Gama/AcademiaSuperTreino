Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text

Public Class Relatorio
    Private Captura As Bitmap
    Private x, y As Integer
    Private newpoint As Point
    Dim ValorPGdt As String
    Dim SubTitulo As String
    Public Property StringStatus As String
    Public Property NomedoUsuario2 As String
    Public Sub SomarPagamentos()

        Dim linha As DataGridViewRow
        Dim ValorPG As Double

        For Each linha In DGVRelatorio.Rows
            ValorPG = ValorPG + linha.Cells(3).Value
        Next

        LblValPag.Text = "ValorPG Total Mensal: " & FormatCurrency(ValorPG)

        LblTotalUser.Text = "Total de Alunos: " & DGVRelatorio.RowCount
    End Sub
    Private Sub Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SomarPagamentos()
        DGVRelatorio.Columns.Remove(DGVRelatorio.Columns(0))
        DGVRelatorio.Columns.Remove(DGVRelatorio.Columns(5))


    End Sub

    Private Sub LblPdf_Click(sender As Object, e As EventArgs) Handles LblPdf.Click
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
                

                Dim pdfTable As New PdfPTable(5)
                Dim pdfcell As PdfPCell = Nothing

                pdfTable.TotalWidth = 550.0F
                pdfTable.LockedWidth = True
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER
                pdfTable.HeaderRows = 1


                Dim widths As Single() = New Single() {1.0F, 1.0F, 1.0F, 1.0F, 1.0F}
                pdfTable.SetWidths(widths)
                ' pdfTable.HorizontalAlignment = 1
                pdfTable.SpacingBefore = 2.0F



                pdfcell = New PdfPCell(New Paragraph(New Chunk("Nome", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph(New Chunk("Plano", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph(New Chunk("ValorPG", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph(New Chunk("Pagamento", font12Bold)))
                pdfcell.HorizontalAlignment = HorizontalAlignment.Left
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph(New Chunk("Telefone", font12Bold)))
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
                ValorPGdt = LblValPag.Text
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
                Process.Start(sfd.FileName)


            End If

            MsgBox("Relatório Gerado com Sucesso")
            End If


    End Sub
    Class HeaderFooter
        Inherits PdfPageEventHelper
        Public Overrides Sub OnEndPage(writer As PdfWriter, document As Document)
            Dim sfd As New SaveFileDialog With {.Filter = "Arquivos PDF (*.pdf) | *.pdf"}
            Dim TxtTitulo As String
            TxtTitulo = "RELATÓRIO DE ALUNOS MATRICULADOS "
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

            pdfrodape.WriteSelectedRows(0, -1, document.LeftMargin + 5, document.GetBottom(document.BottomMargin), writer.DirectContent)

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
            'Dim coluna6 As New DataColumn(DGVRelatorio.Columns(5).HeaderText.ToString, GetType(String))

            dataTable.Columns.Add(coluna1)
            dataTable.Columns.Add(coluna2)
            dataTable.Columns.Add(coluna3)
            dataTable.Columns.Add(coluna4)
            dataTable.Columns.Add(coluna5)
            'dataTable.Columns.Add(coluna6)

            Dim dataRow As DataRow
            For i = 0 To DGVRelatorio.Rows.Count - 1
                dataRow = dataTable.NewRow
                dataRow(coluna1) = DGVRelatorio.Rows(i).Cells(0).Value.ToString
                dataRow(coluna2) = DGVRelatorio.Rows(i).Cells(1).Value.ToString
                dataRow(coluna3) = DGVRelatorio.Rows(i).Cells(2).Value.ToString
                dataRow(coluna4) = DGVRelatorio.Rows(i).Cells(3).Value.ToString
                dataRow(coluna5) = DGVRelatorio.Rows(i).Cells(4).Value.ToString
                'dataRow(DGVRelatorio.Columns(5).HeaderText.ToString) = DGVRelatorio.Rows(i).Cells(5).Value.ToString
                dataTable.Rows.Add(dataRow)
            Next

            dataTable.AcceptChanges()
            Return dataTable

        End Function
        Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
            Me.Hide()
        End Sub

        Private Sub Relatorio_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
            x = Control.MousePosition.X - Me.Location.X
            y = Control.MousePosition.Y - Me.Location.Y
        End Sub

        Private Sub Relatorio_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
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