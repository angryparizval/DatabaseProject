Public Class AvailableCars
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim homePage As New HomePage
        homePage.Show()
        Me.Hide()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs)
        Dim homePage As New HomePage
        homePage.Show
        Hide
    End Sub
End Class
