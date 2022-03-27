'-------------------------------------------Importing FireSharp. Make sure you have FireSharp installed on this project.
'-------------------------------------------For more information see here : https://github.com/ziyasal/FireSharp
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
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
Public Class RelGeral

    Public Property NomedoUsuario2 As String
    Private x, y As Integer
    Private newpoint As Point


    '-------------------------------------------Configure FireSharp
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "DwZBui2w2YLamtMyzVAscnjXXtgU2fiGCDMftN4R",
        .BasePath = "https://crud-96b20-default-rtdb.firebaseio.com/"
        }

    Private client As IFirebaseClient



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim Menu As New F_Menu
        Menu.Fnome.Text = NomedoUsuario2
        Me.Hide()
        Menu.ShowDialog()
        Me.Close()
    End Sub

    Private Sub RelGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        LiveCall()
    End Sub

    Private Async Sub LiveCall()
        While True
            Await Threading.Tasks.Task.Delay(600)
            Dim res As FirebaseResponse = Await client.GetAsync("Relatorios/Mensalidade")
            Dim data As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(res.Body.ToString())
            UdtMens(data)

            Dim res2 As FirebaseResponse = Await client.GetAsync("Relatorios/DiariasPagas")
            Dim data2 As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(res.Body.ToString())
            UdtDiarias(data2)

            Dim res3 As FirebaseResponse = Await client.GetAsync("Relatorios/ContasPagas")
            Dim data3 As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(res.Body.ToString())
            UdtContas(data3)
        End While
    End Sub

    Private Sub UdtMens(ByVal records As Dictionary(Of String, String))

        'lblcontas.Text = records.ElementAt(0).Value & vbLf
        'lbldiarias.Text = records.ElementAt(1).Value & vbLf
        LblMensa.Text = records.ElementAt(3).Value & vbLf

        '----------------------------------------- Converter para número Mensalidades
        Dim ValorPG As Double
        Dim ValorPGC As String
        Dim TxtVal As Double
        Dim TxtValInt1 As Integer
        If LblMensa.Text = "" Then
            LblMensa.Text = "0"
        End If
        TxtVal = LblMensa.Text
        TxtValInt1 = CInt(TxtVal)
        '----------------------------------------- Converter para número Diarias
        Dim ValorPG2 As Double
        Dim ValorPGC2 As String
        Dim TxtVal2 As Double
        Dim TxtValInt2 As Integer
        If lbldiarias.Text = "" Then
            lbldiarias.Text = "0"
        End If
        TxtVal2 = lbldiarias.Text
        TxtValInt2 = CInt(TxtVal2)
        '----------------------------------------- Converter para número Diarias
        Dim ValorPG3 As Double
        Dim ValorPGC3 As String
        Dim TxtVal3 As Double
        Dim TxtValInt3 As Integer
        If lblcontas.Text = "" Then
            lblcontas.Text = "0"
        End If
        TxtVal3 = lblcontas.Text
        TxtValInt3 = CInt(TxtVal3)

        Dim total As Integer
        total = TxtValInt1 + TxtValInt2 - TxtValInt3
        lblsaldo.Text = FormatCurrency(total)
        lblcontas.Text = FormatCurrency(TxtValInt3)
        lbldiarias.Text = FormatCurrency(TxtValInt2)
        LblMensa.Text = FormatCurrency(TxtValInt1)

    End Sub
    Private Sub UdtDiarias(ByVal records As Dictionary(Of String, String))

        ' lblcontas.Text = records.ElementAt(0).Value & vbLf
        lbldiarias.Text = records.ElementAt(1).Value & vbLf
        ' LblMensa.Text = records.ElementAt(3).Value & vbLf

        '----------------------------------------- Converter para número Diarias
        Dim ValorPG3 As Double
        Dim ValorPGC3 As String
        Dim TxtVal3 As Double
        Dim TxtValInt3 As Integer
        If lblcontas.Text = "" Then
            lblcontas.Text = "0"
        End If
        TxtVal3 = lblcontas.Text
        TxtValInt3 = CInt(TxtVal3)


    End Sub
    Private Sub UdtContas(ByVal records As Dictionary(Of String, String))

        lblcontas.Text = records.ElementAt(0).Value & vbLf
        ' lbldiarias.Text = records.ElementAt(1).Value & vbLf
        ' LblMensa.Text = records.ElementAt(3).Value & vbLf

        '----------------------------------------- Converter para número Mensalidades

        Dim TxtVal As Double
        Dim TxtValInt1 As Integer
        If LblMensa.Text = "" Then
            LblMensa.Text = "0"
        End If
        TxtVal = LblMensa.Text
        TxtValInt1 = CInt(TxtVal)
        '----------------------------------------- Converter para número Diarias
        Dim TxtVal2 As Double
        Dim TxtValInt2 As Integer
        If lbldiarias.Text = "" Then
            lbldiarias.Text = "0"
        End If
        TxtVal2 = lbldiarias.Text
        TxtValInt2 = CInt(TxtVal2)
        '----------------------------------------- Converter para número Diarias

        Dim TxtVal3 As Double
        Dim TxtValInt3 As Integer
        If lblcontas.Text = "" Then
            lblcontas.Text = "0"
        End If
        TxtVal3 = lblcontas.Text
        TxtValInt3 = CInt(TxtVal3)

        Dim total As Integer
        total = TxtValInt1 + TxtValInt2 - TxtValInt3
        lblsaldo.Text = FormatCurrency(total)
        lblcontas.Text = FormatCurrency(TxtValInt3)
        lbldiarias.Text = FormatCurrency(TxtValInt2)
        LblMensa.Text = FormatCurrency(TxtValInt1)

    End Sub
End Class