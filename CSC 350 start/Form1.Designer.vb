<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(281, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(185, 144)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold)
        Button1.Location = New Point(25, 29)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 29)
        Button1.TabIndex = 2
        Button1.Text = "Back to Home"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 21F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(185, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(410, 47)
        Label2.TabIndex = 3
        Label2.Text = "Rental Agreement Form"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 20)
        Label3.TabIndex = 4
        Label3.Text = "Customer No."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(452, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 7
        Label4.Text = "Vehicle No."
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(541, 144)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(653, 147)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(39, 245)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 20)
        Label6.TabIndex = 10
        Label6.Text = "Insurance Policy No."
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(185, 242)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(281, 242)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 20)
        Label7.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(465, 245)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 20)
        Label8.TabIndex = 13
        Label8.Text = "Store No."
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(541, 245)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(637, 245)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 20)
        Label9.TabIndex = 11
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold)
        Button2.Location = New Point(327, 334)
        Button2.Name = "Button2"
        Button2.Size = New Size(127, 29)
        Button2.TabIndex = 14
        Button2.Text = "Next"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button

End Class
