Public Class HomePage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim createCustomerForm As New CreateCustomer()
        createCustomerForm.Show()
        Me.Hide() ' Optional: hides the current form
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim availableCarsForm As New AvailableCars()
        availableCarsForm.Show()
        Me.Hide() ' Optional: hides the current form
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rentalAgreeInputForm As New RentalAgreeInput()
        rentalAgreeInputForm.Show()
        Me.Hide() ' Optional: hides the current form
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim reportStartForm As New ReportStart()
        reportStartForm.Show()
        Me.Hide() ' Optional: hides the current form
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class