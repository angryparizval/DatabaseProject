Public Class ReportStart
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim homePage As New HomePage
        homePage.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim finalReportForm As New FinalReport()
        finalReportForm.Show()
        Me.Hide()
    End Sub
End Class