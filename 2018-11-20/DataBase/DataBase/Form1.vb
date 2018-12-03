Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3DataSet.Testing_DataBase' table. You can move, or remove it, as needed.
        Me.Testing_DataBaseTableAdapter.Fill(Me.Database3DataSet.Testing_DataBase)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim curItem As String = ListBox1.SelectedItem.ToString()
        TextBox1.Text = curItem
    End Sub
End Class
