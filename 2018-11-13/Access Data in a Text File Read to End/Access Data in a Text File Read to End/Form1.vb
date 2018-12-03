Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FILE_NAME As String = "C:\Users\Lucky\Desktop\File.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            RichTextBox1.Text = objReader.ReadToEnd
            objReader.Close()
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub
End Class
