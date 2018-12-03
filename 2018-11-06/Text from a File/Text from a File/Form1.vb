Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim FILE_NAME As String = "C:\Users\lucky\Desktop\File.txt"
        Dim TextLine As String
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            TextLine = NewMethod1(TextLine, objReader)
            TextBox1.Text = TextLine
        Else
            MsgBox("File Does Not Exist")
        End If

    End Sub

    Private Shared Function NewMethod1(TextLine As String, objReader As IO.StreamReader) As String
        Do While objReader.Peek() <> -1
            TextLine = NewMethod(TextLine:=TextLine, objReader:=objReader)
        Loop

        Return TextLine
    End Function

    Private Shared Function NewMethod(TextLine As String, objReader As IO.StreamReader) As String
        TextLine = TextLine & GetObjReader(objReader).ReadLine() & vbNewLine
        Return TextLine
    End Function

    Private Shared Function GetObjReader(objReader As IO.StreamReader) As IO.StreamReader
        Return objReader
    End Function
End Class
