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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mint = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CreamFilled = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Oreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChocolateChip = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Test123 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Test123.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Girl Scouts Reciept Calculator"
        '
        'Mint
        '
        Me.Mint.Location = New System.Drawing.Point(127, 23)
        Me.Mint.Name = "Mint"
        Me.Mint.Size = New System.Drawing.Size(100, 20)
        Me.Mint.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mint"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CreamFilled)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Oreo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ChocolateChip)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Mint)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cookies"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Cream Filled"
        '
        'CreamFilled
        '
        Me.CreamFilled.Location = New System.Drawing.Point(127, 122)
        Me.CreamFilled.Name = "CreamFilled"
        Me.CreamFilled.Size = New System.Drawing.Size(100, 20)
        Me.CreamFilled.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Oreo"
        '
        'Oreo
        '
        Me.Oreo.Location = New System.Drawing.Point(127, 89)
        Me.Oreo.Name = "Oreo"
        Me.Oreo.Size = New System.Drawing.Size(100, 20)
        Me.Oreo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chocolate Chip"
        '
        'ChocolateChip
        '
        Me.ChocolateChip.Location = New System.Drawing.Point(127, 56)
        Me.ChocolateChip.Name = "ChocolateChip"
        Me.ChocolateChip.Size = New System.Drawing.Size(100, 20)
        Me.ChocolateChip.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 379)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 63)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ribbon"
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(60, 583)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(180, 69)
        Me.Calculate.TabIndex = 3
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(471, 273)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(0, 13)
        Me.Total.TabIndex = 7
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(101, 19)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(100, 20)
        Me.FirstName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "First Name"
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(101, 45)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(100, 20)
        Me.LastName.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Last Name"
        '
        'Test123
        '
        Me.Test123.Controls.Add(Me.Label7)
        Me.Test123.Controls.Add(Me.LastName)
        Me.Test123.Controls.Add(Me.Label6)
        Me.Test123.Controls.Add(Me.FirstName)
        Me.Test123.Location = New System.Drawing.Point(39, 108)
        Me.Test123.Name = "Test123"
        Me.Test123.Size = New System.Drawing.Size(224, 75)
        Me.Test123.TabIndex = 0
        Me.Test123.TabStop = False
        Me.Test123.Text = "Name"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "No Ribbon"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Ribbon"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 745)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Test123)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Test123.ResumeLayout(False)
        Me.Test123.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Mint As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CreamFilled As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Oreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ChocolateChip As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Calculate As Button
    Friend WithEvents Total As Label
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LastName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Test123 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
