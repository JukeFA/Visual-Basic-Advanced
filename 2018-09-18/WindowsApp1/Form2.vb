Public Class Form2
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        If ComboBox1.SelectedItem = "Kot" And ComboBox2.SelectedItem = "Pies" And ComboBox3.SelectedItem = "Królik" And ComboBox4.SelectedItem = "Ptak" Then
            Form3.Show()
            Me.Hide()
        Else
            MessageBox.Show("One of your answers is incrorrect, Please Try Again.")
        End If
    End Sub
End Class