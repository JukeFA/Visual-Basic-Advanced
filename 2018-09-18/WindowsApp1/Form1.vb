Public Class Form1
    Private Sub Submit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Submit.Click
        If ComboBox1.SelectedItem = "A Woman" And ComboBox2.SelectedItem = "A Man" And ComboBox3.SelectedItem = "A Boy" And ComboBox4.SelectedItem = "A Girl" Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("One of your answers is incrorrect, Please Try Again.")
        End If
    End Sub
End Class
