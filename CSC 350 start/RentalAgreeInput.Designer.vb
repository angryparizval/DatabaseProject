<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalAgreeInput
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
        Button2 = New Button()
        Label8 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold)
        Button2.Location = New Point(302, 259)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 22)
        Button2.TabIndex = 29
        Button2.Text = "Next"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(423, 192)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 15)
        Label8.TabIndex = 28
        Label8.Text = "Store No."
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(489, 192)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(110, 23)
        TextBox4.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(573, 192)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 15)
        Label9.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(50, 192)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 15)
        Label6.TabIndex = 25
        Label6.Text = "Insurance Policy No."
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(178, 190)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(110, 23)
        TextBox3.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(262, 190)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(411, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 22
        Label4.Text = "Vehicle No."
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(489, 116)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(110, 23)
        TextBox2.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(587, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(86, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 19
        Label3.Text = "Customer No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 21F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(178, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(334, 38)
        Label2.TabIndex = 18
        Label2.Text = "Rental Agreement Form"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold)
        Button1.Location = New Point(38, 30)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 22)
        Button1.TabIndex = 17
        Button1.Text = "Back to Home"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(178, 116)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(110, 23)
        TextBox1.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(262, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 15
        ' 
        ' RentalAgreeInput
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(Button2)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "RentalAgreeInput"
        Text = "RentalAgreeInput"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
