Public Class Form1
    Private Sub Calculate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Calculate.Click
        If RadioButton2.Checked = True Then
            Total.Text = FirstName.Text & LastName.Text &
                vbCrLf & "Total Cost: $" & Val((Mint.Text * 5) + (ChocolateChip.Text * 7) + (Oreo.Text * 4) + (CreamFilled.Text * 10) + 1)
        Else
            Total.Text = FirstName.Text & LastName.Text &
                vbCrLf & "Total Cost: $" & Val((Mint.Text * 5) + (ChocolateChip.Text * 7) + (Oreo.Text * 4) + (CreamFilled.Text * 10))
        End If
    End Sub
End Class
