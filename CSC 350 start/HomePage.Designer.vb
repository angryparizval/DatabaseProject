<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(218, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 40)
        Label1.TabIndex = 2
        Label1.Text = "Rental Cars Home Page"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(284, 85)
        Button1.Name = "Button1"
        Button1.Size = New Size(185, 27)
        Button1.TabIndex = 3
        Button1.Text = "Create Customer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(284, 137)
        Button2.Name = "Button2"
        Button2.Size = New Size(185, 27)
        Button2.TabIndex = 4
        Button2.Text = "Search Available Cars"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(284, 199)
        Button3.Name = "Button3"
        Button3.Size = New Size(185, 27)
        Button3.TabIndex = 5
        Button3.Text = "Create Rental Agreement"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(284, 258)
        Button4.Name = "Button4"
        Button4.Size = New Size(185, 27)
        Button4.TabIndex = 6
        Button4.Text = "View Report"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "HomePage"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
