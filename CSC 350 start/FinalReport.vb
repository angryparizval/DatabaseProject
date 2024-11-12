Public Class FinalReport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reportStartForm As New ReportStart()
        reportStartForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim homePage As New HomePage
        homePage.Show()
        Me.Hide()
    End Sub
End Class