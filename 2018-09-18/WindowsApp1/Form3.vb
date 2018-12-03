Public Class Form3
    Private Sub Finish_Click(sender As Object, e As EventArgs) Handles Finish.Click
        Me.Close()
        Form2.Close()
        Form1.Close()
    End Sub
End Class