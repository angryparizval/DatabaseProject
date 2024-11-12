<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AvailableCars
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
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.ItemHeight = 15
        ComboBox1.Location = New Point(304, 175)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(225, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(272, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(319, 40)
        Label1.TabIndex = 1
        Label1.Text = "Cars Available to Rent"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(30, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 45)
        Button1.TabIndex = 3
        Button1.Text = "Back to Home Page"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AvailableCars
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(864, 463)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Name = "AvailableCars"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button

End Class
