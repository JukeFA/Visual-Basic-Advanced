Public Class Form1
    Private Sub Submit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Submit.Click
        If ((TextBox1.Text * TextBox19.Text) + (TextBox2.Text * TextBox20.Text) + (TextBox3.Text * TextBox21.Text) + (TextBox4.Text * TextBox22.Text) + (TextBox5.Text * TextBox23.Text) + (TextBox6.Text * TextBox24.Text) + (TextBox7.Text * TextBox25.Text) + (TextBox8.Text * TextBox26.Text) + (TextBox9.Text * TextBox27.Text) + (TextBox10.Text * TextBox28.Text) + (TextBox11.Text * TextBox29.Text) + (TextBox12.Text * TextBox30.Text) + (TextBox13.Text * TextBox31.Text) + (TextBox14.Text * TextBox32.Text) + (TextBox15.Text * TextBox33.Text) + (TextBox16.Text * TextBox34.Text) + (TextBox17.Text * TextBox35.Text) + (TextBox18.Text * TextBox36.Text)) <= 50 Then
            RichTextBox1.Text = "You are within your budget, Be sure that you picked up the important items."
        Else
            RichTextBox1.Text = "You are not within your budget, you went over by $" & (((TextBox1.Text * TextBox19.Text) + (TextBox2.Text * TextBox20.Text) + (TextBox3.Text * TextBox21.Text) + (TextBox4.Text * TextBox22.Text) + (TextBox5.Text * TextBox23.Text) + (TextBox6.Text * TextBox24.Text) + (TextBox7.Text * TextBox25.Text) + (TextBox8.Text * TextBox26.Text) + (TextBox9.Text * TextBox27.Text) + (TextBox10.Text * TextBox28.Text) + (TextBox11.Text * TextBox29.Text) + (TextBox12.Text * TextBox30.Text) + (TextBox13.Text * TextBox31.Text) + (TextBox14.Text * TextBox32.Text) + (TextBox15.Text * TextBox33.Text) + (TextBox16.Text * TextBox34.Text) + (TextBox17.Text * TextBox35.Text) + (TextBox18.Text * TextBox36.Text)) - 50) & ", try cutting out candy or other unnecessary itmes."
        End If
    End Sub
End Class
