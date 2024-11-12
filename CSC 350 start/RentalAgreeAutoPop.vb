Public Class RentalAgreeAutoPop
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub RentalAgreeAutoPop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rentalAgreeInputForm As New RentalAgreeInput()
        rentalAgreeInputForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim homePage As New HomePage
        homePage.Show()
        Me.Hide()
    End Sub
End Class