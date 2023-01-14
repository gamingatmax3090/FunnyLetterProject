Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub

    Public Sub Generate_Click(sender As Object, e As EventArgs) Handles Generate.Click
        Dim originalText As String = TextBox1.Text
        Dim modifiedText As String = ""
        Dim rand As New Random()

        For Each c As Char In originalText
            If Char.IsLetter(c) Then
                If rand.Next(10) <= 4 Then
                    modifiedText += Char.ToUpper(c)
                Else
                    modifiedText += Char.ToLower(c)
                End If
            Else
                modifiedText += c
            End If
        Next
        TextBox1.Text = modifiedText
        btnCopy.Visible = True

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub

End Class
