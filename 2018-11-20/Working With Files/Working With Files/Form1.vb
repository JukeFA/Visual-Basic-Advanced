Public Class Form1
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Dim filename As String = FilePath.Text
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(filename, True)
        file.WriteLine(FileItem1.Text & vbCrLf & FileItem2.Text)
        file.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim FILE_NAME As String = FilePath.Text
        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            RichTextBox1.Text = objReader.ReadToEnd
            objReader.Close()
        Else
            MsgBox("File does Not Exist")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        IO.File.WriteAllText(FilePath, "")
    End Sub
End Class
