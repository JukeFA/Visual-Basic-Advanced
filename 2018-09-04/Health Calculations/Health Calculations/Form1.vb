Public Class Form1

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = "You have consumed " & Val((Val(Fat.Text) * 9) + ((Val(Carbo.Text) + Val(Protein.Text)) * 4)) & " calories."
    End Sub
End Class
