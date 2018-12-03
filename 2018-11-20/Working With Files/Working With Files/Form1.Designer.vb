<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileItem1 = New System.Windows.Forms.TextBox()
        Me.FileItem2 = New System.Windows.Forms.TextBox()
        Me.FilePath = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(495, 521)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 58)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Display File Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(878, 521)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 58)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Delete File Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(647, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(257, 76)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Add Items to File"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Type in path to create your file"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Item to Add to File"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Second Item to Add to File"
        '
        'FileItem1
        '
        Me.FileItem1.Location = New System.Drawing.Point(581, 105)
        Me.FileItem1.Name = "FileItem1"
        Me.FileItem1.Size = New System.Drawing.Size(885, 31)
        Me.FileItem1.TabIndex = 3
        '
        'FileItem2
        '
        Me.FileItem2.Location = New System.Drawing.Point(581, 157)
        Me.FileItem2.Name = "FileItem2"
        Me.FileItem2.Size = New System.Drawing.Size(885, 31)
        Me.FileItem2.TabIndex = 3
        '
        'FilePath
        '
        Me.FilePath.Location = New System.Drawing.Point(581, 55)
        Me.FilePath.Name = "FilePath"
        Me.FilePath.Size = New System.Drawing.Size(885, 31)
        Me.FilePath.TabIndex = 3
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(243, 619)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1223, 340)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1613, 1013)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FileItem2)
        Me.Controls.Add(Me.FileItem1)
        Me.Controls.Add(Me.FilePath)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FileItem1 As TextBox
    Friend WithEvents FileItem2 As TextBox
    Friend WithEvents FilePath As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
